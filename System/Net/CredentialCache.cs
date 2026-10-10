using System;
using System.Collections;

namespace System.Net
{
	/// <summary>Предоставляет хранилище для множества учетных данных.</summary>
	// Token: 0x020005C5 RID: 1477
	public class CredentialCache : ICredentials, ICredentialsByHost, IEnumerable
	{
		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002FE2 RID: 12258 RVA: 0x000A52CA File Offset: 0x000A34CA
		internal bool IsDefaultInCache
		{
			get
			{
				return this.m_NumbDefaultCredInCache != 0;
			}
		}

		/// <summary>Добавляет экземпляр <see cref="T:System.Net.NetworkCredential" /> в кэш учетных данных для использования с протоколами, отличными от SMTP, и связывает его с префиксом URI и протоколом проверки подлинности.</summary>
		/// <param name="uriPrefix">Параметр <see cref="T:System.Uri" />, определяющий префикс URI ресурсов, к которым предоставляется доступ посредством учетных данных.</param>
		/// <param name="authType">Схема проверки подлинности, которая используется ресурсом, названным в <paramref name="uriPrefix" />.</param>
		/// <param name="cred">Экземпляр <see cref="T:System.Net.NetworkCredential" />, добавляемый в кэш учетных данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="uriPrefix" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="authType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Те же учетные данные добавляются несколько раз.</exception>
		// Token: 0x06002FE4 RID: 12260 RVA: 0x000A52F4 File Offset: 0x000A34F4
		public void Add(Uri uriPrefix, string authType, NetworkCredential cred)
		{
			if (uriPrefix == null)
			{
				throw new ArgumentNullException("uriPrefix");
			}
			if (authType == null)
			{
				throw new ArgumentNullException("authType");
			}
			if (cred is SystemNetworkCredential)
			{
				throw new ArgumentException(SR.GetString("Default credentials cannot be supplied for the {0} authentication scheme.", new object[]
				{
					authType
				}), "authType");
			}
			this.m_version++;
			CredentialKey key = new CredentialKey(uriPrefix, authType);
			this.cache.Add(key, cred);
			if (cred is SystemNetworkCredential)
			{
				this.m_NumbDefaultCredInCache++;
			}
		}

		/// <summary>Добавляет экземпляр <see cref="T:System.Net.NetworkCredential" /> для использования вместе с SMTP в кэш учетных данных и связывает этот экземпляр с узлом, портом и протоколом проверки подлинности. Учетные данные, добавленные с помощью этого метода, допустимы только для SMTP. Этот метод не работает с запросами HTTP или FTP.</summary>
		/// <param name="host">Объект <see cref="T:System.String" />, определяющий компьютер.</param>
		/// <param name="port">Значение <see cref="T:System.Int32" />, которое обозначает порт, через который следует подключаться к <paramref name="host" />.</param>
		/// <param name="authenticationType">Строка <see cref="T:System.String" />, указывающая схему проверку подлинности, используемую при подключении к <paramref name="host" /> с использованием <paramref name="cred" />.</param>
		/// <param name="credential">Экземпляр <see cref="T:System.Net.NetworkCredential" />, добавляемый в кэш учетных данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="host" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="authType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="authType" /> не является приемлемым значением.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="port" /> меньше нуля.</exception>
		// Token: 0x06002FE5 RID: 12261 RVA: 0x000A5384 File Offset: 0x000A3584
		public void Add(string host, int port, string authenticationType, NetworkCredential credential)
		{
			if (host == null)
			{
				throw new ArgumentNullException("host");
			}
			if (authenticationType == null)
			{
				throw new ArgumentNullException("authenticationType");
			}
			if (host.Length == 0)
			{
				throw new ArgumentException(SR.GetString("The parameter '{0}' cannot be an empty string.", new object[]
				{
					"host"
				}));
			}
			if (port < 0)
			{
				throw new ArgumentOutOfRangeException("port");
			}
			if (credential is SystemNetworkCredential)
			{
				throw new ArgumentException(SR.GetString("Default credentials cannot be supplied for the {0} authentication scheme.", new object[]
				{
					authenticationType
				}), "authenticationType");
			}
			this.m_version++;
			CredentialHostKey key = new CredentialHostKey(host, port, authenticationType);
			this.cacheForHosts.Add(key, credential);
			if (credential is SystemNetworkCredential)
			{
				this.m_NumbDefaultCredInCache++;
			}
		}

		/// <summary>Удаляет экземпляр <see cref="T:System.Net.NetworkCredential" /> из кэша, если он связан с указанным префиксом URI и протоколом проверки подлинности.</summary>
		/// <param name="uriPrefix">Параметр <see cref="T:System.Uri" />, определяющий префикс URI ресурсов, для доступа к которым используются учетные данные.</param>
		/// <param name="authType">Схема проверки подлинности, которая используется узелом, названным в <paramref name="uriPrefix" />.</param>
		// Token: 0x06002FE6 RID: 12262 RVA: 0x000A5448 File Offset: 0x000A3648
		public void Remove(Uri uriPrefix, string authType)
		{
			if (uriPrefix == null || authType == null)
			{
				return;
			}
			this.m_version++;
			CredentialKey key = new CredentialKey(uriPrefix, authType);
			if (this.cache[key] is SystemNetworkCredential)
			{
				this.m_NumbDefaultCredInCache--;
			}
			this.cache.Remove(key);
		}

		/// <summary>Удаляет экземпляр <see cref="T:System.Net.NetworkCredential" /> из кэша, если он связан с указанным узлом, портом и протоколом проверки подлинности.</summary>
		/// <param name="host">Объект <see cref="T:System.String" />, определяющий компьютер.</param>
		/// <param name="port">Значение <see cref="T:System.Int32" />, которое обозначает порт, через который следует подключаться к <paramref name="host" />.</param>
		/// <param name="authenticationType">Строка <see cref="T:System.String" />, указывающая схему проверку подлинности, используемую при подключении к <paramref name="host" />.</param>
		// Token: 0x06002FE7 RID: 12263 RVA: 0x000A54A8 File Offset: 0x000A36A8
		public void Remove(string host, int port, string authenticationType)
		{
			if (host == null || authenticationType == null)
			{
				return;
			}
			if (port < 0)
			{
				return;
			}
			this.m_version++;
			CredentialHostKey key = new CredentialHostKey(host, port, authenticationType);
			if (this.cacheForHosts[key] is SystemNetworkCredential)
			{
				this.m_NumbDefaultCredInCache--;
			}
			this.cacheForHosts.Remove(key);
		}

		/// <summary>Возвращает экземпляр <see cref="T:System.Net.NetworkCredential" />, связанный с указанным URI или узлом, а также с типом проверки подлинности.</summary>
		/// <param name="uriPrefix">Параметр <see cref="T:System.Uri" />, определяющий префикс URI ресурсов, к которым предоставляется доступ посредством учетных данных.</param>
		/// <param name="authType">Схема проверки подлинности, которая используется ресурсом, названным в <paramref name="uriPrefix" />.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.NetworkCredential" /> или, если в кэше нет соответствующих учетных данных, — <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="uriPrefix" /> или <paramref name="authType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002FE8 RID: 12264 RVA: 0x000A5508 File Offset: 0x000A3708
		public NetworkCredential GetCredential(Uri uriPrefix, string authType)
		{
			if (uriPrefix == null)
			{
				throw new ArgumentNullException("uriPrefix");
			}
			if (authType == null)
			{
				throw new ArgumentNullException("authType");
			}
			int num = -1;
			NetworkCredential result = null;
			IDictionaryEnumerator enumerator = this.cache.GetEnumerator();
			while (enumerator.MoveNext())
			{
				CredentialKey credentialKey = (CredentialKey)enumerator.Key;
				if (credentialKey.Match(uriPrefix, authType))
				{
					int uriPrefixLength = credentialKey.UriPrefixLength;
					if (uriPrefixLength > num)
					{
						num = uriPrefixLength;
						result = (NetworkCredential)enumerator.Value;
					}
				}
			}
			return result;
		}

		/// <summary>Возвращает экземпляр <see cref="T:System.Net.NetworkCredential" />, связанный с заданными узлом, портом и протоколом проверки подлинности.</summary>
		/// <param name="host">Объект <see cref="T:System.String" />, определяющий компьютер.</param>
		/// <param name="port">Значение <see cref="T:System.Int32" />, которое обозначает порт, через который следует подключаться к <paramref name="host" />.</param>
		/// <param name="authenticationType">Строка <see cref="T:System.String" />, указывающая схему проверку подлинности, используемую при подключении к <paramref name="host" />.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.NetworkCredential" /> или, если в кэше нет соответствующих учетных данных, — <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="host" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="authType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="authType" /> не является приемлемым значением.  
		///
		/// или - 
		/// Параметр <paramref name="host" /> равен пустой строке ("").</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="port" /> меньше нуля.</exception>
		// Token: 0x06002FE9 RID: 12265 RVA: 0x000A5584 File Offset: 0x000A3784
		public NetworkCredential GetCredential(string host, int port, string authenticationType)
		{
			if (host == null)
			{
				throw new ArgumentNullException("host");
			}
			if (authenticationType == null)
			{
				throw new ArgumentNullException("authenticationType");
			}
			if (host.Length == 0)
			{
				throw new ArgumentException(SR.GetString("The parameter '{0}' cannot be an empty string.", new object[]
				{
					"host"
				}));
			}
			if (port < 0)
			{
				throw new ArgumentOutOfRangeException("port");
			}
			NetworkCredential result = null;
			IDictionaryEnumerator enumerator = this.cacheForHosts.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (((CredentialHostKey)enumerator.Key).Match(host, port, authenticationType))
				{
					result = (NetworkCredential)enumerator.Value;
				}
			}
			return result;
		}

		/// <summary>Возвращает перечислитель, с помощью которого можно выполнять итерацию элементов экземпляра <see cref="T:System.Net.CredentialCache" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Net.CredentialCache" />.</returns>
		// Token: 0x06002FEA RID: 12266 RVA: 0x000A561C File Offset: 0x000A381C
		public IEnumerator GetEnumerator()
		{
			return new CredentialCache.CredentialEnumerator(this, this.cache, this.cacheForHosts, this.m_version);
		}

		/// <summary>Возвращает системные учетные данные приложения.</summary>
		/// <returns>Значение <see cref="T:System.Net.ICredentials" />, которое представляет системные учетные данные приложения.</returns>
		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06002FEB RID: 12267 RVA: 0x000A5636 File Offset: 0x000A3836
		public static ICredentials DefaultCredentials
		{
			get
			{
				return SystemNetworkCredential.defaultCredential;
			}
		}

		/// <summary>Возвращает сетевые учетные данные текущего контекста безопасности.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkCredential" />, представляющий сетевые учетные данные текущего пользователя или приложения.</returns>
		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06002FEC RID: 12268 RVA: 0x000A5636 File Offset: 0x000A3836
		public static NetworkCredential DefaultNetworkCredentials
		{
			get
			{
				return SystemNetworkCredential.defaultCredential;
			}
		}

		// Token: 0x04001A61 RID: 6753
		private Hashtable cache = new Hashtable();

		// Token: 0x04001A62 RID: 6754
		private Hashtable cacheForHosts = new Hashtable();

		// Token: 0x04001A63 RID: 6755
		internal int m_version;

		// Token: 0x04001A64 RID: 6756
		private int m_NumbDefaultCredInCache;

		// Token: 0x020005C6 RID: 1478
		private class CredentialEnumerator : IEnumerator
		{
			// Token: 0x06002FED RID: 12269 RVA: 0x000A5640 File Offset: 0x000A3840
			internal CredentialEnumerator(CredentialCache cache, Hashtable table, Hashtable hostTable, int version)
			{
				this.m_cache = cache;
				this.m_array = new ICredentials[table.Count + hostTable.Count];
				table.Values.CopyTo(this.m_array, 0);
				hostTable.Values.CopyTo(this.m_array, table.Count);
				this.m_version = version;
			}

			// Token: 0x17000997 RID: 2455
			// (get) Token: 0x06002FEE RID: 12270 RVA: 0x000A56AC File Offset: 0x000A38AC
			object IEnumerator.Current
			{
				get
				{
					if (this.m_index < 0 || this.m_index >= this.m_array.Length)
					{
						throw new InvalidOperationException(SR.GetString("Enumeration has either not started or has already finished."));
					}
					if (this.m_version != this.m_cache.m_version)
					{
						throw new InvalidOperationException(SR.GetString("Collection was modified; enumeration operation may not execute."));
					}
					return this.m_array[this.m_index];
				}
			}

			// Token: 0x06002FEF RID: 12271 RVA: 0x000A5714 File Offset: 0x000A3914
			bool IEnumerator.MoveNext()
			{
				if (this.m_version != this.m_cache.m_version)
				{
					throw new InvalidOperationException(SR.GetString("Collection was modified; enumeration operation may not execute."));
				}
				int num = this.m_index + 1;
				this.m_index = num;
				if (num < this.m_array.Length)
				{
					return true;
				}
				this.m_index = this.m_array.Length;
				return false;
			}

			// Token: 0x06002FF0 RID: 12272 RVA: 0x000A5770 File Offset: 0x000A3970
			void IEnumerator.Reset()
			{
				this.m_index = -1;
			}

			// Token: 0x04001A65 RID: 6757
			private CredentialCache m_cache;

			// Token: 0x04001A66 RID: 6758
			private ICredentials[] m_array;

			// Token: 0x04001A67 RID: 6759
			private int m_index = -1;

			// Token: 0x04001A68 RID: 6760
			private int m_version;
		}
	}
}
