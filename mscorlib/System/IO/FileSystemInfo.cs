using System;
using System.IO.Enumeration;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.IO
{
	/// <summary>Предоставляет базовый класс для объектов <see cref="T:System.IO.FileInfo" /> и <see cref="T:System.IO.DirectoryInfo" />.</summary>
	// Token: 0x02000B3A RID: 2874
	[Serializable]
	public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileSystemInfo" />.</summary>
		// Token: 0x060067D5 RID: 26581 RVA: 0x0016236A File Offset: 0x0016056A
		protected FileSystemInfo()
		{
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x00162379 File Offset: 0x00160579
		internal static FileSystemInfo Create(string fullPath, ref FileSystemEntry findData)
		{
			DirectoryInfo directoryInfo = findData.IsDirectory ? new DirectoryInfo(fullPath, null, new string(findData.FileName), true) : new FileInfo(fullPath, null, new string(findData.FileName), true);
			directoryInfo.Init(findData._info);
			return directoryInfo;
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x001623B7 File Offset: 0x001605B7
		internal void Invalidate()
		{
			this._dataInitialized = -1;
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x001623C0 File Offset: 0x001605C0
		internal unsafe void Init(Interop.NtDll.FILE_FULL_DIR_INFORMATION* info)
		{
			this._data.dwFileAttributes = (int)info->FileAttributes;
			this._data.ftCreationTime = *(Interop.Kernel32.FILE_TIME*)(&info->CreationTime);
			this._data.ftLastAccessTime = *(Interop.Kernel32.FILE_TIME*)(&info->LastAccessTime);
			this._data.ftLastWriteTime = *(Interop.Kernel32.FILE_TIME*)(&info->LastWriteTime);
			this._data.nFileSizeHigh = (uint)(info->EndOfFile >> 32);
			this._data.nFileSizeLow = (uint)info->EndOfFile;
			this._dataInitialized = 0;
		}

		/// <summary>Получает или задает атрибуты для текущего файла или каталога.</summary>
		/// <returns>Атрибуты <see cref="T:System.IO.FileAttributes" /> текущего объекта <see cref="T:System.IO.FileSystemInfo" />.</returns>
		/// <exception cref="T:System.IO.FileNotFoundException">Указанный файл не существует. Возникает только при установке значения свойства.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указан недопустимый путь. Например, он ведет на несопоставленный диск. Возникает только при установке значения свойства.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">Вызывающий оператор пытается установить недействительный атрибут файла.  
		///
		/// или - 
		/// Пользователь пытается задать значение атрибута, но не имеет разрешения на запись.</exception>
		/// <exception cref="T:System.IO.IOException">
		///   <see cref="M:System.IO.FileSystemInfo.Refresh" /> не может инициализировать данные.</exception>
		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x060067D9 RID: 26585 RVA: 0x00162451 File Offset: 0x00160651
		// (set) Token: 0x060067DA RID: 26586 RVA: 0x00162464 File Offset: 0x00160664
		public FileAttributes Attributes
		{
			get
			{
				this.EnsureDataInitialized();
				return (FileAttributes)this._data.dwFileAttributes;
			}
			set
			{
				FileSystem.SetAttributes(this.FullPath, value);
				this._dataInitialized = -1;
			}
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x060067DB RID: 26587 RVA: 0x0016247C File Offset: 0x0016067C
		internal bool ExistsCore
		{
			get
			{
				if (this._dataInitialized == -1)
				{
					this.Refresh();
				}
				return this._dataInitialized == 0 && this._data.dwFileAttributes != -1 && this is DirectoryInfo == ((this._data.dwFileAttributes & 16) == 16);
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x060067DC RID: 26588 RVA: 0x001624CF File Offset: 0x001606CF
		// (set) Token: 0x060067DD RID: 26589 RVA: 0x001624E7 File Offset: 0x001606E7
		internal DateTimeOffset CreationTimeCore
		{
			get
			{
				this.EnsureDataInitialized();
				return this._data.ftCreationTime.ToDateTimeOffset();
			}
			set
			{
				FileSystem.SetCreationTime(this.FullPath, value, this is DirectoryInfo);
				this._dataInitialized = -1;
			}
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x060067DE RID: 26590 RVA: 0x00162505 File Offset: 0x00160705
		// (set) Token: 0x060067DF RID: 26591 RVA: 0x0016251D File Offset: 0x0016071D
		internal DateTimeOffset LastAccessTimeCore
		{
			get
			{
				this.EnsureDataInitialized();
				return this._data.ftLastAccessTime.ToDateTimeOffset();
			}
			set
			{
				FileSystem.SetLastAccessTime(this.FullPath, value, this is DirectoryInfo);
				this._dataInitialized = -1;
			}
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x060067E0 RID: 26592 RVA: 0x0016253B File Offset: 0x0016073B
		// (set) Token: 0x060067E1 RID: 26593 RVA: 0x00162553 File Offset: 0x00160753
		internal DateTimeOffset LastWriteTimeCore
		{
			get
			{
				this.EnsureDataInitialized();
				return this._data.ftLastWriteTime.ToDateTimeOffset();
			}
			set
			{
				FileSystem.SetLastWriteTime(this.FullPath, value, this is DirectoryInfo);
				this._dataInitialized = -1;
			}
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x060067E2 RID: 26594 RVA: 0x00162571 File Offset: 0x00160771
		internal long LengthCore
		{
			get
			{
				this.EnsureDataInitialized();
				return (long)((ulong)this._data.nFileSizeHigh << 32 | ((ulong)this._data.nFileSizeLow & (ulong)-1));
			}
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x00162598 File Offset: 0x00160798
		private void EnsureDataInitialized()
		{
			if (this._dataInitialized == -1)
			{
				this._data = default(Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA);
				this.Refresh();
			}
			if (this._dataInitialized != 0)
			{
				throw Win32Marshal.GetExceptionForWin32Error(this._dataInitialized, this.FullPath);
			}
		}

		/// <summary>Обновляет состояние объекта.</summary>
		/// <exception cref="T:System.IO.IOException">Устройство, например дисковод, не готово.</exception>
		// Token: 0x060067E4 RID: 26596 RVA: 0x001625CF File Offset: 0x001607CF
		public void Refresh()
		{
			this._dataInitialized = FileSystem.FillAttributeInfo(this.FullPath, ref this._data, false);
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x060067E5 RID: 26597 RVA: 0x001625E9 File Offset: 0x001607E9
		internal string NormalizedPath
		{
			get
			{
				if (!PathInternal.EndsWithPeriodOrSpace(this.FullPath))
				{
					return this.FullPath;
				}
				return PathInternal.EnsureExtendedPrefix(this.FullPath);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileSystemInfo" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Указанный <see cref="T:System.Runtime.Serialization.SerializationInfo" /> имеет значение null.</exception>
		// Token: 0x060067E6 RID: 26598 RVA: 0x0016260C File Offset: 0x0016080C
		protected FileSystemInfo(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.FullPath = Path.GetFullPathInternal(info.GetString("FullPath"));
			this.OriginalPath = info.GetString("OriginalPath");
			this._name = info.GetString("Name");
		}

		/// <summary>Устанавливает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с именем файла и дополнительными сведениями об исключении.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x060067E7 RID: 26599 RVA: 0x0016266C File Offset: 0x0016086C
		[ComVisible(false)]
		[SecurityCritical]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("OriginalPath", this.OriginalPath, typeof(string));
			info.AddValue("FullPath", this.FullPath, typeof(string));
			info.AddValue("Name", this.Name, typeof(string));
		}

		/// <summary>Получает полный путь к каталогу или файлу.</summary>
		/// <returns>Строка, содержащая полный путь.</returns>
		/// <exception cref="T:System.IO.PathTooLongException">Длина имени полного пути и файла превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x060067E8 RID: 26600 RVA: 0x001626CA File Offset: 0x001608CA
		public virtual string FullName
		{
			get
			{
				return this.FullPath;
			}
		}

		/// <summary>Получает строку, содержащую расширение файла.</summary>
		/// <returns>Строка, содержащая расширение <see cref="T:System.IO.FileSystemInfo" />.</returns>
		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x060067E9 RID: 26601 RVA: 0x001626D4 File Offset: 0x001608D4
		public string Extension
		{
			get
			{
				int length = this.FullPath.Length;
				int num = length;
				while (--num >= 0)
				{
					char c = this.FullPath[num];
					if (c == '.')
					{
						return this.FullPath.Substring(num, length - num);
					}
					if (PathInternal.IsDirectorySeparator(c) || c == Path.VolumeSeparatorChar)
					{
						break;
					}
				}
				return string.Empty;
			}
		}

		/// <summary>Для файлов — получает имя файла. Для каталогов — получает имя последнего каталога в иерархии, если таковая существует. В противном случае свойство <see langword="Name" /> получает имя данного каталога.</summary>
		/// <returns>Строка, представляющая собой имя родительского каталога, имя последнего каталога в иерархии или имя файла, включая расширение имени файла.</returns>
		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x060067EA RID: 26602 RVA: 0x00162362 File Offset: 0x00160562
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		/// <summary>Получает значение, показывающее, существует ли данный файл или каталог.</summary>
		/// <returns>Значение <see langword="true" />, если файл или каталог существует; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x060067EB RID: 26603 RVA: 0x00162730 File Offset: 0x00160930
		public virtual bool Exists
		{
			get
			{
				bool result;
				try
				{
					result = this.ExistsCore;
				}
				catch
				{
					result = false;
				}
				return result;
			}
		}

		/// <summary>Удаляет файл или каталог.</summary>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный путь недопустим (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.IO.IOException">Для файла или каталога имеется открытый дескриптор, используется операционная система Windows XP или более ранняя версия. Этот открытый дескриптор может быть результатом перечисления каталогов и файлов. Дополнительные сведения см. в разделе Практическое руководство. Перечисление каталогов и файлов.</exception>
		// Token: 0x060067EC RID: 26604
		public abstract void Delete();

		/// <summary>Получает или задает время создания текущего файла или каталога.</summary>
		/// <returns>Дата и время создания текущего объекта <see cref="T:System.IO.FileSystemInfo" />.</returns>
		/// <exception cref="T:System.IO.IOException">
		///   <see cref="M:System.IO.FileSystemInfo.Refresh" /> не может инициализировать данные.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный путь недопустим (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версией.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Вызывающий объект пытается задать недействительное время создания.</exception>
		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x060067ED RID: 26605 RVA: 0x0016275C File Offset: 0x0016095C
		// (set) Token: 0x060067EE RID: 26606 RVA: 0x00162777 File Offset: 0x00160977
		public DateTime CreationTime
		{
			get
			{
				return this.CreationTimeUtc.ToLocalTime();
			}
			set
			{
				this.CreationTimeUtc = value.ToUniversalTime();
			}
		}

		/// <summary>Получает или задает время создания текущего файла или каталога в формате UTC.</summary>
		/// <returns>Дата и время создания текущего объекта <see cref="T:System.IO.FileSystemInfo" /> в формате UTC.</returns>
		/// <exception cref="T:System.IO.IOException">
		///   <see cref="M:System.IO.FileSystemInfo.Refresh" /> не может инициализировать данные.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный путь недопустим (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версией.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Вызывающий объект пытается задать недействительное время доступа.</exception>
		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x060067EF RID: 26607 RVA: 0x00162788 File Offset: 0x00160988
		// (set) Token: 0x060067F0 RID: 26608 RVA: 0x001627A3 File Offset: 0x001609A3
		public DateTime CreationTimeUtc
		{
			get
			{
				return this.CreationTimeCore.UtcDateTime;
			}
			set
			{
				this.CreationTimeCore = File.GetUtcDateTimeOffset(value);
			}
		}

		/// <summary>Получает или задает время последнего доступа к текущему файлу или каталогу.</summary>
		/// <returns>Время последнего доступа к текущему файлу или каталогу.</returns>
		/// <exception cref="T:System.IO.IOException">
		///   <see cref="M:System.IO.FileSystemInfo.Refresh" /> не может инициализировать данные.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версией.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Вызывающий объект пытается задать недействительное время доступа</exception>
		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060067F1 RID: 26609 RVA: 0x001627B4 File Offset: 0x001609B4
		// (set) Token: 0x060067F2 RID: 26610 RVA: 0x001627CF File Offset: 0x001609CF
		public DateTime LastAccessTime
		{
			get
			{
				return this.LastAccessTimeUtc.ToLocalTime();
			}
			set
			{
				this.LastAccessTimeUtc = value.ToUniversalTime();
			}
		}

		/// <summary>Получает или задает дату и время последнего доступа к заданному файлу или каталогу в формате UTC.</summary>
		/// <returns>Время последнего доступа к текущему файлу или каталогу в формате UTC.</returns>
		/// <exception cref="T:System.IO.IOException">
		///   <see cref="M:System.IO.FileSystemInfo.Refresh" /> не может инициализировать данные.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версией.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Вызывающий объект пытается задать недействительное время доступа.</exception>
		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060067F3 RID: 26611 RVA: 0x001627E0 File Offset: 0x001609E0
		// (set) Token: 0x060067F4 RID: 26612 RVA: 0x001627FB File Offset: 0x001609FB
		public DateTime LastAccessTimeUtc
		{
			get
			{
				return this.LastAccessTimeCore.UtcDateTime;
			}
			set
			{
				this.LastAccessTimeCore = File.GetUtcDateTimeOffset(value);
			}
		}

		/// <summary>Получает или задает время последней операции записи в текущий файл или каталог.</summary>
		/// <returns>Время последней операции записи в текущий файл.</returns>
		/// <exception cref="T:System.IO.IOException">
		///   <see cref="M:System.IO.FileSystemInfo.Refresh" /> не может инициализировать данные.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версией.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Вызывающий объект пытается задать недействительное время записи.</exception>
		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x060067F5 RID: 26613 RVA: 0x0016280C File Offset: 0x00160A0C
		// (set) Token: 0x060067F6 RID: 26614 RVA: 0x00162827 File Offset: 0x00160A27
		public DateTime LastWriteTime
		{
			get
			{
				return this.LastWriteTimeUtc.ToLocalTime();
			}
			set
			{
				this.LastWriteTimeUtc = value.ToUniversalTime();
			}
		}

		/// <summary>Получает или задает время последней операции записи в текущий файл или каталог в формате UTC.</summary>
		/// <returns>Время последней операции записи в текущий файл в формате UTC.</returns>
		/// <exception cref="T:System.IO.IOException">
		///   <see cref="M:System.IO.FileSystemInfo.Refresh" /> не может инициализировать данные.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Текущая операционная система не является системой Windows NT или более поздней версией.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Вызывающий объект пытается задать недействительное время записи.</exception>
		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x060067F7 RID: 26615 RVA: 0x00162838 File Offset: 0x00160A38
		// (set) Token: 0x060067F8 RID: 26616 RVA: 0x00162853 File Offset: 0x00160A53
		public DateTime LastWriteTimeUtc
		{
			get
			{
				return this.LastWriteTimeCore.UtcDateTime;
			}
			set
			{
				this.LastWriteTimeCore = File.GetUtcDateTimeOffset(value);
			}
		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x00162861 File Offset: 0x00160A61
		public override string ToString()
		{
			return this.OriginalPath ?? string.Empty;
		}

		// Token: 0x04003C6E RID: 15470
		private Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA _data;

		// Token: 0x04003C6F RID: 15471
		private int _dataInitialized = -1;

		/// <summary>Представляет полный путь к каталогу или файлу.</summary>
		/// <exception cref="T:System.IO.PathTooLongException">Длина полного пути превышает максимальную длину, определенную в системе.</exception>
		// Token: 0x04003C70 RID: 15472
		protected string FullPath;

		/// <summary>Первоначально заданный пользователем относительный или абсолютный путь.</summary>
		// Token: 0x04003C71 RID: 15473
		protected string OriginalPath;

		// Token: 0x04003C72 RID: 15474
		internal string _name;
	}
}
