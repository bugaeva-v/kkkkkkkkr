using System;

namespace System.Data
{
	/// <summary>Представляет параметр, относящийся к объекту Command, и при необходимости его сопоставление со столбцами <see cref="T:System.Data.DataSet" />. Реализация осуществляется с помощью поставщиков данных .NET Framework, которые обращаются к источникам данных.</summary>
	// Token: 0x020000FF RID: 255
	public interface IDataParameter
	{
		/// <summary>Возвращает или устанавливает тип <see cref="T:System.Data.DbType" /> параметра.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.DbType" />. Значение по умолчанию — <see cref="F:System.Data.DbType.String" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойству не задано допустимое значение <see cref="T:System.Data.DbType" />.</exception>
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000F13 RID: 3859
		// (set) Token: 0x06000F14 RID: 3860
		DbType DbType { get; set; }

		/// <summary>Возвращает или задает значение, указывающее, является ли параметр только входным, только выходным, двунаправленным или параметром, возвращаемым хранимой процедурой.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.ParameterDirection" />. Значение по умолчанию — <see langword="Input" />.</returns>
		/// <exception cref="T:System.ArgumentException">Для свойства не задано одно из допустимых значений типа <see cref="T:System.Data.ParameterDirection" />.</exception>
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000F15 RID: 3861
		// (set) Token: 0x06000F16 RID: 3862
		ParameterDirection Direction { get; set; }

		/// <summary>Возвращает значение, указывающее, принимает ли этот параметр значения null.</summary>
		/// <returns>
		///   <see langword="true" />, если допускаются значения null. В противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000F17 RID: 3863
		bool IsNullable { get; }

		/// <summary>Возвращает или задает имя таблицы для объекта <see cref="T:System.Data.IDataParameter" />.</summary>
		/// <returns>Имя <see cref="T:System.Data.IDataParameter" />. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000F18 RID: 3864
		// (set) Token: 0x06000F19 RID: 3865
		string ParameterName { get; set; }

		/// <summary>Возвращает или задает имя исходного столбца, сопоставленного с <see cref="T:System.Data.DataSet" /> и используемого для загрузки или возвращения значения <see cref="P:System.Data.IDataParameter.Value" />.</summary>
		/// <returns>Имя исходного столбца, сопоставленного с <see cref="T:System.Data.DataSet" />. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000F1A RID: 3866
		// (set) Token: 0x06000F1B RID: 3867
		string SourceColumn { get; set; }

		/// <summary>Возвращает или задает значение <see cref="T:System.Data.DataRowVersion" /> при загрузке <see cref="P:System.Data.IDataParameter.Value" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.DataRowVersion" />. Значение по умолчанию — <see langword="Current" />.</returns>
		/// <exception cref="T:System.ArgumentException">Для свойства не задано одно из допустимых значений типа <see cref="T:System.Data.DataRowVersion" />.</exception>
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000F1C RID: 3868
		// (set) Token: 0x06000F1D RID: 3869
		DataRowVersion SourceVersion { get; set; }

		/// <summary>Возвращает или задает значение параметра.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, который является значением параметра. Значение по умолчанию — null.</returns>
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000F1E RID: 3870
		// (set) Token: 0x06000F1F RID: 3871
		object Value { get; set; }
	}
}
