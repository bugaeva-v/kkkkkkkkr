using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет описание операции сортировки, применяемой к источнику данных.</summary>
	// Token: 0x020003D0 RID: 976
	public class ListSortDescription
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ListSortDescription" />, используя заданно описание свойства и направление.</summary>
		/// <param name="property">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, описывающий свойство, по которому сортируется источник данных.</param>
		/// <param name="direction">Одно из значений <see cref="T:System.ComponentModel.ListSortDescription" />.</param>
		// Token: 0x06001F7F RID: 8063 RVA: 0x0006D5D0 File Offset: 0x0006B7D0
		public ListSortDescription(PropertyDescriptor property, ListSortDirection direction)
		{
			this.PropertyDescriptor = property;
			this.SortDirection = direction;
		}

		/// <summary>Получает или задает абстрактное описание свойства класса, связанное с этим описанием <see cref="T:System.ComponentModel.ListSortDescription" /></summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.PropertyDescriptor" />, связанный с данным элементом управления <see cref="T:System.ComponentModel.ListSortDescription" />.</returns>
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x0006D5E6 File Offset: 0x0006B7E6
		// (set) Token: 0x06001F81 RID: 8065 RVA: 0x0006D5EE File Offset: 0x0006B7EE
		public PropertyDescriptor PropertyDescriptor { get; set; }

		/// <summary>Возвращает или задает направление операции сортировки, связанное с этим описанием <see cref="T:System.ComponentModel.ListSortDescription" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.ComponentModel.ListSortDirection" />.</returns>
		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x0006D5F7 File Offset: 0x0006B7F7
		// (set) Token: 0x06001F83 RID: 8067 RVA: 0x0006D5FF File Offset: 0x0006B7FF
		public ListSortDirection SortDirection { get; set; }
	}
}
