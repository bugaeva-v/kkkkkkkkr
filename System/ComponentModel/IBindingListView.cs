using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Расширяет интерфейс <see cref="T:System.ComponentModel.IBindingList" />, предоставляя дополнительные возможности сортировки и фильтрации.</summary>
	// Token: 0x020003B0 RID: 944
	public interface IBindingListView : IBindingList, IList, ICollection, IEnumerable
	{
		/// <summary>Сортирует источник данных, используя заданную коллекцию <see cref="T:System.ComponentModel.ListSortDescriptionCollection" />.</summary>
		/// <param name="sorts">Коллекция <see cref="T:System.ComponentModel.ListSortDescriptionCollection" />, содержащая условия сортировки, применяемые к источнику данных.</param>
		// Token: 0x06001EEF RID: 7919
		void ApplySort(ListSortDescriptionCollection sorts);

		/// <summary>Получает или задает фильтр, используемый для исключения элементов из коллекции элементов, возвращенных источником данных.</summary>
		/// <returns>Строка, используемая для фильтрации элементов из коллекции элементов, возвращенной источником данных.</returns>
		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001EF0 RID: 7920
		// (set) Token: 0x06001EF1 RID: 7921
		string Filter { get; set; }

		/// <summary>Возвращает коллекцию описаний сортировки, применяемых в данный момент к источнику данных.</summary>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.ListSortDescriptionCollection" />, применяемая в данный момент к источнику данных.</returns>
		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001EF2 RID: 7922
		ListSortDescriptionCollection SortDescriptions { get; }

		/// <summary>Возвращает текущий фильтр, примененный к источнику данных.</summary>
		// Token: 0x06001EF3 RID: 7923
		void RemoveFilter();

		/// <summary>Возвращает значение, показывающее, поддерживает ли источник данных дополнительные возможности сортировки.</summary>
		/// <returns>Значение <see langword="true" />, если источник данных поддерживает дополнительные возможности сортировки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001EF4 RID: 7924
		bool SupportsAdvancedSorting { get; }

		/// <summary>Возвращает значение, указывающее, поддерживает ли источник данных фильтрацию.</summary>
		/// <returns>Значение <see langword="true" />, если источник данных поддерживает фильтрацию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001EF5 RID: 7925
		bool SupportsFiltering { get; }
	}
}
