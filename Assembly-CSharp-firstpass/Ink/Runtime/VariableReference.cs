using System;

namespace Ink.Runtime
{
	// Token: 0x02000043 RID: 67
	internal class VariableReference : Object
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0001230F File Offset: 0x0001050F
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00012317 File Offset: 0x00010517
		public string name { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00012320 File Offset: 0x00010520
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00012328 File Offset: 0x00010528
		public Path pathForCount { get; set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00012331 File Offset: 0x00010531
		internal Container containerForCount
		{
			get
			{
				return base.ResolvePath(this.pathForCount) as Container;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00012344 File Offset: 0x00010544
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0001235C File Offset: 0x0001055C
		public string pathStringForCount
		{
			get
			{
				if (this.pathForCount == null)
				{
					return null;
				}
				return base.CompactPathString(this.pathForCount);
			}
			set
			{
				if (value == null)
				{
					this.pathForCount = null;
					return;
				}
				this.pathForCount = new Path(value);
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00012375 File Offset: 0x00010575
		public VariableReference(string name)
		{
			this.name = name;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00012384 File Offset: 0x00010584
		public VariableReference()
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0001238C File Offset: 0x0001058C
		public override string ToString()
		{
			if (this.name != null)
			{
				return string.Format("var({0})", this.name);
			}
			string pathStringForCount = this.pathStringForCount;
			return string.Format("read_count({0})", pathStringForCount);
		}
	}
}
