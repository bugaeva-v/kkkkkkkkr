using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Представляет стандартные параметры для алгоритма шифрования на основе эллиптических кривых (ECC).
	///       </summary>
	// Token: 0x02000035 RID: 53
	public struct ECParameters
	{
		/// <summary>
		///         Проверяет текущий объект.
		///       </summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Параметры кривой или ключа недопустимы для текущего типа кривой.
		///           </exception>
		// Token: 0x060000B9 RID: 185 RVA: 0x00002868 File Offset: 0x00000A68
		public void Validate()
		{
			bool flag = false;
			if (this.Q.X == null || this.Q.Y == null || this.Q.X.Length != this.Q.Y.Length)
			{
				flag = true;
			}
			if (!flag)
			{
				if (this.Curve.IsExplicit)
				{
					flag = (this.D != null && this.D.Length != this.Curve.Order.Length);
				}
				else if (this.Curve.IsNamed)
				{
					flag = (this.D != null && this.D.Length != this.Q.X.Length);
				}
			}
			if (flag)
			{
				throw new CryptographicException("The specified key parameters are not valid. Q.X and Q.Y are required fields. Q.X, Q.Y must be the same length. If D is specified it must be the same length as Q.X and Q.Y for named curves or the same length as Order for explicit curves.");
			}
			this.Curve.Validate();
		}

		/// <summary>
		///         Представляет открытый ключ <see langword="Q" /> для алгоритма шифрования на основе эллиптических кривых (ECC).
		///       </summary>
		/// <returns>
		///         Параметр <see langword="Q" /> для алгоритма шифрования на основе эллиптических кривых (ECC).
		///       </returns>
		// Token: 0x040002D0 RID: 720
		public ECPoint Q;

		/// <summary>
		///         Представляет закрытый ключ <see langword="D" /> для алгоритма шифрования на основе эллиптических кривых (ECC), хранящийся в формате с обратным порядком байтов.
		///       </summary>
		/// <returns>
		///         Параметр <see langword="D" /> для алгоритма шифрования на основе эллиптических кривых (ECC).
		///       </returns>
		// Token: 0x040002D1 RID: 721
		public byte[] D;

		/// <summary>
		///         Представляет кривую, связанную с открытым ключом (<see cref="F:System.Security.Cryptography.ECParameters.Q" />) и, дополнительно, с закрытым ключом (<see cref="F:System.Security.Cryptography.ECParameters.D" />).
		///       </summary>
		/// <returns>
		///         Кривая.
		///       </returns>
		// Token: 0x040002D2 RID: 722
		public ECCurve Curve;
	}
}
