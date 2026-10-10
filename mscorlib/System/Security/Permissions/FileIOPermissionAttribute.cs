using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.FileIOPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x0200043A RID: 1082
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class FileIOPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.FileIOPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="action" /> не является допустимым <see cref="T:System.Security.Permissions.SecurityAction" />.</exception>
		// Token: 0x06002BEB RID: 11243 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public FileIOPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Возвращает или устанавливает полный доступ к файлу или каталогу, заданному строковым значением.</summary>
		/// <returns>Абсолютный путь файла или каталога для полного доступа.</returns>
		/// <exception cref="T:System.NotSupportedException">Это свойство не поддерживает метод Get.</exception>
		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x0009DCFD File Offset: 0x0009BEFD
		// (set) Token: 0x06002BED RID: 11245 RVA: 0x0009EB28 File Offset: 0x0009CD28
		[Obsolete("use newer properties")]
		public string All
		{
			get
			{
				throw new NotSupportedException("All");
			}
			set
			{
				this.append = value;
				this.path = value;
				this.read = value;
				this.write = value;
			}
		}

		/// <summary>Возвращает или устанавливает доступ к файлу или каталогу, заданному строковым значением.</summary>
		/// <returns>Абсолютный путь для доступа к файлу или каталогу.</returns>
		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x0009EB46 File Offset: 0x0009CD46
		// (set) Token: 0x06002BEF RID: 11247 RVA: 0x0009EB4E File Offset: 0x0009CD4E
		public string Append
		{
			get
			{
				return this.append;
			}
			set
			{
				this.append = value;
			}
		}

		/// <summary>Возвращает или задает файл или каталог, для которого необходимо предоставить разрешение обнаружения пути.</summary>
		/// <returns>Абсолютный путь к файлу или каталогу.</returns>
		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x0009EB57 File Offset: 0x0009CD57
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x0009EB5F File Offset: 0x0009CD5F
		public string PathDiscovery
		{
			get
			{
				return this.path;
			}
			set
			{
				this.path = value;
			}
		}

		/// <summary>Возвращает или устанавливает доступ на чтение для файла или каталога, заданного строковым значением.</summary>
		/// <returns>Абсолютный путь к файлу или каталогу для доступа на чтение.</returns>
		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x0009EB68 File Offset: 0x0009CD68
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x0009EB70 File Offset: 0x0009CD70
		public string Read
		{
			get
			{
				return this.read;
			}
			set
			{
				this.read = value;
			}
		}

		/// <summary>Возвращает или устанавливает доступ на запись для файла или каталога, заданного строковым значением.</summary>
		/// <returns>Абсолютный путь к файлу или каталогу для доступа на запись.</returns>
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x0009EB79 File Offset: 0x0009CD79
		// (set) Token: 0x06002BF5 RID: 11253 RVA: 0x0009EB81 File Offset: 0x0009CD81
		public string Write
		{
			get
			{
				return this.write;
			}
			set
			{
				this.write = value;
			}
		}

		/// <summary>Получает или задает разрешенный доступ ко всем файлам.</summary>
		/// <returns>Битовое сочетание значений <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />, представляющее разрешения для всех файлов. Значение по умолчанию — <see cref="F:System.Security.Permissions.FileIOPermissionAccess.NoAccess" />.</returns>
		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x0009EB8A File Offset: 0x0009CD8A
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x0009EB92 File Offset: 0x0009CD92
		public FileIOPermissionAccess AllFiles
		{
			get
			{
				return this.allFiles;
			}
			set
			{
				this.allFiles = value;
			}
		}

		/// <summary>Получает или задает разрешенный доступ ко всем локальным файлам.</summary>
		/// <returns>Битовое сочетание значений <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />, представляющее разрешения для всех локальных файлов. Значение по умолчанию — <see cref="F:System.Security.Permissions.FileIOPermissionAccess.NoAccess" />.</returns>
		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x0009EB9B File Offset: 0x0009CD9B
		// (set) Token: 0x06002BF9 RID: 11257 RVA: 0x0009EBA3 File Offset: 0x0009CDA3
		public FileIOPermissionAccess AllLocalFiles
		{
			get
			{
				return this.allLocalFiles;
			}
			set
			{
				this.allLocalFiles = value;
			}
		}

		/// <summary>Возвращает или задает файл или каталог, для которого можно изменить данные управления доступом.</summary>
		/// <returns>Абсолютный путь к файлу или каталогу, для которого можно изменить данные управления доступом.</returns>
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x0009EBAC File Offset: 0x0009CDAC
		// (set) Token: 0x06002BFB RID: 11259 RVA: 0x0009EBB4 File Offset: 0x0009CDB4
		public string ChangeAccessControl
		{
			get
			{
				return this.changeAccessControl;
			}
			set
			{
				this.changeAccessControl = value;
			}
		}

		/// <summary>Возвращает или задает файл или каталог, для которого можно просмотреть данные управления доступом.</summary>
		/// <returns>Абсолютный путь к файлу или каталогу, для которого можно просмотреть данные управления доступом.</returns>
		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x0009EBBD File Offset: 0x0009CDBD
		// (set) Token: 0x06002BFD RID: 11261 RVA: 0x0009EBC5 File Offset: 0x0009CDC5
		public string ViewAccessControl
		{
			get
			{
				return this.viewAccessControl;
			}
			set
			{
				this.viewAccessControl = value;
			}
		}

		/// <summary>Возвращает или задает файл или каталог, в котором можно просмотреть и изменить данные файла.</summary>
		/// <returns>Абсолютный путь к файлу или каталогу, в котором можно просмотреть и изменить данные файла.</returns>
		/// <exception cref="T:System.NotSupportedException">Вызывается метод доступа <see langword="get" />. Этот метод доступа предоставляется только для совместимости с компилятором C#.</exception>
		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x000472C8 File Offset: 0x000454C8
		// (set) Token: 0x06002BFF RID: 11263 RVA: 0x0009EB28 File Offset: 0x0009CD28
		public string ViewAndModify
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				this.append = value;
				this.path = value;
				this.read = value;
				this.write = value;
			}
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.FileIOPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.FileIOPermission" />, соответствующий этому атрибуту.</returns>
		/// <exception cref="T:System.ArgumentException">Сведения пути к файлу или каталогу, для которого должна быть обеспечена безопасность доступа, содержат недопустимые символы или спецификаторы подстановочных знаков.</exception>
		// Token: 0x06002C00 RID: 11264 RVA: 0x0009EBD0 File Offset: 0x0009CDD0
		public override IPermission CreatePermission()
		{
			FileIOPermission fileIOPermission;
			if (base.Unrestricted)
			{
				fileIOPermission = new FileIOPermission(PermissionState.Unrestricted);
			}
			else
			{
				fileIOPermission = new FileIOPermission(PermissionState.None);
				if (this.append != null)
				{
					fileIOPermission.AddPathList(FileIOPermissionAccess.Append, this.append);
				}
				if (this.path != null)
				{
					fileIOPermission.AddPathList(FileIOPermissionAccess.PathDiscovery, this.path);
				}
				if (this.read != null)
				{
					fileIOPermission.AddPathList(FileIOPermissionAccess.Read, this.read);
				}
				if (this.write != null)
				{
					fileIOPermission.AddPathList(FileIOPermissionAccess.Write, this.write);
				}
			}
			return fileIOPermission;
		}

		// Token: 0x04002024 RID: 8228
		private string append;

		// Token: 0x04002025 RID: 8229
		private string path;

		// Token: 0x04002026 RID: 8230
		private string read;

		// Token: 0x04002027 RID: 8231
		private string write;

		// Token: 0x04002028 RID: 8232
		private FileIOPermissionAccess allFiles;

		// Token: 0x04002029 RID: 8233
		private FileIOPermissionAccess allLocalFiles;

		// Token: 0x0400202A RID: 8234
		private string changeAccessControl;

		// Token: 0x0400202B RID: 8235
		private string viewAccessControl;
	}
}
