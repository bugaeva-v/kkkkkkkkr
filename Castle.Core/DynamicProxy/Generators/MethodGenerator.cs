using System;
using System.Reflection;
using Castle.DynamicProxy.Contributors;
using Castle.DynamicProxy.Generators.Emitters;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000047 RID: 71
	public abstract class MethodGenerator : IGenerator<MethodEmitter>
	{
		// Token: 0x06000233 RID: 563 RVA: 0x00008FD5 File Offset: 0x000071D5
		protected MethodGenerator(MetaMethod method, OverrideMethodDelegate overrideMethod)
		{
			this.method = method;
			this.overrideMethod = overrideMethod;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00008FEB File Offset: 0x000071EB
		protected MethodInfo MethodOnTarget
		{
			get
			{
				return this.method.MethodOnTarget;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00008FF8 File Offset: 0x000071F8
		protected MethodInfo MethodToOverride
		{
			get
			{
				return this.method.Method;
			}
		}

		// Token: 0x06000236 RID: 566
		protected abstract MethodEmitter BuildProxiedMethodBody(MethodEmitter emitter, ClassEmitter @class, ProxyGenerationOptions options, INamingScope namingScope);

		// Token: 0x06000237 RID: 567 RVA: 0x00009008 File Offset: 0x00007208
		public MethodEmitter Generate(ClassEmitter @class, ProxyGenerationOptions options, INamingScope namingScope)
		{
			MethodEmitter emitter = this.overrideMethod(this.method.Name, this.method.Attributes, this.MethodToOverride);
			MethodEmitter methodEmitter = this.BuildProxiedMethodBody(emitter, @class, options, namingScope);
			if (this.MethodToOverride.DeclaringType.GetTypeInfo().IsInterface)
			{
				@class.TypeBuilder.DefineMethodOverride(methodEmitter.MethodBuilder, this.MethodToOverride);
			}
			return methodEmitter;
		}

		// Token: 0x04000095 RID: 149
		private readonly MetaMethod method;

		// Token: 0x04000096 RID: 150
		private readonly OverrideMethodDelegate overrideMethod;
	}
}
