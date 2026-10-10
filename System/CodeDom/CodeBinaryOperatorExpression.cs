using System;

namespace System.CodeDom
{
	/// <summary>Представляет выражение, состоящее из бинарной операции между двумя выражениями.</summary>
	// Token: 0x020002F9 RID: 761
	[Serializable]
	public class CodeBinaryOperatorExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeBinaryOperatorExpression" />.</summary>
		// Token: 0x06001859 RID: 6233 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeBinaryOperatorExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeBinaryOperatorExpression" />, используя заданные параметры.</summary>
		/// <param name="left">
		///   <see cref="T:System.CodeDom.CodeExpression" /> слева от оператора.</param>
		/// <param name="op">
		///   <see cref="T:System.CodeDom.CodeBinaryOperatorType" />, указывающий тип оператора.</param>
		/// <param name="right">
		///   <see cref="T:System.CodeDom.CodeExpression" /> справа от оператора.</param>
		// Token: 0x0600185A RID: 6234 RVA: 0x0005F3E0 File Offset: 0x0005D5E0
		public CodeBinaryOperatorExpression(CodeExpression left, CodeBinaryOperatorType op, CodeExpression right)
		{
			this.Right = right;
			this.Operator = op;
			this.Left = left;
		}

		/// <summary>Получает или задает кодовое выражение справа от оператора.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий правый операнд.</returns>
		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x0005F3FD File Offset: 0x0005D5FD
		// (set) Token: 0x0600185C RID: 6236 RVA: 0x0005F405 File Offset: 0x0005D605
		public CodeExpression Right { get; set; }

		/// <summary>Получает или задает кодовое выражение слева от оператора.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий левый операнд.</returns>
		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x0005F40E File Offset: 0x0005D60E
		// (set) Token: 0x0600185E RID: 6238 RVA: 0x0005F416 File Offset: 0x0005D616
		public CodeExpression Left { get; set; }

		/// <summary>Получает или задает оператор в выражении бинарного оператора.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeBinaryOperatorType" />, указывающий тип оператора в выражении.</returns>
		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x0005F41F File Offset: 0x0005D61F
		// (set) Token: 0x06001860 RID: 6240 RVA: 0x0005F427 File Offset: 0x0005D627
		public CodeBinaryOperatorType Operator { get; set; }
	}
}
