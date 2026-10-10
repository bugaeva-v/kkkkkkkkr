using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Reflection.Emit
{
	/// <summary>Определяет и создает новые экземпляры классов во время выполнения.</summary>
	// Token: 0x02000947 RID: 2375
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_TypeBuilder))]
	[ClassInterface(ClassInterfaceType.None)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class TypeBuilder : TypeInfo, _TypeBuilder
	{
		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06005284 RID: 21124 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _TypeBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06005285 RID: 21125 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _TypeBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06005286 RID: 21126 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _TypeBuilder.GetTypeInfoCount(out uint pcTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06005287 RID: 21127 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _TypeBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x00102EC6 File Offset: 0x001010C6
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return this.attrs;
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x00102ECE File Offset: 0x001010CE
		private TypeBuilder()
		{
			if (RuntimeType.MakeTypeBuilderInstantiation == null)
			{
				RuntimeType.MakeTypeBuilderInstantiation = new Func<Type, Type[], Type>(TypeBuilderInstantiation.MakeGenericType);
			}
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00102EF0 File Offset: 0x001010F0
		[PreserveDependency("DoTypeBuilderResolve", "System.AppDomain")]
		internal TypeBuilder(ModuleBuilder mb, TypeAttributes attr, int table_idx) : this()
		{
			this.parent = null;
			this.attrs = attr;
			this.class_size = 0;
			this.table_idx = table_idx;
			this.tname = ((table_idx == 1) ? "<Module>" : ("type_" + table_idx.ToString()));
			this.nspace = string.Empty;
			this.fullname = TypeIdentifiers.WithoutEscape(this.tname);
			this.pmodule = mb;
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00102F64 File Offset: 0x00101164
		internal TypeBuilder(ModuleBuilder mb, string name, TypeAttributes attr, Type parent, Type[] interfaces, PackingSize packing_size, int type_size, Type nesting_type) : this()
		{
			this.parent = TypeBuilder.ResolveUserType(parent);
			this.attrs = attr;
			this.class_size = type_size;
			this.packing_size = packing_size;
			this.nesting_type = nesting_type;
			this.check_name("fullname", name);
			if (parent == null && (attr & TypeAttributes.ClassSemanticsMask) != TypeAttributes.NotPublic && (attr & TypeAttributes.Abstract) == TypeAttributes.NotPublic)
			{
				throw new InvalidOperationException("Interface must be declared abstract.");
			}
			int num = name.LastIndexOf('.');
			if (num != -1)
			{
				this.tname = name.Substring(num + 1);
				this.nspace = name.Substring(0, num);
			}
			else
			{
				this.tname = name;
				this.nspace = string.Empty;
			}
			if (interfaces != null)
			{
				this.interfaces = new Type[interfaces.Length];
				Array.Copy(interfaces, this.interfaces, interfaces.Length);
			}
			this.pmodule = mb;
			if ((attr & TypeAttributes.ClassSemanticsMask) == TypeAttributes.NotPublic && parent == null)
			{
				this.parent = typeof(object);
			}
			this.table_idx = mb.get_next_table_index(this, 2, 1);
			this.fullname = this.GetFullName();
		}

		/// <summary>Извлекает динамическую сборку, содержащую определение данного типа.</summary>
		/// <returns>Только для чтения. Извлекает динамическую сборку, содержащую определение данного типа.</returns>
		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x0600528C RID: 21132 RVA: 0x00103077 File Offset: 0x00101277
		public override Assembly Assembly
		{
			get
			{
				return this.pmodule.Assembly;
			}
		}

		/// <summary>Возвращает полное имя данного типа, дополненное отображаемым именем сборки.</summary>
		/// <returns>Только для чтения. Полное имя данного типа, дополненное отображаемым именем сборки.</returns>
		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x00103084 File Offset: 0x00101284
		public override string AssemblyQualifiedName
		{
			get
			{
				return this.fullname.DisplayName + ", " + this.Assembly.FullName;
			}
		}

		/// <summary>Возвращает базовый тип данного типа.</summary>
		/// <returns>Только для чтения. Возвращает базовый тип данного типа.</returns>
		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x0600528E RID: 21134 RVA: 0x001030A6 File Offset: 0x001012A6
		public override Type BaseType
		{
			get
			{
				return this.parent;
			}
		}

		/// <summary>Возвращает тот тип, в котором объявлен данный тип.</summary>
		/// <returns>Только для чтения. Тип, в котором объявлен данный тип.</returns>
		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x0600528F RID: 21135 RVA: 0x001030AE File Offset: 0x001012AE
		public override Type DeclaringType
		{
			get
			{
				return this.nesting_type;
			}
		}

		/// <summary>Определяет, является ли этот тип производным из указанного типа.</summary>
		/// <param name="c">Проверяемый тип <see cref="T:System.Type" />.</param>
		/// <returns>Только для чтения. Возвращает <see langword="true" />, если данный тип совпадает с типом параметра <paramref name="c" /> или является подтипом типа <paramref name="c" />, в противном случае возвращает <see langword="false" />.</returns>
		// Token: 0x06005290 RID: 21136 RVA: 0x001030B8 File Offset: 0x001012B8
		[ComVisible(true)]
		public override bool IsSubclassOf(Type c)
		{
			if (c == null)
			{
				return false;
			}
			if (c == this)
			{
				return false;
			}
			Type baseType = this.parent;
			while (baseType != null)
			{
				if (c == baseType)
				{
					return true;
				}
				baseType = baseType.BaseType;
			}
			return false;
		}

		/// <summary>Возвращает тип основной системы для данного <see langword="TypeBuilder" />.</summary>
		/// <returns>Только для чтения. Возвращает базовый системный тип.</returns>
		/// <exception cref="T:System.InvalidOperationException">Этот тип является перечислением, однако тип основной системы отсутствует.</exception>
		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x00103100 File Offset: 0x00101300
		public override Type UnderlyingSystemType
		{
			get
			{
				if (this.is_created)
				{
					return this.created.UnderlyingSystemType;
				}
				if (!this.IsEnum)
				{
					return this;
				}
				if (this.underlying_type != null)
				{
					return this.underlying_type;
				}
				throw new InvalidOperationException("Enumeration type is not defined.");
			}
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x00103140 File Offset: 0x00101340
		private TypeName GetFullName()
		{
			TypeIdentifier typeIdentifier = TypeIdentifiers.FromInternal(this.tname);
			if (this.nesting_type != null)
			{
				return TypeNames.FromDisplay(this.nesting_type.FullName).NestedName(typeIdentifier);
			}
			if (this.nspace != null && this.nspace.Length > 0)
			{
				return TypeIdentifiers.FromInternal(this.nspace, typeIdentifier);
			}
			return typeIdentifier;
		}

		/// <summary>Извлекает полный путь данного типа.</summary>
		/// <returns>Только для чтения. Извлекает полный путь данного типа.</returns>
		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x001031A2 File Offset: 0x001013A2
		public override string FullName
		{
			get
			{
				return this.fullname.DisplayName;
			}
		}

		/// <summary>Извлекает идентификатор GUID данного типа.</summary>
		/// <returns>Только для чтения. Извлекает идентификатор GUID данного типа.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается для неполных типов.</exception>
		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06005294 RID: 21140 RVA: 0x001031AF File Offset: 0x001013AF
		public override Guid GUID
		{
			get
			{
				this.check_created();
				return this.created.GUID;
			}
		}

		/// <summary>Извлекает динамический модуль, содержащий определение данного типа.</summary>
		/// <returns>Только для чтения. Извлекает динамический модуль, содержащий определение данного типа.</returns>
		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06005295 RID: 21141 RVA: 0x001031C2 File Offset: 0x001013C2
		public override Module Module
		{
			get
			{
				return this.pmodule;
			}
		}

		/// <summary>Извлекает имя данного типа.</summary>
		/// <returns>Только для чтения. Извлекает имя данного типа <see cref="T:System.String" />.</returns>
		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06005296 RID: 21142 RVA: 0x001031CA File Offset: 0x001013CA
		public override string Name
		{
			get
			{
				return this.tname;
			}
		}

		/// <summary>Извлекает пространство имен, в котором определен данный <see langword="TypeBuilder" />.</summary>
		/// <returns>Только для чтения. Извлекает пространство имен, в котором определен данный <see langword="TypeBuilder" />.</returns>
		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06005297 RID: 21143 RVA: 0x001031D2 File Offset: 0x001013D2
		public override string Namespace
		{
			get
			{
				return this.nspace;
			}
		}

		/// <summary>Извлекает размер упаковки данного типа.</summary>
		/// <returns>Только для чтения. Извлекает размер упаковки данного типа.</returns>
		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06005298 RID: 21144 RVA: 0x001031DA File Offset: 0x001013DA
		public PackingSize PackingSize
		{
			get
			{
				return this.packing_size;
			}
		}

		/// <summary>Извлекает полный размер типа.</summary>
		/// <returns>Только для чтения. Получает общий размер этого типа.</returns>
		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06005299 RID: 21145 RVA: 0x001031E2 File Offset: 0x001013E2
		public int Size
		{
			get
			{
				return this.class_size;
			}
		}

		/// <summary>Возвращает тип, который был использован для получения данного типа.</summary>
		/// <returns>Только для чтения. Тип, который был использован для получения данного типа.</returns>
		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x0600529A RID: 21146 RVA: 0x001030AE File Offset: 0x001012AE
		public override Type ReflectedType
		{
			get
			{
				return this.nesting_type;
			}
		}

		/// <summary>Добавляет к данному типу средства декларативной безопасности.</summary>
		/// <param name="action">Требуемое действие по обеспечению безопасности, например Demand, Assert и т. п.</param>
		/// <param name="pset">Набор разрешений, к которым применяется действие.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недопустимый параметр <paramref name="action" /> (недопустимы значения <see langword="RequestMinimum" />, <see langword="RequestOptional" /> и <see langword="RequestRefuse" />).</exception>
		/// <exception cref="T:System.InvalidOperationException">Включающий тип был создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		/// Набор разрешений <paramref name="pset" /> содержит действие, добавленное ранее с помощью <see langword="AddDeclarativeSecurity" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="pset" /> — <see langword="null" />.</exception>
		// Token: 0x0600529B RID: 21147 RVA: 0x001031EC File Offset: 0x001013EC
		public void AddDeclarativeSecurity(SecurityAction action, PermissionSet pset)
		{
			if (pset == null)
			{
				throw new ArgumentNullException("pset");
			}
			if (action == SecurityAction.RequestMinimum || action == SecurityAction.RequestOptional || action == SecurityAction.RequestRefuse)
			{
				throw new ArgumentOutOfRangeException("Request* values are not permitted", "action");
			}
			this.check_not_created();
			if (this.permissions != null)
			{
				RefEmitPermissionSet[] array = this.permissions;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].action == action)
					{
						throw new InvalidOperationException("Multiple permission sets specified with the same SecurityAction.");
					}
				}
				RefEmitPermissionSet[] array2 = new RefEmitPermissionSet[this.permissions.Length + 1];
				this.permissions.CopyTo(array2, 0);
				this.permissions = array2;
			}
			else
			{
				this.permissions = new RefEmitPermissionSet[1];
			}
			this.permissions[this.permissions.Length - 1] = new RefEmitPermissionSet(action, pset.ToXml().ToString());
			this.attrs |= TypeAttributes.HasSecurity;
		}

		/// <summary>Добавляет интерфейс, реализуемый данным типом.</summary>
		/// <param name="interfaceType">Интерфейс, реализуемый данным типом.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="interfaceType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x0600529C RID: 21148 RVA: 0x001032CC File Offset: 0x001014CC
		[ComVisible(true)]
		public void AddInterfaceImplementation(Type interfaceType)
		{
			if (interfaceType == null)
			{
				throw new ArgumentNullException("interfaceType");
			}
			this.check_not_created();
			if (this.interfaces != null)
			{
				Type[] array = this.interfaces;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == interfaceType)
					{
						return;
					}
				}
				Type[] array2 = new Type[this.interfaces.Length + 1];
				this.interfaces.CopyTo(array2, 0);
				array2[this.interfaces.Length] = interfaceType;
				this.interfaces = array2;
				return;
			}
			this.interfaces = new Type[1];
			this.interfaces[0] = interfaceType;
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x00103364 File Offset: 0x00101564
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			this.check_created();
			if (!(this.created == typeof(object)))
			{
				return this.created.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);
			}
			if (this.ctors == null)
			{
				return null;
			}
			ConstructorBuilder constructorBuilder = null;
			int num = 0;
			foreach (ConstructorBuilder constructorBuilder2 in this.ctors)
			{
				if (callConvention == CallingConventions.Any || constructorBuilder2.CallingConvention == callConvention)
				{
					constructorBuilder = constructorBuilder2;
					num++;
				}
			}
			if (num == 0)
			{
				return null;
			}
			if (types != null)
			{
				MethodBase[] array2 = new MethodBase[num];
				if (num == 1)
				{
					array2[0] = constructorBuilder;
				}
				else
				{
					num = 0;
					foreach (ConstructorBuilder constructorInfo in this.ctors)
					{
						if (callConvention == CallingConventions.Any || constructorInfo.CallingConvention == callConvention)
						{
							array2[num++] = constructorInfo;
						}
					}
				}
				if (binder == null)
				{
					binder = Type.DefaultBinder;
				}
				return (ConstructorInfo)binder.SelectMethod(bindingAttr, array2, types, modifiers);
			}
			if (num > 1)
			{
				throw new AmbiguousMatchException();
			}
			return constructorBuilder;
		}

		/// <summary>Определяет, применяется ли пользовательский атрибут к текущему типу.</summary>
		/// <param name="attributeType">Искомый тип атрибута. Возвращаются только те атрибуты, которые можно назначить этому типу.</param>
		/// <param name="inherit">Определяет необходимость поиска цепочки наследования этого элемента для поиска атрибутов.</param>
		/// <returns>Значение <see langword="true" />, если один или несколько экземпляров <paramref name="attributeType" /> или атрибут, производный от <paramref name="attributeType" />, определен для этого типа; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается для неполных типов. Извлеките тип с помощью <see cref="M:System.Type.GetType" /> и вызовите <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> в возвращенном типе <see cref="T:System.Type" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> не определен.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="attributeType" /> — <see langword="null" />.</exception>
		// Token: 0x0600529E RID: 21150 RVA: 0x0010345F File Offset: 0x0010165F
		[SecuritySafeCritical]
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			if (!this.is_created)
			{
				throw new NotSupportedException();
			}
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		/// <summary>Возвращает все пользовательские атрибуты, определенные для данного типа.</summary>
		/// <param name="inherit">Определяет необходимость поиска цепочки наследования этого элемента для поиска атрибутов.</param>
		/// <returns>Возвращает массив объектов, предоставляющих все пользовательские атрибуты данного типа.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается для неполных типов. Извлечение типа выполняется с помощью метода <see cref="M:System.Type.GetType" />, а затем вызывается<see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> на возвращенном типе <see cref="T:System.Type" />.</exception>
		// Token: 0x0600529F RID: 21151 RVA: 0x00103477 File Offset: 0x00101677
		[SecuritySafeCritical]
		public override object[] GetCustomAttributes(bool inherit)
		{
			this.check_created();
			return this.created.GetCustomAttributes(inherit);
		}

		/// <summary>Возвращает все пользовательские атрибуты текущего типа, которые можно назначить для указанного типа.</summary>
		/// <param name="attributeType">Искомый тип атрибута. Возвращаются только те атрибуты, которые можно назначить этому типу.</param>
		/// <param name="inherit">Определяет необходимость поиска цепочки наследования этого элемента для поиска атрибутов.</param>
		/// <returns>Массив пользовательских атрибутов, определенных для текущего типа.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается для неполных типов. Извлеките тип с помощью <see cref="M:System.Type.GetType" /> и вызовите <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> в возвращенном типе <see cref="T:System.Type" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="attributeType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Он должен быть типом, предоставленным базовой системой среды выполнения.</exception>
		// Token: 0x060052A0 RID: 21152 RVA: 0x0010348B File Offset: 0x0010168B
		[SecuritySafeCritical]
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			this.check_created();
			return this.created.GetCustomAttributes(attributeType, inherit);
		}

		/// <summary>Определяет вложенный тип с данным именем.</summary>
		/// <param name="name">Краткое имя типа. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <returns>Определенный вложенный тип.</returns>
		/// <exception cref="T:System.ArgumentException">Длина <paramref name="name" /> равна нулю или превышает 1023.  
		/// -или- 
		/// Эта операция создаст тип с повторяющимся <see cref="P:System.Reflection.Emit.TypeBuilder.FullName" /> в текущей сборке.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x060052A1 RID: 21153 RVA: 0x001034A0 File Offset: 0x001016A0
		public TypeBuilder DefineNestedType(string name)
		{
			return this.DefineNestedType(name, TypeAttributes.NestedPrivate, this.pmodule.assemblyb.corlib_object_type, null);
		}

		/// <summary>Определяет вложенный тип с данными именем и атрибутами.</summary>
		/// <param name="name">Краткое имя типа. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attr">Атрибуты типа.</param>
		/// <returns>Определенный вложенный тип.</returns>
		/// <exception cref="T:System.ArgumentException">Не указан вложенный атрибут.  
		/// -или- 
		/// Этот тип запечатан.  
		/// -или- 
		/// Этот тип является массивом.  
		/// -или- 
		/// Этот тип является интерфейсом, а вложенный тип не является интерфейсом.  
		/// -или- 
		/// Длина <paramref name="name" /> равна нулю или больше 1023.  
		/// -или- 
		/// Эта операция создаст тип с повторяющимся <see cref="P:System.Reflection.Emit.TypeBuilder.FullName" /> в текущей сборке.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x060052A2 RID: 21154 RVA: 0x001034BB File Offset: 0x001016BB
		public TypeBuilder DefineNestedType(string name, TypeAttributes attr)
		{
			return this.DefineNestedType(name, attr, this.pmodule.assemblyb.corlib_object_type, null);
		}

		/// <summary>Определяет вложенный тип с данными именем, атрибутами и расширяемым типом.</summary>
		/// <param name="name">Краткое имя типа. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attr">Атрибуты типа.</param>
		/// <param name="parent">Тип, расширяемый данным вложенным типом.</param>
		/// <returns>Определенный вложенный тип.</returns>
		/// <exception cref="T:System.ArgumentException">Не указан вложенный атрибут.  
		/// -или- 
		/// Этот тип запечатан.  
		/// -или- 
		/// Этот тип является массивом.  
		/// -или- 
		/// Этот тип является интерфейсом, а вложенный тип не является интерфейсом.  
		/// -или- 
		/// Длина <paramref name="name" /> равна нулю или больше 1023.  
		/// -или- 
		/// Эта операция создаст тип с повторяющимся <see cref="P:System.Reflection.Emit.TypeBuilder.FullName" /> в текущей сборке.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x060052A3 RID: 21155 RVA: 0x001034D6 File Offset: 0x001016D6
		public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent)
		{
			return this.DefineNestedType(name, attr, parent, null);
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x001034E4 File Offset: 0x001016E4
		private TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, Type[] interfaces, PackingSize packSize, int typeSize)
		{
			if (interfaces != null)
			{
				for (int i = 0; i < interfaces.Length; i++)
				{
					if (interfaces[i] == null)
					{
						throw new ArgumentNullException("interfaces");
					}
				}
			}
			TypeBuilder typeBuilder = new TypeBuilder(this.pmodule, name, attr, parent, interfaces, packSize, typeSize, this);
			typeBuilder.fullname = typeBuilder.GetFullName();
			this.pmodule.RegisterTypeName(typeBuilder, typeBuilder.fullname);
			if (this.subtypes != null)
			{
				TypeBuilder[] array = new TypeBuilder[this.subtypes.Length + 1];
				Array.Copy(this.subtypes, array, this.subtypes.Length);
				array[this.subtypes.Length] = typeBuilder;
				this.subtypes = array;
			}
			else
			{
				this.subtypes = new TypeBuilder[1];
				this.subtypes[0] = typeBuilder;
			}
			return typeBuilder;
		}

		/// <summary>Определяет вложенный тип для расширения заданного типа с данными именем, атрибутами, расширяемым типом и реализуемыми интерфейсами.</summary>
		/// <param name="name">Краткое имя типа. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attr">Атрибуты типа.</param>
		/// <param name="parent">Тип, расширяемый вложенным типом.</param>
		/// <param name="interfaces">Интерфейсы, реализуемые данным вложенным типом.</param>
		/// <returns>Определенный вложенный тип.</returns>
		/// <exception cref="T:System.ArgumentException">Не указан вложенный атрибут.  
		/// -или- 
		/// Этот тип запечатан.  
		/// -или- 
		/// Этот тип является массивом.  
		/// -или- 
		/// Этот тип является интерфейсом, а вложенный тип не является интерфейсом.  
		/// -или- 
		/// Длина <paramref name="name" /> равна нулю или больше 1023.  
		/// -или- 
		/// Эта операция создаст тип с повторяющимся <see cref="P:System.Reflection.Emit.TypeBuilder.FullName" /> в текущей сборке.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		/// Элементом массива <paramref name="interfaces" /> является <see langword="null" />.</exception>
		// Token: 0x060052A5 RID: 21157 RVA: 0x001035A6 File Offset: 0x001017A6
		[ComVisible(true)]
		public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, Type[] interfaces)
		{
			return this.DefineNestedType(name, attr, parent, interfaces, PackingSize.Unspecified, 0);
		}

		/// <summary>Определяет вложенный тип с данными именем, атрибутами, общим размером типа и расширяемым типом.</summary>
		/// <param name="name">Краткое имя типа. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attr">Атрибуты типа.</param>
		/// <param name="parent">Тип, расширяемый данным вложенным типом.</param>
		/// <param name="typeSize">Общий размер типа.</param>
		/// <returns>Определенный вложенный тип.</returns>
		/// <exception cref="T:System.ArgumentException">Не указан вложенный атрибут.  
		/// -или- 
		/// Этот тип запечатан.  
		/// -или- 
		/// Этот тип является массивом.  
		/// -или- 
		/// Этот тип является интерфейсом, а вложенный тип не является интерфейсом.  
		/// -или- 
		/// Длина <paramref name="name" /> равна нулю или больше 1023.  
		/// -или- 
		/// Эта операция создаст тип с повторяющимся <see cref="P:System.Reflection.Emit.TypeBuilder.FullName" /> в текущей сборке.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x060052A6 RID: 21158 RVA: 0x001035B5 File Offset: 0x001017B5
		public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, int typeSize)
		{
			return this.DefineNestedType(name, attr, parent, null, PackingSize.Unspecified, typeSize);
		}

		/// <summary>Определяет вложенный тип с данными именем, атрибутами, расширяемым им типом и упаковочным размером.</summary>
		/// <param name="name">Краткое имя типа. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attr">Атрибуты типа.</param>
		/// <param name="parent">Тип, который вложенный тип расширяет.</param>
		/// <param name="packSize">Размер упаковки типа.</param>
		/// <returns>Определенный вложенный тип.</returns>
		/// <exception cref="T:System.ArgumentException">Не указан вложенный атрибут.  
		/// -или- 
		/// Этот тип запечатан.  
		/// -или- 
		/// Этот тип является массивом.  
		/// -или- 
		/// Этот тип является интерфейсом, а вложенный тип не является интерфейсом.  
		/// -или- 
		/// Длина <paramref name="name" /> равна нулю или больше 1023.  
		/// -или- 
		/// Эта операция создаст тип с повторяющимся <see cref="P:System.Reflection.Emit.TypeBuilder.FullName" /> в текущей сборке.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		// Token: 0x060052A7 RID: 21159 RVA: 0x001035C4 File Offset: 0x001017C4
		public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, PackingSize packSize)
		{
			return this.DefineNestedType(name, attr, parent, null, packSize, 0);
		}

		/// <summary>Определяет вложенный тип с данным именем, атрибутами, размером и расширяемым типом.</summary>
		/// <param name="name">Краткое имя типа. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="attr">Атрибуты типа.</param>
		/// <param name="parent">Тип, который вложенный тип расширяет.</param>
		/// <param name="packSize">Размер упаковки типа.</param>
		/// <param name="typeSize">Общий размер типа.</param>
		/// <returns>Определенный вложенный тип.</returns>
		// Token: 0x060052A8 RID: 21160 RVA: 0x001035D3 File Offset: 0x001017D3
		public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, PackingSize packSize, int typeSize)
		{
			return this.DefineNestedType(name, attr, parent, null, packSize, typeSize);
		}

		/// <summary>Добавляет в тип новый конструктор с данными атрибутами и сигнатурой.</summary>
		/// <param name="attributes">Атрибуты конструктора.</param>
		/// <param name="callingConvention">Соглашение о вызовах конструктора.</param>
		/// <param name="parameterTypes">Типы параметров конструктора.</param>
		/// <returns>Определенный конструктор.</returns>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x060052A9 RID: 21161 RVA: 0x001035E3 File Offset: 0x001017E3
		[ComVisible(true)]
		public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes)
		{
			return this.DefineConstructor(attributes, callingConvention, parameterTypes, null, null);
		}

		/// <summary>Добавляет в тип новый конструктор с данными атрибутами, сигнатурой и пользовательскими модификаторами.</summary>
		/// <param name="attributes">Атрибуты конструктора.</param>
		/// <param name="callingConvention">Соглашение о вызовах конструктора.</param>
		/// <param name="parameterTypes">Типы параметров конструктора.</param>
		/// <param name="requiredCustomModifiers">Массив массивов типов. Каждый массив типов представляет обязательные настраиваемые модификаторы для соответствующего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />. Если определенный параметр не имеет обязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов. Если ни один из параметров не имеет обязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов.</param>
		/// <param name="optionalCustomModifiers">Массив массивов типов. Каждый массив типов представляет необязательные настраиваемые модификаторы для соответствующего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />. Если определенный параметр не имеет необязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов. Если ни один из параметров не содержит необязательные пользовательские модификаторы, вместо массива массивов нужно задать значение <see langword="null" />.</param>
		/// <returns>Определенный конструктор.</returns>
		/// <exception cref="T:System.ArgumentException">Размер <paramref name="requiredCustomModifiers" /> или <paramref name="optionalCustomModifiers" /> не равен размеру <paramref name="parameterTypes" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот тип был создан ранее с помощью <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		/// Для текущего динамического типа значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> равно <see langword="true" />, однако значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> равно <see langword="false" />.</exception>
		// Token: 0x060052AA RID: 21162 RVA: 0x001035F0 File Offset: 0x001017F0
		[ComVisible(true)]
		public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers)
		{
			this.check_not_created();
			ConstructorBuilder constructorBuilder = new ConstructorBuilder(this, attributes, callingConvention, parameterTypes, requiredCustomModifiers, optionalCustomModifiers);
			if (this.ctors != null)
			{
				ConstructorBuilder[] array = new ConstructorBuilder[this.ctors.Length + 1];
				Array.Copy(this.ctors, array, this.ctors.Length);
				array[this.ctors.Length] = constructorBuilder;
				this.ctors = array;
			}
			else
			{
				this.ctors = new ConstructorBuilder[1];
				this.ctors[0] = constructorBuilder;
			}
			return constructorBuilder;
		}

		/// <summary>Определяет конструктор по умолчанию. Конструктор, определенный здесь, просто вызывает конструктор по умолчанию для родительского класса.</summary>
		/// <param name="attributes">Объект <see langword="MethodAttributes" />, представляющий атрибуты, которые нужно применить к конструктору.</param>
		/// <returns>Возвращает конструктор.</returns>
		/// <exception cref="T:System.NotSupportedException">В родительском типе (базовый тип) отсутствует конструктор по умолчанию.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		/// Для текущего динамического типа значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> равно <see langword="true" />, однако значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> равно <see langword="false" />.</exception>
		// Token: 0x060052AB RID: 21163 RVA: 0x00103668 File Offset: 0x00101868
		[ComVisible(true)]
		public ConstructorBuilder DefineDefaultConstructor(MethodAttributes attributes)
		{
			Type type;
			if (this.parent != null)
			{
				type = this.parent;
			}
			else
			{
				type = this.pmodule.assemblyb.corlib_object_type;
			}
			Type type2 = type;
			type = type.InternalResolve();
			if (type == typeof(object) || type == typeof(ValueType))
			{
				type = type2;
			}
			ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			if (constructor == null)
			{
				throw new NotSupportedException("Parent does not have a default constructor. The default constructor must be explicitly defined.");
			}
			ConstructorBuilder constructorBuilder = this.DefineConstructor(attributes, CallingConventions.Standard, Type.EmptyTypes);
			ILGenerator ilgenerator = constructorBuilder.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Call, constructor);
			ilgenerator.Emit(OpCodes.Ret);
			return constructorBuilder;
		}

		// Token: 0x060052AC RID: 21164 RVA: 0x00103724 File Offset: 0x00101924
		private void append_method(MethodBuilder mb)
		{
			if (this.methods != null)
			{
				if (this.methods.Length == this.num_methods)
				{
					MethodBuilder[] destinationArray = new MethodBuilder[this.methods.Length * 2];
					Array.Copy(this.methods, destinationArray, this.num_methods);
					this.methods = destinationArray;
				}
			}
			else
			{
				this.methods = new MethodBuilder[1];
			}
			this.methods[this.num_methods] = mb;
			this.num_methods++;
		}

		/// <summary>Добавляет в тип новый метод с данными именем, атрибутами метода и сигнатурой метода.</summary>
		/// <param name="name">Имя метода. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attributes">Атрибуты метода.</param>
		/// <param name="returnType">Тип возвращаемого значения метода.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <returns>Определенный метод.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.  
		/// -или- 
		/// Тип родительского элемента данного метода — интерфейс, и этот метод не является виртуальным (<see langword="Overridable" /> в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		/// Для текущего динамического типа значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> равно <see langword="true" />, однако значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> равно <see langword="false" />.</exception>
		// Token: 0x060052AD RID: 21165 RVA: 0x0010379C File Offset: 0x0010199C
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes)
		{
			return this.DefineMethod(name, attributes, CallingConventions.Standard, returnType, parameterTypes);
		}

		/// <summary>Добавляет в тип новый метод с указанным именем, атрибутами метода, соглашением о вызове и сигнатурой метода.</summary>
		/// <param name="name">Имя метода. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attributes">Атрибуты метода.</param>
		/// <param name="callingConvention">Соглашение о вызове метода.</param>
		/// <param name="returnType">Тип возвращаемого значения метода.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <returns>
		///   <see cref="T:System.Reflection.Emit.MethodBuilder" /> представляет собой новый определенный метод.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.  
		/// -или- 
		/// Тип родительского элемента данного метода — интерфейс, и этот метод не является виртуальным (<see langword="Overridable" /> в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		/// Для текущего динамического типа значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> равно <see langword="true" />, однако значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> равно <see langword="false" />.</exception>
		// Token: 0x060052AE RID: 21166 RVA: 0x001037AC File Offset: 0x001019AC
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
		{
			return this.DefineMethod(name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null);
		}

		/// <summary>Добавляет в тип новый метод с указанным именем, атрибутами метода, соглашением о вызове, сигнатурой метода и пользовательскими модификаторами.</summary>
		/// <param name="name">Имя метода. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attributes">Атрибуты метода.</param>
		/// <param name="callingConvention">Соглашение о вызове метода.</param>
		/// <param name="returnType">Тип возвращаемого значения метода.</param>
		/// <param name="returnTypeRequiredCustomModifiers">Массив типов представляет собой требуемые пользовательские модификаторы для поля, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> для типа возвращаемых значений метода. Если возвращаемый тип не содержит требуемых настраиваемых модификаторов, укажите <see langword="null" />.</param>
		/// <param name="returnTypeOptionalCustomModifiers">Массив типов, представляющих необязательные настраиваемые модификаторы, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />, для возвращаемого типа метода. Если возвращаемый тип не содержит необязательных настраиваемых модификаторов, укажите <see langword="null" />.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <param name="parameterTypeRequiredCustomModifiers">Массив массивов типов. Каждый массив типов представляет обязательные настраиваемые модификаторы для соответствующего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />. Если определенный параметр не имеет обязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов. Если ни один из параметров не имеет обязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов.</param>
		/// <param name="parameterTypeOptionalCustomModifiers">Массив массивов типов. Каждый массив типов представляет необязательные настраиваемые модификаторы для соответствующего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />. Если определенный параметр не имеет необязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов. Если ни один из параметров не содержит необязательные пользовательские модификаторы, вместо массива массивов нужно задать значение <see langword="null" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.MethodBuilder" />, представляющий новый, добавленный метод.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.  
		/// -или- 
		/// Родительский тип данного метода — интерфейс, и данный метод не является виртуальным (<see langword="Overridable" /> в Visual Basic).  
		/// -или- 
		/// Размер <paramref name="parameterTypeRequiredCustomModifiers" /> или <paramref name="parameterTypeOptionalCustomModifiers" /> не равен размеру <paramref name="parameterTypes" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		/// Для текущего динамического типа значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> равно <see langword="true" />, однако значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> равно <see langword="false" />.</exception>
		// Token: 0x060052AF RID: 21167 RVA: 0x001037CC File Offset: 0x001019CC
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
		{
			this.check_name("name", name);
			this.check_not_created();
			if (base.IsInterface && ((attributes & MethodAttributes.Abstract) == MethodAttributes.PrivateScope || (attributes & MethodAttributes.Virtual) == MethodAttributes.PrivateScope) && (attributes & MethodAttributes.Static) == MethodAttributes.PrivateScope)
			{
				throw new ArgumentException("Interface method must be abstract and virtual.");
			}
			if (returnType == null)
			{
				returnType = this.pmodule.assemblyb.corlib_void_type;
			}
			MethodBuilder methodBuilder = new MethodBuilder(this, name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
			this.append_method(methodBuilder);
			return methodBuilder;
		}

		/// <summary>Определяет метод <see langword="PInvoke" />, задавая его имя, имя DLL, в котором этот метод определен, имя точки входа, атрибуты метода, соглашение о вызовах, возвращаемый тип, типы параметров метода и <see langword="PInvoke" />-флаги.</summary>
		/// <param name="name">Имя метода <see langword="PInvoke" />. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="dllName">Имя библиотеки DLL, в которой определен метод <see langword="PInvoke" />.</param>
		/// <param name="entryName">Имя точки входа в библиотеке DLL.</param>
		/// <param name="attributes">Атрибуты метода.</param>
		/// <param name="callingConvention">Соглашение о вызове метода.</param>
		/// <param name="returnType">Возвращаемый тип метода.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <param name="nativeCallConv">Собственное соглашение о вызове.</param>
		/// <param name="nativeCharSet">Присущий данному объекту набор символов метода.</param>
		/// <returns>Определенный метод <see langword="PInvoke" />.</returns>
		/// <exception cref="T:System.ArgumentException">Данный метод не является статическим.  
		/// -или- 
		/// Родительский тип является интерфейсом.  
		/// -или- 
		/// Метод является абстрактным.  
		/// -или- 
		/// Метод был определен ранее.  
		/// -или- 
		/// Длина параметра <paramref name="name" />, <paramref name="dllName" /> или <paramref name="entryName" /> равна нулю.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="name" />, <paramref name="dllName" /> или <paramref name="entryName" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x060052B0 RID: 21168 RVA: 0x00103850 File Offset: 0x00101A50
		public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
		{
			return this.DefinePInvokeMethod(name, dllName, entryName, attributes, callingConvention, returnType, null, null, parameterTypes, null, null, nativeCallConv, nativeCharSet);
		}

		/// <summary>Определяет метод <see langword="PInvoke" /> по имени, имени библиотеки DLL, в которой определен метод, имени точки входа, атрибутам метода, соглашению о вызове метода, типу возвращаемых этим методом значений, типам параметров метода, флагам <see langword="PInvoke" /> и пользовательским модификаторам параметров и типа возвращаемых данных.</summary>
		/// <param name="name">Имя метода <see langword="PInvoke" />. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="dllName">Имя библиотеки DLL, в которой определен метод <see langword="PInvoke" />.</param>
		/// <param name="entryName">Имя точки входа в библиотеке DLL.</param>
		/// <param name="attributes">Атрибуты метода.</param>
		/// <param name="callingConvention">Соглашение о вызове метода.</param>
		/// <param name="returnType">Возвращаемый тип метода.</param>
		/// <param name="returnTypeRequiredCustomModifiers">Массив типов, представляющих обязательные настраиваемые модификаторы, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />, для возвращаемого типа метода. Если возвращаемый тип не содержит требуемых настраиваемых модификаторов, укажите <see langword="null" />.</param>
		/// <param name="returnTypeOptionalCustomModifiers">Массив типов, представляющих необязательные настраиваемые модификаторы, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />, для возвращаемого типа метода. Если возвращаемый тип не содержит необязательные настраиваемые модификаторы, укажите <see langword="null" />.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <param name="parameterTypeRequiredCustomModifiers">Массив массивов типов. Каждый массив типов представляет обязательные настраиваемые модификаторы для соответствующего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />. Если определенный параметр не имеет обязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов. Если ни один из параметров не имеет обязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов.</param>
		/// <param name="parameterTypeOptionalCustomModifiers">Массив массивов типов. Каждый массив типов представляет необязательные настраиваемые модификаторы для соответствующего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />. Если определенный параметр не имеет необязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов. Если ни один из параметров не имеет необязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива типов.</param>
		/// <param name="nativeCallConv">Собственное соглашение о вызове.</param>
		/// <param name="nativeCharSet">Присущий данному объекту набор символов метода.</param>
		/// <returns>
		///   <see cref="T:System.Reflection.Emit.MethodBuilder" />, представляющий определенный метод <see langword="PInvoke" />.</returns>
		/// <exception cref="T:System.ArgumentException">Данный метод не является статическим.  
		/// -или- 
		/// Родительский тип является интерфейсом.  
		/// -или- 
		/// Метод является абстрактным.  
		/// -или- 
		/// Метод был определен ранее.  
		/// -или- 
		/// Длина <paramref name="name" />, <paramref name="dllName" /> или <paramref name="entryName" /> равна нулю.  
		/// -или- 
		/// Размер <paramref name="parameterTypeRequiredCustomModifiers" /> или <paramref name="parameterTypeOptionalCustomModifiers" /> не равен размеру <paramref name="parameterTypes" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" />, <paramref name="dllName" /> или <paramref name="entryName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		/// Для текущего динамического типа значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> равно <see langword="true" />, однако значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> равно <see langword="false" />.</exception>
		// Token: 0x060052B1 RID: 21169 RVA: 0x00103878 File Offset: 0x00101A78
		public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers, CallingConvention nativeCallConv, CharSet nativeCharSet)
		{
			this.check_name("name", name);
			this.check_name("dllName", dllName);
			this.check_name("entryName", entryName);
			if ((attributes & MethodAttributes.Abstract) != MethodAttributes.PrivateScope)
			{
				throw new ArgumentException("PInvoke methods must be static and native and cannot be abstract.");
			}
			if (base.IsInterface)
			{
				throw new ArgumentException("PInvoke methods cannot exist on interfaces.");
			}
			this.check_not_created();
			MethodBuilder methodBuilder = new MethodBuilder(this, name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers, dllName, entryName, nativeCallConv, nativeCharSet);
			this.append_method(methodBuilder);
			return methodBuilder;
		}

		/// <summary>Определяет метод <see langword="PInvoke" />, задавая его имя, имя DLL, в котором этот метод определен, атрибуты метода, соглашение о вызовах, возвращаемый тип, типы параметров метода и <see langword="PInvoke" />-флаги.</summary>
		/// <param name="name">Имя метода <see langword="PInvoke" />. Параметр <paramref name="name" /> не может содержать внедренные значения NULL.</param>
		/// <param name="dllName">Имя библиотеки DLL, в которой определен метод <see langword="PInvoke" />.</param>
		/// <param name="attributes">Атрибуты метода.</param>
		/// <param name="callingConvention">Соглашение о вызове метода.</param>
		/// <param name="returnType">Возвращаемый тип метода.</param>
		/// <param name="parameterTypes">Типы параметров метода.</param>
		/// <param name="nativeCallConv">Собственное соглашение о вызове.</param>
		/// <param name="nativeCharSet">Присущий данному объекту набор символов метода.</param>
		/// <returns>Определенный метод <see langword="PInvoke" />.</returns>
		/// <exception cref="T:System.ArgumentException">Данный метод не является статическим.  
		/// -или- 
		/// Родительский тип является интерфейсом.  
		/// -или- 
		/// Метод является абстрактным.  
		/// -или- 
		/// Метод был определен ранее.  
		/// -или- 
		/// Длина параметра <paramref name="name" /> или <paramref name="dllName" /> равна нулю.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="dllName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x060052B2 RID: 21170 RVA: 0x00103900 File Offset: 0x00101B00
		public MethodBuilder DefinePInvokeMethod(string name, string dllName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet)
		{
			return this.DefinePInvokeMethod(name, dllName, name, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet);
		}

		/// <summary>Добавляет в тип новый метод с данными именем и атрибутами метода.</summary>
		/// <param name="name">Имя метода. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attributes">Атрибуты метода.</param>
		/// <returns>
		///   <see cref="T:System.Reflection.Emit.MethodBuilder" /> представляет собой новый определенный метод.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.  
		/// -или- 
		/// Тип родительского элемента данного метода — интерфейс, и этот метод не является виртуальным (<see langword="Overridable" /> в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		/// Для текущего динамического типа значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> равно <see langword="true" />, однако значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> равно <see langword="false" />.</exception>
		// Token: 0x060052B3 RID: 21171 RVA: 0x00103921 File Offset: 0x00101B21
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes)
		{
			return this.DefineMethod(name, attributes, CallingConventions.Standard);
		}

		/// <summary>Добавляет в тип новый метод с указанным именем, атрибутами метода и соглашением о вызове.</summary>
		/// <param name="name">Имя метода. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attributes">Атрибуты метода.</param>
		/// <param name="callingConvention">Соглашение о вызове метода.</param>
		/// <returns>
		///   <see cref="T:System.Reflection.Emit.MethodBuilder" /> представляет собой новый определенный метод.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.  
		/// -или- 
		/// Тип родительского элемента данного метода является интерфейсом, и этот метод не является виртуальным (<see langword="Overridable" /> в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		/// Для текущего динамического типа значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> равно <see langword="true" />, однако значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> равно <see langword="false" />.</exception>
		// Token: 0x060052B4 RID: 21172 RVA: 0x0010392C File Offset: 0x00101B2C
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention)
		{
			return this.DefineMethod(name, attributes, callingConvention, null, null);
		}

		/// <summary>Задает основной текст метода, реализующий данное объявление метода, возможно, под другим именем.</summary>
		/// <param name="methodInfoBody">Используемый основной текст метода. Должно быть объектом <see langword="MethodBuilder" />.</param>
		/// <param name="methodInfoDeclaration">Метод, объявления которого используются.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="methodInfoBody" /> не принадлежит к этому классу.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="methodInfoBody" /> или <paramref name="methodInfoDeclaration" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		/// Объявляемый тип <paramref name="methodInfoBody" /> не является типом, представленным <see cref="T:System.Reflection.Emit.TypeBuilder" />.</exception>
		// Token: 0x060052B5 RID: 21173 RVA: 0x0010393C File Offset: 0x00101B3C
		public void DefineMethodOverride(MethodInfo methodInfoBody, MethodInfo methodInfoDeclaration)
		{
			if (methodInfoBody == null)
			{
				throw new ArgumentNullException("methodInfoBody");
			}
			if (methodInfoDeclaration == null)
			{
				throw new ArgumentNullException("methodInfoDeclaration");
			}
			this.check_not_created();
			if (methodInfoBody.DeclaringType != this)
			{
				throw new ArgumentException("method body must belong to this type");
			}
			if (methodInfoBody is MethodBuilder)
			{
				((MethodBuilder)methodInfoBody).set_override(methodInfoDeclaration);
			}
		}

		/// <summary>Добавляет в тип новое поле с данными именем, атрибутами и типом поля.</summary>
		/// <param name="fieldName">Имя поля. Параметр <paramref name="fieldName" /> не может содержать внедренные значения NULL.</param>
		/// <param name="type">Тип поля.</param>
		/// <param name="attributes">Атрибуты поля.</param>
		/// <returns>Определенное в результате поле.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="fieldName" /> равна нулю.  
		/// -или- 
		///  Параметр <paramref name="type" /> имеет значение System.Void.  
		/// -или- 
		/// Общий размер был указан для родительского класса этого поля.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="fieldName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x060052B6 RID: 21174 RVA: 0x001039A4 File Offset: 0x00101BA4
		public FieldBuilder DefineField(string fieldName, Type type, FieldAttributes attributes)
		{
			return this.DefineField(fieldName, type, null, null, attributes);
		}

		/// <summary>Добавляет в тип новое поле с данными именем, атрибутами, типом поля и пользовательскими модификаторами.</summary>
		/// <param name="fieldName">Имя поля. Параметр <paramref name="fieldName" /> не может содержать внедренные значения NULL.</param>
		/// <param name="type">Тип поля.</param>
		/// <param name="requiredCustomModifiers">Массив типов, представляющих обязательные настраиваемые модификаторы для поля, например <see cref="T:Microsoft.VisualC.IsConstModifier" />.</param>
		/// <param name="optionalCustomModifiers">Массив типов, представляющих необязательные настраиваемые модификаторы для поля, например <see cref="T:Microsoft.VisualC.IsConstModifier" />.</param>
		/// <param name="attributes">Атрибуты поля.</param>
		/// <returns>Определенное в результате поле.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="fieldName" /> равна нулю.  
		/// -или- 
		///  Параметр <paramref name="type" /> имеет значение System.Void.  
		/// -или- 
		/// Общий размер был указан для родительского класса этого поля.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="fieldName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x060052B7 RID: 21175 RVA: 0x001039B4 File Offset: 0x00101BB4
		public FieldBuilder DefineField(string fieldName, Type type, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers, FieldAttributes attributes)
		{
			this.check_name("fieldName", fieldName);
			if (type == typeof(void))
			{
				throw new ArgumentException("Bad field type in defining field.");
			}
			this.check_not_created();
			FieldBuilder fieldBuilder = new FieldBuilder(this, fieldName, type, attributes, requiredCustomModifiers, optionalCustomModifiers);
			if (this.fields != null)
			{
				if (this.fields.Length == this.num_fields)
				{
					FieldBuilder[] destinationArray = new FieldBuilder[this.fields.Length * 2];
					Array.Copy(this.fields, destinationArray, this.num_fields);
					this.fields = destinationArray;
				}
				this.fields[this.num_fields] = fieldBuilder;
				this.num_fields++;
			}
			else
			{
				this.fields = new FieldBuilder[1];
				this.fields[0] = fieldBuilder;
				this.num_fields++;
			}
			if (this.IsEnum && this.underlying_type == null && (attributes & FieldAttributes.Static) == FieldAttributes.PrivateScope)
			{
				this.underlying_type = type;
			}
			return fieldBuilder;
		}

		/// <summary>Добавляет в тип новое свойство с данными именем и сигнатурой свойства.</summary>
		/// <param name="name">Имя свойства. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attributes">Атрибуты свойства.</param>
		/// <param name="returnType">Возвращаемый тип свойства.</param>
		/// <param name="parameterTypes">Типы параметров свойства.</param>
		/// <returns>Определенное свойство.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		/// Один из элементов массива <paramref name="parameterTypes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x060052B8 RID: 21176 RVA: 0x00103AA8 File Offset: 0x00101CA8
		public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, Type returnType, Type[] parameterTypes)
		{
			return this.DefineProperty(name, attributes, (CallingConventions)0, returnType, null, null, parameterTypes, null, null);
		}

		/// <summary>Добавляет в тип новое свойство с данными именем, атрибутами, соглашением о вызове и сигнатурой свойства.</summary>
		/// <param name="name">Имя свойства. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attributes">Атрибуты свойства.</param>
		/// <param name="callingConvention">Соглашение о вызовах методов доступа свойства.</param>
		/// <param name="returnType">Возвращаемый тип свойства.</param>
		/// <param name="parameterTypes">Типы параметров свойства.</param>
		/// <returns>Определенное свойство.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		/// Один из элементов массива <paramref name="parameterTypes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x060052B9 RID: 21177 RVA: 0x00103AC8 File Offset: 0x00101CC8
		public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
		{
			return this.DefineProperty(name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null);
		}

		/// <summary>Добавляет в тип новое свойство с данными именем, сигнатурой свойства и пользовательскими модификаторами.</summary>
		/// <param name="name">Имя свойства. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attributes">Атрибуты свойства.</param>
		/// <param name="returnType">Возвращаемый тип свойства.</param>
		/// <param name="returnTypeRequiredCustomModifiers">Массив типов, представляющих обязательные настраиваемые модификаторы, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />, для возвращаемого типа свойства. Если возвращаемый тип не содержит требуемых настраиваемых модификаторов, укажите <see langword="null" />.</param>
		/// <param name="returnTypeOptionalCustomModifiers">Массив типов, представляющих необязательные настраиваемые модификаторы, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />, для возвращаемого типа свойства. Если у типа возвращаемого значения нет необязательных пользовательских модификаторов, укажите значение <see langword="null" />.</param>
		/// <param name="parameterTypes">Типы параметров свойства.</param>
		/// <param name="parameterTypeRequiredCustomModifiers">Массив массивов типов. Каждый массив типов представляет обязательные настраиваемые модификаторы для соответствующего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />. Если определенный параметр не имеет обязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов. Если ни один из параметров не имеет обязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов.</param>
		/// <param name="parameterTypeOptionalCustomModifiers">Массив массивов типов. Каждый массив типов представляет необязательные настраиваемые модификаторы для соответствующего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />. Если определенный параметр не имеет необязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов. Если ни один из параметров не содержит необязательные пользовательские модификаторы, вместо массива массивов нужно задать значение <see langword="null" />.</param>
		/// <returns>Определенное свойство.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> равно <see langword="null" />  
		/// -или- 
		/// Один из элементов массива <paramref name="parameterTypes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x060052BA RID: 21178 RVA: 0x00103AE8 File Offset: 0x00101CE8
		public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
		{
			return this.DefineProperty(name, attributes, (CallingConventions)0, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
		}

		/// <summary>Добавляет в тип новое свойство с данными именем, соглашением о вызове, сигнатурой свойства и пользовательскими модификаторами.</summary>
		/// <param name="name">Имя свойства. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attributes">Атрибуты свойства.</param>
		/// <param name="callingConvention">Соглашение о вызовах методов доступа свойства.</param>
		/// <param name="returnType">Возвращаемый тип свойства.</param>
		/// <param name="returnTypeRequiredCustomModifiers">Массив типов, представляющих обязательные настраиваемые модификаторы, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />, для возвращаемого типа свойства. Если возвращаемый тип не содержит требуемых настраиваемых модификаторов, укажите <see langword="null" />.</param>
		/// <param name="returnTypeOptionalCustomModifiers">Массив типов, представляющих необязательные настраиваемые модификаторы, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />, для возвращаемого типа свойства. Если у типа возвращаемого значения нет необязательных пользовательских модификаторов, укажите значение <see langword="null" />.</param>
		/// <param name="parameterTypes">Типы параметров свойства.</param>
		/// <param name="parameterTypeRequiredCustomModifiers">Массив массивов типов. Каждый массив типов представляет обязательные настраиваемые модификаторы для соответствующего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />. Если определенный параметр не имеет обязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов. Если ни один из параметров не имеет обязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов.</param>
		/// <param name="parameterTypeOptionalCustomModifiers">Массив массивов типов. Каждый массив типов представляет необязательные настраиваемые модификаторы для соответствующего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" />. Если определенный параметр не имеет необязательных настраиваемых модификаторов, укажите <see langword="null" /> вместо массива массивов. Если ни один из параметров не содержит необязательные пользовательские модификаторы, вместо массива массивов нужно задать значение <see langword="null" />.</param>
		/// <returns>Определенное свойство.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		/// Один из элементов массива <paramref name="parameterTypes" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x060052BB RID: 21179 RVA: 0x00103B0C File Offset: 0x00101D0C
		public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
		{
			this.check_name("name", name);
			if (parameterTypes != null)
			{
				for (int i = 0; i < parameterTypes.Length; i++)
				{
					if (parameterTypes[i] == null)
					{
						throw new ArgumentNullException("parameterTypes");
					}
				}
			}
			this.check_not_created();
			PropertyBuilder propertyBuilder = new PropertyBuilder(this, name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
			if (this.properties != null)
			{
				Array.Resize<PropertyBuilder>(ref this.properties, this.properties.Length + 1);
				this.properties[this.properties.Length - 1] = propertyBuilder;
			}
			else
			{
				this.properties = new PropertyBuilder[]
				{
					propertyBuilder
				};
			}
			return propertyBuilder;
		}

		/// <summary>Определяет инициализатор для данного типа.</summary>
		/// <returns>Возвращает инициализатор типа.</returns>
		/// <exception cref="T:System.InvalidOperationException">Содержащий тип был создан ранее с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x060052BC RID: 21180 RVA: 0x00103BAE File Offset: 0x00101DAE
		[ComVisible(true)]
		public ConstructorBuilder DefineTypeInitializer()
		{
			return this.DefineConstructor(MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, CallingConventions.Standard, null);
		}

		// Token: 0x060052BD RID: 21181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern TypeInfo create_runtime_class();

		// Token: 0x060052BE RID: 21182 RVA: 0x00103BBD File Offset: 0x00101DBD
		private bool is_nested_in(Type t)
		{
			while (t != null)
			{
				if (t == this)
				{
					return true;
				}
				t = t.DeclaringType;
			}
			return false;
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x00103BE0 File Offset: 0x00101DE0
		private bool has_ctor_method()
		{
			MethodAttributes methodAttributes = MethodAttributes.SpecialName | MethodAttributes.RTSpecialName;
			for (int i = 0; i < this.num_methods; i++)
			{
				MethodBuilder methodBuilder = this.methods[i];
				if (methodBuilder.Name == ConstructorInfo.ConstructorName && (methodBuilder.Attributes & methodAttributes) == methodAttributes)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Создает объект <see cref="T:System.Type" /> для данного класса. После определения полей и методов в классе вызывается метод <see langword="CreateType" /> для загрузки его объекта <see langword="Type" />.</summary>
		/// <returns>Возвращает новый объект <see cref="T:System.Type" /> для данного класса.</returns>
		/// <exception cref="T:System.InvalidOperationException">Включающий тип не был создан.  
		/// -или- 
		/// Этот тип не является абстрактным, а содержит абстрактный метод.  
		/// -или- 
		/// Этот тип не является абстрактным классом или интерфейсом, а содержит метод без тела метода.</exception>
		/// <exception cref="T:System.NotSupportedException">Тип содержит неверный код на языке MSIL.  
		/// -или- 
		/// Конечный адрес ветвления задан с использованием однобайтового смещения, но он находится на расстоянии более 127 байт от ветви.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип. Например, тип содержит метод <see langword="static" />, который имеет соглашение о вызове <see cref="F:System.Reflection.CallingConventions.HasThis" />.</exception>
		// Token: 0x060052C0 RID: 21184 RVA: 0x00103C2D File Offset: 0x00101E2D
		public Type CreateType()
		{
			return this.CreateTypeInfo();
		}

		/// <summary>Получает объект <see cref="T:System.Reflection.TypeInfo" />, представляющий данный тип.</summary>
		/// <returns>Объект, представляющий данный тип.</returns>
		// Token: 0x060052C1 RID: 21185 RVA: 0x00103C38 File Offset: 0x00101E38
		public TypeInfo CreateTypeInfo()
		{
			if (this.createTypeCalled)
			{
				return this.created;
			}
			if (!base.IsInterface && this.parent == null && this != this.pmodule.assemblyb.corlib_object_type && this.FullName != "<Module>")
			{
				this.SetParent(this.pmodule.assemblyb.corlib_object_type);
			}
			if (this.fields != null)
			{
				foreach (FieldBuilder fieldBuilder in this.fields)
				{
					if (!(fieldBuilder == null))
					{
						Type fieldType = fieldBuilder.FieldType;
						if (!fieldBuilder.IsStatic && fieldType is TypeBuilder && fieldType.IsValueType && fieldType != this && this.is_nested_in(fieldType))
						{
							TypeBuilder typeBuilder = (TypeBuilder)fieldType;
							if (!typeBuilder.is_created)
							{
								AppDomain.CurrentDomain.DoTypeBuilderResolve(typeBuilder);
								bool is_created = typeBuilder.is_created;
							}
						}
					}
				}
			}
			if (!base.IsInterface && !base.IsValueType && this.ctors == null && this.tname != "<Module>" && ((this.GetAttributeFlagsImpl() & TypeAttributes.Abstract) | TypeAttributes.Sealed) != (TypeAttributes.Abstract | TypeAttributes.Sealed) && !this.has_ctor_method())
			{
				this.DefineDefaultConstructor(MethodAttributes.Public);
			}
			this.createTypeCalled = true;
			if (this.parent != null && this.parent.IsSealed)
			{
				string[] array2 = new string[5];
				array2[0] = "Could not load type '";
				array2[1] = this.FullName;
				array2[2] = "' from assembly '";
				int num = 3;
				Assembly assembly = this.Assembly;
				array2[num] = ((assembly != null) ? assembly.ToString() : null);
				array2[4] = "' because the parent type is sealed.";
				throw new TypeLoadException(string.Concat(array2));
			}
			if (this.parent == this.pmodule.assemblyb.corlib_enum_type && this.methods != null)
			{
				string[] array3 = new string[5];
				array3[0] = "Could not load type '";
				array3[1] = this.FullName;
				array3[2] = "' from assembly '";
				int num2 = 3;
				Assembly assembly2 = this.Assembly;
				array3[num2] = ((assembly2 != null) ? assembly2.ToString() : null);
				array3[4] = "' because it is an enum with methods.";
				throw new TypeLoadException(string.Concat(array3));
			}
			if (this.interfaces != null)
			{
				foreach (Type type in this.interfaces)
				{
					if (type.IsNestedPrivate && type.Assembly != this.Assembly)
					{
						string[] array5 = new string[7];
						array5[0] = "Could not load type '";
						array5[1] = this.FullName;
						array5[2] = "' from assembly '";
						int num3 = 3;
						Assembly assembly3 = this.Assembly;
						array5[num3] = ((assembly3 != null) ? assembly3.ToString() : null);
						array5[4] = "' because it is implements the inaccessible interface '";
						array5[5] = type.FullName;
						array5[6] = "'.";
						throw new TypeLoadException(string.Concat(array5));
					}
				}
			}
			if (this.methods != null)
			{
				bool flag = !base.IsAbstract;
				for (int j = 0; j < this.num_methods; j++)
				{
					MethodBuilder methodBuilder = this.methods[j];
					if (flag && methodBuilder.IsAbstract)
					{
						string str = "Type is concrete but has abstract method ";
						MethodBuilder methodBuilder2 = methodBuilder;
						throw new InvalidOperationException(str + ((methodBuilder2 != null) ? methodBuilder2.ToString() : null));
					}
					methodBuilder.check_override();
					methodBuilder.fixup();
				}
			}
			if (this.ctors != null)
			{
				ConstructorBuilder[] array6 = this.ctors;
				for (int i = 0; i < array6.Length; i++)
				{
					array6[i].fixup();
				}
			}
			this.ResolveUserTypes();
			this.created = this.create_runtime_class();
			if (this.created != null)
			{
				return this.created;
			}
			return this;
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x00103FB4 File Offset: 0x001021B4
		private void ResolveUserTypes()
		{
			this.parent = TypeBuilder.ResolveUserType(this.parent);
			TypeBuilder.ResolveUserTypes(this.interfaces);
			if (this.fields != null)
			{
				foreach (FieldBuilder fieldBuilder in this.fields)
				{
					if (fieldBuilder != null)
					{
						fieldBuilder.ResolveUserTypes();
					}
				}
			}
			if (this.methods != null)
			{
				foreach (MethodBuilder methodBuilder in this.methods)
				{
					if (methodBuilder != null)
					{
						methodBuilder.ResolveUserTypes();
					}
				}
			}
			if (this.ctors != null)
			{
				foreach (ConstructorBuilder constructorBuilder in this.ctors)
				{
					if (constructorBuilder != null)
					{
						constructorBuilder.ResolveUserTypes();
					}
				}
			}
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x00104078 File Offset: 0x00102278
		internal static void ResolveUserTypes(Type[] types)
		{
			if (types != null)
			{
				for (int i = 0; i < types.Length; i++)
				{
					types[i] = TypeBuilder.ResolveUserType(types[i]);
				}
			}
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x001040A4 File Offset: 0x001022A4
		internal static Type ResolveUserType(Type t)
		{
			if (!(t != null) || (!(t.GetType().Assembly != typeof(int).Assembly) && !(t is TypeDelegator)))
			{
				return t;
			}
			t = t.UnderlyingSystemType;
			if (t != null && (t.GetType().Assembly != typeof(int).Assembly || t is TypeDelegator))
			{
				throw new NotSupportedException("User defined subclasses of System.Type are not yet supported.");
			}
			return t;
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x0010412C File Offset: 0x0010232C
		internal void FixupTokens(Dictionary<int, int> token_map, Dictionary<int, MemberInfo> member_map)
		{
			if (this.methods != null)
			{
				for (int i = 0; i < this.num_methods; i++)
				{
					this.methods[i].FixupTokens(token_map, member_map);
				}
			}
			if (this.ctors != null)
			{
				ConstructorBuilder[] array = this.ctors;
				for (int j = 0; j < array.Length; j++)
				{
					array[j].FixupTokens(token_map, member_map);
				}
			}
			if (this.subtypes != null)
			{
				TypeBuilder[] array2 = this.subtypes;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].FixupTokens(token_map, member_map);
				}
			}
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x001041B0 File Offset: 0x001023B0
		internal void GenerateDebugInfo(ISymbolWriter symbolWriter)
		{
			symbolWriter.OpenNamespace(this.Namespace);
			if (this.methods != null)
			{
				for (int i = 0; i < this.num_methods; i++)
				{
					this.methods[i].GenerateDebugInfo(symbolWriter);
				}
			}
			if (this.ctors != null)
			{
				ConstructorBuilder[] array = this.ctors;
				for (int j = 0; j < array.Length; j++)
				{
					array[j].GenerateDebugInfo(symbolWriter);
				}
			}
			symbolWriter.CloseNamespace();
			if (this.subtypes != null)
			{
				for (int k = 0; k < this.subtypes.Length; k++)
				{
					this.subtypes[k].GenerateDebugInfo(symbolWriter);
				}
			}
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Reflection.ConstructorInfo" />, представляющий открытые или не открытые (в зависимости от того, что указано) конструкторы, которые определены для данного класса.</summary>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из объекта <see cref="T:System.Reflection.BindingFlags" />, как в методах <see langword="InvokeMethod" />, <see langword="NonPublic" /> и др.</param>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.ConstructorInfo" />, предоставляющий указанные конструкторы для данного класса. Если конструкторы не определены, возвращается пустой массив.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052C7 RID: 21191 RVA: 0x00104245 File Offset: 0x00102445
		[ComVisible(true)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			if (this.is_created)
			{
				return this.created.GetConstructors(bindingAttr);
			}
			throw new NotSupportedException();
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x00104264 File Offset: 0x00102464
		internal ConstructorInfo[] GetConstructorsInternal(BindingFlags bindingAttr)
		{
			if (this.ctors == null)
			{
				return new ConstructorInfo[0];
			}
			ArrayList arrayList = new ArrayList();
			foreach (ConstructorBuilder constructorBuilder in this.ctors)
			{
				bool flag = false;
				MethodAttributes attributes = constructorBuilder.Attributes;
				if ((attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public)
				{
					if ((bindingAttr & BindingFlags.Public) != BindingFlags.Default)
					{
						flag = true;
					}
				}
				else if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
				{
					flag = true;
				}
				if (flag)
				{
					flag = false;
					if ((attributes & MethodAttributes.Static) != MethodAttributes.PrivateScope)
					{
						if ((bindingAttr & BindingFlags.Static) != BindingFlags.Default)
						{
							flag = true;
						}
					}
					else if ((bindingAttr & BindingFlags.Instance) != BindingFlags.Default)
					{
						flag = true;
					}
					if (flag)
					{
						arrayList.Add(constructorBuilder);
					}
				}
			}
			ConstructorInfo[] array2 = new ConstructorInfo[arrayList.Count];
			arrayList.CopyTo(array2);
			return array2;
		}

		/// <summary>При вызове этого метода всегда возникает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Этот метод не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x060052C9 RID: 21193 RVA: 0x000472C8 File Offset: 0x000454C8
		public override Type GetElementType()
		{
			throw new NotSupportedException();
		}

		/// <summary>Возвращает событие с указанным именем.</summary>
		/// <param name="name">Имя искомого события.</param>
		/// <param name="bindingAttr">Побитовое сочетание значений <see cref="T:System.Reflection.BindingFlags" />, ограничивающее поиск.</param>
		/// <returns>Объект <see cref="T:System.Reflection.EventInfo" />, представляющий событие, объявленное или наследованное этим типом с указанным именем, или <see langword="null" />, если сопоставления отсутствуют.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052CA RID: 21194 RVA: 0x00104305 File Offset: 0x00102505
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			this.check_created();
			return this.created.GetEvent(name, bindingAttr);
		}

		/// <summary>Возвращает открытые события, объявленные или наследованные данным типом.</summary>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.EventInfo" />, предоставляющий открытые события, объявленные или наследованные данным типом. Если открытые события отсутствуют, возвращается пустой массив.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052CB RID: 21195 RVA: 0x0004751C File Offset: 0x0004571C
		public override EventInfo[] GetEvents()
		{
			return this.GetEvents(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>Возвращает открытые и не являющиеся открытыми события, объявленные данным типом.</summary>
		/// <param name="bindingAttr">Побитовое сочетание значений <see cref="T:System.Reflection.BindingFlags" />, ограничивающее поиск.</param>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.EventInfo" />, представляющий события, объявленные или наследованные этим типом, которые соответствуют указанным флагам связывания. Если соответствующие события отсутствуют, возвращается пустой массив.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052CC RID: 21196 RVA: 0x0010431A File Offset: 0x0010251A
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			if (this.is_created)
			{
				return this.created.GetEvents(bindingAttr);
			}
			throw new NotSupportedException();
		}

		/// <summary>Возвращает поле, соответствующее указанному имени.</summary>
		/// <param name="name">Имя поля, которое нужно получить.</param>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из объекта <see cref="T:System.Reflection.BindingFlags" />, как в методах <see langword="InvokeMethod" />, <see langword="NonPublic" /> и др.</param>
		/// <returns>Возвращает объект <see cref="T:System.Reflection.FieldInfo" />, предоставляющий объявленное или наследованное данным типом поле с указанным именем и открытым или не являющимся открытым модификатором. Если совпадения отсутствуют, возвращается значение <see langword="null" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052CD RID: 21197 RVA: 0x00104338 File Offset: 0x00102538
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			if (this.created != null)
			{
				return this.created.GetField(name, bindingAttr);
			}
			if (this.fields == null)
			{
				return null;
			}
			foreach (FieldBuilder fieldInfo in this.fields)
			{
				if (!(fieldInfo == null) && !(fieldInfo.Name != name))
				{
					bool flag = false;
					FieldAttributes attributes = fieldInfo.Attributes;
					if ((attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Public)
					{
						if ((bindingAttr & BindingFlags.Public) != BindingFlags.Default)
						{
							flag = true;
						}
					}
					else if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
					{
						flag = true;
					}
					if (flag)
					{
						flag = false;
						if ((attributes & FieldAttributes.Static) != FieldAttributes.PrivateScope)
						{
							if ((bindingAttr & BindingFlags.Static) != BindingFlags.Default)
							{
								flag = true;
							}
						}
						else if ((bindingAttr & BindingFlags.Instance) != BindingFlags.Default)
						{
							flag = true;
						}
						if (flag)
						{
							return fieldInfo;
						}
					}
				}
			}
			return null;
		}

		/// <summary>Возвращает открытые и не являющиеся открытыми поля, объявленные данным типом.</summary>
		/// <param name="bindingAttr">Этот параметр должен представлять собой битовый флаг объекта <see cref="T:System.Reflection.BindingFlags" />: <see langword="InvokeMethod" />, <see langword="NonPublic" /> и т. д.</param>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.FieldInfo" />, предоставляющий открытые и не являющиеся открытыми поля, объявленные или наследованные данным типом. Если указанные поля отсутствуют, возвращается пустой массив.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052CE RID: 21198 RVA: 0x001043E4 File Offset: 0x001025E4
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			if (this.created != null)
			{
				return this.created.GetFields(bindingAttr);
			}
			if (this.fields == null)
			{
				return new FieldInfo[0];
			}
			ArrayList arrayList = new ArrayList();
			foreach (FieldBuilder fieldInfo in this.fields)
			{
				if (!(fieldInfo == null))
				{
					bool flag = false;
					FieldAttributes attributes = fieldInfo.Attributes;
					if ((attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Public)
					{
						if ((bindingAttr & BindingFlags.Public) != BindingFlags.Default)
						{
							flag = true;
						}
					}
					else if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
					{
						flag = true;
					}
					if (flag)
					{
						flag = false;
						if ((attributes & FieldAttributes.Static) != FieldAttributes.PrivateScope)
						{
							if ((bindingAttr & BindingFlags.Static) != BindingFlags.Default)
							{
								flag = true;
							}
						}
						else if ((bindingAttr & BindingFlags.Instance) != BindingFlags.Default)
						{
							flag = true;
						}
						if (flag)
						{
							arrayList.Add(fieldInfo);
						}
					}
				}
			}
			FieldInfo[] array2 = new FieldInfo[arrayList.Count];
			arrayList.CopyTo(array2);
			return array2;
		}

		/// <summary>Возвращает интерфейс, реализованный (прямо или косвенно) данным классом, с проверенным именем, соответствующим указанному имени интерфейса.</summary>
		/// <param name="name">Имя интерфейса.</param>
		/// <param name="ignoreCase">Если значение <see langword="true" />, при поиске не учитывается регистр. Если <see langword="false" />, то при поиске учитывается регистр.</param>
		/// <returns>Возвращает объект <see cref="T:System.Type" />, предоставляющий реализованный интерфейс. Возвращает значение null, если соответствующего имени интерфейса не найдено.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052CF RID: 21199 RVA: 0x001044AA File Offset: 0x001026AA
		public override Type GetInterface(string name, bool ignoreCase)
		{
			this.check_created();
			return this.created.GetInterface(name, ignoreCase);
		}

		/// <summary>Возвращает массив всех интерфейсов, реализованных для данного типа, а также для его базовых типов.</summary>
		/// <returns>Возвращает массив объектов <see cref="T:System.Type" />, представляющих реализованные интерфейсы. Если ни одного интерфейса не определено, возвращается пустой массив.</returns>
		// Token: 0x060052D0 RID: 21200 RVA: 0x001044C0 File Offset: 0x001026C0
		public override Type[] GetInterfaces()
		{
			if (this.is_created)
			{
				return this.created.GetInterfaces();
			}
			if (this.interfaces != null)
			{
				Type[] array = new Type[this.interfaces.Length];
				this.interfaces.CopyTo(array, 0);
				return array;
			}
			return Type.EmptyTypes;
		}

		/// <summary>Возвращает все открытые или не являющиеся открытыми (в зависимости от того, что указано) элементы, объявленные или наследованные данным типом.</summary>
		/// <param name="name">Имя члена.</param>
		/// <param name="type">Тип возвращаемого элемента.</param>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из объекта <see cref="T:System.Reflection.BindingFlags" />, как в методах <see langword="InvokeMethod" />, <see langword="NonPublic" /> и др.</param>
		/// <returns>Если задано <paramref name="nonPublic" />, метод возвращает массив объектов <see cref="T:System.Reflection.MemberInfo" />, предоставляющий открытые и не являющиеся открытыми элементы, определенные для данного типа; в противном случае возвращаются только открытые элементы.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052D1 RID: 21201 RVA: 0x0010450B File Offset: 0x0010270B
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			this.check_created();
			return this.created.GetMember(name, type, bindingAttr);
		}

		/// <summary>Возвращает элементы для открытых и неоткрытых элементов, объявленных или наследуемых данным типом.</summary>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из объекта <see cref="T:System.Reflection.BindingFlags" />, например <see langword="InvokeMethod" />, <see langword="NonPublic" /> и др.</param>
		/// <returns>Возвращает массив объектов <see cref="T:System.Reflection.MemberInfo" />, предоставляющий открытые и не являющиеся открытыми элементы, объявленные или наследованные данным типом. Если соответствующие элементы не найдены, возвращается пустой массив.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052D2 RID: 21202 RVA: 0x00104521 File Offset: 0x00102721
		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			this.check_created();
			return this.created.GetMembers(bindingAttr);
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00104538 File Offset: 0x00102738
		private MethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, Type reflected_type)
		{
			MethodInfo[] array2;
			if ((bindingAttr & BindingFlags.DeclaredOnly) == BindingFlags.Default && this.parent != null)
			{
				MethodInfo[] array = this.parent.GetMethods(bindingAttr);
				ArrayList arrayList = new ArrayList(array.Length);
				bool flag = (bindingAttr & BindingFlags.FlattenHierarchy) > BindingFlags.Default;
				foreach (MethodInfo methodInfo in array)
				{
					MethodAttributes attributes = methodInfo.Attributes;
					if (!methodInfo.IsStatic || flag)
					{
						MethodAttributes methodAttributes = attributes & MethodAttributes.MemberAccessMask;
						bool flag2;
						if (methodAttributes != MethodAttributes.Private)
						{
							if (methodAttributes != MethodAttributes.Assembly)
							{
								if (methodAttributes == MethodAttributes.Public)
								{
									flag2 = ((bindingAttr & BindingFlags.Public) > BindingFlags.Default);
								}
								else
								{
									flag2 = ((bindingAttr & BindingFlags.NonPublic) > BindingFlags.Default);
								}
							}
							else
							{
								flag2 = ((bindingAttr & BindingFlags.NonPublic) > BindingFlags.Default);
							}
						}
						else
						{
							flag2 = false;
						}
						if (flag2)
						{
							arrayList.Add(methodInfo);
						}
					}
				}
				if (this.methods == null)
				{
					array2 = new MethodInfo[arrayList.Count];
					arrayList.CopyTo(array2);
				}
				else
				{
					array2 = new MethodInfo[this.methods.Length + arrayList.Count];
					arrayList.CopyTo(array2, 0);
					this.methods.CopyTo(array2, arrayList.Count);
				}
			}
			else
			{
				MethodInfo[] array3 = this.methods;
				array2 = array3;
			}
			if (array2 == null)
			{
				return new MethodInfo[0];
			}
			ArrayList arrayList2 = new ArrayList();
			foreach (MethodInfo methodInfo2 in array2)
			{
				if (!(methodInfo2 == null) && (name == null || string.Compare(methodInfo2.Name, name, ignoreCase) == 0))
				{
					bool flag2 = false;
					MethodAttributes attributes = methodInfo2.Attributes;
					if ((attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public)
					{
						if ((bindingAttr & BindingFlags.Public) != BindingFlags.Default)
						{
							flag2 = true;
						}
					}
					else if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
					{
						flag2 = true;
					}
					if (flag2)
					{
						flag2 = false;
						if ((attributes & MethodAttributes.Static) != MethodAttributes.PrivateScope)
						{
							if ((bindingAttr & BindingFlags.Static) != BindingFlags.Default)
							{
								flag2 = true;
							}
						}
						else if ((bindingAttr & BindingFlags.Instance) != BindingFlags.Default)
						{
							flag2 = true;
						}
						if (flag2)
						{
							arrayList2.Add(methodInfo2);
						}
					}
				}
			}
			MethodInfo[] array4 = new MethodInfo[arrayList2.Count];
			arrayList2.CopyTo(array4);
			return array4;
		}

		/// <summary>Возвращает (в зависимости от того, что указано) все открытые и не являющиеся открытыми методы, объявленные или наследованные данным типом.</summary>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из объекта <see cref="T:System.Reflection.BindingFlags" />, как в методах <see langword="InvokeMethod" />, <see langword="NonPublic" /> и др.</param>
		/// <returns>Если задано <paramref name="nonPublic" />, метод возвращает массив объектов <see cref="T:System.Reflection.MethodInfo" />, предоставляющий открытые и не являющиеся открытыми методы, определенные для данного типа; в противном случае возвращаются только открытые методы.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052D4 RID: 21204 RVA: 0x001046F8 File Offset: 0x001028F8
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return this.GetMethodsByName(null, bindingAttr, false, this);
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x00104704 File Offset: 0x00102904
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			this.check_created();
			if (types == null)
			{
				return this.created.GetMethod(name, bindingAttr);
			}
			return this.created.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>Возвращает открытые и не являющиеся открытыми вложенные типы, объявленные данным типом.</summary>
		/// <param name="name">Объект <see cref="T:System.String" />, содержащий имя искомого вложенного типа.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Ноль, чтобы при поиске открытых методов учитывался регистр букв.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект <see cref="T:System.Type" />, предоставляющий вложенный тип, который соответствует указанным требованиям; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052D6 RID: 21206 RVA: 0x00104734 File Offset: 0x00102934
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			this.check_created();
			if (this.subtypes == null)
			{
				return null;
			}
			foreach (TypeBuilder typeBuilder in this.subtypes)
			{
				if (typeBuilder.is_created)
				{
					if ((typeBuilder.attrs & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPublic)
					{
						if ((bindingAttr & BindingFlags.Public) == BindingFlags.Default)
						{
							goto IL_55;
						}
					}
					else if ((bindingAttr & BindingFlags.NonPublic) == BindingFlags.Default)
					{
						goto IL_55;
					}
					if (typeBuilder.Name == name)
					{
						return typeBuilder.created;
					}
				}
				IL_55:;
			}
			return null;
		}

		/// <summary>Возвращает открытые и не являющиеся открытыми вложенные типы, объявленные или наследованные данным типом.</summary>
		/// <param name="bindingAttr">Это должен быть одноразрядный флаг из объекта <see cref="T:System.Reflection.BindingFlags" />, как в методах <see langword="InvokeMethod" />, <see langword="NonPublic" /> и др.</param>
		/// <returns>Массив объектов <see cref="T:System.Type" />, предоставляющий все типы, вложенные в текущий объект <see cref="T:System.Type" />, которые соответствуют указанным ограничениям на связывание.  
		/// Пустой массив типа <see cref="T:System.Type" />, если у текущего типа <see cref="T:System.Type" /> нет вложенных типов или если ни один из вложенных типов не соответствует ограничениям на связывание.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052D7 RID: 21207 RVA: 0x001047A4 File Offset: 0x001029A4
		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			if (!this.is_created)
			{
				throw new NotSupportedException();
			}
			ArrayList arrayList = new ArrayList();
			if (this.subtypes == null)
			{
				return Type.EmptyTypes;
			}
			foreach (TypeBuilder typeBuilder in this.subtypes)
			{
				bool flag = false;
				if ((typeBuilder.attrs & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPublic)
				{
					if ((bindingAttr & BindingFlags.Public) != BindingFlags.Default)
					{
						flag = true;
					}
				}
				else if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
				{
					flag = true;
				}
				if (flag)
				{
					arrayList.Add(typeBuilder);
				}
			}
			Type[] array2 = new Type[arrayList.Count];
			arrayList.CopyTo(array2);
			return array2;
		}

		/// <summary>Возвращает (в зависимости от того, что указано) все открытые или не являющиеся открытыми свойства, объявленные или наследованные данным типом.</summary>
		/// <param name="bindingAttr">Атрибут вызова. Этот параметр должен представлять собой битовый флаг объекта <see cref="T:System.Reflection.BindingFlags" />: <see langword="InvokeMethod" />, <see langword="NonPublic" /> и т. д.</param>
		/// <returns>Возвращает массив объектов <see langword="PropertyInfo" />, предоставляющих открытые и неоткрытые свойства, определенные на данном типе, если используется параметр <paramref name="nonPublic" />; в противном случае возвращаются только открытые свойства.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052D8 RID: 21208 RVA: 0x00104834 File Offset: 0x00102A34
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			if (this.is_created)
			{
				return this.created.GetProperties(bindingAttr);
			}
			if (this.properties == null)
			{
				return new PropertyInfo[0];
			}
			ArrayList arrayList = new ArrayList();
			foreach (PropertyBuilder propertyInfo in this.properties)
			{
				bool flag = false;
				MethodInfo methodInfo = propertyInfo.GetGetMethod(true);
				if (methodInfo == null)
				{
					methodInfo = propertyInfo.GetSetMethod(true);
				}
				if (!(methodInfo == null))
				{
					MethodAttributes attributes = methodInfo.Attributes;
					if ((attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public)
					{
						if ((bindingAttr & BindingFlags.Public) != BindingFlags.Default)
						{
							flag = true;
						}
					}
					else if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
					{
						flag = true;
					}
					if (flag)
					{
						flag = false;
						if ((attributes & MethodAttributes.Static) != MethodAttributes.PrivateScope)
						{
							if ((bindingAttr & BindingFlags.Static) != BindingFlags.Default)
							{
								flag = true;
							}
						}
						else if ((bindingAttr & BindingFlags.Instance) != BindingFlags.Default)
						{
							flag = true;
						}
						if (flag)
						{
							arrayList.Add(propertyInfo);
						}
					}
				}
			}
			PropertyInfo[] array2 = new PropertyInfo[arrayList.Count];
			arrayList.CopyTo(array2);
			return array2;
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x00104913 File Offset: 0x00102B13
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw this.not_supported();
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x0010491B File Offset: 0x00102B1B
		protected override bool HasElementTypeImpl()
		{
			return this.is_created && this.created.HasElementType;
		}

		/// <summary>Вызывает указанный член. Вызываемый метод должен быть доступен и должен обеспечивать наиболее конкретизированное совпадение с заданным списком аргументов, с использованием ограничений заданного связывателя и атрибутов вызова.</summary>
		/// <param name="name">Имя элемента, который предполагается вызвать. Это может быть конструктор, метод, свойство или поле. Необходимо указать подходящий атрибут вызова. Обратите внимание, что можно вызвать член класса, заданный по умолчанию, передав в качестве имени члена пустую строку.</param>
		/// <param name="invokeAttr">Атрибут вызова. Это должен быть одноразрядный флаг из <see langword="BindingFlags" />.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see langword="MemberInfo" /> с помощью отражения. Если указан модуль привязки <see langword="null" />, используется модуль привязки по умолчанию. См. <see cref="T:System.Reflection.Binder" />.</param>
		/// <param name="target">Объект, для которого следует вызвать указанный элемент. Если член является статическим, этот параметр игнорируется.</param>
		/// <param name="args">Список аргументов. Это массив объектов, содержащий число, порядок и тип параметров вызываемого члена. Если параметров нет, должно быть указано значение NULL.</param>
		/// <param name="modifiers">Массив с такой же длиной, как у <paramref name="args" /> с элементами, представляющими атрибуты, связанные с аргументами вызываемого члена. Параметр имеет атрибуты, связанные с ним в метаданных. Они используются различными службами взаимодействия. Дополнительные сведения см. в спецификации метаданных.</param>
		/// <param name="culture">Экземпляр объекта <see langword="CultureInfo" />, используемого для управления приведением типов. Если его значением является null, для текущего потока используется <see langword="CultureInfo" />. (Обратите внимание, что необходимо, например, преобразовывать строку, представляющую число 1000 в число с удвоенной точностью, поскольку в разных языках и региональных параметрах число 1000 представляется по-разному).</param>
		/// <param name="namedParameters">Каждый параметр в массиве <paramref name="namedParameters" /> получает значение от соответствующего элемента массива <paramref name="args" />. Если длина <paramref name="args" /> больше, чем длина <paramref name="namedParameters" />, оставшиеся значения аргументов передаются по порядку.</param>
		/// <returns>Возвращает возвращаемое значение вызванного элемента.</returns>
		/// <exception cref="T:System.NotSupportedException">В настоящее время этот метод не поддерживается для неполных типов.</exception>
		// Token: 0x060052DB RID: 21211 RVA: 0x00104934 File Offset: 0x00102B34
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			this.check_created();
			return this.created.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x00047302 File Offset: 0x00045502
		protected override bool IsCOMObjectImpl()
		{
			return (this.GetAttributeFlagsImpl() & TypeAttributes.Import) > TypeAttributes.NotPublic;
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00104960 File Offset: 0x00102B60
		protected override bool IsValueTypeImpl()
		{
			if (this == this.pmodule.assemblyb.corlib_value_type || this == this.pmodule.assemblyb.corlib_enum_type)
			{
				return false;
			}
			Type baseType = this.parent;
			while (baseType != null)
			{
				if (baseType == this.pmodule.assemblyb.corlib_value_type)
				{
					return true;
				}
				baseType = baseType.BaseType;
			}
			return false;
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, который представляет одномерный массив текущего типа с нижней границей, равной нулю.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, который представляет одномерный тип массива, тип элемента в котором является текущим, с нижней границей, равной нулю.</returns>
		// Token: 0x060052E2 RID: 21218 RVA: 0x000F653D File Offset: 0x000F473D
		public override Type MakeArrayType()
		{
			return new ArrayType(this, 0);
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, который представляет массив текущего типа с заданным числом измерений.</summary>
		/// <param name="rank">Размерность массива.</param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий одномерный массив текущего типа.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">Параметр <paramref name="rank" /> не является допустимым измерением массива.</exception>
		// Token: 0x060052E3 RID: 21219 RVA: 0x000F6546 File Offset: 0x000F4746
		public override Type MakeArrayType(int rank)
		{
			if (rank < 1)
			{
				throw new IndexOutOfRangeException();
			}
			return new ArrayType(this, rank);
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, который представляет текущий тип при передаче в качестве параметра <see langword="ref" /> (<see langword="ByRef" /> в Visual Basic).</summary>
		/// <returns>Объект <see cref="T:System.Type" />, который представляет текущий тип при передаче в качестве параметра <see langword="ref" /> (<see langword="ByRef" /> в Visual Basic).</returns>
		// Token: 0x060052E4 RID: 21220 RVA: 0x000F6559 File Offset: 0x000F4759
		public override Type MakeByRefType()
		{
			return new ByRefType(this);
		}

		/// <summary>Замещает элементы массива типов параметрами типов текущего определения универсального типа, затем возвращает получившийся сконструированный тип.</summary>
		/// <param name="typeArguments">Массив типов, который должен быть замещен параметрами типов текущего определения универсального типа.</param>
		/// <returns>
		///   <see cref="T:System.Type" /> представляет сконструированный тип, сформированный путем замещения элементов объекта <paramref name="typeArguments" /> параметрами текущего универсального типа.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий тип не представляет определение универсального типа. То есть <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> возвращает <see langword="false" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeArguments" /> — <see langword="null" />.  
		/// -или- 
		/// Любой элемент <paramref name="typeArguments" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Type.Module" /> любого элемента <paramref name="typeArguments" /> — <see langword="null" />.  
		/// -или- 
		/// Свойство <see cref="P:System.Reflection.Module.Assembly" /> модуля любого элемента <paramref name="typeArguments" /> — <see langword="null" />.</exception>
		// Token: 0x060052E5 RID: 21221 RVA: 0x001049D4 File Offset: 0x00102BD4
		public override Type MakeGenericType(params Type[] typeArguments)
		{
			if (!this.IsGenericTypeDefinition)
			{
				throw new InvalidOperationException("not a generic type definition");
			}
			if (typeArguments == null)
			{
				throw new ArgumentNullException("typeArguments");
			}
			if (this.generic_params.Length != typeArguments.Length)
			{
				throw new ArgumentException(string.Format("The type or method has {0} generic parameter(s) but {1} generic argument(s) where provided. A generic argument must be provided for each generic parameter.", this.generic_params.Length, typeArguments.Length), "typeArguments");
			}
			for (int i = 0; i < typeArguments.Length; i++)
			{
				if (typeArguments[i] == null)
				{
					throw new ArgumentNullException("typeArguments");
				}
			}
			Type[] array = new Type[typeArguments.Length];
			typeArguments.CopyTo(array, 0);
			return this.pmodule.assemblyb.MakeGenericType(this, array);
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, который представляет тип неуправляемого указателя на текущий тип.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, который представляет тип неуправляемого указателя на текущий тип.</returns>
		// Token: 0x060052E6 RID: 21222 RVA: 0x000F6561 File Offset: 0x000F4761
		public override Type MakePointerType()
		{
			return new PointerType(this);
		}

		/// <summary>Не поддерживается в динамических модулях.</summary>
		/// <returns>Только для чтения.</returns>
		/// <exception cref="T:System.NotSupportedException">Не поддерживается в динамических модулях.</exception>
		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x060052E7 RID: 21223 RVA: 0x00104A82 File Offset: 0x00102C82
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				this.check_created();
				return this.created.TypeHandle;
			}
		}

		/// <summary>Задание пользовательского атрибута с помощью средства построения пользовательских атрибутов.</summary>
		/// <param name="customBuilder">Экземпляр вспомогательного класса для определения пользовательского атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="customBuilder" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для текущего динамического типа значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> равно <see langword="true" />, однако значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> равно <see langword="false" />.</exception>
		// Token: 0x060052E8 RID: 21224 RVA: 0x00104A98 File Offset: 0x00102C98
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			if (customBuilder == null)
			{
				throw new ArgumentNullException("customBuilder");
			}
			string fullName = customBuilder.Ctor.ReflectedType.FullName;
			if (fullName == "System.Runtime.InteropServices.StructLayoutAttribute")
			{
				byte[] data = customBuilder.Data;
				int num = (int)data[2] | (int)data[3] << 8;
				this.attrs &= ~TypeAttributes.LayoutMask;
				switch (num)
				{
				case 0:
					this.attrs |= TypeAttributes.SequentialLayout;
					goto IL_A5;
				case 2:
					this.attrs |= TypeAttributes.ExplicitLayout;
					goto IL_A5;
				case 3:
					this.attrs |= TypeAttributes.NotPublic;
					goto IL_A5;
				}
				throw new Exception("Error in customattr");
				IL_A5:
				Type type = (customBuilder.Ctor is ConstructorBuilder) ? ((ConstructorBuilder)customBuilder.Ctor).parameters[0] : customBuilder.Ctor.GetParametersInternal()[0].ParameterType;
				int num2 = 6;
				if (type.FullName == "System.Int16")
				{
					num2 = 4;
				}
				int num3 = (int)data[num2++];
				num3 |= (int)data[num2++] << 8;
				for (int i = 0; i < num3; i++)
				{
					num2++;
					int num4;
					if (data[num2++] == 85)
					{
						num4 = CustomAttributeBuilder.decode_len(data, num2, out num2);
						CustomAttributeBuilder.string_from_bytes(data, num2, num4);
						num2 += num4;
					}
					num4 = CustomAttributeBuilder.decode_len(data, num2, out num2);
					string a = CustomAttributeBuilder.string_from_bytes(data, num2, num4);
					num2 += num4;
					int num5 = (int)data[num2++];
					num5 |= (int)data[num2++] << 8;
					num5 |= (int)data[num2++] << 16;
					num5 |= (int)data[num2++] << 24;
					if (!(a == "CharSet"))
					{
						if (!(a == "Pack"))
						{
							if (a == "Size")
							{
								this.class_size = num5;
							}
						}
						else
						{
							this.packing_size = (PackingSize)num5;
						}
					}
					else
					{
						switch (num5)
						{
						case 1:
						case 2:
							this.attrs &= ~TypeAttributes.StringFormatMask;
							break;
						case 3:
							this.attrs &= ~TypeAttributes.AutoClass;
							this.attrs |= TypeAttributes.UnicodeClass;
							break;
						case 4:
							this.attrs &= ~TypeAttributes.UnicodeClass;
							this.attrs |= TypeAttributes.AutoClass;
							break;
						}
					}
				}
				return;
			}
			if (fullName == "System.Runtime.CompilerServices.SpecialNameAttribute")
			{
				this.attrs |= TypeAttributes.SpecialName;
				return;
			}
			if (fullName == "System.SerializableAttribute")
			{
				this.attrs |= TypeAttributes.Serializable;
				return;
			}
			if (fullName == "System.Runtime.InteropServices.ComImportAttribute")
			{
				this.attrs |= TypeAttributes.Import;
				return;
			}
			if (fullName == "System.Security.SuppressUnmanagedCodeSecurityAttribute")
			{
				this.attrs |= TypeAttributes.HasSecurity;
			}
			if (this.cattrs != null)
			{
				CustomAttributeBuilder[] array = new CustomAttributeBuilder[this.cattrs.Length + 1];
				this.cattrs.CopyTo(array, 0);
				array[this.cattrs.Length] = customBuilder;
				this.cattrs = array;
				return;
			}
			this.cattrs = new CustomAttributeBuilder[1];
			this.cattrs[0] = customBuilder;
		}

		/// <summary>Устанавливает пользовательский атрибут с использованием заданного большого двоичного объекта пользовательских атрибутов.</summary>
		/// <param name="con">Конструктор пользовательского атрибута.</param>
		/// <param name="binaryAttribute">Большой двоичный объект байтов, предоставляющий атрибуты.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="con" /> или <paramref name="binaryAttribute" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для текущего динамического типа значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> равно <see langword="true" />, однако значение свойства <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> равно <see langword="false" />.</exception>
		// Token: 0x060052E9 RID: 21225 RVA: 0x00104DCC File Offset: 0x00102FCC
		[ComVisible(true)]
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			this.SetCustomAttribute(new CustomAttributeBuilder(con, binaryAttribute));
		}

		/// <summary>Добавляет в тип новое событие с данными именем, атрибутами и типом события.</summary>
		/// <param name="name">Имя события. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="attributes">Атрибуты события.</param>
		/// <param name="eventtype">Тип события.</param>
		/// <returns>Определенное событие.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="eventtype" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x060052EA RID: 21226 RVA: 0x00104DDC File Offset: 0x00102FDC
		public EventBuilder DefineEvent(string name, EventAttributes attributes, Type eventtype)
		{
			this.check_name("name", name);
			if (eventtype == null)
			{
				throw new ArgumentNullException("type");
			}
			this.check_not_created();
			EventBuilder eventBuilder = new EventBuilder(this, name, attributes, eventtype);
			if (this.events != null)
			{
				EventBuilder[] array = new EventBuilder[this.events.Length + 1];
				Array.Copy(this.events, array, this.events.Length);
				array[this.events.Length] = eventBuilder;
				this.events = array;
			}
			else
			{
				this.events = new EventBuilder[1];
				this.events[0] = eventBuilder;
			}
			return eventBuilder;
		}

		/// <summary>Определяет инициализированное поле данных в разделе .sdata переносимого исполняемого PE-файла.</summary>
		/// <param name="name">Имя, используемое для ссылки на данные. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="data">Большой двоичный объект данных.</param>
		/// <param name="attributes">Атрибуты поля.</param>
		/// <returns>Поле для ссылки на данные.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.  
		/// -или- 
		/// Размер данных не больше нуля либо не меньше 0x3f0000.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="data" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Вызов метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> уже был выполнен.</exception>
		// Token: 0x060052EB RID: 21227 RVA: 0x00104E6F File Offset: 0x0010306F
		public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			FieldBuilder fieldBuilder = this.DefineUninitializedData(name, data.Length, attributes);
			fieldBuilder.SetRVAData(data);
			return fieldBuilder;
		}

		/// <summary>Определяет неинициализированное поле данных в разделе <see langword=".sdata" /> переносимого исполняемого файла.</summary>
		/// <param name="name">Имя, используемое для ссылки на данные. Параметр <paramref name="name" /> не должен содержать внедренные значения NULL.</param>
		/// <param name="size">Размер поля данных.</param>
		/// <param name="attributes">Атрибуты поля.</param>
		/// <returns>Поле для ссылки на данные.</returns>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="name" /> равна нулю.  
		/// -или- 
		///  Значение <paramref name="size" /> меньше или равно нулю либо больше или равно 0x003f0000.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x060052EC RID: 21228 RVA: 0x00104E94 File Offset: 0x00103094
		public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("Empty name is not legal", "name");
			}
			if (size <= 0 || size > 4128768)
			{
				throw new ArgumentException("Data size must be > 0 and < 0x3f0000");
			}
			this.check_not_created();
			string text = "$ArrayType$" + size.ToString();
			TypeIdentifier innerName = TypeIdentifiers.WithoutEscape(text);
			Type type = this.pmodule.GetRegisteredType(this.fullname.NestedName(innerName));
			if (type == null)
			{
				TypeBuilder typeBuilder = this.DefineNestedType(text, TypeAttributes.Public | TypeAttributes.NestedPublic | TypeAttributes.ExplicitLayout | TypeAttributes.Sealed, this.pmodule.assemblyb.corlib_value_type, null, PackingSize.Size1, size);
				typeBuilder.CreateType();
				type = typeBuilder;
			}
			return this.DefineField(name, type, attributes | FieldAttributes.Static | FieldAttributes.HasFieldRVA);
		}

		/// <summary>Возвращает токен типа для данного типа.</summary>
		/// <returns>Только для чтения. Возвращает <see langword="TypeToken" /> этого типа.</returns>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x060052ED RID: 21229 RVA: 0x00104F57 File Offset: 0x00103157
		public TypeToken TypeToken
		{
			get
			{
				return new TypeToken(33554432 | this.table_idx);
			}
		}

		/// <summary>Задает базовый тип для создаваемого в настоящий момент типа.</summary>
		/// <param name="parent">Новый базовый тип.</param>
		/// <exception cref="T:System.InvalidOperationException">Данный тип был ранее создан с помощью метода <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.  
		/// -или- 
		///  <paramref name="parent" /> имеет значение <see langword="null" />, и текущий экземпляр представляет интерфейс, атрибуты которого не включают <see cref="F:System.Reflection.TypeAttributes.Abstract" />.  
		/// -или- 
		/// Для текущего динамического типа свойство <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> имеет значение <see langword="true" />, но свойство <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> имеет значение <see langword="false" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="parent" /> является интерфейсом. Это условие исключения является новым в .NET Framework версии 2.0.</exception>
		// Token: 0x060052EE RID: 21230 RVA: 0x00104F6C File Offset: 0x0010316C
		public void SetParent(Type parent)
		{
			this.check_not_created();
			if (parent == null)
			{
				if ((this.attrs & TypeAttributes.ClassSemanticsMask) != TypeAttributes.NotPublic)
				{
					if ((this.attrs & TypeAttributes.Abstract) == TypeAttributes.NotPublic)
					{
						throw new InvalidOperationException("Interface must be declared abstract.");
					}
					this.parent = null;
				}
				else
				{
					this.parent = typeof(object);
				}
			}
			else
			{
				this.parent = parent;
			}
			this.parent = TypeBuilder.ResolveUserType(this.parent);
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x00104FDF File Offset: 0x001031DF
		internal int get_next_table_index(object obj, int table, int count)
		{
			return this.pmodule.get_next_table_index(obj, table, count);
		}

		/// <summary>Возвращает отображение интерфейса для запрошенного интерфейса.</summary>
		/// <param name="interfaceType">Тип <see cref="T:System.Type" /> интерфейса, для которого необходимо извлечь сопоставление.</param>
		/// <returns>Возвращает запрошенное отображение интерфейса.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализуется для неполных типов.</exception>
		// Token: 0x060052F0 RID: 21232 RVA: 0x00104FEF File Offset: 0x001031EF
		[ComVisible(true)]
		public override InterfaceMapping GetInterfaceMap(Type interfaceType)
		{
			if (this.created == null)
			{
				throw new NotSupportedException("This method is not implemented for incomplete types.");
			}
			return this.created.GetInterfaceMap(interfaceType);
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x00105016 File Offset: 0x00103216
		internal override Type InternalResolve()
		{
			this.check_created();
			return this.created;
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00105016 File Offset: 0x00103216
		internal override Type RuntimeResolve()
		{
			this.check_created();
			return this.created;
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x060052F3 RID: 21235 RVA: 0x00105024 File Offset: 0x00103224
		internal bool is_created
		{
			get
			{
				return this.createTypeCalled;
			}
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x000F79D6 File Offset: 0x000F5BD6
		private Exception not_supported()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x0010502C File Offset: 0x0010322C
		private void check_not_created()
		{
			if (this.is_created)
			{
				throw new InvalidOperationException("Unable to change after type has been created.");
			}
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00105041 File Offset: 0x00103241
		private void check_created()
		{
			if (!this.is_created)
			{
				throw this.not_supported();
			}
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00105052 File Offset: 0x00103252
		private void check_name(string argName, string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException(argName);
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("Empty name is not legal", argName);
			}
			if (name[0] == '\0')
			{
				throw new ArgumentException("Illegal name", argName);
			}
		}

		/// <summary>Возвращает имя типа, исключая пространство имен.</summary>
		/// <returns>Только для чтения. Имя типа, исключая пространство имен.</returns>
		// Token: 0x060052F8 RID: 21240 RVA: 0x00105087 File Offset: 0x00103287
		public override string ToString()
		{
			return this.FullName;
		}

		/// <summary>Получает значение, указывающее, можно ли назначить указанный объект <see cref="T:System.Type" /> данному объекту.</summary>
		/// <param name="c">Объект для тестирования.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="c" /> и текущий объект тип представляют один тип, или если текущий тип находится в иерархии наследования параметра <paramref name="c" />, или если текущий тип является интерфейсом, поддерживаемым параметром <paramref name="c" />. Значение <see langword="false" />, если не выполняется ни одно из этих условий, или значение параметра <paramref name="c" /> равно <see langword="null" />.</returns>
		// Token: 0x060052F9 RID: 21241 RVA: 0x0010508F File Offset: 0x0010328F
		[MonoTODO]
		public override bool IsAssignableFrom(Type c)
		{
			return base.IsAssignableFrom(c);
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x00105098 File Offset: 0x00103298
		[MonoTODO("arrays")]
		internal bool IsAssignableTo(Type c)
		{
			if (c == this)
			{
				return true;
			}
			if (c.IsInterface)
			{
				if (this.parent != null && this.is_created && c.IsAssignableFrom(this.parent))
				{
					return true;
				}
				if (this.interfaces == null)
				{
					return false;
				}
				foreach (Type c2 in this.interfaces)
				{
					if (c.IsAssignableFrom(c2))
					{
						return true;
					}
				}
				if (!this.is_created)
				{
					return false;
				}
			}
			if (this.parent == null)
			{
				return c == typeof(object);
			}
			return c.IsAssignableFrom(this.parent);
		}

		/// <summary>Возвращает значение, указывающее, был ли создан текущий динамический тип.</summary>
		/// <returns>Значение <see langword="true" />, если был вызван метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060052FB RID: 21243 RVA: 0x00105141 File Offset: 0x00103341
		public bool IsCreated()
		{
			return this.is_created;
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Type" />, представляющий аргументы универсального типа, или параметры типа определения универсального типа.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />. Элементы массива представляют аргументы типа, относящиеся к универсальному типу, или параметры типа определения универсального типа.</returns>
		// Token: 0x060052FC RID: 21244 RVA: 0x0010514C File Offset: 0x0010334C
		public override Type[] GetGenericArguments()
		{
			if (this.generic_params == null)
			{
				return null;
			}
			Type[] array = new Type[this.generic_params.Length];
			this.generic_params.CopyTo(array, 0);
			return array;
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, представляющий определение универсального типа, из которого можно получить текущий тип.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий определение универсального типа, из которого можно получить текущий тип.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий тип не является универсальным. То есть <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> возвращает значение <see langword="false" />.</exception>
		// Token: 0x060052FD RID: 21245 RVA: 0x0010517F File Offset: 0x0010337F
		public override Type GetGenericTypeDefinition()
		{
			if (this.generic_params == null)
			{
				throw new InvalidOperationException("Type is not generic");
			}
			return this;
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x060052FE RID: 21246 RVA: 0x00105195 File Offset: 0x00103395
		public override bool ContainsGenericParameters
		{
			get
			{
				return this.generic_params != null;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли текущий тип параметром универсального типа.</summary>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Reflection.Emit.TypeBuilder" /> представляет параметр универсального типа; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x060052FF RID: 21247 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, которое указывает ковариацию и особые ограничения текущего параметра универсального типа.</summary>
		/// <returns>Побитовое сочетание значений <see cref="T:System.Reflection.GenericParameterAttributes" />, которое описывает ковариацию и особые ограничения текущего параметра универсального типа.</returns>
		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06005300 RID: 21248 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				return GenericParameterAttributes.None;
			}
		}

		/// <summary>Возвращает значение, указывающее, представляет ли текущий объект <see cref="T:System.Reflection.Emit.TypeBuilder" /> определение универсального типа, на основе которого могут быть созданы другие универсальные типы.</summary>
		/// <returns>Значение <see langword="true" />, если этот объект <see cref="T:System.Reflection.Emit.TypeBuilder" /> представляет определение универсального типа, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06005301 RID: 21249 RVA: 0x00105195 File Offset: 0x00103395
		public override bool IsGenericTypeDefinition
		{
			get
			{
				return this.generic_params != null;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли текущий тип универсальным.</summary>
		/// <returns>Значение <see langword="true" />, если тип, представленный текущим объектом <see cref="T:System.Reflection.Emit.TypeBuilder" /> является универсальным; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06005302 RID: 21250 RVA: 0x001051A0 File Offset: 0x001033A0
		public override bool IsGenericType
		{
			get
			{
				return this.IsGenericTypeDefinition;
			}
		}

		/// <summary>Возвращает позицию параметра типа в списке параметров типа универсального параметра, объявившем об этом параметре.</summary>
		/// <returns>Если текущий объект <see cref="T:System.Reflection.Emit.TypeBuilder" /> представляет параметр универсального типа, позиция параметра типа в списке параметров типа универсального типа, объявившего этот параметр; в противном случае — без определения.</returns>
		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06005303 RID: 21251 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO]
		public override int GenericParameterPosition
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Возвращает метод, объявивший текущий параметр универсального типа.</summary>
		/// <returns>
		///   <see cref="T:System.Reflection.MethodBase" />, представляющий метод, объявивший текущий тип, если текущий тип является параметром универсального типа; в противном случае — <see langword="null" />.</returns>
		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06005304 RID: 21252 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override MethodBase DeclaringMethod
		{
			get
			{
				return null;
			}
		}

		/// <summary>Определяет параметры универсального типа для текущего типа, указывая их номера и имена, а также возвращает массив объектов <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />, который может быть использован для определения ограничений.</summary>
		/// <param name="names">Массив имен для параметров универсального типа.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />, который можно использовать для определения ограничений параметров универсального типа для текущего типа.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для этого типа уже были определены параметры универсального типа.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="names" /> — <see langword="null" />.  
		/// -или- 
		/// Элемент <paramref name="names" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="names" /> является пустым массивом.</exception>
		// Token: 0x06005305 RID: 21253 RVA: 0x001051A8 File Offset: 0x001033A8
		public GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names)
		{
			if (names == null)
			{
				throw new ArgumentNullException("names");
			}
			if (names.Length == 0)
			{
				throw new ArgumentException("names");
			}
			this.generic_params = new GenericTypeParameterBuilder[names.Length];
			for (int i = 0; i < names.Length; i++)
			{
				string text = names[i];
				if (text == null)
				{
					throw new ArgumentNullException("names");
				}
				this.generic_params[i] = new GenericTypeParameterBuilder(this, null, text, i);
			}
			return this.generic_params;
		}

		/// <summary>Возвращает конструктор указанного сконструированного универсального типа, соответствующего указанному конструктору определения универсального типа.</summary>
		/// <param name="type">Сконструированный универсальный тип, конструктор которого возвращается.</param>
		/// <param name="constructor">Конструктор определения универсального типа <paramref name="type" />, который определяет, какой конструктор <paramref name="type" /> должен быть возвращен.</param>
		/// <returns>Объект <see cref="T:System.Reflection.ConstructorInfo" />, который представляет конструктор <paramref name="type" />, соответствующий <paramref name="constructor" />, который определяет конструктор, принадлежащий определению универсального типа <paramref name="type" />.</returns>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="type" /> не представляет универсальный тип.  
		/// -или- 
		///  Параметр <paramref name="type" /> не является параметром типа <see cref="T:System.Reflection.Emit.TypeBuilder" />.  
		/// -или- 
		/// Объявляющий тип <paramref name="constructor" /> не является определением универсального типа.  
		/// -или- 
		/// Объявленный тип <paramref name="constructor" /> не является определением универсального типа <paramref name="type" />.</exception>
		// Token: 0x06005306 RID: 21254 RVA: 0x00105218 File Offset: 0x00103418
		public static ConstructorInfo GetConstructor(Type type, ConstructorInfo constructor)
		{
			if (type == null)
			{
				throw new ArgumentException("Type is not generic", "type");
			}
			if (!type.IsGenericType)
			{
				throw new ArgumentException("Type is not a generic type", "type");
			}
			if (type.IsGenericTypeDefinition)
			{
				throw new ArgumentException("Type cannot be a generic type definition", "type");
			}
			if (constructor == null)
			{
				throw new NullReferenceException();
			}
			if (!constructor.DeclaringType.IsGenericTypeDefinition)
			{
				throw new ArgumentException("constructor declaring type is not a generic type definition", "constructor");
			}
			if (constructor.DeclaringType != type.GetGenericTypeDefinition())
			{
				throw new ArgumentException("constructor declaring type is not the generic type definition of type", "constructor");
			}
			ConstructorInfo constructor2 = type.GetConstructor(constructor);
			if (constructor2 == null)
			{
				throw new ArgumentException("constructor not found");
			}
			return constructor2;
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x001052D8 File Offset: 0x001034D8
		private static bool IsValidGetMethodType(Type type)
		{
			if (type is TypeBuilder || type is TypeBuilderInstantiation)
			{
				return true;
			}
			if (type.Module is ModuleBuilder)
			{
				return true;
			}
			if (type.IsGenericParameter)
			{
				return false;
			}
			Type[] genericArguments = type.GetGenericArguments();
			if (genericArguments == null)
			{
				return false;
			}
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (TypeBuilder.IsValidGetMethodType(genericArguments[i]))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Возвращает метод указанного сконструированного универсального типа, соответствующего указанному методу определения универсального типа.</summary>
		/// <param name="type">Сконструированный универсальный тип, метод которого возвращается.</param>
		/// <param name="method">Метод определения универсального типа <paramref name="type" />, который определяет, какой метод <paramref name="type" /> должен быть возвращен.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, который представляет метод <paramref name="type" />, соответствующий <paramref name="method" />, который определяет метод, принадлежащий определению универсального типа <paramref name="type" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="method" /> — это универсальный метод, который не является определением универсального метода.  
		/// -или- 
		///  <paramref name="type" /> не представляет универсальный тип.  
		/// -или- 
		///  Параметр <paramref name="type" /> не является параметром типа <see cref="T:System.Reflection.Emit.TypeBuilder" />.  
		/// -или- 
		/// Объявляющий тип <paramref name="method" /> не является определением универсального типа.  
		/// -или- 
		/// Объявленный тип <paramref name="method" /> не является определением универсального типа <paramref name="type" />.</exception>
		// Token: 0x06005308 RID: 21256 RVA: 0x00105338 File Offset: 0x00103538
		public static MethodInfo GetMethod(Type type, MethodInfo method)
		{
			if (!TypeBuilder.IsValidGetMethodType(type))
			{
				string str = "type is not TypeBuilder but ";
				Type type2 = type.GetType();
				throw new ArgumentException(str + ((type2 != null) ? type2.ToString() : null), "type");
			}
			if (type is TypeBuilder && type.ContainsGenericParameters)
			{
				type = type.MakeGenericType(type.GetGenericArguments());
			}
			if (!type.IsGenericType)
			{
				throw new ArgumentException("type is not a generic type", "type");
			}
			if (!method.DeclaringType.IsGenericTypeDefinition)
			{
				throw new ArgumentException("method declaring type is not a generic type definition", "method");
			}
			if (method.DeclaringType != type.GetGenericTypeDefinition())
			{
				throw new ArgumentException("method declaring type is not the generic type definition of type", "method");
			}
			if (method == null)
			{
				throw new NullReferenceException();
			}
			MethodInfo method2 = type.GetMethod(method);
			if (method2 == null)
			{
				throw new ArgumentException(string.Format("method {0} not found in type {1}", method.Name, type));
			}
			return method2;
		}

		/// <summary>Возвращает поле указанного сконструированного универсального типа, соответствующего указанному полю определения универсального типа.</summary>
		/// <param name="type">Сконструированный универсальный тип, поле которого возвращается.</param>
		/// <param name="field">Поле определения универсального типа <paramref name="type" />, которое задает, какое поле <paramref name="type" /> должно быть возвращено.</param>
		/// <returns>Объект <see cref="T:System.Reflection.FieldInfo" />, который представляет поле <paramref name="type" />, соответствующий <paramref name="field" />, который определяет поле, принадлежащее определению универсального типа <paramref name="type" />.</returns>
		/// <exception cref="T:System.ArgumentException">Тип <paramref name="type" /> не представляет универсальный тип.  
		/// -или- 
		///  Параметр <paramref name="type" /> не является параметром типа <see cref="T:System.Reflection.Emit.TypeBuilder" />.  
		/// -или- 
		/// Объявляющий тип <paramref name="field" /> не является определением универсального типа.  
		/// -или- 
		/// Объявленный тип <paramref name="field" /> не является определением универсального типа <paramref name="type" />.</exception>
		// Token: 0x06005309 RID: 21257 RVA: 0x00105420 File Offset: 0x00103620
		public static FieldInfo GetField(Type type, FieldInfo field)
		{
			if (!type.IsGenericType)
			{
				throw new ArgumentException("Type is not a generic type", "type");
			}
			if (type.IsGenericTypeDefinition)
			{
				throw new ArgumentException("Type cannot be a generic type definition", "type");
			}
			if (field is FieldOnTypeBuilderInst)
			{
				throw new ArgumentException("The specified field must be declared on a generic type definition.", "field");
			}
			if (field.DeclaringType != type.GetGenericTypeDefinition())
			{
				throw new ArgumentException("field declaring type is not the generic type definition of type", "method");
			}
			FieldInfo field2 = type.GetField(field);
			if (field2 == null)
			{
				throw new Exception("field not found");
			}
			return field2;
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x0600530A RID: 21258 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		internal override bool IsUserType
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, представляет ли этот данный объект сконструированный универсальный тип.</summary>
		/// <returns>Значение <see langword="true" />, если этот объект представляет сконструированный универсальный тип; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x0600530B RID: 21259 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public override bool IsConstructedGenericType
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, можно ли назначить указанный объект <see cref="T:System.Reflection.TypeInfo" /> данному объекту.</summary>
		/// <param name="typeInfo">Объект для тестирования.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="typeInfo" /> можно назначить данному объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600530C RID: 21260 RVA: 0x000FA635 File Offset: 0x000F8835
		public override bool IsAssignableFrom(TypeInfo typeInfo)
		{
			return base.IsAssignableFrom(typeInfo);
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x001054B8 File Offset: 0x001036B8
		internal static bool SetConstantValue(Type destType, object value, ref object destValue)
		{
			if (value != null)
			{
				Type type = value.GetType();
				if (destType.IsByRef)
				{
					destType = destType.GetElementType();
				}
				destType = (Nullable.GetUnderlyingType(destType) ?? destType);
				if (destType.IsEnum)
				{
					EnumBuilder enumBuilder;
					Type type2;
					TypeBuilder typeBuilder;
					if ((enumBuilder = (destType as EnumBuilder)) != null)
					{
						type2 = enumBuilder.GetEnumUnderlyingType();
						if ((!enumBuilder.GetTypeBuilder().is_created || !(type == enumBuilder.GetTypeBuilder().created)) && !(type == type2))
						{
							TypeBuilder.throw_argument_ConstantDoesntMatch();
						}
					}
					else if ((typeBuilder = (destType as TypeBuilder)) != null)
					{
						type2 = typeBuilder.underlying_type;
						if (type2 == null || (type != typeBuilder.UnderlyingSystemType && type != type2))
						{
							TypeBuilder.throw_argument_ConstantDoesntMatch();
						}
					}
					else
					{
						type2 = Enum.GetUnderlyingType(destType);
						if (type != destType && type != type2)
						{
							TypeBuilder.throw_argument_ConstantDoesntMatch();
						}
					}
					type = type2;
				}
				else if (!destType.IsAssignableFrom(type))
				{
					TypeBuilder.throw_argument_ConstantDoesntMatch();
				}
				switch (Type.GetTypeCode(type))
				{
				case TypeCode.Boolean:
				case TypeCode.Char:
				case TypeCode.SByte:
				case TypeCode.Byte:
				case TypeCode.Int16:
				case TypeCode.UInt16:
				case TypeCode.Int32:
				case TypeCode.UInt32:
				case TypeCode.Int64:
				case TypeCode.UInt64:
				case TypeCode.Single:
				case TypeCode.Double:
					destValue = value;
					return true;
				case TypeCode.DateTime:
				{
					long ticks = ((DateTime)value).Ticks;
					destValue = ticks;
					return true;
				}
				case TypeCode.String:
					destValue = value;
					return true;
				}
				throw new ArgumentException(type.ToString() + " is not a supported constant type.");
			}
			destValue = null;
			return true;
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x00105643 File Offset: 0x00103843
		private static void throw_argument_ConstantDoesntMatch()
		{
			throw new ArgumentException("Constant does not match the defined type.");
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x0600530F RID: 21263 RVA: 0x000040F7 File Offset: 0x000022F7
		public override bool IsTypeDefinition
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0400331B RID: 13083
		private string tname;

		// Token: 0x0400331C RID: 13084
		private string nspace;

		// Token: 0x0400331D RID: 13085
		private Type parent;

		// Token: 0x0400331E RID: 13086
		private Type nesting_type;

		// Token: 0x0400331F RID: 13087
		internal Type[] interfaces;

		// Token: 0x04003320 RID: 13088
		internal int num_methods;

		// Token: 0x04003321 RID: 13089
		internal MethodBuilder[] methods;

		// Token: 0x04003322 RID: 13090
		internal ConstructorBuilder[] ctors;

		// Token: 0x04003323 RID: 13091
		internal PropertyBuilder[] properties;

		// Token: 0x04003324 RID: 13092
		internal int num_fields;

		// Token: 0x04003325 RID: 13093
		internal FieldBuilder[] fields;

		// Token: 0x04003326 RID: 13094
		internal EventBuilder[] events;

		// Token: 0x04003327 RID: 13095
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x04003328 RID: 13096
		internal TypeBuilder[] subtypes;

		// Token: 0x04003329 RID: 13097
		internal TypeAttributes attrs;

		// Token: 0x0400332A RID: 13098
		private int table_idx;

		// Token: 0x0400332B RID: 13099
		private ModuleBuilder pmodule;

		// Token: 0x0400332C RID: 13100
		private int class_size;

		// Token: 0x0400332D RID: 13101
		private PackingSize packing_size;

		// Token: 0x0400332E RID: 13102
		private IntPtr generic_container;

		// Token: 0x0400332F RID: 13103
		private GenericTypeParameterBuilder[] generic_params;

		// Token: 0x04003330 RID: 13104
		private RefEmitPermissionSet[] permissions;

		// Token: 0x04003331 RID: 13105
		private TypeInfo created;

		// Token: 0x04003332 RID: 13106
		private int state;

		// Token: 0x04003333 RID: 13107
		private TypeName fullname;

		// Token: 0x04003334 RID: 13108
		private bool createTypeCalled;

		// Token: 0x04003335 RID: 13109
		private Type underlying_type;

		/// <summary>Показывает, что полный размер типа не указан.</summary>
		// Token: 0x04003336 RID: 13110
		public const int UnspecifiedTypeSize = 0;
	}
}
