using System;

namespace System.CodeDom
{
	/// <summary>Представляет оператор, вызывающий исключение.</summary>
	// Token: 0x02000330 RID: 816
	[Serializable]
	public class CodeThrowExceptionStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeThrowExceptionStatement" />.</summary>
		// Token: 0x060019E1 RID: 6625 RVA: 0x0005F0D5 File Offset: 0x0005D2D5
		public CodeThrowExceptionStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeThrowExceptionStatement" /> с указанным экземпляром типа исключения.</summary>
		/// <param name="toThrow">
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий создаваемое исключение.</param>
		// Token: 0x060019E2 RID: 6626 RVA: 0x00060E78 File Offset: 0x0005F078
		public CodeThrowExceptionStatement(CodeExpression toThrow)
		{
			this.ToThrow = toThrow;
		}

		/// <summary>Получает или задает создаваемое исключение.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpression" />, представляющий экземпляр создаваемого исключения.</returns>
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x00060E87 File Offset: 0x0005F087
		// (set) Token: 0x060019E4 RID: 6628 RVA: 0x00060E8F File Offset: 0x0005F08F
		public CodeExpression ToThrow { get; set; }
	}
}
