using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выдается, если вызываемый метод не поддерживается, или при попытке чтения, поиска или записи в поток, который не поддерживает вызванную функцию.</summary>
	// Token: 0x02000161 RID: 353
	[Serializable]
	public class NotSupportedException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotSupportedException" />, задавая в качестве значения свойства нового экземпляра <see cref="P:System.Exception.Message" /> системное сообщение с описанием ошибки. Это сообщение учитывает текущую культуру системы.</summary>
		// Token: 0x06000DE0 RID: 3552 RVA: 0x00035FBC File Offset: 0x000341BC
		public NotSupportedException() : base("Specified method is not supported.")
		{
			base.HResult = -2146233067;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotSupportedException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x06000DE1 RID: 3553 RVA: 0x00035FD4 File Offset: 0x000341D4
		public NotSupportedException(string message) : base(message)
		{
			base.HResult = -2146233067;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotSupportedException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем NULL, текущее исключение возникло в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000DE2 RID: 3554 RVA: 0x00035FE8 File Offset: 0x000341E8
		public NotSupportedException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233067;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.NotSupportedException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000DE3 RID: 3555 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected NotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
