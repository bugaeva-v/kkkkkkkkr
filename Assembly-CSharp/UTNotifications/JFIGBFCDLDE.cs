using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace UTNotifications
{
	// Token: 0x02000222 RID: 546
	[DefaultMember("Item")]
	public class JFIGBFCDLDE : OBIIIHFGELL, IEnumerable
	{
		// Token: 0x060044C2 RID: 17602 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator KJAKACOKAPC()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator KIKJPBEBPEH()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x001E064A File Offset: 0x001DE84A
		public override OBIIIHFGELL BHHPKNDJFIF(OBIIIHFGELL ABBAALCKIJI)
		{
			this.CCFFFDNFPHI.Remove(ABBAALCKIJI);
			return ABBAALCKIJI;
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator GetEnumerator()
		{
			foreach (OBIIIHFGELL obiiihfgell in this.CCFFFDNFPHI)
			{
				yield return obiiihfgell;
			}
			List<OBIIIHFGELL>.Enumerator enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator ADLFOLMLJKP()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator NFPJHKDKJAB()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator KJBFEEMBMPD()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060044CA RID: 17610 RVA: 0x000879A1 File Offset: 0x00085BA1
		// (set) Token: 0x060044DB RID: 17627 RVA: 0x001E074C File Offset: 0x001DE94C
		public override OBIIIHFGELL LOPMOIJDFDL
		{
			get
			{
				return new DPBDIHCMLIA(this);
			}
			set
			{
				this.CCFFFDNFPHI.Add(value);
			}
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x001E067C File Offset: 0x001DE87C
		public override OBIIIHFGELL BHHPKNDJFIF(int MCCLOKJEGGL)
		{
			if (MCCLOKJEGGL < 0 || MCCLOKJEGGL >= this.CCFFFDNFPHI.Count)
			{
				return null;
			}
			OBIIIHFGELL result = this.CCFFFDNFPHI[MCCLOKJEGGL];
			this.CCFFFDNFPHI.RemoveAt(MCCLOKJEGGL);
			return result;
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator GJONEKLFPJF()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060044D8 RID: 17624 RVA: 0x001E0725 File Offset: 0x001DE925
		// (set) Token: 0x060044CD RID: 17613 RVA: 0x001E06AA File Offset: 0x001DE8AA
		public override OBIIIHFGELL LOPMOIJDFDL
		{
			get
			{
				if (MCCLOKJEGGL < 0 || MCCLOKJEGGL >= this.CCFFFDNFPHI.Count)
				{
					return new DPBDIHCMLIA(this);
				}
				return this.CCFFFDNFPHI[MCCLOKJEGGL];
			}
			set
			{
				if (MCCLOKJEGGL < 0 || MCCLOKJEGGL >= this.CCFFFDNFPHI.Count)
				{
					this.CCFFFDNFPHI.Add(value);
					return;
				}
				this.CCFFFDNFPHI[MCCLOKJEGGL] = value;
			}
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x001E06D8 File Offset: 0x001DE8D8
		public override void GPBAIBPNNFC(BinaryWriter GMJDAACFDFB)
		{
			GMJDAACFDFB.Write(1);
			GMJDAACFDFB.Write(this.CCFFFDNFPHI.Count);
			for (int i = 0; i < this.CCFFFDNFPHI.Count; i++)
			{
				this.CCFFFDNFPHI[i].GPBAIBPNNFC(GMJDAACFDFB);
			}
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator LPHCNNFIOIF()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator MEOCOKMBKJM()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator EEEJGBJFCMA()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator AIMAOCDKJMK()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator KHIJCKCAONB()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator LDFFEGNIGND()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator LCOOIGNBOEK()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator NJACDNKDBNB()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator PPJFHKGMJGE()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator JMJKPONOJIP()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator HMCJDJFKNKD()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x001E074C File Offset: 0x001DE94C
		public override void BDPEBJCNOGG(string AGOONFEKBHK, OBIIIHFGELL KNLLMKKMJBH)
		{
			this.CCFFFDNFPHI.Add(KNLLMKKMJBH);
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator OLPNBCOKDHG()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator ACCEFJBDKDJ()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator LPMDJAIJFMM()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x001E075A File Offset: 0x001DE95A
		public override IEnumerable<OBIIIHFGELL> PPLHLJPFNAM
		{
			get
			{
				foreach (OBIIIHFGELL obiiihfgell in this.CCFFFDNFPHI)
				{
					yield return obiiihfgell;
				}
				List<OBIIIHFGELL>.Enumerator enumerator = default(List<OBIIIHFGELL>.Enumerator);
				yield break;
				yield break;
			}
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator OOANPMDHNMN()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator HAPAFMEEKPF()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator DNEALKALLCF()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator DLJLGKMPHIH()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator IMMLCGLLLBK()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator ICHOKKCDHAA()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator JAGFGJGACCP()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator BMDIOPJDAIP()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x001E076C File Offset: 0x001DE96C
		public override string ToString()
		{
			string text = "[ ";
			foreach (OBIIIHFGELL obiiihfgell in this.CCFFFDNFPHI)
			{
				if (text.Length > 2)
				{
					text += ", ";
				}
				text += obiiihfgell.ToString();
			}
			text += " ]";
			return text;
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator PGMGPLENDKI()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060044EB RID: 17643 RVA: 0x001E07F0 File Offset: 0x001DE9F0
		public override int MLNJCKPBPBL
		{
			get
			{
				return this.CCFFFDNFPHI.Count;
			}
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x001E065A File Offset: 0x001DE85A
		public IEnumerator KNMPPIJKLDL()
		{
			enumerator = this.CCFFFDNFPHI.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					OBIIIHFGELL obiiihfgell = enumerator.Current;
					yield return obiiihfgell;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(List<OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x001E063B File Offset: 0x001DE83B
		public IEnumerator NCHOKMLILAJ()
		{
			JFIGBFCDLDE.GKAPJFKIBLM gkapjfkiblm = new JFIGBFCDLDE.GKAPJFKIBLM(1);
			gkapjfkiblm.<>4__this = this;
			return gkapjfkiblm;
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x001E0800 File Offset: 0x001DEA00
		public override string FFPLEFPLADA(string PMGAPEJOONC)
		{
			string text = "[ ";
			foreach (OBIIIHFGELL obiiihfgell in this.CCFFFDNFPHI)
			{
				if (text.Length > 3)
				{
					text += ", ";
				}
				text = text + "\n" + PMGAPEJOONC + "   ";
				text += obiiihfgell.FFPLEFPLADA(PMGAPEJOONC + "   ");
			}
			text = text + "\n" + PMGAPEJOONC + "]";
			return text;
		}

		// Token: 0x040012FA RID: 4858
		private List<OBIIIHFGELL> CCFFFDNFPHI = new List<OBIIIHFGELL>();
	}
}
