using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x020000B4 RID: 180
	public class RouteAction
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00007414 File Offset: 0x00005614
		public bool HasReturnValue { get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000741C File Offset: 0x0000561C
		[Nullable(2)]
		public object ReturnValue { [NullableContext(2)] get; }

		// Token: 0x060002C3 RID: 707 RVA: 0x00007424 File Offset: 0x00005624
		public static RouteAction Continue()
		{
			return RouteAction._continue;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000742B File Offset: 0x0000562B
		public static RouteAction Return([Nullable(2)] object value)
		{
			return new RouteAction(true, value);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00007434 File Offset: 0x00005634
		[NullableContext(2)]
		private RouteAction(bool hasReturnValue, object returnValue)
		{
			this.HasReturnValue = hasReturnValue;
			this.ReturnValue = returnValue;
		}

		// Token: 0x040000B8 RID: 184
		private static readonly RouteAction _continue = new RouteAction(false, null);
	}
}
