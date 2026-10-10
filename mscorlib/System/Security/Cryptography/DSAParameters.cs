using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Содержит типичные параметры для алгоритма <see cref="T:System.Security.Cryptography.DSA" />.</summary>
	// Token: 0x0200048A RID: 1162
	[ComVisible(true)]
	[Serializable]
	public struct DSAParameters
	{
		/// <summary>Задает параметр <see langword="P" /> для алгоритма <see cref="T:System.Security.Cryptography.DSA" />.</summary>
		// Token: 0x04002159 RID: 8537
		public byte[] P;

		/// <summary>Задает параметр <see langword="Q" /> для алгоритма <see cref="T:System.Security.Cryptography.DSA" />.</summary>
		// Token: 0x0400215A RID: 8538
		public byte[] Q;

		/// <summary>Задает параметр <see langword="G" /> для алгоритма <see cref="T:System.Security.Cryptography.DSA" />.</summary>
		// Token: 0x0400215B RID: 8539
		public byte[] G;

		/// <summary>Задает параметр <see langword="Y" /> для алгоритма <see cref="T:System.Security.Cryptography.DSA" />.</summary>
		// Token: 0x0400215C RID: 8540
		public byte[] Y;

		/// <summary>Задает параметр <see langword="J" /> для алгоритма <see cref="T:System.Security.Cryptography.DSA" />.</summary>
		// Token: 0x0400215D RID: 8541
		public byte[] J;

		/// <summary>Задает параметр <see langword="X" /> для алгоритма <see cref="T:System.Security.Cryptography.DSA" />.</summary>
		// Token: 0x0400215E RID: 8542
		[NonSerialized]
		public byte[] X;

		/// <summary>Задает начальное значение для алгоритма <see cref="T:System.Security.Cryptography.DSA" />.</summary>
		// Token: 0x0400215F RID: 8543
		public byte[] Seed;

		/// <summary>Задает счетчик для алгоритма <see cref="T:System.Security.Cryptography.DSA" />.</summary>
		// Token: 0x04002160 RID: 8544
		public int Counter;
	}
}
