using System;

namespace NSubstitute.Core
{
	// Token: 0x0200006F RID: 111
	public class CallSpecAndTarget
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00005D54 File Offset: 0x00003F54
		public ICallSpecification CallSpecification { get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00005D5C File Offset: 0x00003F5C
		public object Target { get; }

		// Token: 0x0600019C RID: 412 RVA: 0x00005D64 File Offset: 0x00003F64
		public CallSpecAndTarget(ICallSpecification callSpecification, object target)
		{
			this.CallSpecification = callSpecification;
			this.Target = target;
		}
	}
}
