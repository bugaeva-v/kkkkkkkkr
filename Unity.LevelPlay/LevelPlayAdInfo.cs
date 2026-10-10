using System;
using System.Collections.Generic;
using System.Globalization;
using JetBrains.Annotations;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000009 RID: 9
	public sealed class LevelPlayAdInfo
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00002548 File Offset: 0x00000748
		internal LevelPlayAdInfo(string json)
		{
			if (string.IsNullOrEmpty(json))
			{
				return;
			}
			try
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				Dictionary<string, object> dictionary = LevelPlayJson.Deserialize(json) as Dictionary<string, object>;
				object obj;
				if (dictionary.TryGetValue("adId", out obj) && obj != null)
				{
					this.AdId = obj.ToString();
				}
				if (dictionary.TryGetValue("adUnitId", out obj) && obj != null)
				{
					this.AdUnitId = obj.ToString();
				}
				if (dictionary.TryGetValue("adUnitName", out obj) && obj != null)
				{
					this.AdUnitName = obj.ToString();
				}
				if (dictionary.TryGetValue("adSize", out obj) && obj != null)
				{
					this.AdSize = LevelPlayAdInfo.GetAdSize(obj.ToString());
				}
				if (dictionary.TryGetValue("adFormat", out obj) && obj != null)
				{
					this.AdFormat = obj.ToString();
				}
				if (dictionary.TryGetValue("placementName", out obj) && obj != null)
				{
					this.PlacementName = obj.ToString();
				}
				if (dictionary.TryGetValue("auctionId", out obj) && obj != null)
				{
					this.AuctionId = obj.ToString();
				}
				if (dictionary.TryGetValue("creativeId", out obj) && obj != null)
				{
					this.CreativeId = obj.ToString();
				}
				if (dictionary.TryGetValue("country", out obj) && obj != null)
				{
					this.Country = obj.ToString();
				}
				if (dictionary.TryGetValue("ab", out obj) && obj != null)
				{
					this.Ab = obj.ToString();
				}
				if (dictionary.TryGetValue("segmentName", out obj) && obj != null)
				{
					this.SegmentName = obj.ToString();
				}
				if (dictionary.TryGetValue("adNetwork", out obj) && obj != null)
				{
					this.AdNetwork = obj.ToString();
				}
				if (dictionary.TryGetValue("instanceName", out obj) && obj != null)
				{
					this.InstanceName = obj.ToString();
				}
				if (dictionary.TryGetValue("instanceId", out obj) && obj != null)
				{
					this.InstanceId = obj.ToString();
				}
				double value;
				if (dictionary.TryGetValue("revenue", out obj) && obj != null && double.TryParse(string.Format(invariantCulture, "{0}", obj), NumberStyles.Any, invariantCulture, out value))
				{
					this.Revenue = new double?(value);
				}
				if (dictionary.TryGetValue("precision", out obj) && obj != null)
				{
					this.Precision = obj.ToString();
				}
				if (dictionary.TryGetValue("encryptedCPM", out obj) && obj != null)
				{
					this.EncryptedCPM = obj.ToString();
				}
			}
			catch (Exception ex)
			{
				Debug.LogError("error parsing LevelPlayAdInfo" + ex.ToString());
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000027CC File Offset: 0x000009CC
		private static LevelPlayAdSize GetAdSize(string adSizeJson)
		{
			string description = "";
			int width = 0;
			int height = 0;
			if (!string.IsNullOrEmpty(adSizeJson))
			{
				try
				{
					Dictionary<string, object> dictionary = LevelPlayJson.Deserialize(adSizeJson) as Dictionary<string, object>;
					object obj;
					if (dictionary.TryGetValue("description", out obj) && obj != null)
					{
						description = obj.ToString();
					}
					if (dictionary.TryGetValue("width", out obj) && obj != null)
					{
						width = int.Parse(obj.ToString());
					}
					if (dictionary.TryGetValue("height", out obj) && obj != null)
					{
						height = int.Parse(obj.ToString());
					}
					return LevelPlayAdInfo.GetAdSize(description, width, height);
				}
				catch (Exception value)
				{
					Console.WriteLine(value);
					return null;
				}
			}
			return null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002874 File Offset: 0x00000A74
		private static LevelPlayAdSize GetAdSize(string description, int width = 0, int height = 0)
		{
			if (description == "BANNER")
			{
				return LevelPlayAdSize.BANNER;
			}
			if (description == "LARGE")
			{
				return LevelPlayAdSize.LARGE;
			}
			if (description == "MEDIUM_RECTANGLE")
			{
				return LevelPlayAdSize.MEDIUM_RECTANGLE;
			}
			if (description == "CUSTOM")
			{
				return LevelPlayAdSize.CreateCustomBannerSize(width, height);
			}
			if (description == "LEADERBOARD")
			{
				return LevelPlayAdSize.LEADERBOARD;
			}
			if (!(description == "ADAPTIVE"))
			{
				return LevelPlayAdSize.BANNER;
			}
			return LevelPlayAdSize.CreateAdaptiveAdSize(width);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002900 File Offset: 0x00000B00
		public override string ToString()
		{
			return string.Format("adId: {0}, adUnitId: {1}, adUnitName: {2}, adSize: {3}, adFormat: {4}, placementName: {5}, auctionId: {6}, creativeId: {7}, country: {8}, ab: {9}, segmentName: {10}, adNetwork: {11}, instanceName: {12}, instanceId: {13}, revenue: {14}, precision: {15}, encryptedCPM: {16}", new object[]
			{
				this.AdId,
				this.AdUnitId,
				this.AdUnitName,
				this.AdSize,
				this.AdFormat,
				this.PlacementName,
				this.AuctionId,
				this.CreativeId,
				this.Country,
				this.Ab,
				this.SegmentName,
				this.AdNetwork,
				this.InstanceName,
				this.InstanceId,
				this.Revenue,
				this.Precision,
				this.EncryptedCPM
			});
		}

		// Token: 0x04000011 RID: 17
		private const string AdIdKey = "adId";

		// Token: 0x04000012 RID: 18
		private const string AdUnitIdKey = "adUnitId";

		// Token: 0x04000013 RID: 19
		private const string AdUnitNameKey = "adUnitName";

		// Token: 0x04000014 RID: 20
		private const string AdSizeKey = "adSize";

		// Token: 0x04000015 RID: 21
		private const string AdFormatKey = "adFormat";

		// Token: 0x04000016 RID: 22
		private const string PlacementNameKey = "placementName";

		// Token: 0x04000017 RID: 23
		private const string AuctionIdKey = "auctionId";

		// Token: 0x04000018 RID: 24
		private const string CountryKey = "country";

		// Token: 0x04000019 RID: 25
		private const string AbKey = "ab";

		// Token: 0x0400001A RID: 26
		private const string SegmentNameKey = "segmentName";

		// Token: 0x0400001B RID: 27
		private const string AdNetworkKey = "adNetwork";

		// Token: 0x0400001C RID: 28
		private const string InstanceNameKey = "instanceName";

		// Token: 0x0400001D RID: 29
		private const string InstanceIdKey = "instanceId";

		// Token: 0x0400001E RID: 30
		private const string RevenueKey = "revenue";

		// Token: 0x0400001F RID: 31
		private const string PrecisionKey = "precision";

		// Token: 0x04000020 RID: 32
		private const string EncryptedCpmKey = "encryptedCPM";

		// Token: 0x04000021 RID: 33
		private const string AdSizeDescriptionKey = "description";

		// Token: 0x04000022 RID: 34
		private const string AdSizeWidthKey = "width";

		// Token: 0x04000023 RID: 35
		private const string AdSizeHeightKey = "height";

		// Token: 0x04000024 RID: 36
		public readonly string AdId;

		// Token: 0x04000025 RID: 37
		public readonly string AdUnitId;

		// Token: 0x04000026 RID: 38
		public readonly string AdUnitName;

		// Token: 0x04000027 RID: 39
		[CanBeNull]
		public readonly LevelPlayAdSize AdSize;

		// Token: 0x04000028 RID: 40
		public readonly string AdFormat;

		// Token: 0x04000029 RID: 41
		public readonly string PlacementName;

		// Token: 0x0400002A RID: 42
		public readonly string AuctionId;

		// Token: 0x0400002B RID: 43
		public readonly string CreativeId;

		// Token: 0x0400002C RID: 44
		public readonly string Country;

		// Token: 0x0400002D RID: 45
		public readonly string Ab;

		// Token: 0x0400002E RID: 46
		public readonly string SegmentName;

		// Token: 0x0400002F RID: 47
		public readonly string AdNetwork;

		// Token: 0x04000030 RID: 48
		public readonly string InstanceName;

		// Token: 0x04000031 RID: 49
		public readonly string InstanceId;

		// Token: 0x04000032 RID: 50
		public readonly double? Revenue;

		// Token: 0x04000033 RID: 51
		public readonly string Precision;

		// Token: 0x04000034 RID: 52
		public readonly string EncryptedCPM;
	}
}
