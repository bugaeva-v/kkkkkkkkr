using System;

namespace System.ComponentModel
{
	/// <summary>Определяет событие, возникающее при инициализации. Этот класс не наследуется.</summary>
	// Token: 0x02000373 RID: 883
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class InitializationEventAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InitializationEventAttribute" />.</summary>
		/// <param name="eventName">Имя события инициализации.</param>
		// Token: 0x06001D26 RID: 7462 RVA: 0x0006853F File Offset: 0x0006673F
		public InitializationEventAttribute(string eventName)
		{
			this.EventName = eventName;
		}

		/// <summary>Возвращает имя события инициализации.</summary>
		/// <returns>Имя события инициализации.</returns>
		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x0006854E File Offset: 0x0006674E
		public string EventName { get; }
	}
}
