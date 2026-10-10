using System;
using System.Collections.Generic;
using Stores.Util;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000034 RID: 52
	internal class AppleJsonProductDescriptionsDeserializer : JsonProductDescriptionsDeserializer
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00004DEC File Offset: 0x00002FEC
		internal override ProductMetadata DeserializeMetadata(Dictionary<string, object> data)
		{
			bool isFamilyShareable = Convert.ToBoolean(data.TryGetString("isFamilyShareable"));
			return new AppleProductMetadata(base.DeserializeMetadata(data), isFamilyShareable);
		}
	}
}
