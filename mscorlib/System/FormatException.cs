using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое возникает в случае, если формат аргумента недопустим или строка составного формата построена неправильно.</summary>
	// Token: 0x0200011B RID: 283
	[Serializable]
	public class FormatException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.FormatException" />.</summary>
		// Token: 0x06000AE2 RID: 2786 RVA: 0x000288A5 File Offset: 0x00026AA5
		public FormatException() : base("One of the identified items was in an invalid format.")
		{
			base.HResult = -2146233033;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.FormatException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06000AE3 RID: 2787 RVA: 0x000288BD File Offset: 0x00026ABD
		public FormatException(string message) : base(message)
		{
			base.HResult = -2146233033;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.FormatException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000AE4 RID: 2788 RVA: 0x000288D1 File Offset: 0x00026AD1
		public FormatException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233033;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.FormatException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000AE5 RID: 2789 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected FormatException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
