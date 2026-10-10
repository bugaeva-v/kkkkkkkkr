using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Указывает, что <see cref="T:System.Xml.Serialization.XmlSerializer" /> должен сериализовать член класса как закодированный атрибут SOAP.
	///       </summary>
	// Token: 0x020002AA RID: 682
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class SoapAttributeAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.SoapAttributeAttribute" />.
		///       </summary>
		// Token: 0x060019B8 RID: 6584 RVA: 0x000021EA File Offset: 0x000003EA
		public SoapAttributeAttribute()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.SoapAttributeAttribute" /> класса, используя указанное значение имени атрибута XML.
		///       </summary>
		/// <param name="attributeName">
		///           Имя XML-атрибута.
		///         </param>
		// Token: 0x060019B9 RID: 6585 RVA: 0x0009422F File Offset: 0x0009242F
		public SoapAttributeAttribute(string attributeName)
		{
			this.attributeName = attributeName;
		}

		/// <summary>
		///         Возвращает или задает имя атрибута XML, созданного объектом <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </summary>
		/// <returns>
		///         Имя XML-атрибута.
		///          По умолчанию используется идентификатор члена.
		///       </returns>
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x0009423E File Offset: 0x0009243E
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x00094254 File Offset: 0x00092454
		public string AttributeName
		{
			get
			{
				if (this.attributeName != null)
				{
					return this.attributeName;
				}
				return string.Empty;
			}
			set
			{
				this.attributeName = value;
			}
		}

		/// <summary>
		///         Возвращает или задает пространство имен XML атрибута XML.
		///       </summary>
		/// <returns>
		///         Пространство имен XML атрибута XML.
		///       </returns>
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x0009425D File Offset: 0x0009245D
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x00094265 File Offset: 0x00092465
		public string Namespace
		{
			get
			{
				return this.ns;
			}
			set
			{
				this.ns = value;
			}
		}

		/// <summary>
		///         Возвращает или задает тип данных языка определения схемы XML атрибута SOAP, созданного объектом <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </summary>
		/// <returns>
		///         Тип данных схемы XML, как определено документом консорциума World Wide Web (www.w3.org) с именем «XML схема часть 2: типы данных».
		///       </returns>
		/// <exception cref="T:System.Exception">
		///             Указанный тип данных схемы XML не может быть сопоставлен с типом данных .NET.
		///           </exception>
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x0009426E File Offset: 0x0009246E
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x00094284 File Offset: 0x00092484
		public string DataType
		{
			get
			{
				if (this.dataType != null)
				{
					return this.dataType;
				}
				return string.Empty;
			}
			set
			{
				this.dataType = value;
			}
		}

		// Token: 0x0400193E RID: 6462
		private string attributeName;

		// Token: 0x0400193F RID: 6463
		private string ns;

		// Token: 0x04001940 RID: 6464
		private string dataType;
	}
}
