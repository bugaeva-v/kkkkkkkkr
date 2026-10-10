using System;

namespace Microsoft.Win32
{
	/// <summary>Определяет необязательное поведение при возвращении пар "имя-значение" из раздела реестра.</summary>
	// Token: 0x020000A8 RID: 168
	[Flags]
	public enum RegistryValueOptions
	{
		/// <summary>Необязательное поведение не задано.</summary>
		// Token: 0x04000F7B RID: 3963
		None = 0,
		/// <summary>Значение типа <see cref="F:Microsoft.Win32.RegistryValueKind.ExpandString" /> возвращается без расширения соответствующих встроенных переменных среды.</summary>
		// Token: 0x04000F7C RID: 3964
		DoNotExpandEnvironmentNames = 1
	}
}
