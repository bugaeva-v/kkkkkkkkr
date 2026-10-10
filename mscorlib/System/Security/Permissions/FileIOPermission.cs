using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace System.Security.Permissions
{
	/// <summary>Управляет возможностью доступа к файлам и папкам. Этот класс не наследуется.</summary>
	// Token: 0x02000438 RID: 1080
	[ComVisible(true)]
	[Serializable]
	public sealed class FileIOPermission : CodeAccessPermission, IBuiltInPermission, IUnrestrictedPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.FileIOPermission" /> указанным состоянием разрешения: полностью ограниченное или неограниченное.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым значением для <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06002BC7 RID: 11207 RVA: 0x0009E030 File Offset: 0x0009C230
		public FileIOPermission(PermissionState state)
		{
			if (CodeAccessPermission.CheckPermissionState(state, true) == PermissionState.Unrestricted)
			{
				this.m_Unrestricted = true;
				this.m_AllFilesAccess = FileIOPermissionAccess.AllAccess;
				this.m_AllLocalFilesAccess = FileIOPermissionAccess.AllAccess;
			}
			this.CreateLists();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.FileIOPermission" /> с заданным доступом к указанному файлу или каталогу.</summary>
		/// <param name="access">Битовая комбинация значений перечисления <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.</param>
		/// <param name="path">Абсолютный путь к файлу или каталогу.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.  
		/// -или- 
		/// Параметр <paramref name="path" /> не является допустимой строкой.  
		/// -или- 
		/// Параметр <paramref name="path" /> не указывает абсолютный путь к файлу или каталогу.</exception>
		// Token: 0x06002BC8 RID: 11208 RVA: 0x0009E05F File Offset: 0x0009C25F
		public FileIOPermission(FileIOPermissionAccess access, string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			this.CreateLists();
			this.AddPathList(access, path);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.FileIOPermission" /> заданным уровнем доступа к указанным файлам или каталогам.</summary>
		/// <param name="access">Битовая комбинация значений перечисления <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.</param>
		/// <param name="pathList">Массив, содержащий абсолютные пути к файлам и каталогам.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.  
		/// -или- 
		/// Запись в массиве <paramref name="pathList" /> не является допустимой строкой.</exception>
		// Token: 0x06002BC9 RID: 11209 RVA: 0x0009E083 File Offset: 0x0009C283
		public FileIOPermission(FileIOPermissionAccess access, string[] pathList)
		{
			if (pathList == null)
			{
				throw new ArgumentNullException("pathList");
			}
			this.CreateLists();
			this.AddPathList(access, pathList);
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x0009E0A7 File Offset: 0x0009C2A7
		internal void CreateLists()
		{
			this.readList = new ArrayList();
			this.writeList = new ArrayList();
			this.appendList = new ArrayList();
			this.pathList = new ArrayList();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.FileIOPermission" /> указанным доступом к назначенному файлу или каталогу, а также заданными правами доступа к сведениям об управлении файлами.</summary>
		/// <param name="access">Битовая комбинация значений перечисления <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.</param>
		/// <param name="control">Битовая комбинация значений перечисления <see cref="T:System.Security.AccessControl.AccessControlActions" />.</param>
		/// <param name="path">Абсолютный путь к файлу или каталогу.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.  
		/// -или- 
		/// Параметр <paramref name="path" /> не является допустимой строкой.  
		/// -или- 
		/// Параметр <paramref name="path" /> не указывает абсолютный путь к файлу или каталогу.</exception>
		// Token: 0x06002BCB RID: 11211 RVA: 0x0009E0D5 File Offset: 0x0009C2D5
		[MonoTODO("(2.0) Access Control isn't implemented")]
		public FileIOPermission(FileIOPermissionAccess access, AccessControlActions control, string path)
		{
			throw new NotImplementedException();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.FileIOPermission" /> с указанным доступом к назначенным файлам и каталогам, а также с заданными правами доступа к сведениям об управлении файлами.</summary>
		/// <param name="access">Битовая комбинация значений перечисления <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.</param>
		/// <param name="control">Битовая комбинация значений перечисления <see cref="T:System.Security.AccessControl.AccessControlActions" />.</param>
		/// <param name="pathList">Массив, содержащий абсолютные пути к файлам и каталогам.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.  
		/// -или- 
		/// Запись в массиве <paramref name="pathList" /> не является допустимой строкой.</exception>
		// Token: 0x06002BCC RID: 11212 RVA: 0x0009E0D5 File Offset: 0x0009C2D5
		[MonoTODO("(2.0) Access Control isn't implemented")]
		public FileIOPermission(FileIOPermissionAccess access, AccessControlActions control, string[] pathList)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x0009E0E2 File Offset: 0x0009C2E2
		internal FileIOPermission(FileIOPermissionAccess access, string[] pathList, bool checkForDuplicates, bool needFullPath)
		{
		}

		/// <summary>Получает или задает разрешенный доступ ко всем файлам.</summary>
		/// <returns>Набор флагов файлового ввода-вывода для всех файлов.</returns>
		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x0009E0EA File Offset: 0x0009C2EA
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x0009E0F2 File Offset: 0x0009C2F2
		public FileIOPermissionAccess AllFiles
		{
			get
			{
				return this.m_AllFilesAccess;
			}
			set
			{
				if (!this.m_Unrestricted)
				{
					this.m_AllFilesAccess = value;
				}
			}
		}

		/// <summary>Получает или задает разрешенный доступ ко всем локальным файлам.</summary>
		/// <returns>Набор флагов файлового ввода-вывода для всех локальных файлов.</returns>
		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x0009E103 File Offset: 0x0009C303
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x0009E10B File Offset: 0x0009C30B
		public FileIOPermissionAccess AllLocalFiles
		{
			get
			{
				return this.m_AllLocalFilesAccess;
			}
			set
			{
				if (!this.m_Unrestricted)
				{
					this.m_AllLocalFilesAccess = value;
				}
			}
		}

		/// <summary>Добавляет доступ для заданного файла или каталога к существующему состоянию разрешения.</summary>
		/// <param name="access">Поразрядное сочетание значений <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.</param>
		/// <param name="path">Абсолютный путь к файлу или каталогу.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.  
		/// -или- 
		/// Параметр <paramref name="path" /> не является допустимой строкой.  
		/// -или- 
		/// Параметр <paramref name="path" /> не указывает абсолютный путь к файлу или каталогу.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Параметр <paramref name="path" /> имеет недопустимый формат.</exception>
		// Token: 0x06002BD2 RID: 11218 RVA: 0x0009E11C File Offset: 0x0009C31C
		public void AddPathList(FileIOPermissionAccess access, string path)
		{
			if ((FileIOPermissionAccess.AllAccess & access) != access)
			{
				FileIOPermission.ThrowInvalidFlag(access, true);
			}
			FileIOPermission.ThrowIfInvalidPath(path);
			this.AddPathInternal(access, path);
		}

		/// <summary>Добавляет доступ для заданных файлов или каталогов к существующему состоянию разрешения.</summary>
		/// <param name="access">Поразрядное сочетание значений <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.</param>
		/// <param name="pathList">Массив, содержащий абсолютные пути к файлам и каталогам.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.  
		/// -или- 
		/// Запись в массиве <paramref name="pathList" /> недопустима.</exception>
		/// <exception cref="T:System.NotSupportedException">Запись в массиве <paramref name="pathList" /> имеет недопустимый формат.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="pathList" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002BD3 RID: 11219 RVA: 0x0009E13C File Offset: 0x0009C33C
		public void AddPathList(FileIOPermissionAccess access, string[] pathList)
		{
			if ((FileIOPermissionAccess.AllAccess & access) != access)
			{
				FileIOPermission.ThrowInvalidFlag(access, true);
			}
			FileIOPermission.ThrowIfInvalidPath(pathList);
			foreach (string path in pathList)
			{
				this.AddPathInternal(access, path);
			}
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x0009E17C File Offset: 0x0009C37C
		internal void AddPathInternal(FileIOPermissionAccess access, string path)
		{
			path = Path.InsecureGetFullPath(path);
			if ((access & FileIOPermissionAccess.Read) == FileIOPermissionAccess.Read)
			{
				this.readList.Add(path);
			}
			if ((access & FileIOPermissionAccess.Write) == FileIOPermissionAccess.Write)
			{
				this.writeList.Add(path);
			}
			if ((access & FileIOPermissionAccess.Append) == FileIOPermissionAccess.Append)
			{
				this.appendList.Add(path);
			}
			if ((access & FileIOPermissionAccess.PathDiscovery) == FileIOPermissionAccess.PathDiscovery)
			{
				this.pathList.Add(path);
			}
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06002BD5 RID: 11221 RVA: 0x0009E1E0 File Offset: 0x0009C3E0
		public override IPermission Copy()
		{
			if (this.m_Unrestricted)
			{
				return new FileIOPermission(PermissionState.Unrestricted);
			}
			return new FileIOPermission(PermissionState.None)
			{
				readList = (ArrayList)this.readList.Clone(),
				writeList = (ArrayList)this.writeList.Clone(),
				appendList = (ArrayList)this.appendList.Clone(),
				pathList = (ArrayList)this.pathList.Clone(),
				m_AllFilesAccess = this.m_AllFilesAccess,
				m_AllLocalFilesAccess = this.m_AllLocalFilesAccess
			};
		}

		/// <summary>Восстанавливает разрешение с указанным состоянием из кодировки XML.</summary>
		/// <param name="esd">Кодировка XML, используемая для восстановления разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="esd" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="esd" /> не является допустимым элементом разрешения.  
		/// -или- 
		/// Несовместимый номер версии параметра <paramref name="esd" />.</exception>
		// Token: 0x06002BD6 RID: 11222 RVA: 0x0009E274 File Offset: 0x0009C474
		[SecuritySafeCritical]
		public override void FromXml(SecurityElement esd)
		{
			CodeAccessPermission.CheckSecurityElement(esd, "esd", 1, 1);
			if (CodeAccessPermission.IsUnrestricted(esd))
			{
				this.m_Unrestricted = true;
				return;
			}
			this.m_Unrestricted = false;
			string text = esd.Attribute("Read");
			if (text != null)
			{
				string[] array = text.Split(';', StringSplitOptions.None);
				this.AddPathList(FileIOPermissionAccess.Read, array);
			}
			text = esd.Attribute("Write");
			if (text != null)
			{
				string[] array = text.Split(';', StringSplitOptions.None);
				this.AddPathList(FileIOPermissionAccess.Write, array);
			}
			text = esd.Attribute("Append");
			if (text != null)
			{
				string[] array = text.Split(';', StringSplitOptions.None);
				this.AddPathList(FileIOPermissionAccess.Append, array);
			}
			text = esd.Attribute("PathDiscovery");
			if (text != null)
			{
				string[] array = text.Split(';', StringSplitOptions.None);
				this.AddPathList(FileIOPermissionAccess.PathDiscovery, array);
			}
		}

		/// <summary>Возвращает все файлы и каталоги с заданным <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.</summary>
		/// <param name="access">Одно из значений <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />, представляющее один тип доступа к файлам.</param>
		/// <returns>Массив, содержащий пути к файлам и каталогам, к которым предоставлен доступ, заданный параметром <paramref name="access" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="access" /> не является допустимым значением <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.  
		/// -или- 
		///  <paramref name="access" /> имеет значение <see cref="F:System.Security.Permissions.FileIOPermissionAccess.AllAccess" />, которое представляет несколько типов доступа к файлам, или <see cref="F:System.Security.Permissions.FileIOPermissionAccess.NoAccess" />, которое не представляет ни один тип доступа к файлам.</exception>
		// Token: 0x06002BD7 RID: 11223 RVA: 0x0009E32C File Offset: 0x0009C52C
		public string[] GetPathList(FileIOPermissionAccess access)
		{
			if ((FileIOPermissionAccess.AllAccess & access) != access)
			{
				FileIOPermission.ThrowInvalidFlag(access, true);
			}
			ArrayList arrayList = new ArrayList();
			switch (access)
			{
			case FileIOPermissionAccess.NoAccess:
				goto IL_7F;
			case FileIOPermissionAccess.Read:
				arrayList.AddRange(this.readList);
				goto IL_7F;
			case FileIOPermissionAccess.Write:
				arrayList.AddRange(this.writeList);
				goto IL_7F;
			case FileIOPermissionAccess.Append:
				arrayList.AddRange(this.appendList);
				goto IL_7F;
			case FileIOPermissionAccess.PathDiscovery:
				arrayList.AddRange(this.pathList);
				goto IL_7F;
			}
			FileIOPermission.ThrowInvalidFlag(access, false);
			IL_7F:
			if (arrayList.Count <= 0)
			{
				return null;
			}
			return (string[])arrayList.ToArray(typeof(string));
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002BD8 RID: 11224 RVA: 0x0009E3D8 File Offset: 0x0009C5D8
		public override IPermission Intersect(IPermission target)
		{
			FileIOPermission fileIOPermission = FileIOPermission.Cast(target);
			if (fileIOPermission == null)
			{
				return null;
			}
			if (this.IsUnrestricted())
			{
				return fileIOPermission.Copy();
			}
			if (fileIOPermission.IsUnrestricted())
			{
				return this.Copy();
			}
			FileIOPermission fileIOPermission2 = new FileIOPermission(PermissionState.None);
			fileIOPermission2.AllFiles = (this.m_AllFilesAccess & fileIOPermission.AllFiles);
			fileIOPermission2.AllLocalFiles = (this.m_AllLocalFilesAccess & fileIOPermission.AllLocalFiles);
			FileIOPermission.IntersectKeys(this.readList, fileIOPermission.readList, fileIOPermission2.readList);
			FileIOPermission.IntersectKeys(this.writeList, fileIOPermission.writeList, fileIOPermission2.writeList);
			FileIOPermission.IntersectKeys(this.appendList, fileIOPermission.appendList, fileIOPermission2.appendList);
			FileIOPermission.IntersectKeys(this.pathList, fileIOPermission.pathList, fileIOPermission2.pathList);
			if (!fileIOPermission2.IsEmpty())
			{
				return fileIOPermission2;
			}
			return null;
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение, для которого требуется проверить отношение подмножества. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002BD9 RID: 11225 RVA: 0x0009E4A4 File Offset: 0x0009C6A4
		public override bool IsSubsetOf(IPermission target)
		{
			FileIOPermission fileIOPermission = FileIOPermission.Cast(target);
			if (fileIOPermission == null)
			{
				return false;
			}
			if (fileIOPermission.IsEmpty())
			{
				return this.IsEmpty();
			}
			if (this.IsUnrestricted())
			{
				return fileIOPermission.IsUnrestricted();
			}
			return fileIOPermission.IsUnrestricted() || ((this.m_AllFilesAccess & fileIOPermission.AllFiles) == this.m_AllFilesAccess && (this.m_AllLocalFilesAccess & fileIOPermission.AllLocalFiles) == this.m_AllLocalFilesAccess && FileIOPermission.KeyIsSubsetOf(this.appendList, fileIOPermission.appendList) && FileIOPermission.KeyIsSubsetOf(this.readList, fileIOPermission.readList) && FileIOPermission.KeyIsSubsetOf(this.writeList, fileIOPermission.writeList) && FileIOPermission.KeyIsSubsetOf(this.pathList, fileIOPermission.pathList));
		}

		/// <summary>Возвращает значение, указывающее, является ли текущее разрешение неограниченным.</summary>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является неограниченным. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002BDA RID: 11226 RVA: 0x0009E568 File Offset: 0x0009C768
		public bool IsUnrestricted()
		{
			return this.m_Unrestricted;
		}

		/// <summary>Задает указанный доступ к указанному файлу или каталогу, заменяя существующее состояние разрешения.</summary>
		/// <param name="access">Поразрядное сочетание значений <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.</param>
		/// <param name="path">Абсолютный путь к файлу или каталогу.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.  
		/// -или- 
		/// Параметр <paramref name="path" /> не является допустимой строкой.  
		/// -или- 
		/// Параметр <paramref name="path" /> не указывает абсолютный путь к файлу или каталогу.</exception>
		// Token: 0x06002BDB RID: 11227 RVA: 0x0009E570 File Offset: 0x0009C770
		public void SetPathList(FileIOPermissionAccess access, string path)
		{
			if ((FileIOPermissionAccess.AllAccess & access) != access)
			{
				FileIOPermission.ThrowInvalidFlag(access, true);
			}
			FileIOPermission.ThrowIfInvalidPath(path);
			this.Clear(access);
			this.AddPathInternal(access, path);
		}

		/// <summary>Устанавливает заданный доступ для указанных файлов и каталогов, заменяя текущее состояние заданного доступа на новый набор путей.</summary>
		/// <param name="access">Поразрядное сочетание значений <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.</param>
		/// <param name="pathList">Массив, содержащий абсолютные пути к файлам и каталогам.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым значением для <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />.  
		/// -или- 
		/// Запись в параметре <paramref name="pathList" /> не является допустимой строкой.</exception>
		// Token: 0x06002BDC RID: 11228 RVA: 0x0009E598 File Offset: 0x0009C798
		public void SetPathList(FileIOPermissionAccess access, string[] pathList)
		{
			if ((FileIOPermissionAccess.AllAccess & access) != access)
			{
				FileIOPermission.ThrowInvalidFlag(access, true);
			}
			FileIOPermission.ThrowIfInvalidPath(pathList);
			this.Clear(access);
			foreach (string path in pathList)
			{
				this.AddPathInternal(access, path);
			}
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Кодировка XML разрешения, включающая любые сведения о состоянии.</returns>
		// Token: 0x06002BDD RID: 11229 RVA: 0x0009E5DC File Offset: 0x0009C7DC
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.Element(1);
			if (this.m_Unrestricted)
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			else
			{
				string[] array = this.GetPathList(FileIOPermissionAccess.Append);
				if (array != null && array.Length != 0)
				{
					securityElement.AddAttribute("Append", string.Join(";", array));
				}
				array = this.GetPathList(FileIOPermissionAccess.Read);
				if (array != null && array.Length != 0)
				{
					securityElement.AddAttribute("Read", string.Join(";", array));
				}
				array = this.GetPathList(FileIOPermissionAccess.Write);
				if (array != null && array.Length != 0)
				{
					securityElement.AddAttribute("Write", string.Join(";", array));
				}
				array = this.GetPathList(FileIOPermissionAccess.PathDiscovery);
				if (array != null && array.Length != 0)
				{
					securityElement.AddAttribute("PathDiscovery", string.Join(";", array));
				}
			}
			return securityElement;
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="other">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="other" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002BDE RID: 11230 RVA: 0x0009E6A4 File Offset: 0x0009C8A4
		public override IPermission Union(IPermission other)
		{
			FileIOPermission fileIOPermission = FileIOPermission.Cast(other);
			if (fileIOPermission == null)
			{
				return this.Copy();
			}
			if (this.IsUnrestricted() || fileIOPermission.IsUnrestricted())
			{
				return new FileIOPermission(PermissionState.Unrestricted);
			}
			if (this.IsEmpty() && fileIOPermission.IsEmpty())
			{
				return null;
			}
			FileIOPermission fileIOPermission2 = (FileIOPermission)this.Copy();
			fileIOPermission2.AllFiles |= fileIOPermission.AllFiles;
			fileIOPermission2.AllLocalFiles |= fileIOPermission.AllLocalFiles;
			string[] array = fileIOPermission.GetPathList(FileIOPermissionAccess.Read);
			if (array != null)
			{
				FileIOPermission.UnionKeys(fileIOPermission2.readList, array);
			}
			array = fileIOPermission.GetPathList(FileIOPermissionAccess.Write);
			if (array != null)
			{
				FileIOPermission.UnionKeys(fileIOPermission2.writeList, array);
			}
			array = fileIOPermission.GetPathList(FileIOPermissionAccess.Append);
			if (array != null)
			{
				FileIOPermission.UnionKeys(fileIOPermission2.appendList, array);
			}
			array = fileIOPermission.GetPathList(FileIOPermissionAccess.PathDiscovery);
			if (array != null)
			{
				FileIOPermission.UnionKeys(fileIOPermission2.pathList, array);
			}
			return fileIOPermission2;
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Security.Permissions.FileIOPermission" /> текущему объекту <see cref="T:System.Security.Permissions.FileIOPermission" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Security.Permissions.FileIOPermission" />, который требуется сравнить с текущим объектом <see cref="T:System.Security.Permissions.FileIOPermission" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Security.Permissions.FileIOPermission" /> равен текущему объекту <see cref="T:System.Security.Permissions.FileIOPermission" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002BDF RID: 11231 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("(2.0)")]
		[ComVisible(false)]
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Возвращает хэш-код для объекта <see cref="T:System.Security.Permissions.FileIOPermission" />, который можно использовать в алгоритмах хэширования и структурах данных, например в хэш-таблице.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Security.Permissions.FileIOPermission" />.</returns>
		// Token: 0x06002BE0 RID: 11232 RVA: 0x0009E77A File Offset: 0x0009C97A
		[MonoTODO("(2.0)")]
		[ComVisible(false)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x00015831 File Offset: 0x00013A31
		int IBuiltInPermission.GetTokenIndex()
		{
			return 2;
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x0009E784 File Offset: 0x0009C984
		private bool IsEmpty()
		{
			return !this.m_Unrestricted && this.appendList.Count == 0 && this.readList.Count == 0 && this.writeList.Count == 0 && this.pathList.Count == 0;
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x0009E7D0 File Offset: 0x0009C9D0
		private static FileIOPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			FileIOPermission fileIOPermission = target as FileIOPermission;
			if (fileIOPermission == null)
			{
				CodeAccessPermission.ThrowInvalidPermission(target, typeof(FileIOPermission));
			}
			return fileIOPermission;
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x0009E7F0 File Offset: 0x0009C9F0
		internal static void ThrowInvalidFlag(FileIOPermissionAccess access, bool context)
		{
			string text;
			if (context)
			{
				text = Locale.GetText("Unknown flag '{0}'.");
			}
			else
			{
				text = Locale.GetText("Invalid flag '{0}' in this context.");
			}
			throw new ArgumentException(string.Format(text, access), "access");
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x0009E830 File Offset: 0x0009CA30
		internal static void ThrowIfInvalidPath(string path)
		{
			string directoryName = Path.GetDirectoryName(path);
			if (directoryName != null && directoryName.LastIndexOfAny(FileIOPermission.BadPathNameCharacters) >= 0)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid path characters in path: '{0}'"), path), "path");
			}
			string fileName = Path.GetFileName(path);
			if (fileName != null && fileName.LastIndexOfAny(FileIOPermission.BadFileNameCharacters) >= 0)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid filename characters in path: '{0}'"), path), "path");
			}
			if (!Path.IsPathRooted(path))
			{
				throw new ArgumentException(Locale.GetText("Absolute path information is required."), "path");
			}
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x0009E8C0 File Offset: 0x0009CAC0
		internal static void ThrowIfInvalidPath(string[] paths)
		{
			for (int i = 0; i < paths.Length; i++)
			{
				FileIOPermission.ThrowIfInvalidPath(paths[i]);
			}
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x0009E8E8 File Offset: 0x0009CAE8
		internal void Clear(FileIOPermissionAccess access)
		{
			if ((access & FileIOPermissionAccess.Read) == FileIOPermissionAccess.Read)
			{
				this.readList.Clear();
			}
			if ((access & FileIOPermissionAccess.Write) == FileIOPermissionAccess.Write)
			{
				this.writeList.Clear();
			}
			if ((access & FileIOPermissionAccess.Append) == FileIOPermissionAccess.Append)
			{
				this.appendList.Clear();
			}
			if ((access & FileIOPermissionAccess.PathDiscovery) == FileIOPermissionAccess.PathDiscovery)
			{
				this.pathList.Clear();
			}
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x0009E93C File Offset: 0x0009CB3C
		internal static bool KeyIsSubsetOf(IList local, IList target)
		{
			bool flag = false;
			foreach (object obj in local)
			{
				string path = (string)obj;
				using (IEnumerator enumerator2 = target.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (Path.IsPathSubsetOf((string)enumerator2.Current, path))
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0009E9E4 File Offset: 0x0009CBE4
		internal static void UnionKeys(IList list, string[] paths)
		{
			foreach (string text in paths)
			{
				int count = list.Count;
				if (count == 0)
				{
					list.Add(text);
				}
				else
				{
					int j;
					for (j = 0; j < count; j++)
					{
						string text2 = (string)list[j];
						if (Path.IsPathSubsetOf(text, text2))
						{
							list[j] = text;
							break;
						}
						if (Path.IsPathSubsetOf(text2, text))
						{
							break;
						}
					}
					if (j == count)
					{
						list.Add(text);
					}
				}
			}
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x0009EA64 File Offset: 0x0009CC64
		internal static void IntersectKeys(IList local, IList target, IList result)
		{
			foreach (object obj in local)
			{
				string text = (string)obj;
				foreach (object obj2 in target)
				{
					string text2 = (string)obj2;
					if (text2.Length > text.Length)
					{
						if (Path.IsPathSubsetOf(text, text2))
						{
							result.Add(text2);
						}
					}
					else if (Path.IsPathSubsetOf(text2, text))
					{
						result.Add(text);
					}
				}
			}
		}

		// Token: 0x04002013 RID: 8211
		private const int version = 1;

		// Token: 0x04002014 RID: 8212
		private static char[] BadPathNameCharacters = Path.GetInvalidPathChars();

		// Token: 0x04002015 RID: 8213
		private static char[] BadFileNameCharacters = Path.GetInvalidFileNameChars();

		// Token: 0x04002016 RID: 8214
		private bool m_Unrestricted;

		// Token: 0x04002017 RID: 8215
		private FileIOPermissionAccess m_AllFilesAccess;

		// Token: 0x04002018 RID: 8216
		private FileIOPermissionAccess m_AllLocalFilesAccess;

		// Token: 0x04002019 RID: 8217
		private ArrayList readList;

		// Token: 0x0400201A RID: 8218
		private ArrayList writeList;

		// Token: 0x0400201B RID: 8219
		private ArrayList appendList;

		// Token: 0x0400201C RID: 8220
		private ArrayList pathList;
	}
}
