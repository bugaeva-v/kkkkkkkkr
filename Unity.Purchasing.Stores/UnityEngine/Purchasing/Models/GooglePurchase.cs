using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Utils;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000055 RID: 85
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePurchase : IGooglePurchase
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00008FEF File Offset: 0x000071EF
		public bool isAcknowledged { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00008FF7 File Offset: 0x000071F7
		public int purchaseState { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00008FFF File Offset: 0x000071FF
		public List<string> skus { get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00009007 File Offset: 0x00007207
		public string orderId { get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0000900F File Offset: 0x0000720F
		public string receipt { get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00009017 File Offset: 0x00007217
		public string signature { get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000901F File Offset: 0x0000721F
		public string originalJson { get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00009027 File Offset: 0x00007227
		public string purchaseToken { get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000902F File Offset: 0x0000722F
		[Nullable(2)]
		public string obfuscatedAccountId { [NullableContext(2)] get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00009037 File Offset: 0x00007237
		[Nullable(2)]
		public string obfuscatedProfileId { [NullableContext(2)] get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000903F File Offset: 0x0000723F
		public IEnumerable<ProductDescription> productDescriptions { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00009047 File Offset: 0x00007247
		[Nullable(2)]
		public string sku
		{
			[NullableContext(2)]
			get
			{
				return this.skus.FirstOrDefault<string>();
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00009054 File Offset: 0x00007254
		internal GooglePurchase(AndroidJavaObject purchase, IEnumerable<AndroidJavaObject> productDetailsEnum)
		{
			using (AndroidJavaObject androidJavaObject = purchase.Call<AndroidJavaObject>("getProducts", Array.Empty<object>()))
			{
				this.isAcknowledged = purchase.Call<bool>("isAcknowledged", Array.Empty<object>());
				this.purchaseState = purchase.Call<int>("getPurchaseState", Array.Empty<object>());
				this.skus = androidJavaObject.Enumerate<string>().ToList<string>();
				this.orderId = purchase.Call<string>("getOrderId", Array.Empty<object>());
				this.originalJson = purchase.Call<string>("getOriginalJson", Array.Empty<object>());
				this.signature = purchase.Call<string>("getSignature", Array.Empty<object>());
				this.purchaseToken = purchase.Call<string>("getPurchaseToken", Array.Empty<object>());
				AndroidJavaObject androidJavaObject2 = purchase.Call<AndroidJavaObject>("getAccountIdentifiers", Array.Empty<object>());
				this.obfuscatedAccountId = androidJavaObject2.Call<string>("getObfuscatedAccountId", Array.Empty<object>());
				this.obfuscatedProfileId = androidJavaObject2.Call<string>("getObfuscatedProfileId", Array.Empty<object>());
				this.productDescriptions = from productDetails in productDetailsEnum
				select ProductDetailsConverter.BuildProductDescription(productDetails, ProductType.Unknown);
				List<string> productDetailsJson = (from productDescription in this.productDescriptions
				select productDescription.metadata.GetGoogleProductMetadata().originalJson).ToList<string>();
				this.receipt = GoogleReceiptEncoder.EncodeReceipt(this.originalJson, this.signature, productDetailsJson);
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000091E8 File Offset: 0x000073E8
		public virtual bool IsAcknowledged()
		{
			return this.isAcknowledged;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000091F0 File Offset: 0x000073F0
		public virtual bool IsPurchased()
		{
			return this.purchaseState == GooglePurchaseStateEnum.Purchased();
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000091FF File Offset: 0x000073FF
		public virtual bool IsPending()
		{
			return this.purchaseState == GooglePurchaseStateEnum.Pending();
		}
	}
}
