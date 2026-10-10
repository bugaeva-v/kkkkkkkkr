using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.PARAMFLAG" />.</summary>
	// Token: 0x02000728 RID: 1832
	[Flags]
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.PARAMFLAG instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[Serializable]
	public enum PARAMFLAG : short
	{
		/// <summary>Не определено, передает ли параметр сведения или получает их.</summary>
		// Token: 0x04002B54 RID: 11092
		PARAMFLAG_NONE = 0,
		/// <summary>Параметр передает сведения из вызывающего объекта в вызываемый объект.</summary>
		// Token: 0x04002B55 RID: 11093
		PARAMFLAG_FIN = 1,
		/// <summary>Этот параметр возвращает сведения из вызываемого объекта в вызывающий объект.</summary>
		// Token: 0x04002B56 RID: 11094
		PARAMFLAG_FOUT = 2,
		/// <summary>Этот параметр является локальным идентификатором клиентского приложения.</summary>
		// Token: 0x04002B57 RID: 11095
		PARAMFLAG_FLCID = 4,
		/// <summary>Этот параметр является значением, возвращаемым членом.</summary>
		// Token: 0x04002B58 RID: 11096
		PARAMFLAG_FRETVAL = 8,
		/// <summary>Это необязательный параметр.</summary>
		// Token: 0x04002B59 RID: 11097
		PARAMFLAG_FOPT = 16,
		/// <summary>Для параметра определено поведение по умолчанию.</summary>
		// Token: 0x04002B5A RID: 11098
		PARAMFLAG_FHASDEFAULT = 32,
		/// <summary>Для параметра заданы пользовательские данные.</summary>
		// Token: 0x04002B5B RID: 11099
		PARAMFLAG_FHASCUSTDATA = 64
	}
}
