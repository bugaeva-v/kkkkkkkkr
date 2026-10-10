using System;
using System.IO;

namespace UTNotifications
{
	// Token: 0x02000295 RID: 661
	public class BCBNCFOIBEI : OBIIIHFGELL
	{
		// Token: 0x0600532F RID: 21295 RVA: 0x00248716 File Offset: 0x00246916
		public BCBNCFOIBEI(bool CPDFGAFFJIK)
		{
			this.AFECPNMLFHA = CPDFGAFFJIK;
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x00248725 File Offset: 0x00246925
		public override string FFPLEFPLADA(string PMGAPEJOONC)
		{
			return "\"" + OBIIIHFGELL.AKKOPHIECDA(this.OBENGNDEADD) + "\"";
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06005332 RID: 21298 RVA: 0x0024874A File Offset: 0x0024694A
		// (set) Token: 0x06005331 RID: 21297 RVA: 0x00248741 File Offset: 0x00246941
		public override string IJPDKGMEHJP
		{
			get
			{
				return this.OBENGNDEADD;
			}
			set
			{
				this.OBENGNDEADD = value;
			}
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x00248752 File Offset: 0x00246952
		public BCBNCFOIBEI(string CPDFGAFFJIK)
		{
			this.OBENGNDEADD = CPDFGAFFJIK;
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x00248725 File Offset: 0x00246925
		public override string ToString()
		{
			return "\"" + OBIIIHFGELL.AKKOPHIECDA(this.OBENGNDEADD) + "\"";
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x00248764 File Offset: 0x00246964
		public override void GPBAIBPNNFC(BinaryWriter GMJDAACFDFB)
		{
			BCBNCFOIBEI bcbncfoibei = new BCBNCFOIBEI("");
			bcbncfoibei.JEMMIFCNCFI = this.JEMMIFCNCFI;
			if (bcbncfoibei.OBENGNDEADD == this.OBENGNDEADD)
			{
				GMJDAACFDFB.Write(4);
				GMJDAACFDFB.Write(this.JEMMIFCNCFI);
				return;
			}
			bcbncfoibei.JFDGHAKCEPC = this.JFDGHAKCEPC;
			if (bcbncfoibei.OBENGNDEADD == this.OBENGNDEADD)
			{
				GMJDAACFDFB.Write(7);
				GMJDAACFDFB.Write(this.JFDGHAKCEPC);
				return;
			}
			bcbncfoibei.NIBEOIHMPJD = this.NIBEOIHMPJD;
			if (bcbncfoibei.OBENGNDEADD == this.OBENGNDEADD)
			{
				GMJDAACFDFB.Write(5);
				GMJDAACFDFB.Write(this.NIBEOIHMPJD);
				return;
			}
			bcbncfoibei.AFECPNMLFHA = this.AFECPNMLFHA;
			if (bcbncfoibei.OBENGNDEADD == this.OBENGNDEADD)
			{
				GMJDAACFDFB.Write(6);
				GMJDAACFDFB.Write(this.AFECPNMLFHA);
				return;
			}
			GMJDAACFDFB.Write(3);
			GMJDAACFDFB.Write(this.OBENGNDEADD);
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x0024885B File Offset: 0x00246A5B
		public BCBNCFOIBEI(float CPDFGAFFJIK)
		{
			this.JFDGHAKCEPC = CPDFGAFFJIK;
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x0024886A File Offset: 0x00246A6A
		public BCBNCFOIBEI(int CPDFGAFFJIK)
		{
			this.JEMMIFCNCFI = CPDFGAFFJIK;
		}

		// Token: 0x06005338 RID: 21304 RVA: 0x00248879 File Offset: 0x00246A79
		public BCBNCFOIBEI(double CPDFGAFFJIK)
		{
			this.NIBEOIHMPJD = CPDFGAFFJIK;
		}

		// Token: 0x04001737 RID: 5943
		private string OBENGNDEADD;
	}
}
