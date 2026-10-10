using System;

namespace Microsoft.Win32
{
	/// <summary>Представляет возможные значения для узла верхнего уровня на чужом компьютере.</summary>
	// Token: 0x020000A2 RID: 162
	public enum RegistryHive
	{
		/// <summary>Представляет базовый раздел HKEY_CLASSES_ROOT на другом компьютере. Для удаленного открытия данного узла это значение может быть передано в метод <see cref="M:Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive,System.String)" />.</summary>
		// Token: 0x04000F4E RID: 3918
		ClassesRoot = -2147483648,
		/// <summary>Представляете базовый раздел HKEY_CURRENT_USER на другом компьютере. Для удаленного открытия данного узла это значение может быть передано в метод <see cref="M:Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive,System.String)" />.</summary>
		// Token: 0x04000F4F RID: 3919
		CurrentUser,
		/// <summary>Представляете базовый раздел HKEY_LOCAL_MACHINE на другом компьютере. Для удаленного открытия данного узла это значение может быть передано в метод <see cref="M:Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive,System.String)" />.</summary>
		// Token: 0x04000F50 RID: 3920
		LocalMachine,
		/// <summary>Представляете базовый раздел HKEY_USERS на другом компьютере. Для удаленного открытия данного узла это значение может быть передано в метод <see cref="M:Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive,System.String)" />.</summary>
		// Token: 0x04000F51 RID: 3921
		Users,
		/// <summary>Представляете базовый раздел HKEY_PERFORMANCE_DATA на другом компьютере. Для удаленного открытия данного узла это значение может быть передано в метод <see cref="M:Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive,System.String)" />.</summary>
		// Token: 0x04000F52 RID: 3922
		PerformanceData,
		/// <summary>Представляете базовый раздел HKEY_CURRENT_CONFIG на другом компьютере. Для удаленного открытия данного узла это значение может быть передано в метод <see cref="M:Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive,System.String)" />.</summary>
		// Token: 0x04000F53 RID: 3923
		CurrentConfig,
		/// <summary>Представляете базовый раздел HKEY_DYN_DATA на другом компьютере. Для удаленного открытия данного узла это значение может быть передано в метод <see cref="M:Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive,System.String)" />.</summary>
		// Token: 0x04000F54 RID: 3924
		DynData
	}
}
