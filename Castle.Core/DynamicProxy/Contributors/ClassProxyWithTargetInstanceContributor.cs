using System;
using System.Collections.Generic;
using System.Reflection;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x02000092 RID: 146
	internal class ClassProxyWithTargetInstanceContributor : ClassProxyInstanceContributor
	{
		// Token: 0x060003A6 RID: 934 RVA: 0x0000D64C File Offset: 0x0000B84C
		public ClassProxyWithTargetInstanceContributor(Type targetType, IList<MethodInfo> methodsToSkip, Type[] interfaces, string typeId) : base(targetType, methodsToSkip, interfaces, typeId)
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000D659 File Offset: 0x0000B859
		protected override Reference GetTargetReference(ClassEmitter emitter)
		{
			return emitter.GetField("__target");
		}
	}
}
