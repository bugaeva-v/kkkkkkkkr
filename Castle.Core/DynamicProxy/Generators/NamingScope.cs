using System;
using System.Collections.Generic;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x0200004A RID: 74
	public class NamingScope : INamingScope
	{
		// Token: 0x06000249 RID: 585 RVA: 0x00009836 File Offset: 0x00007A36
		public NamingScope()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00009849 File Offset: 0x00007A49
		private NamingScope(INamingScope parent)
		{
			this.parentScope = parent;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00009863 File Offset: 0x00007A63
		public INamingScope ParentScope
		{
			get
			{
				return this.parentScope;
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000986C File Offset: 0x00007A6C
		public string GetUniqueName(string suggestedName)
		{
			int num;
			if (!this.names.TryGetValue(suggestedName, out num))
			{
				this.names.Add(suggestedName, 0);
				return suggestedName;
			}
			num++;
			this.names[suggestedName] = num;
			return suggestedName + "_" + num.ToString();
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000098BB File Offset: 0x00007ABB
		public INamingScope SafeSubScope()
		{
			return new NamingScope(this);
		}

		// Token: 0x0400009D RID: 157
		private readonly IDictionary<string, int> names = new Dictionary<string, int>();

		// Token: 0x0400009E RID: 158
		private readonly INamingScope parentScope;
	}
}
