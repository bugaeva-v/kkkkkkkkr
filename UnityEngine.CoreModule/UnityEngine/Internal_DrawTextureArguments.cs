using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200013C RID: 316
	[VisibleToOtherModules(new string[]
	{
		"UnityEngine.IMGUIModule"
	})]
	internal struct Internal_DrawTextureArguments
	{
		// Token: 0x04000402 RID: 1026
		public Rect screenRect;

		// Token: 0x04000403 RID: 1027
		public Rect sourceRect;

		// Token: 0x04000404 RID: 1028
		public int leftBorder;

		// Token: 0x04000405 RID: 1029
		public int rightBorder;

		// Token: 0x04000406 RID: 1030
		public int topBorder;

		// Token: 0x04000407 RID: 1031
		public int bottomBorder;

		// Token: 0x04000408 RID: 1032
		public Color leftBorderColor;

		// Token: 0x04000409 RID: 1033
		public Color rightBorderColor;

		// Token: 0x0400040A RID: 1034
		public Color topBorderColor;

		// Token: 0x0400040B RID: 1035
		public Color bottomBorderColor;

		// Token: 0x0400040C RID: 1036
		public Color color;

		// Token: 0x0400040D RID: 1037
		public Vector4 borderWidths;

		// Token: 0x0400040E RID: 1038
		public Vector4 cornerRadiuses;

		// Token: 0x0400040F RID: 1039
		public bool smoothCorners;

		// Token: 0x04000410 RID: 1040
		public int pass;

		// Token: 0x04000411 RID: 1041
		public Texture texture;

		// Token: 0x04000412 RID: 1042
		public Material mat;
	}
}
