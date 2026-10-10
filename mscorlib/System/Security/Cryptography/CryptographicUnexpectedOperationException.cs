using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security.Cryptography
{
	/// <summary>Исключение возникает при выполнении непредвиденной операции во время криптографической операции.</summary>
	// Token: 0x02000484 RID: 1156
	[ComVisible(true)]
	[Serializable]
	public class CryptographicUnexpectedOperationException : CryptographicException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException" /> стандартными свойствами.</summary>
		// Token: 0x06002E9C RID: 11932 RVA: 0x000A691D File Offset: 0x000A4B1D
		public CryptographicUnexpectedOperationException()
		{
			base.SetErrorCode(-2146233295);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06002E9D RID: 11933 RVA: 0x000A6930 File Offset: 0x000A4B30
		public CryptographicUnexpectedOperationException(string message) : base(message)
		{
			base.SetErrorCode(-2146233295);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException" /> указанным сообщением об ошибке в заданном формате.</summary>
		/// <param name="format">Формат, используемый для вывода сообщения об ошибке.</param>
		/// <param name="insert">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06002E9E RID: 11934 RVA: 0x000A6944 File Offset: 0x000A4B44
		public CryptographicUnexpectedOperationException(string format, string insert) : base(string.Format(CultureInfo.CurrentCulture, format, insert))
		{
			base.SetErrorCode(-2146233295);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06002E9F RID: 11935 RVA: 0x000A6963 File Offset: 0x000A4B63
		public CryptographicUnexpectedOperationException(string message, Exception inner) : base(message, inner)
		{
			base.SetErrorCode(-2146233295);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06002EA0 RID: 11936 RVA: 0x000A6978 File Offset: 0x000A4B78
		protected CryptographicUnexpectedOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
