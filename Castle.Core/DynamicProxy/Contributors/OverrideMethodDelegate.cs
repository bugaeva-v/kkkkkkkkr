using System;
using System.Reflection;
using Castle.DynamicProxy.Generators.Emitters;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x02000096 RID: 150
	// (Invoke) Token: 0x060003C1 RID: 961
	public delegate MethodEmitter OverrideMethodDelegate(string name, MethodAttributes attributes, MethodInfo methodToOverride);
}
