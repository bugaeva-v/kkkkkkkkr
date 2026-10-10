using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x0200000C RID: 12
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	internal sealed class NotNullWhenAttribute : Attribute
	{
		// Token: 0x06000013 RID: 19 RVA: 0x0000225B File Offset: 0x0000045B
		public NotNullWhenAttribute(bool returnValue)
		{
			this.ReturnValue = returnValue;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000226A File Offset: 0x0000046A
		public bool ReturnValue { get; }
	}
}
