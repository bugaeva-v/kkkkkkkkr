using System;
using System.Globalization;

namespace System.Drawing.Printing
{
	/// <summary>Задает размер бумажного листа.</summary>
	// Token: 0x020000BB RID: 187
	[Serializable]
	public class PaperSize
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PaperSize" />.</summary>
		// Token: 0x06000A8C RID: 2700 RVA: 0x000181ED File Offset: 0x000163ED
		public PaperSize()
		{
			this._kind = PaperKind.Custom;
			this._name = string.Empty;
			this._createdByDefaultConstructor = true;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0001820E File Offset: 0x0001640E
		internal PaperSize(PaperKind kind, string name, int width, int height)
		{
			this._kind = kind;
			this._name = name;
			this._width = width;
			this._height = height;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Printing.PaperSize" />.</summary>
		/// <param name="name">Название формата.</param>
		/// <param name="width">Ширина бумаги в сотых долях дюйма.</param>
		/// <param name="height">Высота бумаги в сотых долях дюйма.</param>
		// Token: 0x06000A8E RID: 2702 RVA: 0x00018233 File Offset: 0x00016433
		public PaperSize(string name, int width, int height)
		{
			this._kind = PaperKind.Custom;
			this._name = name;
			this._width = width;
			this._height = height;
		}

		/// <summary>Получает или задает высоту бумаги в сотых долях дюйма.</summary>
		/// <returns>Высота бумаги в сотых долях дюйма.</returns>
		/// <exception cref="T:System.ArgumentException">Свойству <see cref="P:System.Drawing.Printing.PaperSize.Kind" /> невозможно присвоить значение <see cref="F:System.Drawing.Printing.PaperKind.Custom" />.</exception>
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00018257 File Offset: 0x00016457
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x0001825F File Offset: 0x0001645F
		public int Height
		{
			get
			{
				return this._height;
			}
			set
			{
				if (this._kind != PaperKind.Custom && !this._createdByDefaultConstructor)
				{
					throw new ArgumentException(SR.Format("PaperSize cannot be changed unless the Kind property is set to Custom.", Array.Empty<object>()));
				}
				this._height = value;
			}
		}

		/// <summary>Получает тип бумаги.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Drawing.Printing.PaperKind" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойству <see cref="P:System.Drawing.Printing.PaperSize.Kind" /> невозможно присвоить значение <see cref="F:System.Drawing.Printing.PaperKind.Custom" />.</exception>
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0001828D File Offset: 0x0001648D
		public PaperKind Kind
		{
			get
			{
				if (this._kind <= PaperKind.PrcEnvelopeNumber10Rotated && this._kind != (PaperKind)48 && this._kind != (PaperKind)49)
				{
					return this._kind;
				}
				return PaperKind.Custom;
			}
		}

		/// <summary>Получает или задает формат и тип бумаги.</summary>
		/// <returns>Название формата и тип бумаги.</returns>
		/// <exception cref="T:System.ArgumentException">Свойству <see cref="P:System.Drawing.Printing.PaperSize.Kind" /> невозможно присвоить значение <see cref="F:System.Drawing.Printing.PaperKind.Custom" />.</exception>
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x000182B5 File Offset: 0x000164B5
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x000182BD File Offset: 0x000164BD
		public string PaperName
		{
			get
			{
				return this._name;
			}
			set
			{
				if (this._kind != PaperKind.Custom && !this._createdByDefaultConstructor)
				{
					throw new ArgumentException(SR.Format("PaperSize cannot be changed unless the Kind property is set to Custom.", Array.Empty<object>()));
				}
				this._name = value;
			}
		}

		/// <summary>Возвращает или задает целое число, предоставляющее одно из значений <see cref="T:System.Drawing.Printing.PaperSize" /> или пользовательское значение.</summary>
		/// <returns>Целое значение, представляющее одно из значений <see cref="T:System.Drawing.Printing.PaperSize" /> или пользовательское значение.</returns>
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x000182EB File Offset: 0x000164EB
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x000182F3 File Offset: 0x000164F3
		public int RawKind
		{
			get
			{
				return (int)this._kind;
			}
			set
			{
				this._kind = (PaperKind)value;
			}
		}

		/// <summary>Получает или задает ширину бумаги в сотых долях дюйма.</summary>
		/// <returns>Ширина бумаги в сотых долях дюйма.</returns>
		/// <exception cref="T:System.ArgumentException">Свойству <see cref="P:System.Drawing.Printing.PaperSize.Kind" /> невозможно присвоить значение <see cref="F:System.Drawing.Printing.PaperKind.Custom" />.</exception>
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x000182FC File Offset: 0x000164FC
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x00018304 File Offset: 0x00016504
		public int Width
		{
			get
			{
				return this._width;
			}
			set
			{
				if (this._kind != PaperKind.Custom && !this._createdByDefaultConstructor)
				{
					throw new ArgumentException(SR.Format("PaperSize cannot be changed unless the Kind property is set to Custom.", Array.Empty<object>()));
				}
				this._width = value;
			}
		}

		/// <summary>Предоставляет сведения о <see cref="T:System.Drawing.Printing.PaperSize" /> в форме строки.</summary>
		/// <returns>Строка.</returns>
		// Token: 0x06000A98 RID: 2712 RVA: 0x00018334 File Offset: 0x00016534
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"[PaperSize ",
				this.PaperName,
				" Kind=",
				this.Kind.ToString(),
				" Height=",
				this.Height.ToString(CultureInfo.InvariantCulture),
				" Width=",
				this.Width.ToString(CultureInfo.InvariantCulture),
				"]"
			});
		}

		// Token: 0x040006E1 RID: 1761
		private PaperKind _kind;

		// Token: 0x040006E2 RID: 1762
		private string _name;

		// Token: 0x040006E3 RID: 1763
		private int _width;

		// Token: 0x040006E4 RID: 1764
		private int _height;

		// Token: 0x040006E5 RID: 1765
		private bool _createdByDefaultConstructor;
	}
}
