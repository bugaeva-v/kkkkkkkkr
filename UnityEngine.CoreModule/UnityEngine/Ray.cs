using System;
using System.Globalization;

namespace UnityEngine
{
	// Token: 0x02000115 RID: 277
	public struct Ray : IFormattable
	{
		// Token: 0x060006F8 RID: 1784 RVA: 0x0000A2B3 File Offset: 0x000084B3
		public Ray(Vector3 origin, Vector3 direction)
		{
			this.m_Origin = origin;
			this.m_Direction = direction.normalized;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0000A2CC File Offset: 0x000084CC
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x0000A2E4 File Offset: 0x000084E4
		public Vector3 origin
		{
			get
			{
				return this.m_Origin;
			}
			set
			{
				this.m_Origin = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x0000A2F0 File Offset: 0x000084F0
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x0000A308 File Offset: 0x00008508
		public Vector3 direction
		{
			get
			{
				return this.m_Direction;
			}
			set
			{
				this.m_Direction = value.normalized;
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0000A318 File Offset: 0x00008518
		public Vector3 GetPoint(float distance)
		{
			return this.m_Origin + this.m_Direction * distance;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0000A344 File Offset: 0x00008544
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0000A360 File Offset: 0x00008560
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0000A37C File Offset: 0x0000857C
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
			return UnityString.Format("Origin: {0}, Dir: {1}", new object[]
			{
				this.m_Origin.ToString(format, formatProvider),
				this.m_Direction.ToString(format, formatProvider)
			});
		}

		// Token: 0x04000392 RID: 914
		private Vector3 m_Origin;

		// Token: 0x04000393 RID: 915
		private Vector3 m_Direction;
	}
}
