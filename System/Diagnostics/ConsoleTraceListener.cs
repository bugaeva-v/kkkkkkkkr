using System;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Направляет вывод отладки и трассировки в стандартный поток вывода или стандартный поток сообщений об ошибках.</summary>
	// Token: 0x02000213 RID: 531
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	public class ConsoleTraceListener : TextWriterTraceListener
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.ConsoleTraceListener" /> с записью выходных данных трассировки в стандартный поток вывода.</summary>
		// Token: 0x06000F4C RID: 3916 RVA: 0x00044B40 File Offset: 0x00042D40
		public ConsoleTraceListener() : base(Console.Out)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.ConsoleTraceListener" /> с возможностью записи выходных данных трассировки в стандартный поток вывода или стандартный поток ошибок.</summary>
		/// <param name="useErrorStream">Значение <see langword="true" /> для записи выходных данных отладки и трассировки в стандартный поток ошибок или значение <see langword="false" /> для записи выходных данных отладки и трассировки в стандартный поток вывода.</param>
		// Token: 0x06000F4D RID: 3917 RVA: 0x00044B4D File Offset: 0x00042D4D
		public ConsoleTraceListener(bool useErrorStream) : base(useErrorStream ? Console.Error : Console.Out)
		{
		}

		/// <summary>Закрывает выходные данные для потока, заданного для этого прослушивателя трассировки.</summary>
		// Token: 0x06000F4E RID: 3918 RVA: 0x00003917 File Offset: 0x00001B17
		public override void Close()
		{
		}
	}
}
