using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using Castle.DynamicProxy.Generators.Emitters.CodeBuilders;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x02000059 RID: 89
	[DebuggerDisplay("{builder.Name}")]
	public class MethodEmitter : IMemberEmitter
	{
		// Token: 0x060002C0 RID: 704 RVA: 0x0000AD10 File Offset: 0x00008F10
		protected internal MethodEmitter(MethodBuilder builder)
		{
			this.builder = builder;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000AD1F File Offset: 0x00008F1F
		internal MethodEmitter(AbstractTypeEmitter owner, string name, MethodAttributes attributes) : this(owner.TypeBuilder.DefineMethod(name, attributes))
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000AD34 File Offset: 0x00008F34
		internal MethodEmitter(AbstractTypeEmitter owner, string name, MethodAttributes attributes, Type returnType, params Type[] argumentTypes) : this(owner, name, attributes)
		{
			this.SetParameters(argumentTypes);
			this.SetReturnType(returnType);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000AD50 File Offset: 0x00008F50
		internal MethodEmitter(AbstractTypeEmitter owner, string name, MethodAttributes attributes, MethodInfo methodToUseAsATemplate) : this(owner, name, attributes)
		{
			Dictionary<string, GenericTypeParameterBuilder> genericArgumentsMap = GenericUtil.GetGenericArgumentsMap(owner);
			Type returnType = GenericUtil.ExtractCorrectType(methodToUseAsATemplate.ReturnType, genericArgumentsMap);
			ParameterInfo[] parameters = methodToUseAsATemplate.GetParameters();
			Type[] parameters2 = GenericUtil.ExtractParametersTypes(parameters, genericArgumentsMap);
			this.genericTypeParams = GenericUtil.CopyGenericArguments(methodToUseAsATemplate, this.builder, genericArgumentsMap);
			this.SetParameters(parameters2);
			this.SetReturnType(returnType);
			this.SetSignature(returnType, methodToUseAsATemplate.ReturnParameter, parameters2, parameters);
			this.DefineParameters(parameters);
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000ADC4 File Offset: 0x00008FC4
		public ArgumentReference[] Arguments
		{
			get
			{
				return this.arguments;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000ADCC File Offset: 0x00008FCC
		public virtual MethodCodeBuilder CodeBuilder
		{
			get
			{
				if (this.codebuilder == null)
				{
					this.codebuilder = new MethodCodeBuilder(this.builder.GetILGenerator());
				}
				return this.codebuilder;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000ADF2 File Offset: 0x00008FF2
		public GenericTypeParameterBuilder[] GenericTypeParams
		{
			get
			{
				return this.genericTypeParams;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000ADFA File Offset: 0x00008FFA
		public MethodBuilder MethodBuilder
		{
			get
			{
				return this.builder;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000AE02 File Offset: 0x00009002
		public MemberInfo Member
		{
			get
			{
				return this.builder;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000AE0A File Offset: 0x0000900A
		public Type ReturnType
		{
			get
			{
				return this.builder.ReturnType;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000AE17 File Offset: 0x00009017
		private bool ImplementedByRuntime
		{
			get
			{
				return (this.builder.MethodImplementationFlags & MethodImplAttributes.CodeTypeMask) > MethodImplAttributes.IL;
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000AE29 File Offset: 0x00009029
		public void DefineCustomAttribute(CustomAttributeBuilder attribute)
		{
			this.builder.SetCustomAttribute(attribute);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000AE37 File Offset: 0x00009037
		public void SetParameters(Type[] paramTypes)
		{
			this.builder.SetParameters(paramTypes);
			this.arguments = ArgumentsUtil.ConvertToArgumentReference(paramTypes);
			ArgumentsUtil.InitializeArgumentsByPosition(this.arguments, this.MethodBuilder.IsStatic);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000AE67 File Offset: 0x00009067
		public virtual void EnsureValidCodeBlock()
		{
			if (!this.ImplementedByRuntime && this.CodeBuilder.IsEmpty)
			{
				this.CodeBuilder.AddStatement(new NopStatement());
				this.CodeBuilder.AddStatement(new ReturnStatement());
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000AEA0 File Offset: 0x000090A0
		public virtual void Generate()
		{
			if (this.ImplementedByRuntime)
			{
				return;
			}
			this.codebuilder.Generate(this, this.builder.GetILGenerator());
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000AEC4 File Offset: 0x000090C4
		private void DefineParameters(ParameterInfo[] parameters)
		{
			foreach (ParameterInfo parameterInfo in parameters)
			{
				ParameterBuilder parameterBuilder = this.builder.DefineParameter(parameterInfo.Position + 1, parameterInfo.Attributes, parameterInfo.Name);
				foreach (CustomAttributeInfo customAttributeInfo in parameterInfo.GetNonInheritableAttributes())
				{
					parameterBuilder.SetCustomAttribute(customAttributeInfo.Builder);
				}
				if ((parameterInfo.Attributes & ParameterAttributes.HasDefault) != ParameterAttributes.None)
				{
					try
					{
						this.CopyDefaultValueConstant(parameterInfo, parameterBuilder);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000AF7C File Offset: 0x0000917C
		private void CopyDefaultValueConstant(ParameterInfo from, ParameterBuilder to)
		{
			object obj;
			try
			{
				obj = from.DefaultValue;
			}
			catch (FormatException obj2) when (from.ParameterType == typeof(DateTime))
			{
				obj = null;
			}
			catch (FormatException obj3) when (from.ParameterType.GetTypeInfo().IsEnum)
			{
				obj = null;
			}
			if (obj is Missing)
			{
				return;
			}
			try
			{
				to.SetConstant(obj);
			}
			catch (ArgumentException)
			{
				Type parameterType = from.ParameterType;
				Type type = parameterType;
				if (obj == null)
				{
					if (parameterType.IsNullableType())
					{
						return;
					}
					if (parameterType.GetTypeInfo().IsValueType)
					{
						return;
					}
				}
				else if (parameterType.IsNullableType())
				{
					type = from.ParameterType.GetGenericArguments()[0];
					if (type.GetTypeInfo().IsEnum || type.IsAssignableFrom(obj.GetType()))
					{
						return;
					}
				}
				try
				{
					object constant = Convert.ChangeType(obj, type, CultureInfo.InvariantCulture);
					to.SetConstant(constant);
					return;
				}
				catch
				{
				}
				throw;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000B0A4 File Offset: 0x000092A4
		private void SetReturnType(Type returnType)
		{
			this.builder.SetReturnType(returnType);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000B0B4 File Offset: 0x000092B4
		private void SetSignature(Type returnType, ParameterInfo returnParameter, Type[] parameters, ParameterInfo[] baseMethodParameters)
		{
			Type[] requiredCustomModifiers = returnParameter.GetRequiredCustomModifiers();
			Array.Reverse(requiredCustomModifiers);
			Type[] optionalCustomModifiers = returnParameter.GetOptionalCustomModifiers();
			Array.Reverse(optionalCustomModifiers);
			int num = baseMethodParameters.Length;
			Type[][] array = new Type[num][];
			Type[][] array2 = new Type[num][];
			for (int i = 0; i < num; i++)
			{
				array[i] = baseMethodParameters[i].GetRequiredCustomModifiers();
				Array.Reverse(array[i]);
				array2[i] = baseMethodParameters[i].GetOptionalCustomModifiers();
				Array.Reverse(array2[i]);
			}
			this.builder.SetSignature(returnType, requiredCustomModifiers, optionalCustomModifiers, parameters, array, array2);
		}

		// Token: 0x040000B9 RID: 185
		private readonly MethodBuilder builder;

		// Token: 0x040000BA RID: 186
		private readonly GenericTypeParameterBuilder[] genericTypeParams;

		// Token: 0x040000BB RID: 187
		private ArgumentReference[] arguments;

		// Token: 0x040000BC RID: 188
		private MethodCodeBuilder codebuilder;
	}
}
