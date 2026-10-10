using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using Unity;

namespace System.Threading
{
	/// <summary>Предоставляет атомарные операции для переменных, общедоступных нескольким потокам.</summary>
	// Token: 0x020002F0 RID: 752
	public static class Interlocked
	{
		/// <summary>Сравнивает два 32-разрядных целых числа со знаком на равенство и, если они равны, заменяет первое.</summary>
		/// <param name="location1">Целевой объект, который нужно сравнить с объектом <paramref name="comparand" /> и, возможно, заменить.</param>
		/// <param name="value">Значение, которым будет заменено целевое значение, если проверка покажет равенство.</param>
		/// <param name="comparand">Значение, которое сравнивается со значением в позиции <paramref name="location1" />.</param>
		/// <returns>Исходное значение в позиции <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020B3 RID: 8371
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int CompareExchange(ref int location1, int value, int comparand);

		// Token: 0x060020B4 RID: 8372
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded);

		// Token: 0x060020B5 RID: 8373
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result);

		/// <summary>Сравнивает два объекта на равенство ссылок и, если они равны, заменяет первый объект.</summary>
		/// <param name="location1">Целевой объект, который будет сравниваться по ссылке со значением параметра <paramref name="comparand" /> и, возможно, будет заменен.</param>
		/// <param name="value">Объект, который заменит целевой объект, если результатом сравнения по ссылке будет равенство.</param>
		/// <param name="comparand">Объект, который сравнивается по ссылке с объектом в <paramref name="location1" />.</param>
		/// <returns>Исходное значение в позиции <paramref name="location1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020B6 RID: 8374 RVA: 0x000769C8 File Offset: 0x00074BC8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static object CompareExchange(ref object location1, object value, object comparand)
		{
			object result = null;
			Interlocked.CompareExchange(ref location1, ref value, ref comparand, ref result);
			return result;
		}

		/// <summary>Сравнивает два числа с плавающей запятой с обычной точностью на равенство и, если они равны, заменяет первое значение.</summary>
		/// <param name="location1">Целевой объект, который нужно сравнить с объектом <paramref name="comparand" /> и, возможно, заменить.</param>
		/// <param name="value">Значение, которым будет заменено целевое значение, если проверка покажет равенство.</param>
		/// <param name="comparand">Значение, которое сравнивается со значением в позиции <paramref name="location1" />.</param>
		/// <returns>Исходное значение в позиции <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020B7 RID: 8375
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float CompareExchange(ref float location1, float value, float comparand);

		/// <summary>Уменьшает значение заданной переменной и сохраняет результат в виде атомарной операции.</summary>
		/// <param name="location">Переменная, у которой уменьшается значение.</param>
		/// <returns>Уменьшаемое значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Адрес <paramref name="location" /> является пустым указателем.</exception>
		// Token: 0x060020B8 RID: 8376
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Decrement(ref int location);

		/// <summary>Уменьшает значение заданной переменной и сохраняет результат в виде атомарной операции.</summary>
		/// <param name="location">Переменная, у которой уменьшается значение.</param>
		/// <returns>Уменьшаемое значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Адрес <paramref name="location" /> является пустым указателем.</exception>
		// Token: 0x060020B9 RID: 8377
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Decrement(ref long location);

		/// <summary>Увеличивает значение заданной переменной и сохраняет результат в виде атомарной операции.</summary>
		/// <param name="location">Переменная, значение которой должно увеличиваться.</param>
		/// <returns>Увеличиваемое значение.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location" /> является пустым указателем.</exception>
		// Token: 0x060020BA RID: 8378
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Increment(ref int location);

		/// <summary>Увеличивает значение заданной переменной и сохраняет результат в виде атомарной операции.</summary>
		/// <param name="location">Переменная, значение которой должно увеличиваться.</param>
		/// <returns>Увеличиваемое значение.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location" /> является пустым указателем.</exception>
		// Token: 0x060020BB RID: 8379
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Increment(ref long location);

		/// <summary>Присваивает 32-разрядному целому числу со знаком заданное значение и возвращает исходное значение в виде атомарной операции.</summary>
		/// <param name="location1">Переменная, которая задается указанным значением.</param>
		/// <param name="value">Значение, которое задается для параметра <paramref name="location1" />.</param>
		/// <returns>Исходное значение <paramref name="location1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020BC RID: 8380
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Exchange(ref int location1, int value);

		// Token: 0x060020BD RID: 8381
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Exchange(ref object location1, ref object value, ref object result);

		/// <summary>Задает объект указанным значением в виде атомарной операции и возвращает ссылку на исходный объект.</summary>
		/// <param name="location1">Переменная, которая задается указанным значением.</param>
		/// <param name="value">Значение, которое задается для параметра <paramref name="location1" />.</param>
		/// <returns>Исходное значение <paramref name="location1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020BE RID: 8382 RVA: 0x000769E4 File Offset: 0x00074BE4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static object Exchange(ref object location1, object value)
		{
			object result = null;
			Interlocked.Exchange(ref location1, ref value, ref result);
			return result;
		}

		/// <summary>Задает число с плавающей запятой с одинарной точностью указанным значением в виде атомарной операции и возвращает исходное значение.</summary>
		/// <param name="location1">Переменная, которая задается указанным значением.</param>
		/// <param name="value">Значение, которое задается для параметра <paramref name="location1" />.</param>
		/// <returns>Исходное значение <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020BF RID: 8383
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Exchange(ref float location1, float value);

		/// <summary>Сравнивает два 64-разрядных целых числа со знаком на равенство и, если они равны, заменяет первое.</summary>
		/// <param name="location1">Целевой объект, который нужно сравнить с объектом <paramref name="comparand" /> и, возможно, заменить.</param>
		/// <param name="value">Значение, которым будет заменено целевое значение, если проверка покажет равенство.</param>
		/// <param name="comparand">Значение, которое сравнивается со значением в позиции <paramref name="location1" />.</param>
		/// <returns>Исходное значение в позиции <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020C0 RID: 8384
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long CompareExchange(ref long location1, long value, long comparand);

		/// <summary>Сравнивает два зависящих от платформы обработчика или указателя на равенство и, если они равны, заменяет первое из значений.</summary>
		/// <param name="location1">Целевое значение <see cref="T:System.IntPtr" />, которое будет сравниваться со значением параметра <paramref name="comparand" /> и, возможно, будет заменено <paramref name="value" />.</param>
		/// <param name="value">Значение <see cref="T:System.IntPtr" />, которое заменит целевое значение, если результатом сравнения будет равенство.</param>
		/// <param name="comparand">Значение <see cref="T:System.IntPtr" />, которое сравнивается со значением <paramref name="location1" />.</param>
		/// <returns>Исходное значение в позиции <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020C1 RID: 8385
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand);

		/// <summary>Сравнивает два числа с плавающей запятой двойной точности на равенство и, если они равны, заменяет первое значение.</summary>
		/// <param name="location1">Целевой объект, который нужно сравнить с объектом <paramref name="comparand" /> и, возможно, заменить.</param>
		/// <param name="value">Значение, которым будет заменено целевое значение, если проверка покажет равенство.</param>
		/// <param name="comparand">Значение, которое сравнивается со значением в позиции <paramref name="location1" />.</param>
		/// <returns>Исходное значение в позиции <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020C2 RID: 8386
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double CompareExchange(ref double location1, double value, double comparand);

		/// <summary>Сравнивает два экземпляра указанного ссылочного типа <paramref name="T" /> на равенство ссылок. Если они равны, заменяет первый экземпляр.</summary>
		/// <param name="location1">Целевой объект, значение которого сравнивается по ссылке с объектом <paramref name="comparand" /> и, возможно, будет заменено. Это ссылочный параметр (<see langword="ref" /> в C#, <see langword="ByRef" /> в Visual Basic).</param>
		/// <param name="value">Значение, которым будет заменено целевое значение, если результатом сравнения по ссылке будет равенство.</param>
		/// <param name="comparand">Значение, которое сравнивается по ссылке со значением в позиции <paramref name="location1" />.</param>
		/// <typeparam name="T">Тип, используемый для <paramref name="location1" />, <paramref name="value" />, и <paramref name="comparand" />. Этот тип должен быть ссылочным типом.</typeparam>
		/// <returns>Исходное значение в позиции <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020C3 RID: 8387 RVA: 0x00076A00 File Offset: 0x00074C00
		[ComVisible(false)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[Intrinsic]
		public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
		{
			if (Unsafe.AsPointer<T>(ref location1) == null)
			{
				throw new NullReferenceException();
			}
			T result = default(T);
			Interlocked.CompareExchange(Unsafe.As<T, object>(ref location1), Unsafe.As<T, object>(ref value), Unsafe.As<T, object>(ref comparand), Unsafe.As<T, object>(ref result));
			return result;
		}

		/// <summary>Присваивает 64-разрядному целому числу со знаком заданное значение и возвращает исходное значение в виде атомарной операции.</summary>
		/// <param name="location1">Переменная, которая задается указанным значением.</param>
		/// <param name="value">Значение, которое задается для параметра <paramref name="location1" />.</param>
		/// <returns>Исходное значение <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020C4 RID: 8388
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Exchange(ref long location1, long value);

		/// <summary>Задает указатель или обработчик, зависящий от платформы в виде атомарной операции, и возвращает ссылку на исходное значение.</summary>
		/// <param name="location1">Переменная, которая задается указанным значением.</param>
		/// <param name="value">Значение, которое задается для параметра <paramref name="location1" />.</param>
		/// <returns>Исходное значение <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020C5 RID: 8389
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr Exchange(ref IntPtr location1, IntPtr value);

		/// <summary>Задает число с плавающей запятой с двойной точностью указанным значением в виде атомарной операции и возвращает исходное значение.</summary>
		/// <param name="location1">Переменная, которая задается указанным значением.</param>
		/// <param name="value">Значение, которое задается для параметра <paramref name="location1" />.</param>
		/// <returns>Исходное значение <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020C6 RID: 8390
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Exchange(ref double location1, double value);

		/// <summary>Задает определенное значение для переменной указанного типа <paramref name="T" /> и возвращает исходное значение (атомарная операция).</summary>
		/// <param name="location1">Переменная, которая задается указанным значением. Это ссылочный параметр (<see langword="ref" /> в C#, <see langword="ByRef" /> в Visual Basic).</param>
		/// <param name="value">Значение, которое задается для параметра <paramref name="location1" />.</param>
		/// <typeparam name="T">Тип, который должен использоваться для <paramref name="location1" /> и <paramref name="value" />. Этот тип должен быть ссылочным типом.</typeparam>
		/// <returns>Исходное значение <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020C7 RID: 8391 RVA: 0x00076A48 File Offset: 0x00074C48
		[ComVisible(false)]
		[Intrinsic]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static T Exchange<T>(ref T location1, T value) where T : class
		{
			if (Unsafe.AsPointer<T>(ref location1) == null)
			{
				throw new NullReferenceException();
			}
			T result = default(T);
			Interlocked.Exchange(Unsafe.As<T, object>(ref location1), Unsafe.As<T, object>(ref value), Unsafe.As<T, object>(ref result));
			return result;
		}

		/// <summary>Возвращает 64-разрядное значение, загруженное в виде атомарной операции.</summary>
		/// <param name="location">Загружаемое 64-разрядное значение.</param>
		/// <returns>Загруженное значение.</returns>
		// Token: 0x060020C8 RID: 8392
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Read(ref long location);

		/// <summary>Добавляет два 32-разрядных целых числа и заменяет первое число на сумму в виде атомарной операции.</summary>
		/// <param name="location1">Переменная, содержащая первое добавляемое значение. Сумма двух значений сохраняется в <paramref name="location1" />.</param>
		/// <param name="value">Значение, добавляемое к целому в <paramref name="location1" />.</param>
		/// <returns>Новое значение сохраняется в <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020C9 RID: 8393
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Add(ref int location1, int value);

		/// <summary>Добавляет два 64-разрядных целых числа и заменяет первое число на сумму в виде атомарной операции.</summary>
		/// <param name="location1">Переменная, содержащая первое добавляемое значение. Сумма двух значений сохраняется в <paramref name="location1" />.</param>
		/// <param name="value">Значение, добавляемое к целому в <paramref name="location1" />.</param>
		/// <returns>Новое значение сохраняется в <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Адрес <paramref name="location1" /> является пустым указателем.</exception>
		// Token: 0x060020CA RID: 8394
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Add(ref long location1, long value);

		/// <summary>Выполняет синхронизацию доступа к памяти следующим образом: Процессор, выполняющий текущий поток, не способен упорядочить инструкции так, чтобы обращения к памяти до вызова метода <see cref="M:System.Threading.Interlocked.MemoryBarrier" /> выполнялись после обращений к памяти, следующих за вызовом метода <see cref="M:System.Threading.Interlocked.MemoryBarrier" />.</summary>
		// Token: 0x060020CB RID: 8395 RVA: 0x00076A87 File Offset: 0x00074C87
		public static void MemoryBarrier()
		{
			Thread.MemoryBarrier();
		}

		// Token: 0x060020CC RID: 8396
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MemoryBarrierProcessWide();

		/// <summary>Defines a memory fence that blocks speculative execution past this point until pending reads and writes are complete.</summary>
		// Token: 0x060020CD RID: 8397 RVA: 0x000173AD File Offset: 0x000155AD
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void SpeculationBarrier()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
