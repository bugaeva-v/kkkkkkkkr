using System;
using System.Runtime.Serialization;

namespace System.Transactions
{
	/// <summary>Исключение, которое вызывается в двух случаях: а) при попытке выполнить операцию по транзакции, для которой уже был выполнен откат; б) когда делается попытка зафиксировать транзакцию, и транзакция прерывается.</summary>
	// Token: 0x0200001F RID: 31
	[Serializable]
	public class TransactionAbortedException : TransactionException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionAbortedException" />.</summary>
		// Token: 0x0600008A RID: 138 RVA: 0x00002B8A File Offset: 0x00000D8A
		public TransactionAbortedException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionAbortedException" /> указанным сообщением.</summary>
		/// <param name="message">Объект типа <see cref="T:System.String" />, содержащий сообщение с указанием причины исключения.</param>
		// Token: 0x0600008B RID: 139 RVA: 0x00002B92 File Offset: 0x00000D92
		public TransactionAbortedException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionAbortedException" /> указанным сообщением и внутренним исключением.</summary>
		/// <param name="message">Объект типа <see cref="T:System.String" />, содержащий сообщение с указанием причины исключения.</param>
		/// <param name="innerException">Получает экземпляр исключения, который вызывает текущее исключение. Дополнительные сведения см. в описании свойства <see cref="P:System.Exception.InnerException" />.</param>
		// Token: 0x0600008C RID: 140 RVA: 0x00002B9B File Offset: 0x00000D9B
		public TransactionAbortedException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionAbortedException" /> указанными сведениями о сериализации и потоковым контекстом.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с описанием неуспешной сериализации.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с описанием контекста неуспешной сериализации.</param>
		// Token: 0x0600008D RID: 141 RVA: 0x00002BA5 File Offset: 0x00000DA5
		protected TransactionAbortedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
