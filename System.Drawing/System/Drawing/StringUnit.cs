using System;

namespace System.Drawing
{
	/// <summary>Указывает единицы измерения для строки текста.</summary>
	// Token: 0x0200003F RID: 63
	public enum StringUnit
	{
		/// <summary>Указывает в качестве единицы измерения единицы международной системы измерения.</summary>
		// Token: 0x04000372 RID: 882
		World,
		/// <summary>Задает в качестве единицы измерения единицы измерения устройства.</summary>
		// Token: 0x04000373 RID: 883
		Display,
		/// <summary>Указывает в качестве единицы измерения пиксель.</summary>
		// Token: 0x04000374 RID: 884
		Pixel,
		/// <summary>Задает в качестве единицы измерения пункт (1/72 дюйма).</summary>
		// Token: 0x04000375 RID: 885
		Point,
		/// <summary>Задает в качестве единицы измерения дюйм.</summary>
		// Token: 0x04000376 RID: 886
		Inch,
		/// <summary>Указывает в качестве единицы измерения 1/300 дюйма.</summary>
		// Token: 0x04000377 RID: 887
		Document,
		/// <summary>Задает в качестве единицы измерения миллиметр.</summary>
		// Token: 0x04000378 RID: 888
		Millimeter,
		/// <summary>Указывает в качестве единицы измерения для принтера размер максимального пробела для шрифта в 32 пункта.</summary>
		// Token: 0x04000379 RID: 889
		Em = 32
	}
}
