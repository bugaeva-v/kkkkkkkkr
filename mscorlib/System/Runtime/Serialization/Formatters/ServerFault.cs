using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;

namespace System.Runtime.Serialization.Formatters
{
	/// <summary>Содержит сведения серверной неисправности. Этот класс не наследуется.</summary>
	// Token: 0x02000681 RID: 1665
	[SoapType(Embedded = true)]
	[ComVisible(true)]
	[Serializable]
	public sealed class ServerFault
	{
		// Token: 0x06003DEE RID: 15854 RVA: 0x000D5C5D File Offset: 0x000D3E5D
		internal ServerFault(Exception exception)
		{
			this.exception = exception;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Formatters.ServerFault" />.</summary>
		/// <param name="exceptionType">Тип исключения, произошедшего на сервере.</param>
		/// <param name="message">Сообщение, сопровождавшее исключение.</param>
		/// <param name="stackTrace">Трассировка стека потока, выведшая исключение на сервер.</param>
		// Token: 0x06003DEF RID: 15855 RVA: 0x000D5C6C File Offset: 0x000D3E6C
		public ServerFault(string exceptionType, string message, string stackTrace)
		{
			this.exceptionType = exceptionType;
			this.message = message;
			this.stackTrace = stackTrace;
		}

		/// <summary>Получает или задает тип исключения, созданного сервером.</summary>
		/// <returns>Тип исключения, созданного сервером.</returns>
		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x000D5C89 File Offset: 0x000D3E89
		// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x000D5C91 File Offset: 0x000D3E91
		public string ExceptionType
		{
			get
			{
				return this.exceptionType;
			}
			set
			{
				this.exceptionType = value;
			}
		}

		/// <summary>Получает или задает сообщение, сопровождающее созданное на сервере исключение.</summary>
		/// <returns>Сообщение, сопровождающее созданное на сервере исключение.</returns>
		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06003DF2 RID: 15858 RVA: 0x000D5C9A File Offset: 0x000D3E9A
		// (set) Token: 0x06003DF3 RID: 15859 RVA: 0x000D5CA2 File Offset: 0x000D3EA2
		public string ExceptionMessage
		{
			get
			{
				return this.message;
			}
			set
			{
				this.message = value;
			}
		}

		/// <summary>Получает или задает трассировку стека потока, выводящую исключение на сервер.</summary>
		/// <returns>Трассировка стека потока, выведшая исключение на сервер.</returns>
		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06003DF4 RID: 15860 RVA: 0x000D5CAB File Offset: 0x000D3EAB
		// (set) Token: 0x06003DF5 RID: 15861 RVA: 0x000D5CB3 File Offset: 0x000D3EB3
		public string StackTrace
		{
			get
			{
				return this.stackTrace;
			}
			set
			{
				this.stackTrace = value;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x000D5CBC File Offset: 0x000D3EBC
		internal Exception Exception
		{
			get
			{
				return this.exception;
			}
		}

		// Token: 0x040027B3 RID: 10163
		private string exceptionType;

		// Token: 0x040027B4 RID: 10164
		private string message;

		// Token: 0x040027B5 RID: 10165
		private string stackTrace;

		// Token: 0x040027B6 RID: 10166
		private Exception exception;
	}
}
