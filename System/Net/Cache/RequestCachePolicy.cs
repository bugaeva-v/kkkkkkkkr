using System;

namespace System.Net.Cache
{
	/// <summary>Определяет требования приложения к кэшированию ресурсов, получаемых с помощью объектов <see cref="T:System.Net.WebRequest" />.</summary>
	// Token: 0x02000789 RID: 1929
	public class RequestCachePolicy
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Cache.RequestCachePolicy" />.</summary>
		// Token: 0x06003CC4 RID: 15556 RVA: 0x000CEBBC File Offset: 0x000CCDBC
		public RequestCachePolicy() : this(RequestCacheLevel.Default)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Cache.RequestCachePolicy" />. используя указанную политику кэша.</summary>
		/// <param name="level">Значение <see cref="T:System.Net.Cache.RequestCacheLevel" />, указывающее поведение кэша по отношению к ресурсам, полученным с помощью объектов <see cref="T:System.Net.WebRequest" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">уровень не является допустимым значением <see cref="T:System.Net.Cache.RequestCacheLevel" />.</exception>
		// Token: 0x06003CC5 RID: 15557 RVA: 0x000CEBC5 File Offset: 0x000CCDC5
		public RequestCachePolicy(RequestCacheLevel level)
		{
			if (level < RequestCacheLevel.Default || level > RequestCacheLevel.NoCacheNoStore)
			{
				throw new ArgumentOutOfRangeException("level");
			}
			this.m_Level = level;
		}

		/// <summary>Возвращает значение <see cref="T:System.Net.Cache.RequestCacheLevel" />, заданное при построении данного экземпляра.</summary>
		/// <returns>Значение <see cref="T:System.Net.Cache.RequestCacheLevel" />, указывающее поведение кэша по отношению к ресурсам, полученным с помощью объектов <see cref="T:System.Net.WebRequest" />.</returns>
		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06003CC6 RID: 15558 RVA: 0x000CEBE7 File Offset: 0x000CCDE7
		public RequestCacheLevel Level
		{
			get
			{
				return this.m_Level;
			}
		}

		/// <summary>Возвращает строковое представление данного экземпляра.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит свойство <see cref="P:System.Net.Cache.RequestCachePolicy.Level" /> для данного экземпляра.</returns>
		// Token: 0x06003CC7 RID: 15559 RVA: 0x000CEBEF File Offset: 0x000CCDEF
		public override string ToString()
		{
			return "Level:" + this.m_Level.ToString();
		}

		// Token: 0x040023F2 RID: 9202
		private RequestCacheLevel m_Level;
	}
}
