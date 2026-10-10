using System;

namespace System.CodeDom
{
	/// <summary>Представляет элемент типа с помощью фрагмента исходного кода.</summary>
	// Token: 0x0200032C RID: 812
	[Serializable]
	public class CodeSnippetTypeMember : CodeTypeMember
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeSnippetTypeMember" />.</summary>
		// Token: 0x060019C9 RID: 6601 RVA: 0x0005FE51 File Offset: 0x0005E051
		public CodeSnippetTypeMember()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeSnippetTypeMember" /> с помощью указанного текста.</summary>
		/// <param name="text">Фрагмент исходного кода для элемента типа.</param>
		// Token: 0x060019CA RID: 6602 RVA: 0x00060D3F File Offset: 0x0005EF3F
		public CodeSnippetTypeMember(string text)
		{
			this.Text = text;
		}

		/// <summary>Получает или задает фрагмент исходного кода для элемента типа.</summary>
		/// <returns>Фрагмент исходного кода для элемента типа.</returns>
		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x00060D4E File Offset: 0x0005EF4E
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x00060D5F File Offset: 0x0005EF5F
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

		// Token: 0x04000DDA RID: 3546
		private string _text;
	}
}
