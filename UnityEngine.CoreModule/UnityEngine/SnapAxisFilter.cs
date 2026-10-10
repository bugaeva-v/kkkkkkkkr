using System;

namespace UnityEngine
{
	// Token: 0x0200023F RID: 575
	internal struct SnapAxisFilter : IEquatable<SnapAxisFilter>
	{
		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x00027B2C File Offset: 0x00025D2C
		public float x
		{
			get
			{
				return ((this.m_Mask & SnapAxis.X) == SnapAxis.X) ? 1f : 0f;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x00027B58 File Offset: 0x00025D58
		public float y
		{
			get
			{
				return ((this.m_Mask & SnapAxis.Y) == SnapAxis.Y) ? 1f : 0f;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x00027B84 File Offset: 0x00025D84
		public float z
		{
			get
			{
				return ((this.m_Mask & SnapAxis.Z) == SnapAxis.Z) ? 1f : 0f;
			}
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00027BB0 File Offset: 0x00025DB0
		public SnapAxisFilter(Vector3 v)
		{
			this.m_Mask = SnapAxis.None;
			float num = 1E-06f;
			bool flag = Mathf.Abs(v.x) > num;
			if (flag)
			{
				this.m_Mask |= SnapAxis.X;
			}
			bool flag2 = Mathf.Abs(v.y) > num;
			if (flag2)
			{
				this.m_Mask |= SnapAxis.Y;
			}
			bool flag3 = Mathf.Abs(v.z) > num;
			if (flag3)
			{
				this.m_Mask |= SnapAxis.Z;
			}
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00027C2C File Offset: 0x00025E2C
		public SnapAxisFilter(SnapAxis axis)
		{
			this.m_Mask = SnapAxis.None;
			bool flag = (axis & SnapAxis.X) == SnapAxis.X;
			if (flag)
			{
				this.m_Mask |= SnapAxis.X;
			}
			bool flag2 = (axis & SnapAxis.Y) == SnapAxis.Y;
			if (flag2)
			{
				this.m_Mask |= SnapAxis.Y;
			}
			bool flag3 = (axis & SnapAxis.Z) == SnapAxis.Z;
			if (flag3)
			{
				this.m_Mask |= SnapAxis.Z;
			}
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00027C8C File Offset: 0x00025E8C
		public override string ToString()
		{
			return string.Format("{{{0}, {1}, {2}}}", this.x, this.y, this.z);
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x00027CCC File Offset: 0x00025ECC
		public int active
		{
			get
			{
				int num = 0;
				bool flag = (this.m_Mask & SnapAxis.X) > SnapAxis.None;
				if (flag)
				{
					num++;
				}
				bool flag2 = (this.m_Mask & SnapAxis.Y) > SnapAxis.None;
				if (flag2)
				{
					num++;
				}
				bool flag3 = (this.m_Mask & SnapAxis.Z) > SnapAxis.None;
				if (flag3)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00027D1C File Offset: 0x00025F1C
		public static implicit operator Vector3(SnapAxisFilter mask)
		{
			return new Vector3(mask.x, mask.y, mask.z);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00027D48 File Offset: 0x00025F48
		public static explicit operator SnapAxisFilter(Vector3 v)
		{
			return new SnapAxisFilter(v);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00027D60 File Offset: 0x00025F60
		public static explicit operator SnapAxis(SnapAxisFilter mask)
		{
			return mask.m_Mask;
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00027D78 File Offset: 0x00025F78
		public static SnapAxisFilter operator |(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask | right.m_Mask);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00027D9C File Offset: 0x00025F9C
		public static SnapAxisFilter operator &(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask & right.m_Mask);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00027DC0 File Offset: 0x00025FC0
		public static SnapAxisFilter operator ^(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask ^ right.m_Mask);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00027DE4 File Offset: 0x00025FE4
		public static SnapAxisFilter operator ~(SnapAxisFilter left)
		{
			return new SnapAxisFilter(~left.m_Mask);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00027E04 File Offset: 0x00026004
		public static Vector3 operator *(SnapAxisFilter mask, float value)
		{
			return new Vector3(mask.x * value, mask.y * value, mask.z * value);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00027E38 File Offset: 0x00026038
		public static Vector3 operator *(SnapAxisFilter mask, Vector3 right)
		{
			return new Vector3(mask.x * right.x, mask.y * right.y, mask.z * right.z);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00027E7C File Offset: 0x0002607C
		public static Vector3 operator *(Quaternion rotation, SnapAxisFilter mask)
		{
			int active = mask.active;
			bool flag = active > 2;
			Vector3 result;
			if (flag)
			{
				result = mask;
			}
			else
			{
				Vector3 vector = rotation * mask;
				vector = new Vector3(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
				bool flag2 = active > 1;
				if (flag2)
				{
					result = new Vector3((float)((vector.x > vector.y || vector.x > vector.z) ? 1 : 0), (float)((vector.y > vector.x || vector.y > vector.z) ? 1 : 0), (float)((vector.z > vector.x || vector.z > vector.y) ? 1 : 0));
				}
				else
				{
					result = new Vector3((float)((vector.x > vector.y && vector.x > vector.z) ? 1 : 0), (float)((vector.y > vector.z && vector.y > vector.x) ? 1 : 0), (float)((vector.z > vector.x && vector.z > vector.y) ? 1 : 0));
				}
			}
			return result;
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00027FC0 File Offset: 0x000261C0
		public static bool operator ==(SnapAxisFilter left, SnapAxisFilter right)
		{
			return left.m_Mask == right.m_Mask;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00027FE0 File Offset: 0x000261E0
		public static bool operator !=(SnapAxisFilter left, SnapAxisFilter right)
		{
			return !(left == right);
		}

		// Token: 0x170004A4 RID: 1188
		public float this[int i]
		{
			get
			{
				bool flag = i < 0 || i > 2;
				if (flag)
				{
					throw new IndexOutOfRangeException();
				}
				return (float)(SnapAxis.X & this.m_Mask >> (i & 31)) * 1f;
			}
			set
			{
				bool flag = i < 0 || i > 2;
				if (flag)
				{
					throw new IndexOutOfRangeException();
				}
				this.m_Mask &= (SnapAxis)(~(SnapAxis)(1 << i));
				this.m_Mask |= (SnapAxis)(((value > 0f) ? 1 : 0) << (i & 31));
			}
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00028090 File Offset: 0x00026290
		public bool Equals(SnapAxisFilter other)
		{
			return this.m_Mask == other.m_Mask;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x000280B0 File Offset: 0x000262B0
		public override bool Equals(object obj)
		{
			bool flag = obj == null;
			return !flag && obj is SnapAxisFilter && this.Equals((SnapAxisFilter)obj);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x000280E8 File Offset: 0x000262E8
		public override int GetHashCode()
		{
			return this.m_Mask.GetHashCode();
		}

		// Token: 0x04000849 RID: 2121
		private const SnapAxis X = SnapAxis.X;

		// Token: 0x0400084A RID: 2122
		private const SnapAxis Y = SnapAxis.Y;

		// Token: 0x0400084B RID: 2123
		private const SnapAxis Z = SnapAxis.Z;

		// Token: 0x0400084C RID: 2124
		public static readonly SnapAxisFilter all = new SnapAxisFilter(SnapAxis.All);

		// Token: 0x0400084D RID: 2125
		private SnapAxis m_Mask;
	}
}
