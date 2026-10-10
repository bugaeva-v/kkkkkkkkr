using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Определяет, требуется ли игнорировать пустое пространство при преобразовании в кодировку base64.</summary>
	// Token: 0x0200047D RID: 1149
	[ComVisible(true)]
	[Serializable]
	public enum FromBase64TransformMode
	{
		/// <summary>Пустое пространство следует игнорировать.</summary>
		// Token: 0x0400212E RID: 8494
		IgnoreWhiteSpaces,
		/// <summary>Пустое пространство не следует игнорировать.</summary>
		// Token: 0x0400212F RID: 8495
		DoNotIgnoreWhiteSpaces
	}
}
