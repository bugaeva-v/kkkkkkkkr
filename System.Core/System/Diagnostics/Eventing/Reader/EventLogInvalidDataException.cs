using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Представляет исключение, вызываемое при публикации поставщиком недопустимых данных в событии.
	///       </summary>
	// Token: 0x020003A3 RID: 931
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public class EventLogInvalidDataException : EventLogException
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.Reader.EventLogInvalidDataException" />.
		///       </summary>
		// Token: 0x06001BB6 RID: 7094 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogInvalidDataException()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.Reader.EventLogInvalidDataException" /> с сериализованными данными.
		///       </summary>
		/// <param name="serializationInfo">
		///           <see cref="T:System.Runtime.Serialization.SerializationInfo" /> Объект, содержащий сериализованные данные объекта о вызванном исключении.
		///         </param>
		/// <param name="streamingContext">
		///           Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.
		///         </param>
		// Token: 0x06001BB7 RID: 7095 RVA: 0x0000235B File Offset: 0x0000055B
		protected EventLogInvalidDataException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogInvalidDataException" /> класс, указав сообщение об ошибке, описывающее текущее исключение.
		///       </summary>
		/// <param name="message">
		///           Сообщение об ошибке, описывающее текущее исключение.
		///         </param>
		// Token: 0x06001BB8 RID: 7096 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogInvalidDataException(string message)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogInvalidDataException" /> класса ошибка сообщением и внутренним исключением.
		///       </summary>
		/// <param name="message">
		///           Сообщение об ошибке, описывающее текущее исключение.
		///         </param>
		/// <param name="innerException">
		///           Экземпляр исключения, вызвавший текущее исключение.
		///         </param>
		// Token: 0x06001BB9 RID: 7097 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogInvalidDataException(string message, Exception innerException)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
