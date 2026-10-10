using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Предоставляет статические методы для создания, копирования, удаления, перемещения и открытия одного файла, а также помогает при создании объектов <see cref="T:System.IO.FileStream" />.</summary>
	// Token: 0x02000B31 RID: 2865
	public static class File
	{
		/// <summary>Открывает для чтения существующий файл, содержащий текст в кодировке UTF-8.</summary>
		/// <param name="path">Файл, открываемый для чтения.</param>
		/// <returns>
		///   <see cref="T:System.IO.StreamReader" /> в заданном пути.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06006752 RID: 26450 RVA: 0x001600B4 File Offset: 0x0015E2B4
		public static StreamReader OpenText(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			return new StreamReader(path);
		}

		/// <summary>Создается или открывается файл для записи текста в кодировке UTF-8. Если файл уже существует, его содержимое перезаписывается.</summary>
		/// <param name="path">Файл, который нужно открыть для записи.</param>
		/// <returns>
		///   <see cref="T:System.IO.StreamWriter" />, выполняющий запись в указанный файл в кодировке UTF-8.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06006753 RID: 26451 RVA: 0x001600CA File Offset: 0x0015E2CA
		public static StreamWriter CreateText(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			return new StreamWriter(path, false);
		}

		/// <summary>Создает объект <see cref="T:System.IO.StreamWriter" />, добавляющий текст с кодировкой UTF-8 в существующий файл, или в новый файл, если указанный файл не существует.</summary>
		/// <param name="path">Путь к файлу, в который производится добавление.</param>
		/// <returns>Модуль записи потока, который добавляет текст в кодировке UTF-8 в указанный файл или новый файл.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный путь является недопустимым (например, каталог не существует или находится на несопоставленном диске).</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06006754 RID: 26452 RVA: 0x001600E1 File Offset: 0x0015E2E1
		public static StreamWriter AppendText(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			return new StreamWriter(path, true);
		}

		/// <summary>Копирует существующий файл в новый файл. Перезапись файла с тем же именем не разрешена.</summary>
		/// <param name="sourceFileName">Копируемый файл.</param>
		/// <param name="destFileName">Имя конечного файла. Это не может быть имя каталога или имя существующего файла.</param>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="sourceFileName" /> или <paramref name="destFileName" /> представляет собой строку нулевой длины, содержащую только пробелы или содержащую один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.  
		///
		/// или - 
		/// Параметр <paramref name="sourceFileName" /> или <paramref name="destFileName" /> определяет каталог.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceFileName" /> или <paramref name="destFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">В <paramref name="sourceFileName" /> или <paramref name="destFileName" /> указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="sourceFileName" />.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="destFileName" /> существует.  
		///
		/// или - 
		/// Произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="sourceFileName" /> или <paramref name="destFileName" /> имеет недопустимый формат.</exception>
		// Token: 0x06006755 RID: 26453 RVA: 0x001600F8 File Offset: 0x0015E2F8
		public static void Copy(string sourceFileName, string destFileName)
		{
			File.Copy(sourceFileName, destFileName, false);
		}

		/// <summary>Копирует существующий файл в новый файл. Перезапись файла с тем же именем разрешена.</summary>
		/// <param name="sourceFileName">Копируемый файл.</param>
		/// <param name="destFileName">Имя конечного файла. Это не может быть имя каталога.</param>
		/// <param name="overwrite">
		///   <see langword="true" />, если конечный файл можно перезаписать; в противном случае — <see langword="false" />.</param>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.  
		/// -или- 
		///  Объект <paramref name="destFileName" /> доступен только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="sourceFileName" /> или <paramref name="destFileName" /> представляет собой строку нулевой длины, строку, содержащую только пробелы, или строку, содержащую один или несколько недопустимых символов, определенных методом <see cref="F:System.IO.Path.InvalidPathChars" />.  
		///
		/// или - 
		/// Параметр <paramref name="sourceFileName" /> или <paramref name="destFileName" /> определяет каталог.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceFileName" /> или <paramref name="destFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">В <paramref name="sourceFileName" /> или <paramref name="destFileName" /> указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="sourceFileName" />.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="destFileName" /> существует, и <paramref name="overwrite" /> равно <see langword="false" />.  
		/// -или- 
		/// Произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="sourceFileName" /> или <paramref name="destFileName" /> имеет недопустимый формат.</exception>
		// Token: 0x06006756 RID: 26454 RVA: 0x00160104 File Offset: 0x0015E304
		public static void Copy(string sourceFileName, string destFileName, bool overwrite)
		{
			if (sourceFileName == null)
			{
				throw new ArgumentNullException("sourceFileName", "File name cannot be null.");
			}
			if (destFileName == null)
			{
				throw new ArgumentNullException("destFileName", "File name cannot be null.");
			}
			if (sourceFileName.Length == 0)
			{
				throw new ArgumentException("Empty file name is not legal.", "sourceFileName");
			}
			if (destFileName.Length == 0)
			{
				throw new ArgumentException("Empty file name is not legal.", "destFileName");
			}
			FileSystem.CopyFile(Path.GetFullPath(sourceFileName), Path.GetFullPath(destFileName), overwrite);
		}

		/// <summary>Создает или перезаписывает файл в указанном пути.</summary>
		/// <param name="path">Путь и имя создаваемого файла.</param>
		/// <returns>
		///   <see cref="T:System.IO.FileStream" />, обеспечивающий доступ для чтения и записи к файлу, указанному в <paramref name="path" />.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.  
		/// -или- 
		///  Параметр <paramref name="path" /> указывает файл, доступный только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода при создании файла.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06006757 RID: 26455 RVA: 0x00160179 File Offset: 0x0015E379
		public static FileStream Create(string path)
		{
			return File.Create(path, 4096);
		}

		/// <summary>Создает или перезаписывает указанный файл.</summary>
		/// <param name="path">Имя файла</param>
		/// <param name="bufferSize">Число байтов, буферизируемых при чтении и записи в данный файл.</param>
		/// <returns>
		///   <see cref="T:System.IO.FileStream" /> с заданным размером буфера, который обеспечивает доступ для чтения и записи к файлу, указанному в <paramref name="path" />.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.  
		///
		/// или - 
		/// Параметр <paramref name="path" /> указывает файл, доступный только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода при создании файла.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06006758 RID: 26456 RVA: 0x00160186 File Offset: 0x0015E386
		public static FileStream Create(string path, int bufferSize)
		{
			return new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize);
		}

		/// <summary>Создает или перезаписывает указанный файл, определяя размер буфера и значение <see cref="T:System.IO.FileOptions" />, которое описывает, как создавать или перезаписывать файл.</summary>
		/// <param name="path">Имя файла</param>
		/// <param name="bufferSize">Число байтов, буферизируемых при чтении и записи в данный файл.</param>
		/// <param name="options">Одно из значений <see cref="T:System.IO.FileOptions" />, которое описывает, как создавать или перезаписывать файл.</param>
		/// <returns>Новый файл с заданным размером буфера.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.  
		/// -или- 
		///  Параметр <paramref name="path" /> указывает файл, доступный только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода при создании файла.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06006759 RID: 26457 RVA: 0x00160192 File Offset: 0x0015E392
		public static FileStream Create(string path, int bufferSize, FileOptions options)
		{
			return new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, options);
		}

		/// <summary>Удаляет указанный файл.</summary>
		/// <param name="path">Имя файла, предназначенного для удаления. Знаки подстановки не поддерживаются.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Указанный файл используется.  
		/// -или- 
		/// Для файла имеется открытый дескриптор, а операционной системой является Windows XP или более ранней версии. Этот открытый дескриптор может быть результатом перечисления каталогов и файлов. Дополнительные сведения см. в разделе Как перечислить каталоги и файлы.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.  
		///
		/// или - 
		/// Файл является исполняемым файлом, который уже используется.  
		///
		/// -или- 
		///  <paramref name="path" /> является каталогом.  
		/// -или- 
		///  Параметр <paramref name="path" /> указывает файл только для чтения.</exception>
		// Token: 0x0600675A RID: 26458 RVA: 0x0016019F File Offset: 0x0015E39F
		public static void Delete(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			FileSystem.DeleteFile(Path.GetFullPath(path));
		}

		/// <summary>Определяет, существует ли заданный файл.</summary>
		/// <param name="path">Проверяемый файл.</param>
		/// <returns>Значение <see langword="true" />, если вызывающий оператор имеет требуемые разрешения и <paramref name="path" /> содержит имя существующего файла; в противном случае — <see langword="false" />. Этот метод также возвращает <see langword="false" />, если <paramref name="path" /> — <see langword="null" />, недействительный путь или строка нулевой длины. Если у вызывающего оператора нет достаточных полномочий на чтение заданного файла, исключения не создаются, а данный метод возвращает <see langword="false" /> вне зависимости от существования <paramref name="path" />.</returns>
		// Token: 0x0600675B RID: 26459 RVA: 0x001601BC File Offset: 0x0015E3BC
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
				path = Path.GetFullPath(path);
				if (path.Length > 0 && PathInternal.IsDirectorySeparator(path[path.Length - 1]))
				{
					return false;
				}
				return FileSystem.FileExists(path);
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

		/// <summary>Открывает объект <see cref="T:System.IO.FileStream" /> по указанному пути с доступом для чтения и записи без совместного доступа.</summary>
		/// <param name="path">Открываемый файл.</param>
		/// <param name="mode">Значение <see cref="T:System.IO.FileMode" /> указывает, нужно ли создавать файл, если он не существует, и определяет, будет ли содержимое существующих файлов сохранено или перезаписано.</param>
		/// <returns>Поток <see cref="T:System.IO.FileStream" />, открытый в указанном режиме и по указанному пути с доступом для чтения и записи и без предоставления общего доступа.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> определяет каталог.  
		///
		/// или - 
		/// У вызывающего объекта отсутствует необходимое разрешение.  
		///
		/// -или- 
		///  <paramref name="mode" /> имеет значение <see cref="F:System.IO.FileMode.Create" />, а указанный файл является скрытым.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="mode" /> задает недопустимое значение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x0600675C RID: 26460 RVA: 0x00160244 File Offset: 0x0015E444
		public static FileStream Open(string path, FileMode mode)
		{
			return File.Open(path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.None);
		}

		/// <summary>Открывает <see cref="T:System.IO.FileStream" /> в заданном пути с заданным режимом и доступом без совместного доступа.</summary>
		/// <param name="path">Открываемый файл.</param>
		/// <param name="mode">Значение <see cref="T:System.IO.FileMode" /> указывает, нужно ли создавать файл, если он не существует, и определяет, будет ли содержимое существующих файлов сохранено или перезаписано.</param>
		/// <param name="access">Значение <see cref="T:System.IO.FileAccess" />, описывающее операции, которые можно выполнять с файлом.</param>
		/// <returns>Объект с монопольным доступом <see cref="T:System.IO.FileStream" />, обеспечивающий доступ к указанному файлу с заданным режимом и доступом.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.  
		///
		/// или - 
		/// <paramref name="access" /> указывает <see langword="Read" />, и <paramref name="mode" /> указывает <see langword="Create" />, <see langword="CreateNew" />, <see langword="Truncate" /> или <see langword="Append" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///   <paramref name="path" /> указывает файл, доступный только для чтения, а параметр <paramref name="access" /> не равен <see langword="Read" />.  
		///
		/// или - 
		/// <paramref name="path" /> определяет каталог.  
		///
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.  
		///
		/// или - 
		/// <paramref name="mode" /> имеет значение <see cref="F:System.IO.FileMode.Create" />, а указанный файл является скрытым.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="mode" /> или <paramref name="access" /> задает недопустимое значение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x0600675D RID: 26461 RVA: 0x00160256 File Offset: 0x0015E456
		public static FileStream Open(string path, FileMode mode, FileAccess access)
		{
			return File.Open(path, mode, access, FileShare.None);
		}

		/// <summary>Открывает <see cref="T:System.IO.FileStream" /> в заданном пути, с заданным режимом доступа для чтения, записи или чтения и записи и с заданным параметром совместного использования.</summary>
		/// <param name="path">Открываемый файл.</param>
		/// <param name="mode">Значение <see cref="T:System.IO.FileMode" /> указывает, нужно ли создавать файл, если он не существует, и определяет, будет ли содержимое существующих файлов сохранено или перезаписано.</param>
		/// <param name="access">Значение <see cref="T:System.IO.FileAccess" />, описывающее операции, которые можно выполнять с файлом.</param>
		/// <param name="share">Значение <see cref="T:System.IO.FileShare" />, задающее тип доступа к файлу других потоков.</param>
		/// <returns>Поток <see cref="T:System.IO.FileStream" /> по указанному пути с указанным режимом доступа для чтения, записи или чтения и записи и с указанным параметром совместного доступа.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.  
		/// -или- 
		///  <paramref name="access" /> указывает <see langword="Read" />, и <paramref name="mode" /> указывает <see langword="Create" />, <see langword="CreateNew" />, <see langword="Truncate" /> или <see langword="Append" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///   <paramref name="path" /> указывает файл, доступный только для чтения, а параметр <paramref name="access" /> не равен <see langword="Read" />.  
		/// -или- 
		///  <paramref name="path" /> определяет каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.  
		/// -или- 
		///  <paramref name="mode" /> имеет значение <see cref="F:System.IO.FileMode.Create" />, а указанный файл является скрытым.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="mode" />, <paramref name="access" /> или <paramref name="share" /> задает недопустимое значение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x0600675E RID: 26462 RVA: 0x00160261 File Offset: 0x0015E461
		public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			return new FileStream(path, mode, access, share);
		}

		// Token: 0x0600675F RID: 26463 RVA: 0x0016026C File Offset: 0x0015E46C
		internal static DateTimeOffset GetUtcDateTimeOffset(DateTime dateTime)
		{
			if (dateTime.Kind == DateTimeKind.Unspecified)
			{
				return DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
			}
			return dateTime.ToUniversalTime();
		}

		/// <summary>Устанавливает дату и время создания файла.</summary>
		/// <param name="path">Файл, для которого задаются сведения о дате и времени создания.</param>
		/// <param name="creationTime">Объект <see cref="T:System.DateTime" />, содержащий значение, которое должно быть задано для даты и времени создания <paramref name="path" />. Значение представляется в формате местного времени.</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный путь не найден.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.IOException">При выполнении операции произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="creationTime" /> указывает значение вне диапазона дат или времени, разрешенного для этой операции.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06006760 RID: 26464 RVA: 0x00160290 File Offset: 0x0015E490
		public static void SetCreationTime(string path, DateTime creationTime)
		{
			FileSystem.SetCreationTime(Path.GetFullPath(path), creationTime, false);
		}

		/// <summary>Устанавливает дату и время создания файла, представленные в формате общего скоординированного времени (UTC).</summary>
		/// <param name="path">Файл, для которого задаются сведения о дате и времени создания.</param>
		/// <param name="creationTimeUtc">Объект <see cref="T:System.DateTime" />, содержащий значение, которое должно быть задано для даты и времени создания <paramref name="path" />. Значение выражено в формате всемирного координированного времени (UTC).</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный путь не найден.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.IOException">При выполнении операции произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="creationTime" /> указывает значение вне диапазона дат или времени, разрешенного для этой операции.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06006761 RID: 26465 RVA: 0x001602A4 File Offset: 0x0015E4A4
		public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
		{
			FileSystem.SetCreationTime(Path.GetFullPath(path), File.GetUtcDateTimeOffset(creationTimeUtc), false);
		}

		/// <summary>Возвращает дату и время создания заданного файла или каталога.</summary>
		/// <param name="path">Файл или каталог, для которого получены сведения о дате и времени создания.</param>
		/// <returns>Структура <see cref="T:System.DateTime" />, для которой заданы дата и время создания указанного файла или каталога. Значение представляется в формате местного времени.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06006762 RID: 26466 RVA: 0x001602B8 File Offset: 0x0015E4B8
		public static DateTime GetCreationTime(string path)
		{
			return FileSystem.GetCreationTime(Path.GetFullPath(path)).LocalDateTime;
		}

		/// <summary>Возвращает дату и время создания заданного файла или каталога в формате общего скоординированного времени (UTC).</summary>
		/// <param name="path">Файл или каталог, для которого получены сведения о дате и времени создания.</param>
		/// <returns>Структура <see cref="T:System.DateTime" />, для которой заданы дата и время создания указанного файла или каталога. Значение выражено в формате всемирного координированного времени (UTC).</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06006763 RID: 26467 RVA: 0x001602D8 File Offset: 0x0015E4D8
		public static DateTime GetCreationTimeUtc(string path)
		{
			return FileSystem.GetCreationTime(Path.GetFullPath(path)).UtcDateTime;
		}

		/// <summary>Устанавливаются дата и время последнего доступа к заданному файлу.</summary>
		/// <param name="path">Файл, для которого устанавливаются сведения о дате и времени доступа.</param>
		/// <param name="lastAccessTime">Объект <see cref="T:System.DateTime" />, содержащий значение, которое должно быть задано для даты и времени последнего доступа к <paramref name="path" />. Значение представляется в формате местного времени.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный путь не найден.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="lastAccessTime" /> указывает значение, выходящее за диапазон дат или времени, разрешенных для этой операции.</exception>
		// Token: 0x06006764 RID: 26468 RVA: 0x001602F8 File Offset: 0x0015E4F8
		public static void SetLastAccessTime(string path, DateTime lastAccessTime)
		{
			FileSystem.SetLastAccessTime(Path.GetFullPath(path), lastAccessTime, false);
		}

		/// <summary>Устанавливает дату и время последнего доступа к заданному файлу в формате всемирного координированного времени (UTC).</summary>
		/// <param name="path">Файл, для которого устанавливаются сведения о дате и времени доступа.</param>
		/// <param name="lastAccessTimeUtc">Объект <see cref="T:System.DateTime" />, содержащий значение, которое должно быть задано для даты и времени последнего доступа к <paramref name="path" />. Значение выражено в формате всемирного координированного времени (UTC).</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный путь не найден.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="lastAccessTimeUtc" /> указывает значение, выходящее за диапазон дат или времени, разрешенных для этой операции.</exception>
		// Token: 0x06006765 RID: 26469 RVA: 0x0016030C File Offset: 0x0015E50C
		public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
		{
			FileSystem.SetLastAccessTime(Path.GetFullPath(path), File.GetUtcDateTimeOffset(lastAccessTimeUtc), false);
		}

		/// <summary>Возвращает время и дату последнего обращения к указанному файлу или каталогу.</summary>
		/// <param name="path">Файл или каталог, информацию о дате и времени обращения к которому следует получить.</param>
		/// <returns>Структура <see cref="T:System.DateTime" />, для которой заданы дата и время последнего доступа к указанному файлу или каталогу. Значение представляется в формате местного времени.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06006766 RID: 26470 RVA: 0x00160320 File Offset: 0x0015E520
		public static DateTime GetLastAccessTime(string path)
		{
			return FileSystem.GetLastAccessTime(Path.GetFullPath(path)).LocalDateTime;
		}

		/// <summary>Возвращает дату и время последнего доступа к заданному файлу или каталогу в формате всемирного координированного времени (UTC).</summary>
		/// <param name="path">Файл или каталог, информацию о дате и времени обращения к которому следует получить.</param>
		/// <returns>Структура <see cref="T:System.DateTime" />, для которой заданы дата и время последнего доступа к указанному файлу или каталогу. Значение выражено в формате всемирного координированного времени (UTC).</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x06006767 RID: 26471 RVA: 0x00160340 File Offset: 0x0015E540
		public static DateTime GetLastAccessTimeUtc(string path)
		{
			return FileSystem.GetLastAccessTime(Path.GetFullPath(path)).UtcDateTime;
		}

		/// <summary>Устанавливаются дата и время последней операции записи в заданный файл.</summary>
		/// <param name="path">Файл, для которого устанавливаются сведения о дате и времени.</param>
		/// <param name="lastWriteTime">Объект <see cref="T:System.DateTime" />, содержащий значение, которое должно быть задано для даты и времени последней записи <paramref name="path" />. Значение представляется в формате местного времени.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный путь не найден.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="lastWriteTime" /> указывает значение, выходящее за диапазон дат или времени, разрешенных для этой операции.</exception>
		// Token: 0x06006768 RID: 26472 RVA: 0x00160360 File Offset: 0x0015E560
		public static void SetLastWriteTime(string path, DateTime lastWriteTime)
		{
			FileSystem.SetLastWriteTime(Path.GetFullPath(path), lastWriteTime, false);
		}

		/// <summary>Устанавливает дату и время последней операции записи в заданный файл в формате всемирного координированного времени (UTC).</summary>
		/// <param name="path">Файл, для которого устанавливаются сведения о дате и времени.</param>
		/// <param name="lastWriteTimeUtc">Объект <see cref="T:System.DateTime" />, содержащий значение, которое должно быть задано для даты и времени последней записи <paramref name="path" />. Значение выражено в формате всемирного координированного времени (UTC).</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный путь не найден.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="lastWriteTimeUtc" /> указывает значение, выходящее за диапазон дат или времени, разрешенных для этой операции.</exception>
		// Token: 0x06006769 RID: 26473 RVA: 0x00160374 File Offset: 0x0015E574
		public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
		{
			FileSystem.SetLastWriteTime(Path.GetFullPath(path), File.GetUtcDateTimeOffset(lastWriteTimeUtc), false);
		}

		/// <summary>Возвращает время и дату последней операции записи в указанный файл или каталог.</summary>
		/// <param name="path">Файл или каталог, для которого должны быть получены сведения о дате и времени записи.</param>
		/// <returns>Структура <see cref="T:System.DateTime" />, для которой заданы дата и время последней операции записи в указанный файл или каталог. Значение представляется в формате местного времени.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x0600676A RID: 26474 RVA: 0x00160388 File Offset: 0x0015E588
		public static DateTime GetLastWriteTime(string path)
		{
			return FileSystem.GetLastWriteTime(Path.GetFullPath(path)).LocalDateTime;
		}

		/// <summary>Возвращает дату и время последней операции записи в заданный файл или каталог в формате всемирного координированного времени (UTC).</summary>
		/// <param name="path">Файл или каталог, для которого должны быть получены сведения о дате и времени записи.</param>
		/// <returns>Структура <see cref="T:System.DateTime" />, для которой заданы дата и время последней операции записи в указанный файл или каталог. Значение выражено в формате всемирного координированного времени (UTC).</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x0600676B RID: 26475 RVA: 0x001603A8 File Offset: 0x0015E5A8
		public static DateTime GetLastWriteTimeUtc(string path)
		{
			return FileSystem.GetLastWriteTime(Path.GetFullPath(path)).UtcDateTime;
		}

		/// <summary>Получает значение <see cref="T:System.IO.FileAttributes" /> для файла в пути.</summary>
		/// <param name="path">Путь к файлу.</param>
		/// <returns>Значение <see cref="T:System.IO.FileAttributes" /> для файла в пути.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> является пустой строкой, содержит только пробелы или недопустимые символы.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="path" /> представляет файл и является недопустимым, например указывает на несопоставленный диск, или же невозможно найти файл.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///   <paramref name="path" /> представляет каталог и является недопустимым, например указывает на несопоставленный диск, или же невозможно найти каталог.</exception>
		/// <exception cref="T:System.IO.IOException">Этот файл используется другим процессом.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600676C RID: 26476 RVA: 0x001603C8 File Offset: 0x0015E5C8
		public static FileAttributes GetAttributes(string path)
		{
			return FileSystem.GetAttributes(Path.GetFullPath(path));
		}

		/// <summary>Устанавливает заданные атрибуты <see cref="T:System.IO.FileAttributes" /> файла по заданному пути.</summary>
		/// <param name="path">Путь к файлу.</param>
		/// <param name="fileAttributes">Побитовое сочетание значений перечисления.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> является пустым, содержит только пробелы, содержит недопустимые символы, или же атрибут файла недействителен.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> определяет каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600676D RID: 26477 RVA: 0x001603D8 File Offset: 0x0015E5D8
		public static void SetAttributes(string path, FileAttributes fileAttributes)
		{
			if ((fileAttributes & (FileAttributes)(-2147483648)) == (FileAttributes)0)
			{
				FileSystem.SetAttributes(Path.GetFullPath(path), fileAttributes);
				return;
			}
			Path.Validate(path);
			MonoIOError error;
			if (!MonoIO.SetFileAttributes(path, fileAttributes, out error))
			{
				throw MonoIO.GetException(path, error);
			}
		}

		/// <summary>Открывает для чтения существующий файл.</summary>
		/// <param name="path">Файл, открываемый для чтения.</param>
		/// <returns>Доступный только для чтения <see cref="T:System.IO.FileStream" /> в заданном пути.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> определяет каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		// Token: 0x0600676E RID: 26478 RVA: 0x00160414 File Offset: 0x0015E614
		public static FileStream OpenRead(string path)
		{
			return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
		}

		/// <summary>Открывает существующий файл или создает новый файл для записи.</summary>
		/// <param name="path">Файл, который нужно открыть для записи.</param>
		/// <returns>Объект с монопольным доступом <see cref="T:System.IO.FileStream" /> в заданном пути с доступом <see cref="F:System.IO.FileAccess.Write" />.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.  
		/// -или- 
		///  Параметр <paramref name="path" /> указывает файл или каталог только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x0600676F RID: 26479 RVA: 0x0016041F File Offset: 0x0015E61F
		public static FileStream OpenWrite(string path)
		{
			return new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
		}

		/// <summary>Открывает текстовый файл, считывает весь текст файла и затем закрывает файл.</summary>
		/// <param name="path">Файл, открываемый для чтения.</param>
		/// <returns>Строка, содержащая весь текст файла.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> определяет каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006770 RID: 26480 RVA: 0x0016042A File Offset: 0x0015E62A
		public static string ReadAllText(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			return File.InternalReadAllText(path, Encoding.UTF8);
		}

		/// <summary>Открывает файл, считывает весь текст файла с заданной кодировкой и затем закрывает файл.</summary>
		/// <param name="path">Файл, открываемый для чтения.</param>
		/// <param name="encoding">Кодировка, примененная к содержимому файла.</param>
		/// <returns>Строка, содержащая весь текст файла.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> определяет каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006771 RID: 26481 RVA: 0x0016045D File Offset: 0x0015E65D
		public static string ReadAllText(string path, Encoding encoding)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			return File.InternalReadAllText(path, encoding);
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x0016049C File Offset: 0x0015E69C
		private static string InternalReadAllText(string path, Encoding encoding)
		{
			string result;
			using (StreamReader streamReader = new StreamReader(path, encoding, true))
			{
				result = streamReader.ReadToEnd();
			}
			return result;
		}

		/// <summary>Создает новый файл, записывает в него указанную строку и затем закрывает файл. Если целевой файл уже существует, он будет переопределен.</summary>
		/// <param name="path">Файл, в который осуществляется запись.</param>
		/// <param name="contents">Строка, которую нужно записать в файл.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> равняется <see langword="null" />, или <paramref name="contents" /> является пустым.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		///
		/// или - 
		/// <paramref name="path" /> определяет каталог.  
		///
		/// или - 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006773 RID: 26483 RVA: 0x001604D8 File Offset: 0x0015E6D8
		public static void WriteAllText(string path, string contents)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			using (StreamWriter streamWriter = new StreamWriter(path))
			{
				streamWriter.Write(contents);
			}
		}

		/// <summary>Создает новый файл, записывает указанную строку в этот файл, используя заданную кодировку, и затем закрывает файл. Если целевой файл уже существует, он будет переопределен.</summary>
		/// <param name="path">Файл, в который осуществляется запись.</param>
		/// <param name="contents">Строка, которую нужно записать в файл.</param>
		/// <param name="encoding">Кодировка, которую необходимо применить к строке.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> равняется <see langword="null" />, или <paramref name="contents" /> является пустым.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		///
		/// или - 
		/// <paramref name="path" /> определяет каталог.  
		///
		/// или - 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006774 RID: 26484 RVA: 0x00160538 File Offset: 0x0015E738
		public static void WriteAllText(string path, string contents, Encoding encoding)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			using (StreamWriter streamWriter = new StreamWriter(path, false, encoding))
			{
				streamWriter.Write(contents);
			}
		}

		/// <summary>Открывает двоичный файл, считывает содержимое файла в массив байтов и затем закрывает файл.</summary>
		/// <param name="path">Файл, открываемый для чтения.</param>
		/// <returns>Массив байтов с содержимым файла.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> определяет каталог.  
		///
		/// или - 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006775 RID: 26485 RVA: 0x001605A8 File Offset: 0x0015E7A8
		public static byte[] ReadAllBytes(string path)
		{
			byte[] result;
			using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 1))
			{
				long length = fileStream.Length;
				if (length > 2147483647L)
				{
					throw new IOException("The file is too long. This operation is currently limited to supporting files less than 2 gigabytes in size.");
				}
				if (length == 0L)
				{
					result = File.ReadAllBytesUnknownLength(fileStream);
				}
				else
				{
					int num = 0;
					int i = (int)length;
					byte[] array = new byte[i];
					while (i > 0)
					{
						int num2 = fileStream.Read(array, num, i);
						if (num2 == 0)
						{
							throw Error.GetEndOfFile();
						}
						num += num2;
						i -= num2;
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x00160640 File Offset: 0x0015E840
		private unsafe static byte[] ReadAllBytesUnknownLength(FileStream fs)
		{
			byte[] array = null;
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)512], 512);
			byte[] result;
			try
			{
				int num = 0;
				for (;;)
				{
					if (num == span.Length)
					{
						uint num2 = (uint)(span.Length * 2);
						if (num2 > 2147483591U)
						{
							num2 = (uint)Math.Max(2147483591, span.Length + 1);
						}
						byte[] array2 = ArrayPool<byte>.Shared.Rent((int)num2);
						span.CopyTo(array2);
						if (array != null)
						{
							ArrayPool<byte>.Shared.Return(array, false);
						}
						span = (array = array2);
					}
					int num3 = fs.Read(span.Slice(num));
					if (num3 == 0)
					{
						break;
					}
					num += num3;
				}
				result = span.Slice(0, num).ToArray();
			}
			finally
			{
				if (array != null)
				{
					ArrayPool<byte>.Shared.Return(array, false);
				}
			}
			return result;
		}

		/// <summary>Создает новый файл, записывает в него указанный массив байтов и затем закрывает файл. Если целевой файл уже существует, он будет переопределен.</summary>
		/// <param name="path">Файл, в который осуществляется запись.</param>
		/// <param name="bytes">Байты, которые нужно записать в файл.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> имеет значение <see langword="null" />, или массив байтов является пустым.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> определяет каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006777 RID: 26487 RVA: 0x00160720 File Offset: 0x0015E920
		public static void WriteAllBytes(string path, byte[] bytes)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path", "Path cannot be null.");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes");
			}
			File.InternalWriteAllBytes(path, bytes);
		}

		// Token: 0x06006778 RID: 26488 RVA: 0x00160770 File Offset: 0x0015E970
		private static void InternalWriteAllBytes(string path, byte[] bytes)
		{
			using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read))
			{
				fileStream.Write(bytes, 0, bytes.Length);
			}
		}

		/// <summary>Открывает текстовый файл, считывает все строки файла и затем закрывает файл.</summary>
		/// <param name="path">Файл, открываемый для чтения.</param>
		/// <returns>Массив строк, содержащий все строки файла.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		///
		/// или - 
		/// <paramref name="path" /> определяет каталог.  
		///
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006779 RID: 26489 RVA: 0x001607B0 File Offset: 0x0015E9B0
		public static string[] ReadAllLines(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			return File.InternalReadAllLines(path, Encoding.UTF8);
		}

		/// <summary>Открывает файл, считывает все строки файла с заданной кодировкой и затем закрывает файл.</summary>
		/// <param name="path">Файл, открываемый для чтения.</param>
		/// <param name="encoding">Кодировка, примененная к содержимому файла.</param>
		/// <returns>Массив строк, содержащий все строки файла.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> определяет каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600677A RID: 26490 RVA: 0x001607E3 File Offset: 0x0015E9E3
		public static string[] ReadAllLines(string path, Encoding encoding)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			return File.InternalReadAllLines(path, encoding);
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x00160820 File Offset: 0x0015EA20
		private static string[] InternalReadAllLines(string path, Encoding encoding)
		{
			List<string> list = new List<string>();
			using (StreamReader streamReader = new StreamReader(path, encoding))
			{
				string item;
				while ((item = streamReader.ReadLine()) != null)
				{
					list.Add(item);
				}
			}
			return list.ToArray();
		}

		/// <summary>Считывает строки файла.</summary>
		/// <param name="path">Файл, который нужно прочитать.</param>
		/// <returns>Все строки файла или строки, которые являются результатом запроса.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> является пустой строкой, содержит только пробел либо один или несколько недопустимых символов, определенных методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" /> (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не обнаружен.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина параметра <paramref name="path" /> превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> является каталогом.  
		///
		/// или - 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600677C RID: 26492 RVA: 0x00160870 File Offset: 0x0015EA70
		public static IEnumerable<string> ReadLines(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			return ReadLinesIterator.CreateIterator(path, Encoding.UTF8);
		}

		/// <summary>Считывает строки файла с заданной кодировкой.</summary>
		/// <param name="path">Файл, который нужно прочитать.</param>
		/// <param name="encoding">Кодировка, примененная к содержимому файла.</param>
		/// <returns>Все строки файла или строки, которые являются результатом запроса.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или содержащую хотя бы один недопустимый символ, заданный методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" /> (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не обнаружен.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина параметра <paramref name="path" /> превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		///
		/// или - 
		/// <paramref name="path" /> является каталогом.  
		///
		/// или - 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600677D RID: 26493 RVA: 0x001608A3 File Offset: 0x0015EAA3
		public static IEnumerable<string> ReadLines(string path, Encoding encoding)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			return ReadLinesIterator.CreateIterator(path, encoding);
		}

		/// <summary>Создает новый файл, записывает в него указанный массив строк и затем закрывает файл.</summary>
		/// <param name="path">Файл, в который осуществляется запись.</param>
		/// <param name="contents">Массив строк, который нужно записать в файл.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Либо <paramref name="path" />, либо <paramref name="contents" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> определяет каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600677E RID: 26494 RVA: 0x001608E0 File Offset: 0x0015EAE0
		public static void WriteAllLines(string path, string[] contents)
		{
			File.WriteAllLines(path, contents);
		}

		/// <summary>Создает новый файл, записывает в него коллекцию строк, затем закрывает файл.</summary>
		/// <param name="path">Файл, в который осуществляется запись.</param>
		/// <param name="contents">Строки, записываемые в файл.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> является пустой строкой, содержит только пробел либо один или несколько недопустимых символов, определенных методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Либо <paramref name="path" />, либо <paramref name="contents" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" /> (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина параметра <paramref name="path" /> превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		///
		/// или - 
		/// Эта операция не поддерживается на текущей платформе.  
		///
		/// или - 
		/// <paramref name="path" /> является каталогом.  
		///
		///
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600677F RID: 26495 RVA: 0x001608EC File Offset: 0x0015EAEC
		public static void WriteAllLines(string path, IEnumerable<string> contents)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (contents == null)
			{
				throw new ArgumentNullException("contents");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			File.InternalWriteAllLines(new StreamWriter(path), contents);
		}

		/// <summary>Создает новый файл, записывает указанный массив строк в этот файл, используя заданную кодировку, затем закрывает файл.</summary>
		/// <param name="path">Файл, в который осуществляется запись.</param>
		/// <param name="contents">Массив строк, который нужно записать в файл.</param>
		/// <param name="encoding">Объект <see cref="T:System.Text.Encoding" />, представляющий кодировку символов, примененную к массиву строк.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Либо <paramref name="path" />, либо <paramref name="contents" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		///
		/// или - 
		/// Эта операция не поддерживается на текущей платформе.  
		///
		/// -или- 
		///  <paramref name="path" /> определяет каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006780 RID: 26496 RVA: 0x00160939 File Offset: 0x0015EB39
		public static void WriteAllLines(string path, string[] contents, Encoding encoding)
		{
			File.WriteAllLines(path, contents, encoding);
		}

		/// <summary>Создает новый файл, используя указанную кодировку, записывает коллекцию строк в этот файл, затем закрывает файл.</summary>
		/// <param name="path">Файл, в который осуществляется запись.</param>
		/// <param name="contents">Строки, записываемые в файл.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> является пустой строкой, содержит только пробел либо один или несколько недопустимых символов, определенных методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Какой-либо из параметров <paramref name="path" />, <paramref name="contents" /> или <paramref name="encoding" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="path" /> (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина параметра <paramref name="path" /> превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> является каталогом.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006781 RID: 26497 RVA: 0x00160944 File Offset: 0x0015EB44
		public static void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (contents == null)
			{
				throw new ArgumentNullException("contents");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			File.InternalWriteAllLines(new StreamWriter(path, false, encoding), contents);
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x001609A4 File Offset: 0x0015EBA4
		private static void InternalWriteAllLines(TextWriter writer, IEnumerable<string> contents)
		{
			try
			{
				foreach (string value in contents)
				{
					writer.WriteLine(value);
				}
			}
			finally
			{
				if (writer != null)
				{
					((IDisposable)writer).Dispose();
				}
			}
		}

		/// <summary>Открывает файл, добавляет в него указанную строку и затем закрывает файл. Если файл не существует, этот метод создает файл, записывает в него указанную строку и затем закрывает файл.</summary>
		/// <param name="path">Файл, в который нужно добавить заданную строку.</param>
		/// <param name="contents">Строка, которую нужно добавить в файл.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный путь является недопустимым (например, каталог не существует или находится на несопоставленном диске).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> определяет каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006783 RID: 26499 RVA: 0x00160A04 File Offset: 0x0015EC04
		public static void AppendAllText(string path, string contents)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			using (StreamWriter streamWriter = new StreamWriter(path, true))
			{
				streamWriter.Write(contents);
			}
		}

		/// <summary>Добавляет указанную строку в файл, создавая файл, если он не существует.</summary>
		/// <param name="path">Файл, в который нужно добавить заданную строку.</param>
		/// <param name="contents">Строка, которую нужно добавить в файл.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный путь является недопустимым (например, каталог не существует или находится на несопоставленном диске).</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		///  <paramref name="path" /> определяет каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006784 RID: 26500 RVA: 0x00160A64 File Offset: 0x0015EC64
		public static void AppendAllText(string path, string contents, Encoding encoding)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			using (StreamWriter streamWriter = new StreamWriter(path, true, encoding))
			{
				streamWriter.Write(contents);
			}
		}

		/// <summary>Добавляет строки в файл, затем закрывает файл. Если указанный файл не существует, этот метод создает файл, записывает в него указанные строки и затем закрывает файл.</summary>
		/// <param name="path">Файл, в который добавляются строки. Если файл не существует, он создается.</param>
		/// <param name="contents">Строки, добавляемые в файл.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или еще один недопустимый символ, заданный методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Либо <paramref name="path" />, либо <paramref name="contents" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Параметр <paramref name="path" /> является недопустимым (например, каталог не существует или указан несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не обнаружен.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина параметра <paramref name="path" /> превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект не имеет разрешения на запись в файл.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		///
		/// или - 
		/// <paramref name="path" /> является каталогом.</exception>
		// Token: 0x06006785 RID: 26501 RVA: 0x00160AD4 File Offset: 0x0015ECD4
		public static void AppendAllLines(string path, IEnumerable<string> contents)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (contents == null)
			{
				throw new ArgumentNullException("contents");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			File.InternalWriteAllLines(new StreamWriter(path, true), contents);
		}

		/// <summary>Добавляет строки в файл, используя заданную кодировку, затем закрывает файл. Если указанный файл не существует, этот метод создает файл, записывает в него указанные строки и затем закрывает файл.</summary>
		/// <param name="path">Файл, в который добавляются строки. Если файл не существует, он создается.</param>
		/// <param name="contents">Строки, добавляемые в файл.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или еще один недопустимый символ, заданный методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Какой-либо из параметров <paramref name="path" />, <paramref name="contents" /> или <paramref name="encoding" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Параметр <paramref name="path" /> является недопустимым (например, каталог не существует или указан несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="path" />, не обнаружен.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина параметра <paramref name="path" /> превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		///
		/// или - 
		/// <paramref name="path" /> является каталогом.  
		///
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006786 RID: 26502 RVA: 0x00160B24 File Offset: 0x0015ED24
		public static void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (contents == null)
			{
				throw new ArgumentNullException("contents");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			File.InternalWriteAllLines(new StreamWriter(path, true, encoding), contents);
		}

		/// <summary>Заменяет содержимое заданного файла на содержимое другого файла, удаляя исходный файл и создавая резервную копию замененного файла.</summary>
		/// <param name="sourceFileName">Имя файла, который заменяет файл, указанный <paramref name="destinationFileName" />.</param>
		/// <param name="destinationFileName">Имя заменяемого файла.</param>
		/// <param name="destinationBackupFileName">Имя файла резервной копии.</param>
		/// <exception cref="T:System.ArgumentException">Путь, описываемый параметром <paramref name="destinationFileName" />, имел недопустимую форму.  
		///
		/// или - 
		/// Путь, описываемый параметром <paramref name="destinationBackupFileName" />, имел недопустимую форму.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="destinationFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DriveNotFoundException">Указан недопустимый диск.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, описываемый текущим объектом <see cref="T:System.IO.FileInfo" />, не найден.  
		///
		/// или - 
		/// Файл, описываемый параметром <paramref name="destinationBackupFileName" />, не найден.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.  
		/// -или- 
		/// Параметры <paramref name="sourceFileName" /> и <paramref name="destinationFileName" /> указывают один и тот же файл.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Операционной системой является Windows 98 Second Edition или более ранних версий, и файловая система отлична от NTFS.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="sourceFileName" /> или <paramref name="destinationFileName" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		///
		/// или - 
		/// Исходные или конечные параметры определяют каталог вместо файла.  
		///
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006787 RID: 26503 RVA: 0x00160B81 File Offset: 0x0015ED81
		public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
		{
			File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, false);
		}

		/// <summary>Заменяет содержимое заданного файла на содержимое другого файла, удаляя исходный файл и создавая резервную копию замененного файла, и при необходимости игнорирует ошибки слияния.</summary>
		/// <param name="sourceFileName">Имя файла, который заменяет файл, указанный <paramref name="destinationFileName" />.</param>
		/// <param name="destinationFileName">Имя заменяемого файла.</param>
		/// <param name="destinationBackupFileName">Имя файла резервной копии.</param>
		/// <param name="ignoreMetadataErrors">Значение <see langword="true" /> позволяет игнорировать ошибки слияния (например, атрибуты и списки управления доступом (ACL)), исходящие из заменяемого файла в заменяющий; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">Путь, описываемый параметром <paramref name="destinationFileName" />, имел недопустимую форму.  
		/// -или- 
		/// Путь, описываемый параметром <paramref name="destinationBackupFileName" />, имел недопустимую форму.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="destinationFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DriveNotFoundException">Указан недопустимый диск.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, описываемый текущим объектом <see cref="T:System.IO.FileInfo" />, не найден.  
		/// -или- 
		/// Файл, описываемый параметром <paramref name="destinationBackupFileName" />, не найден.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.  
		/// -или- 
		/// Параметры <paramref name="sourceFileName" /> и <paramref name="destinationFileName" /> указывают один и тот же файл.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Операционной системой является Windows 98 Second Edition или более ранних версий, и файловая система отлична от NTFS.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="sourceFileName" /> или <paramref name="destinationFileName" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// Исходные или конечные параметры определяют каталог вместо файла.  
		///
		/// или - 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006788 RID: 26504 RVA: 0x00160B8C File Offset: 0x0015ED8C
		public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
		{
			if (sourceFileName == null)
			{
				throw new ArgumentNullException("sourceFileName");
			}
			if (destinationFileName == null)
			{
				throw new ArgumentNullException("destinationFileName");
			}
			FileSystem.ReplaceFile(Path.GetFullPath(sourceFileName), Path.GetFullPath(destinationFileName), (destinationBackupFileName != null) ? Path.GetFullPath(destinationBackupFileName) : null, ignoreMetadataErrors);
		}

		/// <summary>Перемещает заданный файл в новое местоположение и разрешает переименование файла.</summary>
		/// <param name="sourceFileName">Имя перемещаемого файла. Может содержать относительный или абсолютный путь.</param>
		/// <param name="destFileName">Новый путь к файлу и его имя.</param>
		/// <exception cref="T:System.IO.IOException">Конечный файл уже существует.  
		/// -или- 
		///  Не удалось найти <paramref name="sourceFileName" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceFileName" /> или <paramref name="destFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="sourceFileName" /> или <paramref name="destFileName" /> представляет собой строку нулевой длины, содержащую только пробелы или содержащую недопустимые символы, заданные методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">В <paramref name="sourceFileName" /> или <paramref name="destFileName" /> указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="sourceFileName" /> или <paramref name="destFileName" /> имеет недопустимый формат.</exception>
		// Token: 0x06006789 RID: 26505 RVA: 0x00160BC8 File Offset: 0x0015EDC8
		public static void Move(string sourceFileName, string destFileName)
		{
			if (sourceFileName == null)
			{
				throw new ArgumentNullException("sourceFileName", "File name cannot be null.");
			}
			if (destFileName == null)
			{
				throw new ArgumentNullException("destFileName", "File name cannot be null.");
			}
			if (sourceFileName.Length == 0)
			{
				throw new ArgumentException("Empty file name is not legal.", "sourceFileName");
			}
			if (destFileName.Length == 0)
			{
				throw new ArgumentException("Empty file name is not legal.", "destFileName");
			}
			string fullPath = Path.GetFullPath(sourceFileName);
			string fullPath2 = Path.GetFullPath(destFileName);
			if (!FileSystem.FileExists(fullPath))
			{
				throw new FileNotFoundException(SR.Format("Could not find file '{0}'.", fullPath), fullPath);
			}
			FileSystem.MoveFile(fullPath, fullPath2);
		}

		/// <summary>Шифрует файл таким образом, чтобы его можно было расшифровать только с помощью учетной записи, которая использовалась для шифрования.</summary>
		/// <param name="path">Путь, описывающий файл, который нужно зашифровать.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DriveNotFoundException">Указан недопустимый диск.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, описанный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версией.</exception>
		/// <exception cref="T:System.NotSupportedException">Файловая система не является системой NTFS.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// Параметр <paramref name="path" /> указывает каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600678A RID: 26506 RVA: 0x00160C5A File Offset: 0x0015EE5A
		public static void Encrypt(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			throw new PlatformNotSupportedException("File encryption is not supported on this platform.");
		}

		/// <summary>Расшифровывает файл, зашифрованный текущей учетной записью с помощью метода <see cref="M:System.IO.File.Encrypt(System.String)" />.</summary>
		/// <param name="path">Путь, описывающий файл, который нужно расшифровать.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DriveNotFoundException">Указан недопустимый диск.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, описанный параметром <paramref name="path" />, не найден.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода. Например зашифрованный файл уже открыт.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версией.</exception>
		/// <exception cref="T:System.NotSupportedException">Файловая система не является системой NTFS.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// Параметр <paramref name="path" /> указывает каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600678B RID: 26507 RVA: 0x00160C5A File Offset: 0x0015EE5A
		public static void Decrypt(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			throw new PlatformNotSupportedException("File encryption is not supported on this platform.");
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x0600678C RID: 26508 RVA: 0x00160C74 File Offset: 0x0015EE74
		private static Encoding UTF8NoBOM
		{
			get
			{
				Encoding result;
				if ((result = File.s_UTF8NoBOM) == null)
				{
					result = (File.s_UTF8NoBOM = new UTF8Encoding(false, true));
				}
				return result;
			}
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x00160C8C File Offset: 0x0015EE8C
		private static StreamReader AsyncStreamReader(string path, Encoding encoding)
		{
			return new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous | FileOptions.SequentialScan), encoding, true);
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x00160CA8 File Offset: 0x0015EEA8
		private static StreamWriter AsyncStreamWriter(string path, Encoding encoding, bool append)
		{
			return new StreamWriter(new FileStream(path, append ? FileMode.Append : FileMode.Create, FileAccess.Write, FileShare.Read, 4096, FileOptions.Asynchronous | FileOptions.SequentialScan), encoding);
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x00160CC9 File Offset: 0x0015EEC9
		public static Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.ReadAllTextAsync(path, Encoding.UTF8, cancellationToken);
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x00160CD8 File Offset: 0x0015EED8
		public static Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			if (!cancellationToken.IsCancellationRequested)
			{
				return File.InternalReadAllTextAsync(path, encoding, cancellationToken);
			}
			return Task.FromCanceled<string>(cancellationToken);
		}

		// Token: 0x06006791 RID: 26513 RVA: 0x00160D34 File Offset: 0x0015EF34
		private static Task<string> InternalReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken)
		{
			File.<InternalReadAllTextAsync>d__67 <InternalReadAllTextAsync>d__;
			<InternalReadAllTextAsync>d__.path = path;
			<InternalReadAllTextAsync>d__.encoding = encoding;
			<InternalReadAllTextAsync>d__.cancellationToken = cancellationToken;
			<InternalReadAllTextAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<InternalReadAllTextAsync>d__.<>1__state = -1;
			<InternalReadAllTextAsync>d__.<>t__builder.Start<File.<InternalReadAllTextAsync>d__67>(ref <InternalReadAllTextAsync>d__);
			return <InternalReadAllTextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06006792 RID: 26514 RVA: 0x00160D87 File Offset: 0x0015EF87
		public static Task WriteAllTextAsync(string path, string contents, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.WriteAllTextAsync(path, contents, File.UTF8NoBOM, cancellationToken);
		}

		// Token: 0x06006793 RID: 26515 RVA: 0x00160D98 File Offset: 0x0015EF98
		public static Task WriteAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (string.IsNullOrEmpty(contents))
			{
				new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read).Dispose();
				return Task.CompletedTask;
			}
			return File.InternalWriteAllTextAsync(File.AsyncStreamWriter(path, encoding, false), contents, cancellationToken);
		}

		// Token: 0x06006794 RID: 26516 RVA: 0x00160E14 File Offset: 0x0015F014
		public static Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<byte[]>(cancellationToken);
			}
			FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 1, FileOptions.Asynchronous | FileOptions.SequentialScan);
			bool flag = false;
			Task<byte[]> result;
			try
			{
				long length = fileStream.Length;
				if (length > 2147483647L)
				{
					result = Task.FromException<byte[]>(new IOException("The file is too long. This operation is currently limited to supporting files less than 2 gigabytes in size."));
				}
				else
				{
					flag = true;
					result = ((length > 0L) ? File.InternalReadAllBytesAsync(fileStream, (int)length, cancellationToken) : File.InternalReadAllBytesUnknownLengthAsync(fileStream, cancellationToken));
				}
			}
			finally
			{
				if (!flag)
				{
					fileStream.Dispose();
				}
			}
			return result;
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x00160E9C File Offset: 0x0015F09C
		private static Task<byte[]> InternalReadAllBytesAsync(FileStream fs, int count, CancellationToken cancellationToken)
		{
			File.<InternalReadAllBytesAsync>d__71 <InternalReadAllBytesAsync>d__;
			<InternalReadAllBytesAsync>d__.fs = fs;
			<InternalReadAllBytesAsync>d__.count = count;
			<InternalReadAllBytesAsync>d__.cancellationToken = cancellationToken;
			<InternalReadAllBytesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
			<InternalReadAllBytesAsync>d__.<>1__state = -1;
			<InternalReadAllBytesAsync>d__.<>t__builder.Start<File.<InternalReadAllBytesAsync>d__71>(ref <InternalReadAllBytesAsync>d__);
			return <InternalReadAllBytesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x00160EF0 File Offset: 0x0015F0F0
		private static Task<byte[]> InternalReadAllBytesUnknownLengthAsync(FileStream fs, CancellationToken cancellationToken)
		{
			File.<InternalReadAllBytesUnknownLengthAsync>d__72 <InternalReadAllBytesUnknownLengthAsync>d__;
			<InternalReadAllBytesUnknownLengthAsync>d__.fs = fs;
			<InternalReadAllBytesUnknownLengthAsync>d__.cancellationToken = cancellationToken;
			<InternalReadAllBytesUnknownLengthAsync>d__.<>t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
			<InternalReadAllBytesUnknownLengthAsync>d__.<>1__state = -1;
			<InternalReadAllBytesUnknownLengthAsync>d__.<>t__builder.Start<File.<InternalReadAllBytesUnknownLengthAsync>d__72>(ref <InternalReadAllBytesUnknownLengthAsync>d__);
			return <InternalReadAllBytesUnknownLengthAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x00160F3C File Offset: 0x0015F13C
		public static Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (path == null)
			{
				throw new ArgumentNullException("path", "Path cannot be null.");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes");
			}
			if (!cancellationToken.IsCancellationRequested)
			{
				return File.InternalWriteAllBytesAsync(path, bytes, cancellationToken);
			}
			return Task.FromCanceled(cancellationToken);
		}

		// Token: 0x06006798 RID: 26520 RVA: 0x00160F9C File Offset: 0x0015F19C
		private static Task InternalWriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken)
		{
			File.<InternalWriteAllBytesAsync>d__74 <InternalWriteAllBytesAsync>d__;
			<InternalWriteAllBytesAsync>d__.path = path;
			<InternalWriteAllBytesAsync>d__.bytes = bytes;
			<InternalWriteAllBytesAsync>d__.cancellationToken = cancellationToken;
			<InternalWriteAllBytesAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<InternalWriteAllBytesAsync>d__.<>1__state = -1;
			<InternalWriteAllBytesAsync>d__.<>t__builder.Start<File.<InternalWriteAllBytesAsync>d__74>(ref <InternalWriteAllBytesAsync>d__);
			return <InternalWriteAllBytesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x00160FEF File Offset: 0x0015F1EF
		public static Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.ReadAllLinesAsync(path, Encoding.UTF8, cancellationToken);
		}

		// Token: 0x0600679A RID: 26522 RVA: 0x00161000 File Offset: 0x0015F200
		public static Task<string[]> ReadAllLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			if (!cancellationToken.IsCancellationRequested)
			{
				return File.InternalReadAllLinesAsync(path, encoding, cancellationToken);
			}
			return Task.FromCanceled<string[]>(cancellationToken);
		}

		// Token: 0x0600679B RID: 26523 RVA: 0x0016105C File Offset: 0x0015F25C
		private static Task<string[]> InternalReadAllLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken)
		{
			File.<InternalReadAllLinesAsync>d__77 <InternalReadAllLinesAsync>d__;
			<InternalReadAllLinesAsync>d__.path = path;
			<InternalReadAllLinesAsync>d__.encoding = encoding;
			<InternalReadAllLinesAsync>d__.cancellationToken = cancellationToken;
			<InternalReadAllLinesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string[]>.Create();
			<InternalReadAllLinesAsync>d__.<>1__state = -1;
			<InternalReadAllLinesAsync>d__.<>t__builder.Start<File.<InternalReadAllLinesAsync>d__77>(ref <InternalReadAllLinesAsync>d__);
			return <InternalReadAllLinesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600679C RID: 26524 RVA: 0x001610AF File Offset: 0x0015F2AF
		public static Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.WriteAllLinesAsync(path, contents, File.UTF8NoBOM, cancellationToken);
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x001610C0 File Offset: 0x0015F2C0
		public static Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (contents == null)
			{
				throw new ArgumentNullException("contents");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			if (!cancellationToken.IsCancellationRequested)
			{
				return File.InternalWriteAllLinesAsync(File.AsyncStreamWriter(path, encoding, false), contents, cancellationToken);
			}
			return Task.FromCanceled(cancellationToken);
		}

		// Token: 0x0600679E RID: 26526 RVA: 0x00161130 File Offset: 0x0015F330
		private static Task InternalWriteAllLinesAsync(TextWriter writer, IEnumerable<string> contents, CancellationToken cancellationToken)
		{
			File.<InternalWriteAllLinesAsync>d__80 <InternalWriteAllLinesAsync>d__;
			<InternalWriteAllLinesAsync>d__.writer = writer;
			<InternalWriteAllLinesAsync>d__.contents = contents;
			<InternalWriteAllLinesAsync>d__.cancellationToken = cancellationToken;
			<InternalWriteAllLinesAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<InternalWriteAllLinesAsync>d__.<>1__state = -1;
			<InternalWriteAllLinesAsync>d__.<>t__builder.Start<File.<InternalWriteAllLinesAsync>d__80>(ref <InternalWriteAllLinesAsync>d__);
			return <InternalWriteAllLinesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600679F RID: 26527 RVA: 0x00161184 File Offset: 0x0015F384
		private static Task InternalWriteAllTextAsync(StreamWriter sw, string contents, CancellationToken cancellationToken)
		{
			File.<InternalWriteAllTextAsync>d__81 <InternalWriteAllTextAsync>d__;
			<InternalWriteAllTextAsync>d__.sw = sw;
			<InternalWriteAllTextAsync>d__.contents = contents;
			<InternalWriteAllTextAsync>d__.cancellationToken = cancellationToken;
			<InternalWriteAllTextAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<InternalWriteAllTextAsync>d__.<>1__state = -1;
			<InternalWriteAllTextAsync>d__.<>t__builder.Start<File.<InternalWriteAllTextAsync>d__81>(ref <InternalWriteAllTextAsync>d__);
			return <InternalWriteAllTextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060067A0 RID: 26528 RVA: 0x001611D7 File Offset: 0x0015F3D7
		public static Task AppendAllTextAsync(string path, string contents, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.AppendAllTextAsync(path, contents, File.UTF8NoBOM, cancellationToken);
		}

		// Token: 0x060067A1 RID: 26529 RVA: 0x001611E8 File Offset: 0x0015F3E8
		public static Task AppendAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			if (string.IsNullOrEmpty(contents))
			{
				new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.Read).Dispose();
				return Task.CompletedTask;
			}
			return File.InternalWriteAllTextAsync(File.AsyncStreamWriter(path, encoding, true), contents, cancellationToken);
		}

		// Token: 0x060067A2 RID: 26530 RVA: 0x00161264 File Offset: 0x0015F464
		public static Task AppendAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default(CancellationToken))
		{
			return File.AppendAllLinesAsync(path, contents, File.UTF8NoBOM, cancellationToken);
		}

		// Token: 0x060067A3 RID: 26531 RVA: 0x00161274 File Offset: 0x0015F474
		public static Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (contents == null)
			{
				throw new ArgumentNullException("contents");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Empty path name is not legal.", "path");
			}
			if (!cancellationToken.IsCancellationRequested)
			{
				return File.InternalWriteAllLinesAsync(File.AsyncStreamWriter(path, encoding, true), contents, cancellationToken);
			}
			return Task.FromCanceled(cancellationToken);
		}

		/// <summary>Создает или перезаписывает указанный файл с заданным размером буфера, параметрами файла и уровнем безопасности.</summary>
		/// <param name="path">Имя файла</param>
		/// <param name="bufferSize">Число байтов, буферизируемых при чтении и записи в данный файл.</param>
		/// <param name="options">Одно из значений <see cref="T:System.IO.FileOptions" />, которое описывает, как создавать или перезаписывать файл.</param>
		/// <param name="fileSecurity">Одно из значений <see cref="T:System.Security.AccessControl.FileSecurity" />, определяющих управление доступом и аудит безопасности для файла.</param>
		/// <returns>Новый файл с заданным размером буфера, параметрами файла и уровнем безопасности.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.  
		/// -или- 
		///  Параметр <paramref name="path" /> указывает файл, доступный только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода при создании файла.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> задан в недопустимом формате.</exception>
		// Token: 0x060067A4 RID: 26532 RVA: 0x00160192 File Offset: 0x0015E392
		public static FileStream Create(string path, int bufferSize, FileOptions options, FileSecurity fileSecurity)
		{
			return new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, options);
		}

		/// <summary>Получает объект <see cref="T:System.Security.AccessControl.FileSecurity" />, который инкапсулирует записи списка ACL для заданного файла.</summary>
		/// <param name="path">Путь к файлу, содержащему объект <see cref="T:System.Security.AccessControl.FileSecurity" />, описывающий сведения о списке управления доступом (ACL) для конкретного файла.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.FileSecurity" />, который инкапсулирует правила управления доступом для файла, описанные параметром <paramref name="path" />.</returns>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.SEHException">Параметр <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.SystemException">Не удалось найти файл.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// Параметр <paramref name="path" /> указывает каталог.  
		///
		/// или - 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060067A5 RID: 26533 RVA: 0x001612E2 File Offset: 0x0015F4E2
		public static FileSecurity GetAccessControl(string path)
		{
			return File.GetAccessControl(path, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
		}

		/// <summary>Получает объект <see cref="T:System.Security.AccessControl.FileSecurity" />, инкапсулирующий записи списка ACL определенного типа для конкретного файла.</summary>
		/// <param name="path">Путь к файлу, содержащему объект <see cref="T:System.Security.AccessControl.FileSecurity" />, описывающий сведения о списке управления доступом (ACL) для конкретного файла.</param>
		/// <param name="includeSections">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее тип сведений о списке ACL, которые необходимо получить.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.FileSecurity" />, который инкапсулирует правила управления доступом для файла, описанные параметром <paramref name="path" />.</returns>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.SEHException">Параметр <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.SystemException">Не удалось найти файл.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		///
		/// или - 
		/// Эта операция не поддерживается на текущей платформе.  
		///
		/// или - 
		/// Параметр <paramref name="path" /> указывает каталог.  
		///
		///
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060067A6 RID: 26534 RVA: 0x001612EC File Offset: 0x0015F4EC
		public static FileSecurity GetAccessControl(string path, AccessControlSections includeSections)
		{
			return new FileSecurity(path, includeSections);
		}

		/// <summary>Применяет записи списка управления доступом (ACL), описанные объектом <see cref="T:System.Security.AccessControl.FileSecurity" />, к заданному файлу.</summary>
		/// <param name="path">Файл, в который нужно добавить или из которого нужно удалить записи списка управления доступом.</param>
		/// <param name="fileSecurity">Объект <see cref="T:System.Security.AccessControl.FileSecurity" />, характеризующий запись ACL, которую необходимо применить к файлу, описанному параметром <paramref name="path" />.</param>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.SEHException">Параметр <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.SystemException">Не удалось найти файл.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="path" /> указывает файл, доступный только для чтения.  
		///
		/// или - 
		/// Эта операция не поддерживается на текущей платформе.  
		///
		/// или - 
		/// Параметр <paramref name="path" /> указывает каталог.  
		///
		///
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="fileSecurity" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060067A7 RID: 26535 RVA: 0x001612F5 File Offset: 0x0015F4F5
		public static void SetAccessControl(string path, FileSecurity fileSecurity)
		{
			if (fileSecurity == null)
			{
				throw new ArgumentNullException("fileSecurity");
			}
			fileSecurity.PersistModifications(path);
		}

		// Token: 0x04003C30 RID: 15408
		private const int MaxByteArrayLength = 2147483591;

		// Token: 0x04003C31 RID: 15409
		private static Encoding s_UTF8NoBOM;

		// Token: 0x04003C32 RID: 15410
		internal const int DefaultBufferSize = 4096;
	}
}
