using System;
using System.Collections;
using System.IO;

namespace System.CodeDom.Compiler
{
	/// <summary>Представляет коллекцию временных файлов.</summary>
	// Token: 0x02000341 RID: 833
	[Serializable]
	public class TempFileCollection : ICollection, IEnumerable, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.TempFileCollection" /> со значениями по умолчанию.</summary>
		// Token: 0x06001A67 RID: 6759 RVA: 0x00061919 File Offset: 0x0005FB19
		public TempFileCollection() : this(null, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.CodeDom.Compiler.TempFileCollection" />, используя указанный временный каталог, из которого временные файлы будут удалены по умолчанию после создания и использования.</summary>
		/// <param name="tempDir">Путь к временному каталогу для сохранения временных файлов.</param>
		// Token: 0x06001A68 RID: 6760 RVA: 0x00061923 File Offset: 0x0005FB23
		public TempFileCollection(string tempDir) : this(tempDir, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.CodeDom.Compiler.TempFileCollection" />, используя указанный временный каталог и значение, показывающее, следует ли по умолчанию сохранить или удалить временные файлы после создания и использования.</summary>
		/// <param name="tempDir">Путь к временному каталогу для сохранения временных файлов.</param>
		/// <param name="keepFiles">
		///   <see langword="true" />, если после использования временные файлы следует оставить; <see langword="false" />, если временные файлы должны быть удалены.</param>
		// Token: 0x06001A69 RID: 6761 RVA: 0x0006192D File Offset: 0x0005FB2D
		public TempFileCollection(string tempDir, bool keepFiles)
		{
			this.KeepFiles = keepFiles;
			this._tempDir = tempDir;
			this._files = new Hashtable(StringComparer.OrdinalIgnoreCase);
		}

		/// <summary>Выполняет определяемые приложением задачи, связанные с удалением, высвобождением или сбросом неуправляемых ресурсов.</summary>
		// Token: 0x06001A6A RID: 6762 RVA: 0x00061953 File Offset: 0x0005FB53
		void IDisposable.Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.CodeDom.Compiler.TempFileCollection" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06001A6B RID: 6763 RVA: 0x00061962 File Offset: 0x0005FB62
		protected virtual void Dispose(bool disposing)
		{
			this.SafeDelete();
		}

		/// <summary>Пытается удалить временные файлы перед тем, как данный объект будет утилизирован при сборке мусора.</summary>
		// Token: 0x06001A6C RID: 6764 RVA: 0x0006196C File Offset: 0x0005FB6C
		~TempFileCollection()
		{
			this.Dispose(false);
		}

		/// <summary>Добавляет к коллекции имя файла с указанным расширением имени файла.</summary>
		/// <param name="fileExtension">Расширение имени файла для автоматически создаваемого имени временного файла, добавляемого к коллекции.</param>
		/// <returns>Имя файла с указанным расширением, добавленное к коллекции.</returns>
		// Token: 0x06001A6D RID: 6765 RVA: 0x0006199C File Offset: 0x0005FB9C
		public string AddExtension(string fileExtension)
		{
			return this.AddExtension(fileExtension, this.KeepFiles);
		}

		/// <summary>Добавляет к коллекции имя файла с указанным расширением имени файла, используя указанное значение, показывающее, удалить файл или сохранить.</summary>
		/// <param name="fileExtension">Расширение имени файла для автоматически создаваемого имени временного файла, добавляемого к коллекции.</param>
		/// <param name="keepFile">
		///   <see langword="true" />, если после использования временный файл следует оставить; <see langword="false" />, если файл должен быть удален.</param>
		/// <returns>Имя файла с указанным расширением, добавленное к коллекции.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="fileExtension" /> имеет значение <see langword="null" /> или является пустой строкой.</exception>
		// Token: 0x06001A6E RID: 6766 RVA: 0x000619AC File Offset: 0x0005FBAC
		public string AddExtension(string fileExtension, bool keepFile)
		{
			if (string.IsNullOrEmpty(fileExtension))
			{
				throw new ArgumentException(SR.Format("Argument {0} cannot be null or zero-length.", "fileExtension"), "fileExtension");
			}
			string text = this.BasePath + "." + fileExtension;
			this.AddFile(text, keepFile);
			return text;
		}

		/// <summary>Добавляет к коллекции указанный файл, используя указанное значение, показывающее, следует ли оставлять файл после удаления коллекции или при вызове метода <see cref="M:System.CodeDom.Compiler.TempFileCollection.Delete" />.</summary>
		/// <param name="fileName">Имя файла для добавления к коллекции.</param>
		/// <param name="keepFile">
		///   <see langword="true" />, если после использования временный файл следует оставить; <see langword="false" />, если файл должен быть удален.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="fileName" /> имеет значение <see langword="null" /> или является пустой строкой.  
		///
		/// или - 
		/// Значение <paramref name="fileName" /> является дубликатом.</exception>
		// Token: 0x06001A6F RID: 6767 RVA: 0x000619F8 File Offset: 0x0005FBF8
		public void AddFile(string fileName, bool keepFile)
		{
			if (string.IsNullOrEmpty(fileName))
			{
				throw new ArgumentException(SR.Format("Argument {0} cannot be null or zero-length.", "fileName"), "fileName");
			}
			if (this._files[fileName] != null)
			{
				throw new ArgumentException(SR.Format("The file name '{0}' was already in the collection.", fileName), "fileName");
			}
			this._files.Add(fileName, keepFile);
		}

		/// <summary>Получает перечислитель, который перечисляет члены коллекции.</summary>
		/// <returns>Перечислитель <see cref="T:System.Collections.IEnumerator" />, содержащий члены коллекции.</returns>
		// Token: 0x06001A70 RID: 6768 RVA: 0x00061A5D File Offset: 0x0005FC5D
		public IEnumerator GetEnumerator()
		{
			return this._files.Keys.GetEnumerator();
		}

		/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06001A71 RID: 6769 RVA: 0x00061A5D File Offset: 0x0005FC5D
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this._files.Keys.GetEnumerator();
		}

		/// <summary>Копирует элементы коллекции в массив начиная с заданного индекса в целевом массиве.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ICollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="start">Отсчитываемый от нуля индекс в массиве, с которого начинается копирование.</param>
		// Token: 0x06001A72 RID: 6770 RVA: 0x00061A6F File Offset: 0x0005FC6F
		void ICollection.CopyTo(Array array, int start)
		{
			this._files.Keys.CopyTo(array, start);
		}

		/// <summary>Копирует члены коллекции в указанную строку начиная с указанного индекса.</summary>
		/// <param name="fileNames">Массив строк, в который выполняется копирование.</param>
		/// <param name="start">Индекс в массиве, с которого следует начать копирование.</param>
		// Token: 0x06001A73 RID: 6771 RVA: 0x00061A6F File Offset: 0x0005FC6F
		public void CopyTo(string[] fileNames, int start)
		{
			this._files.Keys.CopyTo(fileNames, start);
		}

		/// <summary>Получает число файлов в коллекции.</summary>
		/// <returns>Число файлов в коллекции.</returns>
		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x00061A83 File Offset: 0x0005FC83
		public int Count
		{
			get
			{
				return this._files.Count;
			}
		}

		/// <summary>Возвращает количество элементов, содержащихся в коллекции.</summary>
		/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x00061A83 File Offset: 0x0005FC83
		int ICollection.Count
		{
			get
			{
				return this._files.Count;
			}
		}

		/// <summary>Возвращает объект, который можно использовать для синхронизации доступа к коллекции.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x00002F6A File Offset: 0x0000116A
		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x00003062 File Offset: 0x00001262
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает временный каталог для хранения временных файлов.</summary>
		/// <returns>Временный каталог для хранения временных файлов.</returns>
		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x00061A90 File Offset: 0x0005FC90
		public string TempDir
		{
			get
			{
				return this._tempDir ?? string.Empty;
			}
		}

		/// <summary>Получает полный путь к базовому имени файла, без расширения имени файла, по пути временного каталога, используемого при создании имен временных файлов для коллекции.</summary>
		/// <returns>Полный путь к базовому имени файла, без расширения имени файла, по пути временного каталога, используемого при создании имен временных файлов для коллекции.</returns>
		/// <exception cref="T:System.Security.SecurityException">Если свойство <see cref="P:System.CodeDom.Compiler.TempFileCollection.BasePath" /> не было задано или оно задано как <see langword="null" />, а разрешение <see cref="F:System.Security.Permissions.FileIOPermissionAccess.AllAccess" /> не предоставлено для временного каталога, указанного свойством <see cref="P:System.CodeDom.Compiler.TempFileCollection.TempDir" />.</exception>
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x00061AA1 File Offset: 0x0005FCA1
		public string BasePath
		{
			get
			{
				this.EnsureTempNameCreated();
				return this._basePath;
			}
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00061AB0 File Offset: 0x0005FCB0
		private void EnsureTempNameCreated()
		{
			if (this._basePath == null)
			{
				string text = null;
				bool flag = false;
				int num = 5000;
				do
				{
					this._basePath = Path.Combine(string.IsNullOrEmpty(this.TempDir) ? Path.GetTempPath() : this.TempDir, Path.GetFileNameWithoutExtension(Path.GetRandomFileName()));
					text = this._basePath + ".tmp";
					try
					{
						new FileStream(text, FileMode.CreateNew, FileAccess.Write).Dispose();
						flag = true;
					}
					catch (IOException ex)
					{
						num--;
						if (num == 0 || ex is DirectoryNotFoundException)
						{
							throw;
						}
						flag = false;
					}
				}
				while (!flag);
				this._files.Add(text, this.KeepFiles);
			}
		}

		/// <summary>Возвращает или задает значение, показывающее, следует ли по умолчанию сохранять файлы при вызове метода <see cref="M:System.CodeDom.Compiler.TempFileCollection.Delete" /> или удалении коллекции.</summary>
		/// <returns>
		///   <see langword="true" />, если файлы следует сохранить; в противном случае <see langword="false" />.</returns>
		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x00061B64 File Offset: 0x0005FD64
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x00061B6C File Offset: 0x0005FD6C
		public bool KeepFiles { get; set; }

		// Token: 0x06001A7D RID: 6781 RVA: 0x00061B78 File Offset: 0x0005FD78
		private bool KeepFile(string fileName)
		{
			object obj = this._files[fileName];
			return obj != null && (bool)obj;
		}

		/// <summary>Удаляет из данной коллекции временные файлы, не помеченные для сохранения.</summary>
		// Token: 0x06001A7E RID: 6782 RVA: 0x00061962 File Offset: 0x0005FB62
		public void Delete()
		{
			this.SafeDelete();
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00061BA0 File Offset: 0x0005FDA0
		internal void Delete(string fileName)
		{
			try
			{
				File.Delete(fileName);
			}
			catch
			{
			}
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00061BC8 File Offset: 0x0005FDC8
		internal void SafeDelete()
		{
			if (this._files != null && this._files.Count > 0)
			{
				string[] array = new string[this._files.Count];
				this._files.Keys.CopyTo(array, 0);
				foreach (string text in array)
				{
					if (!this.KeepFile(text))
					{
						this.Delete(text);
						this._files.Remove(text);
					}
				}
			}
		}

		// Token: 0x04000E19 RID: 3609
		private string _basePath;

		// Token: 0x04000E1A RID: 3610
		private readonly string _tempDir;

		// Token: 0x04000E1B RID: 3611
		private readonly Hashtable _files;
	}
}
