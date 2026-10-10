using System;
using System.Collections.Generic;

namespace AppsFlyerSDK
{
	// Token: 0x02000015 RID: 21
	public class CHELAOBJCBK : EventArgs
	{
		// Token: 0x06000276 RID: 630 RVA: 0x00009157 File Offset: 0x00007357
		public MLOBDOPIAJF MDAILEHEOCO()
		{
			return this.<ALNIKHNKLKJ>k__BackingField;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000915F File Offset: 0x0000735F
		public string HNICFIGILFM()
		{
			return this.DJHKIHHAAOE("deep_link_value");
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000916C File Offset: 0x0000736C
		public AKFKPPMLPJP IFFDJGPNONC { get; }

		// Token: 0x06000279 RID: 633 RVA: 0x00009174 File Offset: 0x00007374
		public string OKALDKJHNLG()
		{
			return this.DJHKIHHAAOE("af_sub1");
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00009157 File Offset: 0x00007357
		public MLOBDOPIAJF GCFILGFLALC { get; }

		// Token: 0x0600027B RID: 635 RVA: 0x0000916C File Offset: 0x0000736C
		public AKFKPPMLPJP JGDKHLMCKFP()
		{
			return this.<AIANCJOAPCP>k__BackingField;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00009181 File Offset: 0x00007381
		public string BKLLLHEMGBG()
		{
			return this.DJHKIHHAAOE("x4");
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000918E File Offset: 0x0000738E
		public string GIINBANHCID()
		{
			return this.DJHKIHHAAOE("campaign_id");
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000919B File Offset: 0x0000739B
		private string DJHKIHHAAOE(string ODGNIFJGEHL)
		{
			if (this.KKEKGPHOLDN != null && this.KKEKGPHOLDN.ContainsKey(ODGNIFJGEHL) && this.KKEKGPHOLDN[ODGNIFJGEHL] != null)
			{
				return this.KKEKGPHOLDN[ODGNIFJGEHL].ToString();
			}
			return null;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000091D4 File Offset: 0x000073D4
		public string LPECKLOPAAN()
		{
			return this.DJHKIHHAAOE("true");
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000919B File Offset: 0x0000739B
		private string NGMGAOMFIPP(string ODGNIFJGEHL)
		{
			if (this.KKEKGPHOLDN != null && this.KKEKGPHOLDN.ContainsKey(ODGNIFJGEHL) && this.KKEKGPHOLDN[ODGNIFJGEHL] != null)
			{
				return this.KKEKGPHOLDN[ODGNIFJGEHL].ToString();
			}
			return null;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000091E1 File Offset: 0x000073E1
		public string AGDBDEPILMA()
		{
			return this.DJHKIHHAAOE("false");
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000091EE File Offset: 0x000073EE
		public string JJMFLBOKNBK()
		{
			return this.CHDNGNHBPDJ("");
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000091FB File Offset: 0x000073FB
		public string BGMBLJKONLH()
		{
			return this.NGMGAOMFIPP("onAppOpenAttributionFailure");
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00009208 File Offset: 0x00007408
		public string IPAOJKDBNCL()
		{
			return this.CHDNGNHBPDJ("af_sub5");
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00009215 File Offset: 0x00007415
		public string FNMPFPEDOOL()
		{
			return this.DJHKIHHAAOE("\\r");
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000916C File Offset: 0x0000736C
		public AKFKPPMLPJP FGENGMKKMAB()
		{
			return this.<AIANCJOAPCP>k__BackingField;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00009222 File Offset: 0x00007422
		public string NGFCABDKAAF()
		{
			return this.NGMGAOMFIPP("\\f");
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000922F File Offset: 0x0000742F
		public string AGDFNFOJFBC()
		{
			return this.NGMGAOMFIPP("af_sub1");
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000091E1 File Offset: 0x000073E1
		public string PJPPOEFEMPL()
		{
			return this.DJHKIHHAAOE("false");
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000923C File Offset: 0x0000743C
		public string OGADPIMFBEJ()
		{
			return this.DJHKIHHAAOE("campaign");
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000924C File Offset: 0x0000744C
		public bool KAJICMPNAIN()
		{
			if (this.KKEKGPHOLDN != null && this.KKEKGPHOLDN.ContainsKey("is_deferred"))
			{
				try
				{
					return (bool)this.KKEKGPHOLDN["is_deferred"];
				}
				catch (Exception arg)
				{
					AppsFlyer.AFLog("DeepLinkEventsArgs.isDeferred", string.Format("{0} Exception caught.", arg));
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000916C File Offset: 0x0000736C
		public AKFKPPMLPJP MHBAJOOJBJG()
		{
			return this.<AIANCJOAPCP>k__BackingField;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000092B8 File Offset: 0x000074B8
		public string LPLPNHHMLKA()
		{
			return this.DJHKIHHAAOE("af_sub2");
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000092C5 File Offset: 0x000074C5
		public string NFCNKJOLCFL()
		{
			return this.DJHKIHHAAOE("\\u");
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000092D2 File Offset: 0x000074D2
		public string AOHGLLHFDPL()
		{
			return this.CHDNGNHBPDJ("AppsFlyer_Unity_v{0} {1} called with {2}");
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000916C File Offset: 0x0000736C
		public AKFKPPMLPJP HDFAIENBFHA()
		{
			return this.<AIANCJOAPCP>k__BackingField;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000919B File Offset: 0x0000739B
		private string CHDNGNHBPDJ(string ODGNIFJGEHL)
		{
			if (this.KKEKGPHOLDN != null && this.KKEKGPHOLDN.ContainsKey(ODGNIFJGEHL) && this.KKEKGPHOLDN[ODGNIFJGEHL] != null)
			{
				return this.KKEKGPHOLDN[ODGNIFJGEHL].ToString();
			}
			return null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000092DF File Offset: 0x000074DF
		public string EAIANALDABK()
		{
			return this.CHDNGNHBPDJ("{0} Exception caught.");
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000916C File Offset: 0x0000736C
		public AKFKPPMLPJP KKNIBGIPEKO()
		{
			return this.<AIANCJOAPCP>k__BackingField;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000918E File Offset: 0x0000738E
		public string ILEEGLKLOLF()
		{
			return this.DJHKIHHAAOE("campaign_id");
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000092EC File Offset: 0x000074EC
		public bool JLEAAIADJIA()
		{
			if (this.KKEKGPHOLDN != null && this.KKEKGPHOLDN.ContainsKey("{}[],:\""))
			{
				try
				{
					return (bool)this.KKEKGPHOLDN["\\t"];
				}
				catch (Exception arg)
				{
					AppsFlyer.AFLog("match_type", string.Format("", arg));
				}
				return true;
			}
			return true;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00009358 File Offset: 0x00007558
		public string JIGMIFPAMIF()
		{
			return this.DJHKIHHAAOE("af_sub4");
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00009365 File Offset: 0x00007565
		public string GNKIMBOPIHK()
		{
			return this.NGMGAOMFIPP("false");
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00009358 File Offset: 0x00007558
		public string ELEJNNFDBMH()
		{
			return this.DJHKIHHAAOE("af_sub4");
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00009372 File Offset: 0x00007572
		public string ANHDJAOIDAB()
		{
			return this.DJHKIHHAAOE("\\n");
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000922F File Offset: 0x0000742F
		public string IPLHLBFIFGH()
		{
			return this.NGMGAOMFIPP("af_sub1");
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00009157 File Offset: 0x00007357
		public MLOBDOPIAJF HNAKCNIFOLJ()
		{
			return this.<ALNIKHNKLKJ>k__BackingField;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000937F File Offset: 0x0000757F
		public Dictionary<string, object> DDNECPDMGEN()
		{
			return this.KKEKGPHOLDN;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000916C File Offset: 0x0000736C
		public AKFKPPMLPJP AEFCDDJBHHI()
		{
			return this.<AIANCJOAPCP>k__BackingField;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00009387 File Offset: 0x00007587
		public string CFBPFFKHOCD()
		{
			return this.CHDNGNHBPDJ("click_http_referrer");
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00009394 File Offset: 0x00007594
		public string PJBGAKIFOOH()
		{
			return this.DJHKIHHAAOE("match_type");
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000093A1 File Offset: 0x000075A1
		public string JNNFNEBMNCL()
		{
			return this.DJHKIHHAAOE("{}[],:\"");
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000093AE File Offset: 0x000075AE
		public string HMLFDJMOHCG()
		{
			return this.NGMGAOMFIPP("errorDescription");
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000093BB File Offset: 0x000075BB
		public string ODBNJLMCKIH()
		{
			return this.DJHKIHHAAOE("click_http_referrer");
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000093C8 File Offset: 0x000075C8
		public string OGEKLFJKNEG()
		{
			return this.CHDNGNHBPDJ("campaign_id");
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000093D5 File Offset: 0x000075D5
		public string CLMIJGPBBNE()
		{
			return this.CHDNGNHBPDJ("af_sub2");
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000093E2 File Offset: 0x000075E2
		public string ABEJPBHDCDM()
		{
			return this.CHDNGNHBPDJ("onAppOpenAttributionFailure");
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00009208 File Offset: 0x00007408
		public string PLFGLMEIOGE()
		{
			return this.CHDNGNHBPDJ("af_sub5");
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00009157 File Offset: 0x00007357
		public MLOBDOPIAJF CEHCKFGOLPB()
		{
			return this.<ALNIKHNKLKJ>k__BackingField;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000937F File Offset: 0x0000757F
		public Dictionary<string, object> HKCJFABHAOE()
		{
			return this.KKEKGPHOLDN;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00009365 File Offset: 0x00007565
		public string CJGBBJFJENM()
		{
			return this.NGMGAOMFIPP("false");
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000916C File Offset: 0x0000736C
		public AKFKPPMLPJP DEMMBEOEOEK()
		{
			return this.<AIANCJOAPCP>k__BackingField;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000093EF File Offset: 0x000075EF
		public string FFPCOJMNMOB()
		{
			return this.DJHKIHHAAOE("af_sub3");
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000093FC File Offset: 0x000075FC
		public CHELAOBJCBK(string PPDGGDCAMNB)
		{
			try
			{
				Dictionary<string, object> dictionary = AppsFlyer.CallbackStringToDictionary(PPDGGDCAMNB);
				string a = "";
				string a2 = "";
				if (dictionary.ContainsKey("status") && dictionary["status"] != null)
				{
					a = dictionary["status"].ToString();
				}
				if (dictionary.ContainsKey("error") && dictionary["error"] != null)
				{
					a2 = dictionary["error"].ToString();
				}
				if (dictionary.ContainsKey("deepLink") && dictionary["deepLink"] != null)
				{
					this.KKEKGPHOLDN = AppsFlyer.CallbackStringToDictionary(dictionary["deepLink"].ToString());
				}
				if (dictionary.ContainsKey("is_deferred"))
				{
					this.KKEKGPHOLDN["is_deferred"] = dictionary["is_deferred"];
				}
				if (!(a == "FOUND"))
				{
					if (!(a == "NOT_FOUND"))
					{
						this.IFFDJGPNONC = 2;
					}
					else
					{
						this.IFFDJGPNONC = 1;
					}
				}
				else
				{
					this.IFFDJGPNONC = 0;
				}
				if (!(a2 == "TIMEOUT"))
				{
					if (!(a2 == "NETWORK"))
					{
						if (!(a2 == "HTTP_STATUS_CODE"))
						{
							this.GCFILGFLALC = 3;
						}
						else
						{
							this.GCFILGFLALC = 2;
						}
					}
					else
					{
						this.GCFILGFLALC = 1;
					}
				}
				else
				{
					this.GCFILGFLALC = 0;
				}
			}
			catch (Exception arg)
			{
				AppsFlyer.AFLog("DeepLinkEventsArgs.parseDeepLink", string.Format("{0} Exception caught.", arg));
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000091E1 File Offset: 0x000073E1
		public string MFBEAFKFFLH()
		{
			return this.DJHKIHHAAOE("false");
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000958C File Offset: 0x0000778C
		public string PAHHHPAJICM()
		{
			return this.DJHKIHHAAOE("statusCode");
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00009599 File Offset: 0x00007799
		public string LGIFHHEPMHK()
		{
			return this.CHDNGNHBPDJ("\\n");
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000095A6 File Offset: 0x000077A6
		public string FGLIAPJPBBF()
		{
			return this.DJHKIHHAAOE("af_sub5");
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000095B3 File Offset: 0x000077B3
		public string HFNPHGBAECP()
		{
			return this.NGMGAOMFIPP("statusCode");
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000091FB File Offset: 0x000073FB
		public string AJHEEGHCLEO()
		{
			return this.NGMGAOMFIPP("onAppOpenAttributionFailure");
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000095C0 File Offset: 0x000077C0
		public string KBOLKBHODCK()
		{
			return this.DJHKIHHAAOE("media_source");
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000095CD File Offset: 0x000077CD
		public string BLPJGCEIPOI()
		{
			return this.NGMGAOMFIPP("af_sub2");
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000095DA File Offset: 0x000077DA
		public string NBCPMDIEHBB()
		{
			return this.NGMGAOMFIPP("parseRequestCallback");
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000095E7 File Offset: 0x000077E7
		public string DLGAMALPMDC()
		{
			return this.DJHKIHHAAOE("R");
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000918E File Offset: 0x0000738E
		public string MMPDKHLPACA()
		{
			return this.DJHKIHHAAOE("campaign_id");
		}

		// Token: 0x04000068 RID: 104
		public Dictionary<string, object> KKEKGPHOLDN;
	}
}
