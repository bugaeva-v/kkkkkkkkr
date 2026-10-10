using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Предоставляет каналы для сообщений, пересекающих границы удаленного взаимодействия.</summary>
	// Token: 0x020005B2 RID: 1458
	[ComVisible(true)]
	public interface IChannel
	{
		/// <summary>Возвращает имя канала.</summary>
		/// <returns>Имя канала.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x0600386F RID: 14447
		string ChannelName { get; }

		/// <summary>Возвращает приоритет канала.</summary>
		/// <returns>Целое число, обозначающее приоритет, назначенный данному каналу.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06003870 RID: 14448
		int ChannelPriority { get; }

		/// <summary>Возвращает URI-объект в качестве внешнего параметра и URI текущего канала в качестве возвращаемого значения.</summary>
		/// <param name="url">URL-адрес объекта.</param>
		/// <param name="objectURI">При возврате этого метода он содержит объект <see cref="T:System.String" />, в котором содержится объект URI. Этот параметр передается неинициализированным.</param>
		/// <returns>URI текущего канала или <see langword="null" />, если URI не принадлежит этому каналу.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003871 RID: 14449
		string Parse(string url, out string objectURI);
	}
}
