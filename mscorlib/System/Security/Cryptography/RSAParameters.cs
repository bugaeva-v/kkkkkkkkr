using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет стандартные параметры для алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</summary>
	// Token: 0x020004A9 RID: 1193
	[ComVisible(true)]
	[Serializable]
	public struct RSAParameters
	{
		/// <summary>Представляет параметр <see langword="Exponent" /> для алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		// Token: 0x040021B8 RID: 8632
		public byte[] Exponent;

		/// <summary>Представляет параметр <see langword="Modulus" /> для алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		// Token: 0x040021B9 RID: 8633
		public byte[] Modulus;

		/// <summary>Представляет параметр <see langword="P" /> для алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		// Token: 0x040021BA RID: 8634
		[NonSerialized]
		public byte[] P;

		/// <summary>Представляет параметр <see langword="Q" /> для алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		// Token: 0x040021BB RID: 8635
		[NonSerialized]
		public byte[] Q;

		/// <summary>Представляет параметр <see langword="DP" /> для алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		// Token: 0x040021BC RID: 8636
		[NonSerialized]
		public byte[] DP;

		/// <summary>Представляет параметр <see langword="DQ" /> для алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		// Token: 0x040021BD RID: 8637
		[NonSerialized]
		public byte[] DQ;

		/// <summary>Представляет параметр <see langword="InverseQ" /> для алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		// Token: 0x040021BE RID: 8638
		[NonSerialized]
		public byte[] InverseQ;

		/// <summary>Представляет параметр <see langword="D" /> для алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		// Token: 0x040021BF RID: 8639
		[NonSerialized]
		public byte[] D;
	}
}
