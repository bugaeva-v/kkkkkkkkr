using System;
using System.Globalization;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет неуправляемому коду доступ к открытым членам класса <see cref="T:System.Reflection.FieldInfo" />.</summary>
	// Token: 0x0200076F RID: 1903
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[TypeLibImportClass(typeof(FieldInfo))]
	[Guid("8A7C1442-A9FB-366B-80D8-4939FFA6DBE0")]
	[CLSCompliant(false)]
	[ComVisible(true)]
	public interface _FieldInfo
	{
		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.Equals(System.Object)" />.</summary>
		/// <param name="other">Объект <see cref="T:System.Object" />, с которым сравнивается текущий объект <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту <see cref="T:System.Object" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004340 RID: 17216
		bool Equals(object other);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" />.</summary>
		/// <param name="inherit">Указывает, следует ли выполнять поиск атрибутов в цепочке наследования этого члена.</param>
		/// <returns>Массив, содержащий все настраиваемые атрибуты, или массив с нулем элементов, если атрибуты не определены.</returns>
		// Token: 0x06004341 RID: 17217
		object[] GetCustomAttributes(bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Тип атрибута для поиска. Возвращаются только те атрибуты, которые можно назначить этому типу.</param>
		/// <param name="inherit">Указывает, следует ли выполнять поиск атрибутов в цепочке наследования этого члена.</param>
		/// <returns>Массив, содержащий пользовательские атрибуты, примененные к данному элементу, или массив с нулем (0) элементов, если атрибуты не применялись.</returns>
		// Token: 0x06004342 RID: 17218
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetHashCode" />.</summary>
		/// <returns>Хэш-код для текущего экземпляра.</returns>
		// Token: 0x06004343 RID: 17219
		int GetHashCode();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />.</returns>
		// Token: 0x06004344 RID: 17220
		Type GetType();

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		// Token: 0x06004345 RID: 17221
		void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		// Token: 0x06004346 RID: 17222
		void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		// Token: 0x06004347 RID: 17223
		void GetTypeInfoCount(out uint pcTInfo);

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		// Token: 0x06004348 RID: 17224
		void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.FieldInfo.GetValue(System.Object)" />.</summary>
		/// <param name="obj">Объект, значение поля которого будет возвращено.</param>
		/// <returns>Объект, содержащий значение поля, отраженное этим экземпляром.</returns>
		// Token: 0x06004349 RID: 17225
		object GetValue(object obj);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.FieldInfo.GetValueDirect(System.TypedReference)" />.</summary>
		/// <param name="obj">Структура <see cref="T:System.TypedReference" />, инкапсулирующая управляемый указатель на место и представление типа во время выполнения, которое может храниться в этом месте.</param>
		/// <returns>Объект <see cref="T:System.Object" />, содержащий значение поля.</returns>
		// Token: 0x0600434A RID: 17226
		object GetValueDirect(TypedReference obj);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Объект <see cref="T:System.Type" />, к которому применяются настраиваемые атрибуты.</param>
		/// <param name="inherit">Указывает, следует ли выполнять поиск атрибутов в цепочке наследования этого члена.</param>
		/// <returns>Значение <see langword="true" />, если к этому элементу применяется один или несколько экземпляров параметра <paramref name="attributeType" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600434B RID: 17227
		bool IsDefined(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.FieldInfo.SetValue(System.Object,System.Object)" />.</summary>
		/// <param name="obj">Объект, значение поля которого будет указано.</param>
		/// <param name="value">Значение, присваиваемое этому полю.</param>
		// Token: 0x0600434C RID: 17228
		void SetValue(object obj, object value);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.PropertyInfo.SetValue(System.Object,System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" />.</summary>
		/// <param name="obj">Объект, значение поля которого будет указано.</param>
		/// <param name="value">Значение, присваиваемое этому полю.</param>
		/// <param name="invokeAttr">Поле <see cref="T:System.Reflection.Binder" />, определяющее требуемый тип привязки (например, <see langword="Binder.CreateInstance" /> или <see langword="Binder.ExactBinding" />).</param>
		/// <param name="binder">Набор свойств, который позволяет осуществлять связывание, приведение типов аргументов и вызов элементов с помощью отражения. Если параметр <paramref name="binder" /> принимает значение <see langword="null" />, используется свойство <see langword="Binder.DefaultBinding" />.</param>
		/// <param name="culture">Программные настройки конкретного языка и региональных параметров.</param>
		// Token: 0x0600434D RID: 17229
		void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.FieldInfo.SetValueDirect(System.TypedReference,System.Object)" />.</summary>
		/// <param name="obj">Объект, значение поля которого будет указано.</param>
		/// <param name="value">Значение, присваиваемое этому полю.</param>
		// Token: 0x0600434E RID: 17230
		void SetValueDirect(TypedReference obj, object value);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.ToString" />.</summary>
		/// <returns>Строка, представляющая текущий объект <see cref="T:System.Object" />.</returns>
		// Token: 0x0600434F RID: 17231
		string ToString();

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.Attributes" />.</summary>
		/// <returns>Атрибуты <see cref="T:System.Reflection.FieldAttributes" /> для данного поля.</returns>
		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06004350 RID: 17232
		FieldAttributes Attributes { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.MemberInfo.DeclaringType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" /> для класса, объявляющего данный член.</returns>
		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06004351 RID: 17233
		Type DeclaringType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.FieldHandle" />.</summary>
		/// <returns>Дескриптор представления внутренних метаданных поля.</returns>
		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06004352 RID: 17234
		RuntimeFieldHandle FieldHandle { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.FieldType" />.</summary>
		/// <returns>Тип этого объекта поля.</returns>
		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06004353 RID: 17235
		Type FieldType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.IsAssembly" />.</summary>
		/// <returns>Значение <see langword="true" />, если для поля задан атрибут <see langword="Assembly" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06004354 RID: 17236
		bool IsAssembly { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.IsFamily" />.</summary>
		/// <returns>Значение <see langword="true" />, если для поля задан атрибут <see langword="Family" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06004355 RID: 17237
		bool IsFamily { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.IsFamilyAndAssembly" />.</summary>
		/// <returns>Значение <see langword="true" />, если для поля задан атрибут <see langword="FamANDAssem" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06004356 RID: 17238
		bool IsFamilyAndAssembly { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.IsFamilyOrAssembly" />.</summary>
		/// <returns>Значение <see langword="true" />, если для поля задан атрибут <see langword="FamORAssem" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06004357 RID: 17239
		bool IsFamilyOrAssembly { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.IsInitOnly" />.</summary>
		/// <returns>Значение <see langword="true" />, если для поля задан атрибут <see langword="InitOnly" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06004358 RID: 17240
		bool IsInitOnly { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.IsLiteral" />.</summary>
		/// <returns>Значение <see langword="true" />, если для поля задан атрибут <see langword="Literal" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06004359 RID: 17241
		bool IsLiteral { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.IsNotSerialized" />.</summary>
		/// <returns>Значение <see langword="true" />, если для поля задан атрибут <see langword="NotSerialized" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x0600435A RID: 17242
		bool IsNotSerialized { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.IsPinvokeImpl" />.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут <see langword="PinvokeImpl" /> установлен в классе <see cref="T:System.Reflection.FieldAttributes" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x0600435B RID: 17243
		bool IsPinvokeImpl { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.IsPrivate" />.</summary>
		/// <returns>Значение <see langword="true" />, если поле является закрытым; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x0600435C RID: 17244
		bool IsPrivate { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.IsPublic" />.</summary>
		/// <returns>Значение <see langword="true" />, если поле является открытым; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x0600435D RID: 17245
		bool IsPublic { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.IsSpecialName" />.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут <see langword="SpecialName" /> установлен в классе <see cref="T:System.Reflection.FieldAttributes" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x0600435E RID: 17246
		bool IsSpecialName { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.IsStatic" />.</summary>
		/// <returns>Значение <see langword="true" />, если поле является статическим; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x0600435F RID: 17247
		bool IsStatic { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.FieldInfo.MemberType" />.</summary>
		/// <returns>Значение <see cref="T:System.Reflection.MemberTypes" />, указывающее, что этот элемент является полем.</returns>
		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06004360 RID: 17248
		MemberTypes MemberType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.MemberInfo.Name" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя данного элемента.</returns>
		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06004361 RID: 17249
		string Name { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.MemberInfo.ReflectedType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, с помощью которого был получен данный объект.</returns>
		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06004362 RID: 17250
		Type ReflectedType { get; }
	}
}
