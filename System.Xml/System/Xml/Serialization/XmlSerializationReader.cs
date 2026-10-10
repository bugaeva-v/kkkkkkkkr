using System;
using System.Collections;
using System.Configuration;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Xml.Serialization.Configuration;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Управляет десериализации <see cref="T:System.Xml.Serialization.XmlSerializer" /> класса.
	///       </summary>
	// Token: 0x020002EB RID: 747
	public abstract class XmlSerializationReader : XmlSerializationGeneratedCode
	{
		// Token: 0x06001D8B RID: 7563 RVA: 0x000AD4E8 File Offset: 0x000AB6E8
		static XmlSerializationReader()
		{
			XmlSerializerSection xmlSerializerSection = ConfigurationManager.GetSection(ConfigurationStrings.XmlSerializerSectionPath) as XmlSerializerSection;
			XmlSerializationReader.checkDeserializeAdvances = (xmlSerializerSection != null && xmlSerializerSection.CheckDeserializeAdvances);
		}

		/// <summary>
		///         Хранит имена элементов и атрибутов в <see cref="T:System.Xml.NameTable" /> объекта.
		///       </summary>
		// Token: 0x06001D8C RID: 7564
		protected abstract void InitIDs();

		// Token: 0x06001D8D RID: 7565 RVA: 0x000AD518 File Offset: 0x000AB718
		internal void Init(XmlReader r, XmlDeserializationEvents events, string encodingStyle, TempAssembly tempAssembly)
		{
			this.events = events;
			if (XmlSerializationReader.checkDeserializeAdvances)
			{
				this.countingReader = new XmlCountingReader(r);
				this.r = this.countingReader;
			}
			else
			{
				this.r = r;
			}
			this.d = null;
			this.soap12 = (encodingStyle == "http://www.w3.org/2003/05/soap-encoding");
			base.Init(tempAssembly);
			this.schemaNsID = r.NameTable.Add("http://www.w3.org/2001/XMLSchema");
			this.schemaNs2000ID = r.NameTable.Add("http://www.w3.org/2000/10/XMLSchema");
			this.schemaNs1999ID = r.NameTable.Add("http://www.w3.org/1999/XMLSchema");
			this.schemaNonXsdTypesNsID = r.NameTable.Add("http://microsoft.com/wsdl/types/");
			this.instanceNsID = r.NameTable.Add("http://www.w3.org/2001/XMLSchema-instance");
			this.instanceNs2000ID = r.NameTable.Add("http://www.w3.org/2000/10/XMLSchema-instance");
			this.instanceNs1999ID = r.NameTable.Add("http://www.w3.org/1999/XMLSchema-instance");
			this.soapNsID = r.NameTable.Add("http://schemas.xmlsoap.org/soap/encoding/");
			this.soap12NsID = r.NameTable.Add("http://www.w3.org/2003/05/soap-encoding");
			this.schemaID = r.NameTable.Add("schema");
			this.wsdlNsID = r.NameTable.Add("http://schemas.xmlsoap.org/wsdl/");
			this.wsdlArrayTypeID = r.NameTable.Add("arrayType");
			this.nullID = r.NameTable.Add("null");
			this.nilID = r.NameTable.Add("nil");
			this.typeID = r.NameTable.Add("type");
			this.arrayTypeID = r.NameTable.Add("arrayType");
			this.itemTypeID = r.NameTable.Add("itemType");
			this.arraySizeID = r.NameTable.Add("arraySize");
			this.arrayID = r.NameTable.Add("Array");
			this.urTypeID = r.NameTable.Add("anyType");
			this.InitIDs();
		}

		/// <summary>
		///         Возвращает или задает значение, определяющее транслируются ли строки XML в допустимые имена типов .NET Framework.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если строки XML декодированные в допустимые имена типов .NET Framework; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x000AD732 File Offset: 0x000AB932
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x000AD73A File Offset: 0x000AB93A
		protected bool DecodeName
		{
			get
			{
				return this.decodeName;
			}
			set
			{
				this.decodeName = value;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XmlReader" /> объект, который используется <see cref="T:System.Xml.Serialization.XmlSerializationReader" />.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlReader" /> Который используется <see cref="T:System.Xml.Serialization.XmlSerializationReader" />.
		///       </returns>
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x000AD743 File Offset: 0x000AB943
		protected XmlReader Reader
		{
			get
			{
				return this.r;
			}
		}

		/// <summary>
		///         Возвращает текущее количество <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <returns>
		///         Текущее количество <see cref="T:System.Xml.XmlReader" />.
		///       </returns>
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x000AD74B File Offset: 0x000AB94B
		protected int ReaderCount
		{
			get
			{
				if (!XmlSerializationReader.checkDeserializeAdvances)
				{
					return 0;
				}
				return this.countingReader.AdvanceCount;
			}
		}

		/// <summary>
		///         Возвращает объект XML-документа, в который десериализуется документ XML.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlDocument" /> Представляющий десериализованного <see cref="T:System.Xml.XmlDocument" /> данных.
		///       </returns>
		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x000AD761 File Offset: 0x000AB961
		protected XmlDocument Document
		{
			get
			{
				if (this.d == null)
				{
					this.d = new XmlDocument(this.r.NameTable);
					this.d.SetBaseURI(this.r.BaseURI);
				}
				return this.d;
			}
		}

		/// <summary>
		///         Получает динамически созданную сборку по имени.
		///       </summary>
		/// <param name="assemblyFullName">
		///           Полное имя сборки.
		///         </param>
		/// <returns>
		///         Динамически создаваемый <see cref="T:System.Reflection.Assembly" />.
		///       </returns>
		// Token: 0x06001D93 RID: 7571 RVA: 0x000AD79D File Offset: 0x000AB99D
		protected static Assembly ResolveDynamicAssembly(string assemblyFullName)
		{
			return DynamicAssemblies.Get(assemblyFullName);
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x000AD7A8 File Offset: 0x000AB9A8
		private void InitPrimitiveIDs()
		{
			if (this.tokenID != null)
			{
				return;
			}
			this.r.NameTable.Add("http://www.w3.org/2001/XMLSchema");
			this.r.NameTable.Add("http://microsoft.com/wsdl/types/");
			this.stringID = this.r.NameTable.Add("string");
			this.intID = this.r.NameTable.Add("int");
			this.booleanID = this.r.NameTable.Add("boolean");
			this.shortID = this.r.NameTable.Add("short");
			this.longID = this.r.NameTable.Add("long");
			this.floatID = this.r.NameTable.Add("float");
			this.doubleID = this.r.NameTable.Add("double");
			this.decimalID = this.r.NameTable.Add("decimal");
			this.dateTimeID = this.r.NameTable.Add("dateTime");
			this.qnameID = this.r.NameTable.Add("QName");
			this.dateID = this.r.NameTable.Add("date");
			this.timeID = this.r.NameTable.Add("time");
			this.hexBinaryID = this.r.NameTable.Add("hexBinary");
			this.base64BinaryID = this.r.NameTable.Add("base64Binary");
			this.unsignedByteID = this.r.NameTable.Add("unsignedByte");
			this.byteID = this.r.NameTable.Add("byte");
			this.unsignedShortID = this.r.NameTable.Add("unsignedShort");
			this.unsignedIntID = this.r.NameTable.Add("unsignedInt");
			this.unsignedLongID = this.r.NameTable.Add("unsignedLong");
			this.oldDecimalID = this.r.NameTable.Add("decimal");
			this.oldTimeInstantID = this.r.NameTable.Add("timeInstant");
			this.charID = this.r.NameTable.Add("char");
			this.guidID = this.r.NameTable.Add("guid");
			if (LocalAppContextSwitches.EnableTimeSpanSerialization)
			{
				this.timeSpanID = this.r.NameTable.Add("TimeSpan");
			}
			this.base64ID = this.r.NameTable.Add("base64");
			this.anyURIID = this.r.NameTable.Add("anyURI");
			this.durationID = this.r.NameTable.Add("duration");
			this.ENTITYID = this.r.NameTable.Add("ENTITY");
			this.ENTITIESID = this.r.NameTable.Add("ENTITIES");
			this.gDayID = this.r.NameTable.Add("gDay");
			this.gMonthID = this.r.NameTable.Add("gMonth");
			this.gMonthDayID = this.r.NameTable.Add("gMonthDay");
			this.gYearID = this.r.NameTable.Add("gYear");
			this.gYearMonthID = this.r.NameTable.Add("gYearMonth");
			this.IDID = this.r.NameTable.Add("ID");
			this.IDREFID = this.r.NameTable.Add("IDREF");
			this.IDREFSID = this.r.NameTable.Add("IDREFS");
			this.integerID = this.r.NameTable.Add("integer");
			this.languageID = this.r.NameTable.Add("language");
			this.NameID = this.r.NameTable.Add("Name");
			this.NCNameID = this.r.NameTable.Add("NCName");
			this.NMTOKENID = this.r.NameTable.Add("NMTOKEN");
			this.NMTOKENSID = this.r.NameTable.Add("NMTOKENS");
			this.negativeIntegerID = this.r.NameTable.Add("negativeInteger");
			this.nonNegativeIntegerID = this.r.NameTable.Add("nonNegativeInteger");
			this.nonPositiveIntegerID = this.r.NameTable.Add("nonPositiveInteger");
			this.normalizedStringID = this.r.NameTable.Add("normalizedString");
			this.NOTATIONID = this.r.NameTable.Add("NOTATION");
			this.positiveIntegerID = this.r.NameTable.Add("positiveInteger");
			this.tokenID = this.r.NameTable.Add("token");
		}

		/// <summary>
		///         Возвращает значение <see langword="xsi:type" /> атрибут для элемента XML в текущем расположении <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <returns>
		///         Полное имя XML, указывающее тип данных элемента XML.
		///       </returns>
		// Token: 0x06001D95 RID: 7573 RVA: 0x000ADD38 File Offset: 0x000ABF38
		protected XmlQualifiedName GetXsiType()
		{
			string attribute = this.r.GetAttribute(this.typeID, this.instanceNsID);
			if (attribute == null)
			{
				attribute = this.r.GetAttribute(this.typeID, this.instanceNs2000ID);
				if (attribute == null)
				{
					attribute = this.r.GetAttribute(this.typeID, this.instanceNs1999ID);
					if (attribute == null)
					{
						return null;
					}
				}
			}
			return this.ToXmlQualifiedName(attribute, false);
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x000ADDA0 File Offset: 0x000ABFA0
		private Type GetPrimitiveType(XmlQualifiedName typeName, bool throwOnUnknown)
		{
			this.InitPrimitiveIDs();
			if (typeName.Namespace == this.schemaNsID || typeName.Namespace == this.soapNsID || typeName.Namespace == this.soap12NsID)
			{
				if (typeName.Name == this.stringID || typeName.Name == this.anyURIID || typeName.Name == this.durationID || typeName.Name == this.ENTITYID || typeName.Name == this.ENTITIESID || typeName.Name == this.gDayID || typeName.Name == this.gMonthID || typeName.Name == this.gMonthDayID || typeName.Name == this.gYearID || typeName.Name == this.gYearMonthID || typeName.Name == this.IDID || typeName.Name == this.IDREFID || typeName.Name == this.IDREFSID || typeName.Name == this.integerID || typeName.Name == this.languageID || typeName.Name == this.NameID || typeName.Name == this.NCNameID || typeName.Name == this.NMTOKENID || typeName.Name == this.NMTOKENSID || typeName.Name == this.negativeIntegerID || typeName.Name == this.nonPositiveIntegerID || typeName.Name == this.nonNegativeIntegerID || typeName.Name == this.normalizedStringID || typeName.Name == this.NOTATIONID || typeName.Name == this.positiveIntegerID || typeName.Name == this.tokenID)
				{
					return typeof(string);
				}
				if (typeName.Name == this.intID)
				{
					return typeof(int);
				}
				if (typeName.Name == this.booleanID)
				{
					return typeof(bool);
				}
				if (typeName.Name == this.shortID)
				{
					return typeof(short);
				}
				if (typeName.Name == this.longID)
				{
					return typeof(long);
				}
				if (typeName.Name == this.floatID)
				{
					return typeof(float);
				}
				if (typeName.Name == this.doubleID)
				{
					return typeof(double);
				}
				if (typeName.Name == this.decimalID)
				{
					return typeof(decimal);
				}
				if (typeName.Name == this.dateTimeID)
				{
					return typeof(DateTime);
				}
				if (typeName.Name == this.qnameID)
				{
					return typeof(XmlQualifiedName);
				}
				if (typeName.Name == this.dateID)
				{
					return typeof(DateTime);
				}
				if (typeName.Name == this.timeID)
				{
					return typeof(DateTime);
				}
				if (typeName.Name == this.hexBinaryID)
				{
					return typeof(byte[]);
				}
				if (typeName.Name == this.base64BinaryID)
				{
					return typeof(byte[]);
				}
				if (typeName.Name == this.unsignedByteID)
				{
					return typeof(byte);
				}
				if (typeName.Name == this.byteID)
				{
					return typeof(sbyte);
				}
				if (typeName.Name == this.unsignedShortID)
				{
					return typeof(ushort);
				}
				if (typeName.Name == this.unsignedIntID)
				{
					return typeof(uint);
				}
				if (typeName.Name == this.unsignedLongID)
				{
					return typeof(ulong);
				}
				throw this.CreateUnknownTypeException(typeName);
			}
			else if (typeName.Namespace == this.schemaNs2000ID || typeName.Namespace == this.schemaNs1999ID)
			{
				if (typeName.Name == this.stringID || typeName.Name == this.anyURIID || typeName.Name == this.durationID || typeName.Name == this.ENTITYID || typeName.Name == this.ENTITIESID || typeName.Name == this.gDayID || typeName.Name == this.gMonthID || typeName.Name == this.gMonthDayID || typeName.Name == this.gYearID || typeName.Name == this.gYearMonthID || typeName.Name == this.IDID || typeName.Name == this.IDREFID || typeName.Name == this.IDREFSID || typeName.Name == this.integerID || typeName.Name == this.languageID || typeName.Name == this.NameID || typeName.Name == this.NCNameID || typeName.Name == this.NMTOKENID || typeName.Name == this.NMTOKENSID || typeName.Name == this.negativeIntegerID || typeName.Name == this.nonPositiveIntegerID || typeName.Name == this.nonNegativeIntegerID || typeName.Name == this.normalizedStringID || typeName.Name == this.NOTATIONID || typeName.Name == this.positiveIntegerID || typeName.Name == this.tokenID)
				{
					return typeof(string);
				}
				if (typeName.Name == this.intID)
				{
					return typeof(int);
				}
				if (typeName.Name == this.booleanID)
				{
					return typeof(bool);
				}
				if (typeName.Name == this.shortID)
				{
					return typeof(short);
				}
				if (typeName.Name == this.longID)
				{
					return typeof(long);
				}
				if (typeName.Name == this.floatID)
				{
					return typeof(float);
				}
				if (typeName.Name == this.doubleID)
				{
					return typeof(double);
				}
				if (typeName.Name == this.oldDecimalID)
				{
					return typeof(decimal);
				}
				if (typeName.Name == this.oldTimeInstantID)
				{
					return typeof(DateTime);
				}
				if (typeName.Name == this.qnameID)
				{
					return typeof(XmlQualifiedName);
				}
				if (typeName.Name == this.dateID)
				{
					return typeof(DateTime);
				}
				if (typeName.Name == this.timeID)
				{
					return typeof(DateTime);
				}
				if (typeName.Name == this.hexBinaryID)
				{
					return typeof(byte[]);
				}
				if (typeName.Name == this.byteID)
				{
					return typeof(sbyte);
				}
				if (typeName.Name == this.unsignedShortID)
				{
					return typeof(ushort);
				}
				if (typeName.Name == this.unsignedIntID)
				{
					return typeof(uint);
				}
				if (typeName.Name == this.unsignedLongID)
				{
					return typeof(ulong);
				}
				throw this.CreateUnknownTypeException(typeName);
			}
			else if (typeName.Namespace == this.schemaNonXsdTypesNsID)
			{
				if (typeName.Name == this.charID)
				{
					return typeof(char);
				}
				if (typeName.Name == this.guidID)
				{
					return typeof(Guid);
				}
				throw this.CreateUnknownTypeException(typeName);
			}
			else
			{
				if (throwOnUnknown)
				{
					throw this.CreateUnknownTypeException(typeName);
				}
				return null;
			}
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x000AE503 File Offset: 0x000AC703
		private bool IsPrimitiveNamespace(string ns)
		{
			return ns == this.schemaNsID || ns == this.schemaNonXsdTypesNsID || ns == this.soapNsID || ns == this.soap12NsID || ns == this.schemaNs2000ID || ns == this.schemaNs1999ID;
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x000AE53D File Offset: 0x000AC73D
		private string ReadStringValue()
		{
			if (this.r.IsEmptyElement)
			{
				this.r.Skip();
				return string.Empty;
			}
			this.r.ReadStartElement();
			string result = this.r.ReadString();
			this.ReadEndElement();
			return result;
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x000AE57C File Offset: 0x000AC77C
		private XmlQualifiedName ReadXmlQualifiedName()
		{
			bool flag = false;
			string value;
			if (this.r.IsEmptyElement)
			{
				value = string.Empty;
				flag = true;
			}
			else
			{
				this.r.ReadStartElement();
				value = this.r.ReadString();
			}
			XmlQualifiedName result = this.ToXmlQualifiedName(value);
			if (flag)
			{
				this.r.Skip();
				return result;
			}
			this.ReadEndElement();
			return result;
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x000AE5D8 File Offset: 0x000AC7D8
		private byte[] ReadByteArray(bool isBase64)
		{
			ArrayList arrayList = new ArrayList();
			int num = 1024;
			int num2 = -1;
			int num3 = 0;
			int num4 = 0;
			byte[] array = new byte[num];
			arrayList.Add(array);
			while (num2 != 0)
			{
				if (num3 == array.Length)
				{
					num = Math.Min(num * 2, 65536);
					array = new byte[num];
					num3 = 0;
					arrayList.Add(array);
				}
				if (isBase64)
				{
					num2 = this.r.ReadElementContentAsBase64(array, num3, array.Length - num3);
				}
				else
				{
					num2 = this.r.ReadElementContentAsBinHex(array, num3, array.Length - num3);
				}
				num3 += num2;
				num4 += num2;
			}
			byte[] array2 = new byte[num4];
			num3 = 0;
			foreach (object obj in arrayList)
			{
				byte[] array3 = (byte[])obj;
				num = Math.Min(array3.Length, num4);
				if (num > 0)
				{
					Buffer.BlockCopy(array3, 0, array2, num3, num);
					num3 += num;
					num4 -= num;
				}
			}
			arrayList.Clear();
			return array2;
		}

		/// <summary>
		///         Возвращает значение узла XML, по которой <see cref="T:System.Xml.XmlReader" /> в текущий момент находится.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Xml.XmlQualifiedName" /> Представляющий тип данных для текущего расположения <see cref="T:System.Xml.XmlReader" />.
		///         </param>
		/// <returns>
		///         Значение узла как тип значения .NET Framework, если значение простого типа данных схемы XML.
		///       </returns>
		// Token: 0x06001D9B RID: 7579 RVA: 0x000AE6F4 File Offset: 0x000AC8F4
		protected object ReadTypedPrimitive(XmlQualifiedName type)
		{
			return this.ReadTypedPrimitive(type, false);
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x000AE700 File Offset: 0x000AC900
		private object ReadTypedPrimitive(XmlQualifiedName type, bool elementCanBeType)
		{
			this.InitPrimitiveIDs();
			if (!this.IsPrimitiveNamespace(type.Namespace) || type.Name == this.urTypeID)
			{
				return this.ReadXmlNodes(elementCanBeType);
			}
			object result;
			if (type.Namespace == this.schemaNsID || type.Namespace == this.soapNsID || type.Namespace == this.soap12NsID)
			{
				if (type.Name == this.stringID || type.Name == this.normalizedStringID)
				{
					result = this.ReadStringValue();
				}
				else if (type.Name == this.anyURIID || type.Name == this.durationID || type.Name == this.ENTITYID || type.Name == this.ENTITIESID || type.Name == this.gDayID || type.Name == this.gMonthID || type.Name == this.gMonthDayID || type.Name == this.gYearID || type.Name == this.gYearMonthID || type.Name == this.IDID || type.Name == this.IDREFID || type.Name == this.IDREFSID || type.Name == this.integerID || type.Name == this.languageID || type.Name == this.NameID || type.Name == this.NCNameID || type.Name == this.NMTOKENID || type.Name == this.NMTOKENSID || type.Name == this.negativeIntegerID || type.Name == this.nonPositiveIntegerID || type.Name == this.nonNegativeIntegerID || type.Name == this.NOTATIONID || type.Name == this.positiveIntegerID || type.Name == this.tokenID)
				{
					result = this.CollapseWhitespace(this.ReadStringValue());
				}
				else if (type.Name == this.intID)
				{
					result = XmlConvert.ToInt32(this.ReadStringValue());
				}
				else if (type.Name == this.booleanID)
				{
					result = XmlConvert.ToBoolean(this.ReadStringValue());
				}
				else if (type.Name == this.shortID)
				{
					result = XmlConvert.ToInt16(this.ReadStringValue());
				}
				else if (type.Name == this.longID)
				{
					result = XmlConvert.ToInt64(this.ReadStringValue());
				}
				else if (type.Name == this.floatID)
				{
					result = XmlConvert.ToSingle(this.ReadStringValue());
				}
				else if (type.Name == this.doubleID)
				{
					result = XmlConvert.ToDouble(this.ReadStringValue());
				}
				else if (type.Name == this.decimalID)
				{
					result = XmlConvert.ToDecimal(this.ReadStringValue());
				}
				else if (type.Name == this.dateTimeID)
				{
					result = XmlSerializationReader.ToDateTime(this.ReadStringValue());
				}
				else if (type.Name == this.qnameID)
				{
					result = this.ReadXmlQualifiedName();
				}
				else if (type.Name == this.dateID)
				{
					result = XmlSerializationReader.ToDate(this.ReadStringValue());
				}
				else if (type.Name == this.timeID)
				{
					result = XmlSerializationReader.ToTime(this.ReadStringValue());
				}
				else if (type.Name == this.unsignedByteID)
				{
					result = XmlConvert.ToByte(this.ReadStringValue());
				}
				else if (type.Name == this.byteID)
				{
					result = XmlConvert.ToSByte(this.ReadStringValue());
				}
				else if (type.Name == this.unsignedShortID)
				{
					result = XmlConvert.ToUInt16(this.ReadStringValue());
				}
				else if (type.Name == this.unsignedIntID)
				{
					result = XmlConvert.ToUInt32(this.ReadStringValue());
				}
				else if (type.Name == this.unsignedLongID)
				{
					result = XmlConvert.ToUInt64(this.ReadStringValue());
				}
				else if (type.Name == this.hexBinaryID)
				{
					result = this.ToByteArrayHex(false);
				}
				else if (type.Name == this.base64BinaryID)
				{
					result = this.ToByteArrayBase64(false);
				}
				else if (type.Name == this.base64ID && (type.Namespace == this.soapNsID || type.Namespace == this.soap12NsID))
				{
					result = this.ToByteArrayBase64(false);
				}
				else
				{
					result = this.ReadXmlNodes(elementCanBeType);
				}
			}
			else if (type.Namespace == this.schemaNs2000ID || type.Namespace == this.schemaNs1999ID)
			{
				if (type.Name == this.stringID || type.Name == this.normalizedStringID)
				{
					result = this.ReadStringValue();
				}
				else if (type.Name == this.anyURIID || type.Name == this.anyURIID || type.Name == this.durationID || type.Name == this.ENTITYID || type.Name == this.ENTITIESID || type.Name == this.gDayID || type.Name == this.gMonthID || type.Name == this.gMonthDayID || type.Name == this.gYearID || type.Name == this.gYearMonthID || type.Name == this.IDID || type.Name == this.IDREFID || type.Name == this.IDREFSID || type.Name == this.integerID || type.Name == this.languageID || type.Name == this.NameID || type.Name == this.NCNameID || type.Name == this.NMTOKENID || type.Name == this.NMTOKENSID || type.Name == this.negativeIntegerID || type.Name == this.nonPositiveIntegerID || type.Name == this.nonNegativeIntegerID || type.Name == this.NOTATIONID || type.Name == this.positiveIntegerID || type.Name == this.tokenID)
				{
					result = this.CollapseWhitespace(this.ReadStringValue());
				}
				else if (type.Name == this.intID)
				{
					result = XmlConvert.ToInt32(this.ReadStringValue());
				}
				else if (type.Name == this.booleanID)
				{
					result = XmlConvert.ToBoolean(this.ReadStringValue());
				}
				else if (type.Name == this.shortID)
				{
					result = XmlConvert.ToInt16(this.ReadStringValue());
				}
				else if (type.Name == this.longID)
				{
					result = XmlConvert.ToInt64(this.ReadStringValue());
				}
				else if (type.Name == this.floatID)
				{
					result = XmlConvert.ToSingle(this.ReadStringValue());
				}
				else if (type.Name == this.doubleID)
				{
					result = XmlConvert.ToDouble(this.ReadStringValue());
				}
				else if (type.Name == this.oldDecimalID)
				{
					result = XmlConvert.ToDecimal(this.ReadStringValue());
				}
				else if (type.Name == this.oldTimeInstantID)
				{
					result = XmlSerializationReader.ToDateTime(this.ReadStringValue());
				}
				else if (type.Name == this.qnameID)
				{
					result = this.ReadXmlQualifiedName();
				}
				else if (type.Name == this.dateID)
				{
					result = XmlSerializationReader.ToDate(this.ReadStringValue());
				}
				else if (type.Name == this.timeID)
				{
					result = XmlSerializationReader.ToTime(this.ReadStringValue());
				}
				else if (type.Name == this.unsignedByteID)
				{
					result = XmlConvert.ToByte(this.ReadStringValue());
				}
				else if (type.Name == this.byteID)
				{
					result = XmlConvert.ToSByte(this.ReadStringValue());
				}
				else if (type.Name == this.unsignedShortID)
				{
					result = XmlConvert.ToUInt16(this.ReadStringValue());
				}
				else if (type.Name == this.unsignedIntID)
				{
					result = XmlConvert.ToUInt32(this.ReadStringValue());
				}
				else if (type.Name == this.unsignedLongID)
				{
					result = XmlConvert.ToUInt64(this.ReadStringValue());
				}
				else
				{
					result = this.ReadXmlNodes(elementCanBeType);
				}
			}
			else if (type.Namespace == this.schemaNonXsdTypesNsID)
			{
				if (type.Name == this.charID)
				{
					result = XmlSerializationReader.ToChar(this.ReadStringValue());
				}
				else if (type.Name == this.guidID)
				{
					result = new Guid(this.CollapseWhitespace(this.ReadStringValue()));
				}
				else if (type.Name == this.timeSpanID && LocalAppContextSwitches.EnableTimeSpanSerialization)
				{
					result = XmlConvert.ToTimeSpan(this.ReadStringValue());
				}
				else
				{
					result = this.ReadXmlNodes(elementCanBeType);
				}
			}
			else
			{
				result = this.ReadXmlNodes(elementCanBeType);
			}
			return result;
		}

		/// <summary>
		///         Считывает XML-элемента, который допускает значения null (<see langword="xsi:nil = 'true'" />) и возвращает универсальный <see cref="T:System.Nullable`1" /> значение.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Xml.XmlQualifiedName" /> Представляющий тип данных для текущего расположения <see cref="T:System.Xml.XmlReader" />.
		///         </param>
		/// <returns>
		///         Универсальный <see cref="T:System.Nullable`1" /> представляющий значение null XML.
		///       </returns>
		// Token: 0x06001D9D RID: 7581 RVA: 0x000AF084 File Offset: 0x000AD284
		protected object ReadTypedNull(XmlQualifiedName type)
		{
			this.InitPrimitiveIDs();
			if (!this.IsPrimitiveNamespace(type.Namespace) || type.Name == this.urTypeID)
			{
				return null;
			}
			object result;
			if (type.Namespace == this.schemaNsID || type.Namespace == this.soapNsID || type.Namespace == this.soap12NsID)
			{
				if (type.Name == this.stringID || type.Name == this.anyURIID || type.Name == this.durationID || type.Name == this.ENTITYID || type.Name == this.ENTITIESID || type.Name == this.gDayID || type.Name == this.gMonthID || type.Name == this.gMonthDayID || type.Name == this.gYearID || type.Name == this.gYearMonthID || type.Name == this.IDID || type.Name == this.IDREFID || type.Name == this.IDREFSID || type.Name == this.integerID || type.Name == this.languageID || type.Name == this.NameID || type.Name == this.NCNameID || type.Name == this.NMTOKENID || type.Name == this.NMTOKENSID || type.Name == this.negativeIntegerID || type.Name == this.nonPositiveIntegerID || type.Name == this.nonNegativeIntegerID || type.Name == this.normalizedStringID || type.Name == this.NOTATIONID || type.Name == this.positiveIntegerID || type.Name == this.tokenID)
				{
					result = null;
				}
				else if (type.Name == this.intID)
				{
					result = null;
				}
				else if (type.Name == this.booleanID)
				{
					result = null;
				}
				else if (type.Name == this.shortID)
				{
					result = null;
				}
				else if (type.Name == this.longID)
				{
					result = null;
				}
				else if (type.Name == this.floatID)
				{
					result = null;
				}
				else if (type.Name == this.doubleID)
				{
					result = null;
				}
				else if (type.Name == this.decimalID)
				{
					result = null;
				}
				else if (type.Name == this.dateTimeID)
				{
					result = null;
				}
				else if (type.Name == this.qnameID)
				{
					result = null;
				}
				else if (type.Name == this.dateID)
				{
					result = null;
				}
				else if (type.Name == this.timeID)
				{
					result = null;
				}
				else if (type.Name == this.unsignedByteID)
				{
					result = null;
				}
				else if (type.Name == this.byteID)
				{
					result = null;
				}
				else if (type.Name == this.unsignedShortID)
				{
					result = null;
				}
				else if (type.Name == this.unsignedIntID)
				{
					result = null;
				}
				else if (type.Name == this.unsignedLongID)
				{
					result = null;
				}
				else if (type.Name == this.hexBinaryID)
				{
					result = null;
				}
				else if (type.Name == this.base64BinaryID)
				{
					result = null;
				}
				else if (type.Name == this.base64ID && (type.Namespace == this.soapNsID || type.Namespace == this.soap12NsID))
				{
					result = null;
				}
				else
				{
					result = null;
				}
			}
			else if (type.Namespace == this.schemaNonXsdTypesNsID)
			{
				if (type.Name == this.charID)
				{
					result = null;
				}
				else if (type.Name == this.guidID)
				{
					result = null;
				}
				else if (type.Name == this.timeSpanID && LocalAppContextSwitches.EnableTimeSpanSerialization)
				{
					result = null;
				}
				else
				{
					result = null;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		/// <summary>
		///         Определяет, указывает ли имя атрибута XML пространство имен XML.
		///       </summary>
		/// <param name="name">
		///           Имя атрибута XML.
		///         </param>
		/// <returns>
		///         <see langword="true " />Если имя атрибута XML указывает пространство имен XML; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001D9E RID: 7582 RVA: 0x000AF485 File Offset: 0x000AD685
		protected bool IsXmlnsAttribute(string name)
		{
			return name.StartsWith("xmlns", StringComparison.Ordinal) && (name.Length == 5 || name[5] == ':');
		}

		/// <summary>
		///         Устанавливает значение атрибута XML, если оно имеет тип <see langword="arrayType" /> из пространства имен языка описания веб-служб (WSDL).
		///       </summary>
		/// <param name="attr">
		///           <see cref="T:System.Xml.XmlAttribute" /> Может иметь тип <see langword="wsdl:array" />.
		///         </param>
		// Token: 0x06001D9F RID: 7583 RVA: 0x000AF4B0 File Offset: 0x000AD6B0
		protected void ParseWsdlArrayType(XmlAttribute attr)
		{
			if (attr.LocalName == this.wsdlArrayTypeID && attr.NamespaceURI == this.wsdlNsID)
			{
				int num = attr.Value.LastIndexOf(':');
				if (num < 0)
				{
					attr.Value = this.r.LookupNamespace("") + ":" + attr.Value;
					return;
				}
				attr.Value = this.r.LookupNamespace(attr.Value.Substring(0, num)) + ":" + attr.Value.Substring(num + 1);
			}
		}

		/// <summary>
		///         Возвращает или задает значение, которое должно быть <see langword="true" /> для SOAP 1.1 возвращаемое значение.
		///       </summary>
		/// <returns>
		///         <see langword="true" />, если значение является возвращаемым значением.
		///       </returns>
		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x000AF548 File Offset: 0x000AD748
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x000AF55D File Offset: 0x000AD75D
		protected bool IsReturnValue
		{
			get
			{
				return this.isReturnValue && !this.soap12;
			}
			set
			{
				this.isReturnValue = value;
			}
		}

		/// <summary>
		///         Указывает, что <see cref="T:System.Xml.XmlReader" /> для чтения текущего элемента XML, если элемент имеет атрибут null с значение true.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если элемент имеет null = «true» значение атрибута и чтения; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001DA2 RID: 7586 RVA: 0x000AF568 File Offset: 0x000AD768
		protected bool ReadNull()
		{
			if (!this.GetNullAttr())
			{
				return false;
			}
			if (this.r.IsEmptyElement)
			{
				this.r.Skip();
				return true;
			}
			this.r.ReadStartElement();
			int num = 0;
			int readerCount = this.ReaderCount;
			while (this.r.NodeType != XmlNodeType.EndElement)
			{
				this.UnknownNode(null);
				this.CheckReaderCount(ref num, ref readerCount);
			}
			this.ReadEndElement();
			return true;
		}

		/// <summary>
		///         Определяет ли XML-элемента где <see cref="T:System.Xml.XmlReader" /> располагается имеет атрибут null присвоено значение <see langword="true" />.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если <see cref="T:System.Xml.XmlReader" /> расположено в настоящее время атрибут null со значением <see langword="true" />; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001DA3 RID: 7587 RVA: 0x000AF5D8 File Offset: 0x000AD7D8
		protected bool GetNullAttr()
		{
			string attribute = this.r.GetAttribute(this.nilID, this.instanceNsID);
			if (attribute == null)
			{
				attribute = this.r.GetAttribute(this.nullID, this.instanceNsID);
			}
			if (attribute == null)
			{
				attribute = this.r.GetAttribute(this.nullID, this.instanceNs2000ID);
				if (attribute == null)
				{
					attribute = this.r.GetAttribute(this.nullID, this.instanceNs1999ID);
				}
			}
			return attribute != null && XmlConvert.ToBoolean(attribute);
		}

		/// <summary>
		///         Указывает, что <see cref="T:System.Xml.XmlReader" /> для чтения простых, предназначенный только для чтения XML-элемента, которые могут быть <see langword="null" />.
		///       </summary>
		/// <returns>
		///         Строковое значение; в противном случае — <see langword="null" />.
		///       </returns>
		// Token: 0x06001DA4 RID: 7588 RVA: 0x000AF65C File Offset: 0x000AD85C
		protected string ReadNullableString()
		{
			if (this.ReadNull())
			{
				return null;
			}
			return this.r.ReadElementString();
		}

		/// <summary>
		///         Указывает, что <see cref="T:System.Xml.XmlReader" /> для чтения полное имя элемента, в которой он расположен.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XmlQualifiedName" /> представляющий полное имя элемента XML, в противном случае — <see langword="null" /> Если null = «true» присутствует значение атрибута.
		///       </returns>
		// Token: 0x06001DA5 RID: 7589 RVA: 0x000AF673 File Offset: 0x000AD873
		protected XmlQualifiedName ReadNullableQualifiedName()
		{
			if (this.ReadNull())
			{
				return null;
			}
			return this.ReadElementQualifiedName();
		}

		/// <summary>
		///         Делает <see cref="T:System.Xml.XmlReader" /> чтения полное имя элемента, в которой он расположен.
		///       </summary>
		/// <returns>
		///         Полное имя текущего элемента XML.
		///       </returns>
		// Token: 0x06001DA6 RID: 7590 RVA: 0x000AF688 File Offset: 0x000AD888
		protected XmlQualifiedName ReadElementQualifiedName()
		{
			if (this.r.IsEmptyElement)
			{
				XmlQualifiedName result = new XmlQualifiedName(string.Empty, this.r.LookupNamespace(""));
				this.r.Skip();
				return result;
			}
			XmlQualifiedName result2 = this.ToXmlQualifiedName(this.CollapseWhitespace(this.r.ReadString()));
			this.r.ReadEndElement();
			return result2;
		}

		/// <summary>
		///         Указывает, что <see cref="T:System.Xml.XmlReader" /> для чтения корневым элементом документа XML в текущей позиции.
		///       </summary>
		/// <param name="wrapped">
		///           <see langword="true" /> Если метод должен считать контент только после считывания стартового элемента; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlDocument" /> Содержащий корневой элемент, которое было прочитано.
		///       </returns>
		// Token: 0x06001DA7 RID: 7591 RVA: 0x000AF6EC File Offset: 0x000AD8EC
		protected XmlDocument ReadXmlDocument(bool wrapped)
		{
			XmlNode xmlNode = this.ReadXmlNode(wrapped);
			if (xmlNode == null)
			{
				return null;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.AppendChild(xmlDocument.ImportNode(xmlNode, true));
			return xmlDocument;
		}

		/// <summary>
		///         Удаляет все вхождения пробелы в начале и конце заданной строки.
		///       </summary>
		/// <param name="value">
		///           Строка, которая будет его пробелы усекаются.
		///         </param>
		/// <returns>
		///         Обрезанная строка.
		///       </returns>
		// Token: 0x06001DA8 RID: 7592 RVA: 0x000AF71A File Offset: 0x000AD91A
		protected string CollapseWhitespace(string value)
		{
			if (value == null)
			{
				return null;
			}
			return value.Trim();
		}

		/// <summary>
		///         Указывает, что <see cref="T:System.Xml.XmlReader" /> для чтения узел XML в текущей позиции.
		///       </summary>
		/// <param name="wrapped">
		///           <see langword="true" /> для считывания содержимого только после считывания стартового элемента; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNode" /> Представляющий узел XML, которое было прочитано.
		///       </returns>
		// Token: 0x06001DA9 RID: 7593 RVA: 0x000AF728 File Offset: 0x000AD928
		protected XmlNode ReadXmlNode(bool wrapped)
		{
			XmlNode result = null;
			if (wrapped)
			{
				if (this.ReadNull())
				{
					return null;
				}
				this.r.ReadStartElement();
				this.r.MoveToContent();
				if (this.r.NodeType != XmlNodeType.EndElement)
				{
					result = this.Document.ReadNode(this.r);
				}
				int num = 0;
				int readerCount = this.ReaderCount;
				while (this.r.NodeType != XmlNodeType.EndElement)
				{
					this.UnknownNode(null);
					this.CheckReaderCount(ref num, ref readerCount);
				}
				this.r.ReadEndElement();
			}
			else
			{
				result = this.Document.ReadNode(this.r);
			}
			return result;
		}

		/// <summary>
		///         Создает массив байтов base-64 из входной строки.
		///       </summary>
		/// <param name="value">
		///           Строка для преобразования в массив байтов в base-64.
		///         </param>
		/// <returns>
		///         Массив байтов base-64.
		///       </returns>
		// Token: 0x06001DAA RID: 7594 RVA: 0x000AF7C7 File Offset: 0x000AD9C7
		protected static byte[] ToByteArrayBase64(string value)
		{
			return XmlCustomFormatter.ToByteArrayBase64(value);
		}

		/// <summary>
		///         Указывает, что <see cref="T:System.Xml.XmlReader" /> для чтения значения строки в текущей позиции и возвратить его в виде массива байтов в base-64.
		///       </summary>
		/// <param name="isNull">
		///           <see langword="true" /> Чтобы вернуть <see langword="null" />; <see langword="false" /> для возвращения массива байтов в base-64.
		///         </param>
		/// <returns>
		///         Массив байтов base-64; в противном случае — <see langword="null" /> Если значение <paramref name="isNull" /> равно <see langword="true" />.
		///       </returns>
		// Token: 0x06001DAB RID: 7595 RVA: 0x000AF7CF File Offset: 0x000AD9CF
		protected byte[] ToByteArrayBase64(bool isNull)
		{
			if (isNull)
			{
				return null;
			}
			return this.ReadByteArray(true);
		}

		/// <summary>
		///         Создает шестнадцатеричный байтовый массив из входной строки.
		///       </summary>
		/// <param name="value">
		///           Строка для преобразования в шестнадцатеричный байтовый массив.
		///         </param>
		/// <returns>
		///         Шестнадцатеричный байтовый массив.
		///       </returns>
		// Token: 0x06001DAC RID: 7596 RVA: 0x000AF7DD File Offset: 0x000AD9DD
		protected static byte[] ToByteArrayHex(string value)
		{
			return XmlCustomFormatter.ToByteArrayHex(value);
		}

		/// <summary>
		///         Указывает, что <see cref="T:System.Xml.XmlReader" /> для чтения значения строки в текущей позиции и возвращения в качестве шестнадцатеричного байтового массива.
		///       </summary>
		/// <param name="isNull">
		///           <see langword="true" /> Чтобы вернуть <see langword="null" />; <see langword="false" /> для возврата шестнадцатеричного байтового массива.
		///         </param>
		/// <returns>
		///         Шестнадцатеричный байтовый массив; в противном случае — <see langword="null" /> Если значение <paramref name="isNull" /> равно true.
		///       </returns>
		// Token: 0x06001DAD RID: 7597 RVA: 0x000AF7E5 File Offset: 0x000AD9E5
		protected byte[] ToByteArrayHex(bool isNull)
		{
			if (isNull)
			{
				return null;
			}
			return this.ReadByteArray(false);
		}

		/// <summary>
		///         Возвращает длину массива с кодировкой SOAP которых <see cref="T:System.Xml.XmlReader" /> в текущий момент находится.
		///       </summary>
		/// <param name="name">
		///           Локальное имя, которое должен иметь массив.
		///         </param>
		/// <param name="ns">
		///           Пространство имен, которое должен иметь массив.
		///         </param>
		/// <returns>
		///         Длина массива SOAP.
		///       </returns>
		// Token: 0x06001DAE RID: 7598 RVA: 0x000AF7F4 File Offset: 0x000AD9F4
		protected int GetArrayLength(string name, string ns)
		{
			if (this.GetNullAttr())
			{
				return 0;
			}
			string attribute = this.r.GetAttribute(this.arrayTypeID, this.soapNsID);
			XmlSerializationReader.SoapArrayInfo soapArrayInfo = this.ParseArrayType(attribute);
			if (soapArrayInfo.dimensions != 1)
			{
				throw new InvalidOperationException(Res.GetString("SOAP-ENC:arrayType with multidimensional array found at {0}. Only single-dimensional arrays are supported. Consider using an array of arrays instead.", new object[]
				{
					this.CurrentTag()
				}));
			}
			XmlQualifiedName xmlQualifiedName = this.ToXmlQualifiedName(soapArrayInfo.qname, false);
			if (xmlQualifiedName.Name != name)
			{
				throw new InvalidOperationException(Res.GetString("The SOAP-ENC:arrayType references type is named '{0}'; a type named '{1}' was expected at {2}.", new object[]
				{
					xmlQualifiedName.Name,
					name,
					this.CurrentTag()
				}));
			}
			if (xmlQualifiedName.Namespace != ns)
			{
				throw new InvalidOperationException(Res.GetString("The SOAP-ENC:arrayType references type is from namespace '{0}'; the namespace '{1}' was expected at {2}.", new object[]
				{
					xmlQualifiedName.Namespace,
					ns,
					this.CurrentTag()
				}));
			}
			return soapArrayInfo.length;
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000AF8DC File Offset: 0x000ADADC
		private XmlSerializationReader.SoapArrayInfo ParseArrayType(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException(Res.GetString("SOAP-ENC:arrayType was missing at {0}.", new object[]
				{
					this.CurrentTag()
				}));
			}
			if (value.Length == 0)
			{
				throw new ArgumentException(Res.GetString("SOAP-ENC:arrayType was empty at {0}.", new object[]
				{
					this.CurrentTag()
				}), "value");
			}
			char[] array = value.ToCharArray();
			int num = array.Length;
			XmlSerializationReader.SoapArrayInfo result = default(XmlSerializationReader.SoapArrayInfo);
			int num2 = num - 1;
			if (array[num2] != ']')
			{
				throw new ArgumentException(Res.GetString("SOAP-ENC:arrayType must end with a ']' character."), "value");
			}
			num2--;
			while (num2 != -1 && array[num2] != '[')
			{
				if (array[num2] == ',')
				{
					throw new ArgumentException(Res.GetString("SOAP-ENC:arrayType with multidimensional array found at {0}. Only single-dimensional arrays are supported. Consider using an array of arrays instead.", new object[]
					{
						this.CurrentTag()
					}), "value");
				}
				num2--;
			}
			if (num2 == -1)
			{
				throw new ArgumentException(Res.GetString("SOAP-ENC:arrayType has mismatched brackets."), "value");
			}
			int num3 = num - num2 - 2;
			if (num3 > 0)
			{
				string text = new string(array, num2 + 1, num3);
				try
				{
					result.length = int.Parse(text, CultureInfo.InvariantCulture);
					goto IL_14F;
				}
				catch (Exception ex)
				{
					if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
					{
						throw;
					}
					throw new ArgumentException(Res.GetString("SOAP-ENC:arrayType could not handle '{1}' as the length of the array.", new object[]
					{
						text
					}), "value");
				}
			}
			result.length = -1;
			IL_14F:
			num2--;
			result.jaggedDimensions = 0;
			while (num2 != -1 && array[num2] == ']')
			{
				num2--;
				if (num2 < 0)
				{
					throw new ArgumentException(Res.GetString("SOAP-ENC:arrayType has mismatched brackets."), "value");
				}
				if (array[num2] == ',')
				{
					throw new ArgumentException(Res.GetString("SOAP-ENC:arrayType with multidimensional array found at {0}. Only single-dimensional arrays are supported. Consider using an array of arrays instead.", new object[]
					{
						this.CurrentTag()
					}), "value");
				}
				if (array[num2] != '[')
				{
					throw new ArgumentException(Res.GetString("SOAP-ENC:arrayType must end with a ']' character."), "value");
				}
				num2--;
				result.jaggedDimensions++;
			}
			result.dimensions = 1;
			result.qname = new string(array, 0, num2 + 1);
			return result;
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x000AFAF0 File Offset: 0x000ADCF0
		private XmlSerializationReader.SoapArrayInfo ParseSoap12ArrayType(string itemType, string arraySize)
		{
			XmlSerializationReader.SoapArrayInfo soapArrayInfo = default(XmlSerializationReader.SoapArrayInfo);
			if (itemType != null && itemType.Length > 0)
			{
				soapArrayInfo.qname = itemType;
			}
			else
			{
				soapArrayInfo.qname = "";
			}
			string[] array;
			if (arraySize != null && arraySize.Length > 0)
			{
				array = arraySize.Split(null);
			}
			else
			{
				array = new string[0];
			}
			soapArrayInfo.dimensions = 0;
			soapArrayInfo.length = -1;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Length > 0)
				{
					if (array[i] == "*")
					{
						soapArrayInfo.dimensions++;
					}
					else
					{
						try
						{
							soapArrayInfo.length = int.Parse(array[i], CultureInfo.InvariantCulture);
							soapArrayInfo.dimensions++;
						}
						catch (Exception ex)
						{
							if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
							{
								throw;
							}
							throw new ArgumentException(Res.GetString("SOAP-ENC:arrayType could not handle '{1}' as the length of the array.", new object[]
							{
								array[i]
							}), "value");
						}
					}
				}
			}
			if (soapArrayInfo.dimensions == 0)
			{
				soapArrayInfo.dimensions = 1;
			}
			return soapArrayInfo;
		}

		/// <summary>
		///         Создает <see cref="T:System.DateTime" /> объекта из входной строки.
		///       </summary>
		/// <param name="value">
		///           Строка для преобразования в <see cref="T:System.DateTime" /> объекта.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.DateTime" />.
		///       </returns>
		// Token: 0x06001DB1 RID: 7601 RVA: 0x000AFC10 File Offset: 0x000ADE10
		protected static DateTime ToDateTime(string value)
		{
			return XmlCustomFormatter.ToDateTime(value);
		}

		/// <summary>
		///         Создает <see cref="T:System.DateTime" /> объекта из входной строки.
		///       </summary>
		/// <param name="value">
		///           Строка для преобразования в <see cref="T:System.DateTime" /> объекта класса.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.DateTime" />объекта.
		///       </returns>
		// Token: 0x06001DB2 RID: 7602 RVA: 0x000AFC18 File Offset: 0x000ADE18
		protected static DateTime ToDate(string value)
		{
			return XmlCustomFormatter.ToDate(value);
		}

		/// <summary>
		///         Создает <see cref="T:System.DateTime" /> из строки, которая представляет время.
		///       </summary>
		/// <param name="value">
		///           Строка для преобразования в <see cref="T:System.DateTime" /> объекта.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.DateTime" />.
		///       </returns>
		// Token: 0x06001DB3 RID: 7603 RVA: 0x000AFC20 File Offset: 0x000ADE20
		protected static DateTime ToTime(string value)
		{
			return XmlCustomFormatter.ToTime(value);
		}

		/// <summary>
		///         Создает <see cref="T:System.Char" /> объекта из входной строки.
		///       </summary>
		/// <param name="value">
		///           Строка для преобразования в <see cref="T:System.Char" /> объекта.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Char" />.
		///       </returns>
		// Token: 0x06001DB4 RID: 7604 RVA: 0x000AFC28 File Offset: 0x000ADE28
		protected static char ToChar(string value)
		{
			return XmlCustomFormatter.ToChar(value);
		}

		/// <summary>
		///         Создает числовое значение перечисления в строку, состоящую из идентификаторов-разделителей, представляющих константы из списка перечислителя.
		///       </summary>
		/// <param name="value">
		///           Строка, состоящая из разделителей идентификаторов, где каждый представляет константу из установленного списка перечислителя.
		///         </param>
		/// <param name="h">
		///           Объект <see cref="T:System.Collections.Hashtable" /> состоящий из идентификаторов как ключи и константы как целые числа.
		///         </param>
		/// <param name="typeName">
		///           Имя типа перечисления.
		///         </param>
		/// <returns>
		///         Значение типа long, состоит из значения перечисления как ряд побитовое <see langword="OR" /> операций.
		///       </returns>
		// Token: 0x06001DB5 RID: 7605 RVA: 0x000AFC30 File Offset: 0x000ADE30
		protected static long ToEnum(string value, Hashtable h, string typeName)
		{
			return XmlCustomFormatter.ToEnum(value, h, typeName, true);
		}

		/// <summary>
		///         Декодирует имя XML.
		///       </summary>
		/// <param name="value">
		///           Имя XML для декодирования.
		///         </param>
		/// <returns>
		///         Декодированная строка.
		///       </returns>
		// Token: 0x06001DB6 RID: 7606 RVA: 0x000AFC3B File Offset: 0x000ADE3B
		protected static string ToXmlName(string value)
		{
			return XmlCustomFormatter.ToXmlName(value);
		}

		/// <summary>
		///         Декодирует имя XML.
		///       </summary>
		/// <param name="value">
		///           Имя XML для декодирования.
		///         </param>
		/// <returns>
		///         Декодированная строка.
		///       </returns>
		// Token: 0x06001DB7 RID: 7607 RVA: 0x000AFC43 File Offset: 0x000ADE43
		protected static string ToXmlNCName(string value)
		{
			return XmlCustomFormatter.ToXmlNCName(value);
		}

		/// <summary>
		///         Декодирует имя XML.
		///       </summary>
		/// <param name="value">
		///           Имя XML для декодирования.
		///         </param>
		/// <returns>
		///         Декодированная строка.
		///       </returns>
		// Token: 0x06001DB8 RID: 7608 RVA: 0x000AFC4B File Offset: 0x000ADE4B
		protected static string ToXmlNmToken(string value)
		{
			return XmlCustomFormatter.ToXmlNmToken(value);
		}

		/// <summary>
		///         Декодирует имя XML.
		///       </summary>
		/// <param name="value">
		///           Имя XML для декодирования.
		///         </param>
		/// <returns>
		///         Декодированная строка.
		///       </returns>
		// Token: 0x06001DB9 RID: 7609 RVA: 0x000AFC53 File Offset: 0x000ADE53
		protected static string ToXmlNmTokens(string value)
		{
			return XmlCustomFormatter.ToXmlNmTokens(value);
		}

		/// <summary>
		///         Получает <see cref="T:System.Xml.XmlQualifiedName" /> от имени, которое может содержать префикс.
		///       </summary>
		/// <param name="value">
		///           Имя, которое может содержать префикс.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlQualifiedName" /> Представляющий имя пространства имен XML.
		///       </returns>
		// Token: 0x06001DBA RID: 7610 RVA: 0x000AFC5B File Offset: 0x000ADE5B
		protected XmlQualifiedName ToXmlQualifiedName(string value)
		{
			return this.ToXmlQualifiedName(value, this.DecodeName);
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x000AFC6C File Offset: 0x000ADE6C
		internal XmlQualifiedName ToXmlQualifiedName(string value, bool decodeName)
		{
			int num = (value == null) ? -1 : value.LastIndexOf(':');
			string text = (num < 0) ? null : value.Substring(0, num);
			string text2 = value.Substring(num + 1);
			if (decodeName)
			{
				text = XmlConvert.DecodeName(text);
				text2 = XmlConvert.DecodeName(text2);
			}
			if (text == null || text.Length == 0)
			{
				return new XmlQualifiedName(this.r.NameTable.Add(value), this.r.LookupNamespace(string.Empty));
			}
			string text3 = this.r.LookupNamespace(text);
			if (text3 == null)
			{
				throw new InvalidOperationException(Res.GetString("Namespace prefix '{0}' is not defined.", new object[]
				{
					text
				}));
			}
			return new XmlQualifiedName(this.r.NameTable.Add(text2), text3);
		}

		/// <summary>
		///         Вызывает <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownAttribute" /> событий для определения текущего положения <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="o">
		///           Объект, <see cref="T:System.Xml.Serialization.XmlSerializer" /> пытается десериализовать, впоследствии доступны через <see cref="P:System.Xml.Serialization.XmlAttributeEventArgs.ObjectBeingDeserialized" /> свойство.
		///         </param>
		/// <param name="attr">
		///           <see cref="T:System.Xml.XmlAttribute" /> Представляющий рассматриваемого атрибута.
		///         </param>
		// Token: 0x06001DBC RID: 7612 RVA: 0x000AFD26 File Offset: 0x000ADF26
		protected void UnknownAttribute(object o, XmlAttribute attr)
		{
			this.UnknownAttribute(o, attr, null);
		}

		/// <summary>
		///         Вызывает <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownAttribute" /> событий для определения текущего положения <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="o">
		///           Объект, <see cref="T:System.Xml.Serialization.XmlSerializer" /> пытается десериализовать, впоследствии доступны через <see cref="P:System.Xml.Serialization.XmlAttributeEventArgs.ObjectBeingDeserialized" /> свойство.
		///         </param>
		/// <param name="attr">
		///           Объект <see cref="T:System.Xml.XmlAttribute" /> представляющий рассматриваемого атрибута.
		///         </param>
		/// <param name="qnames">
		///           Список с разделителями запятыми XML полных имен.
		///         </param>
		// Token: 0x06001DBD RID: 7613 RVA: 0x000AFD34 File Offset: 0x000ADF34
		protected void UnknownAttribute(object o, XmlAttribute attr, string qnames)
		{
			if (this.events.OnUnknownAttribute != null)
			{
				int lineNumber;
				int linePosition;
				this.GetCurrentPosition(out lineNumber, out linePosition);
				XmlAttributeEventArgs e = new XmlAttributeEventArgs(attr, lineNumber, linePosition, o, qnames);
				this.events.OnUnknownAttribute(this.events.sender, e);
			}
		}

		/// <summary>
		///         Вызывает <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownElement" /> событий для определения текущего положения <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="o">
		///           <see cref="T:System.Object" /> Был десериализован.
		///         </param>
		/// <param name="elem">
		///           <see cref="T:System.Xml.XmlElement" /> Для которого возникает событие.
		///         </param>
		// Token: 0x06001DBE RID: 7614 RVA: 0x000AFD7F File Offset: 0x000ADF7F
		protected void UnknownElement(object o, XmlElement elem)
		{
			this.UnknownElement(o, elem, null);
		}

		/// <summary>
		///         Вызывает <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownElement" /> событий для определения текущего положения <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="o">
		///           Объект, <see cref="T:System.Xml.Serialization.XmlSerializer" /> пытается десериализовать, впоследствии доступны через <see cref="P:System.Xml.Serialization.XmlAttributeEventArgs.ObjectBeingDeserialized" /> свойство.
		///         </param>
		/// <param name="elem">
		///           <see cref="T:System.Xml.XmlElement" /> Для которого возникает событие.
		///         </param>
		/// <param name="qnames">
		///           Список с разделителями запятыми XML полных имен.
		///         </param>
		// Token: 0x06001DBF RID: 7615 RVA: 0x000AFD8C File Offset: 0x000ADF8C
		protected void UnknownElement(object o, XmlElement elem, string qnames)
		{
			if (this.events.OnUnknownElement != null)
			{
				int lineNumber;
				int linePosition;
				this.GetCurrentPosition(out lineNumber, out linePosition);
				XmlElementEventArgs e = new XmlElementEventArgs(elem, lineNumber, linePosition, o, qnames);
				this.events.OnUnknownElement(this.events.sender, e);
			}
		}

		/// <summary>
		///         Вызывает <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" /> событий для определения текущего положения <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="o">
		///           Объект, который был десериализован.
		///         </param>
		// Token: 0x06001DC0 RID: 7616 RVA: 0x000AFDD7 File Offset: 0x000ADFD7
		protected void UnknownNode(object o)
		{
			this.UnknownNode(o, null);
		}

		/// <summary>
		///         Вызывает <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" /> событий для определения текущего положения <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="o">
		///           Десериализуемый объект.
		///         </param>
		/// <param name="qnames">
		///           Список с разделителями запятыми XML полных имен.
		///         </param>
		// Token: 0x06001DC1 RID: 7617 RVA: 0x000AFDE4 File Offset: 0x000ADFE4
		protected void UnknownNode(object o, string qnames)
		{
			if (this.r.NodeType == XmlNodeType.None || this.r.NodeType == XmlNodeType.Whitespace)
			{
				this.r.Read();
				return;
			}
			if (this.r.NodeType == XmlNodeType.EndElement)
			{
				return;
			}
			if (this.events.OnUnknownNode != null)
			{
				this.UnknownNode(this.Document.ReadNode(this.r), o, qnames);
				return;
			}
			if (this.r.NodeType == XmlNodeType.Attribute && this.events.OnUnknownAttribute == null)
			{
				return;
			}
			if (this.r.NodeType == XmlNodeType.Element && this.events.OnUnknownElement == null)
			{
				this.r.Skip();
				return;
			}
			this.UnknownNode(this.Document.ReadNode(this.r), o, qnames);
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x000AFEB0 File Offset: 0x000AE0B0
		private void UnknownNode(XmlNode unknownNode, object o, string qnames)
		{
			if (unknownNode == null)
			{
				return;
			}
			if (unknownNode.NodeType != XmlNodeType.None && unknownNode.NodeType != XmlNodeType.Whitespace && this.events.OnUnknownNode != null)
			{
				int lineNumber;
				int linePosition;
				this.GetCurrentPosition(out lineNumber, out linePosition);
				XmlNodeEventArgs e = new XmlNodeEventArgs(unknownNode, lineNumber, linePosition, o);
				this.events.OnUnknownNode(this.events.sender, e);
			}
			if (unknownNode.NodeType == XmlNodeType.Attribute)
			{
				this.UnknownAttribute(o, (XmlAttribute)unknownNode, qnames);
				return;
			}
			if (unknownNode.NodeType == XmlNodeType.Element)
			{
				this.UnknownElement(o, (XmlElement)unknownNode, qnames);
			}
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x000AFF40 File Offset: 0x000AE140
		private void GetCurrentPosition(out int lineNumber, out int linePosition)
		{
			if (this.Reader is IXmlLineInfo)
			{
				IXmlLineInfo xmlLineInfo = (IXmlLineInfo)this.Reader;
				lineNumber = xmlLineInfo.LineNumber;
				linePosition = xmlLineInfo.LinePosition;
				return;
			}
			lineNumber = (linePosition = -1);
		}

		/// <summary>
		///         Вызывает <see cref="E:System.Xml.Serialization.XmlSerializer.UnreferencedObject" /> событий для определения текущего положения <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="id">
		///           Уникальную строку, которая используется для идентификации неиспользуемого объекта впоследствии доступны через <see cref="P:System.Xml.Serialization.UnreferencedObjectEventArgs.UnreferencedId" /> свойство.
		///         </param>
		/// <param name="o">
		///           Объект, <see cref="T:System.Xml.Serialization.XmlSerializer" /> пытается десериализовать, впоследствии доступны через <see cref="P:System.Xml.Serialization.UnreferencedObjectEventArgs.UnreferencedObject" /> свойство.
		///         </param>
		// Token: 0x06001DC4 RID: 7620 RVA: 0x000AFF80 File Offset: 0x000AE180
		protected void UnreferencedObject(string id, object o)
		{
			if (this.events.OnUnreferencedObject != null)
			{
				UnreferencedObjectEventArgs e = new UnreferencedObjectEventArgs(o, id);
				this.events.OnUnreferencedObject(this.events.sender, e);
			}
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x000AFFC0 File Offset: 0x000AE1C0
		private string CurrentTag()
		{
			XmlNodeType nodeType = this.r.NodeType;
			switch (nodeType)
			{
			case XmlNodeType.Element:
				return string.Concat(new string[]
				{
					"<",
					this.r.LocalName,
					" xmlns='",
					this.r.NamespaceURI,
					"'>"
				});
			case XmlNodeType.Attribute:
			case XmlNodeType.EntityReference:
			case XmlNodeType.Entity:
				break;
			case XmlNodeType.Text:
				return this.r.Value;
			case XmlNodeType.CDATA:
				return "CDATA";
			case XmlNodeType.ProcessingInstruction:
				return "<?";
			case XmlNodeType.Comment:
				return "<--";
			default:
				if (nodeType == XmlNodeType.EndElement)
				{
					return ">";
				}
				break;
			}
			return "(unknown)";
		}

		/// <summary>
		///         Создает <see cref="T:System.InvalidOperationException" /> указывающее, что тип неизвестен.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Xml.XmlQualifiedName" /> Представляющее имя неизвестного типа.
		///         </param>
		/// <returns>
		///         <see cref="T:System.InvalidOperationException" /> Исключение.
		///       </returns>
		// Token: 0x06001DC6 RID: 7622 RVA: 0x000B0071 File Offset: 0x000AE271
		protected Exception CreateUnknownTypeException(XmlQualifiedName type)
		{
			return new InvalidOperationException(Res.GetString("The specified type was not recognized: name='{0}', namespace='{1}', at {2}.", new object[]
			{
				type.Name,
				type.Namespace,
				this.CurrentTag()
			}));
		}

		/// <summary>
		///         Создает <see cref="T:System.InvalidOperationException" /> означает, что невозможно изменить тип коллекции с кодировкой SOAP, и его значения не может быть заполнено.
		///       </summary>
		/// <param name="name">
		///           Полное имя типа платформы .NET Framework, для которого существует сопоставление.
		///         </param>
		/// <returns>
		///         <see cref="T:System.InvalidOperationException" /> Исключение.
		///       </returns>
		// Token: 0x06001DC7 RID: 7623 RVA: 0x000B00A3 File Offset: 0x000AE2A3
		protected Exception CreateReadOnlyCollectionException(string name)
		{
			return new InvalidOperationException(Res.GetString("Could not deserialize {0}. Parameterless constructor is required for collections and enumerators.", new object[]
			{
				name
			}));
		}

		/// <summary>
		///         Создает <see cref="T:System.InvalidOperationException" /> указывающее, что десериализуемый объект должен быть абстрактным.
		///       </summary>
		/// <param name="name">
		///           Имя абстрактного типа.
		///         </param>
		/// <param name="ns">
		///           Пространство имен .NET Framework абстрактного типа.
		///         </param>
		/// <returns>
		///         <see cref="T:System.InvalidOperationException" /> Исключение.
		///       </returns>
		// Token: 0x06001DC8 RID: 7624 RVA: 0x000B00BE File Offset: 0x000AE2BE
		protected Exception CreateAbstractTypeException(string name, string ns)
		{
			return new InvalidOperationException(Res.GetString("The specified type is abstract: name='{0}', namespace='{1}', at {2}.", new object[]
			{
				name,
				ns,
				this.CurrentTag()
			}));
		}

		/// <summary>
		///         Создает <see cref="T:System.InvalidOperationException" /> указывающее, что десериализуемый объект нельзя, так как отсутствует конструктор.
		///       </summary>
		/// <param name="typeName">
		///           Имя типа.
		///         </param>
		/// <returns>
		///         <see cref="T:System.InvalidOperationException" /> Исключение.
		///       </returns>
		// Token: 0x06001DC9 RID: 7625 RVA: 0x000B00E6 File Offset: 0x000AE2E6
		protected Exception CreateInaccessibleConstructorException(string typeName)
		{
			return new InvalidOperationException(Res.GetString("{0} cannot be serialized because it does not have a parameterless constructor.", new object[]
			{
				typeName
			}));
		}

		/// <summary>
		///         Создает <see cref="T:System.InvalidOperationException" /> указывающее, что десериализуемый объект нельзя, так как конструктор вызывает исключение безопасности.
		///       </summary>
		/// <param name="typeName">
		///           Имя типа.
		///         </param>
		/// <returns>
		///         <see cref="T:System.InvalidOperationException" /> Исключение.
		///       </returns>
		// Token: 0x06001DCA RID: 7626 RVA: 0x000B0101 File Offset: 0x000AE301
		protected Exception CreateCtorHasSecurityException(string typeName)
		{
			return new InvalidOperationException(Res.GetString("The type '{0}' cannot be serialized because its parameterless constructor is decorated with declarative security permission attributes. Consider using imperative asserts or demands in the constructor.", new object[]
			{
				typeName
			}));
		}

		/// <summary>
		///         Создает <see cref="T:System.InvalidOperationException" /> указывает, что в текущей позиции <see cref="T:System.Xml.XmlReader" /> представляет неизвестный узел XML.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.InvalidOperationException" /> Исключение.
		///       </returns>
		// Token: 0x06001DCB RID: 7627 RVA: 0x000B011C File Offset: 0x000AE31C
		protected Exception CreateUnknownNodeException()
		{
			return new InvalidOperationException(Res.GetString("{0} was not expected.", new object[]
			{
				this.CurrentTag()
			}));
		}

		/// <summary>
		///         Создает <see cref="T:System.InvalidOperationException" /> указывающее, что значение перечисления не является допустимым.
		///       </summary>
		/// <param name="value">
		///           Значение перечисления, является недопустимым.
		///         </param>
		/// <param name="enumType">
		///           Тип перечисления.
		///         </param>
		/// <returns>
		///         <see cref="T:System.InvalidOperationException" /> Исключение.
		///       </returns>
		// Token: 0x06001DCC RID: 7628 RVA: 0x000B013C File Offset: 0x000AE33C
		protected Exception CreateUnknownConstantException(string value, Type enumType)
		{
			return new InvalidOperationException(Res.GetString("Instance validation error: '{0}' is not a valid value for {1}.", new object[]
			{
				value,
				enumType.Name
			}));
		}

		/// <summary>
		///         Создает <see cref="T:System.InvalidCastException" /> указывающее, что не удалось выполнить неявное преобразование.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Объект не может быть приведен к.
		///            Этот тип включается в сообщение об исключении.
		///         </param>
		/// <param name="value">
		///           Объект, который не может быть приведен.
		///            Этот объект включается в сообщение об исключении.
		///         </param>
		/// <returns>
		///         <see cref="T:System.InvalidCastException" /> Исключение.
		///       </returns>
		// Token: 0x06001DCD RID: 7629 RVA: 0x000B0160 File Offset: 0x000AE360
		protected Exception CreateInvalidCastException(Type type, object value)
		{
			return this.CreateInvalidCastException(type, value, null);
		}

		/// <summary>
		///         Создает <see cref="T:System.InvalidCastException" /> указывающее, что не удалось выполнить неявное преобразование.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Объект не может быть приведен к.
		///            Этот тип включается в сообщение об исключении.
		///         </param>
		/// <param name="value">
		///           Объект, который не может быть приведен.
		///            Этот объект включается в сообщение об исключении.
		///         </param>
		/// <param name="id">
		///           Идентификатор строки.
		///         </param>
		/// <returns>
		///         <see cref="T:System.InvalidCastException" /> Исключение.
		///       </returns>
		// Token: 0x06001DCE RID: 7630 RVA: 0x000B016C File Offset: 0x000AE36C
		protected Exception CreateInvalidCastException(Type type, object value, string id)
		{
			if (value == null)
			{
				return new InvalidCastException(Res.GetString("Cannot assign null value to an object of type {1}.", new object[]
				{
					type.FullName
				}));
			}
			if (id == null)
			{
				return new InvalidCastException(Res.GetString("Cannot assign object of type {0} to an object of type {1}.", new object[]
				{
					value.GetType().FullName,
					type.FullName
				}));
			}
			return new InvalidCastException(Res.GetString("Cannot assign object of type {0} to an object of type {1}. The error occurred while reading node with id='{2}'.", new object[]
			{
				value.GetType().FullName,
				type.FullName,
				id
			}));
		}

		/// <summary>
		///         Заполняет объект из его представления XML в текущем расположении <see cref="T:System.Xml.XmlReader" />, с возможностью чтения внутреннего элемента.
		///       </summary>
		/// <param name="xsdDerived">
		///           Локальное имя производного типа данных схемы XML.
		///         </param>
		/// <param name="nsDerived">
		///           Пространство имен производного типа данных схемы XML.
		///         </param>
		/// <param name="xsdBase">
		///           Локальное имя базового типа данных схемы XML.
		///         </param>
		/// <param name="nsBase">
		///           Пространство имен базового типа данных схемы XML.
		///         </param>
		/// <param name="clrDerived">
		///           Пространство имен производного типа платформы .NET Framework.
		///         </param>
		/// <param name="clrBase">
		///           Имя базового типа платформы .NET Framework.
		///         </param>
		/// <returns>
		///         <see cref="T:System.InvalidOperationException" /> Исключение.
		///       </returns>
		// Token: 0x06001DCF RID: 7631 RVA: 0x000B01FB File Offset: 0x000AE3FB
		protected Exception CreateBadDerivationException(string xsdDerived, string nsDerived, string xsdBase, string nsBase, string clrDerived, string clrBase)
		{
			return new InvalidOperationException(Res.GetString("Type '{0}' from namespace '{1}' declared as derivation of type '{2}' from namespace '{3}, but corresponding CLR types are not compatible.  Cannot convert type '{4}' to '{5}'.", new object[]
			{
				xsdDerived,
				nsDerived,
				xsdBase,
				nsBase,
				clrDerived,
				clrBase
			}));
		}

		/// <summary>
		///         Создает <see cref="T:System.InvalidOperationException" /> указывающее, что производный тип, который сопоставляется с типом данных схемы XML не найден.
		///       </summary>
		/// <param name="name">
		///           Локальное имя типа данных схемы XML, сопоставленного недоступен производному типу.
		///         </param>
		/// <param name="ns">
		///           Пространство имен типа данных схемы XML, сопоставленного недоступен производному типу.
		///         </param>
		/// <param name="clrType">
		///           Полное имя базового типа платформы .NET Framework, для которого производный тип не удается найти.
		///         </param>
		/// <returns>
		///         <see cref="T:System.InvalidOperationException" /> Исключение.
		///       </returns>
		// Token: 0x06001DD0 RID: 7632 RVA: 0x000B022D File Offset: 0x000AE42D
		protected Exception CreateMissingIXmlSerializableType(string name, string ns, string clrType)
		{
			return new InvalidOperationException(Res.GetString("Type '{0}' from namespace '{1}' does not have corresponding IXmlSerializable type. Please consider adding {2} to '{3}'.", new object[]
			{
				name,
				ns,
				typeof(XmlIncludeAttribute).Name,
				clrType
			}));
		}

		/// <summary>
		///         Обеспечивает достаточно велик, чтобы вместить указанного индекса заданного массива или копии.
		///       </summary>
		/// <param name="a">
		///           <see cref="T:System.Array" /> Который проверяется.
		///         </param>
		/// <param name="index">
		///           Требуемый индекс.
		///         </param>
		/// <param name="elementType">
		///           <see cref="T:System.Type" /> Элементов массива.
		///         </param>
		/// <returns>
		///         Существующий <see cref="T:System.Array" />, если он уже достаточно велик, в противном случае — новый, больший массив, который содержит элементы исходного массива.
		///       </returns>
		// Token: 0x06001DD1 RID: 7633 RVA: 0x000B0264 File Offset: 0x000AE464
		protected Array EnsureArrayIndex(Array a, int index, Type elementType)
		{
			if (a == null)
			{
				return Array.CreateInstance(elementType, 32);
			}
			if (index < a.Length)
			{
				return a;
			}
			Array array = Array.CreateInstance(elementType, a.Length * 2);
			Array.Copy(a, array, index);
			return array;
		}

		/// <summary>
		///         Гарантирует, что заданного массива или копии, не больше указанной длины.
		///       </summary>
		/// <param name="a">
		///           Массив, который проверяется.
		///         </param>
		/// <param name="length">
		///           Максимальная длина массива.
		///         </param>
		/// <param name="elementType">
		///           <see cref="T:System.Type" /> Элементов массива.
		///         </param>
		/// <param name="isNullable">
		///           <see langword="true" /> Если <see langword="null" /> для массива, при наличии для входного массива, может быть возвращен; в противном случае — новый меньший массив.
		///         </param>
		/// <returns>
		///         Существующий <see cref="T:System.Array" />, если уже достаточно небольшой; в противном случае — новый меньший массив, содержащий элементы исходного массива до размера<paramref name=" length" />.
		///       </returns>
		// Token: 0x06001DD2 RID: 7634 RVA: 0x000B02A0 File Offset: 0x000AE4A0
		protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable)
		{
			if (a == null)
			{
				if (isNullable)
				{
					return null;
				}
				return Array.CreateInstance(elementType, 0);
			}
			else
			{
				if (a.Length == length)
				{
					return a;
				}
				Array array = Array.CreateInstance(elementType, length);
				Array.Copy(a, array, length);
				return array;
			}
		}

		/// <summary>
		///         Результат вызова <see cref="M:System.Xml.XmlReader.ReadString" /> метод, добавляемый в конец входного значения.
		///       </summary>
		/// <param name="value">
		///           Строка для добавления префикса к результату вызова <see cref="M:System.Xml.XmlReader.ReadString" /> метод.
		///         </param>
		/// <returns>
		///         Результат вызова <see cref="M:System.Xml.XmlReader.ReadString" /> метод, добавляемый в конец входного значения.
		///       </returns>
		// Token: 0x06001DD3 RID: 7635 RVA: 0x000B02DA File Offset: 0x000AE4DA
		protected string ReadString(string value)
		{
			return this.ReadString(value, false);
		}

		/// <summary>
		///         Возвращает результат вызова <see cref="M:System.Xml.XmlReader.ReadString" /> метод <see cref="T:System.Xml.XmlReader" /> класса, обрезаются пробелы при необходимости и добавляется к входному значению.
		///       </summary>
		/// <param name="value">
		///           Строка, которая будет добавляться.
		///         </param>
		/// <param name="trim">
		///           <see langword="true" /> Если результат операции считывания должен быть сокращен; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Результат операции считывания, добавленный к входному значению.
		///       </returns>
		// Token: 0x06001DD4 RID: 7636 RVA: 0x000B02E4 File Offset: 0x000AE4E4
		protected string ReadString(string value, bool trim)
		{
			string text = this.r.ReadString();
			if (text != null && trim)
			{
				text = text.Trim();
			}
			if (value == null || value.Length == 0)
			{
				return text;
			}
			return value + text;
		}

		/// <summary>
		///         Заполняет объект из его представления XML в текущем расположении <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="serializable">
		///           <see cref="T:System.Xml.Serialization.IXmlSerializable" /> Соответствующий текущей позиции <see cref="T:System.Xml.XmlReader" />.
		///         </param>
		/// <returns>
		///         Объект, реализующий интерфейс <see cref="T:System.Xml.Serialization.IXmlSerializable" /> интерфейс его членов, заполняется из папки <see cref="T:System.Xml.XmlReader" />.
		///       </returns>
		// Token: 0x06001DD5 RID: 7637 RVA: 0x000B0320 File Offset: 0x000AE520
		protected IXmlSerializable ReadSerializable(IXmlSerializable serializable)
		{
			return this.ReadSerializable(serializable, false);
		}

		/// <summary>
		///         Этот метод поддерживает инфраструктуру .NET Framework и не предназначен для использования непосредственно из программного кода.
		///       </summary>
		/// <param name="serializable">
		///           Объект IXmlSerializable, соответствующий текущей позиции объекта XMLReader.
		///         </param>
		/// <param name="wrappedAny">
		///           Указывает, переносится ли сериализуемый объект.
		///         </param>
		/// <returns>
		///         Объект, реализующий интерфейс IXmlSerializable его членов, заполняется из расположения XmlReader.
		///       </returns>
		// Token: 0x06001DD6 RID: 7638 RVA: 0x000B032C File Offset: 0x000AE52C
		protected IXmlSerializable ReadSerializable(IXmlSerializable serializable, bool wrappedAny)
		{
			string b = null;
			string b2 = null;
			if (wrappedAny)
			{
				b = this.r.LocalName;
				b2 = this.r.NamespaceURI;
				this.r.Read();
				this.r.MoveToContent();
			}
			serializable.ReadXml(this.r);
			if (wrappedAny)
			{
				while (this.r.NodeType == XmlNodeType.Whitespace)
				{
					this.r.Skip();
				}
				if (this.r.NodeType == XmlNodeType.None)
				{
					this.r.Skip();
				}
				if (this.r.NodeType == XmlNodeType.EndElement && this.r.LocalName == b && this.r.NamespaceURI == b2)
				{
					this.Reader.Read();
				}
			}
			return serializable;
		}

		/// <summary>
		///         Считывает значение <see langword="href" /> атрибута (<see langword="ref" /> атрибут для SOAP 1.2), используемый для ссылки на элемент XML в кодировании SOAP.
		///       </summary>
		/// <param name="fixupReference">
		///           Выходная строка, в которую <see langword="href" /> чтения значения атрибута.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если значение было прочитано; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001DD7 RID: 7639 RVA: 0x000B03F8 File Offset: 0x000AE5F8
		protected bool ReadReference(out string fixupReference)
		{
			string text = this.soap12 ? this.r.GetAttribute("ref", "http://www.w3.org/2003/05/soap-encoding") : this.r.GetAttribute("href");
			if (text == null)
			{
				fixupReference = null;
				return false;
			}
			if (!this.soap12)
			{
				if (!text.StartsWith("#", StringComparison.Ordinal))
				{
					throw new InvalidOperationException(Res.GetString("The referenced element with ID '{0}' is located outside the current document and cannot be retrieved.", new object[]
					{
						text
					}));
				}
				fixupReference = text.Substring(1);
			}
			else
			{
				fixupReference = text;
			}
			if (this.r.IsEmptyElement)
			{
				this.r.Skip();
			}
			else
			{
				this.r.ReadStartElement();
				this.ReadEndElement();
			}
			return true;
		}

		/// <summary>
		///         Сохраняет объект, который был десериализован с кодировкой SOAP <see langword="multiRef" /> элемент для дальнейшего доступа через <see cref="M:System.Xml.Serialization.XmlSerializationReader.GetTarget(System.String)" /> метод.
		///       </summary>
		/// <param name="id">
		///           Значение <see langword="id" /> атрибут <see langword="multiRef" /> элемента, который идентифицирует элемент.
		///         </param>
		/// <param name="o">
		///           Объект, который будет десериализован из XML-элемента.
		///         </param>
		// Token: 0x06001DD8 RID: 7640 RVA: 0x000B04A8 File Offset: 0x000AE6A8
		protected void AddTarget(string id, object o)
		{
			if (id == null)
			{
				if (this.targetsWithoutIds == null)
				{
					this.targetsWithoutIds = new ArrayList();
				}
				if (o != null)
				{
					this.targetsWithoutIds.Add(o);
					return;
				}
			}
			else
			{
				if (this.targets == null)
				{
					this.targets = new Hashtable();
				}
				if (!this.targets.Contains(id))
				{
					this.targets.Add(id, o);
				}
			}
		}

		/// <summary>
		///         Сохраняет объект, содержащий экземпляр метода обратного вызова, который будет вызываться, при необходимости для заполнения объектов в массиве с кодировкой SOAP.
		///       </summary>
		/// <param name="fixup">
		///           <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> Делегат и метод обратного вызова входных данных.
		///         </param>
		// Token: 0x06001DD9 RID: 7641 RVA: 0x000B050A File Offset: 0x000AE70A
		protected void AddFixup(XmlSerializationReader.Fixup fixup)
		{
			if (this.fixups == null)
			{
				this.fixups = new ArrayList();
			}
			this.fixups.Add(fixup);
		}

		/// <summary>
		///         Сохраняет объект, содержащий метод обратного вызова, который будет вызываться, при необходимости, для заполнения коллекции .NET Framework или перечисления, которые соответствуют SOAP-кодированных массивов или SOAP-кодированным элементам с несколькими ссылками.
		///       </summary>
		/// <param name="fixup">
		///           A <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> делегат и метод обратного вызова входных данных.
		///         </param>
		// Token: 0x06001DDA RID: 7642 RVA: 0x000B052C File Offset: 0x000AE72C
		protected void AddFixup(XmlSerializationReader.CollectionFixup fixup)
		{
			if (this.collectionFixups == null)
			{
				this.collectionFixups = new ArrayList();
			}
			this.collectionFixups.Add(fixup);
		}

		/// <summary>
		///         Возвращает объект, который был десериализован с кодировкой SOAP <see langword="multiRef" /> элемент, который был сохранен ранее с помощью <see cref="M:System.Xml.Serialization.XmlSerializationReader.AddTarget(System.String,System.Object)" />.
		///       </summary>
		/// <param name="id">
		///           Значение <see langword="id" /> атрибут <see langword="multiRef" /> элемента, который идентифицирует элемент.
		///         </param>
		/// <returns>
		///         Объект, десериализуемый из SOAP-кодированного <see langword="multiRef" /> элемента.
		///       </returns>
		// Token: 0x06001DDB RID: 7643 RVA: 0x000B0550 File Offset: 0x000AE750
		protected object GetTarget(string id)
		{
			object obj = (this.targets != null) ? this.targets[id] : null;
			if (obj == null)
			{
				throw new InvalidOperationException(Res.GetString("The referenced element with ID '{0}' was not found in the document.", new object[]
				{
					id
				}));
			}
			this.Referenced(obj);
			return obj;
		}

		/// <summary>
		///         Сохраняет объект, десериализуемый из SOAP-кодированного <see langword="multiRef" /> элемента.
		///       </summary>
		/// <param name="o">
		///           Десериализуемый объект.
		///         </param>
		// Token: 0x06001DDC RID: 7644 RVA: 0x000B059A File Offset: 0x000AE79A
		protected void Referenced(object o)
		{
			if (o == null)
			{
				return;
			}
			if (this.referencedTargets == null)
			{
				this.referencedTargets = new Hashtable();
			}
			this.referencedTargets[o] = o;
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x000B05C0 File Offset: 0x000AE7C0
		private void HandleUnreferencedObjects()
		{
			if (this.targets != null)
			{
				foreach (object obj in this.targets)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					if (this.referencedTargets == null || !this.referencedTargets.Contains(dictionaryEntry.Value))
					{
						this.UnreferencedObject((string)dictionaryEntry.Key, dictionaryEntry.Value);
					}
				}
			}
			if (this.targetsWithoutIds != null)
			{
				foreach (object obj2 in this.targetsWithoutIds)
				{
					if (this.referencedTargets == null || !this.referencedTargets.Contains(obj2))
					{
						this.UnreferencedObject(null, obj2);
					}
				}
			}
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x000B06B4 File Offset: 0x000AE8B4
		private void DoFixups()
		{
			if (this.fixups == null)
			{
				return;
			}
			for (int i = 0; i < this.fixups.Count; i++)
			{
				XmlSerializationReader.Fixup fixup = (XmlSerializationReader.Fixup)this.fixups[i];
				fixup.Callback(fixup);
			}
			if (this.collectionFixups == null)
			{
				return;
			}
			for (int j = 0; j < this.collectionFixups.Count; j++)
			{
				XmlSerializationReader.CollectionFixup collectionFixup = (XmlSerializationReader.CollectionFixup)this.collectionFixups[j];
				collectionFixup.Callback(collectionFixup.Collection, collectionFixup.CollectionItems);
			}
		}

		/// <summary>
		///         Заполняет значения SOAP-кодированного массива, тип данных которого сопоставлен к ссылочному типу .NET Framework.
		///       </summary>
		/// <param name="fixup">
		///           Объект, содержащий массив, значения которого заполняются.
		///         </param>
		// Token: 0x06001DDF RID: 7647 RVA: 0x000B0748 File Offset: 0x000AE948
		protected void FixupArrayRefs(object fixup)
		{
			XmlSerializationReader.Fixup fixup2 = (XmlSerializationReader.Fixup)fixup;
			Array array = (Array)fixup2.Source;
			for (int i = 0; i < array.Length; i++)
			{
				string text = fixup2.Ids[i];
				if (text != null)
				{
					object target = this.GetTarget(text);
					try
					{
						array.SetValue(target, i);
					}
					catch (InvalidCastException)
					{
						throw new InvalidOperationException(Res.GetString("Invalid reference id='{0}'. Object of type {1} cannot be stored in an array of this type. Details: array index={2}.", new object[]
						{
							text,
							target.GetType().FullName,
							i.ToString(CultureInfo.InvariantCulture)
						}));
					}
				}
			}
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x000B07E4 File Offset: 0x000AE9E4
		private object ReadArray(string typeName, string typeNs)
		{
			Type type = null;
			XmlSerializationReader.SoapArrayInfo soapArrayInfo;
			if (this.soap12)
			{
				string attribute = this.r.GetAttribute(this.itemTypeID, this.soap12NsID);
				string attribute2 = this.r.GetAttribute(this.arraySizeID, this.soap12NsID);
				Type type2 = (Type)this.types[new XmlQualifiedName(typeName, typeNs)];
				if (attribute == null && attribute2 == null && (type2 == null || !type2.IsArray))
				{
					return null;
				}
				soapArrayInfo = this.ParseSoap12ArrayType(attribute, attribute2);
				if (type2 != null)
				{
					type = TypeScope.GetArrayElementType(type2, null);
				}
			}
			else
			{
				string attribute3 = this.r.GetAttribute(this.arrayTypeID, this.soapNsID);
				if (attribute3 == null)
				{
					return null;
				}
				soapArrayInfo = this.ParseArrayType(attribute3);
			}
			if (soapArrayInfo.dimensions != 1)
			{
				throw new InvalidOperationException(Res.GetString("SOAP-ENC:arrayType with multidimensional array found at {0}. Only single-dimensional arrays are supported. Consider using an array of arrays instead.", new object[]
				{
					this.CurrentTag()
				}));
			}
			Type type3 = null;
			XmlQualifiedName xmlQualifiedName = new XmlQualifiedName(this.urTypeID, this.schemaNsID);
			XmlQualifiedName xmlQualifiedName2;
			if (soapArrayInfo.qname.Length > 0)
			{
				xmlQualifiedName2 = this.ToXmlQualifiedName(soapArrayInfo.qname, false);
				type3 = (Type)this.types[xmlQualifiedName2];
			}
			else
			{
				xmlQualifiedName2 = xmlQualifiedName;
			}
			if (this.soap12 && type3 == typeof(object))
			{
				type3 = null;
			}
			bool flag;
			if (type3 == null)
			{
				if (!this.soap12)
				{
					type3 = this.GetPrimitiveType(xmlQualifiedName2, true);
					flag = true;
				}
				else
				{
					if (xmlQualifiedName2 != xmlQualifiedName)
					{
						type3 = this.GetPrimitiveType(xmlQualifiedName2, false);
					}
					if (type3 != null)
					{
						flag = true;
					}
					else if (type == null)
					{
						type3 = typeof(object);
						flag = false;
					}
					else
					{
						type3 = type;
						XmlQualifiedName xmlQualifiedName3 = (XmlQualifiedName)this.typesReverse[type3];
						if (xmlQualifiedName3 == null)
						{
							xmlQualifiedName3 = XmlSerializationWriter.GetPrimitiveTypeNameInternal(type3);
							flag = true;
						}
						else
						{
							flag = type3.IsPrimitive;
						}
						if (xmlQualifiedName3 != null)
						{
							xmlQualifiedName2 = xmlQualifiedName3;
						}
					}
				}
			}
			else
			{
				flag = type3.IsPrimitive;
			}
			if (!this.soap12 && soapArrayInfo.jaggedDimensions > 0)
			{
				for (int i = 0; i < soapArrayInfo.jaggedDimensions; i++)
				{
					type3 = type3.MakeArrayType();
				}
			}
			if (this.r.IsEmptyElement)
			{
				this.r.Skip();
				return Array.CreateInstance(type3, 0);
			}
			this.r.ReadStartElement();
			this.r.MoveToContent();
			int num = 0;
			Array array = null;
			if (type3.IsValueType)
			{
				if (!flag && !type3.IsEnum)
				{
					throw new NotSupportedException(Res.GetString("Cannot serialize {0}. Arrays of structs are not supported with encoded SOAP.", new object[]
					{
						type3.FullName
					}));
				}
				int num2 = 0;
				int readerCount = this.ReaderCount;
				while (this.r.NodeType != XmlNodeType.EndElement)
				{
					array = this.EnsureArrayIndex(array, num, type3);
					array.SetValue(this.ReadReferencedElement(xmlQualifiedName2.Name, xmlQualifiedName2.Namespace), num);
					num++;
					this.r.MoveToContent();
					this.CheckReaderCount(ref num2, ref readerCount);
				}
				array = this.ShrinkArray(array, num, type3, false);
			}
			else
			{
				string[] array2 = null;
				int num3 = 0;
				int num4 = 0;
				int readerCount2 = this.ReaderCount;
				while (this.r.NodeType != XmlNodeType.EndElement)
				{
					array = this.EnsureArrayIndex(array, num, type3);
					array2 = (string[])this.EnsureArrayIndex(array2, num3, typeof(string));
					string name;
					string ns;
					if (this.r.NamespaceURI.Length != 0)
					{
						name = this.r.LocalName;
						if (this.r.NamespaceURI == this.soapNsID)
						{
							ns = "http://www.w3.org/2001/XMLSchema";
						}
						else
						{
							ns = this.r.NamespaceURI;
						}
					}
					else
					{
						name = xmlQualifiedName2.Name;
						ns = xmlQualifiedName2.Namespace;
					}
					array.SetValue(this.ReadReferencingElement(name, ns, out array2[num3]), num);
					num++;
					num3++;
					this.r.MoveToContent();
					this.CheckReaderCount(ref num4, ref readerCount2);
				}
				if (this.soap12 && type3 == typeof(object))
				{
					Type type4 = null;
					for (int j = 0; j < num; j++)
					{
						object value = array.GetValue(j);
						if (value != null)
						{
							Type type5 = value.GetType();
							if (type5.IsValueType)
							{
								type4 = null;
								break;
							}
							if (type4 == null || type5.IsAssignableFrom(type4))
							{
								type4 = type5;
							}
							else if (!type4.IsAssignableFrom(type5))
							{
								type4 = null;
								break;
							}
						}
					}
					if (type4 != null)
					{
						type3 = type4;
					}
				}
				array2 = (string[])this.ShrinkArray(array2, num3, typeof(string), false);
				array = this.ShrinkArray(array, num, type3, false);
				XmlSerializationReader.Fixup fixup = new XmlSerializationReader.Fixup(array, new XmlSerializationFixupCallback(this.FixupArrayRefs), array2);
				this.AddFixup(fixup);
			}
			this.ReadEndElement();
			return array;
		}

		/// <summary>
		///         Инициализирует методы обратного вызова, заполняющие объекты, соответствующие данным XML с кодировкой SOAP.
		///       </summary>
		// Token: 0x06001DE1 RID: 7649
		protected abstract void InitCallbacks();

		/// <summary>
		///         Десериализует объекты с кодировкой SOAP <see langword="multiRef" /> элементы в сообщении SOAP.
		///       </summary>
		// Token: 0x06001DE2 RID: 7650 RVA: 0x000B0CD4 File Offset: 0x000AEED4
		protected void ReadReferencedElements()
		{
			this.r.MoveToContent();
			int num = 0;
			int readerCount = this.ReaderCount;
			while (this.r.NodeType != XmlNodeType.EndElement && this.r.NodeType != XmlNodeType.None)
			{
				string text;
				this.ReadReferencingElement(null, null, true, out text);
				this.r.MoveToContent();
				this.CheckReaderCount(ref num, ref readerCount);
			}
			this.DoFixups();
			this.HandleUnreferencedObjects();
		}

		/// <summary>
		///         Десериализует объект из SOAP-кодированного <see langword="multiRef" /> XML-элемента.
		///       </summary>
		/// <returns>
		///         Значение ссылочного элемента в документе.
		///       </returns>
		// Token: 0x06001DE3 RID: 7651 RVA: 0x000B0D42 File Offset: 0x000AEF42
		protected object ReadReferencedElement()
		{
			return this.ReadReferencedElement(null, null);
		}

		/// <summary>
		///         Десериализует объект из SOAP-кодированного <see langword="multiRef" /> XML-элемента.
		///       </summary>
		/// <param name="name">
		///           Локальное имя типа данных схемы XML элемента.
		///         </param>
		/// <param name="ns">
		///           Пространство имен типа данных схемы XML элемента.
		///         </param>
		/// <returns>
		///         Значение ссылочного элемента в документе.
		///       </returns>
		// Token: 0x06001DE4 RID: 7652 RVA: 0x000B0D4C File Offset: 0x000AEF4C
		protected object ReadReferencedElement(string name, string ns)
		{
			string text;
			return this.ReadReferencingElement(name, ns, out text);
		}

		/// <summary>
		///         Десериализует объект из элемента XML в сообщении SOAP, содержащий ссылку на <see langword="multiRef" /> элемент.
		///       </summary>
		/// <param name="fixupReference">
		///           Выходная строка, в которую <see langword="href" /> чтения значения атрибута.
		///         </param>
		/// <returns>
		///         Десериализованный объект.
		///       </returns>
		// Token: 0x06001DE5 RID: 7653 RVA: 0x000B0D63 File Offset: 0x000AEF63
		protected object ReadReferencingElement(out string fixupReference)
		{
			return this.ReadReferencingElement(null, null, out fixupReference);
		}

		/// <summary>
		///         Десериализует объект из элемента XML в сообщении SOAP, содержащий ссылку на <see langword="multiRef" /> элемент.
		///       </summary>
		/// <param name="name">
		///           Локальное имя типа данных схемы XML элемента.
		///         </param>
		/// <param name="ns">
		///           Пространство имен типа данных схемы XML элемента.
		///         </param>
		/// <param name="fixupReference">
		///           Выходная строка, в которую <see langword="href" /> чтения значения атрибута.
		///         </param>
		/// <returns>
		///         Десериализованный объект.
		///       </returns>
		// Token: 0x06001DE6 RID: 7654 RVA: 0x000B0D6E File Offset: 0x000AEF6E
		protected object ReadReferencingElement(string name, string ns, out string fixupReference)
		{
			return this.ReadReferencingElement(name, ns, false, out fixupReference);
		}

		/// <summary>
		///         Десериализует объект из элемента XML в сообщении SOAP, содержащий ссылку на <see langword="multiRef" /> элемент.
		///       </summary>
		/// <param name="name">
		///           Локальное имя типа данных схемы XML элемента.
		///         </param>
		/// <param name="ns">
		///           Пространство имен типа данных схемы XML элемента.
		///         </param>
		/// <param name="elementCanBeType">
		///           <see langword="true" /> Если имя элемента также является имя типа данных схемы XML; в противном случае — <see langword="false" />.
		///         </param>
		/// <param name="fixupReference">
		///           Выходная строка, в которой значение <see langword="href" /> чтения атрибута.
		///         </param>
		/// <returns>
		///         Десериализованный объект.
		///       </returns>
		// Token: 0x06001DE7 RID: 7655 RVA: 0x000B0D7C File Offset: 0x000AEF7C
		protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference)
		{
			if (this.callbacks == null)
			{
				this.callbacks = new Hashtable();
				this.types = new Hashtable();
				XmlQualifiedName xmlQualifiedName = new XmlQualifiedName(this.urTypeID, this.r.NameTable.Add("http://www.w3.org/2001/XMLSchema"));
				this.types.Add(xmlQualifiedName, typeof(object));
				this.typesReverse = new Hashtable();
				this.typesReverse.Add(typeof(object), xmlQualifiedName);
				this.InitCallbacks();
			}
			this.r.MoveToContent();
			if (this.ReadReference(out fixupReference))
			{
				return null;
			}
			if (this.ReadNull())
			{
				return null;
			}
			string id = this.soap12 ? this.r.GetAttribute("id", "http://www.w3.org/2003/05/soap-encoding") : this.r.GetAttribute("id", null);
			object obj;
			if ((obj = this.ReadArray(name, ns)) == null)
			{
				XmlQualifiedName xmlQualifiedName2 = this.GetXsiType();
				if (xmlQualifiedName2 == null)
				{
					if (name == null)
					{
						xmlQualifiedName2 = new XmlQualifiedName(this.r.NameTable.Add(this.r.LocalName), this.r.NameTable.Add(this.r.NamespaceURI));
					}
					else
					{
						xmlQualifiedName2 = new XmlQualifiedName(this.r.NameTable.Add(name), this.r.NameTable.Add(ns));
					}
				}
				XmlSerializationReadCallback xmlSerializationReadCallback = (XmlSerializationReadCallback)this.callbacks[xmlQualifiedName2];
				if (xmlSerializationReadCallback != null)
				{
					obj = xmlSerializationReadCallback();
				}
				else
				{
					obj = this.ReadTypedPrimitive(xmlQualifiedName2, elementCanBeType);
				}
			}
			this.AddTarget(id, obj);
			return obj;
		}

		/// <summary>
		///         Хранит реализация <see cref="T:System.Xml.Serialization.XmlSerializationReadCallback" /> делегат и ее входными данными для последующего вызова.
		///       </summary>
		/// <param name="name">
		///           Имя типа .NET Framework, который был десериализован.
		///         </param>
		/// <param name="ns">
		///           Пространство имен типа платформы .NET Framework, который был десериализован.
		///         </param>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Для десериализации.
		///         </param>
		/// <param name="read">
		///           Делегат действия <see cref="T:System.Xml.Serialization.XmlSerializationReadCallback" />.
		///         </param>
		// Token: 0x06001DE8 RID: 7656 RVA: 0x000B0F18 File Offset: 0x000AF118
		protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read)
		{
			XmlQualifiedName xmlQualifiedName = new XmlQualifiedName(this.r.NameTable.Add(name), this.r.NameTable.Add(ns));
			this.callbacks[xmlQualifiedName] = read;
			this.types[xmlQualifiedName] = type;
			this.typesReverse[type] = xmlQualifiedName;
		}

		/// <summary>
		///         Делает <see cref="T:System.Xml.XmlReader" /> чтения закрывающий тег XML.
		///       </summary>
		// Token: 0x06001DE9 RID: 7657 RVA: 0x000B0F78 File Offset: 0x000AF178
		protected void ReadEndElement()
		{
			while (this.r.NodeType == XmlNodeType.Whitespace)
			{
				this.r.Skip();
			}
			if (this.r.NodeType == XmlNodeType.None)
			{
				this.r.Skip();
				return;
			}
			this.r.ReadEndElement();
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x000B0FC8 File Offset: 0x000AF1C8
		private object ReadXmlNodes(bool elementCanBeType)
		{
			ArrayList arrayList = new ArrayList();
			string localName = this.Reader.LocalName;
			string namespaceURI = this.Reader.NamespaceURI;
			string name = this.Reader.Name;
			string text = null;
			string text2 = null;
			int num = 0;
			int num2 = -1;
			int num3 = -1;
			XmlNode xmlNode;
			if (this.Reader.NodeType == XmlNodeType.Attribute)
			{
				XmlAttribute xmlAttribute = this.Document.CreateAttribute(name, namespaceURI);
				xmlAttribute.Value = this.Reader.Value;
				xmlNode = xmlAttribute;
			}
			else
			{
				xmlNode = this.Document.CreateElement(name, namespaceURI);
			}
			this.GetCurrentPosition(out num2, out num3);
			XmlElement xmlElement = xmlNode as XmlElement;
			while (this.Reader.MoveToNextAttribute())
			{
				if (this.IsXmlnsAttribute(this.Reader.Name) || (this.Reader.Name == "id" && (!this.soap12 || this.Reader.NamespaceURI == "http://www.w3.org/2003/05/soap-encoding")))
				{
					num++;
				}
				if (this.Reader.LocalName == this.typeID && (this.Reader.NamespaceURI == this.instanceNsID || this.Reader.NamespaceURI == this.instanceNs2000ID || this.Reader.NamespaceURI == this.instanceNs1999ID))
				{
					string value = this.Reader.Value;
					int num4 = value.LastIndexOf(':');
					text = ((num4 >= 0) ? value.Substring(num4 + 1) : value);
					text2 = this.Reader.LookupNamespace((num4 >= 0) ? value.Substring(0, num4) : "");
				}
				XmlAttribute xmlAttribute2 = (XmlAttribute)this.Document.ReadNode(this.r);
				arrayList.Add(xmlAttribute2);
				if (xmlElement != null)
				{
					xmlElement.SetAttributeNode(xmlAttribute2);
				}
			}
			if (elementCanBeType && text == null)
			{
				text = localName;
				text2 = namespaceURI;
				XmlAttribute xmlAttribute3 = this.Document.CreateAttribute(this.typeID, this.instanceNsID);
				xmlAttribute3.Value = name;
				arrayList.Add(xmlAttribute3);
			}
			if (text == "anyType" && (text2 == this.schemaNsID || text2 == this.schemaNs1999ID || text2 == this.schemaNs2000ID))
			{
				num++;
			}
			this.Reader.MoveToElement();
			if (this.Reader.IsEmptyElement)
			{
				this.Reader.Skip();
			}
			else
			{
				this.Reader.ReadStartElement();
				this.Reader.MoveToContent();
				int num5 = 0;
				int readerCount = this.ReaderCount;
				while (this.Reader.NodeType != XmlNodeType.EndElement)
				{
					XmlNode xmlNode2 = this.Document.ReadNode(this.r);
					arrayList.Add(xmlNode2);
					if (xmlElement != null)
					{
						xmlElement.AppendChild(xmlNode2);
					}
					this.Reader.MoveToContent();
					this.CheckReaderCount(ref num5, ref readerCount);
				}
				this.ReadEndElement();
			}
			if (arrayList.Count <= num)
			{
				return new object();
			}
			object result = (XmlNode[])arrayList.ToArray(typeof(XmlNode));
			this.UnknownNode(xmlNode, null, null);
			return result;
		}

		/// <summary>
		///         Проверяет, является ли десериализатор.
		///       </summary>
		/// <param name="whileIterations">
		///           Текущий <see langword="count" /> время от времени цикла.
		///         </param>
		/// <param name="readerCount">
		///           Текущий контекст <see cref="P:System.Xml.Serialization.XmlSerializationReader.ReaderCount" />.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="P:System.Xml.Serialization.XmlSerializationReader.ReaderCount" /> Не обладает расширенными.
		///           </exception>
		// Token: 0x06001DEB RID: 7659 RVA: 0x000B12CD File Offset: 0x000AF4CD
		protected void CheckReaderCount(ref int whileIterations, ref int readerCount)
		{
			if (XmlSerializationReader.checkDeserializeAdvances)
			{
				whileIterations++;
				if ((whileIterations & 128) == 128)
				{
					if (readerCount == this.ReaderCount)
					{
						throw new InvalidOperationException(Res.GetString("Internal error: deserialization failed to advance over underlying stream."));
					}
					readerCount = this.ReaderCount;
				}
			}
		}

		// Token: 0x04001A66 RID: 6758
		private XmlReader r;

		// Token: 0x04001A67 RID: 6759
		private XmlCountingReader countingReader;

		// Token: 0x04001A68 RID: 6760
		private XmlDocument d;

		// Token: 0x04001A69 RID: 6761
		private Hashtable callbacks;

		// Token: 0x04001A6A RID: 6762
		private Hashtable types;

		// Token: 0x04001A6B RID: 6763
		private Hashtable typesReverse;

		// Token: 0x04001A6C RID: 6764
		private XmlDeserializationEvents events;

		// Token: 0x04001A6D RID: 6765
		private Hashtable targets;

		// Token: 0x04001A6E RID: 6766
		private Hashtable referencedTargets;

		// Token: 0x04001A6F RID: 6767
		private ArrayList targetsWithoutIds;

		// Token: 0x04001A70 RID: 6768
		private ArrayList fixups;

		// Token: 0x04001A71 RID: 6769
		private ArrayList collectionFixups;

		// Token: 0x04001A72 RID: 6770
		private bool soap12;

		// Token: 0x04001A73 RID: 6771
		private bool isReturnValue;

		// Token: 0x04001A74 RID: 6772
		private bool decodeName = true;

		// Token: 0x04001A75 RID: 6773
		private string schemaNsID;

		// Token: 0x04001A76 RID: 6774
		private string schemaNs1999ID;

		// Token: 0x04001A77 RID: 6775
		private string schemaNs2000ID;

		// Token: 0x04001A78 RID: 6776
		private string schemaNonXsdTypesNsID;

		// Token: 0x04001A79 RID: 6777
		private string instanceNsID;

		// Token: 0x04001A7A RID: 6778
		private string instanceNs2000ID;

		// Token: 0x04001A7B RID: 6779
		private string instanceNs1999ID;

		// Token: 0x04001A7C RID: 6780
		private string soapNsID;

		// Token: 0x04001A7D RID: 6781
		private string soap12NsID;

		// Token: 0x04001A7E RID: 6782
		private string schemaID;

		// Token: 0x04001A7F RID: 6783
		private string wsdlNsID;

		// Token: 0x04001A80 RID: 6784
		private string wsdlArrayTypeID;

		// Token: 0x04001A81 RID: 6785
		private string nullID;

		// Token: 0x04001A82 RID: 6786
		private string nilID;

		// Token: 0x04001A83 RID: 6787
		private string typeID;

		// Token: 0x04001A84 RID: 6788
		private string arrayTypeID;

		// Token: 0x04001A85 RID: 6789
		private string itemTypeID;

		// Token: 0x04001A86 RID: 6790
		private string arraySizeID;

		// Token: 0x04001A87 RID: 6791
		private string arrayID;

		// Token: 0x04001A88 RID: 6792
		private string urTypeID;

		// Token: 0x04001A89 RID: 6793
		private string stringID;

		// Token: 0x04001A8A RID: 6794
		private string intID;

		// Token: 0x04001A8B RID: 6795
		private string booleanID;

		// Token: 0x04001A8C RID: 6796
		private string shortID;

		// Token: 0x04001A8D RID: 6797
		private string longID;

		// Token: 0x04001A8E RID: 6798
		private string floatID;

		// Token: 0x04001A8F RID: 6799
		private string doubleID;

		// Token: 0x04001A90 RID: 6800
		private string decimalID;

		// Token: 0x04001A91 RID: 6801
		private string dateTimeID;

		// Token: 0x04001A92 RID: 6802
		private string qnameID;

		// Token: 0x04001A93 RID: 6803
		private string dateID;

		// Token: 0x04001A94 RID: 6804
		private string timeID;

		// Token: 0x04001A95 RID: 6805
		private string hexBinaryID;

		// Token: 0x04001A96 RID: 6806
		private string base64BinaryID;

		// Token: 0x04001A97 RID: 6807
		private string base64ID;

		// Token: 0x04001A98 RID: 6808
		private string unsignedByteID;

		// Token: 0x04001A99 RID: 6809
		private string byteID;

		// Token: 0x04001A9A RID: 6810
		private string unsignedShortID;

		// Token: 0x04001A9B RID: 6811
		private string unsignedIntID;

		// Token: 0x04001A9C RID: 6812
		private string unsignedLongID;

		// Token: 0x04001A9D RID: 6813
		private string oldDecimalID;

		// Token: 0x04001A9E RID: 6814
		private string oldTimeInstantID;

		// Token: 0x04001A9F RID: 6815
		private string anyURIID;

		// Token: 0x04001AA0 RID: 6816
		private string durationID;

		// Token: 0x04001AA1 RID: 6817
		private string ENTITYID;

		// Token: 0x04001AA2 RID: 6818
		private string ENTITIESID;

		// Token: 0x04001AA3 RID: 6819
		private string gDayID;

		// Token: 0x04001AA4 RID: 6820
		private string gMonthID;

		// Token: 0x04001AA5 RID: 6821
		private string gMonthDayID;

		// Token: 0x04001AA6 RID: 6822
		private string gYearID;

		// Token: 0x04001AA7 RID: 6823
		private string gYearMonthID;

		// Token: 0x04001AA8 RID: 6824
		private string IDID;

		// Token: 0x04001AA9 RID: 6825
		private string IDREFID;

		// Token: 0x04001AAA RID: 6826
		private string IDREFSID;

		// Token: 0x04001AAB RID: 6827
		private string integerID;

		// Token: 0x04001AAC RID: 6828
		private string languageID;

		// Token: 0x04001AAD RID: 6829
		private string NameID;

		// Token: 0x04001AAE RID: 6830
		private string NCNameID;

		// Token: 0x04001AAF RID: 6831
		private string NMTOKENID;

		// Token: 0x04001AB0 RID: 6832
		private string NMTOKENSID;

		// Token: 0x04001AB1 RID: 6833
		private string negativeIntegerID;

		// Token: 0x04001AB2 RID: 6834
		private string nonPositiveIntegerID;

		// Token: 0x04001AB3 RID: 6835
		private string nonNegativeIntegerID;

		// Token: 0x04001AB4 RID: 6836
		private string normalizedStringID;

		// Token: 0x04001AB5 RID: 6837
		private string NOTATIONID;

		// Token: 0x04001AB6 RID: 6838
		private string positiveIntegerID;

		// Token: 0x04001AB7 RID: 6839
		private string tokenID;

		// Token: 0x04001AB8 RID: 6840
		private string charID;

		// Token: 0x04001AB9 RID: 6841
		private string guidID;

		// Token: 0x04001ABA RID: 6842
		private string timeSpanID;

		// Token: 0x04001ABB RID: 6843
		private static bool checkDeserializeAdvances;

		// Token: 0x020002EC RID: 748
		private struct SoapArrayInfo
		{
			// Token: 0x04001ABC RID: 6844
			public string qname;

			// Token: 0x04001ABD RID: 6845
			public int dimensions;

			// Token: 0x04001ABE RID: 6846
			public int length;

			// Token: 0x04001ABF RID: 6847
			public int jaggedDimensions;
		}

		/// <summary>
		///         Содержит <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> Делегировать экземпляра, а также метод, входные данные; также выступает в качестве параметра для метода.
		///       </summary>
		// Token: 0x020002ED RID: 749
		protected class Fixup
		{
			/// <summary>
			///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlSerializationReader.Fixup" />.
			///       </summary>
			/// <param name="o">
			///           Объект, содержащий прочие объекты, значения которых заполняются посредством реализации обратного вызова.
			///         </param>
			/// <param name="callback">
			///           Метод, который создает экземпляр <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> делегат.
			///         </param>
			/// <param name="count">
			///           Размер массива строк, полученного через <see cref="P:System.Xml.Serialization.XmlSerializationReader.Fixup.Ids" /> свойство.
			///         </param>
			// Token: 0x06001DED RID: 7661 RVA: 0x000B131C File Offset: 0x000AF51C
			public Fixup(object o, XmlSerializationFixupCallback callback, int count) : this(o, callback, new string[count])
			{
			}

			/// <summary>
			///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlSerializationReader.Fixup" />.
			///       </summary>
			/// <param name="o">
			///           Объект, содержащий прочие объекты, значения которых заполняются посредством реализации обратного вызова.
			///         </param>
			/// <param name="callback">
			///           Метод, который создает экземпляр <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> делегат.
			///         </param>
			/// <param name="ids">
			///           Массив строк в результате <see cref="P:System.Xml.Serialization.XmlSerializationReader.Fixup.Ids" /> свойство.
			///         </param>
			// Token: 0x06001DEE RID: 7662 RVA: 0x000B132C File Offset: 0x000AF52C
			public Fixup(object o, XmlSerializationFixupCallback callback, string[] ids)
			{
				this.callback = callback;
				this.Source = o;
				this.ids = ids;
			}

			/// <summary>
			///         Возвращает метод обратного вызова, который создает экземпляр <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> делегат.
			///       </summary>
			/// <returns>
			///         Метод обратного вызова, который создает экземпляр <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> делегат.
			///       </returns>
			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x06001DEF RID: 7663 RVA: 0x000B1349 File Offset: 0x000AF549
			public XmlSerializationFixupCallback Callback
			{
				get
				{
					return this.callback;
				}
			}

			/// <summary>
			///         Возвращает или задает объект, содержащий другие объекты, значения которых заполняются посредством реализации обратного вызова.
			///       </summary>
			/// <returns>
			///         Источник, содержащий объекты со значениями для заполнения.
			///       </returns>
			// Token: 0x170005E2 RID: 1506
			// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x000B1351 File Offset: 0x000AF551
			// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x000B1359 File Offset: 0x000AF559
			public object Source
			{
				get
				{
					return this.source;
				}
				set
				{
					this.source = value;
				}
			}

			/// <summary>
			///         Возвращает или задает массив ключей для объектов, принадлежащих <see cref="P:System.Xml.Serialization.XmlSerializationReader.Fixup.Source" /> Свойства, значения которых заполняются посредством реализации обратного вызова.
			///       </summary>
			/// <returns>
			///         Массив ключей.
			///       </returns>
			// Token: 0x170005E3 RID: 1507
			// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x000B1362 File Offset: 0x000AF562
			public string[] Ids
			{
				get
				{
					return this.ids;
				}
			}

			// Token: 0x04001AC0 RID: 6848
			private XmlSerializationFixupCallback callback;

			// Token: 0x04001AC1 RID: 6849
			private object source;

			// Token: 0x04001AC2 RID: 6850
			private string[] ids;
		}

		/// <summary>
		///         Содержит <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> Делегировать экземпляра, а также метод, входные данные; также поддерживает параметры метода.
		///       </summary>
		// Token: 0x020002EE RID: 750
		protected class CollectionFixup
		{
			/// <summary>
			///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlSerializationReader.CollectionFixup" /> класс с параметрами для метода обратного вызова.
			///       </summary>
			/// <param name="collection">
			///           Коллекция, в который метод обратного вызова копирует массив элементов коллекции.
			///         </param>
			/// <param name="callback">
			///           Метод, который создает экземпляр <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> делегат.
			///         </param>
			/// <param name="collectionItems">
			///           Массив, в котором метод обратного вызова копирует коллекцию.
			///         </param>
			// Token: 0x06001DF3 RID: 7667 RVA: 0x000B136A File Offset: 0x000AF56A
			public CollectionFixup(object collection, XmlSerializationCollectionFixupCallback callback, object collectionItems)
			{
				this.callback = callback;
				this.collection = collection;
				this.collectionItems = collectionItems;
			}

			/// <summary>
			///         Возвращает метод обратного вызова, который создает экземпляр <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> делегат.
			///       </summary>
			/// <returns>
			///         <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> Делегат, который указывает на метод обратного вызова.
			///       </returns>
			// Token: 0x170005E4 RID: 1508
			// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x000B1387 File Offset: 0x000AF587
			public XmlSerializationCollectionFixupCallback Callback
			{
				get
				{
					return this.callback;
				}
			}

			/// <summary>
			///         Возвращает <paramref name="object collection" /> для метода обратного вызова.
			///       </summary>
			/// <returns>
			///         Коллекция, которая используется для исправления.
			///       </returns>
			// Token: 0x170005E5 RID: 1509
			// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x000B138F File Offset: 0x000AF58F
			public object Collection
			{
				get
				{
					return this.collection;
				}
			}

			/// <summary>
			///         Возвращает массив, в котором метод обратного вызова копирует коллекцию.
			///       </summary>
			/// <returns>
			///         Массив, в котором метод обратного вызова копирует коллекцию.
			///       </returns>
			// Token: 0x170005E6 RID: 1510
			// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x000B1397 File Offset: 0x000AF597
			public object CollectionItems
			{
				get
				{
					return this.collectionItems;
				}
			}

			// Token: 0x04001AC3 RID: 6851
			private XmlSerializationCollectionFixupCallback callback;

			// Token: 0x04001AC4 RID: 6852
			private object collection;

			// Token: 0x04001AC5 RID: 6853
			private object collectionItems;
		}
	}
}
