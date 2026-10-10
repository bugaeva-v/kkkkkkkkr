using System;
using System.Security.Permissions;

namespace Microsoft.Win32
{
	/// <summary>Предоставляет данные для события <see cref="E:Microsoft.Win32.SystemEvents.SessionSwitch" />.</summary>
	// Token: 0x02000127 RID: 295
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public class SessionSwitchEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.SessionSwitchEventArgs" />, используя заданный идентификатор типа события изменения сеанса.</summary>
		/// <param name="reason">Причина <see cref="T:Microsoft.Win32.SessionSwitchReason" />, показывающая тип события изменения сеанса.</param>
		// Token: 0x060006D9 RID: 1753 RVA: 0x000136EA File Offset: 0x000118EA
		public SessionSwitchEventArgs(SessionSwitchReason reason)
		{
			this.reason = reason;
		}

		/// <summary>Возвращает идентификатор, показывающий тип события изменения сеанса.</summary>
		/// <returns>Объект <see cref="T:Microsoft.Win32.SessionSwitchReason" />, показывающий тип события изменения сеанса.</returns>
		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x000136F9 File Offset: 0x000118F9
		public SessionSwitchReason Reason
		{
			get
			{
				return this.reason;
			}
		}

		// Token: 0x040004D8 RID: 1240
		private SessionSwitchReason reason;
	}
}
