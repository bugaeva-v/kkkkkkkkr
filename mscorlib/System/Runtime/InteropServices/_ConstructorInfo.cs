using System;
using System.Globalization;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет неуправляемому коду доступ к открытым элементам класса <see cref="T:System.Reflection.ConstructorInfo" />.</summary>
	// Token: 0x02000768 RID: 1896
	[ComVisible(true)]
	[TypeLibImportClass(typeof(ConstructorInfo))]
	[Guid("E9A19478-9646-3679-9B10-8411AE1FD57D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[CLSCompliant(false)]
	public interface _ConstructorInfo
	{
		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.Equals(System.Object)" />.</summary>
		/// <param name="other">Объект <see cref="T:System.Object" />, который необходимо сравнить с текущим объектом <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту <see cref="T:System.Object" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060042E2 RID: 17122
		bool Equals(object other);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" />.</summary>
		/// <param name="inherit">Определяет необходимость поиска цепочки наследования этого элемента для поиска атрибутов.</param>
		/// <returns>Массив, содержащий все настраиваемые атрибуты, или массив нулей (0), если атрибуты не определены.</returns>
		// Token: 0x060042E3 RID: 17123
		object[] GetCustomAttributes(bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Emit.MethodBuilder.GetCustomAttributes(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Искомый тип атрибута. Возвращаются только те атрибуты, которые можно назначить этому типу.</param>
		/// <param name="inherit">Определяет необходимость поиска цепочки наследования этого элемента для поиска атрибутов.</param>
		/// <returns>Массив, содержащий пользовательские атрибуты, примененные к данному элементу, или массив нулей (0), если атрибуты не применялись.</returns>
		// Token: 0x060042E4 RID: 17124
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetHashCode" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра.</returns>
		// Token: 0x060042E5 RID: 17125
		int GetHashCode();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к элементу <see cref="M:System.Reflection.MethodBase.GetMethodImplementationFlags" />.</summary>
		/// <returns>Флаги <see cref="T:System.Reflection.MethodImplAttributes" />.</returns>
		// Token: 0x060042E6 RID: 17126
		MethodImplAttributes GetMethodImplementationFlags();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.GetParameters" />.</summary>
		/// <returns>Массив типа <see cref="T:System.Reflection.ParameterInfo" />, содержащий сведения, которые соответствуют подписи метода (или конструктора), отражаемого этим экземпляром.</returns>
		// Token: 0x060042E7 RID: 17127
		ParameterInfo[] GetParameters();

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		// Token: 0x060042E8 RID: 17128
		void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		// Token: 0x060042E9 RID: 17129
		void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		// Token: 0x060042EA RID: 17130
		void GetTypeInfoCount(out uint pcTInfo);

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		// Token: 0x060042EB RID: 17131
		void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />.</returns>
		// Token: 0x060042EC RID: 17132
		Type GetType();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.ConstructorInfo.Invoke(System.Object[])" />.</summary>
		/// <param name="parameters">Массив значений, соответствующий по количеству, порядку и типу (с учетом ограничений связывателя по умолчанию) параметрам данного конструктора. Если этот конструктор не принимает параметров, то используется либо массив с нулевыми элементами, либо <see langword="null" />, как в Object[] parameters = new Object[0]. Любой объект этого массива, которому не присвоено значение явным образом, будет содержать значение по умолчанию для своего типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых передается по значению, это значение равно 0, 0,0 или <see langword="false" /> в зависимости от конкретного типа элемента.</param>
		/// <returns>Экземпляр класса, связанного с конструктором.</returns>
		// Token: 0x060042ED RID: 17133
		object Invoke_5(object[] parameters);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.Invoke(System.Object,System.Object[])" />.</summary>
		/// <param name="obj">Экземпляр, создавший этот метод.</param>
		/// <param name="parameters">Список аргументов для вызываемого метода или конструктора. Это массив объектов, количество, порядок и тип которых должны соответствовать списку параметров вызываемого метода или конструктора. Если параметров нет, для <paramref name="parameters" /> должно быть указано значение <see langword="null" />.  
		/// Если метод или конструктор, представленный этим экземпляром, принимает параметр <see langword="ref" /> (<see langword="ByRef" /> в Visual Basic), не требуются никакие специальные атрибуты для вызова этого метода или конструктора с использованием этой функции. Любой объект этого массива, который не был явно инициализирован с помощью значения, будет содержать значение по умолчанию для данного типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых передается по значению, это значение равно 0, 0,0 или <see langword="false" /> в зависимости от конкретного типа элемента.</param>
		/// <returns>Экземпляр класса, связанного с конструктором.</returns>
		// Token: 0x060042EE RID: 17134
		object Invoke_3(object obj, object[] parameters);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.ConstructorInfo.Invoke(System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" />.</summary>
		/// <param name="invokeAttr">Одно из значений <see langword="BindingFlags" />, определяющих тип связывания.</param>
		/// <param name="binder">
		///   <see langword="Binder" />, определяющий набор свойств и разрешающий связывание, приведение типов аргументов и вызов элементов с помощью отражения. Если параметр <paramref name="binder" /> принимает значение <see langword="null" />, используется свойство <see langword="Binder.DefaultBinding" />.</param>
		/// <param name="parameters">Массив типа <see langword="Object" />, используемый для проверки соответствия количества, порядка и типа параметрам данного конструктора, с учетом ограничений <paramref name="binder" />. Если этот конструктор не требует параметров, передается массив нулей, как в Object[] parameters = new Object[0]. Любой объект этого массива, который не был явно инициализирован с помощью значения, будет содержать значение по умолчанию для данного типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых передается по значению, это значение равно 0, 0,0 или <see langword="false" /> в зависимости от конкретного типа элемента.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый для управления приведением типов. Если значение этого объекта — <see langword="null" />, для текущего потока используется <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <returns>Экземпляр класса, связанного с конструктором.</returns>
		// Token: 0x060042EF RID: 17135
		object Invoke_4(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.Invoke(System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" />.</summary>
		/// <param name="obj">Экземпляр, создавший этот метод.</param>
		/// <param name="invokeAttr">Одно из значений <see langword="BindingFlags" />, определяющих тип связывания.</param>
		/// <param name="binder">
		///   <see langword="Binder" />, определяющий набор свойств и разрешающий связывание, приведение типов аргументов и вызов элементов с помощью отражения. Если параметр <paramref name="binder" /> принимает значение <see langword="null" />, используется свойство <see langword="Binder.DefaultBinding" />.</param>
		/// <param name="parameters">Массив типа <see langword="Object" />, используемый для проверки соответствия количества, порядка и типа параметрам данного конструктора, с учетом ограничений <paramref name="binder" />. Если этот конструктор не требует параметров, передается массив нулей, как в Object[] parameters = new Object[0]. Любой объект этого массива, который не был явно инициализирован с помощью значения, будет содержать значение по умолчанию для данного типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых передается по значению, это значение равно 0, 0,0 или <see langword="false" /> в зависимости от конкретного типа элемента.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый для управления приведением типов. Если значение этого объекта — <see langword="null" />, для текущего потока используется <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <returns>Экземпляр класса, связанного с конструктором.</returns>
		// Token: 0x060042F0 RID: 17136
		object Invoke_2(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к элементу <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Объект <see langword="Type" />, к которому применяются настраиваемые атрибуты.</param>
		/// <param name="inherit">Определяет необходимость поиска цепочки наследования этого элемента для поиска атрибутов.</param>
		/// <returns>Значение <see langword="true" />, если к этому элементу применяется один или несколько экземпляров параметра <paramref name="attributeType" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060042F1 RID: 17137
		bool IsDefined(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.ToString" />.</summary>
		/// <returns>Строка, представляющая текущий <see cref="T:System.Object" />.</returns>
		// Token: 0x060042F2 RID: 17138
		string ToString();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.Attributes" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Reflection.MethodAttributes" />.</returns>
		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060042F3 RID: 17139
		MethodAttributes Attributes { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.CallingConvention" />.</summary>
		/// <returns>Атрибуты <see cref="T:System.Reflection.CallingConventions" /> для этого метода.</returns>
		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060042F4 RID: 17140
		CallingConventions CallingConvention { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.DeclaringType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" /> для класса, объявляющего данный член.</returns>
		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060042F5 RID: 17141
		Type DeclaringType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsAbstract" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод является абстрактным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060042F6 RID: 17142
		bool IsAbstract { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsAssembly" />.</summary>
		/// <returns>Значение равно <see langword="true" />, если этот метод может вызываться другими классами этой же сборки, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x060042F7 RID: 17143
		bool IsAssembly { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsConstructor" />.</summary>
		/// <returns>Значение <see langword="true" />, если этот метод является конструктором, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060042F8 RID: 17144
		bool IsConstructor { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsFamily" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу предоставляется только элементам данного класса и элементам производных классов, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060042F9 RID: 17145
		bool IsFamily { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsFamilyAndAssembly" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу разрешен только элементам данного класса и элементам производных классов, которые находятся в той же сборке, ограничен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x060042FA RID: 17146
		bool IsFamilyAndAssembly { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsFamilyOrAssembly" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу разрешен только самим элементам данного класса, элементам производных классов, независимо от того, где они находятся, и элементам других классов, которые находятся в этой же сборке, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x060042FB RID: 17147
		bool IsFamilyOrAssembly { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsFinal" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод помечен атрибутом <see langword="final" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x060042FC RID: 17148
		bool IsFinal { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsHideBySig" />.</summary>
		/// <returns>Значение <see langword="true" />, если член скрыт на основе сигнатуры; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x060042FD RID: 17149
		bool IsHideBySig { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsPrivate" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу разрешен только элементам данного класса, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x060042FE RID: 17150
		bool IsPrivate { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsPublic" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод является открытым; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x060042FF RID: 17151
		bool IsPublic { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsSpecialName" />.</summary>
		/// <returns>Значение <see langword="true" />, если у этого метода имеется специальное имя; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06004300 RID: 17152
		bool IsSpecialName { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsStatic" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод помечен атрибутом <see langword="static" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06004301 RID: 17153
		bool IsStatic { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsVirtual" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод помечен атрибутом <see langword="virtual" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06004302 RID: 17154
		bool IsVirtual { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.ConstructorInfo.MemberType" />.</summary>
		/// <returns>Значение <see cref="T:System.Reflection.MemberTypes" />, показывающее тип элемента.</returns>
		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06004303 RID: 17155
		MemberTypes MemberType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.MethodHandle" />.</summary>
		/// <returns>Объект <see cref="T:System.RuntimeMethodHandle" />.</returns>
		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06004304 RID: 17156
		RuntimeMethodHandle MethodHandle { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.Name" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя данного элемента.</returns>
		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06004305 RID: 17157
		string Name { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.ReflectedType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, через который был получен данный объект <see cref="T:System.Reflection.MemberInfo" />.</returns>
		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06004306 RID: 17158
		Type ReflectedType { get; }
	}
}
