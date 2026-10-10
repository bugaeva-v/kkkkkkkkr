using System;
using System.Collections.Generic;
using System.Globalization;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200000E RID: 14
	public sealed class LevelPlayImpressionData
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00003264 File Offset: 0x00001464
		public string AuctionId
		{
			get
			{
				return this.GetValueAsString("auctionId");
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00003271 File Offset: 0x00001471
		public string CreativeId
		{
			get
			{
				return this.GetValueAsString("creativeId");
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000327E File Offset: 0x0000147E
		public string AdFormat
		{
			get
			{
				return this.GetValueAsString("adFormat");
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000328B File Offset: 0x0000148B
		public string MediationAdUnitName
		{
			get
			{
				return this.GetValueAsString("mediationAdUnitName");
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00003298 File Offset: 0x00001498
		public string MediationAdUnitId
		{
			get
			{
				return this.GetValueAsString("mediationAdUnitId");
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000032A5 File Offset: 0x000014A5
		public string Country
		{
			get
			{
				return this.GetValueAsString("country");
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000032B2 File Offset: 0x000014B2
		public string Ab
		{
			get
			{
				return this.GetValueAsString("ab");
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000032BF File Offset: 0x000014BF
		public string SegmentName
		{
			get
			{
				return this.GetValueAsString("segmentName");
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000032CC File Offset: 0x000014CC
		public string Placement
		{
			get
			{
				return this.GetValueAsString("placement");
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000032D9 File Offset: 0x000014D9
		public string AdNetwork
		{
			get
			{
				return this.GetValueAsString("adNetwork");
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000032E6 File Offset: 0x000014E6
		public string InstanceName
		{
			get
			{
				return this.GetValueAsString("instanceName");
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000032F3 File Offset: 0x000014F3
		public string InstanceId
		{
			get
			{
				return this.GetValueAsString("instanceId");
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00003300 File Offset: 0x00001500
		public double? Revenue
		{
			get
			{
				return this.GetValueAsDouble("revenue");
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000330D File Offset: 0x0000150D
		public string Precision
		{
			get
			{
				return this.GetValueAsString("precision");
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000331A File Offset: 0x0000151A
		public string EncryptedCpm
		{
			get
			{
				return this.GetValueAsString("encryptedCPM");
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00003327 File Offset: 0x00001527
		public int? ConversionValue
		{
			get
			{
				return this.GetValueAsInt("conversionValue");
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00003334 File Offset: 0x00001534
		public string AllData { get; }

		// Token: 0x060000CD RID: 205 RVA: 0x0000333C File Offset: 0x0000153C
		internal LevelPlayImpressionData(string levelplayImpressionJson)
		{
			this.AllData = levelplayImpressionJson;
			this.InternalDictionary = this.ParseJson(levelplayImpressionJson);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003358 File Offset: 0x00001558
		private Dictionary<string, object> ParseJson(string json)
		{
			Dictionary<string, object> result;
			try
			{
				result = ((LevelPlayJson.Deserialize(json) as Dictionary<string, object>) ?? new Dictionary<string, object>());
			}
			catch (Exception exception)
			{
				LevelPlayLogger.LogException(exception);
				result = new Dictionary<string, object>();
			}
			return result;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000339C File Offset: 0x0000159C
		private string GetValueAsString(string key)
		{
			object obj;
			if (!this.InternalDictionary.TryGetValue(key, out obj) || obj == null)
			{
				return null;
			}
			return obj.ToString();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000033C4 File Offset: 0x000015C4
		private double? GetValueAsDouble(string key)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			object obj;
			double value;
			if (this.InternalDictionary.TryGetValue(key, out obj) && obj != null && double.TryParse(string.Format(invariantCulture, "{0}", obj), NumberStyles.Any, invariantCulture, out value))
			{
				return new double?(value);
			}
			return null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003418 File Offset: 0x00001618
		private int? GetValueAsInt(string key)
		{
			object obj;
			int value;
			if (this.InternalDictionary.TryGetValue(key, out obj) && obj != null && int.TryParse(obj.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003464 File Offset: 0x00001664
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"LevelPlayImpressionData{AuctionId='",
				this.AuctionId,
				"', CreativeId='",
				this.CreativeId,
				"', AdFormat='",
				this.AdFormat,
				"', MediationAdUnitName='",
				this.MediationAdUnitName,
				"', MediationAdUnitId='",
				this.MediationAdUnitId,
				"', Country='",
				this.Country,
				"', Ab='",
				this.Ab,
				"', SegmentName='",
				this.SegmentName,
				"', Placement='",
				this.Placement,
				"', AdNetwork='",
				this.AdNetwork,
				"', InstanceName='",
				this.InstanceName,
				"', InstanceId='",
				this.InstanceId,
				"', Revenue=",
				this.Revenue.ToString(),
				", Precision='",
				this.Precision,
				"', EncryptedCpm='",
				this.EncryptedCpm,
				"', ConversionValue=",
				this.ConversionValue.ToString(),
				"}"
			});
		}

		// Token: 0x04000052 RID: 82
		private readonly Dictionary<string, object> InternalDictionary;
	}
}
