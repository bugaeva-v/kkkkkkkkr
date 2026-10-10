using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Поддерживает задание времени ожидания для метода <see cref="M:System.EnterpriseServices.IProcessInitializer.Startup(System.Object)" />.</summary>
	// Token: 0x02000022 RID: 34
	[Guid("72380d55-8d2b-43a3-8513-2b6ef31434e9")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IProcessInitControl
	{
		/// <summary>Задает число секунд, оставшихся до истечения времени ожидания метода <see cref="M:System.EnterpriseServices.IProcessInitializer.Startup(System.Object)" />.</summary>
		/// <param name="dwSecondsRemaining">Число секунд, остающихся до истечения времени, заданного для выполнения метода запуска.</param>
		// Token: 0x06000074 RID: 116
		void ResetInitializerTimeout(int dwSecondsRemaining);
	}
}
