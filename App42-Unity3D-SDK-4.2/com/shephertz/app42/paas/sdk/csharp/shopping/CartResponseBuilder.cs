using System;
using System.Collections.Generic;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.shopping
{
	// Token: 0x02000032 RID: 50
	public class CartResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x060001FE RID: 510 RVA: 0x0000AB74 File Offset: 0x00008D74
		public Cart BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("carts", json);
			if (serviceJSONObject == null)
			{
				Cart cart = new Cart();
				cart.SetStrResponse(json);
				cart.SetResponseSuccess(base.IsResponseSuccess(json));
				cart.SetTotalRecords(base.GetTotalRecords(json));
				return cart;
			}
			JSONNode cartJSONObj = (JSONObject)serviceJSONObject["cart"];
			Cart cart2 = this.BuildCartObject(cartJSONObj);
			cart2.SetStrResponse(json);
			cart2.SetResponseSuccess(base.IsResponseSuccess(json));
			return cart2;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		private Cart BuildCartObject(JSONNode cartJSONObj)
		{
			Cart cart = new Cart();
			base.BuildObjectFromJSONTree(cart, cartJSONObj);
			if (cartJSONObj["items"] != null && cartJSONObj["items"]["item"] != null)
			{
				if (cartJSONObj["items"]["item"] != null && cartJSONObj["items"]["item"] is JSONObject)
				{
					JSONNode jsonObj = (JSONObject)cartJSONObj["items"]["item"];
					Cart.Item obj = new Cart.Item(cart);
					base.BuildObjectFromJSONTree(obj, jsonObj);
				}
				else
				{
					JSONArray jsonarray = (JSONArray)cartJSONObj["items"]["item"];
					for (int i = 0; i < jsonarray.Count; i++)
					{
						JSONNode jsonObj2 = (JSONObject)jsonarray[i];
						Cart.Item obj2 = new Cart.Item(cart);
						base.BuildObjectFromJSONTree(obj2, jsonObj2);
					}
				}
			}
			if (cartJSONObj["payments"] != null && cartJSONObj["payments"]["payment"] != null)
			{
				JSONNode jsonObj3 = (JSONObject)cartJSONObj["payments"]["payment"];
				Cart.Payment obj3 = new Cart.Payment(cart);
				base.BuildObjectFromJSONTree(obj3, jsonObj3);
			}
			return cart;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000AD58 File Offset: 0x00008F58
		public IList<Cart> BuildArrayResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("carts", json);
			IList<Cart> list = new List<Cart>();
			if (serviceJSONObject["cart"] != null && serviceJSONObject["cart"] is JSONArray)
			{
				JSONArray jsonarray = (JSONArray)serviceJSONObject["cart"];
				for (int i = 0; i < jsonarray.Count; i++)
				{
					JSONNode cartJSONObj = (JSONObject)jsonarray[i];
					Cart cart = this.BuildCartObject(cartJSONObj);
					cart.SetStrResponse(json);
					cart.SetResponseSuccess(base.IsResponseSuccess(json));
					list.Add(cart);
				}
			}
			else
			{
				JSONNode cartJSONObj2 = (JSONObject)serviceJSONObject["cart"];
				Cart cart2 = this.BuildCartObject(cartJSONObj2);
				cart2.SetStrResponse(json);
				cart2.SetResponseSuccess(base.IsResponseSuccess(json));
				list.Add(cart2);
			}
			return list;
		}
	}
}
