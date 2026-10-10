using System;
using System.Runtime.InteropServices;

namespace System.Configuration.Internal
{
	/// <summary>Определяет интерфейс, используемый платформой .NET Framework, для поддержки управления конфигурации.</summary>
	// Token: 0x0200007D RID: 125
	[ComVisible(false)]
	public interface IConfigurationManagerHelper
	{
		/// <summary>Гарантирует, что конфигурация сети загружена.</summary>
		// Token: 0x0600042C RID: 1068
		void EnsureNetConfigLoaded();
	}
}
