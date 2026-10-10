using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Представляет исключение, возникающее, если запрошенный журнал событий (обычно указывается имя журнала событий или путь к файлу журнала событий) не существует.
	///       </summary>
	// Token: 0x020003A5 RID: 933
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public class EventLogNotFoundException : EventLogException
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.Reader.EventLogNotFoundException" />.
		///       </summary>
		// Token: 0x06001BBE RID: 7102 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogNotFoundException()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Eventing.Reader.EventLogNotFoundException" /> с сериализованными данными.
		///       </summary>
		/// <param name="serializationInfo">
		///           <see cref="T:System.Runtime.Serialization.SerializationInfo" /> Объект, содержащий сериализованные данные объекта о вызванном исключении.
		///         </param>
		/// <param name="streamingContext">
		///           Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.
		///         </param>
		// Token: 0x06001BBF RID: 7103 RVA: 0x0000235B File Offset: 0x0000055B
		protected EventLogNotFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogNotFoundException" /> класс, указав сообщение об ошибке, описывающее текущее исключение.
		///       </summary>
		/// <param name="message">
		///           Сообщение об ошибке, описывающее текущее исключение.
		///         </param>
		// Token: 0x06001BC0 RID: 7104 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogNotFoundException(string message)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.Reader.EventLogNotFoundException" /> класса ошибка сообщением и внутренним исключением.
		///       </summary>
		/// <param name="message">
		///           Сообщение об ошибке, описывающее текущее исключение.
		///         </param>
		/// <param name="innerException">
		///           Экземпляр исключения, вызвавший текущее исключение.
		///         </param>
		// Token: 0x06001BC1 RID: 7105 RVA: 0x0000235B File Offset: 0x0000055B
		public EventLogNotFoundException(string message, Exception innerException)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
