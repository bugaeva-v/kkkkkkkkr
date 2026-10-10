using System;

namespace System
{
	/// <summary>Указывает части <see cref="T:System.Uri" />.</summary>
	// Token: 0x02000157 RID: 343
	[Flags]
	public enum UriComponents
	{
		/// <summary>Данные <see cref="P:System.Uri.Scheme" />.</summary>
		// Token: 0x04000612 RID: 1554
		Scheme = 1,
		/// <summary>Данные <see cref="P:System.Uri.UserInfo" />.</summary>
		// Token: 0x04000613 RID: 1555
		UserInfo = 2,
		/// <summary>Данные <see cref="P:System.Uri.Host" />.</summary>
		// Token: 0x04000614 RID: 1556
		Host = 4,
		/// <summary>Данные <see cref="P:System.Uri.Port" />.</summary>
		// Token: 0x04000615 RID: 1557
		Port = 8,
		/// <summary>Данные <see cref="P:System.Uri.LocalPath" />.</summary>
		// Token: 0x04000616 RID: 1558
		Path = 16,
		/// <summary>Данные <see cref="P:System.Uri.Query" />.</summary>
		// Token: 0x04000617 RID: 1559
		Query = 32,
		/// <summary>Данные <see cref="P:System.Uri.Fragment" />.</summary>
		// Token: 0x04000618 RID: 1560
		Fragment = 64,
		/// <summary>Данные <see cref="P:System.Uri.Port" />. Если данные порта отсутствуют в <see cref="T:System.Uri" /> и порт по умолчанию был назначен <see cref="P:System.Uri.Scheme" />, возвращается порт по умолчанию. Если порт по умолчанию отсутствует, возвращается значение –1.</summary>
		// Token: 0x04000619 RID: 1561
		StrongPort = 128,
		/// <summary>Нормализованная форма <see cref="P:System.Uri.Host" />.</summary>
		// Token: 0x0400061A RID: 1562
		NormalizedHost = 256,
		/// <summary>Указывает, следует ли включать разделитель.</summary>
		// Token: 0x0400061B RID: 1563
		KeepDelimiter = 1073741824,
		/// <summary>Полный контекст <see cref="T:System.Uri" />, который необходим для сериализаторов URI. В контекст входит область протокола IPv6.</summary>
		// Token: 0x0400061C RID: 1564
		SerializationInfoString = -2147483648,
		/// <summary>Данные <see cref="P:System.Uri.Scheme" />, <see cref="P:System.Uri.UserInfo" />, <see cref="P:System.Uri.Host" />, <see cref="P:System.Uri.Port" />, <see cref="P:System.Uri.LocalPath" />, <see cref="P:System.Uri.Query" /> и <see cref="P:System.Uri.Fragment" />.</summary>
		// Token: 0x0400061D RID: 1565
		AbsoluteUri = 127,
		/// <summary>Данные <see cref="P:System.Uri.Host" /> и <see cref="P:System.Uri.Port" />. Если данные порта отсутствуют в URI и порт по умолчанию был назначен <see cref="P:System.Uri.Scheme" />, возвращается порт по умолчанию. Если порт по умолчанию отсутствует, возвращается значение –1.</summary>
		// Token: 0x0400061E RID: 1566
		HostAndPort = 132,
		/// <summary>Данные <see cref="P:System.Uri.UserInfo" />, <see cref="P:System.Uri.Host" /> и <see cref="P:System.Uri.Port" />. Если данные порта отсутствуют в <see cref="T:System.Uri" /> и порт по умолчанию был назначен <see cref="P:System.Uri.Scheme" />, возвращается порт по умолчанию. Если порт по умолчанию отсутствует, возвращается значение –1.</summary>
		// Token: 0x0400061F RID: 1567
		StrongAuthority = 134,
		/// <summary>Данные <see cref="P:System.Uri.Scheme" />, <see cref="P:System.Uri.Host" /> и <see cref="P:System.Uri.Port" />.</summary>
		// Token: 0x04000620 RID: 1568
		SchemeAndServer = 13,
		/// <summary>Данные <see cref="P:System.Uri.Scheme" />, <see cref="P:System.Uri.Host" />, <see cref="P:System.Uri.Port" />, <see cref="P:System.Uri.LocalPath" /> и <see cref="P:System.Uri.Query" />.</summary>
		// Token: 0x04000621 RID: 1569
		HttpRequestUrl = 61,
		/// <summary>Данные <see cref="P:System.Uri.LocalPath" /> и <see cref="P:System.Uri.Query" />. См. также <see cref="P:System.Uri.PathAndQuery" />.</summary>
		// Token: 0x04000622 RID: 1570
		PathAndQuery = 48
	}
}
