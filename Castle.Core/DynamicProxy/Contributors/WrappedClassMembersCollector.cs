using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000AC RID: 172
	public class WrappedClassMembersCollector : ClassMembersCollector
	{
		// Token: 0x0600042C RID: 1068 RVA: 0x0000F6B2 File Offset: 0x0000D8B2
		public WrappedClassMembersCollector(Type type) : base(type)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000F6BB File Offset: 0x0000D8BB
		public override void CollectMembersToProxy(IProxyGenerationHook hook)
		{
			base.CollectMembersToProxy(hook);
			this.CollectFields(hook);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000F6CC File Offset: 0x0000D8CC
		protected override MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone)
		{
			if (!ProxyUtil.IsAccessibleMethod(method))
			{
				return null;
			}
			bool flag = base.AcceptMethod(method, true, hook);
			if (!flag && !method.IsAbstract)
			{
				return null;
			}
			return new MetaMethod(method, method, isStandalone, flag, true);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000F704 File Offset: 0x0000D904
		protected bool IsGeneratedByTheCompiler(FieldInfo field)
		{
			return field.IsDefined(typeof(CompilerGeneratedAttribute));
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000F716 File Offset: 0x0000D916
		protected virtual bool IsOKToBeOnProxy(FieldInfo field)
		{
			return this.IsGeneratedByTheCompiler(field);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000F720 File Offset: 0x0000D920
		private void CollectFields(IProxyGenerationHook hook)
		{
			foreach (FieldInfo fieldInfo in this.type.GetAllFields())
			{
				if (!this.IsOKToBeOnProxy(fieldInfo))
				{
					hook.NonProxyableMemberNotification(this.type, fieldInfo);
				}
			}
		}
	}
}
