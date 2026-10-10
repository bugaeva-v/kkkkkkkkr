using System;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет набор служб, преобразующих управляемую сборку в библиотеку COM-типов и наоборот.</summary>
	// Token: 0x02000741 RID: 1857
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComVisible(true)]
	[Guid("F1C3BF78-C3E4-11D3-88E7-00902754C43A")]
	public interface ITypeLibConverter
	{
		/// <summary>Преобразует сборку в библиотеку COM-типов.</summary>
		/// <param name="assembly">Преобразуемая сборка.</param>
		/// <param name="typeLibName">Имя файла итоговой библиотеки типов.</param>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.TypeLibExporterFlags" />, указывающее любые специальные параметры.</param>
		/// <param name="notifySink">Интерфейс <see cref="T:System.Runtime.InteropServices.ITypeLibExporterNotifySink" />, реализованный вызывающим объектом.</param>
		/// <returns>Объект, реализующий интерфейс <see langword="ITypeLib" />.</returns>
		// Token: 0x0600413E RID: 16702
		[return: MarshalAs(UnmanagedType.Interface)]
		object ConvertAssemblyToTypeLib(Assembly assembly, string typeLibName, TypeLibExporterFlags flags, ITypeLibExporterNotifySink notifySink);

		/// <summary>Преобразует библиотеку COM-типов в сборку.</summary>
		/// <param name="typeLib">Объект, реализующий интерфейс <see langword="ITypeLib" />.</param>
		/// <param name="asmFileName">Имя файла итоговой сборки.</param>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.TypeLibImporterFlags" />, указывающее любые специальные параметры.</param>
		/// <param name="notifySink">Интерфейс <see cref="T:System.Runtime.InteropServices.ITypeLibImporterNotifySink" />, реализованный вызывающим объектом.</param>
		/// <param name="publicKey">Массив <see langword="byte" />, содержащий открытый ключ.</param>
		/// <param name="keyPair">Объект <see cref="T:System.Reflection.StrongNameKeyPair" />, содержащий пару криптографических ключей — открытый и закрытый.</param>
		/// <param name="unsafeInterfaces">Если значение равно <see langword="true" />, для интерфейса необходимы проверки времени компоновки для разрешения <see cref="F:System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode" />. Если значение равно <see langword="false" />, для интерфейсов необходимы проверки во время выполнения, для которых требуется проверка стека. Они более ресурсоемки, но обеспечивают более высокую безопасность.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.AssemblyBuilder" />, содержащий преобразованную библиотеку типов.</returns>
		// Token: 0x0600413F RID: 16703
		AssemblyBuilder ConvertTypeLibToAssembly([MarshalAs(UnmanagedType.Interface)] object typeLib, string asmFileName, int flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, StrongNameKeyPair keyPair, bool unsafeInterfaces);

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
		// Token: 0x06004140 RID: 16704
		AssemblyBuilder ConvertTypeLibToAssembly([MarshalAs(UnmanagedType.Interface)] object typeLib, string asmFileName, TypeLibImporterFlags flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, StrongNameKeyPair keyPair, string asmNamespace, Version asmVersion);

		/// <summary>Получает имя и базу кода основной сборки взаимодействия для указанной библиотеки типов.</summary>
		/// <param name="g">Идентификатор GUID библиотеки типов.</param>
		/// <param name="major">Основной номер версии библиотеки типов.</param>
		/// <param name="minor">Дополнительный номер версии библиотеки типов.</param>
		/// <param name="lcid">Идентификатор LCID библиотеки типов.</param>
		/// <param name="asmName">При успешном возвращении имя основной сборки взаимодействия, связанной с параметром <paramref name="g" />.</param>
		/// <param name="asmCodeBase">При успешном возвращении база кода основной сборки взаимодействия, связанная с параметром <paramref name="g" />.</param>
		/// <returns>Значение <see langword="true" />, если основная сборка взаимодействия обнаружена в реестре; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004141 RID: 16705
		bool GetPrimaryInteropAssembly(Guid g, int major, int minor, int lcid, out string asmName, out string asmCodeBase);
	}
}
