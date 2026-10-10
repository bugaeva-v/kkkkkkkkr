using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Описывает порядок передачи элемента структуры, параметра или возвращаемого функцией значения из одного процесса в другой.</summary>
	// Token: 0x020007BA RID: 1978
	[Flags]
	[Serializable]
	public enum PARAMFLAG : short
	{
		/// <summary>Не задает, передает ли параметр сведения или получает их.</summary>
		// Token: 0x04002CA7 RID: 11431
		PARAMFLAG_NONE = 0,
		/// <summary>Параметр передает сведения из вызывающего объекта в вызываемый объект.</summary>
		// Token: 0x04002CA8 RID: 11432
		PARAMFLAG_FIN = 1,
		/// <summary>Этот параметр возвращает сведения из вызываемого объекта в вызывающий объект.</summary>
		// Token: 0x04002CA9 RID: 11433
		PARAMFLAG_FOUT = 2,
		/// <summary>Этот параметр является локальным идентификатором клиентского приложения.</summary>
		// Token: 0x04002CAA RID: 11434
		PARAMFLAG_FLCID = 4,
		/// <summary>Этот параметр является значением, возвращаемым членом.</summary>
		// Token: 0x04002CAB RID: 11435
		PARAMFLAG_FRETVAL = 8,
		/// <summary>Это необязательный параметр.</summary>
		// Token: 0x04002CAC RID: 11436
		PARAMFLAG_FOPT = 16,
		/// <summary>Для параметра определено поведение по умолчанию.</summary>
		// Token: 0x04002CAD RID: 11437
		PARAMFLAG_FHASDEFAULT = 32,
		/// <summary>Для параметра заданы пользовательские данные.</summary>
		// Token: 0x04002CAE RID: 11438
		PARAMFLAG_FHASCUSTDATA = 64
	}
}
