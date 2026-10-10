using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Создает оболочку для передачи данных удаленного взаимодействия между приемниками сообщений, либо для запросов от клиента к серверу, либо для последующих ответов.</summary>
	// Token: 0x02000623 RID: 1571
	[ComVisible(true)]
	public class InternalMessageWrapper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.InternalMessageWrapper" />.</summary>
		/// <param name="msg">Сообщение, действующее либо как исходящий вызов метода удаленного объекта, либо как последующий ответ.</param>
		// Token: 0x06003B15 RID: 15125 RVA: 0x000CE361 File Offset: 0x000CC561
		public InternalMessageWrapper(IMessage msg)
		{
			this.WrappedMessage = msg;
		}

		/// <summary>Представляет интерфейс запроса или ответа <see cref="T:System.Runtime.Remoting.Messaging.IMethodMessage" />, заключаемый в оболочку упаковщиком сообщений.</summary>
		// Token: 0x04002692 RID: 9874
		protected IMessage WrappedMessage;
	}
}
