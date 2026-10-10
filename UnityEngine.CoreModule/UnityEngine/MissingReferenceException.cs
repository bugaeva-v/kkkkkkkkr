using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x0200021E RID: 542
	[Serializable]
	public class MissingReferenceException : SystemException
	{
		// Token: 0x0600177D RID: 6013 RVA: 0x00025F35 File Offset: 0x00024135
		public MissingReferenceException() : base("A Unity Runtime error occurred!")
		{
			base.HResult = -2147467261;
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00025F50 File Offset: 0x00024150
		public MissingReferenceException(string message) : base(message)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00025F67 File Offset: 0x00024167
		public MissingReferenceException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00025F7F File Offset: 0x0002417F
		protected MissingReferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0400080E RID: 2062
		private const int Result = -2147467261;

		// Token: 0x0400080F RID: 2063
		private string unityStackTrace;
	}
}
