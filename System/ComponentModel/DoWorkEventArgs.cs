using System;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для обработчика событий <see cref="E:System.ComponentModel.BackgroundWorker.DoWork" />.</summary>
	// Token: 0x02000413 RID: 1043
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public class DoWorkEventArgs : CancelEventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DoWorkEventArgs" />.</summary>
		/// <param name="argument">Определяет аргумент для асинхронной операции.</param>
		// Token: 0x060021B4 RID: 8628 RVA: 0x000734B4 File Offset: 0x000716B4
		public DoWorkEventArgs(object argument)
		{
			this.argument = argument;
		}

		/// <summary>Возвращает значение, представляющее аргумент асинхронной операции.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий аргумент асинхронной операции.</returns>
		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x000734C3 File Offset: 0x000716C3
		[SRDescription("Argument passed into the worker handler from BackgroundWorker.RunWorkerAsync.")]
		public object Argument
		{
			get
			{
				return this.argument;
			}
		}

		/// <summary>Получает или задает значение, представляющее результат асинхронной операции.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий результат асинхронной операции.</returns>
		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x000734CB File Offset: 0x000716CB
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x000734D3 File Offset: 0x000716D3
		[SRDescription("Result from the worker function.")]
		public object Result
		{
			get
			{
				return this.result;
			}
			set
			{
				this.result = value;
			}
		}

		// Token: 0x04001025 RID: 4133
		private object result;

		// Token: 0x04001026 RID: 4134
		private object argument;
	}
}
