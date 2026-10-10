using System;
using System.Reflection;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x02000097 RID: 151
	// (Invoke) Token: 0x060003C5 RID: 965
	public delegate Expression GetTargetExpressionDelegate(ClassEmitter @class, MethodInfo method);
}
