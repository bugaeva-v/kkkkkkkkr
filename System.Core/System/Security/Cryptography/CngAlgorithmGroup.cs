using System;
using System.Security.Permissions;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Инкапсулирует имя группы алгоритмов шифрования.
	///       </summary>
	// Token: 0x0200003F RID: 63
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public sealed class CngAlgorithmGroup : IEquatable<CngAlgorithmGroup>
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" />.
		///       </summary>
		/// <param name="algorithmGroup">
		///           Имя группы алгоритмов для инициализации.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="algorithmGroup" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="algorithmGroup" /> Длина параметра равно 0 (нулю).
		///           </exception>
		// Token: 0x060000F1 RID: 241 RVA: 0x0000319C File Offset: 0x0000139C
		public CngAlgorithmGroup(string algorithmGroup)
		{
			if (algorithmGroup == null)
			{
				throw new ArgumentNullException("algorithmGroup");
			}
			if (algorithmGroup.Length == 0)
			{
				throw new ArgumentException(SR.GetString("The algorithm group '{0}' is invalid.", new object[]
				{
					algorithmGroup
				}), "algorithmGroup");
			}
			this.m_algorithmGroup = algorithmGroup;
		}

		/// <summary>
		///         Возвращает имя группы алгоритмов, текущий <see cref="T:System.Security.Cryptography.CngAlgorithm" /> указывает объект.
		///       </summary>
		/// <returns>
		///         Имя группы embedded алгоритма.
		///       </returns>
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000031EB File Offset: 0x000013EB
		public string AlgorithmGroup
		{
			get
			{
				return this.m_algorithmGroup;
			}
		}

		/// <summary>
		///         Определяет неравенство двух <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" /> объекта задают разные группы алгоритмов.
		///       </summary>
		/// <param name="left">
		///           Объект, задающий группу алгоритмов.
		///         </param>
		/// <param name="right">
		///           Второй объект, который требуется сравнить с объектом, идентифицируемым параметром <paramref name="left" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если два объекта задают разные группы алгоритмов; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x060000F3 RID: 243 RVA: 0x000031F3 File Offset: 0x000013F3
		public static bool operator ==(CngAlgorithmGroup left, CngAlgorithmGroup right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		/// <summary>
		///         Определяет неравенство двух <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" /> объекта задают разные группы алгоритмов.
		///       </summary>
		/// <param name="left">
		///           Объект, задающий группу алгоритмов.
		///         </param>
		/// <param name="right">
		///           Второй объект, который требуется сравнить с объектом, идентифицируемым параметром <paramref name="left" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если два объекта задают разные группы алгоритмов; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x060000F4 RID: 244 RVA: 0x00003204 File Offset: 0x00001404
		public static bool operator !=(CngAlgorithmGroup left, CngAlgorithmGroup right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		/// <summary>
		///         Сравнивает заданный объект с текущим объектом <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" />.
		///       </summary>
		/// <param name="obj">
		///           Объект, который требуется сравнить с текущим объектом <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <paramref name="obj" /> параметр <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" /> задающим тот же алгоритм группы, что и текущий объект; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x060000F5 RID: 245 RVA: 0x00003218 File Offset: 0x00001418
		public override bool Equals(object obj)
		{
			return this.Equals(obj as CngAlgorithmGroup);
		}

		/// <summary>
		///         Сравнивает заданный объект <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" /> с текущим объектом <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" />.
		///       </summary>
		/// <param name="other">
		///           Объект, который требуется сравнить с текущим объектом <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <paramref name="other" /> параметр задает тот же самый алгоритм группы, что и текущий объект; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x060000F6 RID: 246 RVA: 0x00003226 File Offset: 0x00001426
		public bool Equals(CngAlgorithmGroup other)
		{
			return other != null && this.m_algorithmGroup.Equals(other.AlgorithmGroup);
		}

		/// <summary>
		///         Создает хэш-значение для имени группы алгоритма, которое внедрено в текущий <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" /> объекта.
		///       </summary>
		/// <returns>
		///         Хэш-значение внедренного имени группы алгоритмов.
		///       </returns>
		// Token: 0x060000F7 RID: 247 RVA: 0x0000323E File Offset: 0x0000143E
		public override int GetHashCode()
		{
			return this.m_algorithmGroup.GetHashCode();
		}

		/// <summary>
		///         Возвращает имя группы алгоритмов, текущий <see cref="T:System.Security.Cryptography.CngAlgorithm" /> указывает объект.
		///       </summary>
		/// <returns>
		///         Имя группы embedded алгоритма.
		///       </returns>
		// Token: 0x060000F8 RID: 248 RVA: 0x000031EB File Offset: 0x000013EB
		public override string ToString()
		{
			return this.m_algorithmGroup;
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" /> объект, задающий алгоритм Диффи-Хелмана семейство алгоритмов.
		///       </summary>
		/// <returns>
		///         Объект, задающий семейство алгоритмов, Диффи-Хелмана.
		///       </returns>
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000324B File Offset: 0x0000144B
		public static CngAlgorithmGroup DiffieHellman
		{
			get
			{
				if (CngAlgorithmGroup.s_dh == null)
				{
					CngAlgorithmGroup.s_dh = new CngAlgorithmGroup("DH");
				}
				return CngAlgorithmGroup.s_dh;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" /> объект, задающий семейство алгоритмов, алгоритм цифровой подписи (DSA).
		///       </summary>
		/// <returns>
		///         Объект, задающий семейство алгоритмов, DSA.
		///       </returns>
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00003274 File Offset: 0x00001474
		public static CngAlgorithmGroup Dsa
		{
			get
			{
				if (CngAlgorithmGroup.s_dsa == null)
				{
					CngAlgorithmGroup.s_dsa = new CngAlgorithmGroup("DSA");
				}
				return CngAlgorithmGroup.s_dsa;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" /> объект, задающий семейство алгоритмов, алгоритма Диффи-Хеллмана на эллиптических кривых (ECDH).
		///       </summary>
		/// <returns>
		///         Объект, задающий семейство алгоритмов, ECDH.
		///       </returns>
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000329D File Offset: 0x0000149D
		public static CngAlgorithmGroup ECDiffieHellman
		{
			get
			{
				if (CngAlgorithmGroup.s_ecdh == null)
				{
					CngAlgorithmGroup.s_ecdh = new CngAlgorithmGroup("ECDH");
				}
				return CngAlgorithmGroup.s_ecdh;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" /> объект, задающий семейство алгоритмов, эллиптических кривых цифровой подписи алгоритма (ECDSA).
		///       </summary>
		/// <returns>
		///         Объект, задающий семейство алгоритмов, ECDSA.
		///       </returns>
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000032C6 File Offset: 0x000014C6
		public static CngAlgorithmGroup ECDsa
		{
			get
			{
				if (CngAlgorithmGroup.s_ecdsa == null)
				{
					CngAlgorithmGroup.s_ecdsa = new CngAlgorithmGroup("ECDSA");
				}
				return CngAlgorithmGroup.s_ecdsa;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngAlgorithmGroup" /> объект, задающий семейство алгоритмов, Ривест Шамир адельман () (RSA).
		///       </summary>
		/// <returns>
		///         Объект, задающий семейство алгоритмов RSA.
		///       </returns>
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000032EF File Offset: 0x000014EF
		public static CngAlgorithmGroup Rsa
		{
			get
			{
				if (CngAlgorithmGroup.s_rsa == null)
				{
					CngAlgorithmGroup.s_rsa = new CngAlgorithmGroup("RSA");
				}
				return CngAlgorithmGroup.s_rsa;
			}
		}

		// Token: 0x04000304 RID: 772
		private static volatile CngAlgorithmGroup s_dh;

		// Token: 0x04000305 RID: 773
		private static volatile CngAlgorithmGroup s_dsa;

		// Token: 0x04000306 RID: 774
		private static volatile CngAlgorithmGroup s_ecdh;

		// Token: 0x04000307 RID: 775
		private static volatile CngAlgorithmGroup s_ecdsa;

		// Token: 0x04000308 RID: 776
		private static volatile CngAlgorithmGroup s_rsa;

		// Token: 0x04000309 RID: 777
		private string m_algorithmGroup;
	}
}
