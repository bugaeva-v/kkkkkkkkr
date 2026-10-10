using System;

namespace Castle.Core
{
	// Token: 0x020000AE RID: 174
	public interface IServiceProviderEx : IServiceProvider
	{
		// Token: 0x06000433 RID: 1075
		T GetService<T>() where T : class;
	}
}
