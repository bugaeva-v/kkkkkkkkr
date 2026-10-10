using System;

namespace System.Reflection
{
	/// <summary>Определяет процессор и количество бит на слово в платформе, для которой предназначен исполняемый файл.</summary>
	// Token: 0x020008BA RID: 2234
	public enum ProcessorArchitecture
	{
		/// <summary>Неизвестное или неопределенное сочетание параметров процессора и разрядности слова.</summary>
		// Token: 0x04002F17 RID: 12055
		None,
		/// <summary>Код нейтрален по отношению к процессору и разрядности слова.</summary>
		// Token: 0x04002F18 RID: 12056
		MSIL,
		/// <summary>Для 32-разрядного процессора Intel — реального либо среды Windows on Windows на 64-разрядной платформе (WOW64).</summary>
		// Token: 0x04002F19 RID: 12057
		X86,
		/// <summary>Только 64-разрядный процессор Intel Itanium.</summary>
		// Token: 0x04002F1A RID: 12058
		IA64,
		/// <summary>64-разрядный процессор на основе архитектуры x64.</summary>
		// Token: 0x04002F1B RID: 12059
		Amd64,
		/// <summary>Препроцессор ARM.</summary>
		// Token: 0x04002F1C RID: 12060
		Arm
	}
}
