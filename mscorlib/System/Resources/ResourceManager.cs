using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading;

namespace System.Resources
{
	/// <summary>Представляет диспетчер ресурсов, обеспечивающий удобный доступ к ресурсам, связанным с языком и региональными параметрами, во время выполнения.</summary>
	// Token: 0x02000868 RID: 2152
	[ComVisible(true)]
	[Serializable]
	public class ResourceManager
	{
		// Token: 0x06004781 RID: 18305 RVA: 0x000E94C4 File Offset: 0x000E76C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			try
			{
				this.m_callingAssembly = (RuntimeAssembly)Assembly.GetCallingAssembly();
			}
			catch
			{
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.ResourceManager" /> со значениями по умолчанию.</summary>
		// Token: 0x06004782 RID: 18306 RVA: 0x000E94F8 File Offset: 0x000E76F8
		protected ResourceManager()
		{
			this.Init();
			this._lastUsedResourceCache = new ResourceManager.CultureNameResourceSetPair();
			ResourceManager.ResourceManagerMediator mediator = new ResourceManager.ResourceManagerMediator(this);
			this.resourceGroveler = new ManifestBasedResourceGroveler(mediator);
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x000E9530 File Offset: 0x000E7730
		private ResourceManager(string baseName, string resourceDir, Type usingResourceSet)
		{
			if (baseName == null)
			{
				throw new ArgumentNullException("baseName");
			}
			if (resourceDir == null)
			{
				throw new ArgumentNullException("resourceDir");
			}
			this.BaseNameField = baseName;
			this.moduleDir = resourceDir;
			this._userResourceSet = usingResourceSet;
			this.ResourceSets = new Hashtable();
			this._resourceSets = new Dictionary<string, ResourceSet>();
			this._lastUsedResourceCache = new ResourceManager.CultureNameResourceSetPair();
			this.UseManifest = false;
			ResourceManager.ResourceManagerMediator mediator = new ResourceManager.ResourceManagerMediator(this);
			this.resourceGroveler = new FileBasedResourceGroveler(mediator);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.ResourceManager" />, который ищет ресурсы, содержащиеся в файлах с указанным корневым именем, в данной сборке.</summary>
		/// <param name="baseName">Корневое имя файла ресурсов без расширения, но включающее какое-либо полное имя пространства имен. Например, имя корневой папки для файла ресурсов MyApplication.MyResource.en-US.resources будет MyApplication.MyResource.</param>
		/// <param name="assembly">Главная сборка для ресурсов.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="baseName" /> или параметра <paramref name="assembly" /> — <see langword="null" />.</exception>
		// Token: 0x06004784 RID: 18308 RVA: 0x000E95B0 File Offset: 0x000E77B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResourceManager(string baseName, Assembly assembly)
		{
			if (baseName == null)
			{
				throw new ArgumentNullException("baseName");
			}
			if (null == assembly)
			{
				throw new ArgumentNullException("assembly");
			}
			if (!(assembly is RuntimeAssembly))
			{
				throw new ArgumentException(Environment.GetResourceString("Assembly must be a runtime Assembly object."));
			}
			this.MainAssembly = assembly;
			this.BaseNameField = baseName;
			this.SetAppXConfiguration();
			this.CommonAssemblyInit();
			try
			{
				this.m_callingAssembly = (RuntimeAssembly)Assembly.GetCallingAssembly();
				if (assembly == typeof(object).Assembly && this.m_callingAssembly != assembly)
				{
					this.m_callingAssembly = null;
				}
			}
			catch
			{
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.ResourceManager" />, который использует указанный класс <see cref="T:System.Resources.ResourceSet" /> для поиска ресурсов, содержащихся в файлах с указанным корневым именем, в данной сборке.</summary>
		/// <param name="baseName">Корневое имя файла ресурсов без расширения, но включающее какое-либо полное имя пространства имен. Например, имя корневой папки для файла ресурсов MyApplication.MyResource.en-US.resources будет MyApplication.MyResource.</param>
		/// <param name="assembly">Главная сборка для ресурсов.</param>
		/// <param name="usingResourceSet">Тип пользовательского объекта <see cref="T:System.Resources.ResourceSet" /> для использования. При значении <see langword="null" /> используется объект времени выполнения по умолчанию <see cref="T:System.Resources.ResourceSet" />.</param>
		/// <exception cref="T:System.ArgumentException">Объект <paramref name="usingResourceset" /> не является производным от класса <see cref="T:System.Resources.ResourceSet" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="baseName" /> или параметра <paramref name="assembly" /> — <see langword="null" />.</exception>
		// Token: 0x06004785 RID: 18309 RVA: 0x000E9668 File Offset: 0x000E7868
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResourceManager(string baseName, Assembly assembly, Type usingResourceSet)
		{
			if (baseName == null)
			{
				throw new ArgumentNullException("baseName");
			}
			if (null == assembly)
			{
				throw new ArgumentNullException("assembly");
			}
			if (!(assembly is RuntimeAssembly))
			{
				throw new ArgumentException(Environment.GetResourceString("Assembly must be a runtime Assembly object."));
			}
			this.MainAssembly = assembly;
			this.BaseNameField = baseName;
			if (usingResourceSet != null && usingResourceSet != ResourceManager._minResourceSet && !usingResourceSet.IsSubclassOf(ResourceManager._minResourceSet))
			{
				throw new ArgumentException(Environment.GetResourceString("Type parameter must refer to a subclass of ResourceSet."), "usingResourceSet");
			}
			this._userResourceSet = usingResourceSet;
			this.CommonAssemblyInit();
			try
			{
				this.m_callingAssembly = (RuntimeAssembly)Assembly.GetCallingAssembly();
				if (assembly == typeof(object).Assembly && this.m_callingAssembly != assembly)
				{
					this.m_callingAssembly = null;
				}
			}
			catch
			{
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.ResourceManager" />, который ищет ресурсы в сопутствующих сборках, используя сведения из указанного объекта типа.</summary>
		/// <param name="resourceSource">Тип, из которого диспетчер ресурсов получает все сведения, необходимые для поиска RESOURCES-файлов.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="resourceSource" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004786 RID: 18310 RVA: 0x000E975C File Offset: 0x000E795C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResourceManager(Type resourceSource)
		{
			if (null == resourceSource)
			{
				throw new ArgumentNullException("resourceSource");
			}
			if (!(resourceSource is RuntimeType))
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a runtime Type object."));
			}
			this._locationInfo = resourceSource;
			this.MainAssembly = this._locationInfo.Assembly;
			this.BaseNameField = resourceSource.Name;
			this.SetAppXConfiguration();
			this.CommonAssemblyInit();
			try
			{
				this.m_callingAssembly = (RuntimeAssembly)Assembly.GetCallingAssembly();
				if (this.MainAssembly == typeof(object).Assembly && this.m_callingAssembly != this.MainAssembly)
				{
					this.m_callingAssembly = null;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x000E9828 File Offset: 0x000E7A28
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
			this._resourceSets = null;
			this.resourceGroveler = null;
			this._lastUsedResourceCache = null;
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x000E9840 File Offset: 0x000E7A40
		[SecuritySafeCritical]
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			this._resourceSets = new Dictionary<string, ResourceSet>();
			this._lastUsedResourceCache = new ResourceManager.CultureNameResourceSetPair();
			ResourceManager.ResourceManagerMediator mediator = new ResourceManager.ResourceManagerMediator(this);
			if (this.UseManifest)
			{
				this.resourceGroveler = new ManifestBasedResourceGroveler(mediator);
			}
			else
			{
				this.resourceGroveler = new FileBasedResourceGroveler(mediator);
			}
			if (this.m_callingAssembly == null)
			{
				this.m_callingAssembly = (RuntimeAssembly)this._callingAssembly;
			}
			if (this.UseManifest && this._neutralResourcesCulture == null)
			{
				this._neutralResourcesCulture = ManifestBasedResourceGroveler.GetNeutralResourcesLanguage(this.MainAssembly, ref this._fallbackLoc);
			}
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x000E98D2 File Offset: 0x000E7AD2
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			this._callingAssembly = this.m_callingAssembly;
			this.UseSatelliteAssem = this.UseManifest;
			this.ResourceSets = new Hashtable();
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x000E98F8 File Offset: 0x000E7AF8
		[SecuritySafeCritical]
		private void CommonAssemblyInit()
		{
			this.UseManifest = true;
			this._resourceSets = new Dictionary<string, ResourceSet>();
			this._lastUsedResourceCache = new ResourceManager.CultureNameResourceSetPair();
			this._fallbackLoc = UltimateResourceFallbackLocation.MainAssembly;
			ResourceManager.ResourceManagerMediator mediator = new ResourceManager.ResourceManagerMediator(this);
			this.resourceGroveler = new ManifestBasedResourceGroveler(mediator);
			this._neutralResourcesCulture = ManifestBasedResourceGroveler.GetNeutralResourcesLanguage(this.MainAssembly, ref this._fallbackLoc);
			this.ResourceSets = new Hashtable();
		}

		/// <summary>Возвращает имя корневой папки файлов ресурсов, в которой класс <see cref="T:System.Resources.ResourceManager" /> ищет ресурсы.</summary>
		/// <returns>Имя корневой папки файлов ресурсов, в которой класс <see cref="T:System.Resources.ResourceManager" /> ищет ресурсы.</returns>
		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x0600478B RID: 18315 RVA: 0x000E995E File Offset: 0x000E7B5E
		public virtual string BaseName
		{
			get
			{
				return this.BaseNameField;
			}
		}

		/// <summary>Возвращает или задает значение, которое указывает, позволяет ли диспетчер ресурсов выполнять поиск ресурсов с учетом регистра в методах <see cref="M:System.Resources.ResourceManager.GetString(System.String)" /> и <see cref="M:System.Resources.ResourceManager.GetObject(System.String)" />.</summary>
		/// <returns>Значение <see langword="true" />, чтобы не учитывать регистр при поиске ресурсов, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x0600478C RID: 18316 RVA: 0x000E9966 File Offset: 0x000E7B66
		// (set) Token: 0x0600478D RID: 18317 RVA: 0x000E996E File Offset: 0x000E7B6E
		public virtual bool IgnoreCase
		{
			get
			{
				return this._ignoreCase;
			}
			set
			{
				this._ignoreCase = value;
			}
		}

		/// <summary>Возвращает тип объекта набора ресурсов, используемый диспетчером ресурсов для построения объекта <see cref="T:System.Resources.ResourceSet" />.</summary>
		/// <returns>Тип объекта набора ресурсов, используемый диспетчером ресурсов для построения объекта <see cref="T:System.Resources.ResourceSet" />.</returns>
		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x0600478E RID: 18318 RVA: 0x000E9977 File Offset: 0x000E7B77
		public virtual Type ResourceSetType
		{
			get
			{
				if (!(this._userResourceSet == null))
				{
					return this._userResourceSet;
				}
				return typeof(RuntimeResourceSet);
			}
		}

		/// <summary>Возвращает или задает расположение, из которого извлекаются резервные ресурсы по умолчанию.</summary>
		/// <returns>Одно из значений перечисления, которое указывает, где диспетчер ресурсов может выполнять поиск резервных ресурсов.</returns>
		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x0600478F RID: 18319 RVA: 0x000E9998 File Offset: 0x000E7B98
		// (set) Token: 0x06004790 RID: 18320 RVA: 0x000E99A0 File Offset: 0x000E7BA0
		protected UltimateResourceFallbackLocation FallbackLocation
		{
			get
			{
				return this._fallbackLoc;
			}
			set
			{
				this._fallbackLoc = value;
			}
		}

		/// <summary>Сообщает диспетчеру ресурсов, что следует вызвать метод <see cref="M:System.Resources.ResourceSet.Close" /> на всех объектах <see cref="T:System.Resources.ResourceSet" /> и освободить все ресурсы.</summary>
		// Token: 0x06004791 RID: 18321 RVA: 0x000E99AC File Offset: 0x000E7BAC
		public virtual void ReleaseAllResources()
		{
			Dictionary<string, ResourceSet> resourceSets = this._resourceSets;
			this._resourceSets = new Dictionary<string, ResourceSet>();
			this._lastUsedResourceCache = new ResourceManager.CultureNameResourceSetPair();
			Dictionary<string, ResourceSet> obj = resourceSets;
			lock (obj)
			{
				IDictionaryEnumerator dictionaryEnumerator = resourceSets.GetEnumerator();
				IDictionaryEnumerator dictionaryEnumerator2 = null;
				if (this.ResourceSets != null)
				{
					dictionaryEnumerator2 = this.ResourceSets.GetEnumerator();
				}
				this.ResourceSets = new Hashtable();
				while (dictionaryEnumerator.MoveNext())
				{
					((ResourceSet)dictionaryEnumerator.Value).Close();
				}
				if (dictionaryEnumerator2 != null)
				{
					while (dictionaryEnumerator2.MoveNext())
					{
						((ResourceSet)dictionaryEnumerator2.Value).Close();
					}
				}
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Resources.ResourceManager" />, который ищет ресурсы в конкретном каталоге вместо манифеста сборки.</summary>
		/// <param name="baseName">Имя корневой папки ресурсов. Например, имя корневой папки для файла ресурсов "MyResource.en-US.resources" будет "MyResource".</param>
		/// <param name="resourceDir">Имя папки, в которой производится поиск ресурсов. <paramref name="resourceDir" /> может быть абсолютным или относительным путем из каталога приложения.</param>
		/// <param name="usingResourceSet">Тип пользовательского объекта <see cref="T:System.Resources.ResourceSet" /> для использования. При значении <see langword="null" /> используется объект времени выполнения по умолчанию <see cref="T:System.Resources.ResourceSet" />.</param>
		/// <returns>Новый экземпляр диспетчера ресурсов, который выполняет поиск ресурсов в указанном каталоге вместо манифеста сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="baseName" /> или параметра <paramref name="resourceDir" /> — <see langword="null" />.</exception>
		// Token: 0x06004792 RID: 18322 RVA: 0x000E9A68 File Offset: 0x000E7C68
		public static ResourceManager CreateFileBasedResourceManager(string baseName, string resourceDir, Type usingResourceSet)
		{
			return new ResourceManager(baseName, resourceDir, usingResourceSet);
		}

		/// <summary>Создает имя файла ресурсов для заданного объекта <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <param name="culture">Объект языка и региональных параметров, для которого создается имя файла ресурсов.</param>
		/// <returns>Имя, которое может быть использовано для файла ресурсов для заданного объекта <see cref="T:System.Globalization.CultureInfo" />.</returns>
		// Token: 0x06004793 RID: 18323 RVA: 0x000E9A74 File Offset: 0x000E7C74
		protected virtual string GetResourceFileName(CultureInfo culture)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			stringBuilder.Append(this.BaseNameField);
			if (!culture.HasInvariantCultureName)
			{
				CultureInfo.VerifyCultureName(culture.Name, true);
				stringBuilder.Append('.');
				stringBuilder.Append(culture.Name);
			}
			stringBuilder.Append(".resources");
			return stringBuilder.ToString();
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x000E9AD8 File Offset: 0x000E7CD8
		internal ResourceSet GetFirstResourceSet(CultureInfo culture)
		{
			if (this._neutralResourcesCulture != null && culture.Name == this._neutralResourcesCulture.Name)
			{
				culture = CultureInfo.InvariantCulture;
			}
			if (this._lastUsedResourceCache != null)
			{
				ResourceManager.CultureNameResourceSetPair lastUsedResourceCache = this._lastUsedResourceCache;
				lock (lastUsedResourceCache)
				{
					if (culture.Name == this._lastUsedResourceCache.lastCultureName)
					{
						return this._lastUsedResourceCache.lastResourceSet;
					}
				}
			}
			Dictionary<string, ResourceSet> resourceSets = this._resourceSets;
			ResourceSet resourceSet = null;
			if (resourceSets != null)
			{
				Dictionary<string, ResourceSet> obj = resourceSets;
				lock (obj)
				{
					resourceSets.TryGetValue(culture.Name, out resourceSet);
				}
			}
			if (resourceSet != null)
			{
				if (this._lastUsedResourceCache != null)
				{
					ResourceManager.CultureNameResourceSetPair lastUsedResourceCache = this._lastUsedResourceCache;
					lock (lastUsedResourceCache)
					{
						this._lastUsedResourceCache.lastCultureName = culture.Name;
						this._lastUsedResourceCache.lastResourceSet = resourceSet;
					}
				}
				return resourceSet;
			}
			return null;
		}

		/// <summary>Извлекает набор ресурсов для определенного языка и региональных параметров.</summary>
		/// <param name="culture">Язык и региональные параметры, ресурсы для которых необходимо получить.</param>
		/// <param name="createIfNotExists">Значение <see langword="true" /> для загрузки набора ресурсов, если он еще не загружен; в противном случае — значение <see langword="false" />.</param>
		/// <param name="tryParents">Значение <see langword="true" />, чтобы соответствующий ресурс загружался с использованием резервных ресурсов, если набор ресурсов не удается найти. Значение <see langword="false" /> для обхода процесса использования резервных ресурсов.</param>
		/// <returns>Набор ресурсов для указанного языка и региональных параметров.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="culture" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Resources.MissingManifestResourceException">Параметр <paramref name="tryParents" /> имеет значение <see langword="true" />, не найден подходящий набор ресурсов, и отсутствуют ресурсы языка и региональных параметров по умолчанию.</exception>
		// Token: 0x06004795 RID: 18325 RVA: 0x000E9C04 File Offset: 0x000E7E04
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			Dictionary<string, ResourceSet> resourceSets = this._resourceSets;
			if (resourceSets != null)
			{
				Dictionary<string, ResourceSet> obj = resourceSets;
				lock (obj)
				{
					ResourceSet result;
					if (resourceSets.TryGetValue(culture.Name, out result))
					{
						return result;
					}
				}
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			if (this.UseManifest && culture.HasInvariantCultureName)
			{
				string resourceFileName = this.GetResourceFileName(culture);
				Stream manifestResourceStream = ((RuntimeAssembly)this.MainAssembly).GetManifestResourceStream(this._locationInfo, resourceFileName, this.m_callingAssembly == this.MainAssembly, ref stackCrawlMark);
				if (createIfNotExists && manifestResourceStream != null)
				{
					ResourceSet result = ((ManifestBasedResourceGroveler)this.resourceGroveler).CreateResourceSet(manifestResourceStream, this.MainAssembly);
					ResourceManager.AddResourceSet(resourceSets, culture.Name, ref result);
					return result;
				}
			}
			return this.InternalGetResourceSet(culture, createIfNotExists, tryParents);
		}

		/// <summary>Предоставляет реализацию для обнаружения набора ресурсов.</summary>
		/// <param name="culture">Искомый объект языка и региональных параметров.</param>
		/// <param name="createIfNotExists">Значение <see langword="true" /> для загрузки набора ресурсов, если он еще не загружен; в противном случае — значение <see langword="false" />.</param>
		/// <param name="tryParents">Значение <see langword="true" /> для проверки родительских объектов <see cref="T:System.Globalization.CultureInfo" />, если невозможно загрузить набор ресурсов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Указанный набор ресурсов.</returns>
		/// <exception cref="T:System.Resources.MissingManifestResourceException">Главная сборка не содержит RESOURCES-файл, требуемый для обнаружения ресурса.</exception>
		/// <exception cref="T:System.ExecutionEngineException">Произошла внутренняя ошибка среды выполнения.</exception>
		/// <exception cref="T:System.Resources.MissingSatelliteAssemblyException">Не удается найти местоположение вспомогательной сборки, связанной с объектом <paramref name="culture" />.</exception>
		// Token: 0x06004796 RID: 18326 RVA: 0x000E9CF0 File Offset: 0x000E7EF0
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return this.InternalGetResourceSet(culture, createIfNotExists, tryParents, ref stackCrawlMark);
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x000E9D0C File Offset: 0x000E7F0C
		[SecurityCritical]
		private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark)
		{
			Dictionary<string, ResourceSet> resourceSets = this._resourceSets;
			ResourceSet resourceSet = null;
			CultureInfo cultureInfo = null;
			Dictionary<string, ResourceSet> obj = resourceSets;
			lock (obj)
			{
				if (resourceSets.TryGetValue(requestedCulture.Name, out resourceSet))
				{
					return resourceSet;
				}
			}
			ResourceFallbackManager resourceFallbackManager = new ResourceFallbackManager(requestedCulture, this._neutralResourcesCulture, tryParents);
			foreach (CultureInfo cultureInfo2 in resourceFallbackManager)
			{
				obj = resourceSets;
				lock (obj)
				{
					if (resourceSets.TryGetValue(cultureInfo2.Name, out resourceSet))
					{
						if (requestedCulture != cultureInfo2)
						{
							cultureInfo = cultureInfo2;
						}
						break;
					}
				}
				resourceSet = this.resourceGroveler.GrovelForResourceSet(cultureInfo2, resourceSets, tryParents, createIfNotExists, ref stackMark);
				if (resourceSet != null)
				{
					cultureInfo = cultureInfo2;
					break;
				}
			}
			if (resourceSet != null && cultureInfo != null)
			{
				foreach (CultureInfo cultureInfo3 in resourceFallbackManager)
				{
					ResourceManager.AddResourceSet(resourceSets, cultureInfo3.Name, ref resourceSet);
					if (cultureInfo3 == cultureInfo)
					{
						break;
					}
				}
			}
			return resourceSet;
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x000E9E64 File Offset: 0x000E8064
		private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs)
		{
			lock (localResourceSets)
			{
				ResourceSet resourceSet;
				if (localResourceSets.TryGetValue(cultureName, out resourceSet))
				{
					if (resourceSet != rs)
					{
						if (!localResourceSets.ContainsValue(rs))
						{
							rs.Dispose();
						}
						rs = resourceSet;
					}
				}
				else
				{
					localResourceSets.Add(cultureName, rs);
				}
			}
		}

		/// <summary>Возвращает версию, указанную атрибутом <see cref="T:System.Resources.SatelliteContractVersionAttribute" /> в заданной сборке.</summary>
		/// <param name="a">Сборка для проверки атрибута <see cref="T:System.Resources.SatelliteContractVersionAttribute" />.</param>
		/// <returns>Версия сопутствующего контракта данной сборки либо значение <see langword="null" />, если версия не была найдена.</returns>
		/// <exception cref="T:System.ArgumentException">Объект <see cref="T:System.Version" />, найденный в сборке <paramref name="a" />, неверен.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="a" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004799 RID: 18329 RVA: 0x000E9EC8 File Offset: 0x000E80C8
		protected static Version GetSatelliteContractVersion(Assembly a)
		{
			if (a == null)
			{
				throw new ArgumentNullException("a", Environment.GetResourceString("Assembly cannot be null."));
			}
			string text = null;
			if (a.ReflectionOnly)
			{
				foreach (CustomAttributeData customAttributeData in CustomAttributeData.GetCustomAttributes(a))
				{
					if (customAttributeData.Constructor.DeclaringType == typeof(SatelliteContractVersionAttribute))
					{
						text = (string)customAttributeData.ConstructorArguments[0].Value;
						break;
					}
				}
				if (text == null)
				{
					return null;
				}
			}
			else
			{
				object[] customAttributes = a.GetCustomAttributes(typeof(SatelliteContractVersionAttribute), false);
				if (customAttributes.Length == 0)
				{
					return null;
				}
				text = ((SatelliteContractVersionAttribute)customAttributes[0]).Version;
			}
			Version result;
			try
			{
				result = new Version(text);
			}
			catch (ArgumentOutOfRangeException innerException)
			{
				if (a == typeof(object).Assembly)
				{
					return null;
				}
				throw new ArgumentException(Environment.GetResourceString("Satellite contract version attribute on the assembly '{0}' specifies an invalid version: {1}.", new object[]
				{
					a.ToString(),
					text
				}), innerException);
			}
			return result;
		}

		/// <summary>Возвращает сведения, относящиеся к конкретному языку и региональным параметрам, для ресурсов главной сборки по умолчанию путем получения значения атрибута <see cref="T:System.Resources.NeutralResourcesLanguageAttribute" /> в указанной сборке.</summary>
		/// <param name="a">Сборка, для которой требуется получить сведения, относящиеся к конкретному языку и региональным параметрам.</param>
		/// <returns>Язык и региональные параметры из атрибута <see cref="T:System.Resources.NeutralResourcesLanguageAttribute" />, если они найдены; в противном случае — инвариантный язык и региональные параметры.</returns>
		// Token: 0x0600479A RID: 18330 RVA: 0x000E9FFC File Offset: 0x000E81FC
		[SecuritySafeCritical]
		protected static CultureInfo GetNeutralResourcesLanguage(Assembly a)
		{
			UltimateResourceFallbackLocation ultimateResourceFallbackLocation = UltimateResourceFallbackLocation.MainAssembly;
			return ManifestBasedResourceGroveler.GetNeutralResourcesLanguage(a, ref ultimateResourceFallbackLocation);
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x000EA014 File Offset: 0x000E8214
		internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2)
		{
			int num = asmTypeName1.IndexOf(',');
			if (((num == -1) ? asmTypeName1.Length : num) != typeName2.Length)
			{
				return false;
			}
			if (string.Compare(asmTypeName1, 0, typeName2, 0, typeName2.Length, StringComparison.Ordinal) != 0)
			{
				return false;
			}
			if (num == -1)
			{
				return true;
			}
			while (char.IsWhiteSpace(asmTypeName1[++num]))
			{
			}
			AssemblyName assemblyName = new AssemblyName(asmTypeName1.Substring(num));
			if (string.Compare(assemblyName.Name, asmName2.Name, StringComparison.OrdinalIgnoreCase) != 0)
			{
				return false;
			}
			if (string.Compare(assemblyName.Name, "mscorlib", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
			if (assemblyName.CultureInfo != null && asmName2.CultureInfo != null && assemblyName.CultureInfo.LCID != asmName2.CultureInfo.LCID)
			{
				return false;
			}
			byte[] publicKeyToken = assemblyName.GetPublicKeyToken();
			byte[] publicKeyToken2 = asmName2.GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken2 != null)
			{
				if (publicKeyToken.Length != publicKeyToken2.Length)
				{
					return false;
				}
				for (int i = 0; i < publicKeyToken.Length; i++)
				{
					if (publicKeyToken[i] != publicKeyToken2[i])
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x00004BF9 File Offset: 0x00002DF9
		private void SetAppXConfiguration()
		{
		}

		/// <summary>Возвращает значение указанного строкового ресурса.</summary>
		/// <param name="name">Имя извлекаемого ресурса.</param>
		/// <returns>Значение ресурса, локализованное для языка и региональных параметров текущего пользовательского интерфейса вызывающего объекта, или значение <see langword="null" />, если не удается найти <paramref name="name" /> в наборе ресурсов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Значение указанного ресурса не является строковым.</exception>
		/// <exception cref="T:System.Resources.MissingManifestResourceException">Не найден подходящий набор ресурсов и отсутствуют ресурсы языка и региональных параметров по умолчанию. Сведения об обработке этого исключения см. в подразделе "Обработка исключений MissingManifestResourceException и MissingSatelliteAssemblyException" раздела, посвященного классу <see cref="T:System.Resources.ResourceManager" />.</exception>
		/// <exception cref="T:System.Resources.MissingSatelliteAssemblyException">Ресурсы языка и региональных параметров по умолчанию находятся во вспомогательной сборке, которую не удалось найти. Сведения об обработке этого исключения см. в подразделе "Обработка исключений MissingManifestResourceException и MissingSatelliteAssemblyException" раздела, посвященного классу <see cref="T:System.Resources.ResourceManager" />.</exception>
		// Token: 0x0600479D RID: 18333 RVA: 0x000EA10C File Offset: 0x000E830C
		public virtual string GetString(string name)
		{
			return this.GetString(name, null);
		}

		/// <summary>Возвращает значение строкового ресурса, локализованного для указанного языка и региональных параметров.</summary>
		/// <param name="name">Имя извлекаемого ресурса.</param>
		/// <param name="culture">Объект, предоставляющий язык и региональные параметры, для которых локализуется ресурс.</param>
		/// <returns>Значение ресурса, локализованное для указанного языка и региональных параметров, или значение <see langword="null" />, если не удается найти <paramref name="name" /> в наборе ресурсов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Значение указанного ресурса не является строковым.</exception>
		/// <exception cref="T:System.Resources.MissingManifestResourceException">Не найден подходящий набор ресурсов и отсутствуют ресурсы языка и региональных параметров по умолчанию. Сведения об обработке этого исключения см. в подразделе "Обработка исключений MissingManifestResourceException и MissingSatelliteAssemblyException" раздела, посвященного классу <see cref="T:System.Resources.ResourceManager" />.</exception>
		/// <exception cref="T:System.Resources.MissingSatelliteAssemblyException">Ресурсы языка и региональных параметров по умолчанию находятся во вспомогательной сборке, которую не удалось найти. Сведения об обработке этого исключения см. в подразделе "Обработка исключений MissingManifestResourceException и MissingSatelliteAssemblyException" раздела, посвященного классу <see cref="T:System.Resources.ResourceManager" />.</exception>
		// Token: 0x0600479E RID: 18334 RVA: 0x000EA118 File Offset: 0x000E8318
		public virtual string GetString(string name, CultureInfo culture)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (culture == null)
			{
				culture = Thread.CurrentThread.GetCurrentUICultureNoAppX();
			}
			ResourceSet resourceSet = this.GetFirstResourceSet(culture);
			if (resourceSet != null)
			{
				string @string = resourceSet.GetString(name, this._ignoreCase);
				if (@string != null)
				{
					return @string;
				}
			}
			foreach (CultureInfo cultureInfo in new ResourceFallbackManager(culture, this._neutralResourcesCulture, true))
			{
				ResourceSet resourceSet2 = this.InternalGetResourceSet(cultureInfo, true, true);
				if (resourceSet2 == null)
				{
					break;
				}
				if (resourceSet2 != resourceSet)
				{
					string string2 = resourceSet2.GetString(name, this._ignoreCase);
					if (string2 != null)
					{
						if (this._lastUsedResourceCache != null)
						{
							ResourceManager.CultureNameResourceSetPair lastUsedResourceCache = this._lastUsedResourceCache;
							lock (lastUsedResourceCache)
							{
								this._lastUsedResourceCache.lastCultureName = cultureInfo.Name;
								this._lastUsedResourceCache.lastResourceSet = resourceSet2;
							}
						}
						return string2;
					}
					resourceSet = resourceSet2;
				}
			}
			return null;
		}

		/// <summary>Возвращает значение указанного нестрокового ресурса.</summary>
		/// <param name="name">Имя получаемого ресурса.</param>
		/// <returns>Значение ресурса, локализованного для текущих настроек языка и региональных параметров вызывающего объекта. Если соответствующий набор ресурсов существует, но параметр <paramref name="name" /> не найден, то метод возвращает значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Resources.MissingManifestResourceException">Не найден подходящий набор локализованных ресурсов и отсутствуют ресурсы языка и региональных параметров по умолчанию. Сведения об обработке этого исключения см. в подразделе "Обработка исключений MissingManifestResourceException и MissingSatelliteAssemblyException" раздела, посвященного классу <see cref="T:System.Resources.ResourceManager" />.</exception>
		/// <exception cref="T:System.Resources.MissingSatelliteAssemblyException">Ресурсы языка и региональных параметров по умолчанию находятся во вспомогательной сборке, которую не удалось найти. Сведения об обработке этого исключения см. в подразделе "Обработка исключений MissingManifestResourceException и MissingSatelliteAssemblyException" раздела, посвященного классу <see cref="T:System.Resources.ResourceManager" />.</exception>
		// Token: 0x0600479F RID: 18335 RVA: 0x000EA234 File Offset: 0x000E8434
		public virtual object GetObject(string name)
		{
			return this.GetObject(name, null, true);
		}

		/// <summary>Возвращает значение указанного нестрокового ресурса, локализованного для указанного языка и региональных параметров.</summary>
		/// <param name="name">Имя получаемого ресурса.</param>
		/// <param name="culture">Язык и региональные параметры, для которых локализуется этот ресурс. Если ресурс для языка и региональных параметров не локализован, диспетчер ресурсов использует резервные правила для поиска подходящего ресурса.  
		/// Если это значение равно <see langword="null" />, объект <see cref="T:System.Globalization.CultureInfo" /> получается с помощью свойства <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" />.</param>
		/// <returns>Значение ресурса, локализованного для указанного языка и региональных параметров. Если соответствующий набор ресурсов существует, но параметр <paramref name="name" /> не найден, то метод возвращает значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Resources.MissingManifestResourceException">Не было найдено никаких возможных наборов ресурсов и отсутствуют ресурсы языка и региональных параметров по умолчанию. Сведения об обработке этого исключения см. в подразделе "Обработка исключений MissingManifestResourceException и MissingSatelliteAssemblyException" раздела, посвященного классу <see cref="T:System.Resources.ResourceManager" />.</exception>
		/// <exception cref="T:System.Resources.MissingSatelliteAssemblyException">Ресурсы языка и региональных параметров по умолчанию находятся во вспомогательной сборке, которую не удалось найти. Сведения об обработке этого исключения см. в подразделе "Обработка исключений MissingManifestResourceException и MissingSatelliteAssemblyException" раздела, посвященного классу <see cref="T:System.Resources.ResourceManager" />.</exception>
		// Token: 0x060047A0 RID: 18336 RVA: 0x000EA23F File Offset: 0x000E843F
		public virtual object GetObject(string name, CultureInfo culture)
		{
			return this.GetObject(name, culture, true);
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x000EA24C File Offset: 0x000E844C
		private object GetObject(string name, CultureInfo culture, bool wrapUnmanagedMemStream)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (culture == null)
			{
				culture = Thread.CurrentThread.GetCurrentUICultureNoAppX();
			}
			ResourceSet resourceSet = this.GetFirstResourceSet(culture);
			if (resourceSet != null)
			{
				object @object = resourceSet.GetObject(name, this._ignoreCase);
				if (@object != null)
				{
					UnmanagedMemoryStream unmanagedMemoryStream = @object as UnmanagedMemoryStream;
					if (unmanagedMemoryStream != null && wrapUnmanagedMemStream)
					{
						return new UnmanagedMemoryStreamWrapper(unmanagedMemoryStream);
					}
					return @object;
				}
			}
			foreach (CultureInfo cultureInfo in new ResourceFallbackManager(culture, this._neutralResourcesCulture, true))
			{
				ResourceSet resourceSet2 = this.InternalGetResourceSet(cultureInfo, true, true);
				if (resourceSet2 == null)
				{
					break;
				}
				if (resourceSet2 != resourceSet)
				{
					object object2 = resourceSet2.GetObject(name, this._ignoreCase);
					if (object2 != null)
					{
						if (this._lastUsedResourceCache != null)
						{
							ResourceManager.CultureNameResourceSetPair lastUsedResourceCache = this._lastUsedResourceCache;
							lock (lastUsedResourceCache)
							{
								this._lastUsedResourceCache.lastCultureName = cultureInfo.Name;
								this._lastUsedResourceCache.lastResourceSet = resourceSet2;
							}
						}
						UnmanagedMemoryStream unmanagedMemoryStream2 = object2 as UnmanagedMemoryStream;
						if (unmanagedMemoryStream2 != null && wrapUnmanagedMemStream)
						{
							return new UnmanagedMemoryStreamWrapper(unmanagedMemoryStream2);
						}
						return object2;
					}
					else
					{
						resourceSet = resourceSet2;
					}
				}
			}
			return null;
		}

		/// <summary>Возвращает объект потока неуправляемой памяти из заданного ресурса.</summary>
		/// <param name="name">Имя ресурса.</param>
		/// <returns>Объект потока неуправляемой памяти, представляющий ресурс.</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение указанного ресурса не является объектом <see cref="T:System.IO.MemoryStream" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Resources.MissingManifestResourceException">Не было найдено никаких возможных наборов ресурсов и отсутствуют ресурсы по умолчанию. Сведения об обработке этого исключения см. в подразделе "Обработка исключений MissingManifestResourceException и MissingSatelliteAssemblyException" раздела, посвященного классу <see cref="T:System.Resources.ResourceManager" />.</exception>
		/// <exception cref="T:System.Resources.MissingSatelliteAssemblyException">Ресурсы языка и региональных параметров по умолчанию находятся во вспомогательной сборке, которую не удалось найти. Сведения об обработке этого исключения см. в подразделе "Обработка исключений MissingManifestResourceException и MissingSatelliteAssemblyException" раздела, посвященного классу <see cref="T:System.Resources.ResourceManager" />.</exception>
		// Token: 0x060047A2 RID: 18338 RVA: 0x000EA3A4 File Offset: 0x000E85A4
		[ComVisible(false)]
		public UnmanagedMemoryStream GetStream(string name)
		{
			return this.GetStream(name, null);
		}

		/// <summary>Возвращает объект потока неуправляемой памяти из заданного ресурса, используя заданный язык и региональные параметры.</summary>
		/// <param name="name">Имя ресурса.</param>
		/// <param name="culture">Объект, задающий язык и региональные параметры для использования при поиске ресурса. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, используется язык и региональные параметры для текущего потока.</param>
		/// <returns>Объект потока неуправляемой памяти, представляющий ресурс.</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение указанного ресурса не является объектом <see cref="T:System.IO.MemoryStream" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Resources.MissingManifestResourceException">Не было найдено никаких возможных наборов ресурсов и отсутствуют ресурсы по умолчанию. Сведения об обработке этого исключения см. в подразделе "Обработка исключений MissingManifestResourceException и MissingSatelliteAssemblyException" раздела, посвященного классу <see cref="T:System.Resources.ResourceManager" />.</exception>
		/// <exception cref="T:System.Resources.MissingSatelliteAssemblyException">Ресурсы языка и региональных параметров по умолчанию находятся во вспомогательной сборке, которую не удалось найти. Сведения об обработке этого исключения см. в подразделе "Обработка исключений MissingManifestResourceException и MissingSatelliteAssemblyException" раздела, посвященного классу <see cref="T:System.Resources.ResourceManager" />.</exception>
		// Token: 0x060047A3 RID: 18339 RVA: 0x000EA3B0 File Offset: 0x000E85B0
		[ComVisible(false)]
		public UnmanagedMemoryStream GetStream(string name, CultureInfo culture)
		{
			object @object = this.GetObject(name, culture, false);
			UnmanagedMemoryStream unmanagedMemoryStream = @object as UnmanagedMemoryStream;
			if (unmanagedMemoryStream == null && @object != null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Resource '{0}' was not a Stream - call GetObject instead.", new object[]
				{
					name
				}));
			}
			return unmanagedMemoryStream;
		}

		/// <summary>Указывает имя корневой папки файлов ресурсов, в которой класс <see cref="T:System.Resources.ResourceManager" /> ищет ресурсы.</summary>
		// Token: 0x04002DCE RID: 11726
		protected string BaseNameField;

		/// <summary>Содержит объект <see cref="T:System.Collections.Hashtable" />, который возвращает сопоставление языков и региональных параметров с объектами <see cref="T:System.Resources.ResourceSet" />.</summary>
		// Token: 0x04002DCF RID: 11727
		[Obsolete("call InternalGetResourceSet instead")]
		protected Hashtable ResourceSets;

		// Token: 0x04002DD0 RID: 11728
		[NonSerialized]
		private Dictionary<string, ResourceSet> _resourceSets;

		// Token: 0x04002DD1 RID: 11729
		private string moduleDir;

		/// <summary>Задает главную сборку, содержащую ресурсы.</summary>
		// Token: 0x04002DD2 RID: 11730
		protected Assembly MainAssembly;

		// Token: 0x04002DD3 RID: 11731
		private Type _locationInfo;

		// Token: 0x04002DD4 RID: 11732
		private Type _userResourceSet;

		// Token: 0x04002DD5 RID: 11733
		private CultureInfo _neutralResourcesCulture;

		// Token: 0x04002DD6 RID: 11734
		[NonSerialized]
		private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache;

		// Token: 0x04002DD7 RID: 11735
		private bool _ignoreCase;

		// Token: 0x04002DD8 RID: 11736
		private bool UseManifest;

		// Token: 0x04002DD9 RID: 11737
		[OptionalField(VersionAdded = 1)]
		private bool UseSatelliteAssem;

		// Token: 0x04002DDA RID: 11738
		[OptionalField]
		private UltimateResourceFallbackLocation _fallbackLoc;

		// Token: 0x04002DDB RID: 11739
		[OptionalField]
		private Version _satelliteContractVersion;

		// Token: 0x04002DDC RID: 11740
		[OptionalField]
		private bool _lookedForSatelliteContractVersion;

		// Token: 0x04002DDD RID: 11741
		[OptionalField(VersionAdded = 1)]
		private Assembly _callingAssembly;

		// Token: 0x04002DDE RID: 11742
		[OptionalField(VersionAdded = 4)]
		private RuntimeAssembly m_callingAssembly;

		// Token: 0x04002DDF RID: 11743
		[NonSerialized]
		private IResourceGroveler resourceGroveler;

		/// <summary>Содержит номер, используемый для идентификации файлов ресурсов.</summary>
		// Token: 0x04002DE0 RID: 11744
		public static readonly int MagicNumber = -1091581234;

		/// <summary>Указывает версию заголовков файлов ресурсов, которую текущая реализация <see cref="T:System.Resources.ResourceManager" /> может интерпретировать и создавать.</summary>
		// Token: 0x04002DE1 RID: 11745
		public static readonly int HeaderVersionNumber = 1;

		// Token: 0x04002DE2 RID: 11746
		private static readonly Type _minResourceSet = typeof(ResourceSet);

		// Token: 0x04002DE3 RID: 11747
		internal static readonly string ResReaderTypeName = typeof(ResourceReader).FullName;

		// Token: 0x04002DE4 RID: 11748
		internal static readonly string ResSetTypeName = typeof(RuntimeResourceSet).FullName;

		// Token: 0x04002DE5 RID: 11749
		internal static readonly string MscorlibName = typeof(ResourceReader).Assembly.FullName;

		// Token: 0x04002DE6 RID: 11750
		internal const string ResFileExtension = ".resources";

		// Token: 0x04002DE7 RID: 11751
		internal const int ResFileExtensionLength = 10;

		// Token: 0x04002DE8 RID: 11752
		internal static readonly int DEBUG = 0;

		// Token: 0x02000869 RID: 2153
		internal class CultureNameResourceSetPair
		{
			// Token: 0x04002DE9 RID: 11753
			public string lastCultureName;

			// Token: 0x04002DEA RID: 11754
			public ResourceSet lastResourceSet;
		}

		// Token: 0x0200086A RID: 2154
		internal class ResourceManagerMediator
		{
			// Token: 0x060047A6 RID: 18342 RVA: 0x000EA463 File Offset: 0x000E8663
			internal ResourceManagerMediator(ResourceManager rm)
			{
				if (rm == null)
				{
					throw new ArgumentNullException("rm");
				}
				this._rm = rm;
			}

			// Token: 0x17000AF7 RID: 2807
			// (get) Token: 0x060047A7 RID: 18343 RVA: 0x000EA480 File Offset: 0x000E8680
			internal string ModuleDir
			{
				get
				{
					return this._rm.moduleDir;
				}
			}

			// Token: 0x17000AF8 RID: 2808
			// (get) Token: 0x060047A8 RID: 18344 RVA: 0x000EA48D File Offset: 0x000E868D
			internal Type LocationInfo
			{
				get
				{
					return this._rm._locationInfo;
				}
			}

			// Token: 0x17000AF9 RID: 2809
			// (get) Token: 0x060047A9 RID: 18345 RVA: 0x000EA49A File Offset: 0x000E869A
			internal Type UserResourceSet
			{
				get
				{
					return this._rm._userResourceSet;
				}
			}

			// Token: 0x17000AFA RID: 2810
			// (get) Token: 0x060047AA RID: 18346 RVA: 0x000EA4A7 File Offset: 0x000E86A7
			internal string BaseNameField
			{
				get
				{
					return this._rm.BaseNameField;
				}
			}

			// Token: 0x17000AFB RID: 2811
			// (get) Token: 0x060047AB RID: 18347 RVA: 0x000EA4B4 File Offset: 0x000E86B4
			// (set) Token: 0x060047AC RID: 18348 RVA: 0x000EA4C1 File Offset: 0x000E86C1
			internal CultureInfo NeutralResourcesCulture
			{
				get
				{
					return this._rm._neutralResourcesCulture;
				}
				set
				{
					this._rm._neutralResourcesCulture = value;
				}
			}

			// Token: 0x060047AD RID: 18349 RVA: 0x000EA4CF File Offset: 0x000E86CF
			internal string GetResourceFileName(CultureInfo culture)
			{
				return this._rm.GetResourceFileName(culture);
			}

			// Token: 0x17000AFC RID: 2812
			// (get) Token: 0x060047AE RID: 18350 RVA: 0x000EA4DD File Offset: 0x000E86DD
			// (set) Token: 0x060047AF RID: 18351 RVA: 0x000EA4EA File Offset: 0x000E86EA
			internal bool LookedForSatelliteContractVersion
			{
				get
				{
					return this._rm._lookedForSatelliteContractVersion;
				}
				set
				{
					this._rm._lookedForSatelliteContractVersion = value;
				}
			}

			// Token: 0x17000AFD RID: 2813
			// (get) Token: 0x060047B0 RID: 18352 RVA: 0x000EA4F8 File Offset: 0x000E86F8
			// (set) Token: 0x060047B1 RID: 18353 RVA: 0x000EA505 File Offset: 0x000E8705
			internal Version SatelliteContractVersion
			{
				get
				{
					return this._rm._satelliteContractVersion;
				}
				set
				{
					this._rm._satelliteContractVersion = value;
				}
			}

			// Token: 0x060047B2 RID: 18354 RVA: 0x000EA513 File Offset: 0x000E8713
			internal Version ObtainSatelliteContractVersion(Assembly a)
			{
				return ResourceManager.GetSatelliteContractVersion(a);
			}

			// Token: 0x17000AFE RID: 2814
			// (get) Token: 0x060047B3 RID: 18355 RVA: 0x000EA51B File Offset: 0x000E871B
			// (set) Token: 0x060047B4 RID: 18356 RVA: 0x000EA528 File Offset: 0x000E8728
			internal UltimateResourceFallbackLocation FallbackLoc
			{
				get
				{
					return this._rm.FallbackLocation;
				}
				set
				{
					this._rm._fallbackLoc = value;
				}
			}

			// Token: 0x17000AFF RID: 2815
			// (get) Token: 0x060047B5 RID: 18357 RVA: 0x000EA536 File Offset: 0x000E8736
			internal RuntimeAssembly CallingAssembly
			{
				get
				{
					return this._rm.m_callingAssembly;
				}
			}

			// Token: 0x17000B00 RID: 2816
			// (get) Token: 0x060047B6 RID: 18358 RVA: 0x000EA543 File Offset: 0x000E8743
			internal RuntimeAssembly MainAssembly
			{
				get
				{
					return (RuntimeAssembly)this._rm.MainAssembly;
				}
			}

			// Token: 0x17000B01 RID: 2817
			// (get) Token: 0x060047B7 RID: 18359 RVA: 0x000EA555 File Offset: 0x000E8755
			internal string BaseName
			{
				get
				{
					return this._rm.BaseName;
				}
			}

			// Token: 0x04002DEB RID: 11755
			private ResourceManager _rm;
		}
	}
}
