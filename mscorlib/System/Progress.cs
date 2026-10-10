using System;
using System.Threading;

namespace System
{
	/// <summary>Предоставляет <see cref="T:System.IProgress`1" />, вызывающий обратные вызовы для каждого заявленного значения хода выполнения.</summary>
	/// <typeparam name="T">Указывает тип значения отчета о ходе выполнения.</typeparam>
	// Token: 0x02000170 RID: 368
	public class Progress<T> : IProgress<T>
	{
		/// <summary>Выполняет инициализацию объекта <see cref="T:System.Progress`1" />.</summary>
		// Token: 0x06000E8D RID: 3725 RVA: 0x0003BA21 File Offset: 0x00039C21
		public Progress()
		{
			this._synchronizationContext = (SynchronizationContext.Current ?? ProgressStatics.DefaultContext);
			this._invokeHandlers = new SendOrPostCallback(this.InvokeHandlers);
		}

		/// <summary>Инициализирует объект <see cref="T:System.Progress`1" /> с указанным обратным вызовом.</summary>
		/// <param name="handler">Обработчик, который необходимо вызывать для каждого сообщаемого значения хода выполнения. Этот обработчик вызывается в дополнение ко всем делегатам, зарегистрированным с событием <see cref="E:System.Progress`1.ProgressChanged" />. В зависимости от экземпляра <see cref="T:System.Threading.SynchronizationContext" />, перехваченного <see cref="T:System.Progress`1" /> при конструировании, возможно, что этот экземпляр обработчика может быть вызван синхронно с самим собой.</param>
		// Token: 0x06000E8E RID: 3726 RVA: 0x0003BA4F File Offset: 0x00039C4F
		public Progress(Action<T> handler) : this()
		{
			if (handler == null)
			{
				throw new ArgumentNullException("handler");
			}
			this._handler = handler;
		}

		/// <summary>Вызывается для каждого зафиксированного значения хода выполнения.</summary>
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000E8F RID: 3727 RVA: 0x0003BA6C File Offset: 0x00039C6C
		// (remove) Token: 0x06000E90 RID: 3728 RVA: 0x0003BAA4 File Offset: 0x00039CA4
		public event EventHandler<T> ProgressChanged;

		/// <summary>Сообщает об изменении хода выполнения.</summary>
		/// <param name="value">Значение обновленного хода выполнения.</param>
		// Token: 0x06000E91 RID: 3729 RVA: 0x0003BADC File Offset: 0x00039CDC
		protected virtual void OnReport(T value)
		{
			bool handler = this._handler != null;
			EventHandler<T> progressChanged = this.ProgressChanged;
			if (handler || progressChanged != null)
			{
				this._synchronizationContext.Post(this._invokeHandlers, value);
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0003BB12 File Offset: 0x00039D12
		void IProgress<!0>.Report(T value)
		{
			this.OnReport(value);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0003BB1C File Offset: 0x00039D1C
		private void InvokeHandlers(object state)
		{
			T t = (T)((object)state);
			Action<T> handler = this._handler;
			EventHandler<T> progressChanged = this.ProgressChanged;
			if (handler != null)
			{
				handler(t);
			}
			if (progressChanged != null)
			{
				progressChanged(this, t);
			}
		}

		// Token: 0x040012BF RID: 4799
		private readonly SynchronizationContext _synchronizationContext;

		// Token: 0x040012C0 RID: 4800
		private readonly Action<T> _handler;

		// Token: 0x040012C1 RID: 4801
		private readonly SendOrPostCallback _invokeHandlers;
	}
}
