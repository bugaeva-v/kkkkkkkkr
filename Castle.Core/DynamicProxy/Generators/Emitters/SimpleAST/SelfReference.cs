using System;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000086 RID: 134
	[DebuggerDisplay("this")]
	public class SelfReference : Reference
	{
		// Token: 0x06000371 RID: 881 RVA: 0x0000CB58 File Offset: 0x0000AD58
		protected SelfReference() : base(null)
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000CB61 File Offset: 0x0000AD61
		public override void LoadAddressOfReference(ILGenerator gen)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000CB68 File Offset: 0x0000AD68
		public override void LoadReference(ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldarg_0);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000CB75 File Offset: 0x0000AD75
		public override void StoreReference(ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldarg_0);
		}

		// Token: 0x04000100 RID: 256
		public static readonly SelfReference Self = new SelfReference();
	}
}
