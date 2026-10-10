using System;
using UnityEngine;
using UnityEngine.Networking;

namespace AssetBundles
{
	// Token: 0x02000445 RID: 1093
	public class JANJJAOKJJP : LOKAMLMIIAA
	{
		// Token: 0x06008425 RID: 33829 RVA: 0x003A34B8 File Offset: 0x003A16B8
		protected override void OFOIHGLENOL()
		{
			if (this.BOOAKCMJDIC != 2)
			{
				base.GCFILGFLALC = this.GNNNOPMMGCP.error;
			}
			if (!string.IsNullOrEmpty(base.GCFILGFLALC))
			{
				this.GNNNOPMMGCP.Dispose();
				this.GNNNOPMMGCP = null;
				this.JGGJNIPMFIK = null;
				if (!this.JKEMFIPAPKA)
				{
					NPOILPKELOJ.PHLMNHLIAMB = true;
				}
				return;
			}
			if (this.JKEMFIPAPKA && KDCJJBLGCBH.EHBBFMCILPC.NDNDKJDIHKA())
			{
				if (this.LLCAGPCNKJB < 0.25f)
				{
					NPOILPKELOJ.IKDKDPNCJBO = LKBEFCALCCC.ultra;
				}
				else if (this.LLCAGPCNKJB < 1f)
				{
					NPOILPKELOJ.IKDKDPNCJBO = LKBEFCALCCC.high;
				}
				else if (this.LLCAGPCNKJB < 3f)
				{
					NPOILPKELOJ.IKDKDPNCJBO = LKBEFCALCCC.mid;
				}
				else
				{
					NPOILPKELOJ.IKDKDPNCJBO = LKBEFCALCCC.low;
				}
				NPOILPKELOJ.DJPKNMEEFPK = true;
			}
			AssetBundle assetBundle = (this.GNNNOPMMGCP.downloadHandler as DownloadHandlerAssetBundle).assetBundle;
			if (assetBundle == null)
			{
				base.GCFILGFLALC = string.Format("{0} is not a valid asset bundle.", base.CIEHGJMAFKH);
			}
			else
			{
				base.GHKBBDLNAGD = new GCFIOHOKPPN(assetBundle);
			}
			this.GNNNOPMMGCP.Dispose();
			this.GNNNOPMMGCP = null;
			this.JGGJNIPMFIK = null;
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x003A35D0 File Offset: 0x003A17D0
		public JANJJAOKJJP(string CIEHGJMAFKH, UnityWebRequest MBOEDNIHAMH) : base(CIEHGJMAFKH)
		{
			if (MBOEDNIHAMH == null || !(MBOEDNIHAMH.downloadHandler is DownloadHandlerAssetBundle))
			{
				throw new ArgumentNullException("request");
			}
			this.HIIPJMDOJAG = MBOEDNIHAMH.url;
			this.GNNNOPMMGCP = MBOEDNIHAMH;
			this.JGGJNIPMFIK = MBOEDNIHAMH.SendWebRequest();
			if (CIEHGJMAFKH.Equals(LNDOOJOFFOM.Common.ToString()))
			{
				this.JKEMFIPAPKA = true;
			}
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x003A363C File Offset: 0x003A183C
		public override string HPIFGCJIPKK()
		{
			return this.HIIPJMDOJAG;
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x0009C88E File Offset: 0x0009AA8E
		public override string NCDEKILOHGF()
		{
			return this.HPIFGCJIPKK();
		}

		// Token: 0x06008429 RID: 33833 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
		public override bool HJOPIMGMGML()
		{
			return false;
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600842A RID: 33834 RVA: 0x003A3644 File Offset: 0x003A1844
		protected override bool EPBDMHGPFJN
		{
			get
			{
				bool flag = this.JGGJNIPMFIK == null || this.JGGJNIPMFIK.isDone || !string.IsNullOrEmpty(this.GNNNOPMMGCP.error);
				if (!flag)
				{
					float num = Mathf.Abs(this.GNNNOPMMGCP.downloadProgress - this.HAPHBJAFANA);
					if (this.GNNNOPMMGCP.downloadProgress < 1E-05f)
					{
						this.JGBMENMDMFE += Time.deltaTime;
					}
					else
					{
						this.JGBMENMDMFE = 0f;
					}
					if (this.GNNNOPMMGCP.downloadProgress < 1f && num < 1E-05f)
					{
						this.GHAKGHAEEBP += Time.deltaTime;
					}
					else
					{
						this.GHAKGHAEEBP = 0f;
					}
					this.HAPHBJAFANA = this.GNNNOPMMGCP.downloadProgress;
					if (this.JKEMFIPAPKA && KDCJJBLGCBH.EHBBFMCILPC.LBGMLFJEMEM())
					{
						if ((this.LLCAGPCNKJB >= NPOILPKELOJ.OHBIHJJIDJK + NPOILPKELOJ.CDCFIAIJLOB || this.GHAKGHAEEBP >= NPOILPKELOJ.OLILNLJHHJO + NPOILPKELOJ.CDCFIAIJLOB || this.JGBMENMDMFE >= NPOILPKELOJ.FGKHNCHIMNH + NPOILPKELOJ.CDCFIAIJLOB) && this.BOOAKCMJDIC == 0)
						{
							this.BOOAKCMJDIC = 1;
							NPOILPKELOJ.CDCFIAIJLOB += NPOILPKELOJ.LNIMMLLHDME;
							NPOILPKELOJ.MMANKOLKKMG = true;
							NPOILPKELOJ.BGPKAOFOHHB++;
							this.GNNNOPMMGCP.Abort();
						}
						else if ((this.LLCAGPCNKJB >= NPOILPKELOJ.OHBIHJJIDJK + NPOILPKELOJ.CDCFIAIJLOB + NPOILPKELOJ.JHCNNAADBIB || this.GHAKGHAEEBP >= NPOILPKELOJ.OLILNLJHHJO + NPOILPKELOJ.CDCFIAIJLOB + NPOILPKELOJ.JHCNNAADBIB || this.JGBMENMDMFE >= NPOILPKELOJ.FGKHNCHIMNH + NPOILPKELOJ.CDCFIAIJLOB + NPOILPKELOJ.JHCNNAADBIB) && this.BOOAKCMJDIC > 0)
						{
							this.BOOAKCMJDIC = 2;
							base.GCFILGFLALC = "m_abortFlag = 2";
							flag = true;
						}
					}
					else if ((this.LLCAGPCNKJB >= NPOILPKELOJ.HEOJMGJHGGH || this.GHAKGHAEEBP >= NPOILPKELOJ.BDHPABAKCME || NPOILPKELOJ.PHLMNHLIAMB) && this.BOOAKCMJDIC == 0)
					{
						this.BOOAKCMJDIC = 1;
						this.GNNNOPMMGCP.Abort();
					}
					else if ((this.LLCAGPCNKJB >= NPOILPKELOJ.HEOJMGJHGGH + NPOILPKELOJ.OPMIBNIOMOO || this.GHAKGHAEEBP >= NPOILPKELOJ.BDHPABAKCME + NPOILPKELOJ.OPMIBNIOMOO) && this.BOOAKCMJDIC > 0)
					{
						this.BOOAKCMJDIC = 2;
						base.GCFILGFLALC = "m_abortFlag = 2";
						flag = true;
					}
				}
				return flag;
			}
		}

		// Token: 0x040025A0 RID: 9632
		private UnityWebRequest GNNNOPMMGCP;

		// Token: 0x040025A1 RID: 9633
		private AsyncOperation JGGJNIPMFIK;

		// Token: 0x040025A2 RID: 9634
		private string HIIPJMDOJAG;

		// Token: 0x040025A3 RID: 9635
		private int BOOAKCMJDIC;

		// Token: 0x040025A4 RID: 9636
		private bool JKEMFIPAPKA;
	}
}
