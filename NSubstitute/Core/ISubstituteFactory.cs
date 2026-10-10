using System;

namespace NSubstitute.Core
{
	// Token: 0x020000A0 RID: 160
	public interface ISubstituteFactory
	{
		// Token: 0x0600024C RID: 588
		object Create(Type[] typesToProxy, object[] constructorArguments);

		// Token: 0x0600024D RID: 589
		object CreatePartial(Type[] typesToProxy, object[] constructorArguments);
	}
}
