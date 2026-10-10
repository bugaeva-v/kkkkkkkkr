using System;

namespace System.Runtime.ConstrainedExecution
{
	/// <summary>Гарантирует, что весь код завершения в производных классах помечен как критический.</summary>
	// Token: 0x020007D7 RID: 2007
	public abstract class CriticalFinalizerObject
	{
		/// <summary>Освобождает все ресурсы, используемые классом <see cref="T:System.Runtime.ConstrainedExecution.CriticalFinalizerObject" />.</summary>
		// Token: 0x060045B7 RID: 17847 RVA: 0x000E5138 File Offset: 0x000E3338
		~CriticalFinalizerObject()
		{
		}
	}
}
