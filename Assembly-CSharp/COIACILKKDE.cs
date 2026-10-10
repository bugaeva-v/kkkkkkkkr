using System;

// Token: 0x0200045D RID: 1117
public class COIACILKKDE : KGLBKJKNPFD
{
	// Token: 0x0600880B RID: 34827 RVA: 0x003CDBCD File Offset: 0x003CBDCD
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x0600880C RID: 34828 RVA: 0x003CDBE5 File Offset: 0x003CBDE5
	public COIACILKKDE(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.useMappingV2;
	}

	// Token: 0x0600880D RID: 34829 RVA: 0x003CDBF5 File Offset: 0x003CBDF5
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x0600880E RID: 34830 RVA: 0x003CDC08 File Offset: 0x003CBE08
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (COIACILKKDE.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x0600880F RID: 34831 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x06008810 RID: 34832 RVA: 0x003CDC18 File Offset: 0x003CBE18
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == COIACILKKDE.BMHGEBOHLHH.done;
	}

	// Token: 0x04002607 RID: 9735
	public COIACILKKDE.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x0200045E RID: 1118
	public enum BMHGEBOHLHH
	{
		// Token: 0x04002609 RID: 9737
		start,
		// Token: 0x0400260A RID: 9738
		done
	}
}
