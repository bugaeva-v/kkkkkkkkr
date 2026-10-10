using System;
using System.Configuration.Assemblies;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;
using System.Security;
using System.Security.Policy;
using System.Threading;
using Unity;

namespace System
{
	/// <summary>Содержит методы, позволяющие локально или удаленно создавать типы объектов или получать ссылки на существующие удаленные объекты. Этот класс не наследуется.</summary>
	// Token: 0x020001EA RID: 490
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(_Activator))]
	public sealed class Activator : _Activator
	{
		// Token: 0x060014E5 RID: 5349 RVA: 0x0000259F File Offset: 0x0000079F
		private Activator()
		{
		}

		/// <summary>Создает экземпляр указанного типа, используя конструктор, соответствующий заданным параметрам.</summary>
		/// <param name="type">Тип создаваемого объекта.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="type" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который использует параметры <paramref name="bindingAttr" /> и <paramref name="args" /> для поиска и идентификации конструктора <paramref name="type" />. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="args">Массив аргументов, число, порядок и тип которых соответствуют параметрам вызываемого конструктора. Если параметр <paramref name="args" /> предоставляет пустой массив или имеет значение <see langword="null" />, то вызывается конструктор, который не принимает никаких параметров (конструктор, вызываемый по умолчанию).</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="type" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <returns>Ссылка на вновь созданный объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является объектом <see langword="RuntimeType" />.  
		/// -или- 
		///  Тип <paramref name="type" /> является открытым универсальным типом (то есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> возвращает <see langword="true" />).</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="type" /> не может иметь значение <see cref="T:System.Reflection.Emit.TypeBuilder" />.  
		///
		/// или - 
		/// Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.  
		///
		/// или - 
		/// Сборка, содержащая <paramref name="type" />, является динамической сборкой, которая была создана с использованием <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Save" />.  
		///
		/// или - 
		/// Конструктор, который наилучшим образом соответствует <paramref name="args" />, имеет аргументы <see langword="varargs" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызываемый конструктор создает исключение.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">
		///   <paramref name="type" /> — это объект модели COM, но идентификатор класса, используемый для получения типа, является недопустимым, или идентифицируемый класс не зарегистрирован.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="type" /> не является допустимым типом.</exception>
		// Token: 0x060014E6 RID: 5350 RVA: 0x000523EB File Offset: 0x000505EB
		public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture)
		{
			return Activator.CreateInstance(type, bindingAttr, binder, args, culture, null);
		}

		/// <summary>Создает экземпляр указанного типа, используя конструктор, соответствующий заданным параметрам.</summary>
		/// <param name="type">Тип создаваемого объекта.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="type" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который использует параметры <paramref name="bindingAttr" /> и <paramref name="args" /> для поиска и идентификации конструктора <paramref name="type" />. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="args">Массив аргументов, число, порядок и тип которых соответствуют параметрам вызываемого конструктора. Если параметр <paramref name="args" /> предоставляет пустой массив или имеет значение <see langword="null" />, то вызывается конструктор, который не принимает никаких параметров (конструктор, вызываемый по умолчанию).</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="type" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.  
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Ссылка на вновь созданный объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является объектом <see langword="RuntimeType" />.  
		/// -или- 
		///  Тип <paramref name="type" /> является открытым универсальным типом (то есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> возвращает <see langword="true" />).</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="type" /> не может иметь значение <see cref="T:System.Reflection.Emit.TypeBuilder" />.  
		///
		/// или - 
		/// Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.  
		///
		/// или - 
		/// <paramref name="activationAttributes" /> не является пустым массивом, а создаваемый тип не является производным от <see cref="T:System.MarshalByRefObject" />.  
		///
		/// или - 
		/// Сборка, содержащая <paramref name="type" />, является динамической сборкой, которая была создана с использованием <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Save" />.  
		///
		/// или - 
		/// Конструктор, который наилучшим образом соответствует <paramref name="args" />, имеет аргументы <see langword="varargs" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызываемый конструктор создает исключение.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">
		///   <paramref name="type" /> — это объект модели COM, но идентификатор класса, используемый для получения типа, является недопустимым, или идентифицируемый класс не зарегистрирован.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="type" /> не является допустимым типом.</exception>
		// Token: 0x060014E7 RID: 5351 RVA: 0x000523FC File Offset: 0x000505FC
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (RuntimeFeature.IsDynamicCodeSupported && type is TypeBuilder)
			{
				throw new NotSupportedException(Environment.GetResourceString("CreateInstance cannot be used with an object of type TypeBuilder."));
			}
			if ((bindingAttr & (BindingFlags)255) == BindingFlags.Default)
			{
				bindingAttr |= (BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance);
			}
			if (activationAttributes != null && activationAttributes.Length != 0)
			{
				if (!type.IsMarshalByRef)
				{
					throw new NotSupportedException(Environment.GetResourceString("Activation Attributes are not supported for types not deriving from MarshalByRefObject."));
				}
				if (!type.IsContextful && (activationAttributes.Length > 1 || !(activationAttributes[0] is UrlAttribute)))
				{
					throw new NotSupportedException(Environment.GetResourceString("UrlAttribute is the only attribute supported for MarshalByRefObject."));
				}
			}
			RuntimeType runtimeType = type.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "type");
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return runtimeType.CreateInstanceImpl(bindingAttr, binder, args, culture, activationAttributes, ref stackCrawlMark);
		}

		/// <summary>Создает экземпляр указанного типа, используя конструктор, соответствующий заданным параметрам.</summary>
		/// <param name="type">Тип создаваемого объекта.</param>
		/// <param name="args">Массив аргументов, число, порядок и тип которых соответствуют параметрам вызываемого конструктора. Если параметр <paramref name="args" /> предоставляет пустой массив или имеет значение <see langword="null" />, то вызывается конструктор, который не принимает никаких параметров (конструктор, вызываемый по умолчанию).</param>
		/// <returns>Ссылка на вновь созданный объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является объектом <see langword="RuntimeType" />.  
		/// -или- 
		///  Тип <paramref name="type" /> является открытым универсальным типом (то есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> возвращает <see langword="true" />).</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="type" /> не может иметь значение <see cref="T:System.Reflection.Emit.TypeBuilder" />.  
		///
		/// или - 
		/// Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.  
		///
		/// или - 
		/// Сборка, содержащая <paramref name="type" />, является динамической сборкой, которая была создана с использованием <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Save" />.  
		///
		/// или - 
		/// Конструктор, который наилучшим образом соответствует <paramref name="args" />, имеет аргументы <see langword="varargs" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызываемый конструктор создает исключение.</exception>
		/// <exception cref="T:System.MethodAccessException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MemberAccessException" />.  
		///
		///
		///
		///
		///  Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MissingMemberException" />.  
		///
		///
		///
		///
		///  Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">
		///   <paramref name="type" /> — это COM-объект, но идентификатор класса, используемый для получения типа, является недопустимым, или идентифицируемый класс не зарегистрирован.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="type" /> не является допустимым типом.</exception>
		// Token: 0x060014E8 RID: 5352 RVA: 0x000524CC File Offset: 0x000506CC
		public static object CreateInstance(Type type, params object[] args)
		{
			return Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, args, null, null);
		}

		/// <summary>Создает экземпляр указанного типа, используя конструктор, соответствующий заданным параметрам.</summary>
		/// <param name="type">Тип создаваемого объекта.</param>
		/// <param name="args">Массив аргументов, число, порядок и тип которых соответствуют параметрам вызываемого конструктора. Если параметр <paramref name="args" /> предоставляет пустой массив или имеет значение <see langword="null" />, то вызывается конструктор, который не принимает никаких параметров (конструктор, вызываемый по умолчанию).</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.  
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Ссылка на вновь созданный объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является объектом <see langword="RuntimeType" />.  
		/// -или- 
		///  Тип <paramref name="type" /> является открытым универсальным типом (то есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> возвращает <see langword="true" />).</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="type" /> не может иметь значение <see cref="T:System.Reflection.Emit.TypeBuilder" />.  
		///
		/// или - 
		/// Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.  
		///
		/// или - 
		/// <paramref name="activationAttributes" /> не является пустым массивом, а создаваемый тип не является производным от <see cref="T:System.MarshalByRefObject" />.  
		///
		/// или - 
		/// Сборка, содержащая <paramref name="type" />, является динамической сборкой, которая была создана с использованием <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Save" />.  
		///
		/// или - 
		/// Конструктор, который наилучшим образом соответствует <paramref name="args" />, имеет аргументы <see langword="varargs" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызываемый конструктор создает исключение.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">
		///   <paramref name="type" /> — это COM-объект, но идентификатор класса, используемый для получения типа, является недопустимым, или идентифицируемый класс не зарегистрирован.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="type" /> не является допустимым типом.</exception>
		// Token: 0x060014E9 RID: 5353 RVA: 0x000524DD File Offset: 0x000506DD
		public static object CreateInstance(Type type, object[] args, object[] activationAttributes)
		{
			return Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, args, null, activationAttributes);
		}

		/// <summary>Создает экземпляр указанного типа, используя конструктор, заданный для этого типа по умолчанию.</summary>
		/// <param name="type">Тип создаваемого объекта.</param>
		/// <returns>Ссылка на вновь созданный объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является объектом <see langword="RuntimeType" />.  
		/// -или- 
		///  Тип <paramref name="type" /> является открытым универсальным типом (то есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> возвращает <see langword="true" />).</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="type" /> не может иметь значение <see cref="T:System.Reflection.Emit.TypeBuilder" />.  
		///
		/// или - 
		/// Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.  
		///
		/// или - 
		/// Сборка, содержащая <paramref name="type" />, является динамической сборкой, которая была создана с использованием <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Save" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызываемый конструктор создает исключение.</exception>
		/// <exception cref="T:System.MethodAccessException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MemberAccessException" />.  
		///
		///
		///
		///
		///  Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MissingMemberException" />.  
		///
		///
		///
		///
		///  Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">
		///   <paramref name="type" /> — это COM-объект, но идентификатор класса, используемый для получения типа, является недопустимым, или идентифицируемый класс не зарегистрирован.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="type" /> не является допустимым типом.</exception>
		// Token: 0x060014EA RID: 5354 RVA: 0x000524EE File Offset: 0x000506EE
		public static object CreateInstance(Type type)
		{
			return Activator.CreateInstance(type, false);
		}

		/// <summary>Создает экземпляр типа с заданным именем, используя для этого именованную сборку и конструктор по умолчанию.</summary>
		/// <param name="assemblyName">Имя сборки, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />. Если параметр <paramref name="assemblyName" /> имеет значение <see langword="null" />, поиск осуществляется в выполняющейся сборке.</param>
		/// <param name="typeName">Полное имя предпочтительного типа.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот член был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.  
		///
		/// или - 
		/// Недопустимые имя сборки или кодовая база.</exception>
		// Token: 0x060014EB RID: 5355 RVA: 0x000524F8 File Offset: 0x000506F8
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ObjectHandle CreateInstance(string assemblyName, string typeName)
		{
			if (assemblyName == null)
			{
				assemblyName = Assembly.GetCallingAssembly().GetName().Name;
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Activator.CreateInstance(assemblyName, typeName, false, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, null, null, null, null, ref stackCrawlMark);
		}

		/// <summary>Создает экземпляр типа с заданным именем, используя для этого именованную сборку и конструктор по умолчанию.</summary>
		/// <param name="assemblyName">Имя сборки, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />. Если параметр <paramref name="assemblyName" /> имеет значение <see langword="null" />, поиск осуществляется в выполняющейся сборке.</param>
		/// <param name="typeName">Полное имя предпочтительного типа.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.  
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.  
		///
		/// или - 
		/// <paramref name="activationAttributes" /> не является пустым массивом, а создаваемый тип не является производным от <see cref="T:System.MarshalByRefObject" />.  
		///
		/// или - 
		/// <paramref name="activationAttributes" /> не является объектом <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />.  
		///
		///
		/// Массив.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимым именем сборки.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.  
		///
		/// или - 
		/// Недопустимое имя сборки или кодовая база.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Произошла ошибка при попытке удаленной активации в целевом объекте, указанном в <paramref name="activationAttributes" />.</exception>
		// Token: 0x060014EC RID: 5356 RVA: 0x00052530 File Offset: 0x00050730
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes)
		{
			if (assemblyName == null)
			{
				assemblyName = Assembly.GetCallingAssembly().GetName().Name;
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Activator.CreateInstance(assemblyName, typeName, false, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, null, null, activationAttributes, null, ref stackCrawlMark);
		}

		/// <summary>Создает экземпляр указанного типа, используя конструктор, заданный для этого типа по умолчанию.</summary>
		/// <param name="type">Тип создаваемого объекта.</param>
		/// <param name="nonPublic">Значение <see langword="true" />, если можно сопоставить как открытый, так и закрытый конструктор по умолчанию; значение <see langword="false" />, если можно сопоставить только открытый конструктор по умолчанию.</param>
		/// <returns>Ссылка на вновь созданный объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> не является объектом <see langword="RuntimeType" />.  
		/// -или- 
		///  Тип <paramref name="type" /> является открытым универсальным типом (то есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> возвращает <see langword="true" />).</exception>
		/// <exception cref="T:System.NotSupportedException">Тип <paramref name="type" /> не может иметь значение <see cref="T:System.Reflection.Emit.TypeBuilder" />.  
		///
		/// или - 
		/// Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.  
		///
		/// или - 
		/// Сборка, содержащая <paramref name="type" />, является динамической сборкой, которая была создана с использованием <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Save" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызываемый конструктор создает исключение.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">
		///   <paramref name="type" /> — это COM-объект, но идентификатор класса, используемый для получения типа, является недопустимым, или идентифицируемый класс не зарегистрирован.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="type" /> не является допустимым типом.</exception>
		// Token: 0x060014ED RID: 5357 RVA: 0x00052567 File Offset: 0x00050767
		public static object CreateInstance(Type type, bool nonPublic)
		{
			return Activator.CreateInstance(type, nonPublic, true);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00052574 File Offset: 0x00050774
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CreateInstance(Type type, bool nonPublic, bool wrapExceptions)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			RuntimeType runtimeType = type.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "type");
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return runtimeType.CreateInstanceDefaultCtor(!nonPublic, false, true, wrapExceptions, ref stackCrawlMark);
		}

		/// <summary>Создает экземпляр типа, объявленного в указанном параметре универсального типа, с помощью конструктора без параметров.</summary>
		/// <typeparam name="T">Создаваемый тип данных.</typeparam>
		/// <returns>Ссылка на вновь созданный объект.</returns>
		/// <exception cref="T:System.MissingMethodException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MissingMemberException" />.  
		///
		///
		///
		///
		///  Тип, который задан для <paramref name="T" />, не имеет конструктора без параметров.</exception>
		// Token: 0x060014EF RID: 5359 RVA: 0x000525C8 File Offset: 0x000507C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T CreateInstance<T>()
		{
			RuntimeType runtimeType = typeof(T) as RuntimeType;
			if (runtimeType.HasElementType)
			{
				throw new MissingMethodException(Environment.GetResourceString("No parameterless constructor defined for this object."));
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return (T)((object)runtimeType.CreateInstanceDefaultCtor(true, true, true, true, ref stackCrawlMark));
		}

		/// <summary>Создает экземпляр типа с заданным именем, используя для этого файл именованной сборки и конструктор по умолчанию.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />.</param>
		/// <param name="typeName">Имя предпочтительного типа.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего оператора нет необходимого разрешения <see cref="T:System.Security.Permissions.FileIOPermission" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		// Token: 0x060014F0 RID: 5360 RVA: 0x0005260E File Offset: 0x0005080E
		public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName)
		{
			return Activator.CreateInstanceFrom(assemblyFile, typeName, null);
		}

		/// <summary>Создает экземпляр типа с заданным именем, используя для этого файл именованной сборки и конструктор по умолчанию.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />.</param>
		/// <param name="typeName">Имя предпочтительного типа.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.  
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="activationAttributes" /> не является пустым массивом, а создаваемый тип не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего оператора нет необходимого разрешения <see cref="T:System.Security.Permissions.FileIOPermission" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		// Token: 0x060014F1 RID: 5361 RVA: 0x00052618 File Offset: 0x00050818
		public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes)
		{
			return Activator.CreateInstanceFrom(assemblyFile, typeName, false, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, null, null, activationAttributes);
		}

		/// <summary>Создает экземпляр типа с заданным именем, используя для этого именованную сборку и конструктор, который наилучшим образом соответствует заданным параметрам.</summary>
		/// <param name="assemblyName">Имя сборки, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />. Если параметр <paramref name="assemblyName" /> имеет значение <see langword="null" />, поиск осуществляется в выполняющейся сборке.</param>
		/// <param name="typeName">Полное имя предпочтительного типа.</param>
		/// <param name="ignoreCase">Значение <see langword="true" /> для выполнения поиска <paramref name="typeName" /> без учета регистра; значение <see langword="false" /> для выполнения поиска с учетом регистра.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который использует параметры <paramref name="bindingAttr" /> и <paramref name="args" /> для поиска и идентификации конструктора <paramref name="typeName" />. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="args">Массив аргументов, число, порядок и тип которых соответствуют параметрам вызываемого конструктора. Если параметр <paramref name="args" /> предоставляет пустой массив или имеет значение <see langword="null" />, то вызывается конструктор, который не принимает никаких параметров (конструктор, вызываемый по умолчанию).</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.  
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <param name="securityInfo">Сведения, используемые для принятия решений согласно политике безопасности и предоставления разрешений для кода.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.  
		///
		/// или - 
		/// <paramref name="activationAttributes" /> не является пустым массивом, а создаваемый тип не является производным от <see cref="T:System.MarshalByRefObject" />.  
		///
		/// или - 
		/// Конструктор, который наилучшим образом соответствует <paramref name="args" />, имеет аргументы <see langword="varargs" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.  
		///
		/// или - 
		/// Недопустимые имя сборки или кодовая база.</exception>
		// Token: 0x060014F2 RID: 5362 RVA: 0x0005262C File Offset: 0x0005082C
		[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityInfo)
		{
			if (assemblyName == null)
			{
				assemblyName = Assembly.GetCallingAssembly().GetName().Name;
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Activator.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityInfo, ref stackCrawlMark);
		}

		/// <summary>Создает экземпляр типа с заданным именем, используя для этого именованную сборку и конструктор, который наилучшим образом соответствует заданным параметрам.</summary>
		/// <param name="assemblyName">Имя сборки, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />. Если параметр <paramref name="assemblyName" /> имеет значение <see langword="null" />, поиск осуществляется в выполняющейся сборке.</param>
		/// <param name="typeName">Полное имя предпочтительного типа.</param>
		/// <param name="ignoreCase">Значение <see langword="true" /> для выполнения поиска <paramref name="typeName" /> без учета регистра; значение <see langword="false" /> для выполнения поиска с учетом регистра.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который использует параметры <paramref name="bindingAttr" /> и <paramref name="args" /> для поиска и идентификации конструктора <paramref name="typeName" />. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="args">Массив аргументов, число, порядок и тип которых соответствуют параметрам вызываемого конструктора. Если параметр <paramref name="args" /> предоставляет пустой массив или имеет значение <see langword="null" />, то вызывается конструктор, который не принимает никаких параметров (конструктор, вызываемый по умолчанию).</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.  
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.  
		///
		/// или - 
		/// <paramref name="activationAttributes" /> не является пустым массивом, а создаваемый тип не является производным от <see cref="T:System.MarshalByRefObject" />.  
		///
		/// или - 
		/// Конструктор, который наилучшим образом соответствует <paramref name="args" />, имеет аргументы <see langword="varargs" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.  
		///
		/// или - 
		/// Недопустимые имя сборки или кодовая база.</exception>
		// Token: 0x060014F3 RID: 5363 RVA: 0x00052664 File Offset: 0x00050864
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			if (assemblyName == null)
			{
				assemblyName = Assembly.GetCallingAssembly().GetName().Name;
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Activator.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, null, ref stackCrawlMark);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0005269C File Offset: 0x0005089C
		[SecurityCritical]
		internal static ObjectHandle CreateInstance(string assemblyString, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityInfo, ref StackCrawlMark stackMark)
		{
			Type type = null;
			Assembly assembly = null;
			if (assemblyString == null)
			{
				assembly = RuntimeAssembly.GetExecutingAssembly(ref stackMark);
			}
			else
			{
				RuntimeAssembly runtimeAssembly;
				AssemblyName assemblyName = RuntimeAssembly.CreateAssemblyName(assemblyString, false, out runtimeAssembly);
				if (runtimeAssembly != null)
				{
					assembly = runtimeAssembly;
				}
				else if (assemblyName.ContentType == AssemblyContentType.WindowsRuntime)
				{
					type = Type.GetType(typeName + ", " + assemblyString, true, ignoreCase);
				}
				else
				{
					assembly = RuntimeAssembly.InternalLoadAssemblyName(assemblyName, securityInfo, null, ref stackMark, true, false, false);
				}
			}
			if (type == null)
			{
				if (assembly == null)
				{
					return null;
				}
				type = assembly.GetType(typeName, true, ignoreCase);
			}
			object obj = Activator.CreateInstance(type, bindingAttr, binder, args, culture, activationAttributes);
			if (obj == null)
			{
				return null;
			}
			return new ObjectHandle(obj);
		}

		/// <summary>Создает экземпляр типа с заданным именем, используя для этого файл именованной сборки и конструктор, который наилучшим образом соответствует заданным параметрам.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />.</param>
		/// <param name="typeName">Имя предпочтительного типа.</param>
		/// <param name="ignoreCase">Значение <see langword="true" /> для выполнения поиска <paramref name="typeName" /> без учета регистра; значение <see langword="false" /> для выполнения поиска с учетом регистра.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который использует параметры <paramref name="bindingAttr" /> и <paramref name="args" /> для поиска и идентификации конструктора <paramref name="typeName" />. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="args">Массив аргументов, число, порядок и тип которых соответствуют параметрам вызываемого конструктора. Если параметр <paramref name="args" /> предоставляет пустой массив или имеет значение <see langword="null" />, то вызывается конструктор, который не принимает никаких параметров (конструктор, вызываемый по умолчанию).</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.  
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <param name="securityInfo">Сведения, используемые для принятия решений согласно политике безопасности и предоставления разрешений для кода.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор не имеет необходимого разрешения <see cref="T:System.Security.Permissions.FileIOPermission" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="activationAttributes" /> не является пустым массивом, а создаваемый тип не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		// Token: 0x060014F5 RID: 5365 RVA: 0x0005273C File Offset: 0x0005093C
		[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
		public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityInfo)
		{
			return Activator.CreateInstanceFromInternal(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityInfo);
		}

		/// <summary>Создает экземпляр типа с заданным именем, используя для этого файл именованной сборки и конструктор, который наилучшим образом соответствует заданным параметрам.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />.</param>
		/// <param name="typeName">Имя предпочтительного типа.</param>
		/// <param name="ignoreCase">Значение <see langword="true" /> для выполнения поиска <paramref name="typeName" /> без учета регистра; значение <see langword="false" /> для выполнения поиска с учетом регистра.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который использует параметры <paramref name="bindingAttr" /> и <paramref name="args" /> для поиска и идентификации конструктора <paramref name="typeName" />. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="args">Массив аргументов, число, порядок и тип которых соответствуют параметрам вызываемого конструктора. Если параметр <paramref name="args" /> предоставляет пустой массив или имеет значение <see langword="null" />, то вызывается конструктор, который не принимает никаких параметров (конструктор, вызываемый по умолчанию).</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.  
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор не имеет необходимого разрешения <see cref="T:System.Security.Permissions.FileIOPermission" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="activationAttributes" /> не является пустым массивом, а создаваемый тип не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		// Token: 0x060014F6 RID: 5366 RVA: 0x0005275C File Offset: 0x0005095C
		public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			return Activator.CreateInstanceFromInternal(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, null);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0005277C File Offset: 0x0005097C
		private static ObjectHandle CreateInstanceFromInternal(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityInfo)
		{
			object obj = Activator.CreateInstance(Assembly.LoadFrom(assemblyFile, securityInfo).GetType(typeName, true, ignoreCase), bindingAttr, binder, args, culture, activationAttributes);
			if (obj == null)
			{
				return null;
			}
			return new ObjectHandle(obj);
		}

		/// <summary>Создает экземпляр типа с заданным именем в указанном удаленном домене, используя для этого именованную сборку и конструктор по умолчанию.</summary>
		/// <param name="domain">Удаленный домен, в котором создан тип с именем <paramref name="typeName" />.</param>
		/// <param name="assemblyName">Имя сборки, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />. Если параметр <paramref name="assemblyName" /> имеет значение <see langword="null" />, поиск осуществляется в выполняющейся сборке.</param>
		/// <param name="typeName">Полное имя предпочтительного типа.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="typeName" /> или <paramref name="domain" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Не удается создать экземпляр абстрактного типа.  
		///
		/// или - 
		/// Этот элемент был вызван при помощи механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.  
		///
		/// или - 
		/// Недопустимые имя сборки или кодовая база.</exception>
		// Token: 0x060014F8 RID: 5368 RVA: 0x000527B3 File Offset: 0x000509B3
		[SecurityCritical]
		public static ObjectHandle CreateInstance(AppDomain domain, string assemblyName, string typeName)
		{
			if (domain == null)
			{
				throw new ArgumentNullException("domain");
			}
			return domain.InternalCreateInstanceWithNoSecurity(assemblyName, typeName);
		}

		/// <summary>Создает экземпляр типа с заданным именем в указанном удаленном домене, используя для этого именованную сборку и конструктор, который наилучшим образом соответствует заданным параметрам.</summary>
		/// <param name="domain">Домен, в котором создан тип с именем <paramref name="typeName" />.</param>
		/// <param name="assemblyName">Имя сборки, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />. Если параметр <paramref name="assemblyName" /> имеет значение <see langword="null" />, поиск осуществляется в выполняющейся сборке.</param>
		/// <param name="typeName">Полное имя предпочтительного типа.</param>
		/// <param name="ignoreCase">Значение <see langword="true" /> для выполнения поиска <paramref name="typeName" /> без учета регистра; значение <see langword="false" /> для выполнения поиска с учетом регистра.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который использует параметры <paramref name="bindingAttr" /> и <paramref name="args" /> для поиска и идентификации конструктора <paramref name="typeName" />. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="args">Массив аргументов, число, порядок и тип которых соответствуют параметрам вызываемого конструктора. Если параметр <paramref name="args" /> предоставляет пустой массив или имеет значение <see langword="null" />, то вызывается конструктор, который не принимает никаких параметров (конструктор, вызываемый по умолчанию).</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, это массив, содержащий единственный объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />. Атрибут <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> указывает URL-адрес, требуемый для активации удаленного объекта.</param>
		/// <param name="securityAttributes">Сведения, используемые для принятия решений согласно политике безопасности и предоставления разрешений для кода.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="domain" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.  
		///
		/// или - 
		/// <paramref name="activationAttributes" /> не является пустым массивом, а создаваемый тип не является производным от <see cref="T:System.MarshalByRefObject" />.  
		///
		/// или - 
		/// Конструктор, который наилучшим образом соответствует <paramref name="args" />, имеет аргументы <see langword="varargs" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.  
		///
		/// или - 
		/// Недопустимые имя сборки или кодовая база.</exception>
		// Token: 0x060014F9 RID: 5369 RVA: 0x000527CC File Offset: 0x000509CC
		[SecurityCritical]
		[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
		public static ObjectHandle CreateInstance(AppDomain domain, string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
		{
			if (domain == null)
			{
				throw new ArgumentNullException("domain");
			}
			return domain.InternalCreateInstanceWithNoSecurity(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
		}

		/// <summary>Создает экземпляр типа с заданным именем в указанном удаленном домене, используя для этого именованную сборку и конструктор, который наилучшим образом соответствует заданным параметрам.</summary>
		/// <param name="domain">Домен, в котором создан тип с именем <paramref name="typeName" />.</param>
		/// <param name="assemblyName">Имя сборки, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />. Если параметр <paramref name="assemblyName" /> имеет значение <see langword="null" />, поиск осуществляется в выполняющейся сборке.</param>
		/// <param name="typeName">Полное имя предпочтительного типа.</param>
		/// <param name="ignoreCase">Значение <see langword="true" /> для выполнения поиска <paramref name="typeName" /> без учета регистра; значение <see langword="false" /> для выполнения поиска с учетом регистра.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который использует параметры <paramref name="bindingAttr" /> и <paramref name="args" /> для поиска и идентификации конструктора <paramref name="typeName" />. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="args">Массив аргументов, число, порядок и тип которых соответствуют параметрам вызываемого конструктора. Если параметр <paramref name="args" /> предоставляет пустой массив или имеет значение <see langword="null" />, то вызывается конструктор, который не принимает никаких параметров (конструктор, вызываемый по умолчанию).</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.  
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="domain" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">Тип модели COM не был получен с помощью <see cref="Overload:System.Type.GetTypeFromProgID" /> или <see cref="Overload:System.Type.GetTypeFromCLSID" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Создание типов <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" /> и <see cref="T:System.RuntimeArgumentHandle" /> или массивов этих типов не поддерживается.  
		///
		/// или - 
		/// <paramref name="activationAttributes" /> не является пустым массивом, а создаваемый тип не является производным от <see cref="T:System.MarshalByRefObject" />.  
		///
		/// или - 
		/// Конструктор, который наилучшим образом соответствует <paramref name="args" />, имеет аргументы <see langword="varargs" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.  
		///
		/// или - 
		/// Недопустимые имя сборки или кодовая база.</exception>
		// Token: 0x060014FA RID: 5370 RVA: 0x000527FC File Offset: 0x000509FC
		[SecurityCritical]
		public static ObjectHandle CreateInstance(AppDomain domain, string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			if (domain == null)
			{
				throw new ArgumentNullException("domain");
			}
			return domain.InternalCreateInstanceWithNoSecurity(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, null);
		}

		/// <summary>Создает экземпляр типа с заданным именем в указанном удаленном домене, используя для этого файл именованной сборки и конструктор по умолчанию.</summary>
		/// <param name="domain">Удаленный домен, в котором создан тип с именем <paramref name="typeName" />.</param>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />.</param>
		/// <param name="typeName">Имя предпочтительного типа.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="domain" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего оператора нет необходимого разрешения <see cref="T:System.Security.Permissions.FileIOPermission" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		// Token: 0x060014FB RID: 5371 RVA: 0x0005282B File Offset: 0x00050A2B
		[SecurityCritical]
		public static ObjectHandle CreateInstanceFrom(AppDomain domain, string assemblyFile, string typeName)
		{
			if (domain == null)
			{
				throw new ArgumentNullException("domain");
			}
			return domain.InternalCreateInstanceFromWithNoSecurity(assemblyFile, typeName);
		}

		/// <summary>Создает экземпляр типа с заданным именем в указанном удаленном домене, используя для этого файл именованной сборки и конструктор, который наилучшим образом соответствует заданным параметрам.</summary>
		/// <param name="domain">Удаленный домен, в котором создан тип с именем <paramref name="typeName" />.</param>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />.</param>
		/// <param name="typeName">Имя предпочтительного типа.</param>
		/// <param name="ignoreCase">Значение <see langword="true" /> для выполнения поиска <paramref name="typeName" /> без учета регистра; значение <see langword="false" /> для выполнения поиска с учетом регистра.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который использует параметры <paramref name="bindingAttr" /> и <paramref name="args" /> для поиска и идентификации конструктора <paramref name="typeName" />. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="args">Массив аргументов, число, порядок и тип которых соответствуют параметрам вызываемого конструктора. Если параметр <paramref name="args" /> предоставляет пустой массив или имеет значение <see langword="null" />, то вызывается конструктор, который не принимает никаких параметров (конструктор, вызываемый по умолчанию).</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.  
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <param name="securityAttributes">Сведения, используемые для принятия решений согласно политике безопасности и предоставления разрешений для кода.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="domain" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего оператора нет необходимого разрешения <see cref="T:System.Security.Permissions.FileIOPermission" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="activationAttributes" /> не является пустым массивом, а создаваемый тип не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В данный момент загружена среда CLR версии 2.0 или более поздней. Объект <paramref name="assemblyName" /> был скомпилирован для версии среды CLR, более поздней, чем загруженная. Обратите внимание, что .NET Framework версий 2.0, 3.0 и 3.5 использует среду CLR версии 2.0.</exception>
		// Token: 0x060014FC RID: 5372 RVA: 0x00052844 File Offset: 0x00050A44
		[Obsolete("Methods which use Evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
		[SecurityCritical]
		public static ObjectHandle CreateInstanceFrom(AppDomain domain, string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
		{
			if (domain == null)
			{
				throw new ArgumentNullException("domain");
			}
			return domain.InternalCreateInstanceFromWithNoSecurity(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
		}

		/// <summary>Создает экземпляр типа с заданным именем в указанном удаленном домене, используя для этого файл именованной сборки и конструктор, который наилучшим образом соответствует заданным параметрам.</summary>
		/// <param name="domain">Удаленный домен, в котором создан тип с именем <paramref name="typeName" />.</param>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />.</param>
		/// <param name="typeName">Имя предпочтительного типа.</param>
		/// <param name="ignoreCase">Значение <see langword="true" /> для выполнения поиска <paramref name="typeName" /> без учета регистра; значение <see langword="false" /> для выполнения поиска с учетом регистра.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который использует параметры <paramref name="bindingAttr" /> и <paramref name="args" /> для поиска и идентификации конструктора <paramref name="typeName" />. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="args">Массив аргументов, число, порядок и тип которых соответствуют параметрам вызываемого конструктора. Если параметр <paramref name="args" /> предоставляет пустой массив или имеет значение <see langword="null" />, то вызывается конструктор, который не принимает никаких параметров (конструктор, вызываемый по умолчанию).</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.  
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="domain" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Конструктор, который был вызван с помощью отражения, создал исключение.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего оператора нет необходимого разрешения <see cref="T:System.Security.Permissions.FileIOPermission" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="activationAttributes" /> не является пустым массивом, а создаваемый тип не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		///
		/// или - 
		/// <paramref name="assemblyName" /> был скомпилирован для версии общеязыковой среды выполнения, которая является более поздней, чем версия, которая в настоящий момент загружена.</exception>
		// Token: 0x060014FD RID: 5373 RVA: 0x00052874 File Offset: 0x00050A74
		[SecurityCritical]
		public static ObjectHandle CreateInstanceFrom(AppDomain domain, string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			if (domain == null)
			{
				throw new ArgumentNullException("domain");
			}
			return domain.InternalCreateInstanceFromWithNoSecurity(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, null);
		}

		/// <summary>Создает экземпляр COM-объекта с заданным именем, используя для этого файл именованной сборки и конструктор по умолчанию.</summary>
		/// <param name="assemblyName">Имя файла, содержащего сборку, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />.</param>
		/// <param name="typeName">Имя предпочтительного типа.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="typeName" /> или <paramref name="assemblyName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Невозможно создать экземпляр с помощью модели COM.  
		///
		/// или - 
		/// <paramref name="typename" /> не найден в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл <paramref name="assemblyName" /> не найден, или модуль, который вы пытаетесь загрузить, не указывает расширение имени файла.</exception>
		/// <exception cref="T:System.MemberAccessException">Не удалось создать экземпляр абстрактного класса.  
		///
		/// или - 
		/// Этот элемент был вызван при помощи механизма позднего связывания.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="assemblyName" /> является пустой строкой ("").</exception>
		// Token: 0x060014FE RID: 5374 RVA: 0x000528A3 File Offset: 0x00050AA3
		public static ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName)
		{
			return Activator.CreateComInstanceFrom(assemblyName, typeName, null, AssemblyHashAlgorithm.None);
		}

		/// <summary>Создает экземпляр COM-объекта с заданным именем, используя для этого файл именованной сборки и конструктор по умолчанию.</summary>
		/// <param name="assemblyName">Имя файла, содержащего сборку, в которой выполняется поиск типа, заданного параметром <paramref name="typeName" />.</param>
		/// <param name="typeName">Имя предпочтительного типа.</param>
		/// <param name="hashValue">Значение вычисленного хэш-кода.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм, используемый для хэширования файлов и создания строгого имени.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному экземпляру.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="typeName" /> или <paramref name="assemblyName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="assemblyName" /> является пустой строкой ("").</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.
		///
		/// или - 
		/// <paramref name="assemblyName" /> превышает максимальную длину, определенную системой.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл <paramref name="assemblyName" /> не найден, или модуль, который вы пытаетесь загрузить, не указывает расширение имени файла.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Тип <paramref name="assemblyName" /> найден, но не может быть загружен.</exception>
		/// <exception cref="T:System.BadImageFormatException">Тип <paramref name="assemblyName" /> не является допустимой сборкой.</exception>
		/// <exception cref="T:System.Security.SecurityException">База кода, которая не начинается с "file://", была указана без требуемого разрешения <see langword="WebPermission" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Невозможно создать экземпляр с помощью COM-модели.  
		///
		/// или - 
		/// <paramref name="typename" /> не найден в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.MemberAccessException">Не удается создать экземпляр абстрактного класса.  
		///
		/// или - 
		/// Этот элемент был вызван при помощи механизма позднего связывания.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		// Token: 0x060014FF RID: 5375 RVA: 0x000528B0 File Offset: 0x00050AB0
		public static ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
		{
			Assembly assembly = Assembly.LoadFrom(assemblyName, hashValue, hashAlgorithm);
			Type type = assembly.GetType(typeName, true, false);
			object[] customAttributes = type.GetCustomAttributes(typeof(ComVisibleAttribute), false);
			if (customAttributes.Length != 0 && !((ComVisibleAttribute)customAttributes[0]).Value)
			{
				throw new TypeLoadException(Environment.GetResourceString("The specified type must be visible from COM."));
			}
			if (assembly == null)
			{
				return null;
			}
			object obj = Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, null, null, null);
			if (obj == null)
			{
				return null;
			}
			return new ObjectHandle(obj);
		}

		/// <summary>Создает прокси для хорошо известного объекта, определенного заданным типом и URL.</summary>
		/// <param name="type">Тип хорошо известного объекта, к которому нужно подключиться.</param>
		/// <param name="url">URL-адрес хорошо известного объекта.</param>
		/// <returns>Прокси, который указывает на конечную точку, используемую требуемым хорошо известным объектом.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> или <paramref name="url" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="type" /> не маршалируется по ссылке и не является интерфейсом.</exception>
		/// <exception cref="T:System.MemberAccessException">Этот элемент был вызван при помощи механизма позднего связывания.</exception>
		// Token: 0x06001500 RID: 5376 RVA: 0x00052929 File Offset: 0x00050B29
		[SecurityCritical]
		public static object GetObject(Type type, string url)
		{
			return Activator.GetObject(type, url, null);
		}

		/// <summary>Создает прокси для хорошо известного объекта, который идентифицируется по заданному типу, URL и данным канала.</summary>
		/// <param name="type">Тип хорошо известного объекта, к которому нужно подключиться.</param>
		/// <param name="url">URL-адрес хорошо известного объекта.</param>
		/// <param name="state">Данные, зависящие от канала, или значение <see langword="null" />.</param>
		/// <returns>Прокси, который указывает на конечную точку, используемую требуемым хорошо известным объектом.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> или <paramref name="url" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///   <paramref name="type" /> не маршалируется по ссылке и не является интерфейсом.</exception>
		/// <exception cref="T:System.MemberAccessException">Этот элемент был вызван при помощи механизма позднего связывания.</exception>
		// Token: 0x06001501 RID: 5377 RVA: 0x00052933 File Offset: 0x00050B33
		[SecurityCritical]
		public static object GetObject(Type type, string url, object state)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return RemotingServices.Connect(type, url, state);
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00052951 File Offset: 0x00050B51
		[Conditional("_DEBUG")]
		private static void Log(bool test, string title, string success, string failure)
		{
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Когда выполнение этого метода завершается, содержит указатель, по которому записано число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе. Этот параметр передается неинициализированным.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001503 RID: 5379 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Activator.GetTypeInfoCount(out uint pcTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Объект, получающий указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001504 RID: 5380 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Activator.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Число сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим оператором, в который помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001505 RID: 5381 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Activator.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентификатор подготовки к отправке, по которому идентифицируется член.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001506 RID: 5382 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Activator.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает экземпляр типа, назначенного указанным объектом <see cref="T:System.ActivationContext" />.</summary>
		/// <param name="activationContext">Объект контекста активации, задающий объект, который необходимо создать.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному объекту.</returns>
		// Token: 0x06001507 RID: 5383 RVA: 0x00052955 File Offset: 0x00050B55
		[SecuritySafeCritical]
		public static ObjectHandle CreateInstance(ActivationContext activationContext)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Создает экземпляр типа, назначенного указанным объектом <see cref="T:System.ActivationContext" /> и активированного с помощью указанных пользовательских данных активации.</summary>
		/// <param name="activationContext">Объект контекста активации, задающий объект, который необходимо создать.</param>
		/// <param name="activationCustomData">Массив строк в кодировке Юникод, содержащих пользовательские данные активации.</param>
		/// <returns>Дескриптор, оболочку которого нужно удалить, чтобы получить доступ к вновь созданному объекту.</returns>
		// Token: 0x06001508 RID: 5384 RVA: 0x00052955 File Offset: 0x00050B55
		[SecuritySafeCritical]
		public static ObjectHandle CreateInstance(ActivationContext activationContext, string[] activationCustomData)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		// Token: 0x040014F4 RID: 5364
		internal const int LookupMask = 255;

		// Token: 0x040014F5 RID: 5365
		internal const BindingFlags ConLookup = BindingFlags.Instance | BindingFlags.Public;

		// Token: 0x040014F6 RID: 5366
		internal const BindingFlags ConstructorDefault = BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance;
	}
}
