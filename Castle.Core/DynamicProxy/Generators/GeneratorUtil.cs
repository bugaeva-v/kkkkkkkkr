using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000037 RID: 55
	public static class GeneratorUtil
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00007500 File Offset: 0x00005700
		public static void CopyOutAndRefParameters(TypeReference[] dereferencedArguments, LocalReference invocation, MethodInfo method, MethodEmitter emitter)
		{
			ParameterInfo[] parameters = method.GetParameters();
			LocalReference localReference = null;
			for (int i = 0; i < parameters.Length; i++)
			{
				if (GeneratorUtil.<CopyOutAndRefParameters>g__IsByRef|0_0(parameters[i]) && !GeneratorUtil.<CopyOutAndRefParameters>g__IsReadOnly|0_1(parameters[i]))
				{
					if (localReference == null)
					{
						localReference = GeneratorUtil.StoreInvocationArgumentsInLocal(emitter, invocation);
					}
					emitter.CodeBuilder.AddStatement(GeneratorUtil.AssignArgument(dereferencedArguments, i, localReference));
				}
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00007557 File Offset: 0x00005757
		private static ConvertExpression Argument(int i, LocalReference invocationArgs, TypeReference[] arguments)
		{
			return new ConvertExpression(arguments[i].Type, new LoadRefArrayElementExpression(i, invocationArgs));
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000756D File Offset: 0x0000576D
		private static AssignStatement AssignArgument(TypeReference[] dereferencedArguments, int i, LocalReference invocationArgs)
		{
			return new AssignStatement(dereferencedArguments[i], GeneratorUtil.Argument(i, invocationArgs, dereferencedArguments));
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000757F File Offset: 0x0000577F
		private static AssignStatement GetArguments(LocalReference invocationArgs, LocalReference invocation)
		{
			return new AssignStatement(invocationArgs, new MethodInvocationExpression(invocation, InvocationMethods.GetArguments, new Expression[0]));
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00007598 File Offset: 0x00005798
		private static LocalReference StoreInvocationArgumentsInLocal(MethodEmitter emitter, LocalReference invocation)
		{
			LocalReference localReference = emitter.CodeBuilder.DeclareLocal(typeof(object[]));
			emitter.CodeBuilder.AddStatement(GeneratorUtil.GetArguments(localReference, invocation));
			return localReference;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000075CF File Offset: 0x000057CF
		[CompilerGenerated]
		internal static bool <CopyOutAndRefParameters>g__IsByRef|0_0(ParameterInfo parameter)
		{
			return parameter.ParameterType.GetTypeInfo().IsByRef;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000075E4 File Offset: 0x000057E4
		[CompilerGenerated]
		internal static bool <CopyOutAndRefParameters>g__IsReadOnly|0_1(ParameterInfo parameter)
		{
			if ((parameter.Attributes & (ParameterAttributes.In | ParameterAttributes.Out)) != ParameterAttributes.In)
			{
				return false;
			}
			if (parameter.GetRequiredCustomModifiers().Any((Type x) => x == typeof(InAttribute)))
			{
				return true;
			}
			return parameter.GetCustomAttributes(false).Any((object x) => x.GetType().FullName == "System.Runtime.CompilerServices.IsReadOnlyAttribute");
		}
	}
}
