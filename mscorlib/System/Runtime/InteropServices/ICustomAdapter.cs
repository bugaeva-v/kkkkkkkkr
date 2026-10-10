using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Позволяет клиентам получать доступ к фактическому объекту, а не к объекту адаптера, предоставленному пользовательским упаковщиком.</summary>
	// Token: 0x020006D7 RID: 1751
	public interface ICustomAdapter
	{
		/// <summary>Предоставляет доступ к базовому объекту, упакованному настраиваемым модулем упаковки и передачи.</summary>
		/// <returns>Объект, содержащийся в объекте адаптера.</returns>
		// Token: 0x06004032 RID: 16434
		[return: MarshalAs(UnmanagedType.IUnknown)]
		object GetUnderlyingObject();
	}
}
