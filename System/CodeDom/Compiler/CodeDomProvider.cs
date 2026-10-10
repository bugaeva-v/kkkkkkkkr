using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.CSharp;
using Microsoft.VisualBasic;

namespace System.CodeDom.Compiler
{
	/// <summary>Предоставляет базовый класс для реализаций <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />. Это абстрактный класс.</summary>
	// Token: 0x02000343 RID: 835
	public abstract class CodeDomProvider : Component
	{
		// Token: 0x06001A95 RID: 6805 RVA: 0x000621DC File Offset: 0x000603DC
		static CodeDomProvider()
		{
			CodeDomProvider.AddCompilerInfo(new CompilerInfo(new CompilerParameters
			{
				WarningLevel = 4
			}, typeof(CSharpCodeProvider).FullName)
			{
				_compilerLanguages = new string[]
				{
					"c#",
					"cs",
					"csharp"
				},
				_compilerExtensions = new string[]
				{
					".cs",
					"cs"
				}
			});
			CodeDomProvider.AddCompilerInfo(new CompilerInfo(new CompilerParameters
			{
				WarningLevel = 4
			}, typeof(VBCodeProvider).FullName)
			{
				_compilerLanguages = new string[]
				{
					"vb",
					"vbs",
					"visualbasic",
					"vbscript"
				},
				_compilerExtensions = new string[]
				{
					".vb",
					"vb"
				}
			});
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x000622E8 File Offset: 0x000604E8
		private static void AddCompilerInfo(CompilerInfo compilerInfo)
		{
			foreach (string key in compilerInfo._compilerLanguages)
			{
				CodeDomProvider.s_compilerLanguages[key] = compilerInfo;
			}
			foreach (string key2 in compilerInfo._compilerExtensions)
			{
				CodeDomProvider.s_compilerExtensions[key2] = compilerInfo;
			}
			CodeDomProvider.s_allCompilerInfo.Add(compilerInfo);
		}

		/// <summary>Получает экземпляр <see cref="T:System.CodeDom.Compiler.CodeDomProvider" /> для заданного языка и параметров поставщика.</summary>
		/// <param name="language">Имя языка.</param>
		/// <param name="providerOptions">Коллекция параметров поставщика из файла конфигурации.</param>
		/// <returns>Поставщик CodeDOM, реализованный для заданного имени языка и параметров.</returns>
		// Token: 0x06001A97 RID: 6807 RVA: 0x0006234A File Offset: 0x0006054A
		public static CodeDomProvider CreateProvider(string language, IDictionary<string, string> providerOptions)
		{
			return CodeDomProvider.GetCompilerInfo(language).CreateProvider(providerOptions);
		}

		/// <summary>Получает экземпляр <see cref="T:System.CodeDom.Compiler.CodeDomProvider" /> для заданного языка.</summary>
		/// <param name="language">Имя языка.</param>
		/// <returns>Поставщик CodeDOM, реализованный для заданного имени языка.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Для языка, заданного в параметре <paramref name="language" />, на данном компьютере не настроен поставщик.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="language" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06001A98 RID: 6808 RVA: 0x00062358 File Offset: 0x00060558
		public static CodeDomProvider CreateProvider(string language)
		{
			return CodeDomProvider.GetCompilerInfo(language).CreateProvider();
		}

		/// <summary>Возвращает имя языка, связанное с определенным расширением имени файла, как настроено в разделе конфигурации компилятора <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />.</summary>
		/// <param name="extension">Расширение имени файла.</param>
		/// <returns>Имя языка, связанное с определенным расширением имени файла, как настроено в параметрах конфигурации компилятора <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationException">Для языка, заданного в параметре <paramref name="extension" />, на данном компьютере не настроен поставщик языка.</exception>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Значение параметра <paramref name="extension" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06001A99 RID: 6809 RVA: 0x00062365 File Offset: 0x00060565
		public static string GetLanguageFromExtension(string extension)
		{
			CompilerInfo compilerInfoForExtensionNoThrow = CodeDomProvider.GetCompilerInfoForExtensionNoThrow(extension);
			if (compilerInfoForExtensionNoThrow == null)
			{
				throw new CodeDomProvider.ConfigurationErrorsException("There is no CodeDom provider defined for the language.");
			}
			return compilerInfoForExtensionNoThrow._compilerLanguages[0];
		}

		/// <summary>Проверяет, имеется ли связанная ли с данным языком реализация <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />, настроенная на данном компьютере.</summary>
		/// <param name="language">Имя языка.</param>
		/// <returns>
		///   <see langword="true" />, если реализация <see cref="T:System.CodeDom.Compiler.CodeDomProvider" /> настроена для заданного языка; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="language" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06001A9A RID: 6810 RVA: 0x00062382 File Offset: 0x00060582
		public static bool IsDefinedLanguage(string language)
		{
			return CodeDomProvider.GetCompilerInfoForLanguageNoThrow(language) != null;
		}

		/// <summary>Проверяет, имеется ли связанная ли с данным расширением имени файла реализация <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />, настроенная на данном компьютере.</summary>
		/// <param name="extension">Расширение имени файла.</param>
		/// <returns>
		///   <see langword="true" />, если реализация <see cref="T:System.CodeDom.Compiler.CodeDomProvider" /> настроена для определенного имени файла; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="extension" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06001A9B RID: 6811 RVA: 0x0006238D File Offset: 0x0006058D
		public static bool IsDefinedExtension(string extension)
		{
			return CodeDomProvider.GetCompilerInfoForExtensionNoThrow(extension) != null;
		}

		/// <summary>Возвращает параметры поставщика и компилятора языка для заданного языка.</summary>
		/// <param name="language">Имя языка.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.CompilerInfo" />, заполненный параметрами настроенной реализации <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationException">Для языка, заданного в параметре <paramref name="language" />, на данном компьютере не настроен поставщик.</exception>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Значение параметра <paramref name="language" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06001A9C RID: 6812 RVA: 0x00062398 File Offset: 0x00060598
		public static CompilerInfo GetCompilerInfo(string language)
		{
			CompilerInfo compilerInfoForLanguageNoThrow = CodeDomProvider.GetCompilerInfoForLanguageNoThrow(language);
			if (compilerInfoForLanguageNoThrow == null)
			{
				throw new CodeDomProvider.ConfigurationErrorsException("There is no CodeDom provider defined for the language.");
			}
			return compilerInfoForLanguageNoThrow;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x000623B0 File Offset: 0x000605B0
		private static CompilerInfo GetCompilerInfoForLanguageNoThrow(string language)
		{
			if (language == null)
			{
				throw new ArgumentNullException("language");
			}
			CompilerInfo result;
			CodeDomProvider.s_compilerLanguages.TryGetValue(language.Trim(), out result);
			return result;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x000623E0 File Offset: 0x000605E0
		private static CompilerInfo GetCompilerInfoForExtensionNoThrow(string extension)
		{
			if (extension == null)
			{
				throw new ArgumentNullException("extension");
			}
			CompilerInfo result;
			CodeDomProvider.s_compilerExtensions.TryGetValue(extension.Trim(), out result);
			return result;
		}

		/// <summary>Возвращает параметры поставщика и компилятора языка для данного компьютера.</summary>
		/// <returns>Массив типа <see cref="T:System.CodeDom.Compiler.CompilerInfo" />, представляющий параметры всех настроенных реализаций <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06001A9F RID: 6815 RVA: 0x0006240F File Offset: 0x0006060F
		public static CompilerInfo[] GetAllCompilerInfo()
		{
			return CodeDomProvider.s_allCompilerInfo.ToArray();
		}

		/// <summary>Получает расширение имени файла по умолчанию для использования в файлах исходного кода в текущем языке.</summary>
		/// <returns>Расширение имени файла, соответствующее расширению исходных файлов текущего языка. Базовая реализация всегда возвращает значение <see cref="F:System.String.Empty" />.</returns>
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0006241B File Offset: 0x0006061B
		public virtual string FileExtension
		{
			get
			{
				return string.Empty;
			}
		}

		/// <summary>Получает идентификатор возможностей языка.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.Compiler.LanguageOptions" />, который указывает специальные возможности языка.</returns>
		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x00003062 File Offset: 0x00001262
		public virtual LanguageOptions LanguageOptions
		{
			get
			{
				return LanguageOptions.None;
			}
		}

		/// <summary>При переопределении в производном классе создает новый генератор кода.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.ICodeGenerator" />, который может использоваться для генерации представлений исходного кода на основе <see cref="N:System.CodeDom" />.</returns>
		// Token: 0x06001AA2 RID: 6818
		[Obsolete("Callers should not use the ICodeGenerator interface and should instead use the methods directly on the CodeDomProvider class. Those inheriting from CodeDomProvider must still implement this interface, and should exclude this warning or also obsolete this method.")]
		public abstract ICodeGenerator CreateGenerator();

		/// <summary>При переопределении в производном классе создает новый генератор кода, используя для вывода указанный объект <see cref="T:System.IO.TextWriter" />.</summary>
		/// <param name="output">Объект <see cref="T:System.IO.TextWriter" />, который следует использовать для вывода.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.ICodeGenerator" />, который может использоваться для генерации представлений исходного кода на основе <see cref="N:System.CodeDom" />.</returns>
		// Token: 0x06001AA3 RID: 6819 RVA: 0x00062422 File Offset: 0x00060622
		public virtual ICodeGenerator CreateGenerator(TextWriter output)
		{
			return this.CreateGenerator();
		}

		/// <summary>При переопределении в производном классе создает новый генератор кода, используя указанное имя файла для выходных данных.</summary>
		/// <param name="fileName">Имя файла для выходных данных.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.ICodeGenerator" />, который может использоваться для генерации представлений исходного кода на основе <see cref="N:System.CodeDom" />.</returns>
		// Token: 0x06001AA4 RID: 6820 RVA: 0x00062422 File Offset: 0x00060622
		public virtual ICodeGenerator CreateGenerator(string fileName)
		{
			return this.CreateGenerator();
		}

		/// <summary>При переопределении в производном классе создает новый компилятор кода.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.ICodeCompiler" />, который может использоваться для компиляции представлений исходного кода на основе <see cref="N:System.CodeDom" />.</returns>
		// Token: 0x06001AA5 RID: 6821
		[Obsolete("Callers should not use the ICodeCompiler interface and should instead use the methods directly on the CodeDomProvider class. Those inheriting from CodeDomProvider must still implement this interface, and should exclude this warning or also obsolete this method.")]
		public abstract ICodeCompiler CreateCompiler();

		/// <summary>При переопределении в производном классе создает новый анализатор кода.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.ICodeParser" />, который может использоваться для анализа исходного кода. Базовая реализация всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x06001AA6 RID: 6822 RVA: 0x00002F6A File Offset: 0x0000116A
		[Obsolete("Callers should not use the ICodeParser interface and should instead use the methods directly on the CodeDomProvider class. Those inheriting from CodeDomProvider must still implement this interface, and should exclude this warning or also obsolete this method.")]
		public virtual ICodeParser CreateParser()
		{
			return null;
		}

		/// <summary>Получает <see cref="T:System.ComponentModel.TypeConverter" /> для указанного типа данных.</summary>
		/// <param name="type">Тип объекта, для которого извлекается преобразователь типов.</param>
		/// <returns>
		///   <see cref="T:System.ComponentModel.TypeConverter" /> для указанного типа или <see langword="null" />, если <see cref="T:System.ComponentModel.TypeConverter" /> для указанного типа не найден.</returns>
		// Token: 0x06001AA7 RID: 6823 RVA: 0x0006242A File Offset: 0x0006062A
		public virtual TypeConverter GetConverter(Type type)
		{
			return TypeDescriptor.GetConverter(type);
		}

		/// <summary>Компилирует сборку на основе деревьев <see cref="N:System.CodeDom" />, содержащихся в указанном массиве объектов <see cref="T:System.CodeDom.CodeCompileUnit" />, используя указанные параметры компилятора.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, задающий параметры компиляции.</param>
		/// <param name="compilationUnits">Массив типа <see cref="T:System.CodeDom.CodeCompileUnit" />, указывающий код для компиляции.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.CompilerResults" />, показывающий результаты компиляции.</returns>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateCompiler" />.</exception>
		// Token: 0x06001AA8 RID: 6824 RVA: 0x00062432 File Offset: 0x00060632
		public virtual CompilerResults CompileAssemblyFromDom(CompilerParameters options, params CodeCompileUnit[] compilationUnits)
		{
			return this.CreateCompilerHelper().CompileAssemblyFromDomBatch(options, compilationUnits);
		}

		/// <summary>Компилирует сборку из исходного кода, содержащегося в указанных файлах, используя указанные параметры компилятора.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, задающий параметры компиляции.</param>
		/// <param name="fileNames">Массив имен файлов для компиляции.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.CompilerResults" />, показывающий результаты компиляции.</returns>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateCompiler" />.</exception>
		// Token: 0x06001AA9 RID: 6825 RVA: 0x00062441 File Offset: 0x00060641
		public virtual CompilerResults CompileAssemblyFromFile(CompilerParameters options, params string[] fileNames)
		{
			return this.CreateCompilerHelper().CompileAssemblyFromFileBatch(options, fileNames);
		}

		/// <summary>Компилирует сборку из указанного массива строк, содержащего исходный код, используя указанные параметры компилятора.</summary>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, задающий параметры компилятора для компиляции.</param>
		/// <param name="sources">Массив строк исходного кода для компиляции.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.CompilerResults" />, показывающий результаты компиляции.</returns>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateCompiler" />.</exception>
		// Token: 0x06001AAA RID: 6826 RVA: 0x00062450 File Offset: 0x00060650
		public virtual CompilerResults CompileAssemblyFromSource(CompilerParameters options, params string[] sources)
		{
			return this.CreateCompilerHelper().CompileAssemblyFromSourceBatch(options, sources);
		}

		/// <summary>Возвращает значение, показывающее, является ли указанное значение допустимым идентификатором для текущего языка.</summary>
		/// <param name="value">Значение для проверки на допустимый идентификатор.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="value" /> является допустимым идентификатором; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateGenerator" />.</exception>
		// Token: 0x06001AAB RID: 6827 RVA: 0x0006245F File Offset: 0x0006065F
		public virtual bool IsValidIdentifier(string value)
		{
			return this.CreateGeneratorHelper().IsValidIdentifier(value);
		}

		/// <summary>Создает Escape-идентификатор для заданного значения.</summary>
		/// <param name="value">Строка, для которой создается Escape-идентификатор.</param>
		/// <returns>Escape-идентификатор для данного значения.</returns>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateGenerator" />.</exception>
		// Token: 0x06001AAC RID: 6828 RVA: 0x0006246D File Offset: 0x0006066D
		public virtual string CreateEscapedIdentifier(string value)
		{
			return this.CreateGeneratorHelper().CreateEscapedIdentifier(value);
		}

		/// <summary>Создает допустимый идентификатор для указанного значения.</summary>
		/// <param name="value">Строка, для которой создается допустимый идентификатор.</param>
		/// <returns>Допустимый идентификатор для указанного значения.</returns>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateGenerator" />.</exception>
		// Token: 0x06001AAD RID: 6829 RVA: 0x0006247B File Offset: 0x0006067B
		public virtual string CreateValidIdentifier(string value)
		{
			return this.CreateGeneratorHelper().CreateValidIdentifier(value);
		}

		/// <summary>Получает тип, на который указывает заданный объект <see cref="T:System.CodeDom.CodeTypeReference" />.</summary>
		/// <param name="type">
		///   <see cref="T:System.CodeDom.CodeTypeReference" /> указывает возвращаемый тип.</param>
		/// <returns>Текстовое представление указанного типа, отформатированное для языка, на котором создается код данным генератором кода. Например, в Visual Basic передача объекта <see cref="T:System.CodeDom.CodeTypeReference" /> для типа <see cref="T:System.Int32" /> вернет "Integer".</returns>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateGenerator" />.</exception>
		// Token: 0x06001AAE RID: 6830 RVA: 0x00062489 File Offset: 0x00060689
		public virtual string GetTypeOutput(CodeTypeReference type)
		{
			return this.CreateGeneratorHelper().GetTypeOutput(type);
		}

		/// <summary>Возвращает значение, показывающее, обеспечивается ли указанная поддержка создания кода.</summary>
		/// <param name="generatorSupport">Объект <see cref="T:System.CodeDom.Compiler.GeneratorSupport" />, указывающий тип поддержки создания кода, который следует проверить.</param>
		/// <returns>
		///   <see langword="true" />, если указанная поддержка создания кода осуществляется; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateGenerator" />.</exception>
		// Token: 0x06001AAF RID: 6831 RVA: 0x00062497 File Offset: 0x00060697
		public virtual bool Supports(GeneratorSupport generatorSupport)
		{
			return this.CreateGeneratorHelper().Supports(generatorSupport);
		}

		/// <summary>Создает код для указанного выражения объектной модели документов кода (CodeDOM) и направляет его указанному модулю записи текста, используя заданные параметры.</summary>
		/// <param name="expression">Объект <see cref="T:System.CodeDom.CodeExpression" />, указывающий выражение, для которого создается код.</param>
		/// <param name="writer">Объект <see cref="T:System.IO.TextWriter" />, которому направляется выходной код.</param>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, указывающий параметры для использования при создании кода.</param>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateGenerator" />.</exception>
		// Token: 0x06001AB0 RID: 6832 RVA: 0x000624A5 File Offset: 0x000606A5
		public virtual void GenerateCodeFromExpression(CodeExpression expression, TextWriter writer, CodeGeneratorOptions options)
		{
			this.CreateGeneratorHelper().GenerateCodeFromExpression(expression, writer, options);
		}

		/// <summary>Создает код для указанного оператора языка объектной модели документов кода (CodeDOM) и направляет его указанному модулю записи текста, используя заданные параметры.</summary>
		/// <param name="statement">Объект <see cref="T:System.CodeDom.CodeStatement" />, содержащий элементы CodeDOM, для которых генерируется код.</param>
		/// <param name="writer">Объект <see cref="T:System.IO.TextWriter" />, которому направляется выходной код.</param>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, указывающий параметры для использования при создании кода.</param>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateGenerator" />.</exception>
		// Token: 0x06001AB1 RID: 6833 RVA: 0x000624B5 File Offset: 0x000606B5
		public virtual void GenerateCodeFromStatement(CodeStatement statement, TextWriter writer, CodeGeneratorOptions options)
		{
			this.CreateGeneratorHelper().GenerateCodeFromStatement(statement, writer, options);
		}

		/// <summary>Создает код для указанного пространства имен объектной модели документов кода (CodeDOM) и направляет его указанному модулю записи текста, используя заданные параметры.</summary>
		/// <param name="codeNamespace">Объект <see cref="T:System.CodeDom.CodeNamespace" />, указывающий пространство имен, для которого создается код.</param>
		/// <param name="writer">Объект <see cref="T:System.IO.TextWriter" />, которому направляется выходной код.</param>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, указывающий параметры для использования при создании кода.</param>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateGenerator" />.</exception>
		// Token: 0x06001AB2 RID: 6834 RVA: 0x000624C5 File Offset: 0x000606C5
		public virtual void GenerateCodeFromNamespace(CodeNamespace codeNamespace, TextWriter writer, CodeGeneratorOptions options)
		{
			this.CreateGeneratorHelper().GenerateCodeFromNamespace(codeNamespace, writer, options);
		}

		/// <summary>Создает код для указанной единицы компиляции объектной модели документов кода (CodeDOM) и направляет его указанному модулю записи текста, используя заданные параметры.</summary>
		/// <param name="compileUnit">Объект <see cref="T:System.CodeDom.CodeCompileUnit" />, для которого создается код.</param>
		/// <param name="writer">Объект <see cref="T:System.IO.TextWriter" />, которому направляется выходной код.</param>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, указывающий параметры для использования при создании кода.</param>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateGenerator" />.</exception>
		// Token: 0x06001AB3 RID: 6835 RVA: 0x000624D5 File Offset: 0x000606D5
		public virtual void GenerateCodeFromCompileUnit(CodeCompileUnit compileUnit, TextWriter writer, CodeGeneratorOptions options)
		{
			this.CreateGeneratorHelper().GenerateCodeFromCompileUnit(compileUnit, writer, options);
		}

		/// <summary>Создает код для указанного объявления типа объектной модели документов кода (CodeDOM) и направляет его указанному модулю записи текста, используя заданные параметры.</summary>
		/// <param name="codeType">Объект <see cref="T:System.CodeDom.CodeTypeDeclaration" />, указывающий тип, для которого создается код.</param>
		/// <param name="writer">Объект <see cref="T:System.IO.TextWriter" />, которому направляется выходной код.</param>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, указывающий параметры для использования при создании кода.</param>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateGenerator" />.</exception>
		// Token: 0x06001AB4 RID: 6836 RVA: 0x000624E5 File Offset: 0x000606E5
		public virtual void GenerateCodeFromType(CodeTypeDeclaration codeType, TextWriter writer, CodeGeneratorOptions options)
		{
			this.CreateGeneratorHelper().GenerateCodeFromType(codeType, writer, options);
		}

		/// <summary>Создает код для указанного объявления члена объектной модели документов кода (CodeDOM) и направляет его указанному модулю записи текста, используя заданные параметры.</summary>
		/// <param name="member">Объект <see cref="T:System.CodeDom.CodeTypeMember" />, указывающий член, для которого создается код.</param>
		/// <param name="writer">Объект <see cref="T:System.IO.TextWriter" />, которому направляется выходной код.</param>
		/// <param name="options">Объект <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, указывающий параметры для использования при создании кода.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод не переопределяется в производном классе.</exception>
		// Token: 0x06001AB5 RID: 6837 RVA: 0x000624F5 File Offset: 0x000606F5
		public virtual void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options)
		{
			throw new NotImplementedException("This CodeDomProvider does not support this method.");
		}

		/// <summary>Компилирует код, прочитанный из заданного текстового потока, в объект <see cref="T:System.CodeDom.CodeCompileUnit" />.</summary>
		/// <param name="codeStream">Объект <see cref="T:System.IO.TextReader" />, используемый для чтения анализируемого кода.</param>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeCompileUnit" />, содержащий представление анализируемого кода.</returns>
		/// <exception cref="T:System.NotImplementedException">В производном классе нельзя переопределить ни этот метод, ни метод <see cref="M:System.CodeDom.Compiler.CodeDomProvider.CreateGenerator" />.</exception>
		// Token: 0x06001AB6 RID: 6838 RVA: 0x00062501 File Offset: 0x00060701
		public virtual CodeCompileUnit Parse(TextReader codeStream)
		{
			return this.CreateParserHelper().Parse(codeStream);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0006250F File Offset: 0x0006070F
		private ICodeCompiler CreateCompilerHelper()
		{
			ICodeCompiler codeCompiler = this.CreateCompiler();
			if (codeCompiler == null)
			{
				throw new NotImplementedException("This CodeDomProvider does not support this method.");
			}
			return codeCompiler;
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x00062525 File Offset: 0x00060725
		private ICodeGenerator CreateGeneratorHelper()
		{
			ICodeGenerator codeGenerator = this.CreateGenerator();
			if (codeGenerator == null)
			{
				throw new NotImplementedException("This CodeDomProvider does not support this method.");
			}
			return codeGenerator;
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0006253B File Offset: 0x0006073B
		private ICodeParser CreateParserHelper()
		{
			ICodeParser codeParser = this.CreateParser();
			if (codeParser == null)
			{
				throw new NotImplementedException("This CodeDomProvider does not support this method.");
			}
			return codeParser;
		}

		// Token: 0x04000E1D RID: 3613
		private static readonly Dictionary<string, CompilerInfo> s_compilerLanguages = new Dictionary<string, CompilerInfo>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000E1E RID: 3614
		private static readonly Dictionary<string, CompilerInfo> s_compilerExtensions = new Dictionary<string, CompilerInfo>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000E1F RID: 3615
		private static readonly List<CompilerInfo> s_allCompilerInfo = new List<CompilerInfo>();

		// Token: 0x02000344 RID: 836
		private sealed class ConfigurationErrorsException : SystemException
		{
			// Token: 0x06001ABB RID: 6843 RVA: 0x0002F15C File Offset: 0x0002D35C
			public ConfigurationErrorsException(string message) : base(message)
			{
			}

			// Token: 0x06001ABC RID: 6844 RVA: 0x00062551 File Offset: 0x00060751
			public ConfigurationErrorsException(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				throw new PlatformNotSupportedException();
			}
		}
	}
}
