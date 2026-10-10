using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x0200041F RID: 1055
	[UsedByNativeCode]
	public struct VisibleReflectionProbe : IEquatable<VisibleReflectionProbe>
	{
		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x0003E139 File Offset: 0x0003C339
		public Texture texture
		{
			get
			{
				return (Texture)Object.FindObjectFromInstanceID(this.m_TextureId);
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x0003E14B File Offset: 0x0003C34B
		public ReflectionProbe reflectionProbe
		{
			get
			{
				return (ReflectionProbe)Object.FindObjectFromInstanceID(this.m_InstanceId);
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x0003E160 File Offset: 0x0003C360
		// (set) Token: 0x060024AA RID: 9386 RVA: 0x0003E178 File Offset: 0x0003C378
		public Bounds bounds
		{
			get
			{
				return this.m_Bounds;
			}
			set
			{
				this.m_Bounds = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x0003E184 File Offset: 0x0003C384
		// (set) Token: 0x060024AC RID: 9388 RVA: 0x0003E19C File Offset: 0x0003C39C
		public Matrix4x4 localToWorldMatrix
		{
			get
			{
				return this.m_LocalToWorldMatrix;
			}
			set
			{
				this.m_LocalToWorldMatrix = value;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x0003E1A8 File Offset: 0x0003C3A8
		// (set) Token: 0x060024AE RID: 9390 RVA: 0x0003E1C0 File Offset: 0x0003C3C0
		public Vector4 hdrData
		{
			get
			{
				return this.m_HdrData;
			}
			set
			{
				this.m_HdrData = value;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x0003E1CC File Offset: 0x0003C3CC
		// (set) Token: 0x060024B0 RID: 9392 RVA: 0x0003E1E4 File Offset: 0x0003C3E4
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

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x0003E1F0 File Offset: 0x0003C3F0
		// (set) Token: 0x060024B2 RID: 9394 RVA: 0x0003E208 File Offset: 0x0003C408
		public float blendDistance
		{
			get
			{
				return this.m_BlendDistance;
			}
			set
			{
				this.m_BlendDistance = value;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x0003E214 File Offset: 0x0003C414
		// (set) Token: 0x060024B4 RID: 9396 RVA: 0x0003E22C File Offset: 0x0003C42C
		public int importance
		{
			get
			{
				return this.m_Importance;
			}
			set
			{
				this.m_Importance = value;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x0003E238 File Offset: 0x0003C438
		// (set) Token: 0x060024B6 RID: 9398 RVA: 0x0003E255 File Offset: 0x0003C455
		public bool isBoxProjection
		{
			get
			{
				return Convert.ToBoolean(this.m_BoxProjection);
			}
			set
			{
				this.m_BoxProjection = Convert.ToInt32(value);
			}
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x0003E264 File Offset: 0x0003C464
		public bool Equals(VisibleReflectionProbe other)
		{
			return this.m_Bounds.Equals(other.m_Bounds) && this.m_LocalToWorldMatrix.Equals(other.m_LocalToWorldMatrix) && this.m_HdrData.Equals(other.m_HdrData) && this.m_Center.Equals(other.m_Center) && this.m_BlendDistance.Equals(other.m_BlendDistance) && this.m_Importance == other.m_Importance && this.m_BoxProjection == other.m_BoxProjection && this.m_InstanceId == other.m_InstanceId && this.m_TextureId == other.m_TextureId;
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x0003E314 File Offset: 0x0003C514
		public override bool Equals(object obj)
		{
			bool flag = obj == null;
			return !flag && obj is VisibleReflectionProbe && this.Equals((VisibleReflectionProbe)obj);
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x0003E34C File Offset: 0x0003C54C
		public override int GetHashCode()
		{
			int num = this.m_Bounds.GetHashCode();
			num = (num * 397 ^ this.m_LocalToWorldMatrix.GetHashCode());
			num = (num * 397 ^ this.m_HdrData.GetHashCode());
			num = (num * 397 ^ this.m_Center.GetHashCode());
			num = (num * 397 ^ this.m_BlendDistance.GetHashCode());
			num = (num * 397 ^ this.m_Importance);
			num = (num * 397 ^ this.m_BoxProjection);
			num = (num * 397 ^ this.m_InstanceId);
			return num * 397 ^ this.m_TextureId;
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x0003E410 File Offset: 0x0003C610
		public static bool operator ==(VisibleReflectionProbe left, VisibleReflectionProbe right)
		{
			return left.Equals(right);
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x0003E42C File Offset: 0x0003C62C
		public static bool operator !=(VisibleReflectionProbe left, VisibleReflectionProbe right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04000D9C RID: 3484
		private Bounds m_Bounds;

		// Token: 0x04000D9D RID: 3485
		private Matrix4x4 m_LocalToWorldMatrix;

		// Token: 0x04000D9E RID: 3486
		private Vector4 m_HdrData;

		// Token: 0x04000D9F RID: 3487
		private Vector3 m_Center;

		// Token: 0x04000DA0 RID: 3488
		private float m_BlendDistance;

		// Token: 0x04000DA1 RID: 3489
		private int m_Importance;

		// Token: 0x04000DA2 RID: 3490
		private int m_BoxProjection;

		// Token: 0x04000DA3 RID: 3491
		private int m_InstanceId;

		// Token: 0x04000DA4 RID: 3492
		private int m_TextureId;
	}
}
