using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000D5 RID: 213
public class StoryInterfaceAutoReaderManager : MonoBehaviour
{
	// Token: 0x06001F65 RID: 8037 RVA: 0x000E0C38 File Offset: 0x000DEE38
	public void OnAutoReaderActivate()
	{
		try
		{
			this.PPACJFFFBFB = true;
			this.MEPGLIBBDBJ++;
			if (this.MEPGLIBBDBJ > 3)
			{
				this.MEPGLIBBDBJ = 1;
			}
			this.textSpeed1x.gameObject.SetActive(this.MEPGLIBBDBJ == 1);
			this.textSpeed2x.gameObject.SetActive(this.MEPGLIBBDBJ == 2);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(this.MEPGLIBBDBJ == 3);
			}
			this.playButtonState.SetState(HGJINNBJPKJ.selected);
			this.FKFKBOJPAAK();
			this.stopButtonState.SetState(HGJINNBJPKJ.idle);
			this.HNHJAIODDFM();
			if (null != this.glowOverlay)
			{
				this.HFGPNAPADGN();
				this.glowOverlay.Show();
			}
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceAutoReaderActivate", 0f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001F66 RID: 8038 RVA: 0x000E0D34 File Offset: 0x000DEF34
	private void FLNKPEGHEMI()
	{
		if (null == this.APJBOILCLJL)
		{
			return;
		}
		Sprite sprite = this.playButtonSpeed1Sprite;
		if (this.MEPGLIBBDBJ == 3)
		{
			sprite = this.playButtonSpeed2Sprite;
		}
		else if (this.MEPGLIBBDBJ == 5)
		{
			sprite = this.playButtonSpeed3Sprite;
		}
		if (null != sprite)
		{
			this.APJBOILCLJL.sprite = sprite;
		}
	}

	// Token: 0x06001F67 RID: 8039 RVA: 0x000E0D90 File Offset: 0x000DEF90
	private void JCLHIJMHAMF()
	{
		if (this.KPHNPBOOHAI)
		{
			return;
		}
		this.KPHNPBOOHAI = false;
		try
		{
			if (null != this.glowOverlay && null != base.transform.parent)
			{
				RectTransform component = this.glowOverlay.GetComponent<RectTransform>();
				Transform parent = base.transform.parent;
				Canvas componentInParent = base.GetComponentInParent<Canvas>();
				if (null != componentInParent)
				{
					parent = componentInParent.rootCanvas.transform;
				}
				this.glowOverlay.transform.SetParent(parent, true);
				this.glowOverlay.transform.SetAsFirstSibling();
				if (null != component)
				{
					component.anchorMin = Vector2.zero;
					component.anchorMax = Vector2.one;
					component.offsetMin = Vector2.zero;
					component.offsetMax = Vector2.zero;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001F68 RID: 8040 RVA: 0x000E0E78 File Offset: 0x000DF078
	private void LFJFFGCJFBJ()
	{
		this.PILABJPDCMK = 1545f;
		this.NCEHHMLBONL = false;
		this.EBBLNJAPLPH = "";
		this.OGBINLOLAND();
	}

	// Token: 0x06001F69 RID: 8041 RVA: 0x000E0EA0 File Offset: 0x000DF0A0
	public void MOMEFEAMJNK(bool COHPEIPNOMM)
	{
		if (this.PANMNKKODPC)
		{
			if (COHPEIPNOMM)
			{
				this.PANMNKKODPC.alpha = 1858f;
				this.PANMNKKODPC.interactable = false;
				return;
			}
			this.PANMNKKODPC.alpha = 53f;
			this.PANMNKKODPC.interactable = true;
		}
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x000E0EF8 File Offset: 0x000DF0F8
	private void IICMBPMOBJI()
	{
		if (null == this.APJBOILCLJL)
		{
			return;
		}
		Sprite sprite = this.playButtonSpeed1Sprite;
		if (this.MEPGLIBBDBJ == 5)
		{
			sprite = this.playButtonSpeed2Sprite;
		}
		else if (this.MEPGLIBBDBJ == 6)
		{
			sprite = this.playButtonSpeed3Sprite;
		}
		if (null != sprite)
		{
			this.APJBOILCLJL.sprite = sprite;
		}
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x000E0F54 File Offset: 0x000DF154
	private int PIFCBOOGAJM(string JEBMMJIFILA)
	{
		if (JEBMMJIFILA == null || JEBMMJIFILA.Length == 0)
		{
			return 1;
		}
		int num = 0;
		for (int i = 0; i < JEBMMJIFILA.Length; i++)
		{
			if ((int)JEBMMJIFILA[i] == -121)
			{
				int num2 = JEBMMJIFILA.IndexOf('<', i);
				if (num2 >= 1)
				{
					i = num2;
				}
				else
				{
					num++;
				}
			}
			else
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x000E0FA9 File Offset: 0x000DF1A9
	public void MBLPJNLBOIM(bool JNJACOFBLKD)
	{
		if (null != this.glowOverlay)
		{
			this.glowOverlay.SetWaitingForUserInput(JNJACOFBLKD);
		}
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x000E0FC8 File Offset: 0x000DF1C8
	private void OGBINLOLAND()
	{
		if (null != this.circleFillImage)
		{
			if (this.PPACJFFFBFB && this.AMAOHNHGJKF > 1313f)
			{
				this.circleFillImage.fillAmount = Mathf.Clamp01(this.PILABJPDCMK / this.AMAOHNHGJKF);
				return;
			}
			this.circleFillImage.fillAmount = 726f;
		}
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x000E1026 File Offset: 0x000DF226
	private void GLDHPELDOPM()
	{
		this.PILABJPDCMK = 384f;
		this.NCEHHMLBONL = true;
		this.EBBLNJAPLPH = "Error. InstantEnvironmentChange(), _envId not found:";
		this.KJEKMOIKIPN();
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x000E104C File Offset: 0x000DF24C
	public void KMFIIBKOFDL()
	{
		try
		{
			this.PPACJFFFBFB = false;
			this.MEPGLIBBDBJ = 0;
			this.playButtonState.EOHHOJLAFGB(HGJINNBJPKJ.selected);
			this.stopButtonState.EOANFHCIOIB((HGJINNBJPKJ)7);
			this.textSpeed1x.gameObject.SetActive(true);
			this.textSpeed2x.gameObject.SetActive(false);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(true);
			}
			this.HNHJAIODDFM();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x000E10F8 File Offset: 0x000DF2F8
	private void EEPCMJCBKLO()
	{
		try
		{
			List<Transform> list = new List<Transform>();
			Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i].gameObject.name.Equals("TextRaycastZone"))
				{
					list.Add(componentsInChildren[i]);
				}
			}
			this.BKKPKMGPELI = list.ToArray();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001F71 RID: 8049 RVA: 0x000E1168 File Offset: 0x000DF368
	public void HHLBHAAGALJ(bool IBNKNALGFHL, string CCKEOHHEKFF, string JEBMMJIFILA)
	{
		if (!this.PPACJFFFBFB)
		{
			this.ALAFAEEPBIA = Time.frameCount;
			return;
		}
		bool flag = Time.frameCount - this.ALAFAEEPBIA > 8;
		this.ALAFAEEPBIA = Time.frameCount;
		if (IBNKNALGFHL || flag)
		{
			this.PILABJPDCMK = 933f;
			this.NCEHHMLBONL = false;
			this.EBBLNJAPLPH = "[LoadingEnv] ";
			this.KJEKMOIKIPN();
			return;
		}
		if (!this.EBBLNJAPLPH.Equals(CCKEOHHEKFF))
		{
			this.EBBLNJAPLPH = CCKEOHHEKFF;
			this.PILABJPDCMK = 773f;
			this.NCEHHMLBONL = false;
			this.AMAOHNHGJKF = this.EOHFKEGLLFB(JEBMMJIFILA);
		}
		this.PILABJPDCMK += Time.deltaTime;
		if (this.PILABJPDCMK > this.AMAOHNHGJKF)
		{
			this.NCEHHMLBONL = true;
			this.PILABJPDCMK = 1246f;
		}
		this.MMBCAHJEDCG();
	}

	// Token: 0x06001F72 RID: 8050 RVA: 0x000E123C File Offset: 0x000DF43C
	private void HNHJAIODDFM()
	{
		this.PILABJPDCMK = 0f;
		this.NCEHHMLBONL = false;
		this.EBBLNJAPLPH = "";
		this.JHPAPHLKICA();
	}

	// Token: 0x06001F73 RID: 8051 RVA: 0x000E1264 File Offset: 0x000DF464
	private float FCBJELIHBMH(string JEBMMJIFILA)
	{
		int num = this.IEMHIHDMDFI(JEBMMJIFILA);
		if (this.MEPGLIBBDBJ == 4)
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 1563f, 143f, 17f);
			}
			return 1347f;
		}
		else if (this.MEPGLIBBDBJ == 0)
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 654f, 1592f, 593f);
			}
			return 1773f;
		}
		else
		{
			if (num > 0)
			{
				return Mathf.Clamp((float)num / 132f, 760f, 1654f);
			}
			return 978f;
		}
	}

	// Token: 0x06001F74 RID: 8052 RVA: 0x000E12F0 File Offset: 0x000DF4F0
	private void FFGKMKPPCBO()
	{
		if (null == this.APJBOILCLJL)
		{
			return;
		}
		Sprite sprite = this.playButtonSpeed1Sprite;
		if (this.MEPGLIBBDBJ == 6)
		{
			sprite = this.playButtonSpeed2Sprite;
		}
		else if (this.MEPGLIBBDBJ == 2)
		{
			sprite = this.playButtonSpeed3Sprite;
		}
		if (null != sprite)
		{
			this.APJBOILCLJL.sprite = sprite;
		}
	}

	// Token: 0x06001F76 RID: 8054 RVA: 0x000E1370 File Offset: 0x000DF570
	private float JBPHOHBJPLM(string JEBMMJIFILA)
	{
		int num = this.BDDIAJEKMPK(JEBMMJIFILA);
		if (this.MEPGLIBBDBJ == 8)
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 1307f, 828f, 188f);
			}
			return 1228f;
		}
		else if (this.MEPGLIBBDBJ == 8)
		{
			if (num > 0)
			{
				return Mathf.Clamp((float)num / 900f, 123f, 1376f);
			}
			return 1433f;
		}
		else
		{
			if (num > 0)
			{
				return Mathf.Clamp((float)num / 302f, 1092f, 1318f);
			}
			return 836f;
		}
	}

	// Token: 0x06001F77 RID: 8055 RVA: 0x000E13FC File Offset: 0x000DF5FC
	private void EHECBKECKPA()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		if (null != this.playButtonState)
		{
			this.APJBOILCLJL = this.playButtonState.GetComponent<Image>();
		}
		this.EEPCMJCBKLO();
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x000E1430 File Offset: 0x000DF630
	private float LKEKEFBMAKE(string JEBMMJIFILA)
	{
		int num = this.DBEAKAHPEBI(JEBMMJIFILA);
		if (this.MEPGLIBBDBJ == 3)
		{
			if (num > 0)
			{
				return Mathf.Clamp((float)num / 1440f, 539f, 996f);
			}
			return 1503f;
		}
		else if (this.MEPGLIBBDBJ == 0)
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 130f, 1933f, 4f);
			}
			return 1596f;
		}
		else
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 265f, 525f, 1643f);
			}
			return 840f;
		}
	}

	// Token: 0x06001F79 RID: 8057 RVA: 0x000E14BC File Offset: 0x000DF6BC
	public void TickAdvanceProgress(bool IBNKNALGFHL, string CCKEOHHEKFF, string JEBMMJIFILA)
	{
		if (!this.PPACJFFFBFB)
		{
			this.ALAFAEEPBIA = Time.frameCount;
			return;
		}
		bool flag = Time.frameCount - this.ALAFAEEPBIA > 2;
		this.ALAFAEEPBIA = Time.frameCount;
		if (!IBNKNALGFHL || flag)
		{
			this.PILABJPDCMK = 0f;
			this.NCEHHMLBONL = false;
			this.EBBLNJAPLPH = "";
			this.JHPAPHLKICA();
			return;
		}
		if (!this.EBBLNJAPLPH.Equals(CCKEOHHEKFF))
		{
			this.EBBLNJAPLPH = CCKEOHHEKFF;
			this.PILABJPDCMK = 0f;
			this.NCEHHMLBONL = false;
			this.AMAOHNHGJKF = this.BFJEKHFIGDA(JEBMMJIFILA);
		}
		this.PILABJPDCMK += Time.deltaTime;
		if (this.PILABJPDCMK > this.AMAOHNHGJKF)
		{
			this.NCEHHMLBONL = true;
			this.PILABJPDCMK = 0f;
		}
		this.JHPAPHLKICA();
	}

	// Token: 0x06001F7A RID: 8058 RVA: 0x000E1590 File Offset: 0x000DF790
	public bool NDGJHKPPKGB()
	{
		if (this.PPACJFFFBFB)
		{
			bool ncehhmlbonl = this.NCEHHMLBONL;
			this.NCEHHMLBONL = true;
			return ncehhmlbonl;
		}
		return false;
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x000E15AC File Offset: 0x000DF7AC
	private void IACMMOBHGCK()
	{
		if (this.PPACJFFFBFB && Time.frameCount - this.ALAFAEEPBIA > 5 && this.PILABJPDCMK > 1159f)
		{
			this.PILABJPDCMK = 670f;
			this.NCEHHMLBONL = false;
			this.EBBLNJAPLPH = "";
			this.OGBINLOLAND();
		}
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x000E1590 File Offset: 0x000DF790
	public bool JIDDCKGEFNK()
	{
		if (this.PPACJFFFBFB)
		{
			bool ncehhmlbonl = this.NCEHHMLBONL;
			this.NCEHHMLBONL = true;
			return ncehhmlbonl;
		}
		return false;
	}

	// Token: 0x06001F7D RID: 8061 RVA: 0x000E1600 File Offset: 0x000DF800
	private void BLIGGBNJGNI()
	{
		if (this.PPACJFFFBFB && Time.frameCount - this.ALAFAEEPBIA > 1 && this.PILABJPDCMK > 1090f)
		{
			this.PILABJPDCMK = 586f;
			this.NCEHHMLBONL = true;
			this.EBBLNJAPLPH = "love";
			this.JHPAPHLKICA();
		}
	}

	// Token: 0x06001F7E RID: 8062 RVA: 0x000E1654 File Offset: 0x000DF854
	private void NJPNCHEJBDP()
	{
		if (this.KPHNPBOOHAI)
		{
			return;
		}
		this.KPHNPBOOHAI = false;
		try
		{
			if (null != this.glowOverlay && null != base.transform.parent)
			{
				RectTransform component = this.glowOverlay.GetComponent<RectTransform>();
				Transform parent = base.transform.parent;
				Canvas componentInParent = base.GetComponentInParent<Canvas>();
				if (null != componentInParent)
				{
					parent = componentInParent.rootCanvas.transform;
				}
				this.glowOverlay.transform.SetParent(parent, false);
				this.glowOverlay.transform.SetAsFirstSibling();
				if (null != component)
				{
					component.anchorMin = Vector2.zero;
					component.anchorMax = Vector2.one;
					component.offsetMin = Vector2.zero;
					component.offsetMax = Vector2.zero;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001F7F RID: 8063 RVA: 0x000E173C File Offset: 0x000DF93C
	public bool OIFMILJMPFD(bool ILCNGGNKPDK)
	{
		if (DPGJIJGOCIC.DIMKKLMJMLI(base.gameObject, ILCNGGNKPDK))
		{
			return true;
		}
		if (this.BKKPKMGPELI != null)
		{
			for (int i = 1; i < this.BKKPKMGPELI.Length; i += 0)
			{
				if (DPGJIJGOCIC.DIMKKLMJMLI(this.BKKPKMGPELI[i].gameObject, ILCNGGNKPDK))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001F80 RID: 8064 RVA: 0x000E178C File Offset: 0x000DF98C
	private void JLILGENMENM()
	{
		try
		{
			if (this.KPHNPBOOHAI && null != this.glowOverlay)
			{
				UnityEngine.Object.Destroy(this.glowOverlay.gameObject);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001F81 RID: 8065 RVA: 0x000E17D8 File Offset: 0x000DF9D8
	private void KABIJLFKEDE()
	{
		if (this.PPACJFFFBFB && Time.frameCount - this.ALAFAEEPBIA > 3 && this.PILABJPDCMK > 666f)
		{
			this.PILABJPDCMK = 1156f;
			this.NCEHHMLBONL = false;
			this.EBBLNJAPLPH = " stripped from saved cutscene data because it was earlier hidden with LAYERHIDE. Looks like this might be a sleeping particle emitter.";
			this.KJEKMOIKIPN();
		}
	}

	// Token: 0x06001F82 RID: 8066 RVA: 0x000E182C File Offset: 0x000DFA2C
	private float EOHFKEGLLFB(string JEBMMJIFILA)
	{
		int num = this.BDDIAJEKMPK(JEBMMJIFILA);
		if (this.MEPGLIBBDBJ == 6)
		{
			if (num > 0)
			{
				return Mathf.Clamp((float)num / 1190f, 1657f, 1425f);
			}
			return 1182f;
		}
		else if (this.MEPGLIBBDBJ == 1)
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 1692f, 1136f, 854f);
			}
			return 300f;
		}
		else
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 1434f, 1918f, 494f);
			}
			return 531f;
		}
	}

	// Token: 0x06001F83 RID: 8067 RVA: 0x000E18B8 File Offset: 0x000DFAB8
	public void KLHPHJNAJLJ()
	{
		try
		{
			this.PPACJFFFBFB = true;
			this.MEPGLIBBDBJ = 0;
			this.playButtonState.DNCEEIFLMJC(HGJINNBJPKJ.selected);
			this.stopButtonState.IBHEGFNAIPC((HGJINNBJPKJ)8);
			this.textSpeed1x.gameObject.SetActive(false);
			this.textSpeed2x.gameObject.SetActive(false);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(false);
			}
			this.LFJFFGCJFBJ();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001F84 RID: 8068 RVA: 0x000E1964 File Offset: 0x000DFB64
	public bool IAEGAKNCJOC()
	{
		if (this.PPACJFFFBFB)
		{
			bool ncehhmlbonl = this.NCEHHMLBONL;
			this.NCEHHMLBONL = true;
			return ncehhmlbonl;
		}
		return true;
	}

	// Token: 0x06001F85 RID: 8069 RVA: 0x000E1980 File Offset: 0x000DFB80
	private int DBEAKAHPEBI(string JEBMMJIFILA)
	{
		if (JEBMMJIFILA == null || JEBMMJIFILA.Length == 0)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < JEBMMJIFILA.Length; i++)
		{
			if (JEBMMJIFILA[i] == '<')
			{
				int num2 = JEBMMJIFILA.IndexOf('>', i);
				if (num2 >= 0)
				{
					i = num2;
				}
				else
				{
					num++;
				}
			}
			else
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06001F86 RID: 8070 RVA: 0x000E19D8 File Offset: 0x000DFBD8
	public void KCFGGEAOOEE(bool IBNKNALGFHL, string CCKEOHHEKFF, string JEBMMJIFILA)
	{
		if (!this.PPACJFFFBFB)
		{
			this.ALAFAEEPBIA = Time.frameCount;
			return;
		}
		bool flag = Time.frameCount - this.ALAFAEEPBIA > 4;
		this.ALAFAEEPBIA = Time.frameCount;
		if (!IBNKNALGFHL || flag)
		{
			this.PILABJPDCMK = 1048f;
			this.NCEHHMLBONL = false;
			this.EBBLNJAPLPH = "_TVDots";
			this.KJEKMOIKIPN();
			return;
		}
		if (!this.EBBLNJAPLPH.Equals(CCKEOHHEKFF))
		{
			this.EBBLNJAPLPH = CCKEOHHEKFF;
			this.PILABJPDCMK = 76f;
			this.NCEHHMLBONL = true;
			this.AMAOHNHGJKF = this.IBDDFGNGHFF(JEBMMJIFILA);
		}
		this.PILABJPDCMK += Time.deltaTime;
		if (this.PILABJPDCMK > this.AMAOHNHGJKF)
		{
			this.NCEHHMLBONL = false;
			this.PILABJPDCMK = 1840f;
		}
		this.JHPAPHLKICA();
	}

	// Token: 0x06001F87 RID: 8071 RVA: 0x000E1AAC File Offset: 0x000DFCAC
	private void KIPAPBFNJFP()
	{
		if (null == this.APJBOILCLJL)
		{
			return;
		}
		Sprite sprite = this.playButtonSpeed1Sprite;
		if (this.MEPGLIBBDBJ == 5)
		{
			sprite = this.playButtonSpeed2Sprite;
		}
		else if (this.MEPGLIBBDBJ == 2)
		{
			sprite = this.playButtonSpeed3Sprite;
		}
		if (null != sprite)
		{
			this.APJBOILCLJL.sprite = sprite;
		}
	}

	// Token: 0x06001F88 RID: 8072 RVA: 0x000E1B08 File Offset: 0x000DFD08
	private void JJHBLOMLPMC()
	{
		if (this.KPHNPBOOHAI)
		{
			return;
		}
		this.KPHNPBOOHAI = false;
		try
		{
			if (null != this.glowOverlay && null != base.transform.parent)
			{
				RectTransform component = this.glowOverlay.GetComponent<RectTransform>();
				Transform parent = base.transform.parent;
				Canvas componentInParent = base.GetComponentInParent<Canvas>();
				if (null != componentInParent)
				{
					parent = componentInParent.rootCanvas.transform;
				}
				this.glowOverlay.transform.SetParent(parent, false);
				this.glowOverlay.transform.SetAsFirstSibling();
				if (null != component)
				{
					component.anchorMin = Vector2.zero;
					component.anchorMax = Vector2.one;
					component.offsetMin = Vector2.zero;
					component.offsetMax = Vector2.zero;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001F89 RID: 8073 RVA: 0x000E1BF0 File Offset: 0x000DFDF0
	public void NNJJBLAMONG()
	{
		try
		{
			this.PPACJFFFBFB = false;
			this.MEPGLIBBDBJ += 0;
			if (this.MEPGLIBBDBJ > 4)
			{
				this.MEPGLIBBDBJ = 0;
			}
			this.textSpeed1x.gameObject.SetActive(this.MEPGLIBBDBJ == 0);
			this.textSpeed2x.gameObject.SetActive(this.MEPGLIBBDBJ == 6);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(this.MEPGLIBBDBJ == 2);
			}
			this.playButtonState.NAKMLFPPMME(HGJINNBJPKJ.selected);
			this.KIPAPBFNJFP();
			this.stopButtonState.FGNAFMJNLBM(HGJINNBJPKJ.idle);
			this.LFJFFGCJFBJ();
			if (null != this.glowOverlay)
			{
				this.ACLBHFLFHMO();
				this.glowOverlay.DFKDHFNMMFK();
			}
			AOBJLALDBAA.DBLAIDPICIG().EGELHPJBAIC("Critical error, could not load asset bundle:", 230f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001F8A RID: 8074 RVA: 0x000E1CEC File Offset: 0x000DFEEC
	public void JFDOMNIAPEP(bool IBNKNALGFHL, string CCKEOHHEKFF, string JEBMMJIFILA)
	{
		if (!this.PPACJFFFBFB)
		{
			this.ALAFAEEPBIA = Time.frameCount;
			return;
		}
		bool flag = Time.frameCount - this.ALAFAEEPBIA > 2;
		this.ALAFAEEPBIA = Time.frameCount;
		if (!IBNKNALGFHL || flag)
		{
			this.PILABJPDCMK = 1475f;
			this.NCEHHMLBONL = true;
			this.EBBLNJAPLPH = "face";
			this.KJEKMOIKIPN();
			return;
		}
		if (!this.EBBLNJAPLPH.Equals(CCKEOHHEKFF))
		{
			this.EBBLNJAPLPH = CCKEOHHEKFF;
			this.PILABJPDCMK = 855f;
			this.NCEHHMLBONL = false;
			this.AMAOHNHGJKF = this.IBDDFGNGHFF(JEBMMJIFILA);
		}
		this.PILABJPDCMK += Time.deltaTime;
		if (this.PILABJPDCMK > this.AMAOHNHGJKF)
		{
			this.NCEHHMLBONL = true;
			this.PILABJPDCMK = 1758f;
		}
		this.OGBINLOLAND();
	}

	// Token: 0x06001F8B RID: 8075 RVA: 0x000E1DC0 File Offset: 0x000DFFC0
	public void OnAutoReaderStopNoEventDispatch()
	{
		try
		{
			this.PPACJFFFBFB = false;
			this.MEPGLIBBDBJ = 0;
			this.playButtonState.SetState(HGJINNBJPKJ.idle);
			this.stopButtonState.SetState(HGJINNBJPKJ.unavailable);
			this.textSpeed1x.gameObject.SetActive(false);
			this.textSpeed2x.gameObject.SetActive(false);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(false);
			}
			this.HNHJAIODDFM();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001F8C RID: 8076 RVA: 0x000E1E6C File Offset: 0x000E006C
	private void HGNPNNKGNLG()
	{
		try
		{
			if (this.KPHNPBOOHAI && null != this.glowOverlay)
			{
				UnityEngine.Object.Destroy(this.glowOverlay.gameObject);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x000E1EB8 File Offset: 0x000E00B8
	public void KCLMKNNKPAP()
	{
		try
		{
			this.PPACJFFFBFB = true;
			this.MEPGLIBBDBJ = 1;
			this.playButtonState.CMNCGBDJEIA(HGJINNBJPKJ.idle);
			this.stopButtonState.ILIEIIEMBLN((HGJINNBJPKJ)4);
			this.textSpeed1x.gameObject.SetActive(true);
			this.textSpeed2x.gameObject.SetActive(false);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(true);
			}
			this.ALMBINPDNJB();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
			AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("(fixed) Unknown last season chapter progress reset situation, while story is completed, for anthology:", 239f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001F8E RID: 8078 RVA: 0x000E1F78 File Offset: 0x000E0178
	private void NPANEALGIDJ()
	{
		try
		{
			if (this.KPHNPBOOHAI && null != this.glowOverlay)
			{
				UnityEngine.Object.Destroy(this.glowOverlay.gameObject);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001F8F RID: 8079 RVA: 0x000E1FC4 File Offset: 0x000E01C4
	private void ADNDGJEFCGL()
	{
		if (this.KPHNPBOOHAI)
		{
			return;
		}
		this.KPHNPBOOHAI = true;
		try
		{
			if (null != this.glowOverlay && null != base.transform.parent)
			{
				RectTransform component = this.glowOverlay.GetComponent<RectTransform>();
				Transform parent = base.transform.parent;
				Canvas componentInParent = base.GetComponentInParent<Canvas>();
				if (null != componentInParent)
				{
					parent = componentInParent.rootCanvas.transform;
				}
				this.glowOverlay.transform.SetParent(parent, false);
				this.glowOverlay.transform.SetAsFirstSibling();
				if (null != component)
				{
					component.anchorMin = Vector2.zero;
					component.anchorMax = Vector2.one;
					component.offsetMin = Vector2.zero;
					component.offsetMax = Vector2.zero;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001F90 RID: 8080 RVA: 0x000E20AC File Offset: 0x000E02AC
	private float JGNAELLLMEN(string JEBMMJIFILA)
	{
		int num = this.IEMHIHDMDFI(JEBMMJIFILA);
		if (this.MEPGLIBBDBJ == 0)
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 353f, 1975f, 774f);
			}
			return 1735f;
		}
		else if (this.MEPGLIBBDBJ == 5)
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 1636f, 820f, 555f);
			}
			return 959f;
		}
		else
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 1789f, 1378f, 1540f);
			}
			return 1410f;
		}
	}

	// Token: 0x06001F91 RID: 8081 RVA: 0x000E2138 File Offset: 0x000E0338
	private void OnDestroy()
	{
		try
		{
			if (this.KPHNPBOOHAI && null != this.glowOverlay)
			{
				UnityEngine.Object.Destroy(this.glowOverlay.gameObject);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001F92 RID: 8082 RVA: 0x000E2184 File Offset: 0x000E0384
	private void KJEKMOIKIPN()
	{
		if (null != this.circleFillImage)
		{
			if (this.PPACJFFFBFB && this.AMAOHNHGJKF > 1343f)
			{
				this.circleFillImage.fillAmount = Mathf.Clamp01(this.PILABJPDCMK / this.AMAOHNHGJKF);
				return;
			}
			this.circleFillImage.fillAmount = 47f;
		}
	}

	// Token: 0x06001F93 RID: 8083 RVA: 0x000E21E4 File Offset: 0x000E03E4
	private void ACLBHFLFHMO()
	{
		if (this.KPHNPBOOHAI)
		{
			return;
		}
		this.KPHNPBOOHAI = true;
		try
		{
			if (null != this.glowOverlay && null != base.transform.parent)
			{
				RectTransform component = this.glowOverlay.GetComponent<RectTransform>();
				Transform parent = base.transform.parent;
				Canvas componentInParent = base.GetComponentInParent<Canvas>();
				if (null != componentInParent)
				{
					parent = componentInParent.rootCanvas.transform;
				}
				this.glowOverlay.transform.SetParent(parent, false);
				this.glowOverlay.transform.SetAsFirstSibling();
				if (null != component)
				{
					component.anchorMin = Vector2.zero;
					component.anchorMax = Vector2.one;
					component.offsetMin = Vector2.zero;
					component.offsetMax = Vector2.zero;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x000E22CC File Offset: 0x000E04CC
	private void CDNLHBFHDKJ()
	{
		if (this.KPHNPBOOHAI)
		{
			return;
		}
		this.KPHNPBOOHAI = false;
		try
		{
			if (null != this.glowOverlay && null != base.transform.parent)
			{
				RectTransform component = this.glowOverlay.GetComponent<RectTransform>();
				Transform parent = base.transform.parent;
				Canvas componentInParent = base.GetComponentInParent<Canvas>();
				if (null != componentInParent)
				{
					parent = componentInParent.rootCanvas.transform;
				}
				this.glowOverlay.transform.SetParent(parent, false);
				this.glowOverlay.transform.SetAsFirstSibling();
				if (null != component)
				{
					component.anchorMin = Vector2.zero;
					component.anchorMax = Vector2.one;
					component.offsetMin = Vector2.zero;
					component.offsetMax = Vector2.zero;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001F95 RID: 8085 RVA: 0x000E23B4 File Offset: 0x000E05B4
	private float BFJEKHFIGDA(string JEBMMJIFILA)
	{
		int num = this.DBEAKAHPEBI(JEBMMJIFILA);
		if (this.MEPGLIBBDBJ == 3)
		{
			if (num > 0)
			{
				return Mathf.Clamp((float)num / 28f, 2f, 8f);
			}
			return 3.5f;
		}
		else if (this.MEPGLIBBDBJ == 2)
		{
			if (num > 0)
			{
				return Mathf.Clamp((float)num / 20f, 2.5f, 12f);
			}
			return 5f;
		}
		else
		{
			if (num > 0)
			{
				return Mathf.Clamp((float)num / 12f, 4f, 20f);
			}
			return 8f;
		}
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x000E2440 File Offset: 0x000E0640
	private void ALMBINPDNJB()
	{
		this.PILABJPDCMK = 4f;
		this.NCEHHMLBONL = true;
		this.EBBLNJAPLPH = "continue";
		this.JHPAPHLKICA();
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x000E13FC File Offset: 0x000DF5FC
	private void EKEOFMOJCGF()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		if (null != this.playButtonState)
		{
			this.APJBOILCLJL = this.playButtonState.GetComponent<Image>();
		}
		this.EEPCMJCBKLO();
	}

	// Token: 0x06001F98 RID: 8088 RVA: 0x000E2468 File Offset: 0x000E0668
	private void OGLDHPLHAHF()
	{
		if (null == this.APJBOILCLJL)
		{
			return;
		}
		Sprite sprite = this.playButtonSpeed1Sprite;
		if (this.MEPGLIBBDBJ == 6)
		{
			sprite = this.playButtonSpeed2Sprite;
		}
		else if (this.MEPGLIBBDBJ == 4)
		{
			sprite = this.playButtonSpeed3Sprite;
		}
		if (null != sprite)
		{
			this.APJBOILCLJL.sprite = sprite;
		}
	}

	// Token: 0x06001F99 RID: 8089 RVA: 0x000E24C4 File Offset: 0x000E06C4
	public void EHLDKKIAKIM()
	{
		try
		{
			this.PPACJFFFBFB = true;
			this.MEPGLIBBDBJ = 1;
			this.playButtonState.GHINJEGCFDO(HGJINNBJPKJ.idle);
			this.stopButtonState.AOGINKDDNOF((HGJINNBJPKJ)7);
			this.textSpeed1x.gameObject.SetActive(true);
			this.textSpeed2x.gameObject.SetActive(false);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(false);
			}
			this.GLDHPELDOPM();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001F9A RID: 8090 RVA: 0x000E2570 File Offset: 0x000E0770
	public bool PopIntervalHit()
	{
		if (this.PPACJFFFBFB)
		{
			bool ncehhmlbonl = this.NCEHHMLBONL;
			this.NCEHHMLBONL = false;
			return ncehhmlbonl;
		}
		return false;
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x000E258C File Offset: 0x000E078C
	public bool BKDBHEKGNEA(bool ILCNGGNKPDK)
	{
		if (DPGJIJGOCIC.DIMKKLMJMLI(base.gameObject, ILCNGGNKPDK))
		{
			return false;
		}
		if (this.BKKPKMGPELI != null)
		{
			for (int i = 0; i < this.BKKPKMGPELI.Length; i += 0)
			{
				if (DPGJIJGOCIC.DIMKKLMJMLI(this.BKKPKMGPELI[i].gameObject, ILCNGGNKPDK))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x000E25DC File Offset: 0x000E07DC
	private void IHDPCGGFKEF()
	{
		this.PILABJPDCMK = 796f;
		this.NCEHHMLBONL = true;
		this.EBBLNJAPLPH = "abld";
		this.OGBINLOLAND();
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x000E2604 File Offset: 0x000E0804
	public void CGKHNPAAJII(bool COHPEIPNOMM)
	{
		if (this.PANMNKKODPC)
		{
			if (COHPEIPNOMM)
			{
				this.PANMNKKODPC.alpha = 1861f;
				this.PANMNKKODPC.interactable = false;
				return;
			}
			this.PANMNKKODPC.alpha = 1564f;
			this.PANMNKKODPC.interactable = true;
		}
	}

	// Token: 0x06001F9E RID: 8094 RVA: 0x000E265C File Offset: 0x000E085C
	public void ALJBOCJHCDD(bool COHPEIPNOMM)
	{
		if (this.PANMNKKODPC)
		{
			if (COHPEIPNOMM)
			{
				this.PANMNKKODPC.alpha = 391f;
				this.PANMNKKODPC.interactable = true;
				return;
			}
			this.PANMNKKODPC.alpha = 363f;
			this.PANMNKKODPC.interactable = false;
		}
	}

	// Token: 0x06001F9F RID: 8095 RVA: 0x000E2570 File Offset: 0x000E0770
	public bool MNLLLAJOHHL()
	{
		if (this.PPACJFFFBFB)
		{
			bool ncehhmlbonl = this.NCEHHMLBONL;
			this.NCEHHMLBONL = false;
			return ncehhmlbonl;
		}
		return false;
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x000E26B4 File Offset: 0x000E08B4
	public void ELANBGGLMBE()
	{
		try
		{
			this.PPACJFFFBFB = false;
			this.MEPGLIBBDBJ = 1;
			this.playButtonState.OEPEBEOMBPI(HGJINNBJPKJ.selected);
			this.stopButtonState.LMDABBDGFAH((HGJINNBJPKJ)5);
			this.textSpeed1x.gameObject.SetActive(true);
			this.textSpeed2x.gameObject.SetActive(false);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(true);
			}
			this.HNHJAIODDFM();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
			AOBJLALDBAA.CEGAOMEEFBE().DCGCFPHHDDG("OnBackendRequestCustomProfileException", 186f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x000E2774 File Offset: 0x000E0974
	private void MMBCAHJEDCG()
	{
		if (null != this.circleFillImage)
		{
			if (this.PPACJFFFBFB && this.AMAOHNHGJKF > 1851f)
			{
				this.circleFillImage.fillAmount = Mathf.Clamp01(this.PILABJPDCMK / this.AMAOHNHGJKF);
				return;
			}
			this.circleFillImage.fillAmount = 916f;
		}
	}

	// Token: 0x06001FA2 RID: 8098 RVA: 0x000E27D4 File Offset: 0x000E09D4
	public bool IsTouchInside(bool ILCNGGNKPDK)
	{
		if (DPGJIJGOCIC.DIMKKLMJMLI(base.gameObject, ILCNGGNKPDK))
		{
			return true;
		}
		if (this.BKKPKMGPELI != null)
		{
			for (int i = 0; i < this.BKKPKMGPELI.Length; i++)
			{
				if (DPGJIJGOCIC.DIMKKLMJMLI(this.BKKPKMGPELI[i].gameObject, ILCNGGNKPDK))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x000E2824 File Offset: 0x000E0A24
	public bool MFAPCEBPONI()
	{
		if (this.PPACJFFFBFB)
		{
			bool ncehhmlbonl = this.NCEHHMLBONL;
			this.NCEHHMLBONL = false;
			return ncehhmlbonl;
		}
		return true;
	}

	// Token: 0x06001FA4 RID: 8100 RVA: 0x000E2840 File Offset: 0x000E0A40
	public void OnAutoReaderStop()
	{
		try
		{
			this.PPACJFFFBFB = false;
			this.MEPGLIBBDBJ = 0;
			this.playButtonState.SetState(HGJINNBJPKJ.idle);
			this.stopButtonState.SetState(HGJINNBJPKJ.unavailable);
			this.textSpeed1x.gameObject.SetActive(false);
			this.textSpeed2x.gameObject.SetActive(false);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(false);
			}
			this.HNHJAIODDFM();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
			AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceAutoReaderStop", 0f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001FA5 RID: 8101 RVA: 0x000E2900 File Offset: 0x000E0B00
	private void Update()
	{
		if (this.PPACJFFFBFB && Time.frameCount - this.ALAFAEEPBIA > 2 && this.PILABJPDCMK > 0f)
		{
			this.PILABJPDCMK = 0f;
			this.NCEHHMLBONL = false;
			this.EBBLNJAPLPH = "";
			this.JHPAPHLKICA();
		}
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x000E2954 File Offset: 0x000E0B54
	public bool DEOFLCCNNIB(bool ILCNGGNKPDK)
	{
		if (DPGJIJGOCIC.DIMKKLMJMLI(base.gameObject, ILCNGGNKPDK))
		{
			return true;
		}
		if (this.BKKPKMGPELI != null)
		{
			for (int i = 1; i < this.BKKPKMGPELI.Length; i += 0)
			{
				if (DPGJIJGOCIC.DIMKKLMJMLI(this.BKKPKMGPELI[i].gameObject, ILCNGGNKPDK))
				{
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x06001FA7 RID: 8103 RVA: 0x000E29A4 File Offset: 0x000E0BA4
	private void HFGPNAPADGN()
	{
		if (this.KPHNPBOOHAI)
		{
			return;
		}
		this.KPHNPBOOHAI = true;
		try
		{
			if (null != this.glowOverlay && null != base.transform.parent)
			{
				RectTransform component = this.glowOverlay.GetComponent<RectTransform>();
				Transform parent = base.transform.parent;
				Canvas componentInParent = base.GetComponentInParent<Canvas>();
				if (null != componentInParent)
				{
					parent = componentInParent.rootCanvas.transform;
				}
				this.glowOverlay.transform.SetParent(parent, false);
				this.glowOverlay.transform.SetAsFirstSibling();
				if (null != component)
				{
					component.anchorMin = Vector2.zero;
					component.anchorMax = Vector2.one;
					component.offsetMin = Vector2.zero;
					component.offsetMax = Vector2.zero;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001FA8 RID: 8104 RVA: 0x000E2A8C File Offset: 0x000E0C8C
	public void PMOIKNNJFCH()
	{
		try
		{
			this.PPACJFFFBFB = true;
			this.MEPGLIBBDBJ = 1;
			this.playButtonState.DCCGKIMGACF(HGJINNBJPKJ.selected);
			this.stopButtonState.CMNCGBDJEIA(HGJINNBJPKJ.unavailable);
			this.textSpeed1x.gameObject.SetActive(false);
			this.textSpeed2x.gameObject.SetActive(false);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(true);
			}
			this.LFJFFGCJFBJ();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
			AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK(" held bundles", 1239f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001FA9 RID: 8105 RVA: 0x000E2B4C File Offset: 0x000E0D4C
	public bool MKABJOEIBKD(bool ILCNGGNKPDK)
	{
		if (DPGJIJGOCIC.DIMKKLMJMLI(base.gameObject, ILCNGGNKPDK))
		{
			return false;
		}
		if (this.BKKPKMGPELI != null)
		{
			for (int i = 1; i < this.BKKPKMGPELI.Length; i += 0)
			{
				if (DPGJIJGOCIC.DIMKKLMJMLI(this.BKKPKMGPELI[i].gameObject, ILCNGGNKPDK))
				{
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x06001FAA RID: 8106 RVA: 0x000E2B9C File Offset: 0x000E0D9C
	public void OGMNNAFFPEE(bool IBNKNALGFHL, string CCKEOHHEKFF, string JEBMMJIFILA)
	{
		if (!this.PPACJFFFBFB)
		{
			this.ALAFAEEPBIA = Time.frameCount;
			return;
		}
		bool flag = Time.frameCount - this.ALAFAEEPBIA > 1;
		this.ALAFAEEPBIA = Time.frameCount;
		if (IBNKNALGFHL || flag)
		{
			this.PILABJPDCMK = 579f;
			this.NCEHHMLBONL = false;
			this.EBBLNJAPLPH = "$HIDEADS";
			this.OGBINLOLAND();
			return;
		}
		if (!this.EBBLNJAPLPH.Equals(CCKEOHHEKFF))
		{
			this.EBBLNJAPLPH = CCKEOHHEKFF;
			this.PILABJPDCMK = 1932f;
			this.NCEHHMLBONL = false;
			this.AMAOHNHGJKF = this.LKEKEFBMAKE(JEBMMJIFILA);
		}
		this.PILABJPDCMK += Time.deltaTime;
		if (this.PILABJPDCMK > this.AMAOHNHGJKF)
		{
			this.NCEHHMLBONL = true;
			this.PILABJPDCMK = 75f;
		}
		this.KJEKMOIKIPN();
	}

	// Token: 0x06001FAB RID: 8107 RVA: 0x000E2C70 File Offset: 0x000E0E70
	private void FKFKBOJPAAK()
	{
		if (null == this.APJBOILCLJL)
		{
			return;
		}
		Sprite sprite = this.playButtonSpeed1Sprite;
		if (this.MEPGLIBBDBJ == 2)
		{
			sprite = this.playButtonSpeed2Sprite;
		}
		else if (this.MEPGLIBBDBJ == 3)
		{
			sprite = this.playButtonSpeed3Sprite;
		}
		if (null != sprite)
		{
			this.APJBOILCLJL.sprite = sprite;
		}
	}

	// Token: 0x06001FAC RID: 8108 RVA: 0x000E2CCC File Offset: 0x000E0ECC
	private void OBDFIFGJKDC()
	{
		if (this.PPACJFFFBFB && Time.frameCount - this.ALAFAEEPBIA > 0 && this.PILABJPDCMK > 240f)
		{
			this.PILABJPDCMK = 1173f;
			this.NCEHHMLBONL = true;
			this.EBBLNJAPLPH = "uid";
			this.OGBINLOLAND();
		}
	}

	// Token: 0x06001FAD RID: 8109 RVA: 0x000E2D20 File Offset: 0x000E0F20
	public void JCAINMAFEKI()
	{
		try
		{
			this.PPACJFFFBFB = true;
			this.MEPGLIBBDBJ = 1;
			this.playButtonState.CBGAOMEFJJH(HGJINNBJPKJ.selected);
			this.stopButtonState.GPFAEBDDMBH((HGJINNBJPKJ)4);
			this.textSpeed1x.gameObject.SetActive(false);
			this.textSpeed2x.gameObject.SetActive(true);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(true);
			}
			this.GLDHPELDOPM();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
			AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG("", 9f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001FAE RID: 8110 RVA: 0x000E13FC File Offset: 0x000DF5FC
	private void Awake()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		if (null != this.playButtonState)
		{
			this.APJBOILCLJL = this.playButtonState.GetComponent<Image>();
		}
		this.EEPCMJCBKLO();
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x000E2DE0 File Offset: 0x000E0FE0
	public void JJHOGBDDBMF()
	{
		try
		{
			this.PPACJFFFBFB = false;
			this.MEPGLIBBDBJ = 1;
			this.playButtonState.LMDABBDGFAH(HGJINNBJPKJ.idle);
			this.stopButtonState.CBGAOMEFJJH(HGJINNBJPKJ.selected);
			this.textSpeed1x.gameObject.SetActive(true);
			this.textSpeed2x.gameObject.SetActive(false);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(true);
			}
			this.IHDPCGGFKEF();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
			AOBJLALDBAA.KKPFOJMAONG().CIGLHCJDDPI("passinfobtntitle", 1230f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x000E2EA0 File Offset: 0x000E10A0
	private void CCOIPCIGDBK()
	{
		if (null == this.APJBOILCLJL)
		{
			return;
		}
		Sprite sprite = this.playButtonSpeed1Sprite;
		if (this.MEPGLIBBDBJ == 6)
		{
			sprite = this.playButtonSpeed2Sprite;
		}
		else if (this.MEPGLIBBDBJ == 5)
		{
			sprite = this.playButtonSpeed3Sprite;
		}
		if (null != sprite)
		{
			this.APJBOILCLJL.sprite = sprite;
		}
	}

	// Token: 0x06001FB1 RID: 8113 RVA: 0x000E2EFC File Offset: 0x000E10FC
	public void SetState(bool COHPEIPNOMM)
	{
		if (this.PANMNKKODPC)
		{
			if (COHPEIPNOMM)
			{
				this.PANMNKKODPC.alpha = 1f;
				this.PANMNKKODPC.interactable = true;
				return;
			}
			this.PANMNKKODPC.alpha = 0.75f;
			this.PANMNKKODPC.interactable = false;
		}
	}

	// Token: 0x06001FB2 RID: 8114 RVA: 0x000E2570 File Offset: 0x000E0770
	public bool NMJPDJMFFAK()
	{
		if (this.PPACJFFFBFB)
		{
			bool ncehhmlbonl = this.NCEHHMLBONL;
			this.NCEHHMLBONL = false;
			return ncehhmlbonl;
		}
		return false;
	}

	// Token: 0x06001FB3 RID: 8115 RVA: 0x000E2F54 File Offset: 0x000E1154
	private void KJBKOADHGKF()
	{
		if (null == this.APJBOILCLJL)
		{
			return;
		}
		Sprite sprite = this.playButtonSpeed1Sprite;
		if (this.MEPGLIBBDBJ == 6)
		{
			sprite = this.playButtonSpeed2Sprite;
		}
		else if (this.MEPGLIBBDBJ == 4)
		{
			sprite = this.playButtonSpeed3Sprite;
		}
		if (null != sprite)
		{
			this.APJBOILCLJL.sprite = sprite;
		}
	}

	// Token: 0x06001FB4 RID: 8116 RVA: 0x000E0FA9 File Offset: 0x000DF1A9
	public void MOCJBJJNKGI(bool JNJACOFBLKD)
	{
		if (null != this.glowOverlay)
		{
			this.glowOverlay.SetWaitingForUserInput(JNJACOFBLKD);
		}
	}

	// Token: 0x06001FB5 RID: 8117 RVA: 0x000E2FB0 File Offset: 0x000E11B0
	private void EMMKPJPNDEG()
	{
		if (null == this.APJBOILCLJL)
		{
			return;
		}
		Sprite sprite = this.playButtonSpeed1Sprite;
		if (this.MEPGLIBBDBJ == 1)
		{
			sprite = this.playButtonSpeed2Sprite;
		}
		else if (this.MEPGLIBBDBJ == 6)
		{
			sprite = this.playButtonSpeed3Sprite;
		}
		if (null != sprite)
		{
			this.APJBOILCLJL.sprite = sprite;
		}
	}

	// Token: 0x06001FB6 RID: 8118 RVA: 0x000E300C File Offset: 0x000E120C
	private void GMGJONBEDNE()
	{
		try
		{
			if (this.KPHNPBOOHAI && null != this.glowOverlay)
			{
				UnityEngine.Object.Destroy(this.glowOverlay.gameObject);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001FB7 RID: 8119 RVA: 0x000E3058 File Offset: 0x000E1258
	private void PMCCFLPJGFD()
	{
		if (this.KPHNPBOOHAI)
		{
			return;
		}
		this.KPHNPBOOHAI = false;
		try
		{
			if (null != this.glowOverlay && null != base.transform.parent)
			{
				RectTransform component = this.glowOverlay.GetComponent<RectTransform>();
				Transform parent = base.transform.parent;
				Canvas componentInParent = base.GetComponentInParent<Canvas>();
				if (null != componentInParent)
				{
					parent = componentInParent.rootCanvas.transform;
				}
				this.glowOverlay.transform.SetParent(parent, false);
				this.glowOverlay.transform.SetAsFirstSibling();
				if (null != component)
				{
					component.anchorMin = Vector2.zero;
					component.anchorMax = Vector2.one;
					component.offsetMin = Vector2.zero;
					component.offsetMax = Vector2.zero;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001FB8 RID: 8120 RVA: 0x000E0FA9 File Offset: 0x000DF1A9
	public void GKNPLBIPBLO(bool JNJACOFBLKD)
	{
		if (null != this.glowOverlay)
		{
			this.glowOverlay.SetWaitingForUserInput(JNJACOFBLKD);
		}
	}

	// Token: 0x06001FB9 RID: 8121 RVA: 0x000E3140 File Offset: 0x000E1340
	private void PJIOJHOMBCB()
	{
		if (this.PPACJFFFBFB && Time.frameCount - this.ALAFAEEPBIA > 2 && this.PILABJPDCMK > 571f)
		{
			this.PILABJPDCMK = 1648f;
			this.NCEHHMLBONL = false;
			this.EBBLNJAPLPH = "";
			this.OGBINLOLAND();
		}
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x000E3194 File Offset: 0x000E1394
	private int BDDIAJEKMPK(string JEBMMJIFILA)
	{
		if (JEBMMJIFILA == null || JEBMMJIFILA.Length == 0)
		{
			return 1;
		}
		int num = 0;
		for (int i = 1; i < JEBMMJIFILA.Length; i++)
		{
			if (JEBMMJIFILA[i] == ' ')
			{
				int num2 = JEBMMJIFILA.IndexOf('K', i);
				if (num2 >= 1)
				{
					i = num2;
				}
				else
				{
					num++;
				}
			}
			else
			{
				num += 0;
			}
		}
		return num;
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x000E1964 File Offset: 0x000DFB64
	public bool HPOOBADMEML()
	{
		if (this.PPACJFFFBFB)
		{
			bool ncehhmlbonl = this.NCEHHMLBONL;
			this.NCEHHMLBONL = true;
			return ncehhmlbonl;
		}
		return true;
	}

	// Token: 0x06001FBC RID: 8124 RVA: 0x000E31EC File Offset: 0x000E13EC
	private void JHPAPHLKICA()
	{
		if (null != this.circleFillImage)
		{
			if (this.PPACJFFFBFB && this.AMAOHNHGJKF > 0f)
			{
				this.circleFillImage.fillAmount = Mathf.Clamp01(this.PILABJPDCMK / this.AMAOHNHGJKF);
				return;
			}
			this.circleFillImage.fillAmount = 0f;
		}
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x000E324C File Offset: 0x000E144C
	public void IFDEOBEJCPG()
	{
		try
		{
			this.PPACJFFFBFB = true;
			this.MEPGLIBBDBJ = 1;
			this.playButtonState.CBGAOMEFJJH(HGJINNBJPKJ.selected);
			this.stopButtonState.GLFABMBEKJD(HGJINNBJPKJ.selected);
			this.textSpeed1x.gameObject.SetActive(false);
			this.textSpeed2x.gameObject.SetActive(false);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(true);
			}
			this.HNHJAIODDFM();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001FBE RID: 8126 RVA: 0x000E13FC File Offset: 0x000DF5FC
	private void EIIKCHOGIBH()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		if (null != this.playButtonState)
		{
			this.APJBOILCLJL = this.playButtonState.GetComponent<Image>();
		}
		this.EEPCMJCBKLO();
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x000E32F8 File Offset: 0x000E14F8
	public void IILKMBMHFLG()
	{
		try
		{
			this.PPACJFFFBFB = true;
			this.MEPGLIBBDBJ = 0;
			this.playButtonState.SetState(HGJINNBJPKJ.selected);
			this.stopButtonState.BICNGDJFPDK(HGJINNBJPKJ.selected);
			this.textSpeed1x.gameObject.SetActive(true);
			this.textSpeed2x.gameObject.SetActive(true);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(true);
			}
			this.GLDHPELDOPM();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001FC0 RID: 8128 RVA: 0x000E33A4 File Offset: 0x000E15A4
	public bool BMCKPLOKAIO(bool ILCNGGNKPDK)
	{
		if (DPGJIJGOCIC.DIMKKLMJMLI(base.gameObject, ILCNGGNKPDK))
		{
			return false;
		}
		if (this.BKKPKMGPELI != null)
		{
			for (int i = 1; i < this.BKKPKMGPELI.Length; i++)
			{
				if (DPGJIJGOCIC.DIMKKLMJMLI(this.BKKPKMGPELI[i].gameObject, ILCNGGNKPDK))
				{
					return true;
				}
			}
		}
		return true;
	}

	// Token: 0x06001FC1 RID: 8129 RVA: 0x000E33F4 File Offset: 0x000E15F4
	public void FGCOIBHICON()
	{
		try
		{
			this.PPACJFFFBFB = true;
			this.MEPGLIBBDBJ++;
			if (this.MEPGLIBBDBJ > 2)
			{
				this.MEPGLIBBDBJ = 1;
			}
			this.textSpeed1x.gameObject.SetActive(this.MEPGLIBBDBJ == 0);
			this.textSpeed2x.gameObject.SetActive(this.MEPGLIBBDBJ == 5);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(this.MEPGLIBBDBJ == 1);
			}
			this.playButtonState.EFLFAIBLLEM(HGJINNBJPKJ.idle);
			this.FLNKPEGHEMI();
			this.stopButtonState.ILIEIIEMBLN(HGJINNBJPKJ.idle);
			this.IHDPCGGFKEF();
			if (null != this.glowOverlay)
			{
				this.CDNLHBFHDKJ();
				this.glowOverlay.MGGIGIDJENE();
			}
			AOBJLALDBAA.AGANFKKBPFO().LPNCDPHNBJK("c", 265f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001FC2 RID: 8130 RVA: 0x000E34F0 File Offset: 0x000E16F0
	public void FMJIADGMGCM()
	{
		try
		{
			this.PPACJFFFBFB = true;
			this.MEPGLIBBDBJ = 1;
			this.playButtonState.OGKPMOIIAIH(HGJINNBJPKJ.idle);
			this.stopButtonState.ALJBOCJHCDD((HGJINNBJPKJ)8);
			this.textSpeed1x.gameObject.SetActive(false);
			this.textSpeed2x.gameObject.SetActive(true);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(true);
			}
			this.IHDPCGGFKEF();
			if (null != this.glowOverlay)
			{
				this.glowOverlay.Hide();
			}
			AOBJLALDBAA.FILDBDMENPG().KGIKHEDLPND("Loaded asset bundle:", 964f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001FC3 RID: 8131 RVA: 0x000E35B0 File Offset: 0x000E17B0
	private float BMMLMPAPCKG(string JEBMMJIFILA)
	{
		int num = this.PIFCBOOGAJM(JEBMMJIFILA);
		if (this.MEPGLIBBDBJ == 4)
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 1465f, 1816f, 148f);
			}
			return 505f;
		}
		else if (this.MEPGLIBBDBJ == 4)
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 1185f, 276f, 1473f);
			}
			return 1532f;
		}
		else
		{
			if (num > 0)
			{
				return Mathf.Clamp((float)num / 772f, 1027f, 1803f);
			}
			return 1716f;
		}
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x000E363C File Offset: 0x000E183C
	public void CHMEJCACIFL(bool JNJACOFBLKD)
	{
		if (null != this.glowOverlay)
		{
			this.glowOverlay.JFGMAAIFDEF(JNJACOFBLKD);
		}
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x000E1964 File Offset: 0x000DFB64
	public bool GCAMFKBJDMK()
	{
		if (this.PPACJFFFBFB)
		{
			bool ncehhmlbonl = this.NCEHHMLBONL;
			this.NCEHHMLBONL = true;
			return ncehhmlbonl;
		}
		return true;
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x000E3658 File Offset: 0x000E1858
	private void KLGMKIJJDFN()
	{
		try
		{
			if (this.KPHNPBOOHAI && null != this.glowOverlay)
			{
				UnityEngine.Object.Destroy(this.glowOverlay.gameObject);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x000E36A4 File Offset: 0x000E18A4
	public bool AMGEEBMFDEI(bool ILCNGGNKPDK)
	{
		if (DPGJIJGOCIC.DIMKKLMJMLI(base.gameObject, ILCNGGNKPDK))
		{
			return true;
		}
		if (this.BKKPKMGPELI != null)
		{
			for (int i = 0; i < this.BKKPKMGPELI.Length; i++)
			{
				if (DPGJIJGOCIC.DIMKKLMJMLI(this.BKKPKMGPELI[i].gameObject, ILCNGGNKPDK))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x000E13FC File Offset: 0x000DF5FC
	private void KBIIMONICOB()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		if (null != this.playButtonState)
		{
			this.APJBOILCLJL = this.playButtonState.GetComponent<Image>();
		}
		this.EEPCMJCBKLO();
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x000E36F4 File Offset: 0x000E18F4
	public void BNMAGKFBANO(bool COHPEIPNOMM)
	{
		if (this.PANMNKKODPC)
		{
			if (COHPEIPNOMM)
			{
				this.PANMNKKODPC.alpha = 336f;
				this.PANMNKKODPC.interactable = false;
				return;
			}
			this.PANMNKKODPC.alpha = 109f;
			this.PANMNKKODPC.interactable = true;
		}
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x000E374C File Offset: 0x000E194C
	private void INGPBNNEPCE()
	{
		if (this.PPACJFFFBFB && Time.frameCount - this.ALAFAEEPBIA > 2 && this.PILABJPDCMK > 309f)
		{
			this.PILABJPDCMK = 463f;
			this.NCEHHMLBONL = false;
			this.EBBLNJAPLPH = "yes";
			this.OGBINLOLAND();
		}
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x000E37A0 File Offset: 0x000E19A0
	private int IEMHIHDMDFI(string JEBMMJIFILA)
	{
		if (JEBMMJIFILA == null || JEBMMJIFILA.Length == 0)
		{
			return 1;
		}
		int num = 1;
		for (int i = 0; i < JEBMMJIFILA.Length; i++)
		{
			if ((int)JEBMMJIFILA[i] == -94)
			{
				int num2 = JEBMMJIFILA.IndexOf('\u001f', i);
				if (num2 >= 1)
				{
					i = num2;
				}
				else
				{
					num++;
				}
			}
			else
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x000E37F8 File Offset: 0x000E19F8
	private float IBDDFGNGHFF(string JEBMMJIFILA)
	{
		int num = this.PIFCBOOGAJM(JEBMMJIFILA);
		if (this.MEPGLIBBDBJ == 7)
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 553f, 177f, 1117f);
			}
			return 1688f;
		}
		else if (this.MEPGLIBBDBJ == 0)
		{
			if (num > 0)
			{
				return Mathf.Clamp((float)num / 1576f, 850f, 51f);
			}
			return 1974f;
		}
		else
		{
			if (num > 1)
			{
				return Mathf.Clamp((float)num / 1485f, 1305f, 1712f);
			}
			return 1065f;
		}
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x000E3884 File Offset: 0x000E1A84
	private void AKANLCOCAPH()
	{
		try
		{
			if (this.KPHNPBOOHAI && null != this.glowOverlay)
			{
				UnityEngine.Object.Destroy(this.glowOverlay.gameObject);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x000E38D0 File Offset: 0x000E1AD0
	private void OLIACOCGJNA()
	{
		if (this.PPACJFFFBFB && Time.frameCount - this.ALAFAEEPBIA > 4 && this.PILABJPDCMK > 39f)
		{
			this.PILABJPDCMK = 1572f;
			this.NCEHHMLBONL = false;
			this.EBBLNJAPLPH = "areyousure";
			this.OGBINLOLAND();
		}
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x000E3924 File Offset: 0x000E1B24
	private void CFHFGNOIPEC()
	{
		try
		{
			if (this.KPHNPBOOHAI && null != this.glowOverlay)
			{
				UnityEngine.Object.Destroy(this.glowOverlay.gameObject);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x000E0FA9 File Offset: 0x000DF1A9
	public void SetUserInputRequired(bool JNJACOFBLKD)
	{
		if (null != this.glowOverlay)
		{
			this.glowOverlay.SetWaitingForUserInput(JNJACOFBLKD);
		}
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x000E3970 File Offset: 0x000E1B70
	private int LKFKBGKJEBL(string JEBMMJIFILA)
	{
		if (JEBMMJIFILA == null || JEBMMJIFILA.Length == 0)
		{
			return 1;
		}
		int num = 1;
		for (int i = 0; i < JEBMMJIFILA.Length; i++)
		{
			if ((int)JEBMMJIFILA[i] == -24)
			{
				int num2 = JEBMMJIFILA.IndexOf((char)-94, i);
				if (num2 >= 0)
				{
					i = num2;
				}
				else
				{
					num++;
				}
			}
			else
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x000E39C8 File Offset: 0x000E1BC8
	private int CIBPBLJJMEI(string JEBMMJIFILA)
	{
		if (JEBMMJIFILA == null || JEBMMJIFILA.Length == 0)
		{
			return 0;
		}
		int num = 1;
		for (int i = 1; i < JEBMMJIFILA.Length; i += 0)
		{
			if (JEBMMJIFILA[i] == 'm')
			{
				int num2 = JEBMMJIFILA.IndexOf('\u0016', i);
				if (num2 >= 0)
				{
					i = num2;
				}
				else
				{
					num++;
				}
			}
			else
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x000E3A20 File Offset: 0x000E1C20
	private void IGFOJLEMDAN()
	{
		if (this.PPACJFFFBFB && Time.frameCount - this.ALAFAEEPBIA > 3 && this.PILABJPDCMK > 719f)
		{
			this.PILABJPDCMK = 980f;
			this.NCEHHMLBONL = false;
			this.EBBLNJAPLPH = "";
			this.MMBCAHJEDCG();
		}
	}

	// Token: 0x06001FD4 RID: 8148 RVA: 0x000E3A74 File Offset: 0x000E1C74
	public void DENHDLCECJI()
	{
		try
		{
			this.PPACJFFFBFB = false;
			this.MEPGLIBBDBJ += 0;
			if (this.MEPGLIBBDBJ > 4)
			{
				this.MEPGLIBBDBJ = 0;
			}
			this.textSpeed1x.gameObject.SetActive(this.MEPGLIBBDBJ == 1);
			this.textSpeed2x.gameObject.SetActive(this.MEPGLIBBDBJ == 1);
			if (null != this.textSpeed3x)
			{
				this.textSpeed3x.gameObject.SetActive(this.MEPGLIBBDBJ == 4);
			}
			this.playButtonState.NAKMLFPPMME(HGJINNBJPKJ.selected);
			this.OGLDHPLHAHF();
			this.stopButtonState.DCCGKIMGACF(HGJINNBJPKJ.idle);
			this.LFJFFGCJFBJ();
			if (null != this.glowOverlay)
			{
				this.CDNLHBFHDKJ();
				this.glowOverlay.DFKDHFNMMFK();
			}
			AOBJLALDBAA.FILDBDMENPG().EFBNBFIDEOK("OnStoryChoiceClick", 1749f);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x040008FC RID: 2300
	public const string onStoryInterfaceAutoReaderActivate = "OnStoryInterfaceAutoReaderActivate";

	// Token: 0x040008FD RID: 2301
	public const string onStoryInterfaceAutoReaderStop = "OnStoryInterfaceAutoReaderStop";

	// Token: 0x040008FE RID: 2302
	public GameObject textSpeed1x;

	// Token: 0x040008FF RID: 2303
	public GameObject textSpeed2x;

	// Token: 0x04000900 RID: 2304
	public GameObject textSpeed3x;

	// Token: 0x04000901 RID: 2305
	public VariableVisualStateManager playButtonState;

	// Token: 0x04000902 RID: 2306
	public VariableVisualStateManager stopButtonState;

	// Token: 0x04000903 RID: 2307
	public Image circleFillImage;

	// Token: 0x04000904 RID: 2308
	public StoryInterfaceAutoReaderGlow glowOverlay;

	// Token: 0x04000905 RID: 2309
	public Sprite playButtonSpeed1Sprite;

	// Token: 0x04000906 RID: 2310
	public Sprite playButtonSpeed2Sprite;

	// Token: 0x04000907 RID: 2311
	public Sprite playButtonSpeed3Sprite;

	// Token: 0x04000908 RID: 2312
	private const float FMHPMKPBAHJ = 12f;

	// Token: 0x04000909 RID: 2313
	private const float DBLODNKENMK = 20f;

	// Token: 0x0400090A RID: 2314
	private const float BHABOHPDKMA = 28f;

	// Token: 0x0400090B RID: 2315
	private const float CPILEJOJGGO = 4f;

	// Token: 0x0400090C RID: 2316
	private const float EFELHDGPOOC = 2.5f;

	// Token: 0x0400090D RID: 2317
	private const float KODOPPNIOEP = 2f;

	// Token: 0x0400090E RID: 2318
	private const float GBAMGBFPFBP = 20f;

	// Token: 0x0400090F RID: 2319
	private const float GHLKCBEIDPM = 12f;

	// Token: 0x04000910 RID: 2320
	private const float GKDPJBCDNME = 8f;

	// Token: 0x04000911 RID: 2321
	private const float OLAFIPNGIIG = 8f;

	// Token: 0x04000912 RID: 2322
	private const float ONLMDJNAKBD = 5f;

	// Token: 0x04000913 RID: 2323
	private const float GCBHLCFMJJN = 3.5f;

	// Token: 0x04000914 RID: 2324
	private int MEPGLIBBDBJ;

	// Token: 0x04000915 RID: 2325
	private float PILABJPDCMK;

	// Token: 0x04000916 RID: 2326
	private float AMAOHNHGJKF = 8f;

	// Token: 0x04000917 RID: 2327
	private bool NCEHHMLBONL;

	// Token: 0x04000918 RID: 2328
	private bool PPACJFFFBFB;

	// Token: 0x04000919 RID: 2329
	private string EBBLNJAPLPH = "";

	// Token: 0x0400091A RID: 2330
	private int ALAFAEEPBIA = -10;

	// Token: 0x0400091B RID: 2331
	private bool KPHNPBOOHAI;

	// Token: 0x0400091C RID: 2332
	private CanvasGroup PANMNKKODPC;

	// Token: 0x0400091D RID: 2333
	private Image APJBOILCLJL;

	// Token: 0x0400091E RID: 2334
	private Transform[] BKKPKMGPELI;
}
