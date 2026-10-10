using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Указывает порядок операций матричных преобразований.</summary>
	// Token: 0x02000148 RID: 328
	public enum MatrixOrder
	{
		/// <summary>Новое преобразование применяется перед старым.</summary>
		// Token: 0x04000B3D RID: 2877
		Prepend,
		/// <summary>Новое преобразование применяется после старого.</summary>
		// Token: 0x04000B3E RID: 2878
		Append
	}
}
