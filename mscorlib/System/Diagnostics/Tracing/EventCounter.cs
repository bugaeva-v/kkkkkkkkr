using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Предоставляет возможность сбора статистики по очень часто возникающим событиям с помощью класса <see cref="T:System.Diagnostics.Tracing.EventSource" />.</summary>
	// Token: 0x020009EF RID: 2543
	public class EventCounter : DiagnosticCounter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventCounter" />.</summary>
		/// <param name="name">Имя счетчика событий.</param>
		/// <param name="eventSource">Источник события.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="eventSource" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005AB9 RID: 23225 RVA: 0x0013445C File Offset: 0x0013265C
		public EventCounter(string name, EventSource eventSource) : base(name, eventSource)
		{
		}

		/// <summary>Записывает метрики, если включены счетчики производительности.</summary>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06005ABA RID: 23226 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void WriteMetric(float value)
		{
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void WriteMetric(double value)
		{
		}
	}
}
