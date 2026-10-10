using System;
using System.Text;
using SimpleJSON;

namespace com.shephertz.app42.paas.sdk.csharp.storage
{
	// Token: 0x02000051 RID: 81
	public class GeoQuery : App42Response
	{
		// Token: 0x06000308 RID: 776 RVA: 0x00010B66 File Offset: 0x0000ED66
		public GeoQuery(StringBuilder jsonQuery)
		{
			this.jsonObject = jsonQuery;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00010B75 File Offset: 0x0000ED75
		public GeoQuery(JSONArray jsonQuery)
		{
			this.jsonArray = jsonQuery;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00010B84 File Offset: 0x0000ED84
		public string GetStr()
		{
			if (this.jsonObject != null)
			{
				return new StringBuilder("[").Append(this.jsonObject.ToString()).Append("]").ToString();
			}
			return this.jsonArray.ToString();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00010BC3 File Offset: 0x0000EDC3
		public new object GetType()
		{
			if (this.jsonObject != null)
			{
				return this.jsonObject;
			}
			return this.jsonArray;
		}

		// Token: 0x04000158 RID: 344
		private StringBuilder jsonObject;

		// Token: 0x04000159 RID: 345
		private JSONArray jsonArray;
	}
}
