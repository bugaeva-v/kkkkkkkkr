using System;
using System.Reflection;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для события MethodName<see langword="Completed" />.</summary>
	// Token: 0x02000408 RID: 1032
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public class AsyncCompletedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AsyncCompletedEventArgs" />.</summary>
		// Token: 0x06002159 RID: 8537 RVA: 0x0000C759 File Offset: 0x0000A959
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public AsyncCompletedEventArgs()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AsyncCompletedEventArgs" />.</summary>
		/// <param name="error">Любая ошибка, возникающая в ходе асинхронной операции.</param>
		/// <param name="cancelled">Значение, показывающее, была ли отменена асинхронная операция.</param>
		/// <param name="userState">Необязательный заданный пользователем объект состояния, переданный методу <see cref="M:System.ComponentModel.BackgroundWorker.RunWorkerAsync(System.Object)" />.</param>
		// Token: 0x0600215A RID: 8538 RVA: 0x00072221 File Offset: 0x00070421
		public AsyncCompletedEventArgs(Exception error, bool cancelled, object userState)
		{
			this.error = error;
			this.cancelled = cancelled;
			this.userState = userState;
		}

		/// <summary>Возвращает значение, показывающее, была ли отменена асинхронная операция.</summary>
		/// <returns>Значение <see langword="true" />, если фоновая операция была отменена; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x0007223E File Offset: 0x0007043E
		[SRDescription("True if operation was cancelled.")]
		public bool Cancelled
		{
			get
			{
				return this.cancelled;
			}
		}

		/// <summary>Возвращает значение, показывающее, какая ошибка произошла в течение асинхронной операции.</summary>
		/// <returns>Экземпляр исключения <see cref="T:System.Exception" />, если в ходе асинхронной операции произошла ошибка; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x00072246 File Offset: 0x00070446
		[SRDescription("Exception that occurred during operation.  Null if no error.")]
		public Exception Error
		{
			get
			{
				return this.error;
			}
		}

		/// <summary>Возвращает уникальный идентификатор для асинхронной задачи.</summary>
		/// <returns>Ссылка на объект, уникальным образом идентифицирующая асинхронную задачу; в противном случае — значение <see langword="null" />, если значение не было задано.</returns>
		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x0007224E File Offset: 0x0007044E
		[SRDescription("User-supplied state to identify operation.")]
		public object UserState
		{
			get
			{
				return this.userState;
			}
		}

		/// <summary>Вызывает предоставленное пользователем исключение в случае неудачного выполнения асинхронной операции.</summary>
		/// <exception cref="T:System.InvalidOperationException">Значение свойства <see cref="P:System.ComponentModel.AsyncCompletedEventArgs.Cancelled" /> — <see langword="true" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Свойство <see cref="P:System.ComponentModel.AsyncCompletedEventArgs.Error" /> было установлено асинхронной операцией. Свойство <see cref="P:System.Exception.InnerException" /> содержит ссылку на ошибку <see cref="P:System.ComponentModel.AsyncCompletedEventArgs.Error" />.</exception>
		// Token: 0x0600215E RID: 8542 RVA: 0x00072256 File Offset: 0x00070456
		protected void RaiseExceptionIfNecessary()
		{
			if (this.Error != null)
			{
				throw new TargetInvocationException(SR.GetString("An exception occurred during the operation, making the result invalid.  Check InnerException for exception details."), this.Error);
			}
			if (this.Cancelled)
			{
				throw new InvalidOperationException(SR.GetString("Operation has been cancelled."));
			}
		}

		// Token: 0x04001001 RID: 4097
		private readonly Exception error;

		// Token: 0x04001002 RID: 4098
		private readonly bool cancelled;

		// Token: 0x04001003 RID: 4099
		private readonly object userState;
	}
}
