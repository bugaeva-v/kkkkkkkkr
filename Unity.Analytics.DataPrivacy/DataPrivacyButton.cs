using System;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UnityEngine.Analytics
{
	// Token: 0x02000003 RID: 3
	public class DataPrivacyButton : Button
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002233 File Offset: 0x00000433
		private DataPrivacyButton()
		{
			base.onClick.AddListener(new UnityAction(this.OpenDataPrivacyUrl));
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002252 File Offset: 0x00000452
		private void OnFailure(string reason)
		{
			base.interactable = true;
			Debug.LogWarning(string.Format("Failed to get data privacy url: {0}", reason));
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000226B File Offset: 0x0000046B
		private void OpenUrl(string url)
		{
			base.interactable = true;
			this.urlOpened = true;
			Application.OpenURL(url);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002281 File Offset: 0x00000481
		private void OpenDataPrivacyUrl()
		{
			base.interactable = false;
			DataPrivacy.FetchPrivacyUrl(new Action<string>(this.OpenUrl), new Action<string>(this.OnFailure));
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022A7 File Offset: 0x000004A7
		private void OnApplicationFocus(bool hasFocus)
		{
			if (hasFocus && this.urlOpened)
			{
				this.urlOpened = false;
				RemoteSettings.ForceUpdate();
			}
		}

		// Token: 0x04000005 RID: 5
		private bool urlOpened;
	}
}
