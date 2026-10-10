using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="choice" /> элемента (композитор) из схемы XML, определенной консорциумом World Wide Web Consortium (W3C).
	///         <see langword="choice" /> Позволяет только одному из его дочерних элементов появляться в экземпляре.
	///       </summary>
	// Token: 0x0200059B RID: 1435
	public class XmlSchemaChoice : XmlSchemaGroupBase
	{
		/// <summary>
		///         Возвращает коллекцию элементов, содержащихся в компоновщике (<see langword="choice" />): <see langword="XmlSchemaElement" />, <see langword="XmlSchemaGroupRef" />, <see langword="XmlSchemaChoice" />, <see langword="XmlSchemaSequence" />, или <see langword="XmlSchemaAny" />.
		///       </summary>
		/// <returns>
		///         Коллекция элементов, содержащихся в <see langword="XmlSchemaChoice" />.
		///       </returns>
		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06003A06 RID: 14854 RVA: 0x0014C20D File Offset: 0x0014A40D
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("any", typeof(XmlSchemaAny))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		[XmlElement("element", typeof(XmlSchemaElement))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		public override XmlSchemaObjectCollection Items
		{
			get
			{
				return this.items;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06003A07 RID: 14855 RVA: 0x0014C215 File Offset: 0x0014A415
		internal override bool IsEmpty
		{
			get
			{
				return base.IsEmpty;
			}
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x0014C21D File Offset: 0x0014A41D
		internal override void SetItems(XmlSchemaObjectCollection newItems)
		{
			this.items = newItems;
		}

		// Token: 0x04002AEA RID: 10986
		private XmlSchemaObjectCollection items = new XmlSchemaObjectCollection();
	}
}
