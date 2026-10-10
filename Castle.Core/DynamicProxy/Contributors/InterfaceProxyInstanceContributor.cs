using System;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.CodeBuilders;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x0200009F RID: 159
	public class InterfaceProxyInstanceContributor : ProxyInstanceContributor
	{
		// Token: 0x060003DE RID: 990 RVA: 0x0000E1B9 File Offset: 0x0000C3B9
		protected override Reference GetTargetReference(ClassEmitter emitter)
		{
			return emitter.GetField("__target");
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000E1C6 File Offset: 0x0000C3C6
		public InterfaceProxyInstanceContributor(Type targetType, string proxyGeneratorId, Type[] interfaces) : base(targetType, interfaces, proxyGeneratorId)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000E1D4 File Offset: 0x0000C3D4
		protected override void CustomizeGetObjectData(AbstractCodeBuilder codebuilder, ArgumentReference serializationInfo, ArgumentReference streamingContext, ClassEmitter emitter)
		{
			FieldReference field = emitter.GetField("__target");
			codebuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(serializationInfo, SerializationInfoMethods.AddValue_Object, new Expression[]
			{
				new ConstReference("__targetFieldType").ToExpression(),
				new ConstReference(field.Reference.FieldType.AssemblyQualifiedName).ToExpression()
			})));
			codebuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(serializationInfo, SerializationInfoMethods.AddValue_Object, new Expression[]
			{
				new ConstReference("__theInterface").ToExpression(),
				new ConstReference(this.targetType.AssemblyQualifiedName).ToExpression()
			})));
		}
	}
}
