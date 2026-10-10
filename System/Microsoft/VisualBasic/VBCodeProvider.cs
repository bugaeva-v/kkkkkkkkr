using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace Microsoft.VisualBasic
{
	/// <summary>Предоставляет доступ к экземплярам генератора и компилятора кода Visual Basic.</summary>
	// Token: 0x02000136 RID: 310
	public class VBCodeProvider : CodeDomProvider
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.VisualBasic.VBCodeProvider" />.</summary>
		// Token: 0x060007AA RID: 1962 RVA: 0x0001831A File Offset: 0x0001651A
		public VBCodeProvider()
		{
			this._generator = new VBCodeGenerator();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.VisualBasic.VBCodeProvider" /> с помощью указанных параметров поставщика.</summary>
		/// <param name="providerOptions">Объект <see cref="T:System.Collections.Generic.IDictionary`2" />, содержащий параметры поставщика из файла конфигурации.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="providerOptions" /> — <see langword="null" />.</exception>
		// Token: 0x060007AB RID: 1963 RVA: 0x0001832D File Offset: 0x0001652D
		public VBCodeProvider(IDictionary<string, string> providerOptions)
		{
			if (providerOptions == null)
			{
				throw new ArgumentNullException("providerOptions");
			}
			this._generator = new VBCodeGenerator(providerOptions);
		}

		/// <summary>Получает расширение имени файла, используемое при создании файлов исходного кода.</summary>
		/// <returns>Расширение имени файла, используемое при создании файлов исходного кода.</returns>
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0001834F File Offset: 0x0001654F
		public override string FileExtension
		{
			get
			{
				return "vb";
			}
		}

		/// <summary>Получает идентификатор возможностей языка.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.Compiler.LanguageOptions" />, который указывает специальные возможности языка.</returns>
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x0000390E File Offset: 0x00001B0E
		public override LanguageOptions LanguageOptions
		{
			get
			{
				return LanguageOptions.CaseInsensitive;
			}
		}

		/// <summary>Получает экземпляр генератора кода Visual Basic.</summary>
		/// <returns>Экземпляр реализации <see cref="T:System.CodeDom.Compiler.ICodeGenerator" /> Visual Basic.</returns>
		// Token: 0x060007AE RID: 1966 RVA: 0x00018356 File Offset: 0x00016556
		[Obsolete("Callers should not use the ICodeGenerator interface and should instead use the methods directly on the CodeDomProvider class.")]
		public override ICodeGenerator CreateGenerator()
		{
			return this._generator;
		}

		/// <summary>Получает экземпляр компилятора кода Visual Basic.</summary>
		/// <returns>Экземпляр реализации <see cref="T:System.CodeDom.Compiler.ICodeCompiler" /> Visual Basic.</returns>
		// Token: 0x060007AF RID: 1967 RVA: 0x00018356 File Offset: 0x00016556
		[Obsolete("Callers should not use the ICodeCompiler interface and should instead use the methods directly on the CodeDomProvider class.")]
		public override ICodeCompiler CreateCompiler()
		{
			return this._generator;
		}

		/// <summary>Получает <see cref="T:System.ComponentModel.TypeConverter" /> для заданного типа объекта.</summary>
		/// <param name="type">Тип объекта, для которого извлекается преобразователь типов.</param>
		/// <returns>
		///   <see cref="T:System.ComponentModel.TypeConverter" /> для заданного типа.</returns>
		// Token: 0x060007B0 RID: 1968 RVA: 0x0001835E File Offset: 0x0001655E
		public override TypeConverter GetConverter(Type type)
		{
			if (type == typeof(MemberAttributes))
			{
				return VBMemberAttributeConverter.Default;
			}
			if (!(type == typeof(TypeAttributes)))
			{
				return base.GetConverter(type);
			}
			return VBTypeAttributeConverter.Default;
		}

		/// <summary>Создает код для заданного члена класса, используя заданные параметры модуля записи текста и генератора кода.</summary>
		/// <param name="member">Класс <see cref="T:System.CodeDom.CodeTypeMember" />, для которого создается код.</param>
		/// <param name="writer">Экземпляр <see cref="T:System.IO.TextWriter" />, в который выполняется запись.</param>
		/// <param name="options">Параметры <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, используемые при создании кода.</param>
		// Token: 0x060007B1 RID: 1969 RVA: 0x00018397 File Offset: 0x00016597
		public override void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options)
		{
			this._generator.GenerateCodeFromMember(member, writer, options);
		}

		// Token: 0x0400051E RID: 1310
		private VBCodeGenerator _generator;
	}
}
