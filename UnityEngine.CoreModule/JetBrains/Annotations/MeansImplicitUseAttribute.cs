using System;

namespace JetBrains.Annotations
{
	// Token: 0x020000C2 RID: 194
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
	public sealed class MeansImplicitUseAttribute : Attribute
	{
		// Token: 0x06000359 RID: 857 RVA: 0x00005D9E File Offset: 0x00003F9E
		public MeansImplicitUseAttribute() : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00005DAA File Offset: 0x00003FAA
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags) : this(useKindFlags, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00005DB6 File Offset: 0x00003FB6
		public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags) : this(ImplicitUseKindFlags.Default, targetFlags)
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00005DC2 File Offset: 0x00003FC2
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
			this.UseKindFlags = useKindFlags;
			this.TargetFlags = targetFlags;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00005DDA File Offset: 0x00003FDA
		[UsedImplicitly]
		public ImplicitUseKindFlags UseKindFlags { get; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00005DE2 File Offset: 0x00003FE2
		[UsedImplicitly]
		public ImplicitUseTargetFlags TargetFlags { get; }
	}
}
