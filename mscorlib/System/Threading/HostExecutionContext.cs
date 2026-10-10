using System;

namespace System.Threading
{
	/// <summary>Инкапсулирует и распространяет контекст выполнения хоста по потокам.</summary>
	// Token: 0x020002EE RID: 750
	[MonoTODO("Useless until the runtime supports it")]
	public class HostExecutionContext : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.HostExecutionContext" />.</summary>
		// Token: 0x060020A8 RID: 8360 RVA: 0x0007697D File Offset: 0x00074B7D
		public HostExecutionContext()
		{
			this._state = null;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.HostExecutionContext" />, используя определенное состояние.</summary>
		/// <param name="state">Объект, представляющий состояние контекста выполнения хоста.</param>
		// Token: 0x060020A9 RID: 8361 RVA: 0x0007698C File Offset: 0x00074B8C
		public HostExecutionContext(object state)
		{
			this._state = state;
		}

		/// <summary>Создает копию текущего контекста выполнения хоста.</summary>
		/// <returns>Объект <see cref="T:System.Threading.HostExecutionContext" />, представляющий контекст хоста для текущего потока.</returns>
		// Token: 0x060020AA RID: 8362 RVA: 0x0007699B File Offset: 0x00074B9B
		public virtual HostExecutionContext CreateCopy()
		{
			return new HostExecutionContext(this._state);
		}

		/// <summary>Получает или задает состояние контекста выполнения хоста.</summary>
		/// <returns>Объект, представляющий состояние контекста выполнения хоста.</returns>
		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x000769A8 File Offset: 0x00074BA8
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x000769B0 File Offset: 0x00074BB0
		protected internal object State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Threading.HostExecutionContext" />.</summary>
		// Token: 0x060020AD RID: 8365 RVA: 0x000769B9 File Offset: 0x00074BB9
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>При переопределении в производном классе освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Threading.WaitHandle" />, и при необходимости освобождает управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x060020AE RID: 8366 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x04001B6C RID: 7020
		private object _state;
	}
}
