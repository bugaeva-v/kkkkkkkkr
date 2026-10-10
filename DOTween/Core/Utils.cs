using System;
using UnityEngine;

namespace DG.Tweening.Core
{
	// Token: 0x0200004F RID: 79
	internal static class Utils
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x0000F634 File Offset: 0x0000D834
		internal static Vector3 Vector3FromAngle(float degrees, float magnitude)
		{
			float f = degrees * 0.017453292f;
			return new Vector3(magnitude * Mathf.Cos(f), magnitude * Mathf.Sin(f), 0f);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000F664 File Offset: 0x0000D864
		internal static float Angle2D(Vector3 from, Vector3 to)
		{
			Vector2 right = Vector2.right;
			to -= from;
			float num = Vector2.Angle(right, to);
			if (Vector3.Cross(right, to).z > 0f)
			{
				num = 360f - num;
			}
			return num * -1f;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000F6B4 File Offset: 0x0000D8B4
		internal static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b)
		{
			return Mathf.Approximately(a.x, b.x) && Mathf.Approximately(a.y, b.y) && Mathf.Approximately(a.z, b.z);
		}
	}
}
