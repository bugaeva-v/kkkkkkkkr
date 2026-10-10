using System;

namespace System.Xml
{
	/// <summary>
	///         Представляет тип XML для строки.
	///          Это позволяет читать как тип XML, например тип раздела CDATA строку.
	///       </summary>
	// Token: 0x02000221 RID: 545
	public enum XmlTokenizedType
	{
		/// <summary>
		///         Тип CDATA.
		///       </summary>
		// Token: 0x0400127F RID: 4735
		CDATA,
		/// <summary>
		///         Тип идентификатора.
		///       </summary>
		// Token: 0x04001280 RID: 4736
		ID,
		/// <summary>
		///         Тип IDREF.
		///       </summary>
		// Token: 0x04001281 RID: 4737
		IDREF,
		/// <summary>
		///         Тип IDREFS.
		///       </summary>
		// Token: 0x04001282 RID: 4738
		IDREFS,
		/// <summary>
		///         Тип СУЩНОСТИ.
		///       </summary>
		// Token: 0x04001283 RID: 4739
		ENTITY,
		/// <summary>
		///         Тип СУЩНОСТИ.
		///       </summary>
		// Token: 0x04001284 RID: 4740
		ENTITIES,
		/// <summary>
		///         Тип NMTOKEN.
		///       </summary>
		// Token: 0x04001285 RID: 4741
		NMTOKEN,
		/// <summary>
		///         Тип NMTOKENS.
		///       </summary>
		// Token: 0x04001286 RID: 4742
		NMTOKENS,
		/// <summary>
		///         Тип NOTATION.
		///       </summary>
		// Token: 0x04001287 RID: 4743
		NOTATION,
		/// <summary>
		///         Тип ПЕРЕЧИСЛЕНИЯ.
		///       </summary>
		// Token: 0x04001288 RID: 4744
		ENUMERATION,
		/// <summary>
		///         Тип QName.
		///       </summary>
		// Token: 0x04001289 RID: 4745
		QName,
		/// <summary>
		///         Тип имени NCName.
		///       </summary>
		// Token: 0x0400128A RID: 4746
		NCName,
		/// <summary>
		///         Не является типом.
		///       </summary>
		// Token: 0x0400128B RID: 4747
		None
	}
}
