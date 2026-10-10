using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition.Diagnostics;
using System.ComponentModel.Composition.Primitives;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Internal;
using Microsoft.Internal.Collections;

namespace System.ComponentModel.Composition.Hosting
{
	/// <summary>Обнаруживает части с атрибутами в сборках в указанном каталоге.</summary>
	// Token: 0x020000D9 RID: 217
	[DebuggerTypeProxy(typeof(DirectoryCatalog.DirectoryCatalogDebuggerProxy))]
	public class DirectoryCatalog : ComposablePartCatalog, INotifyComposablePartCatalogChanged, ICompositionElement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" /> с помощью объектов <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartDefinition" />, основанных на всех DLL-файлах, расположенных по указанному пути к каталогу.</summary>
		/// <param name="path">Путь к каталогу, в котором выполняется поиск сборок, добавляемых в каталог.  
		/// Необходимо указать абсолютный путь или путь относительно каталога <see cref="P:System.AppDomain.BaseDirectory" />.</param>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный <paramref name="path" /> недопустим (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> является строкой нулевой длины, содержит только пробелы или содержит один или несколько недопустимых в данной реализации символов.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный параметр <paramref name="path" />, имя файла или и то и другое превышает наибольшую возможную длину, определенную системой.</exception>
		// Token: 0x0600059A RID: 1434 RVA: 0x00011065 File Offset: 0x0000F265
		public DirectoryCatalog(string path) : this(path, "*.dll")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" /> с помощью объектов <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartDefinition" />, основанных на всех DLL-файлах, расположенном по указанному пути, в указанном контексте отражения.</summary>
		/// <param name="path">Путь к каталогу, в котором выполняется поиск сборок, добавляемых в каталог.  
		/// Необходимо указать абсолютный путь или путь относительно каталога <see cref="P:System.AppDomain.BaseDirectory" />.</param>
		/// <param name="reflectionContext">Контекст, используемый для создания частей.</param>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный <paramref name="path" /> недопустим (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> является строкой нулевой длины, содержит только пробелы или содержит один или несколько недопустимых в данной реализации символов.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный параметр <paramref name="path" />, имя файла или и то и другое превышает наибольшую возможную длину, определенную системой.</exception>
		// Token: 0x0600059B RID: 1435 RVA: 0x00011073 File Offset: 0x0000F273
		public DirectoryCatalog(string path, ReflectionContext reflectionContext) : this(path, "*.dll", reflectionContext)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" /> с помощью объектов <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartDefinition" />, основанных на всех DLL-файлах, расположенном по указанному пути, с заданным источником для частей.</summary>
		/// <param name="path">Путь к каталогу, в котором выполняется поиск сборок, добавляемых в каталог.  
		/// Необходимо указать абсолютный путь или путь относительно каталога <see cref="P:System.AppDomain.BaseDirectory" />.</param>
		/// <param name="definitionOrigin">Элемент, используемый средствами диагностики для определения источника для частей.</param>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный <paramref name="path" /> недопустим (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> является строкой нулевой длины, содержит только пробелы или содержит один или несколько недопустимых в данной реализации символов.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный параметр <paramref name="path" />, имя файла или и то и другое превышает наибольшую возможную длину, определенную системой.</exception>
		// Token: 0x0600059C RID: 1436 RVA: 0x00011082 File Offset: 0x0000F282
		public DirectoryCatalog(string path, ICompositionElement definitionOrigin) : this(path, "*.dll", definitionOrigin)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" /> с помощью объектов <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartDefinition" />, основанных на всех DLL-файлах, расположеных по указанному пути, в указанном контексте отражения.</summary>
		/// <param name="path">Путь к каталогу, в котором выполняется поиск сборок, добавляемых в каталог.  
		/// Необходимо указать абсолютный путь или путь относительно каталога <see cref="P:System.AppDomain.BaseDirectory" />.</param>
		/// <param name="reflectionContext">Контекст, используемый для создания частей.</param>
		/// <param name="definitionOrigin">Элемент, используемый средствами диагностики для определения источника для частей.</param>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный <paramref name="path" /> недопустим (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> является строкой нулевой длины, содержит только пробелы или содержит один или несколько недопустимых в данной реализации символов.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный параметр <paramref name="path" />, имя файла или и то и другое превышает наибольшую возможную длину, определенную системой.</exception>
		// Token: 0x0600059D RID: 1437 RVA: 0x00011091 File Offset: 0x0000F291
		public DirectoryCatalog(string path, ReflectionContext reflectionContext, ICompositionElement definitionOrigin) : this(path, "*.dll", reflectionContext, definitionOrigin)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" /> с помощью объектов <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartDefinition" />, которые соответствуют заданному шаблону поиска в каталоге, расположенном по указанному пути.</summary>
		/// <param name="path">Путь к каталогу, в котором выполняется поиск сборок, добавляемых в каталог.  
		/// Необходимо указать абсолютный путь или путь относительно каталога <see cref="P:System.AppDomain.BaseDirectory" />.</param>
		/// <param name="searchPattern">Строка поиска. Формат этой строки должен совпадать с форматом, указанным для метода <see cref="M:System.IO.Directory.GetFiles(System.String,System.String)" />.</param>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный <paramref name="path" /> недопустим (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> или <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> является строкой нулевой длины, содержит только пробелы или содержит один или несколько недопустимых в данной реализации символов.  
		///
		/// или - 
		/// <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный параметр <paramref name="path" />, имя файла или и то и другое превышает наибольшую возможную длину, определенную системой.</exception>
		// Token: 0x0600059E RID: 1438 RVA: 0x000110A1 File Offset: 0x0000F2A1
		public DirectoryCatalog(string path, string searchPattern)
		{
			this._thisLock = new Lock();
			base..ctor();
			Requires.NotNullOrEmpty(path, "path");
			Requires.NotNullOrEmpty(searchPattern, "searchPattern");
			this._definitionOrigin = this;
			this.Initialize(path, searchPattern);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" /> с помощью объектов <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartDefinition" />, основанных на заданном шаблоне поиска в каталоге, расположенном по указанному пути, с заданным источником для частей.</summary>
		/// <param name="path">Путь к каталогу, в котором выполняется поиск сборок, добавляемых в каталог.  
		/// Необходимо указать абсолютный путь или путь относительно каталога <see cref="P:System.AppDomain.BaseDirectory" />.</param>
		/// <param name="searchPattern">Строка поиска. Формат этой строки должен совпадать с форматом, указанным для метода <see cref="M:System.IO.Directory.GetFiles(System.String,System.String)" />.</param>
		/// <param name="definitionOrigin">Элемент, используемый средствами диагностики для определения источника для частей.</param>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный <paramref name="path" /> недопустим (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> или <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> является строкой нулевой длины, содержит только пробелы или содержит один или несколько недопустимых в данной реализации символов.  
		///
		/// или - 
		/// <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный параметр <paramref name="path" />, имя файла или и то и другое превышает наибольшую возможную длину, определенную системой.</exception>
		// Token: 0x0600059F RID: 1439 RVA: 0x000110DC File Offset: 0x0000F2DC
		public DirectoryCatalog(string path, string searchPattern, ICompositionElement definitionOrigin)
		{
			this._thisLock = new Lock();
			base..ctor();
			Requires.NotNullOrEmpty(path, "path");
			Requires.NotNullOrEmpty(searchPattern, "searchPattern");
			Requires.NotNull<ICompositionElement>(definitionOrigin, "definitionOrigin");
			this._definitionOrigin = definitionOrigin;
			this.Initialize(path, searchPattern);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" /> с помощью объектов <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartDefinition" />, основанных на заданном шаблоне поиска в каталоге, расположенном по указанному пути, используя заданный контекст отражения.</summary>
		/// <param name="path">Путь к каталогу, в котором выполняется поиск сборок, добавляемых в каталог.  
		/// Необходимо указать абсолютный путь или путь относительно каталога <see cref="P:System.AppDomain.BaseDirectory" />.</param>
		/// <param name="searchPattern">Строка поиска. Формат этой строки должен совпадать с форматом, указанным для метода <see cref="M:System.IO.Directory.GetFiles(System.String,System.String)" />.</param>
		/// <param name="reflectionContext">Контекст, используемый для создания частей.</param>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный <paramref name="path" /> недопустим (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> или <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> является строкой нулевой длины, содержит только пробелы или содержит один или несколько недопустимых в данной реализации символов.  
		///
		/// или - 
		/// <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный параметр <paramref name="path" />, имя файла или и то и другое превышает наибольшую возможную длину, определенную системой.</exception>
		// Token: 0x060005A0 RID: 1440 RVA: 0x0001112C File Offset: 0x0000F32C
		public DirectoryCatalog(string path, string searchPattern, ReflectionContext reflectionContext)
		{
			this._thisLock = new Lock();
			base..ctor();
			Requires.NotNullOrEmpty(path, "path");
			Requires.NotNullOrEmpty(searchPattern, "searchPattern");
			Requires.NotNull<ReflectionContext>(reflectionContext, "reflectionContext");
			this._reflectionContext = reflectionContext;
			this._definitionOrigin = this;
			this.Initialize(path, searchPattern);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" /> с помощью объектов <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartDefinition" />, основанных на заданном шаблоне поиска в каталоге, расположенном по указанному пути, используя заданный контекст отражения.</summary>
		/// <param name="path">Путь к каталогу, в котором выполняется поиск сборок, добавляемых в каталог.  
		/// Необходимо указать абсолютный путь или путь относительно каталога <see cref="P:System.AppDomain.BaseDirectory" />.</param>
		/// <param name="searchPattern">Строка поиска. Формат этой строки должен совпадать с форматом, указанным для метода <see cref="M:System.IO.Directory.GetFiles(System.String,System.String)" />.</param>
		/// <param name="reflectionContext">Контекст, используемый для создания частей.</param>
		/// <param name="definitionOrigin">Элемент, используемый средствами диагностики для определения источника для частей.</param>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Указанный <paramref name="path" /> недопустим (например, он соответствует неподключенному диску).</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="path" /> или <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> является строкой нулевой длины, содержит только пробелы или содержит один или несколько недопустимых в данной реализации символов.  
		///
		/// или - 
		/// <paramref name="searchPattern" /> не содержит допустимый шаблон.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный параметр <paramref name="path" />, имя файла или и то и другое превышает наибольшую возможную длину, определенную системой.</exception>
		// Token: 0x060005A1 RID: 1441 RVA: 0x00011184 File Offset: 0x0000F384
		public DirectoryCatalog(string path, string searchPattern, ReflectionContext reflectionContext, ICompositionElement definitionOrigin)
		{
			this._thisLock = new Lock();
			base..ctor();
			Requires.NotNullOrEmpty(path, "path");
			Requires.NotNullOrEmpty(searchPattern, "searchPattern");
			Requires.NotNull<ReflectionContext>(reflectionContext, "reflectionContext");
			Requires.NotNull<ICompositionElement>(definitionOrigin, "definitionOrigin");
			this._reflectionContext = reflectionContext;
			this._definitionOrigin = definitionOrigin;
			this.Initialize(path, searchPattern);
		}

		/// <summary>Получает преобразованный абсолютный путь, используемый объектом <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" />.</summary>
		/// <returns>Преобразованный абсолютный путь, используемый каталогом.</returns>
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x000111E6 File Offset: 0x0000F3E6
		public string FullPath
		{
			get
			{
				return this._fullPath;
			}
		}

		/// <summary>Получает коллекцию файлов, которые в настоящий момент загружены в каталог.</summary>
		/// <returns>Коллекция файлов, которые в настоящий момент загружены в каталог.</returns>
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x000111F0 File Offset: 0x0000F3F0
		public ReadOnlyCollection<string> LoadedFiles
		{
			get
			{
				ReadOnlyCollection<string> loadedFiles;
				using (new ReadLock(this._thisLock))
				{
					loadedFiles = this._loadedFiles;
				}
				return loadedFiles;
			}
		}

		/// <summary>Получает путь, используемый объектом <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" />.</summary>
		/// <returns>Путь, используемый каталогом.</returns>
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00011234 File Offset: 0x0000F434
		public string Path
		{
			get
			{
				return this._path;
			}
		}

		/// <summary>Получает шаблон поиска, переданный конструктору объекта <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" />.</summary>
		/// <returns>Шаблон поиска, используемый каталогом для поиска файлов. Значение по умолчанию — *.dll, возвращающее все DLL-файлы.</returns>
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0001123C File Offset: 0x0000F43C
		public string SearchPattern
		{
			get
			{
				return this._searchPattern;
			}
		}

		/// <summary>Происходит в результате изменения содержимого каталога.</summary>
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060005A6 RID: 1446 RVA: 0x00011244 File Offset: 0x0000F444
		// (remove) Token: 0x060005A7 RID: 1447 RVA: 0x0001127C File Offset: 0x0000F47C
		public event EventHandler<ComposablePartCatalogChangeEventArgs> Changed;

		/// <summary>Происходит при изменении каталога.</summary>
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060005A8 RID: 1448 RVA: 0x000112B4 File Offset: 0x0000F4B4
		// (remove) Token: 0x060005A9 RID: 1449 RVA: 0x000112EC File Offset: 0x0000F4EC
		public event EventHandler<ComposablePartCatalogChangeEventArgs> Changing;

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x060005AA RID: 1450 RVA: 0x00011324 File Offset: 0x0000F524
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && !this._isDisposed)
				{
					bool flag = false;
					ComposablePartCatalogCollection composablePartCatalogCollection = null;
					try
					{
						using (new WriteLock(this._thisLock))
						{
							if (!this._isDisposed)
							{
								flag = true;
								composablePartCatalogCollection = this._catalogCollection;
								this._catalogCollection = null;
								this._assemblyCatalogs = null;
								this._isDisposed = true;
							}
						}
					}
					finally
					{
						if (composablePartCatalogCollection != null)
						{
							composablePartCatalogCollection.Dispose();
						}
						if (flag)
						{
							this._thisLock.Dispose();
						}
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		/// <summary>Возвращает перечислитель, выполняющий итерацию каталога.</summary>
		/// <returns>Перечислитель, который может использоваться для выполнения итерации каталога.</returns>
		// Token: 0x060005AB RID: 1451 RVA: 0x000113D4 File Offset: 0x0000F5D4
		public override IEnumerator<ComposablePartDefinition> GetEnumerator()
		{
			return this._catalogCollection.SelectMany((ComposablePartCatalog catalog) => catalog).GetEnumerator();
		}

		/// <summary>Получает определения экспортов, которые соответствуют ограничению, выраженному указанным определением импорта.</summary>
		/// <param name="definition">Условия, при которых возвращаются объекты <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" />.</param>
		/// <returns>Коллекция объектов, содержащих объекты <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" /> и связанные с ними объекты <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartDefinition" />, которые соответствуют ограничениям, заданным параметром <paramref name="definition" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.DirectoryCatalog" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="definition" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060005AC RID: 1452 RVA: 0x00011408 File Offset: 0x0000F608
		public override IEnumerable<Tuple<ComposablePartDefinition, ExportDefinition>> GetExports(ImportDefinition definition)
		{
			this.ThrowIfDisposed();
			Requires.NotNull<ImportDefinition>(definition, "definition");
			return this._catalogCollection.SelectMany((ComposablePartCatalog catalog) => catalog.GetExports(definition));
		}

		/// <summary>Вызывает событие <see cref="E:System.ComponentModel.Composition.Hosting.DirectoryCatalog.Changed" />.</summary>
		/// <param name="e">Объект, содержащий данные о событии.</param>
		// Token: 0x060005AD RID: 1453 RVA: 0x00011450 File Offset: 0x0000F650
		protected virtual void OnChanged(ComposablePartCatalogChangeEventArgs e)
		{
			EventHandler<ComposablePartCatalogChangeEventArgs> changed = this.Changed;
			if (changed != null)
			{
				changed(this, e);
			}
		}

		/// <summary>Вызывает событие <see cref="E:System.ComponentModel.Composition.Hosting.DirectoryCatalog.Changing" />.</summary>
		/// <param name="e">Объект, содержащий данные о событии.</param>
		// Token: 0x060005AE RID: 1454 RVA: 0x00011470 File Offset: 0x0000F670
		protected virtual void OnChanging(ComposablePartCatalogChangeEventArgs e)
		{
			EventHandler<ComposablePartCatalogChangeEventArgs> changing = this.Changing;
			if (changing != null)
			{
				changing(this, e);
			}
		}

		/// <summary>Обновляет объекты <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartDefinition" /> последними файлами из каталога, соответствующими шаблону поиска.</summary>
		// Token: 0x060005AF RID: 1455 RVA: 0x00011490 File Offset: 0x0000F690
		public void Refresh()
		{
			this.ThrowIfDisposed();
			Assumes.NotNull<ReadOnlyCollection<string>>(this._loadedFiles);
			ComposablePartDefinition[] addedDefinitions;
			ComposablePartDefinition[] removedDefinitions;
			for (;;)
			{
				string[] files = this.GetFiles();
				object loadedFiles;
				string[] beforeFiles;
				using (new ReadLock(this._thisLock))
				{
					loadedFiles = this._loadedFiles;
					beforeFiles = this._loadedFiles.ToArray<string>();
				}
				List<Tuple<string, AssemblyCatalog>> list;
				List<Tuple<string, AssemblyCatalog>> list2;
				this.DiffChanges(beforeFiles, files, out list, out list2);
				if (list.Count == 0 && list2.Count == 0)
				{
					break;
				}
				addedDefinitions = list.SelectMany((Tuple<string, AssemblyCatalog> cat) => cat.Item2).ToArray<ComposablePartDefinition>();
				removedDefinitions = list2.SelectMany((Tuple<string, AssemblyCatalog> cat) => cat.Item2).ToArray<ComposablePartDefinition>();
				using (AtomicComposition atomicComposition = new AtomicComposition())
				{
					ComposablePartCatalogChangeEventArgs e = new ComposablePartCatalogChangeEventArgs(addedDefinitions, removedDefinitions, atomicComposition);
					this.OnChanging(e);
					using (new WriteLock(this._thisLock))
					{
						if (loadedFiles != this._loadedFiles)
						{
							continue;
						}
						foreach (Tuple<string, AssemblyCatalog> tuple in list)
						{
							this._assemblyCatalogs.Add(tuple.Item1, tuple.Item2);
							this._catalogCollection.Add(tuple.Item2);
						}
						foreach (Tuple<string, AssemblyCatalog> tuple2 in list2)
						{
							this._assemblyCatalogs.Remove(tuple2.Item1);
							this._catalogCollection.Remove(tuple2.Item2);
						}
						this._loadedFiles = files.ToReadOnlyCollection<string>();
						atomicComposition.Complete();
					}
				}
				goto IL_1CF;
			}
			return;
			IL_1CF:
			ComposablePartCatalogChangeEventArgs e2 = new ComposablePartCatalogChangeEventArgs(addedDefinitions, removedDefinitions, null);
			this.OnChanged(e2);
		}

		/// <summary>Получает строковое представление каталога каталогов.</summary>
		/// <returns>Строковое представление каталога.</returns>
		// Token: 0x060005B0 RID: 1456 RVA: 0x000116C0 File Offset: 0x0000F8C0
		public override string ToString()
		{
			return this.GetDisplayName();
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000116C8 File Offset: 0x0000F8C8
		private AssemblyCatalog CreateAssemblyCatalogGuarded(string assemblyFilePath)
		{
			Exception exception = null;
			try
			{
				return (this._reflectionContext != null) ? new AssemblyCatalog(assemblyFilePath, this._reflectionContext, this) : new AssemblyCatalog(assemblyFilePath, this);
			}
			catch (FileNotFoundException exception)
			{
			}
			catch (FileLoadException exception)
			{
			}
			catch (BadImageFormatException exception)
			{
			}
			catch (ReflectionTypeLoadException exception)
			{
			}
			CompositionTrace.AssemblyLoadFailed(this, assemblyFilePath, exception);
			return null;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00011744 File Offset: 0x0000F944
		private void DiffChanges(string[] beforeFiles, string[] afterFiles, out List<Tuple<string, AssemblyCatalog>> catalogsToAdd, out List<Tuple<string, AssemblyCatalog>> catalogsToRemove)
		{
			catalogsToAdd = new List<Tuple<string, AssemblyCatalog>>();
			catalogsToRemove = new List<Tuple<string, AssemblyCatalog>>();
			foreach (string text in afterFiles.Except(beforeFiles))
			{
				AssemblyCatalog assemblyCatalog = this.CreateAssemblyCatalogGuarded(text);
				if (assemblyCatalog != null)
				{
					catalogsToAdd.Add(new Tuple<string, AssemblyCatalog>(text, assemblyCatalog));
				}
			}
			IEnumerable<string> enumerable = beforeFiles.Except(afterFiles);
			using (new ReadLock(this._thisLock))
			{
				foreach (string text2 in enumerable)
				{
					AssemblyCatalog item;
					if (this._assemblyCatalogs.TryGetValue(text2, out item))
					{
						catalogsToRemove.Add(new Tuple<string, AssemblyCatalog>(text2, item));
					}
				}
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00011838 File Offset: 0x0000FA38
		private string GetDisplayName()
		{
			return string.Format(CultureInfo.CurrentCulture, "{0} (Path=\"{1}\")", base.GetType().Name, this._path);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0001185A File Offset: 0x0000FA5A
		private string[] GetFiles()
		{
			return Directory.GetFiles(this._fullPath, this._searchPattern);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0001186D File Offset: 0x0000FA6D
		private static string GetFullPath(string path)
		{
			if (!System.IO.Path.IsPathRooted(path) && AppDomain.CurrentDomain.BaseDirectory != null)
			{
				path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
			}
			return System.IO.Path.GetFullPath(path);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0001189C File Offset: 0x0000FA9C
		private void Initialize(string path, string searchPattern)
		{
			this._path = path;
			this._fullPath = DirectoryCatalog.GetFullPath(path);
			this._searchPattern = searchPattern;
			this._assemblyCatalogs = new Dictionary<string, AssemblyCatalog>();
			this._catalogCollection = new ComposablePartCatalogCollection(null, null, null);
			this._loadedFiles = this.GetFiles().ToReadOnlyCollection<string>();
			foreach (string text in this._loadedFiles)
			{
				AssemblyCatalog assemblyCatalog = this.CreateAssemblyCatalogGuarded(text);
				if (assemblyCatalog != null)
				{
					this._assemblyCatalogs.Add(text, assemblyCatalog);
					this._catalogCollection.Add(assemblyCatalog);
				}
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0001194C File Offset: 0x0000FB4C
		[DebuggerStepThrough]
		private void ThrowIfDisposed()
		{
			if (this._isDisposed)
			{
				throw ExceptionBuilder.CreateObjectDisposed(this);
			}
		}

		/// <summary>Получает отображаемое имя каталога каталогов.</summary>
		/// <returns>Строка, содержащая доступное для чтения отображаемое имя каталога каталогов.</returns>
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x000116C0 File Offset: 0x0000F8C0
		string ICompositionElement.DisplayName
		{
			get
			{
				return this.GetDisplayName();
			}
		}

		/// <summary>Получает элемент композиции, от которого происходит данный каталог каталогов.</summary>
		/// <returns>Всегда <see langword="null" />.</returns>
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0000AD5C File Offset: 0x00008F5C
		ICompositionElement ICompositionElement.Origin
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400026C RID: 620
		private readonly Lock _thisLock;

		// Token: 0x0400026D RID: 621
		private readonly ICompositionElement _definitionOrigin;

		// Token: 0x0400026E RID: 622
		private ComposablePartCatalogCollection _catalogCollection;

		// Token: 0x0400026F RID: 623
		private Dictionary<string, AssemblyCatalog> _assemblyCatalogs;

		// Token: 0x04000270 RID: 624
		private volatile bool _isDisposed;

		// Token: 0x04000271 RID: 625
		private string _path;

		// Token: 0x04000272 RID: 626
		private string _fullPath;

		// Token: 0x04000273 RID: 627
		private string _searchPattern;

		// Token: 0x04000274 RID: 628
		private ReadOnlyCollection<string> _loadedFiles;

		// Token: 0x04000275 RID: 629
		private readonly ReflectionContext _reflectionContext;

		// Token: 0x020000DA RID: 218
		internal class DirectoryCatalogDebuggerProxy
		{
			// Token: 0x060005BA RID: 1466 RVA: 0x0001195F File Offset: 0x0000FB5F
			public DirectoryCatalogDebuggerProxy(DirectoryCatalog catalog)
			{
				Requires.NotNull<DirectoryCatalog>(catalog, "catalog");
				this._catalog = catalog;
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x060005BB RID: 1467 RVA: 0x00011979 File Offset: 0x0000FB79
			public ReadOnlyCollection<Assembly> Assemblies
			{
				get
				{
					return (from catalog in this._catalog._assemblyCatalogs.Values
					select catalog.Assembly).ToReadOnlyCollection<Assembly>();
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x060005BC RID: 1468 RVA: 0x000119B4 File Offset: 0x0000FBB4
			public ReflectionContext ReflectionContext
			{
				get
				{
					return this._catalog._reflectionContext;
				}
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x060005BD RID: 1469 RVA: 0x000119C1 File Offset: 0x0000FBC1
			public string SearchPattern
			{
				get
				{
					return this._catalog.SearchPattern;
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x060005BE RID: 1470 RVA: 0x000119CE File Offset: 0x0000FBCE
			public string Path
			{
				get
				{
					return this._catalog._path;
				}
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x060005BF RID: 1471 RVA: 0x000119DB File Offset: 0x0000FBDB
			public string FullPath
			{
				get
				{
					return this._catalog._fullPath;
				}
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x060005C0 RID: 1472 RVA: 0x000119E8 File Offset: 0x0000FBE8
			public ReadOnlyCollection<string> LoadedFiles
			{
				get
				{
					return this._catalog._loadedFiles;
				}
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x060005C1 RID: 1473 RVA: 0x000119F5 File Offset: 0x0000FBF5
			public ReadOnlyCollection<ComposablePartDefinition> Parts
			{
				get
				{
					return this._catalog.Parts.ToReadOnlyCollection<ComposablePartDefinition>();
				}
			}

			// Token: 0x04000278 RID: 632
			private readonly DirectoryCatalog _catalog;
		}
	}
}
