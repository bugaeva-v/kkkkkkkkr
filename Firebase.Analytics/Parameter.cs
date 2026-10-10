using System;
using System.Collections.Generic;

namespace Firebase.Analytics
{
	// Token: 0x02000005 RID: 5
	public class Parameter : IDisposable
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002635 File Offset: 0x00000835
		// (set) Token: 0x06000016 RID: 22 RVA: 0x0000263D File Offset: 0x0000083D
		internal string Name { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002646 File Offset: 0x00000846
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000264E File Offset: 0x0000084E
		internal object Value { get; set; }

		// Token: 0x06000019 RID: 25 RVA: 0x00002657 File Offset: 0x00000857
		public Parameter(string parameterName, string parameterValue)
		{
			this.Name = parameterName;
			this.Value = parameterValue;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002671 File Offset: 0x00000871
		public Parameter(string parameterName, long parameterValue)
		{
			this.Name = parameterName;
			this.Value = parameterValue;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002690 File Offset: 0x00000890
		public Parameter(string parameterName, double parameterValue)
		{
			this.Name = parameterName;
			this.Value = parameterValue;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002657 File Offset: 0x00000857
		public Parameter(string parameterName, IDictionary<string, object> parameterValue)
		{
			this.Name = parameterName;
			this.Value = parameterValue;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002657 File Offset: 0x00000857
		public Parameter(string parameterName, IEnumerable<IDictionary<string, object>> parameterValue)
		{
			this.Name = parameterName;
			this.Value = parameterValue;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000026AF File Offset: 0x000008AF
		[Obsolete("No longer needed, will be removed in the future.")]
		public void Dispose()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000026AF File Offset: 0x000008AF
		[Obsolete("No longer needed, will be removed in the future.")]
		public void Dispose(bool disposing)
		{
		}
	}
}
