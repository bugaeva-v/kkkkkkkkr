using System;
using UnityEngine;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x0200003B RID: 59
	internal class PlayerPrefsPersistence : IPersistence
	{
		// Token: 0x06000188 RID: 392 RVA: 0x000064FE File Offset: 0x000046FE
		public void SaveValue(string key, int value)
		{
			PlayerPrefs.SetInt(key, value);
			PlayerPrefs.Save();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000650C File Offset: 0x0000470C
		public void SaveValue(string key, string value)
		{
			PlayerPrefs.SetString(key, value);
			PlayerPrefs.Save();
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000651A File Offset: 0x0000471A
		public int LoadInt(string key)
		{
			if (PlayerPrefs.HasKey(key))
			{
				return PlayerPrefs.GetInt(key);
			}
			return 0;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000652C File Offset: 0x0000472C
		public string LoadString(string key)
		{
			if (PlayerPrefs.HasKey(key))
			{
				return PlayerPrefs.GetString(key);
			}
			return null;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000653E File Offset: 0x0000473E
		public void ClearValue(string key)
		{
			PlayerPrefs.DeleteKey(key);
		}
	}
}
