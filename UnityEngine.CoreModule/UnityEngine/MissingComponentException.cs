using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x0200021C RID: 540
	[Serializable]
	public class MissingComponentException : SystemException
	{
		// Token: 0x06001775 RID: 6005 RVA: 0x00025F35 File Offset: 0x00024135
		public MissingComponentException() : base("A Unity Runtime error occurred!")
		{
			base.HResult = -2147467261;
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00025F50 File Offset: 0x00024150
		public MissingComponentException(string message) : base(message)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00025F67 File Offset: 0x00024167
		public MissingComponentException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00025F7F File Offset: 0x0002417F
		protected MissingComponentException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0400080A RID: 2058
		private const int Result = -2147467261;

		// Token: 0x0400080B RID: 2059
		private string unityStackTrace;
	}
}
