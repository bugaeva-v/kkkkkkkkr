using System;
using System.Collections.Generic;

namespace System.ComponentModel.Composition.Primitives
{
	/// <summary>Определяет абстрактный базовый класс для компонуемых частей, которые импортируют объекты и создают экспортированные объекты.</summary>
	// Token: 0x02000089 RID: 137
	public abstract class ComposablePart
	{
		/// <summary>Получает коллекцию объектов <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" />, описывающих экспортированные объекты, предоставляемые частью.</summary>
		/// <returns>Коллекция объектов <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" />, описывающих экспортированные объекты, предоставляемые объектом <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" /> ликвидирован.</exception>
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003A1 RID: 929
		public abstract IEnumerable<ExportDefinition> ExportDefinitions { get; }

		/// <summary>Получает коллекцию объектов <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />, описывающих импортированные объекты, необходимые для части.</summary>
		/// <returns>Коллекция объектов <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />, описывающих импортированные объекты, необходимые для объекта <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" /> ликвидирован.</exception>
		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003A2 RID: 930
		public abstract IEnumerable<ImportDefinition> ImportDefinitions { get; }

		/// <summary>Получает метаданные объекта <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" />.</summary>
		/// <returns>Метаданные объекта <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" />. Значением по умолчанию является пустой доступный только для чтения объект <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" /> ликвидирован.</exception>
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000AB7D File Offset: 0x00008D7D
		public virtual IDictionary<string, object> Metadata
		{
			get
			{
				return MetadataServices.EmptyMetadata;
			}
		}

		/// <summary>Вызывается после того, как все импорты части заданы и экспорты могут быть извлечены.</summary>
		// Token: 0x060003A4 RID: 932 RVA: 0x000028FF File Offset: 0x00000AFF
		public virtual void Activate()
		{
		}

		/// <summary>Получает экспортированный объект, который описывается заданным объектом <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" />.</summary>
		/// <param name="definition">Один из объектов <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" /> из свойства <see cref="P:System.ComponentModel.Composition.Primitives.ComposablePart.ExportDefinitions" />, описывающий экспортированный объект, который требуется вернуть.</param>
		/// <returns>Экспортированный объект, описываемый параметром <paramref name="definition" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" /> ликвидирован.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="definition" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException">Произошла ошибка при получении экспортированного объекта, который описывается <see cref="T:System.ComponentModel.Composition.Primitives.ExportDefinition" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="definition" /> поступило не из свойства <see cref="P:System.ComponentModel.Composition.Primitives.ComposablePart.ExportDefinitions" /> класса <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не был задан один или несколько необходимых импортов, указываемых свойством <see cref="P:System.ComponentModel.Composition.Primitives.ImportDefinition.IsPrerequisite" />.</exception>
		// Token: 0x060003A5 RID: 933
		public abstract object GetExportedValue(ExportDefinition definition);

		/// <summary>Задает импорт, который описывается указанным объектом <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />, чтобы он соответствовал указанным экспортированным элементам.</summary>
		/// <param name="definition">Один из объектов свойства <see cref="P:System.ComponentModel.Composition.Primitives.ComposablePart.ImportDefinitions" />, определяющий задаваемый импорт.</param>
		/// <param name="exports">Коллекция объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, для которых задается импорт, описываемый свойством <paramref name="definition" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" /> ликвидирован.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="definition" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="exports" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ComponentModel.Composition.Primitives.ComposablePartException">Произошла ошибка при задании импорта, который описывается объектом <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="definition" /> поступило не из свойства <see cref="P:System.ComponentModel.Composition.Primitives.ComposablePart.ImportDefinitions" /> класса <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" />.  
		///
		/// или - 
		/// Параметр <paramref name="exports" /> содержит элемент, равный <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="exports" /> пуст и <see cref="P:System.ComponentModel.Composition.Primitives.ImportDefinition.Cardinality" /> имеет значение <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ExactlyOne" />.  
		///
		/// или - 
		/// Параметр <paramref name="exports" /> содержит несколько элементов, и свойство <see cref="P:System.ComponentModel.Composition.Primitives.ImportDefinition.Cardinality" /> имеет значение <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ZeroOrOne" /> или <see cref="F:System.ComponentModel.Composition.Primitives.ImportCardinality.ExactlyOne" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.ComponentModel.Composition.Primitives.ComposablePart.SetImport(System.ComponentModel.Composition.Primitives.ImportDefinition,System.Collections.Generic.IEnumerable{System.ComponentModel.Composition.Primitives.Export})" /> вызывался ранее, и свойство <see cref="P:System.ComponentModel.Composition.Primitives.ImportDefinition.IsRecomposable" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x060003A6 RID: 934
		public abstract void SetImport(ImportDefinition definition, IEnumerable<Export> exports);
	}
}
