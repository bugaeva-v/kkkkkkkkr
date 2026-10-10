using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Runtime.Serialization;
using System.Security.AccessControl;

namespace System.IO
{
	/// <summary>Предоставляет методы экземпляра класса для создания, перемещения и перечисления в каталогах и подкаталогах. Этот класс не наследуется.</summary>
	// Token: 0x02000B2F RID: 2863
	[Serializable]
	public sealed class DirectoryInfo : FileSystemInfo
	{
		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.DirectoryInfo" /> для заданного пути.</summary>
		/// <param name="path">Строка, содержащая путь, для которого создается класс <see langword="DirectoryInfo" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> содержит недопустимые символы, такие как ", &lt;, &gt; или |.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x06006715 RID: 26389 RVA: 0x0015FA45 File Offset: 0x0015DC45
		public DirectoryInfo(string path)
		{
			this.Init(path, Path.GetFullPath(path), null, true);
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x0015FA5C File Offset: 0x0015DC5C
		internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
			this.Init(originalPath, fullPath, fileName, isNormalized);
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x0015FA70 File Offset: 0x0015DC70
		private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
			if (originalPath == null)
			{
				throw new ArgumentNullException("path");
			}
			this.OriginalPath = originalPath;
			fullPath = (fullPath ?? originalPath);
			fullPath = (isNormalized ? fullPath : Path.GetFullPath(fullPath));
			this._name = (fileName ?? (PathInternal.IsRoot(fullPath) ? fullPath : Path.GetFileName(PathInternal.TrimEndingDirectorySeparator(fullPath.AsSpan()))).ToString());
			this.FullPath = fullPath;
		}

		/// <summary>Получает родительский каталог заданного подкаталога.</summary>
		/// <returns>Родительский каталог или <see langword="null" /> Если путь имеет значение null или если путь к файлу указывает на корневой каталог (например, "\«, «C:», или *"\\server\share»).</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06006718 RID: 26392 RVA: 0x0015FAF0 File Offset: 0x0015DCF0
		public DirectoryInfo Parent
		{
			get
			{
				string directoryName = Path.GetDirectoryName(PathInternal.IsRoot(this.FullPath) ? this.FullPath : PathInternal.TrimEndingDirectorySeparator(this.FullPath));
				if (directoryName == null)
				{
					return null;
				}
				return new DirectoryInfo(directoryName, null, null, false);
			}
		}

		/// <summary>Создает один или несколько подкаталогов по заданному пути. Путь может быть задан относительно текущего экземпляра класса <see cref="T:System.IO.DirectoryInfo" />.</summary>
		/// <param name="path">Заданный путь. Этот путь не может указывать на другой том диска или иметь формат UNC.</param>
		/// <returns>Последний каталог, на который указывает <paramref name="path" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> не указывает допустимый путь к файлу или содержит недопустимые символы <see langword="DirectoryInfo" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Невозможно создать подкаталог.  
		/// -или- 
		/// Файл или каталог уже имеет имя, указанное <paramref name="path" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект не имеет разрешения доступа к коду для создания каталога.  
		/// -или- 
		/// Вызывающий объект не имеет разрешения доступа к коду для чтения каталога, описанного возвращаемым объектом <see cref="T:System.IO.DirectoryInfo" />.  Это может произойти, если параметр <paramref name="path" /> описывает существующий каталог.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> содержит двоеточие (:), которое не является частью метки диска (C:\).</exception>
		// Token: 0x06006719 RID: 26393 RVA: 0x0015FB38 File Offset: 0x0015DD38
		public DirectoryInfo CreateSubdirectory(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (PathInternal.IsEffectivelyEmpty(path))
			{
				throw new ArgumentException("Path cannot be the empty string or all whitespace.", "path");
			}
			if (Path.IsPathRooted(path))
			{
				throw new ArgumentException("Second path fragment must not be a drive or UNC name.", "path");
			}
			string fullPath = Path.GetFullPath(Path.Combine(this.FullPath, path));
			ReadOnlySpan<char> span = PathInternal.TrimEndingDirectorySeparator(fullPath.AsSpan());
			ReadOnlySpan<char> value = PathInternal.TrimEndingDirectorySeparator(this.FullPath.AsSpan());
			if (span.StartsWith(value, PathInternal.StringComparison) && (span.Length == value.Length || PathInternal.IsDirectorySeparator(fullPath[value.Length])))
			{
				FileSystem.CreateDirectory(fullPath);
				return new DirectoryInfo(fullPath);
			}
			throw new ArgumentException(SR.Format("The directory specified, '{0}', is not a subdirectory of '{1}'.", path, this.FullPath), "path");
		}

		/// <summary>Создает каталог.</summary>
		/// <exception cref="T:System.IO.IOException">Не удалось создать каталог.</exception>
		// Token: 0x0600671A RID: 26394 RVA: 0x0015FC11 File Offset: 0x0015DE11
		public void Create()
		{
			FileSystem.CreateDirectory(this.FullPath);
			base.Invalidate();
		}

		/// <summary>Возвращает список файлов текущего каталога.</summary>
		/// <returns>Массив типа <see cref="T:System.IO.FileInfo" />.</returns>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		// Token: 0x0600671B RID: 26395 RVA: 0x0015FC24 File Offset: 0x0015DE24
		public FileInfo[] GetFiles()
		{
			return this.GetFiles("*", EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает список файлов текущего каталога, соответствующих заданному шаблону поиска.</summary>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами файлов.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <returns>Массив типа <see cref="T:System.IO.FileInfo" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="searchPattern" /> содержит один или несколько недопустимых символов, определенных методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый путь (например, указывающий на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600671C RID: 26396 RVA: 0x0015FC36 File Offset: 0x0015DE36
		public FileInfo[] GetFiles(string searchPattern)
		{
			return this.GetFiles(searchPattern, EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает список файлов из текущего каталога, соответствующих заданному шаблону поиска, с использованием значения, которое позволяет определить, следует ли выполнять поиск в подкаталогах.</summary>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами файлов.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <param name="searchOption">Одно из значений перечисления, определяющее, следует ли выполнять поиск только в текущем каталоге или также во всех его подкаталогах.</param>
		/// <returns>Массив типа <see cref="T:System.IO.FileInfo" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="searchPattern" /> содержит один или несколько недопустимых символов, определенных методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> не является допустимым значением <see cref="T:System.IO.SearchOption" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый путь (например, указывающий на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600671D RID: 26397 RVA: 0x0015FC44 File Offset: 0x0015DE44
		public FileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
		{
			return this.GetFiles(searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x0600671E RID: 26398 RVA: 0x0015FC53 File Offset: 0x0015DE53
		public FileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return ((IEnumerable<FileInfo>)DirectoryInfo.InternalEnumerateInfos(this.FullPath, searchPattern, SearchTarget.Files, enumerationOptions)).ToArray<FileInfo>();
		}

		/// <summary>Возвращает массив строго типизированных объектов <see cref="T:System.IO.FileSystemInfo" />, представляющих все файлы и подкаталоги в том или ином каталоге.</summary>
		/// <returns>Массив строго типизированных записей <see cref="T:System.IO.FileSystemInfo" />.</returns>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый путь (например, указывающий на несопоставленный диск).</exception>
		// Token: 0x0600671F RID: 26399 RVA: 0x0015FC6D File Offset: 0x0015DE6D
		public FileSystemInfo[] GetFileSystemInfos()
		{
			return this.GetFileSystemInfos("*", EnumerationOptions.Compatible);
		}

		/// <summary>Извлекает массив строго типизированных объектов <see cref="T:System.IO.FileSystemInfo" />, представляющих файлы и подкаталоги, соответствующие заданным критериям поиска.</summary>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами каталогов и файлов.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <returns>Массив строго типизированных объектов <see langword="FileSystemInfo" />, соответствующих критерию поиска.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="searchPattern" /> содержит один или несколько недопустимых символов, определенных методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006720 RID: 26400 RVA: 0x0015FC7F File Offset: 0x0015DE7F
		public FileSystemInfo[] GetFileSystemInfos(string searchPattern)
		{
			return this.GetFileSystemInfos(searchPattern, EnumerationOptions.Compatible);
		}

		/// <summary>Извлекает массив объектов <see cref="T:System.IO.FileSystemInfo" />, представляющих файлы и подкаталоги, соответствующие заданным критериям поиска.</summary>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами каталогов и файлов.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <param name="searchOption">Одно из значений перечисления, определяющее, следует ли выполнять поиск только в текущем каталоге или также во всех его подкаталогах. Значение по умолчанию — <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
		/// <returns>Массив элементов файловой системы, удовлетворяющих критериям поиска.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="searchPattern" /> содержит один или несколько недопустимых символов, определенных методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> не является допустимым значением <see cref="T:System.IO.SearchOption" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006721 RID: 26401 RVA: 0x0015FC8D File Offset: 0x0015DE8D
		public FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return this.GetFileSystemInfos(searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x0015FC9C File Offset: 0x0015DE9C
		public FileSystemInfo[] GetFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return DirectoryInfo.InternalEnumerateInfos(this.FullPath, searchPattern, SearchTarget.Both, enumerationOptions).ToArray<FileSystemInfo>();
		}

		/// <summary>Возвращает подкаталоги текущего каталога.</summary>
		/// <returns>Массив объектов <see cref="T:System.IO.DirectoryInfo" />.</returns>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, содержащийся в объекте <see cref="T:System.IO.DirectoryInfo" />, является недействительным (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006723 RID: 26403 RVA: 0x0015FCB1 File Offset: 0x0015DEB1
		public DirectoryInfo[] GetDirectories()
		{
			return this.GetDirectories("*", EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает массив каталогов текущего объекта <see cref="T:System.IO.DirectoryInfo" />, отвечающих заданным условиям поиска.</summary>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами каталогов.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <returns>Массив элементов типа <see langword="DirectoryInfo" />, отвечающих критерию <paramref name="searchPattern" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="searchPattern" /> содержит один или несколько недопустимых символов, определенных методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, содержащийся в объекте <see langword="DirectoryInfo" />, является недействительным (например,он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006724 RID: 26404 RVA: 0x0015FCC3 File Offset: 0x0015DEC3
		public DirectoryInfo[] GetDirectories(string searchPattern)
		{
			return this.GetDirectories(searchPattern, EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает массив каталогов в текущем объекте <see cref="T:System.IO.DirectoryInfo" />, отвечающих заданным условиям поиска, с использованием значения, которое позволяет определить, следует ли выполнять поиск в подкаталогах.</summary>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами каталогов.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <param name="searchOption">Одно из значений перечисления, определяющее, следует ли выполнять поиск только в текущем каталоге или также во всех его подкаталогах.</param>
		/// <returns>Массив элементов типа <see langword="DirectoryInfo" />, отвечающих критерию <paramref name="searchPattern" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="searchPattern" /> содержит один или несколько недопустимых символов, определенных методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> не является допустимым значением <see cref="T:System.IO.SearchOption" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, содержащийся в объекте <see langword="DirectoryInfo" />, является недействительным (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006725 RID: 26405 RVA: 0x0015FCD1 File Offset: 0x0015DED1
		public DirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
		{
			return this.GetDirectories(searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x06006726 RID: 26406 RVA: 0x0015FCE0 File Offset: 0x0015DEE0
		public DirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return ((IEnumerable<DirectoryInfo>)DirectoryInfo.InternalEnumerateInfos(this.FullPath, searchPattern, SearchTarget.Directories, enumerationOptions)).ToArray<DirectoryInfo>();
		}

		/// <summary>Возвращает перечисляемую коллекцию сведений о каталогах в текущем каталоге.</summary>
		/// <returns>Перечисляемая коллекция каталогов в текущем каталоге.</returns>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, содержащийся в объекте <see cref="T:System.IO.DirectoryInfo" />, является недействительным (например,он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006727 RID: 26407 RVA: 0x0015FCFA File Offset: 0x0015DEFA
		public IEnumerable<DirectoryInfo> EnumerateDirectories()
		{
			return this.EnumerateDirectories("*", EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает перечисляемую коллекцию сведений о каталогах, соответствующую указанному шаблону поиска.</summary>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами каталогов.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <returns>Перечисляемая коллекция каталогов, соответствующая параметру <paramref name="searchPattern" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, содержащийся в объекте <see cref="T:System.IO.DirectoryInfo" />, является недействительным (например,он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006728 RID: 26408 RVA: 0x0015FD0C File Offset: 0x0015DF0C
		public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern)
		{
			return this.EnumerateDirectories(searchPattern, EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает перечисляемую коллекцию сведений о каталогах, соответствующую указанному шаблону поиска и параметру поиска в подкаталогах.</summary>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами каталогов.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <param name="searchOption">Одно из значений перечисления, определяющее, следует ли выполнять поиск только в текущем каталоге или также во всех его подкаталогах. Значение по умолчанию — <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
		/// <returns>Перечисляемая коллекция каталогов, соответствующая параметру <paramref name="searchPattern" /> и <paramref name="searchOption" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> не является допустимым значением <see cref="T:System.IO.SearchOption" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, содержащийся в объекте <see cref="T:System.IO.DirectoryInfo" />, является недействительным (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006729 RID: 26409 RVA: 0x0015FD1A File Offset: 0x0015DF1A
		public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
		{
			return this.EnumerateDirectories(searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x0600672A RID: 26410 RVA: 0x0015FD29 File Offset: 0x0015DF29
		public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return (IEnumerable<DirectoryInfo>)DirectoryInfo.InternalEnumerateInfos(this.FullPath, searchPattern, SearchTarget.Directories, enumerationOptions);
		}

		/// <summary>Возвращает перечисляемую коллекцию сведений о файлах в текущем каталоге.</summary>
		/// <returns>Перечисляемая коллекция файлов в текущем каталоге.</returns>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, содержащийся в объекте <see cref="T:System.IO.DirectoryInfo" />, является недействительным (например,он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600672B RID: 26411 RVA: 0x0015FD3E File Offset: 0x0015DF3E
		public IEnumerable<FileInfo> EnumerateFiles()
		{
			return this.EnumerateFiles("*", EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает перечисляемую коллекцию сведений о файлах, соответствующую шаблону поиска.</summary>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами файлов.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <returns>Перечисляемая коллекция файлов, соответствующая параметру <paramref name="searchPattern" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, содержащийся в объекте <see cref="T:System.IO.DirectoryInfo" />, является недействительным (например,он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600672C RID: 26412 RVA: 0x0015FD50 File Offset: 0x0015DF50
		public IEnumerable<FileInfo> EnumerateFiles(string searchPattern)
		{
			return this.EnumerateFiles(searchPattern, EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает перечисляемую коллекцию сведений о файлах, соответствующую указанному шаблону поиска и параметру поиска в подкаталогах.</summary>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами файлов.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <param name="searchOption">Одно из значений перечисления, определяющее, следует ли выполнять поиск только в текущем каталоге или также во всех его подкаталогах. Значение по умолчанию — <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
		/// <returns>Перечисляемая коллекция файлов, соответствующая параметру <paramref name="searchPattern" /> и <paramref name="searchOption" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> не является допустимым значением <see cref="T:System.IO.SearchOption" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, содержащийся в объекте <see cref="T:System.IO.DirectoryInfo" />, является недействительным (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600672D RID: 26413 RVA: 0x0015FD5E File Offset: 0x0015DF5E
		public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
		{
			return this.EnumerateFiles(searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x0600672E RID: 26414 RVA: 0x0015FD6D File Offset: 0x0015DF6D
		public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return (IEnumerable<FileInfo>)DirectoryInfo.InternalEnumerateInfos(this.FullPath, searchPattern, SearchTarget.Files, enumerationOptions);
		}

		/// <summary>Возвращает перечисляемую коллекцию сведений о файловой системе текущего каталога.</summary>
		/// <returns>Перечисляемая коллекция сведений о файловой системе текущего каталога.</returns>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, содержащийся в объекте <see cref="T:System.IO.DirectoryInfo" />, является недействительным (например,он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600672F RID: 26415 RVA: 0x0015FD82 File Offset: 0x0015DF82
		public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos()
		{
			return this.EnumerateFileSystemInfos("*", EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает перечисляемую коллекцию сведений о файловой системе, соответствующую указанному шаблону поиска.</summary>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами каталогов.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <returns>Перечисляемая коллекция сведений об объектах файловой системы, соответствующая параметру <paramref name="searchPattern" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, содержащийся в объекте <see cref="T:System.IO.DirectoryInfo" />, является недействительным (например,он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006730 RID: 26416 RVA: 0x0015FD94 File Offset: 0x0015DF94
		public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
		{
			return this.EnumerateFileSystemInfos(searchPattern, EnumerationOptions.Compatible);
		}

		/// <summary>Возвращает перечисляемую коллекцию сведений о файловой системе, соответствующую указанному шаблону поиска и параметру поиска в подкаталогах.</summary>
		/// <param name="searchPattern">Строка поиска, которая будет сравниваться с именами каталогов.  Этот параметр может содержать сочетание допустимого литерального пути и подстановочного символа (* и ?), но не поддерживает регулярные выражения.</param>
		/// <param name="searchOption">Одно из значений перечисления, определяющее, следует ли выполнять поиск только в текущем каталоге или также во всех его подкаталогах. Значение по умолчанию — <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
		/// <returns>Перечисляемая коллекция сведений об объектах файловой системы, соответствующая параметру <paramref name="searchPattern" /> и <paramref name="searchOption" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> не является допустимым значением <see cref="T:System.IO.SearchOption" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Путь, содержащийся в объекте <see cref="T:System.IO.DirectoryInfo" />, является недействительным (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006731 RID: 26417 RVA: 0x0015FDA2 File Offset: 0x0015DFA2
		public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return this.EnumerateFileSystemInfos(searchPattern, EnumerationOptions.FromSearchOption(searchOption));
		}

		// Token: 0x06006732 RID: 26418 RVA: 0x0015FDB1 File Offset: 0x0015DFB1
		public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return DirectoryInfo.InternalEnumerateInfos(this.FullPath, searchPattern, SearchTarget.Both, enumerationOptions);
		}

		// Token: 0x06006733 RID: 26419 RVA: 0x0015FDC4 File Offset: 0x0015DFC4
		internal static IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			if (searchPattern == null)
			{
				throw new ArgumentNullException("searchPattern");
			}
			FileSystemEnumerableFactory.NormalizeInputs(ref path, ref searchPattern, options);
			switch (searchTarget)
			{
			case SearchTarget.Files:
				return FileSystemEnumerableFactory.FileInfos(path, searchPattern, options);
			case SearchTarget.Directories:
				return FileSystemEnumerableFactory.DirectoryInfos(path, searchPattern, options);
			case SearchTarget.Both:
				return FileSystemEnumerableFactory.FileSystemInfos(path, searchPattern, options);
			default:
				throw new ArgumentException("Enum value was out of legal range.", "searchTarget");
			}
		}

		/// <summary>Получает корневую часть каталога.</summary>
		/// <returns>Объект, представляющий корень каталога.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06006734 RID: 26420 RVA: 0x0015FE29 File Offset: 0x0015E029
		public DirectoryInfo Root
		{
			get
			{
				return new DirectoryInfo(Path.GetPathRoot(this.FullPath));
			}
		}

		/// <summary>Перемещает экземпляр <see cref="T:System.IO.DirectoryInfo" /> и его содержимое в местоположение, на которое указывает новый путь.</summary>
		/// <param name="destDirName">Имя и путь к местоположению, в которое необходимо переместить указанный каталог. Место назначения не должно находиться на другом томе устройства или в каталоге с идентичным именем. Оно должно представлять собой существующий каталог, в который перемещаемый каталог будет добавлен в виде подкаталога.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destDirName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="destDirName" /> является пустой строкой ("").</exception>
		/// <exception cref="T:System.IO.IOException">Была предпринята попытка переместить каталог в другой том.  
		/// -или- 
		///  <paramref name="destDirName" /> уже существует.  
		/// -или- 
		/// Нет прав доступа к этому пути.  
		///
		/// или - 
		/// Каталог перемещается, и каталог назначения имеет то же имя.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Не удается найти каталог назначения.</exception>
		// Token: 0x06006735 RID: 26421 RVA: 0x0015FE3C File Offset: 0x0015E03C
		public void MoveTo(string destDirName)
		{
			if (destDirName == null)
			{
				throw new ArgumentNullException("destDirName");
			}
			if (destDirName.Length == 0)
			{
				throw new ArgumentException("Empty file name is not legal.", "destDirName");
			}
			string fullPath = Path.GetFullPath(destDirName);
			string text = PathInternal.EnsureTrailingSeparator(fullPath);
			string text2 = PathInternal.EnsureTrailingSeparator(this.FullPath);
			if (string.Equals(text2, text, PathInternal.StringComparison))
			{
				throw new IOException("Source and destination path must be different.");
			}
			string pathRoot = Path.GetPathRoot(text2);
			string pathRoot2 = Path.GetPathRoot(text);
			if (!string.Equals(pathRoot, pathRoot2, PathInternal.StringComparison))
			{
				throw new IOException("Source and destination path must have identical roots. Move will not work across volumes.");
			}
			if (!this.Exists && !FileSystem.FileExists(this.FullPath))
			{
				throw new DirectoryNotFoundException(SR.Format("Could not find a part of the path '{0}'.", this.FullPath));
			}
			if (FileSystem.DirectoryExists(fullPath))
			{
				throw new IOException(SR.Format("Cannot create '{0}' because a file or directory with the same name already exists.", text));
			}
			FileSystem.MoveDirectory(this.FullPath, fullPath);
			this.Init(destDirName, text, null, true);
			base.Invalidate();
		}

		/// <summary>Удаляет этот <see cref="T:System.IO.DirectoryInfo" />, если он пуст.</summary>
		/// <exception cref="T:System.UnauthorizedAccessException">Каталог содержит файл только для чтения.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Каталог, описанный этим объектом <see cref="T:System.IO.DirectoryInfo" />, не существует или не найден.</exception>
		/// <exception cref="T:System.IO.IOException">Каталог не пуст.  
		///
		/// или - 
		/// Каталог является текущим рабочим каталогом приложения.  
		///
		/// -или- 
		/// Для каталога имеется открытый дескриптор, используется операционная система Windows XP или более ранняя версия. Открытый дескриптор мог появиться в результате перечисления каталогов. Дополнительные сведения см. в разделе Как перечислить каталоги и файлы.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006736 RID: 26422 RVA: 0x0015FF25 File Offset: 0x0015E125
		public override void Delete()
		{
			FileSystem.RemoveDirectory(this.FullPath, false);
		}

		/// <summary>Удаляет данный экземпляр <see cref="T:System.IO.DirectoryInfo" />, указывая, следует ли также удалить подкаталоги и файлы.</summary>
		/// <param name="recursive">Значение <see langword="true" /> позволяет удалить каталог, его подкаталоги и все файлы, в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.UnauthorizedAccessException">Каталог содержит файл только для чтения.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Каталог, описанный этим объектом <see cref="T:System.IO.DirectoryInfo" />, не существует или не найден.</exception>
		/// <exception cref="T:System.IO.IOException">Каталог доступен только для чтения.  
		/// -или- 
		/// Каталог содержит файлы или подкаталоги и <paramref name="recursive" /> равен <see langword="false" />.  
		///
		/// или - 
		/// Каталог является текущим рабочим каталогом приложения.  
		///
		/// -или- 
		/// Для каталога или одного из его файлов имеется открытый дескриптор, а операционной системой является Windows XP или более ранней версии. Этот открытый дескриптор может быть результатом перечисления каталогов и файлов. Дополнительные сведения см. в разделе Как перечислить каталоги и файлы.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006737 RID: 26423 RVA: 0x0015FF33 File Offset: 0x0015E133
		public void Delete(bool recursive)
		{
			FileSystem.RemoveDirectory(this.FullPath, recursive);
		}

		// Token: 0x06006738 RID: 26424 RVA: 0x0015FF41 File Offset: 0x0015E141
		private DirectoryInfo(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Создает каталог с помощью объекта <see cref="T:System.Security.AccessControl.DirectorySecurity" />.</summary>
		/// <param name="directorySecurity">Элемент управления доступом, который необходимо применить к каталогу.</param>
		/// <exception cref="T:System.IO.IOException">Каталог, заданный параметром <paramref name="path" />, доступен только для чтения или не является пустым каталогом.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.NotSupportedException">Предпринята попытка создать каталог с единственным знаком двоеточия (:).</exception>
		// Token: 0x06006739 RID: 26425 RVA: 0x0015FF4B File Offset: 0x0015E14B
		public void Create(DirectorySecurity directorySecurity)
		{
			FileSystem.CreateDirectory(this.FullPath);
		}

		/// <summary>Создает один или несколько подкаталогов по заданному пути с заданными параметрами безопасности. Путь может быть задан относительно текущего экземпляра класса <see cref="T:System.IO.DirectoryInfo" />.</summary>
		/// <param name="path">Заданный путь. Этот путь не может указывать на другой том диска или иметь формат UNC.</param>
		/// <param name="directorySecurity">Параметры безопасности, которые необходимо применить.</param>
		/// <returns>Последний каталог, на который указывает <paramref name="path" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> не указывает допустимый путь к файлу или содержит недопустимые символы <see langword="DirectoryInfo" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, ведущий на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Невозможно создать подкаталог.  
		/// -или- 
		/// Файл или каталог уже имеет имя, указанное <paramref name="path" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект не имеет разрешения доступа к коду для создания каталога.  
		/// -или- 
		/// Вызывающий объект не имеет разрешения доступа к коду для чтения каталога, описанного возвращаемым объектом <see cref="T:System.IO.DirectoryInfo" />.  Это может произойти, если параметр <paramref name="path" /> описывает существующий каталог.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> содержит двоеточие (:), которое не является частью метки диска (C:\).</exception>
		// Token: 0x0600673A RID: 26426 RVA: 0x0015FF58 File Offset: 0x0015E158
		public DirectoryInfo CreateSubdirectory(string path, DirectorySecurity directorySecurity)
		{
			return this.CreateSubdirectory(path);
		}

		/// <summary>Получает объект <see cref="T:System.Security.AccessControl.DirectorySecurity" />, который инкапсулирует записи списка управления доступом (ACL) для каталога, описываемого текущим объектом <see cref="T:System.IO.DirectoryInfo" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.DirectorySecurity" />, который инкапсулирует правила управления доступом к каталогу.</returns>
		/// <exception cref="T:System.SystemException">Не удается найти или изменить каталог.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Каталог доступен только для чтения.  
		/// -или- 
		/// Эта операция не поддерживается на текущей платформе.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.IO.IOException">При открытии каталога возникла ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows 2000 или более поздней версией Windows.</exception>
		// Token: 0x0600673B RID: 26427 RVA: 0x0015FF61 File Offset: 0x0015E161
		public DirectorySecurity GetAccessControl()
		{
			return Directory.GetAccessControl(this.FullPath, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
		}

		/// <summary>Получает объект <see cref="T:System.Security.AccessControl.DirectorySecurity" />, который инкапсулирует заданный тип записей списка управления доступом для каталога, описываемого текущим объектом <see cref="T:System.IO.DirectoryInfo" />.</summary>
		/// <param name="includeSections">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее тип сведений о списке ACL, которые необходимо получить.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.DirectorySecurity" />, который инкапсулирует правила управления доступом для файла, описанные параметром <paramref name="path" />.  
		/// Исключения 
		///   Тип исключения 
		///   Условие 
		///  <see cref="T:System.SystemException" /> Не удается найти или изменить каталог.  
		///  <see cref="T:System.UnauthorizedAccessException" /> Текущий процесс не может открыть каталог из-за отсутствия соответствующих прав доступа.  
		///  <see cref="T:System.IO.IOException" /> При открытии каталога возникла ошибка ввода-вывода.  
		///  <see cref="T:System.PlatformNotSupportedException" /> Текущая операционная система не является системой Microsoft Windows 2000 или более поздней версией Windows.  
		///  <see cref="T:System.UnauthorizedAccessException" /> Каталог доступен только для чтения.  
		///
		/// или - 
		/// Эта операция не поддерживается на текущей платформе.  
		///
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение.</returns>
		// Token: 0x0600673C RID: 26428 RVA: 0x0015FF70 File Offset: 0x0015E170
		public DirectorySecurity GetAccessControl(AccessControlSections includeSections)
		{
			return Directory.GetAccessControl(this.FullPath, includeSections);
		}

		/// <summary>Применяет записи списка управления доступом (ACL), описанные объектом <see cref="T:System.Security.AccessControl.DirectorySecurity" />, к каталогу, который описывается текущим объектом <see cref="T:System.IO.DirectoryInfo" />.</summary>
		/// <param name="directorySecurity">Объект, характеризующий запись ACL, которую необходимо применить к каталогу, описанному параметром <paramref name="path" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="directorySecurity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.SystemException">Не удалось найти или изменить файл.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Текущий процесс не может открыть файл из-за отсутствия соответствующих прав доступа.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Microsoft Windows 2000 или более поздней версией Windows.</exception>
		// Token: 0x0600673D RID: 26429 RVA: 0x0015FF7E File Offset: 0x0015E17E
		public void SetAccessControl(DirectorySecurity directorySecurity)
		{
			Directory.SetAccessControl(this.FullPath, directorySecurity);
		}
	}
}
