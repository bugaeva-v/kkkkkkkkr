using System;
using Microsoft.Win32.SafeHandles;

namespace System.IO.MemoryMappedFiles
{
	/// <summary>
	///         Представляет размещенный в памяти файл.
	///       </summary>
	// Token: 0x0200033B RID: 827
	public class MemoryMappedFile : IDisposable
	{
		/// <summary>
		///         Создает размещенный в памяти файл из файла на диске.
		///       </summary>
		/// <param name="path">
		///           Путь к файлу для сопоставления.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="path" /> является пустой строкой, содержит только пробелы или имеет один или несколько недопустимых символов, как определяется <see cref="M:System.IO.Path.GetInvalidFileNameChars" /> метод.
		///
		///             -или-
		///
		///             <paramref name="path" /> ссылается на недопустимый устройства.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="path" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Ошибка ввода/вывода.
		///           </exception>
		/// <exception cref="T:System.IO.PathTooLongException">
		///             <paramref name="path" /> превышает максимальную длину, определенную операционной системой.
		///              В Windows пути должны содержать менее 248 символов и имена файлов должны содержать не более 260 знаков.
		///           </exception>
		/// <exception cref="T:System.Security.SecurityException">
		///             Вызывающий объект не имеет необходимых разрешений для файла.
		///           </exception>
		// Token: 0x060018F3 RID: 6387 RVA: 0x00053E5C File Offset: 0x0005205C
		public static MemoryMappedFile CreateFromFile(string path)
		{
			return MemoryMappedFile.CreateFromFile(path, FileMode.Open, null, 0L, MemoryMappedFileAccess.ReadWrite);
		}

		/// <summary>
		///         Создает размещенный в памяти файл с заданным режимом доступа из файла на диске.
		///       </summary>
		/// <param name="path">
		///           Путь к файлу для сопоставления.
		///         </param>
		/// <param name="mode">
		///           Режим доступа; должен быть <see cref="F:System.IO.FileMode.Open" />.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданным режимом доступа.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="path" /> является пустой строкой, содержит только пробелы или имеет один или несколько недопустимых символов, как определяется <see cref="M:System.IO.Path.GetInvalidFileNameChars" /> метод.
		///
		///             -или-
		///
		///             <paramref name="path" /> ссылается на недопустимый устройства.
		///
		///             -или-
		///
		///             Свойство <paramref name="mode" /> имеет значение <see cref="F:System.IO.FileMode.Append" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="path" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             <paramref name="mode" /> is <see cref="F:System.IO.FileMode.Create" />, <see cref="F:System.IO.FileMode.CreateNew" />, or <see cref="F:System.IO.FileMode.Truncate" />.
		///
		///             -или-
		///
		///             <paramref name="mode" /> — <see cref="F:System.IO.FileMode.OpenOrCreate" /> и файл на диске не существует.
		///
		///             -или-
		///
		///             Ошибка ввода/вывода.
		///           </exception>
		/// <exception cref="T:System.IO.PathTooLongException">
		///             <paramref name="path" /> превышает максимальную длину, определенную операционной системой.
		///              В Windows пути должны содержать менее 248 символов и имена файлов должны содержать не более 260 знаков.
		///           </exception>
		/// <exception cref="T:System.Security.SecurityException">
		///             Вызывающий объект не имеет необходимых разрешений для файла.
		///           </exception>
		// Token: 0x060018F4 RID: 6388 RVA: 0x00053E6C File Offset: 0x0005206C
		public static MemoryMappedFile CreateFromFile(string path, FileMode mode)
		{
			long num = 0L;
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("path");
			}
			if (mode == FileMode.Append)
			{
				throw new ArgumentException("mode");
			}
			IntPtr preexistingHandle = MemoryMapImpl.OpenFile(path, mode, null, out num, MemoryMappedFileAccess.ReadWrite, MemoryMappedFileOptions.None);
			return new MemoryMappedFile
			{
				handle = new SafeMemoryMappedFileHandle(preexistingHandle, true)
			};
		}

		/// <summary>
		///         Создает из файла на диске размещенный в памяти файл с заданным режимом доступа и именем.
		///       </summary>
		/// <param name="path">
		///           Путь к файлу для сопоставления.
		///         </param>
		/// <param name="mode">
		///           Режим доступа; должен быть <see cref="F:System.IO.FileMode.Open" />.
		///         </param>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными именем и режимом доступа.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="path" /> является пустой строкой, содержит только пробелы или имеет один или несколько недопустимых символов, как определяется <see cref="M:System.IO.Path.GetInvalidFileNameChars" /> метод.
		///
		///             -или-
		///
		///             <paramref name="path" /> ссылается на недопустимый устройства.
		///
		///             -или-
		///
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///
		///             -или-
		///
		///             Свойство <paramref name="mode" /> имеет значение <see cref="F:System.IO.FileMode.Append" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="path" /> или <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             <paramref name="mode" /> is <see cref="F:System.IO.FileMode.Create" />, <see cref="F:System.IO.FileMode.CreateNew" />, or <see cref="F:System.IO.FileMode.Truncate" />.
		///
		///             -или-
		///
		///             <paramref name="mode" /> — <see cref="F:System.IO.FileMode.OpenOrCreate" /> и файл на диске не существует.
		///
		///             -или-
		///
		///             Ошибка ввода/вывода.
		///           </exception>
		/// <exception cref="T:System.IO.PathTooLongException">
		///             <paramref name="path" /> превышает максимальную длину, определенную операционной системой.
		///              В Windows пути должны содержать менее 248 символов и имена файлов должны содержать не более 260 знаков.
		///           </exception>
		/// <exception cref="T:System.Security.SecurityException">
		///             Вызывающий объект не имеет необходимых разрешений для файла.
		///           </exception>
		// Token: 0x060018F5 RID: 6389 RVA: 0x00053ECB File Offset: 0x000520CB
		public static MemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName)
		{
			return MemoryMappedFile.CreateFromFile(path, mode, mapName, 0L, MemoryMappedFileAccess.ReadWrite);
		}

		/// <summary>
		///         Создает из файла на диске размещенный в памяти файл с заданным режимом доступа, именем и емкостью.
		///       </summary>
		/// <param name="path">
		///           Путь к файлу для сопоставления.
		///         </param>
		/// <param name="mode">
		///           Режим доступа; может быть любой из <see cref="T:System.IO.FileMode" /> значений перечисления, за исключением <see cref="F:System.IO.FileMode.Append" />.
		///         </param>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <param name="capacity">
		///           Максимальный размер, выделяемый размещенному в памяти файлу, в байтах.
		///            Чтобы задать емкость, равную размеру файла на диске, указывается значение 0.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="path" /> является пустой строкой, содержит только пробелы или имеет один или несколько недопустимых символов, как определяется <see cref="M:System.IO.Path.GetInvalidFileNameChars" /> метод.
		///
		///             -или-
		///
		///             <paramref name="path" /> ссылается на недопустимый устройства.
		///
		///             -или-
		///
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///
		///             -или-
		///
		///             Свойство <paramref name="mode" /> имеет значение <see cref="F:System.IO.FileMode.Append" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="path" /> или <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="capacity" /> больше, чем размер логического адресного пространства.
		///
		///             -или-
		///
		///             Значение параметра <paramref name="capacity" /> меньше нуля.
		///
		///             -или-
		///
		///             <paramref name="capacity" /> меньше, чем размер файла (но не ноль).
		///
		///             -или-
		///
		///             <paramref name="capacity" /> равно нулю, а размер файла на диске также — ноль.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Ошибка ввода/вывода.
		///           </exception>
		/// <exception cref="T:System.IO.PathTooLongException">
		///             <paramref name="path" /> превышает максимальную длину, определенную операционной системой.
		///              В Windows пути должны содержать менее 248 символов и имена файлов должны содержать не более 260 знаков.
		///           </exception>
		/// <exception cref="T:System.Security.SecurityException">
		///             Вызывающий объект не имеет необходимых разрешений для файла.
		///           </exception>
		// Token: 0x060018F6 RID: 6390 RVA: 0x00053ED8 File Offset: 0x000520D8
		public static MemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName, long capacity)
		{
			return MemoryMappedFile.CreateFromFile(path, mode, mapName, capacity, MemoryMappedFileAccess.ReadWrite);
		}

		/// <summary>
		///         Создает из файла на диске размещенный в памяти файл с указанными режимом доступа, именем, емкостью и типом доступа.
		///       </summary>
		/// <param name="path">
		///           Путь к файлу для сопоставления.
		///         </param>
		/// <param name="mode">
		///           Режим доступа; может быть любой из <see cref="T:System.IO.FileMode" /> значений перечисления, за исключением <see cref="F:System.IO.FileMode.Append" />.
		///         </param>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <param name="capacity">
		///           Максимальный размер, выделяемый размещенному в памяти файлу, в байтах.
		///            Чтобы задать емкость, равную размеру файла на диске, указывается значение 0.
		///         </param>
		/// <param name="access">
		///           Одно из значений перечисления, определяющее разрешенный тип доступа к размещенному в памяти файлу.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///
		///             -или-
		///
		///             <paramref name="access" /> не является разрешенным значением.
		///
		///             -или-
		///
		///             <paramref name="path" /> Указывает пустой файл.
		///
		///             -или-
		///
		///             <paramref name="access" /> указывается как <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Read" /> и емкость превышает размер файла, заданного <paramref name="path" />.
		///
		///             -или-
		///
		///             Свойство <paramref name="mode" /> имеет значение <see cref="F:System.IO.FileMode.Append" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="path" /> или <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="capacity" /> больше, чем размер логического адресного пространства.
		///
		///             -или-
		///
		///             Значение параметра <paramref name="capacity" /> меньше нуля.
		///
		///             -или-
		///
		///             <paramref name="capacity" /> меньше, чем размер файла (но не ноль).
		///
		///             -или-
		///
		///             <paramref name="capacity" /> равно нулю, а размер файла на диске также — ноль.
		///
		///             -или-
		///
		///             <paramref name="access" /> не является определенным <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" /> значение.
		///
		///             -или-
		///
		///             Размер файла обозначаются <paramref name="path" /> больше, чем <paramref name="capacity" />.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             -или-
		///
		///             Ошибка ввода/вывода.
		///           </exception>
		/// <exception cref="T:System.IO.PathTooLongException">
		///             <paramref name="path" /> превышает максимальную длину, определенную операционной системой.
		///              В Windows пути должны содержать менее 248 символов и имена файлов должны содержать не более 260 знаков.
		///           </exception>
		/// <exception cref="T:System.Security.SecurityException">
		///             Вызывающий объект не имеет необходимых разрешений для файла.
		///           </exception>
		// Token: 0x060018F7 RID: 6391 RVA: 0x00053EE4 File Offset: 0x000520E4
		public static MemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName, long capacity, MemoryMappedFileAccess access)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("path");
			}
			if (mapName != null && mapName.Length == 0)
			{
				throw new ArgumentException("mapName");
			}
			if (mode == FileMode.Append)
			{
				throw new ArgumentException("mode");
			}
			if (capacity < 0L)
			{
				throw new ArgumentOutOfRangeException("capacity");
			}
			IntPtr preexistingHandle = MemoryMapImpl.OpenFile(path, mode, mapName, out capacity, access, MemoryMappedFileOptions.None);
			return new MemoryMappedFile
			{
				handle = new SafeMemoryMappedFileHandle(preexistingHandle, true)
			};
		}

		/// <summary>
		///         Создает из существующего файла размещенный в памяти файл с заданными режимом доступа, именем, режимом наследования и емкостью.
		///       </summary>
		/// <param name="fileStream">
		///           Поток существующего файла.
		///         </param>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <param name="capacity">
		///           Максимальный размер, выделяемый размещенному в памяти файлу, в байтах.
		///            Укажите 0, чтобы задать емкость, равную размер <paramref name="filestream" />.
		///         </param>
		/// <param name="access">
		///           Одно из значений перечисления, определяющее разрешенный тип доступа к размещенному в памяти файлу.
		///
		///           Этот параметр не может быть присвоено <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" />.
		///         </param>
		/// <param name="inheritability">
		///           Одно из значений перечисления, определяющее, может ли дескриптор размещенного в памяти файла наследоваться дочерним процессом.
		///            Значение по умолчанию — <see cref="F:System.IO.HandleInheritability.None" />.
		///         </param>
		/// <param name="leaveOpen">
		///           Значение, указывающее, следует ли закрывать исходного файла потока, когда <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFile" /> удаляется.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> имеет значение <see langword="null" /> или является пустой строкой.
		///
		///             -или-
		///
		///             <paramref name="capacity" /> и длину файла равны нулю.
		///
		///             -или-
		///
		///             <paramref name="access" /> имеет значение <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" /> или <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" /> значение перечисления, которое не допускается.
		///
		///             -или-
		///
		///             <paramref name="access" /> имеет значение <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Read" /> и <paramref name="capacity" /> больше, чем длина <see langword="filestream" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="fileStream" />  — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="capacity" /> меньше нуля.
		///
		///             -или-
		///
		///             <paramref name="capacity" /> меньше, чем размер файла.
		///
		///             -или-
		///
		///             <paramref name="access" /> не является допустимым значением перечисления <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" />.
		///
		///             -или-
		///
		///             <paramref name="inheritability" /> не является допустимым значением перечисления <see cref="T:System.IO.HandleInheritability" />.
		///           </exception>
		// Token: 0x060018F8 RID: 6392 RVA: 0x00053F68 File Offset: 0x00052168
		public static MemoryMappedFile CreateFromFile(FileStream fileStream, string mapName, long capacity, MemoryMappedFileAccess access, HandleInheritability inheritability, bool leaveOpen)
		{
			if (fileStream == null)
			{
				throw new ArgumentNullException("fileStream");
			}
			if (mapName != null && mapName.Length == 0)
			{
				throw new ArgumentException("mapName");
			}
			if ((!MonoUtil.IsUnix && capacity == 0L && fileStream.Length == 0L) || capacity > fileStream.Length)
			{
				throw new ArgumentException("capacity");
			}
			IntPtr preexistingHandle = MemoryMapImpl.OpenHandle(fileStream.SafeFileHandle.DangerousGetHandle(), mapName, out capacity, access, MemoryMappedFileOptions.None);
			MemoryMapImpl.ConfigureHandleInheritability(preexistingHandle, inheritability);
			return new MemoryMappedFile
			{
				handle = new SafeMemoryMappedFileHandle(preexistingHandle, true),
				stream = fileStream,
				keepOpen = leaveOpen
			};
		}

		/// <summary>
		///         Создает размещенный в памяти файл с указанным именем, емкостью, тип доступа, разрешения безопасности, режимом наследования и требованием к ликвидации из файла на диске.
		///       </summary>
		/// <param name="fileStream">
		///           <paramref name="fileStream" /> К файлу для сопоставления.
		///         </param>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <param name="capacity">
		///           Максимальный размер, выделяемый размещенному в памяти файлу, в байтах.
		///            Чтобы задать емкость, равную размеру файла на диске, указывается значение 0.
		///         </param>
		/// <param name="access">
		///           Одно из значений перечисления, определяющее разрешенный тип доступа к размещенному в памяти файлу.
		///
		///           Этот параметр не может быть присвоено <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" />.
		///         </param>
		/// <param name="memoryMappedFileSecurity">
		///           Разрешения, которые могут быть предоставлены для доступа к файлам и операций с размещенными в памяти файлами.
		///
		///           Этот параметр может иметь значение <see langword="null" />.
		///         </param>
		/// <param name="inheritability">
		///           Одно из значений перечисления, определяющее, может ли дескриптор размещенного в памяти файла наследоваться дочерним процессом.
		///            Значение по умолчанию — <see cref="F:System.IO.HandleInheritability.None" />.
		///         </param>
		/// <param name="leaveOpen">
		///           <see langword="true" /> Чтобы не удалять <paramref name="fileStream" /> после <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFile" /> закрытия; <see langword="false" /> метода Dispose <paramref name="fileStream" />.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///
		///             -или-
		///
		///             <paramref name="capacity" /> и длину файла равны нулю.
		///
		///             -или-
		///
		///             <paramref name="access" /> имеет значение <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Read" /> или <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" /> значение перечисления, которое не допускается.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="fileStream" /> или <paramref name="mapname" />  — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="capacity" /> меньше нуля.
		///
		///             -или-
		///
		///             <paramref name="capacity" /> меньше, чем размер файла.
		///
		///             -или-
		///
		///             <paramref name="access" /> не является допустимым значением перечисления <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" />.
		///
		///             -или-
		///
		///             <paramref name="inheritability" /> не является допустимым <see cref="T:System.IO.HandleInheritability" /> значение перечисления.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             <paramref name="fileStream" /> Закрыто.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             <paramref name="access" /> имеет значение <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" /> при <paramref name="fileStream" />в доступе <see cref="F:System.IO.FileAccess.Read" /> или <see cref="F:System.IO.FileAccess.Write" />.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             <paramref name="mapName" /> уже существует.
		///           </exception>
		// Token: 0x060018F9 RID: 6393 RVA: 0x00054000 File Offset: 0x00052200
		[MonoLimitation("memoryMappedFileSecurity is currently ignored")]
		public static MemoryMappedFile CreateFromFile(FileStream fileStream, string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability, bool leaveOpen)
		{
			if (fileStream == null)
			{
				throw new ArgumentNullException("fileStream");
			}
			if (mapName != null && mapName.Length == 0)
			{
				throw new ArgumentException("mapName");
			}
			if ((!MonoUtil.IsUnix && capacity == 0L && fileStream.Length == 0L) || capacity > fileStream.Length)
			{
				throw new ArgumentException("capacity");
			}
			IntPtr preexistingHandle = MemoryMapImpl.OpenHandle(fileStream.SafeFileHandle.DangerousGetHandle(), mapName, out capacity, access, MemoryMappedFileOptions.None);
			MemoryMapImpl.ConfigureHandleInheritability(preexistingHandle, inheritability);
			return new MemoryMappedFile
			{
				handle = new SafeMemoryMappedFileHandle(preexistingHandle, true),
				stream = fileStream,
				keepOpen = leaveOpen
			};
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00054098 File Offset: 0x00052298
		private static MemoryMappedFile CoreShmCreate(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability, FileMode mode)
		{
			if (mapName != null && mapName.Length == 0)
			{
				throw new ArgumentException("mapName");
			}
			if (capacity < 0L)
			{
				throw new ArgumentOutOfRangeException("capacity");
			}
			IntPtr preexistingHandle = MemoryMapImpl.OpenFile(null, mode, mapName, out capacity, access, options);
			return new MemoryMappedFile
			{
				handle = new SafeMemoryMappedFileHandle(preexistingHandle, true)
			};
		}

		/// <summary>
		///         Создает размещенный в памяти файл с заданной емкостью в системной памяти.
		///       </summary>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <param name="capacity">
		///           Максимальный размер, выделяемый размещенному в памяти файлу, в байтах.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными именем и емкостью.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение <paramref name="capacity" /> не больше нуля.
		///           </exception>
		// Token: 0x060018FB RID: 6395 RVA: 0x000540EB File Offset: 0x000522EB
		[MonoLimitation("Named mappings scope is process local")]
		public static MemoryMappedFile CreateNew(string mapName, long capacity)
		{
			return MemoryMappedFile.CreateNew(mapName, capacity, MemoryMappedFileAccess.ReadWrite, MemoryMappedFileOptions.None, null, HandleInheritability.None);
		}

		/// <summary>
		///         Создает размещенный в памяти файл с заданной емкостью и типом доступа в системной памяти.
		///       </summary>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <param name="capacity">
		///           Максимальный размер, выделяемый размещенному в памяти файлу, в байтах.
		///         </param>
		/// <param name="access">
		///           Одно из значений перечисления, определяющее разрешенный тип доступа к размещенному в памяти файлу.
		///            Значение по умолчанию — <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///
		///             -или-
		///
		///             Параметр <paramref name="access" /> задан как доступный только для записи с помощью значения перечисления <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение <paramref name="capacity" /> не больше нуля.
		///
		///             -или-
		///
		///             <paramref name="access" /> не является допустимым значением перечисления <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" />.
		///           </exception>
		// Token: 0x060018FC RID: 6396 RVA: 0x000540F8 File Offset: 0x000522F8
		[MonoLimitation("Named mappings scope is process local")]
		public static MemoryMappedFile CreateNew(string mapName, long capacity, MemoryMappedFileAccess access)
		{
			return MemoryMappedFile.CreateNew(mapName, capacity, access, MemoryMappedFileOptions.None, null, HandleInheritability.None);
		}

		/// <summary>
		///         Создает размещенный в памяти файл с заданными именем, емкостью, типом доступа, параметрами выделения памяти и режимом наследования.
		///       </summary>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <param name="capacity">
		///           Максимальный размер, выделяемый размещенному в памяти файлу, в байтах.
		///         </param>
		/// <param name="access">
		///           Одно из значений перечисления, определяющее разрешенный тип доступа к размещенному в памяти файлу.
		///            Значение по умолчанию — <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />.
		///         </param>
		/// <param name="options">
		///           Побитовое сочетание значений перечисления, которое задает параметры выделения памяти для размещенного в памяти файла.
		///         </param>
		/// <param name="inheritability">
		///           Значение, определяющее, может ли дескриптор размещенного в памяти файла наследоваться дочерним процессом.
		///            Значение по умолчанию — <see cref="F:System.IO.HandleInheritability.None" />.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///
		///             -или-
		///
		///             Параметр <paramref name="access" /> задан как доступный только для записи с помощью значения перечисления <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение <paramref name="capacity" /> не больше нуля.
		///
		///             -или-
		///
		///             <paramref name="access" /> не является допустимым значением перечисления <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" />.
		///
		///             -или-
		///
		///             <paramref name="inheritability" /> не является допустимым значением <see cref="T:System.IO.HandleInheritability" />.
		///           </exception>
		// Token: 0x060018FD RID: 6397 RVA: 0x00054105 File Offset: 0x00052305
		[MonoLimitation("Named mappings scope is process local; options is ignored")]
		public static MemoryMappedFile CreateNew(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, HandleInheritability inheritability)
		{
			return MemoryMappedFile.CreateNew(mapName, capacity, access, options, null, inheritability);
		}

		/// <summary>
		///         Создает размещенный в памяти файл с заданной емкостью, типом доступа, выделением памяти, настройками безопасности и режимом наследования в системной памяти.
		///       </summary>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <param name="capacity">
		///           Максимальный размер, выделяемый размещенному в памяти файлу, в байтах.
		///         </param>
		/// <param name="access">
		///           Одно из значений перечисления, определяющее разрешенный тип доступа к размещенному в памяти файлу.
		///            Значение по умолчанию — <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />.
		///         </param>
		/// <param name="options">
		///           Побитовое сочетание значений перечисления, которое задает параметры выделения памяти для размещенного в памяти файла.
		///         </param>
		/// <param name="memoryMappedFileSecurity">
		///           Разрешения, которые могут быть предоставлены для доступа к файлам и операций с размещенными в памяти файлами.
		///
		///           Этот параметр может иметь значение <see langword="null" />.
		///         </param>
		/// <param name="inheritability">
		///           Одно из значений перечисления, определяющее, может ли дескриптор размещенного в памяти файла наследоваться дочерним процессом.
		///            Значение по умолчанию — <see cref="F:System.IO.HandleInheritability.None" />.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///
		///             -или-
		///
		///             Параметр <paramref name="access" /> задан как доступный только для записи с помощью значения перечисления <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение <paramref name="capacity" /> не больше нуля.
		///
		///             -или-
		///
		///             <paramref name="access" /> не является допустимым значением перечисления <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" />.
		///
		///             -или-
		///
		///             <paramref name="inheritability" /> не является допустимым значением перечисления <see cref="T:System.IO.HandleInheritability" />.
		///           </exception>
		// Token: 0x060018FE RID: 6398 RVA: 0x00054113 File Offset: 0x00052313
		[MonoLimitation("Named mappings scope is process local; options and memoryMappedFileSecurity are ignored")]
		public static MemoryMappedFile CreateNew(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability)
		{
			return MemoryMappedFile.CoreShmCreate(mapName, capacity, access, options, memoryMappedFileSecurity, inheritability, FileMode.CreateNew);
		}

		/// <summary>
		///         Создает или открывает размещенный в памяти файл с заданной емкостью в системной памяти.
		///       </summary>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <param name="capacity">
		///           Максимальный размер, выделяемый размещенному в памяти файлу, в байтах.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданным именем и размером.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="capacity" /> больше, чем размер логического адресного пространства.
		///
		///             -или-
		///
		///             Значение <paramref name="capacity" /> не больше нуля.
		///           </exception>
		// Token: 0x060018FF RID: 6399 RVA: 0x00054123 File Offset: 0x00052323
		[MonoLimitation("Named mappings scope is process local")]
		public static MemoryMappedFile CreateOrOpen(string mapName, long capacity)
		{
			return MemoryMappedFile.CreateOrOpen(mapName, capacity, MemoryMappedFileAccess.ReadWrite);
		}

		/// <summary>
		///         Создает или открывает размещенный в памяти файл с заданной емкостью и типом доступа в системной памяти.
		///       </summary>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <param name="capacity">
		///           Максимальный размер, выделяемый размещенному в памяти файлу, в байтах.
		///         </param>
		/// <param name="access">
		///           Одно из значений перечисления, определяющее разрешенный тип доступа к размещенному в памяти файлу.
		///            Значение по умолчанию — <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///
		///             -или-
		///
		///             Параметр <paramref name="access" /> задан как доступный только для записи с помощью значения перечисления <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="capacity" /> больше, чем размер логического адресного пространства.
		///
		///             -или-
		///
		///             Значение <paramref name="capacity" /> не больше нуля.
		///
		///             -или-
		///
		///             <paramref name="access" /> не является допустимым значением перечисления <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" />.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             В операционной системе запрещен указанный доступ к файлу; Например, значение доступа <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" /> или <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />, но файл или каталог доступен только для чтения.
		///           </exception>
		// Token: 0x06001900 RID: 6400 RVA: 0x0005412D File Offset: 0x0005232D
		[MonoLimitation("Named mappings scope is process local")]
		public static MemoryMappedFile CreateOrOpen(string mapName, long capacity, MemoryMappedFileAccess access)
		{
			return MemoryMappedFile.CreateOrOpen(mapName, capacity, access, MemoryMappedFileOptions.None, null, HandleInheritability.None);
		}

		/// <summary>
		///         Создает пустой размещенный в памяти файл или открывает существующий, если файл с таким именем уже имеется.
		///          При открытии существующего файла емкость, параметры и аргументы памяти игнорируются.
		///       </summary>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <param name="capacity">
		///           Максимальный размер, выделяемый размещенному в памяти файлу, в байтах.
		///         </param>
		/// <param name="access">
		///           Одно из значений перечисления, определяющее разрешенный тип доступа к размещенному в памяти файлу.
		///            Значение по умолчанию — <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />.
		///         </param>
		/// <param name="options">
		///           Побитовое сочетание значений, которое задает параметры выделения памяти для файла.
		///         </param>
		/// <param name="inheritability">
		///           Значение, определяющее, может ли дескриптор размещенного в памяти файла наследоваться дочерним процессом.
		///            Значение по умолчанию — <see cref="F:System.IO.HandleInheritability.None" />.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///
		///             -или-
		///
		///             Параметр <paramref name="access" /> задан как доступный только для записи с помощью значения перечисления <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="capacity" /> больше, чем размер логического адресного пространства.
		///
		///             -или-
		///
		///             Значение <paramref name="capacity" /> не больше нуля.
		///
		///             -или-
		///
		///             <paramref name="access" /> не является допустимым значением перечисления <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" />.
		///
		///             -или-
		///
		///             <paramref name="inheritability" /> не является допустимым <see cref="T:System.IO.HandleInheritability" /> значение перечисления.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             В операционной системе запрещен указанный доступ к файлу; Например, значение доступа <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" /> или <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />, но файл или каталог доступен только для чтения.
		///           </exception>
		// Token: 0x06001901 RID: 6401 RVA: 0x0005413A File Offset: 0x0005233A
		[MonoLimitation("Named mappings scope is process local")]
		public static MemoryMappedFile CreateOrOpen(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, HandleInheritability inheritability)
		{
			return MemoryMappedFile.CreateOrOpen(mapName, capacity, access, options, null, inheritability);
		}

		/// <summary>
		///         Создает или открывает размещенный в памяти файл с заданной емкостью, типом доступа, выделением памяти, разрешениями безопасности и режимом наследования в системной памяти.
		///       </summary>
		/// <param name="mapName">
		///           Имя, присваиваемое размещенному в памяти файлу.
		///         </param>
		/// <param name="capacity">
		///           Максимальный размер, выделяемый размещенному в памяти файлу, в байтах.
		///         </param>
		/// <param name="access">
		///           Одно из значений перечисления, определяющее разрешенный тип доступа к размещенному в памяти файлу.
		///            Значение по умолчанию — <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />.
		///         </param>
		/// <param name="options">
		///           Побитовое сочетание значений перечисления, которое задает параметры выделения памяти для размещенного в памяти файла.
		///         </param>
		/// <param name="memoryMappedFileSecurity">
		///           Разрешения, которые могут быть предоставлены для доступа к файлам и операций с размещенными в памяти файлами.
		///
		///           Этот параметр может иметь значение <see langword="null" />.
		///         </param>
		/// <param name="inheritability">
		///           Одно из значений перечисления, определяющее, может ли дескриптор размещенного в памяти файла наследоваться дочерним процессом.
		///            Значение по умолчанию — <see cref="F:System.IO.HandleInheritability.None" />.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///
		///             -или-
		///
		///             Параметр <paramref name="access" /> задан как доступный только для записи с помощью значения перечисления <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="capacity" /> больше, чем размер логического адресного пространства.
		///
		///             -или-
		///
		///             Значение <paramref name="capacity" /> не больше нуля.
		///
		///             -или-
		///
		///             <paramref name="access" /> не является допустимым значением перечисления <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" />.
		///
		///             -или-
		///
		///             <paramref name="inheritability" /> не является допустимым <see cref="T:System.IO.HandleInheritability" /> значение перечисления.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             В операционной системе запрещен указанный <paramref name="access" /> файл; например, <paramref name="access" /> имеет значение <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" /> или <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />, но файл или каталог доступен только для чтения.
		///           </exception>
		// Token: 0x06001902 RID: 6402 RVA: 0x00054148 File Offset: 0x00052348
		[MonoLimitation("Named mappings scope is process local")]
		public static MemoryMappedFile CreateOrOpen(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability)
		{
			return MemoryMappedFile.CoreShmCreate(mapName, capacity, access, options, memoryMappedFileSecurity, inheritability, FileMode.OpenOrCreate);
		}

		/// <summary>
		///         Открывает существующий размещенный в памяти файл с заданным именем в системной памяти.
		///       </summary>
		/// <param name="mapName">
		///           Имя размещенного в памяти файла, который необходимо открыть.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданным именем.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///             Файл, указанный для <paramref name="mapName" /> не существует.
		///           </exception>
		// Token: 0x06001903 RID: 6403 RVA: 0x00054158 File Offset: 0x00052358
		[MonoLimitation("Named mappings scope is process local")]
		public static MemoryMappedFile OpenExisting(string mapName)
		{
			return MemoryMappedFile.OpenExisting(mapName, MemoryMappedFileRights.ReadWrite);
		}

		/// <summary>
		///         Открывает существующий размещенный в памяти файл с заданными именем и правами доступа в системной памяти.
		///       </summary>
		/// <param name="mapName">
		///           Имя размещенного в памяти файла, который необходимо открыть.
		///         </param>
		/// <param name="desiredAccessRights">
		///           Одно из значений перечисления, определяющее права доступа, применяемые к размещенному в памяти файлу.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="desiredAccessRights" /> не является допустимым значением перечисления <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileRights" />.
		///           </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///             Файл, указанный для <paramref name="mapName" /> не существует.
		///           </exception>
		// Token: 0x06001904 RID: 6404 RVA: 0x00054161 File Offset: 0x00052361
		[MonoLimitation("Named mappings scope is process local")]
		public static MemoryMappedFile OpenExisting(string mapName, MemoryMappedFileRights desiredAccessRights)
		{
			return MemoryMappedFile.OpenExisting(mapName, desiredAccessRights, HandleInheritability.None);
		}

		/// <summary>
		///         Открывает существующий размещенный в памяти файл с заданными именем, правами доступа и режимом наследования в системной памяти.
		///       </summary>
		/// <param name="mapName">
		///           Имя размещенного в памяти файла, который необходимо открыть.
		///         </param>
		/// <param name="desiredAccessRights">
		///           Одно из значений перечисления, определяющее права доступа, применяемые к размещенному в памяти файлу.
		///         </param>
		/// <param name="inheritability">
		///           Одно из значений перечисления, определяющее, может ли дескриптор размещенного в памяти файла наследоваться дочерним процессом.
		///            Значение по умолчанию — <see cref="F:System.IO.HandleInheritability.None" />.
		///         </param>
		/// <returns>
		///         Размещенный в памяти файл с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <paramref name="mapName" /> равен пустой строке.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="mapName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="desiredAccessRights" /> не является допустимым значением перечисления <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileRights" />.
		///
		///             -или-
		///
		///             <paramref name="inheritability" /> не является допустимым значением перечисления <see cref="T:System.IO.HandleInheritability" />.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             Запрошенный доступ недопустим для файла размещенный в памяти.
		///           </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///             Файл, указанный для <paramref name="mapName" /> не существует.
		///           </exception>
		// Token: 0x06001905 RID: 6405 RVA: 0x0005416B File Offset: 0x0005236B
		[MonoLimitation("Named mappings scope is process local")]
		public static MemoryMappedFile OpenExisting(string mapName, MemoryMappedFileRights desiredAccessRights, HandleInheritability inheritability)
		{
			return MemoryMappedFile.CoreShmCreate(mapName, 0L, MemoryMappedFileAccess.ReadWrite, MemoryMappedFileOptions.None, null, inheritability, FileMode.Open);
		}

		/// <summary>
		///         Создает поток, который сопоставляется с представлением размещенного в памяти файла.
		///       </summary>
		/// <returns>
		///         Поток памяти.
		///       </returns>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             Доступ к файлу памяти не авторизован.
		///           </exception>
		// Token: 0x06001906 RID: 6406 RVA: 0x0005417A File Offset: 0x0005237A
		public MemoryMappedViewStream CreateViewStream()
		{
			return this.CreateViewStream(0L, 0L);
		}

		/// <summary>
		///         Создает поток, который сопоставляется с представлением размещенного в памяти файла и имеет заданное смещение и размер.
		///       </summary>
		/// <param name="offset">
		///           Байт, с которого должно начинаться представление.
		///         </param>
		/// <param name="size">
		///           Размер представления.
		///            Укажите 0 (ноль), чтобы создать представление, которое начинается с <paramref name="offset" /> и заканчивается приблизительно в конце файла размещенный в памяти.
		///         </param>
		/// <returns>
		///         Поток памяти с заданными смещением и размером.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="offset" /> или <paramref name="size" /> имеет отрицательное значение.
		///
		///             -или-
		///
		///             <paramref name="size" /> больше логического адресного пространства.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             Доступ к файлу памяти не авторизован.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             <paramref name="size" /> больше, чем общий объем виртуальной памяти.
		///           </exception>
		// Token: 0x06001907 RID: 6407 RVA: 0x00054186 File Offset: 0x00052386
		public MemoryMappedViewStream CreateViewStream(long offset, long size)
		{
			return this.CreateViewStream(offset, size, MemoryMappedFileAccess.ReadWrite);
		}

		/// <summary>
		///         Создает поток, который сопоставляется с представлением размещенного в памяти файла и имеет заданное смещение, размер и тип доступа.
		///       </summary>
		/// <param name="offset">
		///           Байт, с которого должно начинаться представление.
		///         </param>
		/// <param name="size">
		///           Размер представления.
		///            Укажите 0 (ноль), чтобы создать представление, которое начинается с <paramref name="offset" /> и заканчивается приблизительно в конце файла размещенный в памяти.
		///         </param>
		/// <param name="access">
		///           Одно из значений перечисления, определяющее разрешенный тип доступа к размещенному в памяти файлу.
		///            Значение по умолчанию — <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />.
		///         </param>
		/// <returns>
		///         Поток памяти с заданными характеристиками.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="offset" /> или <paramref name="size" /> имеет отрицательное значение.
		///
		///             -или-
		///
		///             <paramref name="size" /> больше логического адресного пространства.
		///
		///             -или-
		///
		///             <paramref name="access " />не является допустимым <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" /> значение перечисления.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             <paramref name="access" /> Недопустимый файл отображения памяти.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             <paramref name="size" /> больше, чем общий объем виртуальной памяти.
		///
		///             -или-
		///
		///             <paramref name="access" /> Недопустимый файл отображения памяти.
		///           </exception>
		// Token: 0x06001908 RID: 6408 RVA: 0x00054191 File Offset: 0x00052391
		public MemoryMappedViewStream CreateViewStream(long offset, long size, MemoryMappedFileAccess access)
		{
			return new MemoryMappedViewStream(MemoryMappedView.Create(this.handle.DangerousGetHandle(), offset, size, access));
		}

		/// <summary>
		///         Создает <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedViewAccessor" /> сопоставляется с представлением размещенного в памяти файла.
		///       </summary>
		/// <returns>
		///         Блок оперативной памяти.
		///       </returns>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             Доступ к файлу памяти не авторизован.
		///           </exception>
		// Token: 0x06001909 RID: 6409 RVA: 0x000541AB File Offset: 0x000523AB
		public MemoryMappedViewAccessor CreateViewAccessor()
		{
			return this.CreateViewAccessor(0L, 0L);
		}

		/// <summary>
		///         Создает <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedViewAccessor" /> сопоставляется с представлением размещенного в памяти файла и имеет заданное смещение и размер.
		///       </summary>
		/// <param name="offset">
		///           Байт, с которого должно начинаться представление.
		///         </param>
		/// <param name="size">
		///           Размер представления.
		///            Укажите 0 (ноль), чтобы создать представление, которое начинается с <paramref name="offset" /> и заканчивается приблизительно в конце файла размещенный в памяти.
		///         </param>
		/// <returns>
		///         Блок оперативной памяти.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="offset" /> или <paramref name="size" /> имеет отрицательное значение.
		///
		///             -или-
		///
		///             <paramref name="size" /> больше логического адресного пространства.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             Доступ к файлу памяти не авторизован.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Ошибка ввода/вывода.
		///           </exception>
		// Token: 0x0600190A RID: 6410 RVA: 0x000541B7 File Offset: 0x000523B7
		public MemoryMappedViewAccessor CreateViewAccessor(long offset, long size)
		{
			return this.CreateViewAccessor(offset, size, MemoryMappedFileAccess.ReadWrite);
		}

		/// <summary>
		///         Создает <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedViewAccessor" /> сопоставляется с представлением размещенного в памяти файла и который имеет заданное смещение, размер и ограничения доступа.
		///       </summary>
		/// <param name="offset">
		///           Байт, с которого должно начинаться представление.
		///         </param>
		/// <param name="size">
		///           Размер представления.
		///            Укажите 0 (ноль), чтобы создать представление, которое начинается с <paramref name="offset" /> и заканчивается приблизительно в конце файла размещенный в памяти.
		///         </param>
		/// <param name="access">
		///           Одно из значений перечисления, определяющее разрешенный тип доступа к размещенному в памяти файлу.
		///            Значение по умолчанию — <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />.
		///         </param>
		/// <returns>
		///         Блок оперативной памяти.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="offset" /> или <paramref name="size" /> имеет отрицательное значение.
		///
		///             -или-
		///
		///             <paramref name="size" /> больше логического адресного пространства.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             <paramref name="access" /> Недопустимый файл отображения памяти.
		///           </exception>
		/// <exception cref="T:System.IO.IOException">
		///             Ошибка ввода/вывода.
		///           </exception>
		// Token: 0x0600190B RID: 6411 RVA: 0x000541C2 File Offset: 0x000523C2
		public MemoryMappedViewAccessor CreateViewAccessor(long offset, long size, MemoryMappedFileAccess access)
		{
			return new MemoryMappedViewAccessor(MemoryMappedView.Create(this.handle.DangerousGetHandle(), offset, size, access));
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00002162 File Offset: 0x00000362
		private MemoryMappedFile()
		{
		}

		/// <summary>
		///         Освобождает все ресурсы, занятые модулем <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFile" />.
		///       </summary>
		// Token: 0x0600190D RID: 6413 RVA: 0x000541DC File Offset: 0x000523DC
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>
		///         Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFile" />, а при необходимости освобождает также управляемые ресурсы.
		///       </summary>
		/// <param name="disposing">
		///           Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.
		///         </param>
		// Token: 0x0600190E RID: 6414 RVA: 0x000541E8 File Offset: 0x000523E8
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.stream != null)
			{
				if (!this.keepOpen)
				{
					this.stream.Close();
				}
				this.stream = null;
			}
			if (this.handle != null)
			{
				this.handle.Dispose();
				this.handle = null;
			}
		}

		/// <summary>
		///         Возвращает элемент управления доступом к ресурсу размещенного в памяти файла.
		///       </summary>
		/// <returns>
		///         Разрешения, которые могут быть предоставлены для доступа к файлам и операций с размещенными в памяти файлами.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Внутренний вызов для установки информации о безопасности не удалось.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Внутренний вызов для установки информации о безопасности не удалось.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Размещенный в памяти файл не будет закрыт.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Является ли текущая платформа Windows 98 или более ранней версии.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             Внутренний вызов для установки информации о безопасности не удалось.
		///
		///             -или-
		///
		///             Размещенный в памяти файл был открыт как <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.Write" /> только.
		///           </exception>
		// Token: 0x0600190F RID: 6415 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public MemoryMappedFileSecurity GetAccessControl()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Задает элемент управления доступом к ресурсу размещенного в памяти файла.
		///       </summary>
		/// <param name="memoryMappedFileSecurity">
		///           Разрешения, которые могут быть предоставлены для доступа к файлам и операций с размещенными в памяти файлами.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="memoryMappedFileSecurity" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Внутренний вызов для установки информации о безопасности не удалось.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Внутренний вызов для установки информации о безопасности не удалось.
		///           </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///             Внутренний вызов для установки информации о безопасности не удалось.
		///           </exception>
		// Token: 0x06001910 RID: 6416 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public void SetAccessControl(MemoryMappedFileSecurity memoryMappedFileSecurity)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Возвращает дескриптор размещенного в памяти файла.
		///       </summary>
		/// <returns>
		///         Дескриптор размещенного в памяти файла.
		///       </returns>
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x00054234 File Offset: 0x00052434
		public SafeMemoryMappedFileHandle SafeMemoryMappedFileHandle
		{
			get
			{
				return this.handle;
			}
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0005423C File Offset: 0x0005243C
		internal static FileAccess GetFileAccess(MemoryMappedFileAccess access)
		{
			if (access == MemoryMappedFileAccess.Read)
			{
				return FileAccess.Read;
			}
			if (access == MemoryMappedFileAccess.Write)
			{
				return FileAccess.Write;
			}
			if (access == MemoryMappedFileAccess.ReadWrite)
			{
				return FileAccess.ReadWrite;
			}
			if (access == MemoryMappedFileAccess.CopyOnWrite)
			{
				return FileAccess.ReadWrite;
			}
			if (access == MemoryMappedFileAccess.ReadExecute)
			{
				return FileAccess.Read;
			}
			if (access == MemoryMappedFileAccess.ReadWriteExecute)
			{
				return FileAccess.ReadWrite;
			}
			throw new ArgumentOutOfRangeException("access");
		}

		// Token: 0x04000C08 RID: 3080
		private FileStream stream;

		// Token: 0x04000C09 RID: 3081
		private bool keepOpen;

		// Token: 0x04000C0A RID: 3082
		private SafeMemoryMappedFileHandle handle;
	}
}
