using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет набор служб, преобразующих управляемую сборку в библиотеку COM-типов и наоборот.</summary>
	// Token: 0x02000752 RID: 1874
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[Guid("f1c3bf79-c3e4-11d3-88e7-00902754c43a")]
	public sealed class TypeLibConverter : ITypeLibConverter
	{
		/// <summary>Преобразует сборку в библиотеку COM-типов.</summary>
		/// <param name="assembly">Преобразуемая сборка.</param>
		/// <param name="strTypeLibName">Имя файла итоговой библиотеки типов.</param>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.TypeLibExporterFlags" />, указывающее любые специальные параметры.</param>
		/// <param name="notifySink">Интерфейс <see cref="T:System.Runtime.InteropServices.ITypeLibExporterNotifySink" />, реализованный вызывающим объектом.</param>
		/// <returns>Объект, реализующий интерфейс <see langword="ITypeLib" />.</returns>
		// Token: 0x06004245 RID: 16965 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SecuritySafeCritical]
		[MonoTODO("implement")]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public object ConvertAssemblyToTypeLib(Assembly assembly, string strTypeLibName, TypeLibExporterFlags flags, ITypeLibExporterNotifySink notifySink)
		{
			throw new NotImplementedException();
		}

		/// <summary>Преобразует библиотеку COM-типов в сборку.</summary>
		/// <param name="typeLib">Объект, реализующий интерфейс <see langword="ITypeLib" />.</param>
		/// <param name="asmFileName">Имя файла итоговой сборки.</param>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.TypeLibImporterFlags" />, указывающее любые специальные параметры.</param>
		/// <param name="notifySink">Интерфейс <see cref="T:System.Runtime.InteropServices.ITypeLibImporterNotifySink" />, реализованный вызывающим объектом.</param>
		/// <param name="publicKey">Массив <see langword="byte" />, содержащий открытый ключ.</param>
		/// <param name="keyPair">Объект <see cref="T:System.Reflection.StrongNameKeyPair" />, содержащий пару криптографических ключей — открытый и закрытый.</param>
		/// <param name="unsafeInterfaces">Если значение равно <see langword="true" />, для интерфейса необходимы проверки времени компоновки для разрешения <see cref="F:System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode" />. Если значение равно <see langword="false" />, для интерфейсов необходимы проверки во время выполнения, для которых требуется проверка стека. Они более ресурсоемки, но обеспечивают более высокую безопасность.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.AssemblyBuilder" />, содержащий преобразованную библиотеку типов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeLib" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="asmFileName" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="notifySink" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asmFileName" /> равен пустой строке.  
		///
		/// или - 
		/// <paramref name="asmFileName" /> превышает максимальную длину, определенную системой. Дополнительные сведения см. в разделе <see cref="T:System.IO.PathTooLongException" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="flags" /> не является <see cref="F:System.Runtime.InteropServices.TypeLibImporterFlags.PrimaryInteropAssembly" />.  
		///
		/// или - 
		/// Значения параметров <paramref name="publicKey" /> и <paramref name="keyPair" /> равны <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">Созданные метаданные содержат ошибки, препятствующие загрузке типов.</exception>
		// Token: 0x06004246 RID: 16966 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("implement")]
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public AssemblyBuilder ConvertTypeLibToAssembly([MarshalAs(UnmanagedType.Interface)] object typeLib, string asmFileName, int flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, StrongNameKeyPair keyPair, bool unsafeInterfaces)
		{
			throw new NotImplementedException();
		}

		/// <summary>Преобразует библиотеку COM-типов в сборку.</summary>
		/// <param name="typeLib">Объект, реализующий интерфейс <see langword="ITypeLib" />.</param>
		/// <param name="asmFileName">Имя файла итоговой сборки.</param>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.TypeLibImporterFlags" />, указывающее любые специальные параметры.</param>
		/// <param name="notifySink">Интерфейс <see cref="T:System.Runtime.InteropServices.ITypeLibImporterNotifySink" />, реализованный вызывающим объектом.</param>
		/// <param name="publicKey">Массив <see langword="byte" />, содержащий открытый ключ.</param>
		/// <param name="keyPair">Объект <see cref="T:System.Reflection.StrongNameKeyPair" />, содержащий пару криптографических ключей — открытый и закрытый.</param>
		/// <param name="asmNamespace">Пространство имен для итоговой сборки.</param>
		/// <param name="asmVersion">Версия итоговой сборки. Если значение равно <see langword="null" />, используется версия библиотеки типов.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.AssemblyBuilder" />, содержащий преобразованную библиотеку типов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeLib" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="asmFileName" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="notifySink" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asmFileName" /> равен пустой строке.  
		///
		/// или - 
		/// <paramref name="asmFileName" /> превышает максимальную длину, определенную системой. Дополнительные сведения см. в разделе <see cref="T:System.IO.PathTooLongException" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="flags" /> не является <see cref="F:System.Runtime.InteropServices.TypeLibImporterFlags.PrimaryInteropAssembly" />.  
		///
		/// или - 
		/// Значения параметров <paramref name="publicKey" /> и <paramref name="keyPair" /> равны <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">Созданные метаданные содержат ошибки, препятствующие загрузке типов.</exception>
		// Token: 0x06004247 RID: 16967 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SecuritySafeCritical]
		[MonoTODO("implement")]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public AssemblyBuilder ConvertTypeLibToAssembly([MarshalAs(UnmanagedType.Interface)] object typeLib, string asmFileName, TypeLibImporterFlags flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, StrongNameKeyPair keyPair, string asmNamespace, Version asmVersion)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает имя и базу кода основной сборки взаимодействия для указанной библиотеки типов.</summary>
		/// <param name="g">Идентификатор GUID библиотеки типов.</param>
		/// <param name="major">Основной номер версии библиотеки типов.</param>
		/// <param name="minor">Дополнительный номер версии библиотеки типов.</param>
		/// <param name="lcid">Идентификатор LCID библиотеки типов.</param>
		/// <param name="asmName">При успешном возвращении имя основной сборки взаимодействия, связанной с параметром <paramref name="g" />.</param>
		/// <param name="asmCodeBase">При успешном возвращении база кода основной сборки взаимодействия, связанная с параметром <paramref name="g" />.</param>
		/// <returns>Значение <see langword="true" />, если основная сборка взаимодействия обнаружена в реестре; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004248 RID: 16968 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("implement")]
		public bool GetPrimaryInteropAssembly(Guid g, int major, int minor, int lcid, out string asmName, out string asmCodeBase)
		{
			throw new NotImplementedException();
		}
	}
}
