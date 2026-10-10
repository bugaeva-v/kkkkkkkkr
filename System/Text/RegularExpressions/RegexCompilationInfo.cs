using System;

namespace System.Text.RegularExpressions
{
	/// <summary>Представляет сведения о регулярном выражении, используемые для компиляции регулярного выражения в отдельную сборку.</summary>
	// Token: 0x020001FF RID: 511
	[Serializable]
	public class RegexCompilationInfo
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.RegularExpressions.RegexCompilationInfo" />, содержащего сведения о регулярном выражении, которое должно быть включено в сборку.</summary>
		/// <param name="pattern">Регулярное выражение для компилирования.</param>
		/// <param name="options">Параметры регулярного выражения для использования при компилировании регулярного выражения.</param>
		/// <param name="name">Имя типа, представляющего скомпилированное регулярное выражение.</param>
		/// <param name="fullnamespace">Пространство имен, к которому принадлежит новый тип.</param>
		/// <param name="ispublic">Значение <see langword="true" />, чтобы сделать скомпилированное регулярное выражение видимым для всех, иначе значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="name" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pattern" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="fullnamespace" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000DEC RID: 3564 RVA: 0x0003A448 File Offset: 0x00038648
		public RegexCompilationInfo(string pattern, RegexOptions options, string name, string fullnamespace, bool ispublic) : this(pattern, options, name, fullnamespace, ispublic, Regex.s_defaultMatchTimeout)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.RegularExpressions.RegexCompilationInfo" />, содержащего сведения о регулярном выражении с указанным значение времени ожидания, которое должно быть включено в сборку.</summary>
		/// <param name="pattern">Регулярное выражение для компилирования.</param>
		/// <param name="options">Параметры регулярного выражения для использования при компилировании регулярного выражения.</param>
		/// <param name="name">Имя типа, представляющего скомпилированное регулярное выражение.</param>
		/// <param name="fullnamespace">Пространство имен, к которому принадлежит новый тип.</param>
		/// <param name="ispublic">Значение <see langword="true" />, чтобы сделать скомпилированное регулярное выражение видимым для всех, иначе значение <see langword="false" />.</param>
		/// <param name="matchTimeout">Интервал времени ожидания по умолчанию для регулярного выражения.</param>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="name" /> имеет значение <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pattern" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="name" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="fullnamespace" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="matchTimeout" /> отрицательное, равно нулю или больше, чем приблизительно 24 дня.</exception>
		// Token: 0x06000DED RID: 3565 RVA: 0x0003A45C File Offset: 0x0003865C
		public RegexCompilationInfo(string pattern, RegexOptions options, string name, string fullnamespace, bool ispublic, TimeSpan matchTimeout)
		{
			this.Pattern = pattern;
			this.Name = name;
			this.Namespace = fullnamespace;
			this.Options = options;
			this.IsPublic = ispublic;
			this.MatchTimeout = matchTimeout;
		}

		/// <summary>Получает или задает значение, указывающее на то, обладает ли скомпилированное регулярное выражение общей видимостью.</summary>
		/// <returns>Значение <see langword="true" />, если регулярное выражение обладает общей видимостью, иначе значение <see langword="false" />.</returns>
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x0003A491 File Offset: 0x00038691
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x0003A499 File Offset: 0x00038699
		public bool IsPublic { get; set; }

		/// <summary>Получает или задает интервал времени ожидания по умолчанию регулярного выражения.</summary>
		/// <returns>Максимальный интервал времени по умолчанию, который может пройти в операции сравнения с шаблоном, прежде чем возникнет исключение <see cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException" />, или <see cref="F:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />, если контроль времени ожидания отключен.</returns>
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x0003A4A2 File Offset: 0x000386A2
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x0003A4AA File Offset: 0x000386AA
		public TimeSpan MatchTimeout
		{
			get
			{
				return this._matchTimeout;
			}
			set
			{
				Regex.ValidateMatchTimeout(value);
				this._matchTimeout = value;
			}
		}

		/// <summary>Получает или задает имя типа, представляющего скомпилированное регулярное выражение.</summary>
		/// <returns>Имя нового типа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значением этого свойства является <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значением для этого свойства является пустая строка.</exception>
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x0003A4B9 File Offset: 0x000386B9
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x0003A4C1 File Offset: 0x000386C1
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Name");
				}
				if (value.Length == 0)
				{
					throw new ArgumentException(SR.Format("Argument {0} cannot be zero-length.", "Name"), "Name");
				}
				this._name = value;
			}
		}

		/// <summary>Получает или задает пространство имен, к которому принадлежит новый тип.</summary>
		/// <returns>Пространство имен нового типа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значением этого свойства является <see langword="null" />.</exception>
		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x0003A4FA File Offset: 0x000386FA
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x0003A502 File Offset: 0x00038702
		public string Namespace
		{
			get
			{
				return this._nspace;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Namespace");
				}
				this._nspace = value;
			}
		}

		/// <summary>Получает или задает параметры для использования при компилировании регулярного выражения.</summary>
		/// <returns>Побитовое сочетание значений перечисления.</returns>
		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x0003A51A File Offset: 0x0003871A
		// (set) Token: 0x06000DF7 RID: 3575 RVA: 0x0003A522 File Offset: 0x00038722
		public RegexOptions Options { get; set; }

		/// <summary>Получает или задает регулярное выражение для компилирования.</summary>
		/// <returns>Регулярное выражение для компилирования.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значением этого свойства является <see langword="null" />.</exception>
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x0003A52B File Offset: 0x0003872B
		// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x0003A533 File Offset: 0x00038733
		public string Pattern
		{
			get
			{
				return this._pattern;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Pattern");
				}
				this._pattern = value;
			}
		}

		// Token: 0x040008A3 RID: 2211
		private string _pattern;

		// Token: 0x040008A4 RID: 2212
		private string _name;

		// Token: 0x040008A5 RID: 2213
		private string _nspace;

		// Token: 0x040008A6 RID: 2214
		private TimeSpan _matchTimeout;
	}
}
