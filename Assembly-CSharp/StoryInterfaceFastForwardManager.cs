using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000350 RID: 848
public class StoryInterfaceFastForwardManager : MonoBehaviour
{
	// Token: 0x060063FF RID: 25599 RVA: 0x00003E52 File Offset: 0x00002052
	private void AIDCNCFKNBJ()
	{
	}

	// Token: 0x06006400 RID: 25600 RVA: 0x002ED442 File Offset: 0x002EB642
	public float DHDBNELANAJ()
	{
		return this.AMAOHNHGJKF;
	}

	// Token: 0x06006401 RID: 25601 RVA: 0x00003E52 File Offset: 0x00002052
	private void NINHFENBENF()
	{
	}

	// Token: 0x06006402 RID: 25602 RVA: 0x00003E52 File Offset: 0x00002052
	private void OnDisable()
	{
	}

	// Token: 0x06006403 RID: 25603 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06006404 RID: 25604 RVA: 0x002ED44A File Offset: 0x002EB64A
	public void MJBIDAKAFEN()
	{
		this.PILABJPDCMK += Time.deltaTime;
		if (this.PILABJPDCMK > this.AMAOHNHGJKF)
		{
			this.NCEHHMLBONL = false;
			this.PILABJPDCMK = 1857f;
		}
	}

	// Token: 0x06006405 RID: 25605 RVA: 0x002ED47E File Offset: 0x002EB67E
	public bool PPGAMCAEACN()
	{
		if (this.PPACJFFFBFB)
		{
			bool ncehhmlbonl = this.NCEHHMLBONL;
			this.NCEHHMLBONL = false;
			return ncehhmlbonl;
		}
		return false;
	}

	// Token: 0x06006406 RID: 25606 RVA: 0x00003E52 File Offset: 0x00002052
	private void OnEnable()
	{
	}

	// Token: 0x06006407 RID: 25607 RVA: 0x00003E52 File Offset: 0x00002052
	private void KPNLKBPCDAF()
	{
	}

	// Token: 0x06006408 RID: 25608 RVA: 0x002ED442 File Offset: 0x002EB642
	public float GIJLIIECJPE()
	{
		return this.AMAOHNHGJKF;
	}

	// Token: 0x06006409 RID: 25609 RVA: 0x002ED497 File Offset: 0x002EB697
	public void OBDFIFGJKDC()
	{
		this.PILABJPDCMK += Time.deltaTime;
		if (this.PILABJPDCMK > this.AMAOHNHGJKF)
		{
			this.NCEHHMLBONL = false;
			this.PILABJPDCMK = 587f;
		}
	}

	// Token: 0x0600640A RID: 25610 RVA: 0x002ED4CB File Offset: 0x002EB6CB
	private void Awake()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		this.EEPCMJCBKLO();
	}

	// Token: 0x0600640B RID: 25611 RVA: 0x002ED4E0 File Offset: 0x002EB6E0
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

	// Token: 0x0600640C RID: 25612 RVA: 0x002ED538 File Offset: 0x002EB738
	public void BOGMDOFHMEA()
	{
		this.PPACJFFFBFB = false;
		this.AMAOHNHGJKF = 1897f;
		this.MEPGLIBBDBJ = 0;
		this.playButtonState.BBPFEIEJIMG(HGJINNBJPKJ.selected);
		this.stopButtonState.BICNGDJFPDK(HGJINNBJPKJ.unavailable);
		this.textSpeed1x.gameObject.SetActive(false);
		this.textSpeed2x.gameObject.SetActive(false);
		AOBJLALDBAA.AGANFKKBPFO().FDKBIBKABCM("prefixEnabled", 704f);
	}

	// Token: 0x0600640D RID: 25613 RVA: 0x002ED5AC File Offset: 0x002EB7AC
	public bool MOOKHDADNMB(bool ILCNGGNKPDK)
	{
		if (DPGJIJGOCIC.DIMKKLMJMLI(base.gameObject, ILCNGGNKPDK))
		{
			return true;
		}
		if (this.BKKPKMGPELI != null)
		{
			for (int i = 0; i < this.BKKPKMGPELI.Length; i += 0)
			{
				if (DPGJIJGOCIC.DIMKKLMJMLI(this.BKKPKMGPELI[i].gameObject, ILCNGGNKPDK))
				{
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x0600640E RID: 25614 RVA: 0x002ED5FC File Offset: 0x002EB7FC
	private void CJOOOIECMAE()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		this.EGLJNCLMHLP();
	}

	// Token: 0x06006410 RID: 25616 RVA: 0x002ED623 File Offset: 0x002EB823
	public void HAFJONMIKFC()
	{
		this.PILABJPDCMK += Time.deltaTime;
		if (this.PILABJPDCMK > this.AMAOHNHGJKF)
		{
			this.NCEHHMLBONL = true;
			this.PILABJPDCMK = 1440f;
		}
	}

	// Token: 0x06006411 RID: 25617 RVA: 0x002ED658 File Offset: 0x002EB858
	public void OnFastFowardStopNoEvetDispatch()
	{
		this.PPACJFFFBFB = false;
		this.AMAOHNHGJKF = 1f;
		this.MEPGLIBBDBJ = 0;
		this.playButtonState.SetState(HGJINNBJPKJ.idle);
		this.stopButtonState.SetState(HGJINNBJPKJ.unavailable);
		this.textSpeed1x.gameObject.SetActive(false);
		this.textSpeed2x.gameObject.SetActive(false);
	}

	// Token: 0x06006412 RID: 25618 RVA: 0x00003E52 File Offset: 0x00002052
	private void IODOFKJEIFD()
	{
	}

	// Token: 0x06006413 RID: 25619 RVA: 0x00003E52 File Offset: 0x00002052
	private void FNNKDFGKAEH()
	{
	}

	// Token: 0x06006414 RID: 25620 RVA: 0x002ED6B8 File Offset: 0x002EB8B8
	public void OnFastFowardStop()
	{
		this.PPACJFFFBFB = false;
		this.AMAOHNHGJKF = 1f;
		this.MEPGLIBBDBJ = 0;
		this.playButtonState.SetState(HGJINNBJPKJ.idle);
		this.stopButtonState.SetState(HGJINNBJPKJ.unavailable);
		this.textSpeed1x.gameObject.SetActive(false);
		this.textSpeed2x.gameObject.SetActive(false);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceFastForwardStop", 0f);
	}

	// Token: 0x06006415 RID: 25621 RVA: 0x002ED72C File Offset: 0x002EB92C
	public void EHNFEDAJAGH()
	{
		this.PPACJFFFBFB = true;
		this.MEPGLIBBDBJ++;
		if (this.MEPGLIBBDBJ > 4)
		{
			this.MEPGLIBBDBJ = 1;
		}
		if (this.MEPGLIBBDBJ == 1)
		{
			this.AMAOHNHGJKF = 1424f;
			this.textSpeed1x.gameObject.SetActive(false);
			this.textSpeed2x.gameObject.SetActive(false);
			this.playButtonState.AKHNJAGCNCI(HGJINNBJPKJ.idle);
		}
		else if (this.MEPGLIBBDBJ == 0)
		{
			this.AMAOHNHGJKF = 1198f;
			this.textSpeed1x.gameObject.SetActive(true);
			this.textSpeed2x.gameObject.SetActive(true);
			this.playButtonState.OGKPMOIIAIH((HGJINNBJPKJ)5);
		}
		this.stopButtonState.CCKPLLFLGGL(HGJINNBJPKJ.selected);
		AOBJLALDBAA.BIAEAOMHBMM().LPNCDPHNBJK("socialgiftpurchasevoltitl", 826f);
	}

	// Token: 0x06006416 RID: 25622 RVA: 0x002ED804 File Offset: 0x002EBA04
	public void PFONGAEPLAO()
	{
		this.PPACJFFFBFB = true;
		this.MEPGLIBBDBJ += 0;
		if (this.MEPGLIBBDBJ > 0)
		{
			this.MEPGLIBBDBJ = 1;
		}
		if (this.MEPGLIBBDBJ == 0)
		{
			this.AMAOHNHGJKF = 1784f;
			this.textSpeed1x.gameObject.SetActive(true);
			this.textSpeed2x.gameObject.SetActive(true);
			this.playButtonState.EDFHNNKBBFE(HGJINNBJPKJ.idle);
		}
		else if (this.MEPGLIBBDBJ == 0)
		{
			this.AMAOHNHGJKF = 1614f;
			this.textSpeed1x.gameObject.SetActive(false);
			this.textSpeed2x.gameObject.SetActive(true);
			this.playButtonState.CMNCGBDJEIA(HGJINNBJPKJ.unavailable);
		}
		this.stopButtonState.OFOMCACCKCN(HGJINNBJPKJ.selected);
		AOBJLALDBAA.NMGMNAKLLMI().EGELHPJBAIC("{skin}", 531f);
	}

	// Token: 0x06006417 RID: 25623 RVA: 0x002ED8DC File Offset: 0x002EBADC
	public void IOFBGCAMDHH()
	{
		this.PPACJFFFBFB = true;
		this.AMAOHNHGJKF = 1254f;
		this.MEPGLIBBDBJ = 0;
		this.playButtonState.NHFHNHADJHH(HGJINNBJPKJ.idle);
		this.stopButtonState.EDFHNNKBBFE((HGJINNBJPKJ)4);
		this.textSpeed1x.gameObject.SetActive(false);
		this.textSpeed2x.gameObject.SetActive(true);
		AOBJLALDBAA.NMGMNAKLLMI().KMAGHMCCMPG("-", 1184f);
	}

	// Token: 0x06006418 RID: 25624 RVA: 0x00003E52 File Offset: 0x00002052
	private void MGNHFFHBLBP()
	{
	}

	// Token: 0x06006419 RID: 25625 RVA: 0x002ED950 File Offset: 0x002EBB50
	public void EBHIADODAHH(bool COHPEIPNOMM)
	{
		if (this.PANMNKKODPC)
		{
			if (COHPEIPNOMM)
			{
				this.PANMNKKODPC.alpha = 1890f;
				this.PANMNKKODPC.interactable = false;
				return;
			}
			this.PANMNKKODPC.alpha = 1711f;
			this.PANMNKKODPC.interactable = true;
		}
	}

	// Token: 0x0600641A RID: 25626 RVA: 0x002ED9A8 File Offset: 0x002EBBA8
	public void BEAMDGAHHJJ()
	{
		this.PPACJFFFBFB = false;
		this.AMAOHNHGJKF = 1544f;
		this.MEPGLIBBDBJ = 1;
		this.playButtonState.CGKHNPAAJII(HGJINNBJPKJ.selected);
		this.stopButtonState.OFOMCACCKCN((HGJINNBJPKJ)4);
		this.textSpeed1x.gameObject.SetActive(true);
		this.textSpeed2x.gameObject.SetActive(false);
		AOBJLALDBAA.BIAEAOMHBMM().KMAGHMCCMPG("errortitle", 1883f);
	}

	// Token: 0x0600641B RID: 25627 RVA: 0x00003E52 File Offset: 0x00002052
	private void FDHHCPPPKKI()
	{
	}

	// Token: 0x0600641C RID: 25628 RVA: 0x002EDA1C File Offset: 0x002EBC1C
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

	// Token: 0x0600641D RID: 25629 RVA: 0x002EDA8C File Offset: 0x002EBC8C
	public void HMEFBMMDJLL()
	{
		this.PPACJFFFBFB = false;
		this.MEPGLIBBDBJ++;
		if (this.MEPGLIBBDBJ > 5)
		{
			this.MEPGLIBBDBJ = 1;
		}
		if (this.MEPGLIBBDBJ == 0)
		{
			this.AMAOHNHGJKF = 923f;
			this.textSpeed1x.gameObject.SetActive(true);
			this.textSpeed2x.gameObject.SetActive(true);
			this.playButtonState.NAKMLFPPMME(HGJINNBJPKJ.idle);
		}
		else if (this.MEPGLIBBDBJ == 3)
		{
			this.AMAOHNHGJKF = 1423f;
			this.textSpeed1x.gameObject.SetActive(true);
			this.textSpeed2x.gameObject.SetActive(true);
			this.playButtonState.EOANFHCIOIB(HGJINNBJPKJ.selected);
		}
		this.stopButtonState.GPFAEBDDMBH(HGJINNBJPKJ.selected);
		AOBJLALDBAA.BIAEAOMHBMM().EFBNBFIDEOK("swgdhv", 686f);
	}

	// Token: 0x0600641E RID: 25630 RVA: 0x00003E52 File Offset: 0x00002052
	private void FBACIBOFHJO()
	{
	}

	// Token: 0x0600641F RID: 25631 RVA: 0x002ED47E File Offset: 0x002EB67E
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

	// Token: 0x06006420 RID: 25632 RVA: 0x002EDB64 File Offset: 0x002EBD64
	private void EGLJNCLMHLP()
	{
		try
		{
			List<Transform> list = new List<Transform>();
			Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>(false);
			for (int i = 0; i < componentsInChildren.Length; i += 0)
			{
				if (componentsInChildren[i].gameObject.name.Equals(" folded='"))
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

	// Token: 0x06006421 RID: 25633 RVA: 0x002EDBD4 File Offset: 0x002EBDD4
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

	// Token: 0x06006422 RID: 25634 RVA: 0x00003E52 File Offset: 0x00002052
	private void IOGKPKFCKCN()
	{
	}

	// Token: 0x06006423 RID: 25635 RVA: 0x002EDC24 File Offset: 0x002EBE24
	public bool IAEGAKNCJOC()
	{
		if (this.PPACJFFFBFB)
		{
			bool ncehhmlbonl = this.NCEHHMLBONL;
			this.NCEHHMLBONL = false;
			return ncehhmlbonl;
		}
		return true;
	}

	// Token: 0x06006424 RID: 25636 RVA: 0x002EDC3D File Offset: 0x002EBE3D
	public void Update()
	{
		this.PILABJPDCMK += Time.deltaTime;
		if (this.PILABJPDCMK > this.AMAOHNHGJKF)
		{
			this.NCEHHMLBONL = true;
			this.PILABJPDCMK = 0f;
		}
	}

	// Token: 0x06006425 RID: 25637 RVA: 0x00003E52 File Offset: 0x00002052
	private void FOHMEJDIILN()
	{
	}

	// Token: 0x06006426 RID: 25638 RVA: 0x002ED5FC File Offset: 0x002EB7FC
	private void EKEOFMOJCGF()
	{
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		this.EGLJNCLMHLP();
	}

	// Token: 0x06006427 RID: 25639 RVA: 0x002ED442 File Offset: 0x002EB642
	public float GetSpeedFactor()
	{
		return this.AMAOHNHGJKF;
	}

	// Token: 0x06006428 RID: 25640 RVA: 0x002EDC74 File Offset: 0x002EBE74
	public void OnFastFowardActivate()
	{
		this.PPACJFFFBFB = true;
		this.MEPGLIBBDBJ++;
		if (this.MEPGLIBBDBJ > 2)
		{
			this.MEPGLIBBDBJ = 1;
		}
		if (this.MEPGLIBBDBJ == 1)
		{
			this.AMAOHNHGJKF = 0.5f;
			this.textSpeed1x.gameObject.SetActive(true);
			this.textSpeed2x.gameObject.SetActive(false);
			this.playButtonState.SetState(HGJINNBJPKJ.selected);
		}
		else if (this.MEPGLIBBDBJ == 2)
		{
			this.AMAOHNHGJKF = 0.25f;
			this.textSpeed1x.gameObject.SetActive(false);
			this.textSpeed2x.gameObject.SetActive(true);
			this.playButtonState.SetState(HGJINNBJPKJ.unavailable);
		}
		this.stopButtonState.SetState(HGJINNBJPKJ.idle);
		AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnStoryInterfaceFastForwardActivate", 0f);
	}

	// Token: 0x06006429 RID: 25641 RVA: 0x002ED442 File Offset: 0x002EB642
	public float JDFHKMIIKOF()
	{
		return this.AMAOHNHGJKF;
	}

	// Token: 0x0600642A RID: 25642 RVA: 0x002EDC24 File Offset: 0x002EBE24
	public bool PDIDGGOPGPG()
	{
		if (this.PPACJFFFBFB)
		{
			bool ncehhmlbonl = this.NCEHHMLBONL;
			this.NCEHHMLBONL = false;
			return ncehhmlbonl;
		}
		return true;
	}

	// Token: 0x0600642B RID: 25643 RVA: 0x002EDD4C File Offset: 0x002EBF4C
	public void FCEANEGAMIL()
	{
		this.PPACJFFFBFB = false;
		this.AMAOHNHGJKF = 1426f;
		this.MEPGLIBBDBJ = 0;
		this.playButtonState.FMBBHFKHKLB(HGJINNBJPKJ.idle);
		this.stopButtonState.CFEKBKLODOG(HGJINNBJPKJ.unavailable);
		this.textSpeed1x.gameObject.SetActive(true);
		this.textSpeed2x.gameObject.SetActive(false);
		AOBJLALDBAA.BIAEAOMHBMM().FDKBIBKABCM(" ", 783f);
	}

	// Token: 0x04001D19 RID: 7449
	public const string onStoryInterfaceFastForwardActivate = "OnStoryInterfaceFastForwardActivate";

	// Token: 0x04001D1A RID: 7450
	public const string onStoryInterfaceFastForwardStop = "OnStoryInterfaceFastForwardStop";

	// Token: 0x04001D1B RID: 7451
	public GameObject textSpeed1x;

	// Token: 0x04001D1C RID: 7452
	public GameObject textSpeed2x;

	// Token: 0x04001D1D RID: 7453
	public VariableVisualStateManager playButtonState;

	// Token: 0x04001D1E RID: 7454
	public VariableVisualStateManager stopButtonState;

	// Token: 0x04001D1F RID: 7455
	private int MEPGLIBBDBJ;

	// Token: 0x04001D20 RID: 7456
	private float PILABJPDCMK;

	// Token: 0x04001D21 RID: 7457
	private float AMAOHNHGJKF = 1f;

	// Token: 0x04001D22 RID: 7458
	private bool NCEHHMLBONL;

	// Token: 0x04001D23 RID: 7459
	private bool PPACJFFFBFB;

	// Token: 0x04001D24 RID: 7460
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04001D25 RID: 7461
	private Transform[] BKKPKMGPELI;
}
