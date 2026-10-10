using System;

namespace System.Net.Cache
{
	/// <summary>Указывает значение временных величин, которые управляют поведением кэшировния ресурсов, полученных с помощью объектов <see cref="T:System.Net.HttpWebRequest" />.</summary>
	// Token: 0x0200078B RID: 1931
	public enum HttpCacheAgeControl
	{
		/// <summary>Только для внутреннего использования. При попытке использования этого элемента .NET Framework генерирует исключение <see cref="T:System.ArgumentException" />.</summary>
		// Token: 0x040023FE RID: 9214
		None,
		/// <summary>Содержимое может браться из кэша, если время, оставшееся до истечения его срока действия, больше или равно времени, указываемому этим значением.</summary>
		// Token: 0x040023FF RID: 9215
		MinFresh,
		/// <summary>Содержимое может браться из кэша, пока его возраст не превысит это значение.</summary>
		// Token: 0x04002400 RID: 9216
		MaxAge,
		/// <summary>Содержимое может браться из кэша, если время, прошедшее с момента истечения его срока действия до текущего момента, меньше времени, указываемого данным значением.</summary>
		// Token: 0x04002401 RID: 9217
		MaxStale = 4,
		/// <summary>
		///   <see cref="P:System.Net.Cache.HttpRequestCachePolicy.MaxAge" /> и <see cref="P:System.Net.Cache.HttpRequestCachePolicy.MinFresh" />.</summary>
		// Token: 0x04002402 RID: 9218
		MaxAgeAndMinFresh = 3,
		/// <summary>
		///   <see cref="P:System.Net.Cache.HttpRequestCachePolicy.MaxAge" /> и <see cref="P:System.Net.Cache.HttpRequestCachePolicy.MaxStale" />.</summary>
		// Token: 0x04002403 RID: 9219
		MaxAgeAndMaxStale = 6
	}
}
