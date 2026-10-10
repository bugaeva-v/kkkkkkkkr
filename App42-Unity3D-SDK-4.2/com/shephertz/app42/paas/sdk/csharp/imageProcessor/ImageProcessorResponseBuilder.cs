using System;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.imageProcessor
{
	// Token: 0x0200005D RID: 93
	public class ImageProcessorResponseBuilder : App42ResponseBuilder
	{
		// Token: 0x06000383 RID: 899 RVA: 0x00012EAC File Offset: 0x000110AC
		public Image BuildResponse(string json)
		{
			JSONNode serviceJSONObject = base.GetServiceJSONObject("image", json);
			Image image = new Image();
			if (serviceJSONObject == null)
			{
				Image image2 = new Image();
				image2.SetStrResponse(json);
				image2.SetResponseSuccess(base.IsResponseSuccess(json));
				image2.SetTotalRecords(base.GetTotalRecords(json));
				return image2;
			}
			image.SetStrResponse(json);
			image.SetResponseSuccess(base.IsResponseSuccess(json));
			base.BuildObjectFromJSONTree(image, serviceJSONObject);
			return image;
		}
	}
}
