using System;
using System.Runtime.Serialization;

namespace Castle.DynamicProxy
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	public class InvalidMixinConfigurationException : Exception
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00002E44 File Offset: 0x00001044
		public InvalidMixinConfigurationException(string message) : base(message)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002E4D File Offset: 0x0000104D
		public InvalidMixinConfigurationException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002E57 File Offset: 0x00001057
		protected InvalidMixinConfigurationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
