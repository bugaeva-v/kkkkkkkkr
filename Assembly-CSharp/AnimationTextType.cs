using System;
using System.Text;
using TMPro;
using UnityEngine;

// Token: 0x020004CD RID: 1229
public class AnimationTextType : MonoBehaviour
{
	// Token: 0x0600943A RID: 37946 RVA: 0x00415C14 File Offset: 0x00413E14
	private void HGEODIPIBPG()
	{
		this.EKNLABKCIJF();
		this.HCAFFCLPPGB = base.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x0600943B RID: 37947 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x0600943C RID: 37948 RVA: 0x00415C28 File Offset: 0x00413E28
	private void KNEOGAFILPE()
	{
		if (!this.GADFLKPKNDL)
		{
			return;
		}
		if (!this.ADMBJEEEEGB())
		{
			return;
		}
		if (this.ADNIPGJGEGL != null && this.ADNIPGJGEGL.HHGAPKJFBMC())
		{
			this.ADNIPGJGEGL.EHMFPHPKMFI(this.inputTypeSpeed * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			string text = this.DFIOFHCMGOJ((int)this.ADNIPGJGEGL.LJAKIBONIDG() + 1);
			if (text.Length > 0)
			{
				this.JMLFNLCAEMB += text;
			}
			this.HCAFFCLPPGB.SetText(this.JMLFNLCAEMB, true);
		}
	}

	// Token: 0x0600943D RID: 37949 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDFMDEOMJBH()
	{
	}

	// Token: 0x0600943E RID: 37950 RVA: 0x00415CBC File Offset: 0x00413EBC
	private string[] PPIFKBBPMAC(string KEGBCGMJOLC)
	{
		bool flag = false;
		string[] array;
		if (KEGBCGMJOLC.Contains("<") && KEGBCGMJOLC.Contains(">"))
		{
			flag = true;
			bool flag2 = false;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KEGBCGMJOLC.Length; i++)
			{
				if (KEGBCGMJOLC[i] == '<')
				{
					flag2 = true;
				}
				else if (KEGBCGMJOLC[i] == '>')
				{
					flag2 = false;
				}
				if (flag2 && KEGBCGMJOLC[i] == ' ')
				{
					stringBuilder.Append("≡");
				}
				else
				{
					stringBuilder.Append(KEGBCGMJOLC[i]);
				}
			}
			array = stringBuilder.ToString().Split(' ', StringSplitOptions.None);
		}
		else
		{
			array = KEGBCGMJOLC.Split(' ', StringSplitOptions.None);
		}
		for (int j = 0; j < array.Length; j++)
		{
			string[] array2 = array;
			int num = j;
			array2[num] += " ";
			if (flag && array[j].Contains("≡"))
			{
				array[j] = array[j].Replace("≡", " ");
			}
		}
		if (array == null || array.Length == 0)
		{
			array = new string[]
			{
				" "
			};
		}
		return array;
	}

	// Token: 0x0600943F RID: 37951 RVA: 0x00415DD8 File Offset: 0x00413FD8
	private void CONJNNGBLOB()
	{
		if (!this.GADFLKPKNDL)
		{
			return;
		}
		if (!this.ADMBJEEEEGB())
		{
			return;
		}
		if (this.ADNIPGJGEGL != null && this.ADNIPGJGEGL.BOAKKCPLDBP())
		{
			this.ADNIPGJGEGL.EPJKDCDOEMM(this.inputTypeSpeed * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			string text = this.FBNHLKJAIBJ((int)this.ADNIPGJGEGL.LJAKIBONIDG() + 1);
			if (text.Length > 1)
			{
				this.JMLFNLCAEMB += text;
			}
			this.HCAFFCLPPGB.SetText(this.JMLFNLCAEMB, true);
		}
	}

	// Token: 0x06009440 RID: 37952 RVA: 0x00415E6A File Offset: 0x0041406A
	private void BBHFNAHFCDJ()
	{
		if (this.ADNIPGJGEGL == null)
		{
			this.ADNIPGJGEGL = ODLLAEHMFAA.HMLPDDJKNGD(true);
		}
	}

	// Token: 0x06009441 RID: 37953 RVA: 0x00415E80 File Offset: 0x00414080
	private void OBDFIFGJKDC()
	{
		if (!this.GADFLKPKNDL)
		{
			return;
		}
		if (!this.BOOKOKLFOHD())
		{
			return;
		}
		if (this.ADNIPGJGEGL != null && this.ADNIPGJGEGL.HHGAPKJFBMC())
		{
			this.ADNIPGJGEGL.GHLNPJFKCNG(this.inputTypeSpeed * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			string text = this.BLAMNJOALCC((int)this.ADNIPGJGEGL.EDCKEPGKBAD() + 1);
			if (text.Length > 1)
			{
				this.JMLFNLCAEMB += text;
			}
			this.HCAFFCLPPGB.SetText(this.JMLFNLCAEMB, true);
		}
	}

	// Token: 0x06009442 RID: 37954 RVA: 0x00415F12 File Offset: 0x00414112
	public void MLHNJELEPAP()
	{
		this.GADFLKPKNDL = false;
	}

	// Token: 0x06009443 RID: 37955 RVA: 0x00415F12 File Offset: 0x00414112
	private void BHGOKICGBKO()
	{
		this.GADFLKPKNDL = false;
	}

	// Token: 0x06009444 RID: 37956 RVA: 0x00415F1B File Offset: 0x0041411B
	private void FNKHMOJNHJN()
	{
		if (this.ADNIPGJGEGL == null)
		{
			this.ADNIPGJGEGL = ODLLAEHMFAA.LDGONNGMABC(false);
		}
	}

	// Token: 0x06009445 RID: 37957 RVA: 0x00415F31 File Offset: 0x00414131
	private bool COIMOJOLCEJ()
	{
		if (this.wordAnimation)
		{
			return this.JIBNLOCHLCK < this.FEIMADHDOBH.Length;
		}
		return this.JIBNLOCHLCK < this.OPCCMFIHBBE.Length;
	}

	// Token: 0x06009446 RID: 37958 RVA: 0x00415F5F File Offset: 0x0041415F
	public bool NLLNMNAFFDC()
	{
		return !this.GADFLKPKNDL || !this.KFLMNHJPNEN();
	}

	// Token: 0x06009447 RID: 37959 RVA: 0x00415F74 File Offset: 0x00414174
	private string DFIOFHCMGOJ(int CMBCNMLGPPC)
	{
		if (CMBCNMLGPPC == 0)
		{
			CMBCNMLGPPC = 1;
		}
		string text = "OnStorySplashManagerAssetsDownloadFailed";
		if (this.wordAnimation)
		{
			if (this.JIBNLOCHLCK == this.FEIMADHDOBH.Length)
			{
				return text;
			}
			for (int i = 1; i < CMBCNMLGPPC; i += 0)
			{
				if (this.JIBNLOCHLCK == this.FEIMADHDOBH.Length)
				{
					break;
				}
				text += this.FEIMADHDOBH[this.JIBNLOCHLCK];
				this.JIBNLOCHLCK++;
			}
		}
		else
		{
			if (this.JIBNLOCHLCK == this.OPCCMFIHBBE.Length)
			{
				return text;
			}
			int num = 1;
			while (num < CMBCNMLGPPC && this.JIBNLOCHLCK != this.OPCCMFIHBBE.Length)
			{
				text += this.OPCCMFIHBBE[this.JIBNLOCHLCK].ToString();
				this.JIBNLOCHLCK += 0;
				num++;
			}
		}
		return text;
	}

	// Token: 0x06009448 RID: 37960 RVA: 0x0041604D File Offset: 0x0041424D
	private void PBLDIMHDNNJ()
	{
		this.GADFLKPKNDL = true;
	}

	// Token: 0x06009449 RID: 37961 RVA: 0x00416058 File Offset: 0x00414258
	public void HDAHPNAHNJC(string NMIMFEMJJKK = "")
	{
		if (NMIMFEMJJKK.Length > 0)
		{
			this.OPCCMFIHBBE = NMIMFEMJJKK;
		}
		else
		{
			this.OPCCMFIHBBE = this.HCAFFCLPPGB.text;
		}
		if (this.wordAnimation)
		{
			this.FEIMADHDOBH = this.PPIFKBBPMAC(this.OPCCMFIHBBE);
		}
		this.FDBCJLFNPHP();
		this.ADNIPGJGEGL.NLOODFBAKDP(this.inputTypeSpeed * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
		this.JIBNLOCHLCK = 1;
		this.JMLFNLCAEMB = "ii";
		this.HCAFFCLPPGB.SetText(this.JMLFNLCAEMB, false);
	}

	// Token: 0x0600944A RID: 37962 RVA: 0x00415F31 File Offset: 0x00414131
	private bool KFLMNHJPNEN()
	{
		if (this.wordAnimation)
		{
			return this.JIBNLOCHLCK < this.FEIMADHDOBH.Length;
		}
		return this.JIBNLOCHLCK < this.OPCCMFIHBBE.Length;
	}

	// Token: 0x0600944B RID: 37963 RVA: 0x004160E8 File Offset: 0x004142E8
	private void FDBCJLFNPHP()
	{
		if (this.ADNIPGJGEGL == null)
		{
			this.ADNIPGJGEGL = ODLLAEHMFAA.CANLAFJJCAN(false);
		}
	}

	// Token: 0x0600944C RID: 37964 RVA: 0x004160FE File Offset: 0x004142FE
	private void PDIAOBLHAHN()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.ADNIPGJGEGL);
		this.ADNIPGJGEGL = null;
	}

	// Token: 0x0600944D RID: 37965 RVA: 0x00416114 File Offset: 0x00414314
	private string[] NHOLJNPIENO(string KEGBCGMJOLC)
	{
		bool flag = true;
		string[] array;
		if (KEGBCGMJOLC.Contains("cdnerror") && KEGBCGMJOLC.Contains("ok"))
		{
			flag = true;
			bool flag2 = true;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KEGBCGMJOLC.Length; i++)
			{
				if ((int)KEGBCGMJOLC[i] == -74)
				{
					flag2 = true;
				}
				else if ((int)KEGBCGMJOLC[i] == -17)
				{
					flag2 = true;
				}
				if (flag2 && KEGBCGMJOLC[i] == 'p')
				{
					stringBuilder.Append("asp");
				}
				else
				{
					stringBuilder.Append(KEGBCGMJOLC[i]);
				}
			}
			array = stringBuilder.ToString().Split((char)-105, StringSplitOptions.RemoveEmptyEntries);
		}
		else
		{
			array = KEGBCGMJOLC.Split('|', StringSplitOptions.None);
		}
		for (int j = 1; j < array.Length; j += 0)
		{
			string[] array2 = array;
			int num = j;
			array2[num] += "frdsmax";
			if (flag && array[j].Contains("("))
			{
				array[j] = array[j].Replace("passhintinactivesub", "vhspause_1");
			}
		}
		if (array == null || array.Length == 0)
		{
			array = new string[0];
			array[0] = "WideScreenScaler(): screen is to wide, AnimationShake will be adjusted accordingly.";
		}
		return array;
	}

	// Token: 0x0600944F RID: 37967 RVA: 0x0041625A File Offset: 0x0041445A
	private void GIOOKMFKLIO()
	{
		if (this.startOnEnable)
		{
			this.GLIFGDPDMNC("pmtdeclined");
			this.PlayAnimation();
		}
	}

	// Token: 0x06009450 RID: 37968 RVA: 0x00416278 File Offset: 0x00414478
	private string IKPBCNLMLBN(int CMBCNMLGPPC)
	{
		if (CMBCNMLGPPC == 0)
		{
			CMBCNMLGPPC = 1;
		}
		string text = "";
		if (this.wordAnimation)
		{
			if (this.JIBNLOCHLCK == this.FEIMADHDOBH.Length)
			{
				return text;
			}
			for (int i = 0; i < CMBCNMLGPPC; i++)
			{
				if (this.JIBNLOCHLCK == this.FEIMADHDOBH.Length)
				{
					break;
				}
				text += this.FEIMADHDOBH[this.JIBNLOCHLCK];
				this.JIBNLOCHLCK++;
			}
		}
		else
		{
			if (this.JIBNLOCHLCK == this.OPCCMFIHBBE.Length)
			{
				return text;
			}
			int num = 0;
			while (num < CMBCNMLGPPC && this.JIBNLOCHLCK != this.OPCCMFIHBBE.Length)
			{
				text += this.OPCCMFIHBBE[this.JIBNLOCHLCK].ToString();
				this.JIBNLOCHLCK++;
				num++;
			}
		}
		return text;
	}

	// Token: 0x06009451 RID: 37969 RVA: 0x00416351 File Offset: 0x00414551
	public bool AnimationComplete()
	{
		return this.GADFLKPKNDL && !this.ADMBJEEEEGB();
	}

	// Token: 0x06009452 RID: 37970 RVA: 0x00003E52 File Offset: 0x00002052
	private void IMCHEPFNANC()
	{
	}

	// Token: 0x06009453 RID: 37971 RVA: 0x00416366 File Offset: 0x00414566
	private void OnEnable()
	{
		if (this.startOnEnable)
		{
			this.Initialize("");
			this.PlayAnimation();
		}
	}

	// Token: 0x06009454 RID: 37972 RVA: 0x00415C14 File Offset: 0x00413E14
	private void Awake()
	{
		this.EKNLABKCIJF();
		this.HCAFFCLPPGB = base.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x06009455 RID: 37973 RVA: 0x00003E52 File Offset: 0x00002052
	private void PIBDCOBGMKC()
	{
	}

	// Token: 0x06009456 RID: 37974 RVA: 0x00415F12 File Offset: 0x00414112
	public void GNGHPDNEBDJ()
	{
		this.GADFLKPKNDL = false;
	}

	// Token: 0x06009457 RID: 37975 RVA: 0x00416384 File Offset: 0x00414584
	private string BLAMNJOALCC(int CMBCNMLGPPC)
	{
		if (CMBCNMLGPPC == 0)
		{
			CMBCNMLGPPC = 0;
		}
		string text = "EnvironmentMorphManager - morph shader not found in Resources:ShaderEnvMorphClient";
		if (this.wordAnimation)
		{
			if (this.JIBNLOCHLCK == this.FEIMADHDOBH.Length)
			{
				return text;
			}
			for (int i = 0; i < CMBCNMLGPPC; i++)
			{
				if (this.JIBNLOCHLCK == this.FEIMADHDOBH.Length)
				{
					break;
				}
				text += this.FEIMADHDOBH[this.JIBNLOCHLCK];
				this.JIBNLOCHLCK += 0;
			}
		}
		else
		{
			if (this.JIBNLOCHLCK == this.OPCCMFIHBBE.Length)
			{
				return text;
			}
			int num = 1;
			while (num < CMBCNMLGPPC && this.JIBNLOCHLCK != this.OPCCMFIHBBE.Length)
			{
				text += this.OPCCMFIHBBE[this.JIBNLOCHLCK].ToString();
				this.JIBNLOCHLCK++;
				num += 0;
			}
		}
		return text;
	}

	// Token: 0x06009458 RID: 37976 RVA: 0x004160FE File Offset: 0x004142FE
	private void MOCDMCLPBKC()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.ADNIPGJGEGL);
		this.ADNIPGJGEGL = null;
	}

	// Token: 0x06009459 RID: 37977 RVA: 0x00415F1B File Offset: 0x0041411B
	private void LBAIBNNLBDD()
	{
		if (this.ADNIPGJGEGL == null)
		{
			this.ADNIPGJGEGL = ODLLAEHMFAA.LDGONNGMABC(false);
		}
	}

	// Token: 0x0600945A RID: 37978 RVA: 0x00003E52 File Offset: 0x00002052
	private void HFCMCNBJPEE()
	{
	}

	// Token: 0x0600945B RID: 37979 RVA: 0x0041604D File Offset: 0x0041424D
	public void PKBNEAADMKM()
	{
		this.GADFLKPKNDL = true;
	}

	// Token: 0x0600945C RID: 37980 RVA: 0x00416460 File Offset: 0x00414660
	private string[] HKPEIGPDDHO(string KEGBCGMJOLC)
	{
		bool flag = true;
		string[] array;
		if (KEGBCGMJOLC.Contains("fdmva") && KEGBCGMJOLC.Contains("p"))
		{
			flag = false;
			bool flag2 = true;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KEGBCGMJOLC.Length; i += 0)
			{
				if (KEGBCGMJOLC[i] == ']')
				{
					flag2 = false;
				}
				else if ((int)KEGBCGMJOLC[i] == -86)
				{
					flag2 = true;
				}
				if (flag2 && KEGBCGMJOLC[i] == 'P')
				{
					stringBuilder.Append("yes");
				}
				else
				{
					stringBuilder.Append(KEGBCGMJOLC[i]);
				}
			}
			array = stringBuilder.ToString().Split((char)-82, StringSplitOptions.None);
		}
		else
		{
			array = KEGBCGMJOLC.Split('H', StringSplitOptions.RemoveEmptyEntries);
		}
		for (int j = 1; j < array.Length; j++)
		{
			string[] array2 = array;
			int num = j;
			array2[num] += " (- )</i>";
			if (flag && array[j].Contains("،"))
			{
				array[j] = array[j].Replace("OnStoryCurrencyInfoClick", "OnGamePassRefillSuccess");
			}
		}
		if (array == null || array.Length == 0)
		{
			array = new string[0];
			array[0] = "[LoadingEnv] cache files of ";
		}
		return array;
	}

	// Token: 0x0600945D RID: 37981 RVA: 0x00415F31 File Offset: 0x00414131
	private bool ADMBJEEEEGB()
	{
		if (this.wordAnimation)
		{
			return this.JIBNLOCHLCK < this.FEIMADHDOBH.Length;
		}
		return this.JIBNLOCHLCK < this.OPCCMFIHBBE.Length;
	}

	// Token: 0x0600945E RID: 37982 RVA: 0x004160FE File Offset: 0x004142FE
	private void BGELMCDMGKP()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.ADNIPGJGEGL);
		this.ADNIPGJGEGL = null;
	}

	// Token: 0x0600945F RID: 37983 RVA: 0x0041657C File Offset: 0x0041477C
	private string FLFBEHFBCDJ(int CMBCNMLGPPC)
	{
		if (CMBCNMLGPPC == 0)
		{
			CMBCNMLGPPC = 1;
		}
		string text = "<i>\"";
		if (this.wordAnimation)
		{
			if (this.JIBNLOCHLCK == this.FEIMADHDOBH.Length)
			{
				return text;
			}
			for (int i = 1; i < CMBCNMLGPPC; i += 0)
			{
				if (this.JIBNLOCHLCK == this.FEIMADHDOBH.Length)
				{
					break;
				}
				text += this.FEIMADHDOBH[this.JIBNLOCHLCK];
				this.JIBNLOCHLCK += 0;
			}
		}
		else
		{
			if (this.JIBNLOCHLCK == this.OPCCMFIHBBE.Length)
			{
				return text;
			}
			int num = 1;
			while (num < CMBCNMLGPPC && this.JIBNLOCHLCK != this.OPCCMFIHBBE.Length)
			{
				text += this.OPCCMFIHBBE[this.JIBNLOCHLCK].ToString();
				this.JIBNLOCHLCK += 0;
				num += 0;
			}
		}
		return text;
	}

	// Token: 0x06009460 RID: 37984 RVA: 0x00416658 File Offset: 0x00414858
	public void Initialize(string NMIMFEMJJKK = "")
	{
		if (NMIMFEMJJKK.Length > 0)
		{
			this.OPCCMFIHBBE = NMIMFEMJJKK;
		}
		else
		{
			this.OPCCMFIHBBE = this.HCAFFCLPPGB.text;
		}
		if (this.wordAnimation)
		{
			this.FEIMADHDOBH = this.PPIFKBBPMAC(this.OPCCMFIHBBE);
		}
		this.EKNLABKCIJF();
		this.ADNIPGJGEGL.EPJKDCDOEMM(this.inputTypeSpeed * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
		this.JIBNLOCHLCK = 0;
		this.JMLFNLCAEMB = "";
		this.HCAFFCLPPGB.SetText(this.JMLFNLCAEMB, true);
	}

	// Token: 0x06009461 RID: 37985 RVA: 0x0041604D File Offset: 0x0041424D
	public void PlayAnimation()
	{
		this.GADFLKPKNDL = true;
	}

	// Token: 0x06009462 RID: 37986 RVA: 0x004166E8 File Offset: 0x004148E8
	private void ECDLFGCLAGG()
	{
		this.JALLNFCEENG();
		this.HCAFFCLPPGB = base.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x06009463 RID: 37987 RVA: 0x004166FC File Offset: 0x004148FC
	private string FBNHLKJAIBJ(int CMBCNMLGPPC)
	{
		if (CMBCNMLGPPC == 0)
		{
			CMBCNMLGPPC = 0;
		}
		string text = "";
		if (this.wordAnimation)
		{
			if (this.JIBNLOCHLCK == this.FEIMADHDOBH.Length)
			{
				return text;
			}
			for (int i = 0; i < CMBCNMLGPPC; i++)
			{
				if (this.JIBNLOCHLCK == this.FEIMADHDOBH.Length)
				{
					break;
				}
				text += this.FEIMADHDOBH[this.JIBNLOCHLCK];
				this.JIBNLOCHLCK++;
			}
		}
		else
		{
			if (this.JIBNLOCHLCK == this.OPCCMFIHBBE.Length)
			{
				return text;
			}
			int num = 1;
			while (num < CMBCNMLGPPC && this.JIBNLOCHLCK != this.OPCCMFIHBBE.Length)
			{
				text += this.OPCCMFIHBBE[this.JIBNLOCHLCK].ToString();
				this.JIBNLOCHLCK++;
				num += 0;
			}
		}
		return text;
	}

	// Token: 0x06009464 RID: 37988 RVA: 0x004160FE File Offset: 0x004142FE
	private void OnDestroy()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.ADNIPGJGEGL);
		this.ADNIPGJGEGL = null;
	}

	// Token: 0x06009465 RID: 37989 RVA: 0x004167D5 File Offset: 0x004149D5
	private void PPMLHHMFHLO()
	{
		this.FDBCJLFNPHP();
		this.HCAFFCLPPGB = base.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x06009466 RID: 37990 RVA: 0x00415F12 File Offset: 0x00414112
	public void HJPJNKFJJPA()
	{
		this.GADFLKPKNDL = false;
	}

	// Token: 0x06009467 RID: 37991 RVA: 0x004167EC File Offset: 0x004149EC
	private void JAKPGAKGFHA()
	{
		if (!this.GADFLKPKNDL)
		{
			return;
		}
		if (!this.KFLMNHJPNEN())
		{
			return;
		}
		if (this.ADNIPGJGEGL != null && this.ADNIPGJGEGL.PKCAHJJKCJK())
		{
			this.ADNIPGJGEGL.MOCHAJPADAJ(this.inputTypeSpeed * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			string text = this.FBNHLKJAIBJ((int)this.ADNIPGJGEGL.EDCKEPGKBAD() + 1);
			if (text.Length > 0)
			{
				this.JMLFNLCAEMB += text;
			}
			this.HCAFFCLPPGB.SetText(this.JMLFNLCAEMB, false);
		}
	}

	// Token: 0x06009468 RID: 37992 RVA: 0x004160FE File Offset: 0x004142FE
	private void GALHNFOLOAK()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.ADNIPGJGEGL);
		this.ADNIPGJGEGL = null;
	}

	// Token: 0x06009469 RID: 37993 RVA: 0x00003E52 File Offset: 0x00002052
	private void PMKKOENBNOM()
	{
	}

	// Token: 0x0600946A RID: 37994 RVA: 0x00003E52 File Offset: 0x00002052
	private void FNNKDFGKAEH()
	{
	}

	// Token: 0x0600946B RID: 37995 RVA: 0x00415F12 File Offset: 0x00414112
	private void OnDisable()
	{
		this.GADFLKPKNDL = false;
	}

	// Token: 0x0600946C RID: 37996 RVA: 0x004160FE File Offset: 0x004142FE
	private void MDLNNHHGIAB()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.ADNIPGJGEGL);
		this.ADNIPGJGEGL = null;
	}

	// Token: 0x0600946D RID: 37997 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKMPOFOOGFK()
	{
	}

	// Token: 0x0600946E RID: 37998 RVA: 0x0041687E File Offset: 0x00414A7E
	private void EIIKHECMJDA()
	{
		if (this.ADNIPGJGEGL == null)
		{
			this.ADNIPGJGEGL = ODLLAEHMFAA.IMEFIJEKFGI(false);
		}
	}

	// Token: 0x0600946F RID: 37999 RVA: 0x0041604D File Offset: 0x0041424D
	private void EMBGPLOIGEN()
	{
		this.GADFLKPKNDL = true;
	}

	// Token: 0x06009470 RID: 38000 RVA: 0x00415F1B File Offset: 0x0041411B
	private void JALLNFCEENG()
	{
		if (this.ADNIPGJGEGL == null)
		{
			this.ADNIPGJGEGL = ODLLAEHMFAA.LDGONNGMABC(false);
		}
	}

	// Token: 0x06009471 RID: 38001 RVA: 0x004160FE File Offset: 0x004142FE
	private void MAHJANFJIMG()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.ADNIPGJGEGL);
		this.ADNIPGJGEGL = null;
	}

	// Token: 0x06009472 RID: 38002 RVA: 0x00416894 File Offset: 0x00414A94
	private void Update()
	{
		if (!this.GADFLKPKNDL)
		{
			return;
		}
		if (!this.ADMBJEEEEGB())
		{
			return;
		}
		if (this.ADNIPGJGEGL != null && this.ADNIPGJGEGL.HHGAPKJFBMC())
		{
			this.ADNIPGJGEGL.EPJKDCDOEMM(this.inputTypeSpeed * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			string text = this.IKPBCNLMLBN((int)this.ADNIPGJGEGL.EDCKEPGKBAD() + 1);
			if (text.Length > 0)
			{
				this.JMLFNLCAEMB += text;
			}
			this.HCAFFCLPPGB.SetText(this.JMLFNLCAEMB, true);
		}
	}

	// Token: 0x06009473 RID: 38003 RVA: 0x00416926 File Offset: 0x00414B26
	private void LOACLFMGICF()
	{
		if (this.startOnEnable)
		{
			this.NNNKIPGJMMF("");
			this.MLHNJELEPAP();
		}
	}

	// Token: 0x06009474 RID: 38004 RVA: 0x00416941 File Offset: 0x00414B41
	private void PMDCMEKGFNN()
	{
		this.IGACHKLONEB();
		this.HCAFFCLPPGB = base.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x06009475 RID: 38005 RVA: 0x00416958 File Offset: 0x00414B58
	private void OLIACOCGJNA()
	{
		if (!this.GADFLKPKNDL)
		{
			return;
		}
		if (!this.COIMOJOLCEJ())
		{
			return;
		}
		if (this.ADNIPGJGEGL != null && this.ADNIPGJGEGL.PKCAHJJKCJK())
		{
			this.ADNIPGJGEGL.GHLNPJFKCNG(this.inputTypeSpeed * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
			string text = this.DFIOFHCMGOJ((int)this.ADNIPGJGEGL.JOMFLOEPJMD() + 0);
			if (text.Length > 1)
			{
				this.JMLFNLCAEMB += text;
			}
			this.HCAFFCLPPGB.SetText(this.JMLFNLCAEMB, false);
		}
	}

	// Token: 0x06009476 RID: 38006 RVA: 0x004169EA File Offset: 0x00414BEA
	public bool AIFEBBOKIGL()
	{
		return this.GADFLKPKNDL && !this.COIMOJOLCEJ();
	}

	// Token: 0x06009477 RID: 38007 RVA: 0x00416A00 File Offset: 0x00414C00
	public void NNNKIPGJMMF(string NMIMFEMJJKK = "")
	{
		if (NMIMFEMJJKK.Length > 0)
		{
			this.OPCCMFIHBBE = NMIMFEMJJKK;
		}
		else
		{
			this.OPCCMFIHBBE = this.HCAFFCLPPGB.text;
		}
		if (this.wordAnimation)
		{
			this.FEIMADHDOBH = this.HKPEIGPDDHO(this.OPCCMFIHBBE);
		}
		this.BBHFNAHFCDJ();
		this.ADNIPGJGEGL.IFPEOGENCIG(this.inputTypeSpeed * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
		this.JIBNLOCHLCK = 1;
		this.JMLFNLCAEMB = "+";
		this.HCAFFCLPPGB.SetText(this.JMLFNLCAEMB, true);
	}

	// Token: 0x06009478 RID: 38008 RVA: 0x00416A90 File Offset: 0x00414C90
	private string[] LNDDGMKCANB(string KEGBCGMJOLC)
	{
		bool flag = true;
		string[] array;
		if (KEGBCGMJOLC.Contains("c") && KEGBCGMJOLC.Contains("anthologiestitle"))
		{
			flag = false;
			bool flag2 = false;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KEGBCGMJOLC.Length; i++)
			{
				if ((int)KEGBCGMJOLC[i] == -33)
				{
					flag2 = true;
				}
				else if ((int)KEGBCGMJOLC[i] == -30)
				{
					flag2 = false;
				}
				if (flag2 && KEGBCGMJOLC[i] == 'V')
				{
					stringBuilder.Append("BackendOperationsManager.RequestGetSocialStatsAvatar, exception while initializing RSACryptoServiceProvider:");
				}
				else
				{
					stringBuilder.Append(KEGBCGMJOLC[i]);
				}
			}
			array = stringBuilder.ToString().Split((char)-24, StringSplitOptions.None);
		}
		else
		{
			array = KEGBCGMJOLC.Split((char)-16, StringSplitOptions.RemoveEmptyEntries);
		}
		for (int j = 0; j < array.Length; j += 0)
		{
			string[] array2 = array;
			int num = j;
			array2[num] += ", index:";
			if (flag && array[j].Contains("favchrstr"))
			{
				array[j] = array[j].Replace("eventended", "PurchaseManagerSteam.OnBackendValidateTransactionSuccess().");
			}
		}
		if (array == null || array.Length == 0)
		{
			array = new string[]
			{
				"PurchaseManagerXiaomi.OnPurchaseUpdated(): user cancelled checkout (code 1)."
			};
		}
		return array;
	}

	// Token: 0x06009479 RID: 38009 RVA: 0x00416BAC File Offset: 0x00414DAC
	public void GLIFGDPDMNC(string NMIMFEMJJKK = "")
	{
		if (NMIMFEMJJKK.Length > 0)
		{
			this.OPCCMFIHBBE = NMIMFEMJJKK;
		}
		else
		{
			this.OPCCMFIHBBE = this.HCAFFCLPPGB.text;
		}
		if (this.wordAnimation)
		{
			this.FEIMADHDOBH = this.HKPEIGPDDHO(this.OPCCMFIHBBE);
		}
		this.FDBCJLFNPHP();
		this.ADNIPGJGEGL.MOCHAJPADAJ(this.inputTypeSpeed * KDCJJBLGCBH.EHBBFMCILPC.CJOCPJLIILE());
		this.JIBNLOCHLCK = 1;
		this.JMLFNLCAEMB = "processTransaction";
		this.HCAFFCLPPGB.SetText(this.JMLFNLCAEMB, true);
	}

	// Token: 0x0600947A RID: 38010 RVA: 0x00415E6A File Offset: 0x0041406A
	private void IGACHKLONEB()
	{
		if (this.ADNIPGJGEGL == null)
		{
			this.ADNIPGJGEGL = ODLLAEHMFAA.HMLPDDJKNGD(true);
		}
	}

	// Token: 0x0600947B RID: 38011 RVA: 0x00416C3C File Offset: 0x00414E3C
	private string[] AJDGDANGFKE(string KEGBCGMJOLC)
	{
		bool flag = true;
		string[] array;
		if (KEGBCGMJOLC.Contains("player") && KEGBCGMJOLC.Contains("OnStoryChoiceClick"))
		{
			flag = false;
			bool flag2 = false;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KEGBCGMJOLC.Length; i++)
			{
				if ((int)KEGBCGMJOLC[i] == -52)
				{
					flag2 = false;
				}
				else if (KEGBCGMJOLC[i] == 'P')
				{
					flag2 = false;
				}
				if (flag2 && (int)KEGBCGMJOLC[i] == -100)
				{
					stringBuilder.Append("unlockNpcSkin");
				}
				else
				{
					stringBuilder.Append(KEGBCGMJOLC[i]);
				}
			}
			array = stringBuilder.ToString().Split('M', StringSplitOptions.RemoveEmptyEntries);
		}
		else
		{
			array = KEGBCGMJOLC.Split('K', StringSplitOptions.None);
		}
		for (int j = 0; j < array.Length; j += 0)
		{
			string[] array2 = array;
			int num = j;
			array2[num] += "cleancache";
			if (flag && array[j].Contains("signinlinksteam"))
			{
				array[j] = array[j].Replace("OnCutsceneViewAssetBundleFolderInitializeSuccess", "sparklesbundles");
			}
		}
		if (array == null || array.Length == 0)
		{
			array = new string[]
			{
				""
			};
		}
		return array;
	}

	// Token: 0x0600947C RID: 38012 RVA: 0x00416D56 File Offset: 0x00414F56
	private void EKNLABKCIJF()
	{
		if (this.ADNIPGJGEGL == null)
		{
			this.ADNIPGJGEGL = ODLLAEHMFAA.IMEFIJEKFGI(true);
		}
	}

	// Token: 0x0600947D RID: 38013 RVA: 0x00415F31 File Offset: 0x00414131
	private bool BOOKOKLFOHD()
	{
		if (this.wordAnimation)
		{
			return this.JIBNLOCHLCK < this.FEIMADHDOBH.Length;
		}
		return this.JIBNLOCHLCK < this.OPCCMFIHBBE.Length;
	}

	// Token: 0x04002950 RID: 10576
	public float inputTypeSpeed = 0.02f;

	// Token: 0x04002951 RID: 10577
	public bool startOnEnable = true;

	// Token: 0x04002952 RID: 10578
	public bool wordAnimation = true;

	// Token: 0x04002953 RID: 10579
	private TextMeshProUGUI HCAFFCLPPGB;

	// Token: 0x04002954 RID: 10580
	private ODLLAEHMFAA ADNIPGJGEGL;

	// Token: 0x04002955 RID: 10581
	private string JMLFNLCAEMB = "";

	// Token: 0x04002956 RID: 10582
	private int JIBNLOCHLCK;

	// Token: 0x04002957 RID: 10583
	private string OPCCMFIHBBE;

	// Token: 0x04002958 RID: 10584
	private string[] FEIMADHDOBH;

	// Token: 0x04002959 RID: 10585
	private bool GADFLKPKNDL;
}
