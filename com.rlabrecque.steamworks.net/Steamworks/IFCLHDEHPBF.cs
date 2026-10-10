using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Steamworks
{
	// Token: 0x020001C1 RID: 449
	public static class IFCLHDEHPBF
	{
		// Token: 0x06002311 RID: 8977 RVA: 0x0001787C File Offset: 0x00015A7C
		internal static void FIDMCBAJBEB()
		{
			object gapbgmibcpc = IFCLHDEHPBF.GAPBGMIBCPC;
			lock (gapbgmibcpc)
			{
				IFCLHDEHPBF.JBMCFCEBNEF--;
				if (IFCLHDEHPBF.JBMCFCEBNEF == 0)
				{
					IFCLHDEHPBF.LKGJIBPLOMB();
					Marshal.FreeHGlobal(IFCLHDEHPBF.NIDJPOOKGCB);
					IFCLHDEHPBF.NIDJPOOKGCB = IntPtr.Zero;
				}
			}
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x000178E4 File Offset: 0x00015AE4
		internal static void CNHFNKMIICB(SteamAPICall_t FGMEFAKKDLA, IBKFNBPADAF GGKNPLOOLLP)
		{
			object gapbgmibcpc = IFCLHDEHPBF.GAPBGMIBCPC;
			lock (gapbgmibcpc)
			{
				List<IBKFNBPADAF> list;
				if (IFCLHDEHPBF.OMBDNMJONBJ.TryGetValue(SteamAPICall_t.PEAFCMBIENC(FGMEFAKKDLA), out list))
				{
					list.Remove(GGKNPLOOLLP);
					if (list.Count == 0)
					{
						IFCLHDEHPBF.OMBDNMJONBJ.Remove(SteamAPICall_t.PEAFCMBIENC(FGMEFAKKDLA));
					}
				}
			}
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00017954 File Offset: 0x00015B54
		internal static void AINHNFLCANE(BHIMLNJODHD AHONGLBPDNK)
		{
			int key = CKAIGJENPCJ.LFEPNEGKHBA(AHONGLBPDNK.BICNHJFIPMK());
			Dictionary<int, List<BHIMLNJODHD>> dictionary = AHONGLBPDNK.IGIJPJIKLGB ? IFCLHDEHPBF.ECHJEAIGMIG : IFCLHDEHPBF.HAOKHHBKHDP;
			object gapbgmibcpc = IFCLHDEHPBF.GAPBGMIBCPC;
			lock (gapbgmibcpc)
			{
				List<BHIMLNJODHD> list;
				if (!dictionary.TryGetValue(key, out list))
				{
					list = new List<BHIMLNJODHD>();
					dictionary.Add(key, list);
				}
				list.Add(AHONGLBPDNK);
			}
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x000179D4 File Offset: 0x00015BD4
		internal static void CNHFNKMIICB(BHIMLNJODHD AHONGLBPDNK)
		{
			int key = CKAIGJENPCJ.LFEPNEGKHBA(AHONGLBPDNK.BICNHJFIPMK());
			Dictionary<int, List<BHIMLNJODHD>> dictionary = AHONGLBPDNK.IGIJPJIKLGB ? IFCLHDEHPBF.ECHJEAIGMIG : IFCLHDEHPBF.HAOKHHBKHDP;
			object gapbgmibcpc = IFCLHDEHPBF.GAPBGMIBCPC;
			lock (gapbgmibcpc)
			{
				List<BHIMLNJODHD> list;
				if (dictionary.TryGetValue(key, out list))
				{
					list.Remove(AHONGLBPDNK);
					if (list.Count == 0)
					{
						dictionary.Remove(key);
					}
				}
			}
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x00017A80 File Offset: 0x00015C80
		internal static void BAMHPOCKBML()
		{
			object gapbgmibcpc = IFCLHDEHPBF.GAPBGMIBCPC;
			lock (gapbgmibcpc)
			{
				if (IFCLHDEHPBF.JBMCFCEBNEF == 0)
				{
					IPBEAECLPOJ.KILJPCHBMDJ();
					IFCLHDEHPBF.NIDJPOOKGCB = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(EPEAAMILNCP)));
				}
				IFCLHDEHPBF.JBMCFCEBNEF++;
			}
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x00017AEC File Offset: 0x00015CEC
		public static void HAIIBJONLLI(Exception AKLGBJKDOMM)
		{
			Debug.LogException(AKLGBJKDOMM);
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00017AF4 File Offset: 0x00015CF4
		internal static void AINHNFLCANE(SteamAPICall_t FGMEFAKKDLA, IBKFNBPADAF GGKNPLOOLLP)
		{
			object gapbgmibcpc = IFCLHDEHPBF.GAPBGMIBCPC;
			lock (gapbgmibcpc)
			{
				List<IBKFNBPADAF> list;
				if (!IFCLHDEHPBF.OMBDNMJONBJ.TryGetValue(SteamAPICall_t.PEAFCMBIENC(FGMEFAKKDLA), out list))
				{
					list = new List<IBKFNBPADAF>();
					IFCLHDEHPBF.OMBDNMJONBJ.Add(SteamAPICall_t.PEAFCMBIENC(FGMEFAKKDLA), list);
				}
				list.Add(GGKNPLOOLLP);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x00017B60 File Offset: 0x00015D60
		public static bool FACIFBONANM
		{
			get
			{
				return IFCLHDEHPBF.JBMCFCEBNEF > 0;
			}
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00017B6C File Offset: 0x00015D6C
		private static void LKGJIBPLOMB()
		{
			List<BHIMLNJODHD> list = new List<BHIMLNJODHD>();
			List<IBKFNBPADAF> list2 = new List<IBKFNBPADAF>();
			object gapbgmibcpc = IFCLHDEHPBF.GAPBGMIBCPC;
			lock (gapbgmibcpc)
			{
				foreach (KeyValuePair<int, List<BHIMLNJODHD>> keyValuePair in IFCLHDEHPBF.HAOKHHBKHDP)
				{
					list.AddRange(keyValuePair.Value);
				}
				IFCLHDEHPBF.HAOKHHBKHDP.Clear();
				foreach (KeyValuePair<int, List<BHIMLNJODHD>> keyValuePair2 in IFCLHDEHPBF.ECHJEAIGMIG)
				{
					list.AddRange(keyValuePair2.Value);
				}
				IFCLHDEHPBF.ECHJEAIGMIG.Clear();
				foreach (KeyValuePair<ulong, List<IBKFNBPADAF>> keyValuePair3 in IFCLHDEHPBF.OMBDNMJONBJ)
				{
					list2.AddRange(keyValuePair3.Value);
				}
				IFCLHDEHPBF.OMBDNMJONBJ.Clear();
				foreach (BHIMLNJODHD bhimlnjodhd in list)
				{
					bhimlnjodhd.AGLLPHEJFHA();
				}
				foreach (IBKFNBPADAF ibkfnbpadaf in list2)
				{
					ibkfnbpadaf.AGLLPHEJFHA();
				}
			}
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00017D68 File Offset: 0x00015F68
		internal static void KFGJPBDALAJ(bool BIAKDFMOMEB)
		{
			if (!IFCLHDEHPBF.FACIFBONANM)
			{
				throw new InvalidOperationException("Callback dispatcher is not initialized.");
			}
			HSteamPipe cmimopgnckb = HSteamPipe.PEAFCMBIENC(BIAKDFMOMEB ? IPBEAECLPOJ.FCPHJGJEDPH() : IPBEAECLPOJ.IJFIDBHJDJO());
			IPBEAECLPOJ.CHEHCACDNGB(cmimopgnckb);
			Dictionary<int, List<BHIMLNJODHD>> dictionary = BIAKDFMOMEB ? IFCLHDEHPBF.ECHJEAIGMIG : IFCLHDEHPBF.HAOKHHBKHDP;
			while (IPBEAECLPOJ.PEJDFNMNDNM(cmimopgnckb, IFCLHDEHPBF.NIDJPOOKGCB))
			{
				EPEAAMILNCP epeaamilncp = (EPEAAMILNCP)Marshal.PtrToStructure(IFCLHDEHPBF.NIDJPOOKGCB, typeof(EPEAAMILNCP));
				try
				{
					List<BHIMLNJODHD> collection;
					if (epeaamilncp.DHKEEKJCGCB == 703)
					{
						IOPAFGIDMNF iopafgidmnf = (IOPAFGIDMNF)Marshal.PtrToStructure(epeaamilncp.BKANIPBNJJL, typeof(IOPAFGIDMNF));
						IntPtr intPtr = Marshal.AllocHGlobal((int)iopafgidmnf.HOJBGJHGNPO);
						bool jhfkhlnojjb;
						if (IPBEAECLPOJ.EPDNFBHCDFE(cmimopgnckb, iopafgidmnf.CHJCLNMLFKB, intPtr, (int)iopafgidmnf.HOJBGJHGNPO, iopafgidmnf.DHKEEKJCGCB, out jhfkhlnojjb))
						{
							object gapbgmibcpc = IFCLHDEHPBF.GAPBGMIBCPC;
							lock (gapbgmibcpc)
							{
								List<IBKFNBPADAF> list;
								if (IFCLHDEHPBF.OMBDNMJONBJ.TryGetValue(SteamAPICall_t.PEAFCMBIENC(iopafgidmnf.CHJCLNMLFKB), out list))
								{
									IFCLHDEHPBF.OMBDNMJONBJ.Remove(SteamAPICall_t.PEAFCMBIENC(iopafgidmnf.CHJCLNMLFKB));
									foreach (IBKFNBPADAF ibkfnbpadaf in list)
									{
										ibkfnbpadaf.MJOEIEPDBOH(intPtr, jhfkhlnojjb, SteamAPICall_t.PEAFCMBIENC(iopafgidmnf.CHJCLNMLFKB));
										ibkfnbpadaf.AGLLPHEJFHA();
									}
								}
							}
						}
						Marshal.FreeHGlobal(intPtr);
					}
					else if (dictionary.TryGetValue(epeaamilncp.DHKEEKJCGCB, out collection))
					{
						object gapbgmibcpc = IFCLHDEHPBF.GAPBGMIBCPC;
						List<BHIMLNJODHD> list2;
						lock (gapbgmibcpc)
						{
							list2 = new List<BHIMLNJODHD>(collection);
						}
						foreach (BHIMLNJODHD bhimlnjodhd in list2)
						{
							bhimlnjodhd.FBIKOLGDAMH(epeaamilncp.BKANIPBNJJL);
						}
					}
				}
				catch (Exception aklgbjkdomm)
				{
					IFCLHDEHPBF.HAIIBJONLLI(aklgbjkdomm);
				}
				finally
				{
					IPBEAECLPOJ.JBFJPEACOKG(cmimopgnckb);
				}
			}
		}

		// Token: 0x04000A22 RID: 2594
		private static Dictionary<int, List<BHIMLNJODHD>> HAOKHHBKHDP = new Dictionary<int, List<BHIMLNJODHD>>();

		// Token: 0x04000A23 RID: 2595
		private static Dictionary<int, List<BHIMLNJODHD>> ECHJEAIGMIG = new Dictionary<int, List<BHIMLNJODHD>>();

		// Token: 0x04000A24 RID: 2596
		private static Dictionary<ulong, List<IBKFNBPADAF>> OMBDNMJONBJ = new Dictionary<ulong, List<IBKFNBPADAF>>();

		// Token: 0x04000A25 RID: 2597
		private static object GAPBGMIBCPC = new object();

		// Token: 0x04000A26 RID: 2598
		private static IntPtr NIDJPOOKGCB;

		// Token: 0x04000A27 RID: 2599
		private static int JBMCFCEBNEF;
	}
}
