using System;

namespace System.Reflection.Emit
{
	/// <summary>Описывает типы инструкций MSIL.</summary>
	// Token: 0x02000907 RID: 2311
	public enum OpCodeType
	{
		/// <summary>Это значение перечислителя зарезервировано и не должно использоваться.</summary>
		// Token: 0x04003084 RID: 12420
		[Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
		Annotation,
		/// <summary>Инструкции MSIL, используемые как синонимы других инструкций MSIL. Например, <see langword="ldarg.0" /> представляет инструкцию <see langword="ldarg" /> с аргументом, равным 0.</summary>
		// Token: 0x04003085 RID: 12421
		Macro,
		/// <summary>Описывает зарезервированную инструкцию MSIL.</summary>
		// Token: 0x04003086 RID: 12422
		Nternal,
		/// <summary>Описывает инструкцию MSIL, которая применяется к объектам.</summary>
		// Token: 0x04003087 RID: 12423
		Objmodel,
		/// <summary>Описывает префиксную инструкцию, которая меняет следующую инструкцию.</summary>
		// Token: 0x04003088 RID: 12424
		Prefix,
		/// <summary>Описывает встроенную инструкцию.</summary>
		// Token: 0x04003089 RID: 12425
		Primitive
	}
}
