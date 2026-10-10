using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	/// <summary>Представляет событие синхронизации потока.</summary>
	// Token: 0x020002C6 RID: 710
	[ComVisible(true)]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public class EventWaitHandle : WaitHandle
	{
		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Threading.EventWaitHandle" />, определяя, получает ли сигнал, ожидающий дескриптор, и производится ли сброс автоматически или вручную.</summary>
		/// <param name="initialState">Значение <see langword="true" /> для задания начального состояния сигнальным; <see langword="false" /> для задания несигнального начального состояния.</param>
		/// <param name="mode">Одно из значений <see cref="T:System.Threading.EventResetMode" />, которое определяет, выполняется ли сброс события автоматически или вручную.</param>
		// Token: 0x06001ED0 RID: 7888 RVA: 0x000727EA File Offset: 0x000709EA
		[SecuritySafeCritical]
		public EventWaitHandle(bool initialState, EventResetMode mode) : this(initialState, mode, null)
		{
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Threading.EventWaitHandle" />, определяющего получает ли сигнал дескриптор ожидания, если он был создан в результате данного вызова, сбрасывается ли он автоматически или вручную, а также имя системного события синхронизации.</summary>
		/// <param name="initialState">Значение <see langword="true" /> обозначает, что именованное событие получит исходное сигнальное состояние, если такое событие создается в результате этого вызова; значение <see langword="false" /> устанавливает несигнальное состояние.</param>
		/// <param name="mode">Одно из значений <see cref="T:System.Threading.EventResetMode" />, которое определяет, выполняется ли сброс события автоматически или вручную.</param>
		/// <param name="name">Имя события синхронизации на уровне системы.</param>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованное событие уже существует и имеет настройки управления доступом, но пользователь не имеет прав <see cref="F:System.Security.AccessControl.EventWaitHandleRights.FullControl" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованное событие нельзя создать; вероятно, дескриптор ожидания другого типа имеет то же имя.</exception>
		/// <exception cref="T:System.ArgumentException">Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		// Token: 0x06001ED1 RID: 7889 RVA: 0x000727F8 File Offset: 0x000709F8
		[SecurityCritical]
		public EventWaitHandle(bool initialState, EventResetMode mode, string name)
		{
			if (name != null && 260 < name.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("The name can be no more than 260 characters in length.", new object[]
				{
					name
				}));
			}
			int num;
			SafeWaitHandle safeWaitHandle;
			if (mode != EventResetMode.AutoReset)
			{
				if (mode != EventResetMode.ManualReset)
				{
					throw new ArgumentException(Environment.GetResourceString("Value of flags is invalid.", new object[]
					{
						name
					}));
				}
				safeWaitHandle = new SafeWaitHandle(NativeEventCalls.CreateEvent_internal(true, initialState, name, out num), true);
			}
			else
			{
				safeWaitHandle = new SafeWaitHandle(NativeEventCalls.CreateEvent_internal(false, initialState, name, out num), true);
			}
			if (safeWaitHandle.IsInvalid)
			{
				safeWaitHandle.SetHandleAsInvalid();
				if (name != null && name.Length != 0 && 6 == num)
				{
					throw new WaitHandleCannotBeOpenedException(Environment.GetResourceString("A WaitHandle with system-wide name '{0}' cannot be created. A WaitHandle of a different type might have the same name.", new object[]
					{
						name
					}));
				}
				__Error.WinIOError(num, name);
			}
			base.SetHandleInternal(safeWaitHandle);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.EventWaitHandle" /> и указывает следующие сведения: передавать ли сигнал в дескриптор ожидания при первичном запуске в результате этого вызова; выполнять ли сброс автоматически или вручную; имя системного события синхронизации; логическая переменная для сохранения информации о том, было ли создано именованное системное событие.</summary>
		/// <param name="initialState">Значение <see langword="true" /> обозначает, что именованное событие получит исходное сигнальное состояние, если такое событие создается в результате этого вызова; значение <see langword="false" /> устанавливает несигнальное состояние.</param>
		/// <param name="mode">Одно из значений <see cref="T:System.Threading.EventResetMode" />, которое определяет, выполняется ли сброс события автоматически или вручную.</param>
		/// <param name="name">Имя события синхронизации на уровне системы.</param>
		/// <param name="createdNew">Когда данный метод возвращает значение, он содержит <see langword="true" />, если было создано локальное событие (то есть, если <paramref name="name" /> имеет значение <see langword="null" /> или пустую строку) или было создано системное событие с заданным именем; либо значение <see langword="false" />, если указанное именованное событие уже существовало. Этот параметр передается неинициализированным.</param>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованное событие уже существует и имеет настройки управления доступом, но пользователь не имеет прав <see cref="F:System.Security.AccessControl.EventWaitHandleRights.FullControl" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованное событие нельзя создать; вероятно, дескриптор ожидания другого типа имеет то же имя.</exception>
		/// <exception cref="T:System.ArgumentException">Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		// Token: 0x06001ED2 RID: 7890 RVA: 0x000728C3 File Offset: 0x00070AC3
		[SecurityCritical]
		public EventWaitHandle(bool initialState, EventResetMode mode, string name, out bool createdNew) : this(initialState, mode, name, out createdNew, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.EventWaitHandle" /> с указанием следующих сведений: передавать ли сигнал в дескриптор ожидания при первичном запуске в результате этого вызова, выполнять ли сброс автоматически или вручную, имя системного события синхронизации, логическая переменная для сохранения информации о том, было ли создано именованное системное событие, правила управления доступом для именованного события, если оно создается.</summary>
		/// <param name="initialState">Значение <see langword="true" /> обозначает, что именованное событие получит исходное сигнальное состояние, если такое событие создается в результате этого вызова; значение <see langword="false" /> устанавливает несигнальное состояние.</param>
		/// <param name="mode">Одно из значений <see cref="T:System.Threading.EventResetMode" />, которое определяет, выполняется ли сброс события автоматически или вручную.</param>
		/// <param name="name">Имя события синхронизации на уровне системы.</param>
		/// <param name="createdNew">Когда данный метод возвращает значение, он содержит <see langword="true" />, если было создано локальное событие (то есть, если <paramref name="name" /> имеет значение <see langword="null" /> или пустую строку) или было создано системное событие с заданным именем; либо значение <see langword="false" />, если указанное именованное событие уже существовало. Этот параметр передается неинициализированным.</param>
		/// <param name="eventSecurity">Объект <see cref="T:System.Security.AccessControl.EventWaitHandleSecurity" />, определяющий настройки управления доступом для применения к именованному системному событию.</param>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованное событие уже существует и имеет настройки управления доступом, но пользователь не имеет прав <see cref="F:System.Security.AccessControl.EventWaitHandleRights.FullControl" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованное событие нельзя создать; вероятно, дескриптор ожидания другого типа имеет то же имя.</exception>
		/// <exception cref="T:System.ArgumentException">Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		// Token: 0x06001ED3 RID: 7891 RVA: 0x000728D4 File Offset: 0x00070AD4
		[SecurityCritical]
		public EventWaitHandle(bool initialState, EventResetMode mode, string name, out bool createdNew, EventWaitHandleSecurity eventSecurity)
		{
			if (name != null && 260 < name.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("The name can be no more than 260 characters in length.", new object[]
				{
					name
				}));
			}
			bool manual;
			if (mode != EventResetMode.AutoReset)
			{
				if (mode != EventResetMode.ManualReset)
				{
					throw new ArgumentException(Environment.GetResourceString("Value of flags is invalid.", new object[]
					{
						name
					}));
				}
				manual = true;
			}
			else
			{
				manual = false;
			}
			int num;
			SafeWaitHandle safeWaitHandle = new SafeWaitHandle(NativeEventCalls.CreateEvent_internal(manual, initialState, name, out num), true);
			if (safeWaitHandle.IsInvalid)
			{
				safeWaitHandle.SetHandleAsInvalid();
				if (name != null && name.Length != 0 && 6 == num)
				{
					throw new WaitHandleCannotBeOpenedException(Environment.GetResourceString("A WaitHandle with system-wide name '{0}' cannot be created. A WaitHandle of a different type might have the same name.", new object[]
					{
						name
					}));
				}
				__Error.WinIOError(num, name);
			}
			createdNew = (num != 183);
			base.SetHandleInternal(safeWaitHandle);
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x000729A0 File Offset: 0x00070BA0
		[SecurityCritical]
		private EventWaitHandle(SafeWaitHandle handle)
		{
			base.SetHandleInternal(handle);
		}

		/// <summary>Открывает указанное именованное событие синхронизации, если оно уже существует.</summary>
		/// <param name="name">Имя системного события синхронизации, которое нужно открыть.</param>
		/// <returns>Объект, представляющий именованное системное событие.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованное системное событие не существует.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованное событие существует, но у пользователя нет необходимых для его использования прав доступа.</exception>
		// Token: 0x06001ED5 RID: 7893 RVA: 0x000729AF File Offset: 0x00070BAF
		[SecurityCritical]
		public static EventWaitHandle OpenExisting(string name)
		{
			return EventWaitHandle.OpenExisting(name, EventWaitHandleRights.Modify | EventWaitHandleRights.Synchronize);
		}

		/// <summary>Открывает указанное именованное событие синхронизации, если оно уже существует, с требуемыми правами доступа.</summary>
		/// <param name="name">Имя системного события синхронизации, которое нужно открыть.</param>
		/// <param name="rights">Битовая комбинация значений перечисления, которые определяют желаемые права доступа.</param>
		/// <returns>Объект, представляющий именованное системное событие.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованное системное событие не существует.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованное событие уже существует, но пользователь не имеет требуемых прав для безопасного доступа.</exception>
		// Token: 0x06001ED6 RID: 7894 RVA: 0x000729BC File Offset: 0x00070BBC
		[SecurityCritical]
		public static EventWaitHandle OpenExisting(string name, EventWaitHandleRights rights)
		{
			EventWaitHandle result;
			switch (EventWaitHandle.OpenExistingWorker(name, rights, out result))
			{
			case WaitHandle.OpenExistingResult.NameNotFound:
				throw new WaitHandleCannotBeOpenedException();
			case WaitHandle.OpenExistingResult.PathNotFound:
				__Error.WinIOError(3, "");
				return result;
			case WaitHandle.OpenExistingResult.NameInvalid:
				throw new WaitHandleCannotBeOpenedException(Environment.GetResourceString("A WaitHandle with system-wide name '{0}' cannot be created. A WaitHandle of a different type might have the same name.", new object[]
				{
					name
				}));
			default:
				return result;
			}
		}

		/// <summary>Открывает указанное именованное событие синхронизации, если оно уже существует, и возвращает значение, указывающее, успешно ли выполнена операция.</summary>
		/// <param name="name">Имя системного события синхронизации, которое нужно открыть.</param>
		/// <param name="result">При возврате этого метода содержит объект <see cref="T:System.Threading.EventWaitHandle" />, представляющий именованное событие синхронизации, если вызов завершился успешно, или значение <see langword="null" />, если вызов завершился неудачно. Этот параметр обрабатывается как неинициализированный.</param>
		/// <returns>Значение <see langword="true" />, если именованное событие синхронизации открылось успешно. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованное событие уже существует, но пользователь не имеет требуемых прав для безопасного доступа.</exception>
		// Token: 0x06001ED7 RID: 7895 RVA: 0x00072A17 File Offset: 0x00070C17
		[SecurityCritical]
		public static bool TryOpenExisting(string name, out EventWaitHandle result)
		{
			return EventWaitHandle.OpenExistingWorker(name, EventWaitHandleRights.Modify | EventWaitHandleRights.Synchronize, out result) == WaitHandle.OpenExistingResult.Success;
		}

		/// <summary>Открывает заданное именованное событие синхронизации, если оно уже существует, с требуемыми правами доступа и возвращает значение, указывающее, успешно ли выполнена операция.</summary>
		/// <param name="name">Имя системного события синхронизации, которое нужно открыть.</param>
		/// <param name="rights">Битовая комбинация значений перечисления, которые определяют желаемые права доступа.</param>
		/// <param name="result">При возврате этого метода содержит объект <see cref="T:System.Threading.EventWaitHandle" />, представляющий именованное событие синхронизации, если вызов завершился успешно, или значение <see langword="null" />, если вызов завершился неудачно. Этот параметр обрабатывается как неинициализированный.</param>
		/// <returns>Значение <see langword="true" />, если именованное событие синхронизации открылось успешно. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованное событие уже существует, но пользователь не имеет требуемых прав для безопасного доступа.</exception>
		// Token: 0x06001ED8 RID: 7896 RVA: 0x00072A28 File Offset: 0x00070C28
		[SecurityCritical]
		public static bool TryOpenExisting(string name, EventWaitHandleRights rights, out EventWaitHandle result)
		{
			return EventWaitHandle.OpenExistingWorker(name, rights, out result) == WaitHandle.OpenExistingResult.Success;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00072A38 File Offset: 0x00070C38
		[SecurityCritical]
		private static WaitHandle.OpenExistingResult OpenExistingWorker(string name, EventWaitHandleRights rights, out EventWaitHandle result)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name", Environment.GetResourceString("Parameter '{0}' cannot be null."));
			}
			if (name.Length == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Empty name is not legal."), "name");
			}
			if (name != null && 260 < name.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("The name can be no more than 260 characters in length.", new object[]
				{
					name
				}));
			}
			result = null;
			int num;
			SafeWaitHandle safeWaitHandle = new SafeWaitHandle(NativeEventCalls.OpenEvent_internal(name, rights, out num), true);
			if (safeWaitHandle.IsInvalid)
			{
				if (2 == num || 123 == num)
				{
					return WaitHandle.OpenExistingResult.NameNotFound;
				}
				if (3 == num)
				{
					return WaitHandle.OpenExistingResult.PathNotFound;
				}
				if (name != null && name.Length != 0 && 6 == num)
				{
					return WaitHandle.OpenExistingResult.NameInvalid;
				}
				__Error.WinIOError(num, "");
			}
			result = new EventWaitHandle(safeWaitHandle);
			return WaitHandle.OpenExistingResult.Success;
		}

		/// <summary>Задает несигнальное состояние события, вызывая блокирование потоков.</summary>
		/// <returns>Значение <see langword="true" />, если операция прошла успешно; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Метод <see cref="M:System.Threading.WaitHandle.Close" /> ранее вызывался для этого <see cref="T:System.Threading.EventWaitHandle" />.</exception>
		// Token: 0x06001EDA RID: 7898 RVA: 0x00072AF5 File Offset: 0x00070CF5
		[SecuritySafeCritical]
		public bool Reset()
		{
			bool flag = NativeEventCalls.ResetEvent(this.safeWaitHandle);
			if (!flag)
			{
				throw new IOException();
			}
			return flag;
		}

		/// <summary>Устанавливает сигнальное состояние события, что позволяет продолжить выполнение одному или нескольким ожидающим потокам.</summary>
		/// <returns>Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Метод <see cref="M:System.Threading.WaitHandle.Close" /> ранее вызывался для этого <see cref="T:System.Threading.EventWaitHandle" />.</exception>
		// Token: 0x06001EDB RID: 7899 RVA: 0x00072B0D File Offset: 0x00070D0D
		[SecuritySafeCritical]
		public bool Set()
		{
			bool flag = NativeEventCalls.SetEvent(this.safeWaitHandle);
			if (!flag)
			{
				throw new IOException();
			}
			return flag;
		}

		/// <summary>Получает объект <see cref="T:System.Security.AccessControl.EventWaitHandleSecurity" />, представляющий параметры безопасности управления доступом для именованного системного события, представленного текущим объектом <see cref="T:System.Threading.EventWaitHandle" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.EventWaitHandleSecurity" />, представляющий параметры безопасности управления доступом для именованного системного события.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Текущий объект <see cref="T:System.Threading.EventWaitHandle" /> представляет именованное системное событие, а пользователь не имеет <see cref="F:System.Security.AccessControl.EventWaitHandleRights.ReadPermissions" />.  
		///
		/// или - 
		/// Текущий объект <see cref="T:System.Threading.EventWaitHandle" /> представляет именованное системное событие и не был открыт с помощью <see cref="F:System.Security.AccessControl.EventWaitHandleRights.ReadPermissions" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Не поддерживается для Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Метод <see cref="M:System.Threading.WaitHandle.Close" /> ранее вызывался для этого <see cref="T:System.Threading.EventWaitHandle" />.</exception>
		// Token: 0x06001EDC RID: 7900 RVA: 0x00072B25 File Offset: 0x00070D25
		[SecuritySafeCritical]
		public EventWaitHandleSecurity GetAccessControl()
		{
			return new EventWaitHandleSecurity(this.safeWaitHandle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
		}

		/// <summary>Задает защиту управления доступом для именованного системного события.</summary>
		/// <param name="eventSecurity">Объект <see cref="T:System.Security.AccessControl.EventWaitHandleSecurity" />, определяющий настройки управления доступом для применения к именованному системному событию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="eventSecurity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Пользователь не имеет разрешений <see cref="F:System.Security.AccessControl.EventWaitHandleRights.ChangePermissions" />.  
		///
		/// или - 
		/// Это событие не было открыто с помощью <see cref="F:System.Security.AccessControl.EventWaitHandleRights.ChangePermissions" />.</exception>
		/// <exception cref="T:System.SystemException">Текущий объект <see cref="T:System.Threading.EventWaitHandle" /> не представляет именованное системное событие.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Метод <see cref="M:System.Threading.WaitHandle.Close" /> ранее вызывался для этого <see cref="T:System.Threading.EventWaitHandle" />.</exception>
		// Token: 0x06001EDD RID: 7901 RVA: 0x00072B36 File Offset: 0x00070D36
		[SecuritySafeCritical]
		public void SetAccessControl(EventWaitHandleSecurity eventSecurity)
		{
			if (eventSecurity == null)
			{
				throw new ArgumentNullException("eventSecurity");
			}
			eventSecurity.Persist(this.safeWaitHandle);
		}
	}
}
