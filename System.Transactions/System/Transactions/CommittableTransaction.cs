using System;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Transactions
{
	/// <summary>Описывает фиксируемую транзакцию.</summary>
	// Token: 0x0200000A RID: 10
	[Serializable]
	public sealed class CommittableTransaction : Transaction, ISerializable, IDisposable, IAsyncResult
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.CommittableTransaction" />.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">Попытка создать транзакцию в системе Windows 98, Windows 98 Second Edition или Windows Millennium Edition.</exception>
		// Token: 0x0600000C RID: 12 RVA: 0x0000208C File Offset: 0x0000028C
		public CommittableTransaction() : this(default(TransactionOptions))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.CommittableTransaction" /> заданным значением <paramref name="timeout" />.</summary>
		/// <param name="timeout">Максимальное время, в течение которого может существовать транзакция до ее прерывания.</param>
		/// <exception cref="T:System.PlatformNotSupportedException">Попытка создать транзакцию в системе Windows 98, Windows 98 Second Edition или Windows Millennium Edition.</exception>
		// Token: 0x0600000D RID: 13 RVA: 0x000020A8 File Offset: 0x000002A8
		public CommittableTransaction(TimeSpan timeout) : base(IsolationLevel.Serializable)
		{
			this.options = default(TransactionOptions);
			this.options.Timeout = timeout;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.CommittableTransaction" /> с заданными параметрами транзакции.</summary>
		/// <param name="options">Структура <see cref="T:System.Transactions.TransactionOptions" /> с описанием параметров, которые должны использоваться для новой транзакции.</param>
		/// <exception cref="T:System.PlatformNotSupportedException">Попытка создать транзакцию в системе Windows 98, Windows 98 Second Edition или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> недопустим.</exception>
		// Token: 0x0600000E RID: 14 RVA: 0x000020C9 File Offset: 0x000002C9
		public CommittableTransaction(TransactionOptions options) : base(options.IsolationLevel)
		{
			this.options = options;
		}

		/// <summary>Начинает попытку зафиксировать транзакцию асинхронно.</summary>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который вызывается при завершении транзакции. Этот параметр может иметь значение <see langword="null" />. В этом случае приложение не уведомляется о завершении транзакции и должно использовать интерфейс <see cref="T:System.IAsyncResult" /> для проверки завершения и, соответственно, ждать или вызвать метод <see cref="M:System.Transactions.CommittableTransaction.EndCommit(System.IAsyncResult)" /> для ожидания завершения.</param>
		/// <param name="asyncState">Объект, который может содержать произвольную информацию о состоянии, связанную с асинхронной фиксацией. Этот объект передается обратному вызову и не интерпретируется инфраструктурой <see cref="N:System.Transactions" />. Допускается пустая ссылка.</param>
		/// <returns>Интерфейс <see cref="T:System.IAsyncResult" />, который может использоваться вызывающей стороной для проверки состояния асинхронной операции или ожидания завершения операции.</returns>
		// Token: 0x0600000F RID: 15 RVA: 0x000020E0 File Offset: 0x000002E0
		public IAsyncResult BeginCommit(AsyncCallback asyncCallback, object asyncState)
		{
			this.callback = asyncCallback;
			this.user_defined_state = asyncState;
			AsyncCallback asyncCallback2 = null;
			if (asyncCallback != null)
			{
				asyncCallback2 = new AsyncCallback(this.CommitCallback);
			}
			this.asyncResult = base.BeginCommitInternal(asyncCallback2);
			return this;
		}

		/// <summary>Завершает попытку зафиксировать транзакцию асинхронно.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, связанный с асинхронной фиксацией.</param>
		/// <exception cref="T:System.Transactions.TransactionAbortedException">Вызывается метод <see cref="M:System.Transactions.CommittableTransaction.BeginCommit(System.AsyncCallback,System.Object)" />, и выполняется первоначальный откат транзакции.</exception>
		// Token: 0x06000010 RID: 16 RVA: 0x0000211B File Offset: 0x0000031B
		public void EndCommit(IAsyncResult asyncResult)
		{
			if (asyncResult != this)
			{
				throw new ArgumentException("The IAsyncResult parameter must be the same parameter as returned by BeginCommit.", "asyncResult");
			}
			base.EndCommitInternal(this.asyncResult);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000213D File Offset: 0x0000033D
		private void CommitCallback(IAsyncResult ar)
		{
			if (this.asyncResult == null && ar.CompletedSynchronously)
			{
				this.asyncResult = ar;
			}
			this.callback(this);
		}

		/// <summary>Пытается зафиксировать транзакцию.</summary>
		/// <exception cref="T:System.Transactions.TransactionInDoubtException">В транзакции вызывается метод <see cref="M:System.Transactions.CommittableTransaction.Commit" />, и транзакция переходит в состояние <see cref="F:System.Transactions.TransactionStatus.InDoubt" />.</exception>
		/// <exception cref="T:System.Transactions.TransactionAbortedException">Вызывается метод <see cref="M:System.Transactions.CommittableTransaction.Commit" />, и выполняется первоначальный откат транзакции.</exception>
		// Token: 0x06000012 RID: 18 RVA: 0x00002162 File Offset: 0x00000362
		public void Commit()
		{
			base.CommitInternal();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO("Not implemented")]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает объект, предоставленный в качестве последнего параметра вызова метода <see cref="M:System.Transactions.CommittableTransaction.BeginCommit(System.AsyncCallback,System.Object)" />.</summary>
		/// <returns>Объект, предоставленный в качестве последнего параметра вызова метода <see cref="M:System.Transactions.CommittableTransaction.BeginCommit(System.AsyncCallback,System.Object)" />.</returns>
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002171 File Offset: 0x00000371
		object IAsyncResult.AsyncState
		{
			get
			{
				return this.user_defined_state;
			}
		}

		/// <summary>Возвращает дескриптор <see cref="T:System.Threading.WaitHandle" />, используемый для ожидания завершения асинхронной операции.</summary>
		/// <returns>Дескриптор <see cref="T:System.Threading.WaitHandle" />, используемый для ожидания завершения асинхронной операции.</returns>
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002179 File Offset: 0x00000379
		WaitHandle IAsyncResult.AsyncWaitHandle
		{
			get
			{
				return this.asyncResult.AsyncWaitHandle;
			}
		}

		/// <summary>Возвращает указатель, позволяющий определить, синхронно ли выполнена асинхронная операция фиксации.</summary>
		/// <returns>
		///   <see langword="true" />, если асинхронная операция фиксации выполнена синхронно; в противном случае — <see langword="false" />. Это свойство всегда возвращает значение <see langword="false" />, даже если операция выполнена синхронно.</returns>
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002186 File Offset: 0x00000386
		bool IAsyncResult.CompletedSynchronously
		{
			get
			{
				return this.asyncResult.CompletedSynchronously;
			}
		}

		/// <summary>Получает указатель, позволяющий определить, выполнена ли асинхронная операция фиксации.</summary>
		/// <returns>Значение <see langword="true" />, если операция выполнена; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002193 File Offset: 0x00000393
		bool IAsyncResult.IsCompleted
		{
			get
			{
				return this.asyncResult.IsCompleted;
			}
		}

		// Token: 0x0400002B RID: 43
		private TransactionOptions options;

		// Token: 0x0400002C RID: 44
		private AsyncCallback callback;

		// Token: 0x0400002D RID: 45
		private object user_defined_state;

		// Token: 0x0400002E RID: 46
		private IAsyncResult asyncResult;
	}
}
