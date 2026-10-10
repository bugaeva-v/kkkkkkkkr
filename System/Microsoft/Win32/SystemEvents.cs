using System;
using System.Collections;
using System.ComponentModel;
using System.Security.Permissions;
using System.Timers;

namespace Microsoft.Win32
{
	/// <summary>Предоставляет доступ к уведомлениям о системных событиях. Этот класс не наследуется.</summary>
	// Token: 0x0200012A RID: 298
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	public sealed class SystemEvents
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x0000219B File Offset: 0x0000039B
		private SystemEvents()
		{
		}

		/// <summary>Создает новый таймер окна, связанный с окном системных событий.</summary>
		/// <param name="interval">Определяет интервал между уведомлениями таймера, в миллисекундах.</param>
		/// <returns>Идентификатор нового таймера.</returns>
		/// <exception cref="T:System.ArgumentException">Интервал меньше или равен нулю.</exception>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий или попытка создания таймера закончилась неудачей.</exception>
		// Token: 0x060006E0 RID: 1760 RVA: 0x00013704 File Offset: 0x00011904
		public static IntPtr CreateTimer(int interval)
		{
			int hashCode = Guid.NewGuid().GetHashCode();
			Timer timer = new Timer((double)interval);
			timer.Elapsed += SystemEvents.InternalTimerElapsed;
			SystemEvents.TimerStore.Add(hashCode, timer);
			return new IntPtr(hashCode);
		}

		/// <summary>Завершает работу таймера, заданного идентификатором.</summary>
		/// <param name="timerId">Идентификатор таймера, работу которого нужно завершить.</param>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий или попытка завершения работы таймера закончилась неудачей.</exception>
		// Token: 0x060006E1 RID: 1761 RVA: 0x00013758 File Offset: 0x00011958
		public static void KillTimer(IntPtr timerId)
		{
			Timer timer = (Timer)SystemEvents.TimerStore[timerId.GetHashCode()];
			timer.Stop();
			timer.Elapsed -= SystemEvents.InternalTimerElapsed;
			timer.Dispose();
			SystemEvents.TimerStore.Remove(timerId.GetHashCode());
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000137B3 File Offset: 0x000119B3
		private static void InternalTimerElapsed(object e, ElapsedEventArgs args)
		{
			if (SystemEvents.TimerElapsed != null)
			{
				SystemEvents.TimerElapsed(null, new TimerElapsedEventArgs(IntPtr.Zero));
			}
		}

		/// <summary>Вызывает заданный делегат, используя поток, прослушивающий системные события.</summary>
		/// <param name="method">Делегат, вызываемый с помощью потока, прослушивающего системные события.</param>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x060006E3 RID: 1763 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public static void InvokeOnEventsThread(Delegate method)
		{
			throw new NotImplementedException();
		}

		/// <summary>Происходит, когда пользователь изменяет параметры дисплея.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060006E4 RID: 1764 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006E5 RID: 1765 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO]
		public static event EventHandler DisplaySettingsChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Происходит при изменении параметров дисплея.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060006E6 RID: 1766 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006E7 RID: 1767 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO("Currently does nothing on Mono")]
		public static event EventHandler DisplaySettingsChanging
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Происходит перед завершением потока, прослушивающего системные события.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060006E8 RID: 1768 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006E9 RID: 1769 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO("Currently does nothing on Mono")]
		public static event EventHandler EventsThreadShutdown
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Происходит, когда пользователь добавляет шрифты в систему или удаляет шрифты из системы.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060006EA RID: 1770 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006EB RID: 1771 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO("Currently does nothing on Mono")]
		public static event EventHandler InstalledFontsChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Происходит при недостатке оперативной памяти в системе.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060006EC RID: 1772 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006ED RID: 1773 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO("Currently does nothing on Mono")]
		[Browsable(false)]
		[Obsolete("")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static event EventHandler LowMemory
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Происходит, когда пользователь переходит к приложению, которое использует другую палитру.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060006EE RID: 1774 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006EF RID: 1775 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO("Currently does nothing on Mono")]
		public static event EventHandler PaletteChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Происходит, когда пользователь приостанавливает или возобновляет работу системы.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060006F0 RID: 1776 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006F1 RID: 1777 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO("Currently does nothing on Mono")]
		public static event PowerModeChangedEventHandler PowerModeChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Происходит, когда пользователь выходит из системы или завершает ее работу.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060006F2 RID: 1778 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006F3 RID: 1779 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO("Currently does nothing on Mono")]
		public static event SessionEndedEventHandler SessionEnded
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Происходит, когда пользователь пытается выйти из системы или завершить ее работу.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060006F4 RID: 1780 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006F5 RID: 1781 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO("Currently does nothing on Mono")]
		public static event SessionEndingEventHandler SessionEnding
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Происходит после смены текущего вошедшего в систему пользователя.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060006F6 RID: 1782 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006F7 RID: 1783 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO("Currently does nothing on Mono")]
		public static event SessionSwitchEventHandler SessionSwitch
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Происходит, когда пользователь изменяет время системных часов.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060006F8 RID: 1784 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006F9 RID: 1785 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO("Currently does nothing on Mono")]
		public static event EventHandler TimeChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Происходит, когда заканчивается интервал таймера Windows.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060006FA RID: 1786 RVA: 0x000137D4 File Offset: 0x000119D4
		// (remove) Token: 0x060006FB RID: 1787 RVA: 0x00013808 File Offset: 0x00011A08
		public static event TimerElapsedEventHandler TimerElapsed;

		/// <summary>Происходит после изменения пользовательских параметров.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060006FC RID: 1788 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006FD RID: 1789 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO("Currently does nothing on Mono")]
		public static event UserPreferenceChangedEventHandler UserPreferenceChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Происходит при изменении пользовательских параметров.</summary>
		/// <exception cref="T:System.InvalidOperationException">В текущем контексте уведомления о системных событиях не поддерживаются. Например, серверные процессы могут не поддерживать уведомлений о глобальных системных событиях.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.ExternalException">Попытка создания потока окна системных событий завершилась неудачей.</exception>
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060006FE RID: 1790 RVA: 0x00003917 File Offset: 0x00001B17
		// (remove) Token: 0x060006FF RID: 1791 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO("Currently does nothing on Mono")]
		public static event UserPreferenceChangingEventHandler UserPreferenceChanging
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x040004E3 RID: 1251
		private static Hashtable TimerStore = new Hashtable();
	}
}
