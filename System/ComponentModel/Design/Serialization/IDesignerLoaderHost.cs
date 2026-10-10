using System;
using System.Collections;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Предоставляет интерфейс, позволяющий расширить узел конструктора для обеспечения загрузки из сериализованного состояния.</summary>
	// Token: 0x02000485 RID: 1157
	public interface IDesignerLoaderHost : IDesignerHost, IServiceContainer, IServiceProvider
	{
		/// <summary>Прекращает операцию загрузки конструктора.</summary>
		/// <param name="baseClassName">Полное имя базового класса документа, создаваемого конструктором.</param>
		/// <param name="successful">Значение <see langword="true" />, если конструктор загружен успешно; в противном случае — <see langword="false" />.</param>
		/// <param name="errorCollection">Коллекция ошибок, возникших при загрузке. Если ошибок нет, передается либо пустая коллекция, либо значение <see langword="null" />.</param>
		// Token: 0x06002515 RID: 9493
		void EndLoad(string baseClassName, bool successful, ICollection errorCollection);

		/// <summary>Перезагружает документ проекта.</summary>
		// Token: 0x06002516 RID: 9494
		void Reload();
	}
}
