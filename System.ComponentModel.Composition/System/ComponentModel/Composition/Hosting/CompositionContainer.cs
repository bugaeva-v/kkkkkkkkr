using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition.Primitives;
using System.Diagnostics;
using System.Threading;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.Hosting
{
	/// <summary>Управляет композицией частей.</summary>
	// Token: 0x020000CC RID: 204
	public class CompositionContainer : ExportProvider, ICompositionService, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</summary>
		// Token: 0x06000530 RID: 1328 RVA: 0x0000F907 File Offset: 0x0000DB07
		public CompositionContainer() : this(null, Array.Empty<ExportProvider>())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> указанными поставщиками экспортов.</summary>
		/// <param name="providers">Массив объектов <see cref="T:System.ComponentModel.Composition.Hosting.ExportProvider" />, которые предоставляют объекту <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> доступ к объектам <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, или значение <see langword="null" />, чтобы задать для свойства <see cref="P:System.ComponentModel.Composition.Hosting.CompositionContainer.Providers" /> пустую коллекцию <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="providers" /> содержит элемент, равный <see langword="null" />.</exception>
		// Token: 0x06000531 RID: 1329 RVA: 0x0000F915 File Offset: 0x0000DB15
		public CompositionContainer(params ExportProvider[] providers) : this(null, providers)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> с указанными поставщиками экспортов и параметрами.</summary>
		/// <param name="compositionOptions">Объект, задающий поведение этого контейнера.</param>
		/// <param name="providers">Массив объектов <see cref="T:System.ComponentModel.Composition.Hosting.ExportProvider" />, которые предоставляют объекту <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> доступ к объектам <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, или значение <see langword="null" />, чтобы задать для свойства <see cref="P:System.ComponentModel.Composition.Hosting.CompositionContainer.Providers" /> пустую коллекцию <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="providers" /> содержит элемент, равный <see langword="null" />.</exception>
		// Token: 0x06000532 RID: 1330 RVA: 0x0000F91F File Offset: 0x0000DB1F
		public CompositionContainer(CompositionOptions compositionOptions, params ExportProvider[] providers) : this(null, compositionOptions, providers)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> указанными каталогом и поставщиками экспортов.</summary>
		/// <param name="catalog">Каталог, предоставляющий объекты <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> объекту <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</param>
		/// <param name="providers">Массив объектов <see cref="T:System.ComponentModel.Composition.Hosting.ExportProvider" />, которые предоставляют объекту <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> доступ к объектам <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, или значение <see langword="null" />, чтобы задать для свойства <see cref="P:System.ComponentModel.Composition.Hosting.CompositionContainer.Providers" /> пустую коллекцию <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="providers" /> содержит элемент, равный <see langword="null" />.</exception>
		// Token: 0x06000533 RID: 1331 RVA: 0x0000F92A File Offset: 0x0000DB2A
		public CompositionContainer(ComposablePartCatalog catalog, params ExportProvider[] providers) : this(catalog, false, providers)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> указанными каталогом, потокобезопасным режимом и поставщиками экспорта.</summary>
		/// <param name="catalog">Каталог, предоставляющий объекты <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> объекту <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</param>
		/// <param name="isThreadSafe">Значение <see langword="true" />, если данный объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> должен быть потокобезопасным; в противном случае — значение <see langword="false" />.</param>
		/// <param name="providers">Массив объектов <see cref="T:System.ComponentModel.Composition.Hosting.ExportProvider" />, которые предоставляют объекту <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> доступ к объектам <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, или значение <see langword="null" />, чтобы задать для свойства <see cref="P:System.ComponentModel.Composition.Hosting.CompositionContainer.Providers" /> пустую коллекцию <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</param>
		/// <exception cref="T:System.ArgumentException">Один или несколько элементов <paramref name="providers" /> имеют значение <see langword="null" />.</exception>
		// Token: 0x06000534 RID: 1332 RVA: 0x0000F935 File Offset: 0x0000DB35
		public CompositionContainer(ComposablePartCatalog catalog, bool isThreadSafe, params ExportProvider[] providers) : this(catalog, isThreadSafe ? CompositionOptions.IsThreadSafe : CompositionOptions.Default, providers)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> с указанным каталогом, параметрами и поставщиками экспортов.</summary>
		/// <param name="catalog">Каталог, предоставляющий объекты <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> объекту <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</param>
		/// <param name="compositionOptions">Объект, задающий параметры, которые воздействуют на поведение контейнера.</param>
		/// <param name="providers">Массив объектов <see cref="T:System.ComponentModel.Composition.Hosting.ExportProvider" />, которые предоставляют объекту <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> доступ к объектам <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, или значение <see langword="null" />, чтобы задать для свойства <see cref="P:System.ComponentModel.Composition.Hosting.CompositionContainer.Providers" /> пустую коллекцию <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="providers" /> содержит элемент, равный <see langword="null" />.</exception>
		// Token: 0x06000535 RID: 1333 RVA: 0x0000F948 File Offset: 0x0000DB48
		public CompositionContainer(ComposablePartCatalog catalog, CompositionOptions compositionOptions, params ExportProvider[] providers)
		{
			if (compositionOptions > (CompositionOptions.DisableSilentRejection | CompositionOptions.IsThreadSafe | CompositionOptions.ExportCompositionService))
			{
				throw new ArgumentOutOfRangeException("compositionOptions");
			}
			this._compositionOptions = compositionOptions;
			this._partExportProvider = new ComposablePartExportProvider(compositionOptions);
			this._partExportProvider.SourceProvider = this;
			if (catalog != null || providers.Length != 0)
			{
				if (catalog != null)
				{
					this._catalogExportProvider = new CatalogExportProvider(catalog, compositionOptions);
					this._catalogExportProvider.SourceProvider = this;
					this._localExportProvider = new AggregateExportProvider(new ExportProvider[]
					{
						this._partExportProvider,
						this._catalogExportProvider
					});
				}
				else
				{
					this._localExportProvider = new AggregateExportProvider(new ExportProvider[]
					{
						this._partExportProvider
					});
				}
				if (providers != null && providers.Length != 0)
				{
					this._ancestorExportProvider = new AggregateExportProvider(providers);
					this._rootProvider = new AggregateExportProvider(new ExportProvider[]
					{
						this._localExportProvider,
						this._ancestorExportProvider
					});
				}
				else
				{
					this._rootProvider = this._localExportProvider;
				}
			}
			else
			{
				this._rootProvider = this._partExportProvider;
			}
			if (compositionOptions.HasFlag(CompositionOptions.ExportCompositionService))
			{
				this.ComposeExportedValue(new CompositionContainer.CompositionServiceShim(this));
			}
			this._rootProvider.ExportsChanged += this.OnExportsChangedInternal;
			this._rootProvider.ExportsChanging += this.OnExportsChangingInternal;
			this._providers = ((providers != null) ? new ReadOnlyCollection<ExportProvider>((ExportProvider[])providers.Clone()) : CompositionContainer.EmptyProviders);
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0000FABE File Offset: 0x0000DCBE
		internal CompositionOptions CompositionOptions
		{
			get
			{
				this.ThrowIfDisposed();
				return this._compositionOptions;
			}
		}

		/// <summary>Получает объект <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartCatalog" />, который предоставляет контейнеру доступ к объектам <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</summary>
		/// <returns>Каталог, который предоставляет объекту <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> доступ к экспортам, созданным объектами <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" />. Значение по умолчанию: <see langword="null" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0000FACC File Offset: 0x0000DCCC
		public ComposablePartCatalog Catalog
		{
			get
			{
				this.ThrowIfDisposed();
				if (this._catalogExportProvider == null)
				{
					return null;
				}
				return this._catalogExportProvider.Catalog;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0000FAE9 File Offset: 0x0000DCE9
		internal CatalogExportProvider CatalogExportProvider
		{
			get
			{
				this.ThrowIfDisposed();
				return this._catalogExportProvider;
			}
		}

		/// <summary>Получает поставщики экспортов, которые предоставляют контейнеру доступ к дополнительным объектам <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartCatalog" />.</summary>
		/// <returns>Коллекция объектов <see cref="T:System.ComponentModel.Composition.Hosting.ExportProvider" />, которые предоставляют объекту <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> доступ к дополнительным объектам <see cref="T:System.ComponentModel.Composition.Primitives.Export" />. Значение по умолчанию — пустой объект <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> удален.</exception>
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0000FAF7 File Offset: 0x0000DCF7
		public ReadOnlyCollection<ExportProvider> Providers
		{
			get
			{
				this.ThrowIfDisposed();
				return this._providers;
			}
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</summary>
		// Token: 0x0600053A RID: 1338 RVA: 0x0000FB05 File Offset: 0x0000DD05
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x0600053B RID: 1339 RVA: 0x0000FB14 File Offset: 0x0000DD14
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !this._isDisposed)
			{
				ExportProvider exportProvider = null;
				AggregateExportProvider aggregateExportProvider = null;
				AggregateExportProvider aggregateExportProvider2 = null;
				ComposablePartExportProvider composablePartExportProvider = null;
				CatalogExportProvider catalogExportProvider = null;
				ImportEngine importEngine = null;
				object @lock = this._lock;
				lock (@lock)
				{
					if (!this._isDisposed)
					{
						exportProvider = this._rootProvider;
						this._rootProvider = null;
						aggregateExportProvider2 = this._localExportProvider;
						this._localExportProvider = null;
						aggregateExportProvider = this._ancestorExportProvider;
						this._ancestorExportProvider = null;
						composablePartExportProvider = this._partExportProvider;
						this._partExportProvider = null;
						catalogExportProvider = this._catalogExportProvider;
						this._catalogExportProvider = null;
						importEngine = this._importEngine;
						this._importEngine = null;
						this._isDisposed = true;
					}
				}
				if (exportProvider != null)
				{
					exportProvider.ExportsChanged -= this.OnExportsChangedInternal;
					exportProvider.ExportsChanging -= this.OnExportsChangingInternal;
				}
				if (aggregateExportProvider != null)
				{
					aggregateExportProvider.Dispose();
				}
				if (aggregateExportProvider2 != null)
				{
					aggregateExportProvider2.Dispose();
				}
				if (catalogExportProvider != null)
				{
					catalogExportProvider.Dispose();
				}
				if (composablePartExportProvider != null)
				{
					composablePartExportProvider.Dispose();
				}
				if (importEngine != null)
				{
					importEngine.Dispose();
				}
			}
		}

		/// <summary>Добавляет в контейнер или удаляет из контейнера части, содержащиеся в указанном объекте <see cref="T:System.ComponentModel.Composition.Hosting.CompositionBatch" />, и выполняет композицию.</summary>
		/// <param name="batch">Изменения объекта <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />, которые должны быть включены в композицию.</param>
		// Token: 0x0600053C RID: 1340 RVA: 0x0000FC38 File Offset: 0x0000DE38
		public void Compose(CompositionBatch batch)
		{
			Requires.NotNull<CompositionBatch>(batch, "batch");
			this.ThrowIfDisposed();
			this._partExportProvider.Compose(batch);
		}

		/// <summary>Освобождает указанный объект <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> из объекта <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</summary>
		/// <param name="export">Объект <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, который необходимо освободить.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="export" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600053D RID: 1341 RVA: 0x0000FC58 File Offset: 0x0000DE58
		public void ReleaseExport(Export export)
		{
			Requires.NotNull<Export>(export, "export");
			IDisposable disposable = export as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		/// <summary>Удаляет указанный экспорт из композиции и освобождает занятые им ресурсы, если это возможно.</summary>
		/// <param name="export">Косвенная ссылка на удаляемый экспорт.</param>
		/// <typeparam name="T">Тип экспорта.</typeparam>
		// Token: 0x0600053E RID: 1342 RVA: 0x0000FC80 File Offset: 0x0000DE80
		public void ReleaseExport<T>(Lazy<T> export)
		{
			Requires.NotNull<Lazy<T>>(export, "export");
			IDisposable disposable = export as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		/// <summary>Освобождает набор объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> из объекта <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</summary>
		/// <param name="exports">Коллекция объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, которые необходимо освободить.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="exports" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="exports" /> содержит элемент, равный <see langword="null" />.</exception>
		// Token: 0x0600053F RID: 1343 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		public void ReleaseExports(IEnumerable<Export> exports)
		{
			Requires.NotNullOrNullElements<Export>(exports, "exports");
			foreach (Export export in exports)
			{
				this.ReleaseExport(export);
			}
		}

		/// <summary>Удаляет коллекцию экспортов из композиции и освобождает занятые ими ресурсы, если это возможно.</summary>
		/// <param name="exports">Коллекция косвенных ссылок на удаляемые экспорты.</param>
		/// <typeparam name="T">Тип экспортов.</typeparam>
		// Token: 0x06000540 RID: 1344 RVA: 0x0000FCFC File Offset: 0x0000DEFC
		public void ReleaseExports<T>(IEnumerable<Lazy<T>> exports)
		{
			Requires.NotNullOrNullElements<Lazy<T>>(exports, "exports");
			foreach (Lazy<T> export in exports)
			{
				this.ReleaseExport<T>(export);
			}
		}

		/// <summary>Удаляет коллекцию экспортов из композиции и освобождает занятые ими ресурсы, если это возможно.</summary>
		/// <param name="exports">Коллекция косвенных ссылок на удаляемые экспорты и их метаданные.</param>
		/// <typeparam name="T">Тип экспортов.</typeparam>
		/// <typeparam name="TMetadataView">Тип представления метаданных экспортов.</typeparam>
		// Token: 0x06000541 RID: 1345 RVA: 0x0000FD50 File Offset: 0x0000DF50
		public void ReleaseExports<T, TMetadataView>(IEnumerable<Lazy<T, TMetadataView>> exports)
		{
			Requires.NotNullOrNullElements<Lazy<T, TMetadataView>>(exports, "exports");
			foreach (Lazy<T, TMetadataView> export in exports)
			{
				this.ReleaseExport<T>(export);
			}
		}

		/// <summary>Удовлетворяет импорты указанного объекта <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" /> без его регистрации для рекомпозиции.</summary>
		/// <param name="part">Часть, импорты которой удовлетворяются.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="part" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionException">Произошла ошибка при композиции. Свойство <see cref="P:System.ComponentModel.Composition.CompositionException.Errors" /> будет содержать коллекцию произошедших ошибок.</exception>
		// Token: 0x06000542 RID: 1346 RVA: 0x0000FDA4 File Offset: 0x0000DFA4
		public void SatisfyImportsOnce(ComposablePart part)
		{
			this.ThrowIfDisposed();
			if (this._importEngine == null)
			{
				ImportEngine importEngine = new ImportEngine(this, this._compositionOptions);
				object @lock = this._lock;
				lock (@lock)
				{
					if (this._importEngine == null)
					{
						Thread.MemoryBarrier();
						this._importEngine = importEngine;
						importEngine = null;
					}
				}
				if (importEngine != null)
				{
					importEngine.Dispose();
				}
			}
			this._importEngine.SatisfyImportsOnce(part);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000BD10 File Offset: 0x00009F10
		internal void OnExportsChangedInternal(object sender, ExportsChangeEventArgs e)
		{
			this.OnExportsChanged(e);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0000BD19 File Offset: 0x00009F19
		internal void OnExportsChangingInternal(object sender, ExportsChangeEventArgs e)
		{
			this.OnExportsChanging(e);
		}

		/// <summary>Возвращает коллекцию всех экспортов, которые соответствуют условиям в указанном объекте <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.</summary>
		/// <param name="definition">Объект, определяющий условия получаемых объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</param>
		/// <param name="atomicComposition">Используемая транзакция композиции или значение <see langword="null" /> для отключения транзакционной композиции.</param>
		/// <returns>Коллекция всех объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> в данном объекте <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />, которые соответствуют условиям, заданным параметром <paramref name="definition" />.</returns>
		// Token: 0x06000545 RID: 1349 RVA: 0x0000FE24 File Offset: 0x0000E024
		protected override IEnumerable<Export> GetExportsCore(ImportDefinition definition, AtomicComposition atomicComposition)
		{
			this.ThrowIfDisposed();
			IEnumerable<Export> result = null;
			object obj;
			if (!definition.Metadata.TryGetValue("System.ComponentModel.Composition.ImportSource", out obj))
			{
				obj = ImportSource.Any;
			}
			switch ((ImportSource)obj)
			{
			case ImportSource.Any:
				Assumes.NotNull<ExportProvider>(this._rootProvider);
				this._rootProvider.TryGetExports(definition, atomicComposition, out result);
				break;
			case ImportSource.Local:
				Assumes.NotNull<AggregateExportProvider>(this._localExportProvider);
				this._localExportProvider.TryGetExports(definition.RemoveImportSource(), atomicComposition, out result);
				break;
			case ImportSource.NonLocal:
				if (this._ancestorExportProvider != null)
				{
					this._ancestorExportProvider.TryGetExports(definition.RemoveImportSource(), atomicComposition, out result);
				}
				break;
			}
			return result;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0000FECC File Offset: 0x0000E0CC
		[DebuggerStepThrough]
		private void ThrowIfDisposed()
		{
			if (this._isDisposed)
			{
				throw ExceptionBuilder.CreateObjectDisposed(this);
			}
		}

		// Token: 0x0400023B RID: 571
		private CompositionOptions _compositionOptions;

		// Token: 0x0400023C RID: 572
		private ImportEngine _importEngine;

		// Token: 0x0400023D RID: 573
		private ComposablePartExportProvider _partExportProvider;

		// Token: 0x0400023E RID: 574
		private ExportProvider _rootProvider;

		// Token: 0x0400023F RID: 575
		private CatalogExportProvider _catalogExportProvider;

		// Token: 0x04000240 RID: 576
		private AggregateExportProvider _localExportProvider;

		// Token: 0x04000241 RID: 577
		private AggregateExportProvider _ancestorExportProvider;

		// Token: 0x04000242 RID: 578
		private readonly ReadOnlyCollection<ExportProvider> _providers;

		// Token: 0x04000243 RID: 579
		private volatile bool _isDisposed;

		// Token: 0x04000244 RID: 580
		private object _lock = new object();

		// Token: 0x04000245 RID: 581
		private static ReadOnlyCollection<ExportProvider> EmptyProviders = new ReadOnlyCollection<ExportProvider>(new ExportProvider[0]);

		// Token: 0x020000CD RID: 205
		private class CompositionServiceShim : ICompositionService
		{
			// Token: 0x06000548 RID: 1352 RVA: 0x0000FEF1 File Offset: 0x0000E0F1
			public CompositionServiceShim(CompositionContainer innerContainer)
			{
				Assumes.NotNull<CompositionContainer>(innerContainer);
				this._innerContainer = innerContainer;
			}

			// Token: 0x06000549 RID: 1353 RVA: 0x0000FF06 File Offset: 0x0000E106
			void ICompositionService.SatisfyImportsOnce(ComposablePart part)
			{
				this._innerContainer.SatisfyImportsOnce(part);
			}

			// Token: 0x04000246 RID: 582
			private CompositionContainer _innerContainer;
		}
	}
}
