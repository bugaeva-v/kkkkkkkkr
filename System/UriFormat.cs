using System;

namespace System
{
	/// <summary>Указывает, каким образом экранируются данные URI.</summary>
	// Token: 0x02000158 RID: 344
	public enum UriFormat
	{
		/// <summary>Преобразование выполнено в соответствии с правилами стандарта RFC 2396.</summary>
		// Token: 0x04000624 RID: 1572
		UriEscaped = 1,
		/// <summary>Преобразование не произведено.</summary>
		// Token: 0x04000625 RID: 1573
		Unescaped,
		/// <summary>Символы, имеющие зарезервированное значение в компонентах запрошенного URI, остаются преобразованными. Остальные символы не преобразуются.</summary>
		// Token: 0x04000626 RID: 1574
		SafeUnescaped
	}
}
