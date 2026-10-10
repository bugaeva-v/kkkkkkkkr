using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System.Threading
{
	/// <summary>Содержит методы для выполнения операций энергонезависимой памяти.</summary>
	// Token: 0x020002FD RID: 765
	public static class Volatile
	{
		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x0600214B RID: 8523 RVA: 0x0007831A File Offset: 0x0007651A
		[Intrinsic]
		public static bool Read(ref bool location)
		{
			return Unsafe.As<bool, Volatile.VolatileBoolean>(ref location).Value;
		}

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x0600214C RID: 8524 RVA: 0x00078329 File Offset: 0x00076529
		[Intrinsic]
		public static void Write(ref bool location, bool value)
		{
			Unsafe.As<bool, Volatile.VolatileBoolean>(ref location).Value = value;
		}

		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x0600214D RID: 8525 RVA: 0x00078339 File Offset: 0x00076539
		[Intrinsic]
		public static byte Read(ref byte location)
		{
			return Unsafe.As<byte, Volatile.VolatileByte>(ref location).Value;
		}

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x0600214E RID: 8526 RVA: 0x00078348 File Offset: 0x00076548
		[Intrinsic]
		public static void Write(ref byte location, byte value)
		{
			Unsafe.As<byte, Volatile.VolatileByte>(ref location).Value = value;
		}

		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x0600214F RID: 8527 RVA: 0x00078358 File Offset: 0x00076558
		[Intrinsic]
		public static short Read(ref short location)
		{
			return Unsafe.As<short, Volatile.VolatileInt16>(ref location).Value;
		}

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x06002150 RID: 8528 RVA: 0x00078367 File Offset: 0x00076567
		[Intrinsic]
		public static void Write(ref short location, short value)
		{
			Unsafe.As<short, Volatile.VolatileInt16>(ref location).Value = value;
		}

		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x06002151 RID: 8529 RVA: 0x00078377 File Offset: 0x00076577
		[Intrinsic]
		public static int Read(ref int location)
		{
			return Unsafe.As<int, Volatile.VolatileInt32>(ref location).Value;
		}

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x06002152 RID: 8530 RVA: 0x00078386 File Offset: 0x00076586
		[Intrinsic]
		public static void Write(ref int location, int value)
		{
			Unsafe.As<int, Volatile.VolatileInt32>(ref location).Value = value;
		}

		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x06002153 RID: 8531 RVA: 0x00078396 File Offset: 0x00076596
		[Intrinsic]
		public static IntPtr Read(ref IntPtr location)
		{
			return Unsafe.As<IntPtr, Volatile.VolatileIntPtr>(ref location).Value;
		}

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x06002154 RID: 8532 RVA: 0x000783A5 File Offset: 0x000765A5
		[Intrinsic]
		public static void Write(ref IntPtr location, IntPtr value)
		{
			Unsafe.As<IntPtr, Volatile.VolatileIntPtr>(ref location).Value = value;
		}

		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x06002155 RID: 8533 RVA: 0x000783B5 File Offset: 0x000765B5
		[Intrinsic]
		[CLSCompliant(false)]
		public static sbyte Read(ref sbyte location)
		{
			return Unsafe.As<sbyte, Volatile.VolatileSByte>(ref location).Value;
		}

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x06002156 RID: 8534 RVA: 0x000783C4 File Offset: 0x000765C4
		[CLSCompliant(false)]
		[Intrinsic]
		public static void Write(ref sbyte location, sbyte value)
		{
			Unsafe.As<sbyte, Volatile.VolatileSByte>(ref location).Value = value;
		}

		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x06002157 RID: 8535 RVA: 0x000783D4 File Offset: 0x000765D4
		[Intrinsic]
		public static float Read(ref float location)
		{
			return Unsafe.As<float, Volatile.VolatileSingle>(ref location).Value;
		}

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x06002158 RID: 8536 RVA: 0x000783E3 File Offset: 0x000765E3
		[Intrinsic]
		public static void Write(ref float location, float value)
		{
			Unsafe.As<float, Volatile.VolatileSingle>(ref location).Value = value;
		}

		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x06002159 RID: 8537 RVA: 0x000783F3 File Offset: 0x000765F3
		[CLSCompliant(false)]
		[Intrinsic]
		public static ushort Read(ref ushort location)
		{
			return Unsafe.As<ushort, Volatile.VolatileUInt16>(ref location).Value;
		}

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x0600215A RID: 8538 RVA: 0x00078402 File Offset: 0x00076602
		[CLSCompliant(false)]
		[Intrinsic]
		public static void Write(ref ushort location, ushort value)
		{
			Unsafe.As<ushort, Volatile.VolatileUInt16>(ref location).Value = value;
		}

		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x0600215B RID: 8539 RVA: 0x00078412 File Offset: 0x00076612
		[CLSCompliant(false)]
		[Intrinsic]
		public static uint Read(ref uint location)
		{
			return Unsafe.As<uint, Volatile.VolatileUInt32>(ref location).Value;
		}

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x0600215C RID: 8540 RVA: 0x00078421 File Offset: 0x00076621
		[CLSCompliant(false)]
		[Intrinsic]
		public static void Write(ref uint location, uint value)
		{
			Unsafe.As<uint, Volatile.VolatileUInt32>(ref location).Value = value;
		}

		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x0600215D RID: 8541 RVA: 0x00078431 File Offset: 0x00076631
		[CLSCompliant(false)]
		[Intrinsic]
		public static UIntPtr Read(ref UIntPtr location)
		{
			return Unsafe.As<UIntPtr, Volatile.VolatileUIntPtr>(ref location).Value;
		}

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x0600215E RID: 8542 RVA: 0x00078440 File Offset: 0x00076640
		[CLSCompliant(false)]
		[Intrinsic]
		public static void Write(ref UIntPtr location, UIntPtr value)
		{
			Unsafe.As<UIntPtr, Volatile.VolatileUIntPtr>(ref location).Value = value;
		}

		/// <summary>Считывает ссылку на объект из указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <typeparam name="T">Тип считываемого поля. Должен быть ссылочным типом или типом значения.</typeparam>
		/// <returns>Прочитанная ссылка на объект <paramref name="T" />. Эта ссылка является последней, записанной любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x0600215F RID: 8543 RVA: 0x00078450 File Offset: 0x00076650
		[Intrinsic]
		public static T Read<T>(ref T location) where T : class
		{
			return Unsafe.As<T>(Unsafe.As<T, Volatile.VolatileObject>(ref location).Value);
		}

		/// <summary>Записывает заданную ссылку на объект в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается ссылка на объект.</param>
		/// <param name="value">Записываемая ссылка на объект. Ссылка записывается немедленно, так что она становится видимой для всех процессоров компьютера.</param>
		/// <typeparam name="T">Тип поля, в которое выполняется запись. Должен быть ссылочным типом или типом значения.</typeparam>
		// Token: 0x06002160 RID: 8544 RVA: 0x00078464 File Offset: 0x00076664
		[Intrinsic]
		public static void Write<T>(ref T location, T value) where T : class
		{
			Unsafe.As<T, Volatile.VolatileObject>(ref location).Value = value;
		}

		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x06002161 RID: 8545
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Read(ref long location);

		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x06002162 RID: 8546
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ulong Read(ref ulong location);

		/// <summary>Считывает значение указанного поля. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется после данного метода в коде, процессор не сможет переместить ее перед этим методом.</summary>
		/// <param name="location">Считываемое поле.</param>
		/// <returns>Прочитанное значение. Это значение является последним, записанным любым процессором компьютера, независимо от количества процессоров и от состояния кэша процессоров.</returns>
		// Token: 0x06002163 RID: 8547
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Read(ref double location);

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция памяти появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x06002164 RID: 8548
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Write(ref long location, long value);

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x06002165 RID: 8549
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Write(ref ulong location, ulong value);

		/// <summary>Записывает заданное значение в указанное поле. В системах, которым это необходимо, вставляет барьер памяти, не позволяющий процессору изменять порядок операций памяти следующим образом: если операция чтения или записи появляется перед данным методом в коде, процессор не сможет поместить ее после этого метода.</summary>
		/// <param name="location">Поле, в которое записывается значение.</param>
		/// <param name="value">Значение для записи. Значение записывается немедленно, так что оно становится видимым для всех процессоров компьютера.</param>
		// Token: 0x06002166 RID: 8550
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Write(ref double location, double value);

		// Token: 0x020002FE RID: 766
		private struct VolatileBoolean
		{
			// Token: 0x04001BBC RID: 7100
			public volatile bool Value;
		}

		// Token: 0x020002FF RID: 767
		private struct VolatileByte
		{
			// Token: 0x04001BBD RID: 7101
			public volatile byte Value;
		}

		// Token: 0x02000300 RID: 768
		private struct VolatileInt16
		{
			// Token: 0x04001BBE RID: 7102
			public volatile short Value;
		}

		// Token: 0x02000301 RID: 769
		private struct VolatileInt32
		{
			// Token: 0x04001BBF RID: 7103
			public volatile int Value;
		}

		// Token: 0x02000302 RID: 770
		private struct VolatileIntPtr
		{
			// Token: 0x04001BC0 RID: 7104
			public volatile IntPtr Value;
		}

		// Token: 0x02000303 RID: 771
		private struct VolatileSByte
		{
			// Token: 0x04001BC1 RID: 7105
			public volatile sbyte Value;
		}

		// Token: 0x02000304 RID: 772
		private struct VolatileSingle
		{
			// Token: 0x04001BC2 RID: 7106
			public volatile float Value;
		}

		// Token: 0x02000305 RID: 773
		private struct VolatileUInt16
		{
			// Token: 0x04001BC3 RID: 7107
			public volatile ushort Value;
		}

		// Token: 0x02000306 RID: 774
		private struct VolatileUInt32
		{
			// Token: 0x04001BC4 RID: 7108
			public volatile uint Value;
		}

		// Token: 0x02000307 RID: 775
		private struct VolatileUIntPtr
		{
			// Token: 0x04001BC5 RID: 7109
			public volatile UIntPtr Value;
		}

		// Token: 0x02000308 RID: 776
		private struct VolatileObject
		{
			// Token: 0x04001BC6 RID: 7110
			public volatile object Value;
		}
	}
}
