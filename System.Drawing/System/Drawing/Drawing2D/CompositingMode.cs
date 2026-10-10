using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Указывает, как исходные цвета объединяются с фоновыми цветами.</summary>
	// Token: 0x02000138 RID: 312
	public enum CompositingMode
	{
		/// <summary>Указывает на то, что цвет при визуализации смешивается с фоновым цветом. Смешивание определяется альфа-составляющей визуализируемого цвета.</summary>
		// Token: 0x04000AC2 RID: 2754
		SourceOver,
		/// <summary>Указывает на то, что цвет при визуализации перекрывает фоновый цвет.</summary>
		// Token: 0x04000AC3 RID: 2755
		SourceCopy
	}
}
