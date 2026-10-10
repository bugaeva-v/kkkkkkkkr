using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Threading
{
	/// <summary>Предоставляет пул потоков, который можно использовать для выполнения задач, отправки рабочих элементов, обработки асинхронного ввода-вывода, ожидания от имени других потоков и обработки таймеров.</summary>
	// Token: 0x020002E6 RID: 742
	public static class ThreadPool
	{
		/// <summary>Задает количество запросов к пулу потоков, которые могут быть активными одновременно. Все запросы, превышающие это количество, остаются в очереди до тех пор, пока потоки пула не станут доступны.</summary>
		/// <param name="workerThreads">Максимальное количество рабочих потоков в пуле потоков.</param>
		/// <param name="completionPortThreads">Максимальное количество потоков асинхронного ввода-вывода в пуле потоков.</param>
		/// <returns>Значение <see langword="true" />, если изменение выполнено успешно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002035 RID: 8245 RVA: 0x000757AC File Offset: 0x000739AC
		[SecuritySafeCritical]
		public static bool SetMaxThreads(int workerThreads, int completionPortThreads)
		{
			return ThreadPool.SetMaxThreadsNative(workerThreads, completionPortThreads);
		}

		/// <summary>Возвращает количество запросов к пулу потоков, которые могут быть активными одновременно. Все запросы, превышающие это количество, остаются в очереди до тех пор, пока потоки пула не станут доступны.</summary>
		/// <param name="workerThreads">Максимальное количество рабочих потоков в пуле потоков.</param>
		/// <param name="completionPortThreads">Максимальное количество потоков асинхронного ввода-вывода в пуле потоков.</param>
		// Token: 0x06002036 RID: 8246 RVA: 0x000757B5 File Offset: 0x000739B5
		[SecuritySafeCritical]
		public static void GetMaxThreads(out int workerThreads, out int completionPortThreads)
		{
			ThreadPool.GetMaxThreadsNative(out workerThreads, out completionPortThreads);
		}

		/// <summary>Задает минимальное число потоков, создаваемых пулом потоков по требованию по мере поступления новых запросов перед переходом на алгоритм управления созданием и уничтожением потоков.</summary>
		/// <param name="workerThreads">Минимальное количество рабочих потоков, которые создаются пулом потоков по требованию.</param>
		/// <param name="completionPortThreads">Минимальное количество потоков асинхронного ввода-вывода, которые создаются пулом потоков по требованию.</param>
		/// <returns>Значение <see langword="true" />, если изменение выполнено успешно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002037 RID: 8247 RVA: 0x000757BE File Offset: 0x000739BE
		[SecuritySafeCritical]
		public static bool SetMinThreads(int workerThreads, int completionPortThreads)
		{
			return ThreadPool.SetMinThreadsNative(workerThreads, completionPortThreads);
		}

		/// <summary>Возвращает минимальное число потоков, создаваемых пулом потоков по требованию по мере поступления новых запросов перед переходом на алгоритм управления созданием и уничтожением потоков.</summary>
		/// <param name="workerThreads">При возвращении метода содержит минимальное количество рабочих потоков, которые создаются пулом потоков по требованию.</param>
		/// <param name="completionPortThreads">При возвращении метода содержит минимальное количество потоков асинхронного ввода-вывода, которые создаются пулом потоков по требованию.</param>
		// Token: 0x06002038 RID: 8248 RVA: 0x000757C7 File Offset: 0x000739C7
		[SecuritySafeCritical]
		public static void GetMinThreads(out int workerThreads, out int completionPortThreads)
		{
			ThreadPool.GetMinThreadsNative(out workerThreads, out completionPortThreads);
		}

		/// <summary>Возвращает разницу между максимальным числом потоков пула, возвращаемых методом <see cref="M:System.Threading.ThreadPool.GetMaxThreads(System.Int32@,System.Int32@)" />, и числом активных в данный момент потоков.</summary>
		/// <param name="workerThreads">Количество доступных рабочих потоков.</param>
		/// <param name="completionPortThreads">Количество доступных потоков асинхронного ввода-вывода.</param>
		// Token: 0x06002039 RID: 8249 RVA: 0x000757D0 File Offset: 0x000739D0
		[SecuritySafeCritical]
		public static void GetAvailableThreads(out int workerThreads, out int completionPortThreads)
		{
			ThreadPool.GetAvailableThreadsNative(out workerThreads, out completionPortThreads);
		}

		/// <summary>Регистрирует делегат для ожидания объекта <see cref="T:System.Threading.WaitHandle" />, задавая время ожидания в миллисекундах в виде 32-разрядного целого числа без знака.</summary>
		/// <param name="waitObject">Регистрируемый объект <see cref="T:System.Threading.WaitHandle" />. Используйте объект <see cref="T:System.Threading.WaitHandle" />, отличный от <see cref="T:System.Threading.Mutex" />.</param>
		/// <param name="callBack">Делегат <see cref="T:System.Threading.WaitOrTimerCallback" />, который вызывается при получении сигнала объектом, указанным в параметре <paramref name="waitObject" />.</param>
		/// <param name="state">Передаваемый делегату объект.</param>
		/// <param name="millisecondsTimeOutInterval">Время ожидания в миллисекундах. Если параметр <paramref name="millisecondsTimeOutInterval" /> равен 0 (нулю), функция проверяет состояние объекта и немедленно возвращает значение. Если параметр <paramref name="millisecondsTimeOutInterval" /> равен -1, время ожидания функции никогда не истекает.</param>
		/// <param name="executeOnlyOnce">Значение <see langword="true" /> указывает, что после вызова делегата поток не будет ожидать параметр <paramref name="waitObject" />; значение <see langword="false" /> указывает, что таймер сбрасывается всякий раз по завершении операции ожидания до тех пор, пока регистрация ожидания не будет отменена.</param>
		/// <returns>Объект <see cref="T:System.Threading.RegisteredWaitHandle" />, который можно использовать для отмены зарегистрированной операции ожидания.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="millisecondsTimeOutInterval" /> меньше –1.</exception>
		// Token: 0x0600203A RID: 8250 RVA: 0x000757DC File Offset: 0x000739DC
		[SecuritySafeCritical]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, ref stackCrawlMark, true);
		}

		/// <summary>Регистрирует делегат для ожидания объекта <see cref="T:System.Threading.WaitHandle" />, задавая время ожидания в миллисекундах в виде 32-разрядного целого числа без знака. Этот метод не распространяет вызывающий стек на рабочий поток.</summary>
		/// <param name="waitObject">Регистрируемый объект <see cref="T:System.Threading.WaitHandle" />. Используйте объект <see cref="T:System.Threading.WaitHandle" />, отличный от <see cref="T:System.Threading.Mutex" />.</param>
		/// <param name="callBack">Делегат, который вызывается при получении сигнала объектом, указанным в параметре <paramref name="waitObject" />.</param>
		/// <param name="state">Передаваемый делегату объект.</param>
		/// <param name="millisecondsTimeOutInterval">Время ожидания в миллисекундах. Если параметр <paramref name="millisecondsTimeOutInterval" /> равен 0 (нулю), функция проверяет состояние объекта и немедленно возвращает значение. Если параметр <paramref name="millisecondsTimeOutInterval" /> равен -1, время ожидания функции никогда не истекает.</param>
		/// <param name="executeOnlyOnce">Значение <see langword="true" /> указывает, что после вызова делегата поток не будет ожидать параметр <paramref name="waitObject" />; значение <see langword="false" /> указывает, что таймер сбрасывается всякий раз по завершении операции ожидания до тех пор, пока регистрация ожидания не будет отменена.</param>
		/// <returns>Объект <see cref="T:System.Threading.RegisteredWaitHandle" />, который можно использовать для отмены зарегистрированной операции ожидания.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600203B RID: 8251 RVA: 0x000757FC File Offset: 0x000739FC
		[SecurityCritical]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, millisecondsTimeOutInterval, executeOnlyOnce, ref stackCrawlMark, false);
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0007581C File Offset: 0x00073A1C
		[SecurityCritical]
		private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack)
		{
			if (waitObject == null)
			{
				throw new ArgumentNullException("waitObject");
			}
			if (callBack == null)
			{
				throw new ArgumentNullException("callBack");
			}
			if (millisecondsTimeOutInterval != 4294967295U && millisecondsTimeOutInterval > 2147483647U)
			{
				throw new NotSupportedException("Timeout is too big. Maximum is Int32.MaxValue");
			}
			RegisteredWaitHandle registeredWaitHandle = new RegisteredWaitHandle(waitObject, callBack, state, new TimeSpan(0, 0, 0, 0, (int)millisecondsTimeOutInterval), executeOnlyOnce);
			if (compressStack)
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(registeredWaitHandle.Wait), null);
			}
			else
			{
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(registeredWaitHandle.Wait), null);
			}
			return registeredWaitHandle;
		}

		/// <summary>Регистрирует делегат для ожидания объекта <see cref="T:System.Threading.WaitHandle" />, задавая время ожидания в миллисекундах в виде 32-разрядного целого числа со знаком.</summary>
		/// <param name="waitObject">Регистрируемый объект <see cref="T:System.Threading.WaitHandle" />. Используйте объект <see cref="T:System.Threading.WaitHandle" />, отличный от <see cref="T:System.Threading.Mutex" />.</param>
		/// <param name="callBack">Делегат <see cref="T:System.Threading.WaitOrTimerCallback" />, который вызывается при получении сигнала объектом, указанным в параметре <paramref name="waitObject" />.</param>
		/// <param name="state">Передаваемый делегату объект.</param>
		/// <param name="millisecondsTimeOutInterval">Время ожидания в миллисекундах. Если параметр <paramref name="millisecondsTimeOutInterval" /> равен 0 (нулю), функция проверяет состояние объекта и немедленно возвращает значение. Если параметр <paramref name="millisecondsTimeOutInterval" /> равен -1, время ожидания функции никогда не истекает.</param>
		/// <param name="executeOnlyOnce">Значение <see langword="true" /> указывает, что после вызова делегата поток не будет ожидать параметр <paramref name="waitObject" />; значение <see langword="false" /> указывает, что таймер сбрасывается всякий раз по завершении операции ожидания до тех пор, пока регистрация ожидания не будет отменена.</param>
		/// <returns>Объект <see cref="T:System.Threading.RegisteredWaitHandle" />, инкапсулирующий собственный дескриптор.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="millisecondsTimeOutInterval" /> меньше –1.</exception>
		// Token: 0x0600203D RID: 8253 RVA: 0x000758A0 File Offset: 0x00073AA0
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			if (millisecondsTimeOutInterval < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)((millisecondsTimeOutInterval == -1) ? -1 : millisecondsTimeOutInterval), executeOnlyOnce, ref stackCrawlMark, true);
		}

		/// <summary>Регистрирует делегат для ожидания объекта <see cref="T:System.Threading.WaitHandle" />, задавая время ожидания в миллисекундах в виде 32-разрядного целого числа со знаком. Этот метод не распространяет вызывающий стек на рабочий поток.</summary>
		/// <param name="waitObject">Регистрируемый объект <see cref="T:System.Threading.WaitHandle" />. Используйте объект <see cref="T:System.Threading.WaitHandle" />, отличный от <see cref="T:System.Threading.Mutex" />.</param>
		/// <param name="callBack">Делегат, который вызывается при получении сигнала объектом, указанным в параметре <paramref name="waitObject" />.</param>
		/// <param name="state">Передаваемый делегату объект.</param>
		/// <param name="millisecondsTimeOutInterval">Время ожидания в миллисекундах. Если параметр <paramref name="millisecondsTimeOutInterval" /> равен 0 (нулю), функция проверяет состояние объекта и немедленно возвращает значение. Если параметр <paramref name="millisecondsTimeOutInterval" /> равен -1, время ожидания функции никогда не истекает.</param>
		/// <param name="executeOnlyOnce">Значение <see langword="true" /> указывает, что после вызова делегата поток не будет ожидать параметр <paramref name="waitObject" />; значение <see langword="false" /> указывает, что таймер сбрасывается всякий раз по завершении операции ожидания до тех пор, пока регистрация ожидания не будет отменена.</param>
		/// <returns>Объект <see cref="T:System.Threading.RegisteredWaitHandle" />, который можно использовать для отмены зарегистрированной операции ожидания.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="millisecondsTimeOutInterval" /> меньше –1.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600203E RID: 8254 RVA: 0x000758E0 File Offset: 0x00073AE0
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			if (millisecondsTimeOutInterval < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)((millisecondsTimeOutInterval == -1) ? -1 : millisecondsTimeOutInterval), executeOnlyOnce, ref stackCrawlMark, false);
		}

		/// <summary>Регистрирует делегат для ожидания объекта <see cref="T:System.Threading.WaitHandle" />, задавая время ожидания в миллисекундах в виде 64-разрядного целого числа со знаком.</summary>
		/// <param name="waitObject">Регистрируемый объект <see cref="T:System.Threading.WaitHandle" />. Используйте объект <see cref="T:System.Threading.WaitHandle" />, отличный от <see cref="T:System.Threading.Mutex" />.</param>
		/// <param name="callBack">Делегат <see cref="T:System.Threading.WaitOrTimerCallback" />, который вызывается при получении сигнала объектом, указанным в параметре <paramref name="waitObject" />.</param>
		/// <param name="state">Передаваемый делегату объект.</param>
		/// <param name="millisecondsTimeOutInterval">Время ожидания в миллисекундах. Если параметр <paramref name="millisecondsTimeOutInterval" /> равен 0 (нулю), функция проверяет состояние объекта и немедленно возвращает значение. Если параметр <paramref name="millisecondsTimeOutInterval" /> равен -1, время ожидания функции никогда не истекает.</param>
		/// <param name="executeOnlyOnce">Значение <see langword="true" /> указывает, что после вызова делегата поток не будет ожидать параметр <paramref name="waitObject" />; значение <see langword="false" /> указывает, что таймер сбрасывается всякий раз по завершении операции ожидания до тех пор, пока регистрация ожидания не будет отменена.</param>
		/// <returns>Объект <see cref="T:System.Threading.RegisteredWaitHandle" />, инкапсулирующий собственный дескриптор.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="millisecondsTimeOutInterval" /> меньше –1.</exception>
		// Token: 0x0600203F RID: 8255 RVA: 0x00075920 File Offset: 0x00073B20
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			if (millisecondsTimeOutInterval < -1L)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (millisecondsTimeOutInterval == -1L) ? uint.MaxValue : ((uint)millisecondsTimeOutInterval), executeOnlyOnce, ref stackCrawlMark, true);
		}

		/// <summary>Регистрирует делегат для ожидания объекта <see cref="T:System.Threading.WaitHandle" />, задавая время ожидания в миллисекундах в виде 64-разрядного целого числа со знаком. Этот метод не распространяет вызывающий стек на рабочий поток.</summary>
		/// <param name="waitObject">Регистрируемый объект <see cref="T:System.Threading.WaitHandle" />. Используйте объект <see cref="T:System.Threading.WaitHandle" />, отличный от <see cref="T:System.Threading.Mutex" />.</param>
		/// <param name="callBack">Делегат, который вызывается при получении сигнала объектом, указанным в параметре <paramref name="waitObject" />.</param>
		/// <param name="state">Передаваемый делегату объект.</param>
		/// <param name="millisecondsTimeOutInterval">Время ожидания в миллисекундах. Если параметр <paramref name="millisecondsTimeOutInterval" /> равен 0 (нулю), функция проверяет состояние объекта и немедленно возвращает значение. Если параметр <paramref name="millisecondsTimeOutInterval" /> равен -1, время ожидания функции никогда не истекает.</param>
		/// <param name="executeOnlyOnce">Значение <see langword="true" /> указывает, что после вызова делегата поток не будет ожидать параметр <paramref name="waitObject" />; значение <see langword="false" /> указывает, что таймер сбрасывается всякий раз по завершении операции ожидания до тех пор, пока регистрация ожидания не будет отменена.</param>
		/// <returns>Объект <see cref="T:System.Threading.RegisteredWaitHandle" />, который можно использовать для отмены зарегистрированной операции ожидания.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="millisecondsTimeOutInterval" /> меньше –1.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06002040 RID: 8256 RVA: 0x00075960 File Offset: 0x00073B60
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			if (millisecondsTimeOutInterval < -1L)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeOutInterval", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (millisecondsTimeOutInterval == -1L) ? uint.MaxValue : ((uint)millisecondsTimeOutInterval), executeOnlyOnce, ref stackCrawlMark, false);
		}

		/// <summary>Регистрирует делегат для ожидания объекта <see cref="T:System.Threading.WaitHandle" />, задавая значение <see cref="T:System.TimeSpan" /> для времени ожидания.</summary>
		/// <param name="waitObject">Регистрируемый объект <see cref="T:System.Threading.WaitHandle" />. Используйте объект <see cref="T:System.Threading.WaitHandle" />, отличный от <see cref="T:System.Threading.Mutex" />.</param>
		/// <param name="callBack">Делегат <see cref="T:System.Threading.WaitOrTimerCallback" />, который вызывается при получении сигнала объектом, указанным в параметре <paramref name="waitObject" />.</param>
		/// <param name="state">Передаваемый делегату объект.</param>
		/// <param name="timeout">Время ожидания, представленное объектом <see cref="T:System.TimeSpan" />. Если параметр <paramref name="timeout" /> равен 0 (нулю), функция проверяет состояние объекта и немедленно возвращает значение. Если параметр <paramref name="timeout" /> равен -1, время ожидания функции никогда не истекает.</param>
		/// <param name="executeOnlyOnce">Значение <see langword="true" /> указывает, что после вызова делегата поток не будет ожидать параметр <paramref name="waitObject" />; значение <see langword="false" /> указывает, что таймер сбрасывается всякий раз по завершении операции ожидания до тех пор, пока регистрация ожидания не будет отменена.</param>
		/// <returns>Объект <see cref="T:System.Threading.RegisteredWaitHandle" />, инкапсулирующий собственный дескриптор.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="timeout" /> меньше –1.</exception>
		/// <exception cref="T:System.NotSupportedException">Значение параметра <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06002041 RID: 8257 RVA: 0x000759A0 File Offset: 0x00073BA0
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Argument must be less than or equal to 2^31 - 1 milliseconds."));
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)num, executeOnlyOnce, ref stackCrawlMark, true);
		}

		/// <summary>Регистрирует делегат для ожидания объекта <see cref="T:System.Threading.WaitHandle" />, задавая значение <see cref="T:System.TimeSpan" /> для времени ожидания. Этот метод не распространяет вызывающий стек на рабочий поток.</summary>
		/// <param name="waitObject">Регистрируемый объект <see cref="T:System.Threading.WaitHandle" />. Используйте объект <see cref="T:System.Threading.WaitHandle" />, отличный от <see cref="T:System.Threading.Mutex" />.</param>
		/// <param name="callBack">Делегат, который вызывается при получении сигнала объектом, указанным в параметре <paramref name="waitObject" />.</param>
		/// <param name="state">Передаваемый делегату объект.</param>
		/// <param name="timeout">Время ожидания, представленное объектом <see cref="T:System.TimeSpan" />. Если параметр <paramref name="timeout" /> равен 0 (нулю), функция проверяет состояние объекта и немедленно возвращает значение. Если параметр <paramref name="timeout" /> равен -1, время ожидания функции никогда не истекает.</param>
		/// <param name="executeOnlyOnce">Значение <see langword="true" /> указывает, что после вызова делегата поток не будет ожидать параметр <paramref name="waitObject" />; значение <see langword="false" /> указывает, что таймер сбрасывается всякий раз по завершении операции ожидания до тех пор, пока регистрация ожидания не будет отменена.</param>
		/// <returns>Объект <see cref="T:System.Threading.RegisteredWaitHandle" />, который можно использовать для отмены зарегистрированной операции ожидания.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="timeout" /> меньше –1.</exception>
		/// <exception cref="T:System.NotSupportedException">Значение параметра <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06002042 RID: 8258 RVA: 0x00075A00 File Offset: 0x00073C00
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Argument must be less than or equal to 2^31 - 1 milliseconds."));
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.RegisterWaitForSingleObject(waitObject, callBack, state, (uint)num, executeOnlyOnce, ref stackCrawlMark, false);
		}

		/// <summary>Помещает метод в очередь на выполнение и указывает объект, содержащий данные для использования методом. Метод выполняется, когда становится доступен поток из пула потоков.</summary>
		/// <param name="callBack">Делегат <see cref="T:System.Threading.WaitCallback" />, представляющий выполняемый метод.</param>
		/// <param name="state">Объект, содержащий данные, используемые методом.</param>
		/// <returns>Значение <see langword="true" />, если метод успешно помещен в очередь. Если рабочий элемент не может быть помещен очередь, выдается исключение <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Среда CLR является размещенной, а основное приложение не поддерживает это действие.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="callBack" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002043 RID: 8259 RVA: 0x00075A60 File Offset: 0x00073C60
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool QueueUserWorkItem(WaitCallback callBack, object state)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.QueueUserWorkItemHelper(callBack, state, ref stackCrawlMark, true, true);
		}

		/// <summary>Помещает метод в очередь на выполнение. Метод выполняется, когда становится доступен поток из пула потоков.</summary>
		/// <param name="callBack">Делегат <see cref="T:System.Threading.WaitCallback" />, представляющий метод, который требуется выполнить.</param>
		/// <returns>Значение <see langword="true" />, если метод успешно помещен в очередь. Если рабочий элемент не может быть помещен очередь, выдается исключение <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="callBack" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Среда CLR является размещенной, а основное приложение не поддерживает это действие.</exception>
		// Token: 0x06002044 RID: 8260 RVA: 0x00075A7C File Offset: 0x00073C7C
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool QueueUserWorkItem(WaitCallback callBack)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.QueueUserWorkItemHelper(callBack, null, ref stackCrawlMark, true, true);
		}

		/// <summary>Помещает указанный делегат в очередь пула потоков, но не распространяет вызывающий стек на рабочий поток.</summary>
		/// <param name="callBack">Метод <see cref="T:System.Threading.WaitCallback" />, представляющий делегат, который вызывается, когда потоку в пуле потоков назначается рабочий элемент.</param>
		/// <param name="state">Объект, передаваемый делегату при вызове его из пула потоков.</param>
		/// <returns>Значение <see langword="true" />, если метод завершается успешно. Если рабочий элемент не удалось поместить в очередь, создается исключение <see cref="T:System.OutOfMemoryException" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ApplicationException">Возникла ситуация нехватки памяти.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не удается поместить в очередь рабочий элемент.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="callBack" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002045 RID: 8261 RVA: 0x00075A98 File Offset: 0x00073C98
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.QueueUserWorkItemHelper(callBack, state, ref stackCrawlMark, false, true);
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00075AB4 File Offset: 0x00073CB4
		public static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal)
		{
			if (callBack == null)
			{
				throw new ArgumentNullException("callBack");
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.QueueUserWorkItemHelper(delegate(object x)
			{
				callBack((TState)((object)x));
			}, state, ref stackCrawlMark, true, !preferLocal);
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00075B00 File Offset: 0x00073D00
		public static bool UnsafeQueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal)
		{
			if (callBack == null)
			{
				throw new ArgumentNullException("callBack");
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return ThreadPool.QueueUserWorkItemHelper(delegate(object x)
			{
				callBack((TState)((object)x));
			}, state, ref stackCrawlMark, false, !preferLocal);
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00075B4C File Offset: 0x00073D4C
		[SecurityCritical]
		private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true)
		{
			bool result = true;
			if (callBack != null)
			{
				ThreadPool.EnsureVMInitialized();
				try
				{
					return result;
				}
				finally
				{
					QueueUserWorkItemCallback callback = new QueueUserWorkItemCallback(callBack, state, compressStack, ref stackMark);
					ThreadPoolGlobals.workQueue.Enqueue(callback, forceGlobal);
					result = true;
				}
			}
			throw new ArgumentNullException("WaitCallback");
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00075B9C File Offset: 0x00073D9C
		[SecurityCritical]
		internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
		{
			ThreadPool.EnsureVMInitialized();
			try
			{
			}
			finally
			{
				ThreadPoolGlobals.workQueue.Enqueue(workItem, forceGlobal);
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00075BD0 File Offset: 0x00073DD0
		[SecurityCritical]
		internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
		{
			return ThreadPoolGlobals.vmTpInitialized && ThreadPoolGlobals.workQueue.LocalFindAndPop(workItem);
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00075BE8 File Offset: 0x00073DE8
		[SecurityCritical]
		internal static IEnumerable<IThreadPoolWorkItem> GetQueuedWorkItems()
		{
			return ThreadPool.EnumerateQueuedWorkItems(ThreadPoolWorkQueue.allThreadQueues.Current, ThreadPoolGlobals.workQueue.queueTail);
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00075C05 File Offset: 0x00073E05
		internal static IEnumerable<IThreadPoolWorkItem> EnumerateQueuedWorkItems(ThreadPoolWorkQueue.WorkStealingQueue[] wsQueues, ThreadPoolWorkQueue.QueueSegment globalQueueTail)
		{
			if (wsQueues != null)
			{
				foreach (ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue in wsQueues)
				{
					if (workStealingQueue != null && workStealingQueue.m_array != null)
					{
						IThreadPoolWorkItem[] items = workStealingQueue.m_array;
						int num;
						for (int i = 0; i < items.Length; i = num + 1)
						{
							IThreadPoolWorkItem threadPoolWorkItem = items[i];
							if (threadPoolWorkItem != null)
							{
								yield return threadPoolWorkItem;
							}
							num = i;
						}
						items = null;
					}
				}
				ThreadPoolWorkQueue.WorkStealingQueue[] array = null;
			}
			if (globalQueueTail != null)
			{
				ThreadPoolWorkQueue.QueueSegment segment;
				for (segment = globalQueueTail; segment != null; segment = segment.Next)
				{
					IThreadPoolWorkItem[] items = segment.nodes;
					int num;
					for (int j = 0; j < items.Length; j = num + 1)
					{
						IThreadPoolWorkItem threadPoolWorkItem2 = items[j];
						if (threadPoolWorkItem2 != null)
						{
							yield return threadPoolWorkItem2;
						}
						num = j;
					}
					items = null;
				}
				segment = null;
			}
			yield break;
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00075C1C File Offset: 0x00073E1C
		[SecurityCritical]
		internal static IEnumerable<IThreadPoolWorkItem> GetLocallyQueuedWorkItems()
		{
			return ThreadPool.EnumerateQueuedWorkItems(new ThreadPoolWorkQueue.WorkStealingQueue[]
			{
				ThreadPoolWorkQueueThreadLocals.threadLocals.workStealingQueue
			}, null);
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00075C37 File Offset: 0x00073E37
		[SecurityCritical]
		internal static IEnumerable<IThreadPoolWorkItem> GetGloballyQueuedWorkItems()
		{
			return ThreadPool.EnumerateQueuedWorkItems(null, ThreadPoolGlobals.workQueue.queueTail);
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00075C4C File Offset: 0x00073E4C
		private static object[] ToObjectArray(IEnumerable<IThreadPoolWorkItem> workitems)
		{
			int num = 0;
			foreach (IThreadPoolWorkItem threadPoolWorkItem in workitems)
			{
				num++;
			}
			object[] array = new object[num];
			num = 0;
			foreach (IThreadPoolWorkItem threadPoolWorkItem2 in workitems)
			{
				if (num < array.Length)
				{
					array[num] = threadPoolWorkItem2;
				}
				num++;
			}
			return array;
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00075CDC File Offset: 0x00073EDC
		[SecurityCritical]
		internal static object[] GetQueuedWorkItemsForDebugger()
		{
			return ThreadPool.ToObjectArray(ThreadPool.GetQueuedWorkItems());
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00075CE8 File Offset: 0x00073EE8
		[SecurityCritical]
		internal static object[] GetGloballyQueuedWorkItemsForDebugger()
		{
			return ThreadPool.ToObjectArray(ThreadPool.GetGloballyQueuedWorkItems());
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00075CF4 File Offset: 0x00073EF4
		[SecurityCritical]
		internal static object[] GetLocallyQueuedWorkItemsForDebugger()
		{
			return ThreadPool.ToObjectArray(ThreadPool.GetLocallyQueuedWorkItems());
		}

		// Token: 0x06002053 RID: 8275
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool RequestWorkerThread();

		// Token: 0x06002054 RID: 8276
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern bool PostQueuedCompletionStatus(NativeOverlapped* overlapped);

		/// <summary>Помещает в очередь на выполнение операцию перекрывающегося ввода-вывода.</summary>
		/// <param name="overlapped">Помещаемая в очередь структура <see cref="T:System.Threading.NativeOverlapped" />.</param>
		/// <returns>Значение <see langword="true" />, если операция была успешна помещена в очередь порта завершения ввода-вывода; в противном случае значение <see langword="false" />.</returns>
		// Token: 0x06002055 RID: 8277 RVA: 0x00075D00 File Offset: 0x00073F00
		[SecurityCritical]
		[CLSCompliant(false)]
		public unsafe static bool UnsafeQueueNativeOverlapped(NativeOverlapped* overlapped)
		{
			throw new NotImplementedException("");
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00075D0C File Offset: 0x00073F0C
		[SecurityCritical]
		private static void EnsureVMInitialized()
		{
			if (!ThreadPoolGlobals.vmTpInitialized)
			{
				ThreadPool.InitializeVMTp(ref ThreadPoolGlobals.enableWorkerTracking);
				ThreadPoolGlobals.vmTpInitialized = true;
			}
		}

		// Token: 0x06002057 RID: 8279
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SetMinThreadsNative(int workerThreads, int completionPortThreads);

		// Token: 0x06002058 RID: 8280
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SetMaxThreadsNative(int workerThreads, int completionPortThreads);

		// Token: 0x06002059 RID: 8281
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetMinThreadsNative(out int workerThreads, out int completionPortThreads);

		// Token: 0x0600205A RID: 8282
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetMaxThreadsNative(out int workerThreads, out int completionPortThreads);

		// Token: 0x0600205B RID: 8283
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetAvailableThreadsNative(out int workerThreads, out int completionPortThreads);

		// Token: 0x0600205C RID: 8284
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool NotifyWorkItemComplete();

		// Token: 0x0600205D RID: 8285
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void ReportThreadStatus(bool isWorking);

		// Token: 0x0600205E RID: 8286 RVA: 0x00075D29 File Offset: 0x00073F29
		[SecuritySafeCritical]
		internal static void NotifyWorkItemProgress()
		{
			ThreadPool.EnsureVMInitialized();
			ThreadPool.NotifyWorkItemProgressNative();
		}

		// Token: 0x0600205F RID: 8287
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void NotifyWorkItemProgressNative();

		// Token: 0x06002060 RID: 8288
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void NotifyWorkItemQueued();

		// Token: 0x06002061 RID: 8289 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[SecurityCritical]
		internal static bool IsThreadPoolHosted()
		{
			return false;
		}

		// Token: 0x06002062 RID: 8290
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitializeVMTp(ref bool enableWorkerTracking);

		/// <summary>Связывает дескриптор операционной системы с объектом <see cref="T:System.Threading.ThreadPool" />.</summary>
		/// <param name="osHandle">Структура <see cref="T:System.IntPtr" />, хранящая дескриптор. Дескриптор должен быть открыт для перекрывающегося ввода-вывода в неуправляемой области.</param>
		/// <returns>Значение <see langword="true" />, если дескриптор является связанным; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06002063 RID: 8291 RVA: 0x00075D35 File Offset: 0x00073F35
		[Obsolete("ThreadPool.BindHandle(IntPtr) has been deprecated.  Please use ThreadPool.BindHandle(SafeHandle) instead.", false)]
		[SecuritySafeCritical]
		public static bool BindHandle(IntPtr osHandle)
		{
			return ThreadPool.BindIOCompletionCallbackNative(osHandle);
		}

		/// <summary>Связывает дескриптор операционной системы с объектом <see cref="T:System.Threading.ThreadPool" />.</summary>
		/// <param name="osHandle">Объект <see cref="T:System.Runtime.InteropServices.SafeHandle" />, содержащий дескриптор операционной системы. Дескриптор должен быть открыт для перекрывающегося ввода-вывода в неуправляемой области.</param>
		/// <returns>Значение <see langword="true" />, если дескриптор является связанным; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="osHandle" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002064 RID: 8292 RVA: 0x00075D40 File Offset: 0x00073F40
		[SecuritySafeCritical]
		public static bool BindHandle(SafeHandle osHandle)
		{
			if (osHandle == null)
			{
				throw new ArgumentNullException("osHandle");
			}
			bool result = false;
			bool flag = false;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				osHandle.DangerousAddRef(ref flag);
				result = ThreadPool.BindIOCompletionCallbackNative(osHandle.DangerousGetHandle());
			}
			finally
			{
				if (flag)
				{
					osHandle.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000040F7 File Offset: 0x000022F7
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[SecurityCritical]
		private static bool BindIOCompletionCallbackNative(IntPtr fileHandle)
		{
			return true;
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x00075D98 File Offset: 0x00073F98
		internal static bool IsThreadPoolThread
		{
			get
			{
				return Thread.CurrentThread.IsThreadPoolThread;
			}
		}
	}
}
