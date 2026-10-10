using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Представляет модуль записи символов для управляемого кода.</summary>
	// Token: 0x020009DE RID: 2526
	[ComVisible(true)]
	public interface ISymbolWriter
	{
		/// <summary>Закрывает интерфейс <see cref="T:System.Diagnostics.SymbolStore.ISymbolWriter" /> и сохраняет символы в хранилище символов.</summary>
		// Token: 0x06005A78 RID: 23160
		void Close();

		/// <summary>Закрывает текущий метод.</summary>
		// Token: 0x06005A79 RID: 23161
		void CloseMethod();

		/// <summary>Закрывает последнее пространство имен.</summary>
		// Token: 0x06005A7A RID: 23162
		void CloseNamespace();

		/// <summary>Закрывает текущую лексическую область видимости.</summary>
		/// <param name="endOffset">точки после последней инструкции в области.</param>
		// Token: 0x06005A7B RID: 23163
		void CloseScope(int endOffset);

		/// <summary>Определяет исходный документ.</summary>
		/// <param name="url">URL-адрес, предназначенный для идентификации документа.</param>
		/// <param name="language">Язык документа. Этот параметр может иметь значение <see cref="F:System.Guid.Empty" />.</param>
		/// <param name="languageVendor">Удостоверение поставщика языка документа. Этот параметр может иметь значение <see cref="F:System.Guid.Empty" />.</param>
		/// <param name="documentType">Тип документа. Этот параметр может иметь значение <see cref="F:System.Guid.Empty" />.</param>
		/// <returns>Объект, представляющий документ.</returns>
		// Token: 0x06005A7C RID: 23164
		ISymbolDocumentWriter DefineDocument(string url, Guid language, Guid languageVendor, Guid documentType);

		/// <summary>Определяет поле в типе или глобальное поле.</summary>
		/// <param name="parent">Тип метаданных или маркер метода.</param>
		/// <param name="name">Имя поля.</param>
		/// <param name="attributes">Побитовое сочетание атрибутов полей.</param>
		/// <param name="signature">Подпись поля.</param>
		/// <param name="addrKind">Типы адресов <paramref name="addr1" /> и <paramref name="addr2" />.</param>
		/// <param name="addr1">Первый адрес для спецификации поля.</param>
		/// <param name="addr2">Второй адрес для спецификации поля.</param>
		/// <param name="addr3">Третий адрес для спецификации поля.</param>
		// Token: 0x06005A7D RID: 23165
		void DefineField(SymbolToken parent, string name, FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3);

		/// <summary>Определяет одну глобальную переменную.</summary>
		/// <param name="name">Имя глобальной переменной.</param>
		/// <param name="attributes">Побитовое сочетание атрибутов глобальной переменной.</param>
		/// <param name="signature">Подпись глобальной переменной.</param>
		/// <param name="addrKind">Типы адресов <paramref name="addr1" />, <paramref name="addr2" /> и <paramref name="addr3" />.</param>
		/// <param name="addr1">Первый адрес для спецификации глобальной переменной.</param>
		/// <param name="addr2">Второй адрес для спецификации глобальной переменной.</param>
		/// <param name="addr3">Третий адрес для спецификации глобальной переменной.</param>
		// Token: 0x06005A7E RID: 23166
		void DefineGlobalVariable(string name, FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3);

		/// <summary>Определяет одну переменную в текущей лексической области видимости.</summary>
		/// <param name="name">Имя локальной переменной.</param>
		/// <param name="attributes">Побитовое сочетание атрибутов локальной переменной.</param>
		/// <param name="signature">Подпись локальной переменной.</param>
		/// <param name="addrKind">Типы адресов <paramref name="addr1" />, <paramref name="addr2" /> и <paramref name="addr3" />.</param>
		/// <param name="addr1">Первый адрес для спецификации локальной переменной.</param>
		/// <param name="addr2">Второй адрес для спецификации локальной переменной.</param>
		/// <param name="addr3">Третий адрес для спецификации локальной переменной.</param>
		/// <param name="startOffset">Начальное смещение для переменной. Если этот параметр равен нулю, он не обрабатывается и переменная определяется для всей области. Если параметр имеет ненулевое значение, переменная находится в границах смещений текущей области.</param>
		/// <param name="endOffset">Конечное смещение для переменной. Если этот параметр равен нулю, он не обрабатывается и переменная определяется для всей области. Если параметр имеет ненулевое значение, переменная находится в границах смещений текущей области.</param>
		// Token: 0x06005A7F RID: 23167
		void DefineLocalVariable(string name, FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3, int startOffset, int endOffset);

		/// <summary>Определяет один параметр в текущем методе. Тип каждого параметра извлекается из подписи метода в соответствии с его положением.</summary>
		/// <param name="name">Имя параметра.</param>
		/// <param name="attributes">Побитовое сочетание атрибутов параметра.</param>
		/// <param name="sequence">Подпись параметра.</param>
		/// <param name="addrKind">Типы адресов <paramref name="addr1" />, <paramref name="addr2" /> и <paramref name="addr3" />.</param>
		/// <param name="addr1">Первый адрес для спецификации параметра.</param>
		/// <param name="addr2">Второй адрес для спецификации параметра.</param>
		/// <param name="addr3">Третий адрес для спецификации параметра.</param>
		// Token: 0x06005A80 RID: 23168
		void DefineParameter(string name, ParameterAttributes attributes, int sequence, SymAddressKind addrKind, int addr1, int addr2, int addr3);

		/// <summary>Определяет группу точек следования в текущем методе.</summary>
		/// <param name="document">Объект документа, для которого определяются точки следования.</param>
		/// <param name="offsets">Смещения точек следования определяются от начала методов.</param>
		/// <param name="lines">Строки документа для точек следования.</param>
		/// <param name="columns">Позиции в документе для точек следования.</param>
		/// <param name="endLines">Конечные строки документа для точек следования.</param>
		/// <param name="endColumns">Конечные позиции документа для точек следования.</param>
		// Token: 0x06005A81 RID: 23169
		void DefineSequencePoints(ISymbolDocumentWriter document, int[] offsets, int[] lines, int[] columns, int[] endLines, int[] endColumns);

		/// <summary>Задает интерфейс включения метаданных, который требуется связать со средством записи.</summary>
		/// <param name="emitter">Интерфейс порождения метаданных.</param>
		/// <param name="filename">Имя файла, для которого записываются символы отладки. Имя файла требуется не для всех средств записи. Если имя файла задано для модуля записи, который не использует имена файлов, этот параметр пропускается.</param>
		/// <param name="fFullBuild">Значение <see langword="true" /> указывает, что это полное перестроение; <see langword="false" /> — что это добавочная компиляция.</param>
		// Token: 0x06005A82 RID: 23170
		void Initialize(IntPtr emitter, string filename, bool fFullBuild);

		/// <summary>Открывает метод для размещения символьной информации.</summary>
		/// <param name="method">Токен метаданных для открываемого метода.</param>
		// Token: 0x06005A83 RID: 23171
		void OpenMethod(SymbolToken method);

		/// <summary>Открывает новое пространство имен.</summary>
		/// <param name="name">Имя нового пространства имен.</param>
		// Token: 0x06005A84 RID: 23172
		void OpenNamespace(string name);

		/// <summary>Открывает новую лексическую область видимости в текущем методе.</summary>
		/// <param name="startOffset">Смещение в байтах от начала метода до первой инструкции в лексической области.</param>
		/// <returns>Непрозрачный идентификатор области видимости, который можно использовать с методом <see cref="M:System.Diagnostics.SymbolStore.ISymbolWriter.SetScopeRange(System.Int32,System.Int32,System.Int32)" /> для определения начального и конечного смещений области видимости в дальнейшем. В этом случае смещения, переданные методам <see cref="M:System.Diagnostics.SymbolStore.ISymbolWriter.OpenScope(System.Int32)" /> и <see cref="M:System.Diagnostics.SymbolStore.ISymbolWriter.CloseScope(System.Int32)" />, пропускаются. Идентификатор области видимости действителен только в текущем методе.</returns>
		// Token: 0x06005A85 RID: 23173
		int OpenScope(int startOffset);

		/// <summary>Указывает истинные начало и конец метода в исходном файле. Метод <see cref="M:System.Diagnostics.SymbolStore.ISymbolWriter.SetMethodSourceRange(System.Diagnostics.SymbolStore.ISymbolDocumentWriter,System.Int32,System.Int32,System.Diagnostics.SymbolStore.ISymbolDocumentWriter,System.Int32,System.Int32)" /> следует использовать для задания длины метода независимо от точек следования, имеющихся в методе.</summary>
		/// <param name="startDoc">Документ, в котором находится начальная позиция.</param>
		/// <param name="startLine">Номер начальной строки.</param>
		/// <param name="startColumn">Начальный столбец.</param>
		/// <param name="endDoc">Документ, в котором находится конечная позиция.</param>
		/// <param name="endLine">Номер конечной строки.</param>
		/// <param name="endColumn">Номер конечного столбца.</param>
		// Token: 0x06005A86 RID: 23174
		void SetMethodSourceRange(ISymbolDocumentWriter startDoc, int startLine, int startColumn, ISymbolDocumentWriter endDoc, int endLine, int endColumn);

		/// <summary>Определяет диапазон смещений для заданной лексической области видимости.</summary>
		/// <param name="scopeID">Идентификатор лексической области.</param>
		/// <param name="startOffset">Смещение начала лексической области в байтах.</param>
		/// <param name="endOffset">Смещение конца лексической области в байтах.</param>
		// Token: 0x06005A87 RID: 23175
		void SetScopeRange(int scopeID, int startOffset, int endOffset);

		/// <summary>Определяет атрибут для заданного имени и значения атрибута.</summary>
		/// <param name="parent">Токен метаданных, для которого определяется атрибут.</param>
		/// <param name="name">Имя атрибута.</param>
		/// <param name="data">Значение атрибута.</param>
		// Token: 0x06005A88 RID: 23176
		void SetSymAttribute(SymbolToken parent, string name, byte[] data);

		/// <summary>Задает основной интерфейс <see langword="ISymUnmanagedWriter" /> (соответствующий неуправляемый интерфейс), который используется управляемым интерфейсом <see cref="T:System.Diagnostics.SymbolStore.ISymbolWriter" /> для генерации символов.</summary>
		/// <param name="underlyingWriter">Указатель на код, представляющий основное средство записи.</param>
		// Token: 0x06005A89 RID: 23177
		void SetUnderlyingWriter(IntPtr underlyingWriter);

		/// <summary>Идентифицирует пользовательский метод в качестве точки входа для текущего модуля.</summary>
		/// <param name="entryMethod">Токен метаданных для метода, который является пользовательской точкой входа.</param>
		// Token: 0x06005A8A RID: 23178
		void SetUserEntryPoint(SymbolToken entryMethod);

		/// <summary>Указывает, что в открытой лексической области видимости используется заданное полное имя пространства имен.</summary>
		/// <param name="fullName">Полное имя пространства имен.</param>
		// Token: 0x06005A8B RID: 23179
		void UsingNamespace(string fullName);
	}
}
