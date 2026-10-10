using System;

namespace System.Data
{
	/// <summary>Описывает версию данных в объекте <see cref="T:System.Data.DataRow" />.</summary>
	// Token: 0x020000DB RID: 219
	[Flags]
	public enum DataViewRowState
	{
		/// <summary>Отсутствует.</summary>
		// Token: 0x0400084D RID: 2125
		None = 0,
		/// <summary>Неизменившаяся строка.</summary>
		// Token: 0x0400084E RID: 2126
		Unchanged = 2,
		/// <summary>Новая строка.</summary>
		// Token: 0x0400084F RID: 2127
		Added = 4,
		/// <summary>Удаленная строка.</summary>
		// Token: 0x04000850 RID: 2128
		Deleted = 8,
		/// <summary>Текущая версия исходных данных, которые были изменены (см. <see langword="ModifiedOriginal" />).</summary>
		// Token: 0x04000851 RID: 2129
		ModifiedCurrent = 16,
		/// <summary>Версия исходной строки измененных данных. (Хотя данные были изменены, они доступны как <see langword="ModifiedCurrent" />).</summary>
		// Token: 0x04000852 RID: 2130
		ModifiedOriginal = 32,
		/// <summary>Исходные строки, включая неизмененные и удаленные.</summary>
		// Token: 0x04000853 RID: 2131
		OriginalRows = 42,
		/// <summary>Текущие строки, включая неизмененные, новые и измененные строки. По умолчанию <see cref="T:System.Data.DataViewRowState" /> имеет значение CurrentRows.</summary>
		// Token: 0x04000854 RID: 2132
		CurrentRows = 22
	}
}
