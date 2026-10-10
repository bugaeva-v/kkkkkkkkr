using System;

namespace System.Net
{
	/// <summary>Определяет номера версий протокола HTTP, поддерживаемых классами <see cref="T:System.Net.HttpWebRequest" /> и <see cref="T:System.Net.HttpWebResponse" />.</summary>
	// Token: 0x0200057B RID: 1403
	public class HttpVersion
	{
		// Token: 0x040018E0 RID: 6368
		public static readonly Version Unknown = new Version(0, 0);

		/// <summary>Определяет экземпляр класса <see cref="T:System.Version" /> для протокола HTTP 1.0.</summary>
		// Token: 0x040018E1 RID: 6369
		public static readonly Version Version10 = new Version(1, 0);

		/// <summary>Определяет экземпляр класса <see cref="T:System.Version" /> для протокола HTTP 1.1.</summary>
		// Token: 0x040018E2 RID: 6370
		public static readonly Version Version11 = new Version(1, 1);

		// Token: 0x040018E3 RID: 6371
		public static readonly Version Version20 = new Version(2, 0);
	}
}
