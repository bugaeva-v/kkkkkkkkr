using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Хранит данные канала для каналов удаленного взаимодействия.</summary>
	// Token: 0x020005B3 RID: 1459
	[ComVisible(true)]
	public interface IChannelDataStore
	{
		/// <summary>Возвращает массив URI, на который отображается текущий канал.</summary>
		/// <returns>Массив URI канала, на который отображается текущий канал.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06003872 RID: 14450
		string[] ChannelUris { get; }

		/// <summary>Возвращает или задает объект данных, связанный с указанным ключом для используемого канала.</summary>
		/// <param name="key">Ключ, с которым связан объект данных.</param>
		/// <returns>Указанный объект данных для используемого канала.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x170007FE RID: 2046
		object this[object key]
		{
			get;
			set;
		}
	}
}
