using System;
using System.Globalization;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет неуправляемому коду доступ к открытым элементам класса <see cref="T:System.Reflection.MethodBase" />.</summary>
	// Token: 0x02000773 RID: 1907
	[ComVisible(true)]
	[TypeLibImportClass(typeof(MethodBase))]
	[Guid("6240837A-707F-3181-8E98-A36AE086766B")]
	[CLSCompliant(false)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface _MethodBase
	{
		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.Equals(System.Object)" />.</summary>
		/// <param name="other">Объект <see cref="T:System.Object" />, который необходимо сравнить с текущим объектом <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту <see cref="T:System.Object" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600437A RID: 17274
		bool Equals(object other);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" />.</summary>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив, содержащий все настраиваемые атрибуты, или массив нулей (0), если атрибуты не определены.</returns>
		// Token: 0x0600437B RID: 17275
		object[] GetCustomAttributes(bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Искомый тип атрибута. Возвращаются только те атрибуты, которые можно назначить этому типу.</param>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив, содержащий пользовательские атрибуты, примененные к данному элементу, или массив нулей (0), если атрибуты не применялись.</returns>
		// Token: 0x0600437C RID: 17276
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetHashCode" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра.</returns>
		// Token: 0x0600437D RID: 17277
		int GetHashCode();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.GetMethodImplementationFlags" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Reflection.MethodImplAttributes" />.</returns>
		// Token: 0x0600437E RID: 17278
		MethodImplAttributes GetMethodImplementationFlags();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.GetParameters" />.</summary>
		/// <returns>Массив типа <see cref="T:System.Reflection.ParameterInfo" />, содержащий сведения, которые соответствуют подписи метода (или конструктора), отражаемого этим экземпляром.</returns>
		// Token: 0x0600437F RID: 17279
		ParameterInfo[] GetParameters();

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Массив сопоставляемых имен.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, выделенный вызывающим объектом, в который помещаются идентификаторы, соответствующие именам.</param>
		// Token: 0x06004380 RID: 17280
		void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

		/// <summary>Возвращает сведения о типе объекта, которые могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Указатель на объект с запрошенными сведениями о типе.</param>
		// Token: 0x06004381 RID: 17281
		void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Когда выполнение этого метода завершается, содержит указатель, по которому записано число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004382 RID: 17282
		void GetTypeInfoCount(out uint pcTInfo);

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентификатор члена.</param>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Ссылка на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также количество элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		// Token: 0x06004383 RID: 17283
		void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />.</returns>
		// Token: 0x06004384 RID: 17284
		Type GetType();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.Invoke(System.Object,System.Object[])" />.</summary>
		/// <param name="obj">Экземпляр, создавший этот метод.</param>
		/// <param name="parameters">Список аргументов для вызываемого метода или конструктора. Это массив объектов, количество, порядок и тип которых должны соответствовать списку параметров вызываемого метода или конструктора. В отсутствие параметров значение <paramref name="parameters" /> должно быть равно <see langword="null" />.  
		/// Если метод или конструктор, представленный этим экземпляром, принимает параметр <see langword="ref" /> (<see langword="ByRef" /> в Visual Basic) для вызова метода или конструктора с использованием этой функции никакие специальные атрибуты не требуются. Любой объект этого массива, который не был явно инициализирован с помощью значения, будет содержать значение по умолчанию для данного типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых соответствует значению, это значение равно 0, 0,0 или <see langword="false" />, в зависимости от заданного типа элемента.</param>
		/// <returns>Экземпляр класса, связанного с конструктором.</returns>
		// Token: 0x06004385 RID: 17285
		object Invoke(object obj, object[] parameters);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MethodBase.Invoke(System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" />.</summary>
		/// <param name="obj">Экземпляр, создавший этот метод.</param>
		/// <param name="invokeAttr">Одно из значений <see langword="BindingFlags" />, определяющих тип связывания.</param>
		/// <param name="binder">
		///   <see langword="Binder" />, определяющий набор свойств и разрешающий связывание, приведение типов аргументов и вызов элементов с помощью отражения. Если параметр <paramref name="binder" /> принимает значение <see langword="null" />, используется свойство <see langword="Binder.DefaultBinding" />.</param>
		/// <param name="parameters">Массив типа <see langword="Object" />, используемый для проверки соответствия количества, порядка и типа параметрам данного конструктора, с учетом ограничений <paramref name="binder" />. Если этот конструктор не требует параметров, передается массив нулей, как в Object[] parameters = new Object[0]. Любой объект этого массива, который не был явно инициализирован с помощью значения, будет содержать значение по умолчанию для данного типа объекта. Для элементов ссылочного типа это значение равно <see langword="null" />. Для элементов, тип которых соответствует значению, это значение равно 0, 0,0 или <see langword="false" />, в зависимости от заданного типа элемента.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый для управления приведением типов. Если значение этого объекта — <see langword="null" />, для текущего потока используется <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <returns>Экземпляр класса, связанного с конструктором.</returns>
		// Token: 0x06004386 RID: 17286
		object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Объект <see langword="Type" />, к которому применяются настраиваемые атрибуты.</param>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если к этому члену применяется один или несколько экземпляров параметра <paramref name="attributeType" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004387 RID: 17287
		bool IsDefined(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.ToString" />.</summary>
		/// <returns>Строка, представляющая текущий <see cref="T:System.Object" />.</returns>
		// Token: 0x06004388 RID: 17288
		string ToString();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.Attributes" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Reflection.MethodAttributes" />.</returns>
		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06004389 RID: 17289
		MethodAttributes Attributes { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.CallingConvention" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Reflection.CallingConventions" />.</returns>
		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x0600438A RID: 17290
		CallingConventions CallingConvention { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.DeclaringType" />.</summary>
		/// <returns>Объект <see langword="Type" /> для класса, объявляющего данный член.</returns>
		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x0600438B RID: 17291
		Type DeclaringType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsAbstract" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод является абстрактным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x0600438C RID: 17292
		bool IsAbstract { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsAssembly" />.</summary>
		/// <returns>Значение равно <see langword="true" />, если этот метод может вызываться другими классами этой же сборки, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x0600438D RID: 17293
		bool IsAssembly { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsConstructor" />.</summary>
		/// <returns>Значение <see langword="true" />, если этот метод является конструктором, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x0600438E RID: 17294
		bool IsConstructor { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsFamily" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу предоставляется только элементам данного класса и элементам производных классов, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x0600438F RID: 17295
		bool IsFamily { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsFamilyAndAssembly" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу разрешен только элементам данного класса и элементам производных классов, которые находятся в той же сборке, ограничен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06004390 RID: 17296
		bool IsFamilyAndAssembly { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsFamilyOrAssembly" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу разрешен только самим элементам данного класса, элементам производных классов, независимо от того, где они находятся, и элементам других классов, которые находятся в этой же сборке, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06004391 RID: 17297
		bool IsFamilyOrAssembly { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsFinal" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод помечен атрибутом <see langword="final" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06004392 RID: 17298
		bool IsFinal { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsHideBySig" />.</summary>
		/// <returns>Значение <see langword="true" />, если член скрыт на основе сигнатуры; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06004393 RID: 17299
		bool IsHideBySig { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsPrivate" />.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к этому методу разрешен только элементам данного класса, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06004394 RID: 17300
		bool IsPrivate { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsPublic" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод является открытым; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06004395 RID: 17301
		bool IsPublic { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsSpecialName" />.</summary>
		/// <returns>Значение <see langword="true" />, если у этого метода имеется специальное имя; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06004396 RID: 17302
		bool IsSpecialName { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsStatic" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод помечен атрибутом <see langword="static" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06004397 RID: 17303
		bool IsStatic { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.IsVirtual" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод помечен атрибутом <see langword="virtual" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06004398 RID: 17304
		bool IsVirtual { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.MemberType" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Reflection.MemberTypes" />, указывающее тип члена.</returns>
		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06004399 RID: 17305
		MemberTypes MemberType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MethodBase.MethodHandle" />.</summary>
		/// <returns>Объект <see cref="T:System.RuntimeMethodHandle" />.</returns>
		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x0600439A RID: 17306
		RuntimeMethodHandle MethodHandle { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.Name" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя этого члена.</returns>
		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x0600439B RID: 17307
		string Name { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к свойству <see cref="P:System.Reflection.MemberInfo.ReflectedType" />.</summary>
		/// <returns>Объект <see langword="Type" />, используемый для получения этого объекта <see langword="MemberInfo" />.</returns>
		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x0600439C RID: 17308
		Type ReflectedType { get; }
	}
}
