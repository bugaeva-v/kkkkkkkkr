using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace System.CodeDom.Compiler
{
	/// <summary>Предоставляет пример реализации интерфейса <see cref="T:System.CodeDom.Compiler.ICodeGenerator" />. Это абстрактный класс.</summary>
	// Token: 0x02000345 RID: 837
	public abstract class CodeGenerator : ICodeGenerator
	{
		/// <summary>Получает объявление типа кода для текущего класса.</summary>
		/// <returns>Объявление типа кода для текущего класса.</returns>
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x00062560 File Offset: 0x00060760
		protected CodeTypeDeclaration CurrentClass
		{
			get
			{
				return this._currentClass;
			}
		}

		/// <summary>Получает имя текущего класса.</summary>
		/// <returns>Имя текущего класса.</returns>
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x00062568 File Offset: 0x00060768
		protected string CurrentTypeName
		{
			get
			{
				if (this._currentClass == null)
				{
					return "<% unknown %>";
				}
				return this._currentClass.Name;
			}
		}

		/// <summary>Получает текущий элемент класса.</summary>
		/// <returns>Текущий член класса.</returns>
		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x00062583 File Offset: 0x00060783
		protected CodeTypeMember CurrentMember
		{
			get
			{
				return this._currentMember;
			}
		}

		/// <summary>Получает имя текущего элемента.</summary>
		/// <returns>Имя текущего члена.</returns>
		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x0006258B File Offset: 0x0006078B
		protected string CurrentMemberName
		{
			get
			{
				if (this._currentMember == null)
				{
					return "<% unknown %>";
				}
				return this._currentMember.Name;
			}
		}

		/// <summary>Получает значение, указывающее, является ли создаваемый в данный момент объект интерфейсом.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий объект является интерфейсом; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x000625A6 File Offset: 0x000607A6
		protected bool IsCurrentInterface
		{
			get
			{
				return this._currentClass != null && !(this._currentClass is CodeTypeDelegate) && this._currentClass.IsInterface;
			}
		}

		/// <summary>Получает значение, указывающее, является ли создаваемый в данный момент объект классом.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий объект является классом; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x000625CA File Offset: 0x000607CA
		protected bool IsCurrentClass
		{
			get
			{
				return this._currentClass != null && !(this._currentClass is CodeTypeDelegate) && this._currentClass.IsClass;
			}
		}

		/// <summary>Получает значение, указывающее, является ли создаваемый объект размерным типом значения или структурой.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий объект является типом значения или структурой; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x000625EE File Offset: 0x000607EE
		protected bool IsCurrentStruct
		{
			get
			{
				return this._currentClass != null && !(this._currentClass is CodeTypeDelegate) && this._currentClass.IsStruct;
			}
		}

		/// <summary>Получает значение, указывающее, является ли создаваемый в данный момент объект перечислением.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий объект является перечислением; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x00062612 File Offset: 0x00060812
		protected bool IsCurrentEnum
		{
			get
			{
				return this._currentClass != null && !(this._currentClass is CodeTypeDelegate) && this._currentClass.IsEnum;
			}
		}

		/// <summary>Получает значение, указывающее, является ли создаваемый в данный момент объект делегатом.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий объект является делегатом; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x00062636 File Offset: 0x00060836
		protected bool IsCurrentDelegate
		{
			get
			{
				return this._currentClass != null && this._currentClass is CodeTypeDelegate;
			}
		}

		/// <summary>Возвращает или задает количество пробелов для каждого уровня отступа.</summary>
		/// <returns>Количество пробелов для каждого уровня отступа.</returns>
		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x00062650 File Offset: 0x00060850
		// (set) Token: 0x06001AC7 RID: 6855 RVA: 0x0006265D File Offset: 0x0006085D
		protected int Indent
		{
			get
			{
				return this._output.Indent;
			}
			set
			{
				this._output.Indent = value;
			}
		}

		/// <summary>Получает токен, представляющий <see langword="null" />.</summary>
		/// <returns>Лексема, представляющая <see langword="null" />.</returns>
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001AC8 RID: 6856
		protected abstract string NullToken { get; }

		/// <summary>Получает модуль записи текста, предназначенный для вывода данных.</summary>
		/// <returns>Модуль записи текста, предназначенный для вывода данных.</returns>
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x0006266B File Offset: 0x0006086B
		protected TextWriter Output
		{
			get
			{
				return this._output;
			}
		}

		/// <summary>Получает параметры для использования генератором кода.</summary>
		/// <returns>Объект, который указывает параметры, предназначенные для использования генератором кода.</returns>
		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x00062673 File Offset: 0x00060873
		protected CodeGeneratorOptions Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0006267C File Offset: 0x0006087C
		private void GenerateType(CodeTypeDeclaration e)
		{
			this._currentClass = e;
			if (e.StartDirectives.Count > 0)
			{
				this.GenerateDirectives(e.StartDirectives);
			}
			this.GenerateCommentStatements(e.Comments);
			if (e.LinePragma != null)
			{
				this.GenerateLinePragmaStart(e.LinePragma);
			}
			this.GenerateTypeStart(e);
			if (this.Options.VerbatimOrder)
			{
				using (IEnumerator enumerator = e.Members.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						CodeTypeMember member = (CodeTypeMember)obj;
						this.GenerateTypeMember(member, e);
					}
					goto IL_CA;
				}
			}
			this.GenerateFields(e);
			this.GenerateSnippetMembers(e);
			this.GenerateTypeConstructors(e);
			this.GenerateConstructors(e);
			this.GenerateProperties(e);
			this.GenerateEvents(e);
			this.GenerateMethods(e);
			this.GenerateNestedTypes(e);
			IL_CA:
			this._currentClass = e;
			this.GenerateTypeEnd(e);
			if (e.LinePragma != null)
			{
				this.GenerateLinePragmaEnd(e.LinePragma);
			}
			if (e.EndDirectives.Count > 0)
			{
				this.GenerateDirectives(e.EndDirectives);
			}
		}

		/// <summary>Создает код для указанных директив кода.</summary>
		/// <param name="directives">Директивы кода, для которых необходимо создать код.</param>
		// Token: 0x06001ACC RID: 6860 RVA: 0x00003917 File Offset: 0x00001B17
		protected virtual void GenerateDirectives(CodeDirectiveCollection directives)
		{
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x000627A0 File Offset: 0x000609A0
		private void GenerateTypeMember(CodeTypeMember member, CodeTypeDeclaration declaredType)
		{
			if (this._options.BlankLinesBetweenMembers)
			{
				this.Output.WriteLine();
			}
			if (member is CodeTypeDeclaration)
			{
				((ICodeGenerator)this).GenerateCodeFromType((CodeTypeDeclaration)member, this._output.InnerWriter, this._options);
				this._currentClass = declaredType;
				return;
			}
			if (member.StartDirectives.Count > 0)
			{
				this.GenerateDirectives(member.StartDirectives);
			}
			this.GenerateCommentStatements(member.Comments);
			if (member.LinePragma != null)
			{
				this.GenerateLinePragmaStart(member.LinePragma);
			}
			if (member is CodeMemberField)
			{
				this.GenerateField((CodeMemberField)member);
			}
			else if (member is CodeMemberProperty)
			{
				this.GenerateProperty((CodeMemberProperty)member, declaredType);
			}
			else if (member is CodeMemberMethod)
			{
				if (member is CodeConstructor)
				{
					this.GenerateConstructor((CodeConstructor)member, declaredType);
				}
				else if (member is CodeTypeConstructor)
				{
					this.GenerateTypeConstructor((CodeTypeConstructor)member);
				}
				else if (member is CodeEntryPointMethod)
				{
					this.GenerateEntryPointMethod((CodeEntryPointMethod)member, declaredType);
				}
				else
				{
					this.GenerateMethod((CodeMemberMethod)member, declaredType);
				}
			}
			else if (member is CodeMemberEvent)
			{
				this.GenerateEvent((CodeMemberEvent)member, declaredType);
			}
			else if (member is CodeSnippetTypeMember)
			{
				int indent = this.Indent;
				this.Indent = 0;
				this.GenerateSnippetMember((CodeSnippetTypeMember)member);
				this.Indent = indent;
				this.Output.WriteLine();
			}
			if (member.LinePragma != null)
			{
				this.GenerateLinePragmaEnd(member.LinePragma);
			}
			if (member.EndDirectives.Count > 0)
			{
				this.GenerateDirectives(member.EndDirectives);
			}
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00062938 File Offset: 0x00060B38
		private void GenerateTypeConstructors(CodeTypeDeclaration e)
		{
			foreach (object obj in e.Members)
			{
				CodeTypeMember codeTypeMember = (CodeTypeMember)obj;
				if (codeTypeMember is CodeTypeConstructor)
				{
					this._currentMember = codeTypeMember;
					if (this._options.BlankLinesBetweenMembers)
					{
						this.Output.WriteLine();
					}
					if (this._currentMember.StartDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.StartDirectives);
					}
					this.GenerateCommentStatements(this._currentMember.Comments);
					CodeTypeConstructor codeTypeConstructor = (CodeTypeConstructor)codeTypeMember;
					if (codeTypeConstructor.LinePragma != null)
					{
						this.GenerateLinePragmaStart(codeTypeConstructor.LinePragma);
					}
					this.GenerateTypeConstructor(codeTypeConstructor);
					if (codeTypeConstructor.LinePragma != null)
					{
						this.GenerateLinePragmaEnd(codeTypeConstructor.LinePragma);
					}
					if (this._currentMember.EndDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.EndDirectives);
					}
				}
			}
		}

		/// <summary>Создает код для пространств имен в указанной единице компиляции.</summary>
		/// <param name="e">Единица компиляции, для которой необходимо создать пространства имен.</param>
		// Token: 0x06001ACF RID: 6863 RVA: 0x00062A4C File Offset: 0x00060C4C
		protected void GenerateNamespaces(CodeCompileUnit e)
		{
			foreach (object obj in e.Namespaces)
			{
				CodeNamespace e2 = (CodeNamespace)obj;
				((ICodeGenerator)this).GenerateCodeFromNamespace(e2, this._output.InnerWriter, this._options);
			}
		}

		/// <summary>Создает код для указанного пространства имен и содержащихся в нем классов.</summary>
		/// <param name="e">Пространство имен, для которого необходимо создать классы.</param>
		// Token: 0x06001AD0 RID: 6864 RVA: 0x00062AB8 File Offset: 0x00060CB8
		protected void GenerateTypes(CodeNamespace e)
		{
			foreach (object obj in e.Types)
			{
				CodeTypeDeclaration e2 = (CodeTypeDeclaration)obj;
				if (this._options.BlankLinesBetweenMembers)
				{
					this.Output.WriteLine();
				}
				((ICodeGenerator)this).GenerateCodeFromType(e2, this._output.InnerWriter, this._options);
			}
		}

		/// <summary>Получает значение, показывающее, предоставляет ли генератор поддержку средств языка, представленных указанным объектом <see cref="T:System.CodeDom.Compiler.GeneratorSupport" />.</summary>
		/// <param name="support">Возможности, на наличие которых следует проверить генератор.</param>
		/// <returns>
		///   <see langword="true" />, если указанные возможности поддерживаются; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001AD1 RID: 6865 RVA: 0x00062B3C File Offset: 0x00060D3C
		bool ICodeGenerator.Supports(GeneratorSupport support)
		{
			return this.Supports(support);
		}

		/// <summary>Формирует код для указанного объявления типа Code Document Object Model (CodeDOM) и выводит его в определенный модуль записи текста, используя заданные параметры.</summary>
		/// <param name="e">Тип, для которого формируется код.</param>
		/// <param name="w">Модуль записи текста для вывода кода.</param>
		/// <param name="o">Параметры, используемые для создания кода.</param>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="w" /> недоступен. Возможно, параметр <paramref name="w" /> закрыт до вызова метода.</exception>
		// Token: 0x06001AD2 RID: 6866 RVA: 0x00062B48 File Offset: 0x00060D48
		void ICodeGenerator.GenerateCodeFromType(CodeTypeDeclaration e, TextWriter w, CodeGeneratorOptions o)
		{
			bool flag = false;
			if (this._output != null && w != this._output.InnerWriter)
			{
				throw new InvalidOperationException("The output writer for code generation and the writer supplied don't match and cannot be used. This is generally caused by a bad implementation of a CodeGenerator derived class.");
			}
			if (this._output == null)
			{
				flag = true;
				this._options = (o ?? new CodeGeneratorOptions());
				this._output = new ExposedTabStringIndentedTextWriter(w, this._options.IndentString);
			}
			try
			{
				this.GenerateType(e);
			}
			finally
			{
				if (flag)
				{
					this._output = null;
					this._options = null;
				}
			}
		}

		/// <summary>Формирует код для указанного выражения Code Document Object Model (CodeDOM) и выводит его в определенный модуль записи текста.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		/// <param name="w">Модуль записи текста для вывода кода.</param>
		/// <param name="o">Параметры, используемые для создания кода.</param>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="w" /> недоступен. Возможно, параметр <paramref name="w" /> закрыт до вызова метода.</exception>
		// Token: 0x06001AD3 RID: 6867 RVA: 0x00062BD8 File Offset: 0x00060DD8
		void ICodeGenerator.GenerateCodeFromExpression(CodeExpression e, TextWriter w, CodeGeneratorOptions o)
		{
			bool flag = false;
			if (this._output != null && w != this._output.InnerWriter)
			{
				throw new InvalidOperationException("The output writer for code generation and the writer supplied don't match and cannot be used. This is generally caused by a bad implementation of a CodeGenerator derived class.");
			}
			if (this._output == null)
			{
				flag = true;
				this._options = (o ?? new CodeGeneratorOptions());
				this._output = new ExposedTabStringIndentedTextWriter(w, this._options.IndentString);
			}
			try
			{
				this.GenerateExpression(e);
			}
			finally
			{
				if (flag)
				{
					this._output = null;
					this._options = null;
				}
			}
		}

		/// <summary>Создает код для указанной единицы компиляции Code Document Object Model (CodeDOM) и выводит его в указанный текстовый редактор, используя указанные параметры.</summary>
		/// <param name="e">Единица компиляции CodeDOM, для которой создается код.</param>
		/// <param name="w">Модуль записи текста для вывода кода.</param>
		/// <param name="o">Параметры, используемые для создания кода.</param>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="w" /> недоступен. Возможно, параметр <paramref name="w" /> закрыт до вызова метода.</exception>
		// Token: 0x06001AD4 RID: 6868 RVA: 0x00062C68 File Offset: 0x00060E68
		void ICodeGenerator.GenerateCodeFromCompileUnit(CodeCompileUnit e, TextWriter w, CodeGeneratorOptions o)
		{
			bool flag = false;
			if (this._output != null && w != this._output.InnerWriter)
			{
				throw new InvalidOperationException("The output writer for code generation and the writer supplied don't match and cannot be used. This is generally caused by a bad implementation of a CodeGenerator derived class.");
			}
			if (this._output == null)
			{
				flag = true;
				this._options = (o ?? new CodeGeneratorOptions());
				this._output = new ExposedTabStringIndentedTextWriter(w, this._options.IndentString);
			}
			try
			{
				if (e is CodeSnippetCompileUnit)
				{
					this.GenerateSnippetCompileUnit((CodeSnippetCompileUnit)e);
				}
				else
				{
					this.GenerateCompileUnit(e);
				}
			}
			finally
			{
				if (flag)
				{
					this._output = null;
					this._options = null;
				}
			}
		}

		/// <summary>Формирует код для указанного пространства имен Code Document Object Model (CodeDOM) и выводит его в определенный модуль записи текста, используя заданные параметры.</summary>
		/// <param name="e">Пространство имен, для которого формируется код.</param>
		/// <param name="w">Модуль записи текста для вывода кода.</param>
		/// <param name="o">Параметры, используемые для создания кода.</param>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="w" /> недоступен. Возможно, параметр <paramref name="w" /> закрыт до вызова метода.</exception>
		// Token: 0x06001AD5 RID: 6869 RVA: 0x00062D0C File Offset: 0x00060F0C
		void ICodeGenerator.GenerateCodeFromNamespace(CodeNamespace e, TextWriter w, CodeGeneratorOptions o)
		{
			bool flag = false;
			if (this._output != null && w != this._output.InnerWriter)
			{
				throw new InvalidOperationException("The output writer for code generation and the writer supplied don't match and cannot be used. This is generally caused by a bad implementation of a CodeGenerator derived class.");
			}
			if (this._output == null)
			{
				flag = true;
				this._options = (o ?? new CodeGeneratorOptions());
				this._output = new ExposedTabStringIndentedTextWriter(w, this._options.IndentString);
			}
			try
			{
				this.GenerateNamespace(e);
			}
			finally
			{
				if (flag)
				{
					this._output = null;
					this._options = null;
				}
			}
		}

		/// <summary>Формирует код для указанной инструкции Code Document Object Model (CodeDOM) и выводит его в определенный модуль записи текста, используя заданные параметры.</summary>
		/// <param name="e">Инструкция, содержащая элементы CodeDOM, которые необходимо преобразовать.</param>
		/// <param name="w">Модуль записи текста для вывода кода.</param>
		/// <param name="o">Параметры, используемые для создания кода.</param>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="w" /> недоступен. Возможно, параметр <paramref name="w" /> закрыт до вызова метода.</exception>
		// Token: 0x06001AD6 RID: 6870 RVA: 0x00062D9C File Offset: 0x00060F9C
		void ICodeGenerator.GenerateCodeFromStatement(CodeStatement e, TextWriter w, CodeGeneratorOptions o)
		{
			bool flag = false;
			if (this._output != null && w != this._output.InnerWriter)
			{
				throw new InvalidOperationException("The output writer for code generation and the writer supplied don't match and cannot be used. This is generally caused by a bad implementation of a CodeGenerator derived class.");
			}
			if (this._output == null)
			{
				flag = true;
				this._options = (o ?? new CodeGeneratorOptions());
				this._output = new ExposedTabStringIndentedTextWriter(w, this._options.IndentString);
			}
			try
			{
				this.GenerateStatement(e);
			}
			finally
			{
				if (flag)
				{
					this._output = null;
					this._options = null;
				}
			}
		}

		/// <summary>Создает код для заданного члена класса, используя заданные параметры модуля записи текста и генератора кода.</summary>
		/// <param name="member">Член класса, для которого необходимо создать код.</param>
		/// <param name="writer">Модуль записи текста для вывода кода.</param>
		/// <param name="options">Параметры, которые следует использовать при создании кода.</param>
		/// <exception cref="T:System.InvalidOperationException">Свойство <see cref="P:System.CodeDom.Compiler.CodeGenerator.Output" /> не равно <see langword="null" />.</exception>
		// Token: 0x06001AD7 RID: 6871 RVA: 0x00062E2C File Offset: 0x0006102C
		public virtual void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options)
		{
			if (this._output != null)
			{
				throw new InvalidOperationException("This code generation API cannot be called while the generator is being used to generate something else.");
			}
			this._options = (options ?? new CodeGeneratorOptions());
			this._output = new ExposedTabStringIndentedTextWriter(writer, this._options.IndentString);
			try
			{
				CodeTypeDeclaration codeTypeDeclaration = new CodeTypeDeclaration();
				this._currentClass = codeTypeDeclaration;
				this.GenerateTypeMember(member, codeTypeDeclaration);
			}
			finally
			{
				this._currentClass = null;
				this._output = null;
				this._options = null;
			}
		}

		/// <summary>Получает значение, показывающее, является ли указанное значение допустимым идентификатором для текущего языка.</summary>
		/// <param name="value">Значение для тестирования.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="value" /> является допустимым идентификатором; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001AD8 RID: 6872 RVA: 0x00062EB0 File Offset: 0x000610B0
		bool ICodeGenerator.IsValidIdentifier(string value)
		{
			return this.IsValidIdentifier(value);
		}

		/// <summary>Выбрасывает исключение, если указанное значение не является допустимым идентификатором.</summary>
		/// <param name="value">Идентификатор для проверки на допустимость.</param>
		// Token: 0x06001AD9 RID: 6873 RVA: 0x00062EB9 File Offset: 0x000610B9
		void ICodeGenerator.ValidateIdentifier(string value)
		{
			this.ValidateIdentifier(value);
		}

		/// <summary>Создает Escape-идентификатор для заданного значения.</summary>
		/// <param name="value">Строка, для которой создается Escape-идентификатор.</param>
		/// <returns>Escape-идентификатор для данного значения.</returns>
		// Token: 0x06001ADA RID: 6874 RVA: 0x00062EC2 File Offset: 0x000610C2
		string ICodeGenerator.CreateEscapedIdentifier(string value)
		{
			return this.CreateEscapedIdentifier(value);
		}

		/// <summary>Создает допустимый идентификатор для указанного значения.</summary>
		/// <param name="value">Строка, для которой создается допустимый идентификатор.</param>
		/// <returns>Допустимый идентификатор для указанного значения.</returns>
		// Token: 0x06001ADB RID: 6875 RVA: 0x00062ECB File Offset: 0x000610CB
		string ICodeGenerator.CreateValidIdentifier(string value)
		{
			return this.CreateValidIdentifier(value);
		}

		/// <summary>Получает тип, на который указывает заданный объект <see cref="T:System.CodeDom.CodeTypeReference" />.</summary>
		/// <param name="type">Возвращаемый тип.</param>
		/// <returns>Имя ссылки на тип данных.</returns>
		// Token: 0x06001ADC RID: 6876 RVA: 0x00062ED4 File Offset: 0x000610D4
		string ICodeGenerator.GetTypeOutput(CodeTypeReference type)
		{
			return this.GetTypeOutput(type);
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00062EE0 File Offset: 0x000610E0
		private void GenerateConstructors(CodeTypeDeclaration e)
		{
			foreach (object obj in e.Members)
			{
				CodeTypeMember codeTypeMember = (CodeTypeMember)obj;
				if (codeTypeMember is CodeConstructor)
				{
					this._currentMember = codeTypeMember;
					if (this._options.BlankLinesBetweenMembers)
					{
						this.Output.WriteLine();
					}
					if (this._currentMember.StartDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.StartDirectives);
					}
					this.GenerateCommentStatements(this._currentMember.Comments);
					CodeConstructor codeConstructor = (CodeConstructor)codeTypeMember;
					if (codeConstructor.LinePragma != null)
					{
						this.GenerateLinePragmaStart(codeConstructor.LinePragma);
					}
					this.GenerateConstructor(codeConstructor, e);
					if (codeConstructor.LinePragma != null)
					{
						this.GenerateLinePragmaEnd(codeConstructor.LinePragma);
					}
					if (this._currentMember.EndDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.EndDirectives);
					}
				}
			}
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00062FF4 File Offset: 0x000611F4
		private void GenerateEvents(CodeTypeDeclaration e)
		{
			foreach (object obj in e.Members)
			{
				CodeTypeMember codeTypeMember = (CodeTypeMember)obj;
				if (codeTypeMember is CodeMemberEvent)
				{
					this._currentMember = codeTypeMember;
					if (this._options.BlankLinesBetweenMembers)
					{
						this.Output.WriteLine();
					}
					if (this._currentMember.StartDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.StartDirectives);
					}
					this.GenerateCommentStatements(this._currentMember.Comments);
					CodeMemberEvent codeMemberEvent = (CodeMemberEvent)codeTypeMember;
					if (codeMemberEvent.LinePragma != null)
					{
						this.GenerateLinePragmaStart(codeMemberEvent.LinePragma);
					}
					this.GenerateEvent(codeMemberEvent, e);
					if (codeMemberEvent.LinePragma != null)
					{
						this.GenerateLinePragmaEnd(codeMemberEvent.LinePragma);
					}
					if (this._currentMember.EndDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.EndDirectives);
					}
				}
			}
		}

		/// <summary>Создает код для указанного выражения кода.</summary>
		/// <param name="e">Выражение кода, для которого необходимо создать код.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="e" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="e" /> не является допустимым <see cref="T:System.CodeDom.CodeStatement" />.</exception>
		// Token: 0x06001ADF RID: 6879 RVA: 0x00063108 File Offset: 0x00061308
		protected void GenerateExpression(CodeExpression e)
		{
			if (e is CodeArrayCreateExpression)
			{
				this.GenerateArrayCreateExpression((CodeArrayCreateExpression)e);
				return;
			}
			if (e is CodeBaseReferenceExpression)
			{
				this.GenerateBaseReferenceExpression((CodeBaseReferenceExpression)e);
				return;
			}
			if (e is CodeBinaryOperatorExpression)
			{
				this.GenerateBinaryOperatorExpression((CodeBinaryOperatorExpression)e);
				return;
			}
			if (e is CodeCastExpression)
			{
				this.GenerateCastExpression((CodeCastExpression)e);
				return;
			}
			if (e is CodeDelegateCreateExpression)
			{
				this.GenerateDelegateCreateExpression((CodeDelegateCreateExpression)e);
				return;
			}
			if (e is CodeFieldReferenceExpression)
			{
				this.GenerateFieldReferenceExpression((CodeFieldReferenceExpression)e);
				return;
			}
			if (e is CodeArgumentReferenceExpression)
			{
				this.GenerateArgumentReferenceExpression((CodeArgumentReferenceExpression)e);
				return;
			}
			if (e is CodeVariableReferenceExpression)
			{
				this.GenerateVariableReferenceExpression((CodeVariableReferenceExpression)e);
				return;
			}
			if (e is CodeIndexerExpression)
			{
				this.GenerateIndexerExpression((CodeIndexerExpression)e);
				return;
			}
			if (e is CodeArrayIndexerExpression)
			{
				this.GenerateArrayIndexerExpression((CodeArrayIndexerExpression)e);
				return;
			}
			if (e is CodeSnippetExpression)
			{
				this.GenerateSnippetExpression((CodeSnippetExpression)e);
				return;
			}
			if (e is CodeMethodInvokeExpression)
			{
				this.GenerateMethodInvokeExpression((CodeMethodInvokeExpression)e);
				return;
			}
			if (e is CodeMethodReferenceExpression)
			{
				this.GenerateMethodReferenceExpression((CodeMethodReferenceExpression)e);
				return;
			}
			if (e is CodeEventReferenceExpression)
			{
				this.GenerateEventReferenceExpression((CodeEventReferenceExpression)e);
				return;
			}
			if (e is CodeDelegateInvokeExpression)
			{
				this.GenerateDelegateInvokeExpression((CodeDelegateInvokeExpression)e);
				return;
			}
			if (e is CodeObjectCreateExpression)
			{
				this.GenerateObjectCreateExpression((CodeObjectCreateExpression)e);
				return;
			}
			if (e is CodeParameterDeclarationExpression)
			{
				this.GenerateParameterDeclarationExpression((CodeParameterDeclarationExpression)e);
				return;
			}
			if (e is CodeDirectionExpression)
			{
				this.GenerateDirectionExpression((CodeDirectionExpression)e);
				return;
			}
			if (e is CodePrimitiveExpression)
			{
				this.GeneratePrimitiveExpression((CodePrimitiveExpression)e);
				return;
			}
			if (e is CodePropertyReferenceExpression)
			{
				this.GeneratePropertyReferenceExpression((CodePropertyReferenceExpression)e);
				return;
			}
			if (e is CodePropertySetValueReferenceExpression)
			{
				this.GeneratePropertySetValueReferenceExpression((CodePropertySetValueReferenceExpression)e);
				return;
			}
			if (e is CodeThisReferenceExpression)
			{
				this.GenerateThisReferenceExpression((CodeThisReferenceExpression)e);
				return;
			}
			if (e is CodeTypeReferenceExpression)
			{
				this.GenerateTypeReferenceExpression((CodeTypeReferenceExpression)e);
				return;
			}
			if (e is CodeTypeOfExpression)
			{
				this.GenerateTypeOfExpression((CodeTypeOfExpression)e);
				return;
			}
			if (e is CodeDefaultValueExpression)
			{
				this.GenerateDefaultValueExpression((CodeDefaultValueExpression)e);
				return;
			}
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			throw new ArgumentException(SR.Format("Element type {0} is not supported.", e.GetType().FullName), "e");
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00063350 File Offset: 0x00061550
		private void GenerateFields(CodeTypeDeclaration e)
		{
			foreach (object obj in e.Members)
			{
				CodeTypeMember codeTypeMember = (CodeTypeMember)obj;
				if (codeTypeMember is CodeMemberField)
				{
					this._currentMember = codeTypeMember;
					if (this._options.BlankLinesBetweenMembers)
					{
						this.Output.WriteLine();
					}
					if (this._currentMember.StartDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.StartDirectives);
					}
					this.GenerateCommentStatements(this._currentMember.Comments);
					CodeMemberField codeMemberField = (CodeMemberField)codeTypeMember;
					if (codeMemberField.LinePragma != null)
					{
						this.GenerateLinePragmaStart(codeMemberField.LinePragma);
					}
					this.GenerateField(codeMemberField);
					if (codeMemberField.LinePragma != null)
					{
						this.GenerateLinePragmaEnd(codeMemberField.LinePragma);
					}
					if (this._currentMember.EndDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.EndDirectives);
					}
				}
			}
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00063464 File Offset: 0x00061664
		private void GenerateSnippetMembers(CodeTypeDeclaration e)
		{
			bool flag = false;
			foreach (object obj in e.Members)
			{
				CodeTypeMember codeTypeMember = (CodeTypeMember)obj;
				if (codeTypeMember is CodeSnippetTypeMember)
				{
					flag = true;
					this._currentMember = codeTypeMember;
					if (this._options.BlankLinesBetweenMembers)
					{
						this.Output.WriteLine();
					}
					if (this._currentMember.StartDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.StartDirectives);
					}
					this.GenerateCommentStatements(this._currentMember.Comments);
					CodeSnippetTypeMember codeSnippetTypeMember = (CodeSnippetTypeMember)codeTypeMember;
					if (codeSnippetTypeMember.LinePragma != null)
					{
						this.GenerateLinePragmaStart(codeSnippetTypeMember.LinePragma);
					}
					int indent = this.Indent;
					this.Indent = 0;
					this.GenerateSnippetMember(codeSnippetTypeMember);
					this.Indent = indent;
					if (codeSnippetTypeMember.LinePragma != null)
					{
						this.GenerateLinePragmaEnd(codeSnippetTypeMember.LinePragma);
					}
					if (this._currentMember.EndDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.EndDirectives);
					}
				}
			}
			if (flag)
			{
				this.Output.WriteLine();
			}
		}

		/// <summary>Выводит код указанной единицы компиляции фрагмента исходного кода.</summary>
		/// <param name="e">Единица компиляции литерального фрагмента исходного кода, для которой необходимо создать код.</param>
		// Token: 0x06001AE2 RID: 6882 RVA: 0x000635A4 File Offset: 0x000617A4
		protected virtual void GenerateSnippetCompileUnit(CodeSnippetCompileUnit e)
		{
			this.GenerateDirectives(e.StartDirectives);
			if (e.LinePragma != null)
			{
				this.GenerateLinePragmaStart(e.LinePragma);
			}
			this.Output.WriteLine(e.Value);
			if (e.LinePragma != null)
			{
				this.GenerateLinePragmaEnd(e.LinePragma);
			}
			if (e.EndDirectives.Count > 0)
			{
				this.GenerateDirectives(e.EndDirectives);
			}
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00063610 File Offset: 0x00061810
		private void GenerateMethods(CodeTypeDeclaration e)
		{
			foreach (object obj in e.Members)
			{
				CodeTypeMember codeTypeMember = (CodeTypeMember)obj;
				if (codeTypeMember is CodeMemberMethod && !(codeTypeMember is CodeTypeConstructor) && !(codeTypeMember is CodeConstructor))
				{
					this._currentMember = codeTypeMember;
					if (this._options.BlankLinesBetweenMembers)
					{
						this.Output.WriteLine();
					}
					if (this._currentMember.StartDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.StartDirectives);
					}
					this.GenerateCommentStatements(this._currentMember.Comments);
					CodeMemberMethod codeMemberMethod = (CodeMemberMethod)codeTypeMember;
					if (codeMemberMethod.LinePragma != null)
					{
						this.GenerateLinePragmaStart(codeMemberMethod.LinePragma);
					}
					if (codeTypeMember is CodeEntryPointMethod)
					{
						this.GenerateEntryPointMethod((CodeEntryPointMethod)codeTypeMember, e);
					}
					else
					{
						this.GenerateMethod(codeMemberMethod, e);
					}
					if (codeMemberMethod.LinePragma != null)
					{
						this.GenerateLinePragmaEnd(codeMemberMethod.LinePragma);
					}
					if (this._currentMember.EndDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.EndDirectives);
					}
				}
			}
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0006375C File Offset: 0x0006195C
		private void GenerateNestedTypes(CodeTypeDeclaration e)
		{
			foreach (object obj in e.Members)
			{
				CodeTypeMember codeTypeMember = (CodeTypeMember)obj;
				if (codeTypeMember is CodeTypeDeclaration)
				{
					if (this._options.BlankLinesBetweenMembers)
					{
						this.Output.WriteLine();
					}
					CodeTypeDeclaration e2 = (CodeTypeDeclaration)codeTypeMember;
					((ICodeGenerator)this).GenerateCodeFromType(e2, this._output.InnerWriter, this._options);
				}
			}
		}

		/// <summary>Создает код для указанной единицы компиляции.</summary>
		/// <param name="e">Единица компиляции, для которой необходимо создать код.</param>
		// Token: 0x06001AE5 RID: 6885 RVA: 0x000637F0 File Offset: 0x000619F0
		protected virtual void GenerateCompileUnit(CodeCompileUnit e)
		{
			this.GenerateCompileUnitStart(e);
			this.GenerateNamespaces(e);
			this.GenerateCompileUnitEnd(e);
		}

		/// <summary>Создает код для указанного пространства имен.</summary>
		/// <param name="e">Пространство имен, для которого формируется код.</param>
		// Token: 0x06001AE6 RID: 6886 RVA: 0x00063807 File Offset: 0x00061A07
		protected virtual void GenerateNamespace(CodeNamespace e)
		{
			this.GenerateCommentStatements(e.Comments);
			this.GenerateNamespaceStart(e);
			this.GenerateNamespaceImports(e);
			this.Output.WriteLine();
			this.GenerateTypes(e);
			this.GenerateNamespaceEnd(e);
		}

		/// <summary>Создает код для указанного импорта пространства имен.</summary>
		/// <param name="e">Импорт пространства имен, для которого необходимо создать код.</param>
		// Token: 0x06001AE7 RID: 6887 RVA: 0x0006383C File Offset: 0x00061A3C
		protected void GenerateNamespaceImports(CodeNamespace e)
		{
			foreach (object obj in e.Imports)
			{
				CodeNamespaceImport codeNamespaceImport = (CodeNamespaceImport)obj;
				if (codeNamespaceImport.LinePragma != null)
				{
					this.GenerateLinePragmaStart(codeNamespaceImport.LinePragma);
				}
				this.GenerateNamespaceImport(codeNamespaceImport);
				if (codeNamespaceImport.LinePragma != null)
				{
					this.GenerateLinePragmaEnd(codeNamespaceImport.LinePragma);
				}
			}
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x000638C0 File Offset: 0x00061AC0
		private void GenerateProperties(CodeTypeDeclaration e)
		{
			foreach (object obj in e.Members)
			{
				CodeTypeMember codeTypeMember = (CodeTypeMember)obj;
				if (codeTypeMember is CodeMemberProperty)
				{
					this._currentMember = codeTypeMember;
					if (this._options.BlankLinesBetweenMembers)
					{
						this.Output.WriteLine();
					}
					if (this._currentMember.StartDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.StartDirectives);
					}
					this.GenerateCommentStatements(this._currentMember.Comments);
					CodeMemberProperty codeMemberProperty = (CodeMemberProperty)codeTypeMember;
					if (codeMemberProperty.LinePragma != null)
					{
						this.GenerateLinePragmaStart(codeMemberProperty.LinePragma);
					}
					this.GenerateProperty(codeMemberProperty, e);
					if (codeMemberProperty.LinePragma != null)
					{
						this.GenerateLinePragmaEnd(codeMemberProperty.LinePragma);
					}
					if (this._currentMember.EndDirectives.Count > 0)
					{
						this.GenerateDirectives(this._currentMember.EndDirectives);
					}
				}
			}
		}

		/// <summary>Создает код для указанного оператора.</summary>
		/// <param name="e">Оператор, для которого необходимо создать код.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="e" /> не является допустимым <see cref="T:System.CodeDom.CodeStatement" />.</exception>
		// Token: 0x06001AE9 RID: 6889 RVA: 0x000639D4 File Offset: 0x00061BD4
		protected void GenerateStatement(CodeStatement e)
		{
			if (e.StartDirectives.Count > 0)
			{
				this.GenerateDirectives(e.StartDirectives);
			}
			if (e.LinePragma != null)
			{
				this.GenerateLinePragmaStart(e.LinePragma);
			}
			if (e is CodeCommentStatement)
			{
				this.GenerateCommentStatement((CodeCommentStatement)e);
			}
			else if (e is CodeMethodReturnStatement)
			{
				this.GenerateMethodReturnStatement((CodeMethodReturnStatement)e);
			}
			else if (e is CodeConditionStatement)
			{
				this.GenerateConditionStatement((CodeConditionStatement)e);
			}
			else if (e is CodeTryCatchFinallyStatement)
			{
				this.GenerateTryCatchFinallyStatement((CodeTryCatchFinallyStatement)e);
			}
			else if (e is CodeAssignStatement)
			{
				this.GenerateAssignStatement((CodeAssignStatement)e);
			}
			else if (e is CodeExpressionStatement)
			{
				this.GenerateExpressionStatement((CodeExpressionStatement)e);
			}
			else if (e is CodeIterationStatement)
			{
				this.GenerateIterationStatement((CodeIterationStatement)e);
			}
			else if (e is CodeThrowExceptionStatement)
			{
				this.GenerateThrowExceptionStatement((CodeThrowExceptionStatement)e);
			}
			else if (e is CodeSnippetStatement)
			{
				int indent = this.Indent;
				this.Indent = 0;
				this.GenerateSnippetStatement((CodeSnippetStatement)e);
				this.Indent = indent;
			}
			else if (e is CodeVariableDeclarationStatement)
			{
				this.GenerateVariableDeclarationStatement((CodeVariableDeclarationStatement)e);
			}
			else if (e is CodeAttachEventStatement)
			{
				this.GenerateAttachEventStatement((CodeAttachEventStatement)e);
			}
			else if (e is CodeRemoveEventStatement)
			{
				this.GenerateRemoveEventStatement((CodeRemoveEventStatement)e);
			}
			else if (e is CodeGotoStatement)
			{
				this.GenerateGotoStatement((CodeGotoStatement)e);
			}
			else
			{
				if (!(e is CodeLabeledStatement))
				{
					throw new ArgumentException(SR.Format("Element type {0} is not supported.", e.GetType().FullName), "e");
				}
				this.GenerateLabeledStatement((CodeLabeledStatement)e);
			}
			if (e.LinePragma != null)
			{
				this.GenerateLinePragmaEnd(e.LinePragma);
			}
			if (e.EndDirectives.Count > 0)
			{
				this.GenerateDirectives(e.EndDirectives);
			}
		}

		/// <summary>Создает код для указанной коллекции операторов.</summary>
		/// <param name="stms">Операторы, для которых необходимо создать код.</param>
		// Token: 0x06001AEA RID: 6890 RVA: 0x00063BC4 File Offset: 0x00061DC4
		protected void GenerateStatements(CodeStatementCollection stmts)
		{
			foreach (object obj in stmts)
			{
				CodeStatement e = (CodeStatement)obj;
				((ICodeGenerator)this).GenerateCodeFromStatement(e, this._output.InnerWriter, this._options);
			}
		}

		/// <summary>Создает код для указанной коллекции объявлений атрибута.</summary>
		/// <param name="attributes">Атрибуты, для которых необходимо создать код.</param>
		// Token: 0x06001AEB RID: 6891 RVA: 0x00063C2C File Offset: 0x00061E2C
		protected virtual void OutputAttributeDeclarations(CodeAttributeDeclarationCollection attributes)
		{
			if (attributes.Count == 0)
			{
				return;
			}
			this.GenerateAttributeDeclarationsStart(attributes);
			bool flag = true;
			foreach (object obj in attributes)
			{
				CodeAttributeDeclaration codeAttributeDeclaration = (CodeAttributeDeclaration)obj;
				if (flag)
				{
					flag = false;
				}
				else
				{
					this.ContinueOnNewLine(", ");
				}
				this.Output.Write(codeAttributeDeclaration.Name);
				this.Output.Write('(');
				bool flag2 = true;
				foreach (object obj2 in codeAttributeDeclaration.Arguments)
				{
					CodeAttributeArgument arg = (CodeAttributeArgument)obj2;
					if (flag2)
					{
						flag2 = false;
					}
					else
					{
						this.Output.Write(", ");
					}
					this.OutputAttributeArgument(arg);
				}
				this.Output.Write(')');
			}
			this.GenerateAttributeDeclarationsEnd(attributes);
		}

		/// <summary>Выводит аргумент в блоке атрибута.</summary>
		/// <param name="arg">Аргумент атрибута, для которого необходимо создать код.</param>
		// Token: 0x06001AEC RID: 6892 RVA: 0x00063D44 File Offset: 0x00061F44
		protected virtual void OutputAttributeArgument(CodeAttributeArgument arg)
		{
			if (!string.IsNullOrEmpty(arg.Name))
			{
				this.OutputIdentifier(arg.Name);
				this.Output.Write('=');
			}
			((ICodeGenerator)this).GenerateCodeFromExpression(arg.Value, this._output.InnerWriter, this._options);
		}

		/// <summary>Создает код для указанного <see cref="T:System.CodeDom.FieldDirection" />.</summary>
		/// <param name="dir">Одно из значений перечисления, обозначающее атрибут поля.</param>
		// Token: 0x06001AED RID: 6893 RVA: 0x00063D94 File Offset: 0x00061F94
		protected virtual void OutputDirection(FieldDirection dir)
		{
			switch (dir)
			{
			case FieldDirection.In:
				break;
			case FieldDirection.Out:
				this.Output.Write("out ");
				return;
			case FieldDirection.Ref:
				this.Output.Write("ref ");
				break;
			default:
				return;
			}
		}

		/// <summary>Выводит модификатор области поля, относящийся к указанным атрибутам.</summary>
		/// <param name="attributes">Одно из значений перечисления, задающее атрибуты.</param>
		// Token: 0x06001AEE RID: 6894 RVA: 0x00063DCC File Offset: 0x00061FCC
		protected virtual void OutputFieldScopeModifier(MemberAttributes attributes)
		{
			if ((attributes & MemberAttributes.VTableMask) == MemberAttributes.New)
			{
				this.Output.Write("new ");
			}
			switch (attributes & MemberAttributes.ScopeMask)
			{
			case MemberAttributes.Final:
			case MemberAttributes.Override:
				break;
			case MemberAttributes.Static:
				this.Output.Write("static ");
				return;
			case MemberAttributes.Const:
				this.Output.Write("const ");
				break;
			default:
				return;
			}
		}

		/// <summary>Создает код для указанного модификатора доступа элемента.</summary>
		/// <param name="attributes">Одно из значений перечисления, обозначающее модификатор доступа к члену, для которого необходимо создать код.</param>
		// Token: 0x06001AEF RID: 6895 RVA: 0x00063E34 File Offset: 0x00062034
		protected virtual void OutputMemberAccessModifier(MemberAttributes attributes)
		{
			MemberAttributes memberAttributes = attributes & MemberAttributes.AccessMask;
			if (memberAttributes <= MemberAttributes.Family)
			{
				if (memberAttributes == MemberAttributes.Assembly)
				{
					this.Output.Write("internal ");
					return;
				}
				if (memberAttributes == MemberAttributes.FamilyAndAssembly)
				{
					this.Output.Write("internal ");
					return;
				}
				if (memberAttributes != MemberAttributes.Family)
				{
					return;
				}
				this.Output.Write("protected ");
				return;
			}
			else
			{
				if (memberAttributes == MemberAttributes.FamilyOrAssembly)
				{
					this.Output.Write("protected internal ");
					return;
				}
				if (memberAttributes == MemberAttributes.Private)
				{
					this.Output.Write("private ");
					return;
				}
				if (memberAttributes != MemberAttributes.Public)
				{
					return;
				}
				this.Output.Write("public ");
				return;
			}
		}

		/// <summary>Создает код для указанного модификатора области элемента.</summary>
		/// <param name="attributes">Одно из значений перечисления, обозначающее модификатор области действия члена, для которого необходимо создать код.</param>
		// Token: 0x06001AF0 RID: 6896 RVA: 0x00063EE8 File Offset: 0x000620E8
		protected virtual void OutputMemberScopeModifier(MemberAttributes attributes)
		{
			if ((attributes & MemberAttributes.VTableMask) == MemberAttributes.New)
			{
				this.Output.Write("new ");
			}
			switch (attributes & MemberAttributes.ScopeMask)
			{
			case MemberAttributes.Abstract:
				this.Output.Write("abstract ");
				return;
			case MemberAttributes.Final:
				this.Output.Write("");
				return;
			case MemberAttributes.Static:
				this.Output.Write("static ");
				return;
			case MemberAttributes.Override:
				this.Output.Write("override ");
				return;
			default:
			{
				MemberAttributes memberAttributes = attributes & MemberAttributes.AccessMask;
				if (memberAttributes == MemberAttributes.Family || memberAttributes == MemberAttributes.Public)
				{
					this.Output.Write("virtual ");
				}
				return;
			}
			}
		}

		/// <summary>Создает код для указанного типа.</summary>
		/// <param name="typeRef">Тип, для которого формируется код.</param>
		// Token: 0x06001AF1 RID: 6897
		protected abstract void OutputType(CodeTypeReference typeRef);

		/// <summary>Создает код для указанных атрибутов типа.</summary>
		/// <param name="attributes">Одно из значений перечисления, обозначающее атрибуты типа, для которых необходимо создать код.</param>
		/// <param name="isStruct">
		///   <see langword="true" />, если тип является структурой; в противном случае — <see langword="false" />.</param>
		/// <param name="isEnum">
		///   <see langword="true" />, если тип является перечислением; в противном случае — <see langword="false" />.</param>
		// Token: 0x06001AF2 RID: 6898 RVA: 0x00063F9C File Offset: 0x0006219C
		protected virtual void OutputTypeAttributes(TypeAttributes attributes, bool isStruct, bool isEnum)
		{
			TypeAttributes typeAttributes = attributes & TypeAttributes.VisibilityMask;
			if (typeAttributes - TypeAttributes.Public > 1)
			{
				if (typeAttributes == TypeAttributes.NestedPrivate)
				{
					this.Output.Write("private ");
				}
			}
			else
			{
				this.Output.Write("public ");
			}
			if (isStruct)
			{
				this.Output.Write("struct ");
				return;
			}
			if (isEnum)
			{
				this.Output.Write("enum ");
				return;
			}
			typeAttributes = (attributes & TypeAttributes.ClassSemanticsMask);
			if (typeAttributes == TypeAttributes.NotPublic)
			{
				if ((attributes & TypeAttributes.Sealed) == TypeAttributes.Sealed)
				{
					this.Output.Write("sealed ");
				}
				if ((attributes & TypeAttributes.Abstract) == TypeAttributes.Abstract)
				{
					this.Output.Write("abstract ");
				}
				this.Output.Write("class ");
				return;
			}
			if (typeAttributes != TypeAttributes.ClassSemanticsMask)
			{
				return;
			}
			this.Output.Write("interface ");
		}

		/// <summary>Создает код для указанной пары, состоящей из типа и имени объекта.</summary>
		/// <param name="typeRef">Тип.</param>
		/// <param name="name">Имя для объекта.</param>
		// Token: 0x06001AF3 RID: 6899 RVA: 0x0006406E File Offset: 0x0006226E
		protected virtual void OutputTypeNamePair(CodeTypeReference typeRef, string name)
		{
			this.OutputType(typeRef);
			this.Output.Write(' ');
			this.OutputIdentifier(name);
		}

		/// <summary>Выводит указанный идентификатор.</summary>
		/// <param name="ident">Идентификатор для вывода.</param>
		// Token: 0x06001AF4 RID: 6900 RVA: 0x0006408B File Offset: 0x0006228B
		protected virtual void OutputIdentifier(string ident)
		{
			this.Output.Write(ident);
		}

		/// <summary>Создает код для указанного списка выражений.</summary>
		/// <param name="expressions">Выражения, для которых необходимо создать код.</param>
		// Token: 0x06001AF5 RID: 6901 RVA: 0x00064099 File Offset: 0x00062299
		protected virtual void OutputExpressionList(CodeExpressionCollection expressions)
		{
			this.OutputExpressionList(expressions, false);
		}

		/// <summary>Создает код для указанного списка выражений.</summary>
		/// <param name="expressions">Выражения, для которых необходимо создать код.</param>
		/// <param name="newlineBetweenItems">
		///   <see langword="true" /> для вставки новой строки после каждого элемента; в противном случае — <see langword="false" />.</param>
		// Token: 0x06001AF6 RID: 6902 RVA: 0x000640A4 File Offset: 0x000622A4
		protected virtual void OutputExpressionList(CodeExpressionCollection expressions, bool newlineBetweenItems)
		{
			bool flag = true;
			int indent = this.Indent;
			this.Indent = indent + 1;
			foreach (object obj in expressions)
			{
				CodeExpression e = (CodeExpression)obj;
				if (flag)
				{
					flag = false;
				}
				else if (newlineBetweenItems)
				{
					this.ContinueOnNewLine(",");
				}
				else
				{
					this.Output.Write(", ");
				}
				((ICodeGenerator)this).GenerateCodeFromExpression(e, this._output.InnerWriter, this._options);
			}
			indent = this.Indent;
			this.Indent = indent - 1;
		}

		/// <summary>Создает код для указанного оператора.</summary>
		/// <param name="op">Оператор, для которого необходимо создать код.</param>
		// Token: 0x06001AF7 RID: 6903 RVA: 0x00064158 File Offset: 0x00062358
		protected virtual void OutputOperator(CodeBinaryOperatorType op)
		{
			switch (op)
			{
			case CodeBinaryOperatorType.Add:
				this.Output.Write('+');
				return;
			case CodeBinaryOperatorType.Subtract:
				this.Output.Write('-');
				return;
			case CodeBinaryOperatorType.Multiply:
				this.Output.Write('*');
				return;
			case CodeBinaryOperatorType.Divide:
				this.Output.Write('/');
				return;
			case CodeBinaryOperatorType.Modulus:
				this.Output.Write('%');
				return;
			case CodeBinaryOperatorType.Assign:
				this.Output.Write('=');
				return;
			case CodeBinaryOperatorType.IdentityInequality:
				this.Output.Write("!=");
				return;
			case CodeBinaryOperatorType.IdentityEquality:
				this.Output.Write("==");
				return;
			case CodeBinaryOperatorType.ValueEquality:
				this.Output.Write("==");
				return;
			case CodeBinaryOperatorType.BitwiseOr:
				this.Output.Write('|');
				return;
			case CodeBinaryOperatorType.BitwiseAnd:
				this.Output.Write('&');
				return;
			case CodeBinaryOperatorType.BooleanOr:
				this.Output.Write("||");
				return;
			case CodeBinaryOperatorType.BooleanAnd:
				this.Output.Write("&&");
				return;
			case CodeBinaryOperatorType.LessThan:
				this.Output.Write('<');
				return;
			case CodeBinaryOperatorType.LessThanOrEqual:
				this.Output.Write("<=");
				return;
			case CodeBinaryOperatorType.GreaterThan:
				this.Output.Write('>');
				return;
			case CodeBinaryOperatorType.GreaterThanOrEqual:
				this.Output.Write(">=");
				return;
			default:
				return;
			}
		}

		/// <summary>Создает код для указанных параметров.</summary>
		/// <param name="parameters">Выражения объявления параметра, для которых необходимо создать код.</param>
		// Token: 0x06001AF8 RID: 6904 RVA: 0x000642B4 File Offset: 0x000624B4
		protected virtual void OutputParameters(CodeParameterDeclarationExpressionCollection parameters)
		{
			bool flag = true;
			bool flag2 = parameters.Count > 15;
			if (flag2)
			{
				this.Indent += 3;
			}
			foreach (object obj in parameters)
			{
				CodeParameterDeclarationExpression e = (CodeParameterDeclarationExpression)obj;
				if (flag)
				{
					flag = false;
				}
				else
				{
					this.Output.Write(", ");
				}
				if (flag2)
				{
					this.ContinueOnNewLine("");
				}
				this.GenerateExpression(e);
			}
			if (flag2)
			{
				this.Indent -= 3;
			}
		}

		/// <summary>Создает код для указанного выражения создания массива.</summary>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeArrayCreateExpression" />, указывающий выражение, для которого создается код.</param>
		// Token: 0x06001AF9 RID: 6905
		protected abstract void GenerateArrayCreateExpression(CodeArrayCreateExpression e);

		/// <summary>Создает код для указанного выражения базовой ссылки.</summary>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeBaseReferenceExpression" />, указывающий выражение, для которого создается код.</param>
		// Token: 0x06001AFA RID: 6906
		protected abstract void GenerateBaseReferenceExpression(CodeBaseReferenceExpression e);

		/// <summary>Создает код для указанного выражения двоичного оператора.</summary>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeBinaryOperatorExpression" />, указывающий выражение, для которого создается код.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="e" /> — <see langword="null" />.</exception>
		// Token: 0x06001AFB RID: 6907 RVA: 0x00064360 File Offset: 0x00062560
		protected virtual void GenerateBinaryOperatorExpression(CodeBinaryOperatorExpression e)
		{
			bool flag = false;
			this.Output.Write('(');
			this.GenerateExpression(e.Left);
			this.Output.Write(' ');
			if (e.Left is CodeBinaryOperatorExpression || e.Right is CodeBinaryOperatorExpression)
			{
				if (!this._inNestedBinary)
				{
					flag = true;
					this._inNestedBinary = true;
					this.Indent += 3;
				}
				this.ContinueOnNewLine("");
			}
			this.OutputOperator(e.Operator);
			this.Output.Write(' ');
			this.GenerateExpression(e.Right);
			this.Output.Write(')');
			if (flag)
			{
				this.Indent -= 3;
				this._inNestedBinary = false;
			}
		}

		/// <summary>Создает знак продолжения строки и переносит строку.</summary>
		/// <param name="st">Строка для записи с новой строки.</param>
		// Token: 0x06001AFC RID: 6908 RVA: 0x00064423 File Offset: 0x00062623
		protected virtual void ContinueOnNewLine(string st)
		{
			this.Output.WriteLine(st);
		}

		/// <summary>Создает код для указанного выражения приведения.</summary>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeCastExpression" />, указывающий выражение, для которого создается код.</param>
		// Token: 0x06001AFD RID: 6909
		protected abstract void GenerateCastExpression(CodeCastExpression e);

		/// <summary>Создает код для указанного выражения создания делегата.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001AFE RID: 6910
		protected abstract void GenerateDelegateCreateExpression(CodeDelegateCreateExpression e);

		/// <summary>Создает код для указанного выражения ссылки на поле.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001AFF RID: 6911
		protected abstract void GenerateFieldReferenceExpression(CodeFieldReferenceExpression e);

		/// <summary>Создает код для указанного выражения ссылки на аргумент.</summary>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeArgumentReferenceExpression" />, указывающий выражение, для которого создается код.</param>
		// Token: 0x06001B00 RID: 6912
		protected abstract void GenerateArgumentReferenceExpression(CodeArgumentReferenceExpression e);

		/// <summary>Создает код для указанного выражения ссылки на переменную.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B01 RID: 6913
		protected abstract void GenerateVariableReferenceExpression(CodeVariableReferenceExpression e);

		/// <summary>Создает код для указанного выражения индексатора.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B02 RID: 6914
		protected abstract void GenerateIndexerExpression(CodeIndexerExpression e);

		/// <summary>Создает код для указанного выражения индексатора массива.</summary>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeArrayIndexerExpression" />, указывающий выражение, для которого создается код.</param>
		// Token: 0x06001B03 RID: 6915
		protected abstract void GenerateArrayIndexerExpression(CodeArrayIndexerExpression e);

		/// <summary>Выводит код указанного выражения, заданного в виде литерального фрагмента кода.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B04 RID: 6916
		protected abstract void GenerateSnippetExpression(CodeSnippetExpression e);

		/// <summary>Создает код для указанного выражения вызова метода.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B05 RID: 6917
		protected abstract void GenerateMethodInvokeExpression(CodeMethodInvokeExpression e);

		/// <summary>Создает код для указанного выражения ссылки на метод.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B06 RID: 6918
		protected abstract void GenerateMethodReferenceExpression(CodeMethodReferenceExpression e);

		/// <summary>Создает код для указанного выражения ссылки на событие.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B07 RID: 6919
		protected abstract void GenerateEventReferenceExpression(CodeEventReferenceExpression e);

		/// <summary>Создает код для указанного выражения вызова делегата.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B08 RID: 6920
		protected abstract void GenerateDelegateInvokeExpression(CodeDelegateInvokeExpression e);

		/// <summary>Создает код для указанного выражения создания объекта.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B09 RID: 6921
		protected abstract void GenerateObjectCreateExpression(CodeObjectCreateExpression e);

		/// <summary>Создает код для указанного выражения объявления параметра.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B0A RID: 6922 RVA: 0x00064434 File Offset: 0x00062634
		protected virtual void GenerateParameterDeclarationExpression(CodeParameterDeclarationExpression e)
		{
			if (e.CustomAttributes.Count > 0)
			{
				this.OutputAttributeDeclarations(e.CustomAttributes);
				this.Output.Write(' ');
			}
			this.OutputDirection(e.Direction);
			this.OutputTypeNamePair(e.Type, e.Name);
		}

		/// <summary>Создает код для указанного направляющего выражения.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B0B RID: 6923 RVA: 0x00064486 File Offset: 0x00062686
		protected virtual void GenerateDirectionExpression(CodeDirectionExpression e)
		{
			this.OutputDirection(e.Direction);
			this.GenerateExpression(e.Expression);
		}

		/// <summary>Создает код для указанного элементарного выражения.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> использует недопустимый тип данных. Допустимы только следующие типы данных: 
		/// – string 
		/// – char 
		/// – byte 
		/// – Int16 
		/// – Int32 
		/// – Int64 
		/// – Single 
		/// – Double 
		/// – Decimal</exception>
		// Token: 0x06001B0C RID: 6924 RVA: 0x000644A0 File Offset: 0x000626A0
		protected virtual void GeneratePrimitiveExpression(CodePrimitiveExpression e)
		{
			if (e.Value == null)
			{
				this.Output.Write(this.NullToken);
				return;
			}
			if (e.Value is string)
			{
				this.Output.Write(this.QuoteSnippetString((string)e.Value));
				return;
			}
			if (e.Value is char)
			{
				this.Output.Write("'" + e.Value.ToString() + "'");
				return;
			}
			if (e.Value is byte)
			{
				this.Output.Write(((byte)e.Value).ToString(CultureInfo.InvariantCulture));
				return;
			}
			if (e.Value is short)
			{
				this.Output.Write(((short)e.Value).ToString(CultureInfo.InvariantCulture));
				return;
			}
			if (e.Value is int)
			{
				this.Output.Write(((int)e.Value).ToString(CultureInfo.InvariantCulture));
				return;
			}
			if (e.Value is long)
			{
				this.Output.Write(((long)e.Value).ToString(CultureInfo.InvariantCulture));
				return;
			}
			if (e.Value is float)
			{
				this.GenerateSingleFloatValue((float)e.Value);
				return;
			}
			if (e.Value is double)
			{
				this.GenerateDoubleValue((double)e.Value);
				return;
			}
			if (e.Value is decimal)
			{
				this.GenerateDecimalValue((decimal)e.Value);
				return;
			}
			if (!(e.Value is bool))
			{
				throw new ArgumentException(SR.Format("Invalid Primitive Type: {0}. Consider using CodeObjectCreateExpression.", e.Value.GetType().ToString()));
			}
			if ((bool)e.Value)
			{
				this.Output.Write("true");
				return;
			}
			this.Output.Write("false");
		}

		/// <summary>Создает код для числа одинарной точности с плавающей запятой.</summary>
		/// <param name="s">Значение, для которого необходимо создать код.</param>
		// Token: 0x06001B0D RID: 6925 RVA: 0x000646A0 File Offset: 0x000628A0
		protected virtual void GenerateSingleFloatValue(float s)
		{
			this.Output.Write(s.ToString("R", CultureInfo.InvariantCulture));
		}

		/// <summary>Создает код для числа двойной точности с плавающей запятой.</summary>
		/// <param name="d">Значение, для которого необходимо создать код.</param>
		// Token: 0x06001B0E RID: 6926 RVA: 0x000646BE File Offset: 0x000628BE
		protected virtual void GenerateDoubleValue(double d)
		{
			this.Output.Write(d.ToString("R", CultureInfo.InvariantCulture));
		}

		/// <summary>Создает код для указанного десятичного значения.</summary>
		/// <param name="d">Десятичное значение, для которого создается код.</param>
		// Token: 0x06001B0F RID: 6927 RVA: 0x000646DC File Offset: 0x000628DC
		protected virtual void GenerateDecimalValue(decimal d)
		{
			this.Output.Write(d.ToString(CultureInfo.InvariantCulture));
		}

		/// <summary>Создает код для заданной ссылки на значение по умолчанию.</summary>
		/// <param name="e">Ссылка, для которой необходимо создать код.</param>
		// Token: 0x06001B10 RID: 6928 RVA: 0x00003917 File Offset: 0x00001B17
		protected virtual void GenerateDefaultValueExpression(CodeDefaultValueExpression e)
		{
		}

		/// <summary>Создает код для указанного выражения ссылки на свойство.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B11 RID: 6929
		protected abstract void GeneratePropertyReferenceExpression(CodePropertyReferenceExpression e);

		/// <summary>Создает код для указанного выражения ссылки на значение, задаваемое для свойства.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B12 RID: 6930
		protected abstract void GeneratePropertySetValueReferenceExpression(CodePropertySetValueReferenceExpression e);

		/// <summary>Создает код для указанного выражения ссылки this.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B13 RID: 6931
		protected abstract void GenerateThisReferenceExpression(CodeThisReferenceExpression e);

		/// <summary>Создает код для указанного выражения ссылки на тип.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B14 RID: 6932 RVA: 0x000646F5 File Offset: 0x000628F5
		protected virtual void GenerateTypeReferenceExpression(CodeTypeReferenceExpression e)
		{
			this.OutputType(e.Type);
		}

		/// <summary>Создает код для указанного типа выражения.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B15 RID: 6933 RVA: 0x00064703 File Offset: 0x00062903
		protected virtual void GenerateTypeOfExpression(CodeTypeOfExpression e)
		{
			this.Output.Write("typeof(");
			this.OutputType(e.Type);
			this.Output.Write(')');
		}

		/// <summary>Создает код для указанного оператора выражения.</summary>
		/// <param name="e">Оператор, для которого необходимо создать код.</param>
		// Token: 0x06001B16 RID: 6934
		protected abstract void GenerateExpressionStatement(CodeExpressionStatement e);

		/// <summary>Создает код для указанного оператора итерации.</summary>
		/// <param name="e">Оператор, для которого необходимо создать код.</param>
		// Token: 0x06001B17 RID: 6935
		protected abstract void GenerateIterationStatement(CodeIterationStatement e);

		/// <summary>Создает код для указанного оператора выброса исключения.</summary>
		/// <param name="e">Оператор, для которого необходимо создать код.</param>
		// Token: 0x06001B18 RID: 6936
		protected abstract void GenerateThrowExceptionStatement(CodeThrowExceptionStatement e);

		/// <summary>Создает код для указанного оператора комментария.</summary>
		/// <param name="e">Оператор, для которого необходимо создать код.</param>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.CodeDom.CodeCommentStatement.Comment" /> параметра <paramref name="e" /> не задано.</exception>
		// Token: 0x06001B19 RID: 6937 RVA: 0x0006472E File Offset: 0x0006292E
		protected virtual void GenerateCommentStatement(CodeCommentStatement e)
		{
			if (e.Comment == null)
			{
				throw new ArgumentException(SR.Format("The 'Comment' property of the CodeCommentStatement '{0}' cannot be null.", "e"), "e");
			}
			this.GenerateComment(e.Comment);
		}

		/// <summary>Создает код для указанных операторов комментария.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B1A RID: 6938 RVA: 0x00064760 File Offset: 0x00062960
		protected virtual void GenerateCommentStatements(CodeCommentStatementCollection e)
		{
			foreach (object obj in e)
			{
				CodeCommentStatement e2 = (CodeCommentStatement)obj;
				this.GenerateCommentStatement(e2);
			}
		}

		/// <summary>Создает код для указанного комментария.</summary>
		/// <param name="e">Класс <see cref="T:System.CodeDom.CodeComment" />, для которого создается код.</param>
		// Token: 0x06001B1B RID: 6939
		protected abstract void GenerateComment(CodeComment e);

		/// <summary>Создает код для указанного оператора возврата метода.</summary>
		/// <param name="e">Оператор, для которого необходимо создать код.</param>
		// Token: 0x06001B1C RID: 6940
		protected abstract void GenerateMethodReturnStatement(CodeMethodReturnStatement e);

		/// <summary>Создает код для указанного условного оператора.</summary>
		/// <param name="e">Оператор, для которого необходимо создать код.</param>
		// Token: 0x06001B1D RID: 6941
		protected abstract void GenerateConditionStatement(CodeConditionStatement e);

		/// <summary>Создает код для указанного оператора <see langword="try...catch...finally" />.</summary>
		/// <param name="e">Оператор, для которого необходимо создать код.</param>
		// Token: 0x06001B1E RID: 6942
		protected abstract void GenerateTryCatchFinallyStatement(CodeTryCatchFinallyStatement e);

		/// <summary>Создает код для указанного оператора присваивания.</summary>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeAssignStatement" />, указывающий оператор, для которого создается код.</param>
		// Token: 0x06001B1F RID: 6943
		protected abstract void GenerateAssignStatement(CodeAssignStatement e);

		/// <summary>Создает код для указанного оператора присоединения события.</summary>
		/// <param name="e">Объект <see cref="T:System.CodeDom.CodeAttachEventStatement" />, указывающий оператор, для которого создается код.</param>
		// Token: 0x06001B20 RID: 6944
		protected abstract void GenerateAttachEventStatement(CodeAttachEventStatement e);

		/// <summary>Создает код для указанного оператора удаления события.</summary>
		/// <param name="e">Оператор, для которого необходимо создать код.</param>
		// Token: 0x06001B21 RID: 6945
		protected abstract void GenerateRemoveEventStatement(CodeRemoveEventStatement e);

		/// <summary>Создает код для указанного оператора <see langword="goto" />.</summary>
		/// <param name="e">Выражение, для которого формируется код.</param>
		// Token: 0x06001B22 RID: 6946
		protected abstract void GenerateGotoStatement(CodeGotoStatement e);

		/// <summary>Создает код для указанного оператора с меткой.</summary>
		/// <param name="e">Оператор, для которого необходимо создать код.</param>
		// Token: 0x06001B23 RID: 6947
		protected abstract void GenerateLabeledStatement(CodeLabeledStatement e);

		/// <summary>Выводит код оператора, заданного в виде литерального фрагмента кода.</summary>
		/// <param name="e">Оператор, для которого необходимо создать код.</param>
		// Token: 0x06001B24 RID: 6948 RVA: 0x00015660 File Offset: 0x00013860
		protected virtual void GenerateSnippetStatement(CodeSnippetStatement e)
		{
			this.Output.WriteLine(e.Value);
		}

		/// <summary>Создает код для указанного оператора объявления переменной.</summary>
		/// <param name="e">Оператор, для которого необходимо создать код.</param>
		// Token: 0x06001B25 RID: 6949
		protected abstract void GenerateVariableDeclarationStatement(CodeVariableDeclarationStatement e);

		/// <summary>Создает код для указанного начала строки директивы pragma.</summary>
		/// <param name="e">Начало строки директивы pragma, для которого необходимо создать код.</param>
		// Token: 0x06001B26 RID: 6950
		protected abstract void GenerateLinePragmaStart(CodeLinePragma e);

		/// <summary>Создает код для указанного конца строки директивы pragma.</summary>
		/// <param name="e">Конец строки директивы pragma, для которой необходимо создать код.</param>
		// Token: 0x06001B27 RID: 6951
		protected abstract void GenerateLinePragmaEnd(CodeLinePragma e);

		/// <summary>Создает код для указанного события.</summary>
		/// <param name="e">Событие члена, для которого необходимо создать код.</param>
		/// <param name="c">Тип объекта, в котором происходит это событие.</param>
		// Token: 0x06001B28 RID: 6952
		protected abstract void GenerateEvent(CodeMemberEvent e, CodeTypeDeclaration c);

		/// <summary>Создает код для указанного поля-члена.</summary>
		/// <param name="e">Поле, для которого необходимо создать код.</param>
		// Token: 0x06001B29 RID: 6953
		protected abstract void GenerateField(CodeMemberField e);

		/// <summary>Выводит код члена класса, заданного в виде литерального фрагмента кода.</summary>
		/// <param name="e">Член, для которого необходимо создать код.</param>
		// Token: 0x06001B2A RID: 6954
		protected abstract void GenerateSnippetMember(CodeSnippetTypeMember e);

		/// <summary>Создает код для указанного метода точки входа.</summary>
		/// <param name="e">Точка входа для кода.</param>
		/// <param name="c">Код, объявляющий тип.</param>
		// Token: 0x06001B2B RID: 6955
		protected abstract void GenerateEntryPointMethod(CodeEntryPointMethod e, CodeTypeDeclaration c);

		/// <summary>Создает код для указанного метода.</summary>
		/// <param name="e">Метод члена, для которого необходимо создать код.</param>
		/// <param name="c">Тип объекта, в котором выполняется этот метод.</param>
		// Token: 0x06001B2C RID: 6956
		protected abstract void GenerateMethod(CodeMemberMethod e, CodeTypeDeclaration c);

		/// <summary>Создает код для указанного свойства.</summary>
		/// <param name="e">Свойство, для которого необходимо создать код.</param>
		/// <param name="c">Тип объекта, в котором реализуется это свойство.</param>
		// Token: 0x06001B2D RID: 6957
		protected abstract void GenerateProperty(CodeMemberProperty e, CodeTypeDeclaration c);

		/// <summary>Создает код для указанного конструктора.</summary>
		/// <param name="e">Конструктор, для которого необходимо создать код.</param>
		/// <param name="c">Тип объекта, создаваемый этим конструктором.</param>
		// Token: 0x06001B2E RID: 6958
		protected abstract void GenerateConstructor(CodeConstructor e, CodeTypeDeclaration c);

		/// <summary>Создает код для указанного конструктора класса.</summary>
		/// <param name="e">Конструктор класса, для которого необходимо создать код.</param>
		// Token: 0x06001B2F RID: 6959
		protected abstract void GenerateTypeConstructor(CodeTypeConstructor e);

		/// <summary>Создает код для заданного начала класса.</summary>
		/// <param name="e">Начало класса, для которого необходимо создать код.</param>
		// Token: 0x06001B30 RID: 6960
		protected abstract void GenerateTypeStart(CodeTypeDeclaration e);

		/// <summary>Создает код для заданного конца класса.</summary>
		/// <param name="e">Конец класса, для которого необходимо создать код.</param>
		// Token: 0x06001B31 RID: 6961
		protected abstract void GenerateTypeEnd(CodeTypeDeclaration e);

		/// <summary>Создает код для начала единицы компиляции.</summary>
		/// <param name="e">Единица компиляции, для которой необходимо создать код.</param>
		// Token: 0x06001B32 RID: 6962 RVA: 0x000647B4 File Offset: 0x000629B4
		protected virtual void GenerateCompileUnitStart(CodeCompileUnit e)
		{
			if (e.StartDirectives.Count > 0)
			{
				this.GenerateDirectives(e.StartDirectives);
			}
		}

		/// <summary>Создает код для конца единицы компиляции.</summary>
		/// <param name="e">Единица компиляции, для которой необходимо создать код.</param>
		// Token: 0x06001B33 RID: 6963 RVA: 0x000647D0 File Offset: 0x000629D0
		protected virtual void GenerateCompileUnitEnd(CodeCompileUnit e)
		{
			if (e.EndDirectives.Count > 0)
			{
				this.GenerateDirectives(e.EndDirectives);
			}
		}

		/// <summary>Создает код для начала пространства имен.</summary>
		/// <param name="e">Пространство имен, для которого формируется код.</param>
		// Token: 0x06001B34 RID: 6964
		protected abstract void GenerateNamespaceStart(CodeNamespace e);

		/// <summary>Создает код для конца пространства имен.</summary>
		/// <param name="e">Пространство имен, для которого формируется код.</param>
		// Token: 0x06001B35 RID: 6965
		protected abstract void GenerateNamespaceEnd(CodeNamespace e);

		/// <summary>Создает код для указанного импорта пространства имен.</summary>
		/// <param name="e">Импорт пространства имен, для которого необходимо создать код.</param>
		// Token: 0x06001B36 RID: 6966
		protected abstract void GenerateNamespaceImport(CodeNamespaceImport e);

		/// <summary>Создает код для указанного начала блока атрибута.</summary>
		/// <param name="attributes">Объект <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" />, указывающий начало блока атрибута, для которого создается код.</param>
		// Token: 0x06001B37 RID: 6967
		protected abstract void GenerateAttributeDeclarationsStart(CodeAttributeDeclarationCollection attributes);

		/// <summary>Создает код для указанного конца блока атрибута.</summary>
		/// <param name="attributes">Объект <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" />, указывающий конец блока атрибута, для которого создается код.</param>
		// Token: 0x06001B38 RID: 6968
		protected abstract void GenerateAttributeDeclarationsEnd(CodeAttributeDeclarationCollection attributes);

		/// <summary>Возвращает значение, показывающее, обеспечивается ли указанная поддержка создания кода.</summary>
		/// <param name="support">Тип поддержки создания кода, который необходимо протестировать.</param>
		/// <returns>
		///   <see langword="true" />, если указанная поддержка создания кода осуществляется; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001B39 RID: 6969
		protected abstract bool Supports(GeneratorSupport support);

		/// <summary>Получает значение, показывающее, является ли указанное значение допустимым идентификатором.</summary>
		/// <param name="value">Значение для проверки на наличие конфликтов с допустимыми идентификаторами.</param>
		/// <returns>
		///   <see langword="true" />, если значение является допустимым идентификатором; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001B3A RID: 6970
		protected abstract bool IsValidIdentifier(string value);

		/// <summary>Выдает исключение, если указанная строка не является допустимым идентификатором.</summary>
		/// <param name="value">Идентификатор для проверки на допустимость использования в качестве идентификатора.</param>
		/// <exception cref="T:System.ArgumentException">Если указанный идентификатор является недопустимым или конфликтует с зарезервированными ключевыми словами языка.</exception>
		// Token: 0x06001B3B RID: 6971 RVA: 0x000647EC File Offset: 0x000629EC
		protected virtual void ValidateIdentifier(string value)
		{
			if (!this.IsValidIdentifier(value))
			{
				throw new ArgumentException(SR.Format("Identifier '{0}' is not valid.", value));
			}
		}

		/// <summary>Создает Escape-идентификатор для заданного значения.</summary>
		/// <param name="value">Строка, для которой создается Escape-идентификатор.</param>
		/// <returns>Escape-идентификатор для данного значения.</returns>
		// Token: 0x06001B3C RID: 6972
		protected abstract string CreateEscapedIdentifier(string value);

		/// <summary>Создает допустимый идентификатор для указанного значения.</summary>
		/// <param name="value">Строка, для которой создается допустимый идентификатор.</param>
		/// <returns>Допустимый идентификатор для значения.</returns>
		// Token: 0x06001B3D RID: 6973
		protected abstract string CreateValidIdentifier(string value);

		/// <summary>Возвращает имя указанного типа данных.</summary>
		/// <param name="value">Тип, имя которого будет возвращено.</param>
		/// <returns>Имя ссылки на тип данных.</returns>
		// Token: 0x06001B3E RID: 6974
		protected abstract string GetTypeOutput(CodeTypeReference value);

		/// <summary>Преобразует указанную строку, форматируя ее с помощью Escape-кодов.</summary>
		/// <param name="value">Преобразуемая строка.</param>
		/// <returns>Преобразованная строка.</returns>
		// Token: 0x06001B3F RID: 6975
		protected abstract string QuoteSnippetString(string value);

		/// <summary>Получает значение, показывающее, является ли указанная строка допустимым идентификатором.</summary>
		/// <param name="value">Строка для проверки на истинность.</param>
		/// <returns>
		///   <see langword="true" />, если указанная строка является допустимым идентификатором; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001B40 RID: 6976 RVA: 0x0001EB85 File Offset: 0x0001CD85
		public static bool IsValidLanguageIndependentIdentifier(string value)
		{
			return CSharpHelpers.IsValidTypeNameOrIdentifier(value, false);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00064808 File Offset: 0x00062A08
		internal static bool IsValidLanguageIndependentTypeName(string value)
		{
			return CSharpHelpers.IsValidTypeNameOrIdentifier(value, true);
		}

		/// <summary>Пытается проверить каждое поле идентификатора, содержащееся в указанном <see cref="T:System.CodeDom.CodeObject" /> или дереве <see cref="N:System.CodeDom" />.</summary>
		/// <param name="e">Объект, который необходимо протестировать на наличие недопустимых идентификаторов.</param>
		/// <exception cref="T:System.ArgumentException">Указанный <see cref="T:System.CodeDom.CodeObject" /> содержит недопустимый идентификатор.</exception>
		// Token: 0x06001B42 RID: 6978 RVA: 0x00064811 File Offset: 0x00062A11
		public static void ValidateIdentifiers(CodeObject e)
		{
			new CodeValidator().ValidateIdentifiers(e);
		}

		// Token: 0x04000E20 RID: 3616
		private const int ParameterMultilineThreshold = 15;

		// Token: 0x04000E21 RID: 3617
		private ExposedTabStringIndentedTextWriter _output;

		// Token: 0x04000E22 RID: 3618
		private CodeGeneratorOptions _options;

		// Token: 0x04000E23 RID: 3619
		private CodeTypeDeclaration _currentClass;

		// Token: 0x04000E24 RID: 3620
		private CodeTypeMember _currentMember;

		// Token: 0x04000E25 RID: 3621
		private bool _inNestedBinary;
	}
}
