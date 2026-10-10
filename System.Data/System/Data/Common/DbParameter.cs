using System;
using System.ComponentModel;

namespace System.Data.Common
{
	/// <summary>Представляет параметр для объекта <see cref="T:System.Data.Common.DbCommand" /> и (необязательно) его сопоставление со столбцом <see cref="T:System.Data.DataSet" />. Дополнительные сведения о параметрах см. в разделе Настройка параметров и типов данных параметров.</summary>
	// Token: 0x0200039B RID: 923
	public abstract class DbParameter : MarshalByRefObject, IDbDataParameter, IDataParameter
	{
		/// <summary>Возвращает или устанавливает тип <see cref="T:System.Data.DbType" /> параметра.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.DbType" />. Значение по умолчанию — <see cref="F:System.Data.DbType.String" />.</returns>
		/// <exception cref="T:System.ArgumentException">Для свойства не задано допустимое значение <see cref="T:System.Data.DbType" />.</exception>
		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06002CBB RID: 11451
		// (set) Token: 0x06002CBC RID: 11452
		[RefreshProperties(RefreshProperties.All)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public abstract DbType DbType { get; set; }

		/// <summary>Сбрасывает свойство DbType к его исходным параметрам.</summary>
		// Token: 0x06002CBD RID: 11453
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public abstract void ResetDbType();

		/// <summary>Возвращает или задает значение, указывающее, является ли параметр только входным, только выходным, двунаправленным или параметром, возвращаемым хранимой процедурой.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.ParameterDirection" />. Значение по умолчанию — <see langword="Input" />.</returns>
		/// <exception cref="T:System.ArgumentException">Для свойства не задано допустимое значение <see cref="T:System.Data.ParameterDirection" />.</exception>
		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06002CBE RID: 11454
		// (set) Token: 0x06002CBF RID: 11455
		[DefaultValue(ParameterDirection.Input)]
		[RefreshProperties(RefreshProperties.All)]
		public abstract ParameterDirection Direction { get; set; }

		/// <summary>Возвращает или задает значение, указывающее, принимает ли этот параметр значения NULL.</summary>
		/// <returns>Значение <see langword="true" />, если допускаются значения NULL. В противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06002CC0 RID: 11456
		// (set) Token: 0x06002CC1 RID: 11457
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignOnly(true)]
		[Browsable(false)]
		public abstract bool IsNullable { get; set; }

		/// <summary>Возвращает или задает имя таблицы для объекта <see cref="T:System.Data.Common.DbParameter" />.</summary>
		/// <returns>Имя <see cref="T:System.Data.Common.DbParameter" />. Значение по умолчанию — пустая строка ("").</returns>
		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06002CC2 RID: 11458
		// (set) Token: 0x06002CC3 RID: 11459
		[DefaultValue("")]
		public abstract string ParameterName { get; set; }

		/// <summary>Указывает точность числовых параметров.</summary>
		/// <returns>Максимальное число разрядов, используемых для представления свойства <see langword="Value" /> объекта <see langword="Parameter" /> поставщика данных. Значение по умолчанию — 0. Оно указывает, что точность значения <see langword="Value" /> задает поставщик данных.</returns>
		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x00006D64 File Offset: 0x00004F64
		// (set) Token: 0x06002CC5 RID: 11461 RVA: 0x00007EED File Offset: 0x000060ED
		byte IDbDataParameter.Precision
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Data.IDbDataParameter.Scale" />.</summary>
		/// <returns>Число десятичных разрядов, до которых вычисляется значение <see cref="P:System.Data.OleDb.OleDbParameter.Value" />. Значение по умолчанию — 0.</returns>
		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x00006D64 File Offset: 0x00004F64
		// (set) Token: 0x06002CC7 RID: 11463 RVA: 0x00007EED File Offset: 0x000060ED
		byte IDbDataParameter.Scale
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает максимальное число разрядов, используемых для представления свойства <see cref="P:System.Data.Common.DbParameter.Value" />.</summary>
		/// <returns>Максимальное число разрядов, используемых для представления свойства <see cref="P:System.Data.Common.DbParameter.Value" />.</returns>
		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x000BEEBF File Offset: 0x000BD0BF
		// (set) Token: 0x06002CC9 RID: 11465 RVA: 0x000BEEC7 File Offset: 0x000BD0C7
		public virtual byte Precision
		{
			get
			{
				return ((IDbDataParameter)this).Precision;
			}
			set
			{
				((IDbDataParameter)this).Precision = value;
			}
		}

		/// <summary>Возвращает или задает число десятичных разрядов, до которых вычисляется значение <see cref="P:System.Data.Common.DbParameter.Value" />.</summary>
		/// <returns>Число десятичных разрядов, до которых вычисляется значение <see cref="P:System.Data.Common.DbParameter.Value" />.</returns>
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x000BEED0 File Offset: 0x000BD0D0
		// (set) Token: 0x06002CCB RID: 11467 RVA: 0x000BEED8 File Offset: 0x000BD0D8
		public virtual byte Scale
		{
			get
			{
				return ((IDbDataParameter)this).Scale;
			}
			set
			{
				((IDbDataParameter)this).Scale = value;
			}
		}

		/// <summary>Возвращает или задает максимальную длину данных (в байтах) в столбце.</summary>
		/// <returns>Максимальная длина данных (в байтах) в столбце. Значение по умолчанию определяется исходя из значения параметра.</returns>
		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06002CCC RID: 11468
		// (set) Token: 0x06002CCD RID: 11469
		public abstract int Size { get; set; }

		/// <summary>Возвращает или задает имя исходного столбца, сопоставленного <see cref="T:System.Data.DataSet" /> и используемого для загрузки или возвращения значения <see cref="P:System.Data.Common.DbParameter.Value" />.</summary>
		/// <returns>Имя исходного столбца, сопоставленного <see cref="T:System.Data.DataSet" />. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06002CCE RID: 11470
		// (set) Token: 0x06002CCF RID: 11471
		[DefaultValue("")]
		public abstract string SourceColumn { get; set; }

		/// <summary>Возвращает или задает значение, показывающее, допускает ли исходный столбец значение NULL. Это позволяет <see cref="T:System.Data.Common.DbCommandBuilder" /> правильно создавать инструкции Update для столбцов со значением NULL.</summary>
		/// <returns>Значение <see langword="true" />, если исходный столбец допускает значение NULL; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06002CD0 RID: 11472
		// (set) Token: 0x06002CD1 RID: 11473
		[DefaultValue(false)]
		[RefreshProperties(RefreshProperties.All)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public abstract bool SourceColumnNullMapping { get; set; }

		/// <summary>Возвращает или задает значение <see cref="T:System.Data.DataRowVersion" />, используемое при загрузке <see cref="P:System.Data.Common.DbParameter.Value" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.DataRowVersion" />. Значение по умолчанию — <see langword="Current" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойству не задано одно из значений <see cref="T:System.Data.DataRowVersion" />.</exception>
		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x000BEEE1 File Offset: 0x000BD0E1
		// (set) Token: 0x06002CD3 RID: 11475 RVA: 0x00007EED File Offset: 0x000060ED
		[DefaultValue(DataRowVersion.Current)]
		public virtual DataRowVersion SourceVersion
		{
			get
			{
				return DataRowVersion.Default;
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает значение параметра.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, который является значением параметра. Значение по умолчанию — null.</returns>
		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06002CD4 RID: 11476
		// (set) Token: 0x06002CD5 RID: 11477
		[RefreshProperties(RefreshProperties.All)]
		[DefaultValue(null)]
		public abstract object Value { get; set; }
	}
}
