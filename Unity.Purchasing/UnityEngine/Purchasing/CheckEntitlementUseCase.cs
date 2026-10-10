using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000070 RID: 112
	internal class CheckEntitlementUseCase : ICheckEntitlementUseCase, IStoreCheckEntitlementCallback
	{
		// Token: 0x06000208 RID: 520 RVA: 0x00005BF9 File Offset: 0x00003DF9
		[Preserve]
		internal CheckEntitlementUseCase(IStore storeResponsible)
		{
			this.m_Store = storeResponsible;
			this.m_Store.SetEntitlementCheckCallback(this);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00005C20 File Offset: 0x00003E20
		public void IsProductEntitled(Product product, Action<Entitlement> onResult)
		{
			if (product == null)
			{
				Entitlement obj = new Entitlement(null, null, EntitlementStatus.Unknown, "Invalid product: null");
				if (onResult != null)
				{
					onResult(obj);
				}
				return;
			}
			ProductDefinition definition = product.definition;
			string str = ((definition != null) ? definition.id : null) ?? "unknown";
			if (this.FindExistingEntitlementRequest(product))
			{
				Entitlement obj2 = new Entitlement(null, null, EntitlementStatus.Unknown, "Duplicate CheckEntitlement request detected for product id: " + str);
				if (onResult != null)
				{
					onResult(obj2);
				}
				return;
			}
			this.AddAndSendCheckEntitlementRequest(product, onResult);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00005C98 File Offset: 0x00003E98
		private bool FindExistingEntitlementRequest(Product productToCheckFor)
		{
			return this.m_OngoingRequests.Exists((CheckEntitlementRequest request) => request.ProductToCheck.Equals(productToCheckFor));
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00005CCC File Offset: 0x00003ECC
		private void AddAndSendCheckEntitlementRequest(Product product, Action<Entitlement> onCheckComplete)
		{
			CheckEntitlementRequest item = new CheckEntitlementRequest(product, onCheckComplete);
			this.m_OngoingRequests.Add(item);
			try
			{
				this.m_Store.CheckEntitlement(product.definition);
			}
			catch (Exception ex)
			{
				this.m_OngoingRequests.Remove(item);
				Entitlement obj = new Entitlement(product, null, EntitlementStatus.Unknown, "Exception during CheckEntitlement: " + ex.Message);
				if (onCheckComplete != null)
				{
					onCheckComplete(obj);
				}
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00005D44 File Offset: 0x00003F44
		public void OnCheckEntitlement(ProductDefinition productDefinition, EntitlementStatus status, string message = null)
		{
			CheckEntitlementRequest matchingRequest = this.GetMatchingRequest(productDefinition);
			if (matchingRequest != null)
			{
				Entitlement obj = new Entitlement(matchingRequest.ProductToCheck, null, status, null);
				Action<Entitlement> onChecked = matchingRequest.OnChecked;
				if (onChecked != null)
				{
					onChecked(obj);
				}
				this.m_OngoingRequests.Remove(matchingRequest);
				return;
			}
			Debug.unityLogger.LogIAPWarning("[CheckEntitlement] Missing request for productDefinition: " + productDefinition.storeSpecificId + ". " + string.Format("Callback will not be invoked. Status: {0}. Message: {1}", status, message ?? "none"));
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00005DC4 File Offset: 0x00003FC4
		private CheckEntitlementRequest GetMatchingRequest(ProductDefinition productDefinition)
		{
			return this.m_OngoingRequests.FirstOrDefault((CheckEntitlementRequest request) => request.ProductToCheck.definition.storeSpecificId.Equals(productDefinition.storeSpecificId));
		}

		// Token: 0x040000A3 RID: 163
		private readonly IStore m_Store;

		// Token: 0x040000A4 RID: 164
		private readonly List<CheckEntitlementRequest> m_OngoingRequests = new List<CheckEntitlementRequest>();
	}
}
