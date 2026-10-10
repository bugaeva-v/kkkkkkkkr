using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="group" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс определяет группы на <see langword="schema" /> уровне, на которые ссылается сложные типы.
	///          Он группирует набор объявлений элементов, позволяя использовать их в качестве группы в определении сложного типа.
	///       </summary>
	// Token: 0x020005BE RID: 1470
	public class XmlSchemaGroup : XmlSchemaAnnotated
	{
		/// <summary>
		///         Возвращает или задает имя группы схем.
		///       </summary>
		/// <returns>
		///         Имя группы схем.
		///       </returns>
		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x0014E093 File Offset: 0x0014C293
		// (set) Token: 0x06003B1D RID: 15133 RVA: 0x0014E09B File Offset: 0x0014C29B
		[XmlAttribute("name")]
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>
		///         Возвращает или задает один из <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, или <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> классы.
		///       </summary>
		/// <returns>
		///         Один из <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, или <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> классы.
		///       </returns>
		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x0014E0A4 File Offset: 0x0014C2A4
		// (set) Token: 0x06003B1F RID: 15135 RVA: 0x0014E0AC File Offset: 0x0014C2AC
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("all", typeof(XmlSchemaAll))]
		public XmlSchemaGroupBase Particle
		{
			get
			{
				return this.particle;
			}
			set
			{
				this.particle = value;
			}
		}

		/// <summary>
		///         Возвращает полное имя группы схем.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlQualifiedName" /> Объект, представляющий полное имя группы схем.
		///       </returns>
		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x0014E0B5 File Offset: 0x0014C2B5
		[XmlIgnore]
		public XmlQualifiedName QualifiedName
		{
			get
			{
				return this.qname;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06003B21 RID: 15137 RVA: 0x0014E0BD File Offset: 0x0014C2BD
		// (set) Token: 0x06003B22 RID: 15138 RVA: 0x0014E0C5 File Offset: 0x0014C2C5
		[XmlIgnore]
		internal XmlSchemaParticle CanonicalParticle
		{
			get
			{
				return this.canonicalParticle;
			}
			set
			{
				this.canonicalParticle = value;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06003B23 RID: 15139 RVA: 0x0014E0CE File Offset: 0x0014C2CE
		// (set) Token: 0x06003B24 RID: 15140 RVA: 0x0014E0D6 File Offset: 0x0014C2D6
		[XmlIgnore]
		internal XmlSchemaGroup Redefined
		{
			get
			{
				return this.redefined;
			}
			set
			{
				this.redefined = value;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06003B25 RID: 15141 RVA: 0x0014E0DF File Offset: 0x0014C2DF
		// (set) Token: 0x06003B26 RID: 15142 RVA: 0x0014E0E7 File Offset: 0x0014C2E7
		[XmlIgnore]
		internal int SelfReferenceCount
		{
			get
			{
				return this.selfReferenceCount;
			}
			set
			{
				this.selfReferenceCount = value;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06003B27 RID: 15143 RVA: 0x0014E0F0 File Offset: 0x0014C2F0
		// (set) Token: 0x06003B28 RID: 15144 RVA: 0x0014E0F8 File Offset: 0x0014C2F8
		[XmlIgnore]
		internal override string NameAttribute
		{
			get
			{
				return this.Name;
			}
			set
			{
				this.Name = value;
			}
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x0014E101 File Offset: 0x0014C301
		internal void SetQualifiedName(XmlQualifiedName value)
		{
			this.qname = value;
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x0014E10A File Offset: 0x0014C30A
		internal override XmlSchemaObject Clone()
		{
			return this.Clone(null);
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x0014E114 File Offset: 0x0014C314
		internal XmlSchemaObject Clone(XmlSchema parentSchema)
		{
			XmlSchemaGroup xmlSchemaGroup = (XmlSchemaGroup)base.MemberwiseClone();
			if (XmlSchemaComplexType.HasParticleRef(this.particle, parentSchema))
			{
				xmlSchemaGroup.particle = (XmlSchemaComplexType.CloneParticle(this.particle, parentSchema) as XmlSchemaGroupBase);
			}
			xmlSchemaGroup.canonicalParticle = XmlSchemaParticle.Empty;
			return xmlSchemaGroup;
		}

		// Token: 0x04002B62 RID: 11106
		private string name;

		// Token: 0x04002B63 RID: 11107
		private XmlSchemaGroupBase particle;

		// Token: 0x04002B64 RID: 11108
		private XmlSchemaParticle canonicalParticle;

		// Token: 0x04002B65 RID: 11109
		private XmlQualifiedName qname = XmlQualifiedName.Empty;

		// Token: 0x04002B66 RID: 11110
		private XmlSchemaGroup redefined;

		// Token: 0x04002B67 RID: 11111
		private int selfReferenceCount;
	}
}
