using System;

namespace System.Runtime.ExceptionServices
{
	/// <summary>Предоставляет данные для события уведомления, возникающего при первом появлении управляемого исключения (прежде чем среда CLR начнет поиск обработчиков событий).</summary>
	// Token: 0x020007D0 RID: 2000
	public class FirstChanceExceptionEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs" /> с указанным исключением.</summary>
		/// <param name="exception">Исключение, только что выданное управляемым кодом, которое будет анализироваться событием <see cref="E:System.AppDomain.UnhandledException" />.</param>
		// Token: 0x060045A8 RID: 17832 RVA: 0x000E505F File Offset: 0x000E325F
		public FirstChanceExceptionEventArgs(Exception exception)
		{
			this.Exception = exception;
		}

		/// <summary>Объект управляемого исключения, соответствующее исключению, создаваемому в управляемом коде.</summary>
		/// <returns>Недавно выданное исключение.</returns>
		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x060045A9 RID: 17833 RVA: 0x000E506E File Offset: 0x000E326E
		public Exception Exception { get; }
	}
}
