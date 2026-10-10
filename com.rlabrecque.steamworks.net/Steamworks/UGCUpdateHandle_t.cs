using System;

namespace Steamworks
{
	// Token: 0x020000D8 RID: 216
	[Serializable]
	public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x0000D39A File Offset: 0x0000B59A
		public static bool MKGNKAMFMPG(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCUpdateHandle == DEJFBNMNMOK.m_UGCUpdateHandle;
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0000D3AA File Offset: 0x0000B5AA
		public static UGCUpdateHandle_t JHGEMFPADIC(ulong AJLPALFJHCC)
		{
			return new UGCUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0000D3B2 File Offset: 0x0000B5B2
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is UGCUpdateHandle_t && UGCUpdateHandle_t.MKGNKAMFMPG(this, (UGCUpdateHandle_t)LNBMEILJKDH);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0000D3CF File Offset: 0x0000B5CF
		public int LGDFGIAHHME(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle.CompareTo(LNBMEILJKDH.m_UGCUpdateHandle);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0000D3AA File Offset: 0x0000B5AA
		public static UGCUpdateHandle_t GDMEOLEOLGI(ulong AJLPALFJHCC)
		{
			return new UGCUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public static ulong MDHKPHFGMDC(UGCUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCUpdateHandle;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0000D39A File Offset: 0x0000B59A
		public bool IELBGOMFEBJ(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle == LNBMEILJKDH.m_UGCUpdateHandle;
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0000D3EA File Offset: 0x0000B5EA
		public override string ToString()
		{
			return this.m_UGCUpdateHandle.ToString();
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public static ulong PJLGPAOKAHP(UGCUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCUpdateHandle;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0000D3AA File Offset: 0x0000B5AA
		public static UGCUpdateHandle_t PEAFCMBIENC(ulong AJLPALFJHCC)
		{
			return new UGCUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0000D3CF File Offset: 0x0000B5CF
		public int CompareTo(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle.CompareTo(LNBMEILJKDH.m_UGCUpdateHandle);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0000D3CF File Offset: 0x0000B5CF
		public int NOEOIFCMOJA(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle.CompareTo(LNBMEILJKDH.m_UGCUpdateHandle);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0000D39A File Offset: 0x0000B59A
		public bool MFHMLODHJGH(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle == LNBMEILJKDH.m_UGCUpdateHandle;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public static ulong AMAFMNJBNKC(UGCUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCUpdateHandle;
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0000D3CF File Offset: 0x0000B5CF
		public int FPLPEMNKGOK(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle.CompareTo(LNBMEILJKDH.m_UGCUpdateHandle);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0000D39A File Offset: 0x0000B59A
		public bool AGOMFHFJLCM(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle == LNBMEILJKDH.m_UGCUpdateHandle;
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0000D39A File Offset: 0x0000B59A
		public bool EPBJEKJAJAM(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle == LNBMEILJKDH.m_UGCUpdateHandle;
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0000D3CF File Offset: 0x0000B5CF
		public int BOKJBEEFMDM(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle.CompareTo(LNBMEILJKDH.m_UGCUpdateHandle);
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0000D39A File Offset: 0x0000B59A
		public static bool HELPLOFAEII(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCUpdateHandle == DEJFBNMNMOK.m_UGCUpdateHandle;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public static ulong EFIDMFLMNJM(UGCUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCUpdateHandle;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0000D39A File Offset: 0x0000B59A
		public static bool LJKJMNKEKMF(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCUpdateHandle == DEJFBNMNMOK.m_UGCUpdateHandle;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0000D3AA File Offset: 0x0000B5AA
		public static UGCUpdateHandle_t DCPDCODLHJN(ulong AJLPALFJHCC)
		{
			return new UGCUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public static ulong PEAFCMBIENC(UGCUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCUpdateHandle;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0000D39A File Offset: 0x0000B59A
		public bool IDPPEPEAHIC(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle == LNBMEILJKDH.m_UGCUpdateHandle;
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0000D3F7 File Offset: 0x0000B5F7
		public static bool LOKGEPBONJG(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return UGCUpdateHandle_t.PEGNGOCNKEH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0000D3F7 File Offset: 0x0000B5F7
		public static bool IOAHIBPNMPP(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return UGCUpdateHandle_t.PEGNGOCNKEH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public static ulong EOPHKNPBLNC(UGCUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCUpdateHandle;
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0000D39A File Offset: 0x0000B59A
		public static bool ANMCAPADKNB(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCUpdateHandle == DEJFBNMNMOK.m_UGCUpdateHandle;
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public static ulong LFPIOHLDKCO(UGCUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCUpdateHandle;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public static ulong CBMHIJAIMFN(UGCUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCUpdateHandle;
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0000D3AA File Offset: 0x0000B5AA
		public static UGCUpdateHandle_t JHKPJDENLLN(ulong AJLPALFJHCC)
		{
			return new UGCUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public static ulong LOEIJPMCCPF(UGCUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCUpdateHandle;
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0000D403 File Offset: 0x0000B603
		public UGCUpdateHandle_t(ulong AJLPALFJHCC)
		{
			this.m_UGCUpdateHandle = AJLPALFJHCC;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0000D3AA File Offset: 0x0000B5AA
		public static UGCUpdateHandle_t BFKCGOCPDHP(ulong AJLPALFJHCC)
		{
			return new UGCUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0000D3AA File Offset: 0x0000B5AA
		public static UGCUpdateHandle_t DLCBJEFIHLI(ulong AJLPALFJHCC)
		{
			return new UGCUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public static ulong ECBJFILBKEG(UGCUpdateHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_UGCUpdateHandle;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0000D40C File Offset: 0x0000B60C
		public static bool FIKFEJGKJDK(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return !UGCUpdateHandle_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0000D39A File Offset: 0x0000B59A
		public bool IIMFAIFNACE(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle == LNBMEILJKDH.m_UGCUpdateHandle;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0000D40C File Offset: 0x0000B60C
		public static bool NEFGNGBGAJI(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return !UGCUpdateHandle_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0000D3AA File Offset: 0x0000B5AA
		public static UGCUpdateHandle_t ICIODPKFNBE(ulong AJLPALFJHCC)
		{
			return new UGCUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0000D3F7 File Offset: 0x0000B5F7
		public static bool IDHFJKJMFNO(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return UGCUpdateHandle_t.PEGNGOCNKEH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0000D426 File Offset: 0x0000B626
		public static bool LJBNKEBHLGE(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return !UGCUpdateHandle_t.PEGNGOCNKEH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0000D3AA File Offset: 0x0000B5AA
		public static UGCUpdateHandle_t BDDFEOKMDML(ulong AJLPALFJHCC)
		{
			return new UGCUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0000D432 File Offset: 0x0000B632
		public static bool KFCFNBMJNEF(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return UGCUpdateHandle_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0000D39A File Offset: 0x0000B59A
		public static bool OKNIKGHCLJK(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCUpdateHandle == DEJFBNMNMOK.m_UGCUpdateHandle;
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0000D39A File Offset: 0x0000B59A
		public bool CCLPOCKCEFC(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle == LNBMEILJKDH.m_UGCUpdateHandle;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0000D3AA File Offset: 0x0000B5AA
		public static UGCUpdateHandle_t ECPDGDCBJOL(ulong AJLPALFJHCC)
		{
			return new UGCUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0000D39A File Offset: 0x0000B59A
		public static bool PEGNGOCNKEH(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_UGCUpdateHandle == DEJFBNMNMOK.m_UGCUpdateHandle;
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0000D3CF File Offset: 0x0000B5CF
		public int HFEKCDNFIEB(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle.CompareTo(LNBMEILJKDH.m_UGCUpdateHandle);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0000D43E File Offset: 0x0000B63E
		public static bool PNPPOPMEIGG(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return UGCUpdateHandle_t.OKNIKGHCLJK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0000D3F7 File Offset: 0x0000B5F7
		public static bool GEDIHMHFNMI(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return UGCUpdateHandle_t.PEGNGOCNKEH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0000D39A File Offset: 0x0000B59A
		public bool Equals(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle == LNBMEILJKDH.m_UGCUpdateHandle;
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0000D39A File Offset: 0x0000B59A
		public bool DDKIFFMKCOK(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle == LNBMEILJKDH.m_UGCUpdateHandle;
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0000D44A File Offset: 0x0000B64A
		public override int GetHashCode()
		{
			return this.m_UGCUpdateHandle.GetHashCode();
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0000D3CF File Offset: 0x0000B5CF
		public int COBNKIJOMII(UGCUpdateHandle_t LNBMEILJKDH)
		{
			return this.m_UGCUpdateHandle.CompareTo(LNBMEILJKDH.m_UGCUpdateHandle);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0000D457 File Offset: 0x0000B657
		public static bool HCCJEBOKDIH(UGCUpdateHandle_t OBNBCGOIMKE, UGCUpdateHandle_t DEJFBNMNMOK)
		{
			return !UGCUpdateHandle_t.ANMCAPADKNB(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0000D3AA File Offset: 0x0000B5AA
		public static UGCUpdateHandle_t MPOEPCABICJ(ulong AJLPALFJHCC)
		{
			return new UGCUpdateHandle_t(AJLPALFJHCC);
		}

		// Token: 0x04000650 RID: 1616
		public static readonly UGCUpdateHandle_t Invalid = new UGCUpdateHandle_t(ulong.MaxValue);

		// Token: 0x04000651 RID: 1617
		public ulong m_UGCUpdateHandle;
	}
}
