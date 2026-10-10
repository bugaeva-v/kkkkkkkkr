using System;
using System.Globalization;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Purchasing;

// Token: 0x02000097 RID: 151
public class NIIJIJNFIIA
{
	// Token: 0x0600156F RID: 5487 RVA: 0x000A5E68 File Offset: 0x000A4068
	public string HCPDJKHJBLK()
	{
		try
		{
			if (null != this.EGEODKDPGDF && this.EGEODKDPGDF["onAppOpenAttribution"]["chapterrewindhint1"] != null)
			{
				return this.EGEODKDPGDF["anpcs"]["anthology"];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		if (this.NJBCLIILMOF != null)
		{
			return this.NJBCLIILMOF.Info.TransactionID;
		}
		if (this.GAAFNHPBBOB != null)
		{
			return this.GAAFNHPBBOB.BAOPJDNMEAC;
		}
		return this.DIDOFCNINNI.BAOPJDNMEAC;
	}

	// Token: 0x06001570 RID: 5488 RVA: 0x000A5F1C File Offset: 0x000A411C
	public PendingOrder DAJNEGNAAHM()
	{
		return this.OGEPANOGJOA;
	}

	// Token: 0x06001571 RID: 5489 RVA: 0x000A5F24 File Offset: 0x000A4124
	public string KIJGJGBKONC()
	{
		if (this.NJBCLIILMOF != null)
		{
			return this.NJBCLIILMOF.Info.TransactionID;
		}
		if (this.GAAFNHPBBOB != null)
		{
			return this.GAAFNHPBBOB.BAOPJDNMEAC;
		}
		return this.DIDOFCNINNI.BAOPJDNMEAC;
	}

	// Token: 0x06001572 RID: 5490 RVA: 0x000A5F5E File Offset: 0x000A415E
	public GGAHKHBFKDA OCHOGBDCBIJ()
	{
		return this.DIDOFCNINNI;
	}

	// Token: 0x06001573 RID: 5491 RVA: 0x000A5F66 File Offset: 0x000A4166
	public void NLPANLMJLEG(GGAHKHBFKDA FCHIANFOCGE)
	{
		this.DIDOFCNINNI = FCHIANFOCGE;
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x000A5F70 File Offset: 0x000A4170
	public string POCNGEMCHME()
	{
		if (this.NJBCLIILMOF != null)
		{
			if (!string.IsNullOrEmpty(this.NJBCLIILMOF.Info.Receipt))
			{
				return this.NJBCLIILMOF.Info.Receipt;
			}
			Debug.LogError("energyhinttitle");
			return " ";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.FMMJONLGNAK().ToString();
			}
			return this.DIDOFCNINNI.KOKGBJDCFOI().ToString();
		}
	}

	// Token: 0x06001575 RID: 5493 RVA: 0x000A5F24 File Offset: 0x000A4124
	public string EJHHLGDKMMF()
	{
		if (this.NJBCLIILMOF != null)
		{
			return this.NJBCLIILMOF.Info.TransactionID;
		}
		if (this.GAAFNHPBBOB != null)
		{
			return this.GAAFNHPBBOB.BAOPJDNMEAC;
		}
		return this.DIDOFCNINNI.BAOPJDNMEAC;
	}

	// Token: 0x06001576 RID: 5494 RVA: 0x000A5FE8 File Offset: 0x000A41E8
	public string NLAFMINLGGP()
	{
		if (this.NJBCLIILMOF != null)
		{
			Product product = ABLEFBBIBNB.ECAJAEBFDJB(this.NJBCLIILMOF);
			if (product != null)
			{
				return product.definition.id;
			}
			return "";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.DLCPOJGJFDG;
			}
			return this.DIDOFCNINNI.JIEBEFKGJIM.DEJCCBNPFEC;
		}
	}

	// Token: 0x06001577 RID: 5495 RVA: 0x000A6044 File Offset: 0x000A4244
	public string KEPKKEOFEJA()
	{
		if (this.NJBCLIILMOF != null)
		{
			Product product = ABLEFBBIBNB.ECAJAEBFDJB(this.NJBCLIILMOF);
			if (product != null)
			{
				return product.metadata.isoCurrencyCode;
			}
			return "ok";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.AMGPFOKINPI;
			}
			return "sp0";
		}
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x000A6094 File Offset: 0x000A4294
	public string AGAGIJCFIKK()
	{
		if (this.NJBCLIILMOF != null)
		{
			Product product = ABLEFBBIBNB.ECAJAEBFDJB(this.NJBCLIILMOF);
			if (product != null)
			{
				return product.definition.storeSpecificId;
			}
			return "";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.DDNOAOGEPIF;
			}
			return this.DIDOFCNINNI.JIEBEFKGJIM.DEJCCBNPFEC;
		}
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x000A60EE File Offset: 0x000A42EE
	public void JIAOKCAPDAF(PendingOrder FODKOPMKCBK, Order OILKKJGIKEA)
	{
		this.OGEPANOGJOA = FODKOPMKCBK;
		this.NJBCLIILMOF = OILKKJGIKEA;
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x000A6100 File Offset: 0x000A4300
	public string NOJAEDJDJAP()
	{
		if (this.NJBCLIILMOF != null)
		{
			Product product = ABLEFBBIBNB.ECAJAEBFDJB(this.NJBCLIILMOF);
			if (product != null)
			{
				return product.metadata.isoCurrencyCode;
			}
			return "USD";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.AMGPFOKINPI;
			}
			return "USD";
		}
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x000A6150 File Offset: 0x000A4350
	public string CDHKEPGJLMB()
	{
		if (this.NJBCLIILMOF != null)
		{
			if (!string.IsNullOrEmpty(this.NJBCLIILMOF.Info.Receipt))
			{
				return this.NJBCLIILMOF.Info.Receipt;
			}
			Debug.LogError("PendingPurchase.GetReceipt(): Receipt is null or empty");
			return "";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.CDHKEPGJLMB().ToString();
			}
			return this.DIDOFCNINNI.CDHKEPGJLMB().ToString();
		}
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x000A61C8 File Offset: 0x000A43C8
	public string HAHAGOKHAJG()
	{
		if (this.NJBCLIILMOF != null)
		{
			Product product = ABLEFBBIBNB.ECAJAEBFDJB(this.NJBCLIILMOF);
			if (product != null)
			{
				return product.definition.storeSpecificId;
			}
			return "energyhinttitle";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.DDNOAOGEPIF;
			}
			return this.DIDOFCNINNI.JIEBEFKGJIM.DEJCCBNPFEC;
		}
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x000A6222 File Offset: 0x000A4422
	public void OPNMJONPMHA(INBFGLCMEBN PJCAPDFEAFD)
	{
		this.GAAFNHPBBOB = PJCAPDFEAFD;
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x000A622C File Offset: 0x000A442C
	public string JBNDHJBNCNK()
	{
		if (this.NJBCLIILMOF != null)
		{
			Product product = ABLEFBBIBNB.ECAJAEBFDJB(this.NJBCLIILMOF);
			if (product != null)
			{
				return product.metadata.localizedPrice.ToString(CultureInfo.InvariantCulture);
			}
			return "";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.EPEDJKGMIAA;
			}
			return this.DIDOFCNINNI.JIEBEFKGJIM.DMODNDCLGEJ;
		}
	}

	// Token: 0x0600157F RID: 5503 RVA: 0x000A6294 File Offset: 0x000A4494
	public string BANNONOLDCP()
	{
		if (this.NJBCLIILMOF != null)
		{
			Product product = ABLEFBBIBNB.ECAJAEBFDJB(this.NJBCLIILMOF);
			if (product != null)
			{
				return product.definition.storeSpecificId;
			}
			return "";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.DDNOAOGEPIF;
			}
			return this.DIDOFCNINNI.JIEBEFKGJIM.DEJCCBNPFEC;
		}
	}

	// Token: 0x06001580 RID: 5504 RVA: 0x000A62F0 File Offset: 0x000A44F0
	public string BJIAMMDNLLP()
	{
		if (this.NJBCLIILMOF != null)
		{
			Product product = ABLEFBBIBNB.ECAJAEBFDJB(this.NJBCLIILMOF);
			if (product != null)
			{
				return product.metadata.localizedPrice.ToString(CultureInfo.InvariantCulture);
			}
			return " holding [";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.EPEDJKGMIAA;
			}
			return this.DIDOFCNINNI.JIEBEFKGJIM.DMODNDCLGEJ;
		}
	}

	// Token: 0x06001581 RID: 5505 RVA: 0x000A6358 File Offset: 0x000A4558
	public string ACMFCCCBBKL()
	{
		if (this.NJBCLIILMOF != null)
		{
			if (!string.IsNullOrEmpty(this.NJBCLIILMOF.Info.Receipt))
			{
				return this.NJBCLIILMOF.Info.Receipt;
			}
			Debug.LogError("black");
			return ")";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.CDHKEPGJLMB().ToString();
			}
			return this.DIDOFCNINNI.CBBHIFLLGJE().ToString();
		}
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x000A63CE File Offset: 0x000A45CE
	public INBFGLCMEBN IKBNBFECCOG()
	{
		return this.GAAFNHPBBOB;
	}

	// Token: 0x06001583 RID: 5507 RVA: 0x000A5F1C File Offset: 0x000A411C
	public PendingOrder ODBJLMOLJIE()
	{
		return this.OGEPANOGJOA;
	}

	// Token: 0x06001584 RID: 5508 RVA: 0x000A60EE File Offset: 0x000A42EE
	public void HEAIDLCDNMF(PendingOrder FODKOPMKCBK, Order OILKKJGIKEA)
	{
		this.OGEPANOGJOA = FODKOPMKCBK;
		this.NJBCLIILMOF = OILKKJGIKEA;
	}

	// Token: 0x06001585 RID: 5509 RVA: 0x000A5F24 File Offset: 0x000A4124
	public string CDIHDNKKLCE()
	{
		if (this.NJBCLIILMOF != null)
		{
			return this.NJBCLIILMOF.Info.TransactionID;
		}
		if (this.GAAFNHPBBOB != null)
		{
			return this.GAAFNHPBBOB.BAOPJDNMEAC;
		}
		return this.DIDOFCNINNI.BAOPJDNMEAC;
	}

	// Token: 0x06001586 RID: 5510 RVA: 0x000A63CE File Offset: 0x000A45CE
	public INBFGLCMEBN JGHLLEHJJLG()
	{
		return this.GAAFNHPBBOB;
	}

	// Token: 0x06001587 RID: 5511 RVA: 0x000A5F24 File Offset: 0x000A4124
	public string MFBNOLFOCCL()
	{
		if (this.NJBCLIILMOF != null)
		{
			return this.NJBCLIILMOF.Info.TransactionID;
		}
		if (this.GAAFNHPBBOB != null)
		{
			return this.GAAFNHPBBOB.BAOPJDNMEAC;
		}
		return this.DIDOFCNINNI.BAOPJDNMEAC;
	}

	// Token: 0x06001588 RID: 5512 RVA: 0x000A5F66 File Offset: 0x000A4166
	public void PDKENAHOGPJ(GGAHKHBFKDA FCHIANFOCGE)
	{
		this.DIDOFCNINNI = FCHIANFOCGE;
	}

	// Token: 0x06001589 RID: 5513 RVA: 0x000A5F24 File Offset: 0x000A4124
	public string MDGKLOAPLHI()
	{
		if (this.NJBCLIILMOF != null)
		{
			return this.NJBCLIILMOF.Info.TransactionID;
		}
		if (this.GAAFNHPBBOB != null)
		{
			return this.GAAFNHPBBOB.BAOPJDNMEAC;
		}
		return this.DIDOFCNINNI.BAOPJDNMEAC;
	}

	// Token: 0x0600158A RID: 5514 RVA: 0x000A5F5E File Offset: 0x000A415E
	public GGAHKHBFKDA JMGGEIADBDO()
	{
		return this.DIDOFCNINNI;
	}

	// Token: 0x0600158B RID: 5515 RVA: 0x000A63D8 File Offset: 0x000A45D8
	public string EFMAOLLKGEI()
	{
		try
		{
			if (null != this.EGEODKDPGDF && this.EGEODKDPGDF["p"]["order"] != null)
			{
				return this.EGEODKDPGDF["p"]["order"];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.NJBCLIILMOF != null)
		{
			return this.NJBCLIILMOF.Info.TransactionID;
		}
		if (this.GAAFNHPBBOB != null)
		{
			return this.GAAFNHPBBOB.BAOPJDNMEAC;
		}
		return this.DIDOFCNINNI.BAOPJDNMEAC;
	}

	// Token: 0x0600158C RID: 5516 RVA: 0x000A5F66 File Offset: 0x000A4166
	public void GJFPCBGNAKF(GGAHKHBFKDA FCHIANFOCGE)
	{
		this.DIDOFCNINNI = FCHIANFOCGE;
	}

	// Token: 0x0600158D RID: 5517 RVA: 0x000A6222 File Offset: 0x000A4422
	public void DIFLENNOMPF(INBFGLCMEBN PJCAPDFEAFD)
	{
		this.GAAFNHPBBOB = PJCAPDFEAFD;
	}

	// Token: 0x0600158E RID: 5518 RVA: 0x000A60EE File Offset: 0x000A42EE
	public void DKCDILFHPOG(PendingOrder FODKOPMKCBK, Order OILKKJGIKEA)
	{
		this.OGEPANOGJOA = FODKOPMKCBK;
		this.NJBCLIILMOF = OILKKJGIKEA;
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x000A5F5E File Offset: 0x000A415E
	public GGAHKHBFKDA KDJILGELJCN()
	{
		return this.DIDOFCNINNI;
	}

	// Token: 0x06001590 RID: 5520 RVA: 0x000A60EE File Offset: 0x000A42EE
	public void DJDCBDEAPCO(PendingOrder FODKOPMKCBK, Order OILKKJGIKEA)
	{
		this.OGEPANOGJOA = FODKOPMKCBK;
		this.NJBCLIILMOF = OILKKJGIKEA;
	}

	// Token: 0x06001591 RID: 5521 RVA: 0x000A5F66 File Offset: 0x000A4166
	public void DNGGPPEKFII(GGAHKHBFKDA FCHIANFOCGE)
	{
		this.DIDOFCNINNI = FCHIANFOCGE;
	}

	// Token: 0x06001592 RID: 5522 RVA: 0x000A6222 File Offset: 0x000A4422
	public void HCABKLCPFFH(INBFGLCMEBN PJCAPDFEAFD)
	{
		this.GAAFNHPBBOB = PJCAPDFEAFD;
	}

	// Token: 0x06001593 RID: 5523 RVA: 0x000A648C File Offset: 0x000A468C
	public string COAPEGGPKCO()
	{
		if (this.NJBCLIILMOF != null)
		{
			Product product = ABLEFBBIBNB.ECAJAEBFDJB(this.NJBCLIILMOF);
			if (product != null)
			{
				return product.metadata.localizedPrice.ToString(CultureInfo.InvariantCulture);
			}
			return "yes";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.EPEDJKGMIAA;
			}
			return this.DIDOFCNINNI.JIEBEFKGJIM.DMODNDCLGEJ;
		}
	}

	// Token: 0x06001594 RID: 5524 RVA: 0x000A64F3 File Offset: 0x000A46F3
	public NIIJIJNFIIA()
	{
		this.KMDENBLAEJO = EBPDOCELHBN.Idle;
		this.OGEPANOGJOA = null;
		this.NJBCLIILMOF = null;
		this.DIDOFCNINNI = null;
		this.GAAFNHPBBOB = null;
	}

	// Token: 0x06001595 RID: 5525 RVA: 0x000A63CE File Offset: 0x000A45CE
	public INBFGLCMEBN KAEOPFBNMIG()
	{
		return this.GAAFNHPBBOB;
	}

	// Token: 0x06001596 RID: 5526 RVA: 0x000A6520 File Offset: 0x000A4720
	public string IAMBKEEHNJI()
	{
		if (this.NJBCLIILMOF != null)
		{
			Product product = ABLEFBBIBNB.ECAJAEBFDJB(this.NJBCLIILMOF);
			if (product != null)
			{
				return product.metadata.isoCurrencyCode;
			}
			return "";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.AMGPFOKINPI;
			}
			return "liveeventcontent";
		}
	}

	// Token: 0x06001597 RID: 5527 RVA: 0x000A5F66 File Offset: 0x000A4166
	public void GECNIOPFGDL(GGAHKHBFKDA FCHIANFOCGE)
	{
		this.DIDOFCNINNI = FCHIANFOCGE;
	}

	// Token: 0x06001598 RID: 5528 RVA: 0x000A5F1C File Offset: 0x000A411C
	public PendingOrder CLMIKDHEABK()
	{
		return this.OGEPANOGJOA;
	}

	// Token: 0x06001599 RID: 5529 RVA: 0x000A6570 File Offset: 0x000A4770
	public string NGJPKHIPDDG()
	{
		try
		{
			if (null != this.EGEODKDPGDF && this.EGEODKDPGDF["/"]["string_not_found"] != null)
			{
				return this.EGEODKDPGDF["smps"]["priceCurrencyCode"];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.NJBCLIILMOF != null)
		{
			return this.NJBCLIILMOF.Info.TransactionID;
		}
		if (this.GAAFNHPBBOB != null)
		{
			return this.GAAFNHPBBOB.BAOPJDNMEAC;
		}
		return this.DIDOFCNINNI.BAOPJDNMEAC;
	}

	// Token: 0x0600159A RID: 5530 RVA: 0x000A6624 File Offset: 0x000A4824
	public string PMLONKDDIFC()
	{
		try
		{
			if (null != this.EGEODKDPGDF && this.EGEODKDPGDF[""]["p"] != null)
			{
				return this.EGEODKDPGDF["$e1es"][", anthologies "];
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		if (this.NJBCLIILMOF != null)
		{
			return this.NJBCLIILMOF.Info.TransactionID;
		}
		if (this.GAAFNHPBBOB != null)
		{
			return this.GAAFNHPBBOB.BAOPJDNMEAC;
		}
		return this.DIDOFCNINNI.BAOPJDNMEAC;
	}

	// Token: 0x0600159B RID: 5531 RVA: 0x000A66D8 File Offset: 0x000A48D8
	public string OCMLGHDLECP()
	{
		if (this.NJBCLIILMOF != null)
		{
			Product product = ABLEFBBIBNB.ECAJAEBFDJB(this.NJBCLIILMOF);
			if (product != null)
			{
				return product.definition.storeSpecificId;
			}
			return "sponsortitle";
		}
		else
		{
			if (this.GAAFNHPBBOB != null)
			{
				return this.GAAFNHPBBOB.DDNOAOGEPIF;
			}
			return this.DIDOFCNINNI.JIEBEFKGJIM.DEJCCBNPFEC;
		}
	}

	// Token: 0x0600159C RID: 5532 RVA: 0x000A6222 File Offset: 0x000A4422
	public void HICKMLEHFIH(INBFGLCMEBN PJCAPDFEAFD)
	{
		this.GAAFNHPBBOB = PJCAPDFEAFD;
	}

	// Token: 0x040006A9 RID: 1705
	public JSONObject EGEODKDPGDF;

	// Token: 0x040006AA RID: 1706
	public EBPDOCELHBN KMDENBLAEJO;

	// Token: 0x040006AB RID: 1707
	private PendingOrder OGEPANOGJOA;

	// Token: 0x040006AC RID: 1708
	private Order NJBCLIILMOF;

	// Token: 0x040006AD RID: 1709
	private GGAHKHBFKDA DIDOFCNINNI;

	// Token: 0x040006AE RID: 1710
	private INBFGLCMEBN GAAFNHPBBOB;
}
