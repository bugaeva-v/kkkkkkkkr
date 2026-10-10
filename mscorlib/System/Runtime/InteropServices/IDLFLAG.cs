using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IDLFLAG" />.</summary>
	// Token: 0x02000726 RID: 1830
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.IDLFLAG instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[Flags]
	[Serializable]
	public enum IDLFLAG : short
	{
		/// <summary>Не определено, передает ли параметр сведения или получает их.</summary>
		// Token: 0x04002B4C RID: 11084
		IDLFLAG_NONE = 0,
		/// <summary>Параметр передает сведения из вызывающего объекта в вызываемый объект.</summary>
		// Token: 0x04002B4D RID: 11085
		IDLFLAG_FIN = 1,
		/// <summary>Этот параметр возвращает сведения из вызываемого объекта в вызывающий объект.</summary>
		// Token: 0x04002B4E RID: 11086
		IDLFLAG_FOUT = 2,
		/// <summary>Этот параметр является локальным идентификатором клиентского приложения.</summary>
		// Token: 0x04002B4F RID: 11087
		IDLFLAG_FLCID = 4,
		/// <summary>Этот параметр является значением, возвращаемым членом.</summary>
		// Token: 0x04002B50 RID: 11088
		IDLFLAG_FRETVAL = 8
	}
}
