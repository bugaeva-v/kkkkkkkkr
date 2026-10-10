using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Представляет базовое исключение, связанное с поставщиком.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000378 RID: 888
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public class InstrumentationBaseException : Exception
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Management.Instrumentation.InstrumentationBaseException" />.
		///          .
		///          Это конструктор по умолчанию.
		///       </summary>
		// Token: 0x06001AF7 RID: 6903 RVA: 0x0000235B File Offset: 0x0000055B
		public InstrumentationBaseException()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Management.Instrumentation.InstrumentationBaseException" /> класс со сведениями о сериализации.
		///       </summary>
		/// <param name="info">
		///           Данные, необходимые для сериализации или десериализации объекта.
		///         </param>
		/// <param name="context">
		///           Описание источника и назначения заданного сериализованного потока.
		///         </param>
		// Token: 0x06001AF8 RID: 6904 RVA: 0x0000235B File Offset: 0x0000055B
		protected InstrumentationBaseException(SerializationInfo info, StreamingContext context)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Management.Instrumentation.InstrumentationBaseException" /> класса сообщение, описывающее исключение.
		///       </summary>
		/// <param name="message">
		///           Сообщение с описанием исключения.
		///         </param>
		// Token: 0x06001AF9 RID: 6905 RVA: 0x0000235B File Offset: 0x0000055B
		public InstrumentationBaseException(string message)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый <see cref="T:System.Management.Instrumentation.InstrumentationBaseException" /> класса с заданной строкой и исключением.
		///       </summary>
		/// <param name="message">
		///           Сообщение с описанием исключения.
		///         </param>
		/// <param name="innerException">
		///           Экземпляр исключения, вызвавший текущее исключение.
		///         </param>
		// Token: 0x06001AFA RID: 6906 RVA: 0x0000235B File Offset: 0x0000055B
		public InstrumentationBaseException(string message, Exception innerException)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
