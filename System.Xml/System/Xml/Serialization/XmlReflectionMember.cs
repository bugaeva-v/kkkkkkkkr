using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Обеспечивает сопоставление между объектами кода в методах службы веб-.NET Framework и содержимое сообщений языка описания веб-служб (WSDL), определенные для веб-служб SOAP.
	///       </summary>
	// Token: 0x020002DF RID: 735
	public class XmlReflectionMember
	{
		/// <summary>
		///         Возвращает или задает тип Web service объект кода члена метода, представленного данным сопоставлением.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Type" /> Web service метод код субъекта, представленного данным сопоставлением.
		///       </returns>
		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x000A3A7E File Offset: 0x000A1C7E
		// (set) Token: 0x06001C83 RID: 7299 RVA: 0x000A3A86 File Offset: 0x000A1C86
		public Type MemberType
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		/// <summary>
		///         Возвращает или задает <see cref="T:System.Xml.Serialization.XmlAttributes" /> с коллекцией <see cref="T:System.Xml.Serialization.XmlSerializer" />-связанных атрибутов, которые были применены к сущности элемента кода.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlAttributes" /> Представляющий атрибуты XML, которые были применены к код элемента.
		///       </returns>
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x000A3A8F File Offset: 0x000A1C8F
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x000A3A97 File Offset: 0x000A1C97
		public XmlAttributes XmlAttributes
		{
			get
			{
				return this.xmlAttributes;
			}
			set
			{
				this.xmlAttributes = value;
			}
		}

		/// <summary>
		///         Возвращает или задает <see cref="T:System.Xml.Serialization.SoapAttributes" /> с коллекцией атрибутов, связанных с SOAP, примененных к сущности кода члена.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Xml.Serialization.SoapAttributes" /> содержащий объекты, представляющие SOAP атрибуты, примененные к элементу.
		///       </returns>
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x000A3AA0 File Offset: 0x000A1CA0
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x000A3AA8 File Offset: 0x000A1CA8
		public SoapAttributes SoapAttributes
		{
			get
			{
				return this.soapAttributes;
			}
			set
			{
				this.soapAttributes = value;
			}
		}

		/// <summary>
		///         Возвращает или задает имя члена метода веб-службы для данного сопоставления.
		///       </summary>
		/// <returns>
		///         Имя метода веб-службы.
		///       </returns>
		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x000A3AB1 File Offset: 0x000A1CB1
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x000A3AC7 File Offset: 0x000A1CC7
		public string MemberName
		{
			get
			{
				if (this.memberName != null)
				{
					return this.memberName;
				}
				return string.Empty;
			}
			set
			{
				this.memberName = value;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, является ли <see cref="T:System.Xml.Serialization.XmlReflectionMember" /> представляет Web service возвращаемого значения метода, в отличие от выходного параметра.
		///       </summary>
		/// <returns>
		///         <see langword="true" />, если элемент представляет возвращаемое значение веб службы; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x000A3AD0 File Offset: 0x000A1CD0
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x000A3AD8 File Offset: 0x000A1CD8
		public bool IsReturnValue
		{
			get
			{
				return this.isReturnValue;
			}
			set
			{
				this.isReturnValue = value;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, которое указывает, что значение соответствующего определения элемента XML isNullable атрибут <see langword="false" />.
		///       </summary>
		/// <returns>
		///         <see langword="True" /> Чтобы переопределить <see cref="P:System.Xml.Serialization.XmlElementAttribute.IsNullable" /> свойство; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x000A3AE1 File Offset: 0x000A1CE1
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x000A3AE9 File Offset: 0x000A1CE9
		public bool OverrideIsNullable
		{
			get
			{
				return this.overrideIsNullable;
			}
			set
			{
				this.overrideIsNullable = value;
			}
		}

		// Token: 0x04001A1D RID: 6685
		private string memberName;

		// Token: 0x04001A1E RID: 6686
		private Type type;

		// Token: 0x04001A1F RID: 6687
		private XmlAttributes xmlAttributes = new XmlAttributes();

		// Token: 0x04001A20 RID: 6688
		private SoapAttributes soapAttributes = new SoapAttributes();

		// Token: 0x04001A21 RID: 6689
		private bool isReturnValue;

		// Token: 0x04001A22 RID: 6690
		private bool overrideIsNullable;
	}
}
