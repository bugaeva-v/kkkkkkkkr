using System;
using System.Reflection.Emit;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200008B RID: 139
	public class TypeTokenExpression : Expression
	{
		// Token: 0x0600037F RID: 895 RVA: 0x0000CC3C File Offset: 0x0000AE3C
		public TypeTokenExpression(Type type)
		{
			this.type = type;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000CC4B File Offset: 0x0000AE4B
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldtoken, this.type);
			gen.Emit(OpCodes.Call, TypeMethods.GetTypeFromHandle);
		}

		// Token: 0x04000104 RID: 260
		private readonly Type type;
	}
}
