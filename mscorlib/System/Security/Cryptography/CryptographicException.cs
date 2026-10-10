using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Microsoft.Win32;

namespace System.Security.Cryptography
{
	/// <summary>Исключение, которое возникает в случае ошибки при выполнении криптографической операции.</summary>
	// Token: 0x02000483 RID: 1155
	[ComVisible(true)]
	[Serializable]
	public class CryptographicException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicException" /> стандартными свойствами.</summary>
		// Token: 0x06002E95 RID: 11925 RVA: 0x000A687B File Offset: 0x000A4A7B
		public CryptographicException() : base(Environment.GetResourceString("Error occurred during a cryptographic operation."))
		{
			base.SetErrorCode(-2146233296);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06002E96 RID: 11926 RVA: 0x000A6898 File Offset: 0x000A4A98
		public CryptographicException(string message) : base(message)
		{
			base.SetErrorCode(-2146233296);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicException" /> указанным сообщением об ошибке в заданном формате.</summary>
		/// <param name="format">Формат, используемый для вывода сообщения об ошибке.</param>
		/// <param name="insert">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06002E97 RID: 11927 RVA: 0x000A68AC File Offset: 0x000A4AAC
		public CryptographicException(string format, string insert) : base(string.Format(CultureInfo.CurrentCulture, format, insert))
		{
			base.SetErrorCode(-2146233296);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06002E98 RID: 11928 RVA: 0x000A68CB File Offset: 0x000A4ACB
		public CryptographicException(string message, Exception inner) : base(message, inner)
		{
			base.SetErrorCode(-2146233296);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicException" /> заданным кодом ошибки <see langword="HRESULT" />.</summary>
		/// <param name="hr">Код ошибки <see langword="HRESULT" />.</param>
		// Token: 0x06002E99 RID: 11929 RVA: 0x000A68E0 File Offset: 0x000A4AE0
		[SecuritySafeCritical]
		public CryptographicException(int hr) : this(Win32Native.GetMessage(hr))
		{
			if (((long)hr & (long)((ulong)-2147483648)) != (long)((ulong)-2147483648))
			{
				hr = ((hr & 65535) | -2147024896);
			}
			base.SetErrorCode(hr);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CryptographicException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06002E9A RID: 11930 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected CryptographicException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x000A6915 File Offset: 0x000A4B15
		private static void ThrowCryptographicException(int hr)
		{
			throw new CryptographicException(hr);
		}

		// Token: 0x04002142 RID: 8514
		private const int FORMAT_MESSAGE_IGNORE_INSERTS = 512;

		// Token: 0x04002143 RID: 8515
		private const int FORMAT_MESSAGE_FROM_SYSTEM = 4096;

		// Token: 0x04002144 RID: 8516
		private const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;
	}
}
