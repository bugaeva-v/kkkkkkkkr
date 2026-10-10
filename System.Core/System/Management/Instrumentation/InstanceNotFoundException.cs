using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Вызываемое исключение, которое указывает на отсутствие экземпляров, возвращаемых поставщиком.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000376 RID: 886
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public class InstanceNotFoundException : InstrumentationException
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса InstanceNotFoundException.
		///       </summary>
		// Token: 0x06001AEE RID: 6894 RVA: 0x0000235B File Offset: 0x0000055B
		public InstanceNotFoundException()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса InstanceNotFoundException с указанными сведениями о сериализации и контекстом потоковой передачи.
		///       </summary>
		/// <param name="info">
		///           SerializationInfo, содержащий все данные, необходимые для сериализации исключения.
		///         </param>
		/// <param name="context">
		///           StreamingContext, указывающий источник и назначение потока.
		///         </param>
		// Token: 0x06001AEF RID: 6895 RVA: 0x0000235B File Offset: 0x0000055B
		protected InstanceNotFoundException(SerializationInfo info, StreamingContext context)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса InstanceNotFoundException со строкой сообщения, заданным для сообщения.
		///       </summary>
		/// <param name="message">
		///           Строка, содержащая сообщение об ошибке с объяснением причин исключения.
		///         </param>
		// Token: 0x06001AF0 RID: 6896 RVA: 0x0000235B File Offset: 0x0000055B
		public InstanceNotFoundException(string message)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса InstanceNotFoundException с указанным сообщением об ошибке и внутренним исключением.
		///       </summary>
		/// <param name="message">
		///           Строка, содержащая сообщение об ошибке с объяснением причин исключения.
		///         </param>
		/// <param name="innerException">
		///           Исключение, вызвавшее текущее исключение.
		///         </param>
		// Token: 0x06001AF1 RID: 6897 RVA: 0x0000235B File Offset: 0x0000055B
		public InstanceNotFoundException(string message, Exception innerException)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
