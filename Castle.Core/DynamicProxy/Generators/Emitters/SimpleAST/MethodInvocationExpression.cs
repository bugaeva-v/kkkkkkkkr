using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200007A RID: 122
	public class MethodInvocationExpression : Expression
	{
		// Token: 0x06000346 RID: 838 RVA: 0x0000C5C5 File Offset: 0x0000A7C5
		public MethodInvocationExpression(MethodInfo method, params Expression[] args) : this(SelfReference.Self, method, args)
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000C5D4 File Offset: 0x0000A7D4
		public MethodInvocationExpression(MethodEmitter method, params Expression[] args) : this(SelfReference.Self, method.MethodBuilder, args)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		public MethodInvocationExpression(Reference owner, MethodEmitter method, params Expression[] args) : this(owner, method.MethodBuilder, args)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000C5F8 File Offset: 0x0000A7F8
		public MethodInvocationExpression(Reference owner, MethodInfo method, params Expression[] args)
		{
			this.owner = owner;
			this.method = method;
			this.args = args;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000C615 File Offset: 0x0000A815
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0000C61D File Offset: 0x0000A81D
		public bool VirtualCall { get; set; }

		// Token: 0x0600034C RID: 844 RVA: 0x0000C628 File Offset: 0x0000A828
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			ArgumentsUtil.EmitLoadOwnerAndReference(this.owner, gen);
			Expression[] array = this.args;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Emit(member, gen);
			}
			if (this.VirtualCall)
			{
				gen.Emit(OpCodes.Callvirt, this.method);
				return;
			}
			gen.Emit(OpCodes.Call, this.method);
		}

		// Token: 0x040000EB RID: 235
		protected readonly Expression[] args;

		// Token: 0x040000EC RID: 236
		protected readonly MethodInfo method;

		// Token: 0x040000ED RID: 237
		protected readonly Reference owner;
	}
}
