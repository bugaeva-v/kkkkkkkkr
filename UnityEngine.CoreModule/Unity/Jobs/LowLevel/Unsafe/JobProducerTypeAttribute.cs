using System;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000067 RID: 103
	[AttributeUsage(AttributeTargets.Interface)]
	public sealed class JobProducerTypeAttribute : Attribute
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000375D File Offset: 0x0000195D
		public Type ProducerType { get; }

		// Token: 0x0600018E RID: 398 RVA: 0x00003765 File Offset: 0x00001965
		public JobProducerTypeAttribute(Type producerType)
		{
			this.ProducerType = producerType;
		}
	}
}
