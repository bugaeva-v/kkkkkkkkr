using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000082 RID: 130
	public abstract class Reference
	{
		// Token: 0x0600035F RID: 863 RVA: 0x0000C944 File Offset: 0x0000AB44
		protected Reference()
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000C957 File Offset: 0x0000AB57
		protected Reference(Reference owner)
		{
			this.owner = owner;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0000C971 File Offset: 0x0000AB71
		// (set) Token: 0x06000362 RID: 866 RVA: 0x0000C979 File Offset: 0x0000AB79
		public Reference OwnerReference
		{
			get
			{
				return this.owner;
			}
			set
			{
				this.owner = value;
			}
		}

		// Token: 0x06000363 RID: 867
		public abstract void LoadAddressOfReference(ILGenerator gen);

		// Token: 0x06000364 RID: 868
		public abstract void LoadReference(ILGenerator gen);

		// Token: 0x06000365 RID: 869
		public abstract void StoreReference(ILGenerator gen);

		// Token: 0x06000366 RID: 870 RVA: 0x0000C982 File Offset: 0x0000AB82
		public virtual void Generate(ILGenerator gen)
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000C984 File Offset: 0x0000AB84
		public virtual Expression ToAddressOfExpression()
		{
			return new AddressOfReferenceExpression(this);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000C98C File Offset: 0x0000AB8C
		public virtual Expression ToExpression()
		{
			return new ReferenceExpression(this);
		}

		// Token: 0x040000FB RID: 251
		protected Reference owner = SelfReference.Self;
	}
}
