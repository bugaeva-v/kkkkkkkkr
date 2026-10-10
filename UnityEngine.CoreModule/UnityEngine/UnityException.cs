using System;
using System.Runtime.Serialization;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200021B RID: 539
	[RequiredByNativeCode]
	[Serializable]
	public class UnityException : SystemException
	{
		// Token: 0x06001771 RID: 6001 RVA: 0x00025F35 File Offset: 0x00024135
		public UnityException() : base("A Unity Runtime error occurred!")
		{
			base.HResult = -2147467261;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00025F50 File Offset: 0x00024150
		public UnityException(string message) : base(message)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00025F67 File Offset: 0x00024167
		public UnityException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00025F7F File Offset: 0x0002417F
		protected UnityException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000808 RID: 2056
		private const int Result = -2147467261;

		// Token: 0x04000809 RID: 2057
		private string unityStackTrace;
	}
}
