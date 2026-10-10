using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace Microsoft.CSharp
{
	/// <summary>Предоставляет доступ к экземплярам генератора кода C# и компилятора кода.</summary>
	// Token: 0x0200013C RID: 316
	public class CSharpCodeProvider : CodeDomProvider
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.CSharp.CSharpCodeProvider" />.</summary>
		// Token: 0x0600086C RID: 2156 RVA: 0x0001E57E File Offset: 0x0001C77E
		public CSharpCodeProvider()
		{
			this._generator = new CSharpCodeGenerator();
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:Microsoft.CSharp.CSharpCodeProvider" /> с помощью указанных параметров поставщика.</summary>
		/// <param name="providerOptions">Объект <see cref="T:System.Collections.Generic.IDictionary`2" />, содержащий параметры поставщика из файла конфигурации.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="providerOptions" /> — <see langword="null" />.</exception>
		// Token: 0x0600086D RID: 2157 RVA: 0x0001E591 File Offset: 0x0001C791
		public CSharpCodeProvider(IDictionary<string, string> providerOptions)
		{
			if (providerOptions == null)
			{
				throw new ArgumentNullException("providerOptions");
			}
			this._generator = new CSharpCodeGenerator(providerOptions);
		}

		/// <summary>Получает расширение имени файла, используемое при создании файлов исходного кода.</summary>
		/// <returns>Расширение имени файла, используемое при создании файлов исходного кода.</returns>
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0001E5B3 File Offset: 0x0001C7B3
		public override string FileExtension
		{
			get
			{
				return "cs";
			}
		}

		/// <summary>Получает экземпляр генератора кода C#.</summary>
		/// <returns>Экземпляр реализации <see cref="T:System.CodeDom.Compiler.ICodeGenerator" /> C#.</returns>
		// Token: 0x0600086F RID: 2159 RVA: 0x0001E5BA File Offset: 0x0001C7BA
		[Obsolete("Callers should not use the ICodeGenerator interface and should instead use the methods directly on the CodeDomProvider class.")]
		public override ICodeGenerator CreateGenerator()
		{
			return this._generator;
		}

		/// <summary>Получает экземпляр компилятора кода C#.</summary>
		/// <returns>Экземпляр реализации <see cref="T:System.CodeDom.Compiler.ICodeCompiler" /> C#.</returns>
		// Token: 0x06000870 RID: 2160 RVA: 0x0001E5BA File Offset: 0x0001C7BA
		[Obsolete("Callers should not use the ICodeCompiler interface and should instead use the methods directly on the CodeDomProvider class.")]
		public override ICodeCompiler CreateCompiler()
		{
			return this._generator;
		}

		/// <summary>Получает <see cref="T:System.ComponentModel.TypeConverter" /> для заданного типа объекта.</summary>
		/// <param name="type">Тип объекта, для которого извлекается преобразователь типов.</param>
		/// <returns>Идентификатор <see cref="T:System.ComponentModel.TypeConverter" /> для заданного типа.</returns>
		// Token: 0x06000871 RID: 2161 RVA: 0x0001E5C2 File Offset: 0x0001C7C2
		public override TypeConverter GetConverter(Type type)
		{
			if (type == typeof(MemberAttributes))
			{
				return CSharpMemberAttributeConverter.Default;
			}
			if (!(type == typeof(TypeAttributes)))
			{
				return base.GetConverter(type);
			}
			return CSharpTypeAttributeConverter.Default;
		}

		/// <summary>Создает код для заданного члена класса, используя заданные возможности модуля записи текста и генератора кода.</summary>
		/// <param name="member">Класс <see cref="T:System.CodeDom.CodeTypeMember" />, для которого создается код.</param>
		/// <param name="writer">Класс <see cref="T:System.IO.TextWriter" />, в который осуществляется запись.</param>
		/// <param name="options">Параметры <see cref="T:System.CodeDom.Compiler.CodeGeneratorOptions" />, используемые при создании кода.</param>
		// Token: 0x06000872 RID: 2162 RVA: 0x0001E5FB File Offset: 0x0001C7FB
		public override void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options)
		{
			this._generator.GenerateCodeFromMember(member, writer, options);
		}

		// Token: 0x04000536 RID: 1334
		private readonly CSharpCodeGenerator _generator;
	}
}
