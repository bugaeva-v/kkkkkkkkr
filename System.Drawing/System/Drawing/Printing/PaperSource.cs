using System;

namespace System.Drawing.Printing
{
	/// <summary>Задает лоток, из которого принтер берет бумагу.</summary>
	// Token: 0x020000BC RID: 188
	[Serializable]
	public class PaperSource
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PaperSource" />.</summary>
		// Token: 0x06000A99 RID: 2713 RVA: 0x000183C1 File Offset: 0x000165C1
		public PaperSource()
		{
			this._kind = PaperSourceKind.Custom;
			this._name = string.Empty;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000183DF File Offset: 0x000165DF
		internal PaperSource(PaperSourceKind kind, string name)
		{
			this._kind = kind;
			this._name = name;
		}

		/// <summary>Получает источник бумаги.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Drawing.Printing.PaperSourceKind" />.</returns>
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x000183F5 File Offset: 0x000165F5
		public PaperSourceKind Kind
		{
			get
			{
				if (this._kind >= (PaperSourceKind)256)
				{
					return PaperSourceKind.Custom;
				}
				return this._kind;
			}
		}

		/// <summary>Возвращает или задает целое число, представляющее одно из значений <see cref="T:System.Drawing.Printing.PaperSourceKind" /> или пользовательское значение.</summary>
		/// <returns>Целое значение, представляющее одно из значений <see cref="T:System.Drawing.Printing.PaperSourceKind" /> или пользовательское значение.</returns>
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00018410 File Offset: 0x00016610
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00018418 File Offset: 0x00016618
		public int RawKind
		{
			get
			{
				return (int)this._kind;
			}
			set
			{
				this._kind = (PaperSourceKind)value;
			}
		}

		/// <summary>Получает или задает название источника бумаги.</summary>
		/// <returns>Имя источника бумаги.</returns>
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00018421 File Offset: 0x00016621
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00018429 File Offset: 0x00016629
		public string SourceName
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		/// <summary>Предоставляет сведения о <see cref="T:System.Drawing.Printing.PaperSource" /> в форме строки.</summary>
		/// <returns>Строка.</returns>
		// Token: 0x06000AA0 RID: 2720 RVA: 0x00018434 File Offset: 0x00016634
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"[PaperSource ",
				this.SourceName,
				" Kind=",
				this.Kind.ToString(),
				"]"
			});
		}

		// Token: 0x040006E6 RID: 1766
		private string _name;

		// Token: 0x040006E7 RID: 1767
		private PaperSourceKind _kind;
	}
}
