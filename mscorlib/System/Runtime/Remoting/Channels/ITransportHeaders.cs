using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Хранит коллекцию заголовков, используемых в приемниках канала.</summary>
	// Token: 0x020005C4 RID: 1476
	[ComVisible(true)]
	public interface ITransportHeaders
	{
		/// <summary>Возвращает или задает транспортный заголовок, связанный с указанным ключом.</summary>
		/// <param name="key">Ключ, с которым связан запрошенный транспортный заголовок.</param>
		/// <returns>Транспортный заголовок, связанный с заданным ключом.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000809 RID: 2057
		object this[object key]
		{
			get;
			set;
		}

		/// <summary>Возвращает перечислитель <see cref="T:System.Collections.IEnumerator" />, проводящий итерации по всем записям объекта <see cref="T:System.Runtime.Remoting.Channels.ITransportHeaders" />.</summary>
		/// <returns>Перечислитель <see cref="T:System.Collections.IEnumerator" />, проводящий итерации по всем записям объекта <see cref="T:System.Runtime.Remoting.Channels.ITransportHeaders" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x0600389F RID: 14495
		IEnumerator GetEnumerator();
	}
}
