using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Представляет пару координат (X,Y) для структур шифрования на основе эллиптических кривых (ECC).
	///       </summary>
	// Token: 0x02000036 RID: 54
	public struct ECPoint
	{
		/// <summary>
		///         Представляет координату Х.
		///       </summary>
		/// <returns>
		///         Координата Х.
		///       </returns>
		// Token: 0x040002D3 RID: 723
		public byte[] X;

		/// <summary>
		///         Представляет координату Y.
		///       </summary>
		/// <returns>
		///         Y-координата.
		///       </returns>
		// Token: 0x040002D4 RID: 724
		public byte[] Y;
	}
}
