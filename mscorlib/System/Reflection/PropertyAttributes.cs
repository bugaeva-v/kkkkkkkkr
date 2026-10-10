using System;

namespace System.Reflection
{
	/// <summary>Определяет атрибуты, которые могут быть связаны со свойством. Значения этих атрибутов определены в файле corhdr.h.</summary>
	// Token: 0x020008BB RID: 2235
	[Flags]
	public enum PropertyAttributes
	{
		/// <summary>Указывает, что со свойству не сопоставлены атрибуты.</summary>
		// Token: 0x04002F1E RID: 12062
		None = 0,
		/// <summary>Указывает, что это специальное свойство. Особенности свойства отражены в его имени.</summary>
		// Token: 0x04002F1F RID: 12063
		SpecialName = 512,
		/// <summary>Указывает, что кодировка имен проверяется внутренними интерфейсами API метаданных.</summary>
		// Token: 0x04002F20 RID: 12064
		RTSpecialName = 1024,
		/// <summary>Указывает, что свойство имеет значение по умолчанию.</summary>
		// Token: 0x04002F21 RID: 12065
		HasDefault = 4096,
		/// <summary>Зарезервировано.</summary>
		// Token: 0x04002F22 RID: 12066
		Reserved2 = 8192,
		/// <summary>Зарезервировано.</summary>
		// Token: 0x04002F23 RID: 12067
		Reserved3 = 16384,
		/// <summary>Зарезервировано.</summary>
		// Token: 0x04002F24 RID: 12068
		Reserved4 = 32768,
		/// <summary>Указывает флаг, зарезервированный для применения только во время выполнения.</summary>
		// Token: 0x04002F25 RID: 12069
		ReservedMask = 62464
	}
}
