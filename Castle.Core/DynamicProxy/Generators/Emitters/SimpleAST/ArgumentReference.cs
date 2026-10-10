using System;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000063 RID: 99
	[DebuggerDisplay("argument {Type}")]
	public class ArgumentReference : TypeReference
	{
		// Token: 0x060002FA RID: 762 RVA: 0x0000B9AC File Offset: 0x00009BAC
		public ArgumentReference(Type argumentType) : base(argumentType)
		{
			this.Position = -1;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000B9BC File Offset: 0x00009BBC
		public ArgumentReference(Type argumentType, int position) : base(argumentType)
		{
			this.Position = position;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000B9CC File Offset: 0x00009BCC
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0000B9D4 File Offset: 0x00009BD4
		internal int Position { get; set; }

		// Token: 0x060002FE RID: 766 RVA: 0x0000B9DD File Offset: 0x00009BDD
		public override void LoadAddressOfReference(ILGenerator gen)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		public override void LoadReference(ILGenerator gen)
		{
			if (this.Position == -1)
			{
				throw new ProxyGenerationException("ArgumentReference uninitialized");
			}
			switch (this.Position)
			{
			case 0:
				gen.Emit(OpCodes.Ldarg_0);
				return;
			case 1:
				gen.Emit(OpCodes.Ldarg_1);
				return;
			case 2:
				gen.Emit(OpCodes.Ldarg_2);
				return;
			case 3:
				gen.Emit(OpCodes.Ldarg_3);
				return;
			default:
				gen.Emit(OpCodes.Ldarg_S, this.Position);
				return;
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000BA65 File Offset: 0x00009C65
		public override void StoreReference(ILGenerator gen)
		{
			if (this.Position == -1)
			{
				throw new ProxyGenerationException("ArgumentReference uninitialized");
			}
			gen.Emit(OpCodes.Starg, this.Position);
		}
	}
}
