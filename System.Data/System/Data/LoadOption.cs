using System;

namespace System.Data
{
	/// <summary>Управляет применением значений из источника данных в существующих строках при использовании метода <see cref="Overload:System.Data.DataTable.Load" /> или <see cref="Overload:System.Data.DataSet.Load" />.</summary>
	// Token: 0x0200010C RID: 268
	public enum LoadOption
	{
		/// <summary>Входные значения для этой строки будут записаны как в текущее значение, так и в исходное значение данных для каждого столбца.</summary>
		// Token: 0x04000978 RID: 2424
		OverwriteChanges = 1,
		/// <summary>Входные значения для этой строки будут записаны в исходные значения данных для каждого столбца. Текущая версия данных в столбце не изменяется.  Это значение по умолчанию.</summary>
		// Token: 0x04000979 RID: 2425
		PreserveChanges,
		/// <summary>Входные значения для этой строки будут записаны в текущее значение данных для каждого столбца. Исходная версия данных в столбце не изменяется.</summary>
		// Token: 0x0400097A RID: 2426
		Upsert
	}
}
