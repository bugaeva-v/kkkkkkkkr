using System;
using UnityEngine;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000031 RID: 49
	public struct QuaternionOptions : IPlugOptions
	{
		// Token: 0x0600020C RID: 524 RVA: 0x0000C271 File Offset: 0x0000A471
		public void Reset()
		{
			this.rotateMode = RotateMode.Fast;
			this.axisConstraint = AxisConstraint.None;
			this.up = Vector3.zero;
		}

		// Token: 0x040000DF RID: 223
		internal RotateMode rotateMode;

		// Token: 0x040000E0 RID: 224
		internal AxisConstraint axisConstraint;

		// Token: 0x040000E1 RID: 225
		internal Vector3 up;
	}
}
