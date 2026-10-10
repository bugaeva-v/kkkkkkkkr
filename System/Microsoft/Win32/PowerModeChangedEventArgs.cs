using System;
using System.Security.Permissions;

namespace Microsoft.Win32
{
	/// <summary>Предоставляет данные для события <see cref="E:Microsoft.Win32.SystemEvents.PowerModeChanged" />.</summary>
	// Token: 0x0200011F RID: 287
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public class PowerModeChangedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.PowerModeChangedEventArgs" />, используя заданный тип события режима питания.</summary>
		/// <param name="mode">Одно из значений <see cref="T:Microsoft.Win32.PowerModes" />, представляющее тип события режима питания.</param>
		// Token: 0x060006C5 RID: 1733 RVA: 0x00013694 File Offset: 0x00011894
		public PowerModeChangedEventArgs(PowerModes mode)
		{
			this.mymode = mode;
		}

		/// <summary>Возвращает идентификатор, определяющий тип возникающего события режима питания.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:Microsoft.Win32.PowerModes" />.</returns>
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x000136A3 File Offset: 0x000118A3
		public PowerModes Mode
		{
			get
			{
				return this.mymode;
			}
		}

		// Token: 0x040004CD RID: 1229
		private PowerModes mymode;
	}
}
