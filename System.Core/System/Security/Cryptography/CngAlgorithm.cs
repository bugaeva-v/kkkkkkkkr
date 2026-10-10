using System;
using System.Security.Permissions;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Инкапсулирует имя алгоритма шифрования.
	///       </summary>
	// Token: 0x0200003E RID: 62
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public sealed class CngAlgorithm : IEquatable<CngAlgorithm>
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CngAlgorithm" />.
		///       </summary>
		/// <param name="algorithm">
		///           Имя алгоритма для инициализации.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="algorithm" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="algorithm" /> Длина параметра равно 0 (нулю).
		///           </exception>
		// Token: 0x060000DB RID: 219 RVA: 0x00002EAC File Offset: 0x000010AC
		public CngAlgorithm(string algorithm)
		{
			if (algorithm == null)
			{
				throw new ArgumentNullException("algorithm");
			}
			if (algorithm.Length == 0)
			{
				throw new ArgumentException(SR.GetString("The algorithm name '{0}' is invalid.", new object[]
				{
					algorithm
				}), "algorithm");
			}
			this.m_algorithm = algorithm;
		}

		/// <summary>
		///         Возвращает имя алгоритма, заданного текущим объектом <see cref="T:System.Security.Cryptography.CngAlgorithm" />.
		///       </summary>
		/// <returns>
		///         Внедренное имя алгоритма.
		///       </returns>
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00002EFB File Offset: 0x000010FB
		public string Algorithm
		{
			get
			{
				return this.m_algorithm;
			}
		}

		/// <summary>
		///         Определяет, задают ли два объекта <see cref="T:System.Security.Cryptography.CngAlgorithm" /> одно и то же имя алгоритма.
		///       </summary>
		/// <param name="left">
		///           Объект, задающий имя алгоритма.
		///         </param>
		/// <param name="right">
		///           Второй объект, который требуется сравнить с объектом, идентифицируемым параметром <paramref name="left" />.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если два объекта задают один и тот же алгоритм, в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x060000DD RID: 221 RVA: 0x00002F03 File Offset: 0x00001103
		public static bool operator ==(CngAlgorithm left, CngAlgorithm right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		/// <summary>
		///         Определяет, задают ли два объекта <see cref="T:System.Security.Cryptography.CngAlgorithm" /> разные алгоритмы.
		///       </summary>
		/// <param name="left">
		///           Объект, задающий имя алгоритма.
		///         </param>
		/// <param name="right">
		///           Второй объект, который требуется сравнить с объектом, идентифицируемым параметром <paramref name="left" />.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если два объекта задают разные алгоритмы, в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x060000DE RID: 222 RVA: 0x00002F14 File Offset: 0x00001114
		public static bool operator !=(CngAlgorithm left, CngAlgorithm right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		/// <summary>
		///         Сравнивает заданный объект с текущим объектом <see cref="T:System.Security.Cryptography.CngAlgorithm" />.
		///       </summary>
		/// <param name="obj">
		///           Объект, который требуется сравнить с текущим объектом <see cref="T:System.Security.Cryptography.CngAlgorithm" />.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если параметр <paramref name="obj" /> является объектом <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающим тот же самый алгоритм, что и текущий объект; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x060000DF RID: 223 RVA: 0x00002F28 File Offset: 0x00001128
		public override bool Equals(object obj)
		{
			return this.Equals(obj as CngAlgorithm);
		}

		/// <summary>
		///         Сравнивает заданный объект <see cref="T:System.Security.Cryptography.CngAlgorithm" /> с текущим объектом <see cref="T:System.Security.Cryptography.CngAlgorithm" />.
		///       </summary>
		/// <param name="other">
		///           Объект, который требуется сравнить с текущим объектом <see cref="T:System.Security.Cryptography.CngAlgorithm" />.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если параметр <paramref name="other" /> задает тот же самый алгоритм, что и текущий объект; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x060000E0 RID: 224 RVA: 0x00002F36 File Offset: 0x00001136
		public bool Equals(CngAlgorithm other)
		{
			return other != null && this.m_algorithm.Equals(other.Algorithm);
		}

		/// <summary>
		///         Формирует хэш-значение имени алгоритма, которое внедрено в текущий объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />.
		///       </summary>
		/// <returns>
		///         Хэш-значение внедренного имени алгоритма.
		///       </returns>
		// Token: 0x060000E1 RID: 225 RVA: 0x00002F4E File Offset: 0x0000114E
		public override int GetHashCode()
		{
			return this.m_algorithm.GetHashCode();
		}

		/// <summary>
		///         Возвращает имя алгоритма, заданного текущим объектом <see cref="T:System.Security.Cryptography.CngAlgorithm" />.
		///       </summary>
		/// <returns>
		///         Внедренное имя алгоритма.
		///       </returns>
		// Token: 0x060000E2 RID: 226 RVA: 0x00002EFB File Offset: 0x000010FB
		public override string ToString()
		{
			return this.m_algorithm;
		}

		/// <summary>
		///         Возвращает новый объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий хэш-алгоритм RSA.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм RSA.
		///       </returns>
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002F5B File Offset: 0x0000115B
		public static CngAlgorithm Rsa
		{
			get
			{
				if (CngAlgorithm.s_rsa == null)
				{
					CngAlgorithm.s_rsa = new CngAlgorithm("RSA");
				}
				return CngAlgorithm.s_rsa;
			}
		}

		/// <summary>
		///         Получает объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий алгоритм обмена ключами эллиптической кривой Диффи-Хелмана (ECDH), кривая которого описывается с помощью свойства ключа.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм обмена ключами ECDH, кривая которого описывается с помощью свойства ключа.
		///       </returns>
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002F84 File Offset: 0x00001184
		public static CngAlgorithm ECDiffieHellman
		{
			get
			{
				if (CngAlgorithm.s_ecdh == null)
				{
					CngAlgorithm.s_ecdh = new CngAlgorithm("ECDH");
				}
				return CngAlgorithm.s_ecdh;
			}
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий алгоритм обмена ключами Диффи-Хеллмана на эллиптических кривых (ECDH), в котором используется кривая P-256.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм ECDH, в котором используется кривая P-256.
		///       </returns>
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002FAD File Offset: 0x000011AD
		public static CngAlgorithm ECDiffieHellmanP256
		{
			get
			{
				if (CngAlgorithm.s_ecdhp256 == null)
				{
					CngAlgorithm.s_ecdhp256 = new CngAlgorithm("ECDH_P256");
				}
				return CngAlgorithm.s_ecdhp256;
			}
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий алгоритм обмена ключами Диффи-Хеллмана на эллиптических кривых (ECDH), в котором используется кривая P-384.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм ECDH, в котором используется кривая P-384.
		///       </returns>
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002FD6 File Offset: 0x000011D6
		public static CngAlgorithm ECDiffieHellmanP384
		{
			get
			{
				if (CngAlgorithm.s_ecdhp384 == null)
				{
					CngAlgorithm.s_ecdhp384 = new CngAlgorithm("ECDH_P384");
				}
				return CngAlgorithm.s_ecdhp384;
			}
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий алгоритм обмена ключами Диффи-Хеллмана на эллиптических кривых (ECDH), в котором используется кривая P-521.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм ECDH, в котором используется кривая P-521.
		///       </returns>
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002FFF File Offset: 0x000011FF
		public static CngAlgorithm ECDiffieHellmanP521
		{
			get
			{
				if (CngAlgorithm.s_ecdhp521 == null)
				{
					CngAlgorithm.s_ecdhp521 = new CngAlgorithm("ECDH_P521");
				}
				return CngAlgorithm.s_ecdhp521;
			}
		}

		/// <summary>
		///         Получает объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий алгоритм цифровых подписей на основе эллиптических кривых (ECDSA), кривая которого описывается с помощью свойства ключа.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм ECDSA, кривая которого описывается с помощью свойства ключа.
		///       </returns>
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00003028 File Offset: 0x00001228
		public static CngAlgorithm ECDsa
		{
			get
			{
				if (CngAlgorithm.s_ecdsa == null)
				{
					CngAlgorithm.s_ecdsa = new CngAlgorithm("ECDSA");
				}
				return CngAlgorithm.s_ecdsa;
			}
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий алгоритм цифровых подписей на основе эллиптических кривых (ECDSA), в котором используется кривая P-256.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм ECDSA, в котором используется кривая P-256.
		///       </returns>
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00003051 File Offset: 0x00001251
		public static CngAlgorithm ECDsaP256
		{
			get
			{
				if (CngAlgorithm.s_ecdsap256 == null)
				{
					CngAlgorithm.s_ecdsap256 = new CngAlgorithm("ECDSA_P256");
				}
				return CngAlgorithm.s_ecdsap256;
			}
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий алгоритм цифровых подписей на основе эллиптических кривых (ECDSA), в котором используется кривая P-384.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм ECDSA, в котором используется кривая P-384.
		///       </returns>
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000307A File Offset: 0x0000127A
		public static CngAlgorithm ECDsaP384
		{
			get
			{
				if (CngAlgorithm.s_ecdsap384 == null)
				{
					CngAlgorithm.s_ecdsap384 = new CngAlgorithm("ECDSA_P384");
				}
				return CngAlgorithm.s_ecdsap384;
			}
		}

		/// <summary>
		///         Возвращает новый объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий алгоритм цифровых подписей на основе эллиптических кривых (ECDSA), в котором используется кривая P-521.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм ECDSA, в котором используется кривая P-521.
		///       </returns>
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000030A3 File Offset: 0x000012A3
		public static CngAlgorithm ECDsaP521
		{
			get
			{
				if (CngAlgorithm.s_ecdsap521 == null)
				{
					CngAlgorithm.s_ecdsap521 = new CngAlgorithm("ECDSA_P521");
				}
				return CngAlgorithm.s_ecdsap521;
			}
		}

		/// <summary>
		///         Возвращает новый объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий хэш-алгоритм MD5.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм MD5.
		///       </returns>
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000030CC File Offset: 0x000012CC
		public static CngAlgorithm MD5
		{
			get
			{
				if (CngAlgorithm.s_md5 == null)
				{
					CngAlgorithm.s_md5 = new CngAlgorithm("MD5");
				}
				return CngAlgorithm.s_md5;
			}
		}

		/// <summary>
		///         Возвращает новый объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий алгоритм SHA-1.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм SHA-1.
		///       </returns>
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000030F5 File Offset: 0x000012F5
		public static CngAlgorithm Sha1
		{
			get
			{
				if (CngAlgorithm.s_sha1 == null)
				{
					CngAlgorithm.s_sha1 = new CngAlgorithm("SHA1");
				}
				return CngAlgorithm.s_sha1;
			}
		}

		/// <summary>
		///         Возвращает новый объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий алгоритм SHA-256.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм SHA-256.
		///       </returns>
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000311E File Offset: 0x0000131E
		public static CngAlgorithm Sha256
		{
			get
			{
				if (CngAlgorithm.s_sha256 == null)
				{
					CngAlgorithm.s_sha256 = new CngAlgorithm("SHA256");
				}
				return CngAlgorithm.s_sha256;
			}
		}

		/// <summary>
		///         Возвращает новый объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий алгоритм SHA-384.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм SHA-384.
		///       </returns>
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00003147 File Offset: 0x00001347
		public static CngAlgorithm Sha384
		{
			get
			{
				if (CngAlgorithm.s_sha384 == null)
				{
					CngAlgorithm.s_sha384 = new CngAlgorithm("SHA384");
				}
				return CngAlgorithm.s_sha384;
			}
		}

		/// <summary>
		///         Возвращает новый объект <see cref="T:System.Security.Cryptography.CngAlgorithm" />, задающий алгоритм SHA-512.
		///       </summary>
		/// <returns>
		///         Объект, задающий алгоритм SHA-512.
		///       </returns>
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00003170 File Offset: 0x00001370
		public static CngAlgorithm Sha512
		{
			get
			{
				if (CngAlgorithm.s_sha512 == null)
				{
					CngAlgorithm.s_sha512 = new CngAlgorithm("SHA512");
				}
				return CngAlgorithm.s_sha512;
			}
		}

		// Token: 0x040002F5 RID: 757
		private static volatile CngAlgorithm s_ecdh;

		// Token: 0x040002F6 RID: 758
		private static volatile CngAlgorithm s_ecdhp256;

		// Token: 0x040002F7 RID: 759
		private static volatile CngAlgorithm s_ecdhp384;

		// Token: 0x040002F8 RID: 760
		private static volatile CngAlgorithm s_ecdhp521;

		// Token: 0x040002F9 RID: 761
		private static volatile CngAlgorithm s_ecdsa;

		// Token: 0x040002FA RID: 762
		private static volatile CngAlgorithm s_ecdsap256;

		// Token: 0x040002FB RID: 763
		private static volatile CngAlgorithm s_ecdsap384;

		// Token: 0x040002FC RID: 764
		private static volatile CngAlgorithm s_ecdsap521;

		// Token: 0x040002FD RID: 765
		private static volatile CngAlgorithm s_md5;

		// Token: 0x040002FE RID: 766
		private static volatile CngAlgorithm s_sha1;

		// Token: 0x040002FF RID: 767
		private static volatile CngAlgorithm s_sha256;

		// Token: 0x04000300 RID: 768
		private static volatile CngAlgorithm s_sha384;

		// Token: 0x04000301 RID: 769
		private static volatile CngAlgorithm s_sha512;

		// Token: 0x04000302 RID: 770
		private static volatile CngAlgorithm s_rsa;

		// Token: 0x04000303 RID: 771
		private string m_algorithm;
	}
}
