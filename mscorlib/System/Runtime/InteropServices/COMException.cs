using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>Исключение, которое выдается при возвращении неизвестного значения HRESULT после вызова метода COM.</summary>
	// Token: 0x020006D1 RID: 1745
	[Serializable]
	public class COMException : ExternalException
	{
		// Token: 0x06004021 RID: 16417 RVA: 0x000E0B35 File Offset: 0x000DED35
		internal COMException(int hr)
		{
			base.HResult = hr;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.COMException" /> со значениями по умолчанию.</summary>
		// Token: 0x06004022 RID: 16418 RVA: 0x000E0B44 File Offset: 0x000DED44
		public COMException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.COMException" /> с заданным сообщением.</summary>
		/// <param name="message">Сообщение, указывающее причину возникновения исключения.</param>
		// Token: 0x06004023 RID: 16419 RVA: 0x000E0B4C File Offset: 0x000DED4C
		public COMException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.COMException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06004024 RID: 16420 RVA: 0x000E0B55 File Offset: 0x000DED55
		public COMException(string message, Exception inner) : base(message, inner)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.COMException" />, используя заданное сообщение и код ошибки.</summary>
		/// <param name="message">Сообщение, указывающее причину возникновения исключения.</param>
		/// <param name="errorCode">Значение кода ошибки (HRESULT), связанное с этим исключением.</param>
		// Token: 0x06004025 RID: 16421 RVA: 0x000E0B5F File Offset: 0x000DED5F
		public COMException(string message, int errorCode) : base(message)
		{
			base.HResult = errorCode;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.COMException" />, используя данные сериализации.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, предоставляющий контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004026 RID: 16422 RVA: 0x000E0B6F File Offset: 0x000DED6F
		protected COMException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Преобразует содержимое исключения в строку.</summary>
		/// <returns>Строка, содержащая свойства <see cref="P:System.Exception.HResult" />, <see cref="P:System.Exception.Message" />, <see cref="P:System.Exception.InnerException" /> и <see cref="P:System.Exception.StackTrace" /> исключения.</returns>
		// Token: 0x06004027 RID: 16423 RVA: 0x000E0B7C File Offset: 0x000DED7C
		public override string ToString()
		{
			string message = this.Message;
			string text = base.GetType().ToString() + " (0x" + base.HResult.ToString("X8", CultureInfo.InvariantCulture) + ")";
			if (message != null && message.Length > 0)
			{
				text = text + ": " + message;
			}
			Exception innerException = base.InnerException;
			if (innerException != null)
			{
				text = text + " ---> " + innerException.ToString();
			}
			if (this.StackTrace != null)
			{
				text = text + Environment.NewLine + this.StackTrace;
			}
			return text;
		}
	}
}
