using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200006A RID: 106
	[DebuggerDisplay("{value}")]
	public class ConstReference : TypeReference
	{
		// Token: 0x06000311 RID: 785 RVA: 0x0000BCEF File Offset: 0x00009EEF
		public ConstReference(object value) : base(value.GetType())
		{
			if (!value.GetType().GetTypeInfo().IsPrimitive && !(value is string))
			{
				throw new ProxyGenerationException("Invalid type to ConstReference");
			}
			this.value = value;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000BD29 File Offset: 0x00009F29
		public override void Generate(ILGenerator gen)
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000BD2B File Offset: 0x00009F2B
		public override void LoadAddressOfReference(ILGenerator gen)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000BD32 File Offset: 0x00009F32
		public override void LoadReference(ILGenerator gen)
		{
			OpCodeUtil.EmitLoadOpCodeForConstantValue(gen, this.value);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000BD40 File Offset: 0x00009F40
		public override void StoreReference(ILGenerator gen)
		{
			throw new NotImplementedException("ConstReference.StoreReference");
		}

		// Token: 0x040000D5 RID: 213
		private readonly object value;
	}
}
