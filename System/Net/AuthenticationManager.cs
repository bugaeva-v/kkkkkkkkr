using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Net.Configuration;

namespace System.Net
{
	/// <summary>Управляет модулями проверки подлинности, вызываемыми в процессе проверки подлинности учетных данных клиента.</summary>
	// Token: 0x02000669 RID: 1641
	public class AuthenticationManager
	{
		// Token: 0x060033C3 RID: 13251 RVA: 0x0000219B File Offset: 0x0000039B
		private AuthenticationManager()
		{
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x000B44E8 File Offset: 0x000B26E8
		private static void EnsureModules()
		{
			object obj = AuthenticationManager.locker;
			lock (obj)
			{
				if (AuthenticationManager.modules == null)
				{
					AuthenticationManager.modules = new ArrayList();
					AuthenticationModulesSection authenticationModulesSection = ConfigurationManager.GetSection("system.net/authenticationModules") as AuthenticationModulesSection;
					if (authenticationModulesSection != null)
					{
						foreach (object obj2 in authenticationModulesSection.AuthenticationModules)
						{
							AuthenticationModuleElement authenticationModuleElement = (AuthenticationModuleElement)obj2;
							IAuthenticationModule value = null;
							try
							{
								value = (IAuthenticationModule)Activator.CreateInstance(Type.GetType(authenticationModuleElement.Type, true));
							}
							catch
							{
							}
							AuthenticationManager.modules.Add(value);
						}
					}
				}
			}
		}

		/// <summary>Возвращает или задает политику учетных данных, которую следует использовать для запросов ресурсов, выполняемых с использованием класса <see cref="T:System.Net.HttpWebRequest" />.</summary>
		/// <returns>Объект, реализующий интерфейс <see cref="T:System.Net.ICredentialPolicy" />, который определяет, отправляются ли учетные данные вместе с запросами. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x000B45CC File Offset: 0x000B27CC
		// (set) Token: 0x060033C6 RID: 13254 RVA: 0x000B45D3 File Offset: 0x000B27D3
		public static ICredentialPolicy CredentialPolicy
		{
			get
			{
				return AuthenticationManager.credential_policy;
			}
			set
			{
				AuthenticationManager.credential_policy = value;
			}
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x0001FD2F File Offset: 0x0001DF2F
		private static Exception GetMustImplement()
		{
			return new NotImplementedException();
		}

		/// <summary>Возвращает словарь, содержащий имена участников-служб, которые используются для идентификации узлов во время проверки подлинности Kerberos для запросов, сделанных с использованием класса <see cref="T:System.Net.WebRequest" /> и его производных классов.</summary>
		/// <returns>Доступный для записи словарь <see cref="T:System.Collections.Specialized.StringDictionary" />, который содержит значения имен участников-служб для ключей, состоящих из сведений узла.</returns>
		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x060033C8 RID: 13256 RVA: 0x000B45DB File Offset: 0x000B27DB
		[MonoTODO]
		public static StringDictionary CustomTargetNameDictionary
		{
			get
			{
				throw AuthenticationManager.GetMustImplement();
			}
		}

		/// <summary>Возвращает список модулей проверки подлинности, зарегистрированных диспетчером проверки подлинности.</summary>
		/// <returns>Параметр <see cref="T:System.Collections.IEnumerator" />, который обеспечивает чтение зарегистрированных модулей проверки подлинности.</returns>
		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x060033C9 RID: 13257 RVA: 0x000B45E2 File Offset: 0x000B27E2
		public static IEnumerator RegisteredModules
		{
			get
			{
				AuthenticationManager.EnsureModules();
				return AuthenticationManager.modules.GetEnumerator();
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060033CA RID: 13258 RVA: 0x00003062 File Offset: 0x00001262
		[MonoTODO]
		internal static bool OSSupportsExtendedProtection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x000B45F4 File Offset: 0x000B27F4
		internal static void Clear()
		{
			AuthenticationManager.EnsureModules();
			ArrayList obj = AuthenticationManager.modules;
			lock (obj)
			{
				AuthenticationManager.modules.Clear();
			}
		}

		/// <summary>Вызывает все зарегистрированные модули проверки подлинности, чтобы найти модуль, который может ответить на запрос проверки подлинности.</summary>
		/// <param name="challenge">Запрос, возвращаемый интернет-ресурсом.</param>
		/// <param name="request">Компонент <see cref="T:System.Net.WebRequest" />, который инициировал запрос проверки подлинности.</param>
		/// <param name="credentials">Учетная запись <see cref="T:System.Net.ICredentials" />, связанная с этим запросом.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Net.Authorization" />, содержащий результат попытки авторизации. Если на запрос не отвечает ни один из модулей проверки подлинности, этот метод возвращает <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="challenge" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="request" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="credentials" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060033CC RID: 13260 RVA: 0x000B463C File Offset: 0x000B283C
		public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			if (request == null)
			{
				throw new ArgumentNullException("request");
			}
			if (credentials == null)
			{
				throw new ArgumentNullException("credentials");
			}
			if (challenge == null)
			{
				throw new ArgumentNullException("challenge");
			}
			return AuthenticationManager.DoAuthenticate(challenge, request, credentials);
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x000B4670 File Offset: 0x000B2870
		private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			AuthenticationManager.EnsureModules();
			ArrayList obj = AuthenticationManager.modules;
			lock (obj)
			{
				foreach (object obj2 in AuthenticationManager.modules)
				{
					IAuthenticationModule authenticationModule = (IAuthenticationModule)obj2;
					Authorization authorization = authenticationModule.Authenticate(challenge, request, credentials);
					if (authorization != null)
					{
						authorization.ModuleAuthenticationType = authenticationModule.AuthenticationType;
						return authorization;
					}
				}
			}
			return null;
		}

		/// <summary>Выполняет предварительную проверку подлинности запроса.</summary>
		/// <param name="request">Запрос <see cref="T:System.Net.WebRequest" /> интернет-ресурса.</param>
		/// <param name="credentials">Учетная запись <see cref="T:System.Net.ICredentials" />, связанная с запросом.</param>
		/// <returns>Если предварительная проверка подлинности запроса может быть выполнена, возвращается экземпляр класса <see cref="T:System.Net.Authorization" />; в противном случае возвращается <see langword="null" />. Если значением параметра <paramref name="credentials" /> является <see langword="null" />, метод возвращает <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="request" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060033CE RID: 13262 RVA: 0x000B4718 File Offset: 0x000B2918
		public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
		{
			if (request == null)
			{
				throw new ArgumentNullException("request");
			}
			if (credentials == null)
			{
				return null;
			}
			AuthenticationManager.EnsureModules();
			ArrayList obj = AuthenticationManager.modules;
			lock (obj)
			{
				foreach (object obj2 in AuthenticationManager.modules)
				{
					IAuthenticationModule authenticationModule = (IAuthenticationModule)obj2;
					Authorization authorization = authenticationModule.PreAuthenticate(request, credentials);
					if (authorization != null)
					{
						authorization.ModuleAuthenticationType = authenticationModule.AuthenticationType;
						return authorization;
					}
				}
			}
			return null;
		}

		/// <summary>Регистрация модуля проверки подлинности диспетчером проверки подлинности.</summary>
		/// <param name="authenticationModule">Модуль <see cref="T:System.Net.IAuthenticationModule" /> проверки подлинности, который должен регистрироваться диспетчером проверки подлинности.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="authenticationModule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060033CF RID: 13263 RVA: 0x000B47D0 File Offset: 0x000B29D0
		public static void Register(IAuthenticationModule authenticationModule)
		{
			if (authenticationModule == null)
			{
				throw new ArgumentNullException("authenticationModule");
			}
			AuthenticationManager.DoUnregister(authenticationModule.AuthenticationType, false);
			ArrayList obj = AuthenticationManager.modules;
			lock (obj)
			{
				AuthenticationManager.modules.Add(authenticationModule);
			}
		}

		/// <summary>Удаляет модуль проверки подлинности из списка зарегистрированных модулей.</summary>
		/// <param name="authenticationModule">Модуль <see cref="T:System.Net.IAuthenticationModule" /> проверки подлинности, удаляемый из списка зарегистрированных модулей.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="authenticationModule" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Заданный модуль <see cref="T:System.Net.IAuthenticationModule" /> проверки подлинности не зарегистрирован.</exception>
		// Token: 0x060033D0 RID: 13264 RVA: 0x000B4830 File Offset: 0x000B2A30
		public static void Unregister(IAuthenticationModule authenticationModule)
		{
			if (authenticationModule == null)
			{
				throw new ArgumentNullException("authenticationModule");
			}
			AuthenticationManager.DoUnregister(authenticationModule.AuthenticationType, true);
		}

		/// <summary>Удаляет модули проверки подлинности с указанной схемой проверки подлинности из списка зарегистрированных модулей.</summary>
		/// <param name="authenticationScheme">Схема проверки подлинности удаляемого модуля.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="authenticationScheme" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль для данной схемы проверки подлинности не зарегистрирован.</exception>
		// Token: 0x060033D1 RID: 13265 RVA: 0x000B484C File Offset: 0x000B2A4C
		public static void Unregister(string authenticationScheme)
		{
			if (authenticationScheme == null)
			{
				throw new ArgumentNullException("authenticationScheme");
			}
			AuthenticationManager.DoUnregister(authenticationScheme, true);
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x000B4864 File Offset: 0x000B2A64
		private static void DoUnregister(string authenticationScheme, bool throwEx)
		{
			AuthenticationManager.EnsureModules();
			ArrayList obj = AuthenticationManager.modules;
			lock (obj)
			{
				IAuthenticationModule authenticationModule = null;
				foreach (object obj2 in AuthenticationManager.modules)
				{
					IAuthenticationModule authenticationModule2 = (IAuthenticationModule)obj2;
					if (string.Compare(authenticationModule2.AuthenticationType, authenticationScheme, true) == 0)
					{
						authenticationModule = authenticationModule2;
						break;
					}
				}
				if (authenticationModule == null)
				{
					if (throwEx)
					{
						throw new InvalidOperationException("Scheme not registered.");
					}
				}
				else
				{
					AuthenticationManager.modules.Remove(authenticationModule);
				}
			}
		}

		// Token: 0x04001E5A RID: 7770
		private static ArrayList modules;

		// Token: 0x04001E5B RID: 7771
		private static object locker = new object();

		// Token: 0x04001E5C RID: 7772
		private static ICredentialPolicy credential_policy = null;
	}
}
