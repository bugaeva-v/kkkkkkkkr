using System;

namespace JetBrains.Annotations
{
	// Token: 0x020000CD RID: 205
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = true)]
	public sealed class MacroAttribute : Attribute
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00005E5F File Offset: 0x0000405F
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00005E67 File Offset: 0x00004067
		[CanBeNull]
		public string Expression { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00005E70 File Offset: 0x00004070
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00005E78 File Offset: 0x00004078
		public int Editable { get; set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00005E81 File Offset: 0x00004081
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00005E89 File Offset: 0x00004089
		[CanBeNull]
		public string Target { get; set; }
	}
}
