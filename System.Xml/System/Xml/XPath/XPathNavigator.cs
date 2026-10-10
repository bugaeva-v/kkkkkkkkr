using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Schema;
using MS.Internal.Xml.XPath;

namespace System.Xml.XPath
{
	/// <summary>
	///         Представляет модель курсора для навигации по данным XML и их редактирования.
	///       </summary>
	// Token: 0x02000259 RID: 601
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XPathNavigator : XPathItem, ICloneable, IXPathNavigable, IXmlNamespaceResolver
	{
		/// <summary>
		///         Возвращает текстовое значение текущего узла.
		///       </summary>
		/// <returns>
		///         Объект <see langword="string" /> содержащий текстовое значение текущего узла.
		///       </returns>
		// Token: 0x06001605 RID: 5637 RVA: 0x00085626 File Offset: 0x00083826
		public override string ToString()
		{
			return this.Value;
		}

		/// <summary>
		///         Возвращает значение, указывающее, представлен ли узел XPath текущим узлом.
		///       </summary>
		/// <returns>
		///         Всегда возвращает значение <see langword="true" />.
		///       </returns>
		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x0001222F File Offset: 0x0001042F
		public sealed override bool IsNode
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlSchemaType" /> сведения для текущего узла.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaType" /> Объекта; значение по умолчанию — <see langword="null" />.
		///       </returns>
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x00085630 File Offset: 0x00083830
		public override XmlSchemaType XmlType
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo == null || schemaInfo.Validity != XmlSchemaValidity.Valid)
				{
					return null;
				}
				XmlSchemaType memberType = schemaInfo.MemberType;
				if (memberType != null)
				{
					return memberType;
				}
				return schemaInfo.SchemaType;
			}
		}

		/// <summary>
		///         Устанавливает значение текущего узла.
		///       </summary>
		/// <param name="value">
		///           Новое значение узла.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр value имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> расположен в корневом узле, узле пространства имен, или указанное значение является недопустимым.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x06001608 RID: 5640 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual void SetValue(string value)
		{
			throw new NotSupportedException();
		}

		/// <summary>
		///         Возвращает текущий узел в виде упакованного объекта наиболее подходящего типа .NET Framework.
		///       </summary>
		/// <returns>
		///         Текущий узел в виде упакованного объекта наиболее подходящего типа .NET Framework.
		///       </returns>
		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x00085664 File Offset: 0x00083864
		public override object TypedValue
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ChangeType(this.Value, datatype.ValueType, this);
							}
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ChangeType(datatype.ParseValue(this.Value, this.NameTable, this), datatype.ValueType, this);
							}
						}
					}
				}
				return this.Value;
			}
		}

		/// <summary>
		///         Устанавливает типизированное значение текущего узла.
		///       </summary>
		/// <param name="typedValue">
		///           Новое типизированное значение узла.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает тип указанного объекта.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Указанное значение не может быть <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не находится в узле элемента или атрибута.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x0600160A RID: 5642 RVA: 0x000856FC File Offset: 0x000838FC
		public virtual void SetTypedValue(object typedValue)
		{
			if (typedValue == null)
			{
				throw new ArgumentNullException("typedValue");
			}
			XPathNodeType nodeType = this.NodeType;
			if (nodeType - XPathNodeType.Element > 1)
			{
				throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current position of the navigator."));
			}
			string text = null;
			IXmlSchemaInfo schemaInfo = this.SchemaInfo;
			if (schemaInfo != null)
			{
				XmlSchemaType schemaType = schemaInfo.SchemaType;
				if (schemaType != null)
				{
					text = schemaType.ValueConverter.ToString(typedValue, this);
					XmlSchemaDatatype datatype = schemaType.Datatype;
					if (datatype != null)
					{
						datatype.ParseValue(text, this.NameTable, this);
					}
				}
			}
			if (text == null)
			{
				text = XmlUntypedConverter.Untyped.ToString(typedValue, this);
			}
			this.SetValue(text);
		}

		/// <summary>
		///         Получает <see cref="T:System.Type" /> платформы .NET Framework текущего узла.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Type" /> платформы .NET Framework текущего узла.
		///          Значение по умолчанию — <see cref="T:System.String" />.
		///       </returns>
		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x0008578C File Offset: 0x0008398C
		public override Type ValueType
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return datatype.ValueType;
							}
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return datatype.ValueType;
							}
						}
					}
				}
				return typeof(string);
			}
		}

		/// <summary>
		///         Возвращает значение текущего узла в виде <see cref="T:System.Boolean" />.
		///       </summary>
		/// <returns>
		///         Значение текущего узла <see cref="T:System.Boolean" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Невозможно преобразовать строковое значение текущего узла в <see cref="T:System.Boolean" />.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.Boolean" /> является недопустимым.
		///           </exception>
		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x000857F8 File Offset: 0x000839F8
		public override bool ValueAsBoolean
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							return xmlSchemaType.ValueConverter.ToBoolean(this.Value);
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ToBoolean(datatype.ParseValue(this.Value, this.NameTable, this));
							}
						}
					}
				}
				return XmlUntypedConverter.Untyped.ToBoolean(this.Value);
			}
		}

		/// <summary>
		///         Возвращает значение текущего узла в виде <see cref="T:System.DateTime" />.
		///       </summary>
		/// <returns>
		///         Значение текущего узла <see cref="T:System.DateTime" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Невозможно преобразовать строковое значение текущего узла в <see cref="T:System.DateTime" />.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.DateTime" /> является недопустимым.
		///           </exception>
		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x00085884 File Offset: 0x00083A84
		public override DateTime ValueAsDateTime
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							return xmlSchemaType.ValueConverter.ToDateTime(this.Value);
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ToDateTime(datatype.ParseValue(this.Value, this.NameTable, this));
							}
						}
					}
				}
				return XmlUntypedConverter.Untyped.ToDateTime(this.Value);
			}
		}

		/// <summary>
		///         Возвращает значение текущего узла в виде <see cref="T:System.Double" />.
		///       </summary>
		/// <returns>
		///         Значение текущего узла <see cref="T:System.Double" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Невозможно преобразовать строковое значение текущего узла в <see cref="T:System.Double" />.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.Double" /> является недопустимым.
		///           </exception>
		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x00085910 File Offset: 0x00083B10
		public override double ValueAsDouble
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							return xmlSchemaType.ValueConverter.ToDouble(this.Value);
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ToDouble(datatype.ParseValue(this.Value, this.NameTable, this));
							}
						}
					}
				}
				return XmlUntypedConverter.Untyped.ToDouble(this.Value);
			}
		}

		/// <summary>
		///         Возвращает значение текущего узла в виде <see cref="T:System.Int32" />.
		///       </summary>
		/// <returns>
		///         Значение текущего узла <see cref="T:System.Int32" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Невозможно преобразовать строковое значение текущего узла в <see cref="T:System.Int32" />.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.Int32" /> является недопустимым.
		///           </exception>
		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x0008599C File Offset: 0x00083B9C
		public override int ValueAsInt
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							return xmlSchemaType.ValueConverter.ToInt32(this.Value);
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ToInt32(datatype.ParseValue(this.Value, this.NameTable, this));
							}
						}
					}
				}
				return XmlUntypedConverter.Untyped.ToInt32(this.Value);
			}
		}

		/// <summary>
		///         Возвращает значение текущего узла в виде <see cref="T:System.Int64" />.
		///       </summary>
		/// <returns>
		///         Значение текущего узла <see cref="T:System.Int64" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Невозможно преобразовать строковое значение текущего узла в <see cref="T:System.Int64" />.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.Int64" /> является недопустимым.
		///           </exception>
		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x00085A28 File Offset: 0x00083C28
		public override long ValueAsLong
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							return xmlSchemaType.ValueConverter.ToInt64(this.Value);
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ToInt64(datatype.ParseValue(this.Value, this.NameTable, this));
							}
						}
					}
				}
				return XmlUntypedConverter.Untyped.ToInt64(this.Value);
			}
		}

		/// <summary>
		///         Возвращает значение текущего узла в виде <see cref="T:System.Type" /> указан, используется <see cref="T:System.Xml.IXmlNamespaceResolver" /> объект, заданный для разрешения префиксов пространства имен.
		///       </summary>
		/// <param name="returnType">
		///           <see cref="T:System.Type" /> Необходимо возвратить значение текущего узла.
		///         </param>
		/// <param name="nsResolver">
		///           Объект <see cref="T:System.Xml.IXmlNamespaceResolver" />, используемый для разрешения префиксов пространств имен.
		///         </param>
		/// <returns>
		///         Значение текущего узла в виде <see cref="T:System.Type" /> запрошено.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Значение текущего узла не в формате, необходимом для целевого типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		// Token: 0x06001611 RID: 5649 RVA: 0x00085AB4 File Offset: 0x00083CB4
		public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver)
		{
			if (nsResolver == null)
			{
				nsResolver = this;
			}
			IXmlSchemaInfo schemaInfo = this.SchemaInfo;
			if (schemaInfo != null)
			{
				if (schemaInfo.Validity == XmlSchemaValidity.Valid)
				{
					XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
					if (xmlSchemaType == null)
					{
						xmlSchemaType = schemaInfo.SchemaType;
					}
					if (xmlSchemaType != null)
					{
						return xmlSchemaType.ValueConverter.ChangeType(this.Value, returnType, nsResolver);
					}
				}
				else
				{
					XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
					if (xmlSchemaType != null)
					{
						XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
						if (datatype != null)
						{
							return xmlSchemaType.ValueConverter.ChangeType(datatype.ParseValue(this.Value, this.NameTable, nsResolver), returnType, nsResolver);
						}
					}
				}
			}
			return XmlUntypedConverter.Untyped.ChangeType(this.Value, returnType, nsResolver);
		}

		/// <summary>
		///         Создает новую копию <see cref="T:System.Xml.XPath.XPathNavigator" /> объекта.
		///       </summary>
		/// <returns>
		///         Новая копия объекта <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </returns>
		// Token: 0x06001612 RID: 5650 RVA: 0x00085B49 File Offset: 0x00083D49
		object ICloneable.Clone()
		{
			return this.Clone();
		}

		/// <summary>
		///         Возвращает копию <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XPath.XPathNavigator" /> Копию данного объекта <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </returns>
		// Token: 0x06001613 RID: 5651 RVA: 0x00085B49 File Offset: 0x00083D49
		public virtual XPathNavigator CreateNavigator()
		{
			return this.Clone();
		}

		/// <summary>
		///         При переопределении в производном классе, возвращает <see cref="T:System.Xml.XmlNameTable" /> из <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNameTable" /> Объект, позволяющий возвращать разделенную версию <see cref="T:System.String" /> документа XML.
		///       </returns>
		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001614 RID: 5652
		public abstract XmlNameTable NameTable { get; }

		/// <summary>
		///         Возвращает URI пространства имен для указанного префикса.
		///       </summary>
		/// <param name="prefix">
		///           Префикс, для которого требуется разрешить URI пространства имен.
		///            Чтобы сопоставить пространство имен по умолчанию, необходимо передать <see cref="F:System.String.Empty" />.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.String" /> содержащая пространство имен URI, назначен префикс пространства имен указано; <see langword="null" /> Если пространство имен не назначен URI указан префикс.
		///         <see cref="T:System.String" /> Возвращается атомизирована.
		///       </returns>
		// Token: 0x06001615 RID: 5653 RVA: 0x00085B54 File Offset: 0x00083D54
		public virtual string LookupNamespace(string prefix)
		{
			if (prefix == null)
			{
				return null;
			}
			if (this.NodeType != XPathNodeType.Element)
			{
				XPathNavigator xpathNavigator = this.Clone();
				if (xpathNavigator.MoveToParent())
				{
					return xpathNavigator.LookupNamespace(prefix);
				}
			}
			else if (this.MoveToNamespace(prefix))
			{
				string value = this.Value;
				this.MoveToParent();
				return value;
			}
			if (prefix.Length == 0)
			{
				return string.Empty;
			}
			if (prefix == "xml")
			{
				return "http://www.w3.org/XML/1998/namespace";
			}
			if (prefix == "xmlns")
			{
				return "http://www.w3.org/2000/xmlns/";
			}
			return null;
		}

		/// <summary>
		///         Возвращает префикс, объявленный для указанного URI пространства имен.
		///       </summary>
		/// <param name="namespaceURI">
		///           URI пространства имен, который необходимо разрешить для получения префикса.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.String" /> содержащая префикс пространства имен, назначаемый пространства имен URI задан; в противном случае — <see cref="F:System.String.Empty" /> Если префикс не назначен URI пространства имен.
		///         <see cref="T:System.String" /> Возвращается атомизирована.
		///       </returns>
		// Token: 0x06001616 RID: 5654 RVA: 0x00085BD4 File Offset: 0x00083DD4
		public virtual string LookupPrefix(string namespaceURI)
		{
			if (namespaceURI == null)
			{
				return null;
			}
			XPathNavigator xpathNavigator = this.Clone();
			if (this.NodeType != XPathNodeType.Element)
			{
				if (xpathNavigator.MoveToParent())
				{
					return xpathNavigator.LookupPrefix(namespaceURI);
				}
			}
			else if (xpathNavigator.MoveToFirstNamespace(XPathNamespaceScope.All))
			{
				while (!(namespaceURI == xpathNavigator.Value))
				{
					if (!xpathNavigator.MoveToNextNamespace(XPathNamespaceScope.All))
					{
						goto IL_4C;
					}
				}
				return xpathNavigator.LocalName;
			}
			IL_4C:
			if (namespaceURI == this.LookupNamespace(string.Empty))
			{
				return string.Empty;
			}
			if (namespaceURI == "http://www.w3.org/XML/1998/namespace")
			{
				return "xml";
			}
			if (namespaceURI == "http://www.w3.org/2000/xmlns/")
			{
				return "xmlns";
			}
			return null;
		}

		/// <summary>
		///         Возвращает пространства имен, находящиеся в области видимости для текущего узла.
		///       </summary>
		/// <param name="scope">
		///           <see cref="T:System.Xml.XmlNamespaceScope" /> Указание пространств имен, чтобы вернуть значение.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Collections.Generic.IDictionary`2" /> Коллекции имен пространств имен, отсортированных по префиксу.
		///       </returns>
		// Token: 0x06001617 RID: 5655 RVA: 0x00085C70 File Offset: 0x00083E70
		public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			XPathNodeType nodeType = this.NodeType;
			if ((nodeType != XPathNodeType.Element && scope != XmlNamespaceScope.Local) || nodeType == XPathNodeType.Attribute || nodeType == XPathNodeType.Namespace)
			{
				XPathNavigator xpathNavigator = this.Clone();
				if (xpathNavigator.MoveToParent())
				{
					return xpathNavigator.GetNamespacesInScope(scope);
				}
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (scope == XmlNamespaceScope.All)
			{
				dictionary["xml"] = "http://www.w3.org/XML/1998/namespace";
			}
			if (this.MoveToFirstNamespace((XPathNamespaceScope)scope))
			{
				do
				{
					string localName = this.LocalName;
					string value = this.Value;
					if (localName.Length != 0 || value.Length != 0 || scope == XmlNamespaceScope.Local)
					{
						dictionary[localName] = value;
					}
				}
				while (this.MoveToNextNamespace((XPathNamespaceScope)scope));
				this.MoveToParent();
			}
			return dictionary;
		}

		/// <summary>
		///         Получает <see cref="T:System.Collections.IEqualityComparer" />, используемый для определения равенства объектов <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Collections.IEqualityComparer" />, используемый для определения равенства объектов <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </returns>
		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x00085D0B File Offset: 0x00083F0B
		public static IEqualityComparer NavigatorComparer
		{
			get
			{
				return XPathNavigator.comparer;
			}
		}

		/// <summary>
		///         При переопределении в производном классе создает новый <see cref="T:System.Xml.XPath.XPathNavigator" />, расположенный в том же узле, что и данный <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <returns>
		///         Новый <see cref="T:System.Xml.XPath.XPathNavigator" />, расположенный в том же узле, что и данный <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </returns>
		// Token: 0x06001619 RID: 5657
		public abstract XPathNavigator Clone();

		/// <summary>
		///         При переопределении в производном классе получает <see cref="T:System.Xml.XPath.XPathNodeType" /> текущего узла.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.XPath.XPathNodeType" />, представляющих текущий узел.
		///       </returns>
		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600161A RID: 5658
		public abstract XPathNodeType NodeType { get; }

		/// <summary>
		///         При переопределении в производном классе возвращает <see cref="P:System.Xml.XPath.XPathNavigator.Name" /> текущего узла без какого-либо префикса пространства имен.
		///       </summary>
		/// <returns>
		///         Строка <see cref="T:System.String" />, содержащая локальное имя текущего узла, или <see cref="F:System.String.Empty" />, если у текущего узла нет имени (например, у текстового узла или узла комментария).
		///       </returns>
		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600161B RID: 5659
		public abstract string LocalName { get; }

		/// <summary>
		///         Когда переопределено в производном классе, возвращает полное имя текущего узла.
		///       </summary>
		/// <returns>
		///         Строка <see cref="T:System.String" />, содержащая полное имя <see cref="P:System.Xml.XPath.XPathNavigator.Name" /> текущего узла, или <see cref="F:System.String.Empty" />, если у текущего узла нет имени (например, у текстового узла или узла комментария).
		///       </returns>
		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600161C RID: 5660
		public abstract string Name { get; }

		/// <summary>
		///         Когда переопределено в производном классе, возвращает URI пространства имен текущего узла.
		///       </summary>
		/// <returns>
		///         Строка <see cref="T:System.String" />, содержащая URI пространства имен текущего узла, или <see cref="F:System.String.Empty" />, если у текущего узла нет URI пространства имен.
		///       </returns>
		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600161D RID: 5661
		public abstract string NamespaceURI { get; }

		/// <summary>
		///         Когда переопределено в производном классе, возвращает префикс пространства имен, связанный с текущим узлом.
		///       </summary>
		/// <returns>
		///         Строка <see cref="T:System.String" />, содержащая префикс пространства имен, связанный с текущим узлом.
		///       </returns>
		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600161E RID: 5662
		public abstract string Prefix { get; }

		/// <summary>
		///         Когда переопределено в производном классе, возвращает базовый URI для текущего узла.
		///       </summary>
		/// <returns>
		///         Расположение, из которого был загружен узел, или <see cref="F:System.String.Empty" /> Если нет значения.
		///       </returns>
		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600161F RID: 5663
		public abstract string BaseURI { get; }

		/// <summary>
		///         Когда переопределено в производном классе, возвращает значение, указывающее, является ли текущий узел пустым элементом без тега конечного элемента.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если текущий узел является пустым элементом; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001620 RID: 5664
		public abstract bool IsEmptyElement { get; }

		/// <summary>
		///         Возвращает xml:lang область для текущего узла.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.String" /> содержащий значение xml:lang области, или <see cref="F:System.String.Empty" /> если текущий узел не имеет xml:lang область возвращаемое значение.
		///       </returns>
		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00085D14 File Offset: 0x00083F14
		public virtual string XmlLang
		{
			get
			{
				XPathNavigator xpathNavigator = this.Clone();
				while (!xpathNavigator.MoveToAttribute("lang", "http://www.w3.org/XML/1998/namespace"))
				{
					if (!xpathNavigator.MoveToParent())
					{
						return string.Empty;
					}
				}
				return xpathNavigator.Value;
			}
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Xml.XmlReader" />, содержащий текущий узел и его дочерние узлы.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlReader" />, содержащий текущий узел и его дочерние узлы.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не находится в узле элемента или в корневом узле.
		///           </exception>
		// Token: 0x06001622 RID: 5666 RVA: 0x00085D50 File Offset: 0x00083F50
		public virtual XmlReader ReadSubtree()
		{
			XPathNodeType nodeType = this.NodeType;
			if (nodeType > XPathNodeType.Element)
			{
				throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current position of the navigator."));
			}
			return this.CreateReader();
		}

		/// <summary>
		///         Выполняет потоковую передачу текущего узла и его дочерних узлов в указанный объект <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="writer">
		///           Объект <see cref="T:System.Xml.XmlWriter" />, в который выполняется потоковая передача.
		///         </param>
		// Token: 0x06001623 RID: 5667 RVA: 0x00085D7E File Offset: 0x00083F7E
		public virtual void WriteSubtree(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteNode(this, true);
		}

		/// <summary>
		///         Используемые <see cref="T:System.Xml.XPath.XPathNavigator" /> просмотра реализации, обеспечивающие «виртуальных» XML для хранилища, для обеспечения доступа к нижележащим объектам.
		///       </summary>
		/// <returns>
		///         Значение по умолчанию — <see langword="null" />.
		///       </returns>
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x0001DA42 File Offset: 0x0001BC42
		public virtual object UnderlyingObject
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		///         Возвращает значение, показывающее, имеются ли атрибуты у текущего узла.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> если текущий узел содержит атрибуты; возвращает <see langword="false" /> если текущий узел не имеет атрибутов или <see cref="T:System.Xml.XPath.XPathNavigator" /> находится не на узле элемента.
		///       </returns>
		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00085D96 File Offset: 0x00083F96
		public virtual bool HasAttributes
		{
			get
			{
				if (!this.MoveToFirstAttribute())
				{
					return false;
				}
				this.MoveToParent();
				return true;
			}
		}

		/// <summary>
		///         Возвращает значение атрибута с указанным локальным именем и универсальным кодом ресурса (URI) пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///           <paramref name="localName" /> учитывается регистр.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.String" /> содержащий значение указанного атрибута; <see cref="F:System.String.Empty" /> Если соответствующий атрибут не найден или <see cref="T:System.Xml.XPath.XPathNavigator" /> находится не на узле элемента.
		///       </returns>
		// Token: 0x06001626 RID: 5670 RVA: 0x00085DAA File Offset: 0x00083FAA
		public virtual string GetAttribute(string localName, string namespaceURI)
		{
			if (!this.MoveToAttribute(localName, namespaceURI))
			{
				return "";
			}
			string value = this.Value;
			this.MoveToParent();
			return value;
		}

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> к атрибуту с соответствующим локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           Пространство имен URI атрибута; <see langword="null" /> обозначает пустое пространство имен.
		///         </param>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к атрибуту; в противном случае — <see langword="false" />.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x06001627 RID: 5671 RVA: 0x00085DC9 File Offset: 0x00083FC9
		public virtual bool MoveToAttribute(string localName, string namespaceURI)
		{
			if (this.MoveToFirstAttribute())
			{
				while (!(localName == this.LocalName) || !(namespaceURI == this.NamespaceURI))
				{
					if (!this.MoveToNextAttribute())
					{
						this.MoveToParent();
						return false;
					}
				}
				return true;
			}
			return false;
		}

		/// <summary>
		///         При переопределении в производном классе перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> к первому атрибуту текущего узла.
		///       </summary>
		/// <returns>
		///         Возвращает значение <see langword="true" />, если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к первому атрибуту текущего узла; в противном случае возвращает значение <see langword="false" />.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x06001628 RID: 5672
		public abstract bool MoveToFirstAttribute();

		/// <summary>
		///         При переопределении в производном классе перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> в следующий атрибут.
		///       </summary>
		/// <returns>
		///         Возвращает значение <see langword="true" />, если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается в следующий атрибут, или значение <see langword="false" />, если атрибутов больше нет.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x06001629 RID: 5673
		public abstract bool MoveToNextAttribute();

		/// <summary>
		///         Возвращает значение узла пространства имен, соответствующее указанному локальному имени.
		///       </summary>
		/// <param name="name">
		///           Локальное имя узла пространства имен.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.String" /> содержащий значение узла пространства имен; <see cref="F:System.String.Empty" /> соответствующий узел пространства имен не найден или если <see cref="T:System.Xml.XPath.XPathNavigator" /> находится не на узле элемента.
		///       </returns>
		// Token: 0x0600162A RID: 5674 RVA: 0x00085E04 File Offset: 0x00084004
		public virtual string GetNamespace(string name)
		{
			if (this.MoveToNamespace(name))
			{
				string value = this.Value;
				this.MoveToParent();
				return value;
			}
			if (name == "xml")
			{
				return "http://www.w3.org/XML/1998/namespace";
			}
			if (name == "xmlns")
			{
				return "http://www.w3.org/2000/xmlns/";
			}
			return string.Empty;
		}

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> узел пространства имен с указанным префиксом пространства имен.
		///       </summary>
		/// <param name="name">
		///           Префикс пространства имен для узла пространства имен.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к указанному пространству имен; <see langword="false" /> соответствующий узел пространства имен не найден или если <see cref="T:System.Xml.XPath.XPathNavigator" /> находится не на узле элемента.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x0600162B RID: 5675 RVA: 0x00085E53 File Offset: 0x00084053
		public virtual bool MoveToNamespace(string name)
		{
			if (this.MoveToFirstNamespace(XPathNamespaceScope.All))
			{
				while (!(name == this.LocalName))
				{
					if (!this.MoveToNextNamespace(XPathNamespaceScope.All))
					{
						this.MoveToParent();
						return false;
					}
				}
				return true;
			}
			return false;
		}

		/// <summary>
		///         При переопределении в производном классе перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> к первому узлу пространства имен, который соответствует <see cref="T:System.Xml.XPath.XPathNamespaceScope" /> указанного.
		///       </summary>
		/// <param name="namespaceScope">
		///           <see cref="T:System.Xml.XPath.XPathNamespaceScope" /> Значение, описывающее область пространства имен.
		///         </param>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к первому узлу пространства имен; в противном случае — <see langword="false" />.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x0600162C RID: 5676
		public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

		/// <summary>
		///         При переопределении в производном классе перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> до следующего соответствия имен узла <see cref="T:System.Xml.XPath.XPathNamespaceScope" /> указанного.
		///       </summary>
		/// <param name="namespaceScope">
		///           <see cref="T:System.Xml.XPath.XPathNamespaceScope" /> Значение, описывающее область пространства имен.
		///         </param>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к следующему узлу пространства имен; в противном случае — <see langword="false" />.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x0600162D RID: 5677
		public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> к первому узлу пространства имен текущего узла.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к первому узлу пространства имен; в противном случае — <see langword="false" />.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x0600162E RID: 5678 RVA: 0x00085E7F File Offset: 0x0008407F
		public bool MoveToFirstNamespace()
		{
			return this.MoveToFirstNamespace(XPathNamespaceScope.All);
		}

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> следующий узел пространства имен.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к следующему узлу пространства имен; в противном случае — <see langword="false" />.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x0600162F RID: 5679 RVA: 0x00085E88 File Offset: 0x00084088
		public bool MoveToNextNamespace()
		{
			return this.MoveToNextNamespace(XPathNamespaceScope.All);
		}

		/// <summary>
		///         При переопределении в производном классе перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> к следующему сестринскому узлу текущего узла.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к следующему сестринскому узлу; в противном случае — значение <see langword="false" />, если больше нет сестринских узлов, или если <see cref="T:System.Xml.XPath.XPathNavigator" /> в данный момент находится в узле атрибута.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x06001630 RID: 5680
		public abstract bool MoveToNext();

		/// <summary>
		///         При переопределении в производном классе перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> предыдущий узел того же уровня текущего узла.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к предыдущему узлу; в противном случае, <see langword="false" /> Если нет предыдущего узла того же уровня или <see cref="T:System.Xml.XPath.XPathNavigator" /> расположено на узле атрибута.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x06001631 RID: 5681
		public abstract bool MoveToPrevious();

		/// <summary>
		///         Перемещает объект <see cref="T:System.Xml.XPath.XPathNavigator" /> в первый узел одного уровня с текущим узлом.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к первому узлу текущего узла; <see langword="false" /> при наличии не первый элемент того же уровня или если <see cref="T:System.Xml.XPath.XPathNavigator" /> расположено на узле атрибута.
		///          Если <see cref="T:System.Xml.XPath.XPathNavigator" /> уже находится на первый элемент <see cref="T:System.Xml.XPath.XPathNavigator" /> вернет <see langword="true" /> и его положение не изменяется.
		///
		///         Если <see cref="M:System.Xml.XPath.XPathNavigator.MoveToFirst" /> возвращает <see langword="false" /> из-за не первый элемент того же уровня или если <see cref="T:System.Xml.XPath.XPathNavigator" /> в настоящее время находится на атрибуте, положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x06001632 RID: 5682 RVA: 0x00085E94 File Offset: 0x00084094
		public virtual bool MoveToFirst()
		{
			XPathNodeType nodeType = this.NodeType;
			return nodeType - XPathNodeType.Attribute > 1 && this.MoveToParent() && this.MoveToFirstChild();
		}

		/// <summary>
		///         При переопределении в производном классе перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> первый дочерний узел текущего узла.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается первый дочерний узел текущего узла; в противном случае — <see langword="false" />.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x06001633 RID: 5683
		public abstract bool MoveToFirstChild();

		/// <summary>
		///         При переопределении в производном классе перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> в родительский узел текущего узла.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается в родительский узел текущего узла; в противном случае — <see langword="false" />.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x06001634 RID: 5684
		public abstract bool MoveToParent();

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> на корневой узел, к которому принадлежит текущий узел.
		///       </summary>
		// Token: 0x06001635 RID: 5685 RVA: 0x00085EC0 File Offset: 0x000840C0
		public virtual void MoveToRoot()
		{
			while (this.MoveToParent())
			{
			}
		}

		/// <summary>
		///         При переопределении в производном классе перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> в той же позиции, что и заданный <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <param name="other">
		///           <see cref="T:System.Xml.XPath.XPathNavigator" /> Размещается на узле, который требуется переместить.
		///         </param>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к той же позиции, что и заданный <see cref="T:System.Xml.XPath.XPathNavigator" />; в противном случае — <see langword="false" />.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x06001636 RID: 5686
		public abstract bool MoveTo(XPathNavigator other);

		/// <summary>
		///         При переопределении в производном классе перемещает к узлу, имеющему атрибут типа ID значение которого соответствует указанному <see cref="T:System.String" />.
		///       </summary>
		/// <param name="id">
		///           Объект <see cref="T:System.String" /> представляет ID значение узла, на который требуется переместить.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешного перемещения, в противном случае — <see langword="false" />.
		///          Если <see langword="false" />, позиция навигатора не изменяется.
		///       </returns>
		// Token: 0x06001637 RID: 5687
		public abstract bool MoveToId(string id);

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> к дочернему узлу с заданным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя дочернего узла, к которому следует перейти.
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен дочернего узла, к которому следует перейти.
		///         </param>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к дочернему узлу; в противном случае — <see langword="false" />.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x06001638 RID: 5688 RVA: 0x00085ECC File Offset: 0x000840CC
		public virtual bool MoveToChild(string localName, string namespaceURI)
		{
			if (this.MoveToFirstChild())
			{
				while (this.NodeType != XPathNodeType.Element || !(localName == this.LocalName) || !(namespaceURI == this.NamespaceURI))
				{
					if (!this.MoveToNext())
					{
						this.MoveToParent();
						return false;
					}
				}
				return true;
			}
			return false;
		}

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> дочерний узел <see cref="T:System.Xml.XPath.XPathNodeType" /> указанного.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Xml.XPath.XPathNodeType" /> Для перемещения дочернего узла.
		///         </param>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к дочернему узлу; в противном случае — <see langword="false" />.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x06001639 RID: 5689 RVA: 0x00085F18 File Offset: 0x00084118
		public virtual bool MoveToChild(XPathNodeType type)
		{
			if (this.MoveToFirstChild())
			{
				int contentKindMask = XPathNavigator.GetContentKindMask(type);
				while ((1 << (int)this.NodeType & contentKindMask) == 0)
				{
					if (!this.MoveToNext())
					{
						this.MoveToParent();
						return false;
					}
				}
				return true;
			}
			return false;
		}

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> к элементу с указанным локальным именем и URI пространства имен в порядке документов.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если объект <see cref="T:System.Xml.XPath.XPathNavigator" /> был перемещен успешно; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x0600163A RID: 5690 RVA: 0x00085F55 File Offset: 0x00084155
		public virtual bool MoveToFollowing(string localName, string namespaceURI)
		{
			return this.MoveToFollowing(localName, namespaceURI, null);
		}

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> к элементу с указанным локальным именем и URI пространства имен до достижения заданной границы в порядке документов.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <param name="end">
		///           Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, размещенный на границе элемента, которая не пересекается текущим <see cref="T:System.Xml.XPath.XPathNavigator" /> при поиске следующего элемента.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если объект <see cref="T:System.Xml.XPath.XPathNavigator" /> был перемещен успешно; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x0600163B RID: 5691 RVA: 0x00085F60 File Offset: 0x00084160
		public virtual bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end)
		{
			XPathNavigator other = this.Clone();
			XPathNodeType nodeType;
			if (end != null)
			{
				nodeType = end.NodeType;
				if (nodeType - XPathNodeType.Attribute <= 1)
				{
					end = end.Clone();
					end.MoveToNonDescendant();
				}
			}
			nodeType = this.NodeType;
			if (nodeType - XPathNodeType.Attribute <= 1 && !this.MoveToParent())
			{
				return false;
			}
			for (;;)
			{
				if (!this.MoveToFirstChild())
				{
					while (!this.MoveToNext())
					{
						if (!this.MoveToParent())
						{
							goto Block_6;
						}
					}
				}
				if (end != null && this.IsSamePosition(end))
				{
					goto Block_8;
				}
				if (this.NodeType == XPathNodeType.Element && !(localName != this.LocalName) && !(namespaceURI != this.NamespaceURI))
				{
					return true;
				}
			}
			Block_6:
			this.MoveTo(other);
			return false;
			Block_8:
			this.MoveTo(other);
			return false;
		}

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> к следующему элементу типа <see cref="T:System.Xml.XPath.XPathNodeType" />, указанному в порядке документов.
		///       </summary>
		/// <param name="type">
		///           Тип <see cref="T:System.Xml.XPath.XPathNodeType" /> элемента.
		///            Тип <see cref="T:System.Xml.XPath.XPathNodeType" /> не может быть <see cref="F:System.Xml.XPath.XPathNodeType.Attribute" /> или <see cref="F:System.Xml.XPath.XPathNodeType.Namespace" />.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если объект <see cref="T:System.Xml.XPath.XPathNavigator" /> был перемещен успешно; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x0600163C RID: 5692 RVA: 0x00086008 File Offset: 0x00084208
		public virtual bool MoveToFollowing(XPathNodeType type)
		{
			return this.MoveToFollowing(type, null);
		}

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> к следующему элементу указанного типа <see cref="T:System.Xml.XPath.XPathNodeType" /> до указанной границы в порядке документов.
		///       </summary>
		/// <param name="type">
		///           Тип <see cref="T:System.Xml.XPath.XPathNodeType" /> элемента.
		///            Тип <see cref="T:System.Xml.XPath.XPathNodeType" /> не может быть <see cref="F:System.Xml.XPath.XPathNodeType.Attribute" /> или <see cref="F:System.Xml.XPath.XPathNodeType.Namespace" />.
		///         </param>
		/// <param name="end">
		///           Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, размещенный на границе элемента, которая не пересекается текущим <see cref="T:System.Xml.XPath.XPathNavigator" /> при поиске следующего элемента.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если объект <see cref="T:System.Xml.XPath.XPathNavigator" /> был перемещен успешно; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x0600163D RID: 5693 RVA: 0x00086014 File Offset: 0x00084214
		public virtual bool MoveToFollowing(XPathNodeType type, XPathNavigator end)
		{
			XPathNavigator other = this.Clone();
			int contentKindMask = XPathNavigator.GetContentKindMask(type);
			XPathNodeType nodeType;
			if (end != null)
			{
				nodeType = end.NodeType;
				if (nodeType - XPathNodeType.Attribute <= 1)
				{
					end = end.Clone();
					end.MoveToNonDescendant();
				}
			}
			nodeType = this.NodeType;
			if (nodeType - XPathNodeType.Attribute <= 1 && !this.MoveToParent())
			{
				return false;
			}
			for (;;)
			{
				if (!this.MoveToFirstChild())
				{
					while (!this.MoveToNext())
					{
						if (!this.MoveToParent())
						{
							goto Block_6;
						}
					}
				}
				if (end != null && this.IsSamePosition(end))
				{
					goto Block_8;
				}
				if ((1 << (int)this.NodeType & contentKindMask) != 0)
				{
					return true;
				}
			}
			Block_6:
			this.MoveTo(other);
			return false;
			Block_8:
			this.MoveTo(other);
			return false;
		}

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> следующий узел одного уровня с заданным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя следующего узла того же уровня, к которому следует перейти.
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен следующего узла того же уровня, к которому следует перейти.
		///         </param>
		/// <returns>
		///         Возвращает <see langword="true" /> Если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к следующему узлу того же уровня; <see langword="false" /> если нет дополнительных элементов того же уровня или если <see cref="T:System.Xml.XPath.XPathNavigator" /> расположено на узле атрибута.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x0600163E RID: 5694 RVA: 0x000860B0 File Offset: 0x000842B0
		public virtual bool MoveToNext(string localName, string namespaceURI)
		{
			XPathNavigator other = this.Clone();
			while (this.MoveToNext())
			{
				if (this.NodeType == XPathNodeType.Element && localName == this.LocalName && namespaceURI == this.NamespaceURI)
				{
					return true;
				}
			}
			this.MoveTo(other);
			return false;
		}

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XPath.XPathNavigator" /> на следующий узел того же уровня текущего узла, соответствующий <see cref="T:System.Xml.XPath.XPathNodeType" /> указанного.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Xml.XPath.XPathNodeType" /> Узла того же уровня для перемещения.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если <see cref="T:System.Xml.XPath.XPathNavigator" /> успешно перемещается к следующему сестринскому узлу; в противном случае — значение <see langword="false" />, если больше нет сестринских узлов, или если <see cref="T:System.Xml.XPath.XPathNavigator" /> в данный момент находится в узле атрибута.
		///          Если возвращается значение <see langword="false" />, то положение <see cref="T:System.Xml.XPath.XPathNavigator" /> остается неизменным.
		///       </returns>
		// Token: 0x0600163F RID: 5695 RVA: 0x00086100 File Offset: 0x00084300
		public virtual bool MoveToNext(XPathNodeType type)
		{
			XPathNavigator other = this.Clone();
			int contentKindMask = XPathNavigator.GetContentKindMask(type);
			while (this.MoveToNext())
			{
				if ((1 << (int)this.NodeType & contentKindMask) != 0)
				{
					return true;
				}
			}
			this.MoveTo(other);
			return false;
		}

		/// <summary>
		///         Возвращает значение, указывающее, имеются ли у текущего узла какие-либо дочерние узлы.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если текущий узел имеет дочерние узлы; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x0008613F File Offset: 0x0008433F
		public virtual bool HasChildren
		{
			get
			{
				if (this.MoveToFirstChild())
				{
					this.MoveToParent();
					return true;
				}
				return false;
			}
		}

		/// <summary>
		///         При переопределении в производном классе определяет, является ли текущий <see cref="T:System.Xml.XPath.XPathNavigator" /> находится в той же позиции, что и заданный <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <param name="other">
		///           <see cref="T:System.Xml.XPath.XPathNavigator" /> Для сравнения с <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если два <see cref="T:System.Xml.XPath.XPathNavigator" /> объекты имеют ту же позицию; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001641 RID: 5697
		public abstract bool IsSamePosition(XPathNavigator other);

		/// <summary>
		///         Определяет, является ли указанный <see cref="T:System.Xml.XPath.XPathNavigator" /> является потомком текущего <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <param name="nav">
		///           <see cref="T:System.Xml.XPath.XPathNavigator" /> Для сравнения с <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если указанный <see cref="T:System.Xml.XPath.XPathNavigator" /> является потомком текущего <see cref="T:System.Xml.XPath.XPathNavigator" />; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001642 RID: 5698 RVA: 0x00086153 File Offset: 0x00084353
		public virtual bool IsDescendant(XPathNavigator nav)
		{
			if (nav != null)
			{
				nav = nav.Clone();
				while (nav.MoveToParent())
				{
					if (nav.IsSamePosition(this))
					{
						return true;
					}
				}
			}
			return false;
		}

		/// <summary>
		///         Сравнивает положение текущего <see cref="T:System.Xml.XPath.XPathNavigator" /> с позицией <see cref="T:System.Xml.XPath.XPathNavigator" /> указанного.
		///       </summary>
		/// <param name="nav">
		///           <see cref="T:System.Xml.XPath.XPathNavigator" /> Для сравнения.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNodeOrder" /> Значение, представляющее сравнительное положение двух <see cref="T:System.Xml.XPath.XPathNavigator" /> объектов.
		///       </returns>
		// Token: 0x06001643 RID: 5699 RVA: 0x00086178 File Offset: 0x00084378
		public virtual XmlNodeOrder ComparePosition(XPathNavigator nav)
		{
			if (nav == null)
			{
				return XmlNodeOrder.Unknown;
			}
			if (this.IsSamePosition(nav))
			{
				return XmlNodeOrder.Same;
			}
			XPathNavigator xpathNavigator = this.Clone();
			XPathNavigator xpathNavigator2 = nav.Clone();
			int i = XPathNavigator.GetDepth(xpathNavigator.Clone());
			int j = XPathNavigator.GetDepth(xpathNavigator2.Clone());
			if (i > j)
			{
				while (i > j)
				{
					xpathNavigator.MoveToParent();
					i--;
				}
				if (xpathNavigator.IsSamePosition(xpathNavigator2))
				{
					return XmlNodeOrder.After;
				}
			}
			if (j > i)
			{
				while (j > i)
				{
					xpathNavigator2.MoveToParent();
					j--;
				}
				if (xpathNavigator.IsSamePosition(xpathNavigator2))
				{
					return XmlNodeOrder.Before;
				}
			}
			XPathNavigator xpathNavigator3 = xpathNavigator.Clone();
			XPathNavigator xpathNavigator4 = xpathNavigator2.Clone();
			while (xpathNavigator3.MoveToParent() && xpathNavigator4.MoveToParent())
			{
				if (xpathNavigator3.IsSamePosition(xpathNavigator4))
				{
					xpathNavigator.GetType().ToString() != "Microsoft.VisualStudio.Modeling.StoreNavigator";
					return this.CompareSiblings(xpathNavigator, xpathNavigator2);
				}
				xpathNavigator.MoveToParent();
				xpathNavigator2.MoveToParent();
			}
			return XmlNodeOrder.Unknown;
		}

		/// <summary>
		///         Возвращает сведения схемы, которые были назначены текущему узлу в результате проверки схемы.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> Объект, содержащий сведения о схеме для текущего узла.
		///       </returns>
		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x0001E525 File Offset: 0x0001C725
		public virtual IXmlSchemaInfo SchemaInfo
		{
			get
			{
				return this as IXmlSchemaInfo;
			}
		}

		/// <summary>
		///         Проверяет, что XML-данные в <see cref="T:System.Xml.XPath.XPathNavigator" /> предоставленных схеме языка XSD определения схемы XML.
		///       </summary>
		/// <param name="schemas">
		///           <see cref="T:System.Xml.Schema.XmlSchemaSet" /> Содержащей схемы, используемые для проверки XML-данных, содержащихся в <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///         </param>
		/// <param name="validationEventHandler">
		///           <see cref="T:System.Xml.Schema.ValidationEventHandler" /> Получающий сведения об ошибках и предупреждений проверки схемы.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если нет ошибок проверки схемы; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">
		///             Ошибка проверки схемы, а не <see cref="T:System.Xml.Schema.ValidationEventHandler" /> был указан для обработки ошибок проверки.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XPath.XPathNavigator" /> Расположено на узле, не является элемент, атрибут или корневой узел или не сведения о типе для выполнения проверки.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <see cref="M:System.Xml.XPath.XPathNavigator.CheckValidity(System.Xml.Schema.XmlSchemaSet,System.Xml.Schema.ValidationEventHandler)" /> Метод был вызван с <see cref="T:System.Xml.Schema.XmlSchemaSet" /> параметра при <see cref="T:System.Xml.XPath.XPathNavigator" /> не был расположен в корневом узле XML-данных.
		///           </exception>
		// Token: 0x06001645 RID: 5701 RVA: 0x00086258 File Offset: 0x00084458
		public virtual bool CheckValidity(XmlSchemaSet schemas, ValidationEventHandler validationEventHandler)
		{
			XmlSchemaType xmlSchemaType = null;
			XmlSchemaElement xmlSchemaElement = null;
			XmlSchemaAttribute xmlSchemaAttribute = null;
			switch (this.NodeType)
			{
			case XPathNodeType.Root:
				if (schemas == null)
				{
					throw new InvalidOperationException(Res.GetString("An XmlSchemaSet must be provided to validate the document."));
				}
				xmlSchemaType = null;
				break;
			case XPathNodeType.Element:
			{
				if (schemas == null)
				{
					throw new InvalidOperationException(Res.GetString("An XmlSchemaSet must be provided to validate the document."));
				}
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					xmlSchemaType = schemaInfo.SchemaType;
					xmlSchemaElement = schemaInfo.SchemaElement;
				}
				if (xmlSchemaType == null && xmlSchemaElement == null)
				{
					throw new InvalidOperationException(Res.GetString("Element should have prior schema information to call this method.", null));
				}
				break;
			}
			case XPathNodeType.Attribute:
			{
				if (schemas == null)
				{
					throw new InvalidOperationException(Res.GetString("An XmlSchemaSet must be provided to validate the document."));
				}
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					xmlSchemaType = schemaInfo.SchemaType;
					xmlSchemaAttribute = schemaInfo.SchemaAttribute;
				}
				if (xmlSchemaType == null && xmlSchemaAttribute == null)
				{
					throw new InvalidOperationException(Res.GetString("Element should have prior schema information to call this method.", null));
				}
				break;
			}
			default:
				throw new InvalidOperationException(Res.GetString("Validate and CheckValidity are only allowed on Root or Element nodes.", null));
			}
			XmlReader xmlReader = this.CreateReader();
			XPathNavigator.CheckValidityHelper checkValidityHelper = new XPathNavigator.CheckValidityHelper(validationEventHandler, xmlReader as XPathNavigatorReader);
			validationEventHandler = new ValidationEventHandler(checkValidityHelper.ValidationCallback);
			XmlReader validatingReader = this.GetValidatingReader(xmlReader, schemas, validationEventHandler, xmlSchemaType, xmlSchemaElement, xmlSchemaAttribute);
			while (validatingReader.Read())
			{
			}
			return checkValidityHelper.IsValid;
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00086380 File Offset: 0x00084580
		private XmlReader GetValidatingReader(XmlReader reader, XmlSchemaSet schemas, ValidationEventHandler validationEvent, XmlSchemaType schemaType, XmlSchemaElement schemaElement, XmlSchemaAttribute schemaAttribute)
		{
			if (schemaAttribute != null)
			{
				return schemaAttribute.Validate(reader, null, schemas, validationEvent);
			}
			if (schemaElement != null)
			{
				return schemaElement.Validate(reader, null, schemas, validationEvent);
			}
			if (schemaType != null)
			{
				return schemaType.Validate(reader, null, schemas, validationEvent);
			}
			XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
			xmlReaderSettings.ConformanceLevel = ConformanceLevel.Auto;
			xmlReaderSettings.ValidationType = ValidationType.Schema;
			xmlReaderSettings.Schemas = schemas;
			xmlReaderSettings.ValidationEventHandler += validationEvent;
			return XmlReader.Create(reader, xmlReaderSettings);
		}

		/// <summary>
		///         Компилирует строку, представляющую выражение XPath и возвращает <see cref="T:System.Xml.XPath.XPathExpression" /> объекта.
		///       </summary>
		/// <param name="xpath">
		///           Строчное представление выражения XPath.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XPath.XPathExpression" /> Объект, представляющий выражение XPath.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="xpath" /> Параметр содержит недопустимое выражение XPath.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимое выражение XPath.
		///           </exception>
		// Token: 0x06001647 RID: 5703 RVA: 0x000863E6 File Offset: 0x000845E6
		public virtual XPathExpression Compile(string xpath)
		{
			return XPathExpression.Compile(xpath);
		}

		/// <summary>
		///         Выбирает один узел в <see cref="T:System.Xml.XPath.XPathNavigator" />, используя указанный запрос XPath.
		///       </summary>
		/// <param name="xpath">
		///           Строка <see cref="T:System.String" />, представляющая выражение XPath.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, содержащий первый узел, соответствующий указанному запросу XPath, или значение <see langword="null" />, если результаты запроса отсутствуют.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Произошла ошибка в запросе XPath, или тип возвращаемого значения выражения XPath не является узлом.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимый запрос XPath.
		///           </exception>
		// Token: 0x06001648 RID: 5704 RVA: 0x000863EE File Offset: 0x000845EE
		public virtual XPathNavigator SelectSingleNode(string xpath)
		{
			return this.SelectSingleNode(XPathExpression.Compile(xpath));
		}

		/// <summary>
		///         Выбирает один узел в объекте <see cref="T:System.Xml.XPath.XPathNavigator" />, используя указанный запрос XPath совместно с указанным объектом <see cref="T:System.Xml.IXmlNamespaceResolver" /> для разрешения префиксов пространства имен.
		///       </summary>
		/// <param name="xpath">
		///           Строка <see cref="T:System.String" />, представляющая выражение XPath.
		///         </param>
		/// <param name="resolver">
		///           Объект <see cref="T:System.Xml.IXmlNamespaceResolver" />, используемый для разрешения префиксов пространства имен в запросе XPath.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, содержащий первый узел, соответствующий указанному запросу XPath, или значение <see langword="null" />, если результаты запроса отсутствуют.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Произошла ошибка в запросе XPath, или тип возвращаемого значения выражения XPath не является узлом.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимый запрос XPath.
		///           </exception>
		// Token: 0x06001649 RID: 5705 RVA: 0x000863FC File Offset: 0x000845FC
		public virtual XPathNavigator SelectSingleNode(string xpath, IXmlNamespaceResolver resolver)
		{
			return this.SelectSingleNode(XPathExpression.Compile(xpath, resolver));
		}

		/// <summary>
		///         Выбирает один узел в <see cref="T:System.Xml.XPath.XPathNavigator" />, используя указанный объект <see cref="T:System.Xml.XPath.XPathExpression" />.
		///       </summary>
		/// <param name="expression">
		///           Объект <see cref="T:System.Xml.XPath.XPathExpression" />, содержащий скомпилированный запрос XPath.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, содержащий первый узел, соответствующий указанному запросу XPath, или значение <see langword="null" />, если результаты запроса отсутствуют.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Произошла ошибка в запросе XPath, или тип возвращаемого значения выражения XPath не является узлом.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимый запрос XPath.
		///           </exception>
		// Token: 0x0600164A RID: 5706 RVA: 0x0008640C File Offset: 0x0008460C
		public virtual XPathNavigator SelectSingleNode(XPathExpression expression)
		{
			XPathNodeIterator xpathNodeIterator = this.Select(expression);
			if (xpathNodeIterator.MoveNext())
			{
				return xpathNodeIterator.Current;
			}
			return null;
		}

		/// <summary>
		///         Выбирает набор узлов с помощью заданного выражения XPath.
		///       </summary>
		/// <param name="xpath">
		///           Строка <see cref="T:System.String" />, представляющая выражение XPath.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNodeIterator" />, указывающий на выбранный набор узлов.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Выражение XPath содержит ошибку, или его возвращаемый тип не является набором узлов.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимое выражение XPath.
		///           </exception>
		// Token: 0x0600164B RID: 5707 RVA: 0x00086431 File Offset: 0x00084631
		public virtual XPathNodeIterator Select(string xpath)
		{
			return this.Select(XPathExpression.Compile(xpath));
		}

		/// <summary>
		///         Выбирает набор узлов, используя указанное выражение XPath совместно с объектом <see cref="T:System.Xml.IXmlNamespaceResolver" /> для разрешения префиксов пространств имен.
		///       </summary>
		/// <param name="xpath">
		///           Строка <see cref="T:System.String" />, представляющая выражение XPath.
		///         </param>
		/// <param name="resolver">
		///           Объект <see cref="T:System.Xml.IXmlNamespaceResolver" />, используемый для разрешения префиксов пространств имен.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNodeIterator" />, указывающий на набор выбранных узлов.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Выражение XPath содержит ошибку, или его возвращаемый тип не является набором узлов.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимое выражение XPath.
		///           </exception>
		// Token: 0x0600164C RID: 5708 RVA: 0x0008643F File Offset: 0x0008463F
		public virtual XPathNodeIterator Select(string xpath, IXmlNamespaceResolver resolver)
		{
			return this.Select(XPathExpression.Compile(xpath, resolver));
		}

		/// <summary>
		///         Выбирает набор узлов с помощью заданного выражения <see cref="T:System.Xml.XPath.XPathExpression" />.
		///       </summary>
		/// <param name="expr">
		///           Объект <see cref="T:System.Xml.XPath.XPathExpression" />, содержащий скомпилированный запрос XPath.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNodeIterator" />, указывающий на выбранный набор узлов.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Выражение XPath содержит ошибку, или его возвращаемый тип не является набором узлов.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимое выражение XPath.
		///           </exception>
		// Token: 0x0600164D RID: 5709 RVA: 0x0008644E File Offset: 0x0008464E
		public virtual XPathNodeIterator Select(XPathExpression expr)
		{
			XPathNodeIterator xpathNodeIterator = this.Evaluate(expr) as XPathNodeIterator;
			if (xpathNodeIterator == null)
			{
				throw XPathException.Create("Expression must evaluate to a node-set.");
			}
			return xpathNodeIterator;
		}

		/// <summary>
		///         Вычисляет заданное выражение XPath и возвращает типизированный результат.
		///       </summary>
		/// <param name="xpath">
		///           Строка, представляющая выражение XPath, которое следует вычислить.
		///         </param>
		/// <returns>
		///         Результат выражения (логическое значение, число, строка или набор узлов).
		///          Он сопоставляется с объектом <see cref="T:System.Boolean" />, <see cref="T:System.Double" />, <see cref="T:System.String" /> или <see cref="T:System.Xml.XPath.XPathNodeIterator" /> соответственно.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Возвращаемый тип выражения XPath — набор узлов.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимое выражение XPath.
		///           </exception>
		// Token: 0x0600164E RID: 5710 RVA: 0x0008646A File Offset: 0x0008466A
		public virtual object Evaluate(string xpath)
		{
			return this.Evaluate(XPathExpression.Compile(xpath), null);
		}

		/// <summary>
		///         Вычисляет значение заданного выражения XPath и возвращает типизированный результат с помощью указанного объекта <see cref="T:System.Xml.IXmlNamespaceResolver" />, который разрешает префиксы пространства имен в выражении XPath.
		///       </summary>
		/// <param name="xpath">
		///           Строка, представляющая выражение XPath, которое следует вычислить.
		///         </param>
		/// <param name="resolver">
		///           Объект <see cref="T:System.Xml.IXmlNamespaceResolver" />, используемый для разрешения префиксов пространства имен в выражении XPath.
		///         </param>
		/// <returns>
		///         Результат выражения (логическое значение, число, строка или набор узлов).
		///          Он сопоставляется с объектом <see cref="T:System.Boolean" />, <see cref="T:System.Double" />, <see cref="T:System.String" /> или <see cref="T:System.Xml.XPath.XPathNodeIterator" /> соответственно.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Возвращаемый тип выражения XPath — набор узлов.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимое выражение XPath.
		///           </exception>
		// Token: 0x0600164F RID: 5711 RVA: 0x00086479 File Offset: 0x00084679
		public virtual object Evaluate(string xpath, IXmlNamespaceResolver resolver)
		{
			return this.Evaluate(XPathExpression.Compile(xpath, resolver));
		}

		/// <summary>
		///         Вычисляет <see cref="T:System.Xml.XPath.XPathExpression" /> и возвращает типизированный результат.
		///       </summary>
		/// <param name="expr">
		///           <see cref="T:System.Xml.XPath.XPathExpression" />, которое можно вычислить.
		///         </param>
		/// <returns>
		///         Результат выражения (логическое значение, число, строка или набор узлов).
		///          Он сопоставляется с объектом <see cref="T:System.Boolean" />, <see cref="T:System.Double" />, <see cref="T:System.String" /> или <see cref="T:System.Xml.XPath.XPathNodeIterator" /> соответственно.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Возвращаемый тип выражения XPath — набор узлов.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимое выражение XPath.
		///           </exception>
		// Token: 0x06001650 RID: 5712 RVA: 0x00086488 File Offset: 0x00084688
		public virtual object Evaluate(XPathExpression expr)
		{
			return this.Evaluate(expr, null);
		}

		/// <summary>
		///         Использует предоставленный контекст для вычисления <see cref="T:System.Xml.XPath.XPathExpression" /> и возвращает типизированный результат.
		///       </summary>
		/// <param name="expr">
		///           Выражение <see cref="T:System.Xml.XPath.XPathExpression" />, которое можно вычислить.
		///         </param>
		/// <param name="context">
		///           Объект <see cref="T:System.Xml.XPath.XPathNodeIterator" />, указывающий на выбранный узел, в котором должно выполняться вычисление.
		///         </param>
		/// <returns>
		///         Результат выражения (логическое значение, число, строка или набор узлов).
		///          Он сопоставляется с объектом <see cref="T:System.Boolean" />, <see cref="T:System.Double" />, <see cref="T:System.String" /> или <see cref="T:System.Xml.XPath.XPathNodeIterator" /> соответственно.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Возвращаемый тип выражения XPath — набор узлов.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимое выражение XPath.
		///           </exception>
		// Token: 0x06001651 RID: 5713 RVA: 0x00086494 File Offset: 0x00084694
		public virtual object Evaluate(XPathExpression expr, XPathNodeIterator context)
		{
			CompiledXpathExpr compiledXpathExpr = expr as CompiledXpathExpr;
			if (compiledXpathExpr == null)
			{
				throw XPathException.Create("This is an invalid object. Only objects returned from Compile() can be passed as input.");
			}
			Query query = Query.Clone(compiledXpathExpr.QueryTree);
			query.Reset();
			if (context == null)
			{
				context = new XPathSingletonIterator(this.Clone(), true);
			}
			object obj = query.Evaluate(context);
			if (obj is XPathNodeIterator)
			{
				return new XPathSelectionIterator(context.Current, query);
			}
			return obj;
		}

		/// <summary>
		///         Определяет, соответствует ли текущий узел указанному выражению <see cref="T:System.Xml.XPath.XPathExpression" />.
		///       </summary>
		/// <param name="expr">
		///           Объект <see cref="T:System.Xml.XPath.XPathExpression" />, содержащий скомпилированное выражение XPath.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если текущий узел соответствует <see cref="T:System.Xml.XPath.XPathExpression" />; в противном случае — значение <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Не удается вычислить выражение XPath.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимое выражение XPath.
		///           </exception>
		// Token: 0x06001652 RID: 5714 RVA: 0x000864F8 File Offset: 0x000846F8
		public virtual bool Matches(XPathExpression expr)
		{
			CompiledXpathExpr compiledXpathExpr = expr as CompiledXpathExpr;
			if (compiledXpathExpr == null)
			{
				throw XPathException.Create("This is an invalid object. Only objects returned from Compile() can be passed as input.");
			}
			Query query = Query.Clone(compiledXpathExpr.QueryTree);
			bool result;
			try
			{
				result = (query.MatchNode(this) != null);
			}
			catch (XPathException)
			{
				throw XPathException.Create("'{0}' is an invalid XSLT pattern.", compiledXpathExpr.Expression);
			}
			return result;
		}

		/// <summary>
		///         Определяет, соответствует ли текущий узел указанному выражению XPath.
		///       </summary>
		/// <param name="xpath">
		///           Выражение XPath.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если текущий узел соответствует указанному выражению XPath; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Не удается вычислить выражение XPath.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимое выражение XPath.
		///           </exception>
		// Token: 0x06001653 RID: 5715 RVA: 0x00086558 File Offset: 0x00084758
		public virtual bool Matches(string xpath)
		{
			return this.Matches(XPathNavigator.CompileMatchPattern(xpath));
		}

		/// <summary>
		///         Выбирает все дочерние узлы текущего узла с совпадающим <see cref="T:System.Xml.XPath.XPathNodeType" />.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Xml.XPath.XPathNodeType" /> Дочерних узлов.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNodeIterator" />, содержащий выбранные узлы.
		///       </returns>
		// Token: 0x06001654 RID: 5716 RVA: 0x00086566 File Offset: 0x00084766
		public virtual XPathNodeIterator SelectChildren(XPathNodeType type)
		{
			return new XPathChildIterator(this.Clone(), type);
		}

		/// <summary>
		///         Выбирает все дочерние узлы текущего узла с заданным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="name">
		///           Локальное имя дочерних узлов.
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен дочерних узлов.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNodeIterator" />, содержащий выбранные узлы.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <see langword="null" /> не может передаваться в качестве параметра.
		///           </exception>
		// Token: 0x06001655 RID: 5717 RVA: 0x00086574 File Offset: 0x00084774
		public virtual XPathNodeIterator SelectChildren(string name, string namespaceURI)
		{
			return new XPathChildIterator(this.Clone(), name, namespaceURI);
		}

		/// <summary>
		///         Выбирает все узлы-предки текущего узла с соответствующим <see cref="T:System.Xml.XPath.XPathNodeType" />.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Xml.XPath.XPathNodeType" /> Узлов-предков.
		///         </param>
		/// <param name="matchSelf">
		///           Значение <see langword="true" /> для включения узла контекста в выбираемые узлы; в противном случае значение <see langword="false" />.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNodeIterator" />, содержащий выбранные узлы.
		///          Возвращаемые узлы располагаются в порядке, обратном их следованию в документе.
		///       </returns>
		// Token: 0x06001656 RID: 5718 RVA: 0x00086583 File Offset: 0x00084783
		public virtual XPathNodeIterator SelectAncestors(XPathNodeType type, bool matchSelf)
		{
			return new XPathAncestorIterator(this.Clone(), type, matchSelf);
		}

		/// <summary>
		///         Выбирает все узлы-предки текущего узла с заданным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="name">
		///           Локальное имя узлов-предков.
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен узлов-предков.
		///         </param>
		/// <param name="matchSelf">
		///           Значение <see langword="true" /> для включения узла контекста в выбираемые узлы; в противном случае значение <see langword="false" />.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNodeIterator" />, содержащий выбранные узлы.
		///          Возвращаемые узлы располагаются в порядке, обратном их следованию в документе.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <see langword="null" /> не может передаваться в качестве параметра.
		///           </exception>
		// Token: 0x06001657 RID: 5719 RVA: 0x00086592 File Offset: 0x00084792
		public virtual XPathNodeIterator SelectAncestors(string name, string namespaceURI, bool matchSelf)
		{
			return new XPathAncestorIterator(this.Clone(), name, namespaceURI, matchSelf);
		}

		/// <summary>
		///         Выбирает все узлы-потомки текущего узла с соответствующим <see cref="T:System.Xml.XPath.XPathNodeType" />.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Xml.XPath.XPathNodeType" /> Узлов-потомков.
		///         </param>
		/// <param name="matchSelf">
		///           <see langword="true" /> Чтобы включить контекстный узел в выделение; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNodeIterator" />, содержащий выбранные узлы.
		///       </returns>
		// Token: 0x06001658 RID: 5720 RVA: 0x000865A2 File Offset: 0x000847A2
		public virtual XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf)
		{
			return new XPathDescendantIterator(this.Clone(), type, matchSelf);
		}

		/// <summary>
		///         Выбирает все узлы-потомки текущего узла с заданным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="name">
		///           Локальное имя узлов-потомков.
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен узлов-потомков.
		///         </param>
		/// <param name="matchSelf">
		///           <see langword="true" /> Чтобы включить контекстный узел в выделение; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNodeIterator" />, содержащий выбранные узлы.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <see langword="null" /> не может передаваться в качестве параметра.
		///           </exception>
		// Token: 0x06001659 RID: 5721 RVA: 0x000865B1 File Offset: 0x000847B1
		public virtual XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf)
		{
			return new XPathDescendantIterator(this.Clone(), name, namespaceURI, matchSelf);
		}

		/// <summary>
		///         Получает значение, указывающее, может ли <see cref="T:System.Xml.XPath.XPathNavigator" /> редактировать базовые данные XML.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если <see cref="T:System.Xml.XPath.XPathNavigator" /> может редактировать базовые данные XML; в противном случае — значение <see langword="false" />
		///       </returns>
		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		public virtual bool CanEdit
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Xml.XmlWriter" />, используемый для создания нового дочернего узла в начале списка дочерних узлов текущего узла.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />, используемый для создания нового дочернего узла в начале списка дочерних узлов текущего узла.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел, в котором расположен объект <see cref="T:System.Xml.XPath.XPathNavigator" />, не разрешает добавить перед собой новый дочерний узел.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x0600165B RID: 5723 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual XmlWriter PrependChild()
		{
			throw new NotSupportedException();
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Xml.XmlWriter" />, используемый для создания одного или нескольких дочерних узлов в конце списка дочерних узлов текущего узла.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />, используемый для создания новых дочерних узлов в конце списка дочерних узлов текущего узла.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел, в котором располагается <see cref="T:System.Xml.XPath.XPathNavigator" />, не является ни корневым узлом, ни узлом элемента.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x0600165C RID: 5724 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual XmlWriter AppendChild()
		{
			throw new NotSupportedException();
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Xml.XmlWriter" />, используемый для создания нового сестринского узла после текущего выбранного узла.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />, используемый для создания нового сестринского узла после текущего выбранного узла.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Положение <see cref="T:System.Xml.XPath.XPathNavigator" /> не допускает вставку нового сестринского узла после текущего узла.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x0600165D RID: 5725 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual XmlWriter InsertAfter()
		{
			throw new NotSupportedException();
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Xml.XmlWriter" />, используемый для создания нового сестринского узла перед текущим выбранным узлом.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />, используемый для создания нового сестринского перед текущим выбранным узлом.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Положение <see cref="T:System.Xml.XPath.XPathNavigator" /> не допускает вставку нового сестринского узла перед текущим узлом.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x0600165E RID: 5726 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual XmlWriter InsertBefore()
		{
			throw new NotSupportedException();
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Xml.XmlWriter" />, используемый для создания новых атрибутов текущего элемента.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />, используемый для создания новых атрибутов текущего элемента.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не находится в узле элемента.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x0600165F RID: 5727 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual XmlWriter CreateAttributes()
		{
			throw new NotSupportedException();
		}

		/// <summary>
		///         Заменяет узлы того же уровня в диапазоне от текущего до заданного узла.
		///       </summary>
		/// <param name="lastSiblingToReplace">
		///           Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, расположенный в последнем сестринском узле в заменяемом диапазоне.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlWriter" />, используемый для указания диапазона замены.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Заданный объект <see cref="T:System.Xml.XPath.XPathNavigator" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Указанный последний заменяемый узел не является допустимым сестринским узлом текущего узла.
		///           </exception>
		// Token: 0x06001660 RID: 5728 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual XmlWriter ReplaceRange(XPathNavigator lastSiblingToReplace)
		{
			throw new NotSupportedException();
		}

		/// <summary>
		///         Заменяет текущий узел содержимым указанной строки.
		///       </summary>
		/// <param name="newNode">
		///           Строка данных XML для нового узла.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр строки XML — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не находится в элементе, тексте, инструкции по обработке или узле комментария.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Неправильный формат параметра строки XML.
		///           </exception>
		// Token: 0x06001661 RID: 5729 RVA: 0x000865C4 File Offset: 0x000847C4
		public virtual void ReplaceSelf(string newNode)
		{
			XmlReader newNode2 = this.CreateContextReader(newNode, false);
			this.ReplaceSelf(newNode2);
		}

		/// <summary>
		///         Заменяет текущий узел содержимым указанного объекта <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="newNode">
		///           Объект <see cref="T:System.Xml.XmlReader" />, расположенный в XML-данных для нового узла.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Объект <see cref="T:System.Xml.XmlReader" /> находится в состоянии ошибки или закрыт.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр объекта <see cref="T:System.Xml.XmlReader" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XPath.XPathNavigator" /> Находится не на элемент, текст, инструкция по обработке или узел комментария.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             XML-содержимое параметра объекта <see cref="T:System.Xml.XmlReader" /> сформировано некорректно.
		///           </exception>
		// Token: 0x06001662 RID: 5730 RVA: 0x000865E4 File Offset: 0x000847E4
		public virtual void ReplaceSelf(XmlReader newNode)
		{
			if (newNode == null)
			{
				throw new ArgumentNullException("newNode");
			}
			XPathNodeType nodeType = this.NodeType;
			if (nodeType == XPathNodeType.Root || nodeType == XPathNodeType.Attribute || nodeType == XPathNodeType.Namespace)
			{
				throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current position of the navigator."));
			}
			XmlWriter xmlWriter = this.ReplaceRange(this);
			this.BuildSubtree(newNode, xmlWriter);
			xmlWriter.Close();
		}

		/// <summary>
		///         Заменяет текущий узел содержимым указанного объекта <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <param name="newNode">
		///           Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, расположенный в новом узле.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр объекта <see cref="T:System.Xml.XPath.XPathNavigator" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XPath.XPathNavigator" /> Находится не на элемент, текст, инструкция по обработке или узел комментария.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             XML-содержимое параметра объекта <see cref="T:System.Xml.XPath.XPathNavigator" /> сформировано некорректно.
		///           </exception>
		// Token: 0x06001663 RID: 5731 RVA: 0x00086638 File Offset: 0x00084838
		public virtual void ReplaceSelf(XPathNavigator newNode)
		{
			if (newNode == null)
			{
				throw new ArgumentNullException("newNode");
			}
			XmlReader newNode2 = newNode.CreateReader();
			this.ReplaceSelf(newNode2);
		}

		/// <summary>
		///         Возвращает или задает разметку, представляющую открывающие и закрывающие теги текущего узла и его дочерних узлов.
		///       </summary>
		/// <returns>
		///         Строка <see cref="T:System.String" />, содержащая разметку, которая представляет открывающие и закрывающие теги текущего узла и его дочерних узлов.
		///       </returns>
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x00086664 File Offset: 0x00084864
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x00086750 File Offset: 0x00084950
		public virtual string OuterXml
		{
			get
			{
				if (this.NodeType == XPathNodeType.Attribute)
				{
					return this.Name + "=\"" + this.Value + "\"";
				}
				if (this.NodeType != XPathNodeType.Namespace)
				{
					StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
					XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings
					{
						Indent = true,
						OmitXmlDeclaration = true,
						ConformanceLevel = ConformanceLevel.Auto
					});
					try
					{
						xmlWriter.WriteNode(this, true);
					}
					finally
					{
						xmlWriter.Close();
					}
					return stringWriter.ToString();
				}
				if (this.LocalName.Length == 0)
				{
					return "xmlns=\"" + this.Value + "\"";
				}
				return string.Concat(new string[]
				{
					"xmlns:",
					this.LocalName,
					"=\"",
					this.Value,
					"\""
				});
			}
			set
			{
				this.ReplaceSelf(value);
			}
		}

		/// <summary>
		///         Возвращает или задает разметку, представляющую дочерние узлы текущего узла.
		///       </summary>
		/// <returns>
		///         Строка <see cref="T:System.String" />, содержащая разметку дочерних узлов текущего узла.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Невозможно задать свойство <see cref="P:System.Xml.XPath.XPathNavigator.InnerXml" />.
		///           </exception>
		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x0008675C File Offset: 0x0008495C
		// (set) Token: 0x06001667 RID: 5735 RVA: 0x000867F8 File Offset: 0x000849F8
		public virtual string InnerXml
		{
			get
			{
				XPathNodeType nodeType = this.NodeType;
				if (nodeType <= XPathNodeType.Element)
				{
					StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
					XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings
					{
						Indent = true,
						OmitXmlDeclaration = true,
						ConformanceLevel = ConformanceLevel.Auto
					});
					try
					{
						if (this.MoveToFirstChild())
						{
							do
							{
								xmlWriter.WriteNode(this, true);
							}
							while (this.MoveToNext());
							this.MoveToParent();
						}
					}
					finally
					{
						xmlWriter.Close();
					}
					return stringWriter.ToString();
				}
				if (nodeType - XPathNodeType.Attribute > 1)
				{
					return string.Empty;
				}
				return this.Value;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				XPathNodeType nodeType = this.NodeType;
				if (nodeType > XPathNodeType.Element)
				{
					if (nodeType != XPathNodeType.Attribute)
					{
						throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current position of the navigator."));
					}
					this.SetValue(value);
					return;
				}
				else
				{
					XPathNavigator xpathNavigator = this.CreateNavigator();
					while (xpathNavigator.MoveToFirstChild())
					{
						xpathNavigator.DeleteSelf();
					}
					if (value.Length != 0)
					{
						xpathNavigator.AppendChild(value);
						return;
					}
					return;
				}
			}
		}

		/// <summary>
		///         Создает новый дочерний узел в конце списка дочерних узлов текущего узла, используя заданную строку данных XML.
		///       </summary>
		/// <param name="newChild">
		///           Строка данных XML для нового дочернего узла.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр строки XML-данных — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел, в котором располагается <see cref="T:System.Xml.XPath.XPathNavigator" />, не является ни корневым узлом, ни узлом элемента.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Неправильный формат параметра строки XML-данных.
		///           </exception>
		// Token: 0x06001668 RID: 5736 RVA: 0x00086864 File Offset: 0x00084A64
		public virtual void AppendChild(string newChild)
		{
			XmlReader newChild2 = this.CreateContextReader(newChild, true);
			this.AppendChild(newChild2);
		}

		/// <summary>
		///         Создает новый дочерний узел в конце списка дочерних узлов текущего узла, используя XML-содержимое заданного объекта <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="newChild">
		///           Объект <see cref="T:System.Xml.XmlReader" />, расположенный в XML-данных для нового дочернего узла.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Объект <see cref="T:System.Xml.XmlReader" /> находится в состоянии ошибки или закрыт.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр объекта <see cref="T:System.Xml.XmlReader" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел, в котором располагается <see cref="T:System.Xml.XPath.XPathNavigator" />, не является ни корневым узлом, ни узлом элемента.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             XML-содержимое параметра объекта <see cref="T:System.Xml.XmlReader" /> сформировано некорректно.
		///           </exception>
		// Token: 0x06001669 RID: 5737 RVA: 0x00086884 File Offset: 0x00084A84
		public virtual void AppendChild(XmlReader newChild)
		{
			if (newChild == null)
			{
				throw new ArgumentNullException("newChild");
			}
			XmlWriter xmlWriter = this.AppendChild();
			this.BuildSubtree(newChild, xmlWriter);
			xmlWriter.Close();
		}

		/// <summary>
		///         Создает новый дочерний узел в конце списка дочерних узлов текущего узла, используя узлы в заданном <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <param name="newChild">
		///           Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, расположенный в узле, который следует добавить как новый дочерний узел.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр объекта <see cref="T:System.Xml.XPath.XPathNavigator" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел, в котором располагается <see cref="T:System.Xml.XPath.XPathNavigator" />, не является ни корневым узлом, ни узлом элемента.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x0600166A RID: 5738 RVA: 0x000868B4 File Offset: 0x00084AB4
		public virtual void AppendChild(XPathNavigator newChild)
		{
			if (newChild == null)
			{
				throw new ArgumentNullException("newChild");
			}
			if (!this.IsValidChildType(newChild.NodeType))
			{
				throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current position of the navigator."));
			}
			XmlReader newChild2 = newChild.CreateReader();
			this.AppendChild(newChild2);
		}

		/// <summary>
		///         Создает новый дочерний узел в начале списка дочерних узлов текущего узла, используя заданную строку XML.
		///       </summary>
		/// <param name="newChild">
		///           Строка данных XML для нового дочернего узла.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр строки XML — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел, в котором расположен объект <see cref="T:System.Xml.XPath.XPathNavigator" />, не разрешает добавить перед собой новый дочерний узел.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Неправильный формат параметра строки XML.
		///           </exception>
		// Token: 0x0600166B RID: 5739 RVA: 0x000868FC File Offset: 0x00084AFC
		public virtual void PrependChild(string newChild)
		{
			XmlReader newChild2 = this.CreateContextReader(newChild, true);
			this.PrependChild(newChild2);
		}

		/// <summary>
		///         Создает новый дочерний узел в начале списка дочерних узлов текущего узла, используя XML-содержимое указанного объекта <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="newChild">
		///           Объект <see cref="T:System.Xml.XmlReader" />, расположенный в XML-данных для нового дочернего узла.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Объект <see cref="T:System.Xml.XmlReader" /> находится в состоянии ошибки или закрыт.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Объект <see cref="T:System.Xml.XmlReader" /> имеет параметр <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел, в котором расположен объект <see cref="T:System.Xml.XPath.XPathNavigator" />, не разрешает добавить перед собой новый дочерний узел.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             XML-содержимое параметра объекта <see cref="T:System.Xml.XmlReader" /> сформировано некорректно.
		///           </exception>
		// Token: 0x0600166C RID: 5740 RVA: 0x0008691C File Offset: 0x00084B1C
		public virtual void PrependChild(XmlReader newChild)
		{
			if (newChild == null)
			{
				throw new ArgumentNullException("newChild");
			}
			XmlWriter xmlWriter = this.PrependChild();
			this.BuildSubtree(newChild, xmlWriter);
			xmlWriter.Close();
		}

		/// <summary>
		///         Создает новый дочерний узел в начале списка дочерних узлов текущего узла, используя узлы из указанного объекта <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <param name="newChild">
		///           Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, расположенный в узле, который следует добавить как новый дочерний узел.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр объекта <see cref="T:System.Xml.XPath.XPathNavigator" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел, в котором расположен объект <see cref="T:System.Xml.XPath.XPathNavigator" />, не разрешает добавить перед собой новый дочерний узел.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x0600166D RID: 5741 RVA: 0x0008694C File Offset: 0x00084B4C
		public virtual void PrependChild(XPathNavigator newChild)
		{
			if (newChild == null)
			{
				throw new ArgumentNullException("newChild");
			}
			if (!this.IsValidChildType(newChild.NodeType))
			{
				throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current position of the navigator."));
			}
			XmlReader newChild2 = newChild.CreateReader();
			this.PrependChild(newChild2);
		}

		/// <summary>
		///         Создает перед текущим выбранным узлом новый узел того же уровня, используя заданную строку XML.
		///       </summary>
		/// <param name="newSibling">
		///           Строка данных XML для нового узла того же уровня.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр строки XML — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Положение <see cref="T:System.Xml.XPath.XPathNavigator" /> не допускает вставку нового сестринского узла перед текущим узлом.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Неправильный формат параметра строки XML.
		///           </exception>
		// Token: 0x0600166E RID: 5742 RVA: 0x00086994 File Offset: 0x00084B94
		public virtual void InsertBefore(string newSibling)
		{
			XmlReader newSibling2 = this.CreateContextReader(newSibling, false);
			this.InsertBefore(newSibling2);
		}

		/// <summary>
		///         Создает новый сестринский узел того же уровня перед выбранным в данный момент узлом, используя XML-содержимое указанного объекта <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="newSibling">
		///           Объект <see cref="T:System.Xml.XmlReader" />, расположенный в XML-данных для нового сестринского узла.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Объект <see cref="T:System.Xml.XmlReader" /> находится в состоянии ошибки или закрыт.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Объект <see cref="T:System.Xml.XmlReader" /> имеет параметр <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Положение <see cref="T:System.Xml.XPath.XPathNavigator" /> не допускает вставку нового сестринского узла перед текущим узлом.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             XML-содержимое параметра объекта <see cref="T:System.Xml.XmlReader" /> сформировано некорректно.
		///           </exception>
		// Token: 0x0600166F RID: 5743 RVA: 0x000869B4 File Offset: 0x00084BB4
		public virtual void InsertBefore(XmlReader newSibling)
		{
			if (newSibling == null)
			{
				throw new ArgumentNullException("newSibling");
			}
			XmlWriter xmlWriter = this.InsertBefore();
			this.BuildSubtree(newSibling, xmlWriter);
			xmlWriter.Close();
		}

		/// <summary>
		///         Создает новый сестринский узел перед выбранным в данный момент узлом, используя узлы, содержащиеся в указанном объекте <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <param name="newSibling">
		///           Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, расположенный в узле, который следует добавить как новый сестринский узел.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр объекта <see cref="T:System.Xml.XPath.XPathNavigator" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Положение <see cref="T:System.Xml.XPath.XPathNavigator" /> не допускает вставку нового сестринского узла перед текущим узлом.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x06001670 RID: 5744 RVA: 0x000869E4 File Offset: 0x00084BE4
		public virtual void InsertBefore(XPathNavigator newSibling)
		{
			if (newSibling == null)
			{
				throw new ArgumentNullException("newSibling");
			}
			if (!this.IsValidSiblingType(newSibling.NodeType))
			{
				throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current position of the navigator."));
			}
			XmlReader newSibling2 = newSibling.CreateReader();
			this.InsertBefore(newSibling2);
		}

		/// <summary>
		///         Создает после текущего выбранного узла новый узел того же уровня, используя заданную строку XML.
		///       </summary>
		/// <param name="newSibling">
		///           Строка данных XML для нового узла того же уровня.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр строки XML — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Положение объекта <see cref="T:System.Xml.XPath.XPathNavigator" /> не допускает вставку нового сестринского узла после текущего узла.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Неправильный формат параметра строки XML.
		///           </exception>
		// Token: 0x06001671 RID: 5745 RVA: 0x00086A2C File Offset: 0x00084C2C
		public virtual void InsertAfter(string newSibling)
		{
			XmlReader newSibling2 = this.CreateContextReader(newSibling, false);
			this.InsertAfter(newSibling2);
		}

		/// <summary>
		///         Создает новый сестринский узел после выбранного в текущий момент узла, используя содержимое XML указанного объекта <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="newSibling">
		///           Объект <see cref="T:System.Xml.XmlReader" />, расположенный в XML-данных для нового сестринского узла.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Объект <see cref="T:System.Xml.XmlReader" /> находится в состоянии ошибки или закрыт.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Объект <see cref="T:System.Xml.XmlReader" /> имеет параметр <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Положение <see cref="T:System.Xml.XPath.XPathNavigator" /> не допускает вставку нового сестринского узла после текущего узла.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             XML-содержимое параметра объекта <see cref="T:System.Xml.XmlReader" /> сформировано некорректно.
		///           </exception>
		// Token: 0x06001672 RID: 5746 RVA: 0x00086A4C File Offset: 0x00084C4C
		public virtual void InsertAfter(XmlReader newSibling)
		{
			if (newSibling == null)
			{
				throw new ArgumentNullException("newSibling");
			}
			XmlWriter xmlWriter = this.InsertAfter();
			this.BuildSubtree(newSibling, xmlWriter);
			xmlWriter.Close();
		}

		/// <summary>
		///         Создает новый сестринский узел после выбранного в данный момент узла, используя узлы, содержащиеся в указанном объекте <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <param name="newSibling">
		///           Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, расположенный в узле, который следует добавить как новый сестринский узел.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр объекта <see cref="T:System.Xml.XPath.XPathNavigator" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Положение <see cref="T:System.Xml.XPath.XPathNavigator" /> не допускает вставку нового сестринского узла после текущего узла.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x06001673 RID: 5747 RVA: 0x00086A7C File Offset: 0x00084C7C
		public virtual void InsertAfter(XPathNavigator newSibling)
		{
			if (newSibling == null)
			{
				throw new ArgumentNullException("newSibling");
			}
			if (!this.IsValidSiblingType(newSibling.NodeType))
			{
				throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current position of the navigator."));
			}
			XmlReader newSibling2 = newSibling.CreateReader();
			this.InsertAfter(newSibling2);
		}

		/// <summary>
		///         Удаляет узлы того же уровня в диапазоне от текущего до заданного узла.
		///       </summary>
		/// <param name="lastSiblingToDelete">
		///           Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, расположенный в последнем сестринском узле в удаляемом диапазоне.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Заданный объект <see cref="T:System.Xml.XPath.XPathNavigator" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Указанный последний удаляемый узел является допустимым сестринским узлом текущего узла.
		///           </exception>
		// Token: 0x06001674 RID: 5748 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual void DeleteRange(XPathNavigator lastSiblingToDelete)
		{
			throw new NotSupportedException();
		}

		/// <summary>
		///         Удаляет текущий узел и его дочерние узлы.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> расположен в узле, который не может быть удален как корневой узел или узел пространства имен.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x06001675 RID: 5749 RVA: 0x00086AC3 File Offset: 0x00084CC3
		public virtual void DeleteSelf()
		{
			this.DeleteRange(this);
		}

		/// <summary>
		///         Создает новый элемент дочернего узла в начале списка дочерних узлов текущего узла, используя заданный префикс пространства имен, локальное имя, URI пространства имен значение.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен нового дочернего элемента (если имеется).
		///         </param>
		/// <param name="localName">
		///           Локальное имя нового дочернего элемента (если имеется).
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен нового дочернего элемента (если имеется).
		///           <see cref="F:System.String.Empty" /> и <see langword="null" /> эквивалентны.
		///         </param>
		/// <param name="value">
		///           Значение нового дочернего элемента.
		///            Если передается значение <see cref="F:System.String.Empty" /> или <see langword="null" />, то создается пустой элемент.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел, в котором расположен объект <see cref="T:System.Xml.XPath.XPathNavigator" />, не разрешает добавить перед собой новый дочерний узел.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x06001676 RID: 5750 RVA: 0x00086ACC File Offset: 0x00084CCC
		public virtual void PrependChildElement(string prefix, string localName, string namespaceURI, string value)
		{
			XmlWriter xmlWriter = this.PrependChild();
			xmlWriter.WriteStartElement(prefix, localName, namespaceURI);
			if (value != null)
			{
				xmlWriter.WriteString(value);
			}
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
		}

		/// <summary>
		///         Создает новый элемент дочернего узла в конце списка дочерних узлов текущего узла, используя заданный префикс пространства имен, локальное имя, URI пространства имен и указанное значение.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен нового элемента дочернего узла (если имеется).
		///         </param>
		/// <param name="localName">
		///           Локальное имя нового элемента дочернего узла (если имеется).
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен нового дочернего узла элементов (если имеется).
		///           <see cref="F:System.String.Empty" /> и <see langword="null" /> эквивалентны.
		///         </param>
		/// <param name="value">
		///           Значение нового элемента дочернего узла.
		///            Если передается значение <see cref="F:System.String.Empty" /> или <see langword="null" />, то создается пустой элемент.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел, в котором располагается <see cref="T:System.Xml.XPath.XPathNavigator" />, не является ни корневым узлом, ни узлом элемента.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x06001677 RID: 5751 RVA: 0x00086B04 File Offset: 0x00084D04
		public virtual void AppendChildElement(string prefix, string localName, string namespaceURI, string value)
		{
			XmlWriter xmlWriter = this.AppendChild();
			xmlWriter.WriteStartElement(prefix, localName, namespaceURI);
			if (value != null)
			{
				xmlWriter.WriteString(value);
			}
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
		}

		/// <summary>
		///         Создает перед текущим узлом новый элемент того же уровня, используя заданный префикс пространства имен, локальное имя, URI пространства имен и значение.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен нового дочернего элемента (если имеется).
		///         </param>
		/// <param name="localName">
		///           Локальное имя нового дочернего элемента (если имеется).
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен нового дочернего элемента (если имеется).
		///           <see cref="F:System.String.Empty" /> и <see langword="null" /> эквивалентны.
		///         </param>
		/// <param name="value">
		///           Значение нового дочернего элемента.
		///            Если передается значение <see cref="F:System.String.Empty" /> или <see langword="null" />, то создается пустой элемент.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Положение <see cref="T:System.Xml.XPath.XPathNavigator" /> не допускает вставку нового сестринского узла перед текущим узлом.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x06001678 RID: 5752 RVA: 0x00086B3C File Offset: 0x00084D3C
		public virtual void InsertElementBefore(string prefix, string localName, string namespaceURI, string value)
		{
			XmlWriter xmlWriter = this.InsertBefore();
			xmlWriter.WriteStartElement(prefix, localName, namespaceURI);
			if (value != null)
			{
				xmlWriter.WriteString(value);
			}
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
		}

		/// <summary>
		///         Создает после текущего узла новый элемент с тем же родителем, используя заданный префикс пространства имен, локальное имя, URI пространства имен и значение.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен нового дочернего элемента (если имеется).
		///         </param>
		/// <param name="localName">
		///           Локальное имя нового дочернего элемента (если имеется).
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен нового дочернего элемента (если имеется).
		///           <see cref="F:System.String.Empty" /> и <see langword="null" /> эквивалентны.
		///         </param>
		/// <param name="value">
		///           Значение нового дочернего элемента.
		///            Если передается значение <see cref="F:System.String.Empty" /> или <see langword="null" />, то создается пустой элемент.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Положение объекта <see cref="T:System.Xml.XPath.XPathNavigator" /> не допускает вставку нового сестринского узла после текущего узла.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x06001679 RID: 5753 RVA: 0x00086B74 File Offset: 0x00084D74
		public virtual void InsertElementAfter(string prefix, string localName, string namespaceURI, string value)
		{
			XmlWriter xmlWriter = this.InsertAfter();
			xmlWriter.WriteStartElement(prefix, localName, namespaceURI);
			if (value != null)
			{
				xmlWriter.WriteString(value);
			}
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
		}

		/// <summary>
		///         Создает узел атрибута в текущем узле элемента, используя заданный префикс пространства имен, локальное имя, URI пространства имен и указанное значение.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен нового узла атрибута (если имеется).
		///         </param>
		/// <param name="localName">
		///           Локальное имя нового узла атрибута, которое не может быть <see cref="F:System.String.Empty" /> или <see langword="null" />.
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен нового узла атрибута (если имеется).
		///         </param>
		/// <param name="value">
		///           Значение нового узла атрибута.
		///            Если передается значение <see cref="F:System.String.Empty" /> или <see langword="null" />, то создается пустой узел атрибута.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не находится в узле элемента.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Объект <see cref="T:System.Xml.XPath.XPathNavigator" /> не поддерживает редактирование.
		///           </exception>
		// Token: 0x0600167A RID: 5754 RVA: 0x00086BAC File Offset: 0x00084DAC
		public virtual void CreateAttribute(string prefix, string localName, string namespaceURI, string value)
		{
			XmlWriter xmlWriter = this.CreateAttributes();
			xmlWriter.WriteStartAttribute(prefix, localName, namespaceURI);
			if (value != null)
			{
				xmlWriter.WriteString(value);
			}
			xmlWriter.WriteEndAttribute();
			xmlWriter.Close();
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00086BE4 File Offset: 0x00084DE4
		internal bool MoveToPrevious(string localName, string namespaceURI)
		{
			XPathNavigator other = this.Clone();
			localName = ((localName != null) ? this.NameTable.Get(localName) : null);
			while (this.MoveToPrevious())
			{
				if (this.NodeType == XPathNodeType.Element && localName == this.LocalName && namespaceURI == this.NamespaceURI)
				{
					return true;
				}
			}
			this.MoveTo(other);
			return false;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00086C44 File Offset: 0x00084E44
		internal bool MoveToPrevious(XPathNodeType type)
		{
			XPathNavigator other = this.Clone();
			int contentKindMask = XPathNavigator.GetContentKindMask(type);
			while (this.MoveToPrevious())
			{
				if ((1 << (int)this.NodeType & contentKindMask) != 0)
				{
					return true;
				}
			}
			this.MoveTo(other);
			return false;
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00086C84 File Offset: 0x00084E84
		internal bool MoveToNonDescendant()
		{
			if (this.NodeType == XPathNodeType.Root)
			{
				return false;
			}
			if (this.MoveToNext())
			{
				return true;
			}
			XPathNavigator xpathNavigator = this.Clone();
			if (!this.MoveToParent())
			{
				return false;
			}
			XPathNodeType nodeType = xpathNavigator.NodeType;
			if (nodeType - XPathNodeType.Attribute <= 1 && this.MoveToFirstChild())
			{
				return true;
			}
			while (!this.MoveToNext())
			{
				if (!this.MoveToParent())
				{
					this.MoveTo(xpathNavigator);
					return false;
				}
			}
			return true;
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x00086CE8 File Offset: 0x00084EE8
		internal uint IndexInParent
		{
			get
			{
				XPathNavigator xpathNavigator = this.Clone();
				uint num = 0U;
				XPathNodeType nodeType = this.NodeType;
				if (nodeType != XPathNodeType.Attribute)
				{
					if (nodeType != XPathNodeType.Namespace)
					{
						while (xpathNavigator.MoveToNext())
						{
							num += 1U;
						}
					}
					else
					{
						while (xpathNavigator.MoveToNextNamespace())
						{
							num += 1U;
						}
					}
				}
				else
				{
					while (xpathNavigator.MoveToNextAttribute())
					{
						num += 1U;
					}
				}
				return num;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00086D38 File Offset: 0x00084F38
		internal virtual string UniqueId
		{
			get
			{
				XPathNavigator xpathNavigator = this.Clone();
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(XPathNavigator.NodeTypeLetter[(int)this.NodeType]);
				for (;;)
				{
					uint num = xpathNavigator.IndexInParent;
					if (!xpathNavigator.MoveToParent())
					{
						break;
					}
					if (num <= 31U)
					{
						stringBuilder.Append(XPathNavigator.UniqueIdTbl[(int)num]);
					}
					else
					{
						stringBuilder.Append('0');
						do
						{
							stringBuilder.Append(XPathNavigator.UniqueIdTbl[(int)(num & 31U)]);
							num >>= 5;
						}
						while (num != 0U);
						stringBuilder.Append('0');
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00086DBC File Offset: 0x00084FBC
		private static XPathExpression CompileMatchPattern(string xpath)
		{
			bool needContext;
			return new CompiledXpathExpr(new QueryBuilder().BuildPatternQuery(xpath, out needContext), xpath, needContext);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00086DE0 File Offset: 0x00084FE0
		private static int GetDepth(XPathNavigator nav)
		{
			int num = 0;
			while (nav.MoveToParent())
			{
				num++;
			}
			return num;
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00086E00 File Offset: 0x00085000
		private XmlNodeOrder CompareSiblings(XPathNavigator n1, XPathNavigator n2)
		{
			int num = 0;
			XPathNodeType nodeType = n1.NodeType;
			if (nodeType != XPathNodeType.Attribute)
			{
				if (nodeType != XPathNodeType.Namespace)
				{
					num += 2;
				}
			}
			else
			{
				num++;
			}
			nodeType = n2.NodeType;
			if (nodeType != XPathNodeType.Attribute)
			{
				if (nodeType == XPathNodeType.Namespace)
				{
					if (num == 0)
					{
						while (n1.MoveToNextNamespace())
						{
							if (n1.IsSamePosition(n2))
							{
								return XmlNodeOrder.Before;
							}
						}
					}
				}
				else
				{
					num -= 2;
					if (num == 0)
					{
						while (n1.MoveToNext())
						{
							if (n1.IsSamePosition(n2))
							{
								return XmlNodeOrder.Before;
							}
						}
					}
				}
			}
			else
			{
				num--;
				if (num == 0)
				{
					while (n1.MoveToNextAttribute())
					{
						if (n1.IsSamePosition(n2))
						{
							return XmlNodeOrder.Before;
						}
					}
				}
			}
			if (num >= 0)
			{
				return XmlNodeOrder.After;
			}
			return XmlNodeOrder.Before;
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00086E94 File Offset: 0x00085094
		internal static XmlNamespaceManager GetNamespaces(IXmlNamespaceResolver resolver)
		{
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(new NameTable());
			foreach (KeyValuePair<string, string> keyValuePair in resolver.GetNamespacesInScope(XmlNamespaceScope.All))
			{
				if (keyValuePair.Key != "xmlns")
				{
					xmlNamespaceManager.AddNamespace(keyValuePair.Key, keyValuePair.Value);
				}
			}
			return xmlNamespaceManager;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00086F10 File Offset: 0x00085110
		internal static int GetContentKindMask(XPathNodeType type)
		{
			return XPathNavigator.ContentKindMasks[(int)type];
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00086F19 File Offset: 0x00085119
		internal static int GetKindMask(XPathNodeType type)
		{
			if (type == XPathNodeType.All)
			{
				return int.MaxValue;
			}
			if (type == XPathNodeType.Text)
			{
				return 112;
			}
			return 1 << (int)type;
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00086F33 File Offset: 0x00085133
		internal static bool IsText(XPathNodeType type)
		{
			return type - XPathNodeType.Text <= 2;
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00086F40 File Offset: 0x00085140
		private bool IsValidChildType(XPathNodeType type)
		{
			XPathNodeType nodeType = this.NodeType;
			if (nodeType != XPathNodeType.Root)
			{
				if (nodeType == XPathNodeType.Element)
				{
					if (type == XPathNodeType.Element || type - XPathNodeType.Text <= 4)
					{
						return true;
					}
				}
			}
			else if (type == XPathNodeType.Element || type - XPathNodeType.SignificantWhitespace <= 3)
			{
				return true;
			}
			return false;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00086F78 File Offset: 0x00085178
		private bool IsValidSiblingType(XPathNodeType type)
		{
			XPathNodeType nodeType = this.NodeType;
			return (nodeType == XPathNodeType.Element || nodeType - XPathNodeType.Text <= 4) && (type == XPathNodeType.Element || type - XPathNodeType.Text <= 4);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00086FA3 File Offset: 0x000851A3
		private XmlReader CreateReader()
		{
			return XPathNavigatorReader.Create(this);
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00086FAC File Offset: 0x000851AC
		private XmlReader CreateContextReader(string xml, bool fromCurrentNode)
		{
			if (xml == null)
			{
				throw new ArgumentNullException("xml");
			}
			XPathNavigator xpathNavigator = this.CreateNavigator();
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(this.NameTable);
			if (!fromCurrentNode)
			{
				xpathNavigator.MoveToParent();
			}
			if (xpathNavigator.MoveToFirstNamespace(XPathNamespaceScope.All))
			{
				do
				{
					xmlNamespaceManager.AddNamespace(xpathNavigator.LocalName, xpathNavigator.Value);
				}
				while (xpathNavigator.MoveToNextNamespace(XPathNamespaceScope.All));
			}
			XmlParserContext context = new XmlParserContext(this.NameTable, xmlNamespaceManager, null, XmlSpace.Default);
			return new XmlTextReader(xml, XmlNodeType.Element, context)
			{
				WhitespaceHandling = WhitespaceHandling.Significant
			};
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00087028 File Offset: 0x00085228
		internal void BuildSubtree(XmlReader reader, XmlWriter writer)
		{
			string text = "http://www.w3.org/2000/xmlns/";
			ReadState readState = reader.ReadState;
			if (readState != ReadState.Initial && readState != ReadState.Interactive)
			{
				throw new ArgumentException(Res.GetString("Operation is not valid due to the current state of the object."), "reader");
			}
			int num = 0;
			if (readState == ReadState.Initial)
			{
				if (!reader.Read())
				{
					return;
				}
				num++;
			}
			do
			{
				switch (reader.NodeType)
				{
				case XmlNodeType.Element:
				{
					writer.WriteStartElement(reader.Prefix, reader.LocalName, reader.NamespaceURI);
					bool isEmptyElement = reader.IsEmptyElement;
					while (reader.MoveToNextAttribute())
					{
						if (reader.NamespaceURI == text)
						{
							if (reader.Prefix.Length == 0)
							{
								writer.WriteAttributeString("", "xmlns", text, reader.Value);
							}
							else
							{
								writer.WriteAttributeString("xmlns", reader.LocalName, text, reader.Value);
							}
						}
						else
						{
							writer.WriteStartAttribute(reader.Prefix, reader.LocalName, reader.NamespaceURI);
							writer.WriteString(reader.Value);
							writer.WriteEndAttribute();
						}
					}
					reader.MoveToElement();
					if (isEmptyElement)
					{
						writer.WriteEndElement();
					}
					else
					{
						num++;
					}
					break;
				}
				case XmlNodeType.Attribute:
					if (reader.NamespaceURI == text)
					{
						if (reader.Prefix.Length == 0)
						{
							writer.WriteAttributeString("", "xmlns", text, reader.Value);
						}
						else
						{
							writer.WriteAttributeString("xmlns", reader.LocalName, text, reader.Value);
						}
					}
					else
					{
						writer.WriteStartAttribute(reader.Prefix, reader.LocalName, reader.NamespaceURI);
						writer.WriteString(reader.Value);
						writer.WriteEndAttribute();
					}
					break;
				case XmlNodeType.Text:
				case XmlNodeType.CDATA:
					writer.WriteString(reader.Value);
					break;
				case XmlNodeType.EntityReference:
					reader.ResolveEntity();
					break;
				case XmlNodeType.ProcessingInstruction:
					writer.WriteProcessingInstruction(reader.LocalName, reader.Value);
					break;
				case XmlNodeType.Comment:
					writer.WriteComment(reader.Value);
					break;
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
					writer.WriteString(reader.Value);
					break;
				case XmlNodeType.EndElement:
					writer.WriteFullEndElement();
					num--;
					break;
				}
			}
			while (reader.Read() && num > 0);
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x00087266 File Offset: 0x00085466
		private object debuggerDisplayProxy
		{
			get
			{
				return new XPathNavigator.DebuggerDisplayProxy(this);
			}
		}

		// Token: 0x04001801 RID: 6145
		internal static readonly XPathNavigatorKeyComparer comparer = new XPathNavigatorKeyComparer();

		// Token: 0x04001802 RID: 6146
		internal static readonly char[] NodeTypeLetter = new char[]
		{
			'R',
			'E',
			'A',
			'N',
			'T',
			'S',
			'W',
			'P',
			'C',
			'X'
		};

		// Token: 0x04001803 RID: 6147
		internal static readonly char[] UniqueIdTbl = new char[]
		{
			'A',
			'B',
			'C',
			'D',
			'E',
			'F',
			'G',
			'H',
			'I',
			'J',
			'K',
			'L',
			'M',
			'N',
			'O',
			'P',
			'Q',
			'R',
			'S',
			'T',
			'U',
			'V',
			'W',
			'X',
			'Y',
			'Z',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6'
		};

		// Token: 0x04001804 RID: 6148
		internal const int AllMask = 2147483647;

		// Token: 0x04001805 RID: 6149
		internal const int NoAttrNmspMask = 2147483635;

		// Token: 0x04001806 RID: 6150
		internal const int TextMask = 112;

		// Token: 0x04001807 RID: 6151
		internal static readonly int[] ContentKindMasks = new int[]
		{
			1,
			2,
			0,
			0,
			112,
			32,
			64,
			128,
			256,
			2147483635
		};

		// Token: 0x0200025A RID: 602
		private class CheckValidityHelper
		{
			// Token: 0x0600168F RID: 5775 RVA: 0x000872D8 File Offset: 0x000854D8
			internal CheckValidityHelper(ValidationEventHandler nextEventHandler, XPathNavigatorReader reader)
			{
				this.isValid = true;
				this.nextEventHandler = nextEventHandler;
				this.reader = reader;
			}

			// Token: 0x06001690 RID: 5776 RVA: 0x000872F8 File Offset: 0x000854F8
			internal void ValidationCallback(object sender, ValidationEventArgs args)
			{
				if (args.Severity == XmlSeverityType.Error)
				{
					this.isValid = false;
				}
				XmlSchemaValidationException ex = args.Exception as XmlSchemaValidationException;
				if (ex != null && this.reader != null)
				{
					ex.SetSourceObject(this.reader.UnderlyingObject);
				}
				if (this.nextEventHandler != null)
				{
					this.nextEventHandler(sender, args);
					return;
				}
				if (ex != null && args.Severity == XmlSeverityType.Error)
				{
					throw ex;
				}
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x06001691 RID: 5777 RVA: 0x0008735F File Offset: 0x0008555F
			internal bool IsValid
			{
				get
				{
					return this.isValid;
				}
			}

			// Token: 0x04001808 RID: 6152
			private bool isValid;

			// Token: 0x04001809 RID: 6153
			private ValidationEventHandler nextEventHandler;

			// Token: 0x0400180A RID: 6154
			private XPathNavigatorReader reader;
		}

		// Token: 0x0200025B RID: 603
		[DebuggerDisplay("{ToString()}")]
		internal struct DebuggerDisplayProxy
		{
			// Token: 0x06001692 RID: 5778 RVA: 0x00087367 File Offset: 0x00085567
			public DebuggerDisplayProxy(XPathNavigator nav)
			{
				this.nav = nav;
			}

			// Token: 0x06001693 RID: 5779 RVA: 0x00087370 File Offset: 0x00085570
			public override string ToString()
			{
				string text = this.nav.NodeType.ToString();
				switch (this.nav.NodeType)
				{
				case XPathNodeType.Element:
					text = text + ", Name=\"" + this.nav.Name + "\"";
					break;
				case XPathNodeType.Attribute:
				case XPathNodeType.Namespace:
				case XPathNodeType.ProcessingInstruction:
					text = text + ", Name=\"" + this.nav.Name + "\"";
					text = text + ", Value=\"" + XmlConvert.EscapeValueForDebuggerDisplay(this.nav.Value) + "\"";
					break;
				case XPathNodeType.Text:
				case XPathNodeType.SignificantWhitespace:
				case XPathNodeType.Whitespace:
				case XPathNodeType.Comment:
					text = text + ", Value=\"" + XmlConvert.EscapeValueForDebuggerDisplay(this.nav.Value) + "\"";
					break;
				}
				return text;
			}

			// Token: 0x0400180B RID: 6155
			private XPathNavigator nav;
		}
	}
}
