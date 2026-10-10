using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection.Emit
{
	/// <summary>Предоставляет методы построения сигнатур.</summary>
	// Token: 0x02000943 RID: 2371
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(_SignatureHelper))]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class SignatureHelper : _SignatureHelper
	{
		// Token: 0x06005252 RID: 21074 RVA: 0x00102846 File Offset: 0x00100A46
		internal SignatureHelper(ModuleBuilder module, SignatureHelper.SignatureHelperType type)
		{
			this.type = type;
			this.module = module;
		}

		/// <summary>Возвращает вспомогательный объект сигнатуры для поля.</summary>
		/// <param name="mod">Динамический модуль, который содержит поле, для которого запрашивается <see langword="SignatureHelper" />.</param>
		/// <returns>Объект <see langword="SignatureHelper" /> для поля.</returns>
		// Token: 0x06005253 RID: 21075 RVA: 0x0010285C File Offset: 0x00100A5C
		public static SignatureHelper GetFieldSigHelper(Module mod)
		{
			if (mod != null && !(mod is ModuleBuilder))
			{
				throw new ArgumentException("ModuleBuilder is expected");
			}
			return new SignatureHelper((ModuleBuilder)mod, SignatureHelper.SignatureHelperType.HELPER_FIELD);
		}

		/// <summary>Возвращает вспомогательный объект сигнатуры для локальной переменной.</summary>
		/// <param name="mod">Динамический модуль, который содержит локальную переменную, для которой запрашивается <see langword="SignatureHelper" />.</param>
		/// <returns>Объект <see langword="SignatureHelper" /> для локальной переменной.</returns>
		// Token: 0x06005254 RID: 21076 RVA: 0x00102886 File Offset: 0x00100A86
		public static SignatureHelper GetLocalVarSigHelper(Module mod)
		{
			if (mod != null && !(mod is ModuleBuilder))
			{
				throw new ArgumentException("ModuleBuilder is expected");
			}
			return new SignatureHelper((ModuleBuilder)mod, SignatureHelper.SignatureHelperType.HELPER_LOCAL);
		}

		/// <summary>Возвращает вспомогательный объект сигнатуры для локальной переменной.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.SignatureHelper" /> для локальной переменной.</returns>
		// Token: 0x06005255 RID: 21077 RVA: 0x001028B0 File Offset: 0x00100AB0
		public static SignatureHelper GetLocalVarSigHelper()
		{
			return new SignatureHelper(null, SignatureHelper.SignatureHelperType.HELPER_LOCAL);
		}

		/// <summary>Возвращает вспомогательный объект сигнатуры для метода, получая на вход соглашение о вызове и тип возвращаемого значения.</summary>
		/// <param name="callingConvention">Соглашение о вызовах метода.</param>
		/// <param name="returnType">Тип возвращаемого значения метода или <see langword="null" /> для типа возвращаемого значения void (процедура <see langword="Sub" /> в Visual Basic).</param>
		/// <returns>Объект <see langword="SignatureHelper" /> для метода.</returns>
		// Token: 0x06005256 RID: 21078 RVA: 0x001028B9 File Offset: 0x00100AB9
		public static SignatureHelper GetMethodSigHelper(CallingConventions callingConvention, Type returnType)
		{
			return SignatureHelper.GetMethodSigHelper(null, callingConvention, (CallingConvention)0, returnType, null);
		}

		/// <summary>Возвращает вспомогательный объект сигнатуры для метода, получая на вход соглашение о неуправляемом вызове и тип возвращаемого значения.</summary>
		/// <param name="unmanagedCallingConvention">Соглашение о неуправляемом вызове метода.</param>
		/// <param name="returnType">Тип возвращаемого значения метода или <see langword="null" /> для типа возвращаемого значения void (процедура <see langword="Sub" /> в Visual Basic).</param>
		/// <returns>Объект <see langword="SignatureHelper" /> для метода.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="unmanagedCallConv" /> является неизвестным соглашением о неуправляемом вызове.</exception>
		// Token: 0x06005257 RID: 21079 RVA: 0x001028C5 File Offset: 0x00100AC5
		public static SignatureHelper GetMethodSigHelper(CallingConvention unmanagedCallingConvention, Type returnType)
		{
			return SignatureHelper.GetMethodSigHelper(null, CallingConventions.Standard, unmanagedCallingConvention, returnType, null);
		}

		/// <summary>Возвращает вспомогательный объект подписи для метода с учетом соответствующего модуля, соглашения о вызовах и типа возвращаемого значения.</summary>
		/// <param name="mod">
		///   <see cref="T:System.Reflection.Emit.ModuleBuilder" /> — содержит метод, для которого запрашивается <see langword="SignatureHelper" />.</param>
		/// <param name="callingConvention">Соглашение о вызовах метода.</param>
		/// <param name="returnType">Тип возвращаемого значения метода или <see langword="null" /> для типа возвращаемого значения void (процедура <see langword="Sub" /> в Visual Basic).</param>
		/// <returns>Объект <see langword="SignatureHelper" /> для метода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mod" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mod" /> не является объектом <see cref="T:System.Reflection.Emit.ModuleBuilder" />.</exception>
		// Token: 0x06005258 RID: 21080 RVA: 0x001028D1 File Offset: 0x00100AD1
		public static SignatureHelper GetMethodSigHelper(Module mod, CallingConventions callingConvention, Type returnType)
		{
			return SignatureHelper.GetMethodSigHelper(mod, callingConvention, (CallingConvention)0, returnType, null);
		}

		/// <summary>Возвращает вспомогательный объект подписи для метода, получая на вход модуль метода, соглашение о неуправляемом вызове и возвращаемый тип.</summary>
		/// <param name="mod">
		///   <see cref="T:System.Reflection.Emit.ModuleBuilder" /> — содержит метод, для которого запрашивается <see langword="SignatureHelper" />.</param>
		/// <param name="unmanagedCallConv">Соглашение о неуправляемом вызове метода.</param>
		/// <param name="returnType">Тип возвращаемого значения метода или <see langword="null" /> для типа возвращаемого значения void (процедура <see langword="Sub" /> в Visual Basic).</param>
		/// <returns>Объект <see langword="SignatureHelper" /> для метода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mod" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mod" /> не является объектом <see cref="T:System.Reflection.Emit.ModuleBuilder" />.  
		/// -или- 
		///  <paramref name="unmanagedCallConv" /> является неизвестным соглашением о неуправляемом вызове.</exception>
		// Token: 0x06005259 RID: 21081 RVA: 0x001028DD File Offset: 0x00100ADD
		public static SignatureHelper GetMethodSigHelper(Module mod, CallingConvention unmanagedCallConv, Type returnType)
		{
			return SignatureHelper.GetMethodSigHelper(mod, CallingConventions.Standard, unmanagedCallConv, returnType, null);
		}

		/// <summary>Возвращает вспомогательный объект сигнатуры для метода со стандартным соглашением о вызове, имея в наличии модуль метода, тип возвращаемого значения и типы аргументов.</summary>
		/// <param name="mod">
		///   <see cref="T:System.Reflection.Emit.ModuleBuilder" /> — содержит метод, для которого запрашивается <see langword="SignatureHelper" />.</param>
		/// <param name="returnType">Тип возвращаемого значения метода или <see langword="null" /> для типа возвращаемого значения void (процедура <see langword="Sub" /> в Visual Basic).</param>
		/// <param name="parameterTypes">Типы аргументов метода или значение <see langword="null" />, если метод не содержит аргументов.</param>
		/// <returns>Объект <see langword="SignatureHelper" /> для метода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mod" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Элемент <paramref name="parameterTypes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mod" /> не является объектом <see cref="T:System.Reflection.Emit.ModuleBuilder" />.</exception>
		// Token: 0x0600525A RID: 21082 RVA: 0x001028E9 File Offset: 0x00100AE9
		public static SignatureHelper GetMethodSigHelper(Module mod, Type returnType, Type[] parameterTypes)
		{
			return SignatureHelper.GetMethodSigHelper(mod, CallingConventions.Standard, (CallingConvention)0, returnType, parameterTypes);
		}

		/// <summary>Возвращает вспомогательный объект сигнатуры для свойства, получая на вход модуль, содержащий свойство, тип свойства и аргументы свойства.</summary>
		/// <param name="mod">Модуль <see cref="T:System.Reflection.Emit.ModuleBuilder" />, содержащий свойство, для которого запрашивается <see cref="T:System.Reflection.Emit.SignatureHelper" />.</param>
		/// <param name="returnType">Тип свойства.</param>
		/// <param name="parameterTypes">Типы аргументов или значение <see langword="null" />, если в свойстве отсутствуют аргументы.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.SignatureHelper" /> для свойства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mod" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Элемент <paramref name="parameterTypes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="mod" /> не является объектом <see cref="T:System.Reflection.Emit.ModuleBuilder" />.</exception>
		// Token: 0x0600525B RID: 21083 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("Not implemented")]
		public static SignatureHelper GetPropertySigHelper(Module mod, Type returnType, Type[] parameterTypes)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает вспомогательный объект сигнатуры для свойства, получая на вход динамический модуль, содержащий свойство, тип свойства, аргументы свойства и пользовательские модификаторы для типа возвращаемого значения и аргументов.</summary>
		/// <param name="mod">Модуль <see cref="T:System.Reflection.Emit.ModuleBuilder" />, содержащий свойство, для которого запрашивается <see cref="T:System.Reflection.Emit.SignatureHelper" />.</param>
		/// <param name="returnType">Тип свойства.</param>
		/// <param name="requiredReturnTypeCustomModifiers">Массив типов представляет собой требуемые пользовательские модификаторы для возвращаемого типа, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. Если возвращаемый тип не содержит требуемых настраиваемых модификаторов, укажите <see langword="null" />.</param>
		/// <param name="optionalReturnTypeCustomModifiers">Массив типов представляет собой необязательные пользовательские модификаторы для возвращаемого типа, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. Если возвращаемый тип не содержит необязательные настраиваемые модификаторы, укажите <see langword="null" />.</param>
		/// <param name="parameterTypes">Типы аргументов свойств или <see langword="null" />, если свойство не содержит аргументов.</param>
		/// <param name="requiredParameterTypeCustomModifiers">Массив массивов типов. Каждый массив типов представляет собой требуемые пользовательские модификаторы для соответствующего свойства. Если определенный аргумент не содержит требуемые пользовательские модификаторы, вместо массива данных укажите <see langword="null" />. Если свойство не содержит аргументов или если аргументы не содержат пользовательские модификаторы, укажите значение <see langword="null" /> вместо массива массивов.</param>
		/// <param name="optionalParameterTypeCustomModifiers">Массив массивов типов. Каждый массив типов представляет собой необязательные пользовательские модификаторы для соответствующего свойства. Если определенный аргумент не содержит необязательные пользовательские модификаторы, вместо массива данных укажите <see langword="null" />. Если свойство не содержит аргументов или если аргументы не содержат необязательные пользовательские модификаторы, укажите значение <see langword="null" /> вместо массива массивов.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.SignatureHelper" /> для свойства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mod" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Элемент <paramref name="parameterTypes" /> имеет значение <see langword="null" />.  
		///
		/// -или- 
		/// Один из указанных пользовательских модификаторов имеет значение <see langword="null" />. (Однако значение <see langword="null" /> может быть указано для массива пользовательских модификаторов для любого аргумента).</exception>
		/// <exception cref="T:System.ArgumentException">Подпись уже была закончена.  
		///
		/// или - 
		/// <paramref name="mod" /> не является объектом <see cref="T:System.Reflection.Emit.ModuleBuilder" />.  
		///
		/// или - 
		/// Один из указанных пользовательских модификаторов имеет тип массива.  
		///
		///
		/// -или- 
		/// Один из указанных пользовательских модификаторов является открытым универсальным типом. То есть значение свойства <see cref="P:System.Type.ContainsGenericParameters" /> для пользовательского модификатора равно <see langword="true" />.  
		/// -или- 
		/// Размер <paramref name="requiredParameterTypeCustomModifiers" /> или <paramref name="optionalParameterTypeCustomModifiers" /> не равен размеру <paramref name="parameterTypes" />.</exception>
		// Token: 0x0600525C RID: 21084 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("Not implemented")]
		public static SignatureHelper GetPropertySigHelper(Module mod, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает вспомогательный объект подписи для свойства, получая на вход динамический модуль, содержащий свойство, соглашение о вызове, тип свойства, аргументы свойства и пользовательские модификаторы для типа возвращаемого значения и аргументов.</summary>
		/// <param name="mod">Модуль <see cref="T:System.Reflection.Emit.ModuleBuilder" />, содержащий свойство, для которого запрашивается <see cref="T:System.Reflection.Emit.SignatureHelper" />.</param>
		/// <param name="callingConvention">Соглашение о вызовах методов доступа свойства.</param>
		/// <param name="returnType">Тип свойства.</param>
		/// <param name="requiredReturnTypeCustomModifiers">Массив типов представляет собой требуемые пользовательские модификаторы для возвращаемого типа, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. Если возвращаемый тип не содержит требуемых настраиваемых модификаторов, укажите <see langword="null" />.</param>
		/// <param name="optionalReturnTypeCustomModifiers">Массив типов представляет собой необязательные пользовательские модификаторы для возвращаемого типа, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. Если возвращаемый тип не содержит необязательные настраиваемые модификаторы, укажите <see langword="null" />.</param>
		/// <param name="parameterTypes">Типы аргументов свойств или <see langword="null" />, если свойство не содержит аргументов.</param>
		/// <param name="requiredParameterTypeCustomModifiers">Массив массивов типов. Каждый массив типов представляет собой требуемые пользовательские модификаторы для соответствующего свойства. Если определенный аргумент не содержит требуемые пользовательские модификаторы, вместо массива данных укажите <see langword="null" />. Если свойство не содержит аргументов или если аргументы не содержат пользовательские модификаторы, укажите значение <see langword="null" /> вместо массива массивов.</param>
		/// <param name="optionalParameterTypeCustomModifiers">Массив массивов типов. Каждый массив типов представляет собой необязательные пользовательские модификаторы для соответствующего свойства. Если определенный аргумент не содержит необязательные пользовательские модификаторы, вместо массива данных укажите <see langword="null" />. Если свойство не содержит аргументов или если аргументы не содержат необязательные пользовательские модификаторы, укажите значение <see langword="null" /> вместо массива массивов.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.SignatureHelper" /> для свойства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mod" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Элемент <paramref name="parameterTypes" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Один из указанных пользовательских модификаторов имеет значение <see langword="null" />. (Однако значение <see langword="null" /> может быть указано для массива пользовательских модификаторов для любого аргумента).</exception>
		/// <exception cref="T:System.ArgumentException">Подпись уже была закончена.  
		///
		/// или - 
		/// <paramref name="mod" /> не является объектом <see cref="T:System.Reflection.Emit.ModuleBuilder" />.  
		///
		/// -или- 
		/// Один из указанных пользовательских модификаторов имеет тип массива.  
		///
		/// или - 
		/// Один из указанных пользовательских модификаторов является открытым универсальным типом. То есть значение свойства <see cref="P:System.Type.ContainsGenericParameters" /> для пользовательского модификатора равно <see langword="true" />.  
		///
		/// или - 
		/// Размер <paramref name="requiredParameterTypeCustomModifiers" /> или <paramref name="optionalParameterTypeCustomModifiers" /> не равен размеру <paramref name="parameterTypes" />.</exception>
		// Token: 0x0600525D RID: 21085 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("Not implemented")]
		public static SignatureHelper GetPropertySigHelper(Module mod, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x001028F8 File Offset: 0x00100AF8
		private static int AppendArray(ref Type[] array, Type t)
		{
			if (array != null)
			{
				Type[] array2 = new Type[array.Length + 1];
				Array.Copy(array, array2, array.Length);
				array2[array.Length] = t;
				array = array2;
				return array.Length - 1;
			}
			array = new Type[1];
			array[0] = t;
			return 0;
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x00102940 File Offset: 0x00100B40
		private static void AppendArrayAt(ref Type[][] array, Type[] t, int pos)
		{
			int num = Math.Max(pos, (array == null) ? 0 : array.Length);
			Type[][] array2 = new Type[num + 1][];
			if (array != null)
			{
				Array.Copy(array, array2, num);
			}
			array2[pos] = t;
			array = array2;
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x0010297C File Offset: 0x00100B7C
		private static void ValidateParameterModifiers(string name, Type[] parameter_modifiers)
		{
			foreach (Type type in parameter_modifiers)
			{
				if (type == null)
				{
					throw new ArgumentNullException(name);
				}
				if (type.IsArray)
				{
					throw new ArgumentException(Locale.GetText("Array type not permitted"), name);
				}
				if (type.ContainsGenericParameters)
				{
					throw new ArgumentException(Locale.GetText("Open Generic Type not permitted"), name);
				}
			}
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x001029E0 File Offset: 0x00100BE0
		private static void ValidateCustomModifier(int n, Type[][] custom_modifiers, string name)
		{
			if (custom_modifiers == null)
			{
				return;
			}
			if (custom_modifiers.Length != n)
			{
				throw new ArgumentException(Locale.GetText(string.Format("Custom modifiers length `{0}' does not match the size of the arguments", Array.Empty<object>())));
			}
			foreach (Type[] array in custom_modifiers)
			{
				if (array != null)
				{
					SignatureHelper.ValidateParameterModifiers(name, array);
				}
			}
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x00102A2F File Offset: 0x00100C2F
		private static Exception MissingFeature()
		{
			throw new NotImplementedException("Mono does not currently support setting modOpt/modReq through SignatureHelper");
		}

		/// <summary>Добавляет набор аргументов к сигнатуре с указанными пользовательскими модификаторами.</summary>
		/// <param name="arguments">Типы добавляемых аргументов.</param>
		/// <param name="requiredCustomModifiers">Массив массивов типов. Каждый массив типов представляет собой требуемые пользовательские модификаторы для соответствующего аргумента, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. Если определенный аргумент не содержит требуемые пользовательские модификаторы, вместо массива данных укажите <see langword="null" />. Если ни один из аргументов не содержит требуемые пользовательские модификаторы, вместо массива массивов укажите <see langword="null" />.</param>
		/// <param name="optionalCustomModifiers">Массив массивов типов. Каждый массив типов представляет собой необязательные пользовательские модификаторы для соответствующего аргумента, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. Если определенный аргумент не содержит необязательные пользовательские модификаторы, вместо массива данных укажите <see langword="null" />. Если ни один из аргументов не содержит необязательные пользовательские модификаторы, вместо массива массивов укажите <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Элемент <paramref name="arguments" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Один из указанных пользовательских модификаторов имеет значение <see langword="null" />. (Однако значение <see langword="null" /> может быть указано для массива пользовательских модификаторов для любого аргумента).</exception>
		/// <exception cref="T:System.ArgumentException">Подпись уже была закончена.  
		/// -или- 
		/// Один из указанных пользовательских модификаторов имеет тип массива.  
		/// -или- 
		/// Один из указанных пользовательских модификаторов является открытым универсальным типом. То есть значение свойства <see cref="P:System.Type.ContainsGenericParameters" /> для пользовательского модификатора равно <see langword="true" />.  
		/// -или- 
		/// Размер <paramref name="requiredCustomModifiers" /> или <paramref name="optionalCustomModifiers" /> не равен размеру <paramref name="arguments" />.</exception>
		// Token: 0x06005263 RID: 21091 RVA: 0x00102A3C File Offset: 0x00100C3C
		[MonoTODO("Currently we ignore requiredCustomModifiers and optionalCustomModifiers")]
		public void AddArguments(Type[] arguments, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers)
		{
			if (arguments == null)
			{
				throw new ArgumentNullException("arguments");
			}
			if (requiredCustomModifiers != null || optionalCustomModifiers != null)
			{
				throw SignatureHelper.MissingFeature();
			}
			SignatureHelper.ValidateCustomModifier(arguments.Length, requiredCustomModifiers, "requiredCustomModifiers");
			SignatureHelper.ValidateCustomModifier(arguments.Length, optionalCustomModifiers, "optionalCustomModifiers");
			for (int i = 0; i < arguments.Length; i++)
			{
				this.AddArgument(arguments[i], (requiredCustomModifiers != null) ? requiredCustomModifiers[i] : null, (optionalCustomModifiers != null) ? optionalCustomModifiers[i] : null);
			}
		}

		/// <summary>Добавляет аргумент указанного типа к сигнатуре, определяя, должен ли этот аргумент быть закреплен.</summary>
		/// <param name="argument">Тип аргумента.</param>
		/// <param name="pinned">Значение <see langword="true" />, если аргумент закреплен; в противном случае — <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="argument" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005264 RID: 21092 RVA: 0x00102AA8 File Offset: 0x00100CA8
		[MonoTODO("pinned is ignored")]
		public void AddArgument(Type argument, bool pinned)
		{
			this.AddArgument(argument);
		}

		/// <summary>Добавляет аргумент к сигнатуре с указанными пользовательскими модификаторами.</summary>
		/// <param name="argument">Тип аргумента.</param>
		/// <param name="requiredCustomModifiers">Массив типов представляет собой требуемые пользовательские модификаторы для аргумента, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. Если аргумент не имеет требуемых пользовательских модификаторов, укажите значение <see langword="null" />.</param>
		/// <param name="optionalCustomModifiers">Массив типов представляет собой необязательные пользовательские модификаторы для аргумента, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsBoxed" />. Если аргумент не имеет необязательных пользовательских модификаторов, укажите значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="argument" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Элемент <paramref name="requiredCustomModifiers" /> равен <paramref name="optionalCustomModifiers" /> или <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Подпись уже была закончена.  
		/// -или- 
		/// Один из указанных пользовательских модификаторов имеет тип массива.  
		///
		/// или - 
		/// Один из указанных пользовательских модификаторов является открытым универсальным типом. То есть значение свойства <see cref="P:System.Type.ContainsGenericParameters" /> для пользовательского модификатора равно <see langword="true" />.</exception>
		// Token: 0x06005265 RID: 21093 RVA: 0x00102AB4 File Offset: 0x00100CB4
		public void AddArgument(Type argument, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers)
		{
			if (argument == null)
			{
				throw new ArgumentNullException("argument");
			}
			if (requiredCustomModifiers != null)
			{
				SignatureHelper.ValidateParameterModifiers("requiredCustomModifiers", requiredCustomModifiers);
			}
			if (optionalCustomModifiers != null)
			{
				SignatureHelper.ValidateParameterModifiers("optionalCustomModifiers", optionalCustomModifiers);
			}
			int pos = SignatureHelper.AppendArray(ref this.arguments, argument);
			if (requiredCustomModifiers != null)
			{
				SignatureHelper.AppendArrayAt(ref this.modreqs, requiredCustomModifiers, pos);
			}
			if (optionalCustomModifiers != null)
			{
				SignatureHelper.AppendArrayAt(ref this.modopts, optionalCustomModifiers, pos);
			}
		}

		/// <summary>Добавляет аргумент к сигнатуре.</summary>
		/// <param name="clsArgument">Тип аргумента.</param>
		/// <exception cref="T:System.ArgumentException">Подпись уже была закончена.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="clsArgument" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005266 RID: 21094 RVA: 0x00102B1E File Offset: 0x00100D1E
		public void AddArgument(Type clsArgument)
		{
			if (clsArgument == null)
			{
				throw new ArgumentNullException("clsArgument");
			}
			SignatureHelper.AppendArray(ref this.arguments, clsArgument);
		}

		/// <summary>Помечает конец фиксированной части функции с переменным количеством аргументов. Используется только в том случае, если вызывающий оператор создает место вызова сигнатуры функции с переменным количеством аргументов.</summary>
		// Token: 0x06005267 RID: 21095 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("Not implemented")]
		public void AddSentinel()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x00102B44 File Offset: 0x00100D44
		private static bool CompareOK(Type[][] one, Type[][] two)
		{
			if (one == null)
			{
				return two == null;
			}
			if (two == null)
			{
				return false;
			}
			if (one.Length != two.Length)
			{
				return false;
			}
			int i = 0;
			while (i < one.Length)
			{
				Type[] array = one[i];
				Type[] array2 = two[i];
				if (array == null)
				{
					if (array2 != null)
					{
						goto IL_32;
					}
				}
				else
				{
					if (array2 == null)
					{
						return false;
					}
					goto IL_32;
				}
				IL_83:
				i++;
				continue;
				IL_32:
				if (array.Length != array2.Length)
				{
					return false;
				}
				for (int j = 0; j < array.Length; j++)
				{
					Type type = array[j];
					Type type2 = array2[j];
					if (type == null)
					{
						if (!(type2 == null))
						{
							return false;
						}
					}
					else
					{
						if (type2 == null)
						{
							return false;
						}
						if (!type.Equals(type2))
						{
							return false;
						}
					}
				}
				goto IL_83;
			}
			return true;
		}

		/// <summary>Проверяет, равен ли этот экземпляр данному объекту.</summary>
		/// <param name="obj">Объект, с которым нужно сравнить данный экземпляр.</param>
		/// <returns>Значение <see langword="true" />, если данный объект является объектом <see langword="SignatureHelper" /> и предоставляет ту же самую сигнатуру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005269 RID: 21097 RVA: 0x00102BE0 File Offset: 0x00100DE0
		public override bool Equals(object obj)
		{
			SignatureHelper signatureHelper = obj as SignatureHelper;
			if (signatureHelper == null)
			{
				return false;
			}
			if (signatureHelper.module != this.module || signatureHelper.returnType != this.returnType || signatureHelper.callConv != this.callConv || signatureHelper.unmanagedCallConv != this.unmanagedCallConv)
			{
				return false;
			}
			if (this.arguments != null)
			{
				if (signatureHelper.arguments == null)
				{
					return false;
				}
				if (this.arguments.Length != signatureHelper.arguments.Length)
				{
					return false;
				}
				for (int i = 0; i < this.arguments.Length; i++)
				{
					if (!signatureHelper.arguments[i].Equals(this.arguments[i]))
					{
						return false;
					}
				}
			}
			else if (signatureHelper.arguments != null)
			{
				return false;
			}
			return SignatureHelper.CompareOK(signatureHelper.modreqs, this.modreqs) && SignatureHelper.CompareOK(signatureHelper.modopts, this.modopts);
		}

		/// <summary>Создает и возвращает хэш-код для этого экземпляра.</summary>
		/// <returns>Хэш-код на основе имени.</returns>
		// Token: 0x0600526A RID: 21098 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600526B RID: 21099
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern byte[] get_signature_local();

		// Token: 0x0600526C RID: 21100
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern byte[] get_signature_field();

		/// <summary>Добавляет к сигнатуре конечный токен и помечает сигнатуру как законченную, поэтому больше никакие токены не могут быть добавлены.</summary>
		/// <returns>Массив байтов, содержащий сигнатуру целиком.</returns>
		// Token: 0x0600526D RID: 21101 RVA: 0x00102CC4 File Offset: 0x00100EC4
		public byte[] GetSignature()
		{
			TypeBuilder.ResolveUserTypes(this.arguments);
			SignatureHelper.SignatureHelperType signatureHelperType = this.type;
			if (signatureHelperType == SignatureHelper.SignatureHelperType.HELPER_FIELD)
			{
				return this.get_signature_field();
			}
			if (signatureHelperType == SignatureHelper.SignatureHelperType.HELPER_LOCAL)
			{
				return this.get_signature_local();
			}
			throw new NotImplementedException();
		}

		/// <summary>Возвращает строку, представляющую аргументы сигнатуры.</summary>
		/// <returns>Строка, представляющая аргументы этой сигнатуры.</returns>
		// Token: 0x0600526E RID: 21102 RVA: 0x00102CFD File Offset: 0x00100EFD
		public override string ToString()
		{
			return "SignatureHelper";
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x00102D04 File Offset: 0x00100F04
		internal static SignatureHelper GetMethodSigHelper(Module mod, CallingConventions callingConvention, CallingConvention unmanagedCallingConvention, Type returnType, Type[] parameters)
		{
			if (mod != null && !(mod is ModuleBuilder))
			{
				throw new ArgumentException("ModuleBuilder is expected");
			}
			if (returnType == null)
			{
				returnType = typeof(void);
			}
			if (returnType.IsUserType)
			{
				throw new NotSupportedException("User defined subclasses of System.Type are not yet supported.");
			}
			if (parameters != null)
			{
				for (int i = 0; i < parameters.Length; i++)
				{
					if (parameters[i].IsUserType)
					{
						throw new NotSupportedException("User defined subclasses of System.Type are not yet supported.");
					}
				}
			}
			SignatureHelper signatureHelper = new SignatureHelper((ModuleBuilder)mod, SignatureHelper.SignatureHelperType.HELPER_METHOD);
			signatureHelper.returnType = returnType;
			signatureHelper.callConv = callingConvention;
			signatureHelper.unmanagedCallConv = unmanagedCallingConvention;
			if (parameters != null)
			{
				signatureHelper.arguments = new Type[parameters.Length];
				for (int j = 0; j < parameters.Length; j++)
				{
					signatureHelper.arguments[j] = parameters[j];
				}
			}
			return signatureHelper;
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06005270 RID: 21104 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _SignatureHelper.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06005271 RID: 21105 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _SignatureHelper.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06005272 RID: 21106 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _SignatureHelper.GetTypeInfoCount(out uint pcTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06005273 RID: 21107 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _SignatureHelper.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x000173AD File Offset: 0x000155AD
		internal SignatureHelper()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400330B RID: 13067
		private ModuleBuilder module;

		// Token: 0x0400330C RID: 13068
		private Type[] arguments;

		// Token: 0x0400330D RID: 13069
		private SignatureHelper.SignatureHelperType type;

		// Token: 0x0400330E RID: 13070
		private Type returnType;

		// Token: 0x0400330F RID: 13071
		private CallingConventions callConv;

		// Token: 0x04003310 RID: 13072
		private CallingConvention unmanagedCallConv;

		// Token: 0x04003311 RID: 13073
		private Type[][] modreqs;

		// Token: 0x04003312 RID: 13074
		private Type[][] modopts;

		// Token: 0x02000944 RID: 2372
		internal enum SignatureHelperType
		{
			// Token: 0x04003314 RID: 13076
			HELPER_FIELD,
			// Token: 0x04003315 RID: 13077
			HELPER_LOCAL,
			// Token: 0x04003316 RID: 13078
			HELPER_METHOD,
			// Token: 0x04003317 RID: 13079
			HELPER_PROPERTY
		}
	}
}
