using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition.Primitives;
using System.Globalization;
using System.Linq;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.Hosting
{
	/// <summary>Получает экспорты, соответствующие заданному объекту <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.</summary>
	// Token: 0x020000DE RID: 222
	public abstract class ExportProvider
	{
		/// <summary>Возвращает экспорт с именем контракта, производным от указанного параметра типа. В случае отсутствия ровно одного соответствующего экспорта создается исключение.</summary>
		/// <typeparam name="T">Параметр типа возвращаемого объекта <see cref="T:System.Lazy`1" />. Имя контракта также является производным от этого параметра типа.</typeparam>
		/// <returns>Экспорт с именем контракта, производным от указанного параметра типа.</returns>
		/// <exception cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException">Существует ноль объектов <see cref="T:System.Lazy`1" /> с именем контракта, являющимся производным <paramref name="T" />, в объекте <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.  
		///
		/// или - 
		/// Существует несколько объектов <see cref="T:System.Lazy`1" /> с именем контракта, являющимся производным <paramref name="T" />, в объекте <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		// Token: 0x060005CC RID: 1484 RVA: 0x00011A3D File Offset: 0x0000FC3D
		public Lazy<T> GetExport<T>()
		{
			return this.GetExport<T>(null);
		}

		/// <summary>Возвращает экспорт с указанным именем контракта. В случае отсутствия ровно одного соответствующего экспорта создается исключение.</summary>
		/// <param name="contractName">Имя контракта возвращаемого объекта <see cref="T:System.Lazy`1" /> либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		/// <typeparam name="T">Параметр типа возвращаемого объекта <see cref="T:System.Lazy`1" />.</typeparam>
		/// <returns>Экспорт с указанным именем контракта.</returns>
		/// <exception cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException">Существует ноль объектов <see cref="T:System.Lazy`1" /> с именем контракта, являющимся производным <paramref name="T" />, в объекте <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.  
		///
		/// или - 
		/// Существует несколько объектов <see cref="T:System.Lazy`1" /> с именем контракта, являющимся производным <paramref name="T" />, в объекте <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		// Token: 0x060005CD RID: 1485 RVA: 0x00011A46 File Offset: 0x0000FC46
		public Lazy<T> GetExport<T>(string contractName)
		{
			return this.GetExportCore<T>(contractName);
		}

		/// <summary>Возвращает экспорт с именем контракта, производным от указанного параметра типа. В случае отсутствия ровно одного соответствующего экспорта создается исключение.</summary>
		/// <typeparam name="T">Параметр типа возвращаемого объекта <see cref="T:System.Lazy`2" />. Имя контракта также является производным от этого параметра типа.</typeparam>
		/// <typeparam name="TMetadataView">Тип представления метаданных возвращаемого объекта <see cref="T:System.Lazy`2" />.</typeparam>
		/// <returns>System.Lazy`2</returns>
		/// <exception cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException">Существует ноль объектов <see cref="T:System.Lazy`2" /> с именем контракта, являющимся производным <paramref name="T" />, в объекте <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.  
		///
		/// или - 
		/// Существует несколько объектов <see cref="T:System.Lazy`2" /> с именем контракта, являющимся производным <paramref name="T" />, в объекте <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="TMetadataView" /> не является допустимым типом представления метаданных.</exception>
		// Token: 0x060005CE RID: 1486 RVA: 0x00011A4F File Offset: 0x0000FC4F
		public Lazy<T, TMetadataView> GetExport<T, TMetadataView>()
		{
			return this.GetExport<T, TMetadataView>(null);
		}

		/// <summary>Возвращает экспорт с указанным именем контракта. В случае отсутствия ровно одного соответствующего экспорта создается исключение.</summary>
		/// <param name="contractName">Имя контракта возвращаемого объекта <see cref="T:System.Lazy`2" /> либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		/// <typeparam name="T">Параметр типа возвращаемого объекта <see cref="T:System.Lazy`2" />.</typeparam>
		/// <typeparam name="TMetadataView">Тип представления метаданных возвращаемого объекта <see cref="T:System.Lazy`2" />.</typeparam>
		/// <returns>Экспорт с указанным именем контракта.</returns>
		/// <exception cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException">Существует ноль объектов <see cref="T:System.Lazy`2" /> с именем контракта, являющимся производным <paramref name="T" />, в объекте <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.  
		///
		/// или - 
		/// Существует несколько объектов <see cref="T:System.Lazy`2" /> с именем контракта, являющимся производным <paramref name="T" />, в объекте <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="TMetadataView" /> не является допустимым типом представления метаданных.</exception>
		// Token: 0x060005CF RID: 1487 RVA: 0x00011A58 File Offset: 0x0000FC58
		public Lazy<T, TMetadataView> GetExport<T, TMetadataView>(string contractName)
		{
			return this.GetExportCore<T, TMetadataView>(contractName);
		}

		/// <summary>Получает экспорты с указанным именем контракта.</summary>
		/// <param name="type">Параметр типа возвращаемых объектов <see cref="T:System.Lazy`2" />.</param>
		/// <param name="metadataViewType">Тип представления метаданных возвращаемых объектов <see cref="T:System.Lazy`2" />.</param>
		/// <param name="contractName">Имя контракта возвращаемого объекта <see cref="T:System.Lazy`2" /> либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		/// <returns>Коллекция всех объектов <see cref="T:System.Lazy`2" /> для контракта с именем <paramref name="contractName" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="metadataViewType" /> не является допустимым типом представления метаданных.</exception>
		// Token: 0x060005D0 RID: 1488 RVA: 0x00011A64 File Offset: 0x0000FC64
		public IEnumerable<Lazy<object, object>> GetExports(Type type, Type metadataViewType, string contractName)
		{
			IEnumerable<Export> exportsCore = this.GetExportsCore(type, metadataViewType, contractName, ImportCardinality.ZeroOrMore);
			Collection<Lazy<object, object>> collection = new Collection<Lazy<object, object>>();
			Func<Export, Lazy<object, object>> func = ExportServices.CreateSemiStronglyTypedLazyFactory(type, metadataViewType);
			foreach (Export arg in exportsCore)
			{
				collection.Add(func(arg));
			}
			return collection;
		}

		/// <summary>Получает все экспорты с именем контракта, производным от указанного параметра типа.</summary>
		/// <typeparam name="T">Параметр типа возвращаемых объектов <see cref="T:System.Lazy`1" />. Имя контракта также является производным от этого параметра типа.</typeparam>
		/// <returns>Объекты <see cref="T:System.Lazy`1" /> с именем контракта, производным от типа <paramref name="T" />, если оно найдено; в противном случае — пустой объект <see cref="T:System.Collections.Generic.IEnumerable`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		// Token: 0x060005D1 RID: 1489 RVA: 0x00011ACC File Offset: 0x0000FCCC
		public IEnumerable<Lazy<T>> GetExports<T>()
		{
			return this.GetExports<T>(null);
		}

		/// <summary>Получает экспорты с указанным именем контракта.</summary>
		/// <param name="contractName">Имя контракта возвращаемых объектов <see cref="T:System.Lazy`1" /> либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		/// <typeparam name="T">Параметр типа возвращаемых объектов <see cref="T:System.Lazy`1" />.</typeparam>
		/// <returns>Объекты <see cref="T:System.Lazy`1" /> с указанным именем контракта, если оно найдено; в противном случае — пустой объект <see cref="T:System.Collections.Generic.IEnumerable`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		// Token: 0x060005D2 RID: 1490 RVA: 0x00011AD5 File Offset: 0x0000FCD5
		public IEnumerable<Lazy<T>> GetExports<T>(string contractName)
		{
			return this.GetExportsCore<T>(contractName);
		}

		/// <summary>Получает все экспорты с именем контракта, производным от указанного параметра типа.</summary>
		/// <typeparam name="T">Параметр типа возвращаемых объектов <see cref="T:System.Lazy`2" />. Имя контракта также является производным от этого параметра типа.</typeparam>
		/// <typeparam name="TMetadataView">Тип представления метаданных возвращаемых объектов <see cref="T:System.Lazy`2" />.</typeparam>
		/// <returns>Объекты <see cref="T:System.Lazy`2" /> с именем контракта, производным от типа <paramref name="T" />, если оно найдено; в противном случае — пустой объект <see cref="T:System.Collections.Generic.IEnumerable`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="TMetadataView" /> не является допустимым типом представления метаданных.</exception>
		// Token: 0x060005D3 RID: 1491 RVA: 0x00011ADE File Offset: 0x0000FCDE
		public IEnumerable<Lazy<T, TMetadataView>> GetExports<T, TMetadataView>()
		{
			return this.GetExports<T, TMetadataView>(null);
		}

		/// <summary>Получает экспорты с указанным именем контракта.</summary>
		/// <param name="contractName">Имя контракта возвращаемых объектов <see cref="T:System.Lazy`2" /> либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		/// <typeparam name="T">Параметр типа возвращаемых объектов <see cref="T:System.Lazy`2" />. Имя контракта также является производным от этого параметра типа.</typeparam>
		/// <typeparam name="TMetadataView">Тип представления метаданных возвращаемых объектов <see cref="T:System.Lazy`2" />.</typeparam>
		/// <returns>Объекты <see cref="T:System.Lazy`2" /> с указанным именем контракта, если оно найдено; в противном случае — пустой объект <see cref="T:System.Collections.Generic.IEnumerable`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="TMetadataView" /> не является допустимым типом представления метаданных.</exception>
		// Token: 0x060005D4 RID: 1492 RVA: 0x00011AE7 File Offset: 0x0000FCE7
		public IEnumerable<Lazy<T, TMetadataView>> GetExports<T, TMetadataView>(string contractName)
		{
			return this.GetExportsCore<T, TMetadataView>(contractName);
		}

		/// <summary>Возвращает экспортированный объект с именем контракта, производным от указанного параметра типа. В случае отсутствия ровно одного соответствующего экспортированного объекта создается исключение.</summary>
		/// <typeparam name="T">Тип возвращаемого экспортированного объекта. Имя контракта также является производным от этого параметра типа.</typeparam>
		/// <returns>Экспортированный объект с именем контракта, производным от указанного параметра типа.</returns>
		/// <exception cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException">Имеются ноль экспортируемых объектов с именем контракта, являющимся производным <paramref name="T" />, в <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.  
		///
		/// или - 
		/// В контейнере <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> имеется несколько экспортированных объектов с именем контракта, являющимся производным типа <paramref name="T" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionContractMismatchException">Базовый экспортированный объект не может быть приведен к типу <paramref name="T" />.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionException">Произошла ошибка при композиции. <see cref="P:System.ComponentModel.Composition.CompositionException.Errors" /> будет содержать коллекцию произошедших ошибок.</exception>
		// Token: 0x060005D5 RID: 1493 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		public T GetExportedValue<T>()
		{
			return this.GetExportedValue<T>(null);
		}

		/// <summary>Возвращает экспортированный объект с указанным именем контракта. В случае отсутствия ровно одного соответствующего экспортированного объекта создается исключение.</summary>
		/// <param name="contractName">Имя контракта возвращаемого экспортированного объекта либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		/// <typeparam name="T">Тип возвращаемого экспортированного объекта.</typeparam>
		/// <returns>Экспортированный объект с указанным именем контракта.</returns>
		/// <exception cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException">Имеются ноль экспортируемых объектов с именем контракта, являющимся производным <paramref name="T" />, в <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.  
		///
		/// или - 
		/// В контейнере <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> имеется несколько экспортированных объектов с именем контракта, являющимся производным типа <paramref name="T" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionContractMismatchException">Базовый экспортированный объект не может быть приведен к типу <paramref name="T" />.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionException">Произошла ошибка при композиции. <see cref="P:System.ComponentModel.Composition.CompositionException.Errors" /> будет содержать коллекцию произошедших ошибок.</exception>
		// Token: 0x060005D6 RID: 1494 RVA: 0x00011AF9 File Offset: 0x0000FCF9
		public T GetExportedValue<T>(string contractName)
		{
			return this.GetExportedValueCore<T>(contractName, ImportCardinality.ExactlyOne);
		}

		/// <summary>Получает экспортированный объект с именем контракта, производным от указанного параметра типа, или значение по умолчанию для указанного типа. При наличии более одного соответствующего экспортированного объекта создается исключение.</summary>
		/// <typeparam name="T">Тип возвращаемого экспортированного объекта. Имя контракта также является производным от этого параметра типа.</typeparam>
		/// <returns>Экспортированный объект с именем контракта, производным от типа <paramref name="T" />, если оно найдено; в противном случае — значение по умолчанию для типа <paramref name="T" />.</returns>
		/// <exception cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException">В контейнере <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> имеется несколько экспортированных объектов с именем контракта, являющимся производным типа <paramref name="T" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionContractMismatchException">Базовый экспортированный объект не может быть приведен к типу <paramref name="T" />.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionException">Произошла ошибка при композиции. <see cref="P:System.ComponentModel.Composition.CompositionException.Errors" /> будет содержать коллекцию произошедших ошибок.</exception>
		// Token: 0x060005D7 RID: 1495 RVA: 0x00011B03 File Offset: 0x0000FD03
		public T GetExportedValueOrDefault<T>()
		{
			return this.GetExportedValueOrDefault<T>(null);
		}

		/// <summary>Получает экспортированный объект с заданным именем контракта или значение по умолчанию для указанного типа. При наличии более одного соответствующего экспортированного объекта создается исключение.</summary>
		/// <param name="contractName">Имя контракта возвращаемого экспортированного объекта либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		/// <typeparam name="T">Тип возвращаемого экспортированного объекта.</typeparam>
		/// <returns>Экспортированный объект с указанным именем контракта, если оно найдено; в противном случае — значение по умолчанию для типа <paramref name="T" />.</returns>
		/// <exception cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException">Существует несколько экспортируемых объектов с названием контракта, указанным в <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionContractMismatchException">Базовый экспортированный объект не может быть приведен к типу <paramref name="T" />.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionException">Произошла ошибка при композиции. <see cref="P:System.ComponentModel.Composition.CompositionException.Errors" /> будет содержать коллекцию произошедших ошибок.</exception>
		// Token: 0x060005D8 RID: 1496 RVA: 0x00011B0C File Offset: 0x0000FD0C
		public T GetExportedValueOrDefault<T>(string contractName)
		{
			return this.GetExportedValueCore<T>(contractName, ImportCardinality.ZeroOrOne);
		}

		/// <summary>Получает экспортированные объекты с именем контракта, производным от указанного параметра типа.</summary>
		/// <typeparam name="T">Тип возвращаемого экспортированного объекта. Имя контракта также является производным от этого параметра типа.</typeparam>
		/// <returns>Экспортированные объекты с именем контракта, производным от указанного типа, если оно найдено; в противном случае — пустой объект <see cref="T:System.Collections.ObjectModel.Collection`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionContractMismatchException">Один или несколько базовых экспортируемых объектов не могут быть приведены к <paramref name="T" />.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionException">Произошла ошибка при композиции. <see cref="P:System.ComponentModel.Composition.CompositionException.Errors" /> будет содержать коллекцию произошедших ошибок.</exception>
		// Token: 0x060005D9 RID: 1497 RVA: 0x00011B16 File Offset: 0x0000FD16
		public IEnumerable<T> GetExportedValues<T>()
		{
			return this.GetExportedValues<T>(null);
		}

		/// <summary>Получает экспортированные объекты с указанным именем контракта.</summary>
		/// <param name="contractName">Имя контракта возвращаемых экспортированных объектов либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		/// <typeparam name="T">Тип возвращаемого экспортированного объекта.</typeparam>
		/// <returns>Экспортированные объекты с указанным именем контракта, если оно найдено; в противном случае — пустой объект <see cref="T:System.Collections.ObjectModel.Collection`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> ликвидирован.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionContractMismatchException">Одно или несколько базовых экспортируемых значений не могут быть приведены к <paramref name="T" />.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.CompositionException">Произошла ошибка при композиции. <see cref="P:System.ComponentModel.Composition.CompositionException.Errors" /> будет содержать коллекцию произошедших ошибок.</exception>
		// Token: 0x060005DA RID: 1498 RVA: 0x00011B1F File Offset: 0x0000FD1F
		public IEnumerable<T> GetExportedValues<T>(string contractName)
		{
			return this.GetExportedValuesCore<T>(contractName);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00011B28 File Offset: 0x0000FD28
		private IEnumerable<T> GetExportedValuesCore<T>(string contractName)
		{
			IEnumerable<Export> exportsCore = this.GetExportsCore(typeof(T), null, contractName, ImportCardinality.ZeroOrMore);
			Collection<T> collection = new Collection<T>();
			foreach (Export export in exportsCore)
			{
				collection.Add(ExportServices.GetCastedExportedValue<T>(export));
			}
			return collection;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00011B90 File Offset: 0x0000FD90
		private T GetExportedValueCore<T>(string contractName, ImportCardinality cardinality)
		{
			Assumes.IsTrue(cardinality.IsAtMostOne());
			Export export = this.GetExportsCore(typeof(T), null, contractName, cardinality).SingleOrDefault<Export>();
			if (export == null)
			{
				return default(T);
			}
			return ExportServices.GetCastedExportedValue<T>(export);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00011BD4 File Offset: 0x0000FDD4
		private IEnumerable<Lazy<T>> GetExportsCore<T>(string contractName)
		{
			IEnumerable<Export> exportsCore = this.GetExportsCore(typeof(T), null, contractName, ImportCardinality.ZeroOrMore);
			Collection<Lazy<T>> collection = new Collection<Lazy<T>>();
			foreach (Export export in exportsCore)
			{
				collection.Add(ExportServices.CreateStronglyTypedLazyOfT<T>(export));
			}
			return collection;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00011C3C File Offset: 0x0000FE3C
		private IEnumerable<Lazy<T, TMetadataView>> GetExportsCore<T, TMetadataView>(string contractName)
		{
			IEnumerable<Export> exportsCore = this.GetExportsCore(typeof(T), typeof(TMetadataView), contractName, ImportCardinality.ZeroOrMore);
			Collection<Lazy<T, TMetadataView>> collection = new Collection<Lazy<T, TMetadataView>>();
			foreach (Export export in exportsCore)
			{
				collection.Add(ExportServices.CreateStronglyTypedLazyOfTM<T, TMetadataView>(export));
			}
			return collection;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00011CAC File Offset: 0x0000FEAC
		private Lazy<T, TMetadataView> GetExportCore<T, TMetadataView>(string contractName)
		{
			Export export = this.GetExportsCore(typeof(T), typeof(TMetadataView), contractName, ImportCardinality.ExactlyOne).SingleOrDefault<Export>();
			if (export == null)
			{
				return null;
			}
			return ExportServices.CreateStronglyTypedLazyOfTM<T, TMetadataView>(export);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		private Lazy<T> GetExportCore<T>(string contractName)
		{
			Export export = this.GetExportsCore(typeof(T), null, contractName, ImportCardinality.ExactlyOne).SingleOrDefault<Export>();
			if (export == null)
			{
				return null;
			}
			return ExportServices.CreateStronglyTypedLazyOfT<T>(export);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00011D1C File Offset: 0x0000FF1C
		private IEnumerable<Export> GetExportsCore(Type type, Type metadataViewType, string contractName, ImportCardinality cardinality)
		{
			Requires.NotNull<Type>(type, "type");
			if (string.IsNullOrEmpty(contractName))
			{
				contractName = AttributedModelServices.GetContractName(type);
			}
			if (metadataViewType == null)
			{
				metadataViewType = ExportServices.DefaultMetadataViewType;
			}
			if (!MetadataViewProvider.IsViewTypeValid(metadataViewType))
			{
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Strings.InvalidMetadataView, metadataViewType.Name));
			}
			ImportDefinition definition = ExportProvider.BuildImportDefinition(type, metadataViewType, contractName, cardinality);
			return this.GetExports(definition, null);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00011D8C File Offset: 0x0000FF8C
		private static ImportDefinition BuildImportDefinition(Type type, Type metadataViewType, string contractName, ImportCardinality cardinality)
		{
			Assumes.NotNull<Type, Type, string>(type, metadataViewType, contractName);
			IEnumerable<KeyValuePair<string, Type>> requiredMetadata = CompositionServices.GetRequiredMetadata(metadataViewType);
			IDictionary<string, object> importMetadata = CompositionServices.GetImportMetadata(type, null);
			string requiredTypeIdentity = null;
			if (type != typeof(object))
			{
				requiredTypeIdentity = AttributedModelServices.GetTypeIdentity(type);
			}
			return new ContractBasedImportDefinition(contractName, requiredTypeIdentity, requiredMetadata, cardinality, false, true, CreationPolicy.Any, importMetadata);
		}

		/// <summary>Происходит при изменении экспортов в объекте <see cref="T:System.ComponentModel.Composition.Hosting.ExportProvider" />.</summary>
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060005E4 RID: 1508 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		// (remove) Token: 0x060005E5 RID: 1509 RVA: 0x00011E10 File Offset: 0x00010010
		public event EventHandler<ExportsChangeEventArgs> ExportsChanged;

		/// <summary>Происходит при изменении предоставленных экспортов.</summary>
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060005E6 RID: 1510 RVA: 0x00011E48 File Offset: 0x00010048
		// (remove) Token: 0x060005E7 RID: 1511 RVA: 0x00011E80 File Offset: 0x00010080
		public event EventHandler<ExportsChangeEventArgs> ExportsChanging;

		/// <summary>Получает все экспорты, которые соответствуют условиям указанного определения импорта.</summary>
		/// <param name="definition">Объект, определяющий условия получаемых объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</param>
		/// <returns>Коллекция всех объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, соответствующих условию, определенному параметром <paramref name="definition" />.</returns>
		/// <exception cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException">Свойство <see cref="P:System.ComponentModel.Composition.Primitives.ImportDefinition.Cardinality" /> равно <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ExactlyOne" /> и имеется ноль объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, которые соответствуют условиям указанного <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.  
		///
		/// или - 
		/// Свойство <see cref="P:System.ComponentModel.Composition.Primitives.ImportDefinition.Cardinality" /> равно <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ZeroOrOne" /> или <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ExactlyOne" /> и имеется более одного объекта <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, который соответствует условиям указанного <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="definition" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060005E8 RID: 1512 RVA: 0x00011EB5 File Offset: 0x000100B5
		public IEnumerable<Export> GetExports(ImportDefinition definition)
		{
			return this.GetExports(definition, null);
		}

		/// <summary>Получает все экспорты, которые соответствуют условиям указанного определения импорта и композиции.</summary>
		/// <param name="definition">Объект, определяющий условия получаемых объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</param>
		/// <param name="atomicComposition">Транзакционный контейнер для композиции.</param>
		/// <returns>Коллекция всех объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, соответствующих условию, определенному параметрами <paramref name="definition" /> и <paramref name="atomicComposition" />.</returns>
		/// <exception cref="T:System.ComponentModel.Composition.ImportCardinalityMismatchException">Свойство <see cref="P:System.ComponentModel.Composition.Primitives.ImportDefinition.Cardinality" /> равно <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ExactlyOne" /> и имеется ноль объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, которые соответствуют условиям указанного <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.  
		///
		/// или - 
		/// Свойство <see cref="P:System.ComponentModel.Composition.Primitives.ImportDefinition.Cardinality" /> равно <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ZeroOrOne" /> или <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ExactlyOne" /> и имеется более одного объекта <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, который соответствует условиям указанного <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="definition" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="atomicComposition" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060005E9 RID: 1513 RVA: 0x00011EC0 File Offset: 0x000100C0
		public IEnumerable<Export> GetExports(ImportDefinition definition, AtomicComposition atomicComposition)
		{
			Requires.NotNull<ImportDefinition>(definition, "definition");
			IEnumerable<Export> result;
			ExportCardinalityCheckResult exportCardinalityCheckResult = this.TryGetExportsCore(definition, atomicComposition, out result);
			if (exportCardinalityCheckResult == ExportCardinalityCheckResult.Match)
			{
				return result;
			}
			if (exportCardinalityCheckResult != ExportCardinalityCheckResult.NoExports)
			{
				Assumes.IsTrue(exportCardinalityCheckResult == ExportCardinalityCheckResult.TooManyExports);
				throw new ImportCardinalityMismatchException(string.Format(CultureInfo.CurrentCulture, Strings.CardinalityMismatch_TooManyExports, definition.ToString()));
			}
			throw new ImportCardinalityMismatchException(string.Format(CultureInfo.CurrentCulture, Strings.CardinalityMismatch_NoExports, definition.ToString()));
		}

		/// <summary>Получает все элементы экспорта, которые соответствуют заданным параметрам импорта.</summary>
		/// <param name="definition">Объект, определяющий условия получаемых объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</param>
		/// <param name="atomicComposition">Транзакционный контейнер для композиции.</param>
		/// <param name="exports">При возвращении данного метода содержит коллекцию объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, соответствующих условиям, определенным объектом <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />, если эти объекты найдены; в противном случае — пустой объект <see cref="T:System.Collections.Generic.IEnumerable`1" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если значение свойства <see cref="P:System.ComponentModel.Composition.Primitives.ImportDefinition.Cardinality" /> равно <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ZeroOrOne" /> или <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ZeroOrMore" /> и имеется ноль объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, соответствующих условиям указанного определения <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />; значение <see langword="true" />, если значение свойства <see cref="P:System.ComponentModel.Composition.Primitives.ImportDefinition.Cardinality" /> равно <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ZeroOrOne" /> или <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ExactlyOne" /> и имеется ровно один объект <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, соответствующий условиям указанного определения <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />; в противном случае значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="definition" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060005EA RID: 1514 RVA: 0x00011F2C File Offset: 0x0001012C
		public bool TryGetExports(ImportDefinition definition, AtomicComposition atomicComposition, out IEnumerable<Export> exports)
		{
			Requires.NotNull<ImportDefinition>(definition, "definition");
			exports = null;
			return this.TryGetExportsCore(definition, atomicComposition, out exports) == ExportCardinalityCheckResult.Match;
		}

		/// <summary>Получает все экспорты, которые соответствуют ограничению, заданному указанным определением.</summary>
		/// <param name="definition">Объект, определяющий условия возвращаемых объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />.</param>
		/// <param name="atomicComposition">Транзакционный контейнер для композиции.</param>
		/// <returns>Коллекция, которая содержит все элементы экспорта, соответствующие заданному условию.</returns>
		// Token: 0x060005EB RID: 1515
		protected abstract IEnumerable<Export> GetExportsCore(ImportDefinition definition, AtomicComposition atomicComposition);

		/// <summary>Вызывает событие <see cref="E:System.ComponentModel.Composition.Hosting.ExportProvider.ExportsChanged" />.</summary>
		/// <param name="e">Объект класса <see cref="T:System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs" />, содержащий данные события.</param>
		// Token: 0x060005EC RID: 1516 RVA: 0x00011F48 File Offset: 0x00010148
		protected virtual void OnExportsChanged(ExportsChangeEventArgs e)
		{
			EventHandler<ExportsChangeEventArgs> exportsChanged = this.ExportsChanged;
			if (exportsChanged != null)
			{
				CompositionServices.TryFire<ExportsChangeEventArgs>(exportsChanged, this, e).ThrowOnErrors(e.AtomicComposition);
			}
		}

		/// <summary>Вызывает событие <see cref="E:System.ComponentModel.Composition.Hosting.ExportProvider.ExportsChanging" />.</summary>
		/// <param name="e">Объект класса <see cref="T:System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs" />, содержащий данные события.</param>
		// Token: 0x060005ED RID: 1517 RVA: 0x00011F78 File Offset: 0x00010178
		protected virtual void OnExportsChanging(ExportsChangeEventArgs e)
		{
			EventHandler<ExportsChangeEventArgs> exportsChanging = this.ExportsChanging;
			if (exportsChanging != null)
			{
				CompositionServices.TryFire<ExportsChangeEventArgs>(exportsChanging, this, e).ThrowOnErrors(e.AtomicComposition);
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00011FA8 File Offset: 0x000101A8
		private ExportCardinalityCheckResult TryGetExportsCore(ImportDefinition definition, AtomicComposition atomicComposition, out IEnumerable<Export> exports)
		{
			Assumes.NotNull<ImportDefinition>(definition);
			exports = this.GetExportsCore(definition, atomicComposition);
			ExportCardinalityCheckResult exportCardinalityCheckResult = ExportServices.CheckCardinality<Export>(definition, exports);
			if (exportCardinalityCheckResult == ExportCardinalityCheckResult.TooManyExports && definition.Cardinality == ImportCardinality.ZeroOrOne)
			{
				exportCardinalityCheckResult = ExportCardinalityCheckResult.Match;
				exports = null;
			}
			if (exports == null)
			{
				exports = ExportProvider.EmptyExports;
			}
			return exportCardinalityCheckResult;
		}

		// Token: 0x04000280 RID: 640
		private static readonly Export[] EmptyExports = new Export[0];
	}
}
