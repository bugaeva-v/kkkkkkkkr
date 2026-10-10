using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Представляет исключение, которое возникает, когда произошла ошибка при чтении, запроса или подписки на события в журнале событий.
	///       </summary>
	// Token: 0x020003AD RID: 941
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public class EventLogReadingException : EventLogException
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.Reader.EventLogReadingException" />.
		///       </summary>
		// Token: 0x06001C03 RID: 7171 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogReadingException()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.Reader.EventLogReadingException" /> с сериализованными данными.
		///       </summary>
		/// <param name="serializationInfo">
		///           <see cref="T:System.Runtime.Serialization.SerializationInfo" /> Объект, содержащий сериализованные данные объекта о вызванном исключении.
		///         </param>
		/// <param name="streamingContext">
		///           Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.
		///         </param>
		// Token: 0x06001C04 RID: 7172 RVA: 0x0000235B File Offset: 0x0000055B
		protected EventLogReadingException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogReadingException" /> класс, указав сообщение об ошибке, описывающее текущее исключение.
		///       </summary>
		/// <param name="message">
		///           Сообщение об ошибке, описывающее текущее исключение.
		///         </param>
		// Token: 0x06001C05 RID: 7173 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogReadingException(string message)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogReadingException" /> класса ошибка сообщением и внутренним исключением.
		///       </summary>
		/// <param name="message">
		///           Сообщение об ошибке, описывающее текущее исключение.
		///         </param>
		/// <param name="innerException">
		///           Экземпляр исключения, вызвавший текущее исключение.
		///         </param>
		// Token: 0x06001C06 RID: 7174 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogReadingException(string message, Exception innerException)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
