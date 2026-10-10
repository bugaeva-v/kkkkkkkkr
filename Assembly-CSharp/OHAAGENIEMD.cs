using System;
using System.Collections.Generic;

// Token: 0x02000410 RID: 1040
public class OHAAGENIEMD : KGLBKJKNPFD
{
	// Token: 0x06007C85 RID: 31877 RVA: 0x003745D1 File Offset: 0x003727D1
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06007C86 RID: 31878 RVA: 0x003745E4 File Offset: 0x003727E4
	public OHAAGENIEMD(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.environmentSet;
		this.FLPGNPNHJNK = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "id(", ')', true);
		this.NLAPFLNBDLC = StoryEnvironmentManager.StringToStoryEnvironmentPosition(HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "pos(", ')', true));
		this.BIBACLNGIOD = StoryEnvironmentManager.StringToStoryEnvironmentPositionVertical(HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "posv(", ')', true));
		this.HCMBDDEOADO = new PJNIHBJFGGI();
		if (OFGJFNLDKGO.Contains("fade"))
		{
			List<string> list = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "fade(", ')', true);
			if (list.Count != 0)
			{
				this.HCMBDDEOADO.OCNOFIDCBIH = list[0];
			}
			if (list.Count == 1)
			{
				this.HCMBDDEOADO.MOFGINHMBGG = this.HCMBDDEOADO.OCNOFIDCBIH;
			}
			else if (list.Count == 2)
			{
				this.HCMBDDEOADO.MOFGINHMBGG = list[1];
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("StoryStepEnvironmentSet - invalid number of fade params.");
			}
		}
		else if (OFGJFNLDKGO.Contains("color"))
		{
			List<string> list2 = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "color(", ')', true);
			if (list2.Count != 0)
			{
				this.HCMBDDEOADO.OCNOFIDCBIH = list2[0];
			}
			if (list2.Count == 1)
			{
				this.HCMBDDEOADO.MOFGINHMBGG = this.HCMBDDEOADO.OCNOFIDCBIH;
			}
			else if (list2.Count == 2)
			{
				this.HCMBDDEOADO.MOFGINHMBGG = list2[1];
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("StoryStepEnvironmentSet - invalid number of color params.");
			}
		}
		else
		{
			this.HCMBDDEOADO.OCNOFIDCBIH = "black";
			this.HCMBDDEOADO.MOFGINHMBGG = "black";
		}
		if (OFGJFNLDKGO.Contains("flags("))
		{
			this.NGNDOALIKAK = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "flags(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("layers("))
		{
			this.GIPMNEKDKIL = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "layers(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("layer("))
		{
			this.GIPMNEKDKIL = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "layer(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("layershow"))
		{
			this.GIPMNEKDKIL = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "layershow(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("layerhide"))
		{
			this.AEEAPPMCNNL = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "layerhide(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("zoom("))
		{
			this.HNNHBPDBCGG = new JKFDGJEMAMP();
			List<float> list3 = HLDNEMHDEDH.KKCGKPNINIJ(OFGJFNLDKGO, "zoom(", ')', true);
			if (list3.Count != 0)
			{
				this.HNNHBPDBCGG.FKOHEKBAOEK = list3[0];
			}
			if (list3.Count == 1)
			{
				this.HNNHBPDBCGG.ILHCFECFMDI = this.HNNHBPDBCGG.FKOHEKBAOEK;
			}
			else if (list3.Count == 2)
			{
				this.HNNHBPDBCGG.ILHCFECFMDI = list3[1];
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("StoryStepEnvironmentSet - invalid number of zoom params.");
			}
		}
		if (OFGJFNLDKGO.Contains("time"))
		{
			List<float> list4 = HLDNEMHDEDH.KKCGKPNINIJ(OFGJFNLDKGO, "time(", ')', true);
			if (list4.Count != 0)
			{
				this.NCKKJGPMGHG = list4[0];
			}
			if (list4.Count == 1)
			{
				this.CICCPMFOCGH = this.NCKKJGPMGHG;
			}
			else if (list4.Count == 2)
			{
				this.CICCPMFOCGH = list4[1];
			}
			else
			{
				DPGJIJGOCIC.ANOPFDLPKGC("StoryStepEnvironmentSet - invalid number of time params.");
			}
		}
		else
		{
			this.NCKKJGPMGHG = (this.CICCPMFOCGH = 1.5f);
		}
		this.NCKKJGPMGHG *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		this.CICCPMFOCGH *= AppManager.EHBBFMCILPC.debugSettings.OAEBOACHHOG(1f);
		if (OFGJFNLDKGO.Contains("sfx"))
		{
			this.JLEAIJGBGHL = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "sfx(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("sfxloop"))
		{
			this.MHCAKNHEPDE = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "sfxloop(", ')', true) == 1);
		}
		if (OFGJFNLDKGO.Contains("amb"))
		{
			this.DKPPAALFKMO = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "amb(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("mus"))
		{
			this.KPPJINFHMIP = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "mus(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("musloop"))
		{
			this.LLODADPOMJB = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "musloop(", ')', true) == 1);
		}
		if (OFGJFNLDKGO.Contains("refresh"))
		{
			this.EAKLBCIFDEI = (HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "refresh(", ')', true) == 1);
		}
		if (OFGJFNLDKGO.Contains("flip"))
		{
			this.NFHNOJACGHO = HLDNEMHDEDH.NCIMIEAINEO(OFGJFNLDKGO, "flip(", ')', true);
		}
		if (OFGJFNLDKGO.Contains("morph("))
		{
			List<string> list5 = HLDNEMHDEDH.NNKLPOAODNF(OFGJFNLDKGO, "morph(", ')', true);
			if (list5.Count >= 1 && list5[0].Contains("("))
			{
				list5.Clear();
			}
			if (list5.Count >= 1)
			{
				this.ILBOLKIAOGK = EnvironmentMorphManager.StringToStoryEnvironmentMorphStyle(list5[0]);
			}
			else
			{
				this.ILBOLKIAOGK = AKNNGFCMEEA.dissolve;
			}
			if (list5.Count >= 2)
			{
				try
				{
					this.JCGHCKFAOKI = (float)Convert.ToDouble(list5[1]);
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
				}
			}
			if (list5.Count >= 3)
			{
				try
				{
					this.AJFDHJEKIBO = (float)Convert.ToDouble(list5[2]);
				}
				catch (Exception aklgbjkdomm2)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
				}
			}
		}
	}

	// Token: 0x06007C87 RID: 31879 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06007C88 RID: 31880 RVA: 0x00374B94 File Offset: 0x00372D94
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06007C89 RID: 31881 RVA: 0x00374BAC File Offset: 0x00372DAC
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (OHAAGENIEMD.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x06007C8A RID: 31882 RVA: 0x00374BBC File Offset: 0x00372DBC
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == OHAAGENIEMD.BMHGEBOHLHH.done;
	}

	// Token: 0x040023CC RID: 9164
	public OHAAGENIEMD.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040023CD RID: 9165
	public string FLPGNPNHJNK = "";

	// Token: 0x040023CE RID: 9166
	public FCABOFEGPGP NLAPFLNBDLC;

	// Token: 0x040023CF RID: 9167
	public PHALBCMBPPL BIBACLNGIOD;

	// Token: 0x040023D0 RID: 9168
	public PJNIHBJFGGI HCMBDDEOADO;

	// Token: 0x040023D1 RID: 9169
	public JKFDGJEMAMP HNNHBPDBCGG;

	// Token: 0x040023D2 RID: 9170
	public float NCKKJGPMGHG = 1.5f;

	// Token: 0x040023D3 RID: 9171
	public float CICCPMFOCGH = 1.5f;

	// Token: 0x040023D4 RID: 9172
	public string KPPJINFHMIP = "";

	// Token: 0x040023D5 RID: 9173
	public string DKPPAALFKMO = "";

	// Token: 0x040023D6 RID: 9174
	public string JLEAIJGBGHL = "";

	// Token: 0x040023D7 RID: 9175
	public bool MHCAKNHEPDE;

	// Token: 0x040023D8 RID: 9176
	public bool LLODADPOMJB;

	// Token: 0x040023D9 RID: 9177
	public bool EAKLBCIFDEI;

	// Token: 0x040023DA RID: 9178
	public float NFHNOJACGHO;

	// Token: 0x040023DB RID: 9179
	public AKNNGFCMEEA ILBOLKIAOGK;

	// Token: 0x040023DC RID: 9180
	public float JCGHCKFAOKI;

	// Token: 0x040023DD RID: 9181
	public float AJFDHJEKIBO;

	// Token: 0x040023DE RID: 9182
	public List<string> GIPMNEKDKIL = new List<string>();

	// Token: 0x040023DF RID: 9183
	public List<string> AEEAPPMCNNL = new List<string>();

	// Token: 0x040023E0 RID: 9184
	public List<string> NGNDOALIKAK = new List<string>();

	// Token: 0x02000411 RID: 1041
	public enum BMHGEBOHLHH
	{
		// Token: 0x040023E2 RID: 9186
		start,
		// Token: 0x040023E3 RID: 9187
		changeEnvironment,
		// Token: 0x040023E4 RID: 9188
		changeEnvironmentVideoPrepared,
		// Token: 0x040023E5 RID: 9189
		attemptToShowAd,
		// Token: 0x040023E6 RID: 9190
		showingAd,
		// Token: 0x040023E7 RID: 9191
		showRemoveAdsOffer,
		// Token: 0x040023E8 RID: 9192
		waitingForRemoveAdsOfferResponse,
		// Token: 0x040023E9 RID: 9193
		done
	}
}
