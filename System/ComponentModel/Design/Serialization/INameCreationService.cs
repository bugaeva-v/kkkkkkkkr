using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Предоставляет службу для генерации уникальных имен объектов.</summary>
	// Token: 0x0200048B RID: 1163
	public interface INameCreationService
	{
		/// <summary>Создает новое имя, которое уникально для всех компонентов в указанном контейнере.</summary>
		/// <param name="container">Контейнер, в который добавляется новый объект.</param>
		/// <param name="dataType">Тип данных объекта, которому возвращается имя.</param>
		/// <returns>Уникальное имя типа данных.</returns>
		// Token: 0x06002530 RID: 9520
		string CreateName(IContainer container, Type dataType);

		/// <summary>Возвращает значение, определяющее, является ли указанное имя допустимым.</summary>
		/// <param name="name">Имя для проверки.</param>
		/// <returns>Значение <see langword="true" />, если имя является допустимым; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002531 RID: 9521
		bool IsValidName(string name);

		/// <summary>Возвращает значение, определяющее, является ли указанное имя допустимым.</summary>
		/// <param name="name">Имя для проверки.</param>
		// Token: 0x06002532 RID: 9522
		void ValidateName(string name);
	}
}
