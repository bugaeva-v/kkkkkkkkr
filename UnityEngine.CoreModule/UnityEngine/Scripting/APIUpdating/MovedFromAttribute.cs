using System;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x020002E1 RID: 737
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class MovedFromAttribute : Attribute
	{
		// Token: 0x06001E0B RID: 7691 RVA: 0x00030DF4 File Offset: 0x0002EFF4
		public MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null)
		{
			this.data.Set(autoUpdateAPI, sourceNamespace, sourceAssembly, sourceClassName);
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00030E0F File Offset: 0x0002F00F
		public MovedFromAttribute(string sourceNamespace)
		{
			this.data.Set(true, sourceNamespace, null, null);
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x00030E2C File Offset: 0x0002F02C
		internal bool AffectsAPIUpdater
		{
			get
			{
				return !this.data.classHasChanged && !this.data.assemblyHasChanged;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x00030E5C File Offset: 0x0002F05C
		public bool IsInDifferentAssembly
		{
			get
			{
				return this.data.assemblyHasChanged;
			}
		}

		// Token: 0x040009DF RID: 2527
		internal MovedFromAttributeData data;
	}
}
