using System;

namespace System.CodeDom
{
	/// <summary>Представляет условный оператор перехода, обычно представляемый как <see langword="if" />.</summary>
	// Token: 0x02000303 RID: 771
	[Serializable]
	public class CodeConditionStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeConditionStatement" />.</summary>
		// Token: 0x060018A7 RID: 6311 RVA: 0x0005F881 File Offset: 0x0005DA81
		public CodeConditionStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeConditionStatement" />, используя указанное условие и операторы.</summary>
		/// <param name="condition">
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий выражение для вычисления.</param>
		/// <param name="trueStatements">Массив типа <see cref="T:System.CodeDom.CodeStatement" />, содержащий операторы для выполнения, если условие равно <see langword="true" />.</param>
		// Token: 0x060018A8 RID: 6312 RVA: 0x0005F89F File Offset: 0x0005DA9F
		public CodeConditionStatement(CodeExpression condition, params CodeStatement[] trueStatements)
		{
			this.Condition = condition;
			this.TrueStatements.AddRange(trueStatements);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeConditionStatement" />, используя указанное условие и операторы.</summary>
		/// <param name="condition">
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий условие для вычисления.</param>
		/// <param name="trueStatements">Массив типа <see cref="T:System.CodeDom.CodeStatement" />, содержащий операторы для выполнения, если условие равно <see langword="true" />.</param>
		/// <param name="falseStatements">Массив типа <see cref="T:System.CodeDom.CodeStatement" />, содержащий операторы для выполнения, если условие равно <see langword="false" />.</param>
		// Token: 0x060018A9 RID: 6313 RVA: 0x0005F8D0 File Offset: 0x0005DAD0
		public CodeConditionStatement(CodeExpression condition, CodeStatement[] trueStatements, CodeStatement[] falseStatements)
		{
			this.Condition = condition;
			this.TrueStatements.AddRange(trueStatements);
			this.FalseStatements.AddRange(falseStatements);
		}

		/// <summary>Получает или задает выражение для вычисления <see langword="true" /> или <see langword="false" />.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" /> для вычисления <see langword="true" /> или <see langword="false" />.</returns>
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x0005F90D File Offset: 0x0005DB0D
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x0005F915 File Offset: 0x0005DB15
		public CodeExpression Condition { get; set; }

		/// <summary>Получает коллекцию операторов для выполнения, если условное выражение вычислено как <see langword="true" />.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeStatementCollection" />, содержащий операторы для выполнения, если условное выражение вычислено как <see langword="true" />.</returns>
		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x0005F91E File Offset: 0x0005DB1E
		public CodeStatementCollection TrueStatements { get; } = new CodeStatementCollection();

		/// <summary>Получает коллекцию операторов для выполнения, если условное выражение вычислено как <see langword="false" />.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeStatementCollection" />, содержащий операторы для выполнения, если условное выражение вычислено как <see langword="false" />.</returns>
		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x0005F926 File Offset: 0x0005DB26
		public CodeStatementCollection FalseStatements { get; } = new CodeStatementCollection();
	}
}
