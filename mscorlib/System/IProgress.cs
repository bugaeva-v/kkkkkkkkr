using System;

namespace System
{
	/// <summary>Определяет поставщика обновлений хода выполнения.</summary>
	/// <typeparam name="T">Тип значения обновления хода выполнения.</typeparam>
	// Token: 0x02000143 RID: 323
	public interface IProgress<in T>
	{
		/// <summary>Сообщает об обновлении хода выполнения.</summary>
		/// <param name="value">Значение обновленного хода выполнения.</param>
		// Token: 0x06000C05 RID: 3077
		void Report(T value);
	}
}
