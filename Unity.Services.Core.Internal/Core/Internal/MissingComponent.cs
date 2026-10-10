using System;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000049 RID: 73
	internal class MissingComponent : IServiceComponent
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00003781 File Offset: 0x00001981
		public Type IntendedType { get; }

		// Token: 0x0600013B RID: 315 RVA: 0x00003789 File Offset: 0x00001989
		internal MissingComponent(Type intendedType)
		{
			this.IntendedType = intendedType;
		}
	}
}
