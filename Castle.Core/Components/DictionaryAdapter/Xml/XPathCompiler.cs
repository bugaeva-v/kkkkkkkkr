using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.XPath;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000182 RID: 386
	public static class XPathCompiler
	{
		// Token: 0x06000BFC RID: 3068 RVA: 0x0001CEB0 File Offset: 0x0001B0B0
		public static CompiledXPath Compile(string path)
		{
			if (path == null)
			{
				throw Error.ArgumentNull("path");
			}
			CompiledXPath compiledXPath = new CompiledXPath();
			compiledXPath.Path = XPathExpression.Compile(path);
			if (!XPathCompiler.ParsePath(new XPathCompiler.Tokenizer(path), compiledXPath))
			{
				compiledXPath.MakeNotCreatable();
			}
			compiledXPath.Prepare();
			return compiledXPath;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0001CEF8 File Offset: 0x0001B0F8
		private static bool ParsePath(XPathCompiler.Tokenizer source, CompiledXPath path)
		{
			CompiledXPathStep compiledXPathStep = null;
			while (XPathCompiler.ParseStep(source, path, ref compiledXPathStep))
			{
				if (source.Token == XPathCompiler.Token.EndOfInput)
				{
					return true;
				}
				if (!XPathCompiler.Consume(source, XPathCompiler.Token.StepSeparator))
				{
					return false;
				}
				if (compiledXPathStep.IsAttribute)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0001CF34 File Offset: 0x0001B134
		private static bool ParseStep(XPathCompiler.Tokenizer source, CompiledXPath path, ref CompiledXPathStep step)
		{
			CompiledXPathStep compiledXPathStep = step;
			int index = source.Index;
			if (!XPathCompiler.ParseNodeCore<CompiledXPathStep>(source, XPathCompiler.StepFactory, ref step))
			{
				return false;
			}
			if (step != compiledXPathStep)
			{
				string consumedText = source.GetConsumedText(index);
				step.Path = XPathExpression.Compile(consumedText);
				if (compiledXPathStep == null)
				{
					path.FirstStep = step;
				}
				else
				{
					XPathCompiler.LinkNodes(compiledXPathStep, step);
				}
				int depth = path.Depth;
				path.Depth = depth + 1;
			}
			return true;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0001CF9C File Offset: 0x0001B19C
		private static bool ParseNodeCore<TNode>(XPathCompiler.Tokenizer source, Func<TNode> factory, ref TNode node) where TNode : CompiledXPathNode
		{
			if (!XPathCompiler.Consume(source, XPathCompiler.Token.SelfReference))
			{
				node = factory();
				if (XPathCompiler.Consume(source, XPathCompiler.Token.AttributeStart))
				{
					node.IsAttribute = true;
				}
				if (!XPathCompiler.ParseQualifiedName(source, node))
				{
					return false;
				}
			}
			if (node != null)
			{
				return XPathCompiler.ParsePredicateList(source, node);
			}
			return source.Token != XPathCompiler.Token.PredicateStart;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0001D014 File Offset: 0x0001B214
		private static bool ParsePredicateList(XPathCompiler.Tokenizer source, CompiledXPathNode parent)
		{
			while (XPathCompiler.Consume(source, XPathCompiler.Token.PredicateStart))
			{
				if (!XPathCompiler.ParsePredicate(source, parent))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0001D02D File Offset: 0x0001B22D
		private static bool ParsePredicate(XPathCompiler.Tokenizer source, CompiledXPathNode parent)
		{
			return XPathCompiler.ParseAndExpression(source, parent) && XPathCompiler.Consume(source, XPathCompiler.Token.PredicateEnd);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0001D046 File Offset: 0x0001B246
		private static bool ParseAndExpression(XPathCompiler.Tokenizer source, CompiledXPathNode parent)
		{
			while (XPathCompiler.ParseExpression(source, parent))
			{
				if (source.Token != XPathCompiler.Token.Name || source.Text != "and")
				{
					return true;
				}
				source.Consume();
			}
			return false;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0001D076 File Offset: 0x0001B276
		private static bool ParseExpression(XPathCompiler.Tokenizer source, CompiledXPathNode parent)
		{
			if (source.Token != XPathCompiler.Token.Name && source.Token != XPathCompiler.Token.AttributeStart && source.Token != XPathCompiler.Token.SelfReference)
			{
				return XPathCompiler.ParseRightToLeftExpression(source, parent);
			}
			return XPathCompiler.ParseLeftToRightExpression(source, parent);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0001D0A8 File Offset: 0x0001B2A8
		private static bool ParseLeftToRightExpression(XPathCompiler.Tokenizer source, CompiledXPathNode parent)
		{
			CompiledXPathNode compiledXPathNode;
			if (!XPathCompiler.ParseNestedPath(source, parent, out compiledXPathNode))
			{
				return false;
			}
			if (!XPathCompiler.Consume(source, XPathCompiler.Token.EqualsOperator))
			{
				return true;
			}
			XPathExpression value;
			if (!XPathCompiler.ParseValue(source, out value))
			{
				return false;
			}
			compiledXPathNode.Value = value;
			return true;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0001D0E4 File Offset: 0x0001B2E4
		private static bool ParseRightToLeftExpression(XPathCompiler.Tokenizer source, CompiledXPathNode parent)
		{
			XPathExpression value;
			if (!XPathCompiler.ParseValue(source, out value))
			{
				return false;
			}
			if (!XPathCompiler.Consume(source, XPathCompiler.Token.EqualsOperator))
			{
				return false;
			}
			CompiledXPathNode compiledXPathNode;
			if (!XPathCompiler.ParseNestedPath(source, parent, out compiledXPathNode))
			{
				return false;
			}
			compiledXPathNode.Value = value;
			return true;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0001D120 File Offset: 0x0001B320
		private static bool ParseNestedPath(XPathCompiler.Tokenizer source, CompiledXPathNode parent, out CompiledXPathNode node)
		{
			node = null;
			while (XPathCompiler.ParseNode(source, parent, ref node))
			{
				if (!XPathCompiler.Consume(source, XPathCompiler.Token.StepSeparator))
				{
					if (node == null)
					{
						IList<CompiledXPathNode> dependencies = parent.Dependencies;
						if (dependencies.Count != 0)
						{
							return false;
						}
						ICollection<CompiledXPathNode> collection = dependencies;
						CompiledXPathNode item;
						node = (item = XPathCompiler.NodeFactory());
						collection.Add(item);
					}
					return true;
				}
				if (node.IsAttribute)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0001D17C File Offset: 0x0001B37C
		private static bool ParseNode(XPathCompiler.Tokenizer source, CompiledXPathNode parent, ref CompiledXPathNode node)
		{
			CompiledXPathNode compiledXPathNode = node;
			if (!XPathCompiler.ParseNodeCore<CompiledXPathNode>(source, XPathCompiler.NodeFactory, ref node))
			{
				return false;
			}
			if (node != compiledXPathNode)
			{
				if (compiledXPathNode == null)
				{
					parent.Dependencies.Add(node);
				}
				else
				{
					XPathCompiler.LinkNodes(compiledXPathNode, node);
				}
			}
			return true;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0001D1BC File Offset: 0x0001B3BC
		private static bool ParseValue(XPathCompiler.Tokenizer source, out XPathExpression value)
		{
			int index = source.Index;
			if (!XPathCompiler.Consume(source, XPathCompiler.Token.StringLiteral) && (!XPathCompiler.Consume(source, XPathCompiler.Token.VariableStart) || !XPathCompiler.ParseQualifiedName(source, null)))
			{
				return Try.Failure<XPathExpression>(out value);
			}
			string consumedText = source.GetConsumedText(index);
			value = XPathExpression.Compile(consumedText);
			return true;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0001D20C File Offset: 0x0001B40C
		private static bool ParseQualifiedName(XPathCompiler.Tokenizer source, CompiledXPathNode node)
		{
			string text;
			if (!XPathCompiler.ParseName(source, out text))
			{
				return false;
			}
			if (!XPathCompiler.Consume(source, XPathCompiler.Token.NameSeparator))
			{
				if (node != null)
				{
					node.LocalName = text;
				}
				return true;
			}
			string localName;
			if (!XPathCompiler.ParseName(source, out localName))
			{
				return false;
			}
			if (node != null)
			{
				node.Prefix = text;
				node.LocalName = localName;
			}
			return true;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0001D258 File Offset: 0x0001B458
		private static bool ParseName(XPathCompiler.Tokenizer source, out string name)
		{
			if (source.Token != XPathCompiler.Token.Name)
			{
				return Try.Failure<string>(out name);
			}
			name = source.Text;
			source.Consume();
			return true;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0001D278 File Offset: 0x0001B478
		private static bool Consume(XPathCompiler.Tokenizer source, XPathCompiler.Token token)
		{
			if (source.Token != token)
			{
				return false;
			}
			source.Consume();
			return true;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0001D28C File Offset: 0x0001B48C
		private static void LinkNodes(CompiledXPathNode previous, CompiledXPathNode next)
		{
			previous.NextNode = next;
			next.PreviousNode = previous;
		}

		// Token: 0x04000289 RID: 649
		private static readonly Func<CompiledXPathNode> NodeFactory = () => new CompiledXPathNode();

		// Token: 0x0400028A RID: 650
		private static readonly Func<CompiledXPathStep> StepFactory = () => new CompiledXPathStep();

		// Token: 0x02000223 RID: 547
		private enum Token
		{
			// Token: 0x04000436 RID: 1078
			Name,
			// Token: 0x04000437 RID: 1079
			SelfReference,
			// Token: 0x04000438 RID: 1080
			StepSeparator,
			// Token: 0x04000439 RID: 1081
			NameSeparator,
			// Token: 0x0400043A RID: 1082
			AttributeStart,
			// Token: 0x0400043B RID: 1083
			VariableStart,
			// Token: 0x0400043C RID: 1084
			EqualsOperator,
			// Token: 0x0400043D RID: 1085
			PredicateStart,
			// Token: 0x0400043E RID: 1086
			PredicateEnd,
			// Token: 0x0400043F RID: 1087
			StringLiteral,
			// Token: 0x04000440 RID: 1088
			EndOfInput,
			// Token: 0x04000441 RID: 1089
			Error
		}

		// Token: 0x02000224 RID: 548
		private class Tokenizer
		{
			// Token: 0x06000F35 RID: 3893 RVA: 0x00023E47 File Offset: 0x00022047
			public Tokenizer(string input)
			{
				this.input = input;
				this.state = XPathCompiler.Tokenizer.State.Initial;
				this.index = -1;
				this.Consume();
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x06000F36 RID: 3894 RVA: 0x00023E6A File Offset: 0x0002206A
			public XPathCompiler.Token Token
			{
				get
				{
					return this.token;
				}
			}

			// Token: 0x170002BD RID: 701
			// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00023E72 File Offset: 0x00022072
			public string Text
			{
				get
				{
					return this.input.Substring(this.start, this.index - this.start + 1);
				}
			}

			// Token: 0x06000F38 RID: 3896 RVA: 0x00023E94 File Offset: 0x00022094
			public string GetConsumedText(int start)
			{
				return this.input.Substring(start, this.prior - start + 1);
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x06000F39 RID: 3897 RVA: 0x00023EAC File Offset: 0x000220AC
			public int Index
			{
				get
				{
					return this.start;
				}
			}

			// Token: 0x06000F3A RID: 3898 RVA: 0x00023EB4 File Offset: 0x000220B4
			public void Consume()
			{
				this.prior = this.index;
				for (;;)
				{
					char c = this.ReadChar();
					switch (this.state)
					{
					case XPathCompiler.Tokenizer.State.Initial:
						this.start = this.index;
						if (c <= '.')
						{
							if (c <= '"')
							{
								if (c == '\0')
								{
									goto IL_DA;
								}
								if (c == '"')
								{
									this.state = XPathCompiler.Tokenizer.State.DoubleQuoteString;
									break;
								}
							}
							else
							{
								if (c == '$')
								{
									goto IL_BA;
								}
								if (c == '\'')
								{
									this.state = XPathCompiler.Tokenizer.State.SingleQuoteString;
									break;
								}
								if (c == '.')
								{
									goto IL_9A;
								}
							}
						}
						else if (c <= '=')
						{
							if (c == '/')
							{
								goto IL_A2;
							}
							if (c == ':')
							{
								goto IL_AA;
							}
							if (c == '=')
							{
								goto IL_C2;
							}
						}
						else
						{
							if (c == '@')
							{
								goto IL_B2;
							}
							if (c == '[')
							{
								goto IL_CA;
							}
							if (c == ']')
							{
								goto IL_D2;
							}
						}
						if (XPathCompiler.Tokenizer.IsNameStartChar(c))
						{
							this.state = XPathCompiler.Tokenizer.State.Name;
						}
						else if (!XPathCompiler.Tokenizer.IsWhitespace(c))
						{
							this.state = XPathCompiler.Tokenizer.State.Failed;
						}
						break;
					case XPathCompiler.Tokenizer.State.Name:
						if (!XPathCompiler.Tokenizer.IsNameChar(c))
						{
							goto Block_18;
						}
						break;
					case XPathCompiler.Tokenizer.State.SingleQuoteString:
						if (c == '\'')
						{
							goto Block_19;
						}
						break;
					case XPathCompiler.Tokenizer.State.DoubleQuoteString:
						if (c == '"')
						{
							goto Block_20;
						}
						break;
					case XPathCompiler.Tokenizer.State.Failed:
						goto IL_176;
					}
				}
				IL_9A:
				this.token = XPathCompiler.Token.SelfReference;
				return;
				IL_A2:
				this.token = XPathCompiler.Token.StepSeparator;
				return;
				IL_AA:
				this.token = XPathCompiler.Token.NameSeparator;
				return;
				IL_B2:
				this.token = XPathCompiler.Token.AttributeStart;
				return;
				IL_BA:
				this.token = XPathCompiler.Token.VariableStart;
				return;
				IL_C2:
				this.token = XPathCompiler.Token.EqualsOperator;
				return;
				IL_CA:
				this.token = XPathCompiler.Token.PredicateStart;
				return;
				IL_D2:
				this.token = XPathCompiler.Token.PredicateEnd;
				return;
				IL_DA:
				this.token = XPathCompiler.Token.EndOfInput;
				return;
				Block_18:
				this.RewindChar();
				this.token = XPathCompiler.Token.Name;
				this.state = XPathCompiler.Tokenizer.State.Initial;
				return;
				Block_19:
				this.token = XPathCompiler.Token.StringLiteral;
				this.state = XPathCompiler.Tokenizer.State.Initial;
				return;
				Block_20:
				this.token = XPathCompiler.Token.StringLiteral;
				this.state = XPathCompiler.Tokenizer.State.Initial;
				return;
				IL_176:
				this.token = XPathCompiler.Token.Error;
			}

			// Token: 0x06000F3B RID: 3899 RVA: 0x00024040 File Offset: 0x00022240
			private char ReadChar()
			{
				int num = this.index + 1;
				this.index = num;
				if (num >= this.input.Length)
				{
					return '\0';
				}
				return this.input[this.index];
			}

			// Token: 0x06000F3C RID: 3900 RVA: 0x0002407E File Offset: 0x0002227E
			private void RewindChar()
			{
				this.index--;
			}

			// Token: 0x06000F3D RID: 3901 RVA: 0x0002408E File Offset: 0x0002228E
			private static bool IsWhitespace(char c)
			{
				return XmlConvert.IsWhitespaceChar(c);
			}

			// Token: 0x06000F3E RID: 3902 RVA: 0x00024096 File Offset: 0x00022296
			private static bool IsNameStartChar(char c)
			{
				return XmlConvert.IsStartNCNameChar(c);
			}

			// Token: 0x06000F3F RID: 3903 RVA: 0x0002409E File Offset: 0x0002229E
			private static bool IsNameChar(char c)
			{
				return XmlConvert.IsNCNameChar(c);
			}

			// Token: 0x04000442 RID: 1090
			private readonly string input;

			// Token: 0x04000443 RID: 1091
			private XPathCompiler.Tokenizer.State state;

			// Token: 0x04000444 RID: 1092
			private XPathCompiler.Token token;

			// Token: 0x04000445 RID: 1093
			private int index;

			// Token: 0x04000446 RID: 1094
			private int start;

			// Token: 0x04000447 RID: 1095
			private int prior;

			// Token: 0x0200023B RID: 571
			private enum State
			{
				// Token: 0x04000474 RID: 1140
				Initial,
				// Token: 0x04000475 RID: 1141
				Name,
				// Token: 0x04000476 RID: 1142
				SingleQuoteString,
				// Token: 0x04000477 RID: 1143
				DoubleQuoteString,
				// Token: 0x04000478 RID: 1144
				Failed
			}
		}
	}
}
