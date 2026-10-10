using System;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Задает действие, которое должен выполнять диспетчер пользовательского домена приложения при инициализации нового домена.</summary>
	// Token: 0x02000235 RID: 565
	[ComVisible(true)]
	[Flags]
	public enum AppDomainManagerInitializationOptions
	{
		/// <summary>Действия по инициализации отсутствуют.</summary>
		// Token: 0x04001715 RID: 5909
		None = 0,
		/// <summary>Регистрирует вызываемую оболочку COM для текущего диспетчера <see cref="T:System.AppDomainManager" />, используя для этого неуправляемый узел.</summary>
		// Token: 0x04001716 RID: 5910
		RegisterWithHost = 1
	}
}
