using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Указывает, что используемый канал требуется подключить к службе внешнего слушателя.</summary>
	// Token: 0x020005B5 RID: 1461
	[ComVisible(true)]
	public interface IChannelReceiverHook
	{
		/// <summary>Возвращает тип слушателя, к которому нужно подключиться.</summary>
		/// <returns>Тип слушателя, к которому нужно подключиться (например, http).</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06003879 RID: 14457
		string ChannelScheme { get; }

		/// <summary>Возвращает цепь приемников канала, которая используется текущим каналом.</summary>
		/// <returns>Цепь приемников канала, которая используется текущим каналом.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x0600387A RID: 14458
		IServerChannelSink ChannelSinkChain { get; }

		/// <summary>Возвращает логическое значение, указывающее, нужно ли связать <see cref="T:System.Runtime.Remoting.Channels.IChannelReceiverHook" /> со службой внешнего слушателя.</summary>
		/// <returns>Логическое значение, указывающее, нужно ли связать <see cref="T:System.Runtime.Remoting.Channels.IChannelReceiverHook" /> со службой внешнего слушателя.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x0600387B RID: 14459
		bool WantsToListen { get; }

		/// <summary>Добавляет URI, в котором ловушка канала осуществляет прослушивание.</summary>
		/// <param name="channelUri">URI, в котором ловушка канала осуществляет прослушивание.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x0600387C RID: 14460
		void AddHookChannelUri(string channelUri);
	}
}
