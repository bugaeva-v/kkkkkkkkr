using System;
using System.Globalization;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет неуправляемому коду доступ к открытым элементам класса <see cref="T:System.Type" />.</summary>
	// Token: 0x0200077F RID: 1919
	[ComVisible(true)]
	[CLSCompliant(false)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("BCA8B44D-AAD6-3A86-8AB7-03349F4F2DA2")]
	[TypeLibImportClass(typeof(Type))]
	public interface _Type
	{
		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		// Token: 0x06004406 RID: 17414
		void GetTypeInfoCount(out uint pcTInfo);

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		// Token: 0x06004407 RID: 17415
		void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		// Token: 0x06004408 RID: 17416
		void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		// Token: 0x06004409 RID: 17417
		void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.ToString" />.</summary>
		/// <returns>Объект типа <see cref="T:System.String" />, представляющий имя текущего объекта <see cref="T:System.Type" />.</returns>
		// Token: 0x0600440A RID: 17418
		string ToString();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.Equals(System.Object)" />.</summary>
		/// <param name="other">Объект <see cref="T:System.Object" />, базовый системный тип которого сравнивается с базовым системным типом текущего типа <see cref="T:System.Type" />.</param>
		/// <returns>Значение <see langword="true" />, если базовый системный тип параметра <paramref name="o" /> совпадает с базовым системным типом текущего объекта <see cref="T:System.Type" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600440B RID: 17419
		bool Equals(object other);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetHashCode" />.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, содержащее хэш-код данного экземпляра.</returns>
		// Token: 0x0600440C RID: 17420
		int GetHashCode();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetType" />.</summary>
		/// <returns>Текущий контекст <see cref="T:System.Type" />.</returns>
		// Token: 0x0600440D RID: 17421
		Type GetType();

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.MemberType" />.</summary>
		/// <returns>Значение <see cref="T:System.Reflection.MemberTypes" />, позволяющее определить, каким типом является этот член: обычным или вложенным.</returns>
		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x0600440E RID: 17422
		MemberTypes MemberType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.MemberInfo.Name" />.</summary>
		/// <returns>Имя <see cref="T:System.Type" />.</returns>
		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x0600440F RID: 17423
		string Name { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.DeclaringType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" /> для класса, объявляющего данный член. Если данный тип является вложенным, это свойство возвращает тип, в который он вложен.</returns>
		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06004410 RID: 17424
		Type DeclaringType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.ReflectedType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, с помощью которого был получен данный объект <see cref="T:System.Reflection.MemberInfo" />.</returns>
		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06004411 RID: 17425
		Type ReflectedType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Тип атрибута для поиска. Возвращаются только те атрибуты, которые можно назначить этому типу.</param>
		/// <param name="inherit">Указывает, следует ли выполнять поиск атрибутов в цепочке наследования этого члена.</param>
		/// <returns>Массив, содержащий пользовательские атрибуты, примененные к данному элементу, или массив с нулем (0) элементов, если атрибуты не применялись.</returns>
		// Token: 0x06004412 RID: 17426
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetCustomAttributes(System.Boolean)" />.</summary>
		/// <param name="inherit">Указывает, следует ли выполнять поиск атрибутов в цепочке наследования этого члена.</param>
		/// <returns>Массив, содержащий пользовательские атрибуты, примененные к данному элементу, или массив с нулем (0) элементов, если атрибуты не применялись.</returns>
		// Token: 0x06004413 RID: 17427
		object[] GetCustomAttributes(bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Объект <see langword="Type" />, к которому применяются настраиваемые атрибуты.</param>
		/// <param name="inherit">Указывает, следует ли выполнять поиск атрибутов в цепочке наследования этого члена.</param>
		/// <returns>Значение <see langword="true" />, если к этому элементу применяется один или несколько экземпляров параметра <paramref name="attributeType" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004414 RID: 17428
		bool IsDefined(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.GUID" />.</summary>
		/// <returns>Идентификатор GUID, связанный с объектом <see cref="T:System.Type" />.</returns>
		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06004415 RID: 17429
		Guid GUID { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.Module" />.</summary>
		/// <returns>Имя модуля, в котором определен текущий тип <see cref="T:System.Type" />.</returns>
		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06004416 RID: 17430
		Module Module { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.Assembly" />.</summary>
		/// <returns>Экземпляр <see cref="T:System.Reflection.Assembly" />, описывающий сборку, которая содержит текущий тип.</returns>
		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06004417 RID: 17431
		Assembly Assembly { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.TypeHandle" />.</summary>
		/// <returns>Дескриптор текущего объекта <see cref="T:System.Type" />.</returns>
		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06004418 RID: 17432
		RuntimeTypeHandle TypeHandle { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.FullName" />.</summary>
		/// <returns>Строка, которая содержит полное имя объекта <see cref="T:System.Type" />, включая пространство имен <see cref="T:System.Type" />, но не включая сборку.</returns>
		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06004419 RID: 17433
		string FullName { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.Namespace" />.</summary>
		/// <returns>Пространство имен <see cref="T:System.Type" />.</returns>
		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x0600441A RID: 17434
		string Namespace { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.AssemblyQualifiedName" />.</summary>
		/// <returns>Имя объекта <see cref="T:System.Type" /> с указанием сборки, включающее имя сборки, из которой был загружен объект <see cref="T:System.Type" />.</returns>
		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x0600441B RID: 17435
		string AssemblyQualifiedName { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetArrayRank" />.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, содержащее количество измерений текущего <see cref="T:System.Type" />.</returns>
		// Token: 0x0600441C RID: 17436
		int GetArrayRank();

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.BaseType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, прямым наследником которого является текущий объект <see cref="T:System.Type" />, или <see langword="null" />, если текущий объект <see langword="Type" /> представляет класс <see cref="T:System.Object" />.</returns>
		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x0600441D RID: 17437
		Type BaseType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetConstructors(System.Reflection.BindingFlags)" />.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		///
		/// или - 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.ConstructorInfo" />, представляющий все конструкторы, определенные для текущего объекта <see cref="T:System.Type" /> и удовлетворяющие указанным ограничениям привязки, в том числе и инициализатор типа, если он определен. Возвращает пустой массив типа <see cref="T:System.Reflection.ConstructorInfo" />, если для текущего типа <see cref="T:System.Type" /> не определены конструкторы, если не один из определенных конструкторов не соответствует ограничениям на связывание, или если текущий тип <see cref="T:System.Type" /> представляет собой параметр универсального типа или определение метода.</returns>
		// Token: 0x0600441E RID: 17438
		ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetInterface(System.String,System.Boolean)" />.</summary>
		/// <param name="name">Строка типа <see cref="T:System.String" />, содержащая имя искомого интерфейса. Для универсальных интерфейсов это искаженное имя.</param>
		/// <param name="ignoreCase">Если этот параметр равен <see langword="true" />, то при поиске по параметру <paramref name="name" /> регистр букв не учитывается.  
		/// -или- 
		///  Если этот параметр равен <see langword="false" />, то при поиске по параметру <paramref name="name" /> учитывается регистр букв.</param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий интерфейс с заданным именем, который реализуется или наследуется текущим объектом <see cref="T:System.Type" />, если такой интерфейс существует; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x0600441F RID: 17439
		Type GetInterface(string name, bool ignoreCase);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetInterfaces" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющий все интерфейсы, реализуемые или наследуемые текущим типом <see cref="T:System.Type" />.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Type" /> в случае отсутствия интерфейсов, реализуемых или наследуемых текущим типом <see cref="T:System.Type" />.</returns>
		// Token: 0x06004420 RID: 17440
		Type[] GetInterfaces();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.FindInterfaces(System.Reflection.TypeFilter,System.Object)" />.</summary>
		/// <param name="filter">Делегат <see cref="T:System.Reflection.TypeFilter" />, сравнивающий интерфейсы с параметром <paramref name="filterCriteria" />.</param>
		/// <param name="filterCriteria">Критерий поиска, определяющий, должен ли тот или иной интерфейс включаться в возвращаемый массив.</param>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющий отфильтрованный список интерфейсов, реализованных или наследуемых текущим типом <see cref="T:System.Type" />.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Type" />, если отсутствуют интерфейсы, реализованные или наследуемые текущим типом <see cref="T:System.Type" /> и удовлетворяющие заданному фильтру.</returns>
		// Token: 0x06004421 RID: 17441
		Type[] FindInterfaces(TypeFilter filter, object filterCriteria);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetEvent(System.String,System.Reflection.BindingFlags)" />.</summary>
		/// <param name="name">Строка типа <see cref="T:System.String" />, содержащая имя события, которое объявлено или унаследовано текущим типом <see cref="T:System.Type" />.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		///
		/// или - 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.EventInfo" />, представляющий указанное событие, которое объявлено или унаследовано текущим типом <see cref="T:System.Type" />, если такое событие найдено; <see langword="null" /> в противном случае.</returns>
		// Token: 0x06004422 RID: 17442
		EventInfo GetEvent(string name, BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetEvents" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.EventInfo" />, представляющий все открытые события, которые объявлены или унаследованы в текущем объекте <see cref="T:System.Type" />.  
		///
		/// или - 
		/// Пустой массив типа <see cref="T:System.Reflection.EventInfo" />, если в текущем объекте <see cref="T:System.Type" /> нет открытых событий.</returns>
		// Token: 0x06004423 RID: 17443
		EventInfo[] GetEvents();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetEvents(System.Reflection.BindingFlags)" />.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.EventInfo" />, представляющий все события, которые объявлены или унаследованы данным объектом <see cref="T:System.Type" /> и удовлетворяют указанным ограничениям привязки.  
		///
		/// или - 
		/// Пустой массив типа <see cref="T:System.Reflection.EventInfo" />, если у текущего типа <see cref="T:System.Type" /> нет событий или ни одно событие не удовлетворяет ограничениям привязки.</returns>
		// Token: 0x06004424 RID: 17444
		EventInfo[] GetEvents(BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к методу <see cref="M:System.Type.GetNestedTypes(System.Reflection.BindingFlags)" /> и выполняет поиск типов, вложенных в текущий тип <see cref="T:System.Type" />, используя заданные ограничения на связывание.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющий все типы, вложенные внутри текущего типа <see cref="T:System.Type" /> и удовлетворяющие указанным ограничениям привязки.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Type" />, если внутри текущего объекта <see cref="T:System.Type" /> нет вложенных типов или ни один из вложенных типов не удовлетворяет ограничениям привязки.</returns>
		// Token: 0x06004425 RID: 17445
		Type[] GetNestedTypes(BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetNestedType(System.String,System.Reflection.BindingFlags)" />.</summary>
		/// <param name="name">Строка, содержащая имя искомого вложенного типа.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Если поиск выполнен успешно, возвращается объект <see cref="T:System.Type" />, предоставляющий вложенный тип, который соответствует указанным требованиям; в противном случае возвращается <see langword="null" />.</returns>
		// Token: 0x06004426 RID: 17446
		Type GetNestedType(string name, BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMember(System.String,System.Reflection.MemberTypes,System.Reflection.BindingFlags)" />.</summary>
		/// <param name="name">Строка типа <see cref="T:System.String" />, содержащая имя для поиска членов.</param>
		/// <param name="type">Искомое значение <see cref="T:System.Reflection.MemberTypes" />.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Ноль для возвращения пустого массива.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющий открытые члены с заданным именем, если такие члены есть, и пустой массив, если таких членов нет.</returns>
		// Token: 0x06004427 RID: 17447
		MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetDefaultMembers" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющий все члены по умолчанию текущего объекта <see cref="T:System.Type" />.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.MemberInfo" />, если у текущего типа <see cref="T:System.Type" /> нет членов по умолчанию.</returns>
		// Token: 0x06004428 RID: 17448
		MemberInfo[] GetDefaultMembers();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.FindMembers(System.Reflection.MemberTypes,System.Reflection.BindingFlags,System.Reflection.MemberFilter,System.Object)" />.</summary>
		/// <param name="memberType">Объект <see langword="MemberTypes" />, показывающий тип члена, который нужно найти.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		///
		/// или - 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="filter">Делегат, выполняющий сравнение и возвращающий <see langword="true" />, если проверяемый член соответствует условиям, заданным в параметре <paramref name="filterCriteria" />, и <see langword="false" /> в противном случае. Можно использовать делегаты <see langword="FilterAttribute" />, <see langword="FilterName" /> и <see langword="FilterNameIgnoreCase" />, предоставляемые этим классом. Первый делегат в качестве условий поиска использует поля классов <see langword="FieldAttributes" />, <see langword="MethodAttributes" /> и <see langword="MethodImplAttributes" />, а два других делегата — объекты <see langword="String" />.</param>
		/// <param name="filterCriteria">Условие поиска, определяющее, будет ли член включен в возвращаемый массив объектов <see langword="MemberInfo" />.  
		/// Поля классов <see langword="FieldAttributes" />, <see langword="MethodAttributes" /> и <see langword="MethodImplAttributes" /> могут использоваться вместе с делегатом <see langword="FilterAttribute" />, предоставляемым этим классом.</param>
		/// <returns>Отфильтрованный массив объектов <see cref="T:System.Reflection.MemberInfo" />, имеющих тип указанного члена.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Reflection.MemberInfo" />, если у текущего типа <see cref="T:System.Type" /> нет членов типа <paramref name="memberType" />, удовлетворяющих условиям фильтра.</returns>
		// Token: 0x06004429 RID: 17449
		MemberInfo[] FindMembers(MemberTypes memberType, BindingFlags bindingAttr, MemberFilter filter, object filterCriteria);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetElementType" />.</summary>
		/// <returns>Тип объекта (<see cref="T:System.Type" />), который содержится в текущем массиве или ссылка на который содержится в текущем массиве или на который ссылается указательный или ссылочный тип.  
		/// -или- 
		///  Значение <see langword="null" />, если текущий тип <see cref="T:System.Type" /> не является массивом или указателем, или не передается по ссылке, или представляет собой универсальный тип либо определением метода.</returns>
		// Token: 0x0600442A RID: 17450
		Type GetElementType();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.IsSubclassOf(System.Type)" />.</summary>
		/// <param name="c">Объект <see cref="T:System.Type" />, с которым сравнивается текущий объект <see cref="T:System.Type" />.</param>
		/// <returns>Значение <see langword="true" />, если тип <see cref="T:System.Type" />, представленный параметром <paramref name="c" />, и текущий тип <see cref="T:System.Type" /> представляют классы, и класс, представленный текущим типом <see cref="T:System.Type" />, является производным от класса, представленного параметром <paramref name="c" />; в противном случае — значение <see langword="false" />. Этот метод также возвращает значение <see langword="false" />, если параметр <paramref name="c" /> и текущий объект <see cref="T:System.Type" /> представляют один и тот же класс.</returns>
		// Token: 0x0600442B RID: 17451
		bool IsSubclassOf(Type c);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.IsInstanceOfType(System.Object)" />.</summary>
		/// <param name="o">Объект, который требуется сравнить с текущим объектом <see cref="T:System.Type" />.</param>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Type" /> входит в иерархию наследования объекта, представленного параметром <paramref name="o" /> или если текущий объект <see cref="T:System.Type" /> является интерфейсом, поддерживаемым параметром <paramref name="o" />. Значение <see langword="false" />, если не выполняется ни одно из перечисленных условий, или параметр <paramref name="o" /> имеет значение <see langword="null" />, или текущий объект <see cref="T:System.Type" /> является открытым универсальным типом (то есть свойство <see cref="P:System.Type.ContainsGenericParameters" /> возвращает значение <see langword="true" />).</returns>
		// Token: 0x0600442C RID: 17452
		bool IsInstanceOfType(object o);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.IsAssignableFrom(System.Type)" />.</summary>
		/// <param name="c">Объект <see cref="T:System.Type" />, с которым сравнивается текущий объект <see cref="T:System.Type" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="c" /> и текущий объект <see cref="T:System.Type" /> представляют один и тот же тип, если текущий объект <see cref="T:System.Type" /> входит в иерархию наследования параметра <paramref name="c" />, если текущий объект <see cref="T:System.Type" /> является интерфейсом, который реализуется параметром <paramref name="c" />, или если параметр <paramref name="c" /> является параметром универсального типа и текущий объект <see cref="T:System.Type" /> представляет одно из ограничений параметра <paramref name="c" />. Значение <see langword="false" />, если не выполняется ни одно из этих условий или значение параметра <paramref name="c" /> равно <see langword="null" />.</returns>
		// Token: 0x0600442D RID: 17453
		bool IsAssignableFrom(Type c);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetInterfaceMap(System.Type)" />.</summary>
		/// <param name="interfaceType">Тип <see cref="T:System.Type" />, соответствующий интерфейсу, для которого необходимо найти совпадение.</param>
		/// <returns>Объект <see cref="T:System.Reflection.InterfaceMapping" />, который представляет сопоставление интерфейса для параметра <paramref name="interfaceType" />.</returns>
		// Token: 0x0600442E RID: 17454
		InterfaceMapping GetInterfaceMap(Type interfaceType);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Type[],System.Reflection.ParameterModifier[])" />.</summary>
		/// <param name="name">Строка типа <see cref="T:System.String" />, содержащая имя искомого метода.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект <see cref="T:System.Reflection.Binder" />, определяющий набор свойств и разрешающий привязку, что может быть сопряжено с выбором перегружаемых методов, приведением типов аргументов и вызовом члена с помощью отражения.  
		/// -или- 
		///  Значение <see langword="null" />, чтобы использовать свойство <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого метода.  
		///
		/// или - 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить метод, который не имеет параметров.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект <see cref="T:System.Reflection.MethodInfo" />, предоставляющий метод, который соответствует указанным требованиям; в противном случае возвращается <see langword="null" />.</returns>
		// Token: 0x0600442F RID: 17455
		MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags)" />.</summary>
		/// <param name="name">Строка типа <see cref="T:System.String" />, содержащая имя искомого метода.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект <see cref="T:System.Reflection.MethodInfo" />, предоставляющий метод, который соответствует указанным требованиям; в противном случае возвращается <see langword="null" />.</returns>
		// Token: 0x06004430 RID: 17456
		MethodInfo GetMethod(string name, BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMethods(System.Reflection.BindingFlags)" />.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MethodInfo" />, представляющий все методы, определенные для текущего типа <see cref="T:System.Type" /> и удовлетворяющие указанным ограничениям привязки.  
		///
		/// или - 
		/// Пустой массив типа <see cref="T:System.Reflection.MethodInfo" />, если для текущего объекта <see cref="T:System.Type" /> не определены методы или ни один из определенных методов не удовлетворяет ограничениям привязки.</returns>
		// Token: 0x06004431 RID: 17457
		MethodInfo[] GetMethods(BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetField(System.String,System.Reflection.BindingFlags)" />.</summary>
		/// <param name="name">Объект <see cref="T:System.String" />, содержащий имя искомого поля данных.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.FieldInfo" />, представляющий поле, соответствующее заданным требованиям, если такое поле существует, и <see langword="null" />, если такого поля нет.</returns>
		// Token: 0x06004432 RID: 17458
		FieldInfo GetField(string name, BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetFields(System.Reflection.BindingFlags)" />.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.FieldInfo" />, представляющий все поля, определенные для текущего типа <see cref="T:System.Type" /> и удовлетворяющие указанным ограничениям привязки.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.FieldInfo" />, если для текущего объекта <see cref="T:System.Type" /> не определены поля или ни одно из определенных полей не удовлетворяет ограничениям привязки.</returns>
		// Token: 0x06004433 RID: 17459
		FieldInfo[] GetFields(BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetProperty(System.String,System.Reflection.BindingFlags)" />.</summary>
		/// <param name="name">Объект типа <see cref="T:System.String" />, содержащий имя искомого свойства.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.PropertyInfo" />, предоставляющий свойство, которое соответствует указанным требованиям, если такое свойство найдено; в противном случае возвращается <see langword="null" />.</returns>
		// Token: 0x06004434 RID: 17460
		PropertyInfo GetProperty(string name, BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetProperty(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Type,System.Type[],System.Reflection.ParameterModifier[])" />.</summary>
		/// <param name="name">Объект типа <see cref="T:System.String" />, содержащий имя искомого свойства.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект <see cref="T:System.Reflection.Binder" />, определяющий набор свойств и разрешающий привязку, что может быть сопряжено с выбором перегружаемых методов, приведением типов аргументов и вызовом члена с помощью отражения.  
		///
		/// или - 
		/// Значение <see langword="null" />, чтобы использовать свойство <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="returnType">Тип возвращаемого значения свойства.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого индексированного свойства.  
		///
		/// или - 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить неиндексированное свойство.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Объект <see cref="T:System.Reflection.PropertyInfo" />, предоставляющий свойство, которое соответствует указанным требованиям, если такое свойство найдено; в противном случае возвращается <see langword="null" />.</returns>
		// Token: 0x06004435 RID: 17461
		PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetProperties(System.Reflection.BindingFlags)" />.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		///
		/// или - 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.PropertyInfo" />, представляющий все свойства текущего типа <see cref="T:System.Type" />, которые удовлетворяют указанным ограничениям привязки.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.PropertyInfo" />, если у текущего типа <see cref="T:System.Type" /> нет свойств или ни одно свойство не удовлетворяет ограничениям привязки.</returns>
		// Token: 0x06004436 RID: 17462
		PropertyInfo[] GetProperties(BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMember(System.String,System.Reflection.BindingFlags)" />.</summary>
		/// <param name="name">Строка типа <see cref="T:System.String" />, содержащая имя для поиска членов.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		///
		/// или - 
		/// Ноль для возвращения пустого массива.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющий открытые члены с заданным именем, если такие члены есть, и пустой массив, если таких членов нет.</returns>
		// Token: 0x06004437 RID: 17463
		MemberInfo[] GetMember(string name, BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMembers(System.Reflection.BindingFlags)" />.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющий все члены, определенные для текущего типа <see cref="T:System.Type" /> и удовлетворяющие указанным ограничениям привязки.  
		///
		/// или - 
		/// Пустой массив типа <see cref="T:System.Reflection.MemberInfo" />, если для текущего объекта <see cref="T:System.Type" /> не определены члены или ни один из определенных членов не удовлетворяет ограничениям привязки.</returns>
		// Token: 0x06004438 RID: 17464
		MemberInfo[] GetMembers(BindingFlags bindingAttr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" />.</summary>
		/// <param name="name">Объект типа <see cref="T:System.String" />, содержащий имя вызываемого члена: конструктора, метода, свойства или поля.  
		/// -или- 
		/// Пустая строка ("") — в этом случае будет вызван член по умолчанию.  
		/// -или- 
		/// Для элементов IDispatch — строка, представляющая DispID, например "[DispID=3]".</param>
		/// <param name="invokeAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск. Тип доступа может быть обозначен одним из флагов <see langword="BindingFlags" />, например <see langword="Public" />, <see langword="NonPublic" />, <see langword="Private" />, <see langword="InvokeMethod" />, <see langword="GetField" /> и т.д. Тип поиска указывать необязательно. Если тип поиска не указан, используются флаги <see langword="BindingFlags.Public" /> | <see langword="BindingFlags.Instance" />.</param>
		/// <param name="binder">Объект <see cref="T:System.Reflection.Binder" />, определяющий набор свойств и разрешающий привязку, что может быть сопряжено с выбором перегружаемых методов, приведением типов аргументов и вызовом члена с помощью отражения.  
		/// -или- 
		///  Значение <see langword="null" />, чтобы использовать свойство <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="target">
		///   <see cref="T:System.Object" />, для которого будет вызван указанный элемент.</param>
		/// <param name="args">Массив с аргументами, передаваемыми вызываемому члену.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="args" />. Атрибуты, связанные с параметром, хранятся в сигнатуре члена. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, представляющий используемый языковой стандарт глобализации. Он может понадобиться для выполнения преобразований, зависящих от языкового стандарта, например приведения числа в строковом формате к типу Double.  
		/// -или- 
		///  <see langword="null" />, для использования объекта <see cref="T:System.Globalization.CultureInfo" /> текущего потока.</param>
		/// <param name="namedParameters">Массив, содержащий имена параметров, в которые передаются значения элементов массива <paramref name="args" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий значение, возвращаемое указанным членом.</returns>
		// Token: 0x06004439 RID: 17465
		object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.UnderlyingSystemType" />.</summary>
		/// <returns>Базовый системный тип текущего типа <see cref="T:System.Type" />.</returns>
		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x0600443A RID: 17466
		Type UnderlyingSystemType { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Globalization.CultureInfo)" />.</summary>
		/// <param name="name">Объект типа <see cref="T:System.String" />, содержащий имя вызываемого члена: конструктора, метода, свойства или поля.  
		/// -или- 
		/// Пустая строка ("") — в этом случае будет вызван член по умолчанию.  
		/// -или- 
		/// Для элементов IDispatch — строка, представляющая DispID, например "[DispID=3]".</param>
		/// <param name="invokeAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск. Тип доступа может быть обозначен одним из флагов <see langword="BindingFlags" />, например <see langword="Public" />, <see langword="NonPublic" />, <see langword="Private" />, <see langword="InvokeMethod" />, <see langword="GetField" /> и т.д. Тип поиска указывать необязательно. Если тип поиска не указан, используются флаги <see langword="BindingFlags.Public" /> | <see langword="BindingFlags.Instance" />.</param>
		/// <param name="binder">Объект <see cref="T:System.Reflection.Binder" />, определяющий набор свойств и разрешающий привязку, что может быть сопряжено с выбором перегружаемых методов, приведением типов аргументов и вызовом члена с помощью отражения.  
		/// -или- 
		///  Значение <see langword="null" />, чтобы использовать свойство <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="target">
		///   <see cref="T:System.Object" />, для которого будет вызван указанный элемент.</param>
		/// <param name="args">Массив с аргументами, передаваемыми вызываемому члену.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, представляющий используемый языковой стандарт глобализации. Он может понадобиться для выполнения преобразований, зависящих от языкового стандарта, например приведения числа в строковом формате к типу Double.  
		///
		/// или - 
		/// <see langword="null" />, для использования объекта <see cref="T:System.Globalization.CultureInfo" /> текущего потока.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий значение, возвращаемое указанным членом.</returns>
		// Token: 0x0600443B RID: 17467
		object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, CultureInfo culture);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[])" />.</summary>
		/// <param name="name">Объект типа <see cref="T:System.String" />, содержащий имя вызываемого члена: конструктора, метода, свойства или поля.  
		/// -или- 
		/// Пустая строка ("") — в этом случае будет вызван член по умолчанию.  
		/// -или- 
		/// Для элементов IDispatch — строка, представляющая DispID, например "[DispID=3]".</param>
		/// <param name="invokeAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск. Тип доступа может быть обозначен одним из флагов <see langword="BindingFlags" />, например <see langword="Public" />, <see langword="NonPublic" />, <see langword="Private" />, <see langword="InvokeMethod" />, <see langword="GetField" /> и т.д. Тип поиска указывать необязательно. Если тип поиска не указан, используются флаги <see langword="BindingFlags.Public" /> | <see langword="BindingFlags.Instance" />.</param>
		/// <param name="binder">Объект <see cref="T:System.Reflection.Binder" />, определяющий набор свойств и разрешающий привязку, что может быть сопряжено с выбором перегружаемых методов, приведением типов аргументов и вызовом члена с помощью отражения.  
		///
		/// или - 
		/// Значение <see langword="null" />, чтобы использовать свойство <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="target">
		///   <see cref="T:System.Object" />, для которого будет вызван указанный элемент.</param>
		/// <param name="args">Массив с аргументами, передаваемыми вызываемому члену.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий значение, возвращаемое указанным членом.</returns>
		// Token: 0x0600443C RID: 17468
		object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" />.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		///
		/// или - 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект <see cref="T:System.Reflection.Binder" />, определяющий набор свойств и разрешающий привязку, что может быть сопряжено с выбором перегружаемых методов, приведением типов аргументов и вызовом члена с помощью отражения.  
		/// -или- 
		///  Значение <see langword="null" />, чтобы использовать свойство <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="callConvention">Объект <see cref="T:System.Reflection.CallingConventions" />, определяющий набор применяемых правил, касающихся порядка и расположения аргументов, способа передачи возвращаемого значения, регистров, используемых для аргументов, и очистки стека.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров, извлекаемых конструктором.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить конструктор, который не имеет параметров.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект <see cref="T:System.Reflection.ConstructorInfo" />, представляющий конструктор, который соответствует указанным требованиям; в противном случае возвращается значение <see langword="null" />.</returns>
		// Token: 0x0600443D RID: 17469
		ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Type[],System.Reflection.ParameterModifier[])" />.</summary>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект <see cref="T:System.Reflection.Binder" />, определяющий набор свойств и разрешающий привязку, что может быть сопряжено с выбором перегружаемых методов, приведением типов аргументов и вызовом члена с помощью отражения.  
		///
		/// или - 
		/// Значение <see langword="null" />, чтобы использовать свойство <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров, извлекаемых конструктором.  
		///
		/// или - 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить конструктор, который не имеет параметров.  
		///
		/// или - 
		/// <see cref="F:System.Type.EmptyTypes" />.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве типов параметра. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект <see cref="T:System.Reflection.ConstructorInfo" />, представляющий конструктор, который соответствует указанным требованиям; в противном случае возвращается значение <see langword="null" />.</returns>
		// Token: 0x0600443E RID: 17470
		ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetConstructor(System.Type[])" />.</summary>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющих число, порядок и тип параметров нужного конструктора.  
		/// -или- 
		/// Пустой массив объектов <see cref="T:System.Type" /> для получения конструктора, не имеющего параметров. Подобный пустой массив предоставляется полем <see langword="static" /> с описателем <see cref="F:System.Type.EmptyTypes" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.ConstructorInfo" />, представляющий открытый конструктор экземпляра, параметры которого соответствуют типам, указанным в массиве типов параметров, если такой конструктор существует, и <see langword="null" />, если такого конструктора нет.</returns>
		// Token: 0x0600443F RID: 17471
		ConstructorInfo GetConstructor(Type[] types);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetConstructors" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.ConstructorInfo" />, представляющий все открытые конструкторы экземпляров, определенные для текущего типа <see cref="T:System.Type" />, за исключением инициализатора типа (статический конструктор). Если для текущего типа <see cref="T:System.Type" /> не определены конструкторы экземпляра, или если текущий тип <see cref="T:System.Type" /> представляет собой параметр универсального типа или определение метода, возвращается пустой массив типа <see cref="T:System.Reflection.ConstructorInfo" />.</returns>
		// Token: 0x06004440 RID: 17472
		ConstructorInfo[] GetConstructors();

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.TypeInitializer" />.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.ConstructorInfo" />, содержащий имя конструктора класса <see cref="T:System.Type" />.</returns>
		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06004441 RID: 17473
		ConstructorInfo TypeInitializer { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" />.</summary>
		/// <param name="name">Строка типа <see cref="T:System.String" />, содержащая имя искомого метода.</param>
		/// <param name="bindingAttr">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		/// -или- 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <param name="binder">Объект <see cref="T:System.Reflection.Binder" />, определяющий набор свойств и разрешающий привязку, что может быть сопряжено с выбором перегружаемых методов, приведением типов аргументов и вызовом члена с помощью отражения.  
		///
		/// или - 
		/// Значение <see langword="null" />, чтобы использовать свойство <see cref="P:System.Type.DefaultBinder" />.</param>
		/// <param name="callConvention">Объект <see cref="T:System.Reflection.CallingConventions" />, определяющий набор применяемых правил, касающихся порядка и расположения аргументов, способа передачи возвращаемого значения, регистров, используемых для аргументов, и способа очистки стека.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого метода.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить метод, который не имеет параметров.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Если поиск выполнен удачно, возвращается объект <see cref="T:System.Reflection.MethodInfo" />, предоставляющий метод, который соответствует указанным требованиям; в противном случае возвращается <see langword="null" />.</returns>
		// Token: 0x06004442 RID: 17474
		MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMethod(System.String,System.Type[],System.Reflection.ParameterModifier[])" />.</summary>
		/// <param name="name">Объект <see cref="T:System.String" />, содержащий имя искомого открытого метода.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого метода.  
		///
		/// или - 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить метод, который не имеет параметров.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий открытый метод, который соответствует указанным условиям, если такой метод существует, и <see langword="null" />, если такого метода нет.</returns>
		// Token: 0x06004443 RID: 17475
		MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMethod(System.String,System.Type[])" />.</summary>
		/// <param name="name">Объект <see cref="T:System.String" />, содержащий имя искомого открытого метода.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого метода.  
		///
		/// или - 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить метод, который не имеет параметров.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий открытый метод, параметры которого соответствуют указанным типам аргументов, если такой метод существует, и <see langword="null" />, если такого метода нет.</returns>
		// Token: 0x06004444 RID: 17476
		MethodInfo GetMethod(string name, Type[] types);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMethod(System.String)" />.</summary>
		/// <param name="name">Объект <see cref="T:System.String" />, содержащий имя искомого открытого метода.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий открытый метод с заданным именем, если такой метод есть, и <see langword="null" />, если такого метода нет.</returns>
		// Token: 0x06004445 RID: 17477
		MethodInfo GetMethod(string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMethods" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MethodInfo" />, представляющий все открытые методы, определенные для текущего объекта <see cref="T:System.Type" />.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.MethodInfo" />, если для текущего типа <see cref="T:System.Type" /> открытые методы не определены.</returns>
		// Token: 0x06004446 RID: 17478
		MethodInfo[] GetMethods();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetField(System.String)" />.</summary>
		/// <param name="name">Объект <see cref="T:System.String" />, содержащий имя искомого поля данных.</param>
		/// <returns>Объект <see cref="T:System.Reflection.FieldInfo" />, представляющий открытое поле с заданным именем, если такой метод найден; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x06004447 RID: 17479
		FieldInfo GetField(string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetFields" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.FieldInfo" />, представляющий все открытые поля, определенные для текущего объекта <see cref="T:System.Type" />.  
		/// -или- 
		/// Пустой массив типа <see cref="T:System.Reflection.FieldInfo" />, если для текущего типа <see cref="T:System.Type" /> открытые поля не определены.</returns>
		// Token: 0x06004448 RID: 17480
		FieldInfo[] GetFields();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetInterface(System.String)" />.</summary>
		/// <param name="name">Строка типа <see cref="T:System.String" />, содержащая имя искомого интерфейса. Для универсальных интерфейсов это искаженное имя.</param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий интерфейс с заданным именем, который реализуется или наследуется текущим объектом <see cref="T:System.Type" />, если такой интерфейс существует; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x06004449 RID: 17481
		Type GetInterface(string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetEvent(System.String)" />.</summary>
		/// <param name="name">Битовая маска, составленная из одного или нескольких объектов <see cref="T:System.Reflection.BindingFlags" /> и указывающая, как ведется поиск.  
		///
		/// или - 
		/// Нуль, чтобы было возвращено значение <see langword="null" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.EventInfo" />, представляющий все события, которые объявлены или унаследованы данным объектом <see cref="T:System.Type" /> и удовлетворяют указанным ограничениям привязки.  
		///
		/// или - 
		/// Пустой массив типа <see cref="T:System.Reflection.EventInfo" />, если у текущего типа <see cref="T:System.Type" /> нет событий или ни одно событие не удовлетворяет ограничениям привязки.</returns>
		// Token: 0x0600444A RID: 17482
		EventInfo GetEvent(string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetProperty(System.String,System.Type,System.Type[],System.Reflection.ParameterModifier[])" />.</summary>
		/// <param name="name">Объект типа <see cref="T:System.String" />, содержащий имя искомого открытого свойства.</param>
		/// <param name="returnType">Тип возвращаемого значения свойства.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого индексированного свойства.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить неиндексированное свойство.</param>
		/// <param name="modifiers">Массив объектов <see cref="T:System.Reflection.ParameterModifier" />, представляющих атрибуты, связанные с соответствующим элементом в массиве <paramref name="types" />. Связыватель по умолчанию не обрабатывает этот параметр.</param>
		/// <returns>Объект <see cref="T:System.Reflection.PropertyInfo" />, представляющий открытое свойство, соответствующее указанным требованиям, если такое свойство существует, и <see langword="null" />, если такого свойства нет.</returns>
		// Token: 0x0600444B RID: 17483
		PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetProperty(System.String,System.Type,System.Type[])" />.</summary>
		/// <param name="name">Объект типа <see cref="T:System.String" />, содержащий имя искомого открытого свойства.</param>
		/// <param name="returnType">Тип возвращаемого значения свойства.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого индексированного свойства.  
		///
		/// или - 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить неиндексированное свойство.</param>
		/// <returns>Объект <see cref="T:System.Reflection.PropertyInfo" />, представляющий открытое свойство, параметры которого соответствуют указанным условиям, если такое свойство существует, и <see langword="null" />, если такого свойства нет.</returns>
		// Token: 0x0600444C RID: 17484
		PropertyInfo GetProperty(string name, Type returnType, Type[] types);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetProperty(System.String,System.Type[])" />.</summary>
		/// <param name="name">Объект типа <see cref="T:System.String" />, содержащий имя искомого открытого свойства.</param>
		/// <param name="types">Массив объектов <see cref="T:System.Type" />, предоставляющий число, порядок и тип параметров искомого индексированного свойства.  
		/// -или- 
		/// Пустой массив объектов типа <see cref="T:System.Type" /> (то есть Type[] types = new Type[0]), если требуется получить неиндексированное свойство.</param>
		/// <returns>Объект <see cref="T:System.Reflection.PropertyInfo" />, представляющий открытое свойство, параметры которого соответствуют указанным условиям, если такое свойство существует, и <see langword="null" />, если такого свойства нет.</returns>
		// Token: 0x0600444D RID: 17485
		PropertyInfo GetProperty(string name, Type[] types);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetProperty(System.String,System.Type)" />.</summary>
		/// <param name="name">Объект типа <see cref="T:System.String" />, содержащий имя искомого открытого свойства.</param>
		/// <param name="returnType">Тип возвращаемого значения свойства.</param>
		/// <returns>Объект <see cref="T:System.Reflection.PropertyInfo" />, представляющий открытое свойство с заданным именем, если такое свойство есть, и <see langword="null" />, если такого свойства нет.</returns>
		// Token: 0x0600444E RID: 17486
		PropertyInfo GetProperty(string name, Type returnType);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetProperty(System.String)" />.</summary>
		/// <param name="name">Объект типа <see cref="T:System.String" />, содержащий имя искомого открытого свойства.</param>
		/// <returns>Объект <see cref="T:System.Reflection.PropertyInfo" />, представляющий открытое свойство с заданным именем, если такое свойство есть, и <see langword="null" />, если такого свойства нет.</returns>
		// Token: 0x0600444F RID: 17487
		PropertyInfo GetProperty(string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetProperties" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.PropertyInfo" />, представляющий все открытые свойства текущего типа <see cref="T:System.Type" />.  
		///
		/// или - 
		/// Пустой массив типа <see cref="T:System.Reflection.PropertyInfo" />, если у текущего типа <see cref="T:System.Type" /> нет открытых свойств.</returns>
		// Token: 0x06004450 RID: 17488
		PropertyInfo[] GetProperties();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetNestedTypes" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющий все типы, вложенные в текущий тип <see cref="T:System.Type" />.  
		///
		/// или - 
		/// Пустой массив типа <see cref="T:System.Type" />, если у текущего типа <see cref="T:System.Type" /> нет вложенных типов.</returns>
		// Token: 0x06004451 RID: 17489
		Type[] GetNestedTypes();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetNestedType(System.String)" />.</summary>
		/// <param name="name">Строка, содержащая имя искомого вложенного типа.</param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий открытый вложенный тип с заданным именем, если тип есть, и <see langword="null" />, если такого типа нет.</returns>
		// Token: 0x06004452 RID: 17490
		Type GetNestedType(string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMember(System.String)" />.</summary>
		/// <param name="name">Объект <see cref="T:System.String" />, содержащий имя искомых открытых членов.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющий открытые члены с заданным именем, если такие члены есть, и пустой массив, если таких членов нет.</returns>
		// Token: 0x06004453 RID: 17491
		MemberInfo[] GetMember(string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.GetMembers" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MemberInfo" />, представляющий все открытые члены текущего типа <see cref="T:System.Type" />.  
		///
		/// или - 
		/// Пустой массив типа <see cref="T:System.Reflection.MemberInfo" />, если у текущего типа <see cref="T:System.Type" /> нет открытых членов.</returns>
		// Token: 0x06004454 RID: 17492
		MemberInfo[] GetMembers();

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.Attributes" />.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.TypeAttributes" />, представляющий набор атрибутов типа <see cref="T:System.Type" />, если <see cref="T:System.Type" /> не представляет параметр универсального типа. В противном случае это значение не определено.</returns>
		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06004455 RID: 17493
		TypeAttributes Attributes { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsNotPublic" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> верхнего уровня не объявлен как открытый; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06004456 RID: 17494
		bool IsNotPublic { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsPublic" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> верхнего уровня объявлен как открытый; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06004457 RID: 17495
		bool IsPublic { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsNestedPublic" />.</summary>
		/// <returns>Значение <see langword="true" />, если данный класс является вложенным и объявленным как открытый; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06004458 RID: 17496
		bool IsNestedPublic { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsNestedPrivate" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является вложенным и объявленным как закрытый; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06004459 RID: 17497
		bool IsNestedPrivate { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsNestedFamily" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является вложенным и видимым только внутри собственного семейства; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x0600445A RID: 17498
		bool IsNestedFamily { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsNestedAssembly" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является вложенным и видимым только в своей сборке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x0600445B RID: 17499
		bool IsNestedAssembly { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsNestedFamANDAssem" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является вложенным и видимым только классам, принадлежащим одновременно к семейству и сборке этого объекта; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x0600445C RID: 17500
		bool IsNestedFamANDAssem { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsNestedFamORAssem" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является вложенным и видимым только классам, принадлежащим его семейству или его сборке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x0600445D RID: 17501
		bool IsNestedFamORAssem { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsAutoLayout" />.</summary>
		/// <returns>Значение <see langword="true" />, если для объекта <see cref="T:System.Type" /> выбран атрибут размещения класса <see langword="AutoLayout" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x0600445E RID: 17502
		bool IsAutoLayout { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsLayoutSequential" />.</summary>
		/// <returns>Значение <see langword="true" />, если для объекта <see cref="T:System.Type" /> выбран атрибут размещения класса <see langword="SequentialLayout" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x0600445F RID: 17503
		bool IsLayoutSequential { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsExplicitLayout" />.</summary>
		/// <returns>Значение <see langword="true" />, если для объекта <see cref="T:System.Type" /> выбран атрибут размещения класса <see langword="ExplicitLayout" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06004460 RID: 17504
		bool IsExplicitLayout { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsClass" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является классом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06004461 RID: 17505
		bool IsClass { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsInterface" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является интерфейсом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06004462 RID: 17506
		bool IsInterface { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsValueType" />.</summary>
		/// <returns>Значение <see langword="true" />, если тип <see cref="T:System.Type" /> является типом значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06004463 RID: 17507
		bool IsValueType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsAbstract" />.</summary>
		/// <returns>Значение <see langword="true" />, если класс <see cref="T:System.Type" /> является абстрактным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06004464 RID: 17508
		bool IsAbstract { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsSealed" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> объявлен как запечатанный; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06004465 RID: 17509
		bool IsSealed { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsEnum" />.</summary>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Type" /> представляет перечисление; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06004466 RID: 17510
		bool IsEnum { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsSpecialName" />.</summary>
		/// <returns>Значение <see langword="true" />, если имя данного объекта <see cref="T:System.Type" /> требует специальной обработки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06004467 RID: 17511
		bool IsSpecialName { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsImport" />.</summary>
		/// <returns>Значение <see langword="true" />, если у <see cref="T:System.Type" /> есть атрибут <see cref="T:System.Runtime.InteropServices.ComImportAttribute" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06004468 RID: 17512
		bool IsImport { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsSerializable" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является сериализуемым; в противным случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06004469 RID: 17513
		bool IsSerializable { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsAnsiClass" />.</summary>
		/// <returns>Значение <see langword="true" />, если для данного объекта <see langword="AnsiClass" /> выбран атрибут формата строки <see cref="T:System.Type" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x0600446A RID: 17514
		bool IsAnsiClass { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsUnicodeClass" />.</summary>
		/// <returns>Значение <see langword="true" />, если для данного объекта <see langword="UnicodeClass" /> выбран атрибут формата строки <see cref="T:System.Type" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x0600446B RID: 17515
		bool IsUnicodeClass { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsAutoClass" />.</summary>
		/// <returns>Значение <see langword="true" />, если для данного объекта <see langword="AutoClass" /> выбран атрибут формата строки <see cref="T:System.Type" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x0600446C RID: 17516
		bool IsAutoClass { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsArray" />.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Type" /> является массивом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x0600446D RID: 17517
		bool IsArray { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsByRef" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> передан по ссылке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x0600446E RID: 17518
		bool IsByRef { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsPointer" />.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Type" /> является указателем; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x0600446F RID: 17519
		bool IsPointer { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsPrimitive" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является одним из типов-примитивов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06004470 RID: 17520
		bool IsPrimitive { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsCOMObject" />.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Type" /> является COM-объектом, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06004471 RID: 17521
		bool IsCOMObject { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.HasElementType" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> является массивом, указателем или параметром, переданным по ссылке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06004472 RID: 17522
		bool HasElementType { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsContextful" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> может быть помещен в контекст; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06004473 RID: 17523
		bool IsContextful { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Type.IsMarshalByRef" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Type" /> маршалируется по ссылке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06004474 RID: 17524
		bool IsMarshalByRef { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Type.Equals(System.Type)" />.</summary>
		/// <param name="o">Объект <see cref="T:System.Type" />, базовый системный тип которого сравнивается с базовым системным типом текущего типа <see cref="T:System.Type" />.</param>
		/// <returns>Значение <see langword="true" />, если базовый системный тип параметра <paramref name="o" /> совпадает с базовым системным типом текущего объекта <see cref="T:System.Type" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004475 RID: 17525
		bool Equals(Type o);
	}
}
