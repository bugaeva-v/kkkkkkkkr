using System;
using System.Globalization;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000117 RID: 279
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/Math/Rect.h")]
	[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
	public struct Rect : IEquatable<Rect>, IFormattable
	{
		// Token: 0x0600070A RID: 1802 RVA: 0x0000A513 File Offset: 0x00008713
		public Rect(float x, float y, float width, float height)
		{
			this.m_XMin = x;
			this.m_YMin = y;
			this.m_Width = width;
			this.m_Height = height;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0000A533 File Offset: 0x00008733
		public Rect(Vector2 position, Vector2 size)
		{
			this.m_XMin = position.x;
			this.m_YMin = position.y;
			this.m_Width = size.x;
			this.m_Height = size.y;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0000A566 File Offset: 0x00008766
		public Rect(Rect source)
		{
			this.m_XMin = source.m_XMin;
			this.m_YMin = source.m_YMin;
			this.m_Width = source.m_Width;
			this.m_Height = source.m_Height;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x0000A599 File Offset: 0x00008799
		public static Rect zero
		{
			get
			{
				return new Rect(0f, 0f, 0f, 0f);
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0000A5B4 File Offset: 0x000087B4
		public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
		{
			return new Rect(xmin, ymin, xmax - xmin, ymax - ymin);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0000A513 File Offset: 0x00008713
		public void Set(float x, float y, float width, float height)
		{
			this.m_XMin = x;
			this.m_YMin = y;
			this.m_Width = width;
			this.m_Height = height;
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0000A5D4 File Offset: 0x000087D4
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x0000A5EC File Offset: 0x000087EC
		public float x
		{
			get
			{
				return this.m_XMin;
			}
			set
			{
				this.m_XMin = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0000A5F8 File Offset: 0x000087F8
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x0000A610 File Offset: 0x00008810
		public float y
		{
			get
			{
				return this.m_YMin;
			}
			set
			{
				this.m_YMin = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0000A61C File Offset: 0x0000881C
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x0000A63F File Offset: 0x0000883F
		public Vector2 position
		{
			get
			{
				return new Vector2(this.m_XMin, this.m_YMin);
			}
			set
			{
				this.m_XMin = value.x;
				this.m_YMin = value.y;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0000A65C File Offset: 0x0000885C
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x0000A699 File Offset: 0x00008899
		public Vector2 center
		{
			get
			{
				return new Vector2(this.x + this.m_Width / 2f, this.y + this.m_Height / 2f);
			}
			set
			{
				this.m_XMin = value.x - this.m_Width / 2f;
				this.m_YMin = value.y - this.m_Height / 2f;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0000A6D0 File Offset: 0x000088D0
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x0000A6F3 File Offset: 0x000088F3
		public Vector2 min
		{
			get
			{
				return new Vector2(this.xMin, this.yMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0000A710 File Offset: 0x00008910
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0000A733 File Offset: 0x00008933
		public Vector2 max
		{
			get
			{
				return new Vector2(this.xMax, this.yMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0000A750 File Offset: 0x00008950
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0000A768 File Offset: 0x00008968
		public float width
		{
			get
			{
				return this.m_Width;
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0000A774 File Offset: 0x00008974
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x0000A78C File Offset: 0x0000898C
		public float height
		{
			get
			{
				return this.m_Height;
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0000A798 File Offset: 0x00008998
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x0000A7BB File Offset: 0x000089BB
		public Vector2 size
		{
			get
			{
				return new Vector2(this.m_Width, this.m_Height);
			}
			set
			{
				this.m_Width = value.x;
				this.m_Height = value.y;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0000A7D8 File Offset: 0x000089D8
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x0000A7F0 File Offset: 0x000089F0
		public float xMin
		{
			get
			{
				return this.m_XMin;
			}
			set
			{
				float xMax = this.xMax;
				this.m_XMin = value;
				this.m_Width = xMax - this.m_XMin;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0000A81C File Offset: 0x00008A1C
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x0000A834 File Offset: 0x00008A34
		public float yMin
		{
			get
			{
				return this.m_YMin;
			}
			set
			{
				float yMax = this.yMax;
				this.m_YMin = value;
				this.m_Height = yMax - this.m_YMin;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x0000A860 File Offset: 0x00008A60
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x0000A87F File Offset: 0x00008A7F
		public float xMax
		{
			get
			{
				return this.m_Width + this.m_XMin;
			}
			set
			{
				this.m_Width = value - this.m_XMin;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0000A890 File Offset: 0x00008A90
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x0000A8AF File Offset: 0x00008AAF
		public float yMax
		{
			get
			{
				return this.m_Height + this.m_YMin;
			}
			set
			{
				this.m_Height = value - this.m_YMin;
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		public bool Contains(Vector2 point)
		{
			return point.x >= this.xMin && point.x < this.xMax && point.y >= this.yMin && point.y < this.yMax;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0000A910 File Offset: 0x00008B10
		public bool Contains(Vector3 point)
		{
			return point.x >= this.xMin && point.x < this.xMax && point.y >= this.yMin && point.y < this.yMax;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0000A960 File Offset: 0x00008B60
		public bool Contains(Vector3 point, bool allowInverse)
		{
			bool flag = !allowInverse;
			bool result;
			if (flag)
			{
				result = this.Contains(point);
			}
			else
			{
				bool flag2 = (this.width < 0f && point.x <= this.xMin && point.x > this.xMax) || (this.width >= 0f && point.x >= this.xMin && point.x < this.xMax);
				bool flag3 = (this.height < 0f && point.y <= this.yMin && point.y > this.yMax) || (this.height >= 0f && point.y >= this.yMin && point.y < this.yMax);
				result = (flag2 && flag3);
			}
			return result;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0000AA40 File Offset: 0x00008C40
		private static Rect OrderMinMax(Rect rect)
		{
			bool flag = rect.xMin > rect.xMax;
			if (flag)
			{
				float xMin = rect.xMin;
				rect.xMin = rect.xMax;
				rect.xMax = xMin;
			}
			bool flag2 = rect.yMin > rect.yMax;
			if (flag2)
			{
				float yMin = rect.yMin;
				rect.yMin = rect.yMax;
				rect.yMax = yMin;
			}
			return rect;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0000AAC4 File Offset: 0x00008CC4
		public bool Overlaps(Rect other)
		{
			return other.xMax > this.xMin && other.xMin < this.xMax && other.yMax > this.yMin && other.yMin < this.yMax;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0000AB18 File Offset: 0x00008D18
		public bool Overlaps(Rect other, bool allowInverse)
		{
			Rect rect = this;
			if (allowInverse)
			{
				rect = Rect.OrderMinMax(rect);
				other = Rect.OrderMinMax(other);
			}
			return rect.Overlaps(other);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0000AB50 File Offset: 0x00008D50
		public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates)
		{
			return new Vector2(Mathf.Lerp(rectangle.x, rectangle.xMax, normalizedRectCoordinates.x), Mathf.Lerp(rectangle.y, rectangle.yMax, normalizedRectCoordinates.y));
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0000AB9C File Offset: 0x00008D9C
		public static Vector2 PointToNormalized(Rect rectangle, Vector2 point)
		{
			return new Vector2(Mathf.InverseLerp(rectangle.x, rectangle.xMax, point.x), Mathf.InverseLerp(rectangle.y, rectangle.yMax, point.y));
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		public static bool operator !=(Rect lhs, Rect rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0000AC04 File Offset: 0x00008E04
		public static bool operator ==(Rect lhs, Rect rhs)
		{
			return lhs.x == rhs.x && lhs.y == rhs.y && lhs.width == rhs.width && lhs.height == rhs.height;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0000AC5C File Offset: 0x00008E5C
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ this.width.GetHashCode() << 2 ^ this.y.GetHashCode() >> 2 ^ this.height.GetHashCode() >> 1;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		public override bool Equals(object other)
		{
			bool flag = !(other is Rect);
			return !flag && this.Equals((Rect)other);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		public bool Equals(Rect other)
		{
			return this.x.Equals(other.x) && this.y.Equals(other.y) && this.width.Equals(other.width) && this.height.Equals(other.height);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0000AD54 File Offset: 0x00008F54
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0000AD70 File Offset: 0x00008F70
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0000AD8C File Offset: 0x00008F8C
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
			return UnityString.Format("(x:{0}, y:{1}, width:{2}, height:{3})", new object[]
			{
				this.x.ToString(format, formatProvider),
				this.y.ToString(format, formatProvider),
				this.width.ToString(format, formatProvider),
				this.height.ToString(format, formatProvider)
			});
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0000AE20 File Offset: 0x00009020
		[Obsolete("use xMin")]
		public float left
		{
			get
			{
				return this.m_XMin;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x0000AE38 File Offset: 0x00009038
		[Obsolete("use xMax")]
		public float right
		{
			get
			{
				return this.m_XMin + this.m_Width;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0000AE58 File Offset: 0x00009058
		[Obsolete("use yMin")]
		public float top
		{
			get
			{
				return this.m_YMin;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x0000AE70 File Offset: 0x00009070
		[Obsolete("use yMax")]
		public float bottom
		{
			get
			{
				return this.m_YMin + this.m_Height;
			}
		}

		// Token: 0x04000396 RID: 918
		[NativeName("x")]
		private float m_XMin;

		// Token: 0x04000397 RID: 919
		[NativeName("y")]
		private float m_YMin;

		// Token: 0x04000398 RID: 920
		[NativeName("width")]
		private float m_Width;

		// Token: 0x04000399 RID: 921
		[NativeName("height")]
		private float m_Height;
	}
}
