using System;

namespace System.ComponentModel
{
	/// <summary>Задает способ изменения списка.</summary>
	// Token: 0x020003CF RID: 975
	public enum ListChangedType
	{
		/// <summary>В список внесены существенные изменения. Все отслеживающие элементы управления обновляют все свои данные из списка.</summary>
		// Token: 0x04000F63 RID: 3939
		Reset,
		/// <summary>Элемент, добавляемый в список. Свойство <see cref="P:System.ComponentModel.ListChangedEventArgs.NewIndex" /> содержит индекс элемента, который был добавлен.</summary>
		// Token: 0x04000F64 RID: 3940
		ItemAdded,
		/// <summary>Элемент, удаленный из списка. Свойство <see cref="P:System.ComponentModel.ListChangedEventArgs.NewIndex" /> содержит индекс элемента, который был удален.</summary>
		// Token: 0x04000F65 RID: 3941
		ItemDeleted,
		/// <summary>Элемент, перемещенный внутри списка. Свойство <see cref="P:System.ComponentModel.ListChangedEventArgs.OldIndex" /> содержит предыдущий индекс элемента, а свойство <see cref="P:System.ComponentModel.ListChangedEventArgs.NewIndex" /> содержит новый индекс элемента.</summary>
		// Token: 0x04000F66 RID: 3942
		ItemMoved,
		/// <summary>Элемент, измененный в списке. Свойство <see cref="P:System.ComponentModel.ListChangedEventArgs.NewIndex" /> содержит индекс элемента, который был изменен.</summary>
		// Token: 0x04000F67 RID: 3943
		ItemChanged,
		/// <summary>Объект <see cref="T:System.ComponentModel.PropertyDescriptor" /> был добавлен, что привело к изменению схемы.</summary>
		// Token: 0x04000F68 RID: 3944
		PropertyDescriptorAdded,
		/// <summary>Объект <see cref="T:System.ComponentModel.PropertyDescriptor" /> был удален, что привело к изменению схемы.</summary>
		// Token: 0x04000F69 RID: 3945
		PropertyDescriptorDeleted,
		/// <summary>Объект <see cref="T:System.ComponentModel.PropertyDescriptor" /> был изменен, что привело к изменению схемы.</summary>
		// Token: 0x04000F6A RID: 3946
		PropertyDescriptorChanged
	}
}
