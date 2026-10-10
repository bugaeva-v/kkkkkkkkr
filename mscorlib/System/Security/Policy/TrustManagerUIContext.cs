using System;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Задает тип пользовательского интерфейса (UI) и диспетчер доверия, который следует использовать для решений о доверии.</summary>
	// Token: 0x02000423 RID: 1059
	[ComVisible(true)]
	public enum TrustManagerUIContext
	{
		/// <summary>Установка пользовательского интерфейса.</summary>
		// Token: 0x04001FC3 RID: 8131
		Install,
		/// <summary>Обновление пользовательского интерфейса.</summary>
		// Token: 0x04001FC4 RID: 8132
		Upgrade,
		/// <summary>Запуск пользовательского интерфейса.</summary>
		// Token: 0x04001FC5 RID: 8133
		Run
	}
}
