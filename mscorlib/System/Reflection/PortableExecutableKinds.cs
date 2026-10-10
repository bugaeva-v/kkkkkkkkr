using System;

namespace System.Reflection
{
	/// <summary>Определяет природу кода в исполняемом файле.</summary>
	// Token: 0x020008B9 RID: 2233
	[Flags]
	public enum PortableExecutableKinds
	{
		/// <summary>Этот файл не является переносимым исполняемым (PE) файлом.</summary>
		// Token: 0x04002F10 RID: 12048
		NotAPortableExecutableImage = 0,
		/// <summary>Этот исполняемый файл содержит только код MSIL и благодаря этому может выполняться как на 32-разрядных, так и на 64-разрядных платформах.</summary>
		// Token: 0x04002F11 RID: 12049
		ILOnly = 1,
		/// <summary>Этот исполняемый файл может выполняться на 32-разрядной платформе, в 32-разрядной среде Windows поверх Windows (WOW) или на 64-разрядной платформе.</summary>
		// Token: 0x04002F12 RID: 12050
		Required32Bit = 2,
		/// <summary>Для выполнения этого исполняемого файла требуется 64-разрядная платформа.</summary>
		// Token: 0x04002F13 RID: 12051
		PE32Plus = 4,
		/// <summary>Этот исполняемый файл содержит только неуправляемый код.</summary>
		// Token: 0x04002F14 RID: 12052
		Unmanaged32Bit = 8,
		/// <summary>Исполняемый файл платформенно-независимый, но он должен выполняться на 32-разрядной платформе, если это возможно.</summary>
		// Token: 0x04002F15 RID: 12053
		Preferred32Bit = 16
	}
}
