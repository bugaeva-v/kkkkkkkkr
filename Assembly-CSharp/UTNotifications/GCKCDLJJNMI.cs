using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UTNotifications
{
	// Token: 0x020000CF RID: 207
	[DefaultMember("Item")]
	public class GCKCDLJJNMI : OBIIIHFGELL, IEnumerable
	{
		// Token: 0x06001EA5 RID: 7845 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public IEnumerator EEEJGBJFCMA()
		{
			GCKCDLJJNMI.PBIGEOCEMFL pbigeocemfl = new GCKCDLJJNMI.PBIGEOCEMFL(1);
			pbigeocemfl.<>4__this = this;
			return pbigeocemfl;
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public IEnumerator MEOCOKMBKJM()
		{
			GCKCDLJJNMI.PBIGEOCEMFL pbigeocemfl = new GCKCDLJJNMI.PBIGEOCEMFL(1);
			pbigeocemfl.<>4__this = this;
			return pbigeocemfl;
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public IEnumerator JAGFGJGACCP()
		{
			GCKCDLJJNMI.PBIGEOCEMFL pbigeocemfl = new GCKCDLJJNMI.PBIGEOCEMFL(1);
			pbigeocemfl.<>4__this = this;
			return pbigeocemfl;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x000DBFEB File Offset: 0x000DA1EB
		public override int MLNJCKPBPBL
		{
			get
			{
				return this.LMEDELDBFDM.Count;
			}
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000DBFF8 File Offset: 0x000DA1F8
		public IEnumerator ADLFOLMLJKP()
		{
			foreach (KeyValuePair<string, OBIIIHFGELL> keyValuePair in this.LMEDELDBFDM)
			{
				yield return keyValuePair;
			}
			Dictionary<string, OBIIIHFGELL>.Enumerator enumerator = default(Dictionary<string, OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x000DC007 File Offset: 0x000DA207
		// (set) Token: 0x06001EAE RID: 7854 RVA: 0x000DC06E File Offset: 0x000DA26E
		public override OBIIIHFGELL LOPMOIJDFDL
		{
			get
			{
				if (this.LMEDELDBFDM.ContainsKey(AGOONFEKBHK))
				{
					return this.LMEDELDBFDM[AGOONFEKBHK];
				}
				return new DPBDIHCMLIA(this, AGOONFEKBHK);
			}
			set
			{
				if (this.LMEDELDBFDM.ContainsKey(AGOONFEKBHK))
				{
					this.LMEDELDBFDM[AGOONFEKBHK] = value;
					return;
				}
				this.LMEDELDBFDM.Add(AGOONFEKBHK, value);
			}
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public IEnumerator LCOOIGNBOEK()
		{
			GCKCDLJJNMI.PBIGEOCEMFL pbigeocemfl = new GCKCDLJJNMI.PBIGEOCEMFL(1);
			pbigeocemfl.<>4__this = this;
			return pbigeocemfl;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x000DC09C File Offset: 0x000DA29C
		// (set) Token: 0x06001EAC RID: 7852 RVA: 0x000DC02C File Offset: 0x000DA22C
		public override OBIIIHFGELL LOPMOIJDFDL
		{
			get
			{
				if (MCCLOKJEGGL < 0 || MCCLOKJEGGL >= this.LMEDELDBFDM.Count)
				{
					return null;
				}
				return this.LMEDELDBFDM.ElementAt(MCCLOKJEGGL).Value;
			}
			set
			{
				if (MCCLOKJEGGL < 0 || MCCLOKJEGGL >= this.LMEDELDBFDM.Count)
				{
					return;
				}
				string key = this.LMEDELDBFDM.ElementAt(MCCLOKJEGGL).Key;
				this.LMEDELDBFDM[key] = value;
			}
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public IEnumerator PPJFHKGMJGE()
		{
			GCKCDLJJNMI.PBIGEOCEMFL pbigeocemfl = new GCKCDLJJNMI.PBIGEOCEMFL(1);
			pbigeocemfl.<>4__this = this;
			return pbigeocemfl;
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public IEnumerator KIKJPBEBPEH()
		{
			GCKCDLJJNMI.PBIGEOCEMFL pbigeocemfl = new GCKCDLJJNMI.PBIGEOCEMFL(1);
			pbigeocemfl.<>4__this = this;
			return pbigeocemfl;
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public IEnumerator NFPJHKDKJAB()
		{
			GCKCDLJJNMI.PBIGEOCEMFL pbigeocemfl = new GCKCDLJJNMI.PBIGEOCEMFL(1);
			pbigeocemfl.<>4__this = this;
			return pbigeocemfl;
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public IEnumerator OLPNBCOKDHG()
		{
			GCKCDLJJNMI.PBIGEOCEMFL pbigeocemfl = new GCKCDLJJNMI.PBIGEOCEMFL(1);
			pbigeocemfl.<>4__this = this;
			return pbigeocemfl;
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x000DBFF8 File Offset: 0x000DA1F8
		public IEnumerator BMDIOPJDAIP()
		{
			enumerator = this.LMEDELDBFDM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, OBIIIHFGELL> keyValuePair = enumerator.Current;
					yield return keyValuePair;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(Dictionary<string, OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x000DC0D4 File Offset: 0x000DA2D4
		public override void GPBAIBPNNFC(BinaryWriter GMJDAACFDFB)
		{
			GMJDAACFDFB.Write(2);
			GMJDAACFDFB.Write(this.LMEDELDBFDM.Count);
			foreach (string text in this.LMEDELDBFDM.Keys)
			{
				GMJDAACFDFB.Write(text);
				this.LMEDELDBFDM[text].GPBAIBPNNFC(GMJDAACFDFB);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x000DC158 File Offset: 0x000DA358
		public override IEnumerable<OBIIIHFGELL> PPLHLJPFNAM
		{
			get
			{
				foreach (KeyValuePair<string, OBIIIHFGELL> keyValuePair in this.LMEDELDBFDM)
				{
					yield return keyValuePair.Value;
				}
				Dictionary<string, OBIIIHFGELL>.Enumerator enumerator = default(Dictionary<string, OBIIIHFGELL>.Enumerator);
				yield break;
				yield break;
			}
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x000DC168 File Offset: 0x000DA368
		public override OBIIIHFGELL BHHPKNDJFIF(OBIIIHFGELL ABBAALCKIJI)
		{
			GCKCDLJJNMI.GJDPEDOMGLO gjdpedomglo = new GCKCDLJJNMI.GJDPEDOMGLO();
			gjdpedomglo.aNode = ABBAALCKIJI;
			OBIIIHFGELL result;
			try
			{
				KeyValuePair<string, OBIIIHFGELL> keyValuePair = this.LMEDELDBFDM.Where(new Func<KeyValuePair<string, OBIIIHFGELL>, bool>(gjdpedomglo.PNNKHDKMFKM)).First<KeyValuePair<string, OBIIIHFGELL>>();
				this.LMEDELDBFDM.Remove(keyValuePair.Key);
				result = gjdpedomglo.aNode;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x000DC1D4 File Offset: 0x000DA3D4
		public override string FFPLEFPLADA(string PMGAPEJOONC)
		{
			string text = "{ ";
			foreach (KeyValuePair<string, OBIIIHFGELL> keyValuePair in this.LMEDELDBFDM)
			{
				if (text.Length > 3)
				{
					text += ", ";
				}
				text = text + "\n" + PMGAPEJOONC + "   ";
				text = string.Concat(new string[]
				{
					text,
					"\"",
					OBIIIHFGELL.AKKOPHIECDA(keyValuePair.Key),
					"\" : ",
					keyValuePair.Value.FFPLEFPLADA(PMGAPEJOONC + "   ")
				});
			}
			text = text + "\n" + PMGAPEJOONC + "}";
			return text;
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x000DC2AC File Offset: 0x000DA4AC
		public override string ToString()
		{
			string text = "{";
			foreach (KeyValuePair<string, OBIIIHFGELL> keyValuePair in this.LMEDELDBFDM)
			{
				if (text.Length > 2)
				{
					text += ", ";
				}
				text = string.Concat(new string[]
				{
					text,
					"\"",
					OBIIIHFGELL.AKKOPHIECDA(keyValuePair.Key),
					"\":",
					keyValuePair.Value.ToString()
				});
			}
			text += "}";
			return text;
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x000DC360 File Offset: 0x000DA560
		public override OBIIIHFGELL BHHPKNDJFIF(string AGOONFEKBHK)
		{
			if (!this.LMEDELDBFDM.ContainsKey(AGOONFEKBHK))
			{
				return null;
			}
			OBIIIHFGELL result = this.LMEDELDBFDM[AGOONFEKBHK];
			this.LMEDELDBFDM.Remove(AGOONFEKBHK);
			return result;
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public IEnumerator JMJKPONOJIP()
		{
			GCKCDLJJNMI.PBIGEOCEMFL pbigeocemfl = new GCKCDLJJNMI.PBIGEOCEMFL(1);
			pbigeocemfl.<>4__this = this;
			return pbigeocemfl;
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public IEnumerator LPMDJAIJFMM()
		{
			GCKCDLJJNMI.PBIGEOCEMFL pbigeocemfl = new GCKCDLJJNMI.PBIGEOCEMFL(1);
			pbigeocemfl.<>4__this = this;
			return pbigeocemfl;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x000DC38C File Offset: 0x000DA58C
		public override void BDPEBJCNOGG(string AGOONFEKBHK, OBIIIHFGELL KNLLMKKMJBH)
		{
			if (string.IsNullOrEmpty(AGOONFEKBHK))
			{
				this.LMEDELDBFDM.Add(Guid.NewGuid().ToString(), KNLLMKKMJBH);
				return;
			}
			if (this.LMEDELDBFDM.ContainsKey(AGOONFEKBHK))
			{
				this.LMEDELDBFDM[AGOONFEKBHK] = KNLLMKKMJBH;
				return;
			}
			this.LMEDELDBFDM.Add(AGOONFEKBHK, KNLLMKKMJBH);
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public IEnumerator IMMLCGLLLBK()
		{
			GCKCDLJJNMI.PBIGEOCEMFL pbigeocemfl = new GCKCDLJJNMI.PBIGEOCEMFL(1);
			pbigeocemfl.<>4__this = this;
			return pbigeocemfl;
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x000DBFF8 File Offset: 0x000DA1F8
		public IEnumerator GetEnumerator()
		{
			enumerator = this.LMEDELDBFDM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, OBIIIHFGELL> keyValuePair = enumerator.Current;
					yield return keyValuePair;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(Dictionary<string, OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public IEnumerator KNMPPIJKLDL()
		{
			GCKCDLJJNMI.PBIGEOCEMFL pbigeocemfl = new GCKCDLJJNMI.PBIGEOCEMFL(1);
			pbigeocemfl.<>4__this = this;
			return pbigeocemfl;
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x000DBFF8 File Offset: 0x000DA1F8
		public IEnumerator NJACDNKDBNB()
		{
			enumerator = this.LMEDELDBFDM.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, OBIIIHFGELL> keyValuePair = enumerator.Current;
					yield return keyValuePair;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			enumerator = default(Dictionary<string, OBIIIHFGELL>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000DC400 File Offset: 0x000DA600
		public override OBIIIHFGELL BHHPKNDJFIF(int MCCLOKJEGGL)
		{
			if (MCCLOKJEGGL < 0 || MCCLOKJEGGL >= this.LMEDELDBFDM.Count)
			{
				return null;
			}
			KeyValuePair<string, OBIIIHFGELL> keyValuePair = this.LMEDELDBFDM.ElementAt(MCCLOKJEGGL);
			this.LMEDELDBFDM.Remove(keyValuePair.Key);
			return keyValuePair.Value;
		}

		// Token: 0x040008B2 RID: 2226
		private Dictionary<string, OBIIIHFGELL> LMEDELDBFDM = new Dictionary<string, OBIIIHFGELL>();

		// Token: 0x020000D0 RID: 208
		[CompilerGenerated]
		private sealed class GJDPEDOMGLO
		{
			// Token: 0x06001EC3 RID: 7875 RVA: 0x000DC448 File Offset: 0x000DA648
			internal bool PNNKHDKMFKM(KeyValuePair<string, OBIIIHFGELL> k)
			{
				return OBIIIHFGELL.MKGNKAMFMPG(k.Value, this.aNode);
			}

			// Token: 0x040008B3 RID: 2227
			public OBIIIHFGELL aNode;
		}
	}
}
