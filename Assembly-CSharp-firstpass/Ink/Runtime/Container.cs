using System;
using System.Collections.Generic;
using System.Text;

namespace Ink.Runtime
{
	// Token: 0x02000021 RID: 33
	internal class Container : Object, INamedContent
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00008F0C File Offset: 0x0000710C
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00008F14 File Offset: 0x00007114
		public string name { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00008F1D File Offset: 0x0000711D
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00008F25 File Offset: 0x00007125
		public List<Object> content
		{
			get
			{
				return this._content;
			}
			set
			{
				this.AddContent(value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00008F2E File Offset: 0x0000712E
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00008F36 File Offset: 0x00007136
		public Dictionary<string, INamedContent> namedContent { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00008F40 File Offset: 0x00007140
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00009014 File Offset: 0x00007214
		public Dictionary<string, Object> namedOnlyContent
		{
			get
			{
				Dictionary<string, Object> dictionary = new Dictionary<string, Object>();
				foreach (KeyValuePair<string, INamedContent> keyValuePair in this.namedContent)
				{
					dictionary[keyValuePair.Key] = (Object)keyValuePair.Value;
				}
				foreach (Object @object in this.content)
				{
					INamedContent namedContent = @object as INamedContent;
					if (namedContent != null && namedContent.hasValidName)
					{
						dictionary.Remove(namedContent.name);
					}
				}
				if (dictionary.Count == 0)
				{
					dictionary = null;
				}
				return dictionary;
			}
			set
			{
				Dictionary<string, Object> namedOnlyContent = this.namedOnlyContent;
				if (namedOnlyContent != null)
				{
					foreach (KeyValuePair<string, Object> keyValuePair in namedOnlyContent)
					{
						this.namedContent.Remove(keyValuePair.Key);
					}
				}
				if (value == null)
				{
					return;
				}
				foreach (KeyValuePair<string, Object> keyValuePair2 in value)
				{
					INamedContent namedContent = keyValuePair2.Value as INamedContent;
					if (namedContent != null)
					{
						this.AddToNamedContentOnly(namedContent);
					}
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000090CC File Offset: 0x000072CC
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000090D4 File Offset: 0x000072D4
		public bool visitsShouldBeCounted { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000090DD File Offset: 0x000072DD
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000090E5 File Offset: 0x000072E5
		public bool turnIndexShouldBeCounted { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000090EE File Offset: 0x000072EE
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000090F6 File Offset: 0x000072F6
		public bool countingAtStartOnly { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00009100 File Offset: 0x00007300
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000913A File Offset: 0x0000733A
		public int countFlags
		{
			get
			{
				Container.CountFlags countFlags = (Container.CountFlags)0;
				if (this.visitsShouldBeCounted)
				{
					countFlags |= Container.CountFlags.Visits;
				}
				if (this.turnIndexShouldBeCounted)
				{
					countFlags |= Container.CountFlags.Turns;
				}
				if (this.countingAtStartOnly)
				{
					countFlags |= Container.CountFlags.CountStartOnly;
				}
				if (countFlags == Container.CountFlags.CountStartOnly)
				{
					countFlags = (Container.CountFlags)0;
				}
				return (int)countFlags;
			}
			set
			{
				if ((value & 1) > 0)
				{
					this.visitsShouldBeCounted = true;
				}
				if ((value & 2) > 0)
				{
					this.turnIndexShouldBeCounted = true;
				}
				if ((value & 4) > 0)
				{
					this.countingAtStartOnly = true;
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00009163 File Offset: 0x00007363
		public bool hasValidName
		{
			get
			{
				return this.name != null && this.name.Length > 0;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000917D File Offset: 0x0000737D
		public Path pathToFirstLeafContent
		{
			get
			{
				if (this._pathToFirstLeafContent == null)
				{
					this._pathToFirstLeafContent = base.path.PathByAppendingPath(this.internalPathToFirstLeafContent);
				}
				return this._pathToFirstLeafContent;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000091A4 File Offset: 0x000073A4
		private Path internalPathToFirstLeafContent
		{
			get
			{
				List<Path.Component> list = new List<Path.Component>();
				Container container = this;
				while (container != null)
				{
					if (container.content.Count > 0)
					{
						list.Add(new Path.Component(0));
						container = (container.content[0] as Container);
					}
				}
				return new Path(list, false);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000091F7 File Offset: 0x000073F7
		public Container()
		{
			this._content = new List<Object>();
			this.namedContent = new Dictionary<string, INamedContent>();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00009218 File Offset: 0x00007418
		public void AddContent(Object contentObj)
		{
			this.content.Add(contentObj);
			if (contentObj.parent)
			{
				string str = "content is already in ";
				Object parent = contentObj.parent;
				throw new Exception(str + ((parent != null) ? parent.ToString() : null));
			}
			contentObj.parent = this;
			this.TryAddNamedContent(contentObj);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00009270 File Offset: 0x00007470
		public void AddContent(IList<Object> contentList)
		{
			foreach (Object contentObj in contentList)
			{
				this.AddContent(contentObj);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000092B8 File Offset: 0x000074B8
		public void InsertContent(Object contentObj, int index)
		{
			this.content.Insert(index, contentObj);
			if (contentObj.parent)
			{
				string str = "content is already in ";
				Object parent = contentObj.parent;
				throw new Exception(str + ((parent != null) ? parent.ToString() : null));
			}
			contentObj.parent = this;
			this.TryAddNamedContent(contentObj);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00009310 File Offset: 0x00007510
		public void TryAddNamedContent(Object contentObj)
		{
			INamedContent namedContent = contentObj as INamedContent;
			if (namedContent != null && namedContent.hasValidName)
			{
				this.AddToNamedContentOnly(namedContent);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00009336 File Offset: 0x00007536
		public void AddToNamedContentOnly(INamedContent namedContentObj)
		{
			((Object)namedContentObj).parent = this;
			this.namedContent[namedContentObj.name] = namedContentObj;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00009358 File Offset: 0x00007558
		public void AddContentsOfContainer(Container otherContainer)
		{
			this.content.AddRange(otherContainer.content);
			foreach (Object @object in otherContainer.content)
			{
				@object.parent = this;
				this.TryAddNamedContent(@object);
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000093C4 File Offset: 0x000075C4
		protected Object ContentWithPathComponent(Path.Component component)
		{
			if (component.isIndex)
			{
				if (component.index >= 0 && component.index < this.content.Count)
				{
					return this.content[component.index];
				}
				return null;
			}
			else
			{
				if (component.isParent)
				{
					return base.parent;
				}
				INamedContent namedContent = null;
				if (this.namedContent.TryGetValue(component.name, out namedContent))
				{
					return (Object)namedContent;
				}
				string[] array = new string[5];
				array[0] = "Content '";
				array[1] = component.name;
				array[2] = "' not found at path: '";
				int num = 3;
				Path path = base.path;
				array[num] = ((path != null) ? path.ToString() : null);
				array[4] = "'";
				throw new StoryException(string.Concat(array));
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000947C File Offset: 0x0000767C
		public Object ContentAtPath(Path path, int partialPathLength = -1)
		{
			if (partialPathLength == -1)
			{
				partialPathLength = path.componentCount;
			}
			Container container = this;
			Object @object = this;
			for (int i = 0; i < partialPathLength; i++)
			{
				Path.Component component = path.GetComponent(i);
				if (container == null)
				{
					string str = "Path continued, but previous object wasn't a container: ";
					Object object2 = @object;
					throw new Exception(str + ((object2 != null) ? object2.ToString() : null));
				}
				@object = container.ContentWithPathComponent(component);
				container = (@object as Container);
			}
			return @object;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000094E4 File Offset: 0x000076E4
		public void BuildStringOfHierarchy(StringBuilder sb, int indentation, Object pointedObj)
		{
			Action action = delegate()
			{
				for (int j = 0; j < 4 * indentation; j++)
				{
					sb.Append(" ");
				}
			};
			action();
			sb.Append("[");
			if (this.hasValidName)
			{
				sb.AppendFormat(" ({0})", this.name);
			}
			if (this == pointedObj)
			{
				sb.Append("  <---");
			}
			sb.AppendLine();
			int indentation2 = indentation;
			indentation = indentation2 + 1;
			for (int i = 0; i < this.content.Count; i++)
			{
				Object @object = this.content[i];
				if (@object is Container)
				{
					((Container)@object).BuildStringOfHierarchy(sb, indentation, pointedObj);
				}
				else
				{
					action();
					if (@object is StringValue)
					{
						sb.Append("\"");
						sb.Append(@object.ToString().Replace("\n", "\\n"));
						sb.Append("\"");
					}
					else
					{
						sb.Append(@object.ToString());
					}
				}
				if (i != this.content.Count - 1)
				{
					sb.Append(",");
				}
				if (!(@object is Container) && @object == pointedObj)
				{
					sb.Append("  <---");
				}
				sb.AppendLine();
			}
			Dictionary<string, INamedContent> dictionary = new Dictionary<string, INamedContent>();
			foreach (KeyValuePair<string, INamedContent> keyValuePair in this.namedContent)
			{
				if (!this.content.Contains((Object)keyValuePair.Value))
				{
					dictionary.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			if (dictionary.Count > 0)
			{
				action();
				sb.AppendLine("-- named: --");
				foreach (KeyValuePair<string, INamedContent> keyValuePair2 in dictionary)
				{
					((Container)keyValuePair2.Value).BuildStringOfHierarchy(sb, indentation, pointedObj);
					sb.AppendLine();
				}
			}
			indentation2 = indentation;
			indentation = indentation2 - 1;
			action();
			sb.Append("]");
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000097A8 File Offset: 0x000079A8
		public virtual string BuildStringOfHierarchy()
		{
			StringBuilder stringBuilder = new StringBuilder();
			this.BuildStringOfHierarchy(stringBuilder, 0, null);
			return stringBuilder.ToString();
		}

		// Token: 0x04000117 RID: 279
		private List<Object> _content;

		// Token: 0x0400011C RID: 284
		private Path _pathToFirstLeafContent;

		// Token: 0x02000064 RID: 100
		[Flags]
		public enum CountFlags
		{
			// Token: 0x0400020A RID: 522
			Visits = 1,
			// Token: 0x0400020B RID: 523
			Turns = 2,
			// Token: 0x0400020C RID: 524
			CountStartOnly = 4
		}
	}
}
