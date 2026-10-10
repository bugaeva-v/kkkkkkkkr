using System;
using System.Runtime.Serialization;

namespace System.Diagnostics.Tracing
{
	/// <summary>Исключение, которое вызывается при возникновении ошибки во время трассировки событий Windows (ETW).</summary>
	// Token: 0x020009E4 RID: 2532
	[Serializable]
	public class EventSourceException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventSourceException" />.</summary>
		// Token: 0x06005A8F RID: 23183 RVA: 0x001342D0 File Offset: 0x001324D0
		public EventSourceException() : base("An error occurred when writing to a listener.")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventSourceException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06005A90 RID: 23184 RVA: 0x000328A2 File Offset: 0x00030AA2
		public EventSourceException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventSourceException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или значение <see langword="null" />, если внутреннее исключение не задано.</param>
		// Token: 0x06005A91 RID: 23185 RVA: 0x000328AB File Offset: 0x00030AAB
		public EventSourceException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventSourceException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06005A92 RID: 23186 RVA: 0x00020FA7 File Offset: 0x0001F1A7
		protected EventSourceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x001342DD File Offset: 0x001324DD
		internal EventSourceException(Exception innerException) : base("An error occurred when writing to a listener.", innerException)
		{
		}
	}
}
