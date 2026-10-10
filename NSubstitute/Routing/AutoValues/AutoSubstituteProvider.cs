using System;
using System.Linq;
using System.Reflection;
using NSubstitute.Core;

namespace NSubstitute.Routing.AutoValues
{
	// Token: 0x02000037 RID: 55
	public class AutoSubstituteProvider : IAutoValueProvider
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00003CD0 File Offset: 0x00001ED0
		public AutoSubstituteProvider(ISubstituteFactory substituteFactory)
		{
			this._substituteFactory = substituteFactory;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003CDF File Offset: 0x00001EDF
		public bool CanProvideValueFor(Type type)
		{
			return type.GetTypeInfo().IsInterface || type.IsDelegate() || this.IsPureVirtualClassWithParameterlessConstructor(type);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003CFF File Offset: 0x00001EFF
		public object GetValue(Type type)
		{
			return this._substituteFactory.Create(new Type[]
			{
				type
			}, new object[0]);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003D1C File Offset: 0x00001F1C
		private bool IsPureVirtualClassWithParameterlessConstructor(Type type)
		{
			return !(type == typeof(object)) && type.GetTypeInfo().IsClass && this.IsPureVirtualType(type) && this.HasParameterlessConstructor(type);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00003D58 File Offset: 0x00001F58
		private bool HasParameterlessConstructor(Type type)
		{
			return (from x in type.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
			where this.IsCallableFromProxy(x) && x.GetParameters().Length == 0
			select x).Any<ConstructorInfo>();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003D80 File Offset: 0x00001F80
		private bool IsPureVirtualType(Type type)
		{
			return !type.GetTypeInfo().IsSealed && type.GetMethods().Where(new Func<MethodInfo, bool>(this.NotMethodFromObject)).Where(new Func<MethodInfo, bool>(this.NotStaticMethod)).All(new Func<MethodInfo, bool>(this.IsOverridable));
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003DD5 File Offset: 0x00001FD5
		private bool IsCallableFromProxy(MethodBase constructor)
		{
			return constructor.IsPublic || constructor.IsFamily || constructor.IsFamilyOrAssembly;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003DEF File Offset: 0x00001FEF
		private bool IsOverridable(MethodInfo methodInfo)
		{
			return methodInfo.IsVirtual && !methodInfo.IsFinal;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003E04 File Offset: 0x00002004
		private bool NotMethodFromObject(MethodInfo methodInfo)
		{
			return methodInfo.DeclaringType != typeof(object);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003E1B File Offset: 0x0000201B
		private bool NotStaticMethod(MethodInfo methodInfo)
		{
			return !methodInfo.IsStatic;
		}

		// Token: 0x04000049 RID: 73
		private readonly ISubstituteFactory _substituteFactory;
	}
}
