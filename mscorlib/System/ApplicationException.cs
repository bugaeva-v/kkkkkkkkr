using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Служит базовым классом для определяемых приложением исключений.</summary>
	// Token: 0x020000F2 RID: 242
	[Serializable]
	public class ApplicationException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ApplicationException" />.</summary>
		// Token: 0x060006FA RID: 1786 RVA: 0x00020F66 File Offset: 0x0001F166
		public ApplicationException() : base("Error in the application.")
		{
			base.HResult = -2146232832;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ApplicationException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x060006FB RID: 1787 RVA: 0x00020F7E File Offset: 0x0001F17E
		public ApplicationException(string message) : base(message)
		{
			base.HResult = -2146232832;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ApplicationException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем NULL, текущее исключение возникло в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060006FC RID: 1788 RVA: 0x00020F92 File Offset: 0x0001F192
		public ApplicationException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232832;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ApplicationException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x060006FD RID: 1789 RVA: 0x00020FA7 File Offset: 0x0001F1A7
		protected ApplicationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
