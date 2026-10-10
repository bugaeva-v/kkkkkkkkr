using System;
using Unity;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Содержит сопоставление одного типа в другой.
	///       </summary>
	// Token: 0x0200030A RID: 778
	public class XmlTypeMapping : XmlMapping
	{
		// Token: 0x0600205D RID: 8285 RVA: 0x000D0C35 File Offset: 0x000CEE35
		internal XmlTypeMapping(TypeScope scope, ElementAccessor accessor) : base(scope, accessor)
		{
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x000D0C3F File Offset: 0x000CEE3F
		internal TypeMapping Mapping
		{
			get
			{
				return base.Accessor.Mapping;
			}
		}

		/// <summary>
		///         Возвращает имя типа сопоставляемого объекта.
		///       </summary>
		/// <returns>
		///         Имя типа сопоставляемого объекта.
		///       </returns>
		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x000D0C4C File Offset: 0x000CEE4C
		public string TypeName
		{
			get
			{
				return this.Mapping.TypeDesc.Name;
			}
		}

		/// <summary>
		///         Полное имя типа, содержит пространство имен (или пространства имен) и тип.
		///       </summary>
		/// <returns>
		///         Полное имя типа.
		///       </returns>
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x000D0C5E File Offset: 0x000CEE5E
		public string TypeFullName
		{
			get
			{
				return this.Mapping.TypeDesc.FullName;
			}
		}

		/// <summary>
		///         Возвращает имя элемента XML отраженного объекта.
		///       </summary>
		/// <returns>
		///         Имя элемента XML отраженного объекта.
		///          Значение по умолчанию — имя класса объекта.
		///       </returns>
		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x000D0C70 File Offset: 0x000CEE70
		public string XsdTypeName
		{
			get
			{
				return this.Mapping.TypeName;
			}
		}

		/// <summary>
		///         Возвращает пространство имен XML сопоставляемого объекта.
		///       </summary>
		/// <returns>
		///         Пространство имен XML сопоставляемого объекта.
		///          Значение по умолчанию — пустая строка ("").
		///       </returns>
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x000D0C7D File Offset: 0x000CEE7D
		public string XsdTypeNamespace
		{
			get
			{
				return this.Mapping.Namespace;
			}
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00067344 File Offset: 0x00065544
		internal XmlTypeMapping()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
