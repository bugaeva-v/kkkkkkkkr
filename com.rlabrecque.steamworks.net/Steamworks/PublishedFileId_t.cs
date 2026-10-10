using System;

namespace Steamworks
{
	// Token: 0x02000013 RID: 19
	[Serializable]
	public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
	{
		// Token: 0x0600015D RID: 349 RVA: 0x00003939 File Offset: 0x00001B39
		public int IIGHANNBMEL(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId.CompareTo(LNBMEILJKDH.m_PublishedFileId);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool KMGLKIINEPE(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00003939 File Offset: 0x00001B39
		public int PFDDODLANEL(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId.CompareTo(LNBMEILJKDH.m_PublishedFileId);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000395C File Offset: 0x00001B5C
		public static ulong PEAFCMBIENC(PublishedFileId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_PublishedFileId;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00003964 File Offset: 0x00001B64
		public static PublishedFileId_t PEAFCMBIENC(ulong AJLPALFJHCC)
		{
			return new PublishedFileId_t(AJLPALFJHCC);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000395C File Offset: 0x00001B5C
		public static ulong BPFLDKEBKED(PublishedFileId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_PublishedFileId;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00003964 File Offset: 0x00001B64
		public static PublishedFileId_t IEMDOCBBBOP(ulong AJLPALFJHCC)
		{
			return new PublishedFileId_t(AJLPALFJHCC);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000394C File Offset: 0x00001B4C
		public static bool ICFJLJPOGEE(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PublishedFileId == DEJFBNMNMOK.m_PublishedFileId;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool BADPMBMDPIP(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool BPPMMPGDDEM(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00003939 File Offset: 0x00001B39
		public int GOOANKMJIMN(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId.CompareTo(LNBMEILJKDH.m_PublishedFileId);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00003964 File Offset: 0x00001B64
		public static PublishedFileId_t AIGHJLNLCOB(ulong AJLPALFJHCC)
		{
			return new PublishedFileId_t(AJLPALFJHCC);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000396C File Offset: 0x00001B6C
		public static bool NPEKIIDAPNG(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return !PublishedFileId_t.BGLONEMFOBG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00003964 File Offset: 0x00001B64
		public static PublishedFileId_t HGIOFALCHCO(ulong AJLPALFJHCC)
		{
			return new PublishedFileId_t(AJLPALFJHCC);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000395C File Offset: 0x00001B5C
		public static ulong JAMBFIOAJNM(PublishedFileId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_PublishedFileId;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool LMJGCLHPCOL(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00003978 File Offset: 0x00001B78
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is PublishedFileId_t && PublishedFileId_t.MKGNKAMFMPG(this, (PublishedFileId_t)LNBMEILJKDH);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000394C File Offset: 0x00001B4C
		public static bool MKONPBCDPHI(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PublishedFileId == DEJFBNMNMOK.m_PublishedFileId;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000394C File Offset: 0x00001B4C
		public static bool JHDBIABDGLI(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PublishedFileId == DEJFBNMNMOK.m_PublishedFileId;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00003939 File Offset: 0x00001B39
		public int CompareTo(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId.CompareTo(LNBMEILJKDH.m_PublishedFileId);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00003964 File Offset: 0x00001B64
		public static PublishedFileId_t IFFBKMDGBHG(ulong AJLPALFJHCC)
		{
			return new PublishedFileId_t(AJLPALFJHCC);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00003939 File Offset: 0x00001B39
		public int PCPOOFNGNMC(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId.CompareTo(LNBMEILJKDH.m_PublishedFileId);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00003995 File Offset: 0x00001B95
		public static bool NEFGNGBGAJI(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return !PublishedFileId_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00003939 File Offset: 0x00001B39
		public int MEDIKGILCOA(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId.CompareTo(LNBMEILJKDH.m_PublishedFileId);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000039A1 File Offset: 0x00001BA1
		public static bool AONOBDMGABM(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return PublishedFileId_t.ICFJLJPOGEE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00003964 File Offset: 0x00001B64
		public static PublishedFileId_t KJFNPDCLGPD(ulong AJLPALFJHCC)
		{
			return new PublishedFileId_t(AJLPALFJHCC);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool MBGGHPHHCLB(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00003964 File Offset: 0x00001B64
		public static PublishedFileId_t PKJMBHJMNGD(ulong AJLPALFJHCC)
		{
			return new PublishedFileId_t(AJLPALFJHCC);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool JDJCKJFAPJC(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000039AD File Offset: 0x00001BAD
		public static bool PHAPHNPLBNI(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return !PublishedFileId_t.NMOCADNHGKO(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool DKNOFLLOLFM(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool MMCLBBLECBG(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00003939 File Offset: 0x00001B39
		public int OFGNNJBGBBO(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId.CompareTo(LNBMEILJKDH.m_PublishedFileId);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00003995 File Offset: 0x00001B95
		public static bool DFBOPLBLCLI(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return !PublishedFileId_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool EMNFLNOILHJ(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000394C File Offset: 0x00001B4C
		public static bool KJDLGEAOBCN(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PublishedFileId == DEJFBNMNMOK.m_PublishedFileId;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00003939 File Offset: 0x00001B39
		public int ENGDBAPNJIF(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId.CompareTo(LNBMEILJKDH.m_PublishedFileId);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00003939 File Offset: 0x00001B39
		public int EDIANBCBAPC(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId.CompareTo(LNBMEILJKDH.m_PublishedFileId);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000039B9 File Offset: 0x00001BB9
		public static bool LOKGEPBONJG(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return !PublishedFileId_t.MKONPBCDPHI(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000394C File Offset: 0x00001B4C
		public static bool MKGNKAMFMPG(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PublishedFileId == DEJFBNMNMOK.m_PublishedFileId;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool MKIJFNEMLLO(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000394C File Offset: 0x00001B4C
		public static bool BGLONEMFOBG(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PublishedFileId == DEJFBNMNMOK.m_PublishedFileId;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool EDDLIGFNIJC(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool Equals(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool LOFCAANOECF(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000394C File Offset: 0x00001B4C
		public static bool NMOCADNHGKO(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PublishedFileId == DEJFBNMNMOK.m_PublishedFileId;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00003964 File Offset: 0x00001B64
		public static PublishedFileId_t OFOPKGCKJMB(ulong AJLPALFJHCC)
		{
			return new PublishedFileId_t(AJLPALFJHCC);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000039C5 File Offset: 0x00001BC5
		public static bool JLOCHIBFOOE(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return PublishedFileId_t.JHDBIABDGLI(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000395C File Offset: 0x00001B5C
		public static ulong OLDLOCJALFC(PublishedFileId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_PublishedFileId;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00003964 File Offset: 0x00001B64
		public static PublishedFileId_t NHFENIAGPGH(ulong AJLPALFJHCC)
		{
			return new PublishedFileId_t(AJLPALFJHCC);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool PHNJMELFJHE(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000394C File Offset: 0x00001B4C
		public static bool IAMCAOEJCKB(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PublishedFileId == DEJFBNMNMOK.m_PublishedFileId;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00003939 File Offset: 0x00001B39
		public int FJPFHEBNICF(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId.CompareTo(LNBMEILJKDH.m_PublishedFileId);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000394C File Offset: 0x00001B4C
		public static bool OLKDMLMMJHH(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_PublishedFileId == DEJFBNMNMOK.m_PublishedFileId;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000039D1 File Offset: 0x00001BD1
		public PublishedFileId_t(ulong AJLPALFJHCC)
		{
			this.m_PublishedFileId = AJLPALFJHCC;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000395C File Offset: 0x00001B5C
		public static ulong OMOGNLKCNAE(PublishedFileId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_PublishedFileId;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000396C File Offset: 0x00001B6C
		public static bool JHEELDCJJCN(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return !PublishedFileId_t.BGLONEMFOBG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00003964 File Offset: 0x00001B64
		public static PublishedFileId_t KDMCDHGNCBF(ulong AJLPALFJHCC)
		{
			return new PublishedFileId_t(AJLPALFJHCC);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000039DA File Offset: 0x00001BDA
		public override string ToString()
		{
			return this.m_PublishedFileId.ToString();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000039E7 File Offset: 0x00001BE7
		public static bool LOEENBMBLHI(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return PublishedFileId_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool MDCHFNJHJBF(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000395C File Offset: 0x00001B5C
		public static ulong MDHKPHFGMDC(PublishedFileId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_PublishedFileId;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00003964 File Offset: 0x00001B64
		public static PublishedFileId_t HAIGBPCLLHH(ulong AJLPALFJHCC)
		{
			return new PublishedFileId_t(AJLPALFJHCC);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00003A01 File Offset: 0x00001C01
		public static bool ILEALMPICFM(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return !PublishedFileId_t.JHDBIABDGLI(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00003A0D File Offset: 0x00001C0D
		public override int GetHashCode()
		{
			return this.m_PublishedFileId.GetHashCode();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool DBMDDNLKNNA(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000039A1 File Offset: 0x00001BA1
		public static bool PALENFIECHL(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return PublishedFileId_t.ICFJLJPOGEE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000395C File Offset: 0x00001B5C
		public static ulong LOEIJPMCCPF(PublishedFileId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_PublishedFileId;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00003939 File Offset: 0x00001B39
		public int DBPPIBGCMAG(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId.CompareTo(LNBMEILJKDH.m_PublishedFileId);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00003A1A File Offset: 0x00001C1A
		public static bool HCCJEBOKDIH(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return PublishedFileId_t.IAMCAOEJCKB(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00003A26 File Offset: 0x00001C26
		public static bool IJKBFPCKGPE(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return !PublishedFileId_t.KJDLGEAOBCN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00003939 File Offset: 0x00001B39
		public int IKDJDCLHBGI(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId.CompareTo(LNBMEILJKDH.m_PublishedFileId);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool GGFNJBLGAND(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000395C File Offset: 0x00001B5C
		public static ulong GDMEOLEOLGI(PublishedFileId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_PublishedFileId;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool EOKAGCFACDP(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00003A26 File Offset: 0x00001C26
		public static bool PJAPLIAIDCM(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return !PublishedFileId_t.KJDLGEAOBCN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000395C File Offset: 0x00001B5C
		public static ulong GADOGIBOENF(PublishedFileId_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_PublishedFileId;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000394C File Offset: 0x00001B4C
		public bool OEHGPCPILFB(PublishedFileId_t LNBMEILJKDH)
		{
			return this.m_PublishedFileId == LNBMEILJKDH.m_PublishedFileId;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000039B9 File Offset: 0x00001BB9
		public static bool AKCGBMIACGD(PublishedFileId_t OBNBCGOIMKE, PublishedFileId_t DEJFBNMNMOK)
		{
			return !PublishedFileId_t.MKONPBCDPHI(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0400007C RID: 124
		public static readonly PublishedFileId_t Invalid = new PublishedFileId_t(0UL);

		// Token: 0x0400007D RID: 125
		public ulong m_PublishedFileId;
	}
}
