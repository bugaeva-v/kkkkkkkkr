using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS" />.</summary>
	// Token: 0x02000723 RID: 1827
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[Flags]
	[Serializable]
	public enum IMPLTYPEFLAGS
	{
		/// <summary>Интерфейс или диспетчерский интерфейс предоставляет источник или приемник, используемый по умолчанию.</summary>
		// Token: 0x04002B28 RID: 11048
		IMPLTYPEFLAG_FDEFAULT = 1,
		/// <summary>Этот член совместного класса вызывается, а не реализуется.</summary>
		// Token: 0x04002B29 RID: 11049
		IMPLTYPEFLAG_FSOURCE = 2,
		/// <summary>Не следует позволять пользователям отображать или программировать этот член.</summary>
		// Token: 0x04002B2A RID: 11050
		IMPLTYPEFLAG_FRESTRICTED = 4,
		/// <summary>Приемники получают события при помощи таблицы виртуальной функции (VTBL).</summary>
		// Token: 0x04002B2B RID: 11051
		IMPLTYPEFLAG_FDEFAULTVTABLE = 8
	}
}
