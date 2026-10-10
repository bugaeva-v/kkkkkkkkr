using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Представляет определенные атрибуты элемента XSD &lt;<see langword="part" />&gt; элемент в документе WSDL для создания классов из документа.
	///       </summary>
	// Token: 0x020002B6 RID: 694
	public class SoapSchemaMember
	{
		/// <summary>
		///         Возвращает или задает значение, соответствующее типу атрибута WSDL-элемента part.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlQualifiedName" /> Соответствующий типу XML.
		///       </returns>
		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x000987CD File Offset: 0x000969CD
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x000987D5 File Offset: 0x000969D5
		public XmlQualifiedName MemberType
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
		///         Возвращает или задает значение, соответствующее атрибуту имени элемента частей WSDL.
		///       </summary>
		/// <returns>
		///         Имя элемента.
		///       </returns>
		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x000987DE File Offset: 0x000969DE
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x000987F4 File Offset: 0x000969F4
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

		// Token: 0x04001961 RID: 6497
		private string memberName;

		// Token: 0x04001962 RID: 6498
		private XmlQualifiedName type = XmlQualifiedName.Empty;
	}
}
