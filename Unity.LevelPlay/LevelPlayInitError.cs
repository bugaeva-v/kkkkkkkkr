using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200000F RID: 15
	public sealed class LevelPlayInitError
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000035C9 File Offset: 0x000017C9
		public int ErrorCode { get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000035D1 File Offset: 0x000017D1
		public string ErrorMessage { get; }

		// Token: 0x060000D5 RID: 213 RVA: 0x000035DC File Offset: 0x000017DC
		internal LevelPlayInitError(string json)
		{
			if (string.IsNullOrEmpty(json))
			{
				return;
			}
			try
			{
				Dictionary<string, object> dictionary = LevelPlayJson.Deserialize(json) as Dictionary<string, object>;
				object obj;
				if (dictionary.TryGetValue("errorCode", out obj) && obj != null)
				{
					this.ErrorCode = int.Parse(obj.ToString());
				}
				if (dictionary.TryGetValue("errorMessage", out obj) && obj != null)
				{
					this.ErrorMessage = obj.ToString();
				}
			}
			catch (Exception ex)
			{
				Debug.LogError("Failed to parse LevelPlayInitError: " + ex.Message);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003670 File Offset: 0x00001870
		public override string ToString()
		{
			return string.Format("LevelPlayInitError: {0}, {1}", this.ErrorCode, this.ErrorMessage);
		}
	}
}
