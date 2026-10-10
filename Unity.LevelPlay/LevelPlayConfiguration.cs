using System;
using System.Collections.Generic;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200000D RID: 13
	public sealed class LevelPlayConfiguration
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000031C1 File Offset: 0x000013C1
		public bool IsAdQualityEnabled { get; }

		// Token: 0x060000BB RID: 187 RVA: 0x000031CC File Offset: 0x000013CC
		internal LevelPlayConfiguration(string json)
		{
			if (string.IsNullOrEmpty(json))
			{
				return;
			}
			try
			{
				object obj;
				if ((LevelPlayJson.Deserialize(json) as Dictionary<string, object>).TryGetValue("isAdQualityEnabled", out obj) && obj != null)
				{
					bool flag;
					if (bool.TryParse(obj.ToString(), out flag))
					{
						this.IsAdQualityEnabled = flag;
					}
					else
					{
						LevelPlayLogger.LogError("Failed to parse isAdQualityEnabled: " + ((obj != null) ? obj.ToString() : null));
					}
				}
			}
			catch (Exception ex)
			{
				LevelPlayLogger.LogError("Failed to parse LevelPlayConfiguration: " + ex.Message);
			}
		}

		// Token: 0x0400004F RID: 79
		private const string k_IsAdQualityEnabled = "isAdQualityEnabled";
	}
}
