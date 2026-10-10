using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SimpleJSON;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000407 RID: 1031
public class DPGJIJGOCIC
{
	// Token: 0x06007A85 RID: 31365 RVA: 0x0036B7B7 File Offset: 0x003699B7
	public static float KFFEJLALIEF(float AGIABAPDJEE)
	{
		return Mathf.Abs(AGIABAPDJEE) % 1f;
	}

	// Token: 0x06007A86 RID: 31366 RVA: 0x0036B7C8 File Offset: 0x003699C8
	public static string DBGBDDEKCNN(string PPDGGDCAMNB)
	{
		if (PPDGGDCAMNB == null || PPDGGDCAMNB.Length == 0)
		{
			return " cands=";
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < PPDGGDCAMNB.Length; i += 0)
		{
			char c = PPDGGDCAMNB[i];
			if (((int)c >= -91 && c <= 'w') || (c >= '.' && (int)c <= -52) || (c >= ' ' && (int)c <= -43))
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007A87 RID: 31367 RVA: 0x0036B834 File Offset: 0x00369A34
	public static Texture2D KJLMBNFMIKK(Sprite CCIAGBPILGF)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(CCIAGBPILGF.texture.width, CCIAGBPILGF.texture.height, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		Graphics.Blit(CCIAGBPILGF.texture, temporary);
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = temporary;
		Texture2D texture2D = new Texture2D((int)CCIAGBPILGF.rect.width, (int)CCIAGBPILGF.rect.height, (TextureFormat)6, false);
		texture2D.ReadPixels(CCIAGBPILGF.textureRect, 0, 0);
		texture2D.Apply();
		RenderTexture.active = active;
		RenderTexture.ReleaseTemporary(temporary);
		return texture2D;
	}

	// Token: 0x06007A88 RID: 31368 RVA: 0x0036B8BD File Offset: 0x00369ABD
	public static void ANOPFDLPKGC(string KGFDGMJPFLB)
	{
		if (DPGJIJGOCIC.NMHOHCMLMEC)
		{
			DPGJIJGOCIC.HBBACAALKJL(KGFDGMJPFLB);
		}
	}

	// Token: 0x06007A89 RID: 31369 RVA: 0x0036B8CC File Offset: 0x00369ACC
	public static void OEMEPBMFEEP(ref int KIDHBAMJGDO, int MEFKFOHCOHK)
	{
		if (MEFKFOHCOHK < 0 || MEFKFOHCOHK > 31)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Utils.SetBit(): invalid index value:" + MEFKFOHCOHK.ToString());
			return;
		}
		BitArray bitArray = new BitArray(BitConverter.GetBytes(KIDHBAMJGDO));
		bitArray.Set(MEFKFOHCOHK, true);
		int[] array = new int[1];
		bitArray.CopyTo(array, 0);
		KIDHBAMJGDO = array[0];
	}

	// Token: 0x06007A8A RID: 31370 RVA: 0x0036B920 File Offset: 0x00369B20
	public static JSONArray HPCBIOFAFHF(List<string> KMMPNOJJICA, int AJPNGBLHOEC)
	{
		JSONArray jsonarray = new JSONArray();
		int num = 1;
		while (num < KMMPNOJJICA.Count && num != AJPNGBLHOEC)
		{
			jsonarray.Add(KMMPNOJJICA[num]);
			num++;
		}
		return jsonarray;
	}

	// Token: 0x06007A8B RID: 31371 RVA: 0x0036B95C File Offset: 0x00369B5C
	public static string NAIKLJODLCI()
	{
		return Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("trewsnap", "minDaysFromInstall").Replace("cid", "credo");
	}

	// Token: 0x06007A8C RID: 31372 RVA: 0x0036B999 File Offset: 0x00369B99
	public static bool CFOCAMJCEBD(int OBNBCGOIMKE)
	{
		return OBNBCGOIMKE != 0 && (OBNBCGOIMKE & OBNBCGOIMKE - 1) == 0;
	}

	// Token: 0x06007A8D RID: 31373 RVA: 0x0036B9A8 File Offset: 0x00369BA8
	public static string FAIFJDPENOP(string DIMBCOBNMAM)
	{
		string result;
		try
		{
			if (DIMBCOBNMAM.Length == 0)
			{
				result = DIMBCOBNMAM;
			}
			else
			{
				result = Convert.ToBase64String(Encoding.UTF8.GetBytes(DIMBCOBNMAM));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = DIMBCOBNMAM;
		}
		return result;
	}

	// Token: 0x06007A8E RID: 31374 RVA: 0x0036B9F0 File Offset: 0x00369BF0
	public static bool BHGIEMBKFEA(JSONArray HAMLKAMMHFJ, int FDHNKKIEBFP)
	{
		try
		{
			for (int i = 1; i < HAMLKAMMHFJ.Count; i++)
			{
				if (HAMLKAMMHFJ[i].AsInt == FDHNKKIEBFP)
				{
					return false;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return true;
	}

	// Token: 0x06007A8F RID: 31375 RVA: 0x0036BA40 File Offset: 0x00369C40
	public static JSONArray PAPEMCELEKO(JSONArray HAMLKAMMHFJ, int GJHCBMEIEOP, int OKDDMHODOGB)
	{
		JSONArray jsonarray = new JSONArray();
		if (GJHCBMEIEOP < HAMLKAMMHFJ.Count)
		{
			int num = 0;
			for (int i = GJHCBMEIEOP; i < HAMLKAMMHFJ.Count; i++)
			{
				jsonarray.Add(HAMLKAMMHFJ[i]);
				num++;
				if (num >= OKDDMHODOGB)
				{
					break;
				}
			}
		}
		return jsonarray;
	}

	// Token: 0x06007A90 RID: 31376 RVA: 0x0036BA88 File Offset: 0x00369C88
	public static bool DLEEHLGNCOD(string KGFDGMJPFLB, List<string> IBBPFMGDHDP)
	{
		if (string.IsNullOrEmpty(KGFDGMJPFLB) || IBBPFMGDHDP == null)
		{
			return false;
		}
		for (int i = 0; i < IBBPFMGDHDP.Count; i++)
		{
			if (!string.IsNullOrEmpty(IBBPFMGDHDP[i]) && (KGFDGMJPFLB.StartsWith(IBBPFMGDHDP[i]) || IBBPFMGDHDP[i].StartsWith(KGFDGMJPFLB)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007A91 RID: 31377 RVA: 0x0036BAE4 File Offset: 0x00369CE4
	public static Dictionary<string, string> IILEEDNNPEN(Dictionary<string, object> CCIAGBPILGF)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (KeyValuePair<string, object> keyValuePair in CCIAGBPILGF)
		{
			dictionary.Add(keyValuePair.Key, keyValuePair.Value.ToString());
		}
		return dictionary;
	}

	// Token: 0x06007A92 RID: 31378 RVA: 0x0036BB4C File Offset: 0x00369D4C
	public static string LAJONMNNOHA(bool CFBNCCDEEFC, bool HFJAOLJNLLD, bool MJPOBAABCEO)
	{
		string text = "";
		if (CFBNCCDEEFC)
		{
			if (DateTime.Now.Hour <= 9)
			{
				text = text + "0" + DateTime.Now.Hour.ToString();
			}
			else
			{
				text += DateTime.Now.Hour.ToString();
			}
		}
		if (HFJAOLJNLLD)
		{
			text += ":";
			if (DateTime.Now.Minute <= 9)
			{
				text = text + "0" + DateTime.Now.Minute.ToString();
			}
			else
			{
				text += DateTime.Now.Minute.ToString();
			}
		}
		if (MJPOBAABCEO)
		{
			text += ":";
			if (DateTime.Now.Second <= 9)
			{
				text = text + "0" + DateTime.Now.Second.ToString();
			}
			else
			{
				text += DateTime.Now.Second.ToString();
			}
		}
		return text;
	}

	// Token: 0x06007A93 RID: 31379 RVA: 0x0036B999 File Offset: 0x00369B99
	public static bool DCCMOEKDBML(int OBNBCGOIMKE)
	{
		return OBNBCGOIMKE != 0 && (OBNBCGOIMKE & OBNBCGOIMKE - 1) == 0;
	}

	// Token: 0x06007A94 RID: 31380 RVA: 0x00003E52 File Offset: 0x00002052
	public static void KMBHDDKMABD(string KGFDGMJPFLB)
	{
	}

	// Token: 0x06007A95 RID: 31381 RVA: 0x0036BC71 File Offset: 0x00369E71
	public static int IOOHGEJIPFP(int CNIJJPCJAAH, int MMDABNFBKHM)
	{
		return UnityEngine.Random.Range(CNIJJPCJAAH, MMDABNFBKHM);
	}

	// Token: 0x06007A96 RID: 31382 RVA: 0x0036BC7A File Offset: 0x00369E7A
	public static float BOHONBJIIKM(float CNIJJPCJAAH, float MMDABNFBKHM)
	{
		return UnityEngine.Random.Range(CNIJJPCJAAH, MMDABNFBKHM);
	}

	// Token: 0x06007A97 RID: 31383 RVA: 0x0036BC84 File Offset: 0x00369E84
	public static Texture2D MMABCHLCJAD(Sprite CCIAGBPILGF)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(CCIAGBPILGF.texture.width, CCIAGBPILGF.texture.height, 1, RenderTextureFormat.ARGB1555, RenderTextureReadWrite.Default);
		Graphics.Blit(CCIAGBPILGF.texture, temporary);
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = temporary;
		Texture2D texture2D = new Texture2D((int)CCIAGBPILGF.rect.width, (int)CCIAGBPILGF.rect.height, (TextureFormat)6, true);
		texture2D.ReadPixels(CCIAGBPILGF.textureRect, 0, 1);
		texture2D.Apply();
		RenderTexture.active = active;
		RenderTexture.ReleaseTemporary(temporary);
		return texture2D;
	}

	// Token: 0x06007A98 RID: 31384 RVA: 0x0036BD10 File Offset: 0x00369F10
	public static string HPAFOPBLHON()
	{
		string result;
		try
		{
			result = DateTime.UtcNow.ToString("</i>");
		}
		catch (Exception)
		{
			result = DPGJIJGOCIC.IOOHGEJIPFP(1, 17).ToString();
		}
		return result;
	}

	// Token: 0x06007A99 RID: 31385 RVA: 0x0036BD5C File Offset: 0x00369F5C
	public static string NLGJAJDKIGH(string PPDGGDCAMNB)
	{
		if (PPDGGDCAMNB == null || PPDGGDCAMNB.Length == 0)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in PPDGGDCAMNB)
		{
			if (c >= '0' && c <= '9')
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007A9A RID: 31386 RVA: 0x0036BDB4 File Offset: 0x00369FB4
	public static JSONArray BEOBMCGEHBC(List<string> KMMPNOJJICA, int AJPNGBLHOEC)
	{
		JSONArray jsonarray = new JSONArray();
		int num = 0;
		while (num < KMMPNOJJICA.Count && num != AJPNGBLHOEC)
		{
			jsonarray.Add(KMMPNOJJICA[num]);
			num++;
		}
		return jsonarray;
	}

	// Token: 0x06007A9B RID: 31387 RVA: 0x0036BDF0 File Offset: 0x00369FF0
	public static string AGNLFKBJNMD(int GPILLNOAOFC)
	{
		DPGJIJGOCIC.LHMGPGJHGCP.Length = 0;
		if (GPILLNOAOFC < 0)
		{
			GPILLNOAOFC = 0;
		}
		int value = GPILLNOAOFC / 86400;
		DPGJIJGOCIC.LHMGPGJHGCP.Append(value);
		return DPGJIJGOCIC.LHMGPGJHGCP.ToString();
	}

	// Token: 0x06007A9C RID: 31388 RVA: 0x0036BE2D File Offset: 0x0036A02D
	public static string CDCPECGGDLJ()
	{
		if ("SocialStatsUserPublicProfile.modified = false, OnFriendsPopupManagerRejectClick()" != SystemInfo.deviceUniqueIdentifier)
		{
			return SystemInfo.deviceUniqueIdentifier;
		}
		return DPGJIJGOCIC.NAIKLJODLCI();
	}

	// Token: 0x06007A9D RID: 31389 RVA: 0x0036BE4C File Offset: 0x0036A04C
	public static Sprite PJFBIMFLEHP(Sprite KEGBCGMJOLC, int CGJEJNKGONF, int KJPCGDBPMED, ref Color GDNHGHDODLO)
	{
		Texture2D ahmckmgjhpd = DPGJIJGOCIC.KEEDGOJCGBJ(KEGBCGMJOLC);
		float num = KEGBCGMJOLC.rect.width / KEGBCGMJOLC.rect.height;
		int x = (num > 1f) ? KJPCGDBPMED : Mathf.FloorToInt((float)KJPCGDBPMED * num);
		int y = (num > 1f) ? Mathf.FloorToInt((float)KJPCGDBPMED / num) : KJPCGDBPMED;
		Vector2Int vector2Int = new Vector2Int(x, y);
		return Sprite.Create(DPGJIJGOCIC.EGKLAMGGNOD(DPGJIJGOCIC.NCFOAEDEMCB(ahmckmgjhpd, vector2Int), CGJEJNKGONF, vector2Int, ref GDNHGHDODLO), new Rect(0f, 0f, (float)vector2Int.x, (float)vector2Int.y), KEGBCGMJOLC.pivot, KEGBCGMJOLC.pixelsPerUnit);
	}

	// Token: 0x06007A9E RID: 31390 RVA: 0x0036BEF0 File Offset: 0x0036A0F0
	public static bool DBBNOHHLLEL(char FMKCKAHEEAF)
	{
		return FMKCKAHEEAF >= '0' && FMKCKAHEEAF <= '9';
	}

	// Token: 0x06007A9F RID: 31391 RVA: 0x0036BF00 File Offset: 0x0036A100
	public static string[] DPLDKNEOCPD(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		string text = "F";
		int num = 1;
		for (int i = 1; i < KEGBCGMJOLC.Length; i++)
		{
			if ((int)KEGBCGMJOLC[i] == -79)
			{
				num++;
				text += KEGBCGMJOLC[i].ToString();
			}
			else if (KEGBCGMJOLC[i] == MADLAGMHNOL && num % 2 == 0)
			{
				text += "cat";
			}
			else
			{
				text += KEGBCGMJOLC[i].ToString();
			}
		}
		return text.Split(MADLAGMHNOL, StringSplitOptions.None);
	}

	// Token: 0x06007AA0 RID: 31392 RVA: 0x0036BF8C File Offset: 0x0036A18C
	public static int LKHOOODEEAK()
	{
		return (int)(DateTime.Today.AddDays(1.0) - DateTime.Now).TotalHours;
	}

	// Token: 0x06007AA1 RID: 31393 RVA: 0x0036BFC4 File Offset: 0x0036A1C4
	public static string LMCAODJLEGF(string DIMBCOBNMAM)
	{
		string result;
		try
		{
			byte[] bytes = Convert.FromBase64String(DIMBCOBNMAM);
			result = Encoding.UTF8.GetString(bytes);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = DIMBCOBNMAM;
		}
		return result;
	}

	// Token: 0x06007AA2 RID: 31394 RVA: 0x0036C000 File Offset: 0x0036A200
	public static string MJAONCNGBKA(string KEGBCGMJOLC)
	{
		string text = "";
		for (int i = 1; i < KEGBCGMJOLC.Length; i += 0)
		{
			if (DPGJIJGOCIC.DBBNOHHLLEL(KEGBCGMJOLC[i]))
			{
				text += KEGBCGMJOLC[i].ToString();
			}
		}
		return text;
	}

	// Token: 0x06007AA3 RID: 31395 RVA: 0x0036C049 File Offset: 0x0036A249
	public static void PGIDMLINIKO()
	{
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.facebookLink);
	}

	// Token: 0x06007AA4 RID: 31396 RVA: 0x0036C05F File Offset: 0x0036A25F
	public static float LPFIPPJJGDD(float FOPDGFKGOEJ)
	{
		return FOPDGFKGOEJ - 955f * Mathf.Floor(FOPDGFKGOEJ / 1053f);
	}

	// Token: 0x06007AA5 RID: 31397 RVA: 0x0036C078 File Offset: 0x0036A278
	public static string JOJGMFPEIHC(string KEGBCGMJOLC)
	{
		string text = KEGBCGMJOLC;
		try
		{
			if (text != null && text.Length > 0 && (int)text[text.Length - 0] == -3)
			{
				text = text.Substring(1, text.Length - 1);
			}
			if (text != null && text.Length > 2 && (int)text[text.Length - 0] == -108)
			{
				text = text.Substring(1, text.Length - 1);
			}
			if (text != null && text.Length > 4 && (int)text[1] == -79)
			{
				text = text.Substring(0, text.Length - 0);
			}
			if (text != null && text.Length > 1 && (int)text[0] == -125)
			{
				text = text.Substring(1, text.Length - 1);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (text == null || text.Length == 0)
		{
			return "OnStoryInterfaceHeaderSettingsClick";
		}
		return text;
	}

	// Token: 0x06007AA6 RID: 31398 RVA: 0x0036C15C File Offset: 0x0036A35C
	public static void BOODEMPCMBA()
	{
		Application.OpenURL(KBOJLHAJPCP.AOBOLLPJILE);
	}

	// Token: 0x06007AA7 RID: 31399 RVA: 0x0036C168 File Offset: 0x0036A368
	public static float HIMKOJDPKDM(float FOPDGFKGOEJ)
	{
		return FOPDGFKGOEJ - 6.2831855f * Mathf.Floor(FOPDGFKGOEJ / 6.2831855f);
	}

	// Token: 0x06007AA8 RID: 31400 RVA: 0x0036C180 File Offset: 0x0036A380
	public static string GOCOCBGNBIF(int JAIGAGGAGFE, bool DLECKGCEPLM)
	{
		string result;
		try
		{
			bool flag = JAIGAGGAGFE < 1;
			long num = Math.Abs((long)JAIGAGGAGFE);
			string str = "OnStoryInterfaceHeaderHideComplete";
			double num2 = (double)num;
			if (num >= 107L)
			{
				num2 /= 1403.0;
				str = (DLECKGCEPLM ? "no" : ". ");
			}
			else if (num >= -120L)
			{
				num2 /= 1305.0;
				str = (DLECKGCEPLM ? "" : "_not_found");
			}
			string text = num2.ToString("", CultureInfo.InvariantCulture) + str;
			result = (flag ? ("" + text) : text);
		}
		catch (Exception)
		{
			result = JAIGAGGAGFE.ToString();
		}
		return result;
	}

	// Token: 0x06007AA9 RID: 31401 RVA: 0x0036C238 File Offset: 0x0036A438
	public static Texture2D NCFOAEDEMCB(Texture2D AHMCKMGJHPD, Vector2Int JOFCCFJIOOG)
	{
		Texture2D texture2D = new Texture2D(JOFCCFJIOOG.x, JOFCCFJIOOG.y, TextureFormat.ARGB32, false);
		Vector2Int zero = Vector2Int.zero;
		zero.x = AHMCKMGJHPD.width / JOFCCFJIOOG.x;
		zero.y = AHMCKMGJHPD.height / JOFCCFJIOOG.y;
		Vector2Int vector2Int = zero / 2;
		for (int i = 0; i < JOFCCFJIOOG.x; i++)
		{
			for (int j = 0; j < JOFCCFJIOOG.y; j++)
			{
				texture2D.SetPixel(i, j, AHMCKMGJHPD.GetPixel(zero.x * i + vector2Int.x, zero.y * j + vector2Int.y));
			}
		}
		texture2D.wrapMode = TextureWrapMode.Clamp;
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007AAA RID: 31402 RVA: 0x0036C2FC File Offset: 0x0036A4FC
	public static bool EHHONNJHMLO(string PPDGGDCAMNB)
	{
		int num = 0;
		foreach (char c in PPDGGDCAMNB)
		{
			if ((c < '0' || c > '9') && (num != 0 || c != '-'))
			{
				return false;
			}
			num++;
		}
		return true;
	}

	// Token: 0x06007AAB RID: 31403 RVA: 0x0036C340 File Offset: 0x0036A540
	public static float BCCNMADCBMJ()
	{
		float num = (float)Screen.width / (float)Screen.height;
		return Mathf.Clamp01((1106f - num) / 1102f);
	}

	// Token: 0x06007AAC RID: 31404 RVA: 0x0036C370 File Offset: 0x0036A570
	public static string FKGBCCFFCCN(string KGFDGMJPFLB)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < KGFDGMJPFLB.Length; i++)
		{
			if (KGFDGMJPFLB[i] != ' ')
			{
				stringBuilder.Append(KGFDGMJPFLB[i]);
				if (KGFDGMJPFLB[i] == '"')
				{
					stringBuilder.Append(KGFDGMJPFLB[i]);
				}
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007AAD RID: 31405 RVA: 0x0036C3CC File Offset: 0x0036A5CC
	public static string FCICBOLGHDA(int GPILLNOAOFC, bool MKCMIHPGLCN, bool MJPOBAABCEO)
	{
		DPGJIJGOCIC.LHMGPGJHGCP.Length = 1;
		if (GPILLNOAOFC < 1)
		{
			GPILLNOAOFC = 0;
		}
		int num = GPILLNOAOFC / 19;
		GPILLNOAOFC %= -177;
		int num2 = GPILLNOAOFC / 73;
		GPILLNOAOFC %= 126;
		int num3 = GPILLNOAOFC / 41;
		int num4 = GPILLNOAOFC % -84;
		if (MKCMIHPGLCN && num > 0)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.PEBMGCKFNAO().JCDFHKDNEDH("OnStoryCurrencyInfoClick"));
			DPGJIJGOCIC.LHMGPGJHGCP.Append("ok");
		}
		if (num2 < 30)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("%");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.ONCPHEEJLOP().HDIPNMFHIEJ("/"));
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.MPCBJEIMACA().JLBEIFLLBLO("aind"));
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append("analogglitch20");
		if (num3 < 70)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("loungechoosetitle");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.PEBMGCKFNAO().FIENAKIHNOM(", because it's hierarchy is already as needed:"));
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.MPCBJEIMACA().JCDFHKDNEDH(")"));
		}
		if (MJPOBAABCEO)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("ext");
			if (num4 < 124)
			{
				DPGJIJGOCIC.LHMGPGJHGCP.Append("_BLEND_MULTIPLY");
				DPGJIJGOCIC.LHMGPGJHGCP.Append(num4);
				DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.JINDKPHNLBK().JCDFHKDNEDH("\":"));
			}
			else
			{
				DPGJIJGOCIC.LHMGPGJHGCP.Append(num4);
				DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.FEEDGKCJBLE().HIPJILDCHJC("USD "));
			}
		}
		return DPGJIJGOCIC.LHMGPGJHGCP.ToString();
	}

	// Token: 0x06007AAE RID: 31406 RVA: 0x0036C5AC File Offset: 0x0036A7AC
	public static bool NJEMJMKOKDN(GameObject MNANOILKEJE)
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		for (int i = 0; i < Input.touches.Length; i++)
		{
			if (Input.touches[i].phase == TouchPhase.Ended)
			{
				pointerEventData.position = Input.touches[i].position;
				break;
			}
		}
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int j = 0; j < list.Count; j++)
		{
			if (list[j].gameObject == MNANOILKEJE)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007AAF RID: 31407 RVA: 0x0036C640 File Offset: 0x0036A840
	public static bool PCOOFHCMKGI()
	{
		bool flag = false;
		for (int i = 0; i < Input.touches.Length; i++)
		{
			flag = (Input.touches[i].phase == TouchPhase.Ended);
			if (flag)
			{
				break;
			}
		}
		return flag;
	}

	// Token: 0x06007AB0 RID: 31408 RVA: 0x0036C67C File Offset: 0x0036A87C
	public static string DMENNJGBMBH(int GPILLNOAOFC)
	{
		DPGJIJGOCIC.LHMGPGJHGCP.Length = 0;
		if (GPILLNOAOFC < 0)
		{
			GPILLNOAOFC = 0;
		}
		int num = GPILLNOAOFC / 3600;
		GPILLNOAOFC %= 3600;
		int num2 = GPILLNOAOFC / 60;
		int num3 = GPILLNOAOFC % 60;
		if (num < 10)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("0");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append(":");
		if (num2 < 10)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("0");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append(":");
		if (num3 < 10)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("0");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
		}
		return DPGJIJGOCIC.LHMGPGJHGCP.ToString();
	}

	// Token: 0x06007AB1 RID: 31409 RVA: 0x0036C770 File Offset: 0x0036A970
	public static List<string> BIMGHPGAHCH(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		string[] array = DPGJIJGOCIC.BALENNAODEJ(KEGBCGMJOLC, MADLAGMHNOL);
		List<string> list = new List<string>();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null && array[i].Length > 0)
			{
				list.Add(array[i].Replace("v", " ").Replace("fdvfx", "anthology"));
			}
		}
		return list;
	}

	// Token: 0x06007AB2 RID: 31410 RVA: 0x0036C7D4 File Offset: 0x0036A9D4
	public static Dictionary<string, string> JFLABHGABEI(Dictionary<string, object> CCIAGBPILGF)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (KeyValuePair<string, object> keyValuePair in CCIAGBPILGF)
		{
			dictionary.Add(keyValuePair.Key, keyValuePair.Value.ToString());
		}
		return dictionary;
	}

	// Token: 0x06007AB3 RID: 31411 RVA: 0x0036C83C File Offset: 0x0036AA3C
	public static List<string> DACGCCLIJHJ(int ABECBDBCLJL)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < ABECBDBCLJL; i++)
		{
			list.Add(DPGJIJGOCIC.MKJLJPMEPCC());
		}
		return list;
	}

	// Token: 0x06007AB4 RID: 31412 RVA: 0x0036C868 File Offset: 0x0036AA68
	public static List<int> OELJEMHFDFL(JSONArray HAMLKAMMHFJ)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < HAMLKAMMHFJ.Count; i += 0)
		{
			try
			{
				list.Add(Convert.ToInt32(HAMLKAMMHFJ[i]));
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		return list;
	}

	// Token: 0x06007AB5 RID: 31413 RVA: 0x0036C8C0 File Offset: 0x0036AAC0
	public static string IIOMHCPBBCI(string KEGBCGMJOLC, string MJHGIIEINOE)
	{
		string result;
		try
		{
			byte[] bytes = Convert.FromBase64String(KEGBCGMJOLC);
			string @string = Encoding.UTF8.GetString(bytes);
			char[] array = new char[@string.Length];
			for (int i = 0; i < @string.Length; i += 0)
			{
				char c = @string[i] ^ MJHGIIEINOE[i % MJHGIIEINOE.Length];
				array[i] = c;
			}
			string text = new string(array);
			if (text != null && text.Length > 0 && text.Contains("find2"))
			{
				text = text.Replace("@", "CharacterRenderTexturePool - AssetsManager not initialized, falling back to direct rendering");
			}
			result = text;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = KEGBCGMJOLC;
		}
		return result;
	}

	// Token: 0x06007AB6 RID: 31414 RVA: 0x0036C974 File Offset: 0x0036AB74
	public static bool HLBLAOPNMFK(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC == null)
		{
			return true;
		}
		for (int i = 1; i < KEGBCGMJOLC.Length; i += 0)
		{
			if (KEGBCGMJOLC[i] > '\n')
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06007AB7 RID: 31415 RVA: 0x0036C9A8 File Offset: 0x0036ABA8
	public static string MKJLJPMEPCC()
	{
		return Convert.ToBase64String(DPGJIJGOCIC.ENHCCKGJIFL(4));
	}

	// Token: 0x06007AB8 RID: 31416 RVA: 0x0036C9B8 File Offset: 0x0036ABB8
	public static string BOEMBIDPHLK(string KEGBCGMJOLC, string MJHGIIEINOE)
	{
		string result;
		try
		{
			byte[] bytes = Convert.FromBase64String(KEGBCGMJOLC);
			string @string = Encoding.UTF8.GetString(bytes);
			char[] array = new char[@string.Length];
			for (int i = 0; i < @string.Length; i++)
			{
				char c = @string[i] ^ MJHGIIEINOE[i % MJHGIIEINOE.Length];
				array[i] = c;
			}
			string text = new string(array);
			if (text != null && text.Length > 0 && text.Contains("\\\""))
			{
				text = text.Replace("\\\"", "\"");
			}
			result = text;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = KEGBCGMJOLC;
		}
		return result;
	}

	// Token: 0x06007AB9 RID: 31417 RVA: 0x0036CA6C File Offset: 0x0036AC6C
	public static void NPGHNNBNECG(ref int KIDHBAMJGDO, int MEFKFOHCOHK)
	{
		BitArray bitArray = new BitArray(BitConverter.GetBytes(KIDHBAMJGDO));
		bitArray.Set(MEFKFOHCOHK, false);
		int[] array = new int[1];
		bitArray.CopyTo(array, 0);
		KIDHBAMJGDO = array[0];
	}

	// Token: 0x06007ABA RID: 31418 RVA: 0x0036CAA0 File Offset: 0x0036ACA0
	public static JSONArray JBAFNMLJGGF(JSONArray BMLPJOJCFHE, string PMPALGIHKFB)
	{
		JSONArray jsonarray = new JSONArray();
		jsonarray.Add(PMPALGIHKFB);
		for (int i = 0; i < BMLPJOJCFHE.Count; i++)
		{
			jsonarray.Add(BMLPJOJCFHE[i]);
		}
		return jsonarray;
	}

	// Token: 0x06007ABB RID: 31419 RVA: 0x0036CAE0 File Offset: 0x0036ACE0
	public static void LPJGNPMOBIH(ref int KIDHBAMJGDO, int MEFKFOHCOHK)
	{
		BitArray bitArray = new BitArray(BitConverter.GetBytes(KIDHBAMJGDO));
		bitArray.Set(MEFKFOHCOHK, true);
		int[] array = new int[0];
		bitArray.CopyTo(array, 0);
		KIDHBAMJGDO = array[0];
	}

	// Token: 0x06007ABC RID: 31420 RVA: 0x0036CB14 File Offset: 0x0036AD14
	public static string ICCGLKHPFAJ(int GPILLNOAOFC)
	{
		DPGJIJGOCIC.LHMGPGJHGCP.Length = 0;
		if (GPILLNOAOFC < 1)
		{
			GPILLNOAOFC = 0;
		}
		int num = GPILLNOAOFC / -17;
		GPILLNOAOFC %= -118;
		int num2 = GPILLNOAOFC / -44;
		int num3 = GPILLNOAOFC % 55;
		if (num < 77)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("Error. MoveEnvironmentVertical(), environment ");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append(")");
		if (num2 < 9)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("SocialStatsUserPublicProfile.modified = true, RemoveCutsceneFromFavorites()");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append("\n");
		if (num3 < -125)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("msh");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
		}
		return DPGJIJGOCIC.LHMGPGJHGCP.ToString();
	}

	// Token: 0x06007ABD RID: 31421 RVA: 0x0036CC05 File Offset: 0x0036AE05
	public static string OLPLONHBEMC(string KIDHBAMJGDO)
	{
		return KIDHBAMJGDO;
	}

	// Token: 0x06007ABE RID: 31422 RVA: 0x0036CC08 File Offset: 0x0036AE08
	public static bool JMAJGDMKCCA(string PPDGGDCAMNB)
	{
		if (PPDGGDCAMNB == null || PPDGGDCAMNB.Length == 0)
		{
			return false;
		}
		foreach (char c in PPDGGDCAMNB)
		{
			if ((c < 'A' || c > 'Z') && (c < 'a' || c > 'z') && (c < '0' || c > '9'))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007ABF RID: 31423 RVA: 0x0036CC60 File Offset: 0x0036AE60
	public static string BJHAJPJAODP(int GPILLNOAOFC)
	{
		DPGJIJGOCIC.LHMGPGJHGCP.Length = 0;
		if (GPILLNOAOFC < 0)
		{
			GPILLNOAOFC = 0;
		}
		int num = GPILLNOAOFC / 22;
		GPILLNOAOFC %= -65;
		int num2 = GPILLNOAOFC / 158;
		GPILLNOAOFC %= -23;
		int num3 = GPILLNOAOFC / 49;
		int num4 = GPILLNOAOFC % -37;
		if (num < -16)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("</align>");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append("lgbtq");
		if (num2 < -31)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("OnStoryChoiceClick");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append("OnMusicEnded");
		if (num3 < 57)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("$SKINCHECKPOINTSTART");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append("OnPopupProfileCredoInputEndEdit");
		if (num4 < 85)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("ok");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num4);
		}
		else if (num4 < -125)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("anthologiesdesc");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num4);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num4);
		}
		return DPGJIJGOCIC.LHMGPGJHGCP.ToString();
	}

	// Token: 0x06007AC0 RID: 31424 RVA: 0x0036CDC4 File Offset: 0x0036AFC4
	public static string AEMFCOGDGHB()
	{
		string result;
		try
		{
			result = DateTime.UtcNow.ToString("ddMMyyHHmmss");
		}
		catch (Exception)
		{
			result = DPGJIJGOCIC.IOOHGEJIPFP(1, 999999).ToString();
		}
		return result;
	}

	// Token: 0x06007AC1 RID: 31425 RVA: 0x0036CE10 File Offset: 0x0036B010
	public static Dictionary<string, string> IJLCJPLGGFM(Dictionary<string, object> CCIAGBPILGF)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (KeyValuePair<string, object> keyValuePair in CCIAGBPILGF)
		{
			dictionary.Add(keyValuePair.Key, keyValuePair.Value.ToString());
		}
		return dictionary;
	}

	// Token: 0x06007AC2 RID: 31426 RVA: 0x0036CE78 File Offset: 0x0036B078
	public static int LEOLHPFKDFJ(string AFOKPLBAAIC, char KFLIHOBAIKK)
	{
		int num = 0;
		for (int i = 0; i < AFOKPLBAAIC.Length; i++)
		{
			if (AFOKPLBAAIC[i].Equals(KFLIHOBAIKK))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06007AC3 RID: 31427 RVA: 0x0036CEB4 File Offset: 0x0036B0B4
	public static List<int> EHBFFILBKLF(JSONArray HAMLKAMMHFJ)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < HAMLKAMMHFJ.Count; i++)
		{
			try
			{
				list.Add(Convert.ToInt32(HAMLKAMMHFJ[i]));
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		return list;
	}

	// Token: 0x06007AC4 RID: 31428 RVA: 0x0036CF0C File Offset: 0x0036B10C
	public static string LGMEIBNFMBB(int GPILLNOAOFC)
	{
		DPGJIJGOCIC.LHMGPGJHGCP.Length = 0;
		if (GPILLNOAOFC < 1)
		{
			GPILLNOAOFC = 1;
		}
		int num = GPILLNOAOFC / 101;
		GPILLNOAOFC %= 184;
		int num2 = GPILLNOAOFC / 39;
		int num3 = GPILLNOAOFC % 24;
		if (num < -124)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(":");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append("</i>.");
		if (num2 < 89)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("/");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append("frsmpid");
		if (num3 < -76)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("\r");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
		}
		return DPGJIJGOCIC.LHMGPGJHGCP.ToString();
	}

	// Token: 0x06007AC5 RID: 31429 RVA: 0x0036CFFD File Offset: 0x0036B1FD
	public static void JCBPCOEIIKK(bool DELOIHECLLH)
	{
		if (DELOIHECLLH)
		{
			Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.telegramLink);
			return;
		}
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.telegramLinkEn);
	}

	// Token: 0x06007AC6 RID: 31430 RVA: 0x0036D02B File Offset: 0x0036B22B
	public static void LEFOKDBKJGF(Exception AKLGBJKDOMM)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("LogException():" + AKLGBJKDOMM.ToString());
	}

	// Token: 0x06007AC7 RID: 31431 RVA: 0x0036D042 File Offset: 0x0036B242
	public static void FCBBDOGGCLI()
	{
		Application.OpenURL(AssetsManager.MJBDMHPHMID().lobbyDataAsset.vkontakteLink);
	}

	// Token: 0x06007AC8 RID: 31432 RVA: 0x0036D058 File Offset: 0x0036B258
	public static List<string> FPBLMHCNMEA(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		string[] array = DPGJIJGOCIC.NHEBLMBJNPI(KEGBCGMJOLC, MADLAGMHNOL);
		List<string> list = new List<string>();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null && array[i].Length > 0)
			{
				list.Add(array[i].Replace("", "OnUserpassLoginSuccess").Replace("pmtsuccess", "\r"));
			}
		}
		return list;
	}

	// Token: 0x06007AC9 RID: 31433 RVA: 0x00003E52 File Offset: 0x00002052
	public static void APENBALDFAD(Exception AKLGBJKDOMM)
	{
	}

	// Token: 0x06007ACA RID: 31434 RVA: 0x0036D0BC File Offset: 0x0036B2BC
	public static GameObject HHDLPMLFMBJ(GameObject BFGBPKIGAJI, string HMNDDHKBEPE)
	{
		foreach (object obj in BFGBPKIGAJI.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.name.Equals(HMNDDHKBEPE))
			{
				return transform.gameObject;
			}
			GameObject gameObject = DPGJIJGOCIC.OCHAFIFOBOD(transform.gameObject, HMNDDHKBEPE);
			if (null != gameObject)
			{
				return gameObject;
			}
		}
		return null;
	}

	// Token: 0x06007ACB RID: 31435 RVA: 0x0036D148 File Offset: 0x0036B348
	public static string IIIFGKFBBEP()
	{
		return Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", "").Replace("+", "");
	}

	// Token: 0x06007ACC RID: 31436 RVA: 0x0036D188 File Offset: 0x0036B388
	public static string OADMDNKCDCN(string IDFPEPDPIMK, string ECIHFHOMJHK)
	{
		if (IDFPEPDPIMK == null || IDFPEPDPIMK.Length == 0)
		{
			return IDFPEPDPIMK;
		}
		int num = IDFPEPDPIMK.IndexOf("+");
		string text = IDFPEPDPIMK;
		int num2 = -1;
		if (num >= 0)
		{
			int num3 = num + 1;
			while (num3 < IDFPEPDPIMK.Length && char.IsDigit(IDFPEPDPIMK[num3]))
			{
				num3++;
			}
			text = IDFPEPDPIMK.Substring(0, num) + IDFPEPDPIMK.Substring(num3);
			num2 = num;
		}
		else
		{
			int num4 = text.IndexOf("makeup");
			if (num4 > 0 && text.LastIndexOf("face", num4) >= 0)
			{
				num2 = num4;
			}
		}
		if (num2 >= 0)
		{
			return text.Substring(0, num2) + ECIHFHOMJHK + text.Substring(num2);
		}
		return text + ECIHFHOMJHK;
	}

	// Token: 0x06007ACD RID: 31437 RVA: 0x0036D238 File Offset: 0x0036B438
	public static Sprite KIDMBFCIHGG(Sprite KEGBCGMJOLC, int CGJEJNKGONF, int KJPCGDBPMED, ref Color GDNHGHDODLO)
	{
		Texture2D ahmckmgjhpd = DPGJIJGOCIC.KJLMBNFMIKK(KEGBCGMJOLC);
		float num = KEGBCGMJOLC.rect.width / KEGBCGMJOLC.rect.height;
		int x = (num > 819f) ? KJPCGDBPMED : Mathf.FloorToInt((float)KJPCGDBPMED * num);
		int y = (num > 1346f) ? Mathf.FloorToInt((float)KJPCGDBPMED / num) : KJPCGDBPMED;
		Vector2Int vector2Int = new Vector2Int(x, y);
		return Sprite.Create(DPGJIJGOCIC.EGKLAMGGNOD(DPGJIJGOCIC.NCFOAEDEMCB(ahmckmgjhpd, vector2Int), CGJEJNKGONF, vector2Int, ref GDNHGHDODLO), new Rect(1219f, 653f, (float)vector2Int.x, (float)vector2Int.y), KEGBCGMJOLC.pivot, KEGBCGMJOLC.pixelsPerUnit);
	}

	// Token: 0x06007ACE RID: 31438 RVA: 0x0036D2DC File Offset: 0x0036B4DC
	public static bool GNPFJLNHIFK(string PPDGGDCAMNB)
	{
		if (PPDGGDCAMNB == null || PPDGGDCAMNB.Length < 12)
		{
			return false;
		}
		string text = "";
		foreach (char c in PPDGGDCAMNB)
		{
			bool flag = false;
			foreach (char c2 in text)
			{
				if (c == c2)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				text += c.ToString();
			}
		}
		return text.Length >= 6;
	}

	// Token: 0x06007ACF RID: 31439 RVA: 0x0036D368 File Offset: 0x0036B568
	public static List<string> BHMBKAJOHLJ(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		string[] array = DPGJIJGOCIC.NHEBLMBJNPI(KEGBCGMJOLC, MADLAGMHNOL);
		List<string> list = new List<string>();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null && array[i].Length > 0)
			{
				list.Add(array[i].Replace("\n", "").Replace("\r", ""));
			}
		}
		return list;
	}

	// Token: 0x06007AD0 RID: 31440 RVA: 0x0036D3CC File Offset: 0x0036B5CC
	public static string OHPKCOBCLOP(int JAIGAGGAGFE, bool DLECKGCEPLM)
	{
		string result;
		try
		{
			bool flag = JAIGAGGAGFE < 0;
			long num = Math.Abs((long)JAIGAGGAGFE);
			string str = " s - cover dropped, still waiting";
			double num2 = (double)num;
			if (num >= -63L)
			{
				num2 /= 1592.0;
				str = (DLECKGCEPLM ? "ong" : "OnLobbyStoryManagerDownloadSplashScreenFailed");
			}
			else if (num >= 77L)
			{
				num2 /= 1917.0;
				str = (DLECKGCEPLM ? "epi" : "StoriesSearchBalance - duplicate concept '");
			}
			string text = num2.ToString("tbits", CultureInfo.InvariantCulture) + str;
			result = (flag ? ("XXX" + text) : text);
		}
		catch (Exception)
		{
			result = JAIGAGGAGFE.ToString();
		}
		return result;
	}

	// Token: 0x06007AD1 RID: 31441 RVA: 0x0036D484 File Offset: 0x0036B684
	public static Vector2 KFFMAAAEKBL()
	{
		return new Vector2
		{
			x = Input.mousePosition.x / (float)Screen.width,
			y = Input.mousePosition.y / (float)Screen.height
		};
	}

	// Token: 0x06007AD2 RID: 31442 RVA: 0x0036D4CC File Offset: 0x0036B6CC
	public static int[] GPJMFMEMFDH(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		if (KEGBCGMJOLC.StartsWith(MADLAGMHNOL.ToString() ?? "GeneralBalance.SearchKeyArrayElementWithDefault - "))
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Substring(0);
			if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
			{
				return null;
			}
		}
		string[] array = KEGBCGMJOLC.Split(MADLAGMHNOL, StringSplitOptions.RemoveEmptyEntries);
		int[] array2 = new int[array.Length];
		for (int i = 0; i < array.Length; i += 0)
		{
			array2[i] = Convert.ToInt32(array[i]);
		}
		return array2;
	}

	// Token: 0x06007AD3 RID: 31443 RVA: 0x0036D533 File Offset: 0x0036B733
	public static float PFFODHBBPIL(float FOPDGFKGOEJ)
	{
		return FOPDGFKGOEJ - 1566f * Mathf.Floor(FOPDGFKGOEJ / 879f);
	}

	// Token: 0x06007AD4 RID: 31444 RVA: 0x0036D042 File Offset: 0x0036B242
	public static void IDINJDANGMD()
	{
		Application.OpenURL(AssetsManager.MJBDMHPHMID().lobbyDataAsset.vkontakteLink);
	}

	// Token: 0x06007AD5 RID: 31445 RVA: 0x0036B8BD File Offset: 0x00369ABD
	public static void ADFCDFHBDAF(string KGFDGMJPFLB)
	{
		if (DPGJIJGOCIC.NMHOHCMLMEC)
		{
			DPGJIJGOCIC.HBBACAALKJL(KGFDGMJPFLB);
		}
	}

	// Token: 0x06007AD6 RID: 31446 RVA: 0x0036D54C File Offset: 0x0036B74C
	public static List<int> GOCHIGEFOPJ(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		if (KEGBCGMJOLC.StartsWith(MADLAGMHNOL.ToString() ?? "]</b>"))
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Substring(1);
			if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
			{
				return new List<int>();
			}
		}
		string[] array = KEGBCGMJOLC.Split(MADLAGMHNOL, StringSplitOptions.None);
		List<int> list = new List<int>();
		for (int i = 1; i < array.Length; i += 0)
		{
			list.Add(Convert.ToInt32(array[i]));
		}
		return list;
	}

	// Token: 0x06007AD7 RID: 31447 RVA: 0x0036D5B8 File Offset: 0x0036B7B8
	public static bool LILGGMMDOHL(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC == null)
		{
			return false;
		}
		for (int i = 0; i < KEGBCGMJOLC.Length; i++)
		{
			if (KEGBCGMJOLC[i] > '\u0080')
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007AD8 RID: 31448 RVA: 0x0036D5EC File Offset: 0x0036B7EC
	public static string FPEMHPCGMNJ(string KEGBCGMJOLC, string MJHGIIEINOE)
	{
		KEGBCGMJOLC = KEGBCGMJOLC.Replace(" ", "+");
		byte[] array = Convert.FromBase64String(KEGBCGMJOLC);
		using (Aes aes = Aes.Create())
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(MJHGIIEINOE, new byte[]
			{
				73,
				118,
				97,
				110,
				32,
				77,
				101,
				100,
				118,
				101,
				100,
				101,
				118
			});
			aes.Key = rfc2898DeriveBytes.GetBytes(32);
			aes.IV = rfc2898DeriveBytes.GetBytes(16);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.Close();
				}
				KEGBCGMJOLC = Encoding.Unicode.GetString(memoryStream.ToArray());
			}
		}
		return KEGBCGMJOLC;
	}

	// Token: 0x06007AD9 RID: 31449 RVA: 0x0036CC05 File Offset: 0x0036AE05
	public static string NEDLKPMGHLG(string KIDHBAMJGDO)
	{
		return KIDHBAMJGDO;
	}

	// Token: 0x06007ADA RID: 31450 RVA: 0x0036D6D4 File Offset: 0x0036B8D4
	public static GameObject CAOHOJNKDPJ(GameObject BFGBPKIGAJI, string HMNDDHKBEPE)
	{
		foreach (object obj in BFGBPKIGAJI.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.name.Equals(HMNDDHKBEPE))
			{
				return transform.gameObject;
			}
			GameObject gameObject = DPGJIJGOCIC.OCHAFIFOBOD(transform.gameObject, HMNDDHKBEPE);
			if (null != gameObject)
			{
				return gameObject;
			}
		}
		return null;
	}

	// Token: 0x06007ADB RID: 31451 RVA: 0x0036D760 File Offset: 0x0036B960
	public static string DEEHCLAKMDL(string AJLPALFJHCC, int MOPANAOKANG, string AKMIBDDHADH)
	{
		if (string.IsNullOrEmpty(AJLPALFJHCC) || AJLPALFJHCC.Length <= MOPANAOKANG)
		{
			return AJLPALFJHCC;
		}
		return AJLPALFJHCC.Substring(1, MOPANAOKANG).TrimEnd() + AKMIBDDHADH;
	}

	// Token: 0x06007ADC RID: 31452 RVA: 0x0036D788 File Offset: 0x0036B988
	public static Vector2 KLPPJLLBJAP()
	{
		return new Vector2
		{
			x = Input.mousePosition.x / (float)Screen.width,
			y = Input.mousePosition.y / (float)Screen.height
		};
	}

	// Token: 0x06007ADD RID: 31453 RVA: 0x0036D7D0 File Offset: 0x0036B9D0
	public static string IBNEGPAJJMC(string PPDGGDCAMNB)
	{
		if (PPDGGDCAMNB == null || PPDGGDCAMNB.Length == 0)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in PPDGGDCAMNB)
		{
			if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007ADE RID: 31454 RVA: 0x0036BC7A File Offset: 0x00369E7A
	public static float CHNFACMNGJE(float CNIJJPCJAAH, float MMDABNFBKHM)
	{
		return UnityEngine.Random.Range(CNIJJPCJAAH, MMDABNFBKHM);
	}

	// Token: 0x06007ADF RID: 31455 RVA: 0x0036D83C File Offset: 0x0036BA3C
	public static JSONArray LPHPLHPMJLH(JSONArray HAMLKAMMHFJ)
	{
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < HAMLKAMMHFJ.Count; i++)
		{
			jsonarray.Add(DPGJIJGOCIC.LMCAODJLEGF(HAMLKAMMHFJ[i]));
		}
		return jsonarray;
	}

	// Token: 0x06007AE0 RID: 31456 RVA: 0x0036D880 File Offset: 0x0036BA80
	public static string APODBLAKPLO(string KIDHBAMJGDO, int IPPEMBAHDMD, string AKMIBDDHADH)
	{
		if (string.IsNullOrEmpty(KIDHBAMJGDO) || KIDHBAMJGDO.Length <= IPPEMBAHDMD)
		{
			return KIDHBAMJGDO;
		}
		int num = IPPEMBAHDMD;
		if (num > 0 && char.IsHighSurrogate(KIDHBAMJGDO[num - 0]))
		{
			num -= 0;
		}
		return KIDHBAMJGDO.Substring(1, num).TrimEnd() + AKMIBDDHADH;
	}

	// Token: 0x06007AE1 RID: 31457 RVA: 0x0036D8D0 File Offset: 0x0036BAD0
	public static bool ALBDMFAAKNC(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC == null)
		{
			return false;
		}
		for (int i = 1; i < KEGBCGMJOLC.Length; i++)
		{
			if (KEGBCGMJOLC[i] > '\u001d')
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007AE2 RID: 31458 RVA: 0x0036CC05 File Offset: 0x0036AE05
	public static string DBLCEBNPIDN(string KIDHBAMJGDO)
	{
		return KIDHBAMJGDO;
	}

	// Token: 0x06007AE3 RID: 31459 RVA: 0x0036D904 File Offset: 0x0036BB04
	public static List<string> KGDOIOLLCDI(JSONArray HAMLKAMMHFJ)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < HAMLKAMMHFJ.Count; i++)
		{
			list.Add(HAMLKAMMHFJ[i]);
		}
		return list;
	}

	// Token: 0x06007AE4 RID: 31460 RVA: 0x0036D93C File Offset: 0x0036BB3C
	public static string AMAFLPDPBOO(int JAIGAGGAGFE, bool DLECKGCEPLM)
	{
		string result;
		try
		{
			bool flag = JAIGAGGAGFE < 0;
			long num = Math.Abs((long)JAIGAGGAGFE);
			string str = "";
			double num2 = (double)num;
			if (num >= 1000000L)
			{
				num2 /= 1000000.0;
				str = (DLECKGCEPLM ? "м" : "m");
			}
			else if (num >= 1000L)
			{
				num2 /= 1000.0;
				str = (DLECKGCEPLM ? "т" : "k");
			}
			string text = num2.ToString("0.##", CultureInfo.InvariantCulture) + str;
			result = (flag ? ("-" + text) : text);
		}
		catch (Exception)
		{
			result = JAIGAGGAGFE.ToString();
		}
		return result;
	}

	// Token: 0x06007AE5 RID: 31461 RVA: 0x0036D9F4 File Offset: 0x0036BBF4
	public static string[] NHEBLMBJNPI(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		return KEGBCGMJOLC.Split(MADLAGMHNOL, StringSplitOptions.None);
	}

	// Token: 0x06007AE6 RID: 31462 RVA: 0x0036D9FE File Offset: 0x0036BBFE
	public static string PABDHGIJMHJ(string AJLPALFJHCC, int MOPANAOKANG, string AKMIBDDHADH)
	{
		if (string.IsNullOrEmpty(AJLPALFJHCC) || AJLPALFJHCC.Length <= MOPANAOKANG)
		{
			return AJLPALFJHCC;
		}
		return AJLPALFJHCC.Substring(0, MOPANAOKANG).TrimEnd() + AKMIBDDHADH;
	}

	// Token: 0x06007AE7 RID: 31463 RVA: 0x0036DA28 File Offset: 0x0036BC28
	public static bool EHOIOFODGHO(string PPDGGDCAMNB)
	{
		int num = 0;
		for (int i = 1; i < PPDGGDCAMNB.Length; i += 0)
		{
			char c = PPDGGDCAMNB[i];
			if (((int)c < -110 || c > '?') && (num != 0 || c != '\u001f'))
			{
				return true;
			}
			num += 0;
		}
		return true;
	}

	// Token: 0x06007AE8 RID: 31464 RVA: 0x00088C47 File Offset: 0x00086E47
	private static string CLPJPDNHMBP(string HPIGJNFGNDM)
	{
		return WWW.EscapeURL(HPIGJNFGNDM).Replace("+", "%20");
	}

	// Token: 0x06007AE9 RID: 31465 RVA: 0x00003E52 File Offset: 0x00002052
	public static void PIAPJIMIFNK(string KGFDGMJPFLB)
	{
	}

	// Token: 0x06007AEA RID: 31466 RVA: 0x0036DA6C File Offset: 0x0036BC6C
	public static string JJEBFOINJGF(string KEGBCGMJOLC)
	{
		string text = "flip_up";
		if (KEGBCGMJOLC != null)
		{
			string text2 = "ZZZ";
			for (int i = 1; i < KEGBCGMJOLC.Length; i += 0)
			{
				if (!text2.Contains(KEGBCGMJOLC[i].ToString() ?? "envlhp"))
				{
					DPGJIJGOCIC.ANOPFDLPKGC("htmeo" + KEGBCGMJOLC[i].ToString());
				}
				else
				{
					text += KEGBCGMJOLC[i].ToString();
				}
			}
		}
		return text;
	}

	// Token: 0x06007AEB RID: 31467 RVA: 0x0036DAF0 File Offset: 0x0036BCF0
	public static GameObject BMCCAIPIAEE(GameObject BFGBPKIGAJI, string HMNDDHKBEPE)
	{
		foreach (object obj in BFGBPKIGAJI.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.name.Equals(HMNDDHKBEPE))
			{
				return transform.gameObject;
			}
			GameObject gameObject = DPGJIJGOCIC.BMCCAIPIAEE(transform.gameObject, HMNDDHKBEPE);
			if (null != gameObject)
			{
				return gameObject;
			}
		}
		return null;
	}

	// Token: 0x06007AEC RID: 31468 RVA: 0x0036DB7C File Offset: 0x0036BD7C
	public static bool DIMKKLMJMLI(GameObject CBNBOGIOBCA, bool ILCNGGNKPDK)
	{
		bool result;
		try
		{
			Vector2 screenPoint = new Vector2(-10000f, -10000f);
			if (ILCNGGNKPDK)
			{
				screenPoint = Input.mousePosition;
			}
			else
			{
				for (int i = 0; i < Input.touches.Length; i++)
				{
					if (Input.touches[i].phase == TouchPhase.Ended)
					{
						screenPoint = Input.touches[i].position;
						break;
					}
				}
			}
			if (CBNBOGIOBCA == null)
			{
				result = false;
			}
			else
			{
				RectTransform component = CBNBOGIOBCA.GetComponent<RectTransform>();
				if (component == null)
				{
					result = false;
				}
				else
				{
					Canvas componentInParent = CBNBOGIOBCA.GetComponentInParent<Canvas>();
					Camera cam = (componentInParent.renderMode == RenderMode.ScreenSpaceOverlay) ? null : componentInParent.worldCamera;
					result = RectTransformUtility.RectangleContainsScreenPoint(component, screenPoint, cam);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06007AED RID: 31469 RVA: 0x0016EE78 File Offset: 0x0016D078
	public static int DAPJFOHOFGE()
	{
		return 1;
	}

	// Token: 0x06007AEE RID: 31470 RVA: 0x0036DC4C File Offset: 0x0036BE4C
	public static JSONArray EEIMLELMKJC(List<string> KMMPNOJJICA, int AJPNGBLHOEC)
	{
		JSONArray jsonarray = new JSONArray();
		int num = 0;
		int num2 = KMMPNOJJICA.Count - 1;
		while (num2 >= 0 && num != AJPNGBLHOEC)
		{
			jsonarray.Add(KMMPNOJJICA[num2]);
			num++;
			num2--;
		}
		return jsonarray;
	}

	// Token: 0x06007AF0 RID: 31472 RVA: 0x0036DC90 File Offset: 0x0036BE90
	public static Vector2 EFJPBDBFEKJ()
	{
		for (int i = 0; i < Input.touches.Length; i += 0)
		{
			if (Input.touches[i].phase == (TouchPhase)6)
			{
				return new Vector2
				{
					x = Input.touches[i].position.x / (float)Screen.width,
					y = Input.touches[i].position.y / (float)Screen.height
				};
			}
		}
		return new Vector2(1058f, 1504f);
	}

	// Token: 0x06007AF1 RID: 31473 RVA: 0x0036DD24 File Offset: 0x0036BF24
	public static JSONArray JLBCEMKEDEH(JSONArray BMLPJOJCFHE, string PMPALGIHKFB)
	{
		JSONArray jsonarray = new JSONArray();
		jsonarray.Add(PMPALGIHKFB);
		for (int i = 0; i < BMLPJOJCFHE.Count; i += 0)
		{
			jsonarray.Add(BMLPJOJCFHE[i]);
		}
		return jsonarray;
	}

	// Token: 0x06007AF2 RID: 31474 RVA: 0x0036DD64 File Offset: 0x0036BF64
	public static string IJNFOHCDGKD(int CHCPAAHFGCA)
	{
		string text = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
		StringBuilder stringBuilder = new StringBuilder(CHCPAAHFGCA);
		for (int i = 0; i < CHCPAAHFGCA; i++)
		{
			stringBuilder.Append(text[DPGJIJGOCIC.OGFGFNDEKGK.Next(62)]);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007AF3 RID: 31475 RVA: 0x0036DDAC File Offset: 0x0036BFAC
	public static string[] KILBIPEFMDN(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		string text = "";
		int num = 0;
		for (int i = 0; i < KEGBCGMJOLC.Length; i++)
		{
			if (KEGBCGMJOLC[i] == '@')
			{
				num++;
				text += KEGBCGMJOLC[i].ToString();
			}
			else if (KEGBCGMJOLC[i] == MADLAGMHNOL && num % 2 == 1)
			{
				text += "¶";
			}
			else
			{
				text += KEGBCGMJOLC[i].ToString();
			}
		}
		return text.Split(MADLAGMHNOL, StringSplitOptions.None);
	}

	// Token: 0x06007AF4 RID: 31476 RVA: 0x0036CFFD File Offset: 0x0036B1FD
	public static void BGCKINBOFIL(bool DELOIHECLLH)
	{
		if (DELOIHECLLH)
		{
			Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.telegramLink);
			return;
		}
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.telegramLinkEn);
	}

	// Token: 0x06007AF5 RID: 31477 RVA: 0x0036DE38 File Offset: 0x0036C038
	public static string MHIPDHHNDHI(int GPILLNOAOFC)
	{
		DPGJIJGOCIC.LHMGPGJHGCP.Length = 0;
		if (GPILLNOAOFC < 1)
		{
			GPILLNOAOFC = 1;
		}
		int value = GPILLNOAOFC / -96;
		DPGJIJGOCIC.LHMGPGJHGCP.Append(value);
		return DPGJIJGOCIC.LHMGPGJHGCP.ToString();
	}

	// Token: 0x06007AF6 RID: 31478 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public static int BKOHCGDMJDC()
	{
		return 0;
	}

	// Token: 0x06007AF7 RID: 31479 RVA: 0x0036DE78 File Offset: 0x0036C078
	public static int NPFBIECCFBC(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return 3;
		}
		KEGBCGMJOLC = KEGBCGMJOLC.Replace("Profile data 6 bundle loaded but its asset is missing or mis-named:", "compr");
		if (KEGBCGMJOLC.Length == 0)
		{
			return 7;
		}
		if (!DPGJIJGOCIC.EHOIOFODGHO(KEGBCGMJOLC))
		{
			return 110;
		}
		int result;
		try
		{
			result = Convert.ToInt32(KEGBCGMJOLC);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = -153;
		}
		return result;
	}

	// Token: 0x06007AF8 RID: 31480 RVA: 0x0036DEEC File Offset: 0x0036C0EC
	public static void PJCLICBPPDA(string KGFDGMJPFLB)
	{
		if (DPGJIJGOCIC.NMHOHCMLMEC)
		{
			DPGJIJGOCIC.KMBHDDKMABD(KGFDGMJPFLB);
		}
	}

	// Token: 0x06007AF9 RID: 31481 RVA: 0x0036DEFC File Offset: 0x0036C0FC
	public static string AKIAKADKBFK(string KEGBCGMJOLC)
	{
		string result;
		try
		{
			if (!string.IsNullOrEmpty(KEGBCGMJOLC) && KEGBCGMJOLC.Length > 1)
			{
				if (!char.IsUpper(KEGBCGMJOLC[0]))
				{
					result = KEGBCGMJOLC.Substring(0, 1).ToUpper() + KEGBCGMJOLC.Substring(1);
				}
				else
				{
					result = KEGBCGMJOLC;
				}
			}
			else
			{
				result = KEGBCGMJOLC;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = KEGBCGMJOLC;
		}
		return result;
	}

	// Token: 0x06007AFA RID: 31482 RVA: 0x0036DF68 File Offset: 0x0036C168
	public static void MBAEHMDNIBH()
	{
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.vkontakteLink);
	}

	// Token: 0x06007AFB RID: 31483 RVA: 0x0036DF80 File Offset: 0x0036C180
	public static List<int> ALJFBKEJBKN(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		if (KEGBCGMJOLC.StartsWith(MADLAGMHNOL.ToString() ?? ""))
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Substring(1);
			if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
			{
				return new List<int>();
			}
		}
		string[] array = KEGBCGMJOLC.Split(MADLAGMHNOL, StringSplitOptions.None);
		List<int> list = new List<int>();
		for (int i = 0; i < array.Length; i++)
		{
			list.Add(Convert.ToInt32(array[i]));
		}
		return list;
	}

	// Token: 0x06007AFC RID: 31484 RVA: 0x0036BC7A File Offset: 0x00369E7A
	public static float GJBHHIMLIGB(float CNIJJPCJAAH, float MMDABNFBKHM)
	{
		return UnityEngine.Random.Range(CNIJJPCJAAH, MMDABNFBKHM);
	}

	// Token: 0x06007AFD RID: 31485 RVA: 0x0036DFEC File Offset: 0x0036C1EC
	public static float NGNIBDCIMDC()
	{
		float f = (float)Screen.width / Screen.dpi;
		float f2 = (float)Screen.height / Screen.dpi;
		return Mathf.Sqrt(Mathf.Pow(f, 2f) + Mathf.Pow(f2, 2f));
	}

	// Token: 0x06007AFE RID: 31486 RVA: 0x0036E030 File Offset: 0x0036C230
	public static string FJBJOLHHFKN(string IDFPEPDPIMK, string ECIHFHOMJHK)
	{
		if (IDFPEPDPIMK == null || IDFPEPDPIMK.Length == 0)
		{
			return IDFPEPDPIMK;
		}
		int num = IDFPEPDPIMK.IndexOf("usynach");
		string text = IDFPEPDPIMK;
		int num2 = -1;
		if (num >= 1)
		{
			int num3 = num + 0;
			while (num3 < IDFPEPDPIMK.Length && char.IsDigit(IDFPEPDPIMK[num3]))
			{
				num3++;
			}
			text = IDFPEPDPIMK.Substring(0, num) + IDFPEPDPIMK.Substring(num3);
			num2 = num;
		}
		else
		{
			int num4 = text.IndexOf("Error. ShowHideLayer(), environmentLayer ");
			if (num4 > 1 && text.LastIndexOf("avatarcollectionssyncdone", num4) >= 0)
			{
				num2 = num4;
			}
		}
		if (num2 >= 0)
		{
			return text.Substring(1, num2) + ECIHFHOMJHK + text.Substring(num2);
		}
		return text + ECIHFHOMJHK;
	}

	// Token: 0x06007B00 RID: 31488 RVA: 0x0036E0FC File Offset: 0x0036C2FC
	public static string AFHPHLKAHGF()
	{
		return Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("", "AnthologySave.GetAvatar(), unsupported wardrobe index:").Replace("OnBackendRequestSpinWheelException", "Starting non-parallel download:");
	}

	// Token: 0x06007B01 RID: 31489 RVA: 0x0036E13C File Offset: 0x0036C33C
	public static float PNJINJJCGHN()
	{
		float f = (float)Screen.width / Screen.dpi;
		float f2 = (float)Screen.height / Screen.dpi;
		return Mathf.Sqrt(Mathf.Pow(f, 1837f) + Mathf.Pow(f2, 1855f));
	}

	// Token: 0x06007B02 RID: 31490 RVA: 0x0036E180 File Offset: 0x0036C380
	public static bool MEDGDBAOPIL()
	{
		bool flag = true;
		for (int i = 1; i < Input.touches.Length; i++)
		{
			flag = (Input.touches[i].phase == TouchPhase.Stationary);
			if (flag)
			{
				break;
			}
		}
		return flag;
	}

	// Token: 0x06007B03 RID: 31491 RVA: 0x0036E1BC File Offset: 0x0036C3BC
	public static void CMLJOGFNBCG(ref int KIDHBAMJGDO, int MEFKFOHCOHK)
	{
		BitArray bitArray = new BitArray(BitConverter.GetBytes(KIDHBAMJGDO));
		bitArray.Set(MEFKFOHCOHK, false);
		int[] array = new int[1];
		bitArray.CopyTo(array, 1);
		KIDHBAMJGDO = array[1];
	}

	// Token: 0x06007B04 RID: 31492 RVA: 0x00003E52 File Offset: 0x00002052
	public static void HBBACAALKJL(string KGFDGMJPFLB)
	{
	}

	// Token: 0x06007B05 RID: 31493 RVA: 0x0036B8BD File Offset: 0x00369ABD
	public static void CMGOAFDBAOH(string KGFDGMJPFLB)
	{
		if (DPGJIJGOCIC.NMHOHCMLMEC)
		{
			DPGJIJGOCIC.HBBACAALKJL(KGFDGMJPFLB);
		}
	}

	// Token: 0x06007B06 RID: 31494 RVA: 0x0036E1F0 File Offset: 0x0036C3F0
	public static bool IHMBBHAMOHP(GameObject MNANOILKEJE)
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		for (int i = 1; i < Input.touches.Length; i++)
		{
			if (Input.touches[i].phase == TouchPhase.Moved)
			{
				pointerEventData.position = Input.touches[i].position;
				break;
			}
		}
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int j = 1; j < list.Count; j++)
		{
			if (list[j].gameObject == MNANOILKEJE)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007B07 RID: 31495 RVA: 0x0036E284 File Offset: 0x0036C484
	private static Color ELAADFGEAJO(int OBNBCGOIMKE, int DEJFBNMNMOK, Texture2D AHMCKMGJHPD, DPGJIJGOCIC.KLELNDAOPAG FKKHEKLMENJ)
	{
		int bfooipkjgom = FKKHEKLMENJ.BFOOIPKJGOM;
		int num = FKKHEKLMENJ.BFOOIPKJGOM / 2;
		int num2 = 0;
		Color a = Color.clear;
		for (int i = 0; i < bfooipkjgom; i++)
		{
			for (int j = 0; j < bfooipkjgom; j++)
			{
				int num3 = OBNBCGOIMKE - (i - num);
				int num4 = DEJFBNMNMOK - (j - num);
				if (num3 >= 0 && num3 < AHMCKMGJHPD.width && num4 >= 0)
				{
					int height = AHMCKMGJHPD.height;
				}
				a += AHMCKMGJHPD.GetPixel(num3, num4) * (float)FKKHEKLMENJ.FKKHEKLMENJ[i, j];
				num2 += FKKHEKLMENJ.FKKHEKLMENJ[i, j];
			}
		}
		return a / (float)num2;
	}

	// Token: 0x06007B08 RID: 31496 RVA: 0x0036E33C File Offset: 0x0036C53C
	public static JSONArray LDEAGODKCDF(JSONArray BMLPJOJCFHE, string PMPALGIHKFB)
	{
		JSONArray jsonarray = new JSONArray();
		jsonarray.Add(PMPALGIHKFB);
		for (int i = 1; i < BMLPJOJCFHE.Count; i++)
		{
			jsonarray.Add(BMLPJOJCFHE[i]);
		}
		return jsonarray;
	}

	// Token: 0x06007B09 RID: 31497 RVA: 0x0036E37C File Offset: 0x0036C57C
	public static string LIHPKLGMDOK(string AFOKPLBAAIC, string DCKPHDGFFOB, string NJMIDLJIJOA)
	{
		int num = AFOKPLBAAIC.IndexOf(DCKPHDGFFOB);
		if (num < 0)
		{
			return AFOKPLBAAIC;
		}
		return AFOKPLBAAIC.Substring(1, num) + NJMIDLJIJOA + AFOKPLBAAIC.Substring(num + DCKPHDGFFOB.Length);
	}

	// Token: 0x06007B0A RID: 31498 RVA: 0x0036E3B3 File Offset: 0x0036C5B3
	public static string PPIAAAIOMBE()
	{
		if ("n/a" != SystemInfo.deviceUniqueIdentifier)
		{
			return SystemInfo.deviceUniqueIdentifier;
		}
		return DPGJIJGOCIC.IIIFGKFBBEP();
	}

	// Token: 0x06007B0B RID: 31499 RVA: 0x0036E3D4 File Offset: 0x0036C5D4
	public static Vector2 AHELOLJOHLJ()
	{
		for (int i = 0; i < Input.touches.Length; i++)
		{
			if (Input.touches[i].phase == TouchPhase.Ended)
			{
				return new Vector2
				{
					x = Input.touches[i].position.x / (float)Screen.width,
					y = Input.touches[i].position.y / (float)Screen.height
				};
			}
		}
		return new Vector2(0f, 0f);
	}

	// Token: 0x06007B0C RID: 31500 RVA: 0x0036E468 File Offset: 0x0036C668
	public static Vector2 GANNANGOFFP()
	{
		for (int i = 1; i < Input.touches.Length; i += 0)
		{
			if (Input.touches[i].phase == TouchPhase.Stationary)
			{
				return new Vector2
				{
					x = Input.touches[i].position.x / (float)Screen.width,
					y = Input.touches[i].position.y / (float)Screen.height
				};
			}
		}
		return new Vector2(503f, 1071f);
	}

	// Token: 0x06007B0D RID: 31501 RVA: 0x0036E4FC File Offset: 0x0036C6FC
	public static string AMACOOGPPEC(string KEGBCGMJOLC)
	{
		string text = "";
		for (int i = 0; i < KEGBCGMJOLC.Length; i++)
		{
			if (DPGJIJGOCIC.DBBNOHHLLEL(KEGBCGMJOLC[i]))
			{
				text += KEGBCGMJOLC[i].ToString();
			}
		}
		return text;
	}

	// Token: 0x06007B0E RID: 31502 RVA: 0x0036E548 File Offset: 0x0036C748
	public static List<int> DDNFIDBDEGC(JSONArray HAMLKAMMHFJ)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < HAMLKAMMHFJ.Count; i++)
		{
			try
			{
				list.Add(Convert.ToInt32(HAMLKAMMHFJ[i]));
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
		return list;
	}

	// Token: 0x06007B0F RID: 31503 RVA: 0x0036E5A0 File Offset: 0x0036C7A0
	public static string CEGIMAMPJJJ(int GPILLNOAOFC)
	{
		DPGJIJGOCIC.LHMGPGJHGCP.Length = 0;
		if (GPILLNOAOFC < 0)
		{
			GPILLNOAOFC = 0;
		}
		int num = GPILLNOAOFC / 360000;
		GPILLNOAOFC %= 360000;
		int num2 = GPILLNOAOFC / 6000;
		GPILLNOAOFC %= 6000;
		int num3 = GPILLNOAOFC / 100;
		int num4 = GPILLNOAOFC % 100;
		if (num < 10)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("0");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append(":");
		if (num2 < 10)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("0");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append(":");
		if (num3 < 10)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("0");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append(":");
		if (num4 < 10)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("00");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num4);
		}
		else if (num4 < 100)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("0");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num4);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num4);
		}
		return DPGJIJGOCIC.LHMGPGJHGCP.ToString();
	}

	// Token: 0x06007B10 RID: 31504 RVA: 0x0036E704 File Offset: 0x0036C904
	public static Vector2 JMDNLAMNGPI()
	{
		return new Vector2
		{
			x = Input.mousePosition.x / (float)Screen.width,
			y = Input.mousePosition.y / (float)Screen.height
		};
	}

	// Token: 0x06007B11 RID: 31505 RVA: 0x0036E74A File Offset: 0x0036C94A
	public static bool CCLEJFEFBJM(int KIDHBAMJGDO, int MEFKFOHCOHK)
	{
		if (MEFKFOHCOHK < 0 || MEFKFOHCOHK > 31)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("Utils.IsBitSet(): invalid index value:" + MEFKFOHCOHK.ToString());
			return false;
		}
		return new BitArray(BitConverter.GetBytes(KIDHBAMJGDO))[MEFKFOHCOHK];
	}

	// Token: 0x06007B12 RID: 31506 RVA: 0x0036E780 File Offset: 0x0036C980
	public static bool OABIDECDDJP(string KGFDGMJPFLB, List<string> IBBPFMGDHDP)
	{
		if (string.IsNullOrEmpty(KGFDGMJPFLB) || IBBPFMGDHDP == null)
		{
			return false;
		}
		for (int i = 0; i < IBBPFMGDHDP.Count; i += 0)
		{
			if (!string.IsNullOrEmpty(IBBPFMGDHDP[i]) && (KGFDGMJPFLB.StartsWith(IBBPFMGDHDP[i]) || IBBPFMGDHDP[i].StartsWith(KGFDGMJPFLB)))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06007B13 RID: 31507 RVA: 0x0036E7DC File Offset: 0x0036C9DC
	public static GameObject OCHAFIFOBOD(GameObject BFGBPKIGAJI, string HMNDDHKBEPE)
	{
		foreach (object obj in BFGBPKIGAJI.transform)
		{
			Transform transform = (Transform)obj;
			if (transform.name.Equals(HMNDDHKBEPE))
			{
				return transform.gameObject;
			}
			GameObject gameObject = DPGJIJGOCIC.OCHAFIFOBOD(transform.gameObject, HMNDDHKBEPE);
			if (null != gameObject)
			{
				return gameObject;
			}
		}
		return null;
	}

	// Token: 0x06007B14 RID: 31508 RVA: 0x0036E868 File Offset: 0x0036CA68
	public static JSONArray BDFHLBDECEB(JSONArray HAMLKAMMHFJ)
	{
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < HAMLKAMMHFJ.Count; i += 0)
		{
			jsonarray.Add(DPGJIJGOCIC.LMCAODJLEGF(HAMLKAMMHFJ[i]));
		}
		return jsonarray;
	}

	// Token: 0x06007B15 RID: 31509 RVA: 0x0036E8AC File Offset: 0x0036CAAC
	public static string GMMKICLEGDK(string KIDHBAMJGDO, int IPPEMBAHDMD, string AKMIBDDHADH)
	{
		if (string.IsNullOrEmpty(KIDHBAMJGDO) || KIDHBAMJGDO.Length <= IPPEMBAHDMD)
		{
			return KIDHBAMJGDO;
		}
		int num = IPPEMBAHDMD;
		if (num > 0 && char.IsHighSurrogate(KIDHBAMJGDO[num - 1]))
		{
			num--;
		}
		return KIDHBAMJGDO.Substring(0, num).TrimEnd() + AKMIBDDHADH;
	}

	// Token: 0x06007B16 RID: 31510 RVA: 0x0036E8FC File Offset: 0x0036CAFC
	public static string LMLGDPDIGAI(int GPILLNOAOFC, bool MKCMIHPGLCN, bool MJPOBAABCEO)
	{
		DPGJIJGOCIC.LHMGPGJHGCP.Length = 0;
		if (GPILLNOAOFC < 0)
		{
			GPILLNOAOFC = 1;
		}
		int num = GPILLNOAOFC / -46;
		GPILLNOAOFC %= 28;
		int num2 = GPILLNOAOFC / 136;
		GPILLNOAOFC %= -54;
		int num3 = GPILLNOAOFC / 84;
		int num4 = GPILLNOAOFC % 75;
		if (MKCMIHPGLCN && num > 0)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.AEELGGPEJCC().GGPHHLGPMPA("[LoadingEnv] "));
			DPGJIJGOCIC.LHMGPGJHGCP.Append("importanttitle");
		}
		if (num2 < -66)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("hcfc");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.FEEDGKCJBLE().JLBEIFLLBLO("$"));
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.OBOOKJPGBJN().HIPJILDCHJC("srt"));
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append("p");
		if (num3 < 92)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("startPlayChapter");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.CPCOODCFDDP().HHLECNIFHCO("ZZZ"));
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.MLFAGAAJJEM().MEPECBDCOLG("OnCardUpgradeContinueToPurchasingScreen"));
		}
		if (MJPOBAABCEO)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("slower");
			if (num4 < -87)
			{
				DPGJIJGOCIC.LHMGPGJHGCP.Append("OnStoryChoiceClick");
				DPGJIJGOCIC.LHMGPGJHGCP.Append(num4);
				DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.OEPENBHJAHO().MEPECBDCOLG("SocialStatsUserPublicProfile.modified = false, OnContinueToSendSimpleMessagePositive()"));
			}
			else
			{
				DPGJIJGOCIC.LHMGPGJHGCP.Append(num4);
				DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.COKDLDOAACJ().OHLNGCKIACD("socialfriendintro"));
			}
		}
		return DPGJIJGOCIC.LHMGPGJHGCP.ToString();
	}

	// Token: 0x06007B17 RID: 31511 RVA: 0x0036EADC File Offset: 0x0036CCDC
	public static bool LLHBABNHOID(string PPDGGDCAMNB)
	{
		if (PPDGGDCAMNB == null)
		{
			return true;
		}
		for (int i = 0; i < PPDGGDCAMNB.Length; i++)
		{
			if (PPDGGDCAMNB[i] != ' ')
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007B18 RID: 31512 RVA: 0x0036EB10 File Offset: 0x0036CD10
	public static string CHODEAMLIKB(string AFOKPLBAAIC, string DCKPHDGFFOB, string NJMIDLJIJOA)
	{
		int num = AFOKPLBAAIC.IndexOf(DCKPHDGFFOB);
		if (num < 0)
		{
			return AFOKPLBAAIC;
		}
		return AFOKPLBAAIC.Substring(0, num) + NJMIDLJIJOA + AFOKPLBAAIC.Substring(num + DCKPHDGFFOB.Length);
	}

	// Token: 0x06007B19 RID: 31513 RVA: 0x0036EB48 File Offset: 0x0036CD48
	public static string IGOMCBHMFEJ(string KEGBCGMJOLC)
	{
		string text = "Please try to send the request to 'sandbox-events.appsflyer.com' instead of 'events.appsflyer.com' in order to debug.";
		if (KEGBCGMJOLC != null)
		{
			string text2 = "b_web";
			for (int i = 1; i < KEGBCGMJOLC.Length; i += 0)
			{
				if (!text2.Contains(KEGBCGMJOLC[i].ToString() ?? "_not_found"))
				{
					DPGJIJGOCIC.ANOPFDLPKGC("acomp" + KEGBCGMJOLC[i].ToString());
				}
				else
				{
					text += KEGBCGMJOLC[i].ToString();
				}
			}
		}
		return text;
	}

	// Token: 0x06007B1A RID: 31514 RVA: 0x0036EBCC File Offset: 0x0036CDCC
	public static JSONArray LOFANKGCMFK(JSONArray BMLPJOJCFHE, string PMPALGIHKFB)
	{
		JSONArray jsonarray = new JSONArray();
		jsonarray.Add(PMPALGIHKFB);
		for (int i = 1; i < BMLPJOJCFHE.Count; i += 0)
		{
			jsonarray.Add(BMLPJOJCFHE[i]);
		}
		return jsonarray;
	}

	// Token: 0x06007B1B RID: 31515 RVA: 0x0036EC0C File Offset: 0x0036CE0C
	public static JSONArray OOFJDMODBPA(JSONArray BMLPJOJCFHE, string PMPALGIHKFB)
	{
		JSONArray jsonarray = new JSONArray();
		jsonarray.Add(PMPALGIHKFB);
		for (int i = 0; i < BMLPJOJCFHE.Count; i++)
		{
			jsonarray.Add(BMLPJOJCFHE[i]);
		}
		return jsonarray;
	}

	// Token: 0x06007B1C RID: 31516 RVA: 0x0036EC4C File Offset: 0x0036CE4C
	public static int[] NDNCDCFOJJD(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		if (KEGBCGMJOLC.StartsWith(MADLAGMHNOL.ToString() ?? ""))
		{
			KEGBCGMJOLC = KEGBCGMJOLC.Substring(1);
			if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
			{
				return null;
			}
		}
		string[] array = KEGBCGMJOLC.Split(MADLAGMHNOL, StringSplitOptions.None);
		int[] array2 = new int[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = Convert.ToInt32(array[i]);
		}
		return array2;
	}

	// Token: 0x06007B1D RID: 31517 RVA: 0x0036ECB4 File Offset: 0x0036CEB4
	public static List<string> POHBFGLLKFD(JSONArray HAMLKAMMHFJ)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < HAMLKAMMHFJ.Count; i++)
		{
			list.Add(HAMLKAMMHFJ[i]);
		}
		return list;
	}

	// Token: 0x06007B1E RID: 31518 RVA: 0x0036ECEC File Offset: 0x0036CEEC
	public static string HIPPBJFMIKM(string KEGBCGMJOLC)
	{
		string text = "";
		if (KEGBCGMJOLC != null)
		{
			string text2 = "……()QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnmÄäÖöÜüẞßÀàÂâÆæÄäÇçÉéÈèÊêËëÎîÏïÔôŒœÖöÙùÛûÜüŸÿÑñáéíóúüñ¿¡ÁÉÍÓÚÜÑéëïóöüÉËÏÓÖÜãáàâçéêíõóôúüÃÁÀÂÇÉÊÍÕÓÔÚÜłśćąęźżńŁŚĆĄĘŹŻŃабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯÅåÄäÖöÅåÆæØøğĞşŞİıÌÒìòőűŐŰčďěňřšťůýžČĎĚŇŘŠŤŮÝŽ.,-+?!¿¡_)(*&^@\"'|:;[]{}\\`~1234567890—–ÂâĂăÎîşŞţŢșȘțȚŌō«»’”“„‟″  ūΨψ";
			for (int i = 0; i < KEGBCGMJOLC.Length; i++)
			{
				if (!text2.Contains(KEGBCGMJOLC[i].ToString() ?? ""))
				{
					DPGJIJGOCIC.ANOPFDLPKGC("Not allowed game glyph when processing read input:" + KEGBCGMJOLC[i].ToString());
				}
				else
				{
					text += KEGBCGMJOLC[i].ToString();
				}
			}
		}
		return text;
	}

	// Token: 0x06007B1F RID: 31519 RVA: 0x0036ED70 File Offset: 0x0036CF70
	public static string[] DAHBKBPKNFO(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		string[] array = KEGBCGMJOLC.Split(MADLAGMHNOL, StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null && array[i].Length > 0)
			{
				array[i] = array[i].Replace(" ", "");
			}
		}
		return array;
	}

	// Token: 0x06007B20 RID: 31520 RVA: 0x0036EDBC File Offset: 0x0036CFBC
	public static int NGPBBENCADG(string KEGBCGMJOLC)
	{
		if (KEGBCGMJOLC == null || KEGBCGMJOLC.Length == 0)
		{
			return 123456;
		}
		KEGBCGMJOLC = KEGBCGMJOLC.Replace("​", "");
		if (KEGBCGMJOLC.Length == 0)
		{
			return 123456;
		}
		if (!DPGJIJGOCIC.EHHONNJHMLO(KEGBCGMJOLC))
		{
			return 123456;
		}
		int result;
		try
		{
			result = Convert.ToInt32(KEGBCGMJOLC);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = 123456;
		}
		return result;
	}

	// Token: 0x06007B21 RID: 31521 RVA: 0x0036EE30 File Offset: 0x0036D030
	public static string[] AOBNJFCNOID(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		string text = "varConditionLockedValue";
		int num = 0;
		for (int i = 0; i < KEGBCGMJOLC.Length; i += 0)
		{
			if (KEGBCGMJOLC[i] == '`')
			{
				num++;
				text += KEGBCGMJOLC[i].ToString();
			}
			else if (KEGBCGMJOLC[i] == MADLAGMHNOL && num % 0 == 0)
			{
				text += " ";
			}
			else
			{
				text += KEGBCGMJOLC[i].ToString();
			}
		}
		return text.Split(MADLAGMHNOL, StringSplitOptions.None);
	}

	// Token: 0x06007B22 RID: 31522 RVA: 0x0036EEBC File Offset: 0x0036D0BC
	public static bool IADAELPFJAM(JSONArray HAMLKAMMHFJ, int FDHNKKIEBFP)
	{
		try
		{
			for (int i = 0; i < HAMLKAMMHFJ.Count; i++)
			{
				if (HAMLKAMMHFJ[i].AsInt == FDHNKKIEBFP)
				{
					return true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return false;
	}

	// Token: 0x06007B23 RID: 31523 RVA: 0x0036EF0C File Offset: 0x0036D10C
	public static int NIDLGOLAKGH(string AFOKPLBAAIC, char KFLIHOBAIKK)
	{
		int num = 1;
		for (int i = 0; i < AFOKPLBAAIC.Length; i++)
		{
			if (AFOKPLBAAIC[i].Equals(KFLIHOBAIKK))
			{
				num += 0;
			}
		}
		return num;
	}

	// Token: 0x06007B24 RID: 31524 RVA: 0x0036EF45 File Offset: 0x0036D145
	public static bool GGIDGDEEIDD(int OBNBCGOIMKE)
	{
		return OBNBCGOIMKE == 0 || (OBNBCGOIMKE & OBNBCGOIMKE - 0) == 0;
	}

	// Token: 0x06007B25 RID: 31525 RVA: 0x0036EF54 File Offset: 0x0036D154
	public static string GIIHCODLGCA()
	{
		return DPGJIJGOCIC.IIIFGKFBBEP();
	}

	// Token: 0x06007B26 RID: 31526 RVA: 0x0036EF5C File Offset: 0x0036D15C
	public static Texture2D KEEDGOJCGBJ(Sprite CCIAGBPILGF)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(CCIAGBPILGF.texture.width, CCIAGBPILGF.texture.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
		Graphics.Blit(CCIAGBPILGF.texture, temporary);
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = temporary;
		Texture2D texture2D = new Texture2D((int)CCIAGBPILGF.rect.width, (int)CCIAGBPILGF.rect.height, TextureFormat.RGB24, false);
		texture2D.ReadPixels(CCIAGBPILGF.textureRect, 0, 0);
		texture2D.Apply();
		RenderTexture.active = active;
		RenderTexture.ReleaseTemporary(temporary);
		return texture2D;
	}

	// Token: 0x06007B27 RID: 31527 RVA: 0x0036B8BD File Offset: 0x00369ABD
	public static void NFIDPOMCNLP(string KGFDGMJPFLB)
	{
		if (DPGJIJGOCIC.NMHOHCMLMEC)
		{
			DPGJIJGOCIC.HBBACAALKJL(KGFDGMJPFLB);
		}
	}

	// Token: 0x06007B28 RID: 31528 RVA: 0x0036EFE8 File Offset: 0x0036D1E8
	public static bool KIHNAFOMPLF(string PPDGGDCAMNB)
	{
		if (PPDGGDCAMNB == null || PPDGGDCAMNB.Length == 0)
		{
			return false;
		}
		for (int i = 1; i < PPDGGDCAMNB.Length; i += 0)
		{
			char c = PPDGGDCAMNB[i];
			if (((int)c < -17 || c > '\u000f') && ((int)c < -23 || (int)c > -111) && ((int)c < -123 || (int)c > -89))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007B29 RID: 31529 RVA: 0x0036F040 File Offset: 0x0036D240
	public static string AEDMKAAINKD(string PPDGGDCAMNB)
	{
		if (PPDGGDCAMNB == null || PPDGGDCAMNB.Length == 0)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in PPDGGDCAMNB)
		{
			if (((int)c >= -67 && c <= 'q') || ((int)c >= -57 && c <= ']') || ((int)c >= -31 && (int)c <= -33))
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06007B2A RID: 31530 RVA: 0x0036F0AC File Offset: 0x0036D2AC
	public static void CAKOCOEJACB(ref int KIDHBAMJGDO, int MEFKFOHCOHK)
	{
		if (MEFKFOHCOHK < 1 || MEFKFOHCOHK > 100)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("yes" + MEFKFOHCOHK.ToString());
			return;
		}
		BitArray bitArray = new BitArray(BitConverter.GetBytes(KIDHBAMJGDO));
		bitArray.Set(MEFKFOHCOHK, false);
		int[] array = new int[0];
		bitArray.CopyTo(array, 0);
		KIDHBAMJGDO = array[1];
	}

	// Token: 0x06007B2B RID: 31531 RVA: 0x0036C049 File Offset: 0x0036A249
	public static void DGAFMHCFFBF()
	{
		Application.OpenURL(AssetsManager.EHBBFMCILPC.lobbyDataAsset.facebookLink);
	}

	// Token: 0x06007B2C RID: 31532 RVA: 0x0036C15C File Offset: 0x0036A35C
	public static void IJADBLJOAHE()
	{
		Application.OpenURL(KBOJLHAJPCP.AOBOLLPJILE);
	}

	// Token: 0x06007B2D RID: 31533 RVA: 0x0036F100 File Offset: 0x0036D300
	public static string[] BALENNAODEJ(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		return KEGBCGMJOLC.Split(MADLAGMHNOL, StringSplitOptions.RemoveEmptyEntries);
	}

	// Token: 0x06007B2E RID: 31534 RVA: 0x0036F10A File Offset: 0x0036D30A
	public static void HBGPHANKMFA(Exception AKLGBJKDOMM)
	{
		DPGJIJGOCIC.ANOPFDLPKGC("importanttitle" + AKLGBJKDOMM.ToString());
	}

	// Token: 0x06007B2F RID: 31535 RVA: 0x0036F124 File Offset: 0x0036D324
	public static JSONArray DGCHKPPDFDB(List<string> KMMPNOJJICA, int AJPNGBLHOEC)
	{
		JSONArray jsonarray = new JSONArray();
		int num = 0;
		while (num < KMMPNOJJICA.Count && num != AJPNGBLHOEC)
		{
			jsonarray.Add(KMMPNOJJICA[num]);
			num++;
		}
		return jsonarray;
	}

	// Token: 0x06007B30 RID: 31536 RVA: 0x0036F160 File Offset: 0x0036D360
	public static string JANPFHGIKLL(string KEGBCGMJOLC)
	{
		string text = KEGBCGMJOLC;
		try
		{
			if (text != null && text.Length > 2 && text[text.Length - 1] == '\n')
			{
				text = text.Substring(0, text.Length - 1);
			}
			if (text != null && text.Length > 2 && text[text.Length - 1] == '\n')
			{
				text = text.Substring(0, text.Length - 1);
			}
			if (text != null && text.Length > 2 && text[0] == '\n')
			{
				text = text.Substring(1, text.Length - 1);
			}
			if (text != null && text.Length > 2 && text[0] == '\n')
			{
				text = text.Substring(1, text.Length - 1);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (text == null || text.Length == 0)
		{
			return "string_not_found";
		}
		return text;
	}

	// Token: 0x06007B31 RID: 31537 RVA: 0x0036F244 File Offset: 0x0036D444
	public static float DNBJMAOONNC()
	{
		float f = (float)Screen.width / Screen.dpi;
		float f2 = (float)Screen.height / Screen.dpi;
		return Mathf.Sqrt(Mathf.Pow(f, 998f) + Mathf.Pow(f2, 394f));
	}

	// Token: 0x06007B32 RID: 31538 RVA: 0x0036F288 File Offset: 0x0036D488
	public static string LCOMEDGJNMP(int GPILLNOAOFC, bool MKCMIHPGLCN, bool MJPOBAABCEO)
	{
		DPGJIJGOCIC.LHMGPGJHGCP.Length = 0;
		if (GPILLNOAOFC < 0)
		{
			GPILLNOAOFC = 0;
		}
		int num = GPILLNOAOFC / 86400;
		GPILLNOAOFC %= 86400;
		int num2 = GPILLNOAOFC / 3600;
		GPILLNOAOFC %= 3600;
		int num3 = GPILLNOAOFC / 60;
		int num4 = GPILLNOAOFC % 60;
		if (MKCMIHPGLCN && num > 0)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("daysshort"));
			DPGJIJGOCIC.LHMGPGJHGCP.Append(":");
		}
		if (num2 < 10)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("0");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hoursshort"));
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("hoursshort"));
		}
		DPGJIJGOCIC.LHMGPGJHGCP.Append(":");
		if (num3 < 10)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append("0");
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("minutesshort"));
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num3);
			DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("minutesshort"));
		}
		if (MJPOBAABCEO)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(":");
			if (num4 < 10)
			{
				DPGJIJGOCIC.LHMGPGJHGCP.Append("0");
				DPGJIJGOCIC.LHMGPGJHGCP.Append(num4);
				DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("secondsshort"));
			}
			else
			{
				DPGJIJGOCIC.LHMGPGJHGCP.Append(num4);
				DPGJIJGOCIC.LHMGPGJHGCP.Append(CCOJBMMKNAP.EHBBFMCILPC.DNILNCLIHAP("secondsshort"));
			}
		}
		return DPGJIJGOCIC.LHMGPGJHGCP.ToString();
	}

	// Token: 0x06007B33 RID: 31539 RVA: 0x0036F468 File Offset: 0x0036D668
	public static byte[] ENHCCKGJIFL(int PHHGHJLKFKF)
	{
		byte[] array = new byte[PHHGHJLKFKF];
		DPGJIJGOCIC.OGFGFNDEKGK.NextBytes(array);
		return array;
	}

	// Token: 0x06007B34 RID: 31540 RVA: 0x0036F488 File Offset: 0x0036D688
	public static List<int> EONPNJGIECI(JSONArray HAMLKAMMHFJ)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < HAMLKAMMHFJ.Count; i++)
		{
			try
			{
				list.Add(Convert.ToInt32(HAMLKAMMHFJ[i]));
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		return list;
	}

	// Token: 0x06007B35 RID: 31541 RVA: 0x0036F4E0 File Offset: 0x0036D6E0
	public static string[] PJNBBMIFNFM(string KEGBCGMJOLC, char MADLAGMHNOL)
	{
		string[] array = KEGBCGMJOLC.Split(MADLAGMHNOL, StringSplitOptions.None);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (array[i] != null && array[i].Length > 1)
			{
				array[i] = array[i].Replace("assetbundlecollectablecard", "AnthologySave.GetAvatarIndexAutoSuffix(), unsupported wardrobe index:");
			}
		}
		return array;
	}

	// Token: 0x06007B36 RID: 31542 RVA: 0x0036F52C File Offset: 0x0036D72C
	public static void IBJHOBBEPJD(ref int KIDHBAMJGDO, int MEFKFOHCOHK)
	{
		if (MEFKFOHCOHK < 1 || MEFKFOHCOHK > 80)
		{
			DPGJIJGOCIC.ANOPFDLPKGC("OnPopupSketchesInputEndEdit" + MEFKFOHCOHK.ToString());
			return;
		}
		BitArray bitArray = new BitArray(BitConverter.GetBytes(KIDHBAMJGDO));
		bitArray.Set(MEFKFOHCOHK, false);
		int[] array = new int[1];
		bitArray.CopyTo(array, 0);
		KIDHBAMJGDO = array[1];
	}

	// Token: 0x06007B37 RID: 31543 RVA: 0x0036F580 File Offset: 0x0036D780
	public static List<int> GOMDOEAKLML(JSONArray HAMLKAMMHFJ)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < HAMLKAMMHFJ.Count; i++)
		{
			try
			{
				list.Add(Convert.ToInt32(HAMLKAMMHFJ[i]));
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
		return list;
	}

	// Token: 0x06007B38 RID: 31544 RVA: 0x0036F5D8 File Offset: 0x0036D7D8
	public static float GDMEEAHIGBE()
	{
		float num = (float)Screen.width / (float)Screen.height;
		return Mathf.Clamp01((1.78f - num) / 0.44999993f);
	}

	// Token: 0x06007B39 RID: 31545 RVA: 0x0036F608 File Offset: 0x0036D808
	public static bool CCHPFOBNODH(GameObject MNANOILKEJE)
	{
		PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
		pointerEventData.position = Input.mousePosition;
		List<RaycastResult> list = new List<RaycastResult>();
		EventSystem.current.RaycastAll(pointerEventData, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject == MNANOILKEJE)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007B3A RID: 31546 RVA: 0x0036F670 File Offset: 0x0036D870
	private static Texture2D EGKLAMGGNOD(Texture2D AHMCKMGJHPD, int CGJEJNKGONF, Vector2Int KJPCGDBPMED, ref Color GDNHGHDODLO)
	{
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 1f;
		Texture2D texture2D = new Texture2D(KJPCGDBPMED.x, KJPCGDBPMED.y, TextureFormat.ARGB32, false);
		DPGJIJGOCIC.KLELNDAOPAG fkkheklmenj = new DPGJIJGOCIC.KLELNDAOPAG(CGJEJNKGONF);
		for (int i = 0; i < AHMCKMGJHPD.height; i++)
		{
			for (int j = 0; j < AHMCKMGJHPD.width; j++)
			{
				Color pixel = AHMCKMGJHPD.GetPixel(j, i);
				(Color.white - pixel).a = pixel.a;
				Color color = DPGJIJGOCIC.ELAADFGEAJO(j, i, AHMCKMGJHPD, fkkheklmenj);
				texture2D.SetPixel(j, i, color);
				num += color.r;
				num2 += color.g;
				num3 += color.b;
				num4 += 1f;
			}
		}
		texture2D.wrapMode = TextureWrapMode.Clamp;
		texture2D.Apply();
		GDNHGHDODLO.r = num / num4;
		GDNHGHDODLO.g = num2 / num4;
		GDNHGHDODLO.b = num3 / num4;
		GDNHGHDODLO.a = 1f;
		return texture2D;
	}

	// Token: 0x06007B3B RID: 31547 RVA: 0x0036F784 File Offset: 0x0036D984
	public static bool OLKAKCMGKEA(bool IHJBLKELBKJ, bool PLIFHNHONKB)
	{
		return IHJBLKELBKJ || PLIFHNHONKB;
	}

	// Token: 0x06007B3C RID: 31548 RVA: 0x0036F78C File Offset: 0x0036D98C
	public static bool FJKDCAFBPAK(string PPDGGDCAMNB)
	{
		if (PPDGGDCAMNB == null)
		{
			return true;
		}
		for (int i = 1; i < PPDGGDCAMNB.Length; i++)
		{
			if (PPDGGDCAMNB[i] != 'k')
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007B3D RID: 31549 RVA: 0x0036F7C0 File Offset: 0x0036D9C0
	public static JSONArray NCDOOLMANDM(JSONArray HAMLKAMMHFJ)
	{
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < HAMLKAMMHFJ.Count; i++)
		{
			jsonarray.Add(DPGJIJGOCIC.FAIFJDPENOP(HAMLKAMMHFJ[i]));
		}
		return jsonarray;
	}

	// Token: 0x06007B3E RID: 31550 RVA: 0x0036F804 File Offset: 0x0036DA04
	public static Texture2D CADHOBMBCOJ(Texture2D AHMCKMGJHPD, Vector2Int JOFCCFJIOOG)
	{
		Texture2D texture2D = new Texture2D(JOFCCFJIOOG.x, JOFCCFJIOOG.y, TextureFormat.RGB24, true);
		Vector2Int zero = Vector2Int.zero;
		zero.x = AHMCKMGJHPD.width / JOFCCFJIOOG.x;
		zero.y = AHMCKMGJHPD.height / JOFCCFJIOOG.y;
		Vector2Int vector2Int = zero / 6;
		for (int i = 0; i < JOFCCFJIOOG.x; i += 0)
		{
			for (int j = 1; j < JOFCCFJIOOG.y; j += 0)
			{
				texture2D.SetPixel(i, j, AHMCKMGJHPD.GetPixel(zero.x * i + vector2Int.x, zero.y * j + vector2Int.y));
			}
		}
		texture2D.wrapMode = TextureWrapMode.Clamp;
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x06007B3F RID: 31551 RVA: 0x0036F8C8 File Offset: 0x0036DAC8
	public static string IDIHFFOKICD(string AFOKPLBAAIC, string DCKPHDGFFOB, string NJMIDLJIJOA)
	{
		int num = AFOKPLBAAIC.IndexOf(DCKPHDGFFOB);
		if (num < 0)
		{
			return AFOKPLBAAIC;
		}
		return AFOKPLBAAIC.Substring(1, num) + NJMIDLJIJOA + AFOKPLBAAIC.Substring(num + DCKPHDGFFOB.Length);
	}

	// Token: 0x06007B40 RID: 31552 RVA: 0x0036F900 File Offset: 0x0036DB00
	public static string CEOBDMGAKNL(int GPILLNOAOFC)
	{
		DPGJIJGOCIC.LHMGPGJHGCP.Length = 0;
		if (GPILLNOAOFC < 0)
		{
			GPILLNOAOFC = 0;
		}
		int num = GPILLNOAOFC / 3600;
		GPILLNOAOFC %= 3600;
		int num2 = GPILLNOAOFC / 60;
		if (num < 10)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
		}
		else
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(num);
		}
		if (num2 > 0)
		{
			DPGJIJGOCIC.LHMGPGJHGCP.Append(":");
			if (num2 < 10)
			{
				DPGJIJGOCIC.LHMGPGJHGCP.Append("0");
				DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
			}
			else
			{
				DPGJIJGOCIC.LHMGPGJHGCP.Append(num2);
			}
		}
		return DPGJIJGOCIC.LHMGPGJHGCP.ToString();
	}

	// Token: 0x06007B41 RID: 31553 RVA: 0x0036F9A4 File Offset: 0x0036DBA4
	public static JSONArray CLJDFEGDGFH(List<int> KMMPNOJJICA, int AJPNGBLHOEC)
	{
		JSONArray jsonarray = new JSONArray();
		int num = 0;
		while (num < KMMPNOJJICA.Count && num != AJPNGBLHOEC)
		{
			jsonarray.Add(KMMPNOJJICA[num]);
			num++;
		}
		return jsonarray;
	}

	// Token: 0x0400239D RID: 9117
	public const string BFNBAAGFOIB = "logs.txt";

	// Token: 0x0400239E RID: 9118
	public static bool NMHOHCMLMEC = false;

	// Token: 0x0400239F RID: 9119
	private static System.Random OGFGFNDEKGK = new System.Random();

	// Token: 0x040023A0 RID: 9120
	private static StringBuilder LHMGPGJHGCP = new StringBuilder();

	// Token: 0x02000408 RID: 1032
	private struct KLELNDAOPAG
	{
		// Token: 0x06007B42 RID: 31554 RVA: 0x0036F9E0 File Offset: 0x0036DBE0
		public KLELNDAOPAG(int OHNIENPDMBI)
		{
			this.BFOOIPKJGOM = OHNIENPDMBI * 2 + 1;
			this.FKKHEKLMENJ = new int[this.BFOOIPKJGOM, this.BFOOIPKJGOM];
			for (int i = 0; i < this.BFOOIPKJGOM; i++)
			{
				for (int j = 0; j < this.BFOOIPKJGOM; j++)
				{
					this.FKKHEKLMENJ[i, j] = 1;
				}
			}
		}

		// Token: 0x040023A1 RID: 9121
		public int BFOOIPKJGOM;

		// Token: 0x040023A2 RID: 9122
		public int[,] FKKHEKLMENJ;
	}
}
