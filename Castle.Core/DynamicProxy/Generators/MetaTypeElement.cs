using System;
using System.Reflection;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000044 RID: 68
	public abstract class MetaTypeElement
	{
		// Token: 0x0600022A RID: 554 RVA: 0x00008D76 File Offset: 0x00006F76
		protected MetaTypeElement(Type sourceType)
		{
			this.sourceType = sourceType;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00008D85 File Offset: 0x00006F85
		internal bool CanBeImplementedExplicitly
		{
			get
			{
				return this.sourceType != null && this.sourceType.GetTypeInfo().IsInterface;
			}
		}

		// Token: 0x0600022C RID: 556
		internal abstract void SwitchToExplicitImplementation();

		// Token: 0x04000092 RID: 146
		protected readonly Type sourceType;
	}
}
