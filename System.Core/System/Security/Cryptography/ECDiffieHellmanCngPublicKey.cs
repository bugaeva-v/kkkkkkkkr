using System;
using System.Security.Permissions;
using Unity;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Указывает открытый ключ алгоритма Диффи-Хеллмана на эллиптических кривых (ECDH) для использования с <see cref="T:System.Security.Cryptography.ECDiffieHellmanCng" /> класса.
	///       </summary>
	// Token: 0x0200036F RID: 879
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public sealed class ECDiffieHellmanCngPublicKey : ECDiffieHellmanPublicKey
	{
		// Token: 0x06001AC9 RID: 6857 RVA: 0x0000235B File Offset: 0x0000055B
		internal ECDiffieHellmanCngPublicKey()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает формат большого двоичного ОБЪЕКТА ключа <see cref="T:System.Security.Cryptography.ECDiffieHellmanCngPublicKey" /> объекта.
		///       </summary>
		/// <returns>
		///         Формат, выраженный в большой двоичный объект ключа.
		///       </returns>
		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x0005A05A File Offset: 0x0005825A
		public CngKeyBlobFormat BlobFormat
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Преобразует массив байтов, содержащий открытый ключ для <see cref="T:System.Security.Cryptography.ECDiffieHellmanCngPublicKey" /> объекта согласно указанному формату.
		///       </summary>
		/// <param name="publicKeyBlob">
		///           Массив байтов, содержащий открытый ключ алгоритма Диффи-Хеллмана на эллиптических кривых (ECDH).
		///         </param>
		/// <param name="format">
		///           Объект, задающий формат большого двоичного ОБЪЕКТА ключа.
		///         </param>
		/// <returns>
		///         Объект, содержащий открытый ключ ECDH, сериализованный в массив байтов.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение параметра <paramref name="publicKeyBlob" /> или параметра <paramref name="format" /> — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="publicKeyBlob" /> Параметр не содержит <see cref="T:System.Security.Cryptography.ECDiffieHellman" /> ключа.
		///           </exception>
		// Token: 0x06001ACB RID: 6859 RVA: 0x0005A05A File Offset: 0x0005825A
		[SecuritySafeCritical]
		public static ECDiffieHellmanPublicKey FromByteArray(byte[] publicKeyBlob, CngKeyBlobFormat format)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Преобразует XML-строка <see cref="T:System.Security.Cryptography.ECDiffieHellmanCngPublicKey" /> объекта.
		///       </summary>
		/// <param name="xml">
		///           XML-строка, которая содержит ключ алгоритма Диффи-Хеллмана на эллиптических кривых (ECDH).
		///         </param>
		/// <returns>
		///         Объект, содержащий открытый ключ ECDH, заданный указанной XML.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="xml" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="xml" /> Не указан параметр <see cref="T:System.Security.Cryptography.ECDiffieHellman" /> ключа.
		///           </exception>
		// Token: 0x06001ACC RID: 6860 RVA: 0x0005A05A File Offset: 0x0005825A
		[SecuritySafeCritical]
		public static ECDiffieHellmanCngPublicKey FromXmlString(string xml)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Преобразует <see cref="T:System.Security.Cryptography.ECDiffieHellmanCngPublicKey" /> объект <see cref="T:System.Security.Cryptography.CngKey" /> объект.
		///       </summary>
		/// <returns>
		///         Объект, содержащий ключ, представленный <see cref="T:System.Security.Cryptography.ECDiffieHellmanCngPublicKey" /> объекта.
		///       </returns>
		// Token: 0x06001ACD RID: 6861 RVA: 0x0005A05A File Offset: 0x0005825A
		public CngKey Import()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
