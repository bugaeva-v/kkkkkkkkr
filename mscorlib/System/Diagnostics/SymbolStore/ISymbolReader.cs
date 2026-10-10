using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Представляет средство чтения символов для управляемого кода.</summary>
	// Token: 0x020009DB RID: 2523
	[ComVisible(true)]
	public interface ISymbolReader
	{
		/// <summary>Получает токен метаданных для метода, заданного в качестве точки входа пользователя для модуля (если существует).</summary>
		/// <returns>Токен метаданных для метода, который является точкой входа пользователя для модуля.</returns>
		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06005A5E RID: 23134
		SymbolToken UserEntryPoint { get; }

		/// <summary>Получает документ на основании заданного языка, поставщика и типа.</summary>
		/// <param name="url">URL-адрес, предназначенный для идентификации документа.</param>
		/// <param name="language">Язык документа. Этому параметру можно присвоить значение <see cref="F:System.Guid.Empty" />.</param>
		/// <param name="languageVendor">Удостоверение поставщика языка документа. Этому параметру можно присвоить значение <see cref="F:System.Guid.Empty" />.</param>
		/// <param name="documentType">Тип документа. Этому параметру можно присвоить значение <see cref="F:System.Guid.Empty" />.</param>
		/// <returns>Заданный документ.</returns>
		// Token: 0x06005A5F RID: 23135
		ISymbolDocument GetDocument(string url, Guid language, Guid languageVendor, Guid documentType);

		/// <summary>Получает массив всех документов, определенных в хранилище символов.</summary>
		/// <returns>Массив всех документов, определенных в хранилище символов.</returns>
		// Token: 0x06005A60 RID: 23136
		ISymbolDocument[] GetDocuments();

		/// <summary>Получает все глобальные переменные в модуле.</summary>
		/// <returns>Массив всех глобальных переменных в модуле.</returns>
		// Token: 0x06005A61 RID: 23137
		ISymbolVariable[] GetGlobalVariables();

		/// <summary>Получает объект метода средства чтения символов для заданного идентификатора метода.</summary>
		/// <param name="method">Токен метаданных метода.</param>
		/// <returns>Объект метода средства чтения символов для заданного идентификатора метода.</returns>
		// Token: 0x06005A62 RID: 23138
		ISymbolMethod GetMethod(SymbolToken method);

		/// <summary>Получает объект метода средства чтения символов для заданных идентификатора метода и его версии в режиме "Изменить и продолжить".</summary>
		/// <param name="method">Токен метаданных метода.</param>
		/// <param name="version">Версия в режиме "Изменить и продолжить" этого метода.</param>
		/// <returns>Объект метода средства чтения символов для заданного идентификатора метода.</returns>
		// Token: 0x06005A63 RID: 23139
		ISymbolMethod GetMethod(SymbolToken method, int version);

		/// <summary>Получает объект метода средства чтения символов, содержащий указанную позицию в документе.</summary>
		/// <param name="document">Документ, в котором находится метод.</param>
		/// <param name="line">Позиция строки в документе. Нумерация строк начинается с 1.</param>
		/// <param name="column">Позиция столбца в документе. Нумерация столбцов начинается с 1.</param>
		/// <returns>Объект метода средства чтения для заданной позиции в документе.</returns>
		// Token: 0x06005A64 RID: 23140
		ISymbolMethod GetMethodFromDocumentPosition(ISymbolDocument document, int line, int column);

		/// <summary>Получает пространства имен, определенные в глобальной области в текущем хранилище символов.</summary>
		/// <returns>Пространства имен, определенные в глобальной области в текущем хранилище символов.</returns>
		// Token: 0x06005A65 RID: 23141
		ISymbolNamespace[] GetNamespaces();

		/// <summary>Получает значение атрибута для заданного имени атрибута.</summary>
		/// <param name="parent">маркер метаданных объекта, для которого запрашивается этот атрибут.</param>
		/// <param name="name">Имя атрибута.</param>
		/// <returns>Значение атрибута.</returns>
		// Token: 0x06005A66 RID: 23142
		byte[] GetSymAttribute(SymbolToken parent, string name);

		/// <summary>Получает переменные, не являющиеся локальными, для заданного родительского объекта.</summary>
		/// <param name="parent">маркер метаданных типа, для которого запрашиваются эти переменные.</param>
		/// <returns>Массив переменных для родительского объекта.</returns>
		// Token: 0x06005A67 RID: 23143
		ISymbolVariable[] GetVariables(SymbolToken parent);
	}
}
