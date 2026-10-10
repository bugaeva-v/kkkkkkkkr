using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Содержит данные о связи, передаваемые между объединенными приемниками сообщений.</summary>
	// Token: 0x0200061B RID: 1563
	[ComVisible(true)]
	public interface IMessage
	{
		/// <summary>Возвращает <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщений.</summary>
		/// <returns>Словарь, представляющий коллекцию свойств сообщений.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06003AF8 RID: 15096
		IDictionary Properties { get; }
	}
}
