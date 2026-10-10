using System;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics
{
	// Token: 0x02000011 RID: 17
	public class TransactionItem
	{
		// Token: 0x06000061 RID: 97 RVA: 0x000037FB File Offset: 0x000019FB
		internal void Serialize(IBuffer buffer)
		{
			buffer.PushString("itemName", this.ItemName);
			buffer.PushString("itemType", this.ItemType);
			buffer.PushInt64("itemAmount", this.ItemAmount);
		}

		// Token: 0x04000043 RID: 67
		public string ItemName;

		// Token: 0x04000044 RID: 68
		public string ItemType;

		// Token: 0x04000045 RID: 69
		public long ItemAmount;
	}
}
