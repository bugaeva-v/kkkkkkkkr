using System;

namespace DG.Tweening.Core.Easing
{
	// Token: 0x02000057 RID: 87
	public static class Bounce
	{
		// Token: 0x060002AF RID: 687 RVA: 0x0000FAAC File Offset: 0x0000DCAC
		public static float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			return 1f - Bounce.EaseOut(duration - time, duration, -1f, -1f);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		public static float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			if ((time /= duration) < 0.36363637f)
			{
				return 7.5625f * time * time;
			}
			if (time < 0.72727275f)
			{
				return 7.5625f * (time -= 0.54545456f) * time + 0.75f;
			}
			if (time < 0.90909094f)
			{
				return 7.5625f * (time -= 0.8181818f) * time + 0.9375f;
			}
			return 7.5625f * (time -= 0.95454544f) * time + 0.984375f;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000FB48 File Offset: 0x0000DD48
		public static float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			if (time < duration * 0.5f)
			{
				return Bounce.EaseIn(time * 2f, duration, -1f, -1f) * 0.5f;
			}
			return Bounce.EaseOut(time * 2f - duration, duration, -1f, -1f) * 0.5f + 0.5f;
		}
	}
}
