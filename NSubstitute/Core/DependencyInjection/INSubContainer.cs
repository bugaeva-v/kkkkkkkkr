using System;

namespace NSubstitute.Core.DependencyInjection
{
	// Token: 0x020000C4 RID: 196
	public interface INSubContainer : INSubResolver
	{
		// Token: 0x0600033C RID: 828
		IConfigurableNSubContainer Customize();

		// Token: 0x0600033D RID: 829
		INSubResolver CreateScope();
	}
}
