using System;
using System.Collections.Generic;

namespace System.Diagnostics.Tracing
{
	/// <summary>Предоставляет аргументы для обратного вызова <see cref="M:System.Diagnostics.Tracing.EventSource.OnEventCommand(System.Diagnostics.Tracing.EventCommandEventArgs)" />.</summary>
	// Token: 0x020009EE RID: 2542
	public class EventCommandEventArgs : EventArgs
	{
		// Token: 0x06005AB4 RID: 23220 RVA: 0x00134454 File Offset: 0x00132654
		private EventCommandEventArgs()
		{
		}

		/// <summary>Получает массив аргументы для обратного вызова.</summary>
		/// <returns>Массив аргументов обратного вызова.</returns>
		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06005AB5 RID: 23221 RVA: 0x000479F8 File Offset: 0x00045BF8
		public IDictionary<string, string> Arguments
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает команду для обратного вызова.</summary>
		/// <returns>Команда обратного вызова.</returns>
		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06005AB6 RID: 23222 RVA: 0x000479F8 File Offset: 0x00045BF8
		public EventCommand Command
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Отключает событие, имеющее указанный идентификатор.</summary>
		/// <param name="eventId">Идентификатор события, которое требуется отключить.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="eventId" /> является диапазоном; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005AB7 RID: 23223 RVA: 0x000040F7 File Offset: 0x000022F7
		public bool DisableEvent(int eventId)
		{
			return true;
		}

		/// <summary>Включает событие, имеющее указанный идентификатор.</summary>
		/// <param name="eventId">Идентификатор события, которое требуется включить.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="eventId" /> является диапазоном; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005AB8 RID: 23224 RVA: 0x000040F7 File Offset: 0x000022F7
		public bool EnableEvent(int eventId)
		{
			return true;
		}
	}
}
