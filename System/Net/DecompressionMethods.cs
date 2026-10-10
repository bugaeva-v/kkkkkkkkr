using System;

namespace System.Net
{
	/// <summary>Представляет формат кодирования сжатия и распаковки файлов, который будет использоваться для сжатия данных, полученных в ответ на <see cref="T:System.Net.HttpWebRequest" />.</summary>
	// Token: 0x02000672 RID: 1650
	[Flags]
	public enum DecompressionMethods
	{
		/// <summary>Этот метод не использует сжатия.</summary>
		// Token: 0x04001E74 RID: 7796
		None = 0,
		/// <summary>Используйте алгоритм сжатия и распаковки gZip.</summary>
		// Token: 0x04001E75 RID: 7797
		GZip = 1,
		/// <summary>Используйте алгоритм сжатия и распаковки Deflate.</summary>
		// Token: 0x04001E76 RID: 7798
		Deflate = 2
	}
}
