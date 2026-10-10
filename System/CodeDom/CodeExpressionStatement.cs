using System;

namespace System.CodeDom
{
	/// <summary>Представляет оператор, состоящий из одного выражения.</summary>
	// Token: 0x0200030F RID: 783
	[Serializable]
	public class CodeExpressionStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeExpressionStatement" />.</summary>
		// Token: 0x060018EC RID: 6380 RVA: 0x0005F0D5 File Offset: 0x0005D2D5
		public CodeExpressionStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeExpressionStatement" />, используя указанное выражение.</summary>
		/// <param name="expression">
		///   <see cref="T:System.CodeDom.CodeExpression" /> для оператора.</param>
		// Token: 0x060018ED RID: 6381 RVA: 0x0005FC58 File Offset: 0x0005DE58
		public CodeExpressionStatement(CodeExpression expression)
		{
			this.Expression = expression;
		}

		/// <summary>Получает или задает выражение для оператора.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает выражение для оператора.</returns>
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x0005FC67 File Offset: 0x0005DE67
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x0005FC6F File Offset: 0x0005DE6F
		public CodeExpression Expression { get; set; }
	}
}
