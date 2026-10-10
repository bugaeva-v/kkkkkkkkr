using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Hosting;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Policy;
using Mono.Security;
using Unity;

namespace System
{
	/// <summary>Предоставляет сведения о привязке сборок, которые могут быть добавлены к экземпляру класса <see cref="T:System.AppDomain" />.</summary>
	// Token: 0x02000227 RID: 551
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class AppDomainSetup : IAppDomainSetup
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AppDomainSetup" />.</summary>
		// Token: 0x0600188C RID: 6284 RVA: 0x0000259F File Offset: 0x0000079F
		public AppDomainSetup()
		{
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0005D9A4 File Offset: 0x0005BBA4
		internal AppDomainSetup(AppDomainSetup setup)
		{
			this.application_base = setup.application_base;
			this.application_name = setup.application_name;
			this.cache_path = setup.cache_path;
			this.configuration_file = setup.configuration_file;
			this.dynamic_base = setup.dynamic_base;
			this.license_file = setup.license_file;
			this.private_bin_path = setup.private_bin_path;
			this.private_bin_path_probe = setup.private_bin_path_probe;
			this.shadow_copy_directories = setup.shadow_copy_directories;
			this.shadow_copy_files = setup.shadow_copy_files;
			this.publisher_policy = setup.publisher_policy;
			this.path_changed = setup.path_changed;
			this.loader_optimization = setup.loader_optimization;
			this.disallow_binding_redirects = setup.disallow_binding_redirects;
			this.disallow_code_downloads = setup.disallow_code_downloads;
			this._activationArguments = setup._activationArguments;
			this.domain_initializer = setup.domain_initializer;
			this.application_trust = setup.application_trust;
			this.domain_initializer_args = setup.domain_initializer_args;
			this.disallow_appbase_probe = setup.disallow_appbase_probe;
			this.configuration_bytes = setup.configuration_bytes;
			this.manager_assembly = setup.manager_assembly;
			this.manager_type = setup.manager_type;
			this.partial_visible_assemblies = setup.partial_visible_assemblies;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AppDomainSetup" /> заданными аргументами контекста активации, необходимыми для активации домена приложения на основе манифеста.</summary>
		/// <param name="activationArguments">Объект, определяющий сведения, необходимые для активации нового домена приложения на основе манифеста.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="activationArguments" /> — <see langword="null" />.</exception>
		// Token: 0x0600188E RID: 6286 RVA: 0x0005DAD7 File Offset: 0x0005BCD7
		public AppDomainSetup(ActivationArguments activationArguments)
		{
			this._activationArguments = activationArguments;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AppDomainSetup" /> заданным контекстом активации для использования при активации домена приложения на основе манифеста.</summary>
		/// <param name="activationContext">Контекст активации, который необходимо использовать для текущего домена приложения.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="activationContext" /> — <see langword="null" />.</exception>
		// Token: 0x0600188F RID: 6287 RVA: 0x0005DAE6 File Offset: 0x0005BCE6
		public AppDomainSetup(ActivationContext activationContext)
		{
			this._activationArguments = new ActivationArguments(activationContext);
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0005DAFC File Offset: 0x0005BCFC
		private static string GetAppBase(string appBase)
		{
			if (appBase == null)
			{
				return null;
			}
			if (appBase == "")
			{
				appBase = Path.DirectorySeparatorChar.ToString();
			}
			if (appBase.StartsWith("file://", StringComparison.OrdinalIgnoreCase))
			{
				appBase = new Uri(appBase).LocalPath;
				if (Path.DirectorySeparatorChar != '/')
				{
					appBase = appBase.Replace('/', Path.DirectorySeparatorChar);
				}
			}
			appBase = Path.GetFullPath(appBase);
			if (Path.DirectorySeparatorChar != '/')
			{
				bool flag = appBase.StartsWith("\\\\?\\", StringComparison.Ordinal);
				if (appBase.IndexOf(':', flag ? 6 : 2) != -1)
				{
					throw new NotSupportedException("The given path's format is not supported.");
				}
			}
			string directoryName = Path.GetDirectoryName(appBase);
			if (directoryName != null && directoryName.LastIndexOfAny(Path.GetInvalidPathChars()) >= 0)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid path characters in path: '{0}'"), appBase), "appBase");
			}
			string fileName = Path.GetFileName(appBase);
			if (fileName != null && fileName.LastIndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid filename characters in path: '{0}'"), appBase), "appBase");
			}
			return appBase;
		}

		/// <summary>Возвращает или задает имя каталога, содержащего приложение.</summary>
		/// <returns>Имя базовой папки приложения.</returns>
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x0005DBFC File Offset: 0x0005BDFC
		// (set) Token: 0x06001892 RID: 6290 RVA: 0x0005DC09 File Offset: 0x0005BE09
		public string ApplicationBase
		{
			[SecuritySafeCritical]
			get
			{
				return AppDomainSetup.GetAppBase(this.application_base);
			}
			set
			{
				this.application_base = value;
			}
		}

		/// <summary>Получает или задает имя приложения.</summary>
		/// <returns>Имя приложения.</returns>
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x0005DC12 File Offset: 0x0005BE12
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x0005DC1A File Offset: 0x0005BE1A
		public string ApplicationName
		{
			get
			{
				return this.application_name;
			}
			set
			{
				this.application_name = value;
			}
		}

		/// <summary>Возвращает или задает имя области, определенной для приложения, где создаются теневые копии файлов.</summary>
		/// <returns>Полный путь к каталогу и полное имя файла, соответствующие создаваемой теневой копии.</returns>
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x0005DC23 File Offset: 0x0005BE23
		// (set) Token: 0x06001896 RID: 6294 RVA: 0x0005DC2B File Offset: 0x0005BE2B
		public string CachePath
		{
			[SecuritySafeCritical]
			get
			{
				return this.cache_path;
			}
			set
			{
				this.cache_path = value;
			}
		}

		/// <summary>Возвращает или задает имя файла конфигурации для домена приложения.</summary>
		/// <returns>Имя файла конфигурации.</returns>
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x0005DC34 File Offset: 0x0005BE34
		// (set) Token: 0x06001898 RID: 6296 RVA: 0x0005DC83 File Offset: 0x0005BE83
		public string ConfigurationFile
		{
			[SecuritySafeCritical]
			get
			{
				if (this.configuration_file == null)
				{
					return null;
				}
				if (Path.IsPathRooted(this.configuration_file))
				{
					return this.configuration_file;
				}
				if (this.ApplicationBase == null)
				{
					throw new MemberAccessException("The ApplicationBase must be set before retrieving this property.");
				}
				return Path.Combine(this.ApplicationBase, this.configuration_file);
			}
			set
			{
				this.configuration_file = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, применяется ли к домену приложения раздел &lt;publisherPolicy&gt; файла конфигурации.</summary>
		/// <returns>Значение <see langword="true" />, если раздел <see langword="&lt;publisherPolicy&gt;" /> файла конфигурации для домена приложения игнорируется; значение <see langword="false" />, если объявленная политика издателя применяется.</returns>
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x0005DC8C File Offset: 0x0005BE8C
		// (set) Token: 0x0600189A RID: 6298 RVA: 0x0005DC94 File Offset: 0x0005BE94
		public bool DisallowPublisherPolicy
		{
			get
			{
				return this.publisher_policy;
			}
			set
			{
				this.publisher_policy = value;
			}
		}

		/// <summary>Возвращает или задает базовую папку, в которой находится папка для динамически создаваемых файлов.</summary>
		/// <returns>Каталог, в котором расположена папка <see cref="P:System.AppDomain.DynamicDirectory" />.  
		///
		///  Возвращаемое значение этого свойства отличается от присвоенного значения.</returns>
		/// <exception cref="T:System.MemberAccessException">Это свойство не может быть установлено, поскольку имя приложения в домене приложения равно <see langword="null" />.</exception>
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x0005DCA0 File Offset: 0x0005BEA0
		// (set) Token: 0x0600189C RID: 6300 RVA: 0x0005DCF0 File Offset: 0x0005BEF0
		public string DynamicBase
		{
			[SecuritySafeCritical]
			get
			{
				if (this.dynamic_base == null)
				{
					return null;
				}
				if (Path.IsPathRooted(this.dynamic_base))
				{
					return this.dynamic_base;
				}
				if (this.ApplicationBase == null)
				{
					throw new MemberAccessException("The ApplicationBase must be set before retrieving this property.");
				}
				return Path.Combine(this.ApplicationBase, this.dynamic_base);
			}
			[SecuritySafeCritical]
			set
			{
				if (this.application_name == null)
				{
					throw new MemberAccessException("ApplicationName must be set before the DynamicBase can be set.");
				}
				this.dynamic_base = Path.Combine(value, ((uint)this.application_name.GetHashCode()).ToString("x"));
			}
		}

		/// <summary>Возвращает или задает расположение файла лицензии, связанного с этим доменом.</summary>
		/// <returns>Имя и расположение файла лицензии.</returns>
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x0005DD34 File Offset: 0x0005BF34
		// (set) Token: 0x0600189E RID: 6302 RVA: 0x0005DD3C File Offset: 0x0005BF3C
		public string LicenseFile
		{
			[SecuritySafeCritical]
			get
			{
				return this.license_file;
			}
			set
			{
				this.license_file = value;
			}
		}

		/// <summary>Определяет политику оптимизации, используемую для загрузки исполняемого файла.</summary>
		/// <returns>Константа перечислимого типа, которая используется с атрибутом <see cref="T:System.LoaderOptimizationAttribute" />.</returns>
		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x0005DD45 File Offset: 0x0005BF45
		// (set) Token: 0x060018A0 RID: 6304 RVA: 0x0005DD4D File Offset: 0x0005BF4D
		[MonoLimitation("In Mono this is controlled by the --share-code flag")]
		public LoaderOptimization LoaderOptimization
		{
			get
			{
				return this.loader_optimization;
			}
			set
			{
				this.loader_optimization = value;
			}
		}

		/// <summary>Получает или задает отображаемое имя сборки, содержащей тип диспетчера доменов приложений для доменов приложений, созданных с помощью данного объекта <see cref="T:System.AppDomainSetup" />.</summary>
		/// <returns>Отображаемое имя сборки, содержащей <see cref="T:System.Type" /> диспетчера доменов приложений.</returns>
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x0005DD56 File Offset: 0x0005BF56
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x0005DD5E File Offset: 0x0005BF5E
		public string AppDomainManagerAssembly
		{
			get
			{
				return this.manager_assembly;
			}
			set
			{
				this.manager_assembly = value;
			}
		}

		/// <summary>Получает или задает полное имя типа, содержащего диспетчер доменов приложений для доменов приложений, созданных с помощью данного объекта <see cref="T:System.AppDomainSetup" />.</summary>
		/// <returns>Полное имя типа, включая пространство имен.</returns>
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0005DD67 File Offset: 0x0005BF67
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x0005DD6F File Offset: 0x0005BF6F
		public string AppDomainManagerType
		{
			get
			{
				return this.manager_type;
			}
			set
			{
				this.manager_type = value;
			}
		}

		/// <summary>Получает или задает список помеченных флагом <see cref="F:System.Security.PartialTrustVisibilityLevel.NotVisibleByDefault" /> сборок, которые видимы коду с частичным доверием в изолированном домене приложения.</summary>
		/// <returns>Массив частичных имен сборок, где каждое частичное имя состоит из простого имени сборки и открытого ключа.</returns>
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x0005DD78 File Offset: 0x0005BF78
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x0005DD80 File Offset: 0x0005BF80
		public string[] PartialTrustVisibleAssemblies
		{
			get
			{
				return this.partial_visible_assemblies;
			}
			set
			{
				if (value != null)
				{
					this.partial_visible_assemblies = (string[])value.Clone();
					Array.Sort<string>(this.partial_visible_assemblies, StringComparer.OrdinalIgnoreCase);
					return;
				}
				this.partial_visible_assemblies = null;
			}
		}

		/// <summary>Возвращает или задает список каталогов в базовой папке приложения, в которых выполняется поиск закрытых сборок.</summary>
		/// <returns>Список имен каталогов, разделенных точкой с запятой.</returns>
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x0005DDAE File Offset: 0x0005BFAE
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x0005DDB6 File Offset: 0x0005BFB6
		public string PrivateBinPath
		{
			[SecuritySafeCritical]
			get
			{
				return this.private_bin_path;
			}
			set
			{
				this.private_bin_path = value;
				this.path_changed = true;
			}
		}

		/// <summary>Возвращает или задает строковое значение, включающее <see cref="P:System.AppDomainSetup.ApplicationBase" /> в путь поиска для приложения или исключающее его из пути поиска для приложения, чтобы поиск выполнялся только в <see cref="P:System.AppDomainSetup.PrivateBinPath" />.</summary>
		/// <returns>Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для включения пути к базовой папке приложения при поиске сборок; любое непустое строковое значение для исключения пути. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x0005DDC6 File Offset: 0x0005BFC6
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x0005DDCE File Offset: 0x0005BFCE
		public string PrivateBinPathProbe
		{
			get
			{
				return this.private_bin_path_probe;
			}
			set
			{
				this.private_bin_path_probe = value;
				this.path_changed = true;
			}
		}

		/// <summary>Возвращает или задает имена каталогов, содержащих сборки, для которых будут созданы теневые копии.</summary>
		/// <returns>Список имен каталогов, разделенных точкой с запятой.</returns>
		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x0005DDDE File Offset: 0x0005BFDE
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x0005DDE6 File Offset: 0x0005BFE6
		public string ShadowCopyDirectories
		{
			[SecuritySafeCritical]
			get
			{
				return this.shadow_copy_directories;
			}
			set
			{
				this.shadow_copy_directories = value;
			}
		}

		/// <summary>Возвращает или задает строку, позволяющую определить, включено ли теневое копирование.</summary>
		/// <returns>Строковое значение true, свидетельствующее о том, что теневое копирование включено, или значение false, указывающее на то, что оно отключено.</returns>
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x0005DDEF File Offset: 0x0005BFEF
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x0005DDF7 File Offset: 0x0005BFF7
		public string ShadowCopyFiles
		{
			get
			{
				return this.shadow_copy_files;
			}
			set
			{
				this.shadow_copy_files = value;
			}
		}

		/// <summary>Получает или задает значение, определяющее, допускает ли домен приложения перенаправление привязки сборок.</summary>
		/// <returns>Значение <see langword="true" />, если перенаправление сборок запрещено; значение <see langword="false" />, если оно разрешено.</returns>
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x0005DE00 File Offset: 0x0005C000
		// (set) Token: 0x060018B0 RID: 6320 RVA: 0x0005DE08 File Offset: 0x0005C008
		public bool DisallowBindingRedirects
		{
			get
			{
				return this.disallow_binding_redirects;
			}
			set
			{
				this.disallow_binding_redirects = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, разрешена ли загрузка сборок для этого домена приложения по протоколу HTTP.</summary>
		/// <returns>Значение <see langword="true" />, если загрузка сборок по протоколу HTTP запрещена; значение <see langword="false" />, если она разрешена.</returns>
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x0005DE11 File Offset: 0x0005C011
		// (set) Token: 0x060018B2 RID: 6322 RVA: 0x0005DE19 File Offset: 0x0005C019
		public bool DisallowCodeDownload
		{
			get
			{
				return this.disallow_code_downloads;
			}
			set
			{
				this.disallow_code_downloads = value;
			}
		}

		/// <summary>Получает или задает строку, которая задает целевую версию и профиль .NET Framework для домена приложения, в формате, который может быть проанализирован конструктором <see cref="M:System.Runtime.Versioning.FrameworkName.#ctor(System.String)" />.</summary>
		/// <returns>Целевая версия и профиль платформы .NET Framework.</returns>
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x0005DE22 File Offset: 0x0005C022
		// (set) Token: 0x060018B4 RID: 6324 RVA: 0x0005DE2A File Offset: 0x0005C02A
		public string TargetFrameworkName { get; set; }

		/// <summary>Возвращает или задает данные об активации домена приложения.</summary>
		/// <returns>Объект, содержащий данные об активации домена приложения.</returns>
		/// <exception cref="T:System.InvalidOperationException">Этому свойству присваивается объект <see cref="T:System.Runtime.Hosting.ActivationArguments" />, удостоверение приложения которого не соответствует удостоверение приложения объекта <see cref="T:System.Security.Policy.ApplicationTrust" />, возвращенного свойством <see cref="P:System.AppDomainSetup.ApplicationTrust" />. Если свойство <see cref="P:System.AppDomainSetup.ApplicationTrust" /> имеет значение <see langword="null" />, исключение не выбрасывается.</exception>
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060018B5 RID: 6325 RVA: 0x0005DE33 File Offset: 0x0005C033
		// (set) Token: 0x060018B6 RID: 6326 RVA: 0x0005DE50 File Offset: 0x0005C050
		public ActivationArguments ActivationArguments
		{
			get
			{
				if (this._activationArguments != null)
				{
					return this._activationArguments;
				}
				this.DeserializeNonPrimitives();
				return this._activationArguments;
			}
			set
			{
				this._activationArguments = value;
			}
		}

		/// <summary>Возвращает или задает делегат <see cref="T:System.AppDomainInitializer" />, представляющий метод обратного вызова, вызываемый при инициализации домена приложения.</summary>
		/// <returns>Делегат, представляющий метод обратного вызова, вызываемый при инициализации домена приложения.</returns>
		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x0005DE59 File Offset: 0x0005C059
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x0005DE76 File Offset: 0x0005C076
		[MonoLimitation("it needs to be invoked within the created domain")]
		public AppDomainInitializer AppDomainInitializer
		{
			get
			{
				if (this.domain_initializer != null)
				{
					return this.domain_initializer;
				}
				this.DeserializeNonPrimitives();
				return this.domain_initializer;
			}
			set
			{
				this.domain_initializer = value;
			}
		}

		/// <summary>Возвращает или задает аргументы, передаваемые методу обратного вызова, представленному делегатом <see cref="T:System.AppDomainInitializer" />. Этот метод обратного вызова вызывается при инициализации домена приложения.</summary>
		/// <returns>Массив строк, передаваемый методу обратного вызова, представленному делегатом <see cref="T:System.AppDomainInitializer" />, когда метод обратного вызова вызывается при инициализации <see cref="T:System.AppDomain" />.</returns>
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0005DE7F File Offset: 0x0005C07F
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x0005DE87 File Offset: 0x0005C087
		[MonoLimitation("it needs to be used to invoke the initializer within the created domain")]
		public string[] AppDomainInitializerArguments
		{
			get
			{
				return this.domain_initializer_args;
			}
			set
			{
				this.domain_initializer_args = value;
			}
		}

		/// <summary>Возвращает или задает объект, содержащий сведения о безопасности и доверии.</summary>
		/// <returns>Объект, содержащий сведения о безопасности и доверии.</returns>
		/// <exception cref="T:System.InvalidOperationException">Этому свойству присваивается объект <see cref="T:System.Security.Policy.ApplicationTrust" />, удостоверение приложения которого не соответствует удостоверение приложения объекта <see cref="T:System.Runtime.Hosting.ActivationArguments" />, возвращенного свойством <see cref="P:System.AppDomainSetup.ActivationArguments" />. Если свойство <see cref="P:System.AppDomainSetup.ActivationArguments" /> имеет значение <see langword="null" />, исключение не вызывается.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойству присвоено значение <see langword="null" />.</exception>
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x0005DE90 File Offset: 0x0005C090
		// (set) Token: 0x060018BC RID: 6332 RVA: 0x0005DEC0 File Offset: 0x0005C0C0
		[MonoNotSupported("This property exists but not considered.")]
		public ApplicationTrust ApplicationTrust
		{
			get
			{
				if (this.application_trust != null)
				{
					return this.application_trust;
				}
				this.DeserializeNonPrimitives();
				if (this.application_trust == null)
				{
					this.application_trust = new ApplicationTrust();
				}
				return this.application_trust;
			}
			set
			{
				this.application_trust = value;
			}
		}

		/// <summary>Указывает, выполняется ли поиск загружаемых сборок в базовой папке приложения и в папке приватных двоичных файлов.</summary>
		/// <returns>Значение <see langword="true" />, если проверка не разрешена. В противном случае — значение <see langword="false" />. Значение по умолчанию: <see langword="false" />.</returns>
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x0005DEC9 File Offset: 0x0005C0C9
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x0005DED1 File Offset: 0x0005C0D1
		[MonoNotSupported("This property exists but not considered.")]
		public bool DisallowApplicationBaseProbing
		{
			get
			{
				return this.disallow_appbase_probe;
			}
			set
			{
				this.disallow_appbase_probe = value;
			}
		}

		/// <summary>Возвращает XML-данные конфигурации, заданные методом <see cref="M:System.AppDomainSetup.SetConfigurationBytes(System.Byte[])" />, который переопределяет XML-данные конфигурации приложения.</summary>
		/// <returns>Массив, содержащий XML-данные конфигурации, заданные с помощью метода <see cref="M:System.AppDomainSetup.SetConfigurationBytes(System.Byte[])" />, или <see langword="null" />, если метод <see cref="M:System.AppDomainSetup.SetConfigurationBytes(System.Byte[])" /> не вызывался.</returns>
		// Token: 0x060018BF RID: 6335 RVA: 0x0005DEDA File Offset: 0x0005C0DA
		[MonoNotSupported("This method exists but not considered.")]
		public byte[] GetConfigurationBytes()
		{
			if (this.configuration_bytes == null)
			{
				return null;
			}
			return this.configuration_bytes.Clone() as byte[];
		}

		/// <summary>Предоставляет XML-данные конфигурации для домена приложения, заменяя XML-данные конфигурации приложения.</summary>
		/// <param name="value">Массив, содержащий XML-данные конфигурации для домена приложения.</param>
		// Token: 0x060018C0 RID: 6336 RVA: 0x0005DEF6 File Offset: 0x0005C0F6
		[MonoNotSupported("This method exists but not considered.")]
		public void SetConfigurationBytes(byte[] value)
		{
			this.configuration_bytes = value;
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0005DF00 File Offset: 0x0005C100
		private void DeserializeNonPrimitives()
		{
			lock (this)
			{
				if (this.serialized_non_primitives != null)
				{
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					MemoryStream serializationStream = new MemoryStream(this.serialized_non_primitives);
					object[] array = (object[])binaryFormatter.Deserialize(serializationStream);
					this._activationArguments = (ActivationArguments)array[0];
					this.domain_initializer = (AppDomainInitializer)array[1];
					this.application_trust = (ApplicationTrust)array[2];
					this.serialized_non_primitives = null;
				}
			}
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0005DF90 File Offset: 0x0005C190
		internal void SerializeNonPrimitives()
		{
			object[] graph = new object[]
			{
				this._activationArguments,
				this.domain_initializer,
				this.application_trust
			};
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			MemoryStream memoryStream = new MemoryStream();
			binaryFormatter.Serialize(memoryStream, graph);
			this.serialized_non_primitives = memoryStream.ToArray();
		}

		/// <summary>Устанавливает заданные переключатели, благодаря чему домен приложения становится совместимым с предыдущими версиями платформы .NET Framework для указанных аспектов.</summary>
		/// <param name="switches">Перечислимый набор строковых значений, задающих переключатели совместимости, или значение <see langword="null" /> для стирания существующих переключателей совместимости.</param>
		// Token: 0x060018C3 RID: 6339 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[MonoTODO("not implemented, does not throw because it's used in testing moonlight")]
		public void SetCompatibilitySwitches(IEnumerable<string> switches)
		{
		}

		/// <summary>Возвращает или задает значение, указывающее, отключено ли кэширование интерфейсов для вызовов взаимодействия в домене приложения, так что QueryInterface выполняется для каждого вызова.</summary>
		/// <returns>
		///   <see langword="true" />, если кэширование интерфейсов отключено для вызовов взаимодействия в доменах приложения, созданных с текущим объектом <see cref="T:System.AppDomainSetup" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x0005DFE0 File Offset: 0x0005C1E0
		// (set) Token: 0x060018C5 RID: 6341 RVA: 0x000173AD File Offset: 0x000155AD
		public bool SandboxInterop
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>Предоставляет среду CLR с резервной реализацией функции сравнения строк.</summary>
		/// <param name="functionName">Имя переопределяемой функции сравнения строк.</param>
		/// <param name="functionVersion">Версия функции. Для .NET Framework 4.5 значение должно быть больше или равно 1.</param>
		/// <param name="functionPointer">Указатель на функцию, переопределяющую <paramref name="functionName" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="functionName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="functionVersion" /> не является значением, равным или большим 1.  
		/// -или- 
		///  <paramref name="functionPointer" /> — <see cref="F:System.IntPtr.Zero" />.</exception>
		// Token: 0x060018C6 RID: 6342 RVA: 0x000173AD File Offset: 0x000155AD
		[SecurityCritical]
		public void SetNativeFunction(string functionName, int functionVersion, IntPtr functionPointer)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040016BB RID: 5819
		private string application_base;

		// Token: 0x040016BC RID: 5820
		private string application_name;

		// Token: 0x040016BD RID: 5821
		private string cache_path;

		// Token: 0x040016BE RID: 5822
		private string configuration_file;

		// Token: 0x040016BF RID: 5823
		private string dynamic_base;

		// Token: 0x040016C0 RID: 5824
		private string license_file;

		// Token: 0x040016C1 RID: 5825
		private string private_bin_path;

		// Token: 0x040016C2 RID: 5826
		private string private_bin_path_probe;

		// Token: 0x040016C3 RID: 5827
		private string shadow_copy_directories;

		// Token: 0x040016C4 RID: 5828
		private string shadow_copy_files;

		// Token: 0x040016C5 RID: 5829
		private bool publisher_policy;

		// Token: 0x040016C6 RID: 5830
		private bool path_changed;

		// Token: 0x040016C7 RID: 5831
		private LoaderOptimization loader_optimization;

		// Token: 0x040016C8 RID: 5832
		private bool disallow_binding_redirects;

		// Token: 0x040016C9 RID: 5833
		private bool disallow_code_downloads;

		// Token: 0x040016CA RID: 5834
		private ActivationArguments _activationArguments;

		// Token: 0x040016CB RID: 5835
		private AppDomainInitializer domain_initializer;

		// Token: 0x040016CC RID: 5836
		[NonSerialized]
		private ApplicationTrust application_trust;

		// Token: 0x040016CD RID: 5837
		private string[] domain_initializer_args;

		// Token: 0x040016CE RID: 5838
		private bool disallow_appbase_probe;

		// Token: 0x040016CF RID: 5839
		private byte[] configuration_bytes;

		// Token: 0x040016D0 RID: 5840
		private byte[] serialized_non_primitives;

		// Token: 0x040016D1 RID: 5841
		private string manager_assembly;

		// Token: 0x040016D2 RID: 5842
		private string manager_type;

		// Token: 0x040016D3 RID: 5843
		private string[] partial_visible_assemblies;
	}
}
