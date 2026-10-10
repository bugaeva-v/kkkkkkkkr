using System;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         При <see cref="E:System.Diagnostics.Eventing.Reader.EventLogWatcher.EventRecordWritten" /> события, экземпляр этого объекта передается в метод-делегат, обрабатывающий событие.
	///          Этот объект содержит событие, опубликованное в журнале событий или исключение, произошедшее при сбое подписки на событие.
	///       </summary>
	// Token: 0x020003B0 RID: 944
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class EventRecordWrittenEventArgs : EventArgs
	{
		// Token: 0x06001C31 RID: 7217 RVA: 0x0000235B File Offset: 0x0000055B
		internal EventRecordWrittenEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает исключение, произошедшее при сбое подписки на событие.
		///          Исключение имеет описание причин сбоя подписки.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Exception" /> объекта.
		///       </returns>
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x0005A05A File Offset: 0x0005825A
		public Exception EventException
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает запись события, опубликованную в журнале событий.
		///          Это событие соответствует критериям запроса, указанного в подписке на событие.
		///       </summary>
		/// <returns>
		///         Возвращает объект <see cref="T:System.Diagnostics.Eventing.Reader.EventRecord" />.
		///       </returns>
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x0005A05A File Offset: 0x0005825A
		public EventRecord EventRecord
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}
	}
}
