using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Представляет базовый класс для всех исключений, которые вызываются при возникновении ошибки при чтении журнала событий сведения.
	///       </summary>
	// Token: 0x020003A2 RID: 930
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public class EventLogException : Exception
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.Reader.EventLogException" />.
		///       </summary>
		// Token: 0x06001BB1 RID: 7089 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogException()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogException" /> класса с кодом ошибки для исключения.
		///       </summary>
		/// <param name="errorCode">
		///           Сведения, связанные с код ошибки для ошибки, возникшей при чтении или настройке журнала событий.
		///            Дополнительные сведения и список журнала событий связанные коды в разделе http://go.microsoft.com/fwlink/?LinkId=82629.
		///         </param>
		// Token: 0x06001BB2 RID: 7090 RVA: 0x0000235B File Offset: 0x0000055B
		protected EventLogException(int errorCode)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.Reader.EventLogException" /> с сериализованными данными.
		///       </summary>
		/// <param name="serializationInfo">
		///           Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта по возникающему исключению.
		///         </param>
		/// <param name="streamingContext">
		///           Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.
		///         </param>
		// Token: 0x06001BB3 RID: 7091 RVA: 0x0000235B File Offset: 0x0000055B
		protected EventLogException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogException" /> класс, указав сообщение об ошибке, описывающее текущее исключение.
		///       </summary>
		/// <param name="message">
		///           Сообщение об ошибке, описывающее текущее исключение.
		///         </param>
		// Token: 0x06001BB4 RID: 7092 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogException(string message)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogException" /> класса ошибка сообщением и внутренним исключением.
		///       </summary>
		/// <param name="message">
		///           Сообщение об ошибке, описывающее текущее исключение.
		///         </param>
		/// <param name="innerException">
		///           Экземпляр исключения, вызвавший текущее исключение.
		///         </param>
		// Token: 0x06001BB5 RID: 7093 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogException(string message, Exception innerException)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
