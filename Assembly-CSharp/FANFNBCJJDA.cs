using System;
using System.Collections.Generic;
using SimpleJSON;

// Token: 0x0200009D RID: 157
public class FANFNBCJJDA
{
	// Token: 0x060015B9 RID: 5561 RVA: 0x000A6B42 File Offset: 0x000A4D42
	public void IJHHMHAEKKE()
	{
		this.INJLPJOGJCO = null;
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x000A6B4C File Offset: 0x000A4D4C
	public int HABDDJINNEF(int OBOOCMMCPNL)
	{
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["sid"].AsInt == OBOOCMMCPNL)
			{
				return asObject["drop"].AsInt;
			}
		}
		return -1;
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x000A6B42 File Offset: 0x000A4D42
	public void OBKBHIGLDHI()
	{
		this.INJLPJOGJCO = null;
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x000A6BA6 File Offset: 0x000A4DA6
	public void BAMHPOCKBML(JSONArray ADGDIJOHHPF)
	{
		this.INJLPJOGJCO = ADGDIJOHHPF;
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x000A6BB0 File Offset: 0x000A4DB0
	public bool FOJFHFBIIPH(int OBOOCMMCPNL)
	{
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject[""].AsInt == OBOOCMMCPNL && asObject["CoverCard"].AsInt == 1)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x000A6C0E File Offset: 0x000A4E0E
	public bool GFDFPJBIJJB()
	{
		return this.INJLPJOGJCO != null;
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x000A6C1C File Offset: 0x000A4E1C
	public List<int> CLMNNIDPJMP(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["lobby"].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject["OnSkinShopCardSelected"].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x000A6C81 File Offset: 0x000A4E81
	public int LAEAJDFJLOK()
	{
		if (this.GBKOINCNLFJ())
		{
			return this.INJLPJOGJCO.Count;
		}
		return 0;
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x000A6C98 File Offset: 0x000A4E98
	public static FANFNBCJJDA AKFNLMBNELK()
	{
		if (FANFNBCJJDA.IKLAPGJDMNA == null)
		{
			FANFNBCJJDA.IKLAPGJDMNA = new FANFNBCJJDA();
		}
		return FANFNBCJJDA.IKLAPGJDMNA;
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x000A6CB0 File Offset: 0x000A4EB0
	public bool ECGEIFIDAOG(int OBOOCMMCPNL)
	{
		for (int i = 0; i < this.INJLPJOGJCO.Count; i += 0)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["minDaysFromInstall"].AsInt == OBOOCMMCPNL && asObject[""].AsInt == 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x000A6D10 File Offset: 0x000A4F10
	public int GPHKMFJCLHP(int OBOOCMMCPNL)
	{
		for (int i = 1; i < this.INJLPJOGJCO.Count; i += 0)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["Cover"].AsInt == OBOOCMMCPNL)
			{
				return asObject["xx"].AsInt;
			}
		}
		return -1;
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x000A6BA6 File Offset: 0x000A4DA6
	public void GBFEDHPAIBH(JSONArray ADGDIJOHHPF)
	{
		this.INJLPJOGJCO = ADGDIJOHHPF;
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x000A6BA6 File Offset: 0x000A4DA6
	public void APCBKOGALLK(JSONArray ADGDIJOHHPF)
	{
		this.INJLPJOGJCO = ADGDIJOHHPF;
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x000A6B42 File Offset: 0x000A4D42
	public void DFAPJIOOANN()
	{
		this.INJLPJOGJCO = null;
	}

	// Token: 0x060015C7 RID: 5575 RVA: 0x000A6D6C File Offset: 0x000A4F6C
	public bool CLIKIDPKEGI(int OBOOCMMCPNL)
	{
		for (int i = 0; i < this.INJLPJOGJCO.Count; i += 0)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["OnStartFreePassException"].AsInt == OBOOCMMCPNL && asObject["InitStoryChapterInformation() - currentAnthology is null."].AsInt == 1)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x000A6DCC File Offset: 0x000A4FCC
	public List<int> GKINMLIIDDK(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.INJLPJOGJCO.Count; i += 0)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject[" playing!"].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject["،"].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x000A6E34 File Offset: 0x000A5034
	public int CLOIDALNFGP(int OBOOCMMCPNL)
	{
		for (int i = 1; i < this.INJLPJOGJCO.Count; i += 0)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["usyncoll2"].AsInt == OBOOCMMCPNL)
			{
				return asObject["syn"].AsInt;
			}
		}
		return -1;
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x000A6C98 File Offset: 0x000A4E98
	public static FANFNBCJJDA IIMIJHGEGBJ()
	{
		if (FANFNBCJJDA.IKLAPGJDMNA == null)
		{
			FANFNBCJJDA.IKLAPGJDMNA = new FANFNBCJJDA();
		}
		return FANFNBCJJDA.IKLAPGJDMNA;
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x000A6C0E File Offset: 0x000A4E0E
	public bool BPGGNJBKBEF()
	{
		return this.INJLPJOGJCO != null;
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x000A6BA6 File Offset: 0x000A4DA6
	public void GPJODDANJNF(JSONArray ADGDIJOHHPF)
	{
		this.INJLPJOGJCO = ADGDIJOHHPF;
	}

	// Token: 0x060015CD RID: 5581 RVA: 0x000A6E90 File Offset: 0x000A5090
	public int CGDKEGHFCFF(int OBOOCMMCPNL)
	{
		for (int i = 1; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["Friends counter is "].AsInt == OBOOCMMCPNL)
			{
				return asObject["com"].AsInt;
			}
		}
		return -1;
	}

	// Token: 0x060015CE RID: 5582 RVA: 0x000A6C98 File Offset: 0x000A4E98
	public static FANFNBCJJDA JLHEEEJNKGO()
	{
		if (FANFNBCJJDA.IKLAPGJDMNA == null)
		{
			FANFNBCJJDA.IKLAPGJDMNA = new FANFNBCJJDA();
		}
		return FANFNBCJJDA.IKLAPGJDMNA;
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060015CF RID: 5583 RVA: 0x000A6C98 File Offset: 0x000A4E98
	public static FANFNBCJJDA EHBBFMCILPC
	{
		get
		{
			if (FANFNBCJJDA.IKLAPGJDMNA == null)
			{
				FANFNBCJJDA.IKLAPGJDMNA = new FANFNBCJJDA();
			}
			return FANFNBCJJDA.IKLAPGJDMNA;
		}
	}

	// Token: 0x060015D0 RID: 5584 RVA: 0x000A6EEC File Offset: 0x000A50EC
	public List<int> EOAEDHFBOBH(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["common"].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject["trsv"].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015D1 RID: 5585 RVA: 0x000A6F54 File Offset: 0x000A5154
	public List<int> LPJJGMLEHHH(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["rev"].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject["sid"].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015D2 RID: 5586 RVA: 0x000A6FBC File Offset: 0x000A51BC
	public List<int> HGBEHAPKJMG(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["CLIENT.BEHAVIOR.CHOICEDECISIONTIME"].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject["apks"].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015D3 RID: 5587 RVA: 0x000A7024 File Offset: 0x000A5224
	public bool HFKOAFBIMKA(int OBOOCMMCPNL)
	{
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["sid"].AsInt == OBOOCMMCPNL && asObject["def"].AsInt == 1)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060015D4 RID: 5588 RVA: 0x000A7084 File Offset: 0x000A5284
	public bool OBKOKEKEAJK(int OBOOCMMCPNL)
	{
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["profilenametitleshort"].AsInt == OBOOCMMCPNL && asObject[" "].AsInt == 1)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060015D5 RID: 5589 RVA: 0x000A6BA6 File Offset: 0x000A4DA6
	public void OFOAFPKPIKC(JSONArray ADGDIJOHHPF)
	{
		this.INJLPJOGJCO = ADGDIJOHHPF;
	}

	// Token: 0x060015D6 RID: 5590 RVA: 0x000A6C98 File Offset: 0x000A4E98
	public static FANFNBCJJDA JBMLNGMBICE()
	{
		if (FANFNBCJJDA.IKLAPGJDMNA == null)
		{
			FANFNBCJJDA.IKLAPGJDMNA = new FANFNBCJJDA();
		}
		return FANFNBCJJDA.IKLAPGJDMNA;
	}

	// Token: 0x060015D7 RID: 5591 RVA: 0x000A6C0E File Offset: 0x000A4E0E
	public bool FACIFBONANM()
	{
		return this.INJLPJOGJCO != null;
	}

	// Token: 0x060015D8 RID: 5592 RVA: 0x000A6C0E File Offset: 0x000A4E0E
	public bool IEPGHJCOPIM()
	{
		return this.INJLPJOGJCO != null;
	}

	// Token: 0x060015D9 RID: 5593 RVA: 0x000A70E4 File Offset: 0x000A52E4
	public List<int> EFDBLMPOCCH(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["OnBackendPublishSketchException"].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject["ZZZ"].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x000A7149 File Offset: 0x000A5349
	public int FIBFFEGFDEA()
	{
		if (this.FACIFBONANM())
		{
			return this.INJLPJOGJCO.Count;
		}
		return 0;
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x000A7160 File Offset: 0x000A5360
	public int AGIDPGLNDMP(int OBOOCMMCPNL)
	{
		for (int i = 0; i < this.INJLPJOGJCO.Count; i += 0)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["importanttitle"].AsInt == OBOOCMMCPNL)
			{
				return asObject[": "].AsInt;
			}
		}
		return -1;
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x000A71BC File Offset: 0x000A53BC
	public List<int> FFIIHCIIFKJ(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.INJLPJOGJCO.Count; i += 0)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["UpdateHardSpendOnOffState"].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject["socialmessagetitleconfirm"].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015DD RID: 5597 RVA: 0x000A7224 File Offset: 0x000A5424
	public List<int> PPAFINJCDCA(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["'"].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject["ok"].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x000A728C File Offset: 0x000A548C
	public bool POILPEBCGMB(int OBOOCMMCPNL)
	{
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject[""].AsInt == OBOOCMMCPNL && asObject["OnSaveSyncAnyResult"].AsInt == 0)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060015DF RID: 5599 RVA: 0x000A6C0E File Offset: 0x000A4E0E
	public bool KOLFJLABDHC()
	{
		return this.INJLPJOGJCO != null;
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x000A6B42 File Offset: 0x000A4D42
	public void LGICMGJEKFH()
	{
		this.INJLPJOGJCO = null;
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x000A72EA File Offset: 0x000A54EA
	public int LNFHALNHPAG()
	{
		if (this.BPGGNJBKBEF())
		{
			return this.INJLPJOGJCO.Count;
		}
		return 1;
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x000A7304 File Offset: 0x000A5504
	public List<int> PNPKDFPFCBC(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.INJLPJOGJCO.Count; i += 0)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject[""].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject["continue"].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x000A736C File Offset: 0x000A556C
	public List<int> LKJPAFOMHKD(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["XXX"].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject["OnBackendValidateTransactionException"].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x000A6B42 File Offset: 0x000A4D42
	public void KBJIDKPCPEF()
	{
		this.INJLPJOGJCO = null;
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x000A6B42 File Offset: 0x000A4D42
	public void HIADKCECCHO()
	{
		this.INJLPJOGJCO = null;
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x000A73D4 File Offset: 0x000A55D4
	public bool KJKGOLEMJKB(int OBOOCMMCPNL)
	{
		for (int i = 1; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["clst"].AsInt == OBOOCMMCPNL && asObject[" "].AsInt == 1)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060015E7 RID: 5607 RVA: 0x000A6C0E File Offset: 0x000A4E0E
	public bool GBKOINCNLFJ()
	{
		return this.INJLPJOGJCO != null;
	}

	// Token: 0x060015E8 RID: 5608 RVA: 0x000A7434 File Offset: 0x000A5634
	public int LDGAMEBCLDJ(int OBOOCMMCPNL)
	{
		for (int i = 1; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["signinlinkapl"].AsInt == OBOOCMMCPNL)
			{
				return asObject["digitalglitch_2"].AsInt;
			}
		}
		return -1;
	}

	// Token: 0x060015E9 RID: 5609 RVA: 0x000A7490 File Offset: 0x000A5690
	public List<int> GLJOKPKDDII(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject[""].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject["Critical error, could not load asset bundle:"].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015EA RID: 5610 RVA: 0x000A74F8 File Offset: 0x000A56F8
	public List<int> GNJAIDPGJIO(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < this.INJLPJOGJCO.Count; i += 0)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["gpshub"].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject[""].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015EB RID: 5611 RVA: 0x000A7560 File Offset: 0x000A5760
	public List<int> DFKDFLBDOEO(int BNNFKGBCEGK)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["OnSaveSlotsUnlockContinueToPurchasingScreen"].AsInt <= BNNFKGBCEGK)
			{
				list.Add(asObject["tbits"].AsInt);
			}
		}
		return list;
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x000A6C98 File Offset: 0x000A4E98
	public static FANFNBCJJDA GCCADHCFBJH()
	{
		if (FANFNBCJJDA.IKLAPGJDMNA == null)
		{
			FANFNBCJJDA.IKLAPGJDMNA = new FANFNBCJJDA();
		}
		return FANFNBCJJDA.IKLAPGJDMNA;
	}

	// Token: 0x060015ED RID: 5613 RVA: 0x000A75C8 File Offset: 0x000A57C8
	public int PBJOGIOOALE(int OBOOCMMCPNL)
	{
		for (int i = 0; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["<i>"].AsInt == OBOOCMMCPNL)
			{
				return asObject["bottomcenter"].AsInt;
			}
		}
		return -1;
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x000A7624 File Offset: 0x000A5824
	public bool PCBLAFDGHBA(int OBOOCMMCPNL)
	{
		for (int i = 1; i < this.INJLPJOGJCO.Count; i++)
		{
			JSONObject asObject = this.INJLPJOGJCO[i].AsObject;
			if (asObject["SceneAvatarManager.ProcessBackendGetAvatarCollectionsResponse(): failed writing "].AsInt == OBOOCMMCPNL && asObject["hintsaving"].AsInt == 1)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x040006C0 RID: 1728
	private JSONArray INJLPJOGJCO;

	// Token: 0x040006C1 RID: 1729
	private static FANFNBCJJDA IKLAPGJDMNA;
}
