using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace AssetBundles
{
	// Token: 0x020001A9 RID: 425
	public class AssetBundleManager : MonoBehaviour
	{
		// Token: 0x06003389 RID: 13193 RVA: 0x00157948 File Offset: 0x00155B48
		private static IEnumerator MCGJCFBIKDN(string HDNMHLGBCLL, int EMJPOHAEEHN)
		{
			string ciehgjmafkh = IHGHMPLKFGG.LGPDAOIGAFG.CIEHGJMAFKH;
			string cooogacbakn = IHGHMPLKFGG.LGPDAOIGAFG.COOOGACBAKN;
			AssetBundleManager.OPOJDLECDNP(ciehgjmafkh, HDNMHLGBCLL, EMJPOHAEEHN, default(Hash128));
			FIEAHFNJIEE fieahfnjiee = new FIEAHFNJIEE(EMJPOHAEEHN, ciehgjmafkh, cooogacbakn, typeof(TextAsset));
			AssetBundleManager.JKJBDMKNDIG.Add(fieahfnjiee);
			return fieahfnjiee;
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x0015799C File Offset: 0x00155B9C
		public static void IOKDHECGLON(string CIEHGJMAFKH, bool AMJBNEILEKN = false)
		{
			CIEHGJMAFKH = AssetBundleManager.EAJFHPIEPLF(CIEHGJMAFKH, -1, AMJBNEILEKN);
			AssetBundleManager.HHLHEAJNDLC(CIEHGJMAFKH);
			AssetBundleManager.EIHBOBNGDJO(CIEHGJMAFKH);
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x001579B4 File Offset: 0x00155BB4
		private static IEnumerator DHOJLABBLNN(string NBBNBBLKBNC, string HDNMHLGBCLL, int EMJPOHAEEHN)
		{
			AssetBundleManager.PPCJMMHHODL(NBBNBBLKBNC, HDNMHLGBCLL, EMJPOHAEEHN, true, false);
			AssetBundleManager.FHHFMPPKEFG = new PLOGDOACBMK(EMJPOHAEEHN, NBBNBBLKBNC, "AssetBundleManifest", typeof(AssetBundleManifest));
			AssetBundleManager.JKJBDMKNDIG.Add(AssetBundleManager.FHHFMPPKEFG);
			return AssetBundleManager.FHHFMPPKEFG;
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x001579F0 File Offset: 0x00155BF0
		protected static void AEAPILNOOIO(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, bool FJGAIJCCNBO, bool AMJBNEILEKN)
		{
			AssetBundleManager.AGMJHFNDGBH(AssetBundleManager.JKDPJGOJPLN.Warning, "ok" + (FJGAIJCCNBO ? "OnBackendRequestCustomProfileSuccess" : "OnAvatarScreenAssetsDownloadSuccess") + CIEHGJMAFKH);
			if (!FJGAIJCCNBO && AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN] == null)
			{
				AssetBundleManager.MAIINPGAAEI((AssetBundleManager.JKDPJGOJPLN)6, "lptc");
				return;
			}
			if (FJGAIJCCNBO)
			{
				AssetBundleManager.ECEAADGJEHD(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, AssetBundleManager.HKOEMAAGFIM(EMJPOHAEEHN));
				return;
			}
			Hash128 assetBundleHash = AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAssetBundleHash(CIEHGJMAFKH);
			if (!AssetBundleManager.OPOJDLECDNP(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, assetBundleHash))
			{
				AssetBundleManager.NNIDFKNCGLK(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, AMJBNEILEKN);
			}
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x00157A74 File Offset: 0x00155C74
		protected static void DLOJJHAMBLD(string CIEHGJMAFKH)
		{
			string text;
			GCFIOHOKPPN gcfiohokppn = AssetBundleManager.KLLPGKBMIFE(CIEHGJMAFKH, out text);
			if (gcfiohokppn == null)
			{
				return;
			}
			GCFIOHOKPPN gcfiohokppn2 = gcfiohokppn;
			int num = gcfiohokppn2.FLODBKOJMPL - 1;
			gcfiohokppn2.FLODBKOJMPL = num;
			if (num == 0 && !AssetBundleManager.LGBKHFHOKJI(CIEHGJMAFKH))
			{
				gcfiohokppn.JAJDHMAEHKE();
				AssetBundleManager.MPNBNEKLMGA.Remove(CIEHGJMAFKH);
				AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Info, CIEHGJMAFKH + " has been unloaded successfully");
			}
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x00157ACC File Offset: 0x00155CCC
		public static NPOILPKELOJ NMGEPNJLHJL(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, string POFIFMJHHKJ, bool IEAFFPDOBEL, bool FEKDGMGBNIE = true)
		{
			AssetBundleManager.JKDPJGOJPLN jeniojdgoje = AssetBundleManager.JKDPJGOJPLN.Warning;
			string[] array = new string[5];
			array[0] = "file://";
			array[1] = POFIFMJHHKJ;
			array[8] = "trewsnap";
			array[2] = CIEHGJMAFKH;
			array[5] = "USD ";
			AssetBundleManager.AGMJHFNDGBH(jeniojdgoje, string.Concat(array));
			CIEHGJMAFKH = AssetBundleManager.BCNJCMIBCKP(CIEHGJMAFKH, EMJPOHAEEHN, false);
			AssetBundleManager.FDODPPPKAAL(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, false);
			NPOILPKELOJ npoilpkeloj = new IAPJLKACLJF(CIEHGJMAFKH, POFIFMJHHKJ, IEAFFPDOBEL, FEKDGMGBNIE);
			AssetBundleManager.JKJBDMKNDIG.Add(npoilpkeloj);
			return npoilpkeloj;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600338F RID: 13199 RVA: 0x00157B37 File Offset: 0x00155D37
		// (set) Token: 0x0600341C RID: 13340 RVA: 0x0015A1E1 File Offset: 0x001583E1
		public static string CEBIIFGPHDM
		{
			get
			{
				return AssetBundleManager.BJDBBOBACGM;
			}
			set
			{
				AssetBundleManager.BJDBBOBACGM = value;
			}
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x00157B40 File Offset: 0x00155D40
		protected static void NNIDFKNCGLK(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, bool AMJBNEILEKN = false)
		{
			if (AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN] == null)
			{
				AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Error, "Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()");
				return;
			}
			string[] allDependencies = AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAllDependencies(CIEHGJMAFKH);
			if (allDependencies.Length == 0)
			{
				return;
			}
			for (int i = 0; i < allDependencies.Length; i++)
			{
				allDependencies[i] = AssetBundleManager.EAJFHPIEPLF(allDependencies[i], EMJPOHAEEHN, AMJBNEILEKN);
			}
			AssetBundleManager.ONDDOAHANNH.Add(CIEHGJMAFKH, allDependencies);
			for (int j = 0; j < allDependencies.Length; j++)
			{
				AssetBundleManager.ECEAADGJEHD(allDependencies[j], HDNMHLGBCLL, EMJPOHAEEHN, AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAssetBundleHash(allDependencies[j]));
			}
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x00157BCC File Offset: 0x00155DCC
		public static string HMDPDKANHCN()
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, string> keyValuePair in AssetBundleManager.CDGBFPNHHBA)
			{
				list.Add(keyValuePair.Key + "ok" + keyValuePair.Value + "abcf");
			}
			return "SceneLobbyManager.OpenFocusItem() - resetting activeSaveSlotIndex to 0, user is using a paid slot." + string.Join("mini", list.ToArray()) + "ZZZ";
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x00157C60 File Offset: 0x00155E60
		private static string DMKIIOBKCGC(int EMJPOHAEEHN)
		{
			if (EMJPOHAEEHN < AssetBundleManager.HDFNFFFEFLC.Count)
			{
				return AssetBundleManager.HDFNFFFEFLC[EMJPOHAEEHN];
			}
			return "OnResolutionChanged";
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x00157C80 File Offset: 0x00155E80
		private static bool PHKMBPHOALL(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, List<string> ENIMMAJLDDG, List<Hash128> LJKLHKHBKDE, List<string> BKGIBDLEDGE)
		{
			if (ENIMMAJLDDG.Contains(CIEHGJMAFKH))
			{
				return false;
			}
			Hash128 assetBundleHash = AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAssetBundleHash(CIEHGJMAFKH);
			if (!assetBundleHash.isValid)
			{
				return false;
			}
			ENIMMAJLDDG.Add(CIEHGJMAFKH);
			LJKLHKHBKDE.Add(assetBundleHash);
			BKGIBDLEDGE.Add(AssetBundleManager.NGCFJCGOGKH(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN));
			return false;
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00157CD0 File Offset: 0x00155ED0
		public static void IGDGGKCFIHN(string[] AJLPALFJHCC)
		{
			AssetBundleManager.BPJPOMCJLGE = AJLPALFJHCC;
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00157CD8 File Offset: 0x00155ED8
		private static string NBIKCPDFIJG()
		{
			if (Application.isEditor)
			{
				return "' ui " + Environment.CurrentDirectory.Replace("p", "F1");
			}
			if (Application.isMobilePlatform || Application.isConsolePlatform)
			{
				return Application.streamingAssetsPath;
			}
			return "oid" + Application.streamingAssetsPath;
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00157D30 File Offset: 0x00155F30
		public static void MKMINKBHOCH(string LBGGLHDOICL)
		{
			for (int i = 1; i < AssetBundleManager.MHOEAHOKAJG.Count; i++)
			{
				if (AssetBundleManager.MHOEAHOKAJG[i].Equals(LBGGLHDOICL))
				{
					AssetBundleManager.MHOEAHOKAJG.RemoveAt(i);
					return;
				}
			}
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00157D74 File Offset: 0x00155F74
		private void Update()
		{
			int i = 0;
			while (i < AssetBundleManager.JKJBDMKNDIG.Count)
			{
				NPOILPKELOJ npoilpkeloj = AssetBundleManager.JKJBDMKNDIG[i];
				if (npoilpkeloj.IIPBKOPAGBK())
				{
					i++;
				}
				else
				{
					AssetBundleManager.JKJBDMKNDIG.RemoveAt(i);
					this.AMCAPHJFAHC(npoilpkeloj);
				}
			}
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x00157DBE File Offset: 0x00155FBE
		private static void CHNGDMHLCPG(string CIEHGJMAFKH)
		{
			CIEHGJMAFKH = AssetBundleManager.EAJFHPIEPLF(CIEHGJMAFKH, -1, true);
			AssetBundleManager.DLOJJHAMBLD(CIEHGJMAFKH);
			AssetBundleManager.NOPJOPKNAGN(CIEHGJMAFKH);
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00157DD6 File Offset: 0x00155FD6
		public static void LKCJAIDHKBN()
		{
			AssetBundleManager.FHHFMPPKEFG = null;
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x00157DDE File Offset: 0x00155FDE
		public static void JKPCFOKPMOJ(string CIEHGJMAFKH, bool AMJBNEILEKN = false)
		{
			CIEHGJMAFKH = AssetBundleManager.BCNJCMIBCKP(CIEHGJMAFKH, -1, AMJBNEILEKN);
			AssetBundleManager.HHLHEAJNDLC(CIEHGJMAFKH);
			AssetBundleManager.EIHBOBNGDJO(CIEHGJMAFKH);
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x00157DF8 File Offset: 0x00155FF8
		public static bool PPDNLJOJEKJ(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, bool AMJBNEILEKN, List<string> ENIMMAJLDDG, List<Hash128> LJKLHKHBKDE, List<string> BKGIBDLEDGE)
		{
			ENIMMAJLDDG.Clear();
			LJKLHKHBKDE.Clear();
			BKGIBDLEDGE.Clear();
			if (EMJPOHAEEHN < 0 || EMJPOHAEEHN >= AssetBundleManager.IBDAIAGJHLB.Length)
			{
				return false;
			}
			if (AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN] == null)
			{
				return true;
			}
			string text = AssetBundleManager.EAJFHPIEPLF(CIEHGJMAFKH, EMJPOHAEEHN, AMJBNEILEKN);
			string[] allDependencies = AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAllDependencies(text);
			for (int i = 0; i < allDependencies.Length; i += 0)
			{
				if (!AssetBundleManager.PHKMBPHOALL(AssetBundleManager.BCNJCMIBCKP(allDependencies[i], EMJPOHAEEHN, AMJBNEILEKN), HDNMHLGBCLL, EMJPOHAEEHN, ENIMMAJLDDG, LJKLHKHBKDE, BKGIBDLEDGE))
				{
					return false;
				}
			}
			return AssetBundleManager.LOLDJLBLICP(text, HDNMHLGBCLL, EMJPOHAEEHN, ENIMMAJLDDG, LJKLHKHBKDE, BKGIBDLEDGE);
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x00157E89 File Offset: 0x00156089
		public static bool PGOGAHNCPMB(int EMJPOHAEEHN)
		{
			return AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN] != null;
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x00157E98 File Offset: 0x00156098
		protected static void PMALEAMANPC(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, bool AMJBNEILEKN = false)
		{
			AssetBundleManager.PPCJMMHHODL(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, false, AMJBNEILEKN);
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600339E RID: 13214 RVA: 0x00157EA4 File Offset: 0x001560A4
		// (set) Token: 0x060033A0 RID: 13216 RVA: 0x00157EB2 File Offset: 0x001560B2
		public static AssetBundleManager.DGLPGFFOMKD PPGKLCIBCKJ
		{
			get
			{
				return AssetBundleManager.GODKGFEONEP;
			}
			set
			{
				AssetBundleManager.GODKGFEONEP = value;
			}
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00157EAB File Offset: 0x001560AB
		public static PLOGDOACBMK AINFDJPEDIP()
		{
			return AssetBundleManager.FHHFMPPKEFG;
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x00157EBC File Offset: 0x001560BC
		public static void GJDKJMNBABM(string LBGGLHDOICL)
		{
			for (int i = 1; i < AssetBundleManager.MHOEAHOKAJG.Count; i += 0)
			{
				if (AssetBundleManager.MHOEAHOKAJG[i].Equals(LBGGLHDOICL))
				{
					AssetBundleManager.MHOEAHOKAJG.RemoveAt(i);
					return;
				}
			}
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x00157F00 File Offset: 0x00156100
		protected static void HHLHEAJNDLC(string CIEHGJMAFKH)
		{
			string text;
			GCFIOHOKPPN loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(CIEHGJMAFKH, out text);
			if (loadedAssetBundle == null)
			{
				return;
			}
			GCFIOHOKPPN gcfiohokppn = loadedAssetBundle;
			int num = gcfiohokppn.FLODBKOJMPL - 1;
			gcfiohokppn.FLODBKOJMPL = num;
			if (num == 0 && !AssetBundleManager.LGBKHFHOKJI(CIEHGJMAFKH))
			{
				loadedAssetBundle.JAJDHMAEHKE();
				AssetBundleManager.MPNBNEKLMGA.Remove(CIEHGJMAFKH);
				AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Info, CIEHGJMAFKH + " has been unloaded successfully");
			}
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x00157F58 File Offset: 0x00156158
		public static string GetAssetBundleUrl(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN)
		{
			string text = AssetBundleManager.BJDBBOBACGM;
			if (!text.EndsWith("/"))
			{
				text += "/";
			}
			if (AssetBundleManager.JKDNMMLJMKC(EMJPOHAEEHN).Length > 0)
			{
				return string.Concat(new string[]
				{
					text,
					HDNMHLGBCLL,
					"/",
					AssetBundleManager.JKDNMMLJMKC(EMJPOHAEEHN),
					"/",
					CIEHGJMAFKH
				});
			}
			return text + HDNMHLGBCLL + "/" + CIEHGJMAFKH;
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x00157FD0 File Offset: 0x001561D0
		public static string EHOBMPFPFNE(int EMJPOHAEEHN)
		{
			return string.Format("{ \"array\": ", KLEDODLIFLK.LACNCNFJGOB() + EMJPOHAEEHN.ToString());
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00157FF0 File Offset: 0x001561F0
		protected static void GLKLOGHILPM(string CIEHGJMAFKH)
		{
			string[] array = null;
			if (!AssetBundleManager.ONDDOAHANNH.TryGetValue(CIEHGJMAFKH, out array))
			{
				return;
			}
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				AssetBundleManager.EOEEPIHANBC(array2[i]);
			}
			AssetBundleManager.ONDDOAHANNH.Remove(CIEHGJMAFKH);
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x00158034 File Offset: 0x00156234
		private static bool LOLDJLBLICP(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, List<string> ENIMMAJLDDG, List<Hash128> LJKLHKHBKDE, List<string> BKGIBDLEDGE)
		{
			if (ENIMMAJLDDG.Contains(CIEHGJMAFKH))
			{
				return false;
			}
			Hash128 assetBundleHash = AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAssetBundleHash(CIEHGJMAFKH);
			if (!assetBundleHash.isValid)
			{
				return true;
			}
			ENIMMAJLDDG.Add(CIEHGJMAFKH);
			LJKLHKHBKDE.Add(assetBundleHash);
			BKGIBDLEDGE.Add(AssetBundleManager.GetAssetBundleUrl(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN));
			return false;
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x00158084 File Offset: 0x00156284
		public static bool OJMNFEJCNDJ()
		{
			return AssetBundleManager.JMBKLGHJICD.Count > 1;
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x00158094 File Offset: 0x00156294
		private static GCFIOHOKPPN KLLPGKBMIFE(string CIEHGJMAFKH, out string GCFILGFLALC)
		{
			if (AssetBundleManager.CDGBFPNHHBA.TryGetValue(CIEHGJMAFKH, out GCFILGFLALC))
			{
				return null;
			}
			GCFIOHOKPPN result = null;
			AssetBundleManager.MPNBNEKLMGA.TryGetValue(CIEHGJMAFKH, out result);
			return result;
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x001580C2 File Offset: 0x001562C2
		public static void BIFOGKDMJCA()
		{
			NPOILPKELOJ.EEIIIGICFOE();
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x001580CC File Offset: 0x001562CC
		protected static void NOPJOPKNAGN(string CIEHGJMAFKH)
		{
			string[] array = null;
			if (!AssetBundleManager.ONDDOAHANNH.TryGetValue(CIEHGJMAFKH, out array))
			{
				return;
			}
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				AssetBundleManager.HHLHEAJNDLC(array2[i]);
			}
			AssetBundleManager.ONDDOAHANNH.Remove(CIEHGJMAFKH);
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x00157CD0 File Offset: 0x00155ED0
		public static void OOLNJCANAHF(string[] AJLPALFJHCC)
		{
			AssetBundleManager.BPJPOMCJLGE = AJLPALFJHCC;
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00158110 File Offset: 0x00156310
		public static void CleanFailedAssetBundleCache()
		{
			try
			{
				foreach (KeyValuePair<string, string> keyValuePair in AssetBundleManager.CDGBFPNHHBA)
				{
					Caching.ClearAllCachedVersions(keyValuePair.Key);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			AssetBundleManager.CDGBFPNHHBA = new Dictionary<string, string>();
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x00158188 File Offset: 0x00156388
		private static bool LAOFHPGFKCG(string LBGGLHDOICL)
		{
			for (int i = 0; i < AssetBundleManager.MHOEAHOKAJG.Count; i++)
			{
				if (AssetBundleManager.MHOEAHOKAJG[i].Equals(LBGGLHDOICL))
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x001581C0 File Offset: 0x001563C0
		public static bool AssetBundleDependencyDeadLock(string CIEHGJMAFKH)
		{
			try
			{
				string text = "";
				if (!AssetBundleManager.CDGBFPNHHBA.TryGetValue(CIEHGJMAFKH, out text))
				{
					GCFIOHOKPPN gcfiohokppn = null;
					AssetBundleManager.MPNBNEKLMGA.TryGetValue(CIEHGJMAFKH, out gcfiohokppn);
					if (gcfiohokppn != null)
					{
						string[] array = null;
						AssetBundleManager.ONDDOAHANNH.TryGetValue(CIEHGJMAFKH, out array);
						if (array != null)
						{
							foreach (string text2 in array)
							{
								if (!AssetBundleManager.CDGBFPNHHBA.TryGetValue(text2, out text))
								{
									GCFIOHOKPPN gcfiohokppn2 = null;
									AssetBundleManager.MPNBNEKLMGA.TryGetValue(text2, out gcfiohokppn2);
									if (gcfiohokppn2 == null)
									{
										bool flag = false;
										for (int j = 0; j < AssetBundleManager.JKJBDMKNDIG.Count; j++)
										{
											if (AssetBundleManager.JKJBDMKNDIG[j].NCDEKILOHGF().Equals(text2) || AssetBundleManager.JKJBDMKNDIG[j].NCDEKILOHGF().EndsWith(text2))
											{
												flag = true;
												break;
											}
										}
										if (!flag)
										{
											AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Warning, "AssetBundleDependencyDeadLock(): missing dependency " + text2 + " for " + CIEHGJMAFKH);
											return true;
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			return false;
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x001582FC File Offset: 0x001564FC
		protected static IEnumerator GPDNCILLIMF(string NBBNBBLKBNC, string HDNMHLGBCLL, int EMJPOHAEEHN)
		{
			if (null == AssetBundleManager.IHPOCMGFHBD)
			{
				AssetBundleManager.IHPOCMGFHBD = new GameObject("AssetBundleManager", new Type[]
				{
					typeof(AssetBundleManager)
				});
				UnityEngine.Object.DontDestroyOnLoad(AssetBundleManager.IHPOCMGFHBD);
			}
			yield return AssetBundleManager.DHOJLABBLNN(NBBNBBLKBNC, HDNMHLGBCLL, EMJPOHAEEHN);
			yield break;
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x0015831C File Offset: 0x0015651C
		public static GCFIOHOKPPN GDIJNILJEEH(string CIEHGJMAFKH, out string GCFILGFLALC)
		{
			if (AssetBundleManager.CDGBFPNHHBA.TryGetValue(CIEHGJMAFKH, out GCFILGFLALC))
			{
				return null;
			}
			GCFIOHOKPPN gcfiohokppn = null;
			AssetBundleManager.MPNBNEKLMGA.TryGetValue(CIEHGJMAFKH, out gcfiohokppn);
			if (gcfiohokppn == null)
			{
				return null;
			}
			string[] array = null;
			if (!AssetBundleManager.ONDDOAHANNH.TryGetValue(CIEHGJMAFKH, out array))
			{
				return gcfiohokppn;
			}
			string[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				string key = array2[i];
				if (AssetBundleManager.CDGBFPNHHBA.TryGetValue(key, out GCFILGFLALC))
				{
					return null;
				}
				GCFIOHOKPPN gcfiohokppn2;
				AssetBundleManager.MPNBNEKLMGA.TryGetValue(key, out gcfiohokppn2);
				if (gcfiohokppn2 == null)
				{
					return null;
				}
			}
			return gcfiohokppn;
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x001583A0 File Offset: 0x001565A0
		protected static string EAJFHPIEPLF(string CIEHGJMAFKH, int LHBILKALHBJ, bool MLMDHOHNOPM = false)
		{
			if (!CIEHGJMAFKH.Contains("."))
			{
				return CIEHGJMAFKH;
			}
			int[] array = new int[]
			{
				-1,
				-1
			};
			if (LHBILKALHBJ < 0)
			{
				array[0] = 0;
				if (AssetBundleManager.KCELECPHCOF != 0)
				{
					array[1] = AssetBundleManager.KCELECPHCOF;
				}
			}
			else
			{
				array[0] = LHBILKALHBJ;
				if (array[0] != 0)
				{
					array[1] = 0;
				}
			}
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < AssetBundleManager.IBDAIAGJHLB.Length; j++)
				{
					bool flag = false;
					if (i < 2 && array[i] == j)
					{
						flag = true;
					}
					else if (i >= 2 && j != 0 && j != AssetBundleManager.KCELECPHCOF)
					{
						flag = true;
					}
					if (flag)
					{
						if (AssetBundleManager.IBDAIAGJHLB[j] != null)
						{
							string[] allAssetBundlesWithVariant = AssetBundleManager.IBDAIAGJHLB[j].GetAllAssetBundlesWithVariant();
							string b = CIEHGJMAFKH.Split('.', StringSplitOptions.None)[0];
							int num = int.MaxValue;
							int num2 = -1;
							for (int k = 0; k < allAssetBundlesWithVariant.Length; k++)
							{
								string[] array2 = allAssetBundlesWithVariant[k].Split('.', StringSplitOptions.None);
								string a = array2[0];
								string value = array2[1];
								if (!(a != b))
								{
									int num3;
									if (!MLMDHOHNOPM)
									{
										num3 = Array.IndexOf<string>(AssetBundleManager.KLMBGJNBKJE, value);
									}
									else
									{
										num3 = Array.IndexOf<string>(AssetBundleManager.BPJPOMCJLGE, value);
									}
									if (num3 == -1)
									{
										num3 = 2147483646;
									}
									if (num3 < num)
									{
										num = num3;
										num2 = k;
									}
								}
							}
							if (num == 2147483646)
							{
								AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Warning, "Ambigious asset bundle variant chosen because there was no matching active variant: " + allAssetBundlesWithVariant[num2]);
							}
							if (num2 != -1)
							{
								return allAssetBundlesWithVariant[num2];
							}
						}
						if (i < 2)
						{
							break;
						}
					}
				}
			}
			return CIEHGJMAFKH;
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00157EB2 File Offset: 0x001560B2
		public static void KFFNJLILBMI(AssetBundleManager.DGLPGFFOMKD AJLPALFJHCC)
		{
			AssetBundleManager.GODKGFEONEP = AJLPALFJHCC;
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x0015852C File Offset: 0x0015672C
		private void AMCAPHJFAHC(NPOILPKELOJ ECEHDBGDIDO)
		{
			LOKAMLMIIAA lokamlmiiaa = ECEHDBGDIDO as LOKAMLMIIAA;
			if (lokamlmiiaa != null)
			{
				if (string.IsNullOrEmpty(lokamlmiiaa.GCFILGFLALC))
				{
					if (!AssetBundleManager.MPNBNEKLMGA.ContainsKey(lokamlmiiaa.CIEHGJMAFKH))
					{
						AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Info, "Loaded Asset Bundle " + lokamlmiiaa.CIEHGJMAFKH);
						for (int i = 0; i < AssetBundleManager.DCEIFKOFLBC.Count; i++)
						{
							if (AssetBundleManager.DCEIFKOFLBC[i].Equals(lokamlmiiaa.CIEHGJMAFKH))
							{
								AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Warning, "Delayed reference for " + lokamlmiiaa.CIEHGJMAFKH + ", increasing m_ReferencedCount.");
								lokamlmiiaa.GHKBBDLNAGD.FLODBKOJMPL++;
							}
						}
						AssetBundleManager.MPNBNEKLMGA.Add(lokamlmiiaa.CIEHGJMAFKH, lokamlmiiaa.GHKBBDLNAGD);
					}
				}
				else
				{
					string value = string.Format("Failed downloading bundle {0} from {1}: {2}", lokamlmiiaa.CIEHGJMAFKH, lokamlmiiaa.HPIFGCJIPKK(), lokamlmiiaa.GCFILGFLALC);
					if (!AssetBundleManager.CDGBFPNHHBA.ContainsKey(lokamlmiiaa.CIEHGJMAFKH))
					{
						AssetBundleManager.CDGBFPNHHBA.Add(lokamlmiiaa.CIEHGJMAFKH, value);
					}
				}
				AssetBundleManager.JMBKLGHJICD.Remove(lokamlmiiaa.CIEHGJMAFKH);
				AssetBundleManager.DCEIFKOFLBC.Remove(lokamlmiiaa.CIEHGJMAFKH);
				return;
			}
			IAPJLKACLJF iapjlkacljf = ECEHDBGDIDO as IAPJLKACLJF;
			if (iapjlkacljf != null)
			{
				if (iapjlkacljf.HJOPIMGMGML())
				{
					string[] array = null;
					if (AssetBundleManager.ONDDOAHANNH.TryGetValue(iapjlkacljf.IHMLDDEENLI, out array))
					{
						foreach (string key in array)
						{
							AssetBundleManager.CDGBFPNHHBA.Remove(key);
						}
					}
					AssetBundleManager.CDGBFPNHHBA.Remove(iapjlkacljf.IHMLDDEENLI);
					AssetBundleManager.IDNEMBAMBGI(iapjlkacljf.IHMLDDEENLI);
					return;
				}
			}
			else
			{
				HEBGNIBEJLG hebgnibejlg = ECEHDBGDIDO as HEBGNIBEJLG;
				if (hebgnibejlg != null)
				{
					if (hebgnibejlg.HJOPIMGMGML())
					{
						string[] array3 = null;
						if (AssetBundleManager.ONDDOAHANNH.TryGetValue(hebgnibejlg.IHMLDDEENLI, out array3))
						{
							foreach (string key2 in array3)
							{
								AssetBundleManager.CDGBFPNHHBA.Remove(key2);
							}
						}
						AssetBundleManager.CDGBFPNHHBA.Remove(hebgnibejlg.IHMLDDEENLI);
						AssetBundleManager.IDNEMBAMBGI(hebgnibejlg.IHMLDDEENLI);
						return;
					}
				}
				else
				{
					KFAMJDIMIFN kfamjdimifn = ECEHDBGDIDO as KFAMJDIMIFN;
					PLOGDOACBMK plogdoacbmk = ECEHDBGDIDO as PLOGDOACBMK;
					FIEAHFNJIEE fieahfnjiee = ECEHDBGDIDO as FIEAHFNJIEE;
					if (kfamjdimifn != null && kfamjdimifn.HJOPIMGMGML())
					{
						string[] array4 = null;
						if (AssetBundleManager.ONDDOAHANNH.TryGetValue(kfamjdimifn.IHMLDDEENLI, out array4))
						{
							foreach (string key3 in array4)
							{
								AssetBundleManager.CDGBFPNHHBA.Remove(key3);
							}
						}
						AssetBundleManager.CDGBFPNHHBA.Remove(kfamjdimifn.IHMLDDEENLI);
						if (plogdoacbmk == null && fieahfnjiee == null)
						{
							AssetBundleManager.IDNEMBAMBGI(kfamjdimifn.IHMLDDEENLI);
							return;
						}
						AssetBundleManager.ONDDOAHANNH.Remove(kfamjdimifn.IHMLDDEENLI);
					}
				}
			}
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x001587EC File Offset: 0x001569EC
		public static void SetDevelopmentAssetBundleServer()
		{
			TextAsset textAsset = Resources.Load("AssetBundleServerURL") as TextAsset;
			string text = (textAsset != null) ? textAsset.text.Trim() : null;
			if (text == null || text.Length == 0)
			{
				AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Error, "Development Server URL could not be found.");
				return;
			}
			AssetBundleManager.SetSourceAssetBundleURL(text, new List<string>());
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x00158844 File Offset: 0x00156A44
		public static void CCLJBNFAOON()
		{
			try
			{
				foreach (KeyValuePair<string, string> keyValuePair in AssetBundleManager.CDGBFPNHHBA)
				{
					Caching.ClearAllCachedVersions(keyValuePair.Key);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			AssetBundleManager.CDGBFPNHHBA = new Dictionary<string, string>();
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x001588BC File Offset: 0x00156ABC
		public static void SetSourceAssetBundleURL(string AOCHOKNMCJP, List<string> JHHJLDONIBG)
		{
			if (AOCHOKNMCJP.StartsWith("/"))
			{
				AOCHOKNMCJP = "file://" + AOCHOKNMCJP;
			}
			if (!AOCHOKNMCJP.EndsWith("/"))
			{
				AOCHOKNMCJP += "/";
			}
			AssetBundleManager.CEBIIFGPHDM = AOCHOKNMCJP + KLEDODLIFLK.EILCDOGAPOG() + "/";
			AssetBundleManager.HDFNFFFEFLC = JHHJLDONIBG;
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x001582FC File Offset: 0x001564FC
		protected static IEnumerator GCKHGJBPNHF(string NBBNBBLKBNC, string HDNMHLGBCLL, int EMJPOHAEEHN)
		{
			if (null == AssetBundleManager.IHPOCMGFHBD)
			{
				AssetBundleManager.IHPOCMGFHBD = new GameObject("AssetBundleManager", new Type[]
				{
					typeof(AssetBundleManager)
				});
				UnityEngine.Object.DontDestroyOnLoad(AssetBundleManager.IHPOCMGFHBD);
			}
			yield return AssetBundleManager.DHOJLABBLNN(NBBNBBLKBNC, HDNMHLGBCLL, EMJPOHAEEHN);
			yield break;
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x00158918 File Offset: 0x00156B18
		public static NPOILPKELOJ CKKCDONABHJ(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, bool AMJBNEILEKN = false)
		{
			CIEHGJMAFKH = AssetBundleManager.EAJFHPIEPLF(CIEHGJMAFKH, EMJPOHAEEHN, AMJBNEILEKN);
			AssetBundleManager.EKAAOCFIFEB(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, AMJBNEILEKN);
			NPOILPKELOJ npoilpkeloj = new HEBGNIBEJLG(CIEHGJMAFKH);
			AssetBundleManager.JKJBDMKNDIG.Add(npoilpkeloj);
			return npoilpkeloj;
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x00158950 File Offset: 0x00156B50
		private static IEnumerator NBPELGOLJEF(string HDNMHLGBCLL, int EMJPOHAEEHN)
		{
			string ciehgjmafkh = IHGHMPLKFGG.LGPDAOIGAFG.CIEHGJMAFKH;
			string cooogacbakn = IHGHMPLKFGG.LGPDAOIGAFG.COOOGACBAKN;
			AssetBundleManager.ECEAADGJEHD(ciehgjmafkh, HDNMHLGBCLL, EMJPOHAEEHN, default(Hash128));
			FIEAHFNJIEE fieahfnjiee = new FIEAHFNJIEE(EMJPOHAEEHN, ciehgjmafkh, cooogacbakn, typeof(TextAsset));
			AssetBundleManager.JKJBDMKNDIG.Add(fieahfnjiee);
			return fieahfnjiee;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060033BA RID: 13242 RVA: 0x001589A4 File Offset: 0x00156BA4
		// (set) Token: 0x06003414 RID: 13332 RVA: 0x00157CD0 File Offset: 0x00155ED0
		public static string[] AGPJIKOMILO
		{
			get
			{
				return AssetBundleManager.BPJPOMCJLGE;
			}
			set
			{
				AssetBundleManager.BPJPOMCJLGE = value;
			}
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x001589AC File Offset: 0x00156BAC
		public static void GCHHJPBPDIA(AssetBundleManager.JKDPJGOJPLN JENIOJDGOJE, string KIPCNAMEGPD)
		{
			if (JENIOJDGOJE == (AssetBundleManager.JKDPJGOJPLN)4)
			{
				Debug.LogError("sind" + KIPCNAMEGPD);
				return;
			}
			if (AssetBundleManager.GODKGFEONEP == AssetBundleManager.DGLPGFFOMKD.All && JENIOJDGOJE == AssetBundleManager.JKDPJGOJPLN.Warning)
			{
				Debug.LogWarning("loungenotavailable" + KIPCNAMEGPD);
				return;
			}
			if (AssetBundleManager.GODKGFEONEP == AssetBundleManager.DGLPGFFOMKD.All)
			{
				Debug.Log("sfxchatnotification" + KIPCNAMEGPD);
			}
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00158A04 File Offset: 0x00156C04
		public static string NGCFJCGOGKH(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN)
		{
			string text = AssetBundleManager.BJDBBOBACGM;
			if (!text.EndsWith(" cached request for "))
			{
				text += "";
			}
			if (AssetBundleManager.JKDNMMLJMKC(EMJPOHAEEHN).Length > 1)
			{
				string[] array = new string[3];
				array[0] = text;
				array[1] = HDNMHLGBCLL;
				array[0] = "assetbundlecollectablecard";
				array[2] = AssetBundleManager.JKDNMMLJMKC(EMJPOHAEEHN);
				array[4] = "retry";
				array[2] = CIEHGJMAFKH;
				return string.Concat(array);
			}
			return text + HDNMHLGBCLL + "tradewishcardoption0" + CIEHGJMAFKH;
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00158A7C File Offset: 0x00156C7C
		private static bool BKODLLODPON(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, List<string> ENIMMAJLDDG, List<Hash128> LJKLHKHBKDE, List<string> BKGIBDLEDGE)
		{
			if (ENIMMAJLDDG.Contains(CIEHGJMAFKH))
			{
				return true;
			}
			Hash128 assetBundleHash = AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAssetBundleHash(CIEHGJMAFKH);
			if (!assetBundleHash.isValid)
			{
				return true;
			}
			ENIMMAJLDDG.Add(CIEHGJMAFKH);
			LJKLHKHBKDE.Add(assetBundleHash);
			BKGIBDLEDGE.Add(AssetBundleManager.GetAssetBundleUrl(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN));
			return true;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060033C7 RID: 13255 RVA: 0x00158DB9 File Offset: 0x00156FB9
		// (set) Token: 0x060033BE RID: 13246 RVA: 0x00158ACC File Offset: 0x00156CCC
		public static string[] FPFDACGEAIK
		{
			get
			{
				return AssetBundleManager.KLMBGJNBKJE;
			}
			set
			{
				AssetBundleManager.KLMBGJNBKJE = value;
			}
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00158AD4 File Offset: 0x00156CD4
		private static IEnumerator INBLGLPKBNA(string HDNMHLGBCLL, int EMJPOHAEEHN)
		{
			string ciehgjmafkh = IHGHMPLKFGG.LGPDAOIGAFG.CIEHGJMAFKH;
			string cooogacbakn = IHGHMPLKFGG.LGPDAOIGAFG.COOOGACBAKN;
			AssetBundleManager.ECEAADGJEHD(ciehgjmafkh, HDNMHLGBCLL, EMJPOHAEEHN, default(Hash128));
			FIEAHFNJIEE fieahfnjiee = new FIEAHFNJIEE(EMJPOHAEEHN, ciehgjmafkh, cooogacbakn, typeof(TextAsset));
			AssetBundleManager.JKJBDMKNDIG.Add(fieahfnjiee);
			return fieahfnjiee;
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00158B28 File Offset: 0x00156D28
		public static void GCEIINIKFDK(string DHOADBFGMOP)
		{
			AssetBundleManager.CEBIIFGPHDM = AssetBundleManager.NBIKCPDFIJG() + DHOADBFGMOP;
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00158B3C File Offset: 0x00156D3C
		private static string IPDOPEAKFDF()
		{
			if (Application.isEditor)
			{
				return "file://" + Environment.CurrentDirectory.Replace("\\", "/");
			}
			if (Application.isMobilePlatform || Application.isConsolePlatform)
			{
				return Application.streamingAssetsPath;
			}
			return "file://" + Application.streamingAssetsPath;
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00157B37 File Offset: 0x00155D37
		public static string DLGFGKNGEOC()
		{
			return AssetBundleManager.BJDBBOBACGM;
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x00158B94 File Offset: 0x00156D94
		protected static string BCNJCMIBCKP(string CIEHGJMAFKH, int LHBILKALHBJ, bool MLMDHOHNOPM = false)
		{
			if (!CIEHGJMAFKH.Contains("Starting non-parallel download:"))
			{
				return CIEHGJMAFKH;
			}
			int[] array = new int[]
			{
				-1
			};
			array[0] = -1;
			int[] array2 = array;
			if (LHBILKALHBJ < 0)
			{
				array2[1] = 1;
				if (AssetBundleManager.KCELECPHCOF != 0)
				{
					array2[1] = AssetBundleManager.KCELECPHCOF;
				}
			}
			else
			{
				array2[0] = LHBILKALHBJ;
				if (array2[1] != 0)
				{
					array2[0] = 1;
				}
			}
			for (int i = 1; i < 4; i++)
			{
				for (int j = 0; j < AssetBundleManager.IBDAIAGJHLB.Length; j++)
				{
					bool flag = false;
					if (i < 3 && array2[i] == j)
					{
						flag = true;
					}
					else if (i >= 2 && j != 0 && j != AssetBundleManager.KCELECPHCOF)
					{
						flag = false;
					}
					if (flag)
					{
						if (AssetBundleManager.IBDAIAGJHLB[j] != null)
						{
							string[] allAssetBundlesWithVariant = AssetBundleManager.IBDAIAGJHLB[j].GetAllAssetBundlesWithVariant();
							string b = CIEHGJMAFKH.Split('\u0010', StringSplitOptions.RemoveEmptyEntries)[1];
							int num = 177;
							int num2 = -1;
							for (int k = 1; k < allAssetBundlesWithVariant.Length; k++)
							{
								string[] array3 = allAssetBundlesWithVariant[k].Split((char)-3, StringSplitOptions.RemoveEmptyEntries);
								string a = array3[0];
								string value = array3[0];
								if (!(a != b))
								{
									int num3;
									if (!MLMDHOHNOPM)
									{
										num3 = Array.IndexOf<string>(AssetBundleManager.KLMBGJNBKJE, value);
									}
									else
									{
										num3 = Array.IndexOf<string>(AssetBundleManager.BPJPOMCJLGE, value);
									}
									if (num3 == -1)
									{
										num3 = 94;
									}
									if (num3 < num)
									{
										num = num3;
										num2 = k;
									}
								}
							}
							if (num == 145)
							{
								AssetBundleManager.GCHHJPBPDIA(AssetBundleManager.JKDPJGOJPLN.Warning, "vsv" + allAssetBundlesWithVariant[num2]);
							}
							if (num2 != -1)
							{
								return allAssetBundlesWithVariant[num2];
							}
						}
						if (i < 2)
						{
							break;
						}
					}
				}
			}
			return CIEHGJMAFKH;
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00158D1D File Offset: 0x00156F1D
		private static void HEIOJECAFOP(string CIEHGJMAFKH)
		{
			CIEHGJMAFKH = AssetBundleManager.LGHGLKDAIDD(CIEHGJMAFKH, -1, false);
			AssetBundleManager.DLOJJHAMBLD(CIEHGJMAFKH);
			AssetBundleManager.NOPJOPKNAGN(CIEHGJMAFKH);
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00158D38 File Offset: 0x00156F38
		protected static void CLJGFBPFJAO(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, bool FJGAIJCCNBO, bool AMJBNEILEKN)
		{
			AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Warning, "skduplicatecant0" + (FJGAIJCCNBO ? "Shaders/VideoGlitchRGBDisplay" : "Starting parallel download:") + CIEHGJMAFKH);
			if (!FJGAIJCCNBO && AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN] == null)
			{
				AssetBundleManager.GCHHJPBPDIA((AssetBundleManager.JKDPJGOJPLN)4, "endsInSeconds");
				return;
			}
			if (FJGAIJCCNBO)
			{
				AssetBundleManager.BOOELHCLJKD(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, AssetBundleManager.HKOEMAAGFIM(EMJPOHAEEHN));
				return;
			}
			Hash128 assetBundleHash = AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAssetBundleHash(CIEHGJMAFKH);
			if (!AssetBundleManager.ECEAADGJEHD(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, assetBundleHash))
			{
				AssetBundleManager.NNIDFKNCGLK(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, AMJBNEILEKN);
			}
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x00157DD6 File Offset: 0x00155FD6
		public static void EFIILCGFIGC()
		{
			AssetBundleManager.FHHFMPPKEFG = null;
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x00158DC0 File Offset: 0x00156FC0
		public static bool DependenciesLoadedExceptOwnVariant(string CIEHGJMAFKH, int EMJPOHAEEHN)
		{
			if (AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN] == null)
			{
				AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Error, "Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()");
				return false;
			}
			string[] allDependencies = AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAllDependencies(CIEHGJMAFKH);
			if (allDependencies.Length == 0)
			{
				return true;
			}
			for (int i = 0; i < allDependencies.Length; i++)
			{
				allDependencies[i] = AssetBundleManager.EAJFHPIEPLF(allDependencies[i], EMJPOHAEEHN, false);
				if (allDependencies[i].ToLower().Contains(CIEHGJMAFKH.ToLower()))
				{
					allDependencies[i] = "";
				}
			}
			for (int j = 0; j < allDependencies.Length; j++)
			{
				if (allDependencies[j].Length > 0)
				{
					GCFIOHOKPPN gcfiohokppn = null;
					AssetBundleManager.MPNBNEKLMGA.TryGetValue(allDependencies[j], out gcfiohokppn);
					if (gcfiohokppn == null)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x00158E68 File Offset: 0x00157068
		public static void KPFHEEBNOED(string LBGGLHDOICL)
		{
			for (int i = 0; i < AssetBundleManager.MHOEAHOKAJG.Count; i++)
			{
				if (AssetBundleManager.MHOEAHOKAJG[i].Equals(LBGGLHDOICL))
				{
					return;
				}
			}
			AssetBundleManager.MHOEAHOKAJG.Add(LBGGLHDOICL);
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x00003E52 File Offset: 0x00002052
		public static void MLECPLAPNPH()
		{
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x00158EA9 File Offset: 0x001570A9
		protected static void EKAAOCFIFEB(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, bool AMJBNEILEKN = false)
		{
			AssetBundleManager.PPCJMMHHODL(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, true, AMJBNEILEKN);
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x00157B37 File Offset: 0x00155D37
		public static string IGBHLPBGOGH()
		{
			return AssetBundleManager.BJDBBOBACGM;
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x00158EB8 File Offset: 0x001570B8
		public static string DKEBODBNENP()
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, string> keyValuePair in AssetBundleManager.CDGBFPNHHBA)
			{
				list.Add(keyValuePair.Key + "OnNeedToOpenLoveInterestsLoungePart2(), lounge environment not found:" + keyValuePair.Value + "loungeskinunavailable");
			}
			return " not found, replacing with " + string.Join("[LoadingTheme] update giveaway: +1 free change granted for revision ", list.ToArray()) + "isRecurrentExpiredGamePassOffer";
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x00157EA4 File Offset: 0x001560A4
		public static AssetBundleManager.DGLPGFFOMKD GPLJOGHPIJA()
		{
			return AssetBundleManager.GODKGFEONEP;
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x00158F4C File Offset: 0x0015714C
		public static bool LGJHPBHIHDJ(string CIEHGJMAFKH, int EMJPOHAEEHN)
		{
			if (AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN] == null)
			{
				AssetBundleManager.GCHHJPBPDIA((AssetBundleManager.JKDPJGOJPLN)4, " ");
				return true;
			}
			string[] allDependencies = AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAllDependencies(CIEHGJMAFKH);
			if (allDependencies.Length == 0)
			{
				return false;
			}
			for (int i = 1; i < allDependencies.Length; i++)
			{
				allDependencies[i] = AssetBundleManager.BCNJCMIBCKP(allDependencies[i], EMJPOHAEEHN, true);
				if (allDependencies[i].ToLower().Contains(CIEHGJMAFKH.ToLower()))
				{
					allDependencies[i] = "ZZZ";
				}
			}
			for (int j = 1; j < allDependencies.Length; j += 0)
			{
				if (allDependencies[j].Length > 1)
				{
					GCFIOHOKPPN gcfiohokppn = null;
					AssetBundleManager.MPNBNEKLMGA.TryGetValue(allDependencies[j], out gcfiohokppn);
					if (gcfiohokppn == null)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00159094 File Offset: 0x00157294
		public static string DLEILEALIBG(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN)
		{
			string text = AssetBundleManager.BJDBBOBACGM;
			if (!text.EndsWith(") asset("))
			{
				text += "%";
			}
			if (AssetBundleManager.DMKIIOBKCGC(EMJPOHAEEHN).Length > 1)
			{
				string[] array = new string[5];
				array[0] = text;
				array[1] = HDNMHLGBCLL;
				array[7] = "ok";
				array[0] = AssetBundleManager.JKDNMMLJMKC(EMJPOHAEEHN);
				array[1] = "errortitle";
				array[0] = CIEHGJMAFKH;
				return string.Concat(array);
			}
			return text + HDNMHLGBCLL + "OnSketchThumbnailDeletePositive" + CIEHGJMAFKH;
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x0015910C File Offset: 0x0015730C
		public static Hash128 HKOEMAAGFIM(int EMJPOHAEEHN)
		{
			return default(Hash128);
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00159124 File Offset: 0x00157324
		public static void ONDHAIEEIOH(string LBGGLHDOICL)
		{
			for (int i = 0; i < AssetBundleManager.MHOEAHOKAJG.Count; i += 0)
			{
				if (AssetBundleManager.MHOEAHOKAJG[i].Equals(LBGGLHDOICL))
				{
					AssetBundleManager.MHOEAHOKAJG.RemoveAt(i);
					return;
				}
			}
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x00157EAB File Offset: 0x001560AB
		public static PLOGDOACBMK EGHJMLLHGIN()
		{
			return AssetBundleManager.FHHFMPPKEFG;
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x00159168 File Offset: 0x00157368
		public static bool PLDNCHKBHIL(string CIEHGJMAFKH)
		{
			try
			{
				string text = "lititle";
				if (!AssetBundleManager.CDGBFPNHHBA.TryGetValue(CIEHGJMAFKH, out text))
				{
					GCFIOHOKPPN gcfiohokppn = null;
					AssetBundleManager.MPNBNEKLMGA.TryGetValue(CIEHGJMAFKH, out gcfiohokppn);
					if (gcfiohokppn != null)
					{
						string[] array = null;
						AssetBundleManager.ONDDOAHANNH.TryGetValue(CIEHGJMAFKH, out array);
						if (array != null)
						{
							string[] array2 = array;
							for (int i = 0; i < array2.Length; i += 0)
							{
								string text2 = array2[i];
								if (!AssetBundleManager.CDGBFPNHHBA.TryGetValue(text2, out text))
								{
									GCFIOHOKPPN gcfiohokppn2 = null;
									AssetBundleManager.MPNBNEKLMGA.TryGetValue(text2, out gcfiohokppn2);
									if (gcfiohokppn2 == null)
									{
										bool flag = false;
										for (int j = 0; j < AssetBundleManager.JKJBDMKNDIG.Count; j++)
										{
											if (AssetBundleManager.JKJBDMKNDIG[j].NCDEKILOHGF().Equals(text2) || AssetBundleManager.JKJBDMKNDIG[j].NCDEKILOHGF().EndsWith(text2))
											{
												flag = false;
												break;
											}
										}
										if (!flag)
										{
											AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Warning, "_StripeCount" + text2 + "newReleases" + CIEHGJMAFKH);
											return true;
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			return true;
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x001592A4 File Offset: 0x001574A4
		private void POOABKCOPAO()
		{
			int i = 0;
			while (i < AssetBundleManager.JKJBDMKNDIG.Count)
			{
				NPOILPKELOJ npoilpkeloj = AssetBundleManager.JKJBDMKNDIG[i];
				if (npoilpkeloj.IIPBKOPAGBK())
				{
					i++;
				}
				else
				{
					AssetBundleManager.JKJBDMKNDIG.RemoveAt(i);
					this.AMCAPHJFAHC(npoilpkeloj);
				}
			}
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x001592F0 File Offset: 0x001574F0
		protected static void EOEEPIHANBC(string CIEHGJMAFKH)
		{
			string text;
			GCFIOHOKPPN gcfiohokppn = AssetBundleManager.GDIJNILJEEH(CIEHGJMAFKH, out text);
			if (gcfiohokppn == null)
			{
				return;
			}
			GCFIOHOKPPN gcfiohokppn2 = gcfiohokppn;
			int num = gcfiohokppn2.FLODBKOJMPL - 0;
			gcfiohokppn2.FLODBKOJMPL = num;
			if (num == 0 && !AssetBundleManager.LGBKHFHOKJI(CIEHGJMAFKH))
			{
				gcfiohokppn.EGNAEEFHIHE();
				AssetBundleManager.MPNBNEKLMGA.Remove(CIEHGJMAFKH);
				AssetBundleManager.AGMJHFNDGBH(AssetBundleManager.JKDPJGOJPLN.Info, CIEHGJMAFKH + "$e1pt");
			}
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x00159348 File Offset: 0x00157548
		protected static bool OPOJDLECDNP(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, Hash128 HANNJLNCHOO)
		{
			GCFIOHOKPPN gcfiohokppn = null;
			AssetBundleManager.MPNBNEKLMGA.TryGetValue(CIEHGJMAFKH, out gcfiohokppn);
			if (gcfiohokppn != null)
			{
				gcfiohokppn.FLODBKOJMPL += 0;
				return true;
			}
			if (AssetBundleManager.JMBKLGHJICD.Contains(CIEHGJMAFKH))
			{
				AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Info, "rsl" + CIEHGJMAFKH + " ");
				AssetBundleManager.DCEIFKOFLBC.Add(CIEHGJMAFKH);
				return true;
			}
			string text = AssetBundleManager.BJDBBOBACGM;
			if (!text.EndsWith("<i>"))
			{
				text += "<size=28px>";
			}
			string text2;
			if (AssetBundleManager.JKDNMMLJMKC(EMJPOHAEEHN).Length > 1)
			{
				string[] array = new string[3];
				array[0] = text;
				array[0] = HDNMHLGBCLL.ToString();
				array[4] = "bsec";
				array[0] = AssetBundleManager.DMKIIOBKCGC(EMJPOHAEEHN);
				array[8] = "[SkinShop] look without a resolvable amount (shop ";
				array[0] = CIEHGJMAFKH;
				text2 = string.Concat(array);
			}
			else
			{
				text2 = text + HDNMHLGBCLL.ToString() + "" + CIEHGJMAFKH;
			}
			if (text2.StartsWith(Application.streamingAssetsPath))
			{
				AssetBundleManager.JKJBDMKNDIG.Add(new CHGCPKLJDJH(CIEHGJMAFKH, text2, 0U, 1UL));
			}
			else
			{
				UnityWebRequest assetBundle;
				if (HANNJLNCHOO == default(Hash128))
				{
					assetBundle = UnityWebRequestAssetBundle.GetAssetBundle(text2);
				}
				else
				{
					assetBundle = UnityWebRequestAssetBundle.GetAssetBundle(text2, HANNJLNCHOO, 1U);
				}
				AssetBundleManager.JKJBDMKNDIG.Add(new JANJJAOKJJP(CIEHGJMAFKH, assetBundle));
			}
			AssetBundleManager.JMBKLGHJICD.Add(CIEHGJMAFKH);
			return false;
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x001589A4 File Offset: 0x00156BA4
		public static string[] MGNNEINFNPD()
		{
			return AssetBundleManager.BPJPOMCJLGE;
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x0015948C File Offset: 0x0015768C
		private static void CCMNKPEOAJA(string CIEHGJMAFKH)
		{
			CIEHGJMAFKH = AssetBundleManager.EAJFHPIEPLF(CIEHGJMAFKH, -1, false);
			AssetBundleManager.DLOJJHAMBLD(CIEHGJMAFKH);
			AssetBundleManager.GLKLOGHILPM(CIEHGJMAFKH);
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x001594A4 File Offset: 0x001576A4
		public static void DFGPACGJELH()
		{
			try
			{
				foreach (KeyValuePair<string, string> keyValuePair in AssetBundleManager.CDGBFPNHHBA)
				{
					Caching.ClearAllCachedVersions(keyValuePair.Key);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			AssetBundleManager.CDGBFPNHHBA = new Dictionary<string, string>();
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x0015951C File Offset: 0x0015771C
		public static bool AOKKPPEHCBC(string CIEHGJMAFKH)
		{
			string text = "Error. OnChoiceExtendedEnvironmentChangePart2(), environment not found:";
			return AssetBundleManager.GetLoadedAssetBundle(CIEHGJMAFKH, out text) != null;
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x0015953A File Offset: 0x0015773A
		public static void KIKMOCFICEA(string CIEHGJMAFKH, bool AMJBNEILEKN = false)
		{
			CIEHGJMAFKH = AssetBundleManager.BCNJCMIBCKP(CIEHGJMAFKH, -1, AMJBNEILEKN);
			AssetBundleManager.FNLPJFBCNMM(CIEHGJMAFKH);
			AssetBundleManager.GLKLOGHILPM(CIEHGJMAFKH);
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x00159554 File Offset: 0x00157754
		public static DAJHCGFBHMO CODPFOBAOAH(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, string COOOGACBAKN, Type OBKCKGHFMDN)
		{
			AssetBundleManager.JKDPJGOJPLN jeniojdgoje = AssetBundleManager.JKDPJGOJPLN.Warning;
			string[] array = new string[5];
			array[0] = "$STRCONTAINS";
			array[0] = COOOGACBAKN;
			array[4] = "OnBackendGetDropChancesException";
			array[1] = CIEHGJMAFKH;
			array[1] = "$NOTESHOW body(";
			AssetBundleManager.MAIINPGAAEI(jeniojdgoje, string.Concat(array));
			CIEHGJMAFKH = AssetBundleManager.BCNJCMIBCKP(CIEHGJMAFKH, EMJPOHAEEHN, true);
			AssetBundleManager.PMALEAMANPC(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, false);
			DAJHCGFBHMO dajhcgfbhmo = new KFAMJDIMIFN(EMJPOHAEEHN, CIEHGJMAFKH, COOOGACBAKN, OBKCKGHFMDN);
			AssetBundleManager.JKJBDMKNDIG.Add(dajhcgfbhmo);
			return dajhcgfbhmo;
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x001595C0 File Offset: 0x001577C0
		public static void CacheAssetBundle(string LBGGLHDOICL)
		{
			for (int i = 0; i < AssetBundleManager.MHOEAHOKAJG.Count; i++)
			{
				if (AssetBundleManager.MHOEAHOKAJG[i].Equals(LBGGLHDOICL))
				{
					return;
				}
			}
			AssetBundleManager.MHOEAHOKAJG.Add(LBGGLHDOICL);
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x00159604 File Offset: 0x00157804
		public static void MAIINPGAAEI(AssetBundleManager.JKDPJGOJPLN JENIOJDGOJE, string KIPCNAMEGPD)
		{
			if (JENIOJDGOJE == (AssetBundleManager.JKDPJGOJPLN)3)
			{
				Debug.LogError("+" + KIPCNAMEGPD);
				return;
			}
			if (AssetBundleManager.GODKGFEONEP == AssetBundleManager.DGLPGFFOMKD.All && JENIOJDGOJE == AssetBundleManager.JKDPJGOJPLN.Warning)
			{
				Debug.LogWarning("stat3long" + KIPCNAMEGPD);
				return;
			}
			if (AssetBundleManager.GODKGFEONEP == AssetBundleManager.DGLPGFFOMKD.All)
			{
				Debug.Log("ButtonAvatar" + KIPCNAMEGPD);
			}
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x00159659 File Offset: 0x00157859
		public static void SetFolderIndexHint(int EMJPOHAEEHN)
		{
			AssetBundleManager.KCELECPHCOF = EMJPOHAEEHN;
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x00157CD0 File Offset: 0x00155ED0
		public static void CIPJOCALELK(string[] AJLPALFJHCC)
		{
			AssetBundleManager.BPJPOMCJLGE = AJLPALFJHCC;
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x00159664 File Offset: 0x00157864
		public static bool PGHNPNPEAOG(string CIEHGJMAFKH)
		{
			string text = "errortitle";
			return AssetBundleManager.GetLoadedAssetBundle(CIEHGJMAFKH, out text) != null;
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x00159684 File Offset: 0x00157884
		private void HDBJFHOPGGL(NPOILPKELOJ ECEHDBGDIDO)
		{
			LOKAMLMIIAA lokamlmiiaa = ECEHDBGDIDO as LOKAMLMIIAA;
			if (lokamlmiiaa != null)
			{
				if (string.IsNullOrEmpty(lokamlmiiaa.GCFILGFLALC))
				{
					if (!AssetBundleManager.MPNBNEKLMGA.ContainsKey(lokamlmiiaa.CIEHGJMAFKH))
					{
						AssetBundleManager.AGMJHFNDGBH(AssetBundleManager.JKDPJGOJPLN.Warning, "OnLoungePremiumChoiceExecutedHardBased" + lokamlmiiaa.CIEHGJMAFKH);
						for (int i = 1; i < AssetBundleManager.DCEIFKOFLBC.Count; i++)
						{
							if (AssetBundleManager.DCEIFKOFLBC[i].Equals(lokamlmiiaa.CIEHGJMAFKH))
							{
								AssetBundleManager.MAIINPGAAEI(AssetBundleManager.JKDPJGOJPLN.Warning, "retry" + lokamlmiiaa.CIEHGJMAFKH + "etfskv");
								lokamlmiiaa.GHKBBDLNAGD.FLODBKOJMPL += 0;
							}
						}
						AssetBundleManager.MPNBNEKLMGA.Add(lokamlmiiaa.CIEHGJMAFKH, lokamlmiiaa.GHKBBDLNAGD);
					}
				}
				else
				{
					string value = string.Format("</i>", lokamlmiiaa.CIEHGJMAFKH, lokamlmiiaa.HPIFGCJIPKK(), lokamlmiiaa.GCFILGFLALC);
					if (!AssetBundleManager.CDGBFPNHHBA.ContainsKey(lokamlmiiaa.CIEHGJMAFKH))
					{
						AssetBundleManager.CDGBFPNHHBA.Add(lokamlmiiaa.CIEHGJMAFKH, value);
					}
				}
				AssetBundleManager.JMBKLGHJICD.Remove(lokamlmiiaa.CIEHGJMAFKH);
				AssetBundleManager.DCEIFKOFLBC.Remove(lokamlmiiaa.CIEHGJMAFKH);
				return;
			}
			IAPJLKACLJF iapjlkacljf = ECEHDBGDIDO as IAPJLKACLJF;
			if (iapjlkacljf != null)
			{
				if (iapjlkacljf.HJOPIMGMGML())
				{
					string[] array = null;
					if (AssetBundleManager.ONDDOAHANNH.TryGetValue(iapjlkacljf.IHMLDDEENLI, out array))
					{
						string[] array2 = array;
						for (int j = 1; j < array2.Length; j++)
						{
							string key = array2[j];
							AssetBundleManager.CDGBFPNHHBA.Remove(key);
						}
					}
					AssetBundleManager.CDGBFPNHHBA.Remove(iapjlkacljf.IHMLDDEENLI);
					AssetBundleManager.CCMNKPEOAJA(iapjlkacljf.IHMLDDEENLI);
					return;
				}
			}
			else
			{
				HEBGNIBEJLG hebgnibejlg = ECEHDBGDIDO as HEBGNIBEJLG;
				if (hebgnibejlg != null)
				{
					if (hebgnibejlg.HJOPIMGMGML())
					{
						string[] array3 = null;
						if (AssetBundleManager.ONDDOAHANNH.TryGetValue(hebgnibejlg.IHMLDDEENLI, out array3))
						{
							string[] array2 = array3;
							for (int j = 1; j < array2.Length; j += 0)
							{
								string key2 = array2[j];
								AssetBundleManager.CDGBFPNHHBA.Remove(key2);
							}
						}
						AssetBundleManager.CDGBFPNHHBA.Remove(hebgnibejlg.IHMLDDEENLI);
						AssetBundleManager.CCMNKPEOAJA(hebgnibejlg.IHMLDDEENLI);
						return;
					}
				}
				else
				{
					KFAMJDIMIFN kfamjdimifn = ECEHDBGDIDO as KFAMJDIMIFN;
					PLOGDOACBMK plogdoacbmk = ECEHDBGDIDO as PLOGDOACBMK;
					FIEAHFNJIEE fieahfnjiee = ECEHDBGDIDO as FIEAHFNJIEE;
					if (kfamjdimifn != null && kfamjdimifn.HJOPIMGMGML())
					{
						string[] array4 = null;
						if (AssetBundleManager.ONDDOAHANNH.TryGetValue(kfamjdimifn.IHMLDDEENLI, out array4))
						{
							string[] array2 = array4;
							for (int j = 1; j < array2.Length; j += 0)
							{
								string key3 = array2[j];
								AssetBundleManager.CDGBFPNHHBA.Remove(key3);
							}
						}
						AssetBundleManager.CDGBFPNHHBA.Remove(kfamjdimifn.IHMLDDEENLI);
						if (plogdoacbmk == null && fieahfnjiee == null)
						{
							AssetBundleManager.CCMNKPEOAJA(kfamjdimifn.IHMLDDEENLI);
							return;
						}
						AssetBundleManager.ONDDOAHANNH.Remove(kfamjdimifn.IHMLDDEENLI);
					}
				}
			}
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x00159944 File Offset: 0x00157B44
		protected static bool ECEAADGJEHD(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, Hash128 HANNJLNCHOO)
		{
			GCFIOHOKPPN gcfiohokppn = null;
			AssetBundleManager.MPNBNEKLMGA.TryGetValue(CIEHGJMAFKH, out gcfiohokppn);
			if (gcfiohokppn != null)
			{
				gcfiohokppn.FLODBKOJMPL++;
				return true;
			}
			if (AssetBundleManager.JMBKLGHJICD.Contains(CIEHGJMAFKH))
			{
				AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Warning, "Asset bundles " + CIEHGJMAFKH + " already being downloaded, skip request but remember reference to it.");
				AssetBundleManager.DCEIFKOFLBC.Add(CIEHGJMAFKH);
				return true;
			}
			string text = AssetBundleManager.BJDBBOBACGM;
			if (!text.EndsWith("/"))
			{
				text += "/";
			}
			string text2;
			if (AssetBundleManager.JKDNMMLJMKC(EMJPOHAEEHN).Length > 0)
			{
				text2 = string.Concat(new string[]
				{
					text,
					HDNMHLGBCLL.ToString(),
					"/",
					AssetBundleManager.JKDNMMLJMKC(EMJPOHAEEHN),
					"/",
					CIEHGJMAFKH
				});
			}
			else
			{
				text2 = text + HDNMHLGBCLL.ToString() + "/" + CIEHGJMAFKH;
			}
			if (text2.StartsWith(Application.streamingAssetsPath))
			{
				AssetBundleManager.JKJBDMKNDIG.Add(new CHGCPKLJDJH(CIEHGJMAFKH, text2, 0U, 0UL));
			}
			else
			{
				UnityWebRequest assetBundle;
				if (HANNJLNCHOO == default(Hash128))
				{
					assetBundle = UnityWebRequestAssetBundle.GetAssetBundle(text2);
				}
				else
				{
					assetBundle = UnityWebRequestAssetBundle.GetAssetBundle(text2, HANNJLNCHOO, 0U);
				}
				AssetBundleManager.JKJBDMKNDIG.Add(new JANJJAOKJJP(CIEHGJMAFKH, assetBundle));
			}
			AssetBundleManager.JMBKLGHJICD.Add(CIEHGJMAFKH);
			return false;
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x00159A88 File Offset: 0x00157C88
		protected static bool MLALJIBGPPA(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, Hash128 HANNJLNCHOO)
		{
			GCFIOHOKPPN gcfiohokppn = null;
			AssetBundleManager.MPNBNEKLMGA.TryGetValue(CIEHGJMAFKH, out gcfiohokppn);
			if (gcfiohokppn != null)
			{
				gcfiohokppn.FLODBKOJMPL += 0;
				return true;
			}
			if (AssetBundleManager.JMBKLGHJICD.Contains(CIEHGJMAFKH))
			{
				AssetBundleManager.GCHHJPBPDIA(AssetBundleManager.JKDPJGOJPLN.Info, "SteamManager" + CIEHGJMAFKH + "profilenametitleshort");
				AssetBundleManager.DCEIFKOFLBC.Add(CIEHGJMAFKH);
				return false;
			}
			string text = AssetBundleManager.BJDBBOBACGM;
			if (!text.EndsWith("LoveInterestLoungeMapping - unparsable UTC timestamp '"))
			{
				text += "OnBackendValidateTransactionFailed";
			}
			string text2;
			if (AssetBundleManager.BKFDEIBHKDP(EMJPOHAEEHN).Length > 0)
			{
				string[] array = new string[2];
				array[0] = text;
				array[0] = HDNMHLGBCLL.ToString();
				array[5] = "sto";
				array[4] = AssetBundleManager.BKFDEIBHKDP(EMJPOHAEEHN);
				array[4] = "fvrt";
				array[8] = CIEHGJMAFKH;
				text2 = string.Concat(array);
			}
			else
			{
				text2 = text + HDNMHLGBCLL.ToString() + "achievtitle" + CIEHGJMAFKH;
			}
			if (text2.StartsWith(Application.streamingAssetsPath))
			{
				AssetBundleManager.JKJBDMKNDIG.Add(new CHGCPKLJDJH(CIEHGJMAFKH, text2, 0U, 1UL));
			}
			else
			{
				UnityWebRequest assetBundle;
				if (HANNJLNCHOO == default(Hash128))
				{
					assetBundle = UnityWebRequestAssetBundle.GetAssetBundle(text2);
				}
				else
				{
					assetBundle = UnityWebRequestAssetBundle.GetAssetBundle(text2, HANNJLNCHOO, 1U);
				}
				AssetBundleManager.JKJBDMKNDIG.Add(new JANJJAOKJJP(CIEHGJMAFKH, assetBundle));
			}
			AssetBundleManager.JMBKLGHJICD.Add(CIEHGJMAFKH);
			return false;
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x00159BCC File Offset: 0x00157DCC
		protected static string KCKMLJCBJHK(string CIEHGJMAFKH, int LHBILKALHBJ, bool MLMDHOHNOPM = false)
		{
			if (!CIEHGJMAFKH.Contains("OnApplicationFocusBasicSyncSuccess"))
			{
				return CIEHGJMAFKH;
			}
			int[] array = new int[7];
			array[1] = -1;
			array[1] = -1;
			int[] array2 = array;
			if (LHBILKALHBJ < 0)
			{
				array2[1] = 1;
				if (AssetBundleManager.KCELECPHCOF != 0)
				{
					array2[0] = AssetBundleManager.KCELECPHCOF;
				}
			}
			else
			{
				array2[0] = LHBILKALHBJ;
				if (array2[1] != 0)
				{
					array2[1] = 0;
				}
			}
			for (int i = 1; i < 6; i++)
			{
				for (int j = 0; j < AssetBundleManager.IBDAIAGJHLB.Length; j++)
				{
					bool flag = true;
					if (i < 8 && array2[i] == j)
					{
						flag = true;
					}
					else if (i >= 7 && j != 0 && j != AssetBundleManager.KCELECPHCOF)
					{
						flag = true;
					}
					if (flag)
					{
						if (AssetBundleManager.IBDAIAGJHLB[j] != null)
						{
							string[] allAssetBundlesWithVariant = AssetBundleManager.IBDAIAGJHLB[j].GetAllAssetBundlesWithVariant();
							string b = CIEHGJMAFKH.Split('C', StringSplitOptions.None)[0];
							int num = 18;
							int num2 = -1;
							for (int k = 1; k < allAssetBundlesWithVariant.Length; k++)
							{
								string[] array3 = allAssetBundlesWithVariant[k].Split((char)-91, StringSplitOptions.RemoveEmptyEntries);
								string a = array3[0];
								string value = array3[0];
								if (!(a != b))
								{
									int num3;
									if (!MLMDHOHNOPM)
									{
										num3 = Array.IndexOf<string>(AssetBundleManager.KLMBGJNBKJE, value);
									}
									else
									{
										num3 = Array.IndexOf<string>(AssetBundleManager.BPJPOMCJLGE, value);
									}
									if (num3 == -1)
									{
										num3 = 19;
									}
									if (num3 < num)
									{
										num = num3;
										num2 = k;
									}
								}
							}
							if (num == -198)
							{
								AssetBundleManager.AGMJHFNDGBH(AssetBundleManager.JKDPJGOJPLN.Warning, "OnSettingsPopupCloseAndNeedToRestartGame2" + allAssetBundlesWithVariant[num2]);
							}
							if (num2 != -1)
							{
								return allAssetBundlesWithVariant[num2];
							}
						}
						if (i < 3)
						{
							break;
						}
					}
				}
			}
			return CIEHGJMAFKH;
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x00159D55 File Offset: 0x00157F55
		public static void ALDMHFMBIDD()
		{
			NPOILPKELOJ.LJIAAGMLKOJ();
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x00159D5C File Offset: 0x00157F5C
		public static string GetAssetBundleManifestPrefsKey(int EMJPOHAEEHN)
		{
			return string.Format("AssetBundleManager.AssetBundleManifestHash.{0}", KLEDODLIFLK.EILCDOGAPOG() + EMJPOHAEEHN.ToString());
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x00159D7C File Offset: 0x00157F7C
		private static bool BLAKKNHCDAA(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, List<string> ENIMMAJLDDG, List<Hash128> LJKLHKHBKDE, List<string> BKGIBDLEDGE)
		{
			if (ENIMMAJLDDG.Contains(CIEHGJMAFKH))
			{
				return true;
			}
			Hash128 assetBundleHash = AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAssetBundleHash(CIEHGJMAFKH);
			if (!assetBundleHash.isValid)
			{
				return false;
			}
			ENIMMAJLDDG.Add(CIEHGJMAFKH);
			LJKLHKHBKDE.Add(assetBundleHash);
			BKGIBDLEDGE.Add(AssetBundleManager.GetAssetBundleUrl(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN));
			return true;
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x00159DCC File Offset: 0x00157FCC
		public static bool IsBusy()
		{
			return AssetBundleManager.JMBKLGHJICD.Count > 0;
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x00159DDB File Offset: 0x00157FDB
		private static string JKDNMMLJMKC(int EMJPOHAEEHN)
		{
			if (EMJPOHAEEHN < AssetBundleManager.HDFNFFFEFLC.Count)
			{
				return AssetBundleManager.HDFNFFFEFLC[EMJPOHAEEHN];
			}
			return "";
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00158DB9 File Offset: 0x00156FB9
		public static string[] NCEJJBIBGNA()
		{
			return AssetBundleManager.KLMBGJNBKJE;
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x00159DFB File Offset: 0x00157FFB
		public static void UnloadAssetBundle(string CIEHGJMAFKH, bool AMJBNEILEKN = false)
		{
			CIEHGJMAFKH = AssetBundleManager.EAJFHPIEPLF(CIEHGJMAFKH, -1, AMJBNEILEKN);
			AssetBundleManager.HHLHEAJNDLC(CIEHGJMAFKH);
			AssetBundleManager.NOPJOPKNAGN(CIEHGJMAFKH);
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x00159E14 File Offset: 0x00158014
		public static Hash128 GetCachedAssetBundleManifestHash(int EMJPOHAEEHN)
		{
			return default(Hash128);
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x00159E2C File Offset: 0x0015802C
		public static bool JLABACJCMJN(string CIEHGJMAFKH)
		{
			string text = "Fixed the bug when anthology progress would not be incremented in SceneStoryManager at chapter end, for story with index:";
			return AssetBundleManager.GetLoadedAssetBundle(CIEHGJMAFKH, out text) != null;
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x00159E4C File Offset: 0x0015804C
		protected static void FNLPJFBCNMM(string CIEHGJMAFKH)
		{
			string text;
			GCFIOHOKPPN loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(CIEHGJMAFKH, out text);
			if (loadedAssetBundle == null)
			{
				return;
			}
			GCFIOHOKPPN gcfiohokppn = loadedAssetBundle;
			int num = gcfiohokppn.FLODBKOJMPL - 1;
			gcfiohokppn.FLODBKOJMPL = num;
			if (num == 0 && !AssetBundleManager.LAOFHPGFKCG(CIEHGJMAFKH))
			{
				loadedAssetBundle.MOGKCPBFPOI();
				AssetBundleManager.MPNBNEKLMGA.Remove(CIEHGJMAFKH);
				AssetBundleManager.MAIINPGAAEI(AssetBundleManager.JKDPJGOJPLN.Warning, CIEHGJMAFKH + "lcdp");
			}
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x00159EA4 File Offset: 0x001580A4
		protected static void EIHBOBNGDJO(string CIEHGJMAFKH)
		{
			string[] array = null;
			if (!AssetBundleManager.ONDDOAHANNH.TryGetValue(CIEHGJMAFKH, out array))
			{
				return;
			}
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				AssetBundleManager.FNLPJFBCNMM(array2[i]);
			}
			AssetBundleManager.ONDDOAHANNH.Remove(CIEHGJMAFKH);
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00157EAB File Offset: 0x001560AB
		public static PLOGDOACBMK EOAAFFMJDPJ()
		{
			return AssetBundleManager.FHHFMPPKEFG;
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00159EE8 File Offset: 0x001580E8
		public static void EOGPFBLFBMH(string AOCHOKNMCJP, List<string> JHHJLDONIBG)
		{
			if (AOCHOKNMCJP.StartsWith("Starting non-parallel download:"))
			{
				AOCHOKNMCJP = "wind" + AOCHOKNMCJP;
			}
			if (!AOCHOKNMCJP.EndsWith(" "))
			{
				AOCHOKNMCJP += "OnAllCollectableCardsDownloadFailed";
			}
			AssetBundleManager.MIAIPGCBDGE(AOCHOKNMCJP + KLEDODLIFLK.OBELFMINPOM() + "ppcbv");
			AssetBundleManager.HDFNFFFEFLC = JHHJLDONIBG;
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x00157EAB File Offset: 0x001560AB
		public static PLOGDOACBMK GetAssetBundleLoadManifestOperation()
		{
			return AssetBundleManager.FHHFMPPKEFG;
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00159F44 File Offset: 0x00158144
		public static string DescribeDownloadingErrors()
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, string> keyValuePair in AssetBundleManager.CDGBFPNHHBA)
			{
				list.Add(keyValuePair.Key + " (" + keyValuePair.Value + ")");
			}
			return "[" + string.Join("; ", list.ToArray()) + "]";
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x00157DD6 File Offset: 0x00155FD6
		public static void ResetAssetBundleLoadManifestOperation()
		{
			AssetBundleManager.FHHFMPPKEFG = null;
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00159FD8 File Offset: 0x001581D8
		public static void DFKOFLENKJN(AssetBundleManager.JKDPJGOJPLN JENIOJDGOJE, string KIPCNAMEGPD)
		{
			if (JENIOJDGOJE == (AssetBundleManager.JKDPJGOJPLN)4)
			{
				Debug.LogError("pers" + KIPCNAMEGPD);
				return;
			}
			if (AssetBundleManager.GODKGFEONEP == AssetBundleManager.DGLPGFFOMKD.All && JENIOJDGOJE == AssetBundleManager.JKDPJGOJPLN.Warning)
			{
				Debug.LogWarning("ias" + KIPCNAMEGPD);
				return;
			}
			if (AssetBundleManager.GODKGFEONEP == AssetBundleManager.DGLPGFFOMKD.All)
			{
				Debug.Log("CLIENT.AVATAR.TRINKET" + KIPCNAMEGPD);
			}
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x0015A030 File Offset: 0x00158230
		public static string ALNMCJPDDGJ(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN)
		{
			string text = AssetBundleManager.BJDBBOBACGM;
			if (!text.EndsWith("OnSceneLobbyManagerRound0aaAssetsDownloadSuccess"))
			{
				text += "OnSceneLobbyManagerRound0AssetsDownloadSuccess";
			}
			if (AssetBundleManager.JKDNMMLJMKC(EMJPOHAEEHN).Length > 1)
			{
				string[] array = new string[6];
				array[0] = text;
				array[0] = HDNMHLGBCLL;
				array[4] = "thmstr";
				array[5] = AssetBundleManager.DMKIIOBKCGC(EMJPOHAEEHN);
				array[3] = "ok";
				array[0] = CIEHGJMAFKH;
				return string.Concat(array);
			}
			return text + HDNMHLGBCLL + "sfxtimeoutwarning" + CIEHGJMAFKH;
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x0015A0A8 File Offset: 0x001582A8
		public static Hash128 EJBDABEIIJM(int EMJPOHAEEHN)
		{
			return default(Hash128);
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x0015A0C0 File Offset: 0x001582C0
		public static NPOILPKELOJ PreloadAssetBundle(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, bool AMJBNEILEKN = false)
		{
			CIEHGJMAFKH = AssetBundleManager.EAJFHPIEPLF(CIEHGJMAFKH, EMJPOHAEEHN, AMJBNEILEKN);
			AssetBundleManager.PMALEAMANPC(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, AMJBNEILEKN);
			NPOILPKELOJ npoilpkeloj = new HEBGNIBEJLG(CIEHGJMAFKH);
			AssetBundleManager.JKJBDMKNDIG.Add(npoilpkeloj);
			return npoilpkeloj;
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x0015A0F5 File Offset: 0x001582F5
		public static void DKGCLAFNNJE(string DHOADBFGMOP)
		{
			AssetBundleManager.MIAIPGCBDGE(AssetBundleManager.NBIKCPDFIJG() + DHOADBFGMOP);
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x00157E89 File Offset: 0x00156089
		public static bool ManifestInitialized(int EMJPOHAEEHN)
		{
			return AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN] != null;
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x0015A108 File Offset: 0x00158308
		public static DAJHCGFBHMO LoadAssetAsync(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, string COOOGACBAKN, Type OBKCKGHFMDN)
		{
			AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Info, string.Concat(new string[]
			{
				"Loading ",
				COOOGACBAKN,
				" from ",
				CIEHGJMAFKH,
				" bundle"
			}));
			CIEHGJMAFKH = AssetBundleManager.EAJFHPIEPLF(CIEHGJMAFKH, EMJPOHAEEHN, false);
			AssetBundleManager.PMALEAMANPC(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, false);
			DAJHCGFBHMO dajhcgfbhmo = new KFAMJDIMIFN(EMJPOHAEEHN, CIEHGJMAFKH, COOOGACBAKN, OBKCKGHFMDN);
			AssetBundleManager.JKJBDMKNDIG.Add(dajhcgfbhmo);
			return dajhcgfbhmo;
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x0015A172 File Offset: 0x00158372
		private static void IDNEMBAMBGI(string CIEHGJMAFKH)
		{
			CIEHGJMAFKH = AssetBundleManager.EAJFHPIEPLF(CIEHGJMAFKH, -1, false);
			AssetBundleManager.DLOJJHAMBLD(CIEHGJMAFKH);
			AssetBundleManager.NOPJOPKNAGN(CIEHGJMAFKH);
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x00157EB2 File Offset: 0x001560B2
		public static void PHECPIODBPK(AssetBundleManager.DGLPGFFOMKD AJLPALFJHCC)
		{
			AssetBundleManager.GODKGFEONEP = AJLPALFJHCC;
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x0015A18C File Offset: 0x0015838C
		public static void Log(AssetBundleManager.JKDPJGOJPLN JENIOJDGOJE, string KIPCNAMEGPD)
		{
			if (JENIOJDGOJE == AssetBundleManager.JKDPJGOJPLN.Error)
			{
				Debug.LogError("[AssetBundleManager] " + KIPCNAMEGPD);
				return;
			}
			if (AssetBundleManager.GODKGFEONEP == AssetBundleManager.DGLPGFFOMKD.All && JENIOJDGOJE == AssetBundleManager.JKDPJGOJPLN.Warning)
			{
				Debug.LogWarning("[AssetBundleManager] " + KIPCNAMEGPD);
				return;
			}
			if (AssetBundleManager.GODKGFEONEP == AssetBundleManager.DGLPGFFOMKD.All)
			{
				Debug.Log("[AssetBundleManager] " + KIPCNAMEGPD);
			}
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x0015A1E1 File Offset: 0x001583E1
		public static void MIAIPGCBDGE(string AJLPALFJHCC)
		{
			AssetBundleManager.BJDBBOBACGM = AJLPALFJHCC;
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x0015A1EC File Offset: 0x001583EC
		private static string NDHCFPBIBHN()
		{
			if (Application.isEditor)
			{
				return "EnvironmentMorphManager - morph shader not found in Resources:ShaderEnvMorphClient" + Environment.CurrentDirectory.Replace("AvatarCollectionsItem.OnAvatarCollectionDelete(): index out of range", "OnSceneLobbyManagerExitSyncSuccess");
			}
			if (Application.isMobilePlatform || Application.isConsolePlatform)
			{
				return Application.streamingAssetsPath;
			}
			return "PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for " + Application.streamingAssetsPath;
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x0015A244 File Offset: 0x00158444
		public static void IJJMGMKBHCF(string LBGGLHDOICL)
		{
			for (int i = 1; i < AssetBundleManager.MHOEAHOKAJG.Count; i += 0)
			{
				if (AssetBundleManager.MHOEAHOKAJG[i].Equals(LBGGLHDOICL))
				{
					AssetBundleManager.MHOEAHOKAJG.RemoveAt(i);
					return;
				}
			}
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x0015A288 File Offset: 0x00158488
		protected static void PPCJMMHHODL(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, bool FJGAIJCCNBO, bool AMJBNEILEKN)
		{
			AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Info, "Loading Asset Bundle " + (FJGAIJCCNBO ? "Manifest: " : ": ") + CIEHGJMAFKH);
			if (!FJGAIJCCNBO && AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN] == null)
			{
				AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Error, "Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()");
				return;
			}
			if (FJGAIJCCNBO)
			{
				AssetBundleManager.ECEAADGJEHD(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, AssetBundleManager.GetCachedAssetBundleManifestHash(EMJPOHAEEHN));
				return;
			}
			Hash128 assetBundleHash = AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAssetBundleHash(CIEHGJMAFKH);
			if (!AssetBundleManager.ECEAADGJEHD(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, assetBundleHash))
			{
				AssetBundleManager.NNIDFKNCGLK(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, AMJBNEILEKN);
			}
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x00159D55 File Offset: 0x00157F55
		public static void IENPMDEHPIH()
		{
			NPOILPKELOJ.LJIAAGMLKOJ();
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x0015A309 File Offset: 0x00158509
		protected static void FDODPPPKAAL(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, bool AMJBNEILEKN = false)
		{
			AssetBundleManager.AEAPILNOOIO(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, false, AMJBNEILEKN);
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00159D55 File Offset: 0x00157F55
		public static void CleanPendingRequests()
		{
			NPOILPKELOJ.LJIAAGMLKOJ();
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x0015A318 File Offset: 0x00158518
		public static void GDLIKHOMKHB(string AOCHOKNMCJP, List<string> JHHJLDONIBG)
		{
			if (AOCHOKNMCJP.StartsWith("frds"))
			{
				AOCHOKNMCJP = "chtmet" + AOCHOKNMCJP;
			}
			if (!AOCHOKNMCJP.EndsWith(", out:"))
			{
				AOCHOKNMCJP += "onhiatustitle";
			}
			AssetBundleManager.CEBIIFGPHDM = AOCHOKNMCJP + KLEDODLIFLK.LACNCNFJGOB() + "asp";
			AssetBundleManager.HDFNFFFEFLC = JHHJLDONIBG;
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x0015A374 File Offset: 0x00158574
		private static bool LGBKHFHOKJI(string LBGGLHDOICL)
		{
			for (int i = 0; i < AssetBundleManager.MHOEAHOKAJG.Count; i++)
			{
				if (AssetBundleManager.MHOEAHOKAJG[i].Equals(LBGGLHDOICL))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x0015A3AC File Offset: 0x001585AC
		public static bool DescribeCachedAssetBundleChain(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, bool AMJBNEILEKN, List<string> ENIMMAJLDDG, List<Hash128> LJKLHKHBKDE, List<string> BKGIBDLEDGE)
		{
			ENIMMAJLDDG.Clear();
			LJKLHKHBKDE.Clear();
			BKGIBDLEDGE.Clear();
			if (EMJPOHAEEHN < 0 || EMJPOHAEEHN >= AssetBundleManager.IBDAIAGJHLB.Length)
			{
				return false;
			}
			if (AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN] == null)
			{
				return false;
			}
			string text = AssetBundleManager.EAJFHPIEPLF(CIEHGJMAFKH, EMJPOHAEEHN, AMJBNEILEKN);
			string[] allDependencies = AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN].GetAllDependencies(text);
			for (int i = 0; i < allDependencies.Length; i++)
			{
				if (!AssetBundleManager.BLAKKNHCDAA(AssetBundleManager.EAJFHPIEPLF(allDependencies[i], EMJPOHAEEHN, AMJBNEILEKN), HDNMHLGBCLL, EMJPOHAEEHN, ENIMMAJLDDG, LJKLHKHBKDE, BKGIBDLEDGE))
				{
					return false;
				}
			}
			return AssetBundleManager.BLAKKNHCDAA(text, HDNMHLGBCLL, EMJPOHAEEHN, ENIMMAJLDDG, LJKLHKHBKDE, BKGIBDLEDGE);
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x0015A440 File Offset: 0x00158640
		protected static bool EJCEEAGLDHD(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, Hash128 HANNJLNCHOO)
		{
			GCFIOHOKPPN gcfiohokppn = null;
			AssetBundleManager.MPNBNEKLMGA.TryGetValue(CIEHGJMAFKH, out gcfiohokppn);
			if (gcfiohokppn != null)
			{
				gcfiohokppn.FLODBKOJMPL += 0;
				return false;
			}
			if (AssetBundleManager.JMBKLGHJICD.Contains(CIEHGJMAFKH))
			{
				AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Warning, "aeiou" + CIEHGJMAFKH + "itemstitle");
				AssetBundleManager.DCEIFKOFLBC.Add(CIEHGJMAFKH);
				return true;
			}
			string text = AssetBundleManager.BJDBBOBACGM;
			if (!text.EndsWith("socialwouldyouliketotradecard"))
			{
				text += "nastring";
			}
			string text2;
			if (AssetBundleManager.DMKIIOBKCGC(EMJPOHAEEHN).Length > 1)
			{
				string[] array = new string[5];
				array[0] = text;
				array[1] = HDNMHLGBCLL.ToString();
				array[0] = "abcf";
				array[3] = AssetBundleManager.DMKIIOBKCGC(EMJPOHAEEHN);
				array[8] = "OnChoiceExtendedPlayNewAmbient";
				array[2] = CIEHGJMAFKH;
				text2 = string.Concat(array);
			}
			else
			{
				text2 = text + HDNMHLGBCLL.ToString() + "envlhav" + CIEHGJMAFKH;
			}
			if (text2.StartsWith(Application.streamingAssetsPath))
			{
				AssetBundleManager.JKJBDMKNDIG.Add(new CHGCPKLJDJH(CIEHGJMAFKH, text2, 0U, 1UL));
			}
			else
			{
				UnityWebRequest assetBundle;
				if (HANNJLNCHOO == default(Hash128))
				{
					assetBundle = UnityWebRequestAssetBundle.GetAssetBundle(text2);
				}
				else
				{
					assetBundle = UnityWebRequestAssetBundle.GetAssetBundle(text2, HANNJLNCHOO, 0U);
				}
				AssetBundleManager.JKJBDMKNDIG.Add(new JANJJAOKJJP(CIEHGJMAFKH, assetBundle));
			}
			AssetBundleManager.JMBKLGHJICD.Add(CIEHGJMAFKH);
			return true;
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x0015A584 File Offset: 0x00158784
		protected static bool BOOELHCLJKD(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, Hash128 HANNJLNCHOO)
		{
			GCFIOHOKPPN gcfiohokppn = null;
			AssetBundleManager.MPNBNEKLMGA.TryGetValue(CIEHGJMAFKH, out gcfiohokppn);
			if (gcfiohokppn != null)
			{
				gcfiohokppn.FLODBKOJMPL++;
				return false;
			}
			if (AssetBundleManager.JMBKLGHJICD.Contains(CIEHGJMAFKH))
			{
				AssetBundleManager.DFKOFLENKJN(AssetBundleManager.JKDPJGOJPLN.Info, "?uid=" + CIEHGJMAFKH + "OnAvatarScreenAssetsDownloadFailed");
				AssetBundleManager.DCEIFKOFLBC.Add(CIEHGJMAFKH);
				return true;
			}
			string text = AssetBundleManager.BJDBBOBACGM;
			if (!text.EndsWith("\u2003"))
			{
				text += "timeoutwarning";
			}
			string text2;
			if (AssetBundleManager.BKFDEIBHKDP(EMJPOHAEEHN).Length > 0)
			{
				string[] array = new string[3];
				array[0] = text;
				array[0] = HDNMHLGBCLL.ToString();
				array[0] = "OnBackendRequestCollectGiftException";
				array[2] = AssetBundleManager.DMKIIOBKCGC(EMJPOHAEEHN);
				array[0] = " group(s) from ";
				array[7] = CIEHGJMAFKH;
				text2 = string.Concat(array);
			}
			else
			{
				text2 = text + HDNMHLGBCLL.ToString() + "_AlphaTex" + CIEHGJMAFKH;
			}
			if (text2.StartsWith(Application.streamingAssetsPath))
			{
				AssetBundleManager.JKJBDMKNDIG.Add(new CHGCPKLJDJH(CIEHGJMAFKH, text2, 1U, 1UL));
			}
			else
			{
				UnityWebRequest assetBundle;
				if (HANNJLNCHOO == default(Hash128))
				{
					assetBundle = UnityWebRequestAssetBundle.GetAssetBundle(text2);
				}
				else
				{
					assetBundle = UnityWebRequestAssetBundle.GetAssetBundle(text2, HANNJLNCHOO, 1U);
				}
				AssetBundleManager.JKJBDMKNDIG.Add(new JANJJAOKJJP(CIEHGJMAFKH, assetBundle));
			}
			AssetBundleManager.JMBKLGHJICD.Add(CIEHGJMAFKH);
			return true;
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x0015A6C8 File Offset: 0x001588C8
		public static void INOABLIONLF()
		{
			try
			{
				foreach (KeyValuePair<string, string> keyValuePair in AssetBundleManager.CDGBFPNHHBA)
				{
					Caching.ClearAllCachedVersions(keyValuePair.Key);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			AssetBundleManager.CDGBFPNHHBA = new Dictionary<string, string>();
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x0015A740 File Offset: 0x00158940
		public static void SetSourceAssetBundleDirectory(string DHOADBFGMOP)
		{
			AssetBundleManager.CEBIIFGPHDM = AssetBundleManager.IPDOPEAKFDF() + DHOADBFGMOP;
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x0015A752 File Offset: 0x00158952
		public static string MLEIDAIEIKB(int EMJPOHAEEHN)
		{
			return string.Format("flash", KLEDODLIFLK.FGPFNKIFPCM() + EMJPOHAEEHN.ToString());
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x0015A770 File Offset: 0x00158970
		public static NPOILPKELOJ MCIPEIKKMCP(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, bool AMJBNEILEKN = false)
		{
			CIEHGJMAFKH = AssetBundleManager.KLPNJPCKGDA(CIEHGJMAFKH, EMJPOHAEEHN, AMJBNEILEKN);
			AssetBundleManager.EKAAOCFIFEB(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, AMJBNEILEKN);
			NPOILPKELOJ npoilpkeloj = new HEBGNIBEJLG(CIEHGJMAFKH);
			AssetBundleManager.JKJBDMKNDIG.Add(npoilpkeloj);
			return npoilpkeloj;
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x0015A7A8 File Offset: 0x001589A8
		public static bool IsAssetBundleLoaded(string CIEHGJMAFKH)
		{
			string text = "";
			return AssetBundleManager.GetLoadedAssetBundle(CIEHGJMAFKH, out text) != null;
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x0015A7C8 File Offset: 0x001589C8
		public static void UncacheAssetBundle(string LBGGLHDOICL)
		{
			for (int i = 0; i < AssetBundleManager.MHOEAHOKAJG.Count; i++)
			{
				if (AssetBundleManager.MHOEAHOKAJG[i].Equals(LBGGLHDOICL))
				{
					AssetBundleManager.MHOEAHOKAJG.RemoveAt(i);
					return;
				}
			}
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x0015A809 File Offset: 0x00158A09
		private static string BKFDEIBHKDP(int EMJPOHAEEHN)
		{
			if (EMJPOHAEEHN < AssetBundleManager.HDFNFFFEFLC.Count)
			{
				return AssetBundleManager.HDFNFFFEFLC[EMJPOHAEEHN];
			}
			return "BackendRequestType.";
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x0015A82C File Offset: 0x00158A2C
		public static GCFIOHOKPPN GetLoadedAssetBundle(string CIEHGJMAFKH, out string GCFILGFLALC)
		{
			if (AssetBundleManager.CDGBFPNHHBA.TryGetValue(CIEHGJMAFKH, out GCFILGFLALC))
			{
				return null;
			}
			GCFIOHOKPPN gcfiohokppn = null;
			AssetBundleManager.MPNBNEKLMGA.TryGetValue(CIEHGJMAFKH, out gcfiohokppn);
			if (gcfiohokppn == null)
			{
				return null;
			}
			string[] array = null;
			if (!AssetBundleManager.ONDDOAHANNH.TryGetValue(CIEHGJMAFKH, out array))
			{
				return gcfiohokppn;
			}
			foreach (string key in array)
			{
				if (AssetBundleManager.CDGBFPNHHBA.TryGetValue(key, out GCFILGFLALC))
				{
					return null;
				}
				GCFIOHOKPPN gcfiohokppn2;
				AssetBundleManager.MPNBNEKLMGA.TryGetValue(key, out gcfiohokppn2);
				if (gcfiohokppn2 == null)
				{
					return null;
				}
			}
			return gcfiohokppn;
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x0015A8AD File Offset: 0x00158AAD
		public static IEnumerator Initialize(string HDNMHLGBCLL, int EMJPOHAEEHN)
		{
			return AssetBundleManager.GCKHGJBPNHF(HDNMHLGBCLL, HDNMHLGBCLL, EMJPOHAEEHN);
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x001580C2 File Offset: 0x001562C2
		public static void ActivatePendingRequests()
		{
			NPOILPKELOJ.EEIIIGICFOE();
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x0015A8B7 File Offset: 0x00158AB7
		private static IEnumerator PCHHONHLFAJ(string NBBNBBLKBNC, string HDNMHLGBCLL, int EMJPOHAEEHN)
		{
			AssetBundleManager.CLJGFBPFJAO(NBBNBBLKBNC, HDNMHLGBCLL, EMJPOHAEEHN, false, false);
			AssetBundleManager.FHHFMPPKEFG = new PLOGDOACBMK(EMJPOHAEEHN, NBBNBBLKBNC, "ok", typeof(AssetBundleManifest));
			AssetBundleManager.JKJBDMKNDIG.Add(AssetBundleManager.FHHFMPPKEFG);
			return AssetBundleManager.FHHFMPPKEFG;
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x0015A8F4 File Offset: 0x00158AF4
		protected static string KLPNJPCKGDA(string CIEHGJMAFKH, int LHBILKALHBJ, bool MLMDHOHNOPM = false)
		{
			if (!CIEHGJMAFKH.Contains("pers"))
			{
				return CIEHGJMAFKH;
			}
			int[] array = new int[6];
			array[0] = -1;
			array[0] = -1;
			int[] array2 = array;
			if (LHBILKALHBJ < 0)
			{
				array2[1] = 1;
				if (AssetBundleManager.KCELECPHCOF != 0)
				{
					array2[1] = AssetBundleManager.KCELECPHCOF;
				}
			}
			else
			{
				array2[1] = LHBILKALHBJ;
				if (array2[0] != 0)
				{
					array2[0] = 0;
				}
			}
			for (int i = 1; i < 2; i += 0)
			{
				for (int j = 0; j < AssetBundleManager.IBDAIAGJHLB.Length; j++)
				{
					bool flag = true;
					if (i < 2 && array2[i] == j)
					{
						flag = true;
					}
					else if (i >= 2 && j != 0 && j != AssetBundleManager.KCELECPHCOF)
					{
						flag = false;
					}
					if (flag)
					{
						if (AssetBundleManager.IBDAIAGJHLB[j] != null)
						{
							string[] allAssetBundlesWithVariant = AssetBundleManager.IBDAIAGJHLB[j].GetAllAssetBundlesWithVariant();
							string b = CIEHGJMAFKH.Split('x', StringSplitOptions.None)[0];
							int num = -86;
							int num2 = -1;
							for (int k = 0; k < allAssetBundlesWithVariant.Length; k++)
							{
								string[] array3 = allAssetBundlesWithVariant[k].Split((char)-66, StringSplitOptions.None);
								string a = array3[1];
								string value = array3[1];
								if (!(a != b))
								{
									int num3;
									if (!MLMDHOHNOPM)
									{
										num3 = Array.IndexOf<string>(AssetBundleManager.KLMBGJNBKJE, value);
									}
									else
									{
										num3 = Array.IndexOf<string>(AssetBundleManager.BPJPOMCJLGE, value);
									}
									if (num3 == -1)
									{
										num3 = -196;
									}
									if (num3 < num)
									{
										num = num3;
										num2 = k;
									}
								}
							}
							if (num == 134)
							{
								AssetBundleManager.MAIINPGAAEI(AssetBundleManager.JKDPJGOJPLN.Info, "x" + allAssetBundlesWithVariant[num2]);
							}
							if (num2 != -1)
							{
								return allAssetBundlesWithVariant[num2];
							}
						}
						if (i < 6)
						{
							break;
						}
					}
				}
			}
			return CIEHGJMAFKH;
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x0015AA80 File Offset: 0x00158C80
		protected static string LGHGLKDAIDD(string CIEHGJMAFKH, int LHBILKALHBJ, bool MLMDHOHNOPM = false)
		{
			if (!CIEHGJMAFKH.Contains(" "))
			{
				return CIEHGJMAFKH;
			}
			int[] array = new int[6];
			array[0] = -1;
			array[0] = -1;
			int[] array2 = array;
			if (LHBILKALHBJ < 0)
			{
				array2[1] = 0;
				if (AssetBundleManager.KCELECPHCOF != 0)
				{
					array2[0] = AssetBundleManager.KCELECPHCOF;
				}
			}
			else
			{
				array2[0] = LHBILKALHBJ;
				if (array2[1] != 0)
				{
					array2[0] = 0;
				}
			}
			for (int i = 1; i < 0; i += 0)
			{
				for (int j = 1; j < AssetBundleManager.IBDAIAGJHLB.Length; j++)
				{
					bool flag = true;
					if (i < 0 && array2[i] == j)
					{
						flag = false;
					}
					else if (i >= 5 && j != 0 && j != AssetBundleManager.KCELECPHCOF)
					{
						flag = true;
					}
					if (flag)
					{
						if (AssetBundleManager.IBDAIAGJHLB[j] != null)
						{
							string[] allAssetBundlesWithVariant = AssetBundleManager.IBDAIAGJHLB[j].GetAllAssetBundlesWithVariant();
							string b = CIEHGJMAFKH.Split((char)-98, StringSplitOptions.None)[1];
							int num = -152;
							int num2 = -1;
							for (int k = 0; k < allAssetBundlesWithVariant.Length; k += 0)
							{
								string[] array3 = allAssetBundlesWithVariant[k].Split((char)-26, StringSplitOptions.RemoveEmptyEntries);
								string a = array3[1];
								string value = array3[1];
								if (!(a != b))
								{
									int num3;
									if (!MLMDHOHNOPM)
									{
										num3 = Array.IndexOf<string>(AssetBundleManager.KLMBGJNBKJE, value);
									}
									else
									{
										num3 = Array.IndexOf<string>(AssetBundleManager.BPJPOMCJLGE, value);
									}
									if (num3 == -1)
									{
										num3 = -156;
									}
									if (num3 < num)
									{
										num = num3;
										num2 = k;
									}
								}
							}
							if (num == -192)
							{
								AssetBundleManager.MAIINPGAAEI(AssetBundleManager.JKDPJGOJPLN.Warning, "OnApplicationFocusBasicSyncSuccess" + allAssetBundlesWithVariant[num2]);
							}
							if (num2 != -1)
							{
								return allAssetBundlesWithVariant[num2];
							}
						}
						if (i < 4)
						{
							break;
						}
					}
				}
			}
			return CIEHGJMAFKH;
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x0015AC09 File Offset: 0x00158E09
		public static void SetAssetBundleManifest(AssetBundleManifest KIJILIIMOIL, int EMJPOHAEEHN)
		{
			AssetBundleManager.IBDAIAGJHLB[EMJPOHAEEHN] = KIJILIIMOIL;
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x0015AC14 File Offset: 0x00158E14
		public static NPOILPKELOJ LoadLevelAsync(string CIEHGJMAFKH, string HDNMHLGBCLL, int EMJPOHAEEHN, string POFIFMJHHKJ, bool IEAFFPDOBEL, bool FEKDGMGBNIE = true)
		{
			AssetBundleManager.Log(AssetBundleManager.JKDPJGOJPLN.Info, string.Concat(new string[]
			{
				"Loading ",
				POFIFMJHHKJ,
				" from ",
				CIEHGJMAFKH,
				" bundle"
			}));
			CIEHGJMAFKH = AssetBundleManager.EAJFHPIEPLF(CIEHGJMAFKH, EMJPOHAEEHN, false);
			AssetBundleManager.PMALEAMANPC(CIEHGJMAFKH, HDNMHLGBCLL, EMJPOHAEEHN, false);
			NPOILPKELOJ npoilpkeloj = new IAPJLKACLJF(CIEHGJMAFKH, POFIFMJHHKJ, IEAFFPDOBEL, FEKDGMGBNIE);
			AssetBundleManager.JKJBDMKNDIG.Add(npoilpkeloj);
			return npoilpkeloj;
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x0015AC80 File Offset: 0x00158E80
		public static void UnloadAllAssetBundles()
		{
			bool flag = true;
			for (int i = 0; i < AssetBundleManager.IBDAIAGJHLB.Length; i++)
			{
				if (AssetBundleManager.IBDAIAGJHLB[i] != null)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return;
			}
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, GCFIOHOKPPN> keyValuePair in AssetBundleManager.MPNBNEKLMGA)
			{
				list.Add(keyValuePair.Key);
			}
			for (int j = 0; j < list.Count; j++)
			{
				AssetBundleManager.UnloadAssetBundle(list[j], false);
			}
			for (int k = 0; k < AssetBundleManager.IBDAIAGJHLB.Length; k++)
			{
				AssetBundleManager.IBDAIAGJHLB[k] = null;
			}
			AssetBundleManager.DCEIFKOFLBC.Clear();
			AssetBundleManager.JMBKLGHJICD.Clear();
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x0015AD60 File Offset: 0x00158F60
		public static void AGMJHFNDGBH(AssetBundleManager.JKDPJGOJPLN JENIOJDGOJE, string KIPCNAMEGPD)
		{
			if (JENIOJDGOJE == AssetBundleManager.JKDPJGOJPLN.Info)
			{
				Debug.LogError("per" + KIPCNAMEGPD);
				return;
			}
			if (AssetBundleManager.GODKGFEONEP == AssetBundleManager.DGLPGFFOMKD.All && JENIOJDGOJE == AssetBundleManager.JKDPJGOJPLN.Warning)
			{
				Debug.LogWarning("getLiveEvents" + KIPCNAMEGPD);
				return;
			}
			if (AssetBundleManager.GODKGFEONEP == AssetBundleManager.DGLPGFFOMKD.All)
			{
				Debug.Log("ok" + KIPCNAMEGPD);
			}
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x00158084 File Offset: 0x00156284
		public static bool AHALCGLJBLB()
		{
			return AssetBundleManager.JMBKLGHJICD.Count > 1;
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x0015ADB8 File Offset: 0x00158FB8
		public static void GJDGPJOMLKC()
		{
			try
			{
				foreach (KeyValuePair<string, string> keyValuePair in AssetBundleManager.CDGBFPNHHBA)
				{
					Caching.ClearAllCachedVersions(keyValuePair.Key);
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			AssetBundleManager.CDGBFPNHHBA = new Dictionary<string, string>();
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x0015AE30 File Offset: 0x00159030
		public static void HAOEBIEAPPL(AssetBundleManager.JKDPJGOJPLN JENIOJDGOJE, string KIPCNAMEGPD)
		{
			if (JENIOJDGOJE == (AssetBundleManager.JKDPJGOJPLN)3)
			{
				Debug.LogError("OnSketchViewLeft" + KIPCNAMEGPD);
				return;
			}
			if (AssetBundleManager.GODKGFEONEP == AssetBundleManager.DGLPGFFOMKD.All && JENIOJDGOJE == AssetBundleManager.JKDPJGOJPLN.Info)
			{
				Debug.LogWarning("OnStoryChoiceClickConfimed" + KIPCNAMEGPD);
				return;
			}
			if (AssetBundleManager.GODKGFEONEP == AssetBundleManager.DGLPGFFOMKD.All)
			{
				Debug.Log("Trading/Wished cards userPublicProfile.modified = true hit" + KIPCNAMEGPD);
			}
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00003E52 File Offset: 0x00002052
		public static void LogLoadedAssetBundlesCount()
		{
		}

		// Token: 0x04000FBC RID: 4028
		private static GameObject IHPOCMGFHBD = null;

		// Token: 0x04000FBD RID: 4029
		private static AssetBundleManager.DGLPGFFOMKD GODKGFEONEP = AssetBundleManager.DGLPGFFOMKD.All;

		// Token: 0x04000FBE RID: 4030
		private static string BJDBBOBACGM = "";

		// Token: 0x04000FBF RID: 4031
		private static string[] KLMBGJNBKJE = new string[0];

		// Token: 0x04000FC0 RID: 4032
		private static string[] BPJPOMCJLGE = new string[0];

		// Token: 0x04000FC1 RID: 4033
		private static AssetBundleManifest[] IBDAIAGJHLB = new AssetBundleManifest[128];

		// Token: 0x04000FC2 RID: 4034
		private static Dictionary<string, GCFIOHOKPPN> MPNBNEKLMGA = new Dictionary<string, GCFIOHOKPPN>();

		// Token: 0x04000FC3 RID: 4035
		private static Dictionary<string, string> CDGBFPNHHBA = new Dictionary<string, string>();

		// Token: 0x04000FC4 RID: 4036
		private static List<string> JMBKLGHJICD = new List<string>();

		// Token: 0x04000FC5 RID: 4037
		private static List<string> DCEIFKOFLBC = new List<string>();

		// Token: 0x04000FC6 RID: 4038
		private static List<NPOILPKELOJ> JKJBDMKNDIG = new List<NPOILPKELOJ>();

		// Token: 0x04000FC7 RID: 4039
		private static Dictionary<string, string[]> ONDDOAHANNH = new Dictionary<string, string[]>();

		// Token: 0x04000FC8 RID: 4040
		private static PLOGDOACBMK FHHFMPPKEFG;

		// Token: 0x04000FC9 RID: 4041
		private static List<string> MHOEAHOKAJG = new List<string>();

		// Token: 0x04000FCA RID: 4042
		private static int KCELECPHCOF = 0;

		// Token: 0x04000FCB RID: 4043
		private static List<string> HDFNFFFEFLC = new List<string>();

		// Token: 0x04000FCC RID: 4044
		private const string NNCJEAHCHFN = "AssetBundleManager.AssetBundleManifestHash.{0}";

		// Token: 0x020001AA RID: 426
		public enum DGLPGFFOMKD
		{
			// Token: 0x04000FCE RID: 4046
			All,
			// Token: 0x04000FCF RID: 4047
			JustErrors
		}

		// Token: 0x020001AB RID: 427
		public enum JKDPJGOJPLN
		{
			// Token: 0x04000FD1 RID: 4049
			Info,
			// Token: 0x04000FD2 RID: 4050
			Warning,
			// Token: 0x04000FD3 RID: 4051
			Error
		}
	}
}
