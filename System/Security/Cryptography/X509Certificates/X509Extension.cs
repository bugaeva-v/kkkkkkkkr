using System;
using System.Text;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Представляет расширение X509.</summary>
	// Token: 0x020002E2 RID: 738
	public class X509Extension : AsnEncodedData
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />.</summary>
		// Token: 0x06001776 RID: 6006 RVA: 0x0005D14E File Offset: 0x0005B34E
		protected X509Extension()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />.</summary>
		/// <param name="encodedExtension">Закодированные данные, используемые для создания расширения.</param>
		/// <param name="critical">Значение <see langword="true" />, если расширение является критическим, в противном случае — <see langword="false" />.</param>
		// Token: 0x06001777 RID: 6007 RVA: 0x0005D156 File Offset: 0x0005B356
		public X509Extension(AsnEncodedData encodedExtension, bool critical)
		{
			if (encodedExtension.Oid == null)
			{
				throw new ArgumentNullException("encodedExtension.Oid");
			}
			base.Oid = encodedExtension.Oid;
			base.RawData = encodedExtension.RawData;
			this._critical = critical;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />.</summary>
		/// <param name="oid">Идентификатор объекта, используемый для определения расширения.</param>
		/// <param name="rawData">Закодированные данные, используемые для создания расширения.</param>
		/// <param name="critical">Значение <see langword="true" />, если расширение является критическим, в противном случае — <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="oid" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="oid" /> является пустой строкой ("").</exception>
		// Token: 0x06001778 RID: 6008 RVA: 0x0005D190 File Offset: 0x0005B390
		public X509Extension(Oid oid, byte[] rawData, bool critical)
		{
			if (oid == null)
			{
				throw new ArgumentNullException("oid");
			}
			base.Oid = oid;
			base.RawData = rawData;
			this._critical = critical;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />.</summary>
		/// <param name="oid">Строка, представляющая идентификатор объекта.</param>
		/// <param name="rawData">Закодированные данные, используемые для создания расширения.</param>
		/// <param name="critical">Значение <see langword="true" />, если расширение является критическим, в противном случае — <see langword="false" />.</param>
		// Token: 0x06001779 RID: 6009 RVA: 0x0005D1BB File Offset: 0x0005B3BB
		public X509Extension(string oid, byte[] rawData, bool critical) : base(oid, rawData)
		{
			this._critical = critical;
		}

		/// <summary>Получает логическое значение, определяющее, является ли расширение критическим.</summary>
		/// <returns>Значение <see langword="true" />, если расширение является критическим, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x0005D1CC File Offset: 0x0005B3CC
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x0005D1D4 File Offset: 0x0005B3D4
		public bool Critical
		{
			get
			{
				return this._critical;
			}
			set
			{
				this._critical = value;
			}
		}

		/// <summary>Копирует свойства расширения указанного объекта <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</summary>
		/// <param name="asnEncodedData">Копируемый объект <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asnEncodedData" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">В классе <paramref name="asnEncodedData" /> отсутствует допустимое расширение X.509.</exception>
		// Token: 0x0600177C RID: 6012 RVA: 0x0005D1E0 File Offset: 0x0005B3E0
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			if (asnEncodedData == null)
			{
				throw new ArgumentNullException("encodedData");
			}
			X509Extension x509Extension = asnEncodedData as X509Extension;
			if (x509Extension == null)
			{
				throw new ArgumentException(Locale.GetText("Expected a X509Extension instance."));
			}
			base.CopyFrom(asnEncodedData);
			this._critical = x509Extension.Critical;
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x0005D228 File Offset: 0x0005B428
		internal string FormatUnkownData(byte[] data)
		{
			if (data == null || data.Length == 0)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < data.Length; i++)
			{
				stringBuilder.Append(data[i].ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000D28 RID: 3368
		private bool _critical;
	}
}
