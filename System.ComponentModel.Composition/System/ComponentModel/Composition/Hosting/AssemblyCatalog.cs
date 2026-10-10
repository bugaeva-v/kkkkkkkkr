using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Threading;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.Hosting
{
	/// <summary>Обнаруживает атрибутивные фрагменты в сборке управляемого кода.</summary>
	// Token: 0x020000A1 RID: 161
	[DebuggerTypeProxy(typeof(AssemblyCatalogDebuggerProxy))]
	public class AssemblyCatalog : ComposablePartCatalog, ICompositionElement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" /> указанной базой кода.</summary>
		/// <param name="codeBase">Строка, указывающая базу кода сборки (то есть путь к файлу сборки), содержащую атрибутированные объекты <see cref="T:System.Type" /> для добавления к объекту <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" />.</param>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="codeBase" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена версия 2.0 среды CLR или более ранняя версия, а параметр <paramref name="codeBase" /> был скомпилирован в более поздней версии.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение на обнаружение пути.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить <paramref name="codeBase" />.  
		///
		/// или - 
		/// <paramref name="codeBase" /> задает каталог.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="codeBase" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="codeBase" /> не найден.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="codeBase" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x0600043F RID: 1087 RVA: 0x0000C033 File Offset: 0x0000A233
		public AssemblyCatalog(string codeBase)
		{
			Requires.NotNullOrEmpty(codeBase, "codeBase");
			this.InitializeAssemblyCatalog(AssemblyCatalog.LoadAssembly(codeBase));
			this._definitionOrigin = this;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" /> с указанными базой кода и контекстом отражения.</summary>
		/// <param name="codeBase">Строка, указывающая базу кода сборки (то есть путь к файлу сборки), содержащую атрибутированные объекты <see cref="T:System.Type" /> для добавления к объекту <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" />.</param>
		/// <param name="reflectionContext">Контекст, используемый каталогом для интерпретации типов.</param>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="codeBase" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="codeBase" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение на обнаружение пути.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить <paramref name="codeBase" />.  
		///
		/// или - 
		/// <paramref name="codeBase" /> задает каталог.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="codebase" /> или <paramref name="reflectionContext" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="codeBase" /> не найден.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="codeBase" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x06000440 RID: 1088 RVA: 0x0000C064 File Offset: 0x0000A264
		public AssemblyCatalog(string codeBase, ReflectionContext reflectionContext)
		{
			Requires.NotNullOrEmpty(codeBase, "codeBase");
			Requires.NotNull<ReflectionContext>(reflectionContext, "reflectionContext");
			this.InitializeAssemblyCatalog(AssemblyCatalog.LoadAssembly(codeBase));
			this._reflectionContext = reflectionContext;
			this._definitionOrigin = this;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" /> указанной базой кода.</summary>
		/// <param name="codeBase">Строка, указывающая базу кода сборки (то есть путь к файлу сборки), содержащую атрибутированные объекты <see cref="T:System.Type" /> для добавления к объекту <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" />.</param>
		/// <param name="definitionOrigin">Элемент, используемый средствами диагностики для определения источников частей.</param>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="codeBase" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="codeBase" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение на обнаружение пути.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить <paramref name="codeBase" />.  
		///
		/// или - 
		/// <paramref name="codeBase" /> задает каталог.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="codebase" /> или <paramref name="definitionOrigin" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="codeBase" /> не найден.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="codeBase" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x06000441 RID: 1089 RVA: 0x0000C0B2 File Offset: 0x0000A2B2
		public AssemblyCatalog(string codeBase, ICompositionElement definitionOrigin)
		{
			Requires.NotNullOrEmpty(codeBase, "codeBase");
			Requires.NotNull<ICompositionElement>(definitionOrigin, "definitionOrigin");
			this.InitializeAssemblyCatalog(AssemblyCatalog.LoadAssembly(codeBase));
			this._definitionOrigin = definitionOrigin;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" /> с указанными базой кода и контекстом отражения.</summary>
		/// <param name="codeBase">Строка, указывающая базу кода сборки (то есть путь к файлу сборки), содержащую атрибутированные объекты <see cref="T:System.Type" /> для добавления к объекту <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" />.</param>
		/// <param name="reflectionContext">Контекст, используемый каталогом для интерпретации типов.</param>
		/// <param name="definitionOrigin">Элемент, используемый средствами диагностики для определения источников частей.</param>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="codeBase" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="codeBase" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение на обнаружение пути.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Не удалось загрузить <paramref name="codeBase" />.  
		///
		/// или - 
		/// <paramref name="codeBase" /> задает каталог.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="codebase" />, <paramref name="definitionOrigin" /> или <paramref name="reflectionContext" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="codeBase" /> не найден.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="codeBase" /> представляет собой строку нулевой длины, содержащую только пробелы или один или несколько недопустимых символов, заданных методом <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		// Token: 0x06000442 RID: 1090 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		public AssemblyCatalog(string codeBase, ReflectionContext reflectionContext, ICompositionElement definitionOrigin)
		{
			Requires.NotNullOrEmpty(codeBase, "codeBase");
			Requires.NotNull<ReflectionContext>(reflectionContext, "reflectionContext");
			Requires.NotNull<ICompositionElement>(definitionOrigin, "definitionOrigin");
			this.InitializeAssemblyCatalog(AssemblyCatalog.LoadAssembly(codeBase));
			this._reflectionContext = reflectionContext;
			this._definitionOrigin = definitionOrigin;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" /> с указанной сборкой и контекстом отражения.</summary>
		/// <param name="assembly">Сборка, содержащая помеченные атрибутами объекты <see cref="T:System.Type" />, добавляемые в объект <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" />.</param>
		/// <param name="reflectionContext">Контекст, используемый каталогом для интерпретации типов.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assembly" /> или <paramref name="reflectionContext" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Сборка <paramref name="assembly" /> была загружена в контекст только для отражения.</exception>
		// Token: 0x06000443 RID: 1091 RVA: 0x0000C149 File Offset: 0x0000A349
		public AssemblyCatalog(Assembly assembly, ReflectionContext reflectionContext)
		{
			Requires.NotNull<Assembly>(assembly, "assembly");
			Requires.NotNull<ReflectionContext>(reflectionContext, "reflectionContext");
			this.InitializeAssemblyCatalog(assembly);
			this._reflectionContext = reflectionContext;
			this._definitionOrigin = this;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" /> с указанной сборкой и контекстом отражения.</summary>
		/// <param name="assembly">Сборка, содержащая помеченные атрибутами объекты <see cref="T:System.Type" />, добавляемые в объект <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" />.</param>
		/// <param name="reflectionContext">Контекст, используемый каталогом для интерпретации типов.</param>
		/// <param name="definitionOrigin">Элемент, используемый средствами диагностики для определения источников частей.</param>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="assembly" />, <paramref name="definitionOrigin" /> или <paramref name="reflectionContext" /> равно <see langword="null" />.  
		///
		/// или - 
		/// Сборка <paramref name="assembly" /> была загружена в контекст только для отражения.</exception>
		// Token: 0x06000444 RID: 1092 RVA: 0x0000C188 File Offset: 0x0000A388
		public AssemblyCatalog(Assembly assembly, ReflectionContext reflectionContext, ICompositionElement definitionOrigin)
		{
			Requires.NotNull<Assembly>(assembly, "assembly");
			Requires.NotNull<ReflectionContext>(reflectionContext, "reflectionContext");
			Requires.NotNull<ICompositionElement>(definitionOrigin, "definitionOrigin");
			this.InitializeAssemblyCatalog(assembly);
			this._reflectionContext = reflectionContext;
			this._definitionOrigin = definitionOrigin;
		}

		/// <summary>Инициализирует указанный экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" /> заданной сборкой.</summary>
		/// <param name="assembly">Сборка, содержащая помеченные атрибутами объекты <see cref="T:System.Type" />, добавляемые в объект <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" />.</param>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="assembly" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Сборка <paramref name="assembly" /> была загружена в контекст только для отражения.</exception>
		// Token: 0x06000445 RID: 1093 RVA: 0x0000C1DC File Offset: 0x0000A3DC
		public AssemblyCatalog(Assembly assembly)
		{
			Requires.NotNull<Assembly>(assembly, "assembly");
			this.InitializeAssemblyCatalog(assembly);
			this._definitionOrigin = this;
		}

		/// <summary>Инициализирует указанный экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" /> заданной сборкой.</summary>
		/// <param name="assembly">Сборка, содержащая помеченные атрибутами объекты <see cref="T:System.Type" />, добавляемые в объект <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" />.</param>
		/// <param name="definitionOrigin">Элемент, используемый средствами диагностики для определения источников частей.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assembly" /> или <paramref name="definitionOrigin" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Сборка <paramref name="assembly" /> была загружена в контекст только для отражения.</exception>
		// Token: 0x06000446 RID: 1094 RVA: 0x0000C208 File Offset: 0x0000A408
		public AssemblyCatalog(Assembly assembly, ICompositionElement definitionOrigin)
		{
			Requires.NotNull<Assembly>(assembly, "assembly");
			Requires.NotNull<ICompositionElement>(definitionOrigin, "definitionOrigin");
			this.InitializeAssemblyCatalog(assembly);
			this._definitionOrigin = definitionOrigin;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000C23F File Offset: 0x0000A43F
		private void InitializeAssemblyCatalog(Assembly assembly)
		{
			this._assembly = assembly;
		}

		/// <summary>Получает коллекцию экспортов, которые соответствуют условиям, заданным определением импорта.</summary>
		/// <param name="definition">Условия, которые определяют соответствующие экспорты.</param>
		/// <returns>Коллекция экспортов, которые соответствуют условиям, заданным параметром <paramref name="definition" />.</returns>
		// Token: 0x06000448 RID: 1096 RVA: 0x0000C24A File Offset: 0x0000A44A
		public override IEnumerable<Tuple<ComposablePartDefinition, ExportDefinition>> GetExports(ImportDefinition definition)
		{
			return this.InnerCatalog.GetExports(definition);
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0000C258 File Offset: 0x0000A458
		private ComposablePartCatalog InnerCatalog
		{
			get
			{
				this.ThrowIfDisposed();
				if (this._innerCatalog == null)
				{
					CatalogReflectionContextAttribute firstAttribute = this._assembly.GetFirstAttribute<CatalogReflectionContextAttribute>();
					Assembly assembly = (firstAttribute != null) ? firstAttribute.CreateReflectionContext().MapAssembly(this._assembly) : this._assembly;
					object thisLock = this._thisLock;
					lock (thisLock)
					{
						if (this._innerCatalog == null)
						{
							TypeCatalog innerCatalog = (this._reflectionContext != null) ? new TypeCatalog(assembly.GetTypes(), this._reflectionContext, this._definitionOrigin) : new TypeCatalog(assembly.GetTypes(), this._definitionOrigin);
							Thread.MemoryBarrier();
							this._innerCatalog = innerCatalog;
						}
					}
				}
				return this._innerCatalog;
			}
		}

		/// <summary>Получает сборку, помеченные атрибутами типы которой содержатся в каталоге сборки.</summary>
		/// <returns>Сборку, помеченные атрибутами объекты <see cref="T:System.Type" /> которой содержатся в объекте <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" />.</returns>
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0000C32C File Offset: 0x0000A52C
		public Assembly Assembly
		{
			get
			{
				return this._assembly;
			}
		}

		/// <summary>Получает отображаемое имя объекта <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" />.</summary>
		/// <returns>Строка, представляющая тип и сборку данного объекта <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" />.</returns>
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000C336 File Offset: 0x0000A536
		string ICompositionElement.DisplayName
		{
			get
			{
				return this.GetDisplayName();
			}
		}

		/// <summary>Получает элемент композиции, от которого происходит данный элемент.</summary>
		/// <returns>Всегда <see langword="null" />.</returns>
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000AD5C File Offset: 0x00008F5C
		ICompositionElement ICompositionElement.Origin
		{
			get
			{
				return null;
			}
		}

		/// <summary>Получает строковое представление каталога сборки.</summary>
		/// <returns>Строковое представление каталога сборки.</returns>
		// Token: 0x0600044D RID: 1101 RVA: 0x0000C336 File Offset: 0x0000A536
		public override string ToString()
		{
			return this.GetDisplayName();
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x0600044E RID: 1102 RVA: 0x0000C340 File Offset: 0x0000A540
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (Interlocked.CompareExchange(ref this._isDisposed, 1, 0) == 0 && disposing && this._innerCatalog != null)
				{
					this._innerCatalog.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		/// <summary>Возвращает перечислитель, выполняющий итерацию каталога.</summary>
		/// <returns>Перечислитель, который может использоваться для выполнения итерации каталога.</returns>
		// Token: 0x0600044F RID: 1103 RVA: 0x0000C390 File Offset: 0x0000A590
		public override IEnumerator<ComposablePartDefinition> GetEnumerator()
		{
			return this.InnerCatalog.GetEnumerator();
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000C39D File Offset: 0x0000A59D
		private void ThrowIfDisposed()
		{
			if (this._isDisposed == 1)
			{
				throw ExceptionBuilder.CreateObjectDisposed(this);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000C3AF File Offset: 0x0000A5AF
		private string GetDisplayName()
		{
			return string.Format(CultureInfo.CurrentCulture, "{0} (Assembly=\"{1}\")", base.GetType().Name, this.Assembly.FullName);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		private static Assembly LoadAssembly(string codeBase)
		{
			Requires.NotNullOrEmpty(codeBase, "codeBase");
			AssemblyName assemblyName;
			try
			{
				assemblyName = AssemblyName.GetAssemblyName(codeBase);
			}
			catch (ArgumentException)
			{
				assemblyName = new AssemblyName();
				assemblyName.CodeBase = codeBase;
			}
			return Assembly.Load(assemblyName);
		}

		// Token: 0x040001AB RID: 427
		private readonly object _thisLock = new object();

		// Token: 0x040001AC RID: 428
		private readonly ICompositionElement _definitionOrigin;

		// Token: 0x040001AD RID: 429
		private volatile Assembly _assembly;

		// Token: 0x040001AE RID: 430
		private volatile ComposablePartCatalog _innerCatalog;

		// Token: 0x040001AF RID: 431
		private int _isDisposed;

		// Token: 0x040001B0 RID: 432
		private ReflectionContext _reflectionContext;
	}
}
