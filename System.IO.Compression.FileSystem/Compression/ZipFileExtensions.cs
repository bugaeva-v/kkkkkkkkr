using System;
using System.ComponentModel;

namespace System.IO.Compression
{
	/// <summary>Предоставляет методы расширения для классов <see cref="T:System.IO.Compression.ZipArchive" /> и <see cref="T:System.IO.Compression.ZipArchiveEntry" />.</summary>
	// Token: 0x02000006 RID: 6
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ZipFileExtensions
	{
		/// <summary>Архивирует файл, сжимая его и добавляя его в ZIP-архив.</summary>
		/// <param name="destination">ZIP-архив, в который добавляется файл.</param>
		/// <param name="sourceFileName">Путь к файлу, который необходимо заархивировать. Можно указать относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <param name="entryName">Имя записи, которую требуется создать в ZIP-архиве.</param>
		/// <returns>Программа-оболочка для новой записи в ZIP-архиве.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="sourceFileName" /> имеет значение <see cref="F:System.String.Empty" />, содержит только пробел или по крайней мере один недопустимый символ.  
		/// -или- 
		///  Свойство <paramref name="entryName" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceFileName" /> или <paramref name="entryName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">В <paramref name="sourceFileName" /> длина указанного пути, имени файла или обоих параметров превышает установленное в системе максимальное значение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="sourceFileName" /> (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Файл, заданный <paramref name="sourceFileName" />, не может быть открыт или слишком велик для изменения (текущий предел: Int32.MaxValue).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="sourceFileName" /> задает каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует разрешение на доступ к файлу, указанному параметром <paramref name="sourceFileName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="sourceFileName" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="sourceFileName" /> имеет недопустимый формат.  
		/// -или- 
		/// ZIP-архив не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">ZIP-архив был удален.</exception>
		// Token: 0x06000014 RID: 20 RVA: 0x00002514 File Offset: 0x00000714
		public static ZipArchiveEntry CreateEntryFromFile(this ZipArchive destination, string sourceFileName, string entryName)
		{
			return ZipFileExtensions.DoCreateEntryFromFile(destination, sourceFileName, entryName, null);
		}

		/// <summary>Архивирует файл, сжимая его с использованием заданного уровня сжатия и добавляя его в ZIP-архив.</summary>
		/// <param name="destination">ZIP-архив, в который добавляется файл.</param>
		/// <param name="sourceFileName">Путь к файлу, который необходимо заархивировать. Можно указать относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <param name="entryName">Имя записи, которую требуется создать в ZIP-архиве.</param>
		/// <param name="compressionLevel">Одно из значений перечисления, указывающее, акцентировать ли внимание на скорости или эффективности сжатия при создании записи.</param>
		/// <returns>Программа-оболочка для новой записи в ZIP-архиве.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="sourceFileName" /> имеет значение <see cref="F:System.String.Empty" />, содержит только пробел или по крайней мере один недопустимый символ.  
		/// -или- 
		///  Свойство <paramref name="entryName" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceFileName" /> или <paramref name="entryName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Недопустимый <paramref name="sourceFileName" /> (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.PathTooLongException">В <paramref name="sourceFileName" /> длина указанного пути, имени файла или обоих параметров превышает установленное в системе максимальное значение.</exception>
		/// <exception cref="T:System.IO.IOException">Файл, заданный <paramref name="sourceFileName" />, не может быть открыт или слишком велик для изменения (текущий предел: Int32.MaxValue).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="sourceFileName" /> задает каталог.  
		/// -или- 
		/// У вызывающего объекта отсутствует разрешение на доступ к файлу, указанному параметром <paramref name="sourceFileName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный параметром <paramref name="sourceFileName" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="sourceFileName" /> имеет недопустимый формат.  
		/// -или- 
		/// ZIP-архив не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">ZIP-архив был удален.</exception>
		// Token: 0x06000015 RID: 21 RVA: 0x00002532 File Offset: 0x00000732
		public static ZipArchiveEntry CreateEntryFromFile(this ZipArchive destination, string sourceFileName, string entryName, CompressionLevel compressionLevel)
		{
			return ZipFileExtensions.DoCreateEntryFromFile(destination, sourceFileName, entryName, new CompressionLevel?(compressionLevel));
		}

		/// <summary>Извлекает все файлы из ZIP-архива в каталог в файловой системе.</summary>
		/// <param name="source">ZIP-архив, из которого нужно извлечь файлы.</param>
		/// <param name="destinationDirectoryName">Путь к каталогу, в который нужно поместить извлеченные файлы. Можно указать относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="destinationDirectoryName" /> имеет значение <see cref="F:System.String.Empty" />, содержит только пробел или по крайней мере один недопустимый символ.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationDirectoryName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Длина указанного пути превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Каталог, указанный в параметре <paramref name="destinationDirectoryName" />, уже существует.  
		/// -или- 
		/// Имя записи в архиве имеет значение <see cref="F:System.String.Empty" />, содержит только пробел или по крайней мере один недопустимый символ.  
		/// -или- 
		/// При извлечении записи из архива будет создан файл, который находится вне каталога, заданного параметром <paramref name="destinationDirectoryName" />. (Это может произойти, например, если имя записи содержит методы доступа к родительскому каталогу.) 
		/// -или- 
		/// Две или несколько записей в архиве имеют одинаковые имена.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта нет необходимого разрешения для записи в каталог назначения.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="destinationDirectoryName" /> содержит недопустимый формат.</exception>
		/// <exception cref="T:System.IO.InvalidDataException">Запись архива не найдена или повреждена.  
		/// -или- 
		/// Запись архива была сжата с помощью неподдерживаемого метода сжатия.</exception>
		// Token: 0x06000016 RID: 22 RVA: 0x00002542 File Offset: 0x00000742
		public static void ExtractToDirectory(this ZipArchive source, string destinationDirectoryName)
		{
			source.ExtractToDirectory(destinationDirectoryName, false);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000254C File Offset: 0x0000074C
		public static void ExtractToDirectory(this ZipArchive source, string destinationDirectoryName, bool overwrite)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (destinationDirectoryName == null)
			{
				throw new ArgumentNullException("destinationDirectoryName");
			}
			string text = Directory.CreateDirectory(destinationDirectoryName).FullName;
			if (!text.EndsWith(Path.DirectorySeparatorChar))
			{
				text += Path.DirectorySeparatorChar.ToString();
			}
			foreach (ZipArchiveEntry zipArchiveEntry in source.Entries)
			{
				string fullPath = Path.GetFullPath(Path.Combine(text, zipArchiveEntry.FullName));
				if (!fullPath.StartsWith(text, PathInternal.StringComparison))
				{
					throw new IOException("Extracting Zip entry would have resulted in a file outside the specified destination directory.");
				}
				if (Path.GetFileName(fullPath).Length == 0)
				{
					if (zipArchiveEntry.Length != 0L)
					{
						throw new IOException("Zip entry name ends in directory separator character but contains data.");
					}
					Directory.CreateDirectory(fullPath);
				}
				else
				{
					Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
					zipArchiveEntry.ExtractToFile(fullPath, overwrite);
				}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002640 File Offset: 0x00000840
		internal static ZipArchiveEntry DoCreateEntryFromFile(ZipArchive destination, string sourceFileName, string entryName, CompressionLevel? compressionLevel)
		{
			if (destination == null)
			{
				throw new ArgumentNullException("destination");
			}
			if (sourceFileName == null)
			{
				throw new ArgumentNullException("sourceFileName");
			}
			if (entryName == null)
			{
				throw new ArgumentNullException("entryName");
			}
			ZipArchiveEntry result;
			using (Stream stream = new FileStream(sourceFileName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, false))
			{
				ZipArchiveEntry zipArchiveEntry = (compressionLevel != null) ? destination.CreateEntry(entryName, compressionLevel.Value) : destination.CreateEntry(entryName);
				DateTime lastWriteTime = File.GetLastWriteTime(sourceFileName);
				if (lastWriteTime.Year < 1980 || lastWriteTime.Year > 2107)
				{
					lastWriteTime = new DateTime(1980, 1, 1, 0, 0, 0);
				}
				zipArchiveEntry.LastWriteTime = lastWriteTime;
				using (Stream stream2 = zipArchiveEntry.Open())
				{
					stream.CopyTo(stream2);
				}
				result = zipArchiveEntry;
			}
			return result;
		}

		/// <summary>Извлекает запись в ZIP-архиве в файл.</summary>
		/// <param name="source">ZIP-архив, из которого извлекается файл.</param>
		/// <param name="destinationFileName">Путь к файлу, создаваемому из содержимого записи. Можно указать относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="destinationFileName" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.  
		/// -или- 
		///  Параметр <paramref name="destinationFileName" /> задает каталог.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="destinationFileName" /> уже существует.  
		/// -или- 
		/// Ошибка ввода/вывода.  
		/// -или- 
		/// Запись в текущий момент открыта для записи.  
		/// -или- 
		/// Запись была удалена из архива.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Вызывающий объект не имеет необходимых разрешений на создание нового файла.</exception>
		/// <exception cref="T:System.IO.InvalidDataException">Запись в архиве отсутствует либо была повреждена и ее невозможно прочитать.  
		/// -или- 
		/// Запись была сжата с использованием неподдерживаемого метода сжатия.</exception>
		/// <exception cref="T:System.ObjectDisposedException">ZIP-архив, которому принадлежит эта запись, был удален.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="destinationFileName" /> задан в недопустимом формате.  
		/// -или- 
		/// ZIP-архив для этой записи был открыт в режиме <see cref="F:System.IO.Compression.ZipArchiveMode.Create" />, который не разрешает получение записей.</exception>
		// Token: 0x06000019 RID: 25 RVA: 0x00002730 File Offset: 0x00000930
		public static void ExtractToFile(this ZipArchiveEntry source, string destinationFileName)
		{
			source.ExtractToFile(destinationFileName, false);
		}

		/// <summary>Извлекает запись из ZIP-архива в файл и при необходимости перезаписывает существующий файл с тем же именем.</summary>
		/// <param name="source">ZIP-архив, из которого извлекается файл.</param>
		/// <param name="destinationFileName">Путь к файлу, создаваемому из содержимого записи. Можно указать относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <param name="overwrite">Значение <see langword="true" />, чтобы перезаписывался существующий файл с тем же именем, что и файл назначения; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="destinationFileName" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.  
		/// -или- 
		///  Параметр <paramref name="destinationFileName" /> задает каталог.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Имя, заданное в параметре <paramref name="destinationFileName" />, уже существует, а параметр <paramref name="overwrite" /> имеет значение <see langword="false" />.  
		/// -или- 
		/// Ошибка ввода/вывода.  
		/// -или- 
		/// Запись в текущий момент открыта для записи.  
		/// -или- 
		/// Запись была удалена из архива.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Вызывающий объект не имеет необходимых разрешений на создание нового файла.</exception>
		/// <exception cref="T:System.IO.InvalidDataException">Запись в архиве отсутствует или была повреждена, и ее невозможно прочитать.  
		/// -или- 
		/// Запись была сжата с использованием неподдерживаемого метода сжатия.</exception>
		/// <exception cref="T:System.ObjectDisposedException">ZIP-архив, которому принадлежит эта запись, был удален.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="destinationFileName" /> задан в недопустимом формате.  
		/// -или- 
		/// ZIP-архив для этой записи был открыт в режиме <see cref="F:System.IO.Compression.ZipArchiveMode.Create" />, который не разрешает получение записей.</exception>
		// Token: 0x0600001A RID: 26 RVA: 0x0000273C File Offset: 0x0000093C
		public static void ExtractToFile(this ZipArchiveEntry source, string destinationFileName, bool overwrite)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (destinationFileName == null)
			{
				throw new ArgumentNullException("destinationFileName");
			}
			FileMode mode = overwrite ? FileMode.Create : FileMode.CreateNew;
			using (Stream stream = new FileStream(destinationFileName, mode, FileAccess.Write, FileShare.None, 4096, false))
			{
				using (Stream stream2 = source.Open())
				{
					stream2.CopyTo(stream);
				}
			}
			File.SetLastWriteTime(destinationFileName, source.LastWriteTime.DateTime);
		}
	}
}
