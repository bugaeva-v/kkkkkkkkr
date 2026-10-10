using System;

namespace System.CodeDom
{
	/// <summary>Представляет блок <see langword="try" /> с произвольным количеством предложений <see langword="catch" /> и (опционально) блок <see langword="finally" />.</summary>
	// Token: 0x02000331 RID: 817
	[Serializable]
	public class CodeTryCatchFinallyStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTryCatchFinallyStatement" />.</summary>
		// Token: 0x060019E5 RID: 6629 RVA: 0x00060E98 File Offset: 0x0005F098
		public CodeTryCatchFinallyStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTryCatchFinallyStatement" />, используя указанные операторы для предложений try и catch.</summary>
		/// <param name="tryStatements">Массив объектов <see cref="T:System.CodeDom.CodeStatement" />, указывающий операторы, к которым следует применить try.</param>
		/// <param name="catchClauses">Массив объектов <see cref="T:System.CodeDom.CodeCatchClause" />, указывающий предложения, к которым следует применить catch.</param>
		// Token: 0x060019E6 RID: 6630 RVA: 0x00060EC4 File Offset: 0x0005F0C4
		public CodeTryCatchFinallyStatement(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses)
		{
			this.TryStatements.AddRange(tryStatements);
			this.CatchClauses.AddRange(catchClauses);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTryCatchFinallyStatement" />, используя указанные операторы для предложений try, catch и операторы finally.</summary>
		/// <param name="tryStatements">Массив объектов <see cref="T:System.CodeDom.CodeStatement" />, указывающий операторы, к которым следует применить try.</param>
		/// <param name="catchClauses">Массив объектов <see cref="T:System.CodeDom.CodeCatchClause" />, указывающий предложения, к которым следует применить catch.</param>
		/// <param name="finallyStatements">Массив объектов <see cref="T:System.CodeDom.CodeStatement" />, указывающий операторы finally для использования.</param>
		// Token: 0x060019E7 RID: 6631 RVA: 0x00060F10 File Offset: 0x0005F110
		public CodeTryCatchFinallyStatement(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses, CodeStatement[] finallyStatements)
		{
			this.TryStatements.AddRange(tryStatements);
			this.CatchClauses.AddRange(catchClauses);
			this.FinallyStatements.AddRange(finallyStatements);
		}

		/// <summary>Получает операторы для try.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeStatementCollection" />, которая указывает операторы для try.</returns>
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00060F68 File Offset: 0x0005F168
		public CodeStatementCollection TryStatements { get; } = new CodeStatementCollection();

		/// <summary>Возвращает предложения catch для использования.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeCatchClauseCollection" /> указывает предложения catch для использования.</returns>
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x00060F70 File Offset: 0x0005F170
		public CodeCatchClauseCollection CatchClauses { get; } = new CodeCatchClauseCollection();

		/// <summary>Возвращает операторы finally для использования.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeStatementCollection" />, которая указывает операторы finally.</returns>
		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x00060F78 File Offset: 0x0005F178
		public CodeStatementCollection FinallyStatements { get; } = new CodeStatementCollection();
	}
}
