using System;
using System.Security.Permissions;

namespace Microsoft.Win32
{
	/// <summary>Предоставляет данные для события <see cref="E:Microsoft.Win32.SystemEvents.SessionEnded" />.</summary>
	// Token: 0x02000123 RID: 291
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public class SessionEndedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.SessionEndedEventArgs" />.</summary>
		/// <param name="reason">Одно из значений <see cref="T:Microsoft.Win32.SessionEndReasons" />, показывающее, как закончен сеанс.</param>
		// Token: 0x060006CB RID: 1739 RVA: 0x000136AB File Offset: 0x000118AB
		public SessionEndedEventArgs(SessionEndReasons reason)
		{
			this.myreason = reason;
		}

		/// <summary>Возвращает идентификатор показывающий способ завершения сеанса.</summary>
		/// <returns>Одно из значений <see cref="T:Microsoft.Win32.SessionEndReasons" />, показывающее, как закончен сеанс.</returns>
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x000136BA File Offset: 0x000118BA
		public SessionEndReasons Reason
		{
			get
			{
				return this.myreason;
			}
		}

		// Token: 0x040004D5 RID: 1237
		private SessionEndReasons myreason;
	}
}
