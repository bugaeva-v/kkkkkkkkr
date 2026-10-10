using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.Arguments
{
	// Token: 0x020000D3 RID: 211
	public class DefaultChecker : IDefaultChecker
	{
		// Token: 0x06000385 RID: 901 RVA: 0x00009120 File Offset: 0x00007320
		public DefaultChecker(IDefaultForType defaultForType)
		{
			this._defaultForType = defaultForType;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000912F File Offset: 0x0000732F
		public bool IsDefault([Nullable(2)] object value, Type forType)
		{
			return EqualityComparer<object>.Default.Equals(value, this._defaultForType.GetDefaultFor(forType));
		}

		// Token: 0x04000103 RID: 259
		private readonly IDefaultForType _defaultForType;
	}
}
