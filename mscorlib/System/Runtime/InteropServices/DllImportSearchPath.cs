using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает пути, используемые для поиска DLL, предоставляющих вызываемые для платформы функции.</summary>
	// Token: 0x02000704 RID: 1796
	[Flags]
	public enum DllImportSearchPath
	{
		/// <summary>Выполнять поиск зависимостей библиотеки DLL в папке, где находится библиотека DLL, прежде чем в других папках.</summary>
		// Token: 0x04002AC9 RID: 10953
		UseDllDirectoryForDependencies = 256,
		/// <summary>Включить каталог приложения в путь поиска DLL.</summary>
		// Token: 0x04002ACA RID: 10954
		ApplicationDirectory = 512,
		/// <summary>Включить любой путь, который был явно добавлен в путь поиска по всему процессу с помощью функции Win32 AddDllDirectory.</summary>
		// Token: 0x04002ACB RID: 10955
		UserDirectories = 1024,
		/// <summary>Включить каталог <see langword="%WinDir%\System32" /> в путь поиска DLL.</summary>
		// Token: 0x04002ACC RID: 10956
		System32 = 2048,
		/// <summary>Включить каталог приложения, каталог <see langword="%WinDir%\System32" /> и каталоги пользователей в путь поиска DLL.</summary>
		// Token: 0x04002ACD RID: 10957
		SafeDirectories = 4096,
		/// <summary>При поиске зависимостей сборки включите каталог, содержащий саму сборку, и сначала выполните поиск в этом каталоге. Это значение используется платформой .NET Framework, прежде чем пути передаются в функцию Win32 LoadLibraryEx.</summary>
		// Token: 0x04002ACE RID: 10958
		AssemblyDirectory = 2,
		/// <summary>Выполните поиск в каталоге приложения, а затем вызовите функцию Win32 LoadLibraryEx с флагом LOAD_WITH_ALTERED_SEARCH_PATH. Это значение пропускается, если указано любое другое значение. Операционные системы, которые не поддерживают атрибут <see cref="T:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute" />, используют это значение и пропускают остальные значения.</summary>
		// Token: 0x04002ACF RID: 10959
		LegacyBehavior = 0
	}
}
