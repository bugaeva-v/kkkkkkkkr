using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Описывает порядок передачи элемента структуры, параметра или возвращаемого функцией значения из одного процесса в другой.</summary>
	// Token: 0x020007B8 RID: 1976
	[Flags]
	[Serializable]
	public enum IDLFLAG : short
	{
		/// <summary>Не задает, передает ли параметр сведения или получает их.</summary>
		// Token: 0x04002C9F RID: 11423
		IDLFLAG_NONE = 0,
		/// <summary>Параметр передает сведения из вызывающего объекта в вызываемый объект.</summary>
		// Token: 0x04002CA0 RID: 11424
		IDLFLAG_FIN = 1,
		/// <summary>Этот параметр возвращает сведения из вызываемого объекта в вызывающий объект.</summary>
		// Token: 0x04002CA1 RID: 11425
		IDLFLAG_FOUT = 2,
		/// <summary>Этот параметр является локальным идентификатором клиентского приложения.</summary>
		// Token: 0x04002CA2 RID: 11426
		IDLFLAG_FLCID = 4,
		/// <summary>Этот параметр является значением, возвращаемым членом.</summary>
		// Token: 0x04002CA3 RID: 11427
		IDLFLAG_FRETVAL = 8
	}
}
