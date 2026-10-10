using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000008 RID: 8
	public sealed class LevelPlayAdError
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000023D5 File Offset: 0x000005D5
		public int ErrorCode { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000023DD File Offset: 0x000005DD
		public string ErrorMessage { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000023E5 File Offset: 0x000005E5
		public string AdUnitId { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000023ED File Offset: 0x000005ED
		public string AdId { get; }

		// Token: 0x0600007B RID: 123 RVA: 0x000023F8 File Offset: 0x000005F8
		internal LevelPlayAdError(string json)
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
				if (dictionary.TryGetValue("adUnitId", out obj) && obj != null)
				{
					this.AdUnitId = obj.ToString();
				}
				if (dictionary.TryGetValue("adId", out obj) && obj != null)
				{
					this.AdId = obj.ToString();
				}
			}
			catch (Exception ex)
			{
				Debug.LogError("Failed to parse LevelPlayAdError: " + ex.Message);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000024C8 File Offset: 0x000006C8
		internal LevelPlayAdError(string adUnitId, int errorCode, string errorMessage, string adId)
		{
			this.ErrorCode = errorCode;
			this.ErrorMessage = errorMessage;
			this.AdUnitId = adUnitId;
			this.AdId = adId;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000024ED File Offset: 0x000006ED
		internal LevelPlayAdError(string adUnitId, int errorCode, string errorMessage)
		{
			this.ErrorCode = errorCode;
			this.ErrorMessage = errorMessage;
			this.AdUnitId = adUnitId;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000250A File Offset: 0x0000070A
		public override string ToString()
		{
			return string.Format("LevelPlayAdError: {0}, {1}, {2}, {3}", new object[]
			{
				this.ErrorCode,
				this.ErrorMessage,
				this.AdUnitId,
				this.AdId
			});
		}
	}
}
