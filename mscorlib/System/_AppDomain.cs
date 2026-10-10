using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Policy;
using System.Security.Principal;

namespace System
{
	/// <summary>Предоставляет неуправляемому коду доступ к открытым членам класса <see cref="T:System.AppDomain" />.</summary>
	// Token: 0x02000202 RID: 514
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Guid("05F696DC-2B29-3663-AD8B-C4389CF2A713")]
	public interface _AppDomain
	{
		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06001618 RID: 5656
		void GetTypeInfoCount(out uint pcTInfo);

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06001619 RID: 5657
		void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x0600161A RID: 5658
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
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x0600161B RID: 5659
		void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.ToString" />.</summary>
		/// <returns>Строка, полученная путем сцепления литеральной строки "Name:", понятного имени домена приложения и либо строкового представления политик контекста, либо строки "Политики контекста отсутствуют".</returns>
		// Token: 0x0600161C RID: 5660
		string ToString();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к унаследованному методу <see cref="M:System.Object.Equals(System.Object)" />.</summary>
		/// <param name="other">Объект <see cref="T:System.Object" /> для сравнения с текущим объектом <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту <see cref="T:System.Object" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600161D RID: 5661
		bool Equals(object other);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к унаследованному методу <see cref="M:System.Object.GetHashCode" />.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Object" />.</returns>
		// Token: 0x0600161E RID: 5662
		int GetHashCode();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.GetType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, который представляет тип текущего экземпляра.</returns>
		// Token: 0x0600161F RID: 5663
		Type GetType();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.InitializeLifetimeService" />.</summary>
		/// <returns>Всегда <see langword="null" />.</returns>
		// Token: 0x06001620 RID: 5664
		[SecurityCritical]
		object InitializeLifetimeService();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к унаследованному методу <see cref="M:System.MarshalByRefObject.GetLifetimeService" />.</summary>
		/// <returns>Объект типа <see cref="T:System.Runtime.Remoting.Lifetime.ILease" />, используемый для управления политикой времени существования данного экземпляра.</returns>
		// Token: 0x06001621 RID: 5665
		[SecurityCritical]
		object GetLifetimeService();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к событию <see cref="E:System.AppDomain.DomainUnload" />.</summary>
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06001622 RID: 5666
		// (remove) Token: 0x06001623 RID: 5667
		event EventHandler DomainUnload;

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к событию <see cref="E:System.AppDomain.AssemblyLoad" />.</summary>
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06001624 RID: 5668
		// (remove) Token: 0x06001625 RID: 5669
		event AssemblyLoadEventHandler AssemblyLoad;

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к событию <see cref="E:System.AppDomain.ProcessExit" />.</summary>
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06001626 RID: 5670
		// (remove) Token: 0x06001627 RID: 5671
		event EventHandler ProcessExit;

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к событию <see cref="E:System.AppDomain.TypeResolve" />.</summary>
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06001628 RID: 5672
		// (remove) Token: 0x06001629 RID: 5673
		event ResolveEventHandler TypeResolve;

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к событию <see cref="E:System.AppDomain.ResourceResolve" />.</summary>
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600162A RID: 5674
		// (remove) Token: 0x0600162B RID: 5675
		event ResolveEventHandler ResourceResolve;

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к событию <see cref="E:System.AppDomain.AssemblyResolve" />.</summary>
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600162C RID: 5676
		// (remove) Token: 0x0600162D RID: 5677
		event ResolveEventHandler AssemblyResolve;

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к событию <see cref="E:System.AppDomain.UnhandledException" />.</summary>
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600162E RID: 5678
		// (remove) Token: 0x0600162F RID: 5679
		event UnhandledExceptionEventHandler UnhandledException;

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess)" />.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим доступа для динамической сборки.</param>
		/// <returns>Представляет созданную динамическую сборку.</returns>
		// Token: 0x06001630 RID: 5680
		AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.String)" />.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="dir">Имя папки, в которой будет сохранена сборка. Если параметр <paramref name="dir" /> имеет значение <see langword="null" />, по умолчанию используется текущий каталог.</param>
		/// <returns>Представляет созданную динамическую сборку.</returns>
		// Token: 0x06001631 RID: 5681
		AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.Security.Policy.Evidence)" />.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="evidence">Свидетельство, предоставляемое для динамической сборки. Используемое свидетельство является постоянным, как конечный набор свидетельств, используемых для разрешения политики.</param>
		/// <returns>Представляет созданную динамическую сборку.</returns>
		// Token: 0x06001632 RID: 5682
		AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.Security.PermissionSet,System.Security.PermissionSet,System.Security.PermissionSet)" />.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="requiredPermissions">Запрос обязательных разрешений.</param>
		/// <param name="optionalPermissions">Запрос дополнительных разрешений.</param>
		/// <param name="refusedPermissions">Запрос разрешений, в которых отказано.</param>
		/// <returns>Представляет созданную динамическую сборку.</returns>
		// Token: 0x06001633 RID: 5683
		AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.String,System.Security.Policy.Evidence)" />.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="dir">Имя папки, в которой будет сохранена сборка. Если параметр <paramref name="dir" /> имеет значение <see langword="null" />, по умолчанию используется текущий каталог.</param>
		/// <param name="evidence">Свидетельство, предоставляемое для динамической сборки. Используемое свидетельство является постоянным, как конечный набор свидетельств, используемых для разрешения политики.</param>
		/// <returns>Представляет созданную динамическую сборку.</returns>
		// Token: 0x06001634 RID: 5684
		AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.String,System.Security.PermissionSet,System.Security.PermissionSet,System.Security.PermissionSet)" />.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="dir">Имя папки, в которой будет сохранена сборка. Если параметр <paramref name="dir" /> имеет значение <see langword="null" />, по умолчанию используется текущий каталог.</param>
		/// <param name="requiredPermissions">Запрос обязательных разрешений.</param>
		/// <param name="optionalPermissions">Запрос дополнительных разрешений.</param>
		/// <param name="refusedPermissions">Запрос разрешений, в которых отказано.</param>
		/// <returns>Представляет созданную динамическую сборку.</returns>
		// Token: 0x06001635 RID: 5685
		AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.Security.Policy.Evidence,System.Security.PermissionSet,System.Security.PermissionSet,System.Security.PermissionSet)" />.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="evidence">Свидетельство, предоставляемое для динамической сборки. Используемое свидетельство является постоянным, как конечный набор свидетельств, используемых для разрешения политики.</param>
		/// <param name="requiredPermissions">Запрос обязательных разрешений.</param>
		/// <param name="optionalPermissions">Запрос дополнительных разрешений.</param>
		/// <param name="refusedPermissions">Запрос разрешений, в которых отказано.</param>
		/// <returns>Представляет созданную динамическую сборку.</returns>
		// Token: 0x06001636 RID: 5686
		AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.String,System.Security.Policy.Evidence,System.Security.PermissionSet,System.Security.PermissionSet,System.Security.PermissionSet)" />.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="dir">Имя папки, в которой будет сохранена сборка. Если параметр <paramref name="dir" /> имеет значение <see langword="null" />, по умолчанию используется текущий каталог.</param>
		/// <param name="evidence">Свидетельство, предоставляемое для динамической сборки. Используемое свидетельство является постоянным, как конечный набор свидетельств, используемых для разрешения политики.</param>
		/// <param name="requiredPermissions">Запрос обязательных разрешений.</param>
		/// <param name="optionalPermissions">Запрос дополнительных разрешений.</param>
		/// <param name="refusedPermissions">Запрос разрешений, в которых отказано.</param>
		/// <returns>Представляет созданную динамическую сборку.</returns>
		// Token: 0x06001637 RID: 5687
		AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName,System.Reflection.Emit.AssemblyBuilderAccess,System.String,System.Security.Policy.Evidence,System.Security.PermissionSet,System.Security.PermissionSet,System.Security.PermissionSet,System.Boolean)" />.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="dir">Имя каталога, в котором будет сохранена динамическая сборка. Если параметр <paramref name="dir" /> имеет значение <see langword="null" />, по умолчанию используется текущий каталог.</param>
		/// <param name="evidence">Свидетельство, предоставляемое для динамической сборки. Используемое свидетельство является постоянным, как конечный набор свидетельств, используемых для разрешения политики.</param>
		/// <param name="requiredPermissions">Запрос обязательных разрешений.</param>
		/// <param name="optionalPermissions">Запрос дополнительных разрешений.</param>
		/// <param name="refusedPermissions">Запрос разрешений, в которых отказано.</param>
		/// <param name="isSynchronized">Значение <see langword="true" />, чтобы синхронизировать создание модулей, типов и членов в динамической сборке, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Представляет созданную динамическую сборку.</returns>
		// Token: 0x06001638 RID: 5688
		AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.CreateInstance(System.String,System.String)" />.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, заданного параметром <paramref name="typeName" />. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		// Token: 0x06001639 RID: 5689
		ObjectHandle CreateInstance(string assemblyName, string typeName);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.CreateInstanceFrom(System.String,System.String)" />.</summary>
		/// <param name="assemblyFile">Имя (включая путь) файла, который содержит сборку, определяющую запрошенный тип. Эта сборка загружается с помощью метода <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, или значение <see langword="null" />, если объект <paramref name="typeName" /> не найден. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		// Token: 0x0600163A RID: 5690
		ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.CreateInstance(System.String,System.String,System.Object[])" />.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, массив, который содержит единственный объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />. Атрибут <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> указывает URL-адрес, требуемый для активации удаленного объекта.</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, заданного параметром <paramref name="typeName" />. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		// Token: 0x0600163B RID: 5691
		ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.CreateInstanceFrom(System.String,System.String,System.Object[])" />.</summary>
		/// <param name="assemblyFile">Имя (включая путь) файла, который содержит сборку, определяющую запрошенный тип. Эта сборка загружается с помощью метода <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, массив, который содержит единственный объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />. Атрибут <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> указывает URL-адрес, требуемый для активации удаленного объекта.</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, или значение <see langword="null" />, если объект <paramref name="typeName" /> не найден. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		// Token: 0x0600163C RID: 5692
		ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.CreateInstance(System.String,System.String,System.Boolean,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo,System.Object[],System.Security.Policy.Evidence)" />.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при поиске.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see cref="T:System.Reflection.MemberInfo" /> с помощью отражения. Если параметр <paramref name="binder" /> имеет значение null, то используется модуль привязки по умолчанию.</param>
		/// <param name="args">Аргументы для передачи конструктору. Массив аргументов должен соответствовать по числу, порядку и типу параметров вызываемому конструктору. Если предпочтителен конструктор по умолчанию, то объект <paramref name="args" /> должен быть пустым массивом или значением null.</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, массив, который содержит единственный объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />. Атрибут <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> указывает URL-адрес, требуемый для активации удаленного объекта.</param>
		/// <param name="securityAttributes">Сведения, используемые для авторизации создания <paramref name="typeName" />.</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, заданного параметром <paramref name="typeName" />. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		// Token: 0x0600163D RID: 5693
		ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.CreateInstanceFrom(System.String,System.String,System.Boolean,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo,System.Object[],System.Security.Policy.Evidence)" />.</summary>
		/// <param name="assemblyFile">Имя (включая путь) файла, который содержит сборку, определяющую запрошенный тип. Эта сборка загружается с помощью метода <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при поиске.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который допускает привязку, приведение типов аргументов, вызов элементов и извлечение объектов <see cref="T:System.Reflection.MemberInfo" /> путем отражения. Если параметр <paramref name="binder" /> имеет значение null, то используется модуль привязки по умолчанию.</param>
		/// <param name="args">Аргументы для передачи конструктору. Массив аргументов должен соответствовать по числу, порядку и типу параметров вызываемому конструктору. Если предпочтителен конструктор по умолчанию, то объект <paramref name="args" /> должен быть пустым массивом или значением null.</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, массив, который содержит единственный объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />. Атрибут <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> указывает URL-адрес, требуемый для активации удаленного объекта.</param>
		/// <param name="securityAttributes">Сведения, используемые для авторизации создания <paramref name="typeName" />.</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, или значение <see langword="null" />, если объект <paramref name="typeName" /> не найден. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		// Token: 0x0600163E RID: 5694
		ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.Load(System.Reflection.AssemblyName)" />.</summary>
		/// <param name="assemblyRef">Объект, который описывает сборку, подлежащую загрузке.</param>
		/// <returns>Загруженная сборка.</returns>
		// Token: 0x0600163F RID: 5695
		Assembly Load(AssemblyName assemblyRef);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.Load(System.String)" />.</summary>
		/// <param name="assemblyString">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <returns>Загруженная сборка.</returns>
		// Token: 0x06001640 RID: 5696
		Assembly Load(string assemblyString);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.Load(System.Byte[])" />.</summary>
		/// <param name="rawAssembly">Массив типа <see langword="byte" />, который является образом в формате COFF, содержащим порожденную сборку.</param>
		/// <returns>Загруженная сборка.</returns>
		// Token: 0x06001641 RID: 5697
		Assembly Load(byte[] rawAssembly);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.Load(System.Byte[],System.Byte[])" />.</summary>
		/// <param name="rawAssembly">Массив типа <see langword="byte" />, который является образом в формате COFF, содержащим порожденную сборку.</param>
		/// <param name="rawSymbolStore">Массив типа <see langword="byte" />, содержащий необработанные байты, которые представляют символы для сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		// Token: 0x06001642 RID: 5698
		Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.Load(System.Byte[],System.Byte[],System.Security.Policy.Evidence)" />.</summary>
		/// <param name="rawAssembly">Массив типа <see langword="byte" />, который является образом в формате COFF, содержащим порожденную сборку.</param>
		/// <param name="rawSymbolStore">Массив типа <see langword="byte" />, содержащий необработанные байты, которые представляют символы для сборки.</param>
		/// <param name="securityEvidence">Свидетельство для загрузки сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		// Token: 0x06001643 RID: 5699
		Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.Load(System.Reflection.AssemblyName,System.Security.Policy.Evidence)" />.</summary>
		/// <param name="assemblyRef">Объект, который описывает сборку, подлежащую загрузке.</param>
		/// <param name="assemblySecurity">Свидетельство для загрузки сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		// Token: 0x06001644 RID: 5700
		Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.Load(System.String,System.Security.Policy.Evidence)" />.</summary>
		/// <param name="assemblyString">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="assemblySecurity">Свидетельство для загрузки сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		// Token: 0x06001645 RID: 5701
		Assembly Load(string assemblyString, Evidence assemblySecurity);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.ExecuteAssembly(System.String,System.Security.Policy.Evidence)" />.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, которую необходимо выполнить.</param>
		/// <param name="assemblySecurity">Свидетельство для загрузки сборки.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		// Token: 0x06001646 RID: 5702
		int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.ExecuteAssembly(System.String)" />.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, которую необходимо выполнить.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		// Token: 0x06001647 RID: 5703
		int ExecuteAssembly(string assemblyFile);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к перегрузке метода <see cref="M:System.AppDomain.ExecuteAssembly(System.String,System.Security.Policy.Evidence,System.String[])" />.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, которую необходимо выполнить.</param>
		/// <param name="assemblySecurity">Предоставленное свидетельство для сборки.</param>
		/// <param name="args">Аргументы, передаваемые в точку входа сборки.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		// Token: 0x06001648 RID: 5704
		int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.AppDomain.FriendlyName" />.</summary>
		/// <returns>Понятное имя этого домена приложения.</returns>
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06001649 RID: 5705
		string FriendlyName { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.AppDomain.BaseDirectory" />.</summary>
		/// <returns>Базовый каталог, в котором распознаватель сборок производит поиск.</returns>
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600164A RID: 5706
		string BaseDirectory { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.AppDomain.RelativeSearchPath" />.</summary>
		/// <returns>Путь, к каталогу, находящемуся в базовом каталоге, где распознаватель сборок будет производить поиск закрытых сборок.</returns>
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600164B RID: 5707
		string RelativeSearchPath { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.AppDomain.ShadowCopyFiles" />.</summary>
		/// <returns>Значение <see langword="true" />, если домен приложения настроен для теневого копирования файлов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600164C RID: 5708
		bool ShadowCopyFiles { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.GetAssemblies" />.</summary>
		/// <returns>Массив сборок в этом домене приложения.</returns>
		// Token: 0x0600164D RID: 5709
		Assembly[] GetAssemblies();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.AppendPrivatePath(System.String)" />.</summary>
		/// <param name="path">Имя каталога, который следует добавить в закрытый путь.</param>
		// Token: 0x0600164E RID: 5710
		[SecurityCritical]
		void AppendPrivatePath(string path);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.ClearPrivatePath" />.</summary>
		// Token: 0x0600164F RID: 5711
		[SecurityCritical]
		void ClearPrivatePath();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.SetShadowCopyPath(System.String)" />.</summary>
		/// <param name="s">Список имен каталогов, разделенных точкой с запятой.</param>
		// Token: 0x06001650 RID: 5712
		[SecurityCritical]
		void SetShadowCopyPath(string s);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.ClearShadowCopyPath" />.</summary>
		// Token: 0x06001651 RID: 5713
		[SecurityCritical]
		void ClearShadowCopyPath();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.SetCachePath(System.String)" />.</summary>
		/// <param name="s">Полный путь к расположению теневых копий.</param>
		// Token: 0x06001652 RID: 5714
		[SecurityCritical]
		void SetCachePath(string s);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.SetData(System.String,System.Object)" />.</summary>
		/// <param name="name">Имя пользовательского свойства домена приложения, которое требуется создать или изменить.</param>
		/// <param name="data">Значение свойства.</param>
		// Token: 0x06001653 RID: 5715
		[SecurityCritical]
		void SetData(string name, object data);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.GetData(System.String)" />.</summary>
		/// <param name="name">Имя предопределенного свойства домена приложения или имя определенного вами свойства домена приложения.</param>
		/// <returns>Значение свойства <paramref name="name" />.</returns>
		// Token: 0x06001654 RID: 5716
		object GetData(string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.DoCallBack(System.CrossAppDomainDelegate)" />.</summary>
		/// <param name="theDelegate">Делегат, определяющий вызываемый метод.</param>
		// Token: 0x06001655 RID: 5717
		void DoCallBack(CrossAppDomainDelegate theDelegate);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.AppDomain.DynamicDirectory" />.</summary>
		/// <returns>Возвращает каталог, в котором распознаватель сборок производит поиск динамически созданных сборок.</returns>
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06001656 RID: 5718
		string DynamicDirectory { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.AppDomain.Evidence" />.</summary>
		/// <returns>Возвращает объект <see cref="T:System.Security.Policy.Evidence" />, связанный с данным доменом приложения, используемый в качестве входных данных для политики безопасности.</returns>
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06001657 RID: 5719
		Evidence Evidence { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.SetAppDomainPolicy(System.Security.Policy.PolicyLevel)" />.</summary>
		/// <param name="domainPolicy">Уровень политики безопасности.</param>
		// Token: 0x06001658 RID: 5720
		[SecurityCritical]
		void SetAppDomainPolicy(PolicyLevel domainPolicy);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy)" />.</summary>
		/// <param name="policy">Одно из значений <see cref="T:System.Security.Principal.PrincipalPolicy" />, определяющее тип объекта-участника, который необходимо подключить к потоку.</param>
		// Token: 0x06001659 RID: 5721
		void SetPrincipalPolicy(PrincipalPolicy policy);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.AppDomain.SetThreadPrincipal(System.Security.Principal.IPrincipal)" />.</summary>
		/// <param name="principal">Объект-участник, который необходимо подключить к потоку.</param>
		// Token: 0x0600165A RID: 5722
		void SetThreadPrincipal(IPrincipal principal);
	}
}
