using System;

namespace System.Drawing
{
	/// <summary>Каждое свойство класса <see cref="T:System.Drawing.SystemIcons" /> является объектом <see cref="T:System.Drawing.Icon" /> для стандартных значков, используемых в системе Windows. Этот класс не наследуется.</summary>
	// Token: 0x0200008C RID: 140
	public sealed class SystemIcons
	{
		// Token: 0x0600077B RID: 1915 RVA: 0x00016150 File Offset: 0x00014350
		static SystemIcons()
		{
			SystemIcons.icons[0] = new Icon("Mono.ico", true);
			SystemIcons.icons[1] = new Icon("Information.ico", true);
			SystemIcons.icons[2] = new Icon("Error.ico", true);
			SystemIcons.icons[3] = new Icon("Warning.ico", true);
			SystemIcons.icons[4] = new Icon("Question.ico", true);
			SystemIcons.icons[5] = new Icon("Shield.ico", true);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00002050 File Offset: 0x00000250
		private SystemIcons()
		{
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Icon" />, который содержит стандартный значок приложения (WIN32: IDI_APPLICATION).</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Icon" />, содержащий стандартный значок приложения.</returns>
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x000161D4 File Offset: 0x000143D4
		public static Icon Application
		{
			get
			{
				return SystemIcons.icons[0];
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Icon" />, который содержит системный значок звездочки (WIN32: IDI_ASTERISK).</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Icon" />, содержащий системный значок звездочки.</returns>
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x000161DD File Offset: 0x000143DD
		public static Icon Asterisk
		{
			get
			{
				return SystemIcons.icons[1];
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Icon" />, который содержит системный значок ошибки (WIN32: IDI_ERROR).</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Icon" />, содержащий системный значок ошибки.</returns>
		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x000161E6 File Offset: 0x000143E6
		public static Icon Error
		{
			get
			{
				return SystemIcons.icons[2];
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Icon" />, который содержит системный значок восклицательного знака (WIN32: IDI_EXCLAMATION).</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Icon" />, содержащий системный значок восклицательного знака.</returns>
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x000161EF File Offset: 0x000143EF
		public static Icon Exclamation
		{
			get
			{
				return SystemIcons.icons[3];
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Icon" />, который содержит системный значок руки (WIN32: IDI_HAND).</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Icon" />, содержащий системный значок руки.</returns>
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x000161E6 File Offset: 0x000143E6
		public static Icon Hand
		{
			get
			{
				return SystemIcons.icons[2];
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Icon" />, который содержит системный значок сведений (WIN32: IDI_INFORMATION).</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Icon" />, содержащий системный значок сведений.</returns>
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x000161DD File Offset: 0x000143DD
		public static Icon Information
		{
			get
			{
				return SystemIcons.icons[1];
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Icon" />, который содержит системный значок вопроса (WIN32: IDI_QUESTION).</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Icon" />, содержащий системный значок вопроса.</returns>
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x000161F8 File Offset: 0x000143F8
		public static Icon Question
		{
			get
			{
				return SystemIcons.icons[4];
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Icon" />, который содержит системный значок предупреждения (WIN32: IDI_WARNING).</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Icon" />, содержащий системный значок предупреждения.</returns>
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x000161EF File Offset: 0x000143EF
		public static Icon Warning
		{
			get
			{
				return SystemIcons.icons[3];
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Icon" />, который содержит системный значок эмблемы Windows (WIN32: IDI_WINLOGO).</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Icon" />, содержащий системный значок эмблемы Windows.</returns>
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x000161D4 File Offset: 0x000143D4
		public static Icon WinLogo
		{
			get
			{
				return SystemIcons.icons[0];
			}
		}

		/// <summary>Получает объект <see cref="T:System.Drawing.Icon" />, который содержит значок щита.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Icon" />, который содержит значок щита (WIN32: IDI_HAND).</returns>
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00016201 File Offset: 0x00014401
		public static Icon Shield
		{
			get
			{
				return SystemIcons.icons[5];
			}
		}

		// Token: 0x0400056A RID: 1386
		private static Icon[] icons = new Icon[6];

		// Token: 0x0400056B RID: 1387
		private const int Application_Winlogo = 0;

		// Token: 0x0400056C RID: 1388
		private const int Asterisk_Information = 1;

		// Token: 0x0400056D RID: 1389
		private const int Error_Hand = 2;

		// Token: 0x0400056E RID: 1390
		private const int Exclamation_Warning = 3;

		// Token: 0x0400056F RID: 1391
		private const int Question_ = 4;

		// Token: 0x04000570 RID: 1392
		private const int Shield_ = 5;
	}
}
