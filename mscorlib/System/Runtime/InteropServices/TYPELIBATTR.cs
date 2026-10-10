using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.TYPELIBATTR" />.</summary>
	// Token: 0x02000751 RID: 1873
	[Obsolete]
	[Serializable]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct TYPELIBATTR
	{
		/// <summary>Предоставляет уникальную глобальную библиотеку идентификаторов для библиотеки типов.</summary>
		// Token: 0x04002C01 RID: 11265
		public Guid guid;

		/// <summary>Представляет код языка библиотеки типов.</summary>
		// Token: 0x04002C02 RID: 11266
		public int lcid;

		/// <summary>Представляет целевую аппаратную платформу библиотеки типов.</summary>
		// Token: 0x04002C03 RID: 11267
		public SYSKIND syskind;

		/// <summary>Представляет номер основной версии библиотеки типов.</summary>
		// Token: 0x04002C04 RID: 11268
		public short wMajorVerNum;

		/// <summary>Представляет дополнительный номер версии библиотеки типов.</summary>
		// Token: 0x04002C05 RID: 11269
		public short wMinorVerNum;

		/// <summary>Представляет флаги библиотеки.</summary>
		// Token: 0x04002C06 RID: 11270
		public LIBFLAGS wLibFlags;
	}
}
