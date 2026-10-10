using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Создает приемники каналов сервера для канала сервера, через который передаются удаленные сообщения.</summary>
	// Token: 0x020005C0 RID: 1472
	[ComVisible(true)]
	public interface IServerChannelSinkProvider
	{
		/// <summary>Возвращает или задает следующего провайдера приемников в цепи поставщика приемника канала.</summary>
		/// <returns>Следующий поставщик в цепи поставщиков приемников канала.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06003892 RID: 14482
		// (set) Token: 0x06003893 RID: 14483
		IServerChannelSinkProvider Next { get; set; }

		/// <summary>Создает цепочку приемников.</summary>
		/// <param name="channel">Канал, для которого создается цепочка приемников каналов.</param>
		/// <returns>Первый приемник заново сформированной цепи канала или <see langword="null" />, указывающий, что этот поставщик не может обеспечить подключение для этой оконечной точки.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003894 RID: 14484
		IServerChannelSink CreateSink(IChannelReceiver channel);

		/// <summary>Возвращает данные канала для канала, с которым связан текущий приемник.</summary>
		/// <param name="channelData">Объект <see cref="T:System.Runtime.Remoting.Channels.IChannelDataStore" />, в который необходимо возвратить данные канала.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003895 RID: 14485
		void GetChannelData(IChannelDataStore channelData);
	}
}
