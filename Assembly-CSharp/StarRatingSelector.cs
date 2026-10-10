using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000053 RID: 83
public class StarRatingSelector : MonoBehaviour
{
	// Token: 0x06000B50 RID: 2896 RVA: 0x00051DFC File Offset: 0x0004FFFC
	private void GBIDDHNBECB()
	{
		this.star1anim.gameObject.SetActive(true);
		this.star2anim.gameObject.SetActive(true);
		this.star3anim.gameObject.SetActive(true);
		this.star4anim.gameObject.SetActive(true);
		this.star5anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x00003E52 File Offset: 0x00002052
	private void EBBIFAMPCCI()
	{
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x00051ED4 File Offset: 0x000500D4
	public void DCFLNLEPMLJ()
	{
		StarRatingSelector.lastRating = 1;
		this.star3anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x00051F6C File Offset: 0x0005016C
	private void EKOJFMLPNGJ()
	{
		this.star1anim.gameObject.SetActive(false);
		this.star2anim.gameObject.SetActive(true);
		this.star3anim.gameObject.SetActive(true);
		this.star4anim.gameObject.SetActive(false);
		this.star5anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x00052044 File Offset: 0x00050244
	private void GJMIHJNBPEB()
	{
		this.star1anim.gameObject.SetActive(true);
		this.star2anim.gameObject.SetActive(false);
		this.star3anim.gameObject.SetActive(true);
		this.star4anim.gameObject.SetActive(true);
		this.star5anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x0005211C File Offset: 0x0005031C
	private void OnEnable()
	{
		if (!StarRatingSelector.EAFNPCBNDKM)
		{
			StarRatingSelector.lastRating = 0;
			return;
		}
		if (StarRatingSelector.lastRating == 1)
		{
			this.SelectOneStar();
			return;
		}
		if (StarRatingSelector.lastRating == 2)
		{
			this.SelectTwoStars();
			return;
		}
		if (StarRatingSelector.lastRating == 3)
		{
			this.SelectThreeStars();
			return;
		}
		if (StarRatingSelector.lastRating == 4)
		{
			this.SelectFourStars();
			return;
		}
		if (StarRatingSelector.lastRating == 5)
		{
			this.SelectFiveStars();
		}
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x00052184 File Offset: 0x00050384
	private void EKIDOPDDHJD()
	{
		this.star1anim.gameObject.SetActive(false);
		this.star2anim.gameObject.SetActive(false);
		this.star3anim.gameObject.SetActive(false);
		this.star4anim.gameObject.SetActive(true);
		this.star5anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x0005225C File Offset: 0x0005045C
	public void CMIGPHJOLAK()
	{
		StarRatingSelector.lastRating = 1;
		this.star2anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x000522F3 File Offset: 0x000504F3
	public static void KICOHCKIHED(bool KIDHBAMJGDO)
	{
		StarRatingSelector.EAFNPCBNDKM = KIDHBAMJGDO;
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x000522FC File Offset: 0x000504FC
	public void CMHNJIIPDNK()
	{
		StarRatingSelector.lastRating = 0;
		this.star1anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x000522F3 File Offset: 0x000504F3
	public static void ECDBHJPLLNL(bool KIDHBAMJGDO)
	{
		StarRatingSelector.EAFNPCBNDKM = KIDHBAMJGDO;
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x00052394 File Offset: 0x00050594
	public void BKLNMFMCECM()
	{
		StarRatingSelector.lastRating = 7;
		this.star5anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x0005242C File Offset: 0x0005062C
	private void OGEFPECCDDE()
	{
		if (!StarRatingSelector.EAFNPCBNDKM)
		{
			StarRatingSelector.lastRating = 0;
			return;
		}
		if (StarRatingSelector.lastRating == 0)
		{
			this.SelectOneStar();
			return;
		}
		if (StarRatingSelector.lastRating == 5)
		{
			this.MDMJIKFEHOG();
			return;
		}
		if (StarRatingSelector.lastRating == 0)
		{
			this.NIHJPEGOJPJ();
			return;
		}
		if (StarRatingSelector.lastRating == 0)
		{
			this.MALDDGMKEBG();
			return;
		}
		if (StarRatingSelector.lastRating == 6)
		{
			this.PHBNHDDDNND();
		}
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x00052494 File Offset: 0x00050694
	public void NHILEFGMHPB()
	{
		StarRatingSelector.lastRating = 6;
		this.star4anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x0005252C File Offset: 0x0005072C
	public void JFKBKELONHI()
	{
		StarRatingSelector.lastRating = 6;
		this.star3anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x000525C4 File Offset: 0x000507C4
	public void OBENGLHFGEF()
	{
		StarRatingSelector.lastRating = 5;
		this.star2anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x0005265B File Offset: 0x0005085B
	public static void KBLNNAMPEKI()
	{
		StarRatingSelector.lastRating = 1;
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x00052664 File Offset: 0x00050864
	private void CHEDGGLPOJP()
	{
		if (!StarRatingSelector.EAFNPCBNDKM)
		{
			StarRatingSelector.lastRating = 0;
			return;
		}
		if (StarRatingSelector.lastRating == 1)
		{
			this.SelectOneStar();
			return;
		}
		if (StarRatingSelector.lastRating == 3)
		{
			this.CMIGPHJOLAK();
			return;
		}
		if (StarRatingSelector.lastRating == 8)
		{
			this.MCPBIEICMPC();
			return;
		}
		if (StarRatingSelector.lastRating == 1)
		{
			this.SelectFourStars();
			return;
		}
		if (StarRatingSelector.lastRating == 5)
		{
			this.IGBELCJCCIB();
		}
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x000526CC File Offset: 0x000508CC
	private void MGGPLDCIPJN()
	{
		this.star1anim.gameObject.SetActive(false);
		this.star2anim.gameObject.SetActive(true);
		this.star3anim.gameObject.SetActive(false);
		this.star4anim.gameObject.SetActive(false);
		this.star5anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x000522F3 File Offset: 0x000504F3
	public static void MFGIPLNOADA(bool KIDHBAMJGDO)
	{
		StarRatingSelector.EAFNPCBNDKM = KIDHBAMJGDO;
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x000527A4 File Offset: 0x000509A4
	public void MALDDGMKEBG()
	{
		StarRatingSelector.lastRating = 1;
		this.star4anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x0005283C File Offset: 0x00050A3C
	public void PHLNBMNLGAM()
	{
		StarRatingSelector.lastRating = 0;
		this.star5anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x000528D4 File Offset: 0x00050AD4
	public void LELJIPFOMGF()
	{
		StarRatingSelector.lastRating = 7;
		this.star5anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x0005296C File Offset: 0x00050B6C
	public void OBNJBDHICAM()
	{
		StarRatingSelector.lastRating = 8;
		this.star3anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x00003E52 File Offset: 0x00002052
	private void ODOOIGEDLKB()
	{
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x00052A04 File Offset: 0x00050C04
	public void EKHLEINOMKN()
	{
		StarRatingSelector.lastRating = 1;
		this.star5anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x00052A9B File Offset: 0x00050C9B
	public static void DMAMDMFNKED()
	{
		StarRatingSelector.lastRating = 0;
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x0005265B File Offset: 0x0005085B
	public static void MEAFFBAJFKO()
	{
		StarRatingSelector.lastRating = 1;
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x00052AA4 File Offset: 0x00050CA4
	public void MCPBIEICMPC()
	{
		StarRatingSelector.lastRating = 6;
		this.star3anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00052B3C File Offset: 0x00050D3C
	private void PABMEBKPBJO()
	{
		if (!StarRatingSelector.EAFNPCBNDKM)
		{
			StarRatingSelector.lastRating = 1;
			return;
		}
		if (StarRatingSelector.lastRating == 0)
		{
			this.JPPEMOOJGDD();
			return;
		}
		if (StarRatingSelector.lastRating == 6)
		{
			this.SelectTwoStars();
			return;
		}
		if (StarRatingSelector.lastRating == 1)
		{
			this.JFKBKELONHI();
			return;
		}
		if (StarRatingSelector.lastRating == 3)
		{
			this.EDFJADDCAEL();
			return;
		}
		if (StarRatingSelector.lastRating == 1)
		{
			this.BKLNMFMCECM();
		}
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x00052BA4 File Offset: 0x00050DA4
	public void SelectOneStar()
	{
		StarRatingSelector.lastRating = 1;
		this.star1anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x00052C3C File Offset: 0x00050E3C
	private void MIEEIOCPCNL()
	{
		this.star1anim.gameObject.SetActive(true);
		this.star2anim.gameObject.SetActive(false);
		this.star3anim.gameObject.SetActive(false);
		this.star4anim.gameObject.SetActive(true);
		this.star5anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x00052D14 File Offset: 0x00050F14
	private void NGPHDNKNGHE()
	{
		this.star1anim.gameObject.SetActive(false);
		this.star2anim.gameObject.SetActive(false);
		this.star3anim.gameObject.SetActive(false);
		this.star4anim.gameObject.SetActive(true);
		this.star5anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x000522F3 File Offset: 0x000504F3
	public static void GPHGHLCFNDK(bool KIDHBAMJGDO)
	{
		StarRatingSelector.EAFNPCBNDKM = KIDHBAMJGDO;
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x000522F3 File Offset: 0x000504F3
	public static void RememberLastRating(bool KIDHBAMJGDO)
	{
		StarRatingSelector.EAFNPCBNDKM = KIDHBAMJGDO;
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x000522F3 File Offset: 0x000504F3
	public static void COFMKBKJEON(bool KIDHBAMJGDO)
	{
		StarRatingSelector.EAFNPCBNDKM = KIDHBAMJGDO;
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x000522F3 File Offset: 0x000504F3
	public static void NDAHJJEONIN(bool KIDHBAMJGDO)
	{
		StarRatingSelector.EAFNPCBNDKM = KIDHBAMJGDO;
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00052DEC File Offset: 0x00050FEC
	private void JJIGCFGKFHO()
	{
		if (!StarRatingSelector.EAFNPCBNDKM)
		{
			StarRatingSelector.lastRating = 1;
			return;
		}
		if (StarRatingSelector.lastRating == 1)
		{
			this.GDJDILMCONE();
			return;
		}
		if (StarRatingSelector.lastRating == 1)
		{
			this.CMIGPHJOLAK();
			return;
		}
		if (StarRatingSelector.lastRating == 4)
		{
			this.OBNJBDHICAM();
			return;
		}
		if (StarRatingSelector.lastRating == 5)
		{
			this.SelectFourStars();
			return;
		}
		if (StarRatingSelector.lastRating == 8)
		{
			this.IGOMCNMDPNE();
		}
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x00052E54 File Offset: 0x00051054
	public void NBDPNCINNKK()
	{
		StarRatingSelector.lastRating = 1;
		this.star1anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x000522F3 File Offset: 0x000504F3
	public static void KOJGKGODKOL(bool KIDHBAMJGDO)
	{
		StarRatingSelector.EAFNPCBNDKM = KIDHBAMJGDO;
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x00052EEC File Offset: 0x000510EC
	public void DNCHBMFHEMG()
	{
		StarRatingSelector.lastRating = 0;
		this.star1anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x00052A9B File Offset: 0x00050C9B
	public static void JOMBAFBAAKG()
	{
		StarRatingSelector.lastRating = 0;
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x00052F84 File Offset: 0x00051184
	public void SelectThreeStars()
	{
		StarRatingSelector.lastRating = 3;
		this.star3anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x0005301C File Offset: 0x0005121C
	public void DIMJPEMCIGO()
	{
		StarRatingSelector.lastRating = 4;
		this.star3anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x000530B4 File Offset: 0x000512B4
	private void KPNLKBPCDAF()
	{
		this.star1anim.gameObject.SetActive(false);
		this.star2anim.gameObject.SetActive(false);
		this.star3anim.gameObject.SetActive(true);
		this.star4anim.gameObject.SetActive(true);
		this.star5anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B7F RID: 2943 RVA: 0x0005318C File Offset: 0x0005138C
	public void NIHJPEGOJPJ()
	{
		StarRatingSelector.lastRating = 7;
		this.star3anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B80 RID: 2944 RVA: 0x00003E52 File Offset: 0x00002052
	private void AMLICNPKJNO()
	{
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x00053224 File Offset: 0x00051424
	public void JPPEMOOJGDD()
	{
		StarRatingSelector.lastRating = 1;
		this.star1anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x000532BC File Offset: 0x000514BC
	public void GJPDJIHIOBD()
	{
		StarRatingSelector.lastRating = 5;
		this.star5anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x00053354 File Offset: 0x00051554
	public void EDFJADDCAEL()
	{
		StarRatingSelector.lastRating = 7;
		this.star4anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x000533EC File Offset: 0x000515EC
	public void ICFMHIKIFOO()
	{
		StarRatingSelector.lastRating = 1;
		this.star4anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x00053484 File Offset: 0x00051684
	public void SelectTwoStars()
	{
		StarRatingSelector.lastRating = 2;
		this.star2anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x0005351C File Offset: 0x0005171C
	private void IJMPLMMFIEP()
	{
		if (!StarRatingSelector.EAFNPCBNDKM)
		{
			StarRatingSelector.lastRating = 1;
			return;
		}
		if (StarRatingSelector.lastRating == 0)
		{
			this.JPPEMOOJGDD();
			return;
		}
		if (StarRatingSelector.lastRating == 2)
		{
			this.MDMJIKFEHOG();
			return;
		}
		if (StarRatingSelector.lastRating == 3)
		{
			this.OBNJBDHICAM();
			return;
		}
		if (StarRatingSelector.lastRating == 7)
		{
			this.NHILEFGMHPB();
			return;
		}
		if (StarRatingSelector.lastRating == 3)
		{
			this.IGBELCJCCIB();
		}
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x00053584 File Offset: 0x00051784
	public void MDMJIKFEHOG()
	{
		StarRatingSelector.lastRating = 7;
		this.star2anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B88 RID: 2952 RVA: 0x0005361C File Offset: 0x0005181C
	public void IGOMCNMDPNE()
	{
		StarRatingSelector.lastRating = 0;
		this.star5anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B89 RID: 2953 RVA: 0x000536B4 File Offset: 0x000518B4
	public void PHBNHDDDNND()
	{
		StarRatingSelector.lastRating = 2;
		this.star5anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x0005374C File Offset: 0x0005194C
	public void MAPGOCAPIFF()
	{
		StarRatingSelector.lastRating = 5;
		this.star5anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B8B RID: 2955 RVA: 0x000537E4 File Offset: 0x000519E4
	public void SelectFourStars()
	{
		StarRatingSelector.lastRating = 4;
		this.star4anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x0005387C File Offset: 0x00051A7C
	public void ODFEKKILMIN()
	{
		StarRatingSelector.lastRating = 4;
		this.star4anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B8D RID: 2957 RVA: 0x00053914 File Offset: 0x00051B14
	public void GDJDILMCONE()
	{
		StarRatingSelector.lastRating = 0;
		this.star1anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B8E RID: 2958 RVA: 0x000539AC File Offset: 0x00051BAC
	private void OnDisable()
	{
		this.star1anim.gameObject.SetActive(false);
		this.star2anim.gameObject.SetActive(false);
		this.star3anim.gameObject.SetActive(false);
		this.star4anim.gameObject.SetActive(false);
		this.star5anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[0];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x06000B8F RID: 2959 RVA: 0x00053A84 File Offset: 0x00051C84
	public void IGBELCJCCIB()
	{
		StarRatingSelector.lastRating = 4;
		this.star5anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B90 RID: 2960 RVA: 0x00053B1C File Offset: 0x00051D1C
	public void KEBODGIGMLP()
	{
		StarRatingSelector.lastRating = 8;
		this.star3anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[0];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[0];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x00053BB4 File Offset: 0x00051DB4
	private void ILOPFODPJCL()
	{
		if (!StarRatingSelector.EAFNPCBNDKM)
		{
			StarRatingSelector.lastRating = 0;
			return;
		}
		if (StarRatingSelector.lastRating == 0)
		{
			this.DNCHBMFHEMG();
			return;
		}
		if (StarRatingSelector.lastRating == 2)
		{
			this.MDMJIKFEHOG();
			return;
		}
		if (StarRatingSelector.lastRating == 2)
		{
			this.OBNJBDHICAM();
			return;
		}
		if (StarRatingSelector.lastRating == 8)
		{
			this.EDFJADDCAEL();
			return;
		}
		if (StarRatingSelector.lastRating == 8)
		{
			this.IGBELCJCCIB();
		}
	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x00053C1C File Offset: 0x00051E1C
	public void SelectFiveStars()
	{
		StarRatingSelector.lastRating = 5;
		this.star5anim.gameObject.SetActive(true);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[1];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[1];
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x00003E52 File Offset: 0x00002052
	private void FPJBOINCKCE()
	{
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x00052A9B File Offset: 0x00050C9B
	public static void SelectNoStars()
	{
		StarRatingSelector.lastRating = 0;
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x00053CB4 File Offset: 0x00051EB4
	public void NJNNCGCCFMN()
	{
		StarRatingSelector.lastRating = 8;
		this.star5anim.gameObject.SetActive(false);
		this.star1.sprite = this.starSprites[1];
		this.star2.sprite = this.starSprites[1];
		this.star3.sprite = this.starSprites[0];
		this.star4.sprite = this.starSprites[1];
		this.star5.sprite = this.starSprites[0];
	}

	// Token: 0x04000380 RID: 896
	public static int lastRating;

	// Token: 0x04000381 RID: 897
	public Image star1;

	// Token: 0x04000382 RID: 898
	public Image star2;

	// Token: 0x04000383 RID: 899
	public Image star3;

	// Token: 0x04000384 RID: 900
	public Image star4;

	// Token: 0x04000385 RID: 901
	public Image star5;

	// Token: 0x04000386 RID: 902
	public Image star1anim;

	// Token: 0x04000387 RID: 903
	public Image star2anim;

	// Token: 0x04000388 RID: 904
	public Image star3anim;

	// Token: 0x04000389 RID: 905
	public Image star4anim;

	// Token: 0x0400038A RID: 906
	public Image star5anim;

	// Token: 0x0400038B RID: 907
	public List<Sprite> starSprites;

	// Token: 0x0400038C RID: 908
	private static bool EAFNPCBNDKM;
}
