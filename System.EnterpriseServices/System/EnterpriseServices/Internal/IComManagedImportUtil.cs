using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Определяет компоненты и устанавливает их в каталог COM+.</summary>
	// Token: 0x0200005F RID: 95
	[Guid("c3f8f66b-91be-4c99-a94f-ce3b0a951039")]
	public interface IComManagedImportUtil
	{
		/// <summary>Получает из сборки информацию о компонентах.</summary>
		/// <param name="assemblyPath">Путь к сборке.</param>
		/// <param name="numComponents">Когда этот метод возвращает управление, данный параметр содержит количество компонентов в сборке.</param>
		/// <param name="componentInfo">Когда этот метод возвращает управление, данный параметр содержит информацию о компонентах.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assemblyPath" /> — пустая строка (""), содержащая только пробел либо один или несколько недопустимых знаков, указанных в <see cref="F:System.IO.Path.InvalidPathChars" />.  
		/// -или- 
		/// Система не может извлечь абсолютный путь.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствуют необходимые разрешения.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyPath" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="assemblyPath" /> содержит двоеточие (":").</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x0600016D RID: 365
		[DispId(4)]
		void GetComponentInfo([MarshalAs(UnmanagedType.BStr)] string assemblyPath, [MarshalAs(UnmanagedType.BStr)] out string numComponents, [MarshalAs(UnmanagedType.BStr)] out string componentInfo);

		/// <summary>Устанавливает сборку в приложение COM+.</summary>
		/// <param name="filename">Путь к сборке.</param>
		/// <param name="parname">Имя раздела COM+.</param>
		/// <param name="appname">Имя приложения COM+.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.EnterpriseServices.RegistrationException">Входная сборка не имеет строгого имени.</exception>
		// Token: 0x0600016E RID: 366
		[DispId(5)]
		void InstallAssembly([MarshalAs(UnmanagedType.BStr)] string filename, [MarshalAs(UnmanagedType.BStr)] string parname, [MarshalAs(UnmanagedType.BStr)] string appname);
	}
}
