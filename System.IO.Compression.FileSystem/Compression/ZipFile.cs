using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace System.IO.Compression
{
	/// <summary>Предоставляет статические методы для создания, извлечения и открытия ZIP-архивов.</summary>
	// Token: 0x02000005 RID: 5
	public static class ZipFile
	{
		/// <summary>Открывает для чтения ZIP-архив по указанному пути.</summary>
		/// <param name="archiveFileName">Путь к открываемому архиву, заданный как относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <returns>Открытый ZIP-архив.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="archiveFileName" /> имеет значение <see cref="F:System.String.Empty" />, содержит только пробел или по крайней мере один недопустимый символ.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="archiveFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">В <paramref name="archiveFileName" /> длина указанного пути, имени файла или обоих параметров превышает установленное в системе максимальное значение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Параметр <paramref name="archiveFileName" /> недопустим или не существует (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.IO.IOException">Не удалось открыть <paramref name="archiveFileName" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="archiveFileName" /> задает каталог.  
		///
		/// или - 
		/// У вызывающего оператора отсутствует разрешение на доступ к файлу, указанному в параметре <paramref name="archiveFileName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, заданный в <paramref name="archiveFileName" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="archiveFileName" /> содержит недопустимый формат.</exception>
		/// <exception cref="T:System.IO.InvalidDataException">
		///   <paramref name="archiveFileName" /> не может интерпретироваться как ZIP-архив.</exception>
		// Token: 0x06000006 RID: 6 RVA: 0x00002100 File Offset: 0x00000300
		public static ZipArchive OpenRead(string archiveFileName)
		{
			return ZipFile.Open(archiveFileName, ZipArchiveMode.Read);
		}

		/// <summary>Открывает ZIP-архив по указанному пути и в заданном режиме.</summary>
		/// <param name="archiveFileName">Путь к открываемому архиву, заданный как относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <param name="mode">Одно из значений перечисления, указывающее действия, которые разрешены над записями в открытом архиве.</param>
		/// <returns>Открытый ZIP-архив.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="archiveFileName" /> имеет значение <see cref="F:System.String.Empty" />, содержит только пробел или по крайней мере один недопустимый символ.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="archiveFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">В <paramref name="archiveFileName" /> длина указанного пути, имени файла или обоих параметров превышает установленное в системе максимальное значение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Параметр <paramref name="archiveFileName" /> недопустим или не существует (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.IO.IOException">Не удалось открыть <paramref name="archiveFileName" />.  
		///
		/// или - 
		/// <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Create" />, однако файл, указанный в <paramref name="archiveFileName" />, уже существует.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="archiveFileName" /> задает каталог.  
		///
		/// или - 
		/// У вызывающего оператора отсутствует разрешение на доступ к файлу, указанному в параметре <paramref name="archiveFileName" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="mode" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Read" />, однако файл, указанный в <paramref name="archiveFileName" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="archiveFileName" /> содержит недопустимый формат.</exception>
		/// <exception cref="T:System.IO.InvalidDataException">
		///   <paramref name="archiveFileName" /> не может интерпретироваться как ZIP-архив.  
		///
		/// или - 
		/// <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Update" />, однако запись отсутствует в архиве или повреждена и не может быть прочитана.  
		///
		/// или - 
		/// <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Update" />, однако запись слишком велика, чтобы поместиться в памяти.</exception>
		// Token: 0x06000007 RID: 7 RVA: 0x00002109 File Offset: 0x00000309
		public static ZipArchive Open(string archiveFileName, ZipArchiveMode mode)
		{
			return ZipFile.Open(archiveFileName, mode, null);
		}

		/// <summary>Открывает ZIP-архив по указанному пути в указанном режиме и с использованием указанной кодировки символов для имен записей.</summary>
		/// <param name="archiveFileName">Путь к открываемому архиву, заданный как относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <param name="mode">Одно из значений перечисления, указывающее действия, которые разрешены над записями в открытом архиве.</param>
		/// <param name="entryNameEncoding">Кодирование, используемое при чтении или записи имен записей в этом архиве. Задайте значение для этого параметра, только если кодирование требуется для взаимодействия с инструментами и библиотеками ZIP-архива, которые не поддерживают кодирование UTF-8 для имен записей.</param>
		/// <returns>Открытый ZIP-архив.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="archiveFileName" /> имеет значение <see cref="F:System.String.Empty" />, содержит только пробел или по крайней мере один недопустимый символ.  
		///
		/// или - 
		/// <paramref name="entryNameEncoding" /> установлено на кодировку Юникода, отличное от UTF-8.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="archiveFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">В <paramref name="archiveFileName" /> длина указанного пути, имени файла или обоих параметров превышает установленное в системе максимальное значение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Параметр <paramref name="archiveFileName" /> недопустим или не существует (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.IO.IOException">Не удалось открыть <paramref name="archiveFileName" />.  
		///
		/// или - 
		/// <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Create" />, однако файл, указанный в <paramref name="archiveFileName" />, уже существует.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="archiveFileName" /> задает каталог.  
		///
		/// или - 
		/// У вызывающего оператора отсутствует разрешение на доступ к файлу, указанному в параметре <paramref name="archiveFileName" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="mode" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Read" />, однако файл, указанный в <paramref name="archiveFileName" />, не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="archiveFileName" /> содержит недопустимый формат.</exception>
		/// <exception cref="T:System.IO.InvalidDataException">
		///   <paramref name="archiveFileName" /> не может интерпретироваться как ZIP-архив.  
		///
		/// или - 
		/// <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Update" />, однако запись отсутствует в архиве или повреждена и не может быть прочитана.  
		///
		/// или - 
		/// <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Update" />, однако запись слишком велика, чтобы поместиться в памяти.</exception>
		// Token: 0x06000008 RID: 8 RVA: 0x00002114 File Offset: 0x00000314
		public static ZipArchive Open(string archiveFileName, ZipArchiveMode mode, Encoding entryNameEncoding)
		{
			FileMode mode2;
			FileAccess access;
			FileShare share;
			switch (mode)
			{
			case ZipArchiveMode.Read:
				mode2 = FileMode.Open;
				access = FileAccess.Read;
				share = FileShare.Read;
				break;
			case ZipArchiveMode.Create:
				mode2 = FileMode.CreateNew;
				access = FileAccess.Write;
				share = FileShare.None;
				break;
			case ZipArchiveMode.Update:
				mode2 = FileMode.OpenOrCreate;
				access = FileAccess.ReadWrite;
				share = FileShare.None;
				break;
			default:
				throw new ArgumentOutOfRangeException("mode");
			}
			FileStream fileStream = new FileStream(archiveFileName, mode2, access, share, 4096, false);
			ZipArchive result;
			try
			{
				result = new ZipArchive(fileStream, mode, false, entryNameEncoding);
			}
			catch
			{
				fileStream.Dispose();
				throw;
			}
			return result;
		}

		/// <summary>Создает ZIP архив, содержащий файлы и каталоги из указанного каталога.</summary>
		/// <param name="sourceDirectoryName">Путь к архивируемому каталогу, заданный как относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <param name="destinationArchiveFileName">Путь создаваемого архива, заданный как относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="sourceDirectoryName" /> или <paramref name="destinationArchiveFileName" /> является <see cref="F:System.String.Empty" />, содержит только пробелы или хотя бы один недопустимый символ.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceDirectoryName" /> или <paramref name="destinationArchiveFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">В<paramref name="sourceDirectoryName" /> или <paramref name="destinationArchiveFileName" /> длина указанного пути, имени файла или обоих параметров превышает установленное в системе максимальное значение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Параметр <paramref name="sourceDirectoryName" /> недопустим или не существует (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="destinationArchiveFileName" /> уже существует.  
		///
		/// или - 
		/// Не удалось открыть файл в указанном каталоге.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="destinationArchiveFileName" /> задает каталог.  
		///
		/// или - 
		/// Вызывающий код не имеет необходимого разрешения на доступ к каталогу, указанному в <paramref name="sourceDirectoryName" />, или к файлу, указанному в <paramref name="destinationArchiveFileName" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="sourceDirectoryName" /> или <paramref name="destinationArchiveFileName" /> содержит недопустимый формат.  
		///
		/// или - 
		/// ZIP-архив не поддерживает запись.</exception>
		// Token: 0x06000009 RID: 9 RVA: 0x00002190 File Offset: 0x00000390
		public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName)
		{
			ZipFile.DoCreateFromDirectory(sourceDirectoryName, destinationArchiveFileName, null, false, null);
		}

		/// <summary>Создает ZIP-архив, содержащий файлы и каталоги из указанного каталога, использует указанный уровень сжатия и необязательно включает базовый каталог.</summary>
		/// <param name="sourceDirectoryName">Путь к архивируемому каталогу, заданный как относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <param name="destinationArchiveFileName">Путь создаваемого архива, заданный как относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <param name="compressionLevel">Одно из значений перечисления, указывающее, акцентировать ли внимание на скорости или эффективности сжатия при создании записи.</param>
		/// <param name="includeBaseDirectory">Значение <see langword="true" />, чтобы включить имя каталога из параметра <paramref name="sourceDirectoryName" /> в корень архива; значение <see langword="false" />, чтобы включать только содержимое этого каталога.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="sourceDirectoryName" /> или <paramref name="destinationArchiveFileName" /> является <see cref="F:System.String.Empty" />, содержит только пробелы или хотя бы один недопустимый символ.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceDirectoryName" /> или <paramref name="destinationArchiveFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">В<paramref name="sourceDirectoryName" /> или <paramref name="destinationArchiveFileName" /> длина указанного пути, имени файла или обоих параметров превышает установленное в системе максимальное значение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Параметр <paramref name="sourceDirectoryName" /> недопустим или не существует (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="destinationArchiveFileName" /> уже существует.  
		///
		/// или - 
		/// Не удалось открыть файл в указанном каталоге.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="destinationArchiveFileName" /> задает каталог.  
		///
		/// или - 
		/// Вызывающий код не имеет необходимого разрешения на доступ к каталогу, указанному в <paramref name="sourceDirectoryName" />, или к файлу, указанному в <paramref name="destinationArchiveFileName" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="sourceDirectoryName" /> или <paramref name="destinationArchiveFileName" /> содержит недопустимый формат.  
		///
		/// или - 
		/// ZIP-архив не поддерживает запись.</exception>
		// Token: 0x0600000A RID: 10 RVA: 0x000021AF File Offset: 0x000003AF
		public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory)
		{
			ZipFile.DoCreateFromDirectory(sourceDirectoryName, destinationArchiveFileName, new CompressionLevel?(compressionLevel), includeBaseDirectory, null);
		}

		/// <summary>Создает ZIP-архив, содержащий файлы и каталоги из указанного каталога, использует указанный уровень сжатия и кодировку символов для имен записей и необязательно включает базовый каталог.</summary>
		/// <param name="sourceDirectoryName">Путь к архивируемому каталогу, заданный как относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <param name="destinationArchiveFileName">Путь создаваемого архива, заданный как относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <param name="compressionLevel">Одно из значений перечисления, указывающее, акцентировать ли внимание на скорости или эффективности сжатия при создании записи.</param>
		/// <param name="includeBaseDirectory">Значение <see langword="true" />, чтобы включить имя каталога из параметра <paramref name="sourceDirectoryName" /> в корень архива; значение <see langword="false" />, чтобы включать только содержимое этого каталога.</param>
		/// <param name="entryNameEncoding">Кодирование, используемое при чтении или записи имен записей в этом архиве. Задайте значение для этого параметра, только если кодирование требуется для взаимодействия с инструментами и библиотеками ZIP-архива, которые не поддерживают кодирование UTF-8 для имен записей.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="sourceDirectoryName" /> или <paramref name="destinationArchiveFileName" /> является <see cref="F:System.String.Empty" />, содержит только пробелы или хотя бы один недопустимый символ.  
		///
		/// или - 
		/// <paramref name="entryNameEncoding" /> установлено на кодировку Юникода, отличное от UTF-8.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceDirectoryName" /> или <paramref name="destinationArchiveFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">В<paramref name="sourceDirectoryName" /> или <paramref name="destinationArchiveFileName" /> длина указанного пути, имени файла или обоих параметров превышает установленное в системе максимальное значение.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Параметр <paramref name="sourceDirectoryName" /> недопустим или не существует (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="destinationArchiveFileName" /> уже существует.  
		///
		/// или - 
		/// Не удалось открыть файл в указанном каталоге.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Параметр <paramref name="destinationArchiveFileName" /> задает каталог.  
		///
		/// или - 
		/// Вызывающий код не имеет необходимого разрешения на доступ к каталогу, указанному в <paramref name="sourceDirectoryName" />, или к файлу, указанному в <paramref name="destinationArchiveFileName" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="sourceDirectoryName" /> или <paramref name="destinationArchiveFileName" /> содержит недопустимый формат.  
		///
		/// или - 
		/// ZIP-архив не поддерживает запись.</exception>
		// Token: 0x0600000B RID: 11 RVA: 0x000021C0 File Offset: 0x000003C0
		public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding)
		{
			ZipFile.DoCreateFromDirectory(sourceDirectoryName, destinationArchiveFileName, new CompressionLevel?(compressionLevel), includeBaseDirectory, entryNameEncoding);
		}

		/// <summary>Извлекает все файлы в указанном ZIP-архиве в каталогу в файловой системе.</summary>
		/// <param name="sourceArchiveFileName">Путь к архиву, который требуется извлечь.</param>
		/// <param name="destinationDirectoryName">Путь к каталогу, в котором следует поместить извлеченные файлы, заданный как относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="destinationDirectoryName" /> или <paramref name="sourceArchiveFileName" /> является <see cref="F:System.String.Empty" />, содержит только пробелы или хотя бы один недопустимый символ.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="destinationDirectoryName" /> или <paramref name="sourceArchiveFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанная длина пути в <paramref name="destinationDirectoryName" /> или <paramref name="sourceArchiveFileName" /> превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Каталог, указанный в параметре <paramref name="destinationDirectoryName" />, уже существует.  
		///
		/// или - 
		/// Имя записи в архиве имеет значение <see cref="F:System.String.Empty" />, содержит только пробел или по крайней мере один недопустимый символ.  
		///
		/// или - 
		/// Извлечение записи архива создаст файл, который находится вне каталога, заданного <paramref name="destinationDirectoryName" />. (Это может произойти, например, если имя записи содержит методы доступа к родительскому каталогу.) 
		///
		/// или - 
		/// Запись архива, которую требуется извлечь, имеет то же имя, что и запись, которая уже была извлекается из того же архива.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Вызывающий код не имеет необходимого разрешения на доступ к архиву или целевому каталогу.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="destinationDirectoryName" /> или <paramref name="sourceArchiveFileName" /> содержит недопустимый формат.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="sourceArchiveFileName" />.</exception>
		/// <exception cref="T:System.IO.InvalidDataException">Архив, заданный параметром <paramref name="sourceArchiveFileName" />, не является допустимым ZIP-архивом.  
		///
		/// или - 
		/// Не удалось найти запись архива или она была повреждена.  
		///
		/// или - 
		/// Запись архива была сжата с помощью неподдерживаемого метода сжатия.</exception>
		// Token: 0x0600000C RID: 12 RVA: 0x000021D2 File Offset: 0x000003D2
		public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName)
		{
			ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName, null);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021DC File Offset: 0x000003DC
		public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, bool overwrite)
		{
			ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName, null, overwrite);
		}

		/// <summary>Извлекает все файлы в указанном ZIP-архиве к каталог в файловой системе и использует указанную кодировку для имен записей.</summary>
		/// <param name="sourceArchiveFileName">Путь к архиву, который требуется извлечь.</param>
		/// <param name="destinationDirectoryName">Путь к каталогу, в котором следует поместить извлеченные файлы, заданный как относительный или абсолютный путь. Относительный путь интерпретируется относительно текущего рабочего каталога.</param>
		/// <param name="entryNameEncoding">Кодирование, используемое при чтении или записи имен записей в этом архиве. Задайте значение для этого параметра, только если кодирование требуется для взаимодействия с инструментами и библиотеками ZIP-архива, которые не поддерживают кодирование UTF-8 для имен записей.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="destinationDirectoryName" /> или <paramref name="sourceArchiveFileName" /> является <see cref="F:System.String.Empty" />, содержит только пробелы или хотя бы один недопустимый символ.  
		///
		/// или - 
		/// <paramref name="entryNameEncoding" /> установлено на кодировку Юникода, отличное от UTF-8.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="destinationDirectoryName" /> или <paramref name="sourceArchiveFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанная длина пути в <paramref name="destinationDirectoryName" /> или <paramref name="sourceArchiveFileName" /> превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь (например, он ведет на несопоставленный диск).</exception>
		/// <exception cref="T:System.IO.IOException">Каталог, указанный в параметре <paramref name="destinationDirectoryName" />, уже существует.  
		///
		/// или - 
		/// Имя записи в архиве имеет значение <see cref="F:System.String.Empty" />, содержит только пробел или по крайней мере один недопустимый символ.  
		///
		/// или - 
		/// Извлечение записи архива создаст файл, который находится вне каталога, заданного <paramref name="destinationDirectoryName" />. (Это может произойти, например, если имя записи содержит методы доступа к родительскому каталогу.) 
		///
		/// или - 
		/// Запись архива, которую требуется извлечь, имеет то же имя, что и запись, которая уже была извлекается из того же архива.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Вызывающий код не имеет необходимого разрешения на доступ к архиву или целевому каталогу.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="destinationDirectoryName" /> или <paramref name="sourceArchiveFileName" /> содержит недопустимый формат.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="sourceArchiveFileName" />.</exception>
		/// <exception cref="T:System.IO.InvalidDataException">Архив, заданный параметром <paramref name="sourceArchiveFileName" />, не является допустимым ZIP-архивом.  
		///
		/// или - 
		/// Не удалось найти запись архива или она была повреждена.  
		///
		/// или - 
		/// Запись архива была сжата с помощью неподдерживаемого метода сжатия.</exception>
		// Token: 0x0600000E RID: 14 RVA: 0x000021E7 File Offset: 0x000003E7
		public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding)
		{
			ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName, entryNameEncoding, false);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021F4 File Offset: 0x000003F4
		public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding, bool overwrite)
		{
			if (sourceArchiveFileName == null)
			{
				throw new ArgumentNullException("sourceArchiveFileName");
			}
			using (ZipArchive zipArchive = ZipFile.Open(sourceArchiveFileName, ZipArchiveMode.Read, entryNameEncoding))
			{
				zipArchive.ExtractToDirectory(destinationDirectoryName, overwrite);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000223C File Offset: 0x0000043C
		private static void DoCreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel? compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding)
		{
			sourceDirectoryName = Path.GetFullPath(sourceDirectoryName);
			destinationArchiveFileName = Path.GetFullPath(destinationArchiveFileName);
			using (ZipArchive zipArchive = ZipFile.Open(destinationArchiveFileName, ZipArchiveMode.Create, entryNameEncoding))
			{
				bool flag = true;
				DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirectoryName);
				string fullName = directoryInfo.FullName;
				if (includeBaseDirectory && directoryInfo.Parent != null)
				{
					fullName = directoryInfo.Parent.FullName;
				}
				char[] array = ArrayPool<char>.Shared.Rent(260);
				try
				{
					foreach (FileSystemInfo fileSystemInfo in directoryInfo.EnumerateFileSystemInfos("*", SearchOption.AllDirectories))
					{
						flag = false;
						int length = fileSystemInfo.FullName.Length - fullName.Length;
						if (fileSystemInfo is FileInfo)
						{
							string entryName = ZipFile.EntryFromPath(fileSystemInfo.FullName, fullName.Length, length, ref array, false);
							ZipFileExtensions.DoCreateEntryFromFile(zipArchive, fileSystemInfo.FullName, entryName, compressionLevel);
						}
						else
						{
							DirectoryInfo directoryInfo2 = fileSystemInfo as DirectoryInfo;
							if (directoryInfo2 != null && ZipFile.IsDirEmpty(directoryInfo2))
							{
								string entryName2 = ZipFile.EntryFromPath(fileSystemInfo.FullName, fullName.Length, length, ref array, true);
								zipArchive.CreateEntry(entryName2);
							}
						}
					}
					if (includeBaseDirectory && flag)
					{
						zipArchive.CreateEntry(ZipFile.EntryFromPath(directoryInfo.Name, 0, directoryInfo.Name.Length, ref array, true));
					}
				}
				finally
				{
					ArrayPool<char>.Shared.Return(array, false);
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023E8 File Offset: 0x000005E8
		private static string EntryFromPath(string entry, int offset, int length, ref char[] buffer, bool appendPathSeparator = false)
		{
			while (length > 0 && (entry[offset] == Path.DirectorySeparatorChar || entry[offset] == Path.AltDirectorySeparatorChar))
			{
				offset++;
				length--;
			}
			if (length != 0)
			{
				int num = appendPathSeparator ? (length + 1) : length;
				ZipFile.EnsureCapacity(ref buffer, num);
				entry.CopyTo(offset, buffer, 0, length);
				for (int i = 0; i < length; i++)
				{
					char c = buffer[i];
					if (c == Path.DirectorySeparatorChar || c == Path.AltDirectorySeparatorChar)
					{
						buffer[i] = '/';
					}
				}
				if (appendPathSeparator)
				{
					buffer[length] = '/';
				}
				return new string(buffer, 0, num);
			}
			if (!appendPathSeparator)
			{
				return string.Empty;
			}
			return '/'.ToString();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002490 File Offset: 0x00000690
		private static void EnsureCapacity(ref char[] buffer, int min)
		{
			if (buffer.Length < min)
			{
				int num = buffer.Length * 2;
				if (num < min)
				{
					num = min;
				}
				ArrayPool<char>.Shared.Return(buffer, false);
				buffer = ArrayPool<char>.Shared.Rent(num);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024CC File Offset: 0x000006CC
		private static bool IsDirEmpty(DirectoryInfo possiblyEmptyDir)
		{
			bool result;
			using (IEnumerator<string> enumerator = Directory.EnumerateFileSystemEntries(possiblyEmptyDir.FullName).GetEnumerator())
			{
				result = !enumerator.MoveNext();
			}
			return result;
		}

		// Token: 0x0400002D RID: 45
		private const char PathSeparator = '/';
	}
}
