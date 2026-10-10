using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;
using Unity;

namespace System.Security.Principal
{
	/// <summary>Представляет пользователя Windows.</summary>
	// Token: 0x020004EC RID: 1260
	[ComVisible(true)]
	[Serializable]
	public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.WindowsIdentity" /> для пользователя, представленного заданным токеном учетной записи Windows.</summary>
		/// <param name="userToken">Токен учетной записи для пользователя, от лица которого выполняется код.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="userToken" /> имеет значение 0.  
		/// -или- 
		///  Параметр <paramref name="userToken" /> дублирован и недопустим для олицетворения.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта нет нужных разрешений.  
		/// -или- 
		/// Произошла ошибка Win32.</exception>
		// Token: 0x06003244 RID: 12868 RVA: 0x000B9539 File Offset: 0x000B7739
		[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		public WindowsIdentity(IntPtr userToken) : this(userToken, null, WindowsAccountType.Normal, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.WindowsIdentity" /> для пользователя, представленного заданным токеном учетной записи Windows и заданным типом проверки подлинности.</summary>
		/// <param name="userToken">Токен учетной записи для пользователя, от лица которого выполняется код.</param>
		/// <param name="type">(Использовать только для справки.) Тип проверки подлинности, применяемой для идентификации пользователя.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="userToken" /> имеет значение 0.  
		/// -или- 
		///  Параметр <paramref name="userToken" /> дублирован и недопустим для олицетворения.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта нет нужных разрешений.  
		/// -или- 
		/// Произошла ошибка Win32.</exception>
		// Token: 0x06003245 RID: 12869 RVA: 0x000B9545 File Offset: 0x000B7745
		[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		public WindowsIdentity(IntPtr userToken, string type) : this(userToken, type, WindowsAccountType.Normal, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.WindowsIdentity" /> для пользователя, представленного заданными токеном учетной записи Windows, типом проверки подлинности и типом учетной записи Windows.</summary>
		/// <param name="userToken">Токен учетной записи для пользователя, от лица которого выполняется код.</param>
		/// <param name="type">(Использовать только для справки.) Тип проверки подлинности, применяемой для идентификации пользователя.</param>
		/// <param name="acctType">Одно из значений перечисления.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="userToken" /> имеет значение 0.  
		///
		/// или - 
		/// Параметр <paramref name="userToken" /> дублирован и недопустим для олицетворения.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта нет нужных разрешений.  
		///
		/// или - 
		/// Произошла ошибка Win32.</exception>
		// Token: 0x06003246 RID: 12870 RVA: 0x000B9551 File Offset: 0x000B7751
		[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType) : this(userToken, type, acctType, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.WindowsIdentity" /> для пользователя, представленного указанными токеном учетной записи Windows, типом проверки подлинности, типом учетной записи Windows и состоянием проверки подлинности.</summary>
		/// <param name="userToken">Токен учетной записи для пользователя, от лица которого выполняется код.</param>
		/// <param name="type">(Использовать только для справки.) Тип проверки подлинности, применяемой для идентификации пользователя.</param>
		/// <param name="acctType">Одно из значений перечисления.</param>
		/// <param name="isAuthenticated">Значение <see langword="true" /> — пользователь прошел проверку подлинности; в противном случае — <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="userToken" /> имеет значение 0.  
		/// -или- 
		///  Параметр <paramref name="userToken" /> дублирован и недопустим для олицетворения.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта нет нужных разрешений.  
		/// -или- 
		/// Произошла ошибка Win32.</exception>
		// Token: 0x06003247 RID: 12871 RVA: 0x000B955D File Offset: 0x000B775D
		[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
		{
			this._type = type;
			this._account = acctType;
			this._authenticated = isAuthenticated;
			this._name = null;
			this.SetToken(userToken);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.WindowsIdentity" /> для пользователя, представленного указанным именем участника-пользователя.</summary>
		/// <param name="sUserPrincipalName">Имя участника-пользователя, от лица которого выполняется код.</param>
		/// <exception cref="T:System.UnauthorizedAccessException">Система Windows вернула код состояния STATUS_ACCESS_DENIED Windows NT.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта нет нужных разрешений.  
		/// -или- 
		/// Компьютер не присоединен к Windows 2003 или к более поздней версии домена.  
		///
		/// или - 
		/// Компьютер не находится под управлением Windows 2003 или более поздней версии.  
		///
		/// или - 
		/// Пользователь не является участником домена, к которому присоединен компьютер.</exception>
		// Token: 0x06003248 RID: 12872 RVA: 0x000B9589 File Offset: 0x000B7789
		[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		public WindowsIdentity(string sUserPrincipalName) : this(sUserPrincipalName, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.WindowsIdentity" /> для пользователя, представленного заданным именем участника-пользователя и типом проверки подлинности.</summary>
		/// <param name="sUserPrincipalName">Имя участника-пользователя, от лица которого выполняется код.</param>
		/// <param name="type">(Использовать только для справки.) Тип проверки подлинности, применяемой для идентификации пользователя.</param>
		/// <exception cref="T:System.UnauthorizedAccessException">Система Windows вернула код состояния STATUS_ACCESS_DENIED Windows NT.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта нет нужных разрешений.  
		///
		/// или - 
		/// Компьютер не присоединен к Windows 2003 или к более поздней версии домена.  
		///
		/// -или- 
		/// Компьютер не находится под управлением Windows 2003 или более поздней версии.  
		///
		/// или - 
		/// Пользователь не является участником домена, к которому присоединен компьютер.</exception>
		// Token: 0x06003249 RID: 12873 RVA: 0x000B9594 File Offset: 0x000B7794
		[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		public WindowsIdentity(string sUserPrincipalName, string type)
		{
			if (sUserPrincipalName == null)
			{
				throw new NullReferenceException("sUserPrincipalName");
			}
			IntPtr userToken = WindowsIdentity.GetUserToken(sUserPrincipalName);
			if (!Environment.IsUnix && userToken == IntPtr.Zero)
			{
				throw new ArgumentException("only for Windows Server 2003 +");
			}
			this._authenticated = true;
			this._account = WindowsAccountType.Normal;
			this._type = type;
			this.SetToken(userToken);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.WindowsIdentity" /> для пользователя, представленного данными в потоке <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="info">Объект, содержащий сведения учетной записи пользователя.</param>
		/// <param name="context">Объект, указывающий характеристики потока.</param>
		/// <exception cref="T:System.NotSupportedException">Класс <see cref="T:System.Security.Principal.WindowsIdentity" /> невозможно сериализовать через процессы.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта нет нужных разрешений.  
		/// -или- 
		/// Произошла ошибка Win32.</exception>
		// Token: 0x0600324A RID: 12874 RVA: 0x000B95F7 File Offset: 0x000B77F7
		[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		public WindowsIdentity(SerializationInfo info, StreamingContext context)
		{
			this._info = info;
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x000B9606 File Offset: 0x000B7806
		internal WindowsIdentity(ClaimsIdentity claimsIdentity, IntPtr userToken) : base(claimsIdentity)
		{
			if (userToken != IntPtr.Zero && userToken.ToInt64() > 0L)
			{
				this.SetToken(userToken);
			}
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Security.Principal.WindowsIdentity" />.</summary>
		// Token: 0x0600324C RID: 12876 RVA: 0x000B962E File Offset: 0x000B782E
		[ComVisible(false)]
		public void Dispose()
		{
			this._token = IntPtr.Zero;
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Security.Principal.WindowsIdentity" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x0600324D RID: 12877 RVA: 0x000B962E File Offset: 0x000B782E
		[ComVisible(false)]
		protected virtual void Dispose(bool disposing)
		{
			this._token = IntPtr.Zero;
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Principal.WindowsIdentity" />, который можно использовать в качестве контрольного значения в коде, чтобы представлять анонимного пользователя. Значение свойства не представляет встроенный анонимный идентификатор, используемый операционной системой Windows.</summary>
		/// <returns>Объект, представляющий анонимного пользователя.</returns>
		// Token: 0x0600324E RID: 12878 RVA: 0x000B963C File Offset: 0x000B783C
		public static WindowsIdentity GetAnonymous()
		{
			WindowsIdentity windowsIdentity;
			if (Environment.IsUnix)
			{
				windowsIdentity = new WindowsIdentity("nobody");
				windowsIdentity._account = WindowsAccountType.Anonymous;
				windowsIdentity._authenticated = false;
				windowsIdentity._type = string.Empty;
			}
			else
			{
				windowsIdentity = new WindowsIdentity(IntPtr.Zero, string.Empty, WindowsAccountType.Anonymous, false);
				windowsIdentity._name = string.Empty;
			}
			return windowsIdentity;
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Principal.WindowsIdentity" />, представляющий текущего пользователя Windows.</summary>
		/// <returns>Объект, представляющий текущего пользователя.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта нет нужных разрешений.</exception>
		// Token: 0x0600324F RID: 12879 RVA: 0x000B9696 File Offset: 0x000B7896
		public static WindowsIdentity GetCurrent()
		{
			return new WindowsIdentity(WindowsIdentity.GetCurrentToken(), null, WindowsAccountType.Normal, true);
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Principal.WindowsIdentity" />, представляющий идентификатор Windows для потока или процесса в зависимости от значения параметра <paramref name="ifImpersonating" />.</summary>
		/// <param name="ifImpersonating">Значение <see langword="true" /> для возврата объекта <see cref="T:System.Security.Principal.WindowsIdentity" />, только если олицетворение потока выполняется в данный момент; значение <see langword="false" /> для возврата объекта <see cref="T:System.Security.Principal.WindowsIdentity" /> потока, если олицетворение потока выполняется, или объекта <see cref="T:System.Security.Principal.WindowsIdentity" /> процесса, если олицетворение потока в настоящий момент не выполняется.</param>
		/// <returns>Объект, представляющий пользователя Windows.</returns>
		// Token: 0x06003250 RID: 12880 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("need icall changes")]
		public static WindowsIdentity GetCurrent(bool ifImpersonating)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Principal.WindowsIdentity" />, представляющий текущего пользователя Windows, используя указанный требуемый уровень доступа к токену.</summary>
		/// <param name="desiredAccess">Побитовое сочетание значений перечисления.</param>
		/// <returns>Объект, представляющий текущего пользователя.</returns>
		// Token: 0x06003251 RID: 12881 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("need icall changes")]
		public static WindowsIdentity GetCurrent(TokenAccessLevels desiredAccess)
		{
			throw new NotImplementedException();
		}

		/// <summary>Олицетворяет пользователя, представленного объектом <see cref="T:System.Security.Principal.WindowsIdentity" />.</summary>
		/// <returns>Объект, представляющий пользователя Windows до олицетворения; может использоваться для возврата к исходному контексту пользователя.</returns>
		/// <exception cref="T:System.InvalidOperationException">Попытка выполнить олицетворение с использованием анонимного удостоверения.</exception>
		/// <exception cref="T:System.Security.SecurityException">Произошла ошибка Win32.</exception>
		// Token: 0x06003252 RID: 12882 RVA: 0x000B96A5 File Offset: 0x000B78A5
		public virtual WindowsImpersonationContext Impersonate()
		{
			return new WindowsImpersonationContext(this._token);
		}

		/// <summary>Олицетворяет пользователя, представленного заданным токеном.</summary>
		/// <param name="userToken">Дескриптор токена учетной записи Windows. Этот токен обычно извлекается посредством вызова неуправляемого кода, например, вызова функции <see langword="LogonUser" /> API Win32.</param>
		/// <returns>Объект, представляющий пользователя Windows до олицетворения; может использоваться для возврата к исходному контексту пользователя.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Система Windows вернула код состояния STATUS_ACCESS_DENIED Windows NT.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта нет нужных разрешений.</exception>
		// Token: 0x06003253 RID: 12883 RVA: 0x000B96B2 File Offset: 0x000B78B2
		[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		public static WindowsImpersonationContext Impersonate(IntPtr userToken)
		{
			return new WindowsImpersonationContext(userToken);
		}

		/// <summary>Выполняет указанное действие с олицетворенным удостоверением Windows. Вместо олицетворенного вызова метода и выполнения функции в контексте <see cref="T:System.Security.Principal.WindowsImpersonationContext" /> можно использовать метод <see cref="M:System.Security.Principal.WindowsIdentity.RunImpersonated(Microsoft.Win32.SafeHandles.SafeAccessTokenHandle,System.Action)" /> и предоставить функцию непосредственно в качестве параметра.</summary>
		/// <param name="safeAccessTokenHandle">Дескриптор SafeAccessTokenHandle олицетворенного удостоверения Windows.</param>
		/// <param name="action">System.Action для запуска.</param>
		// Token: 0x06003254 RID: 12884 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SecuritySafeCritical]
		public static void RunImpersonated(SafeAccessTokenHandle safeAccessTokenHandle, Action action)
		{
			throw new NotImplementedException();
		}

		/// <summary>Выполняет указанную функцию с олицетворенным удостоверением Windows. Вместо олицетворенного вызова метода и выполнения функции в контексте <see cref="T:System.Security.Principal.WindowsImpersonationContext" /> можно использовать метод <see cref="M:System.Security.Principal.WindowsIdentity.RunImpersonated(Microsoft.Win32.SafeHandles.SafeAccessTokenHandle,System.Action)" /> и предоставить функцию непосредственно в качестве параметра.</summary>
		/// <param name="safeAccessTokenHandle">Дескриптор SafeAccessTokenHandle олицетворенного удостоверения Windows.</param>
		/// <param name="func">System.Func для запуска.</param>
		/// <typeparam name="T">Тип объекта, который используется и возвращается функцией.</typeparam>
		/// <returns>Результат функции.</returns>
		// Token: 0x06003255 RID: 12885 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SecuritySafeCritical]
		public static T RunImpersonated<T>(SafeAccessTokenHandle safeAccessTokenHandle, Func<T> func)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает тип аутентификации, используемой для идентификации пользователя.</summary>
		/// <returns>Тип проверки подлинности, применяемой для идентификации пользователя.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Система Windows вернула код состояния STATUS_ACCESS_DENIED Windows NT.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта нет нужных разрешений.  
		///
		/// или - 
		/// Компьютер не присоединен к Windows 2003 или к более поздней версии домена.  
		///
		/// -или- 
		/// Компьютер не находится под управлением Windows 2003 или более поздней версии.  
		///
		/// или - 
		/// Пользователь не является участником домена, к которому присоединен компьютер.</exception>
		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x000B96BA File Offset: 0x000B78BA
		public sealed override string AuthenticationType
		{
			[SecuritySafeCritical]
			get
			{
				return this._type;
			}
		}

		/// <summary>Возвращает значение, показывающее, определена ли в системе учетная запись пользователя как анонимная.</summary>
		/// <returns>Значение <see langword="true" />, если учетная запись пользователя является анонимной; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x000B96C2 File Offset: 0x000B78C2
		public virtual bool IsAnonymous
		{
			get
			{
				return this._account == WindowsAccountType.Anonymous;
			}
		}

		/// <summary>Возвращает значение, указывающее, прошел ли пользователь проверку подлинности в Windows.</summary>
		/// <returns>
		///   <see langword="true" />, если пользователь прошел проверку подлинности; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x000B96CD File Offset: 0x000B78CD
		public override bool IsAuthenticated
		{
			get
			{
				return this._authenticated;
			}
		}

		/// <summary>Возвращает значение, показывающее, определена ли в системе учетная запись пользователя как учетная запись <see cref="F:System.Security.Principal.WindowsAccountType.Guest" />.</summary>
		/// <returns>
		///   <see langword="true" />, если учетная запись пользователя является учетной записью <see cref="F:System.Security.Principal.WindowsAccountType.Guest" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x000B96D5 File Offset: 0x000B78D5
		public virtual bool IsGuest
		{
			get
			{
				return this._account == WindowsAccountType.Guest;
			}
		}

		/// <summary>Возвращает значение, показывающее, определена ли в системе учетная запись пользователя как учетная запись <see cref="F:System.Security.Principal.WindowsAccountType.System" />.</summary>
		/// <returns>
		///   <see langword="true" />, если учетная запись пользователя является учетной записью <see cref="F:System.Security.Principal.WindowsAccountType.System" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x000B96E0 File Offset: 0x000B78E0
		public virtual bool IsSystem
		{
			get
			{
				return this._account == WindowsAccountType.System;
			}
		}

		/// <summary>Возвращает имя входа пользователя Windows.</summary>
		/// <returns>Имя входа пользователя Windows, от лица которого запущен код.</returns>
		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x000B96EB File Offset: 0x000B78EB
		public override string Name
		{
			[SecuritySafeCritical]
			get
			{
				if (this._name == null)
				{
					this._name = WindowsIdentity.GetTokenName(this._token);
				}
				return this._name;
			}
		}

		/// <summary>Возвращает токен учетной записи Windows для пользователя.</summary>
		/// <returns>Дескриптор токена доступа, связанный с текущим выполняемым потоком.</returns>
		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x000B970C File Offset: 0x000B790C
		public virtual IntPtr Token
		{
			get
			{
				return this._token;
			}
		}

		/// <summary>Возвращает группы, к которым относится текущий пользователь Windows.</summary>
		/// <returns>Объект, представляющий группы, к которым принадлежит текущий пользователь Windows.</returns>
		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("not implemented")]
		public IdentityReferenceCollection Groups
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает уровень олицетворения для пользователя.</summary>
		/// <returns>Одно из значений перечисления, указывающее уровень олицетворения.</returns>
		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x000479F8 File Offset: 0x00045BF8
		[ComVisible(false)]
		[MonoTODO("not implemented")]
		public TokenImpersonationLevel ImpersonationLevel
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает идентификатор безопасности (ИД безопасности) для владельца токена.</summary>
		/// <returns>Объект для владельца токена.</returns>
		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("not implemented")]
		[ComVisible(false)]
		public SecurityIdentifier Owner
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает идентификатор безопасности (ИД безопасности) для пользователя.</summary>
		/// <returns>Объект для пользователя.</returns>
		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06003260 RID: 12896 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("not implemented")]
		[ComVisible(false)]
		public SecurityIdentifier User
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и вызывается событием десериализации после завершения десериализации в ходе обратного вызова.</summary>
		/// <param name="sender">Источник события десериализации.</param>
		// Token: 0x06003261 RID: 12897 RVA: 0x000B9714 File Offset: 0x000B7914
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			this._token = (IntPtr)this._info.GetValue("m_userToken", typeof(IntPtr));
			this._name = this._info.GetString("m_name");
			if (this._name != null)
			{
				if (WindowsIdentity.GetTokenName(this._token) != this._name)
				{
					throw new SerializationException("Token-Name mismatch.");
				}
			}
			else
			{
				this._name = WindowsIdentity.GetTokenName(this._token);
				if (this._name == null)
				{
					throw new SerializationException("Token doesn't match a user.");
				}
			}
			this._type = this._info.GetString("m_type");
			this._account = (WindowsAccountType)this._info.GetValue("m_acctType", typeof(WindowsAccountType));
			this._authenticated = this._info.GetBoolean("m_isAuthenticated");
		}

		/// <summary>Задает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с информацией логического контекста, необходимой для повторного создания экземпляра данного контекста выполнения.</summary>
		/// <param name="info">Объект, содержащий сведения, которые требуются для сериализации коллекции <see cref="T:System.Collections.Hashtable" />.</param>
		/// <param name="context">Объект, содержащий исходный объект и объект назначения для сериализованного потока, связанного с <see cref="T:System.Collections.Hashtable" />.</param>
		// Token: 0x06003262 RID: 12898 RVA: 0x000B97FC File Offset: 0x000B79FC
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("m_userToken", this._token);
			info.AddValue("m_name", this._name);
			info.AddValue("m_type", this._type);
			info.AddValue("m_acctType", this._account);
			info.AddValue("m_isAuthenticated", this._authenticated);
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x000B9868 File Offset: 0x000B7A68
		internal ClaimsIdentity CloneAsBase()
		{
			return base.Clone();
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x000B970C File Offset: 0x000B790C
		internal IntPtr GetTokenInternal()
		{
			return this._token;
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x000B9870 File Offset: 0x000B7A70
		private void SetToken(IntPtr token)
		{
			if (Environment.IsUnix)
			{
				this._token = token;
				if (this._type == null)
				{
					this._type = "POSIX";
				}
				if (this._token == IntPtr.Zero)
				{
					this._account = WindowsAccountType.System;
					return;
				}
			}
			else
			{
				if (token == WindowsIdentity.invalidWindows && this._account != WindowsAccountType.Anonymous)
				{
					throw new ArgumentException("Invalid token");
				}
				this._token = token;
				if (this._type == null)
				{
					this._type = "NTLM";
				}
			}
		}

		/// <summary>Возвращает объект <see cref="T:Microsoft.Win32.SafeHandles.SafeAccessTokenHandle" /> для данного экземпляра <see cref="T:System.Security.Principal.WindowsIdentity" />.</summary>
		/// <returns>Возвращает значение типа <see cref="T:Microsoft.Win32.SafeHandles.SafeAccessTokenHandle" />.</returns>
		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06003266 RID: 12902 RVA: 0x000479F8 File Offset: 0x00045BF8
		public SafeAccessTokenHandle AccessToken
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06003267 RID: 12903
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string[] _GetRoles(IntPtr token);

		// Token: 0x06003268 RID: 12904
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr GetCurrentToken();

		// Token: 0x06003269 RID: 12905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetTokenName(IntPtr token);

		// Token: 0x0600326A RID: 12906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetUserToken(string username);

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.WindowsIdentity" />, используя указанный объект <see cref="T:System.Security.Principal.WindowsIdentity" />.</summary>
		/// <param name="identity">Объект, из которого создается новый экземпляр <see cref="T:System.Security.Principal.WindowsIdentity" />.</param>
		// Token: 0x0600326C RID: 12908 RVA: 0x000173AD File Offset: 0x000155AD
		[SecuritySafeCritical]
		protected WindowsIdentity(WindowsIdentity identity)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает утверждения, имеющие ключ свойства <see cref="F:System.Security.Claims.ClaimTypes.WindowsDeviceClaim" />.</summary>
		/// <returns>Коллекция утверждений, имеющих ключ свойства <see cref="F:System.Security.Claims.ClaimTypes.WindowsDeviceClaim" />.</returns>
		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x000B98FF File Offset: 0x000B7AFF
		public virtual IEnumerable<Claim> DeviceClaims
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>Возвращает утверждения, имеющие ключ свойства <see cref="F:System.Security.Claims.ClaimTypes.WindowsUserClaim" />.</summary>
		/// <returns>Коллекция утверждений, имеющих ключ свойства <see cref="F:System.Security.Claims.ClaimTypes.WindowsUserClaim" />.</returns>
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600326E RID: 12910 RVA: 0x000B98FF File Offset: 0x000B7AFF
		public virtual IEnumerable<Claim> UserClaims
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		// Token: 0x0400233C RID: 9020
		private IntPtr _token;

		// Token: 0x0400233D RID: 9021
		private string _type;

		// Token: 0x0400233E RID: 9022
		private WindowsAccountType _account;

		// Token: 0x0400233F RID: 9023
		private bool _authenticated;

		// Token: 0x04002340 RID: 9024
		private string _name;

		// Token: 0x04002341 RID: 9025
		private SerializationInfo _info;

		// Token: 0x04002342 RID: 9026
		private static IntPtr invalidWindows = IntPtr.Zero;

		/// <summary>Определяет имя издателя <see cref="T:System.Security.Claims.ClaimsIdentity" /> по умолчанию.</summary>
		// Token: 0x04002343 RID: 9027
		[NonSerialized]
		public new const string DefaultIssuer = "AD AUTHORITY";
	}
}
