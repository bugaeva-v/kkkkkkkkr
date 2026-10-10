using System;
using System.Data.Common;
using System.Globalization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет поток символов переменной длины, сохраняемый в базе данных или извлекаемый из нее. <see cref="T:System.Data.SqlTypes.SqlString" /> имеет базовую структуру данных, отличную от соответствующего типа данных <see cref="T:System.String" /> платформы .NET Framework.</summary>
	// Token: 0x02000317 RID: 791
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public struct SqlString : INullable, IComparable, IXmlSerializable
	{
		// Token: 0x0600258E RID: 9614 RVA: 0x000A88D1 File Offset: 0x000A6AD1
		private SqlString(bool fNull)
		{
			this.m_value = null;
			this.m_cmpInfo = null;
			this.m_lcid = 0;
			this.m_flag = SqlCompareOptions.None;
			this.m_fNotNull = false;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="lcid">Задает региональные настройки и язык для новой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="compareOptions">Задает параметры сравнения новой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="data">Массив данных для хранения.</param>
		/// <param name="index">Начальный индекс в массиве.</param>
		/// <param name="count">Число символов из индекса для копирования.</param>
		/// <param name="fUnicode">
		///   <see langword="true" />, если используется кодировка Юникод. В противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600258F RID: 9615 RVA: 0x000A88F8 File Offset: 0x000A6AF8
		public SqlString(int lcid, SqlCompareOptions compareOptions, byte[] data, int index, int count, bool fUnicode)
		{
			this.m_lcid = lcid;
			SqlString.ValidateSqlCompareOptions(compareOptions);
			this.m_flag = compareOptions;
			if (data == null)
			{
				this.m_fNotNull = false;
				this.m_value = null;
				this.m_cmpInfo = null;
				return;
			}
			this.m_fNotNull = true;
			this.m_cmpInfo = null;
			if (fUnicode)
			{
				this.m_value = SqlString.s_unicodeEncoding.GetString(data, index, count);
				return;
			}
			Encoding encoding = Encoding.GetEncoding(new CultureInfo(this.m_lcid).TextInfo.ANSICodePage);
			this.m_value = encoding.GetString(data, index, count);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="lcid">Задает региональные настройки и язык для новой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="compareOptions">Задает параметры сравнения новой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="data">Массив данных для хранения.</param>
		/// <param name="fUnicode">
		///   <see langword="true" />, если используется кодировка Юникод. В противном случае — значение <see langword="false" />.</param>
		// Token: 0x06002590 RID: 9616 RVA: 0x000A8986 File Offset: 0x000A6B86
		public SqlString(int lcid, SqlCompareOptions compareOptions, byte[] data, bool fUnicode)
		{
			this = new SqlString(lcid, compareOptions, data, 0, data.Length, fUnicode);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="lcid">Задает региональные настройки и язык для новой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="compareOptions">Задает параметры сравнения новой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="data">Массив данных для хранения.</param>
		/// <param name="index">Начальный индекс в массиве.</param>
		/// <param name="count">Число символов из индекса для копирования.</param>
		// Token: 0x06002591 RID: 9617 RVA: 0x000A8997 File Offset: 0x000A6B97
		public SqlString(int lcid, SqlCompareOptions compareOptions, byte[] data, int index, int count)
		{
			this = new SqlString(lcid, compareOptions, data, index, count, true);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlString" /> с использованием заданных кода языка, параметров сравнения и данных.</summary>
		/// <param name="lcid">Задает региональные настройки и язык для новой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="compareOptions">Задает параметры сравнения новой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="data">Массив данных для хранения.</param>
		// Token: 0x06002592 RID: 9618 RVA: 0x000A89A7 File Offset: 0x000A6BA7
		public SqlString(int lcid, SqlCompareOptions compareOptions, byte[] data)
		{
			this = new SqlString(lcid, compareOptions, data, 0, data.Length, true);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlString" /> с использованием заданных строки, кода языка и значений параметров сравнения.</summary>
		/// <param name="data">Строка, которую необходимо сохранить.</param>
		/// <param name="lcid">Задает региональные настройки и язык для новой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="compareOptions">Задает параметры сравнения новой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		// Token: 0x06002593 RID: 9619 RVA: 0x000A89B7 File Offset: 0x000A6BB7
		public SqlString(string data, int lcid, SqlCompareOptions compareOptions)
		{
			this.m_lcid = lcid;
			SqlString.ValidateSqlCompareOptions(compareOptions);
			this.m_flag = compareOptions;
			this.m_cmpInfo = null;
			if (data == null)
			{
				this.m_fNotNull = false;
				this.m_value = null;
				return;
			}
			this.m_fNotNull = true;
			this.m_value = data;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlString" /> с использованием заданной строки и значений кода языка.</summary>
		/// <param name="data">Строка, которую необходимо сохранить.</param>
		/// <param name="lcid">Задает региональные настройки и язык для новой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		// Token: 0x06002594 RID: 9620 RVA: 0x000A89F4 File Offset: 0x000A6BF4
		public SqlString(string data, int lcid)
		{
			this = new SqlString(data, lcid, SqlString.s_iDefaultFlag);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Data.SqlTypes.SqlString" /> с использованием заданной строки.</summary>
		/// <param name="data">Строка, которую необходимо сохранить.</param>
		// Token: 0x06002595 RID: 9621 RVA: 0x000A8A03 File Offset: 0x000A6C03
		public SqlString(string data)
		{
			this = new SqlString(data, CultureInfo.CurrentCulture.LCID, SqlString.s_iDefaultFlag);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x000A8A1C File Offset: 0x000A6C1C
		private SqlString(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo)
		{
			this.m_lcid = lcid;
			SqlString.ValidateSqlCompareOptions(compareOptions);
			this.m_flag = compareOptions;
			if (data == null)
			{
				this.m_fNotNull = false;
				this.m_value = null;
				this.m_cmpInfo = null;
				return;
			}
			this.m_value = data;
			this.m_cmpInfo = cmpInfo;
			this.m_fNotNull = true;
		}

		/// <summary>Указывает, имеет ли структура <see cref="T:System.Data.SqlTypes.SqlString" /> значение null.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Data.SqlTypes.SqlString.Value" /> имеет значение <see cref="F:System.Data.SqlTypes.SqlString.Null" />. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x000A8A6C File Offset: 0x000A6C6C
		public bool IsNull
		{
			get
			{
				return !this.m_fNotNull;
			}
		}

		/// <summary>Получает строку, которая хранится в данной структуре <see cref="T:System.Data.SqlTypes.SqlString" />. Это свойство доступно только для чтения.</summary>
		/// <returns>Хранимая строка.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">Значением строки является <see cref="F:System.Data.SqlTypes.SqlString.Null" />.</exception>
		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x000A8A77 File Offset: 0x000A6C77
		public string Value
		{
			get
			{
				if (!this.IsNull)
				{
					return this.m_value;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Задает региональные параметры и язык для структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Код языка для строки, хранящейся в свойстве <see cref="P:System.Data.SqlTypes.SqlString.Value" />.</returns>
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x000A8A8D File Offset: 0x000A6C8D
		public int LCID
		{
			get
			{
				if (!this.IsNull)
				{
					return this.m_lcid;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Получает структуру <see cref="T:System.Globalization.CultureInfo" />, которая представляет сведения о языке и региональных параметрах этого объекта <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Структура <see cref="T:System.Globalization.CultureInfo" />, в которой приводятся сведения о языке и региональных параметрах этой структуры SqlString, в том числе об именах, системе письма и календаре, а также о доступе к характерным объектам, предоставляющим методы для выполнения распространенных операций, таких как форматирование даты и сортировка строк.</returns>
		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x000A8AA3 File Offset: 0x000A6CA3
		public CultureInfo CultureInfo
		{
			get
			{
				if (!this.IsNull)
				{
					return CultureInfo.GetCultureInfo(this.m_lcid);
				}
				throw new SqlNullValueException();
			}
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000A8ABE File Offset: 0x000A6CBE
		private void SetCompareInfo()
		{
			if (this.m_cmpInfo == null)
			{
				this.m_cmpInfo = CultureInfo.GetCultureInfo(this.m_lcid).CompareInfo;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Globalization.CompareInfo" />, который определяет способ сравнения строк для этой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Объект <see langword="CompareInfo" />, который определяет сравнение строк для этой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x000A8ADE File Offset: 0x000A6CDE
		public CompareInfo CompareInfo
		{
			get
			{
				if (!this.IsNull)
				{
					this.SetCompareInfo();
					return this.m_cmpInfo;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Сочетание одного или нескольких значений перечисления <see cref="T:System.Data.SqlTypes.SqlCompareOptions" />, представляющее способ сравнения <see cref="T:System.Data.SqlTypes.SqlString" /> с другими структурами <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Значение, указывающее способ сравнения <see cref="T:System.Data.SqlTypes.SqlString" /> с другими структурами <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x000A8AFA File Offset: 0x000A6CFA
		public SqlCompareOptions SqlCompareOptions
		{
			get
			{
				if (!this.IsNull)
				{
					return this.m_flag;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Преобразует параметр <see cref="T:System.String" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Data.SqlTypes.SqlString" />, содержащий значение указанного параметра <see langword="String" />.</returns>
		// Token: 0x0600259E RID: 9630 RVA: 0x000A8B10 File Offset: 0x000A6D10
		public static implicit operator SqlString(string x)
		{
			return new SqlString(x);
		}

		/// <summary>Преобразует <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.String" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Объект <see langword="String" />, содержимое которого совпадает со свойством <see cref="P:System.Data.SqlTypes.SqlString.Value" /> параметра <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x0600259F RID: 9631 RVA: 0x000A8B18 File Offset: 0x000A6D18
		public static explicit operator string(SqlString x)
		{
			return x.Value;
		}

		/// <summary>Преобразует объект <see cref="T:System.Data.SqlTypes.SqlString" /> в объект <see cref="T:System.String" />.</summary>
		/// <returns>Объект <see cref="T:System.String" /> имеет то же значение, что и данная структура <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025A0 RID: 9632 RVA: 0x000A8B21 File Offset: 0x000A6D21
		public override string ToString()
		{
			if (!this.IsNull)
			{
				return this.m_value;
			}
			return SQLResource.NullString;
		}

		/// <summary>Получает массив байтов, в который помещено содержимое <see cref="T:System.Data.SqlTypes.SqlString" /> в формате Юникод.</summary>
		/// <returns>Массив байтов с содержимым <see cref="T:System.Data.SqlTypes.SqlString" /> в формате Юникод.</returns>
		// Token: 0x060025A1 RID: 9633 RVA: 0x000A8B37 File Offset: 0x000A6D37
		public byte[] GetUnicodeBytes()
		{
			if (this.IsNull)
			{
				return null;
			}
			return SqlString.s_unicodeEncoding.GetBytes(this.m_value);
		}

		/// <summary>Получает массив байтов, в который помещено содержимое <see cref="T:System.Data.SqlTypes.SqlString" /> в формате ANSI.</summary>
		/// <returns>Массив байтов с содержимым <see cref="T:System.Data.SqlTypes.SqlString" /> в формате ANSI.</returns>
		// Token: 0x060025A2 RID: 9634 RVA: 0x000A8B53 File Offset: 0x000A6D53
		public byte[] GetNonUnicodeBytes()
		{
			if (this.IsNull)
			{
				return null;
			}
			return Encoding.GetEncoding(new CultureInfo(this.m_lcid).TextInfo.ANSICodePage).GetBytes(this.m_value);
		}

		/// <summary>Сцепляет две указанные структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlString" />, которая содержит новое сцепленное значение, представляющее собой содержимое двух параметров <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025A3 RID: 9635 RVA: 0x000A8B84 File Offset: 0x000A6D84
		public static SqlString operator +(SqlString x, SqlString y)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlString.Null;
			}
			if (x.m_lcid != y.m_lcid || x.m_flag != y.m_flag)
			{
				throw new SqlTypeException(SQLResource.ConcatDiffCollationMessage);
			}
			return new SqlString(x.m_lcid, x.m_flag, x.m_value + y.m_value, (x.m_cmpInfo == null) ? y.m_cmpInfo : x.m_cmpInfo);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x000A8C08 File Offset: 0x000A6E08
		private static int StringCompare(SqlString x, SqlString y)
		{
			if (x.m_lcid != y.m_lcid || x.m_flag != y.m_flag)
			{
				throw new SqlTypeException(SQLResource.CompareDiffCollationMessage);
			}
			x.SetCompareInfo();
			y.SetCompareInfo();
			int result;
			if ((x.m_flag & SqlCompareOptions.BinarySort) != SqlCompareOptions.None)
			{
				result = SqlString.CompareBinary(x, y);
			}
			else if ((x.m_flag & SqlCompareOptions.BinarySort2) != SqlCompareOptions.None)
			{
				result = SqlString.CompareBinary2(x, y);
			}
			else
			{
				string value = x.m_value;
				string value2 = y.m_value;
				int i = value.Length;
				int num = value2.Length;
				while (i > 0)
				{
					if (value[i - 1] != ' ')
					{
						break;
					}
					i--;
				}
				while (num > 0 && value2[num - 1] == ' ')
				{
					num--;
				}
				CompareOptions options = SqlString.CompareOptionsFromSqlCompareOptions(x.m_flag);
				result = x.m_cmpInfo.Compare(x.m_value, 0, i, y.m_value, 0, num, options);
			}
			return result;
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x000A8CFC File Offset: 0x000A6EFC
		private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult)
		{
			if (x.IsNull || y.IsNull)
			{
				return SqlBoolean.Null;
			}
			int num = SqlString.StringCompare(x, y);
			bool value;
			switch (ecExpectedResult)
			{
			case EComparison.LT:
				value = (num < 0);
				break;
			case EComparison.LE:
				value = (num <= 0);
				break;
			case EComparison.EQ:
				value = (num == 0);
				break;
			case EComparison.GE:
				value = (num >= 0);
				break;
			case EComparison.GT:
				value = (num > 0);
				break;
			default:
				return SqlBoolean.Null;
			}
			return new SqlBoolean(value);
		}

		/// <summary>Преобразует заданную структуру <see cref="T:System.Data.SqlTypes.SqlBoolean" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlString" />, содержащий строковое представление параметра <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</returns>
		// Token: 0x060025A6 RID: 9638 RVA: 0x000A8D7C File Offset: 0x000A6F7C
		public static explicit operator SqlString(SqlBoolean x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString());
			}
			return SqlString.Null;
		}

		/// <summary>Преобразует заданную структуру <see cref="T:System.Data.SqlTypes.SqlByte" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlString" />, содержащий строковое представление параметра <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
		// Token: 0x060025A7 RID: 9639 RVA: 0x000A8DAC File Offset: 0x000A6FAC
		public static explicit operator SqlString(SqlByte x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString(null));
			}
			return SqlString.Null;
		}

		/// <summary>Преобразует заданный параметр <see cref="T:System.Data.SqlTypes.SqlInt16" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlString" />, содержащий строковое представление параметра <see cref="T:System.Data.SqlTypes.SqlInt16" />.</returns>
		// Token: 0x060025A8 RID: 9640 RVA: 0x000A8DE0 File Offset: 0x000A6FE0
		public static explicit operator SqlString(SqlInt16 x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString(null));
			}
			return SqlString.Null;
		}

		/// <summary>Преобразует заданный параметр <see cref="T:System.Data.SqlTypes.SqlInt32" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Преобразуемая структура SqlInt32.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlString" />, содержащий строковое представление параметра <see cref="T:System.Data.SqlTypes.SqlInt32" />.</returns>
		// Token: 0x060025A9 RID: 9641 RVA: 0x000A8E14 File Offset: 0x000A7014
		public static explicit operator SqlString(SqlInt32 x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString(null));
			}
			return SqlString.Null;
		}

		/// <summary>Преобразует заданный параметр <see cref="T:System.Data.SqlTypes.SqlInt64" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlString" />, содержащий строковое представление параметра <see cref="T:System.Data.SqlTypes.SqlInt64" />.</returns>
		// Token: 0x060025AA RID: 9642 RVA: 0x000A8E48 File Offset: 0x000A7048
		public static explicit operator SqlString(SqlInt64 x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString(null));
			}
			return SqlString.Null;
		}

		/// <summary>Преобразует заданный параметр <see cref="T:System.Data.SqlTypes.SqlSingle" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlString" />, содержащий строковое представление параметра <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
		// Token: 0x060025AB RID: 9643 RVA: 0x000A8E7C File Offset: 0x000A707C
		public static explicit operator SqlString(SqlSingle x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString(null));
			}
			return SqlString.Null;
		}

		/// <summary>Преобразует заданный параметр <see cref="T:System.Data.SqlTypes.SqlDouble" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlString" />, содержащий строковое представление параметра <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
		// Token: 0x060025AC RID: 9644 RVA: 0x000A8EB0 File Offset: 0x000A70B0
		public static explicit operator SqlString(SqlDouble x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.Value.ToString(null));
			}
			return SqlString.Null;
		}

		/// <summary>Преобразует заданный параметр <see cref="T:System.Data.SqlTypes.SqlDecimal" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Преобразуемая структура <see langword="SqlDecimal" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlString" />, содержащий строковое представление параметра <see langword="SqlDecimal" />.</returns>
		// Token: 0x060025AD RID: 9645 RVA: 0x000A8EE1 File Offset: 0x000A70E1
		public static explicit operator SqlString(SqlDecimal x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.ToString());
			}
			return SqlString.Null;
		}

		/// <summary>Преобразует заданный параметр <see cref="T:System.Data.SqlTypes.SqlMoney" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlString" />, содержащий строковое представление параметра <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
		// Token: 0x060025AE RID: 9646 RVA: 0x000A8F04 File Offset: 0x000A7104
		public static explicit operator SqlString(SqlMoney x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.ToString());
			}
			return SqlString.Null;
		}

		/// <summary>Преобразует заданный параметр <see cref="T:System.Data.SqlTypes.SqlDateTime" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</param>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlString" />, содержащий строковое представление параметра <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</returns>
		// Token: 0x060025AF RID: 9647 RVA: 0x000A8F27 File Offset: 0x000A7127
		public static explicit operator SqlString(SqlDateTime x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.ToString());
			}
			return SqlString.Null;
		}

		/// <summary>Преобразует заданный параметр <see cref="T:System.Data.SqlTypes.SqlGuid" /> в <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Преобразуемая структура <see cref="T:System.Data.SqlTypes.SqlGuid" />.</param>
		/// <returns>Объект <see cref="T:System.Data.SqlTypes.SqlString" />, значение которого является строковым представлением заданной структуры <see cref="T:System.Data.SqlTypes.SqlGuid" />.</returns>
		// Token: 0x060025B0 RID: 9648 RVA: 0x000A8F4A File Offset: 0x000A714A
		public static explicit operator SqlString(SqlGuid x)
		{
			if (!x.IsNull)
			{
				return new SqlString(x.ToString());
			}
			return SqlString.Null;
		}

		/// <summary>Создает копию данного объекта <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Data.SqlTypes.SqlString" />, в котором все значения свойств аналогичны значениям свойств исходного объекта.</returns>
		// Token: 0x060025B1 RID: 9649 RVA: 0x000A8F6D File Offset: 0x000A716D
		public SqlString Clone()
		{
			if (this.IsNull)
			{
				return new SqlString(true);
			}
			return new SqlString(this.m_value, this.m_lcid, this.m_flag);
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlString" /> с целью определить, равны ли они.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они не равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlString" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060025B2 RID: 9650 RVA: 0x000A8F95 File Offset: 0x000A7195
		public static SqlBoolean operator ==(SqlString x, SqlString y)
		{
			return SqlString.Compare(x, y, EComparison.EQ);
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlString" /> с целью определить, отличаются ли они.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlString" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060025B3 RID: 9651 RVA: 0x000A8F9F File Offset: 0x000A719F
		public static SqlBoolean operator !=(SqlString x, SqlString y)
		{
			return !(x == y);
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlString" />, чтобы определить, меньше ли первый, чем второй.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlString" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060025B4 RID: 9652 RVA: 0x000A8FAD File Offset: 0x000A71AD
		public static SqlBoolean operator <(SqlString x, SqlString y)
		{
			return SqlString.Compare(x, y, EComparison.LT);
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlString" /> с целью определить, больше ли первый, чем второй.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlString" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060025B5 RID: 9653 RVA: 0x000A8FB7 File Offset: 0x000A71B7
		public static SqlBoolean operator >(SqlString x, SqlString y)
		{
			return SqlString.Compare(x, y, EComparison.GT);
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlString" /> с целью определить, верно ли, что первый меньше второго или равен ему.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlString" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060025B6 RID: 9654 RVA: 0x000A8FC1 File Offset: 0x000A71C1
		public static SqlBoolean operator <=(SqlString x, SqlString y)
		{
			return SqlString.Compare(x, y, EComparison.LE);
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlString" /> с целью определить, верно ли, что первый больше второго или равен ему.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlString" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060025B7 RID: 9655 RVA: 0x000A8FCB File Offset: 0x000A71CB
		public static SqlBoolean operator >=(SqlString x, SqlString y)
		{
			return SqlString.Compare(x, y, EComparison.GE);
		}

		/// <summary>Сцепляет две указанные структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlString" />, которая содержит новое сцепленное значение, представляющее собой содержимое двух параметров <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025B8 RID: 9656 RVA: 0x000A8FD5 File Offset: 0x000A71D5
		public static SqlString Concat(SqlString x, SqlString y)
		{
			return x + y;
		}

		/// <summary>Сцепляет два заданных значения <see cref="T:System.Data.SqlTypes.SqlString" /> для создания новой структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Структура <see cref="T:System.Data.SqlTypes.SqlString" />, представляющая собой сцепленное значение, составленное из <paramref name="x" /> и <paramref name="y" />.</returns>
		// Token: 0x060025B9 RID: 9657 RVA: 0x000A8FD5 File Offset: 0x000A71D5
		public static SqlString Add(SqlString x, SqlString y)
		{
			return x + y;
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlString" /> с целью определить, равны ли они.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>
		///   <see langword="true" />, если эти два значения равны. В противном случае — значение <see langword="false" />. Если один из экземпляров пуст, <see langword="SqlString" /> будет иметь значение NULL.</returns>
		// Token: 0x060025BA RID: 9658 RVA: 0x000A8FDE File Offset: 0x000A71DE
		public static SqlBoolean Equals(SqlString x, SqlString y)
		{
			return x == y;
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlString" /> с целью определить, отличаются ли они.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Переменная <see cref="T:System.Data.SqlTypes.SqlBoolean" />, которая принимает значение <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если два экземпляра не равны, или значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />, если они равны. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlString" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060025BB RID: 9659 RVA: 0x000A8FE7 File Offset: 0x000A71E7
		public static SqlBoolean NotEquals(SqlString x, SqlString y)
		{
			return x != y;
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlString" />, чтобы определить, меньше ли первый, чем второй.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlString" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060025BC RID: 9660 RVA: 0x000A8FF0 File Offset: 0x000A71F0
		public static SqlBoolean LessThan(SqlString x, SqlString y)
		{
			return x < y;
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlString" /> с целью определить, больше ли первый, чем второй.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlString" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060025BD RID: 9661 RVA: 0x000A8FF9 File Offset: 0x000A71F9
		public static SqlBoolean GreaterThan(SqlString x, SqlString y)
		{
			return x > y;
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlString" /> с целью определить, верно ли, что первый меньше второго или равен ему.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр меньше второго или ему равен. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlString" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060025BE RID: 9662 RVA: 0x000A9002 File Offset: 0x000A7202
		public static SqlBoolean LessThanOrEqual(SqlString x, SqlString y)
		{
			return x <= y;
		}

		/// <summary>Выполняет логическое сравнение двух операндов <see cref="T:System.Data.SqlTypes.SqlString" /> с целью определить, верно ли, что первый больше второго или равен ему.</summary>
		/// <param name="x">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <param name="y">Объект <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Значение типа <see cref="T:System.Data.SqlTypes.SqlBoolean" />, равное <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />, если первый экземпляр больше второго или равен ему. В противном случае — значение <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. Если один из экземпляров структуры <see cref="T:System.Data.SqlTypes.SqlString" /> пуст, свойство <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> структуры <see cref="T:System.Data.SqlTypes.SqlBoolean" /> будет иметь значение <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
		// Token: 0x060025BF RID: 9663 RVA: 0x000A900B File Offset: 0x000A720B
		public static SqlBoolean GreaterThanOrEqual(SqlString x, SqlString y)
		{
			return x >= y;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="P:System.Data.SqlTypes.SqlString.Value" /> не равно нулю; <see langword="false" />, если равно нулю; в противном случае — NULL.</returns>
		// Token: 0x060025C0 RID: 9664 RVA: 0x000A9014 File Offset: 0x000A7214
		public SqlBoolean ToSqlBoolean()
		{
			return (SqlBoolean)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
		/// <returns>Новая структура <see langword="SqlByte" />, <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> которой равно числу, представленному данной структурой <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025C1 RID: 9665 RVA: 0x000A9021 File Offset: 0x000A7221
		public SqlByte ToSqlByte()
		{
			return (SqlByte)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlDateTime" />.</summary>
		/// <returns>Новая структура <see langword="SqlDateTime" />, содержащая значение даты, представленное данной структурой <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025C2 RID: 9666 RVA: 0x000A902E File Offset: 0x000A722E
		public SqlDateTime ToSqlDateTime()
		{
			return (SqlDateTime)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDouble" />, значение которой равно числовому значению данной структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025C3 RID: 9667 RVA: 0x000A903B File Offset: 0x000A723B
		public SqlDouble ToSqlDouble()
		{
			return (SqlDouble)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlInt16" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt16" />, значение которой равно числовому значению данной структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025C4 RID: 9668 RVA: 0x000A9048 File Offset: 0x000A7248
		public SqlInt16 ToSqlInt16()
		{
			return (SqlInt16)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlInt32" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt32" />, значение которой равно числовому значению данной структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025C5 RID: 9669 RVA: 0x000A9055 File Offset: 0x000A7255
		public SqlInt32 ToSqlInt32()
		{
			return (SqlInt32)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlInt64" />, значение которой равно числовому значению данной структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025C6 RID: 9670 RVA: 0x000A9062 File Offset: 0x000A7262
		public SqlInt64 ToSqlInt64()
		{
			return (SqlInt64)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlMoney" />, значение которой равно числовому значению данной структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025C7 RID: 9671 RVA: 0x000A906F File Offset: 0x000A726F
		public SqlMoney ToSqlMoney()
		{
			return (SqlMoney)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlDecimal" />, содержащая значение данной структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025C8 RID: 9672 RVA: 0x000A907C File Offset: 0x000A727C
		public SqlDecimal ToSqlDecimal()
		{
			return (SqlDecimal)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlSingle" />, значение которой равно числовому значению данной структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025C9 RID: 9673 RVA: 0x000A9089 File Offset: 0x000A7289
		public SqlSingle ToSqlSingle()
		{
			return (SqlSingle)this;
		}

		/// <summary>Преобразует эту структуру <see cref="T:System.Data.SqlTypes.SqlString" /> в <see cref="T:System.Data.SqlTypes.SqlGuid" />.</summary>
		/// <returns>Новая структура <see cref="T:System.Data.SqlTypes.SqlGuid" />, свойство <see cref="P:System.Data.SqlTypes.SqlGuid.Value" /> которой имеет значение <see langword="Guid" />, представленное данной структурой <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025CA RID: 9674 RVA: 0x000A9096 File Offset: 0x000A7296
		public SqlGuid ToSqlGuid()
		{
			return (SqlGuid)this;
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x000A90A3 File Offset: 0x000A72A3
		private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions)
		{
			if ((compareOptions & SqlString.s_iValidSqlCompareOptionMask) != compareOptions)
			{
				throw new ArgumentOutOfRangeException("compareOptions");
			}
		}

		/// <summary>Получает эквивалент перечисления <see cref="T:System.Globalization.CompareOptions" /> указанного значения <see cref="T:System.Data.SqlTypes.SqlCompareOptions" />.</summary>
		/// <param name="compareOptions">Значение <see cref="T:System.Data.SqlTypes.SqlCompareOptions" />, которое описывает параметры сравнения для данной структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		/// <returns>Значение <see langword="CompareOptions" />, которое соответствует <see langword="SqlCompareOptions" /> для данной структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</returns>
		// Token: 0x060025CC RID: 9676 RVA: 0x000A90BC File Offset: 0x000A72BC
		public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions)
		{
			CompareOptions compareOptions2 = CompareOptions.None;
			SqlString.ValidateSqlCompareOptions(compareOptions);
			if ((compareOptions & (SqlCompareOptions.BinarySort | SqlCompareOptions.BinarySort2)) != SqlCompareOptions.None)
			{
				throw ADP.ArgumentOutOfRange("compareOptions");
			}
			if ((compareOptions & SqlCompareOptions.IgnoreCase) != SqlCompareOptions.None)
			{
				compareOptions2 |= CompareOptions.IgnoreCase;
			}
			if ((compareOptions & SqlCompareOptions.IgnoreNonSpace) != SqlCompareOptions.None)
			{
				compareOptions2 |= CompareOptions.IgnoreNonSpace;
			}
			if ((compareOptions & SqlCompareOptions.IgnoreKanaType) != SqlCompareOptions.None)
			{
				compareOptions2 |= CompareOptions.IgnoreKanaType;
			}
			if ((compareOptions & SqlCompareOptions.IgnoreWidth) != SqlCompareOptions.None)
			{
				compareOptions2 |= CompareOptions.IgnoreWidth;
			}
			return compareOptions2;
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x000A910C File Offset: 0x000A730C
		private bool FBinarySort()
		{
			return !this.IsNull && (this.m_flag & (SqlCompareOptions.BinarySort | SqlCompareOptions.BinarySort2)) > SqlCompareOptions.None;
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x000A9128 File Offset: 0x000A7328
		private static int CompareBinary(SqlString x, SqlString y)
		{
			byte[] bytes = SqlString.s_unicodeEncoding.GetBytes(x.m_value);
			byte[] bytes2 = SqlString.s_unicodeEncoding.GetBytes(y.m_value);
			int num = bytes.Length;
			int num2 = bytes2.Length;
			int num3 = (num < num2) ? num : num2;
			int i;
			for (i = 0; i < num3; i++)
			{
				if (bytes[i] < bytes2[i])
				{
					return -1;
				}
				if (bytes[i] > bytes2[i])
				{
					return 1;
				}
			}
			i = num3;
			int num4 = 32;
			if (num < num2)
			{
				while (i < num2)
				{
					int num5 = (int)bytes2[i + 1] << (int)(8 + bytes2[i]);
					if (num5 != num4)
					{
						if (num4 <= num5)
						{
							return -1;
						}
						return 1;
					}
					else
					{
						i += 2;
					}
				}
			}
			else
			{
				while (i < num)
				{
					int num5 = (int)bytes[i + 1] << (int)(8 + bytes[i]);
					if (num5 != num4)
					{
						if (num5 <= num4)
						{
							return -1;
						}
						return 1;
					}
					else
					{
						i += 2;
					}
				}
			}
			return 0;
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x000A9200 File Offset: 0x000A7400
		private static int CompareBinary2(SqlString x, SqlString y)
		{
			string value = x.m_value;
			string value2 = y.m_value;
			int length = value.Length;
			int length2 = value2.Length;
			int num = (length < length2) ? length : length2;
			for (int i = 0; i < num; i++)
			{
				if (value[i] < value2[i])
				{
					return -1;
				}
				if (value[i] > value2[i])
				{
					return 1;
				}
			}
			char c = ' ';
			if (length < length2)
			{
				int i = num;
				while (i < length2)
				{
					if (value2[i] != c)
					{
						if (c <= value2[i])
						{
							return -1;
						}
						return 1;
					}
					else
					{
						i++;
					}
				}
			}
			else
			{
				int i = num;
				while (i < length)
				{
					if (value[i] != c)
					{
						if (value[i] <= c)
						{
							return -1;
						}
						return 1;
					}
					else
					{
						i++;
					}
				}
			}
			return 0;
		}

		/// <summary>Сравнивает этот объект <see cref="T:System.Data.SqlTypes.SqlString" /> с предоставленным <see cref="T:System.Object" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Выражение <see cref="T:System.Object" /> для сравнения.</param>
		/// <returns>Число со знаком, представляющее результат сравнения значений экземпляра и объекта.  
		///   Возвращаемое значение 
		///   Условие 
		///   Меньше нуля 
		///   Этот экземпляр меньше данного объекта.  
		///
		///   Нуль 
		///   Этот экземпляр равен данному объекту.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше данного объекта 
		/// - или - 
		/// Объект является пустой ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x060025D0 RID: 9680 RVA: 0x000A92D4 File Offset: 0x000A74D4
		public int CompareTo(object value)
		{
			if (value is SqlString)
			{
				SqlString value2 = (SqlString)value;
				return this.CompareTo(value2);
			}
			throw ADP.WrongType(value.GetType(), typeof(SqlString));
		}

		/// <summary>Сравнивает этот экземпляр <see cref="T:System.Data.SqlTypes.SqlString" /> с предоставленным <see cref="T:System.Data.SqlTypes.SqlString" /> и возвращает сведения об их относительных значениях.</summary>
		/// <param name="value">Выражение <see cref="T:System.Data.SqlTypes.SqlString" /> для сравнения.</param>
		/// <returns>Число со знаком, представляющее результат сравнения значений экземпляра и объекта.  
		///   Возвращаемое значение 
		///   Условие 
		///   Меньше нуля 
		///   Этот экземпляр меньше данного объекта.  
		///
		///   Нуль 
		///   Этот экземпляр равен данному объекту.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше данного объекта 
		/// -или- 
		/// Данный объект является пустой ссылкой (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x060025D1 RID: 9681 RVA: 0x000A9310 File Offset: 0x000A7510
		public int CompareTo(SqlString value)
		{
			if (this.IsNull)
			{
				if (!value.IsNull)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (value.IsNull)
				{
					return 1;
				}
				int num = SqlString.StringCompare(this, value);
				if (num < 0)
				{
					return -1;
				}
				if (num > 0)
				{
					return 1;
				}
				return 0;
			}
		}

		/// <summary>Сравнивает предоставленный параметр объекта со свойством <see cref="P:System.Data.SqlTypes.SqlString.Value" /> объекта <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		/// <param name="value">Сравниваемый объект.</param>
		/// <returns>Значение <see langword="true" />, если объект является экземпляром структуры <see cref="T:System.Data.SqlTypes.SqlString" /> и они равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060025D2 RID: 9682 RVA: 0x000A9358 File Offset: 0x000A7558
		public override bool Equals(object value)
		{
			if (!(value is SqlString))
			{
				return false;
			}
			SqlString y = (SqlString)value;
			if (y.IsNull || this.IsNull)
			{
				return y.IsNull && this.IsNull;
			}
			return (this == y).Value;
		}

		/// <summary>Получает хэш-код для этого экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060025D3 RID: 9683 RVA: 0x000A93B0 File Offset: 0x000A75B0
		public override int GetHashCode()
		{
			if (this.IsNull)
			{
				return 0;
			}
			byte[] array;
			if (this.FBinarySort())
			{
				array = SqlString.s_unicodeEncoding.GetBytes(this.m_value.TrimEnd());
			}
			else
			{
				CompareInfo compareInfo;
				CompareOptions options;
				try
				{
					this.SetCompareInfo();
					compareInfo = this.m_cmpInfo;
					options = SqlString.CompareOptionsFromSqlCompareOptions(this.m_flag);
				}
				catch (ArgumentException)
				{
					compareInfo = CultureInfo.InvariantCulture.CompareInfo;
					options = CompareOptions.None;
				}
				array = compareInfo.GetSortKey(this.m_value.TrimEnd(), options).KeyData;
			}
			return SqlBinary.HashByteArray(array, array.Length);
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <returns>Объект <see langword="XmlSchema" />.</returns>
		// Token: 0x060025D4 RID: 9684 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="reader">
		///   <see langword="XmlReader" />
		/// </param>
		// Token: 0x060025D5 RID: 9685 RVA: 0x000A9444 File Offset: 0x000A7644
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			string attribute = reader.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				reader.ReadElementString();
				this.m_fNotNull = false;
				return;
			}
			this.m_value = reader.ReadElementString();
			this.m_fNotNull = true;
		}

		/// <summary>Данный член предназначен для поддержки платформы .NET Framework и не должен вызываться напрямую из кода приложения.</summary>
		/// <param name="writer">
		///   <see langword="XmlWriter" />
		/// </param>
		// Token: 0x060025D6 RID: 9686 RVA: 0x000A948F File Offset: 0x000A768F
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			writer.WriteString(this.m_value);
		}

		/// <summary>Возвращает XSD (XML-схему) заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>Значение <see langword="string" />, указывающее определение XML-схемы заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x060025D7 RID: 9687 RVA: 0x000A15D3 File Offset: 0x0009F7D3
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x040018E2 RID: 6370
		private string m_value;

		// Token: 0x040018E3 RID: 6371
		private CompareInfo m_cmpInfo;

		// Token: 0x040018E4 RID: 6372
		private int m_lcid;

		// Token: 0x040018E5 RID: 6373
		private SqlCompareOptions m_flag;

		// Token: 0x040018E6 RID: 6374
		private bool m_fNotNull;

		/// <summary>Представляет значение <see cref="T:System.DBNull" />, которое может быть присвоено данному экземпляру структуры <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		// Token: 0x040018E7 RID: 6375
		public static readonly SqlString Null = new SqlString(true);

		// Token: 0x040018E8 RID: 6376
		internal static readonly UnicodeEncoding s_unicodeEncoding = new UnicodeEncoding();

		/// <summary>Задает игнорирование регистра при выполнении сравнения <see cref="T:System.Data.SqlTypes.SqlString" />.</summary>
		// Token: 0x040018E9 RID: 6377
		public static readonly int IgnoreCase = 1;

		/// <summary>Задает игнорирование ширины знака при сравнении строк.</summary>
		// Token: 0x040018EA RID: 6378
		public static readonly int IgnoreWidth = 16;

		/// <summary>Задает игнорирование несамостоятельных знаков (например, диакритических) при сравнении строк.</summary>
		// Token: 0x040018EB RID: 6379
		public static readonly int IgnoreNonSpace = 2;

		/// <summary>Задает игнорирование типа японской азбуки при сравнении строк.</summary>
		// Token: 0x040018EC RID: 6380
		public static readonly int IgnoreKanaType = 8;

		/// <summary>Задает сортировку на основе числового значения символов вместо сортировки по алфавиту.</summary>
		// Token: 0x040018ED RID: 6381
		public static readonly int BinarySort = 32768;

		/// <summary>Задает сортировку на основе числового значения символов вместо сортировки по алфавиту.</summary>
		// Token: 0x040018EE RID: 6382
		public static readonly int BinarySort2 = 16384;

		// Token: 0x040018EF RID: 6383
		private static readonly SqlCompareOptions s_iDefaultFlag = SqlCompareOptions.IgnoreCase | SqlCompareOptions.IgnoreKanaType | SqlCompareOptions.IgnoreWidth;

		// Token: 0x040018F0 RID: 6384
		private static readonly CompareOptions s_iValidCompareOptionMask = CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth;

		// Token: 0x040018F1 RID: 6385
		internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask = SqlCompareOptions.IgnoreCase | SqlCompareOptions.IgnoreNonSpace | SqlCompareOptions.IgnoreKanaType | SqlCompareOptions.IgnoreWidth | SqlCompareOptions.BinarySort | SqlCompareOptions.BinarySort2;

		// Token: 0x040018F2 RID: 6386
		internal static readonly int s_lcidUSEnglish = 1033;

		// Token: 0x040018F3 RID: 6387
		private static readonly int s_lcidBinary = 33280;
	}
}
