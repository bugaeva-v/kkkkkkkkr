using System;
using System.IO;
using System.Text;

namespace System.CodeDom.Compiler
{
	/// <summary>Предоставляет пример реализации интерфейса <see cref="T:System.CodeDom.Compiler.ICodeCompiler" />.</summary>
	// Token: 0x02000342 RID: 834
	public abstract class CodeCompiler : CodeGenerator, ICodeCompiler
	{
		/// <summary>Описание этого члена см. в разделе <see cref="M:System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromDom(System.CodeDom.Compiler.CompilerParameters,System.CodeDom.CodeCompileUnit)" />.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeCompileUnit" />, указывающий источник для компиляции.</param>
		/// <returns>Результаты компиляции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="options" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A81 RID: 6785 RVA: 0x00061C40 File Offset: 0x0005FE40
		CompilerResults ICodeCompiler.CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit e)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			CompilerResults result;
			try
			{
				result = this.FromDom(options, e);
			}
			finally
			{
				options.TempFiles.SafeDelete();
			}
			return result;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromFile(System.CodeDom.Compiler.CompilerParameters,System.String)" />.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="fileName">Имя файла для компиляции.</param>
		/// <returns>Результаты компиляции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="options" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A82 RID: 6786 RVA: 0x00061C84 File Offset: 0x0005FE84
		CompilerResults ICodeCompiler.CompileAssemblyFromFile(CompilerParameters options, string fileName)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			CompilerResults result;
			try
			{
				result = this.FromFile(options, fileName);
			}
			finally
			{
				options.TempFiles.SafeDelete();
			}
			return result;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromSource(System.CodeDom.Compiler.CompilerParameters,System.String)" />.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="source">Строка, указывающая исходный код для компиляции.</param>
		/// <returns>Результаты компиляции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="options" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A83 RID: 6787 RVA: 0x00061CC8 File Offset: 0x0005FEC8
		CompilerResults ICodeCompiler.CompileAssemblyFromSource(CompilerParameters options, string source)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			CompilerResults result;
			try
			{
				result = this.FromSource(options, source);
			}
			finally
			{
				options.TempFiles.SafeDelete();
			}
			return result;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromSourceBatch(System.CodeDom.Compiler.CompilerParameters,System.String[])" />.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="sources">Массив строк, указывающий исходный код для компиляции.</param>
		/// <returns>Результаты компиляции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="options" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A84 RID: 6788 RVA: 0x00061D0C File Offset: 0x0005FF0C
		CompilerResults ICodeCompiler.CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			CompilerResults result;
			try
			{
				result = this.FromSourceBatch(options, sources);
			}
			finally
			{
				options.TempFiles.SafeDelete();
			}
			return result;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromFileBatch(System.CodeDom.Compiler.CompilerParameters,System.String[])" />.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="fileNames">Массив строк, указывающий имена файлов для компиляции.</param>
		/// <returns>Результаты компиляции.</returns>
		// Token: 0x06001A85 RID: 6789 RVA: 0x00061D50 File Offset: 0x0005FF50
		CompilerResults ICodeCompiler.CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			if (fileNames == null)
			{
				throw new ArgumentNullException("fileNames");
			}
			CompilerResults result;
			try
			{
				for (int i = 0; i < fileNames.Length; i++)
				{
					File.OpenRead(fileNames[i]).Dispose();
				}
				result = this.FromFileBatch(options, fileNames);
			}
			finally
			{
				options.TempFiles.SafeDelete();
			}
			return result;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromDomBatch(System.CodeDom.Compiler.CompilerParameters,System.CodeDom.CodeCompileUnit[])" />.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="ea">Массив объектов <see cref="T:System.CodeDom.CodeCompileUnit" />, указывающий источник для компиляции.</param>
		/// <returns>Результаты компиляции.</returns>
		// Token: 0x06001A86 RID: 6790 RVA: 0x00061DC0 File Offset: 0x0005FFC0
		CompilerResults ICodeCompiler.CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] ea)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			CompilerResults result;
			try
			{
				result = this.FromDomBatch(options, ea);
			}
			finally
			{
				options.TempFiles.SafeDelete();
			}
			return result;
		}

		/// <summary>Получает расширение имени файла для использования для файлов исходного кода.</summary>
		/// <returns>Расширение имени файла для использования для файлов исходного кода.</returns>
		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001A87 RID: 6791
		protected abstract string FileExtension { get; }

		/// <summary>Получает имя исполняемого файла компилятора.</summary>
		/// <returns>Имя исполняемого файла компилятора.</returns>
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001A88 RID: 6792
		protected abstract string CompilerName { get; }

		/// <summary>Компилирует указанную единицу компиляции, используя указанные параметры, и возвращает результаты компиляции.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeCompileUnit" />, указывающий источник для компиляции.</param>
		/// <returns>Результаты компиляции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="options" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A89 RID: 6793 RVA: 0x00061E04 File Offset: 0x00060004
		protected virtual CompilerResults FromDom(CompilerParameters options, CodeCompileUnit e)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			return this.FromDomBatch(options, new CodeCompileUnit[]
			{
				e
			});
		}

		/// <summary>Компилирует указанный файл, используя указанные параметры, и возвращает результаты компиляции.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="fileName">Имя файла для компиляции.</param>
		/// <returns>Результаты компиляции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="options" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A8A RID: 6794 RVA: 0x00061E25 File Offset: 0x00060025
		protected virtual CompilerResults FromFile(CompilerParameters options, string fileName)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			File.OpenRead(fileName).Dispose();
			return this.FromFileBatch(options, new string[]
			{
				fileName
			});
		}

		/// <summary>Компилирует указанную строку исходного кода, используя указанные параметры, и возвращает результаты компиляции.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="source">Строка исходного кода для компиляции.</param>
		/// <returns>Результаты компиляции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="options" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A8B RID: 6795 RVA: 0x00061E5F File Offset: 0x0006005F
		protected virtual CompilerResults FromSource(CompilerParameters options, string source)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			return this.FromSourceBatch(options, new string[]
			{
				source
			});
		}

		/// <summary>Компилирует указанные единицы компиляции, используя указанные параметры, и возвращает результаты компиляции.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="ea">Массив объектов <see cref="T:System.CodeDom.CodeCompileUnit" />, указывающий источник для компиляции.</param>
		/// <returns>Результаты компиляции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="options" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="ea" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A8C RID: 6796 RVA: 0x00061E80 File Offset: 0x00060080
		protected virtual CompilerResults FromDomBatch(CompilerParameters options, CodeCompileUnit[] ea)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			if (ea == null)
			{
				throw new ArgumentNullException("ea");
			}
			string[] array = new string[ea.Length];
			for (int i = 0; i < ea.Length; i++)
			{
				if (ea[i] != null)
				{
					this.ResolveReferencedAssemblies(options, ea[i]);
					array[i] = options.TempFiles.AddExtension(i.ToString() + this.FileExtension);
					using (FileStream fileStream = new FileStream(array[i], FileMode.Create, FileAccess.Write, FileShare.Read))
					{
						using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
						{
							((ICodeGenerator)this).GenerateCodeFromCompileUnit(ea[i], streamWriter, base.Options);
							streamWriter.Flush();
						}
					}
				}
			}
			return this.FromFileBatch(options, array);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00061F58 File Offset: 0x00060158
		private void ResolveReferencedAssemblies(CompilerParameters options, CodeCompileUnit e)
		{
			if (e.ReferencedAssemblies.Count > 0)
			{
				foreach (string value in e.ReferencedAssemblies)
				{
					if (!options.ReferencedAssemblies.Contains(value))
					{
						options.ReferencedAssemblies.Add(value);
					}
				}
			}
		}

		/// <summary>Компилирует указанные файлы, используя указанные параметры, и возвращает результаты компиляции.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="fileNames">Массив строк, указывающий имена файлов для компиляции.</param>
		/// <returns>Результаты компиляции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="options" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="fileNames" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A8E RID: 6798 RVA: 0x00061FD0 File Offset: 0x000601D0
		protected virtual CompilerResults FromFileBatch(CompilerParameters options, string[] fileNames)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			if (fileNames == null)
			{
				throw new ArgumentNullException("fileNames");
			}
			throw new PlatformNotSupportedException();
		}

		/// <summary>Обрабатывает указанную строку из указанного объекта <see cref="T:System.CodeDom.Compiler.CompilerResults" />.</summary>
		/// <param name="results">Объект <see cref="T:System.CodeDom.Compiler.CompilerResults" />, показывающий результаты компиляции.</param>
		/// <param name="line">Строка для обработки.</param>
		// Token: 0x06001A8F RID: 6799
		protected abstract void ProcessCompilerOutputLine(CompilerResults results, string line);

		/// <summary>Получает аргументы команды для передачи компилятору из указанного объекта <see cref="T:System.CodeDom.Compiler.CompilerParameters" />.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <returns>Аргументы команды.</returns>
		// Token: 0x06001A90 RID: 6800
		protected abstract string CmdArgsFromParameters(CompilerParameters options);

		/// <summary>Получает командные аргументы, используемые при вызове компилятора для создания файла ответа.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="cmdArgs">Строка аргументов команды.</param>
		/// <returns>Аргументы команды, используемые для создания файла ответа, или значение <see langword="null" />, если аргументы файла ответа отсутствуют.</returns>
		// Token: 0x06001A91 RID: 6801 RVA: 0x00061FF4 File Offset: 0x000601F4
		protected virtual string GetResponseFileCmdArgs(CompilerParameters options, string cmdArgs)
		{
			string text = options.TempFiles.AddExtension("cmdline");
			using (FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write, FileShare.Read))
			{
				using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
				{
					streamWriter.Write(cmdArgs);
					streamWriter.Flush();
				}
			}
			return "@\"" + text + "\"";
		}

		/// <summary>Компилирует указанные строки исходного кода, используя указанные параметры, и возвращает результаты компиляции.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, указывающий параметры компилятора.</param>
		/// <param name="sources">Массив строк, содержащий исходный код для компиляции.</param>
		/// <returns>Результаты компиляции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="options" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="sources" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001A92 RID: 6802 RVA: 0x00062078 File Offset: 0x00060278
		protected virtual CompilerResults FromSourceBatch(CompilerParameters options, string[] sources)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			if (sources == null)
			{
				throw new ArgumentNullException("sources");
			}
			string[] array = new string[sources.Length];
			for (int i = 0; i < sources.Length; i++)
			{
				string text = options.TempFiles.AddExtension(i.ToString() + this.FileExtension);
				using (FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write, FileShare.Read))
				{
					using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
					{
						streamWriter.Write(sources[i]);
						streamWriter.Flush();
					}
				}
				array[i] = text;
			}
			return this.FromFileBatch(options, array);
		}

		/// <summary>Объединяет указанные массивы строк.</summary>
		/// <param name="sa">Массив строк для объединения.</param>
		/// <param name="separator">Используемый разделитель.</param>
		/// <returns>Сцепленная строка.</returns>
		// Token: 0x06001A93 RID: 6803 RVA: 0x00062140 File Offset: 0x00060340
		protected static string JoinStringArray(string[] sa, string separator)
		{
			if (sa == null || sa.Length == 0)
			{
				return string.Empty;
			}
			if (sa.Length == 1)
			{
				return "\"" + sa[0] + "\"";
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < sa.Length - 1; i++)
			{
				stringBuilder.Append('"');
				stringBuilder.Append(sa[i]);
				stringBuilder.Append('"');
				stringBuilder.Append(separator);
			}
			stringBuilder.Append('"');
			stringBuilder.Append(sa[sa.Length - 1]);
			stringBuilder.Append('"');
			return stringBuilder.ToString();
		}
	}
}
