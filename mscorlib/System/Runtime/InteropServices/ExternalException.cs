using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>Базовый тип исключений для всех исключений COM-взаимодействия и исключений структурированной обработки исключений (SEH).</summary>
	// Token: 0x020006C4 RID: 1732
	[Serializable]
	public class ExternalException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="ExternalException" /> стандартными свойствами.</summary>
		// Token: 0x06003FD0 RID: 16336 RVA: 0x000DFD6C File Offset: 0x000DDF6C
		public ExternalException() : base("External component has thrown an exception.")
		{
			base.HResult = -2147467259;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="ExternalException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке с указанием причины возникновения исключения.</param>
		// Token: 0x06003FD1 RID: 16337 RVA: 0x000DFD84 File Offset: 0x000DDF84
		public ExternalException(string message) : base(message)
		{
			base.HResult = -2147467259;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ExternalException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06003FD2 RID: 16338 RVA: 0x000DFD98 File Offset: 0x000DDF98
		public ExternalException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2147467259;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="ExternalException" /> указанным сообщением об ошибке и значением HRESULT ошибки.</summary>
		/// <param name="message">Сообщение об ошибке с указанием причины возникновения исключения.</param>
		/// <param name="errorCode">Значение HRESULT ошибки.</param>
		// Token: 0x06003FD3 RID: 16339 RVA: 0x00032810 File Offset: 0x00030A10
		public ExternalException(string message, int errorCode) : base(message)
		{
			base.HResult = errorCode;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="ExternalException" />, используя данные сериализации.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003FD4 RID: 16340 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected ExternalException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Возвращает <see langword="HRESULT" /> ошибки.</summary>
		/// <returns>
		///   <see langword="HRESULT" /> ошибки.</returns>
		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06003FD5 RID: 16341 RVA: 0x000DFDAD File Offset: 0x000DDFAD
		public virtual int ErrorCode
		{
			get
			{
				return base.HResult;
			}
		}

		/// <summary>Возвращает строку, содержащую значение HRESULT ошибки.</summary>
		/// <returns>Строка, представляющая значение HRESULT.</returns>
		// Token: 0x06003FD6 RID: 16342 RVA: 0x000DFDB8 File Offset: 0x000DDFB8
		public override string ToString()
		{
			string message = this.Message;
			string text = base.GetType().ToString() + " (0x" + base.HResult.ToString("X8", CultureInfo.InvariantCulture) + ")";
			if (!string.IsNullOrEmpty(message))
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
