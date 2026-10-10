using System;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins.Core
{
	// Token: 0x0200003B RID: 59
	internal static class SpecialPluginsUtils
	{
		// Token: 0x06000215 RID: 533 RVA: 0x0000C30C File Offset: 0x0000A50C
		internal static bool SetLookAt(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
			Transform transform = t.target as Transform;
			Vector3 vector = t.endValue;
			vector -= transform.position;
			AxisConstraint axisConstraint = t.plugOptions.axisConstraint;
			if (axisConstraint != AxisConstraint.X)
			{
				if (axisConstraint != AxisConstraint.Y)
				{
					if (axisConstraint == AxisConstraint.Z)
					{
						vector.z = 0f;
					}
				}
				else
				{
					vector.y = 0f;
				}
			}
			else
			{
				vector.x = 0f;
			}
			Vector3 eulerAngles = Quaternion.LookRotation(vector, t.plugOptions.up).eulerAngles;
			t.endValue = eulerAngles;
			return true;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000C3A0 File Offset: 0x0000A5A0
		internal static bool SetPunch(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
		{
			Vector3 b;
			try
			{
				b = t.getter();
			}
			catch
			{
				return false;
			}
			t.isRelative = (t.isSpeedBased = false);
			t.easeType = Ease.OutQuad;
			t.customEase = null;
			int num = t.endValue.Length;
			for (int i = 0; i < num; i++)
			{
				t.endValue[i] = t.endValue[i] + b;
			}
			return true;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000C42C File Offset: 0x0000A62C
		internal static bool SetShake(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
		{
			if (!SpecialPluginsUtils.SetPunch(t))
			{
				return false;
			}
			t.easeType = Ease.Linear;
			return true;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000C440 File Offset: 0x0000A640
		internal static bool SetCameraShakePosition(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
		{
			if (!SpecialPluginsUtils.SetShake(t))
			{
				return false;
			}
			Camera camera = t.target as Camera;
			if (camera == null)
			{
				return false;
			}
			Vector3 b = t.getter();
			Transform transform = camera.transform;
			int num = t.endValue.Length;
			for (int i = 0; i < num; i++)
			{
				Vector3 a = t.endValue[i];
				t.endValue[i] = transform.localRotation * (a - b) + b;
			}
			return true;
		}
	}
}
