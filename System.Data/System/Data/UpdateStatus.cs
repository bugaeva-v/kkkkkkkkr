using System;

namespace System.Data
{
	/// <summary>Указывает действия, предпринимаемые в отношении текущей строки и остальных строк во время выполнения метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</summary>
	// Token: 0x02000149 RID: 329
	public enum UpdateStatus
	{
		/// <summary>Класс <see cref="T:System.Data.Common.DataAdapter" /> для продолжения обработки строк.</summary>
		// Token: 0x04000B64 RID: 2916
		Continue,
		/// <summary>Обработчик событий сообщает, что обновление будет рассматриваться как ошибка.</summary>
		// Token: 0x04000B65 RID: 2917
		ErrorsOccurred,
		/// <summary>Текущая строка не обновляется.</summary>
		// Token: 0x04000B66 RID: 2918
		SkipCurrentRow,
		/// <summary>Текущая строка и все остальные строки не обновляются.</summary>
		// Token: 0x04000B67 RID: 2919
		SkipAllRemainingRows
	}
}
