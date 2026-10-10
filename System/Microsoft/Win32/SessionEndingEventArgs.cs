using System;
using System.Security.Permissions;

namespace Microsoft.Win32
{
	/// <summary>Предоставляет данные для события <see cref="E:Microsoft.Win32.SystemEvents.SessionEnding" />.</summary>
	// Token: 0x02000125 RID: 293
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public class SessionEndingEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.SessionEndingEventArgs" />, используя заданное значение, показывающее тип произошедшего события закрытия сеанса.</summary>
		/// <param name="reason">Одна из причин <see cref="T:Microsoft.Win32.SessionEndReasons" />, задающая способ окончания сеанса.</param>
		// Token: 0x060006D1 RID: 1745 RVA: 0x000136C2 File Offset: 0x000118C2
		public SessionEndingEventArgs(SessionEndReasons reason)
		{
			this.myreason = reason;
		}

		/// <summary>Возвращает причину окончания сеанса.</summary>
		/// <returns>Одно из значений <see cref="T:Microsoft.Win32.SessionEndReasons" />, задающих способ окончания сеанса.</returns>
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x000136D1 File Offset: 0x000118D1
		public SessionEndReasons Reason
		{
			get
			{
				return this.myreason;
			}
		}

		/// <summary>Получает или задает значение, определяющее, отменяет ли пользователь запрос на окончание сеанса.</summary>
		/// <returns>Значение <see langword="true" />, чтобы отменить пользовательский запрос на окончание сеанса; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x000136D9 File Offset: 0x000118D9
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x000136E1 File Offset: 0x000118E1
		public bool Cancel
		{
			get
			{
				return this.mycancel;
			}
			set
			{
				this.mycancel = value;
			}
		}

		// Token: 0x040004D6 RID: 1238
		private SessionEndReasons myreason;

		// Token: 0x040004D7 RID: 1239
		private bool mycancel;
	}
}
