using System;

namespace System.CodeDom
{
	/// <summary>Представляет комментарий.</summary>
	// Token: 0x020002FF RID: 767
	[Serializable]
	public class CodeComment : CodeObject
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeComment" />.</summary>
		// Token: 0x06001887 RID: 6279 RVA: 0x0005F685 File Offset: 0x0005D885
		public CodeComment()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeComment" /> с указанным текстом в качестве содержимого.</summary>
		/// <param name="text">Содержимое комментария.</param>
		// Token: 0x06001888 RID: 6280 RVA: 0x0005F68D File Offset: 0x0005D88D
		public CodeComment(string text)
		{
			this.Text = text;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeComment" />, используя указанный текст и флаг комментария документации.</summary>
		/// <param name="text">Содержимое комментария.</param>
		/// <param name="docComment">Значение <see langword="true" />, если комментарий является комментарием документации; в противном случае — <see langword="false" />.</param>
		// Token: 0x06001889 RID: 6281 RVA: 0x0005F69C File Offset: 0x0005D89C
		public CodeComment(string text, bool docComment)
		{
			this.Text = text;
			this.DocComment = docComment;
		}

		/// <summary>Получает или задает значение, указывающее, является ли комментарий комментарием документации.</summary>
		/// <returns>Значение <see langword="true" />, если комментарий является комментарием документации; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x0005F6B2 File Offset: 0x0005D8B2
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x0005F6BA File Offset: 0x0005D8BA
		public bool DocComment { get; set; }

		/// <summary>Получает или задает текст комментария.</summary>
		/// <returns>Строка, содержащая текст комментария.</returns>
		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x0005F6C3 File Offset: 0x0005D8C3
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x0005F6D4 File Offset: 0x0005D8D4
		public string Text
		{
			get
			{
				return this._text ?? string.Empty;
			}
			set
			{
				this._text = value;
			}
		}

		// Token: 0x04000D73 RID: 3443
		private string _text;
	}
}
