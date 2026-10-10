using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Описывает тип члена модели COM.</summary>
	// Token: 0x020006D3 RID: 1747
	public enum ComMemberType
	{
		/// <summary>Этот член является обычным методом.</summary>
		// Token: 0x04002A19 RID: 10777
		Method,
		/// <summary>Член возвращает свойства.</summary>
		// Token: 0x04002A1A RID: 10778
		PropGet,
		/// <summary>Член задает свойства.</summary>
		// Token: 0x04002A1B RID: 10779
		PropSet
	}
}
