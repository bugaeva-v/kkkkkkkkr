using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000AC RID: 172
	[NullableContext(1)]
	internal interface IDependencyInjectionService
	{
		// Token: 0x06000314 RID: 788
		void AddInstance(object instance);

		// Token: 0x06000315 RID: 789
		void AddService<T>() where T : class;

		// Token: 0x06000316 RID: 790
		T GetInstance<T>() where T : class;
	}
}
