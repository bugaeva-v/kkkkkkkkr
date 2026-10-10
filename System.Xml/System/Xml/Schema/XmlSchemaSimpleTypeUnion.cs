using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="union" /> элемент для простых типов из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          A <see langword="union" /> тип данных может использоваться для указания содержимого <see langword="simpleType" />.
	///          Значение <see langword="simpleType" /> элемент должен быть один из набора возможных типов данных, заданных в объединении.
	///          Типы-объединения всегда являются производными типами и должны состоять как минимум из двух различных типов данных.
	///       </summary>
	// Token: 0x020005E1 RID: 1505
	public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
	{
		/// <summary>
		///         Возвращает коллекцию базовых типов.
		///       </summary>
		/// <returns>
		///         Коллекция базовых значений для простого типа.
		///       </returns>
		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06003C47 RID: 15431 RVA: 0x00151142 File Offset: 0x0014F342
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		public XmlSchemaObjectCollection BaseTypes
		{
			get
			{
				return this.baseTypes;
			}
		}

		/// <summary>
		///         Возвращает или задает массив полное член имена встроенных типов данных или <see langword="simpleType" /> элементов, определенных в этой схеме (или другой схеме, задаваемой указанным пространством имен).
		///       </summary>
		/// <returns>
		///         Массив, состоящий из элементов списка встроенных типов данных или простых типов.
		///       </returns>
		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06003C48 RID: 15432 RVA: 0x0015114A File Offset: 0x0014F34A
		// (set) Token: 0x06003C49 RID: 15433 RVA: 0x00151152 File Offset: 0x0014F352
		[XmlAttribute("memberTypes")]
		public XmlQualifiedName[] MemberTypes
		{
			get
			{
				return this.memberTypes;
			}
			set
			{
				this.memberTypes = value;
			}
		}

		/// <summary>
		///         Получает или задает массив <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> объектов, представляющих тип <see langword="simpleType" /> на основе элемента <see cref="P:System.Xml.Schema.XmlSchemaSimpleTypeUnion.BaseTypes" /> и <see cref="P:System.Xml.Schema.XmlSchemaSimpleTypeUnion.MemberTypes" /> значений простого типа.
		///       </summary>
		/// <returns>
		///         Массив <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> объектов, представляющих тип <see langword="simpleType" /> элемента.
		///       </returns>
		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06003C4A RID: 15434 RVA: 0x0015115B File Offset: 0x0014F35B
		[XmlIgnore]
		public XmlSchemaSimpleType[] BaseMemberTypes
		{
			get
			{
				return this.baseMemberTypes;
			}
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x00151163 File Offset: 0x0014F363
		internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes)
		{
			this.baseMemberTypes = baseMemberTypes;
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x0015116C File Offset: 0x0014F36C
		internal override XmlSchemaObject Clone()
		{
			if (this.memberTypes != null && this.memberTypes.Length != 0)
			{
				XmlSchemaSimpleTypeUnion xmlSchemaSimpleTypeUnion = (XmlSchemaSimpleTypeUnion)base.MemberwiseClone();
				XmlQualifiedName[] array = new XmlQualifiedName[this.memberTypes.Length];
				for (int i = 0; i < this.memberTypes.Length; i++)
				{
					array[i] = this.memberTypes[i].Clone();
				}
				xmlSchemaSimpleTypeUnion.MemberTypes = array;
				return xmlSchemaSimpleTypeUnion;
			}
			return this;
		}

		// Token: 0x04002BCC RID: 11212
		private XmlSchemaObjectCollection baseTypes = new XmlSchemaObjectCollection();

		// Token: 0x04002BCD RID: 11213
		private XmlQualifiedName[] memberTypes;

		// Token: 0x04002BCE RID: 11214
		private XmlSchemaSimpleType[] baseMemberTypes;
	}
}
