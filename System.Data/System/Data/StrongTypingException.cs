using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Исключение, которое выдается строго типизированным объектом <see cref="T:System.Data.DataSet" />, когда пользователь получает доступ к значению <see langword="DBNull" />.</summary>
	// Token: 0x02000136 RID: 310
	[Serializable]
	public class StrongTypingException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.StrongTypingException" />, используя заданную информацию сериализации и контекст потоков.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</param>
		/// <param name="context">Структура <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x060010AF RID: 4271 RVA: 0x0001A5BF File Offset: 0x000187BF
		protected StrongTypingException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.StrongTypingException" />.</summary>
		// Token: 0x060010B0 RID: 4272 RVA: 0x00045C17 File Offset: 0x00043E17
		public StrongTypingException()
		{
			base.HResult = -2146232021;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.StrongTypingException" /> с заданной строкой.</summary>
		/// <param name="message">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060010B1 RID: 4273 RVA: 0x00045C2A File Offset: 0x00043E2A
		public StrongTypingException(string message) : base(message)
		{
			base.HResult = -2146232021;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.StrongTypingException" />, используя заданную строку и внутреннее исключение.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		/// <param name="innerException">Ссылка на внутреннее исключение.</param>
		// Token: 0x060010B2 RID: 4274 RVA: 0x00045C3E File Offset: 0x00043E3E
		public StrongTypingException(string s, Exception innerException) : base(s, innerException)
		{
			base.HResult = -2146232021;
		}
	}
}
