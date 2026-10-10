using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace System.Security.Permissions
{
	/// <summary>Указывает права доступа для конкретных контейнеров ключей. Этот класс не наследуется.</summary>
	// Token: 0x02000446 RID: 1094
	[ComVisible(true)]
	[Serializable]
	public sealed class KeyContainerPermissionAccessEntry
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> с использованием указанных параметров поставщика служб шифрования (CSP) и прав доступа.</summary>
		/// <param name="parameters">Объект <see cref="T:System.Security.Cryptography.CspParameters" />, содержащий параметры поставщика служб шифрования (CSP).</param>
		/// <param name="flags">Поразрядное сочетание значений <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" />.</param>
		/// <exception cref="T:System.ArgumentException">Результирующая запись будет обладать неограниченными правами доступа.</exception>
		// Token: 0x06002C59 RID: 11353 RVA: 0x0009F878 File Offset: 0x0009DA78
		public KeyContainerPermissionAccessEntry(CspParameters parameters, KeyContainerPermissionFlags flags)
		{
			if (parameters == null)
			{
				throw new ArgumentNullException("parameters");
			}
			this.ProviderName = parameters.ProviderName;
			this.ProviderType = parameters.ProviderType;
			this.KeyContainerName = parameters.KeyContainerName;
			this.KeySpec = parameters.KeyNumber;
			this.Flags = flags;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> с использованием указанного имени контейнера и прав доступа.</summary>
		/// <param name="keyContainerName">Имя контейнера ключа.</param>
		/// <param name="flags">Поразрядное сочетание значений <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" />.</param>
		/// <exception cref="T:System.ArgumentException">Результирующая запись будет обладать неограниченными правами доступа.</exception>
		// Token: 0x06002C5A RID: 11354 RVA: 0x0009F8D0 File Offset: 0x0009DAD0
		public KeyContainerPermissionAccessEntry(string keyContainerName, KeyContainerPermissionFlags flags)
		{
			this.KeyContainerName = keyContainerName;
			this.Flags = flags;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> с использованием заданных значений свойств.</summary>
		/// <param name="keyStore">Имя хранилища ключей.</param>
		/// <param name="providerName">Имя поставщика.</param>
		/// <param name="providerType">Типовой код для поставщика. Сведения о значениях см. в описании свойства <see cref="P:System.Security.Permissions.KeyContainerPermissionAccessEntry.ProviderType" />.</param>
		/// <param name="keyContainerName">Имя контейнера ключа.</param>
		/// <param name="keySpec">Спецификация ключа. Сведения о значениях см. в описании свойства <see cref="P:System.Security.Permissions.KeyContainerPermissionAccessEntry.KeySpec" />.</param>
		/// <param name="flags">Поразрядное сочетание значений <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" />.</param>
		/// <exception cref="T:System.ArgumentException">Результирующая запись будет обладать неограниченными правами доступа.</exception>
		// Token: 0x06002C5B RID: 11355 RVA: 0x0009F8E6 File Offset: 0x0009DAE6
		public KeyContainerPermissionAccessEntry(string keyStore, string providerName, int providerType, string keyContainerName, int keySpec, KeyContainerPermissionFlags flags)
		{
			this.KeyStore = keyStore;
			this.ProviderName = providerName;
			this.ProviderType = providerType;
			this.KeyContainerName = keyContainerName;
			this.KeySpec = keySpec;
			this.Flags = flags;
		}

		/// <summary>Получает или задает разрешения контейнера ключа.</summary>
		/// <returns>Поразрядное сочетание значений <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" />. Значение по умолчанию: <see cref="F:System.Security.Permissions.KeyContainerPermissionFlags.NoFlags" />.</returns>
		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x0009F91B File Offset: 0x0009DB1B
		// (set) Token: 0x06002C5D RID: 11357 RVA: 0x0009F923 File Offset: 0x0009DB23
		public KeyContainerPermissionFlags Flags
		{
			get
			{
				return this._flags;
			}
			set
			{
				if ((value & KeyContainerPermissionFlags.AllFlags) != KeyContainerPermissionFlags.NoFlags)
				{
					throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}"), value), "KeyContainerPermissionFlags");
				}
				this._flags = value;
			}
		}

		/// <summary>Получает или задает имя контейнера ключа.</summary>
		/// <returns>Имя контейнера ключа.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующая запись будет обладать неограниченными правами доступа.</exception>
		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x0009F955 File Offset: 0x0009DB55
		// (set) Token: 0x06002C5F RID: 11359 RVA: 0x0009F95D File Offset: 0x0009DB5D
		public string KeyContainerName
		{
			get
			{
				return this._containerName;
			}
			set
			{
				this._containerName = value;
			}
		}

		/// <summary>Получает или задает спецификацию ключа.</summary>
		/// <returns>Одно из значений AT_, определенное в файле заголовка Wincrypt.h.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующая запись будет обладать неограниченными правами доступа.</exception>
		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x0009F966 File Offset: 0x0009DB66
		// (set) Token: 0x06002C61 RID: 11361 RVA: 0x0009F96E File Offset: 0x0009DB6E
		public int KeySpec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}

		/// <summary>Получает или задает имя хранилища ключей.</summary>
		/// <returns>Имя хранилища ключей.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующая запись будет обладать неограниченными правами доступа.</exception>
		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x0009F977 File Offset: 0x0009DB77
		// (set) Token: 0x06002C63 RID: 11363 RVA: 0x0009F97F File Offset: 0x0009DB7F
		public string KeyStore
		{
			get
			{
				return this._store;
			}
			set
			{
				this._store = value;
			}
		}

		/// <summary>Получает или задает имя поставщика.</summary>
		/// <returns>Имя поставщика.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующая запись будет обладать неограниченными правами доступа.</exception>
		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x0009F988 File Offset: 0x0009DB88
		// (set) Token: 0x06002C65 RID: 11365 RVA: 0x0009F990 File Offset: 0x0009DB90
		public string ProviderName
		{
			get
			{
				return this._providerName;
			}
			set
			{
				this._providerName = value;
			}
		}

		/// <summary>Получает или задает тип поставщика.</summary>
		/// <returns>Одно из значений PROV_, определенное в файле заголовка Wincrypt.h.</returns>
		/// <exception cref="T:System.ArgumentException">Результирующая запись будет обладать неограниченными правами доступа.</exception>
		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x0009F999 File Offset: 0x0009DB99
		// (set) Token: 0x06002C67 RID: 11367 RVA: 0x0009F9A1 File Offset: 0x0009DBA1
		public int ProviderType
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}

		/// <summary>Определяет, идентичен ли указанный объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> текущему экземпляру.</summary>
		/// <param name="o">Объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> равен текущему объекту <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002C68 RID: 11368 RVA: 0x0009F9AC File Offset: 0x0009DBAC
		public override bool Equals(object o)
		{
			if (o == null)
			{
				return false;
			}
			KeyContainerPermissionAccessEntry keyContainerPermissionAccessEntry = o as KeyContainerPermissionAccessEntry;
			return keyContainerPermissionAccessEntry != null && this._flags == keyContainerPermissionAccessEntry._flags && !(this._containerName != keyContainerPermissionAccessEntry._containerName) && !(this._store != keyContainerPermissionAccessEntry._store) && !(this._providerName != keyContainerPermissionAccessEntry._providerName) && this._type == keyContainerPermissionAccessEntry._type;
		}

		/// <summary>Получает хэш-код текущего экземпляра для использования в алгоритмах и структурах данных хэширования, например в хэш-таблице.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" />.</returns>
		// Token: 0x06002C69 RID: 11369 RVA: 0x0009FA2C File Offset: 0x0009DC2C
		public override int GetHashCode()
		{
			int num = this._type ^ this._spec ^ (int)this._flags;
			if (this._containerName != null)
			{
				num ^= this._containerName.GetHashCode();
			}
			if (this._store != null)
			{
				num ^= this._store.GetHashCode();
			}
			if (this._providerName != null)
			{
				num ^= this._providerName.GetHashCode();
			}
			return num;
		}

		// Token: 0x0400204D RID: 8269
		private KeyContainerPermissionFlags _flags;

		// Token: 0x0400204E RID: 8270
		private string _containerName;

		// Token: 0x0400204F RID: 8271
		private int _spec;

		// Token: 0x04002050 RID: 8272
		private string _store;

		// Token: 0x04002051 RID: 8273
		private string _providerName;

		// Token: 0x04002052 RID: 8274
		private int _type;
	}
}
