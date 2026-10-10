using System;
using System.Threading;
using System.Xml;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001B3 RID: 435
	public class XmlSubtreeWriter : XmlWriter
	{
		// Token: 0x06000D56 RID: 3414 RVA: 0x00020149 File Offset: 0x0001E349
		public XmlSubtreeWriter(IXmlNode node)
		{
			if (node == null)
			{
				throw Error.ArgumentNull("node");
			}
			this.node = node;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00020168 File Offset: 0x0001E368
		protected override void Dispose(bool managed)
		{
			try
			{
				if (managed)
				{
					this.Reset(WriteState.Closed);
					this.DisposeWriter(ref this.rootWriter);
					this.DisposeWriter(ref this.childWriter);
				}
			}
			finally
			{
				base.Dispose(managed);
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x000201B4 File Offset: 0x0001E3B4
		private void DisposeWriter(ref XmlWriter writer)
		{
			XmlWriter xmlWriter = Interlocked.Exchange<XmlWriter>(ref writer, null);
			if (xmlWriter != null)
			{
				xmlWriter.Close();
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x000201D4 File Offset: 0x0001E3D4
		private XmlWriter RootWriter
		{
			get
			{
				XmlWriter result;
				if ((result = this.rootWriter) == null)
				{
					result = (this.rootWriter = this.node.WriteAttributes());
				}
				return result;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x00020200 File Offset: 0x0001E400
		private XmlWriter ChildWriter
		{
			get
			{
				XmlWriter result;
				if ((result = this.childWriter) == null)
				{
					result = (this.childWriter = this.node.WriteChildren());
				}
				return result;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0002022B File Offset: 0x0001E42B
		private bool IsInRootAttribute
		{
			get
			{
				return this.state == WriteState.Attribute;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00020236 File Offset: 0x0001E436
		private bool IsInRoot
		{
			get
			{
				return this.depth > 0;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00020241 File Offset: 0x0001E441
		private bool IsInChild
		{
			get
			{
				return this.depth > 1;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x0002024C File Offset: 0x0001E44C
		public override WriteState WriteState
		{
			get
			{
				if (!this.IsInRoot || this.state != WriteState.Content)
				{
					return this.state;
				}
				return this.childWriter.WriteState;
			}
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00020271 File Offset: 0x0001E471
		public override void WriteStartDocument(bool standalone)
		{
			this.WriteStartDocument();
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00020279 File Offset: 0x0001E479
		public override void WriteStartDocument()
		{
			this.RequireState(WriteState.Start);
			this.state = WriteState.Prolog;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00020289 File Offset: 0x0001E489
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			this.RequireState(WriteState.Start, WriteState.Prolog);
			this.state = WriteState.Prolog;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0002029C File Offset: 0x0001E49C
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			try
			{
				if (this.IsInRoot)
				{
					this.ChildWriter.WriteStartElement(prefix, localName, ns);
					this.state = WriteState.Content;
				}
				else
				{
					this.RequireState(WriteState.Start, WriteState.Prolog);
					this.node.Clear();
					this.state = WriteState.Element;
				}
				this.depth++;
			}
			catch
			{
				this.Reset(WriteState.Error);
				throw;
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0002030C File Offset: 0x0001E50C
		private void WriteEndElement(Action<XmlWriter> action)
		{
			try
			{
				if (this.IsInChild)
				{
					action(this.ChildWriter);
					this.state = WriteState.Content;
				}
				else
				{
					this.RequireState(WriteState.Element, WriteState.Content);
					this.state = WriteState.Prolog;
				}
				this.depth--;
			}
			catch
			{
				this.Reset(WriteState.Error);
				throw;
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00020370 File Offset: 0x0001E570
		public override void WriteEndElement()
		{
			this.WriteEndElement(delegate(XmlWriter w)
			{
				w.WriteEndElement();
			});
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00020397 File Offset: 0x0001E597
		public override void WriteFullEndElement()
		{
			this.WriteEndElement(delegate(XmlWriter w)
			{
				w.WriteFullEndElement();
			});
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x000203C0 File Offset: 0x0001E5C0
		private void WriteAttribute(Action<XmlWriter> action, WriteState entryState, WriteState exitState)
		{
			try
			{
				if (this.IsInChild)
				{
					action(this.ChildWriter);
				}
				else
				{
					this.RequireState(entryState);
					action(this.RootWriter);
					this.state = exitState;
				}
			}
			catch
			{
				this.Reset(WriteState.Error);
				throw;
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0002041C File Offset: 0x0001E61C
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			this.WriteAttribute(delegate(XmlWriter w)
			{
				w.WriteStartAttribute(prefix, localName, ns);
			}, WriteState.Element, WriteState.Attribute);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00020458 File Offset: 0x0001E658
		public override void WriteEndAttribute()
		{
			this.WriteAttribute(delegate(XmlWriter w)
			{
				w.WriteEndAttribute();
			}, WriteState.Attribute, WriteState.Element);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00020484 File Offset: 0x0001E684
		private void WriteElementOrAttributeContent(Action<XmlWriter> action)
		{
			try
			{
				if (this.IsInChild)
				{
					action(this.ChildWriter);
				}
				else if (this.IsInRootAttribute)
				{
					action(this.RootWriter);
				}
				else
				{
					this.RequireState(WriteState.Element, WriteState.Content);
					action(this.ChildWriter);
					this.state = WriteState.Content;
				}
			}
			catch
			{
				this.Reset(WriteState.Error);
				throw;
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x000204F4 File Offset: 0x0001E6F4
		public override void WriteString(string text)
		{
			this.WriteElementOrAttributeContent(delegate(XmlWriter w)
			{
				w.WriteString(text);
			});
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00020520 File Offset: 0x0001E720
		public override void WriteCharEntity(char ch)
		{
			this.WriteElementOrAttributeContent(delegate(XmlWriter w)
			{
				w.WriteCharEntity(ch);
			});
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0002054C File Offset: 0x0001E74C
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			this.WriteElementOrAttributeContent(delegate(XmlWriter w)
			{
				w.WriteSurrogateCharEntity(lowChar, highChar);
			});
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00020580 File Offset: 0x0001E780
		public override void WriteEntityRef(string name)
		{
			this.WriteElementOrAttributeContent(delegate(XmlWriter w)
			{
				w.WriteEntityRef(name);
			});
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000205AC File Offset: 0x0001E7AC
		public override void WriteChars(char[] buffer, int index, int count)
		{
			this.WriteElementOrAttributeContent(delegate(XmlWriter w)
			{
				w.WriteChars(buffer, index, count);
			});
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x000205E8 File Offset: 0x0001E7E8
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			this.WriteElementOrAttributeContent(delegate(XmlWriter w)
			{
				w.WriteBase64(buffer, index, count);
			});
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00020624 File Offset: 0x0001E824
		public override void WriteRaw(string data)
		{
			this.WriteElementOrAttributeContent(delegate(XmlWriter w)
			{
				w.WriteRaw(data);
			});
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00020650 File Offset: 0x0001E850
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			this.WriteElementOrAttributeContent(delegate(XmlWriter w)
			{
				w.WriteRaw(buffer, index, count);
			});
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0002068C File Offset: 0x0001E88C
		private void WriteElementContent(Action<XmlWriter> action)
		{
			try
			{
				this.RequireState(WriteState.Element, WriteState.Content);
				action(this.ChildWriter);
				this.state = WriteState.Content;
			}
			catch
			{
				this.Reset(WriteState.Error);
				throw;
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x000206D0 File Offset: 0x0001E8D0
		public override void WriteCData(string text)
		{
			this.WriteElementContent(delegate(XmlWriter w)
			{
				w.WriteCData(text);
			});
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x000206FC File Offset: 0x0001E8FC
		public override void WriteProcessingInstruction(string name, string text)
		{
			this.WriteElementContent(delegate(XmlWriter w)
			{
				w.WriteProcessingInstruction(name, text);
			});
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00020730 File Offset: 0x0001E930
		public override void WriteComment(string text)
		{
			this.WriteElementContent(delegate(XmlWriter w)
			{
				w.WriteComment(text);
			});
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0002075C File Offset: 0x0001E95C
		public override void WriteWhitespace(string ws)
		{
			this.WriteElementContent(delegate(XmlWriter w)
			{
				w.WriteWhitespace(ws);
			});
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00020788 File Offset: 0x0001E988
		private void WithWriters(Action<XmlWriter> action, bool worksIfClosed = false, WriteState? resetTo = null)
		{
			try
			{
				if (!worksIfClosed)
				{
					this.RequireNotClosed();
				}
				if (this.rootWriter != null)
				{
					action(this.rootWriter);
				}
				if (this.childWriter != null)
				{
					action(this.childWriter);
				}
				if (resetTo != null)
				{
					this.Reset(resetTo.Value);
				}
			}
			catch
			{
				this.Reset(WriteState.Error);
				throw;
			}
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x000207F8 File Offset: 0x0001E9F8
		public override void Flush()
		{
			this.WithWriters(delegate(XmlWriter w)
			{
				w.Flush();
			}, false, null);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00020834 File Offset: 0x0001EA34
		public override void WriteEndDocument()
		{
			this.WithWriters(delegate(XmlWriter w)
			{
				w.WriteEndDocument();
			}, false, new WriteState?(WriteState.Start));
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00020862 File Offset: 0x0001EA62
		public override void Close()
		{
			this.WithWriters(delegate(XmlWriter w)
			{
				w.Close();
			}, true, new WriteState?(WriteState.Closed));
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00020890 File Offset: 0x0001EA90
		public override string LookupPrefix(string ns)
		{
			string result;
			try
			{
				string text;
				result = ((this.childWriter != null && (text = this.childWriter.LookupPrefix(ns)) != null) ? text : ((this.rootWriter != null && (text = this.rootWriter.LookupPrefix(ns)) != null) ? text : null));
			}
			catch
			{
				this.Reset(WriteState.Error);
				throw;
			}
			return result;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x000208F4 File Offset: 0x0001EAF4
		private void RequireNotClosed()
		{
			if (this.state == WriteState.Closed || this.state == WriteState.Error)
			{
				throw Error.InvalidOperation();
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0002090E File Offset: 0x0001EB0E
		private void RequireState(WriteState state)
		{
			if (this.state != state)
			{
				throw Error.InvalidOperation();
			}
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0002091F File Offset: 0x0001EB1F
		private void RequireState(WriteState state1, WriteState state2)
		{
			if (this.state != state1 && this.state != state2)
			{
				throw Error.InvalidOperation();
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00020939 File Offset: 0x0001EB39
		private void Reset(WriteState state)
		{
			this.depth = 0;
			this.state = state;
		}

		// Token: 0x040002E6 RID: 742
		private readonly IXmlNode node;

		// Token: 0x040002E7 RID: 743
		private XmlWriter rootWriter;

		// Token: 0x040002E8 RID: 744
		private XmlWriter childWriter;

		// Token: 0x040002E9 RID: 745
		private WriteState state;

		// Token: 0x040002EA RID: 746
		private int depth;
	}
}
