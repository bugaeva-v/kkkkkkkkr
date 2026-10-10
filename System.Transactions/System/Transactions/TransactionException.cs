using System;
using System.Runtime.Serialization;

namespace System.Transactions
{
	/// <summary>Исключение, вызываемое при попытке выполнить операцию по транзакции, которая не может допустить новую операцию.</summary>
	// Token: 0x02000021 RID: 33
	[Serializable]
	public class TransactionException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionException" />.</summary>
		// Token: 0x06000091 RID: 145 RVA: 0x00002BCE File Offset: 0x00000DCE
		public TransactionException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionException" /> указанным сообщением.</summary>
		/// <param name="message">Объект типа <see cref="T:System.String" />, содержащий сообщение с указанием причины исключения.</param>
		// Token: 0x06000092 RID: 146 RVA: 0x00002BD6 File Offset: 0x00000DD6
		public TransactionException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionException" /> указанным сообщением и внутренним исключением.</summary>
		/// <param name="message">Объект типа <see cref="T:System.String" />, содержащий сообщение с указанием причины исключения.</param>
		/// <param name="innerException">Получает экземпляр исключения, который вызывает текущее исключение. Дополнительные сведения см. в описании свойства <see cref="P:System.Exception.InnerException" />.</param>
		// Token: 0x06000093 RID: 147 RVA: 0x00002BDF File Offset: 0x00000DDF
		public TransactionException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionException" /> указанными сведениями о сериализации и потоковым контекстом.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с описанием неуспешной сериализации.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с описанием контекста неуспешной сериализации.</param>
		// Token: 0x06000094 RID: 148 RVA: 0x00002BE9 File Offset: 0x00000DE9
		protected TransactionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
