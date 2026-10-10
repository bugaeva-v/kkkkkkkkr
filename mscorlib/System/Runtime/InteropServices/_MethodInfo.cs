using System;
using System.Globalization;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет неуправляемому коду доступ к открытым элементам класса <see cref="T:System.Reflection.MethodInfo" />.</summary>
	// Token: 0x02000775 RID: 1909
	[ComVisible(true)]
	[TypeLibImportClass(typeof(MethodInfo))]
	[Guid("FFCC1B5D-ECB8-38DD-9B01-3DC8ABC2AA5F")]
	[CLSCompliant(false)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface _MethodInfo
	{
		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Когда выполнение этого метода завершается, содержит указатель, по которому записано число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе. Этот параметр передается неинициализированным.</param>
		// Token: 0x060043A1 RID: 17313
		void GetTypeInfoCount(out uint pcTInfo);

		/// <summary>Возвращает сведения о типе объекта, которые могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Указатель на объект с запрошенными сведениями о типе.</param>
		// Token: 0x060043A2 RID: 17314
		void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Массив сопоставляемых имен.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, выделенный вызывающим объектом, в который помещаются идентификаторы, соответствующие именам.</param>
		// Token: 0x060043A3 RID: 17315
		void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентификатор члена.</param>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Ссылка на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также количество элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		// Token: 0x060043A4 RID: 17316
		void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.ToString" />.</summary>
		/// <returns>Строка, представляющая текущий <see cref="T:System.Object" />.</returns>
		// Token: 0x060043A5 RID: 17317
		string ToString();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.Equals(System.Object)" />.</summary>
		/// <param name="other">Объект <see cref="T:System.Object" />, который необходимо сравнить с текущим объектом <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту <see cref="T:System.Object" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060043A6 RID: 17318
		bool Equals(object other);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetHashCode" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра.</returns>
		// Token: 0x060043A7 RID: 17319
		int GetHashCode();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />.</returns>
		// Token: 0x060043A8 RID: 17320
		Type GetType();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.MemberType" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Reflection.MemberTypes" />, указывающее тип члена.</returns>
		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060043A9 RID: 17321
		MemberTypes MemberType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.Name" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя этого члена.</returns>
		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060043AA RID: 17322
		string Name { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.DeclaringType" />.</summary>
		/// <returns>Объект <see langword="Type" /> для класса, объявляющего данный член.</returns>
		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x060043AB RID: 17323
		Type DeclaringType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.ReflectedType" />.</summary>
		/// <returns>Объект <see langword="Type" />, используемый для получения этого объекта <see langword="MemberInfo" />.</returns>
		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x060043AC RID: 17324
		Type ReflectedType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Искомый тип атрибута. Возвращаются только те атрибуты, которые можно назначить этому типу.</param>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив, содержащий пользовательские атрибуты, примененные к данному элементу, или массив нулей (0), если атрибуты не применялись.</returns>
		// Token: 0x060043AD RID: 17325
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" />.</summary>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив, содержащий все настраиваемые атрибуты, или массив нулей (0), если атрибуты не определены.</returns>
		// Token: 0x060043AE RID: 17326
		object[] GetCustomAttributes(bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Объект <see langword="Type" />, к которому применяются настраиваемые атрибуты.</param>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если к этому члену применяется один или несколько экземпляров параметра <paramref name="attributeType" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060043AF RID: 17327
		bool IsDefined(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.GetParameters" />.</summary>
		/// <returns>Массив типа <see cref="T:System.Reflection.ParameterInfo" />, содержащий сведения, которые соответствуют подписи метода (или конструктора), отражаемого этим экземпляром.</returns>
		// Token: 0x060043B0 RID: 17328
		ParameterInfo[] GetParameters();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.GetMethodImplementationFlags" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Reflection.MethodImplAttributes" />.</returns>
		// Token: 0x060043B1 RID: 17329
		MethodImplAttributes GetMethodImplementationFlags();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.MethodHandle" />.</summary>
		/// <returns>Объект <see cref="T:System.RuntimeMethodHandle" />.</returns>
		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x060043B2 RID: 17330
		RuntimeMethodHandle MethodHandle { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.Attributes" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Reflection.MethodAttributes" />.</returns>
		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x060043B3 RID: 17331
		MethodAttributes Attributes { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.CallingConvention" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Reflection.CallingConventions" />.</returns>
		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x060043B4 RID: 17332
		CallingConventions CallingConvention { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.Invoke(System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" />.</summary>
		/// <param name="obj">Экземпляр, создавший этот метод.</param>
		/// <param name="invokeAttr">Одно из значений <see langword="BindingFlags" />, определяющих тип связывания.</param>
		/// <param name="binder">
		///   <see langword="Binder" />, определяющий набор свойств и разрешающий связывание, приведение типов аргументов и вызов элементов с помощью отражения. Если параметр <paramref name="binder" /> принимает значение <see langword="null" />, используется свойство <see langword="Binder.DefaultBinding" />.</param>
		/// <param name="parameters">Массив типа <see langword="Object" />, используемый для проверки соответствия количества, порядка и типа параметрам данного конструктора, с учетом ограничений <paramref name="binder" />. Если этот конструктор не требует параметров, передается массив нулей, как в Object[] parameters = new Object[0]. Любой объект этого массива, который не был явно инициализирован с помощью значения, будет содержать значение по умолчанию для данного типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых соответствует значению, это значение равно 0, 0,0 или <see langword="false" />, в зависимости от заданного типа элемента.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый для управления приведением типов. Если значение этого объекта — <see langword="null" />, для текущего потока используется <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <returns>Экземпляр класса, связанного с конструктором.</returns>
		// Token: 0x060043B5 RID: 17333
		object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsPublic" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод является открытым; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x060043B6 RID: 17334
		bool IsPublic { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsPrivate" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу разрешен только элементам данного класса, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060043B7 RID: 17335
		bool IsPrivate { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsFamily" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу предоставляется только элементам данного класса и элементам производных классов, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060043B8 RID: 17336
		bool IsFamily { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsAssembly" />.</summary>
		/// <returns>Значение равно <see langword="true" />, если этот метод может вызываться другими классами этой же сборки, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060043B9 RID: 17337
		bool IsAssembly { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsFamilyAndAssembly" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу разрешен только элементам данного класса и элементам производных классов, которые находятся в той же сборке, ограничен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x060043BA RID: 17338
		bool IsFamilyAndAssembly { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsFamilyOrAssembly" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу разрешен только самим элементам данного класса, элементам производных классов, независимо от того, где они находятся, и элементам других классов, которые находятся в этой же сборке, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x060043BB RID: 17339
		bool IsFamilyOrAssembly { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsStatic" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод помечен атрибутом <see langword="static" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x060043BC RID: 17340
		bool IsStatic { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsFinal" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод помечен атрибутом <see langword="final" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x060043BD RID: 17341
		bool IsFinal { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsVirtual" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод помечен атрибутом <see langword="virtual" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x060043BE RID: 17342
		bool IsVirtual { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsHideBySig" />.</summary>
		/// <returns>Значение <see langword="true" />, если член скрыт на основе сигнатуры; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060043BF RID: 17343
		bool IsHideBySig { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsAbstract" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод является абстрактным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060043C0 RID: 17344
		bool IsAbstract { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsSpecialName" />.</summary>
		/// <returns>Значение <see langword="true" />, если у этого метода имеется специальное имя; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x060043C1 RID: 17345
		bool IsSpecialName { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsConstructor" />.</summary>
		/// <returns>Значение <see langword="true" />, если этот метод является конструктором, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x060043C2 RID: 17346
		bool IsConstructor { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.Invoke(System.Object,System.Object[])" />.</summary>
		/// <param name="obj">Экземпляр, создавший этот метод.</param>
		/// <param name="parameters">Список аргументов для вызываемого метода или конструктора. Это массив объектов, количество, порядок и тип которых должны соответствовать списку параметров вызываемого метода или конструктора. В отсутствие параметров значение <paramref name="parameters" /> должно быть равно <see langword="null" />.  
		/// Если метод или конструктор, представленный этим экземпляром, принимает параметр <see langword="ref" /> (<see langword="ByRef" /> в Visual Basic) для вызова метода или конструктора с использованием этой функции никакие специальные атрибуты не требуются. Любой объект этого массива, который не был явно инициализирован с помощью значения, будет содержать значение по умолчанию для данного типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых соответствует значению, это значение равно 0, 0,0 или <see langword="false" />, в зависимости от заданного типа элемента.</param>
		/// <returns>Экземпляр класса, связанного с конструктором.</returns>
		// Token: 0x060043C3 RID: 17347
		object Invoke(object obj, object[] parameters);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodInfo.ReturnType" />.</summary>
		/// <returns>Тип возвращаемого значения этого метода.</returns>
		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x060043C4 RID: 17348
		Type ReturnType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodInfo.ReturnTypeCustomAttributes" />.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.ICustomAttributeProvider" />, представляющий пользовательские атрибуты для возвращаемого типа.</returns>
		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x060043C5 RID: 17349
		ICustomAttributeProvider ReturnTypeCustomAttributes { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodInfo.GetBaseDefinition" />.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" /> для первой реализации этого метода.</returns>
		// Token: 0x060043C6 RID: 17350
		MethodInfo GetBaseDefinition();
	}
}
