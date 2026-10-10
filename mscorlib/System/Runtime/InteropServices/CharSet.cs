using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет, какой набор символов должны использовать упакованные строки.</summary>
	// Token: 0x020006C3 RID: 1731
	public enum CharSet
	{
		/// <summary>Это значение устарело и по поведению аналогично значению <see cref="F:System.Runtime.InteropServices.CharSet.Ansi" />.</summary>
		// Token: 0x040029EF RID: 10735
		None = 1,
		/// <summary>Маршалирует строки в виде строк многобайтовых символов.</summary>
		// Token: 0x040029F0 RID: 10736
		Ansi,
		/// <summary>Маршалирует строки в виде 2-байтных символов Юникода.</summary>
		// Token: 0x040029F1 RID: 10737
		Unicode,
		/// <summary>Выполняет автоматический маршалинг строк способом, соответствующим целевой операционной системе. По умолчанию в Windows NT, Windows 2000, Windows XP и семействе Windows Server 2003 используется <see cref="F:System.Runtime.InteropServices.CharSet.Unicode" />, а в Windows 98 и Windows Me — <see cref="F:System.Runtime.InteropServices.CharSet.Ansi" />. Хотя для среды CLR по умолчанию используется значение <see cref="F:System.Runtime.InteropServices.CharSet.Auto" />, языки программирования могут переопределить это значение. Например, C# по умолчанию помечает все методы и типы как <see cref="F:System.Runtime.InteropServices.CharSet.Ansi" />.</summary>
		// Token: 0x040029F2 RID: 10738
		Auto
	}
}
