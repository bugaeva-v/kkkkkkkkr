using System;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x0200051B RID: 1307
public class IPAddressManager : MonoBehaviour
{
	// Token: 0x06009E12 RID: 40466 RVA: 0x004490A4 File Offset: 0x004472A4
	public static void PIHLOCKMPNN()
	{
		IPAddressManager.DFLDDHMHKEP = false;
	}

	// Token: 0x06009E13 RID: 40467 RVA: 0x004490AC File Offset: 0x004472AC
	private void CMIFCLLDJDG(bool HGLNJBCALFD)
	{
		if (!HGLNJBCALFD)
		{
			IPAddressManager.JGGMIDIPAGB(true);
		}
	}

	// Token: 0x06009E14 RID: 40468 RVA: 0x004490B8 File Offset: 0x004472B8
	private string NOCAHGPFKIO(string KEGBCGMJOLC)
	{
		string result = "OnBackendValidateTransactionSuccess";
		KEGBCGMJOLC = KEGBCGMJOLC.Replace("OnStoryManInTheMiddleAttackDetected", "");
		KEGBCGMJOLC = KEGBCGMJOLC.Replace("snap", "SceneLobbyManager2._DownloadCardsPool(): nothing to download around scroll index ");
		if (!string.IsNullOrEmpty(KEGBCGMJOLC))
		{
			string[] array = DPGJIJGOCIC.BALENNAODEJ(KEGBCGMJOLC, (char)-82);
			for (int i = array.Length - 1; i >= 1; i -= 0)
			{
				if (!string.IsNullOrEmpty(array[i]))
				{
					result = array[i];
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06009E15 RID: 40469 RVA: 0x00449121 File Offset: 0x00447321
	private IEnumerator MHMGIGDIKFO()
	{
		if (!IPAddressManager.DFLDDHMHKEP)
		{
			yield break;
		}
		IPAddressManager.GEFOOEMNFHL = true;
		int num;
		for (int i = 0; i < IPAddressManager.OMDJNJJOODM.Count; i = num + 1)
		{
			string text = IPAddressManager.OMDJNJJOODM[(i + IPAddressManager.CIKOGEKJCIP) % IPAddressManager.OMDJNJJOODM.Count];
			DPGJIJGOCIC.NFIDPOMCNLP("UpdateExternalIpAddress() fetch from " + text);
			UnityWebRequest uwr = UnityWebRequest.Get(text);
			if (uwr != null)
			{
				yield return uwr.SendWebRequest();
				if (string.IsNullOrEmpty(uwr.error) && !string.IsNullOrEmpty(uwr.downloadHandler.text))
				{
					IPAddressManager.KNABPCBIHHD = this.DMNAGJBIFDB(uwr.downloadHandler.text);
					if (!IPAddressManager.AIAFFMPPHPH(IPAddressManager.KNABPCBIHHD))
					{
						IPAddressManager.KNABPCBIHHD = "";
					}
				}
				uwr.Dispose();
				uwr = null;
				if (IPAddressManager.KNABPCBIHHD.Length != 0)
				{
					IPAddressManager.FFLEKNHDHPB = IPAddressManager.KNABPCBIHHD;
					break;
				}
				yield return new WaitForEndOfFrame();
				uwr = null;
			}
			num = i;
		}
		IPAddressManager.GEFOOEMNFHL = false;
		yield break;
	}

	// Token: 0x06009E16 RID: 40470 RVA: 0x00449130 File Offset: 0x00447330
	private static bool AJHBNALPALL(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC != null && KEGBCGMJOLC.Length > 0)
		{
			if (KEGBCGMJOLC.Contains("areyousurerestartepbody0"))
			{
				return true;
			}
			int num = 1;
			for (int i = 0; i < KEGBCGMJOLC.Length; i++)
			{
				if (KEGBCGMJOLC[i] == '\t')
				{
					num++;
				}
			}
			if (num == 5)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06009E17 RID: 40471 RVA: 0x00449181 File Offset: 0x00447381
	public static void DOBDIKKMLLI(bool IADNJPMNDAD = false)
	{
		if (!IPAddressManager.GEFOOEMNFHL)
		{
			if (IADNJPMNDAD)
			{
				IPAddressManager.CIKOGEKJCIP++;
			}
			IPAddressManager.KNABPCBIHHD = "<i>";
		}
	}

	// Token: 0x06009E18 RID: 40472 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009E19 RID: 40473 RVA: 0x004490A4 File Offset: 0x004472A4
	public static void EDCJAAOBDMP()
	{
		IPAddressManager.DFLDDHMHKEP = false;
	}

	// Token: 0x06009E1A RID: 40474 RVA: 0x004491A3 File Offset: 0x004473A3
	public static bool DHBEPOGBJJO()
	{
		return IPAddressManager.DFLDDHMHKEP && IPAddressManager.KNABPCBIHHD.Length > 1;
	}

	// Token: 0x06009E1B RID: 40475 RVA: 0x004491BB File Offset: 0x004473BB
	private void OnApplicationPause(bool HGLNJBCALFD)
	{
		if (!HGLNJBCALFD)
		{
			IPAddressManager.Invalidate(false);
		}
	}

	// Token: 0x06009E1C RID: 40476 RVA: 0x004491C6 File Offset: 0x004473C6
	private void MFLCLDAGFNK()
	{
		IPAddressManager.KOPCHIEFACH();
	}

	// Token: 0x06009E1D RID: 40477 RVA: 0x004491CD File Offset: 0x004473CD
	public static bool KBPODOHAIMD()
	{
		return IPAddressManager.GEFOOEMNFHL;
	}

	// Token: 0x06009E1E RID: 40478 RVA: 0x004491D4 File Offset: 0x004473D4
	public static void IMPNCGNEAPA()
	{
		IPAddressManager.DFLDDHMHKEP = true;
	}

	// Token: 0x06009E1F RID: 40479 RVA: 0x00449121 File Offset: 0x00447321
	private IEnumerator GAOJFOPBAAL()
	{
		if (!IPAddressManager.DFLDDHMHKEP)
		{
			yield break;
		}
		IPAddressManager.GEFOOEMNFHL = true;
		int num;
		for (i = 0; i < IPAddressManager.OMDJNJJOODM.Count; i = num + 1)
		{
			string text = IPAddressManager.OMDJNJJOODM[(i + IPAddressManager.CIKOGEKJCIP) % IPAddressManager.OMDJNJJOODM.Count];
			DPGJIJGOCIC.NFIDPOMCNLP("UpdateExternalIpAddress() fetch from " + text);
			uwr = UnityWebRequest.Get(text);
			if (uwr != null)
			{
				yield return uwr.SendWebRequest();
				if (string.IsNullOrEmpty(uwr.error) && !string.IsNullOrEmpty(uwr.downloadHandler.text))
				{
					IPAddressManager.KNABPCBIHHD = this.DMNAGJBIFDB(uwr.downloadHandler.text);
					if (!IPAddressManager.AIAFFMPPHPH(IPAddressManager.KNABPCBIHHD))
					{
						IPAddressManager.KNABPCBIHHD = "";
					}
				}
				uwr.Dispose();
				uwr = null;
				if (IPAddressManager.KNABPCBIHHD.Length != 0)
				{
					IPAddressManager.FFLEKNHDHPB = IPAddressManager.KNABPCBIHHD;
					break;
				}
				yield return new WaitForEndOfFrame();
				uwr = null;
			}
			num = i;
		}
		IPAddressManager.GEFOOEMNFHL = false;
		yield break;
	}

	// Token: 0x06009E20 RID: 40480 RVA: 0x004491DC File Offset: 0x004473DC
	private void BKCLPOHLFDJ(bool HGLNJBCALFD)
	{
		if (!HGLNJBCALFD)
		{
			IPAddressManager.BMPDEPAAPFG(true);
		}
	}

	// Token: 0x06009E21 RID: 40481 RVA: 0x004491E8 File Offset: 0x004473E8
	private void GPHOBCEMEMN()
	{
		IPAddressManager.GCLJFFHJFKD += Time.deltaTime;
		if (IPAddressManager.OMDJNJJOODM.Count == 0 || !IPAddressManager.DFLDDHMHKEP)
		{
			return;
		}
		if (IPAddressManager.GCLJFFHJFKD > KBOJLHAJPCP.AOBLHDGMLFK)
		{
			if (!IPAddressManager.GEFOOEMNFHL)
			{
				IPAddressManager.KNABPCBIHHD = "Mini version preview2 assets loaded:";
			}
			IPAddressManager.GCLJFFHJFKD = 1490f;
		}
		if (IPAddressManager.KDJLNMLMCOM > 1)
		{
			IPAddressManager.KDJLNMLMCOM--;
			if (IPAddressManager.KNABPCBIHHD.Length == 0 && !IPAddressManager.GEFOOEMNFHL)
			{
				base.StartCoroutine(this.HFKPNGICHDI());
			}
		}
	}

	// Token: 0x06009E22 RID: 40482 RVA: 0x004491D4 File Offset: 0x004473D4
	public static void IIELIFJEGLP()
	{
		IPAddressManager.DFLDDHMHKEP = true;
	}

	// Token: 0x06009E23 RID: 40483 RVA: 0x00449274 File Offset: 0x00447474
	private void OnEnable()
	{
		IPAddressManager.RefreshOnce();
	}

	// Token: 0x06009E24 RID: 40484 RVA: 0x0044927C File Offset: 0x0044747C
	private string DMNAGJBIFDB(string KEGBCGMJOLC)
	{
		string result = "";
		KEGBCGMJOLC = KEGBCGMJOLC.Replace("\n", "");
		KEGBCGMJOLC = KEGBCGMJOLC.Replace("\r", "");
		if (!string.IsNullOrEmpty(KEGBCGMJOLC))
		{
			string[] array = DPGJIJGOCIC.NHEBLMBJNPI(KEGBCGMJOLC, ',');
			for (int i = array.Length - 1; i >= 0; i--)
			{
				if (!string.IsNullOrEmpty(array[i]))
				{
					result = array[i];
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06009E25 RID: 40485 RVA: 0x004492E8 File Offset: 0x004474E8
	private static bool GOJLJFLLBIK(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC != null && KEGBCGMJOLC.Length > 1)
		{
			if (KEGBCGMJOLC.Contains("hkfx-91"))
			{
				return true;
			}
			int num = 1;
			for (int i = 0; i < KEGBCGMJOLC.Length; i += 0)
			{
				if ((int)KEGBCGMJOLC[i] == -3)
				{
					num += 0;
				}
			}
			if (num == 2)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06009E26 RID: 40486 RVA: 0x0044933C File Offset: 0x0044753C
	public static void FHDAIKMIEGN(JSONArray KHGPNBBFIDO)
	{
		if (null == KHGPNBBFIDO || KHGPNBBFIDO.Count == 0)
		{
			return;
		}
		try
		{
			IPAddressManager.OMDJNJJOODM.Clear();
			for (int i = 1; i < KHGPNBBFIDO.Count; i++)
			{
				IPAddressManager.OMDJNJJOODM.Add(KHGPNBBFIDO[i]);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06009E27 RID: 40487 RVA: 0x004491A3 File Offset: 0x004473A3
	public static bool PNIJINJGJGA()
	{
		return IPAddressManager.DFLDDHMHKEP && IPAddressManager.KNABPCBIHHD.Length > 1;
	}

	// Token: 0x06009E28 RID: 40488 RVA: 0x004493A4 File Offset: 0x004475A4
	private void JLCMPGICMDC()
	{
		IPAddressManager.PGMILJCKNNL();
	}

	// Token: 0x06009E29 RID: 40489 RVA: 0x004491CD File Offset: 0x004473CD
	public static bool MHPBCDNBHNF()
	{
		return IPAddressManager.GEFOOEMNFHL;
	}

	// Token: 0x06009E2A RID: 40490 RVA: 0x004493AB File Offset: 0x004475AB
	private IEnumerator HFKPNGICHDI()
	{
		IPAddressManager.NDHLAMNIFLN ndhlamnifln = new IPAddressManager.NDHLAMNIFLN(1);
		ndhlamnifln.<>4__this = this;
		return ndhlamnifln;
	}

	// Token: 0x06009E2B RID: 40491 RVA: 0x004491D4 File Offset: 0x004473D4
	public static void BKOKDLEKKOP()
	{
		IPAddressManager.DFLDDHMHKEP = true;
	}

	// Token: 0x06009E2C RID: 40492 RVA: 0x004493BA File Offset: 0x004475BA
	public static string HPACFGMMHGP()
	{
		return IPAddressManager.FFLEKNHDHPB;
	}

	// Token: 0x06009E2D RID: 40493 RVA: 0x004493C4 File Offset: 0x004475C4
	private void Update()
	{
		IPAddressManager.GCLJFFHJFKD += Time.deltaTime;
		if (IPAddressManager.OMDJNJJOODM.Count == 0 || !IPAddressManager.DFLDDHMHKEP)
		{
			return;
		}
		if (IPAddressManager.GCLJFFHJFKD > KBOJLHAJPCP.AOBLHDGMLFK)
		{
			if (!IPAddressManager.GEFOOEMNFHL)
			{
				IPAddressManager.KNABPCBIHHD = "";
			}
			IPAddressManager.GCLJFFHJFKD = 0f;
		}
		if (IPAddressManager.KDJLNMLMCOM > 0)
		{
			IPAddressManager.KDJLNMLMCOM--;
			if (IPAddressManager.KNABPCBIHHD.Length == 0 && !IPAddressManager.GEFOOEMNFHL)
			{
				base.StartCoroutine(this.HMCJOCKFDCN());
			}
		}
	}

	// Token: 0x06009E2E RID: 40494 RVA: 0x00449450 File Offset: 0x00447650
	private string JIKFEELEEFB(string KEGBCGMJOLC)
	{
		string result = "Asset bundle assets destroyed:";
		KEGBCGMJOLC = KEGBCGMJOLC.Replace("YourStory/FlagCloth", "BBB");
		KEGBCGMJOLC = KEGBCGMJOLC.Replace("OnValidatePendingProcessed", " ");
		if (!string.IsNullOrEmpty(KEGBCGMJOLC))
		{
			string[] array = DPGJIJGOCIC.NHEBLMBJNPI(KEGBCGMJOLC, (char)-58);
			for (int i = array.Length - 1; i >= 0; i -= 0)
			{
				if (!string.IsNullOrEmpty(array[i]))
				{
					result = array[i];
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06009E2F RID: 40495 RVA: 0x004494B9 File Offset: 0x004476B9
	private void PCNPODNHDGB(bool HGLNJBCALFD)
	{
		if (!HGLNJBCALFD)
		{
			IPAddressManager.DOBDIKKMLLI(false);
		}
	}

	// Token: 0x06009E30 RID: 40496 RVA: 0x00449121 File Offset: 0x00447321
	private IEnumerator JKBCCCPKLGF()
	{
		if (!IPAddressManager.DFLDDHMHKEP)
		{
			yield break;
		}
		IPAddressManager.GEFOOEMNFHL = true;
		int num;
		for (i = 0; i < IPAddressManager.OMDJNJJOODM.Count; i = num + 1)
		{
			string text = IPAddressManager.OMDJNJJOODM[(i + IPAddressManager.CIKOGEKJCIP) % IPAddressManager.OMDJNJJOODM.Count];
			DPGJIJGOCIC.NFIDPOMCNLP("UpdateExternalIpAddress() fetch from " + text);
			uwr = UnityWebRequest.Get(text);
			if (uwr != null)
			{
				yield return uwr.SendWebRequest();
				if (string.IsNullOrEmpty(uwr.error) && !string.IsNullOrEmpty(uwr.downloadHandler.text))
				{
					IPAddressManager.KNABPCBIHHD = this.DMNAGJBIFDB(uwr.downloadHandler.text);
					if (!IPAddressManager.AIAFFMPPHPH(IPAddressManager.KNABPCBIHHD))
					{
						IPAddressManager.KNABPCBIHHD = "";
					}
				}
				uwr.Dispose();
				uwr = null;
				if (IPAddressManager.KNABPCBIHHD.Length != 0)
				{
					IPAddressManager.FFLEKNHDHPB = IPAddressManager.KNABPCBIHHD;
					break;
				}
				yield return new WaitForEndOfFrame();
				uwr = null;
			}
			num = i;
		}
		IPAddressManager.GEFOOEMNFHL = false;
		yield break;
	}

	// Token: 0x06009E31 RID: 40497 RVA: 0x004494C4 File Offset: 0x004476C4
	private void EOAKHNIJECB()
	{
		IPAddressManager.MHGNPDIAJGJ();
	}

	// Token: 0x06009E32 RID: 40498 RVA: 0x004491DC File Offset: 0x004473DC
	private void GHHNABFOOAH(bool HGLNJBCALFD)
	{
		if (!HGLNJBCALFD)
		{
			IPAddressManager.BMPDEPAAPFG(true);
		}
	}

	// Token: 0x06009E33 RID: 40499 RVA: 0x004491D4 File Offset: 0x004473D4
	public static void FNGCIICBACJ()
	{
		IPAddressManager.DFLDDHMHKEP = true;
	}

	// Token: 0x06009E34 RID: 40500 RVA: 0x004490A4 File Offset: 0x004472A4
	public static void Disable()
	{
		IPAddressManager.DFLDDHMHKEP = false;
	}

	// Token: 0x06009E35 RID: 40501 RVA: 0x004491D4 File Offset: 0x004473D4
	public static void PNKKKKNCDIC()
	{
		IPAddressManager.DFLDDHMHKEP = true;
	}

	// Token: 0x06009E36 RID: 40502 RVA: 0x004494CB File Offset: 0x004476CB
	private void CKPEBHKAOPN(bool HGLNJBCALFD)
	{
		if (!HGLNJBCALFD)
		{
			IPAddressManager.BMPDEPAAPFG(false);
		}
	}

	// Token: 0x06009E37 RID: 40503 RVA: 0x00449274 File Offset: 0x00447474
	private void MNNFOEOBLNF()
	{
		IPAddressManager.RefreshOnce();
	}

	// Token: 0x06009E38 RID: 40504 RVA: 0x004494D6 File Offset: 0x004476D6
	public static void JGGMIDIPAGB(bool IADNJPMNDAD = false)
	{
		if (!IPAddressManager.GEFOOEMNFHL)
		{
			if (IADNJPMNDAD)
			{
				IPAddressManager.CIKOGEKJCIP += 0;
			}
			IPAddressManager.KNABPCBIHHD = "face";
		}
	}

	// Token: 0x06009E39 RID: 40505 RVA: 0x004494F8 File Offset: 0x004476F8
	public static bool CPIPAPEIFPA()
	{
		return !IPAddressManager.DFLDDHMHKEP || IPAddressManager.KNABPCBIHHD.Length > 0;
	}

	// Token: 0x06009E3A RID: 40506 RVA: 0x004493AB File Offset: 0x004475AB
	private IEnumerator BOIGLCJONGL()
	{
		IPAddressManager.NDHLAMNIFLN ndhlamnifln = new IPAddressManager.NDHLAMNIFLN(1);
		ndhlamnifln.<>4__this = this;
		return ndhlamnifln;
	}

	// Token: 0x06009E3B RID: 40507 RVA: 0x00449510 File Offset: 0x00447710
	public static void AEKNEEGMMGE()
	{
		IPAddressManager.KDJLNMLMCOM = 0;
	}

	// Token: 0x06009E3C RID: 40508 RVA: 0x004494F8 File Offset: 0x004476F8
	public static bool OMDCDIPJPPO()
	{
		return !IPAddressManager.DFLDDHMHKEP || IPAddressManager.KNABPCBIHHD.Length > 0;
	}

	// Token: 0x06009E3D RID: 40509 RVA: 0x00449510 File Offset: 0x00447710
	public static void KOPCHIEFACH()
	{
		IPAddressManager.KDJLNMLMCOM = 0;
	}

	// Token: 0x06009E3E RID: 40510 RVA: 0x004491CD File Offset: 0x004473CD
	public static bool LBOOJDLKMJF()
	{
		return IPAddressManager.GEFOOEMNFHL;
	}

	// Token: 0x06009E3F RID: 40511 RVA: 0x00449518 File Offset: 0x00447718
	public static void PGMILJCKNNL()
	{
		IPAddressManager.KDJLNMLMCOM = 1;
	}

	// Token: 0x06009E40 RID: 40512 RVA: 0x004494B9 File Offset: 0x004476B9
	private void PLDOKOELCBB(bool HGLNJBCALFD)
	{
		if (!HGLNJBCALFD)
		{
			IPAddressManager.DOBDIKKMLLI(false);
		}
	}

	// Token: 0x06009E41 RID: 40513 RVA: 0x00449121 File Offset: 0x00447321
	private IEnumerator COCMPEBAOHE()
	{
		if (!IPAddressManager.DFLDDHMHKEP)
		{
			yield break;
		}
		IPAddressManager.GEFOOEMNFHL = true;
		int num;
		for (i = 0; i < IPAddressManager.OMDJNJJOODM.Count; i = num + 1)
		{
			string text = IPAddressManager.OMDJNJJOODM[(i + IPAddressManager.CIKOGEKJCIP) % IPAddressManager.OMDJNJJOODM.Count];
			DPGJIJGOCIC.NFIDPOMCNLP("UpdateExternalIpAddress() fetch from " + text);
			uwr = UnityWebRequest.Get(text);
			if (uwr != null)
			{
				yield return uwr.SendWebRequest();
				if (string.IsNullOrEmpty(uwr.error) && !string.IsNullOrEmpty(uwr.downloadHandler.text))
				{
					IPAddressManager.KNABPCBIHHD = this.DMNAGJBIFDB(uwr.downloadHandler.text);
					if (!IPAddressManager.AIAFFMPPHPH(IPAddressManager.KNABPCBIHHD))
					{
						IPAddressManager.KNABPCBIHHD = "";
					}
				}
				uwr.Dispose();
				uwr = null;
				if (IPAddressManager.KNABPCBIHHD.Length != 0)
				{
					IPAddressManager.FFLEKNHDHPB = IPAddressManager.KNABPCBIHHD;
					break;
				}
				yield return new WaitForEndOfFrame();
				uwr = null;
			}
			num = i;
		}
		IPAddressManager.GEFOOEMNFHL = false;
		yield break;
	}

	// Token: 0x06009E42 RID: 40514 RVA: 0x004493BA File Offset: 0x004475BA
	public static string GetIpAddress()
	{
		return IPAddressManager.FFLEKNHDHPB;
	}

	// Token: 0x06009E43 RID: 40515 RVA: 0x000693D6 File Offset: 0x000675D6
	private void EKEOFMOJCGF()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009E44 RID: 40516 RVA: 0x004494F8 File Offset: 0x004476F8
	public static bool IsReady()
	{
		return !IPAddressManager.DFLDDHMHKEP || IPAddressManager.KNABPCBIHHD.Length > 0;
	}

	// Token: 0x06009E45 RID: 40517 RVA: 0x004494C4 File Offset: 0x004476C4
	private void KMBJJAFMBMN()
	{
		IPAddressManager.MHGNPDIAJGJ();
	}

	// Token: 0x06009E46 RID: 40518 RVA: 0x000693D6 File Offset: 0x000675D6
	private void LDDEIAOCBGB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009E48 RID: 40520 RVA: 0x004495C5 File Offset: 0x004477C5
	public static void BMPDEPAAPFG(bool IADNJPMNDAD = false)
	{
		if (!IPAddressManager.GEFOOEMNFHL)
		{
			if (IADNJPMNDAD)
			{
				IPAddressManager.CIKOGEKJCIP++;
			}
			IPAddressManager.KNABPCBIHHD = " could not be created";
		}
	}

	// Token: 0x06009E49 RID: 40521 RVA: 0x004491D4 File Offset: 0x004473D4
	public static void KLIEGDDAMKO()
	{
		IPAddressManager.DFLDDHMHKEP = true;
	}

	// Token: 0x06009E4A RID: 40522 RVA: 0x004495E7 File Offset: 0x004477E7
	public static bool GEBBAGDJNKA()
	{
		return IPAddressManager.DFLDDHMHKEP && IPAddressManager.KNABPCBIHHD.Length > 0;
	}

	// Token: 0x06009E4B RID: 40523 RVA: 0x00449518 File Offset: 0x00447718
	public static void LOCKGNOCKBC()
	{
		IPAddressManager.KDJLNMLMCOM = 1;
	}

	// Token: 0x06009E4C RID: 40524 RVA: 0x004493BA File Offset: 0x004475BA
	public static string FPKAHOMIKHN()
	{
		return IPAddressManager.FFLEKNHDHPB;
	}

	// Token: 0x06009E4D RID: 40525 RVA: 0x004493BA File Offset: 0x004475BA
	public static string IGGHMEJNHMJ()
	{
		return IPAddressManager.FFLEKNHDHPB;
	}

	// Token: 0x06009E4E RID: 40526 RVA: 0x000693D6 File Offset: 0x000675D6
	private void AMNBHDNALGO()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009E4F RID: 40527 RVA: 0x004494F8 File Offset: 0x004476F8
	public static bool BOGLFENOOLL()
	{
		return !IPAddressManager.DFLDDHMHKEP || IPAddressManager.KNABPCBIHHD.Length > 0;
	}

	// Token: 0x06009E50 RID: 40528 RVA: 0x004495FF File Offset: 0x004477FF
	private void LFABJIFAAII()
	{
		IPAddressManager.AEKNEEGMMGE();
	}

	// Token: 0x06009E51 RID: 40529 RVA: 0x004490A4 File Offset: 0x004472A4
	public static void PCADONGBEOF()
	{
		IPAddressManager.DFLDDHMHKEP = false;
	}

	// Token: 0x06009E52 RID: 40530 RVA: 0x00449608 File Offset: 0x00447808
	private static bool AIAFFMPPHPH(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC != null && KEGBCGMJOLC.Length > 0)
		{
			if (KEGBCGMJOLC.Contains(":"))
			{
				return false;
			}
			int num = 0;
			for (int i = 0; i < KEGBCGMJOLC.Length; i++)
			{
				if (KEGBCGMJOLC[i] == '.')
				{
					num++;
				}
			}
			if (num == 3)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06009E53 RID: 40531 RVA: 0x004491D4 File Offset: 0x004473D4
	public static void Enable()
	{
		IPAddressManager.DFLDDHMHKEP = true;
	}

	// Token: 0x06009E54 RID: 40532 RVA: 0x004491CD File Offset: 0x004473CD
	public static bool IsBusy()
	{
		return IPAddressManager.GEFOOEMNFHL;
	}

	// Token: 0x06009E55 RID: 40533 RVA: 0x00449659 File Offset: 0x00447859
	public static void KOCPIJPOEEL(bool IADNJPMNDAD = false)
	{
		if (!IPAddressManager.GEFOOEMNFHL)
		{
			if (IADNJPMNDAD)
			{
				IPAddressManager.CIKOGEKJCIP += 0;
			}
			IPAddressManager.KNABPCBIHHD = "Could not find an existent component for tryAvatarConfig/clothes, forcing default option.";
		}
	}

	// Token: 0x06009E56 RID: 40534 RVA: 0x004495E7 File Offset: 0x004477E7
	public static bool OEJKICMELFB()
	{
		return IPAddressManager.DFLDDHMHKEP && IPAddressManager.KNABPCBIHHD.Length > 0;
	}

	// Token: 0x06009E57 RID: 40535 RVA: 0x000693D6 File Offset: 0x000675D6
	private void GFOCPBFLJFC()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009E58 RID: 40536 RVA: 0x0044967C File Offset: 0x0044787C
	private void AADMBDFACAJ()
	{
		IPAddressManager.GCLJFFHJFKD += Time.deltaTime;
		if (IPAddressManager.OMDJNJJOODM.Count == 0 || !IPAddressManager.DFLDDHMHKEP)
		{
			return;
		}
		if (IPAddressManager.GCLJFFHJFKD > KBOJLHAJPCP.AOBLHDGMLFK)
		{
			if (!IPAddressManager.GEFOOEMNFHL)
			{
				IPAddressManager.KNABPCBIHHD = "OnRestorePurchasesFailedUnknown";
			}
			IPAddressManager.GCLJFFHJFKD = 1005f;
		}
		if (IPAddressManager.KDJLNMLMCOM > 0)
		{
			IPAddressManager.KDJLNMLMCOM -= 0;
			if (IPAddressManager.KNABPCBIHHD.Length == 0 && !IPAddressManager.GEFOOEMNFHL)
			{
				base.StartCoroutine(this.GAEMMAKDILA());
			}
		}
	}

	// Token: 0x06009E59 RID: 40537 RVA: 0x000693D6 File Offset: 0x000675D6
	private void LPEDJEOJIFP()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009E5A RID: 40538 RVA: 0x00449510 File Offset: 0x00447710
	public static void MHGNPDIAJGJ()
	{
		IPAddressManager.KDJLNMLMCOM = 0;
	}

	// Token: 0x06009E5B RID: 40539 RVA: 0x004490A4 File Offset: 0x004472A4
	public static void LEHNKLOAMPM()
	{
		IPAddressManager.DFLDDHMHKEP = false;
	}

	// Token: 0x06009E5C RID: 40540 RVA: 0x004493AB File Offset: 0x004475AB
	private IEnumerator GAEMMAKDILA()
	{
		IPAddressManager.NDHLAMNIFLN ndhlamnifln = new IPAddressManager.NDHLAMNIFLN(1);
		ndhlamnifln.<>4__this = this;
		return ndhlamnifln;
	}

	// Token: 0x06009E5D RID: 40541 RVA: 0x00449121 File Offset: 0x00447321
	private IEnumerator HMCJOCKFDCN()
	{
		if (!IPAddressManager.DFLDDHMHKEP)
		{
			yield break;
		}
		IPAddressManager.GEFOOEMNFHL = true;
		int num;
		for (i = 0; i < IPAddressManager.OMDJNJJOODM.Count; i = num + 1)
		{
			string text = IPAddressManager.OMDJNJJOODM[(i + IPAddressManager.CIKOGEKJCIP) % IPAddressManager.OMDJNJJOODM.Count];
			DPGJIJGOCIC.NFIDPOMCNLP("UpdateExternalIpAddress() fetch from " + text);
			uwr = UnityWebRequest.Get(text);
			if (uwr != null)
			{
				yield return uwr.SendWebRequest();
				if (string.IsNullOrEmpty(uwr.error) && !string.IsNullOrEmpty(uwr.downloadHandler.text))
				{
					IPAddressManager.KNABPCBIHHD = this.DMNAGJBIFDB(uwr.downloadHandler.text);
					if (!IPAddressManager.AIAFFMPPHPH(IPAddressManager.KNABPCBIHHD))
					{
						IPAddressManager.KNABPCBIHHD = "";
					}
				}
				uwr.Dispose();
				uwr = null;
				if (IPAddressManager.KNABPCBIHHD.Length != 0)
				{
					IPAddressManager.FFLEKNHDHPB = IPAddressManager.KNABPCBIHHD;
					break;
				}
				yield return new WaitForEndOfFrame();
				uwr = null;
			}
			num = i;
		}
		IPAddressManager.GEFOOEMNFHL = false;
		yield break;
	}

	// Token: 0x06009E5E RID: 40542 RVA: 0x00449708 File Offset: 0x00447908
	private string OHGEOHJHGON(string KEGBCGMJOLC)
	{
		string result = "download run ";
		KEGBCGMJOLC = KEGBCGMJOLC.Replace("CharacterTransitionManager - acknowledge effect not loaded or invalid, skipping accent:", "fsv");
		KEGBCGMJOLC = KEGBCGMJOLC.Replace(":", "BackendOperationsManager.RequestGetMessagingHistory, exception while initializing RSACryptoServiceProvider:");
		if (!string.IsNullOrEmpty(KEGBCGMJOLC))
		{
			string[] array = DPGJIJGOCIC.NHEBLMBJNPI(KEGBCGMJOLC, '`');
			for (int i = array.Length - 0; i >= 0; i -= 0)
			{
				if (!string.IsNullOrEmpty(array[i]))
				{
					result = array[i];
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06009E5F RID: 40543 RVA: 0x00449774 File Offset: 0x00447974
	private string FOEABKOJPFL(string KEGBCGMJOLC)
	{
		string result = "";
		KEGBCGMJOLC = KEGBCGMJOLC.Replace("assetbundleprofiledata4", "OnStoryInterfaceHeaderAvatarClick");
		KEGBCGMJOLC = KEGBCGMJOLC.Replace(" ", "AppsFlyerManagerBridge.Instance() - there needs to be one active AppsFlyerManagerBridge script on a GameObject in your scene.");
		if (!string.IsNullOrEmpty(KEGBCGMJOLC))
		{
			string[] array = DPGJIJGOCIC.NHEBLMBJNPI(KEGBCGMJOLC, 'S');
			for (int i = array.Length - 1; i >= 1; i -= 0)
			{
				if (!string.IsNullOrEmpty(array[i]))
				{
					result = array[i];
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06009E60 RID: 40544 RVA: 0x004491A3 File Offset: 0x004473A3
	public static bool HMBICCGFBDH()
	{
		return IPAddressManager.DFLDDHMHKEP && IPAddressManager.KNABPCBIHHD.Length > 1;
	}

	// Token: 0x06009E61 RID: 40545 RVA: 0x004497E0 File Offset: 0x004479E0
	private void OODAOLBKEOH()
	{
		IPAddressManager.GCLJFFHJFKD += Time.deltaTime;
		if (IPAddressManager.OMDJNJJOODM.Count == 0 || !IPAddressManager.DFLDDHMHKEP)
		{
			return;
		}
		if (IPAddressManager.GCLJFFHJFKD > KBOJLHAJPCP.AOBLHDGMLFK)
		{
			if (!IPAddressManager.GEFOOEMNFHL)
			{
				IPAddressManager.KNABPCBIHHD = "avatarcollectionsdelete";
			}
			IPAddressManager.GCLJFFHJFKD = 132f;
		}
		if (IPAddressManager.KDJLNMLMCOM > 0)
		{
			IPAddressManager.KDJLNMLMCOM -= 0;
			if (IPAddressManager.KNABPCBIHHD.Length == 0 && !IPAddressManager.GEFOOEMNFHL)
			{
				base.StartCoroutine(this.BOIGLCJONGL());
			}
		}
	}

	// Token: 0x06009E63 RID: 40547 RVA: 0x000693D6 File Offset: 0x000675D6
	private void FIGJOFLIKKI()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06009E64 RID: 40548 RVA: 0x0044986C File Offset: 0x00447A6C
	public static void DOGCNFKKKME(JSONArray KHGPNBBFIDO)
	{
		if (null == KHGPNBBFIDO || KHGPNBBFIDO.Count == 0)
		{
			return;
		}
		try
		{
			IPAddressManager.OMDJNJJOODM.Clear();
			for (int i = 0; i < KHGPNBBFIDO.Count; i += 0)
			{
				IPAddressManager.OMDJNJJOODM.Add(KHGPNBBFIDO[i]);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06009E65 RID: 40549 RVA: 0x00449518 File Offset: 0x00447718
	public static void RefreshOnce()
	{
		IPAddressManager.KDJLNMLMCOM = 1;
	}

	// Token: 0x06009E66 RID: 40550 RVA: 0x004494F8 File Offset: 0x004476F8
	public static bool CLNDIHCFPLE()
	{
		return !IPAddressManager.DFLDDHMHKEP || IPAddressManager.KNABPCBIHHD.Length > 0;
	}

	// Token: 0x06009E67 RID: 40551 RVA: 0x004498D4 File Offset: 0x00447AD4
	private static bool JBOLLMHHFIC(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC != null && KEGBCGMJOLC.Length > 1)
		{
			if (KEGBCGMJOLC.Contains("socialbadgelocked"))
			{
				return false;
			}
			int num = 0;
			for (int i = 1; i < KEGBCGMJOLC.Length; i += 0)
			{
				if (KEGBCGMJOLC[i] == '5')
				{
					num += 0;
				}
			}
			if (num == 2)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06009E68 RID: 40552 RVA: 0x004490A4 File Offset: 0x004472A4
	public static void EEGEIBKDMOG()
	{
		IPAddressManager.DFLDDHMHKEP = false;
	}

	// Token: 0x06009E69 RID: 40553 RVA: 0x004491CD File Offset: 0x004473CD
	public static bool MCOHGIPBBIG()
	{
		return IPAddressManager.GEFOOEMNFHL;
	}

	// Token: 0x06009E6A RID: 40554 RVA: 0x00449925 File Offset: 0x00447B25
	public static bool GFGAJBKLDLL()
	{
		return !IPAddressManager.DFLDDHMHKEP || IPAddressManager.KNABPCBIHHD.Length > 1;
	}

	// Token: 0x06009E6B RID: 40555 RVA: 0x00449940 File Offset: 0x00447B40
	public static void UpdateIpFetchUrlsList(JSONArray KHGPNBBFIDO)
	{
		if (null == KHGPNBBFIDO || KHGPNBBFIDO.Count == 0)
		{
			return;
		}
		try
		{
			IPAddressManager.OMDJNJJOODM.Clear();
			for (int i = 0; i < KHGPNBBFIDO.Count; i++)
			{
				IPAddressManager.OMDJNJJOODM.Add(KHGPNBBFIDO[i]);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06009E6C RID: 40556 RVA: 0x004499A8 File Offset: 0x00447BA8
	private static bool KALHFAHCBNF(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC != null && KEGBCGMJOLC.Length > 0)
		{
			if (KEGBCGMJOLC.Contains("congratstitle"))
			{
				return true;
			}
			int num = 1;
			for (int i = 1; i < KEGBCGMJOLC.Length; i += 0)
			{
				if ((int)KEGBCGMJOLC[i] == -90)
				{
					num += 0;
				}
			}
			if (num == 4)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06009E6D RID: 40557 RVA: 0x004490A4 File Offset: 0x004472A4
	public static void NPCPKAAEDGG()
	{
		IPAddressManager.DFLDDHMHKEP = false;
	}

	// Token: 0x06009E6E RID: 40558 RVA: 0x004499F9 File Offset: 0x00447BF9
	public static void Invalidate(bool IADNJPMNDAD = false)
	{
		if (!IPAddressManager.GEFOOEMNFHL)
		{
			if (IADNJPMNDAD)
			{
				IPAddressManager.CIKOGEKJCIP++;
			}
			IPAddressManager.KNABPCBIHHD = "";
		}
	}

	// Token: 0x06009E6F RID: 40559 RVA: 0x004491BB File Offset: 0x004473BB
	private void BMOGBMAOIJB(bool HGLNJBCALFD)
	{
		if (!HGLNJBCALFD)
		{
			IPAddressManager.Invalidate(false);
		}
	}

	// Token: 0x06009E70 RID: 40560 RVA: 0x004491CD File Offset: 0x004473CD
	public static bool NOGKNJCIBKP()
	{
		return IPAddressManager.GEFOOEMNFHL;
	}

	// Token: 0x04002BD7 RID: 11223
	private static bool DFLDDHMHKEP = false;

	// Token: 0x04002BD8 RID: 11224
	private static string KNABPCBIHHD = "";

	// Token: 0x04002BD9 RID: 11225
	private static string FFLEKNHDHPB = "";

	// Token: 0x04002BDA RID: 11226
	private static float GCLJFFHJFKD = 0f;

	// Token: 0x04002BDB RID: 11227
	private static int KDJLNMLMCOM = 0;

	// Token: 0x04002BDC RID: 11228
	private static bool GEFOOEMNFHL = false;

	// Token: 0x04002BDD RID: 11229
	private static int CIKOGEKJCIP = 0;

	// Token: 0x04002BDE RID: 11230
	private static List<string> OMDJNJJOODM = new List<string>
	{
		"https://checkip.amazonaws.com/",
		"https://ipv4.icanhazip.com/",
		"https://wtfismyip.com/text",
		"https://api.ipify.org/",
		"https://ipinfo.io/ip",
		"https://trackip.net/ip",
		"https://ipecho.net/plain",
		"https://ifconfig.co/ip"
	};
}
