using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="sequence" /> элемента (композитор) из схемы XML, определенной консорциумом World Wide Web Consortium (W3C).
	///         <see langword="sequence" /> Заставляет элементы группы появиться в указанной последовательности в содержащем его элементе.
	///       </summary>
	// Token: 0x020005D8 RID: 1496
	public class XmlSchemaSequence : XmlSchemaGroupBase
	{
		/// <summary>
		///         Элементы, содержащиеся в компоновщике.
		///          Коллекция <see cref="T:System.Xml.Schema.XmlSchemaElement" />, <see cref="T:System.Xml.Schema.XmlSchemaGroupRef" />, <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaSequence" />, или <see cref="T:System.Xml.Schema.XmlSchemaAny" />.
		///       </summary>
		/// <returns>
		///         Элементы, содержащиеся в компоновщике.
		///       </returns>
		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06003BE0 RID: 15328 RVA: 0x0014EFCD File Offset: 0x0014D1CD
		[XmlElement("any", typeof(XmlSchemaAny))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		[XmlElement("element", typeof(XmlSchemaElement))]
		public override XmlSchemaObjectCollection Items
		{
			get
			{
				return this.items;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06003BE1 RID: 15329 RVA: 0x0014EFD5 File Offset: 0x0014D1D5
		internal override bool IsEmpty
		{
			get
			{
				return base.IsEmpty || this.items.Count == 0;
			}
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x0014EFEF File Offset: 0x0014D1EF
		internal override void SetItems(XmlSchemaObjectCollection newItems)
		{
			this.items = newItems;
		}

		// Token: 0x04002BA7 RID: 11175
		private XmlSchemaObjectCollection items = new XmlSchemaObjectCollection();
	}
}
