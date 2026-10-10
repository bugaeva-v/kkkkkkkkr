using System;

// Token: 0x020002AA RID: 682
public class IPPJMENKOFC : KGLBKJKNPFD
{
	// Token: 0x0600568F RID: 22159 RVA: 0x0026A0D4 File Offset: 0x002682D4
	public IPPJMENKOFC(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.setWardrobe;
		this.OIBGFPEGLME = HLDNEMHDEDH.OKNGPMCDBFE(OFGJFNLDKGO, "index(", ')', true);
	}

	// Token: 0x06005690 RID: 22160 RVA: 0x0026A0FF File Offset: 0x002682FF
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x06005691 RID: 22161 RVA: 0x0026A112 File Offset: 0x00268312
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x06005692 RID: 22162 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06005693 RID: 22163 RVA: 0x0026A12A File Offset: 0x0026832A
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == IPPJMENKOFC.BMHGEBOHLHH.done;
	}

	// Token: 0x06005694 RID: 22164 RVA: 0x0026A135 File Offset: 0x00268335
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (IPPJMENKOFC.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x04001842 RID: 6210
	public IPPJMENKOFC.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001843 RID: 6211
	public int OIBGFPEGLME = -1;

	// Token: 0x020002AB RID: 683
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001845 RID: 6213
		start,
		// Token: 0x04001846 RID: 6214
		done
	}
}
