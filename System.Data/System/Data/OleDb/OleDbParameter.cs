using System;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Представляет параметр для объекта <see cref="T:System.Data.OleDb.OleDbCommand" /> и (необязательно) его сопоставление со столбцом <see cref="T:System.Data.DataSet" />. Этот класс не наследуется.</summary>
	// Token: 0x0200016D RID: 365
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbParameter : DbParameter, IDataParameter, IDbDataParameter, ICloneable
	{
		/// <summary>Возвращает или устанавливает тип <see cref="T:System.Data.DbType" /> параметра.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.DbType" />. Значение по умолчанию — <see cref="F:System.Data.DbType.String" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойству не задано допустимое значение <see cref="T:System.Data.DbType" />.</exception>
		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x00007EED File Offset: 0x000060ED
		public override DbType DbType
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает значение, определяющее, предназначен ли параметр только для ввода, только для вывода, является ли он двунаправленным или возвращается хранимой процедурой.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.ParameterDirection" />. Значение по умолчанию — <see langword="Input" />.</returns>
		/// <exception cref="T:System.ArgumentException">Для свойства не задано одно из допустимых значений типа <see cref="T:System.Data.ParameterDirection" />.</exception>
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x00007EED File Offset: 0x000060ED
		public override ParameterDirection Direction
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, принимает ли этот параметр значения NULL.</summary>
		/// <returns>Значение <see langword="true" />, если допускаются значения NULL. В противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x00007EED File Offset: 0x000060ED
		public override bool IsNullable
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x00007EED File Offset: 0x000060ED
		public int Offset
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или устанавливает тип <see cref="T:System.Data.OleDb.OleDbType" /> параметра.</summary>
		/// <returns>Тип <see cref="T:System.Data.OleDb.OleDbType" /> параметра. Значение по умолчанию — <see cref="F:System.Data.OleDb.OleDbType.VarWChar" />.</returns>
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x00007EED File Offset: 0x000060ED
		public OleDbType OleDbType
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает имя таблицы для объекта <see cref="T:System.Data.OleDb.OleDbParameter" />.</summary>
		/// <returns>Имя <see cref="T:System.Data.OleDb.OleDbParameter" />. Значение по умолчанию — пустая строка ("").</returns>
		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x00007EED File Offset: 0x000060ED
		public override string ParameterName
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает максимальное число разрядов, используемых для представления свойства <see cref="P:System.Data.OleDb.OleDbParameter.Value" />.</summary>
		/// <returns>Максимальное число разрядов, используемых для представления свойства <see cref="P:System.Data.OleDb.OleDbParameter.Value" />. Значение по умолчанию равно 0 и означает, что точность <see cref="P:System.Data.OleDb.OleDbParameter.Value" /> задается поставщиком данных.</returns>
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x00007EED File Offset: 0x000060ED
		public new byte Precision
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает число десятичных разрядов, до которых вычисляется значение <see cref="P:System.Data.OleDb.OleDbParameter.Value" />.</summary>
		/// <returns>Число десятичных разрядов, до которых вычисляется значение <see cref="P:System.Data.OleDb.OleDbParameter.Value" />. Значение по умолчанию — 0.</returns>
		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x00007EED File Offset: 0x000060ED
		public new byte Scale
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает максимальную длину данных (в байтах) в столбце.</summary>
		/// <returns>Максимальная длина данных (в байтах) в столбце. Значение по умолчанию определяется исходя из значения параметра.</returns>
		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x00007EED File Offset: 0x000060ED
		public override int Size
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает имя исходного столбца, сопоставленного <see cref="T:System.Data.DataSet" /> и используемого для загрузки или возвращения значения <see cref="P:System.Data.OleDb.OleDbParameter.Value" />.</summary>
		/// <returns>Имя исходного столбца, сопоставленного <see cref="T:System.Data.DataSet" />. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x1700034A RID: 842
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x00007EED File Offset: 0x000060ED
		public override string SourceColumn
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает значение, показывающее, допускает ли исходный столбец значение NULL. Это позволяет <see cref="T:System.Data.Common.DbCommandBuilder" /> правильно создавать инструкции Update для столбцов со значением NULL.</summary>
		/// <returns>Значение <see langword="true" />, если исходный столбец допускает значение NULL; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700034B RID: 843
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x00007EED File Offset: 0x000060ED
		public override bool SourceColumnNullMapping
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Data.DataRowVersion" />, используемое при загрузке <see cref="P:System.Data.OleDb.OleDbParameter.Value" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.DataRowVersion" />. Значение по умолчанию — <see langword="Current" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство не было установлено в одно из значений <see cref="T:System.Data.DataRowVersion" />.</exception>
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x00007EED File Offset: 0x000060ED
		public override DataRowVersion SourceVersion
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает значение параметра.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, который является значением параметра. Значение по умолчанию — null.</returns>
		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x00007EED File Offset: 0x000060ED
		public override object Value
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbParameter" />.</summary>
		// Token: 0x06001393 RID: 5011 RVA: 0x0005ADFB File Offset: 0x00058FFB
		public OleDbParameter()
		{
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Data.OleDb.OleDbParameter" />, использующего имя параметра и тип данных.</summary>
		/// <param name="name">Имя сопоставляемого параметра.</param>
		/// <param name="dataType">Одно из значений <see cref="T:System.Data.OleDb.OleDbType" />.</param>
		/// <exception cref="T:System.ArgumentException">Значение, передаваемое в параметре <paramref name="dataType" />, имеет недопустимый тип внутренних данных.</exception>
		// Token: 0x06001394 RID: 5012 RVA: 0x0005AE03 File Offset: 0x00059003
		public OleDbParameter(string name, OleDbType dataType)
		{
			throw ADP.OleDb();
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Data.OleDb.OleDbParameter" />, использующего имя параметра, тип данных и длину.</summary>
		/// <param name="name">Имя сопоставляемого параметра.</param>
		/// <param name="dataType">Одно из значений <see cref="T:System.Data.OleDb.OleDbType" />.</param>
		/// <param name="size">Длина параметра.</param>
		/// <exception cref="T:System.ArgumentException">Значение, передаваемое в параметре <paramref name="dataType" />, имеет недопустимый тип внутренних данных.</exception>
		// Token: 0x06001395 RID: 5013 RVA: 0x0005AE03 File Offset: 0x00059003
		public OleDbParameter(string name, OleDbType dataType, int size)
		{
			throw ADP.OleDb();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbParameter" />, использующий имя параметра, тип данных, длину, имя исходного столбца, направление параметра, точность чисел и другие свойства.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <param name="dbType">Одно из значений <see cref="T:System.Data.OleDb.OleDbType" />.</param>
		/// <param name="size">Длина параметра.</param>
		/// <param name="direction">Одно из значений <see cref="T:System.Data.ParameterDirection" />.</param>
		/// <param name="isNullable">Значение <see langword="true" />, если поле допускает значение NULL, значение <see langword="false" /> — в противном случае.</param>
		/// <param name="precision">Общее число разрядов слева и справа от десятичной запятой, до которого вычисляется значения <see cref="P:System.Data.OleDb.OleDbParameter.Value" />.</param>
		/// <param name="scale">Общее число десятичных разрядов, до которого вычисляется значение <see cref="P:System.Data.OleDb.OleDbParameter.Value" />.</param>
		/// <param name="srcColumn">Имя исходного столбца.</param>
		/// <param name="srcVersion">Одно из значений <see cref="T:System.Data.DataRowVersion" />.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, который является значением <see cref="T:System.Data.OleDb.OleDbParameter" />.</param>
		/// <exception cref="T:System.ArgumentException">Значение, передаваемое в параметре <paramref name="dataType" />, имеет недопустимый тип внутренних данных.</exception>
		// Token: 0x06001396 RID: 5014 RVA: 0x0005AE03 File Offset: 0x00059003
		public OleDbParameter(string parameterName, OleDbType dbType, int size, ParameterDirection direction, bool isNullable, byte precision, byte scale, string srcColumn, DataRowVersion srcVersion, object value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbParameter" />, использующий имя параметра, тип данных, длину, имя исходного столбца, направление параметра, точность чисел и другие свойства.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <param name="dbType">Одно из значений <see cref="T:System.Data.OleDb.OleDbType" />.</param>
		/// <param name="size">Длина параметра.</param>
		/// <param name="direction">Одно из значений <see cref="T:System.Data.ParameterDirection" />.</param>
		/// <param name="precision">Общее число разрядов слева и справа от десятичной запятой, до которого вычисляется значения <see cref="P:System.Data.OleDb.OleDbParameter.Value" />.</param>
		/// <param name="scale">Общее число десятичных разрядов, до которого вычисляется значение <see cref="P:System.Data.OleDb.OleDbParameter.Value" />.</param>
		/// <param name="sourceColumn">Имя исходного столбца.</param>
		/// <param name="sourceVersion">Одно из значений <see cref="T:System.Data.DataRowVersion" />.</param>
		/// <param name="sourceColumnNullMapping">
		///   <see langword="true" />, если исходный столбец допускает значение NULL, <see langword="false" /> — в противном случае.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, который является значением <see cref="T:System.Data.OleDb.OleDbParameter" />.</param>
		/// <exception cref="T:System.ArgumentException">Значение, передаваемое в параметре <paramref name="dataType" />, имеет недопустимый тип внутренних данных.</exception>
		// Token: 0x06001397 RID: 5015 RVA: 0x0005AE03 File Offset: 0x00059003
		public OleDbParameter(string parameterName, OleDbType dbType, int size, ParameterDirection direction, byte precision, byte scale, string sourceColumn, DataRowVersion sourceVersion, bool sourceColumnNullMapping, object value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Data.OleDb.OleDbParameter" />, использующего имя параметра, тип данных, длину и имя столбца источника.</summary>
		/// <param name="name">Имя сопоставляемого параметра.</param>
		/// <param name="dataType">Одно из значений <see cref="T:System.Data.OleDb.OleDbType" />.</param>
		/// <param name="size">Длина параметра.</param>
		/// <param name="srcColumn">Имя исходного столбца.</param>
		/// <exception cref="T:System.ArgumentException">Значение, передаваемое в параметре <paramref name="dataType" />, имеет недопустимый тип внутренних данных.</exception>
		// Token: 0x06001398 RID: 5016 RVA: 0x0005AE03 File Offset: 0x00059003
		public OleDbParameter(string name, OleDbType dataType, int size, string srcColumn)
		{
			throw ADP.OleDb();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbParameter" />, использующий имя параметра и значение нового объекта <see cref="T:System.Data.OleDb.OleDbParameter" />.</summary>
		/// <param name="name">Имя сопоставляемого параметра.</param>
		/// <param name="value">Значение нового объекта <see cref="T:System.Data.OleDb.OleDbParameter" />.</param>
		// Token: 0x06001399 RID: 5017 RVA: 0x0005AE03 File Offset: 0x00059003
		public OleDbParameter(string name, object value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Сбрасывает тип, связанный с параметром <see cref="T:System.Data.OleDb.OleDbParameter" />.</summary>
		// Token: 0x0600139A RID: 5018 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void ResetDbType()
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает строку, содержащую имя <see cref="P:System.Data.OleDb.OleDbParameter.ParameterName" />.</summary>
		/// <returns>Строка, содержащая имя <see cref="P:System.Data.OleDb.OleDbParameter.ParameterName" />.</returns>
		// Token: 0x0600139B RID: 5019 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override string ToString()
		{
			throw ADP.OleDb();
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.ICloneable.Clone" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Object" />, который является копией данного экземпляра.</returns>
		// Token: 0x0600139C RID: 5020 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		object ICloneable.Clone()
		{
			throw ADP.OleDb();
		}

		/// <summary>Сбрасывает тип, связанный с параметром <see cref="T:System.Data.OleDb.OleDbParameter" />.</summary>
		// Token: 0x0600139D RID: 5021 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public void ResetOleDbType()
		{
			throw ADP.OleDb();
		}
	}
}
