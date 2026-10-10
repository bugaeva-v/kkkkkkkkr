using System;

namespace System.CodeDom
{
	/// <summary>Представляет оператор <see langword="goto" />.</summary>
	// Token: 0x02000311 RID: 785
	[Serializable]
	public class CodeGotoStatement : CodeStatement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeGotoStatement" />.</summary>
		// Token: 0x060018F6 RID: 6390 RVA: 0x0005F0D5 File Offset: 0x0005D2D5
		public CodeGotoStatement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeGotoStatement" />, используя указанное имя метки.</summary>
		/// <param name="label">Имя метки, откуда следует продолжить выполнение программы.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="Label" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060018F7 RID: 6391 RVA: 0x0005FCB9 File Offset: 0x0005DEB9
		public CodeGotoStatement(string label)
		{
			this.Label = label;
		}

		/// <summary>Получает или задает имя метки, откуда следует продолжить выполнение программы.</summary>
		/// <returns>Строка, указывающая имя метки, откуда следует продолжить выполнение программы.</returns>
		/// <exception cref="T:System.ArgumentNullException">Метка не может быть задана, так как <paramref name="value" /> имеет значение <see langword="null" /> или является пустой строкой.</exception>
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0005FCC8 File Offset: 0x0005DEC8
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0005FCD0 File Offset: 0x0005DED0
		public string Label
		{
			get
			{
				return this._label;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException("value");
				}
				this._label = value;
			}
		}

		// Token: 0x04000D8D RID: 3469
		private string _label;
	}
}
