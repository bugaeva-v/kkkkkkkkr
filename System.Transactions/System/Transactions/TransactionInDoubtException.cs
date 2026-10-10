using System;
using System.Runtime.Serialization;

namespace System.Transactions
{
	/// <summary>Исключение, которое вызывается в двух случаях: а) при попытке выполнить операцию по транзакции, которая находится в состоянии InDoubt; б) когда делается попытка зафиксировать транзакцию, и транзакция переходит в состояние InDoubt.</summary>
	// Token: 0x02000022 RID: 34
	[Serializable]
	public class TransactionInDoubtException : TransactionException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionInDoubtException" />.</summary>
		// Token: 0x06000095 RID: 149 RVA: 0x00002B8A File Offset: 0x00000D8A
		public TransactionInDoubtException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionInDoubtException" /> указанным сообщением.</summary>
		/// <param name="message">Объект типа <see cref="T:System.String" />, содержащий сообщение с указанием причины исключения.</param>
		// Token: 0x06000096 RID: 150 RVA: 0x00002B92 File Offset: 0x00000D92
		public TransactionInDoubtException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionInDoubtException" /> указанным сообщением и внутренним исключением.</summary>
		/// <param name="message">Объект типа <see cref="T:System.String" />, содержащий сообщение с указанием причины исключения.</param>
		/// <param name="innerException">Получает экземпляр исключения, который вызывает текущее исключение. Дополнительные сведения см. в описании свойства <see cref="P:System.Exception.InnerException" />.</param>
		// Token: 0x06000097 RID: 151 RVA: 0x00002B9B File Offset: 0x00000D9B
		public TransactionInDoubtException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionInDoubtException" /> указанными сведениями о сериализации и потоковым контекстом.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с описанием неуспешной сериализации.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с описанием контекста неуспешной сериализации.</param>
		// Token: 0x06000098 RID: 152 RVA: 0x00002BA5 File Offset: 0x00000DA5
		protected TransactionInDoubtException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
