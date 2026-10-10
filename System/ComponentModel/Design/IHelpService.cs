using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет методы для отображения разделов справки, а также для добавления и удаления зарезервированных слов справки во время разработки.</summary>
	// Token: 0x02000463 RID: 1123
	public interface IHelpService
	{
		/// <summary>Добавляет в документ атрибут контекста.</summary>
		/// <param name="name">Имя добавляемого атрибута.</param>
		/// <param name="value">Значение атрибута.</param>
		/// <param name="keywordType">Тип зарезервированного слова из перечисления <see cref="T:System.ComponentModel.Design.HelpKeywordType" />.</param>
		// Token: 0x06002450 RID: 9296
		void AddContextAttribute(string name, string value, HelpKeywordType keywordType);

		/// <summary>Удаляет из документа все существующие атрибуты контекста.</summary>
		// Token: 0x06002451 RID: 9297
		void ClearContextAttributes();

		/// <summary>Создает локальный класс <see cref="T:System.ComponentModel.Design.IHelpService" /> для управления вложенными контекстами.</summary>
		/// <param name="contextType">Приоритетный тип добавляемого вложенного контекста.</param>
		/// <returns>Вновь созданный <see cref="T:System.ComponentModel.Design.IHelpService" />.</returns>
		// Token: 0x06002452 RID: 9298
		IHelpService CreateLocalContext(HelpContextType contextType);

		/// <summary>Удаляет ранее добавленный атрибут контекста.</summary>
		/// <param name="name">Имя удаляемого атрибута.</param>
		/// <param name="value">Значение удаляемого атрибута.</param>
		// Token: 0x06002453 RID: 9299
		void RemoveContextAttribute(string name, string value);

		/// <summary>Удаляет контекст, созданный с помощью метода <see cref="M:System.ComponentModel.Design.IHelpService.CreateLocalContext(System.ComponentModel.Design.HelpContextType)" />.</summary>
		/// <param name="localContext">Удаляемый локальный контекст <see cref="T:System.ComponentModel.Design.IHelpService" />.</param>
		// Token: 0x06002454 RID: 9300
		void RemoveLocalContext(IHelpService localContext);

		/// <summary>Отображает раздел справки, соответствующий указанному ключевому слову.</summary>
		/// <param name="helpKeyword">Ключевое слово раздела справки, который необходимо отобразить.</param>
		// Token: 0x06002455 RID: 9301
		void ShowHelpFromKeyword(string helpKeyword);

		/// <summary>Отображает раздел справки, соответствующий указанному URL-адресу.</summary>
		/// <param name="helpUrl">URL-адреса раздела справки, который необходимо отобразить.</param>
		// Token: 0x06002456 RID: 9302
		void ShowHelpFromUrl(string helpUrl);
	}
}
