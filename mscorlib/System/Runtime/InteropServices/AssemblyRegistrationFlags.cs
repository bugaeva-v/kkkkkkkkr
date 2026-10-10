using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет набор флагов, используемый при регистрации сборок.</summary>
	// Token: 0x02000719 RID: 1817
	[Flags]
	[ComVisible(true)]
	public enum AssemblyRegistrationFlags
	{
		/// <summary>Показывает отсутствие специальных параметров.</summary>
		// Token: 0x04002B00 RID: 11008
		None = 0,
		/// <summary>Показывает необходимость задания в реестре базового раздела кода для сборки.</summary>
		// Token: 0x04002B01 RID: 11009
		SetCodeBase = 1
	}
}
