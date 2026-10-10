using System;

namespace System.CodeDom
{
	/// <summary>Представляет исходное выражение.</summary>
	// Token: 0x0200032A RID: 810
	[Serializable]
	public class CodeSnippetExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeSnippetExpression" />.</summary>
		// Token: 0x060019C1 RID: 6593 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeSnippetExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeSnippetExpression" />, используя указанное исходное выражение.</summary>
		/// <param name="value">Исходное выражение для представления.</param>
		// Token: 0x060019C2 RID: 6594 RVA: 0x00060CED File Offset: 0x0005EEED
		public CodeSnippetExpression(string value)
		{
			this.Value = value;
		}

		/// <summary>Получает или задает исходную строку кода.</summary>
		/// <returns>Исходная строка.</returns>
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x00060CFC File Offset: 0x0005EEFC
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x00060D0D File Offset: 0x0005EF0D
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

		// Token: 0x04000DD8 RID: 3544
		private string _value;
	}
}
