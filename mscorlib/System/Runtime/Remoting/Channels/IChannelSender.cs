using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Предоставляет требуемые функции и свойства для каналов отправителя.</summary>
	// Token: 0x020005B6 RID: 1462
	[ComVisible(true)]
	public interface IChannelSender : IChannel
	{
		/// <summary>Возвращает приемник сообщений канала, который доставляет сообщения объекту данных канала или по указанному URL-адресу.</summary>
		/// <param name="url">URL-адрес, по которому новый сток доставляет сообщения. Может принимать значение <see langword="null" />.</param>
		/// <param name="remoteChannelData">Объект данных канала удаленного узла, по которому новый сток доставляет сообщения. Может принимать значение <see langword="null" />.</param>
		/// <param name="objectURI">Когда метод возвращает управление, содержит URI нового приемника сообщений канала, который доставляет сообщения объекту данных канала или по указанному URL-адресу. Этот параметр передается неинициализированным.</param>
		/// <returns>Приемник сообщений канала, который доставляет сообщения объекту канала данных, по указанному URL-адресу или <see langword="null" />, если канал не может подключиться к данному каналу.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x0600387D RID: 14461
		IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
	}
}
