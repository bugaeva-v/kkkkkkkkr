using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет интерфейс, который может перечислять поставщиков расширений.</summary>
	// Token: 0x02000461 RID: 1121
	public interface IExtenderListService
	{
		/// <summary>Получает набор поставщиков расширений для компонента.</summary>
		/// <returns>Массив типа <see cref="T:System.ComponentModel.IExtenderProvider" />, в котором перечислены активные поставщики расширений. Если поставщики отсутствуют, возвращается пустой массив.</returns>
		// Token: 0x0600244D RID: 9293
		IExtenderProvider[] GetExtenderProviders();
	}
}
