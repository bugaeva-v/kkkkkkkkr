using System;
using System.Reflection;
using System.Reflection.Emit;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000068 RID: 104
	public class BindDelegateExpression : Expression
	{
		// Token: 0x0600030B RID: 779 RVA: 0x0000BBE4 File Offset: 0x00009DE4
		public BindDelegateExpression(Type @delegate, Expression owner, MethodInfo methodToBindTo, GenericTypeParameterBuilder[] genericTypeParams)
		{
			this.delegateCtor = @delegate.GetConstructors()[0];
			this.methodToBindTo = methodToBindTo;
			if (@delegate.GetTypeInfo().IsGenericTypeDefinition)
			{
				Type[] typeArguments = genericTypeParams.AsTypeArray();
				Type type = @delegate.MakeGenericType(typeArguments);
				this.delegateCtor = TypeBuilder.GetConstructor(type, this.delegateCtor);
				this.methodToBindTo = methodToBindTo.MakeGenericMethod(typeArguments);
			}
			this.owner = owner;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000BC50 File Offset: 0x00009E50
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			this.owner.Emit(member, gen);
			gen.Emit(OpCodes.Dup);
			if (this.methodToBindTo.IsFinal)
			{
				gen.Emit(OpCodes.Ldftn, this.methodToBindTo);
			}
			else
			{
				gen.Emit(OpCodes.Ldvirtftn, this.methodToBindTo);
			}
			gen.Emit(OpCodes.Newobj, this.delegateCtor);
		}

		// Token: 0x040000D1 RID: 209
		private readonly ConstructorInfo delegateCtor;

		// Token: 0x040000D2 RID: 210
		private readonly MethodInfo methodToBindTo;

		// Token: 0x040000D3 RID: 211
		private readonly Expression owner;
	}
}
