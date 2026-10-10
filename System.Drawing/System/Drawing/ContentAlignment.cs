using System;
using System.ComponentModel;
using System.Drawing.Design;

namespace System.Drawing
{
	/// <summary>Устанавливает выравнивание содержимого на поверхности рисунка.</summary>
	// Token: 0x02000069 RID: 105
	[Editor("System.Drawing.Design.ContentAlignmentEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public enum ContentAlignment
	{
		/// <summary>Содержимое выравнивается вертикально по верхнему краю и горизонтально по левому краю.</summary>
		// Token: 0x0400045A RID: 1114
		TopLeft = 1,
		/// <summary>Содержимое выравнивается вертикально по верхнему краю и горизонтально по центру.</summary>
		// Token: 0x0400045B RID: 1115
		TopCenter,
		/// <summary>Содержимое выравнивается вертикально по верхнему краю и горизонтально по правому краю.</summary>
		// Token: 0x0400045C RID: 1116
		TopRight = 4,
		/// <summary>Содержимое выравнивается вертикально по середине и горизонтально по левому краю.</summary>
		// Token: 0x0400045D RID: 1117
		MiddleLeft = 16,
		/// <summary>Содержимое выравнивается вертикально по середине и горизонтально по центру.</summary>
		// Token: 0x0400045E RID: 1118
		MiddleCenter = 32,
		/// <summary>Содержимое выравнивается вертикально по середине и горизонтально по правому краю.</summary>
		// Token: 0x0400045F RID: 1119
		MiddleRight = 64,
		/// <summary>Содержимое выравнивается вертикально по нижнему краю и горизонтально по левому краю.</summary>
		// Token: 0x04000460 RID: 1120
		BottomLeft = 256,
		/// <summary>Содержимое выравнивается вертикально по нижнему краю и горизонтально по центру.</summary>
		// Token: 0x04000461 RID: 1121
		BottomCenter = 512,
		/// <summary>Содержимое выравнивается вертикально по нижнему краю и горизонтально по правому краю.</summary>
		// Token: 0x04000462 RID: 1122
		BottomRight = 1024
	}
}
