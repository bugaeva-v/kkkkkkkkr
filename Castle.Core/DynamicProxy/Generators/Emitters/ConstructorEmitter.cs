using System;
using System.Reflection;
using System.Reflection.Emit;
using Castle.DynamicProxy.Generators.Emitters.CodeBuilders;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x02000050 RID: 80
	public class ConstructorEmitter : IMemberEmitter
	{
		// Token: 0x06000291 RID: 657 RVA: 0x0000A437 File Offset: 0x00008637
		protected internal ConstructorEmitter(AbstractTypeEmitter maintype, ConstructorBuilder builder)
		{
			this.maintype = maintype;
			this.builder = builder;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000A450 File Offset: 0x00008650
		internal ConstructorEmitter(AbstractTypeEmitter maintype, params ArgumentReference[] arguments)
		{
			this.maintype = maintype;
			Type[] parameterTypes = ArgumentsUtil.InitializeAndConvert(arguments);
			this.builder = maintype.TypeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, parameterTypes);
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000A485 File Offset: 0x00008685
		public virtual ConstructorCodeBuilder CodeBuilder
		{
			get
			{
				if (this.constructorCodeBuilder == null)
				{
					this.constructorCodeBuilder = new ConstructorCodeBuilder(this.maintype.BaseType, this.builder.GetILGenerator());
				}
				return this.constructorCodeBuilder;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000A4B6 File Offset: 0x000086B6
		public ConstructorBuilder ConstructorBuilder
		{
			get
			{
				return this.builder;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000A4BE File Offset: 0x000086BE
		public MemberInfo Member
		{
			get
			{
				return this.builder;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000A4C6 File Offset: 0x000086C6
		public Type ReturnType
		{
			get
			{
				return typeof(void);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000A4D2 File Offset: 0x000086D2
		private bool ImplementedByRuntime
		{
			get
			{
				return (this.builder.MethodImplementationFlags & MethodImplAttributes.CodeTypeMask) > MethodImplAttributes.IL;
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000A4E4 File Offset: 0x000086E4
		public virtual void EnsureValidCodeBlock()
		{
			if (!this.ImplementedByRuntime && this.CodeBuilder.IsEmpty)
			{
				this.CodeBuilder.InvokeBaseConstructor();
				this.CodeBuilder.AddStatement(new ReturnStatement());
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000A517 File Offset: 0x00008717
		public virtual void Generate()
		{
			if (this.ImplementedByRuntime)
			{
				return;
			}
			this.CodeBuilder.Generate(this, this.builder.GetILGenerator());
		}

		// Token: 0x040000AD RID: 173
		private readonly ConstructorBuilder builder;

		// Token: 0x040000AE RID: 174
		private readonly AbstractTypeEmitter maintype;

		// Token: 0x040000AF RID: 175
		private ConstructorCodeBuilder constructorCodeBuilder;
	}
}
