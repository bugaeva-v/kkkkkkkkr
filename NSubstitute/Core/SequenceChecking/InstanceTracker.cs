using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.SequenceChecking
{
	// Token: 0x020000BD RID: 189
	public class InstanceTracker
	{
		// Token: 0x06000315 RID: 789 RVA: 0x00007E88 File Offset: 0x00006088
		public int InstanceNumber(object o)
		{
			int result;
			if (this._instances.TryGetValue(o, out result))
			{
				return result;
			}
			int num = this._counter + 1;
			this._counter = num;
			int num2 = num;
			this._instances.Add(o, num2);
			return num2;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00007EC7 File Offset: 0x000060C7
		public int NumberOfInstances()
		{
			return this._counter;
		}

		// Token: 0x040000E4 RID: 228
		private readonly Dictionary<object, int> _instances = new Dictionary<object, int>(new InstanceTracker.ReferenceEqualityComparer());

		// Token: 0x040000E5 RID: 229
		private int _counter;

		// Token: 0x0200013C RID: 316
		private class ReferenceEqualityComparer : IEqualityComparer<object>
		{
			// Token: 0x060004CF RID: 1231 RVA: 0x0000A3FC File Offset: 0x000085FC
			[NullableContext(2)]
			public bool Equals(object x, object y)
			{
				return x == y;
			}

			// Token: 0x060004D0 RID: 1232 RVA: 0x0000A402 File Offset: 0x00008602
			public int GetHashCode(object obj)
			{
				return RuntimeHelpers.GetHashCode(obj);
			}
		}
	}
}
