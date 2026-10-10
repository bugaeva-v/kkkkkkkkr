using System;

namespace System.CodeDom
{
	/// <summary>Представляет оператор возвращаемого значения.</summary>
	// Token: 0x0200031B RID: 795
	[Serializable]
	public class CodeMethodReturnStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeMethodReturnStatement" />.</summary>
		// Token: 0x06001946 RID: 6470 RVA: 0x0005F0D5 File Offset: 0x0005D2D5
		public CodeMethodReturnStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeMethodReturnStatement" />, используя заданное выражение.</summary>
		/// <param name="expression">
		///   <see cref="T:System.CodeDom.CodeExpression" /> указывает возвращаемое значение.</param>
		// Token: 0x06001947 RID: 6471 RVA: 0x000603D2 File Offset: 0x0005E5D2
		public CodeMethodReturnStatement(CodeExpression expression)
		{
			this.Expression = expression;
		}

		/// <summary>Получает или задает возвращаемое значение.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий возвращаемое значение для возвращаемого оператора или <see langword="null" />, если оператор является частью подпрограммы.</returns>
		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x000603E1 File Offset: 0x0005E5E1
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x000603E9 File Offset: 0x0005E5E9
		public CodeExpression Expression { get; set; }
	}
}
