using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Предоставляет необходимые функции и свойства для каналов получателя.</summary>
	// Token: 0x020005B4 RID: 1460
	[ComVisible(true)]
	public interface IChannelReceiver : IChannel
	{
		/// <summary>Получает данные для указанного канала.</summary>
		/// <returns>Данные канала.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06003875 RID: 14453
		object ChannelData { get; }

		/// <summary>Возвращает массив всех URL-адресов для URI.</summary>
		/// <param name="objectURI">URI, для которого требуются URL-адреса.</param>
		/// <returns>Массив URL-адресов.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003876 RID: 14454
		string[] GetUrlsForUri(string objectURI);

		/// <summary>Дает текущему каналу команду на отслеживание запросов.</summary>
		/// <param name="data">Дополнительные сведения об инициализации.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003877 RID: 14455
		void StartListening(object data);

		/// <summary>Дает текущему каналу команду на прекращение отслеживания запросов.</summary>
		/// <param name="data">Дополнительные сведения о состоянии канала.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003878 RID: 14456
		void StopListening(object data);
	}
}
