using System;
using UnityEngine;

namespace Unity.Services.Analytics
{
	// Token: 0x0200000A RID: 10
	public class AdImpressionEvent : Event
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002A32 File Offset: 0x00000C32
		public AdImpressionEvent() : base("adImpression", true, 1)
		{
		}

		// Token: 0x17000016 RID: 22
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002A41 File Offset: 0x00000C41
		public AdCompletionStatus AdCompletionStatus
		{
			set
			{
				base.SetParameter("adCompletionStatus", AdImpressionEvent.k_AdCompletionStatusValues[(int)value]);
			}
		}

		// Token: 0x17000017 RID: 23
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002A55 File Offset: 0x00000C55
		public AdProvider AdProvider
		{
			set
			{
				base.SetParameter("adProvider", AdImpressionEvent.k_AdProviderValues[(int)value]);
			}
		}

		// Token: 0x17000018 RID: 24
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002A69 File Offset: 0x00000C69
		public string PlacementId
		{
			set
			{
				base.SetParameter("placementId", value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002A77 File Offset: 0x00000C77
		public string PlacementName
		{
			set
			{
				base.SetParameter("placementName", value);
			}
		}

		// Token: 0x1700001A RID: 26
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002A85 File Offset: 0x00000C85
		public AdPlacementType PlacementType
		{
			set
			{
				base.SetParameter("placementType", AdImpressionEvent.k_AdPlacementTypeValues[(int)value]);
			}
		}

		// Token: 0x1700001B RID: 27
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002A99 File Offset: 0x00000C99
		public double AdEcpmUsd
		{
			set
			{
				base.SetParameter("adEcpmUsd", value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002AA7 File Offset: 0x00000CA7
		public string AdStoreDestinationId
		{
			set
			{
				base.SetParameter("adStoreDestinationID", value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002AB5 File Offset: 0x00000CB5
		public string AdSdkVersion
		{
			set
			{
				base.SetParameter("adSdkVersion", value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002AC3 File Offset: 0x00000CC3
		public string AdImpressionId
		{
			set
			{
				base.SetParameter("adImpressionID", value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002AD1 File Offset: 0x00000CD1
		public string AdMediaType
		{
			set
			{
				base.SetParameter("adMediaType", value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002ADF File Offset: 0x00000CDF
		public long AdTimeWatchedMs
		{
			set
			{
				base.SetParameter("adTimeWatchedMs", value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002AED File Offset: 0x00000CED
		public long AdTimeCloseButtonShownMs
		{
			set
			{
				base.SetParameter("adTimeCloseButtonShownMs", value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002AFB File Offset: 0x00000CFB
		public long AdLengthMs
		{
			set
			{
				base.SetParameter("adLengthMs", value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002B09 File Offset: 0x00000D09
		public bool AdHasClicked
		{
			set
			{
				base.SetParameter("adHasClicked", value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002B17 File Offset: 0x00000D17
		public string AdSource
		{
			set
			{
				base.SetParameter("adSource", value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002B25 File Offset: 0x00000D25
		public string AdStatusCallback
		{
			set
			{
				base.SetParameter("adStatusCallback", value);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002B33 File Offset: 0x00000D33
		public override void Validate()
		{
			base.Validate();
			if (!base.ParameterHasBeenSet("placementId"))
			{
				Debug.LogWarning("A value for the PlacementId parameter is required for an AdImpression event.");
			}
			if (!base.ParameterHasBeenSet("placementName"))
			{
				Debug.LogWarning("A value for the PlacementName parameter is required for an AdImpression event.");
			}
		}

		// Token: 0x04000020 RID: 32
		private static readonly string[] k_AdPlacementTypeValues = Event.BakeEnum2String<AdPlacementType>(false);

		// Token: 0x04000021 RID: 33
		private static readonly string[] k_AdProviderValues = Event.BakeEnum2String<AdProvider>(true);

		// Token: 0x04000022 RID: 34
		private static readonly string[] k_AdCompletionStatusValues = Event.BakeEnum2String<AdCompletionStatus>(true);
	}
}
