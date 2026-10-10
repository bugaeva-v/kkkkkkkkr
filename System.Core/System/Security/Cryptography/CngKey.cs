using System;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Определяет базовую функциональность для ключей, используемых объектами криптографии следующего поколения (CNG).
	///       </summary>
	// Token: 0x02000041 RID: 65
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class CngKey : IDisposable
	{
		/// <summary>
		///         Возвращает группу алгоритм, используемый ключом.
		///       </summary>
		/// <returns>
		///         Объект, задающий имя группы алгоритмов шифрования.
		///       </returns>
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000023CA File Offset: 0x000005CA
		public CngAlgorithmGroup AlgorithmGroup
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Возвращает алгоритм, используемый ключом.
		///       </summary>
		/// <returns>
		///         Объект, задающий имя алгоритма шифрования.
		///       </returns>
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000023CA File Offset: 0x000005CA
		public CngAlgorithm Algorithm
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Получает политику экспорта, используемую ключом.
		///       </summary>
		/// <returns>
		///         Объект, задающий политику экспорта ключа.
		///       </returns>
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000023CA File Offset: 0x000005CA
		public CngExportPolicies ExportPolicy
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Возвращает безопасный дескриптор, представляющий собственный ключ (NCRYPT_KEY_HANDLE).
		///       </summary>
		/// <returns>
		///         Безопасный дескриптор, представляющий ключ.
		///       </returns>
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000023CA File Offset: 0x000005CA
		public SafeNCryptKeyHandle Handle
		{
			[SecurityCritical]
			[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Получает состояние сохранения ключа.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если ключ является эфемерным; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000023CA File Offset: 0x000005CA
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000023CA File Offset: 0x000005CA
		public bool IsEphemeral
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
			[SecurityCritical]
			private set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Возвращает область (компьютера или пользователя) ключа.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если ключ доступен для всех пользователей компьютера; <see langword="false" /> Если ключ только для текущего пользователя.
		///       </returns>
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000023CA File Offset: 0x000005CA
		public bool IsMachineKey
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Возвращает имя ключа.
		///       </summary>
		/// <returns>
		///         Имя ключа.
		///          Если ключ является эфемерным, значение равно <see langword="null" />.
		///       </returns>
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000023CA File Offset: 0x000005CA
		public string KeyName
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Получает размер ключа в битах.
		///       </summary>
		/// <returns>
		///         Размер ключа в битах.
		///       </returns>
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000023CA File Offset: 0x000005CA
		public int KeySize
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Получает криптографические операции, заданные ключом.
		///       </summary>
		/// <returns>
		///         Побитовое сочетание значений перечисления, определяющих разрешенные варианты ключ использования.
		///       </returns>
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000023CA File Offset: 0x000005CA
		public CngKeyUsages KeyUsage
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Возвращает или задает дескриптор окна (HWND), который должен использоваться для запросов пользовательского интерфейса для пользователей при доступе к разделу.
		///       </summary>
		/// <returns>
		///         Дескриптор родительского окна для ключа.
		///       </returns>
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000023CA File Offset: 0x000005CA
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000023CA File Offset: 0x000005CA
		public IntPtr ParentWindowHandle
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
			[SecuritySafeCritical]
			[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Получает поставщик хранилища ключей (KSP), управляющего ключом.
		///       </summary>
		/// <returns>
		///         KSP, управляющий ключом.
		///       </returns>
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000023CA File Offset: 0x000005CA
		public CngProvider Provider
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Получает собственный дескриптор (NCRYPT_PROV_HANDLE) для поставщика хранилища ключей (KSP).
		///       </summary>
		/// <returns>
		///         Дескриптор KSP.
		///       </returns>
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000023CA File Offset: 0x000005CA
		public SafeNCryptProviderHandle ProviderHandle
		{
			[SecurityCritical]
			[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Возвращает уникальное имя для ключа.
		///       </summary>
		/// <returns>
		///         Альтернативное имя для ключа.
		///          Если ключ является эфемерным, значение равно <see langword="null" />.
		///       </returns>
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000023CA File Offset: 0x000005CA
		public string UniqueName
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Получает параметры, управляющие пользовательский интерфейс (UI) для доступа к разделу.
		///       </summary>
		/// <returns>
		///         Объект, содержащий параметры конфигурации для отображения пользовательского интерфейса.
		///       </returns>
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000023CA File Offset: 0x000005CA
		public CngUIPolicy UIPolicy
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Создает <see cref="T:System.Security.Cryptography.CngKey" /> объект, который можно использовать с помощью указанного алгоритма.
		///       </summary>
		/// <param name="algorithm">
		///           Алгоритм, который будет использоваться ключ.
		///         </param>
		/// <returns>
		///         Эфемерный ключ.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="algorithm" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x0600010E RID: 270 RVA: 0x000023CA File Offset: 0x000005CA
		public static CngKey Create(CngAlgorithm algorithm)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает именованный <see cref="T:System.Security.Cryptography.CngKey" /> объект, предоставляющий указанный алгоритм.
		///       </summary>
		/// <param name="algorithm">
		///           Алгоритм, который будет использоваться ключ.
		///         </param>
		/// <param name="keyName">
		///           Имя ключа.
		///            Если имя не указано, то ключ, не будут сохранены.
		///         </param>
		/// <returns>
		///         Постоянный или эфемерный ключ, обеспечивающий работу заданного алгоритма.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="algorithm" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x0600010F RID: 271 RVA: 0x000023CA File Offset: 0x000005CA
		public static CngKey Create(CngAlgorithm algorithm, string keyName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает именованный <see cref="T:System.Security.Cryptography.CngKey" /> объект, предоставляющий указанный алгоритм, с помощью параметров создания указанного ключа.
		///       </summary>
		/// <param name="algorithm">
		///           Алгоритм, который будет использоваться ключ.
		///         </param>
		/// <param name="keyName">
		///           Имя ключа.
		///            Если имя не указано, то ключ, не будут сохранены.
		///         </param>
		/// <param name="creationParameters">
		///           Объект, который указывает дополнительные параметры для метода, включая <see cref="T:System.Security.Cryptography.CngProvider" />.
		///         </param>
		/// <returns>
		///         Постоянный или эфемерный ключ, обеспечивающий работу заданного алгоритма.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="algorithm" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x06000110 RID: 272 RVA: 0x000023CA File Offset: 0x000005CA
		[SecuritySafeCritical]
		public static CngKey Create(CngAlgorithm algorithm, string keyName, CngKeyCreationParameters creationParameters)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Удаляет ключ, связанный с объектом.
		///       </summary>
		/// <exception cref="T:System.ObjectDisposedException">
		///             Предпринята попытка получить доступ к удаленный ключ.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x06000111 RID: 273 RVA: 0x000023CA File Offset: 0x000005CA
		[SecuritySafeCritical]
		public void Delete()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Security.Cryptography.CngKey" />.
		///       </summary>
		// Token: 0x06000112 RID: 274 RVA: 0x000023CA File Offset: 0x000005CA
		[SecuritySafeCritical]
		public void Dispose()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Проверяет, существует ли именованный ключ в поставщик хранилища ключей (KSP) по умолчанию.
		///       </summary>
		/// <param name="keyName">
		///           Имя ключа.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если именованный ключ существует в KSP по умолчанию; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="keyName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x06000113 RID: 275 RVA: 0x000023CA File Offset: 0x000005CA
		public static bool Exists(string keyName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Проверяет наличие именованного ключа в заданном поставщике хранилища ключей (KSP).
		///       </summary>
		/// <param name="keyName">
		///           Имя ключа.
		///         </param>
		/// <param name="provider">
		///           KSP, проверяемый на ключ.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если именованный ключ существует в заданном поставщике; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="keyName" /> или <paramref name="provider" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x06000114 RID: 276 RVA: 0x000023CA File Offset: 0x000005CA
		public static bool Exists(string keyName, CngProvider provider)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Проверяет наличие именованного ключа в заданном поставщике хранилища ключей (KSP) в соответствии с заданными параметрами.
		///       </summary>
		/// <param name="keyName">
		///           Имя ключа.
		///         </param>
		/// <param name="provider">
		///           KSP, для поиска ключа.
		///         </param>
		/// <param name="options">
		///           Побитовое сочетание значений перечисления, определяющих параметры открытия ключа.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если именованный ключ существует в заданном поставщике; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="keyName" /> или <paramref name="provider" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x06000115 RID: 277 RVA: 0x000023CA File Offset: 0x000005CA
		[SecuritySafeCritical]
		public static bool Exists(string keyName, CngProvider provider, CngKeyOpenOptions options)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает новый ключ путем импорта заданного ключевого материала в поставщик хранилища ключей (KSP) по умолчанию и с использованием указанного формата.
		///       </summary>
		/// <param name="keyBlob">
		///           Массив, содержащий сведения о ключе.
		///         </param>
		/// <param name="format">
		///           Объект, который указывает формат массива <paramref name="keyBlob" />.
		///         </param>
		/// <returns>
		///         Новый ключ.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="keyBlob" /> или <paramref name="format" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x06000116 RID: 278 RVA: 0x000023CA File Offset: 0x000005CA
		public static CngKey Import(byte[] keyBlob, CngKeyBlobFormat format)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает ключ путем импорта заданных сведений о ключе в указанный поставщик хранилища ключей (KSP), используя указанный формат.
		///       </summary>
		/// <param name="keyBlob">
		///           Массив, содержащий сведения о ключе.
		///         </param>
		/// <param name="format">
		///           Объект, который указывает формат массива <paramref name="keyBlob" />.
		///         </param>
		/// <param name="provider">
		///           KSP.
		///         </param>
		/// <returns>
		///         Новый ключ.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="keyBlob" />, <paramref name="format" /> или <paramref name="provider" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x06000117 RID: 279 RVA: 0x000023CA File Offset: 0x000005CA
		[SecuritySafeCritical]
		public static CngKey Import(byte[] keyBlob, CngKeyBlobFormat format, CngProvider provider)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Экспортирует ключевой материал в большой двоичный объект в указанном формате.
		///       </summary>
		/// <param name="format">
		///           Объект, задающий формат большого двоичного ОБЪЕКТА ключа.
		///         </param>
		/// <returns>
		///         Большой двоичный объект, содержащий ключевой материал в заданном формате.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="format" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///              Как правило <see cref="P:System.Security.Cryptography.CngKey.ExportPolicy" /> запретить экспорт ключа.
		///           </exception>
		// Token: 0x06000118 RID: 280 RVA: 0x000023CA File Offset: 0x000005CA
		[SecuritySafeCritical]
		public byte[] Export(CngKeyBlobFormat format)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Получает свойство по заданному имени и набору параметров.
		///       </summary>
		/// <param name="name">
		///           Имя нужного свойства.
		///         </param>
		/// <param name="options">
		///           Побитовое сочетание значений перечисления, определяющих параметры именованного свойства.
		///         </param>
		/// <returns>
		///         Объект, содержащий необработанное значение заданного свойства.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="name" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x06000119 RID: 281 RVA: 0x000023CA File Offset: 0x000005CA
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		public CngProperty GetProperty(string name, CngPropertyOptions options)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Проверяет, существует ли указанное свойство ключа.
		///       </summary>
		/// <param name="name">
		///           Имя свойства для проверки.
		///         </param>
		/// <param name="options">
		///           Побитовое сочетание значений перечисления, определяющих параметры именованного свойства.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если указанное свойство найдено; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="name" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600011A RID: 282 RVA: 0x000023CA File Offset: 0x000005CA
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		public bool HasProperty(string name, CngPropertyOptions options)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает экземпляр <see cref="T:System.Security.Cryptography.CngKey" /> объект, который представляет существующий именованный ключ.
		///       </summary>
		/// <param name="keyName">
		///           Имя ключа.
		///         </param>
		/// <returns>
		///         Существующий ключ.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="keyName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x0600011B RID: 283 RVA: 0x000023CA File Offset: 0x000005CA
		public static CngKey Open(string keyName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает экземпляр <see cref="T:System.Security.Cryptography.CngKey" /> объект, который представляет существующий именованный ключ, используя заданном поставщике хранилища ключей (KSP).
		///       </summary>
		/// <param name="keyName">
		///           Имя ключа.
		///         </param>
		/// <param name="provider">
		///           KSP, в котором содержится ключ.
		///         </param>
		/// <returns>
		///         Существующий ключ.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="keyName" /> или <paramref name="provider" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x0600011C RID: 284 RVA: 0x000023CA File Offset: 0x000005CA
		public static CngKey Open(string keyName, CngProvider provider)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает экземпляр <see cref="T:System.Security.Cryptography.CngKey" /> объект, который представляет существующий именованный ключ, используя в заданном поставщике хранилища ключей (KSP) и параметры открытия ключа.
		///       </summary>
		/// <param name="keyName">
		///           Имя ключа.
		///         </param>
		/// <param name="provider">
		///           KSP, в котором содержится ключ.
		///         </param>
		/// <param name="openOptions">
		///           Побитовое сочетание значений перечисления, определяющих параметры открытия ключа, например когда открытия ключа (компьютер или хранилище пользователя) и необходимость подавления запросов пользовательского интерфейса.
		///         </param>
		/// <returns>
		///         Существующий ключ.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="keyName" /> или <paramref name="provider" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x0600011D RID: 285 RVA: 0x000023CA File Offset: 0x000005CA
		[SecuritySafeCritical]
		public static CngKey Open(string keyName, CngProvider provider, CngKeyOpenOptions openOptions)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает экземпляр <see cref="T:System.Security.Cryptography.CngKey" /> используя дескриптор существующего ключа.
		///       </summary>
		/// <param name="keyHandle">
		///           Дескриптор существующего ключа.
		///         </param>
		/// <param name="keyHandleOpenOptions">
		///           Одно из значений перечисления, указывающее, является ли <paramref name="keyHandle" /> представляет эфемерный ключ или именованный ключ.
		///         </param>
		/// <returns>
		///         Существующий ключ.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="keyHandle" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="keyHandle" /> является недопустимым или имеет неправильный формат, или он уже закрыт.
		///              Это исключение также возникает, если ключ является эфемерным, создаваемый общеязыковой среды выполнения (CLR), но <see cref="F:System.Security.Cryptography.CngKeyHandleOpenOptions.EphemeralKey" /> значение не указано.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///             Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x0600011E RID: 286 RVA: 0x000023CA File Offset: 0x000005CA
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		public static CngKey Open(SafeNCryptKeyHandle keyHandle, CngKeyHandleOpenOptions keyHandleOpenOptions)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Задает именованное свойство ключа.
		///       </summary>
		/// <param name="property">
		///           Свойство ключа.
		///         </param>
		// Token: 0x0600011F RID: 287 RVA: 0x000023CA File Offset: 0x000005CA
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		public void SetProperty(CngProperty property)
		{
			throw new NotImplementedException();
		}
	}
}
