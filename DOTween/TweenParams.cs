using System;
using DG.Tweening.Core.Easing;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000015 RID: 21
	public class TweenParams
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00006747 File Offset: 0x00004947
		public TweenParams()
		{
			this.Clear();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006758 File Offset: 0x00004958
		public TweenParams Clear()
		{
			this.id = (this.target = null);
			this.updateType = DOTween.defaultUpdateType;
			this.isIndependentUpdate = DOTween.defaultTimeScaleIndependent;
			this.onStart = (this.onPlay = (this.onRewind = (this.onUpdate = (this.onStepComplete = (this.onComplete = (this.onKill = null))))));
			this.onWaypointChange = null;
			this.isRecyclable = DOTween.defaultRecyclable;
			this.isSpeedBased = false;
			this.autoKill = DOTween.defaultAutoKill;
			this.loops = 1;
			this.loopType = DOTween.defaultLoopType;
			this.delay = 0f;
			this.isRelative = false;
			this.easeType = Ease.Unset;
			this.customEase = null;
			this.easeOvershootOrAmplitude = DOTween.defaultEaseOvershootOrAmplitude;
			this.easePeriod = DOTween.defaultEasePeriod;
			return this;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006835 File Offset: 0x00004A35
		public TweenParams SetAutoKill(bool autoKillOnCompletion = true)
		{
			this.autoKill = autoKillOnCompletion;
			return this;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000683F File Offset: 0x00004A3F
		public TweenParams SetId(object id)
		{
			this.id = id;
			return this;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00006849 File Offset: 0x00004A49
		public TweenParams SetTarget(object target)
		{
			this.target = target;
			return this;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00006853 File Offset: 0x00004A53
		public TweenParams SetLoops(int loops, LoopType? loopType = null)
		{
			if (loops < -1)
			{
				loops = -1;
			}
			else if (loops == 0)
			{
				loops = 1;
			}
			this.loops = loops;
			if (loopType != null)
			{
				this.loopType = loopType.Value;
			}
			return this;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00006884 File Offset: 0x00004A84
		public TweenParams SetEase(Ease ease, float? overshootOrAmplitude = null, float? period = null)
		{
			this.easeType = ease;
			this.easeOvershootOrAmplitude = ((overshootOrAmplitude != null) ? overshootOrAmplitude.Value : DOTween.defaultEaseOvershootOrAmplitude);
			this.easePeriod = ((period != null) ? period.Value : DOTween.defaultEasePeriod);
			this.customEase = null;
			return this;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000068DC File Offset: 0x00004ADC
		public TweenParams SetEase(AnimationCurve animCurve)
		{
			this.easeType = Ease.INTERNAL_Custom;
			this.customEase = new EaseFunction(new EaseCurve(animCurve).Evaluate);
			return this;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000068FE File Offset: 0x00004AFE
		public TweenParams SetEase(EaseFunction customEase)
		{
			this.easeType = Ease.INTERNAL_Custom;
			this.customEase = customEase;
			return this;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00006910 File Offset: 0x00004B10
		public TweenParams SetRecyclable(bool recyclable = true)
		{
			this.isRecyclable = recyclable;
			return this;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000691A File Offset: 0x00004B1A
		public TweenParams SetUpdate(bool isIndependentUpdate)
		{
			this.updateType = DOTween.defaultUpdateType;
			this.isIndependentUpdate = isIndependentUpdate;
			return this;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000692F File Offset: 0x00004B2F
		public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false)
		{
			this.updateType = updateType;
			this.isIndependentUpdate = isIndependentUpdate;
			return this;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00006940 File Offset: 0x00004B40
		public TweenParams OnStart(TweenCallback action)
		{
			this.onStart = action;
			return this;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000694A File Offset: 0x00004B4A
		public TweenParams OnPlay(TweenCallback action)
		{
			this.onPlay = action;
			return this;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00006954 File Offset: 0x00004B54
		public TweenParams OnRewind(TweenCallback action)
		{
			this.onRewind = action;
			return this;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000695E File Offset: 0x00004B5E
		public TweenParams OnUpdate(TweenCallback action)
		{
			this.onUpdate = action;
			return this;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006968 File Offset: 0x00004B68
		public TweenParams OnStepComplete(TweenCallback action)
		{
			this.onStepComplete = action;
			return this;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00006972 File Offset: 0x00004B72
		public TweenParams OnComplete(TweenCallback action)
		{
			this.onComplete = action;
			return this;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000697C File Offset: 0x00004B7C
		public TweenParams OnKill(TweenCallback action)
		{
			this.onKill = action;
			return this;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006986 File Offset: 0x00004B86
		public TweenParams OnWaypointChange(TweenCallback<int> action)
		{
			this.onWaypointChange = action;
			return this;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00006990 File Offset: 0x00004B90
		public TweenParams SetDelay(float delay)
		{
			this.delay = delay;
			return this;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000699A File Offset: 0x00004B9A
		public TweenParams SetRelative(bool isRelative = true)
		{
			this.isRelative = isRelative;
			return this;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000069A4 File Offset: 0x00004BA4
		public TweenParams SetSpeedBased(bool isSpeedBased = true)
		{
			this.isSpeedBased = isSpeedBased;
			return this;
		}

		// Token: 0x0400006A RID: 106
		public static readonly TweenParams Params = new TweenParams();

		// Token: 0x0400006B RID: 107
		internal object id;

		// Token: 0x0400006C RID: 108
		internal object target;

		// Token: 0x0400006D RID: 109
		internal UpdateType updateType;

		// Token: 0x0400006E RID: 110
		internal bool isIndependentUpdate;

		// Token: 0x0400006F RID: 111
		internal TweenCallback onStart;

		// Token: 0x04000070 RID: 112
		internal TweenCallback onPlay;

		// Token: 0x04000071 RID: 113
		internal TweenCallback onRewind;

		// Token: 0x04000072 RID: 114
		internal TweenCallback onUpdate;

		// Token: 0x04000073 RID: 115
		internal TweenCallback onStepComplete;

		// Token: 0x04000074 RID: 116
		internal TweenCallback onComplete;

		// Token: 0x04000075 RID: 117
		internal TweenCallback onKill;

		// Token: 0x04000076 RID: 118
		internal TweenCallback<int> onWaypointChange;

		// Token: 0x04000077 RID: 119
		internal bool isRecyclable;

		// Token: 0x04000078 RID: 120
		internal bool isSpeedBased;

		// Token: 0x04000079 RID: 121
		internal bool autoKill;

		// Token: 0x0400007A RID: 122
		internal int loops;

		// Token: 0x0400007B RID: 123
		internal LoopType loopType;

		// Token: 0x0400007C RID: 124
		internal float delay;

		// Token: 0x0400007D RID: 125
		internal bool isRelative;

		// Token: 0x0400007E RID: 126
		internal Ease easeType;

		// Token: 0x0400007F RID: 127
		internal EaseFunction customEase;

		// Token: 0x04000080 RID: 128
		internal float easeOvershootOrAmplitude;

		// Token: 0x04000081 RID: 129
		internal float easePeriod;
	}
}
