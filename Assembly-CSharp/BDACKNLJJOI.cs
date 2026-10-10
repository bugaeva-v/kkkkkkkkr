using System;
using System.Collections.Generic;

// Token: 0x020002C5 RID: 709
public class BDACKNLJJOI : KGLBKJKNPFD
{
	// Token: 0x060058E8 RID: 22760 RVA: 0x00282269 File Offset: 0x00280469
	public override string LDHNPOGPAOB()
	{
		return this.BOPJOMGIJIA.ToString();
	}

	// Token: 0x060058E9 RID: 22761 RVA: 0x0028227C File Offset: 0x0028047C
	public override void FEHODJMIAJL(int OIMDDBOOAOB = 1)
	{
		if (!this.BBHDMMHCDKO())
		{
			this.BOPJOMGIJIA += OIMDDBOOAOB;
		}
	}

	// Token: 0x060058EA RID: 22762 RVA: 0x00282294 File Offset: 0x00280494
	public BDACKNLJJOI(string OFGJFNLDKGO)
	{
		this.OBKCKGHFMDN = KGLBKJKNPFD.LBFFMOMMAPK.setWardrobeMeta;
		try
		{
			string text = HLDNEMHDEDH.LNLOHDKFDAA(OFGJFNLDKGO, "mixlis(", ')', true);
			if (text != null && text.Length > 0)
			{
				string[] array = text.Split(',', StringSplitOptions.None);
				for (int i = 0; i < array.Length; i++)
				{
					int item = 0;
					if (int.TryParse(array[i].Trim(), out item))
					{
						this.BFFOPDBKCHF.Add(item);
					}
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.BFFOPDBKCHF.Clear();
		}
	}

	// Token: 0x060058EB RID: 22763 RVA: 0x00282330 File Offset: 0x00280530
	public override bool BBHDMMHCDKO()
	{
		return this.BOPJOMGIJIA == BDACKNLJJOI.BMHGEBOHLHH.done;
	}

	// Token: 0x060058EC RID: 22764 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
	public override bool PINCOCDOOGH()
	{
		return false;
	}

	// Token: 0x060058ED RID: 22765 RVA: 0x0028233B File Offset: 0x0028053B
	public override bool FMLECLNJAJM()
	{
		return this.BOPJOMGIJIA == (BDACKNLJJOI.BMHGEBOHLHH)this.KOIINMNNNDJ;
	}

	// Token: 0x04001901 RID: 6401
	public BDACKNLJJOI.BMHGEBOHLHH BOPJOMGIJIA;

	// Token: 0x04001902 RID: 6402
	public List<int> BFFOPDBKCHF = new List<int>();

	// Token: 0x020002C6 RID: 710
	public enum BMHGEBOHLHH
	{
		// Token: 0x04001904 RID: 6404
		start,
		// Token: 0x04001905 RID: 6405
		done
	}
}
