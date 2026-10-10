using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Easing;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.CustomPlugins
{
	// Token: 0x02000045 RID: 69
	public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions>
	{
		// Token: 0x06000245 RID: 581 RVA: 0x0000D671 File Offset: 0x0000B871
		public static PureQuaternionPlugin Plug()
		{
			if (PureQuaternionPlugin._plug == null)
			{
				PureQuaternionPlugin._plug = new PureQuaternionPlugin();
			}
			return PureQuaternionPlugin._plug;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000085F4 File Offset: 0x000067F4
		public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000D68C File Offset: 0x0000B88C
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative)
		{
			Quaternion endValue = t.endValue;
			t.endValue = t.getter();
			t.startValue = (isRelative ? (t.endValue * endValue) : endValue);
			t.setter(t.startValue);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000086D1 File Offset: 0x000068D1
		public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value)
		{
			return value;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000D6DA File Offset: 0x0000B8DA
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
			t.endValue *= t.startValue;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000D6F4 File Offset: 0x0000B8F4
		public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
			t.changeValue.x = t.endValue.x - t.startValue.x;
			t.changeValue.y = t.endValue.y - t.startValue.y;
			t.changeValue.z = t.endValue.z - t.startValue.z;
			t.changeValue.w = t.endValue.w - t.startValue.w;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000D78C File Offset: 0x0000B98C
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue)
		{
			return changeValue.eulerAngles.magnitude / unitsXSecond;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000D7AC File Offset: 0x0000B9AC
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
			float num = EaseManager.Evaluate(t.easeType, t.customEase, elapsed, duration, t.easeOvershootOrAmplitude, t.easePeriod);
			startValue.x += changeValue.x * num;
			startValue.y += changeValue.y * num;
			startValue.z += changeValue.z * num;
			startValue.w += changeValue.w * num;
			setter(startValue);
		}

		// Token: 0x04000119 RID: 281
		private static PureQuaternionPlugin _plug;
	}
}
