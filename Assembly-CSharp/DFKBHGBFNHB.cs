using System;

// Token: 0x0200042B RID: 1067
public class DFKBHGBFNHB : KGLBKJKNPFD
{
	// Token: 0x06007FE8 RID: 32744 RVA: 0x0038A6ED File Offset: 0x003888ED
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == DFKBHGBFNHB.BMHGEBOHLHH.done;
	}

	// Token: 0x06007FE9 RID: 32745 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06007FEA RID: 32746 RVA: 0x0038A6F8 File Offset: 0x003888F8
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06007FEB RID: 32747 RVA: 0x0038A70B File Offset: 0x0038890B
	public DFKBHGBFNHB(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.defaultLang;
		this.NCFJPLBAGDP = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "lang(", ')', true);
		DFKBHGBFNHB.IMIDHJMEGOG = LanguageManager.FromString(this.NCFJPLBAGDP);
	}

	// Token: 0x06007FEC RID: 32748 RVA: 0x0038A74A File Offset: 0x0038894A
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06007FED RID: 32749 RVA: 0x0038A762 File Offset: 0x00388962
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (DFKBHGBFNHB.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x040024CE RID: 9422
	public DFKBHGBFNHB.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x040024CF RID: 9423
	public static CEIBHCNNIDC IMIDHJMEGOG;

	// Token: 0x040024D0 RID: 9424
	public string NCFJPLBAGDP = "en";

	// Token: 0x0200042C RID: 1068
	public enum BMHGEBOHLHH
	{
		// Token: 0x040024D2 RID: 9426
		start,
		// Token: 0x040024D3 RID: 9427
		done
	}
}
