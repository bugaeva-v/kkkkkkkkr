using System;

namespace System.Threading
{
	/// <summary>Представляет внешние данные, локальные для данного асинхронного потока управления, такие как асинхронный метод.</summary>
	/// <typeparam name="T">Тип внешних данных.</typeparam>
	// Token: 0x02000281 RID: 641
	public sealed class AsyncLocal<T> : IAsyncLocal
	{
		/// <summary>Создает экземпляр экземпляра <see cref="T:System.Threading.AsyncLocal`1" />, который не получает уведомления об изменениях.</summary>
		// Token: 0x06001D5A RID: 7514 RVA: 0x0000259F File Offset: 0x0000079F
		public AsyncLocal()
		{
		}

		/// <summary>Создает экземпляр локального экземпляра <see cref="T:System.Threading.AsyncLocal`1" />, который получает уведомления об изменениях.</summary>
		/// <param name="valueChangedHandler">Делегат, который вызывается при каждом изменении текущего значения в любом потоке.</param>
		// Token: 0x06001D5B RID: 7515 RVA: 0x0006DA99 File Offset: 0x0006BC99
		public AsyncLocal(Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler)
		{
			this.m_valueChangedHandler = valueChangedHandler;
		}

		/// <summary>Получает или задает значение внешних данных.</summary>
		/// <returns>Значение внешних данных. Если значение не задано, возвращаемое значение — default(T).</returns>
		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x0006DAA8 File Offset: 0x0006BCA8
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x0006DACF File Offset: 0x0006BCCF
		public T Value
		{
			get
			{
				object localValue = ExecutionContext.GetLocalValue(this);
				if (localValue != null)
				{
					return (T)((object)localValue);
				}
				return default(T);
			}
			set
			{
				ExecutionContext.SetLocalValue(this, value, this.m_valueChangedHandler != null);
			}
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x0006DAE8 File Offset: 0x0006BCE8
		void IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged)
		{
			T previousValue = (previousValueObj == null) ? default(T) : ((T)((object)previousValueObj));
			T currentValue = (currentValueObj == null) ? default(T) : ((T)((object)currentValueObj));
			this.m_valueChangedHandler(new AsyncLocalValueChangedArgs<T>(previousValue, currentValue, contextChanged));
		}

		// Token: 0x04001A24 RID: 6692
		private readonly Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler;
	}
}
