using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.XPath;
using Unity;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет типизированное значение проверяемого XML-элемента или атрибута.
	///         <see cref="T:System.Xml.Schema.XmlAtomicValue" /> Класс не наследуется.
	///       </summary>
	// Token: 0x0200058E RID: 1422
	public sealed class XmlAtomicValue : XPathItem, ICloneable
	{
		// Token: 0x0600393C RID: 14652 RVA: 0x0014A987 File Offset: 0x00148B87
		internal XmlAtomicValue(XmlSchemaType xmlType, bool value)
		{
			if (xmlType == null)
			{
				throw new ArgumentNullException("xmlType");
			}
			this.xmlType = xmlType;
			this.clrType = TypeCode.Boolean;
			this.unionVal.boolVal = value;
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x0014A9B7 File Offset: 0x00148BB7
		internal XmlAtomicValue(XmlSchemaType xmlType, DateTime value)
		{
			if (xmlType == null)
			{
				throw new ArgumentNullException("xmlType");
			}
			this.xmlType = xmlType;
			this.clrType = TypeCode.DateTime;
			this.unionVal.dtVal = value;
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x0014A9E8 File Offset: 0x00148BE8
		internal XmlAtomicValue(XmlSchemaType xmlType, double value)
		{
			if (xmlType == null)
			{
				throw new ArgumentNullException("xmlType");
			}
			this.xmlType = xmlType;
			this.clrType = TypeCode.Double;
			this.unionVal.dblVal = value;
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x0014AA19 File Offset: 0x00148C19
		internal XmlAtomicValue(XmlSchemaType xmlType, int value)
		{
			if (xmlType == null)
			{
				throw new ArgumentNullException("xmlType");
			}
			this.xmlType = xmlType;
			this.clrType = TypeCode.Int32;
			this.unionVal.i32Val = value;
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x0014AA4A File Offset: 0x00148C4A
		internal XmlAtomicValue(XmlSchemaType xmlType, long value)
		{
			if (xmlType == null)
			{
				throw new ArgumentNullException("xmlType");
			}
			this.xmlType = xmlType;
			this.clrType = TypeCode.Int64;
			this.unionVal.i64Val = value;
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x0014AA7B File Offset: 0x00148C7B
		internal XmlAtomicValue(XmlSchemaType xmlType, string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (xmlType == null)
			{
				throw new ArgumentNullException("xmlType");
			}
			this.xmlType = xmlType;
			this.objVal = value;
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x0014AAB0 File Offset: 0x00148CB0
		internal XmlAtomicValue(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (xmlType == null)
			{
				throw new ArgumentNullException("xmlType");
			}
			this.xmlType = xmlType;
			this.objVal = value;
			if (nsResolver != null && (this.xmlType.TypeCode == XmlTypeCode.QName || this.xmlType.TypeCode == XmlTypeCode.Notation))
			{
				string prefixFromQName = this.GetPrefixFromQName(value);
				this.nsPrefix = new XmlAtomicValue.NamespacePrefixForQName(prefixFromQName, nsResolver.LookupNamespace(prefixFromQName));
			}
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x0014AA7B File Offset: 0x00148C7B
		internal XmlAtomicValue(XmlSchemaType xmlType, object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (xmlType == null)
			{
				throw new ArgumentNullException("xmlType");
			}
			this.xmlType = xmlType;
			this.objVal = value;
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x0014AB2C File Offset: 0x00148D2C
		internal XmlAtomicValue(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (xmlType == null)
			{
				throw new ArgumentNullException("xmlType");
			}
			this.xmlType = xmlType;
			this.objVal = value;
			if (nsResolver != null && (this.xmlType.TypeCode == XmlTypeCode.QName || this.xmlType.TypeCode == XmlTypeCode.Notation))
			{
				string @namespace = (this.objVal as XmlQualifiedName).Namespace;
				this.nsPrefix = new XmlAtomicValue.NamespacePrefixForQName(nsResolver.LookupPrefix(@namespace), @namespace);
			}
		}

		/// <summary>
		///         Возвращает копию этой <see cref="T:System.Xml.Schema.XmlAtomicValue" /> объекта.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlAtomicValue" /> Копию этого объекта <see cref="T:System.Xml.Schema.XmlAtomicValue" /> объекта.
		///       </returns>
		// Token: 0x06003945 RID: 14661 RVA: 0x00002068 File Offset: 0x00000268
		public XmlAtomicValue Clone()
		{
			return this;
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.Schema.XmlAtomicValue.Clone" />.
		///       </summary>
		/// <returns>
		///         Возвращает копию этой <see cref="T:System.Xml.Schema.XmlAtomicValue" /> объекта.
		///       </returns>
		// Token: 0x06003946 RID: 14662 RVA: 0x00002068 File Offset: 0x00000268
		object ICloneable.Clone()
		{
			return this;
		}

		/// <summary>
		///         Возвращает значение, указывающее, является ли проверяемый XML-элемент или атрибут узлом XPath или атомарным значением.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если проверяемый XML-элемент или атрибут является узлом XPath; <see langword="false" /> Если проверяемый XML-элемент или атрибут является атомарным значением.
		///       </returns>
		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06003947 RID: 14663 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		public override bool IsNode
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlSchemaType" /> для проверяемого XML-элемента или атрибута.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaType" /> Для проверяемого XML-элемента или атрибута.
		///       </returns>
		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x0014ABAE File Offset: 0x00148DAE
		public override XmlSchemaType XmlType
		{
			get
			{
				return this.xmlType;
			}
		}

		/// <summary>
		///         Получает тип проверяемого XML-элемента или атрибута Microsoft .NET Framework.
		///       </summary>
		/// <returns>
		///         Тип .NET Framework, проверяемого XML-элемента или атрибута.
		///          Значение по умолчанию — <see cref="T:System.String" />.
		///       </returns>
		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x0014ABB6 File Offset: 0x00148DB6
		public override Type ValueType
		{
			get
			{
				return this.xmlType.Datatype.ValueType;
			}
		}

		/// <summary>
		///         Возвращает текущий проверяемого XML-элемента или атрибута в виде упакованного объекта наиболее подходящего типа Microsoft .NET Framework согласно типу его схемы.
		///       </summary>
		/// <returns>
		///         Текущий проверяемый XML-элемента или атрибута в виде упакованного объекта наиболее подходящего типа платформы .NET Framework.
		///       </returns>
		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x0014ABC8 File Offset: 0x00148DC8
		public override object TypedValue
		{
			get
			{
				XmlValueConverter valueConverter = this.xmlType.ValueConverter;
				if (this.objVal == null)
				{
					TypeCode typeCode = this.clrType;
					if (typeCode <= TypeCode.Int32)
					{
						if (typeCode == TypeCode.Boolean)
						{
							return valueConverter.ChangeType(this.unionVal.boolVal, this.ValueType);
						}
						if (typeCode == TypeCode.Int32)
						{
							return valueConverter.ChangeType(this.unionVal.i32Val, this.ValueType);
						}
					}
					else
					{
						if (typeCode == TypeCode.Int64)
						{
							return valueConverter.ChangeType(this.unionVal.i64Val, this.ValueType);
						}
						if (typeCode == TypeCode.Double)
						{
							return valueConverter.ChangeType(this.unionVal.dblVal, this.ValueType);
						}
						if (typeCode == TypeCode.DateTime)
						{
							return valueConverter.ChangeType(this.unionVal.dtVal, this.ValueType);
						}
					}
				}
				return valueConverter.ChangeType(this.objVal, this.ValueType, this.nsPrefix);
			}
		}

		/// <summary>
		///         Возвращает проверяемого XML-элемента или атрибута как <see cref="T:System.Boolean" />.
		///       </summary>
		/// <returns>
		///         Проверяемого XML-элемента или атрибута как <see cref="T:System.Boolean" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Проверяемого XML-элемента или атрибута не находится в правильном формате для <see cref="T:System.Boolean" /> типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.Boolean" /> является недопустимым.
		///           </exception>
		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x0600394B RID: 14667 RVA: 0x0014ACA8 File Offset: 0x00148EA8
		public override bool ValueAsBoolean
		{
			get
			{
				XmlValueConverter valueConverter = this.xmlType.ValueConverter;
				if (this.objVal == null)
				{
					TypeCode typeCode = this.clrType;
					if (typeCode <= TypeCode.Int32)
					{
						if (typeCode == TypeCode.Boolean)
						{
							return this.unionVal.boolVal;
						}
						if (typeCode == TypeCode.Int32)
						{
							return valueConverter.ToBoolean(this.unionVal.i32Val);
						}
					}
					else
					{
						if (typeCode == TypeCode.Int64)
						{
							return valueConverter.ToBoolean(this.unionVal.i64Val);
						}
						if (typeCode == TypeCode.Double)
						{
							return valueConverter.ToBoolean(this.unionVal.dblVal);
						}
						if (typeCode == TypeCode.DateTime)
						{
							return valueConverter.ToBoolean(this.unionVal.dtVal);
						}
					}
				}
				return valueConverter.ToBoolean(this.objVal);
			}
		}

		/// <summary>
		///         Возвращает проверяемого XML-элемента или атрибута как <see cref="T:System.DateTime" />.
		///       </summary>
		/// <returns>
		///         Проверяемого XML-элемента или атрибута как <see cref="T:System.DateTime" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Проверяемого XML-элемента или атрибута не находится в правильном формате для <see cref="T:System.DateTime" /> типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.DateTime" /> является недопустимым.
		///           </exception>
		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x0600394C RID: 14668 RVA: 0x0014AD54 File Offset: 0x00148F54
		public override DateTime ValueAsDateTime
		{
			get
			{
				XmlValueConverter valueConverter = this.xmlType.ValueConverter;
				if (this.objVal == null)
				{
					TypeCode typeCode = this.clrType;
					if (typeCode <= TypeCode.Int32)
					{
						if (typeCode == TypeCode.Boolean)
						{
							return valueConverter.ToDateTime(this.unionVal.boolVal);
						}
						if (typeCode == TypeCode.Int32)
						{
							return valueConverter.ToDateTime(this.unionVal.i32Val);
						}
					}
					else
					{
						if (typeCode == TypeCode.Int64)
						{
							return valueConverter.ToDateTime(this.unionVal.i64Val);
						}
						if (typeCode == TypeCode.Double)
						{
							return valueConverter.ToDateTime(this.unionVal.dblVal);
						}
						if (typeCode == TypeCode.DateTime)
						{
							return this.unionVal.dtVal;
						}
					}
				}
				return valueConverter.ToDateTime(this.objVal);
			}
		}

		/// <summary>
		///         Возвращает проверяемого XML-элемента или атрибута как <see cref="T:System.Double" />.
		///       </summary>
		/// <returns>
		///         Проверяемого XML-элемента или атрибута как <see cref="T:System.Double" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Проверяемого XML-элемента или атрибута не находится в правильном формате для <see cref="T:System.Double" /> типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.Double" /> является недопустимым.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Попытка приведения привела к переполнению.
		///           </exception>
		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x0600394D RID: 14669 RVA: 0x0014AE00 File Offset: 0x00149000
		public override double ValueAsDouble
		{
			get
			{
				XmlValueConverter valueConverter = this.xmlType.ValueConverter;
				if (this.objVal == null)
				{
					TypeCode typeCode = this.clrType;
					if (typeCode <= TypeCode.Int32)
					{
						if (typeCode == TypeCode.Boolean)
						{
							return valueConverter.ToDouble(this.unionVal.boolVal);
						}
						if (typeCode == TypeCode.Int32)
						{
							return valueConverter.ToDouble(this.unionVal.i32Val);
						}
					}
					else
					{
						if (typeCode == TypeCode.Int64)
						{
							return valueConverter.ToDouble(this.unionVal.i64Val);
						}
						if (typeCode == TypeCode.Double)
						{
							return this.unionVal.dblVal;
						}
						if (typeCode == TypeCode.DateTime)
						{
							return valueConverter.ToDouble(this.unionVal.dtVal);
						}
					}
				}
				return valueConverter.ToDouble(this.objVal);
			}
		}

		/// <summary>
		///         Возвращает проверяемого XML-элемента или атрибута как <see cref="T:System.Int32" />.
		///       </summary>
		/// <returns>
		///         Проверяемого XML-элемента или атрибута как <see cref="T:System.Int32" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Проверяемого XML-элемента или атрибута не находится в правильном формате для <see cref="T:System.Int32" /> типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.Int32" /> является недопустимым.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Попытка приведения привела к переполнению.
		///           </exception>
		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x0600394E RID: 14670 RVA: 0x0014AEAC File Offset: 0x001490AC
		public override int ValueAsInt
		{
			get
			{
				XmlValueConverter valueConverter = this.xmlType.ValueConverter;
				if (this.objVal == null)
				{
					TypeCode typeCode = this.clrType;
					if (typeCode <= TypeCode.Int32)
					{
						if (typeCode == TypeCode.Boolean)
						{
							return valueConverter.ToInt32(this.unionVal.boolVal);
						}
						if (typeCode == TypeCode.Int32)
						{
							return this.unionVal.i32Val;
						}
					}
					else
					{
						if (typeCode == TypeCode.Int64)
						{
							return valueConverter.ToInt32(this.unionVal.i64Val);
						}
						if (typeCode == TypeCode.Double)
						{
							return valueConverter.ToInt32(this.unionVal.dblVal);
						}
						if (typeCode == TypeCode.DateTime)
						{
							return valueConverter.ToInt32(this.unionVal.dtVal);
						}
					}
				}
				return valueConverter.ToInt32(this.objVal);
			}
		}

		/// <summary>
		///         Возвращает проверяемого XML-элемента или атрибута как <see cref="T:System.Int64" />.
		///       </summary>
		/// <returns>
		///         Проверяемого XML-элемента или атрибута как <see cref="T:System.Int64" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Проверяемого XML-элемента или атрибута не находится в правильном формате для <see cref="T:System.Int64" /> типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.Int64" /> является недопустимым.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Попытка приведения привела к переполнению.
		///           </exception>
		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x0600394F RID: 14671 RVA: 0x0014AF58 File Offset: 0x00149158
		public override long ValueAsLong
		{
			get
			{
				XmlValueConverter valueConverter = this.xmlType.ValueConverter;
				if (this.objVal == null)
				{
					TypeCode typeCode = this.clrType;
					if (typeCode <= TypeCode.Int32)
					{
						if (typeCode == TypeCode.Boolean)
						{
							return valueConverter.ToInt64(this.unionVal.boolVal);
						}
						if (typeCode == TypeCode.Int32)
						{
							return valueConverter.ToInt64(this.unionVal.i32Val);
						}
					}
					else
					{
						if (typeCode == TypeCode.Int64)
						{
							return this.unionVal.i64Val;
						}
						if (typeCode == TypeCode.Double)
						{
							return valueConverter.ToInt64(this.unionVal.dblVal);
						}
						if (typeCode == TypeCode.DateTime)
						{
							return valueConverter.ToInt64(this.unionVal.dtVal);
						}
					}
				}
				return valueConverter.ToInt64(this.objVal);
			}
		}

		/// <summary>
		///         Возвращает проверяемого XML-элемента или атрибута как тип, указанный с помощью <see cref="T:System.Xml.IXmlNamespaceResolver" /> объект, заданный для разрешения префиксов пространств имен.
		///       </summary>
		/// <param name="type">
		///           Тип, возвращаемый как проверяемого XML-элемента или атрибута.
		///         </param>
		/// <param name="nsResolver">
		///           Объект <see cref="T:System.Xml.IXmlNamespaceResolver" />, используемый для разрешения префиксов пространств имен.
		///         </param>
		/// <returns>
		///         Значение проверяемого XML-элемента или атрибута в заданном типе.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Проверяемого XML-элемента или атрибута не правильный формат для целевого типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Попытка приведения привела к переполнению.
		///           </exception>
		// Token: 0x06003950 RID: 14672 RVA: 0x0014B004 File Offset: 0x00149204
		public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver)
		{
			XmlValueConverter valueConverter = this.xmlType.ValueConverter;
			if (type == typeof(XPathItem) || type == typeof(XmlAtomicValue))
			{
				return this;
			}
			if (this.objVal == null)
			{
				TypeCode typeCode = this.clrType;
				if (typeCode <= TypeCode.Int32)
				{
					if (typeCode == TypeCode.Boolean)
					{
						return valueConverter.ChangeType(this.unionVal.boolVal, type);
					}
					if (typeCode == TypeCode.Int32)
					{
						return valueConverter.ChangeType(this.unionVal.i32Val, type);
					}
				}
				else
				{
					if (typeCode == TypeCode.Int64)
					{
						return valueConverter.ChangeType(this.unionVal.i64Val, type);
					}
					if (typeCode == TypeCode.Double)
					{
						return valueConverter.ChangeType(this.unionVal.dblVal, type);
					}
					if (typeCode == TypeCode.DateTime)
					{
						return valueConverter.ChangeType(this.unionVal.dtVal, type);
					}
				}
			}
			return valueConverter.ChangeType(this.objVal, type, nsResolver);
		}

		/// <summary>
		///         Возвращает <see langword="string" /> значение проверяемого XML-элемента или атрибута.
		///       </summary>
		/// <returns>
		///         <see langword="string" /> Значение проверяемого XML-элемента или атрибута.
		///       </returns>
		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06003951 RID: 14673 RVA: 0x0014B0E4 File Offset: 0x001492E4
		public override string Value
		{
			get
			{
				XmlValueConverter valueConverter = this.xmlType.ValueConverter;
				if (this.objVal == null)
				{
					TypeCode typeCode = this.clrType;
					if (typeCode <= TypeCode.Int32)
					{
						if (typeCode == TypeCode.Boolean)
						{
							return valueConverter.ToString(this.unionVal.boolVal);
						}
						if (typeCode == TypeCode.Int32)
						{
							return valueConverter.ToString(this.unionVal.i32Val);
						}
					}
					else
					{
						if (typeCode == TypeCode.Int64)
						{
							return valueConverter.ToString(this.unionVal.i64Val);
						}
						if (typeCode == TypeCode.Double)
						{
							return valueConverter.ToString(this.unionVal.dblVal);
						}
						if (typeCode == TypeCode.DateTime)
						{
							return valueConverter.ToString(this.unionVal.dtVal);
						}
					}
				}
				return valueConverter.ToString(this.objVal, this.nsPrefix);
			}
		}

		/// <summary>
		///         Возвращает <see langword="string" /> значение проверяемого XML-элемента или атрибута.
		///       </summary>
		/// <returns>
		///         <see langword="string" /> Значение проверяемого XML-элемента или атрибута.
		///       </returns>
		// Token: 0x06003952 RID: 14674 RVA: 0x00085626 File Offset: 0x00083826
		public override string ToString()
		{
			return this.Value;
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x0014B19C File Offset: 0x0014939C
		private string GetPrefixFromQName(string value)
		{
			int num2;
			int num = ValidateNames.ParseQName(value, 0, out num2);
			if (num == 0 || num != value.Length)
			{
				return null;
			}
			if (num2 != 0)
			{
				return value.Substring(0, num2);
			}
			return string.Empty;
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x00067344 File Offset: 0x00065544
		internal XmlAtomicValue()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04002A9A RID: 10906
		private XmlSchemaType xmlType;

		// Token: 0x04002A9B RID: 10907
		private object objVal;

		// Token: 0x04002A9C RID: 10908
		private TypeCode clrType;

		// Token: 0x04002A9D RID: 10909
		private XmlAtomicValue.Union unionVal;

		// Token: 0x04002A9E RID: 10910
		private XmlAtomicValue.NamespacePrefixForQName nsPrefix;

		// Token: 0x0200058F RID: 1423
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private struct Union
		{
			// Token: 0x04002A9F RID: 10911
			[FieldOffset(0)]
			public bool boolVal;

			// Token: 0x04002AA0 RID: 10912
			[FieldOffset(0)]
			public double dblVal;

			// Token: 0x04002AA1 RID: 10913
			[FieldOffset(0)]
			public long i64Val;

			// Token: 0x04002AA2 RID: 10914
			[FieldOffset(0)]
			public int i32Val;

			// Token: 0x04002AA3 RID: 10915
			[FieldOffset(0)]
			public DateTime dtVal;
		}

		// Token: 0x02000590 RID: 1424
		private class NamespacePrefixForQName : IXmlNamespaceResolver
		{
			// Token: 0x06003955 RID: 14677 RVA: 0x0014B1D2 File Offset: 0x001493D2
			public NamespacePrefixForQName(string prefix, string ns)
			{
				this.ns = ns;
				this.prefix = prefix;
			}

			// Token: 0x06003956 RID: 14678 RVA: 0x0014B1E8 File Offset: 0x001493E8
			public string LookupNamespace(string prefix)
			{
				if (prefix == this.prefix)
				{
					return this.ns;
				}
				return null;
			}

			// Token: 0x06003957 RID: 14679 RVA: 0x0014B200 File Offset: 0x00149400
			public string LookupPrefix(string namespaceName)
			{
				if (this.ns == namespaceName)
				{
					return this.prefix;
				}
				return null;
			}

			// Token: 0x06003958 RID: 14680 RVA: 0x0014B218 File Offset: 0x00149418
			public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>(1);
				dictionary[this.prefix] = this.ns;
				return dictionary;
			}

			// Token: 0x04002AA4 RID: 10916
			public string prefix;

			// Token: 0x04002AA5 RID: 10917
			public string ns;
		}
	}
}
