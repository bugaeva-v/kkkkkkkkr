using System;
using System.Collections;
using System.Globalization;
using System.Text;

namespace System.Xml.Schema
{
	/// <summary>
	///         <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> — Абстрактный класс для сопоставления типов языка XSD определения XML-схемы типов Common Language Runtime (CLR).
	///       </summary>
	// Token: 0x020005A8 RID: 1448
	public abstract class XmlSchemaDatatype
	{
		/// <summary>
		///         При переопределении в производном классе возвращает тип элемента Common Language Runtime (CLR).
		///       </summary>
		/// <returns>
		///         Тип элемента Common Language Runtime (CLR).
		///       </returns>
		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06003A82 RID: 14978
		public abstract Type ValueType { get; }

		/// <summary>
		///         При переопределении в производном классе возвращает тип для <see langword="string" /> указан в World Wide Web Consortium (W3C) XML 1.0 спецификация.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlTokenizedType" /> Значение <see langword="string" />.
		///       </returns>
		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06003A83 RID: 14979
		public abstract XmlTokenizedType TokenizedType { get; }

		/// <summary>
		///         При переопределении в производном классе проверяет <see langword="string" /> к встроенной или определяемой пользователем простой тип.
		///       </summary>
		/// <param name="s">
		///           <see langword="string" /> Для проверки простого типа.
		///         </param>
		/// <param name="nameTable">
		///           <see cref="T:System.Xml.XmlNameTable" /> Для атомизации при синтаксическом анализе <see langword="string" /> Если <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> объект представляет тип xs: NCName.
		///         </param>
		/// <param name="nsmgr">
		///           <see cref="T:System.Xml.IXmlNamespaceResolver" /> Объекта для использования при анализе <see langword="string" /> Если <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> объект представляет тип xs: QName.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Object" /> Может быть безопасно приведено к типу, возвращаемому <see cref="P:System.Xml.Schema.XmlSchemaDatatype.ValueType" /> свойство.
		///       </returns>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">
		///             Входное значение не допустимый экземпляр этого типа схемы W3C XML.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение для разбора не может быть <see langword="null" />.
		///           </exception>
		// Token: 0x06003A84 RID: 14980
		public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlSchemaDatatypeVariety" /> значение простого типа.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaDatatypeVariety" /> Значение простого типа.
		///       </returns>
		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06003A85 RID: 14981 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		public virtual XmlSchemaDatatypeVariety Variety
		{
			get
			{
				return XmlSchemaDatatypeVariety.Atomic;
			}
		}

		/// <summary>
		///         Преобразует указанное значение, тип которого одним из допустимых представлений Common Language Runtime (CLR) типа схемы XML представлен <see cref="T:System.Xml.Schema.XmlSchemaDatatype" />, в заданный тип CLR.
		///       </summary>
		/// <param name="value">
		///           Входное значение для преобразования в указанный тип.
		///         </param>
		/// <param name="targetType">
		///           Целевой тип для преобразования входного значения.
		///         </param>
		/// <returns>
		///         Преобразованное входное значение.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение параметра <see cref="T:System.Object" /> или параметра <see cref="T:System.Type" /> — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Тип, представленный <see cref="T:System.Xml.Schema.XmlSchemaDatatype" />   не поддерживает преобразование из типа значения, указанного в указанный тип.
		///           </exception>
		// Token: 0x06003A86 RID: 14982 RVA: 0x0014D338 File Offset: 0x0014B538
		public virtual object ChangeType(object value, Type targetType)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (targetType == null)
			{
				throw new ArgumentNullException("targetType");
			}
			return this.ValueConverter.ChangeType(value, targetType);
		}

		/// <summary>
		///         Преобразует указанное значение, тип которого одним из допустимых представлений Common Language Runtime (CLR) типа схемы XML представлен <see cref="T:System.Xml.Schema.XmlSchemaDatatype" />, на тип среды CLR, заданное с помощью <see cref="T:System.Xml.IXmlNamespaceResolver" /> Если <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> представляет тип xs: QName или тип, производный от него.
		///       </summary>
		/// <param name="value">
		///           Входное значение для преобразования в указанный тип.
		///         </param>
		/// <param name="targetType">
		///           Целевой тип для преобразования входного значения.
		///         </param>
		/// <param name="namespaceResolver">
		///           <see cref="T:System.Xml.IXmlNamespaceResolver" /> Для разрешения префиксов пространств имен.
		///            Это только если <see cref="T:System.Xml.Schema.XmlSchemaDatatype" />  представляет тип xs: QName или тип, производный от него.
		///         </param>
		/// <returns>
		///         Преобразованное входное значение.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение параметра <see cref="T:System.Object" /> или параметра <see cref="T:System.Type" /> — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Тип, представленный <see cref="T:System.Xml.Schema.XmlSchemaDatatype" />   не поддерживает преобразование из типа значения, указанного в указанный тип.
		///           </exception>
		// Token: 0x06003A87 RID: 14983 RVA: 0x0014D369 File Offset: 0x0014B569
		public virtual object ChangeType(object value, Type targetType, IXmlNamespaceResolver namespaceResolver)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (targetType == null)
			{
				throw new ArgumentNullException("targetType");
			}
			if (namespaceResolver == null)
			{
				throw new ArgumentNullException("namespaceResolver");
			}
			return this.ValueConverter.ChangeType(value, targetType, namespaceResolver);
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlTypeCode" /> значение простого типа.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlTypeCode" /> Значение простого типа.
		///       </returns>
		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06003A88 RID: 14984 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		public virtual XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.None;
			}
		}

		/// <summary>
		///         <see cref="M:System.Xml.Schema.XmlSchemaDatatype.IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype)" /> Метод всегда возвращает <see langword="false" />.
		///       </summary>
		/// <param name="datatype">
		///           <see cref="T:System.Xml.Schema.XmlSchemaDatatype" />.
		///         </param>
		/// <returns>
		///         Всегда возвращает значение <see langword="false" />.
		///       </returns>
		// Token: 0x06003A89 RID: 14985 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype)
		{
			return false;
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06003A8A RID: 14986
		internal abstract bool HasLexicalFacets { get; }

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06003A8B RID: 14987
		internal abstract bool HasValueFacets { get; }

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06003A8C RID: 14988
		internal abstract XmlValueConverter ValueConverter { get; }

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06003A8D RID: 14989
		// (set) Token: 0x06003A8E RID: 14990
		internal abstract RestrictionFacets Restriction { get; set; }

		// Token: 0x06003A8F RID: 14991
		internal abstract int Compare(object value1, object value2);

		// Token: 0x06003A90 RID: 14992
		internal abstract object ParseValue(string s, Type typDest, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

		// Token: 0x06003A91 RID: 14993
		internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue);

		// Token: 0x06003A92 RID: 14994
		internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

		// Token: 0x06003A93 RID: 14995
		internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue);

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06003A94 RID: 14996
		internal abstract FacetsChecker FacetsChecker { get; }

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06003A95 RID: 14997
		internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

		// Token: 0x06003A96 RID: 14998
		internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType);

		// Token: 0x06003A97 RID: 14999
		internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType);

		// Token: 0x06003A98 RID: 15000
		internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller);

		// Token: 0x06003A99 RID: 15001
		internal abstract bool IsEqual(object o1, object o2);

		// Token: 0x06003A9A RID: 15002
		internal abstract bool IsComparable(XmlSchemaDatatype dtype);

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06003A9B RID: 15003 RVA: 0x0014D3AC File Offset: 0x0014B5AC
		internal string TypeCodeString
		{
			get
			{
				string result = string.Empty;
				XmlTypeCode typeCode = this.TypeCode;
				switch (this.Variety)
				{
				case XmlSchemaDatatypeVariety.Atomic:
					if (typeCode == XmlTypeCode.AnyAtomicType)
					{
						result = "anySimpleType";
					}
					else
					{
						result = this.TypeCodeToString(typeCode);
					}
					break;
				case XmlSchemaDatatypeVariety.List:
					if (typeCode == XmlTypeCode.AnyAtomicType)
					{
						result = "List of Union";
					}
					else
					{
						result = "List of " + this.TypeCodeToString(typeCode);
					}
					break;
				case XmlSchemaDatatypeVariety.Union:
					result = "Union";
					break;
				}
				return result;
			}
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x0014D420 File Offset: 0x0014B620
		internal string TypeCodeToString(XmlTypeCode typeCode)
		{
			switch (typeCode)
			{
			case XmlTypeCode.None:
				return "None";
			case XmlTypeCode.Item:
				return "AnyType";
			case XmlTypeCode.AnyAtomicType:
				return "AnyAtomicType";
			case XmlTypeCode.String:
				return "String";
			case XmlTypeCode.Boolean:
				return "Boolean";
			case XmlTypeCode.Decimal:
				return "Decimal";
			case XmlTypeCode.Float:
				return "Float";
			case XmlTypeCode.Double:
				return "Double";
			case XmlTypeCode.Duration:
				return "Duration";
			case XmlTypeCode.DateTime:
				return "DateTime";
			case XmlTypeCode.Time:
				return "Time";
			case XmlTypeCode.Date:
				return "Date";
			case XmlTypeCode.GYearMonth:
				return "GYearMonth";
			case XmlTypeCode.GYear:
				return "GYear";
			case XmlTypeCode.GMonthDay:
				return "GMonthDay";
			case XmlTypeCode.GDay:
				return "GDay";
			case XmlTypeCode.GMonth:
				return "GMonth";
			case XmlTypeCode.HexBinary:
				return "HexBinary";
			case XmlTypeCode.Base64Binary:
				return "Base64Binary";
			case XmlTypeCode.AnyUri:
				return "AnyUri";
			case XmlTypeCode.QName:
				return "QName";
			case XmlTypeCode.Notation:
				return "Notation";
			case XmlTypeCode.NormalizedString:
				return "NormalizedString";
			case XmlTypeCode.Token:
				return "Token";
			case XmlTypeCode.Language:
				return "Language";
			case XmlTypeCode.NmToken:
				return "NmToken";
			case XmlTypeCode.Name:
				return "Name";
			case XmlTypeCode.NCName:
				return "NCName";
			case XmlTypeCode.Id:
				return "Id";
			case XmlTypeCode.Idref:
				return "Idref";
			case XmlTypeCode.Entity:
				return "Entity";
			case XmlTypeCode.Integer:
				return "Integer";
			case XmlTypeCode.NonPositiveInteger:
				return "NonPositiveInteger";
			case XmlTypeCode.NegativeInteger:
				return "NegativeInteger";
			case XmlTypeCode.Long:
				return "Long";
			case XmlTypeCode.Int:
				return "Int";
			case XmlTypeCode.Short:
				return "Short";
			case XmlTypeCode.Byte:
				return "Byte";
			case XmlTypeCode.NonNegativeInteger:
				return "NonNegativeInteger";
			case XmlTypeCode.UnsignedLong:
				return "UnsignedLong";
			case XmlTypeCode.UnsignedInt:
				return "UnsignedInt";
			case XmlTypeCode.UnsignedShort:
				return "UnsignedShort";
			case XmlTypeCode.UnsignedByte:
				return "UnsignedByte";
			case XmlTypeCode.PositiveInteger:
				return "PositiveInteger";
			}
			return typeCode.ToString();
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x0014D624 File Offset: 0x0014B824
		internal static string ConcatenatedToString(object value)
		{
			Type type = value.GetType();
			string result = string.Empty;
			if (type == typeof(IEnumerable) && type != typeof(string))
			{
				StringBuilder stringBuilder = new StringBuilder();
				IEnumerator enumerator = (value as IEnumerable).GetEnumerator();
				if (enumerator.MoveNext())
				{
					stringBuilder.Append("{");
					object obj = enumerator.Current;
					if (obj is IFormattable)
					{
						stringBuilder.Append(((IFormattable)obj).ToString("", CultureInfo.InvariantCulture));
					}
					else
					{
						stringBuilder.Append(obj.ToString());
					}
					while (enumerator.MoveNext())
					{
						stringBuilder.Append(" , ");
						obj = enumerator.Current;
						if (obj is IFormattable)
						{
							stringBuilder.Append(((IFormattable)obj).ToString("", CultureInfo.InvariantCulture));
						}
						else
						{
							stringBuilder.Append(obj.ToString());
						}
					}
					stringBuilder.Append("}");
					result = stringBuilder.ToString();
				}
			}
			else if (value is IFormattable)
			{
				result = ((IFormattable)value).ToString("", CultureInfo.InvariantCulture);
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x0014D760 File Offset: 0x0014B960
		internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token)
		{
			return DatatypeImplementation.FromXmlTokenizedType(token);
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x0014D768 File Offset: 0x0014B968
		internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token)
		{
			return DatatypeImplementation.FromXmlTokenizedTypeXsd(token);
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x0014D770 File Offset: 0x0014B970
		internal static XmlSchemaDatatype FromXdrName(string name)
		{
			return DatatypeImplementation.FromXdrName(name);
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x0014D778 File Offset: 0x0014B978
		internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType)
		{
			return DatatypeImplementation.DeriveByUnion(types, schemaType);
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x0014D784 File Offset: 0x0014B984
		internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames)
		{
			int num = 5;
			bool flag = false;
			if (uri.Length > 5 && uri.StartsWith("uuid:", StringComparison.Ordinal))
			{
				flag = true;
			}
			else if (uri.Length > 9 && uri.StartsWith("urn:uuid:", StringComparison.Ordinal))
			{
				flag = true;
				num = 9;
			}
			string text;
			if (flag)
			{
				text = nameTable.Add(uri.Substring(0, num) + uri.Substring(num, uri.Length - num).ToUpper(CultureInfo.InvariantCulture));
			}
			else
			{
				text = uri;
			}
			if (Ref.Equal(schemaNames.NsDataTypeAlias, text) || Ref.Equal(schemaNames.NsDataTypeOld, text))
			{
				text = schemaNames.NsDataType;
			}
			else if (Ref.Equal(schemaNames.NsXdrAlias, text))
			{
				text = schemaNames.NsXdr;
			}
			return text;
		}
	}
}
