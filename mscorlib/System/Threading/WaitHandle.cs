using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Contexts;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	/// <summary>Инкапсулирует связанные с операционной системой объекты, ожидающие монопольного доступа к общим ресурсам.</summary>
	// Token: 0x020002EA RID: 746
	[ComVisible(true)]
	[StructLayout(LayoutKind.Sequential)]
	public abstract class WaitHandle : MarshalByRefObject, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.WaitHandle" />.</summary>
		// Token: 0x06002073 RID: 8307 RVA: 0x00075FEB File Offset: 0x000741EB
		protected WaitHandle()
		{
			this.Init();
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x00075FF9 File Offset: 0x000741F9
		[SecuritySafeCritical]
		private void Init()
		{
			this.safeWaitHandle = null;
			this.waitHandle = WaitHandle.InvalidHandle;
			this.hasThreadAffinity = false;
		}

		/// <summary>Возвращает или задает собственный дескриптор операционной системы.</summary>
		/// <returns>Объект <see langword="IntPtr" />, представляющий собственный дескриптор операционной системы. Значением по умолчанию является значение поля <see cref="F:System.Threading.WaitHandle.InvalidHandle" />.</returns>
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x00076016 File Offset: 0x00074216
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x00076038 File Offset: 0x00074238
		[Obsolete("Use the SafeWaitHandle property instead.")]
		public virtual IntPtr Handle
		{
			[SecuritySafeCritical]
			get
			{
				if (this.safeWaitHandle != null)
				{
					return this.safeWaitHandle.DangerousGetHandle();
				}
				return WaitHandle.InvalidHandle;
			}
			[SecurityCritical]
			set
			{
				if (value == WaitHandle.InvalidHandle)
				{
					if (this.safeWaitHandle != null)
					{
						this.safeWaitHandle.SetHandleAsInvalid();
						this.safeWaitHandle = null;
					}
				}
				else
				{
					this.safeWaitHandle = new SafeWaitHandle(value, true);
				}
				this.waitHandle = value;
			}
		}

		/// <summary>Возвращает или задает собственный дескриптор операционной системы.</summary>
		/// <returns>Объект <see cref="T:Microsoft.Win32.SafeHandles.SafeWaitHandle" />, представляющий собственный дескриптор операционной системы.</returns>
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0007608A File Offset: 0x0007428A
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x000760B4 File Offset: 0x000742B4
		public SafeWaitHandle SafeWaitHandle
		{
			[SecurityCritical]
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			get
			{
				if (this.safeWaitHandle == null)
				{
					this.safeWaitHandle = new SafeWaitHandle(WaitHandle.InvalidHandle, false);
				}
				return this.safeWaitHandle;
			}
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			[SecurityCritical]
			set
			{
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
				}
				finally
				{
					if (value == null)
					{
						this.safeWaitHandle = null;
						this.waitHandle = WaitHandle.InvalidHandle;
					}
					else
					{
						this.safeWaitHandle = value;
						this.waitHandle = this.safeWaitHandle.DangerousGetHandle();
					}
				}
			}
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x00076110 File Offset: 0x00074310
		[SecurityCritical]
		internal void SetHandleInternal(SafeWaitHandle handle)
		{
			this.safeWaitHandle = handle;
			this.waitHandle = handle.DangerousGetHandle();
		}

		/// <summary>Блокирует текущий поток до получения сигнала текущим объектом <see cref="T:System.Threading.WaitHandle" />, используя 32-разрядное целое число со знаком для задания периода времени и указывая, следует ли выйти из домена синхронизации до начала ожидания.</summary>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <param name="exitContext">Значение <see langword="true" /> для выхода из домена синхронизации в текущем контексте перед ожиданием (в синхронизированном контексте) с его последующим повторным получением; в противном случае — <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" /> при получении сигнала текущим экземпляром; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Текущий экземпляр является прозрачным прокси для объекта <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x0600207A RID: 8314 RVA: 0x00076127 File Offset: 0x00074327
		public virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
		{
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			return this.WaitOne((long)millisecondsTimeout, exitContext);
		}

		/// <summary>Блокирует текущий поток до получения сигнала текущим экземпляром, используя значение типа <see cref="T:System.TimeSpan" /> для задания интервала времени и указывая, следует ли выйти из домена синхронизации до начала ожидания.</summary>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <param name="exitContext">Значение <see langword="true" /> для выхода из домена синхронизации в текущем контексте перед ожиданием (в синхронизированном контексте) с его последующим повторным получением; в противном случае — <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" /> при получении сигнала текущим экземпляром; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от -1 миллисекунды, которое представляет неограниченное время ожидания. 
		/// -или- 
		///  Значение <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Текущий экземпляр является прозрачным прокси для объекта <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x0600207B RID: 8315 RVA: 0x0007614C File Offset: 0x0007434C
		public virtual bool WaitOne(TimeSpan timeout, bool exitContext)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (-1L > num || 2147483647L < num)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			return this.WaitOne(num, exitContext);
		}

		/// <summary>Блокирует текущий поток до получения сигнала объектом <see cref="T:System.Threading.WaitHandle" />.</summary>
		/// <returns>Значение <see langword="true" />, если текущий экземпляр получает сигнал. Пока текущий экземпляр не сигнализирует, метод <see cref="M:System.Threading.WaitHandle.WaitOne(System.Int32,System.Boolean)" /> не возвращает управление.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Текущий экземпляр является прозрачным прокси для объекта <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x0600207C RID: 8316 RVA: 0x0007618D File Offset: 0x0007438D
		public virtual bool WaitOne()
		{
			return this.WaitOne(-1, false);
		}

		/// <summary>Блокирует текущий поток до получения текущим дескриптором <see cref="T:System.Threading.WaitHandle" /> сигнала, используя 32-разрядное целое число со знаком для указания интервала времени в миллисекундах.</summary>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <returns>Значение <see langword="true" /> при получении сигнала текущим экземпляром; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Текущий экземпляр является прозрачным прокси для объекта <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x0600207D RID: 8317 RVA: 0x00076197 File Offset: 0x00074397
		public virtual bool WaitOne(int millisecondsTimeout)
		{
			return this.WaitOne(millisecondsTimeout, false);
		}

		/// <summary>Блокирует текущий поток до получения сигнала текущим экземпляром, используя значение типа <see cref="T:System.TimeSpan" /> для указания интервала времени.</summary>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <returns>Значение <see langword="true" /> при получении сигнала текущим экземпляром; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от -1 миллисекунды, которое представляет неограниченное время ожидания. 
		///
		/// или - 
		/// Значение <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Текущий экземпляр является прозрачным прокси для объекта <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x0600207E RID: 8318 RVA: 0x000761A1 File Offset: 0x000743A1
		public virtual bool WaitOne(TimeSpan timeout)
		{
			return this.WaitOne(timeout, false);
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x000761AB File Offset: 0x000743AB
		[SecuritySafeCritical]
		private bool WaitOne(long timeout, bool exitContext)
		{
			return WaitHandle.InternalWaitOne(this.safeWaitHandle, timeout, this.hasThreadAffinity, exitContext);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x000761C4 File Offset: 0x000743C4
		[SecurityCritical]
		internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			if (waitableSafeHandle == null)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot access a disposed object."));
			}
			int num = WaitHandle.WaitOneNative(waitableSafeHandle, (uint)millisecondsTimeout, hasThreadAffinity, exitContext);
			if (num == 128)
			{
				WaitHandle.ThrowAbandonedMutexException();
			}
			return num != 258 && num != int.MaxValue;
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x00076214 File Offset: 0x00074414
		[SecurityCritical]
		internal bool WaitOneWithoutFAS()
		{
			if (this.safeWaitHandle == null)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot access a disposed object."));
			}
			long num = -1L;
			int num2 = WaitHandle.WaitOneNative(this.safeWaitHandle, (uint)num, this.hasThreadAffinity, false);
			if (num2 == 128)
			{
				WaitHandle.ThrowAbandonedMutexException();
			}
			return num2 != 258 && num2 != int.MaxValue;
		}

		/// <summary>Ожидает получения сигнала всеми элементами заданного массива, используя значение типа <see cref="T:System.Int32" /> для задания интервала времени и указывая, следует ли выйти из домена синхронизации до начала ожидания.</summary>
		/// <param name="waitHandles">Массив <see langword="WaitHandle" />, содержащий объекты, ожидаемые текущим экземпляром. Данный массив не может содержать несколько ссылок на один и тот же объект (дубликатов).</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <param name="exitContext">Значение <see langword="true" /> для выхода из домена синхронизации в текущем контексте перед ожиданием (в синхронизированном контексте) с его последующим повторным получением; в противном случае — <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если каждый элемент массива <paramref name="waitHandles" /> получил сигнал; в противном случае значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="waitHandles" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Один или несколько объектов массива <paramref name="waitHandles" /> имеют значение <see langword="null" />.  
		///
		/// -или- 
		///  Массив <paramref name="waitHandles" /> не содержит элементов, и используется платформа .NET Framework версии 2.0 или более поздней.</exception>
		/// <exception cref="T:System.DuplicateWaitObjectException">Массив <paramref name="waitHandles" /> содержит повторяющиеся элементы.</exception>
		/// <exception cref="T:System.NotSupportedException">Массив <paramref name="waitHandles" /> содержит больше объектов, чем разрешено системой.  
		/// -или- 
		/// Атрибут <see cref="T:System.STAThreadAttribute" /> применяется к процедуре потока для текущего потока, а массив <paramref name="waitHandles" /> содержит более одного элемента.</exception>
		/// <exception cref="T:System.ApplicationException">Массив <paramref name="waitHandles" /> не содержит элементов, и используется платформа .NET Framework версии 1.0 или 1.1.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Массив <paramref name="waitHandles" /> содержит прозрачный прокси для элемента <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x06002082 RID: 8322 RVA: 0x00076278 File Offset: 0x00074478
		[SecuritySafeCritical]
		public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
		{
			if (waitHandles == null)
			{
				throw new ArgumentNullException(Environment.GetResourceString("The waitHandles parameter cannot be null."));
			}
			if (waitHandles.Length == 0)
			{
				throw new ArgumentNullException(Environment.GetResourceString("Waithandle array may not be empty."));
			}
			if (waitHandles.Length > 64)
			{
				throw new NotSupportedException(Environment.GetResourceString("The number of WaitHandles must be less than or equal to 64."));
			}
			if (-1 > millisecondsTimeout)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			WaitHandle[] array = new WaitHandle[waitHandles.Length];
			for (int i = 0; i < waitHandles.Length; i++)
			{
				WaitHandle waitHandle = waitHandles[i];
				if (waitHandle == null)
				{
					throw new ArgumentNullException(Environment.GetResourceString("At least one element in the specified array was null."));
				}
				if (RemotingServices.IsTransparentProxy(waitHandle))
				{
					throw new InvalidOperationException(Environment.GetResourceString("Cannot wait on a transparent proxy."));
				}
				array[i] = waitHandle;
			}
			int num = WaitHandle.WaitMultiple(array, millisecondsTimeout, exitContext, true);
			if (128 <= num && 128 + array.Length > num)
			{
				WaitHandle.ThrowAbandonedMutexException();
			}
			GC.KeepAlive(array);
			return num != 258 && num != int.MaxValue;
		}

		/// <summary>Ожидает получения сигнала всеми элементами заданного массива, используя значение типа <see cref="T:System.TimeSpan" /> для задания интервала времени и указывая, следует ли выйти из домена синхронизации до начала ожидания.</summary>
		/// <param name="waitHandles">Массив <see langword="WaitHandle" />, содержащий объекты, ожидаемые текущим экземпляром. Этот массив не может содержать несколько ссылок на один и тот же объект.</param>
		/// <param name="timeout">Объект <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или объект <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <param name="exitContext">Значение <see langword="true" /> для выхода из домена синхронизации в текущем контексте перед ожиданием (в синхронизированном контексте) с его последующим повторным получением; в противном случае — <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, когда каждый элемент массива <paramref name="waitHandles" /> получил сигнал; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="waitHandles" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Один или несколько объектов массива <paramref name="waitHandles" /> имеют значение <see langword="null" />.  
		///
		/// -или- 
		///  Массив <paramref name="waitHandles" /> не содержит элементов, и используется платформа .NET Framework версии 2.0 или более поздней.</exception>
		/// <exception cref="T:System.DuplicateWaitObjectException">Массив <paramref name="waitHandles" /> содержит повторяющиеся элементы.</exception>
		/// <exception cref="T:System.NotSupportedException">Массив <paramref name="waitHandles" /> содержит больше объектов, чем разрешено системой.  
		/// -или- 
		/// Атрибут <see cref="T:System.STAThreadAttribute" /> применяется к процедуре потока для текущего потока, а массив <paramref name="waitHandles" /> содержит более одного элемента.</exception>
		/// <exception cref="T:System.ApplicationException">Массив <paramref name="waitHandles" /> не содержит элементов, и используется платформа .NET Framework версии 1.0 или 1.1.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от -1 миллисекунды, которое представляет неограниченное время ожидания. 
		/// -или- 
		///  Значение <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание прервано, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Массив <paramref name="waitHandles" /> содержит прозрачный прокси для элемента <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x06002083 RID: 8323 RVA: 0x00076364 File Offset: 0x00074564
		public static bool WaitAll(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (-1L > num || 2147483647L < num)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			return WaitHandle.WaitAll(waitHandles, (int)num, exitContext);
		}

		/// <summary>Ожидает получения сигнала всеми элементами заданного массива.</summary>
		/// <param name="waitHandles">Массив <see langword="WaitHandle" />, содержащий объекты, ожидаемые текущим экземпляром. Этот массив не может содержать несколько ссылок на один и тот же объект.</param>
		/// <returns>
		///   <see langword="true" />, когда каждый элемент <paramref name="waitHandles" /> получил сигнал. В противном случае возврат из метода не происходит.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="waitHandles" /> имеет значение <see langword="null" />. -или- 
		/// Один или несколько объектов массива <paramref name="waitHandles" /> имеют значение <see langword="null" />.  
		/// -или- 
		///  Массив <paramref name="waitHandles" /> не содержит элементов, и используется платформа .NET Framework версии 2.0 или более поздней.</exception>
		/// <exception cref="T:System.DuplicateWaitObjectException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.ArgumentException" />.  
		///
		///
		///
		///
		///  Массив <paramref name="waitHandles" /> содержит повторяющиеся элементы.</exception>
		/// <exception cref="T:System.NotSupportedException">Массив <paramref name="waitHandles" /> содержит больше объектов, чем разрешено системой.  
		/// -или- 
		/// Атрибут <see cref="T:System.STAThreadAttribute" /> применяется к процедуре потока для текущего потока, а массив <paramref name="waitHandles" /> содержит более одного элемента.</exception>
		/// <exception cref="T:System.ApplicationException">Массив <paramref name="waitHandles" /> не содержит элементов, и используется платформа .NET Framework версии 1.0 или 1.1.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание прервано, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Массив <paramref name="waitHandles" /> содержит прозрачный прокси для элемента <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x06002084 RID: 8324 RVA: 0x000763A6 File Offset: 0x000745A6
		public static bool WaitAll(WaitHandle[] waitHandles)
		{
			return WaitHandle.WaitAll(waitHandles, -1, true);
		}

		/// <summary>Ожидает получения сигнала всеми элементами заданного массива, используя значение <see cref="T:System.Int32" /> для указания интервала времени.</summary>
		/// <param name="waitHandles">Массив <see langword="WaitHandle" />, содержащий объекты, ожидаемые текущим экземпляром. Данный массив не может содержать несколько ссылок на один и тот же объект (дубликатов).</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <returns>Значение <see langword="true" />, если каждый элемент массива <paramref name="waitHandles" /> получил сигнал; в противном случае значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="waitHandles" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Один или несколько объектов массива <paramref name="waitHandles" /> имеют значение <see langword="null" />.  
		/// -или- 
		///  В массиве <paramref name="waitHandles" /> отсутствуют элементы.</exception>
		/// <exception cref="T:System.DuplicateWaitObjectException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.ArgumentException" />.  
		///
		///
		///
		///
		///  Массив <paramref name="waitHandles" /> содержит повторяющиеся элементы.</exception>
		/// <exception cref="T:System.NotSupportedException">Массив <paramref name="waitHandles" /> содержит больше объектов, чем разрешено системой.  
		///
		/// или - 
		/// Атрибут <see cref="T:System.STAThreadAttribute" /> применяется к процедуре потока для текущего потока, а массив <paramref name="waitHandles" /> содержит более одного элемента.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Массив <paramref name="waitHandles" /> содержит прозрачный прокси для элемента <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x06002085 RID: 8325 RVA: 0x000763B0 File Offset: 0x000745B0
		public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout)
		{
			return WaitHandle.WaitAll(waitHandles, millisecondsTimeout, true);
		}

		/// <summary>Ожидает получения сигнала всеми элементами заданного массива, используя значение <see cref="T:System.TimeSpan" /> для указания интервала времени.</summary>
		/// <param name="waitHandles">Массив <see langword="WaitHandle" />, содержащий объекты, ожидаемые текущим экземпляром. Этот массив не может содержать несколько ссылок на один и тот же объект.</param>
		/// <param name="timeout">Объект <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или объект <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <returns>Значение <see langword="true" />, если каждый элемент массива <paramref name="waitHandles" /> получил сигнал; в противном случае значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="waitHandles" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Один или несколько объектов массива <paramref name="waitHandles" /> имеют значение <see langword="null" />.  
		/// -или- 
		///  В массиве <paramref name="waitHandles" /> отсутствуют элементы.</exception>
		/// <exception cref="T:System.DuplicateWaitObjectException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.ArgumentException" />.  
		///
		///
		///
		///
		///  Массив <paramref name="waitHandles" /> содержит повторяющиеся элементы.</exception>
		/// <exception cref="T:System.NotSupportedException">Массив <paramref name="waitHandles" /> содержит больше объектов, чем разрешено системой.  
		/// -или- 
		/// Атрибут <see cref="T:System.STAThreadAttribute" /> применяется к процедуре потока для текущего потока, а массив <paramref name="waitHandles" /> содержит более одного элемента.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от -1 миллисекунды, которое представляет неограниченное время ожидания. 
		/// -или- 
		///  Значение <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание прервано, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Массив <paramref name="waitHandles" /> содержит прозрачный прокси для элемента <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x06002086 RID: 8326 RVA: 0x000763BA File Offset: 0x000745BA
		public static bool WaitAll(WaitHandle[] waitHandles, TimeSpan timeout)
		{
			return WaitHandle.WaitAll(waitHandles, timeout, true);
		}

		/// <summary>Ожидает, пока какой-либо из элементов заданного массива не получит сигнал, используя 32-разрядное целое число со знаком для задания интервала времени и определения, нужно ли осуществить выход из домена синхронизации до окончания ожидания.</summary>
		/// <param name="waitHandles">Массив <see langword="WaitHandle" />, содержащий объекты, ожидаемые текущим экземпляром.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <param name="exitContext">Значение <see langword="true" /> для выхода из домена синхронизации в текущем контексте перед ожиданием (в синхронизированном контексте) с его последующим повторным получением; в противном случае — <see langword="false" />.</param>
		/// <returns>Индекс объекта в массиве, удовлетворившего условиям ожидания, или значение <see cref="F:System.Threading.WaitHandle.WaitTimeout" />, если ни один из объектов не удовлетворил условиям ожидания и истек интервал времени, равный <paramref name="millisecondsTimeout" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="waitHandles" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Один или несколько объектов массива <paramref name="waitHandles" /> имеют значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Массив <paramref name="waitHandles" /> содержит больше объектов, чем разрешено системой.</exception>
		/// <exception cref="T:System.ApplicationException">
		///   <paramref name="waitHandles" /> является массивом без элементов, а платформа .NET Framework имеет версию 1.0 или 1.1.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="waitHandles" /> является массивом без элементов, а платформа .NET Framework имеет версию 2.0 или выше.</exception>
		/// <exception cref="T:System.InvalidOperationException">Массив <paramref name="waitHandles" /> содержит прозрачный прокси для элемента <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x06002087 RID: 8327 RVA: 0x000763C4 File Offset: 0x000745C4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[SecuritySafeCritical]
		public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
		{
			if (waitHandles == null)
			{
				throw new ArgumentNullException(Environment.GetResourceString("The waitHandles parameter cannot be null."));
			}
			if (waitHandles.Length == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Waithandle array may not be empty."));
			}
			if (64 < waitHandles.Length)
			{
				throw new NotSupportedException(Environment.GetResourceString("The number of WaitHandles must be less than or equal to 64."));
			}
			if (-1 > millisecondsTimeout)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			WaitHandle[] array = new WaitHandle[waitHandles.Length];
			for (int i = 0; i < waitHandles.Length; i++)
			{
				WaitHandle waitHandle = waitHandles[i];
				if (waitHandle == null)
				{
					throw new ArgumentNullException(Environment.GetResourceString("At least one element in the specified array was null."));
				}
				if (RemotingServices.IsTransparentProxy(waitHandle))
				{
					throw new InvalidOperationException(Environment.GetResourceString("Cannot wait on a transparent proxy."));
				}
				array[i] = waitHandle;
			}
			int num = WaitHandle.WaitMultiple(array, millisecondsTimeout, exitContext, false);
			if (128 <= num && 128 + array.Length > num)
			{
				int num2 = num - 128;
				if (0 <= num2 && num2 < array.Length)
				{
					WaitHandle.ThrowAbandonedMutexException(num2, array[num2]);
				}
				else
				{
					WaitHandle.ThrowAbandonedMutexException();
				}
			}
			GC.KeepAlive(array);
			return num;
		}

		/// <summary>Ожидает получения сигнала какими-либо элементами заданного массива, используя <see cref="T:System.TimeSpan" /> для задания интервала времени и указывая, следует ли выйти из домена синхронизации до начала ожидания.</summary>
		/// <param name="waitHandles">Массив <see langword="WaitHandle" />, содержащий объекты, ожидаемые текущим экземпляром.</param>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <param name="exitContext">Значение <see langword="true" /> для выхода из домена синхронизации в текущем контексте перед ожиданием (в синхронизированном контексте) с его последующим повторным получением; в противном случае — <see langword="false" />.</param>
		/// <returns>Индекс объекта в массиве, удовлетворившего условиям ожидания, или значение <see cref="F:System.Threading.WaitHandle.WaitTimeout" />, если ни один из объектов не удовлетворил условиям ожидания и истек интервал времени, равный <paramref name="timeout" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="waitHandles" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Один или несколько объектов массива <paramref name="waitHandles" /> имеют значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Массив <paramref name="waitHandles" /> содержит больше объектов, чем разрешено системой.</exception>
		/// <exception cref="T:System.ApplicationException">
		///   <paramref name="waitHandles" /> является массивом без элементов, а платформа .NET Framework имеет версию 1.0 или 1.1.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от -1 миллисекунды, которое представляет неограниченное время ожидания. 
		///
		/// или - 
		/// Значение <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="waitHandles" /> является массивом без элементов, а платформа .NET Framework имеет версию 2.0 или выше.</exception>
		/// <exception cref="T:System.InvalidOperationException">Массив <paramref name="waitHandles" /> содержит прозрачный прокси для элемента <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x06002088 RID: 8328 RVA: 0x000764C0 File Offset: 0x000746C0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (-1L > num || 2147483647L < num)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			return WaitHandle.WaitAny(waitHandles, (int)num, exitContext);
		}

		/// <summary>Ожидает получения сигнала любыми элементами заданного массива, используя значение типа <see cref="T:System.TimeSpan" /> для указания интервала времени.</summary>
		/// <param name="waitHandles">Массив <see langword="WaitHandle" />, содержащий объекты, ожидаемые текущим экземпляром.</param>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <returns>Индекс объекта в массиве, удовлетворившего условиям ожидания, или значение <see cref="F:System.Threading.WaitHandle.WaitTimeout" />, если ни один из объектов не удовлетворил условиям ожидания и истек интервал времени, равный <paramref name="timeout" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="waitHandles" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Один или несколько объектов массива <paramref name="waitHandles" /> имеют значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Массив <paramref name="waitHandles" /> содержит больше объектов, чем разрешено системой.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от -1 миллисекунды, которое представляет неограниченное время ожидания. 
		/// -или- 
		///  Значение <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.ArgumentException">В массиве <paramref name="waitHandles" /> отсутствуют элементы.</exception>
		/// <exception cref="T:System.InvalidOperationException">Массив <paramref name="waitHandles" /> содержит прозрачный прокси для элемента <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x06002089 RID: 8329 RVA: 0x00076502 File Offset: 0x00074702
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout)
		{
			return WaitHandle.WaitAny(waitHandles, timeout, true);
		}

		/// <summary>Ожидает получения сигнала какими-либо элементами заданного массива.</summary>
		/// <param name="waitHandles">Массив <see langword="WaitHandle" />, содержащий объекты, ожидаемые текущим экземпляром.</param>
		/// <returns>Индекс объекта, удовлетворившего операцию ожидания, в массиве.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="waitHandles" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Один или несколько объектов массива <paramref name="waitHandles" /> имеют значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Массив <paramref name="waitHandles" /> содержит больше объектов, чем разрешено системой.</exception>
		/// <exception cref="T:System.ApplicationException">
		///   <paramref name="waitHandles" /> является массивом без элементов, а платформа .NET Framework имеет версию 1.0 или 1.1.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="waitHandles" /> является массивом без элементов, а платформа .NET Framework имеет версию 2.0 или выше.</exception>
		/// <exception cref="T:System.InvalidOperationException">Массив <paramref name="waitHandles" /> содержит прозрачный прокси для элемента <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x0600208A RID: 8330 RVA: 0x0007650C File Offset: 0x0007470C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static int WaitAny(WaitHandle[] waitHandles)
		{
			return WaitHandle.WaitAny(waitHandles, -1, true);
		}

		/// <summary>Ожидает получения сигнала любыми элементами указанного массива, используя 32-разрядное целое число со знаком для задания интервала времени.</summary>
		/// <param name="waitHandles">Массив <see langword="WaitHandle" />, содержащий объекты, ожидаемые текущим экземпляром.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <returns>Индекс объекта в массиве, удовлетворившего условиям ожидания, или значение <see cref="F:System.Threading.WaitHandle.WaitTimeout" />, если ни один из объектов не удовлетворил условиям ожидания и истек интервал времени, равный <paramref name="millisecondsTimeout" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="waitHandles" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Один или несколько объектов массива <paramref name="waitHandles" /> имеют значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Массив <paramref name="waitHandles" /> содержит больше объектов, чем разрешено системой.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.ArgumentException">В массиве <paramref name="waitHandles" /> отсутствуют элементы.</exception>
		/// <exception cref="T:System.InvalidOperationException">Массив <paramref name="waitHandles" /> содержит прозрачный прокси для элемента <see cref="T:System.Threading.WaitHandle" /> в другом домене приложения.</exception>
		// Token: 0x0600208B RID: 8331 RVA: 0x00076516 File Offset: 0x00074716
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout)
		{
			return WaitHandle.WaitAny(waitHandles, millisecondsTimeout, true);
		}

		/// <summary>Подает сигнал одному объекту <see cref="T:System.Threading.WaitHandle" /> и ожидает другого.</summary>
		/// <param name="toSignal">Объект <see cref="T:System.Threading.WaitHandle" />, который получает сигнал.</param>
		/// <param name="toWaitOn">Объект <see cref="T:System.Threading.WaitHandle" />, сигнализация которого ожидается.</param>
		/// <returns>Значение <see langword="true" />, если и сигнал, и ожидание завершаются удачно; если операция ожидания не завершается, то возврат из метода не происходит.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="toSignal" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="toWaitOn" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод был вызван в потоке с атрибутом <see cref="T:System.STAThreadAttribute" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Этот метод не поддерживается в Windows 98 и Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="toSignal" /> является семафором и его счетчик уже достиг максимального значения.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		// Token: 0x0600208C RID: 8332 RVA: 0x00076520 File Offset: 0x00074720
		public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn)
		{
			return WaitHandle.SignalAndWait(toSignal, toWaitOn, -1, false);
		}

		/// <summary>Передает сигнал одному объекту <see cref="T:System.Threading.WaitHandle" /> и ожидает сигнализации другого, задавая время ожидания в виде <see cref="T:System.TimeSpan" /> и указывая, следует ли выйти из домена синхронизации контекста до начала ожидания.</summary>
		/// <param name="toSignal">Объект <see cref="T:System.Threading.WaitHandle" />, который получает сигнал.</param>
		/// <param name="toWaitOn">Объект <see cref="T:System.Threading.WaitHandle" />, сигнализация которого ожидается.</param>
		/// <param name="timeout">Объект <see cref="T:System.TimeSpan" />, представляющий период ожидания. Если значение равно -1, то ожидание выполняется неограниченное время.</param>
		/// <param name="exitContext">Значение <see langword="true" /> для выхода из домена синхронизации в текущем контексте перед ожиданием (в синхронизированном контексте) с его последующим повторным получением; в противном случае — <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если и передача сигнала, и ожидание завершились успешно; значение <see langword="false" />, если передача сигнала была выполнена, но время ожидания истекло.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="toSignal" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="toWaitOn" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод был вызван в потоке с атрибутом <see cref="T:System.STAThreadAttribute" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Этот метод не поддерживается в Windows 98 и Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="toSignal" /> является семафором и его счетчик уже достиг максимального значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="timeout" /> соответствует отрицательному числу, отличному от -1 миллисекунды.  
		/// -или- 
		///  Значение <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		// Token: 0x0600208D RID: 8333 RVA: 0x0007652C File Offset: 0x0007472C
		public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, TimeSpan timeout, bool exitContext)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (-1L > num || 2147483647L < num)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			return WaitHandle.SignalAndWait(toSignal, toWaitOn, (int)num, exitContext);
		}

		/// <summary>Передает сигнал одному объекту <see cref="T:System.Threading.WaitHandle" /> и ожидает сигнализации другого, задавая время ожидания в виде 32-разрядного целого числа со знаком и указывая, следует ли выйти из домена синхронизации контекста до начала ожидания.</summary>
		/// <param name="toSignal">Объект <see cref="T:System.Threading.WaitHandle" />, который получает сигнал.</param>
		/// <param name="toWaitOn">Объект <see cref="T:System.Threading.WaitHandle" />, сигнализация которого ожидается.</param>
		/// <param name="millisecondsTimeout">Целое число, представляющее интервал ожидания. Если значение равно <see cref="F:System.Threading.Timeout.Infinite" />, то есть -1, то ожидание длится неограниченное время.</param>
		/// <param name="exitContext">Значение <see langword="true" /> для выхода из домена синхронизации в текущем контексте перед ожиданием (в синхронизированном контексте) с его последующим повторным получением; в противном случае — <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если и передача сигнала, и ожидание завершились успешно; значение <see langword="false" />, если передача сигнала была выполнена, но время ожидания истекло.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="toSignal" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="toWaitOn" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод вызывается в потоке с атрибутом <see cref="T:System.STAThreadAttribute" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Этот метод не поддерживается в Windows 98 и Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">Невозможно передать сигнал объекту <see cref="T:System.Threading.WaitHandle" />, поскольку его счетчик превысит максимальное значение.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">Ожидание закончилось, так как поток завершил работу, не освободив мьютекс. Это исключение не вызывается в ОС Windows 98 или Windows Millennium Edition.</exception>
		// Token: 0x0600208E RID: 8334 RVA: 0x00076570 File Offset: 0x00074770
		[SecuritySafeCritical]
		public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, int millisecondsTimeout, bool exitContext)
		{
			if (toSignal == null)
			{
				throw new ArgumentNullException("toSignal");
			}
			if (toWaitOn == null)
			{
				throw new ArgumentNullException("toWaitOn");
			}
			if (-1 > millisecondsTimeout)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			int num = WaitHandle.SignalAndWaitOne(toSignal.safeWaitHandle, toWaitOn.safeWaitHandle, millisecondsTimeout, toWaitOn.hasThreadAffinity, exitContext);
			if (2147483647 != num && toSignal.hasThreadAffinity)
			{
				Thread.EndCriticalRegion();
				Thread.EndThreadAffinity();
			}
			if (128 == num)
			{
				WaitHandle.ThrowAbandonedMutexException();
			}
			if (298 == num)
			{
				throw new InvalidOperationException(Environment.GetResourceString("The WaitHandle cannot be signaled because it would exceed its maximum count."));
			}
			if (299 == num)
			{
				throw new ApplicationException("Attempt to release mutex not owned by caller");
			}
			return num == 0;
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00076628 File Offset: 0x00074828
		private static void ThrowAbandonedMutexException()
		{
			throw new AbandonedMutexException();
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x0007662F File Offset: 0x0007482F
		private static void ThrowAbandonedMutexException(int location, WaitHandle handle)
		{
			throw new AbandonedMutexException(location, handle);
		}

		/// <summary>Освобождает все ресурсы, удерживаемые текущим объектом <see cref="T:System.Threading.WaitHandle" />.</summary>
		// Token: 0x06002091 RID: 8337 RVA: 0x00076638 File Offset: 0x00074838
		public virtual void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>При переопределении в производном классе освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Threading.WaitHandle" />, и при необходимости освобождает управляемые ресурсы.</summary>
		/// <param name="explicitDisposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002092 RID: 8338 RVA: 0x00076647 File Offset: 0x00074847
		[SecuritySafeCritical]
		protected virtual void Dispose(bool explicitDisposing)
		{
			if (this.safeWaitHandle != null)
			{
				this.safeWaitHandle.Close();
			}
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Threading.WaitHandle" />.</summary>
		// Token: 0x06002093 RID: 8339 RVA: 0x00076638 File Offset: 0x00074838
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00076660 File Offset: 0x00074860
		private unsafe static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			bool flag = false;
			SynchronizationContext synchronizationContext = SynchronizationContext.Current;
			int result;
			try
			{
				waitableSafeHandle.DangerousAddRef(ref flag);
				if (exitContext)
				{
					SynchronizationAttribute.ExitContext();
				}
				if (synchronizationContext != null && synchronizationContext.IsWaitNotificationRequired())
				{
					result = synchronizationContext.Wait(new IntPtr[]
					{
						waitableSafeHandle.DangerousGetHandle()
					}, false, (int)millisecondsTimeout);
				}
				else
				{
					IntPtr intPtr = waitableSafeHandle.DangerousGetHandle();
					result = WaitHandle.Wait_internal(&intPtr, 1, false, (int)millisecondsTimeout);
				}
			}
			finally
			{
				if (flag)
				{
					waitableSafeHandle.DangerousRelease();
				}
				if (exitContext)
				{
					SynchronizationAttribute.EnterContext();
				}
			}
			return result;
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x000766E4 File Offset: 0x000748E4
		private unsafe static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll)
		{
			if (waitHandles.Length > 64)
			{
				return int.MaxValue;
			}
			int num = -1;
			SynchronizationContext synchronizationContext = SynchronizationContext.Current;
			int result;
			try
			{
				if (exitContext)
				{
					SynchronizationAttribute.ExitContext();
				}
				for (int i = 0; i < waitHandles.Length; i++)
				{
					try
					{
					}
					finally
					{
						bool flag = false;
						waitHandles[i].SafeWaitHandle.DangerousAddRef(ref flag);
						num = i;
					}
				}
				if (synchronizationContext != null && synchronizationContext.IsWaitNotificationRequired())
				{
					IntPtr[] array = new IntPtr[waitHandles.Length];
					for (int j = 0; j < waitHandles.Length; j++)
					{
						array[j] = waitHandles[j].SafeWaitHandle.DangerousGetHandle();
					}
					result = synchronizationContext.Wait(array, false, millisecondsTimeout);
				}
				else
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)waitHandles.Length) * (UIntPtr)sizeof(IntPtr))];
					for (int k = 0; k < waitHandles.Length; k++)
					{
						ptr[k] = waitHandles[k].SafeWaitHandle.DangerousGetHandle();
					}
					result = WaitHandle.Wait_internal(ptr, waitHandles.Length, WaitAll, millisecondsTimeout);
				}
			}
			finally
			{
				for (int l = num; l >= 0; l--)
				{
					waitHandles[l].SafeWaitHandle.DangerousRelease();
				}
				if (exitContext)
				{
					SynchronizationAttribute.EnterContext();
				}
			}
			return result;
		}

		// Token: 0x06002096 RID: 8342
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms);

		// Token: 0x06002097 RID: 8343 RVA: 0x00076810 File Offset: 0x00074A10
		private static int SignalAndWaitOne(SafeWaitHandle waitHandleToSignal, SafeWaitHandle waitHandleToWaitOn, int millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			bool flag = false;
			bool flag2 = false;
			int result;
			try
			{
				waitHandleToSignal.DangerousAddRef(ref flag);
				waitHandleToWaitOn.DangerousAddRef(ref flag2);
				result = WaitHandle.SignalAndWait_Internal(waitHandleToSignal.DangerousGetHandle(), waitHandleToWaitOn.DangerousGetHandle(), millisecondsTimeout);
			}
			finally
			{
				if (flag)
				{
					waitHandleToSignal.DangerousRelease();
				}
				if (flag2)
				{
					waitHandleToWaitOn.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06002098 RID: 8344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int SignalAndWait_Internal(IntPtr toSignal, IntPtr toWaitOn, int ms);

		// Token: 0x06002099 RID: 8345 RVA: 0x0007686C File Offset: 0x00074A6C
		internal static int ToTimeoutMilliseconds(TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", "Number must be either non-negative and less than or equal to Int32.MaxValue or -1.");
			}
			return (int)num;
		}

		/// <summary>Указывает, что время ожидания операции <see cref="M:System.Threading.WaitHandle.WaitAny(System.Threading.WaitHandle[],System.Int32,System.Boolean)" /> истекло до получения сигнала каким-либо из дескрипторов ожидания. Это поле является константой.</summary>
		// Token: 0x04001B5A RID: 7002
		public const int WaitTimeout = 258;

		// Token: 0x04001B5B RID: 7003
		private const int MAX_WAITHANDLES = 64;

		// Token: 0x04001B5C RID: 7004
		private IntPtr waitHandle;

		// Token: 0x04001B5D RID: 7005
		[SecurityCritical]
		internal volatile SafeWaitHandle safeWaitHandle;

		// Token: 0x04001B5E RID: 7006
		internal bool hasThreadAffinity;

		// Token: 0x04001B5F RID: 7007
		private const int WAIT_OBJECT_0 = 0;

		// Token: 0x04001B60 RID: 7008
		private const int WAIT_ABANDONED = 128;

		// Token: 0x04001B61 RID: 7009
		private const int WAIT_FAILED = 2147483647;

		// Token: 0x04001B62 RID: 7010
		private const int ERROR_TOO_MANY_POSTS = 298;

		// Token: 0x04001B63 RID: 7011
		private const int ERROR_NOT_OWNED_BY_CALLER = 299;

		/// <summary>Представляет недопустимый собственный дескриптор операционной системы. Это поле доступно только для чтения.</summary>
		// Token: 0x04001B64 RID: 7012
		protected static readonly IntPtr InvalidHandle = (IntPtr)(-1);

		// Token: 0x04001B65 RID: 7013
		internal const int MaxWaitHandles = 64;

		// Token: 0x020002EB RID: 747
		internal enum OpenExistingResult
		{
			// Token: 0x04001B67 RID: 7015
			Success,
			// Token: 0x04001B68 RID: 7016
			NameNotFound,
			// Token: 0x04001B69 RID: 7017
			PathNotFound,
			// Token: 0x04001B6A RID: 7018
			NameInvalid
		}
	}
}
