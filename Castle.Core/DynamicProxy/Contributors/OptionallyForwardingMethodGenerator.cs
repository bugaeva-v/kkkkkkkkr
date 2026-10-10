using System;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000AA RID: 170
	public class OptionallyForwardingMethodGenerator : MethodGenerator
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x0000F039 File Offset: 0x0000D239
		public OptionallyForwardingMethodGenerator(MetaMethod method, OverrideMethodDelegate overrideMethod, GetTargetReferenceDelegate getTargetReference) : base(method, overrideMethod)
		{
			this.getTargetReference = getTargetReference;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000F04C File Offset: 0x0000D24C
		protected override MethodEmitter BuildProxiedMethodBody(MethodEmitter emitter, ClassEmitter @class, ProxyGenerationOptions options, INamingScope namingScope)
		{
			Reference reference = this.getTargetReference(@class, base.MethodToOverride);
			emitter.CodeBuilder.AddStatement(new ExpressionStatement(new IfNullExpression(reference, this.IfNull(emitter.ReturnType), this.IfNotNull(reference))));
			return emitter;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000F098 File Offset: 0x0000D298
		private Expression IfNotNull(Reference targetReference)
		{
			MultiStatementExpression multiStatementExpression = new MultiStatementExpression();
			ReferenceExpression[] array = ArgumentsUtil.ConvertToArgumentReferenceExpression(base.MethodToOverride.GetParameters());
			MethodInfo methodToOverride = base.MethodToOverride;
			Expression[] args = array;
			multiStatementExpression.AddStatement(new ReturnStatement(new MethodInvocationExpression(targetReference, methodToOverride, args)
			{
				VirtualCall = true
			}));
			return multiStatementExpression;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000F0DC File Offset: 0x0000D2DC
		private Expression IfNull(Type returnType)
		{
			MultiStatementExpression multiStatementExpression = new MultiStatementExpression();
			this.InitOutParameters(multiStatementExpression, base.MethodToOverride.GetParameters());
			if (returnType == typeof(void))
			{
				multiStatementExpression.AddStatement(new ReturnStatement());
			}
			else
			{
				multiStatementExpression.AddStatement(new ReturnStatement(new DefaultValueExpression(returnType)));
			}
			return multiStatementExpression;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000F134 File Offset: 0x0000D334
		private void InitOutParameters(MultiStatementExpression expression, ParameterInfo[] parameters)
		{
			for (int i = 0; i < parameters.Length; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				if (parameterInfo.IsOut)
				{
					expression.AddStatement(new AssignArgumentStatement(new ArgumentReference(parameterInfo.ParameterType, i + 1), new DefaultValueExpression(parameterInfo.ParameterType)));
				}
			}
		}

		// Token: 0x04000136 RID: 310
		private readonly GetTargetReferenceDelegate getTargetReference;
	}
}
