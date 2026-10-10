using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Определяет интерфейс для приемника сообщений.</summary>
	// Token: 0x0200061D RID: 1565
	[ComVisible(true)]
	public interface IMessageSink
	{
		/// <summary>Синхронно обрабатывает заданное сообщение.</summary>
		/// <param name="msg">Сообщение для обработки.</param>
		/// <returns>Ответное сообщение в ответ на запрос.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x06003AFA RID: 15098
		IMessage SyncProcessMessage(IMessage msg);

		/// <summary>Асинхронно обрабатывает заданное сообщение.</summary>
		/// <param name="msg">Сообщение для обработки.</param>
		/// <param name="replySink">Ответный приемник для ответного сообщения.</param>
		/// <returns>Интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMessageCtrl" />, который предоставляет способ управления асинхронными сообщениями после их отправки.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x06003AFB RID: 15099
		IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);

		/// <summary>Возвращает следующий приемник сообщений в цепочке приемников.</summary>
		/// <returns>Следующий приемник сообщений в цепочке приемников.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06003AFC RID: 15100
		IMessageSink NextSink { get; }
	}
}
