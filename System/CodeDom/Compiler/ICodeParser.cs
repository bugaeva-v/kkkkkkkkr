using System;
using System.IO;

namespace System.CodeDom.Compiler
{
	/// <summary>Определяет интерфейс для анализа кода в <see cref="T:System.CodeDom.CodeCompileUnit" />.</summary>
	// Token: 0x02000353 RID: 851
	public interface ICodeParser
	{
		/// <summary>При реализации в производном классе компилирует указанный текстовый поток в <see cref="T:System.CodeDom.CodeCompileUnit" />.</summary>
		/// <param name="codeStream">
		///   <see cref="T:System.IO.TextReader" /> применяется для чтения предназначенного для компиляции кода.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeCompileUnit" />, содержащий представление анализируемого кода.</returns>
		// Token: 0x06001C1E RID: 7198
		CodeCompileUnit Parse(TextReader codeStream);
	}
}
