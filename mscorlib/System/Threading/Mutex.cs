using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Permissions;

namespace System.Threading
{
	/// <summary>Примитив синхронизации, который также может использоваться в межпроцессорной синхронизации.</summary>
	// Token: 0x020002F3 RID: 755
	[ComVisible(true)]
	public sealed class Mutex : WaitHandle
	{
		// Token: 0x060020D9 RID: 8409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr CreateMutex_icall(bool initiallyOwned, char* name, int name_length, out bool created);

		// Token: 0x060020DA RID: 8410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr OpenMutex_icall(char* name, int name_length, MutexRights rights, out MonoIOError error);

		// Token: 0x060020DB RID: 8411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool ReleaseMutex_internal(IntPtr handle);

		// Token: 0x060020DC RID: 8412 RVA: 0x00076C40 File Offset: 0x00074E40
		private unsafe static IntPtr CreateMutex_internal(bool initiallyOwned, string name, out bool created)
		{
			char* ptr = name;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return Mutex.CreateMutex_icall(initiallyOwned, ptr, (name != null) ? name.Length : 0, out created);
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00076C74 File Offset: 0x00074E74
		private unsafe static IntPtr OpenMutex_internal(string name, MutexRights rights, out MonoIOError error)
		{
			char* ptr = name;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return Mutex.OpenMutex_icall(ptr, (name != null) ? name.Length : 0, rights, out error);
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00076CA5 File Offset: 0x00074EA5
		private Mutex(IntPtr handle)
		{
			this.Handle = handle;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Mutex" /> стандартными свойствами.</summary>
		// Token: 0x060020DF RID: 8415 RVA: 0x00076CB4 File Offset: 0x00074EB4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public Mutex()
		{
			bool flag;
			this.Handle = Mutex.CreateMutex_internal(false, null, out flag);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Mutex" /> логическим значением, указывающим, должен ли вызывающий поток быть изначальным владельцем мьютекса.</summary>
		/// <param name="initiallyOwned">Значение <see langword="true" /> для предоставления вызывающему потоку изначального владения мьютексом; в противном случае — <see langword="false" />.</param>
		// Token: 0x060020E0 RID: 8416 RVA: 0x00076CD8 File Offset: 0x00074ED8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public Mutex(bool initiallyOwned)
		{
			bool flag;
			this.Handle = Mutex.CreateMutex_internal(initiallyOwned, null, out flag);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Mutex" /> логическим значением, указывающим, должен ли вызывающий поток быть изначальным владельцем мьютекса, а также иметь строку, являющуюся именем мьютекса.</summary>
		/// <param name="initiallyOwned">Значение <see langword="true" /> для предоставления вызывающему потоку изначального владения именованным системным мьютексом, если этот мьютекс создан данным вызовом; в противном случае — значение <see langword="false" />.</param>
		/// <param name="name">Имя <see cref="T:System.Threading.Mutex" />. Если значение равно <see langword="null" />, у объекта <see cref="T:System.Threading.Mutex" /> нет имени.</param>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный мьютекс существует, имеет безопасность управления доступом, но пользователь не имеет прав <see cref="F:System.Security.AccessControl.MutexRights.FullControl" />.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованный мьютекс нельзя создать; вероятно, дескриптор ожидания другого типа имеет то же имя.</exception>
		/// <exception cref="T:System.ArgumentException">Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		// Token: 0x060020E1 RID: 8417 RVA: 0x00076CFC File Offset: 0x00074EFC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
		public Mutex(bool initiallyOwned, string name)
		{
			bool flag;
			this.Handle = Mutex.CreateMutex_internal(initiallyOwned, name, out flag);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Mutex" /> логическим значением, указывающим, должен ли вызывающий поток быть изначальным владельцем мьютекса, иметь строку, являющуюся именем мьютекса, и логическое значение, которое при возврате метода показывает, предоставлено ли вызывающему потоку изначальное владение мьютексом.</summary>
		/// <param name="initiallyOwned">Значение <see langword="true" /> для предоставления вызывающему потоку изначального владения именованным системным мьютексом, если этот мьютекс создан данным вызовом; в противном случае — значение <see langword="false" />.</param>
		/// <param name="name">Имя <see cref="T:System.Threading.Mutex" />. Если значение равно <see langword="null" />, у объекта <see cref="T:System.Threading.Mutex" /> нет имени.</param>
		/// <param name="createdNew">При возврате из метода содержит логическое значение <see langword="true" />, если был создан локальный мьютекс (то есть, если параметр <paramref name="name" /> имеет значение <see langword="null" /> или содержит пустую строку) или был создан именованный системный мьютекс; значение <see langword="false" />, если указанный именованный системный мьютекс уже существует. Этот параметр передается неинициализированным.</param>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный мьютекс существует, имеет безопасность управления доступом, но пользователь не имеет прав <see cref="F:System.Security.AccessControl.MutexRights.FullControl" />.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованный мьютекс нельзя создать; вероятно, дескриптор ожидания другого типа имеет то же имя.</exception>
		/// <exception cref="T:System.ArgumentException">Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		// Token: 0x060020E2 RID: 8418 RVA: 0x00076D1E File Offset: 0x00074F1E
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
		public Mutex(bool initiallyOwned, string name, out bool createdNew)
		{
			this.Handle = Mutex.CreateMutex_internal(initiallyOwned, name, out createdNew);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Mutex" /> логическим значением, указывающим, должен ли вызывающий поток быть изначальным владельцем мьютекса, иметь строку, являющуюся именем мьютекса, и логическое значение, которое при возврате метода показывает, предоставлено ли вызывающему потоку изначальное владение мьютексом, а также безопасность управления доступом для применения к именованному мьютексу.</summary>
		/// <param name="initiallyOwned">Значение <see langword="true" /> для предоставления вызывающему потоку изначального владения именованным системным мьютексом, если этот мьютекс создан данным вызовом; в противном случае — значение <see langword="false" />.</param>
		/// <param name="name">Имя системного мьютекса. Если значение равно <see langword="null" />, у объекта <see cref="T:System.Threading.Mutex" /> нет имени.</param>
		/// <param name="createdNew">При возврате из метода содержит логическое значение <see langword="true" />, если был создан локальный мьютекс (то есть, если параметр <paramref name="name" /> имеет значение <see langword="null" /> или содержит пустую строку) или был создан именованный системный мьютекс; значение <see langword="false" />, если указанный именованный системный мьютекс уже существует. Этот параметр передается неинициализированным.</param>
		/// <param name="mutexSecurity">Объект <see cref="T:System.Security.AccessControl.MutexSecurity" />, представляющий безопасность управления доступом для применения к именованному системному мьютексу.</param>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный мьютекс существует, имеет безопасность управления доступом, но пользователь не имеет прав <see cref="F:System.Security.AccessControl.MutexRights.FullControl" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованный мьютекс нельзя создать; вероятно, дескриптор ожидания другого типа имеет то же имя.</exception>
		/// <exception cref="T:System.ArgumentException">Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		// Token: 0x060020E3 RID: 8419 RVA: 0x00076D1E File Offset: 0x00074F1E
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[MonoTODO("Use MutexSecurity in CreateMutex_internal")]
		public Mutex(bool initiallyOwned, string name, out bool createdNew, MutexSecurity mutexSecurity)
		{
			this.Handle = Mutex.CreateMutex_internal(initiallyOwned, name, out createdNew);
		}

		/// <summary>Получает объект <see cref="T:System.Security.AccessControl.MutexSecurity" />, представляющий безопасность управления доступом для именованного мьютекса.</summary>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.MutexSecurity" />, представляющий безопасность управления доступом для именованного мьютекса.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Текущий объект <see cref="T:System.Threading.Mutex" /> представляет именованный системный мьютекс, но пользователь не имеет прав <see cref="F:System.Security.AccessControl.MutexRights.ReadPermissions" />.  
		///
		/// или - 
		/// Текущий объект <see cref="T:System.Threading.Mutex" /> представляет именованный системный мьютекс, но он не был открыт с правами <see cref="F:System.Security.AccessControl.MutexRights.ReadPermissions" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Не поддерживается для Windows 98 или Windows Millennium Edition.</exception>
		// Token: 0x060020E4 RID: 8420 RVA: 0x00076D34 File Offset: 0x00074F34
		public MutexSecurity GetAccessControl()
		{
			return new MutexSecurity(base.SafeWaitHandle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
		}

		/// <summary>Открывает указанный именованный мьютекс, если он уже существует.</summary>
		/// <param name="name">Имя системного мьютекса для открытия.</param>
		/// <returns>Объект, представляющий именованный системный мьютекс.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованный мьютекс не существует.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный мьютекс существует, но у пользователя нет прав доступа, необходимых для его использования.</exception>
		// Token: 0x060020E5 RID: 8421 RVA: 0x00076D43 File Offset: 0x00074F43
		public static Mutex OpenExisting(string name)
		{
			return Mutex.OpenExisting(name, MutexRights.Modify | MutexRights.Synchronize);
		}

		/// <summary>Открывает указанный именованный мьютекс, если он уже существует, с требуемыми правами доступа.</summary>
		/// <param name="name">Имя системного мьютекса для открытия.</param>
		/// <param name="rights">Битовая комбинация значений перечисления, которые определяют желаемые права доступа.</param>
		/// <returns>Объект, представляющий именованный системный мьютекс.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">Именованный мьютекс не существует.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный мьютекс существует, но у пользователя нет необходимой безопасности доступа.</exception>
		// Token: 0x060020E6 RID: 8422 RVA: 0x00076D50 File Offset: 0x00074F50
		public static Mutex OpenExisting(string name, MutexRights rights)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0 || name.Length > 260)
			{
				throw new ArgumentException("name", Locale.GetText("Invalid length [1-260]."));
			}
			MonoIOError monoIOError;
			IntPtr intPtr = Mutex.OpenMutex_internal(name, rights, out monoIOError);
			if (!(intPtr == (IntPtr)null))
			{
				return new Mutex(intPtr);
			}
			if (monoIOError == MonoIOError.ERROR_FILE_NOT_FOUND)
			{
				throw new WaitHandleCannotBeOpenedException(Locale.GetText("Named Mutex handle does not exist: ") + name);
			}
			if (monoIOError == MonoIOError.ERROR_ACCESS_DENIED)
			{
				throw new UnauthorizedAccessException();
			}
			throw new IOException(Locale.GetText("Win32 IO error: ") + monoIOError.ToString());
		}

		/// <summary>Открывает указанный именованный мьютекс, если он уже существует, и возвращает значение, указывающее, успешно ли выполнена операция.</summary>
		/// <param name="name">Имя системного мьютекса для открытия.</param>
		/// <param name="result">Когда выполнение этого метода завершается, содержит объект <see cref="T:System.Threading.Mutex" />, представляющий именованный мьютекс, если вызов завершился успешно, или значение <see langword="null" />, если произошел сбой вызова. Этот параметр обрабатывается как неинициализированный.</param>
		/// <returns>Значение <see langword="true" />, если именованный мьютекс был успешно открыт; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный мьютекс существует, но у пользователя нет прав доступа, необходимых для его использования.</exception>
		// Token: 0x060020E7 RID: 8423 RVA: 0x00076DF8 File Offset: 0x00074FF8
		public static bool TryOpenExisting(string name, out Mutex result)
		{
			return Mutex.TryOpenExisting(name, MutexRights.Modify | MutexRights.Synchronize, out result);
		}

		/// <summary>Открывает указанный именованный мьютекс, если он уже существует, с требуемыми правами доступа, и возвращает значение, указывающее, успешно ли выполнена операция.</summary>
		/// <param name="name">Имя системного мьютекса для открытия.</param>
		/// <param name="rights">Битовая комбинация значений перечисления, которые определяют желаемые права доступа.</param>
		/// <param name="result">Когда выполнение этого метода завершается, содержит объект <see cref="T:System.Threading.Mutex" />, представляющий именованный мьютекс, если вызов завершился успешно, или значение <see langword="null" />, если произошел сбой вызова. Этот параметр обрабатывается как неинициализированный.</param>
		/// <returns>Значение <see langword="true" />, если именованный мьютекс был успешно открыт; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> равен пустой строке.  
		///
		/// или - 
		/// Длина значения параметра <paramref name="name" /> превышает 260 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Произошла ошибка Win32.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Именованный мьютекс существует, но у пользователя нет прав доступа, необходимых для его использования.</exception>
		// Token: 0x060020E8 RID: 8424 RVA: 0x00076E08 File Offset: 0x00075008
		public static bool TryOpenExisting(string name, MutexRights rights, out Mutex result)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0 || name.Length > 260)
			{
				throw new ArgumentException("name", Locale.GetText("Invalid length [1-260]."));
			}
			MonoIOError monoIOError;
			IntPtr intPtr = Mutex.OpenMutex_internal(name, rights, out monoIOError);
			if (intPtr == (IntPtr)null)
			{
				result = null;
				return false;
			}
			result = new Mutex(intPtr);
			return true;
		}

		/// <summary>Освобождает объект <see cref="T:System.Threading.Mutex" /> один раз.</summary>
		/// <exception cref="T:System.ApplicationException">Вызывающий поток не является владельцем мьютекса.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		// Token: 0x060020E9 RID: 8425 RVA: 0x00076E74 File Offset: 0x00075074
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public void ReleaseMutex()
		{
			if (!Mutex.ReleaseMutex_internal(this.Handle))
			{
				throw new ApplicationException("Mutex is not owned");
			}
		}

		/// <summary>Задает безопасность управления доступом для именованного системного мьютекса.</summary>
		/// <param name="mutexSecurity">Объект <see cref="T:System.Security.AccessControl.MutexSecurity" />, представляющий безопасность управления доступом для применения к именованному системному мьютексу.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mutexSecurity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Пользователь не имеет разрешений <see cref="F:System.Security.AccessControl.MutexRights.ChangePermissions" />.  
		///
		/// или - 
		/// Мьютекс не был открыт с <see cref="F:System.Security.AccessControl.MutexRights.ChangePermissions" />.</exception>
		/// <exception cref="T:System.SystemException">Текущий объект <see cref="T:System.Threading.Mutex" /> не представляет именованный системный мьютекс.</exception>
		// Token: 0x060020EA RID: 8426 RVA: 0x00076E8E File Offset: 0x0007508E
		public void SetAccessControl(MutexSecurity mutexSecurity)
		{
			if (mutexSecurity == null)
			{
				throw new ArgumentNullException("mutexSecurity");
			}
			mutexSecurity.PersistModifications(base.SafeWaitHandle);
		}
	}
}
