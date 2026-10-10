using System;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	/// <summary>Ограничивает число потоков, которые могут одновременно обращаться к ресурсу или пулу ресурсов.</summary>
	// Token: 0x0200017E RID: 382
	[ComVisible(false)]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public sealed class Semaphore : WaitHandle
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Semaphore" />, задающий начальное количество входов и максимальное количество одновременных входов.</summary>
		/// <param name="initialCount">Начальное количество запросов для семафора, которое может быть обеспечено одновременно.</param>
		/// <param name="maximumCount">Максимальное количество запросов семафора, которое может быть обеспеченно одновременно.</param>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="initialCount" /> больше значения <paramref name="maximumCount" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="maximumCount" /> меньше 1.  
		///
		/// или - 
		/// Значение параметра <paramref name="initialCount" /> меньше 0.</exception>
		// Token: 0x06000A3F RID: 2623 RVA: 0x0002CD12 File Offset: 0x0002AF12
		[SecuritySafeCritical]
		public Semaphore(int initialCount, int maximumCount) : this(initialCount, maximumCount, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Semaphore" />, задающий начальное количество входов и максимальное количество одновременных входов, а также при необходимости имя объекта системного семафора.</summary>
		/// <param name="initialCount">Начальное количество запросов для семафора, которое может быть обеспечено одновременно.</param>
		/// <param name="maximumCount">Максимальное количество запросов семафора, которое может быть обеспеченно одновременно.</param>
		/// <param name="name">Имя объекта именованного системного семафора.</param>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="initialCount" /> больше значения <paramref name="maximumCount" />.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="maximumCount" /> меньше 1.  
		///
		/// или - 
		/// Значение параметра <paramref name="initialCount" /> меньше 0.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный семафор существует, доступ к нему безопасно регулируется, но пользователь не имеет прав <see cref="F:System.Security.AccessControl.SemaphoreRights.FullControl" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованный семафор нельзя создать. Вероятно, дескриптор ожидания другого типа имеет то же имя.</exception>
		// Token: 0x06000A40 RID: 2624 RVA: 0x0002CD20 File Offset: 0x0002AF20
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public Semaphore(int initialCount, int maximumCount, string name)
		{
			if (initialCount < 0)
			{
				throw new ArgumentOutOfRangeException("initialCount", SR.GetString("Non-negative number required."));
			}
			if (maximumCount < 1)
			{
				throw new ArgumentOutOfRangeException("maximumCount", SR.GetString("Positive number required."));
			}
			if (initialCount > maximumCount)
			{
				throw new ArgumentException(SR.GetString("The initial count for the semaphore must be greater than or equal to zero and less than the maximum count."));
			}
			if (name != null && 260 < name.Length)
			{
				throw new ArgumentException(SR.GetString("The name can be no more than 260 characters in length."));
			}
			int num;
			SafeWaitHandle safeWaitHandle = new SafeWaitHandle(Semaphore.CreateSemaphore_internal(initialCount, maximumCount, name, out num), true);
			if (safeWaitHandle.IsInvalid)
			{
				if (name != null && name.Length != 0 && 6 == num)
				{
					throw new WaitHandleCannotBeOpenedException(SR.GetString("A WaitHandle with system-wide name '{0}' cannot be created. A WaitHandle of a different type might have the same name.", new object[]
					{
						name
					}));
				}
				InternalResources.WinIOError(num, "");
			}
			base.SafeWaitHandle = safeWaitHandle;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Semaphore" />, задающий начальное количество входов и максимальное количество одновременных входов, а также при необходимости задающий имя объекта системного семафора и переменную, получающую значение, которое указывает, был ли создан новый системный семафор.</summary>
		/// <param name="initialCount">Начальное количество запросов семафора, которое может быть удовлетворено одновременно.</param>
		/// <param name="maximumCount">Максимальное количество запросов семафора, которое может быть удовлетворено одновременно.</param>
		/// <param name="name">Имя объекта именованного системного семафора.</param>
		/// <param name="createdNew">При возврате этот метод содержит значение <see langword="true" />, если был создан локальный семафор (то есть если параметр <paramref name="name" /> имеет значение <see langword="null" /> или содержит пустую строку) или был создан заданный именованный системный семафор; значение <see langword="false" />, если указанный именованный семафор уже существовал. Этот параметр передается неинициализированным.</param>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="initialCount" /> больше значения <paramref name="maximumCount" />.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="maximumCount" /> меньше 1.  
		///
		/// или - 
		/// Значение параметра <paramref name="initialCount" /> меньше 0.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный семафор существует, доступ к нему безопасно регулируется, но пользователь не имеет прав <see cref="F:System.Security.AccessControl.SemaphoreRights.FullControl" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованный семафор нельзя создать. Вероятно, дескриптор ожидания другого типа имеет то же имя.</exception>
		// Token: 0x06000A41 RID: 2625 RVA: 0x0002CDED File Offset: 0x0002AFED
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew) : this(initialCount, maximumCount, name, out createdNew, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Semaphore" />, задающий начальное количество входов и максимальное количество одновременных входов, а также при необходимости задает имя объекта системного семафора, переменную, которая получает значение, указывающее, был ли создан новый системный семафор, и управление безопасным доступом для системного семафора.</summary>
		/// <param name="initialCount">Начальное количество запросов семафора, которое может быть удовлетворено одновременно.</param>
		/// <param name="maximumCount">Максимальное количество запросов семафора, которое может быть удовлетворено одновременно.</param>
		/// <param name="name">Имя объекта именованного системного семафора.</param>
		/// <param name="createdNew">При возврате этот метод содержит значение <see langword="true" />, если был создан локальный семафор (то есть если параметр <paramref name="name" /> имеет значение <see langword="null" /> или содержит пустую строку) или был создан заданный именованный системный семафор; значение <see langword="false" />, если указанный именованный семафор уже существовал. Этот параметр передается неинициализированным.</param>
		/// <param name="semaphoreSecurity">Объект <see cref="T:System.Security.AccessControl.SemaphoreSecurity" />, представляющий безопасность управления доступом для применения к именованному системному семафору.</param>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="initialCount" /> больше значения <paramref name="maximumCount" />.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="maximumCount" /> меньше 1.  
		///
		/// или - 
		/// Значение параметра <paramref name="initialCount" /> меньше 0.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный семафор существует, доступ к нему безопасно регулируется, но пользователь не имеет прав <see cref="F:System.Security.AccessControl.SemaphoreRights.FullControl" />.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованный семафор нельзя создать. Вероятно, дескриптор ожидания другого типа имеет то же имя.</exception>
		// Token: 0x06000A42 RID: 2626 RVA: 0x0002CDFC File Offset: 0x0002AFFC
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew, SemaphoreSecurity semaphoreSecurity)
		{
			if (initialCount < 0)
			{
				throw new ArgumentOutOfRangeException("initialCount", SR.GetString("Non-negative number required."));
			}
			if (maximumCount < 1)
			{
				throw new ArgumentOutOfRangeException("maximumCount", SR.GetString("Non-negative number required."));
			}
			if (initialCount > maximumCount)
			{
				throw new ArgumentException(SR.GetString("The initial count for the semaphore must be greater than or equal to zero and less than the maximum count."));
			}
			if (name != null && 260 < name.Length)
			{
				throw new ArgumentException(SR.GetString("The name can be no more than 260 characters in length."));
			}
			int num;
			SafeWaitHandle safeWaitHandle = new SafeWaitHandle(Semaphore.CreateSemaphore_internal(initialCount, maximumCount, name, out num), true);
			if (safeWaitHandle.IsInvalid)
			{
				if (name != null && name.Length != 0 && 6 == num)
				{
					throw new WaitHandleCannotBeOpenedException(SR.GetString("A WaitHandle with system-wide name '{0}' cannot be created. A WaitHandle of a different type might have the same name.", new object[]
					{
						name
					}));
				}
				InternalResources.WinIOError(num, "");
			}
			createdNew = (num != 183);
			base.SafeWaitHandle = safeWaitHandle;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002CED7 File Offset: 0x0002B0D7
		private Semaphore(SafeWaitHandle handle)
		{
			base.SafeWaitHandle = handle;
		}

		/// <summary>Открывает указанный именованный семафор, если он уже существует.</summary>
		/// <param name="name">Имя системного семафора для открытия.</param>
		/// <returns>Объект, представляющий именованный системный семафор.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованный семафор не существует.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный семафор существует, но у пользователя нет прав доступа, необходимых для его использования.</exception>
		// Token: 0x06000A44 RID: 2628 RVA: 0x0002CEE6 File Offset: 0x0002B0E6
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static Semaphore OpenExisting(string name)
		{
			return Semaphore.OpenExisting(name, SemaphoreRights.Modify | SemaphoreRights.Synchronize);
		}

		/// <summary>Открывает указанный именованный семафор, если он уже существует, с требуемым безопасным доступом.</summary>
		/// <param name="name">Имя системного семафора для открытия.</param>
		/// <param name="rights">Битовая комбинация значений перечисления, которые определяют желаемые права доступа.</param>
		/// <returns>Объект, представляющий именованный системный семафор.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованный семафор не существует.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный семафор существует, но у пользователя нет требуемых прав доступа.</exception>
		// Token: 0x06000A45 RID: 2629 RVA: 0x0002CEF4 File Offset: 0x0002B0F4
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static Semaphore OpenExisting(string name, SemaphoreRights rights)
		{
			Semaphore result;
			switch (Semaphore.OpenExistingWorker(name, rights, out result))
			{
			case Semaphore.OpenExistingResult.NameNotFound:
				throw new WaitHandleCannotBeOpenedException();
			case Semaphore.OpenExistingResult.PathNotFound:
				InternalResources.WinIOError(3, string.Empty);
				return result;
			case Semaphore.OpenExistingResult.NameInvalid:
				throw new WaitHandleCannotBeOpenedException(SR.GetString("A WaitHandle with system-wide name '{0}' cannot be created. A WaitHandle of a different type might have the same name.", new object[]
				{
					name
				}));
			default:
				return result;
			}
		}

		/// <summary>Открывает указанный именованный семафор, если он уже существует, и возвращает значение, указывающее, успешно ли выполнена операция.</summary>
		/// <param name="name">Имя системного семафора для открытия.</param>
		/// <param name="result">При возврате этот метод содержит объект <see cref="T:System.Threading.Semaphore" />, представляющий именованный семафор, если вызов завершился успешно, или значение <see langword="null" />, если вызов завершился неудачно. Этот параметр обрабатывается как неинициализированный.</param>
		/// <returns>Значение <see langword="true" />, если именованный семафор был успешно открыт; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный семафор существует, но у пользователя нет прав доступа, необходимых для его использования.</exception>
		// Token: 0x06000A46 RID: 2630 RVA: 0x0002CF4F File Offset: 0x0002B14F
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static bool TryOpenExisting(string name, out Semaphore result)
		{
			return Semaphore.OpenExistingWorker(name, SemaphoreRights.Modify | SemaphoreRights.Synchronize, out result) == Semaphore.OpenExistingResult.Success;
		}

		/// <summary>Открывает заданный именованный семафор, если он уже существует, с требуемыми правами доступа, и возвращает значение, указывающее, успешно ли выполнена операция.</summary>
		/// <param name="name">Имя системного семафора для открытия.</param>
		/// <param name="rights">Битовая комбинация значений перечисления, которые определяют желаемые права доступа.</param>
		/// <param name="result">При возврате этот метод содержит объект <see cref="T:System.Threading.Semaphore" />, представляющий именованный семафор, если вызов завершился успешно, или значение <see langword="null" />, если вызов завершился неудачно. Этот параметр обрабатывается как неинициализированный.</param>
		/// <returns>Значение <see langword="true" />, если именованный семафор был успешно открыт; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный семафор существует, но у пользователя нет прав доступа, необходимых для его использования.</exception>
		// Token: 0x06000A47 RID: 2631 RVA: 0x0002CF60 File Offset: 0x0002B160
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static bool TryOpenExisting(string name, SemaphoreRights rights, out Semaphore result)
		{
			return Semaphore.OpenExistingWorker(name, rights, out result) == Semaphore.OpenExistingResult.Success;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0002CF70 File Offset: 0x0002B170
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		private static Semaphore.OpenExistingResult OpenExistingWorker(string name, SemaphoreRights rights, out Semaphore result)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException(SR.GetString("Argument {0} cannot be null or zero-length.", new object[]
				{
					"name"
				}), "name");
			}
			if (name != null && 260 < name.Length)
			{
				throw new ArgumentException(SR.GetString("The name can be no more than 260 characters in length."));
			}
			result = null;
			int num;
			SafeWaitHandle safeWaitHandle = new SafeWaitHandle(Semaphore.OpenSemaphore_internal(name, rights, out num), true);
			if (safeWaitHandle.IsInvalid)
			{
				if (2 == num || 123 == num)
				{
					return Semaphore.OpenExistingResult.NameNotFound;
				}
				if (3 == num)
				{
					return Semaphore.OpenExistingResult.PathNotFound;
				}
				if (name != null && name.Length != 0 && 6 == num)
				{
					return Semaphore.OpenExistingResult.NameInvalid;
				}
				InternalResources.WinIOError(num, "");
			}
			result = new Semaphore(safeWaitHandle);
			return Semaphore.OpenExistingResult.Success;
		}

		/// <summary>Выходит из семафора и возвращает последнее значение счетчика.</summary>
		/// <returns>Счетчик семафора перед вызовом метода <see cref="Overload:System.Threading.Semaphore.Release" />.</returns>
		/// <exception cref="T:System.Threading.SemaphoreFullException">Счетчик семафора уже имеет максимальное значение.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32, связанная с именованным семафором.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Текущий семафор представляет именованный системный семафор, но пользователь не имеет прав <see cref="F:System.Security.AccessControl.SemaphoreRights.Modify" />.  
		///
		/// или - 
		/// Текущий семафор представляет именованный системный семафор, но он не был открыт с правами доступа <see cref="F:System.Security.AccessControl.SemaphoreRights.Modify" />.</exception>
		// Token: 0x06000A49 RID: 2633 RVA: 0x0002D027 File Offset: 0x0002B227
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[PrePrepareMethod]
		public int Release()
		{
			return this.Release(1);
		}

		/// <summary>Выходит из семафора указанное число раз и возвращает последнее значение счетчика.</summary>
		/// <param name="releaseCount">Количество требуемых выходов из семафора.</param>
		/// <returns>Счетчик семафора перед вызовом метода <see cref="Overload:System.Threading.Semaphore.Release" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="releaseCount" /> меньше 1.</exception>
		/// <exception cref="T:System.Threading.SemaphoreFullException">Счетчик семафора уже имеет максимальное значение.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32, связанная с именованным семафором.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Текущий семафор представляет именованный системный семафор, но пользователь не имеет прав <see cref="F:System.Security.AccessControl.SemaphoreRights.Modify" />.  
		///
		/// или - 
		/// Текущий семафор представляет именованный системный семафор, но он не был открыт с правами <see cref="F:System.Security.AccessControl.SemaphoreRights.Modify" />.</exception>
		// Token: 0x06000A4A RID: 2634 RVA: 0x0002D030 File Offset: 0x0002B230
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public int Release(int releaseCount)
		{
			if (releaseCount < 1)
			{
				throw new ArgumentOutOfRangeException("releaseCount", SR.GetString("Non-negative number required."));
			}
			int result;
			if (!Semaphore.ReleaseSemaphore_internal(base.SafeWaitHandle.DangerousGetHandle(), releaseCount, out result))
			{
				throw new SemaphoreFullException();
			}
			return result;
		}

		/// <summary>Возвращает настройки управления доступом для именованного системного семафора.</summary>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.SemaphoreSecurity" />, представляющий параметры безопасности управления доступом для именованного системного семафора.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Текущий объект <see cref="T:System.Threading.Semaphore" /> представляет именованный системный семафор, а пользователь не имеет прав <see cref="F:System.Security.AccessControl.SemaphoreRights.ReadPermissions" />.  
		///
		/// или - 
		/// Текущий объект <see cref="T:System.Threading.Semaphore" /> представляет именованный системный семафор и не был открыт с использованием прав <see cref="F:System.Security.AccessControl.SemaphoreRights.ReadPermissions" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Не поддерживается для Windows 98 или Windows Millennium Edition.</exception>
		// Token: 0x06000A4B RID: 2635 RVA: 0x0002D072 File Offset: 0x0002B272
		public SemaphoreSecurity GetAccessControl()
		{
			return new SemaphoreSecurity(base.SafeWaitHandle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
		}

		/// <summary>Задает безопасность управления доступом для именованного системного семафора.</summary>
		/// <param name="semaphoreSecurity">Объект <see cref="T:System.Security.AccessControl.SemaphoreSecurity" />, представляющий безопасность управления доступом для применения к именованному системному семафору.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="semaphoreSecurity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Пользователь не имеет прав <see cref="F:System.Security.AccessControl.SemaphoreRights.ChangePermissions" />.  
		///
		/// или - 
		/// Семафор не был открыт с правами <see cref="F:System.Security.AccessControl.SemaphoreRights.ChangePermissions" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий объект <see cref="T:System.Threading.Semaphore" /> не представляет именованный системный семафор.</exception>
		// Token: 0x06000A4C RID: 2636 RVA: 0x0002D081 File Offset: 0x0002B281
		public void SetAccessControl(SemaphoreSecurity semaphoreSecurity)
		{
			if (semaphoreSecurity == null)
			{
				throw new ArgumentNullException("semaphoreSecurity");
			}
			semaphoreSecurity.Persist(base.SafeWaitHandle);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0002D0A0 File Offset: 0x0002B2A0
		internal unsafe static IntPtr CreateSemaphore_internal(int initialCount, int maximumCount, string name, out int errorCode)
		{
			char* ptr = name;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return Semaphore.CreateSemaphore_icall(initialCount, maximumCount, ptr, (name != null) ? name.Length : 0, out errorCode);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0002D0D4 File Offset: 0x0002B2D4
		private unsafe static IntPtr OpenSemaphore_internal(string name, SemaphoreRights rights, out int errorCode)
		{
			char* ptr = name;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return Semaphore.OpenSemaphore_icall(ptr, (name != null) ? name.Length : 0, rights, out errorCode);
		}

		// Token: 0x06000A4F RID: 2639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr CreateSemaphore_icall(int initialCount, int maximumCount, char* name, int name_length, out int errorCode);

		// Token: 0x06000A50 RID: 2640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr OpenSemaphore_icall(char* name, int name_length, SemaphoreRights rights, out int errorCode);

		// Token: 0x06000A51 RID: 2641
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool ReleaseSemaphore_internal(IntPtr handle, int releaseCount, out int previousCount);

		// Token: 0x040006D6 RID: 1750
		private const int MAX_PATH = 260;

		// Token: 0x0200017F RID: 383
		private new enum OpenExistingResult
		{
			// Token: 0x040006D8 RID: 1752
			Success,
			// Token: 0x040006D9 RID: 1753
			NameNotFound,
			// Token: 0x040006DA RID: 1754
			PathNotFound,
			// Token: 0x040006DB RID: 1755
			NameInvalid
		}
	}
}
