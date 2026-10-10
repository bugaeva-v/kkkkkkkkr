using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000111 RID: 273
	[UsedByNativeCode]
	public struct BoundsInt : IEquatable<BoundsInt>, IFormattable
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00009280 File Offset: 0x00007480
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x0000929D File Offset: 0x0000749D
		public int x
		{
			get
			{
				return this.m_Position.x;
			}
			set
			{
				this.m_Position.x = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x000092B0 File Offset: 0x000074B0
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x000092CD File Offset: 0x000074CD
		public int y
		{
			get
			{
				return this.m_Position.y;
			}
			set
			{
				this.m_Position.y = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x000092E0 File Offset: 0x000074E0
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x000092FD File Offset: 0x000074FD
		public int z
		{
			get
			{
				return this.m_Position.z;
			}
			set
			{
				this.m_Position.z = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00009310 File Offset: 0x00007510
		public Vector3 center
		{
			get
			{
				return new Vector3((float)this.x + (float)this.m_Size.x / 2f, (float)this.y + (float)this.m_Size.y / 2f, (float)this.z + (float)this.m_Size.z / 2f);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00009378 File Offset: 0x00007578
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x000093A1 File Offset: 0x000075A1
		public Vector3Int min
		{
			get
			{
				return new Vector3Int(this.xMin, this.yMin, this.zMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
				this.zMin = value.z;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x000093D0 File Offset: 0x000075D0
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x000093F9 File Offset: 0x000075F9
		public Vector3Int max
		{
			get
			{
				return new Vector3Int(this.xMax, this.yMax, this.zMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
				this.zMax = value.z;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00009428 File Offset: 0x00007628
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00009464 File Offset: 0x00007664
		public int xMin
		{
			get
			{
				return Math.Min(this.m_Position.x, this.m_Position.x + this.m_Size.x);
			}
			set
			{
				int xMax = this.xMax;
				this.m_Position.x = value;
				this.m_Size.x = xMax - this.m_Position.x;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x000094A0 File Offset: 0x000076A0
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x000094DC File Offset: 0x000076DC
		public int yMin
		{
			get
			{
				return Math.Min(this.m_Position.y, this.m_Position.y + this.m_Size.y);
			}
			set
			{
				int yMax = this.yMax;
				this.m_Position.y = value;
				this.m_Size.y = yMax - this.m_Position.y;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00009518 File Offset: 0x00007718
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00009554 File Offset: 0x00007754
		public int zMin
		{
			get
			{
				return Math.Min(this.m_Position.z, this.m_Position.z + this.m_Size.z);
			}
			set
			{
				int zMax = this.zMax;
				this.m_Position.z = value;
				this.m_Size.z = zMax - this.m_Position.z;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00009590 File Offset: 0x00007790
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x000095C9 File Offset: 0x000077C9
		public int xMax
		{
			get
			{
				return Math.Max(this.m_Position.x, this.m_Position.x + this.m_Size.x);
			}
			set
			{
				this.m_Size.x = value - this.m_Position.x;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x000095E8 File Offset: 0x000077E8
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00009621 File Offset: 0x00007821
		public int yMax
		{
			get
			{
				return Math.Max(this.m_Position.y, this.m_Position.y + this.m_Size.y);
			}
			set
			{
				this.m_Size.y = value - this.m_Position.y;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00009640 File Offset: 0x00007840
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00009679 File Offset: 0x00007879
		public int zMax
		{
			get
			{
				return Math.Max(this.m_Position.z, this.m_Position.z + this.m_Size.z);
			}
			set
			{
				this.m_Size.z = value - this.m_Position.z;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00009698 File Offset: 0x00007898
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x000096B0 File Offset: 0x000078B0
		public Vector3Int position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x000096BC File Offset: 0x000078BC
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x000096D4 File Offset: 0x000078D4
		public Vector3Int size
		{
			get
			{
				return this.m_Size;
			}
			set
			{
				this.m_Size = value;
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000096DE File Offset: 0x000078DE
		public BoundsInt(int xMin, int yMin, int zMin, int sizeX, int sizeY, int sizeZ)
		{
			this.m_Position = new Vector3Int(xMin, yMin, zMin);
			this.m_Size = new Vector3Int(sizeX, sizeY, sizeZ);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00009700 File Offset: 0x00007900
		public BoundsInt(Vector3Int position, Vector3Int size)
		{
			this.m_Position = position;
			this.m_Size = size;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00009711 File Offset: 0x00007911
		public void SetMinMax(Vector3Int minPosition, Vector3Int maxPosition)
		{
			this.min = minPosition;
			this.max = maxPosition;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00009724 File Offset: 0x00007924
		public void ClampToBounds(BoundsInt bounds)
		{
			this.position = new Vector3Int(Math.Max(Math.Min(bounds.xMax, this.position.x), bounds.xMin), Math.Max(Math.Min(bounds.yMax, this.position.y), bounds.yMin), Math.Max(Math.Min(bounds.zMax, this.position.z), bounds.zMin));
			this.size = new Vector3Int(Math.Min(bounds.xMax - this.position.x, this.size.x), Math.Min(bounds.yMax - this.position.y, this.size.y), Math.Min(bounds.zMax - this.position.z, this.size.z));
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00009838 File Offset: 0x00007A38
		public bool Contains(Vector3Int position)
		{
			return position.x >= this.xMin && position.y >= this.yMin && position.z >= this.zMin && position.x < this.xMax && position.y < this.yMax && position.z < this.zMax;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000098A8 File Offset: 0x00007AA8
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000098C4 File Offset: 0x00007AC4
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000098E0 File Offset: 0x00007AE0
		public string ToString(string format, IFormatProvider formatProvider)
		{
			bool flag = formatProvider == null;
			if (flag)
			{
				formatProvider = CultureInfo.InvariantCulture.NumberFormat;
			}
			return UnityString.Format("Position: {0}, Size: {1}", new object[]
			{
				this.m_Position.ToString(format, formatProvider),
				this.m_Size.ToString(format, formatProvider)
			});
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00009938 File Offset: 0x00007B38
		public static bool operator ==(BoundsInt lhs, BoundsInt rhs)
		{
			return lhs.m_Position == rhs.m_Position && lhs.m_Size == rhs.m_Size;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00009974 File Offset: 0x00007B74
		public static bool operator !=(BoundsInt lhs, BoundsInt rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00009990 File Offset: 0x00007B90
		public override bool Equals(object other)
		{
			bool flag = !(other is BoundsInt);
			return !flag && this.Equals((BoundsInt)other);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x000099C4 File Offset: 0x00007BC4
		public bool Equals(BoundsInt other)
		{
			return this.m_Position.Equals(other.m_Position) && this.m_Size.Equals(other.m_Size);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00009A00 File Offset: 0x00007C00
		public override int GetHashCode()
		{
			return this.m_Position.GetHashCode() ^ this.m_Size.GetHashCode() << 2;
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00009A38 File Offset: 0x00007C38
		public BoundsInt.PositionEnumerator allPositionsWithin
		{
			get
			{
				return new BoundsInt.PositionEnumerator(this.min, this.max);
			}
		}

		// Token: 0x0400038A RID: 906
		private Vector3Int m_Position;

		// Token: 0x0400038B RID: 907
		private Vector3Int m_Size;

		// Token: 0x02000112 RID: 274
		public struct PositionEnumerator : IEnumerator<Vector3Int>, IEnumerator, IDisposable
		{
			// Token: 0x060006CF RID: 1743 RVA: 0x00009A5C File Offset: 0x00007C5C
			public PositionEnumerator(Vector3Int min, Vector3Int max)
			{
				this._current = min;
				this._min = min;
				this._max = max;
				this.Reset();
			}

			// Token: 0x060006D0 RID: 1744 RVA: 0x00009A88 File Offset: 0x00007C88
			public BoundsInt.PositionEnumerator GetEnumerator()
			{
				return this;
			}

			// Token: 0x060006D1 RID: 1745 RVA: 0x00009AA0 File Offset: 0x00007CA0
			public bool MoveNext()
			{
				bool flag = this._current.z >= this._max.z || this._current.y >= this._max.y;
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
							this._current.y = this._min.y;
							num = this._current.z;
							this._current.z = num + 1;
							bool flag5 = this._current.z >= this._max.z;
							if (flag5)
							{
								return false;
							}
						}
					}
					result = true;
				}
				return result;
			}

			// Token: 0x060006D2 RID: 1746 RVA: 0x00009C14 File Offset: 0x00007E14
			public void Reset()
			{
				this._current = this._min;
				int x = this._current.x;
				this._current.x = x - 1;
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00009C44 File Offset: 0x00007E44
			public Vector3Int Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00009C5C File Offset: 0x00007E5C
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060006D5 RID: 1749 RVA: 0x00004563 File Offset: 0x00002763
			void IDisposable.Dispose()
			{
			}

			// Token: 0x0400038C RID: 908
			private readonly Vector3Int _min;

			// Token: 0x0400038D RID: 909
			private readonly Vector3Int _max;

			// Token: 0x0400038E RID: 910
			private Vector3Int _current;
		}
	}
}
