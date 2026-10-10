using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Security.AccessControl;

namespace System.IO
{
	/// <summary>Предоставляет статические методы для создания, перемещения и перечисления в каталогах и вложенных каталогах. Этот класс не наследуется.</summary>
	// Token: 0x02000B2E RID: 2862
	public static class Directory
	{
		/// <summary>Извлекает родительский каталог, на который указывает абсолютный или относительный путь.</summary>
		/// <param name="path">Путь, для которого необходимо извлечь родительский каталог.</param>
		/// <returns>Родительский каталог или значение <see langword="null" />, если <paramref name="path" /> является корневым каталогом, в том числе корнем сервера UNC или именем общего ресурса.</returns>
		/// <exception cref="T:System.IO.IOException">Каталог, заданный параметром <paramref name="path" />, доступен только для чтения.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе. Дополнительные сведения см. в разделе <see cref="T:System.IO.PathTooLongException" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный путь не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">Только .NET Framework: У вызывающего объекта отсутствуют необходимые разрешения.</exception>
		// Token: 0x060066DF RID: 26335 RVA: 0x0015F46C File Offset: 0x0015D66C
		public static DirectoryInfo GetParent(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Path cannot be the empty string or all whitespace.", "path");
			}
			string directoryName = Path.GetDirectoryName(Path.GetFullPath(path));
			if (directoryName == null)
			{
				return null;
			}
			return new DirectoryInfo(directoryName);
		}

		/// <summary>Создает все каталоги и подкаталоги по указанному пути, если они еще не существуют.</summary>
		/// <param name="path">Каталог, который необходимо создать.</param>
		/// <returns>Объект, представляющий каталог по указанному пути. Этот объект возвращается вне зависимости от того, существует ли уже каталог по указанному пути.</returns>
		/// <exception cref="T:System.IO.IOException">Каталог, заданный параметром <paramref name="path" />, является файлом.  
		/// -или- 
		/// Имя сети неизвестно.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="path" /> начинается с символа двоеточия (:) или содержит только двоеточие.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> содержит двоеточие (:), которое не является частью метки диска (C:\).</exception>
		// Token: 0x060066E0 RID: 26336 RVA: 0x0015F4B6 File Offset: 0x0015D6B6
		public static DirectoryInfo CreateDirectory(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Path cannot be the empty string or all whitespace.", "path");
			}
			string fullPath = Path.GetFullPath(path);
			FileSystem.CreateDirectory(fullPath);
			return new DirectoryInfo(fullPath, null, null, false);
		}

		/// <summary>Определяет, указывает ли заданный путь на существующий каталог на диске.</summary>
		/// <param name="path">Проверяемый путь.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="path" /> ссылается на существующий каталог; значение <see langword="false" />, если каталог не существует или если при попытке определить, существует ли указанный каталог.</returns>
		// Token: 0x060066E1 RID: 26337 RVA: 0x0015F4F4 File Offset: 0x0015D6F4
		public static bool Exists(string path)
		{
			try
			{
				if (path == null)
				{
					return false;
				}
				if (path.Length == 0)
				{
					return false;
				}
				return FileSystem.DirectoryExists(Path.GetFullPath(path));
			}
			catch (ArgumentException)
			{
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
			return false;
		}

		/// <summary>Устанавливает дату и время создания заданного файла или каталога.</summary>
		/// <param name="path">Файл или каталог, для которого требуется установить дату и время создания.</param>
		/// <param name="creationTime">Дата и время последней записи в файл или каталог. Значение представляется в формате местного времени.</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный путь не найден.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="creationTime" /> указывает значение, выходящее за диапазон дат или времени, разрешенных для этой операции.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версией.</exception>
		// Token: 0x060066E2 RID: 26338 RVA: 0x0015F558 File Offset: 0x0015D758
		public static void SetCreationTime(string path, DateTime creationTime)
		{
			FileSystem.SetCreationTime(Path.GetFullPath(path), creationTime, true);
		}

		/// <summary>Устанавливает дату и время создания указанного файла или папки в формате всемирного координированного времени (UTC).</summary>
		/// <param name="path">Файл или каталог, для которого требуется установить дату и время создания.</param>
		/// <param name="creationTimeUtc">Дата и время создания каталога или файла. Значение представляется в формате местного времени.</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный путь не найден.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="creationTime" /> указывает значение, выходящее за диапазон дат или времени, разрешенных для этой операции.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версией.</exception>
		// Token: 0x060066E3 RID: 26339 RVA: 0x0015F56C File Offset: 0x0015D76C
		public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
		{
			FileSystem.SetCreationTime(Path.GetFullPath(path), File.GetUtcDateTimeOffset(creationTimeUtc), true);
		}

		/// <summary>Получает дату и время создания каталога.</summary>
		/// <param name="path">Путь к каталогу.</param>
		/// <returns>Структура, для которой заданы дата и время создания указанного каталога. Значение представляется в формате местного времени.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x060066E4 RID: 26340 RVA: 0x0015F580 File Offset: 0x0015D780
		public static DateTime GetCreationTime(string path)
		{
			return File.GetCreationTime(path);
		}

		/// <summary>Получает время и дату создания каталога в формате всемирного координированного времени (UTC).</summary>
		/// <param name="path">Путь к каталогу.</param>
		/// <returns>Структура, для которой заданы дата и время создания указанного каталога. Значение выражено в формате всемирного координированного времени (UTC).</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x060066E5 RID: 26341 RVA: 0x0015F588 File Offset: 0x0015D788
		public static DateTime GetCreationTimeUtc(string path)
		{
			return File.GetCreationTimeUtc(path);
		}

		/// <summary>Устанавливает дату и время последней записи в файл или каталог.</summary>
		/// <param name="path">Путь к каталогу.</param>
		/// <param name="lastWriteTime">Дата и время последней записи в файл или каталог. Значение представляется в формате местного времени.</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Параметр <paramref name="path" /> не найден (например, каталог не существует или находится на несопоставленном диске).</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Параметр <paramref name="path" /> не найден (например, каталог не существует или находится на несопоставленном диске).</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версии.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="lastWriteTime" /> указывает значение, выходящее за диапазон дат или времени, разрешенных для этой операции.</exception>
		// Token: 0x060066E6 RID: 26342 RVA: 0x0015F590 File Offset: 0x0015D790
		public static void SetLastWriteTime(string path, DateTime lastWriteTime)
		{
			FileSystem.SetLastWriteTime(Path.GetFullPath(path), lastWriteTime, true);
		}

		/// <summary>Устанавливает дату и время последней записи в заданный каталог в формате всемирного координированного времени (UTC).</summary>
		/// <param name="path">Путь к каталогу.</param>
		/// <param name="lastWriteTimeUtc">Дата и время последней записи в файл или каталог. Значение выражено в формате всемирного координированного времени (UTC).</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Параметр <paramref name="path" /> не найден (например, каталог не существует или находится на несопоставленном диске).</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Параметр <paramref name="path" /> не найден (например, каталог не существует или находится на несопоставленном диске).</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версии.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="lastWriteTimeUtc" /> указывает значение, выходящее за диапазон дат или времени, разрешенных для этой операции.</exception>
		// Token: 0x060066E7 RID: 26343 RVA: 0x0015F5A4 File Offset: 0x0015D7A4
		public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
		{
			FileSystem.SetLastWriteTime(Path.GetFullPath(path), File.GetUtcDateTimeOffset(lastWriteTimeUtc), true);
		}

		/// <summary>Возвращает время и дату последней операции записи в указанный файл или каталог.</summary>
		/// <param name="path">Файл или каталог, дату и время изменения которого следует получить.</param>
		/// <returns>Структура , для которой заданы дата и время последней операции записи в указанный файл или каталог. Значение представляется в формате местного времени.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x060066E8 RID: 26344 RVA: 0x0015F5B8 File Offset: 0x0015D7B8
		public static DateTime GetLastWriteTime(string path)
		{
			return File.GetLastWriteTime(path);
		}

		/// <summary>Возвращает дату и время последней операции записи в заданный файл или каталог в формате всемирного координированного времени (UTC).</summary>
		/// <param name="path">Файл или каталог, дату и время изменения которого следует получить.</param>
		/// <returns>Структура , для которой заданы дата и время последней операции записи в указанный файл или каталог. Значение выражено в формате всемирного координированного времени (UTC).</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x060066E9 RID: 26345 RVA: 0x0015F5C0 File Offset: 0x0015D7C0
		public static DateTime GetLastWriteTimeUtc(string path)
		{
			return File.GetLastWriteTimeUtc(path);
		}

		/// <summary>Устанавливает время и дату последнего обращения к заданному файлу или каталогу.</summary>
		/// <param name="path">Файл или каталог, для которого требуется установить дату и время доступа.</param>
		/// <param name="lastAccessTime">Объект, содержащий значение, которое необходимо присвоить дате и времени доступа к <paramref name="path" />. Значение представляется в формате местного времени.</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный путь не найден.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версии.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="lastAccessTime" /> указывает значение, выходящее за диапазон дат или времени, разрешенных для этой операции.</exception>
		// Token: 0x060066EA RID: 26346 RVA: 0x0015F5C8 File Offset: 0x0015D7C8
		public static void SetLastAccessTime(string path, DateTime lastAccessTime)
		{
			FileSystem.SetLastAccessTime(Path.GetFullPath(path), lastAccessTime, true);
		}

		/// <summary>Устанавливает дату и время последнего доступа к заданному файлу или каталогу в формате всемирного координированного времени (UTC).</summary>
		/// <param name="path">Файл или каталог, для которого требуется установить дату и время доступа.</param>
		/// <param name="lastAccessTimeUtc">Объект, содержащий значение, которое необходимо присвоить дате и времени доступа к <paramref name="path" />. Значение выражено в формате всемирного координированного времени (UTC).</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный путь не найден.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версии.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="lastAccessTimeUtc" /> указывает значение, выходящее за диапазон дат или времени, разрешенных для этой операции.</exception>
		// Token: 0x060066EB RID: 26347 RVA: 0x0015F5DC File Offset: 0x0015D7DC
		public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
		{
			FileSystem.SetLastAccessTime(Path.GetFullPath(path), File.GetUtcDateTimeOffset(lastAccessTimeUtc), true);
		}

		/// <summary>Возвращает время и дату последнего обращения к указанному файлу или каталогу.</summary>
		/// <param name="path">Файл или каталог, информацию о дате и времени обращения к которому следует получить.</param>
		/// <returns>Структура , для которой заданы дата и время последнего доступа к указанному файлу или каталогу. Значение представляется в формате местного времени.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> имеет недопустимый формат.</exception>
		// Token: 0x060066EC RID: 26348 RVA: 0x0015F5F0 File Offset: 0x0015D7F0
		public static DateTime GetLastAccessTime(string path)
		{
			return File.GetLastAccessTime(path);
		}

		/// <summary>Возвращает дату и время последнего доступа к заданному файлу или каталогу в формате всемирного координированного времени (UTC).</summary>
		/// <param name="path">Файл или каталог, информацию о дате и времени обращения к которому следует получить.</param>
		/// <returns>Структура , для которой заданы дата и время последнего доступа к указанному файлу или каталогу. Значение выражено в формате всемирного координированного времени (UTC).</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> имеет недопустимый формат.</exception>
		// Token: 0x060066ED RID: 26349 RVA: 0x0015F5F8 File Offset: 0x0015D7F8
		public static DateTime GetLastAccessTimeUtc(string path)
		{
			return File.GetLastAccessTimeUtc(path);
		}

		/// <summary>Возвращает имена файлов (с указанием пути к ним) в указанном каталоге.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <returns>Массив полных имен (включая пути) файлов в указанном каталоге или пустой массив, если файлы не найдены.</returns>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.  
		/// -или- 
		/// Произошла сетевая ошибка.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный путь не найден или является недопустимым (например, ведет на несопоставленный диск).</exception>
		// Token: 0x060066EE RID: 26350 RVA: 0x0015F600 File Offset: 0x0015D800
		public static string[] GetFiles(string path)
		{
			return Directory.GetFiles(path, "*", EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает имена файлов (включая пути) из указанного каталога, отвечающие условиям заданного шаблона поиска.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <param name="searchPattern">Строка поиска, которая должна сравниваться с именами файлов в <paramref name="path" />.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <returns>Массив полных имен (включая пути) файлов в указанном каталоге, которые соответствуют указанному шаблону поиска, или пустой массив, если файлы не найдены.</returns>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.  
		/// -или- 
		/// Произошла сетевая ошибка.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="path" /> или <paramref name="searchPattern" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный путь не найден или является недопустимым (например, ведет на несопоставленный диск).</exception>
		// Token: 0x060066EF RID: 26351 RVA: 0x0015F612 File Offset: 0x0015D812
		public static string[] GetFiles(string path, string searchPattern)
		{
			return Directory.GetFiles(path, searchPattern, EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает имена файлов (включая пути) в заданном каталоге, отвечающие условиям шаблона поиска, используя значение, которое определяет, выполнять ли поиск в подкаталогах.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <param name="searchPattern">Строка поиска, которая должна сравниваться с именами файлов в <paramref name="path" />.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <param name="searchOption">Одно из значений перечисления, определяющее, следует ли выполнять поиск только в текущем каталоге или также во всех его подкаталогах.</param>
		/// <returns>Массив полных имен (включая пути) файлов в указанном каталоге, которые соответствуют указанному шаблону и параметру поиска, или пустой массив, если файлы не найдены.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="path" /> или <paramref name="searchpattern" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> не является допустимым значением <see cref="T:System.IO.SearchOption" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный путь не найден или является недопустимым (например, ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.  
		/// -или- 
		/// Произошла сетевая ошибка.</exception>
		// Token: 0x060066F0 RID: 26352 RVA: 0x0015F620 File Offset: 0x0015D820
		public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			return Directory.GetFiles(path, searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x060066F1 RID: 26353 RVA: 0x0015F62F File Offset: 0x0015D82F
		public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Files, enumerationOptions).ToArray<string>();
		}

		/// <summary>Возвращает имена подкаталогов (включая пути) в указанном каталоге.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <returns>Массив полных имен (включая пути) подкаталогов по указанному пути или пустой массив, если каталоги не найдены.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		// Token: 0x060066F2 RID: 26354 RVA: 0x0015F63F File Offset: 0x0015D83F
		public static string[] GetDirectories(string path)
		{
			return Directory.GetDirectories(path, "*", EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает имена подкаталогов (включая пути) в указанном каталоге, соответствующих указанному шаблону поиска.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами подкаталогов в <paramref name="path" />. Этот параметр может содержать сочетание допустимых литеральных и подстановочных символов, но не поддерживает регулярные выражения.</param>
		/// <returns>Массив полных имен (включая пути) подкаталогов в указанном каталоге, которые соответствуют указанному шаблону поиска, или пустой массив, если каталоги не найдены.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="path" /> или <paramref name="searchPattern" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		// Token: 0x060066F3 RID: 26355 RVA: 0x0015F651 File Offset: 0x0015D851
		public static string[] GetDirectories(string path, string searchPattern)
		{
			return Directory.GetDirectories(path, searchPattern, EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает имена подкаталогов (включая пути) в указанном каталоге, соответствующих указанному шаблону поиска, и при необходимости ведет поиск в подкаталогах.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами подкаталогов в <paramref name="path" />. Этот параметр может содержать сочетание допустимых литеральных и подстановочных символов, но не поддерживает регулярные выражения.</param>
		/// <param name="searchOption">Одно из значений перечисления, определяющее, следует ли выполнять поиск только в текущем каталоге или также во всех его подкаталогах.</param>
		/// <returns>Массив полных имен (включая пути) подкаталогов, соответствующих указанным критериям, или пустой массив, если каталоги не найдены.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="path" /> или <paramref name="searchPattern" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> не является допустимым значением <see cref="T:System.IO.SearchOption" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		// Token: 0x060066F4 RID: 26356 RVA: 0x0015F65F File Offset: 0x0015D85F
		public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
		{
			return Directory.GetDirectories(path, searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x0015F66E File Offset: 0x0015D86E
		public static string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Directories, enumerationOptions).ToArray<string>();
		}

		/// <summary>Возвращает имена всех файлов и подкаталогов по указанному пути.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <returns>Массив имен файлов и подкаталогов в указанном каталоге или пустой массив, если файлы или подкаталоги не найдены.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		// Token: 0x060066F6 RID: 26358 RVA: 0x0015F67E File Offset: 0x0015D87E
		public static string[] GetFileSystemEntries(string path)
		{
			return Directory.GetFileSystemEntries(path, "*", EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает массив имен файлов и имен каталогов по указанному пути, соответствующих шаблону поиска.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами файла и каталогов в <paramref name="path" />.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <returns>Массив имен файлов и имен каталогов, соответствующих указанным критериям поиска, или пустой массив, если файлы или каталоги не найдены.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="path" /> или <paramref name="searchPattern" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		// Token: 0x060066F7 RID: 26359 RVA: 0x0015F690 File Offset: 0x0015D890
		public static string[] GetFileSystemEntries(string path, string searchPattern)
		{
			return Directory.GetFileSystemEntries(path, searchPattern, EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает массив всех имен файлов и каталогов по указанному пути, соответствующих шаблону поиска, и при необходимости ведет поиск в подкаталогах.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <param name="searchPattern">Строка поиска, которая должна сравниваться с именами файлов и каталогов в параметре <paramref name="path" />.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <param name="searchOption">Одно из значений перечисления, определяющее, следует ли выполнять поиск только в текущем каталоге или также во всех его подкаталогах.  
		/// Значение по умолчанию — <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
		/// <returns>Массив имен файлов и имен каталогов, соответствующих указанным критериям поиска, или пустой массив, если файлы или каталоги не найдены.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую недопустимые символы. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> не является допустимым значением <see cref="T:System.IO.SearchOption" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" />: например, он ссылается на несопоставленный диск.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или их комбинация превышает максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060066F8 RID: 26360 RVA: 0x0015F69E File Offset: 0x0015D89E
		public static string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
		{
			return Directory.GetFileSystemEntries(path, searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x0015F6AD File Offset: 0x0015D8AD
		public static string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Both, enumerationOptions).ToArray<string>();
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x0015F6C0 File Offset: 0x0015D8C0
		internal static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (searchPattern == null)
			{
				throw new ArgumentNullException("searchPattern");
			}
			FileSystemEnumerableFactory.NormalizeInputs(ref path, ref searchPattern, options);
			switch (searchTarget)
			{
			case SearchTarget.Files:
				return FileSystemEnumerableFactory.UserFiles(path, searchPattern, options);
			case SearchTarget.Directories:
				return FileSystemEnumerableFactory.UserDirectories(path, searchPattern, options);
			case SearchTarget.Both:
				return FileSystemEnumerableFactory.UserEntries(path, searchPattern, options);
			default:
				throw new ArgumentOutOfRangeException("searchTarget");
			}
		}

		/// <summary>Возвращает перечисляемую коллекцию имен каталогов, расположенных по указанному пути.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <returns>Перечисляемая коллекция полных имен (включая пути) для каталогов в каталоге, заданном параметром <paramref name="path" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую недопустимые символы. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" />: например, он ссылается на несопоставленный диск.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или их комбинация превышает максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060066FB RID: 26363 RVA: 0x0015F72E File Offset: 0x0015D92E
		public static IEnumerable<string> EnumerateDirectories(string path)
		{
			return Directory.EnumerateDirectories(path, "*", EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает перечисляемую коллекцию имен каталогов, соответствующих шаблону поиска по указанному пути.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <param name="searchPattern">Строка поиска, которую необходимо сравнивать с именами каталогов, расположенных по пути <paramref name="path" />.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <returns>Перечисляемая коллекция полных имен (включая пути) для каталогов в каталоге, указанном в <paramref name="path" />, которые соответствуют указанному шаблону поиска.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую недопустимые символы. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" />: например, он ссылается на несопоставленный диск.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или их комбинация превышает максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060066FC RID: 26364 RVA: 0x0015F740 File Offset: 0x0015D940
		public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
		{
			return Directory.EnumerateDirectories(path, searchPattern, EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает перечисляемую коллекцию имен каталогов, соответствующих шаблону поиска по указанному пути. Возможно, поиск ведется также и в подкаталогах.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <param name="searchPattern">Строка поиска, которую необходимо сравнивать с именами каталогов, расположенных по пути <paramref name="path" />.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <param name="searchOption">Одно из значений перечисления, определяющее, следует ли выполнять поиск только в текущем каталоге или также во всех его подкаталогах.  
		/// Значение по умолчанию — <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
		/// <returns>Перечисляемая коллекция полных имен (включая пути) для каталогов в каталоге, указанном в <paramref name="path" />, которые соответствуют заданному шаблону и параметрам поиска.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую недопустимые символы. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> не является допустимым значением <see cref="T:System.IO.SearchOption" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" />: например, он ссылается на несопоставленный диск.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или их комбинация превышает максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060066FD RID: 26365 RVA: 0x0015F74E File Offset: 0x0015D94E
		public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
		{
			return Directory.EnumerateDirectories(path, searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x060066FE RID: 26366 RVA: 0x0015F75D File Offset: 0x0015D95D
		public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Directories, enumerationOptions);
		}

		/// <summary>Возвращает перечисляемую коллекцию имен файлов, расположенных по указанному пути.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <returns>Перечисляемая коллекция полных имен (включая пути) для файлов в каталоге, заданном параметром <paramref name="path" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую недопустимые символы. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" />: например, он ссылается на несопоставленный диск.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или их комбинация превышает максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060066FF RID: 26367 RVA: 0x0015F768 File Offset: 0x0015D968
		public static IEnumerable<string> EnumerateFiles(string path)
		{
			return Directory.EnumerateFiles(path, "*", EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает перечисляемую коллекцию имен файлов, соответствующих шаблону поиска по указанному пути.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <param name="searchPattern">Строка поиска, которая должна сравниваться с именами файлов в <paramref name="path" />.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <returns>Перечисляемая коллекция полных имен (включая пути) для файлов в каталоге, указанном в параметре <paramref name="path" />, которые соответствуют заданному шаблону поиска.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую недопустимые символы. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" />: например, он ссылается на несопоставленный диск.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или их комбинация превышает максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006700 RID: 26368 RVA: 0x0015F77A File Offset: 0x0015D97A
		public static IEnumerable<string> EnumerateFiles(string path, string searchPattern)
		{
			return Directory.EnumerateFiles(path, searchPattern, EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает перечисляемую коллекцию имен файлов, соответствующих шаблону поиска по указанному пути. Возможно, поиск ведется также и в подкаталогах.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <param name="searchPattern">Строка поиска, которая должна сравниваться с именами файлов в <paramref name="path" />.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <param name="searchOption">Одно из значений перечисления, определяющее, следует ли выполнять поиск только в текущем каталоге или также во всех его подкаталогах.  
		/// Значение по умолчанию — <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
		/// <returns>Перечисляемая коллекция полных имен (включая пути) для файлов в каталоге, указанном в параметре <paramref name="path" />, которые соответствуют указанному шаблону и параметрам поиска.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую недопустимые символы. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> не является допустимым значением <see cref="T:System.IO.SearchOption" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" />: например, он ссылается на несопоставленный диск.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или их комбинация превышает максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006701 RID: 26369 RVA: 0x0015F788 File Offset: 0x0015D988
		public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
		{
			return Directory.EnumerateFiles(path, searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x0015F797 File Offset: 0x0015D997
		public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Files, enumerationOptions);
		}

		/// <summary>Возвращает перечисляемую коллекцию имен файлов и имен каталогов по указанному пути.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <returns>Перечисляемая коллекция записей файловой системы в каталоге, заданном параметром <paramref name="path" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую недопустимые символы. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" />: например, он ссылается на несопоставленный диск.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или их комбинация превышает максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006703 RID: 26371 RVA: 0x0015F7A2 File Offset: 0x0015D9A2
		public static IEnumerable<string> EnumerateFileSystemEntries(string path)
		{
			return Directory.EnumerateFileSystemEntries(path, "*", EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает перечисляемую коллекцию имен файлов и имен каталогов по указанному пути, соответствующих шаблону поиска.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами в записях файловой системы, расположенными по пути <paramref name="path" />.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <returns>Перечисляемая коллекция записей файловой системы в каталоге, заданном параметром <paramref name="path" />, которые соответствуют указанному шаблону поиска.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую недопустимые символы. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" />: например, он ссылается на несопоставленный диск.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или их комбинация превышает максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006704 RID: 26372 RVA: 0x0015F7B4 File Offset: 0x0015D9B4
		public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
		{
			return Directory.EnumerateFileSystemEntries(path, searchPattern, EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает перечисляемую коллекцию записей файловой системы, соответствующих шаблону поиска по указанному пути. Возможно, поиск ведется также и в подкаталогах.</summary>
		/// <param name="path">Относительный или абсолютный путь к каталогу для поиска. В этой строке не учитывается регистр знаков.</param>
		/// <param name="searchPattern">Строка поиска, которая должна сравниваться с записями файловой системы, расположенными по пути <paramref name="path" />.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <param name="searchOption">Одно из значений перечисления, определяющее, следует ли выполнять поиск только в текущем каталоге или также во всех его подкаталогах.  
		/// Значение по умолчанию — <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
		/// <returns>Перечисляемая коллекция записей файловой системы в каталоге, указанном параметром <paramref name="path" />, который соответствует шаблону и параметру поиска.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую недопустимые символы. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="searchPattern" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> не является допустимым значением <see cref="T:System.IO.SearchOption" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" />: например, он ссылается на несопоставленный диск.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> — это имя файла.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или их комбинация превышает максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006705 RID: 26373 RVA: 0x0015F7C2 File Offset: 0x0015D9C2
		public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
		{
			return Directory.EnumerateFileSystemEntries(path, searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x0015F7D1 File Offset: 0x0015D9D1
		public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return Directory.InternalEnumeratePaths(path, searchPattern, SearchTarget.Both, enumerationOptions);
		}

		/// <summary>Возвращает для заданного пути сведения о томе и корневом каталоге по отдельности или сразу.</summary>
		/// <param name="path">Путь к файлу или каталогу.</param>
		/// <returns>Строка, в которой содержатся сведения о томе, корневом каталоге или одновременно сведения и о томе, и о корневом каталоге для заданного пути.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x06006707 RID: 26375 RVA: 0x0015F7DC File Offset: 0x0015D9DC
		public static string GetDirectoryRoot(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			string fullPath = Path.GetFullPath(path);
			return fullPath.Substring(0, PathInternal.GetRootLength(fullPath));
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x0015F810 File Offset: 0x0015DA10
		internal static string InternalGetDirectoryRoot(string path)
		{
			if (path == null)
			{
				return null;
			}
			return path.Substring(0, PathInternal.GetRootLength(path));
		}

		/// <summary>Получает текущий рабочий каталог приложения.</summary>
		/// <returns>Строка, содержащая абсолютный путь к текущей рабочей папке без обратной косой черты (\) в конце.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Операционной системой является Windows CE, которая не поддерживает функциональность текущего каталога.  
		/// Этот метод доступен в .NET Compact Framework, но в настоящее время не поддерживается.</exception>
		// Token: 0x06006709 RID: 26377 RVA: 0x0015F829 File Offset: 0x0015DA29
		public static string GetCurrentDirectory()
		{
			return Environment.CurrentDirectory;
		}

		/// <summary>Устанавливает заданный каталог в качестве текущего рабочего каталога приложения.</summary>
		/// <param name="path">Путь, который должен быть назначен рабочему каталогу.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение для доступа к неуправляемому коду.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный путь не найден.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный каталог не найден.</exception>
		// Token: 0x0600670A RID: 26378 RVA: 0x0015F830 File Offset: 0x0015DA30
		public static void SetCurrentDirectory(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Path cannot be the empty string or all whitespace.", "path");
			}
			Environment.CurrentDirectory = Path.GetFullPath(path);
		}

		/// <summary>Перемещает файл или каталог со всем его содержимым в новое местоположение.</summary>
		/// <param name="sourceDirName">Путь к файлу или каталогу, который необходимо переместить.</param>
		/// <param name="destDirName">Путь к новому местоположению <paramref name="sourceDirName" />. Если <paramref name="sourceDirName" /> является файлом, то параметр <paramref name="destDirName" /> также должен быть именем файла.</param>
		/// <exception cref="T:System.IO.IOException">Была предпринята попытка переместить каталог в другой том.  
		/// -или- 
		///  <paramref name="destDirName" /> уже существует.  
		/// -или- 
		/// Параметры <paramref name="sourceDirName" /> и <paramref name="destDirName" /> указывают на один и тот же файл или каталог.  
		/// -или- 
		/// Каталог или находящийся в нем файл используется другим процессом.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="sourceDirName" /> или <paramref name="destDirName" /> представляет собой строку нулевой длины, строку, содержащую только пробелы, или строку, содержащую один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="sourceDirName" /> или <paramref name="destDirName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, указанный <paramref name="sourceDirName" />, является недопустимым (например, он ведет на несопоставленный диск).</exception>
		// Token: 0x0600670B RID: 26379 RVA: 0x0015F864 File Offset: 0x0015DA64
		public static void Move(string sourceDirName, string destDirName)
		{
			if (sourceDirName == null)
			{
				throw new ArgumentNullException("sourceDirName");
			}
			if (sourceDirName.Length == 0)
			{
				throw new ArgumentException("Empty file name is not legal.", "sourceDirName");
			}
			if (destDirName == null)
			{
				throw new ArgumentNullException("destDirName");
			}
			if (destDirName.Length == 0)
			{
				throw new ArgumentException("Empty file name is not legal.", "destDirName");
			}
			string fullPath = Path.GetFullPath(sourceDirName);
			string text = PathInternal.EnsureTrailingSeparator(fullPath);
			string fullPath2 = Path.GetFullPath(destDirName);
			string text2 = PathInternal.EnsureTrailingSeparator(fullPath2);
			StringComparison stringComparison = PathInternal.StringComparison;
			if (string.Equals(text, text2, stringComparison))
			{
				throw new IOException("Source and destination path must be different.");
			}
			string pathRoot = Path.GetPathRoot(text);
			string pathRoot2 = Path.GetPathRoot(text2);
			if (!string.Equals(pathRoot, pathRoot2, stringComparison))
			{
				throw new IOException("Source and destination path must have identical roots. Move will not work across volumes.");
			}
			if (!FileSystem.DirectoryExists(fullPath) && !FileSystem.FileExists(fullPath))
			{
				throw new DirectoryNotFoundException(SR.Format("Could not find a part of the path '{0}'.", fullPath));
			}
			if (FileSystem.DirectoryExists(fullPath2))
			{
				throw new IOException(SR.Format("Cannot create '{0}' because a file or directory with the same name already exists.", fullPath2));
			}
			FileSystem.MoveDirectory(fullPath, fullPath2);
		}

		/// <summary>Удаляет пустой каталог по заданному пути.</summary>
		/// <param name="path">Имя пустого каталога, который необходимо удалить. Этот каталог должен поддерживать запись и быть пустым.</param>
		/// <exception cref="T:System.IO.IOException">Файл с именем и расположением, заданными параметром <paramref name="path" />, уже существует.  
		/// -или- 
		/// Каталог является текущим рабочим каталогом приложения.  
		/// -или- 
		/// Каталог, заданный параметром <paramref name="path" />, не пустой.  
		/// -или- 
		/// Каталог доступен только для чтения или содержит файл, доступный только для чтения.  
		/// -или- 
		/// Каталог используется другим процессом.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Параметр <paramref name="path" /> не существует или не найден.  
		/// -или- 
		/// Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		// Token: 0x0600670C RID: 26380 RVA: 0x0015F956 File Offset: 0x0015DB56
		public static void Delete(string path)
		{
			FileSystem.RemoveDirectory(Path.GetFullPath(path), false);
		}

		/// <summary>Удаляет заданный каталог и, при наличии соответствующей инструкции, все подкаталоги и файлы в нем.</summary>
		/// <param name="path">Имя каталога, который необходимо удалить.</param>
		/// <param name="recursive">Значение <see langword="true" /> позволяет удалить каталоги, подкаталоги и файлы по заданному <paramref name="path" />, в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.IO.IOException">Файл с именем и расположением, заданными параметром <paramref name="path" />, уже существует.  
		/// -или- 
		/// Каталог, заданный параметром <paramref name="path" />, доступен только для чтения, или <paramref name="recursive" /> имеет значение <see langword="false" /> и <paramref name="path" /> не является пустым каталогом.  
		/// -или- 
		/// Каталог является текущим рабочим каталогом приложения.  
		/// -или- 
		/// Каталог содержит файл только для чтения.  
		/// -или- 
		/// Каталог используется другим процессом.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Параметр <paramref name="path" /> не существует или не найден.  
		/// -или- 
		/// Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		// Token: 0x0600670D RID: 26381 RVA: 0x0015F964 File Offset: 0x0015DB64
		public static void Delete(string path, bool recursive)
		{
			FileSystem.RemoveDirectory(Path.GetFullPath(path), recursive);
		}

		/// <summary>Извлекает имена логических дисков данного компьютера в формате "&lt;буква диска&gt;:\".</summary>
		/// <returns>Логические устройства данного компьютера.</returns>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода (например, ошибка диска).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600670E RID: 26382 RVA: 0x0015F972 File Offset: 0x0015DB72
		public static string[] GetLogicalDrives()
		{
			return FileSystem.GetLogicalDrives();
		}

		/// <summary>Создает все каталоги по указанному пути, если они еще не существуют, с применением заданных параметров безопасности Windows.</summary>
		/// <param name="path">Каталог, который необходимо создать.</param>
		/// <param name="directorySecurity">Элемент управления доступом, который необходимо применить к каталогу.</param>
		/// <returns>Объект, представляющий каталог по указанному пути. Этот объект возвращается вне зависимости от того, существует ли уже каталог по указанному пути.</returns>
		/// <exception cref="T:System.IO.IOException">Каталог, заданный параметром <paramref name="path" />, является файлом.  
		/// -или- 
		/// Имя сети неизвестно.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов. Вы можете запросить недопустимые символы с помощью метода <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
		/// -или- 
		///  <paramref name="path" /> начинается с символа двоеточия (:) или содержит только двоеточие.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> содержит двоеточие (:), которое не является частью метки диска (C:\).</exception>
		// Token: 0x0600670F RID: 26383 RVA: 0x0015F979 File Offset: 0x0015DB79
		public static DirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity)
		{
			return Directory.CreateDirectory(path);
		}

		/// <summary>Получает объект <see cref="T:System.Security.AccessControl.DirectorySecurity" />, который инкапсулирует записи списка управления доступом (ACL) указанного типа для заданного каталога.</summary>
		/// <param name="path">Путь к каталогу, в котором содержится объект <see cref="T:System.Security.AccessControl.DirectorySecurity" />, описывающий сведения о списке управления доступом (ACL) для конкретного файла.</param>
		/// <param name="includeSections">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее тип сведений о списке ACL, которые необходимо получить.</param>
		/// <returns>Объект, который инкапсулирует правила управления доступом для файла, описанные параметром <paramref name="path" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии каталога возникла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows 2000 или более поздней версии.</exception>
		/// <exception cref="T:System.SystemException">Произошла ошибка системного уровня, например невозможно найти каталог. Конкретное исключение может быть подклассом <see cref="T:System.SystemException" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает каталог, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006710 RID: 26384 RVA: 0x0015F981 File Offset: 0x0015DB81
		public static DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
		{
			return new DirectorySecurity(path, includeSections);
		}

		/// <summary>Получает объект <see cref="T:System.Security.AccessControl.DirectorySecurity" />, который инкапсулирует записи списка управления доступом (ACL) для заданного каталога.</summary>
		/// <param name="path">Путь к каталогу, в котором содержится объект <see cref="T:System.Security.AccessControl.DirectorySecurity" />, описывающий сведения о списке управления доступом (ACL) для конкретного файла.</param>
		/// <returns>Объект, который инкапсулирует правила управления доступом для файла, описанные параметром <paramref name="path" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии каталога возникла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows 2000 или более поздней версии.</exception>
		/// <exception cref="T:System.SystemException">Произошла ошибка системного уровня, например невозможно найти каталог. Конкретное исключение может быть подклассом <see cref="T:System.SystemException" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает каталог, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006711 RID: 26385 RVA: 0x0015F98A File Offset: 0x0015DB8A
		public static DirectorySecurity GetAccessControl(string path)
		{
			return Directory.GetAccessControl(path, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
		}

		/// <summary>Применяет к заданному каталогу записи списка управления доступом (ACL), описанные объектом <see cref="T:System.Security.AccessControl.DirectorySecurity" />.</summary>
		/// <param name="path">Каталог, в который необходимо добавить или из которого нужно удалить записи списка управления доступом.</param>
		/// <param name="directorySecurity">Объект <see cref="T:System.Security.AccessControl.DirectorySecurity" />, описывающий запись ACL, которую требуется применить к каталогу, описанному параметром <paramref name="path" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="directorySecurity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Не удается найти каталог.</exception>
		/// <exception cref="T:System.ArgumentException">Задан недопустимый <paramref name="path" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Текущий процесс не может получить доступ к каталогу, заданному <paramref name="path" />.  
		/// -или- 
		/// Текущий процесс не имеет необходимых прав для задания записи ACL.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows 2000 или более поздней версии.</exception>
		// Token: 0x06006712 RID: 26386 RVA: 0x0015F994 File Offset: 0x0015DB94
		public static void SetAccessControl(string path, DirectorySecurity directorySecurity)
		{
			if (directorySecurity == null)
			{
				throw new ArgumentNullException("directorySecurity");
			}
			string fullPath = Path.GetFullPath(path);
			directorySecurity.PersistModifications(fullPath);
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x0015F9C0 File Offset: 0x0015DBC0
		internal static string InsecureGetCurrentDirectory()
		{
			MonoIOError monoIOError;
			string currentDirectory = MonoIO.GetCurrentDirectory(out monoIOError);
			if (monoIOError != MonoIOError.ERROR_SUCCESS)
			{
				throw MonoIO.GetException(monoIOError);
			}
			return currentDirectory;
		}

		// Token: 0x06006714 RID: 26388 RVA: 0x0015F9E0 File Offset: 0x0015DBE0
		internal static void InsecureSetCurrentDirectory(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Trim().Length == 0)
			{
				throw new ArgumentException("path string must not be an empty string or whitespace string");
			}
			if (!Directory.Exists(path))
			{
				throw new DirectoryNotFoundException("Directory \"" + path + "\" not found.");
			}
			MonoIOError monoIOError;
			MonoIO.SetCurrentDirectory(path, out monoIOError);
			if (monoIOError != MonoIOError.ERROR_SUCCESS)
			{
				throw MonoIO.GetException(path, monoIOError);
			}
		}
	}
}
