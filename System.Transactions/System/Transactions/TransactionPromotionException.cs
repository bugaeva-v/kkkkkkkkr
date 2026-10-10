using System;
using System.Runtime.Serialization;

namespace System.Transactions
{
	/// <summary>Исключение возникает при сбое преобразования.</summary>
	// Token: 0x02000028 RID: 40
	[Serializable]
	public class TransactionPromotionException : TransactionException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionPromotionException" />.</summary>
		// Token: 0x060000C0 RID: 192 RVA: 0x00002B8A File Offset: 0x00000D8A
		public TransactionPromotionException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionPromotionException" /> указанным сообщением.</summary>
		/// <param name="message">Объект типа <see cref="T:System.String" />, содержащий сообщение с указанием причины исключения.</param>
		// Token: 0x060000C1 RID: 193 RVA: 0x00002B92 File Offset: 0x00000D92
		public TransactionPromotionException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionPromotionException" /> указанным сообщением и внутренним исключением.</summary>
		/// <param name="message">Объект типа <see cref="T:System.String" />, содержащий сообщение с указанием причины исключения.</param>
		/// <param name="innerException">Получает экземпляр исключения, который вызывает текущее исключение. Дополнительные сведения см. в описании свойства <see cref="P:System.Exception.InnerException" />.</param>
		// Token: 0x060000C2 RID: 194 RVA: 0x00002B9B File Offset: 0x00000D9B
		public TransactionPromotionException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionPromotionException" /> указанными сведениями о сериализации и потоковым контекстом.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с описанием неуспешной сериализации.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с описанием контекста неуспешной сериализации.</param>
		// Token: 0x060000C3 RID: 195 RVA: 0x00002BA5 File Offset: 0x00000DA5
		protected TransactionPromotionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
