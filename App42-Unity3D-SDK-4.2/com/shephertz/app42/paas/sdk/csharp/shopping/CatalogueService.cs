using System;
using System.Collections.Generic;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.shopping
{
	// Token: 0x02000039 RID: 57
	public class CatalogueService : App42Service
	{
		// Token: 0x06000239 RID: 569 RVA: 0x0000C4BA File Offset: 0x0000A6BA
		public CatalogueService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "catalogue";
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
		public void CreateCatalogue(string catalogueName, string catalogueDescription, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(catalogueName, "CatalogueName");
			Util.ThrowExceptionIfNullOrBlank(catalogueDescription, "CatalogueDescription");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + catalogueName + "\",");
			stringBuilder.Append("\"description\":\"" + catalogueDescription + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"catalogue\":").Append(stringBuilder.ToString()).Append("}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource;
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000C5EC File Offset: 0x0000A7EC
		public void CreateCategory(string catalogueName, string categoryName, string categoryDescription, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(catalogueName, "CatalogueName");
			Util.ThrowExceptionIfNullOrBlank(categoryName, "CategoryName");
			Util.ThrowExceptionIfNullOrBlank(categoryDescription, "CategoryDescription");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("catalogueName", catalogueName);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\"name\":\"" + categoryName + "\",");
			stringBuilder.Append("\"description\":\"" + categoryDescription + "\"}");
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("{\"app42\":{\"catalogue\":{\"categories\":{\"category\":").Append(stringBuilder).Append("}}}}");
			dictionary.Add("body", stringBuilder2.ToString());
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				catalogueName,
				"/category"
			});
			RESTConnectorWWW.GetInstance().ExecutePost(url, paramsDics, stringBuilder2.ToString(), dictionary, dictionary2, callBack);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000C730 File Offset: 0x0000A930
		public void AddItem(string catalogueName, string categoryName, ItemData itemData, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(catalogueName, "CatalogueName");
			Util.ThrowExceptionIfNullOrBlank(categoryName, "CategoryName");
			Util.ThrowExceptionIfNullOrBlank(itemData, "ItemData");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Dictionary<string, string> dictionary2 = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3 = base.Merge(dictionary2, obj);
			dictionary.Add("catalogueName", catalogueName);
			dictionary.Add("categoryName", categoryName);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary)
			{
				dictionary2.Add(keyValuePair.Key, keyValuePair.Value);
			}
			Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
			dictionary4.Add("itemId", itemData.GetItemId());
			dictionary4.Add("name", itemData.GetName());
			dictionary4.Add("description", itemData.GetDescription());
			dictionary4.Add("price", string.Concat(itemData.GetPrice()));
			foreach (KeyValuePair<string, string> keyValuePair2 in dictionary4)
			{
				dictionary2.Add(keyValuePair2.Key, keyValuePair2.Value);
			}
			string value = Util.Sign(this.secretKey, dictionary2);
			dictionary3.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				catalogueName,
				"/",
				categoryName,
				"/item"
			});
			string image = itemData.GetImage();
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", image, dictionary, dictionary4, dictionary2, dictionary3, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000C92C File Offset: 0x0000AB2C
		public void GetItems(string catalogueName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(catalogueName, "CatalogueName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("catalogueName", catalogueName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				catalogueName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		public void GetItemsByCategory(string catalogueName, string categoryName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(catalogueName, "CatalogueName");
			Util.ThrowExceptionIfNullOrBlank(categoryName, "CategoryName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("catalogueName", catalogueName);
			dictionary.Add("categoryName", categoryName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				catalogueName,
				"/",
				categoryName
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		public void GetItemById(string catalogueName, string categoryName, string itemId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(catalogueName, "CatalogueName");
			Util.ThrowExceptionIfNullOrBlank(categoryName, "CategoryName");
			Util.ThrowExceptionIfNullOrBlank(itemId, "itemId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("catalogueName", catalogueName);
			dictionary.Add("categoryName", categoryName);
			dictionary.Add("itemId", itemId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				catalogueName,
				"/",
				categoryName,
				"/",
				itemId
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000CBAC File Offset: 0x0000ADAC
		public void RemoveAllItems(string catalogueName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(catalogueName, "CatalogueName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("catalogueName", catalogueName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				catalogueName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000CC5C File Offset: 0x0000AE5C
		public void RemoveItemsByCategory(string catalogueName, string categoryName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(catalogueName, "CatalogueName");
			Util.ThrowExceptionIfNullOrBlank(categoryName, "CategoryName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("catalogueName", catalogueName);
			dictionary.Add("categoryName", categoryName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				catalogueName,
				"/",
				categoryName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000CD30 File Offset: 0x0000AF30
		public void RemoveItemById(string catalogueName, string categoryName, string itemId, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(catalogueName, "CatalogueName");
			Util.ThrowExceptionIfNullOrBlank(categoryName, "CategoryName");
			Util.ThrowExceptionIfNullOrBlank(itemId, "ItemId");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("catalogueName", catalogueName);
			dictionary.Add("categoryName", categoryName);
			dictionary.Add("itemId", itemId);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				catalogueName,
				"/",
				categoryName,
				"/",
				itemId
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000CE2C File Offset: 0x0000B02C
		public void GetItemsByCategory(string catalogueName, string categoryName, int max, int offset, App42CallBack callBack)
		{
			Util.ValidateMax(max);
			Util.ThrowExceptionIfNullOrBlank(catalogueName, "CatalogueName");
			Util.ThrowExceptionIfNullOrBlank(categoryName, "CategoryName");
			Util.ThrowExceptionIfNullOrBlank(max, "Max");
			Util.ThrowExceptionIfNullOrBlank(offset, "Offset");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("catalogueName", catalogueName);
			dictionary.Add("categoryName", categoryName);
			dictionary.Add("max", string.Concat(max));
			dictionary.Add("offset", string.Concat(offset));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new object[]
			{
				this.version,
				"/",
				this.resource,
				"/paging/",
				catalogueName,
				"/",
				categoryName,
				"/",
				max,
				"/",
				offset
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000CF80 File Offset: 0x0000B180
		public void GetItemsCountByCategory(string catalogueName, string categoryName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(catalogueName, "CatalogueName");
			Util.ThrowExceptionIfNullOrBlank(categoryName, "CategoryName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("catalogueName", catalogueName);
			dictionary.Add("categoryName", categoryName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				catalogueName,
				"/",
				categoryName,
				"/count"
			});
			RESTConnectorWWW.GetInstance().ExecuteGet(url, paramsDics, dictionary, dictionary2, callBack);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000D060 File Offset: 0x0000B260
		public void DeleteCategory(string catalogueName, string categoryName, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(catalogueName, "CatalogueName");
			Util.ThrowExceptionIfNullOrBlank(categoryName, "CategoryName");
			Dictionary<string, string> paramsDics = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			dictionary.Add("catalogueName", catalogueName);
			dictionary.Add("categoryName", categoryName);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = string.Concat(new string[]
			{
				this.version,
				"/",
				this.resource,
				"/",
				catalogueName,
				"/category/",
				categoryName
			});
			RESTConnectorWWW.GetInstance().ExecuteDelete(url, paramsDics, dictionary, dictionary2, callBack);
		}
	}
}
