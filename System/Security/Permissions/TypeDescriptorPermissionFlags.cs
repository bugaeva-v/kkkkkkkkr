using System;

namespace System.Security.Permissions
{
	/// <summary>Определяет настройки разрешений для дескрипторов типа.</summary>
	// Token: 0x02000293 RID: 659
	[Flags]
	[Serializable]
	public enum TypeDescriptorPermissionFlags
	{
		/// <summary>Для дескриптора типа не установлены флаги разрешений.</summary>
		// Token: 0x04000BB6 RID: 2998
		NoFlags = 0,
		/// <summary>Дескриптор типа может вызываться из частично доверенного кода.</summary>
		// Token: 0x04000BB7 RID: 2999
		RestrictedRegistrationAccess = 1
	}
}
