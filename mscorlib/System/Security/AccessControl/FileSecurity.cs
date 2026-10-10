using System;
using System.Runtime.InteropServices;

namespace System.Security.AccessControl
{
	/// <summary>Представляет возможности управления доступом и аудита безопасности для файла. Этот класс не наследуется.</summary>
	// Token: 0x02000527 RID: 1319
	public sealed class FileSecurity : FileSystemSecurity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.FileSecurity" />.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows 2000 или более поздней версией Windows.</exception>
		// Token: 0x06003436 RID: 13366 RVA: 0x000BEA54 File Offset: 0x000BCC54
		public FileSecurity() : base(false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.FileSecurity" /> на основании указанного файла, используя указанные значения из перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />.</summary>
		/// <param name="fileName">Расположение файла, на основании которого создается объект <see cref="T:System.Security.AccessControl.FileSecurity" />.</param>
		/// <param name="includeSections">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее тип сведений о списке управления доступом, которые необходимо получить.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="fileName" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, указанный в параметре <paramref name="fileName" />, не найден.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.SEHException">Параметр <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows 2000 или более поздней версией Windows.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.AccessControl.PrivilegeNotHeldException">Текущая учетная запись системы не имеет прав администратора.</exception>
		/// <exception cref="T:System.SystemException">Не удалось найти файл.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="fileName" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// Параметр <paramref name="fileName" /> указывает каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003437 RID: 13367 RVA: 0x000BEA5D File Offset: 0x000BCC5D
		public FileSecurity(string fileName, AccessControlSections includeSections) : base(false, fileName, includeSections)
		{
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x000BEA68 File Offset: 0x000BCC68
		internal FileSecurity(SafeHandle handle, AccessControlSections includeSections) : base(false, handle, includeSections)
		{
		}
	}
}
