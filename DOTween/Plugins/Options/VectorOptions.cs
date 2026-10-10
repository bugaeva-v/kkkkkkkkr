using System;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000039 RID: 57
	public struct VectorOptions : IPlugOptions
	{
		// Token: 0x06000214 RID: 532 RVA: 0x0000C2FA File Offset: 0x0000A4FA
		public void Reset()
		{
			this.axisConstraint = AxisConstraint.None;
			this.snapping = false;
		}

		// Token: 0x040000EE RID: 238
		public AxisConstraint axisConstraint;

		// Token: 0x040000EF RID: 239
		public bool snapping;
	}
}
