using System;
using UnityEngine;

namespace Unity.Services.Analytics
{
	// Token: 0x02000008 RID: 8
	public class AcquisitionSourceEvent : Event
	{
		// Token: 0x0600002E RID: 46 RVA: 0x0000291F File Offset: 0x00000B1F
		public AcquisitionSourceEvent() : base("acquisitionSource", true, 1)
		{
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000292E File Offset: 0x00000B2E
		public string AcquisitionChannel
		{
			set
			{
				base.SetParameter("acquisitionChannel", value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x06000030 RID: 48 RVA: 0x0000293C File Offset: 0x00000B3C
		public string AcquisitionCampaignId
		{
			set
			{
				base.SetParameter("acquisitionCampaignId", value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0000294A File Offset: 0x00000B4A
		public string AcquisitionCreativeId
		{
			set
			{
				base.SetParameter("acquisitionCreativeId", value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002958 File Offset: 0x00000B58
		public string AcquisitionCampaignName
		{
			set
			{
				base.SetParameter("acquisitionCampaignName", value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002966 File Offset: 0x00000B66
		public string AcquisitionProvider
		{
			set
			{
				base.SetParameter("acquisitionProvider", value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002974 File Offset: 0x00000B74
		public float AcquisitionCost
		{
			set
			{
				base.SetParameter("acquisitionCost", value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002982 File Offset: 0x00000B82
		public string AcquisitionCostCurrency
		{
			set
			{
				base.SetParameter("acquisitionCostCurrency", value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002990 File Offset: 0x00000B90
		public string AcquisitionNetwork
		{
			set
			{
				base.SetParameter("acquisitionNetwork", value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000299E File Offset: 0x00000B9E
		public string AcquisitionCampaignType
		{
			set
			{
				base.SetParameter("acquisitionCampaignType", value);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000029AC File Offset: 0x00000BAC
		public override void Validate()
		{
			base.Validate();
			if (!base.ParameterHasBeenSet("acquisitionChannel"))
			{
				Debug.LogWarning("A value for the AcquisitionChannel parameter is required for an AcquisitionSource event.");
			}
			if (!base.ParameterHasBeenSet("acquisitionCampaignId"))
			{
				Debug.LogWarning("A value for the AcquisitionCampaignId parameter is required for an AcquisitionSource event.");
			}
			if (!base.ParameterHasBeenSet("acquisitionCreativeId"))
			{
				Debug.LogWarning("A value for the AcquisitionCreativeId parameter is required for an AcquisitionSource event.");
			}
			if (!base.ParameterHasBeenSet("acquisitionCampaignName"))
			{
				Debug.LogWarning("A value for the AcquisitionCampaignName parameter is required for an AcquisitionSource event.");
			}
			if (!base.ParameterHasBeenSet("acquisitionProvider"))
			{
				Debug.LogWarning("A value for the AcquisitionProvider parameter is required for an AcquisitionSource event.");
			}
		}
	}
}
