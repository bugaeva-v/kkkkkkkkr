using System;

namespace System.Threading.Tasks
{
	/// <summary>Предоставляет данные для события, создаваемого, если происходит непредвиденное исключение задачи с ошибкой <see cref="T:System.Threading.Tasks.Task" />.</summary>
	// Token: 0x0200037D RID: 893
	public class UnobservedTaskExceptionEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Tasks.UnobservedTaskExceptionEventArgs" /> с непредвиденным исключением.</summary>
		/// <param name="exception">Непредвиденное исключение.</param>
		// Token: 0x06002532 RID: 9522 RVA: 0x000844AB File Offset: 0x000826AB
		public UnobservedTaskExceptionEventArgs(AggregateException exception)
		{
			this.m_exception = exception;
		}

		/// <summary>Присваивает свойству <see cref="P:System.Threading.Tasks.UnobservedTaskExceptionEventArgs.Exception" /> значение observed, не давая ему запускать политику роста исключений, которая по умолчанию прерывает процесс.</summary>
		// Token: 0x06002533 RID: 9523 RVA: 0x000844BA File Offset: 0x000826BA
		public void SetObserved()
		{
			this.m_observed = true;
		}

		/// <summary>Получает значение, указывающее, отмечено ли данное исключение как observed.</summary>
		/// <returns>Значение true, если исключение помечено как observed, в противном случае — значение false.</returns>
		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x000844C3 File Offset: 0x000826C3
		public bool Observed
		{
			get
			{
				return this.m_observed;
			}
		}

		/// <summary>Непредвиденное исключение.</summary>
		/// <returns>Непредвиденное исключение.</returns>
		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x000844CB File Offset: 0x000826CB
		public AggregateException Exception
		{
			get
			{
				return this.m_exception;
			}
		}

		// Token: 0x04001D57 RID: 7511
		private AggregateException m_exception;

		// Token: 0x04001D58 RID: 7512
		internal bool m_observed;
	}
}
