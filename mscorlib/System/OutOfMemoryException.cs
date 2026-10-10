using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выбрасывается при недостаточном объеме памяти для выполнения программы.</summary>
	// Token: 0x020001D0 RID: 464
	[Serializable]
	public class OutOfMemoryException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OutOfMemoryException" />.</summary>
		// Token: 0x060013D7 RID: 5079 RVA: 0x0004EC48 File Offset: 0x0004CE48
		public OutOfMemoryException() : base("Insufficient memory to continue the execution of the program.")
		{
			base.HResult = -2147024882;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OutOfMemoryException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x060013D8 RID: 5080 RVA: 0x0004EC60 File Offset: 0x0004CE60
		public OutOfMemoryException(string message) : base(message)
		{
			base.HResult = -2147024882;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OutOfMemoryException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060013D9 RID: 5081 RVA: 0x0004EC74 File Offset: 0x0004CE74
		public OutOfMemoryException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024882;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OutOfMemoryException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x060013DA RID: 5082 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected OutOfMemoryException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
