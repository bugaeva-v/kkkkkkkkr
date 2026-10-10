using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Реализует пакетную работу, представленную посредством действия, созданного объектом <see cref="T:System.EnterpriseServices.Activity" />.</summary>
	// Token: 0x02000029 RID: 41
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("BD3E2E12-42DD-40f4-A09A-95A50C58304B")]
	[ComImport]
	public interface IServiceCall
	{
		/// <summary>Запускает исполнение пакетной работы, реализованной в этом методе.</summary>
		// Token: 0x06000087 RID: 135
		void OnCall();
	}
}
