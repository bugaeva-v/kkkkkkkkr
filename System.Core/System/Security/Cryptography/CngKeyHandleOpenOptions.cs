using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Задает параметры открытия дескрипторов ключа.
	///       </summary>
	// Token: 0x02000040 RID: 64
	[Flags]
	public enum CngKeyHandleOpenOptions
	{
		/// <summary>
		///         Открываемый дескриптор ключа не определяет эфемерный ключ.
		///       </summary>
		// Token: 0x0400030B RID: 779
		None = 0,
		/// <summary>
		///         Открываемый дескриптор ключа определяет эфемерный ключ.
		///       </summary>
		// Token: 0x0400030C RID: 780
		EphemeralKey = 1
	}
}
