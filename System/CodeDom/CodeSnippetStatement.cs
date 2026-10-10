using System;

namespace System.CodeDom
{
	/// <summary>Представляет оператор, использующий фрагмент исходного кода.</summary>
	// Token: 0x0200032B RID: 811
	[Serializable]
	public class CodeSnippetStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeSnippetStatement" />.</summary>
		// Token: 0x060019C5 RID: 6597 RVA: 0x0005F0D5 File Offset: 0x0005D2D5
		public CodeSnippetStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeSnippetStatement" />, используя указанный фрагмент кода.</summary>
		/// <param name="value">Фрагмент исходного кода оператора для представления.</param>
		// Token: 0x060019C6 RID: 6598 RVA: 0x00060D16 File Offset: 0x0005EF16
		public CodeSnippetStatement(string value)
		{
			this.Value = value;
		}

		/// <summary>Получает или задает оператор фрагмента исходного кода.</summary>
		/// <returns>Оператор фрагмента исходного кода.</returns>
		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x00060D25 File Offset: 0x0005EF25
		// (set) Token: 0x060019C8 RID: 6600 RVA: 0x00060D36 File Offset: 0x0005EF36
		public string Value
		{
			get
			{
				return this._value ?? string.Empty;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x04000DD9 RID: 3545
		private string _value;
	}
}
