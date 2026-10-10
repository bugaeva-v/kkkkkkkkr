using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Определяет компоненты и устанавливает их в каталог COM+.</summary>
	// Token: 0x0200005B RID: 91
	[Guid("3b0398c9-7812-4007-85cb-18c771f2206f")]
	public class ComManagedImportUtil : IComManagedImportUtil
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.Internal.ComManagedImportUtil" />.</summary>
		// Token: 0x0600015F RID: 351 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public ComManagedImportUtil()
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает из сборки информацию о компонентах.</summary>
		/// <param name="assemblyPath">Путь к сборке.</param>
		/// <param name="numComponents">Когда этот метод возвращает управление, данный параметр содержит количество компонентов в сборке.</param>
		/// <param name="componentInfo">Когда этот метод возвращает управление, данный параметр содержит информацию о компонентах.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assemblyPath" /> — пустая строка, содержащая только пробел либо один или несколько недопустимых знаков, указанных в <see cref="F:System.IO.Path.InvalidPathChars" />.  
		/// -или- 
		/// Система не может извлечь абсолютный путь.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствуют необходимые разрешения.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyPath" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="assemblyPath" /> содержит двоеточие (":").</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x06000160 RID: 352 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void GetComponentInfo(string assemblyPath, out string numComponents, out string componentInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Устанавливает сборку в приложение COM+.</summary>
		/// <param name="asmpath">Путь к сборке.</param>
		/// <param name="parname">Имя раздела COM+.</param>
		/// <param name="appname">Имя приложения COM+.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.EnterpriseServices.RegistrationException">Входная сборка не имеет строгого имени.</exception>
		// Token: 0x06000161 RID: 353 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void InstallAssembly(string asmpath, string parname, string appname)
		{
			throw new NotImplementedException();
		}
	}
}
