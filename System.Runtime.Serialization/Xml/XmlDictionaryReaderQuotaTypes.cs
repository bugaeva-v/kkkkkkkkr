using System;

namespace System.Xml
{
	/// <summary>Перечисляет настраиваемые значения квоты для класса XmlDictionaryReaders.</summary>
	// Token: 0x02000062 RID: 98
	[Flags]
	public enum XmlDictionaryReaderQuotaTypes
	{
		/// <summary>Указывает максимальную глубину вложенного узла.</summary>
		// Token: 0x0400027E RID: 638
		MaxDepth = 1,
		/// <summary>Указывает максимальную длину строки, возвращаемой средством чтения.</summary>
		// Token: 0x0400027F RID: 639
		MaxStringContentLength = 2,
		/// <summary>Указывает максимально допустимую длину массива.</summary>
		// Token: 0x04000280 RID: 640
		MaxArrayLength = 4,
		/// <summary>Указывает максимальное допустимое число байтов, возвращаемых для каждой операции чтения.</summary>
		// Token: 0x04000281 RID: 641
		MaxBytesPerRead = 8,
		/// <summary>Указывает максимально допустимое количество символов в имени таблицы.</summary>
		// Token: 0x04000282 RID: 642
		MaxNameTableCharCount = 16
	}
}
