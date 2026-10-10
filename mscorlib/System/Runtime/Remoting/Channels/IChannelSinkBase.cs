using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Предоставляет основной интерфейс для приемников каналов.</summary>
	// Token: 0x020005B7 RID: 1463
	[ComVisible(true)]
	public interface IChannelSinkBase
	{
		/// <summary>Возвращает словарь, через который осуществляется доступ к свойствам приемника.</summary>
		/// <returns>Словарь, через который осуществляется доступ к свойствам приемника, или <see langword="null" />, если приемник канала не поддерживает свойств.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x0600387E RID: 14462
		IDictionary Properties { get; }
	}
}
