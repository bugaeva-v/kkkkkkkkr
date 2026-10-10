using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет интерфейс для добавления и удаления поставщиков расширителей во время разработки.</summary>
	// Token: 0x02000462 RID: 1122
	public interface IExtenderProviderService
	{
		/// <summary>Добавляет указанный поставщик расширений.</summary>
		/// <param name="provider">Добавляемый поставщик расширений.</param>
		// Token: 0x0600244E RID: 9294
		void AddExtenderProvider(IExtenderProvider provider);

		/// <summary>Удаляет указанный поставщик расширений.</summary>
		/// <param name="provider">Удаляемый поставщик расширений.</param>
		// Token: 0x0600244F RID: 9295
		void RemoveExtenderProvider(IExtenderProvider provider);
	}
}
