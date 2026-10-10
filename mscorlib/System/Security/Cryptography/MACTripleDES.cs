using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет код проверки подлинности сообщения (MAC) с помощью алгоритма <see cref="T:System.Security.Cryptography.TripleDES" /> для входных данных <see cref="T:System.Security.Cryptography.CryptoStream" />.</summary>
	// Token: 0x0200049A RID: 1178
	[ComVisible(true)]
	public class MACTripleDES : KeyedHashAlgorithm
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.MACTripleDES" />.</summary>
		// Token: 0x06002F2A RID: 12074 RVA: 0x000A8164 File Offset: 0x000A6364
		public MACTripleDES()
		{
			this.KeyValue = new byte[24];
			Utils.StaticRandomNumberGenerator.GetBytes(this.KeyValue);
			this.des = TripleDES.Create();
			this.HashSizeValue = this.des.BlockSize;
			this.m_bytesPerBlock = this.des.BlockSize / 8;
			this.des.IV = new byte[this.m_bytesPerBlock];
			this.des.Padding = PaddingMode.Zeros;
			this.m_encryptor = null;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.MACTripleDES" /> указанными данными ключа.</summary>
		/// <param name="rgbKey">Секретный ключ для шифрования <see cref="T:System.Security.Cryptography.MACTripleDES" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rgbKey" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002F2B RID: 12075 RVA: 0x000A81EC File Offset: 0x000A63EC
		public MACTripleDES(byte[] rgbKey) : this("System.Security.Cryptography.TripleDES", rgbKey)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.MACTripleDES" /> указанными данными ключа и используя  заданную реализацию <see cref="T:System.Security.Cryptography.TripleDES" />.</summary>
		/// <param name="strTripleDES">Имя используемой реализации <see cref="T:System.Security.Cryptography.TripleDES" />.</param>
		/// <param name="rgbKey">Секретный ключ для шифрования <see cref="T:System.Security.Cryptography.MACTripleDES" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rgbKey" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Параметр <paramref name="strTripleDES" /> не является допустимым именем реализации <see cref="T:System.Security.Cryptography.TripleDES" />.</exception>
		// Token: 0x06002F2C RID: 12076 RVA: 0x000A81FC File Offset: 0x000A63FC
		public MACTripleDES(string strTripleDES, byte[] rgbKey)
		{
			if (rgbKey == null)
			{
				throw new ArgumentNullException("rgbKey");
			}
			if (strTripleDES == null)
			{
				this.des = TripleDES.Create();
			}
			else
			{
				this.des = TripleDES.Create(strTripleDES);
			}
			this.HashSizeValue = this.des.BlockSize;
			this.KeyValue = (byte[])rgbKey.Clone();
			this.m_bytesPerBlock = this.des.BlockSize / 8;
			this.des.IV = new byte[this.m_bytesPerBlock];
			this.des.Padding = PaddingMode.Zeros;
			this.m_encryptor = null;
		}

		/// <summary>Инициализирует экземпляр <see cref="T:System.Security.Cryptography.MACTripleDES" />.</summary>
		// Token: 0x06002F2D RID: 12077 RVA: 0x000A8297 File Offset: 0x000A6497
		public override void Initialize()
		{
			this.m_encryptor = null;
		}

		/// <summary>Возвращает или задает режим заполнения, используемый в хэш-алгоритме.</summary>
		/// <returns>Режим заполнения, используемый в хэш-алгоритме.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Невозможно задать свойство, поскольку указан недопустимый режим заполнения.</exception>
		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002F2E RID: 12078 RVA: 0x000A82A0 File Offset: 0x000A64A0
		// (set) Token: 0x06002F2F RID: 12079 RVA: 0x000A82AD File Offset: 0x000A64AD
		[ComVisible(false)]
		public PaddingMode Padding
		{
			get
			{
				return this.des.Padding;
			}
			set
			{
				if (value < PaddingMode.None || PaddingMode.ISO10126 < value)
				{
					throw new CryptographicException(Environment.GetResourceString("Specified padding mode is not valid for this algorithm."));
				}
				this.des.Padding = value;
			}
		}

		/// <summary>Передает данные, записанные в объект, в шифратор <see cref="T:System.Security.Cryptography.TripleDES" /> для вычисления кода проверки подлинности сообщения (MAC).</summary>
		/// <param name="rgbData">Входные данные.</param>
		/// <param name="ibStart">Смещение в массиве байтов, начиная с которого следует использовать данные.</param>
		/// <param name="cbSize">Число байтов в массиве для использования в качестве данных.</param>
		// Token: 0x06002F30 RID: 12080 RVA: 0x000A82D4 File Offset: 0x000A64D4
		protected override void HashCore(byte[] rgbData, int ibStart, int cbSize)
		{
			if (this.m_encryptor == null)
			{
				this.des.Key = this.Key;
				this.m_encryptor = this.des.CreateEncryptor();
				this._ts = new TailStream(this.des.BlockSize / 8);
				this._cs = new CryptoStream(this._ts, this.m_encryptor, CryptoStreamMode.Write);
			}
			this._cs.Write(rgbData, ibStart, cbSize);
		}

		/// <summary>Возвращает вычисленный код проверки подлинности сообщения (MAC) после записи в объект всех данных.</summary>
		/// <returns>Вычисленный код MAC.</returns>
		// Token: 0x06002F31 RID: 12081 RVA: 0x000A834C File Offset: 0x000A654C
		protected override byte[] HashFinal()
		{
			if (this.m_encryptor == null)
			{
				this.des.Key = this.Key;
				this.m_encryptor = this.des.CreateEncryptor();
				this._ts = new TailStream(this.des.BlockSize / 8);
				this._cs = new CryptoStream(this._ts, this.m_encryptor, CryptoStreamMode.Write);
			}
			this._cs.FlushFinalBlock();
			return this._ts.Buffer;
		}

		/// <summary>Освобождает ресурсы, используемые экземпляром <see cref="T:System.Security.Cryptography.MACTripleDES" />.</summary>
		/// <param name="disposing">Значение <see langword="true" />, если метод вызывается из реализации <see cref="M:System.IDisposable.Dispose" />; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06002F32 RID: 12082 RVA: 0x000A83CC File Offset: 0x000A65CC
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.des != null)
				{
					this.des.Clear();
				}
				if (this.m_encryptor != null)
				{
					this.m_encryptor.Dispose();
				}
				if (this._cs != null)
				{
					this._cs.Clear();
				}
				if (this._ts != null)
				{
					this._ts.Clear();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x0400217E RID: 8574
		private ICryptoTransform m_encryptor;

		// Token: 0x0400217F RID: 8575
		private CryptoStream _cs;

		// Token: 0x04002180 RID: 8576
		private TailStream _ts;

		// Token: 0x04002181 RID: 8577
		private const int m_bitsPerByte = 8;

		// Token: 0x04002182 RID: 8578
		private int m_bytesPerBlock;

		// Token: 0x04002183 RID: 8579
		private TripleDES des;
	}
}
