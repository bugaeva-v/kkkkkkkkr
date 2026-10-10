using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO
{
	/// <summary>Предоставляет <see cref="T:System.IO.Stream" /> в файле, поддерживая синхронные и асинхронные операции чтения и записи.</summary>
	// Token: 0x02000B5E RID: 2910
	[ComVisible(true)]
	public class FileStream : Stream
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> для заданного дескриптора файла, используя указанные разрешения на чтение и запись.</summary>
		/// <param name="handle">Дескриптор для файла, являющегося текущим объектом <see langword="FileStream" />, будет инкапсулирован.</param>
		/// <param name="access">Константа, которая задает свойства <see cref="P:System.IO.FileStream.CanRead" /> и <see cref="P:System.IO.FileStream.CanWrite" /> объекта <see langword="FileStream" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="access" /> не является полем <see cref="T:System.IO.FileAccess" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода (например, ошибка диска).  
		/// -или- 
		/// Поток закрыт.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного дескриптора файлов, например, когда <paramref name="access" /> равен <see langword="Write" /> или <see langword="ReadWrite" />, а для дескриптора файлов установлен доступ только для чтения.</exception>
		// Token: 0x06006975 RID: 26997 RVA: 0x001682C3 File Offset: 0x001664C3
		[Obsolete("Use FileStream(SafeFileHandle handle, FileAccess access) instead")]
		public FileStream(IntPtr handle, FileAccess access) : this(handle, access, true, 4096, false, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> для заданного дескриптора файла, используя указанные разрешения на чтение и запись и владельца экземпляра <see langword="FileStream" />.</summary>
		/// <param name="handle">Дескриптор для файла, являющегося текущим объектом <see langword="FileStream" />, будет инкапсулирован.</param>
		/// <param name="access">Константа, которая задает свойства <see cref="P:System.IO.FileStream.CanRead" /> и <see cref="P:System.IO.FileStream.CanWrite" /> объекта <see langword="FileStream" />.</param>
		/// <param name="ownsHandle">Значение <see langword="true" />, если владельцем дескриптора файла будет этот экземпляр <see langword="FileStream" />; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="access" /> не является полем <see cref="T:System.IO.FileAccess" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода (например, ошибка диска).  
		/// -или- 
		/// Поток закрыт.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного дескриптора файлов, например, когда <paramref name="access" /> равен <see langword="Write" /> или <see langword="ReadWrite" />, а для дескриптора файлов установлен доступ только для чтения.</exception>
		// Token: 0x06006976 RID: 26998 RVA: 0x001682D5 File Offset: 0x001664D5
		[Obsolete("Use FileStream(SafeFileHandle handle, FileAccess access) instead")]
		public FileStream(IntPtr handle, FileAccess access, bool ownsHandle) : this(handle, access, ownsHandle, 4096, false, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> для заданного дескриптора файла, используя указанные разрешения на чтение и запись, владельца экземпляра <see langword="FileStream" /> и размер буфера.</summary>
		/// <param name="handle">Дескриптор файла для файла, который будет инкапсулироваться с помощью объекта <see langword="FileStream" />.</param>
		/// <param name="access">Константа, которая задает свойства <see cref="P:System.IO.FileStream.CanRead" /> и <see cref="P:System.IO.FileStream.CanWrite" /> объекта <see langword="FileStream" />.</param>
		/// <param name="ownsHandle">Значение <see langword="true" />, если владельцем дескриптора файла будет этот экземпляр <see langword="FileStream" />; в противном случае — значение <see langword="false" />.</param>
		/// <param name="bufferSize">Положительное значение <see cref="T:System.Int32" />, большее 0, определяющее размер буфера. Размер буфера по умолчанию — 4096.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="bufferSize" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например ошибка диска.  
		///
		/// или - 
		/// Поток был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного дескриптора файлов, например, когда <paramref name="access" /> равен <see langword="Write" /> или <see langword="ReadWrite" />, а для дескриптора файлов установлен доступ только для чтения.</exception>
		// Token: 0x06006977 RID: 26999 RVA: 0x001682E7 File Offset: 0x001664E7
		[Obsolete("Use FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) instead")]
		public FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize) : this(handle, access, ownsHandle, bufferSize, false, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> для заданного дескриптора файла, используя указанные разрешения на чтение и запись, владельца экземпляра <see langword="FileStream" />, размер буфера и синхронное или асинхронное состояние.</summary>
		/// <param name="handle">Дескриптор файла для файла, который будет инкапсулироваться с помощью объекта <see langword="FileStream" />.</param>
		/// <param name="access">Константа, которая задает свойства <see cref="P:System.IO.FileStream.CanRead" /> и <see cref="P:System.IO.FileStream.CanWrite" /> объекта <see langword="FileStream" />.</param>
		/// <param name="ownsHandle">Значение <see langword="true" />, если владельцем дескриптора файла будет этот экземпляр <see langword="FileStream" />; в противном случае — значение <see langword="false" />.</param>
		/// <param name="bufferSize">Положительное значение <see cref="T:System.Int32" />, большее 0, определяющее размер буфера. Размер буфера по умолчанию — 4096.</param>
		/// <param name="isAsync">Значение <see langword="true" />, если этот дескриптор был открыт асинхронно (т. е. в режиме перекрывающегося ввода-вывода); в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="access" /> меньше <see langword="FileAccess.Read" /> или больше <see langword="FileAccess.ReadWrite" />, либо <paramref name="bufferSize" /> не больше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Дескриптор недействителен.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода (например, ошибка диска).  
		///
		/// или - 
		/// Поток был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного дескриптора файлов, например, когда <paramref name="access" /> равен <see langword="Write" /> или <see langword="ReadWrite" />, а для дескриптора файлов установлен доступ только для чтения.</exception>
		// Token: 0x06006978 RID: 27000 RVA: 0x001682F6 File Offset: 0x001664F6
		[Obsolete("Use FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) instead")]
		public FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync) : this(handle, access, ownsHandle, bufferSize, isAsync, false)
		{
		}

		// Token: 0x06006979 RID: 27001 RVA: 0x00168308 File Offset: 0x00166508
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		internal FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
		{
			this.name = "[Unknown]";
			base..ctor();
			if (handle == MonoIO.InvalidHandle)
			{
				throw new ArgumentException("handle", Locale.GetText("Invalid."));
			}
			this.Init(new SafeFileHandle(handle, false), access, ownsHandle, bufferSize, isAsync, isConsoleWrapper);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> указанным путем и режимом создания.</summary>
		/// <param name="path">Абсолютный или относительный путь к файлу, который будет инкапсулироваться объектом <see langword="FileStream" />.</param>
		/// <param name="mode">Константа, определяющая способ открытия или создания файла.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой пустую строку (""), содержащую только пробел или хотя бы один недопустимый символ.  
		///
		/// или - 
		/// <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде NTFS.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д. в среде, отличной от NTFS.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл, например когда <paramref name="mode" /> равно <see langword="FileMode.Truncate" /> или <see langword="FileMode.Open" />, и файл, заданный параметром <paramref name="path" />, не существует. Файл должен уже существовать в этих режимах.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например задание параметра <see langword="FileMode.CreateNew" />, когда файл, заданный параметром <paramref name="path" />, уже существует.  
		/// -или- 
		/// Поток был закрыт.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="mode" /> содержит недопустимое значение.</exception>
		// Token: 0x0600697A RID: 27002 RVA: 0x0016835D File Offset: 0x0016655D
		public FileStream(string path, FileMode mode) : this(path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.Read, 4096, false, FileOptions.None)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> заданным путем, режимом создания и разрешением на чтение и запись.</summary>
		/// <param name="path">Абсолютный или относительный путь к файлу, который будет инкапсулироваться объектом <see langword="FileStream" />.</param>
		/// <param name="mode">Константа, определяющая способ открытия или создания файла.</param>
		/// <param name="access">Константа, определяющая способ доступа к файлу объекта <see langword="FileStream" />. Также определяет значения, возвращаемые свойствами <see cref="P:System.IO.FileStream.CanRead" /> и <see cref="P:System.IO.FileStream.CanWrite" /> объекта <see langword="FileStream" />. Свойство <see cref="P:System.IO.FileStream.CanSeek" /> имеет значение <see langword="true" />, если параметр <paramref name="path" /> задает файл на диске.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой пустую строку (""), содержащую только пробел или хотя бы один недопустимый символ.  
		/// -или- 
		///  <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде NTFS.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> ссылается на устройство не файлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде, отличной от NTFS.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл, например когда <paramref name="mode" /> равно <see langword="FileMode.Truncate" /> или <see langword="FileMode.Open" /> и файл, заданный параметром <paramref name="path" />, не существует. Файл должен уже существовать в этих режимах.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например задание параметра <see langword="FileMode.CreateNew" />, когда файл, заданный параметром <paramref name="path" />, уже существует.  
		/// -или- 
		/// Поток был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного <paramref name="path" />, например когда <paramref name="access" /> равно <see langword="Write" /> или <see langword="ReadWrite" />, а для файла или каталога установлен доступ только для чтения.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="mode" /> содержит недопустимое значение.</exception>
		// Token: 0x0600697B RID: 27003 RVA: 0x00168377 File Offset: 0x00166577
		public FileStream(string path, FileMode mode, FileAccess access) : this(path, mode, access, (access == FileAccess.Write) ? FileShare.None : FileShare.Read, 4096, false, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> заданным путем, режимом создания, разрешением на чтение и запись и разрешением на совместное использование.</summary>
		/// <param name="path">Абсолютный или относительный путь к файлу, который будет инкапсулироваться объектом <see langword="FileStream" />.</param>
		/// <param name="mode">Константа, определяющая способ открытия или создания файла.</param>
		/// <param name="access">Константа, определяющая способ доступа к файлу объекта <see langword="FileStream" />. Также определяет значения, возвращаемые свойствами <see cref="P:System.IO.FileStream.CanRead" /> и <see cref="P:System.IO.FileStream.CanWrite" /> объекта <see langword="FileStream" />. Свойство <see cref="P:System.IO.FileStream.CanSeek" /> имеет значение <see langword="true" />, если параметр <paramref name="path" /> задает файл на диске.</param>
		/// <param name="share">Константа, определяющая способ совместного использования файла процессами.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой пустую строку (""), содержащую только пробел или хотя бы один недопустимый символ.  
		/// -или- 
		///  <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде NTFS.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> ссылается на устройство не файлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде, отличной от NTFS.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл, например когда <paramref name="mode" /> равно <see langword="FileMode.Truncate" /> или <see langword="FileMode.Open" /> и файл, заданный параметром <paramref name="path" />, не существует. Файл должен уже существовать в этих режимах.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например задание параметра <see langword="FileMode.CreateNew" />, когда файл, заданный параметром <paramref name="path" />, уже существует.  
		///
		/// или - 
		/// Система работает под управлением Windows 98 или Windows 98 Second Edition, и для <paramref name="share" /> задано значение <see langword="FileShare.Delete" />.  
		///
		/// -или- 
		/// Поток был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного <paramref name="path" />, например когда <paramref name="access" /> равно <see langword="Write" /> или <see langword="ReadWrite" />, а для файла или каталога установлен доступ только для чтения.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="mode" /> содержит недопустимое значение.</exception>
		// Token: 0x0600697C RID: 27004 RVA: 0x00168391 File Offset: 0x00166591
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share) : this(path, mode, access, share, 4096, false, FileOptions.None)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> заданным путем, режимом создания, разрешениями на чтение и запись и на совместное использование, а также размером буфера.</summary>
		/// <param name="path">Абсолютный или относительный путь к файлу, который будет инкапсулироваться объектом <see langword="FileStream" />.</param>
		/// <param name="mode">Константа, определяющая способ открытия или создания файла.</param>
		/// <param name="access">Константа, определяющая способ доступа к файлу объекта <see langword="FileStream" />. Также определяет значения, возвращаемые свойствами <see cref="P:System.IO.FileStream.CanRead" /> и <see cref="P:System.IO.FileStream.CanWrite" /> объекта <see langword="FileStream" />. Свойство <see cref="P:System.IO.FileStream.CanSeek" /> имеет значение <see langword="true" />, если параметр <paramref name="path" /> задает файл на диске.</param>
		/// <param name="share">Константа, определяющая способ совместного использования файла процессами.</param>
		/// <param name="bufferSize">Положительное значение <see cref="T:System.Int32" />, большее 0, определяющее размер буфера. Размер буфера по умолчанию — 4096.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой пустую строку (""), содержащую только пробел или хотя бы один недопустимый символ.  
		/// -или- 
		///  <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде NTFS.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде, отличной от NTFS.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="bufferSize" /> имеет отрицательное значение или равен нулю.  
		/// -или- 
		///  <paramref name="mode" />, <paramref name="access" /> или <paramref name="share" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл, например когда <paramref name="mode" /> равно <see langword="FileMode.Truncate" /> или <see langword="FileMode.Open" /> и файл, заданный параметром <paramref name="path" />, не существует. Файл должен уже существовать в этих режимах.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например задание параметра <see langword="FileMode.CreateNew" />, когда файл, заданный параметром <paramref name="path" />, уже существует.  
		///
		/// или - 
		/// Система работает под управлением Windows 98 или Windows 98 Second Edition, и для <paramref name="share" /> задано значение <see langword="FileShare.Delete" />.  
		///
		/// -или- 
		/// Поток был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного <paramref name="path" />, например когда <paramref name="access" /> равно <see langword="Write" /> или <see langword="ReadWrite" />, а для файла или каталога установлен доступ только для чтения.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x0600697D RID: 27005 RVA: 0x001683A5 File Offset: 0x001665A5
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) : this(path, mode, access, share, bufferSize, false, FileOptions.None)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> заданным путем, режимом создания, разрешениями на чтение и запись и совместное использование, размером буфера и синхронным или асинхронным состоянием.</summary>
		/// <param name="path">Абсолютный или относительный путь к файлу, который будет инкапсулироваться объектом <see langword="FileStream" />.</param>
		/// <param name="mode">Константа, определяющая способ открытия или создания файла.</param>
		/// <param name="access">Константа, определяющая способ доступа к файлу объекта <see langword="FileStream" />. Также определяет значения, возвращаемые свойствами <see cref="P:System.IO.FileStream.CanRead" /> и <see cref="P:System.IO.FileStream.CanWrite" /> объекта <see langword="FileStream" />. Свойство <see cref="P:System.IO.FileStream.CanSeek" /> имеет значение <see langword="true" />, если параметр <paramref name="path" /> задает файл на диске.</param>
		/// <param name="share">Константа, определяющая способ совместного использования файла процессами.</param>
		/// <param name="bufferSize">Положительное значение <see cref="T:System.Int32" />, большее 0, определяющее размер буфера. Размер буфера по умолчанию — 4096.</param>
		/// <param name="useAsync">Указывает, использовать ли асинхронный ввод-вывод или синхронный ввод-вывод. Однако обратите внимание, что базовая операционная система может не поддерживать асинхронный ввод-вывод, поэтому, когда задается значение <see langword="true" />, дескриптор может быть открыт синхронно в зависимости от платформы. При асинхронном открытии методы <see cref="M:System.IO.FileStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> и <see cref="M:System.IO.FileStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> выполняются лучше при чтении или записи больших объемов, но они могут работать намного медленнее при чтении или записи маленьких объемов данных. Если приложение разработано таким образом, чтобы получить преимущества асинхронного ввода-вывода, установите для параметра <paramref name="useAsync" /> значение <see langword="true" />. При корректном использовании асинхронного ввода-вывода быстродействие приложения может возрасти вплоть до 10 раз, но использование такого режима ввода-вывода без переработки приложения может во столько же раз ухудшить быстродействие.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой пустую строку (""), содержащую только пробел или хотя бы один недопустимый символ.  
		/// -или- 
		///  <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде NTFS.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде, отличной от NTFS.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="bufferSize" /> имеет отрицательное значение или равен нулю.  
		/// -или- 
		///  <paramref name="mode" />, <paramref name="access" /> или <paramref name="share" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл, например когда <paramref name="mode" /> равно <see langword="FileMode.Truncate" /> или <see langword="FileMode.Open" /> и файл, заданный параметром <paramref name="path" />, не существует. Файл должен уже существовать в этих режимах.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например задание параметра <see langword="FileMode.CreateNew" />, когда файл, заданный параметром <paramref name="path" />, уже существует.  
		/// -или- 
		/// Система работает под управлением Windows 98 или Windows 98 Second Edition, и для <paramref name="share" /> задано значение <see langword="FileShare.Delete" />.  
		///
		/// или - 
		/// Поток был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного <paramref name="path" />, например когда <paramref name="access" /> равно <see langword="Write" /> или <see langword="ReadWrite" />, а для файла или каталога установлен доступ только для чтения.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x0600697E RID: 27006 RVA: 0x001683B6 File Offset: 0x001665B6
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) : this(path, mode, access, share, bufferSize, useAsync ? FileOptions.Asynchronous : FileOptions.None)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> заданным путем, режимом создания, разрешениями на чтение, запись и совместное использование, доступом для других FileStreams к этому же файлу, размером буфера и дополнительными параметрами файла.</summary>
		/// <param name="path">Абсолютный или относительный путь к файлу, который будет инкапсулироваться объектом <see langword="FileStream" />.</param>
		/// <param name="mode">Константа, определяющая способ открытия или создания файла.</param>
		/// <param name="access">Константа, определяющая способ доступа к файлу объекта <see langword="FileStream" />. Также определяет значения, возвращаемые свойствами <see cref="P:System.IO.FileStream.CanRead" /> и <see cref="P:System.IO.FileStream.CanWrite" /> объекта <see langword="FileStream" />. Свойство <see cref="P:System.IO.FileStream.CanSeek" /> имеет значение <see langword="true" />, если параметр <paramref name="path" /> задает файл на диске.</param>
		/// <param name="share">Константа, определяющая способ совместного использования файла процессами.</param>
		/// <param name="bufferSize">Положительное значение <see cref="T:System.Int32" />, большее 0, определяющее размер буфера. Размер буфера по умолчанию — 4096.</param>
		/// <param name="options">Значение, задающее дополнительные параметры файла.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой пустую строку (""), содержащую только пробел или хотя бы один недопустимый символ.  
		/// -или- 
		///  <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде NTFS.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде, отличной от NTFS.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="bufferSize" /> имеет отрицательное значение или равен нулю.  
		///
		/// или - 
		/// <paramref name="mode" />, <paramref name="access" /> или <paramref name="share" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл, например когда <paramref name="mode" /> равно <see langword="FileMode.Truncate" /> или <see langword="FileMode.Open" /> и файл, заданный параметром <paramref name="path" />, не существует. Файл должен уже существовать в этих режимах.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например задание параметра <see langword="FileMode.CreateNew" />, когда файл, заданный параметром <paramref name="path" />, уже существует.  
		/// -или- 
		/// Поток был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного <paramref name="path" />, например когда <paramref name="access" /> равно <see langword="Write" /> или <see langword="ReadWrite" />, а для файла или каталога установлен доступ только для чтения.  
		/// -или- 
		///  Для <paramref name="options" /> указан режим <see cref="F:System.IO.FileOptions.Encrypted" />, но в текущей платформе шифрование файлов не поддерживается.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x0600697F RID: 27007 RVA: 0x001683D1 File Offset: 0x001665D1
		public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) : this(path, mode, access, share, bufferSize, false, options)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> для заданного дескриптора файла, используя указанные разрешения на чтение и запись.</summary>
		/// <param name="handle">Дескриптор для файла, являющегося текущим объектом <see langword="FileStream" />, будет инкапсулирован.</param>
		/// <param name="access">Константа, которая задает свойства <see cref="P:System.IO.FileStream.CanRead" /> и <see cref="P:System.IO.FileStream.CanWrite" /> объекта <see langword="FileStream" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="access" /> не является полем <see cref="T:System.IO.FileAccess" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода (например, ошибка диска).  
		/// -или- 
		/// Поток закрыт.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного дескриптора файлов, например, когда <paramref name="access" /> равен <see langword="Write" /> или <see langword="ReadWrite" />, а для дескриптора файлов установлен доступ только для чтения.</exception>
		// Token: 0x06006980 RID: 27008 RVA: 0x001683E3 File Offset: 0x001665E3
		public FileStream(SafeFileHandle handle, FileAccess access) : this(handle, access, 4096, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> для заданного дескриптора файла, используя указанные разрешения на чтение и запись и размер буфера.</summary>
		/// <param name="handle">Дескриптор для файла, являющегося текущим объектом <see langword="FileStream" />, будет инкапсулирован.</param>
		/// <param name="access">Константа <see cref="T:System.IO.FileAccess" />, которая задает свойства <see cref="P:System.IO.FileStream.CanRead" /> и <see cref="P:System.IO.FileStream.CanWrite" /> объекта <see langword="FileStream" />.</param>
		/// <param name="bufferSize">Положительное значение <see cref="T:System.Int32" />, большее 0, определяющее размер буфера. Размер буфера по умолчанию — 4096.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="handle" /> является недопустимым дескриптором.  
		///
		/// или - 
		/// Параметр <paramref name="handle" /> является синхронным дескриптором, но был использован асинхронно.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="bufferSize" /> имеет отрицательное значение.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода (например, ошибка диска).  
		///
		/// или - 
		/// Поток был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного дескриптора файлов, например, когда <paramref name="access" /> равен <see langword="Write" /> или <see langword="ReadWrite" />, а для дескриптора файлов установлен доступ только для чтения.</exception>
		// Token: 0x06006981 RID: 27009 RVA: 0x001683F3 File Offset: 0x001665F3
		public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) : this(handle, access, bufferSize, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> для заданного дескриптора файла, используя указанные разрешения на чтение и запись, размер буфера и синхронное или асинхронное состояние.</summary>
		/// <param name="handle">Дескриптор файла для файла, который будет инкапсулироваться с помощью объекта <see langword="FileStream" />.</param>
		/// <param name="access">Константа, которая задает свойства <see cref="P:System.IO.FileStream.CanRead" /> и <see cref="P:System.IO.FileStream.CanWrite" /> объекта <see langword="FileStream" />.</param>
		/// <param name="bufferSize">Положительное значение <see cref="T:System.Int32" />, большее 0, определяющее размер буфера. Размер буфера по умолчанию — 4096.</param>
		/// <param name="isAsync">Значение <see langword="true" />, если этот дескриптор был открыт асинхронно (т. е. в режиме перекрывающегося ввода-вывода); в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="handle" /> является недопустимым дескриптором.  
		///
		/// или - 
		/// Параметр <paramref name="handle" /> является синхронным дескриптором, но был использован асинхронно.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="bufferSize" /> имеет отрицательное значение.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода (например, ошибка диска).  
		/// -или- 
		/// Поток был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного дескриптора файлов, например, когда <paramref name="access" /> равен <see langword="Write" /> или <see langword="ReadWrite" />, а для дескриптора файлов установлен доступ только для чтения.</exception>
		// Token: 0x06006982 RID: 27010 RVA: 0x001683FF File Offset: 0x001665FF
		public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync)
		{
			this.name = "[Unknown]";
			base..ctor();
			this.Init(handle, access, false, bufferSize, isAsync, false);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> заданным путем, режимом создания, разрешениями на чтение, запись и совместное использование, размером буфера и дополнительными параметрами файла.</summary>
		/// <param name="path">Абсолютный или относительный путь к файлу, который будет инкапсулироваться объектом <see cref="T:System.IO.FileStream" />.</param>
		/// <param name="mode">Константа, определяющая способ открытия или создания файла.</param>
		/// <param name="rights">Константа, определяющая права доступа, используемые при создании правил доступа и аудита для файла.</param>
		/// <param name="share">Константа, определяющая способ совместного использования файла процессами.</param>
		/// <param name="bufferSize">Положительное значение <see cref="T:System.Int32" />, большее 0, определяющее размер буфера. Размер буфера по умолчанию — 4096.</param>
		/// <param name="options">Константа, задающая дополнительные параметры файла.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой пустую строку (""), содержащую только пробел или хотя бы один недопустимый символ.  
		/// -или- 
		///  <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде NTFS.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде, отличной от NTFS.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="bufferSize" /> имеет отрицательное значение или равен нулю.  
		///
		/// или - 
		/// <paramref name="mode" />, <paramref name="access" /> или <paramref name="share" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл, например когда <paramref name="mode" /> равно <see langword="FileMode.Truncate" /> или <see langword="FileMode.Open" /> и файл, заданный параметром <paramref name="path" />, не существует. Файл должен уже существовать в этих режимах.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версией.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например задание параметра <see langword="FileMode.CreateNew" />, когда файл, заданный параметром <paramref name="path" />, уже существует.  
		///
		/// или - 
		/// Поток был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного <paramref name="path" />, например когда <paramref name="access" /> равно <see langword="Write" /> или <see langword="ReadWrite" />, а для файла или каталога установлен доступ только для чтения.  
		/// -или- 
		///  Для <paramref name="options" /> указан режим <see cref="F:System.IO.FileOptions.Encrypted" />, но в текущей платформе шифрование файлов не поддерживается.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный <paramref name="path" />, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x06006983 RID: 27011 RVA: 0x0016841F File Offset: 0x0016661F
		[MonoLimitation("This ignores the rights parameter")]
		public FileStream(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options) : this(path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, share, bufferSize, false, options)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileStream" /> заданными путем, режимом создания, правами на доступ и совместное использование, размером буфера, дополнительными параметрами файла, управлением доступом и аудитом безопасности.</summary>
		/// <param name="path">Абсолютный или относительный путь к файлу, который будет инкапсулироваться объектом <see cref="T:System.IO.FileStream" />.</param>
		/// <param name="mode">Константа, определяющая способ открытия или создания файла.</param>
		/// <param name="rights">Константа, определяющая права доступа, используемые при создании правил доступа и аудита для файла.</param>
		/// <param name="share">Константа, определяющая способ совместного использования файла процессами.</param>
		/// <param name="bufferSize">Положительное значение <see cref="T:System.Int32" />, большее 0, определяющее размер буфера. Размер буфера по умолчанию — 4096.</param>
		/// <param name="options">Константа, задающая дополнительные параметры файла.</param>
		/// <param name="fileSecurity">Константа, определяющая систему безопасности управления доступом и аудита доступа для файла.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой пустую строку (""), содержащую только пробел или хотя бы один недопустимый символ.  
		/// -или- 
		///  <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде NTFS.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> ссылается на устройство нефайлового типа, например "con:", "com1:", "lpt1:" и т. д., в среде, отличной от NTFS.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="bufferSize" /> имеет отрицательное значение или равен нулю.  
		///
		/// или - 
		/// <paramref name="mode" />, <paramref name="access" /> или <paramref name="share" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл, например когда <paramref name="mode" /> равно <see langword="FileMode.Truncate" /> или <see langword="FileMode.Open" /> и файл, заданный параметром <paramref name="path" />, не существует. Файл должен уже существовать в этих режимах.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода, например задание параметра <see langword="FileMode.CreateNew" />, когда файл, заданный параметром <paramref name="path" />, уже существует.  
		/// -или- 
		/// Поток был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Запрошенный <paramref name="access" /> не поддерживается операционной системой для указанного <paramref name="path" />, например когда <paramref name="access" /> равно <see langword="Write" /> или <see langword="ReadWrite" />, а для файла или каталога установлен доступ только для чтения.  
		/// -или- 
		///  Для <paramref name="options" /> указан режим <see cref="F:System.IO.FileOptions.Encrypted" />, но в текущей платформе шифрование файлов не поддерживается.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный <paramref name="path" />, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версией.</exception>
		// Token: 0x06006984 RID: 27012 RVA: 0x0016841F File Offset: 0x0016661F
		[MonoLimitation("This ignores the rights and fileSecurity parameters")]
		public FileStream(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, FileSecurity fileSecurity) : this(path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, share, bufferSize, false, options)
		{
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x001683D1 File Offset: 0x001665D1
		internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy, bool useLongPath = false, bool checkHost = false) : this(path, mode, access, share, bufferSize, false, options)
		{
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x00168438 File Offset: 0x00166638
		internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) : this(path, mode, access, share, bufferSize, anonymous, isAsync ? FileOptions.Asynchronous : FileOptions.None)
		{
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x00168458 File Offset: 0x00166658
		internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options)
		{
			this.name = "[Unknown]";
			base..ctor();
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Length == 0)
			{
				throw new ArgumentException("Path is empty");
			}
			this.anonymous = anonymous;
			share &= ~FileShare.Inheritable;
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize", "Positive number required.");
			}
			if (mode < FileMode.CreateNew || mode > FileMode.Append)
			{
				throw new ArgumentOutOfRangeException("mode", "Enum value was out of legal range.");
			}
			if (access < FileAccess.Read || access > FileAccess.ReadWrite)
			{
				throw new ArgumentOutOfRangeException("access", "Enum value was out of legal range.");
			}
			if (share < FileShare.None || share > (FileShare.Read | FileShare.Write | FileShare.Delete))
			{
				throw new ArgumentOutOfRangeException("share", "Enum value was out of legal range.");
			}
			if (path.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException("Name has invalid chars");
			}
			path = Path.InsecureGetFullPath(path);
			if (Directory.Exists(path))
			{
				throw new UnauthorizedAccessException(string.Format(Locale.GetText("Access to the path '{0}' is denied."), this.GetSecureFileName(path, false)));
			}
			if (mode == FileMode.Append && (access & FileAccess.Read) == FileAccess.Read)
			{
				throw new ArgumentException("Append access can be requested only in write-only mode.");
			}
			if ((access & FileAccess.Write) == (FileAccess)0 && mode != FileMode.Open && mode != FileMode.OpenOrCreate)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Combining FileMode: {0} with FileAccess: {1} is invalid."), access, mode));
			}
			string directoryName = Path.GetDirectoryName(path);
			if (directoryName.Length > 0 && !Directory.Exists(Path.GetFullPath(directoryName)))
			{
				string text = Locale.GetText("Could not find a part of the path \"{0}\".");
				string arg = anonymous ? directoryName : Path.GetFullPath(path);
				throw new DirectoryNotFoundException(string.Format(text, arg));
			}
			if (!anonymous)
			{
				this.name = path;
			}
			MonoIOError error;
			IntPtr intPtr = MonoIO.Open(path, mode, access, share, options, out error);
			if (intPtr == MonoIO.InvalidHandle)
			{
				throw MonoIO.GetException(this.GetSecureFileName(path), error);
			}
			this.safeHandle = new SafeFileHandle(intPtr, false);
			this.access = access;
			this.owner = true;
			if (MonoIO.GetFileType(this.safeHandle, out error) == MonoFileType.Disk)
			{
				this.canseek = true;
				this.async = ((options & FileOptions.Asynchronous) > FileOptions.None);
			}
			else
			{
				this.canseek = false;
				this.async = false;
			}
			if (access == FileAccess.Read && this.canseek && bufferSize == 4096)
			{
				long length = this.Length;
				if ((long)bufferSize > length)
				{
					bufferSize = (int)((length < 1000L) ? 1000L : length);
				}
			}
			this.InitBuffer(bufferSize, false);
			if (mode == FileMode.Append)
			{
				this.Seek(0L, SeekOrigin.End);
				this.append_startpos = this.Position;
				return;
			}
			this.append_startpos = 0L;
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x001686C0 File Offset: 0x001668C0
		private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
		{
			if (!isConsoleWrapper && safeHandle.IsInvalid)
			{
				throw new ArgumentException(Environment.GetResourceString("Invalid handle."), "handle");
			}
			if (access < FileAccess.Read || access > FileAccess.ReadWrite)
			{
				throw new ArgumentOutOfRangeException("access");
			}
			if (!isConsoleWrapper && bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize", Environment.GetResourceString("Positive number required."));
			}
			MonoIOError monoIOError;
			MonoFileType fileType = MonoIO.GetFileType(safeHandle, out monoIOError);
			if (monoIOError != MonoIOError.ERROR_SUCCESS)
			{
				throw MonoIO.GetException(this.name, monoIOError);
			}
			if (fileType == MonoFileType.Unknown)
			{
				throw new IOException("Invalid handle.");
			}
			if (fileType == MonoFileType.Disk)
			{
				this.canseek = true;
			}
			else
			{
				this.canseek = false;
			}
			this.safeHandle = safeHandle;
			this.ExposeHandle();
			this.access = access;
			this.owner = ownsHandle;
			this.async = isAsync;
			this.anonymous = false;
			if (this.canseek)
			{
				this.buf_start = MonoIO.Seek(safeHandle, 0L, SeekOrigin.Current, out monoIOError);
				if (monoIOError != MonoIOError.ERROR_SUCCESS)
				{
					throw MonoIO.GetException(this.name, monoIOError);
				}
			}
			this.append_startpos = 0L;
		}

		/// <summary>Получает значение, указывающее, поддерживает ли текущий поток чтение.</summary>
		/// <returns>Значение <see langword="true" />, если в потоке поддерживаются операции чтения; значение <see langword="false" />, если поток закрыт или открыт только для записи.</returns>
		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x06006989 RID: 27017 RVA: 0x001687B5 File Offset: 0x001669B5
		public override bool CanRead
		{
			get
			{
				return this.access == FileAccess.Read || this.access == FileAccess.ReadWrite;
			}
		}

		/// <summary>Получает значение, указывающее, поддерживает ли текущий поток запись.</summary>
		/// <returns>Значение <see langword="true" />, если поток поддерживает операции записи; значение <see langword="false" />, если поток закрыт или открыт только для чтения.</returns>
		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x0600698A RID: 27018 RVA: 0x001687CB File Offset: 0x001669CB
		public override bool CanWrite
		{
			get
			{
				return this.access == FileAccess.Write || this.access == FileAccess.ReadWrite;
			}
		}

		/// <summary>Получает значение, указывающее, поддерживает ли текущий поток поиск.</summary>
		/// <returns>Значение <see langword="true" />, если поток поддерживает поиск; значение <see langword="false" />, если поток закрыт или если <see langword="FileStream" /> был сконструирован из дескриптора операционной системы, такого как канал или вывод на консоль.</returns>
		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x0600698B RID: 27019 RVA: 0x001687E1 File Offset: 0x001669E1
		public override bool CanSeek
		{
			get
			{
				return this.canseek;
			}
		}

		/// <summary>Получает значение, указывающее, как был открыт <see langword="FileStream" />: синхронно или асинхронно.</summary>
		/// <returns>Значение <see langword="true" />, если <see langword="FileStream" /> был открыт асинхронно, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x0600698C RID: 27020 RVA: 0x001687E9 File Offset: 0x001669E9
		public virtual bool IsAsync
		{
			get
			{
				return this.async;
			}
		}

		/// <summary>Получает абсолютный путь к файлу, открытому в функции <see langword="FileStream" />.</summary>
		/// <returns>Строка, — это абсолютный путь файла.</returns>
		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x0600698D RID: 27021 RVA: 0x001687F1 File Offset: 0x001669F1
		public virtual string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Возвращает длину потока в байтах.</summary>
		/// <returns>Длинное значение, представляющее длину потока в байтах.</returns>
		/// <exception cref="T:System.NotSupportedException">Параметр <see cref="P:System.IO.FileStream.CanSeek" /> для этого потока имеет значение <see langword="false" />.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода (например, файл закрывается).</exception>
		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x0600698E RID: 27022 RVA: 0x001687FC File Offset: 0x001669FC
		public override long Length
		{
			get
			{
				if (this.safeHandle.IsClosed)
				{
					throw new ObjectDisposedException("Stream has been closed");
				}
				if (!this.CanSeek)
				{
					throw new NotSupportedException("The stream does not support seeking");
				}
				this.FlushBufferIfDirty();
				MonoIOError monoIOError;
				long length = MonoIO.GetLength(this.safeHandle, out monoIOError);
				if (monoIOError != MonoIOError.ERROR_SUCCESS)
				{
					throw MonoIO.GetException(this.GetSecureFileName(this.name), monoIOError);
				}
				return length;
			}
		}

		/// <summary>Возвращает или задает текущую позицию этого потока.</summary>
		/// <returns>Текущая позиция потока.</returns>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает поиск.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.  
		/// -или- 
		/// Для положения задано очень большое значение за пределами конца потока в Windows 98 или более ранней версии.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Попытка установить для положения отрицательное значение.</exception>
		/// <exception cref="T:System.IO.EndOfStreamException">Попытка поиска за пределами потока, который не поддерживает это.</exception>
		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x0600698F RID: 27023 RVA: 0x00168860 File Offset: 0x00166A60
		// (set) Token: 0x06006990 RID: 27024 RVA: 0x001688D5 File Offset: 0x00166AD5
		public override long Position
		{
			get
			{
				if (this.safeHandle.IsClosed)
				{
					throw new ObjectDisposedException("Stream has been closed");
				}
				if (!this.CanSeek)
				{
					throw new NotSupportedException("The stream does not support seeking");
				}
				if (!this.isExposed)
				{
					return this.buf_start + (long)this.buf_offset;
				}
				MonoIOError monoIOError;
				long result = MonoIO.Seek(this.safeHandle, 0L, SeekOrigin.Current, out monoIOError);
				if (monoIOError != MonoIOError.ERROR_SUCCESS)
				{
					throw MonoIO.GetException(this.GetSecureFileName(this.name), monoIOError);
				}
				return result;
			}
			set
			{
				if (value < 0L)
				{
					throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("Non-negative number required."));
				}
				this.Seek(value, SeekOrigin.Begin);
			}
		}

		/// <summary>Возвращает дескриптор файла операционной системы для файла, инкапсулируемого текущим объектом <see langword="FileStream" />.</summary>
		/// <returns>Дескриптор файла операционной системы для файла, инкапсулируемого этим объектом <see langword="FileStream" />, или значение -1, если объект <see langword="FileStream" /> закрыт.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06006991 RID: 27025 RVA: 0x001688FA File Offset: 0x00166AFA
		[Obsolete("Use SafeFileHandle instead")]
		public virtual IntPtr Handle
		{
			[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
			[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
			get
			{
				IntPtr result = this.safeHandle.DangerousGetHandle();
				if (!this.isExposed)
				{
					this.ExposeHandle();
				}
				return result;
			}
		}

		/// <summary>Возвращает объект <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle" />, представляющий дескриптор файла операционной системы для файла, инкапсулируемого текущим объектом <see cref="T:System.IO.FileStream" />.</summary>
		/// <returns>Объект, представляющий дескриптор файла операционной системы для файла, инкапсулируемого текущим объектом <see cref="T:System.IO.FileStream" />.</returns>
		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06006992 RID: 27026 RVA: 0x00168915 File Offset: 0x00166B15
		public virtual SafeFileHandle SafeFileHandle
		{
			[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
			[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
			get
			{
				if (!this.isExposed)
				{
					this.ExposeHandle();
				}
				return this.safeHandle;
			}
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x0016892B File Offset: 0x00166B2B
		private void ExposeHandle()
		{
			this.isExposed = true;
			this.FlushBuffer();
			this.InitBuffer(0, true);
		}

		/// <summary>Считывает байт из файла и перемещает положение чтения на один байт.</summary>
		/// <returns>Байт приводится к типу <see cref="T:System.Int32" /> или -1, если достигнут конец потока.</returns>
		/// <exception cref="T:System.NotSupportedException">Текущий поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий поток закрыт.</exception>
		// Token: 0x06006994 RID: 27028 RVA: 0x00168944 File Offset: 0x00166B44
		public override int ReadByte()
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			if (!this.CanRead)
			{
				throw new NotSupportedException("Stream does not support reading");
			}
			if (this.buf_size != 0)
			{
				if (this.buf_offset >= this.buf_length)
				{
					this.RefillBuffer();
					if (this.buf_length == 0)
					{
						return -1;
					}
				}
				byte[] array = this.buf;
				int num = this.buf_offset;
				this.buf_offset = num + 1;
				return array[num];
			}
			if (this.ReadData(this.safeHandle, this.buf, 0, 1) == 0)
			{
				return -1;
			}
			return (int)this.buf[0];
		}

		/// <summary>Запись байта в текущую позицию в потоке файла.</summary>
		/// <param name="value">Байт, который необходимо записать в поток.</param>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись.</exception>
		// Token: 0x06006995 RID: 27029 RVA: 0x001689DC File Offset: 0x00166BDC
		public override void WriteByte(byte value)
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			if (!this.CanWrite)
			{
				throw new NotSupportedException("Stream does not support writing");
			}
			if (this.buf_offset == this.buf_size)
			{
				this.FlushBuffer();
			}
			if (this.buf_size == 0)
			{
				this.buf[0] = value;
				this.buf_dirty = true;
				this.buf_length = 1;
				this.FlushBuffer();
				return;
			}
			byte[] array = this.buf;
			int num = this.buf_offset;
			this.buf_offset = num + 1;
			array[num] = value;
			if (this.buf_offset > this.buf_length)
			{
				this.buf_length = this.buf_offset;
			}
			this.buf_dirty = true;
		}

		/// <summary>Выполняет чтение блока байтов из потока и запись данных в заданный буфер.</summary>
		/// <param name="array">Когда этот метод возвращает управление, он содержит указанный массив байтов, в котором значения между <paramref name="offset" /> и (<paramref name="offset" /> + <paramref name="count" /> - 1) заменены байтами, считанными из текущего источника.</param>
		/// <param name="offset">Смещение в байтах в массиве <paramref name="array" />, в который будут помещены считанные байты.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <returns>Общее количество байтов, считанных в буфер. Оно может быть меньше запрошенного числа байтов, если в настоящее время не имеется нужного количества байтов, или же равно нулю, если достигнут конец потока.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset" /> и <paramref name="count" /> описывают недопустимый диапазон в <paramref name="array" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x06006996 RID: 27030 RVA: 0x00168A88 File Offset: 0x00166C88
		public override int Read([In] [Out] byte[] array, int offset, int count)
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (!this.CanRead)
			{
				throw new NotSupportedException("Stream does not support reading");
			}
			int num = array.Length;
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "< 0");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "< 0");
			}
			if (offset > num)
			{
				throw new ArgumentException("destination offset is beyond array size");
			}
			if (offset > num - count)
			{
				throw new ArgumentException("Reading would overrun buffer");
			}
			if (this.async)
			{
				IAsyncResult asyncResult = this.BeginRead(array, offset, count, null, null);
				return this.EndRead(asyncResult);
			}
			return this.ReadInternal(array, offset, count);
		}

		// Token: 0x06006997 RID: 27031 RVA: 0x00168B40 File Offset: 0x00166D40
		private int ReadInternal(byte[] dest, int offset, int count)
		{
			int num = this.ReadSegment(dest, offset, count);
			if (num == count)
			{
				return count;
			}
			int num2 = num;
			count -= num;
			if (count > this.buf_size)
			{
				this.FlushBuffer();
				num = this.ReadData(this.safeHandle, dest, offset + num, count);
				this.buf_start += (long)num;
			}
			else
			{
				this.RefillBuffer();
				num = this.ReadSegment(dest, offset + num2, count);
			}
			return num2 + num;
		}

		/// <summary>Начинает операцию асинхронного чтения. Вместо этого рекомендуется использовать <see cref="M:System.IO.FileStream.ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" />.</summary>
		/// <param name="array">Буфер, в который должны считываться данные.</param>
		/// <param name="offset">Смещение в <paramref name="array" /> (в байтах), с которого начинается чтение.</param>
		/// <param name="numBytes">Максимальное число байтов, предназначенных для чтения.</param>
		/// <param name="userCallback">Метод, вызываемый после завершения операции асинхронного чтения.</param>
		/// <param name="stateObject">Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного запроса на асинхронное чтение от других запросов.</param>
		/// <returns>Объект, который ссылается на асинхронное чтение.</returns>
		/// <exception cref="T:System.ArgumentException">Длина массива минус <paramref name="offset" /> меньше <paramref name="numBytes" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="numBytes" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.IO.IOException">Предпринята попытка асинхронного чтения за пределами файла.</exception>
		// Token: 0x06006998 RID: 27032 RVA: 0x00168BAC File Offset: 0x00166DAC
		public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			if (!this.CanRead)
			{
				throw new NotSupportedException("This stream does not support reading");
			}
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (numBytes < 0)
			{
				throw new ArgumentOutOfRangeException("numBytes", "Must be >= 0");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Must be >= 0");
			}
			if (numBytes > array.Length - offset)
			{
				throw new ArgumentException("Buffer too small. numBytes/offset wrong.");
			}
			if (!this.async)
			{
				return base.BeginRead(array, offset, numBytes, userCallback, stateObject);
			}
			return new FileStream.ReadDelegate(this.ReadInternal).BeginInvoke(array, offset, numBytes, userCallback, stateObject);
		}

		/// <summary>Ожидает завершения отложенной асинхронной операции чтения. (Рекомендуется использовать <see cref="M:System.IO.FileStream.ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" />.)</summary>
		/// <param name="asyncResult">Ссылка на ожидаемый отложенный асинхронный запрос.</param>
		/// <returns>Число байтов, считанных из потока, находится между 0 и числом запрошенных байтов. Потоки возвращают 0 только в конце потока, в противном случае они должны блокироваться, пока не будет доступен по крайней мере 1 байт.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Этот объект <see cref="T:System.IAsyncResult" /> не был создан путем вызова <see cref="M:System.IO.FileStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> для данного класса.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.IO.FileStream.EndRead(System.IAsyncResult)" /> вызывается несколько раз.</exception>
		/// <exception cref="T:System.IO.IOException">Поток закрыт, или произошла внутренняя ошибка.</exception>
		// Token: 0x06006999 RID: 27033 RVA: 0x00168C5C File Offset: 0x00166E5C
		public override int EndRead(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!this.async)
			{
				return base.EndRead(asyncResult);
			}
			AsyncResult asyncResult2 = asyncResult as AsyncResult;
			if (asyncResult2 == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			FileStream.ReadDelegate readDelegate = asyncResult2.AsyncDelegate as FileStream.ReadDelegate;
			if (readDelegate == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			return readDelegate.EndInvoke(asyncResult);
		}

		/// <summary>Записывает блок байтов в файловый поток.</summary>
		/// <param name="array">Буфер, содержащий данные для записи в поток.</param>
		/// <param name="offset">Смещение байтов (начиная с нуля) в объекте <paramref name="array" />, с которого начинается копирование байтов в поток.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset" /> и <paramref name="count" /> описывают недопустимый диапазон в <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.  
		///
		/// или - 
		/// Возможно, другой поток вызвал непредвиденное изменение положения дескриптора файла операционной системы.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий экземпляр потока не поддерживает запись.</exception>
		// Token: 0x0600699A RID: 27034 RVA: 0x00168CC4 File Offset: 0x00166EC4
		public override void Write(byte[] array, int offset, int count)
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "< 0");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "< 0");
			}
			if (offset > array.Length - count)
			{
				throw new ArgumentException("Reading would overrun buffer");
			}
			if (!this.CanWrite)
			{
				throw new NotSupportedException("Stream does not support writing");
			}
			if (this.async)
			{
				IAsyncResult asyncResult = this.BeginWrite(array, offset, count, null, null);
				this.EndWrite(asyncResult);
				return;
			}
			this.WriteInternal(array, offset, count);
		}

		// Token: 0x0600699B RID: 27035 RVA: 0x00168D6C File Offset: 0x00166F6C
		private void WriteInternal(byte[] src, int offset, int count)
		{
			if (count > this.buf_size)
			{
				this.FlushBuffer();
				if (this.CanSeek && !this.isExposed)
				{
					MonoIOError monoIOError;
					MonoIO.Seek(this.safeHandle, this.buf_start, SeekOrigin.Begin, out monoIOError);
					if (monoIOError != MonoIOError.ERROR_SUCCESS)
					{
						throw MonoIO.GetException(this.GetSecureFileName(this.name), monoIOError);
					}
				}
				int i = count;
				while (i > 0)
				{
					MonoIOError monoIOError;
					int num = MonoIO.Write(this.safeHandle, src, offset, i, out monoIOError);
					if (monoIOError != MonoIOError.ERROR_SUCCESS)
					{
						throw MonoIO.GetException(this.GetSecureFileName(this.name), monoIOError);
					}
					i -= num;
					offset += num;
				}
				this.buf_start += (long)count;
				return;
			}
			int num2 = 0;
			while (count > 0)
			{
				int num3 = this.WriteSegment(src, offset + num2, count);
				num2 += num3;
				count -= num3;
				if (count == 0)
				{
					break;
				}
				this.FlushBuffer();
			}
		}

		/// <summary>Начинает операцию асинхронной записи. Вместо этого рекомендуется использовать <see cref="M:System.IO.FileStream.WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" />.</summary>
		/// <param name="array">Буфер, содержащий данные для записи в текущий поток.</param>
		/// <param name="offset">Отсчитываемое от нуля смещение байтов в буфере <paramref name="array" />, с которого начинается копирование байтов в текущий поток.</param>
		/// <param name="numBytes">Максимальное число байтов для записи.</param>
		/// <param name="userCallback">Метод, вызываемый после завершения операции асинхронной записи.</param>
		/// <param name="stateObject">Предоставляемый пользователем объект, являющийся отличительным признаком данного конкретного запроса на асинхронную запись от других запросов.</param>
		/// <returns>Объект, который ссылается на асинхронную запись.</returns>
		/// <exception cref="T:System.ArgumentException">Длина массива <paramref name="array" /> минус <paramref name="offset" /> меньше <paramref name="numBytes" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="numBytes" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x0600699C RID: 27036 RVA: 0x00168E38 File Offset: 0x00167038
		public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			if (!this.CanWrite)
			{
				throw new NotSupportedException("This stream does not support writing");
			}
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (numBytes < 0)
			{
				throw new ArgumentOutOfRangeException("numBytes", "Must be >= 0");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Must be >= 0");
			}
			if (numBytes > array.Length - offset)
			{
				throw new ArgumentException("array too small. numBytes/offset wrong.");
			}
			if (!this.async)
			{
				return base.BeginWrite(array, offset, numBytes, userCallback, stateObject);
			}
			FileStreamAsyncResult fileStreamAsyncResult = new FileStreamAsyncResult(userCallback, stateObject);
			fileStreamAsyncResult.BytesRead = -1;
			fileStreamAsyncResult.Count = numBytes;
			fileStreamAsyncResult.OriginalCount = numBytes;
			return new FileStream.WriteDelegate(this.WriteInternal).BeginInvoke(array, offset, numBytes, userCallback, stateObject);
		}

		/// <summary>Завершает асинхронную операцию записи и блокирует до тех пор, пока не будет завершена операция ввода-вывода. (Рекомендуется использовать <see cref="M:System.IO.FileStream.WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" />.)</summary>
		/// <param name="asyncResult">Отложенный асинхронный запрос ввода-вывода.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Этот объект <see cref="T:System.IAsyncResult" /> не был создан путем вызова <see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> для данного класса.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.IO.FileStream.EndWrite(System.IAsyncResult)" /> вызывается несколько раз.</exception>
		/// <exception cref="T:System.IO.IOException">Поток закрыт, или произошла внутренняя ошибка.</exception>
		// Token: 0x0600699D RID: 27037 RVA: 0x00168F04 File Offset: 0x00167104
		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!this.async)
			{
				base.EndWrite(asyncResult);
				return;
			}
			AsyncResult asyncResult2 = asyncResult as AsyncResult;
			if (asyncResult2 == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			FileStream.WriteDelegate writeDelegate = asyncResult2.AsyncDelegate as FileStream.WriteDelegate;
			if (writeDelegate == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			writeDelegate.EndInvoke(asyncResult);
		}

		/// <summary>Устанавливает текущее положение этого потока на заданное значение.</summary>
		/// <param name="offset">Указатель относительно начальной точки <paramref name="origin" />, от которой начинается поиск.</param>
		/// <param name="origin">Задает начальную, конечную или текущую позицию как опорную точку для <paramref name="offset" />, используя значение типа <see cref="T:System.IO.SeekOrigin" />.</param>
		/// <returns>Новая позиция в потоке.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает поиск, например, если <see langword="FileStream" /> создан на основе вывода консоли или канала.</exception>
		/// <exception cref="T:System.ArgumentException">Попытка поиска выполняется до начала потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Методы были вызваны после закрытия потока.</exception>
		// Token: 0x0600699E RID: 27038 RVA: 0x00168F6C File Offset: 0x0016716C
		public override long Seek(long offset, SeekOrigin origin)
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			if (!this.CanSeek)
			{
				throw new NotSupportedException("The stream does not support seeking");
			}
			long num;
			switch (origin)
			{
			case SeekOrigin.Begin:
				num = offset;
				break;
			case SeekOrigin.Current:
				num = this.Position + offset;
				break;
			case SeekOrigin.End:
				num = this.Length + offset;
				break;
			default:
				throw new ArgumentException("origin", "Invalid SeekOrigin");
			}
			if (num < 0L)
			{
				throw new IOException("Attempted to Seek before the beginning of the stream");
			}
			if (num < this.append_startpos)
			{
				throw new IOException("Can't seek back over pre-existing data in append mode");
			}
			this.FlushBuffer();
			MonoIOError monoIOError;
			this.buf_start = MonoIO.Seek(this.safeHandle, num, SeekOrigin.Begin, out monoIOError);
			if (monoIOError != MonoIOError.ERROR_SUCCESS)
			{
				throw MonoIO.GetException(this.GetSecureFileName(this.name), monoIOError);
			}
			return this.buf_start;
		}

		/// <summary>Устанавливает длину этого потока на заданное значение.</summary>
		/// <param name="value">Новая длина потока.</param>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись и поиск.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Предпринята попытка установить для параметра <paramref name="value" /> значение меньше 0.</exception>
		// Token: 0x0600699F RID: 27039 RVA: 0x00169040 File Offset: 0x00167240
		public override void SetLength(long value)
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			if (!this.CanSeek)
			{
				throw new NotSupportedException("The stream does not support seeking");
			}
			if (!this.CanWrite)
			{
				throw new NotSupportedException("The stream does not support writing");
			}
			if (value < 0L)
			{
				throw new ArgumentOutOfRangeException("value is less than 0");
			}
			this.FlushBuffer();
			MonoIOError monoIOError;
			MonoIO.SetLength(this.safeHandle, value, out monoIOError);
			if (monoIOError != MonoIOError.ERROR_SUCCESS)
			{
				throw MonoIO.GetException(this.GetSecureFileName(this.name), monoIOError);
			}
			if (this.Position > value)
			{
				this.Position = value;
			}
		}

		/// <summary>Очищает буферы для этого потока и вызывает запись всех буферизованных данных в файл.</summary>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x060069A0 RID: 27040 RVA: 0x001690D6 File Offset: 0x001672D6
		public override void Flush()
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			this.FlushBuffer();
		}

		/// <summary>Очищает буферы для этого потока и вызывает запись всех буферизованных данных в файл, а также очищает все буферы промежуточных файлов.</summary>
		/// <param name="flushToDisk">Значение <see langword="true" /> для записи на диск  буферов всех промежуточных файлов; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060069A1 RID: 27041 RVA: 0x001690F8 File Offset: 0x001672F8
		public virtual void Flush(bool flushToDisk)
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			this.FlushBuffer();
			if (flushToDisk)
			{
				MonoIOError monoIOError;
				MonoIO.Flush(this.safeHandle, out monoIOError);
			}
		}

		/// <summary>Запрещает другим процессам чтение объекта <see cref="T:System.IO.FileStream" /> и запись в этот объект.</summary>
		/// <param name="position">Начало диапазона для блокировки. Значение этого параметра должно быть больше или равно нулю (0).</param>
		/// <param name="length">Диапазон, который нужно блокировать.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> или <paramref name="length" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Файл закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Процессу не удается получить доступ к файлу, так как другой процесс заблокировал часть этого файла.</exception>
		// Token: 0x060069A2 RID: 27042 RVA: 0x00169134 File Offset: 0x00167334
		public virtual void Lock(long position, long length)
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			if (position < 0L)
			{
				throw new ArgumentOutOfRangeException("position must not be negative");
			}
			if (length < 0L)
			{
				throw new ArgumentOutOfRangeException("length must not be negative");
			}
			MonoIOError monoIOError;
			MonoIO.Lock(this.safeHandle, position, length, out monoIOError);
			if (monoIOError != MonoIOError.ERROR_SUCCESS)
			{
				throw MonoIO.GetException(this.GetSecureFileName(this.name), monoIOError);
			}
		}

		/// <summary>Разрешает доступ других процессов ко всему ранее заблокированному файлу или его части.</summary>
		/// <param name="position">Начало диапазона, который должен быть разблокирован.</param>
		/// <param name="length">Диапазон, который должен быть разблокирован.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> или <paramref name="length" /> является отрицательным значением.</exception>
		// Token: 0x060069A3 RID: 27043 RVA: 0x001691A0 File Offset: 0x001673A0
		public virtual void Unlock(long position, long length)
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			if (position < 0L)
			{
				throw new ArgumentOutOfRangeException("position must not be negative");
			}
			if (length < 0L)
			{
				throw new ArgumentOutOfRangeException("length must not be negative");
			}
			MonoIOError monoIOError;
			MonoIO.Unlock(this.safeHandle, position, length, out monoIOError);
			if (monoIOError != MonoIOError.ERROR_SUCCESS)
			{
				throw MonoIO.GetException(this.GetSecureFileName(this.name), monoIOError);
			}
		}

		/// <summary>Гарантирует, что ресурсы освобождены и выполнены другие операции очистки, когда сборщик мусора восстанавливает <see langword="FileStream" />.</summary>
		// Token: 0x060069A4 RID: 27044 RVA: 0x0016920C File Offset: 0x0016740C
		~FileStream()
		{
			this.Dispose(false);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.FileStream" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x060069A5 RID: 27045 RVA: 0x0016923C File Offset: 0x0016743C
		protected override void Dispose(bool disposing)
		{
			Exception ex = null;
			if (this.safeHandle != null && !this.safeHandle.IsClosed)
			{
				try
				{
					this.FlushBuffer();
				}
				catch (Exception ex)
				{
				}
				if (this.owner)
				{
					MonoIOError monoIOError;
					MonoIO.Close(this.safeHandle.DangerousGetHandle(), out monoIOError);
					if (monoIOError != MonoIOError.ERROR_SUCCESS)
					{
						throw MonoIO.GetException(this.GetSecureFileName(this.name), monoIOError);
					}
					this.safeHandle.DangerousRelease();
				}
			}
			this.canseek = false;
			this.access = (FileAccess)0;
			if (disposing && this.buf != null)
			{
				if (this.buf.Length == 4096 && FileStream.buf_recycle == null)
				{
					object obj = FileStream.buf_recycle_lock;
					lock (obj)
					{
						if (FileStream.buf_recycle == null)
						{
							FileStream.buf_recycle = this.buf;
						}
					}
				}
				this.buf = null;
				GC.SuppressFinalize(this);
			}
			if (ex != null)
			{
				throw ex;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Security.AccessControl.FileSecurity" />, который инкапсулирует записи списка управления доступом (ACL) для файла, описываемого текущим объектом <see cref="T:System.IO.FileStream" />.</summary>
		/// <returns>Объект, инкапсулирующий параметры управления доступом для файла, который описывается текущим объектом <see cref="T:System.IO.FileStream" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Файл закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.SystemException">Не удалось найти файл.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Эта операция не поддерживается на текущей платформе.  
		///
		/// или - 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060069A6 RID: 27046 RVA: 0x00169334 File Offset: 0x00167534
		public FileSecurity GetAccessControl()
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			return new FileSecurity(this.SafeFileHandle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
		}

		/// <summary>Применяет записи списка управления доступом (ACL), описанные объектом <see cref="T:System.Security.AccessControl.FileSecurity" />, к файлу, который описывается текущим объектом <see cref="T:System.IO.FileStream" />.</summary>
		/// <param name="fileSecurity">Объект, который описывает запись ACL, применяемую к текущему файлу.</param>
		/// <exception cref="T:System.ObjectDisposedException">Файл закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="fileSecurity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.SystemException">Не удалось найти или изменить файл.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Текущий процесс не может открыть файл из-за отсутствия соответствующих прав доступа.</exception>
		// Token: 0x060069A7 RID: 27047 RVA: 0x0016935B File Offset: 0x0016755B
		public void SetAccessControl(FileSecurity fileSecurity)
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			if (fileSecurity == null)
			{
				throw new ArgumentNullException("fileSecurity");
			}
			fileSecurity.PersistModifications(this.SafeFileHandle);
		}

		/// <summary>Асинхронно очищает все буферы данного потока, вызывает запись буферизованных данных в базовое устройство и отслеживает запросы отмены.</summary>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию очистки.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		// Token: 0x060069A8 RID: 27048 RVA: 0x0016938F File Offset: 0x0016758F
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (this.safeHandle.IsClosed)
			{
				throw new ObjectDisposedException("Stream has been closed");
			}
			return base.FlushAsync(cancellationToken);
		}

		/// <summary>Асинхронно считывает последовательность байтов из текущего потока, перемещает позицию в потоке на число считанных байтов и отслеживает запросы отмены.</summary>
		/// <param name="buffer">Буфер, в который записываются данные.</param>
		/// <param name="offset">Смещение байтов в <paramref name="buffer" />, с которого начинается запись данных из потока.</param>
		/// <param name="count">Максимальное число байтов, предназначенных для чтения.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит общее число байтов, считанных в буфер. Значение результата может быть меньше запрошенного числа байтов, если число доступных в данный момент байтов меньше запрошенного числа, или результат может быть равен 0 (нулю), если был достигнут конец потока.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x060069A9 RID: 27049 RVA: 0x001693B0 File Offset: 0x001675B0
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return base.ReadAsync(buffer, offset, count, cancellationToken);
		}

		/// <summary>Асинхронно записывает последовательность байтов в текущий поток, перемещает текущую позицию внутри потока на число записанных байтов и отслеживает запросы отмены.</summary>
		/// <param name="buffer">Буфер, из которого записываются данные.</param>
		/// <param name="offset">Смещение байтов (начиная с нуля) в объекте <paramref name="buffer" />, с которого начинается копирование байтов в поток.</param>
		/// <param name="count">Максимальное число байтов для записи.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.NotSupportedException">Поток не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток был удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x060069AA RID: 27050 RVA: 0x001693BD File Offset: 0x001675BD
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return base.WriteAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x001693CA File Offset: 0x001675CA
		private int ReadSegment(byte[] dest, int dest_offset, int count)
		{
			count = Math.Min(count, this.buf_length - this.buf_offset);
			if (count > 0)
			{
				Buffer.InternalBlockCopy(this.buf, this.buf_offset, dest, dest_offset, count);
				this.buf_offset += count;
			}
			return count;
		}

		// Token: 0x060069AC RID: 27052 RVA: 0x0016940C File Offset: 0x0016760C
		private int WriteSegment(byte[] src, int src_offset, int count)
		{
			if (count > this.buf_size - this.buf_offset)
			{
				count = this.buf_size - this.buf_offset;
			}
			if (count > 0)
			{
				Buffer.BlockCopy(src, src_offset, this.buf, this.buf_offset, count);
				this.buf_offset += count;
				if (this.buf_offset > this.buf_length)
				{
					this.buf_length = this.buf_offset;
				}
				this.buf_dirty = true;
			}
			return count;
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x00169480 File Offset: 0x00167680
		private void FlushBuffer()
		{
			if (this.buf_dirty)
			{
				if (this.CanSeek && !this.isExposed)
				{
					MonoIOError monoIOError;
					MonoIO.Seek(this.safeHandle, this.buf_start, SeekOrigin.Begin, out monoIOError);
					if (monoIOError != MonoIOError.ERROR_SUCCESS)
					{
						throw MonoIO.GetException(this.GetSecureFileName(this.name), monoIOError);
					}
				}
				int i = this.buf_length;
				int num = 0;
				while (i > 0)
				{
					MonoIOError monoIOError;
					int num2 = MonoIO.Write(this.safeHandle, this.buf, num, this.buf_length, out monoIOError);
					if (monoIOError != MonoIOError.ERROR_SUCCESS)
					{
						throw MonoIO.GetException(this.GetSecureFileName(this.name), monoIOError);
					}
					i -= num2;
					num += num2;
				}
			}
			this.buf_start += (long)this.buf_offset;
			this.buf_offset = (this.buf_length = 0);
			this.buf_dirty = false;
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x00169548 File Offset: 0x00167748
		private void FlushBufferIfDirty()
		{
			if (this.buf_dirty)
			{
				this.FlushBuffer();
			}
		}

		// Token: 0x060069AF RID: 27055 RVA: 0x00169558 File Offset: 0x00167758
		private void RefillBuffer()
		{
			this.FlushBuffer();
			this.buf_length = this.ReadData(this.safeHandle, this.buf, 0, this.buf_size);
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x00169580 File Offset: 0x00167780
		private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count)
		{
			MonoIOError monoIOError;
			int num = MonoIO.Read(safeHandle, buf, offset, count, out monoIOError);
			if (monoIOError == MonoIOError.ERROR_BROKEN_PIPE)
			{
				num = 0;
			}
			else if (monoIOError != MonoIOError.ERROR_SUCCESS)
			{
				throw MonoIO.GetException(this.GetSecureFileName(this.name), monoIOError);
			}
			if (num == -1)
			{
				throw new IOException();
			}
			return num;
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x001695C8 File Offset: 0x001677C8
		private void InitBuffer(int size, bool isZeroSize)
		{
			if (isZeroSize)
			{
				size = 0;
				this.buf = new byte[1];
			}
			else
			{
				if (size <= 0)
				{
					throw new ArgumentOutOfRangeException("bufferSize", "Positive number required.");
				}
				size = Math.Max(size, 8);
				if (size <= 4096 && FileStream.buf_recycle != null)
				{
					object obj = FileStream.buf_recycle_lock;
					lock (obj)
					{
						if (FileStream.buf_recycle != null)
						{
							this.buf = FileStream.buf_recycle;
							FileStream.buf_recycle = null;
						}
					}
				}
				if (this.buf == null)
				{
					this.buf = new byte[size];
				}
				else
				{
					Array.Clear(this.buf, 0, size);
				}
			}
			this.buf_size = size;
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x00169688 File Offset: 0x00167888
		private string GetSecureFileName(string filename)
		{
			if (!this.anonymous)
			{
				return Path.GetFullPath(filename);
			}
			return Path.GetFileName(filename);
		}

		// Token: 0x060069B3 RID: 27059 RVA: 0x0016969F File Offset: 0x0016789F
		private string GetSecureFileName(string filename, bool full)
		{
			if (this.anonymous)
			{
				return Path.GetFileName(filename);
			}
			if (!full)
			{
				return filename;
			}
			return Path.GetFullPath(filename);
		}

		// Token: 0x04003D2E RID: 15662
		internal const int DefaultBufferSize = 4096;

		// Token: 0x04003D2F RID: 15663
		private static byte[] buf_recycle;

		// Token: 0x04003D30 RID: 15664
		private static readonly object buf_recycle_lock = new object();

		// Token: 0x04003D31 RID: 15665
		private byte[] buf;

		// Token: 0x04003D32 RID: 15666
		private string name;

		// Token: 0x04003D33 RID: 15667
		private SafeFileHandle safeHandle;

		// Token: 0x04003D34 RID: 15668
		private bool isExposed;

		// Token: 0x04003D35 RID: 15669
		private long append_startpos;

		// Token: 0x04003D36 RID: 15670
		private FileAccess access;

		// Token: 0x04003D37 RID: 15671
		private bool owner;

		// Token: 0x04003D38 RID: 15672
		private bool async;

		// Token: 0x04003D39 RID: 15673
		private bool canseek;

		// Token: 0x04003D3A RID: 15674
		private bool anonymous;

		// Token: 0x04003D3B RID: 15675
		private bool buf_dirty;

		// Token: 0x04003D3C RID: 15676
		private int buf_size;

		// Token: 0x04003D3D RID: 15677
		private int buf_length;

		// Token: 0x04003D3E RID: 15678
		private int buf_offset;

		// Token: 0x04003D3F RID: 15679
		private long buf_start;

		// Token: 0x02000B5F RID: 2911
		// (Invoke) Token: 0x060069B6 RID: 27062
		private delegate int ReadDelegate(byte[] buffer, int offset, int count);

		// Token: 0x02000B60 RID: 2912
		// (Invoke) Token: 0x060069BA RID: 27066
		private delegate void WriteDelegate(byte[] buffer, int offset, int count);
	}
}
