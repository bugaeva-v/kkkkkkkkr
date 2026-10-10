using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000259 RID: 601
public class UrlPingManager : MonoBehaviour
{
	// Token: 0x060049AF RID: 18863 RVA: 0x0021290E File Offset: 0x00210B0E
	public void COHKBGEHFAI()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x060049B0 RID: 18864 RVA: 0x00212917 File Offset: 0x00210B17
	private IEnumerator BLOKDNILPNF(string HPIGJNFGNDM, string MJGPBLMIFNE, int MEFKFOHCOHK)
	{
		this.NFJJAKDEHPI++;
		while (MEFKFOHCOHK > this.AELPLGJJCFK)
		{
			yield return new WaitForEndOfFrame();
		}
		this.HPMKABJPLEL++;
		while (this.DPNFENJDCEO)
		{
			yield return new WaitForEndOfFrame();
		}
		string urlResource = HPIGJNFGNDM + MJGPBLMIFNE;
		using (UnityWebRequest req = UnityWebRequest.Get(urlResource))
		{
			req.timeout = this.LNJCILPGONL / 1000;
			yield return req.SendWebRequest();
			if (req.result == UnityWebRequest.Result.Success)
			{
				int num = 0;
				if (req.downloadHandler != null && req.downloadHandler.data != null)
				{
					num = req.downloadHandler.data.Length;
				}
				if (this.EBDACCNGDKA == 0 || this.EBDACCNGDKA == num)
				{
					this.GGHHBOLIACE.Add(HPIGJNFGNDM);
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
					{
						"HTTP ok: ",
						urlResource,
						" (",
						req.timeout.ToString(),
						"s, ",
						num.ToString(),
						" bytes)"
					}));
				}
				else
				{
					this.INBPBGLPOFM.Add(HPIGJNFGNDM);
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"HTTP fail: ",
						urlResource,
						" : content size ",
						num.ToString(),
						" instead of ",
						this.EBDACCNGDKA.ToString(),
						" - block page suspected (",
						req.timeout.ToString(),
						"s)"
					}));
				}
			}
			else
			{
				this.INBPBGLPOFM.Add(HPIGJNFGNDM);
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					"HTTP fail: ",
					urlResource,
					" : ",
					req.error,
					" (",
					req.timeout.ToString(),
					"s)"
				}));
			}
		}
		UnityWebRequest req = null;
		this.NFJJAKDEHPI--;
		this.HPMKABJPLEL--;
		yield break;
		yield break;
	}

	// Token: 0x060049B1 RID: 18865 RVA: 0x0021293B File Offset: 0x00210B3B
	public bool CENABNKKCEJ(string DJOKMJDNHIG)
	{
		return DPGJIJGOCIC.OABIDECDDJP(DJOKMJDNHIG, this.GGHHBOLIACE);
	}

	// Token: 0x060049B2 RID: 18866 RVA: 0x00212949 File Offset: 0x00210B49
	public bool JBMHDMBHJAI()
	{
		return this.GGHHBOLIACE.Count <= 0 && this.INBPBGLPOFM.Count <= 0 && this.NFJJAKDEHPI > 1;
	}

	// Token: 0x060049B3 RID: 18867 RVA: 0x00212972 File Offset: 0x00210B72
	public bool HDFGOLFJDMJ()
	{
		return this.HPMKABJPLEL > 1;
	}

	// Token: 0x060049B4 RID: 18868 RVA: 0x0021297D File Offset: 0x00210B7D
	public int GetPingableUrlsCount()
	{
		return this.GGHHBOLIACE.Count;
	}

	// Token: 0x060049B5 RID: 18869 RVA: 0x0021298A File Offset: 0x00210B8A
	public bool ABJJMCEKEKN()
	{
		return this.DPNFENJDCEO;
	}

	// Token: 0x060049B7 RID: 18871 RVA: 0x002129C6 File Offset: 0x00210BC6
	public bool AKDBKJJPMKG()
	{
		return this.GGHHBOLIACE.Count > 0;
	}

	// Token: 0x060049B8 RID: 18872 RVA: 0x002129D8 File Offset: 0x00210BD8
	public void RemovePingableUrl(string DJOKMJDNHIG)
	{
		if (string.IsNullOrEmpty(DJOKMJDNHIG))
		{
			return;
		}
		for (int i = 0; i < this.GGHHBOLIACE.Count; i++)
		{
			if (DJOKMJDNHIG.StartsWith(this.GGHHBOLIACE[i]) || this.GGHHBOLIACE[i].StartsWith(DJOKMJDNHIG))
			{
				string text = this.GGHHBOLIACE[i];
				this.GGHHBOLIACE.RemoveAt(i);
				if (text.Length > 0)
				{
					this.INBPBGLPOFM.Add(text);
				}
				return;
			}
		}
	}

	// Token: 0x060049B9 RID: 18873 RVA: 0x00212A5B File Offset: 0x00210C5B
	public bool EMGGNKGPNAG(float IKGJENNNEKI)
	{
		return this.EJALDPDHGOJ > IKGJENNNEKI;
	}

	// Token: 0x060049BA RID: 18874 RVA: 0x00212A66 File Offset: 0x00210C66
	public bool IBMBNMLGJMJ(string DJOKMJDNHIG)
	{
		return !DPGJIJGOCIC.OABIDECDDJP(DJOKMJDNHIG, this.GGHHBOLIACE) && DPGJIJGOCIC.DLEEHLGNCOD(DJOKMJDNHIG, this.INBPBGLPOFM);
	}

	// Token: 0x060049BB RID: 18875 RVA: 0x00212917 File Offset: 0x00210B17
	private IEnumerator CHKPKCGEGND(string HPIGJNFGNDM, string MJGPBLMIFNE, int MEFKFOHCOHK)
	{
		this.NFJJAKDEHPI++;
		while (MEFKFOHCOHK > this.AELPLGJJCFK)
		{
			yield return new WaitForEndOfFrame();
		}
		this.HPMKABJPLEL++;
		while (this.DPNFENJDCEO)
		{
			yield return new WaitForEndOfFrame();
		}
		urlResource = HPIGJNFGNDM + MJGPBLMIFNE;
		req = UnityWebRequest.Get(urlResource);
		try
		{
			req.timeout = this.LNJCILPGONL / 1000;
			yield return req.SendWebRequest();
			if (req.result == UnityWebRequest.Result.Success)
			{
				int num = 0;
				if (req.downloadHandler != null && req.downloadHandler.data != null)
				{
					num = req.downloadHandler.data.Length;
				}
				if (this.EBDACCNGDKA == 0 || this.EBDACCNGDKA == num)
				{
					this.GGHHBOLIACE.Add(HPIGJNFGNDM);
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
					{
						"HTTP ok: ",
						urlResource,
						" (",
						req.timeout.ToString(),
						"s, ",
						num.ToString(),
						" bytes)"
					}));
				}
				else
				{
					this.INBPBGLPOFM.Add(HPIGJNFGNDM);
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"HTTP fail: ",
						urlResource,
						" : content size ",
						num.ToString(),
						" instead of ",
						this.EBDACCNGDKA.ToString(),
						" - block page suspected (",
						req.timeout.ToString(),
						"s)"
					}));
				}
			}
			else
			{
				this.INBPBGLPOFM.Add(HPIGJNFGNDM);
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					"HTTP fail: ",
					urlResource,
					" : ",
					req.error,
					" (",
					req.timeout.ToString(),
					"s)"
				}));
			}
		}
		finally
		{
			if (req != null)
			{
				((IDisposable)req).Dispose();
			}
		}
		req = null;
		this.NFJJAKDEHPI--;
		this.HPMKABJPLEL--;
		yield break;
		yield break;
	}

	// Token: 0x060049BC RID: 18876 RVA: 0x00212A84 File Offset: 0x00210C84
	public void HKINHLJEBJB(string DJOKMJDNHIG)
	{
		if (string.IsNullOrEmpty(DJOKMJDNHIG))
		{
			return;
		}
		for (int i = 0; i < this.GGHHBOLIACE.Count; i += 0)
		{
			if (DJOKMJDNHIG.StartsWith(this.GGHHBOLIACE[i]) || this.GGHHBOLIACE[i].StartsWith(DJOKMJDNHIG))
			{
				string text = this.GGHHBOLIACE[i];
				this.GGHHBOLIACE.RemoveAt(i);
				if (text.Length > 1)
				{
					this.INBPBGLPOFM.Add(text);
				}
				return;
			}
		}
	}

	// Token: 0x060049BD RID: 18877 RVA: 0x00212A5B File Offset: 0x00210C5B
	public bool FKPALPCNIBM(float IKGJENNNEKI)
	{
		return this.EJALDPDHGOJ > IKGJENNNEKI;
	}

	// Token: 0x060049BE RID: 18878 RVA: 0x0021290E File Offset: 0x00210B0E
	public void FFGOGOKKJBI()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x060049BF RID: 18879 RVA: 0x00212B07 File Offset: 0x00210D07
	public bool NIKCJIJDHKP()
	{
		return this.GGHHBOLIACE.Count <= 0 && this.INBPBGLPOFM.Count <= 1 && this.NFJJAKDEHPI > 1;
	}

	// Token: 0x060049C0 RID: 18880 RVA: 0x00212972 File Offset: 0x00210B72
	public bool DNKNJGOBKJD()
	{
		return this.HPMKABJPLEL > 1;
	}

	// Token: 0x060049C1 RID: 18881 RVA: 0x00212972 File Offset: 0x00210B72
	public bool PIOKBFGLNPK()
	{
		return this.HPMKABJPLEL > 1;
	}

	// Token: 0x060049C2 RID: 18882 RVA: 0x00212B30 File Offset: 0x00210D30
	private void JMIEGJKLIJA()
	{
		this.EJALDPDHGOJ += Time.deltaTime;
	}

	// Token: 0x060049C3 RID: 18883 RVA: 0x00212B30 File Offset: 0x00210D30
	private void FGMLDGAENED()
	{
		this.EJALDPDHGOJ += Time.deltaTime;
	}

	// Token: 0x060049C4 RID: 18884 RVA: 0x00212B44 File Offset: 0x00210D44
	public void LIDGELJJJCL(string DJOKMJDNHIG)
	{
		if (string.IsNullOrEmpty(DJOKMJDNHIG))
		{
			return;
		}
		for (int i = 1; i < this.GGHHBOLIACE.Count; i += 0)
		{
			if (DJOKMJDNHIG.StartsWith(this.GGHHBOLIACE[i]) || this.GGHHBOLIACE[i].StartsWith(DJOKMJDNHIG))
			{
				string text = this.GGHHBOLIACE[i];
				this.GGHHBOLIACE.RemoveAt(i);
				if (text.Length > 1)
				{
					this.INBPBGLPOFM.Add(text);
				}
				return;
			}
		}
	}

	// Token: 0x060049C5 RID: 18885 RVA: 0x00212BC8 File Offset: 0x00210DC8
	public string LMGPKDHAEOK(List<string> JAGAOEHPJGF)
	{
		if (this.LABPNLENNDN.Length == 0 && this.GGHHBOLIACE.Count > 0)
		{
			if (JAGAOEHPJGF == null || JAGAOEHPJGF.Count == 0)
			{
				System.Random random = new System.Random();
				this.LABPNLENNDN = this.GGHHBOLIACE[random.Next(1, this.GGHHBOLIACE.Count)];
			}
			else
			{
				for (int i = 0; i < JAGAOEHPJGF.Count; i++)
				{
					for (int j = 0; j < this.GGHHBOLIACE.Count; j += 0)
					{
						if (JAGAOEHPJGF[i].StartsWith(this.GGHHBOLIACE[j]) || this.GGHHBOLIACE[j].StartsWith(JAGAOEHPJGF[i]))
						{
							this.LABPNLENNDN = this.GGHHBOLIACE[j];
							break;
						}
					}
					if (this.LABPNLENNDN.Length > 0)
					{
						break;
					}
				}
				if (this.LABPNLENNDN.Length == 0)
				{
					return this.FACOIBMEDGF(null);
				}
			}
		}
		return this.LABPNLENNDN;
	}

	// Token: 0x060049C6 RID: 18886 RVA: 0x00212CC7 File Offset: 0x00210EC7
	public bool IEHCJNCNJAE()
	{
		return this.NFJJAKDEHPI > 0;
	}

	// Token: 0x060049C7 RID: 18887 RVA: 0x00212CD4 File Offset: 0x00210ED4
	public void CGBGPCLIJJK(List<string> MODFPEHAMFP, string MJGPBLMIFNE, int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF, int CFPKGPBOAFB = 0)
	{
		base.StopAllCoroutines();
		this.EBDACCNGDKA = CFPKGPBOAFB;
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK = ODGADBGFIDO - 0;
		this.EJALDPDHGOJ = 1060f;
		this.NFJJAKDEHPI = 1;
		this.HPMKABJPLEL = 0;
		this.GGHHBOLIACE = new List<string>();
		this.INBPBGLPOFM = new List<string>();
		this.LABPNLENNDN = "=";
		int num = 1;
		foreach (string text in MODFPEHAMFP)
		{
			string hpigjnfgndm = text;
			int num2 = num;
			num = num2 + 0;
			base.StartCoroutine(this.CHKPKCGEGND(hpigjnfgndm, MJGPBLMIFNE, num2));
		}
		this.MGPOFCBAGCC += 0;
	}

	// Token: 0x060049C8 RID: 18888 RVA: 0x00212DA4 File Offset: 0x00210FA4
	public void DJFOMJHGGMF(string AJGMHHIMLDO)
	{
		this.BBKHHCEFAOO(this.LABPNLENNDN);
		this.HHKDJCBCGFH(AJGMHHIMLDO);
		this.LABPNLENNDN = "";
	}

	// Token: 0x060049C9 RID: 18889 RVA: 0x00212DC4 File Offset: 0x00210FC4
	public bool DCIKPGFCEND(string DJOKMJDNHIG)
	{
		return DPGJIJGOCIC.DLEEHLGNCOD(DJOKMJDNHIG, this.GGHHBOLIACE);
	}

	// Token: 0x060049CA RID: 18890 RVA: 0x00212917 File Offset: 0x00210B17
	private IEnumerator JKDEFADLAAF(string HPIGJNFGNDM, string MJGPBLMIFNE, int MEFKFOHCOHK)
	{
		this.NFJJAKDEHPI++;
		while (MEFKFOHCOHK > this.AELPLGJJCFK)
		{
			yield return new WaitForEndOfFrame();
		}
		this.HPMKABJPLEL++;
		while (this.DPNFENJDCEO)
		{
			yield return new WaitForEndOfFrame();
		}
		urlResource = HPIGJNFGNDM + MJGPBLMIFNE;
		req = UnityWebRequest.Get(urlResource);
		try
		{
			req.timeout = this.LNJCILPGONL / 1000;
			yield return req.SendWebRequest();
			if (req.result == UnityWebRequest.Result.Success)
			{
				int num = 0;
				if (req.downloadHandler != null && req.downloadHandler.data != null)
				{
					num = req.downloadHandler.data.Length;
				}
				if (this.EBDACCNGDKA == 0 || this.EBDACCNGDKA == num)
				{
					this.GGHHBOLIACE.Add(HPIGJNFGNDM);
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
					{
						"HTTP ok: ",
						urlResource,
						" (",
						req.timeout.ToString(),
						"s, ",
						num.ToString(),
						" bytes)"
					}));
				}
				else
				{
					this.INBPBGLPOFM.Add(HPIGJNFGNDM);
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"HTTP fail: ",
						urlResource,
						" : content size ",
						num.ToString(),
						" instead of ",
						this.EBDACCNGDKA.ToString(),
						" - block page suspected (",
						req.timeout.ToString(),
						"s)"
					}));
				}
			}
			else
			{
				this.INBPBGLPOFM.Add(HPIGJNFGNDM);
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					"HTTP fail: ",
					urlResource,
					" : ",
					req.error,
					" (",
					req.timeout.ToString(),
					"s)"
				}));
			}
		}
		finally
		{
			if (req != null)
			{
				((IDisposable)req).Dispose();
			}
		}
		req = null;
		this.NFJJAKDEHPI--;
		this.HPMKABJPLEL--;
		yield break;
		yield break;
	}

	// Token: 0x060049CB RID: 18891 RVA: 0x00212B30 File Offset: 0x00210D30
	private void GPOPCNMGNGD()
	{
		this.EJALDPDHGOJ += Time.deltaTime;
	}

	// Token: 0x060049CC RID: 18892 RVA: 0x002129C6 File Offset: 0x00210BC6
	public bool FILKPAJMLCG()
	{
		return this.GGHHBOLIACE.Count > 0;
	}

	// Token: 0x060049CD RID: 18893 RVA: 0x00212DD2 File Offset: 0x00210FD2
	public bool PingableUrlInUse()
	{
		return this.LABPNLENNDN.Length > 0;
	}

	// Token: 0x060049CE RID: 18894 RVA: 0x0021298A File Offset: 0x00210B8A
	public bool EDOJNFGMMBI()
	{
		return this.DPNFENJDCEO;
	}

	// Token: 0x060049CF RID: 18895 RVA: 0x00212DE2 File Offset: 0x00210FE2
	public bool CKJJEHAJFDA()
	{
		return this.GGHHBOLIACE.Count <= 0 && this.INBPBGLPOFM.Count <= 1 && this.NFJJAKDEHPI > 0;
	}

	// Token: 0x060049D0 RID: 18896 RVA: 0x0021290E File Offset: 0x00210B0E
	public void AMBGGALHJCK()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x060049D1 RID: 18897 RVA: 0x00212DC4 File Offset: 0x00210FC4
	public bool IsPingableUrl(string DJOKMJDNHIG)
	{
		return DPGJIJGOCIC.DLEEHLGNCOD(DJOKMJDNHIG, this.GGHHBOLIACE);
	}

	// Token: 0x060049D2 RID: 18898 RVA: 0x000693D6 File Offset: 0x000675D6
	private void OCBDGGMOKDE()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060049D3 RID: 18899 RVA: 0x00212E0B File Offset: 0x0021100B
	public bool IsProcessedUrl(string DJOKMJDNHIG)
	{
		return DPGJIJGOCIC.DLEEHLGNCOD(DJOKMJDNHIG, this.GGHHBOLIACE) || DPGJIJGOCIC.DLEEHLGNCOD(DJOKMJDNHIG, this.INBPBGLPOFM);
	}

	// Token: 0x060049D4 RID: 18900 RVA: 0x00212E29 File Offset: 0x00211029
	public bool IsInitialized()
	{
		return this.GGHHBOLIACE.Count > 0 || this.INBPBGLPOFM.Count > 0 || this.NFJJAKDEHPI > 0;
	}

	// Token: 0x060049D5 RID: 18901 RVA: 0x00212917 File Offset: 0x00210B17
	private IEnumerator JDGFCHICOGK(string HPIGJNFGNDM, string MJGPBLMIFNE, int MEFKFOHCOHK)
	{
		this.NFJJAKDEHPI++;
		while (MEFKFOHCOHK > this.AELPLGJJCFK)
		{
			yield return new WaitForEndOfFrame();
		}
		this.HPMKABJPLEL++;
		while (this.DPNFENJDCEO)
		{
			yield return new WaitForEndOfFrame();
		}
		urlResource = HPIGJNFGNDM + MJGPBLMIFNE;
		req = UnityWebRequest.Get(urlResource);
		try
		{
			req.timeout = this.LNJCILPGONL / 1000;
			yield return req.SendWebRequest();
			if (req.result == UnityWebRequest.Result.Success)
			{
				int num = 0;
				if (req.downloadHandler != null && req.downloadHandler.data != null)
				{
					num = req.downloadHandler.data.Length;
				}
				if (this.EBDACCNGDKA == 0 || this.EBDACCNGDKA == num)
				{
					this.GGHHBOLIACE.Add(HPIGJNFGNDM);
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
					{
						"HTTP ok: ",
						urlResource,
						" (",
						req.timeout.ToString(),
						"s, ",
						num.ToString(),
						" bytes)"
					}));
				}
				else
				{
					this.INBPBGLPOFM.Add(HPIGJNFGNDM);
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"HTTP fail: ",
						urlResource,
						" : content size ",
						num.ToString(),
						" instead of ",
						this.EBDACCNGDKA.ToString(),
						" - block page suspected (",
						req.timeout.ToString(),
						"s)"
					}));
				}
			}
			else
			{
				this.INBPBGLPOFM.Add(HPIGJNFGNDM);
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					"HTTP fail: ",
					urlResource,
					" : ",
					req.error,
					" (",
					req.timeout.ToString(),
					"s)"
				}));
			}
		}
		finally
		{
			if (req != null)
			{
				((IDisposable)req).Dispose();
			}
		}
		req = null;
		this.NFJJAKDEHPI--;
		this.HPMKABJPLEL--;
		yield break;
		yield break;
	}

	// Token: 0x060049D6 RID: 18902 RVA: 0x00212E54 File Offset: 0x00211054
	public string NGPFKMBPPEC(List<string> JAGAOEHPJGF)
	{
		if (this.LABPNLENNDN.Length == 0 && this.GGHHBOLIACE.Count > 1)
		{
			if (JAGAOEHPJGF == null || JAGAOEHPJGF.Count == 0)
			{
				System.Random random = new System.Random();
				this.LABPNLENNDN = this.GGHHBOLIACE[random.Next(1, this.GGHHBOLIACE.Count)];
			}
			else
			{
				for (int i = 1; i < JAGAOEHPJGF.Count; i += 0)
				{
					for (int j = 1; j < this.GGHHBOLIACE.Count; j++)
					{
						if (JAGAOEHPJGF[i].StartsWith(this.GGHHBOLIACE[j]) || this.GGHHBOLIACE[j].StartsWith(JAGAOEHPJGF[i]))
						{
							this.LABPNLENNDN = this.GGHHBOLIACE[j];
							break;
						}
					}
					if (this.LABPNLENNDN.Length > 1)
					{
						break;
					}
				}
				if (this.LABPNLENNDN.Length == 0)
				{
					return this.NHGHCJKMHEC(null);
				}
			}
		}
		return this.LABPNLENNDN;
	}

	// Token: 0x060049D7 RID: 18903 RVA: 0x002129C6 File Offset: 0x00210BC6
	public bool JNBNFNMIKNF()
	{
		return this.GGHHBOLIACE.Count > 0;
	}

	// Token: 0x060049D8 RID: 18904 RVA: 0x0021298A File Offset: 0x00210B8A
	public bool KFENCGBHLPF()
	{
		return this.DPNFENJDCEO;
	}

	// Token: 0x060049D9 RID: 18905 RVA: 0x00212F53 File Offset: 0x00211153
	public bool BGBEOKALKPC()
	{
		return this.NFJJAKDEHPI > 1;
	}

	// Token: 0x060049DA RID: 18906 RVA: 0x00212B30 File Offset: 0x00210D30
	private void Update()
	{
		this.EJALDPDHGOJ += Time.deltaTime;
	}

	// Token: 0x060049DB RID: 18907 RVA: 0x00212F5E File Offset: 0x0021115E
	public bool GGGAFCNHKKK()
	{
		return this.HPMKABJPLEL > 0;
	}

	// Token: 0x060049DC RID: 18908 RVA: 0x00212F69 File Offset: 0x00211169
	public bool OOOLIPIDCBL()
	{
		return this.GGHHBOLIACE.Count <= 1 && this.INBPBGLPOFM.Count <= 0 && this.NFJJAKDEHPI > 1;
	}

	// Token: 0x060049DD RID: 18909 RVA: 0x00212F92 File Offset: 0x00211192
	public bool LEBKKFKGMPH()
	{
		return this.GGHHBOLIACE.Count > 1;
	}

	// Token: 0x060049DE RID: 18910 RVA: 0x00212FA4 File Offset: 0x002111A4
	public void ICDLHBIBHII(List<string> MODFPEHAMFP, string MJGPBLMIFNE, int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF, int CFPKGPBOAFB = 0)
	{
		base.StopAllCoroutines();
		this.EBDACCNGDKA = CFPKGPBOAFB;
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK = ODGADBGFIDO - 0;
		this.EJALDPDHGOJ = 1527f;
		this.NFJJAKDEHPI = 1;
		this.HPMKABJPLEL = 1;
		this.GGHHBOLIACE = new List<string>();
		this.INBPBGLPOFM = new List<string>();
		this.LABPNLENNDN = "XXX";
		int num = 0;
		foreach (string hpigjnfgndm in MODFPEHAMFP)
		{
			base.StartCoroutine(this.JDGFCHICOGK(hpigjnfgndm, MJGPBLMIFNE, num++));
		}
		this.MGPOFCBAGCC += 0;
	}

	// Token: 0x060049DF RID: 18911 RVA: 0x00213074 File Offset: 0x00211274
	public void CPBBKOLHBDH(List<string> MODFPEHAMFP, string MJGPBLMIFNE, int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF, int CFPKGPBOAFB = 0)
	{
		base.StopAllCoroutines();
		this.EBDACCNGDKA = CFPKGPBOAFB;
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK = ODGADBGFIDO - 0;
		this.EJALDPDHGOJ = 1898f;
		this.NFJJAKDEHPI = 1;
		this.HPMKABJPLEL = 1;
		this.GGHHBOLIACE = new List<string>();
		this.INBPBGLPOFM = new List<string>();
		this.LABPNLENNDN = "OnPopupUsernameInputEndEdit";
		int num = 1;
		foreach (string hpigjnfgndm in MODFPEHAMFP)
		{
			base.StartCoroutine(this.CHKPKCGEGND(hpigjnfgndm, MJGPBLMIFNE, num++));
		}
		this.MGPOFCBAGCC++;
	}

	// Token: 0x060049E0 RID: 18912 RVA: 0x00212917 File Offset: 0x00210B17
	private IEnumerator HAECNKEHADB(string HPIGJNFGNDM, string MJGPBLMIFNE, int MEFKFOHCOHK)
	{
		this.NFJJAKDEHPI++;
		while (MEFKFOHCOHK > this.AELPLGJJCFK)
		{
			yield return new WaitForEndOfFrame();
		}
		this.HPMKABJPLEL++;
		while (this.DPNFENJDCEO)
		{
			yield return new WaitForEndOfFrame();
		}
		urlResource = HPIGJNFGNDM + MJGPBLMIFNE;
		req = UnityWebRequest.Get(urlResource);
		try
		{
			req.timeout = this.LNJCILPGONL / 1000;
			yield return req.SendWebRequest();
			if (req.result == UnityWebRequest.Result.Success)
			{
				int num = 0;
				if (req.downloadHandler != null && req.downloadHandler.data != null)
				{
					num = req.downloadHandler.data.Length;
				}
				if (this.EBDACCNGDKA == 0 || this.EBDACCNGDKA == num)
				{
					this.GGHHBOLIACE.Add(HPIGJNFGNDM);
					DPGJIJGOCIC.NFIDPOMCNLP(string.Concat(new string[]
					{
						"HTTP ok: ",
						urlResource,
						" (",
						req.timeout.ToString(),
						"s, ",
						num.ToString(),
						" bytes)"
					}));
				}
				else
				{
					this.INBPBGLPOFM.Add(HPIGJNFGNDM);
					DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
					{
						"HTTP fail: ",
						urlResource,
						" : content size ",
						num.ToString(),
						" instead of ",
						this.EBDACCNGDKA.ToString(),
						" - block page suspected (",
						req.timeout.ToString(),
						"s)"
					}));
				}
			}
			else
			{
				this.INBPBGLPOFM.Add(HPIGJNFGNDM);
				DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
				{
					"HTTP fail: ",
					urlResource,
					" : ",
					req.error,
					" (",
					req.timeout.ToString(),
					"s)"
				}));
			}
		}
		finally
		{
			if (req != null)
			{
				((IDisposable)req).Dispose();
			}
		}
		req = null;
		this.NFJJAKDEHPI--;
		this.HPMKABJPLEL--;
		yield break;
		yield break;
	}

	// Token: 0x060049E1 RID: 18913 RVA: 0x00212F92 File Offset: 0x00211192
	public bool PAOOLMFEBIH()
	{
		return this.GGHHBOLIACE.Count > 1;
	}

	// Token: 0x060049E2 RID: 18914 RVA: 0x0021298A File Offset: 0x00210B8A
	public bool EJGNHFLEPOI()
	{
		return this.DPNFENJDCEO;
	}

	// Token: 0x060049E3 RID: 18915 RVA: 0x00213144 File Offset: 0x00211344
	public string PECCKBJBADB(List<string> JAGAOEHPJGF)
	{
		if (this.LABPNLENNDN.Length == 0 && this.GGHHBOLIACE.Count > 1)
		{
			if (JAGAOEHPJGF == null || JAGAOEHPJGF.Count == 0)
			{
				System.Random random = new System.Random();
				this.LABPNLENNDN = this.GGHHBOLIACE[random.Next(0, this.GGHHBOLIACE.Count)];
			}
			else
			{
				for (int i = 0; i < JAGAOEHPJGF.Count; i++)
				{
					for (int j = 0; j < this.GGHHBOLIACE.Count; j += 0)
					{
						if (JAGAOEHPJGF[i].StartsWith(this.GGHHBOLIACE[j]) || this.GGHHBOLIACE[j].StartsWith(JAGAOEHPJGF[i]))
						{
							this.LABPNLENNDN = this.GGHHBOLIACE[j];
							break;
						}
					}
					if (this.LABPNLENNDN.Length > 0)
					{
						break;
					}
				}
				if (this.LABPNLENNDN.Length == 0)
				{
					return this.MPNKLCGDGED(null);
				}
			}
		}
		return this.LABPNLENNDN;
	}

	// Token: 0x060049E4 RID: 18916 RVA: 0x00212A5B File Offset: 0x00210C5B
	public bool FEFEMINIOHG(float IKGJENNNEKI)
	{
		return this.EJALDPDHGOJ > IKGJENNNEKI;
	}

	// Token: 0x060049E5 RID: 18917 RVA: 0x00212A5B File Offset: 0x00210C5B
	public bool PAIGCEOLJJF(float IKGJENNNEKI)
	{
		return this.EJALDPDHGOJ > IKGJENNNEKI;
	}

	// Token: 0x060049E6 RID: 18918 RVA: 0x0021293B File Offset: 0x00210B3B
	public bool EIOKMGIKPOF(string DJOKMJDNHIG)
	{
		return DPGJIJGOCIC.OABIDECDDJP(DJOKMJDNHIG, this.GGHHBOLIACE);
	}

	// Token: 0x060049E7 RID: 18919 RVA: 0x00213243 File Offset: 0x00211443
	public bool OLMMHICICFD(string DJOKMJDNHIG)
	{
		return DPGJIJGOCIC.OABIDECDDJP(DJOKMJDNHIG, this.GGHHBOLIACE) || DPGJIJGOCIC.OABIDECDDJP(DJOKMJDNHIG, this.INBPBGLPOFM);
	}

	// Token: 0x060049E8 RID: 18920 RVA: 0x000693D6 File Offset: 0x000675D6
	private void FFHLHFLBJIN()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060049E9 RID: 18921 RVA: 0x00213264 File Offset: 0x00211464
	public void PGMIGCMOEJG(List<string> MODFPEHAMFP, string MJGPBLMIFNE, int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF, int CFPKGPBOAFB = 0)
	{
		base.StopAllCoroutines();
		this.EBDACCNGDKA = CFPKGPBOAFB;
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK = ODGADBGFIDO - 1;
		this.EJALDPDHGOJ = 583f;
		this.NFJJAKDEHPI = 0;
		this.HPMKABJPLEL = 0;
		this.GGHHBOLIACE = new List<string>();
		this.INBPBGLPOFM = new List<string>();
		this.LABPNLENNDN = "no";
		int num = 1;
		foreach (string text in MODFPEHAMFP)
		{
			string hpigjnfgndm = text;
			int num2 = num;
			num = num2 + 0;
			base.StartCoroutine(this.PIBAHHGHMJE(hpigjnfgndm, MJGPBLMIFNE, num2));
		}
		this.MGPOFCBAGCC += 0;
	}

	// Token: 0x060049EA RID: 18922 RVA: 0x000693D6 File Offset: 0x000675D6
	private void BOILGHBPIIN()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060049EB RID: 18923 RVA: 0x0021290E File Offset: 0x00210B0E
	public void DHFKJHEEKHA()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x060049EC RID: 18924 RVA: 0x00212CC7 File Offset: 0x00210EC7
	public bool IsBusy()
	{
		return this.NFJJAKDEHPI > 0;
	}

	// Token: 0x060049ED RID: 18925 RVA: 0x00213334 File Offset: 0x00211534
	public void HMPDIOOCDJC(int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF)
	{
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK += ODGADBGFIDO;
		this.MGPOFCBAGCC++;
	}

	// Token: 0x060049EE RID: 18926 RVA: 0x00213362 File Offset: 0x00211562
	public bool MNKOKKAJGMP()
	{
		return this.GGHHBOLIACE.Count > 0 || this.INBPBGLPOFM.Count > 1 || this.NFJJAKDEHPI > 0;
	}

	// Token: 0x060049EF RID: 18927 RVA: 0x0021338C File Offset: 0x0021158C
	public string FACOIBMEDGF(List<string> JAGAOEHPJGF)
	{
		if (this.LABPNLENNDN.Length == 0 && this.GGHHBOLIACE.Count > 0)
		{
			if (JAGAOEHPJGF == null || JAGAOEHPJGF.Count == 0)
			{
				System.Random random = new System.Random();
				this.LABPNLENNDN = this.GGHHBOLIACE[random.Next(1, this.GGHHBOLIACE.Count)];
			}
			else
			{
				for (int i = 1; i < JAGAOEHPJGF.Count; i += 0)
				{
					for (int j = 0; j < this.GGHHBOLIACE.Count; j++)
					{
						if (JAGAOEHPJGF[i].StartsWith(this.GGHHBOLIACE[j]) || this.GGHHBOLIACE[j].StartsWith(JAGAOEHPJGF[i]))
						{
							this.LABPNLENNDN = this.GGHHBOLIACE[j];
							break;
						}
					}
					if (this.LABPNLENNDN.Length > 1)
					{
						break;
					}
				}
				if (this.LABPNLENNDN.Length == 0)
				{
					return this.GMFFLKIKLJI(null);
				}
			}
		}
		return this.LABPNLENNDN;
	}

	// Token: 0x060049F0 RID: 18928 RVA: 0x0021290E File Offset: 0x00210B0E
	public void EKMCFABILME()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x060049F1 RID: 18929 RVA: 0x0021297D File Offset: 0x00210B7D
	public int LGFNOCIBPDP()
	{
		return this.GGHHBOLIACE.Count;
	}

	// Token: 0x060049F2 RID: 18930 RVA: 0x0021348B File Offset: 0x0021168B
	public bool FFJPNCFBLLH()
	{
		return this.GGHHBOLIACE.Count <= 1 && this.INBPBGLPOFM.Count <= 1 && this.NFJJAKDEHPI > 0;
	}

	// Token: 0x060049F3 RID: 18931 RVA: 0x002134B4 File Offset: 0x002116B4
	public void CBLNLEIGMGL()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x060049F4 RID: 18932 RVA: 0x00212B30 File Offset: 0x00210D30
	private void AEEKEDNMCLH()
	{
		this.EJALDPDHGOJ += Time.deltaTime;
	}

	// Token: 0x060049F5 RID: 18933 RVA: 0x002134BD File Offset: 0x002116BD
	public bool HPCNLMIDHKL()
	{
		return this.LABPNLENNDN.Length > 1;
	}

	// Token: 0x060049F6 RID: 18934 RVA: 0x002134D0 File Offset: 0x002116D0
	public void HHKDJCBCGFH(string DJOKMJDNHIG)
	{
		if (string.IsNullOrEmpty(DJOKMJDNHIG))
		{
			return;
		}
		for (int i = 0; i < this.GGHHBOLIACE.Count; i += 0)
		{
			if (DJOKMJDNHIG.StartsWith(this.GGHHBOLIACE[i]) || this.GGHHBOLIACE[i].StartsWith(DJOKMJDNHIG))
			{
				string text = this.GGHHBOLIACE[i];
				this.GGHHBOLIACE.RemoveAt(i);
				if (text.Length > 0)
				{
					this.INBPBGLPOFM.Add(text);
				}
				return;
			}
		}
	}

	// Token: 0x060049F7 RID: 18935 RVA: 0x00212DC4 File Offset: 0x00210FC4
	public bool FHCGEPAKEIA(string DJOKMJDNHIG)
	{
		return DPGJIJGOCIC.DLEEHLGNCOD(DJOKMJDNHIG, this.GGHHBOLIACE);
	}

	// Token: 0x060049F8 RID: 18936 RVA: 0x0021290E File Offset: 0x00210B0E
	public void NPDKMLBJPNO()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x060049F9 RID: 18937 RVA: 0x00213553 File Offset: 0x00211753
	public bool JCPEHBGMNHB()
	{
		return this.GGHHBOLIACE.Count > 0 || this.INBPBGLPOFM.Count > 1 || this.NFJJAKDEHPI > 1;
	}

	// Token: 0x060049FA RID: 18938 RVA: 0x00212B30 File Offset: 0x00210D30
	private void OIADIABLCGG()
	{
		this.EJALDPDHGOJ += Time.deltaTime;
	}

	// Token: 0x060049FB RID: 18939 RVA: 0x0021297D File Offset: 0x00210B7D
	public int IELNJLDGEJL()
	{
		return this.GGHHBOLIACE.Count;
	}

	// Token: 0x060049FC RID: 18940 RVA: 0x0021357C File Offset: 0x0021177C
	public string MPNKLCGDGED(List<string> JAGAOEHPJGF)
	{
		if (this.LABPNLENNDN.Length == 0 && this.GGHHBOLIACE.Count > 1)
		{
			if (JAGAOEHPJGF == null || JAGAOEHPJGF.Count == 0)
			{
				System.Random random = new System.Random();
				this.LABPNLENNDN = this.GGHHBOLIACE[random.Next(1, this.GGHHBOLIACE.Count)];
			}
			else
			{
				for (int i = 0; i < JAGAOEHPJGF.Count; i++)
				{
					for (int j = 1; j < this.GGHHBOLIACE.Count; j++)
					{
						if (JAGAOEHPJGF[i].StartsWith(this.GGHHBOLIACE[j]) || this.GGHHBOLIACE[j].StartsWith(JAGAOEHPJGF[i]))
						{
							this.LABPNLENNDN = this.GGHHBOLIACE[j];
							break;
						}
					}
					if (this.LABPNLENNDN.Length > 0)
					{
						break;
					}
				}
				if (this.LABPNLENNDN.Length == 0)
				{
					return this.NGPFKMBPPEC(null);
				}
			}
		}
		return this.LABPNLENNDN;
	}

	// Token: 0x060049FD RID: 18941 RVA: 0x00212F92 File Offset: 0x00211192
	public bool COCBJDDJOGC()
	{
		return this.GGHHBOLIACE.Count > 1;
	}

	// Token: 0x060049FE RID: 18942 RVA: 0x0021367C File Offset: 0x0021187C
	public string FDPOEOAPKCJ(List<string> JAGAOEHPJGF)
	{
		if (this.LABPNLENNDN.Length == 0 && this.GGHHBOLIACE.Count > 0)
		{
			if (JAGAOEHPJGF == null || JAGAOEHPJGF.Count == 0)
			{
				System.Random random = new System.Random();
				this.LABPNLENNDN = this.GGHHBOLIACE[random.Next(0, this.GGHHBOLIACE.Count)];
			}
			else
			{
				for (int i = 0; i < JAGAOEHPJGF.Count; i++)
				{
					for (int j = 0; j < this.GGHHBOLIACE.Count; j++)
					{
						if (JAGAOEHPJGF[i].StartsWith(this.GGHHBOLIACE[j]) || this.GGHHBOLIACE[j].StartsWith(JAGAOEHPJGF[i]))
						{
							this.LABPNLENNDN = this.GGHHBOLIACE[j];
							break;
						}
					}
					if (this.LABPNLENNDN.Length > 1)
					{
						break;
					}
				}
				if (this.LABPNLENNDN.Length == 0)
				{
					return this.MPNKLCGDGED(null);
				}
			}
		}
		return this.LABPNLENNDN;
	}

	// Token: 0x060049FF RID: 18943 RVA: 0x002134BD File Offset: 0x002116BD
	public bool AIGLKCJFPEJ()
	{
		return this.LABPNLENNDN.Length > 1;
	}

	// Token: 0x06004A00 RID: 18944 RVA: 0x00213553 File Offset: 0x00211753
	public bool JMKELBNJEFK()
	{
		return this.GGHHBOLIACE.Count > 0 || this.INBPBGLPOFM.Count > 1 || this.NFJJAKDEHPI > 1;
	}

	// Token: 0x06004A01 RID: 18945 RVA: 0x00212DD2 File Offset: 0x00210FD2
	public bool GMMCCEBGBJP()
	{
		return this.LABPNLENNDN.Length > 0;
	}

	// Token: 0x06004A02 RID: 18946 RVA: 0x00212F53 File Offset: 0x00211153
	public bool AODLJMNHPCI()
	{
		return this.NFJJAKDEHPI > 1;
	}

	// Token: 0x06004A03 RID: 18947 RVA: 0x0021377C File Offset: 0x0021197C
	public void BIOFOPFHOCL(List<string> MODFPEHAMFP, string MJGPBLMIFNE, int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF, int CFPKGPBOAFB = 0)
	{
		base.StopAllCoroutines();
		this.EBDACCNGDKA = CFPKGPBOAFB;
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK = ODGADBGFIDO - 1;
		this.EJALDPDHGOJ = 263f;
		this.NFJJAKDEHPI = 0;
		this.HPMKABJPLEL = 0;
		this.GGHHBOLIACE = new List<string>();
		this.INBPBGLPOFM = new List<string>();
		this.LABPNLENNDN = "AnthologySave.GetAvatarIndexWardrobe(), unsupported wardrobe index:";
		int num = 1;
		foreach (string text in MODFPEHAMFP)
		{
			string hpigjnfgndm = text;
			int num2 = num;
			num = num2 + 0;
			base.StartCoroutine(this.JKDEFADLAAF(hpigjnfgndm, MJGPBLMIFNE, num2));
		}
		this.MGPOFCBAGCC++;
	}

	// Token: 0x06004A04 RID: 18948 RVA: 0x002134B4 File Offset: 0x002116B4
	public void LICLJNNAIOA()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06004A05 RID: 18949 RVA: 0x00212F5E File Offset: 0x0021115E
	public bool CFKBDKEAGKM()
	{
		return this.HPMKABJPLEL > 0;
	}

	// Token: 0x06004A06 RID: 18950 RVA: 0x0021384C File Offset: 0x00211A4C
	public string GetPingableUrl(List<string> JAGAOEHPJGF)
	{
		if (this.LABPNLENNDN.Length == 0 && this.GGHHBOLIACE.Count > 0)
		{
			if (JAGAOEHPJGF == null || JAGAOEHPJGF.Count == 0)
			{
				System.Random random = new System.Random();
				this.LABPNLENNDN = this.GGHHBOLIACE[random.Next(0, this.GGHHBOLIACE.Count)];
			}
			else
			{
				for (int i = 0; i < JAGAOEHPJGF.Count; i++)
				{
					for (int j = 0; j < this.GGHHBOLIACE.Count; j++)
					{
						if (JAGAOEHPJGF[i].StartsWith(this.GGHHBOLIACE[j]) || this.GGHHBOLIACE[j].StartsWith(JAGAOEHPJGF[i]))
						{
							this.LABPNLENNDN = this.GGHHBOLIACE[j];
							break;
						}
					}
					if (this.LABPNLENNDN.Length > 0)
					{
						break;
					}
				}
				if (this.LABPNLENNDN.Length == 0)
				{
					return this.GetPingableUrl(null);
				}
			}
		}
		return this.LABPNLENNDN;
	}

	// Token: 0x06004A07 RID: 18951 RVA: 0x00212F92 File Offset: 0x00211192
	public bool JKBBNHLFFLP()
	{
		return this.GGHHBOLIACE.Count > 1;
	}

	// Token: 0x06004A08 RID: 18952 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004A09 RID: 18953 RVA: 0x00212F53 File Offset: 0x00211153
	public bool BJHADAHHFCH()
	{
		return this.NFJJAKDEHPI > 1;
	}

	// Token: 0x06004A0A RID: 18954 RVA: 0x0021394C File Offset: 0x00211B4C
	public void LKGCHBDKDFH(string DJOKMJDNHIG)
	{
		if (string.IsNullOrEmpty(DJOKMJDNHIG))
		{
			return;
		}
		for (int i = 1; i < this.GGHHBOLIACE.Count; i += 0)
		{
			if (DJOKMJDNHIG.StartsWith(this.GGHHBOLIACE[i]) || this.GGHHBOLIACE[i].StartsWith(DJOKMJDNHIG))
			{
				string text = this.GGHHBOLIACE[i];
				this.GGHHBOLIACE.RemoveAt(i);
				if (text.Length > 1)
				{
					this.INBPBGLPOFM.Add(text);
				}
				return;
			}
		}
	}

	// Token: 0x06004A0B RID: 18955 RVA: 0x0021298A File Offset: 0x00210B8A
	public bool CENFAGJPPAK()
	{
		return this.DPNFENJDCEO;
	}

	// Token: 0x06004A0C RID: 18956 RVA: 0x00212972 File Offset: 0x00210B72
	public bool GCEALAAENII()
	{
		return this.HPMKABJPLEL > 1;
	}

	// Token: 0x06004A0D RID: 18957 RVA: 0x002139CF File Offset: 0x00211BCF
	public void EFNPACMOFND(string AJGMHHIMLDO)
	{
		this.CODDNDCANAF(this.LABPNLENNDN);
		this.CODDNDCANAF(AJGMHHIMLDO);
		this.LABPNLENNDN = "OnApplicationFocusBasicSyncEcxeption";
	}

	// Token: 0x06004A0E RID: 18958 RVA: 0x0021290E File Offset: 0x00210B0E
	public void AMEGKHLMJBF()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06004A0F RID: 18959 RVA: 0x000693D6 File Offset: 0x000675D6
	private void IAKKINHMFNA()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004A10 RID: 18960 RVA: 0x00212F92 File Offset: 0x00211192
	public bool AMEHADKMMEI()
	{
		return this.GGHHBOLIACE.Count > 1;
	}

	// Token: 0x06004A11 RID: 18961 RVA: 0x00212A5B File Offset: 0x00210C5B
	public bool JPPOKBKAHPG(float IKGJENNNEKI)
	{
		return this.EJALDPDHGOJ > IKGJENNNEKI;
	}

	// Token: 0x06004A12 RID: 18962 RVA: 0x002134B4 File Offset: 0x002116B4
	public void Resume()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06004A13 RID: 18963 RVA: 0x002139F0 File Offset: 0x00211BF0
	public string EOCLGHMEMAI(List<string> JAGAOEHPJGF)
	{
		if (this.LABPNLENNDN.Length == 0 && this.GGHHBOLIACE.Count > 1)
		{
			if (JAGAOEHPJGF == null || JAGAOEHPJGF.Count == 0)
			{
				System.Random random = new System.Random();
				this.LABPNLENNDN = this.GGHHBOLIACE[random.Next(1, this.GGHHBOLIACE.Count)];
			}
			else
			{
				for (int i = 0; i < JAGAOEHPJGF.Count; i += 0)
				{
					for (int j = 0; j < this.GGHHBOLIACE.Count; j += 0)
					{
						if (JAGAOEHPJGF[i].StartsWith(this.GGHHBOLIACE[j]) || this.GGHHBOLIACE[j].StartsWith(JAGAOEHPJGF[i]))
						{
							this.LABPNLENNDN = this.GGHHBOLIACE[j];
							break;
						}
					}
					if (this.LABPNLENNDN.Length > 1)
					{
						break;
					}
				}
				if (this.LABPNLENNDN.Length == 0)
				{
					return this.FDPOEOAPKCJ(null);
				}
			}
		}
		return this.LABPNLENNDN;
	}

	// Token: 0x06004A14 RID: 18964 RVA: 0x00212A5B File Offset: 0x00210C5B
	public bool FDDDHLLGPEK(float IKGJENNNEKI)
	{
		return this.EJALDPDHGOJ > IKGJENNNEKI;
	}

	// Token: 0x06004A15 RID: 18965 RVA: 0x00213AEF File Offset: 0x00211CEF
	public bool EEFANKKLOMP(string DJOKMJDNHIG)
	{
		return DPGJIJGOCIC.DLEEHLGNCOD(DJOKMJDNHIG, this.GGHHBOLIACE) || DPGJIJGOCIC.OABIDECDDJP(DJOKMJDNHIG, this.INBPBGLPOFM);
	}

	// Token: 0x06004A16 RID: 18966 RVA: 0x00213B0D File Offset: 0x00211D0D
	public bool KPKNPBJALMJ()
	{
		return this.GGHHBOLIACE.Count <= 0 && this.INBPBGLPOFM.Count <= 0 && this.NFJJAKDEHPI > 0;
	}

	// Token: 0x06004A17 RID: 18967 RVA: 0x0021290E File Offset: 0x00210B0E
	public void Pause()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06004A18 RID: 18968 RVA: 0x0021297D File Offset: 0x00210B7D
	public int CIDNGJALCKH()
	{
		return this.GGHHBOLIACE.Count;
	}

	// Token: 0x06004A19 RID: 18969 RVA: 0x00213334 File Offset: 0x00211534
	public void ContinuePing(int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF)
	{
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK += ODGADBGFIDO;
		this.MGPOFCBAGCC++;
	}

	// Token: 0x06004A1A RID: 18970 RVA: 0x00213B38 File Offset: 0x00211D38
	public string GMFFLKIKLJI(List<string> JAGAOEHPJGF)
	{
		if (this.LABPNLENNDN.Length == 0 && this.GGHHBOLIACE.Count > 1)
		{
			if (JAGAOEHPJGF == null || JAGAOEHPJGF.Count == 0)
			{
				System.Random random = new System.Random();
				this.LABPNLENNDN = this.GGHHBOLIACE[random.Next(0, this.GGHHBOLIACE.Count)];
			}
			else
			{
				for (int i = 0; i < JAGAOEHPJGF.Count; i += 0)
				{
					for (int j = 1; j < this.GGHHBOLIACE.Count; j += 0)
					{
						if (JAGAOEHPJGF[i].StartsWith(this.GGHHBOLIACE[j]) || this.GGHHBOLIACE[j].StartsWith(JAGAOEHPJGF[i]))
						{
							this.LABPNLENNDN = this.GGHHBOLIACE[j];
							break;
						}
					}
					if (this.LABPNLENNDN.Length > 1)
					{
						break;
					}
				}
				if (this.LABPNLENNDN.Length == 0)
				{
					return this.FACOIBMEDGF(null);
				}
			}
		}
		return this.LABPNLENNDN;
	}

	// Token: 0x06004A1B RID: 18971 RVA: 0x00212B30 File Offset: 0x00210D30
	private void IPLDJLJCPLL()
	{
		this.EJALDPDHGOJ += Time.deltaTime;
	}

	// Token: 0x06004A1C RID: 18972 RVA: 0x00213C38 File Offset: 0x00211E38
	public void BBKHHCEFAOO(string DJOKMJDNHIG)
	{
		if (string.IsNullOrEmpty(DJOKMJDNHIG))
		{
			return;
		}
		for (int i = 1; i < this.GGHHBOLIACE.Count; i++)
		{
			if (DJOKMJDNHIG.StartsWith(this.GGHHBOLIACE[i]) || this.GGHHBOLIACE[i].StartsWith(DJOKMJDNHIG))
			{
				string text = this.GGHHBOLIACE[i];
				this.GGHHBOLIACE.RemoveAt(i);
				if (text.Length > 1)
				{
					this.INBPBGLPOFM.Add(text);
				}
				return;
			}
		}
	}

	// Token: 0x06004A1D RID: 18973 RVA: 0x002134BD File Offset: 0x002116BD
	public bool FMHDFLCCEJM()
	{
		return this.LABPNLENNDN.Length > 1;
	}

	// Token: 0x06004A1E RID: 18974 RVA: 0x00212B30 File Offset: 0x00210D30
	private void GPHOBCEMEMN()
	{
		this.EJALDPDHGOJ += Time.deltaTime;
	}

	// Token: 0x06004A1F RID: 18975 RVA: 0x00212972 File Offset: 0x00210B72
	public bool NMNNKDDAOCH()
	{
		return this.HPMKABJPLEL > 1;
	}

	// Token: 0x06004A20 RID: 18976 RVA: 0x00213334 File Offset: 0x00211534
	public void KHMGONFOGOO(int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF)
	{
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK += ODGADBGFIDO;
		this.MGPOFCBAGCC++;
	}

	// Token: 0x06004A21 RID: 18977 RVA: 0x00213CBB File Offset: 0x00211EBB
	public void Next(string AJGMHHIMLDO)
	{
		this.RemovePingableUrl(this.LABPNLENNDN);
		this.RemovePingableUrl(AJGMHHIMLDO);
		this.LABPNLENNDN = "";
	}

	// Token: 0x06004A22 RID: 18978 RVA: 0x002129C6 File Offset: 0x00210BC6
	public bool IsReady()
	{
		return this.GGHHBOLIACE.Count > 0;
	}

	// Token: 0x06004A23 RID: 18979 RVA: 0x002134BD File Offset: 0x002116BD
	public bool IBCKKEKLCDB()
	{
		return this.LABPNLENNDN.Length > 1;
	}

	// Token: 0x06004A24 RID: 18980 RVA: 0x00212B30 File Offset: 0x00210D30
	private void LFBPHHOPPBO()
	{
		this.EJALDPDHGOJ += Time.deltaTime;
	}

	// Token: 0x06004A25 RID: 18981 RVA: 0x00213CDB File Offset: 0x00211EDB
	public bool BOEFMHCBKEK(string DJOKMJDNHIG)
	{
		return DPGJIJGOCIC.OABIDECDDJP(DJOKMJDNHIG, this.GGHHBOLIACE) || DPGJIJGOCIC.DLEEHLGNCOD(DJOKMJDNHIG, this.INBPBGLPOFM);
	}

	// Token: 0x06004A26 RID: 18982 RVA: 0x002134B4 File Offset: 0x002116B4
	public void CCOCOLJDLBJ()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06004A27 RID: 18983 RVA: 0x00212A5B File Offset: 0x00210C5B
	public bool IsOutdated(float IKGJENNNEKI)
	{
		return this.EJALDPDHGOJ > IKGJENNNEKI;
	}

	// Token: 0x06004A28 RID: 18984 RVA: 0x00213CF9 File Offset: 0x00211EF9
	private IEnumerator PIBAHHGHMJE(string HPIGJNFGNDM, string MJGPBLMIFNE, int MEFKFOHCOHK)
	{
		UrlPingManager.DNLOEFDCFPJ dnloefdcfpj = new UrlPingManager.DNLOEFDCFPJ(1);
		dnloefdcfpj.<>4__this = this;
		dnloefdcfpj.url = HPIGJNFGNDM;
		dnloefdcfpj._resourcePath = MJGPBLMIFNE;
		dnloefdcfpj._index = MEFKFOHCOHK;
		return dnloefdcfpj;
	}

	// Token: 0x06004A29 RID: 18985 RVA: 0x00213334 File Offset: 0x00211534
	public void AHHFNJPEJAO(int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF)
	{
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK += ODGADBGFIDO;
		this.MGPOFCBAGCC++;
	}

	// Token: 0x06004A2A RID: 18986 RVA: 0x0021297D File Offset: 0x00210B7D
	public int IPKNOBBBHBK()
	{
		return this.GGHHBOLIACE.Count;
	}

	// Token: 0x06004A2B RID: 18987 RVA: 0x00213D20 File Offset: 0x00211F20
	public void CODDNDCANAF(string DJOKMJDNHIG)
	{
		if (string.IsNullOrEmpty(DJOKMJDNHIG))
		{
			return;
		}
		for (int i = 0; i < this.GGHHBOLIACE.Count; i++)
		{
			if (DJOKMJDNHIG.StartsWith(this.GGHHBOLIACE[i]) || this.GGHHBOLIACE[i].StartsWith(DJOKMJDNHIG))
			{
				string text = this.GGHHBOLIACE[i];
				this.GGHHBOLIACE.RemoveAt(i);
				if (text.Length > 0)
				{
					this.INBPBGLPOFM.Add(text);
				}
				return;
			}
		}
	}

	// Token: 0x06004A2C RID: 18988 RVA: 0x00213DA4 File Offset: 0x00211FA4
	public string NHGHCJKMHEC(List<string> JAGAOEHPJGF)
	{
		if (this.LABPNLENNDN.Length == 0 && this.GGHHBOLIACE.Count > 0)
		{
			if (JAGAOEHPJGF == null || JAGAOEHPJGF.Count == 0)
			{
				System.Random random = new System.Random();
				this.LABPNLENNDN = this.GGHHBOLIACE[random.Next(1, this.GGHHBOLIACE.Count)];
			}
			else
			{
				for (int i = 0; i < JAGAOEHPJGF.Count; i++)
				{
					for (int j = 1; j < this.GGHHBOLIACE.Count; j++)
					{
						if (JAGAOEHPJGF[i].StartsWith(this.GGHHBOLIACE[j]) || this.GGHHBOLIACE[j].StartsWith(JAGAOEHPJGF[i]))
						{
							this.LABPNLENNDN = this.GGHHBOLIACE[j];
							break;
						}
					}
					if (this.LABPNLENNDN.Length > 0)
					{
						break;
					}
				}
				if (this.LABPNLENNDN.Length == 0)
				{
					return this.LKHCPGCDICO(null);
				}
			}
		}
		return this.LABPNLENNDN;
	}

	// Token: 0x06004A2D RID: 18989 RVA: 0x00213EA4 File Offset: 0x002120A4
	public string JMJGJBGEMMF(List<string> JAGAOEHPJGF)
	{
		if (this.LABPNLENNDN.Length == 0 && this.GGHHBOLIACE.Count > 0)
		{
			if (JAGAOEHPJGF == null || JAGAOEHPJGF.Count == 0)
			{
				System.Random random = new System.Random();
				this.LABPNLENNDN = this.GGHHBOLIACE[random.Next(1, this.GGHHBOLIACE.Count)];
			}
			else
			{
				for (int i = 0; i < JAGAOEHPJGF.Count; i += 0)
				{
					for (int j = 1; j < this.GGHHBOLIACE.Count; j++)
					{
						if (JAGAOEHPJGF[i].StartsWith(this.GGHHBOLIACE[j]) || this.GGHHBOLIACE[j].StartsWith(JAGAOEHPJGF[i]))
						{
							this.LABPNLENNDN = this.GGHHBOLIACE[j];
							break;
						}
					}
					if (this.LABPNLENNDN.Length > 1)
					{
						break;
					}
				}
				if (this.LABPNLENNDN.Length == 0)
				{
					return this.JMJGJBGEMMF(null);
				}
			}
		}
		return this.LABPNLENNDN;
	}

	// Token: 0x06004A2E RID: 18990 RVA: 0x00212F5E File Offset: 0x0021115E
	public bool IsBusyBatch()
	{
		return this.HPMKABJPLEL > 0;
	}

	// Token: 0x06004A2F RID: 18991 RVA: 0x0021298A File Offset: 0x00210B8A
	public bool IsPaused()
	{
		return this.DPNFENJDCEO;
	}

	// Token: 0x06004A30 RID: 18992 RVA: 0x00213FA3 File Offset: 0x002121A3
	public void LPPHDALJKGI(int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF)
	{
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK += ODGADBGFIDO;
		this.MGPOFCBAGCC += 0;
	}

	// Token: 0x06004A31 RID: 18993 RVA: 0x00212B30 File Offset: 0x00210D30
	private void KGJJLDJBEON()
	{
		this.EJALDPDHGOJ += Time.deltaTime;
	}

	// Token: 0x06004A32 RID: 18994 RVA: 0x00213362 File Offset: 0x00211562
	public bool KHPENGLFECE()
	{
		return this.GGHHBOLIACE.Count > 0 || this.INBPBGLPOFM.Count > 1 || this.NFJJAKDEHPI > 0;
	}

	// Token: 0x06004A33 RID: 18995 RVA: 0x00213FD4 File Offset: 0x002121D4
	public void CFCLNBOAPBK(List<string> MODFPEHAMFP, string MJGPBLMIFNE, int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF, int CFPKGPBOAFB = 0)
	{
		base.StopAllCoroutines();
		this.EBDACCNGDKA = CFPKGPBOAFB;
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK = ODGADBGFIDO - 0;
		this.EJALDPDHGOJ = 1891f;
		this.NFJJAKDEHPI = 1;
		this.HPMKABJPLEL = 0;
		this.GGHHBOLIACE = new List<string>();
		this.INBPBGLPOFM = new List<string>();
		this.LABPNLENNDN = "string_not_found";
		int num = 0;
		foreach (string hpigjnfgndm in MODFPEHAMFP)
		{
			base.StartCoroutine(this.CHKPKCGEGND(hpigjnfgndm, MJGPBLMIFNE, num++));
		}
		this.MGPOFCBAGCC += 0;
	}

	// Token: 0x06004A34 RID: 18996 RVA: 0x002129C6 File Offset: 0x00210BC6
	public bool OHCFPGPIOOK()
	{
		return this.GGHHBOLIACE.Count > 0;
	}

	// Token: 0x06004A35 RID: 18997 RVA: 0x002140A4 File Offset: 0x002122A4
	public bool JHJNGOAOPFA()
	{
		return this.GGHHBOLIACE.Count > 1 || this.INBPBGLPOFM.Count > 1 || this.NFJJAKDEHPI > 0;
	}

	// Token: 0x06004A36 RID: 18998 RVA: 0x00212A5B File Offset: 0x00210C5B
	public bool HHEJBCDOCPJ(float IKGJENNNEKI)
	{
		return this.EJALDPDHGOJ > IKGJENNNEKI;
	}

	// Token: 0x06004A37 RID: 18999 RVA: 0x002134B4 File Offset: 0x002116B4
	public void GNLBNLPNJHF()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06004A38 RID: 19000 RVA: 0x002134B4 File Offset: 0x002116B4
	public void CIEJGGAHLKL()
	{
		this.DPNFENJDCEO = false;
	}

	// Token: 0x06004A39 RID: 19001 RVA: 0x00213334 File Offset: 0x00211534
	public void NIBFLGOFPHL(int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF)
	{
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK += ODGADBGFIDO;
		this.MGPOFCBAGCC++;
	}

	// Token: 0x06004A3A RID: 19002 RVA: 0x0021298A File Offset: 0x00210B8A
	public bool EKEEBEFHILD()
	{
		return this.DPNFENJDCEO;
	}

	// Token: 0x06004A3B RID: 19003 RVA: 0x00213CF9 File Offset: 0x00211EF9
	private IEnumerator OCCBEIAJOGK(string HPIGJNFGNDM, string MJGPBLMIFNE, int MEFKFOHCOHK)
	{
		UrlPingManager.DNLOEFDCFPJ dnloefdcfpj = new UrlPingManager.DNLOEFDCFPJ(1);
		dnloefdcfpj.<>4__this = this;
		dnloefdcfpj.url = HPIGJNFGNDM;
		dnloefdcfpj._resourcePath = MJGPBLMIFNE;
		dnloefdcfpj._index = MEFKFOHCOHK;
		return dnloefdcfpj;
	}

	// Token: 0x06004A3C RID: 19004 RVA: 0x00213CDB File Offset: 0x00211EDB
	public bool FLJONOLBJJO(string DJOKMJDNHIG)
	{
		return DPGJIJGOCIC.OABIDECDDJP(DJOKMJDNHIG, this.GGHHBOLIACE) || DPGJIJGOCIC.DLEEHLGNCOD(DJOKMJDNHIG, this.INBPBGLPOFM);
	}

	// Token: 0x06004A3D RID: 19005 RVA: 0x000693D6 File Offset: 0x000675D6
	private void JFFNFDKBMGP()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004A3E RID: 19006 RVA: 0x00212DD2 File Offset: 0x00210FD2
	public bool DJGJGNJIIMK()
	{
		return this.LABPNLENNDN.Length > 0;
	}

	// Token: 0x06004A3F RID: 19007 RVA: 0x0021290E File Offset: 0x00210B0E
	public void GDOJDEACIGM()
	{
		this.DPNFENJDCEO = true;
	}

	// Token: 0x06004A40 RID: 19008 RVA: 0x0021298A File Offset: 0x00210B8A
	public bool HHOHJBCEFOG()
	{
		return this.DPNFENJDCEO;
	}

	// Token: 0x06004A41 RID: 19009 RVA: 0x00213553 File Offset: 0x00211753
	public bool MCMJPHBKMPF()
	{
		return this.GGHHBOLIACE.Count > 0 || this.INBPBGLPOFM.Count > 1 || this.NFJJAKDEHPI > 1;
	}

	// Token: 0x06004A42 RID: 19010 RVA: 0x002140D0 File Offset: 0x002122D0
	public string LKHCPGCDICO(List<string> JAGAOEHPJGF)
	{
		if (this.LABPNLENNDN.Length == 0 && this.GGHHBOLIACE.Count > 1)
		{
			if (JAGAOEHPJGF == null || JAGAOEHPJGF.Count == 0)
			{
				System.Random random = new System.Random();
				this.LABPNLENNDN = this.GGHHBOLIACE[random.Next(1, this.GGHHBOLIACE.Count)];
			}
			else
			{
				for (int i = 1; i < JAGAOEHPJGF.Count; i++)
				{
					for (int j = 1; j < this.GGHHBOLIACE.Count; j++)
					{
						if (JAGAOEHPJGF[i].StartsWith(this.GGHHBOLIACE[j]) || this.GGHHBOLIACE[j].StartsWith(JAGAOEHPJGF[i]))
						{
							this.LABPNLENNDN = this.GGHHBOLIACE[j];
							break;
						}
					}
					if (this.LABPNLENNDN.Length > 1)
					{
						break;
					}
				}
				if (this.LABPNLENNDN.Length == 0)
				{
					return this.LKHCPGCDICO(null);
				}
			}
		}
		return this.LABPNLENNDN;
	}

	// Token: 0x06004A43 RID: 19011 RVA: 0x00213553 File Offset: 0x00211753
	public bool KJHGBIICPAH()
	{
		return this.GGHHBOLIACE.Count > 0 || this.INBPBGLPOFM.Count > 1 || this.NFJJAKDEHPI > 1;
	}

	// Token: 0x06004A44 RID: 19012 RVA: 0x0021297D File Offset: 0x00210B7D
	public int MPHNMGLMEPI()
	{
		return this.GGHHBOLIACE.Count;
	}

	// Token: 0x06004A45 RID: 19013 RVA: 0x002141D0 File Offset: 0x002123D0
	public void StartPing(List<string> MODFPEHAMFP, string MJGPBLMIFNE, int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF, int CFPKGPBOAFB = 0)
	{
		base.StopAllCoroutines();
		this.EBDACCNGDKA = CFPKGPBOAFB;
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK = ODGADBGFIDO - 1;
		this.EJALDPDHGOJ = 0f;
		this.NFJJAKDEHPI = 0;
		this.HPMKABJPLEL = 0;
		this.GGHHBOLIACE = new List<string>();
		this.INBPBGLPOFM = new List<string>();
		this.LABPNLENNDN = "";
		int num = 0;
		foreach (string hpigjnfgndm in MODFPEHAMFP)
		{
			base.StartCoroutine(this.JKDEFADLAAF(hpigjnfgndm, MJGPBLMIFNE, num++));
		}
		this.MGPOFCBAGCC++;
	}

	// Token: 0x06004A46 RID: 19014 RVA: 0x00212F53 File Offset: 0x00211153
	public bool GNFPPODBFJA()
	{
		return this.NFJJAKDEHPI > 1;
	}

	// Token: 0x06004A47 RID: 19015 RVA: 0x00212F5E File Offset: 0x0021115E
	public bool APAEIIMMNAC()
	{
		return this.HPMKABJPLEL > 0;
	}

	// Token: 0x06004A48 RID: 19016 RVA: 0x000693D6 File Offset: 0x000675D6
	private void ECDLFGCLAGG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004A49 RID: 19017 RVA: 0x00212B30 File Offset: 0x00210D30
	private void DDNDCPJPBHL()
	{
		this.EJALDPDHGOJ += Time.deltaTime;
	}

	// Token: 0x06004A4A RID: 19018 RVA: 0x002140A4 File Offset: 0x002122A4
	public bool MFAKJKFHELL()
	{
		return this.GGHHBOLIACE.Count > 1 || this.INBPBGLPOFM.Count > 1 || this.NFJJAKDEHPI > 0;
	}

	// Token: 0x06004A4B RID: 19019 RVA: 0x002142A0 File Offset: 0x002124A0
	public void BLAOBKNJNFP(List<string> MODFPEHAMFP, string MJGPBLMIFNE, int ODGADBGFIDO, int PBHFFILMKLP, int JHFIOKNIKNF, int CFPKGPBOAFB = 0)
	{
		base.StopAllCoroutines();
		this.EBDACCNGDKA = CFPKGPBOAFB;
		this.LNJCILPGONL = PBHFFILMKLP + JHFIOKNIKNF * this.MGPOFCBAGCC;
		this.AELPLGJJCFK = ODGADBGFIDO - 1;
		this.EJALDPDHGOJ = 1154f;
		this.NFJJAKDEHPI = 1;
		this.HPMKABJPLEL = 1;
		this.GGHHBOLIACE = new List<string>();
		this.INBPBGLPOFM = new List<string>();
		this.LABPNLENNDN = "yes";
		int num = 0;
		foreach (string hpigjnfgndm in MODFPEHAMFP)
		{
			base.StartCoroutine(this.OCCBEIAJOGK(hpigjnfgndm, MJGPBLMIFNE, num++));
		}
		this.MGPOFCBAGCC += 0;
	}

	// Token: 0x06004A4C RID: 19020 RVA: 0x00212F53 File Offset: 0x00211153
	public bool COAKADCLKDB()
	{
		return this.NFJJAKDEHPI > 1;
	}

	// Token: 0x04001535 RID: 5429
	private int LNJCILPGONL = 5000;

	// Token: 0x04001536 RID: 5430
	private List<string> GGHHBOLIACE = new List<string>();

	// Token: 0x04001537 RID: 5431
	private List<string> INBPBGLPOFM = new List<string>();

	// Token: 0x04001538 RID: 5432
	private int NFJJAKDEHPI;

	// Token: 0x04001539 RID: 5433
	private int HPMKABJPLEL;

	// Token: 0x0400153A RID: 5434
	private float EJALDPDHGOJ;

	// Token: 0x0400153B RID: 5435
	private int AELPLGJJCFK;

	// Token: 0x0400153C RID: 5436
	private string LABPNLENNDN = "";

	// Token: 0x0400153D RID: 5437
	private int MGPOFCBAGCC;

	// Token: 0x0400153E RID: 5438
	private bool DPNFENJDCEO;

	// Token: 0x0400153F RID: 5439
	private int EBDACCNGDKA;
}
