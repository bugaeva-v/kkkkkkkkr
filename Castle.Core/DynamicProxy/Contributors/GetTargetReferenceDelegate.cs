using System;
using System.Reflection;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x02000098 RID: 152
	// (Invoke) Token: 0x060003C9 RID: 969
	public delegate Reference GetTargetReferenceDelegate(ClassEmitter @class, MethodInfo method);
}
