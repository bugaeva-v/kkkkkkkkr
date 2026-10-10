using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Unity;

namespace System.Reflection
{
	/// <summary>Предоставляет сведения о методах и конструкторах.</summary>
	// Token: 0x020008AD RID: 2221
	[Serializable]
	public abstract class MethodBase : MemberInfo, _MethodBase
	{
		/// <summary>При переопределении в производном классе возвращает параметры заданного метода или конструктора.</summary>
		/// <returns>Массив типа <see langword="ParameterInfo" />, содержащий сведения, которые соответствуют подписи метода (или конструктора), представленного этим экземпляром <see langword="MethodBase" />.</returns>
		// Token: 0x06004929 RID: 18729
		public abstract ParameterInfo[] GetParameters();

		/// <summary>Возвращает атрибуты, сопоставленные этому методу.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Reflection.MethodAttributes" />.</returns>
		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x0600492A RID: 18730
		public abstract MethodAttributes Attributes { get; }

		/// <summary>Получает флаги <see cref="T:System.Reflection.MethodImplAttributes" />, указывающие атрибуты реализации методы.</summary>
		/// <returns>Флаги реализации метода.</returns>
		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x0600492B RID: 18731 RVA: 0x000EEAE9 File Offset: 0x000ECCE9
		public virtual MethodImplAttributes MethodImplementationFlags
		{
			get
			{
				return this.GetMethodImplementationFlags();
			}
		}

		/// <summary>При переопределении в производном классе возвращает новые флаги <see cref="T:System.Reflection.MethodImplAttributes" />.</summary>
		/// <returns>Флаги <see langword="MethodImplAttributes" />.</returns>
		// Token: 0x0600492C RID: 18732
		public abstract MethodImplAttributes GetMethodImplementationFlags();

		/// <summary>При переопределении в производном классе возвращает объект <see cref="T:System.Reflection.MethodBody" />, который обеспечивает доступ к потоку MSIL, локальным переменным и исключениям для текущего метода.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodBody" />, который обеспечивает доступ к потоку MSIL, локальным переменным и исключениям для текущего метода.</returns>
		/// <exception cref="T:System.InvalidOperationException">Если этот метод не переопределен в производном классе, он является недопустимым.</exception>
		// Token: 0x0600492D RID: 18733 RVA: 0x00084B8D File Offset: 0x00082D8D
		public virtual MethodBody GetMethodBody()
		{
			throw new InvalidOperationException();
		}

		/// <summary>Возвращает значение, показывающее соглашения о вызовах для этого метода.</summary>
		/// <returns>Атрибуты <see cref="T:System.Reflection.CallingConventions" /> для этого метода.</returns>
		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x0600492E RID: 18734 RVA: 0x000040F7 File Offset: 0x000022F7
		public virtual CallingConventions CallingConvention
		{
			get
			{
				return CallingConventions.Standard;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли метод абстрактным.</summary>
		/// <returns>Значение <see langword="true" />, если метод является абстрактным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x0600492F RID: 18735 RVA: 0x000EEAF1 File Offset: 0x000ECCF1
		public bool IsAbstract
		{
			get
			{
				return (this.Attributes & MethodAttributes.Abstract) > MethodAttributes.PrivateScope;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли метод конструктором.</summary>
		/// <returns>Значение <see langword="true" />, если метод является конструктором, представленным объектом <see cref="T:System.Reflection.ConstructorInfo" /> (см. примечание, относящееся к объектам <see cref="T:System.Reflection.Emit.ConstructorBuilder" />, в разделе "Заметки"); в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06004930 RID: 18736 RVA: 0x000EEB02 File Offset: 0x000ECD02
		public bool IsConstructor
		{
			get
			{
				return this is ConstructorInfo && !this.IsStatic && (this.Attributes & MethodAttributes.RTSpecialName) == MethodAttributes.RTSpecialName;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли метод <see langword="final" />.</summary>
		/// <returns>
		///   <see langword="true" />, если этот метод имеет значение <see langword="final" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06004931 RID: 18737 RVA: 0x000EEB29 File Offset: 0x000ECD29
		public bool IsFinal
		{
			get
			{
				return (this.Attributes & MethodAttributes.Final) > MethodAttributes.PrivateScope;
			}
		}

		/// <summary>Возвращает значение, указывающее, скрывается ли в производном классе только член такого же вида с точно такой же сигнатурой.</summary>
		/// <returns>Значение <see langword="true" />, если член скрыт на основе сигнатуры; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06004932 RID: 18738 RVA: 0x000EEB37 File Offset: 0x000ECD37
		public bool IsHideBySig
		{
			get
			{
				return (this.Attributes & MethodAttributes.HideBySig) > MethodAttributes.PrivateScope;
			}
		}

		/// <summary>Возвращает значение, указывающее, имеет ли этот метод специальное имя.</summary>
		/// <returns>Значение <see langword="true" />, если у этого метода имеется специальное имя; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06004933 RID: 18739 RVA: 0x000EEB48 File Offset: 0x000ECD48
		public bool IsSpecialName
		{
			get
			{
				return (this.Attributes & MethodAttributes.SpecialName) > MethodAttributes.PrivateScope;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли метод значение <see langword="static" />.</summary>
		/// <returns>
		///   <see langword="true" />, если этот метод имеет значение <see langword="static" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06004934 RID: 18740 RVA: 0x000EEB59 File Offset: 0x000ECD59
		public bool IsStatic
		{
			get
			{
				return (this.Attributes & MethodAttributes.Static) > MethodAttributes.PrivateScope;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли метод значение <see langword="virtual" />.</summary>
		/// <returns>
		///   <see langword="true" />, если этот метод имеет значение <see langword="virtual" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06004935 RID: 18741 RVA: 0x000EEB67 File Offset: 0x000ECD67
		public bool IsVirtual
		{
			get
			{
				return (this.Attributes & MethodAttributes.Virtual) > MethodAttributes.PrivateScope;
			}
		}

		/// <summary>Возвращает значение, которое указывает, описана ли доступность данного метода или конструктора в поле <see cref="F:System.Reflection.MethodAttributes.Assembly" />; другими словами, этот метод или конструктор полностью доступен для других полей той же сборки и недоступен для производных типов, не включенных в сборку.</summary>
		/// <returns>Значение <see langword="true" />, если доступность этого метода или конструктора точно описана в поле <see cref="F:System.Reflection.MethodAttributes.Assembly" />; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06004936 RID: 18742 RVA: 0x000EEB75 File Offset: 0x000ECD75
		public bool IsAssembly
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Assembly;
			}
		}

		/// <summary>Возвращает значение, которое указывает, описана ли доступность этого метода или конструктора в поле <see cref="F:System.Reflection.MethodAttributes.Family" />; другими словами, этот метод или конструктор доступен только в своем классе и производных классах.</summary>
		/// <returns>Значение <see langword="true" />, если доступность этого метода или конструктора точно описана в поле <see cref="F:System.Reflection.MethodAttributes.Family" />; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06004937 RID: 18743 RVA: 0x000EEB82 File Offset: 0x000ECD82
		public bool IsFamily
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Family;
			}
		}

		/// <summary>Возвращает значение, которое указывает, описана ли доступность этого метода или конструктора в поле <see cref="F:System.Reflection.MethodAttributes.FamANDAssem" />; другими словами, этот метод или конструктор может вызываться в производных классах, но только в том случае, если они находятся в той же сборке.</summary>
		/// <returns>Значение <see langword="true" />, если доступность этого метода или конструктора точно описана в поле <see cref="F:System.Reflection.MethodAttributes.FamANDAssem" />; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06004938 RID: 18744 RVA: 0x000EEB8F File Offset: 0x000ECD8F
		public bool IsFamilyAndAssembly
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.FamANDAssem;
			}
		}

		/// <summary>Возвращает значение, которое указывает, описана ли потенциальная доступность этого метода или конструктора в поле <see cref="F:System.Reflection.MethodAttributes.FamORAssem" />; другими словами, этот метод или конструктор может вызываться в производных классах независимо от их расположения, а также в классах той же сборки.</summary>
		/// <returns>Значение <see langword="true" />, если доступность этого метода или конструктора точно описана в поле <see cref="F:System.Reflection.MethodAttributes.FamORAssem" />; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06004939 RID: 18745 RVA: 0x000EEB9C File Offset: 0x000ECD9C
		public bool IsFamilyOrAssembly
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.FamORAssem;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли этот член закрытым.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу разрешен только элементам данного класса, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600493A RID: 18746 RVA: 0x000EEBA9 File Offset: 0x000ECDA9
		public bool IsPrivate
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Private;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли метод открытым.</summary>
		/// <returns>Значение <see langword="true" />, если метод является открытым; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600493B RID: 18747 RVA: 0x000EEBB6 File Offset: 0x000ECDB6
		public bool IsPublic
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x0600493C RID: 18748 RVA: 0x000EEBC3 File Offset: 0x000ECDC3
		public virtual bool IsConstructedGenericMethod
		{
			get
			{
				return this.IsGenericMethod && !this.IsGenericMethodDefinition;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли этот метод универсальным.</summary>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Reflection.MethodBase" /> представляет универсальный метод; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x0600493D RID: 18749 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsGenericMethod
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли этот метод определением универсального метода.</summary>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Reflection.MethodBase" /> представляет определение универсального метода; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x0600493E RID: 18750 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsGenericMethodDefinition
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Type" />, которые представляют аргументы универсального метода, относящиеся к типу, или параметры типа определения универсального метода.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа, относящиеся к универсальному методу, или параметры типа определения универсального метода. Возвращает пустой массив, если текущий метод не является универсальным методом.</returns>
		/// <exception cref="T:System.NotSupportedException">Текущий объект является объектом <see cref="T:System.Reflection.ConstructorInfo" />. Универсальные конструкторы в платформе .NET Framework версии 2.0 не поддерживаются. Это исключение является поведением по умолчанию, если этот метод не переопределен в производном классе.</exception>
		// Token: 0x0600493F RID: 18751 RVA: 0x0004728A File Offset: 0x0004548A
		public virtual Type[] GetGenericArguments()
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Возвращает значение, указывающее, содержит ли универсальный метод не присвоенные параметры универсального типа.</summary>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Reflection.MethodBase" /> представляет универсальный метод, который содержит не присвоенные параметры универсального типа; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06004940 RID: 18752 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool ContainsGenericParameters
		{
			get
			{
				return false;
			}
		}

		/// <summary>Вызывает метод или конструктор, представленный текущим экземпляром, используя указанные параметры.</summary>
		/// <param name="obj">Объект, для которого нужно вызвать метод или конструктор. Если метод является статическим, этот аргумент игнорируется. Если конструктор является статическим, этот аргумент должен иметь значение <see langword="null" /> или представлять экземпляр класса, который определяет конструктор.</param>
		/// <param name="parameters">Список аргументов для вызываемого метода или конструктора. Это массив объектов, количество, порядок и тип которых должны соответствовать списку параметров вызываемого метода или конструктора. Если параметров нет, для <paramref name="parameters" /> должно быть указано значение <see langword="null" />.  
		/// Если метод или конструктор, представленный этим экземпляром, принимает параметр <see langword="ref" /> (<see langword="ByRef" /> в Visual Basic), не требуются никакие специальные атрибуты для вызова этого метода или конструктора с использованием этой функции. Любой объект этого массива, которому не присвоено значение явным образом, будет содержать значение по умолчанию для своего типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, хранящих значения, это значение равно 0, 0,0 или <see langword="false" /> (в зависимости от типа конкретного элемента).</param>
		/// <returns>Объект, который содержит возвращаемое значение вызываемого метода, или <see langword="null" /> при вызове конструктора.</returns>
		/// <exception cref="T:System.Reflection.TargetException">Вместо этого в .NET для приложений из Магазина Windows или в переносимой библиотеке классов перехватите исключение <see cref="T:System.Exception" />.  
		///
		///
		///
		///
		///  Параметр <paramref name="obj" /> имеет значение <see langword="null" /> и метод не является статическим.  
		///
		/// или - 
		/// Этот метод не объявлен и не унаследован в классе <paramref name="obj" />.  
		///
		/// или - 
		/// Вызывается статический конструктор, а <paramref name="obj" /> не имеет значения <see langword="null" /> и не является экземпляром класса, в котором объявлен этот конструктор.</exception>
		/// <exception cref="T:System.ArgumentException">Элементы массива <paramref name="parameters" /> не соответствуют подписи метода или конструктора, отраженного этим экземпляром.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызванный метод или конструктор создает исключение.  
		///
		/// или - 
		/// Текущий экземпляр представляет <see cref="T:System.Reflection.Emit.DynamicMethod" />, который содержит непроверяемый код. См. подраздел "Проверка" в разделе примечаний для <see cref="T:System.Reflection.Emit.DynamicMethod" />.</exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">Массив <paramref name="parameters" /> содержит неправильное число аргументов.</exception>
		/// <exception cref="T:System.MethodAccessException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MemberAccessException" />.  
		///
		///
		///
		///
		///  Вызывающий объект не имеет разрешение на выполнение метода или конструктора, представленного текущим экземпляром.</exception>
		/// <exception cref="T:System.InvalidOperationException">Тип, объявляющий метод, является открытым универсальным типом. То есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> для объявляющего типа возвращает значение <see langword="true" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий экземпляр представляет <see cref="T:System.Reflection.Emit.MethodBuilder" />.</exception>
		// Token: 0x06004941 RID: 18753 RVA: 0x000EEBD8 File Offset: 0x000ECDD8
		[DebuggerStepThrough]
		[DebuggerHidden]
		public object Invoke(object obj, object[] parameters)
		{
			return this.Invoke(obj, BindingFlags.Default, null, parameters, null);
		}

		/// <summary>При переопределении в производном классе вызывает отражаемый метод или конструктор с заданными параметрами.</summary>
		/// <param name="obj">Объект, для которого нужно вызвать метод или конструктор. Если метод является статическим, этот аргумент игнорируется. Если конструктор является статическим, этот аргумент должен иметь значение <see langword="null" /> или представлять экземпляр класса, который определяет конструктор.</param>
		/// <param name="invokeAttr">Битовая маска, которая содержит от нуля и больше битовых флагов из атрибута <see cref="T:System.Reflection.BindingFlags" /> в разных сочетаниях. Если параметр <paramref name="binder" /> имеет значение <see langword="null" />, ему присваивается значение <see cref="F:System.Reflection.BindingFlags.Default" />. В результате все передаваемые параметры игнорируются.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see langword="MemberInfo" /> с помощью отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="parameters">Список аргументов для вызываемого метода или конструктора. Это массив объектов, количество, порядок и тип которых должны соответствовать списку параметров вызываемого метода или конструктора. При отсутствии параметров — значение <see langword="null" />.  
		/// Если метод или конструктор, представленный этим экземпляром, принимает параметр ByRef, для вызова метода или конструктора с использованием этой функции специальные атрибуты не требуются. Любой объект этого массива, которому не присвоено значение явным образом, будет содержать значение по умолчанию для своего типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, хранящих значения, это значение равно 0, 0,0 или <see langword="false" /> (в зависимости от типа конкретного элемента).</param>
		/// <param name="culture">Экземпляр объекта <see langword="CultureInfo" />, используемого для управления приведением типов. Если значение этого объекта — <see langword="null" />, для текущего потока используется <see langword="CultureInfo" />. (Например, необходимо преобразовывать объект <see langword="String" />, представляющий 1000, в значение <see langword="Double" />, поскольку при разных языках и региональных параметрах 1000 представляется по-разному.)</param>
		/// <returns>Объект <see langword="Object" />, содержащий возвращаемое значение вызванного метода, значение <see langword="null" /> для конструктора или значение <see langword="null" />, если метод возвращает значение типа <see langword="void" />. Перед вызовом метода или конструктора функция <see langword="Invoke" /> проверяет наличие у пользователя права доступа и допустимость параметров.</returns>
		/// <exception cref="T:System.Reflection.TargetException">Параметр <paramref name="obj" /> имеет значение <see langword="null" /> и метод не является статическим.  
		///
		/// или - 
		/// Этот метод не объявлен и не унаследован в классе <paramref name="obj" />.  
		///
		/// или - 
		/// Вызывается статический конструктор, а <paramref name="obj" /> не имеет значения <see langword="null" /> и не является экземпляром класса, в котором объявлен этот конструктор.</exception>
		/// <exception cref="T:System.ArgumentException">Тип параметра <paramref name="parameters" /> не соответствует подписи метода или конструктора, отраженного этим экземпляром.</exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">Массив <paramref name="parameters" /> содержит неправильное число аргументов.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызванный метод или конструктор создает исключение.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешение на выполнение метода или конструктора, представленного текущим экземпляром.</exception>
		/// <exception cref="T:System.InvalidOperationException">Тип, объявляющий метод, является открытым универсальным типом. То есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> для объявляющего типа возвращает значение <see langword="true" />.</exception>
		// Token: 0x06004942 RID: 18754
		public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

		/// <summary>Возвращает дескриптор представления внутренних метаданных метода.</summary>
		/// <returns>Объект <see cref="T:System.RuntimeMethodHandle" />.</returns>
		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06004943 RID: 18755
		public abstract RuntimeMethodHandle MethodHandle { get; }

		/// <summary>Получает значение, которое указывает, является ли текущий метод или конструктор критически важным для безопасности или защищенным критически важным для безопасности на данном уровне доверия и, следовательно, может ли он выполнять критические операции.</summary>
		/// <returns>Значение <see langword="true" />, если текущий метод или конструктор является критически важным для безопасности или защищенным критически важным для безопасности на текущем уровне доверия; значение <see langword="false" />, если он является прозрачным.</returns>
		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06004944 RID: 18756 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool IsSecurityCritical
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Получает значение, которое указывает, является ли текущий динамический метод или конструктор защищенным критически важным для безопасности и, следовательно, может ли он выполнять критические операции и предоставлять доступ прозрачному коду.</summary>
		/// <returns>Значение <see langword="true" />, если текущий метод или конструктор является защищенным критически важным для безопасности на текущем уровне доверия; значение <see langword="false" />, если он является критически важным для безопасности или прозрачным.</returns>
		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06004945 RID: 18757 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool IsSecuritySafeCritical
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Получает значение, которое указывает, является ли текущий метод или конструктор прозрачным на текущем уровне доверия и, следовательно, не может выполнять критические операции.</summary>
		/// <returns>Значение <see langword="true" />, если метод или конструктор является прозрачным на текущем уровне доверия; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06004946 RID: 18758 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool IsSecurityTransparent
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> равно типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004947 RID: 18759 RVA: 0x000EE386 File Offset: 0x000EC586
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06004948 RID: 18760 RVA: 0x000EE38F File Offset: 0x000EC58F
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определение равенства двух объектов <see cref="T:System.Reflection.MethodBase" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004949 RID: 18761 RVA: 0x000EEBE8 File Offset: 0x000ECDE8
		public static bool operator ==(MethodBase left, MethodBase right)
		{
			if (left == right)
			{
				return true;
			}
			if (left == null || right == null)
			{
				return false;
			}
			MethodInfo left2;
			MethodInfo right2;
			if ((left2 = (left as MethodInfo)) != null && (right2 = (right as MethodInfo)) != null)
			{
				return left2 == right2;
			}
			ConstructorInfo left3;
			ConstructorInfo right3;
			return (left3 = (left as ConstructorInfo)) != null && (right3 = (right as ConstructorInfo)) != null && left3 == right3;
		}

		/// <summary>Определяет неравенство двух объектов <see cref="T:System.Reflection.MethodBase" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600494A RID: 18762 RVA: 0x000EEC54 File Offset: 0x000ECE54
		public static bool operator !=(MethodBase left, MethodBase right)
		{
			return !(left == right);
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x000EEC60 File Offset: 0x000ECE60
		internal virtual ParameterInfo[] GetParametersInternal()
		{
			return this.GetParameters();
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x000EEC68 File Offset: 0x000ECE68
		internal virtual int GetParametersCount()
		{
			return this.GetParametersInternal().Length;
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual Type GetParameterType(int pos)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x000EEC72 File Offset: 0x000ECE72
		internal virtual int get_next_table_index(object obj, int table, int count)
		{
			if (this is MethodBuilder)
			{
				return ((MethodBuilder)this).get_next_table_index(obj, table, count);
			}
			if (this is ConstructorBuilder)
			{
				return ((ConstructorBuilder)this).get_next_table_index(obj, table, count);
			}
			throw new Exception("Method is not a builder method");
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x000EECAC File Offset: 0x000ECEAC
		internal virtual string FormatNameAndSig(bool serialization)
		{
			StringBuilder stringBuilder = new StringBuilder(this.Name);
			stringBuilder.Append("(");
			stringBuilder.Append(MethodBase.ConstructParameters(this.GetParameterTypes(), this.CallingConvention, serialization));
			stringBuilder.Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x000EECFC File Offset: 0x000ECEFC
		internal virtual Type[] GetParameterTypes()
		{
			ParameterInfo[] parametersNoCopy = this.GetParametersNoCopy();
			Type[] array = new Type[parametersNoCopy.Length];
			for (int i = 0; i < parametersNoCopy.Length; i++)
			{
				array[i] = parametersNoCopy[i].ParameterType;
			}
			return array;
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x000EEC60 File Offset: 0x000ECE60
		internal virtual ParameterInfo[] GetParametersNoCopy()
		{
			return this.GetParameters();
		}

		/// <summary>Получает сведения о методе с помощью представления внутренних метаданных метода (дескриптора).</summary>
		/// <param name="handle">Дескриптор метода.</param>
		/// <returns>Строка <see langword="MethodBase" />, содержащая сведения о методе.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="handle" /> недопустим.</exception>
		// Token: 0x06004952 RID: 18770 RVA: 0x000EED34 File Offset: 0x000ECF34
		public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle)
		{
			if (handle.IsNullHandle())
			{
				throw new ArgumentException(Environment.GetResourceString("The handle is invalid."));
			}
			MethodBase methodFromHandleInternalType = RuntimeMethodInfo.GetMethodFromHandleInternalType(handle.Value, IntPtr.Zero);
			if (methodFromHandleInternalType == null)
			{
				throw new ArgumentException("The handle is invalid.");
			}
			Type declaringType = methodFromHandleInternalType.DeclaringType;
			if (declaringType != null && declaringType.IsGenericType)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Cannot resolve method {0} because the declaring type of the method handle {1} is generic. Explicitly provide the declaring type to GetMethodFromHandle."), methodFromHandleInternalType, declaringType.GetGenericTypeDefinition()));
			}
			return methodFromHandleInternalType;
		}

		/// <summary>Возвращает объект <see cref="T:System.Reflection.MethodBase" /> для конструктора метода, представленного заданным дескриптором для заданного универсального типа.</summary>
		/// <param name="handle">Дескриптор представления внутренних метаданных конструктора или метода.</param>
		/// <param name="declaringType">Дескриптор универсального типа, определяющего конструктор или метод.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodBase" />, который представляет метод или конструктор, определенный дескриптором <paramref name="handle" />, в универсальном типе, заданном параметром <paramref name="declaringType" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="handle" /> недопустим.</exception>
		// Token: 0x06004953 RID: 18771 RVA: 0x000EEDBC File Offset: 0x000ECFBC
		[ComVisible(false)]
		public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle, RuntimeTypeHandle declaringType)
		{
			if (handle.IsNullHandle())
			{
				throw new ArgumentException(Environment.GetResourceString("The handle is invalid."));
			}
			MethodBase methodFromHandleInternalType = RuntimeMethodInfo.GetMethodFromHandleInternalType(handle.Value, declaringType.Value);
			if (methodFromHandleInternalType == null)
			{
				throw new ArgumentException("The handle is invalid.");
			}
			return methodFromHandleInternalType;
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x000EEE0C File Offset: 0x000ED00C
		internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string value = "";
			foreach (Type type in parameterTypes)
			{
				stringBuilder.Append(value);
				string text = type.FormatTypeName(serialization);
				if (type.IsByRef && !serialization)
				{
					stringBuilder.Append(text.TrimEnd(new char[]
					{
						'&'
					}));
					stringBuilder.Append(" ByRef");
				}
				else
				{
					stringBuilder.Append(text);
				}
				value = ", ";
			}
			if ((callingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs)
			{
				stringBuilder.Append(value);
				stringBuilder.Append("...");
			}
			return stringBuilder.ToString();
		}

		/// <summary>Возвращает объект <see langword="MethodBase" />, представляющий выполняющийся в текущий момент метод.</summary>
		/// <returns>
		///   <see cref="M:System.Reflection.MethodBase.GetCurrentMethod" /> — это статический метод, который вызывается из выполняющегося метода и возвращает сведения об этом методе.  
		/// Объект <see langword="MethodBase" />, представляющий выполняющийся в текущий момент метод.</returns>
		/// <exception cref="T:System.Reflection.TargetException">Этот элемент был вызван при помощи механизма позднего связывания.</exception>
		// Token: 0x06004955 RID: 18773
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern MethodBase GetCurrentMethod();

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06004956 RID: 18774 RVA: 0x000173AD File Offset: 0x000155AD
		void _MethodBase.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Runtime.InteropServices._MethodBase.GetType" />.</summary>
		/// <returns>Описание этого члена см. в разделе <see cref="M:System.Runtime.InteropServices._MethodBase.GetType" />.</returns>
		// Token: 0x06004957 RID: 18775 RVA: 0x00052955 File Offset: 0x00050B55
		Type _MethodBase.GetType()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06004958 RID: 18776 RVA: 0x000173AD File Offset: 0x000155AD
		void _MethodBase.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06004959 RID: 18777 RVA: 0x000173AD File Offset: 0x000155AD
		void _MethodBase.GetTypeInfoCount(out uint pcTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
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
		// Token: 0x0600495A RID: 18778 RVA: 0x000173AD File Offset: 0x000155AD
		void _MethodBase.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
