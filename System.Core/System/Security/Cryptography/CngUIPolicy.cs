using System;
using System.Security.Permissions;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Инкапсулирует дополнительные параметры конфигурации для пользовательского интерфейса (UI), отображаемого криптографией следующего поколения (CNG) при доступе к защищенному ключу.
	///       </summary>
	// Token: 0x02000047 RID: 71
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class CngUIPolicy
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Security.Cryptography.CngUIPolicy" /> класса с помощью указанным уровнем защиты.
		///       </summary>
		/// <param name="protectionLevel">
		///           Побитовое сочетание значений перечисления, задающих уровень защиты.
		///         </param>
		// Token: 0x06000155 RID: 341 RVA: 0x000038A2 File Offset: 0x00001AA2
		public CngUIPolicy(CngUIProtectionLevels protectionLevel) : this(protectionLevel, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Security.Cryptography.CngUIPolicy" /> класса с помощью указанным уровнем защиты и понятное имя.
		///       </summary>
		/// <param name="protectionLevel">
		///           Побитовое сочетание значений перечисления, задающих уровень защиты.
		///         </param>
		/// <param name="friendlyName">
		///           Понятное имя для ключа, который используется в запросе пользовательского интерфейса.
		///            Укажите строку null, чтобы использовать имя по умолчанию.
		///         </param>
		// Token: 0x06000156 RID: 342 RVA: 0x000038AC File Offset: 0x00001AAC
		public CngUIPolicy(CngUIProtectionLevels protectionLevel, string friendlyName) : this(protectionLevel, friendlyName, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Security.Cryptography.CngUIPolicy" /> класса с помощью указанным уровнем защиты, понятное имя и описание.
		///       </summary>
		/// <param name="protectionLevel">
		///           Побитовое сочетание значений перечисления, задающих уровень защиты.
		///         </param>
		/// <param name="friendlyName">
		///           Понятное имя для ключа, который используется в запросе пользовательского интерфейса.
		///            Укажите строку null, чтобы использовать имя по умолчанию.
		///         </param>
		/// <param name="description">
		///           Описание полнотекстового ключа.
		///            Укажите строку null, чтобы использовать описание по умолчанию.
		///         </param>
		// Token: 0x06000157 RID: 343 RVA: 0x000038B7 File Offset: 0x00001AB7
		public CngUIPolicy(CngUIProtectionLevels protectionLevel, string friendlyName, string description) : this(protectionLevel, friendlyName, description, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Security.Cryptography.CngUIPolicy" /> класса с помощью указанным уровнем защиты, понятное имя, строку описания и контекст.
		///       </summary>
		/// <param name="protectionLevel">
		///           Побитовое сочетание значений перечисления, задающих уровень защиты.
		///         </param>
		/// <param name="friendlyName">
		///           Понятное имя для ключа, который используется в запросе пользовательского интерфейса.
		///            Укажите строку null, чтобы использовать имя по умолчанию.
		///         </param>
		/// <param name="description">
		///           Описание полнотекстового ключа.
		///            Укажите строку null, чтобы использовать описание по умолчанию.
		///         </param>
		/// <param name="useContext">
		///           Описание использования ключа.
		///            Укажите строку null, чтобы использовать описание по умолчанию.
		///         </param>
		// Token: 0x06000158 RID: 344 RVA: 0x000038C3 File Offset: 0x00001AC3
		public CngUIPolicy(CngUIProtectionLevels protectionLevel, string friendlyName, string description, string useContext) : this(protectionLevel, friendlyName, description, useContext, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Security.Cryptography.CngUIPolicy" /> класса с помощью указанным уровнем защиты, понятное имя, строку описания, используйте контекста и title.
		///       </summary>
		/// <param name="protectionLevel">
		///           Побитовое сочетание значений перечисления, задающих уровень защиты.
		///         </param>
		/// <param name="friendlyName">
		///           Понятное имя для ключа, который используется в запросе пользовательского интерфейса.
		///            Укажите строку null, чтобы использовать имя по умолчанию.
		///         </param>
		/// <param name="description">
		///           Описание полнотекстового ключа.
		///            Укажите строку null, чтобы использовать описание по умолчанию.
		///         </param>
		/// <param name="useContext">
		///           Описание использования ключа.
		///            Укажите строку null, чтобы использовать описание по умолчанию.
		///         </param>
		/// <param name="creationTitle">
		///           Название диалоговом окне отображается запрос пользовательского интерфейса.
		///            Укажите строку null, чтобы использовать заголовок по умолчанию.
		///         </param>
		// Token: 0x06000159 RID: 345 RVA: 0x000038D1 File Offset: 0x00001AD1
		public CngUIPolicy(CngUIProtectionLevels protectionLevel, string friendlyName, string description, string useContext, string creationTitle)
		{
			this.m_creationTitle = creationTitle;
			this.m_description = description;
			this.m_friendlyName = friendlyName;
			this.m_protectionLevel = protectionLevel;
			this.m_useContext = useContext;
		}

		/// <summary>
		///         Возвращает заголовок, отображаемый в пользовательском Интерфейсе подсказки.
		///       </summary>
		/// <returns>
		///         Заголовок диалогового окна, которое появляется при доступе к ключу.
		///       </returns>
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000038FE File Offset: 0x00001AFE
		public string CreationTitle
		{
			get
			{
				return this.m_creationTitle;
			}
		}

		/// <summary>
		///         Получает строку описания, которая отображается в пользовательском Интерфейсе в запросе.
		///       </summary>
		/// <returns>
		///         Текст описания для диалогового окна, которое появляется при доступе к ключу.
		///       </returns>
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00003906 File Offset: 0x00001B06
		public string Description
		{
			get
			{
				return this.m_description;
			}
		}

		/// <summary>
		///         Возвращает понятное имя, которое отображается в пользовательском Интерфейсе подсказки.
		///       </summary>
		/// <returns>
		///         Понятное имя, которое используется для описания ключа в диалоговом окне, которое появляется при доступе к ключу.
		///       </returns>
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000390E File Offset: 0x00001B0E
		public string FriendlyName
		{
			get
			{
				return this.m_friendlyName;
			}
		}

		/// <summary>
		///         Возвращает уровень защиты пользовательского интерфейса для ключа.
		///       </summary>
		/// <returns>
		///         Объект, описывающий уровень защиты пользовательского интерфейса для применения к ключу.
		///       </returns>
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00003916 File Offset: 0x00001B16
		public CngUIProtectionLevels ProtectionLevel
		{
			get
			{
				return this.m_protectionLevel;
			}
		}

		/// <summary>
		///         Возвращает описание использования ключа.
		///       </summary>
		/// <returns>
		///         Описание использования ключа.
		///       </returns>
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0000391E File Offset: 0x00001B1E
		public string UseContext
		{
			get
			{
				return this.m_useContext;
			}
		}

		// Token: 0x04000324 RID: 804
		private string m_creationTitle;

		// Token: 0x04000325 RID: 805
		private string m_description;

		// Token: 0x04000326 RID: 806
		private string m_friendlyName;

		// Token: 0x04000327 RID: 807
		private CngUIProtectionLevels m_protectionLevel;

		// Token: 0x04000328 RID: 808
		private string m_useContext;
	}
}
