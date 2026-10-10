using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет типы схемы W3C схемы языка определения XML (XSD).
	///       </summary>
	// Token: 0x020005EE RID: 1518
	public enum XmlTypeCode
	{
		/// <summary>
		///         Нет информации о типе.
		///       </summary>
		// Token: 0x04002C36 RID: 11318
		None,
		/// <summary>
		///         Например, узел или атомарное значение элемента.
		///       </summary>
		// Token: 0x04002C37 RID: 11319
		Item,
		/// <summary>
		///         Это значение поддерживает инфраструктуру .NET Framework и не предназначен для непосредственного использования в коде.
		///       </summary>
		// Token: 0x04002C38 RID: 11320
		Node,
		/// <summary>
		///         Это значение поддерживает инфраструктуру .NET Framework и не предназначен для непосредственного использования в коде.
		///       </summary>
		// Token: 0x04002C39 RID: 11321
		Document,
		/// <summary>
		///         Это значение поддерживает инфраструктуру .NET Framework и не предназначен для непосредственного использования в коде.
		///       </summary>
		// Token: 0x04002C3A RID: 11322
		Element,
		/// <summary>
		///         Это значение поддерживает инфраструктуру .NET Framework и не предназначен для непосредственного использования в коде.
		///       </summary>
		// Token: 0x04002C3B RID: 11323
		Attribute,
		/// <summary>
		///         Это значение поддерживает инфраструктуру .NET Framework и не предназначен для непосредственного использования в коде.
		///       </summary>
		// Token: 0x04002C3C RID: 11324
		Namespace,
		/// <summary>
		///         Это значение поддерживает инфраструктуру .NET Framework и не предназначен для непосредственного использования в коде.
		///       </summary>
		// Token: 0x04002C3D RID: 11325
		ProcessingInstruction,
		/// <summary>
		///         Это значение поддерживает инфраструктуру .NET Framework и не предназначен для непосредственного использования в коде.
		///       </summary>
		// Token: 0x04002C3E RID: 11326
		Comment,
		/// <summary>
		///         Это значение поддерживает инфраструктуру .NET Framework и не предназначен для непосредственного использования в коде.
		///       </summary>
		// Token: 0x04002C3F RID: 11327
		Text,
		/// <summary>
		///         Любое атомарное значение объединения.
		///       </summary>
		// Token: 0x04002C40 RID: 11328
		AnyAtomicType,
		/// <summary>
		///         Нетипизированное атомное значение.
		///       </summary>
		// Token: 0x04002C41 RID: 11329
		UntypedAtomic,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:string" /> типа.
		///       </summary>
		// Token: 0x04002C42 RID: 11330
		String,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:boolean" /> типа.
		///       </summary>
		// Token: 0x04002C43 RID: 11331
		Boolean,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:decimal" /> типа.
		///       </summary>
		// Token: 0x04002C44 RID: 11332
		Decimal,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:float" /> типа.
		///       </summary>
		// Token: 0x04002C45 RID: 11333
		Float,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:double" /> типа.
		///       </summary>
		// Token: 0x04002C46 RID: 11334
		Double,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:Duration" /> типа.
		///       </summary>
		// Token: 0x04002C47 RID: 11335
		Duration,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:dateTime" /> типа.
		///       </summary>
		// Token: 0x04002C48 RID: 11336
		DateTime,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:time" /> типа.
		///       </summary>
		// Token: 0x04002C49 RID: 11337
		Time,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:date" /> типа.
		///       </summary>
		// Token: 0x04002C4A RID: 11338
		Date,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:gYearMonth" /> типа.
		///       </summary>
		// Token: 0x04002C4B RID: 11339
		GYearMonth,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:gYear" /> типа.
		///       </summary>
		// Token: 0x04002C4C RID: 11340
		GYear,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:gMonthDay" /> типа.
		///       </summary>
		// Token: 0x04002C4D RID: 11341
		GMonthDay,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:gDay" /> типа.
		///       </summary>
		// Token: 0x04002C4E RID: 11342
		GDay,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:gMonth" /> типа.
		///       </summary>
		// Token: 0x04002C4F RID: 11343
		GMonth,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:hexBinary" /> типа.
		///       </summary>
		// Token: 0x04002C50 RID: 11344
		HexBinary,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:base64Binary" /> типа.
		///       </summary>
		// Token: 0x04002C51 RID: 11345
		Base64Binary,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:anyURI" /> типа.
		///       </summary>
		// Token: 0x04002C52 RID: 11346
		AnyUri,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:QName" /> типа.
		///       </summary>
		// Token: 0x04002C53 RID: 11347
		QName,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:NOTATION" /> типа.
		///       </summary>
		// Token: 0x04002C54 RID: 11348
		Notation,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:normalizedString" /> типа.
		///       </summary>
		// Token: 0x04002C55 RID: 11349
		NormalizedString,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:token" /> типа.
		///       </summary>
		// Token: 0x04002C56 RID: 11350
		Token,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:language" /> типа.
		///       </summary>
		// Token: 0x04002C57 RID: 11351
		Language,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:NMTOKEN" /> типа.
		///       </summary>
		// Token: 0x04002C58 RID: 11352
		NmToken,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:Name" /> типа.
		///       </summary>
		// Token: 0x04002C59 RID: 11353
		Name,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:NCName" /> типа.
		///       </summary>
		// Token: 0x04002C5A RID: 11354
		NCName,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:ID" /> типа.
		///       </summary>
		// Token: 0x04002C5B RID: 11355
		Id,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:IDREF" /> типа.
		///       </summary>
		// Token: 0x04002C5C RID: 11356
		Idref,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:ENTITY" /> типа.
		///       </summary>
		// Token: 0x04002C5D RID: 11357
		Entity,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:integer" /> типа.
		///       </summary>
		// Token: 0x04002C5E RID: 11358
		Integer,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:nonPositiveInteger" /> типа.
		///       </summary>
		// Token: 0x04002C5F RID: 11359
		NonPositiveInteger,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:negativeInteger" /> типа.
		///       </summary>
		// Token: 0x04002C60 RID: 11360
		NegativeInteger,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:long" /> типа.
		///       </summary>
		// Token: 0x04002C61 RID: 11361
		Long,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:int" /> типа.
		///       </summary>
		// Token: 0x04002C62 RID: 11362
		Int,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:short" /> типа.
		///       </summary>
		// Token: 0x04002C63 RID: 11363
		Short,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:byte" /> типа.
		///       </summary>
		// Token: 0x04002C64 RID: 11364
		Byte,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:nonNegativeInteger" /> типа.
		///       </summary>
		// Token: 0x04002C65 RID: 11365
		NonNegativeInteger,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:unsignedLong" /> типа.
		///       </summary>
		// Token: 0x04002C66 RID: 11366
		UnsignedLong,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:unsignedInt" /> типа.
		///       </summary>
		// Token: 0x04002C67 RID: 11367
		UnsignedInt,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:unsignedShort" /> типа.
		///       </summary>
		// Token: 0x04002C68 RID: 11368
		UnsignedShort,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:unsignedByte" /> типа.
		///       </summary>
		// Token: 0x04002C69 RID: 11369
		UnsignedByte,
		/// <summary>
		///         Схемы W3C XML <see langword="xs:positiveInteger" /> типа.
		///       </summary>
		// Token: 0x04002C6A RID: 11370
		PositiveInteger,
		/// <summary>
		///         Это значение поддерживает инфраструктуру .NET Framework и не предназначен для непосредственного использования в коде.
		///       </summary>
		// Token: 0x04002C6B RID: 11371
		YearMonthDuration,
		/// <summary>
		///         Это значение поддерживает инфраструктуру .NET Framework и не предназначен для непосредственного использования в коде.
		///       </summary>
		// Token: 0x04002C6C RID: 11372
		DayTimeDuration
	}
}
