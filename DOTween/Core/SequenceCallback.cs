using System;

namespace DG.Tweening.Core
{
	// Token: 0x0200004D RID: 77
	internal class SequenceCallback : ABSSequentiable
	{
		// Token: 0x06000279 RID: 633 RVA: 0x0000DCAE File Offset: 0x0000BEAE
		public SequenceCallback(float sequencedPosition, TweenCallback callback)
		{
			this.tweenType = TweenType.Callback;
			this.sequencedPosition = sequencedPosition;
			this.onStart = callback;
		}
	}
}
