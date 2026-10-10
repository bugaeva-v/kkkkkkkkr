using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002D7 RID: 727
public class ChoiceStandardManager : MonoBehaviour
{
	// Token: 0x06005955 RID: 22869 RVA: 0x00283E2D File Offset: 0x0028202D
	public void DDKJPHFHKCC()
	{
		base.StartCoroutine(this.LPGOCMIBNIK());
	}

	// Token: 0x06005956 RID: 22870 RVA: 0x00283E3C File Offset: 0x0028203C
	public void DDPIOJOFLAN(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x06005957 RID: 22871 RVA: 0x00003E52 File Offset: 0x00002052
	private void MFPBKLMBANF()
	{
	}

	// Token: 0x06005958 RID: 22872 RVA: 0x00283E64 File Offset: 0x00282064
	private void IAKKINHMFNA()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005959 RID: 22873 RVA: 0x00283EAC File Offset: 0x002820AC
	public void GLIFGDPDMNC(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x0600595A RID: 22874 RVA: 0x00283ED1 File Offset: 0x002820D1
	public void MEFLCGFOEFJ()
	{
		base.StartCoroutine(this.CCGNBBBAHEG());
	}

	// Token: 0x0600595B RID: 22875 RVA: 0x00283E3C File Offset: 0x0028203C
	public void Initialize(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x0600595C RID: 22876 RVA: 0x00283EE0 File Offset: 0x002820E0
	private IEnumerator INDLHLKMAKP()
	{
		ChoiceStandardManager.HOKDMIOCKBM hokdmiockbm = new ChoiceStandardManager.HOKDMIOCKBM(1);
		hokdmiockbm.<>4__this = this;
		return hokdmiockbm;
	}

	// Token: 0x0600595D RID: 22877 RVA: 0x00283EEF File Offset: 0x002820EF
	public void CEDPFLEAAPK(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, false);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x0600595E RID: 22878 RVA: 0x00283E3C File Offset: 0x0028203C
	public void HDAHPNAHNJC(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x0600595F RID: 22879 RVA: 0x00003E52 File Offset: 0x00002052
	private void FNNKDFGKAEH()
	{
	}

	// Token: 0x06005960 RID: 22880 RVA: 0x00283F14 File Offset: 0x00282114
	public void ILEMJJCLCOL()
	{
		base.StartCoroutine(this.ELDNOELPILB());
	}

	// Token: 0x06005961 RID: 22881 RVA: 0x00283F24 File Offset: 0x00282124
	private void CDHHGBKGGDG()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005962 RID: 22882 RVA: 0x00283F6C File Offset: 0x0028216C
	private void Awake()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005963 RID: 22883 RVA: 0x00283FB4 File Offset: 0x002821B4
	public void MBMFLGKLEJI(OCCBADNHFHK MPBHHDFCDMA, int DDMMDDFIALL = -1)
	{
		string text = MPBHHDFCDMA.EJMOPGHOEFH();
		text = ONEHEBIHPFB.DEOJEIEJGEE(text);
		this.choiceText.SetText(text, true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005964 RID: 22884 RVA: 0x00284088 File Offset: 0x00282288
	private void KDNKCFGANFN()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005965 RID: 22885 RVA: 0x002840D0 File Offset: 0x002822D0
	public void FFEDFDKAEHC(OCCBADNHFHK MPBHHDFCDMA, int DDMMDDFIALL = -1)
	{
		string text = MPBHHDFCDMA.EIBPPDENAIO();
		text = ONEHEBIHPFB.LCKCKFDDDLC(text);
		this.choiceText.SetText(text, true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005966 RID: 22886 RVA: 0x00003E52 File Offset: 0x00002052
	private void BLEFIJPAJMJ()
	{
	}

	// Token: 0x06005967 RID: 22887 RVA: 0x002841A4 File Offset: 0x002823A4
	public void FLMCDJHOAMD()
	{
		base.StartCoroutine(this.EJJCOPLBBKO());
	}

	// Token: 0x06005968 RID: 22888 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06005969 RID: 22889 RVA: 0x00283E3C File Offset: 0x0028203C
	public void OFOAFPKPIKC(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x0600596A RID: 22890 RVA: 0x00003E52 File Offset: 0x00002052
	private void KFKPGJOMIOL()
	{
	}

	// Token: 0x0600596B RID: 22891 RVA: 0x002841B4 File Offset: 0x002823B4
	private void MFKEKAKPJEG()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x0600596C RID: 22892 RVA: 0x002841FC File Offset: 0x002823FC
	private IEnumerator CAMPKFKCABE()
	{
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield break;
	}

	// Token: 0x0600596D RID: 22893 RVA: 0x0028420B File Offset: 0x0028240B
	public void DEPDIJAKMHM()
	{
		base.StartCoroutine(this.CAMPKFKCABE());
	}

	// Token: 0x0600596E RID: 22894 RVA: 0x00283EEF File Offset: 0x002820EF
	public void KMDKBPNAKOG(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, false);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x0600596F RID: 22895 RVA: 0x0028421C File Offset: 0x0028241C
	private void ECDLFGCLAGG()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005970 RID: 22896 RVA: 0x00284264 File Offset: 0x00282464
	public void DGAFAPKAKIA(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x06005971 RID: 22897 RVA: 0x002841A4 File Offset: 0x002823A4
	public void FLENJNDMPGG()
	{
		base.StartCoroutine(this.EJJCOPLBBKO());
	}

	// Token: 0x06005972 RID: 22898 RVA: 0x0028428C File Offset: 0x0028248C
	public void DOFLEONDCMI(OCCBADNHFHK MPBHHDFCDMA, int DDMMDDFIALL = -1)
	{
		string text = MPBHHDFCDMA.FNODAEJLGFH();
		text = ONEHEBIHPFB.NCAMNNEOGKG(text);
		this.choiceText.SetText(text, false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005973 RID: 22899 RVA: 0x00284360 File Offset: 0x00282560
	private void OJGELECJGJC()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005974 RID: 22900 RVA: 0x00283E3C File Offset: 0x0028203C
	public void OCOOJNFJJPG(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x06005975 RID: 22901 RVA: 0x00283EE0 File Offset: 0x002820E0
	private IEnumerator GICJMBCMPKD()
	{
		ChoiceStandardManager.HOKDMIOCKBM hokdmiockbm = new ChoiceStandardManager.HOKDMIOCKBM(1);
		hokdmiockbm.<>4__this = this;
		return hokdmiockbm;
	}

	// Token: 0x06005976 RID: 22902 RVA: 0x002843A8 File Offset: 0x002825A8
	public void NNNKIPGJMMF(OCCBADNHFHK MPBHHDFCDMA, int DDMMDDFIALL = -1)
	{
		string text = MPBHHDFCDMA.MIJAJDJBJPO();
		text = ONEHEBIHPFB.LCKCKFDDDLC(text);
		this.choiceText.SetText(text, true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005977 RID: 22903 RVA: 0x0028447C File Offset: 0x0028267C
	private void DFEDGLDNOBH()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005978 RID: 22904 RVA: 0x002844C4 File Offset: 0x002826C4
	private void KLGLFKMIAPP()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005979 RID: 22905 RVA: 0x002841FC File Offset: 0x002823FC
	private IEnumerator DKFAAJHPFAN()
	{
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield break;
	}

	// Token: 0x0600597A RID: 22906 RVA: 0x002841FC File Offset: 0x002823FC
	private IEnumerator EOLNPEFCCFD()
	{
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield break;
	}

	// Token: 0x0600597B RID: 22907 RVA: 0x002841FC File Offset: 0x002823FC
	private IEnumerator BNOMOAEAKLE()
	{
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield break;
	}

	// Token: 0x0600597C RID: 22908 RVA: 0x0028450C File Offset: 0x0028270C
	private void LKAJODOFNHF()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x0600597D RID: 22909 RVA: 0x00284554 File Offset: 0x00282754
	public void Initialize(OCCBADNHFHK MPBHHDFCDMA, int DDMMDDFIALL = -1)
	{
		string text = MPBHHDFCDMA.LONDJHFBEFM();
		text = ONEHEBIHPFB.LMDACNKELEC(text);
		this.choiceText.SetText(text, true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(false);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600597F RID: 22911 RVA: 0x00284628 File Offset: 0x00282828
	private void OPBNOGLBNDK()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005980 RID: 22912 RVA: 0x00284670 File Offset: 0x00282870
	private void MDNEOMGLGIN()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005981 RID: 22913 RVA: 0x00284264 File Offset: 0x00282464
	public void MHHLOIKMJGD(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x06005982 RID: 22914 RVA: 0x002846B8 File Offset: 0x002828B8
	private void IJIDLNOIHCD()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005983 RID: 22915 RVA: 0x00284700 File Offset: 0x00282900
	public void HBBFAAOICDH(OCCBADNHFHK MPBHHDFCDMA, int DDMMDDFIALL = -1)
	{
		string text = MPBHHDFCDMA.JMMOOHPPNGH();
		text = ONEHEBIHPFB.DEOJEIEJGEE(text);
		this.choiceText.SetText(text, true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 1)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005984 RID: 22916 RVA: 0x002841FC File Offset: 0x002823FC
	private IEnumerator KDBMFBALDHP()
	{
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield break;
	}

	// Token: 0x06005985 RID: 22917 RVA: 0x002847D4 File Offset: 0x002829D4
	private void KGEINIJLFMI()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005986 RID: 22918 RVA: 0x0028481C File Offset: 0x00282A1C
	public void PHIPFAKNBPM()
	{
		base.StartCoroutine(this.DKFAAJHPFAN());
	}

	// Token: 0x06005987 RID: 22919 RVA: 0x0028482C File Offset: 0x00282A2C
	public void DFFMNJDFNJG(OCCBADNHFHK MPBHHDFCDMA, int DDMMDDFIALL = -1)
	{
		string text = MPBHHDFCDMA.LKPPPKODJEO();
		text = ONEHEBIHPFB.DEOJEIEJGEE(text);
		this.choiceText.SetText(text, true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 1; i < this.hints.Count; i += 0)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 1 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005988 RID: 22920 RVA: 0x002841FC File Offset: 0x002823FC
	private IEnumerator PNMOAPCLHGJ()
	{
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield break;
	}

	// Token: 0x06005989 RID: 22921 RVA: 0x00284900 File Offset: 0x00282B00
	public void ShowAutoChoiceAnimation()
	{
		base.StartCoroutine(this.LEDHDKHHPJP());
	}

	// Token: 0x0600598A RID: 22922 RVA: 0x00283EE0 File Offset: 0x002820E0
	private IEnumerator EJJCOPLBBKO()
	{
		ChoiceStandardManager.HOKDMIOCKBM hokdmiockbm = new ChoiceStandardManager.HOKDMIOCKBM(1);
		hokdmiockbm.<>4__this = this;
		return hokdmiockbm;
	}

	// Token: 0x0600598B RID: 22923 RVA: 0x002841FC File Offset: 0x002823FC
	private IEnumerator ELDNOELPILB()
	{
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield break;
	}

	// Token: 0x0600598C RID: 22924 RVA: 0x0028481C File Offset: 0x00282A1C
	public void DIMECNNCJDN()
	{
		base.StartCoroutine(this.DKFAAJHPFAN());
	}

	// Token: 0x0600598D RID: 22925 RVA: 0x0028490F File Offset: 0x00282B0F
	public void LENECOAEHEC()
	{
		base.StartCoroutine(this.MMGGBBOEBEC());
	}

	// Token: 0x0600598E RID: 22926 RVA: 0x00284920 File Offset: 0x00282B20
	private void OPPNHGEMHAB()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x0600598F RID: 22927 RVA: 0x00283EAC File Offset: 0x002820AC
	public void KKPKEJBGAAG(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x06005990 RID: 22928 RVA: 0x00283E2D File Offset: 0x0028202D
	public void JDDMPKODHMM()
	{
		base.StartCoroutine(this.LPGOCMIBNIK());
	}

	// Token: 0x06005991 RID: 22929 RVA: 0x00283EAC File Offset: 0x002820AC
	public void FFAKMKJMEGI(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x06005992 RID: 22930 RVA: 0x00284968 File Offset: 0x00282B68
	public void AAOJNDOHBDC(OCCBADNHFHK MPBHHDFCDMA, int DDMMDDFIALL = -1)
	{
		string text = MPBHHDFCDMA.MFGLHECEGKK();
		text = ONEHEBIHPFB.LCKCKFDDDLC(text);
		this.choiceText.SetText(text, true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
		try
		{
			if (this.hints != null && this.hints.Count > 0)
			{
				for (int i = 0; i < this.hints.Count; i++)
				{
					this.hints[i].gameObject.SetActive(true);
				}
				if (MPBHHDFCDMA.PDIBBBDINLE >= 0 && MPBHHDFCDMA.PDIBBBDINLE < this.hints.Count)
				{
					this.hints[MPBHHDFCDMA.PDIBBBDINLE].gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005993 RID: 22931 RVA: 0x00283EEF File Offset: 0x002820EF
	public void NDACAKGFEFP(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, false);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x06005994 RID: 22932 RVA: 0x00283EAC File Offset: 0x002820AC
	public void OIGPAKEFAGM(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, true);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x06005995 RID: 22933 RVA: 0x00284A3C File Offset: 0x00282C3C
	private void OLEAIHHFBGB()
	{
		this.NCBKOJGNKLB = this.button.image.sprite;
		SpriteState spriteState = this.button.spriteState;
		this.BIGFIMMHJBP = this.button.spriteState.highlightedSprite;
	}

	// Token: 0x06005996 RID: 22934 RVA: 0x00283EE0 File Offset: 0x002820E0
	private IEnumerator LPGOCMIBNIK()
	{
		ChoiceStandardManager.HOKDMIOCKBM hokdmiockbm = new ChoiceStandardManager.HOKDMIOCKBM(1);
		hokdmiockbm.<>4__this = this;
		return hokdmiockbm;
	}

	// Token: 0x06005997 RID: 22935 RVA: 0x00283E3C File Offset: 0x0028203C
	public void FCCHFPEMMID(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x06005998 RID: 22936 RVA: 0x002841FC File Offset: 0x002823FC
	private IEnumerator MMGGBBOEBEC()
	{
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield break;
	}

	// Token: 0x06005999 RID: 22937 RVA: 0x00283E3C File Offset: 0x0028203C
	public void IDELCOJIHIK(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, true);
		if (DDMMDDFIALL > 0)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x0600599A RID: 22938 RVA: 0x00283EE0 File Offset: 0x002820E0
	private IEnumerator CCGNBBBAHEG()
	{
		ChoiceStandardManager.HOKDMIOCKBM hokdmiockbm = new ChoiceStandardManager.HOKDMIOCKBM(1);
		hokdmiockbm.<>4__this = this;
		return hokdmiockbm;
	}

	// Token: 0x0600599B RID: 22939 RVA: 0x00284264 File Offset: 0x00282464
	public void IMADGDGPBOB(string KIPCNAMEGPD, int DDMMDDFIALL = -1)
	{
		this.choiceText.SetText(KIPCNAMEGPD, false);
		if (DDMMDDFIALL > 1)
		{
			base.gameObject.GetComponent<RectTransform>().EFOCKEJENAC((float)DDMMDDFIALL);
		}
	}

	// Token: 0x0600599D RID: 22941 RVA: 0x002841FC File Offset: 0x002823FC
	private IEnumerator IOJDLKGFIKO()
	{
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield break;
	}

	// Token: 0x0600599E RID: 22942 RVA: 0x002841FC File Offset: 0x002823FC
	private IEnumerator LEDHDKHHPJP()
	{
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.BIGFIMMHJBP;
		yield return new WaitForSeconds(ChoiceStandardManager.autoChoiceAnimationTime / 5f);
		this.button.image.sprite = this.NCBKOJGNKLB;
		yield break;
	}

	// Token: 0x04001977 RID: 6519
	public static float autoChoiceAnimationTime = 0.5f;

	// Token: 0x04001978 RID: 6520
	public TextMeshProUGUI choiceText;

	// Token: 0x04001979 RID: 6521
	public Button button;

	// Token: 0x0400197A RID: 6522
	private Sprite NCBKOJGNKLB;

	// Token: 0x0400197B RID: 6523
	private Sprite BIGFIMMHJBP;

	// Token: 0x0400197C RID: 6524
	public List<Image> hints;
}
