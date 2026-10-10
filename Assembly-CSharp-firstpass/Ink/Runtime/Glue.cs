using System;

namespace Ink.Runtime
{
	// Token: 0x02000026 RID: 38
	internal class Glue : Object
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00009BE1 File Offset: 0x00007DE1
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00009BE9 File Offset: 0x00007DE9
		public GlueType glueType { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00009BF2 File Offset: 0x00007DF2
		public bool isLeft
		{
			get
			{
				return this.glueType == GlueType.Left;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00009BFD File Offset: 0x00007DFD
		public bool isBi
		{
			get
			{
				return this.glueType == GlueType.Bidirectional;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00009C08 File Offset: 0x00007E08
		public bool isRight
		{
			get
			{
				return this.glueType == GlueType.Right;
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00009C13 File Offset: 0x00007E13
		public Glue(GlueType type)
		{
			this.glueType = type;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00009C24 File Offset: 0x00007E24
		public override string ToString()
		{
			switch (this.glueType)
			{
			case GlueType.Bidirectional:
				return "BidirGlue";
			case GlueType.Left:
				return "LeftGlue";
			case GlueType.Right:
				return "RightGlue";
			default:
				return "UnexpectedGlueType";
			}
		}
	}
}
