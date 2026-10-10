using System;
using UnityEngine;

// Token: 0x02000535 RID: 1333
[CreateAssetMenu(fileName = "assetLiveOfferX", menuName = "ROMANCE/Create assetLiveOfferX", order = 1)]
public class AssetLiveOffer : ScriptableObject
{
	// Token: 0x04002C5D RID: 11357
	public LJLAENEAOIM offerType;

	// Token: 0x04002C5E RID: 11358
	public string liveOfferId = "lo0";

	// Token: 0x04002C5F RID: 11359
	public string iapSku = "sails_gamepass0";

	// Token: 0x04002C60 RID: 11360
	public int assetIndex;

	// Token: 0x04002C61 RID: 11361
	public int minRevision = 50000;

	// Token: 0x04002C62 RID: 11362
	public string startDateUTC = "2026-01-14T01:00:01.999Z";

	// Token: 0x04002C63 RID: 11363
	public string endDateUTC = "2026-01-14T01:00:01.999Z";

	// Token: 0x04002C64 RID: 11364
	public int requirePayer;

	// Token: 0x04002C65 RID: 11365
	public int requireFreeloader;

	// Token: 0x04002C66 RID: 11366
	public string showIfAnySkuPurchased = "";

	// Token: 0x04002C67 RID: 11367
	public string hideIfAnySkuPurchased = "";

	// Token: 0x04002C68 RID: 11368
	public int minDaysFromInstall = 1;

	// Token: 0x04002C69 RID: 11369
	public int minCompletedChapters;

	// Token: 0x04002C6A RID: 11370
	public string showIfAllEventsHit = "";

	// Token: 0x04002C6B RID: 11371
	public int priority;

	// Token: 0x04002C6C RID: 11372
	public int minTimeBetweenOffers = 43200;

	// Token: 0x04002C6D RID: 11373
	public string onSuccessEvent = "";

	// Token: 0x04002C6E RID: 11374
	public string placement = "lobby";

	// Token: 0x04002C6F RID: 11375
	public int isRecurrentExpiredGamePassOffer;

	// Token: 0x04002C70 RID: 11376
	public int discount;

	// Token: 0x04002C71 RID: 11377
	public int discount2;

	// Token: 0x04002C72 RID: 11378
	public int showTimer;
}
