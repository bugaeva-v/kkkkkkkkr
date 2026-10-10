using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Предоставляет способ управления асинхронными сообщениями после их отправки с помощью <see cref="M:System.Runtime.Remoting.Messaging.IMessageSink.AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage,System.Runtime.Remoting.Messaging.IMessageSink)" />.</summary>
	// Token: 0x0200061C RID: 1564
	[ComVisible(true)]
	public interface IMessageCtrl
	{
		/// <summary>Отменяет асинхронный вызов.</summary>
		/// <param name="msToCancel">Время (в миллисекундах), по истечении которого отменяется сообщение.</param>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x06003AF9 RID: 15097
		void Cancel(int msToCancel);
	}
}
