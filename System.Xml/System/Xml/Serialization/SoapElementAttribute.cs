using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Указывает, что значения открытых членов сериализуются объектом <see cref="T:System.Xml.Serialization.XmlSerializer" /> как закодированный SOAP элемент XML.
	///       </summary>
	// Token: 0x020002AF RID: 687
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class SoapElementAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.SoapElementAttribute" />.
		///       </summary>
		// Token: 0x060019E6 RID: 6630 RVA: 0x000021EA File Offset: 0x000003EA
		public SoapElementAttribute()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.SoapElementAttribute" /> класса и задает имя элемента XML.
		///       </summary>
		/// <param name="elementName">
		///           Имя элемента XML сериализованного члена.
		///         </param>
		// Token: 0x060019E7 RID: 6631 RVA: 0x00094CC9 File Offset: 0x00092EC9
		public SoapElementAttribute(string elementName)
		{
			this.elementName = elementName;
		}

		/// <summary>
		///         Возвращает или задает имя создаваемого элемента XML.
		///       </summary>
		/// <returns>
		///         Имя создаваемого элемента XML.
		///          По умолчанию используется идентификатор члена.
		///       </returns>
		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00094CD8 File Offset: 0x00092ED8
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x00094CEE File Offset: 0x00092EEE
		public string ElementName
		{
			get
			{
				if (this.elementName != null)
				{
					return this.elementName;
				}
				return string.Empty;
			}
			set
			{
				this.elementName = value;
			}
		}

		/// <summary>
		///         Возвращает или задает XML-схемы (XSD) тип данных языка определения создаваемого элемента XML.
		///       </summary>
		/// <returns>
		///         Один из типов данных схемы XML.
		///       </returns>
		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x00094CF7 File Offset: 0x00092EF7
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x00094D0D File Offset: 0x00092F0D
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

		/// <summary>
		///         Возвращает или задает значение, указывающее, является ли <see cref="T:System.Xml.Serialization.XmlSerializer" /> необходимо сериализовать член, имеющий <see langword="xsi:null" /> атрибута значение «1».
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если <see cref="T:System.Xml.Serialization.XmlSerializer" /> создает <see langword="xsi:null" /> атрибута; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x00094D16 File Offset: 0x00092F16
		// (set) Token: 0x060019ED RID: 6637 RVA: 0x00094D1E File Offset: 0x00092F1E
		public bool IsNullable
		{
			get
			{
				return this.nullable;
			}
			set
			{
				this.nullable = value;
			}
		}

		// Token: 0x0400194D RID: 6477
		private string elementName;

		// Token: 0x0400194E RID: 6478
		private string dataType;

		// Token: 0x0400194F RID: 6479
		private bool nullable;
	}
}
