using System;
using System.Collections;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Предоставляет интерфейс, позволяющий расширить загрузчик конструктора для обеспечения асинхронной загрузки внешних компонентов.</summary>
	// Token: 0x02000487 RID: 1159
	public interface IDesignerLoaderService
	{
		/// <summary>Регистрирует внешний компонент как часть процесса загрузки под управлением данного интерфейса.</summary>
		// Token: 0x0600251B RID: 9499
		void AddLoadDependency();

		/// <summary>Посылает сигнал о завершении зависимой загрузки.</summary>
		/// <param name="successful">Значение <see langword="true" />, если загрузка конструктора прошла успешно; значение <see langword="false" />, если возникли ошибки и загрузка не завершена.</param>
		/// <param name="errorCollection">Коллекция ошибок, возникших при загрузке. Если ошибок нет, передается либо пустая коллекция, либо значение <see langword="null" />.</param>
		// Token: 0x0600251C RID: 9500
		void DependentLoadComplete(bool successful, ICollection errorCollection);

		/// <summary>Перезагружает документ проекта.</summary>
		/// <returns>Значение <see langword="true" />, если принят запрос о перезагрузке, либо значение <see langword="false" />, если перезагрузка запрещена.</returns>
		// Token: 0x0600251D RID: 9501
		bool Reload();
	}
}
