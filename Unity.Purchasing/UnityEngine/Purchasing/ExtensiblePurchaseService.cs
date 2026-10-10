using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000035 RID: 53
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ExtensiblePurchaseService : IPurchaseService
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00003622 File Offset: 0x00001822
		protected ExtensiblePurchaseService(IPurchaseService basePurchaseService)
		{
			this.m_BaseInternalPurchaseService = basePurchaseService;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00003631 File Offset: 0x00001831
		[Nullable(2)]
		public virtual IAppleStoreExtendedPurchaseService Apple
		{
			[NullableContext(2)]
			get
			{
				return this.m_BaseInternalPurchaseService.Apple;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000363E File Offset: 0x0000183E
		[Nullable(2)]
		public virtual IGooglePlayStoreExtendedPurchaseService Google
		{
			[NullableContext(2)]
			get
			{
				return this.m_BaseInternalPurchaseService.Google;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000364B File Offset: 0x0000184B
		public virtual void PurchaseProduct(Product product)
		{
			this.m_BaseInternalPurchaseService.PurchaseProduct(product);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003659 File Offset: 0x00001859
		public virtual void Purchase(ICart cart)
		{
			this.m_BaseInternalPurchaseService.Purchase(cart);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003667 File Offset: 0x00001867
		public virtual void ConfirmPurchase(PendingOrder order)
		{
			this.m_BaseInternalPurchaseService.ConfirmPurchase(order);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003675 File Offset: 0x00001875
		public virtual void FetchPurchases()
		{
			this.m_BaseInternalPurchaseService.FetchPurchases();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003682 File Offset: 0x00001882
		public virtual void CheckEntitlement(Product product)
		{
			this.m_BaseInternalPurchaseService.CheckEntitlement(product);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003690 File Offset: 0x00001890
		[NullableContext(2)]
		public virtual void RestoreTransactions(Action<bool, string> callback)
		{
			this.m_BaseInternalPurchaseService.RestoreTransactions(callback);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000369E File Offset: 0x0000189E
		public virtual ReadOnlyObservableCollection<Order> GetPurchases()
		{
			return this.m_BaseInternalPurchaseService.GetPurchases();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000036AB File Offset: 0x000018AB
		public void ProcessPendingOrdersOnPurchasesFetched(bool shouldProcess)
		{
			this.m_BaseInternalPurchaseService.ProcessPendingOrdersOnPurchasesFetched(shouldProcess);
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060000E1 RID: 225 RVA: 0x000036B9 File Offset: 0x000018B9
		// (remove) Token: 0x060000E2 RID: 226 RVA: 0x000036C7 File Offset: 0x000018C7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<PendingOrder> OnPurchasePending
		{
			add
			{
				this.m_BaseInternalPurchaseService.OnPurchasePending += value;
			}
			remove
			{
				this.m_BaseInternalPurchaseService.OnPurchasePending -= value;
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060000E3 RID: 227 RVA: 0x000036D5 File Offset: 0x000018D5
		// (remove) Token: 0x060000E4 RID: 228 RVA: 0x000036E3 File Offset: 0x000018E3
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<Order> OnPurchaseConfirmed
		{
			add
			{
				this.m_BaseInternalPurchaseService.OnPurchaseConfirmed += value;
			}
			remove
			{
				this.m_BaseInternalPurchaseService.OnPurchaseConfirmed -= value;
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060000E5 RID: 229 RVA: 0x000036F1 File Offset: 0x000018F1
		// (remove) Token: 0x060000E6 RID: 230 RVA: 0x000036FF File Offset: 0x000018FF
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<FailedOrder> OnPurchaseFailed
		{
			add
			{
				this.m_BaseInternalPurchaseService.OnPurchaseFailed += value;
			}
			remove
			{
				this.m_BaseInternalPurchaseService.OnPurchaseFailed -= value;
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060000E7 RID: 231 RVA: 0x0000370D File Offset: 0x0000190D
		// (remove) Token: 0x060000E8 RID: 232 RVA: 0x0000371B File Offset: 0x0000191B
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<DeferredOrder> OnPurchaseDeferred
		{
			add
			{
				this.m_BaseInternalPurchaseService.OnPurchaseDeferred += value;
			}
			remove
			{
				this.m_BaseInternalPurchaseService.OnPurchaseDeferred -= value;
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060000E9 RID: 233 RVA: 0x00003729 File Offset: 0x00001929
		// (remove) Token: 0x060000EA RID: 234 RVA: 0x00003737 File Offset: 0x00001937
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<Orders> OnPurchasesFetched
		{
			add
			{
				this.m_BaseInternalPurchaseService.OnPurchasesFetched += value;
			}
			remove
			{
				this.m_BaseInternalPurchaseService.OnPurchasesFetched -= value;
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060000EB RID: 235 RVA: 0x00003745 File Offset: 0x00001945
		// (remove) Token: 0x060000EC RID: 236 RVA: 0x00003753 File Offset: 0x00001953
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<PurchasesFetchFailureDescription> OnPurchasesFetchFailed
		{
			add
			{
				this.m_BaseInternalPurchaseService.OnPurchasesFetchFailed += value;
			}
			remove
			{
				this.m_BaseInternalPurchaseService.OnPurchasesFetchFailed -= value;
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060000ED RID: 237 RVA: 0x00003761 File Offset: 0x00001961
		// (remove) Token: 0x060000EE RID: 238 RVA: 0x0000376F File Offset: 0x0000196F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<Entitlement> OnCheckEntitlement
		{
			add
			{
				this.m_BaseInternalPurchaseService.OnCheckEntitlement += value;
			}
			remove
			{
				this.m_BaseInternalPurchaseService.OnCheckEntitlement -= value;
			}
		}

		// Token: 0x04000032 RID: 50
		private IPurchaseService m_BaseInternalPurchaseService;
	}
}
