using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace System.Drawing.Design
{
	/// <summary>Обеспечивает методы и свойства для управления панелью инструментов в среде разработки и выполнения запросов к этой панели.</summary>
	// Token: 0x02000123 RID: 291
	[Guid("4BACD258-DE64-4048-BC4E-FEDBEF9ACB76")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IToolboxService
	{
		/// <summary>Получает имена всех категорий средств имеющихся в данный момент на панели инструментов.</summary>
		/// <returns>Коллекция <see cref="T:System.Drawing.Design.CategoryNameCollection" />, содержащая категории средств.</returns>
		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000D79 RID: 3449
		CategoryNameCollection CategoryNames { get; }

		/// <summary>Получает или задает имя выбранной в данный момент категории средств с панели инструментов.</summary>
		/// <returns>Имя текущей выбранной категории.</returns>
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000D7A RID: 3450
		// (set) Token: 0x06000D7B RID: 3451
		string SelectedCategory { get; set; }

		/// <summary>Добавляет создатель нового элемента панели инструментов для заданного формата данных.</summary>
		/// <param name="creator">Объект <see cref="T:System.Drawing.Design.ToolboxItemCreatorCallback" />, который может создавать компонент при обращении к элементу панели инструментов.</param>
		/// <param name="format">Формат данных, которым управляет создатель.</param>
		// Token: 0x06000D7C RID: 3452
		void AddCreator(ToolboxItemCreatorCallback creator, string format);

		/// <summary>Добавляет создатель нового элемента панели инструментов для заданных формата данных и хост-узла конструктора.</summary>
		/// <param name="creator">Объект <see cref="T:System.Drawing.Design.ToolboxItemCreatorCallback" />, который может создавать компонент при обращении к элементу панели инструментов.</param>
		/// <param name="format">Формат данных, которым управляет создатель.</param>
		/// <param name="host">Объект <see cref="T:System.ComponentModel.Design.IDesignerHost" /> представляет хост-узел конструктора, который должен быть сопоставлен создателю.</param>
		// Token: 0x06000D7D RID: 3453
		void AddCreator(ToolboxItemCreatorCallback creator, string format, IDesignerHost host);

		/// <summary>Добавляет заданный связанный с проектом элемент на панель инструментов.</summary>
		/// <param name="toolboxItem">Связанный объект <see cref="T:System.Drawing.Design.ToolboxItem" />, который требуется добавить на панель инструментов.</param>
		/// <param name="host">Интерфейс <see cref="T:System.ComponentModel.Design.IDesignerHost" /> для текущего документа проекта.</param>
		// Token: 0x06000D7E RID: 3454
		void AddLinkedToolboxItem(ToolboxItem toolboxItem, IDesignerHost host);

		/// <summary>Добавляет на панель инструментов заданный связанный с проектом элемент определенной категории.</summary>
		/// <param name="toolboxItem">Связанный объект <see cref="T:System.Drawing.Design.ToolboxItem" />, который требуется добавить на панель инструментов.</param>
		/// <param name="category">Категория элементов панели инструментов, в которую следует добавить элемент панели инструментов.</param>
		/// <param name="host">Интерфейс <see cref="T:System.ComponentModel.Design.IDesignerHost" /> для текущего документа проекта.</param>
		// Token: 0x06000D7F RID: 3455
		void AddLinkedToolboxItem(ToolboxItem toolboxItem, string category, IDesignerHost host);

		/// <summary>Добавляет заданный элемент панели инструментов на панель инструментов.</summary>
		/// <param name="toolboxItem">Объект <see cref="T:System.Drawing.Design.ToolboxItem" />, который требуется добавить на панель инструментов.</param>
		// Token: 0x06000D80 RID: 3456
		void AddToolboxItem(ToolboxItem toolboxItem);

		/// <summary>Добавляет указанный элемент заданной категории на панель инструментов.</summary>
		/// <param name="toolboxItem">Объект <see cref="T:System.Drawing.Design.ToolboxItem" />, который требуется добавить на панель инструментов.</param>
		/// <param name="category">Категория элементов панели инструментов, в которую должен быть добавлен объект <see cref="T:System.Drawing.Design.ToolboxItem" />.</param>
		// Token: 0x06000D81 RID: 3457
		void AddToolboxItem(ToolboxItem toolboxItem, string category);

		/// <summary>Получает элемент панели инструментов из указанного объекта, который представляет элемент панели в сериализованной форме.</summary>
		/// <param name="serializedObject">Объект, содержащий объект <see cref="T:System.Drawing.Design.ToolboxItem" /> для извлечения.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Design.ToolboxItem" />, созданный на основе сериализованного объекта.</returns>
		// Token: 0x06000D82 RID: 3458
		ToolboxItem DeserializeToolboxItem(object serializedObject);

		/// <summary>Получает элемент панели инструментов из указанного объекта, который представляет элемент панели в сериализованной форме, с помощью указанного узла конструктора.</summary>
		/// <param name="serializedObject">Объект, содержащий объект <see cref="T:System.Drawing.Design.ToolboxItem" /> для извлечения.</param>
		/// <param name="host">Объект <see cref="T:System.ComponentModel.Design.IDesignerHost" />, с которым требуется связать данный <see cref="T:System.Drawing.Design.ToolboxItem" />.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Design.ToolboxItem" />, созданный в результате десериализации.</returns>
		// Token: 0x06000D83 RID: 3459
		ToolboxItem DeserializeToolboxItem(object serializedObject, IDesignerHost host);

		/// <summary>Получает выбранный в данный момент элемент панели инструментов.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Design.ToolboxItem" />, который выбран в данный момент, либо значение <see langword="null" />, если ни один элемент панели инструментов не выбран.</returns>
		// Token: 0x06000D84 RID: 3460
		ToolboxItem GetSelectedToolboxItem();

		/// <summary>Получает выбранный в данный момент элемент панели инструментов, если это доступно для всех конструкторов или поддерживает определенный конструктор.</summary>
		/// <param name="host">Интерфейс <see cref="T:System.ComponentModel.Design.IDesignerHost" />, с которым должно быть сопоставлено выбранное средство для его возвращения.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Design.ToolboxItem" />, который выбран в данный момент, либо значение <see langword="null" />, если ни один элемент панели инструментов не выбран.</returns>
		// Token: 0x06000D85 RID: 3461
		ToolboxItem GetSelectedToolboxItem(IDesignerHost host);

		/// <summary>Получает полную коллекцию элементов панели инструментов из панели инструментов.</summary>
		/// <returns>Коллекция <see cref="T:System.Drawing.Design.ToolboxItemCollection" />, содержащая текущие элементы панели инструментов.</returns>
		// Token: 0x06000D86 RID: 3462
		ToolboxItemCollection GetToolboxItems();

		/// <summary>Получает коллекцию элементов панели элементов, связанных с указанным узлом конструктора из панели элементов.</summary>
		/// <param name="host">Объект <see cref="T:System.ComponentModel.Design.IDesignerHost" />, который связан с извлекаемыми элементами панели инструментов.</param>
		/// <returns>Коллекция <see cref="T:System.Drawing.Design.ToolboxItemCollection" />, содержащая элементы панели инструментов, сопоставленные указанному хост-узлу конструктора.</returns>
		// Token: 0x06000D87 RID: 3463
		ToolboxItemCollection GetToolboxItems(IDesignerHost host);

		/// <summary>Получает из панели инструментов коллекцию элементов определенной категории.</summary>
		/// <param name="category">Категория элемента панели инструментов, в которой необходимо извлечь все элементы из панели инструментов.</param>
		/// <returns>Коллекция <see cref="T:System.Drawing.Design.ToolboxItemCollection" />, которая содержит элементы текущей панели инструментов, сопоставленные указанной категории.</returns>
		// Token: 0x06000D88 RID: 3464
		ToolboxItemCollection GetToolboxItems(string category);

		/// <summary>Получает из панели инструментов коллекцию элементов панели инструментов, которые сопоставлены указанным хост-узлу конструктора и категории.</summary>
		/// <param name="category">Категория элемента панели инструмента, из которой необходимо извлечь элементы панели инструментов.</param>
		/// <param name="host">Объект <see cref="T:System.ComponentModel.Design.IDesignerHost" />, который связан с извлекаемыми элементами панели инструментов.</param>
		/// <returns>Коллекция <see cref="T:System.Drawing.Design.ToolboxItemCollection" />, которая содержит элементы текущей панели инструментов, сопоставленные указанным хост-узлу конструктора и категории.</returns>
		// Token: 0x06000D89 RID: 3465
		ToolboxItemCollection GetToolboxItems(string category, IDesignerHost host);

		/// <summary>Получает значение, определяющее, может ли указанный объект, который представляет сериализованный элемент панели инструментов, быть использован указанным хост-узелом конструктора.</summary>
		/// <param name="serializedObject">Объект, содержащий объект <see cref="T:System.Drawing.Design.ToolboxItem" /> для извлечения.</param>
		/// <param name="host">Интерфейс <see cref="T:System.ComponentModel.Design.IDesignerHost" /> для проверки поддержки объекта <see cref="T:System.Drawing.Design.ToolboxItem" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект совместим с указанным хост-узелом конструктора; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000D8A RID: 3466
		bool IsSupported(object serializedObject, IDesignerHost host);

		/// <summary>Получает значение, определяющее, соответствует ли указанный объект, который представляет сериализованный элемент панели инструментов, заданным атрибутам.</summary>
		/// <param name="serializedObject">Объект, содержащий объект <see cref="T:System.Drawing.Design.ToolboxItem" /> для извлечения.</param>
		/// <param name="filterAttributes">Коллекция <see cref="T:System.Collections.ICollection" />, содержащая атрибуты для проверки сериализованных объектов.</param>
		/// <returns>Значение <see langword="true" />, если объект соответствует указанным атрибутам; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000D8B RID: 3467
		bool IsSupported(object serializedObject, ICollection filterAttributes);

		/// <summary>Получает значение, указывающее, является ли указанный объект сериализованным элементом панели инструментов.</summary>
		/// <param name="serializedObject">Объект для проверки.</param>
		/// <returns>Значение <see langword="true" />, если объект содержит объект элемента панели инструментов; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000D8C RID: 3468
		bool IsToolboxItem(object serializedObject);

		/// <summary>Получает значение, указывающее, является ли заданный объект сериализованным элементом панели инструментов, используя указанный хост-узел конструктора.</summary>
		/// <param name="serializedObject">Объект для проверки.</param>
		/// <param name="host">Объект <see cref="T:System.ComponentModel.Design.IDesignerHost" />, создающий этот запрос.</param>
		/// <returns>Значение <see langword="true" />, если объект содержит объект элемента панели инструментов; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000D8D RID: 3469
		bool IsToolboxItem(object serializedObject, IDesignerHost host);

		/// <summary>Обновляет состояние элементов панели инструментов.</summary>
		// Token: 0x06000D8E RID: 3470
		void Refresh();

		/// <summary>Удаляет ранее добавленный разработчик элемента панели инструментов для форматирования указанных данных.</summary>
		/// <param name="format">Формат данных разработчика, которые требуется удалить.</param>
		// Token: 0x06000D8F RID: 3471
		void RemoveCreator(string format);

		/// <summary>Удаляет ранее добавленный разработчик, который связан с указанным форматированием данных и определенным узелом конструктора.</summary>
		/// <param name="format">Формат данных разработчика, которые требуется удалить.</param>
		/// <param name="host">Объект <see cref="T:System.ComponentModel.Design.IDesignerHost" />, который связан с удаляемым разработчиком.</param>
		// Token: 0x06000D90 RID: 3472
		void RemoveCreator(string format, IDesignerHost host);

		/// <summary>Удаляет заданный элемент панели инструментов из панели инструментов.</summary>
		/// <param name="toolboxItem">Объект <see cref="T:System.Drawing.Design.ToolboxItem" />, который нужно удалить из панели инструментов.</param>
		// Token: 0x06000D91 RID: 3473
		void RemoveToolboxItem(ToolboxItem toolboxItem);

		/// <summary>Удаляет заданный элемент панели инструментов из панели инструментов.</summary>
		/// <param name="toolboxItem">Объект <see cref="T:System.Drawing.Design.ToolboxItem" />, который нужно удалить из панели инструментов.</param>
		/// <param name="category">Категория элемента панели инструментов, из которой требуется удалить из <see cref="T:System.Drawing.Design.ToolboxItem" />.</param>
		// Token: 0x06000D92 RID: 3474
		void RemoveToolboxItem(ToolboxItem toolboxItem, string category);

		/// <summary>Уведомляет службу панели инструментов, что выбранное средство было использовано.</summary>
		// Token: 0x06000D93 RID: 3475
		void SelectedToolboxItemUsed();

		/// <summary>Получает сериализованный объект, который представляет выбранный элемент панели инструментов.</summary>
		/// <param name="toolboxItem">Экземпляр <see cref="T:System.Drawing.Design.ToolboxItem" /> для сериализации.</param>
		/// <returns>Объект, представляющий заданный объект <see cref="T:System.Drawing.Design.ToolboxItem" />.</returns>
		// Token: 0x06000D94 RID: 3476
		object SerializeToolboxItem(ToolboxItem toolboxItem);

		/// <summary>Устанавливает для курсора текущего приложения курсор, представляющий текущее выбранное средство.</summary>
		/// <returns>Значение <see langword="true" />, если курсор установлен с помощью выбранного в настоящий момент средства, значение <see langword="false" />, если ни одно средство не выбрано и курсор является стандартным курсором Windows.</returns>
		// Token: 0x06000D95 RID: 3477
		bool SetCursor();

		/// <summary>Выбирает указанный элемент панели инструментов.</summary>
		/// <param name="toolboxItem">Необходимо выбрать <see cref="T:System.Drawing.Design.ToolboxItem" />.</param>
		// Token: 0x06000D96 RID: 3478
		void SetSelectedToolboxItem(ToolboxItem toolboxItem);
	}
}
