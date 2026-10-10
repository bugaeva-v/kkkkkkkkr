using System;

namespace System.CodeDom
{
	/// <summary>Представляет оператор <see langword="for" /> или цикл по блоку операторов, использующие выражение проверки как условие для продолжения цикла.</summary>
	// Token: 0x02000313 RID: 787
	[Serializable]
	public class CodeIterationStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeIterationStatement" />.</summary>
		// Token: 0x060018FF RID: 6399 RVA: 0x0005FD3D File Offset: 0x0005DF3D
		public CodeIterationStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeIterationStatement" />, используя заданные параметры.</summary>
		/// <param name="initStatement">
		///   <see cref="T:System.CodeDom.CodeStatement" /> содержит оператор инициализации цикла.</param>
		/// <param name="testExpression">
		///   <see cref="T:System.CodeDom.CodeExpression" /> содержит выражение для проверки выходного условия.</param>
		/// <param name="incrementStatement">
		///   <see cref="T:System.CodeDom.CodeStatement" /> содержит оператор приращения по циклам.</param>
		/// <param name="statements">Массив типа <see cref="T:System.CodeDom.CodeStatement" />, содержащий операторы внутри цикла.</param>
		// Token: 0x06001900 RID: 6400 RVA: 0x0005FD50 File Offset: 0x0005DF50
		public CodeIterationStatement(CodeStatement initStatement, CodeExpression testExpression, CodeStatement incrementStatement, params CodeStatement[] statements)
		{
			this.InitStatement = initStatement;
			this.TestExpression = testExpression;
			this.IncrementStatement = incrementStatement;
			this.Statements.AddRange(statements);
		}

		/// <summary>Получает или задает оператор инициализации цикла.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeStatement" />, указывающий оператор инициализации цикла.</returns>
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x0005FD85 File Offset: 0x0005DF85
		// (set) Token: 0x06001902 RID: 6402 RVA: 0x0005FD8D File Offset: 0x0005DF8D
		public CodeStatement InitStatement { get; set; }

		/// <summary>Получает или задает выражение для проверки как условие продолжения цикла.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий выражение для проверки.</returns>
		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x0005FD96 File Offset: 0x0005DF96
		// (set) Token: 0x06001904 RID: 6404 RVA: 0x0005FD9E File Offset: 0x0005DF9E
		public CodeExpression TestExpression { get; set; }

		/// <summary>Получает или задает оператор, вызываемый после каждого прохода цикла.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeStatement" />, указывающий оператор приращения по циклам.</returns>
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x0005FDA7 File Offset: 0x0005DFA7
		// (set) Token: 0x06001906 RID: 6406 RVA: 0x0005FDAF File Offset: 0x0005DFAF
		public CodeStatement IncrementStatement { get; set; }

		/// <summary>Получает коллекцию операторов для выполнения внутри цикла.</summary>
		/// <returns>Массив типа <see cref="T:System.CodeDom.CodeStatement" />, указывающий операторы внутри цикла.</returns>
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x0005FDB8 File Offset: 0x0005DFB8
		public CodeStatementCollection Statements { get; } = new CodeStatementCollection();
	}
}
