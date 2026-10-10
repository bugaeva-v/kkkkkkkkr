using System;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.CodeBuilders;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x0200009C RID: 156
	public class ForwardingMethodGenerator : MethodGenerator
	{
		// Token: 0x060003D6 RID: 982 RVA: 0x0000E04E File Offset: 0x0000C24E
		public ForwardingMethodGenerator(MetaMethod method, OverrideMethodDelegate overrideMethod, GetTargetReferenceDelegate getTargetReference) : base(method, overrideMethod)
		{
			this.getTargetReference = getTargetReference;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000E060 File Offset: 0x0000C260
		protected override MethodEmitter BuildProxiedMethodBody(MethodEmitter emitter, ClassEmitter @class, ProxyGenerationOptions options, INamingScope namingScope)
		{
			Reference reference = this.getTargetReference(@class, base.MethodToOverride);
			ReferenceExpression[] array = ArgumentsUtil.ConvertToArgumentReferenceExpression(base.MethodToOverride.GetParameters());
			AbstractCodeBuilder codeBuilder = emitter.CodeBuilder;
			Reference owner = reference;
			MethodInfo methodToOverride = base.MethodToOverride;
			Expression[] args = array;
			codeBuilder.AddStatement(new ReturnStatement(new MethodInvocationExpression(owner, methodToOverride, args)
			{
				VirtualCall = true
			}));
			return emitter;
		}

		// Token: 0x0400011C RID: 284
		private readonly GetTargetReferenceDelegate getTargetReference;
	}
}
