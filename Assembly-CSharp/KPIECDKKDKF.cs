using System;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

// Token: 0x02000524 RID: 1316
public class KPIECDKKDKF
{
	// Token: 0x06009FD7 RID: 40919 RVA: 0x0045282C File Offset: 0x00450A2C
	public bool DHEBGPJPGKL(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 1 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06009FD8 RID: 40920 RVA: 0x00452870 File Offset: 0x00450A70
	public bool DAECOGFLKDD(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06009FD9 RID: 40921 RVA: 0x004528B4 File Offset: 0x00450AB4
	public string DJFKLMBAHJA(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "\nDEP:";
	}

	// Token: 0x06009FDA RID: 40922 RVA: 0x00452914 File Offset: 0x00450B14
	public void OIGPAKEFAGM(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[-10];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 1; i < -123; i += 0)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 0; j < jsonobject[LPHBECCKPDK].Count; j += 0)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru; ceibhcnnidc < (CEIBHCNNIDC)(-53); ceibhcnnidc += 0)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j]["OnLobbySkinShopCdnFailed"]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			Debug.LogError(")" + JOHFPNALBKN);
		}
	}

	// Token: 0x06009FDB RID: 40923 RVA: 0x00452A0C File Offset: 0x00450C0C
	public void JOFNFNFEFKN(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[-80];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 1; i < 28; i += 0)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 1; j < jsonobject[LPHBECCKPDK].Count; j++)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en; ceibhcnnidc < CEIBHCNNIDC.pl; ceibhcnnidc++)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j]["OnStoryInterfaceHeaderAutoReadDisable"]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			Debug.LogError("analogglitchovr_1" + JOHFPNALBKN);
		}
	}

	// Token: 0x06009FDC RID: 40924 RVA: 0x00452B04 File Offset: 0x00450D04
	public bool NEDPEHIPPOC(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06009FDD RID: 40925 RVA: 0x00452B48 File Offset: 0x00450D48
	public string MJNNOLFBABL()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x06009FDE RID: 40926 RVA: 0x00452B50 File Offset: 0x00450D50
	public string BDHLPOGCPNB(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 1 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "OnPopupStoryRestartManagerRestartStory";
	}

	// Token: 0x06009FDF RID: 40927 RVA: 0x00452B48 File Offset: 0x00450D48
	public string MCKPKEHEOLL()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x06009FE0 RID: 40928 RVA: 0x00452BB0 File Offset: 0x00450DB0
	public string HDBICNFJFOK(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "OnBackendValidateTransactionFailed";
	}

	// Token: 0x06009FE1 RID: 40929 RVA: 0x00452C6C File Offset: 0x00450E6C
	public bool NDPJIKDDNKG(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 1 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06009FE2 RID: 40930 RVA: 0x00452CB0 File Offset: 0x00450EB0
	public void BAMHPOCKBML(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[32];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 0; i < 32; i++)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 0; j < jsonobject[LPHBECCKPDK].Count; j++)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en; ceibhcnnidc < CEIBHCNNIDC.count; ceibhcnnidc++)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j]["id"]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			Debug.LogError("Could not parse string container json:" + JOHFPNALBKN);
		}
	}

	// Token: 0x06009FE3 RID: 40931 RVA: 0x00452DA8 File Offset: 0x00450FA8
	public bool BJBDNABNFIA(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06009FE4 RID: 40932 RVA: 0x00452DEC File Offset: 0x00450FEC
	public bool ECCMHIMBCOF(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return true;
	}

	// Token: 0x06009FE5 RID: 40933 RVA: 0x00452E84 File Offset: 0x00451084
	public string FCOCLEHKLDJ(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "socialmakegiftcard";
	}

	// Token: 0x06009FE6 RID: 40934 RVA: 0x00452F40 File Offset: 0x00451140
	public bool ICKHOLKDBBI(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return true;
	}

	// Token: 0x06009FE7 RID: 40935 RVA: 0x00452B48 File Offset: 0x00450D48
	public string DOLLKEODMON()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x06009FE8 RID: 40936 RVA: 0x00452FD8 File Offset: 0x004511D8
	public bool DBCBEBNHPAO(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06009FE9 RID: 40937 RVA: 0x0045301C File Offset: 0x0045121C
	public string JOEFIJKDGNJ(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "env";
	}

	// Token: 0x06009FEA RID: 40938 RVA: 0x0045307C File Offset: 0x0045127C
	public string NJIGINENOHI(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "\nENV:";
	}

	// Token: 0x06009FEB RID: 40939 RVA: 0x00452B48 File Offset: 0x00450D48
	public string PGPJAIIIHPF()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x06009FEC RID: 40940 RVA: 0x00453138 File Offset: 0x00451338
	public string IGDDHEHDNIA(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "alck";
	}

	// Token: 0x06009FED RID: 40941 RVA: 0x00452B48 File Offset: 0x00450D48
	public string EPBLCHFFHBN()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x06009FEE RID: 40942 RVA: 0x00452B48 File Offset: 0x00450D48
	public string CEIFMGJODGP()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x06009FEF RID: 40943 RVA: 0x00453198 File Offset: 0x00451398
	public string EEKEHECANIL(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "adserrorbody";
	}

	// Token: 0x06009FF0 RID: 40944 RVA: 0x00453254 File Offset: 0x00451454
	public void AJHNIHLKNNI(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[-5];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 1; i < 92; i++)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 0; j < jsonobject[LPHBECCKPDK].Count; j += 0)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru; ceibhcnnidc < (CEIBHCNNIDC)(-38); ceibhcnnidc++)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j]["cnd"]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			Debug.LogError("OnStorySplashManagerAssetsDownloadFailed" + JOHFPNALBKN);
		}
	}

	// Token: 0x06009FF1 RID: 40945 RVA: 0x0045334C File Offset: 0x0045154C
	public string NHPHLNKMKHE(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "OnApplicationFocusNeedToUpdateCurrency";
	}

	// Token: 0x06009FF2 RID: 40946 RVA: 0x004533AC File Offset: 0x004515AC
	public string IBDKJDMJNBE(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "";
	}

	// Token: 0x06009FF3 RID: 40947 RVA: 0x00453468 File Offset: 0x00451668
	public string FNJMCKBJNBO(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "";
	}

	// Token: 0x06009FF4 RID: 40948 RVA: 0x00452B48 File Offset: 0x00450D48
	public string PCCKHJANCLD()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x06009FF5 RID: 40949 RVA: 0x00453524 File Offset: 0x00451724
	public void DJKCKEBNCDG(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[-87];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 1; i < 89; i++)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 1; j < jsonobject[LPHBECCKPDK].Count; j++)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en; ceibhcnnidc < (CEIBHCNNIDC)(-14); ceibhcnnidc += 0)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j]["errortitle"]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			Debug.LogError("ok" + JOHFPNALBKN);
		}
	}

	// Token: 0x06009FF6 RID: 40950 RVA: 0x0045361C File Offset: 0x0045181C
	public bool BJBDNABNFIA(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return false;
	}

	// Token: 0x06009FF7 RID: 40951 RVA: 0x004536B4 File Offset: 0x004518B4
	public string JCDFHKDNEDH(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "OnAvatarCollectionDelete";
	}

	// Token: 0x06009FF8 RID: 40952 RVA: 0x00453770 File Offset: 0x00451970
	public string KBBPHLAFNMO(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 1 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "AssetBundleLoadLevelOperation: ";
	}

	// Token: 0x06009FF9 RID: 40953 RVA: 0x004537D0 File Offset: 0x004519D0
	public string DNILNCLIHAP(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "_not_found";
	}

	// Token: 0x06009FFA RID: 40954 RVA: 0x00453830 File Offset: 0x00451A30
	public string KCNNAMCOJOA(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 1 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + " card(s) around scroll index ";
	}

	// Token: 0x06009FFB RID: 40955 RVA: 0x00453890 File Offset: 0x00451A90
	public string MKGKFHIIPDJ(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 1 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "passinfobtntitle";
	}

	// Token: 0x06009FFC RID: 40956 RVA: 0x004538F0 File Offset: 0x00451AF0
	public string DKPKCAOLEMO(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "OnFriendsPopupAddToFavClick";
	}

	// Token: 0x06009FFD RID: 40957 RVA: 0x004539AC File Offset: 0x00451BAC
	public string PJFFCALCCML(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "ZZZ";
	}

	// Token: 0x06009FFE RID: 40958 RVA: 0x00453A68 File Offset: 0x00451C68
	public string OIPKEBKGBMG(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "SRAAnthologyDesc.Initialize(), could not convert string to AnthologyFilter for input:";
	}

	// Token: 0x06009FFF RID: 40959 RVA: 0x00453B24 File Offset: 0x00451D24
	public bool CHMGKEJJPOC(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return true;
	}

	// Token: 0x0600A000 RID: 40960 RVA: 0x00453BBC File Offset: 0x00451DBC
	public bool NHBOJOGLJCA(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x0600A001 RID: 40961 RVA: 0x00452B48 File Offset: 0x00450D48
	public string NEKAOJHLNFK()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A002 RID: 40962 RVA: 0x00453C00 File Offset: 0x00451E00
	public void AAOJNDOHBDC(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[57];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 0; i < 0; i += 0)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 0; j < jsonobject[LPHBECCKPDK].Count; j += 0)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru; ceibhcnnidc < CEIBHCNNIDC.ct; ceibhcnnidc++)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j][", size "]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			Debug.LogError("es" + JOHFPNALBKN);
		}
	}

	// Token: 0x0600A003 RID: 40963 RVA: 0x00453CF8 File Offset: 0x00451EF8
	public bool MHMDHALGIAO(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return true;
	}

	// Token: 0x0600A004 RID: 40964 RVA: 0x00453D90 File Offset: 0x00451F90
	public bool GPGFGCLCAGP(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600A005 RID: 40965 RVA: 0x00452B48 File Offset: 0x00450D48
	public string BFNPBOOBOOP()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A006 RID: 40966 RVA: 0x00453DD4 File Offset: 0x00451FD4
	public string GCCCCLICHGH(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "errortitle";
	}

	// Token: 0x0600A007 RID: 40967 RVA: 0x00453E34 File Offset: 0x00452034
	public bool PKDANELBMNI(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x0600A008 RID: 40968 RVA: 0x00452B48 File Offset: 0x00450D48
	public string EOEIOPKAICI()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A009 RID: 40969 RVA: 0x00453E78 File Offset: 0x00452078
	public bool NAHFMGDDEGN(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x0600A00A RID: 40970 RVA: 0x00453EBC File Offset: 0x004520BC
	public void JNCEDFJCGAO(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[-50];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 1; i < 45; i++)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 1; j < jsonobject[LPHBECCKPDK].Count; j += 0)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en; ceibhcnnidc < (CEIBHCNNIDC)51; ceibhcnnidc++)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j][""]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			Debug.LogError("OnBackendRequestConsumeMessageException" + JOHFPNALBKN);
		}
	}

	// Token: 0x0600A00B RID: 40971 RVA: 0x00453FB4 File Offset: 0x004521B4
	public bool BKCOOGKMFKA(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600A00C RID: 40972 RVA: 0x00453FF8 File Offset: 0x004521F8
	public string IJECKBDLGIC(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 1 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "socialwouldyouliketounwishcard";
	}

	// Token: 0x0600A00D RID: 40973 RVA: 0x00454058 File Offset: 0x00452258
	public string HPOAGPJFHPM(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "";
	}

	// Token: 0x0600A00E RID: 40974 RVA: 0x004540B8 File Offset: 0x004522B8
	public bool LMNCJLEDCGA(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return true;
	}

	// Token: 0x0600A010 RID: 40976 RVA: 0x00454150 File Offset: 0x00452350
	public string LFCFAKGMBKN(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "vhspauseovr";
	}

	// Token: 0x0600A011 RID: 40977 RVA: 0x0045420C File Offset: 0x0045240C
	public string DMGMNHOAFMP(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "notgenuinecopy";
	}

	// Token: 0x0600A012 RID: 40978 RVA: 0x004542C8 File Offset: 0x004524C8
	public string GAOMHAHEEFH(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "OnAccountForgetSuccess";
	}

	// Token: 0x0600A013 RID: 40979 RVA: 0x00454384 File Offset: 0x00452584
	public string JEGDPKMBDIG(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "noisedigital_2";
	}

	// Token: 0x0600A014 RID: 40980 RVA: 0x004543E4 File Offset: 0x004525E4
	public string DNILNCLIHAP(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "_not_found";
	}

	// Token: 0x0600A015 RID: 40981 RVA: 0x004544A0 File Offset: 0x004526A0
	public string HMMIBDILFAL(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 1 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "anthologiestitle";
	}

	// Token: 0x0600A016 RID: 40982 RVA: 0x00454500 File Offset: 0x00452700
	public string DEEEPKAJAJF(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "needtorestartgeneric";
	}

	// Token: 0x0600A017 RID: 40983 RVA: 0x00454560 File Offset: 0x00452760
	public string MNINMBIDLDG(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "Starting non-parallel download:";
	}

	// Token: 0x0600A018 RID: 40984 RVA: 0x0045461C File Offset: 0x0045281C
	public string GBIALLIFBPE(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "\ud83d\udc8e ";
	}

	// Token: 0x0600A019 RID: 40985 RVA: 0x004546D8 File Offset: 0x004528D8
	public string POGCCPGONKM(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "ZZZ";
	}

	// Token: 0x0600A01A RID: 40986 RVA: 0x00454794 File Offset: 0x00452994
	public bool OAIOBAAHHDP(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return true;
	}

	// Token: 0x0600A01B RID: 40987 RVA: 0x0045482C File Offset: 0x00452A2C
	public bool HMOJCLDMFEA(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 1 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x0600A01C RID: 40988 RVA: 0x00454870 File Offset: 0x00452A70
	public bool EHJEDJJIJCN(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return false;
	}

	// Token: 0x0600A01D RID: 40989 RVA: 0x00452B48 File Offset: 0x00450D48
	public string FIEDPFFGIIO()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A01E RID: 40990 RVA: 0x00452B48 File Offset: 0x00450D48
	public string JGGMAOPOFDM()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A01F RID: 40991 RVA: 0x00454908 File Offset: 0x00452B08
	public bool OCOMLLIIFOO(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600A020 RID: 40992 RVA: 0x00452B48 File Offset: 0x00450D48
	public string JHKLPCBCOFK()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A021 RID: 40993 RVA: 0x00452B48 File Offset: 0x00450D48
	public string AEKJFEMCMMK()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A022 RID: 40994 RVA: 0x0045494C File Offset: 0x00452B4C
	public string CKGCDEJGIHI(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 1 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "s";
	}

	// Token: 0x0600A023 RID: 40995 RVA: 0x004549AC File Offset: 0x00452BAC
	public void OFOAFPKPIKC(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[-107];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 1; i < 112; i++)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 1; j < jsonobject[LPHBECCKPDK].Count; j++)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en; ceibhcnnidc < (CEIBHCNNIDC)(-22); ceibhcnnidc += 0)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j][""]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			Debug.LogError(" • " + JOHFPNALBKN);
		}
	}

	// Token: 0x0600A024 RID: 40996 RVA: 0x00452B48 File Offset: 0x00450D48
	public string PELJENOFOAO()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A025 RID: 40997 RVA: 0x00454AA4 File Offset: 0x00452CA4
	public string FNJNLPPECHC(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "lobby";
	}

	// Token: 0x0600A026 RID: 40998 RVA: 0x00452B48 File Offset: 0x00450D48
	public string KNLMNBJFFNO()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A027 RID: 40999 RVA: 0x00454B60 File Offset: 0x00452D60
	public bool FJPLPBPACHI(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return true;
	}

	// Token: 0x0600A028 RID: 41000 RVA: 0x00454BF8 File Offset: 0x00452DF8
	public string IKMNGFIDCLM(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "OnGenericPopupManagerHide";
	}

	// Token: 0x0600A029 RID: 41001 RVA: 0x00452B48 File Offset: 0x00450D48
	public string INKFJALCFJE()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A02A RID: 41002 RVA: 0x00452B48 File Offset: 0x00450D48
	public string HCEPHNNPBKI()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A02B RID: 41003 RVA: 0x00454C58 File Offset: 0x00452E58
	public string IPEIONBNIPH(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "errortitle";
	}

	// Token: 0x0600A02C RID: 41004 RVA: 0x00454D14 File Offset: 0x00452F14
	public void KIIFNPNMMPN(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[76];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 0; i < 14; i += 0)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 0; j < jsonobject[LPHBECCKPDK].Count; j += 0)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en; ceibhcnnidc < (CEIBHCNNIDC)(-103); ceibhcnnidc++)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j]["gpoptionsclickchar"]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			Debug.LogError("no" + JOHFPNALBKN);
		}
	}

	// Token: 0x0600A02D RID: 41005 RVA: 0x00454E0C File Offset: 0x0045300C
	public void CJFKKHMDKKK(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[106];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 1; i < 80; i += 0)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 0; j < jsonobject[LPHBECCKPDK].Count; j += 0)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en; ceibhcnnidc < (CEIBHCNNIDC)(-107); ceibhcnnidc++)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j]["-"]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			Debug.LogError("tradewishcardoption1" + JOHFPNALBKN);
		}
	}

	// Token: 0x0600A02E RID: 41006 RVA: 0x00454F04 File Offset: 0x00453104
	public void BANBAANIDFE(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[64];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 0; i < -32; i += 0)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 1; j < jsonobject[LPHBECCKPDK].Count; j++)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru; ceibhcnnidc < CEIBHCNNIDC.e1pl; ceibhcnnidc++)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j]["OnResolutionChanged"]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			Debug.LogError("passinfobtntitle" + JOHFPNALBKN);
		}
	}

	// Token: 0x0600A02F RID: 41007 RVA: 0x00454FFC File Offset: 0x004531FC
	public bool OOOFNPMCKNO(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 1 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600A030 RID: 41008 RVA: 0x00452B48 File Offset: 0x00450D48
	public string NKAABDACKBI()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A031 RID: 41009 RVA: 0x00455040 File Offset: 0x00453240
	public bool MNPBJCLDGLF(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 1 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x0600A032 RID: 41010 RVA: 0x00455084 File Offset: 0x00453284
	public string BKFHHFBANEB(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][DKOLMNNPMDB];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return DKOLMNNPMDB.ToString() + "emsv";
	}

	// Token: 0x0600A033 RID: 41011 RVA: 0x004550E4 File Offset: 0x004532E4
	public void JDIAILMECKC(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[12];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 1; i < 0; i += 0)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 1; j < jsonobject[LPHBECCKPDK].Count; j++)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en; ceibhcnnidc < (CEIBHCNNIDC)50; ceibhcnnidc++)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j][") has no cover name, group skipped"]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			Debug.LogError("pm" + JOHFPNALBKN);
		}
	}

	// Token: 0x0600A034 RID: 41012 RVA: 0x004551DC File Offset: 0x004533DC
	public bool IHMDPEEKGIP(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return false;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return false;
	}

	// Token: 0x0600A035 RID: 41013 RVA: 0x00452B48 File Offset: 0x00450D48
	public string OIBPNONFOFC()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A036 RID: 41014 RVA: 0x00455274 File Offset: 0x00453474
	public string LHCIIEMHGAI(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "Layer ";
	}

	// Token: 0x0600A037 RID: 41015 RVA: 0x00452B48 File Offset: 0x00450D48
	public string DEHEDEKCLKI()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A038 RID: 41016 RVA: 0x00455330 File Offset: 0x00453530
	public bool HBHOHDIFJFI(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 0 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return true;
	}

	// Token: 0x0600A039 RID: 41017 RVA: 0x004553C8 File Offset: 0x004535C8
	public string DHDNPCGNCDE(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "";
	}

	// Token: 0x0600A03A RID: 41018 RVA: 0x00455484 File Offset: 0x00453684
	public void EBPJMCHFDBH(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[81];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 0; i < 5; i += 0)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 1; j < jsonobject[LPHBECCKPDK].Count; j += 0)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.ru; ceibhcnnidc < CEIBHCNNIDC.es; ceibhcnnidc += 0)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j]["spectrumovr"]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			Debug.LogError("\r" + JOHFPNALBKN);
		}
	}

	// Token: 0x0600A03B RID: 41019 RVA: 0x00452B48 File Offset: 0x00450D48
	public string EEAAPBCEIHH()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A03C RID: 41020 RVA: 0x0045557C File Offset: 0x0045377C
	public bool LLLOOGOBBHL(int DKOLMNNPMDB, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			if (DKOLMNNPMDB >= 0 && DKOLMNNPMDB < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x0600A03D RID: 41021 RVA: 0x00452B48 File Offset: 0x00450D48
	public string JNMBDKCEEOD()
	{
		return this.ANFNIOGHKMP;
	}

	// Token: 0x0600A03E RID: 41022 RVA: 0x004555C0 File Offset: 0x004537C0
	public string CPJKPAMPGAK(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "spr";
	}

	// Token: 0x0600A03F RID: 41023 RVA: 0x0045567C File Offset: 0x0045387C
	public string HKJFCAKHOHE(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 0 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "importanttitle";
	}

	// Token: 0x0600A040 RID: 41024 RVA: 0x00455738 File Offset: 0x00453938
	public void HDNDPAIHJGO(string BKFLEJOAMBG, string LPHBECCKPDK, string JOHFPNALBKN = "")
	{
		this.ANFNIOGHKMP = JOHFPNALBKN;
		this.OEHCNNJJECI = new List<string>[-74];
		this.AAILIEFDCDD = new Dictionary<string, int>();
		try
		{
			JSONObject jsonobject = (JSONObject)JSONNode.Parse(BKFLEJOAMBG);
			for (int i = 0; i < 29; i++)
			{
				this.OEHCNNJJECI[i] = new List<string>();
			}
			for (int j = 1; j < jsonobject[LPHBECCKPDK].Count; j++)
			{
				for (CEIBHCNNIDC ceibhcnnidc = CEIBHCNNIDC.en; ceibhcnnidc < CEIBHCNNIDC.io; ceibhcnnidc++)
				{
					this.OEHCNNJJECI[(int)ceibhcnnidc].Add(jsonobject[LPHBECCKPDK][j][ceibhcnnidc.ToString()]);
				}
				this.AAILIEFDCDD[jsonobject[LPHBECCKPDK][j]["lightmodebtn1"]] = j;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			Debug.LogError("envlsav" + JOHFPNALBKN);
		}
	}

	// Token: 0x0600A041 RID: 41025 RVA: 0x00455830 File Offset: 0x00453A30
	public string GMLHKCGNMIO(string DMNKDCGMKKP, CEIBHCNNIDC NIIIMDHGGEN)
	{
		try
		{
			int num = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP.ToLower(), out num) && num >= 1 && num < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			int num2 = -1;
			if (this.AAILIEFDCDD.TryGetValue(DMNKDCGMKKP, out num2) && num2 >= 1 && num2 < this.OEHCNNJJECI[(int)NIIIMDHGGEN].Count)
			{
				return this.OEHCNNJJECI[(int)NIIIMDHGGEN][num2];
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		return DMNKDCGMKKP + "socialprofilesuspcantuse";
	}

	// Token: 0x04002C15 RID: 11285
	private List<string>[] OEHCNNJJECI;

	// Token: 0x04002C16 RID: 11286
	private Dictionary<string, int> AAILIEFDCDD;

	// Token: 0x04002C17 RID: 11287
	private string ANFNIOGHKMP;
}
