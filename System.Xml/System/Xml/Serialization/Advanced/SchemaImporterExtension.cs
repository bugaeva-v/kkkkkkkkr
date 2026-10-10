using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Xml.Schema;

namespace System.Xml.Serialization.Advanced
{
	/// <summary>
	///         Позволяет настраивать код, создаваемый из документа языка описания веб-служб (WSDL), при использовании средств автоматизации запросов.
	///       </summary>
	// Token: 0x02000320 RID: 800
	public abstract class SchemaImporterExtension
	{
		/// <summary>
		///         Позволяет управлять созданным кодом, проверяя импортируемую схему и указав, он преобразуется в тип CLR.
		///       </summary>
		/// <param name="name">
		///           Имя элемента.
		///         </param>
		/// <param name="ns">
		///           Пространство имен элемента.
		///         </param>
		/// <param name="context">
		///           <see cref="T:System.Xml.Schema.XmlSchemaObject" /> Представляющий сведения схемы, например номер строки XML-элемента.
		///         </param>
		/// <param name="schemas">
		///           <see cref="T:System.Xml.Serialization.XmlSchemas" /> Содержащий коллекцию схем в документе.
		///         </param>
		/// <param name="importer">
		///           <see cref="T:System.Xml.Serialization.XmlSchemaImporter" /> То есть используется средство импорта.
		///         </param>
		/// <param name="compileUnit">
		///           A <see cref="T:System.CodeDom.CodeCompileUnit" /> к которому можно добавить структуры CodeDOM для создания альтернативный код для XSD.
		///         </param>
		/// <param name="mainNamespace">
		///           Объект <see cref="T:System.CodeDom.CodeNamespace" /> представляющий текущее пространство имен для элемента.
		///         </param>
		/// <param name="options">
		///           Объект <see cref="T:System.Xml.Serialization.CodeGenerationOptions" /> для настройки параметров на компилятора кода.
		///         </param>
		/// <param name="codeProvider">
		///           Объект <see cref="T:System.CodeDom.Compiler.CodeDomProvider" /> используемый для создания нового кода.
		///         </param>
		/// <returns>
		///         Имя типа среды CLR, который он отображается.
		///       </returns>
		// Token: 0x060020EF RID: 8431 RVA: 0x0001DA42 File Offset: 0x0001BC42
		public virtual string ImportSchemaType(string name, string ns, XmlSchemaObject context, XmlSchemas schemas, XmlSchemaImporter importer, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeGenerationOptions options, CodeDomProvider codeProvider)
		{
			return null;
		}

		/// <summary>
		///         Позволяет управлять созданным кодом, проверяя импортируемую схему и указав, он преобразуется в тип CLR.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Xml.Schema.XmlSchemaType" /> Представляющий тип XSD.
		///         </param>
		/// <param name="context">
		///           <see cref="T:System.Xml.Schema.XmlSchemaObject" /> Представляющий сведения схемы, например номер строки XML-элемента.
		///         </param>
		/// <param name="schemas">
		///           <see cref="T:System.Xml.Serialization.XmlSchemas" /> Содержащий коллекцию схем в документе.
		///         </param>
		/// <param name="importer">
		///           <see cref="T:System.Xml.Serialization.XmlSchemaImporter" /> То есть используется средство импорта.
		///         </param>
		/// <param name="compileUnit">
		///           A <see cref="T:System.CodeDom.CodeCompileUnit" /> к которому можно добавить структуры CodeDOM для создания альтернативный код для XSD.
		///         </param>
		/// <param name="mainNamespace">
		///           Объект <see cref="T:System.CodeDom.CodeNamespace" /> представляющий текущее пространство имен для элемента.
		///         </param>
		/// <param name="options">
		///           Объект <see cref="T:System.Xml.Serialization.CodeGenerationOptions" /> для настройки параметров на компилятора кода.
		///         </param>
		/// <param name="codeProvider">
		///           Объект <see cref="T:System.CodeDom.Compiler.CodeDomProvider" /> используемый для создания нового кода.
		///         </param>
		/// <returns>
		///         Имя типа среды CLR, который он отображается.
		///       </returns>
		// Token: 0x060020F0 RID: 8432 RVA: 0x0001DA42 File Offset: 0x0001BC42
		public virtual string ImportSchemaType(XmlSchemaType type, XmlSchemaObject context, XmlSchemas schemas, XmlSchemaImporter importer, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeGenerationOptions options, CodeDomProvider codeProvider)
		{
			return null;
		}

		/// <summary>
		///         Обрабатывает Импорт &lt; xsd: любой &gt; элементы в схеме.
		///       </summary>
		/// <param name="any">
		///           <see cref="T:System.Xml.Schema.XmlSchemaAny" /> Представляющий <see langword="xsd:any" /> элемент найден в документ схемы XML (XSD).
		///         </param>
		/// <param name="mixed">
		///           Объект <see cref="T:System.Boolean" /> указывает ли XSD <see langword="complex" /> установлен атрибут к «смешанный».
		///           <see langword="true" />, если атрибут установлен в смешанных, в противном случае <see langword="false" />.
		///         </param>
		/// <param name="schemas">
		///           <see cref="T:System.Xml.Serialization.XmlSchemas" /> Содержащий коллекцию схем в XSD.
		///         </param>
		/// <param name="importer">
		///           <see cref="T:System.Xml.Serialization.XmlSchemaImporter" /> То есть используется средство импорта.
		///         </param>
		/// <param name="compileUnit">
		///           A <see cref="T:System.CodeDom.CodeCompileUnit" /> к которому можно добавить структуры CodeDOM для создания альтернативный код для XSD.
		///         </param>
		/// <param name="mainNamespace">
		///           Объект <see cref="T:System.CodeDom.CodeNamespace" /> представляющий текущее пространство имен для элемента.
		///         </param>
		/// <param name="options">
		///           Объект <see cref="T:System.Xml.Serialization.CodeGenerationOptions" /> для настройки параметров на компилятора кода.
		///         </param>
		/// <param name="codeProvider">
		///           A <see cref="T:System.CodeDom.Compiler.CodeDomProvider" /> именно Поставщик CodeDOM, используемый для создания нового кода.
		///         </param>
		/// <returns>
		///         Имя типа среды CLR, который сопоставляется элемент.
		///       </returns>
		// Token: 0x060020F1 RID: 8433 RVA: 0x0001DA42 File Offset: 0x0001BC42
		public virtual string ImportAnyElement(XmlSchemaAny any, bool mixed, XmlSchemas schemas, XmlSchemaImporter importer, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeGenerationOptions options, CodeDomProvider codeProvider)
		{
			return null;
		}

		/// <summary>
		///         Можно указать значение по умолчанию для импортируемого типа XSD.
		///       </summary>
		/// <param name="value">
		///           Значение, найденное в исходном XSD.
		///         </param>
		/// <param name="type">
		///           Имя типа XSD.
		///         </param>
		/// <returns>
		///         A <see cref="T:System.CodeDom.CodeExpression" /> значение по умолчанию.
		///       </returns>
		// Token: 0x060020F2 RID: 8434 RVA: 0x0001DA42 File Offset: 0x0001BC42
		public virtual CodeExpression ImportDefaultValue(string value, string type)
		{
			return null;
		}
	}
}
