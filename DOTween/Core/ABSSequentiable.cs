using System;

namespace DG.Tweening.Core
{
	// Token: 0x02000046 RID: 70
	public abstract class ABSSequentiable
	{
		// Token: 0x0400011A RID: 282
		internal TweenType tweenType;

		// Token: 0x0400011B RID: 283
		internal float sequencedPosition;

		// Token: 0x0400011C RID: 284
		internal float sequencedEndPosition;

		// Token: 0x0400011D RID: 285
		internal TweenCallback onStart;
	}
}
