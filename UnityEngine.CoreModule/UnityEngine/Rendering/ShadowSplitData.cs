using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000413 RID: 1043
	[UsedByNativeCode]
	public struct ShadowSplitData : IEquatable<ShadowSplitData>
	{
		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060023FA RID: 9210 RVA: 0x0003CBFC File Offset: 0x0003ADFC
		// (set) Token: 0x060023FB RID: 9211 RVA: 0x0003CC14 File Offset: 0x0003AE14
		public int cullingPlaneCount
		{
			get
			{
				return this.m_CullingPlaneCount;
			}
			set
			{
				bool flag = value < 0 || value > 10;
				if (flag)
				{
					throw new ArgumentException(string.Format("Value should range from {0} to ShadowSplitData.maximumCullingPlaneCount ({1}), but was {2}.", 0, 10, value));
				}
				this.m_CullingPlaneCount = value;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x0003CC5C File Offset: 0x0003AE5C
		// (set) Token: 0x060023FD RID: 9213 RVA: 0x0003CC74 File Offset: 0x0003AE74
		public Vector4 cullingSphere
		{
			get
			{
				return this.m_CullingSphere;
			}
			set
			{
				this.m_CullingSphere = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x0003CC80 File Offset: 0x0003AE80
		// (set) Token: 0x060023FF RID: 9215 RVA: 0x0003CC98 File Offset: 0x0003AE98
		public float shadowCascadeBlendCullingFactor
		{
			get
			{
				return this.m_ShadowCascadeBlendCullingFactor;
			}
			set
			{
				bool flag = value < 0f || value > 1f;
				if (flag)
				{
					throw new ArgumentException(string.Format("Value should range from {0} to {1}, but was {2}.", 0, 1, value));
				}
				this.m_ShadowCascadeBlendCullingFactor = value;
			}
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x0003CCE8 File Offset: 0x0003AEE8
		public unsafe Plane GetCullingPlane(int index)
		{
			bool flag = index < 0 || index >= this.cullingPlaneCount;
			if (flag)
			{
				throw new ArgumentException("index", string.Format("Index should be at least {0} and less than cullingPlaneCount ({1}), but was {2}.", 0, this.cullingPlaneCount, index));
			}
			fixed (byte* ptr = &this.m_CullingPlanes.FixedElementField)
			{
				byte* ptr2 = ptr;
				Plane* ptr3 = (Plane*)ptr2;
				return ptr3[index];
			}
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x0003CD64 File Offset: 0x0003AF64
		public unsafe void SetCullingPlane(int index, Plane plane)
		{
			bool flag = index < 0 || index >= this.cullingPlaneCount;
			if (flag)
			{
				throw new ArgumentException("index", string.Format("Index should be at least {0} and less than cullingPlaneCount ({1}), but was {2}.", 0, this.cullingPlaneCount, index));
			}
			fixed (byte* ptr = &this.m_CullingPlanes.FixedElementField)
			{
				byte* ptr2 = ptr;
				Plane* ptr3 = (Plane*)ptr2;
				ptr3[index] = plane;
			}
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x0003CDDC File Offset: 0x0003AFDC
		public bool Equals(ShadowSplitData other)
		{
			bool flag = this.m_CullingPlaneCount != other.m_CullingPlaneCount;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				for (int i = 0; i < this.cullingPlaneCount; i++)
				{
					bool flag2 = !this.GetCullingPlane(i).Equals(other.GetCullingPlane(i));
					if (flag2)
					{
						return false;
					}
				}
				result = this.m_CullingSphere.Equals(other.m_CullingSphere);
			}
			return result;
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x0003CE64 File Offset: 0x0003B064
		public override bool Equals(object obj)
		{
			bool flag = obj == null;
			return !flag && obj is ShadowSplitData && this.Equals((ShadowSplitData)obj);
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0003CE9C File Offset: 0x0003B09C
		public override int GetHashCode()
		{
			return this.m_CullingPlaneCount * 397 ^ this.m_CullingSphere.GetHashCode();
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0003CED0 File Offset: 0x0003B0D0
		public static bool operator ==(ShadowSplitData left, ShadowSplitData right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0003CEEC File Offset: 0x0003B0EC
		public static bool operator !=(ShadowSplitData left, ShadowSplitData right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04000D41 RID: 3393
		private const int k_MaximumCullingPlaneCount = 10;

		// Token: 0x04000D42 RID: 3394
		public static readonly int maximumCullingPlaneCount = 10;

		// Token: 0x04000D43 RID: 3395
		private int m_CullingPlaneCount;

		// Token: 0x04000D44 RID: 3396
		[FixedBuffer(typeof(byte), 160)]
		internal ShadowSplitData.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes;

		// Token: 0x04000D45 RID: 3397
		private Vector4 m_CullingSphere;

		// Token: 0x04000D46 RID: 3398
		private float m_ShadowCascadeBlendCullingFactor;

		// Token: 0x04000D47 RID: 3399
		private float m_CullingNearPlane;

		// Token: 0x02000414 RID: 1044
		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(LayoutKind.Sequential, Size = 160)]
		public struct <m_CullingPlanes>e__FixedBuffer
		{
			// Token: 0x04000D48 RID: 3400
			public byte FixedElementField;
		}
	}
}
