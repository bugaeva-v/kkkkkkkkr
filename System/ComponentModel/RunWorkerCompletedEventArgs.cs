using System;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для события MethodName<see langword="Completed" />.</summary>
	// Token: 0x0200041F RID: 1055
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.RunWorkerCompletedEventArgs" />.</summary>
		/// <param name="result">Результат асинхронной операции.</param>
		/// <param name="error">Любая ошибка, возникающая в ходе асинхронной операции.</param>
		/// <param name="cancelled">Значение, показывающее, была ли отменена асинхронная операция.</param>
		// Token: 0x06002255 RID: 8789 RVA: 0x000778A2 File Offset: 0x00075AA2
		public RunWorkerCompletedEventArgs(object result, Exception error, bool cancelled) : base(error, cancelled, null)
		{
			this.result = result;
		}

		/// <summary>Возвращает значение, представляющее результат асинхронной операции.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий результат асинхронной операции.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">
		///   <see cref="P:System.ComponentModel.AsyncCompletedEventArgs.Error" /> не является <see langword="null" />. Свойство <see cref="P:System.Exception.InnerException" /> содержит ссылку на ошибку <see cref="P:System.ComponentModel.AsyncCompletedEventArgs.Error" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Свойство <see cref="P:System.ComponentModel.AsyncCompletedEventArgs.Cancelled" /> имеет значение <see langword="true" />.</exception>
		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x000778B4 File Offset: 0x00075AB4
		public object Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this.result;
			}
		}

		/// <summary>Возвращает значение, представляющее состояние пользователя.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий состояние пользователя.</returns>
		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x000778C2 File Offset: 0x00075AC2
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new object UserState
		{
			get
			{
				return base.UserState;
			}
		}

		// Token: 0x0400106C RID: 4204
		private object result;
	}
}
