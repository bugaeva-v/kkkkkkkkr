using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000118 RID: 280
	[UsedByNativeCode]
	public struct RectInt : IEquatable<RectInt>, IFormattable
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0000AE90 File Offset: 0x00009090
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x0000AEA8 File Offset: 0x000090A8
		public int x
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

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0000AEB4 File Offset: 0x000090B4
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0000AECC File Offset: 0x000090CC
		public int y
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

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0000AED8 File Offset: 0x000090D8
		public Vector2 center
		{
			get
			{
				return new Vector2((float)this.x + (float)this.m_Width / 2f, (float)this.y + (float)this.m_Height / 2f);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x0000AF1C File Offset: 0x0000911C
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x0000AF3F File Offset: 0x0000913F
		public Vector2Int min
		{
			get
			{
				return new Vector2Int(this.xMin, this.yMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x0000AF60 File Offset: 0x00009160
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x0000AF83 File Offset: 0x00009183
		public Vector2Int max
		{
			get
			{
				return new Vector2Int(this.xMax, this.yMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x0000AFA4 File Offset: 0x000091A4
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x0000AFBC File Offset: 0x000091BC
		public int width
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

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0000AFC8 File Offset: 0x000091C8
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x0000AFE0 File Offset: 0x000091E0
		public int height
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

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x0000AFEC File Offset: 0x000091EC
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x0000B018 File Offset: 0x00009218
		public int xMin
		{
			get
			{
				return Math.Min(this.m_XMin, this.m_XMin + this.m_Width);
			}
			set
			{
				int xMax = this.xMax;
				this.m_XMin = value;
				this.m_Width = xMax - this.m_XMin;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x0000B044 File Offset: 0x00009244
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x0000B070 File Offset: 0x00009270
		public int yMin
		{
			get
			{
				return Math.Min(this.m_YMin, this.m_YMin + this.m_Height);
			}
			set
			{
				int yMax = this.yMax;
				this.m_YMin = value;
				this.m_Height = yMax - this.m_YMin;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x0000B09C File Offset: 0x0000929C
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x0000B0C6 File Offset: 0x000092C6
		public int xMax
		{
			get
			{
				return Math.Max(this.m_XMin, this.m_XMin + this.m_Width);
			}
			set
			{
				this.m_Width = value - this.m_XMin;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x0000B0D8 File Offset: 0x000092D8
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x0000B102 File Offset: 0x00009302
		public int yMax
		{
			get
			{
				return Math.Max(this.m_YMin, this.m_YMin + this.m_Height);
			}
			set
			{
				this.m_Height = value - this.m_YMin;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0000B114 File Offset: 0x00009314
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x0000B137 File Offset: 0x00009337
		public Vector2Int position
		{
			get
			{
				return new Vector2Int(this.m_XMin, this.m_YMin);
			}
			set
			{
				this.m_XMin = value.x;
				this.m_YMin = value.y;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x0000B154 File Offset: 0x00009354
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x0000B177 File Offset: 0x00009377
		public Vector2Int size
		{
			get
			{
				return new Vector2Int(this.m_Width, this.m_Height);
			}
			set
			{
				this.m_Width = value.x;
				this.m_Height = value.y;
			}
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0000B194 File Offset: 0x00009394
		public void SetMinMax(Vector2Int minPosition, Vector2Int maxPosition)
		{
			this.min = minPosition;
			this.max = maxPosition;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0000B1A7 File Offset: 0x000093A7
		public RectInt(int xMin, int yMin, int width, int height)
		{
			this.m_XMin = xMin;
			this.m_YMin = yMin;
			this.m_Width = width;
			this.m_Height = height;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0000B1C7 File Offset: 0x000093C7
		public RectInt(Vector2Int position, Vector2Int size)
		{
			this.m_XMin = position.x;
			this.m_YMin = position.y;
			this.m_Width = size.x;
			this.m_Height = size.y;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0000B200 File Offset: 0x00009400
		public void ClampToBounds(RectInt bounds)
		{
			this.position = new Vector2Int(Math.Max(Math.Min(bounds.xMax, this.position.x), bounds.xMin), Math.Max(Math.Min(bounds.yMax, this.position.y), bounds.yMin));
			this.size = new Vector2Int(Math.Min(bounds.xMax - this.position.x, this.size.x), Math.Min(bounds.yMax - this.position.y, this.size.y));
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0000B2C4 File Offset: 0x000094C4
		public bool Contains(Vector2Int position)
		{
			return position.x >= this.xMin && position.y >= this.yMin && position.x < this.xMax && position.y < this.yMax;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0000B318 File Offset: 0x00009518
		public bool Overlaps(RectInt other)
		{
			return other.xMin < this.xMax && other.xMax > this.xMin && other.yMin < this.yMax && other.yMax > this.yMin;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0000B36C File Offset: 0x0000956C
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0000B388 File Offset: 0x00009588
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0000B3A4 File Offset: 0x000095A4
		public string ToString(string format, IFormatProvider formatProvider)
		{
			bool flag = formatProvider == null;
			if (flag)
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

		// Token: 0x06000760 RID: 1888 RVA: 0x0000B428 File Offset: 0x00009628
		public bool Equals(RectInt other)
		{
			return this.m_XMin == other.m_XMin && this.m_YMin == other.m_YMin && this.m_Width == other.m_Width && this.m_Height == other.m_Height;
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0000B478 File Offset: 0x00009678
		public RectInt.PositionEnumerator allPositionsWithin
		{
			get
			{
				return new RectInt.PositionEnumerator(this.min, this.max);
			}
		}

		// Token: 0x0400039A RID: 922
		private int m_XMin;

		// Token: 0x0400039B RID: 923
		private int m_YMin;

		// Token: 0x0400039C RID: 924
		private int m_Width;

		// Token: 0x0400039D RID: 925
		private int m_Height;

		// Token: 0x02000119 RID: 281
		public struct PositionEnumerator : IEnumerator<Vector2Int>, IEnumerator, IDisposable
		{
			// Token: 0x06000762 RID: 1890 RVA: 0x0000B49C File Offset: 0x0000969C
			public PositionEnumerator(Vector2Int min, Vector2Int max)
			{
				this._current = min;
				this._min = min;
				this._max = max;
				this.Reset();
			}

			// Token: 0x06000763 RID: 1891 RVA: 0x0000B4C8 File Offset: 0x000096C8
			public RectInt.PositionEnumerator GetEnumerator()
			{
				return this;
			}

			// Token: 0x06000764 RID: 1892 RVA: 0x0000B4E0 File Offset: 0x000096E0
			public bool MoveNext()
			{
				bool flag = this._current.y >= this._max.y;
				bool result;
				if (flag)
				{
					result = false;
				}
				else
				{
					int num = this._current.x;
					this._current.x = num + 1;
					bool flag2 = this._current.x >= this._max.x;
					if (flag2)
					{
						this._current.x = this._min.x;
						bool flag3 = this._current.x >= this._max.x;
						if (flag3)
						{
							return false;
						}
						num = this._current.y;
						this._current.y = num + 1;
						bool flag4 = this._current.y >= this._max.y;
						if (flag4)
						{
							return false;
						}
					}
					result = true;
				}
				return result;
			}

			// Token: 0x06000765 RID: 1893 RVA: 0x0000B5DC File Offset: 0x000097DC
			public void Reset()
			{
				this._current = this._min;
				int x = this._current.x;
				this._current.x = x - 1;
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x06000766 RID: 1894 RVA: 0x0000B60C File Offset: 0x0000980C
			public Vector2Int Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x06000767 RID: 1895 RVA: 0x0000B624 File Offset: 0x00009824
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06000768 RID: 1896 RVA: 0x00004563 File Offset: 0x00002763
			void IDisposable.Dispose()
			{
			}

			// Token: 0x0400039E RID: 926
			private readonly Vector2Int _min;

			// Token: 0x0400039F RID: 927
			private readonly Vector2Int _max;

			// Token: 0x040003A0 RID: 928
			private Vector2Int _current;
		}
	}
}
