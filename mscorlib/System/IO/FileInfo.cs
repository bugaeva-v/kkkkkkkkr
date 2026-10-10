using System;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;

namespace System.IO
{
	/// <summary>Предоставляет свойства и методы экземпляра для создания, копирования, удаления, перемещения и открытия файлов, а также позволяет создавать объекты <see cref="T:System.IO.FileStream" />. Этот класс не наследуется.</summary>
	// Token: 0x02000B39 RID: 2873
	[Serializable]
	public sealed class FileInfo : FileSystemInfo
	{
		// Token: 0x060067B6 RID: 26550 RVA: 0x00162006 File Offset: 0x00160206
		private FileInfo()
		{
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.FileInfo" />, который служит оболочкой для пути файла.</summary>
		/// <param name="fileName">Полное имя нового файла или относительное имя файла. Путь не должен заканчиваться символом разделителя каталогов.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="fileName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">Имя файла является пустой строкой, содержит только пробелы или недопустимые символы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Отказано в доступе к <paramref name="fileName" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="fileName" /> содержит двоеточие (:) в середине строки.</exception>
		// Token: 0x060067B7 RID: 26551 RVA: 0x0016200E File Offset: 0x0016020E
		public FileInfo(string fileName) : this(fileName, null, null, false)
		{
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x0016201C File Offset: 0x0016021C
		internal FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
			if (originalPath == null)
			{
				throw new ArgumentNullException("fileName");
			}
			this.OriginalPath = originalPath;
			fullPath = (fullPath ?? originalPath);
			this.FullPath = (isNormalized ? (fullPath ?? originalPath) : Path.GetFullPath(fullPath));
			this._name = (fileName ?? Path.GetFileName(originalPath));
		}

		/// <summary>Получает размер текущего файла в байтах.</summary>
		/// <returns>Размер текущего файла в байтах.</returns>
		/// <exception cref="T:System.IO.IOException">
		///   <see cref="M:System.IO.FileSystemInfo.Refresh" /> не удалось обновить состояние файла или каталога.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл не существует.  
		/// -или- 
		/// Свойство <see langword="Length" /> вызывается для каталога.</exception>
		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x060067B9 RID: 26553 RVA: 0x00162076 File Offset: 0x00160276
		public long Length
		{
			get
			{
				if ((base.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
				{
					throw new FileNotFoundException(SR.Format("Could not find file '{0}'.", this.FullPath), this.FullPath);
				}
				return base.LengthCore;
			}
		}

		/// <summary>Получает строку, представляющую полный путь к каталогу.</summary>
		/// <returns>Строка, представляющая полный путь к каталогу.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение <see langword="null" /> было передано в качестве имени каталога.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина имени полного пути превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x060067BA RID: 26554 RVA: 0x001620A7 File Offset: 0x001602A7
		public string DirectoryName
		{
			get
			{
				return Path.GetDirectoryName(this.FullPath);
			}
		}

		/// <summary>Получает экземпляр родительского каталога.</summary>
		/// <returns>Объект <see cref="T:System.IO.DirectoryInfo" />, представляющий родительский каталог данного файла.</returns>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x060067BB RID: 26555 RVA: 0x001620B4 File Offset: 0x001602B4
		public DirectoryInfo Directory
		{
			get
			{
				string directoryName = this.DirectoryName;
				if (directoryName == null)
				{
					return null;
				}
				return new DirectoryInfo(directoryName);
			}
		}

		/// <summary>Возвращает или задает значение, позволяющее определить, является ли текущий файл доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если текущий файл доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти файл, описанный текущим объектом <see cref="T:System.IO.FileInfo" />.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">Пользователь не имеет разрешения на запись, но пытается задать для этого свойства значение <see langword="false" />.</exception>
		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x060067BC RID: 26556 RVA: 0x001620D3 File Offset: 0x001602D3
		// (set) Token: 0x060067BD RID: 26557 RVA: 0x001620E0 File Offset: 0x001602E0
		public bool IsReadOnly
		{
			get
			{
				return (base.Attributes & FileAttributes.ReadOnly) > (FileAttributes)0;
			}
			set
			{
				if (value)
				{
					base.Attributes |= FileAttributes.ReadOnly;
					return;
				}
				base.Attributes &= ~FileAttributes.ReadOnly;
			}
		}

		/// <summary>Создает поток <see cref="T:System.IO.StreamReader" /> с кодировкой UTF-8, который считывает данные из существующего текстового файла.</summary>
		/// <returns>Новый объект <see langword="StreamReader" /> с кодировкой UTF8.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл не найден.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///   <paramref name="path" /> доступен только для чтения или является каталогом.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		// Token: 0x060067BE RID: 26558 RVA: 0x00162103 File Offset: 0x00160303
		public StreamReader OpenText()
		{
			return new StreamReader(base.NormalizedPath, Encoding.UTF8, true);
		}

		/// <summary>Создает <see cref="T:System.IO.StreamWriter" />, который записывает новый текстовый файл.</summary>
		/// <returns>Новый объект <see langword="StreamWriter" />.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Имя файла является каталогом.</exception>
		/// <exception cref="T:System.IO.IOException">Диск доступен только для чтения.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060067BF RID: 26559 RVA: 0x00162116 File Offset: 0x00160316
		public StreamWriter CreateText()
		{
			return new StreamWriter(base.NormalizedPath, false);
		}

		/// <summary>Создает <see cref="T:System.IO.StreamWriter" />, который добавляет текст в файл, представленный этим экземпляром <see cref="T:System.IO.FileInfo" />.</summary>
		/// <returns>Новый объект <see langword="StreamWriter" />.</returns>
		// Token: 0x060067C0 RID: 26560 RVA: 0x00162124 File Offset: 0x00160324
		public StreamWriter AppendText()
		{
			return new StreamWriter(base.NormalizedPath, true);
		}

		/// <summary>Копирует существующий файл в новый файл и запрещает перезапись существующего файла.</summary>
		/// <param name="destFileName">Имя нового файла, в который будет выполняться копирование.</param>
		/// <returns>Новый файл с полным именем.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="destFileName" /> является пустой строкой, содержит только пробелы или недопустимые символы.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка, или файл назначения уже существует.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destFileName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Передан путь к каталогу, или файл перемещен на другой диск.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Каталог, указанный в <paramref name="destFileName" />, не существует.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="destFileName" /> содержит двоеточие (:) в строке, но не указывает том.</exception>
		// Token: 0x060067C1 RID: 26561 RVA: 0x00162132 File Offset: 0x00160332
		public FileInfo CopyTo(string destFileName)
		{
			return this.CopyTo(destFileName, false);
		}

		/// <summary>Копирует существующий файл в новый файл и разрешает перезапись существующего файла.</summary>
		/// <param name="destFileName">Имя нового файла, в который будет выполняться копирование.</param>
		/// <param name="overwrite">Значение <see langword="true" /> позволяет разрешить перезапись существующего файла; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Новый файл или перезапись существующего файла, если для параметра <paramref name="overwrite" /> задано значение <see langword="true" />. Если файл существует и для параметра <paramref name="overwrite" /> задано значение <see langword="false" />, создается исключение <see cref="T:System.IO.IOException" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="destFileName" /> является пустой строкой, содержит только пробелы или недопустимые символы.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка, или файл назначения уже существует, а <paramref name="overwrite" /> имеет значение <see langword="false" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destFileName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Каталог, указанный в <paramref name="destFileName" />, не существует.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Передан путь к каталогу, или файл перемещен на другой диск.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="destFileName" /> содержит двоеточие (:) в середине строки.</exception>
		// Token: 0x060067C2 RID: 26562 RVA: 0x0016213C File Offset: 0x0016033C
		public FileInfo CopyTo(string destFileName, bool overwrite)
		{
			if (destFileName == null)
			{
				throw new ArgumentNullException("destFileName", "File name cannot be null.");
			}
			if (destFileName.Length == 0)
			{
				throw new ArgumentException("Empty file name is not legal.", "destFileName");
			}
			string fullPath = Path.GetFullPath(destFileName);
			FileSystem.CopyFile(this.FullPath, fullPath, overwrite);
			return new FileInfo(fullPath, null, null, true);
		}

		/// <summary>Создает файл.</summary>
		/// <returns>Новый файл.</returns>
		// Token: 0x060067C3 RID: 26563 RVA: 0x00162191 File Offset: 0x00160391
		public FileStream Create()
		{
			return File.Create(base.NormalizedPath);
		}

		/// <summary>Удаляет файл без возможности восстановления.</summary>
		/// <exception cref="T:System.IO.IOException">Целевой файл открыт или сопоставлен в памяти на компьютере под управлением Microsoft Windows NT.  
		/// -или- 
		/// Для файла имеется открытый дескриптор, а операционной системой является Windows XP или более ранней версии. Этот открытый дескриптор может быть результатом перечисления каталогов и файлов. Дополнительные сведения см. в разделе Как перечислить каталоги и файлы.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Путь является каталогом.</exception>
		// Token: 0x060067C4 RID: 26564 RVA: 0x0016219E File Offset: 0x0016039E
		public override void Delete()
		{
			FileSystem.DeleteFile(this.FullPath);
		}

		/// <summary>Открывает файл в заданном режиме.</summary>
		/// <param name="mode">Константа <see cref="T:System.IO.FileMode" /> задает режим (например <see langword="Open" /> или <see langword="Append" />), в котором необходимо открыть файл.</param>
		/// <returns>Файл открыт в заданном режиме с доступом для чтения и записи и без предоставления общего доступа.</returns>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл не найден.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Файл доступен только для чтения или является каталогом.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Файл уже открыт.</exception>
		// Token: 0x060067C5 RID: 26565 RVA: 0x001621AB File Offset: 0x001603AB
		public FileStream Open(FileMode mode)
		{
			return this.Open(mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.None);
		}

		/// <summary>Открывает файл в заданном режиме с доступом для чтения или записи, или и для чтения, и для записи.</summary>
		/// <param name="mode">Константа <see cref="T:System.IO.FileMode" /> задает режим (например <see langword="Open" /> или <see langword="Append" />), в котором необходимо открыть файл.</param>
		/// <param name="access">Константа <see cref="T:System.IO.FileAccess" /> задает доступ к открываемому файлу: <see langword="Read" />, <see langword="Write" /> или <see langword="ReadWrite" />.</param>
		/// <returns>Объект <see cref="T:System.IO.FileStream" /> открыт в заданном режиме, с заданными правами и без предоставления общего доступа.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл не найден.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///   <paramref name="path" /> доступен только для чтения или является каталогом.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Файл уже открыт.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> является пустой строкой или содержит только пробелы.</exception>
		/// <exception cref="T:System.ArgumentNullException">Один или несколько аргументов имеют значение NULL.</exception>
		// Token: 0x060067C6 RID: 26566 RVA: 0x001621BD File Offset: 0x001603BD
		public FileStream Open(FileMode mode, FileAccess access)
		{
			return this.Open(mode, access, FileShare.None);
		}

		/// <summary>Открывает файл в заданном режиме с доступом для чтения, записи или и для чтения, и для записи и с заданным параметром совместного доступа.</summary>
		/// <param name="mode">Константа <see cref="T:System.IO.FileMode" /> задает режим (например <see langword="Open" /> или <see langword="Append" />), в котором необходимо открыть файл.</param>
		/// <param name="access">Константа <see cref="T:System.IO.FileAccess" /> задает доступ к открываемому файлу: <see langword="Read" />, <see langword="Write" /> или <see langword="ReadWrite" />.</param>
		/// <param name="share">Константа <see cref="T:System.IO.FileShare" /> задает тип доступа к файлу для других объектов <see langword="FileStream" />.</param>
		/// <returns>Объект <see cref="T:System.IO.FileStream" /> открыт в заданном режиме, с заданными правами и параметром общего доступа.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл не найден.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///   <paramref name="path" /> доступен только для чтения или является каталогом.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Файл уже открыт.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> является пустой строкой или содержит только пробелы.</exception>
		/// <exception cref="T:System.ArgumentNullException">Один или несколько аргументов имеют значение NULL.</exception>
		// Token: 0x060067C7 RID: 26567 RVA: 0x001621C8 File Offset: 0x001603C8
		public FileStream Open(FileMode mode, FileAccess access, FileShare share)
		{
			return new FileStream(base.NormalizedPath, mode, access, share);
		}

		/// <summary>Создает доступный только для чтения поток <see cref="T:System.IO.FileStream" />.</summary>
		/// <returns>Новый объект <see cref="T:System.IO.FileStream" />, доступный только для чтения.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///   <paramref name="path" /> доступен только для чтения или является каталогом.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Файл уже открыт.</exception>
		// Token: 0x060067C8 RID: 26568 RVA: 0x001621D8 File Offset: 0x001603D8
		public FileStream OpenRead()
		{
			return new FileStream(base.NormalizedPath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, false);
		}

		/// <summary>Создает доступный только для чтения поток <see cref="T:System.IO.FileStream" />.</summary>
		/// <returns>Объект <see cref="T:System.IO.FileStream" />, доступный только для записи, не предназначенный для совместного использования и служащий для нового или существующего файла.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Путь, указанный при создании экземпляра объекта <see cref="T:System.IO.FileInfo" />, доступен только для чтения или является каталогом.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, указанный при создании экземпляра объекта <see cref="T:System.IO.FileInfo" />, является недопустимым, например находится на несопоставленном диске.</exception>
		// Token: 0x060067C9 RID: 26569 RVA: 0x001621EE File Offset: 0x001603EE
		public FileStream OpenWrite()
		{
			return new FileStream(base.NormalizedPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
		}

		/// <summary>Перемещает заданный файл в новое местоположение и разрешает переименование файла.</summary>
		/// <param name="destFileName">Путь, указывающий на местоположение, в которое необходимо переместить файл; в этом же пути можно задать и другое имя файла.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода, например, конечный файл уже существует или устройство назначения не готово.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destFileName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="destFileName" /> является пустой строкой, содержит только пробелы или недопустимые символы.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///   <paramref name="destFileName" /> доступен только для чтения или является каталогом.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл не найден.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="destFileName" /> содержит двоеточие (:) в середине строки.</exception>
		// Token: 0x060067CA RID: 26570 RVA: 0x00162200 File Offset: 0x00160400
		public void MoveTo(string destFileName)
		{
			if (destFileName == null)
			{
				throw new ArgumentNullException("destFileName");
			}
			if (destFileName.Length == 0)
			{
				throw new ArgumentException("Empty file name is not legal.", "destFileName");
			}
			string fullPath = Path.GetFullPath(destFileName);
			if (!new DirectoryInfo(Path.GetDirectoryName(this.FullName)).Exists)
			{
				throw new DirectoryNotFoundException(SR.Format("Could not find a part of the path '{0}'.", this.FullName));
			}
			if (!this.Exists)
			{
				throw new FileNotFoundException(SR.Format("Could not find file '{0}'.", this.FullName), this.FullName);
			}
			FileSystem.MoveFile(this.FullPath, fullPath);
			this.FullPath = fullPath;
			this.OriginalPath = destFileName;
			this._name = Path.GetFileName(fullPath);
			base.Invalidate();
		}

		/// <summary>Заменяет содержимое заданного файла на содержимое файла, которое описано в текущем объекте <see cref="T:System.IO.FileInfo" />, удаляет исходный файл и создает резервную копию замененного файла.</summary>
		/// <param name="destinationFileName">Имя файла, который необходимо заменить текущим файлом.</param>
		/// <param name="destinationBackupFileName">Имя файла, с которым необходимо создать резервную копию файла, описанного параметром <paramref name="destFileName" />.</param>
		/// <returns>Объект <see cref="T:System.IO.FileInfo" />, который инкапсулирует сведения о файле, описанные параметром <paramref name="destFileName" />.</returns>
		/// <exception cref="T:System.ArgumentException">Путь, описываемый параметром <paramref name="destFileName" />, имел недопустимую форму.  
		/// -или- 
		/// Путь, описываемый параметром <paramref name="destBackupFileName" />, имел недопустимую форму.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="destFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти файл, описанный текущим объектом <see cref="T:System.IO.FileInfo" />.  
		/// -или- 
		/// Файл, описываемый параметром <paramref name="destinationFileName" />, не найден.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows NT или более поздней версии.</exception>
		// Token: 0x060067CB RID: 26571 RVA: 0x001622B7 File Offset: 0x001604B7
		public FileInfo Replace(string destinationFileName, string destinationBackupFileName)
		{
			return this.Replace(destinationFileName, destinationBackupFileName, false);
		}

		/// <summary>Заменяет содержимое заданного файла на содержимое файла, которое описано в текущем объекте <see cref="T:System.IO.FileInfo" />, удаляет исходный файл и создает резервную копию замененного файла.  Также позволяет определить, нужно ли игнорировать ошибки слияния.</summary>
		/// <param name="destinationFileName">Имя файла, который необходимо заменить текущим файлом.</param>
		/// <param name="destinationBackupFileName">Имя файла, с которым необходимо создать резервную копию файла, описанного параметром <paramref name="destFileName" />.</param>
		/// <param name="ignoreMetadataErrors">Значение <see langword="true" /> позволяет игнорировать ошибки слияния (например атрибуты и списки ACL), исходящие из заменяемого файла в заменяющий; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.IO.FileInfo" />, который инкапсулирует сведения о файле, описанные параметром <paramref name="destFileName" />.</returns>
		/// <exception cref="T:System.ArgumentException">Путь, описываемый параметром <paramref name="destFileName" />, имел недопустимую форму.  
		/// -или- 
		/// Путь, описываемый параметром <paramref name="destBackupFileName" />, имел недопустимую форму.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="destFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти файл, описанный текущим объектом <see cref="T:System.IO.FileInfo" />.  
		/// -или- 
		/// Файл, описываемый параметром <paramref name="destinationFileName" />, не найден.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows NT или более поздней версии.</exception>
		// Token: 0x060067CC RID: 26572 RVA: 0x001622C2 File Offset: 0x001604C2
		public FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
		{
			if (destinationFileName == null)
			{
				throw new ArgumentNullException("destinationFileName");
			}
			FileSystem.ReplaceFile(this.FullPath, Path.GetFullPath(destinationFileName), (destinationBackupFileName != null) ? Path.GetFullPath(destinationBackupFileName) : null, ignoreMetadataErrors);
			return new FileInfo(destinationFileName);
		}

		/// <summary>Расшифровывает файл, зашифрованный текущей учетной записью с помощью метода <see cref="M:System.IO.FileInfo.Encrypt" />.</summary>
		/// <exception cref="T:System.IO.DriveNotFoundException">Указан недопустимый диск.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти файл, описанный текущим объектом <see cref="T:System.IO.FileInfo" />.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Файловая система не является системой NTFS.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows NT или более поздней версии.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Файл, описанный текущим объектом <see cref="T:System.IO.FileInfo" />, доступен только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060067CD RID: 26573 RVA: 0x001622F6 File Offset: 0x001604F6
		public void Decrypt()
		{
			File.Decrypt(this.FullPath);
		}

		/// <summary>Шифрует файл таким образом, чтобы его можно было расшифровать только с помощью учетной записи, которая использовалась для шифрования.</summary>
		/// <exception cref="T:System.IO.DriveNotFoundException">Указан недопустимый диск.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти файл, описанный текущим объектом <see cref="T:System.IO.FileInfo" />.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.NotSupportedException">Файловая система не является системой NTFS.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows NT или более поздней версии.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Файл, описанный текущим объектом <see cref="T:System.IO.FileInfo" />, доступен только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060067CE RID: 26574 RVA: 0x00162303 File Offset: 0x00160503
		public void Encrypt()
		{
			File.Encrypt(this.FullPath);
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x0015FF41 File Offset: 0x0015E141
		private FileInfo(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Получает объект <see cref="T:System.Security.AccessControl.FileSecurity" />, который инкапсулирует записи списка управления доступом (ACL) для файла, описываемого текущим объектом <see cref="T:System.IO.FileInfo" />.</summary>
		/// <returns>
		///   <see cref="T:System.Security.AccessControl.FileSecurity" />, который инкапсулирует правила управления доступом к текущему файлу.</returns>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows 2000 или более поздней версией Windows.</exception>
		/// <exception cref="T:System.Security.AccessControl.PrivilegeNotHeldException">Текущая учетная запись системы не имеет прав администратора.</exception>
		/// <exception cref="T:System.SystemException">Не удалось найти файл.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060067D0 RID: 26576 RVA: 0x00162310 File Offset: 0x00160510
		public FileSecurity GetAccessControl()
		{
			return File.GetAccessControl(this.FullPath, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
		}

		/// <summary>Получает объект <see cref="T:System.Security.AccessControl.FileSecurity" />, который инкапсулирует заданный тип записей списка управления доступом для файла, описываемого текущим объектом <see cref="T:System.IO.FileInfo" />.</summary>
		/// <param name="includeSections">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlSections" />, которое указывает, какую группу записей списка ACL необходимо извлечь.</param>
		/// <returns>
		///   <see cref="T:System.Security.AccessControl.FileSecurity" />, который инкапсулирует правила управления доступом к текущему файлу.</returns>
		/// <exception cref="T:System.IO.IOException">При открытии файла произошла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows 2000 или более поздней версией Windows.</exception>
		/// <exception cref="T:System.Security.AccessControl.PrivilegeNotHeldException">Текущая учетная запись системы не имеет прав администратора.</exception>
		/// <exception cref="T:System.SystemException">Не удалось найти файл.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060067D1 RID: 26577 RVA: 0x0016231F File Offset: 0x0016051F
		public FileSecurity GetAccessControl(AccessControlSections includeSections)
		{
			return File.GetAccessControl(this.FullPath, includeSections);
		}

		/// <summary>Применяет записи списка управления доступом (ACL), описанные объектом <see cref="T:System.Security.AccessControl.FileSecurity" />, к файлу, который описывается текущим объектом <see cref="T:System.IO.FileInfo" />.</summary>
		/// <param name="fileSecurity">Объект <see cref="T:System.Security.AccessControl.FileSecurity" />, описывающий запись списка управления доступом (ACL), которую необходимо применить к текущему файлу.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="fileSecurity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.SystemException">Не удалось найти или изменить файл.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Текущий процесс не может открыть файл из-за отсутствия соответствующих прав доступа.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows 2000 или более поздней версией Windows.</exception>
		// Token: 0x060067D2 RID: 26578 RVA: 0x0016232D File Offset: 0x0016052D
		public void SetAccessControl(FileSecurity fileSecurity)
		{
			File.SetAccessControl(this.FullPath, fileSecurity);
		}

		// Token: 0x060067D3 RID: 26579 RVA: 0x0016233B File Offset: 0x0016053B
		internal FileInfo(string fullPath, bool ignoreThis)
		{
			this._name = Path.GetFileName(fullPath);
			this.OriginalPath = this._name;
			this.FullPath = fullPath;
		}

		/// <summary>Возвращает имя файла.</summary>
		/// <returns>Имя файла</returns>
		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x060067D4 RID: 26580 RVA: 0x00162362 File Offset: 0x00160562
		public override string Name
		{
			get
			{
				return this._name;
			}
		}
	}
}
