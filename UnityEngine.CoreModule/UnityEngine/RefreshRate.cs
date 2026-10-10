using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000128 RID: 296
	[NativeType("Runtime/Graphics/RefreshRate.h")]
	public struct RefreshRate : IEquatable<RefreshRate>
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
		public double value
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.numerator / this.denominator;
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0000C508 File Offset: 0x0000A708
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(RefreshRate other)
		{
			return this.numerator == other.numerator && this.denominator == other.denominator;
		}

		// Token: 0x040003BA RID: 954
		[RequiredMember]
		public uint numerator;

		// Token: 0x040003BB RID: 955
		[RequiredMember]
		public uint denominator;
	}
}
