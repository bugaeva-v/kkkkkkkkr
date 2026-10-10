using System;
using System.Threading;

namespace System
{
	/// <summary>Представляет состояние асинхронной операции.</summary>
	// Token: 0x02000137 RID: 311
	public interface IAsyncResult
	{
		/// <summary>Возвращает значение, указывающее, выполнена ли асинхронная операция.</summary>
		/// <returns>Значение <see langword="true" />, если операция выполнена; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000BE4 RID: 3044
		bool IsCompleted { get; }

		/// <summary>Возвращает дескриптор <see cref="T:System.Threading.WaitHandle" />, используемый для ожидания завершения асинхронной операции.</summary>
		/// <returns>Дескриптор <see cref="T:System.Threading.WaitHandle" />, используемый для ожидания завершения асинхронной операции.</returns>
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000BE5 RID: 3045
		WaitHandle AsyncWaitHandle { get; }

		/// <summary>Получает определенный пользователем объект, который определяет или содержит сведения об асинхронной операции.</summary>
		/// <returns>Определенный пользователем объект, который определяет или содержит сведения об асинхронной операции.</returns>
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000BE6 RID: 3046
		object AsyncState { get; }

		/// <summary>Возвращает значение, указывающее, выполнялась ли асинхронная операция синхронно.</summary>
		/// <returns>Значение <see langword="true" />, если асинхронная операция выполнена синхронно, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000BE7 RID: 3047
		bool CompletedSynchronously { get; }
	}
}
