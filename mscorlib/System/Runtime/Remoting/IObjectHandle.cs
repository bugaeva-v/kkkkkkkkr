using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Определяет интерфейс для распаковки объектов, маршалированных по значению, косвенного обращения.</summary>
	// Token: 0x0200055E RID: 1374
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("C460E2B4-E199-412a-8456-84DC3E4838C3")]
	public interface IObjectHandle
	{
		/// <summary>Развертывает объект.</summary>
		/// <returns>Развернутый объект.</returns>
		// Token: 0x060035E4 RID: 13796
		object Unwrap();
	}
}
