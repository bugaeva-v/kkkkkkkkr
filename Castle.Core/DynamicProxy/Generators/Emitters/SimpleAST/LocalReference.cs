using System;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000079 RID: 121
	[DebuggerDisplay("local {Type}")]
	public class LocalReference : TypeReference
	{
		// Token: 0x06000341 RID: 833 RVA: 0x0000C56F File Offset: 0x0000A76F
		public LocalReference(Type type) : base(type)
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000C578 File Offset: 0x0000A778
		public override void Generate(ILGenerator gen)
		{
			this.localbuilder = gen.DeclareLocal(base.Type);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000C58C File Offset: 0x0000A78C
		public override void LoadAddressOfReference(ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldloca, this.localbuilder);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000C59F File Offset: 0x0000A79F
		public override void LoadReference(ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldloc, this.localbuilder);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000C5B2 File Offset: 0x0000A7B2
		public override void StoreReference(ILGenerator gen)
		{
			gen.Emit(OpCodes.Stloc, this.localbuilder);
		}

		// Token: 0x040000EA RID: 234
		private LocalBuilder localbuilder;
	}
}
