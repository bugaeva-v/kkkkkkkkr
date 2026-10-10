using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Представляет исключение, возникающее, если указанное имя поставщика событий ссылается на отключенного поставщика событий.
	///          Отключенный поставщик событий не может публиковать события.
	///       </summary>
	// Token: 0x020003A7 RID: 935
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public class EventLogProviderDisabledException : EventLogException
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.Reader.EventLogProviderDisabledException" />.
		///       </summary>
		// Token: 0x06001BC5 RID: 7109 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogProviderDisabledException()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.Reader.EventLogProviderDisabledException" /> с сериализованными данными.
		///       </summary>
		/// <param name="serializationInfo">
		///           <see cref="T:System.Runtime.Serialization.SerializationInfo" /> Объект, содержащий сериализованные данные объекта о вызванном исключении.
		///         </param>
		/// <param name="streamingContext">
		///           Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.
		///         </param>
		// Token: 0x06001BC6 RID: 7110 RVA: 0x0000235B File Offset: 0x0000055B
		protected EventLogProviderDisabledException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogProviderDisabledException" /> класс, указав сообщение об ошибке, описывающее текущее исключение.
		///       </summary>
		/// <param name="message">
		///           Сообщение об ошибке, описывающее текущее исключение.
		///         </param>
		// Token: 0x06001BC7 RID: 7111 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogProviderDisabledException(string message)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogProviderDisabledException" /> класса ошибка сообщением и внутренним исключением.
		///       </summary>
		/// <param name="message">
		///           Сообщение об ошибке, описывающее текущее исключение.
		///         </param>
		/// <param name="innerException">
		///           Экземпляр исключения, вызвавший текущее исключение.
		///         </param>
		// Token: 0x06001BC8 RID: 7112 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogProviderDisabledException(string message, Exception innerException)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
