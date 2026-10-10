using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Purchasing;

// Token: 0x02000404 RID: 1028
public interface ABLEFBBIBNB
{
	// Token: 0x06007A69 RID: 31337
	IEnumerator ValidatePendingPurchases();

	// Token: 0x06007A6A RID: 31338
	void Initialize();

	// Token: 0x06007A6B RID: 31339
	IMBBHEGNCFP GetState();

	// Token: 0x06007A6C RID: 31340
	bool IsInitialized();

	// Token: 0x06007A6D RID: 31341
	void RestorePurchases();

	// Token: 0x06007A6E RID: 31342 RVA: 0x0036B448 File Offset: 0x00369648
	public static Product ECAJAEBFDJB(Order NJBCLIILMOF)
	{
		CartItem cartItem = NJBCLIILMOF.CartOrdered.Items().FirstOrDefault<CartItem>();
		if (cartItem != null)
		{
			return cartItem.Product;
		}
		return null;
	}

	// Token: 0x06007A6F RID: 31343
	void StartPurchase(string IHCGMFBCMOO);

	// Token: 0x06007A70 RID: 31344
	void FetchPurchases();

	// Token: 0x06007A71 RID: 31345
	PurchaseFailureReason GetPurchaseFailedReason();

	// Token: 0x06007A72 RID: 31346
	List<NIIJIJNFIIA> GetValidatedPurchases();

	// Token: 0x06007A73 RID: 31347
	void RefreshSubscriptions();

	// Token: 0x06007A74 RID: 31348 RVA: 0x0036B471 File Offset: 0x00369671
	public static string NAOFMENDDLO(Product KLPFOMCGFLK)
	{
		if (KLPFOMCGFLK != null)
		{
			return KLPFOMCGFLK.definition.id;
		}
		return "";
	}

	// Token: 0x06007A75 RID: 31349
	OBHDGKFFICI GetProductData(string IHCGMFBCMOO);
}
