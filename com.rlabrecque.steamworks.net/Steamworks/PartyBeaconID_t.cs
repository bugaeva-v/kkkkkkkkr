using System;

namespace Steamworks
{
	// Token: 0x020001BF RID: 447
	[Serializable]
	public struct PartyBeaconID_t : IEquatable<PartyBeaconID_t>, IComparable<PartyBeaconID_t>
	{
		// Token: 0x060022F5 RID: 8949 RVA: 0x000177E3 File Offset: 0x000159E3
		public override string ToString()
		{
			return this.m_PartyBeaconID.ToString();
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x000177F0 File Offset: 0x000159F0
		public static ulong PEAFCMBIENC(PartyBeaconID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_PartyBeaconID;
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x000177F8 File Offset: 0x000159F8
		public bool BGCLGOFDJPI(PartyBeaconID_t LNBMEILJKDH)
		{
			return this.m_PartyBeaconID == LNBMEILJKDH.m_PartyBeaconID;
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00017816 File Offset: 0x00015A16
		public int POKMMKCKGPO(PartyBeaconID_t LNBMEILJKDH)
		{
			return this.m_PartyBeaconID.CompareTo(LNBMEILJKDH.m_PartyBeaconID);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x000177F8 File Offset: 0x000159F8
		public bool LBFHFGGCAJP(PartyBeaconID_t LNBMEILJKDH)
		{
			return this.m_PartyBeaconID == LNBMEILJKDH.m_PartyBeaconID;
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00017829 File Offset: 0x00015A29
		public static bool ECLPKLJCBLI(PartyBeaconID_t OBNBCGOIMKE, PartyBeaconID_t DEJFBNMNMOK)
		{
			return PartyBeaconID_t.NFDGMMCNNMN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00017835 File Offset: 0x00015A35
		public static PartyBeaconID_t PJCFLLGPNKB(ulong AJLPALFJHCC)
		{
			return new PartyBeaconID_t(AJLPALFJHCC);
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x0001783D File Offset: 0x00015A3D
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is PartyBeaconID_t && PartyBeaconID_t.MKGNKAMFMPG(this, (PartyBeaconID_t)LNBMEILJKDH);
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x0001785A File Offset: 0x00015A5A
		public override int GetHashCode()
		{
			return this.m_PartyBeaconID.GetHashCode();
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00017816 File Offset: 0x00015A16
		public int CompareTo(PartyBeaconID_t LNBMEILJKDH)
		{
			return this.m_PartyBeaconID.CompareTo(LNBMEILJKDH.m_PartyBeaconID);
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x000177F8 File Offset: 0x000159F8
		public static bool MKGNKAMFMPG(PartyBeaconID_t OBNBCGOIMKE, PartyBeaconID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PartyBeaconID == DEJFBNMNMOK.m_PartyBeaconID;
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x000177F8 File Offset: 0x000159F8
		public bool Equals(PartyBeaconID_t LNBMEILJKDH)
		{
			return this.m_PartyBeaconID == LNBMEILJKDH.m_PartyBeaconID;
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x000177F8 File Offset: 0x000159F8
		public static bool IKBEOPIFAFP(PartyBeaconID_t OBNBCGOIMKE, PartyBeaconID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PartyBeaconID == DEJFBNMNMOK.m_PartyBeaconID;
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x000177F0 File Offset: 0x000159F0
		public static ulong PJLGPAOKAHP(PartyBeaconID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_PartyBeaconID;
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x00017867 File Offset: 0x00015A67
		public static bool NEFGNGBGAJI(PartyBeaconID_t OBNBCGOIMKE, PartyBeaconID_t DEJFBNMNMOK)
		{
			return !PartyBeaconID_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00017873 File Offset: 0x00015A73
		public PartyBeaconID_t(ulong AJLPALFJHCC)
		{
			this.m_PartyBeaconID = AJLPALFJHCC;
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00017835 File Offset: 0x00015A35
		public static PartyBeaconID_t AIGHJLNLCOB(ulong AJLPALFJHCC)
		{
			return new PartyBeaconID_t(AJLPALFJHCC);
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x00017816 File Offset: 0x00015A16
		public int DLCBDAFFEIF(PartyBeaconID_t LNBMEILJKDH)
		{
			return this.m_PartyBeaconID.CompareTo(LNBMEILJKDH.m_PartyBeaconID);
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00017816 File Offset: 0x00015A16
		public int LKMBNGPKKFE(PartyBeaconID_t LNBMEILJKDH)
		{
			return this.m_PartyBeaconID.CompareTo(LNBMEILJKDH.m_PartyBeaconID);
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x000177F8 File Offset: 0x000159F8
		public bool EKEPMIJHKEP(PartyBeaconID_t LNBMEILJKDH)
		{
			return this.m_PartyBeaconID == LNBMEILJKDH.m_PartyBeaconID;
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x00017816 File Offset: 0x00015A16
		public int ABJCOGNCMEJ(PartyBeaconID_t LNBMEILJKDH)
		{
			return this.m_PartyBeaconID.CompareTo(LNBMEILJKDH.m_PartyBeaconID);
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00017816 File Offset: 0x00015A16
		public int CHOKCPIGFEN(PartyBeaconID_t LNBMEILJKDH)
		{
			return this.m_PartyBeaconID.CompareTo(LNBMEILJKDH.m_PartyBeaconID);
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x000177F8 File Offset: 0x000159F8
		public static bool ANMCAPADKNB(PartyBeaconID_t OBNBCGOIMKE, PartyBeaconID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PartyBeaconID == DEJFBNMNMOK.m_PartyBeaconID;
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00017835 File Offset: 0x00015A35
		public static PartyBeaconID_t PEAFCMBIENC(ulong AJLPALFJHCC)
		{
			return new PartyBeaconID_t(AJLPALFJHCC);
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x000177F8 File Offset: 0x000159F8
		public bool NNNJNIOCEPA(PartyBeaconID_t LNBMEILJKDH)
		{
			return this.m_PartyBeaconID == LNBMEILJKDH.m_PartyBeaconID;
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x000177F8 File Offset: 0x000159F8
		public static bool NFDGMMCNNMN(PartyBeaconID_t OBNBCGOIMKE, PartyBeaconID_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PartyBeaconID == DEJFBNMNMOK.m_PartyBeaconID;
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x000177F0 File Offset: 0x000159F0
		public static ulong CCADGDCAMNN(PartyBeaconID_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_PartyBeaconID;
		}

		// Token: 0x04000A13 RID: 2579
		public static readonly PartyBeaconID_t Invalid = new PartyBeaconID_t(0UL);

		// Token: 0x04000A14 RID: 2580
		public ulong m_PartyBeaconID;
	}
}
