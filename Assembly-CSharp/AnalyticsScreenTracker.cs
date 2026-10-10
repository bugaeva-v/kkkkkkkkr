using System;
using UnityEngine;

// Token: 0x0200044E RID: 1102
public class AnalyticsScreenTracker : MonoBehaviour
{
	// Token: 0x060085F8 RID: 34296 RVA: 0x000022C3 File Offset: 0x000004C3
	private void OGKHDICNFOO()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x060085F9 RID: 34297 RVA: 0x003B769C File Offset: 0x003B589C
	private void CEDPIGBOKGB()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.COKDLDOAACJ().LogScreen(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x060085FA RID: 34298 RVA: 0x003B76EC File Offset: 0x003B58EC
	private void OnEnable()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(this.screeName.ToString());
		}
	}

	// Token: 0x060085FB RID: 34299 RVA: 0x00002296 File Offset: 0x00000496
	private void MBGCLJJADKC()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x060085FC RID: 34300 RVA: 0x003B7711 File Offset: 0x003B5911
	private void EDANCCNNDMN()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.ANCEKPONIFI().LogScreen(this.screeName.ToString());
		}
	}

	// Token: 0x060085FD RID: 34301 RVA: 0x003B7736 File Offset: 0x003B5936
	private void DJEHHCPNPHC()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().FAEMDBGLPDF(this.screeName.ToString());
		}
	}

	// Token: 0x060085FE RID: 34302 RVA: 0x003B775C File Offset: 0x003B595C
	private void HMGJEJODDDE()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.JMDJBFAEHBM().PLLMICEAAPG(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x060085FF RID: 34303 RVA: 0x003B77AC File Offset: 0x003B59AC
	private void NINHFENBENF()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.ANCEKPONIFI().FAEMDBGLPDF(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008600 RID: 34304 RVA: 0x00002296 File Offset: 0x00000496
	private void MNMBFHCBJEO()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008601 RID: 34305 RVA: 0x003B77FC File Offset: 0x003B59FC
	private void KHPGMEMIJMB()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DMAAFFFEJGA().OJDGAFEBPLC(this.screeName.ToString());
		}
	}

	// Token: 0x06008602 RID: 34306 RVA: 0x003B7824 File Offset: 0x003B5A24
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.LogScreen(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008604 RID: 34308 RVA: 0x003B7874 File Offset: 0x003B5A74
	private void JLCMPGICMDC()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.KDHCDAEGNDN(this.screeName.ToString());
		}
	}

	// Token: 0x06008605 RID: 34309 RVA: 0x003B789C File Offset: 0x003B5A9C
	private void EKOJFMLPNGJ()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().OJDGAFEBPLC(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008606 RID: 34310 RVA: 0x000022C3 File Offset: 0x000004C3
	private void NNGMEPKMIIM()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06008607 RID: 34311 RVA: 0x003B78EC File Offset: 0x003B5AEC
	private void IFBCKJLCCAK()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.ANCEKPONIFI().KDHCDAEGNDN(this.screeName.ToString());
		}
	}

	// Token: 0x06008608 RID: 34312 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008609 RID: 34313 RVA: 0x003B7914 File Offset: 0x003B5B14
	private void GPLDMBFFDCM()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.COKDLDOAACJ().KDHCDAEGNDN(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x0600860A RID: 34314 RVA: 0x003B7964 File Offset: 0x003B5B64
	private void DJDLHIOMGJB()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.ANCEKPONIFI().JCBJENBEBCL(this.screeName.ToString());
		}
	}

	// Token: 0x0600860B RID: 34315 RVA: 0x003B7989 File Offset: 0x003B5B89
	private void KKDEMLNLMDP()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DMAAFFFEJGA().KDHCDAEGNDN(this.screeName.ToString());
		}
	}

	// Token: 0x0600860C RID: 34316 RVA: 0x000022C3 File Offset: 0x000004C3
	private void MFCNOIJEFKE()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600860D RID: 34317 RVA: 0x00002296 File Offset: 0x00000496
	private void DDEHCKJLNLM()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600860E RID: 34318 RVA: 0x000022C3 File Offset: 0x000004C3
	private void PMHEGLLDBCO()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600860F RID: 34319 RVA: 0x00002296 File Offset: 0x00000496
	private void MOEKELPHKIE()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008610 RID: 34320 RVA: 0x003B79AE File Offset: 0x003B5BAE
	private void CHEDGGLPOJP()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().NFFGLCIFMML(this.screeName.ToString());
		}
	}

	// Token: 0x06008611 RID: 34321 RVA: 0x003B7989 File Offset: 0x003B5B89
	private void DLKPPJDKPFN()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DMAAFFFEJGA().KDHCDAEGNDN(this.screeName.ToString());
		}
	}

	// Token: 0x06008612 RID: 34322 RVA: 0x00002296 File Offset: 0x00000496
	private void PPNLMELMMJE()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008613 RID: 34323 RVA: 0x003B7874 File Offset: 0x003B5A74
	private void KHOLJLKNAPJ()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.KDHCDAEGNDN(this.screeName.ToString());
		}
	}

	// Token: 0x06008614 RID: 34324 RVA: 0x003B79D3 File Offset: 0x003B5BD3
	private void HBELNHOMGCI()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.ANCEKPONIFI().FAEMDBGLPDF(this.screeName.ToString());
		}
	}

	// Token: 0x06008615 RID: 34325 RVA: 0x003B79F8 File Offset: 0x003B5BF8
	private void ANCFEINHJLL()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().AELJGCODPAM(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008616 RID: 34326 RVA: 0x00002296 File Offset: 0x00000496
	private void JOJFNEKCKGO()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008617 RID: 34327 RVA: 0x003B7A48 File Offset: 0x003B5C48
	private void CCNFPNFDNDP()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.COKDLDOAACJ().EJIAJEBHKKJ(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008618 RID: 34328 RVA: 0x003B7A98 File Offset: 0x003B5C98
	private void OANOLIAPPMH()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.AELJGCODPAM(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008619 RID: 34329 RVA: 0x003B7AE8 File Offset: 0x003B5CE8
	private void PBLDIMHDNNJ()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().FAPDDMCLHHE(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x0600861A RID: 34330 RVA: 0x003B7B38 File Offset: 0x003B5D38
	private void HHHJOCGGNHE()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().KKHHOGEGCHC(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x0600861B RID: 34331 RVA: 0x003B7B88 File Offset: 0x003B5D88
	private void GIOOKMFKLIO()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().PLLMICEAAPG(this.screeName.ToString());
		}
	}

	// Token: 0x0600861C RID: 34332 RVA: 0x00002296 File Offset: 0x00000496
	private void IAKHEGMEIKD()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600861D RID: 34333 RVA: 0x000022C3 File Offset: 0x000004C3
	private void NMINEEHFKAP()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600861E RID: 34334 RVA: 0x000022C3 File Offset: 0x000004C3
	private void BIMDHMGMLPB()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600861F RID: 34335 RVA: 0x003B7BAD File Offset: 0x003B5DAD
	private void MNNFOEOBLNF()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.HJGDLOOHNLO().FAPDDMCLHHE(this.screeName.ToString());
		}
	}

	// Token: 0x06008620 RID: 34336 RVA: 0x003B7BD2 File Offset: 0x003B5DD2
	private void GFJBNGMOBAC()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.COKDLDOAACJ().PLLMICEAAPG(this.screeName.ToString());
		}
	}

	// Token: 0x06008621 RID: 34337 RVA: 0x003B7BF7 File Offset: 0x003B5DF7
	private void MDFOBFFGDAB()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.ANCEKPONIFI().CLKGMAIPEHN(this.screeName.ToString());
		}
	}

	// Token: 0x06008622 RID: 34338 RVA: 0x003B7C1C File Offset: 0x003B5E1C
	private void IAJMGGFACOD()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().AHILBLIMLGJ(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008623 RID: 34339 RVA: 0x003B7C6C File Offset: 0x003B5E6C
	private void DHNDICIEGEE()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.HJGDLOOHNLO().PLLMICEAAPG(this.screeName.ToString());
		}
	}

	// Token: 0x06008624 RID: 34340 RVA: 0x003B7C94 File Offset: 0x003B5E94
	private void EMBGPLOIGEN()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.COKDLDOAACJ().PPMBJGAHAEA(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008625 RID: 34341 RVA: 0x003B7CE4 File Offset: 0x003B5EE4
	private void OGEFPECCDDE()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.JCBJENBEBCL(this.screeName.ToString());
		}
	}

	// Token: 0x06008626 RID: 34342 RVA: 0x003B7D09 File Offset: 0x003B5F09
	private void EHBJOHMNJFH()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.KKHHOGEGCHC(this.screeName.ToString());
		}
	}

	// Token: 0x06008627 RID: 34343 RVA: 0x003B7D2E File Offset: 0x003B5F2E
	private void GMKJOIDPAIE()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.ANCEKPONIFI().HMCOBPDJEEA(this.screeName.ToString());
		}
	}

	// Token: 0x06008628 RID: 34344 RVA: 0x003B7D53 File Offset: 0x003B5F53
	private void JJIGCFGKFHO()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.ANCEKPONIFI().FAPDDMCLHHE(this.screeName.ToString());
		}
	}

	// Token: 0x06008629 RID: 34345 RVA: 0x003B7D78 File Offset: 0x003B5F78
	private void MHIHCHGGIDM()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.JMDJBFAEHBM().OJDGAFEBPLC(this.screeName.ToString());
		}
	}

	// Token: 0x0600862A RID: 34346 RVA: 0x003B7DA0 File Offset: 0x003B5FA0
	private void EJKOKLIJDJL()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().PDPAKIJICNL(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x0600862B RID: 34347 RVA: 0x003B7DF0 File Offset: 0x003B5FF0
	private void MGNHFFHBLBP()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.COKDLDOAACJ().NFFGLCIFMML(this.screeName.ToString());
		}
	}

	// Token: 0x0600862C RID: 34348 RVA: 0x00002296 File Offset: 0x00000496
	private void HGLIDMLNPDJ()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x0600862D RID: 34349 RVA: 0x003B7E15 File Offset: 0x003B6015
	private void FBACIBOFHJO()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.HJGDLOOHNLO().EJIAJEBHKKJ(this.screeName.ToString());
		}
	}

	// Token: 0x0600862E RID: 34350 RVA: 0x003B79AE File Offset: 0x003B5BAE
	private void HOJIMOHCLHE()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().NFFGLCIFMML(this.screeName.ToString());
		}
	}

	// Token: 0x0600862F RID: 34351 RVA: 0x000022C3 File Offset: 0x000004C3
	private void NHAMGOIHKHH()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06008630 RID: 34352 RVA: 0x003B7E3C File Offset: 0x003B603C
	private void HONIBLHFFAE()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DMAAFFFEJGA().AELJGCODPAM(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008631 RID: 34353 RVA: 0x003B7E8C File Offset: 0x003B608C
	private void GIHIKHJGOHN()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.HJGDLOOHNLO().MDIKINNMNBK(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008632 RID: 34354 RVA: 0x003B7EDC File Offset: 0x003B60DC
	private void HGCELCKMIOD()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.HJGDLOOHNLO().HMCOBPDJEEA(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008633 RID: 34355 RVA: 0x003B7F2C File Offset: 0x003B612C
	private void GBLJNKDFFJD()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.ANCEKPONIFI().KDHCDAEGNDN(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008634 RID: 34356 RVA: 0x003B7F7C File Offset: 0x003B617C
	private void DNLGACANBLN()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.ANCEKPONIFI().NFFGLCIFMML(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008635 RID: 34357 RVA: 0x003B7FCC File Offset: 0x003B61CC
	private void GJMIHJNBPEB()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.JMDJBFAEHBM().PPMBJGAHAEA(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008636 RID: 34358 RVA: 0x003B801C File Offset: 0x003B621C
	private void OOOHPJJOODA()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DMAAFFFEJGA().PPMBJGAHAEA(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x06008637 RID: 34359 RVA: 0x00002296 File Offset: 0x00000496
	private void ICDPKJPAJAJ()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06008638 RID: 34360 RVA: 0x003B806C File Offset: 0x003B626C
	private void PABMEBKPBJO()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DEALKJPEMMH().EJIAJEBHKKJ(this.screeName.ToString());
		}
	}

	// Token: 0x06008639 RID: 34361 RVA: 0x003B8094 File Offset: 0x003B6294
	private void HKCLEPNKGDH()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.DMAAFFFEJGA().MDIKINNMNBK(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x0600863A RID: 34362 RVA: 0x003B7C6C File Offset: 0x003B5E6C
	private void ILOPFODPJCL()
	{
		if (this.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.HJGDLOOHNLO().PLLMICEAAPG(this.screeName.ToString());
		}
	}

	// Token: 0x0600863B RID: 34363 RVA: 0x000022C3 File Offset: 0x000004C3
	private void MPJCJLOMPED()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x0600863C RID: 34364 RVA: 0x003B80E4 File Offset: 0x003B62E4
	private void NGPHDNKNGHE()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		if (this.parentScreeTracker != null && this.parentScreeTracker.screeName != DFGILFBGPLN.none)
		{
			FirebaseAnalyticsManager.EHBBFMCILPC.PPMBJGAHAEA(this.parentScreeTracker.screeName.ToString());
		}
	}

	// Token: 0x040025BD RID: 9661
	public DFGILFBGPLN screeName;

	// Token: 0x040025BE RID: 9662
	public AnalyticsScreenTracker parentScreeTracker;
}
