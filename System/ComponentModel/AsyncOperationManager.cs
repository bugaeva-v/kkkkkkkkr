using System;
using System.Threading;

namespace System.ComponentModel
{
	/// <summary>Обеспечивает управление параллелизмом для классов, поддерживающих вызовы асинхронных методов. Этот класс не наследуется.</summary>
	// Token: 0x02000362 RID: 866
	public static class AsyncOperationManager
	{
		/// <summary>Возвращает объект <see cref="T:System.ComponentModel.AsyncOperation" /> для контроля длительности конкретной асинхронной операции.</summary>
		/// <param name="userSuppliedState">Объект, используемый для связи элемента состояния клиента, например идентификатора задачи, с конкретной асинхронной операцией.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.AsyncOperation" />, который можно использовать для контроля длительности вызова асинхронного метода.</returns>
		// Token: 0x06001CBA RID: 7354 RVA: 0x00067B07 File Offset: 0x00065D07
		public static AsyncOperation CreateOperation(object userSuppliedState)
		{
			return AsyncOperation.CreateOperation(userSuppliedState, AsyncOperationManager.SynchronizationContext);
		}

		/// <summary>Получает или задает контекст синхронизации для асинхронной операции.</summary>
		/// <returns>Контекст синхронизации для асинхронной операции.</returns>
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x00067B14 File Offset: 0x00065D14
		// (set) Token: 0x06001CBC RID: 7356 RVA: 0x00067B2C File Offset: 0x00065D2C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static SynchronizationContext SynchronizationContext
		{
			get
			{
				if (SynchronizationContext.Current == null)
				{
					SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());
				}
				return SynchronizationContext.Current;
			}
			set
			{
				SynchronizationContext.SetSynchronizationContext(value);
			}
		}
	}
}
