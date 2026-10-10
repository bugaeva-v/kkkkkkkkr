using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000B0 RID: 176
	[Serializable]
	public class Price : ISerializationCallbackReceiver
	{
		// Token: 0x06000324 RID: 804 RVA: 0x0000782A File Offset: 0x00005A2A
		public void OnBeforeSerialize()
		{
			this.data = decimal.GetBits(this.value);
			this.num = decimal.ToDouble(this.value);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000784E File Offset: 0x00005A4E
		public void OnAfterDeserialize()
		{
			if (this.data != null && this.data.Length == 4)
			{
				this.value = new decimal(this.data);
			}
		}

		// Token: 0x040000ED RID: 237
		public decimal value;

		// Token: 0x040000EE RID: 238
		[SerializeField]
		private int[] data;

		// Token: 0x040000EF RID: 239
		[SerializeField]
		private double num;
	}
}
