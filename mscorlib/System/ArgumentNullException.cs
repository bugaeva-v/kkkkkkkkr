using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое создается при передаче пустой ссылки (<see langword="Nothing" /> в Visual Basic) методу, который не принимает ее как допустимый аргумент.</summary>
	// Token: 0x020000F4 RID: 244
	[Serializable]
	public class ArgumentNullException : ArgumentException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentNullException" />.</summary>
		// Token: 0x06000707 RID: 1799 RVA: 0x000210B4 File Offset: 0x0001F2B4
		public ArgumentNullException() : base("Value cannot be null.")
		{
			base.HResult = -2147467261;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentNullException" /> именем параметра, вызвавшего исключение.</summary>
		/// <param name="paramName">Имя параметра, вызвавшего данное исключение.</param>
		// Token: 0x06000708 RID: 1800 RVA: 0x000210CC File Offset: 0x0001F2CC
		public ArgumentNullException(string paramName) : base("Value cannot be null.", paramName)
		{
			base.HResult = -2147467261;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentNullException" /> с заданным сообщением об ошибке и ссылкой на внутреннее исключение, которое стало причиной данного исключения.</summary>
		/// <param name="message">Сообщение об ошибке с объяснением причины исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x06000709 RID: 1801 RVA: 0x000210E5 File Offset: 0x0001F2E5
		public ArgumentNullException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		/// <summary>Инициализирует экземпляр класса <see cref="T:System.ArgumentNullException" /> с указанным сообщением об ошибке и именем параметра, который является причиной возникновения данного исключения.</summary>
		/// <param name="paramName">Имя параметра, вызвавшего данное исключение.</param>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x0600070A RID: 1802 RVA: 0x000210FA File Offset: 0x0001F2FA
		public ArgumentNullException(string paramName, string message) : base(message, paramName)
		{
			base.HResult = -2147467261;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ArgumentNullException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Объект, описывающий источник или цель сериализованных данных.</param>
		// Token: 0x0600070B RID: 1803 RVA: 0x0002110F File Offset: 0x0001F30F
		protected ArgumentNullException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
