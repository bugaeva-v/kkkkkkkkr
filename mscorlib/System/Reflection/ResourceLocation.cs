using System;

namespace System.Reflection
{
	/// <summary>Указывает расположение ресурса.</summary>
	// Token: 0x020008C0 RID: 2240
	[Flags]
	public enum ResourceLocation
	{
		/// <summary>Указывает, что ресурс содержится в другой сборке.</summary>
		// Token: 0x04002F2C RID: 12076
		ContainedInAnotherAssembly = 2,
		/// <summary>Указывает, что ресурс содержится в файле манифеста.</summary>
		// Token: 0x04002F2D RID: 12077
		ContainedInManifestFile = 4,
		/// <summary>Указывает, что ресурс является внедренным (то есть не подключается).</summary>
		// Token: 0x04002F2E RID: 12078
		Embedded = 1
	}
}
