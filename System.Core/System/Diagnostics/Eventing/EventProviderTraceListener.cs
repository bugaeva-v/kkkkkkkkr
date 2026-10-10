using System;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing
{
	/// <summary>
	///         Прослушиватель для <see cref="T:System.Diagnostics.TraceSource" /> который записывает события ETW подсистем.
	///       </summary>
	// Token: 0x02000396 RID: 918
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class EventProviderTraceListener : TraceListener
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.EventProviderTraceListener" /> класса с помощью указанного поставщика идентификатора.
		///       </summary>
		/// <param name="providerId">
		///           Уникальная строка <see cref="T:System.Guid" /> определяющий поставщика.
		///         </param>
		// Token: 0x06001B68 RID: 7016 RVA: 0x0000235B File Offset: 0x0000055B
		public EventProviderTraceListener(string providerId)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.EventProviderTraceListener" /> с использованием указанного поставщика идентификатор и имя прослушивателя.
		///       </summary>
		/// <param name="providerId">
		///           Уникальная строка <see cref="T:System.Guid" /> определяющий поставщика.
		///         </param>
		/// <param name="name">
		///           Имя прослушивателя.
		///         </param>
		// Token: 0x06001B69 RID: 7017 RVA: 0x0000235B File Offset: 0x0000055B
		public EventProviderTraceListener(string providerId, string name)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.Eventing.EventProviderTraceListener" /> класса, используя идентификатор указанного поставщика имя прослушивателя и разделитель.
		///       </summary>
		/// <param name="providerId">
		///           Уникальная строка <see cref="T:System.Guid" /> определяющий поставщика.
		///         </param>
		/// <param name="name">
		///           Имя прослушивателя.
		///         </param>
		/// <param name="delimiter">
		///           Разделитель, используемый для разделения данных события.
		///            (Дополнительные сведения см. в разделе <see cref="P:System.Diagnostics.Eventing.EventProviderTraceListener.Delimiter" /> Свойства.)
		///         </param>
		// Token: 0x06001B6A RID: 7018 RVA: 0x0000235B File Offset: 0x0000055B
		public EventProviderTraceListener(string providerId, string name, string delimiter)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает и задает разделитель, используемый для разделения данных события, которые записываются в подсистему ETW.
		///       </summary>
		/// <returns>
		///         Разделитель, используемый для разделения данных события.
		///          Разделителем по умолчанию является запятая.
		///       </returns>
		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0000235B File Offset: 0x0000055B
		public string Delimiter
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>
		///         Если переопределено в производном классе, записывает заданное сообщение в прослушиватель, создаваемый в производном классе.
		///       </summary>
		/// <param name="message">
		///           Записываемое сообщение.
		///         </param>
		// Token: 0x06001B6D RID: 7021 RVA: 0x0000235B File Offset: 0x0000055B
		public sealed override void Write(string message)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Если переопределено в производном классе, записывает сообщение, заканчивающееся знаком завершения строки, в прослушиватель, создаваемый в производном классе.
		///       </summary>
		/// <param name="message">
		///           Записываемое сообщение.
		///         </param>
		// Token: 0x06001B6E RID: 7022 RVA: 0x0000235B File Offset: 0x0000055B
		public sealed override void WriteLine(string message)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
