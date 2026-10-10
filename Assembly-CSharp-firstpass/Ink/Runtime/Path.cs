using System;
using System.Collections.Generic;
using System.Linq;

namespace Ink.Runtime
{
	// Token: 0x02000030 RID: 48
	internal class Path : IEquatable<Path>
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000D24B File Offset: 0x0000B44B
		public int componentCount
		{
			get
			{
				return this._components.Count;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000D258 File Offset: 0x0000B458
		public Path.Component GetComponent(int index)
		{
			return this._components[index];
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000D266 File Offset: 0x0000B466
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x0000D26E File Offset: 0x0000B46E
		public bool isRelative { get; private set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000D277 File Offset: 0x0000B477
		public Path.Component head
		{
			get
			{
				if (this._components.Count > 0)
				{
					return this._components.First<Path.Component>();
				}
				return null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000D294 File Offset: 0x0000B494
		public Path tail
		{
			get
			{
				if (this._components.Count >= 2)
				{
					return new Path(this._components.GetRange(1, this._components.Count - 1), false);
				}
				return Path.self;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000D2C9 File Offset: 0x0000B4C9
		public int length
		{
			get
			{
				return this._components.Count;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		public Path.Component lastComponent
		{
			get
			{
				int num = this._components.Count - 1;
				if (num >= 0)
				{
					return this._components[num];
				}
				return null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000D308 File Offset: 0x0000B508
		public bool containsNamedComponent
		{
			get
			{
				using (List<Path.Component>.Enumerator enumerator = this._components.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.isIndex)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000D364 File Offset: 0x0000B564
		public Path()
		{
			this._components = new List<Path.Component>();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000D377 File Offset: 0x0000B577
		public Path(Path.Component head, Path tail) : this()
		{
			this._components.Add(head);
			this._components.AddRange(tail._components);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000D39C File Offset: 0x0000B59C
		public Path(IEnumerable<Path.Component> components, bool relative = false) : this()
		{
			this._components.AddRange(components);
			this.isRelative = relative;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000D3B7 File Offset: 0x0000B5B7
		public Path(string componentsString) : this()
		{
			this.componentsString = componentsString;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000D3C6 File Offset: 0x0000B5C6
		public static Path self
		{
			get
			{
				return new Path
				{
					isRelative = true
				};
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000D3D4 File Offset: 0x0000B5D4
		public Path PathByAppendingPath(Path pathToAppend)
		{
			Path path = new Path();
			int num = 0;
			int num2 = 0;
			while (num2 < pathToAppend._components.Count && pathToAppend._components[num2].isParent)
			{
				num++;
				num2++;
			}
			for (int i = 0; i < this._components.Count - num; i++)
			{
				path._components.Add(this._components[i]);
			}
			for (int j = num; j < pathToAppend._components.Count; j++)
			{
				path._components.Add(pathToAppend._components[j]);
			}
			return path;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000D478 File Offset: 0x0000B678
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0000D4C8 File Offset: 0x0000B6C8
		public string componentsString
		{
			get
			{
				if (this._componentsString == null)
				{
					this._componentsString = StringExt.Join<Path.Component>(".", this._components);
					if (this.isRelative)
					{
						this._componentsString = "." + this._componentsString;
					}
				}
				return this._componentsString;
			}
			private set
			{
				this._components.Clear();
				this._componentsString = value;
				if (string.IsNullOrEmpty(this._componentsString))
				{
					return;
				}
				if (this._componentsString[0] == '.')
				{
					this.isRelative = true;
					this._componentsString = this._componentsString.Substring(1);
				}
				else
				{
					this.isRelative = false;
				}
				foreach (string text in this._componentsString.Split('.', StringSplitOptions.None))
				{
					int index;
					if (int.TryParse(text, out index))
					{
						this._components.Add(new Path.Component(index));
					}
					else
					{
						this._components.Add(new Path.Component(text));
					}
				}
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000D576 File Offset: 0x0000B776
		public override string ToString()
		{
			return this.componentsString;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000D57E File Offset: 0x0000B77E
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Path);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000D58C File Offset: 0x0000B78C
		public bool Equals(Path otherPath)
		{
			return otherPath != null && otherPath._components.Count == this._components.Count && otherPath.isRelative == this.isRelative && otherPath._components.SequenceEqual(this._components);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000D5D9 File Offset: 0x0000B7D9
		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		// Token: 0x0400015C RID: 348
		private static string parentId = "^";

		// Token: 0x0400015E RID: 350
		private string _componentsString;

		// Token: 0x0400015F RID: 351
		private List<Path.Component> _components;

		// Token: 0x0200006D RID: 109
		internal class Component : IEquatable<Path.Component>
		{
			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000347 RID: 839 RVA: 0x0001396C File Offset: 0x00011B6C
			// (set) Token: 0x06000348 RID: 840 RVA: 0x00013974 File Offset: 0x00011B74
			public int index { get; private set; }

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000349 RID: 841 RVA: 0x0001397D File Offset: 0x00011B7D
			// (set) Token: 0x0600034A RID: 842 RVA: 0x00013985 File Offset: 0x00011B85
			public string name { get; private set; }

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x0600034B RID: 843 RVA: 0x0001398E File Offset: 0x00011B8E
			public bool isIndex
			{
				get
				{
					return this.index >= 0;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x0600034C RID: 844 RVA: 0x0001399C File Offset: 0x00011B9C
			public bool isParent
			{
				get
				{
					return this.name == Path.parentId;
				}
			}

			// Token: 0x0600034D RID: 845 RVA: 0x000139AE File Offset: 0x00011BAE
			public Component(int index)
			{
				this.index = index;
				this.name = null;
			}

			// Token: 0x0600034E RID: 846 RVA: 0x000139C4 File Offset: 0x00011BC4
			public Component(string name)
			{
				this.name = name;
				this.index = -1;
			}

			// Token: 0x0600034F RID: 847 RVA: 0x000139DA File Offset: 0x00011BDA
			public static Path.Component ToParent()
			{
				return new Path.Component(Path.parentId);
			}

			// Token: 0x06000350 RID: 848 RVA: 0x000139E8 File Offset: 0x00011BE8
			public override string ToString()
			{
				if (this.isIndex)
				{
					return this.index.ToString();
				}
				return this.name;
			}

			// Token: 0x06000351 RID: 849 RVA: 0x00013A12 File Offset: 0x00011C12
			public override bool Equals(object obj)
			{
				return this.Equals(obj as Path.Component);
			}

			// Token: 0x06000352 RID: 850 RVA: 0x00013A20 File Offset: 0x00011C20
			public bool Equals(Path.Component otherComp)
			{
				if (otherComp == null || otherComp.isIndex != this.isIndex)
				{
					return false;
				}
				if (this.isIndex)
				{
					return this.index == otherComp.index;
				}
				return this.name == otherComp.name;
			}

			// Token: 0x06000353 RID: 851 RVA: 0x00013A5D File Offset: 0x00011C5D
			public override int GetHashCode()
			{
				if (this.isIndex)
				{
					return this.index;
				}
				return this.name.GetHashCode();
			}
		}
	}
}
