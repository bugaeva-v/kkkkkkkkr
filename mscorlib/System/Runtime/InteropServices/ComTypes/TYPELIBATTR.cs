using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Определяет конкретную библиотеку типов и обеспечивает поддержку локализации для имен членов.</summary>
	// Token: 0x020007CD RID: 1997
	[Serializable]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct TYPELIBATTR
	{
		/// <summary>Предоставляет уникальную глобальную библиотеку идентификаторов для библиотеки типов.</summary>
		// Token: 0x04002D0D RID: 11533
		public Guid guid;

		/// <summary>Представляет код языка библиотеки типов.</summary>
		// Token: 0x04002D0E RID: 11534
		public int lcid;

		/// <summary>Представляет целевую аппаратную платформу библиотеки типов.</summary>
		// Token: 0x04002D0F RID: 11535
		public SYSKIND syskind;

		/// <summary>Представляет номер основной версии библиотеки типов.</summary>
		// Token: 0x04002D10 RID: 11536
		public short wMajorVerNum;

		/// <summary>Представляет дополнительный номер версии библиотеки типов.</summary>
		// Token: 0x04002D11 RID: 11537
		public short wMinorVerNum;

		/// <summary>Представляет флаги библиотеки.</summary>
		// Token: 0x04002D12 RID: 11538
		public LIBFLAGS wLibFlags;
	}
}
