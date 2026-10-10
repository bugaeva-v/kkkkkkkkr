using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020001E6 RID: 486
	[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
	public static class Random
	{
		// Token: 0x06001600 RID: 5632
		[StaticAccessor("GetScriptingRand()", StaticAccessorType.Dot)]
		[NativeMethod("SetSeed")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitState(int seed);

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x0002357C File Offset: 0x0002177C
		// (set) Token: 0x06001602 RID: 5634 RVA: 0x00023591 File Offset: 0x00021791
		[StaticAccessor("GetScriptingRand()", StaticAccessorType.Dot)]
		public static Random.State state
		{
			get
			{
				Random.State result;
				Random.get_state_Injected(out result);
				return result;
			}
			set
			{
				Random.set_state_Injected(ref value);
			}
		}

		// Token: 0x06001603 RID: 5635
		[FreeFunction]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Range(float minInclusive, float maxInclusive);

		// Token: 0x06001604 RID: 5636 RVA: 0x0002359C File Offset: 0x0002179C
		public static int Range(int minInclusive, int maxExclusive)
		{
			return Random.RandomRangeInt(minInclusive, maxExclusive);
		}

		// Token: 0x06001605 RID: 5637
		[FreeFunction]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int RandomRangeInt(int minInclusive, int maxExclusive);

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001606 RID: 5638
		public static extern float value { [FreeFunction] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x000235B8 File Offset: 0x000217B8
		public static Vector3 insideUnitSphere
		{
			[FreeFunction]
			get
			{
				Vector3 result;
				Random.get_insideUnitSphere_Injected(out result);
				return result;
			}
		}

		// Token: 0x06001608 RID: 5640
		[FreeFunction]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetRandomUnitCircle(out Vector2 output);

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x000235D0 File Offset: 0x000217D0
		public static Vector2 insideUnitCircle
		{
			get
			{
				Vector2 result;
				Random.GetRandomUnitCircle(out result);
				return result;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x000235EC File Offset: 0x000217EC
		public static Vector3 onUnitSphere
		{
			[FreeFunction]
			get
			{
				Vector3 result;
				Random.get_onUnitSphere_Injected(out result);
				return result;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x00023604 File Offset: 0x00021804
		public static Quaternion rotation
		{
			[FreeFunction]
			get
			{
				Quaternion result;
				Random.get_rotation_Injected(out result);
				return result;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x0002361C File Offset: 0x0002181C
		public static Quaternion rotationUniform
		{
			[FreeFunction]
			get
			{
				Quaternion result;
				Random.get_rotationUniform_Injected(out result);
				return result;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x0600160D RID: 5645
		// (set) Token: 0x0600160E RID: 5646
		[Obsolete("Deprecated. Use InitState() function or Random.state property instead.")]
		[StaticAccessor("GetScriptingRand()", StaticAccessorType.Dot)]
		public static extern int seed { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600160F RID: 5647 RVA: 0x00023634 File Offset: 0x00021834
		[Obsolete("Use Random.Range instead")]
		public static float RandomRange(float min, float max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00023650 File Offset: 0x00021850
		[Obsolete("Use Random.Range instead")]
		public static int RandomRange(int min, int max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x0002366C File Offset: 0x0002186C
		public static Color ColorHSV()
		{
			return Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000236AC File Offset: 0x000218AC
		public static Color ColorHSV(float hueMin, float hueMax)
		{
			return Random.ColorHSV(hueMin, hueMax, 0f, 1f, 0f, 1f, 1f, 1f);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x000236E4 File Offset: 0x000218E4
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax)
		{
			return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, 0f, 1f, 1f, 1f);
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00023714 File Offset: 0x00021914
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax)
		{
			return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, 1f, 1f);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00023740 File Offset: 0x00021940
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax)
		{
			float h = Mathf.Lerp(hueMin, hueMax, Random.value);
			float s = Mathf.Lerp(saturationMin, saturationMax, Random.value);
			float v = Mathf.Lerp(valueMin, valueMax, Random.value);
			Color result = Color.HSVToRGB(h, s, v, true);
			result.a = Mathf.Lerp(alphaMin, alphaMax, Random.value);
			return result;
		}

		// Token: 0x06001616 RID: 5654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_state_Injected(out Random.State ret);

		// Token: 0x06001617 RID: 5655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_state_Injected(ref Random.State value);

		// Token: 0x06001618 RID: 5656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_insideUnitSphere_Injected(out Vector3 ret);

		// Token: 0x06001619 RID: 5657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_onUnitSphere_Injected(out Vector3 ret);

		// Token: 0x0600161A RID: 5658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_rotation_Injected(out Quaternion ret);

		// Token: 0x0600161B RID: 5659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_rotationUniform_Injected(out Quaternion ret);

		// Token: 0x020001E7 RID: 487
		[Serializable]
		public struct State
		{
			// Token: 0x040007C5 RID: 1989
			[SerializeField]
			private int s0;

			// Token: 0x040007C6 RID: 1990
			[SerializeField]
			private int s1;

			// Token: 0x040007C7 RID: 1991
			[SerializeField]
			private int s2;

			// Token: 0x040007C8 RID: 1992
			[SerializeField]
			private int s3;
		}
	}
}
