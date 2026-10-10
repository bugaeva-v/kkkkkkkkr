using System;
using System.Globalization;

namespace UnityEngine
{
	// Token: 0x02000116 RID: 278
	public struct Ray2D : IFormattable
	{
		// Token: 0x06000701 RID: 1793 RVA: 0x0000A3E3 File Offset: 0x000085E3
		public Ray2D(Vector2 origin, Vector2 direction)
		{
			this.m_Origin = origin;
			this.m_Direction = direction.normalized;
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0000A3FC File Offset: 0x000085FC
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x0000A414 File Offset: 0x00008614
		public Vector2 origin
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

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0000A420 File Offset: 0x00008620
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x0000A438 File Offset: 0x00008638
		public Vector2 direction
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

		// Token: 0x06000706 RID: 1798 RVA: 0x0000A448 File Offset: 0x00008648
		public Vector2 GetPoint(float distance)
		{
			return this.m_Origin + this.m_Direction * distance;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0000A474 File Offset: 0x00008674
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0000A490 File Offset: 0x00008690
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0000A4AC File Offset: 0x000086AC
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

		// Token: 0x04000394 RID: 916
		private Vector2 m_Origin;

		// Token: 0x04000395 RID: 917
		private Vector2 m_Direction;
	}
}
