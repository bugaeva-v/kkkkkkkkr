using System;

namespace NSubstitute.Core
{
	// Token: 0x0200007E RID: 126
	public interface ICallBaseConfiguration
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001EA RID: 490
		// (set) Token: 0x060001EB RID: 491
		bool CallBaseByDefault { get; set; }

		// Token: 0x060001EC RID: 492
		void Exclude(ICallSpecification callSpecification);

		// Token: 0x060001ED RID: 493
		void Include(ICallSpecification callSpecification);

		// Token: 0x060001EE RID: 494
		bool ShouldCallBase(ICall call);
	}
}
