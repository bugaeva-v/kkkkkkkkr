using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, выбрасываемое при попытке доступа к выгруженному домену приложения.</summary>
	// Token: 0x020001C7 RID: 455
	[Serializable]
	public class AppDomainUnloadedException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AppDomainUnloadedException" />.</summary>
		// Token: 0x060013A5 RID: 5029 RVA: 0x0004E4A5 File Offset: 0x0004C6A5
		public AppDomainUnloadedException() : base("Attempted to access an unloaded AppDomain.")
		{
			base.HResult = -2146234348;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AppDomainUnloadedException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x060013A6 RID: 5030 RVA: 0x0004E4BD File Offset: 0x0004C6BD
		public AppDomainUnloadedException(string message) : base(message)
		{
			base.HResult = -2146234348;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AppDomainUnloadedException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем NULL, текущее исключение возникло в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060013A7 RID: 5031 RVA: 0x0004E4D1 File Offset: 0x0004C6D1
		public AppDomainUnloadedException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146234348;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AppDomainUnloadedException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x060013A8 RID: 5032 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected AppDomainUnloadedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04001446 RID: 5190
		internal const int COR_E_APPDOMAINUNLOADED = -2146234348;
	}
}
