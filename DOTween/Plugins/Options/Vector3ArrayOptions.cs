using System;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000033 RID: 51
	public struct Vector3ArrayOptions : IPlugOptions
	{
		// Token: 0x0600020E RID: 526 RVA: 0x0000C295 File Offset: 0x0000A495
		public void Reset()
		{
			this.axisConstraint = AxisConstraint.None;
			this.snapping = false;
			this.durations = null;
		}

		// Token: 0x040000E3 RID: 227
		public AxisConstraint axisConstraint;

		// Token: 0x040000E4 RID: 228
		public bool snapping;

		// Token: 0x040000E5 RID: 229
		internal float[] durations;
	}
}
