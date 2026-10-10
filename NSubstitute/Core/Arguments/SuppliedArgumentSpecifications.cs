using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000E0 RID: 224
	public class SuppliedArgumentSpecifications : ISuppliedArgumentSpecifications
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000091B8 File Offset: 0x000073B8
		private IReadOnlyCollection<IArgumentSpecification> AllSpecifications { get; }

		// Token: 0x060003A1 RID: 929 RVA: 0x000091C0 File Offset: 0x000073C0
		public SuppliedArgumentSpecifications(IArgumentSpecificationCompatibilityTester argSpecCompatibilityTester, IEnumerable<IArgumentSpecification> argumentSpecifications)
		{
			this._argSpecCompatibilityTester = argSpecCompatibilityTester;
			this.AllSpecifications = argumentSpecifications.ToArray<IArgumentSpecification>();
			this._queue = new Queue<IArgumentSpecification>(this.AllSpecifications);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000091EC File Offset: 0x000073EC
		public bool AnyFor([Nullable(2)] object argument, Type argumentType)
		{
			return this.AllSpecifications.Any((IArgumentSpecification x) => this._argSpecCompatibilityTester.IsSpecificationCompatible(x, argument, argumentType));
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000922C File Offset: 0x0000742C
		public bool IsNextFor([Nullable(2)] object argument, Type argumentType)
		{
			if (this._queue.Count == 0)
			{
				return false;
			}
			IArgumentSpecification specification = this._queue.Peek();
			return this._argSpecCompatibilityTester.IsSpecificationCompatible(specification, argument, argumentType);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00009262 File Offset: 0x00007462
		public IArgumentSpecification Dequeue()
		{
			return this._queue.Dequeue();
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000926F File Offset: 0x0000746F
		public IEnumerable<IArgumentSpecification> DequeueRemaining()
		{
			IEnumerable<IArgumentSpecification> result = this._queue.ToArray();
			this._queue.Clear();
			return result;
		}

		// Token: 0x04000107 RID: 263
		private readonly IArgumentSpecificationCompatibilityTester _argSpecCompatibilityTester;

		// Token: 0x04000108 RID: 264
		private readonly Queue<IArgumentSpecification> _queue;
	}
}
