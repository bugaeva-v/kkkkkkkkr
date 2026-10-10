using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Представляет исключение, связанное с поставщиком.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000377 RID: 887
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public class InstrumentationException : InstrumentationBaseException
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Management.Instrumentation.InstrumentationException" />.
		///          Это конструктор по умолчанию.
		///       </summary>
		// Token: 0x06001AF2 RID: 6898 RVA: 0x0000235B File Offset: 0x0000055B
		public InstrumentationException()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый <see cref="T:System.Management.Instrumentation.InstrumentationException" /> класса System.Exception, который вызвал текущее исключение.
		///       </summary>
		/// <param name="innerException">
		///           Экземпляр исключения, вызвавший текущее исключение.
		///         </param>
		// Token: 0x06001AF3 RID: 6899 RVA: 0x0000235B File Offset: 0x0000055B
		public InstrumentationException(Exception innerException)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Management.Instrumentation.InstrumentationException" /> класс со сведениями о сериализации.
		///       </summary>
		/// <param name="info">
		///           Данные, необходимые для сериализации или десериализации объекта.
		///         </param>
		/// <param name="context">
		///           Описание источника и назначения заданного сериализованного потока.
		///         </param>
		// Token: 0x06001AF4 RID: 6900 RVA: 0x0000235B File Offset: 0x0000055B
		protected InstrumentationException(SerializationInfo info, StreamingContext context)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Management.Instrumentation.InstrumentationException" /> класса сообщение, описывающее исключение.
		///       </summary>
		/// <param name="message">
		///           Сообщение с описанием исключения.
		///         </param>
		// Token: 0x06001AF5 RID: 6901 RVA: 0x0000235B File Offset: 0x0000055B
		public InstrumentationException(string message)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый <see cref="T:System.Management.Instrumentation.InstrumentationException" /> класса с заданной строкой и исключением.
		///       </summary>
		/// <param name="message">
		///           Сообщение с описанием исключения.
		///         </param>
		/// <param name="innerException">
		///           Экземпляр исключения, вызвавший текущее исключение.
		///         </param>
		// Token: 0x06001AF6 RID: 6902 RVA: 0x0000235B File Offset: 0x0000055B
		public InstrumentationException(string message, Exception innerException)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
