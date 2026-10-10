using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Задает тип переносимого исполняемого PE-файла.</summary>
	// Token: 0x0200093D RID: 2365
	[ComVisible(true)]
	[Serializable]
	public enum PEFileKinds
	{
		/// <summary>Переносимый исполняемый PE-файл является DLL.</summary>
		// Token: 0x040032EB RID: 13035
		Dll = 1,
		/// <summary>Приложение является консольным (а не приложением Windows).</summary>
		// Token: 0x040032EC RID: 13036
		ConsoleApplication,
		/// <summary>Данное приложение является приложением Windows.</summary>
		// Token: 0x040032ED RID: 13037
		WindowApplication
	}
}
