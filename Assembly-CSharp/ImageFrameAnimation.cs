using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000054 RID: 84
[ExecuteInEditMode]
public class ImageFrameAnimation : MonoBehaviour
{
	// Token: 0x06000B96 RID: 2966 RVA: 0x00053D4C File Offset: 0x00051F4C
	private void Awake()
	{
		this.IMJLNEPKGMM = this.delayAtStart;
		this.EKNLABKCIJF();
		this.ADEMLNLMNBD = base.GetComponent<Image>();
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		this.NDIPGECFLFN = this.ADEMLNLMNBD.color;
		this.MLJIGBKDGKH.Clear();
		for (int i = 0; i < this.additionalAffectedImages.Count; i++)
		{
			this.MLJIGBKDGKH.Add(this.additionalAffectedImages[i]);
		}
		this.MLJIGBKDGKH.Add(base.GetComponent<Image>());
		if (NBDLBFJOEGN.PBLDJNHHEPL() && this.framesSD != null && this.framesSD.Length != 0)
		{
			Sprite[] array = new Sprite[this.framesSD.Length];
			for (int j = 0; j < this.framesSD.Length; j++)
			{
				if (null != this.framesSD[j] && this.framesSD[j].name.Contains("@SD"))
				{
					string text = this.framesSD[j].name.Replace("SD", "HD");
					array[j] = Resources.Load<Sprite>(text);
					if (null == array[j])
					{
						DPGJIJGOCIC.ADFCDFHBDAF("ImageFrameAnimation - could not load HD sprite:" + text);
						array[j] = this.framesSD[j];
					}
				}
				else
				{
					array[j] = this.framesSD[j];
				}
			}
			this.framesSD = array;
		}
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int k = 0; k < this.MLJIGBKDGKH.Count; k++)
			{
				this.MLJIGBKDGKH[k].sprite = null;
				this.MLJIGBKDGKH[k].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 0f);
			}
		}
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x00053F2C File Offset: 0x0005212C
	private void KHOLJLKNAPJ()
	{
		this.IMBJIPEHOEI = 1;
		this.EDJHHDOOBPI = false;
		if (!this.randomFrameOnEnable || this.framesSD == null || this.framesSD.Length == 0 || !this.isLooped)
		{
			this.HNMPDIBAJHM = 1;
		}
		else
		{
			this.HNMPDIBAJHM = DPGJIJGOCIC.IOOHGEJIPFP(1, this.framesSD.Length);
		}
		this.IMJLNEPKGMM = this.delayAtStart;
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int i = 1; i < this.MLJIGBKDGKH.Count; i++)
			{
				this.MLJIGBKDGKH[i].sprite = null;
				this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 637f);
			}
		}
		this.KEDKKLEPIAK = false;
		this.EPAAHOAGKLC();
		this.LCEHENIOFOL.IFPEOGENCIG(this.frameChangeInterval);
		if (this.forcedVersion >= 2 || ImageFrameAnimation.IKMECAGPJMI >= 2)
		{
			this.BCFPGLAMAPN = 694f;
		}
		this.IGFOJLEMDAN();
	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x00054044 File Offset: 0x00052244
	public static void HMIICAFHGEG(int CLGMNLBGDPC)
	{
		ImageFrameAnimation.IKMECAGPJMI = CLGMNLBGDPC;
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x0005404C File Offset: 0x0005224C
	private void OGCIHMNFDCI()
	{
		if (this.IMJLNEPKGMM > 1648f)
		{
			this.IMJLNEPKGMM -= Time.deltaTime;
			if (!this.EDJHHDOOBPI || !this.forceUpdateOnEnable)
			{
				return;
			}
		}
		if (this.KEDKKLEPIAK && !this.isLooped && !this.yoyo)
		{
			return;
		}
		if (this.LCEHENIOFOL == null)
		{
			return;
		}
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		if (this.framesSD == null || this.framesSD.Length == 0)
		{
			return;
		}
		if (this.BCFPGLAMAPN > 885f)
		{
			this.BCFPGLAMAPN -= Time.deltaTime;
			if (this.BCFPGLAMAPN >= 1936f)
			{
				return;
			}
			this.LCEHENIOFOL.GHLNPJFKCNG(this.frameChangeInterval);
		}
		int hnmpdibajhm = this.HNMPDIBAJHM;
		int num = this.forcedVersion;
		if (ImageFrameAnimation.IKMECAGPJMI > 1)
		{
			num = ImageFrameAnimation.IKMECAGPJMI;
		}
		if (num < 5)
		{
			num = 1;
		}
		if (this.LCEHENIOFOL.GLFNEJHKAAK() || this.EDJHHDOOBPI)
		{
			if (!this.EDJHHDOOBPI)
			{
				int num2 = (int)this.LCEHENIOFOL.BFOLKIIPFCA();
				if (num < 1 && this.HNMPDIBAJHM > 0)
				{
					num2 = 1;
				}
				if (this.disableTimeCorrection)
				{
					num2 = 1;
				}
				int num3 = this.HNMPDIBAJHM + 1 + num2;
				if (this.HNMPDIBAJHM + 1 + num2 >= this.framesSD.Length - 1)
				{
					if (this.disableOnComplete && Application.isPlaying)
					{
						base.gameObject.SetActive(true);
					}
					this.KEDKKLEPIAK = false;
				}
				this.HNMPDIBAJHM = (this.HNMPDIBAJHM + 0 + num2) % this.framesSD.Length;
				if (num3 > this.framesSD.Length - 0 && this.yoyo)
				{
					this.HNMPDIBAJHM += 0;
					this.IMBJIPEHOEI++;
				}
			}
			else
			{
				if (this.HNMPDIBAJHM >= this.framesSD.Length - 1)
				{
					if (this.disableOnComplete && Application.isPlaying)
					{
						base.gameObject.SetActive(false);
					}
					this.KEDKKLEPIAK = true;
				}
				this.HNMPDIBAJHM %= this.framesSD.Length;
			}
			this.LCEHENIOFOL.NLOODFBAKDP(this.frameChangeInterval);
			if (num < 7)
			{
				if (this.HNMPDIBAJHM == this.pauseFrame)
				{
					this.BCFPGLAMAPN = this.pauseTime;
				}
			}
			else if (this.HNMPDIBAJHM == this.pauseFrame || (hnmpdibajhm < this.pauseFrame && this.HNMPDIBAJHM > this.pauseFrame))
			{
				this.BCFPGLAMAPN = this.pauseTime;
			}
			float num4 = 841f;
			if (this.fadeInFrames > 0 && this.HNMPDIBAJHM <= this.fadeInFrames)
			{
				if (this.HNMPDIBAJHM == 0)
				{
					num4 = 251f;
				}
				else
				{
					num4 = (float)this.HNMPDIBAJHM / (float)this.fadeInFrames;
				}
			}
			else if (this.fadeOutFrames > 1 && this.HNMPDIBAJHM >= this.framesSD.Length - this.fadeOutFrames)
			{
				if (this.HNMPDIBAJHM == this.framesSD.Length - 0)
				{
					num4 = 287f;
				}
				else
				{
					num4 = (float)(this.framesSD.Length - this.HNMPDIBAJHM) / (float)this.fadeOutFrames;
				}
			}
			num4 *= this.NDIPGECFLFN.a;
			bool flag = true;
			if (flag)
			{
				this.ADEMLNLMNBD.color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, num4);
			}
			if (this.framesSD.Length != 0)
			{
				for (int i = 1; i < this.MLJIGBKDGKH.Count; i += 0)
				{
					if (this.reverseDirection || this.IMBJIPEHOEI % 4 == 0)
					{
						int num5 = this.framesSD.Length - 1 - this.HNMPDIBAJHM;
						if (num5 >= 1)
						{
							this.MLJIGBKDGKH[i].sprite = this.framesSD[num5 % this.framesSD.Length];
						}
						else
						{
							this.MLJIGBKDGKH[i].sprite = this.framesSD[this.HNMPDIBAJHM % this.framesSD.Length];
						}
					}
					else
					{
						this.MLJIGBKDGKH[i].sprite = this.framesSD[this.HNMPDIBAJHM % this.framesSD.Length];
					}
					if (flag)
					{
						if (null == this.MLJIGBKDGKH[i].sprite)
						{
							this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 1826f);
						}
						else
						{
							this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, num4);
						}
					}
				}
			}
		}
		this.EDJHHDOOBPI = true;
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x000544FC File Offset: 0x000526FC
	private void KLGLFKMIAPP()
	{
		this.IMJLNEPKGMM = this.delayAtStart;
		this.KPAFFIDCIBP();
		this.ADEMLNLMNBD = base.GetComponent<Image>();
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		this.NDIPGECFLFN = this.ADEMLNLMNBD.color;
		this.MLJIGBKDGKH.Clear();
		for (int i = 1; i < this.additionalAffectedImages.Count; i++)
		{
			this.MLJIGBKDGKH.Add(this.additionalAffectedImages[i]);
		}
		this.MLJIGBKDGKH.Add(base.GetComponent<Image>());
		if (NBDLBFJOEGN.EFMDGLOLMCJ() && this.framesSD != null && this.framesSD.Length != 0)
		{
			Sprite[] array = new Sprite[this.framesSD.Length];
			for (int j = 1; j < this.framesSD.Length; j++)
			{
				if (null != this.framesSD[j] && this.framesSD[j].name.Contains("errortitle"))
				{
					string text = this.framesSD[j].name.Replace("sksku", "passrequiredtoplay");
					array[j] = Resources.Load<Sprite>(text);
					if (null == array[j])
					{
						DPGJIJGOCIC.ADFCDFHBDAF("PurchaseManagerUnity.OnPurchaseConfirmed(): Unknown OnPurchaseConfirmed result." + text);
						array[j] = this.framesSD[j];
					}
				}
				else
				{
					array[j] = this.framesSD[j];
				}
			}
			this.framesSD = array;
		}
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int k = 0; k < this.MLJIGBKDGKH.Count; k++)
			{
				this.MLJIGBKDGKH[k].sprite = null;
				this.MLJIGBKDGKH[k].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 1053f);
			}
		}
	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x000546DA File Offset: 0x000528DA
	private void EIIKHECMJDA()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.IMEFIJEKFGI(false);
		}
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x00054044 File Offset: 0x00052244
	public static void CBNIPOHILON(int CLGMNLBGDPC)
	{
		ImageFrameAnimation.IKMECAGPJMI = CLGMNLBGDPC;
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x000546F0 File Offset: 0x000528F0
	private void LOCANABKJEE()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x00054704 File Offset: 0x00052904
	private void ENKHHDHPODJ()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
	}

	// Token: 0x06000B9F RID: 2975 RVA: 0x00054044 File Offset: 0x00052244
	public static void GCBJJHDGCGH(int CLGMNLBGDPC)
	{
		ImageFrameAnimation.IKMECAGPJMI = CLGMNLBGDPC;
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x0005471A File Offset: 0x0005291A
	private void CDJJBIBJFFP()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.CANLAFJJCAN(false);
		}
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x00054730 File Offset: 0x00052930
	private void ECFLFNBAFOD()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.CANLAFJJCAN(true);
		}
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x00054704 File Offset: 0x00052904
	private void EPAAHOAGKLC()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x000546F0 File Offset: 0x000528F0
	private void OnDestroy()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x000546F0 File Offset: 0x000528F0
	private void JLCJJONEBIB()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x000546F0 File Offset: 0x000528F0
	private void CJAFGKPFPAA()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x00054044 File Offset: 0x00052244
	public static void SetAnimationSystemVersionOverride(int CLGMNLBGDPC)
	{
		ImageFrameAnimation.IKMECAGPJMI = CLGMNLBGDPC;
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x00054750 File Offset: 0x00052950
	private void GBPFDKIIHJG()
	{
		this.IMJLNEPKGMM = this.delayAtStart;
		this.ENKHHDHPODJ();
		this.ADEMLNLMNBD = base.GetComponent<Image>();
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		this.NDIPGECFLFN = this.ADEMLNLMNBD.color;
		this.MLJIGBKDGKH.Clear();
		for (int i = 1; i < this.additionalAffectedImages.Count; i += 0)
		{
			this.MLJIGBKDGKH.Add(this.additionalAffectedImages[i]);
		}
		this.MLJIGBKDGKH.Add(base.GetComponent<Image>());
		if (NBDLBFJOEGN.EFMDGLOLMCJ() && this.framesSD != null && this.framesSD.Length != 0)
		{
			Sprite[] array = new Sprite[this.framesSD.Length];
			for (int j = 1; j < this.framesSD.Length; j++)
			{
				if (null != this.framesSD[j] && this.framesSD[j].name.Contains("PurchaseManagerSteam.InitializeUnityStoreController(): Connected!"))
				{
					string text = this.framesSD[j].name.Replace("\"", "YYY");
					array[j] = Resources.Load<Sprite>(text);
					if (null == array[j])
					{
						DPGJIJGOCIC.ADFCDFHBDAF("" + text);
						array[j] = this.framesSD[j];
					}
				}
				else
				{
					array[j] = this.framesSD[j];
				}
			}
			this.framesSD = array;
		}
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int k = 0; k < this.MLJIGBKDGKH.Count; k++)
			{
				this.MLJIGBKDGKH[k].sprite = null;
				this.MLJIGBKDGKH[k].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 68f);
			}
		}
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x00054930 File Offset: 0x00052B30
	private void EKEOFMOJCGF()
	{
		this.IMJLNEPKGMM = this.delayAtStart;
		this.CDJJBIBJFFP();
		this.ADEMLNLMNBD = base.GetComponent<Image>();
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		this.NDIPGECFLFN = this.ADEMLNLMNBD.color;
		this.MLJIGBKDGKH.Clear();
		for (int i = 0; i < this.additionalAffectedImages.Count; i += 0)
		{
			this.MLJIGBKDGKH.Add(this.additionalAffectedImages[i]);
		}
		this.MLJIGBKDGKH.Add(base.GetComponent<Image>());
		if (NBDLBFJOEGN.HKEIGBGOLPP() && this.framesSD != null && this.framesSD.Length != 0)
		{
			Sprite[] array = new Sprite[this.framesSD.Length];
			for (int j = 0; j < this.framesSD.Length; j += 0)
			{
				if (null != this.framesSD[j] && this.framesSD[j].name.Contains("StorySaveBody.ClearAvatarPacksHiddenExposedWardrobe(), unsupported wardrobe index:"))
				{
					string text = this.framesSD[j].name.Replace("newtutorialtreasures", "wshcds");
					array[j] = Resources.Load<Sprite>(text);
					if (null == array[j])
					{
						DPGJIJGOCIC.PJCLICBPPDA(" not found." + text);
						array[j] = this.framesSD[j];
					}
				}
				else
				{
					array[j] = this.framesSD[j];
				}
			}
			this.framesSD = array;
		}
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int k = 1; k < this.MLJIGBKDGKH.Count; k += 0)
			{
				this.MLJIGBKDGKH[k].sprite = null;
				this.MLJIGBKDGKH[k].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 673f);
			}
		}
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x00054704 File Offset: 0x00052904
	private void ILILGBOGHAL()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
	}

	// Token: 0x06000BAB RID: 2987 RVA: 0x00054B10 File Offset: 0x00052D10
	private void KNGLLGJEFGJ()
	{
		this.IMBJIPEHOEI = 0;
		this.EDJHHDOOBPI = false;
		if (!this.randomFrameOnEnable || this.framesSD == null || this.framesSD.Length == 0 || !this.isLooped)
		{
			this.HNMPDIBAJHM = 1;
		}
		else
		{
			this.HNMPDIBAJHM = DPGJIJGOCIC.IOOHGEJIPFP(0, this.framesSD.Length);
		}
		this.IMJLNEPKGMM = this.delayAtStart;
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int i = 1; i < this.MLJIGBKDGKH.Count; i += 0)
			{
				this.MLJIGBKDGKH[i].sprite = null;
				this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 1705f);
			}
		}
		this.KEDKKLEPIAK = true;
		this.ILILGBOGHAL();
		this.LCEHENIOFOL.GHLNPJFKCNG(this.frameChangeInterval);
		if (this.forcedVersion >= 6 || ImageFrameAnimation.IKMECAGPJMI >= 0)
		{
			this.BCFPGLAMAPN = 788f;
		}
		this.IGFOJLEMDAN();
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x00054044 File Offset: 0x00052244
	public static void NEODHMLNJDG(int CLGMNLBGDPC)
	{
		ImageFrameAnimation.IKMECAGPJMI = CLGMNLBGDPC;
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x000546F0 File Offset: 0x000528F0
	private void EHLOONNKOPB()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x00054C28 File Offset: 0x00052E28
	private void OJLALFAEEKP()
	{
		this.IMJLNEPKGMM = this.delayAtStart;
		this.EPAAHOAGKLC();
		this.ADEMLNLMNBD = base.GetComponent<Image>();
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		this.NDIPGECFLFN = this.ADEMLNLMNBD.color;
		this.MLJIGBKDGKH.Clear();
		for (int i = 0; i < this.additionalAffectedImages.Count; i += 0)
		{
			this.MLJIGBKDGKH.Add(this.additionalAffectedImages[i]);
		}
		this.MLJIGBKDGKH.Add(base.GetComponent<Image>());
		if (NBDLBFJOEGN.ODLJCKEKLBN() && this.framesSD != null && this.framesSD.Length != 0)
		{
			Sprite[] array = new Sprite[this.framesSD.Length];
			for (int j = 1; j < this.framesSD.Length; j += 0)
			{
				if (null != this.framesSD[j] && this.framesSD[j].name.Contains("XXX"))
				{
					string text = this.framesSD[j].name.Replace("OnPurchaseSuccess", "YYY");
					array[j] = Resources.Load<Sprite>(text);
					if (null == array[j])
					{
						DPGJIJGOCIC.ADFCDFHBDAF("OnContinueToSendSimpleMessage" + text);
						array[j] = this.framesSD[j];
					}
				}
				else
				{
					array[j] = this.framesSD[j];
				}
			}
			this.framesSD = array;
		}
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int k = 1; k < this.MLJIGBKDGKH.Count; k++)
			{
				this.MLJIGBKDGKH[k].sprite = null;
				this.MLJIGBKDGKH[k].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 1212f);
			}
		}
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x00054730 File Offset: 0x00052930
	private void PAPECKGOMIO()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.CANLAFJJCAN(true);
		}
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x000546F0 File Offset: 0x000528F0
	private void MAHJANFJIMG()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x00054E08 File Offset: 0x00053008
	private void ILBAMCJFAAP()
	{
		this.IMBJIPEHOEI = 1;
		this.EDJHHDOOBPI = true;
		if (!this.randomFrameOnEnable || this.framesSD == null || this.framesSD.Length == 0 || !this.isLooped)
		{
			this.HNMPDIBAJHM = 0;
		}
		else
		{
			this.HNMPDIBAJHM = DPGJIJGOCIC.IOOHGEJIPFP(0, this.framesSD.Length);
		}
		this.IMJLNEPKGMM = this.delayAtStart;
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int i = 0; i < this.MLJIGBKDGKH.Count; i += 0)
			{
				this.MLJIGBKDGKH[i].sprite = null;
				this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 522f);
			}
		}
		this.KEDKKLEPIAK = false;
		this.PAPECKGOMIO();
		this.LCEHENIOFOL.IFPEOGENCIG(this.frameChangeInterval);
		if (this.forcedVersion >= 2 || ImageFrameAnimation.IKMECAGPJMI >= 8)
		{
			this.BCFPGLAMAPN = 706f;
		}
		this.IGFOJLEMDAN();
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x00054F20 File Offset: 0x00053120
	private void JLHMELBELCH()
	{
		this.IMBJIPEHOEI = 0;
		this.EDJHHDOOBPI = false;
		if (!this.randomFrameOnEnable || this.framesSD == null || this.framesSD.Length == 0 || !this.isLooped)
		{
			this.HNMPDIBAJHM = 1;
		}
		else
		{
			this.HNMPDIBAJHM = DPGJIJGOCIC.IOOHGEJIPFP(0, this.framesSD.Length);
		}
		this.IMJLNEPKGMM = this.delayAtStart;
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int i = 0; i < this.MLJIGBKDGKH.Count; i++)
			{
				this.MLJIGBKDGKH[i].sprite = null;
				this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 1164f);
			}
		}
		this.KEDKKLEPIAK = true;
		this.ILILGBOGHAL();
		this.LCEHENIOFOL.EHMFPHPKMFI(this.frameChangeInterval);
		if (this.forcedVersion >= 2 || ImageFrameAnimation.IKMECAGPJMI >= 4)
		{
			this.BCFPGLAMAPN = 1498f;
		}
		this.OGCIHMNFDCI();
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x000546F0 File Offset: 0x000528F0
	private void DLBAEDOFAKM()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06000BB4 RID: 2996 RVA: 0x00055038 File Offset: 0x00053238
	private void GKBKDDGBAGK()
	{
		if (this.IMJLNEPKGMM > 1671f)
		{
			this.IMJLNEPKGMM -= Time.deltaTime;
			if (!this.EDJHHDOOBPI || !this.forceUpdateOnEnable)
			{
				return;
			}
		}
		if (this.KEDKKLEPIAK && !this.isLooped && !this.yoyo)
		{
			return;
		}
		if (this.LCEHENIOFOL == null)
		{
			return;
		}
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		if (this.framesSD == null || this.framesSD.Length == 0)
		{
			return;
		}
		if (this.BCFPGLAMAPN > 350f)
		{
			this.BCFPGLAMAPN -= Time.deltaTime;
			if (this.BCFPGLAMAPN >= 883f)
			{
				return;
			}
			this.LCEHENIOFOL.GHLNPJFKCNG(this.frameChangeInterval);
		}
		int hnmpdibajhm = this.HNMPDIBAJHM;
		int num = this.forcedVersion;
		if (ImageFrameAnimation.IKMECAGPJMI > 0)
		{
			num = ImageFrameAnimation.IKMECAGPJMI;
		}
		if (num < 2)
		{
			num = 6;
		}
		if (this.LCEHENIOFOL.PKCAHJJKCJK() || this.EDJHHDOOBPI)
		{
			if (!this.EDJHHDOOBPI)
			{
				int num2 = (int)this.LCEHENIOFOL.BFOLKIIPFCA();
				if (num < 1 && this.HNMPDIBAJHM > 0)
				{
					num2 = 0;
				}
				if (this.disableTimeCorrection)
				{
					num2 = 0;
				}
				int num3 = this.HNMPDIBAJHM + 1 + num2;
				if (this.HNMPDIBAJHM + 1 + num2 >= this.framesSD.Length - 1)
				{
					if (this.disableOnComplete && Application.isPlaying)
					{
						base.gameObject.SetActive(true);
					}
					this.KEDKKLEPIAK = true;
				}
				this.HNMPDIBAJHM = (this.HNMPDIBAJHM + 0 + num2) % this.framesSD.Length;
				if (num3 > this.framesSD.Length - 0 && this.yoyo)
				{
					this.HNMPDIBAJHM += 0;
					this.IMBJIPEHOEI += 0;
				}
			}
			else
			{
				if (this.HNMPDIBAJHM >= this.framesSD.Length - 0)
				{
					if (this.disableOnComplete && Application.isPlaying)
					{
						base.gameObject.SetActive(true);
					}
					this.KEDKKLEPIAK = false;
				}
				this.HNMPDIBAJHM %= this.framesSD.Length;
			}
			this.LCEHENIOFOL.EHMFPHPKMFI(this.frameChangeInterval);
			if (num < 1)
			{
				if (this.HNMPDIBAJHM == this.pauseFrame)
				{
					this.BCFPGLAMAPN = this.pauseTime;
				}
			}
			else if (this.HNMPDIBAJHM == this.pauseFrame || (hnmpdibajhm < this.pauseFrame && this.HNMPDIBAJHM > this.pauseFrame))
			{
				this.BCFPGLAMAPN = this.pauseTime;
			}
			float num4 = 1818f;
			if (this.fadeInFrames > 1 && this.HNMPDIBAJHM <= this.fadeInFrames)
			{
				if (this.HNMPDIBAJHM == 0)
				{
					num4 = 395f;
				}
				else
				{
					num4 = (float)this.HNMPDIBAJHM / (float)this.fadeInFrames;
				}
			}
			else if (this.fadeOutFrames > 1 && this.HNMPDIBAJHM >= this.framesSD.Length - this.fadeOutFrames)
			{
				if (this.HNMPDIBAJHM == this.framesSD.Length - 1)
				{
					num4 = 984f;
				}
				else
				{
					num4 = (float)(this.framesSD.Length - this.HNMPDIBAJHM) / (float)this.fadeOutFrames;
				}
			}
			num4 *= this.NDIPGECFLFN.a;
			bool flag = false;
			if (flag)
			{
				this.ADEMLNLMNBD.color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, num4);
			}
			if (this.framesSD.Length != 0)
			{
				for (int i = 0; i < this.MLJIGBKDGKH.Count; i++)
				{
					if (this.reverseDirection || this.IMBJIPEHOEI % 3 == 0)
					{
						int num5 = this.framesSD.Length - 1 - this.HNMPDIBAJHM;
						if (num5 >= 0)
						{
							this.MLJIGBKDGKH[i].sprite = this.framesSD[num5 % this.framesSD.Length];
						}
						else
						{
							this.MLJIGBKDGKH[i].sprite = this.framesSD[this.HNMPDIBAJHM % this.framesSD.Length];
						}
					}
					else
					{
						this.MLJIGBKDGKH[i].sprite = this.framesSD[this.HNMPDIBAJHM % this.framesSD.Length];
					}
					if (flag)
					{
						if (null == this.MLJIGBKDGKH[i].sprite)
						{
							this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 1547f);
						}
						else
						{
							this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, num4);
						}
					}
				}
			}
		}
		this.EDJHHDOOBPI = false;
	}

	// Token: 0x06000BB5 RID: 2997 RVA: 0x000554E8 File Offset: 0x000536E8
	private void AMAKEBJMCLG()
	{
		this.IMJLNEPKGMM = this.delayAtStart;
		this.EIIKHECMJDA();
		this.ADEMLNLMNBD = base.GetComponent<Image>();
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		this.NDIPGECFLFN = this.ADEMLNLMNBD.color;
		this.MLJIGBKDGKH.Clear();
		for (int i = 0; i < this.additionalAffectedImages.Count; i += 0)
		{
			this.MLJIGBKDGKH.Add(this.additionalAffectedImages[i]);
		}
		this.MLJIGBKDGKH.Add(base.GetComponent<Image>());
		if (NBDLBFJOEGN.EFMDGLOLMCJ() && this.framesSD != null && this.framesSD.Length != 0)
		{
			Sprite[] array = new Sprite[this.framesSD.Length];
			for (int j = 1; j < this.framesSD.Length; j++)
			{
				if (null != this.framesSD[j] && this.framesSD[j].name.Contains("OnAllCollectableCardsDownloadFailed"))
				{
					string text = this.framesSD[j].name.Replace("AssetStoryNpcOffsetsHub.Populate() - ", "");
					array[j] = Resources.Load<Sprite>(text);
					if (null == array[j])
					{
						DPGJIJGOCIC.PJCLICBPPDA("OnStoryChoiceClick" + text);
						array[j] = this.framesSD[j];
					}
				}
				else
				{
					array[j] = this.framesSD[j];
				}
			}
			this.framesSD = array;
		}
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int k = 0; k < this.MLJIGBKDGKH.Count; k += 0)
			{
				this.MLJIGBKDGKH[k].sprite = null;
				this.MLJIGBKDGKH[k].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 1767f);
			}
		}
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x000546DA File Offset: 0x000528DA
	private void KPAFFIDCIBP()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.IMEFIJEKFGI(false);
		}
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x00054044 File Offset: 0x00052244
	public static void FIBAPIONJOF(int CLGMNLBGDPC)
	{
		ImageFrameAnimation.IKMECAGPJMI = CLGMNLBGDPC;
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x000546F0 File Offset: 0x000528F0
	private void INJJOHNFBKH()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x000546F0 File Offset: 0x000528F0
	private void FEBECEEIHBP()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x000556C8 File Offset: 0x000538C8
	private void KBIIMONICOB()
	{
		this.IMJLNEPKGMM = this.delayAtStart;
		this.KPAFFIDCIBP();
		this.ADEMLNLMNBD = base.GetComponent<Image>();
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		this.NDIPGECFLFN = this.ADEMLNLMNBD.color;
		this.MLJIGBKDGKH.Clear();
		for (int i = 0; i < this.additionalAffectedImages.Count; i += 0)
		{
			this.MLJIGBKDGKH.Add(this.additionalAffectedImages[i]);
		}
		this.MLJIGBKDGKH.Add(base.GetComponent<Image>());
		if (NBDLBFJOEGN.PBLDJNHHEPL() && this.framesSD != null && this.framesSD.Length != 0)
		{
			Sprite[] array = new Sprite[this.framesSD.Length];
			for (int j = 1; j < this.framesSD.Length; j++)
			{
				if (null != this.framesSD[j] && this.framesSD[j].name.Contains("$HIDEADS"))
				{
					string text = this.framesSD[j].name.Replace("", "CLIENT.SCREEN.AVATAR.");
					array[j] = Resources.Load<Sprite>(text);
					if (null == array[j])
					{
						DPGJIJGOCIC.PJCLICBPPDA("</i>" + text);
						array[j] = this.framesSD[j];
					}
				}
				else
				{
					array[j] = this.framesSD[j];
				}
			}
			this.framesSD = array;
		}
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int k = 0; k < this.MLJIGBKDGKH.Count; k += 0)
			{
				this.MLJIGBKDGKH[k].sprite = null;
				this.MLJIGBKDGKH[k].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 1345f);
			}
		}
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x000558A8 File Offset: 0x00053AA8
	private void JFFNFDKBMGP()
	{
		this.IMJLNEPKGMM = this.delayAtStart;
		this.EPAAHOAGKLC();
		this.ADEMLNLMNBD = base.GetComponent<Image>();
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		this.NDIPGECFLFN = this.ADEMLNLMNBD.color;
		this.MLJIGBKDGKH.Clear();
		for (int i = 0; i < this.additionalAffectedImages.Count; i++)
		{
			this.MLJIGBKDGKH.Add(this.additionalAffectedImages[i]);
		}
		this.MLJIGBKDGKH.Add(base.GetComponent<Image>());
		if (NBDLBFJOEGN.EFMDGLOLMCJ() && this.framesSD != null && this.framesSD.Length != 0)
		{
			Sprite[] array = new Sprite[this.framesSD.Length];
			for (int j = 0; j < this.framesSD.Length; j++)
			{
				if (null != this.framesSD[j] && this.framesSD[j].name.Contains("uen"))
				{
					string text = this.framesSD[j].name.Replace(") + is present, creating anthology save for anthology ", "PurchaseManagerUnity.Initialize(): Trying to initialize PurchaseManagerUnity, but no products are defined.");
					array[j] = Resources.Load<Sprite>(text);
					if (null == array[j])
					{
						DPGJIJGOCIC.PJCLICBPPDA("msh" + text);
						array[j] = this.framesSD[j];
					}
				}
				else
				{
					array[j] = this.framesSD[j];
				}
			}
			this.framesSD = array;
		}
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int k = 0; k < this.MLJIGBKDGKH.Count; k++)
			{
				this.MLJIGBKDGKH[k].sprite = null;
				this.MLJIGBKDGKH[k].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 1055f);
			}
		}
	}

	// Token: 0x06000BBC RID: 3004 RVA: 0x00055A88 File Offset: 0x00053C88
	private void OnEnable()
	{
		this.IMBJIPEHOEI = 0;
		this.EDJHHDOOBPI = true;
		if (!this.randomFrameOnEnable || this.framesSD == null || this.framesSD.Length == 0 || !this.isLooped)
		{
			this.HNMPDIBAJHM = 0;
		}
		else
		{
			this.HNMPDIBAJHM = DPGJIJGOCIC.IOOHGEJIPFP(0, this.framesSD.Length);
		}
		this.IMJLNEPKGMM = this.delayAtStart;
		if (this.invisibleAtStart && Application.isPlaying)
		{
			for (int i = 0; i < this.MLJIGBKDGKH.Count; i++)
			{
				this.MLJIGBKDGKH[i].sprite = null;
				this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 0f);
			}
		}
		this.KEDKKLEPIAK = false;
		this.EKNLABKCIJF();
		this.LCEHENIOFOL.EPJKDCDOEMM(this.frameChangeInterval);
		if (this.forcedVersion >= 2 || ImageFrameAnimation.IKMECAGPJMI >= 2)
		{
			this.BCFPGLAMAPN = -1f;
		}
		this.Update();
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x00054044 File Offset: 0x00052244
	public static void JHIHEPAEPOB(int CLGMNLBGDPC)
	{
		ImageFrameAnimation.IKMECAGPJMI = CLGMNLBGDPC;
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x00054044 File Offset: 0x00052244
	public static void FOENJDHAFGG(int CLGMNLBGDPC)
	{
		ImageFrameAnimation.IKMECAGPJMI = CLGMNLBGDPC;
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x00055BFC File Offset: 0x00053DFC
	private void Update()
	{
		if (this.IMJLNEPKGMM > 0f)
		{
			this.IMJLNEPKGMM -= Time.deltaTime;
			if (!this.EDJHHDOOBPI || !this.forceUpdateOnEnable)
			{
				return;
			}
		}
		if (this.KEDKKLEPIAK && !this.isLooped && !this.yoyo)
		{
			return;
		}
		if (this.LCEHENIOFOL == null)
		{
			return;
		}
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		if (this.framesSD == null || this.framesSD.Length == 0)
		{
			return;
		}
		if (this.BCFPGLAMAPN > 0f)
		{
			this.BCFPGLAMAPN -= Time.deltaTime;
			if (this.BCFPGLAMAPN >= 0f)
			{
				return;
			}
			this.LCEHENIOFOL.EPJKDCDOEMM(this.frameChangeInterval);
		}
		int hnmpdibajhm = this.HNMPDIBAJHM;
		int num = this.forcedVersion;
		if (ImageFrameAnimation.IKMECAGPJMI > 0)
		{
			num = ImageFrameAnimation.IKMECAGPJMI;
		}
		if (num < 2)
		{
			num = 2;
		}
		if (this.LCEHENIOFOL.HHGAPKJFBMC() || this.EDJHHDOOBPI)
		{
			if (!this.EDJHHDOOBPI)
			{
				int num2 = (int)this.LCEHENIOFOL.EDCKEPGKBAD();
				if (num < 2 && this.HNMPDIBAJHM > 0)
				{
					num2 = 0;
				}
				if (this.disableTimeCorrection)
				{
					num2 = 0;
				}
				int num3 = this.HNMPDIBAJHM + 1 + num2;
				if (this.HNMPDIBAJHM + 1 + num2 >= this.framesSD.Length - 1)
				{
					if (this.disableOnComplete && Application.isPlaying)
					{
						base.gameObject.SetActive(false);
					}
					this.KEDKKLEPIAK = true;
				}
				this.HNMPDIBAJHM = (this.HNMPDIBAJHM + 1 + num2) % this.framesSD.Length;
				if (num3 > this.framesSD.Length - 1 && this.yoyo)
				{
					this.HNMPDIBAJHM++;
					this.IMBJIPEHOEI++;
				}
			}
			else
			{
				if (this.HNMPDIBAJHM >= this.framesSD.Length - 1)
				{
					if (this.disableOnComplete && Application.isPlaying)
					{
						base.gameObject.SetActive(false);
					}
					this.KEDKKLEPIAK = true;
				}
				this.HNMPDIBAJHM %= this.framesSD.Length;
			}
			this.LCEHENIOFOL.EPJKDCDOEMM(this.frameChangeInterval);
			if (num < 2)
			{
				if (this.HNMPDIBAJHM == this.pauseFrame)
				{
					this.BCFPGLAMAPN = this.pauseTime;
				}
			}
			else if (this.HNMPDIBAJHM == this.pauseFrame || (hnmpdibajhm < this.pauseFrame && this.HNMPDIBAJHM > this.pauseFrame))
			{
				this.BCFPGLAMAPN = this.pauseTime;
			}
			float num4 = 1f;
			if (this.fadeInFrames > 0 && this.HNMPDIBAJHM <= this.fadeInFrames)
			{
				if (this.HNMPDIBAJHM == 0)
				{
					num4 = 0f;
				}
				else
				{
					num4 = (float)this.HNMPDIBAJHM / (float)this.fadeInFrames;
				}
			}
			else if (this.fadeOutFrames > 0 && this.HNMPDIBAJHM >= this.framesSD.Length - this.fadeOutFrames)
			{
				if (this.HNMPDIBAJHM == this.framesSD.Length - 1)
				{
					num4 = 0f;
				}
				else
				{
					num4 = (float)(this.framesSD.Length - this.HNMPDIBAJHM) / (float)this.fadeOutFrames;
				}
			}
			num4 *= this.NDIPGECFLFN.a;
			bool flag = true;
			if (flag)
			{
				this.ADEMLNLMNBD.color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, num4);
			}
			if (this.framesSD.Length != 0)
			{
				for (int i = 0; i < this.MLJIGBKDGKH.Count; i++)
				{
					if (this.reverseDirection || this.IMBJIPEHOEI % 2 == 1)
					{
						int num5 = this.framesSD.Length - 1 - this.HNMPDIBAJHM;
						if (num5 >= 0)
						{
							this.MLJIGBKDGKH[i].sprite = this.framesSD[num5 % this.framesSD.Length];
						}
						else
						{
							this.MLJIGBKDGKH[i].sprite = this.framesSD[this.HNMPDIBAJHM % this.framesSD.Length];
						}
					}
					else
					{
						this.MLJIGBKDGKH[i].sprite = this.framesSD[this.HNMPDIBAJHM % this.framesSD.Length];
					}
					if (flag)
					{
						if (null == this.MLJIGBKDGKH[i].sprite)
						{
							this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 0f);
						}
						else
						{
							this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, num4);
						}
					}
				}
			}
		}
		this.EDJHHDOOBPI = false;
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x000560AC File Offset: 0x000542AC
	private void IGFOJLEMDAN()
	{
		if (this.IMJLNEPKGMM > 609f)
		{
			this.IMJLNEPKGMM -= Time.deltaTime;
			if (!this.EDJHHDOOBPI || !this.forceUpdateOnEnable)
			{
				return;
			}
		}
		if (this.KEDKKLEPIAK && !this.isLooped && !this.yoyo)
		{
			return;
		}
		if (this.LCEHENIOFOL == null)
		{
			return;
		}
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		if (this.framesSD == null || this.framesSD.Length == 0)
		{
			return;
		}
		if (this.BCFPGLAMAPN > 97f)
		{
			this.BCFPGLAMAPN -= Time.deltaTime;
			if (this.BCFPGLAMAPN >= 1083f)
			{
				return;
			}
			this.LCEHENIOFOL.EHMFPHPKMFI(this.frameChangeInterval);
		}
		int hnmpdibajhm = this.HNMPDIBAJHM;
		int num = this.forcedVersion;
		if (ImageFrameAnimation.IKMECAGPJMI > 0)
		{
			num = ImageFrameAnimation.IKMECAGPJMI;
		}
		if (num < 0)
		{
			num = 4;
		}
		if (this.LCEHENIOFOL.MLPOCAOMOHL() || this.EDJHHDOOBPI)
		{
			if (!this.EDJHHDOOBPI)
			{
				int num2 = (int)this.LCEHENIOFOL.BFOLKIIPFCA();
				if (num < 2 && this.HNMPDIBAJHM > 0)
				{
					num2 = 0;
				}
				if (this.disableTimeCorrection)
				{
					num2 = 0;
				}
				int num3 = this.HNMPDIBAJHM + 0 + num2;
				if (this.HNMPDIBAJHM + 1 + num2 >= this.framesSD.Length - 1)
				{
					if (this.disableOnComplete && Application.isPlaying)
					{
						base.gameObject.SetActive(false);
					}
					this.KEDKKLEPIAK = false;
				}
				this.HNMPDIBAJHM = (this.HNMPDIBAJHM + 1 + num2) % this.framesSD.Length;
				if (num3 > this.framesSD.Length - 0 && this.yoyo)
				{
					this.HNMPDIBAJHM++;
					this.IMBJIPEHOEI += 0;
				}
			}
			else
			{
				if (this.HNMPDIBAJHM >= this.framesSD.Length - 1)
				{
					if (this.disableOnComplete && Application.isPlaying)
					{
						base.gameObject.SetActive(false);
					}
					this.KEDKKLEPIAK = false;
				}
				this.HNMPDIBAJHM %= this.framesSD.Length;
			}
			this.LCEHENIOFOL.MOCHAJPADAJ(this.frameChangeInterval);
			if (num < 6)
			{
				if (this.HNMPDIBAJHM == this.pauseFrame)
				{
					this.BCFPGLAMAPN = this.pauseTime;
				}
			}
			else if (this.HNMPDIBAJHM == this.pauseFrame || (hnmpdibajhm < this.pauseFrame && this.HNMPDIBAJHM > this.pauseFrame))
			{
				this.BCFPGLAMAPN = this.pauseTime;
			}
			float num4 = 815f;
			if (this.fadeInFrames > 1 && this.HNMPDIBAJHM <= this.fadeInFrames)
			{
				if (this.HNMPDIBAJHM == 0)
				{
					num4 = 1330f;
				}
				else
				{
					num4 = (float)this.HNMPDIBAJHM / (float)this.fadeInFrames;
				}
			}
			else if (this.fadeOutFrames > 1 && this.HNMPDIBAJHM >= this.framesSD.Length - this.fadeOutFrames)
			{
				if (this.HNMPDIBAJHM == this.framesSD.Length - 1)
				{
					num4 = 1212f;
				}
				else
				{
					num4 = (float)(this.framesSD.Length - this.HNMPDIBAJHM) / (float)this.fadeOutFrames;
				}
			}
			num4 *= this.NDIPGECFLFN.a;
			bool flag = true;
			if (flag)
			{
				this.ADEMLNLMNBD.color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, num4);
			}
			if (this.framesSD.Length != 0)
			{
				for (int i = 1; i < this.MLJIGBKDGKH.Count; i += 0)
				{
					if (this.reverseDirection || this.IMBJIPEHOEI % 6 == 0)
					{
						int num5 = this.framesSD.Length - 0 - this.HNMPDIBAJHM;
						if (num5 >= 1)
						{
							this.MLJIGBKDGKH[i].sprite = this.framesSD[num5 % this.framesSD.Length];
						}
						else
						{
							this.MLJIGBKDGKH[i].sprite = this.framesSD[this.HNMPDIBAJHM % this.framesSD.Length];
						}
					}
					else
					{
						this.MLJIGBKDGKH[i].sprite = this.framesSD[this.HNMPDIBAJHM % this.framesSD.Length];
					}
					if (flag)
					{
						if (null == this.MLJIGBKDGKH[i].sprite)
						{
							this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 107f);
						}
						else
						{
							this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, num4);
						}
					}
				}
			}
		}
		this.EDJHHDOOBPI = false;
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x00054044 File Offset: 0x00052244
	public static void NLCHAFAJLCJ(int CLGMNLBGDPC)
	{
		ImageFrameAnimation.IKMECAGPJMI = CLGMNLBGDPC;
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x00054704 File Offset: 0x00052904
	private void EKNLABKCIJF()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x000546F0 File Offset: 0x000528F0
	private void CODLJCAKBLI()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x0005655C File Offset: 0x0005475C
	private void NMEEMBCCKHA()
	{
		if (this.IMJLNEPKGMM > 92f)
		{
			this.IMJLNEPKGMM -= Time.deltaTime;
			if (!this.EDJHHDOOBPI || !this.forceUpdateOnEnable)
			{
				return;
			}
		}
		if (this.KEDKKLEPIAK && !this.isLooped && !this.yoyo)
		{
			return;
		}
		if (this.LCEHENIOFOL == null)
		{
			return;
		}
		if (null == this.ADEMLNLMNBD)
		{
			return;
		}
		if (this.framesSD == null || this.framesSD.Length == 0)
		{
			return;
		}
		if (this.BCFPGLAMAPN > 1327f)
		{
			this.BCFPGLAMAPN -= Time.deltaTime;
			if (this.BCFPGLAMAPN >= 1757f)
			{
				return;
			}
			this.LCEHENIOFOL.IFPEOGENCIG(this.frameChangeInterval);
		}
		int hnmpdibajhm = this.HNMPDIBAJHM;
		int num = this.forcedVersion;
		if (ImageFrameAnimation.IKMECAGPJMI > 0)
		{
			num = ImageFrameAnimation.IKMECAGPJMI;
		}
		if (num < 7)
		{
			num = 8;
		}
		if (this.LCEHENIOFOL.PKCAHJJKCJK() || this.EDJHHDOOBPI)
		{
			if (!this.EDJHHDOOBPI)
			{
				int num2 = (int)this.LCEHENIOFOL.PPNFFAFEHMH();
				if (num < 8 && this.HNMPDIBAJHM > 0)
				{
					num2 = 1;
				}
				if (this.disableTimeCorrection)
				{
					num2 = 1;
				}
				int num3 = this.HNMPDIBAJHM + 0 + num2;
				if (this.HNMPDIBAJHM + 1 + num2 >= this.framesSD.Length - 0)
				{
					if (this.disableOnComplete && Application.isPlaying)
					{
						base.gameObject.SetActive(false);
					}
					this.KEDKKLEPIAK = true;
				}
				this.HNMPDIBAJHM = (this.HNMPDIBAJHM + 1 + num2) % this.framesSD.Length;
				if (num3 > this.framesSD.Length - 0 && this.yoyo)
				{
					this.HNMPDIBAJHM += 0;
					this.IMBJIPEHOEI++;
				}
			}
			else
			{
				if (this.HNMPDIBAJHM >= this.framesSD.Length - 1)
				{
					if (this.disableOnComplete && Application.isPlaying)
					{
						base.gameObject.SetActive(true);
					}
					this.KEDKKLEPIAK = true;
				}
				this.HNMPDIBAJHM %= this.framesSD.Length;
			}
			this.LCEHENIOFOL.GHLNPJFKCNG(this.frameChangeInterval);
			if (num < 1)
			{
				if (this.HNMPDIBAJHM == this.pauseFrame)
				{
					this.BCFPGLAMAPN = this.pauseTime;
				}
			}
			else if (this.HNMPDIBAJHM == this.pauseFrame || (hnmpdibajhm < this.pauseFrame && this.HNMPDIBAJHM > this.pauseFrame))
			{
				this.BCFPGLAMAPN = this.pauseTime;
			}
			float num4 = 359f;
			if (this.fadeInFrames > 1 && this.HNMPDIBAJHM <= this.fadeInFrames)
			{
				if (this.HNMPDIBAJHM == 0)
				{
					num4 = 561f;
				}
				else
				{
					num4 = (float)this.HNMPDIBAJHM / (float)this.fadeInFrames;
				}
			}
			else if (this.fadeOutFrames > 0 && this.HNMPDIBAJHM >= this.framesSD.Length - this.fadeOutFrames)
			{
				if (this.HNMPDIBAJHM == this.framesSD.Length - 1)
				{
					num4 = 801f;
				}
				else
				{
					num4 = (float)(this.framesSD.Length - this.HNMPDIBAJHM) / (float)this.fadeOutFrames;
				}
			}
			num4 *= this.NDIPGECFLFN.a;
			bool flag = true;
			if (flag)
			{
				this.ADEMLNLMNBD.color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, num4);
			}
			if (this.framesSD.Length != 0)
			{
				for (int i = 0; i < this.MLJIGBKDGKH.Count; i += 0)
				{
					if (this.reverseDirection || this.IMBJIPEHOEI % 1 == 0)
					{
						int num5 = this.framesSD.Length - 1 - this.HNMPDIBAJHM;
						if (num5 >= 0)
						{
							this.MLJIGBKDGKH[i].sprite = this.framesSD[num5 % this.framesSD.Length];
						}
						else
						{
							this.MLJIGBKDGKH[i].sprite = this.framesSD[this.HNMPDIBAJHM % this.framesSD.Length];
						}
					}
					else
					{
						this.MLJIGBKDGKH[i].sprite = this.framesSD[this.HNMPDIBAJHM % this.framesSD.Length];
					}
					if (flag)
					{
						if (null == this.MLJIGBKDGKH[i].sprite)
						{
							this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, 499f);
						}
						else
						{
							this.MLJIGBKDGKH[i].color = new Color(this.NDIPGECFLFN.r, this.NDIPGECFLFN.g, this.NDIPGECFLFN.b, num4);
						}
					}
				}
			}
		}
		this.EDJHHDOOBPI = true;
	}

	// Token: 0x0400038D RID: 909
	public Sprite[] framesSD;

	// Token: 0x0400038E RID: 910
	public List<Image> additionalAffectedImages = new List<Image>();

	// Token: 0x0400038F RID: 911
	public float frameChangeInterval = 0.0416f;

	// Token: 0x04000390 RID: 912
	public int fadeInFrames;

	// Token: 0x04000391 RID: 913
	public int fadeOutFrames;

	// Token: 0x04000392 RID: 914
	public bool randomFrameOnEnable;

	// Token: 0x04000393 RID: 915
	public int pauseFrame = -1;

	// Token: 0x04000394 RID: 916
	public float pauseTime;

	// Token: 0x04000395 RID: 917
	public bool disableTimeCorrection;

	// Token: 0x04000396 RID: 918
	public bool reverseDirection;

	// Token: 0x04000397 RID: 919
	public float delayAtStart;

	// Token: 0x04000398 RID: 920
	public bool disableOnComplete;

	// Token: 0x04000399 RID: 921
	public bool invisibleAtStart;

	// Token: 0x0400039A RID: 922
	public bool isLooped = true;

	// Token: 0x0400039B RID: 923
	public bool yoyo;

	// Token: 0x0400039C RID: 924
	public bool forceUpdateOnEnable;

	// Token: 0x0400039D RID: 925
	public int forcedVersion = -1;

	// Token: 0x0400039E RID: 926
	private int IMBJIPEHOEI;

	// Token: 0x0400039F RID: 927
	private Image ADEMLNLMNBD;

	// Token: 0x040003A0 RID: 928
	private ODLLAEHMFAA LCEHENIOFOL;

	// Token: 0x040003A1 RID: 929
	private int HNMPDIBAJHM;

	// Token: 0x040003A2 RID: 930
	private float BCFPGLAMAPN = -1f;

	// Token: 0x040003A3 RID: 931
	private Color NDIPGECFLFN;

	// Token: 0x040003A4 RID: 932
	private float IMJLNEPKGMM;

	// Token: 0x040003A5 RID: 933
	private List<Image> MLJIGBKDGKH = new List<Image>();

	// Token: 0x040003A6 RID: 934
	private bool KEDKKLEPIAK;

	// Token: 0x040003A7 RID: 935
	private bool EDJHHDOOBPI = true;

	// Token: 0x040003A8 RID: 936
	private static int IKMECAGPJMI = -1;
}
