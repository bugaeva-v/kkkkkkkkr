using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Security;

namespace System.Threading
{
	/// <summary>Предоставляет механизм для синхронизации доступа к объектам.</summary>
	// Token: 0x020002CF RID: 719
	public static class Monitor
	{
		/// <summary>Получает эксклюзивную блокировку указанного объекта.</summary>
		/// <param name="obj">Объект, для которого получается блокировка монитора.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		// Token: 0x06001F26 RID: 7974
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Enter(object obj);

		/// <summary>Получает монопольную блокировку указанного объекта и единым блоком задает значение, указывающее, была ли выполнена блокировка.</summary>
		/// <param name="obj">Ожидаемый объект.</param>
		/// <param name="lockTaken">Результат попытки получить блокировку, переданную по ссылке. Входное значение должно равняться <see langword="false" />. Выходное значение <see langword="true" />, если блокировка получена; в противном случае — выходное значение <see langword="false" />. Выходное значение задается, даже если при попытке получить блокировку возникает исключение.  
		/// Примечание. Если исключение не возникает, выходное значение этого метода всегда равно <see langword="true" />.</param>
		/// <exception cref="T:System.ArgumentException">Входное значение параметра <paramref name="lockTaken" /> — <see langword="true" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		// Token: 0x06001F27 RID: 7975 RVA: 0x00073769 File Offset: 0x00071969
		public static void Enter(object obj, ref bool lockTaken)
		{
			if (lockTaken)
			{
				Monitor.ThrowLockTakenException();
			}
			Monitor.ReliableEnter(obj, ref lockTaken);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x0007377B File Offset: 0x0007197B
		private static void ThrowLockTakenException()
		{
			throw new ArgumentException(Environment.GetResourceString("Argument must be initialized to false"), "lockTaken");
		}

		/// <summary>Освобождает эксклюзивную блокировку указанного объекта.</summary>
		/// <param name="obj">Объект, блокировка которого освобождается.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">Данный поток не владеет блокировкой для указанного объекта.</exception>
		// Token: 0x06001F29 RID: 7977
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Exit(object obj);

		/// <summary>Пытается получить эксклюзивную блокировку указанного объекта.</summary>
		/// <param name="obj">Объект, блокировка которого получается.</param>
		/// <returns>Значение <see langword="true" />, если текущий поток получает блокировку; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		// Token: 0x06001F2A RID: 7978 RVA: 0x00073794 File Offset: 0x00071994
		public static bool TryEnter(object obj)
		{
			bool result = false;
			Monitor.TryEnter(obj, 0, ref result);
			return result;
		}

		/// <summary>Пытается получить монопольную блокировку указанного объекта и единым блоком задает значение, указывающее, была ли выполнена блокировка.</summary>
		/// <param name="obj">Объект, блокировка которого получается.</param>
		/// <param name="lockTaken">Результат попытки получить блокировку, переданную по ссылке. Входное значение должно равняться <see langword="false" />. Выходное значение <see langword="true" />, если блокировка получена; в противном случае — выходное значение <see langword="false" />. Выходное значение задается, даже если при попытке получить блокировку возникает исключение.</param>
		/// <exception cref="T:System.ArgumentException">Входное значение параметра <paramref name="lockTaken" /> — <see langword="true" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		// Token: 0x06001F2B RID: 7979 RVA: 0x000737AD File Offset: 0x000719AD
		public static void TryEnter(object obj, ref bool lockTaken)
		{
			if (lockTaken)
			{
				Monitor.ThrowLockTakenException();
			}
			Monitor.ReliableEnterTimeout(obj, 0, ref lockTaken);
		}

		/// <summary>Пытается получить эксклюзивную блокировку указанного объекта на заданное количество миллисекунд.</summary>
		/// <param name="obj">Объект, блокировка которого получается.</param>
		/// <param name="millisecondsTimeout">Количество миллисекунд, в течение которых ожидать блокировку.</param>
		/// <returns>Значение <see langword="true" />, если текущий поток получает блокировку; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="millisecondsTimeout" /> отрицательно и не равно <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x06001F2C RID: 7980 RVA: 0x000737C0 File Offset: 0x000719C0
		public static bool TryEnter(object obj, int millisecondsTimeout)
		{
			bool result = false;
			Monitor.TryEnter(obj, millisecondsTimeout, ref result);
			return result;
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x000737DC File Offset: 0x000719DC
		private static int MillisecondsTimeoutFromTimeSpan(TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			return (int)num;
		}

		/// <summary>Пытается получить эксклюзивную блокировку указанного объекта в течение заданного количества времени.</summary>
		/// <param name="obj">Объект, блокировка которого получается.</param>
		/// <param name="timeout">Класс <see cref="T:System.TimeSpan" />, представляющий количество времени, в течение которого ожидается блокировка. Значение –1 миллисекунды обозначает бесконечное ожидание.</param>
		/// <returns>Значение <see langword="true" />, если текущий поток получает блокировку; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="timeout" /> в миллисекундах отрицательно и не равно <see cref="F:System.Threading.Timeout.Infinite" /> (–1 миллисекунда) или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001F2E RID: 7982 RVA: 0x00073817 File Offset: 0x00071A17
		public static bool TryEnter(object obj, TimeSpan timeout)
		{
			return Monitor.TryEnter(obj, Monitor.MillisecondsTimeoutFromTimeSpan(timeout));
		}

		/// <summary>В течение заданного количества миллисекунд пытается получить монопольную блокировку указанного объекта и единым блоком задает значение, указывающее, была ли выполнена блокировка.</summary>
		/// <param name="obj">Объект, блокировка которого получается.</param>
		/// <param name="millisecondsTimeout">Количество миллисекунд, в течение которых ожидать блокировку.</param>
		/// <param name="lockTaken">Результат попытки получить блокировку, переданную по ссылке. Входное значение должно равняться <see langword="false" />. Выходное значение <see langword="true" />, если блокировка получена; в противном случае — выходное значение <see langword="false" />. Выходное значение задается, даже если при попытке получить блокировку возникает исключение.</param>
		/// <exception cref="T:System.ArgumentException">Входное значение параметра <paramref name="lockTaken" /> — <see langword="true" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="millisecondsTimeout" /> отрицательно и не равно <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x06001F2F RID: 7983 RVA: 0x00073825 File Offset: 0x00071A25
		public static void TryEnter(object obj, int millisecondsTimeout, ref bool lockTaken)
		{
			if (lockTaken)
			{
				Monitor.ThrowLockTakenException();
			}
			Monitor.ReliableEnterTimeout(obj, millisecondsTimeout, ref lockTaken);
		}

		/// <summary>В течение заданного периода времени пытается получить монопольную блокировку указанного объекта и единым блоком задает значение, указывающее, была ли выполнена блокировка.</summary>
		/// <param name="obj">Объект, блокировка которого получается.</param>
		/// <param name="timeout">Период времени, в течение которого ожидается блокировка. Значение –1 миллисекунды обозначает бесконечное ожидание.</param>
		/// <param name="lockTaken">Результат попытки получить блокировку, переданную по ссылке. Входное значение должно равняться <see langword="false" />. Выходное значение <see langword="true" />, если блокировка получена; в противном случае — выходное значение <see langword="false" />. Выходное значение задается, даже если при попытке получить блокировку возникает исключение.</param>
		/// <exception cref="T:System.ArgumentException">Входное значение параметра <paramref name="lockTaken" /> — <see langword="true" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="timeout" /> в миллисекундах отрицательно и не равно <see cref="F:System.Threading.Timeout.Infinite" /> (–1 миллисекунда) или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001F30 RID: 7984 RVA: 0x00073838 File Offset: 0x00071A38
		public static void TryEnter(object obj, TimeSpan timeout, ref bool lockTaken)
		{
			if (lockTaken)
			{
				Monitor.ThrowLockTakenException();
			}
			Monitor.ReliableEnterTimeout(obj, Monitor.MillisecondsTimeoutFromTimeSpan(timeout), ref lockTaken);
		}

		/// <summary>Определяет, является ли содержит ли текущий поток блокировку на заданном объекте.</summary>
		/// <param name="obj">Объект для тестирования.</param>
		/// <returns>Значение <see langword="true" />, если текущий поток владеет блокировкой в <paramref name="obj" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="obj" /> — <see langword="null" />.</exception>
		// Token: 0x06001F31 RID: 7985 RVA: 0x00073850 File Offset: 0x00071A50
		[SecuritySafeCritical]
		public static bool IsEntered(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			return Monitor.IsEnteredNative(obj);
		}

		/// <summary>Освобождает блокировку объекта и блокирует текущий поток до тех пор, пока тот не получит блокировку снова. Если указанные временные интервалы истекают, поток встает в очередь готовности. Этот метод также указывает на наличие завершения области синхронизации для контекста (если в синхронизированном контексте) до получения впоследствии нового состояния ожидания.</summary>
		/// <param name="obj">Ожидаемый объект.</param>
		/// <param name="millisecondsTimeout">Количество миллисекунд для ожидания постановки в очередь готовности.</param>
		/// <param name="exitContext">Значение <see langword="true" /> для выхода и получения заново области синхронизации для контекста (если в синхронизированном контексте) до ожидания; в противном случае — <see langword="false" />.</param>
		/// <returns>
		///   <see langword="true" /> если блокировка не была получена до истечения заданного времени; <see langword="false" /> если блокировка была получена по истечении заданного времени. Этот метод не осуществляет возврат, если блокировка не была получена.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">Метод <see langword="Wait" /> должен быть вызван из синхронизированного блока кода.</exception>
		/// <exception cref="T:System.Threading.ThreadInterruptedException">Поток, который вызывает <see langword="Wait" />, позже прерывается из состояния ожидания. Это происходит, когда другой поток вызывает метод <see cref="M:System.Threading.Thread.Interrupt" /> данного потока.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="millisecondsTimeout" /> отрицательно и не равно <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x06001F32 RID: 7986 RVA: 0x00073866 File Offset: 0x00071A66
		[SecuritySafeCritical]
		public static bool Wait(object obj, int millisecondsTimeout, bool exitContext)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			return Monitor.ObjWait(exitContext, millisecondsTimeout, obj);
		}

		/// <summary>Освобождает блокировку объекта и блокирует текущий поток до тех пор, пока тот не получит блокировку снова. Если указанные временные интервалы истекают, поток встает в очередь готовности. Необязательно выходит из синхронизированного домена для синхронизации контекста до ожидания и получает домен впоследствии.</summary>
		/// <param name="obj">Ожидаемый объект.</param>
		/// <param name="timeout">Класс <see cref="T:System.TimeSpan" />, представляющий количество времени, до истечения которого поток поступает в очередь ожидания.</param>
		/// <param name="exitContext">Значение <see langword="true" /> для выхода и получения заново области синхронизации для контекста (если в синхронизированном контексте) до ожидания; в противном случае — <see langword="false" />.</param>
		/// <returns>
		///   <see langword="true" /> если блокировка не была получена до истечения заданного времени; <see langword="false" /> если блокировка была получена по истечении заданного времени. Этот метод не осуществляет возврат, если блокировка не была получена.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">
		///   <see langword="Wait" /> — не вызывается из синхронизированного блока кода.</exception>
		/// <exception cref="T:System.Threading.ThreadInterruptedException">Для потока, который вызывает Wait, состояние ожидания позже прерывается. Это происходит, когда другой поток вызывает метод <see cref="M:System.Threading.Thread.Interrupt" /> данного потока.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="timeout" /> в миллисекундах отрицательно и не равно <see cref="F:System.Threading.Timeout.Infinite" /> (–1 миллисекунда) или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001F33 RID: 7987 RVA: 0x0007387E File Offset: 0x00071A7E
		public static bool Wait(object obj, TimeSpan timeout, bool exitContext)
		{
			return Monitor.Wait(obj, Monitor.MillisecondsTimeoutFromTimeSpan(timeout), exitContext);
		}

		/// <summary>Освобождает блокировку объекта и блокирует текущий поток до тех пор, пока тот не получит блокировку снова. Если указанные временные интервалы истекают, поток встает в очередь готовности.</summary>
		/// <param name="obj">Ожидаемый объект.</param>
		/// <param name="millisecondsTimeout">Количество миллисекунд для ожидания постановки в очередь готовности.</param>
		/// <returns>
		///   <see langword="true" /> если блокировка не была получена до истечения заданного времени; <see langword="false" /> если блокировка была получена по истечении заданного времени. Этот метод не осуществляет возврат, если блокировка не была получена.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">Вызывающий поток не владеет блокировкой для указанного объекта.</exception>
		/// <exception cref="T:System.Threading.ThreadInterruptedException">Поток, который вызывает <see langword="Wait" />, позже прерывается из состояния ожидания. Это происходит, когда другой поток вызывает метод <see cref="M:System.Threading.Thread.Interrupt" /> данного потока.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="millisecondsTimeout" /> отрицательно и не равно <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x06001F34 RID: 7988 RVA: 0x0007388D File Offset: 0x00071A8D
		public static bool Wait(object obj, int millisecondsTimeout)
		{
			return Monitor.Wait(obj, millisecondsTimeout, false);
		}

		/// <summary>Освобождает блокировку объекта и блокирует текущий поток до тех пор, пока тот не получит блокировку снова. Если указанные временные интервалы истекают, поток встает в очередь готовности.</summary>
		/// <param name="obj">Ожидаемый объект.</param>
		/// <param name="timeout">Класс <see cref="T:System.TimeSpan" />, представляющий количество времени, до истечения которого поток поступает в очередь ожидания.</param>
		/// <returns>
		///   <see langword="true" /> если блокировка не была получена до истечения заданного времени; <see langword="false" /> если блокировка была получена по истечении заданного времени. Этот метод не осуществляет возврат, если блокировка не была получена.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">Вызывающий поток не владеет блокировкой для указанного объекта.</exception>
		/// <exception cref="T:System.Threading.ThreadInterruptedException">Поток, который вызывает <see langword="Wait" />, позже прерывается из состояния ожидания. Это происходит, когда другой поток вызывает метод <see cref="M:System.Threading.Thread.Interrupt" /> данного потока.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="timeout" /> в миллисекундах отрицательно и не равно <see cref="F:System.Threading.Timeout.Infinite" /> (–1 миллисекунда) или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001F35 RID: 7989 RVA: 0x00073897 File Offset: 0x00071A97
		public static bool Wait(object obj, TimeSpan timeout)
		{
			return Monitor.Wait(obj, Monitor.MillisecondsTimeoutFromTimeSpan(timeout), false);
		}

		/// <summary>Освобождает блокировку объекта и блокирует текущий поток до тех пор, пока тот не получит блокировку снова.</summary>
		/// <param name="obj">Ожидаемый объект.</param>
		/// <returns>Значение <see langword="true" />, если вызов осуществил возврат из-за того, что вызывающий поток заново получил блокировку заданного объекта. Этот метод не осуществляет возврат, если блокировка вновь не получена.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">Вызывающий поток не владеет блокировкой для указанного объекта.</exception>
		/// <exception cref="T:System.Threading.ThreadInterruptedException">Поток, который вызывает <see langword="Wait" />, позже прерывается из состояния ожидания. Это происходит, когда другой поток вызывает метод <see cref="M:System.Threading.Thread.Interrupt" /> данного потока.</exception>
		// Token: 0x06001F36 RID: 7990 RVA: 0x000738A6 File Offset: 0x00071AA6
		public static bool Wait(object obj)
		{
			return Monitor.Wait(obj, -1, false);
		}

		/// <summary>Уведомляет поток в очереди готовности об изменении состояния объекта с блокировкой.</summary>
		/// <param name="obj">Объект, которого ожидает поток.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">Вызывающий поток не владеет блокировкой для указанного объекта.</exception>
		// Token: 0x06001F37 RID: 7991 RVA: 0x000738B0 File Offset: 0x00071AB0
		[SecuritySafeCritical]
		public static void Pulse(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			Monitor.ObjPulse(obj);
		}

		/// <summary>Уведомляет все ожидающие потоки об изменении состояния объекта.</summary>
		/// <param name="obj">Объект, посылающий импульс.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="obj" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">Вызывающий поток не владеет блокировкой для указанного объекта.</exception>
		// Token: 0x06001F38 RID: 7992 RVA: 0x000738C6 File Offset: 0x00071AC6
		[SecuritySafeCritical]
		public static void PulseAll(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			Monitor.ObjPulseAll(obj);
		}

		// Token: 0x06001F39 RID: 7993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Monitor_test_synchronised(object obj);

		// Token: 0x06001F3A RID: 7994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Monitor_pulse(object obj);

		// Token: 0x06001F3B RID: 7995 RVA: 0x000738DC File Offset: 0x00071ADC
		private static void ObjPulse(object obj)
		{
			if (!Monitor.Monitor_test_synchronised(obj))
			{
				throw new SynchronizationLockException("Object is not synchronized");
			}
			Monitor.Monitor_pulse(obj);
		}

		// Token: 0x06001F3C RID: 7996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Monitor_pulse_all(object obj);

		// Token: 0x06001F3D RID: 7997 RVA: 0x000738F7 File Offset: 0x00071AF7
		private static void ObjPulseAll(object obj)
		{
			if (!Monitor.Monitor_test_synchronised(obj))
			{
				throw new SynchronizationLockException("Object is not synchronized");
			}
			Monitor.Monitor_pulse_all(obj);
		}

		// Token: 0x06001F3E RID: 7998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Monitor_wait(object obj, int ms);

		// Token: 0x06001F3F RID: 7999 RVA: 0x00073914 File Offset: 0x00071B14
		private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj)
		{
			if (millisecondsTimeout < 0 && millisecondsTimeout != -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout");
			}
			if (!Monitor.Monitor_test_synchronised(obj))
			{
				throw new SynchronizationLockException("Object is not synchronized");
			}
			bool result;
			try
			{
				if (exitContext)
				{
					SynchronizationAttribute.ExitContext();
				}
				result = Monitor.Monitor_wait(obj, millisecondsTimeout);
			}
			finally
			{
				if (exitContext)
				{
					SynchronizationAttribute.EnterContext();
				}
			}
			return result;
		}

		// Token: 0x06001F40 RID: 8000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken);

		// Token: 0x06001F41 RID: 8001 RVA: 0x00073974 File Offset: 0x00071B74
		private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (timeout < 0 && timeout != -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout");
			}
			Monitor.try_enter_with_atomic_var(obj, timeout, ref lockTaken);
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x0007399F File Offset: 0x00071B9F
		private static void ReliableEnter(object obj, ref bool lockTaken)
		{
			Monitor.ReliableEnterTimeout(obj, -1, ref lockTaken);
		}

		// Token: 0x06001F43 RID: 8003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Monitor_test_owner(object obj);

		// Token: 0x06001F44 RID: 8004 RVA: 0x000739A9 File Offset: 0x00071BA9
		private static bool IsEnteredNative(object obj)
		{
			return Monitor.Monitor_test_owner(obj);
		}
	}
}
