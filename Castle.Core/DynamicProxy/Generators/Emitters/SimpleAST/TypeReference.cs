using System;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200008A RID: 138
	public abstract class TypeReference : Reference
	{
		// Token: 0x0600037C RID: 892 RVA: 0x0000CC1A File Offset: 0x0000AE1A
		protected TypeReference(Type argumentType) : this(null, argumentType)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000CC24 File Offset: 0x0000AE24
		protected TypeReference(Reference owner, Type type) : base(owner)
		{
			this.type = type;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000CC34 File Offset: 0x0000AE34
		public Type Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x04000103 RID: 259
		private readonly Type type;
	}
}
