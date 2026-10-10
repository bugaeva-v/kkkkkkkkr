using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.AttributedModel;
using System.ComponentModel.Composition.Primitives;
using System.ComponentModel.Composition.ReflectionModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using Microsoft.Internal;
using Microsoft.Internal.Collections;

namespace System.ComponentModel.Composition.Hosting
{
	/// <summary>Обнаруживает части с атрибутами из коллекции типов.</summary>
	// Token: 0x020000F9 RID: 249
	[DebuggerTypeProxy(typeof(ComposablePartCatalogDebuggerProxy))]
	public class TypeCatalog : ComposablePartCatalog, ICompositionElement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.TypeCatalog" /> указанными типами.</summary>
		/// <param name="types">Массив помеченных атрибутами объектов <see cref="T:System.Type" /> для добавления в объект <see cref="T:System.ComponentModel.Composition.Hosting.TypeCatalog" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="types" /> содержит элемент, равный <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="types" /> содержит элемент, который был загружен в контекст только для отражения.</exception>
		// Token: 0x0600068C RID: 1676 RVA: 0x00014441 File Offset: 0x00012641
		public TypeCatalog(params Type[] types) : this(types)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.TypeCatalog" /> указанными типами.</summary>
		/// <param name="types">Коллекция помеченных атрибутами объектов <see cref="T:System.Type" />, добавляемых в объект <see cref="T:System.ComponentModel.Composition.Hosting.TypeCatalog" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="types" /> содержит элемент, равный <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="types" /> содержит элемент, который был загружен в контекст только для отражения.</exception>
		// Token: 0x0600068D RID: 1677 RVA: 0x0001444C File Offset: 0x0001264C
		public TypeCatalog(IEnumerable<Type> types)
		{
			this._thisLock = new object();
			base..ctor();
			Requires.NotNull<IEnumerable<Type>>(types, "types");
			this.InitializeTypeCatalog(types);
			this._definitionOrigin = this;
			this._contractPartIndex = new Lazy<IDictionary<string, List<ComposablePartDefinition>>>(new Func<IDictionary<string, List<ComposablePartDefinition>>>(this.CreateIndex), true);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.TypeCatalog" /> с указанными типами и источником для частей.</summary>
		/// <param name="types">Коллекция помеченных атрибутами объектов <see cref="T:System.Type" />, добавляемых в объект <see cref="T:System.ComponentModel.Composition.Hosting.TypeCatalog" />.</param>
		/// <param name="definitionOrigin">Элемент, используемый средствами диагностики для определения источника для частей.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="types" /> содержит элемент, равный <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="types" /> содержит элемент, который был загружен в контекст только для отражения.</exception>
		// Token: 0x0600068E RID: 1678 RVA: 0x0001449C File Offset: 0x0001269C
		public TypeCatalog(IEnumerable<Type> types, ICompositionElement definitionOrigin)
		{
			this._thisLock = new object();
			base..ctor();
			Requires.NotNull<IEnumerable<Type>>(types, "types");
			Requires.NotNull<ICompositionElement>(definitionOrigin, "definitionOrigin");
			this.InitializeTypeCatalog(types);
			this._definitionOrigin = definitionOrigin;
			this._contractPartIndex = new Lazy<IDictionary<string, List<ComposablePartDefinition>>>(new Func<IDictionary<string, List<ComposablePartDefinition>>>(this.CreateIndex), true);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.TypeCatalog" /> указанными типами в указанном контексте отражения.</summary>
		/// <param name="types">Коллекция помеченных атрибутами объектов <see cref="T:System.Type" />, добавляемых в объект <see cref="T:System.ComponentModel.Composition.Hosting.TypeCatalog" />.</param>
		/// <param name="reflectionContext">Контекст, используемый для интерпретации типов.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="types" /> содержит элемент, равный <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="types" /> содержит элемент, который был загружен в контекст только для отражения.</exception>
		// Token: 0x0600068F RID: 1679 RVA: 0x000144F8 File Offset: 0x000126F8
		public TypeCatalog(IEnumerable<Type> types, ReflectionContext reflectionContext)
		{
			this._thisLock = new object();
			base..ctor();
			Requires.NotNull<IEnumerable<Type>>(types, "types");
			Requires.NotNull<ReflectionContext>(reflectionContext, "reflectionContext");
			this.InitializeTypeCatalog(types, reflectionContext);
			this._definitionOrigin = this;
			this._contractPartIndex = new Lazy<IDictionary<string, List<ComposablePartDefinition>>>(new Func<IDictionary<string, List<ComposablePartDefinition>>>(this.CreateIndex), true);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.TypeCatalog" /> указанными типами в указанном контексте отражения и источником для частей.</summary>
		/// <param name="types">Коллекция помеченных атрибутами объектов <see cref="T:System.Type" />, добавляемых в объект <see cref="T:System.ComponentModel.Composition.Hosting.TypeCatalog" />.</param>
		/// <param name="reflectionContext">Контекст, используемый для интерпретации типов.</param>
		/// <param name="definitionOrigin">Элемент, используемый средствами диагностики для определения источника для частей.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="types" /> содержит элемент, равный <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="types" /> содержит элемент, который был загружен в контекст только для отражения.</exception>
		// Token: 0x06000690 RID: 1680 RVA: 0x00014554 File Offset: 0x00012754
		public TypeCatalog(IEnumerable<Type> types, ReflectionContext reflectionContext, ICompositionElement definitionOrigin)
		{
			this._thisLock = new object();
			base..ctor();
			Requires.NotNull<IEnumerable<Type>>(types, "types");
			Requires.NotNull<ReflectionContext>(reflectionContext, "reflectionContext");
			Requires.NotNull<ICompositionElement>(definitionOrigin, "definitionOrigin");
			this.InitializeTypeCatalog(types, reflectionContext);
			this._definitionOrigin = definitionOrigin;
			this._contractPartIndex = new Lazy<IDictionary<string, List<ComposablePartDefinition>>>(new Func<IDictionary<string, List<ComposablePartDefinition>>>(this.CreateIndex), true);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000145BC File Offset: 0x000127BC
		private void InitializeTypeCatalog(IEnumerable<Type> types, ReflectionContext reflectionContext)
		{
			List<Type> list = new List<Type>();
			foreach (Type type in types)
			{
				if (type == null)
				{
					throw ExceptionBuilder.CreateContainsNullElement("types");
				}
				if (type.Assembly.ReflectionOnly)
				{
					throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.Argument_ElementReflectionOnlyType, "types"), "types");
				}
				TypeInfo typeInfo = type.GetTypeInfo();
				TypeInfo typeInfo2 = (reflectionContext != null) ? reflectionContext.MapType(typeInfo) : typeInfo;
				if (typeInfo2 != null)
				{
					if (typeInfo2.Assembly.ReflectionOnly)
					{
						throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.Argument_ReflectionContextReturnsReflectionOnlyType, "reflectionContext"), "reflectionContext");
					}
					list.Add(typeInfo2);
				}
			}
			this._types = list.ToArray();
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000146A4 File Offset: 0x000128A4
		private void InitializeTypeCatalog(IEnumerable<Type> types)
		{
			using (IEnumerator<Type> enumerator = types.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == null)
					{
						throw ExceptionBuilder.CreateContainsNullElement("types");
					}
				}
			}
			this._types = types.ToArray<Type>();
		}

		/// <summary>Возвращает перечислитель, выполняющий итерацию каталога.</summary>
		/// <returns>Перечислитель, который может использоваться для выполнения итерации каталога.</returns>
		// Token: 0x06000693 RID: 1683 RVA: 0x00014704 File Offset: 0x00012904
		public override IEnumerator<ComposablePartDefinition> GetEnumerator()
		{
			this.ThrowIfDisposed();
			return this.PartsInternal.GetEnumerator();
		}

		/// <summary>Получает отображаемое имя каталога типов.</summary>
		/// <returns>Строка, содержащая доступное для чтения отображаемое имя каталога <see cref="T:System.ComponentModel.Composition.Hosting.TypeCatalog" />.</returns>
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00014717 File Offset: 0x00012917
		string ICompositionElement.DisplayName
		{
			get
			{
				return this.GetDisplayName();
			}
		}

		/// <summary>Получает элемент композиции, от которого происходит данный каталог типов.</summary>
		/// <returns>Всегда <see langword="null" />.</returns>
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x0000AD5C File Offset: 0x00008F5C
		ICompositionElement ICompositionElement.Origin
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00014720 File Offset: 0x00012920
		private IEnumerable<ComposablePartDefinition> PartsInternal
		{
			get
			{
				if (this._parts == null)
				{
					object thisLock = this._thisLock;
					lock (thisLock)
					{
						if (this._parts == null)
						{
							Assumes.NotNull<Type[]>(this._types);
							List<ComposablePartDefinition> list = new List<ComposablePartDefinition>();
							Type[] types = this._types;
							for (int i = 0; i < types.Length; i++)
							{
								ComposablePartDefinition composablePartDefinition = AttributedModelDiscovery.CreatePartDefinitionIfDiscoverable(types[i], this._definitionOrigin);
								if (composablePartDefinition != null)
								{
									list.Add(composablePartDefinition);
								}
							}
							Thread.MemoryBarrier();
							this._types = null;
							this._parts = list;
						}
					}
				}
				return this._parts;
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000147D8 File Offset: 0x000129D8
		internal override IEnumerable<ComposablePartDefinition> GetCandidateParts(ImportDefinition definition)
		{
			Assumes.NotNull<ImportDefinition>(definition);
			string contractName = definition.ContractName;
			if (string.IsNullOrEmpty(contractName))
			{
				return this.PartsInternal;
			}
			string value = definition.Metadata.GetValue("System.ComponentModel.Composition.GenericContractName");
			ICollection<ComposablePartDefinition> candidateParts = this.GetCandidateParts(contractName);
			List<ComposablePartDefinition> candidateParts2 = this.GetCandidateParts(value);
			return candidateParts.ConcatAllowingNull(candidateParts2);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00014828 File Offset: 0x00012A28
		private List<ComposablePartDefinition> GetCandidateParts(string contractName)
		{
			if (contractName == null)
			{
				return null;
			}
			List<ComposablePartDefinition> result = null;
			this._contractPartIndex.Value.TryGetValue(contractName, out result);
			return result;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00014854 File Offset: 0x00012A54
		private IDictionary<string, List<ComposablePartDefinition>> CreateIndex()
		{
			Dictionary<string, List<ComposablePartDefinition>> dictionary = new Dictionary<string, List<ComposablePartDefinition>>(StringComparers.ContractName);
			foreach (ComposablePartDefinition composablePartDefinition in this.PartsInternal)
			{
				foreach (string key in (from export in composablePartDefinition.ExportDefinitions
				select export.ContractName).Distinct<string>())
				{
					List<ComposablePartDefinition> list = null;
					if (!dictionary.TryGetValue(key, out list))
					{
						list = new List<ComposablePartDefinition>();
						dictionary.Add(key, list);
					}
					list.Add(composablePartDefinition);
				}
			}
			return dictionary;
		}

		/// <summary>Возвращает строковое представление каталога типов.</summary>
		/// <returns>Строковое представление каталога типов.</returns>
		// Token: 0x0600069A RID: 1690 RVA: 0x00014717 File Offset: 0x00012917
		public override string ToString()
		{
			return this.GetDisplayName();
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.ComponentModel.Composition.Hosting.TypeCatalog" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x0600069B RID: 1691 RVA: 0x00014934 File Offset: 0x00012B34
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this._isDisposed = true;
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00014949 File Offset: 0x00012B49
		private string GetDisplayName()
		{
			return string.Format(CultureInfo.CurrentCulture, Strings.TypeCatalog_DisplayNameFormat, base.GetType().Name, this.GetTypesDisplay());
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001496C File Offset: 0x00012B6C
		private string GetTypesDisplay()
		{
			int num = this.PartsInternal.Count<ComposablePartDefinition>();
			if (num == 0)
			{
				return Strings.TypeCatalog_Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (ComposablePartDefinition composablePartDefinition in this.PartsInternal.Take(2))
			{
				ReflectionComposablePartDefinition reflectionComposablePartDefinition = (ReflectionComposablePartDefinition)composablePartDefinition;
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
					stringBuilder.Append(" ");
				}
				stringBuilder.Append(reflectionComposablePartDefinition.GetPartType().GetDisplayName());
			}
			if (num > 2)
			{
				stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
				stringBuilder.Append(" ...");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00014A44 File Offset: 0x00012C44
		[DebuggerStepThrough]
		private void ThrowIfDisposed()
		{
			if (this._isDisposed)
			{
				throw ExceptionBuilder.CreateObjectDisposed(this);
			}
		}

		// Token: 0x040002CF RID: 719
		private readonly object _thisLock;

		// Token: 0x040002D0 RID: 720
		private Type[] _types;

		// Token: 0x040002D1 RID: 721
		private volatile List<ComposablePartDefinition> _parts;

		// Token: 0x040002D2 RID: 722
		private volatile bool _isDisposed;

		// Token: 0x040002D3 RID: 723
		private readonly ICompositionElement _definitionOrigin;

		// Token: 0x040002D4 RID: 724
		private readonly Lazy<IDictionary<string, List<ComposablePartDefinition>>> _contractPartIndex;
	}
}
