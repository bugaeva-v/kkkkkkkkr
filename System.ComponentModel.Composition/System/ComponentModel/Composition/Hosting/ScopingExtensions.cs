using System;
using System.ComponentModel.Composition.Primitives;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.Hosting
{
	/// <summary>Определяет статические удобные методы для области действия.</summary>
	// Token: 0x020000F8 RID: 248
	public static class ScopingExtensions
	{
		/// <summary>Получает значение, указывающее, находятся ли указанные экспорты частей в пределах заданного контракта.</summary>
		/// <param name="part">Часть для поиска.</param>
		/// <param name="contractName">Имя контракта.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="part" /> экспортирует указанный контракт; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000686 RID: 1670 RVA: 0x0001423C File Offset: 0x0001243C
		public static bool Exports(this ComposablePartDefinition part, string contractName)
		{
			Requires.NotNull<ComposablePartDefinition>(part, "part");
			Requires.NotNull<string>(contractName, "contractName");
			foreach (ExportDefinition exportDefinition in part.ExportDefinitions)
			{
				if (StringComparers.ContractName.Equals(contractName, exportDefinition.ContractName))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Определяет, импортирует ли указанная часть указанный контракт</summary>
		/// <param name="part">Часть для поиска.</param>
		/// <param name="contractName">Имя контракта.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="part" /> импортирует указанный контракт; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000687 RID: 1671 RVA: 0x000142B4 File Offset: 0x000124B4
		public static bool Imports(this ComposablePartDefinition part, string contractName)
		{
			Requires.NotNull<ComposablePartDefinition>(part, "part");
			Requires.NotNull<string>(contractName, "contractName");
			foreach (ImportDefinition importDefinition in part.ImportDefinitions)
			{
				if (StringComparers.ContractName.Equals(contractName, importDefinition.ContractName))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Определяет, импортирует ли указанная часть указанный контракт с указанным количеством элементов.</summary>
		/// <param name="part">Часть для поиска.</param>
		/// <param name="contractName">Имя контракта.</param>
		/// <param name="importCardinality">Количество элементов контракта.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="part" /> импортирует контракт, который имеет указанные имя и количество элементов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000688 RID: 1672 RVA: 0x0001432C File Offset: 0x0001252C
		public static bool Imports(this ComposablePartDefinition part, string contractName, ImportCardinality importCardinality)
		{
			Requires.NotNull<ComposablePartDefinition>(part, "part");
			Requires.NotNull<string>(contractName, "contractName");
			foreach (ImportDefinition importDefinition in part.ImportDefinitions)
			{
				if (StringComparers.ContractName.Equals(contractName, importDefinition.ContractName) && importDefinition.Cardinality == importCardinality)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Получает значение, указывающее, содержит ли указанная часть метаданные, имеющие указанный ключ.</summary>
		/// <param name="part">Часть для поиска.</param>
		/// <param name="key">Ключ метаданных.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="part" /> содержит метаданные с указанным ключом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000689 RID: 1673 RVA: 0x000143AC File Offset: 0x000125AC
		public static bool ContainsPartMetadataWithKey(this ComposablePartDefinition part, string key)
		{
			Requires.NotNull<ComposablePartDefinition>(part, "part");
			Requires.NotNull<string>(key, "key");
			return part.Metadata.ContainsKey(key);
		}

		/// <summary>Получает значение, указывающее, содержит ли указанная часть метаданные, имеющие указанные ключ и значение.</summary>
		/// <param name="part">Часть для поиска.</param>
		/// <param name="key">Ключ метаданных.</param>
		/// <param name="value">Значение метаданных.</param>
		/// <typeparam name="T">Тип значения метаданных.</typeparam>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="part" /> содержит метаданные с указанными ключом, типом значения и значением; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600068A RID: 1674 RVA: 0x000143D0 File Offset: 0x000125D0
		public static bool ContainsPartMetadata<T>(this ComposablePartDefinition part, string key, T value)
		{
			Requires.NotNull<ComposablePartDefinition>(part, "part");
			Requires.NotNull<string>(key, "key");
			object obj = null;
			if (!part.Metadata.TryGetValue(key, out obj))
			{
				return false;
			}
			if (value == null)
			{
				return obj == null;
			}
			return value.Equals(obj);
		}

		/// <summary>Фильтрует указанный каталог с указанной функцией фильтра.</summary>
		/// <param name="catalog">Каталог, в котором следует выполнить фильтрацию.</param>
		/// <param name="filter">Функция фильтра.</param>
		/// <returns>Новый каталог отфильтрованный с помощью указанного фильтра.</returns>
		// Token: 0x0600068B RID: 1675 RVA: 0x00014422 File Offset: 0x00012622
		public static FilteredCatalog Filter(this ComposablePartCatalog catalog, Func<ComposablePartDefinition, bool> filter)
		{
			Requires.NotNull<ComposablePartCatalog>(catalog, "catalog");
			Requires.NotNull<Func<ComposablePartDefinition, bool>>(filter, "filter");
			return new FilteredCatalog(catalog, filter);
		}
	}
}
