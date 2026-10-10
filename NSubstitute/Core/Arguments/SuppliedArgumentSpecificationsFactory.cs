using System;
using System.Collections.Generic;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000E1 RID: 225
	public class SuppliedArgumentSpecificationsFactory : ISuppliedArgumentSpecificationsFactory
	{
		// Token: 0x060003A6 RID: 934 RVA: 0x00009287 File Offset: 0x00007487
		public SuppliedArgumentSpecificationsFactory(IArgumentSpecificationCompatibilityTester argumentSpecificationCompatTester)
		{
			this._argumentSpecificationCompatTester = argumentSpecificationCompatTester;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00009296 File Offset: 0x00007496
		public ISuppliedArgumentSpecifications Create(IEnumerable<IArgumentSpecification> argumentSpecifications)
		{
			return new SuppliedArgumentSpecifications(this._argumentSpecificationCompatTester, argumentSpecifications);
		}

		// Token: 0x0400010A RID: 266
		private readonly IArgumentSpecificationCompatibilityTester _argumentSpecificationCompatTester;
	}
}
