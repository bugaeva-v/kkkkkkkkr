using System;

namespace Steamworks
{
	// Token: 0x020000DD RID: 221
	[Serializable]
	public struct HServerListRequest : IEquatable<HServerListRequest>
	{
		// Token: 0x060011FD RID: 4605 RVA: 0x0000D79C File Offset: 0x0000B99C
		public bool JDDFHOOKAJM(HServerListRequest LNBMEILJKDH)
		{
			return this.m_HServerListRequest == LNBMEILJKDH.m_HServerListRequest;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0000D7C0 File Offset: 0x0000B9C0
		public override int GetHashCode()
		{
			return this.m_HServerListRequest.GetHashCode();
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0000D7CD File Offset: 0x0000B9CD
		public static HServerListRequest AMAFMNJBNKC(IntPtr AJLPALFJHCC)
		{
			return new HServerListRequest(AJLPALFJHCC);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0000D7D5 File Offset: 0x0000B9D5
		public HServerListRequest(IntPtr AJLPALFJHCC)
		{
			this.m_HServerListRequest = AJLPALFJHCC;
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0000D7DE File Offset: 0x0000B9DE
		public static bool NEFGNGBGAJI(HServerListRequest OBNBCGOIMKE, HServerListRequest DEJFBNMNMOK)
		{
			return !HServerListRequest.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0000D7EA File Offset: 0x0000B9EA
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is HServerListRequest && HServerListRequest.MKGNKAMFMPG(this, (HServerListRequest)LNBMEILJKDH);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0000D79C File Offset: 0x0000B99C
		public bool Equals(HServerListRequest LNBMEILJKDH)
		{
			return this.m_HServerListRequest == LNBMEILJKDH.m_HServerListRequest;
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0000D79C File Offset: 0x0000B99C
		public bool IJMIHAGGAJM(HServerListRequest LNBMEILJKDH)
		{
			return this.m_HServerListRequest == LNBMEILJKDH.m_HServerListRequest;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0000D7CD File Offset: 0x0000B9CD
		public static HServerListRequest CBMHIJAIMFN(IntPtr AJLPALFJHCC)
		{
			return new HServerListRequest(AJLPALFJHCC);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0000D807 File Offset: 0x0000BA07
		public static IntPtr PEAFCMBIENC(HServerListRequest MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HServerListRequest;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0000D7CD File Offset: 0x0000B9CD
		public static HServerListRequest ICIODPKFNBE(IntPtr AJLPALFJHCC)
		{
			return new HServerListRequest(AJLPALFJHCC);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0000D79C File Offset: 0x0000B99C
		public bool ODLINHPHKIK(HServerListRequest LNBMEILJKDH)
		{
			return this.m_HServerListRequest == LNBMEILJKDH.m_HServerListRequest;
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0000D7CD File Offset: 0x0000B9CD
		public static HServerListRequest MFKKKOBBPNG(IntPtr AJLPALFJHCC)
		{
			return new HServerListRequest(AJLPALFJHCC);
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0000D80F File Offset: 0x0000BA0F
		public override string ToString()
		{
			return this.m_HServerListRequest.ToString();
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0000D79C File Offset: 0x0000B99C
		public bool OADDCIOCGKD(HServerListRequest LNBMEILJKDH)
		{
			return this.m_HServerListRequest == LNBMEILJKDH.m_HServerListRequest;
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0000D7CD File Offset: 0x0000B9CD
		public static HServerListRequest PEAFCMBIENC(IntPtr AJLPALFJHCC)
		{
			return new HServerListRequest(AJLPALFJHCC);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0000D81C File Offset: 0x0000BA1C
		public static bool HCDPJCOFKKO(HServerListRequest OBNBCGOIMKE, HServerListRequest DEJFBNMNMOK)
		{
			return HServerListRequest.LJKJMNKEKMF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0000D79C File Offset: 0x0000B99C
		public static bool MKGNKAMFMPG(HServerListRequest OBNBCGOIMKE, HServerListRequest DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HServerListRequest == DEJFBNMNMOK.m_HServerListRequest;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0000D807 File Offset: 0x0000BA07
		public static IntPtr ECPDGDCBJOL(HServerListRequest MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HServerListRequest;
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0000D79C File Offset: 0x0000B99C
		public static bool LJKJMNKEKMF(HServerListRequest OBNBCGOIMKE, HServerListRequest DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HServerListRequest == DEJFBNMNMOK.m_HServerListRequest;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0000D807 File Offset: 0x0000BA07
		public static IntPtr GDMEOLEOLGI(HServerListRequest MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HServerListRequest;
		}

		// Token: 0x0400065E RID: 1630
		public static readonly HServerListRequest Invalid = new HServerListRequest(IntPtr.Zero);

		// Token: 0x0400065F RID: 1631
		public IntPtr m_HServerListRequest;
	}
}
