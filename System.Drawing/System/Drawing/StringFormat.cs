using System;
using System.ComponentModel;
using System.Drawing.Text;

namespace System.Drawing
{
	/// <summary>Инкапсулирует сведения о структуре текста (например выравнивание, ориентация и позиции табуляции), операции с отображением (такие как вставка многоточия и замена национальных цифр) и возможности OpenType. Этот класс не наследуется.</summary>
	// Token: 0x0200008A RID: 138
	public sealed class StringFormat : MarshalByRefObject, IDisposable, ICloneable
	{
		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.StringFormat" />.</summary>
		// Token: 0x06000750 RID: 1872 RVA: 0x00015C04 File Offset: 0x00013E04
		public StringFormat() : this((StringFormatFlags)0, 0)
		{
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.StringFormat" /> заданными перечислением <see cref="T:System.Drawing.StringFormatFlags" /> и языком.</summary>
		/// <param name="options">Перечисление <see cref="T:System.Drawing.StringFormatFlags" /> для нового объекта <see cref="T:System.Drawing.StringFormat" />.</param>
		/// <param name="language">Значение, указывающее язык текста.</param>
		// Token: 0x06000751 RID: 1873 RVA: 0x00015C0E File Offset: 0x00013E0E
		public StringFormat(StringFormatFlags options, int language)
		{
			this.nativeStrFmt = IntPtr.Zero;
			base..ctor();
			GDIPlus.CheckStatus(GDIPlus.GdipCreateStringFormat(options, language, out this.nativeStrFmt));
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00015C33 File Offset: 0x00013E33
		internal StringFormat(IntPtr native)
		{
			this.nativeStrFmt = IntPtr.Zero;
			base..ctor();
			this.nativeStrFmt = native;
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x06000753 RID: 1875 RVA: 0x00015C50 File Offset: 0x00013E50
		~StringFormat()
		{
			this.Dispose(false);
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.StringFormat" />.</summary>
		// Token: 0x06000754 RID: 1876 RVA: 0x00015C80 File Offset: 0x00013E80
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00015C8F File Offset: 0x00013E8F
		private void Dispose(bool disposing)
		{
			if (this.nativeStrFmt != IntPtr.Zero)
			{
				Status status = GDIPlus.GdipDeleteStringFormat(this.nativeStrFmt);
				this.nativeStrFmt = IntPtr.Zero;
				GDIPlus.CheckStatus(status);
			}
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.StringFormat" /> из указанного существующего объекта <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <param name="format">Объект <see cref="T:System.Drawing.StringFormat" />, из которого инициализируется новый объект <see cref="T:System.Drawing.StringFormat" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000756 RID: 1878 RVA: 0x00015CBE File Offset: 0x00013EBE
		public StringFormat(StringFormat format)
		{
			this.nativeStrFmt = IntPtr.Zero;
			base..ctor();
			if (format == null)
			{
				throw new ArgumentNullException("format");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCloneStringFormat(format.NativeObject, out this.nativeStrFmt));
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.StringFormat" /> заданным перечислением <see cref="T:System.Drawing.StringFormatFlags" />.</summary>
		/// <param name="options">Перечисление <see cref="T:System.Drawing.StringFormatFlags" /> для нового объекта <see cref="T:System.Drawing.StringFormat" />.</param>
		// Token: 0x06000757 RID: 1879 RVA: 0x00015CF5 File Offset: 0x00013EF5
		public StringFormat(StringFormatFlags options)
		{
			this.nativeStrFmt = IntPtr.Zero;
			base..ctor();
			GDIPlus.CheckStatus(GDIPlus.GdipCreateStringFormat(options, 0, out this.nativeStrFmt));
		}

		/// <summary>Возвращает или задает горизонтальное выравнивание строки.</summary>
		/// <returns>Перечисление <see cref="T:System.Drawing.StringAlignment" />, задающее горизонтальное выравнивание строки.</returns>
		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00015D1C File Offset: 0x00013F1C
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00015D3C File Offset: 0x00013F3C
		public StringAlignment Alignment
		{
			get
			{
				StringAlignment result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetStringFormatAlign(this.nativeStrFmt, out result));
				return result;
			}
			set
			{
				if (value < StringAlignment.Near || value > StringAlignment.Far)
				{
					throw new InvalidEnumArgumentException("Alignment");
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetStringFormatAlign(this.nativeStrFmt, value));
			}
		}

		/// <summary>Возвращает или задает вертикальное выравнивание строки.</summary>
		/// <returns>Перечисление <see cref="T:System.Drawing.StringAlignment" />, представляющее вертикальное выравнивание строки.</returns>
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00015D64 File Offset: 0x00013F64
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00015D84 File Offset: 0x00013F84
		public StringAlignment LineAlignment
		{
			get
			{
				StringAlignment result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetStringFormatLineAlign(this.nativeStrFmt, out result));
				return result;
			}
			set
			{
				if (value < StringAlignment.Near || value > StringAlignment.Far)
				{
					throw new InvalidEnumArgumentException("Alignment");
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetStringFormatLineAlign(this.nativeStrFmt, value));
			}
		}

		/// <summary>Возвращает или задает перечисление <see cref="T:System.Drawing.StringFormatFlags" />, которое содержит сведения о форматировании.</summary>
		/// <returns>Перечисление <see cref="T:System.Drawing.StringFormatFlags" />, содержащее сведения о форматировании.</returns>
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00015DAC File Offset: 0x00013FAC
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00015DCC File Offset: 0x00013FCC
		public StringFormatFlags FormatFlags
		{
			get
			{
				StringFormatFlags result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetStringFormatFlags(this.nativeStrFmt, out result));
				return result;
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetStringFormatFlags(this.nativeStrFmt, value));
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Drawing.Text.HotkeyPrefix" /> для этого объекта <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Text.HotkeyPrefix" /> для этого объекта <see cref="T:System.Drawing.StringFormat" />, по умолчанию объект <see cref="F:System.Drawing.Text.HotkeyPrefix.None" />.</returns>
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00015DE0 File Offset: 0x00013FE0
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00015E00 File Offset: 0x00014000
		public HotkeyPrefix HotkeyPrefix
		{
			get
			{
				HotkeyPrefix result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetStringFormatHotkeyPrefix(this.nativeStrFmt, out result));
				return result;
			}
			set
			{
				if (value < HotkeyPrefix.None || value > HotkeyPrefix.Hide)
				{
					throw new InvalidEnumArgumentException("HotkeyPrefix");
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetStringFormatHotkeyPrefix(this.nativeStrFmt, value));
			}
		}

		/// <summary>Возвращает или задает перечисление <see cref="T:System.Drawing.StringTrimming" /> для объекта <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <returns>Перечисление <see cref="T:System.Drawing.StringTrimming" />, указывающее, как обрезается текст, отображаемый с этим объектом <see cref="T:System.Drawing.StringFormat" />, если он выходит за пределы прямоугольника размещения.</returns>
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00015E28 File Offset: 0x00014028
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00015E48 File Offset: 0x00014048
		public StringTrimming Trimming
		{
			get
			{
				StringTrimming result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetStringFormatTrimming(this.nativeStrFmt, out result));
				return result;
			}
			set
			{
				if (value < StringTrimming.None || value > StringTrimming.EllipsisPath)
				{
					throw new InvalidEnumArgumentException("Trimming");
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetStringFormatTrimming(this.nativeStrFmt, value));
			}
		}

		/// <summary>Возвращает универсальный объект <see cref="T:System.Drawing.StringFormat" /> по умолчанию.</summary>
		/// <returns>Универсальный объект <see cref="T:System.Drawing.StringFormat" /> по умолчанию.</returns>
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00015E70 File Offset: 0x00014070
		public static StringFormat GenericDefault
		{
			get
			{
				IntPtr native;
				GDIPlus.CheckStatus(GDIPlus.GdipStringFormatGetGenericDefault(out native));
				return new StringFormat(native);
			}
		}

		/// <summary>Возвращает язык, используемый при замене арабских цифр местными.</summary>
		/// <returns>Идентификатор языка многоязыковой поддержки (NLS), определяющий язык, который будет использоваться при замене арабских цифр местными. Свойство <see cref="P:System.Globalization.CultureInfo.LCID" /> объекта <see cref="T:System.Globalization.CultureInfo" /> может быть передано как идентификатор языка NLS. Например, предположим, что объект <see cref="T:System.Globalization.CultureInfo" /> создается путем передачи строки "ar-EG" в конструктор <see cref="T:System.Globalization.CultureInfo" />. Если свойство <see cref="P:System.Globalization.CultureInfo.LCID" /> этого объекта <see cref="T:System.Globalization.CultureInfo" /> вместе с <see cref="F:System.Drawing.StringDigitSubstitute.Traditional" /> передается в метод <see cref="M:System.Drawing.StringFormat.SetDigitSubstitution(System.Int32,System.Drawing.StringDigitSubstitute)" />, то во время отображения арабские цифры будут заменены цифрами Arabic-Indic.</returns>
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00015E8F File Offset: 0x0001408F
		public int DigitSubstitutionLanguage
		{
			get
			{
				return this.language;
			}
		}

		/// <summary>Возвращает универсальный типографский объект <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <returns>Универсальный типографский объект <see cref="T:System.Drawing.StringFormat" />.</returns>
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00015E98 File Offset: 0x00014098
		public static StringFormat GenericTypographic
		{
			get
			{
				IntPtr native;
				GDIPlus.CheckStatus(GDIPlus.GdipStringFormatGetGenericTypographic(out native));
				return new StringFormat(native);
			}
		}

		/// <summary>Возвращает метод, используемый для замены цифр.</summary>
		/// <returns>Значение перечисления <see cref="T:System.Drawing.StringDigitSubstitute" />, указывающее, как выполняется замена в строке знаков, которые не отображаются, потому что не поддерживаются текущим шрифтом.</returns>
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00015EB8 File Offset: 0x000140B8
		public StringDigitSubstitute DigitSubstitutionMethod
		{
			get
			{
				StringDigitSubstitute result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetStringFormatDigitSubstitution(this.nativeStrFmt, this.language, out result));
				return result;
			}
		}

		/// <summary>Задает массив структур <see cref="T:System.Drawing.CharacterRange" />, представляющих диапазоны знаков, измеряемые с помощью вызова метода <see cref="M:System.Drawing.Graphics.MeasureCharacterRanges(System.String,System.Drawing.Font,System.Drawing.RectangleF,System.Drawing.StringFormat)" />.</summary>
		/// <param name="ranges">Массив структур <see cref="T:System.Drawing.CharacterRange" />, который представляет диапазоны знаков, измеряемые с помощью вызова метода <see cref="M:System.Drawing.Graphics.MeasureCharacterRanges(System.String,System.Drawing.Font,System.Drawing.RectangleF,System.Drawing.StringFormat)" />.</param>
		/// <exception cref="T:System.OverflowException">Заданы диапазоны 32 символов.</exception>
		// Token: 0x06000766 RID: 1894 RVA: 0x00015EDE File Offset: 0x000140DE
		public void SetMeasurableCharacterRanges(CharacterRange[] ranges)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipSetStringFormatMeasurableCharacterRanges(this.nativeStrFmt, ranges.Length, ranges));
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00015EF4 File Offset: 0x000140F4
		internal int GetMeasurableCharacterRangeCount()
		{
			int result;
			GDIPlus.CheckStatus(GDIPlus.GdipGetStringFormatMeasurableCharacterRangeCount(this.nativeStrFmt, out result));
			return result;
		}

		/// <summary>Создает точную копию объекта <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.StringFormat" />, создаваемый с помощью данного метода.</returns>
		// Token: 0x06000768 RID: 1896 RVA: 0x00015F14 File Offset: 0x00014114
		public object Clone()
		{
			IntPtr native;
			GDIPlus.CheckStatus(GDIPlus.GdipCloneStringFormat(this.nativeStrFmt, out native));
			return new StringFormat(native);
		}

		/// <summary>Преобразует этот объект <see cref="T:System.Drawing.StringFormat" /> в удобную для восприятия строку.</summary>
		/// <returns>Строковое представление объекта <see cref="T:System.Drawing.StringFormat" />.</returns>
		// Token: 0x06000769 RID: 1897 RVA: 0x00015F3C File Offset: 0x0001413C
		public override string ToString()
		{
			return "[StringFormat, FormatFlags=" + this.FormatFlags.ToString() + "]";
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00015F6C File Offset: 0x0001416C
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00015F74 File Offset: 0x00014174
		internal IntPtr NativeObject
		{
			get
			{
				return this.nativeStrFmt;
			}
			set
			{
				this.nativeStrFmt = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00015F6C File Offset: 0x0001416C
		internal IntPtr nativeFormat
		{
			get
			{
				return this.nativeStrFmt;
			}
		}

		/// <summary>Задает позиции табуляции для объекта <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <param name="firstTabOffset">Число пробелов между началом строки текста и первой позицией табуляции.</param>
		/// <param name="tabStops">Массив расстояний между позициями табуляции, заданный свойством <see cref="P:System.Drawing.Graphics.PageUnit" />.</param>
		// Token: 0x0600076D RID: 1901 RVA: 0x00015F7D File Offset: 0x0001417D
		public void SetTabStops(float firstTabOffset, float[] tabStops)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipSetStringFormatTabStops(this.nativeStrFmt, firstTabOffset, tabStops.Length, tabStops));
		}

		/// <summary>Указывает язык и метод, используемые при замене арабских цифр местными.</summary>
		/// <param name="language">Идентификатор языка многоязыковой поддержки (NLS), определяющий язык, который будет использоваться при замене арабских цифр местными. Свойство <see cref="P:System.Globalization.CultureInfo.LCID" /> объекта <see cref="T:System.Globalization.CultureInfo" /> может быть передано как идентификатор языка NLS. Например, предположим, что объект <see cref="T:System.Globalization.CultureInfo" /> создается путем передачи строки "ar-EG" в конструктор <see cref="T:System.Globalization.CultureInfo" />. Если свойство <see cref="P:System.Globalization.CultureInfo.LCID" /> этого объекта <see cref="T:System.Globalization.CultureInfo" /> вместе с <see cref="F:System.Drawing.StringDigitSubstitute.Traditional" /> передается в метод <see cref="M:System.Drawing.StringFormat.SetDigitSubstitution(System.Int32,System.Drawing.StringDigitSubstitute)" />, то во время отображения арабские цифры будут заменены цифрами Arabic-Indic.</param>
		/// <param name="substitute">Элемент перечисления <see cref="T:System.Drawing.StringDigitSubstitute" />, определяющий способ отображения знаков.</param>
		// Token: 0x0600076E RID: 1902 RVA: 0x00015F94 File Offset: 0x00014194
		public void SetDigitSubstitution(int language, StringDigitSubstitute substitute)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipSetStringFormatDigitSubstitution(this.nativeStrFmt, this.language, substitute));
		}

		/// <summary>Возвращает позиции табуляции для этого объекта <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <param name="firstTabOffset">Число пробелов между началом текстовой строки и первой позицией табуляции.</param>
		/// <returns>Массив расстояний (в количестве пробелов) между позициями табуляции.</returns>
		// Token: 0x0600076F RID: 1903 RVA: 0x00015FB0 File Offset: 0x000141B0
		public float[] GetTabStops(out float firstTabOffset)
		{
			int num = 0;
			firstTabOffset = 0f;
			GDIPlus.CheckStatus(GDIPlus.GdipGetStringFormatTabStopCount(this.nativeStrFmt, out num));
			float[] array = new float[num];
			if (num != 0)
			{
				GDIPlus.CheckStatus(GDIPlus.GdipGetStringFormatTabStops(this.nativeStrFmt, num, out firstTabOffset, array));
			}
			return array;
		}

		// Token: 0x04000568 RID: 1384
		private IntPtr nativeStrFmt;

		// Token: 0x04000569 RID: 1385
		private int language;
	}
}
