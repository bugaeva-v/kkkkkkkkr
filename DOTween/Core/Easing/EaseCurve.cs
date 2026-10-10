using System;
using UnityEngine;

namespace DG.Tweening.Core.Easing
{
	// Token: 0x02000059 RID: 89
	public class EaseCurve
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x00010831 File Offset: 0x0000EA31
		public EaseCurve(AnimationCurve animCurve)
		{
			this._animCurve = animCurve;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00010840 File Offset: 0x0000EA40
		public float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod)
		{
			float time2 = this._animCurve[this._animCurve.length - 1].time;
			float num = time / duration;
			return this._animCurve.Evaluate(num * time2);
		}

		// Token: 0x04000189 RID: 393
		private readonly AnimationCurve _animCurve;
	}
}
