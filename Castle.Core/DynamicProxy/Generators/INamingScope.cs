using System;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x0200003A RID: 58
	public interface INamingScope
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001C7 RID: 455
		INamingScope ParentScope { get; }

		// Token: 0x060001C8 RID: 456
		string GetUniqueName(string suggestedName);

		// Token: 0x060001C9 RID: 457
		INamingScope SafeSubScope();
	}
}
