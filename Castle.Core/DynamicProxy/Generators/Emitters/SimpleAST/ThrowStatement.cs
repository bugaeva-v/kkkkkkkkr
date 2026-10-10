using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000088 RID: 136
	public class ThrowStatement : Statement
	{
		// Token: 0x06000378 RID: 888 RVA: 0x0000CB96 File Offset: 0x0000AD96
		public ThrowStatement(Type exceptionType, string errorMessage)
		{
			this.exceptionType = exceptionType;
			this.errorMessage = errorMessage;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000CBAC File Offset: 0x0000ADAC
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			ConstructorInfo constructor = this.exceptionType.GetConstructor(new Type[]
			{
				typeof(string)
			});
			ConstReference constReference = new ConstReference(this.errorMessage);
			new NewInstanceExpression(constructor, new Expression[]
			{
				constReference.ToExpression()
			}).Emit(member, gen);
			gen.Emit(OpCodes.Throw);
		}

		// Token: 0x04000101 RID: 257
		private readonly string errorMessage;

		// Token: 0x04000102 RID: 258
		private readonly Type exceptionType;
	}
}
