using System;

namespace System.Drawing
{
	/// <summary>Задает шрифты, используемые для отображения текста в графических элементах Windows.</summary>
	// Token: 0x0200008B RID: 139
	public sealed class SystemFonts
	{
		// Token: 0x06000771 RID: 1905 RVA: 0x00002050 File Offset: 0x00000250
		private SystemFonts()
		{
		}

		/// <summary>Возвращает объект шрифта, который соответствует имени шрифта заданной системы.</summary>
		/// <param name="systemFontName">Имя системного шрифта, для которого требуется объект шрифта.</param>
		/// <returns>Шрифт <see cref="T:System.Drawing.Font" />, если заданное имя совпадает со значением в <see cref="T:System.Drawing.SystemFonts" />; иначе это <see langword="null" />.</returns>
		// Token: 0x06000772 RID: 1906 RVA: 0x00015FF8 File Offset: 0x000141F8
		public static Font GetFontByName(string systemFontName)
		{
			if (systemFontName == "CaptionFont")
			{
				return SystemFonts.CaptionFont;
			}
			if (systemFontName == "DefaultFont")
			{
				return SystemFonts.DefaultFont;
			}
			if (systemFontName == "DialogFont")
			{
				return SystemFonts.DialogFont;
			}
			if (systemFontName == "IconTitleFont")
			{
				return SystemFonts.IconTitleFont;
			}
			if (systemFontName == "MenuFont")
			{
				return SystemFonts.MenuFont;
			}
			if (systemFontName == "MessageBoxFont")
			{
				return SystemFonts.MessageBoxFont;
			}
			if (systemFontName == "SmallCaptionFont")
			{
				return SystemFonts.SmallCaptionFont;
			}
			if (systemFontName == "StatusFont")
			{
				return SystemFonts.StatusFont;
			}
			return null;
		}

		/// <summary>Получает объект <see cref="T:System.Drawing.Font" />, который используется для отображения текста в заголовках окон.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Font" />, который используется для отображения текста в заголовках окон.</returns>
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0001609E File Offset: 0x0001429E
		public static Font CaptionFont
		{
			get
			{
				return new Font("Microsoft Sans Serif", 11f, "CaptionFont");
			}
		}

		/// <summary>Получает шрифт по умолчанию, который может использоваться приложениями для диалоговых окон и форм.</summary>
		/// <returns>Используемый по умолчанию объект <see cref="T:System.Drawing.Font" /> системы. Возвращаемое значение изменяется в зависимости от операционной системы пользователя, а также от языка и региональных параметров используемой системы.</returns>
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x000160B4 File Offset: 0x000142B4
		public static Font DefaultFont
		{
			get
			{
				return new Font("Microsoft Sans Serif", 8.25f, "DefaultFont");
			}
		}

		/// <summary>Получает шрифт, который может использоваться приложениями для диалоговых окон и форм.</summary>
		/// <returns>Шрифт <see cref="T:System.Drawing.Font" />, который может использоваться для диалоговых окон и форм в зависимости от операционной системы и локальных настроек языка и региональных параметров системы.</returns>
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x000160CA File Offset: 0x000142CA
		public static Font DialogFont
		{
			get
			{
				return new Font("Tahoma", 8f, "DialogFont");
			}
		}

		/// <summary>Получает объект <see cref="T:System.Drawing.Font" />, который используется для сигнатур значков.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Font" />, который используется для сигнатур значков.</returns>
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x000160E0 File Offset: 0x000142E0
		public static Font IconTitleFont
		{
			get
			{
				return new Font("Microsoft Sans Serif", 11f, "IconTitleFont");
			}
		}

		/// <summary>Получает объект <see cref="T:System.Drawing.Font" />, который используется для меню.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Font" />, который используется для меню.</returns>
		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x000160F6 File Offset: 0x000142F6
		public static Font MenuFont
		{
			get
			{
				return new Font("Microsoft Sans Serif", 11f, "MenuFont");
			}
		}

		/// <summary>Получает объект <see cref="T:System.Drawing.Font" />, который используется для окон сообщений.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Font" />, который используется для окон сообщений.</returns>
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0001610C File Offset: 0x0001430C
		public static Font MessageBoxFont
		{
			get
			{
				return new Font("Microsoft Sans Serif", 11f, "MessageBoxFont");
			}
		}

		/// <summary>Получает объект <see cref="T:System.Drawing.Font" />, который используется для отображения текста в заголовках небольших окон, таких как окна инструментов.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Font" />, который используется для отображения текста в заголовках небольших окон, таких как окна инструментов.</returns>
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x00016122 File Offset: 0x00014322
		public static Font SmallCaptionFont
		{
			get
			{
				return new Font("Microsoft Sans Serif", 11f, "SmallCaptionFont");
			}
		}

		/// <summary>Получает объект <see cref="T:System.Drawing.Font" />, который используется для отображения текста в строке состояния.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Font" />, который используется для отображения текста в строке состояния.</returns>
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00016138 File Offset: 0x00014338
		public static Font StatusFont
		{
			get
			{
				return new Font("Microsoft Sans Serif", 11f, "StatusFont");
			}
		}
	}
}
