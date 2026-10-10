using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет исключение, которое выдается при создании ошибок с помощью компонента ADO.NET.</summary>
	// Token: 0x02000088 RID: 136
	[Serializable]
	public class DataException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DataException" /> с указанными сведениями о сериализации и контекстом.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Описание источника и назначения заданного сериализованного потока.</param>
		// Token: 0x060006D4 RID: 1748 RVA: 0x00010C10 File Offset: 0x0000EE10
		protected DataException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DataException" />. Это конструктор по умолчанию.</summary>
		// Token: 0x060006D5 RID: 1749 RVA: 0x0001A589 File Offset: 0x00018789
		public DataException() : base("Data Exception.")
		{
			base.HResult = -2146232032;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DataException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060006D6 RID: 1750 RVA: 0x0001A5A1 File Offset: 0x000187A1
		public DataException(string s) : base(s)
		{
			base.HResult = -2146232032;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DataException" />, используя заданную строку и внутреннее исключение.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		/// <param name="innerException">Ссылка на внутреннее исключение.</param>
		// Token: 0x060006D7 RID: 1751 RVA: 0x0001A5B5 File Offset: 0x000187B5
		public DataException(string s, Exception innerException) : base(s, innerException)
		{
		}
	}
}
