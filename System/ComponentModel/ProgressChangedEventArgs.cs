using System;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для события <see cref="E:System.ComponentModel.BackgroundWorker.ProgressChanged" />.</summary>
	// Token: 0x0200041A RID: 1050
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public class ProgressChangedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ProgressChangedEventArgs" />.</summary>
		/// <param name="progressPercentage">Выполненный процент асинхронной задачи.</param>
		/// <param name="userState">Уникальное пользовательское состояние.</param>
		// Token: 0x060021EE RID: 8686 RVA: 0x000743B2 File Offset: 0x000725B2
		public ProgressChangedEventArgs(int progressPercentage, object userState)
		{
			this.progressPercentage = progressPercentage;
			this.userState = userState;
		}

		/// <summary>Возвращает процент выполнения асинхронной задачи.</summary>
		/// <returns>Значение в процентах, показывающее выполнение асинхронной задачи.</returns>
		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060021EF RID: 8687 RVA: 0x000743C8 File Offset: 0x000725C8
		[SRDescription("Percentage progress made in operation.")]
		public int ProgressPercentage
		{
			get
			{
				return this.progressPercentage;
			}
		}

		/// <summary>Возвращает уникальное пользовательское состояние.</summary>
		/// <returns>Уникальный объект <see cref="T:System.Object" />, показывающий пользовательское состояние.</returns>
		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x000743D0 File Offset: 0x000725D0
		[SRDescription("User-supplied state to identify operation.")]
		public object UserState
		{
			get
			{
				return this.userState;
			}
		}

		// Token: 0x04001037 RID: 4151
		private readonly int progressPercentage;

		// Token: 0x04001038 RID: 4152
		private readonly object userState;
	}
}
