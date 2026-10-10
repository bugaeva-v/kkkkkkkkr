using System;

namespace System.Security.AccessControl
{
	/// <summary>Представляет возможности управления доступом и аудита безопасности для каталога. Этот класс не наследуется.</summary>
	// Token: 0x02000521 RID: 1313
	public sealed class DirectorySecurity : FileSystemSecurity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.DirectorySecurity" />.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows 2000 или более поздней версией Windows.</exception>
		// Token: 0x06003409 RID: 13321 RVA: 0x000BE750 File Offset: 0x000BC950
		public DirectorySecurity() : base(true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.DirectorySecurity" /> на основании указанного каталога, используя указанные значения из перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />.</summary>
		/// <param name="name">Расположение каталога, на основании которого создается объект <see cref="T:System.Security.AccessControl.DirectorySecurity" />.</param>
		/// <param name="includeSections">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее тип сведений о списке управления доступом, которые необходимо получить.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, указанный в параметре <paramref name="name" />, не найден.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии каталога возникла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="name" /> имеет недопустимый формат.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows 2000 или более поздней версией Windows.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.AccessControl.PrivilegeNotHeldException">Текущая учетная запись системы не имеет прав администратора.</exception>
		/// <exception cref="T:System.SystemException">Не удается найти каталог.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="name" /> указывает каталог, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600340A RID: 13322 RVA: 0x000BE759 File Offset: 0x000BC959
		public DirectorySecurity(string name, AccessControlSections includeSections) : base(true, name, includeSections)
		{
		}
	}
}
