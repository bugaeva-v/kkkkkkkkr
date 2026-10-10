using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace System.IO.Compression
{
	/// <summary>
	///         Представляет пакет сжатых файлов в формате ZIP архива.
	///       </summary>
	// Token: 0x02000029 RID: 41
	public class ZipArchive : IDisposable
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.IO.Compression.ZipArchive" /> из указанного потока.
		///       </summary>
		/// <param name="stream">
		///           Поток, содержащий архив для чтения.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Поток уже закрыт или не поддерживает чтение.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="stream" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.IO.InvalidDataException">
		///             Формат содержимого потока отличен от ZIP-архива.
		///           </exception>
		// Token: 0x0600011A RID: 282 RVA: 0x000064DF File Offset: 0x000046DF
		public ZipArchive(Stream stream) : this(stream, ZipArchiveMode.Read, false, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.IO.Compression.ZipArchive" /> из указанного потока с указанным режимом.
		///       </summary>
		/// <param name="stream">
		///           Входной или выходной поток.
		///         </param>
		/// <param name="mode">
		///           Одно из значений перечисления, указывающее, для чтения, создания или обновления записей используется ZIP-архив.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Поток уже закрыт или возможности потока не соответствует режиму.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="stream" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="mode" /> не является допустимым значением.
		///           </exception>
		/// <exception cref="T:System.IO.InvalidDataException">
		///             Содержимое потока не удалось интерпретировать как ZIP-архив.
		///
		///             -или-
		///
		///             <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Update" /> и запись отсутствует в архиве или повреждена и не может быть прочитана.
		///
		///             -или-
		///
		///             <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Update" /> и запись слишком велика, чтобы поместиться в памяти.
		///           </exception>
		// Token: 0x0600011B RID: 283 RVA: 0x000064EB File Offset: 0x000046EB
		public ZipArchive(Stream stream, ZipArchiveMode mode) : this(stream, mode, false, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.IO.Compression.ZipArchive" /> в указанном потоке для указанного режима, а также при необходимости оставляет поток открытым.
		///       </summary>
		/// <param name="stream">
		///           Входной или выходной поток.
		///         </param>
		/// <param name="mode">
		///           Одно из значений перечисления, указывающее, для чтения, создания или обновления записей используется ZIP-архив.
		///         </param>
		/// <param name="leaveOpen">
		///           Значение <see langword="true" />, чтобы оставить поток открытым после удаления объекта <see cref="T:System.IO.Compression.ZipArchive" />; в противном случае — значение <see langword="false" />.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Поток уже закрыт или возможности потока не соответствует режиму.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="stream" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="mode" /> не является допустимым значением.
		///           </exception>
		/// <exception cref="T:System.IO.InvalidDataException">
		///             Содержимое потока не удалось интерпретировать как ZIP-архив.
		///
		///             -или-
		///
		///             <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Update" /> и запись отсутствует в архиве или повреждена и не может быть прочитана.
		///
		///             -или-
		///
		///             <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Update" /> и запись слишком велика, чтобы поместиться в памяти.
		///           </exception>
		// Token: 0x0600011C RID: 284 RVA: 0x000064F7 File Offset: 0x000046F7
		public ZipArchive(Stream stream, ZipArchiveMode mode, bool leaveOpen) : this(stream, mode, leaveOpen, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.IO.Compression.ZipArchive" /> в указанном потоке для заданного режима, использует указанную кодировку для кодировку для имен записей, а также, при необходимости, оставляет поток открытым.
		///       </summary>
		/// <param name="stream">
		///           Входной или выходной поток.
		///         </param>
		/// <param name="mode">
		///           Одно из значений перечисления, указывающее, для чтения, создания или обновления записей используется ZIP-архив.
		///         </param>
		/// <param name="leaveOpen">
		///           Значение <see langword="true" />, чтобы оставить поток открытым после удаления объекта <see cref="T:System.IO.Compression.ZipArchive" />; в противном случае — значение <see langword="false" />.
		///         </param>
		/// <param name="entryNameEncoding">
		///           Кодирование, используемое при чтении или записи имен записей в этом архиве.
		///            Задайте значение для этого параметра, только если кодирование требуется для взаимодействия с инструментами и библиотеками ZIP-архива, которые не поддерживают кодирование UTF-8 для имен записей.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Поток уже закрыт или возможности потока не соответствует режиму.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="stream" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="mode" /> не является допустимым значением.
		///           </exception>
		/// <exception cref="T:System.IO.InvalidDataException">
		///             Содержимое потока не удалось интерпретировать как ZIP-архив.
		///
		///             -или-
		///
		///             <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Update" /> и запись отсутствует в архиве или повреждена и не может быть прочитана.
		///
		///             -или-
		///
		///             <paramref name="mode" /> имеет значение <see cref="F:System.IO.Compression.ZipArchiveMode.Update" /> и запись слишком велика, чтобы поместиться в памяти.
		///           </exception>
		// Token: 0x0600011D RID: 285 RVA: 0x00006503 File Offset: 0x00004703
		public ZipArchive(Stream stream, ZipArchiveMode mode, bool leaveOpen, Encoding entryNameEncoding)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			this.EntryNameEncoding = entryNameEncoding;
			this.Init(stream, mode, leaveOpen);
		}

		/// <summary>
		///         Получает коллекцию записей, которые находятся в ZIP-архиве в текущий момент.
		///       </summary>
		/// <returns>
		///         Коллекция записей, которые находятся в ZIP-архиве в текущий момент.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             ZIP-архив не поддерживает чтение.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             ZIP-архив был удален.
		///           </exception>
		/// <exception cref="T:System.IO.InvalidDataException">
		///             ZIP-архив поврежден, и его операции не удается получить.
		///           </exception>
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000652A File Offset: 0x0000472A
		public ReadOnlyCollection<ZipArchiveEntry> Entries
		{
			get
			{
				if (this._mode == ZipArchiveMode.Create)
				{
					throw new NotSupportedException("Cannot access entries in Create mode.");
				}
				this.ThrowIfDisposed();
				this.EnsureCentralDirectoryRead();
				return this._entriesCollection;
			}
		}

		/// <summary>
		///         Получает значение, которое описывает тип действий, которые ZIP-архив может выполнять над записями.
		///       </summary>
		/// <returns>
		///         Одно из значений перечисления, описывающее тип действия (чтение, создание или обновление), которое ZIP-архив может выполнять над записями.
		///       </returns>
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00006552 File Offset: 0x00004752
		public ZipArchiveMode Mode
		{
			get
			{
				return this._mode;
			}
		}

		/// <summary>
		///         Создает пустую запись, которая имеет указанные путь и имя записи в ZIP архиве.
		///       </summary>
		/// <param name="entryName">
		///           Путь относительно корня архива, который указывает имя создаваемой записи.
		///         </param>
		/// <returns>
		///         Пустая запись в ZIP-архиве.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Свойство <paramref name="entryName" /> имеет значение <see cref="F:System.String.Empty" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="entryName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             ZIP-архив не поддерживает запись.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             ZIP-архив был удален.
		///           </exception>
		// Token: 0x06000120 RID: 288 RVA: 0x0000655C File Offset: 0x0000475C
		public ZipArchiveEntry CreateEntry(string entryName)
		{
			return this.DoCreateEntry(entryName, null);
		}

		/// <summary>
		///         Создает пустую запись, которая имеет указанные имя и уровень сжатия ZIP записи в архиве.
		///       </summary>
		/// <param name="entryName">
		///           Путь относительно корня архива, который указывает имя создаваемой записи.
		///         </param>
		/// <param name="compressionLevel">
		///           Одно из значений перечисления, указывающее, акцентировать ли внимание на скорости или эффективности сжатия при создании записи.
		///         </param>
		/// <returns>
		///         Пустая запись в ZIP-архиве.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Свойство <paramref name="entryName" /> имеет значение <see cref="F:System.String.Empty" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="entryName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             ZIP-архив не поддерживает запись.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             ZIP-архив был удален.
		///           </exception>
		// Token: 0x06000121 RID: 289 RVA: 0x00006579 File Offset: 0x00004779
		public ZipArchiveEntry CreateEntry(string entryName, CompressionLevel compressionLevel)
		{
			return this.DoCreateEntry(entryName, new CompressionLevel?(compressionLevel));
		}

		/// <summary>
		///         Вызывается методом <see cref="M:System.IO.Compression.ZipArchive.Dispose" /> и <see cref="M:System.Object.Finalize" /> методов, чтобы освободить неуправляемые ресурсы, используемые текущим экземпляром <see cref="T:System.IO.Compression.ZipArchive" /> класса и при необходимости завершения записи архива и освобождает управляемые ресурсы.
		///       </summary>
		/// <param name="disposing">
		///           <see langword="true" /> для завершения записи архива и освобождения управляемых и неуправляемых ресурсов; <see langword="false" /> для освобождения только неуправляемых ресурсов.
		///         </param>
		// Token: 0x06000122 RID: 290 RVA: 0x00006588 File Offset: 0x00004788
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !this._isDisposed)
			{
				try
				{
					ZipArchiveMode mode = this._mode;
					if (mode != ZipArchiveMode.Read)
					{
						int num = mode - ZipArchiveMode.Create;
						this.WriteFile();
					}
				}
				finally
				{
					this.CloseStreams();
					this._isDisposed = true;
				}
			}
		}

		/// <summary>
		///         Освобождает ресурсы, используемые текущим экземпляром класса <see cref="T:System.IO.Compression.ZipArchive" />.
		///       </summary>
		// Token: 0x06000123 RID: 291 RVA: 0x000065D8 File Offset: 0x000047D8
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		///         Извлекает оболочку для заданной записи в ZIP-архиве.
		///       </summary>
		/// <param name="entryName">
		///           Путь относительно корня архива, который указывает запись для получения.
		///         </param>
		/// <returns>
		///         Программа-оболочка для указанной записи в архиве; <see langword="null" /> Если запись не существует в архиве.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Свойство <paramref name="entryName" /> имеет значение <see cref="F:System.String.Empty" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="entryName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             ZIP-архив не поддерживает чтение.
		///           </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///             ZIP-архив был удален.
		///           </exception>
		/// <exception cref="T:System.IO.InvalidDataException">
		///             ZIP-архив поврежден, и его операции не удается получить.
		///           </exception>
		// Token: 0x06000124 RID: 292 RVA: 0x000065E8 File Offset: 0x000047E8
		public ZipArchiveEntry GetEntry(string entryName)
		{
			if (entryName == null)
			{
				throw new ArgumentNullException("entryName");
			}
			if (this._mode == ZipArchiveMode.Create)
			{
				throw new NotSupportedException("Cannot access entries in Create mode.");
			}
			this.EnsureCentralDirectoryRead();
			ZipArchiveEntry result;
			this._entriesDictionary.TryGetValue(entryName, out result);
			return result;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000662D File Offset: 0x0000482D
		internal BinaryReader ArchiveReader
		{
			get
			{
				return this._archiveReader;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00006635 File Offset: 0x00004835
		internal Stream ArchiveStream
		{
			get
			{
				return this._archiveStream;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000663D File Offset: 0x0000483D
		internal uint NumberOfThisDisk
		{
			get
			{
				return this._numberOfThisDisk;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00006645 File Offset: 0x00004845
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0000664D File Offset: 0x0000484D
		internal Encoding EntryNameEncoding
		{
			get
			{
				return this._entryNameEncoding;
			}
			private set
			{
				if (value != null && (value.Equals(Encoding.BigEndianUnicode) || value.Equals(Encoding.Unicode)))
				{
					throw new ArgumentException("The specified entry name encoding is not supported.", "EntryNameEncoding");
				}
				this._entryNameEncoding = value;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006684 File Offset: 0x00004884
		private ZipArchiveEntry DoCreateEntry(string entryName, CompressionLevel? compressionLevel)
		{
			if (entryName == null)
			{
				throw new ArgumentNullException("entryName");
			}
			if (string.IsNullOrEmpty(entryName))
			{
				throw new ArgumentException("String cannot be empty.", "entryName");
			}
			if (this._mode == ZipArchiveMode.Read)
			{
				throw new NotSupportedException("Cannot create entries on an archive opened in read mode.");
			}
			this.ThrowIfDisposed();
			ZipArchiveEntry zipArchiveEntry = (compressionLevel != null) ? new ZipArchiveEntry(this, entryName, compressionLevel.Value) : new ZipArchiveEntry(this, entryName);
			this.AddEntry(zipArchiveEntry);
			return zipArchiveEntry;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000066F9 File Offset: 0x000048F9
		internal void AcquireArchiveStream(ZipArchiveEntry entry)
		{
			if (this._archiveStreamOwner != null)
			{
				if (this._archiveStreamOwner.EverOpenedForWrite)
				{
					throw new IOException("Entries cannot be created while previously created entries are still open.");
				}
				this._archiveStreamOwner.WriteAndFinishLocalEntry();
			}
			this._archiveStreamOwner = entry;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00006730 File Offset: 0x00004930
		private void AddEntry(ZipArchiveEntry entry)
		{
			this._entries.Add(entry);
			string fullName = entry.FullName;
			if (!this._entriesDictionary.ContainsKey(fullName))
			{
				this._entriesDictionary.Add(fullName, entry);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000042E9 File Offset: 0x000024E9
		[Conditional("DEBUG")]
		internal void DebugAssertIsStillArchiveStreamOwner(ZipArchiveEntry entry)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000676B File Offset: 0x0000496B
		internal void ReleaseArchiveStream(ZipArchiveEntry entry)
		{
			this._archiveStreamOwner = null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006774 File Offset: 0x00004974
		internal void RemoveEntry(ZipArchiveEntry entry)
		{
			this._entries.Remove(entry);
			this._entriesDictionary.Remove(entry.FullName);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00006795 File Offset: 0x00004995
		internal void ThrowIfDisposed()
		{
			if (this._isDisposed)
			{
				throw new ObjectDisposedException(base.GetType().ToString());
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000067B0 File Offset: 0x000049B0
		private void CloseStreams()
		{
			if (this._leaveOpen)
			{
				if (this._backingStream != null)
				{
					this._archiveStream.Dispose();
				}
				return;
			}
			this._archiveStream.Dispose();
			Stream backingStream = this._backingStream;
			if (backingStream != null)
			{
				backingStream.Dispose();
			}
			BinaryReader archiveReader = this._archiveReader;
			if (archiveReader == null)
			{
				return;
			}
			archiveReader.Dispose();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00006805 File Offset: 0x00004A05
		private void EnsureCentralDirectoryRead()
		{
			if (!this._readEntries)
			{
				this.ReadCentralDirectory();
				this._readEntries = true;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000681C File Offset: 0x00004A1C
		private void Init(Stream stream, ZipArchiveMode mode, bool leaveOpen)
		{
			Stream stream2 = null;
			try
			{
				this._backingStream = null;
				switch (mode)
				{
				case ZipArchiveMode.Read:
					if (!stream.CanRead)
					{
						throw new ArgumentException("Cannot use read mode on a non-readable stream.");
					}
					if (!stream.CanSeek)
					{
						this._backingStream = stream;
						stream = (stream2 = new MemoryStream());
						this._backingStream.CopyTo(stream);
						stream.Seek(0L, SeekOrigin.Begin);
					}
					break;
				case ZipArchiveMode.Create:
					if (!stream.CanWrite)
					{
						throw new ArgumentException("Cannot use create mode on a non-writable stream.");
					}
					break;
				case ZipArchiveMode.Update:
					if (!stream.CanRead || !stream.CanWrite || !stream.CanSeek)
					{
						throw new ArgumentException("Update mode requires a stream with read, write, and seek capabilities.");
					}
					break;
				default:
					throw new ArgumentOutOfRangeException("mode");
				}
				this._mode = mode;
				if (mode == ZipArchiveMode.Create && !stream.CanSeek)
				{
					this._archiveStream = new PositionPreservingWriteOnlyStreamWrapper(stream);
				}
				else
				{
					this._archiveStream = stream;
				}
				this._archiveStreamOwner = null;
				if (mode == ZipArchiveMode.Create)
				{
					this._archiveReader = null;
				}
				else
				{
					this._archiveReader = new BinaryReader(this._archiveStream);
				}
				this._entries = new List<ZipArchiveEntry>();
				this._entriesCollection = new ReadOnlyCollection<ZipArchiveEntry>(this._entries);
				this._entriesDictionary = new Dictionary<string, ZipArchiveEntry>();
				this._readEntries = false;
				this._leaveOpen = leaveOpen;
				this._centralDirectoryStart = 0L;
				this._isDisposed = false;
				this._numberOfThisDisk = 0U;
				this._archiveComment = null;
				switch (mode)
				{
				case ZipArchiveMode.Read:
					this.ReadEndOfCentralDirectory();
					goto IL_1BC;
				case ZipArchiveMode.Create:
					this._readEntries = true;
					goto IL_1BC;
				}
				if (this._archiveStream.Length == 0L)
				{
					this._readEntries = true;
				}
				else
				{
					this.ReadEndOfCentralDirectory();
					this.EnsureCentralDirectoryRead();
					foreach (ZipArchiveEntry zipArchiveEntry in this._entries)
					{
						zipArchiveEntry.ThrowIfNotOpenable(false, true);
					}
				}
				IL_1BC:;
			}
			catch
			{
				if (stream2 != null)
				{
					stream2.Dispose();
				}
				throw;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006A28 File Offset: 0x00004C28
		private void ReadCentralDirectory()
		{
			try
			{
				this._archiveStream.Seek(this._centralDirectoryStart, SeekOrigin.Begin);
				long num = 0L;
				bool saveExtraFieldsAndComments = this.Mode == ZipArchiveMode.Update;
				ZipCentralDirectoryFileHeader cd;
				while (ZipCentralDirectoryFileHeader.TryReadBlock(this._archiveReader, saveExtraFieldsAndComments, out cd))
				{
					this.AddEntry(new ZipArchiveEntry(this, cd));
					num += 1L;
				}
				if (num != this._expectedNumberOfEntries)
				{
					throw new InvalidDataException("Number of entries expected in End Of Central Directory does not correspond to number of entries in Central Directory.");
				}
			}
			catch (EndOfStreamException p)
			{
				throw new InvalidDataException(SR.Format("Central Directory is invalid.", p));
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006AB4 File Offset: 0x00004CB4
		private void ReadEndOfCentralDirectory()
		{
			try
			{
				this._archiveStream.Seek(-18L, SeekOrigin.End);
				if (!ZipHelper.SeekBackwardsToSignature(this._archiveStream, 101010256U))
				{
					throw new InvalidDataException("End of Central Directory record could not be found.");
				}
				long position = this._archiveStream.Position;
				ZipEndOfCentralDirectoryBlock zipEndOfCentralDirectoryBlock;
				ZipEndOfCentralDirectoryBlock.TryReadBlock(this._archiveReader, out zipEndOfCentralDirectoryBlock);
				if (zipEndOfCentralDirectoryBlock.NumberOfThisDisk != zipEndOfCentralDirectoryBlock.NumberOfTheDiskWithTheStartOfTheCentralDirectory)
				{
					throw new InvalidDataException("Split or spanned archives are not supported.");
				}
				this._numberOfThisDisk = (uint)zipEndOfCentralDirectoryBlock.NumberOfThisDisk;
				this._centralDirectoryStart = (long)((ulong)zipEndOfCentralDirectoryBlock.OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber);
				if (zipEndOfCentralDirectoryBlock.NumberOfEntriesInTheCentralDirectory != zipEndOfCentralDirectoryBlock.NumberOfEntriesInTheCentralDirectoryOnThisDisk)
				{
					throw new InvalidDataException("Split or spanned archives are not supported.");
				}
				this._expectedNumberOfEntries = (long)((ulong)zipEndOfCentralDirectoryBlock.NumberOfEntriesInTheCentralDirectory);
				if (this._mode == ZipArchiveMode.Update)
				{
					this._archiveComment = zipEndOfCentralDirectoryBlock.ArchiveComment;
				}
				if (zipEndOfCentralDirectoryBlock.NumberOfThisDisk == 65535 || zipEndOfCentralDirectoryBlock.OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber == 4294967295U || zipEndOfCentralDirectoryBlock.NumberOfEntriesInTheCentralDirectory == 65535)
				{
					this._archiveStream.Seek(position - 16L, SeekOrigin.Begin);
					if (ZipHelper.SeekBackwardsToSignature(this._archiveStream, 117853008U))
					{
						Zip64EndOfCentralDirectoryLocator zip64EndOfCentralDirectoryLocator;
						Zip64EndOfCentralDirectoryLocator.TryReadBlock(this._archiveReader, out zip64EndOfCentralDirectoryLocator);
						if (zip64EndOfCentralDirectoryLocator.OffsetOfZip64EOCD > 9223372036854775807UL)
						{
							throw new InvalidDataException("Offset to Zip64 End Of Central Directory record cannot be held in an Int64.");
						}
						long offsetOfZip64EOCD = (long)zip64EndOfCentralDirectoryLocator.OffsetOfZip64EOCD;
						this._archiveStream.Seek(offsetOfZip64EOCD, SeekOrigin.Begin);
						Zip64EndOfCentralDirectoryRecord zip64EndOfCentralDirectoryRecord;
						if (!Zip64EndOfCentralDirectoryRecord.TryReadBlock(this._archiveReader, out zip64EndOfCentralDirectoryRecord))
						{
							throw new InvalidDataException("Zip 64 End of Central Directory Record not where indicated.");
						}
						this._numberOfThisDisk = zip64EndOfCentralDirectoryRecord.NumberOfThisDisk;
						if (zip64EndOfCentralDirectoryRecord.NumberOfEntriesTotal > 9223372036854775807UL)
						{
							throw new InvalidDataException("Number of Entries cannot be held in an Int64.");
						}
						if (zip64EndOfCentralDirectoryRecord.OffsetOfCentralDirectory > 9223372036854775807UL)
						{
							throw new InvalidDataException("Offset to Central Directory cannot be held in an Int64.");
						}
						if (zip64EndOfCentralDirectoryRecord.NumberOfEntriesTotal != zip64EndOfCentralDirectoryRecord.NumberOfEntriesOnThisDisk)
						{
							throw new InvalidDataException("Split or spanned archives are not supported.");
						}
						this._expectedNumberOfEntries = (long)zip64EndOfCentralDirectoryRecord.NumberOfEntriesTotal;
						this._centralDirectoryStart = (long)zip64EndOfCentralDirectoryRecord.OffsetOfCentralDirectory;
					}
				}
				if (this._centralDirectoryStart > this._archiveStream.Length)
				{
					throw new InvalidDataException("Offset to Central Directory cannot be held in an Int64.");
				}
			}
			catch (EndOfStreamException innerException)
			{
				throw new InvalidDataException("Central Directory corrupt.", innerException);
			}
			catch (IOException innerException2)
			{
				throw new InvalidDataException("Central Directory corrupt.", innerException2);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006D0C File Offset: 0x00004F0C
		private void WriteFile()
		{
			if (this._mode == ZipArchiveMode.Update)
			{
				List<ZipArchiveEntry> list = new List<ZipArchiveEntry>();
				foreach (ZipArchiveEntry zipArchiveEntry in this._entries)
				{
					if (!zipArchiveEntry.LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded())
					{
						list.Add(zipArchiveEntry);
					}
				}
				foreach (ZipArchiveEntry zipArchiveEntry2 in list)
				{
					zipArchiveEntry2.Delete();
				}
				this._archiveStream.Seek(0L, SeekOrigin.Begin);
				this._archiveStream.SetLength(0L);
			}
			foreach (ZipArchiveEntry zipArchiveEntry3 in this._entries)
			{
				zipArchiveEntry3.WriteAndFinishLocalEntry();
			}
			long position = this._archiveStream.Position;
			foreach (ZipArchiveEntry zipArchiveEntry4 in this._entries)
			{
				zipArchiveEntry4.WriteCentralDirectoryFileHeader();
			}
			long sizeOfCentralDirectory = this._archiveStream.Position - position;
			this.WriteArchiveEpilogue(position, sizeOfCentralDirectory);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006E74 File Offset: 0x00005074
		private void WriteArchiveEpilogue(long startOfCentralDirectory, long sizeOfCentralDirectory)
		{
			if (startOfCentralDirectory >= (long)((ulong)-1) || sizeOfCentralDirectory >= (long)((ulong)-1) || this._entries.Count >= 65535)
			{
				long position = this._archiveStream.Position;
				Zip64EndOfCentralDirectoryRecord.WriteBlock(this._archiveStream, (long)this._entries.Count, startOfCentralDirectory, sizeOfCentralDirectory);
				Zip64EndOfCentralDirectoryLocator.WriteBlock(this._archiveStream, position);
			}
			ZipEndOfCentralDirectoryBlock.WriteBlock(this._archiveStream, (long)this._entries.Count, startOfCentralDirectory, sizeOfCentralDirectory, this._archiveComment);
		}

		// Token: 0x0400016B RID: 363
		private Stream _archiveStream;

		// Token: 0x0400016C RID: 364
		private ZipArchiveEntry _archiveStreamOwner;

		// Token: 0x0400016D RID: 365
		private BinaryReader _archiveReader;

		// Token: 0x0400016E RID: 366
		private ZipArchiveMode _mode;

		// Token: 0x0400016F RID: 367
		private List<ZipArchiveEntry> _entries;

		// Token: 0x04000170 RID: 368
		private ReadOnlyCollection<ZipArchiveEntry> _entriesCollection;

		// Token: 0x04000171 RID: 369
		private Dictionary<string, ZipArchiveEntry> _entriesDictionary;

		// Token: 0x04000172 RID: 370
		private bool _readEntries;

		// Token: 0x04000173 RID: 371
		private bool _leaveOpen;

		// Token: 0x04000174 RID: 372
		private long _centralDirectoryStart;

		// Token: 0x04000175 RID: 373
		private bool _isDisposed;

		// Token: 0x04000176 RID: 374
		private uint _numberOfThisDisk;

		// Token: 0x04000177 RID: 375
		private long _expectedNumberOfEntries;

		// Token: 0x04000178 RID: 376
		private Stream _backingStream;

		// Token: 0x04000179 RID: 377
		private byte[] _archiveComment;

		// Token: 0x0400017A RID: 378
		private Encoding _entryNameEncoding;
	}
}
