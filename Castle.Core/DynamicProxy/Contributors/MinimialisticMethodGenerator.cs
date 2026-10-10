using System;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000A8 RID: 168
	public class MinimialisticMethodGenerator : MethodGenerator
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x0000EC9E File Offset: 0x0000CE9E
		public MinimialisticMethodGenerator(MetaMethod method, OverrideMethodDelegate overrideMethod) : base(method, overrideMethod)
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000ECA8 File Offset: 0x0000CEA8
		protected override MethodEmitter BuildProxiedMethodBody(MethodEmitter emitter, ClassEmitter @class, ProxyGenerationOptions options, INamingScope namingScope)
		{
			this.InitOutParameters(emitter, base.MethodToOverride.GetParameters());
			if (emitter.ReturnType == typeof(void))
			{
				emitter.CodeBuilder.AddStatement(new ReturnStatement());
			}
			else
			{
				emitter.CodeBuilder.AddStatement(new ReturnStatement(new DefaultValueExpression(emitter.ReturnType)));
			}
			return emitter;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000ED10 File Offset: 0x0000CF10
		private void InitOutParameters(MethodEmitter emitter, ParameterInfo[] parameters)
		{
			for (int i = 0; i < parameters.Length; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				if (parameterInfo.IsOut)
				{
					emitter.CodeBuilder.AddStatement(new AssignArgumentStatement(new ArgumentReference(parameterInfo.ParameterType, i + 1), new DefaultValueExpression(parameterInfo.ParameterType)));
				}
			}
		}
	}
}
