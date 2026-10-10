using System;

namespace System.CodeDom
{
	/// <summary>Представляет блок исключений <see langword="catch" /> оператора <see langword="try/catch" />.</summary>
	// Token: 0x020002FC RID: 764
	[Serializable]
	public class CodeCatchClause
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCatchClause" />.</summary>
		// Token: 0x06001869 RID: 6249 RVA: 0x0000219B File Offset: 0x0000039B
		public CodeCatchClause()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCatchClause" />, используя указанное имя локальной переменной для исключения.</summary>
		/// <param name="localName">Имя локальной переменной, объявленное в предложении перехвата для исключения. Делать это не обязательно.</param>
		// Token: 0x0600186A RID: 6250 RVA: 0x0005F4C0 File Offset: 0x0005D6C0
		public CodeCatchClause(string localName)
		{
			this._localName = localName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCatchClause" />, используя указанное имя локальной переменной для исключения и тип исключения.</summary>
		/// <param name="localName">Имя локальной переменной, объявленное в предложении перехвата для исключения. Делать это не обязательно.</param>
		/// <param name="catchExceptionType">
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип исключения для перехвата.</param>
		// Token: 0x0600186B RID: 6251 RVA: 0x0005F4CF File Offset: 0x0005D6CF
		public CodeCatchClause(string localName, CodeTypeReference catchExceptionType)
		{
			this._localName = localName;
			this._catchExceptionType = catchExceptionType;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCatchClause" />, используя указанное имя локальной переменной для исключения, тип исключения и коллекцию операторов.</summary>
		/// <param name="localName">Имя локальной переменной, объявленное в предложении перехвата для исключения. Делать это не обязательно.</param>
		/// <param name="catchExceptionType">
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип исключения для перехвата.</param>
		/// <param name="statements">Массив объектов <see cref="T:System.CodeDom.CodeStatement" />, представляющий содержимое блока перехвата.</param>
		// Token: 0x0600186C RID: 6252 RVA: 0x0005F4E5 File Offset: 0x0005D6E5
		public CodeCatchClause(string localName, CodeTypeReference catchExceptionType, params CodeStatement[] statements)
		{
			this._localName = localName;
			this._catchExceptionType = catchExceptionType;
			this.Statements.AddRange(statements);
		}

		/// <summary>Получает или задает имя переменной исключения, обрабатываемого предложением <see langword="catch" />.</summary>
		/// <returns>Имя для переменной исключения, обрабатываемого предложением <see langword="catch" />.</returns>
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x0005F507 File Offset: 0x0005D707
		// (set) Token: 0x0600186E RID: 6254 RVA: 0x0005F518 File Offset: 0x0005D718
		public string LocalName
		{
			get
			{
				return this._localName ?? string.Empty;
			}
			set
			{
				this._localName = value;
			}
		}

		/// <summary>Получает или задает тип исключения для обработки с помощью блока перехвата.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип исключения для обработки.</returns>
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x0005F524 File Offset: 0x0005D724
		// (set) Token: 0x06001870 RID: 6256 RVA: 0x0005F553 File Offset: 0x0005D753
		public CodeTypeReference CatchExceptionType
		{
			get
			{
				CodeTypeReference result;
				if ((result = this._catchExceptionType) == null)
				{
					result = (this._catchExceptionType = new CodeTypeReference(typeof(Exception)));
				}
				return result;
			}
			set
			{
				this._catchExceptionType = value;
			}
		}

		/// <summary>Получает операторы внутри блока перехвата.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeStatementCollection" /> содержит операторы внутри блока перехвата.</returns>
		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x0005F55C File Offset: 0x0005D75C
		public CodeStatementCollection Statements
		{
			get
			{
				CodeStatementCollection result;
				if ((result = this._statements) == null)
				{
					result = (this._statements = new CodeStatementCollection());
				}
				return result;
			}
		}

		// Token: 0x04000D6D RID: 3437
		private CodeStatementCollection _statements;

		// Token: 0x04000D6E RID: 3438
		private CodeTypeReference _catchExceptionType;

		// Token: 0x04000D6F RID: 3439
		private string _localName;
	}
}
