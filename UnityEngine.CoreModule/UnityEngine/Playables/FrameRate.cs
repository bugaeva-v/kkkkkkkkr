using System;
using System.Globalization;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000434 RID: 1076
	[NativeHeader("Runtime/Director/Core/FrameRate.h")]
	[UsedByNativeCode("FrameRate")]
	internal struct FrameRate : IEquatable<FrameRate>
	{
		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x0003F3FF File Offset: 0x0003D5FF
		public bool dropFrame
		{
			get
			{
				return this.m_Rate < 0;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x0003F40A File Offset: 0x0003D60A
		public double rate
		{
			get
			{
				return this.dropFrame ? ((double)(-(double)this.m_Rate) * 0.999000999000999) : ((double)this.m_Rate);
			}
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x0003F42F File Offset: 0x0003D62F
		public FrameRate(uint frameRate = 0U, bool drop = false)
		{
			this.m_Rate = (int)((drop ? uint.MaxValue : 1U) * frameRate);
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x0003F444 File Offset: 0x0003D644
		public bool IsValid()
		{
			return this.m_Rate != 0;
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x0003F460 File Offset: 0x0003D660
		public bool Equals(FrameRate other)
		{
			return this.m_Rate == other.m_Rate;
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x0003F480 File Offset: 0x0003D680
		public override bool Equals(object obj)
		{
			return obj is FrameRate && this.Equals((FrameRate)obj);
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x0003F4A9 File Offset: 0x0003D6A9
		public static bool operator ==(FrameRate a, FrameRate b)
		{
			return a.Equals(b);
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x0003F4B3 File Offset: 0x0003D6B3
		public static bool operator !=(FrameRate a, FrameRate b)
		{
			return !a.Equals(b);
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x0003F4C0 File Offset: 0x0003D6C0
		public static bool operator <(FrameRate a, FrameRate b)
		{
			return a.rate < b.rate;
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x0003F4D2 File Offset: 0x0003D6D2
		public static bool operator <=(FrameRate a, FrameRate b)
		{
			return a.rate <= b.rate;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x0003F4E7 File Offset: 0x0003D6E7
		public static bool operator >(FrameRate a, FrameRate b)
		{
			return a.rate > b.rate;
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x0003F4D2 File Offset: 0x0003D6D2
		public static bool operator >=(FrameRate a, FrameRate b)
		{
			return a.rate <= b.rate;
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x0003F4FC File Offset: 0x0003D6FC
		public override int GetHashCode()
		{
			return this.m_Rate;
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x0003F514 File Offset: 0x0003D714
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x0003F530 File Offset: 0x0003D730
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x0003F54C File Offset: 0x0003D74C
		public string ToString(string format, IFormatProvider formatProvider)
		{
			bool flag = string.IsNullOrEmpty(format);
			if (flag)
			{
				format = (this.dropFrame ? "F2" : "F0");
			}
			bool flag2 = formatProvider == null;
			if (flag2)
			{
				formatProvider = CultureInfo.InvariantCulture.NumberFormat;
			}
			return UnityString.Format("{0} Fps", new object[]
			{
				this.rate.ToString(format, formatProvider)
			});
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x0003F5B8 File Offset: 0x0003D7B8
		internal static int FrameRateToInt(FrameRate framerate)
		{
			return framerate.m_Rate;
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x0003F5D0 File Offset: 0x0003D7D0
		internal static FrameRate DoubleToFrameRate(double framerate)
		{
			uint num = (uint)Math.Ceiling(framerate);
			bool flag = num <= 0U;
			FrameRate result;
			if (flag)
			{
				result = new FrameRate(1U, false);
			}
			else
			{
				FrameRate frameRate = new FrameRate(num, true);
				bool flag2 = Math.Abs(framerate - frameRate.rate) < Math.Abs(framerate - num);
				if (flag2)
				{
					result = frameRate;
				}
				else
				{
					result = new FrameRate(num, false);
				}
			}
			return result;
		}

		// Token: 0x04000E03 RID: 3587
		[Ignore]
		public static readonly FrameRate k_24Fps = new FrameRate(24U, false);

		// Token: 0x04000E04 RID: 3588
		[Ignore]
		public static readonly FrameRate k_23_976Fps = new FrameRate(24U, true);

		// Token: 0x04000E05 RID: 3589
		[Ignore]
		public static readonly FrameRate k_25Fps = new FrameRate(25U, false);

		// Token: 0x04000E06 RID: 3590
		[Ignore]
		public static readonly FrameRate k_30Fps = new FrameRate(30U, false);

		// Token: 0x04000E07 RID: 3591
		[Ignore]
		public static readonly FrameRate k_29_97Fps = new FrameRate(30U, true);

		// Token: 0x04000E08 RID: 3592
		[Ignore]
		public static readonly FrameRate k_50Fps = new FrameRate(50U, false);

		// Token: 0x04000E09 RID: 3593
		[Ignore]
		public static readonly FrameRate k_60Fps = new FrameRate(60U, false);

		// Token: 0x04000E0A RID: 3594
		[Ignore]
		public static readonly FrameRate k_59_94Fps = new FrameRate(60U, true);

		// Token: 0x04000E0B RID: 3595
		[SerializeField]
		private int m_Rate;
	}
}
