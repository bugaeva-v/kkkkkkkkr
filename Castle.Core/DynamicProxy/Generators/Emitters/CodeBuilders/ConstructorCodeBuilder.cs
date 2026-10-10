using System;
using System.Reflection;
using System.Reflection.Emit;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Generators.Emitters.CodeBuilders
{
	// Token: 0x0200008D RID: 141
	public class ConstructorCodeBuilder : AbstractCodeBuilder
	{
		// Token: 0x06000389 RID: 905 RVA: 0x0000CD90 File Offset: 0x0000AF90
		public ConstructorCodeBuilder(Type baseType, ILGenerator generator) : base(generator)
		{
			this.baseType = baseType;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000CDA0 File Offset: 0x0000AFA0
		public void InvokeBaseConstructor()
		{
			Type genericTypeDefinition = this.baseType;
			if (genericTypeDefinition.GetTypeInfo().ContainsGenericParameters)
			{
				genericTypeDefinition = genericTypeDefinition.GetGenericTypeDefinition();
			}
			BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
			ConstructorInfo constructor = genericTypeDefinition.GetConstructor(bindingAttr, null, new Type[0], null);
			this.InvokeBaseConstructor(constructor);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000CDE2 File Offset: 0x0000AFE2
		public void InvokeBaseConstructor(ConstructorInfo constructor)
		{
			base.AddStatement(new ConstructorInvocationStatement(constructor, new Expression[0]));
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000CDF7 File Offset: 0x0000AFF7
		public void InvokeBaseConstructor(ConstructorInfo constructor, params ArgumentReference[] arguments)
		{
			base.AddStatement(new ConstructorInvocationStatement(constructor, ArgumentsUtil.ConvertArgumentReferenceToExpression(arguments)));
		}

		// Token: 0x04000109 RID: 265
		private readonly Type baseType;
	}
}
