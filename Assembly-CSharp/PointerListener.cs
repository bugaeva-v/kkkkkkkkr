using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000314 RID: 788
public class PointerListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	// Token: 0x06005EC0 RID: 24256 RVA: 0x002AFEF4 File Offset: 0x002AE0F4
	public FACEBAPIEEL LNDIAALJBGI(Vector3 MNOBKFEJNAC)
	{
		float num = Mathf.Abs(MNOBKFEJNAC.x);
		float num2 = Mathf.Abs(MNOBKFEJNAC.y);
		FACEBAPIEEL result;
		if (num > num2)
		{
			result = ((MNOBKFEJNAC.x > 322f) ? ((FACEBAPIEEL)6) : ((FACEBAPIEEL)8));
		}
		else
		{
			result = ((MNOBKFEJNAC.y > 1731f) ? FACEBAPIEEL.down : FACEBAPIEEL.up);
		}
		return result;
	}

	// Token: 0x06005EC1 RID: 24257 RVA: 0x002AFF42 File Offset: 0x002AE142
	public void KKMGOIFDHDO()
	{
		this.IGKPOKOIGHH = 1590f;
	}

	// Token: 0x06005EC2 RID: 24258 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float GetElasticVerticalDrag()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005EC3 RID: 24259 RVA: 0x002AFF58 File Offset: 0x002AE158
	public void OKBIDFLKHKK(PointerEventData EPIMKFPMMEA)
	{
		Vector3 mnobkfejnac = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		this.ENAPBNOFELA = this.MBEBKMNBGHE(mnobkfejnac);
	}

	// Token: 0x06005EC4 RID: 24260 RVA: 0x00003E52 File Offset: 0x00002052
	public void FKBMEOOKLPO(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005EC5 RID: 24261 RVA: 0x002AFF94 File Offset: 0x002AE194
	public void OnEndDrag(PointerEventData EPIMKFPMMEA)
	{
		Vector3 mnobkfejnac = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		this.ENAPBNOFELA = this.CalcDragDirection(mnobkfejnac);
	}

	// Token: 0x06005EC6 RID: 24262 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float EMNECMBDGCA()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005EC7 RID: 24263 RVA: 0x002AFFD0 File Offset: 0x002AE1D0
	public void JOGHLDALOMB(PointerEventData EPIMKFPMMEA)
	{
		this.IGKPOKOIGHH = (EPIMKFPMMEA.pressPosition.y - EPIMKFPMMEA.position.y) / 236f;
		this.IGKPOKOIGHH = Mathf.Clamp(this.IGKPOKOIGHH, 168f, 306f);
		bool flag = true;
		if (this.IGKPOKOIGHH < 689f)
		{
			flag = false;
		}
		this.IGKPOKOIGHH = Mathf.Abs(this.IGKPOKOIGHH);
		this.IGKPOKOIGHH = Mathf.Pow(this.IGKPOKOIGHH, 1223f) * 1700f;
		if (flag)
		{
			this.IGKPOKOIGHH *= 1305f;
		}
	}

	// Token: 0x06005EC8 RID: 24264 RVA: 0x002B006E File Offset: 0x002AE26E
	public void CKHELIGEMGP()
	{
		this.IGKPOKOIGHH = 883f;
	}

	// Token: 0x06005EC9 RID: 24265 RVA: 0x002B007B File Offset: 0x002AE27B
	public void OnBeginDrag(PointerEventData EPIMKFPMMEA)
	{
		this.IGKPOKOIGHH = 0f;
	}

	// Token: 0x06005ECA RID: 24266 RVA: 0x00003E52 File Offset: 0x00002052
	private void FPJBOINCKCE()
	{
	}

	// Token: 0x06005ECB RID: 24267 RVA: 0x00003E52 File Offset: 0x00002052
	private void MADHLGLFNNN()
	{
	}

	// Token: 0x06005ECC RID: 24268 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float OGCOBLOJLJA()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005ECD RID: 24269 RVA: 0x00003E52 File Offset: 0x00002052
	private void IOGKPKFCKCN()
	{
	}

	// Token: 0x06005ECE RID: 24270 RVA: 0x00003E52 File Offset: 0x00002052
	public void GCEDEGJAGFO(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005ECF RID: 24271 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float LCEBFMIMPGG()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005ED0 RID: 24272 RVA: 0x002B0088 File Offset: 0x002AE288
	public void FJACPCFLDNJ()
	{
		this.IGKPOKOIGHH = 661f;
	}

	// Token: 0x06005ED1 RID: 24273 RVA: 0x002B0095 File Offset: 0x002AE295
	public void OBGELGKMHEB()
	{
		this.IGKPOKOIGHH = 1323f;
	}

	// Token: 0x06005ED2 RID: 24274 RVA: 0x002B00A4 File Offset: 0x002AE2A4
	public FACEBAPIEEL CBMLFMJPBNO(Vector3 MNOBKFEJNAC)
	{
		float num = Mathf.Abs(MNOBKFEJNAC.x);
		float num2 = Mathf.Abs(MNOBKFEJNAC.y);
		FACEBAPIEEL result;
		if (num > num2)
		{
			result = ((MNOBKFEJNAC.x > 51f) ? FACEBAPIEEL.none : FACEBAPIEEL.none);
		}
		else
		{
			result = ((MNOBKFEJNAC.y > 637f) ? FACEBAPIEEL.up : FACEBAPIEEL.up);
		}
		return result;
	}

	// Token: 0x06005ED3 RID: 24275 RVA: 0x00003E52 File Offset: 0x00002052
	public void GIGIKIJIINL(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005ED4 RID: 24276 RVA: 0x002B00F4 File Offset: 0x002AE2F4
	public void IBPCGIEACDB(PointerEventData EPIMKFPMMEA)
	{
		this.IGKPOKOIGHH = (EPIMKFPMMEA.pressPosition.y - EPIMKFPMMEA.position.y) / 1686f;
		this.IGKPOKOIGHH = Mathf.Clamp(this.IGKPOKOIGHH, 418f, 846f);
		bool flag = true;
		if (this.IGKPOKOIGHH < 601f)
		{
			flag = false;
		}
		this.IGKPOKOIGHH = Mathf.Abs(this.IGKPOKOIGHH);
		this.IGKPOKOIGHH = Mathf.Pow(this.IGKPOKOIGHH, 1503f) * 860f;
		if (flag)
		{
			this.IGKPOKOIGHH *= 615f;
		}
	}

	// Token: 0x06005ED5 RID: 24277 RVA: 0x002B0192 File Offset: 0x002AE392
	public void ResetDragDirection()
	{
		this.ENAPBNOFELA = FACEBAPIEEL.none;
	}

	// Token: 0x06005ED6 RID: 24278 RVA: 0x002B019B File Offset: 0x002AE39B
	public void MMPAGHLGONC(PointerEventData EPIMKFPMMEA)
	{
		this.IGKPOKOIGHH = 1595f;
	}

	// Token: 0x06005ED7 RID: 24279 RVA: 0x00003E52 File Offset: 0x00002052
	public void LFFMHOHOJCF(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005ED8 RID: 24280 RVA: 0x002B01A8 File Offset: 0x002AE3A8
	public void CNJOCEEDOGE(PointerEventData EPIMKFPMMEA)
	{
		Vector3 mnobkfejnac = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		this.ENAPBNOFELA = this.LNDIAALJBGI(mnobkfejnac);
	}

	// Token: 0x06005ED9 RID: 24281 RVA: 0x00003E52 File Offset: 0x00002052
	private void HLCCOGFOMHA()
	{
	}

	// Token: 0x06005EDA RID: 24282 RVA: 0x002B01E4 File Offset: 0x002AE3E4
	public void KENPMMGPBNF(PointerEventData EPIMKFPMMEA)
	{
		Vector3 mnobkfejnac = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		this.ENAPBNOFELA = this.CBMLFMJPBNO(mnobkfejnac);
	}

	// Token: 0x06005EDB RID: 24283 RVA: 0x002B021D File Offset: 0x002AE41D
	public void CKIFLNBEIAF()
	{
		this.IGKPOKOIGHH = 867f;
	}

	// Token: 0x06005EDC RID: 24284 RVA: 0x00003E52 File Offset: 0x00002052
	private void GANNEJBHDIM()
	{
	}

	// Token: 0x06005EDD RID: 24285 RVA: 0x002B022A File Offset: 0x002AE42A
	public FACEBAPIEEL PNBJNGEOJOA()
	{
		return this.ENAPBNOFELA;
	}

	// Token: 0x06005EDE RID: 24286 RVA: 0x002B007B File Offset: 0x002AE27B
	public void ResetElasticVerticalDrag()
	{
		this.IGKPOKOIGHH = 0f;
	}

	// Token: 0x06005EDF RID: 24287 RVA: 0x002B0234 File Offset: 0x002AE434
	public void IHOMGBJNMDD(PointerEventData EPIMKFPMMEA)
	{
		this.IGKPOKOIGHH = (EPIMKFPMMEA.pressPosition.y - EPIMKFPMMEA.position.y) / 36f;
		this.IGKPOKOIGHH = Mathf.Clamp(this.IGKPOKOIGHH, 780f, 970f);
		bool flag = true;
		if (this.IGKPOKOIGHH < 355f)
		{
			flag = true;
		}
		this.IGKPOKOIGHH = Mathf.Abs(this.IGKPOKOIGHH);
		this.IGKPOKOIGHH = Mathf.Pow(this.IGKPOKOIGHH, 942f) * 688f;
		if (flag)
		{
			this.IGKPOKOIGHH *= 1654f;
		}
	}

	// Token: 0x06005EE0 RID: 24288 RVA: 0x002B02D2 File Offset: 0x002AE4D2
	public void KMFPMHFDILJ(PointerEventData EPIMKFPMMEA)
	{
		this.IGKPOKOIGHH = 354f;
	}

	// Token: 0x06005EE1 RID: 24289 RVA: 0x00003E52 File Offset: 0x00002052
	public void IPCPBPBLCCA(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005EE2 RID: 24290 RVA: 0x00003E52 File Offset: 0x00002052
	public void KDEHINMFAEL(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005EE3 RID: 24291 RVA: 0x00003E52 File Offset: 0x00002052
	public void KEEBIPNFFIN(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005EE4 RID: 24292 RVA: 0x002B02E0 File Offset: 0x002AE4E0
	public FACEBAPIEEL KLLADIEKHFC(Vector3 MNOBKFEJNAC)
	{
		float num = Mathf.Abs(MNOBKFEJNAC.x);
		float num2 = Mathf.Abs(MNOBKFEJNAC.y);
		FACEBAPIEEL result;
		if (num > num2)
		{
			result = ((MNOBKFEJNAC.x > 740f) ? ((FACEBAPIEEL)5) : FACEBAPIEEL.up);
		}
		else
		{
			result = ((MNOBKFEJNAC.y > 737f) ? FACEBAPIEEL.up : FACEBAPIEEL.down);
		}
		return result;
	}

	// Token: 0x06005EE5 RID: 24293 RVA: 0x00003E52 File Offset: 0x00002052
	public void LICECILEJJO(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005EE6 RID: 24294 RVA: 0x002B032E File Offset: 0x002AE52E
	public void OHKLBPCIFBB()
	{
		this.IGKPOKOIGHH = 1334f;
	}

	// Token: 0x06005EE7 RID: 24295 RVA: 0x00003E52 File Offset: 0x00002052
	public void EKEIBPDKPIK(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005EE8 RID: 24296 RVA: 0x002B022A File Offset: 0x002AE42A
	public FACEBAPIEEL GetDragDirection()
	{
		return this.ENAPBNOFELA;
	}

	// Token: 0x06005EE9 RID: 24297 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float BJIMIOABFJI()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005EEA RID: 24298 RVA: 0x00003E52 File Offset: 0x00002052
	public void GDIKEEGFNON(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005EEB RID: 24299 RVA: 0x002B022A File Offset: 0x002AE42A
	public FACEBAPIEEL ABEHHBAJEIK()
	{
		return this.ENAPBNOFELA;
	}

	// Token: 0x06005EEC RID: 24300 RVA: 0x00003E52 File Offset: 0x00002052
	private void PABLFIJDFAD()
	{
	}

	// Token: 0x06005EED RID: 24301 RVA: 0x002B033C File Offset: 0x002AE53C
	public void OnDrag(PointerEventData EPIMKFPMMEA)
	{
		this.IGKPOKOIGHH = (EPIMKFPMMEA.pressPosition.y - EPIMKFPMMEA.position.y) / 256f;
		this.IGKPOKOIGHH = Mathf.Clamp(this.IGKPOKOIGHH, -1f, 1f);
		bool flag = false;
		if (this.IGKPOKOIGHH < 0f)
		{
			flag = true;
		}
		this.IGKPOKOIGHH = Mathf.Abs(this.IGKPOKOIGHH);
		this.IGKPOKOIGHH = Mathf.Pow(this.IGKPOKOIGHH, 0.75f) * 0.35f;
		if (flag)
		{
			this.IGKPOKOIGHH *= -1f;
		}
	}

	// Token: 0x06005EEE RID: 24302 RVA: 0x00003E52 File Offset: 0x00002052
	public void BGFNMOOECDC(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005EEF RID: 24303 RVA: 0x00003E52 File Offset: 0x00002052
	public void AGCPDKNGGPA(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005EF0 RID: 24304 RVA: 0x002B022A File Offset: 0x002AE42A
	public FACEBAPIEEL GFFIHMHIGKF()
	{
		return this.ENAPBNOFELA;
	}

	// Token: 0x06005EF1 RID: 24305 RVA: 0x002B03DC File Offset: 0x002AE5DC
	public void IJKKEFILDEN(PointerEventData EPIMKFPMMEA)
	{
		Vector3 mnobkfejnac = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		this.ENAPBNOFELA = this.CalcDragDirection(mnobkfejnac);
	}

	// Token: 0x06005EF2 RID: 24306 RVA: 0x002B0415 File Offset: 0x002AE615
	public void HDNPNBOIABE()
	{
		this.IGKPOKOIGHH = 381f;
	}

	// Token: 0x06005EF3 RID: 24307 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float LNGHOLLPJML()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005EF4 RID: 24308 RVA: 0x002B0424 File Offset: 0x002AE624
	public FACEBAPIEEL PBIKCKGJKAD(Vector3 MNOBKFEJNAC)
	{
		float num = Mathf.Abs(MNOBKFEJNAC.x);
		float num2 = Mathf.Abs(MNOBKFEJNAC.y);
		FACEBAPIEEL result;
		if (num > num2)
		{
			result = ((MNOBKFEJNAC.x > 254f) ? FACEBAPIEEL.down : ((FACEBAPIEEL)5));
		}
		else
		{
			result = ((MNOBKFEJNAC.y > 1104f) ? FACEBAPIEEL.up : FACEBAPIEEL.down);
		}
		return result;
	}

	// Token: 0x06005EF5 RID: 24309 RVA: 0x002B0472 File Offset: 0x002AE672
	public void NJCHKJGKMDJ()
	{
		this.IGKPOKOIGHH = 658f;
	}

	// Token: 0x06005EF6 RID: 24310 RVA: 0x00003E52 File Offset: 0x00002052
	public void PLJPLCMDNLI(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005EF7 RID: 24311 RVA: 0x002B0480 File Offset: 0x002AE680
	public void MBLBGJPIOMP(PointerEventData EPIMKFPMMEA)
	{
		this.IGKPOKOIGHH = (EPIMKFPMMEA.pressPosition.y - EPIMKFPMMEA.position.y) / 562f;
		this.IGKPOKOIGHH = Mathf.Clamp(this.IGKPOKOIGHH, 589f, 667f);
		bool flag = true;
		if (this.IGKPOKOIGHH < 536f)
		{
			flag = true;
		}
		this.IGKPOKOIGHH = Mathf.Abs(this.IGKPOKOIGHH);
		this.IGKPOKOIGHH = Mathf.Pow(this.IGKPOKOIGHH, 975f) * 987f;
		if (flag)
		{
			this.IGKPOKOIGHH *= 1640f;
		}
	}

	// Token: 0x06005EF8 RID: 24312 RVA: 0x002B0520 File Offset: 0x002AE720
	public FACEBAPIEEL OLPKLHCHIMO(Vector3 MNOBKFEJNAC)
	{
		float num = Mathf.Abs(MNOBKFEJNAC.x);
		float num2 = Mathf.Abs(MNOBKFEJNAC.y);
		FACEBAPIEEL result;
		if (num > num2)
		{
			result = ((MNOBKFEJNAC.x > 1998f) ? FACEBAPIEEL.right : FACEBAPIEEL.left);
		}
		else
		{
			result = ((MNOBKFEJNAC.y > 1269f) ? FACEBAPIEEL.down : FACEBAPIEEL.down);
		}
		return result;
	}

	// Token: 0x06005EF9 RID: 24313 RVA: 0x002B0570 File Offset: 0x002AE770
	public void PPMIBEIEPAM(PointerEventData EPIMKFPMMEA)
	{
		this.IGKPOKOIGHH = (EPIMKFPMMEA.pressPosition.y - EPIMKFPMMEA.position.y) / 1181f;
		this.IGKPOKOIGHH = Mathf.Clamp(this.IGKPOKOIGHH, 1180f, 695f);
		bool flag = true;
		if (this.IGKPOKOIGHH < 1027f)
		{
			flag = true;
		}
		this.IGKPOKOIGHH = Mathf.Abs(this.IGKPOKOIGHH);
		this.IGKPOKOIGHH = Mathf.Pow(this.IGKPOKOIGHH, 1679f) * 673f;
		if (flag)
		{
			this.IGKPOKOIGHH *= 30f;
		}
	}

	// Token: 0x06005EFA RID: 24314 RVA: 0x00003E52 File Offset: 0x00002052
	public void PNEDLDEIMBE(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005EFB RID: 24315 RVA: 0x002B0610 File Offset: 0x002AE810
	public void KEKFHGFKLJG(PointerEventData EPIMKFPMMEA)
	{
		this.IGKPOKOIGHH = (EPIMKFPMMEA.pressPosition.y - EPIMKFPMMEA.position.y) / 1520f;
		this.IGKPOKOIGHH = Mathf.Clamp(this.IGKPOKOIGHH, 747f, 1129f);
		bool flag = false;
		if (this.IGKPOKOIGHH < 1231f)
		{
			flag = true;
		}
		this.IGKPOKOIGHH = Mathf.Abs(this.IGKPOKOIGHH);
		this.IGKPOKOIGHH = Mathf.Pow(this.IGKPOKOIGHH, 1286f) * 1924f;
		if (flag)
		{
			this.IGKPOKOIGHH *= 930f;
		}
	}

	// Token: 0x06005EFC RID: 24316 RVA: 0x00003E52 File Offset: 0x00002052
	public void HELPCOFBIEE(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005EFD RID: 24317 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float BOOJAHDOAJM()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005EFE RID: 24318 RVA: 0x002B06AE File Offset: 0x002AE8AE
	public void GEEBOIKHHBP()
	{
		this.ENAPBNOFELA = FACEBAPIEEL.down;
	}

	// Token: 0x06005EFF RID: 24319 RVA: 0x00003E52 File Offset: 0x00002052
	private void JBCKGINANGF()
	{
	}

	// Token: 0x06005F00 RID: 24320 RVA: 0x00003E52 File Offset: 0x00002052
	public void OJPMDCHBNOC(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005F01 RID: 24321 RVA: 0x002B06B8 File Offset: 0x002AE8B8
	public FACEBAPIEEL MBEBKMNBGHE(Vector3 MNOBKFEJNAC)
	{
		float num = Mathf.Abs(MNOBKFEJNAC.x);
		float num2 = Mathf.Abs(MNOBKFEJNAC.y);
		FACEBAPIEEL result;
		if (num > num2)
		{
			result = ((MNOBKFEJNAC.x > 1033f) ? ((FACEBAPIEEL)5) : FACEBAPIEEL.down);
		}
		else
		{
			result = ((MNOBKFEJNAC.y > 92f) ? FACEBAPIEEL.down : FACEBAPIEEL.down);
		}
		return result;
	}

	// Token: 0x06005F02 RID: 24322 RVA: 0x002B0708 File Offset: 0x002AE908
	public void ICFAPKLFIFD(PointerEventData EPIMKFPMMEA)
	{
		this.IGKPOKOIGHH = (EPIMKFPMMEA.pressPosition.y - EPIMKFPMMEA.position.y) / 598f;
		this.IGKPOKOIGHH = Mathf.Clamp(this.IGKPOKOIGHH, 625f, 901f);
		bool flag = true;
		if (this.IGKPOKOIGHH < 1454f)
		{
			flag = true;
		}
		this.IGKPOKOIGHH = Mathf.Abs(this.IGKPOKOIGHH);
		this.IGKPOKOIGHH = Mathf.Pow(this.IGKPOKOIGHH, 917f) * 833f;
		if (flag)
		{
			this.IGKPOKOIGHH *= 1331f;
		}
	}

	// Token: 0x06005F03 RID: 24323 RVA: 0x002B07A6 File Offset: 0x002AE9A6
	public void OACMMLFLPBO()
	{
		this.IGKPOKOIGHH = 334f;
	}

	// Token: 0x06005F04 RID: 24324 RVA: 0x002B07B4 File Offset: 0x002AE9B4
	public FACEBAPIEEL DLJNFNBIHHB(Vector3 MNOBKFEJNAC)
	{
		float num = Mathf.Abs(MNOBKFEJNAC.x);
		float num2 = Mathf.Abs(MNOBKFEJNAC.y);
		FACEBAPIEEL result;
		if (num > num2)
		{
			result = ((MNOBKFEJNAC.x > 462f) ? ((FACEBAPIEEL)7) : ((FACEBAPIEEL)6));
		}
		else
		{
			result = ((MNOBKFEJNAC.y > 451f) ? FACEBAPIEEL.down : FACEBAPIEEL.up);
		}
		return result;
	}

	// Token: 0x06005F05 RID: 24325 RVA: 0x002B0802 File Offset: 0x002AEA02
	public void IHLCGKDPAAE()
	{
		this.ENAPBNOFELA = FACEBAPIEEL.up;
	}

	// Token: 0x06005F06 RID: 24326 RVA: 0x002B080B File Offset: 0x002AEA0B
	public void OIMDFMIOKAI()
	{
		this.IGKPOKOIGHH = 516f;
	}

	// Token: 0x06005F08 RID: 24328 RVA: 0x002B022A File Offset: 0x002AE42A
	public FACEBAPIEEL DFALPJFIAJP()
	{
		return this.ENAPBNOFELA;
	}

	// Token: 0x06005F09 RID: 24329 RVA: 0x002B0828 File Offset: 0x002AEA28
	public FACEBAPIEEL FAHBGMCABKP(Vector3 MNOBKFEJNAC)
	{
		float num = Mathf.Abs(MNOBKFEJNAC.x);
		float num2 = Mathf.Abs(MNOBKFEJNAC.y);
		FACEBAPIEEL result;
		if (num > num2)
		{
			result = ((MNOBKFEJNAC.x > 1215f) ? FACEBAPIEEL.none : FACEBAPIEEL.right);
		}
		else
		{
			result = ((MNOBKFEJNAC.y > 601f) ? FACEBAPIEEL.down : FACEBAPIEEL.up);
		}
		return result;
	}

	// Token: 0x06005F0A RID: 24330 RVA: 0x002B0878 File Offset: 0x002AEA78
	public FACEBAPIEEL CalcDragDirection(Vector3 MNOBKFEJNAC)
	{
		float num = Mathf.Abs(MNOBKFEJNAC.x);
		float num2 = Mathf.Abs(MNOBKFEJNAC.y);
		FACEBAPIEEL result;
		if (num > num2)
		{
			result = ((MNOBKFEJNAC.x > 0f) ? FACEBAPIEEL.right : FACEBAPIEEL.left);
		}
		else
		{
			result = ((MNOBKFEJNAC.y > 0f) ? FACEBAPIEEL.up : FACEBAPIEEL.down);
		}
		return result;
	}

	// Token: 0x06005F0B RID: 24331 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float JBJLJJMKFLH()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005F0C RID: 24332 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float AEEPILEHMFO()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005F0D RID: 24333 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float EHJPOHPHOLO()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005F0E RID: 24334 RVA: 0x002B08C8 File Offset: 0x002AEAC8
	public void JHEFOIFOLIJ(PointerEventData EPIMKFPMMEA)
	{
		Vector3 mnobkfejnac = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		this.ENAPBNOFELA = this.CBMLFMJPBNO(mnobkfejnac);
	}

	// Token: 0x06005F0F RID: 24335 RVA: 0x002B0901 File Offset: 0x002AEB01
	public void IGFGHADKOIG(PointerEventData EPIMKFPMMEA)
	{
		this.IGKPOKOIGHH = 441f;
	}

	// Token: 0x06005F10 RID: 24336 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnPointerUp(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005F11 RID: 24337 RVA: 0x00003E52 File Offset: 0x00002052
	public void LDBPHIOFNFI(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005F12 RID: 24338 RVA: 0x002B090E File Offset: 0x002AEB0E
	public void NAAHELHACIL()
	{
		this.IGKPOKOIGHH = 668f;
	}

	// Token: 0x06005F13 RID: 24339 RVA: 0x002B0802 File Offset: 0x002AEA02
	public void EDMNGJBONBJ()
	{
		this.ENAPBNOFELA = FACEBAPIEEL.up;
	}

	// Token: 0x06005F14 RID: 24340 RVA: 0x002B022A File Offset: 0x002AE42A
	public FACEBAPIEEL KCEPMADOMHH()
	{
		return this.ENAPBNOFELA;
	}

	// Token: 0x06005F15 RID: 24341 RVA: 0x002B022A File Offset: 0x002AE42A
	public FACEBAPIEEL KMOABLFJBJE()
	{
		return this.ENAPBNOFELA;
	}

	// Token: 0x06005F16 RID: 24342 RVA: 0x002B091C File Offset: 0x002AEB1C
	public FACEBAPIEEL HANLJOCHHJM(Vector3 MNOBKFEJNAC)
	{
		float num = Mathf.Abs(MNOBKFEJNAC.x);
		float num2 = Mathf.Abs(MNOBKFEJNAC.y);
		FACEBAPIEEL result;
		if (num > num2)
		{
			result = ((MNOBKFEJNAC.x > 293f) ? ((FACEBAPIEEL)6) : FACEBAPIEEL.none);
		}
		else
		{
			result = ((MNOBKFEJNAC.y > 1467f) ? FACEBAPIEEL.down : FACEBAPIEEL.down);
		}
		return result;
	}

	// Token: 0x06005F17 RID: 24343 RVA: 0x002B096A File Offset: 0x002AEB6A
	public void BIFPBLPHNGK()
	{
		this.IGKPOKOIGHH = 78f;
	}

	// Token: 0x06005F18 RID: 24344 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float JPKMCCKCHJL()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005F19 RID: 24345 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float JIINKCGEOEE()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005F1A RID: 24346 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float GPBGCEHHPIJ()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x06005F1B RID: 24347 RVA: 0x00003E52 File Offset: 0x00002052
	public void OnPointerDown(PointerEventData EPIMKFPMMEA)
	{
	}

	// Token: 0x06005F1C RID: 24348 RVA: 0x002B0978 File Offset: 0x002AEB78
	public FACEBAPIEEL NFACNGALLOI(Vector3 MNOBKFEJNAC)
	{
		float num = Mathf.Abs(MNOBKFEJNAC.x);
		float num2 = Mathf.Abs(MNOBKFEJNAC.y);
		FACEBAPIEEL result;
		if (num > num2)
		{
			result = ((MNOBKFEJNAC.x > 1055f) ? FACEBAPIEEL.none : FACEBAPIEEL.up);
		}
		else
		{
			result = ((MNOBKFEJNAC.y > 1551f) ? FACEBAPIEEL.down : FACEBAPIEEL.up);
		}
		return result;
	}

	// Token: 0x06005F1D RID: 24349 RVA: 0x002B09C8 File Offset: 0x002AEBC8
	public void MNGNIJECPKP(PointerEventData EPIMKFPMMEA)
	{
		Vector3 mnobkfejnac = (EPIMKFPMMEA.position - EPIMKFPMMEA.pressPosition).normalized;
		this.ENAPBNOFELA = this.CBMLFMJPBNO(mnobkfejnac);
	}

	// Token: 0x06005F1E RID: 24350 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x06005F1F RID: 24351 RVA: 0x002AFF4F File Offset: 0x002AE14F
	public float IFPHAHKILNN()
	{
		return this.IGKPOKOIGHH;
	}

	// Token: 0x04001B1A RID: 6938
	private FACEBAPIEEL ENAPBNOFELA = FACEBAPIEEL.none;

	// Token: 0x04001B1B RID: 6939
	private float IGKPOKOIGHH;

	// Token: 0x04001B1C RID: 6940
	private const float JLJAAFGCGML = 256f;

	// Token: 0x04001B1D RID: 6941
	private const float JJNFMCMNEKN = 0.75f;

	// Token: 0x04001B1E RID: 6942
	private const float FCDJBFMBHFM = 0.35f;
}
