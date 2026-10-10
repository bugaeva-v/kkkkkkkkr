using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Policy;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет неуправляемому коду доступ к открытым членам класса <see cref="T:System.Reflection.Assembly" />.</summary>
	// Token: 0x02000763 RID: 1891
	[CLSCompliant(false)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[Guid("17156360-2F1A-384A-BC52-FDE93C215C5B")]
	[ComVisible(true)]
	[TypeLibImportClass(typeof(Assembly))]
	public interface _Assembly
	{
		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.ToString" />.</summary>
		/// <returns>Полное имя сборки или имя класса, если полное имя сборки не может быть определено.</returns>
		// Token: 0x060042A6 RID: 17062
		string ToString();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.Equals(System.Object)" />.</summary>
		/// <param name="other">Объект <see cref="T:System.Object" />, с которым сравнивается текущий объект <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту <see cref="T:System.Object" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060042A7 RID: 17063
		bool Equals(object other);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetHashCode" />.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Object" />.</returns>
		// Token: 0x060042A8 RID: 17064
		int GetHashCode();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Object.GetType" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />.</returns>
		// Token: 0x060042A9 RID: 17065
		Type GetType();

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.Assembly.CodeBase" />.</summary>
		/// <returns>Первоначально заданное расположение сборки.</returns>
		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060042AA RID: 17066
		string CodeBase { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.Assembly.EscapedCodeBase" />.</summary>
		/// <returns>Универсальный код ресурса (URI) с escape-символами.</returns>
		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060042AB RID: 17067
		string EscapedCodeBase { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetName" />.</summary>
		/// <returns>Имя <see cref="T:System.Reflection.AssemblyName" /> для этой сборки.</returns>
		// Token: 0x060042AC RID: 17068
		AssemblyName GetName();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetName(System.Boolean)" />.</summary>
		/// <param name="copiedName">Значение <see langword="true" />, чтобы значение свойства <see cref="P:System.Reflection.Assembly.CodeBase" /> указывало на расположение сборки после создания ее теневой копии; значение <see langword="false" />, если значение свойства <see cref="P:System.Reflection.Assembly.CodeBase" /> должно указывать на первоначальное расположение.</param>
		/// <returns>Имя <see cref="T:System.Reflection.AssemblyName" /> для этой сборки.</returns>
		// Token: 0x060042AD RID: 17069
		AssemblyName GetName(bool copiedName);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.Assembly.FullName" />.</summary>
		/// <returns>Отображаемое имя сборки.</returns>
		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060042AE RID: 17070
		string FullName { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.Assembly.EntryPoint" />.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий точку входа этой сборки. Если точка входа не найдена (например, сборка является DLL-библиотекой), возвращается значение <see langword="null" />.</returns>
		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060042AF RID: 17071
		MethodInfo EntryPoint { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetType(System.String)" />.</summary>
		/// <param name="name">Полное имя типа.</param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий указанный класс, или <see langword="null" />, если класс не найден.</returns>
		// Token: 0x060042B0 RID: 17072
		Type GetType(string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetType(System.String,System.Boolean)" />.</summary>
		/// <param name="name">Полное имя типа.</param>
		/// <param name="throwOnError">Значение <see langword="true" /> для создания исключения, если тип не найден, в обратном случае — значение <see langword="false" />, в результате чего будет возвращено значение <see langword="null" />.</param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий указанный класс.</returns>
		// Token: 0x060042B1 RID: 17073
		Type GetType(string name, bool throwOnError);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="M:System.Reflection.Assembly.GetExportedTypes" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, представляющих типы, определенные в сборке и видимые за пределами сборки.</returns>
		// Token: 0x060042B2 RID: 17074
		Type[] GetExportedTypes();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetTypes" />.</summary>
		/// <returns>Массив типа <see cref="T:System.Type" />, содержащий объекты для всех типов, определенных в этой сборке.</returns>
		// Token: 0x060042B3 RID: 17075
		Type[] GetTypes();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetManifestResourceStream(System.Type,System.String)" />.</summary>
		/// <param name="type">Тип, пространством имен которого ограничена область действия имени ресурса манифеста.</param>
		/// <param name="name">Имя запрашиваемого ресурса манифеста, зависящее от регистра.</param>
		/// <returns>
		///   <see cref="T:System.IO.Stream" />, представляющий этот ресурс манифеста.</returns>
		// Token: 0x060042B4 RID: 17076
		Stream GetManifestResourceStream(Type type, string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetManifestResourceStream(System.String)" />.</summary>
		/// <param name="name">Имя запрашиваемого ресурса манифеста, зависящее от регистра.</param>
		/// <returns>
		///   <see cref="T:System.IO.Stream" />, представляющий этот ресурс манифеста.</returns>
		// Token: 0x060042B5 RID: 17077
		Stream GetManifestResourceStream(string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetFile(System.String)" />.</summary>
		/// <param name="name">Имя указанного файла. Не должно содержать путь к файлу.</param>
		/// <returns>Объект <see cref="T:System.IO.FileStream" /> для заданного файла или значение <see langword="null" />, если файл не найден.</returns>
		// Token: 0x060042B6 RID: 17078
		FileStream GetFile(string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetFiles" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.IO.FileStream" />.</returns>
		// Token: 0x060042B7 RID: 17079
		FileStream[] GetFiles();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetFiles(System.Boolean)" />.</summary>
		/// <param name="getResourceModules">Значение <see langword="true" />, если необходимо включать модули ресурсов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив объектов <see cref="T:System.IO.FileStream" />.</returns>
		// Token: 0x060042B8 RID: 17080
		FileStream[] GetFiles(bool getResourceModules);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetManifestResourceNames" />.</summary>
		/// <returns>Массив типа <see langword="String" />, содержащий имена всех ресурсов.</returns>
		// Token: 0x060042B9 RID: 17081
		string[] GetManifestResourceNames();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetManifestResourceInfo(System.String)" />.</summary>
		/// <param name="resourceName">Имя ресурса, зависящее от регистра.</param>
		/// <returns>Объект <see cref="T:System.Reflection.ManifestResourceInfo" /> со сведениями о топологии ресурса или <see langword="null" />, если ресурс не найден.</returns>
		// Token: 0x060042BA RID: 17082
		ManifestResourceInfo GetManifestResourceInfo(string resourceName);

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.Assembly.Location" />.</summary>
		/// <returns>Местоположение загруженного файла, содержащего манифест. Если для загруженного файла был создан снимок состояния, местонахождение является местонахождением файла после теневого копирования. Если сборка загружается из массива байтов, например, при использовании метода перегрузки <see cref="M:System.Reflection.Assembly.Load(System.Byte[])" />, возвращаемое значение является пустой строкой ("").</returns>
		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060042BB RID: 17083
		string Location { get; }

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.Assembly.Evidence" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Policy.Evidence" /> для этой сборки.</returns>
		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060042BC RID: 17084
		Evidence Evidence { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetCustomAttributes(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">Тип <see cref="T:System.Type" />, для которого должны быть возвращены настраиваемые атрибуты.</param>
		/// <param name="inherit">Данный аргумент не учитывается для объектов типа <see cref="T:System.Reflection.Assembly" />.</param>
		/// <returns>Массив типа <see cref="T:System.Object" />, содержащий настраиваемые атрибуты этой сборки, заданные параметром <paramref name="attributeType" />.</returns>
		// Token: 0x060042BD RID: 17085
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetCustomAttributes(System.Boolean)" />.</summary>
		/// <param name="inherit">Данный аргумент не учитывается для объектов типа <see cref="T:System.Reflection.Assembly" />.</param>
		/// <returns>Массив типа <see langword="Object" />, содержащий настраиваемые атрибуты этой сборки.</returns>
		// Token: 0x060042BE RID: 17086
		object[] GetCustomAttributes(bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.IsDefined(System.Type,System.Boolean)" />.</summary>
		/// <param name="attributeType">
		///   <see cref="T:System.Type" /> настраиваемого атрибута, проверяемого для этой сборки.</param>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Значение <see langword="true" />, если определен настраиваемый атрибут, заданный указанным значением <see cref="T:System.Type" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060042BF RID: 17087
		bool IsDefined(Type attributeType, bool inherit);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" />.</summary>
		/// <param name="info">Объект, для которого будут заполнены сведения о сериализации.</param>
		/// <param name="context">Контекст назначения сериализации.</param>
		// Token: 0x060042C0 RID: 17088
		void GetObjectData(SerializationInfo info, StreamingContext context);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetType(System.String,System.Boolean,System.Boolean)" />.</summary>
		/// <param name="name">Полное имя типа.</param>
		/// <param name="throwOnError">Значение <see langword="true" /> для создания исключения, если тип не найден, в обратном случае — значение <see langword="false" />, в результате чего будет возвращено значение <see langword="null" />.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы игнорировать регистр имени типа, в обратном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий указанный класс.</returns>
		// Token: 0x060042C1 RID: 17089
		Type GetType(string name, bool throwOnError, bool ignoreCase);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetSatelliteAssembly(System.Globalization.CultureInfo)" />.</summary>
		/// <param name="culture">Заданные язык и региональные параметры.</param>
		/// <returns>Указанная вспомогательная сборка.</returns>
		// Token: 0x060042C2 RID: 17090
		Assembly GetSatelliteAssembly(CultureInfo culture);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetSatelliteAssembly(System.Globalization.CultureInfo,System.Version)" />.</summary>
		/// <param name="culture">Заданные язык и региональные параметры.</param>
		/// <param name="version">Версия вспомогательной сборки.</param>
		/// <returns>Указанная вспомогательная сборка.</returns>
		// Token: 0x060042C3 RID: 17091
		Assembly GetSatelliteAssembly(CultureInfo culture, Version version);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.LoadModule(System.String,System.Byte[])" />.</summary>
		/// <param name="moduleName">Имя модуля. Должно соответствовать имени файла в манифесте этой сборки.</param>
		/// <param name="rawModule">Массив байтов, который является COFF-образом, содержащим передаваемый модуль или ресурс.</param>
		/// <returns>Загруженный модуль.</returns>
		// Token: 0x060042C4 RID: 17092
		Module LoadModule(string moduleName, byte[] rawModule);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.LoadModule(System.String,System.Byte[],System.Byte[])" />.</summary>
		/// <param name="moduleName">Имя модуля. Должно соответствовать имени файла в манифесте этой сборки.</param>
		/// <param name="rawModule">Массив байтов, который является COFF-образом, содержащим передаваемый модуль или ресурс.</param>
		/// <param name="rawSymbolStore">Массив байтов, содержащий необработанные байты, представляющие собой символы для модуля. Для файла ресурсов должно быть задано значение <see langword="null" />.</param>
		/// <returns>Загруженный модуль.</returns>
		// Token: 0x060042C5 RID: 17093
		Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.CreateInstance(System.String)" />.</summary>
		/// <param name="typeName">
		///   <see cref="P:System.Type.FullName" /> искомого типа.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Object" />, представляющий тип, для которого язык и региональные параметры, аргументы, связыватель и атрибуты привязки и активации установлены равными <see langword="null" />, а значение <see cref="T:System.Reflection.BindingFlags" /> установлено равным Public или Instance, либо <see langword="null" />, если параметр <paramref name="typeName" /> не найден.</returns>
		// Token: 0x060042C6 RID: 17094
		object CreateInstance(string typeName);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.CreateInstance(System.String,System.Boolean)" />.</summary>
		/// <param name="typeName">
		///   <see cref="P:System.Type.FullName" /> искомого типа.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы игнорировать регистр имени типа, в обратном случае — значение <see langword="false" />.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Object" />, представляющий тип, для которого язык и региональные параметры, аргументы, связыватель и атрибуты привязки и активации установлены равными <see langword="null" />, а значение <see cref="T:System.Reflection.BindingFlags" /> установлено равным Public или Instance, либо <see langword="null" />, если параметр <paramref name="typeName" /> не найден.</returns>
		// Token: 0x060042C7 RID: 17095
		object CreateInstance(string typeName, bool ignoreCase);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.CreateInstance(System.String,System.Boolean,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo,System.Object[])" />.</summary>
		/// <param name="typeName">
		///   <see cref="P:System.Type.FullName" /> искомого типа.</param>
		/// <param name="ignoreCase">Значение <see langword="true" />, чтобы игнорировать регистр имени типа, в обратном случае — значение <see langword="false" />.</param>
		/// <param name="bindingAttr">Битовая маска, влияющая на проведение поиска. Значение является сочетанием одноразрядных флагов из <see cref="T:System.Reflection.BindingFlags" />.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see langword="MemberInfo" /> с помощью отражения. Если значение параметра <paramref name="binder" /> равно <see langword="null" />, используется связыватель по умолчанию.</param>
		/// <param name="args">Массив типа <see langword="Object" />, содержащий аргументы, передаваемые конструктору. Этот массив аргументов должен по числу, порядку и типу аргументов соответствовать параметрам вызываемого конструктора. Если нужен конструктор по умолчанию, <paramref name="args" /> должен быть пустым массивом или <see langword="null" />.</param>
		/// <param name="culture">Экземпляр объекта <see langword="CultureInfo" />, используемого для управления приведением типов. Если значение этого объекта — <see langword="null" />, для текущего потока используется <see langword="CultureInfo" />. (Например, необходимо преобразовывать объект <see langword="String" />, представляющий 1000, в значение <see langword="Double" />, поскольку при разных языках и региональных параметрах 1000 представляется по-разному.)</param>
		/// <param name="activationAttributes">Массив типа <see langword="Object" />, содержащий один или несколько атрибутов активации, которые могут использоваться при активации. Вот пример атрибута активации: 
		/// URLAttribute(http://hostname/appname/objectURI)</param>
		/// <returns>Экземпляр <see langword="Object" />, представляющий указанный тип и соответствующий заданным критериям, или <see langword="null" />, если <paramref name="typeName" /> не найден.</returns>
		// Token: 0x060042C8 RID: 17096
		object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetLoadedModules" />.</summary>
		/// <returns>Массив модулей.</returns>
		// Token: 0x060042C9 RID: 17097
		Module[] GetLoadedModules();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetLoadedModules(System.Boolean)" />.</summary>
		/// <param name="getResourceModules">Значение <see langword="true" />, если необходимо включать модули ресурсов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив модулей.</returns>
		// Token: 0x060042CA RID: 17098
		Module[] GetLoadedModules(bool getResourceModules);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetModules" />.</summary>
		/// <returns>Массив модулей.</returns>
		// Token: 0x060042CB RID: 17099
		Module[] GetModules();

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetModules(System.Boolean)" />.</summary>
		/// <param name="getResourceModules">Значение <see langword="true" />, если необходимо включать модули ресурсов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Массив модулей.</returns>
		// Token: 0x060042CC RID: 17100
		Module[] GetModules(bool getResourceModules);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetModule(System.String)" />.</summary>
		/// <param name="name">Имя запрашиваемого модуля.</param>
		/// <returns>Запрашиваемый модуль или значение <see langword="null" />, если модуль не найден.</returns>
		// Token: 0x060042CD RID: 17101
		Module GetModule(string name);

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к методу <see cref="M:System.Reflection.Assembly.GetReferencedAssemblies" />.</summary>
		/// <returns>Массив типа <see cref="T:System.Reflection.AssemblyName" />, содержащий все сборки, на которые ссылается данная сборка.</returns>
		// Token: 0x060042CE RID: 17102
		AssemblyName[] GetReferencedAssemblies();

		/// <summary>Предоставляет COM-объекты с независящим от версии доступом к свойству <see cref="P:System.Reflection.Assembly.GlobalAssemblyCache" />.</summary>
		/// <returns>Значение <see langword="true" />, если сборка была загружена из глобального кэша сборок, в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060042CF RID: 17103
		bool GlobalAssemblyCache { get; }

		/// <summary>Предоставляет COM-объектам независимый от версии доступ к событию <see cref="E:System.Reflection.Assembly.ModuleResolve" />.</summary>
		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060042D0 RID: 17104
		// (remove) Token: 0x060042D1 RID: 17105
		event ModuleResolveEventHandler ModuleResolve;
	}
}
