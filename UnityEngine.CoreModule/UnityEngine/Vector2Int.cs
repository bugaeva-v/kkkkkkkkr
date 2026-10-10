using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001CC RID: 460
	[Il2CppEagerStaticClassConstruction]
	[NativeType("Runtime/Math/Vector2Int.h")]
	[UsedByNativeCode]
	public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
	{
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x000212EC File Offset: 0x0001F4EC
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x00021304 File Offset: 0x0001F504
		public int x
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.m_X;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
				this.m_X = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00021310 File Offset: 0x0001F510
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x00021328 File Offset: 0x0001F528
		public int y
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.m_Y;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
				this.m_Y = value;
			}
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00021332 File Offset: 0x0001F532
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector2Int(int x, int y)
		{
			this.m_X = x;
			this.m_Y = y;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00021332 File Offset: 0x0001F532
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Set(int x, int y)
		{
			this.m_X = x;
			this.m_Y = y;
		}

		// Token: 0x17000437 RID: 1079
		public int this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				int result;
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException(string.Format("Invalid Vector2Int index addressed: {0}!", index));
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
						throw new IndexOutOfRangeException(string.Format("Invalid Vector2Int index addressed: {0}!", index));
					}
					this.y = value;
				}
				else
				{
					this.x = value;
				}
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x000213D4 File Offset: 0x0001F5D4
		public float magnitude
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Mathf.Sqrt((float)(this.x * this.x + this.y * this.y));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x00021408 File Offset: 0x0001F608
		public int sqrMagnitude
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.x * this.x + this.y * this.y;
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00021438 File Offset: 0x0001F638
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(Vector2Int a, Vector2Int b)
		{
			float num = (float)(a.x - b.x);
			float num2 = (float)(a.y - b.y);
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0002147C File Offset: 0x0001F67C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Min(Vector2Int lhs, Vector2Int rhs)
		{
			return new Vector2Int(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000214BC File Offset: 0x0001F6BC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Max(Vector2Int lhs, Vector2Int rhs)
		{
			return new Vector2Int(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y));
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x000214FC File Offset: 0x0001F6FC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Scale(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x * b.x, a.y * b.y);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00021531 File Offset: 0x0001F731
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Scale(Vector2Int scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00021560 File Offset: 0x0001F760
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clamp(Vector2Int min, Vector2Int max)
		{
			this.x = Math.Max(min.x, this.x);
			this.x = Math.Min(max.x, this.x);
			this.y = Math.Max(min.y, this.y);
			this.y = Math.Min(max.y, this.y);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000215D4 File Offset: 0x0001F7D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator Vector2(Vector2Int v)
		{
			return new Vector2((float)v.x, (float)v.y);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000215FC File Offset: 0x0001F7FC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator Vector3Int(Vector2Int v)
		{
			return new Vector3Int(v.x, v.y, 0);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00021624 File Offset: 0x0001F824
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int FloorToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y));
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00021654 File Offset: 0x0001F854
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int CeilToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y));
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00021684 File Offset: 0x0001F884
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int RoundToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x000216B4 File Offset: 0x0001F8B4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int operator -(Vector2Int v)
		{
			return new Vector2Int(-v.x, -v.y);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x000216DC File Offset: 0x0001F8DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int operator +(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x + b.x, a.y + b.y);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00021714 File Offset: 0x0001F914
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int operator -(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x - b.x, a.y - b.y);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0002174C File Offset: 0x0001F94C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int operator *(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x * b.x, a.y * b.y);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00021784 File Offset: 0x0001F984
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int operator *(int a, Vector2Int b)
		{
			return new Vector2Int(a * b.x, a * b.y);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x000217B0 File Offset: 0x0001F9B0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int operator *(Vector2Int a, int b)
		{
			return new Vector2Int(a.x * b, a.y * b);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000217DC File Offset: 0x0001F9DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int operator /(Vector2Int a, int b)
		{
			return new Vector2Int(a.x / b, a.y / b);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00021808 File Offset: 0x0001FA08
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Vector2Int lhs, Vector2Int rhs)
		{
			return lhs.x == rhs.x && lhs.y == rhs.y;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00021840 File Offset: 0x0001FA40
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Vector2Int lhs, Vector2Int rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0002185C File Offset: 0x0001FA5C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object other)
		{
			bool flag = !(other is Vector2Int);
			return !flag && this.Equals((Vector2Int)other);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00021890 File Offset: 0x0001FA90
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(Vector2Int other)
		{
			return this.x == other.x && this.y == other.y;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000218C4 File Offset: 0x0001FAC4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ this.y.GetHashCode() << 2;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000218F8 File Offset: 0x0001FAF8
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00021914 File Offset: 0x0001FB14
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00021930 File Offset: 0x0001FB30
		public string ToString(string format, IFormatProvider formatProvider)
		{
			bool flag = formatProvider == null;
			if (flag)
			{
				formatProvider = CultureInfo.InvariantCulture.NumberFormat;
			}
			return UnityString.Format("({0}, {1})", new object[]
			{
				this.x.ToString(format, formatProvider),
				this.y.ToString(format, formatProvider)
			});
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x0002198C File Offset: 0x0001FB8C
		public static Vector2Int zero
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2Int.s_Zero;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x000219A4 File Offset: 0x0001FBA4
		public static Vector2Int one
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2Int.s_One;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x000219BC File Offset: 0x0001FBBC
		public static Vector2Int up
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2Int.s_Up;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x000219D4 File Offset: 0x0001FBD4
		public static Vector2Int down
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2Int.s_Down;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x000219EC File Offset: 0x0001FBEC
		public static Vector2Int left
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2Int.s_Left;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x00021A04 File Offset: 0x0001FC04
		public static Vector2Int right
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Vector2Int.s_Right;
			}
		}

		// Token: 0x0400078D RID: 1933
		private int m_X;

		// Token: 0x0400078E RID: 1934
		private int m_Y;

		// Token: 0x0400078F RID: 1935
		private static readonly Vector2Int s_Zero = new Vector2Int(0, 0);

		// Token: 0x04000790 RID: 1936
		private static readonly Vector2Int s_One = new Vector2Int(1, 1);

		// Token: 0x04000791 RID: 1937
		private static readonly Vector2Int s_Up = new Vector2Int(0, 1);

		// Token: 0x04000792 RID: 1938
		private static readonly Vector2Int s_Down = new Vector2Int(0, -1);

		// Token: 0x04000793 RID: 1939
		private static readonly Vector2Int s_Left = new Vector2Int(-1, 0);

		// Token: 0x04000794 RID: 1940
		private static readonly Vector2Int s_Right = new Vector2Int(1, 0);
	}
}
