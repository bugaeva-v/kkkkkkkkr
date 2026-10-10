using System;
using System.Collections.Generic;
using System.IO;
using com.shephertz.app42.paas.sdk.csharp.connection;
using com.shephertz.app42.paas.sdk.csharp.util;

namespace com.shephertz.app42.paas.sdk.csharp.imageProcessor
{
	// Token: 0x0200005E RID: 94
	public class ImageProcessorService : App42Service
	{
		// Token: 0x06000385 RID: 901 RVA: 0x00012F23 File Offset: 0x00011123
		public ImageProcessorService(string apiKey, string secretKey)
		{
			this.apiKey = apiKey;
			this.secretKey = secretKey;
			this.version = "1.0";
			this.resource = "image";
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00012F50 File Offset: 0x00011150
		public void Resize(string name, string imagePath, int width, int height, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(imagePath, "Image Path");
			string extension = Path.GetExtension(imagePath);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			if (!File.Exists(imagePath))
			{
				throw new App42Exception(" File " + imagePath + " does not exist");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("width", string.Concat(width));
			dictionary3.Add("height", string.Concat(height));
			dictionary.Add("name", name);
			dictionary.Add("width", string.Concat(width));
			dictionary.Add("height", string.Concat(height));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/resize";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", imagePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000130D8 File Offset: 0x000112D8
		public void Thumbnail(string name, string imagePath, int width, int height, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(imagePath, "Image Path");
			string extension = Path.GetExtension(imagePath);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			if (!File.Exists(imagePath))
			{
				throw new App42Exception(" File " + imagePath + " does not exist");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("width", string.Concat(width));
			dictionary3.Add("height", string.Concat(height));
			dictionary.Add("name", name);
			dictionary.Add("width", string.Concat(width));
			dictionary.Add("height", string.Concat(height));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/thumbnail";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", imagePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00013260 File Offset: 0x00011460
		public void Scale(string name, string imagePath, int width, int height, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(imagePath, "Image Path");
			string extension = Path.GetExtension(imagePath);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			if (!File.Exists(imagePath))
			{
				throw new App42Exception(" File " + imagePath + " does not exist");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("width", string.Concat(width));
			dictionary3.Add("height", string.Concat(height));
			dictionary.Add("name", name);
			dictionary.Add("width", string.Concat(width));
			dictionary.Add("height", string.Concat(height));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/scale";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", imagePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000133E8 File Offset: 0x000115E8
		public void Crop(string name, string imagePath, int width, int height, int x, int y, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(imagePath, "Image Path");
			string extension = Path.GetExtension(imagePath);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			if (!File.Exists(imagePath))
			{
				throw new App42Exception(" File " + imagePath + " does not exist");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("width", string.Concat(width));
			dictionary3.Add("height", string.Concat(height));
			dictionary3.Add("x", string.Concat(x));
			dictionary3.Add("y", string.Concat(y));
			dictionary.Add("name", name);
			dictionary.Add("width", string.Concat(width));
			dictionary.Add("height", string.Concat(height));
			dictionary.Add("x", string.Concat(x));
			dictionary.Add("y", string.Concat(y));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/crop";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", imagePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000135CC File Offset: 0x000117CC
		public void ResizeByPercentage(string name, string imagePath, double percentage, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(imagePath, "Image Path");
			string extension = Path.GetExtension(imagePath);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			if (!File.Exists(imagePath))
			{
				throw new App42Exception(" File " + imagePath + " does not exist");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("percentage", string.Concat(percentage));
			dictionary.Add("name", name);
			dictionary.Add("percentage", string.Concat(percentage));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/resizePercentage";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", imagePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00013724 File Offset: 0x00011924
		public void ThumbnailByPercentage(string name, string imagePath, double percentage, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(imagePath, "Image Path");
			string extension = Path.GetExtension(imagePath);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			if (!File.Exists(imagePath))
			{
				throw new App42Exception(" File " + imagePath + " does not exist");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("percentage", string.Concat(percentage));
			dictionary.Add("name", name);
			dictionary.Add("percentage", string.Concat(percentage));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/thumbnailPercentage";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", imagePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0001387C File Offset: 0x00011A7C
		public void ScaleByPercentage(string name, string imagePath, double percentage, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(imagePath, "Image Path");
			string extension = Path.GetExtension(imagePath);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			if (!File.Exists(imagePath))
			{
				throw new App42Exception(" File " + imagePath + " does not exist");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("percentage", string.Concat(percentage));
			dictionary.Add("name", name);
			dictionary.Add("percentage", string.Concat(percentage));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/scalePercentage";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", imagePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000139D4 File Offset: 0x00011BD4
		public void ConvertFormat(string name, string imagePath, string formatToConvert, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(imagePath, "Image Path");
			Util.ThrowExceptionIfNullOrBlank(formatToConvert, "FormatToConvert");
			string extension = Path.GetExtension(imagePath);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			if (!formatToConvert.Equals(".jpg") && !formatToConvert.Equals(".jpeg") && !formatToConvert.Equals(".gif") && !formatToConvert.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("=====   The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			if (!File.Exists(imagePath))
			{
				throw new App42Exception(" File " + imagePath + " does not exist");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("formatToConvert", formatToConvert);
			dictionary.Add("name", name);
			dictionary.Add("formatToConvert", formatToConvert);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/convertformat";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", imagePath, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00013B60 File Offset: 0x00011D60
		public void Resize(string name, Stream inputStream, int width, int height, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "Image Path");
			FileStream fileStream = inputStream as FileStream;
			string extension = Path.GetExtension(fileStream.Name);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("width", string.Concat(width));
			dictionary3.Add("height", string.Concat(height));
			dictionary.Add("name", name);
			dictionary.Add("width", string.Concat(width));
			dictionary.Add("height", string.Concat(height));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/resize";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00013CD8 File Offset: 0x00011ED8
		public void Thumbnail(string name, Stream inputStream, int width, int height, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "Image Path");
			FileStream fileStream = inputStream as FileStream;
			string extension = Path.GetExtension(fileStream.Name);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("width", string.Concat(width));
			dictionary3.Add("height", string.Concat(height));
			dictionary.Add("name", name);
			dictionary.Add("width", string.Concat(width));
			dictionary.Add("height", string.Concat(height));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/thumbnail";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00013E50 File Offset: 0x00012050
		public void Scale(string name, Stream inputStream, int width, int height, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "Image Path");
			FileStream fileStream = inputStream as FileStream;
			string extension = Path.GetExtension(fileStream.Name);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("width", string.Concat(width));
			dictionary3.Add("height", string.Concat(height));
			dictionary.Add("name", name);
			dictionary.Add("width", string.Concat(width));
			dictionary.Add("height", string.Concat(height));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/scale";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00013FC8 File Offset: 0x000121C8
		public void Crop(string name, Stream inputStream, int width, int height, int x, int y, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "Image Path");
			FileStream fileStream = inputStream as FileStream;
			string extension = Path.GetExtension(fileStream.Name);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("width", string.Concat(width));
			dictionary3.Add("height", string.Concat(height));
			dictionary3.Add("x", string.Concat(x));
			dictionary3.Add("y", string.Concat(y));
			dictionary.Add("name", name);
			dictionary.Add("width", string.Concat(width));
			dictionary.Add("height", string.Concat(height));
			dictionary.Add("x", string.Concat(x));
			dictionary.Add("y", string.Concat(y));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/crop";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0001419C File Offset: 0x0001239C
		public void ResizeByPercentage(string name, Stream inputStream, double percentage, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "Image Path");
			FileStream fileStream = inputStream as FileStream;
			string extension = Path.GetExtension(fileStream.Name);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("percentage", string.Concat(percentage));
			dictionary.Add("name", name);
			dictionary.Add("percentage", string.Concat(percentage));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/resizePercentage";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000142E4 File Offset: 0x000124E4
		public void ThumbnailByPercentage(string name, Stream inputStream, double percentage, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "Image Path");
			FileStream fileStream = inputStream as FileStream;
			string extension = Path.GetExtension(fileStream.Name);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("percentage", string.Concat(percentage));
			dictionary.Add("name", name);
			dictionary.Add("percentage", string.Concat(percentage));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/thumbnailPercentage";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0001442C File Offset: 0x0001262C
		public void ScaleByPercentage(string name, Stream inputStream, double percentage, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "Image Path");
			FileStream fileStream = inputStream as FileStream;
			string extension = Path.GetExtension(fileStream.Name);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("percentage", string.Concat(percentage));
			dictionary.Add("name", name);
			dictionary.Add("percentage", string.Concat(percentage));
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/scalePercentage";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00014574 File Offset: 0x00012774
		public void ConvertFormat(string name, Stream inputStream, string formatToConvert, App42CallBack callBack)
		{
			Util.ThrowExceptionIfNullOrBlank(name, "Name");
			Util.ThrowExceptionIfNullOrBlank(inputStream, "Image Path");
			Util.ThrowExceptionIfNullOrBlank(formatToConvert, "FormatToConvert");
			FileStream fileStream = inputStream as FileStream;
			string extension = Path.GetExtension(fileStream.Name);
			if (!extension.Equals(".jpg") && !extension.Equals(".jpeg") && !extension.Equals(".gif") && !extension.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			if (!formatToConvert.Equals(".jpg") && !formatToConvert.Equals(".jpeg") && !formatToConvert.Equals(".gif") && !formatToConvert.Equals(".png"))
			{
				throw new ArgumentOutOfRangeException("=====   The Request parameters are invalid. Only file with extensions jpg, jpeg, gif and png are supported");
			}
			Dictionary<string, string> queryParams = new Dictionary<string, string>();
			Dictionary<string, string> dictionary = base.PopulateSignParams();
			Dictionary<string, string> obj = base.PopulateMetaHeaderParams();
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2 = base.Merge(dictionary, obj);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3.Add("name", name);
			dictionary3.Add("formatToConvert", formatToConvert);
			dictionary.Add("name", name);
			dictionary.Add("formatToConvert", formatToConvert);
			string value = Util.Sign(this.secretKey, dictionary);
			dictionary2.Add("signature", value);
			string url = this.version + "/" + this.resource + "/convertformat";
			RESTConnectorWWW.GetInstance().ExecuteMultipart("imageFile", inputStream, queryParams, dictionary3, dictionary, dictionary2, url, Config.GetInstance().GetAccept(), callBack);
		}
	}
}
