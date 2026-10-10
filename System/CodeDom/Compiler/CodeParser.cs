using System;
using System.IO;

namespace System.CodeDom.Compiler
{
	/// <summary>Предоставляет пустую реализацию интерфейса <see cref="T:System.CodeDom.Compiler.ICodeParser" />.</summary>
	// Token: 0x02000347 RID: 839
	public abstract class CodeParser : ICodeParser
	{
		/// <summary>Компилирует указанный текстовый поток в объект <see cref="T:System.CodeDom.CodeCompileUnit" />.</summary>
		/// <param name="codeStream">Объект <see cref="T:System.IO.TextReader" />, используемый для чтения кода, подлежащего анализу.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeCompileUnit" />, содержащий модель кода, полученную в результате анализа кода.</returns>
		// Token: 0x06001B51 RID: 6993
		public abstract CodeCompileUnit Parse(TextReader codeStream);
	}
}
