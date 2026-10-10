using System;
using System.Reflection;
using System.Reflection.Emit;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200007B RID: 123
	public class MethodTokenExpression : Expression
	{
		// Token: 0x0600034D RID: 845 RVA: 0x0000C68B File Offset: 0x0000A88B
		public MethodTokenExpression(MethodInfo method)
		{
			this.method = method;
			this.declaringType = method.DeclaringType;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldtoken, this.method);
			if (this.declaringType == null)
			{
				throw new GeneratorException("declaringType can't be null for this situation");
			}
			gen.Emit(OpCodes.Ldtoken, this.declaringType);
			MethodInfo getMethodFromHandle = MethodBaseMethods.GetMethodFromHandle;
			gen.Emit(OpCodes.Call, getMethodFromHandle);
			gen.Emit(OpCodes.Castclass, typeof(MethodInfo));
		}

		// Token: 0x040000EF RID: 239
		private readonly MethodInfo method;

		// Token: 0x040000F0 RID: 240
		private readonly Type declaringType;
	}
}
