using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выдается, если в метод передается массив с неверным числом размерностей.</summary>
	// Token: 0x02000174 RID: 372
	[Serializable]
	public class RankException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.RankException" />.</summary>
		// Token: 0x06000EAE RID: 3758 RVA: 0x0003C131 File Offset: 0x0003A331
		public RankException() : base("Attempted to operate on an array with the incorrect number of dimensions.")
		{
			base.HResult = -2146233065;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.RankException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку.</param>
		// Token: 0x06000EAF RID: 3759 RVA: 0x0003C149 File Offset: 0x0003A349
		public RankException(string message) : base(message)
		{
			base.HResult = -2146233065;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.RankException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000EB0 RID: 3760 RVA: 0x0003C15D File Offset: 0x0003A35D
		public RankException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233065;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.RankException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000EB1 RID: 3761 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected RankException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
