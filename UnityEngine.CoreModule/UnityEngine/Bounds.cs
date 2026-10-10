using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000110 RID: 272
	[NativeClass("AABB")]
	[NativeHeader("Runtime/Geometry/Ray.h")]
	[NativeHeader("Runtime/Geometry/AABB.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[NativeHeader("Runtime/Geometry/Intersection.h")]
	[NativeType(Header = "Runtime/Geometry/AABB.h")]
	public struct Bounds : IEquatable<Bounds>, IFormattable
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x00008DCD File Offset: 0x00006FCD
		public Bounds(Vector3 center, Vector3 size)
		{
			this.m_Center = center;
			this.m_Extents = size * 0.5f;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00008DE8 File Offset: 0x00006FE8
		public override int GetHashCode()
		{
			return this.center.GetHashCode() ^ this.extents.GetHashCode() << 2;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00008E28 File Offset: 0x00007028
		public override bool Equals(object other)
		{
			bool flag = !(other is Bounds);
			return !flag && this.Equals((Bounds)other);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00008E5C File Offset: 0x0000705C
		public bool Equals(Bounds other)
		{
			return this.center.Equals(other.center) && this.extents.Equals(other.extents);
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00008EA0 File Offset: 0x000070A0
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00008EB8 File Offset: 0x000070B8
		public Vector3 center
		{
			get
			{
				return this.m_Center;
			}
			set
			{
				this.m_Center = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00008EC4 File Offset: 0x000070C4
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00008EE6 File Offset: 0x000070E6
		public Vector3 size
		{
			get
			{
				return this.m_Extents * 2f;
			}
			set
			{
				this.m_Extents = value * 0.5f;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00008EFC File Offset: 0x000070FC
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00008F14 File Offset: 0x00007114
		public Vector3 extents
		{
			get
			{
				return this.m_Extents;
			}
			set
			{
				this.m_Extents = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00008F20 File Offset: 0x00007120
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00008F43 File Offset: 0x00007143
		public Vector3 min
		{
			get
			{
				return this.center - this.extents;
			}
			set
			{
				this.SetMinMax(value, this.max);
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00008F54 File Offset: 0x00007154
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00008F77 File Offset: 0x00007177
		public Vector3 max
		{
			get
			{
				return this.center + this.extents;
			}
			set
			{
				this.SetMinMax(this.min, value);
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00008F88 File Offset: 0x00007188
		public static bool operator ==(Bounds lhs, Bounds rhs)
		{
			return lhs.center == rhs.center && lhs.extents == rhs.extents;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00008FC8 File Offset: 0x000071C8
		public static bool operator !=(Bounds lhs, Bounds rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00008FE4 File Offset: 0x000071E4
		public void SetMinMax(Vector3 min, Vector3 max)
		{
			this.extents = (max - min) * 0.5f;
			this.center = min + this.extents;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00009012 File Offset: 0x00007212
		public void Encapsulate(Vector3 point)
		{
			this.SetMinMax(Vector3.Min(this.min, point), Vector3.Max(this.max, point));
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00009034 File Offset: 0x00007234
		public void Encapsulate(Bounds bounds)
		{
			this.Encapsulate(bounds.center - bounds.extents);
			this.Encapsulate(bounds.center + bounds.extents);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0000906B File Offset: 0x0000726B
		public void Expand(float amount)
		{
			amount *= 0.5f;
			this.extents += new Vector3(amount, amount, amount);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00009091 File Offset: 0x00007291
		public void Expand(Vector3 amount)
		{
			this.extents += amount * 0.5f;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000090B4 File Offset: 0x000072B4
		public bool Intersects(Bounds bounds)
		{
			return this.min.x <= bounds.max.x && this.max.x >= bounds.min.x && this.min.y <= bounds.max.y && this.max.y >= bounds.min.y && this.min.z <= bounds.max.z && this.max.z >= bounds.min.z;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00009168 File Offset: 0x00007368
		public bool IntersectRay(Ray ray)
		{
			float num;
			return Bounds.IntersectRayAABB(ray, this, out num);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00009188 File Offset: 0x00007388
		public bool IntersectRay(Ray ray, out float distance)
		{
			return Bounds.IntersectRayAABB(ray, this, out distance);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000091A8 File Offset: 0x000073A8
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000091C4 File Offset: 0x000073C4
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000091E0 File Offset: 0x000073E0
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
			return UnityString.Format("Center: {0}, Extents: {1}", new object[]
			{
				this.m_Center.ToString(format, formatProvider),
				this.m_Extents.ToString(format, formatProvider)
			});
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00009247 File Offset: 0x00007447
		[NativeMethod("IsInside", IsThreadSafe = true)]
		public bool Contains(Vector3 point)
		{
			return Bounds.Contains_Injected(ref this, ref point);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00009251 File Offset: 0x00007451
		[FreeFunction("BoundsScripting::SqrDistance", HasExplicitThis = true, IsThreadSafe = true)]
		public float SqrDistance(Vector3 point)
		{
			return Bounds.SqrDistance_Injected(ref this, ref point);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0000925B File Offset: 0x0000745B
		[FreeFunction("IntersectRayAABB", IsThreadSafe = true)]
		private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist)
		{
			return Bounds.IntersectRayAABB_Injected(ref ray, ref bounds, out dist);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00009268 File Offset: 0x00007468
		[FreeFunction("BoundsScripting::ClosestPoint", HasExplicitThis = true, IsThreadSafe = true)]
		public Vector3 ClosestPoint(Vector3 point)
		{
			Vector3 result;
			Bounds.ClosestPoint_Injected(ref this, ref point, out result);
			return result;
		}

		// Token: 0x060006A2 RID: 1698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point);

		// Token: 0x060006A3 RID: 1699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point);

		// Token: 0x060006A4 RID: 1700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist);

		// Token: 0x060006A5 RID: 1701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret);

		// Token: 0x04000388 RID: 904
		private Vector3 m_Center;

		// Token: 0x04000389 RID: 905
		[NativeName("m_Extent")]
		private Vector3 m_Extents;
	}
}
