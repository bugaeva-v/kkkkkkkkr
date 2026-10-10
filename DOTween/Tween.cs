using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;

namespace DG.Tweening
{
	// Token: 0x02000018 RID: 24
	public abstract class Tween : ABSSequentiable
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00007BF6 File Offset: 0x00005DF6
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00007BFF File Offset: 0x00005DFF
		public float fullPosition
		{
			get
			{
				return this.Elapsed(true);
			}
			set
			{
				this.Goto(value, this.isPlaying);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00007C10 File Offset: 0x00005E10
		internal virtual void Reset()
		{
			this.timeScale = 1f;
			this.isBackwards = false;
			this.id = null;
			this.intId = -999;
			this.isIndependentUpdate = false;
			this.onStart = (this.onPlay = (this.onRewind = (this.onUpdate = (this.onComplete = (this.onStepComplete = (this.onKill = null))))));
			this.onWaypointChange = null;
			this.target = null;
			this.isFrom = false;
			this.isBlendable = false;
			this.isSpeedBased = false;
			this.duration = 0f;
			this.loops = 1;
			this.delay = 0f;
			this.isRelative = false;
			this.customEase = null;
			this.isSequenced = false;
			this.sequenceParent = null;
			this.specialStartupMode = SpecialStartupMode.None;
			this.creationLocked = (this.startupDone = (this.playedOnce = false));
			this.position = (this.fullDuration = (float)(this.completedLoops = 0));
			this.isPlaying = (this.isComplete = false);
			this.elapsedDelay = 0f;
			this.delayComplete = true;
			this.miscInt = -1;
		}

		// Token: 0x06000163 RID: 355
		internal abstract bool Validate();

		// Token: 0x06000164 RID: 356 RVA: 0x00007D44 File Offset: 0x00005F44
		internal virtual float UpdateDelay(float elapsed)
		{
			return 0f;
		}

		// Token: 0x06000165 RID: 357
		internal abstract bool Startup();

		// Token: 0x06000166 RID: 358
		internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice);

		// Token: 0x06000167 RID: 359 RVA: 0x00007D4C File Offset: 0x00005F4C
		internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode)
		{
			if (!t.startupDone && !t.Startup())
			{
				return true;
			}
			if (!t.playedOnce && updateMode == UpdateMode.Update)
			{
				t.playedOnce = true;
				if (t.onStart != null)
				{
					Tween.OnTweenCallback(t.onStart);
					if (!t.active)
					{
						return true;
					}
				}
				if (t.onPlay != null)
				{
					Tween.OnTweenCallback(t.onPlay);
					if (!t.active)
					{
						return true;
					}
				}
			}
			float prevPosition = t.position;
			int num = t.completedLoops;
			t.completedLoops = toCompletedLoops;
			bool flag = t.position <= 0f && num <= 0;
			bool flag2 = t.isComplete;
			if (t.loops != -1)
			{
				t.isComplete = (t.completedLoops == t.loops);
			}
			int num2 = 0;
			if (updateMode == UpdateMode.Update)
			{
				if (t.isBackwards)
				{
					num2 = ((t.completedLoops < num) ? (num - t.completedLoops) : ((toPosition <= 0f && !flag) ? 1 : 0));
					if (flag2)
					{
						num2--;
					}
				}
				else
				{
					num2 = ((t.completedLoops > num) ? (t.completedLoops - num) : 0);
				}
			}
			else if (t.tweenType == TweenType.Sequence)
			{
				num2 = num - toCompletedLoops;
				if (num2 < 0)
				{
					num2 = -num2;
				}
			}
			t.position = toPosition;
			if (t.position > t.duration)
			{
				t.position = t.duration;
			}
			else if (t.position <= 0f)
			{
				if (t.completedLoops > 0 || t.isComplete)
				{
					t.position = t.duration;
				}
				else
				{
					t.position = 0f;
				}
			}
			bool flag3 = t.isPlaying;
			if (t.isPlaying)
			{
				if (!t.isBackwards)
				{
					t.isPlaying = !t.isComplete;
				}
				else
				{
					t.isPlaying = (t.completedLoops != 0 || t.position > 0f);
				}
			}
			bool useInversePosition = t.loopType == LoopType.Yoyo && ((t.position < t.duration) ? (t.completedLoops % 2 != 0) : (t.completedLoops % 2 == 0));
			UpdateNotice updateNotice = (!flag && ((t.loopType == LoopType.Restart && t.completedLoops != num && (t.loops == -1 || t.completedLoops < t.loops)) || (t.position <= 0f && t.completedLoops <= 0))) ? UpdateNotice.RewindStep : UpdateNotice.None;
			if (t.ApplyTween(prevPosition, num, num2, useInversePosition, updateMode, updateNotice))
			{
				return true;
			}
			if (t.onUpdate != null && updateMode != UpdateMode.IgnoreOnUpdate)
			{
				Tween.OnTweenCallback(t.onUpdate);
			}
			if (t.position <= 0f && t.completedLoops <= 0 && !flag && t.onRewind != null)
			{
				Tween.OnTweenCallback(t.onRewind);
			}
			if (num2 > 0 && updateMode == UpdateMode.Update && t.onStepComplete != null)
			{
				for (int i = 0; i < num2; i++)
				{
					Tween.OnTweenCallback(t.onStepComplete);
				}
			}
			if (t.isComplete && !flag2 && updateMode != UpdateMode.IgnoreOnComplete && t.onComplete != null)
			{
				Tween.OnTweenCallback(t.onComplete);
			}
			if (!t.isPlaying && flag3 && (!t.isComplete || !t.autoKill) && t.onPause != null)
			{
				Tween.OnTweenCallback(t.onPause);
			}
			return t.autoKill && t.isComplete;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000808C File Offset: 0x0000628C
		internal static bool OnTweenCallback(TweenCallback callback)
		{
			if (DOTween.useSafeMode)
			{
				try
				{
					callback();
					return true;
				}
				catch (Exception ex)
				{
					Debugger.LogWarning(string.Concat(new string[]
					{
						"An error inside a tween callback was silently taken care of > ",
						ex.Message,
						"\n\n",
						ex.StackTrace,
						"\n\n"
					}));
					return false;
				}
			}
			callback();
			return true;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00008100 File Offset: 0x00006300
		internal static bool OnTweenCallback<T>(TweenCallback<T> callback, T param)
		{
			if (DOTween.useSafeMode)
			{
				try
				{
					callback(param);
					return true;
				}
				catch (Exception ex)
				{
					Debugger.LogWarning("An error inside a tween callback was silently taken care of > " + ex.Message);
					return false;
				}
			}
			callback(param);
			return true;
		}

		// Token: 0x04000086 RID: 134
		public float timeScale;

		// Token: 0x04000087 RID: 135
		public bool isBackwards;

		// Token: 0x04000088 RID: 136
		public object id;

		// Token: 0x04000089 RID: 137
		public string stringId;

		// Token: 0x0400008A RID: 138
		public int intId = -999;

		// Token: 0x0400008B RID: 139
		public object target;

		// Token: 0x0400008C RID: 140
		internal UpdateType updateType;

		// Token: 0x0400008D RID: 141
		internal bool isIndependentUpdate;

		// Token: 0x0400008E RID: 142
		public TweenCallback onPlay;

		// Token: 0x0400008F RID: 143
		public TweenCallback onPause;

		// Token: 0x04000090 RID: 144
		public TweenCallback onRewind;

		// Token: 0x04000091 RID: 145
		public TweenCallback onUpdate;

		// Token: 0x04000092 RID: 146
		public TweenCallback onStepComplete;

		// Token: 0x04000093 RID: 147
		public TweenCallback onComplete;

		// Token: 0x04000094 RID: 148
		public TweenCallback onKill;

		// Token: 0x04000095 RID: 149
		public TweenCallback<int> onWaypointChange;

		// Token: 0x04000096 RID: 150
		internal bool isFrom;

		// Token: 0x04000097 RID: 151
		internal bool isBlendable;

		// Token: 0x04000098 RID: 152
		internal bool isRecyclable;

		// Token: 0x04000099 RID: 153
		internal bool isSpeedBased;

		// Token: 0x0400009A RID: 154
		internal bool autoKill;

		// Token: 0x0400009B RID: 155
		internal float duration;

		// Token: 0x0400009C RID: 156
		internal int loops;

		// Token: 0x0400009D RID: 157
		internal LoopType loopType;

		// Token: 0x0400009E RID: 158
		internal float delay;

		// Token: 0x0400009F RID: 159
		internal bool isRelative;

		// Token: 0x040000A0 RID: 160
		internal Ease easeType;

		// Token: 0x040000A1 RID: 161
		internal EaseFunction customEase;

		// Token: 0x040000A2 RID: 162
		public float easeOvershootOrAmplitude;

		// Token: 0x040000A3 RID: 163
		public float easePeriod;

		// Token: 0x040000A4 RID: 164
		internal Type typeofT1;

		// Token: 0x040000A5 RID: 165
		internal Type typeofT2;

		// Token: 0x040000A6 RID: 166
		internal Type typeofTPlugOptions;

		// Token: 0x040000A7 RID: 167
		internal bool active;

		// Token: 0x040000A8 RID: 168
		internal bool isSequenced;

		// Token: 0x040000A9 RID: 169
		internal Sequence sequenceParent;

		// Token: 0x040000AA RID: 170
		internal int activeId = -1;

		// Token: 0x040000AB RID: 171
		internal SpecialStartupMode specialStartupMode;

		// Token: 0x040000AC RID: 172
		internal bool creationLocked;

		// Token: 0x040000AD RID: 173
		internal bool startupDone;

		// Token: 0x040000AE RID: 174
		internal bool playedOnce;

		// Token: 0x040000AF RID: 175
		internal float position;

		// Token: 0x040000B0 RID: 176
		internal float fullDuration;

		// Token: 0x040000B1 RID: 177
		internal int completedLoops;

		// Token: 0x040000B2 RID: 178
		internal bool isPlaying;

		// Token: 0x040000B3 RID: 179
		internal bool isComplete;

		// Token: 0x040000B4 RID: 180
		internal float elapsedDelay;

		// Token: 0x040000B5 RID: 181
		internal bool delayComplete = true;

		// Token: 0x040000B6 RID: 182
		internal int miscInt = -1;
	}
}
