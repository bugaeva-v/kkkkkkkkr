using System;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace Castle.Core.Configuration
{
	// Token: 0x020000F2 RID: 242
	[Serializable]
	public class ConfigurationAttributeCollection : NameValueCollection
	{
		// Token: 0x06000677 RID: 1655 RVA: 0x00012A6E File Offset: 0x00010C6E
		public ConfigurationAttributeCollection()
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00012A76 File Offset: 0x00010C76
		protected ConfigurationAttributeCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
