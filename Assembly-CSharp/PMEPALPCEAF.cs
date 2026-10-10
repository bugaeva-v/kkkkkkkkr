using System;
using System.Collections.Generic;
using System.Text;
using SimpleJSON;
using UnityEngine;

// Token: 0x020000BD RID: 189
public class PMEPALPCEAF
{
	// Token: 0x06001A8D RID: 6797 RVA: 0x000B6CD8 File Offset: 0x000B4ED8
	public bool JECGGDNKBID()
	{
		if (!this.GIFPFPOPEJN)
		{
			this.JMJOEHHFJGC(false);
		}
		for (int i = 0; i < this.NPHNGJMGKCB.Count; i++)
		{
			if (this.NPHNGJMGKCB[i].Equals("socialbadge499"))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001A8E RID: 6798 RVA: 0x000B6D2B File Offset: 0x000B4F2B
	public bool MEFKGPLPEBL()
	{
		return this.AEBIJGBDNCF.Count > 0;
	}

	// Token: 0x06001A8F RID: 6799 RVA: 0x000B6D3C File Offset: 0x000B4F3C
	public List<string> IJDGJJCKHAH()
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < this.GLCKIAGABIC.Count; i++)
			{
				string text = this.GLCKIAGABIC[i];
				if (text.Contains("$"))
				{
					string[] array = DPGJIJGOCIC.NHEBLMBJNPI(text, '$');
					list.Add(array[1]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06001A90 RID: 6800 RVA: 0x000B6DB0 File Offset: 0x000B4FB0
	public List<int> FOHIEAJECHA()
	{
		new List<int>();
		List<int> result = new List<int>();
		if (this.GIFPFPOPEJN)
		{
			result = DPGJIJGOCIC.DDNFIDBDEGC(this.PLLGPNGEHLL);
		}
		else
		{
			result = DPGJIJGOCIC.DDNFIDBDEGC(AKLFPGMDKLA.EHBBFMCILPC.PLLGPNGEHLL);
		}
		return result;
	}

	// Token: 0x06001A91 RID: 6801 RVA: 0x000B6DF0 File Offset: 0x000B4FF0
	public List<ICGCJJLADEG> AOCCGKHNGMD()
	{
		return this.AEBIJGBDNCF;
	}

	// Token: 0x06001A92 RID: 6802 RVA: 0x000B6DF8 File Offset: 0x000B4FF8
	public List<int> MHOAOIMAPIJ()
	{
		new List<int>();
		List<int> result = new List<int>();
		if (this.GIFPFPOPEJN)
		{
			result = DPGJIJGOCIC.DDNFIDBDEGC(this.FCJJDEKOIED);
		}
		else
		{
			result = DPGJIJGOCIC.DDNFIDBDEGC(AKLFPGMDKLA.EHBBFMCILPC.FCJJDEKOIED);
		}
		return result;
	}

	// Token: 0x06001A93 RID: 6803 RVA: 0x000B6E38 File Offset: 0x000B5038
	public void AAHPPDCDNCC()
	{
		try
		{
			if (this.HBBADIACPDG)
			{
				return;
			}
			DPGJIJGOCIC.ADFCDFHBDAF("InitTopMatchDataLocal()");
			this.HBBADIACPDG = true;
			JSONArray jsonarray = AssetsManager.EHBBFMCILPC.profileDataAsset.GIOFKDDKAPD();
			if (null == jsonarray)
			{
				return;
			}
			List<IMMKFHKEEBF> list = new List<IMMKFHKEEBF>();
			List<IMMKFHKEEBF> list2 = new List<IMMKFHKEEBF>();
			this.FKDMPMKBCBL = new List<IMMKFHKEEBF>();
			this.IOEACDCKKID = new List<IMMKFHKEEBF>();
			for (int i = jsonarray.Count - 1; i >= 0; i--)
			{
				bool flag = false;
				JSONObject asObject = jsonarray[i].AsObject;
				string text = asObject["var"];
				text = text.Replace(" ", "");
				string text2 = asObject["ant"];
				text2 = text2.Replace(" ", "");
				string text3 = asObject["sprite"];
				text3 = text3.Replace(" ", "");
				string text4 = asObject["max"];
				text4 = text4.Replace(" ", "");
				if (text.Length != 0 && text2.Length != 0 && text4.Length != 0)
				{
					int asInt = asObject["ant"].AsInt;
					int asInt2 = asObject["max"].AsInt;
					string text5 = asObject["varCondition"];
					text5 = text5.Replace(" ", "");
					int asInt3 = asObject["varConditionValue"].AsInt;
					string text6 = asObject["varConditionLocked"];
					text6 = text6.Replace(" ", "");
					int asInt4 = asObject["varConditionLockedValue"].AsInt;
					AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(asInt);
					if (null != assetAnthology)
					{
						if (assetAnthology.header.maxStories != assetAnthology.header.availableStories.Count)
						{
							flag = true;
						}
						AssetStoryHeader assetStoryHeader = GKJPOGNFKNK.CDCEFHLNNEC(assetAnthology.header.availableStories[assetAnthology.header.availableStories.Count - 1]);
						if (null != assetStoryHeader)
						{
							if (assetStoryHeader.totalChaptersCount != assetStoryHeader.availableChaptersCount)
							{
								flag = true;
							}
							EIOPLEFLLIM eioplefllim = AKLFPGMDKLA.EHBBFMCILPC.GJBDBONJCDL(asInt);
							if (eioplefllim != null)
							{
								int num = KDCJJBLGCBH.EHBBFMCILPC.PFPMHHCGPJG();
								if (AKLFPGMDKLA.EHBBFMCILPC.NCPPKEGJPKC() || AKLFPGMDKLA.EHBBFMCILPC.IKHJPEIPEGE(KDCJJBLGCBH.EHBBFMCILPC.HHONCLBBHPG(1), true))
								{
									num += KDCJJBLGCBH.EHBBFMCILPC.BJJOMJLKGHG();
								}
								for (int j = 0; j < num; j++)
								{
									int num2 = eioplefllim.EGHHCFFLPCP(j);
									if (num2 >= 0 && AKLFPGMDKLA.EHBBFMCILPC.ANJGMNHMPGM(j))
									{
										if (num2 > assetAnthology.header.availableStories.Count - 1)
										{
											num2 = assetAnthology.header.availableStories.Count - 1;
										}
										PLFDAJJHMKO plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[num2], j);
										if (plfdajjhmko == null && num2 > 0)
										{
											num2--;
											plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[num2], j);
										}
										if (plfdajjhmko != null)
										{
											try
											{
												if (!flag && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.en && LanguageManager.EHBBFMCILPC.GetSelectedLanguage() != CEIBHCNNIDC.ru && assetStoryHeader.totalChaptersCount < assetStoryHeader.chapterAssetPacks.Count && assetStoryHeader.chapterAssetPacks[assetStoryHeader.totalChaptersCount - 1].inkRevisions.Count > 0 && !assetStoryHeader.chapterAssetPacks[assetStoryHeader.totalChaptersCount - 1].inkRevisions[assetStoryHeader.chapterAssetPacks[assetStoryHeader.totalChaptersCount - 1].inkRevisions.Count - 1].supportedLanguages.Contains(LanguageManager.EHBBFMCILPC.GetSelectedLanguage()))
												{
													flag = true;
												}
											}
											catch (Exception aklgbjkdomm)
											{
												DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
											}
											if (plfdajjhmko.NCAMFPGMCIG.NIJBAMNFJLM.Count == 0)
											{
												plfdajjhmko = null;
												if (num2 > 0)
												{
													num2--;
													plfdajjhmko = AKLFPGMDKLA.EHBBFMCILPC.PKNIPLDMJGG(assetAnthology.header.availableStories[num2], j);
												}
											}
											if (plfdajjhmko != null)
											{
												string text7 = "";
												bool flag2 = true;
												if (text5.Length > 0)
												{
													text7 = text5;
													string text8 = plfdajjhmko.NCAMFPGMCIG.MPMJOPGMNPB(ref text7);
													if (text8 != null && text8.Length > 0)
													{
														try
														{
															flag2 = (int.Parse(text8) == asInt3);
															goto IL_4C6;
														}
														catch (Exception aklgbjkdomm2)
														{
															flag2 = false;
															DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
															goto IL_4C6;
														}
													}
													flag2 = false;
												}
												IL_4C6:
												int mjkicdjifip = 0;
												if (text6.Length > 0)
												{
													text7 = text6;
													string text8 = plfdajjhmko.NCAMFPGMCIG.MPMJOPGMNPB(ref text7);
													if (text8 != null && text8.Length > 0)
													{
														try
														{
															if (int.Parse(text8) == asInt4)
															{
																mjkicdjifip = 1;
															}
															else
															{
																mjkicdjifip = 0;
															}
															goto IL_517;
														}
														catch (Exception aklgbjkdomm3)
														{
															mjkicdjifip = 0;
															DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
															goto IL_517;
														}
													}
													mjkicdjifip = 0;
												}
												IL_517:
												text7 = text;
												if (flag2)
												{
													string text8 = plfdajjhmko.NCAMFPGMCIG.MPMJOPGMNPB(ref text7);
													if (text8 != null && text8.Length > 0)
													{
														try
														{
															IMMKFHKEEBF immkfhkeebf = new IMMKFHKEEBF();
															float num3 = (float)int.Parse(text8);
															float num4 = (float)asInt2;
															immkfhkeebf.BIBKFNMPHIK = (int)(100f * num3 / num4);
															immkfhkeebf.BIBKFNMPHIK = Math.Clamp(immkfhkeebf.BIBKFNMPHIK, 0, 100);
															immkfhkeebf.ODGNIFJGEHL = text + asInt.ToString();
															immkfhkeebf.PFFCLABCNHI = text3;
															immkfhkeebf.MJKICDJIFIP = mjkicdjifip;
															immkfhkeebf.KDODAAICNDO = AKLFPGMDKLA.EHBBFMCILPC.EELIGNKDLCG(immkfhkeebf);
															immkfhkeebf.ACAGNLALNPA = asInt;
															immkfhkeebf.DLFMMBBLIFH = j;
															if (immkfhkeebf.BIBKFNMPHIK > 0)
															{
																if (flag)
																{
																	this.GFMGENGBAKF(list2, immkfhkeebf);
																}
																else
																{
																	this.GFMGENGBAKF(list, immkfhkeebf);
																}
															}
															goto IL_614;
														}
														catch (Exception aklgbjkdomm4)
														{
															DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
															goto IL_614;
														}
													}
													DPGJIJGOCIC.ADFCDFHBDAF("AssetProfileData.InitializeTopMatchData, varValue is null for " + text);
												}
											}
										}
									}
									IL_614:;
								}
							}
						}
					}
				}
			}
			int num5 = 0;
			while (list2.Count > 0)
			{
				int num6 = -1;
				int num7 = -1;
				for (int k = 0; k < list2.Count; k++)
				{
					if (list2[k].BIBKFNMPHIK > num6)
					{
						num6 = list2[k].BIBKFNMPHIK;
						num7 = k;
					}
				}
				if (num7 >= 0)
				{
					this.IOEACDCKKID.Add(list2[num7]);
					list2.RemoveAt(num7);
				}
				if (num6 <= 4 && num6 >= 0 && this.IOEACDCKKID.Count >= 10)
				{
					break;
				}
				num5++;
				if (num5 > 100000)
				{
					break;
				}
			}
			DPGJIJGOCIC.ADFCDFHBDAF("total while iterations:" + num5.ToString());
			try
			{
				num5 = 0;
				bool flag3 = true;
				while (flag3)
				{
					flag3 = false;
					for (int l = 0; l < 76; l++)
					{
						int num8 = 0;
						for (int m = 0; m < this.IOEACDCKKID.Count; m++)
						{
							if (this.IOEACDCKKID[m].ACAGNLALNPA == l - 1)
							{
								if (num8 >= 10 && l != 54)
								{
									flag3 = true;
									DPGJIJGOCIC.ADFCDFHBDAF("Trimming topMatchOngoing.Count by removing " + this.IOEACDCKKID[m].ODGNIFJGEHL + " having a percent of " + this.IOEACDCKKID[m].BIBKFNMPHIK.ToString());
									this.IOEACDCKKID.RemoveAt(m);
									break;
								}
								num8++;
							}
						}
					}
					num5++;
					if (num5 > 1000000)
					{
						break;
					}
				}
				DPGJIJGOCIC.ADFCDFHBDAF("total while iterations:" + num5.ToString());
			}
			catch (Exception aklgbjkdomm5)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
			}
			try
			{
				if (this.IOEACDCKKID.Count > 1000)
				{
					this.IOEACDCKKID.RemoveRange(999, this.IOEACDCKKID.Count - 1000);
				}
			}
			catch (Exception aklgbjkdomm6)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm6);
			}
			num5 = 0;
			while (list.Count > 0)
			{
				int num9 = -1;
				int num10 = -1;
				for (int n = 0; n < list.Count; n++)
				{
					if (list[n].BIBKFNMPHIK > num9)
					{
						num9 = list[n].BIBKFNMPHIK;
						num10 = n;
					}
				}
				if (num10 >= 0)
				{
					this.FKDMPMKBCBL.Add(list[num10]);
					list.RemoveAt(num10);
				}
				if (num9 <= 4 && num9 >= 0 && this.FKDMPMKBCBL.Count >= 10)
				{
					break;
				}
				num5++;
				if (num5 > 100000)
				{
					break;
				}
			}
			DPGJIJGOCIC.ADFCDFHBDAF("total while iterations:" + num5.ToString());
			try
			{
				num5 = 0;
				bool flag4 = true;
				while (flag4)
				{
					flag4 = false;
					for (int num11 = 0; num11 < 76; num11++)
					{
						int num12 = 0;
						for (int num13 = 0; num13 < this.FKDMPMKBCBL.Count; num13++)
						{
							if (this.FKDMPMKBCBL[num13].ACAGNLALNPA == num11 - 1)
							{
								if (num12 >= 10 && num11 != 54)
								{
									flag4 = true;
									DPGJIJGOCIC.ADFCDFHBDAF("Trimming topMatch.Count by removing " + this.FKDMPMKBCBL[num13].ODGNIFJGEHL + " having a percent of " + this.FKDMPMKBCBL[num13].BIBKFNMPHIK.ToString());
									this.FKDMPMKBCBL.RemoveAt(num13);
									break;
								}
								num12++;
							}
						}
					}
					num5++;
					if (num5 > 1000000)
					{
						break;
					}
				}
				DPGJIJGOCIC.ADFCDFHBDAF("total while iterations:" + num5.ToString());
			}
			catch (Exception aklgbjkdomm7)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm7);
			}
			try
			{
				if (this.FKDMPMKBCBL.Count > 1000)
				{
					this.FKDMPMKBCBL.RemoveRange(999, this.FKDMPMKBCBL.Count - 1000);
				}
			}
			catch (Exception aklgbjkdomm8)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm8);
			}
			if (!this.CBLKLJADODP.ToString().Equals(this.BHGKFJPJNHE().ToString()))
			{
				this.CHCBHLIBGFA = true;
			}
		}
		catch (Exception aklgbjkdomm9)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm9);
		}
		this.MBFLANHHEBF();
		try
		{
			AKLFPGMDKLA.EHBBFMCILPC.NHJEADAKHMN(this.ALBFAIPPLLA(), this.CLFAOIPBLCA());
		}
		catch (Exception aklgbjkdomm10)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm10);
		}
	}

	// Token: 0x06001A94 RID: 6804 RVA: 0x000B7978 File Offset: 0x000B5B78
	public void HEEHBPKIIEP(string FCICOMKKJIK)
	{
		for (int i = 1; i < this.GLCKIAGABIC.Count; i++)
		{
			if (this.GLCKIAGABIC[i].EndsWith("OnFriendsPopupManagerRejectClick" + FCICOMKKJIK))
			{
				return;
			}
		}
		for (int j = 0; j < this.FLJBGIKGPEM.Count; j += 0)
		{
			if (this.FLJBGIKGPEM[j].IAGMLHAEOJI.Equals(FCICOMKKJIK))
			{
				DPGJIJGOCIC.CMGOAFDBAOH("XXX");
				this.CHCBHLIBGFA = true;
				string pmpalgihkfb = this.FLJBGIKGPEM[j].KKEBIBCEIPL + "SceneAvatarManager.SyncSelectedAvatarCollectionToAnthology(): anthology indices list not available" + FCICOMKKJIK;
				this.GLCKIAGABIC = DPGJIJGOCIC.OOFJDMODBPA(this.GLCKIAGABIC, pmpalgihkfb);
				return;
			}
		}
	}

	// Token: 0x06001A95 RID: 6805 RVA: 0x000B7A30 File Offset: 0x000B5C30
	public void EONNDBCFGMM(JSONArray GOJLCFCFNCE)
	{
		try
		{
			JSONArray jsonarray = new JSONArray();
			List<string> list = new List<string>();
			if (null != GOJLCFCFNCE)
			{
				for (int i = 0; i < GOJLCFCFNCE.Count; i++)
				{
					JSONArray asArray = GOJLCFCFNCE[i].AsArray;
					if (null != asArray)
					{
						for (int j = 0; j < asArray.Count; j++)
						{
							this.CJAANCAAJOF.Add(asArray[j]);
						}
					}
				}
			}
			for (int k = 0; k < this.CJAANCAAJOF.Count; k++)
			{
				string text = this.CJAANCAAJOF[k];
				if (!list.Contains(text))
				{
					list.Add(text);
					jsonarray.Add(text);
				}
				else
				{
					this.HJFAJHLBJAG = true;
					DPGJIJGOCIC.ANOPFDLPKGC("Removing duplicated cutscene data entry:" + text);
				}
			}
			this.CJAANCAAJOF = jsonarray;
			if (!this.GIFPFPOPEJN)
			{
				PMEPALPCEAF.CPEMOAHNFAG = this.CJAANCAAJOF;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001A96 RID: 6806 RVA: 0x000B7B3C File Offset: 0x000B5D3C
	public List<string> GAOMNJLIHAN()
	{
		List<string> list = new List<string>();
		List<string> collection = DPGJIJGOCIC.KGDOIOLLCDI(this.CHBNFGDAGOI);
		List<string> collection2 = DPGJIJGOCIC.POHBFGLLKFD(this.BEIEDDFCCFO);
		list.AddRange(collection);
		list.AddRange(collection2);
		return list;
	}

	// Token: 0x06001A97 RID: 6807 RVA: 0x000B7B74 File Offset: 0x000B5D74
	public List<string> FJHCBIPBEBG()
	{
		return DPGJIJGOCIC.POHBFGLLKFD(DPGJIJGOCIC.LPHPLHPMJLH(this.JEDFLIKKPEC));
	}

	// Token: 0x06001A98 RID: 6808 RVA: 0x000B7B88 File Offset: 0x000B5D88
	public void LEFMIMINNKO(string FCICOMKKJIK)
	{
		for (int i = 0; i < this.CJAANCAAJOF.Count; i++)
		{
			BNFCLKNDBLO bnfclkndblo = new BNFCLKNDBLO();
			if (bnfclkndblo.EFGCFPKMCHM(this.CJAANCAAJOF[i]) && bnfclkndblo.IAGMLHAEOJI.Equals(FCICOMKKJIK))
			{
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, DeleteCutscene()");
				this.CHCBHLIBGFA = (this.HJFAJHLBJAG = true);
				this.CJAANCAAJOF.Remove(i);
				break;
			}
		}
		this.IPNOKENGAPB();
	}

	// Token: 0x06001A99 RID: 6809 RVA: 0x000B7C08 File Offset: 0x000B5E08
	public void DCBPJJFIMOA(string FCICOMKKJIK)
	{
		for (int i = 0; i < this.GLCKIAGABIC.Count; i++)
		{
			if (this.GLCKIAGABIC[i].EndsWith("$" + FCICOMKKJIK))
			{
				return;
			}
		}
		for (int j = 0; j < this.FLJBGIKGPEM.Count; j++)
		{
			if (this.FLJBGIKGPEM[j].IAGMLHAEOJI.Equals(FCICOMKKJIK))
			{
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, AddCutsceneToFavorites()");
				this.CHCBHLIBGFA = true;
				string pmpalgihkfb = this.FLJBGIKGPEM[j].KKEBIBCEIPL + "$" + FCICOMKKJIK;
				this.GLCKIAGABIC = DPGJIJGOCIC.JBAFNMLJGGF(this.GLCKIAGABIC, pmpalgihkfb);
				return;
			}
		}
	}

	// Token: 0x06001A9A RID: 6810 RVA: 0x000B7CC0 File Offset: 0x000B5EC0
	private bool OMHGNHIDOEF(string FCICOMKKJIK)
	{
		for (int i = 0; i < this.FLJBGIKGPEM.Count; i++)
		{
			if (this.FLJBGIKGPEM[i].IAGMLHAEOJI.Equals(FCICOMKKJIK))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001A9C RID: 6812 RVA: 0x000B7EB8 File Offset: 0x000B60B8
	public void BBKFMMCGFJL(PMEPALPCEAF BEBLHBLODLJ)
	{
		this.OFOIECEHOCN = 0;
		if (BEBLHBLODLJ == null)
		{
			return;
		}
		this.CIKCGDECCMM = new List<int>();
		try
		{
			List<string> list;
			List<string> list2;
			if (this.CFDOLDIADOP().Count > BEBLHBLODLJ.CFDOLDIADOP().Count)
			{
				list = BEBLHBLODLJ.CFDOLDIADOP();
				list2 = this.CFDOLDIADOP();
			}
			else
			{
				list = this.CFDOLDIADOP();
				list2 = BEBLHBLODLJ.CFDOLDIADOP();
			}
			if (list.Count > 1)
			{
				float num = 103f;
				for (int i = 0; i < list2.Count; i += 0)
				{
					if (list.Contains(list2[i]))
					{
						num += 102f;
						this.CIKCGDECCMM.Add(int.Parse(list2[i].Replace("%)", "")));
					}
				}
				this.OFOIECEHOCN = (int)(num / (float)list.Count * 1509f);
			}
			else
			{
				this.OFOIECEHOCN = 0;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001A9D RID: 6813 RVA: 0x000B7FAC File Offset: 0x000B61AC
	public bool MKDGLNJJDLN(PMEPALPCEAF KDECNPPHGBD)
	{
		return KDECNPPHGBD != null && KDECNPPHGBD.EEBMPDNLJGD.Equals(this.EEBMPDNLJGD);
	}

	// Token: 0x06001A9E RID: 6814 RVA: 0x000B7FC4 File Offset: 0x000B61C4
	public void GPCDLDEHOMP()
	{
		this.GLCKIAGABIC = new JSONArray();
		this.CHCBHLIBGFA = true;
	}

	// Token: 0x06001A9F RID: 6815 RVA: 0x000B7FD8 File Offset: 0x000B61D8
	public List<string> ACMJMCLJPKC()
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < this.GLCKIAGABIC.Count; i++)
			{
				string text = this.GLCKIAGABIC[i];
				if (text.Contains("$"))
				{
					string[] array = DPGJIJGOCIC.NHEBLMBJNPI(text, '$');
					list.Add(array[0]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06001AA0 RID: 6816 RVA: 0x000B804C File Offset: 0x000B624C
	public void MGCCGKOEJCN(bool BDFHENEFGKI)
	{
		try
		{
			if (!BDFHENEFGKI)
			{
				if (this.CHBNFGDAGOI.Count > 0)
				{
					JSONArray jsonarray = new JSONArray();
					for (int i = 0; i < this.CHBNFGDAGOI.Count; i++)
					{
						string text = this.CHBNFGDAGOI[i];
						for (int j = 0; j < this.FKDMPMKBCBL.Count; j++)
						{
							if (text.Equals(this.FKDMPMKBCBL[j].DKDECIHBGJE()))
							{
								jsonarray.Add(this.FKDMPMKBCBL[j].DKDECIHBGJE());
								break;
							}
						}
					}
					int num = this.CHBNFGDAGOI.Count - jsonarray.Count;
					this.CHBNFGDAGOI = jsonarray;
					if (num > 0)
					{
						this.CHCBHLIBGFA = true;
					}
					DPGJIJGOCIC.ADFCDFHBDAF("CleanseHiddenTopMatchLists(): removed " + num.ToString() + " entries from the user hidden list (completed) as obsolete.");
				}
				DPGJIJGOCIC.ADFCDFHBDAF("topMatch:" + this.FKDMPMKBCBL.Count.ToString());
				DPGJIJGOCIC.ADFCDFHBDAF("hiddenTopMatchEntries:" + this.CHBNFGDAGOI.Count.ToString());
			}
			if (BDFHENEFGKI)
			{
				if (this.BEIEDDFCCFO.Count > 0)
				{
					JSONArray jsonarray2 = new JSONArray();
					for (int k = 0; k < this.BEIEDDFCCFO.Count; k++)
					{
						string text2 = this.BEIEDDFCCFO[k];
						for (int l = 0; l < this.IOEACDCKKID.Count; l++)
						{
							if (text2.Equals(this.IOEACDCKKID[l].DKDECIHBGJE()))
							{
								jsonarray2.Add(this.IOEACDCKKID[l].DKDECIHBGJE());
								break;
							}
						}
					}
					int num2 = this.BEIEDDFCCFO.Count - jsonarray2.Count;
					this.BEIEDDFCCFO = jsonarray2;
					if (num2 > 0)
					{
						this.CHCBHLIBGFA = true;
					}
					DPGJIJGOCIC.ADFCDFHBDAF("CleanseHiddenTopMatchLists(): removed " + num2.ToString() + " entries from the user hidden list (ongoing) as obsolete.");
				}
				DPGJIJGOCIC.ADFCDFHBDAF("topMatchOngoing:" + this.IOEACDCKKID.Count.ToString());
				DPGJIJGOCIC.ADFCDFHBDAF("hiddenTopMatchOngoingEntries:" + this.BEIEDDFCCFO.Count.ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x000B82C8 File Offset: 0x000B64C8
	public void CMLBEBKBNBJ(string FCICOMKKJIK)
	{
		for (int i = 1; i < this.CJAANCAAJOF.Count; i += 0)
		{
			BNFCLKNDBLO bnfclkndblo = new BNFCLKNDBLO();
			if (bnfclkndblo.IMIOPDPLKNG(this.CJAANCAAJOF[i]) && bnfclkndblo.IAGMLHAEOJI.Equals(FCICOMKKJIK))
			{
				DPGJIJGOCIC.NFIDPOMCNLP("dc");
				this.CHCBHLIBGFA = (this.HJFAJHLBJAG = false);
				this.CJAANCAAJOF.Remove(i);
				break;
			}
		}
		this.IPNOKENGAPB();
	}

	// Token: 0x06001AA2 RID: 6818 RVA: 0x000B8348 File Offset: 0x000B6548
	public void HKGOBAPMPFJ(string FCICOMKKJIK)
	{
		for (int i = 0; i < this.GLCKIAGABIC.Count; i++)
		{
			if (this.GLCKIAGABIC[i].EndsWith("$" + FCICOMKKJIK))
			{
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, RemoveCutsceneFromFavorites()");
				this.CHCBHLIBGFA = true;
				this.GLCKIAGABIC.Remove(i);
				return;
			}
		}
	}

	// Token: 0x06001AA3 RID: 6819 RVA: 0x000B83B0 File Offset: 0x000B65B0
	public void BJJBCPJPBNF(PMEPALPCEAF BEBLHBLODLJ)
	{
		this.OFOIECEHOCN = 1;
		if (BEBLHBLODLJ == null)
		{
			return;
		}
		this.CIKCGDECCMM = new List<int>();
		try
		{
			List<string> list;
			List<string> list2;
			if (this.CFDOLDIADOP().Count > BEBLHBLODLJ.CFDOLDIADOP().Count)
			{
				list = BEBLHBLODLJ.CFDOLDIADOP();
				list2 = this.CFDOLDIADOP();
			}
			else
			{
				list = this.CFDOLDIADOP();
				list2 = BEBLHBLODLJ.CFDOLDIADOP();
			}
			if (list.Count > 0)
			{
				float num = 217f;
				for (int i = 1; i < list2.Count; i += 0)
				{
					if (list.Contains(list2[i]))
					{
						num += 531f;
						this.CIKCGDECCMM.Add(int.Parse(list2[i].Replace("OnConsumeEnergyException", "Critical error, could not load asset bundle:")));
					}
				}
				this.OFOIECEHOCN = (int)(num / (float)list.Count * 155f);
			}
			else
			{
				this.OFOIECEHOCN = 1;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001AA4 RID: 6820 RVA: 0x000B84A4 File Offset: 0x000B66A4
	public List<int> FCCNNMOIMGC()
	{
		new List<int>();
		List<int> list = new List<int>();
		if (this.GIFPFPOPEJN)
		{
			for (int i = 0; i < this.KGHMOKADNKK.Count; i++)
			{
				if (!list.Contains(this.KGHMOKADNKK[i]))
				{
					list.Add(this.KGHMOKADNKK[i]);
				}
			}
		}
		else
		{
			list = LJNMIPMNOKF.EHBBFMCILPC.FCCNNMOIMGC();
		}
		if (list.Count > 1)
		{
			list.Reverse();
		}
		return list;
	}

	// Token: 0x06001AA5 RID: 6821 RVA: 0x000B8520 File Offset: 0x000B6720
	public List<string> KCMNMIFBJOA()
	{
		List<string> list = new List<string>();
		List<string> collection = DPGJIJGOCIC.KGDOIOLLCDI(this.CHBNFGDAGOI);
		List<string> collection2 = DPGJIJGOCIC.POHBFGLLKFD(this.BEIEDDFCCFO);
		list.AddRange(collection);
		list.AddRange(collection2);
		return list;
	}

	// Token: 0x06001AA6 RID: 6822 RVA: 0x000B8558 File Offset: 0x000B6758
	public List<IMMKFHKEEBF> CLFAOIPBLCA()
	{
		return this.IOEACDCKKID;
	}

	// Token: 0x06001AA7 RID: 6823 RVA: 0x000B8560 File Offset: 0x000B6760
	public void HFOONKBBIKD()
	{
		this.JEDFLIKKPEC = new JSONArray();
		this.CHCBHLIBGFA = true;
	}

	// Token: 0x06001AA8 RID: 6824 RVA: 0x000B8574 File Offset: 0x000B6774
	public bool PMOIEJLHFFF(string MMEBLKHCPEH)
	{
		return this.KPOIHDJIMBF.Count > 0 && MMEBLKHCPEH.Length > 0 && DPGJIJGOCIC.POHBFGLLKFD(this.KPOIHDJIMBF).Contains(MMEBLKHCPEH);
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x000B85A3 File Offset: 0x000B67A3
	public List<BNFCLKNDBLO> IPILOAEGBMD()
	{
		return this.FLJBGIKGPEM;
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x000B85AC File Offset: 0x000B67AC
	public void GFFMGEEMKBP(string FCICOMKKJIK, string JEMJGNEGEKI)
	{
		try
		{
			for (int i = 0; i < this.FLJBGIKGPEM.Count; i++)
			{
				if (this.FLJBGIKGPEM[i].IAGMLHAEOJI.Equals(FCICOMKKJIK))
				{
					JSONArray jsonarray = new JSONArray();
					for (int j = 0; j < this.CJAANCAAJOF.Count; j++)
					{
						BNFCLKNDBLO bnfclkndblo = new BNFCLKNDBLO();
						if (bnfclkndblo.EFGCFPKMCHM(this.CJAANCAAJOF[j]))
						{
							if (bnfclkndblo.IAGMLHAEOJI.Equals(FCICOMKKJIK))
							{
								jsonarray.Add(bnfclkndblo.HEHFGHPBJMH(JEMJGNEGEKI));
							}
							else
							{
								jsonarray.Add(this.CJAANCAAJOF[j]);
							}
						}
					}
					this.FLJBGIKGPEM[i].PGEKNGNHANN = JEMJGNEGEKI;
					DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, RenameCutscene()");
					this.CJAANCAAJOF = jsonarray;
					if (!this.GIFPFPOPEJN)
					{
						PMEPALPCEAF.CPEMOAHNFAG = this.CJAANCAAJOF;
					}
					this.CHCBHLIBGFA = (this.HJFAJHLBJAG = true);
					break;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001AAB RID: 6827 RVA: 0x000B86C4 File Offset: 0x000B68C4
	public int CLCHHPKGBHJ(int ACADLFDGMLP)
	{
		if (ACADLFDGMLP == 1)
		{
			return this.DELPFFPOEJJ - 2018;
		}
		return 0;
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x000B86D8 File Offset: 0x000B68D8
	public bool HFEEAIMKJPK()
	{
		try
		{
			for (int i = 0; i < this.FLJBGIKGPEM.Count; i++)
			{
				if (GKJPOGNFKNK.EOOHLFCPIJB(this.FLJBGIKGPEM[i].AMKCLHLIIMN) && !AssetsManager.EHBBFMCILPC.lobbyDataAsset.FIDCFFPHNAP(this.FLJBGIKGPEM[i].KKEBIBCEIPL, true))
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

	// Token: 0x06001AAD RID: 6829 RVA: 0x000B8758 File Offset: 0x000B6958
	public void LDKBOMCJIPL(int PLKMJJIIJNO)
	{
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.JBAFPBAMKKN.Count; i++)
		{
			int asInt = this.JBAFPBAMKKN[i].AsInt;
			if (asInt != PLKMJJIIJNO)
			{
				jsonarray.Add(asInt);
			}
		}
		this.JBAFPBAMKKN = jsonarray;
		this.CHCBHLIBGFA = true;
	}

	// Token: 0x06001AAE RID: 6830 RVA: 0x000B87B4 File Offset: 0x000B69B4
	public List<string> KJOHJOADCGJ()
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < this.GLCKIAGABIC.Count; i += 0)
			{
				string text = this.GLCKIAGABIC[i];
				if (text.Contains("analogglitch20ovr"))
				{
					string[] array = DPGJIJGOCIC.NHEBLMBJNPI(text, 'I');
					list.Add(array[0]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06001AAF RID: 6831 RVA: 0x000B8828 File Offset: 0x000B6A28
	public void GFJPFDNJHNG(int CMBCNMLGPPC)
	{
		if (CMBCNMLGPPC != this.DIEPFILJNKG)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, SetCompletedChaptersCount()");
			this.CHCBHLIBGFA = true;
			this.DIEPFILJNKG = CMBCNMLGPPC;
		}
	}

	// Token: 0x06001AB0 RID: 6832 RVA: 0x000B884C File Offset: 0x000B6A4C
	public void DFCLDEFKHPB(bool BDFHENEFGKI)
	{
		try
		{
			if (!BDFHENEFGKI)
			{
				if (this.CHBNFGDAGOI.Count > 0)
				{
					JSONArray jsonarray = new JSONArray();
					for (int i = 0; i < this.CHBNFGDAGOI.Count; i += 0)
					{
						string text = this.CHBNFGDAGOI[i];
						for (int j = 0; j < this.FKDMPMKBCBL.Count; j++)
						{
							if (text.Equals(this.FKDMPMKBCBL[j].JOKOEGJEGAE()))
							{
								jsonarray.Add(this.FKDMPMKBCBL[j].KPEIFLJACPE());
								break;
							}
						}
					}
					int num = this.CHBNFGDAGOI.Count - jsonarray.Count;
					this.CHBNFGDAGOI = jsonarray;
					if (num > 0)
					{
						this.CHCBHLIBGFA = false;
					}
					DPGJIJGOCIC.PJCLICBPPDA("trinket" + num.ToString() + "XXX");
				}
				DPGJIJGOCIC.PJCLICBPPDA("" + this.FKDMPMKBCBL.Count.ToString());
				DPGJIJGOCIC.ADFCDFHBDAF("daysshort" + this.CHBNFGDAGOI.Count.ToString());
			}
			if (BDFHENEFGKI)
			{
				if (this.BEIEDDFCCFO.Count > 0)
				{
					JSONArray jsonarray2 = new JSONArray();
					for (int k = 1; k < this.BEIEDDFCCFO.Count; k++)
					{
						string text2 = this.BEIEDDFCCFO[k];
						for (int l = 1; l < this.IOEACDCKKID.Count; l++)
						{
							if (text2.Equals(this.IOEACDCKKID[l].ELLAOANGDNI()))
							{
								jsonarray2.Add(this.IOEACDCKKID[l].HCFKHGHICBG());
								break;
							}
						}
					}
					int num2 = this.BEIEDDFCCFO.Count - jsonarray2.Count;
					this.BEIEDDFCCFO = jsonarray2;
					if (num2 > 0)
					{
						this.CHCBHLIBGFA = false;
					}
					DPGJIJGOCIC.ADFCDFHBDAF("lobby" + num2.ToString() + "〉");
				}
				DPGJIJGOCIC.PJCLICBPPDA("StorySaveBody.GetAvatarIndexWardrobe(), unsupported wardrobe index:" + this.IOEACDCKKID.Count.ToString());
				DPGJIJGOCIC.PJCLICBPPDA("cnd" + this.BEIEDDFCCFO.Count.ToString());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001AB1 RID: 6833 RVA: 0x000B8AC8 File Offset: 0x000B6CC8
	public void FIMCPPIBHPM(bool BDFHENEFGKI = false)
	{
		if (!BDFHENEFGKI)
		{
			if (!this.GIFPFPOPEJN)
			{
				this.CHBNFGDAGOI = new JSONArray();
			}
			else
			{
				this.KBLIHBMONDJ = new JSONArray();
			}
		}
		else if (!this.GIFPFPOPEJN)
		{
			this.BEIEDDFCCFO = new JSONArray();
		}
		else
		{
			this.LALOCGIOJHO = new JSONArray();
		}
		if (!this.GIFPFPOPEJN)
		{
			this.MBFLANHHEBF();
			this.CHCBHLIBGFA = true;
		}
	}

	// Token: 0x06001AB2 RID: 6834 RVA: 0x000B8B30 File Offset: 0x000B6D30
	public int AFICLHMOBFA(bool BDFHENEFGKI = false)
	{
		if (!BDFHENEFGKI)
		{
			if (!this.GIFPFPOPEJN)
			{
				return this.CHBNFGDAGOI.Count;
			}
			return this.KBLIHBMONDJ.Count;
		}
		else
		{
			if (!this.GIFPFPOPEJN)
			{
				return this.BEIEDDFCCFO.Count;
			}
			return this.LALOCGIOJHO.Count;
		}
	}

	// Token: 0x06001AB3 RID: 6835 RVA: 0x000B8B7F File Offset: 0x000B6D7F
	public List<FHAJAGIMLLJ> LLEOFPEHNJA()
	{
		return this.CJHNLPJFJLG;
	}

	// Token: 0x06001AB4 RID: 6836 RVA: 0x000B8B88 File Offset: 0x000B6D88
	public void GEPIBACNKIP(JSONObject KEGBCGMJOLC, PMEPALPCEAF BEBLHBLODLJ)
	{
		this.GIFPFPOPEJN = true;
		if (KEGBCGMJOLC["thmstr"] != null)
		{
			this.HOICLELFLOE = KEGBCGMJOLC["thmstr"];
		}
		try
		{
			if (KEGBCGMJOLC["nick"] != null && KEGBCGMJOLC["nick"].ToString().Length > 0)
			{
				this.KNCFKDLOPGA = Encoding.UTF8.GetString(Convert.FromBase64String(KEGBCGMJOLC["nick"]));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			if (KEGBCGMJOLC["credo"] != null && KEGBCGMJOLC["credo"].ToString().Length > 0)
			{
				this.PEONEPNPGEC = Encoding.UTF8.GetString(Convert.FromBase64String(KEGBCGMJOLC["credo"]));
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		try
		{
			if (KEGBCGMJOLC["love"] != null && KEGBCGMJOLC["love"].ToString().Length > 0)
			{
				this.FPJMDDIILIK = Encoding.UTF8.GetString(Convert.FromBase64String(KEGBCGMJOLC["love"]));
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		this.GFAABCCNNDA = KEGBCGMJOLC["lvl"].AsInt;
		this.GHCGBLBCHAE = KEGBCGMJOLC["top"].AsInt;
		if (KEGBCGMJOLC["suid"] != null)
		{
			this.LMFCFHMJIFN = KEGBCGMJOLC["suid"];
		}
		if (KEGBCGMJOLC["csuid"] != null)
		{
			this.MIOEBKPPEHO = KEGBCGMJOLC["csuid"];
		}
		if (KEGBCGMJOLC["pid"] != null)
		{
			this.EEBMPDNLJGD = KEGBCGMJOLC["pid"];
		}
		try
		{
			if (KEGBCGMJOLC["gft"] != null)
			{
				JSONObject asObject = KEGBCGMJOLC["gft"].AsObject;
				this.IFEEIAPMIML = new ILCFDPELMMG();
				this.IFEEIAPMIML.FGJPKGLOGNC(asObject);
			}
		}
		catch (Exception aklgbjkdomm4)
		{
			this.IFEEIAPMIML = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
		}
		try
		{
			if (KEGBCGMJOLC["msg64"] != null)
			{
				this.BONNGONEJBO = DPGJIJGOCIC.LMCAODJLEGF(KEGBCGMJOLC["msg64"]);
			}
		}
		catch (Exception aklgbjkdomm5)
		{
			this.BONNGONEJBO = "";
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
		}
		this.JEDFLIKKPEC = new JSONArray();
		if (KEGBCGMJOLC["favchrstr"] != null)
		{
			this.JEDFLIKKPEC = KEGBCGMJOLC["favchrstr"].AsArray;
			try
			{
				if (KEGBCGMJOLC["favchrstr2"] != null)
				{
					JSONArray jsonarray = new JSONArray();
					jsonarray = KEGBCGMJOLC["favchrstr2"].AsArray;
					for (int i = 0; i < jsonarray.Count; i++)
					{
						bool flag = false;
						string text = jsonarray[i];
						for (int j = 0; j < this.JEDFLIKKPEC.Count; j++)
						{
							string value = this.JEDFLIKKPEC[j];
							if (text.Equals(value))
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							this.JEDFLIKKPEC.Add(text);
						}
					}
				}
			}
			catch (Exception aklgbjkdomm6)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm6);
			}
		}
		this.GACNBNBNOEF = new JSONArray();
		if (KEGBCGMJOLC["favstostr"] != null)
		{
			this.GACNBNBNOEF = KEGBCGMJOLC["favstostr"].AsArray;
			try
			{
				if (KEGBCGMJOLC["favstostr2"] != null)
				{
					JSONArray jsonarray2 = new JSONArray();
					jsonarray2 = KEGBCGMJOLC["favstostr2"].AsArray;
					for (int k = 0; k < jsonarray2.Count; k++)
					{
						bool flag2 = false;
						string text2 = jsonarray2[k];
						for (int l = 0; l < this.GACNBNBNOEF.Count; l++)
						{
							string value2 = this.GACNBNBNOEF[l];
							if (text2.Equals(value2))
							{
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							this.GACNBNBNOEF.Add(text2);
						}
					}
				}
			}
			catch (Exception aklgbjkdomm7)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm7);
			}
		}
		if (KEGBCGMJOLC["bdgsspr"] != null)
		{
			this.NPHNGJMGKCB = KEGBCGMJOLC["bdgsspr"].AsArray;
		}
		this.ACCOJOHJPGH(BEBLHBLODLJ);
		try
		{
			if (KEGBCGMJOLC["lang"] != null)
			{
				this.ICCJIBMFNLD = LanguageManager.FromString(KEGBCGMJOLC["lang"]);
			}
			else
			{
				this.ICCJIBMFNLD = CEIBHCNNIDC.count;
			}
		}
		catch (Exception aklgbjkdomm8)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm8);
		}
		if (KEGBCGMJOLC["hofr"] != null)
		{
			this.HBLHNFKEELE = KEGBCGMJOLC["hofr"].AsInt;
			return;
		}
		this.HBLHNFKEELE = -1;
	}

	// Token: 0x06001AB5 RID: 6837 RVA: 0x000B90DC File Offset: 0x000B72DC
	public void ABHJFNLICDO(IMMKFHKEEBF FOEEIJFHMGG, bool BDFHENEFGKI = false)
	{
		if (!BDFHENEFGKI)
		{
			for (int i = 0; i < this.CHBNFGDAGOI.Count; i++)
			{
				if (this.CHBNFGDAGOI[i].Equals(FOEEIJFHMGG.DKDECIHBGJE()))
				{
					return;
				}
			}
			this.CHBNFGDAGOI.Add(FOEEIJFHMGG.DKDECIHBGJE());
		}
		else
		{
			for (int j = 0; j < this.BEIEDDFCCFO.Count; j++)
			{
				if (this.BEIEDDFCCFO[j].Equals(FOEEIJFHMGG.DKDECIHBGJE()))
				{
					return;
				}
			}
			this.BEIEDDFCCFO.Add(FOEEIJFHMGG.DKDECIHBGJE());
		}
		if (!this.GIFPFPOPEJN)
		{
			this.MBFLANHHEBF();
			this.CHCBHLIBGFA = true;
		}
	}

	// Token: 0x06001AB6 RID: 6838 RVA: 0x000B9199 File Offset: 0x000B7399
	public List<IMMKFHKEEBF> ALBFAIPPLLA()
	{
		return this.FKDMPMKBCBL;
	}

	// Token: 0x06001AB7 RID: 6839 RVA: 0x000B91A1 File Offset: 0x000B73A1
	public bool EDLLCINPMNF()
	{
		return this.HBLHNFKEELE >= 0 || this.JECGGDNKBID();
	}

	// Token: 0x06001AB8 RID: 6840 RVA: 0x000B91B4 File Offset: 0x000B73B4
	public void GEJDNEOIHAE()
	{
		this.GACNBNBNOEF = new JSONArray();
		this.CHCBHLIBGFA = true;
	}

	// Token: 0x06001AB9 RID: 6841 RVA: 0x000B9199 File Offset: 0x000B7399
	public List<IMMKFHKEEBF> IBCNDFKHJJI()
	{
		return this.FKDMPMKBCBL;
	}

	// Token: 0x06001ABA RID: 6842 RVA: 0x000B91C8 File Offset: 0x000B73C8
	public List<string> MBDHFJEAJIH()
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 1; i < this.GLCKIAGABIC.Count; i++)
			{
				string text = this.GLCKIAGABIC[i];
				if (text.Contains("OnStoryScreenChoiceExtendedManagerLayerChangeComplete"))
				{
					string[] array = DPGJIJGOCIC.BALENNAODEJ(text, (char)-82);
					list.Add(array[0]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06001ABB RID: 6843 RVA: 0x000B923C File Offset: 0x000B743C
	public bool OHKBNAJEJGD(IMMKFHKEEBF FOEEIJFHMGG, bool BDFHENEFGKI = false)
	{
		if (!BDFHENEFGKI)
		{
			for (int i = 0; i < this.CHBNFGDAGOI.Count; i++)
			{
				if (this.CHBNFGDAGOI[i].Equals(FOEEIJFHMGG.DKDECIHBGJE()))
				{
					return true;
				}
			}
			if (this.GIFPFPOPEJN)
			{
				for (int j = 0; j < this.KBLIHBMONDJ.Count; j++)
				{
					if (this.KBLIHBMONDJ[j].Equals(FOEEIJFHMGG.DKDECIHBGJE()))
					{
						return true;
					}
				}
			}
			return false;
		}
		for (int k = 0; k < this.BEIEDDFCCFO.Count; k++)
		{
			if (this.BEIEDDFCCFO[k].Equals(FOEEIJFHMGG.DKDECIHBGJE()))
			{
				return true;
			}
		}
		if (this.GIFPFPOPEJN)
		{
			for (int l = 0; l < this.LALOCGIOJHO.Count; l++)
			{
				if (this.LALOCGIOJHO[l].Equals(FOEEIJFHMGG.DKDECIHBGJE()))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001ABC RID: 6844 RVA: 0x000B9338 File Offset: 0x000B7538
	public void CHGABDFMBJO(string KEGBCGMJOLC)
	{
		if (!DPGJIJGOCIC.LMCAODJLEGF(this.HOICLELFLOE).Equals(KEGBCGMJOLC) || this.BDILKANCEEC)
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, SetAvatarIcon()");
			this.CHCBHLIBGFA = true;
			this.HOICLELFLOE = DPGJIJGOCIC.FAIFJDPENOP(KEGBCGMJOLC);
			this.BDILKANCEEC = false;
		}
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x000B9384 File Offset: 0x000B7584
	private void JDPFJEGFPBI()
	{
		this.CJHNLPJFJLG = new List<FHAJAGIMLLJ>();
		List<int> list = new List<int>();
		for (int i = 0; i < this.KDLMOOMBCHA.Count; i++)
		{
			JSONObject asObject = this.KDLMOOMBCHA[i].AsObject;
			if (asObject["docid"].Length > 0)
			{
				AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(i);
				if (null != assetAnthology)
				{
					bool flag = false;
					if (assetAnthology.header.syncWithPrequel && assetAnthology.header.prequelIndex >= 0 && assetAnthology.header.completedStoryIndexRequirement >= 0)
					{
						flag = true;
					}
					if (!flag)
					{
						int item = FHAJAGIMLLJ.LHOOFBGJKOL(asObject["top"].AsInt);
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
			}
		}
		if (list.Count > 0)
		{
			list.Sort();
			list.Reverse();
			for (int j = 0; j < list.Count; j++)
			{
				FHAJAGIMLLJ fhajagimllj = new FHAJAGIMLLJ();
				fhajagimllj.MAOJHOAAIBA = list[j];
				this.CJHNLPJFJLG.Add(fhajagimllj);
			}
			for (int k = 0; k < this.KDLMOOMBCHA.Count; k++)
			{
				JSONObject asObject2 = this.KDLMOOMBCHA[k].AsObject;
				if (asObject2["docid"].Length > 0)
				{
					AssetAnthology assetAnthology2 = GKJPOGNFKNK.LDFIAOCJEOJ(k);
					if (null != assetAnthology2)
					{
						bool flag2 = false;
						if (assetAnthology2.header.syncWithPrequel && assetAnthology2.header.prequelIndex >= 0 && assetAnthology2.header.completedStoryIndexRequirement >= 0)
						{
							flag2 = true;
						}
						if (!flag2)
						{
							int num = FHAJAGIMLLJ.LHOOFBGJKOL(asObject2["top"].AsInt);
							for (int l = 0; l < this.CJHNLPJFJLG.Count; l++)
							{
								if (this.CJHNLPJFJLG[l].MAOJHOAAIBA == num)
								{
									this.CJHNLPJFJLG[l].NGNPBPLBGEB(k, asObject2["top"].AsInt);
									break;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x000B95B0 File Offset: 0x000B77B0
	public void IPNOKENGAPB()
	{
		this.FLJBGIKGPEM = new List<BNFCLKNDBLO>();
		List<BNFCLKNDBLO> list = new List<BNFCLKNDBLO>();
		List<int> list2 = new List<int>();
		for (int i = this.CJAANCAAJOF.Count - 1; i >= 0; i--)
		{
			BNFCLKNDBLO bnfclkndblo = new BNFCLKNDBLO();
			if (bnfclkndblo.EFGCFPKMCHM(this.CJAANCAAJOF[i]))
			{
				list.Add(bnfclkndblo);
				if (!list2.Contains(bnfclkndblo.AMKCLHLIIMN))
				{
					list2.Add(bnfclkndblo.AMKCLHLIIMN);
				}
			}
		}
		if (list2.Count > 0)
		{
			for (int j = 0; j < list2.Count; j++)
			{
				for (int k = 0; k < list.Count; k++)
				{
					if (list[k].AMKCLHLIIMN == list2[j])
					{
						this.FLJBGIKGPEM.Add(list[k]);
					}
				}
			}
		}
	}

	// Token: 0x06001ABF RID: 6847 RVA: 0x000B968C File Offset: 0x000B788C
	public void NKGDPNMBHFJ(List<string> KEGBCGMJOLC)
	{
		JSONArray jsonarray = DPGJIJGOCIC.DGCHKPPDFDB(KEGBCGMJOLC, 18);
		string text = jsonarray.ToString();
		string value = DPGJIJGOCIC.LPHPLHPMJLH(this.GACNBNBNOEF).ToString();
		if (!text.Equals(value))
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, SetFavoriteStories()");
			this.CHCBHLIBGFA = true;
			this.GACNBNBNOEF = DPGJIJGOCIC.NCDOOLMANDM(jsonarray);
		}
	}

	// Token: 0x06001AC0 RID: 6848 RVA: 0x000B96E0 File Offset: 0x000B78E0
	public void ACCOJOHJPGH(PMEPALPCEAF BEBLHBLODLJ)
	{
		this.OFOIECEHOCN = 0;
		if (BEBLHBLODLJ == null)
		{
			return;
		}
		this.CIKCGDECCMM = new List<int>();
		try
		{
			List<string> list;
			List<string> list2;
			if (this.CFDOLDIADOP().Count > BEBLHBLODLJ.CFDOLDIADOP().Count)
			{
				list = BEBLHBLODLJ.CFDOLDIADOP();
				list2 = this.CFDOLDIADOP();
			}
			else
			{
				list = this.CFDOLDIADOP();
				list2 = BEBLHBLODLJ.CFDOLDIADOP();
			}
			if (list.Count > 0)
			{
				float num = 0f;
				for (int i = 0; i < list2.Count; i++)
				{
					if (list.Contains(list2[i]))
					{
						num += 1f;
						this.CIKCGDECCMM.Add(int.Parse(list2[i].Replace("userpublicprofileanthology", "")));
					}
				}
				this.OFOIECEHOCN = (int)(num / (float)list.Count * 100f);
			}
			else
			{
				this.OFOIECEHOCN = 0;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x000B97D4 File Offset: 0x000B79D4
	public List<string> CFDOLDIADOP()
	{
		return DPGJIJGOCIC.POHBFGLLKFD(DPGJIJGOCIC.LPHPLHPMJLH(this.GACNBNBNOEF));
	}

	// Token: 0x06001AC2 RID: 6850 RVA: 0x000B97E8 File Offset: 0x000B79E8
	public List<string> DIDBCOPAICH()
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < this.GLCKIAGABIC.Count; i += 0)
			{
				string text = this.GLCKIAGABIC[i];
				if (text.Contains("loungetreasuresyouhave"))
				{
					string[] array = DPGJIJGOCIC.NHEBLMBJNPI(text, (char)-121);
					list.Add(array[1]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06001AC3 RID: 6851 RVA: 0x000B985C File Offset: 0x000B7A5C
	public void ODIAOMJMCPA()
	{
		this.GACNBNBNOEF = new JSONArray();
		this.CHCBHLIBGFA = false;
	}

	// Token: 0x06001AC4 RID: 6852 RVA: 0x000B9870 File Offset: 0x000B7A70
	private void BINBHBFLIHN()
	{
		this.PJKCNFBNLAN = new List<string>();
		for (int i = 0; i < this.BJFEHLNEINL.Count; i++)
		{
			FHHNOOKHGCE fhhnookhgce = new FHHNOOKHGCE();
			fhhnookhgce.HELBJBBCBHG(this.BJFEHLNEINL[i]);
			List<int> list = fhhnookhgce.NLOHOEAMJDB();
			for (int j = 0; j < list.Count; j++)
			{
				this.PJKCNFBNLAN.Add("a" + fhhnookhgce.IFCHGNCDMLJ.ToString() + "id" + list[j].ToString());
			}
		}
	}

	// Token: 0x06001AC5 RID: 6853 RVA: 0x000B9908 File Offset: 0x000B7B08
	public void FGJPKGLOGNC(JSONObject KEGBCGMJOLC)
	{
		this.GIFPFPOPEJN = (KEGBCGMJOLC["rand"] == 1);
		if (KEGBCGMJOLC["thmstr"] != null)
		{
			this.HOICLELFLOE = KEGBCGMJOLC["thmstr"];
		}
		try
		{
			if (KEGBCGMJOLC["nick"] != null && KEGBCGMJOLC["nick"].ToString().Length > 0)
			{
				this.KNCFKDLOPGA = Encoding.UTF8.GetString(Convert.FromBase64String(KEGBCGMJOLC["nick"]));
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.GFAABCCNNDA = KEGBCGMJOLC["lvl"].AsInt;
		this.GHCGBLBCHAE = KEGBCGMJOLC["top"].AsInt;
		this.HKDBHDBGIHG = KEGBCGMJOLC["com"].AsInt;
		this.AKFNGLGEIFG = KEGBCGMJOLC["ong"].AsInt;
		this.LCCKJBPOJIM = KEGBCGMJOLC["not"].AsInt;
		this.KDLMOOMBCHA = KEGBCGMJOLC["alvl"].AsArray;
		try
		{
			if (KEGBCGMJOLC["credo"] != null && KEGBCGMJOLC["credo"].ToString().Length > 0)
			{
				this.PEONEPNPGEC = Encoding.UTF8.GetString(Convert.FromBase64String(KEGBCGMJOLC["credo"]));
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		try
		{
			if (KEGBCGMJOLC["love"] != null && KEGBCGMJOLC["love"].ToString().Length > 0)
			{
				this.FPJMDDIILIK = Encoding.UTF8.GetString(Convert.FromBase64String(KEGBCGMJOLC["love"]));
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
		this.JEDFLIKKPEC = new JSONArray();
		if (KEGBCGMJOLC["favchrstr"] != null)
		{
			this.JEDFLIKKPEC = KEGBCGMJOLC["favchrstr"].AsArray;
			try
			{
				if (KEGBCGMJOLC["favchrstr2"] != null)
				{
					JSONArray jsonarray = new JSONArray();
					jsonarray = KEGBCGMJOLC["favchrstr2"].AsArray;
					for (int i = 0; i < jsonarray.Count; i++)
					{
						bool flag = false;
						string text = jsonarray[i];
						for (int j = 0; j < this.JEDFLIKKPEC.Count; j++)
						{
							string value = this.JEDFLIKKPEC[j];
							if (text.Equals(value))
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							this.JEDFLIKKPEC.Add(text);
						}
					}
				}
			}
			catch (Exception aklgbjkdomm4)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm4);
			}
		}
		this.GACNBNBNOEF = new JSONArray();
		if (KEGBCGMJOLC["favstostr"] != null)
		{
			this.GACNBNBNOEF = KEGBCGMJOLC["favstostr"].AsArray;
			try
			{
				if (KEGBCGMJOLC["favstostr2"] != null)
				{
					JSONArray jsonarray2 = new JSONArray();
					jsonarray2 = KEGBCGMJOLC["favstostr2"].AsArray;
					for (int k = 0; k < jsonarray2.Count; k++)
					{
						bool flag2 = false;
						string text2 = jsonarray2[k];
						for (int l = 0; l < this.GACNBNBNOEF.Count; l++)
						{
							string value2 = this.GACNBNBNOEF[l];
							if (text2.Equals(value2))
							{
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							this.GACNBNBNOEF.Add(text2);
						}
					}
				}
			}
			catch (Exception aklgbjkdomm5)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm5);
			}
		}
		this.JHAJBKDAECE = null;
		this.GLCKIAGABIC = new JSONArray();
		if (KEGBCGMJOLC["favcut"] != null)
		{
			this.GLCKIAGABIC = KEGBCGMJOLC["favcut"].AsArray;
			this.GLCKIAGABIC = DPGJIJGOCIC.PAPEMCELEKO(this.GLCKIAGABIC, 0, 18);
			this.KJANHNKJMKF();
		}
		this.CJAANCAAJOF = new JSONArray();
		if (KEGBCGMJOLC["cut"] != null)
		{
			this.CJAANCAAJOF = KEGBCGMJOLC["cut"].AsArray;
			if (!this.GIFPFPOPEJN)
			{
				PMEPALPCEAF.CPEMOAHNFAG = this.CJAANCAAJOF;
			}
		}
		else if (!this.GIFPFPOPEJN && PMEPALPCEAF.CPEMOAHNFAG != null)
		{
			this.CJAANCAAJOF = PMEPALPCEAF.CPEMOAHNFAG;
		}
		if (KEGBCGMJOLC["drs"] != null)
		{
			this.DBJMOAOBHKE = KEGBCGMJOLC["drs"].AsInt;
			this.DBJMOAOBHKE++;
		}
		if (KEGBCGMJOLC["lk"] != null)
		{
			this.MCMIMNEJJHK = KEGBCGMJOLC["lk"].AsInt;
		}
		if (KEGBCGMJOLC["ccc"] != null)
		{
			this.DIEPFILJNKG = KEGBCGMJOLC["ccc"].AsInt;
			this.BDILKANCEEC = false;
		}
		else
		{
			this.BDILKANCEEC = true;
		}
		if (KEGBCGMJOLC["suid"] != null)
		{
			this.LMFCFHMJIFN = KEGBCGMJOLC["suid"];
		}
		if (KEGBCGMJOLC["pid"] != null)
		{
			this.EEBMPDNLJGD = KEGBCGMJOLC["pid"];
		}
		if (KEGBCGMJOLC["acd"] != null)
		{
			this.PIJJLPGNKBI = KEGBCGMJOLC["acd"];
			if (this.PIJJLPGNKBI.Contains("T"))
			{
				this.PIJJLPGNKBI = this.PIJJLPGNKBI.Substring(0, this.PIJJLPGNKBI.IndexOf("T"));
				for (int m = 2018; m < 2050; m++)
				{
					if (this.PIJJLPGNKBI.Contains(m.ToString() ?? ""))
					{
						this.DELPFFPOEJJ = m;
						break;
					}
				}
			}
			else
			{
				this.PIJJLPGNKBI = "";
			}
		}
		if (KEGBCGMJOLC["lksrc"] != null)
		{
			this.KPOIHDJIMBF = KEGBCGMJOLC["lksrc"].AsArray;
		}
		if (KEGBCGMJOLC["ach"] != null)
		{
			this.BJFEHLNEINL = KEGBCGMJOLC["ach"].AsArray;
		}
		if (KEGBCGMJOLC["colcds"] != null)
		{
			this.KGHMOKADNKK = DPGJIJGOCIC.DDNFIDBDEGC(KEGBCGMJOLC["colcds"].AsArray);
		}
		if (KEGBCGMJOLC["wshcds"] != null)
		{
			this.PLLGPNGEHLL = KEGBCGMJOLC["wshcds"].AsArray;
			JSONArray jsonarray3 = new JSONArray();
			for (int n = 0; n < this.PLLGPNGEHLL.Count; n++)
			{
				if (!DPGJIJGOCIC.IADAELPFJAM(jsonarray3, this.PLLGPNGEHLL[n].AsInt))
				{
					jsonarray3.Add(this.PLLGPNGEHLL[n].AsInt);
				}
			}
			this.PLLGPNGEHLL = jsonarray3;
		}
		if (KEGBCGMJOLC["tdgcds"] != null)
		{
			this.FCJJDEKOIED = KEGBCGMJOLC["tdgcds"].AsArray;
			JSONArray jsonarray4 = new JSONArray();
			for (int num = 0; num < this.FCJJDEKOIED.Count; num++)
			{
				if (!DPGJIJGOCIC.IADAELPFJAM(jsonarray4, this.FCJJDEKOIED[num].AsInt))
				{
					jsonarray4.Add(this.FCJJDEKOIED[num].AsInt);
				}
			}
			this.FCJJDEKOIED = jsonarray4;
		}
		if (!this.GIFPFPOPEJN && KEGBCGMJOLC["bdgs"] != null)
		{
			this.CHPHILBOOFD = KEGBCGMJOLC["bdgs"].AsArray;
		}
		if (KEGBCGMJOLC["bdgsspr"] != null)
		{
			this.NPHNGJMGKCB = KEGBCGMJOLC["bdgsspr"].AsArray;
			try
			{
				if (this.GIFPFPOPEJN && AssetsManager.EHBBFMCILPC.lobbyDataAsset.CPJDIGHPOPF() == this.NPHNGJMGKCB.Count)
				{
					int num2 = 0;
					bool flag3 = false;
					for (int num3 = 0; num3 < this.NPHNGJMGKCB.Count; num3++)
					{
						string text3 = this.NPHNGJMGKCB[num3];
						if (text3.Contains("locked") && !text3.Contains("499"))
						{
							num2++;
						}
						else if (text3.Contains("locked") && text3.Contains("499"))
						{
							flag3 = true;
						}
					}
					if (num2 == 0 && flag3)
					{
						JSONArray jsonarray5 = new JSONArray();
						for (int num4 = 0; num4 < this.NPHNGJMGKCB.Count; num4++)
						{
							string text4 = this.NPHNGJMGKCB[num4];
							text4 = text4.Replace("locked", "");
							jsonarray5.Add(text4);
						}
						this.NPHNGJMGKCB = jsonarray5;
						DPGJIJGOCIC.ANOPFDLPKGC("Random profile: fixed the socialbadgelocked499 issue.");
					}
				}
			}
			catch (Exception aklgbjkdomm6)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm6);
			}
		}
		this.IPNOKENGAPB();
		this.JDPFJEGFPBI();
		this.BINBHBFLIHN();
		if (KEGBCGMJOLC["tmd"] != null)
		{
			this.CBLKLJADODP = KEGBCGMJOLC["tmd"].AsObject;
			if (this.GIFPFPOPEJN)
			{
				this.MGLLOMHPNHJ();
			}
		}
		if (KEGBCGMJOLC["rep"] != null)
		{
			this.LAKHGAPCKBC = (KEGBCGMJOLC["rep"].AsInt >= KDCJJBLGCBH.EHBBFMCILPC.IMPIECOIAHN());
			bool lakhgapckbc = this.LAKHGAPCKBC;
		}
		if (KEGBCGMJOLC["htme"] != null)
		{
			this.CHBNFGDAGOI = KEGBCGMJOLC["htme"].AsArray;
			if (this.GIFPFPOPEJN)
			{
				try
				{
					this.MGCCGKOEJCN(false);
					int num5 = 0;
					for (int num6 = 0; num6 < this.FKDMPMKBCBL.Count; num6++)
					{
						bool flag4 = false;
						for (int num7 = 0; num7 < this.CHBNFGDAGOI.Count; num7++)
						{
							if (this.CHBNFGDAGOI[num7].Equals(this.FKDMPMKBCBL[num6].DKDECIHBGJE()))
							{
								flag4 = true;
								break;
							}
						}
						if (!flag4)
						{
							num5++;
							if (num5 > 10)
							{
								this.KBLIHBMONDJ.Add(this.FKDMPMKBCBL[num6].DKDECIHBGJE());
							}
						}
					}
					DPGJIJGOCIC.ADFCDFHBDAF("hiddenTopMatchEntriesRandom:" + this.KBLIHBMONDJ.Count.ToString());
				}
				catch (Exception aklgbjkdomm7)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm7);
				}
			}
		}
		if (KEGBCGMJOLC["htmeo"] != null)
		{
			this.BEIEDDFCCFO = KEGBCGMJOLC["htmeo"].AsArray;
			if (this.GIFPFPOPEJN)
			{
				try
				{
					this.MGCCGKOEJCN(true);
					int num8 = 0;
					for (int num9 = 0; num9 < this.IOEACDCKKID.Count; num9++)
					{
						bool flag5 = false;
						for (int num10 = 0; num10 < this.BEIEDDFCCFO.Count; num10++)
						{
							if (this.BEIEDDFCCFO[num10].Equals(this.IOEACDCKKID[num9].DKDECIHBGJE()))
							{
								flag5 = true;
								break;
							}
						}
						if (!flag5)
						{
							num8++;
							if (num8 > 10)
							{
								this.LALOCGIOJHO.Add(this.IOEACDCKKID[num9].DKDECIHBGJE());
							}
						}
					}
					DPGJIJGOCIC.ADFCDFHBDAF("hiddenTopMatchOngoingEntriesRandom:" + this.LALOCGIOJHO.Count.ToString());
				}
				catch (Exception aklgbjkdomm8)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm8);
				}
			}
		}
		this.JBAFPBAMKKN = new JSONArray();
		if (KEGBCGMJOLC["foldcutsto"] != null)
		{
			this.JBAFPBAMKKN = KEGBCGMJOLC["foldcutsto"].AsArray;
		}
		if (!this.GIFPFPOPEJN)
		{
			if (KEGBCGMJOLC["fdata"] != null)
			{
				JSONObject asObject = KEGBCGMJOLC["fdata"].AsObject;
				this.JNNBNNDOGIM.FGJPKGLOGNC(this, asObject);
				if (this.JNNBNNDOGIM.FACIFBONANM())
				{
					this.EMNPICIEEOJ = this.JNNBNNDOGIM.MKABKEDMLMI();
				}
			}
		}
		else if (KEGBCGMJOLC["frcnt"] != null)
		{
			this.EMNPICIEEOJ = KEGBCGMJOLC["frcnt"].AsInt;
		}
		if (KEGBCGMJOLC["socdnd"] != null)
		{
			this.AEDLLHMMIKB = KEGBCGMJOLC["socdnd"].AsInt;
		}
		try
		{
			if (KEGBCGMJOLC["lang"] != null)
			{
				this.ICCJIBMFNLD = LanguageManager.FromString(KEGBCGMJOLC["lang"]);
			}
			else
			{
				this.ICCJIBMFNLD = CEIBHCNNIDC.count;
			}
		}
		catch (Exception aklgbjkdomm9)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm9);
		}
		if (KEGBCGMJOLC["hofr"] != null)
		{
			this.HBLHNFKEELE = KEGBCGMJOLC["hofr"].AsInt;
			return;
		}
		this.HBLHNFKEELE = -1;
	}

	// Token: 0x06001AC6 RID: 6854 RVA: 0x000BA6E8 File Offset: 0x000B88E8
	private JSONObject BHGKFJPJNHE()
	{
		JSONObject jsonobject = new JSONObject();
		JSONArray jsonarray = new JSONArray();
		for (int i = 0; i < this.FKDMPMKBCBL.Count; i++)
		{
			JSONObject jsonobject2 = new JSONObject();
			jsonobject2.Add("per", this.FKDMPMKBCBL[i].BIBKFNMPHIK);
			jsonobject2.Add("nam", this.FKDMPMKBCBL[i].ODGNIFJGEHL);
			jsonobject2.Add("lck", this.FKDMPMKBCBL[i].MJKICDJIFIP);
			jsonobject2.Add("spr", this.FKDMPMKBCBL[i].PFFCLABCNHI);
			jsonarray.Add(jsonobject2);
		}
		jsonobject.Add("tm", jsonarray);
		JSONArray jsonarray2 = new JSONArray();
		for (int j = 0; j < this.IOEACDCKKID.Count; j++)
		{
			JSONObject jsonobject3 = new JSONObject();
			jsonobject3.Add("per", this.IOEACDCKKID[j].BIBKFNMPHIK);
			jsonobject3.Add("nam", this.IOEACDCKKID[j].ODGNIFJGEHL);
			jsonobject3.Add("lck", this.IOEACDCKKID[j].MJKICDJIFIP);
			jsonobject3.Add("spr", this.IOEACDCKKID[j].PFFCLABCNHI);
			jsonarray2.Add(jsonobject3);
		}
		jsonobject.Add("tmo", jsonarray2);
		return jsonobject;
	}

	// Token: 0x06001AC7 RID: 6855 RVA: 0x000BA890 File Offset: 0x000B8A90
	public void MBFLANHHEBF()
	{
		try
		{
			LobbyTopMatchSelectorManager.InitializeInstance();
			if (LobbyTopMatchSelectorManager.InstanceInitialized())
			{
				LobbyTopMatchSelectorManager.EHBBFMCILPC.UpdatePlayerPrefsWithTopMatchData(this.FEOODADPGLI(), this.NLLELMAGIPJ());
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001AC8 RID: 6856 RVA: 0x000BA8D8 File Offset: 0x000B8AD8
	public List<int> PLFIEHIFIOB()
	{
		new List<int>();
		List<int> result = new List<int>();
		if (this.GIFPFPOPEJN)
		{
			result = DPGJIJGOCIC.DDNFIDBDEGC(this.PLLGPNGEHLL);
		}
		else
		{
			result = DPGJIJGOCIC.OELJEMHFDFL(AKLFPGMDKLA.EHBBFMCILPC.PLLGPNGEHLL);
		}
		return result;
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x000BA918 File Offset: 0x000B8B18
	public List<string> NLLELMAGIPJ()
	{
		List<string> list = new List<string>();
		List<string> collection = DPGJIJGOCIC.POHBFGLLKFD(this.CHBNFGDAGOI);
		List<string> collection2 = DPGJIJGOCIC.POHBFGLLKFD(this.BEIEDDFCCFO);
		list.AddRange(collection);
		list.AddRange(collection2);
		return list;
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x000BA950 File Offset: 0x000B8B50
	public int FCFOHLCCHEF(int[] IPNHBBDBIFE)
	{
		int num = 0;
		int result;
		try
		{
			for (int i = 0; i < this.PJKCNFBNLAN.Count; i++)
			{
				string text = this.PJKCNFBNLAN[i];
				text = text.Substring(0, text.IndexOf("id"));
				text = text.Replace("a", "");
				int num2 = int.Parse(text);
				bool flag = false;
				if (IPNHBBDBIFE != null)
				{
					for (int j = 0; j < IPNHBBDBIFE.Length; j++)
					{
						if (IPNHBBDBIFE[j] == num2)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag && null != GKJPOGNFKNK.LDFIAOCJEOJ(num2))
				{
					num++;
				}
			}
			result = num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = num;
		}
		return result;
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x000BAA0C File Offset: 0x000B8C0C
	public List<Sprite> JMJOEHHFJGC(bool AOLEPOLFDIJ)
	{
		List<Sprite> list = new List<Sprite>();
		if (!this.GIFPFPOPEJN)
		{
			int num = MEBMEBKKCKA.EHBBFMCILPC.FEDKEFDOBNJ();
			for (int i = 0; i < AssetsManager.EHBBFMCILPC.lobbyDataAsset.socialStatsBadges.Count; i++)
			{
				bool flag = true;
				int mgljgjmfacn = 0;
				if (i == 1)
				{
					mgljgjmfacn = this.CLCHHPKGBHJ(1);
				}
				if (i >= 100 && i < 200)
				{
					int num2 = i - 100;
					if (num2 < num)
					{
						if (!MEBMEBKKCKA.EHBBFMCILPC.EKCJFDBCCMF(num2, AppManager.EHBBFMCILPC.GetRevision()) || !MEBMEBKKCKA.EHBBFMCILPC.ANANPCLMLNN(num2))
						{
							flag = false;
						}
					}
					else
					{
						flag = false;
					}
				}
				if (flag)
				{
					if (IOGOGMEJCIK.EHBBFMCILPC.CHPHILBOOFD.Contains(i))
					{
						Sprite sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FILFGFIFKJK(i, mgljgjmfacn, true);
						if (null != sprite)
						{
							list.Add(sprite);
						}
					}
					else
					{
						Sprite sprite2 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FILFGFIFKJK(i, mgljgjmfacn, false);
						if (null != sprite2)
						{
							list.Add(sprite2);
						}
					}
				}
			}
			this.NPHNGJMGKCB = new JSONArray();
			for (int j = 0; j < list.Count; j++)
			{
				this.NPHNGJMGKCB.Add(list[j].name);
			}
		}
		else
		{
			for (int k = 0; k < this.NPHNGJMGKCB.Count; k++)
			{
				string hapadeofkbp = this.NPHNGJMGKCB[k];
				Sprite sprite3 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FILFGFIFKJK(hapadeofkbp);
				if (null != sprite3)
				{
					list.Add(sprite3);
				}
			}
		}
		return list;
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x000BABA8 File Offset: 0x000B8DA8
	public bool HBELJGFJILO(string HAPADEOFKBP)
	{
		for (int i = 0; i < this.PJKCNFBNLAN.Count; i++)
		{
			if (HAPADEOFKBP.EndsWith(this.PJKCNFBNLAN[i]))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001ACD RID: 6861 RVA: 0x000BABE4 File Offset: 0x000B8DE4
	public void GFMGENGBAKF(List<IMMKFHKEEBF> FPLJADFJCAE, IMMKFHKEEBF FOEEIJFHMGG)
	{
		try
		{
			for (int i = 0; i < FPLJADFJCAE.Count; i++)
			{
				if (FOEEIJFHMGG.DKDECIHBGJE().Equals(FPLJADFJCAE[i].DKDECIHBGJE()))
				{
					if (FOEEIJFHMGG.BIBKFNMPHIK > FPLJADFJCAE[i].BIBKFNMPHIK)
					{
						if (FOEEIJFHMGG.BIBKFNMPHIK >= 100)
						{
							IOGOGMEJCIK.EHBBFMCILPC.BCBDNKJNHJH(FOEEIJFHMGG);
						}
						DPGJIJGOCIC.ADFCDFHBDAF(string.Concat(new string[]
						{
							"AddNewMyProfileTopMatchEntryMutex() updating ",
							FOEEIJFHMGG.DKDECIHBGJE(),
							" percent (",
							FPLJADFJCAE[i].BIBKFNMPHIK.ToString(),
							"%) with better variation from another slot:",
							FOEEIJFHMGG.BIBKFNMPHIK.ToString(),
							"%"
						}));
						FPLJADFJCAE[i].BIBKFNMPHIK = FOEEIJFHMGG.BIBKFNMPHIK;
						FPLJADFJCAE[i].KDODAAICNDO = FOEEIJFHMGG.KDODAAICNDO;
						if (FPLJADFJCAE[i].DLFMMBBLIFH != FOEEIJFHMGG.DLFMMBBLIFH)
						{
							FPLJADFJCAE[i].DLFMMBBLIFH = FOEEIJFHMGG.DLFMMBBLIFH;
							FPLJADFJCAE[i].MJKICDJIFIP = FOEEIJFHMGG.MJKICDJIFIP;
						}
					}
					if (FOEEIJFHMGG.MJKICDJIFIP == 1 && FPLJADFJCAE[i].DLFMMBBLIFH == FOEEIJFHMGG.DLFMMBBLIFH)
					{
						FPLJADFJCAE[i].MJKICDJIFIP = 1;
						DPGJIJGOCIC.ADFCDFHBDAF("AddNewMyProfileTopMatchEntryMutex() skip adding " + FOEEIJFHMGG.DKDECIHBGJE() + ", already present in top match list. But modifying the locked love interest condition to true.");
					}
					else
					{
						DPGJIJGOCIC.ADFCDFHBDAF("AddNewMyProfileTopMatchEntryMutex() skip adding " + FOEEIJFHMGG.DKDECIHBGJE() + ", already present in top match list.");
					}
					return;
				}
			}
			FPLJADFJCAE.Add(FOEEIJFHMGG);
			if (FOEEIJFHMGG.BIBKFNMPHIK >= 100)
			{
				IOGOGMEJCIK.EHBBFMCILPC.BCBDNKJNHJH(FOEEIJFHMGG);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x000B8B7F File Offset: 0x000B6D7F
	public List<FHAJAGIMLLJ> EHHGGNCFCMB()
	{
		return this.CJHNLPJFJLG;
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x000BADAC File Offset: 0x000B8FAC
	private void MGLLOMHPNHJ()
	{
		DPGJIJGOCIC.ADFCDFHBDAF("InitTopMatchDataCloud()");
		JSONArray jsonarray = new JSONArray();
		if (this.CBLKLJADODP["tm"] != null)
		{
			jsonarray = this.CBLKLJADODP["tm"].AsArray;
		}
		this.FKDMPMKBCBL = new List<IMMKFHKEEBF>();
		for (int i = 0; i < jsonarray.Count; i++)
		{
			JSONObject asObject = jsonarray[i].AsObject;
			IMMKFHKEEBF immkfhkeebf = new IMMKFHKEEBF();
			immkfhkeebf.BIBKFNMPHIK = asObject["per"].AsInt;
			immkfhkeebf.ODGNIFJGEHL = asObject["nam"];
			immkfhkeebf.PFFCLABCNHI = asObject["spr"];
			if (asObject["lck"] != null)
			{
				immkfhkeebf.MJKICDJIFIP = asObject["lck"].AsInt;
			}
			this.FKDMPMKBCBL.Add(immkfhkeebf);
		}
		JSONArray jsonarray2 = new JSONArray();
		if (this.CBLKLJADODP["tmo"] != null)
		{
			jsonarray2 = this.CBLKLJADODP["tmo"].AsArray;
		}
		this.IOEACDCKKID = new List<IMMKFHKEEBF>();
		for (int j = 0; j < jsonarray2.Count; j++)
		{
			JSONObject asObject2 = jsonarray2[j].AsObject;
			IMMKFHKEEBF immkfhkeebf2 = new IMMKFHKEEBF();
			immkfhkeebf2.BIBKFNMPHIK = asObject2["per"].AsInt;
			immkfhkeebf2.ODGNIFJGEHL = asObject2["nam"];
			immkfhkeebf2.PFFCLABCNHI = asObject2["spr"];
			if (asObject2["lck"] != null)
			{
				immkfhkeebf2.MJKICDJIFIP = asObject2["lck"].AsInt;
			}
			this.IOEACDCKKID.Add(immkfhkeebf2);
		}
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x000BAF9C File Offset: 0x000B919C
	public void GDIKJNLCAFA(List<string> KEGBCGMJOLC)
	{
		JSONArray jsonarray = DPGJIJGOCIC.DGCHKPPDFDB(KEGBCGMJOLC, 18);
		string text = jsonarray.ToString();
		string value = DPGJIJGOCIC.LPHPLHPMJLH(this.JEDFLIKKPEC).ToString();
		if (!text.Equals(value))
		{
			DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, SetFavoriteCharacters()");
			this.CHCBHLIBGFA = true;
			this.JEDFLIKKPEC = DPGJIJGOCIC.NCDOOLMANDM(jsonarray);
		}
	}

	// Token: 0x06001AD1 RID: 6865 RVA: 0x000BAFF0 File Offset: 0x000B91F0
	public void AMDKKJPIKPL(JSONArray GOJLCFCFNCE)
	{
		try
		{
			JSONArray jsonarray = new JSONArray();
			List<string> list = new List<string>();
			if (null != GOJLCFCFNCE)
			{
				for (int i = 1; i < GOJLCFCFNCE.Count; i += 0)
				{
					JSONArray asArray = GOJLCFCFNCE[i].AsArray;
					if (null != asArray)
					{
						for (int j = 1; j < asArray.Count; j++)
						{
							this.CJAANCAAJOF.Add(asArray[j]);
						}
					}
				}
			}
			for (int k = 0; k < this.CJAANCAAJOF.Count; k += 0)
			{
				string text = this.CJAANCAAJOF[k];
				if (!list.Contains(text))
				{
					list.Add(text);
					jsonarray.Add(text);
				}
				else
				{
					this.HJFAJHLBJAG = true;
					DPGJIJGOCIC.ANOPFDLPKGC("Error. FlipEnvironment(), environment " + text);
				}
			}
			this.CJAANCAAJOF = jsonarray;
			if (!this.GIFPFPOPEJN)
			{
				PMEPALPCEAF.CPEMOAHNFAG = this.CJAANCAAJOF;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06001AD2 RID: 6866 RVA: 0x000BB0FC File Offset: 0x000B92FC
	public List<IMMKFHKEEBF> FEOODADPGLI()
	{
		List<IMMKFHKEEBF> list = new List<IMMKFHKEEBF>();
		list.AddRange(this.FKDMPMKBCBL);
		list.AddRange(this.IOEACDCKKID);
		return list;
	}

	// Token: 0x06001AD3 RID: 6867 RVA: 0x000BB11B File Offset: 0x000B931B
	public bool BONEGBHNHNM()
	{
		return this.HBLHNFKEELE < 0 && this.JECGGDNKBID();
	}

	// Token: 0x06001AD4 RID: 6868 RVA: 0x000BB130 File Offset: 0x000B9330
	public JSONObject BNMFBKNEMIF()
	{
		JSONObject jsonobject = new JSONObject();
		jsonobject.Add("thmstr", this.HOICLELFLOE);
		if (MEAHFFHIACD.EHBBFMCILPC.IAEEEIAAAIA(this.PEONEPNPGEC, LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) || MEAHFFHIACD.EHBBFMCILPC.IAEEEIAAAIA(this.FPJMDDIILIK, LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) || MEAHFFHIACD.EHBBFMCILPC.IAEEEIAAAIA(this.KNCFKDLOPGA, LanguageManager.EHBBFMCILPC.GetSelectedLanguage()) || AKLFPGMDKLA.EHBBFMCILPC.GNLNPMPJPEC() || this.LAKHGAPCKBC)
		{
			jsonobject.Add("off", 1);
		}
		else
		{
			jsonobject.Add("off", 0);
		}
		if (this.KNCFKDLOPGA.Length > 0)
		{
			jsonobject.Add("nick", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.KNCFKDLOPGA)));
			jsonobject.Add("nick2", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.KNCFKDLOPGA.ToLowerInvariant())));
		}
		else
		{
			jsonobject.Add("nick", "");
			jsonobject.Add("nick2", "");
		}
		if (this.PEONEPNPGEC.Length > 0)
		{
			jsonobject.Add("credo", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.PEONEPNPGEC)));
		}
		else
		{
			jsonobject.Add("credo", "");
		}
		if (this.FPJMDDIILIK.Length > 0)
		{
			jsonobject.Add("love", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.FPJMDDIILIK)));
		}
		else
		{
			jsonobject.Add("love", "");
		}
		jsonobject.Add("com", this.HKDBHDBGIHG);
		jsonobject.Add("ong", this.AKFNGLGEIFG);
		jsonobject.Add("not", this.LCCKJBPOJIM);
		jsonobject.Add("favchrstr", DPGJIJGOCIC.PAPEMCELEKO(this.JEDFLIKKPEC, 0, 6));
		jsonobject.Add("favchrstr2", DPGJIJGOCIC.PAPEMCELEKO(this.JEDFLIKKPEC, 6, 12));
		jsonobject.Add("favstostr", DPGJIJGOCIC.PAPEMCELEKO(this.GACNBNBNOEF, 0, 6));
		jsonobject.Add("favstostr2", DPGJIJGOCIC.PAPEMCELEKO(this.GACNBNBNOEF, 6, 12));
		jsonobject.Add("favcut", DPGJIJGOCIC.PAPEMCELEKO(this.GLCKIAGABIC, 0, 18));
		this.DMEAMGKEALB(jsonobject);
		jsonobject.Add("ccc", this.DIEPFILJNKG);
		jsonobject.Add("tmd", this.BHGKFJPJNHE());
		jsonobject.Add("htme", this.CHBNFGDAGOI);
		jsonobject.Add("htmeo", this.BEIEDDFCCFO);
		jsonobject.Add("foldcutsto", this.JBAFPBAMKKN);
		jsonobject.Add("bdgsspr", this.NPHNGJMGKCB);
		jsonobject.Add("frcnt", this.MKABKEDMLMI());
		JSONArray aItem = new JSONArray();
		if (this.IDPMKIAAIFN)
		{
			jsonobject.Add("ffavmod", 1);
			if (this.JNNBNNDOGIM != null && this.JNNBNNDOGIM.KHMLEDDFBPJ.Count > 0)
			{
				int ajpngblhoec = KDCJJBLGCBH.EHBBFMCILPC.KLEBNDJIOPB(AKLFPGMDKLA.EHBBFMCILPC.AFKCCPIMDJH());
				aItem = DPGJIJGOCIC.DGCHKPPDFDB(this.JNNBNNDOGIM.KHMLEDDFBPJ, ajpngblhoec);
			}
		}
		else
		{
			jsonobject.Add("ffavmod", 0);
		}
		jsonobject.Add("ffav", aItem);
		this.IDPMKIAAIFN = false;
		jsonobject.Add("tdgcds", AKLFPGMDKLA.EHBBFMCILPC.FCJJDEKOIED);
		jsonobject.Add("wshcds", AKLFPGMDKLA.EHBBFMCILPC.PLLGPNGEHLL);
		jsonobject.Add("socdnd", this.AEDLLHMMIKB);
		return jsonobject;
	}

	// Token: 0x06001AD5 RID: 6869 RVA: 0x000BB510 File Offset: 0x000B9710
	public bool MJANECGKMGF(bool BDFHENEFGKI = false)
	{
		bool result;
		try
		{
			if (!BDFHENEFGKI)
			{
				if (!this.GIFPFPOPEJN)
				{
					result = true;
				}
				else
				{
					DPGJIJGOCIC.ADFCDFHBDAF("TopMatchEntriesAvailableForDisplay(): " + (this.FKDMPMKBCBL.Count - this.CHBNFGDAGOI.Count).ToString() + " topMatch to display.");
					result = (this.FKDMPMKBCBL.Count > this.CHBNFGDAGOI.Count);
				}
			}
			else if (!this.GIFPFPOPEJN)
			{
				result = true;
			}
			else
			{
				DPGJIJGOCIC.ADFCDFHBDAF("TopMatchEntriesAvailableForDisplay(): " + (this.IOEACDCKKID.Count - this.BEIEDDFCCFO.Count).ToString() + " topMatchOngoing to display.");
				result = (this.IOEACDCKKID.Count > this.BEIEDDFCCFO.Count);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06001AD6 RID: 6870 RVA: 0x000BB5F4 File Offset: 0x000B97F4
	public void HMEJIGIOIOE(int PLKMJJIIJNO)
	{
		if (PLKMJJIIJNO < 0)
		{
			return;
		}
		if (!this.AMBKNMKIDPH(PLKMJJIIJNO))
		{
			this.JBAFPBAMKKN.Add(PLKMJJIIJNO);
		}
		this.CHCBHLIBGFA = true;
	}

	// Token: 0x06001AD7 RID: 6871 RVA: 0x000BB61C File Offset: 0x000B981C
	public void NGACBBJKKGN(JSONArray KEGBCGMJOLC)
	{
		this.AEBIJGBDNCF = new List<ICGCJJLADEG>();
		try
		{
			for (int i = 0; i < KEGBCGMJOLC.Count; i++)
			{
				JSONObject asObject = KEGBCGMJOLC[i].AsObject;
				this.AEBIJGBDNCF.Add(new ICGCJJLADEG());
				this.AEBIJGBDNCF[this.AEBIJGBDNCF.Count - 1].KIPCNAMEGPD = Encoding.UTF8.GetString(Convert.FromBase64String(asObject["msg64"]));
				this.AEBIJGBDNCF[this.AEBIJGBDNCF.Count - 1].DNGFNDAMEPK = asObject["our"].AsInt;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06001AD8 RID: 6872 RVA: 0x000BB6EC File Offset: 0x000B98EC
	public void KJANHNKJMKF()
	{
		bool gifpfpopejn = this.GIFPFPOPEJN;
	}

	// Token: 0x06001AD9 RID: 6873 RVA: 0x000BB6F5 File Offset: 0x000B98F5
	public int MKABKEDMLMI()
	{
		if (this.GIFPFPOPEJN)
		{
			return this.EMNPICIEEOJ;
		}
		if (this.JNNBNNDOGIM.FACIFBONANM())
		{
			return this.JNNBNNDOGIM.MKABKEDMLMI();
		}
		return 0;
	}

	// Token: 0x06001ADA RID: 6874 RVA: 0x000BB720 File Offset: 0x000B9920
	public int MBDLEGCAHLH()
	{
		return this.CJAANCAAJOF.Count;
	}

	// Token: 0x06001ADB RID: 6875 RVA: 0x000BB730 File Offset: 0x000B9930
	private void FNLINLCFDJI()
	{
		this.CJHNLPJFJLG = new List<FHAJAGIMLLJ>();
		List<int> list = new List<int>();
		for (int i = 0; i < this.KDLMOOMBCHA.Count; i += 0)
		{
			JSONObject asObject = this.KDLMOOMBCHA[i].AsObject;
			if (asObject["BackendOperationsManager.RequestUnlockCardsVolume, exception while initializing RSACryptoServiceProvider:"].Length > 1)
			{
				AssetAnthology assetAnthology = GKJPOGNFKNK.LDFIAOCJEOJ(i);
				if (null != assetAnthology)
				{
					bool flag = true;
					if (assetAnthology.header.syncWithPrequel && assetAnthology.header.prequelIndex >= 1 && assetAnthology.header.completedStoryIndexRequirement >= 0)
					{
						flag = false;
					}
					if (!flag)
					{
						int item = FHAJAGIMLLJ.LHOOFBGJKOL(asObject["OnCutsceneViewAssetBundleFolderInitializeSuccess"].AsInt);
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
			}
		}
		if (list.Count > 0)
		{
			list.Sort();
			list.Reverse();
			for (int j = 1; j < list.Count; j += 0)
			{
				FHAJAGIMLLJ fhajagimllj = new FHAJAGIMLLJ();
				fhajagimllj.MAOJHOAAIBA = list[j];
				this.CJHNLPJFJLG.Add(fhajagimllj);
			}
			for (int k = 0; k < this.KDLMOOMBCHA.Count; k++)
			{
				JSONObject asObject2 = this.KDLMOOMBCHA[k].AsObject;
				if (asObject2[""].Length > 1)
				{
					AssetAnthology assetAnthology2 = GKJPOGNFKNK.LDFIAOCJEOJ(k);
					if (null != assetAnthology2)
					{
						bool flag2 = true;
						if (assetAnthology2.header.syncWithPrequel && assetAnthology2.header.prequelIndex >= 1 && assetAnthology2.header.completedStoryIndexRequirement >= 0)
						{
							flag2 = true;
						}
						if (!flag2)
						{
							int num = FHAJAGIMLLJ.BFHJGDJEMLH(asObject2["aind2"].AsInt);
							for (int l = 0; l < this.CJHNLPJFJLG.Count; l += 0)
							{
								if (this.CJHNLPJFJLG[l].MAOJHOAAIBA == num)
								{
									this.CJHNLPJFJLG[l].HBCJGAPICAM(k, asObject2["wofrewardmsgcard3"].AsInt);
									break;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001ADC RID: 6876 RVA: 0x000BB95B File Offset: 0x000B9B5B
	public string PGJBIPFBMAN()
	{
		return DPGJIJGOCIC.LMCAODJLEGF(this.HOICLELFLOE);
	}

	// Token: 0x06001ADD RID: 6877 RVA: 0x000BB968 File Offset: 0x000B9B68
	public List<string> PEBKLGDBGHC()
	{
		List<string> result;
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < this.PJKCNFBNLAN.Count; i++)
			{
				string text = this.PJKCNFBNLAN[i];
				text = text.Substring(0, text.IndexOf("id"));
				text = text.Replace("a", "");
				int plkmjjiijno = int.Parse(text);
				if (null != GKJPOGNFKNK.LDFIAOCJEOJ(plkmjjiijno))
				{
					list.Add(this.PJKCNFBNLAN[i]);
				}
			}
			result = list;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = this.PJKCNFBNLAN;
		}
		return result;
	}

	// Token: 0x06001ADE RID: 6878 RVA: 0x000BBA10 File Offset: 0x000B9C10
	public void JBNIADKCJJO(List<string> MKDDECHEBEE)
	{
		for (int i = 0; i < MKDDECHEBEE.Count; i++)
		{
			BNFCLKNDBLO bnfclkndblo = new BNFCLKNDBLO();
			if (bnfclkndblo.EFGCFPKMCHM(MKDDECHEBEE[i]) && !this.OMHGNHIDOEF(bnfclkndblo.IAGMLHAEOJI))
			{
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.modified = true, SyncCutscenes()");
				this.CHCBHLIBGFA = (this.HJFAJHLBJAG = true);
				this.CJAANCAAJOF.Add(MKDDECHEBEE[i]);
				DPGJIJGOCIC.NFIDPOMCNLP("SocialStatsUserPublicProfile.SyncCutscenes(): Syncing new cutscene: " + bnfclkndblo.IAGMLHAEOJI);
			}
		}
		if (this.HJFAJHLBJAG)
		{
			this.IPNOKENGAPB();
		}
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x000BBAA8 File Offset: 0x000B9CA8
	private void DMEAMGKEALB(JSONObject KEGBCGMJOLC)
	{
		if (!this.HJFAJHLBJAG)
		{
			return;
		}
		int num = 10;
		JSONArray jsonarray = new JSONArray();
		JSONArray jsonarray2 = new JSONArray();
		for (int i = 0; i < this.CJAANCAAJOF.Count; i++)
		{
			if (jsonarray.Count == num)
			{
				if (KEGBCGMJOLC["cut"] == null)
				{
					KEGBCGMJOLC.Add("cut", jsonarray);
				}
				else
				{
					jsonarray2.Add(jsonarray);
				}
				jsonarray = new JSONArray();
				num = 200;
			}
			jsonarray.Add(this.CJAANCAAJOF[i]);
		}
		if (KEGBCGMJOLC["cut"] == null)
		{
			KEGBCGMJOLC.Add("cut", jsonarray);
		}
		else if (jsonarray.Count > 0)
		{
			jsonarray2.Add(jsonarray);
		}
		KEGBCGMJOLC.Add("cuta", jsonarray2);
	}

	// Token: 0x06001AE0 RID: 6880 RVA: 0x000BBB70 File Offset: 0x000B9D70
	public bool AMBKNMKIDPH(int PLKMJJIIJNO)
	{
		for (int i = 0; i < this.JBAFPBAMKKN.Count; i++)
		{
			if (this.JBAFPBAMKKN[i].AsInt == PLKMJJIIJNO)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x000BBBAC File Offset: 0x000B9DAC
	public List<string> PEGCNCPFHME()
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < this.GLCKIAGABIC.Count; i += 0)
			{
				string text = this.GLCKIAGABIC[i];
				if (text.Contains("FranchisesHub.Populate() - fid "))
				{
					string[] array = DPGJIJGOCIC.BALENNAODEJ(text, (char)-23);
					list.Add(array[1]);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x0400076F RID: 1903
	public bool BDILKANCEEC;

	// Token: 0x04000770 RID: 1904
	public string HOICLELFLOE = "";

	// Token: 0x04000771 RID: 1905
	public string KNCFKDLOPGA = "";

	// Token: 0x04000772 RID: 1906
	public int GFAABCCNNDA;

	// Token: 0x04000773 RID: 1907
	public int GHCGBLBCHAE = 100;

	// Token: 0x04000774 RID: 1908
	public int HKDBHDBGIHG;

	// Token: 0x04000775 RID: 1909
	public int AKFNGLGEIFG;

	// Token: 0x04000776 RID: 1910
	public int LCCKJBPOJIM;

	// Token: 0x04000777 RID: 1911
	public JSONArray KDLMOOMBCHA = new JSONArray();

	// Token: 0x04000778 RID: 1912
	public JSONArray KPOIHDJIMBF = new JSONArray();

	// Token: 0x04000779 RID: 1913
	public string PEONEPNPGEC = "";

	// Token: 0x0400077A RID: 1914
	public string FPJMDDIILIK = "";

	// Token: 0x0400077B RID: 1915
	public int DBJMOAOBHKE = -1;

	// Token: 0x0400077C RID: 1916
	public int MCMIMNEJJHK;

	// Token: 0x0400077D RID: 1917
	public int DIEPFILJNKG;

	// Token: 0x0400077E RID: 1918
	public string LMFCFHMJIFN = "";

	// Token: 0x0400077F RID: 1919
	public string MIOEBKPPEHO = "";

	// Token: 0x04000780 RID: 1920
	public string EEBMPDNLJGD = "";

	// Token: 0x04000781 RID: 1921
	public string PIJJLPGNKBI = "";

	// Token: 0x04000782 RID: 1922
	public int DELPFFPOEJJ = 2018;

	// Token: 0x04000783 RID: 1923
	public bool GIFPFPOPEJN;

	// Token: 0x04000784 RID: 1924
	public bool CHCBHLIBGFA;

	// Token: 0x04000785 RID: 1925
	public bool HJFAJHLBJAG;

	// Token: 0x04000786 RID: 1926
	public bool IDPMKIAAIFN;

	// Token: 0x04000787 RID: 1927
	public bool LAKHGAPCKBC;

	// Token: 0x04000788 RID: 1928
	private JSONArray JEDFLIKKPEC = new JSONArray();

	// Token: 0x04000789 RID: 1929
	private JSONArray GACNBNBNOEF = new JSONArray();

	// Token: 0x0400078A RID: 1930
	private JSONArray GLCKIAGABIC = new JSONArray();

	// Token: 0x0400078B RID: 1931
	private JSONArray JHAJBKDAECE;

	// Token: 0x0400078C RID: 1932
	private JSONArray CJAANCAAJOF = new JSONArray();

	// Token: 0x0400078D RID: 1933
	public static JSONArray CPEMOAHNFAG;

	// Token: 0x0400078E RID: 1934
	private JSONArray BJFEHLNEINL = new JSONArray();

	// Token: 0x0400078F RID: 1935
	private JSONObject CBLKLJADODP = new JSONObject();

	// Token: 0x04000790 RID: 1936
	private JSONArray CHBNFGDAGOI = new JSONArray();

	// Token: 0x04000791 RID: 1937
	private JSONArray BEIEDDFCCFO = new JSONArray();

	// Token: 0x04000792 RID: 1938
	public BHHJENAAKLH JNNBNNDOGIM = new BHHJENAAKLH();

	// Token: 0x04000793 RID: 1939
	public JSONArray CHPHILBOOFD = new JSONArray();

	// Token: 0x04000794 RID: 1940
	public JSONArray NPHNGJMGKCB = new JSONArray();

	// Token: 0x04000795 RID: 1941
	public ILCFDPELMMG IFEEIAPMIML;

	// Token: 0x04000796 RID: 1942
	public string BONNGONEJBO = "";

	// Token: 0x04000797 RID: 1943
	private int EMNPICIEEOJ;

	// Token: 0x04000798 RID: 1944
	private List<BNFCLKNDBLO> FLJBGIKGPEM = new List<BNFCLKNDBLO>();

	// Token: 0x04000799 RID: 1945
	private List<FHAJAGIMLLJ> CJHNLPJFJLG = new List<FHAJAGIMLLJ>();

	// Token: 0x0400079A RID: 1946
	private List<int> KGHMOKADNKK = new List<int>();

	// Token: 0x0400079B RID: 1947
	private JSONArray PLLGPNGEHLL = new JSONArray();

	// Token: 0x0400079C RID: 1948
	private JSONArray FCJJDEKOIED = new JSONArray();

	// Token: 0x0400079D RID: 1949
	private List<string> PJKCNFBNLAN = new List<string>();

	// Token: 0x0400079E RID: 1950
	private List<IMMKFHKEEBF> FKDMPMKBCBL = new List<IMMKFHKEEBF>();

	// Token: 0x0400079F RID: 1951
	private List<IMMKFHKEEBF> IOEACDCKKID = new List<IMMKFHKEEBF>();

	// Token: 0x040007A0 RID: 1952
	private bool HBBADIACPDG;

	// Token: 0x040007A1 RID: 1953
	private JSONArray KBLIHBMONDJ = new JSONArray();

	// Token: 0x040007A2 RID: 1954
	private JSONArray LALOCGIOJHO = new JSONArray();

	// Token: 0x040007A3 RID: 1955
	public int OFOIECEHOCN;

	// Token: 0x040007A4 RID: 1956
	public List<int> CIKCGDECCMM = new List<int>();

	// Token: 0x040007A5 RID: 1957
	private JSONArray JBAFPBAMKKN = new JSONArray();

	// Token: 0x040007A6 RID: 1958
	public int AEDLLHMMIKB;

	// Token: 0x040007A7 RID: 1959
	public int HBLHNFKEELE = -1;

	// Token: 0x040007A8 RID: 1960
	public CEIBHCNNIDC ICCJIBMFNLD;

	// Token: 0x040007A9 RID: 1961
	public List<ICGCJJLADEG> AEBIJGBDNCF = new List<ICGCJJLADEG>();
}
