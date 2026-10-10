using System;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x02000099 RID: 153
	public class DelegateTypeGenerator : IGenerator<AbstractTypeEmitter>
	{
		// Token: 0x060003CC RID: 972 RVA: 0x0000DE01 File Offset: 0x0000C001
		public DelegateTypeGenerator(MetaMethod method, Type targetType)
		{
			this.method = method;
			this.targetType = targetType;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000DE18 File Offset: 0x0000C018
		public AbstractTypeEmitter Generate(ClassEmitter @class, ProxyGenerationOptions options, INamingScope namingScope)
		{
			AbstractTypeEmitter emitter = this.GetEmitter(@class, namingScope);
			this.BuildConstructor(emitter);
			this.BuildInvokeMethod(emitter);
			return emitter;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000DE3D File Offset: 0x0000C03D
		private void BuildConstructor(AbstractTypeEmitter emitter)
		{
			emitter.CreateConstructor(new ArgumentReference[]
			{
				new ArgumentReference(typeof(object)),
				new ArgumentReference(typeof(IntPtr))
			}).ConstructorBuilder.SetImplementationFlags(MethodImplAttributes.CodeTypeMask);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000DE7C File Offset: 0x0000C07C
		private void BuildInvokeMethod(AbstractTypeEmitter @delegate)
		{
			Type[] paramTypes = this.GetParamTypes(@delegate);
			@delegate.CreateMethod("Invoke", MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, @delegate.GetClosedParameterType(this.method.MethodOnTarget.ReturnType), paramTypes).MethodBuilder.SetImplementationFlags(MethodImplAttributes.CodeTypeMask);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000DEC4 File Offset: 0x0000C0C4
		private AbstractTypeEmitter GetEmitter(ClassEmitter @class, INamingScope namingScope)
		{
			MethodInfo methodOnTarget = this.method.MethodOnTarget;
			string suggestedName = string.Format("Castle.Proxies.Delegates.{0}_{1}", methodOnTarget.DeclaringType.Name, this.method.Method.Name);
			string uniqueName = namingScope.ParentScope.GetUniqueName(suggestedName);
			ClassEmitter classEmitter = new ClassEmitter(@class.ModuleScope, uniqueName, typeof(MulticastDelegate), Type.EmptyTypes, TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.AutoClass);
			classEmitter.CopyGenericParametersFromMethod(this.method.Method);
			return classEmitter;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000DF44 File Offset: 0x0000C144
		private Type[] GetParamTypes(AbstractTypeEmitter @delegate)
		{
			ParameterInfo[] parameters = this.method.MethodOnTarget.GetParameters();
			if (@delegate.TypeBuilder.IsGenericType)
			{
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					array[i] = @delegate.GetClosedParameterType(parameters[i].ParameterType);
				}
				return array;
			}
			Type[] array2 = new Type[parameters.Length + 1];
			array2[0] = this.targetType;
			for (int j = 0; j < parameters.Length; j++)
			{
				array2[j + 1] = @delegate.GetClosedParameterType(parameters[j].ParameterType);
			}
			return array2;
		}

		// Token: 0x04000119 RID: 281
		private const TypeAttributes DelegateFlags = TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.AutoClass;

		// Token: 0x0400011A RID: 282
		private readonly MetaMethod method;

		// Token: 0x0400011B RID: 283
		private readonly Type targetType;
	}
}
