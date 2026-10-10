using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.shopping
{
	// Token: 0x02000034 RID: 52
	public class CartService : App42Service
	{
		// Token: 0x06000205 RID: 517 RVA: 0x0000AE71 File Offset: 0x00009071
		public CartService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "cart";
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000AEA0 File Offset: 0x000090A0
		public void CreateCart(string user, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(user, "User");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"userName\":\"" + user + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"cart\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000AF80 File Offset: 0x00009180
		public void GetCartDetails(string cartId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(cartId, "CartId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("cartId", cartId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				cartId,
				"/details"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000B038 File Offset: 0x00009238
		public void AddItem(string cartID, string itemID, long itemQuantity, double price, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(cartID, "CartID");
			Util.ThrowExceptionIfNullOrBlank(itemID, "ItemID");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"quantity\":" + itemQuantity + ",");
			stringBuilder.Append("\"amount\":" + price + "}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"cartId\":\"" + cartID + "\",");
			stringBuilder2.Append("\"item\":" + stringBuilder.ToString());
			dictionary.Add("itemId", itemID);
			StringBuilder stringBuilder3 = new StringBuilder();
			stringBuilder3.Append("{\"app42\":{\"cart\":").Append(stringBuilder2.ToString()).Append("}}}");
			dictionary.Add("body", stringBuilder3.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/item/",
				itemID
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder3.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000B1B0 File Offset: 0x000093B0
		public void GetItems(string cartId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(cartId, "CartId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("cartId", cartId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				cartId
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000B260 File Offset: 0x00009460
		public void GetItem(string cartId, string itemId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(cartId, "CartId");
			Util.ThrowExceptionIfNullOrBlank(itemId, "ItemId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("cartId", cartId);
			dictionary.Add("itemId", itemId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				cartId,
				"/",
				itemId
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000B334 File Offset: 0x00009534
		public void RemoveItem(string cartId, string itemId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(cartId, "CartId");
			Util.ThrowExceptionIfNullOrBlank(itemId, "ItemId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("cartId", cartId);
			dictionary.Add("itemId", itemId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				cartId,
				"/",
				itemId
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000B408 File Offset: 0x00009608
		public void RemoveAllItems(string cartId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(cartId, "CartId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("cartId", cartId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				cartId
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000B4B8 File Offset: 0x000096B8
		public void IsEmpty(string cartId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(cartId, "CartId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("cartId", cartId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				cartId,
				"/isEmpty"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000B570 File Offset: 0x00009770
		public void CheckOut(string cartId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(cartId, "CartId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"cartId\":\"" + cartId + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"cart\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/checkOut";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000B658 File Offset: 0x00009858
		public void Payment(string cartID, string transactionID, string paymentStatus, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(transactionID, "TransactionId");
			Util.ThrowExceptionIfNullOrBlank(paymentStatus, "paymentStatus");
			Util.ThrowExceptionIfNullOrBlank(cartID, "CartID");
			if (!PaymentStatus.AUTHORIZED.ToString().Equals(paymentStatus) && !PaymentStatus.DECLINED.ToString().Equals(paymentStatus) && !PaymentStatus.PENDING.ToString().Equals(paymentStatus))
			{
				throw new App42Exception("Invalid Status. Could be either AUTHORIZED or UNAUTHORIZED or DECLINED");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"cartId\":\"" + cartID + "\",");
			stringBuilder.Append("\"transactionId\":\"" + transactionID + "\",");
			stringBuilder.Append("\"status\":\"" + paymentStatus + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"cart\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/payment";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000B7C8 File Offset: 0x000099C8
		public void GetPaymentsByUser(string userId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userId, "UserId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userId", userId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			dictionary2.Add("isArray", "true");
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/payments/user/",
				userId
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000B888 File Offset: 0x00009A88
		public void GetPaymentByCart(string cartId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(cartId, "CartId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("cartId", cartId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/payments/cart/",
				cartId
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000B938 File Offset: 0x00009B38
		public void GetPaymentsByUserAndStatus(string userId, string paymentStatus, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userId, "userId");
			Util.ThrowExceptionIfNullOrBlank(paymentStatus, "paymentStatus");
			if (!PaymentStatus.AUTHORIZED.ToString().Equals(paymentStatus) && !PaymentStatus.DECLINED.ToString().Equals(paymentStatus) && !PaymentStatus.PENDING.ToString().Equals(paymentStatus))
			{
				throw new App42Exception("Invalid Status. Could be either AUTHORIZED or UNAUTHORIZED or DECLINED");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("status", paymentStatus);
			dictionary.Add("userId", userId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/payments/user/",
				userId,
				"/",
				paymentStatus
			});
			dictionary2.Add("isArray", "true");
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000BA60 File Offset: 0x00009C60
		public void GetPaymentsByStatus(string paymentStatus, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(paymentStatus, "PaymentStatus");
			if (!PaymentStatus.AUTHORIZED.ToString().Equals(paymentStatus) && !PaymentStatus.DECLINED.ToString().Equals(paymentStatus) && !PaymentStatus.PENDING.ToString().Equals(paymentStatus))
			{
				throw new App42Exception("Invalid Status. Could be either AUTHORIZED or UNAUTHORIZED or DECLINED");
			}
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("status", paymentStatus);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			dictionary2.Add("isArray", "true");
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/payments/status/",
				paymentStatus
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000BB60 File Offset: 0x00009D60
		public void GetPaymentHistoryByUser(string userId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(userId, "UserId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("userId", userId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			dictionary2.Add("isArray", "true");
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/payment/history/",
				userId
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000BC20 File Offset: 0x00009E20
		public void GetPaymentHistoryAll(App42CallBack callBack)
		{
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			dictionary2.Add("isArray", "true");
			string url = this.version + "/" + this.resource + "/payment/history";
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000BCAC File Offset: 0x00009EAC
		public void IncreaseQuantity(string cartID, string itemID, int itemQuantity, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(cartID, "CartId");
			Util.ThrowExceptionIfNullOrBlank(itemID, "ItemId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"cartId\":\"" + cartID + "\",");
			stringBuilder.Append("\"itemId\":\"" + itemID + "\",");
			stringBuilder.Append("\"quantity\":\"" + itemQuantity + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"cart\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/increaseQuantity";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000BDD4 File Offset: 0x00009FD4
		public void DecreaseQuantity(string cartID, string itemID, int itemQuantity, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(cartID, "CartId");
			Util.ThrowExceptionIfNullOrBlank(itemID, "ItemId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"cartId\":\"" + cartID + "\",");
			stringBuilder.Append("\"itemId\":\"" + itemID + "\",");
			stringBuilder.Append("\"quantity\":\"" + itemQuantity + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"cart\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/decreaseQuantity";
			RESTConnectorWWW.GetInstance().ExecutePut(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}
	}
}
