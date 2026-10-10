using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Предоставляет доступ к сведениям на диске.</summary>
	// Token: 0x02000B5C RID: 2908
	[ComVisible(true)]
	[Serializable]
	public sealed class DriveInfo : ISerializable
	{
		// Token: 0x0600695C RID: 26972 RVA: 0x00167FB7 File Offset: 0x001661B7
		private DriveInfo(string path, string fstype)
		{
			this.drive_format = fstype;
			this.path = path;
		}

		/// <summary>Предоставляет доступ к сведениям на указанном диске.</summary>
		/// <param name="driveName">Недействительный путь к диску или недействительная буква диска. Буквы могут быть как в верхнем, так и в нижнем регистре, от ''a'' до ''z''. Значение ''null'' не является допустимым значением.</param>
		/// <exception cref="T:System.ArgumentNullException">Для буквы диска не может быть задано значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Первая буква <paramref name="driveName" /> не является буквой верхнего или нижнего регистра от ''a'' до ''z''.  
		///
		/// или - 
		/// <paramref name="driveName" /> не относится к допустимому диску.</exception>
		// Token: 0x0600695D RID: 26973 RVA: 0x00167FD0 File Offset: 0x001661D0
		public DriveInfo(string driveName)
		{
			if (!Environment.IsUnix)
			{
				if (driveName == null || driveName.Length == 0)
				{
					throw new ArgumentException("The drive name is null or empty", "driveName");
				}
				if (driveName.Length >= 2 && driveName[1] != ':')
				{
					throw new ArgumentException("Invalid drive name", "driveName");
				}
				driveName = char.ToUpperInvariant(driveName[0]).ToString() + ":\\";
			}
			DriveInfo[] drives = DriveInfo.GetDrives();
			Array.Sort<DriveInfo>(drives, (DriveInfo di1, DriveInfo di2) => string.Compare(di2.path, di1.path, true));
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveName.StartsWith(driveInfo.path, StringComparison.OrdinalIgnoreCase))
				{
					this.path = driveInfo.path;
					this.drive_format = driveInfo.drive_format;
					return;
				}
			}
			throw new ArgumentException("The drive name does not exist", "driveName");
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x001680C0 File Offset: 0x001662C0
		private static void GetDiskFreeSpace(string path, out ulong availableFreeSpace, out ulong totalSize, out ulong totalFreeSpace)
		{
			MonoIOError error;
			if (!DriveInfo.GetDiskFreeSpaceInternal(path, out availableFreeSpace, out totalSize, out totalFreeSpace, out error))
			{
				throw MonoIO.GetException(path, error);
			}
		}

		/// <summary>Указывает объем доступного свободного места на диске в байтах.</summary>
		/// <returns>Объем свободного места, доступного на диске, в байтах.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Отказано в доступе к сведениям о диске.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода (например, ошибка диска или диск не был готов).</exception>
		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x0600695F RID: 26975 RVA: 0x001680E4 File Offset: 0x001662E4
		public long AvailableFreeSpace
		{
			get
			{
				ulong num;
				ulong num2;
				ulong num3;
				DriveInfo.GetDiskFreeSpace(this.path, out num, out num2, out num3);
				if (num <= 9223372036854775807UL)
				{
					return (long)num;
				}
				return long.MaxValue;
			}
		}

		/// <summary>Возвращает общий объем свободного места, доступного на диске, в байтах.</summary>
		/// <returns>Общий объем свободного места, доступного на диске, в байтах.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Отказано в доступе к сведениям о диске.</exception>
		/// <exception cref="T:System.IO.DriveNotFoundException">Диск не сопоставлен или не существует.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода (например, ошибка диска или диск не был готов).</exception>
		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06006960 RID: 26976 RVA: 0x0016811C File Offset: 0x0016631C
		public long TotalFreeSpace
		{
			get
			{
				ulong num;
				ulong num2;
				ulong num3;
				DriveInfo.GetDiskFreeSpace(this.path, out num, out num2, out num3);
				if (num3 <= 9223372036854775807UL)
				{
					return (long)num3;
				}
				return long.MaxValue;
			}
		}

		/// <summary>Возвращает общий размер места для хранения на диске в байтах.</summary>
		/// <returns>Общий размер диска в байтах.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Отказано в доступе к сведениям о диске.</exception>
		/// <exception cref="T:System.IO.DriveNotFoundException">Диск не сопоставлен или не существует.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода (например, ошибка диска или диск не был готов).</exception>
		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06006961 RID: 26977 RVA: 0x00168154 File Offset: 0x00166354
		public long TotalSize
		{
			get
			{
				ulong num;
				ulong num2;
				ulong num3;
				DriveInfo.GetDiskFreeSpace(this.path, out num, out num2, out num3);
				if (num2 <= 9223372036854775807UL)
				{
					return (long)num2;
				}
				return long.MaxValue;
			}
		}

		/// <summary>Возвращает или задает метку тома диска.</summary>
		/// <returns>Метка тома.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода (например, ошибка диска или диск не был готов).</exception>
		/// <exception cref="T:System.IO.DriveNotFoundException">Диск не сопоставлен или не существует.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Метка тома задается по сети или на дисководе для компакт-дисков.  
		///
		/// или - 
		/// Отказано в доступе к сведениям о диске.</exception>
		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06006962 RID: 26978 RVA: 0x00168189 File Offset: 0x00166389
		// (set) Token: 0x06006963 RID: 26979 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("Currently get only works on Mono/Unix; set not implemented")]
		public string VolumeLabel
		{
			get
			{
				return this.path;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает имя файловой системы, например NTFS или FAT32.</summary>
		/// <returns>Имя файловой системы на указанном диске.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Отказано в доступе к сведениям о диске.</exception>
		/// <exception cref="T:System.IO.DriveNotFoundException">Диск не существует или не сопоставлен.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода (например, ошибка диска или диск не был готов).</exception>
		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06006964 RID: 26980 RVA: 0x00168191 File Offset: 0x00166391
		public string DriveFormat
		{
			get
			{
				return this.drive_format;
			}
		}

		/// <summary>Возвращает тип диска, например компакт-диск, съемный, сетевой или несъемный.</summary>
		/// <returns>Одно из значений перечисления, задающее тип диска.</returns>
		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06006965 RID: 26981 RVA: 0x00168199 File Offset: 0x00166399
		public DriveType DriveType
		{
			get
			{
				return (DriveType)DriveInfo.GetDriveTypeInternal(this.path);
			}
		}

		/// <summary>Возвращает имя диска, например C:\.</summary>
		/// <returns>Имя диска.</returns>
		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06006966 RID: 26982 RVA: 0x00168189 File Offset: 0x00166389
		public string Name
		{
			get
			{
				return this.path;
			}
		}

		/// <summary>Возвращает корневой каталог диска.</summary>
		/// <returns>Объект, содержащий корневой каталог диска.</returns>
		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06006967 RID: 26983 RVA: 0x001681A6 File Offset: 0x001663A6
		public DirectoryInfo RootDirectory
		{
			get
			{
				return new DirectoryInfo(this.path);
			}
		}

		/// <summary>Возвращает значение, указывающее, готов ли диск.</summary>
		/// <returns>Значение <see langword="true" />, если диск готов; значение <see langword="false" />, если диск не готов.</returns>
		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06006968 RID: 26984 RVA: 0x001681B3 File Offset: 0x001663B3
		public bool IsReady
		{
			get
			{
				return Directory.Exists(this.Name);
			}
		}

		/// <summary>Возвращает имена всех логических дисков на компьютере.</summary>
		/// <returns>Массив типа <see cref="T:System.IO.DriveInfo" />, представляющий логические диски на компьютере.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода (например, ошибка диска или диск не был готов).</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06006969 RID: 26985 RVA: 0x001681C0 File Offset: 0x001663C0
		[MonoTODO("In windows, alldrives are 'Fixed'")]
		public static DriveInfo[] GetDrives()
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			DriveInfo[] array = new DriveInfo[logicalDrives.Length];
			int num = 0;
			foreach (string rootPathName in logicalDrives)
			{
				array[num++] = new DriveInfo(rootPathName, DriveInfo.GetDriveFormat(rootPathName));
			}
			return array;
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="info">Объект, который требуется заполнить данными.</param>
		/// <param name="context">Конечный объект (см. <see cref="T:System.Runtime.Serialization.StreamingContext" />) для этой сериализации.</param>
		// Token: 0x0600696A RID: 26986 RVA: 0x000479F8 File Offset: 0x00045BF8
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает имя диска в виде строки.</summary>
		/// <returns>Имя диска.</returns>
		// Token: 0x0600696B RID: 26987 RVA: 0x00168207 File Offset: 0x00166407
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0600696C RID: 26988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern bool GetDiskFreeSpaceInternal(char* pathName, int pathName_length, out ulong freeBytesAvail, out ulong totalNumberOfBytes, out ulong totalNumberOfFreeBytes, out MonoIOError error);

		// Token: 0x0600696D RID: 26989 RVA: 0x00168210 File Offset: 0x00166410
		private unsafe static bool GetDiskFreeSpaceInternal(string pathName, out ulong freeBytesAvail, out ulong totalNumberOfBytes, out ulong totalNumberOfFreeBytes, out MonoIOError error)
		{
			char* ptr = pathName;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return DriveInfo.GetDiskFreeSpaceInternal(ptr, (pathName != null) ? pathName.Length : 0, out freeBytesAvail, out totalNumberOfBytes, out totalNumberOfFreeBytes, out error);
		}

		// Token: 0x0600696E RID: 26990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern uint GetDriveTypeInternal(char* rootPathName, int rootPathName_length);

		// Token: 0x0600696F RID: 26991 RVA: 0x00168244 File Offset: 0x00166444
		private unsafe static uint GetDriveTypeInternal(string rootPathName)
		{
			char* ptr = rootPathName;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return DriveInfo.GetDriveTypeInternal(ptr, (rootPathName != null) ? rootPathName.Length : 0);
		}

		// Token: 0x06006970 RID: 26992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern string GetDriveFormatInternal(char* rootPathName, int rootPathName_length);

		// Token: 0x06006971 RID: 26993 RVA: 0x00168274 File Offset: 0x00166474
		private unsafe static string GetDriveFormat(string rootPathName)
		{
			char* ptr = rootPathName;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return DriveInfo.GetDriveFormatInternal(ptr, (rootPathName != null) ? rootPathName.Length : 0);
		}

		// Token: 0x04003D2A RID: 15658
		private string drive_format;

		// Token: 0x04003D2B RID: 15659
		private string path;
	}
}
