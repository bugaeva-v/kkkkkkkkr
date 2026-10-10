using System;
using System.Diagnostics;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Представляет эллиптическую кривую.
	///       </summary>
	// Token: 0x02000032 RID: 50
	[DebuggerDisplay("ECCurve: {Oid}")]
	public struct ECCurve
	{
		/// <summary>
		///         Получает идентификатор именованной кривой.
		///       </summary>
		/// <returns>
		///         Идентификатор именованной кривой.
		///       </returns>
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002450 File Offset: 0x00000650
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002470 File Offset: 0x00000670
		public Oid Oid
		{
			get
			{
				return new Oid(this._oid.Value, this._oid.FriendlyName);
			}
			private set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Oid");
				}
				if (string.IsNullOrEmpty(value.Value) && string.IsNullOrEmpty(value.FriendlyName))
				{
					throw new ArgumentException(string.Format("The specified Oid is not valid. The Oid.FriendlyName or Oid.Value property must be set.", Array.Empty<object>()));
				}
				this._oid = value;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000024C4 File Offset: 0x000006C4
		private static ECCurve Create(Oid oid)
		{
			return new ECCurve
			{
				CurveType = ECCurve.ECCurveType.Named,
				Oid = oid
			};
		}

		/// <summary>
		///         Создает именованную кривую с помощью указанного объекта <see cref="T:System.Security.Cryptography.Oid" />.
		///       </summary>
		/// <param name="curveOid">
		///           Используемый идентификатор объекта.
		///         </param>
		/// <returns>
		///         Объект, представляющий именованную кривую.
		///       </returns>
		// Token: 0x0600009E RID: 158 RVA: 0x000024EA File Offset: 0x000006EA
		public static ECCurve CreateFromOid(Oid curveOid)
		{
			return ECCurve.Create(new Oid(curveOid.Value, curveOid.FriendlyName));
		}

		/// <summary>
		///         Создает именованную кривую, используя указанное понятное имя идентификатора.
		///       </summary>
		/// <param name="oidFriendlyName">
		///           Понятное имя идентификатора.
		///         </param>
		/// <returns>
		///         Объект, представляющий именованную кривую.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="oidFriendlyName" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600009F RID: 159 RVA: 0x00002502 File Offset: 0x00000702
		public static ECCurve CreateFromFriendlyName(string oidFriendlyName)
		{
			if (oidFriendlyName == null)
			{
				throw new ArgumentNullException("oidFriendlyName");
			}
			return ECCurve.CreateFromValueAndName(null, oidFriendlyName);
		}

		/// <summary>
		///         Создает именованную кривую, используя указанное десятичное представление идентификатора с точками.
		///       </summary>
		/// <param name="oidValue">
		///           Значение идентификатора с точками.
		///         </param>
		/// <returns>
		///         Объект, представляющий именованную кривую.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="oidValue" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060000A0 RID: 160 RVA: 0x00002519 File Offset: 0x00000719
		public static ECCurve CreateFromValue(string oidValue)
		{
			if (oidValue == null)
			{
				throw new ArgumentNullException("oidValue");
			}
			return ECCurve.CreateFromValueAndName(oidValue, null);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002530 File Offset: 0x00000730
		private static ECCurve CreateFromValueAndName(string oidValue, string oidFriendlyName)
		{
			return ECCurve.Create(new Oid(oidValue, oidFriendlyName));
		}

		/// <summary>
		///         Получает значение, обозначающее, указывает ли тип кривой явную простую кривую.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если кривая является явной простой кривой; значение <see langword="false" />, если кривая является именованной простой кривой, кривой характеристики 2 или неявной кривой.
		///       </returns>
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000253E File Offset: 0x0000073E
		public bool IsPrime
		{
			get
			{
				return this.CurveType == ECCurve.ECCurveType.PrimeShortWeierstrass || this.CurveType == ECCurve.ECCurveType.PrimeMontgomery || this.CurveType == ECCurve.ECCurveType.PrimeTwistedEdwards;
			}
		}

		/// <summary>
		///         Получает значение, обозначающее, указывает ли тип кривой явную кривую характеристики 2.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если кривая является явной кривой характеристики 2; значение <see langword="false" />, если кривая является именованной кривой характеристики 2, простой или неявной кривой.
		///       </returns>
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000255D File Offset: 0x0000075D
		public bool IsCharacteristic2
		{
			get
			{
				return this.CurveType == ECCurve.ECCurveType.Characteristic2;
			}
		}

		/// <summary>
		///         Получает значение, обозначающее, указывает ли тип кривой явную кривую (простую кривую или кривую характеристики 2).
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если кривая является явной кривой (простой кривой или кривой характеристики 2); значение <see langword="false" />, если кривая является именованной или неявной кривой.
		///       </returns>
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002568 File Offset: 0x00000768
		public bool IsExplicit
		{
			get
			{
				return this.IsPrime || this.IsCharacteristic2;
			}
		}

		/// <summary>
		///         Получает значение, обозначающее, указывает ли тип кривой именованную кривую.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если кривая является именованной кривой; значение <see langword="false" />, если кривая является неявной или явной кривой (простой кривой или кривой характеристики 2).
		///       </returns>
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000257A File Offset: 0x0000077A
		public bool IsNamed
		{
			get
			{
				return this.CurveType == ECCurve.ECCurveType.Named;
			}
		}

		/// <summary>
		///         Проверяет целостность текущей кривой.
		///          Создает исключение <see cref="T:System.Security.Cryptography.CryptographicException" />, если структура не является допустимой.
		///       </summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Параметры кривой недопустимы для текущего типа кривой.
		///           </exception>
		// Token: 0x060000A6 RID: 166 RVA: 0x00002588 File Offset: 0x00000788
		public void Validate()
		{
			if (this.IsNamed)
			{
				if (this.HasAnyExplicitParameters())
				{
					throw new CryptographicException("The specified named curve parameters are not valid. Only the Oid parameter must be set.");
				}
				if (this.Oid == null || (string.IsNullOrEmpty(this.Oid.FriendlyName) && string.IsNullOrEmpty(this.Oid.Value)))
				{
					throw new CryptographicException("The specified Oid is not valid. The Oid.FriendlyName or Oid.Value property must be set.");
				}
			}
			else if (this.IsExplicit)
			{
				bool flag = false;
				if (this.A == null || this.B == null || this.B.Length != this.A.Length || this.G.X == null || this.G.X.Length != this.A.Length || this.G.Y == null || this.G.Y.Length != this.A.Length || this.Order == null || this.Order.Length == 0 || this.Cofactor == null || this.Cofactor.Length == 0)
				{
					flag = true;
				}
				if (this.IsPrime)
				{
					if (!flag && (this.Prime == null || this.Prime.Length != this.A.Length))
					{
						flag = true;
					}
					if (flag)
					{
						throw new CryptographicException("The specified prime curve parameters are not valid. Prime, A, B, G.X, G.Y and Order are required and must be the same length, and the same length as Q.X, Q.Y and D if those are specified. Seed, Cofactor and Hash are optional. Other parameters are not allowed.");
					}
				}
				else if (this.IsCharacteristic2)
				{
					if (!flag && (this.Polynomial == null || this.Polynomial.Length == 0))
					{
						flag = true;
					}
					if (flag)
					{
						throw new CryptographicException("The specified Characteristic2 curve parameters are not valid. Polynomial, A, B, G.X, G.Y, and Order are required. A, B, G.X, G.Y must be the same length, and the same length as Q.X, Q.Y and D if those are specified. Seed, Cofactor and Hash are optional. Other parameters are not allowed.");
					}
				}
			}
			else if (this.HasAnyExplicitParameters() || this.Oid != null)
			{
				throw new CryptographicException(string.Format("The specified curve '{0}' or its parameters are not valid for this platform.", this.CurveType.ToString()));
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002720 File Offset: 0x00000920
		private bool HasAnyExplicitParameters()
		{
			return this.A != null || this.B != null || this.G.X != null || this.G.Y != null || this.Order != null || this.Cofactor != null || this.Prime != null || this.Polynomial != null || this.Seed != null || this.Hash != null;
		}

		/// <summary>
		///         Первый коэффициент для явной кривой.
		///         A для коротких кривых Вейерштрасса, кривых Монтгомери и скрученных кривых Эдвардса.
		///       </summary>
		/// <returns>
		///         Коэффициент A.
		///       </returns>
		// Token: 0x040002BB RID: 699
		public byte[] A;

		/// <summary>
		///         Второй коэффициент для явной кривой.
		///         B для коротких кривых Вейерштрасса и d для скрученных кривых Эдвардса.
		///       </summary>
		/// <returns>
		///         Коэффициент B.
		///       </returns>
		// Token: 0x040002BC RID: 700
		public byte[] B;

		/// <summary>
		///         Генератор или базовая точка для операций на кривой.
		///       </summary>
		/// <returns>
		///         Базовая точка.
		///       </returns>
		// Token: 0x040002BD RID: 701
		public ECPoint G;

		/// <summary>
		///         Порядок кривой.
		///          Применяется только к явным кривым.
		///       </summary>
		/// <returns>
		///         Порядок кривой.
		///       </returns>
		// Token: 0x040002BE RID: 702
		public byte[] Order;

		/// <summary>
		///         Кофактор кривой.
		///       </summary>
		/// <returns>
		///         Кофактор кривой.
		///       </returns>
		// Token: 0x040002BF RID: 703
		public byte[] Cofactor;

		/// <summary>
		///         Начальное значение для создания коэффициента по алгоритму создания ANSI X9.62.
		///          Применяется только к явным кривым.
		///       </summary>
		/// <returns>
		///         Начальное значение.
		///       </returns>
		// Token: 0x040002C0 RID: 704
		public byte[] Seed;

		/// <summary>
		///         Определяет состав объекта <see cref="T:System.Security.Cryptography.ECCurve" />.
		///       </summary>
		/// <returns>
		///         Тип кривой.
		///       </returns>
		// Token: 0x040002C1 RID: 705
		public ECCurve.ECCurveType CurveType;

		/// <summary>
		///         Имя хэш-алгоритма, который использовался для создания коэффициентов кривой (<see cref="F:System.Security.Cryptography.ECCurve.A" /> и <see cref="F:System.Security.Cryptography.ECCurve.B" />) из <see cref="F:System.Security.Cryptography.ECCurve.Seed" /> согласно алгоритму формирования ANSI X9.62.
		///          Применяется только к явным кривым.
		///       </summary>
		/// <returns>
		///         Имя хэш-алгоритма, используемого для формирования коэффициентов кривой.
		///       </returns>
		// Token: 0x040002C2 RID: 706
		public HashAlgorithmName? Hash;

		/// <summary>
		///         Полином, описывающий кривую.
		///          Применяется только к кривым характеристики 2.
		///       </summary>
		/// <returns>
		///         Полином, описывающий кривую.
		///       </returns>
		// Token: 0x040002C3 RID: 707
		public byte[] Polynomial;

		/// <summary>
		///         Простое число, указывающее простое поле.
		///          Применяется только к простым кривым.
		///       </summary>
		/// <returns>
		///         Простое число P.
		///       </returns>
		// Token: 0x040002C4 RID: 708
		public byte[] Prime;

		// Token: 0x040002C5 RID: 709
		private Oid _oid;

		/// <summary>
		///         Определяет способ интерпретации данных, содержащихся в объекте <see cref="T:System.Security.Cryptography.ECCurve" />.
		///       </summary>
		// Token: 0x02000033 RID: 51
		public enum ECCurveType
		{
			/// <summary>
			///         Данные кривой не интерпретируются.
			///          Предполагается, что вызывающему объекту известен тип кривой.
			///       </summary>
			// Token: 0x040002C7 RID: 711
			Implicit,
			/// <summary>
			///         Параметры кривой представляют простую кривую с помощью формулы y^2 = x^3 + A*x + B в простом поле P.
			///       </summary>
			// Token: 0x040002C8 RID: 712
			PrimeShortWeierstrass,
			/// <summary>
			///         Параметры кривой представляют простую кривую с помощью формулы A*x^2 + y^2 = 1 + B*x^2*y^2 в простом поле P.
			///       </summary>
			// Token: 0x040002C9 RID: 713
			PrimeTwistedEdwards,
			/// <summary>
			///         Параметры кривой представляют простую кривую с помощью формулы B*y^2 = x^3 + A*x^2 + x.
			///       </summary>
			// Token: 0x040002CA RID: 714
			PrimeMontgomery,
			/// <summary>
			///         Параметры кривой представляют кривую характеристики 2.
			///       </summary>
			// Token: 0x040002CB RID: 715
			Characteristic2,
			/// <summary>
			///         Параметры кривой представляют именованную кривую.
			///       </summary>
			// Token: 0x040002CC RID: 716
			Named
		}

		/// <summary>
		///         Представляет класс фабрики для создания именованных кривых.
		///       </summary>
		// Token: 0x02000034 RID: 52
		public static class NamedCurves
		{
			/// <summary>
			///         Получает именованную кривую brainpoolP160r1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP160r1.
			///       </returns>
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000278C File Offset: 0x0000098C
			public static ECCurve brainpoolP160r1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP160r1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP160t1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP160t1.
			///       </returns>
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002798 File Offset: 0x00000998
			public static ECCurve brainpoolP160t1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP160t1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP192r1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP192r1.
			///       </returns>
			// Token: 0x1700000D RID: 13
			// (get) Token: 0x060000AA RID: 170 RVA: 0x000027A4 File Offset: 0x000009A4
			public static ECCurve brainpoolP192r1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP192r1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP192t1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP192t1.
			///       </returns>
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x060000AB RID: 171 RVA: 0x000027B0 File Offset: 0x000009B0
			public static ECCurve brainpoolP192t1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP192t1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP224r1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP224r1.
			///       </returns>
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060000AC RID: 172 RVA: 0x000027BC File Offset: 0x000009BC
			public static ECCurve brainpoolP224r1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP224r1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP224t1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP224t1.
			///       </returns>
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000AD RID: 173 RVA: 0x000027C8 File Offset: 0x000009C8
			public static ECCurve brainpoolP224t1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP224t1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP256r1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP256r1.
			///       </returns>
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000AE RID: 174 RVA: 0x000027D4 File Offset: 0x000009D4
			public static ECCurve brainpoolP256r1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP256r1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP256t1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP256t1.
			///       </returns>
			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000AF RID: 175 RVA: 0x000027E0 File Offset: 0x000009E0
			public static ECCurve brainpoolP256t1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP256t1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP320r1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP320r1.
			///       </returns>
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x000027EC File Offset: 0x000009EC
			public static ECCurve brainpoolP320r1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP320r1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP320t1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP320t1.
			///       </returns>
			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000B1 RID: 177 RVA: 0x000027F8 File Offset: 0x000009F8
			public static ECCurve brainpoolP320t1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP320t1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP384r1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP384r1.
			///       </returns>
			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002804 File Offset: 0x00000A04
			public static ECCurve brainpoolP384r1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP384r1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP384t1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP384t1.
			///       </returns>
			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002810 File Offset: 0x00000A10
			public static ECCurve brainpoolP384t1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP384t1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP512r1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP512r1.
			///       </returns>
			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000281C File Offset: 0x00000A1C
			public static ECCurve brainpoolP512r1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP512r1");
				}
			}

			/// <summary>
			///         Получает именованную кривую brainpoolP512t1.
			///       </summary>
			/// <returns>
			///         Именованная кривая brainpoolP512t1.
			///       </returns>
			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002828 File Offset: 0x00000A28
			public static ECCurve brainpoolP512t1
			{
				get
				{
					return ECCurve.CreateFromFriendlyName("brainpoolP512t1");
				}
			}

			/// <summary>
			///         Получает именованную кривую nistP256.
			///       </summary>
			/// <returns>
			///         Именованная кривая nistP256.
			///       </returns>
			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002834 File Offset: 0x00000A34
			public static ECCurve nistP256
			{
				get
				{
					return ECCurve.CreateFromValueAndName("1.2.840.10045.3.1.7", "nistP256");
				}
			}

			/// <summary>
			///         Получает именованную кривую nistP384.
			///       </summary>
			/// <returns>
			///         Именованная кривая nistP384.
			///       </returns>
			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002845 File Offset: 0x00000A45
			public static ECCurve nistP384
			{
				get
				{
					return ECCurve.CreateFromValueAndName("1.3.132.0.34", "nistP384");
				}
			}

			/// <summary>
			///         Получает именованную кривую nistP521.
			///       </summary>
			/// <returns>
			///         Именованная кривая nistP521.
			///       </returns>
			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002856 File Offset: 0x00000A56
			public static ECCurve nistP521
			{
				get
				{
					return ECCurve.CreateFromValueAndName("1.3.132.0.35", "nistP521");
				}
			}

			// Token: 0x040002CD RID: 717
			private const string ECDSA_P256_OID_VALUE = "1.2.840.10045.3.1.7";

			// Token: 0x040002CE RID: 718
			private const string ECDSA_P384_OID_VALUE = "1.3.132.0.34";

			// Token: 0x040002CF RID: 719
			private const string ECDSA_P521_OID_VALUE = "1.3.132.0.35";
		}
	}
}
