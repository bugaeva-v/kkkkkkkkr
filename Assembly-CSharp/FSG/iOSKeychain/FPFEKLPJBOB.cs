using System;
using System.IO;
using System.Text;
using FSG.Utilities;
using UnityEngine;

namespace FSG.iOSKeychain
{
	// Token: 0x0200004F RID: 79
	public static class FPFEKLPJBOB
	{
		// Token: 0x06000AC4 RID: 2756 RVA: 0x0004FC34 File Offset: 0x0004DE34
		public static void EKDHFAODNHF(string JKLAKEDMACO, string AJLPALFJHCC)
		{
			try
			{
				File.WriteAllBytes(FPFEKLPJBOB.GCGMFMNNGJO(JKLAKEDMACO), FPFEKLPJBOB.INGIAHLLBFL.NHNOAKDJLAF(Encoding.UTF8.GetBytes(AJLPALFJHCC)));
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0004FC7C File Offset: 0x0004DE7C
		private static string GCGMFMNNGJO(string JKLAKEDMACO)
		{
			return Path.Combine(Application.persistentDataPath, string.Format("keychain-{0}.dat", JKLAKEDMACO));
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0004FC94 File Offset: 0x0004DE94
		public static string GALKFKBPLCK(string JKLAKEDMACO)
		{
			string result;
			try
			{
				string path = FPFEKLPJBOB.GCGMFMNNGJO(JKLAKEDMACO);
				if (File.Exists(path))
				{
					byte[] gkikeikfnbc = File.ReadAllBytes(path);
					result = Encoding.UTF8.GetString(FPFEKLPJBOB.INGIAHLLBFL.JCIIFBKIKDP(gkikeikfnbc));
				}
				else
				{
					result = string.Empty;
				}
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0004FCF8 File Offset: 0x0004DEF8
		public static void CLLGBJPJMOC(string JKLAKEDMACO)
		{
			try
			{
				string path = FPFEKLPJBOB.GCGMFMNNGJO(JKLAKEDMACO);
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}

		// Token: 0x04000374 RID: 884
		private static DFKPELFEPFH INGIAHLLBFL = new DFKPELFEPFH("oPXJN744LGH5v2pX3BVj", "KlUiCgYcoHBzB8sjYA4z");
	}
}
