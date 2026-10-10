using System;
using System.Globalization;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет неуправляемому коду доступ к открытым членам класса <see cref="T:System.Reflection.PropertyInfo" />.</summary>
	// Token: 0x0200077C RID: 1916
	[TypeLibImportClass(typeof(PropertyInfo))]
	[Guid("F59ED4E4-E68F-3218-BD77-061AA82824BF")]
	[ComVisible(true)]
	[CLSCompliant(false)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface _PropertyInfo
	{
		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.Equals(System.Object)" />.</summary>
		/// <param name="other">Объект <see cref="T:System.Object" />, с которым сравнивается текущий объект <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту <see cref="T:System.Object" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060043DF RID: 17375
		bool Equals(object other);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.PropertyInfo.GetAccessors" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MethodInfo" />, которые отражают открытые методы <see langword="get" />, <see langword="set" /> и другие методы доступа к свойству, отображаемому текущим экземпляром, если эти методы существуют. В противном случае этот метод возвращает массив с нулевым (0) числом элементов.</returns>
		// Token: 0x060043E0 RID: 17376
		MethodInfo[] GetAccessors();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.PropertyInfo.GetAccessors(System.Boolean)" />.</summary>
		/// <param name="nonPublic">Значение <see langword="true" />, чтобы включить неоткрытые методы в возвращаемый массив <see langword="MethodInfo" />; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MethodInfo" />, элементы которого отражают методы <see langword="get" />, <see langword="set" /> и другие методы доступа к свойству, отражаемому текущим экземпляром. Если параметр <paramref name="nonPublic" /> имеет значение <see langword="true" />, этот массив содержит открытые и не являющиеся открытыми методы <see langword="get" />, <see langword="set" /> и другие методы доступа. Если свойство <paramref name="nonPublic" /> равно <see langword="false" />, этот массив содержит только открытые методы <see langword="get" />, <see langword="set" /> и другие методы доступа. Если методы доступа с указанным статусом видимости не найдены, этот метод возвращает массив с нулевым (0) числом элементов.</returns>
		// Token: 0x060043E1 RID: 17377
		MethodInfo[] GetAccessors(bool nonPublic);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" />.</summary>
		/// <param name="inherit">
		///   <see langword="true" /> для поиска атрибутов в цепочке наследования этого элемента. В противном случае — <see langword="false" />.</param>
		/// <returns>Массив, содержащий все настраиваемые атрибуты, или массив с нулем элементов, если атрибуты не определены.</returns>
		// Token: 0x060043E2 RID: 17378
		object[] GetCustomAttributes(bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Тип атрибута для поиска. Возвращаются только те атрибуты, которые можно назначить этому типу.</param>
		/// <param name="inherit">
		///   <see langword="true" /> для поиска атрибутов в цепочке наследования этого элемента. В противном случае — <see langword="false" />.</param>
		/// <returns>Массив, содержащий пользовательские атрибуты, примененные к данному элементу, или массив с нулем (0) элементов, если атрибуты не применялись.</returns>
		// Token: 0x060043E3 RID: 17379
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.PropertyInfo.GetGetMethod" />.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, предоставляющий открытый метод доступа <see langword="get" /> для этого свойства, или значение <see langword="null" />, если метод доступа <see langword="get" /> не является открытым либо не существует.</returns>
		// Token: 0x060043E4 RID: 17380
		MethodInfo GetGetMethod();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.PropertyInfo.GetGetMethod(System.Boolean)" />.</summary>
		/// <param name="nonPublic">Значение <see langword="true" />, чтобы возвратить не являющийся открытым метод доступа <see langword="get" />; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод доступа <see langword="get" /> для этого свойства, если параметр <paramref name="nonPublic" /> равен <see langword="true" />. Либо значение <see langword="null" />, если параметр <paramref name="nonPublic" /> равен <see langword="false" /> и метод доступа <see langword="get" /> не является открытым, или если параметр <paramref name="nonPublic" /> равен <see langword="true" /> и никаких методов доступа <see langword="get" /> не существует.</returns>
		// Token: 0x060043E5 RID: 17381
		MethodInfo GetGetMethod(bool nonPublic);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetHashCode" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра.</returns>
		// Token: 0x060043E6 RID: 17382
		int GetHashCode();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.PropertyInfo.GetIndexParameters" />.</summary>
		/// <returns>Массив элементов типа <see cref="T:System.Reflection.ParameterInfo" />, содержащий параметры для индексов.</returns>
		// Token: 0x060043E7 RID: 17383
		ParameterInfo[] GetIndexParameters();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.PropertyInfo.GetSetMethod" />.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод <see langword="Set" /> для этого свойства, если метод доступа <see langword="set" /> является открытым, или значение <see langword="null" />, если метод <see langword="set" /> не является открытым.</returns>
		// Token: 0x060043E8 RID: 17384
		MethodInfo GetSetMethod();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.PropertyInfo.GetSetMethod(System.Boolean)" />.</summary>
		/// <param name="nonPublic">Значение <see langword="true" />, чтобы возвратить не являющийся открытым метод доступа; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Одно из значений, перечисленных в следующей таблице.  
		///   Значение 
		///   Значение 
		///   Объект <see cref="T:System.Reflection.MethodInfo" />, предоставляющий метод <see langword="Set" /> для этого свойства.  
		///
		///   Метод доступа <see langword="set" /> является открытым.  
		///
		/// -или- 
		/// Параметр <paramref name="nonPublic" /> имеет значение <see langword="true" />, и метод доступа <see langword="set" /> не является открытым.  
		///
		///  <see langword="null" /> Параметр <paramref name="nonPublic" /> равен <see langword="true" />, но данное свойство предназначено только для чтения.  
		///
		/// - или - 
		/// Параметр <paramref name="nonPublic" /> имеет значение <see langword="false" />, и метод доступа <see langword="set" /> не является открытым.  
		///
		/// -или- 
		/// Метод доступа <see langword="set" /> не существует.</returns>
		// Token: 0x060043E9 RID: 17385
		MethodInfo GetSetMethod(bool nonPublic);

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Массив сопоставляемых имен.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, выделенный вызывающим объектом, в который помещаются идентификаторы, соответствующие именам.</param>
		// Token: 0x060043EA RID: 17386
		void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

		/// <summary>Возвращает сведения о типе объекта, которые можно использовать для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Указатель на объект с запрошенными сведениями о типе.</param>
		// Token: 0x060043EB RID: 17387
		void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Когда выполнение этого метода завершается, содержит указатель, по которому записано число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе. Этот параметр передается неинициализированным.</param>
		// Token: 0x060043EC RID: 17388
		void GetTypeInfoCount(out uint pcTInfo);

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентификатор члена.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель на место сохранения результата.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		// Token: 0x060043ED RID: 17389
		void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />.</returns>
		// Token: 0x060043EE RID: 17390
		Type GetType();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.PropertyInfo.GetValue(System.Object,System.Object[])" />.</summary>
		/// <param name="obj">Объект, свойство которого будет возвращено.</param>
		/// <param name="index">Необязательные значения индекса для индексированных свойств. Для неиндексированных свойств это значение должно быть равно <see langword="null" />.</param>
		/// <returns>Значение свойства для параметра <paramref name="obj" />.</returns>
		// Token: 0x060043EF RID: 17391
		object GetValue(object obj, object[] index);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.PropertyInfo.GetValue(System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" />.</summary>
		/// <param name="obj">Объект, свойство которого будет возвращено.</param>
		/// <param name="invokeAttr">Атрибут вызова. Это должен быть одноразрядный флаг из набора <see langword="BindingFlags" />: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> или <see langword="SetProperty" />. Необходимо указать подходящий атрибут вызова. Если будет вызываться статический член, следует установить флаг <see langword="Static" /> объекта <see langword="BindingFlags" />.</param>
		/// <param name="binder">Объект, который допускает привязку, приведение типов аргументов, вызов элементов и извлечение объектов <see langword="MemberInfo" /> путем отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="index">Необязательные значения индекса для индексированных свойств. Для неиндексированных свойств это значение должно быть равно <see langword="null" />.</param>
		/// <param name="culture">Объект <see langword="CultureInfo" />, представляющий язык и региональные параметры, для которых будет локализован ресурс. Обратите внимание, что в случае, если ресурс не локализован на данном языке, при поиске соответствия будет последовательно вызываться метод <see langword="CultureInfo.Parent" />. Если данное значение равно <see langword="null" />, объект <see langword="CultureInfo" /> извлекается из свойства <see langword="CultureInfo.CurrentUICulture" />.</param>
		/// <returns>Значение свойства для параметра <paramref name="obj" />.</returns>
		// Token: 0x060043F0 RID: 17392
		object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Объект <see cref="T:System.Type" />, к которому применяются настраиваемые атрибуты.</param>
		/// <param name="inherit">
		///   <see langword="true" /> для поиска атрибутов в цепочке наследования этого элемента. В противном случае — <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если к этому члену применяется один или несколько экземпляров параметра <paramref name="attributeType" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060043F1 RID: 17393
		bool IsDefined(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.PropertyInfo.SetValue(System.Object,System.Object,System.Object[])" />.</summary>
		/// <param name="obj">Объект, значение свойства которого будет установлено.</param>
		/// <param name="value">Новое значение для этого свойства.</param>
		/// <param name="index">Необязательные значения индекса для индексированных свойств. Для неиндексированных свойств это значение должно быть равно <see langword="null" />.</param>
		// Token: 0x060043F2 RID: 17394
		void SetValue(object obj, object value, object[] index);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.FieldInfo.SetValue(System.Object,System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Globalization.CultureInfo)" />.</summary>
		/// <param name="obj">Объект, свойство которого будет возвращено.</param>
		/// <param name="value">Новое значение для этого свойства.</param>
		/// <param name="invokeAttr">Атрибут вызова. Это должен быть одноразрядный флаг из набора <see cref="T:System.Reflection.BindingFlags" />: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" /> или <see langword="SetProperty" />. Необходимо указать подходящий атрибут вызова. Если будет вызываться статический член, следует установить флаг <see langword="Static" /> объекта <see langword="BindingFlags" />.</param>
		/// <param name="binder">Объект, который допускает привязку, приведение типов аргументов, вызов элементов и извлечение объектов <see cref="T:System.Reflection.MemberInfo" /> путем отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="index">Необязательные значения индекса для индексированных свойств. Для неиндексированных свойств это значение должно быть равно <see langword="null" />.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, представляющий язык и региональные параметры, для которых будет локализован ресурс. Обратите внимание, что в случае, если ресурс не локализован на данном языке, при поиске соответствия будет последовательно вызываться метод <see langword="CultureInfo.Parent" />. Если данное значение равно <see langword="null" />, объект <see langword="CultureInfo" /> извлекается из свойства <see langword="CultureInfo.CurrentUICulture" />.</param>
		// Token: 0x060043F3 RID: 17395
		void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.ToString" />.</summary>
		/// <returns>Строка, представляющая текущий объект <see cref="T:System.Object" />.</returns>
		// Token: 0x060043F4 RID: 17396
		string ToString();

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.PropertyInfo.Attributes" />.</summary>
		/// <returns>Атрибуты данного свойства.</returns>
		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x060043F5 RID: 17397
		PropertyAttributes Attributes { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.PropertyInfo.CanRead" />.</summary>
		/// <returns>Значение <see langword="true" />, если свойство доступно для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x060043F6 RID: 17398
		bool CanRead { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.PropertyInfo.CanWrite" />.</summary>
		/// <returns>Значение <see langword="true" />, если свойство доступно для записи; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x060043F7 RID: 17399
		bool CanWrite { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.MemberInfo.DeclaringType" />.</summary>
		/// <returns>Объект <see langword="Type" /> для класса, объявляющего данный член.</returns>
		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060043F8 RID: 17400
		Type DeclaringType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.PropertyInfo.IsSpecialName" />.</summary>
		/// <returns>Значение <see langword="true" />, если свойство является особым именем; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060043F9 RID: 17401
		bool IsSpecialName { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.PropertyInfo.MemberType" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Reflection.MemberTypes" />, показывающее, что этот член является свойством.</returns>
		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060043FA RID: 17402
		MemberTypes MemberType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.MemberInfo.Name" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя этого члена.</returns>
		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060043FB RID: 17403
		string Name { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.PropertyInfo.PropertyType" />.</summary>
		/// <returns>Тип этого свойства.</returns>
		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060043FC RID: 17404
		Type PropertyType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.MemberInfo.ReflectedType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, с помощью которого был получен данный объект <see cref="T:System.Reflection.MemberInfo" />.</returns>
		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x060043FD RID: 17405
		Type ReflectedType { get; }
	}
}
