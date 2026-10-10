using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000424 RID: 1060
	[UsedByNativeCode]
	public struct PlatformKeywordSet
	{
		// Token: 0x060024F1 RID: 9457 RVA: 0x0003E984 File Offset: 0x0003CB84
		private ulong ComputeKeywordMask(BuiltinShaderDefine define)
		{
			return (ulong)(1L << (int)(define % (BuiltinShaderDefine)64 & BuiltinShaderDefine.SHADER_API_GLES30));
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x0003E9A0 File Offset: 0x0003CBA0
		public bool IsEnabled(BuiltinShaderDefine define)
		{
			return (this.m_Bits & this.ComputeKeywordMask(define)) > 0UL;
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x0003E9C4 File Offset: 0x0003CBC4
		public void Enable(BuiltinShaderDefine define)
		{
			this.m_Bits |= this.ComputeKeywordMask(define);
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x0003E9DB File Offset: 0x0003CBDB
		public void Disable(BuiltinShaderDefine define)
		{
			this.m_Bits &= ~this.ComputeKeywordMask(define);
		}

		// Token: 0x04000DAD RID: 3501
		private const int k_SizeInBits = 64;

		// Token: 0x04000DAE RID: 3502
		internal ulong m_Bits;
	}
}
