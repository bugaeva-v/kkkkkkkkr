using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет World Wide Web Consortium (W3C) <see langword="annotation" /> элемента.
	///       </summary>
	// Token: 0x02000594 RID: 1428
	public class XmlSchemaAnnotation : XmlSchemaObject
	{
		/// <summary>
		///         Возвращает или задает идентификатор строки.
		///       </summary>
		/// <returns>
		///         Идентификатор строки.
		///          Значение по умолчанию — <see langword="String.Empty" />.
		///
		///         Необязательно.
		///       </returns>
		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x060039AB RID: 14763 RVA: 0x0014BB96 File Offset: 0x00149D96
		// (set) Token: 0x060039AC RID: 14764 RVA: 0x0014BB9E File Offset: 0x00149D9E
		[XmlAttribute("id", DataType = "ID")]
		public string Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		/// <summary>
		///         Возвращает <see langword="Items" /> коллекцию, используемую для хранения <see langword="appinfo" /> и <see langword="documentation" /> дочерних элементов.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaObjectCollection" /> Из <see langword="appinfo" /> и <see langword="documentation" /> дочерних элементов.
		///       </returns>
		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x060039AD RID: 14765 RVA: 0x0014BBA7 File Offset: 0x00149DA7
		[XmlElement("documentation", typeof(XmlSchemaDocumentation))]
		[XmlElement("appinfo", typeof(XmlSchemaAppInfo))]
		public XmlSchemaObjectCollection Items
		{
			get
			{
				return this.items;
			}
		}

		/// <summary>
		///         Возвращает или задает полные атрибуты, не принадлежащие целевого пространства имен схемы.
		///       </summary>
		/// <returns>
		///         Массив <see cref="T:System.Xml.XmlAttribute" /> объектов, не принадлежащих схеме целевого пространства имен.
		///       </returns>
		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x060039AE RID: 14766 RVA: 0x0014BBAF File Offset: 0x00149DAF
		// (set) Token: 0x060039AF RID: 14767 RVA: 0x0014BBB7 File Offset: 0x00149DB7
		[XmlAnyAttribute]
		public XmlAttribute[] UnhandledAttributes
		{
			get
			{
				return this.moreAttributes;
			}
			set
			{
				this.moreAttributes = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060039B0 RID: 14768 RVA: 0x0014BBC0 File Offset: 0x00149DC0
		// (set) Token: 0x060039B1 RID: 14769 RVA: 0x0014BBC8 File Offset: 0x00149DC8
		[XmlIgnore]
		internal override string IdAttribute
		{
			get
			{
				return this.Id;
			}
			set
			{
				this.Id = value;
			}
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x0014BBB7 File Offset: 0x00149DB7
		internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
		{
			this.moreAttributes = moreAttributes;
		}

		// Token: 0x04002ACB RID: 10955
		private string id;

		// Token: 0x04002ACC RID: 10956
		private XmlSchemaObjectCollection items = new XmlSchemaObjectCollection();

		// Token: 0x04002ACD RID: 10957
		private XmlAttribute[] moreAttributes;
	}
}
