using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Служит базовым классом для пространства имен системных исключений.</summary>
	// Token: 0x0200018E RID: 398
	[Serializable]
	public class SystemException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.SystemException" />.</summary>
		// Token: 0x06000FC8 RID: 4040 RVA: 0x000419FA File Offset: 0x0003FBFA
		public SystemException() : base("System error.")
		{
			base.HResult = -2146233087;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.SystemException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06000FC9 RID: 4041 RVA: 0x00041A12 File Offset: 0x0003FC12
		public SystemException(string message) : base(message)
		{
			base.HResult = -2146233087;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.SystemException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000FCA RID: 4042 RVA: 0x00041A26 File Offset: 0x0003FC26
		public SystemException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233087;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.SystemException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000FCB RID: 4043 RVA: 0x00020FA7 File Offset: 0x0001F1A7
		protected SystemException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
