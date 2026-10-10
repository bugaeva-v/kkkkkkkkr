using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет абстрактный класс, из которого создаются все реализации хэш-алгоритмов с ключом.</summary>
	// Token: 0x02000499 RID: 1177
	[ComVisible(true)]
	public abstract class KeyedHashAlgorithm : HashAlgorithm
	{
		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Security.Cryptography.KeyedHashAlgorithm" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002F25 RID: 12069 RVA: 0x000A80EF File Offset: 0x000A62EF
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.KeyValue != null)
				{
					Array.Clear(this.KeyValue, 0, this.KeyValue.Length);
				}
				this.KeyValue = null;
			}
			base.Dispose(disposing);
		}

		/// <summary>Возвращает или задает ключ, используемый в хэш-алгоритме.</summary>
		/// <returns>Ключ, используемый в хэш-алгоритме.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Предпринята попытка изменения свойства <see cref="P:System.Security.Cryptography.KeyedHashAlgorithm.Key" /> после начала хэширования.</exception>
		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000A79C1 File Offset: 0x000A5BC1
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x000A811E File Offset: 0x000A631E
		public virtual byte[] Key
		{
			get
			{
				return (byte[])this.KeyValue.Clone();
			}
			set
			{
				if (this.State != 0)
				{
					throw new CryptographicException(Environment.GetResourceString("Hash key cannot be changed after the first write to the stream."));
				}
				this.KeyValue = (byte[])value.Clone();
			}
		}

		/// <summary>Создает экземпляр реализации по умолчанию хэш-алгоритма с ключом.</summary>
		/// <returns>Новый экземпляр <see cref="T:System.Security.Cryptography.HMACSHA1" />, если параметры по умолчанию не изменены.</returns>
		// Token: 0x06002F28 RID: 12072 RVA: 0x000A8149 File Offset: 0x000A6349
		public new static KeyedHashAlgorithm Create()
		{
			return KeyedHashAlgorithm.Create("System.Security.Cryptography.KeyedHashAlgorithm");
		}

		/// <summary>Создает экземпляр заданной реализации хэш-алгоритма с ключом.</summary>
		/// <param name="algName">Реализация хэш-алгоритма с ключом, которую требуется использовать. В следующей таблице представлены допустимые значения параметра <paramref name="algName" /> и алгоритмы, с которыми они сопоставляются.  
		///   Значение параметра 
		///   Инструменты 
		///   System.Security.Cryptography.HMAC 
		///  <see cref="T:System.Security.Cryptography.HMACSHA1" /> System.Security.Cryptography.KeyedHashAlgorithm 
		///  <see cref="T:System.Security.Cryptography.HMACSHA1" /> HMACMD5 
		///  <see cref="T:System.Security.Cryptography.HMACMD5" /> System.Security.Cryptography.HMACMD5 
		///  <see cref="T:System.Security.Cryptography.HMACMD5" /> HMACRIPEMD160 
		///  <see cref="T:System.Security.Cryptography.HMACRIPEMD160" /> System.Security.Cryptography.HMACRIPEMD160 
		///  <see cref="T:System.Security.Cryptography.HMACRIPEMD160" /> HMACSHA1 
		///  <see cref="T:System.Security.Cryptography.HMACSHA1" /> System.Security.Cryptography.HMACSHA1 
		///  <see cref="T:System.Security.Cryptography.HMACSHA1" /> HMACSHA256 
		///  <see cref="T:System.Security.Cryptography.HMACSHA256" /> System.Security.Cryptography.HMACSHA256 
		///  <see cref="T:System.Security.Cryptography.HMACSHA256" /> HMACSHA384 
		///  <see cref="T:System.Security.Cryptography.HMACSHA384" /> System.Security.Cryptography.HMACSHA384 
		///  <see cref="T:System.Security.Cryptography.HMACSHA384" /> HMACSHA512 
		///  <see cref="T:System.Security.Cryptography.HMACSHA512" /> System.Security.Cryptography.HMACSHA512 
		///  <see cref="T:System.Security.Cryptography.HMACSHA512" /> MACTripleDES 
		///  <see cref="T:System.Security.Cryptography.MACTripleDES" /> System.Security.Cryptography.MACTripleDES 
		///  <see cref="T:System.Security.Cryptography.MACTripleDES" /></param>
		/// <returns>Новый экземпляр заданного хэш-алгоритма с ключом.</returns>
		// Token: 0x06002F29 RID: 12073 RVA: 0x000A8155 File Offset: 0x000A6355
		public new static KeyedHashAlgorithm Create(string algName)
		{
			return (KeyedHashAlgorithm)CryptoConfig.CreateFromName(algName);
		}

		/// <summary>Ключ, используемый в хэш-алгоритме.</summary>
		// Token: 0x0400217D RID: 8573
		protected byte[] KeyValue;
	}
}
