using System;

namespace System.Reflection
{
	/// <summary>Определяет атрибуты, которые могут быть связаны с параметром. Они определяются в файле CorHdr.h.</summary>
	// Token: 0x020008B5 RID: 2229
	[Flags]
	public enum ParameterAttributes
	{
		/// <summary>Указывает, что параметр не имеет атрибутов.</summary>
		// Token: 0x04002EFA RID: 12026
		None = 0,
		/// <summary>Указывает, что данный параметр является входным параметром.</summary>
		// Token: 0x04002EFB RID: 12027
		In = 1,
		/// <summary>Указывает, что данный параметр является выходным параметром.</summary>
		// Token: 0x04002EFC RID: 12028
		Out = 2,
		/// <summary>Указывает, что данный параметр является идентификатором языка локализации (lcid).</summary>
		// Token: 0x04002EFD RID: 12029
		Lcid = 4,
		/// <summary>Указывает, что данный параметр является возвращаемым значением.</summary>
		// Token: 0x04002EFE RID: 12030
		Retval = 8,
		/// <summary>Указывает, что данный параметр не обязателен.</summary>
		// Token: 0x04002EFF RID: 12031
		Optional = 16,
		/// <summary>Указывает, что параметр имеет стандартное значение.</summary>
		// Token: 0x04002F00 RID: 12032
		HasDefault = 4096,
		/// <summary>Указывает, что параметр содержит сведения о маршалинге поля.</summary>
		// Token: 0x04002F01 RID: 12033
		HasFieldMarshal = 8192,
		/// <summary>Зарезервировано.</summary>
		// Token: 0x04002F02 RID: 12034
		Reserved3 = 16384,
		/// <summary>Зарезервировано.</summary>
		// Token: 0x04002F03 RID: 12035
		Reserved4 = 32768,
		/// <summary>Указывает, что данный параметр зарезервирован.</summary>
		// Token: 0x04002F04 RID: 12036
		ReservedMask = 61440
	}
}
