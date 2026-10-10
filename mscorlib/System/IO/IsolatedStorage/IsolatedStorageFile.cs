using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading;
using Mono.Security.Cryptography;
using Unity;

namespace System.IO.IsolatedStorage
{
	/// <summary>Предоставляет область изолированного хранилища, в которой содержатся файлы и каталоги.</summary>
	// Token: 0x02000B73 RID: 2931
	[ComVisible(true)]
	[FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
	public sealed class IsolatedStorageFile : IsolatedStorage, IDisposable
	{
		/// <summary>Возвращает счетчик для хранилищ <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" /> в области ограниченного действия изолированного хранения.</summary>
		/// <param name="scope">Представляет область <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />, для которой возвращаются изолированные хранилища. <see langword="User" /> и <see langword="User|Roaming" /> являются единственными поддерживаемыми комбинациями <see langword="IsolatedStorageScope" />.</param>
		/// <returns>Счетчик для хранилищ <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" /> в указанной области ограниченного действия изолированного хранения.</returns>
		// Token: 0x06006A8D RID: 27277 RVA: 0x0016C9A6 File Offset: 0x0016ABA6
		public static IEnumerator GetEnumerator(IsolatedStorageScope scope)
		{
			IsolatedStorageFile.Demand(scope);
			if (scope != IsolatedStorageScope.User && scope != (IsolatedStorageScope.User | IsolatedStorageScope.Roaming) && scope != IsolatedStorageScope.Machine)
			{
				throw new ArgumentException(Locale.GetText("Invalid scope, only User, User|Roaming and Machine are valid"));
			}
			return new IsolatedStorageFileEnumerator(scope, IsolatedStorageFile.GetIsolatedStorageRoot(scope));
		}

		/// <summary>Возвращает изолированное хранение, соответствующее объектам и типам данного домена приложения и свидетельства сборки.</summary>
		/// <param name="scope">Побитовое сочетание значений перечисления.</param>
		/// <param name="domainEvidence">Объект, который содержит удостоверение домена приложения.</param>
		/// <param name="domainEvidenceType">Тип-идентификатор для выбора из свидетельства домена приложения.</param>
		/// <param name="assemblyEvidence">Объект, который содержит удостоверение сборки кода.</param>
		/// <param name="assemblyEvidenceType">Тип-идентификатор для выбора из свидетельства сборки кода приложения.</param>
		/// <returns>Объект, представляющий параметры.</returns>
		/// <exception cref="T:System.Security.SecurityException">Недостаточно разрешений для изолированного хранения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Удостоверение <paramref name="domainEvidence" /> или <paramref name="assemblyEvidence" /> не было передано.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="scope" /> не является допустимым.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Расположение изолированного хранилища не может быть инициализировано.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение перечисления <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Application" />, но идентификатор приложения вызывающего модуля не может быть определен, так как свойство <see cref="P:System.AppDomain.ActivationContext" /> для текущего домена приложения вернуло значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Domain" />, но разрешения для домена приложения не могут быть определены.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Assembly" />, но разрешения для вызывающей сборки не могут быть определены.</exception>
		// Token: 0x06006A8E RID: 27278 RVA: 0x0016C9D8 File Offset: 0x0016ABD8
		public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, Evidence domainEvidence, Type domainEvidenceType, Evidence assemblyEvidence, Type assemblyEvidenceType)
		{
			IsolatedStorageFile.Demand(scope);
			bool flag = (scope & IsolatedStorageScope.Domain) > IsolatedStorageScope.None;
			if (flag && domainEvidence == null)
			{
				throw new ArgumentNullException("domainEvidence");
			}
			bool flag2 = (scope & IsolatedStorageScope.Assembly) > IsolatedStorageScope.None;
			if (flag2 && assemblyEvidence == null)
			{
				throw new ArgumentNullException("assemblyEvidence");
			}
			IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile(scope);
			if (flag)
			{
				if (domainEvidenceType == null)
				{
					isolatedStorageFile._domainIdentity = IsolatedStorageFile.GetDomainIdentityFromEvidence(domainEvidence);
				}
				else
				{
					isolatedStorageFile._domainIdentity = IsolatedStorageFile.GetTypeFromEvidence(domainEvidence, domainEvidenceType);
				}
				if (isolatedStorageFile._domainIdentity == null)
				{
					throw new IsolatedStorageException(Locale.GetText("Couldn't find domain identity."));
				}
			}
			if (flag2)
			{
				if (assemblyEvidenceType == null)
				{
					isolatedStorageFile._assemblyIdentity = IsolatedStorageFile.GetAssemblyIdentityFromEvidence(assemblyEvidence);
				}
				else
				{
					isolatedStorageFile._assemblyIdentity = IsolatedStorageFile.GetTypeFromEvidence(assemblyEvidence, assemblyEvidenceType);
				}
				if (isolatedStorageFile._assemblyIdentity == null)
				{
					throw new IsolatedStorageException(Locale.GetText("Couldn't find assembly identity."));
				}
			}
			isolatedStorageFile.PostInit();
			return isolatedStorageFile;
		}

		/// <summary>Возвращает изолированное хранение, соответствующее объектам данного домена приложения и свидетельства сборки.</summary>
		/// <param name="scope">Побитовое сочетание значений перечисления.</param>
		/// <param name="domainIdentity">Объект, содержащий свидетельство для удостоверения домена приложения.</param>
		/// <param name="assemblyIdentity">Объект, содержащий свидетельство для удостоверения сборки кода.</param>
		/// <returns>Объект, представляющий параметры.</returns>
		/// <exception cref="T:System.Security.SecurityException">Недостаточно разрешений для изолированного хранения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Ни <paramref name="domainIdentity" />, ни <paramref name="assemblyIdentity" /> не были переданы. Проверяет правильность используемого конструктора.  
		///
		/// или - 
		/// Либо <paramref name="domainIdentity" />, либо <paramref name="assemblyIdentity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="scope" /> не является допустимым.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Расположение изолированного хранилища не может быть инициализировано.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение перечисления <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Application" />, но идентификатор приложения вызывающего модуля не может быть определен, так как свойство <see cref="P:System.AppDomain.ActivationContext" /> для текущего домена приложения вернуло значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Domain" />, но разрешения для домена приложения не могут быть определены.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Assembly" />, но разрешения для вызывающей сборки не могут быть определены.</exception>
		// Token: 0x06006A8F RID: 27279 RVA: 0x0016CAA8 File Offset: 0x0016ACA8
		public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, object domainIdentity, object assemblyIdentity)
		{
			IsolatedStorageFile.Demand(scope);
			if ((scope & IsolatedStorageScope.Domain) != IsolatedStorageScope.None && domainIdentity == null)
			{
				throw new ArgumentNullException("domainIdentity");
			}
			bool flag = (scope & IsolatedStorageScope.Assembly) > IsolatedStorageScope.None;
			if (flag && assemblyIdentity == null)
			{
				throw new ArgumentNullException("assemblyIdentity");
			}
			IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile(scope);
			if (flag)
			{
				isolatedStorageFile._fullEvidences = Assembly.GetCallingAssembly().UnprotectedGetEvidence();
			}
			isolatedStorageFile._domainIdentity = domainIdentity;
			isolatedStorageFile._assemblyIdentity = assemblyIdentity;
			isolatedStorageFile.PostInit();
			return isolatedStorageFile;
		}

		/// <summary>Получает изолированное хранение, соответствующее области ограниченного действия изолированного хранения, предоставляющей типы домена приложения и свидетельства сборки.</summary>
		/// <param name="scope">Побитовое сочетание значений перечисления.</param>
		/// <param name="domainEvidenceType">Тип свидетельства <see cref="T:System.Security.Policy.Evidence" />, которое можно выбрать из списка свидетельств <see cref="T:System.Security.Policy.Evidence" />, присутствующих в домене вызывающего приложения. Значение <see langword="null" /> позволяет объекту <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> выбирать свидетельство.</param>
		/// <param name="assemblyEvidenceType">Тип свидетельства <see cref="T:System.Security.Policy.Evidence" />, которое можно выбрать из списка свидетельств <see cref="T:System.Security.Policy.Evidence" />, присутствующих в домене вызывающего приложения. Значение <see langword="null" /> позволяет объекту <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> выбирать свидетельство.</param>
		/// <returns>Объект, представляющий параметры.</returns>
		/// <exception cref="T:System.Security.SecurityException">Недостаточно разрешений для изолированного хранения.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="scope" /> не является допустимым.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Предоставленный тип свидетельства отсутствует в списке свидетельства сборки.  
		///
		/// или - 
		/// Расположение изолированного хранилища не может быть инициализировано.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение перечисления <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Application" />, но идентификатор приложения вызывающего модуля не может быть определен, так как свойство <see cref="P:System.AppDomain.ActivationContext" /> для текущего домена приложения вернуло значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Domain" />, но разрешения для домена приложения не могут быть определены.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Assembly" />, но разрешения для вызывающей сборки не могут быть определены.</exception>
		// Token: 0x06006A90 RID: 27280 RVA: 0x0016CB14 File Offset: 0x0016AD14
		public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, Type domainEvidenceType, Type assemblyEvidenceType)
		{
			IsolatedStorageFile.Demand(scope);
			IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile(scope);
			if ((scope & IsolatedStorageScope.Domain) != IsolatedStorageScope.None)
			{
				if (domainEvidenceType == null)
				{
					domainEvidenceType = typeof(Url);
				}
				isolatedStorageFile._domainIdentity = IsolatedStorageFile.GetTypeFromEvidence(AppDomain.CurrentDomain.Evidence, domainEvidenceType);
			}
			if ((scope & IsolatedStorageScope.Assembly) != IsolatedStorageScope.None)
			{
				Evidence evidence = Assembly.GetCallingAssembly().UnprotectedGetEvidence();
				isolatedStorageFile._fullEvidences = evidence;
				if ((scope & IsolatedStorageScope.Domain) != IsolatedStorageScope.None)
				{
					if (assemblyEvidenceType == null)
					{
						assemblyEvidenceType = typeof(Url);
					}
					isolatedStorageFile._assemblyIdentity = IsolatedStorageFile.GetTypeFromEvidence(evidence, assemblyEvidenceType);
				}
				else
				{
					isolatedStorageFile._assemblyIdentity = IsolatedStorageFile.GetAssemblyIdentityFromEvidence(evidence);
				}
			}
			isolatedStorageFile.PostInit();
			return isolatedStorageFile;
		}

		/// <summary>Получает изолированное хранение, соответствующее данному удостоверению приложения.</summary>
		/// <param name="scope">Побитовое сочетание значений перечисления.</param>
		/// <param name="applicationIdentity">Объект, содержащий свидетельство для удостоверения приложения.</param>
		/// <returns>Объект, представляющий параметры.</returns>
		/// <exception cref="T:System.Security.SecurityException">Недостаточно разрешений для изолированного хранения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Идентификатор <paramref name="applicationIdentity" /> не был передан.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="scope" /> не является допустимым.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Расположение изолированного хранилища не может быть инициализировано.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение перечисления <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Application" />, но идентификатор приложения вызывающего модуля не может быть определен, так как свойство <see cref="P:System.AppDomain.ActivationContext" /> для текущего домена приложения вернуло значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Domain" />, но разрешения для домена приложения не могут быть определены.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Assembly" />, но разрешения для вызывающей сборки не могут быть определены.</exception>
		// Token: 0x06006A91 RID: 27281 RVA: 0x0016CBB1 File Offset: 0x0016ADB1
		public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, object applicationIdentity)
		{
			IsolatedStorageFile.Demand(scope);
			if (applicationIdentity == null)
			{
				throw new ArgumentNullException("applicationIdentity");
			}
			IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile(scope);
			isolatedStorageFile._applicationIdentity = applicationIdentity;
			isolatedStorageFile._fullEvidences = Assembly.GetCallingAssembly().UnprotectedGetEvidence();
			isolatedStorageFile.PostInit();
			return isolatedStorageFile;
		}

		/// <summary>Получает изолированное хранение, соответствующее области изоляции и объекту удостоверения приложения.</summary>
		/// <param name="scope">Побитовое сочетание значений перечисления.</param>
		/// <param name="applicationEvidenceType">Объект , который содержит удостоверение приложения.</param>
		/// <returns>Объект, представляющий параметры.</returns>
		/// <exception cref="T:System.Security.SecurityException">Недостаточно разрешений для изолированного хранения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Идентификатор <paramref name="applicationEvidence" /> не был передан.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="scope" /> не является допустимым.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Расположение изолированного хранилища не может быть инициализировано.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение перечисления <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Application" />, но идентификатор приложения вызывающего модуля не может быть определен, так как свойство <see cref="P:System.AppDomain.ActivationContext" /> для текущего домена приложения вернуло значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Domain" />, но разрешения для домена приложения не могут быть определены.  
		///
		/// или - 
		/// <paramref name="scope" /> содержит значение <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Assembly" />, но разрешения для вызывающей сборки не могут быть определены.</exception>
		// Token: 0x06006A92 RID: 27282 RVA: 0x0016CBEA File Offset: 0x0016ADEA
		public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, Type applicationEvidenceType)
		{
			IsolatedStorageFile.Demand(scope);
			IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile(scope);
			isolatedStorageFile.InitStore(scope, applicationEvidenceType);
			isolatedStorageFile._fullEvidences = Assembly.GetCallingAssembly().UnprotectedGetEvidence();
			isolatedStorageFile.PostInit();
			return isolatedStorageFile;
		}

		/// <summary>Получает изолированное хранение с областью действия компьютера, соответствующее вызову удостоверения приложения кода.</summary>
		/// <returns>Объект, соответствующий области действия изолированного хранилища на основе вызова удостоверения приложения кода.</returns>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Не удалось определить удостоверение приложения вызывающего объекта.  
		///
		/// или - 
		/// Не удалось определить набор предоставленных разрешений для домена приложения.  
		///
		/// или - 
		/// Расположение изолированного хранилища не может быть инициализировано.</exception>
		/// <exception cref="T:System.Security.SecurityException">Недостаточно разрешений для изолированного хранения.</exception>
		// Token: 0x06006A93 RID: 27283 RVA: 0x0016CC18 File Offset: 0x0016AE18
		[IsolatedStorageFilePermission(SecurityAction.Demand, UsageAllowed = IsolatedStorageContainment.ApplicationIsolationByMachine)]
		public static IsolatedStorageFile GetMachineStoreForApplication()
		{
			IsolatedStorageScope scope = IsolatedStorageScope.Machine | IsolatedStorageScope.Application;
			IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile(scope);
			isolatedStorageFile.InitStore(scope, null);
			isolatedStorageFile._fullEvidences = Assembly.GetCallingAssembly().UnprotectedGetEvidence();
			isolatedStorageFile.PostInit();
			return isolatedStorageFile;
		}

		/// <summary>Получает изолированное хранение с областью действия компьютера, соответствующее вызову удостоверения сборки кода.</summary>
		/// <returns>Объект, соответствующий области действия изолированного хранилища на основе вызова удостоверения сборки кода.</returns>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Расположение изолированного хранилища не может быть инициализировано.</exception>
		/// <exception cref="T:System.Security.SecurityException">Недостаточно разрешений для изолированного хранения.</exception>
		// Token: 0x06006A94 RID: 27284 RVA: 0x0016CC4C File Offset: 0x0016AE4C
		[IsolatedStorageFilePermission(SecurityAction.Demand, UsageAllowed = IsolatedStorageContainment.AssemblyIsolationByMachine)]
		public static IsolatedStorageFile GetMachineStoreForAssembly()
		{
			IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile(IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine);
			Evidence evidence = Assembly.GetCallingAssembly().UnprotectedGetEvidence();
			isolatedStorageFile._fullEvidences = evidence;
			isolatedStorageFile._assemblyIdentity = IsolatedStorageFile.GetAssemblyIdentityFromEvidence(evidence);
			isolatedStorageFile.PostInit();
			return isolatedStorageFile;
		}

		/// <summary>Возвращает изолированное хранение с областью действия компьютера, соответствующее удостоверению домена приложения и сборки.</summary>
		/// <returns>Объект, соответствующий <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />, основывается на комбинации удостоверения домена приложения и удостоверения сборки.</returns>
		/// <exception cref="T:System.Security.SecurityException">Недостаточно разрешений для изолированного хранения.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Хранилище не удалось открыть.  
		///
		/// или - 
		/// Указанная сборка не имеет достаточно разрешений для создания изолированных хранилищ.  
		///
		/// или - 
		/// Невозможно определить разрешения для домена приложений.  
		///
		/// или - 
		/// Расположение изолированного хранилища не может быть инициализировано.</exception>
		// Token: 0x06006A95 RID: 27285 RVA: 0x0016CC84 File Offset: 0x0016AE84
		[IsolatedStorageFilePermission(SecurityAction.Demand, UsageAllowed = IsolatedStorageContainment.DomainIsolationByMachine)]
		public static IsolatedStorageFile GetMachineStoreForDomain()
		{
			IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile(IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine);
			isolatedStorageFile._domainIdentity = IsolatedStorageFile.GetDomainIdentityFromEvidence(AppDomain.CurrentDomain.Evidence);
			Evidence evidence = Assembly.GetCallingAssembly().UnprotectedGetEvidence();
			isolatedStorageFile._fullEvidences = evidence;
			isolatedStorageFile._assemblyIdentity = IsolatedStorageFile.GetAssemblyIdentityFromEvidence(evidence);
			isolatedStorageFile.PostInit();
			return isolatedStorageFile;
		}

		/// <summary>Получает изолированное хранение с областью действия пользователя, соответствующее вызову удостоверения приложения кода.</summary>
		/// <returns>Объект, соответствующий области действия изолированного хранилища на основе вызова удостоверения сборки кода.</returns>
		/// <exception cref="T:System.Security.SecurityException">Недостаточно разрешений для изолированного хранения.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Расположение изолированного хранилища не может быть инициализировано.  
		///
		/// или - 
		/// Не удается установить идентификатор приложения вызывающего объекта, поскольку свойство <see cref="P:System.AppDomain.ActivationContext" /> вернуло значение <see langword="null" />.  
		///
		/// или - 
		/// Невозможно определить разрешения для домена приложений.</exception>
		// Token: 0x06006A96 RID: 27286 RVA: 0x0016CCD4 File Offset: 0x0016AED4
		[IsolatedStorageFilePermission(SecurityAction.Demand, UsageAllowed = IsolatedStorageContainment.ApplicationIsolationByUser)]
		public static IsolatedStorageFile GetUserStoreForApplication()
		{
			IsolatedStorageScope scope = IsolatedStorageScope.User | IsolatedStorageScope.Application;
			IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile(scope);
			isolatedStorageFile.InitStore(scope, null);
			isolatedStorageFile._fullEvidences = Assembly.GetCallingAssembly().UnprotectedGetEvidence();
			isolatedStorageFile.PostInit();
			return isolatedStorageFile;
		}

		/// <summary>Получает изолированное хранение с областью действия пользователя, соответствующее вызову удостоверения сборки кода.</summary>
		/// <returns>Объект, соответствующий области действия изолированного хранилища на основе вызова удостоверения сборки кода.</returns>
		/// <exception cref="T:System.Security.SecurityException">Недостаточно разрешений для изолированного хранения.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Расположение изолированного хранилища не может быть инициализировано.  
		///
		/// или - 
		/// невозможно определить разрешения для вызывающей сборки.</exception>
		// Token: 0x06006A97 RID: 27287 RVA: 0x0016CD08 File Offset: 0x0016AF08
		[IsolatedStorageFilePermission(SecurityAction.Demand, UsageAllowed = IsolatedStorageContainment.AssemblyIsolationByUser)]
		public static IsolatedStorageFile GetUserStoreForAssembly()
		{
			IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile(IsolatedStorageScope.User | IsolatedStorageScope.Assembly);
			Evidence evidence = Assembly.GetCallingAssembly().UnprotectedGetEvidence();
			isolatedStorageFile._fullEvidences = evidence;
			isolatedStorageFile._assemblyIdentity = IsolatedStorageFile.GetAssemblyIdentityFromEvidence(evidence);
			isolatedStorageFile.PostInit();
			return isolatedStorageFile;
		}

		/// <summary>Получает изолированную область хранения с областью действия пользователя, соответствующую удостоверению домена приложения и удостоверению сборки.</summary>
		/// <returns>Объект, соответствующий <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />, основывается на комбинации удостоверения домена приложения и удостоверения сборки.</returns>
		/// <exception cref="T:System.Security.SecurityException">Недостаточно разрешений для изолированного хранения.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Хранилище не удалось открыть.  
		///
		/// или - 
		/// Указанная сборка не имеет достаточно разрешений для создания изолированных хранилищ.  
		///
		/// или - 
		/// Расположение изолированного хранилища не может быть инициализировано.  
		///
		/// или - 
		/// Невозможно определить разрешения для домена приложений.</exception>
		// Token: 0x06006A98 RID: 27288 RVA: 0x0016CD40 File Offset: 0x0016AF40
		[IsolatedStorageFilePermission(SecurityAction.Demand, UsageAllowed = IsolatedStorageContainment.DomainIsolationByUser)]
		public static IsolatedStorageFile GetUserStoreForDomain()
		{
			IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly);
			isolatedStorageFile._domainIdentity = IsolatedStorageFile.GetDomainIdentityFromEvidence(AppDomain.CurrentDomain.Evidence);
			Evidence evidence = Assembly.GetCallingAssembly().UnprotectedGetEvidence();
			isolatedStorageFile._fullEvidences = evidence;
			isolatedStorageFile._assemblyIdentity = IsolatedStorageFile.GetAssemblyIdentityFromEvidence(evidence);
			isolatedStorageFile.PostInit();
			return isolatedStorageFile;
		}

		/// <summary>Получает изолированное хранилище с определенной пользователем областью действия для использования приложениями в домене виртуального узла.</summary>
		/// <returns>Файл изолированного хранилища, соответствующий области изолированного хранилища на основе удостоверения приложения вызывающего кода.</returns>
		// Token: 0x06006A99 RID: 27289 RVA: 0x000472C8 File Offset: 0x000454C8
		[ComVisible(false)]
		public static IsolatedStorageFile GetUserStoreForSite()
		{
			throw new NotSupportedException();
		}

		/// <summary>Удаляет для всех удостоверений указанную область ограниченного действия изолированного хранения.</summary>
		/// <param name="scope">Поразрядное сочетание значений <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />.</param>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Невозможно удалить изолированное хранилище.</exception>
		// Token: 0x06006A9A RID: 27290 RVA: 0x0016CD8C File Offset: 0x0016AF8C
		public static void Remove(IsolatedStorageScope scope)
		{
			string isolatedStorageRoot = IsolatedStorageFile.GetIsolatedStorageRoot(scope);
			if (!Directory.Exists(isolatedStorageRoot))
			{
				return;
			}
			try
			{
				Directory.Delete(isolatedStorageRoot, true);
			}
			catch (IOException)
			{
				throw new IsolatedStorageException("Could not remove storage.");
			}
		}

		// Token: 0x06006A9B RID: 27291 RVA: 0x0016CDD0 File Offset: 0x0016AFD0
		internal static string GetIsolatedStorageRoot(IsolatedStorageScope scope)
		{
			string text = null;
			if ((scope & IsolatedStorageScope.User) != IsolatedStorageScope.None)
			{
				if ((scope & IsolatedStorageScope.Roaming) != IsolatedStorageScope.None)
				{
					text = Environment.UnixGetFolderPath(Environment.SpecialFolder.LocalApplicationData, Environment.SpecialFolderOption.Create);
				}
				else
				{
					text = Environment.UnixGetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.Create);
				}
			}
			else if ((scope & IsolatedStorageScope.Machine) != IsolatedStorageScope.None)
			{
				text = Environment.UnixGetFolderPath(Environment.SpecialFolder.CommonApplicationData, Environment.SpecialFolderOption.Create);
			}
			if (text == null)
			{
				throw new IsolatedStorageException(string.Format(Locale.GetText("Couldn't access storage location for '{0}'."), scope));
			}
			return Path.Combine(text, ".isolated-storage");
		}

		// Token: 0x06006A9C RID: 27292 RVA: 0x0016CE43 File Offset: 0x0016B043
		private static void Demand(IsolatedStorageScope scope)
		{
			if (SecurityManager.SecurityEnabled)
			{
				new IsolatedStorageFilePermission(PermissionState.None)
				{
					UsageAllowed = IsolatedStorageFile.ScopeToContainment(scope)
				}.Demand();
			}
		}

		// Token: 0x06006A9D RID: 27293 RVA: 0x0016CE64 File Offset: 0x0016B064
		private static IsolatedStorageContainment ScopeToContainment(IsolatedStorageScope scope)
		{
			if (scope <= (IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Roaming))
			{
				if (scope <= (IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly))
				{
					if (scope == (IsolatedStorageScope.User | IsolatedStorageScope.Assembly))
					{
						return IsolatedStorageContainment.AssemblyIsolationByUser;
					}
					if (scope == (IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly))
					{
						return IsolatedStorageContainment.DomainIsolationByUser;
					}
				}
				else
				{
					if (scope == (IsolatedStorageScope.User | IsolatedStorageScope.Assembly | IsolatedStorageScope.Roaming))
					{
						return IsolatedStorageContainment.AssemblyIsolationByRoamingUser;
					}
					if (scope == (IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Roaming))
					{
						return IsolatedStorageContainment.DomainIsolationByRoamingUser;
					}
				}
			}
			else if (scope <= (IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine))
			{
				if (scope == (IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine))
				{
					return IsolatedStorageContainment.AssemblyIsolationByMachine;
				}
				if (scope == (IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine))
				{
					return IsolatedStorageContainment.DomainIsolationByMachine;
				}
			}
			else
			{
				if (scope == (IsolatedStorageScope.User | IsolatedStorageScope.Application))
				{
					return IsolatedStorageContainment.ApplicationIsolationByUser;
				}
				if (scope == (IsolatedStorageScope.User | IsolatedStorageScope.Roaming | IsolatedStorageScope.Application))
				{
					return IsolatedStorageContainment.ApplicationIsolationByRoamingUser;
				}
				if (scope == (IsolatedStorageScope.Machine | IsolatedStorageScope.Application))
				{
					return IsolatedStorageContainment.ApplicationIsolationByMachine;
				}
			}
			return IsolatedStorageContainment.UnrestrictedIsolatedStorage;
		}

		// Token: 0x06006A9E RID: 27294 RVA: 0x0016CED4 File Offset: 0x0016B0D4
		internal static ulong GetDirectorySize(DirectoryInfo di)
		{
			ulong num = 0UL;
			foreach (FileInfo fileInfo in di.GetFiles())
			{
				num += (ulong)fileInfo.Length;
			}
			foreach (DirectoryInfo di2 in di.GetDirectories())
			{
				num += IsolatedStorageFile.GetDirectorySize(di2);
			}
			return num;
		}

		// Token: 0x06006A9F RID: 27295 RVA: 0x0016CF2E File Offset: 0x0016B12E
		private IsolatedStorageFile(IsolatedStorageScope scope)
		{
			this.storage_scope = scope;
		}

		// Token: 0x06006AA0 RID: 27296 RVA: 0x0016CF3D File Offset: 0x0016B13D
		internal IsolatedStorageFile(IsolatedStorageScope scope, string location)
		{
			this.storage_scope = scope;
			this.directory = new DirectoryInfo(location);
			if (!this.directory.Exists)
			{
				throw new IsolatedStorageException(Locale.GetText("Invalid storage."));
			}
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x06006AA1 RID: 27297 RVA: 0x0016CF78 File Offset: 0x0016B178
		~IsolatedStorageFile()
		{
		}

		// Token: 0x06006AA2 RID: 27298 RVA: 0x0016CFA0 File Offset: 0x0016B1A0
		private void PostInit()
		{
			string text = IsolatedStorageFile.GetIsolatedStorageRoot(base.Scope);
			string path;
			if (this._applicationIdentity != null)
			{
				path = string.Format("a{0}{1}", this.SeparatorInternal, this.GetNameFromIdentity(this._applicationIdentity));
			}
			else if (this._domainIdentity != null)
			{
				path = string.Format("d{0}{1}{0}{2}", this.SeparatorInternal, this.GetNameFromIdentity(this._domainIdentity), this.GetNameFromIdentity(this._assemblyIdentity));
			}
			else
			{
				if (this._assemblyIdentity == null)
				{
					throw new IsolatedStorageException(Locale.GetText("No code identity available."));
				}
				path = string.Format("d{0}none{0}{1}", this.SeparatorInternal, this.GetNameFromIdentity(this._assemblyIdentity));
			}
			text = Path.Combine(text, path);
			this.directory = new DirectoryInfo(text);
			if (!this.directory.Exists)
			{
				try
				{
					this.directory.Create();
					this.SaveIdentities(text);
				}
				catch (IOException)
				{
				}
			}
		}

		/// <summary>Получает текущий размер изолированного хранения.</summary>
		/// <returns>Общее число байтов хранилища, используемых в текущий момент в области ограниченного действия изолированного хранения.</returns>
		/// <exception cref="T:System.InvalidOperationException">Свойство недоступно. Текущее хранилище имеет перемещаемую область действия или не открыто.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Размер текущего объекта не определен.</exception>
		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06006AA3 RID: 27299 RVA: 0x0016D0A4 File Offset: 0x0016B2A4
		[CLSCompliant(false)]
		[Obsolete]
		public override ulong CurrentSize
		{
			get
			{
				return IsolatedStorageFile.GetDirectorySize(this.directory);
			}
		}

		/// <summary>Возвращает значение, представляющее максимальный размер области, доступной для изолированного хранения в пределах, установленных квотой.</summary>
		/// <returns>Ограничение области изолированного хранения в байтах.</returns>
		/// <exception cref="T:System.InvalidOperationException">Свойство недоступно. <see cref="P:System.IO.IsolatedStorage.IsolatedStorageFile.MaximumSize" /> невозможно определить без свидетельства от создания сборки. Свидетельство не может быть определено после создания объекта.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Произошла ошибка изолированного хранения.</exception>
		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06006AA4 RID: 27300 RVA: 0x0016D0B4 File Offset: 0x0016B2B4
		[CLSCompliant(false)]
		[Obsolete]
		public override ulong MaximumSize
		{
			get
			{
				if (!SecurityManager.SecurityEnabled)
				{
					return 9223372036854775807UL;
				}
				if (this._resolved)
				{
					return this._maxSize;
				}
				Evidence evidence;
				if (this._fullEvidences != null)
				{
					evidence = this._fullEvidences;
				}
				else
				{
					evidence = new Evidence();
					if (this._assemblyIdentity != null)
					{
						evidence.AddHost(this._assemblyIdentity);
					}
				}
				if (evidence.Count < 1)
				{
					throw new InvalidOperationException(Locale.GetText("Couldn't get the quota from the available evidences."));
				}
				PermissionSet permissionSet = null;
				PermissionSet permissionSet2 = SecurityManager.ResolvePolicy(evidence, null, null, null, out permissionSet);
				IsolatedStoragePermission permission = this.GetPermission(permissionSet2);
				if (permission == null)
				{
					if (!permissionSet2.IsUnrestricted())
					{
						throw new InvalidOperationException(Locale.GetText("No quota from the available evidences."));
					}
					this._maxSize = 9223372036854775807UL;
				}
				else
				{
					this._maxSize = (ulong)permission.UserQuota;
				}
				this._resolved = true;
				return this._maxSize;
			}
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06006AA5 RID: 27301 RVA: 0x0016D182 File Offset: 0x0016B382
		internal string Root
		{
			get
			{
				return this.directory.FullName;
			}
		}

		/// <summary>Получает значение, показывающее объем свободного пространства, доступного для изолированного хранилища.</summary>
		/// <returns>Доступное свободное пространство для изолированного хранилища в байтах.</returns>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище закрыто.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06006AA6 RID: 27302 RVA: 0x0016D18F File Offset: 0x0016B38F
		[ComVisible(false)]
		public override long AvailableFreeSpace
		{
			get
			{
				this.CheckOpen();
				return long.MaxValue;
			}
		}

		/// <summary>Получает значение, представляющее максимальный объем свободного пространства, доступного для изолированной памяти.</summary>
		/// <returns>Ограничение объема изолированного хранилища в байтах.</returns>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06006AA7 RID: 27303 RVA: 0x0016D1A0 File Offset: 0x0016B3A0
		[ComVisible(false)]
		public override long Quota
		{
			get
			{
				this.CheckOpen();
				return (long)this.MaximumSize;
			}
		}

		/// <summary>Получает значение, показывающее объем пространства, используемого для изолированного хранилища.</summary>
		/// <returns>Объем пространства, используемого для изолированного хранилища, в байтах.</returns>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище было закрыто.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06006AA8 RID: 27304 RVA: 0x0016D1AE File Offset: 0x0016B3AE
		[ComVisible(false)]
		public override long UsedSize
		{
			get
			{
				this.CheckOpen();
				return (long)IsolatedStorageFile.GetDirectorySize(this.directory);
			}
		}

		/// <summary>Получает значение, указывающее, включено ли изолированное хранилище.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06006AA9 RID: 27305 RVA: 0x000040F7 File Offset: 0x000022F7
		[ComVisible(false)]
		public static bool IsEnabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06006AAA RID: 27306 RVA: 0x0016D1C1 File Offset: 0x0016B3C1
		internal bool IsClosed
		{
			get
			{
				return this.closed;
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06006AAB RID: 27307 RVA: 0x0016D1C9 File Offset: 0x0016B3C9
		internal bool IsDisposed
		{
			get
			{
				return this.disposed;
			}
		}

		/// <summary>Закрывает хранилище, открытое ранее с помощью метода <see cref="M:System.IO.IsolatedStorage.IsolatedStorageFile.GetStore(System.IO.IsolatedStorage.IsolatedStorageScope,System.Type,System.Type)" />, <see cref="M:System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForAssembly" /> или <see cref="M:System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForDomain" />.</summary>
		// Token: 0x06006AAC RID: 27308 RVA: 0x0016D1D1 File Offset: 0x0016B3D1
		public void Close()
		{
			this.closed = true;
		}

		/// <summary>Создает в области ограниченного действия изолированного хранения папку.</summary>
		/// <param name="dir">Относительный путь к папке для создания в области ограниченного действия изолированного хранения.</param>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Текущий код не имеет достаточно разрешений для создания папки изолированного хранения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Путь к папке — <see langword="null" />.</exception>
		// Token: 0x06006AAD RID: 27309 RVA: 0x0016D1DC File Offset: 0x0016B3DC
		public void CreateDirectory(string dir)
		{
			if (dir == null)
			{
				throw new ArgumentNullException("dir");
			}
			if (dir.IndexOfAny(Path.PathSeparatorChars) >= 0)
			{
				string[] array = dir.Split(Path.PathSeparatorChars, StringSplitOptions.RemoveEmptyEntries);
				DirectoryInfo directoryInfo = this.directory;
				for (int i = 0; i < array.Length; i++)
				{
					if (directoryInfo.GetFiles(array[i]).Length != 0)
					{
						throw new IsolatedStorageException("Unable to create directory.");
					}
					directoryInfo = directoryInfo.CreateSubdirectory(array[i]);
				}
				return;
			}
			if (this.directory.GetFiles(dir).Length != 0)
			{
				throw new IsolatedStorageException("Unable to create directory.");
			}
			this.directory.CreateSubdirectory(dir);
		}

		/// <summary>Копирует существующий файл в новый файл.</summary>
		/// <param name="sourceFileName">Имя копируемого файла.</param>
		/// <param name="destinationFileName">Имя конечного файла. Это не может быть имя каталога или имя существующего файла.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="sourceFileName" /> или <paramref name="destinationFileName" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую хотя бы один недопустимый символ, заданный методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceFileName" /> или <paramref name="destinationFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище было закрыто.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="sourceFileName" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Не удалось найти <paramref name="sourceFileName" />.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.  
		///
		/// или - 
		/// <paramref name="destinationFileName" /> существует.  
		///
		/// или - 
		/// Произошла ошибка ввода-вывода.</exception>
		// Token: 0x06006AAE RID: 27310 RVA: 0x0016D270 File Offset: 0x0016B470
		[ComVisible(false)]
		public void CopyFile(string sourceFileName, string destinationFileName)
		{
			this.CopyFile(sourceFileName, destinationFileName, false);
		}

		/// <summary>Копирует существующий файл в новый файл и, возможно, перезаписывает существующий файл.</summary>
		/// <param name="sourceFileName">Имя копируемого файла.</param>
		/// <param name="destinationFileName">Имя конечного файла. Это не может быть имя каталога.</param>
		/// <param name="overwrite">
		///   <see langword="true" />, если конечный файл можно перезаписать; в противном случае — <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="sourceFileName" /> или <paramref name="destinationFileName" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую хотя бы один недопустимый символ, заданный методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceFileName" /> или <paramref name="destinationFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище было закрыто.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="sourceFileName" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Не удалось найти <paramref name="sourceFileName" />.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.  
		///
		/// или - 
		/// Произошла ошибка ввода-вывода.</exception>
		// Token: 0x06006AAF RID: 27311 RVA: 0x0016D27C File Offset: 0x0016B47C
		[ComVisible(false)]
		public void CopyFile(string sourceFileName, string destinationFileName, bool overwrite)
		{
			if (sourceFileName == null)
			{
				throw new ArgumentNullException("sourceFileName");
			}
			if (destinationFileName == null)
			{
				throw new ArgumentNullException("destinationFileName");
			}
			if (sourceFileName.Trim().Length == 0)
			{
				throw new ArgumentException("An empty file name is not valid.", "sourceFileName");
			}
			if (destinationFileName.Trim().Length == 0)
			{
				throw new ArgumentException("An empty file name is not valid.", "destinationFileName");
			}
			this.CheckOpen();
			string text = Path.Combine(this.directory.FullName, sourceFileName);
			string text2 = Path.Combine(this.directory.FullName, destinationFileName);
			if (!this.IsPathInStorage(text) || !this.IsPathInStorage(text2))
			{
				throw new IsolatedStorageException("Operation not allowed.");
			}
			if (!Directory.Exists(Path.GetDirectoryName(text)))
			{
				throw new DirectoryNotFoundException("Could not find a part of path '" + sourceFileName + "'.");
			}
			if (!File.Exists(text))
			{
				throw new FileNotFoundException("Could not find a part of path '" + sourceFileName + "'.");
			}
			if (File.Exists(text2) && !overwrite)
			{
				throw new IsolatedStorageException("Operation not allowed.");
			}
			try
			{
				File.Copy(text, text2, overwrite);
			}
			catch (IOException inner)
			{
				throw new IsolatedStorageException("Operation not allowed.", inner);
			}
			catch (UnauthorizedAccessException inner2)
			{
				throw new IsolatedStorageException("Operation not allowed.", inner2);
			}
		}

		/// <summary>Создает файл в изолированном хранилище.</summary>
		/// <param name="path">Относительный путь к создаваемому файлу.</param>
		/// <returns>Новый файл в изолированном хранилище.</returns>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.</exception>
		/// <exception cref="T:System.ArgumentException">Неверный формат параметра <paramref name="path" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Каталог в <paramref name="path" /> не существует.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		// Token: 0x06006AB0 RID: 27312 RVA: 0x0016D3C0 File Offset: 0x0016B5C0
		[ComVisible(false)]
		public IsolatedStorageFileStream CreateFile(string path)
		{
			return new IsolatedStorageFileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None, this);
		}

		/// <summary>Удаляет из области ограниченного действия изолированного хранилища папку.</summary>
		/// <param name="dir">Относительный путь к папке для удаления из области изолированного хранения.</param>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Невозможно удалить папку.</exception>
		/// <exception cref="T:System.ArgumentNullException">Путь к папке — <see langword="null" />.</exception>
		// Token: 0x06006AB1 RID: 27313 RVA: 0x0016D3CC File Offset: 0x0016B5CC
		public void DeleteDirectory(string dir)
		{
			try
			{
				if (Path.IsPathRooted(dir))
				{
					dir = dir.Substring(1);
				}
				this.directory.CreateSubdirectory(dir).Delete();
			}
			catch
			{
				throw new IsolatedStorageException(Locale.GetText("Could not delete directory '{0}'", new object[]
				{
					dir
				}));
			}
		}

		/// <summary>Удаляет из области ограниченного действия изолированного хранилища файл.</summary>
		/// <param name="file">Относительный путь к файлу для удаления из области ограниченного действия изолированного хранения.</param>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Конечный файл открыт или путь неверен.</exception>
		/// <exception cref="T:System.ArgumentNullException">Путь к файлу — <see langword="null" />.</exception>
		// Token: 0x06006AB2 RID: 27314 RVA: 0x0016D428 File Offset: 0x0016B628
		public void DeleteFile(string file)
		{
			if (file == null)
			{
				throw new ArgumentNullException("file");
			}
			if (!File.Exists(Path.Combine(this.directory.FullName, file)))
			{
				throw new IsolatedStorageException(Locale.GetText("Could not delete file '{0}'", new object[]
				{
					file
				}));
			}
			try
			{
				File.Delete(Path.Combine(this.directory.FullName, file));
			}
			catch
			{
				throw new IsolatedStorageException(Locale.GetText("Could not delete file '{0}'", new object[]
				{
					file
				}));
			}
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" />.</summary>
		// Token: 0x06006AB3 RID: 27315 RVA: 0x0016D4BC File Offset: 0x0016B6BC
		public void Dispose()
		{
			this.disposed = true;
			GC.SuppressFinalize(this);
		}

		/// <summary>Определяет, указывает ли заданный путь на существующий каталог в изолированном хранилище.</summary>
		/// <param name="path">Проверяемый путь.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="path" /> указывает на существующий каталог в изолированном хранилище и не равен <see langword="null" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище закрыто.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.</exception>
		// Token: 0x06006AB4 RID: 27316 RVA: 0x0016D4CC File Offset: 0x0016B6CC
		[ComVisible(false)]
		public bool DirectoryExists(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			this.CheckOpen();
			string path2 = Path.Combine(this.directory.FullName, path);
			return this.IsPathInStorage(path2) && Directory.Exists(path2);
		}

		/// <summary>Определяет, указывает ли заданный путь на существующий файл в изолированном хранилище.</summary>
		/// <param name="path">Путь и имя файла для проверки.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="path" /> указывает на существующий файл в изолированном хранилище и не равен <see langword="null" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище закрыто.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.</exception>
		// Token: 0x06006AB5 RID: 27317 RVA: 0x0016D510 File Offset: 0x0016B710
		[ComVisible(false)]
		public bool FileExists(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			this.CheckOpen();
			string path2 = Path.Combine(this.directory.FullName, path);
			return this.IsPathInStorage(path2) && File.Exists(path2);
		}

		/// <summary>Возвращает дату и время создания заданного файла или каталога.</summary>
		/// <param name="path">Путь к файлу или каталогу, для которых требуется получить сведения о дате и времени создания.</param>
		/// <returns>Дата и время создания заданного файла или каталога. Значение представляется в формате местного времени.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> является пустой строкой, содержит только пробел либо один или несколько недопустимых символов, определенных методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище было закрыто.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.</exception>
		// Token: 0x06006AB6 RID: 27318 RVA: 0x0016D554 File Offset: 0x0016B754
		[ComVisible(false)]
		public DateTimeOffset GetCreationTime(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Trim().Length == 0)
			{
				throw new ArgumentException("An empty path is not valid.");
			}
			this.CheckOpen();
			string path2 = Path.Combine(this.directory.FullName, path);
			if (File.Exists(path2))
			{
				return File.GetCreationTime(path2);
			}
			return Directory.GetCreationTime(path2);
		}

		/// <summary>Возвращает дату и время последнего обращения к указанному файлу или каталогу.</summary>
		/// <param name="path">Путь к файлу или каталогу, для которых требуется получить сведения о дате и времени последнего обращения.</param>
		/// <returns>Дата и время последнего обращения к заданному файлу или каталогу. Значение представляется в формате местного времени.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> является пустой строкой, содержит только пробел либо один или несколько недопустимых символов, определенных методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище было закрыто.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.</exception>
		// Token: 0x06006AB7 RID: 27319 RVA: 0x0016D5C0 File Offset: 0x0016B7C0
		[ComVisible(false)]
		public DateTimeOffset GetLastAccessTime(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Trim().Length == 0)
			{
				throw new ArgumentException("An empty path is not valid.");
			}
			this.CheckOpen();
			string path2 = Path.Combine(this.directory.FullName, path);
			if (File.Exists(path2))
			{
				return File.GetLastAccessTime(path2);
			}
			return Directory.GetLastAccessTime(path2);
		}

		/// <summary>Возвращает дату и время последней операции записи в указанный файл или каталог.</summary>
		/// <param name="path">Путь к файлу или каталогу, для которых требуется получить сведения о дате и времени последней операции записи.</param>
		/// <returns>Дата и время последней операции записи в указанный файл или каталог. Значение представляется в формате местного времени.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="path" /> является пустой строкой, содержит только пробел либо один или несколько недопустимых символов, определенных методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище было закрыто.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.</exception>
		// Token: 0x06006AB8 RID: 27320 RVA: 0x0016D62C File Offset: 0x0016B82C
		[ComVisible(false)]
		public DateTimeOffset GetLastWriteTime(string path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (path.Trim().Length == 0)
			{
				throw new ArgumentException("An empty path is not valid.");
			}
			this.CheckOpen();
			string path2 = Path.Combine(this.directory.FullName, path);
			if (File.Exists(path2))
			{
				return File.GetLastWriteTime(path2);
			}
			return Directory.GetLastWriteTime(path2);
		}

		/// <summary>Перечисляет каталоги в области изолированного хранилища, соответствующие заданному шаблону поиска.</summary>
		/// <param name="searchPattern">Шаблон поиска. Поддерживаются как одиночные ("?"), так и составные ("*") подстановочные знаки.</param>
		/// <returns>Массив относительных путей к каталогам в области изолированного хранилища, соответствующих параметру <paramref name="searchPattern" />. Массив нулевой длины указывает на отсутствие соответствующих папок.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище закрыто.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Вызывающий объект не имеет разрешения на перечисление каталогов, разрешенных из <paramref name="searchPattern" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Каталог или каталоги, указанные параметром <paramref name="searchPattern" />, не найдены.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.</exception>
		// Token: 0x06006AB9 RID: 27321 RVA: 0x0016D698 File Offset: 0x0016B898
		public string[] GetDirectoryNames(string searchPattern)
		{
			if (searchPattern == null)
			{
				throw new ArgumentNullException("searchPattern");
			}
			if (searchPattern.Contains(".."))
			{
				throw new ArgumentException("Search pattern cannot contain '..' to move up directories.", "searchPattern");
			}
			string directoryName = Path.GetDirectoryName(searchPattern);
			string fileName = Path.GetFileName(searchPattern);
			DirectoryInfo[] array = null;
			if (directoryName == null || directoryName.Length == 0)
			{
				array = this.directory.GetDirectories(searchPattern);
			}
			else
			{
				DirectoryInfo directoryInfo = this.directory.GetDirectories(directoryName)[0];
				if (directoryInfo.FullName.IndexOf(this.directory.FullName) >= 0)
				{
					array = directoryInfo.GetDirectories(fileName);
					string[] array2 = directoryName.Split(new char[]
					{
						Path.DirectorySeparatorChar
					}, StringSplitOptions.RemoveEmptyEntries);
					for (int i = array2.Length - 1; i >= 0; i--)
					{
						if (directoryInfo.Name != array2[i])
						{
							array = null;
							break;
						}
						directoryInfo = directoryInfo.Parent;
					}
				}
			}
			if (array == null)
			{
				throw new SecurityException();
			}
			FileSystemInfo[] afsi = array;
			return this.GetNames(afsi);
		}

		/// <summary>Перечисляет каталоги в корневой папке изолированного хранилища.</summary>
		/// <returns>Массив относительных путей каталогов в корневой папке изолированного хранилища. Массив нулевой длины указывает на отсутствие каталогов в корневой папке.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище закрыто.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Вызывающий объект не имеет разрешения на перечисление каталогов.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Один или несколько каталогов не найдены.</exception>
		// Token: 0x06006ABA RID: 27322 RVA: 0x0016D787 File Offset: 0x0016B987
		[ComVisible(false)]
		public string[] GetDirectoryNames()
		{
			return this.GetDirectoryNames("*");
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x0016D794 File Offset: 0x0016B994
		private string[] GetNames(FileSystemInfo[] afsi)
		{
			string[] array = new string[afsi.Length];
			for (int num = 0; num != afsi.Length; num++)
			{
				array[num] = afsi[num].Name;
			}
			return array;
		}

		/// <summary>Получает имена файлов, соответствующие шаблону поиска.</summary>
		/// <param name="searchPattern">Шаблон поиска. Поддерживаются как одиночные ("?"), так и составные ("*") подстановочные знаки.</param>
		/// <returns>Массив относительных путей к файлам в области изолированного хранилища, соответствующим параметру <paramref name="searchPattern" />. Массив нулевой длины указывает на отсутствие соответствующих файлов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="searchPattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Не удается найти путь к файлу, заданный параметром <paramref name="searchPattern" />.</exception>
		// Token: 0x06006ABC RID: 27324 RVA: 0x0016D7C4 File Offset: 0x0016B9C4
		public string[] GetFileNames(string searchPattern)
		{
			if (searchPattern == null)
			{
				throw new ArgumentNullException("searchPattern");
			}
			if (searchPattern.Contains(".."))
			{
				throw new ArgumentException("Search pattern cannot contain '..' to move up directories.", "searchPattern");
			}
			string directoryName = Path.GetDirectoryName(searchPattern);
			string fileName = Path.GetFileName(searchPattern);
			FileInfo[] files;
			if (directoryName == null || directoryName.Length == 0)
			{
				files = this.directory.GetFiles(searchPattern);
			}
			else
			{
				DirectoryInfo[] directories = this.directory.GetDirectories(directoryName);
				if (directories.Length != 1)
				{
					throw new SecurityException();
				}
				if (!directories[0].FullName.StartsWith(this.directory.FullName))
				{
					throw new SecurityException();
				}
				if (directories[0].FullName.Substring(this.directory.FullName.Length + 1) != directoryName)
				{
					throw new SecurityException();
				}
				files = directories[0].GetFiles(fileName);
			}
			FileSystemInfo[] afsi = files;
			return this.GetNames(afsi);
		}

		/// <summary>Перечисляет имена файлов в корневой папке изолированного хранилища.</summary>
		/// <returns>Массив относительных путей файлов в корневой папке изолированного хранилища.  Массив нулевой длины указывает на отсутствие файлов в корневой папке.</returns>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Пути к файлам из корня изолированного хранилища не могут быть определены.</exception>
		// Token: 0x06006ABD RID: 27325 RVA: 0x0016D89D File Offset: 0x0016BA9D
		[ComVisible(false)]
		public string[] GetFileNames()
		{
			return this.GetFileNames("*");
		}

		/// <summary>Позволяет приложению в явной форме запросить больший размер квоты в байтах.</summary>
		/// <param name="newQuotaSize">Запрошенный размер, в байтах.</param>
		/// <returns>Значение <see langword="true" />, если новая квота принята; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="newQuotaSize" /> меньше текущего размера квоты.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="newQuotaSize" /> меньше нуля, или же меньше либо равен текущему размеру квоты.</exception>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище было закрыто.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущая область не предназначена для пользователя приложения.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.</exception>
		// Token: 0x06006ABE RID: 27326 RVA: 0x0016D8AA File Offset: 0x0016BAAA
		[ComVisible(false)]
		public override bool IncreaseQuotaTo(long newQuotaSize)
		{
			if (newQuotaSize < this.Quota)
			{
				throw new ArgumentException();
			}
			this.CheckOpen();
			return false;
		}

		/// <summary>Перемещает указанный каталог и его содержимое в новое расположение.</summary>
		/// <param name="sourceDirectoryName">Имя перемещаемого каталога.</param>
		/// <param name="destinationDirectoryName">Путь к новому местоположению <paramref name="sourceDirectoryName" />. Этот путь не может указывать на существующий каталог.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="sourceFileName" /> или <paramref name="destinationFileName" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую хотя бы один недопустимый символ, заданный методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceFileName" /> или <paramref name="destinationFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище было закрыто.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///   <paramref name="sourceDirectoryName" /> — не существует.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.  
		///
		/// или - 
		/// <paramref name="destinationDirectoryName" /> уже существует.  
		///
		/// или - 
		/// Параметры <paramref name="sourceDirectoryName" /> и <paramref name="destinationDirectoryName" /> ссылаются на один и тот же каталог.</exception>
		// Token: 0x06006ABF RID: 27327 RVA: 0x0016D8C4 File Offset: 0x0016BAC4
		[ComVisible(false)]
		public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName)
		{
			if (sourceDirectoryName == null)
			{
				throw new ArgumentNullException("sourceDirectoryName");
			}
			if (destinationDirectoryName == null)
			{
				throw new ArgumentNullException("sourceDirectoryName");
			}
			if (sourceDirectoryName.Trim().Length == 0)
			{
				throw new ArgumentException("An empty directory name is not valid.", "sourceDirectoryName");
			}
			if (destinationDirectoryName.Trim().Length == 0)
			{
				throw new ArgumentException("An empty directory name is not valid.", "destinationDirectoryName");
			}
			this.CheckOpen();
			string text = Path.Combine(this.directory.FullName, sourceDirectoryName);
			string text2 = Path.Combine(this.directory.FullName, destinationDirectoryName);
			if (!this.IsPathInStorage(text) || !this.IsPathInStorage(text2))
			{
				throw new IsolatedStorageException("Operation not allowed.");
			}
			if (!Directory.Exists(text))
			{
				throw new DirectoryNotFoundException("Could not find a part of path '" + sourceDirectoryName + "'.");
			}
			if (!Directory.Exists(Path.GetDirectoryName(text2)))
			{
				throw new DirectoryNotFoundException("Could not find a part of path '" + destinationDirectoryName + "'.");
			}
			try
			{
				Directory.Move(text, text2);
			}
			catch (IOException inner)
			{
				throw new IsolatedStorageException("Operation not allowed.", inner);
			}
			catch (UnauthorizedAccessException inner2)
			{
				throw new IsolatedStorageException("Operation not allowed.", inner2);
			}
		}

		/// <summary>Перемещает указанный файл в новое расположение и позволяет указать для файла новое имя.</summary>
		/// <param name="sourceFileName">Имя перемещаемого файла.</param>
		/// <param name="destinationFileName">Путь к новому расположению файла. Если путь включает имя файла, перемещенный файл будет иметь это имя.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="sourceFileName" /> или <paramref name="destinationFileName" /> представляет собой строку нулевой длины, строку, содержащую только пробел, или строку, содержащую хотя бы один недопустимый символ, заданный методом <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceFileName" /> или <paramref name="destinationFileName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Изолированное хранилище было закрыто.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удалось найти <paramref name="sourceFileName" />.</exception>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.</exception>
		// Token: 0x06006AC0 RID: 27328 RVA: 0x0016D9F0 File Offset: 0x0016BBF0
		[ComVisible(false)]
		public void MoveFile(string sourceFileName, string destinationFileName)
		{
			if (sourceFileName == null)
			{
				throw new ArgumentNullException("sourceFileName");
			}
			if (destinationFileName == null)
			{
				throw new ArgumentNullException("sourceFileName");
			}
			if (sourceFileName.Trim().Length == 0)
			{
				throw new ArgumentException("An empty file name is not valid.", "sourceFileName");
			}
			if (destinationFileName.Trim().Length == 0)
			{
				throw new ArgumentException("An empty file name is not valid.", "destinationFileName");
			}
			this.CheckOpen();
			string text = Path.Combine(this.directory.FullName, sourceFileName);
			string text2 = Path.Combine(this.directory.FullName, destinationFileName);
			if (!this.IsPathInStorage(text) || !this.IsPathInStorage(text2))
			{
				throw new IsolatedStorageException("Operation not allowed.");
			}
			if (!File.Exists(text))
			{
				throw new FileNotFoundException("Could not find a part of path '" + sourceFileName + "'.");
			}
			if (!Directory.Exists(Path.GetDirectoryName(text2)))
			{
				throw new IsolatedStorageException("Operation not allowed.");
			}
			try
			{
				File.Move(text, text2);
			}
			catch (UnauthorizedAccessException inner)
			{
				throw new IsolatedStorageException("Operation not allowed.", inner);
			}
		}

		/// <summary>Открывает файл в заданном режиме.</summary>
		/// <param name="path">Относительный путь к файлу внутри изолированного хранилища.</param>
		/// <param name="mode">Одно из значений перечисления, задающее способ открытия файла.</param>
		/// <returns>Файл, открытый в заданном режиме, с доступом для чтения и записи и без предоставления общего доступа.</returns>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.</exception>
		/// <exception cref="T:System.ArgumentException">Неверный формат параметра <paramref name="path" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Каталог в <paramref name="path" /> не существует.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл не найден, и <paramref name="mode" /> имеет значение <see cref="F:System.IO.FileMode.Open" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		// Token: 0x06006AC1 RID: 27329 RVA: 0x0016DAF8 File Offset: 0x0016BCF8
		[ComVisible(false)]
		public IsolatedStorageFileStream OpenFile(string path, FileMode mode)
		{
			return new IsolatedStorageFileStream(path, mode, this);
		}

		/// <summary>Открывает файл в заданном режиме с заданным доступом для чтения и записи.</summary>
		/// <param name="path">Относительный путь к файлу внутри изолированного хранилища.</param>
		/// <param name="mode">Одно из значений перечисления, задающее способ открытия файла.</param>
		/// <param name="access">Одно из значений перечисления, определяющее, с какими правами открывается файл: только для чтения, только для записи или для чтения и записи.</param>
		/// <returns>Файл, открытый в заданном режиме, с заданным уровнем доступа и без предоставления общего доступа.</returns>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.</exception>
		/// <exception cref="T:System.ArgumentException">Неверный формат параметра <paramref name="path" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Каталог в <paramref name="path" /> не существует.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл не найден, и <paramref name="mode" /> имеет значение <see cref="F:System.IO.FileMode.Open" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		// Token: 0x06006AC2 RID: 27330 RVA: 0x0016DB02 File Offset: 0x0016BD02
		[ComVisible(false)]
		public IsolatedStorageFileStream OpenFile(string path, FileMode mode, FileAccess access)
		{
			return new IsolatedStorageFileStream(path, mode, access, this);
		}

		/// <summary>Открывает файл в заданном режиме, с заданным уровнем доступа для чтения и записи и с разрешением на совместный доступ.</summary>
		/// <param name="path">Относительный путь к файлу внутри изолированного хранилища.</param>
		/// <param name="mode">Одно из значений перечисления, задающее способ открытия или создания файла.</param>
		/// <param name="access">Одно из значений перечисления, определяющее, с какими правами открывается файл: только для чтения, только для записи или для чтения и записи.</param>
		/// <param name="share">Побитовая комбинация значений перечисления, которые определяют тип доступа к файлу для других объектов <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" />.</param>
		/// <returns>Файл, открытый в заданном режиме, с заданным уровнем доступа и с указанными параметрами общего доступа.</returns>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Изолированное хранилище было удалено.  
		///
		/// или - 
		/// Изолированное хранилище отключено.</exception>
		/// <exception cref="T:System.ArgumentException">Неверный формат параметра <paramref name="path" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Каталог в <paramref name="path" /> не существует.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл не найден, и <paramref name="mode" /> имеет значение <see cref="M:System.IO.FileInfo.Open(System.IO.FileMode)" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Изолированное хранилище было ликвидировано.</exception>
		// Token: 0x06006AC3 RID: 27331 RVA: 0x0016DB0D File Offset: 0x0016BD0D
		[ComVisible(false)]
		public IsolatedStorageFileStream OpenFile(string path, FileMode mode, FileAccess access, FileShare share)
		{
			return new IsolatedStorageFileStream(path, mode, access, share, this);
		}

		/// <summary>Удаляет область ограниченного действия изолированного хранения со всем ее содержимым.</summary>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Невозможно удалить изолированное хранилище.</exception>
		// Token: 0x06006AC4 RID: 27332 RVA: 0x0016DB1C File Offset: 0x0016BD1C
		public override void Remove()
		{
			this.CheckOpen(false);
			try
			{
				this.directory.Delete(true);
			}
			catch
			{
				throw new IsolatedStorageException("Could not remove storage.");
			}
			this.Close();
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x0016DB60 File Offset: 0x0016BD60
		protected override IsolatedStoragePermission GetPermission(PermissionSet ps)
		{
			if (ps == null)
			{
				return null;
			}
			return (IsolatedStoragePermission)ps.GetPermission(typeof(IsolatedStorageFilePermission));
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x0016DB7C File Offset: 0x0016BD7C
		private void CheckOpen()
		{
			this.CheckOpen(true);
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x0016DB88 File Offset: 0x0016BD88
		private void CheckOpen(bool checkDirExists)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException("IsolatedStorageFile");
			}
			if (this.closed)
			{
				throw new InvalidOperationException("Storage needs to be open for this operation.");
			}
			if (checkDirExists && !Directory.Exists(this.directory.FullName))
			{
				throw new IsolatedStorageException("Isolated storage has been removed or disabled.");
			}
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x0016DBDB File Offset: 0x0016BDDB
		private bool IsPathInStorage(string path)
		{
			return Path.GetFullPath(path).StartsWith(this.directory.FullName);
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x0016DBF4 File Offset: 0x0016BDF4
		private string GetNameFromIdentity(object identity)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(identity.ToString());
			Array src = SHA1.Create().ComputeHash(bytes, 0, bytes.Length);
			byte[] array = new byte[10];
			Buffer.BlockCopy(src, 0, array, 0, array.Length);
			return CryptoConvert.ToHex(array);
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x0016DC3C File Offset: 0x0016BE3C
		private static object GetTypeFromEvidence(Evidence e, Type t)
		{
			foreach (object obj in e)
			{
				if (obj.GetType() == t)
				{
					return obj;
				}
			}
			return null;
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x0016DC9C File Offset: 0x0016BE9C
		internal static object GetAssemblyIdentityFromEvidence(Evidence e)
		{
			object typeFromEvidence = IsolatedStorageFile.GetTypeFromEvidence(e, typeof(Publisher));
			if (typeFromEvidence != null)
			{
				return typeFromEvidence;
			}
			typeFromEvidence = IsolatedStorageFile.GetTypeFromEvidence(e, typeof(StrongName));
			if (typeFromEvidence != null)
			{
				return typeFromEvidence;
			}
			return IsolatedStorageFile.GetTypeFromEvidence(e, typeof(Url));
		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x0016DCE8 File Offset: 0x0016BEE8
		internal static object GetDomainIdentityFromEvidence(Evidence e)
		{
			object typeFromEvidence = IsolatedStorageFile.GetTypeFromEvidence(e, typeof(ApplicationDirectory));
			if (typeFromEvidence != null)
			{
				return typeFromEvidence;
			}
			return IsolatedStorageFile.GetTypeFromEvidence(e, typeof(Url));
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x0016DD1C File Offset: 0x0016BF1C
		[SecurityPermission(SecurityAction.Assert, SerializationFormatter = true)]
		private void SaveIdentities(string root)
		{
			IsolatedStorageFile.Identities identities = new IsolatedStorageFile.Identities(this._applicationIdentity, this._assemblyIdentity, this._domainIdentity);
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			IsolatedStorageFile.mutex.WaitOne();
			try
			{
				using (FileStream fileStream = File.Create(root + ".storage"))
				{
					binaryFormatter.Serialize(fileStream, identities);
				}
			}
			finally
			{
				IsolatedStorageFile.mutex.ReleaseMutex();
			}
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x000173AD File Offset: 0x000155AD
		internal IsolatedStorageFile()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04003D99 RID: 15769
		private bool _resolved;

		// Token: 0x04003D9A RID: 15770
		private ulong _maxSize;

		// Token: 0x04003D9B RID: 15771
		private Evidence _fullEvidences;

		// Token: 0x04003D9C RID: 15772
		private static readonly Mutex mutex = new Mutex();

		// Token: 0x04003D9D RID: 15773
		private bool closed;

		// Token: 0x04003D9E RID: 15774
		private bool disposed;

		// Token: 0x04003D9F RID: 15775
		private DirectoryInfo directory;

		// Token: 0x02000B74 RID: 2932
		[Serializable]
		private struct Identities
		{
			// Token: 0x06006AD0 RID: 27344 RVA: 0x0016DDB0 File Offset: 0x0016BFB0
			public Identities(object application, object assembly, object domain)
			{
				this.Application = application;
				this.Assembly = assembly;
				this.Domain = domain;
			}

			// Token: 0x04003DA0 RID: 15776
			public object Application;

			// Token: 0x04003DA1 RID: 15777
			public object Assembly;

			// Token: 0x04003DA2 RID: 15778
			public object Domain;
		}
	}
}
