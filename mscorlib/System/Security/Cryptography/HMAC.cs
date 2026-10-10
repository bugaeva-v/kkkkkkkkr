using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет абстрактный класс, от которого должны наследоваться все реализации хэш-кода проверки подлинности сообщения (HMAC).</summary>
	// Token: 0x0200048E RID: 1166
	[ComVisible(true)]
	public abstract class HMAC : KeyedHashAlgorithm
	{
		/// <summary>Возвращает или задает размер блока, используемый в хэш-значении.</summary>
		/// <returns>Размер блока, используемый в хэш значении.</returns>
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x000A78B3 File Offset: 0x000A5AB3
		// (set) Token: 0x06002EEA RID: 12010 RVA: 0x000A78BB File Offset: 0x000A5ABB
		protected int BlockSizeValue
		{
			get
			{
				return this.blockSizeValue;
			}
			set
			{
				this.blockSizeValue = value;
			}
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x000A78C4 File Offset: 0x000A5AC4
		private void UpdateIOPadBuffers()
		{
			if (this.m_inner == null)
			{
				this.m_inner = new byte[this.BlockSizeValue];
			}
			if (this.m_outer == null)
			{
				this.m_outer = new byte[this.BlockSizeValue];
			}
			for (int i = 0; i < this.BlockSizeValue; i++)
			{
				this.m_inner[i] = 54;
				this.m_outer[i] = 92;
			}
			for (int i = 0; i < this.KeyValue.Length; i++)
			{
				byte[] inner = this.m_inner;
				int num = i;
				inner[num] ^= this.KeyValue[i];
				byte[] outer = this.m_outer;
				int num2 = i;
				outer[num2] ^= this.KeyValue[i];
			}
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x000A7970 File Offset: 0x000A5B70
		internal void InitializeKey(byte[] key)
		{
			this.m_inner = null;
			this.m_outer = null;
			if (key.Length > this.BlockSizeValue)
			{
				this.KeyValue = this.m_hash1.ComputeHash(key);
			}
			else
			{
				this.KeyValue = (byte[])key.Clone();
			}
			this.UpdateIOPadBuffers();
		}

		/// <summary>Возвращает или задает ключ, используемый в хэш-алгоритме.</summary>
		/// <returns>Ключ, используемый в хэш-алгоритме.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Предпринята попытка изменения свойства <see cref="P:System.Security.Cryptography.HMAC.Key" /> после начала хэширования.</exception>
		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x000A79C1 File Offset: 0x000A5BC1
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x000A79D3 File Offset: 0x000A5BD3
		public override byte[] Key
		{
			get
			{
				return (byte[])this.KeyValue.Clone();
			}
			set
			{
				if (this.m_hashing)
				{
					throw new CryptographicException(Environment.GetResourceString("Hash key cannot be changed after the first write to the stream."));
				}
				this.InitializeKey(value);
			}
		}

		/// <summary>Возвращает или задает имя используемого хэш-алгоритма.</summary>
		/// <returns>Имя хэш-алгоритма.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Невозможно изменить текущий хэш-алгоритм.</exception>
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x000A79F4 File Offset: 0x000A5BF4
		// (set) Token: 0x06002EF0 RID: 12016 RVA: 0x000A79FC File Offset: 0x000A5BFC
		public string HashName
		{
			get
			{
				return this.m_hashName;
			}
			set
			{
				if (this.m_hashing)
				{
					throw new CryptographicException(Environment.GetResourceString("Hash name cannot be changed after the first write to the stream."));
				}
				this.m_hashName = value;
				this.m_hash1 = HashAlgorithm.Create(this.m_hashName);
				this.m_hash2 = HashAlgorithm.Create(this.m_hashName);
			}
		}

		/// <summary>Создает экземпляр реализации хэш-кода проверки подлинности сообщения (HMAC) по умолчанию.</summary>
		/// <returns>Новый экземпляр SHA-1, если параметры по умолчанию не были изменены с помощью элемента &lt;cryptoClass&gt;.</returns>
		// Token: 0x06002EF1 RID: 12017 RVA: 0x000A7A4A File Offset: 0x000A5C4A
		public new static HMAC Create()
		{
			return HMAC.Create("System.Security.Cryptography.HMAC");
		}

		/// <summary>Создает экземпляр заданной реализации хэш-кода проверки подлинности сообщения (HMAC).</summary>
		/// <param name="algorithmName">Реализация кода HMAC для использования. В следующей таблице представлены допустимые значения параметра <paramref name="algorithmName" /> и алгоритмы, с которыми они сопоставляются.  
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
		/// <returns>Новый экземпляр заданной реализации кода HMAC.</returns>
		// Token: 0x06002EF2 RID: 12018 RVA: 0x000A7A56 File Offset: 0x000A5C56
		public new static HMAC Create(string algorithmName)
		{
			return (HMAC)CryptoConfig.CreateFromName(algorithmName);
		}

		/// <summary>Инициализирует новый экземпляр реализации по умолчанию класса <see cref="T:System.Security.Cryptography.HMAC" />.</summary>
		// Token: 0x06002EF3 RID: 12019 RVA: 0x000A7A63 File Offset: 0x000A5C63
		public override void Initialize()
		{
			this.m_hash1.Initialize();
			this.m_hash2.Initialize();
			this.m_hashing = false;
		}

		/// <summary>Если переопределено в производном классе, передает данные, записанные в объект, на вход хэш-алгоритма <see cref="T:System.Security.Cryptography.HMAC" /> по умолчанию для вычисления значения хэша.</summary>
		/// <param name="rgb">Входные данные.</param>
		/// <param name="ib">Смещение в массиве байтов, начиная с которого следует использовать данные.</param>
		/// <param name="cb">Число байтов в массиве для использования в качестве данных.</param>
		// Token: 0x06002EF4 RID: 12020 RVA: 0x000A7A84 File Offset: 0x000A5C84
		protected override void HashCore(byte[] rgb, int ib, int cb)
		{
			if (!this.m_hashing)
			{
				this.m_hash1.TransformBlock(this.m_inner, 0, this.m_inner.Length, this.m_inner, 0);
				this.m_hashing = true;
			}
			this.m_hash1.TransformBlock(rgb, ib, cb, rgb, ib);
		}

		/// <summary>Если переопределено в производном классе, завершает вычисление хэша после обработки последних данных криптографическим потоковым объектом.</summary>
		/// <returns>Вычисленный хэш-код в массиве байтов.</returns>
		// Token: 0x06002EF5 RID: 12021 RVA: 0x000A7AD4 File Offset: 0x000A5CD4
		protected override byte[] HashFinal()
		{
			if (!this.m_hashing)
			{
				this.m_hash1.TransformBlock(this.m_inner, 0, this.m_inner.Length, this.m_inner, 0);
				this.m_hashing = true;
			}
			this.m_hash1.TransformFinalBlock(EmptyArray<byte>.Value, 0, 0);
			byte[] hashValue = this.m_hash1.HashValue;
			this.m_hash2.TransformBlock(this.m_outer, 0, this.m_outer.Length, this.m_outer, 0);
			this.m_hash2.TransformBlock(hashValue, 0, hashValue.Length, hashValue, 0);
			this.m_hashing = false;
			this.m_hash2.TransformFinalBlock(EmptyArray<byte>.Value, 0, 0);
			return this.m_hash2.HashValue;
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Security.Cryptography.HMAC" />, и, если допускается изменение ключа, опционально освобождает управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002EF6 RID: 12022 RVA: 0x000A7B8C File Offset: 0x000A5D8C
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.m_hash1 != null)
				{
					((IDisposable)this.m_hash1).Dispose();
				}
				if (this.m_hash2 != null)
				{
					((IDisposable)this.m_hash2).Dispose();
				}
				if (this.m_inner != null)
				{
					Array.Clear(this.m_inner, 0, this.m_inner.Length);
				}
				if (this.m_outer != null)
				{
					Array.Clear(this.m_outer, 0, this.m_outer.Length);
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x000A7C04 File Offset: 0x000A5E04
		internal static HashAlgorithm GetHashAlgorithmWithFipsFallback(Func<HashAlgorithm> createStandardHashAlgorithmCallback, Func<HashAlgorithm> createFipsHashAlgorithmCallback)
		{
			if (CryptoConfig.AllowOnlyFipsAlgorithms)
			{
				try
				{
					return createFipsHashAlgorithmCallback();
				}
				catch (PlatformNotSupportedException ex)
				{
					throw new InvalidOperationException(ex.Message, ex);
				}
			}
			return createStandardHashAlgorithmCallback();
		}

		// Token: 0x04002165 RID: 8549
		private int blockSizeValue = 64;

		// Token: 0x04002166 RID: 8550
		internal string m_hashName;

		// Token: 0x04002167 RID: 8551
		internal HashAlgorithm m_hash1;

		// Token: 0x04002168 RID: 8552
		internal HashAlgorithm m_hash2;

		// Token: 0x04002169 RID: 8553
		private byte[] m_inner;

		// Token: 0x0400216A RID: 8554
		private byte[] m_outer;

		// Token: 0x0400216B RID: 8555
		private bool m_hashing;
	}
}
