using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет набор рекомендованных значений по умолчанию во время создания компонента.</summary>
	// Token: 0x02000458 RID: 1112
	public interface IComponentInitializer
	{
		/// <summary>Восстанавливает состояние по умолчанию для экземпляра компонента.</summary>
		/// <param name="defaultValues">Словарь значений свойства по умолчанию, содержащий пары имя/значение, при помощи которого компонент будет возвращен в исходное состояние.</param>
		// Token: 0x0600240D RID: 9229
		void InitializeExistingComponent(IDictionary defaultValues);

		/// <summary>Инициализирует новый компонент с использованием набора рекомендованных значений.</summary>
		/// <param name="defaultValues">Словарь значений свойства по умолчанию, содержащий пары имя/значение, при помощи которого будет инициализировано состояние компонента.</param>
		// Token: 0x0600240E RID: 9230
		void InitializeNewComponent(IDictionary defaultValues);
	}
}
