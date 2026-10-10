using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000084 RID: 132
	public class ReferencesToObjectArrayExpression : Expression
	{
		// Token: 0x0600036B RID: 875 RVA: 0x0000C9B1 File Offset: 0x0000ABB1
		public ReferencesToObjectArrayExpression(params TypeReference[] args)
		{
			this.args = args;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			LocalBuilder local = gen.DeclareLocal(typeof(object[]));
			gen.Emit(OpCodes.Ldc_I4, this.args.Length);
			gen.Emit(OpCodes.Newarr, typeof(object));
			gen.Emit(OpCodes.Stloc, local);
			for (int i = 0; i < this.args.Length; i++)
			{
				gen.Emit(OpCodes.Ldloc, local);
				gen.Emit(OpCodes.Ldc_I4, i);
				TypeReference typeReference = this.args[i];
				ArgumentsUtil.EmitLoadOwnerAndReference(typeReference, gen);
				if (typeReference.Type.GetTypeInfo().IsByRef)
				{
					throw new NotSupportedException();
				}
				if (typeReference.Type.GetTypeInfo().IsValueType)
				{
					gen.Emit(OpCodes.Box, typeReference.Type);
				}
				else if (typeReference.Type.GetTypeInfo().IsGenericParameter)
				{
					gen.Emit(OpCodes.Box, typeReference.Type);
				}
				gen.Emit(OpCodes.Stelem_Ref);
			}
			gen.Emit(OpCodes.Ldloc, local);
		}

		// Token: 0x040000FD RID: 253
		private readonly TypeReference[] args;
	}
}
