using System;

namespace com.shephertz.app42.paas.sdk.csharp
{
	// Token: 0x02000002 RID: 2
	public class App42Response
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public int GetTotalRecords()
		{
			return this.totalRecords;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public void SetTotalRecords(int totalRecords)
		{
			this.totalRecords = totalRecords;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00000261
		public string GetStrResponse()
		{
			return this.strResponse;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269
		public void SetStrResponse(string strResponse)
		{
			this.strResponse = strResponse;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00000272
		public bool IsResponseSuccess()
		{
			return this.responseSuccess;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000207A File Offset: 0x0000027A
		public void SetResponseSuccess(bool IsResponseSuccess)
		{
			this.responseSuccess = IsResponseSuccess;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002083 File Offset: 0x00000283
		public override string ToString()
		{
			return this.strResponse;
		}

		// Token: 0x04000001 RID: 1
		private bool responseSuccess;

		// Token: 0x04000002 RID: 2
		private string strResponse;

		// Token: 0x04000003 RID: 3
		private int totalRecords = -1;
	}
}
