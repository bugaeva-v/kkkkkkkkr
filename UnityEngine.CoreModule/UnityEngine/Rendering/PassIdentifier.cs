using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000423 RID: 1059
	[NativeHeader("Runtime/Shaders/PassIdentifier.h")]
	[UsedByNativeCode]
	public readonly struct PassIdentifier : IEquatable<PassIdentifier>
	{
		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x0003E88C File Offset: 0x0003CA8C
		public uint SubshaderIndex
		{
			get
			{
				return this.m_SubShaderIndex;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x0003E8A4 File Offset: 0x0003CAA4
		public uint PassIndex
		{
			get
			{
				return this.m_PassIndex;
			}
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x0003E8BC File Offset: 0x0003CABC
		public override bool Equals(object o)
		{
			bool result;
			if (o is PassIdentifier)
			{
				PassIdentifier rhs = (PassIdentifier)o;
				result = this.Equals(rhs);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x0003E8E8 File Offset: 0x0003CAE8
		public bool Equals(PassIdentifier rhs)
		{
			return this.m_SubShaderIndex == rhs.m_SubShaderIndex && this.m_PassIndex == rhs.m_PassIndex;
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x0003E91C File Offset: 0x0003CB1C
		public static bool operator ==(PassIdentifier lhs, PassIdentifier rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x0003E938 File Offset: 0x0003CB38
		public static bool operator !=(PassIdentifier lhs, PassIdentifier rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x0003E954 File Offset: 0x0003CB54
		public override int GetHashCode()
		{
			return this.m_SubShaderIndex.GetHashCode() ^ this.m_PassIndex.GetHashCode();
		}

		// Token: 0x04000DAB RID: 3499
		internal readonly uint m_SubShaderIndex;

		// Token: 0x04000DAC RID: 3500
		internal readonly uint m_PassIndex;
	}
}
