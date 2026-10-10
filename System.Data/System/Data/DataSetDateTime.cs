using System;

namespace System.Data
{
	/// <summary>Описывает формат сериализации для столбцов <see cref="T:System.DateTime" /> в объекте <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x020000CA RID: 202
	public enum DataSetDateTime
	{
		/// <summary>
		///   <see langword="DateTime" /> всегда хранится в Local. Если значение <see cref="F:System.Data.DataSetDateTime.Utc" /> или <see cref="F:System.Data.DataSetDateTime.Unspecified" /> назначено столбцу в этом режиме, оно сначала преобразуется в Local. Сериализация в этом режиме всегда выполняется в Local. В процессе сериализации имеется смещение.</summary>
		// Token: 0x040007FC RID: 2044
		Local = 1,
		/// <summary>
		///   <see langword="DateTime" /> всегда хранится в Unspecified. Если значение <see cref="F:System.Data.DataSetDateTime.Local" /> или <see cref="F:System.Data.DataSetDateTime.Utc" /> назначено столбцу в этом режиме, оно сначала преобразуется в <see cref="F:System.Data.DataSetDateTime.Unspecified" />. Сериализация в этом режиме не вызывает смещения.</summary>
		// Token: 0x040007FD RID: 2045
		Unspecified,
		/// <summary>
		///   <see langword="DateTime" /> хранится в Unspecified. Если значение <see cref="F:System.Data.DataSetDateTime.Local" /> или <see cref="F:System.Data.DataSetDateTime.Utc" /> назначено столбцу в этом режиме, оно сначала преобразуется в <see cref="F:System.Data.DataSetDateTime.Unspecified" />. Сериализация в этом режиме вызывает смещение. Это поведение по умолчанию, обладающее обратной совместимостью. Этот параметр следует рассматривать как Unspecified в хранилище, однако применение смещения аналогично <see cref="F:System.Data.DataSetDateTime.Local" /> в процессе сериализации.</summary>
		// Token: 0x040007FE RID: 2046
		UnspecifiedLocal,
		/// <summary>Значение <see langword="DateTime" /> хранится в UTC (Universal Coordinated Time). Если значение <see cref="F:System.Data.DataSetDateTime.Local" /> или <see cref="F:System.Data.DataSetDateTime.Unspecified" /> назначено столбцу в этом режиме, оно сначала преобразуется в формат <see langword="Utc" />. Сериализация в этом режиме всегда выполняется в <see langword="Utc" />. В процессе сериализации смещение отсутствует.</summary>
		// Token: 0x040007FF RID: 2047
		Utc
	}
}
