using System;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine.Audio;

namespace DG.Tweening
{
	// Token: 0x02000002 RID: 2
	public static class ShortcutExtensions50
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static Tweener DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return DOTween.To(delegate()
			{
				float result;
				target.GetFloat(floatName, out result);
				return result;
			}, delegate(float x)
			{
				target.SetFloat(floatName, x);
			}, endValue, duration).SetTarget(target);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000209B File Offset: 0x0000029B
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return DOTween.Complete(target, withCallbacks);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020A4 File Offset: 0x000002A4
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return DOTween.Kill(target, complete);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020AD File Offset: 0x000002AD
		public static int DOFlip(this AudioMixer target)
		{
			return DOTween.Flip(target);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020B5 File Offset: 0x000002B5
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return DOTween.Goto(target, to, andPlay);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020BF File Offset: 0x000002BF
		public static int DOPause(this AudioMixer target)
		{
			return DOTween.Pause(target);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020C7 File Offset: 0x000002C7
		public static int DOPlay(this AudioMixer target)
		{
			return DOTween.Play(target);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020CF File Offset: 0x000002CF
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return DOTween.PlayBackwards(target);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020D7 File Offset: 0x000002D7
		public static int DOPlayForward(this AudioMixer target)
		{
			return DOTween.PlayForward(target);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020DF File Offset: 0x000002DF
		public static int DORestart(this AudioMixer target)
		{
			return DOTween.Restart(target, true, -1f);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020ED File Offset: 0x000002ED
		public static int DORewind(this AudioMixer target)
		{
			return DOTween.Rewind(target, true);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020F6 File Offset: 0x000002F6
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return DOTween.SmoothRewind(target);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020FE File Offset: 0x000002FE
		public static int DOTogglePause(this AudioMixer target)
		{
			return DOTween.TogglePause(target);
		}
	}
}
