using System;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000067 RID: 103
	[DebuggerDisplay("{reference} as {type}")]
	public class AsTypeReference : Reference
	{
		// Token: 0x06000307 RID: 775 RVA: 0x0000BB54 File Offset: 0x00009D54
		public AsTypeReference(Reference reference, Type type)
		{
			if (reference == null)
			{
				throw new ArgumentNullException("reference");
			}
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.reference = reference;
			this.type = type;
			if (reference == base.OwnerReference)
			{
				base.OwnerReference = null;
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000BBA7 File Offset: 0x00009DA7
		public override void LoadAddressOfReference(ILGenerator gen)
		{
			this.reference.LoadAddressOfReference(gen);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000BBB5 File Offset: 0x00009DB5
		public override void LoadReference(ILGenerator gen)
		{
			this.reference.LoadReference(gen);
			gen.Emit(OpCodes.Isinst, this.type);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000BBD4 File Offset: 0x00009DD4
		public override void StoreReference(ILGenerator gen)
		{
			this.reference.StoreReference(gen);
		}

		// Token: 0x040000CF RID: 207
		private readonly Reference reference;

		// Token: 0x040000D0 RID: 208
		private readonly Type type;
	}
}
