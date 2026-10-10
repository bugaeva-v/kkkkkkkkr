using System;

namespace System.Reflection
{
	/// <summary>Указывает целевую платформу исполняемого файла.</summary>
	// Token: 0x020008A4 RID: 2212
	public enum ImageFileMachine
	{
		/// <summary>Предназначен для 32-разрядных процессоров Intel.</summary>
		// Token: 0x04002EAF RID: 11951
		I386 = 332,
		/// <summary>Предназначен для 64-разрядных процессоров Intel.</summary>
		// Token: 0x04002EB0 RID: 11952
		IA64 = 512,
		/// <summary>Предназначен для 64-разрядных процессоров AMD.</summary>
		// Token: 0x04002EB1 RID: 11953
		AMD64 = 34404,
		/// <summary>Предназначен для процессоров ARM.</summary>
		// Token: 0x04002EB2 RID: 11954
		ARM = 452
	}
}
