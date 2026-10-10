using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Предоставляет сведения о пользовательском канале, передающиеся по <see cref="T:System.Runtime.Remoting.ObjRef" />.</summary>
	// Token: 0x0200055C RID: 1372
	[ComVisible(true)]
	public interface IChannelInfo
	{
		/// <summary>Получает или задает данные канала для каждого канала.</summary>
		/// <returns>Канал данных для каждого канала.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственно вызывающий объект вызывает интерфейс через ссылку и не имеет разрешения на использование инфраструктуры.</exception>
		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060035E0 RID: 13792
		// (set) Token: 0x060035E1 RID: 13793
		object[] ChannelData { get; set; }
	}
}
