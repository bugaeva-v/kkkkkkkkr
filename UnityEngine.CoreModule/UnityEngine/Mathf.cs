using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020001C9 RID: 457
	[NativeHeader("Runtime/Math/FloatConversion.h")]
	[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
	[NativeHeader("Runtime/Math/PerlinNoise.h")]
	[Il2CppEagerStaticClassConstruction]
	[NativeHeader("Runtime/Utilities/BitUtility.h")]
	public struct Mathf
	{
		// Token: 0x0600149E RID: 5278
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int ClosestPowerOfTwo(int value);

		// Token: 0x0600149F RID: 5279
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsPowerOfTwo(int value);

		// Token: 0x060014A0 RID: 5280
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int NextPowerOfTwo(int value);

		// Token: 0x060014A1 RID: 5281
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GammaToLinearSpace(float value);

		// Token: 0x060014A2 RID: 5282
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float LinearToGammaSpace(float value);

		// Token: 0x060014A3 RID: 5283 RVA: 0x0001FBA0 File Offset: 0x0001DDA0
		[FreeFunction(IsThreadSafe = true)]
		public static Color CorrelatedColorTemperatureToRGB(float kelvin)
		{
			Color result;
			Mathf.CorrelatedColorTemperatureToRGB_Injected(kelvin, out result);
			return result;
		}

		// Token: 0x060014A4 RID: 5284
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ushort FloatToHalf(float val);

		// Token: 0x060014A5 RID: 5285
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float HalfToFloat(ushort val);

		// Token: 0x060014A6 RID: 5286
		[FreeFunction("PerlinNoise::NoiseNormalized", IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float PerlinNoise(float x, float y);

		// Token: 0x060014A7 RID: 5287 RVA: 0x0001FBB8 File Offset: 0x0001DDB8
		public static float Sin(float f)
		{
			return (float)Math.Sin((double)f);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0001FBD4 File Offset: 0x0001DDD4
		public static float Cos(float f)
		{
			return (float)Math.Cos((double)f);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
		public static float Tan(float f)
		{
			return (float)Math.Tan((double)f);
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0001FC0C File Offset: 0x0001DE0C
		public static float Asin(float f)
		{
			return (float)Math.Asin((double)f);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0001FC28 File Offset: 0x0001DE28
		public static float Acos(float f)
		{
			return (float)Math.Acos((double)f);
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0001FC44 File Offset: 0x0001DE44
		public static float Atan(float f)
		{
			return (float)Math.Atan((double)f);
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0001FC60 File Offset: 0x0001DE60
		public static float Atan2(float y, float x)
		{
			return (float)Math.Atan2((double)y, (double)x);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0001FC7C File Offset: 0x0001DE7C
		public static float Sqrt(float f)
		{
			return (float)Math.Sqrt((double)f);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0001FC98 File Offset: 0x0001DE98
		public static float Abs(float f)
		{
			return Math.Abs(f);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
		public static int Abs(int value)
		{
			return Math.Abs(value);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
		public static float Min(float a, float b)
		{
			return (a < b) ? a : b;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0001FCE4 File Offset: 0x0001DEE4
		public static float Min(params float[] values)
		{
			int num = values.Length;
			bool flag = num == 0;
			float result;
			if (flag)
			{
				result = 0f;
			}
			else
			{
				float num2 = values[0];
				for (int i = 1; i < num; i++)
				{
					bool flag2 = values[i] < num2;
					if (flag2)
					{
						num2 = values[i];
					}
				}
				result = num2;
			}
			return result;
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0001FD3C File Offset: 0x0001DF3C
		public static int Min(int a, int b)
		{
			return (a < b) ? a : b;
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0001FD58 File Offset: 0x0001DF58
		public static int Min(params int[] values)
		{
			int num = values.Length;
			bool flag = num == 0;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				int num2 = values[0];
				for (int i = 1; i < num; i++)
				{
					bool flag2 = values[i] < num2;
					if (flag2)
					{
						num2 = values[i];
					}
				}
				result = num2;
			}
			return result;
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0001FDAC File Offset: 0x0001DFAC
		public static float Max(float a, float b)
		{
			return (a > b) ? a : b;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0001FDC8 File Offset: 0x0001DFC8
		public static float Max(params float[] values)
		{
			int num = values.Length;
			bool flag = num == 0;
			float result;
			if (flag)
			{
				result = 0f;
			}
			else
			{
				float num2 = values[0];
				for (int i = 1; i < num; i++)
				{
					bool flag2 = values[i] > num2;
					if (flag2)
					{
						num2 = values[i];
					}
				}
				result = num2;
			}
			return result;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0001FE20 File Offset: 0x0001E020
		public static int Max(int a, int b)
		{
			return (a > b) ? a : b;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0001FE3C File Offset: 0x0001E03C
		public static int Max(params int[] values)
		{
			int num = values.Length;
			bool flag = num == 0;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				int num2 = values[0];
				for (int i = 1; i < num; i++)
				{
					bool flag2 = values[i] > num2;
					if (flag2)
					{
						num2 = values[i];
					}
				}
				result = num2;
			}
			return result;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0001FE90 File Offset: 0x0001E090
		public static float Pow(float f, float p)
		{
			return (float)Math.Pow((double)f, (double)p);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0001FEAC File Offset: 0x0001E0AC
		public static float Exp(float power)
		{
			return (float)Math.Exp((double)power);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0001FEC8 File Offset: 0x0001E0C8
		public static float Log(float f, float p)
		{
			return (float)Math.Log((double)f, (double)p);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0001FEE4 File Offset: 0x0001E0E4
		public static float Log(float f)
		{
			return (float)Math.Log((double)f);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0001FF00 File Offset: 0x0001E100
		public static float Log10(float f)
		{
			return (float)Math.Log10((double)f);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0001FF1C File Offset: 0x0001E11C
		public static float Ceil(float f)
		{
			return (float)Math.Ceiling((double)f);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0001FF38 File Offset: 0x0001E138
		public static float Floor(float f)
		{
			return (float)Math.Floor((double)f);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0001FF54 File Offset: 0x0001E154
		public static float Round(float f)
		{
			return (float)Math.Round((double)f);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0001FF70 File Offset: 0x0001E170
		public static int CeilToInt(float f)
		{
			return (int)Math.Ceiling((double)f);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0001FF8C File Offset: 0x0001E18C
		public static int FloorToInt(float f)
		{
			return (int)Math.Floor((double)f);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0001FFA8 File Offset: 0x0001E1A8
		public static int RoundToInt(float f)
		{
			return (int)Math.Round((double)f);
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0001FFC4 File Offset: 0x0001E1C4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sign(float f)
		{
			return (f >= 0f) ? 1f : -1f;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0001FFEC File Offset: 0x0001E1EC
		public static float Clamp(float value, float min, float max)
		{
			bool flag = value < min;
			if (flag)
			{
				value = min;
			}
			else
			{
				bool flag2 = value > max;
				if (flag2)
				{
					value = max;
				}
			}
			return value;
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00020018 File Offset: 0x0001E218
		public static int Clamp(int value, int min, int max)
		{
			bool flag = value < min;
			if (flag)
			{
				value = min;
			}
			else
			{
				bool flag2 = value > max;
				if (flag2)
				{
					value = max;
				}
			}
			return value;
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00020044 File Offset: 0x0001E244
		public static float Clamp01(float value)
		{
			bool flag = value < 0f;
			float result;
			if (flag)
			{
				result = 0f;
			}
			else
			{
				bool flag2 = value > 1f;
				if (flag2)
				{
					result = 1f;
				}
				else
				{
					result = value;
				}
			}
			return result;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00020080 File Offset: 0x0001E280
		public static float Lerp(float a, float b, float t)
		{
			return a + (b - a) * Mathf.Clamp01(t);
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x000200A0 File Offset: 0x0001E2A0
		public static float LerpUnclamped(float a, float b, float t)
		{
			return a + (b - a) * t;
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000200BC File Offset: 0x0001E2BC
		public static float LerpAngle(float a, float b, float t)
		{
			float num = Mathf.Repeat(b - a, 360f);
			bool flag = num > 180f;
			if (flag)
			{
				num -= 360f;
			}
			return a + num * Mathf.Clamp01(t);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x000200FC File Offset: 0x0001E2FC
		public static float MoveTowards(float current, float target, float maxDelta)
		{
			bool flag = Mathf.Abs(target - current) <= maxDelta;
			float result;
			if (flag)
			{
				result = target;
			}
			else
			{
				result = current + Mathf.Sign(target - current) * maxDelta;
			}
			return result;
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00020130 File Offset: 0x0001E330
		public static float MoveTowardsAngle(float current, float target, float maxDelta)
		{
			float num = Mathf.DeltaAngle(current, target);
			bool flag = -maxDelta < num && num < maxDelta;
			float result;
			if (flag)
			{
				result = target;
			}
			else
			{
				target = current + num;
				result = Mathf.MoveTowards(current, target, maxDelta);
			}
			return result;
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0002016C File Offset: 0x0001E36C
		public static float SmoothStep(float from, float to, float t)
		{
			t = Mathf.Clamp01(t);
			t = -2f * t * t * t + 3f * t * t;
			return to * t + from * (1f - t);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x000201AC File Offset: 0x0001E3AC
		public static float Gamma(float value, float absmax, float gamma)
		{
			bool flag = value < 0f;
			float num = Mathf.Abs(value);
			bool flag2 = num > absmax;
			float result;
			if (flag2)
			{
				result = (flag ? (-num) : num);
			}
			else
			{
				float num2 = Mathf.Pow(num / absmax, gamma) * absmax;
				result = (flag ? (-num2) : num2);
			}
			return result;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x000201F8 File Offset: 0x0001E3F8
		public static bool Approximately(float a, float b)
		{
			return Mathf.Abs(b - a) < Mathf.Max(1E-06f * Mathf.Max(Mathf.Abs(a), Mathf.Abs(b)), Mathf.Epsilon * 8f);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0002023C File Offset: 0x0001E43C
		[ExcludeFromDocs]
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00020260 File Offset: 0x0001E460
		[ExcludeFromDocs]
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime)
		{
			float deltaTime = Time.deltaTime;
			float positiveInfinity = float.PositiveInfinity;
			return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, positiveInfinity, deltaTime);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0002028C File Offset: 0x0001E48C
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			smoothTime = Mathf.Max(0.0001f, smoothTime);
			float num = 2f / smoothTime;
			float num2 = num * deltaTime;
			float num3 = 1f / (1f + num2 + 0.48f * num2 * num2 + 0.235f * num2 * num2 * num2);
			float num4 = current - target;
			float num5 = target;
			float num6 = maxSpeed * smoothTime;
			num4 = Mathf.Clamp(num4, -num6, num6);
			target = current - num4;
			float num7 = (currentVelocity + num * num4) * deltaTime;
			currentVelocity = (currentVelocity - num * num7) * num3;
			float num8 = target + (num4 + num7) * num3;
			bool flag = num5 - current > 0f == num8 > num5;
			if (flag)
			{
				num8 = num5;
				currentVelocity = (num8 - num5) / deltaTime;
			}
			return num8;
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00020348 File Offset: 0x0001E548
		[ExcludeFromDocs]
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0002036C File Offset: 0x0001E56C
		[ExcludeFromDocs]
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime)
		{
			float deltaTime = Time.deltaTime;
			float positiveInfinity = float.PositiveInfinity;
			return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, positiveInfinity, deltaTime);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00020398 File Offset: 0x0001E598
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			target = current + Mathf.DeltaAngle(current, target);
			return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x000203C4 File Offset: 0x0001E5C4
		public static float Repeat(float t, float length)
		{
			return Mathf.Clamp(t - Mathf.Floor(t / length) * length, 0f, length);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000203F0 File Offset: 0x0001E5F0
		public static float PingPong(float t, float length)
		{
			t = Mathf.Repeat(t, length * 2f);
			return length - Mathf.Abs(t - length);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0002041C File Offset: 0x0001E61C
		public static float InverseLerp(float a, float b, float value)
		{
			bool flag = a != b;
			float result;
			if (flag)
			{
				result = Mathf.Clamp01((value - a) / (b - a));
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00020450 File Offset: 0x0001E650
		public static float DeltaAngle(float current, float target)
		{
			float num = Mathf.Repeat(target - current, 360f);
			bool flag = num > 180f;
			if (flag)
			{
				num -= 360f;
			}
			return num;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00020488 File Offset: 0x0001E688
		internal static bool LineIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
		{
			float num = p2.x - p1.x;
			float num2 = p2.y - p1.y;
			float num3 = p4.x - p3.x;
			float num4 = p4.y - p3.y;
			float num5 = num * num4 - num2 * num3;
			bool flag = num5 == 0f;
			bool result2;
			if (flag)
			{
				result2 = false;
			}
			else
			{
				float num6 = p3.x - p1.x;
				float num7 = p3.y - p1.y;
				float num8 = (num6 * num4 - num7 * num3) / num5;
				result.x = p1.x + num8 * num;
				result.y = p1.y + num8 * num2;
				result2 = true;
			}
			return result2;
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00020544 File Offset: 0x0001E744
		internal static bool LineSegmentIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
		{
			float num = p2.x - p1.x;
			float num2 = p2.y - p1.y;
			float num3 = p4.x - p3.x;
			float num4 = p4.y - p3.y;
			float num5 = num * num4 - num2 * num3;
			bool flag = num5 == 0f;
			bool result2;
			if (flag)
			{
				result2 = false;
			}
			else
			{
				float num6 = p3.x - p1.x;
				float num7 = p3.y - p1.y;
				float num8 = (num6 * num4 - num7 * num3) / num5;
				bool flag2 = num8 < 0f || num8 > 1f;
				if (flag2)
				{
					result2 = false;
				}
				else
				{
					float num9 = (num6 * num2 - num7 * num) / num5;
					bool flag3 = num9 < 0f || num9 > 1f;
					if (flag3)
					{
						result2 = false;
					}
					else
					{
						result.x = p1.x + num8 * num;
						result.y = p1.y + num8 * num2;
						result2 = true;
					}
				}
			}
			return result2;
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00020654 File Offset: 0x0001E854
		internal static long RandomToLong(Random r)
		{
			byte[] array = new byte[8];
			r.NextBytes(array);
			return (long)(BitConverter.ToUInt64(array, 0) & 9223372036854775807UL);
		}

		// Token: 0x060014DE RID: 5342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret);

		// Token: 0x0400077A RID: 1914
		public const float PI = 3.1415927f;

		// Token: 0x0400077B RID: 1915
		public const float Infinity = float.PositiveInfinity;

		// Token: 0x0400077C RID: 1916
		public const float NegativeInfinity = float.NegativeInfinity;

		// Token: 0x0400077D RID: 1917
		public const float Deg2Rad = 0.017453292f;

		// Token: 0x0400077E RID: 1918
		public const float Rad2Deg = 57.29578f;

		// Token: 0x0400077F RID: 1919
		public static readonly float Epsilon = MathfInternal.IsFlushToZeroEnabled ? MathfInternal.FloatMinNormal : MathfInternal.FloatMinDenormal;
	}
}
