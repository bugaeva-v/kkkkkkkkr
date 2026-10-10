using System;
using UnityEngine;

namespace com.shephertz.app42.paas.sdk.csharp.app42Event
{
	// Token: 0x02000044 RID: 68
	internal class Local
	{
		// Token: 0x0600029A RID: 666 RVA: 0x0000F190 File Offset: 0x0000D390
		internal static void Save(string key, string value)
		{
			try
			{
				PlayerPrefs.SetString(key, value);
				PlayerPrefs.Save();
			}
			catch (PlayerPrefsException ex)
			{
				App42Log.Console("Exception When Saving Values In Local.Save" + ex.ToString());
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000F1D4 File Offset: 0x0000D3D4
		internal static void Remove(string key)
		{
			try
			{
				PlayerPrefs.DeleteKey(key);
			}
			catch (PlayerPrefsException ex)
			{
				App42Log.Console("Exception When Saving Values In Local.Save" + ex.ToString());
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000F214 File Offset: 0x0000D414
		internal static string Fetch(string key)
		{
			string result;
			try
			{
				result = PlayerPrefs.GetString(key);
			}
			catch (PlayerPrefsException ex)
			{
				App42Log.Console("Exception When Fetching Values From Local.Fetch" + ex.ToString());
				result = "";
			}
			return result;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000F25C File Offset: 0x0000D45C
		internal static bool HasKey(string key)
		{
			bool result;
			try
			{
				if (PlayerPrefs.HasKey(key))
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (PlayerPrefsException ex)
			{
				App42Log.Console("Exception When Checking Keys In Local.HasKey" + ex.ToString());
				result = false;
			}
			return result;
		}
	}
}
