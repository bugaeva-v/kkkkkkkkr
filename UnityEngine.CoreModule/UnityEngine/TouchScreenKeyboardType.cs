using System;

namespace UnityEngine
{
	// Token: 0x02000256 RID: 598
	public enum TouchScreenKeyboardType
	{
		// Token: 0x04000887 RID: 2183
		Default,
		// Token: 0x04000888 RID: 2184
		ASCIICapable,
		// Token: 0x04000889 RID: 2185
		NumbersAndPunctuation,
		// Token: 0x0400088A RID: 2186
		URL,
		// Token: 0x0400088B RID: 2187
		NumberPad,
		// Token: 0x0400088C RID: 2188
		PhonePad,
		// Token: 0x0400088D RID: 2189
		NamePhonePad,
		// Token: 0x0400088E RID: 2190
		EmailAddress,
		// Token: 0x0400088F RID: 2191
		[Obsolete("Wii U is no longer supported as of Unity 2018.1.")]
		NintendoNetworkAccount,
		// Token: 0x04000890 RID: 2192
		Social,
		// Token: 0x04000891 RID: 2193
		Search,
		// Token: 0x04000892 RID: 2194
		DecimalPad,
		// Token: 0x04000893 RID: 2195
		OneTimeCode
	}
}
