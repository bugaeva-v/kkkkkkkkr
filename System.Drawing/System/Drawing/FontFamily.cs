using System;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace System.Drawing
{
	/// <summary>Определяет группу гарнитур шрифта со схожим базовым макетом и определенными различиями в стиле. Этот класс не наследуется.</summary>
	// Token: 0x02000070 RID: 112
	public sealed class FontFamily : MarshalByRefObject, IDisposable
	{
		// Token: 0x0600048D RID: 1165 RVA: 0x0000C246 File Offset: 0x0000A446
		internal FontFamily(IntPtr fntfamily)
		{
			this.nativeFontFamily = fntfamily;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000C260 File Offset: 0x0000A460
		internal unsafe void refreshName()
		{
			if (this.nativeFontFamily == IntPtr.Zero)
			{
				return;
			}
			char* value = stackalloc char[(UIntPtr)64];
			GDIPlus.CheckStatus(GDIPlus.GdipGetFamilyName(this.nativeFontFamily, (IntPtr)((void*)value), 0));
			this.name = Marshal.PtrToStringUni((IntPtr)((void*)value));
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x0600048F RID: 1167 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
		~FontFamily()
		{
			this.Dispose();
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0000C2DC File Offset: 0x0000A4DC
		internal IntPtr NativeObject
		{
			get
			{
				return this.nativeFontFamily;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0000C2DC File Offset: 0x0000A4DC
		internal IntPtr NativeFamily
		{
			get
			{
				return this.nativeFontFamily;
			}
		}

		/// <summary>Инициализирует новое семейство <see cref="T:System.Drawing.FontFamily" /> из указанного универсального семейства шрифтов.</summary>
		/// <param name="genericFamily">Объект <see cref="T:System.Drawing.Text.GenericFontFamilies" />, из которого будет создан новый объект <see cref="T:System.Drawing.FontFamily" />.</param>
		// Token: 0x06000492 RID: 1170 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
		public FontFamily(GenericFontFamilies genericFamily)
		{
			Status status;
			switch (genericFamily)
			{
			case GenericFontFamilies.Serif:
				status = GDIPlus.GdipGetGenericFontFamilySerif(out this.nativeFontFamily);
				goto IL_4D;
			case GenericFontFamilies.SansSerif:
				status = GDIPlus.GdipGetGenericFontFamilySansSerif(out this.nativeFontFamily);
				goto IL_4D;
			}
			status = GDIPlus.GdipGetGenericFontFamilyMonospace(out this.nativeFontFamily);
			IL_4D:
			GDIPlus.CheckStatus(status);
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.FontFamily" /> указанным именем.</summary>
		/// <param name="name">Имя нового набора правил <see cref="T:System.Drawing.FontFamily" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> является пустой строкой ("").  
		///
		/// или - 
		/// <paramref name="name" /> указывает шрифт, не установленный на компьютере, на котором выполняется приложение.  
		///
		/// или - 
		/// <paramref name="name" /> указывает шрифт, который не является шрифтом TrueType.</exception>
		// Token: 0x06000493 RID: 1171 RVA: 0x0000C344 File Offset: 0x0000A544
		public FontFamily(string name) : this(name, null)
		{
		}

		/// <summary>Инициализирует новое семейство шрифтов <see cref="T:System.Drawing.FontFamily" /> в заданной коллекции <see cref="T:System.Drawing.Text.FontCollection" /> указанным именем.</summary>
		/// <param name="name">Объект <see cref="T:System.String" />, представляющий имя нового объекта <see cref="T:System.Drawing.FontFamily" />.</param>
		/// <param name="fontCollection">Коллекция <see cref="T:System.Drawing.Text.FontCollection" />, содержащая это семейство шрифтов <see cref="T:System.Drawing.FontFamily" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> является пустой строкой ("").  
		///
		/// или - 
		/// <paramref name="name" /> указывает шрифт, не установленный на компьютере, на котором выполняется приложение.  
		///
		/// или - 
		/// <paramref name="name" /> указывает шрифт, который не является шрифтом TrueType.</exception>
		// Token: 0x06000494 RID: 1172 RVA: 0x0000C350 File Offset: 0x0000A550
		public FontFamily(string name, FontCollection fontCollection)
		{
			IntPtr collection = (fontCollection == null) ? IntPtr.Zero : fontCollection._nativeFontCollection;
			GDIPlus.CheckStatus(GDIPlus.GdipCreateFontFamilyFromName(name, collection, out this.nativeFontFamily));
		}

		/// <summary>Возвращает имя этого аспекта <see cref="T:System.Drawing.FontFamily" />.</summary>
		/// <returns>Объект <see cref="T:System.String" />, представляющий имя этого объекта <see cref="T:System.Drawing.FontFamily" />.</returns>
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0000C391 File Offset: 0x0000A591
		public string Name
		{
			get
			{
				if (this.nativeFontFamily == IntPtr.Zero)
				{
					throw new ArgumentException("Name", Locale.GetText("Object was disposed."));
				}
				if (this.name == null)
				{
					this.refreshName();
				}
				return this.name;
			}
		}

		/// <summary>Возвращает универсальное моноширинное семейство шрифтов <see cref="T:System.Drawing.FontFamily" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.FontFamily" />, представляющий универсальный моноширинный шрифт.</returns>
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0000C3CE File Offset: 0x0000A5CE
		public static FontFamily GenericMonospace
		{
			get
			{
				return new FontFamily(GenericFontFamilies.Monospace);
			}
		}

		/// <summary>Возвращает универсальный объект <see cref="T:System.Drawing.FontFamily" /> Sans Serif.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.FontFamily" />, представляющий универсальный шрифт Sans Serif.</returns>
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0000C3D6 File Offset: 0x0000A5D6
		public static FontFamily GenericSansSerif
		{
			get
			{
				return new FontFamily(GenericFontFamilies.SansSerif);
			}
		}

		/// <summary>Возвращает универсальный объект <see cref="T:System.Drawing.FontFamily" /> Serif.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.FontFamily" />, представляющий универсальный шрифт Serif.</returns>
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0000C3DE File Offset: 0x0000A5DE
		public static FontFamily GenericSerif
		{
			get
			{
				return new FontFamily(GenericFontFamilies.Serif);
			}
		}

		/// <summary>Возвращает восхождение клетки в единицах измерения конструктора для объекта <see cref="T:System.Drawing.FontFamily" /> с заданным стилем.</summary>
		/// <param name="style">Перечисление <see cref="T:System.Drawing.FontStyle" />, содержащее сведения о стиле для шрифта.</param>
		/// <returns>Восхождение клетки для данного объекта <see cref="T:System.Drawing.FontFamily" />, использующего указанный объект <see cref="T:System.Drawing.FontStyle" />.</returns>
		// Token: 0x06000499 RID: 1177 RVA: 0x0000C3E8 File Offset: 0x0000A5E8
		public int GetCellAscent(FontStyle style)
		{
			short result;
			GDIPlus.CheckStatus(GDIPlus.GdipGetCellAscent(this.nativeFontFamily, (int)style, out result));
			return (int)result;
		}

		/// <summary>Возвращает спуск клетки в единицах измерения конструктора для объекта <see cref="T:System.Drawing.FontFamily" /> с заданным стилем.</summary>
		/// <param name="style">Перечисление <see cref="T:System.Drawing.FontStyle" />, содержащее сведения о стиле для шрифта.</param>
		/// <returns>Метрика спуска клетки для данного объекта <see cref="T:System.Drawing.FontFamily" />, использующего указанный объект <see cref="T:System.Drawing.FontStyle" />.</returns>
		// Token: 0x0600049A RID: 1178 RVA: 0x0000C40C File Offset: 0x0000A60C
		public int GetCellDescent(FontStyle style)
		{
			short result;
			GDIPlus.CheckStatus(GDIPlus.GdipGetCellDescent(this.nativeFontFamily, (int)style, out result));
			return (int)result;
		}

		/// <summary>Возвращает высоту квадрата максимального пробела в единицах измерения конструктора для указанного стиля.</summary>
		/// <param name="style">Перечисление <see cref="T:System.Drawing.FontStyle" />, для которого нужно получить высоту максимального пробела.</param>
		/// <returns>Высота квадрата максимального пробела.</returns>
		// Token: 0x0600049B RID: 1179 RVA: 0x0000C430 File Offset: 0x0000A630
		public int GetEmHeight(FontStyle style)
		{
			short result;
			GDIPlus.CheckStatus(GDIPlus.GdipGetEmHeight(this.nativeFontFamily, (int)style, out result));
			return (int)result;
		}

		/// <summary>Возвращает межстрочный интервал в единицах измерения конструктора для семейства шрифтов <see cref="T:System.Drawing.FontFamily" /> с заданным стилем. Межстрочный интервал — это расстояние по вертикали между двумя опорными линиями двух соседних строк в тексте.</summary>
		/// <param name="style">Применяемый режим <see cref="T:System.Drawing.FontStyle" />.</param>
		/// <returns>Расстояние между двумя соседними строками в тексте.</returns>
		// Token: 0x0600049C RID: 1180 RVA: 0x0000C454 File Offset: 0x0000A654
		public int GetLineSpacing(FontStyle style)
		{
			short result;
			GDIPlus.CheckStatus(GDIPlus.GdipGetLineSpacing(this.nativeFontFamily, (int)style, out result));
			return (int)result;
		}

		/// <summary>Указывает, доступно ли указанное перечисление <see cref="T:System.Drawing.FontStyle" />.</summary>
		/// <param name="style">Объект <see cref="T:System.Drawing.FontStyle" /> для проверки.</param>
		/// <returns>Значение <see langword="true" />, если заданное семейство шрифтов <see cref="T:System.Drawing.FontStyle" /> доступно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600049D RID: 1181 RVA: 0x0000C478 File Offset: 0x0000A678
		[MonoDocumentationNote("When used with libgdiplus this method always return true (styles are created on demand).")]
		public bool IsStyleAvailable(FontStyle style)
		{
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsStyleAvailable(this.nativeFontFamily, (int)style, out result));
			return result;
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.FontFamily" />.</summary>
		// Token: 0x0600049E RID: 1182 RVA: 0x0000C499 File Offset: 0x0000A699
		public void Dispose()
		{
			if (this.nativeFontFamily != IntPtr.Zero)
			{
				Status status = GDIPlus.GdipDeleteFontFamily(this.nativeFontFamily);
				this.nativeFontFamily = IntPtr.Zero;
				GC.SuppressFinalize(this);
				GDIPlus.CheckStatus(status);
			}
		}

		/// <summary>Указывает, является ли заданный объект объектом <see cref="T:System.Drawing.FontFamily" /> и идентичен ли он объекту <see cref="T:System.Drawing.FontFamily" />.</summary>
		/// <param name="obj">Объект для тестирования.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является объектом <see cref="T:System.Drawing.FontFamily" /> и идентичен объекту <see cref="T:System.Drawing.FontFamily" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600049F RID: 1183 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		public override bool Equals(object obj)
		{
			FontFamily fontFamily = obj as FontFamily;
			return fontFamily != null && this.Name == fontFamily.Name;
		}

		/// <summary>Возвращает хэш-код для данного объекта <see cref="T:System.Drawing.FontFamily" />.</summary>
		/// <returns>Хэш-код для этого экземпляра <see cref="T:System.Drawing.FontFamily" />.</returns>
		// Token: 0x060004A0 RID: 1184 RVA: 0x0000C4FA File Offset: 0x0000A6FA
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}

		/// <summary>Возвращает массив, содержащий все объекты <see cref="T:System.Drawing.FontFamily" />, связанные с текущим графическим контекстом.</summary>
		/// <returns>Массив объектов <see cref="T:System.Drawing.FontFamily" />, связанных с текущим графическим контекстом.</returns>
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0000C507 File Offset: 0x0000A707
		public static FontFamily[] Families
		{
			get
			{
				return new InstalledFontCollection().Families;
			}
		}

		/// <summary>Возвращает массив, содержащий все объекты <see cref="T:System.Drawing.FontFamily" />, доступные для указанного графического контекста.</summary>
		/// <param name="graphics">Объект <see cref="T:System.Drawing.Graphics" />, из которого возвращаются объекты <see cref="T:System.Drawing.FontFamily" />.</param>
		/// <returns>Массив всех доступных объектов <see cref="T:System.Drawing.FontFamily" /> для заданного объекта <see cref="T:System.Drawing.Graphics" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="graphics" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004A2 RID: 1186 RVA: 0x0000C513 File Offset: 0x0000A713
		public static FontFamily[] GetFamilies(Graphics graphics)
		{
			if (graphics == null)
			{
				throw new ArgumentNullException("graphics");
			}
			return new InstalledFontCollection().Families;
		}

		/// <summary>Возвращает имя данного семейства шрифтов <see cref="T:System.Drawing.FontFamily" /> на указанном языке.</summary>
		/// <param name="language">Язык, на котором возвращается имя.</param>
		/// <returns>Объект <see cref="T:System.String" />, представляющий имя данного семейства шрифтов <see cref="T:System.Drawing.FontFamily" /> на указанном языке.</returns>
		// Token: 0x060004A3 RID: 1187 RVA: 0x0000C52D File Offset: 0x0000A72D
		[MonoLimitation("The language parameter is ignored. We always return the name using the default system language.")]
		public string GetName(int language)
		{
			return this.Name;
		}

		/// <summary>Преобразует семейство шрифтов <see cref="T:System.Drawing.FontFamily" /> в удобное для восприятия представление.</summary>
		/// <returns>Строка, представляющая семейство шрифтов <see cref="T:System.Drawing.FontFamily" />.</returns>
		// Token: 0x060004A4 RID: 1188 RVA: 0x0000C535 File Offset: 0x0000A735
		public override string ToString()
		{
			return "[FontFamily: Name=" + this.Name + "]";
		}

		// Token: 0x04000492 RID: 1170
		private string name;

		// Token: 0x04000493 RID: 1171
		private IntPtr nativeFontFamily = IntPtr.Zero;
	}
}
