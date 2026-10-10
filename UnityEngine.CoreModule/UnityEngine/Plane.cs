using System;
using System.Globalization;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000114 RID: 276
	[UsedByNativeCode]
	public struct Plane : IFormattable
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00009F60 File Offset: 0x00008160
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00009F78 File Offset: 0x00008178
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00009F84 File Offset: 0x00008184
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00009F9C File Offset: 0x0000819C
		public float distance
		{
			get
			{
				return this.m_Distance;
			}
			set
			{
				this.m_Distance = value;
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00009FA6 File Offset: 0x000081A6
		public Plane(Vector3 inNormal, Vector3 inPoint)
		{
			this.m_Normal = Vector3.Normalize(inNormal);
			this.m_Distance = -Vector3.Dot(this.m_Normal, inPoint);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00009FC8 File Offset: 0x000081C8
		public Plane(Vector3 inNormal, float d)
		{
			this.m_Normal = Vector3.Normalize(inNormal);
			this.m_Distance = d;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00009FDE File Offset: 0x000081DE
		public Plane(Vector3 a, Vector3 b, Vector3 c)
		{
			this.m_Normal = Vector3.Normalize(Vector3.Cross(b - a, c - a));
			this.m_Distance = -Vector3.Dot(this.m_Normal, a);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0000A012 File Offset: 0x00008212
		public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint)
		{
			this.m_Normal = Vector3.Normalize(inNormal);
			this.m_Distance = -Vector3.Dot(inNormal, inPoint);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00009FDE File Offset: 0x000081DE
		public void Set3Points(Vector3 a, Vector3 b, Vector3 c)
		{
			this.m_Normal = Vector3.Normalize(Vector3.Cross(b - a, c - a));
			this.m_Distance = -Vector3.Dot(this.m_Normal, a);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0000A02F File Offset: 0x0000822F
		public void Flip()
		{
			this.m_Normal = -this.m_Normal;
			this.m_Distance = -this.m_Distance;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x0000A050 File Offset: 0x00008250
		public Plane flipped
		{
			get
			{
				return new Plane(-this.m_Normal, -this.m_Distance);
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0000A079 File Offset: 0x00008279
		public void Translate(Vector3 translation)
		{
			this.m_Distance += Vector3.Dot(this.m_Normal, translation);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0000A098 File Offset: 0x00008298
		public static Plane Translate(Plane plane, Vector3 translation)
		{
			return new Plane(plane.m_Normal, plane.m_Distance += Vector3.Dot(plane.m_Normal, translation));
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0000A0D0 File Offset: 0x000082D0
		public Vector3 ClosestPointOnPlane(Vector3 point)
		{
			float d = Vector3.Dot(this.m_Normal, point) + this.m_Distance;
			return point - this.m_Normal * d;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0000A108 File Offset: 0x00008308
		public float GetDistanceToPoint(Vector3 point)
		{
			return Vector3.Dot(this.m_Normal, point) + this.m_Distance;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0000A130 File Offset: 0x00008330
		public bool GetSide(Vector3 point)
		{
			return Vector3.Dot(this.m_Normal, point) + this.m_Distance > 0f;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0000A15C File Offset: 0x0000835C
		public bool SameSide(Vector3 inPt0, Vector3 inPt1)
		{
			float distanceToPoint = this.GetDistanceToPoint(inPt0);
			float distanceToPoint2 = this.GetDistanceToPoint(inPt1);
			return (distanceToPoint > 0f && distanceToPoint2 > 0f) || (distanceToPoint <= 0f && distanceToPoint2 <= 0f);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0000A1A8 File Offset: 0x000083A8
		public bool Raycast(Ray ray, out float enter)
		{
			float num = Vector3.Dot(ray.direction, this.m_Normal);
			float num2 = -Vector3.Dot(ray.origin, this.m_Normal) - this.m_Distance;
			bool flag = Mathf.Approximately(num, 0f);
			bool result;
			if (flag)
			{
				enter = 0f;
				result = false;
			}
			else
			{
				enter = num2 / num;
				result = (enter > 0f);
			}
			return result;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0000A214 File Offset: 0x00008414
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0000A230 File Offset: 0x00008430
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0000A24C File Offset: 0x0000844C
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
			return UnityString.Format("(normal:{0}, distance:{1})", new object[]
			{
				this.m_Normal.ToString(format, formatProvider),
				this.m_Distance.ToString(format, formatProvider)
			});
		}

		// Token: 0x0400038F RID: 911
		internal const int size = 16;

		// Token: 0x04000390 RID: 912
		private Vector3 m_Normal;

		// Token: 0x04000391 RID: 913
		private float m_Distance;
	}
}
