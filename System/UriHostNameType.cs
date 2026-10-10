using System;

namespace System
{
	/// <summary>Определяет типы имен узелов для метода <see cref="M:System.Uri.CheckHostName(System.String)" />.</summary>
	// Token: 0x0200015D RID: 349
	public enum UriHostNameType
	{
		/// <summary>Тип имени узла не поддерживается.</summary>
		// Token: 0x0400064C RID: 1612
		Unknown,
		/// <summary>узел установлен, однако не удается определить тип.</summary>
		// Token: 0x0400064D RID: 1613
		Basic,
		/// <summary>Имя узла представлено в виде DNS-имени.</summary>
		// Token: 0x0400064E RID: 1614
		Dns,
		/// <summary>Имя узла представлено в формате IPv4.</summary>
		// Token: 0x0400064F RID: 1615
		IPv4,
		/// <summary>Имя узла представлено в формате IPv6.</summary>
		// Token: 0x04000650 RID: 1616
		IPv6
	}
}
