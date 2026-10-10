using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001CB RID: 459
	[NativeClass("Vector2f")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[Il2CppEagerStaticClassConstruction]
	public struct Vector2 : IEquatable<Vector2>, IFormattable
	{
		// Token: 0x17000429 RID: 1065
		public float this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				float result;
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException("Invalid Vector2 index!");
					}
					result = this.y;
				}
				else
				{
					result = this.x;
				}
				return result;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException("Invalid Vector2 index!");
					}
					this.y = value;
				}
				else
				{
					this.x = value;
				}
			}
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0002071A File Offset: 0x0001E91A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0002071A File Offset: 0x0001E91A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Set(float newX, float newY)
		{
			this.x = newX;
			this.y = newY;
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0002072C File Offset: 0x0001E92C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Vector2(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00020778 File Offset: 0x0001E978
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t)
		{
			return new Vector2(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000207BC File Offset: 0x0001E9BC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta)
		{
			float num = target.x - current.x;
			float num2 = target.y - current.y;
			float num3 = num * num + num2 * num2;
			bool flag = num3 == 0f || (maxDistanceDelta >= 0f && num3 <= maxDistanceDelta * maxDistanceDelta);
			Vector2 result;
			if (flag)
			{
				result = target;
			}
			else
			{
				float num4 = (float)Math.Sqrt((double)num3);
				result = new Vector2(current.x + num / num4 * maxDistanceDelta, current.y + num2 / num4 * maxDistanceDelta);
			}
			return result;
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00020844 File Offset: 0x0001EA44
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Scale(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x * b.x, a.y * b.y);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00020875 File Offset: 0x0001EA75
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Scale(Vector2 scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x000208A0 File Offset: 0x0001EAA0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Normalize()
		{
			float magnitude = this.magnitude;
			bool flag = magnitude > 1E-05f;
			if (flag)
			{
				this /= magnitude;
			}
			else
			{
				this = Vector2.zero;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x000208E0 File Offset: 0x0001EAE0
		public Vector2 normalized
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				Vector2 result = new Vector2(this.x, this.y);
				result.Normalize();
				return result;
			}
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00020910 File Offset: 0x0001EB10
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0002092C File Offset: 0x0001EB2C
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00020948 File Offset: 0x0001EB48
		public string ToString(string format, IFormatProvider formatProvider)
		{
			bool flag = string.IsNullOrEmpty(format);
			if (flag)
			{
				format = "F2";
			}
			bool flag2 = formatProvider == null;
			if (flag2)
			{
				formatProvider = CultureInfo.InvariantCulture.NumberFormat;
			}
			return UnityString.Format("({0}, {1})", new object[]
			{
				this.x.ToString(format, formatProvider),
				this.y.ToString(format, formatProvider)
			});
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x000209B0 File Offset: 0x0001EBB0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ this.y.GetHashCode() << 2;
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000209DC File Offset: 0x0001EBDC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object other)
		{
			bool flag = !(other is Vector2);
			return !flag && this.Equals((Vector2)other);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00020A10 File Offset: 0x0001EC10
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(Vector2 other)
		{
			return this.x == other.x && this.y == other.y;
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00020A44 File Offset: 0x0001EC44
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal)
		{
			float num = -2f * Vector2.Dot(inNormal, inDirection);
			return new Vector2(num * inNormal.x + inDirection.x, num * inNormal.y + inDirection.y);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00020A88 File Offset: 0x0001EC88
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Perpendicular(Vector2 inDirection)
		{
			return new Vector2(-inDirection.y, inDirection.x);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00020AAC File Offset: 0x0001ECAC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(Vector2 lhs, Vector2 rhs)
		{
			return lhs.x * rhs.x + lhs.y * rhs.y;
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00020ADC File Offset: 0x0001ECDC
		public float magnitude
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return (float)Math.Sqrt((double)(this.x * this.x + this.y * this.y));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00020B10 File Offset: 0x0001ED10
		public float sqrMagnitude
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.x * this.x + this.y * this.y;
			}
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00020B40 File Offset: 0x0001ED40
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Angle(Vector2 from, Vector2 to)
		{
			float num = (float)Math.Sqrt((double)(from.sqrMagnitude * to.sqrMagnitude));
			bool flag = num < 1E-15f;
			float result;
			if (flag)
			{
				result = 0f;
			}
			else
			{
				float num2 = Mathf.Clamp(Vector2.Dot(from, to) / num, -1f, 1f);
				result = (float)Math.Acos((double)num2) * 57.29578f;
			}
			return result;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00020BA4 File Offset: 0x0001EDA4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SignedAngle(Vector2 from, Vector2 to)
		{
			float num = Vector2.Angle(from, to);
			float num2 = Mathf.Sign(from.x * to.y - from.y * to.x);
			return num * num2;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00020BE4 File Offset: 0x0001EDE4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(Vector2 a, Vector2 b)
		{
			float num = a.x - b.x;
			float num2 = a.y - b.y;
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00020C20 File Offset: 0x0001EE20
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 ClampMagnitude(Vector2 vector, float maxLength)
		{
			float sqrMagnitude = vector.sqrMagnitude;
			bool flag = sqrMagnitude > maxLength * maxLength;
			Vector2 result;
			if (flag)
			{
				float num = (float)Math.Sqrt((double)sqrMagnitude);
				float num2 = vector.x / num;
				float num3 = vector.y / num;
				result = new Vector2(num2 * maxLength, num3 * maxLength);
			}
			else
			{
				result = vector;
			}
			return result;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00020C74 File Offset: 0x0001EE74
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(Vector2 a)
		{
			return a.x * a.x + a.y * a.y;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00020CA4 File Offset: 0x0001EEA4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float SqrMagnitude()
		{
			return this.x * this.x + this.y * this.y;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00020CD4 File Offset: 0x0001EED4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Min(Vector2 lhs, Vector2 rhs)
		{
			return new Vector2(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00020D10 File Offset: 0x0001EF10
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Max(Vector2 lhs, Vector2 rhs)
		{
			return new Vector2(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y));
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00020D4C File Offset: 0x0001EF4C
		[ExcludeFromDocs]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00020D70 File Offset: 0x0001EF70
		[ExcludeFromDocs]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime)
		{
			float deltaTime = Time.deltaTime;
			float positiveInfinity = float.PositiveInfinity;
			return Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, positiveInfinity, deltaTime);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00020D9C File Offset: 0x0001EF9C
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			smoothTime = Mathf.Max(0.0001f, smoothTime);
			float num = 2f / smoothTime;
			float num2 = num * deltaTime;
			float num3 = 1f / (1f + num2 + 0.48f * num2 * num2 + 0.235f * num2 * num2 * num2);
			float num4 = current.x - target.x;
			float num5 = current.y - target.y;
			Vector2 vector = target;
			float num6 = maxSpeed * smoothTime;
			float num7 = num6 * num6;
			float num8 = num4 * num4 + num5 * num5;
			bool flag = num8 > num7;
			if (flag)
			{
				float num9 = (float)Math.Sqrt((double)num8);
				num4 = num4 / num9 * num6;
				num5 = num5 / num9 * num6;
			}
			target.x = current.x - num4;
			target.y = current.y - num5;
			float num10 = (currentVelocity.x + num * num4) * deltaTime;
			float num11 = (currentVelocity.y + num * num5) * deltaTime;
			currentVelocity.x = (currentVelocity.x - num * num10) * num3;
			currentVelocity.y = (currentVelocity.y - num * num11) * num3;
			float num12 = target.x + (num4 + num10) * num3;
			float num13 = target.y + (num5 + num11) * num3;
			float num14 = vector.x - current.x;
			float num15 = vector.y - current.y;
			float num16 = num12 - vector.x;
			float num17 = num13 - vector.y;
			bool flag2 = num14 * num16 + num15 * num17 > 0f;
			if (flag2)
			{
				num12 = vector.x;
				num13 = vector.y;
				currentVelocity.x = (num12 - vector.x) / deltaTime;
				currentVelocity.y = (num13 - vector.y) / deltaTime;
			}
			return new Vector2(num12, num13);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00020F68 File Offset: 0x0001F168
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x + b.x, a.y + b.y);
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00020F9C File Offset: 0x0001F19C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x - b.x, a.y - b.y);
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00020FD0 File Offset: 0x0001F1D0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator *(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x * b.x, a.y * b.y);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00021004 File Offset: 0x0001F204
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator /(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x / b.x, a.y / b.y);
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00021038 File Offset: 0x0001F238
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator -(Vector2 a)
		{
			return new Vector2(-a.x, -a.y);
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00021060 File Offset: 0x0001F260
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator *(Vector2 a, float d)
		{
			return new Vector2(a.x * d, a.y * d);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00021088 File Offset: 0x0001F288
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator *(float d, Vector2 a)
		{
			return new Vector2(a.x * d, a.y * d);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x000210B0 File Offset: 0x0001F2B0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator /(Vector2 a, float d)
		{
			return new Vector2(a.x / d, a.y / d);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x000210D8 File Offset: 0x0001F2D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Vector2 lhs, Vector2 rhs)
		{
			float num = lhs.x - rhs.x;
			float num2 = lhs.y - rhs.y;
			return num * num + num2 * num2 < 9.9999994E-11f;
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00021114 File Offset: 0x0001F314
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Vector2 lhs, Vector2 rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00021130 File Offset: 0x0001F330
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator Vector2(Vector3 v)
		{
			return new Vector2(v.x, v.y);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x00021154 File Offset: 0x0001F354
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator Vector3(Vector2 v)
		{
			return new Vector3(v.x, v.y, 0f);
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x0002117C File Offset: 0x0001F37C
		public static Vector2 zero
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2.zeroVector;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x00021194 File Offset: 0x0001F394
		public static Vector2 one
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2.oneVector;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x000211AC File Offset: 0x0001F3AC
		public static Vector2 up
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2.upVector;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x000211C4 File Offset: 0x0001F3C4
		public static Vector2 down
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2.downVector;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x000211DC File Offset: 0x0001F3DC
		public static Vector2 left
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2.leftVector;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x000211F4 File Offset: 0x0001F3F4
		public static Vector2 right
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2.rightVector;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x0002120C File Offset: 0x0001F40C
		public static Vector2 positiveInfinity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2.positiveInfinityVector;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x00021224 File Offset: 0x0001F424
		public static Vector2 negativeInfinity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2.negativeInfinityVector;
			}
		}

		// Token: 0x04000781 RID: 1921
		public float x;

		// Token: 0x04000782 RID: 1922
		public float y;

		// Token: 0x04000783 RID: 1923
		private static readonly Vector2 zeroVector = new Vector2(0f, 0f);

		// Token: 0x04000784 RID: 1924
		private static readonly Vector2 oneVector = new Vector2(1f, 1f);

		// Token: 0x04000785 RID: 1925
		private static readonly Vector2 upVector = new Vector2(0f, 1f);

		// Token: 0x04000786 RID: 1926
		private static readonly Vector2 downVector = new Vector2(0f, -1f);

		// Token: 0x04000787 RID: 1927
		private static readonly Vector2 leftVector = new Vector2(-1f, 0f);

		// Token: 0x04000788 RID: 1928
		private static readonly Vector2 rightVector = new Vector2(1f, 0f);

		// Token: 0x04000789 RID: 1929
		private static readonly Vector2 positiveInfinityVector = new Vector2(float.PositiveInfinity, float.PositiveInfinity);

		// Token: 0x0400078A RID: 1930
		private static readonly Vector2 negativeInfinityVector = new Vector2(float.NegativeInfinity, float.NegativeInfinity);

		// Token: 0x0400078B RID: 1931
		public const float kEpsilon = 1E-05f;

		// Token: 0x0400078C RID: 1932
		public const float kEpsilonNormalSqrt = 1E-15f;
	}
}
