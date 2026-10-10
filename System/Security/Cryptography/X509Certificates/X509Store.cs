using System;
using System.Security.Permissions;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Представляет хранилище X.509, которое является физическими хранилищем, используемым для хранения сертификатов X.509 и управления ими. Этот класс не наследуется.</summary>
	// Token: 0x020002E7 RID: 743
	public sealed class X509Store : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" /> с использованием личных сертификатов из хранилища текущего пользователя.</summary>
		// Token: 0x060017A2 RID: 6050 RVA: 0x0005DBE3 File Offset: 0x0005BDE3
		public X509Store() : this("MY", StoreLocation.CurrentUser)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" />, используя указанное имя хранилища.</summary>
		/// <param name="storeName">Строковое значение, представляющее имя хранилища. Дополнительные сведения см. в разделе <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" />.</param>
		// Token: 0x060017A3 RID: 6051 RVA: 0x0005DBF1 File Offset: 0x0005BDF1
		public X509Store(string storeName) : this(storeName, StoreLocation.CurrentUser)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" />, используя указанное значение <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" />.</summary>
		/// <param name="storeName">Одно из значений перечисления, указывающее имя хранилища сертификатов X.509.</param>
		// Token: 0x060017A4 RID: 6052 RVA: 0x0005DBFB File Offset: 0x0005BDFB
		public X509Store(StoreName storeName) : this(storeName, StoreLocation.CurrentUser)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" />, используя указанное значение <see cref="T:System.Security.Cryptography.X509Certificates.StoreLocation" />.</summary>
		/// <param name="storeLocation">Одно из значений перечисления, определяющее расположение хранилища сертификатов X.509.</param>
		// Token: 0x060017A5 RID: 6053 RVA: 0x0005DC05 File Offset: 0x0005BE05
		public X509Store(StoreLocation storeLocation) : this("MY", storeLocation)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" />, используя указанные значения <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" /> и <see cref="T:System.Security.Cryptography.X509Certificates.StoreLocation" />.</summary>
		/// <param name="storeName">Одно из значений перечисления, указывающее имя хранилища сертификатов X.509.</param>
		/// <param name="storeLocation">Одно из значений перечисления, определяющее расположение хранилища сертификатов X.509.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="storeLocation" /> не является допустимым расположением, или <paramref name="storeName" /> не является допустимым именем.</exception>
		// Token: 0x060017A6 RID: 6054 RVA: 0x0005DC14 File Offset: 0x0005BE14
		public X509Store(StoreName storeName, StoreLocation storeLocation)
		{
			if (storeName < StoreName.AddressBook || storeName > StoreName.TrustedPublisher)
			{
				throw new ArgumentException("storeName");
			}
			if (storeLocation < StoreLocation.CurrentUser || storeLocation > StoreLocation.LocalMachine)
			{
				throw new ArgumentException("storeLocation");
			}
			if (storeName == StoreName.CertificateAuthority)
			{
				this._name = "CA";
			}
			else
			{
				this._name = storeName.ToString();
			}
			this._location = storeLocation;
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x0005DC78 File Offset: 0x0005BE78
		public X509Store(StoreName storeName, StoreLocation storeLocation, OpenFlags openFlags) : this(storeName, storeLocation)
		{
			this._flags = openFlags;
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x0005DC89 File Offset: 0x0005BE89
		public X509Store(string storeName, StoreLocation storeLocation, OpenFlags openFlags) : this(storeName, storeLocation)
		{
			this._flags = openFlags;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" /> с помощью дескриптора Intptr в хранилище <see langword="HCERTSTORE" />.</summary>
		/// <param name="storeHandle">Дескриптор хранилища <see langword="HCERTSTORE" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="storeHandle" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр <paramref name="storeHandle" /> указывает на недопустимый контекст.</exception>
		// Token: 0x060017A9 RID: 6057 RVA: 0x0005DC9A File Offset: 0x0005BE9A
		[MonoTODO("Mono's stores are fully managed. All handles are invalid.")]
		[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
		public X509Store(IntPtr storeHandle)
		{
			if (storeHandle == IntPtr.Zero)
			{
				throw new ArgumentNullException("storeHandle");
			}
			throw new CryptographicException("Invalid handle.");
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" /> с помощью строки, представляющей значение перечисления <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" /> и значение перечисления <see cref="T:System.Security.Cryptography.X509Certificates.StoreLocation" />.</summary>
		/// <param name="storeName">Строка, представляющая значение перечисления <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" />.</param>
		/// <param name="storeLocation">Одно из значений перечисления, определяющее расположение хранилища сертификатов X.509.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="storeLocation" /> содержит недопустимое значение.</exception>
		// Token: 0x060017AA RID: 6058 RVA: 0x0005DCC4 File Offset: 0x0005BEC4
		public X509Store(string storeName, StoreLocation storeLocation)
		{
			if (storeLocation < StoreLocation.CurrentUser || storeLocation > StoreLocation.LocalMachine)
			{
				throw new ArgumentException("storeLocation");
			}
			this._name = storeName;
			this._location = storeLocation;
		}

		/// <summary>Возвращает коллекцию сертификатов, расположенную в хранилище сертификатов X.509.</summary>
		/// <returns>Коллекция сертификатов.</returns>
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x0005DCED File Offset: 0x0005BEED
		public X509Certificate2Collection Certificates
		{
			get
			{
				if (this.list == null)
				{
					this.list = new X509Certificate2Collection();
				}
				else if (this.store == null)
				{
					this.list.Clear();
				}
				return this.list;
			}
		}

		/// <summary>Получает расположение хранилища сертификатов X.509.</summary>
		/// <returns>Расположение хранилища сертификатов.</returns>
		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x0005DD1D File Offset: 0x0005BF1D
		public StoreLocation Location
		{
			get
			{
				return this._location;
			}
		}

		/// <summary>Возвращает имя хранилища сертификатов X.509.</summary>
		/// <returns>Имя хранилища сертификатов.</returns>
		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x0005DD25 File Offset: 0x0005BF25
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x0005DD2D File Offset: 0x0005BF2D
		private X509Stores Factory
		{
			get
			{
				if (this._location == StoreLocation.CurrentUser)
				{
					return X509StoreManager.CurrentUser;
				}
				return X509StoreManager.LocalMachine;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060017AF RID: 6063 RVA: 0x0005DD43 File Offset: 0x0005BF43
		public bool IsOpen
		{
			get
			{
				return this.store != null;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x0005DD4E File Offset: 0x0005BF4E
		private bool IsReadOnly
		{
			get
			{
				return (this._flags & OpenFlags.ReadWrite) == OpenFlags.ReadOnly;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x0005DD5B File Offset: 0x0005BF5B
		internal X509Store Store
		{
			get
			{
				return this.store;
			}
		}

		/// <summary>Получает дескриптор <see cref="T:System.IntPtr" /> хранилища <see langword="HCERTSTORE" />.</summary>
		/// <returns>Дескриптор хранилища <see langword="HCERTSTORE" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Хранилище не открыто.</exception>
		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x00011E31 File Offset: 0x00010031
		[MonoTODO("Mono's stores are fully managed. Always returns IntPtr.Zero.")]
		public IntPtr StoreHandle
		{
			get
			{
				return IntPtr.Zero;
			}
		}

		/// <summary>Добавляет сертификат в хранилище сертификатов X.509.</summary>
		/// <param name="certificate">Добавляемый сертификат.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="certificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось добавить сертификат в хранилище.</exception>
		// Token: 0x060017B3 RID: 6067 RVA: 0x0005DD64 File Offset: 0x0005BF64
		public void Add(X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			if (!this.IsOpen)
			{
				throw new CryptographicException(Locale.GetText("Store isn't opened."));
			}
			if (this.IsReadOnly)
			{
				throw new CryptographicException(Locale.GetText("Store is read-only."));
			}
			if (!this.Exists(certificate))
			{
				try
				{
					this.store.Import(new X509Certificate(certificate.RawData));
				}
				finally
				{
					this.Certificates.Add(certificate);
				}
			}
		}

		/// <summary>Добавляет коллекцию сертификатов в хранилище сертификатов X.509.</summary>
		/// <param name="certificates">Добавляемая коллекция сертификатов.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="certificates" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060017B4 RID: 6068 RVA: 0x0005DDF0 File Offset: 0x0005BFF0
		[MonoTODO("Method isn't transactional (like documented)")]
		public void AddRange(X509Certificate2Collection certificates)
		{
			if (certificates == null)
			{
				throw new ArgumentNullException("certificates");
			}
			if (certificates.Count == 0)
			{
				return;
			}
			if (!this.IsOpen)
			{
				throw new CryptographicException(Locale.GetText("Store isn't opened."));
			}
			if (this.IsReadOnly)
			{
				throw new CryptographicException(Locale.GetText("Store is read-only."));
			}
			foreach (X509Certificate2 x509Certificate in certificates)
			{
				if (!this.Exists(x509Certificate))
				{
					try
					{
						this.store.Import(new X509Certificate(x509Certificate.RawData));
					}
					finally
					{
						this.Certificates.Add(x509Certificate);
					}
				}
			}
		}

		/// <summary>Закрывает хранилище сертификатов X.509.</summary>
		// Token: 0x060017B5 RID: 6069 RVA: 0x0005DE9C File Offset: 0x0005C09C
		public void Close()
		{
			this.store = null;
			if (this.list != null)
			{
				this.list.Clear();
			}
		}

		/// <summary>Освобождает ресурсы, используемые этим экземпляром <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" />.</summary>
		// Token: 0x060017B6 RID: 6070 RVA: 0x0005DEB8 File Offset: 0x0005C0B8
		public void Dispose()
		{
			this.Close();
		}

		/// <summary>Открывает хранилище сертификатов X.509 или создает новое хранилище, в зависимости от параметров флага <see cref="T:System.Security.Cryptography.X509Certificates.OpenFlags" />.</summary>
		/// <param name="flags">Побитовое сочетание значений перечисления, определяющее способ открытия хранилища сертификатов X.509.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Хранилище не читается.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">Хранилище содержит недопустимые значения.</exception>
		// Token: 0x060017B7 RID: 6071 RVA: 0x0005DEC0 File Offset: 0x0005C0C0
		public void Open(OpenFlags flags)
		{
			if (string.IsNullOrEmpty(this._name))
			{
				throw new CryptographicException(Locale.GetText("Invalid store name (null or empty)."));
			}
			string storeName;
			if (this._name == "Root")
			{
				storeName = "Trust";
			}
			else
			{
				storeName = this._name;
			}
			bool create = (flags & OpenFlags.OpenExistingOnly) != OpenFlags.OpenExistingOnly;
			this.store = this.Factory.Open(storeName, create);
			if (this.store == null)
			{
				throw new CryptographicException(Locale.GetText("Store {0} doesn't exists.", new object[]
				{
					this._name
				}));
			}
			this._flags = flags;
			foreach (X509Certificate x509Certificate in this.store.Certificates)
			{
				X509Certificate2 x509Certificate2 = new X509Certificate2(x509Certificate.RawData);
				x509Certificate2.Impl.PrivateKey = x509Certificate.RSA;
				this.Certificates.Add(x509Certificate2);
			}
		}

		/// <summary>Удаляет сертификат из хранилища сертификатов X.509.</summary>
		/// <param name="certificate">Сертификат, подлежащий удалению.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="certificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060017B8 RID: 6072 RVA: 0x0005DFCC File Offset: 0x0005C1CC
		public void Remove(X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			if (!this.IsOpen)
			{
				throw new CryptographicException(Locale.GetText("Store isn't opened."));
			}
			if (!this.Exists(certificate))
			{
				return;
			}
			if (this.IsReadOnly)
			{
				throw new CryptographicException(Locale.GetText("Store is read-only."));
			}
			try
			{
				this.store.Remove(new X509Certificate(certificate.RawData));
			}
			finally
			{
				this.Certificates.Remove(certificate);
			}
		}

		/// <summary>Удаляет диапазон сертификатов из хранилища сертификатов X.509.</summary>
		/// <param name="certificates">Диапазон сертификатов, подлежащих удалению.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="certificates" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060017B9 RID: 6073 RVA: 0x0005E058 File Offset: 0x0005C258
		[MonoTODO("Method isn't transactional (like documented)")]
		public void RemoveRange(X509Certificate2Collection certificates)
		{
			if (certificates == null)
			{
				throw new ArgumentNullException("certificates");
			}
			if (certificates.Count == 0)
			{
				return;
			}
			if (!this.IsOpen)
			{
				throw new CryptographicException(Locale.GetText("Store isn't opened."));
			}
			bool flag = false;
			foreach (X509Certificate2 certificate in certificates)
			{
				if (this.Exists(certificate))
				{
					flag = true;
				}
			}
			if (!flag)
			{
				return;
			}
			if (this.IsReadOnly)
			{
				throw new CryptographicException(Locale.GetText("Store is read-only."));
			}
			try
			{
				foreach (X509Certificate2 x509Certificate in certificates)
				{
					this.store.Remove(new X509Certificate(x509Certificate.RawData));
				}
			}
			finally
			{
				this.Certificates.RemoveRange(certificates);
			}
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0005E124 File Offset: 0x0005C324
		private bool Exists(X509Certificate2 certificate)
		{
			if (this.store == null || this.list == null || certificate == null)
			{
				return false;
			}
			foreach (X509Certificate2 other in this.list)
			{
				if (certificate.Equals(other))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000D31 RID: 3377
		private string _name;

		// Token: 0x04000D32 RID: 3378
		private StoreLocation _location;

		// Token: 0x04000D33 RID: 3379
		private X509Certificate2Collection list;

		// Token: 0x04000D34 RID: 3380
		private OpenFlags _flags;

		// Token: 0x04000D35 RID: 3381
		private X509Store store;
	}
}
