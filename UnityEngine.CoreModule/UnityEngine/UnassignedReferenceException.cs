using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x0200021D RID: 541
	[Serializable]
	public class UnassignedReferenceException : SystemException
	{
		// Token: 0x06001779 RID: 6009 RVA: 0x00025F35 File Offset: 0x00024135
		public UnassignedReferenceException() : base("A Unity Runtime error occurred!")
		{
			base.HResult = -2147467261;
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00025F50 File Offset: 0x00024150
		public UnassignedReferenceException(string message) : base(message)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00025F67 File Offset: 0x00024167
		public UnassignedReferenceException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00025F7F File Offset: 0x0002417F
		protected UnassignedReferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0400080C RID: 2060
		private const int Result = -2147467261;

		// Token: 0x0400080D RID: 2061
		private string unityStackTrace;
	}
}
