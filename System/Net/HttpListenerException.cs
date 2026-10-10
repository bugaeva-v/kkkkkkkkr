using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Net
{
	/// <summary>Исключение, которое создается, когда происходит ошибка при обработке запроса HTTP.</summary>
	// Token: 0x020005CE RID: 1486
	[Serializable]
	public class HttpListenerException : Win32Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.HttpListenerException" />.</summary>
		// Token: 0x0600300E RID: 12302 RVA: 0x0007B700 File Offset: 0x00079900
		public HttpListenerException() : base(Marshal.GetLastWin32Error())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.HttpListenerException" />, используя указанный код ошибки.</summary>
		/// <param name="errorCode">Значение <see cref="T:System.Int32" />, идентифицирующее произошедшую ошибку.</param>
		// Token: 0x0600300F RID: 12303 RVA: 0x000A5C91 File Offset: 0x000A3E91
		public HttpListenerException(int errorCode) : base(errorCode)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.HttpListenerException" /> с указанным сообщением и кодом ошибки.</summary>
		/// <param name="errorCode">Значение <see cref="T:System.Int32" />, идентифицирующее произошедшую ошибку.</param>
		/// <param name="message">Значение типа <see cref="T:System.String" />, описывающее возникшую ошибку.</param>
		// Token: 0x06003010 RID: 12304 RVA: 0x000A5C9A File Offset: 0x000A3E9A
		public HttpListenerException(int errorCode, string message) : base(errorCode, message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.HttpListenerException" /> на основе указанных экземпляров классов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для десериализации нового объекта <see cref="T:System.Net.HttpListenerException" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x06003011 RID: 12305 RVA: 0x000A5CA4 File Offset: 0x000A3EA4
		protected HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Возвращает значение, идентифицирующее произошедшую ошибку.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />.</returns>
		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x000A5CAE File Offset: 0x000A3EAE
		public override int ErrorCode
		{
			get
			{
				return base.NativeErrorCode;
			}
		}
	}
}
