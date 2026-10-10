using System;
using System.Security.Permissions;
using Unity;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Предоставляет реализацию алгоритма цифровых подписей (DSA) на платформе криптографии следующего поколения (CNG).
	///       </summary>
	// Token: 0x0200036C RID: 876
	public sealed class DSACng : DSA
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DSACng" /> с парой случайных 2048-битных ключей.
		///       </summary>
		// Token: 0x06001AA7 RID: 6823 RVA: 0x0000235B File Offset: 0x0000055B
		public DSACng()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DSACng" /> с созданным случайным образом ключом указанного размера.
		///       </summary>
		/// <param name="keySize">
		///           Размер создаваемого ключа в битах.
		///         </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Недопустимый параметр <paramref name="keySize" />.
		///           </exception>
		// Token: 0x06001AA8 RID: 6824 RVA: 0x0000235B File Offset: 0x0000055B
		public DSACng(int keySize)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DSACng" /> с заданным ключом.
		///       </summary>
		/// <param name="key">
		///           Ключ, используемый для операций DSA.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="key" /> не является допустимым ключом DSA.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="key" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001AA9 RID: 6825 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public DSACng(CngKey key)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Получает ключ, который будет использоваться объектом <see cref="T:System.Security.Cryptography.DSACng" /> для любой выполняемой им криптографической операции.
		///       </summary>
		/// <returns>
		///         Ключ, используемый объектом <see cref="T:System.Security.Cryptography.DSACng" /> для выполнения криптографических операций.
		///       </returns>
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x0005A05A File Offset: 0x0005825A
		public CngKey Key
		{
			[SecuritySafeCritical]
			[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Создает цифровую подпись для указанных данных.
		///       </summary>
		/// <param name="rgbHash">
		///           Данные, которые должны быть подписаны.
		///         </param>
		/// <returns>
		///         Цифровая подпись для указанных данных.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="rgbHash" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Значение <paramref name="rgbHash" /> короче значения Q ключа DSA.
		///           </exception>
		// Token: 0x06001AAB RID: 6827 RVA: 0x0005A05A File Offset: 0x0005825A
		[SecuritySafeCritical]
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Экспортирует параметры алгоритма DSA.
		///       </summary>
		/// <param name="includePrivateParameters">
		///           Значение <see langword="true" /> для включения закрытых параметров; в противном случае — значение <see langword="false" />.
		///         </param>
		/// <returns>
		///         Параметры алгоритма DSA.
		///       </returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Ключ DSA не является допустимым открытым или закрытым ключом.
		///           </exception>
		// Token: 0x06001AAC RID: 6828 RVA: 0x0005A064 File Offset: 0x00058264
		public override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(DSAParameters);
		}

		/// <summary>
		///         Заменяет существующий ключ, с которым работает текущий экземпляр, создавая новый объект <see cref="T:System.Security.Cryptography.CngKey" /> для структуры параметров.
		///       </summary>
		/// <param name="parameters">
		///           Параметры DSA.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Указаны недопустимые параметры DSA.
		///           </exception>
		// Token: 0x06001AAD RID: 6829 RVA: 0x0000235B File Offset: 0x0000055B
		public override void ImportParameters(DSAParameters parameters)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Проверяет, совпадает ли указанная цифровая подпись с указанными данными.
		///       </summary>
		/// <param name="rgbHash">
		///           Подписанные данные.
		///         </param>
		/// <param name="rgbSignature">
		///           Проверяемая цифровая подпись.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если <paramref name="rgbSignature" /> совпадает с подписью, вычисленной с помощью указанных данных. В противном случае — значение <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="rgbHash" /> имеет значение <see langword="null" />.
		///
		///             -или- 
		///
		///             Параметр <paramref name="rgbSignature" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Значение <paramref name="rgbHash" /> короче значения Q ключа DSA.
		///           </exception>
		// Token: 0x06001AAE RID: 6830 RVA: 0x0005A080 File Offset: 0x00058280
		[SecuritySafeCritical]
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}
	}
}
