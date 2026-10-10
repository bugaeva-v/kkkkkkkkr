using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace System.Security.Cryptography
{
	/// <summary>Содержит параметры, передаваемые поставщику служб шифрования (CSP), который выполняет криптографические вычисления. Этот класс не наследуется.</summary>
	// Token: 0x02000486 RID: 1158
	[ComVisible(true)]
	public sealed class CspParameters
	{
		/// <summary>Представляет флаги для <see cref="T:System.Security.Cryptography.CspParameters" />, изменяющие поведение поставщика служб шифрования (CSP).</summary>
		/// <returns>Значение перечисления или побитовое сочетание значений перечисления.</returns>
		/// <exception cref="T:System.ArgumentException">Значение не является допустимым значением перечисления.</exception>
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x000A6982 File Offset: 0x000A4B82
		// (set) Token: 0x06002EA2 RID: 11938 RVA: 0x000A698C File Offset: 0x000A4B8C
		public CspProviderFlags Flags
		{
			get
			{
				return (CspProviderFlags)this.m_flags;
			}
			set
			{
				int num = 255;
				if ((value & (CspProviderFlags)(~(CspProviderFlags)num)) != CspProviderFlags.NoFlags)
				{
					throw new ArgumentException(Environment.GetResourceString("Illegal enum value: {0}.", new object[]
					{
						(int)value
					}), "value");
				}
				this.m_flags = (int)value;
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />, представляющий права доступа и правила аудита для контейнера.</summary>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />, представляющий права доступа и правила аудита для контейнера.</returns>
		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x000A69D2 File Offset: 0x000A4BD2
		// (set) Token: 0x06002EA4 RID: 11940 RVA: 0x000A69DA File Offset: 0x000A4BDA
		public CryptoKeySecurity CryptoKeySecurity
		{
			get
			{
				return this.m_cryptoKeySecurity;
			}
			set
			{
				this.m_cryptoKeySecurity = value;
			}
		}

		/// <summary>Возвращает или задает пароль, связанный со смарт-картой.</summary>
		/// <returns>Пароль, связанный со смарт-картой.</returns>
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x000A69E3 File Offset: 0x000A4BE3
		// (set) Token: 0x06002EA6 RID: 11942 RVA: 0x000A69EB File Offset: 0x000A4BEB
		public SecureString KeyPassword
		{
			get
			{
				return this.m_keyPassword;
			}
			set
			{
				this.m_keyPassword = value;
				this.m_parentWindowHandle = IntPtr.Zero;
			}
		}

		/// <summary>Возвращает или задает дескриптор неуправляемого родительского окна для окна ввода пароля смарт-карты.</summary>
		/// <returns>Дескриптор родительского окна для окна ввода пароля смарт-карты.</returns>
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x000A69FF File Offset: 0x000A4BFF
		// (set) Token: 0x06002EA8 RID: 11944 RVA: 0x000A6A07 File Offset: 0x000A4C07
		public IntPtr ParentWindowHandle
		{
			get
			{
				return this.m_parentWindowHandle;
			}
			set
			{
				this.m_parentWindowHandle = value;
				this.m_keyPassword = null;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
		// Token: 0x06002EA9 RID: 11945 RVA: 0x000A6A17 File Offset: 0x000A4C17
		public CspParameters() : this(1, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CspParameters" /> с заданным кодом типа поставщика.</summary>
		/// <param name="dwTypeIn">Код типа поставщика, определяющий вид создаваемого поставщика.</param>
		// Token: 0x06002EAA RID: 11946 RVA: 0x000A6A22 File Offset: 0x000A4C22
		public CspParameters(int dwTypeIn) : this(dwTypeIn, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CspParameters" /> с заданным кодом типа поставщика и именем.</summary>
		/// <param name="dwTypeIn">Код типа поставщика, определяющий вид создаваемого поставщика.</param>
		/// <param name="strProviderNameIn">Имя поставщика.</param>
		// Token: 0x06002EAB RID: 11947 RVA: 0x000A6A2D File Offset: 0x000A4C2D
		public CspParameters(int dwTypeIn, string strProviderNameIn) : this(dwTypeIn, strProviderNameIn, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CspParameters" /> с заданным кодом типа и именем поставщика и именем контейнера.</summary>
		/// <param name="dwTypeIn">Код типа поставщика, определяющий вид создаваемого поставщика.</param>
		/// <param name="strProviderNameIn">Имя поставщика.</param>
		/// <param name="strContainerNameIn">Имя контейнера.</param>
		// Token: 0x06002EAC RID: 11948 RVA: 0x000A6A38 File Offset: 0x000A4C38
		public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) : this(dwTypeIn, strProviderNameIn, strContainerNameIn, CspProviderFlags.NoFlags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CspParameters" />, используя тип поставщика, имя поставщика, имя контейнера, сведения о доступе и пароль, связанный со смарт-картой.</summary>
		/// <param name="providerType">Код типа поставщика, определяющий вид создаваемого поставщика.</param>
		/// <param name="providerName">Имя поставщика.</param>
		/// <param name="keyContainerName">Имя контейнера.</param>
		/// <param name="cryptoKeySecurity">Объект, представляющий права доступа и правила аудита для контейнера.</param>
		/// <param name="keyPassword">Пароль, связанный со смарт-картой.</param>
		// Token: 0x06002EAD RID: 11949 RVA: 0x000A6A44 File Offset: 0x000A4C44
		public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, SecureString keyPassword) : this(providerType, providerName, keyContainerName)
		{
			this.m_cryptoKeySecurity = cryptoKeySecurity;
			this.m_keyPassword = keyPassword;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CspParameters" />, используя тип поставщика, имя поставщика, имя контейнера, сведения о доступе и дескриптор неуправляемого окна ввода пароля смарт-карты.</summary>
		/// <param name="providerType">Код типа поставщика, определяющий вид создаваемого поставщика.</param>
		/// <param name="providerName">Имя поставщика.</param>
		/// <param name="keyContainerName">Имя контейнера.</param>
		/// <param name="cryptoKeySecurity">Объект, представляющий права доступа и правила аудита для контейнера.</param>
		/// <param name="parentWindowHandle">Дескриптор родительского окна для окна ввода пароля смарт-карты.</param>
		// Token: 0x06002EAE RID: 11950 RVA: 0x000A6A5F File Offset: 0x000A4C5F
		public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, IntPtr parentWindowHandle) : this(providerType, providerName, keyContainerName)
		{
			this.m_cryptoKeySecurity = cryptoKeySecurity;
			this.m_parentWindowHandle = parentWindowHandle;
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x000A6A7A File Offset: 0x000A4C7A
		internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
		{
			this.ProviderType = providerType;
			this.ProviderName = providerName;
			this.KeyContainerName = keyContainerName;
			this.KeyNumber = -1;
			this.Flags = flags;
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x000A6AA8 File Offset: 0x000A4CA8
		internal CspParameters(CspParameters parameters)
		{
			this.ProviderType = parameters.ProviderType;
			this.ProviderName = parameters.ProviderName;
			this.KeyContainerName = parameters.KeyContainerName;
			this.KeyNumber = parameters.KeyNumber;
			this.Flags = parameters.Flags;
			this.m_cryptoKeySecurity = parameters.m_cryptoKeySecurity;
			this.m_keyPassword = parameters.m_keyPassword;
			this.m_parentWindowHandle = parameters.m_parentWindowHandle;
		}

		/// <summary>Представляет код типа поставщика для <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
		// Token: 0x0400214F RID: 8527
		public int ProviderType;

		/// <summary>Представляет имя поставщика для <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
		// Token: 0x04002150 RID: 8528
		public string ProviderName;

		/// <summary>Представляет имя контейнера ключа для <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
		// Token: 0x04002151 RID: 8529
		public string KeyContainerName;

		/// <summary>Указывает, создан ли асимметричный ключ как ключ подписи или ключ обмена.</summary>
		// Token: 0x04002152 RID: 8530
		public int KeyNumber;

		// Token: 0x04002153 RID: 8531
		private int m_flags;

		// Token: 0x04002154 RID: 8532
		private CryptoKeySecurity m_cryptoKeySecurity;

		// Token: 0x04002155 RID: 8533
		private SecureString m_keyPassword;

		// Token: 0x04002156 RID: 8534
		private IntPtr m_parentWindowHandle;
	}
}
