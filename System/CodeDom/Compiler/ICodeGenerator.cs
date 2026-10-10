using System;
using System.IO;

namespace System.CodeDom.Compiler
{
	/// <summary>Определяет интерфейс для создания кода.</summary>
	// Token: 0x02000352 RID: 850
	public interface ICodeGenerator
	{
		/// <summary>Получает значение, показывающее, является ли указанное значение допустимым идентификатором для текущего языка.</summary>
		/// <param name="value">Значение, которое следует проверить на предмет того, является ли оно допустимым идентификатором.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="value" /> является допустимым идентификатором; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001C13 RID: 7187
		bool IsValidIdentifier(string value);

		/// <summary>Выбрасывает исключение, если указанное значение не является допустимым идентификатором.</summary>
		/// <param name="value">Идентификатор для проверки на допустимость.</param>
		/// <exception cref="T:System.ArgumentException">Недопустимый идентификатор.</exception>
		// Token: 0x06001C14 RID: 7188
		void ValidateIdentifier(string value);

		/// <summary>Создает Escape-идентификатор для заданного значения.</summary>
		/// <param name="value">Строка, для которой создается Escape-идентификатор.</param>
		/// <returns>Escape-идентификатор для данного значения.</returns>
		// Token: 0x06001C15 RID: 7189
		string CreateEscapedIdentifier(string value);

		/// <summary>Создает допустимый идентификатор для указанного значения.</summary>
		/// <param name="value">Строка, для которой создается допустимый идентификатор.</param>
		/// <returns>Допустимый идентификатор для указанного значения.</returns>
		// Token: 0x06001C16 RID: 7190
		string CreateValidIdentifier(string value);

		/// <summary>Получает тип, на который указывает заданный объект <see cref="T:System.CodeDom.CodeTypeReference" />.</summary>
		/// <param name="type">
		///   <see cref="T:System.CodeDom.CodeTypeReference" /> указывает возвращаемый тип.</param>
		/// <returns>Текстовое представление указанного типа для языка, код которого создает данный генератор. Например, в Visual Basic при передаче типа System.Int32 будет возвращено значение Integer.</returns>
		// Token: 0x06001C17 RID: 7191
		string GetTypeOutput(CodeTypeReference type);

		/// <summary>Получает значение, показывающее, предоставляет ли генератор поддержку средств языка, представленных указанным объектом <see cref="T:System.CodeDom.Compiler.GeneratorSupport" />.</summary>
		/// <param name="supports">Возможности, на наличие которых следует проверить генератор.</param>
		/// <returns>
		///   <see langword="true" />, если указанные возможности поддерживаются; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001C18 RID: 7192
		bool Supports(GeneratorSupport supports);

		/// <summary>Формирует код для указанного выражения Code Document Object Model (CodeDOM) и выводит его в определенный модуль записи текста.</summary>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeExpression" />, указывающий выражение, для которого создается код.</param>
		/// <param name="w">Объект <see cref="T:System.IO.TextWriter" />, куда будет выводиться код.</param>
		/// <param name="o">Объект <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, указывающий параметры для использования при создании кода.</param>
		// Token: 0x06001C19 RID: 7193
		void GenerateCodeFromExpression(CodeExpression e, TextWriter w, CodeGeneratorOptions o);

		/// <summary>Формирует код для указанной инструкции Code Document Object Model (CodeDOM) и выводит его в определенный модуль записи текста, используя заданные параметры.</summary>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeStatement" />, содержащий элементы CodeDOM для преобразования.</param>
		/// <param name="w">Объект <see cref="T:System.IO.TextWriter" />, куда будет выводиться код.</param>
		/// <param name="o">Объект <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, указывающий параметры для использования при создании кода.</param>
		// Token: 0x06001C1A RID: 7194
		void GenerateCodeFromStatement(CodeStatement e, TextWriter w, CodeGeneratorOptions o);

		/// <summary>Формирует код для указанного пространства имен Code Document Object Model (CodeDOM) и выводит его в определенный модуль записи текста, используя заданные параметры.</summary>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeNamespace" />, указывающий пространство имен, для которого создается код.</param>
		/// <param name="w">Объект <see cref="T:System.IO.TextWriter" />, куда будет выводиться код.</param>
		/// <param name="o">Объект <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, указывающий параметры для использования при создании кода.</param>
		// Token: 0x06001C1B RID: 7195
		void GenerateCodeFromNamespace(CodeNamespace e, TextWriter w, CodeGeneratorOptions o);

		/// <summary>Создает код для указанной единицы компиляции Code Document Object Model (CodeDOM) и выводит его в указанный текстовый редактор, используя указанные параметры.</summary>
		/// <param name="e">Класс <see cref="T:System.CodeDom.CodeCompileUnit" />, для которого создается код.</param>
		/// <param name="w">Объект <see cref="T:System.IO.TextWriter" />, куда будет выводиться код.</param>
		/// <param name="o">Объект <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, указывающий параметры для использования при создании кода.</param>
		// Token: 0x06001C1C RID: 7196
		void GenerateCodeFromCompileUnit(CodeCompileUnit e, TextWriter w, CodeGeneratorOptions o);

		/// <summary>Формирует код для указанного объявления типа Code Document Object Model (CodeDOM) и выводит его в определенный модуль записи текста, используя заданные параметры.</summary>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeTypeDeclaration" />, задающий тип, для которого создается код.</param>
		/// <param name="w">Объект <see cref="T:System.IO.TextWriter" />, куда будет выводиться код.</param>
		/// <param name="o">Объект <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, указывающий параметры для использования при создании кода.</param>
		// Token: 0x06001C1D RID: 7197
		void GenerateCodeFromType(CodeTypeDeclaration e, TextWriter w, CodeGeneratorOptions o);
	}
}
