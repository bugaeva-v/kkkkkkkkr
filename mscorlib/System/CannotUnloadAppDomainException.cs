using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, создаваемое при сбое попытки выгрузки домена приложения.</summary>
	// Token: 0x020001C9 RID: 457
	[Serializable]
	public class CannotUnloadAppDomainException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CannotUnloadAppDomainException" />.</summary>
		// Token: 0x060013B5 RID: 5045 RVA: 0x0004E7CC File Offset: 0x0004C9CC
		public CannotUnloadAppDomainException() : base("Attempt to unload the AppDomain failed.")
		{
			base.HResult = -2146234347;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CannotUnloadAppDomainException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку.</param>
		// Token: 0x060013B6 RID: 5046 RVA: 0x0004E7E4 File Offset: 0x0004C9E4
		public CannotUnloadAppDomainException(string message) : base(message)
		{
			base.HResult = -2146234347;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CannotUnloadAppDomainException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060013B7 RID: 5047 RVA: 0x0004E7F8 File Offset: 0x0004C9F8
		public CannotUnloadAppDomainException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146234347;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CannotUnloadAppDomainException" /> из сериализованных данных.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x060013B8 RID: 5048 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0400144C RID: 5196
		internal const int COR_E_CANNOTUNLOADAPPDOMAIN = -2146234347;
	}
}
