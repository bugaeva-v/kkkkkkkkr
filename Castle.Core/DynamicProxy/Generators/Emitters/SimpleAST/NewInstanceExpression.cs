using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200007E RID: 126
	public class NewInstanceExpression : Expression
	{
		// Token: 0x06000355 RID: 853 RVA: 0x0000C7D5 File Offset: 0x0000A9D5
		public NewInstanceExpression(ConstructorInfo constructor, params Expression[] args)
		{
			this.constructor = constructor;
			this.arguments = args;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000C7EB File Offset: 0x0000A9EB
		public NewInstanceExpression(Type target, Type[] constructor_args, params Expression[] args)
		{
			this.type = target;
			this.constructorArgs = constructor_args;
			this.arguments = args;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000C808 File Offset: 0x0000AA08
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			Expression[] array = this.arguments;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Emit(member, gen);
			}
			if (this.constructor == null)
			{
				this.constructor = this.type.GetConstructor(this.constructorArgs);
			}
			if (this.constructor == null)
			{
				throw new ProxyGenerationException("Could not find constructor matching specified arguments");
			}
			gen.Emit(OpCodes.Newobj, this.constructor);
		}

		// Token: 0x040000F4 RID: 244
		private readonly Expression[] arguments;

		// Token: 0x040000F5 RID: 245
		private readonly Type[] constructorArgs;

		// Token: 0x040000F6 RID: 246
		private readonly Type type;

		// Token: 0x040000F7 RID: 247
		private ConstructorInfo constructor;
	}
}
