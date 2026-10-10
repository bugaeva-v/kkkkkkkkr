using System;
using System.Collections;
using TMPro;
using UnityEngine;

// Token: 0x02000251 RID: 593
public class AnimationTextIncrement : MonoBehaviour
{
	// Token: 0x060048ED RID: 18669 RVA: 0x002106F2 File Offset: 0x0020E8F2
	private void EBPJMCHFDBH()
	{
		if (!this.KOHFAMMKCAB())
		{
			this.HCAFFCLPPGB = base.gameObject.GetComponent<TextMeshProUGUI>();
		}
	}

	// Token: 0x060048EE RID: 18670 RVA: 0x0021070D File Offset: 0x0020E90D
	private void DEKNOHNIIEE()
	{
		if (!this.OPLKGEDOEAM())
		{
			this.HCAFFCLPPGB = base.gameObject.GetComponent<TextMeshProUGUI>();
		}
	}

	// Token: 0x060048EF RID: 18671 RVA: 0x00210728 File Offset: 0x0020E928
	private void AOEGDOMGEAD()
	{
		if (this.MBJMJDKCJJN != null)
		{
			base.StopCoroutine(this.MBJMJDKCJJN);
			this.MBJMJDKCJJN = null;
		}
	}

	// Token: 0x060048F0 RID: 18672 RVA: 0x00210748 File Offset: 0x0020E948
	public void PHMGCAFGFAI(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.MIFPDCLHKDH();
		if (!this.KOHFAMMKCAB())
		{
			return;
		}
		this.IKIJALJPMCP();
		if (HJIIEHBPGOL <= 842f)
		{
			int jaigaggagfe = Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO;
			this.CCFOFOIDCPK = jaigaggagfe.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.GOCOCBGNBIF(jaigaggagfe, LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, false);
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.OJLNBHDLHAO(Convert.ToInt32(this.IHMKJMPEPHK), Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x060048F1 RID: 18673 RVA: 0x00210807 File Offset: 0x0020EA07
	private IEnumerator CNGJLCPOMKI(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		this.EKNLABKCIJF();
		this.LCEHENIOFOL.EPJKDCDOEMM(HJIIEHBPGOL);
		this.DMFLMBFDPGK = true;
		this.LAFKDOEMNJE = (float)MDKINBFJBJI;
		this.FKIBDPMKGDM = (float)FOJNCFLBKKE;
		yield break;
	}

	// Token: 0x060048F2 RID: 18674 RVA: 0x00210833 File Offset: 0x0020EA33
	private void HHKODCMDAHD()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x060048F3 RID: 18675 RVA: 0x00210807 File Offset: 0x0020EA07
	private IEnumerator EOGHGLIPPHA(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		this.EKNLABKCIJF();
		this.LCEHENIOFOL.EPJKDCDOEMM(HJIIEHBPGOL);
		this.DMFLMBFDPGK = true;
		this.LAFKDOEMNJE = (float)MDKINBFJBJI;
		this.FKIBDPMKGDM = (float)FOJNCFLBKKE;
		yield break;
	}

	// Token: 0x060048F4 RID: 18676 RVA: 0x00210848 File Offset: 0x0020EA48
	public void Set(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.BAMHPOCKBML();
		if (!this.FACIFBONANM())
		{
			return;
		}
		this.CIHEBHCKKLA();
		if (HJIIEHBPGOL <= 0f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.GCGFKGCFJPE(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x060048F5 RID: 18677 RVA: 0x00210833 File Offset: 0x0020EA33
	private void MFHHONHHCEC()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x060048F6 RID: 18678 RVA: 0x002108FE File Offset: 0x0020EAFE
	public void PBHCPODNPEH(string DIMBCOBNMAM)
	{
		this.prefix = DIMBCOBNMAM;
	}

	// Token: 0x060048F7 RID: 18679 RVA: 0x00210907 File Offset: 0x0020EB07
	public void IPILKCOPJOD(string DIMBCOBNMAM)
	{
		this.suffix = DIMBCOBNMAM;
	}

	// Token: 0x060048F8 RID: 18680 RVA: 0x00210910 File Offset: 0x0020EB10
	private void EKNLABKCIJF()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
	}

	// Token: 0x060048F9 RID: 18681 RVA: 0x00210928 File Offset: 0x0020EB28
	public void MMPPOHNKNGL(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.MLJINODMGAB();
		if (!this.EMNAKEANPHE())
		{
			return;
		}
		this.DJDAFJEHJKC();
		if (HJIIEHBPGOL <= 432f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.OHPKCOBCLOP(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.GCGFKGCFJPE(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x060048FA RID: 18682 RVA: 0x002109DE File Offset: 0x0020EBDE
	private void MIOMPIGJKFE()
	{
		if (!this.IDGPHBKJDGF())
		{
			this.HCAFFCLPPGB = base.gameObject.GetComponent<TextMeshProUGUI>();
		}
	}

	// Token: 0x060048FB RID: 18683 RVA: 0x002109F9 File Offset: 0x0020EBF9
	private void Start()
	{
		this.EKNLABKCIJF();
	}

	// Token: 0x060048FC RID: 18684 RVA: 0x00210833 File Offset: 0x0020EA33
	private void EHLOONNKOPB()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x060048FD RID: 18685 RVA: 0x00210A04 File Offset: 0x0020EC04
	public void EOAEFDPIJIE(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.KJDNFFJJLDN();
		if (!this.ELNKLAJGEKF())
		{
			return;
		}
		this.MDAOPHFGLMI();
		if (HJIIEHBPGOL <= 902f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.GOCOCBGNBIF(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.en);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, false);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.CNGJLCPOMKI(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x060048FE RID: 18686 RVA: 0x00210ABA File Offset: 0x0020ECBA
	private void KGEINIJLFMI()
	{
		this.JNDLDFLOHLI();
		this.BAMHPOCKBML();
	}

	// Token: 0x060048FF RID: 18687 RVA: 0x002108FE File Offset: 0x0020EAFE
	public void BOGIAEFAMAG(string DIMBCOBNMAM)
	{
		this.prefix = DIMBCOBNMAM;
	}

	// Token: 0x06004900 RID: 18688 RVA: 0x00210AC8 File Offset: 0x0020ECC8
	public void DADAANINEPN(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.DEKNOHNIIEE();
		if (!this.ANGHFHEDAOE())
		{
			return;
		}
		this.NAAHAHADGIH();
		if (HJIIEHBPGOL <= 910f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.OHPKCOBCLOP(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, false);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.PPAALAGNFLI(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x06004901 RID: 18689 RVA: 0x00210B7E File Offset: 0x0020ED7E
	private bool GBKOINCNLFJ()
	{
		return null != this.HCAFFCLPPGB;
	}

	// Token: 0x06004902 RID: 18690 RVA: 0x00210B8C File Offset: 0x0020ED8C
	private void BAMHPOCKBML()
	{
		if (!this.FACIFBONANM())
		{
			this.HCAFFCLPPGB = base.gameObject.GetComponent<TextMeshProUGUI>();
		}
	}

	// Token: 0x06004903 RID: 18691 RVA: 0x00210BA8 File Offset: 0x0020EDA8
	public void KEDHCHPANBC(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.MLJINODMGAB();
		if (!this.ELNKLAJGEKF())
		{
			return;
		}
		this.JMMJAKEFALJ();
		if (HJIIEHBPGOL <= 955f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.GOCOCBGNBIF(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.BDJABDHKLME(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x06004904 RID: 18692 RVA: 0x00210833 File Offset: 0x0020EA33
	private void DNANKPMNMIF()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06004905 RID: 18693 RVA: 0x00210C60 File Offset: 0x0020EE60
	public void CGPJEPCEJKA(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.EBPJMCHFDBH();
		if (!this.GICEKPECJBL())
		{
			return;
		}
		this.IKIJALJPMCP();
		if (HJIIEHBPGOL <= 1351f)
		{
			int jaigaggagfe = Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO;
			this.CCFOFOIDCPK = jaigaggagfe.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.OHPKCOBCLOP(jaigaggagfe, LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.HNKHMAIINOM(Convert.ToInt32(this.IHMKJMPEPHK), Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x06004906 RID: 18694 RVA: 0x00210B7E File Offset: 0x0020ED7E
	private bool OPLKGEDOEAM()
	{
		return null != this.HCAFFCLPPGB;
	}

	// Token: 0x06004907 RID: 18695 RVA: 0x00210833 File Offset: 0x0020EA33
	private void GMNFLAHGEHF()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06004908 RID: 18696 RVA: 0x00210D1F File Offset: 0x0020EF1F
	private IEnumerator OJGIJEMKPHF(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		AnimationTextIncrement.PKDONODPLHM pkdonodplhm = new AnimationTextIncrement.PKDONODPLHM(1);
		pkdonodplhm.<>4__this = this;
		pkdonodplhm._startAmount = MDKINBFJBJI;
		pkdonodplhm._endAmount = FOJNCFLBKKE;
		pkdonodplhm._animationTime = HJIIEHBPGOL;
		pkdonodplhm._delay = BICHMDEIFKI;
		return pkdonodplhm;
	}

	// Token: 0x06004909 RID: 18697 RVA: 0x00210B7E File Offset: 0x0020ED7E
	private bool ELNKLAJGEKF()
	{
		return null != this.HCAFFCLPPGB;
	}

	// Token: 0x0600490A RID: 18698 RVA: 0x00210D4C File Offset: 0x0020EF4C
	private void PJIOJHOMBCB()
	{
		if (!this.DMFLMBFDPGK)
		{
			return;
		}
		if (!this.OPLKGEDOEAM())
		{
			return;
		}
		if (this.LCEHENIOFOL == null)
		{
			return;
		}
		int num = (int)Mathf.Lerp(this.LAFKDOEMNJE, this.FKIBDPMKGDM, this.LCEHENIOFOL.MJPKAKNMHGM());
		this.CCFOFOIDCPK = num.ToString();
		if (this.EJKFINIPKEA)
		{
			this.IHMKJMPEPHK = DPGJIJGOCIC.OHPKCOBCLOP(num, LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en);
		}
		else
		{
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
		}
		string text = "string_not_found";
		if (this.prefix != null && this.prefix.Length > 0)
		{
			text += this.prefix;
		}
		if (this.showSign)
		{
			if (num > 0)
			{
				text = text + "aind" + this.IHMKJMPEPHK;
			}
			else
			{
				text += this.IHMKJMPEPHK;
			}
		}
		else
		{
			text += this.IHMKJMPEPHK;
		}
		if (this.suffix != null && this.suffix.Length > 0)
		{
			text += this.suffix;
		}
		this.HCAFFCLPPGB.SetText(text, true);
		this.IHMKJMPEPHK = this.CCFOFOIDCPK;
		if (this.LCEHENIOFOL.JAOJCHADMIG())
		{
			this.DMFLMBFDPGK = true;
		}
	}

	// Token: 0x0600490B RID: 18699 RVA: 0x00210E84 File Offset: 0x0020F084
	public void BKEEJEOLJCL(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.MLJINODMGAB();
		if (!this.FACIFBONANM())
		{
			return;
		}
		this.DJDAFJEHJKC();
		if (HJIIEHBPGOL <= 531f)
		{
			int jaigaggagfe = Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO;
			this.CCFOFOIDCPK = jaigaggagfe.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.OHPKCOBCLOP(jaigaggagfe, LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, false);
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.OHEAKBMFGIO(Convert.ToInt32(this.IHMKJMPEPHK), Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x0600490C RID: 18700 RVA: 0x00210B7E File Offset: 0x0020ED7E
	private bool EMNAKEANPHE()
	{
		return null != this.HCAFFCLPPGB;
	}

	// Token: 0x0600490D RID: 18701 RVA: 0x00210807 File Offset: 0x0020EA07
	private IEnumerator OJLNBHDLHAO(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		this.EKNLABKCIJF();
		this.LCEHENIOFOL.EPJKDCDOEMM(HJIIEHBPGOL);
		this.DMFLMBFDPGK = true;
		this.LAFKDOEMNJE = (float)MDKINBFJBJI;
		this.FKIBDPMKGDM = (float)FOJNCFLBKKE;
		yield break;
	}

	// Token: 0x0600490E RID: 18702 RVA: 0x00210833 File Offset: 0x0020EA33
	private void ONJMBHKDOGD()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x0600490F RID: 18703 RVA: 0x00210807 File Offset: 0x0020EA07
	private IEnumerator GCGFKGCFJPE(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		this.EKNLABKCIJF();
		this.LCEHENIOFOL.EPJKDCDOEMM(HJIIEHBPGOL);
		this.DMFLMBFDPGK = true;
		this.LAFKDOEMNJE = (float)MDKINBFJBJI;
		this.FKIBDPMKGDM = (float)FOJNCFLBKKE;
		yield break;
	}

	// Token: 0x06004910 RID: 18704 RVA: 0x00210F44 File Offset: 0x0020F144
	public void IJJLKLLKMBJ(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.EJEPBLIBDEN();
		if (!this.BOMEIICAFLJ())
		{
			return;
		}
		this.JMMJAKEFALJ();
		if (HJIIEHBPGOL <= 181f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.en);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.OHEAKBMFGIO(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x06004911 RID: 18705 RVA: 0x00210FFA File Offset: 0x0020F1FA
	public void GLDEMFDBDCC()
	{
		this.EJKFINIPKEA = true;
	}

	// Token: 0x06004912 RID: 18706 RVA: 0x00210907 File Offset: 0x0020EB07
	public void OKJCAAEFJKP(string DIMBCOBNMAM)
	{
		this.suffix = DIMBCOBNMAM;
	}

	// Token: 0x06004913 RID: 18707 RVA: 0x00211004 File Offset: 0x0020F204
	private void BLIGGBNJGNI()
	{
		if (!this.DMFLMBFDPGK)
		{
			return;
		}
		if (!this.KOHFAMMKCAB())
		{
			return;
		}
		if (this.LCEHENIOFOL == null)
		{
			return;
		}
		int num = (int)Mathf.Lerp(this.LAFKDOEMNJE, this.FKIBDPMKGDM, this.LCEHENIOFOL.PMECGFIPNCC());
		this.CCFOFOIDCPK = num.ToString();
		if (this.EJKFINIPKEA)
		{
			this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(num, LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en);
		}
		else
		{
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
		}
		string text = "p";
		if (this.prefix != null && this.prefix.Length > 1)
		{
			text += this.prefix;
		}
		if (this.showSign)
		{
			if (num > 0)
			{
				text = text + "OnPopupAvatarCollectionsInputEndEdit" + this.IHMKJMPEPHK;
			}
			else
			{
				text += this.IHMKJMPEPHK;
			}
		}
		else
		{
			text += this.IHMKJMPEPHK;
		}
		if (this.suffix != null && this.suffix.Length > 1)
		{
			text += this.suffix;
		}
		this.HCAFFCLPPGB.SetText(text, true);
		this.IHMKJMPEPHK = this.CCFOFOIDCPK;
		if (this.LCEHENIOFOL.GLFNEJHKAAK())
		{
			this.DMFLMBFDPGK = true;
		}
	}

	// Token: 0x06004914 RID: 18708 RVA: 0x0021113B File Offset: 0x0020F33B
	private void FFHLHFLBJIN()
	{
		this.DHFCPBNGAFA();
		this.NGCNFNNMPKC();
	}

	// Token: 0x06004915 RID: 18709 RVA: 0x00210728 File Offset: 0x0020E928
	private void NAAHAHADGIH()
	{
		if (this.MBJMJDKCJJN != null)
		{
			base.StopCoroutine(this.MBJMJDKCJJN);
			this.MBJMJDKCJJN = null;
		}
	}

	// Token: 0x06004916 RID: 18710 RVA: 0x00210FFA File Offset: 0x0020F1FA
	public void LGGHPDHKNGD()
	{
		this.EJKFINIPKEA = true;
	}

	// Token: 0x06004917 RID: 18711 RVA: 0x00210807 File Offset: 0x0020EA07
	private IEnumerator HNKHMAIINOM(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		this.EKNLABKCIJF();
		this.LCEHENIOFOL.EPJKDCDOEMM(HJIIEHBPGOL);
		this.DMFLMBFDPGK = true;
		this.LAFKDOEMNJE = (float)MDKINBFJBJI;
		this.FKIBDPMKGDM = (float)FOJNCFLBKKE;
		yield break;
	}

	// Token: 0x06004918 RID: 18712 RVA: 0x0021114C File Offset: 0x0020F34C
	public void BAAALGHOGFO(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.KJDNFFJJLDN();
		if (!this.HEMPGGJOIAD())
		{
			return;
		}
		this.DJDAFJEHJKC();
		if (HJIIEHBPGOL <= 787f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.HNKHMAIINOM(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x06004919 RID: 18713 RVA: 0x00210728 File Offset: 0x0020E928
	private void IKIJALJPMCP()
	{
		if (this.MBJMJDKCJJN != null)
		{
			base.StopCoroutine(this.MBJMJDKCJJN);
			this.MBJMJDKCJJN = null;
		}
	}

	// Token: 0x0600491A RID: 18714 RVA: 0x00211204 File Offset: 0x0020F404
	public void NMHBAEMBDEI(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.EJEPBLIBDEN();
		if (!this.GBKOINCNLFJ())
		{
			return;
		}
		this.CIHEBHCKKLA();
		if (HJIIEHBPGOL <= 1403f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.GOCOCBGNBIF(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, false);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.OJLNBHDLHAO(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x0600491B RID: 18715 RVA: 0x00210B7E File Offset: 0x0020ED7E
	private bool IDGPHBKJDGF()
	{
		return null != this.HCAFFCLPPGB;
	}

	// Token: 0x0600491C RID: 18716 RVA: 0x002112BC File Offset: 0x0020F4BC
	public void APNFNKGNELA(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.DEKNOHNIIEE();
		if (!this.ELNKLAJGEKF())
		{
			return;
		}
		this.DJDAFJEHJKC();
		if (HJIIEHBPGOL <= 1236f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.OHPKCOBCLOP(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.HNKHMAIINOM(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x0600491D RID: 18717 RVA: 0x00211374 File Offset: 0x0020F574
	public void OGCCJEEKHHN(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.DEKNOHNIIEE();
		if (!this.OPLKGEDOEAM())
		{
			return;
		}
		this.DJDAFJEHJKC();
		if (HJIIEHBPGOL <= 1197f)
		{
			int jaigaggagfe = Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO;
			this.CCFOFOIDCPK = jaigaggagfe.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(jaigaggagfe, LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.GLPILCFKFHB(Convert.ToInt32(this.IHMKJMPEPHK), Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x0600491E RID: 18718 RVA: 0x00210910 File Offset: 0x0020EB10
	private void NPIMMIFAGOP()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
	}

	// Token: 0x0600491F RID: 18719 RVA: 0x00210728 File Offset: 0x0020E928
	private void DJDAFJEHJKC()
	{
		if (this.MBJMJDKCJJN != null)
		{
			base.StopCoroutine(this.MBJMJDKCJJN);
			this.MBJMJDKCJJN = null;
		}
	}

	// Token: 0x06004920 RID: 18720 RVA: 0x00210B7E File Offset: 0x0020ED7E
	private bool FACIFBONANM()
	{
		return null != this.HCAFFCLPPGB;
	}

	// Token: 0x06004921 RID: 18721 RVA: 0x00210B7E File Offset: 0x0020ED7E
	private bool ANGHFHEDAOE()
	{
		return null != this.HCAFFCLPPGB;
	}

	// Token: 0x06004922 RID: 18722 RVA: 0x00211433 File Offset: 0x0020F633
	private void Awake()
	{
		this.EKNLABKCIJF();
		this.BAMHPOCKBML();
	}

	// Token: 0x06004924 RID: 18724 RVA: 0x00210728 File Offset: 0x0020E928
	private void MDAOPHFGLMI()
	{
		if (this.MBJMJDKCJJN != null)
		{
			base.StopCoroutine(this.MBJMJDKCJJN);
			this.MBJMJDKCJJN = null;
		}
	}

	// Token: 0x06004925 RID: 18725 RVA: 0x00210728 File Offset: 0x0020E928
	private void NDAFHAGJKKG()
	{
		if (this.MBJMJDKCJJN != null)
		{
			base.StopCoroutine(this.MBJMJDKCJJN);
			this.MBJMJDKCJJN = null;
		}
	}

	// Token: 0x06004926 RID: 18726 RVA: 0x00210FFA File Offset: 0x0020F1FA
	public void BMELOEAGMNA()
	{
		this.EJKFINIPKEA = true;
	}

	// Token: 0x06004927 RID: 18727 RVA: 0x00210907 File Offset: 0x0020EB07
	public void SetSuffix(string DIMBCOBNMAM)
	{
		this.suffix = DIMBCOBNMAM;
	}

	// Token: 0x06004928 RID: 18728 RVA: 0x0021145F File Offset: 0x0020F65F
	private void NGCNFNNMPKC()
	{
		if (!this.ELNKLAJGEKF())
		{
			this.HCAFFCLPPGB = base.gameObject.GetComponent<TextMeshProUGUI>();
		}
	}

	// Token: 0x06004929 RID: 18729 RVA: 0x0021147A File Offset: 0x0020F67A
	private void DHFCPBNGAFA()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.IMEFIJEKFGI(false);
		}
	}

	// Token: 0x0600492A RID: 18730 RVA: 0x002108FE File Offset: 0x0020EAFE
	public void IOMGAPMAILC(string DIMBCOBNMAM)
	{
		this.prefix = DIMBCOBNMAM;
	}

	// Token: 0x0600492B RID: 18731 RVA: 0x00210728 File Offset: 0x0020E928
	private void JMMJAKEFALJ()
	{
		if (this.MBJMJDKCJJN != null)
		{
			base.StopCoroutine(this.MBJMJDKCJJN);
			this.MBJMJDKCJJN = null;
		}
	}

	// Token: 0x0600492C RID: 18732 RVA: 0x002108FE File Offset: 0x0020EAFE
	public void PLAEKOKPHNH(string DIMBCOBNMAM)
	{
		this.prefix = DIMBCOBNMAM;
	}

	// Token: 0x0600492D RID: 18733 RVA: 0x00211490 File Offset: 0x0020F690
	private void OKEMACBONAF()
	{
		if (!this.DMFLMBFDPGK)
		{
			return;
		}
		if (!this.IDGPHBKJDGF())
		{
			return;
		}
		if (this.LCEHENIOFOL == null)
		{
			return;
		}
		int num = (int)Mathf.Lerp(this.LAFKDOEMNJE, this.FKIBDPMKGDM, this.LCEHENIOFOL.HKAKAAGKMIP());
		this.CCFOFOIDCPK = num.ToString();
		if (this.EJKFINIPKEA)
		{
			this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(num, LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru);
		}
		else
		{
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
		}
		string text = "/";
		if (this.prefix != null && this.prefix.Length > 1)
		{
			text += this.prefix;
		}
		if (this.showSign)
		{
			if (num > 0)
			{
				text = text + "XXX" + this.IHMKJMPEPHK;
			}
			else
			{
				text += this.IHMKJMPEPHK;
			}
		}
		else
		{
			text += this.IHMKJMPEPHK;
		}
		if (this.suffix != null && this.suffix.Length > 1)
		{
			text += this.suffix;
		}
		this.HCAFFCLPPGB.SetText(text, false);
		this.IHMKJMPEPHK = this.CCFOFOIDCPK;
		if (this.LCEHENIOFOL.PKCAHJJKCJK())
		{
			this.DMFLMBFDPGK = true;
		}
	}

	// Token: 0x0600492E RID: 18734 RVA: 0x00210B7E File Offset: 0x0020ED7E
	private bool HEMPGGJOIAD()
	{
		return null != this.HCAFFCLPPGB;
	}

	// Token: 0x0600492F RID: 18735 RVA: 0x002115C8 File Offset: 0x0020F7C8
	public void HPBAJBIOMOA(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.DEKNOHNIIEE();
		if (!this.ELNKLAJGEKF())
		{
			return;
		}
		this.IKIJALJPMCP();
		if (HJIIEHBPGOL <= 140f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, false);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.MMNDMJBMEBO(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x06004930 RID: 18736 RVA: 0x0021167E File Offset: 0x0020F87E
	public void BCKFPIIGNGG()
	{
		this.EJKFINIPKEA = false;
	}

	// Token: 0x06004931 RID: 18737 RVA: 0x00211687 File Offset: 0x0020F887
	private void PCIAOCNDCLO()
	{
		this.MICCOOLEMID();
	}

	// Token: 0x06004932 RID: 18738 RVA: 0x00210833 File Offset: 0x0020EA33
	private void DJIFHJDBBHN()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06004933 RID: 18739 RVA: 0x0021168F File Offset: 0x0020F88F
	private void MICCOOLEMID()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.LDGONNGMABC(true);
		}
	}

	// Token: 0x06004934 RID: 18740 RVA: 0x00210B7E File Offset: 0x0020ED7E
	private bool KOHFAMMKCAB()
	{
		return null != this.HCAFFCLPPGB;
	}

	// Token: 0x06004935 RID: 18741 RVA: 0x00210833 File Offset: 0x0020EA33
	private void BGELMCDMGKP()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06004936 RID: 18742 RVA: 0x002108FE File Offset: 0x0020EAFE
	public void CKFBFAJEIAH(string DIMBCOBNMAM)
	{
		this.prefix = DIMBCOBNMAM;
	}

	// Token: 0x06004937 RID: 18743 RVA: 0x00210907 File Offset: 0x0020EB07
	public void DEJMCNDFMCB(string DIMBCOBNMAM)
	{
		this.suffix = DIMBCOBNMAM;
	}

	// Token: 0x06004938 RID: 18744 RVA: 0x00210833 File Offset: 0x0020EA33
	private void FEBECEEIHBP()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06004939 RID: 18745 RVA: 0x002116A5 File Offset: 0x0020F8A5
	private void MLJINODMGAB()
	{
		if (!this.BOMEIICAFLJ())
		{
			this.HCAFFCLPPGB = base.gameObject.GetComponent<TextMeshProUGUI>();
		}
	}

	// Token: 0x0600493A RID: 18746 RVA: 0x002108FE File Offset: 0x0020EAFE
	public void BGPKKHJJOGP(string DIMBCOBNMAM)
	{
		this.prefix = DIMBCOBNMAM;
	}

	// Token: 0x0600493B RID: 18747 RVA: 0x00210B7E File Offset: 0x0020ED7E
	private bool BOMEIICAFLJ()
	{
		return null != this.HCAFFCLPPGB;
	}

	// Token: 0x0600493C RID: 18748 RVA: 0x002116C0 File Offset: 0x0020F8C0
	private void AMDGDOAOBDG()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.CANLAFJJCAN(true);
		}
	}

	// Token: 0x0600493D RID: 18749 RVA: 0x002108FE File Offset: 0x0020EAFE
	public void SetPrefix(string DIMBCOBNMAM)
	{
		this.prefix = DIMBCOBNMAM;
	}

	// Token: 0x0600493E RID: 18750 RVA: 0x00210728 File Offset: 0x0020E928
	private void CIHEBHCKKLA()
	{
		if (this.MBJMJDKCJJN != null)
		{
			base.StopCoroutine(this.MBJMJDKCJJN);
			this.MBJMJDKCJJN = null;
		}
	}

	// Token: 0x0600493F RID: 18751 RVA: 0x002116D8 File Offset: 0x0020F8D8
	public void KCIFKKGFJMO(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.BAMHPOCKBML();
		if (!this.ELNKLAJGEKF())
		{
			return;
		}
		this.DJDAFJEHJKC();
		if (HJIIEHBPGOL <= 142f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, false);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.JGPKGGJPFJI(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x06004940 RID: 18752 RVA: 0x00211790 File Offset: 0x0020F990
	public void NHIENOAGJHA(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.BAMHPOCKBML();
		if (!this.EMNAKEANPHE())
		{
			return;
		}
		this.MDAOPHFGLMI();
		if (HJIIEHBPGOL <= 1531f)
		{
			int jaigaggagfe = Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO;
			this.CCFOFOIDCPK = jaigaggagfe.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.OHPKCOBCLOP(jaigaggagfe, LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.OJGIJEMKPHF(Convert.ToInt32(this.IHMKJMPEPHK), Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x06004941 RID: 18753 RVA: 0x00211850 File Offset: 0x0020FA50
	private void NMEEMBCCKHA()
	{
		if (!this.DMFLMBFDPGK)
		{
			return;
		}
		if (!this.ELNKLAJGEKF())
		{
			return;
		}
		if (this.LCEHENIOFOL == null)
		{
			return;
		}
		int num = (int)Mathf.Lerp(this.LAFKDOEMNJE, this.FKIBDPMKGDM, this.LCEHENIOFOL.GOFCDICHOEO());
		this.CCFOFOIDCPK = num.ToString();
		if (this.EJKFINIPKEA)
		{
			this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(num, LanguageManager.EHBBFMCILPC.MLOLBFBODHD() == CEIBHCNNIDC.ru);
		}
		else
		{
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
		}
		string text = "lightmodeintrobody1";
		if (this.prefix != null && this.prefix.Length > 0)
		{
			text += this.prefix;
		}
		if (this.showSign)
		{
			if (num > 1)
			{
				text = text + " not found, replacing with " + this.IHMKJMPEPHK;
			}
			else
			{
				text += this.IHMKJMPEPHK;
			}
		}
		else
		{
			text += this.IHMKJMPEPHK;
		}
		if (this.suffix != null && this.suffix.Length > 1)
		{
			text += this.suffix;
		}
		this.HCAFFCLPPGB.SetText(text, true);
		this.IHMKJMPEPHK = this.CCFOFOIDCPK;
		if (this.LCEHENIOFOL.MLPOCAOMOHL())
		{
			this.DMFLMBFDPGK = false;
		}
	}

	// Token: 0x06004942 RID: 18754 RVA: 0x002106F2 File Offset: 0x0020E8F2
	private void MIFPDCLHKDH()
	{
		if (!this.KOHFAMMKCAB())
		{
			this.HCAFFCLPPGB = base.gameObject.GetComponent<TextMeshProUGUI>();
		}
	}

	// Token: 0x06004943 RID: 18755 RVA: 0x00210833 File Offset: 0x0020EA33
	private void OnDestroy()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x06004944 RID: 18756 RVA: 0x00211987 File Offset: 0x0020FB87
	private void IFHJKBHODGG()
	{
		this.NPIMMIFAGOP();
		this.MIFPDCLHKDH();
	}

	// Token: 0x06004945 RID: 18757 RVA: 0x00210807 File Offset: 0x0020EA07
	private IEnumerator BDJABDHKLME(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		this.EKNLABKCIJF();
		this.LCEHENIOFOL.EPJKDCDOEMM(HJIIEHBPGOL);
		this.DMFLMBFDPGK = true;
		this.LAFKDOEMNJE = (float)MDKINBFJBJI;
		this.FKIBDPMKGDM = (float)FOJNCFLBKKE;
		yield break;
	}

	// Token: 0x06004946 RID: 18758 RVA: 0x00211998 File Offset: 0x0020FB98
	public void DPHEMOIKKPP(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.KJDNFFJJLDN();
		if (!this.BOMEIICAFLJ())
		{
			return;
		}
		this.LOEMNDODDEO();
		if (HJIIEHBPGOL <= 446f)
		{
			int jaigaggagfe = Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO;
			this.CCFOFOIDCPK = jaigaggagfe.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.OHPKCOBCLOP(jaigaggagfe, LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.MMNDMJBMEBO(Convert.ToInt32(this.IHMKJMPEPHK), Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x06004947 RID: 18759 RVA: 0x002108FE File Offset: 0x0020EAFE
	public void GOCEGNBIKHO(string DIMBCOBNMAM)
	{
		this.prefix = DIMBCOBNMAM;
	}

	// Token: 0x06004948 RID: 18760 RVA: 0x00211A58 File Offset: 0x0020FC58
	private void Update()
	{
		if (!this.DMFLMBFDPGK)
		{
			return;
		}
		if (!this.FACIFBONANM())
		{
			return;
		}
		if (this.LCEHENIOFOL == null)
		{
			return;
		}
		int num = (int)Mathf.Lerp(this.LAFKDOEMNJE, this.FKIBDPMKGDM, this.LCEHENIOFOL.HKAKAAGKMIP());
		this.CCFOFOIDCPK = num.ToString();
		if (this.EJKFINIPKEA)
		{
			this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(num, LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru);
		}
		else
		{
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
		}
		string text = "";
		if (this.prefix != null && this.prefix.Length > 0)
		{
			text += this.prefix;
		}
		if (this.showSign)
		{
			if (num > 0)
			{
				text = text + "+" + this.IHMKJMPEPHK;
			}
			else
			{
				text += this.IHMKJMPEPHK;
			}
		}
		else
		{
			text += this.IHMKJMPEPHK;
		}
		if (this.suffix != null && this.suffix.Length > 0)
		{
			text += this.suffix;
		}
		this.HCAFFCLPPGB.SetText(text, true);
		this.IHMKJMPEPHK = this.CCFOFOIDCPK;
		if (this.LCEHENIOFOL.HHGAPKJFBMC())
		{
			this.DMFLMBFDPGK = false;
		}
	}

	// Token: 0x06004949 RID: 18761 RVA: 0x00210807 File Offset: 0x0020EA07
	private IEnumerator PPAALAGNFLI(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		this.EKNLABKCIJF();
		this.LCEHENIOFOL.EPJKDCDOEMM(HJIIEHBPGOL);
		this.DMFLMBFDPGK = true;
		this.LAFKDOEMNJE = (float)MDKINBFJBJI;
		this.FKIBDPMKGDM = (float)FOJNCFLBKKE;
		yield break;
	}

	// Token: 0x0600494A RID: 18762 RVA: 0x002108FE File Offset: 0x0020EAFE
	public void OHOGAHMDPDM(string DIMBCOBNMAM)
	{
		this.prefix = DIMBCOBNMAM;
	}

	// Token: 0x0600494B RID: 18763 RVA: 0x00211B8F File Offset: 0x0020FD8F
	private void EJEPBLIBDEN()
	{
		if (!this.GBKOINCNLFJ())
		{
			this.HCAFFCLPPGB = base.gameObject.GetComponent<TextMeshProUGUI>();
		}
	}

	// Token: 0x0600494C RID: 18764 RVA: 0x00210807 File Offset: 0x0020EA07
	private IEnumerator MLGMBHJKCMK(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		this.EKNLABKCIJF();
		this.LCEHENIOFOL.EPJKDCDOEMM(HJIIEHBPGOL);
		this.DMFLMBFDPGK = true;
		this.LAFKDOEMNJE = (float)MDKINBFJBJI;
		this.FKIBDPMKGDM = (float)FOJNCFLBKKE;
		yield break;
	}

	// Token: 0x0600494D RID: 18765 RVA: 0x00211BAC File Offset: 0x0020FDAC
	public void OCKELKKIAIC(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.EJEPBLIBDEN();
		if (!this.EMNAKEANPHE())
		{
			return;
		}
		this.DJDAFJEHJKC();
		if (HJIIEHBPGOL <= 949f)
		{
			int jaigaggagfe = Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO;
			this.CCFOFOIDCPK = jaigaggagfe.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.GOCOCBGNBIF(jaigaggagfe, LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.ru);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, false);
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.OJLNBHDLHAO(Convert.ToInt32(this.IHMKJMPEPHK), Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x0600494E RID: 18766 RVA: 0x002106F2 File Offset: 0x0020E8F2
	private void KJDNFFJJLDN()
	{
		if (!this.KOHFAMMKCAB())
		{
			this.HCAFFCLPPGB = base.gameObject.GetComponent<TextMeshProUGUI>();
		}
	}

	// Token: 0x0600494F RID: 18767 RVA: 0x0021167E File Offset: 0x0020F87E
	public void ECIALDANBGE()
	{
		this.EJKFINIPKEA = false;
	}

	// Token: 0x06004950 RID: 18768 RVA: 0x00211C6C File Offset: 0x0020FE6C
	private void IACMMOBHGCK()
	{
		if (!this.DMFLMBFDPGK)
		{
			return;
		}
		if (!this.IDGPHBKJDGF())
		{
			return;
		}
		if (this.LCEHENIOFOL == null)
		{
			return;
		}
		int num = (int)Mathf.Lerp(this.LAFKDOEMNJE, this.FKIBDPMKGDM, this.LCEHENIOFOL.HKAKAAGKMIP());
		this.CCFOFOIDCPK = num.ToString();
		if (this.EJKFINIPKEA)
		{
			this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(num, LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.ru);
		}
		else
		{
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
		}
		string text = "ok";
		if (this.prefix != null && this.prefix.Length > 0)
		{
			text += this.prefix;
		}
		if (this.showSign)
		{
			if (num > 0)
			{
				text = text + "immediate" + this.IHMKJMPEPHK;
			}
			else
			{
				text += this.IHMKJMPEPHK;
			}
		}
		else
		{
			text += this.IHMKJMPEPHK;
		}
		if (this.suffix != null && this.suffix.Length > 1)
		{
			text += this.suffix;
		}
		this.HCAFFCLPPGB.SetText(text, true);
		this.IHMKJMPEPHK = this.CCFOFOIDCPK;
		if (this.LCEHENIOFOL.BOAKKCPLDBP())
		{
			this.DMFLMBFDPGK = true;
		}
	}

	// Token: 0x06004951 RID: 18769 RVA: 0x00210D1F File Offset: 0x0020EF1F
	private IEnumerator OHEAKBMFGIO(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		AnimationTextIncrement.PKDONODPLHM pkdonodplhm = new AnimationTextIncrement.PKDONODPLHM(1);
		pkdonodplhm.<>4__this = this;
		pkdonodplhm._startAmount = MDKINBFJBJI;
		pkdonodplhm._endAmount = FOJNCFLBKKE;
		pkdonodplhm._animationTime = HJIIEHBPGOL;
		pkdonodplhm._delay = BICHMDEIFKI;
		return pkdonodplhm;
	}

	// Token: 0x06004952 RID: 18770 RVA: 0x00211DA3 File Offset: 0x0020FFA3
	private void DCMMAADPBPM()
	{
		this.MICCOOLEMID();
		this.EBPJMCHFDBH();
	}

	// Token: 0x06004953 RID: 18771 RVA: 0x00210807 File Offset: 0x0020EA07
	private IEnumerator JGPKGGJPFJI(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		this.EKNLABKCIJF();
		this.LCEHENIOFOL.EPJKDCDOEMM(HJIIEHBPGOL);
		this.DMFLMBFDPGK = true;
		this.LAFKDOEMNJE = (float)MDKINBFJBJI;
		this.FKIBDPMKGDM = (float)FOJNCFLBKKE;
		yield break;
	}

	// Token: 0x06004954 RID: 18772 RVA: 0x00210D1F File Offset: 0x0020EF1F
	private IEnumerator MMNDMJBMEBO(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		AnimationTextIncrement.PKDONODPLHM pkdonodplhm = new AnimationTextIncrement.PKDONODPLHM(1);
		pkdonodplhm.<>4__this = this;
		pkdonodplhm._startAmount = MDKINBFJBJI;
		pkdonodplhm._endAmount = FOJNCFLBKKE;
		pkdonodplhm._animationTime = HJIIEHBPGOL;
		pkdonodplhm._delay = BICHMDEIFKI;
		return pkdonodplhm;
	}

	// Token: 0x06004955 RID: 18773 RVA: 0x00210907 File Offset: 0x0020EB07
	public void LFCNBCJKFOA(string DIMBCOBNMAM)
	{
		this.suffix = DIMBCOBNMAM;
	}

	// Token: 0x06004956 RID: 18774 RVA: 0x00211DB4 File Offset: 0x0020FFB4
	public void BIPPINKFIOL(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.MIOMPIGJKFE();
		if (!this.GBKOINCNLFJ())
		{
			return;
		}
		this.LOEMNDODDEO();
		if (HJIIEHBPGOL <= 969f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.OJGIJEMKPHF(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x06004957 RID: 18775 RVA: 0x00211E6C File Offset: 0x0021006C
	public void KGFBPCNFBFC(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.BAMHPOCKBML();
		if (!this.IDGPHBKJDGF())
		{
			return;
		}
		this.LOEMNDODDEO();
		if (HJIIEHBPGOL <= 1634f)
		{
			this.CCFOFOIDCPK = KIDHBAMJGDO.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.GOCOCBGNBIF(KIDHBAMJGDO, LanguageManager.EHBBFMCILPC.NBANPEIHFOJ() == CEIBHCNNIDC.en);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.HCAFFCLPPGB.text = this.IHMKJMPEPHK;
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.OHEAKBMFGIO(Convert.ToInt32(this.IHMKJMPEPHK), KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x06004958 RID: 18776 RVA: 0x00211F22 File Offset: 0x00210122
	private void CJPNMBNKLOO()
	{
		this.JNDLDFLOHLI();
	}

	// Token: 0x06004959 RID: 18777 RVA: 0x00210833 File Offset: 0x0020EA33
	private void MGOMPPDOPOA()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.LCEHENIOFOL);
		this.LCEHENIOFOL = null;
	}

	// Token: 0x0600495A RID: 18778 RVA: 0x00210907 File Offset: 0x0020EB07
	public void IIFAEEJPGMG(string DIMBCOBNMAM)
	{
		this.suffix = DIMBCOBNMAM;
	}

	// Token: 0x0600495B RID: 18779 RVA: 0x00210B7E File Offset: 0x0020ED7E
	private bool GICEKPECJBL()
	{
		return null != this.HCAFFCLPPGB;
	}

	// Token: 0x0600495C RID: 18780 RVA: 0x00211F2A File Offset: 0x0021012A
	private void JNDLDFLOHLI()
	{
		if (this.LCEHENIOFOL == null)
		{
			this.LCEHENIOFOL = ODLLAEHMFAA.HMLPDDJKNGD(true);
		}
	}

	// Token: 0x0600495D RID: 18781 RVA: 0x00210807 File Offset: 0x0020EA07
	private IEnumerator GLPILCFKFHB(int MDKINBFJBJI, int FOJNCFLBKKE, float HJIIEHBPGOL, float BICHMDEIFKI)
	{
		yield return new WaitForSeconds(BICHMDEIFKI);
		this.EKNLABKCIJF();
		this.LCEHENIOFOL.EPJKDCDOEMM(HJIIEHBPGOL);
		this.DMFLMBFDPGK = true;
		this.LAFKDOEMNJE = (float)MDKINBFJBJI;
		this.FKIBDPMKGDM = (float)FOJNCFLBKKE;
		yield break;
	}

	// Token: 0x0600495E RID: 18782 RVA: 0x00211F40 File Offset: 0x00210140
	public void LCIFFLEAPKB(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.BAMHPOCKBML();
		if (!this.HEMPGGJOIAD())
		{
			return;
		}
		this.IKIJALJPMCP();
		if (HJIIEHBPGOL <= 978f)
		{
			int jaigaggagfe = Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO;
			this.CCFOFOIDCPK = jaigaggagfe.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.OHPKCOBCLOP(jaigaggagfe, LanguageManager.EHBBFMCILPC.IEBFINIJAMJ() == CEIBHCNNIDC.en);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, false);
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.OHEAKBMFGIO(Convert.ToInt32(this.IHMKJMPEPHK), Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x0600495F RID: 18783 RVA: 0x002108FE File Offset: 0x0020EAFE
	public void PPEGHGPOPNI(string DIMBCOBNMAM)
	{
		this.prefix = DIMBCOBNMAM;
	}

	// Token: 0x06004960 RID: 18784 RVA: 0x00210728 File Offset: 0x0020E928
	private void LOEMNDODDEO()
	{
		if (this.MBJMJDKCJJN != null)
		{
			base.StopCoroutine(this.MBJMJDKCJJN);
			this.MBJMJDKCJJN = null;
		}
	}

	// Token: 0x06004961 RID: 18785 RVA: 0x00210FFA File Offset: 0x0020F1FA
	public void EnableShortNumberFormat()
	{
		this.EJKFINIPKEA = true;
	}

	// Token: 0x06004962 RID: 18786 RVA: 0x00212000 File Offset: 0x00210200
	public void Increment(int KIDHBAMJGDO, float HJIIEHBPGOL = 1f, float BICHMDEIFKI = 0f)
	{
		this.BAMHPOCKBML();
		if (!this.FACIFBONANM())
		{
			return;
		}
		this.CIHEBHCKKLA();
		if (HJIIEHBPGOL <= 0f)
		{
			int jaigaggagfe = Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO;
			this.CCFOFOIDCPK = jaigaggagfe.ToString();
			if (this.EJKFINIPKEA)
			{
				this.IHMKJMPEPHK = DPGJIJGOCIC.AMAFLPDPBOO(jaigaggagfe, LanguageManager.EHBBFMCILPC.GetSelectedLanguage() == CEIBHCNNIDC.ru);
			}
			else
			{
				this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			}
			this.HCAFFCLPPGB.SetText(this.IHMKJMPEPHK, true);
			this.IHMKJMPEPHK = this.CCFOFOIDCPK;
			return;
		}
		this.MBJMJDKCJJN = base.StartCoroutine(this.GCGFKGCFJPE(Convert.ToInt32(this.IHMKJMPEPHK), Convert.ToInt32(this.IHMKJMPEPHK) + KIDHBAMJGDO, HJIIEHBPGOL, BICHMDEIFKI));
	}

	// Token: 0x04001509 RID: 5385
	public string prefix;

	// Token: 0x0400150A RID: 5386
	public string suffix;

	// Token: 0x0400150B RID: 5387
	public bool showSign;

	// Token: 0x0400150C RID: 5388
	private string IHMKJMPEPHK = "0";

	// Token: 0x0400150D RID: 5389
	private string CCFOFOIDCPK = "0";

	// Token: 0x0400150E RID: 5390
	private float LAFKDOEMNJE;

	// Token: 0x0400150F RID: 5391
	private float FKIBDPMKGDM;

	// Token: 0x04001510 RID: 5392
	private bool DMFLMBFDPGK;

	// Token: 0x04001511 RID: 5393
	private TextMeshProUGUI HCAFFCLPPGB;

	// Token: 0x04001512 RID: 5394
	private ODLLAEHMFAA LCEHENIOFOL;

	// Token: 0x04001513 RID: 5395
	private Coroutine MBJMJDKCJJN;

	// Token: 0x04001514 RID: 5396
	private bool EJKFINIPKEA;
}
