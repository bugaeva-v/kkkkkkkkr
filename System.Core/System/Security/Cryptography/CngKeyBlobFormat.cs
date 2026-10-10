using System;
using System.Security.Permissions;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Задает формат BLOB-объекта ключа для использования с объектами криптографии следующего поколения (CNG) Майкрософт.
	///       </summary>
	// Token: 0x02000042 RID: 66
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public sealed class CngKeyBlobFormat : IEquatable<CngKeyBlobFormat>
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> используя указанный формат.
		///       </summary>
		/// <param name="format">
		///           Формат большого двоичного ОБЪЕКТА ключа для инициализации.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="format" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="format" /> Длина параметра равно 0 (нулю).
		///           </exception>
		// Token: 0x06000121 RID: 289 RVA: 0x00003318 File Offset: 0x00001518
		public CngKeyBlobFormat(string format)
		{
			if (format == null)
			{
				throw new ArgumentNullException("format");
			}
			if (format.Length == 0)
			{
				throw new ArgumentException(SR.GetString("The key blob format '{0}' is invalid.", new object[]
				{
					format
				}), "format");
			}
			this.m_format = format;
		}

		/// <summary>
		///         Возвращает имя формата большого двоичного ОБЪЕКТА ключа, текущий <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> указывает объект.
		///       </summary>
		/// <returns>
		///         Внедренные BLOB формат имя ключа.
		///       </returns>
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00003367 File Offset: 0x00001567
		public string Format
		{
			get
			{
				return this.m_format;
			}
		}

		/// <summary>
		///         Определяет неравенство двух <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> объектов укажите тот же формат большого двоичного ОБЪЕКТА ключа.
		///       </summary>
		/// <param name="left">
		///           Объект, задающий формат большого двоичного ОБЪЕКТА ключа.
		///         </param>
		/// <param name="right">
		///           Второй объект, сравниваемый с объектом, идентифицируемым по <paramref name="left" /> параметр.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если два объекта задают одинаковый формат большого двоичного ОБЪЕКТА ключа; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06000123 RID: 291 RVA: 0x0000336F File Offset: 0x0000156F
		public static bool operator ==(CngKeyBlobFormat left, CngKeyBlobFormat right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		/// <summary>
		///         Определяет неравенство двух <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> объектов не указан тот же формат большого двоичного ОБЪЕКТА ключа.
		///       </summary>
		/// <param name="left">
		///           Объект, задающий формат большого двоичного ОБЪЕКТА ключа.
		///         </param>
		/// <param name="right">
		///           Второй объект, сравниваемый с объектом, идентифицируемым по <paramref name="left" /> параметр.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если два объекта задают одинаковый формат большого двоичного ОБЪЕКТА ключа; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06000124 RID: 292 RVA: 0x00003380 File Offset: 0x00001580
		public static bool operator !=(CngKeyBlobFormat left, CngKeyBlobFormat right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		/// <summary>
		///         Сравнивает заданный объект с текущим объектом <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" />.
		///       </summary>
		/// <param name="obj">
		///           Объект, который требуется сравнить с текущим объектом <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <paramref name="obj" /> параметр <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> объект, который указывает тот же формат большого двоичного ОБЪЕКТА ключа, что и текущий объект; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06000125 RID: 293 RVA: 0x00003394 File Offset: 0x00001594
		public override bool Equals(object obj)
		{
			return this.Equals(obj as CngKeyBlobFormat);
		}

		/// <summary>
		///         Сравнивает заданный объект <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> с текущим объектом <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" />.
		///       </summary>
		/// <param name="other">
		///           Объект, который требуется сравнить с текущим объектом <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <paramref name="other" /> параметр задает тот же формат большого двоичного ОБЪЕКТА ключа, что и текущий объект; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06000126 RID: 294 RVA: 0x000033A2 File Offset: 0x000015A2
		public bool Equals(CngKeyBlobFormat other)
		{
			return other != null && this.m_format.Equals(other.Format);
		}

		/// <summary>
		///         Создает хэш-значение внедренного формат большого двоичного ОБЪЕКТА ключа в текущем <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> объекта.
		///       </summary>
		/// <returns>
		///         Хэш-значение внедренного формат большого двоичного ОБЪЕКТА ключа.
		///       </returns>
		// Token: 0x06000127 RID: 295 RVA: 0x000033BA File Offset: 0x000015BA
		public override int GetHashCode()
		{
			return this.m_format.GetHashCode();
		}

		/// <summary>
		///         Возвращает имя формата большого двоичного ОБЪЕКТА ключа, текущий <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> указывает объект.
		///       </summary>
		/// <returns>
		///         Внедренные BLOB формат имя ключа.
		///       </returns>
		// Token: 0x06000128 RID: 296 RVA: 0x00003367 File Offset: 0x00001567
		public override string ToString()
		{
			return this.m_format;
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> объект, задающий большой двоичный объект закрытого ключа для ключа шифрования (ECC) эллиптической кривой.
		///       </summary>
		/// <returns>
		///         Объект, задающий большой двоичный объект закрытого ключа ECC.
		///       </returns>
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000129 RID: 297 RVA: 0x000033C7 File Offset: 0x000015C7
		public static CngKeyBlobFormat EccPrivateBlob
		{
			get
			{
				if (CngKeyBlobFormat.s_eccPrivate == null)
				{
					CngKeyBlobFormat.s_eccPrivate = new CngKeyBlobFormat("ECCPRIVATEBLOB");
				}
				return CngKeyBlobFormat.s_eccPrivate;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> указывающий открытый ключ большого двоичного ОБЪЕКТА для ключа шифрования (ECC) эллиптической кривой.
		///       </summary>
		/// <returns>
		///         Объект, задающий большой двоичный объект открытого ключа ECC.
		///       </returns>
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000033F0 File Offset: 0x000015F0
		public static CngKeyBlobFormat EccPublicBlob
		{
			get
			{
				if (CngKeyBlobFormat.s_eccPublic == null)
				{
					CngKeyBlobFormat.s_eccPublic = new CngKeyBlobFormat("ECCPUBLICBLOB");
				}
				return CngKeyBlobFormat.s_eccPublic;
			}
		}

		/// <summary>
		///         Получает объект <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" />, указывающий BLOB-объект закрытого ключа для ключа шифрования на основе эллиптических кривых (ECC), содержащий параметры явной кривой.
		///       </summary>
		/// <returns>
		///         Объект, описывающий BLOB-объект закрытого ключа.
		///       </returns>
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00003419 File Offset: 0x00001619
		public static CngKeyBlobFormat EccFullPrivateBlob
		{
			get
			{
				if (CngKeyBlobFormat.s_eccFullPrivate == null)
				{
					CngKeyBlobFormat.s_eccFullPrivate = new CngKeyBlobFormat("ECCFULLPRIVATEBLOB");
				}
				return CngKeyBlobFormat.s_eccFullPrivate;
			}
		}

		/// <summary>
		///         Получает объект <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" />, указывающий BLOB-объект открытого ключа для ключа шифрования на основе эллиптических кривых (ECC), содержащий параметры явной кривой.
		///       </summary>
		/// <returns>
		///         Объект, описывающий BLOB-объект открытого ключа.
		///       </returns>
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00003442 File Offset: 0x00001642
		public static CngKeyBlobFormat EccFullPublicBlob
		{
			get
			{
				if (CngKeyBlobFormat.s_eccFullPublic == null)
				{
					CngKeyBlobFormat.s_eccFullPublic = new CngKeyBlobFormat("ECCFULLPUBLICBLOB");
				}
				return CngKeyBlobFormat.s_eccFullPublic;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> объект, задающий универсальный большой двоичный объект закрытого ключа.
		///       </summary>
		/// <returns>
		///         Объект, задающий универсальный большой двоичный объект закрытого ключа.
		///       </returns>
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000346B File Offset: 0x0000166B
		public static CngKeyBlobFormat GenericPrivateBlob
		{
			get
			{
				if (CngKeyBlobFormat.s_genericPrivate == null)
				{
					CngKeyBlobFormat.s_genericPrivate = new CngKeyBlobFormat("PRIVATEBLOB");
				}
				return CngKeyBlobFormat.s_genericPrivate;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> объект, задающий универсальный большой двоичный объект открытого ключа.
		///       </summary>
		/// <returns>
		///         Объект, задающий универсальный большой двоичный объект открытого ключа.
		///       </returns>
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00003494 File Offset: 0x00001694
		public static CngKeyBlobFormat GenericPublicBlob
		{
			get
			{
				if (CngKeyBlobFormat.s_genericPublic == null)
				{
					CngKeyBlobFormat.s_genericPublic = new CngKeyBlobFormat("PUBLICBLOB");
				}
				return CngKeyBlobFormat.s_genericPublic;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> объект, задающий большой двоичный объект ключа непрозрачной передачи.
		///       </summary>
		/// <returns>
		///         Объект, задающий большой двоичный объект ключа непрозрачной передачи.
		///       </returns>
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000034BD File Offset: 0x000016BD
		public static CngKeyBlobFormat OpaqueTransportBlob
		{
			get
			{
				if (CngKeyBlobFormat.s_opaqueTransport == null)
				{
					CngKeyBlobFormat.s_opaqueTransport = new CngKeyBlobFormat("OpaqueTransport");
				}
				return CngKeyBlobFormat.s_opaqueTransport;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngKeyBlobFormat" /> объект, задающий большой двоичный объект закрытого ключа сведения синтаксис Standard (PKCS #8) ключа.
		///       </summary>
		/// <returns>
		///         Объект, задающий большой двоичный объект закрытого ключа PKCS 8.
		///       </returns>
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000034E6 File Offset: 0x000016E6
		public static CngKeyBlobFormat Pkcs8PrivateBlob
		{
			get
			{
				if (CngKeyBlobFormat.s_pkcs8Private == null)
				{
					CngKeyBlobFormat.s_pkcs8Private = new CngKeyBlobFormat("PKCS8_PRIVATEKEY");
				}
				return CngKeyBlobFormat.s_pkcs8Private;
			}
		}

		// Token: 0x0400030D RID: 781
		private static volatile CngKeyBlobFormat s_eccPrivate;

		// Token: 0x0400030E RID: 782
		private static volatile CngKeyBlobFormat s_eccPublic;

		// Token: 0x0400030F RID: 783
		private static volatile CngKeyBlobFormat s_eccFullPrivate;

		// Token: 0x04000310 RID: 784
		private static volatile CngKeyBlobFormat s_eccFullPublic;

		// Token: 0x04000311 RID: 785
		private static volatile CngKeyBlobFormat s_genericPrivate;

		// Token: 0x04000312 RID: 786
		private static volatile CngKeyBlobFormat s_genericPublic;

		// Token: 0x04000313 RID: 787
		private static volatile CngKeyBlobFormat s_opaqueTransport;

		// Token: 0x04000314 RID: 788
		private static volatile CngKeyBlobFormat s_pkcs8Private;

		// Token: 0x04000315 RID: 789
		private string m_format;
	}
}
