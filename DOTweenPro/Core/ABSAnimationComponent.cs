using System;
using UnityEngine;
using UnityEngine.Events;

namespace DG.Tweening.Core
{
	// Token: 0x0200000C RID: 12
	[AddComponentMenu("")]
	public abstract class ABSAnimationComponent : MonoBehaviour
	{
		// Token: 0x06000026 RID: 38
		public abstract void DOPlay();

		// Token: 0x06000027 RID: 39
		public abstract void DOPlayBackwards();

		// Token: 0x06000028 RID: 40
		public abstract void DOPlayForward();

		// Token: 0x06000029 RID: 41
		public abstract void DOPause();

		// Token: 0x0600002A RID: 42
		public abstract void DOTogglePause();

		// Token: 0x0600002B RID: 43
		public abstract void DORewind();

		// Token: 0x0600002C RID: 44
		public abstract void DORestart(bool fromHere = false);

		// Token: 0x0600002D RID: 45
		public abstract void DOComplete();

		// Token: 0x0600002E RID: 46
		public abstract void DOKill();

		// Token: 0x04000042 RID: 66
		public UpdateType updateType;

		// Token: 0x04000043 RID: 67
		public bool isSpeedBased;

		// Token: 0x04000044 RID: 68
		public bool hasOnStart;

		// Token: 0x04000045 RID: 69
		public bool hasOnPlay;

		// Token: 0x04000046 RID: 70
		public bool hasOnUpdate;

		// Token: 0x04000047 RID: 71
		public bool hasOnStepComplete;

		// Token: 0x04000048 RID: 72
		public bool hasOnComplete;

		// Token: 0x04000049 RID: 73
		public bool hasOnTweenCreated;

		// Token: 0x0400004A RID: 74
		public bool hasOnRewind;

		// Token: 0x0400004B RID: 75
		public UnityEvent onStart;

		// Token: 0x0400004C RID: 76
		public UnityEvent onPlay;

		// Token: 0x0400004D RID: 77
		public UnityEvent onUpdate;

		// Token: 0x0400004E RID: 78
		public UnityEvent onStepComplete;

		// Token: 0x0400004F RID: 79
		public UnityEvent onComplete;

		// Token: 0x04000050 RID: 80
		public UnityEvent onTweenCreated;

		// Token: 0x04000051 RID: 81
		public UnityEvent onRewind;

		// Token: 0x04000052 RID: 82
		[NonSerialized]
		public Tween tween;
	}
}
