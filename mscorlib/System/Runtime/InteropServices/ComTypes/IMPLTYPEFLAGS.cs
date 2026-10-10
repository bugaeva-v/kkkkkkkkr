using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Определяет атрибуты реализованного или унаследованного интерфейса типа.</summary>
	// Token: 0x020007B5 RID: 1973
	[Flags]
	[Serializable]
	public enum IMPLTYPEFLAGS
	{
		/// <summary>Интерфейс или диспетчерский интерфейс предоставляет источник или приемник, используемый по умолчанию.</summary>
		// Token: 0x04002C7B RID: 11387
		IMPLTYPEFLAG_FDEFAULT = 1,
		/// <summary>Этот член совместного класса вызывается, а не реализуется.</summary>
		// Token: 0x04002C7C RID: 11388
		IMPLTYPEFLAG_FSOURCE = 2,
		/// <summary>Не следует позволять пользователям отображать или программировать этот член.</summary>
		// Token: 0x04002C7D RID: 11389
		IMPLTYPEFLAG_FRESTRICTED = 4,
		/// <summary>Приемники получают события при помощи таблицы виртуальной функции (VTBL).</summary>
		// Token: 0x04002C7E RID: 11390
		IMPLTYPEFLAG_FDEFAULTVTABLE = 8
	}
}
