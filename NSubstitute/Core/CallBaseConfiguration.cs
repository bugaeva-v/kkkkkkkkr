using System;
using System.Collections.Concurrent;

namespace NSubstitute.Core
{
	// Token: 0x02000065 RID: 101
	public class CallBaseConfiguration : ICallBaseConfiguration
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000053BB File Offset: 0x000035BB
		private ConcurrentStack<CallBaseConfiguration.CallBaseRule> Rules { get; } = new ConcurrentStack<CallBaseConfiguration.CallBaseRule>();

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000053C3 File Offset: 0x000035C3
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000053CB File Offset: 0x000035CB
		public bool CallBaseByDefault { get; set; }

		// Token: 0x06000164 RID: 356 RVA: 0x000053D4 File Offset: 0x000035D4
		public void Exclude(ICallSpecification callSpecification)
		{
			this.Rules.Push(new CallBaseConfiguration.CallBaseRule(callSpecification, false));
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000053E8 File Offset: 0x000035E8
		public void Include(ICallSpecification callSpecification)
		{
			this.Rules.Push(new CallBaseConfiguration.CallBaseRule(callSpecification, true));
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000053FC File Offset: 0x000035FC
		public bool ShouldCallBase(ICall call)
		{
			bool result;
			if (!this.TryGetExplicitConfiguration(call, out result))
			{
				return this.CallBaseByDefault;
			}
			return result;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000541C File Offset: 0x0000361C
		private bool TryGetExplicitConfiguration(ICall call, out bool callBase)
		{
			callBase = false;
			if (this.Rules.IsEmpty)
			{
				return false;
			}
			foreach (CallBaseConfiguration.CallBaseRule callBaseRule in this.Rules)
			{
				if (callBaseRule.IsSatisfiedBy(call))
				{
					callBase = callBaseRule.CallBase;
					return true;
				}
			}
			return false;
		}

		// Token: 0x02000110 RID: 272
		private readonly struct CallBaseRule
		{
			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x00009C4C File Offset: 0x00007E4C
			private ICallSpecification CallSpecification { get; }

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000443 RID: 1091 RVA: 0x00009C54 File Offset: 0x00007E54
			public bool CallBase { get; }

			// Token: 0x06000444 RID: 1092 RVA: 0x00009C5C File Offset: 0x00007E5C
			public CallBaseRule(ICallSpecification callSpecification, bool callBase)
			{
				this.CallSpecification = callSpecification;
				this.CallBase = callBase;
			}

			// Token: 0x06000445 RID: 1093 RVA: 0x00009C6C File Offset: 0x00007E6C
			public bool IsSatisfiedBy(ICall call)
			{
				return this.CallSpecification.IsSatisfiedBy(call);
			}
		}
	}
}
