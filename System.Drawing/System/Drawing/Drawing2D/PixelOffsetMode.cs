using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Задает смещение пикселей в процессе их отрисовки.</summary>
	// Token: 0x0200014D RID: 333
	public enum PixelOffsetMode
	{
		/// <summary>Указывает недопустимый режим.</summary>
		// Token: 0x04000B57 RID: 2903
		Invalid = -1,
		/// <summary>Задает режим, используемый по умолчанию.</summary>
		// Token: 0x04000B58 RID: 2904
		Default,
		/// <summary>Задает быструю низкокачественную отрисовку.</summary>
		// Token: 0x04000B59 RID: 2905
		HighSpeed,
		/// <summary>Задает медленную высококачественную отрисовку.</summary>
		// Token: 0x04000B5A RID: 2906
		HighQuality,
		/// <summary>Задает отсутствие смещения пикселей.</summary>
		// Token: 0x04000B5B RID: 2907
		None,
		/// <summary>Указывает, что для высокоскоростного сглаживания пиксели смещаются как по горизонтали, так и по вертикали на -0,5 единиц.</summary>
		// Token: 0x04000B5C RID: 2908
		Half
	}
}
