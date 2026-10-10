using System;
using Unity;

namespace System.Diagnostics
{
	/// <summary>Предоставляет данные для событий <see cref="E:System.Diagnostics.Process.OutputDataReceived" /> и <see cref="E:System.Diagnostics.Process.ErrorDataReceived" />.</summary>
	// Token: 0x02000250 RID: 592
	public class DataReceivedEventArgs : EventArgs
	{
		// Token: 0x0600123F RID: 4671 RVA: 0x0004EA54 File Offset: 0x0004CC54
		internal DataReceivedEventArgs(string data)
		{
			this.data = data;
		}

		/// <summary>Возвращает строку символов, записанную в перенаправленный поток вывода <see cref="T:System.Diagnostics.Process" />.</summary>
		/// <returns>Строка, записанная соответствующим процессом <see cref="T:System.Diagnostics.Process" /> в перенаправленный поток <see cref="P:System.Diagnostics.Process.StandardOutput" /> или <see cref="P:System.Diagnostics.Process.StandardError" />.</returns>
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x0004EA63 File Offset: 0x0004CC63
		public string Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal DataReceivedEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000A98 RID: 2712
		private string data;
	}
}
