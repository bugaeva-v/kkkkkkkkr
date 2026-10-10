using System;

namespace System.Reflection.Emit
{
	/// <summary>Описывает тип операнда инструкции MSIL.</summary>
	// Token: 0x02000908 RID: 2312
	public enum OperandType
	{
		/// <summary>Операнд является 32-битовым целочисленным значением, задающим конечный адрес ветвления.</summary>
		// Token: 0x0400308B RID: 12427
		InlineBrTarget,
		/// <summary>Операнд является 32-битовым маркером метаданных.</summary>
		// Token: 0x0400308C RID: 12428
		InlineField,
		/// <summary>Операнд является 32-битовым целочисленным значением.</summary>
		// Token: 0x0400308D RID: 12429
		InlineI,
		/// <summary>Операнд является 64-битовым целочисленным значением.</summary>
		// Token: 0x0400308E RID: 12430
		InlineI8,
		/// <summary>Операнд является 32-битовым маркером метаданных.</summary>
		// Token: 0x0400308F RID: 12431
		InlineMethod,
		/// <summary>Операнд отсутствует.</summary>
		// Token: 0x04003090 RID: 12432
		InlineNone,
		/// <summary>Операнд зарезервирован и не должен использоваться.</summary>
		// Token: 0x04003091 RID: 12433
		[Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
		InlinePhi,
		/// <summary>Операнд является 64-битовым числом с плавающей запятой стандарта IEEE.</summary>
		// Token: 0x04003092 RID: 12434
		InlineR,
		/// <summary>Операнд является 32-битовым маркером сигнатуры метаданных.</summary>
		// Token: 0x04003093 RID: 12435
		InlineSig = 9,
		/// <summary>Операнд является 32-битовым маркером строки метаданных.</summary>
		// Token: 0x04003094 RID: 12436
		InlineString,
		/// <summary>Операнд является 32-битовым целочисленным аргументом инструкции выбора вариантов.</summary>
		// Token: 0x04003095 RID: 12437
		InlineSwitch,
		/// <summary>Операнд является маркером элементов <see langword="FieldRef" />, <see langword="MethodRef" /> или <see langword="TypeRef" />.</summary>
		// Token: 0x04003096 RID: 12438
		InlineTok,
		/// <summary>Операнд является 32-битовым маркером метаданных.</summary>
		// Token: 0x04003097 RID: 12439
		InlineType,
		/// <summary>Операнд является 16-битовым целочисленным значением, содержащим порядковый номер локальной переменной или аргумента.</summary>
		// Token: 0x04003098 RID: 12440
		InlineVar,
		/// <summary>Операнд является 8-битовым целочисленным значением, задающим конечный адрес ветвления.</summary>
		// Token: 0x04003099 RID: 12441
		ShortInlineBrTarget,
		/// <summary>Операнд является 8-битовым целочисленным значением.</summary>
		// Token: 0x0400309A RID: 12442
		ShortInlineI,
		/// <summary>Операнд является 32-битовым числом с плавающей запятой стандарта IEEE.</summary>
		// Token: 0x0400309B RID: 12443
		ShortInlineR,
		/// <summary>Операнд является 8-битовым целочисленным значением, содержащим порядковый номер локальной переменной или аргумента.</summary>
		// Token: 0x0400309C RID: 12444
		ShortInlineVar
	}
}
