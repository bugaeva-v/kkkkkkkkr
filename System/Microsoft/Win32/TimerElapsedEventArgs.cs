using System;
using System.Security.Permissions;

namespace Microsoft.Win32
{
	/// <summary>Предоставляет данные для события <see cref="E:Microsoft.Win32.SystemEvents.TimerElapsed" />.</summary>
	// Token: 0x0200012B RID: 299
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public class TimerElapsedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.TimerElapsedEventArgs" />.</summary>
		/// <param name="timerId">Номер идентификатора таймера.</param>
		// Token: 0x06000701 RID: 1793 RVA: 0x00013847 File Offset: 0x00011A47
		public TimerElapsedEventArgs(IntPtr timerId)
		{
			this.mytimerId = timerId;
		}

		/// <summary>Возвращает номер идентификатора для таймера.</summary>
		/// <returns>Номер идентификатора таймера.</returns>
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00013856 File Offset: 0x00011A56
		public IntPtr TimerId
		{
			get
			{
				return this.mytimerId;
			}
		}

		// Token: 0x040004E5 RID: 1253
		private IntPtr mytimerId;
	}
}
