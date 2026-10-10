using System;
using Unity;

namespace System.Timers
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Timers.Timer.Elapsed" />.</summary>
	// Token: 0x02000195 RID: 405
	public class ElapsedEventArgs : EventArgs
	{
		// Token: 0x06000AA3 RID: 2723 RVA: 0x0002DC14 File Offset: 0x0002BE14
		internal ElapsedEventArgs(DateTime time)
		{
			this.time = time;
		}

		/// <summary>Получает дату и время <see cref="E:System.Timers.Timer.Elapsed" /> возникновения события.</summary>
		/// <returns>Время возникновения события <see cref="E:System.Timers.Timer.Elapsed" />.</returns>
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0002DC23 File Offset: 0x0002BE23
		public DateTime SignalTime
		{
			get
			{
				return this.time;
			}
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal ElapsedEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000721 RID: 1825
		private DateTime time;
	}
}
