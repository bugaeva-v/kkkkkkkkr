using System;
using System.Text;

namespace com.shephertz.app42.paas.sdk.csharp.storage
{
	// Token: 0x02000084 RID: 132
	public class Query : App42Response
	{
		// Token: 0x0600057F RID: 1407 RVA: 0x0001F1B6 File Offset: 0x0001D3B6
		public Query(string jsonQuery)
		{
			this.jsonObject = jsonQuery;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0001F1C5 File Offset: 0x0001D3C5
		public Query(StringBuilder jsonQuery)
		{
			this.jsonArray = jsonQuery;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0001F1D4 File Offset: 0x0001D3D4
		public string GetStr()
		{
			if (this.jsonObject != null)
			{
				return new StringBuilder("[").Append(this.jsonObject.ToString()).Append("]").ToString();
			}
			return this.jsonArray.ToString();
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0001F213 File Offset: 0x0001D413
		public new object GetType()
		{
			if (this.jsonObject != null)
			{
				return this.jsonObject;
			}
			return this.jsonArray;
		}

		// Token: 0x04000245 RID: 581
		private string jsonObject;

		// Token: 0x04000246 RID: 582
		private StringBuilder jsonArray;
	}
}
