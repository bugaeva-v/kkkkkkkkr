using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000071 RID: 113
	[NullableContext(1)]
	[Nullable(0)]
	internal class ConfirmOrderUseCase : IConfirmOrderUseCase, IStorePurchaseConfirmCallback
	{
		// Token: 0x0600020E RID: 526 RVA: 0x00005DF5 File Offset: 0x00003FF5
		[Preserve]
		internal ConfirmOrderUseCase(IStore storeResponsible)
		{
			this.m_Store = storeResponsible;
			this.m_Store.SetPurchaseConfirmCallback(this);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00005E1B File Offset: 0x0000401B
		public void ConfirmOrder(PendingOrder order, Action<PendingOrder, Order> confirmationAction)
		{
			if (this.FindExistingConfirmationRequest(order))
			{
				confirmationAction(order, new FailedOrder(order, PurchaseFailureReason.ExistingPurchasePending, "Duplicate order requested for confirmation. Please refrain from passing the same `PendingOrder` multiple times."));
				return;
			}
			this.AddAndSendFinishTransactionRequest(order, confirmationAction);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00005E44 File Offset: 0x00004044
		private bool FindExistingConfirmationRequest(PendingOrder orderToCheckFor)
		{
			return this.m_ConfirmationRequests.Exists(delegate(ConfirmOrderRequest request)
			{
				PendingOrder orderToConfirm = request.OrderToConfirm;
				return ((orderToConfirm != null) ? orderToConfirm.Info.TransactionID : null) == orderToCheckFor.Info.TransactionID;
			});
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00005E75 File Offset: 0x00004075
		private void AddAndSendFinishTransactionRequest(PendingOrder order, Action<PendingOrder, Order> confirmationAction)
		{
			this.m_ConfirmationRequests.Add(new ConfirmOrderRequest(order, confirmationAction));
			this.m_Store.FinishTransaction(order);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00005E98 File Offset: 0x00004098
		public void OnConfirmOrderSucceeded(string transactionId)
		{
			ConfirmOrderRequest matchingRequest = this.GetMatchingRequest(transactionId);
			if (matchingRequest != null)
			{
				ConfirmedOrder arg = new ConfirmedOrder(matchingRequest.OrderToConfirm.CartOrdered, matchingRequest.OrderToConfirm.Info);
				Action<PendingOrder, Order> action = matchingRequest.Action;
				if (action != null)
				{
					action(matchingRequest.OrderToConfirm, arg);
				}
				this.m_ConfirmationRequests.Remove(matchingRequest);
				return;
			}
			Debug.unityLogger.LogIAPError("Cannot find matching confirmation request for transaction id: " + transactionId + ". The List of orders may have become corrupt. No callbacks will be sent for this call.");
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00005F0C File Offset: 0x0000410C
		public void OnConfirmOrderFailed(FailedOrder failedOrder)
		{
			ConfirmOrderRequest matchingRequest = this.GetMatchingRequest(failedOrder.Info.TransactionID);
			if (matchingRequest != null)
			{
				if (failedOrder.Info.Receipt == string.Empty)
				{
					failedOrder = new FailedOrder(matchingRequest.OrderToConfirm, failedOrder.FailureReason, failedOrder.Details);
				}
				Action<PendingOrder, Order> action = matchingRequest.Action;
				if (action != null)
				{
					action(matchingRequest.OrderToConfirm, failedOrder);
				}
				this.m_ConfirmationRequests.Remove(matchingRequest);
				return;
			}
			Debug.unityLogger.LogIAPError("Cannot find matching confirmation request for transaction id: " + failedOrder.Info.TransactionID + ". The List of orders may have become corrupt. No callbacks will be sent for this call.");
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00005FA8 File Offset: 0x000041A8
		[return: Nullable(2)]
		private ConfirmOrderRequest GetMatchingRequest(string transactionIdentifier)
		{
			return this.m_ConfirmationRequests.FirstOrDefault((ConfirmOrderRequest request) => request.OrderToConfirm.Info.TransactionID == transactionIdentifier);
		}

		// Token: 0x040000A5 RID: 165
		private readonly IStore m_Store;

		// Token: 0x040000A6 RID: 166
		private readonly List<ConfirmOrderRequest> m_ConfirmationRequests = new List<ConfirmOrderRequest>();
	}
}
