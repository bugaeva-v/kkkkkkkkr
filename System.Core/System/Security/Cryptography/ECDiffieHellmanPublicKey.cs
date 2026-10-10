using System;
using System.Security.Permissions;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Предоставляет абстрактный базовый класс, от которого должны наследоваться все реализации <see cref="T:System.Security.Cryptography.ECDiffieHellmanCngPublicKey" />.
	///       </summary>
	// Token: 0x02000049 RID: 73
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public abstract class ECDiffieHellmanPublicKey : IDisposable
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.ECDiffieHellmanPublicKey" />.
		///       </summary>
		// Token: 0x06000175 RID: 373 RVA: 0x00003A15 File Offset: 0x00001C15
		protected ECDiffieHellmanPublicKey()
		{
			this.m_keyBlob = new byte[0];
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.ECDiffieHellmanPublicKey" />.
		///       </summary>
		/// <param name="keyBlob">
		///           Массив байтов, представляющий объект <see cref="T:System.Security.Cryptography.ECDiffieHellmanPublicKey" />.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="keyBlob" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000176 RID: 374 RVA: 0x00003A29 File Offset: 0x00001C29
		protected ECDiffieHellmanPublicKey(byte[] keyBlob)
		{
			if (keyBlob == null)
			{
				throw new ArgumentNullException("keyBlob");
			}
			this.m_keyBlob = (keyBlob.Clone() as byte[]);
		}

		/// <summary>
		///         Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Security.Cryptography.ECDiffieHellman" />.
		///       </summary>
		// Token: 0x06000177 RID: 375 RVA: 0x00003A50 File Offset: 0x00001C50
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>
		///         Освобождает неуправляемые ресурсы, используемые классом <see cref="T:System.Security.Cryptography.ECDiffieHellman" /> (при необходимости освобождает и управляемые ресурсы).
		///       </summary>
		/// <param name="disposing">
		///           Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.
		///         </param>
		// Token: 0x06000178 RID: 376 RVA: 0x00003A59 File Offset: 0x00001C59
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>
		///         Выполняет сериализацию BLOB-объекта ключа <see cref="T:System.Security.Cryptography.ECDiffieHellmanPublicKey" /> в массив байтов.
		///       </summary>
		/// <returns>
		///         Массив байтов, в котором содержится сериализованный открытый ключ алгоритма Диффи-Хеллмана на эллиптических кривых (ECDH).
		///       </returns>
		// Token: 0x06000179 RID: 377 RVA: 0x00003A5B File Offset: 0x00001C5B
		public virtual byte[] ToByteArray()
		{
			return this.m_keyBlob.Clone() as byte[];
		}

		/// <summary>
		///         Выполняет сериализацию открытого ключа <see cref="T:System.Security.Cryptography.ECDiffieHellmanPublicKey" /> в XML-строку.
		///       </summary>
		/// <returns>
		///         XML-строка, в которой содержится сериализованный открытый ключ алгоритма Диффи-Хеллмана на эллиптических кривых (ECDH).
		///       </returns>
		// Token: 0x0600017A RID: 378 RVA: 0x00003A6D File Offset: 0x00001C6D
		public virtual string ToXmlString()
		{
			throw new NotImplementedException(SR.GetString("Method not supported. Derived class must override."));
		}

		/// <summary>
		///         Если переопределено в производном классе, экспортирует именованный или явный объект <see cref="T:System.Security.Cryptography.ECParameters" /> для объекта <see cref="T:System.Security.Cryptography.ECCurve" />.
		///       </summary>
		/// <returns>
		///         Объект, представляющий точку на кривой для этого ключа.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x0600017B RID: 379 RVA: 0x000039F5 File Offset: 0x00001BF5
		public virtual ECParameters ExportParameters()
		{
			throw new NotSupportedException(SR.GetString("Method not supported. Derived class must override."));
		}

		/// <summary>
		///         Если переопределено в производном классе, экспортирует явный объект <see cref="T:System.Security.Cryptography.ECParameters" /> для объекта <see cref="T:System.Security.Cryptography.ECCurve" />.
		///       </summary>
		/// <returns>
		///         Объект, представляющий точку на кривой для этого ключа, в формате явной кривой.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Производный класс должен переопределять этот метод.
		///           </exception>
		// Token: 0x0600017C RID: 380 RVA: 0x000039F5 File Offset: 0x00001BF5
		public virtual ECParameters ExportExplicitParameters()
		{
			throw new NotSupportedException(SR.GetString("Method not supported. Derived class must override."));
		}

		// Token: 0x04000329 RID: 809
		private byte[] m_keyBlob;
	}
}
