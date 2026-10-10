using System;

namespace NSubstitute.Core
{
	// Token: 0x02000094 RID: 148
	public interface IPropertyHelper
	{
		// Token: 0x06000229 RID: 553
		bool IsCallToSetAReadWriteProperty(ICall call);

		// Token: 0x0600022A RID: 554
		ICall CreateCallToPropertyGetterFromSetterCall(ICall callToSetter);
	}
}
