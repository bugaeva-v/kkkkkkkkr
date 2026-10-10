using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Указывает, как накладывается текстура или градиент, когда она меньше, чем заполняемая область.</summary>
	// Token: 0x02000153 RID: 339
	public enum WrapMode
	{
		/// <summary>Производится наложение градиента или текстуры.</summary>
		// Token: 0x04000B6E RID: 2926
		Tile,
		/// <summary>Разворачивает текстуру или градиент горизонтально, а затем производит их наложение.</summary>
		// Token: 0x04000B6F RID: 2927
		TileFlipX,
		/// <summary>Разворачивает текстуру или градиент вертикально, а затем производит их наложение.</summary>
		// Token: 0x04000B70 RID: 2928
		TileFlipY,
		/// <summary>Разворачивает текстуру или градиент горизонтально и вертикально, а затем производит их наложение.</summary>
		// Token: 0x04000B71 RID: 2929
		TileFlipXY,
		/// <summary>Не производится наложение текстуры или градиента.</summary>
		// Token: 0x04000B72 RID: 2930
		Clamp
	}
}
