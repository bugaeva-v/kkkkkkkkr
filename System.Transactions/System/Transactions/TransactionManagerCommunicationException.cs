using System;
using System.Runtime.Serialization;

namespace System.Transactions
{
	/// <summary>Исключение возникает, если диспетчер ресурсов не может взаимодействовать с диспетчером транзакций.</summary>
	// Token: 0x02000026 RID: 38
	[Serializable]
	public class TransactionManagerCommunicationException : TransactionException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionManagerCommunicationException" />.</summary>
		// Token: 0x060000B3 RID: 179 RVA: 0x00002B8A File Offset: 0x00000D8A
		public TransactionManagerCommunicationException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionManagerCommunicationException" /> указанным сообщением.</summary>
		/// <param name="message">Объект типа <see cref="T:System.String" />, содержащий сообщение с указанием причины исключения.</param>
		// Token: 0x060000B4 RID: 180 RVA: 0x00002B92 File Offset: 0x00000D92
		public TransactionManagerCommunicationException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionManagerCommunicationException" /> указанным сообщением и внутренним исключением.</summary>
		/// <param name="message">Объект типа <see cref="T:System.String" />, содержащий сообщение с указанием причины исключения.</param>
		/// <param name="innerException">Получает экземпляр исключения, который вызывает текущее исключение. Дополнительные сведения см. в описании свойства <see cref="P:System.Exception.InnerException" />.</param>
		// Token: 0x060000B5 RID: 181 RVA: 0x00002B9B File Offset: 0x00000D9B
		public TransactionManagerCommunicationException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionManagerCommunicationException" /> указанными сведениями о сериализации и потоковым контекстом.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с описанием неуспешной сериализации.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с описанием контекста неуспешной сериализации.</param>
		// Token: 0x060000B6 RID: 182 RVA: 0x00002BA5 File Offset: 0x00000DA5
		protected TransactionManagerCommunicationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
