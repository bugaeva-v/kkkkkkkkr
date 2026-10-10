using System;

namespace System.CodeDom.Compiler
{
	/// <summary>Определяет интерфейс для запуска компиляции исходного кода или дерева CodeDOM, используя определенный компилятор.</summary>
	// Token: 0x02000351 RID: 849
	public interface ICodeCompiler
	{
		/// <summary>Компилирует сборку из дерева <see cref="N:System.CodeDom" />, содержащегося в указанном <see cref="T:System.CodeDom.CodeCompileUnit" />, используя указанные параметры компилятора.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, задающий параметры компиляции.</param>
		/// <param name="compilationUnit">Объект <see cref="T:System.CodeDom.CodeCompileUnit" />, задающий код для компиляции.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.CompilerResults" />, показывающий результаты компиляции.</returns>
		// Token: 0x06001C0D RID: 7181
		CompilerResults CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit compilationUnit);

		/// <summary>Компилирует сборку из исходного кода, содержащегося в указанном файле, используя указанные параметры компилятора.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, задающий параметры компиляции.</param>
		/// <param name="fileName">Имя файла, содержащего исходный код для компиляции.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.CompilerResults" />, показывающий результаты компиляции.</returns>
		// Token: 0x06001C0E RID: 7182
		CompilerResults CompileAssemblyFromFile(CompilerParameters options, string fileName);

		/// <summary>Компилирует сборку из указанной строки, содержащей исходный код, используя указанные параметры компилятора.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, задающий параметры компиляции.</param>
		/// <param name="source">Исходный код для компиляции.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.CompilerResults" />, показывающий результаты компиляции.</returns>
		// Token: 0x06001C0F RID: 7183
		CompilerResults CompileAssemblyFromSource(CompilerParameters options, string source);

		/// <summary>Компилирует сборку на основе деревьев <see cref="N:System.CodeDom" />, содержащихся в указанном массиве объектов <see cref="T:System.CodeDom.CodeCompileUnit" />, используя указанные параметры компилятора.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, задающий параметры компиляции.</param>
		/// <param name="compilationUnits">Массив типа <see cref="T:System.CodeDom.CodeCompileUnit" />, указывающий код для компиляции.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.CompilerResults" />, показывающий результаты компиляции.</returns>
		// Token: 0x06001C10 RID: 7184
		CompilerResults CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] compilationUnits);

		/// <summary>Компилирует сборку из исходного кода, содержащегося в указанных файлах, используя указанные параметры компилятора.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, задающий параметры компиляции.</param>
		/// <param name="fileNames">Имена файлов для компиляции.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.CompilerResults" />, показывающий результаты компиляции.</returns>
		// Token: 0x06001C11 RID: 7185
		CompilerResults CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames);

		/// <summary>Компилирует сборку из указанного массива строк, содержащего исходный код, используя указанные параметры компилятора.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, задающий параметры компиляции.</param>
		/// <param name="sources">Строки исходного кода для компиляции.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.CompilerResults" />, показывающий результаты компиляции.</returns>
		// Token: 0x06001C12 RID: 7186
		CompilerResults CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources);
	}
}
