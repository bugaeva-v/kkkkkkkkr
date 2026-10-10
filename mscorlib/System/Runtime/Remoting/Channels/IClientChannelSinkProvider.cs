using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Создает приемники каналов клиента для канала клиента, через который передаются сообщения удаленного взаимодействия.</summary>
	// Token: 0x020005B9 RID: 1465
	[ComVisible(true)]
	public interface IClientChannelSinkProvider
	{
		/// <summary>Возвращает или задает следующего провайдера приемников в цепи поставщика приемника канала.</summary>
		/// <returns>Следующий поставщик в цепи поставщиков приемников канала.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06003884 RID: 14468
		// (set) Token: 0x06003885 RID: 14469
		IClientChannelSinkProvider Next { get; set; }

		/// <summary>Создает цепочку приемников.</summary>
		/// <param name="channel">Канал, для которого создается текущая цепь приемников.</param>
		/// <param name="url">URL-адрес объекта, к которому необходимо подключиться. Этот параметр может иметь значение <see langword="null" />, если подключение полностью основано на сведениях, содержащихся в параметре <paramref name="remoteChannelData" />.</param>
		/// <param name="remoteChannelData">Объект данных канала, описывающий канал на удаленном сервере.</param>
		/// <returns>Первый приемник заново сформированной цепи канала или <see langword="null" />, указывающий, что этот поставщик не может обеспечить подключение для этой оконечной точки.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003886 RID: 14470
		IClientChannelSink CreateSink(IChannelSender channel, string url, object remoteChannelData);
	}
}
