using System;

namespace System.CodeDom
{
	/// <summary>Представляет оператор, состоящий из одного комментария.</summary>
	// Token: 0x02000300 RID: 768
	[Serializable]
	public class CodeCommentStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCommentStatement" />.</summary>
		// Token: 0x0600188E RID: 6286 RVA: 0x0005F0D5 File Offset: 0x0005D2D5
		public CodeCommentStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCommentStatement" />, используя указанный комментарий.</summary>
		/// <param name="comment">
		///   <see cref="T:System.CodeDom.CodeComment" />, указывающий комментарий.</param>
		// Token: 0x0600188F RID: 6287 RVA: 0x0005F6DD File Offset: 0x0005D8DD
		public CodeCommentStatement(CodeComment comment)
		{
			this.Comment = comment;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCommentStatement" />, используя указанный текст в качестве содержимого.</summary>
		/// <param name="text">Содержимое комментария.</param>
		// Token: 0x06001890 RID: 6288 RVA: 0x0005F6EC File Offset: 0x0005D8EC
		public CodeCommentStatement(string text)
		{
			this.Comment = new CodeComment(text);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeCommentStatement" />, используя указанный текст и флаг комментария документации.</summary>
		/// <param name="text">Содержимое комментария.</param>
		/// <param name="docComment">Значение <see langword="true" />, если комментарий является комментарием документации; в противном случае — <see langword="false" />.</param>
		// Token: 0x06001891 RID: 6289 RVA: 0x0005F700 File Offset: 0x0005D900
		public CodeCommentStatement(string text, bool docComment)
		{
			this.Comment = new CodeComment(text, docComment);
		}

		/// <summary>Получает или задает содержимое комментария.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeComment" />, указывающий комментарий.</returns>
		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x0005F715 File Offset: 0x0005D915
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x0005F71D File Offset: 0x0005D91D
		public CodeComment Comment { get; set; }
	}
}
