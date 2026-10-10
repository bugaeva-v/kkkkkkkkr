using System;

namespace System.Runtime.Serialization
{
	/// <summary>Указывает, как часто можно опускать сведения о типе.</summary>
	// Token: 0x020000CF RID: 207
	public enum EmitTypeInformation
	{
		/// <summary>По необходимости сообщать сведения о типе.</summary>
		// Token: 0x04000508 RID: 1288
		AsNeeded,
		/// <summary>Всегда для создания информации о типе.</summary>
		// Token: 0x04000509 RID: 1289
		Always,
		/// <summary>Никогда не сообщать сведения о типе.</summary>
		// Token: 0x0400050A RID: 1290
		Never
	}
}
