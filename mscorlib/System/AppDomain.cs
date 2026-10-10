using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Threading;
using Mono.Security;

namespace System
{
	/// <summary>Представляет домен приложения, являющийся изолированной средой, в которой выполняются приложения. Этот класс не наследуется.</summary>
	// Token: 0x02000214 RID: 532
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(_AppDomain))]
	[ComVisible(true)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class AppDomain : MarshalByRefObject, _AppDomain, IEvidenceFactory
	{
		// Token: 0x0600175A RID: 5978 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		internal static bool IsAppXModel()
		{
			return false;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		internal static bool IsAppXDesignMode()
		{
			return false;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00004BF9 File Offset: 0x00002DF9
		internal static void CheckReflectionOnlyLoadSupported()
		{
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00004BF9 File Offset: 0x00002DF9
		internal static void CheckLoadFromSupported()
		{
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00053949 File Offset: 0x00051B49
		private AppDomain()
		{
		}

		// Token: 0x0600175F RID: 5983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AppDomainSetup getSetup();

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x0005B23B File Offset: 0x0005943B
		private AppDomainSetup SetupInformationNoCopy
		{
			get
			{
				return this.getSetup();
			}
		}

		/// <summary>Возвращает сведения о конфигурации домена приложения для этого экземпляра.</summary>
		/// <returns>Сведения об инициализации домена приложения.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x0005B243 File Offset: 0x00059443
		public AppDomainSetup SetupInformation
		{
			get
			{
				return new AppDomainSetup(this.getSetup());
			}
		}

		/// <summary>Возвращает информацию, описывающую разрешения, предоставленные приложению, и то, имеет ли приложение уровень доверия, позволяющий ему выполняться.</summary>
		/// <returns>Объект, инкапсулирующий сведения о разрешениях и доверии для приложения в домене приложения.</returns>
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public ApplicationTrust ApplicationTrust
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает базовый каталог, в котором распознаватель сборок производит поиск.</summary>
		/// <returns>Базовый каталог, в котором распознаватель сборок производит поиск.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x0005B250 File Offset: 0x00059450
		public string BaseDirectory
		{
			get
			{
				string applicationBase = this.SetupInformationNoCopy.ApplicationBase;
				if (SecurityManager.SecurityEnabled && applicationBase != null && applicationBase.Length > 0)
				{
					new FileIOPermission(FileIOPermissionAccess.PathDiscovery, applicationBase).Demand();
				}
				return applicationBase;
			}
		}

		/// <summary>Возвращает путь, к каталогу, находящемуся в базовом каталоге, где распознаватель сборок будет производить поиск закрытых сборок.</summary>
		/// <returns>Путь, к каталогу, находящемуся в базовом каталоге, где распознаватель сборок будет производить поиск закрытых сборок.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x0005B28C File Offset: 0x0005948C
		public string RelativeSearchPath
		{
			get
			{
				string privateBinPath = this.SetupInformationNoCopy.PrivateBinPath;
				if (SecurityManager.SecurityEnabled && privateBinPath != null && privateBinPath.Length > 0)
				{
					new FileIOPermission(FileIOPermissionAccess.PathDiscovery, privateBinPath).Demand();
				}
				return privateBinPath;
			}
		}

		/// <summary>Возвращает каталог, в котором распознаватель сборок производит поиск динамически созданных сборок.</summary>
		/// <returns>Каталог, в котором распознаватель сборок производит поиск динамически созданных сборок.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x0005B2C8 File Offset: 0x000594C8
		public string DynamicDirectory
		{
			[SecuritySafeCritical]
			get
			{
				AppDomainSetup setupInformationNoCopy = this.SetupInformationNoCopy;
				if (setupInformationNoCopy.DynamicBase == null)
				{
					return null;
				}
				string text = Path.Combine(setupInformationNoCopy.DynamicBase, setupInformationNoCopy.ApplicationName);
				if (SecurityManager.SecurityEnabled && text != null && text.Length > 0)
				{
					new FileIOPermission(FileIOPermissionAccess.PathDiscovery, text).Demand();
				}
				return text;
			}
		}

		/// <summary>Возвращает указание на то, настроен ли домен приложения для теневого копирования файлов.</summary>
		/// <returns>Значение <see langword="true" />, если домен приложения настроен для теневого копирования файлов; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x0005B318 File Offset: 0x00059518
		public bool ShadowCopyFiles
		{
			get
			{
				return this.SetupInformationNoCopy.ShadowCopyFiles == "true";
			}
		}

		// Token: 0x06001767 RID: 5991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern string getFriendlyName();

		/// <summary>Возвращает понятное имя этого домена приложения.</summary>
		/// <returns>Понятное имя этого домена приложения.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x0005B32F File Offset: 0x0005952F
		public string FriendlyName
		{
			[SecuritySafeCritical]
			get
			{
				return this.getFriendlyName();
			}
		}

		/// <summary>Возвращает свидетельство <see cref="T:System.Security.Policy.Evidence" />, связанное с этим доменом приложения.</summary>
		/// <returns>Свидетельство, связанное с данным доменом приложений.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x0005B338 File Offset: 0x00059538
		public Evidence Evidence
		{
			[SecuritySafeCritical]
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true)]
			get
			{
				if (this._evidence == null)
				{
					lock (this)
					{
						Assembly entryAssembly = Assembly.GetEntryAssembly();
						if (entryAssembly == null)
						{
							if (this == AppDomain.DefaultDomain)
							{
								return new Evidence();
							}
							this._evidence = AppDomain.DefaultDomain.Evidence;
						}
						else
						{
							this._evidence = Evidence.GetDefaultHostEvidence(entryAssembly);
						}
					}
				}
				return new Evidence(this._evidence);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x0005B3C0 File Offset: 0x000595C0
		internal IPrincipal DefaultPrincipal
		{
			get
			{
				if (AppDomain._principal == null)
				{
					PrincipalPolicy principalPolicy = this._principalPolicy;
					if (principalPolicy != PrincipalPolicy.UnauthenticatedPrincipal)
					{
						if (principalPolicy == PrincipalPolicy.WindowsPrincipal)
						{
							AppDomain._principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
						}
					}
					else
					{
						AppDomain._principal = new GenericPrincipal(new GenericIdentity(string.Empty, string.Empty), null);
					}
				}
				return AppDomain._principal;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x0005B414 File Offset: 0x00059614
		internal PermissionSet GrantedPermissionSet
		{
			get
			{
				return this._granted;
			}
		}

		/// <summary>Возвращает набор разрешений изолированного домена приложения.</summary>
		/// <returns>Набор разрешений изолированного домена приложения.</returns>
		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x0005B41C File Offset: 0x0005961C
		public PermissionSet PermissionSet
		{
			get
			{
				PermissionSet result;
				if ((result = this._granted) == null)
				{
					result = (this._granted = new PermissionSet(PermissionState.Unrestricted));
				}
				return result;
			}
		}

		// Token: 0x0600176D RID: 5997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AppDomain getCurDomain();

		/// <summary>Возвращает текущий домен приложения для текущего объекта <see cref="T:System.Threading.Thread" />.</summary>
		/// <returns>Текущий домен приложения.</returns>
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x0005B442 File Offset: 0x00059642
		public static AppDomain CurrentDomain
		{
			get
			{
				return AppDomain.getCurDomain();
			}
		}

		// Token: 0x0600176F RID: 5999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AppDomain getRootDomain();

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x0005B44C File Offset: 0x0005964C
		internal static AppDomain DefaultDomain
		{
			get
			{
				if (AppDomain.default_domain == null)
				{
					AppDomain rootDomain = AppDomain.getRootDomain();
					if (rootDomain == AppDomain.CurrentDomain)
					{
						AppDomain.default_domain = rootDomain;
					}
					else
					{
						AppDomain.default_domain = (AppDomain)RemotingServices.GetDomainProxy(rootDomain);
					}
				}
				return AppDomain.default_domain;
			}
		}

		/// <summary>Добавляет указанное имя каталога к закрытому списку путей.</summary>
		/// <param name="path">Имя каталога, который следует добавить в закрытый путь.</param>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x06001771 RID: 6001 RVA: 0x0005B48C File Offset: 0x0005968C
		[Obsolete("AppDomain.AppendPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead.")]
		[SecurityCritical]
		[SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public void AppendPrivatePath(string path)
		{
			if (path == null || path.Length == 0)
			{
				return;
			}
			AppDomainSetup setupInformationNoCopy = this.SetupInformationNoCopy;
			string text = setupInformationNoCopy.PrivateBinPath;
			if (text == null || text.Length == 0)
			{
				setupInformationNoCopy.PrivateBinPath = path;
				return;
			}
			text = text.Trim();
			if (text[text.Length - 1] != Path.PathSeparator)
			{
				text += Path.PathSeparator.ToString();
			}
			setupInformationNoCopy.PrivateBinPath = text + path;
		}

		/// <summary>Сбрасывает путь, указывающий на размещение закрытых сборок, присваивая ему пустую строку ("").</summary>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x06001772 RID: 6002 RVA: 0x0005B500 File Offset: 0x00059700
		[Obsolete("AppDomain.ClearPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead.")]
		[SecurityCritical]
		[SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public void ClearPrivatePath()
		{
			this.SetupInformationNoCopy.PrivateBinPath = string.Empty;
		}

		/// <summary>Сбрасывает список каталогов, содержащих теневые копии сборок, присваивая ему пустую строку ("").</summary>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x06001773 RID: 6003 RVA: 0x0005B512 File Offset: 0x00059712
		[SecurityCritical]
		[Obsolete("Use AppDomainSetup.ShadowCopyDirectories")]
		[SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public void ClearShadowCopyPath()
		{
			this.SetupInformationNoCopy.ShadowCopyDirectories = string.Empty;
		}

		/// <summary>Создает новый экземпляр заданного типа COM. Параметры задают имя файла сборки, содержащей этот тип, и имя типа.</summary>
		/// <param name="assemblyName">Имя файла, который содержит сборку, определяющую запрошенный тип.</param>
		/// <param name="typeName">Имя запрошенного типа.</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, заданного параметром <paramref name="typeName" />. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyName" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.MissingMethodException">Открытый конструктор без параметров не найден.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyName" /> не найден.</exception>
		/// <exception cref="T:System.MemberAccessException">
		///   <paramref name="typeName" /> является абстрактным классом.  
		/// -или- 
		/// Этот элемент был вызван при помощи механизма позднего связывания.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="assemblyName" /> является пустой строкой ("").</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.NullReferenceException">Указанный объект COM равен <see langword="null" />.</exception>
		// Token: 0x06001774 RID: 6004 RVA: 0x0005B524 File Offset: 0x00059724
		public ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName)
		{
			return Activator.CreateComInstanceFrom(assemblyName, typeName);
		}

		/// <summary>Создает новый экземпляр заданного типа COM. Параметры задают имя файла сборки, содержащей этот тип, и имя типа.</summary>
		/// <param name="assemblyFile">Имя файла, который содержит сборку, определяющую запрошенный тип.</param>
		/// <param name="typeName">Имя запрошенного типа.</param>
		/// <param name="hashValue">Представляет значение вычисляемого хэш-кода.</param>
		/// <param name="hashAlgorithm">Представляет хэш-алгоритм, используемый манифестом сборки.</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, заданного параметром <paramref name="typeName" />. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyName" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.MissingMethodException">Открытый конструктор без параметров не найден.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyFile" /> не найден.</exception>
		/// <exception cref="T:System.MemberAccessException">
		///   <paramref name="typeName" /> является абстрактным классом.  
		/// -или- 
		/// Этот элемент был вызван при помощи механизма позднего связывания.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="assemblyFile" /> является пустой строкой ("").</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.NullReferenceException">Указанный объект COM равен <see langword="null" />.</exception>
		// Token: 0x06001775 RID: 6005 RVA: 0x0005B52D File Offset: 0x0005972D
		public ObjectHandle CreateComInstanceFrom(string assemblyFile, string typeName, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
		{
			return Activator.CreateComInstanceFrom(assemblyFile, typeName, hashValue, hashAlgorithm);
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0005B539 File Offset: 0x00059739
		internal ObjectHandle InternalCreateInstanceWithNoSecurity(string assemblyName, string typeName)
		{
			return this.CreateInstance(assemblyName, typeName);
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x0005B544 File Offset: 0x00059744
		internal ObjectHandle InternalCreateInstanceWithNoSecurity(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
		{
			return this.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0005B566 File Offset: 0x00059766
		internal ObjectHandle InternalCreateInstanceFromWithNoSecurity(string assemblyName, string typeName)
		{
			return this.CreateInstanceFrom(assemblyName, typeName);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x0005B570 File Offset: 0x00059770
		internal ObjectHandle InternalCreateInstanceFromWithNoSecurity(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
		{
			return this.CreateInstanceFrom(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в указанной сборке.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, заданного параметром <paramref name="typeName" />. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyName" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Этот экземпляр имеет значение <see langword="null" />.</exception>
		// Token: 0x0600177A RID: 6010 RVA: 0x0005B592 File Offset: 0x00059792
		public ObjectHandle CreateInstance(string assemblyName, string typeName)
		{
			if (assemblyName == null)
			{
				throw new ArgumentNullException("assemblyName");
			}
			return Activator.CreateInstance(assemblyName, typeName);
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в указанной сборке. Параметр определяет массив атрибутов активации.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Обычно это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.    
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, заданного параметром <paramref name="typeName" />. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyName" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		/// -или- 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Этот экземпляр имеет значение <see langword="null" />.</exception>
		// Token: 0x0600177B RID: 6011 RVA: 0x0005B5A9 File Offset: 0x000597A9
		public ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes)
		{
			if (assemblyName == null)
			{
				throw new ArgumentNullException("assemblyName");
			}
			return Activator.CreateInstance(assemblyName, typeName, activationAttributes);
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в указанной сборке. Параметры определяют средство связывания, флаги привязки, аргументы конструктора, сведения, связанные с языком и региональными параметрами, используемые для интерпретации аргументов, атрибуты активации и авторизацию для создания типа.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при поиске.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see cref="T:System.Reflection.MemberInfo" /> с помощью отражения. Если параметр <paramref name="binder" /> имеет значение null, то используется модуль привязки по умолчанию.</param>
		/// <param name="args">Аргументы для передачи конструктору. Массив аргументов должен соответствовать по числу, порядку и типу параметров вызываемому конструктору. Если предпочтителен конструктор по умолчанию, то объект <paramref name="args" /> должен быть пустым массивом или значением null.</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Обычно это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.    
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <param name="securityAttributes">Сведения, используемые для авторизации создания <paramref name="typeName" />.</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, заданного параметром <paramref name="typeName" />. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyName" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.  
		/// -или- 
		///  <paramref name="securityAttributes" /> не является <see langword="null" />. Когда устаревшие политики разграничения доступа кода не включены, <paramref name="securityAttributes" /> должен равняться <see langword="null." />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Этот экземпляр имеет значение <see langword="null" />.</exception>
		// Token: 0x0600177C RID: 6012 RVA: 0x0005B5C4 File Offset: 0x000597C4
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
		{
			if (assemblyName == null)
			{
				throw new ArgumentNullException("assemblyName");
			}
			return Activator.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
		}

		/// <summary>Создает новый экземпляр заданного типа. Параметры задают сборку, где определен тип, и имя типа.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <returns>Экземпляр объекта, заданного параметром <paramref name="typeName" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyName" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		/// -или- 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x0600177D RID: 6013 RVA: 0x0005B5F4 File Offset: 0x000597F4
		public object CreateInstanceAndUnwrap(string assemblyName, string typeName)
		{
			ObjectHandle objectHandle = this.CreateInstance(assemblyName, typeName);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		/// <summary>Создает новый экземпляр заданного типа. Параметры задают сборку, где определен тип, имя типа и массив атрибутов активации.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Обычно это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.    
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Экземпляр объекта, заданного параметром <paramref name="typeName" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyName" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x0600177E RID: 6014 RVA: 0x0005B618 File Offset: 0x00059818
		public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes)
		{
			ObjectHandle objectHandle = this.CreateInstance(assemblyName, typeName, activationAttributes);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		/// <summary>Создает новый экземпляр заданного типа. Параметры определяют имя типа, а также способ его поиска и создания.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при поиске.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see cref="T:System.Reflection.MemberInfo" /> с помощью отражения. Если параметр <paramref name="binder" /> имеет значение null, то используется модуль привязки по умолчанию.</param>
		/// <param name="args">Аргументы для передачи конструктору. Массив аргументов должен соответствовать по числу, порядку и типу параметров вызываемому конструктору. Если предпочтителен конструктор по умолчанию, то объект <paramref name="args" /> должен быть пустым массивом или значением null.</param>
		/// <param name="culture">Объект, зависящий от языка и региональных параметров, который используется для управления приведением типов. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see langword="CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Обычно это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.    
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <param name="securityAttributes">Сведения, используемые для авторизации создания <paramref name="typeName" />.</param>
		/// <returns>Экземпляр объекта, заданного параметром <paramref name="typeName" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyName" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		/// -или- 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x0600177F RID: 6015 RVA: 0x0005B63C File Offset: 0x0005983C
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
		{
			ObjectHandle objectHandle = this.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в указанной сборке. Параметры определяют средство связывания, флаги привязки, аргументы конструктора, сведения, связанные с языком и региональными параметрами, используемые для интерпретации аргументов, и необязательные атрибуты активации.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при поиске.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see cref="T:System.Reflection.MemberInfo" /> с помощью отражения. Если параметр <paramref name="binder" /> имеет значение null, то используется модуль привязки по умолчанию.</param>
		/// <param name="args">Аргументы для передачи конструктору. Массив аргументов должен соответствовать по числу, порядку и типу параметров вызываемому конструктору. Если предпочтителен конструктор по умолчанию, то объект <paramref name="args" /> должен быть пустым массивом или значением null.</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Обычно это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.    
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, заданного параметром <paramref name="typeName" />. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyName" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		///
		/// или - 
		/// Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Этот экземпляр имеет значение <see langword="null" />.</exception>
		// Token: 0x06001780 RID: 6016 RVA: 0x0005B66C File Offset: 0x0005986C
		public ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			if (assemblyName == null)
			{
				throw new ArgumentNullException("assemblyName");
			}
			return Activator.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, null);
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в заданной сборке, указывая, игнорируется ли регистр имени типа; атрибуты привязки и средство привязки, используемые для выбора создаваемого типа; аргументы конструктора; язык и региональные параметры; и атрибуты активации.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при поиске.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, позволяющий осуществлять привязку, приведение типов аргументов, вызов элементов, а также поиск объектов <see cref="T:System.Reflection.MemberInfo" /> с помощью отражения. Если параметр <paramref name="binder" /> имеет значение null, то используется модуль привязки по умолчанию.</param>
		/// <param name="args">Аргументы для передачи конструктору. Массив аргументов должен соответствовать по числу, порядку и типу параметров вызываемому конструктору. Если предпочтителен конструктор по умолчанию, то объект <paramref name="args" /> должен быть пустым массивом или значением null.</param>
		/// <param name="culture">Объект, зависящий от языка и региональных параметров, который используется для управления приведением типов. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see langword="CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Как правило, массив, который содержит единственный объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />. который определяет URL-адрес, необходимый для активации удаленного объекта.  
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Экземпляр объекта, заданного параметром <paramref name="typeName" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyName" /> или <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий конструктор не найден.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typename" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет разрешения на вызов этого конструктора.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		/// -или- 
		///  Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x06001781 RID: 6017 RVA: 0x0005B69C File Offset: 0x0005989C
		public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			ObjectHandle objectHandle = this.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в указанном файле сборки.</summary>
		/// <param name="assemblyFile">Имя (включая путь) файла, который содержит сборку, определяющую запрошенный тип. Эта сборка загружается с помощью метода <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при поиске.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который допускает привязку, приведение типов аргументов, вызов элементов и извлечение объектов <see cref="T:System.Reflection.MemberInfo" /> путем отражения. Если параметр <paramref name="binder" /> имеет значение null, то используется модуль привязки по умолчанию.</param>
		/// <param name="args">Аргументы для передачи конструктору. Массив аргументов должен соответствовать по числу, порядку и типу параметров вызываемому конструктору. Если предпочтителен конструктор по умолчанию, то объект <paramref name="args" /> должен быть пустым массивом или значением null.</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Обычно это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.    
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, или значение <see langword="null" />, если объект <paramref name="typeName" /> не найден. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typeName" /> в <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет достаточно разрешений для вызова этого конструктора.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		/// -или- 
		///  Сборка <paramref name="assemblyFile" /> была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.NullReferenceException">Этот экземпляр имеет значение <see langword="null" />.</exception>
		// Token: 0x06001782 RID: 6018 RVA: 0x0005B6C8 File Offset: 0x000598C8
		public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			if (assemblyFile == null)
			{
				throw new ArgumentNullException("assemblyFile");
			}
			return Activator.CreateInstanceFrom(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, null);
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в заданном файле сборки, указывая, игнорируется ли регистр имени типа; атрибуты привязки и средство привязки, используемые для выбора создаваемого типа; аргументы конструктора; язык и региональные параметры; и атрибуты активации.</summary>
		/// <param name="assemblyFile">Имя файла и путь сборки, которая определяет запрошенный тип.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при поиске.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который допускает привязку, приведение типов аргументов, вызов элементов и извлечение объектов <see cref="T:System.Reflection.MemberInfo" /> путем отражения. Если параметр <paramref name="binder" /> имеет значение null, то используется модуль привязки по умолчанию.</param>
		/// <param name="args">Аргументы для передачи конструктору. Массив аргументов должен соответствовать по числу, порядку и типу параметров вызываемому конструктору. Если предпочтителен конструктор по умолчанию, то объект <paramref name="args" /> должен быть пустым массивом или значением null.</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Обычно это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.    
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Запрашиваемый объект или значение <see langword="null" />, если объект <paramref name="typeName" /> не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyName" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typeName" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет достаточно разрешений для вызова этого конструктора.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		/// -или- 
		///  Сборка <paramref name="assemblyName" /> скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x06001783 RID: 6019 RVA: 0x0005B6F8 File Offset: 0x000598F8
		public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			ObjectHandle objectHandle = this.CreateInstanceFrom(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в указанном файле сборки.</summary>
		/// <param name="assemblyFile">Имя (включая путь) файла, который содержит сборку, определяющую запрошенный тип. Эта сборка загружается с помощью метода <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, или значение <see langword="null" />, если объект <paramref name="typeName" /> не найден. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typeName" /> в <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.MissingMethodException">Открытый конструктор без параметров не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет достаточно разрешений для вызова этого конструктора.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		///
		/// или - 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyFile" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.NullReferenceException">Этот экземпляр имеет значение <see langword="null" />.</exception>
		// Token: 0x06001784 RID: 6020 RVA: 0x0005B724 File Offset: 0x00059924
		public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName)
		{
			if (assemblyFile == null)
			{
				throw new ArgumentNullException("assemblyFile");
			}
			return Activator.CreateInstanceFrom(assemblyFile, typeName);
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в указанном файле сборки.</summary>
		/// <param name="assemblyFile">Имя (включая путь) файла, который содержит сборку, определяющую запрошенный тип. Эта сборка загружается с помощью метода <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Обычно это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.    
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, или значение <see langword="null" />, если объект <paramref name="typeName" /> не найден. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typeName" /> в <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет достаточно разрешений для вызова этого конструктора.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		/// -или- 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyFile" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.NullReferenceException">Этот экземпляр имеет значение <see langword="null" />.</exception>
		// Token: 0x06001785 RID: 6021 RVA: 0x0005B73B File Offset: 0x0005993B
		public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes)
		{
			if (assemblyFile == null)
			{
				throw new ArgumentNullException("assemblyFile");
			}
			return Activator.CreateInstanceFrom(assemblyFile, typeName, activationAttributes);
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в указанном файле сборки.</summary>
		/// <param name="assemblyFile">Имя (включая путь) файла, который содержит сборку, определяющую запрошенный тип. Эта сборка загружается с помощью метода <see cref="M:System.Reflection.Assembly.LoadFrom(System.String)" />.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при поиске.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который допускает привязку, приведение типов аргументов, вызов элементов и извлечение объектов <see cref="T:System.Reflection.MemberInfo" /> путем отражения. Если параметр <paramref name="binder" /> имеет значение null, то используется модуль привязки по умолчанию.</param>
		/// <param name="args">Аргументы для передачи конструктору. Массив аргументов должен соответствовать по числу, порядку и типу параметров вызываемому конструктору. Если предпочтителен конструктор по умолчанию, то объект <paramref name="args" /> должен быть пустым массивом или значением null.</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Обычно это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.    
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <param name="securityAttributes">Сведения, используемые для авторизации создания <paramref name="typeName" />.</param>
		/// <returns>Объект, являющийся оболочкой для нового экземпляра, или значение <see langword="null" />, если объект <paramref name="typeName" /> не найден. Необходимо распаковать возвращенное значение, чтобы получить доступ к реальному объекту.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.  
		/// -или- 
		///  <paramref name="securityAttributes" /> не является <see langword="null" />. Если не включена политика разграничения доступа кода для кода предыдущей версии, <paramref name="securityAttributes" /> должно иметь значение <see langword="null" />.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typeName" /> в <paramref name="assemblyFile" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет достаточно разрешений для вызова этого конструктора.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимой сборкой.  
		/// -или- 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyFile" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.NullReferenceException">Этот экземпляр имеет значение <see langword="null" />.</exception>
		// Token: 0x06001786 RID: 6022 RVA: 0x0005B754 File Offset: 0x00059954
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
		{
			if (assemblyFile == null)
			{
				throw new ArgumentNullException("assemblyFile");
			}
			return Activator.CreateInstanceFrom(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в указанном файле сборки.</summary>
		/// <param name="assemblyName">Имя файла и путь сборки, которая определяет запрошенный тип.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <returns>Запрашиваемый объект или значение <see langword="null" />, если объект <paramref name="typeName" /> не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyName" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typeName" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Открытый конструктор без параметров не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет достаточно разрешений для вызова этого конструктора.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		/// -или- 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x06001787 RID: 6023 RVA: 0x0005B784 File Offset: 0x00059984
		public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName)
		{
			ObjectHandle objectHandle = this.CreateInstanceFrom(assemblyName, typeName);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в указанном файле сборки.</summary>
		/// <param name="assemblyName">Имя файла и путь сборки, которая определяет запрошенный тип.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Обычно это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.    
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <returns>Запрашиваемый объект или значение <see langword="null" />, если объект <paramref name="typeName" /> не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyName" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typeName" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Открытый конструктор без параметров не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет достаточно разрешений для вызова этого конструктора.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		/// -или- 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x06001788 RID: 6024 RVA: 0x0005B7A8 File Offset: 0x000599A8
		public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes)
		{
			ObjectHandle objectHandle = this.CreateInstanceFrom(assemblyName, typeName, activationAttributes);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		/// <summary>Создает новый экземпляр заданного типа, определенного в указанном файле сборки.</summary>
		/// <param name="assemblyName">Имя файла и путь сборки, которая определяет запрошенный тип.</param>
		/// <param name="typeName">Полное имя запрошенного типа, включая пространство имен, но не сборку (см. описание свойства <see cref="P:System.Type.FullName" />).</param>
		/// <param name="ignoreCase">Логическое значение, указывающее, следует ли учитывать регистр при поиске.</param>
		/// <param name="bindingAttr">Сочетание битовых флагов (от нуля и более), влияющих на поиск конструктора <paramref name="typeName" />. Если значение параметра <paramref name="bindingAttr" /> равно нулю, проводится поиск открытых конструкторов с учетом регистра.</param>
		/// <param name="binder">Объект, который допускает привязку, приведение типов аргументов, вызов элементов и извлечение объектов <see cref="T:System.Reflection.MemberInfo" /> путем отражения. Если параметр <paramref name="binder" /> имеет значение null, то используется модуль привязки по умолчанию.</param>
		/// <param name="args">Аргументы для передачи конструктору. Массив аргументов должен соответствовать по числу, порядку и типу параметров вызываемому конструктору. Если предпочтителен конструктор по умолчанию, то объект <paramref name="args" /> должен быть пустым массивом или значением null.</param>
		/// <param name="culture">Сведения о языке и региональных параметрах, которые влияют на приведение <paramref name="args" /> к формальным типам, объявленным для конструктора <paramref name="typeName" />. Если параметр <paramref name="culture" /> имеет значение <see langword="null" />, для текущего потока используется объект <see cref="T:System.Globalization.CultureInfo" />.</param>
		/// <param name="activationAttributes">Массив, состоящий из одного или нескольких атрибутов, которые могут участвовать в активации. Обычно это массив, содержащий один объект <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />, определяющий URL-адрес, необходимый для активации удаленного объекта.    
		/// Этот параметр связан с объектами, активируемыми клиентом. Активация клиентом — это устаревшая технология, которая сохраняется с целью обеспечения обратной совместимости; ее не рекомендуется использовать для разработки новых приложений. Сейчас в распределенных приложениях следует использовать Windows Communication Foundation.</param>
		/// <param name="securityAttributes">Сведения, используемые для авторизации создания <paramref name="typeName" />.</param>
		/// <returns>Запрашиваемый объект или значение <see langword="null" />, если объект <paramref name="typeName" /> не найден.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyName" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="typeName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Вызывающий объект не может предоставить атрибуты активации для объекта, который не является производным от <see cref="T:System.MarshalByRefObject" />.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти <paramref name="typeName" /> в <paramref name="assemblyName" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Соответствующий общий конструктор не найден.</exception>
		/// <exception cref="T:System.MethodAccessException">Вызывающий объект не имеет достаточно разрешений для вызова этого конструктора.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyName" /> не является допустимой сборкой.  
		/// -или- 
		/// В настоящий момент загружена среда CLR версии 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x06001789 RID: 6025 RVA: 0x0005B7CC File Offset: 0x000599CC
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
		{
			ObjectHandle objectHandle = this.CreateInstanceFrom(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		/// <summary>Определяет динамическую сборку с указанным именем и режимом доступа.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим доступа для динамической сборки.</param>
		/// <returns>Динамическая сборка с указанным именем и режимом доступа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		/// -или- 
		/// Свойство <see langword="Name" /> параметра <paramref name="name" /> начинается с пробела или содержит прямую либо обратную косую черту.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x0600178A RID: 6026 RVA: 0x0005B7FC File Offset: 0x000599FC
		[SecuritySafeCritical]
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access)
		{
			return this.DefineDynamicAssembly(name, access, null, null, null, null, null, false);
		}

		/// <summary>Определяет динамическую сборку с помощью указанного имени, режима доступа и свидетельства.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="evidence">Свидетельство, предоставляемое для динамической сборки. Используемое свидетельство является постоянным, как конечный набор свидетельств, используемых для разрешения политики.</param>
		/// <returns>Динамическая сборка с указанным именем и возможностями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		/// -или- 
		/// Свойство <see langword="Name" /> параметра <paramref name="name" /> начинается с пробела или содержит прямую либо обратную косую черту.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x0600178B RID: 6027 RVA: 0x0005B818 File Offset: 0x00059A18
		[Obsolete("Declarative security for assembly level is no longer enforced")]
		[SecuritySafeCritical]
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence)
		{
			return this.DefineDynamicAssembly(name, access, null, evidence, null, null, null, false);
		}

		/// <summary>Определяет динамическую сборку с помощью указанного имени, режима доступа и каталога хранения.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="dir">Имя папки, в которой будет сохранена сборка. Если параметр <paramref name="dir" /> имеет значение <see langword="null" />, по умолчанию используется текущий каталог.</param>
		/// <returns>Динамическая сборка с указанным именем и возможностями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		/// -или- 
		/// Свойство <see langword="Name" /> параметра <paramref name="name" /> начинается с пробела или содержит прямую либо обратную косую черту.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x0600178C RID: 6028 RVA: 0x0005B834 File Offset: 0x00059A34
		[SecuritySafeCritical]
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir)
		{
			return this.DefineDynamicAssembly(name, access, dir, null, null, null, null, false);
		}

		/// <summary>Определяет динамическую сборку с помощью указанного имени, режима доступа, каталога хранения и свидетельства.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="dir">Имя папки, в которой будет сохранена сборка. Если параметр <paramref name="dir" /> имеет значение <see langword="null" />, по умолчанию используется текущий каталог.</param>
		/// <param name="evidence">Свидетельство, предоставляемое для динамической сборки. Используемое свидетельство является постоянным, как конечный набор свидетельств, используемых для разрешения политики.</param>
		/// <returns>Динамическая сборка с указанным именем и возможностями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		/// -или- 
		/// Свойство <see langword="Name" /> параметра <paramref name="name" /> начинается с пробела или содержит прямую либо обратную косую черту.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x0600178D RID: 6029 RVA: 0x0005B850 File Offset: 0x00059A50
		[Obsolete("Declarative security for assembly level is no longer enforced")]
		[SecuritySafeCritical]
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence)
		{
			return this.DefineDynamicAssembly(name, access, dir, evidence, null, null, null, false);
		}

		/// <summary>Определяет динамическую сборку с помощью указанного имени, режима доступа и запросов разрешений.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="requiredPermissions">Запрос обязательных разрешений.</param>
		/// <param name="optionalPermissions">Запрос дополнительных разрешений.</param>
		/// <param name="refusedPermissions">Запрос разрешений, в которых отказано.</param>
		/// <returns>Динамическая сборка с указанным именем и возможностями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		/// -или- 
		/// Свойство <see langword="Name" /> параметра <paramref name="name" /> начинается с пробела или содержит прямую либо обратную косую черту.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x0600178E RID: 6030 RVA: 0x0005B86C File Offset: 0x00059A6C
		[Obsolete("Declarative security for assembly level is no longer enforced")]
		[SecuritySafeCritical]
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
		{
			return this.DefineDynamicAssembly(name, access, null, null, requiredPermissions, optionalPermissions, refusedPermissions, false);
		}

		/// <summary>Определяет динамическую сборку с помощью указанного имени, режима доступа, свидетельства и запросов разрешений.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="evidence">Свидетельство, предоставляемое для динамической сборки. Используемое свидетельство является постоянным, как конечный набор свидетельств, используемых для разрешения политики.</param>
		/// <param name="requiredPermissions">Запрос обязательных разрешений.</param>
		/// <param name="optionalPermissions">Запрос дополнительных разрешений.</param>
		/// <param name="refusedPermissions">Запрос разрешений, в которых отказано.</param>
		/// <returns>Динамическая сборка с указанным именем и возможностями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		///
		/// или - 
		/// Свойство <see langword="Name" /> параметра <paramref name="name" /> начинается с пробела или содержит прямую либо обратную косую черту.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x0600178F RID: 6031 RVA: 0x0005B88C File Offset: 0x00059A8C
		[Obsolete("Declarative security for assembly level is no longer enforced")]
		[SecuritySafeCritical]
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
		{
			return this.DefineDynamicAssembly(name, access, null, evidence, requiredPermissions, optionalPermissions, refusedPermissions, false);
		}

		/// <summary>Определяет динамическую сборку с помощью указанного имени, режима доступа, каталога хранения и запросов разрешений.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="dir">Имя папки, в которой будет сохранена сборка. Если параметр <paramref name="dir" /> имеет значение <see langword="null" />, по умолчанию используется текущий каталог.</param>
		/// <param name="requiredPermissions">Запрос обязательных разрешений.</param>
		/// <param name="optionalPermissions">Запрос дополнительных разрешений.</param>
		/// <param name="refusedPermissions">Запрос разрешений, в которых отказано.</param>
		/// <returns>Динамическая сборка с указанным именем и возможностями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		/// -или- 
		/// Свойство <see langword="Name" /> параметра <paramref name="name" /> начинается с пробела или содержит прямую либо обратную косую черту.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x06001790 RID: 6032 RVA: 0x0005B8AC File Offset: 0x00059AAC
		[SecuritySafeCritical]
		[Obsolete("Declarative security for assembly level is no longer enforced")]
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
		{
			return this.DefineDynamicAssembly(name, access, dir, null, requiredPermissions, optionalPermissions, refusedPermissions, false);
		}

		/// <summary>Определяет динамическую сборку с помощью указанного имени, режима доступа, каталога хранения, свидетельства и запросов разрешений.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="dir">Имя папки, в которой будет сохранена сборка. Если параметр <paramref name="dir" /> имеет значение <see langword="null" />, по умолчанию используется текущий каталог.</param>
		/// <param name="evidence">Свидетельство, предоставляемое для динамической сборки. Используемое свидетельство является постоянным, как конечный набор свидетельств, используемых для разрешения политики.</param>
		/// <param name="requiredPermissions">Запрос обязательных разрешений.</param>
		/// <param name="optionalPermissions">Запрос дополнительных разрешений.</param>
		/// <param name="refusedPermissions">Запрос разрешений, в которых отказано.</param>
		/// <returns>Динамическая сборка с указанным именем и возможностями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		///
		/// или - 
		/// Свойство <see langword="Name" /> параметра <paramref name="name" /> начинается с пробела или содержит прямую либо обратную косую черту.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x06001791 RID: 6033 RVA: 0x0005B8CC File Offset: 0x00059ACC
		[Obsolete("Declarative security for assembly level is no longer enforced")]
		[SecuritySafeCritical]
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
		{
			return this.DefineDynamicAssembly(name, access, dir, evidence, requiredPermissions, optionalPermissions, refusedPermissions, false);
		}

		/// <summary>Определяет динамическую сборку с помощью указанного имени, режима доступа, каталога хранения, свидетельства, запросов разрешений и параметра синхронизации.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="dir">Имя каталога, в котором будет сохранена динамическая сборка. Если параметр <paramref name="dir" /> имеет значение <see langword="null" />, по умолчанию используется текущий каталог.</param>
		/// <param name="evidence">Свидетельство, предоставляемое для динамической сборки. Используемое свидетельство является постоянным, как конечный набор свидетельств, используемых для разрешения политики.</param>
		/// <param name="requiredPermissions">Запрос обязательных разрешений.</param>
		/// <param name="optionalPermissions">Запрос дополнительных разрешений.</param>
		/// <param name="refusedPermissions">Запрос разрешений, в которых отказано.</param>
		/// <param name="isSynchronized">Значение <see langword="true" />, чтобы синхронизировать создание модулей, типов и членов в динамической сборке, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Динамическая сборка с указанным именем и возможностями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		/// -или- 
		/// Свойство <see langword="Name" /> параметра <paramref name="name" /> начинается с пробела или содержит прямую либо обратную косую черту.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x06001792 RID: 6034 RVA: 0x0005B8EB File Offset: 0x00059AEB
		[Obsolete("Declarative security for assembly level is no longer enforced")]
		[SecuritySafeCritical]
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			AppDomain.ValidateAssemblyName(name.Name);
			AssemblyBuilder assemblyBuilder = new AssemblyBuilder(name, dir, access, false);
			assemblyBuilder.AddPermissionRequests(requiredPermissions, optionalPermissions, refusedPermissions);
			return assemblyBuilder;
		}

		/// <summary>Определяет динамическую сборку с помощью указанного имени, режима доступа, каталога хранения, свидетельства, запросов разрешений, параметра синхронизации и настраиваемых атрибутов.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="dir">Имя каталога, в котором будет сохранена динамическая сборка. Если параметр <paramref name="dir" /> имеет значение <see langword="null" />, используется текущий каталог.</param>
		/// <param name="evidence">Свидетельство, предоставленное для динамической сборки. Используемое свидетельство является постоянным, как конечный набор свидетельств, используемых для разрешения политики.</param>
		/// <param name="requiredPermissions">Запрос обязательных разрешений.</param>
		/// <param name="optionalPermissions">Запрос дополнительных разрешений.</param>
		/// <param name="refusedPermissions">Запрос разрешений, в которых отказано.</param>
		/// <param name="isSynchronized">Значение <see langword="true" />, чтобы синхронизировать создание модулей, типов и членов в динамической сборке, в противном случае — значение <see langword="false" />.</param>
		/// <param name="assemblyAttributes">Перечислимый список атрибутов, которые будут применены к сборке, или значение <see langword="null" />, если атрибуты отсутствуют.</param>
		/// <returns>Динамическая сборка с указанным именем и возможностями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		/// -или- 
		/// Значение свойства <see langword="Name" /> объекта <paramref name="name" /> начинается с пробела или содержит символ прямой (обратной) косой черты.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x06001793 RID: 6035 RVA: 0x0005B91C File Offset: 0x00059B1C
		[Obsolete("Declarative security for assembly level is no longer enforced")]
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
		{
			AssemblyBuilder assemblyBuilder = this.DefineDynamicAssembly(name, access, dir, evidence, requiredPermissions, optionalPermissions, refusedPermissions, isSynchronized);
			if (assemblyAttributes != null)
			{
				foreach (CustomAttributeBuilder customAttribute in assemblyAttributes)
				{
					assemblyBuilder.SetCustomAttribute(customAttribute);
				}
			}
			return assemblyBuilder;
		}

		/// <summary>Определяет динамическую сборку с указанным именем, режимом доступа и настраиваемыми атрибутами.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим доступа для динамической сборки.</param>
		/// <param name="assemblyAttributes">Перечислимый список атрибутов, которые будут применены к сборке, или значение <see langword="null" />, если атрибуты отсутствуют.</param>
		/// <returns>Динамическая сборка с указанным именем и возможностями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		/// -или- 
		/// Значение свойства <see langword="Name" /> объекта <paramref name="name" /> начинается с пробела или содержит символ прямой (обратной) косой черты.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x06001794 RID: 6036 RVA: 0x0005B980 File Offset: 0x00059B80
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
		{
			return this.DefineDynamicAssembly(name, access, null, null, null, null, null, false, assemblyAttributes);
		}

		/// <summary>Определяет динамическую сборку с помощью указанного имени, режима доступа, каталога хранения и варианта синхронизации.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим, в котором будет осуществляться доступ к динамической сборке.</param>
		/// <param name="dir">Имя каталога, в котором будет сохранена динамическая сборка. Если параметр <paramref name="dir" /> имеет значение <see langword="null" />, используется текущий каталог.</param>
		/// <param name="isSynchronized">Значение <see langword="true" />, чтобы синхронизировать создание модулей, типов и членов в динамической сборке, в противном случае — значение <see langword="false" />.</param>
		/// <param name="assemblyAttributes">Перечислимый список атрибутов, которые будут применены к сборке, или значение <see langword="null" />, если атрибуты отсутствуют.</param>
		/// <returns>Динамическая сборка с указанным именем и возможностями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		/// -или- 
		/// Значение свойства <see langword="Name" /> объекта <paramref name="name" /> начинается с пробела или содержит символ прямой (обратной) косой черты.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x06001795 RID: 6037 RVA: 0x0005B99C File Offset: 0x00059B9C
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, bool isSynchronized, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
		{
			return this.DefineDynamicAssembly(name, access, dir, null, null, null, null, isSynchronized, assemblyAttributes);
		}

		/// <summary>Определяет динамическую сборку с помощью указанного имени, режима доступа и настраиваемых атрибутов, а также используя заданный источник для контекста безопасности.</summary>
		/// <param name="name">Уникальный идентификатор динамической сборки.</param>
		/// <param name="access">Режим доступа для динамической сборки.</param>
		/// <param name="assemblyAttributes">Перечислимый список атрибутов, которые будут применены к сборке, или значение <see langword="null" />, если атрибуты отсутствуют.</param>
		/// <param name="securityContextSource">Источник контекста безопасности.</param>
		/// <returns>Динамическая сборка с указанным именем и возможностями.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <see langword="Name" /> параметра <paramref name="name" /> равно <see langword="null" />.  
		/// -или- 
		/// Значение свойства <see langword="Name" /> объекта <paramref name="name" /> начинается с пробела или содержит символ прямой (обратной) косой черты.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="securityContextSource" /> не является одним из значений перечисления.</exception>
		// Token: 0x06001796 RID: 6038 RVA: 0x0005B9BA File Offset: 0x00059BBA
		[MonoLimitation("The argument securityContextSource is ignored")]
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes, SecurityContextSource securityContextSource)
		{
			return this.DefineDynamicAssembly(name, access, assemblyAttributes);
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0005B9C5 File Offset: 0x00059BC5
		internal AssemblyBuilder DefineInternalDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access)
		{
			return new AssemblyBuilder(name, null, access, true);
		}

		/// <summary>Выполняет код в другом домене приложения, который определен заданным делегатом.</summary>
		/// <param name="callBackDelegate">Делегат, определяющий вызываемый метод.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="callBackDelegate" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001798 RID: 6040 RVA: 0x0005B9D0 File Offset: 0x00059BD0
		public void DoCallBack(CrossAppDomainDelegate callBackDelegate)
		{
			if (callBackDelegate != null)
			{
				callBackDelegate();
			}
		}

		/// <summary>Выполняет сборку, содержащуюся в указанном файле.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, которую необходимо выполнить.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyFile" /> не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимым именем сборки.  
		/// -или- 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="assemblyFile" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.MissingMethodException">Указанная сборка не имеет точку входа.</exception>
		// Token: 0x06001799 RID: 6041 RVA: 0x0005B9DB File Offset: 0x00059BDB
		public int ExecuteAssembly(string assemblyFile)
		{
			return this.ExecuteAssembly(assemblyFile, null, null);
		}

		/// <summary>Выполняет сборку, содержащуюся в указанном файле, с использованием заданного свидетельства.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, которую необходимо выполнить.</param>
		/// <param name="assemblySecurity">Свидетельство для загрузки сборки.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyFile" /> не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимым именем сборки.  
		/// -или- 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="assemblyFile" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.MissingMethodException">Указанная сборка не имеет точку входа.</exception>
		// Token: 0x0600179A RID: 6042 RVA: 0x0005B9E6 File Offset: 0x00059BE6
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity)
		{
			return this.ExecuteAssembly(assemblyFile, assemblySecurity, null);
		}

		/// <summary>Выполняет сборку, содержащуюся в указанном файле, с использованием заданного свидетельства и аргументов.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, которую необходимо выполнить.</param>
		/// <param name="assemblySecurity">Предоставленное свидетельство для сборки.</param>
		/// <param name="args">Аргументы, передаваемые в точку входа сборки.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyFile" /> не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимым именем сборки.  
		///
		/// или - 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="assemblyFile" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="assemblySecurity" /> не является <see langword="null" />. Если не включена политика разграничения доступа кода для кода предыдущей версии, <paramref name="assemblySecurity" /> должно иметь значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Указанная сборка не имеет точку входа.</exception>
		// Token: 0x0600179B RID: 6043 RVA: 0x0005B9F4 File Offset: 0x00059BF4
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args)
		{
			Assembly a = Assembly.LoadFrom(assemblyFile, assemblySecurity);
			return this.ExecuteAssemblyInternal(a, args);
		}

		/// <summary>Выполняет сборку, содержащуюся в указанном файле, с использованием заданного свидетельства, аргументов, хэш-значения и хэш-алгоритма.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, которую необходимо выполнить.</param>
		/// <param name="assemblySecurity">Предоставленное свидетельство для сборки.</param>
		/// <param name="args">Аргументы, передаваемые в точку входа сборки.</param>
		/// <param name="hashValue">Представляет значение вычисляемого хэш-кода.</param>
		/// <param name="hashAlgorithm">Представляет хэш-алгоритм, используемый манифестом сборки.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyFile" /> не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимым именем сборки.  
		/// -или- 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="assemblyFile" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="assemblySecurity" /> не является <see langword="null" />. Если не включена политика разграничения доступа кода для кода предыдущей версии, <paramref name="assemblySecurity" /> должно иметь значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Указанная сборка не имеет точку входа.</exception>
		// Token: 0x0600179C RID: 6044 RVA: 0x0005BA14 File Offset: 0x00059C14
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
		{
			Assembly a = Assembly.LoadFrom(assemblyFile, assemblySecurity, hashValue, hashAlgorithm);
			return this.ExecuteAssemblyInternal(a, args);
		}

		/// <summary>Выполняет сборку, содержащуюся в указанном файле, с использованием заданных аргументов.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, которую необходимо выполнить.</param>
		/// <param name="args">Аргументы, передаваемые в точку входа сборки.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyFile" /> не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимым именем сборки.  
		/// -или- 
		///  Сборка <paramref name="assemblyFile" /> была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.MissingMethodException">Указанная сборка не имеет точку входа.</exception>
		// Token: 0x0600179D RID: 6045 RVA: 0x0005BA38 File Offset: 0x00059C38
		public int ExecuteAssembly(string assemblyFile, string[] args)
		{
			Assembly a = Assembly.LoadFrom(assemblyFile, null);
			return this.ExecuteAssemblyInternal(a, args);
		}

		/// <summary>Выполняет сборку, содержащуюся в указанном файле, с использованием заданных аргументов, хэш-значения и хэш-алгоритма.</summary>
		/// <param name="assemblyFile">Имя файла, содержащего сборку, которую необходимо выполнить.</param>
		/// <param name="args">Аргументы, передаваемые в точку входа сборки.</param>
		/// <param name="hashValue">Представляет значение вычисляемого хэш-кода.</param>
		/// <param name="hashAlgorithm">Представляет хэш-алгоритм, используемый манифестом сборки.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyFile" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyFile" /> не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyFile" /> не является допустимым именем сборки.  
		///
		/// или - 
		/// Сборка <paramref name="assemblyFile" /> была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.MissingMethodException">Указанная сборка не имеет точку входа.</exception>
		// Token: 0x0600179E RID: 6046 RVA: 0x0005BA58 File Offset: 0x00059C58
		public int ExecuteAssembly(string assemblyFile, string[] args, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
		{
			Assembly a = Assembly.LoadFrom(assemblyFile, null, hashValue, hashAlgorithm);
			return this.ExecuteAssemblyInternal(a, args);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0005BA78 File Offset: 0x00059C78
		private int ExecuteAssemblyInternal(Assembly a, string[] args)
		{
			if (a.EntryPoint == null)
			{
				throw new MissingMethodException("Entry point not found in assembly '" + a.FullName + "'.");
			}
			return this.ExecuteAssembly(a, args);
		}

		// Token: 0x060017A0 RID: 6048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int ExecuteAssembly(Assembly a, string[] args);

		// Token: 0x060017A1 RID: 6049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Assembly[] GetAssemblies(bool refOnly);

		/// <summary>Возвращает сборки, которые были загружены в контекст выполнения этого домена приложения.</summary>
		/// <returns>Массив сборок в этом домене приложения.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x060017A2 RID: 6050 RVA: 0x0005BAAB File Offset: 0x00059CAB
		public Assembly[] GetAssemblies()
		{
			return this.GetAssemblies(false);
		}

		/// <summary>Возвращает значение, сохраненное в текущем домене приложения для заданного имени.</summary>
		/// <param name="name">Имя предопределенного свойства домена приложения или имя определенного вами свойства домена приложения.</param>
		/// <returns>Значение свойства <paramref name="name" /> или значение <see langword="null" />, если это свойство не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x060017A3 RID: 6051
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern object GetData(string name);

		/// <summary>Возвращает тип текущего экземпляра.</summary>
		/// <returns>Тип текущего экземпляра.</returns>
		// Token: 0x060017A4 RID: 6052 RVA: 0x00047210 File Offset: 0x00045410
		public new Type GetType()
		{
			return base.GetType();
		}

		/// <summary>Предоставляет объекту <see cref="T:System.AppDomain" /> бесконечное время существования, предотвращая создание аренды.</summary>
		/// <returns>Всегда <see langword="null" />.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x060017A5 RID: 6053 RVA: 0x0000AF5E File Offset: 0x0000915E
		[SecurityCritical]
		public override object InitializeLifetimeService()
		{
			return null;
		}

		// Token: 0x060017A6 RID: 6054
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark);

		/// <summary>Загружает сборку <see cref="T:System.Reflection.Assembly" />, заданную ее именем <see cref="T:System.Reflection.AssemblyName" />.</summary>
		/// <param name="assemblyRef">Объект, который описывает сборку, подлежащую загрузке.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyRef" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyRef" /> не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyRef" /> не является допустимым именем сборки.  
		///
		/// или - 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="assemblyRef" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x060017A7 RID: 6055 RVA: 0x0005BAB4 File Offset: 0x00059CB4
		[SecuritySafeCritical]
		public Assembly Load(AssemblyName assemblyRef)
		{
			return this.Load(assemblyRef, null);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x0005BABE File Offset: 0x00059CBE
		internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError, ref StackCrawlMark stackMark)
		{
			if (assemblyRef == null)
			{
				throw new ArgumentNullException("assemblyRef");
			}
			Assembly assembly = this.LoadAssembly(assemblyRef.FullName, null, false, ref stackMark);
			if (assembly == null && throwOnError)
			{
				throw new FileNotFoundException(null, assemblyRef.Name);
			}
			return assembly;
		}

		/// <summary>Загружает сборку <see cref="T:System.Reflection.Assembly" />, заданную ее именем <see cref="T:System.Reflection.AssemblyName" />.</summary>
		/// <param name="assemblyRef">Объект, который описывает сборку, подлежащую загрузке.</param>
		/// <param name="assemblySecurity">Свидетельство для загрузки сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyRef" /> равно <see langword="null" /></exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyRef" /> не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyRef" /> не является допустимым именем сборки.  
		/// -или- 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="assemblyRef" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x060017A9 RID: 6057 RVA: 0x0005BAF8 File Offset: 0x00059CF8
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity)
		{
			if (assemblyRef == null)
			{
				throw new ArgumentNullException("assemblyRef");
			}
			if (assemblyRef.Name == null || assemblyRef.Name.Length == 0)
			{
				if (assemblyRef.CodeBase != null)
				{
					return Assembly.LoadFrom(assemblyRef.CodeBase, assemblySecurity);
				}
				throw new ArgumentException(Locale.GetText("assemblyRef.Name cannot be empty."), "assemblyRef");
			}
			else
			{
				StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
				Assembly assembly = this.LoadAssembly(assemblyRef.FullName, assemblySecurity, false, ref stackCrawlMark);
				if (assembly != null)
				{
					return assembly;
				}
				if (assemblyRef.CodeBase == null)
				{
					throw new FileNotFoundException(null, assemblyRef.Name);
				}
				string text = assemblyRef.CodeBase;
				if (text.StartsWith("file://", StringComparison.OrdinalIgnoreCase))
				{
					text = new Uri(text).LocalPath;
				}
				try
				{
					assembly = Assembly.LoadFrom(text, assemblySecurity);
				}
				catch
				{
					throw new FileNotFoundException(null, assemblyRef.Name);
				}
				AssemblyName name = assembly.GetName();
				if (assemblyRef.Name != name.Name)
				{
					throw new FileNotFoundException(null, assemblyRef.Name);
				}
				if (assemblyRef.Version != null && assemblyRef.Version != new Version(0, 0, 0, 0) && assemblyRef.Version != name.Version)
				{
					throw new FileNotFoundException(null, assemblyRef.Name);
				}
				if (assemblyRef.CultureInfo != null && assemblyRef.CultureInfo.Equals(name))
				{
					throw new FileNotFoundException(null, assemblyRef.Name);
				}
				byte[] publicKeyToken = assemblyRef.GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length != 0)
				{
					byte[] publicKeyToken2 = name.GetPublicKeyToken();
					if (publicKeyToken2 == null || publicKeyToken.Length != publicKeyToken2.Length)
					{
						throw new FileNotFoundException(null, assemblyRef.Name);
					}
					for (int i = publicKeyToken.Length - 1; i >= 0; i--)
					{
						if (publicKeyToken2[i] != publicKeyToken[i])
						{
							throw new FileNotFoundException(null, assemblyRef.Name);
						}
					}
				}
				return assembly;
			}
		}

		/// <summary>Загружает сборку <see cref="T:System.Reflection.Assembly" />, заданную ее отображаемым именем.</summary>
		/// <param name="assemblyString">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyString" /> равно <see langword="null" /></exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyString" /> не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyString" /> не является допустимым именем сборки.  
		/// -или- 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="assemblyString" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x060017AA RID: 6058 RVA: 0x0005BCC0 File Offset: 0x00059EC0
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Assembly Load(string assemblyString)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return this.Load(assemblyString, null, false, ref stackCrawlMark);
		}

		/// <summary>Загружает сборку <see cref="T:System.Reflection.Assembly" />, заданную ее отображаемым именем.</summary>
		/// <param name="assemblyString">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="assemblySecurity">Свидетельство для загрузки сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyString" /> равно <see langword="null" /></exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyString" /> не найден.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyString" /> не является допустимым именем сборки.  
		/// -или- 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="assemblyString" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x060017AB RID: 6059 RVA: 0x0005BCDC File Offset: 0x00059EDC
		[SecuritySafeCritical]
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Assembly Load(string assemblyString, Evidence assemblySecurity)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return this.Load(assemblyString, assemblySecurity, false, ref stackCrawlMark);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0005BCF6 File Offset: 0x00059EF6
		internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark)
		{
			if (assemblyString == null)
			{
				throw new ArgumentNullException("assemblyString");
			}
			if (assemblyString.Length == 0)
			{
				throw new ArgumentException("assemblyString cannot have zero length");
			}
			Assembly assembly = this.LoadAssembly(assemblyString, assemblySecurity, refonly, ref stackMark);
			if (assembly == null)
			{
				throw new FileNotFoundException(null, assemblyString);
			}
			return assembly;
		}

		/// <summary>Загружает объект <see cref="T:System.Reflection.Assembly" /> с образом в формате COFF, содержащим порожденный объект <see cref="T:System.Reflection.Assembly" />.</summary>
		/// <param name="rawAssembly">Массив типа <see langword="byte" />, который является образом в формате COFF, содержащим порожденную сборку.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rawAssembly" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="rawAssembly" /> не является допустимым именем сборки.  
		/// -или- 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="rawAssembly" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x060017AD RID: 6061 RVA: 0x0005BD35 File Offset: 0x00059F35
		[SecuritySafeCritical]
		public Assembly Load(byte[] rawAssembly)
		{
			return this.Load(rawAssembly, null, null);
		}

		/// <summary>Загружает объект <see cref="T:System.Reflection.Assembly" /> с образом в формате COFF, содержащим порожденный объект <see cref="T:System.Reflection.Assembly" />. Загружаются также необработанные байты, представляющие символы для <see cref="T:System.Reflection.Assembly" />.</summary>
		/// <param name="rawAssembly">Массив типа <see langword="byte" />, который является образом в формате COFF, содержащим порожденную сборку.</param>
		/// <param name="rawSymbolStore">Массив типа <see langword="byte" />, содержащий необработанные байты, которые представляют символы для сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rawAssembly" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="rawAssembly" /> не является допустимым именем сборки.  
		///
		/// или - 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="rawAssembly" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		// Token: 0x060017AE RID: 6062 RVA: 0x0005BD40 File Offset: 0x00059F40
		[SecuritySafeCritical]
		public Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore)
		{
			return this.Load(rawAssembly, rawSymbolStore, null);
		}

		// Token: 0x060017AF RID: 6063
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Assembly LoadAssemblyRaw(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence, bool refonly);

		/// <summary>Загружает объект <see cref="T:System.Reflection.Assembly" /> с образом в формате COFF, содержащим порожденный объект <see cref="T:System.Reflection.Assembly" />. Загружаются также необработанные байты, представляющие символы для <see cref="T:System.Reflection.Assembly" />.</summary>
		/// <param name="rawAssembly">Массив типа <see langword="byte" />, который является образом в формате COFF, содержащим порожденную сборку.</param>
		/// <param name="rawSymbolStore">Массив типа <see langword="byte" />, содержащий необработанные байты, которые представляют символы для сборки.</param>
		/// <param name="securityEvidence">Свидетельство для загрузки сборки.</param>
		/// <returns>Загруженная сборка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rawAssembly" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="rawAssembly" /> не является допустимым именем сборки.  
		/// -или- 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="rawAssembly" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="securityEvidence" /> не является <see langword="null" />. Если не включена политика разграничения доступа кода для кода предыдущей версии, <paramref name="securityEvidence" /> должно иметь значение <see langword="null" />.</exception>
		// Token: 0x060017B0 RID: 6064 RVA: 0x0005BD4B File Offset: 0x00059F4B
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, ControlEvidence = true)]
		public Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence)
		{
			return this.Load(rawAssembly, rawSymbolStore, securityEvidence, false);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0005BD57 File Offset: 0x00059F57
		internal Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence, bool refonly)
		{
			if (rawAssembly == null)
			{
				throw new ArgumentNullException("rawAssembly");
			}
			Assembly assembly = this.LoadAssemblyRaw(rawAssembly, rawSymbolStore, securityEvidence, refonly);
			assembly.FromByteArray = true;
			return assembly;
		}

		/// <summary>Устанавливает уровень политики безопасности для этого домена приложения.</summary>
		/// <param name="domainPolicy">Уровень политики безопасности.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="domainPolicy" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Policy.PolicyException">Установленный уровень политики безопасности.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x060017B2 RID: 6066 RVA: 0x0005BD7C File Offset: 0x00059F7C
		[Obsolete("AppDomain policy levels are obsolete")]
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, ControlPolicy = true)]
		public void SetAppDomainPolicy(PolicyLevel domainPolicy)
		{
			if (domainPolicy == null)
			{
				throw new ArgumentNullException("domainPolicy");
			}
			if (this._granted != null)
			{
				throw new PolicyException(Locale.GetText("An AppDomain policy is already specified."));
			}
			if (this.IsFinalizingForUnload())
			{
				throw new AppDomainUnloadedException();
			}
			PolicyStatement policyStatement = domainPolicy.Resolve(this._evidence);
			this._granted = policyStatement.PermissionSet;
		}

		/// <summary>Устанавливает заданный путь каталога в качестве места, куда копируются теневые сборки.</summary>
		/// <param name="path">Полный путь к расположению теневых копий.</param>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x060017B3 RID: 6067 RVA: 0x0005BDD6 File Offset: 0x00059FD6
		[Obsolete("Use AppDomainSetup.SetCachePath")]
		[SecurityCritical]
		[SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public void SetCachePath(string path)
		{
			this.SetupInformationNoCopy.CachePath = path;
		}

		/// <summary>Указывает, как участники и объекты удостоверений должны присоединяться к потоку, если поток пытается выполнить привязку к участнику при выполнении в этом домене приложения.</summary>
		/// <param name="policy">Одно из значений <see cref="T:System.Security.Principal.PrincipalPolicy" />, определяющее тип объекта-участника, который необходимо подключить к потоку.</param>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x060017B4 RID: 6068 RVA: 0x0005BDE4 File Offset: 0x00059FE4
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		public void SetPrincipalPolicy(PrincipalPolicy policy)
		{
			if (this.IsFinalizingForUnload())
			{
				throw new AppDomainUnloadedException();
			}
			this._principalPolicy = policy;
			AppDomain._principal = null;
		}

		/// <summary>Включает теневое копирование.</summary>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x060017B5 RID: 6069 RVA: 0x0005BE01 File Offset: 0x0005A001
		[Obsolete("Use AppDomainSetup.ShadowCopyFiles")]
		[SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public void SetShadowCopyFiles()
		{
			this.SetupInformationNoCopy.ShadowCopyFiles = "true";
		}

		/// <summary>Устанавливает заданный путь каталога в качестве места для теневого копирования сборок.</summary>
		/// <param name="path">Список имен каталогов, разделенных точкой с запятой.</param>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x060017B6 RID: 6070 RVA: 0x0005BE13 File Offset: 0x0005A013
		[Obsolete("Use AppDomainSetup.ShadowCopyDirectories")]
		[SecurityCritical]
		[SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public void SetShadowCopyPath(string path)
		{
			this.SetupInformationNoCopy.ShadowCopyDirectories = path;
		}

		/// <summary>Задает объект-участник по умолчанию, который необходимо присоединять к потокам, в случае если они пытаются выполнить привязку к объекту-участнику во время выполнения в этом домене приложения.</summary>
		/// <param name="principal">Объект-участник, который необходимо подключить к потоку.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="principal" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Policy.PolicyException">Установленный объект-участник потока.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x060017B7 RID: 6071 RVA: 0x0005BE21 File Offset: 0x0005A021
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		public void SetThreadPrincipal(IPrincipal principal)
		{
			if (principal == null)
			{
				throw new ArgumentNullException("principal");
			}
			if (AppDomain._principal != null)
			{
				throw new PolicyException(Locale.GetText("principal already present."));
			}
			if (this.IsFinalizingForUnload())
			{
				throw new AppDomainUnloadedException();
			}
			AppDomain._principal = principal;
		}

		// Token: 0x060017B8 RID: 6072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AppDomain InternalSetDomainByID(int domain_id);

		// Token: 0x060017B9 RID: 6073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AppDomain InternalSetDomain(AppDomain context);

		// Token: 0x060017BA RID: 6074
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalPushDomainRef(AppDomain domain);

		// Token: 0x060017BB RID: 6075
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalPushDomainRefByID(int domain_id);

		// Token: 0x060017BC RID: 6076
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalPopDomainRef();

		// Token: 0x060017BD RID: 6077
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Context InternalSetContext(Context context);

		// Token: 0x060017BE RID: 6078
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Context InternalGetContext();

		// Token: 0x060017BF RID: 6079
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Context InternalGetDefaultContext();

		// Token: 0x060017C0 RID: 6080
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string InternalGetProcessGuid(string newguid);

		// Token: 0x060017C1 RID: 6081 RVA: 0x0005BE5C File Offset: 0x0005A05C
		internal static object InvokeInDomain(AppDomain domain, MethodInfo method, object obj, object[] args)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			bool flag = false;
			object result;
			try
			{
				AppDomain.InternalPushDomainRef(domain);
				flag = true;
				AppDomain.InternalSetDomain(domain);
				Exception ex;
				object obj2 = ((RuntimeMethodInfo)method).InternalInvoke(obj, args, out ex);
				if (ex != null)
				{
					throw ex;
				}
				result = obj2;
			}
			finally
			{
				AppDomain.InternalSetDomain(currentDomain);
				if (flag)
				{
					AppDomain.InternalPopDomainRef();
				}
			}
			return result;
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0005BEB8 File Offset: 0x0005A0B8
		internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			bool flag = false;
			object result;
			try
			{
				AppDomain.InternalPushDomainRefByID(domain_id);
				flag = true;
				AppDomain.InternalSetDomainByID(domain_id);
				Exception ex;
				object obj2 = ((RuntimeMethodInfo)method).InternalInvoke(obj, args, out ex);
				if (ex != null)
				{
					throw ex;
				}
				result = obj2;
			}
			finally
			{
				AppDomain.InternalSetDomain(currentDomain);
				if (flag)
				{
					AppDomain.InternalPopDomainRef();
				}
			}
			return result;
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0005BF14 File Offset: 0x0005A114
		internal static string GetProcessGuid()
		{
			if (AppDomain._process_guid == null)
			{
				AppDomain._process_guid = AppDomain.InternalGetProcessGuid(Guid.NewGuid().ToString());
			}
			return AppDomain._process_guid;
		}

		/// <summary>Создает новый домен приложения с заданным именем.</summary>
		/// <param name="friendlyName">Понятное имя домена.</param>
		/// <returns>Вновь созданный домен приложения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="friendlyName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Метод не поддерживается в .NET Core.</exception>
		// Token: 0x060017C4 RID: 6084 RVA: 0x0005BF4A File Offset: 0x0005A14A
		public static AppDomain CreateDomain(string friendlyName)
		{
			return AppDomain.CreateDomain(friendlyName, null, null);
		}

		/// <summary>Создает новый домен приложения с заданным именем с помощью предоставленного свидетельства.</summary>
		/// <param name="friendlyName">Понятное имя домена. Это понятное имя может отображаться в пользовательском интерфейсе для определения домена. Для получения дополнительной информации см. <see cref="P:System.AppDomain.FriendlyName" />.</param>
		/// <param name="securityInfo">Свидетельство, идентифицирующее код, который выполняется в домене приложения. Передайте значение <see langword="null" /> для использования свидетельства текущего домена приложения.</param>
		/// <returns>Вновь созданный домен приложения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="friendlyName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060017C5 RID: 6085 RVA: 0x0005BF54 File Offset: 0x0005A154
		public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo)
		{
			return AppDomain.CreateDomain(friendlyName, securityInfo, null);
		}

		// Token: 0x060017C6 RID: 6086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AppDomain createDomain(string friendlyName, AppDomainSetup info);

		/// <summary>Создает новый домен приложения с использованием заданного имени, свидетельства и сведений об установке домена приложения.</summary>
		/// <param name="friendlyName">Понятное имя домена. Это понятное имя может отображаться в пользовательском интерфейсе для определения домена. Дополнительные сведения см. в разделе <see cref="P:System.AppDomain.FriendlyName" />.</param>
		/// <param name="securityInfo">Свидетельство, идентифицирующее код, который выполняется в домене приложения. Передайте значение <see langword="null" /> для использования свидетельства текущего домена приложения.</param>
		/// <param name="info">Объект, в котором содержатся сведения об инициализации домена приложения.</param>
		/// <returns>Вновь созданный домен приложения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="friendlyName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060017C7 RID: 6087 RVA: 0x0005BF60 File Offset: 0x0005A160
		[MonoLimitation("Currently it does not allow the setup in the other domain")]
		[SecurityPermission(SecurityAction.Demand, ControlAppDomain = true)]
		public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info)
		{
			if (friendlyName == null)
			{
				throw new ArgumentNullException("friendlyName");
			}
			AppDomain defaultDomain = AppDomain.DefaultDomain;
			if (info == null)
			{
				if (defaultDomain == null)
				{
					info = new AppDomainSetup();
				}
				else
				{
					info = defaultDomain.SetupInformation;
				}
			}
			else
			{
				info = new AppDomainSetup(info);
			}
			if (defaultDomain != null)
			{
				if (!info.Equals(defaultDomain.SetupInformation))
				{
					if (info.ApplicationBase == null)
					{
						info.ApplicationBase = defaultDomain.SetupInformation.ApplicationBase;
					}
					if (info.ConfigurationFile == null)
					{
						info.ConfigurationFile = Path.GetFileName(defaultDomain.SetupInformation.ConfigurationFile);
					}
				}
			}
			else if (info.ConfigurationFile == null)
			{
				info.ConfigurationFile = "[I don't have a config file]";
			}
			if (info.AppDomainInitializer != null && !info.AppDomainInitializer.Method.IsStatic)
			{
				throw new ArgumentException("Non-static methods cannot be invoked as an appdomain initializer");
			}
			info.SerializeNonPrimitives();
			AppDomain appDomain = (AppDomain)RemotingServices.GetDomainProxy(AppDomain.createDomain(friendlyName, info));
			if (securityInfo == null)
			{
				if (defaultDomain == null)
				{
					appDomain._evidence = null;
				}
				else
				{
					appDomain._evidence = defaultDomain.Evidence;
				}
			}
			else
			{
				appDomain._evidence = new Evidence(securityInfo);
			}
			if (info.AppDomainInitializer != null)
			{
				AppDomain.Loader @object = new AppDomain.Loader(info.AppDomainInitializer.Method.DeclaringType.Assembly.Location);
				appDomain.DoCallBack(new CrossAppDomainDelegate(@object.Load));
				AppDomain.Initializer object2 = new AppDomain.Initializer(info.AppDomainInitializer, info.AppDomainInitializerArguments);
				appDomain.DoCallBack(new CrossAppDomainDelegate(object2.Initialize));
			}
			return appDomain;
		}

		/// <summary>Создает новый домен приложения с заданным именем с использованием свидетельства, пути к базовой папке приложения, относительного пути поиска и параметра, указывающего, должна ли загружаться теневая копия сборки в домен приложения.</summary>
		/// <param name="friendlyName">Понятное имя домена. Это понятное имя может отображаться в пользовательском интерфейсе для определения домена. Для получения дополнительной информации см. <see cref="P:System.AppDomain.FriendlyName" />.</param>
		/// <param name="securityInfo">Свидетельство, идентифицирующее код, который выполняется в домене приложения. Передайте значение <see langword="null" /> для использования свидетельства текущего домена приложения.</param>
		/// <param name="appBasePath">Базовый каталог, в котором распознаватель сборок производит поиск. Дополнительные сведения см. в разделе <see cref="P:System.AppDomain.BaseDirectory" />.</param>
		/// <param name="appRelativeSearchPath">Путь, соответствующий базовому каталогу, в котором распознаватель сборок будет производить поиск закрытых сборок. Для получения дополнительной информации см. <see cref="P:System.AppDomain.RelativeSearchPath" />.</param>
		/// <param name="shadowCopyFiles">Если значение <see langword="true" />, теневая копия сборки загружается в этот домен приложения.</param>
		/// <returns>Вновь созданный домен приложения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="friendlyName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060017C8 RID: 6088 RVA: 0x0005C0C4 File Offset: 0x0005A2C4
		public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles)
		{
			return AppDomain.CreateDomain(friendlyName, securityInfo, AppDomain.CreateDomainSetup(appBasePath, appRelativeSearchPath, shadowCopyFiles));
		}

		/// <summary>Создает новый домен приложения с использованием заданного имени, свидетельства, сведений об установке домена приложения, используемого по умолчанию набора разрешений и массива сборок с полным доверием.</summary>
		/// <param name="friendlyName">Понятное имя домена. Это понятное имя может отображаться в пользовательском интерфейсе для определения домена. Дополнительные сведения см. в описании <see cref="P:System.AppDomain.FriendlyName" />.</param>
		/// <param name="securityInfo">Свидетельство, идентифицирующее код, который выполняется в домене приложения. Передайте значение <see langword="null" /> для использования свидетельства текущего домена приложения.</param>
		/// <param name="info">Объект, в котором содержатся сведения об инициализации домена приложения.</param>
		/// <param name="grantSet">Набор разрешений по умолчанию, который предоставляется всем сборкам, загружаемым в новый домен приложения, который не имеет специальные разрешения.</param>
		/// <param name="fullTrustAssemblies">Массив строгих имен, представляющих сборки, которые будут считаться обладающими полным доверием в новом домене приложения.</param>
		/// <returns>Вновь созданный домен приложения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="friendlyName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Домен приложения равен <see langword="null" />.  
		///
		/// или - 
		/// Свойство <see cref="P:System.AppDomainSetup.ApplicationBase" /> не задано в объекте <see cref="T:System.AppDomainSetup" />, который предоставляется для <paramref name="info" />.</exception>
		// Token: 0x060017C9 RID: 6089 RVA: 0x0005C0D6 File Offset: 0x0005A2D6
		public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info, PermissionSet grantSet, params System.Security.Policy.StrongName[] fullTrustAssemblies)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.ApplicationTrust = new ApplicationTrust(grantSet, fullTrustAssemblies ?? EmptyArray<System.Security.Policy.StrongName>.Value);
			return AppDomain.CreateDomain(friendlyName, securityInfo, info);
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x0005C108 File Offset: 0x0005A308
		private static AppDomainSetup CreateDomainSetup(string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles)
		{
			AppDomainSetup appDomainSetup = new AppDomainSetup();
			appDomainSetup.ApplicationBase = appBasePath;
			appDomainSetup.PrivateBinPath = appRelativeSearchPath;
			if (shadowCopyFiles)
			{
				appDomainSetup.ShadowCopyFiles = "true";
			}
			else
			{
				appDomainSetup.ShadowCopyFiles = "false";
			}
			return appDomainSetup;
		}

		// Token: 0x060017CB RID: 6091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool InternalIsFinalizingForUnload(int domain_id);

		/// <summary>Определяет, выгружен ли этот домен приложения, и были ли закрыты средой CLR объекты, которые он содержал.</summary>
		/// <returns>Значение <see langword="true" />, если этот домен приложения выгружен, и среда CLR начала вызов методов завершения, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060017CC RID: 6092 RVA: 0x0005C145 File Offset: 0x0005A345
		public bool IsFinalizingForUnload()
		{
			return AppDomain.InternalIsFinalizingForUnload(this.getDomainID());
		}

		// Token: 0x060017CD RID: 6093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InternalUnload(int domain_id);

		// Token: 0x060017CE RID: 6094 RVA: 0x0005C152 File Offset: 0x0005A352
		private int getDomainID()
		{
			return Thread.GetDomainID();
		}

		/// <summary>Выгружает заданный домен приложения.</summary>
		/// <param name="domain">Домен приложения, который нужно выгрузить.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="domain" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.CannotUnloadAppDomainException">Домен, определенный параметром <paramref name="domain" />, не может быть выгружен.</exception>
		/// <exception cref="T:System.Exception">Во время выполнения выгрузки произошла ошибка.</exception>
		// Token: 0x060017CF RID: 6095 RVA: 0x0005C159 File Offset: 0x0005A359
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.MayFail)]
		[SecurityPermission(SecurityAction.Demand, ControlAppDomain = true)]
		public static void Unload(AppDomain domain)
		{
			if (domain == null)
			{
				throw new ArgumentNullException("domain");
			}
			AppDomain.InternalUnload(domain.getDomainID());
		}

		/// <summary>Устанавливает заданное значение для свойства указанного домена приложения.</summary>
		/// <param name="name">Имя пользовательского свойства домена приложения, которое требуется создать или изменить.</param>
		/// <param name="data">Значение свойства.</param>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x060017D0 RID: 6096
		[SecurityCritical]
		[SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetData(string name, object data);

		/// <summary>Присваивает заданное значение заданному свойству домена приложения с заданными разрешениями, которые нужно запросить у вызывающего кода при извлечении свойства.</summary>
		/// <param name="name">Имя пользовательского свойства домена приложения, которое требуется создать или изменить.</param>
		/// <param name="data">Значение свойства.</param>
		/// <param name="permission">Разрешение, которое нужно запросить у вызывающего кода при извлечении свойства.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="name" /> задает определяемую системой строку свойства, и <paramref name="permission" /> не равно <see langword="null" />.</exception>
		// Token: 0x060017D1 RID: 6097 RVA: 0x0005C174 File Offset: 0x0005A374
		[MonoLimitation("The permission field is ignored")]
		public void SetData(string name, object data, IPermission permission)
		{
			this.SetData(name, data);
		}

		/// <summary>Устанавливает заданный путь каталога в качестве базового каталога для подкаталогов, в которых сохраняются и становятся доступными динамически созданные файлы.</summary>
		/// <param name="path">Полный путь, который является базовым каталогом для подкаталогов, в которых хранятся динамические сборки.</param>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		// Token: 0x060017D2 RID: 6098 RVA: 0x0005C17E File Offset: 0x0005A37E
		[Obsolete("Use AppDomainSetup.DynamicBase")]
		[SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public void SetDynamicBase(string path)
		{
			this.SetupInformationNoCopy.DynamicBase = path;
		}

		/// <summary>Возвращает текущий идентификатор потока.</summary>
		/// <returns>32-битовое целое число со знаком, являющееся идентификатором текущего потока.</returns>
		// Token: 0x060017D3 RID: 6099 RVA: 0x0005C18C File Offset: 0x0005A38C
		[Obsolete("AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads). To get a stable identifier for a managed thread, use the ManagedThreadId property on Thread.'")]
		public static int GetCurrentThreadId()
		{
			return Thread.CurrentThreadId;
		}

		/// <summary>Получает строку, включающую понятное имя домена приложения и политики контекста.</summary>
		/// <returns>Строка, полученная путем сцепления литеральной строки "Name:", понятного имени домена приложения и либо строкового представления политик контекста, либо строки "Политики контекста отсутствуют".</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Домен приложения, представленный текущим <see cref="T:System.AppDomain" />, выгружен.</exception>
		// Token: 0x060017D4 RID: 6100 RVA: 0x0005B32F File Offset: 0x0005952F
		[SecuritySafeCritical]
		public override string ToString()
		{
			return this.getFriendlyName();
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x0005C194 File Offset: 0x0005A394
		private static void ValidateAssemblyName(string name)
		{
			if (name == null || name.Length == 0)
			{
				throw new ArgumentException("The Name of AssemblyName cannot be null or a zero-length string.");
			}
			bool flag = true;
			for (int i = 0; i < name.Length; i++)
			{
				char c = name[i];
				if (i == 0 && char.IsWhiteSpace(c))
				{
					flag = false;
					break;
				}
				if (c == '/' || c == '\\' || c == ':')
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				throw new ArgumentException("The Name of AssemblyName cannot start with whitespace, or contain '/', '\\'  or ':'.");
			}
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x0005C202 File Offset: 0x0005A402
		private void DoAssemblyLoad(Assembly assembly)
		{
			if (this.AssemblyLoad == null)
			{
				return;
			}
			this.AssemblyLoad(this, new AssemblyLoadEventArgs(assembly));
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x0005C220 File Offset: 0x0005A420
		private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly)
		{
			ResolveEventHandler resolveEventHandler;
			if (refonly)
			{
				resolveEventHandler = this.ReflectionOnlyAssemblyResolve;
			}
			else
			{
				resolveEventHandler = this.AssemblyResolve;
			}
			if (resolveEventHandler == null)
			{
				return null;
			}
			Dictionary<string, object> dictionary;
			if (refonly)
			{
				dictionary = AppDomain.assembly_resolve_in_progress_refonly;
				if (dictionary == null)
				{
					dictionary = new Dictionary<string, object>();
					AppDomain.assembly_resolve_in_progress_refonly = dictionary;
				}
			}
			else
			{
				dictionary = AppDomain.assembly_resolve_in_progress;
				if (dictionary == null)
				{
					dictionary = new Dictionary<string, object>();
					AppDomain.assembly_resolve_in_progress = dictionary;
				}
			}
			if (dictionary.ContainsKey(name))
			{
				return null;
			}
			dictionary[name] = null;
			Assembly result;
			try
			{
				Delegate[] invocationList = resolveEventHandler.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					Assembly assembly = ((ResolveEventHandler)invocationList[i])(this, new ResolveEventArgs(name, requestingAssembly));
					if (assembly != null)
					{
						return assembly;
					}
				}
				result = null;
			}
			finally
			{
				dictionary.Remove(name);
			}
			return result;
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x0005C2E4 File Offset: 0x0005A4E4
		internal Assembly DoTypeBuilderResolve(TypeBuilder tb)
		{
			if (this.TypeResolve == null)
			{
				return null;
			}
			return this.DoTypeResolve(tb.FullName);
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x0005C2FC File Offset: 0x0005A4FC
		internal Assembly DoTypeResolve(string name)
		{
			if (this.TypeResolve == null)
			{
				return null;
			}
			Dictionary<string, object> dictionary = AppDomain.type_resolve_in_progress;
			if (dictionary == null)
			{
				dictionary = (AppDomain.type_resolve_in_progress = new Dictionary<string, object>());
			}
			if (dictionary.ContainsKey(name))
			{
				return null;
			}
			dictionary[name] = null;
			Assembly result;
			try
			{
				Delegate[] invocationList = this.TypeResolve.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					Assembly assembly = ((ResolveEventHandler)invocationList[i])(this, new ResolveEventArgs(name));
					if (assembly != null)
					{
						return assembly;
					}
				}
				result = null;
			}
			finally
			{
				dictionary.Remove(name);
			}
			return result;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x0005C398 File Offset: 0x0005A598
		internal Assembly DoResourceResolve(string name, Assembly requesting)
		{
			if (this.ResourceResolve == null)
			{
				return null;
			}
			Delegate[] invocationList = this.ResourceResolve.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				Assembly assembly = ((ResolveEventHandler)invocationList[i])(this, new ResolveEventArgs(name, requesting));
				if (assembly != null)
				{
					return assembly;
				}
			}
			return null;
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0005C3EB File Offset: 0x0005A5EB
		private void DoDomainUnload()
		{
			if (this.DomainUnload != null)
			{
				this.DomainUnload(this, null);
			}
		}

		// Token: 0x060017DC RID: 6108
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void DoUnhandledException(Exception e);

		// Token: 0x060017DD RID: 6109 RVA: 0x0005C402 File Offset: 0x0005A602
		internal void DoUnhandledException(UnhandledExceptionEventArgs args)
		{
			if (this.UnhandledException != null)
			{
				this.UnhandledException(this, args);
			}
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x0005C419 File Offset: 0x0005A619
		internal byte[] GetMarshalledDomainObjRef()
		{
			return CADSerializer.SerializeObject(RemotingServices.Marshal(AppDomain.CurrentDomain, null, typeof(AppDomain))).GetBuffer();
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x0005C43C File Offset: 0x0005A63C
		internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm)
		{
			IMessage msg;
			if (arrRequest != null)
			{
				msg = CADSerializer.DeserializeMessage(new MemoryStream(arrRequest), null);
			}
			else
			{
				msg = new MethodCall(cadMsg);
			}
			IMessage message = ChannelServices.SyncDispatchMessage(msg);
			cadMrm = CADMethodReturnMessage.Create(message);
			if (cadMrm == null)
			{
				arrResponse = CADSerializer.SerializeMessage(message).GetBuffer();
				return;
			}
			arrResponse = null;
		}

		/// <summary>происходит, когда загружена сборка.</summary>
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060017E0 RID: 6112 RVA: 0x0005C488 File Offset: 0x0005A688
		// (remove) Token: 0x060017E1 RID: 6113 RVA: 0x0005C4C0 File Offset: 0x0005A6C0
		[method: SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public event AssemblyLoadEventHandler AssemblyLoad;

		/// <summary>Происходит, когда разрешение сборки завершается неудачей.</summary>
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060017E2 RID: 6114 RVA: 0x0005C4F8 File Offset: 0x0005A6F8
		// (remove) Token: 0x060017E3 RID: 6115 RVA: 0x0005C530 File Offset: 0x0005A730
		[method: SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public event ResolveEventHandler AssemblyResolve;

		/// <summary>Происходит непосредственно перед выгрузкой объекта <see cref="T:System.AppDomain" />.</summary>
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060017E4 RID: 6116 RVA: 0x0005C568 File Offset: 0x0005A768
		// (remove) Token: 0x060017E5 RID: 6117 RVA: 0x0005C5A0 File Offset: 0x0005A7A0
		[method: SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public event EventHandler DomainUnload;

		/// <summary>Происходит при завершении работы родительского процесса домена приложения по умолчанию.</summary>
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060017E6 RID: 6118 RVA: 0x0005C5D8 File Offset: 0x0005A7D8
		// (remove) Token: 0x060017E7 RID: 6119 RVA: 0x0005C610 File Offset: 0x0005A810
		[method: SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public event EventHandler ProcessExit;

		/// <summary>происходит, когда разрешение ресурса завершается неудачей, из-за того, что он не является допустимым связанным или внедренным ресурсом в сборке.</summary>
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060017E8 RID: 6120 RVA: 0x0005C648 File Offset: 0x0005A848
		// (remove) Token: 0x060017E9 RID: 6121 RVA: 0x0005C680 File Offset: 0x0005A880
		[method: SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public event ResolveEventHandler ResourceResolve;

		/// <summary>Происходит, когда разрешении типа завершается неудачей.</summary>
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060017EA RID: 6122 RVA: 0x0005C6B8 File Offset: 0x0005A8B8
		// (remove) Token: 0x060017EB RID: 6123 RVA: 0x0005C6F0 File Offset: 0x0005A8F0
		[method: SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public event ResolveEventHandler TypeResolve;

		/// <summary>Происходит, если выброшенное исключение остается не перехваченным.</summary>
		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060017EC RID: 6124 RVA: 0x0005C728 File Offset: 0x0005A928
		// (remove) Token: 0x060017ED RID: 6125 RVA: 0x0005C760 File Offset: 0x0005A960
		[method: SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain = true)]
		public event UnhandledExceptionEventHandler UnhandledException;

		/// <summary>Происходит при создании исключения в управляемом коде, перед тем как среда выполнения ищет стек вызовов для обработчика исключений в домене приложений.</summary>
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060017EE RID: 6126 RVA: 0x0005C798 File Offset: 0x0005A998
		// (remove) Token: 0x060017EF RID: 6127 RVA: 0x0005C7D0 File Offset: 0x0005A9D0
		public event EventHandler<FirstChanceExceptionEventArgs> FirstChanceException;

		/// <summary>Возвращает значение, указывающее, имеет ли текущий домен приложения набор разрешений, которые предоставляются всем сборкам, загружаемым в домен приложения.</summary>
		/// <returns>Значение <see langword="true" />, если текущий домен приложения имеет однородный набор разрешений; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x000040F7 File Offset: 0x000022F7
		[MonoTODO]
		public bool IsHomogenous
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает значение, указывающее, выполняются ли сборки, загруженные в текущий домен приложения, с полным доверием.</summary>
		/// <returns>Значение <see langword="true" />, если сборки, загруженные в текущий домен приложения, выполняются с полным доверием; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x000040F7 File Offset: 0x000022F7
		[MonoTODO]
		public bool IsFullyTrusted
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает диспетчер домена, предоставленный средой размещения при инициализации домена приложения.</summary>
		/// <returns>Объект, который представляет диспетчер домена, предоставленный средой размещения при инициализации домена приложения, или значение <see langword="null" />, если диспетчер домена не предоставлен.</returns>
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0005C805 File Offset: 0x0005AA05
		public AppDomainManager DomainManager
		{
			get
			{
				return this._domain_manager;
			}
		}

		/// <summary>Происходит, когда разрешение сборки завершается неудачей в контексте, поддерживающем только отражение.</summary>
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060017F3 RID: 6131 RVA: 0x0005C810 File Offset: 0x0005AA10
		// (remove) Token: 0x060017F4 RID: 6132 RVA: 0x0005C848 File Offset: 0x0005AA48
		public event ResolveEventHandler ReflectionOnlyAssemblyResolve;

		/// <summary>Возвращает контекст активации по умолчанию для текущего домена приложения.</summary>
		/// <returns>Объект, представляющий контекст активации для текущего домена приложения, или значение <see langword="null" />, если этот домен не имеет контекста активации.</returns>
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x0005C87D File Offset: 0x0005AA7D
		public ActivationContext ActivationContext
		{
			get
			{
				return this._activation;
			}
		}

		/// <summary>Возвращает удостоверение приложения в данном домене приложения.</summary>
		/// <returns>Объект, идентифицирующий приложение в данном домене приложения.</returns>
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0005C885 File Offset: 0x0005AA85
		public ApplicationIdentity ApplicationIdentity
		{
			get
			{
				return this._applicationIdentity;
			}
		}

		/// <summary>Возвращает целое число, однозначно идентифицирующее домен приложения в процессе.</summary>
		/// <returns>Целое число, идентифицирующее домен приложения.</returns>
		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x0005C88D File Offset: 0x0005AA8D
		public int Id
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this.getDomainID();
			}
		}

		/// <summary>Возвращает отображаемое имя сборки после применения политики.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки в форме, заданной свойством <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <returns>Строка, содержащая отображаемое имя сборки после применения политики.</returns>
		// Token: 0x060017F8 RID: 6136 RVA: 0x0005C895 File Offset: 0x0005AA95
		[ComVisible(false)]
		[MonoTODO("This routine only returns the parameter currently")]
		public string ApplyPolicy(string assemblyName)
		{
			if (assemblyName == null)
			{
				throw new ArgumentNullException("assemblyName");
			}
			if (assemblyName.Length == 0)
			{
				throw new ArgumentException("assemblyName");
			}
			return assemblyName;
		}

		/// <summary>Создает новый домен приложения с заданным именем с использованием свидетельства, пути к базовой папке приложения, относительного пути поиска и параметра, указывающего, должна ли загружаться теневая копия сборки в домен приложения. Задает метод обратного вызова, вызываемый, когда инициализируется домен приложения, и массив строковых аргументов для передачи методу обратного вызова.</summary>
		/// <param name="friendlyName">Понятное имя домена. Это понятное имя может отображаться в пользовательском интерфейсе для определения домена. Для получения дополнительной информации см. <see cref="P:System.AppDomain.FriendlyName" />.</param>
		/// <param name="securityInfo">Свидетельство, идентифицирующее код, который выполняется в домене приложения. Передайте значение <see langword="null" /> для использования свидетельства текущего домена приложения.</param>
		/// <param name="appBasePath">Базовый каталог, в котором распознаватель сборок производит поиск. Для получения дополнительной информации см. <see cref="P:System.AppDomain.BaseDirectory" />.</param>
		/// <param name="appRelativeSearchPath">Путь, соответствующий базовому каталогу, в котором распознаватель сборок будет производить поиск закрытых сборок. Для получения дополнительной информации см. <see cref="P:System.AppDomain.RelativeSearchPath" />.</param>
		/// <param name="shadowCopyFiles">Значение <see langword="true" /> для загрузки теневой копии сборки в этот домен приложения.</param>
		/// <param name="adInit">Делегат <see cref="T:System.AppDomainInitializer" />, представляющий метод обратного вызова, вызываемый при инициализации нового объекта <see cref="T:System.AppDomain" />.</param>
		/// <param name="adInitArgs">Массив строковых аргументов для передачи в обратный вызов, представленный объектом <paramref name="adInit" />, когда инициализируется новый объект <see cref="T:System.AppDomain" />.</param>
		/// <returns>Вновь созданный домен приложения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="friendlyName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060017F9 RID: 6137 RVA: 0x0005C8BC File Offset: 0x0005AABC
		public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles, AppDomainInitializer adInit, string[] adInitArgs)
		{
			AppDomainSetup appDomainSetup = AppDomain.CreateDomainSetup(appBasePath, appRelativeSearchPath, shadowCopyFiles);
			appDomainSetup.AppDomainInitializerArguments = adInitArgs;
			appDomainSetup.AppDomainInitializer = adInit;
			return AppDomain.CreateDomain(friendlyName, securityInfo, appDomainSetup);
		}

		/// <summary>Выполняет сборку, определенную ее отображаемым именем.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Сборка, заданная параметром <paramref name="assemblyName" />, не найдена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка, заданная параметром <paramref name="assemblyName" />, недопустимая.  
		/// -или- 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка, заданная параметром <paramref name="assemblyName" /> найдена, но ее невозможно загрузить.</exception>
		/// <exception cref="T:System.MissingMethodException">Указанная сборка не имеет точку входа.</exception>
		// Token: 0x060017FA RID: 6138 RVA: 0x0005C8EB File Offset: 0x0005AAEB
		public int ExecuteAssemblyByName(string assemblyName)
		{
			return this.ExecuteAssemblyByName(assemblyName, null, null);
		}

		/// <summary>Выполняет сборку с заданным отображаемым именем с использованием заданного свидетельства.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="assemblySecurity">Свидетельство для загрузки сборки.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Сборка, заданная параметром <paramref name="assemblyName" />, не найдена.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка, заданная параметром <paramref name="assemblyName" /> найдена, но ее невозможно загрузить.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка, заданная параметром <paramref name="assemblyName" />, недопустимая.  
		/// -или- 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.MissingMethodException">Указанная сборка не имеет точку входа.</exception>
		// Token: 0x060017FB RID: 6139 RVA: 0x0005C8F6 File Offset: 0x0005AAF6
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public int ExecuteAssemblyByName(string assemblyName, Evidence assemblySecurity)
		{
			return this.ExecuteAssemblyByName(assemblyName, assemblySecurity, null);
		}

		/// <summary>Выполняет сборку с заданным отображаемым именем с использованием заданного свидетельства и аргументов.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="assemblySecurity">Свидетельство для загрузки сборки.</param>
		/// <param name="args">Аргументы командной строки для передачи при запуске процесса.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Сборка, заданная параметром <paramref name="assemblyName" />, не найдена.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка, заданная параметром <paramref name="assemblyName" /> найдена, но ее невозможно загрузить.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка, заданная параметром <paramref name="assemblyName" />, недопустимая.  
		/// -или- 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="assemblySecurity" /> не является <see langword="null" />. Если не включена политика разграничения доступа кода для кода предыдущей версии, <paramref name="assemblySecurity" /> должно иметь значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Указанная сборка не имеет точку входа.</exception>
		// Token: 0x060017FC RID: 6140 RVA: 0x0005C904 File Offset: 0x0005AB04
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public int ExecuteAssemblyByName(string assemblyName, Evidence assemblySecurity, params string[] args)
		{
			Assembly a = Assembly.Load(assemblyName, assemblySecurity);
			return this.ExecuteAssemblyInternal(a, args);
		}

		/// <summary>Выполняет сборку с заданным <see cref="T:System.Reflection.AssemblyName" /> с использованием указанного свидетельства и аргументов.</summary>
		/// <param name="assemblyName">Объект <see cref="T:System.Reflection.AssemblyName" />, представляющий имя сборки.</param>
		/// <param name="assemblySecurity">Свидетельство для загрузки сборки.</param>
		/// <param name="args">Аргументы командной строки для передачи при запуске процесса.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		/// <exception cref="T:System.IO.FileNotFoundException">Сборка, заданная параметром <paramref name="assemblyName" />, не найдена.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка, заданная параметром <paramref name="assemblyName" /> найдена, но ее невозможно загрузить.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка, заданная параметром <paramref name="assemblyName" />, недопустимая.  
		/// -или- 
		/// Сейчас загружена среда CLR 2.0 или более поздней версии. Сборка <paramref name="assemblyName" /> скомпилирована в более поздней версии.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="assemblySecurity" /> не является <see langword="null" />. Если не включена политика разграничения доступа кода для кода предыдущей версии, <paramref name="assemblySecurity" /> должно иметь значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Указанная сборка не имеет точку входа.</exception>
		// Token: 0x060017FD RID: 6141 RVA: 0x0005C924 File Offset: 0x0005AB24
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public int ExecuteAssemblyByName(AssemblyName assemblyName, Evidence assemblySecurity, params string[] args)
		{
			Assembly a = Assembly.Load(assemblyName, assemblySecurity);
			return this.ExecuteAssemblyInternal(a, args);
		}

		/// <summary>Выполняет сборку с заданным отображаемым именем с использованием заданных аргументов.</summary>
		/// <param name="assemblyName">Отображаемое имя сборки. См. раздел <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <param name="args">Аргументы командной строки для передачи при запуске процесса.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="assemblyName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Сборка, заданная параметром <paramref name="assemblyName" />, не найдена.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка, заданная параметром <paramref name="assemblyName" /> найдена, но ее невозможно загрузить.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка, заданная параметром <paramref name="assemblyName" />, недопустимая.  
		/// -или- 
		///  Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.MissingMethodException">Указанная сборка не имеет точку входа.</exception>
		// Token: 0x060017FE RID: 6142 RVA: 0x0005C944 File Offset: 0x0005AB44
		public int ExecuteAssemblyByName(string assemblyName, params string[] args)
		{
			Assembly a = Assembly.Load(assemblyName, null);
			return this.ExecuteAssemblyInternal(a, args);
		}

		/// <summary>Выполняет сборку с заданным <see cref="T:System.Reflection.AssemblyName" />, используя указанные аргументы.</summary>
		/// <param name="assemblyName">Объект <see cref="T:System.Reflection.AssemblyName" />, представляющий имя сборки.</param>
		/// <param name="args">Аргументы командной строки для передачи при запуске процесса.</param>
		/// <returns>Значение, возвращаемое точкой входа сборки.</returns>
		/// <exception cref="T:System.IO.FileNotFoundException">Сборка, заданная параметром <paramref name="assemblyName" />, не найдена.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка, заданная параметром <paramref name="assemblyName" /> найдена, но ее невозможно загрузить.</exception>
		/// <exception cref="T:System.BadImageFormatException">Сборка, заданная параметром <paramref name="assemblyName" />, недопустимая.  
		/// -или- 
		///  Сборка <paramref name="assemblyName" /> была скомпилирована в более поздней версии среды CLR, чем версия, загруженная в текущий момент.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринята попытка выполнения операции с выгруженным доменом приложения.</exception>
		/// <exception cref="T:System.MissingMethodException">Указанная сборка не имеет точку входа.</exception>
		// Token: 0x060017FF RID: 6143 RVA: 0x0005C964 File Offset: 0x0005AB64
		public int ExecuteAssemblyByName(AssemblyName assemblyName, params string[] args)
		{
			Assembly a = Assembly.Load(assemblyName, null);
			return this.ExecuteAssemblyInternal(a, args);
		}

		/// <summary>Возвращает значение, указывающее, является ли домен приложения используемым по умолчанию доменом для процесса.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий объект <see cref="T:System.AppDomain" /> представляет используемый по умолчанию домен приложения для процесса, в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001800 RID: 6144 RVA: 0x0005C981 File Offset: 0x0005AB81
		public bool IsDefaultAppDomain()
		{
			return this == AppDomain.DefaultDomain;
		}

		/// <summary>Возвращает сборки, которые были загружены в контекст, поддерживающий только отражение, домена приложения.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.Assembly" />, представляющих сборки, которые были загружены в контекст домена приложения, поддерживающий только отражение.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">Предпринимается попытка выполнить операцию в незагруженном домене приложения.</exception>
		// Token: 0x06001801 RID: 6145 RVA: 0x0005C98B File Offset: 0x0005AB8B
		public Assembly[] ReflectionOnlyGetAssemblies()
		{
			return this.GetAssemblies(true);
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001802 RID: 6146 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _AppDomain.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001803 RID: 6147 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _AppDomain.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001804 RID: 6148 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _AppDomain.GetTypeInfoCount(out uint pcTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001805 RID: 6149 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _AppDomain.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает логическое значение, допускающее значения NULL, которое указывает, установлены ли какие-либо переключатели совместимости и, если установлены, установлен ли заданный переключатель совместимости.</summary>
		/// <param name="value">Проверяемый переключатель совместимости.</param>
		/// <returns>Пустая ссылка (<see langword="Nothing" /> в Visual Basic), если переключатели совместимости не установлены; в противном случае логическое значение, указывающее, установлен ли переключатель совместимости, заданный параметром <paramref name="value" />.</returns>
		// Token: 0x06001806 RID: 6150 RVA: 0x0005C994 File Offset: 0x0005AB94
		public bool? IsCompatibilitySwitchSet(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return new bool?(this.compatibility_switch != null && this.compatibility_switch.Contains(value));
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x0005C9C0 File Offset: 0x0005ABC0
		internal void SetCompatibilitySwitch(string value)
		{
			if (this.compatibility_switch == null)
			{
				this.compatibility_switch = new List<string>();
			}
			this.compatibility_switch.Add(value);
		}

		/// <summary>Возвращает или задает значение, указывающее, включен ли мониторинг ЦП и памяти доменов приложений для текущего процесса. После того, как мониторинг для процесса включен, отключить его невозможно.</summary>
		/// <returns>Значение <see langword="true" />, если мониторинг включен; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Текущий процесс попытался присвоить значение <see langword="false" /> этому свойству.</exception>
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("Currently always returns false")]
		public static bool MonitoringIsEnabled
		{
			get
			{
				return false;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает количество байтов, оставшихся после последнего сбора, и про которые известно, что на них ссылается текущий домен приложения.</summary>
		/// <returns>Количество оставшихся байтов.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для свойства <see langword="static" /> (<see langword="Shared" /> в Visual Basic) <see cref="P:System.AppDomain.MonitoringIsEnabled" /> задано значение <see langword="false" />.</exception>
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public long MonitoringSurvivedMemorySize
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает общее количество байтов, оставшихся после последнего сбора для всех доменов приложений в процессе.</summary>
		/// <returns>Общее количество оставшихся байтов для процесса.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для свойства <see langword="static" /> (<see langword="Shared" /> в Visual Basic) <see cref="P:System.AppDomain.MonitoringIsEnabled" /> задано значение <see langword="false" />.</exception>
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public static long MonitoringSurvivedProcessMemorySize
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает общий размер в байтах для всех операций выделения памяти, выполненных доменом приложения с момента его создания, без вычитания собранной памяти.</summary>
		/// <returns>Общий размер для всех операций выделения памяти.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для свойства <see langword="static" /> (<see langword="Shared" /> в Visual Basic) <see cref="P:System.AppDomain.MonitoringIsEnabled" /> задано значение <see langword="false" />.</exception>
		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public long MonitoringTotalAllocatedMemorySize
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает общее процессорное время, использованное всеми потоками при выполнении в текущем домене приложения с момента запуска процесса.</summary>
		/// <returns>Общее процессорное время для текущего домена приложения.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для свойства <see langword="static" /> (<see langword="Shared" /> в Visual Basic) <see cref="P:System.AppDomain.MonitoringIsEnabled" /> задано значение <see langword="false" />.</exception>
		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public TimeSpan MonitoringTotalProcessorTime
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x04001654 RID: 5716
		private IntPtr _mono_app_domain;

		// Token: 0x04001655 RID: 5717
		private static string _process_guid;

		// Token: 0x04001656 RID: 5718
		[ThreadStatic]
		private static Dictionary<string, object> type_resolve_in_progress;

		// Token: 0x04001657 RID: 5719
		[ThreadStatic]
		private static Dictionary<string, object> assembly_resolve_in_progress;

		// Token: 0x04001658 RID: 5720
		[ThreadStatic]
		private static Dictionary<string, object> assembly_resolve_in_progress_refonly;

		// Token: 0x04001659 RID: 5721
		private Evidence _evidence;

		// Token: 0x0400165A RID: 5722
		private PermissionSet _granted;

		// Token: 0x0400165B RID: 5723
		private PrincipalPolicy _principalPolicy;

		// Token: 0x0400165C RID: 5724
		[ThreadStatic]
		private static IPrincipal _principal;

		// Token: 0x0400165D RID: 5725
		private static AppDomain default_domain;

		// Token: 0x04001666 RID: 5734
		private AppDomainManager _domain_manager;

		// Token: 0x04001668 RID: 5736
		private ActivationContext _activation;

		// Token: 0x04001669 RID: 5737
		private ApplicationIdentity _applicationIdentity;

		// Token: 0x0400166A RID: 5738
		private List<string> compatibility_switch;

		// Token: 0x02000215 RID: 533
		[Serializable]
		private class Loader
		{
			// Token: 0x0600180E RID: 6158 RVA: 0x0005C9E1 File Offset: 0x0005ABE1
			public Loader(string assembly)
			{
				this.assembly = assembly;
			}

			// Token: 0x0600180F RID: 6159 RVA: 0x0005C9F0 File Offset: 0x0005ABF0
			public void Load()
			{
				Assembly.LoadFrom(this.assembly);
			}

			// Token: 0x0400166B RID: 5739
			private string assembly;
		}

		// Token: 0x02000216 RID: 534
		[Serializable]
		private class Initializer
		{
			// Token: 0x06001810 RID: 6160 RVA: 0x0005C9FE File Offset: 0x0005ABFE
			public Initializer(AppDomainInitializer initializer, string[] arguments)
			{
				this.initializer = initializer;
				this.arguments = arguments;
			}

			// Token: 0x06001811 RID: 6161 RVA: 0x0005CA14 File Offset: 0x0005AC14
			public void Initialize()
			{
				this.initializer(this.arguments);
			}

			// Token: 0x0400166C RID: 5740
			private AppDomainInitializer initializer;

			// Token: 0x0400166D RID: 5741
			private string[] arguments;
		}
	}
}
