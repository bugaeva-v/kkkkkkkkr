using System;
using System.Reflection;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Tokens
{
	// Token: 0x0200001F RID: 31
	public static class InvocationMethods
	{
		// Token: 0x04000039 RID: 57
		public static readonly ConstructorInfo CompositionInvocationConstructor = typeof(CompositionInvocation).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
		{
			typeof(object),
			typeof(object),
			typeof(IInterceptor[]),
			typeof(MethodInfo),
			typeof(object[])
		}, null);

		// Token: 0x0400003A RID: 58
		public static readonly MethodInfo CompositionInvocationEnsureValidTarget = typeof(CompositionInvocation).GetMethod("EnsureValidTarget", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x0400003B RID: 59
		public static readonly MethodInfo GetArgumentValue = typeof(AbstractInvocation).GetMethod("GetArgumentValue");

		// Token: 0x0400003C RID: 60
		public static readonly MethodInfo GetArguments = typeof(AbstractInvocation).GetMethod("get_Arguments");

		// Token: 0x0400003D RID: 61
		public static readonly MethodInfo GetReturnValue = typeof(AbstractInvocation).GetMethod("get_ReturnValue");

		// Token: 0x0400003E RID: 62
		public static readonly ConstructorInfo InheritanceInvocationConstructor = typeof(InheritanceInvocation).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
		{
			typeof(Type),
			typeof(object),
			typeof(IInterceptor[]),
			typeof(MethodInfo),
			typeof(object[])
		}, null);

		// Token: 0x0400003F RID: 63
		public static readonly ConstructorInfo InheritanceInvocationConstructorWithSelector = typeof(InheritanceInvocation).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
		{
			typeof(Type),
			typeof(object),
			typeof(IInterceptor[]),
			typeof(MethodInfo),
			typeof(object[]),
			typeof(IInterceptorSelector),
			typeof(IInterceptor[]).MakeByRefType()
		}, null);

		// Token: 0x04000040 RID: 64
		public static readonly MethodInfo Proceed = typeof(AbstractInvocation).GetMethod("Proceed", BindingFlags.Instance | BindingFlags.Public);

		// Token: 0x04000041 RID: 65
		public static readonly FieldInfo ProxyObject = typeof(AbstractInvocation).GetField("proxyObject", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000042 RID: 66
		public static readonly MethodInfo SetArgumentValue = typeof(AbstractInvocation).GetMethod("SetArgumentValue");

		// Token: 0x04000043 RID: 67
		public static readonly MethodInfo SetGenericMethodArguments = typeof(AbstractInvocation).GetMethod("SetGenericMethodArguments", new Type[]
		{
			typeof(Type[])
		});

		// Token: 0x04000044 RID: 68
		public static readonly MethodInfo SetReturnValue = typeof(AbstractInvocation).GetMethod("set_ReturnValue");

		// Token: 0x04000045 RID: 69
		public static readonly FieldInfo CompositionInvocationTarget = typeof(CompositionInvocation).GetField("target", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000046 RID: 70
		public static readonly MethodInfo ThrowOnNoTarget = typeof(AbstractInvocation).GetMethod("ThrowOnNoTarget", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000047 RID: 71
		public static readonly MethodInfo EnsureValidTarget = InvocationMethods.CompositionInvocationEnsureValidTarget;

		// Token: 0x04000048 RID: 72
		public static readonly FieldInfo Target = InvocationMethods.CompositionInvocationTarget;
	}
}
