using System;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000069 RID: 105
	[DebuggerDisplay("&{localReference}")]
	public class ByRefReference : TypeReference
	{
		// Token: 0x0600030D RID: 781 RVA: 0x0000BCB7 File Offset: 0x00009EB7
		public ByRefReference(LocalReference localReference) : base(localReference.Type)
		{
			this.localReference = localReference;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000BCCC File Offset: 0x00009ECC
		public override void LoadAddressOfReference(ILGenerator gen)
		{
			this.localReference.LoadAddressOfReference(gen);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000BCDA File Offset: 0x00009EDA
		public override void LoadReference(ILGenerator gen)
		{
			this.localReference.LoadAddressOfReference(gen);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		public override void StoreReference(ILGenerator gen)
		{
			throw new NotImplementedException();
		}

		// Token: 0x040000D4 RID: 212
		private readonly LocalReference localReference;
	}
}
