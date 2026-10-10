using System;
using System.Globalization;

namespace System.Net.Cache
{
	/// <summary>Определяет требования приложения к кэшированию ресурсов, получаемых с помощью объектов <see cref="T:System.Net.HttpWebRequest" />.</summary>
	// Token: 0x0200078C RID: 1932
	public class HttpRequestCachePolicy : RequestCachePolicy
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Cache.HttpRequestCachePolicy" />.</summary>
		// Token: 0x06003CC8 RID: 15560 RVA: 0x000CEC0C File Offset: 0x000CCE0C
		public HttpRequestCachePolicy() : this(HttpRequestCacheLevel.Default)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Cache.HttpRequestCachePolicy" />, используя указанную политику кэша.</summary>
		/// <param name="level">Значение <see cref="T:System.Net.Cache.HttpRequestCacheLevel" />.</param>
		// Token: 0x06003CC9 RID: 15561 RVA: 0x000CEC18 File Offset: 0x000CCE18
		public HttpRequestCachePolicy(HttpRequestCacheLevel level) : base(HttpRequestCachePolicy.MapLevel(level))
		{
			this.m_Level = level;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Cache.HttpRequestCachePolicy" />, используя указанные значения времени и контроля времени существования.</summary>
		/// <param name="cacheAgeControl">Одно из следующих значений перечисления <see cref="T:System.Net.Cache.HttpCacheAgeControl" />: <see cref="F:System.Net.Cache.HttpCacheAgeControl.MaxAge" />, <see cref="F:System.Net.Cache.HttpCacheAgeControl.MaxStale" /> или <see cref="F:System.Net.Cache.HttpCacheAgeControl.MinFresh" />.</param>
		/// <param name="ageOrFreshOrStale">Значение <see cref="T:System.TimeSpan" />, которое указывает количество времени.</param>
		/// <exception cref="T:System.ArgumentException">Значение, присвоенное параметру <paramref name="cacheAgeControl" />, нельзя использовать с этим конструктором.</exception>
		// Token: 0x06003CCA RID: 15562 RVA: 0x000CEC64 File Offset: 0x000CCE64
		public HttpRequestCachePolicy(HttpCacheAgeControl cacheAgeControl, TimeSpan ageOrFreshOrStale) : this(HttpRequestCacheLevel.Default)
		{
			switch (cacheAgeControl)
			{
			case HttpCacheAgeControl.MinFresh:
				this.m_MinFresh = ageOrFreshOrStale;
				return;
			case HttpCacheAgeControl.MaxAge:
				this.m_MaxAge = ageOrFreshOrStale;
				return;
			case HttpCacheAgeControl.MaxStale:
				this.m_MaxStale = ageOrFreshOrStale;
				return;
			}
			throw new ArgumentException(SR.GetString("The specified value is not valid in the '{0}' enumeration.", new object[]
			{
				"HttpCacheAgeControl"
			}), "cacheAgeControl");
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Cache.HttpRequestCachePolicy" />, используя указанное максимальное время существования, значение контроля времени существования и значение времени.</summary>
		/// <param name="cacheAgeControl">Значение <see cref="T:System.Net.Cache.HttpCacheAgeControl" />.</param>
		/// <param name="maxAge">Значение <see cref="T:System.TimeSpan" />, указывающее максимальное время существования ресурсов.</param>
		/// <param name="freshOrStale">Значение <see cref="T:System.TimeSpan" />, которое указывает количество времени.</param>
		/// <exception cref="T:System.ArgumentException">Значение, заданное для параметра <paramref name="cacheAgeControl" />, недопустимо.</exception>
		// Token: 0x06003CCB RID: 15563 RVA: 0x000CECCC File Offset: 0x000CCECC
		public HttpRequestCachePolicy(HttpCacheAgeControl cacheAgeControl, TimeSpan maxAge, TimeSpan freshOrStale) : this(HttpRequestCacheLevel.Default)
		{
			switch (cacheAgeControl)
			{
			case HttpCacheAgeControl.MinFresh:
				this.m_MinFresh = freshOrStale;
				return;
			case HttpCacheAgeControl.MaxAge:
				this.m_MaxAge = maxAge;
				return;
			case HttpCacheAgeControl.MaxAgeAndMinFresh:
				this.m_MaxAge = maxAge;
				this.m_MinFresh = freshOrStale;
				return;
			case HttpCacheAgeControl.MaxStale:
				this.m_MaxStale = freshOrStale;
				return;
			case HttpCacheAgeControl.MaxAgeAndMaxStale:
				this.m_MaxAge = maxAge;
				this.m_MaxStale = freshOrStale;
				return;
			}
			throw new ArgumentException(SR.GetString("The specified value is not valid in the '{0}' enumeration.", new object[]
			{
				"HttpCacheAgeControl"
			}), "cacheAgeControl");
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Cache.HttpRequestCachePolicy" />, используя указанную дату синхронизации кэша.</summary>
		/// <param name="cacheSyncDate">Объект <see cref="T:System.DateTime" />, указывающий время сверки ресурсов, которые хранятся в кэше.</param>
		// Token: 0x06003CCC RID: 15564 RVA: 0x000CED5A File Offset: 0x000CCF5A
		public HttpRequestCachePolicy(DateTime cacheSyncDate) : this(HttpRequestCacheLevel.Default)
		{
			this.m_LastSyncDateUtc = cacheSyncDate.ToUniversalTime();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Cache.HttpRequestCachePolicy" />, используя указанное максимальное время существования, значение контроля времени существования, значение времени и дату синхронизации кэша.</summary>
		/// <param name="cacheAgeControl">Значение <see cref="T:System.Net.Cache.HttpCacheAgeControl" />.</param>
		/// <param name="maxAge">Значение <see cref="T:System.TimeSpan" />, указывающее максимальное время существования ресурсов.</param>
		/// <param name="freshOrStale">Значение <see cref="T:System.TimeSpan" />, которое указывает количество времени.</param>
		/// <param name="cacheSyncDate">Объект <see cref="T:System.DateTime" />, указывающий время сверки ресурсов, которые хранятся в кэше.</param>
		// Token: 0x06003CCD RID: 15565 RVA: 0x000CED70 File Offset: 0x000CCF70
		public HttpRequestCachePolicy(HttpCacheAgeControl cacheAgeControl, TimeSpan maxAge, TimeSpan freshOrStale, DateTime cacheSyncDate) : this(cacheAgeControl, maxAge, freshOrStale)
		{
			this.m_LastSyncDateUtc = cacheSyncDate.ToUniversalTime();
		}

		/// <summary>Возвращает значение <see cref="T:System.Net.Cache.HttpRequestCacheLevel" />, заданное при создании экземпляра.</summary>
		/// <returns>Значение <see cref="T:System.Net.Cache.HttpRequestCacheLevel" />, указывающее поведение кэша по отношению к ресурсам, полученным с помощью объектов <see cref="T:System.Net.HttpWebRequest" />.</returns>
		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06003CCE RID: 15566 RVA: 0x000CED88 File Offset: 0x000CCF88
		public new HttpRequestCacheLevel Level
		{
			get
			{
				return this.m_Level;
			}
		}

		/// <summary>Возвращает дату синхронизации кэша для этого экземпляра.</summary>
		/// <returns>Значение <see cref="T:System.DateTime" />, равное дате создания экземпляра. Если дата не задана, значение этого свойства равно <see cref="F:System.DateTime.MinValue" />.</returns>
		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06003CCF RID: 15567 RVA: 0x000CED90 File Offset: 0x000CCF90
		public DateTime CacheSyncDate
		{
			get
			{
				if (this.m_LastSyncDateUtc == DateTime.MinValue || this.m_LastSyncDateUtc == DateTime.MaxValue)
				{
					return this.m_LastSyncDateUtc;
				}
				return this.m_LastSyncDateUtc.ToLocalTime();
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06003CD0 RID: 15568 RVA: 0x000CEDC8 File Offset: 0x000CCFC8
		internal DateTime InternalCacheSyncDateUtc
		{
			get
			{
				return this.m_LastSyncDateUtc;
			}
		}

		/// <summary>Возвращает максимальное время существования, которое разрешено для ресурса, получаемого из кэша.</summary>
		/// <returns>Значение <see cref="T:System.TimeSpan" />, равное максимальному времени существования, которое указывается при создании экземпляра. Если дата не задана, значение этого свойства равно <see cref="F:System.DateTime.MinValue" />.</returns>
		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x000CEDD0 File Offset: 0x000CCFD0
		public TimeSpan MaxAge
		{
			get
			{
				return this.m_MaxAge;
			}
		}

		/// <summary>Возвращает минимальное значение актуальности, которое разрешено для ресурса, получаемого из кэша.</summary>
		/// <returns>Значение <see cref="T:System.TimeSpan" />, задающее минимальное значение актуальности, которое указывается при создании экземпляра. Если дата не задана, значение этого свойства равно <see cref="F:System.DateTime.MinValue" />.</returns>
		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06003CD2 RID: 15570 RVA: 0x000CEDD8 File Offset: 0x000CCFD8
		public TimeSpan MinFresh
		{
			get
			{
				return this.m_MinFresh;
			}
		}

		/// <summary>Возвращает максимальное значение устаревания, которое разрешено для ресурса, получаемого из кэша.</summary>
		/// <returns>Значение <see cref="T:System.TimeSpan" />, равное максимальному значению устаревания, которое указывается при создании экземпляра. Если дата не задана, значение этого свойства равно <see cref="F:System.DateTime.MinValue" />.</returns>
		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06003CD3 RID: 15571 RVA: 0x000CEDE0 File Offset: 0x000CCFE0
		public TimeSpan MaxStale
		{
			get
			{
				return this.m_MaxStale;
			}
		}

		/// <summary>Возвращает строковое представление данного экземпляра.</summary>
		/// <returns>Значение <see cref="T:System.String" />, которое содержит значения свойств для данного экземпляра.</returns>
		// Token: 0x06003CD4 RID: 15572 RVA: 0x000CEDE8 File Offset: 0x000CCFE8
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Level:",
				this.m_Level.ToString(),
				(this.m_MaxAge == TimeSpan.MaxValue) ? string.Empty : (" MaxAge:" + this.m_MaxAge.ToString()),
				(this.m_MinFresh == TimeSpan.MinValue) ? string.Empty : (" MinFresh:" + this.m_MinFresh.ToString()),
				(this.m_MaxStale == TimeSpan.MinValue) ? string.Empty : (" MaxStale:" + this.m_MaxStale.ToString()),
				(this.CacheSyncDate == DateTime.MinValue) ? string.Empty : (" CacheSyncDate:" + this.CacheSyncDate.ToString(CultureInfo.CurrentCulture))
			});
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x000CEEFA File Offset: 0x000CD0FA
		private static RequestCacheLevel MapLevel(HttpRequestCacheLevel level)
		{
			if (level <= HttpRequestCacheLevel.NoCacheNoStore)
			{
				return (RequestCacheLevel)level;
			}
			if (level == HttpRequestCacheLevel.CacheOrNextCacheOnly)
			{
				return RequestCacheLevel.CacheOnly;
			}
			if (level == HttpRequestCacheLevel.Refresh)
			{
				return RequestCacheLevel.Reload;
			}
			throw new ArgumentOutOfRangeException("level");
		}

		// Token: 0x04002404 RID: 9220
		internal static readonly HttpRequestCachePolicy BypassCache = new HttpRequestCachePolicy(HttpRequestCacheLevel.BypassCache);

		// Token: 0x04002405 RID: 9221
		private HttpRequestCacheLevel m_Level;

		// Token: 0x04002406 RID: 9222
		private DateTime m_LastSyncDateUtc = DateTime.MinValue;

		// Token: 0x04002407 RID: 9223
		private TimeSpan m_MaxAge = TimeSpan.MaxValue;

		// Token: 0x04002408 RID: 9224
		private TimeSpan m_MinFresh = TimeSpan.MinValue;

		// Token: 0x04002409 RID: 9225
		private TimeSpan m_MaxStale = TimeSpan.MinValue;
	}
}
