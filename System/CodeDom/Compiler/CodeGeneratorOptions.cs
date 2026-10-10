using System;
using System.Collections;
using System.Collections.Specialized;

namespace System.CodeDom.Compiler
{
	/// <summary>Представляет набор параметров, используемых генератором кода.</summary>
	// Token: 0x02000346 RID: 838
	public class CodeGeneratorOptions
	{
		/// <summary>Получает или задает объект по указанному индексу.</summary>
		/// <param name="index">Имя, связанное с извлекаемым объектом.</param>
		/// <returns>Объект, связанный с заданным именем. Если объекта, связанного с данным именем, в коллекции не существует, то <see langword="null" />.</returns>
		// Token: 0x17000574 RID: 1396
		public object this[string index]
		{
			get
			{
				return this._options[index];
			}
			set
			{
				this._options[index] = value;
			}
		}

		/// <summary>Получает или задает строку, используемую для отступов.</summary>
		/// <returns>Строка, содержащая используемые для отступов знаки.</returns>
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x00064850 File Offset: 0x00062A50
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x0006487D File Offset: 0x00062A7D
		public string IndentString
		{
			get
			{
				object obj = this._options["IndentString"];
				if (obj == null)
				{
					return "    ";
				}
				return (string)obj;
			}
			set
			{
				this._options["IndentString"] = value;
			}
		}

		/// <summary>Получает или задает стиль, применяемый для скобок.</summary>
		/// <returns>Строка, содержащая применяемый для скобок стиль.</returns>
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00064890 File Offset: 0x00062A90
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x000648BD File Offset: 0x00062ABD
		public string BracingStyle
		{
			get
			{
				object obj = this._options["BracingStyle"];
				if (obj == null)
				{
					return "Block";
				}
				return (string)obj;
			}
			set
			{
				this._options["BracingStyle"] = value;
			}
		}

		/// <summary>Получает или задает значение, показывающее, добавлять ли блоки <see langword="else" />, <see langword="catch" /> или <see langword="finally" />, включая скобки, к заключительной строке каждого предыдущего блока <see langword="if" /> или <see langword="try" />.</summary>
		/// <returns>
		///   <see langword="true" />, если следует добавлять else; в противном случае — <see langword="false" />. По умолчанию этому свойству присваивается значение <see langword="false" />.</returns>
		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x000648D0 File Offset: 0x00062AD0
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x000648F9 File Offset: 0x00062AF9
		public bool ElseOnClosing
		{
			get
			{
				object obj = this._options["ElseOnClosing"];
				return obj != null && (bool)obj;
			}
			set
			{
				this._options["ElseOnClosing"] = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, следует ли вставлять пустые строки между членами.</summary>
		/// <returns>
		///   <see langword="true" />, если следует вставлять пустые строки; в противном случае — <see langword="false" />. По умолчанию значением этого свойства является <see langword="true" />.</returns>
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x00064914 File Offset: 0x00062B14
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x0006493D File Offset: 0x00062B3D
		public bool BlankLinesBetweenMembers
		{
			get
			{
				object obj = this._options["BlankLinesBetweenMembers"];
				return obj == null || (bool)obj;
			}
			set
			{
				this._options["BlankLinesBetweenMembers"] = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, следует ли генерировать члены в том порядке, в котором они расположены в коллекции членов.</summary>
		/// <returns>
		///   <see langword="true" />, чтобы члены генерировались в том порядке, в котором они расположены в коллекции членов, в противном случае — <see langword="false" />. По умолчанию этому свойству присваивается значение <see langword="false" />.</returns>
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00064958 File Offset: 0x00062B58
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x00064981 File Offset: 0x00062B81
		public bool VerbatimOrder
		{
			get
			{
				object obj = this._options["VerbatimOrder"];
				return obj != null && (bool)obj;
			}
			set
			{
				this._options["VerbatimOrder"] = value;
			}
		}

		// Token: 0x04000E26 RID: 3622
		private readonly IDictionary _options = new ListDictionary();
	}
}
