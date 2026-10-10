using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Mono.Interop;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет коллекцию методов для выделения неуправляемой памяти, копирования блоков неуправляемой памяти и преобразования управляемых типов в неуправляемые, а также прочих разнообразных методов, используемых при взаимодействии с неуправляемым кодом.</summary>
	// Token: 0x02000748 RID: 1864
	public static class Marshal
	{
		// Token: 0x0600414E RID: 16718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int AddRefInternal(IntPtr pUnk);

		/// <summary>Увеличивает счетчик ссылок для указанного интерфейса.</summary>
		/// <param name="pUnk">Увеличиваемый счетчик ссылок интерфейса.</param>
		/// <returns>Новое значение счетчика ссылок для параметра <paramref name="pUnk" />.</returns>
		// Token: 0x0600414F RID: 16719 RVA: 0x000E1FFA File Offset: 0x000E01FA
		public static int AddRef(IntPtr pUnk)
		{
			if (pUnk == IntPtr.Zero)
			{
				throw new ArgumentNullException("pUnk");
			}
			return Marshal.AddRefInternal(pUnk);
		}

		/// <summary>Указывает, доступны ли для очистки вызываемые оболочки времени выполнения (RCW) из какого-либо контекста.</summary>
		/// <returns>Значение <see langword="true" />, если есть доступные для очистки вызываемые оболочки времени выполнения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004150 RID: 16720 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public static bool AreComObjectsAvailableForCleanup()
		{
			return false;
		}

		/// <summary>Предписывает среде выполнения очистить все вызываемые оболочки времени выполнения (RCW), выделенные в текущем контексте.</summary>
		// Token: 0x06004151 RID: 16721 RVA: 0x000E201A File Offset: 0x000E021A
		public static void CleanupUnusedObjectsInCurrentContext()
		{
			if (Environment.IsRunningOnWindows)
			{
				throw new PlatformNotSupportedException();
			}
		}

		/// <summary>Выделяет блок памяти указанного размера из механизма распределения памяти для задач COM.</summary>
		/// <param name="cb">Размер выделяемого блока памяти.</param>
		/// <returns>Целое число, представляющее адрес выделенного блока памяти. Освобождать эту память необходимо с помощью метода <see cref="M:System.Runtime.InteropServices.Marshal.FreeCoTaskMem(System.IntPtr)" />.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно памяти для выполнения запроса.</exception>
		// Token: 0x06004152 RID: 16722
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr AllocCoTaskMem(int cb);

		// Token: 0x06004153 RID: 16723
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr AllocCoTaskMemSize(UIntPtr sizet);

		/// <summary>Выделяет память из неуправляемой памяти процесса, используя указатель на заданное количество байтов.</summary>
		/// <param name="cb">Требуемое количество байтов памяти.</param>
		/// <returns>Указатель на только что выделенную память. Эта память должна освобождаться при помощи метода <see cref="M:System.Runtime.InteropServices.Marshal.FreeHGlobal(System.IntPtr)" />.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно памяти для выполнения запроса.</exception>
		// Token: 0x06004154 RID: 16724
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr AllocHGlobal(IntPtr cb);

		/// <summary>Выделяет память из неуправляемой памяти процесса, используя заданное количество байтов.</summary>
		/// <param name="cb">Требуемое количество байтов памяти.</param>
		/// <returns>Указатель на только что выделенную память. Эта память должна освобождаться при помощи метода <see cref="M:System.Runtime.InteropServices.Marshal.FreeHGlobal(System.IntPtr)" />.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно памяти для выполнения запроса.</exception>
		// Token: 0x06004155 RID: 16725 RVA: 0x000E2029 File Offset: 0x000E0229
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static IntPtr AllocHGlobal(int cb)
		{
			return Marshal.AllocHGlobal((IntPtr)cb);
		}

		/// <summary>Возвращает указатель интерфейса, определенный указанным моникером.</summary>
		/// <param name="monikerName">Моникер, соответствующий указателю нужного интерфейса.</param>
		/// <returns>Объект, содержащий ссылку на указатель интерфейса, идентифицируемый параметром <paramref name="monikerName" />. Моникер — это имя, в данном случае определенное интерфейсом.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Нераспознанное значение HRESULT возвращено неуправляемым методом <see langword="BindToMoniker" />.</exception>
		// Token: 0x06004156 RID: 16726 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static object BindToMoniker(string monikerName)
		{
			throw new NotImplementedException();
		}

		/// <summary>Изменяет строгость дескриптора вызываемой оболочки COM (CCW) объекта.</summary>
		/// <param name="otp">Объект, CCW-оболочка которого содержит дескриптор счетчика ссылок. Этот дескриптор является строгим, если значение счетчика CCW-оболочки больше нуля; в противном случае он является слабым.</param>
		/// <param name="fIsWeak">Значение <see langword="true" />, чтобы сделать дескриптор параметра <paramref name="otp" /> менее строгим независимо от числа ссылок; значение <see langword="false" />, чтобы сбросить значение строгости дескриптора параметра <paramref name="otp" /> и сделать его зависимым от числа ссылок.</param>
		// Token: 0x06004157 RID: 16727 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static void ChangeWrapperHandleStrength(object otp, bool fIsWeak)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x000E2036 File Offset: 0x000E0236
		internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length)
		{
			Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, null);
		}

		// Token: 0x06004159 RID: 16729
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, void* fixed_source_element);

		// Token: 0x0600415A RID: 16730 RVA: 0x000E2043 File Offset: 0x000E0243
		private static bool skip_fixed(Array array, int startIndex)
		{
			return startIndex < 0 || startIndex >= array.Length;
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x000E2058 File Offset: 0x000E0258
		internal unsafe static void copy_to_unmanaged(byte[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, null);
				return;
			}
			fixed (byte* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x000E2094 File Offset: 0x000E0294
		internal unsafe static void copy_to_unmanaged(char[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, null);
				return;
			}
			fixed (char* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		/// <summary>Копирует данные из одномерного управляемого массива 8-битных целых чисел без знака в указатель неуправляемой памяти.</summary>
		/// <param name="source">Одномерный массив, из которого выполняется копирование.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в исходном массиве, с которого начинается копирование.</param>
		/// <param name="destination">Указатель памяти, в который выполняется копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> и <paramref name="length" /> являются недопустимыми.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600415D RID: 16733 RVA: 0x000E20D0 File Offset: 0x000E02D0
		public unsafe static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (byte* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		/// <summary>Копирует данные из одномерного управляемого массива символов в неуправляемый указатель памяти.</summary>
		/// <param name="source">Одномерный массив, из которого выполняется копирование.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в исходном массиве, с которого начинается копирование.</param>
		/// <param name="destination">Указатель памяти, в который выполняется копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> и <paramref name="length" /> являются недопустимыми.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="startIndex" />, <paramref name="destination" /> или <paramref name="length" /> равно <see langword="null" />.</exception>
		// Token: 0x0600415E RID: 16734 RVA: 0x000E2108 File Offset: 0x000E0308
		public unsafe static void Copy(char[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (char* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		/// <summary>Копирует данные из одномерного управляемого массива 16-битных целых чисел со знаком в указатель неуправляемой памяти.</summary>
		/// <param name="source">Одномерный массив, из которого выполняется копирование.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в исходном массиве, с которого начинается копирование.</param>
		/// <param name="destination">Указатель памяти, в который выполняется копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> и <paramref name="length" /> являются недопустимыми.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600415F RID: 16735 RVA: 0x000E2140 File Offset: 0x000E0340
		public unsafe static void Copy(short[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (short* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		/// <summary>Копирует данные из одномерного управляемого массива 32-битных целых чисел со знаком в указатель неуправляемой памяти.</summary>
		/// <param name="source">Одномерный массив, из которого выполняется копирование.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в исходном массиве, с которого начинается копирование.</param>
		/// <param name="destination">Указатель памяти, в который выполняется копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> и <paramref name="length" /> являются недопустимыми.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="startIndex" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004160 RID: 16736 RVA: 0x000E2178 File Offset: 0x000E0378
		public unsafe static void Copy(int[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (int* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		/// <summary>Копирует данные из одномерного управляемого массива 64-битных целых чисел со знаком в указатель неуправляемой памяти.</summary>
		/// <param name="source">Одномерный массив, из которого выполняется копирование.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в исходном массиве, с которого начинается копирование.</param>
		/// <param name="destination">Указатель памяти, в который выполняется копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> и <paramref name="length" /> являются недопустимыми.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004161 RID: 16737 RVA: 0x000E21B0 File Offset: 0x000E03B0
		public unsafe static void Copy(long[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (long* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		/// <summary>Копирует данные из одномерного управляемого массива чисел с плавающей запятой одинарной точности в указатель неуправляемой памяти.</summary>
		/// <param name="source">Одномерный массив, из которого выполняется копирование.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в исходном массиве, с которого начинается копирование.</param>
		/// <param name="destination">Указатель памяти, в который выполняется копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> и <paramref name="length" /> являются недопустимыми.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004162 RID: 16738 RVA: 0x000E21E8 File Offset: 0x000E03E8
		public unsafe static void Copy(float[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (float* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		/// <summary>Копирует данные из одномерного управляемого массива чисел с плавающей запятой двойной точности в указатель неуправляемой памяти.</summary>
		/// <param name="source">Одномерный массив, из которого выполняется копирование.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в исходном массиве, с которого начинается копирование.</param>
		/// <param name="destination">Указатель памяти, в который выполняется копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> и <paramref name="length" /> являются недопустимыми.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004163 RID: 16739 RVA: 0x000E2220 File Offset: 0x000E0420
		public unsafe static void Copy(double[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (double* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		/// <summary>Копирует данные из одномерного управляемого массива <see cref="T:System.IntPtr" /> в неуправляемый указатель памяти.</summary>
		/// <param name="source">Одномерный массив, из которого выполняется копирование.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в исходном массиве, с которого начинается копирование.</param>
		/// <param name="destination">Указатель памяти, в который выполняется копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004164 RID: 16740 RVA: 0x000E2258 File Offset: 0x000E0458
		public unsafe static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (IntPtr* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x000E2290 File Offset: 0x000E0490
		internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length)
		{
			Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, null);
		}

		// Token: 0x06004166 RID: 16742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element);

		/// <summary>Копирует данные из указателя неуправляемой памяти в одномерный управляемый массив 8-битных целых чисел без знака.</summary>
		/// <param name="source">Указатель памяти, из которого выполняется копирование.</param>
		/// <param name="destination">Массив для копирования данных.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в массиве назначения, с которого начинается копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004167 RID: 16743 RVA: 0x000E22A0 File Offset: 0x000E04A0
		public unsafe static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
		{
			if (Marshal.skip_fixed(destination, startIndex))
			{
				Marshal.copy_from_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (byte* ptr = &destination[startIndex])
			{
				void* fixed_destination_element = (void*)ptr;
				Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, fixed_destination_element);
			}
		}

		/// <summary>Копирует данные из указателя неуправляемой памяти в управляемый массив символов.</summary>
		/// <param name="source">Указатель памяти, из которого выполняется копирование.</param>
		/// <param name="destination">Массив для копирования данных.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в массиве назначения, с которого начинается копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004168 RID: 16744 RVA: 0x000E22D8 File Offset: 0x000E04D8
		public unsafe static void Copy(IntPtr source, char[] destination, int startIndex, int length)
		{
			if (Marshal.skip_fixed(destination, startIndex))
			{
				Marshal.copy_from_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (char* ptr = &destination[startIndex])
			{
				void* fixed_destination_element = (void*)ptr;
				Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, fixed_destination_element);
			}
		}

		/// <summary>Копирует данные из указателя неуправляемой памяти в одномерный управляемый массив 16-битных целых чисел со знаком.</summary>
		/// <param name="source">Указатель памяти, из которого выполняется копирование.</param>
		/// <param name="destination">Массив для копирования данных.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в массиве назначения, с которого начинается копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004169 RID: 16745 RVA: 0x000E2310 File Offset: 0x000E0510
		public unsafe static void Copy(IntPtr source, short[] destination, int startIndex, int length)
		{
			if (Marshal.skip_fixed(destination, startIndex))
			{
				Marshal.copy_from_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (short* ptr = &destination[startIndex])
			{
				void* fixed_destination_element = (void*)ptr;
				Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, fixed_destination_element);
			}
		}

		/// <summary>Копирует данные из указателя неуправляемой памяти в одномерный управляемый массив 32-битных целых чисел со знаком.</summary>
		/// <param name="source">Указатель памяти, из которого выполняется копирование.</param>
		/// <param name="destination">Массив для копирования данных.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в массиве назначения, с которого начинается копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600416A RID: 16746 RVA: 0x000E2348 File Offset: 0x000E0548
		public unsafe static void Copy(IntPtr source, int[] destination, int startIndex, int length)
		{
			if (Marshal.skip_fixed(destination, startIndex))
			{
				Marshal.copy_from_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (int* ptr = &destination[startIndex])
			{
				void* fixed_destination_element = (void*)ptr;
				Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, fixed_destination_element);
			}
		}

		/// <summary>Копирует данные из указателя неуправляемой памяти в одномерный управляемый массив 64-битных целых чисел со знаком.</summary>
		/// <param name="source">Указатель памяти, из которого выполняется копирование.</param>
		/// <param name="destination">Массив для копирования данных.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в массиве назначения, с которого начинается копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600416B RID: 16747 RVA: 0x000E2380 File Offset: 0x000E0580
		public unsafe static void Copy(IntPtr source, long[] destination, int startIndex, int length)
		{
			if (Marshal.skip_fixed(destination, startIndex))
			{
				Marshal.copy_from_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (long* ptr = &destination[startIndex])
			{
				void* fixed_destination_element = (void*)ptr;
				Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, fixed_destination_element);
			}
		}

		/// <summary>Копирует данные из указателя неуправляемой памяти в управляемый массив чисел с плавающей запятой одиночной точности.</summary>
		/// <param name="source">Указатель памяти, из которого выполняется копирование.</param>
		/// <param name="destination">Массив для копирования данных.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в массиве назначения, с которого начинается копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600416C RID: 16748 RVA: 0x000E23B8 File Offset: 0x000E05B8
		public unsafe static void Copy(IntPtr source, float[] destination, int startIndex, int length)
		{
			if (Marshal.skip_fixed(destination, startIndex))
			{
				Marshal.copy_from_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (float* ptr = &destination[startIndex])
			{
				void* fixed_destination_element = (void*)ptr;
				Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, fixed_destination_element);
			}
		}

		/// <summary>Копирует данные из неуправляемого указателя памяти в управляемый массив чисел с плавающей запятой двойной точности.</summary>
		/// <param name="source">Указатель памяти, из которого выполняется копирование.</param>
		/// <param name="destination">Массив для копирования данных.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в массиве назначения, с которого начинается копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600416D RID: 16749 RVA: 0x000E23F0 File Offset: 0x000E05F0
		public unsafe static void Copy(IntPtr source, double[] destination, int startIndex, int length)
		{
			if (Marshal.skip_fixed(destination, startIndex))
			{
				Marshal.copy_from_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (double* ptr = &destination[startIndex])
			{
				void* fixed_destination_element = (void*)ptr;
				Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, fixed_destination_element);
			}
		}

		/// <summary>Копирует данные из указателя неуправляемой памяти в управляемый массив <see cref="T:System.IntPtr" />.</summary>
		/// <param name="source">Указатель памяти, из которого выполняется копирование.</param>
		/// <param name="destination">Массив для копирования данных.</param>
		/// <param name="startIndex">Отсчитываемый от нуля индекс в массиве назначения, с которого начинается копирование.</param>
		/// <param name="length">Число копируемых элементов массива.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" /> или <paramref name="length" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600416E RID: 16750 RVA: 0x000E2428 File Offset: 0x000E0628
		public unsafe static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length)
		{
			if (Marshal.skip_fixed(destination, startIndex))
			{
				Marshal.copy_from_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (IntPtr* ptr = &destination[startIndex])
			{
				void* fixed_destination_element = (void*)ptr;
				Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, fixed_destination_element);
			}
		}

		/// <summary>Объединяет управляемый объект с заданным COM-объектом.</summary>
		/// <param name="pOuter">Внешний указатель <see langword="IUnknown" />.</param>
		/// <param name="o">Объект для объединения.</param>
		/// <returns>Внутренний указатель <see langword="IUnknown" /> управляемого объекта.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="o" /> является объектом Среда выполнения Windows.</exception>
		// Token: 0x0600416F RID: 16751 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static IntPtr CreateAggregatedObject(IntPtr pOuter, object o)
		{
			throw new NotImplementedException();
		}

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Объединяет управляемый объект заданного типа с заданным COM-объектом.</summary>
		/// <param name="pOuter">Внешний указатель IUnknown.</param>
		/// <param name="o">управляемый объект для агрегации.</param>
		/// <typeparam name="T">тип управляемого объекта для агрегации.</typeparam>
		/// <returns>Внутренний указатель IUnknown управляемого объекта.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="o" /> является объектом Среда выполнения Windows.</exception>
		// Token: 0x06004170 RID: 16752 RVA: 0x000E2460 File Offset: 0x000E0660
		public static IntPtr CreateAggregatedObject<T>(IntPtr pOuter, T o)
		{
			return Marshal.CreateAggregatedObject(pOuter, o);
		}

		/// <summary>Инкапсулирует указанный COM-объект в объекте заданного типа.</summary>
		/// <param name="o">Объект, который следует упаковать.</param>
		/// <param name="t">Тип создаваемой оболочки.</param>
		/// <returns>Новый инкапсулированный объект, являющийся экземпляром нужного типа.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="t" /> должен быть производным от <see langword="__ComObject" />.  
		/// -или- 
		///  <paramref name="t" /> относится к типу Среда выполнения Windows.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="t" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Параметр <paramref name="o" /> нельзя преобразовать в результирующий тип, так как он не поддерживает все требуемые интерфейсы.</exception>
		// Token: 0x06004171 RID: 16753 RVA: 0x000E2470 File Offset: 0x000E0670
		public static object CreateWrapperOfType(object o, Type t)
		{
			__ComObject _ComObject = o as __ComObject;
			if (_ComObject == null)
			{
				throw new ArgumentException("o must derive from __ComObject", "o");
			}
			if (t == null)
			{
				throw new ArgumentNullException("t");
			}
			foreach (Type type in o.GetType().GetInterfaces())
			{
				if (type.IsImport && _ComObject.GetInterface(type) == IntPtr.Zero)
				{
					throw new InvalidCastException();
				}
			}
			return ComInteropProxy.GetProxy(_ComObject.IUnknown, t).GetTransparentProxy();
		}

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Инкапсулирует указанный COM-объект в объекте заданного типа.</summary>
		/// <param name="o">Объект, который следует упаковать.</param>
		/// <typeparam name="T">Тип пакуемого объекта.</typeparam>
		/// <typeparam name="TWrapper">Тип возвращаемого объекта.</typeparam>
		/// <returns>Только что Инкапсулированный объект.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <typeparamref name="T" /> должен быть производным от <see langword="__ComObject" />.  
		/// -или- 
		///  <typeparamref name="T" /> относится к типу Среда выполнения Windows.</exception>
		/// <exception cref="T:System.InvalidCastException">Параметр <paramref name="o" /> не может быть преобразован в <paramref name="TWrapper" />, так как он не поддерживает все необходимые интерфейсы.</exception>
		// Token: 0x06004172 RID: 16754 RVA: 0x000E24FB File Offset: 0x000E06FB
		public static TWrapper CreateWrapperOfType<T, TWrapper>(T o)
		{
			return (TWrapper)((object)Marshal.CreateWrapperOfType(o, typeof(TWrapper)));
		}

		/// <summary>Освобождает все вложенные структуры, на которые указывает заданный блок неуправляемой памяти.</summary>
		/// <param name="ptr">Указатель на неуправляемый блок памяти.</param>
		/// <param name="structuretype">Тип отформатированного класса. Предоставляет сведения распределения, необходимые для удаления буфера из параметра <paramref name="ptr" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="structureType" /> обеспечивает автоматическое распределение. Вместо него следует использовать последовательный или явный вариант.</exception>
		// Token: 0x06004173 RID: 16755
		[ComVisible(true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyStructure(IntPtr ptr, Type structuretype);

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Освобождает все вложенные структуры указанного типа, на которые указывает заданный блок неуправляемой памяти.</summary>
		/// <param name="ptr">Указатель на неуправляемый блок памяти.</param>
		/// <typeparam name="T">Тип отформатированной структуры. Предоставляет сведения распределения, необходимые для удаления буфера из параметра <paramref name="ptr" />.</typeparam>
		/// <exception cref="T:System.ArgumentException">Параметр <typeparamref name="T" /> обеспечивает автоматическое распределение. Вместо него следует использовать последовательный или явный вариант.</exception>
		// Token: 0x06004174 RID: 16756 RVA: 0x000E2517 File Offset: 0x000E0717
		public static void DestroyStructure<T>(IntPtr ptr)
		{
			Marshal.DestroyStructure(ptr, typeof(T));
		}

		/// <summary>Освобождает строку <see langword="BSTR" /> с помощью функции COM SysFreeString.</summary>
		/// <param name="ptr">Адрес освобождаемой строки BSTR.</param>
		// Token: 0x06004175 RID: 16757
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FreeBSTR(IntPtr ptr);

		/// <summary>Освобождает блок памяти, выделенный неуправляемым механизмом распределения памяти для задач COM.</summary>
		/// <param name="ptr">Адрес освобождаемой памяти.</param>
		// Token: 0x06004176 RID: 16758
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FreeCoTaskMem(IntPtr ptr);

		/// <summary>Освобождает память, выделенную ранее из неуправляемой памяти процесса.</summary>
		/// <param name="hglobal">Дескриптор, возвращенный исходным подходящим вызовом метода <see cref="M:System.Runtime.InteropServices.Marshal.AllocHGlobal(System.IntPtr)" />.</param>
		// Token: 0x06004177 RID: 16759
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FreeHGlobal(IntPtr hglobal);

		// Token: 0x06004178 RID: 16760 RVA: 0x000E252C File Offset: 0x000E072C
		private static void ClearBSTR(IntPtr ptr)
		{
			int num = Marshal.ReadInt32(ptr, -4);
			for (int i = 0; i < num; i++)
			{
				Marshal.WriteByte(ptr, i, 0);
			}
		}

		/// <summary>Освобождает указатель BSTR, выделенный с помощью метода <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToBSTR(System.Security.SecureString)" />.</summary>
		/// <param name="s">Адрес <see langword="BSTR" /> для освобождения.</param>
		// Token: 0x06004179 RID: 16761 RVA: 0x000E2556 File Offset: 0x000E0756
		public static void ZeroFreeBSTR(IntPtr s)
		{
			Marshal.ClearBSTR(s);
			Marshal.FreeBSTR(s);
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x000E2564 File Offset: 0x000E0764
		private static void ClearAnsi(IntPtr ptr)
		{
			int num = 0;
			while (Marshal.ReadByte(ptr, num) != 0)
			{
				Marshal.WriteByte(ptr, num, 0);
				num++;
			}
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x000E258C File Offset: 0x000E078C
		private static void ClearUnicode(IntPtr ptr)
		{
			int num = 0;
			while (Marshal.ReadInt16(ptr, num) != 0)
			{
				Marshal.WriteInt16(ptr, num, 0);
				num += 2;
			}
		}

		/// <summary>Освобождает указатель на неуправляемую строку, выделенный с помощью метода <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToCoTaskMemAnsi(System.Security.SecureString)" />.</summary>
		/// <param name="s">Адрес освобождаемой неуправляемой строки.</param>
		// Token: 0x0600417C RID: 16764 RVA: 0x000E25B2 File Offset: 0x000E07B2
		public static void ZeroFreeCoTaskMemAnsi(IntPtr s)
		{
			Marshal.ClearAnsi(s);
			Marshal.FreeCoTaskMem(s);
		}

		/// <summary>Освобождает указатель на неуправляемую строку, выделенный с помощью метода <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToCoTaskMemUnicode(System.Security.SecureString)" />.</summary>
		/// <param name="s">Адрес освобождаемой неуправляемой строки.</param>
		// Token: 0x0600417D RID: 16765 RVA: 0x000E25C0 File Offset: 0x000E07C0
		public static void ZeroFreeCoTaskMemUnicode(IntPtr s)
		{
			Marshal.ClearUnicode(s);
			Marshal.FreeCoTaskMem(s);
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x000E25B2 File Offset: 0x000E07B2
		public static void ZeroFreeCoTaskMemUTF8(IntPtr s)
		{
			Marshal.ClearAnsi(s);
			Marshal.FreeCoTaskMem(s);
		}

		/// <summary>Освобождает указатель на неуправляемую строку, выделенный с помощью метода <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocAnsi(System.Security.SecureString)" />.</summary>
		/// <param name="s">Адрес освобождаемой неуправляемой строки.</param>
		// Token: 0x0600417F RID: 16767 RVA: 0x000E25CE File Offset: 0x000E07CE
		public static void ZeroFreeGlobalAllocAnsi(IntPtr s)
		{
			Marshal.ClearAnsi(s);
			Marshal.FreeHGlobal(s);
		}

		/// <summary>Освобождает указатель на неуправляемую строку, выделенный с помощью метода <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(System.Security.SecureString)" />.</summary>
		/// <param name="s">Адрес освобождаемой неуправляемой строки.</param>
		// Token: 0x06004180 RID: 16768 RVA: 0x000E25DC File Offset: 0x000E07DC
		public static void ZeroFreeGlobalAllocUnicode(IntPtr s)
		{
			Marshal.ClearUnicode(s);
			Marshal.FreeHGlobal(s);
		}

		/// <summary>Возвращает уникальный глобальный идентификатор GUID для указанного типа или создает идентификатор GUID при помощи алгоритма, используемого средством экспортирования библиотек типов Tlbexp.exe.</summary>
		/// <param name="type">Тип, для которого создается идентификатор GUID.</param>
		/// <returns>Идентификатор для указанного типа.</returns>
		// Token: 0x06004181 RID: 16769 RVA: 0x000E25EA File Offset: 0x000E07EA
		public static Guid GenerateGuidForType(Type type)
		{
			return type.GUID;
		}

		/// <summary>Возвращает программный идентификатор ProgID для указанного типа.</summary>
		/// <param name="type">Тип, для которого требуется получить программный идентификатор (ProgID).</param>
		/// <returns>Идентификатор ProgID для указанного типа.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="type" /> не является классом, который может быть создан с помощью COM. Класс должен быть открытым, иметь публичный конструктор по умолчанию, а также быть доступным для COM.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004182 RID: 16770 RVA: 0x000E25F4 File Offset: 0x000E07F4
		public static string GenerateProgIdForType(Type type)
		{
			foreach (CustomAttributeData customAttributeData in CustomAttributeData.GetCustomAttributes(type))
			{
				if (customAttributeData.Constructor.DeclaringType.Name == "ProgIdAttribute")
				{
					IList<CustomAttributeTypedArgument> constructorArguments = customAttributeData.ConstructorArguments;
					string text = customAttributeData.ConstructorArguments[0].Value as string;
					if (text == null)
					{
						text = string.Empty;
					}
					return text;
				}
			}
			return type.FullName;
		}

		/// <summary>Получает выполняющийся экземпляр указанного объекта из таблицы запущенных объектов (ROT).</summary>
		/// <param name="progID">Программный идентификатор (ProgID) запрошенного объекта.</param>
		/// <returns>Запрошенный объект; в противном случае — значение <see langword="null" />. Этот объект может быть приведен к любому интерфейсу COM, поддерживаемому этим объектом.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Объект не найден.</exception>
		// Token: 0x06004183 RID: 16771 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static object GetActiveObject(string progID)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004184 RID: 16772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetCCW(object o, Type T);

		// Token: 0x06004185 RID: 16773 RVA: 0x000E2690 File Offset: 0x000E0890
		private static IntPtr GetComInterfaceForObjectInternal(object o, Type T)
		{
			if (Marshal.IsComObject(o))
			{
				return ((__ComObject)o).GetInterface(T);
			}
			return Marshal.GetCCW(o, T);
		}

		/// <summary>Возвращает указатель на интерфейс IUnknown, представляющий указанный интерфейс заданного объекта. Доступ к настраиваемому интерфейсу запросов включен по умолчанию.</summary>
		/// <param name="o">Объект, предоставляющий интерфейс.</param>
		/// <param name="T">Тип запрашиваемого интерфейса.</param>
		/// <returns>Указатель интерфейса, представляющий заданный интерфейс для объекта.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <typeparamref name="T" /> не является интерфейсом.  
		/// -или- 
		/// Тип недоступен для COM.  
		/// -или- 
		/// Параметр <typeparamref name="T" /> является определением универсального типа.</exception>
		/// <exception cref="T:System.InvalidCastException">Параметр <paramref name="o" /> не поддерживает запрошенный интерфейс.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="o" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Параметр <typeparamref name="T" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004186 RID: 16774 RVA: 0x000E26AE File Offset: 0x000E08AE
		public static IntPtr GetComInterfaceForObject(object o, Type T)
		{
			IntPtr comInterfaceForObjectInternal = Marshal.GetComInterfaceForObjectInternal(o, T);
			Marshal.AddRef(comInterfaceForObjectInternal);
			return comInterfaceForObjectInternal;
		}

		/// <summary>Возвращает указатель на интерфейс IUnknown, представляющий указанный интерфейс заданного объекта. Доступ к настраиваемому интерфейсу запросов контролируется указанным режимом настройки.</summary>
		/// <param name="o">Объект, предоставляющий интерфейс.</param>
		/// <param name="T">Тип запрашиваемого интерфейса.</param>
		/// <param name="mode">Одно из значений перечисления, определяющее, нужно ли применять пользовательскую настройку <see langword="IUnknown::QueryInterface" />, предоставленную в интерфейсе <see cref="T:System.Runtime.InteropServices.ICustomQueryInterface" />.</param>
		/// <returns>Указатель интерфейса, представляющий интерфейс для объекта.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <typeparamref name="T" /> не является интерфейсом.  
		/// -или- 
		/// Тип недоступен для COM.  
		/// -или- 
		/// Параметр <typeparamref name="T" /> является определением универсального типа.</exception>
		/// <exception cref="T:System.InvalidCastException">Объект <paramref name="o" /> не поддерживает запрошенный интерфейс.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="o" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Параметр <typeparamref name="T" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004187 RID: 16775 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static IntPtr GetComInterfaceForObject(object o, Type T, CustomQueryInterfaceMode mode)
		{
			throw new NotImplementedException();
		}

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Возвращает указатель на интерфейс IUnknown, представляющий указанный интерфейс объекта заданного типа. Доступ к настраиваемому интерфейсу запросов включен по умолчанию.</summary>
		/// <param name="o">Объект, предоставляющий интерфейс.</param>
		/// <typeparam name="T">Тип параметра <paramref name="o" />.</typeparam>
		/// <typeparam name="TInterface">Тип возвращаемых интерфейсов.</typeparam>
		/// <returns>Указатель интерфейса, представляющий интерфейс <paramref name="TInterface" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="TInterface" /> не является интерфейсом.  
		/// -или- 
		/// Тип недоступен для COM.  
		/// -или- 
		/// Параметр <typeparamref name="T" />  является открытым универсальным типом.</exception>
		/// <exception cref="T:System.InvalidCastException">Параметр <paramref name="o" /> не поддерживает интерфейс <paramref name="TInterface" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="o" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004188 RID: 16776 RVA: 0x000E26BE File Offset: 0x000E08BE
		public static IntPtr GetComInterfaceForObject<T, TInterface>(T o)
		{
			return Marshal.GetComInterfaceForObject(o, typeof(T));
		}

		/// <summary>Возвращает указатель интерфейса, представляющий заданный интерфейс для объекта, если вызывающий объект находится в том же контексте, что и данный объект.</summary>
		/// <param name="o">Объект, предоставляющий интерфейс.</param>
		/// <param name="t">Тип запрашиваемого интерфейса.</param>
		/// <returns>Указатель интерфейса, заданный параметром <paramref name="t" />, который представляет интерфейс для заданного объекта, или значение <see langword="null" />, если контекст вызывающего объекта отличается от контекста данного объекта.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="t" /> не является интерфейсом.  
		/// -или- 
		/// Тип недоступен для COM.</exception>
		/// <exception cref="T:System.InvalidCastException">Параметр <paramref name="o" /> не поддерживает запрошенный интерфейс.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="o" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="t" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004189 RID: 16777 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static IntPtr GetComInterfaceForObjectInContext(object o, Type t)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает данные, на которые ссылается заданный ключ из указанного COM-объекта.</summary>
		/// <param name="obj">COM-объект, содержащий требуемые данные.</param>
		/// <param name="key">Ключ во внутренней хэш-таблице <paramref name="obj" /> для извлечения данных.</param>
		/// <returns>Данные, представленные параметром <paramref name="key" /> в параметре <paramref name="obj" /> внутренней хэш-таблице.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="obj" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="obj" /> не является COM-объектом.  
		/// -или- 
		///  <paramref name="obj" /> является объектом Среда выполнения Windows.</exception>
		// Token: 0x0600418A RID: 16778 RVA: 0x000E26D5 File Offset: 0x000E08D5
		public static object GetComObjectData(object obj, object key)
		{
			throw new NotSupportedException("MSDN states user code should never need to call this method.");
		}

		// Token: 0x0600418B RID: 16779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetComSlotForMethodInfoInternal(MemberInfo m);

		/// <summary>Извлекает ячейку таблицы виртуальных функций (VTBL) для указанного типа <see cref="T:System.Reflection.MemberInfo" />, если он предоставлен модели COM.</summary>
		/// <param name="m">Объект, представляющий метод интерфейса.</param>
		/// <returns>Идентификатор <paramref name="m" /> ячейки таблицы виртуальных функций (VTBL), если он предоставлен модели COM.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="m" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="m" /> не является объектом <see cref="T:System.Reflection.MemberInfo" />.  
		/// -или- 
		/// Параметр <paramref name="m" /> не является методом интерфейса.</exception>
		// Token: 0x0600418C RID: 16780 RVA: 0x000E26E4 File Offset: 0x000E08E4
		public static int GetComSlotForMethodInfo(MemberInfo m)
		{
			if (m == null)
			{
				throw new ArgumentNullException("m");
			}
			if (!(m is MethodInfo))
			{
				throw new ArgumentException("The MemberInfo must be an interface method.", "m");
			}
			if (!m.DeclaringType.IsInterface)
			{
				throw new ArgumentException("The MemberInfo must be an interface method.", "m");
			}
			return Marshal.GetComSlotForMethodInfoInternal(m);
		}

		/// <summary>Извлекает последнюю ячейку таблицы виртуальных функций (VTBL) для типа, если он предоставлен модели COM.</summary>
		/// <param name="t">Тип, представляющий интерфейс или класс.</param>
		/// <returns>Последняя ячейка таблицы виртуальных функций (VTBL) интерфейса, если он предоставлен модели COM. Если параметр <paramref name="t" /> является классом, возвращенная ячейка таблицы VTBL будет последней ячейкой для интерфейса, созданного из класса.</returns>
		// Token: 0x0600418D RID: 16781 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static int GetEndComSlot(Type t)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает не зависящее от компьютера описание исключения и сведения о состоянии потоков в момент возникновения исключения.</summary>
		/// <returns>Указатель на структуру EXCEPTION_POINTERS.</returns>
		// Token: 0x0600418E RID: 16782 RVA: 0x000479F8 File Offset: 0x00045BF8
		[ComVisible(true)]
		public static IntPtr GetExceptionPointers()
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает дескриптор экземпляра (HINSTANCE) для указанного модуля.</summary>
		/// <param name="m">Модуль, дескриптор экземпляра (HINSTANCE) которого необходимо получить.</param>
		/// <returns>Дескриптор экземпляра (HINSTANCE) для модуля <paramref name="m" />. Если для этого модуля отсутствует HINSTANCE, этот параметр имеет значение -1.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="m" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600418F RID: 16783 RVA: 0x000E2740 File Offset: 0x000E0940
		public static IntPtr GetHINSTANCE(Module m)
		{
			if (m == null)
			{
				throw new ArgumentNullException("m");
			}
			RuntimeModule runtimeModule = m as RuntimeModule;
			if (runtimeModule != null)
			{
				return RuntimeModule.GetHINSTANCE(runtimeModule.MonoModule);
			}
			return (IntPtr)(-1);
		}

		/// <summary>Извлекает код, определяющий тип возникшего исключения.</summary>
		/// <returns>Тип исключения.</returns>
		// Token: 0x06004190 RID: 16784 RVA: 0x0001B98B File Offset: 0x00019B8B
		public static int GetExceptionCode()
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Преобразует указанное исключение в значение HRESULT.</summary>
		/// <param name="e">Исключение, преобразуемое в значение HRESULT.</param>
		/// <returns>Значение HRESULT, сопоставленное с заданным исключением.</returns>
		// Token: 0x06004191 RID: 16785 RVA: 0x000E2780 File Offset: 0x000E0980
		public static int GetHRForException(Exception e)
		{
			if (e == null)
			{
				return 0;
			}
			ManagedErrorInfo errorInfo = new ManagedErrorInfo(e);
			Marshal.SetErrorInfo(0, errorInfo);
			return e._HResult;
		}

		/// <summary>Возвращает значение HRESULT, соответствующее последней ошибке, вызванной кодом Win32, выполняемым с использованием класса <see cref="T:System.Runtime.InteropServices.Marshal" />.</summary>
		/// <returns>Значение HRESULT, соответствующее последнему коду ошибки Win32.</returns>
		// Token: 0x06004192 RID: 16786 RVA: 0x000479F8 File Offset: 0x00045BF8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int GetHRForLastWin32Error()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004193 RID: 16787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetIDispatchForObjectInternal(object o);

		/// <summary>Возвращает интерфейс IDispatch из управляемого объекта.</summary>
		/// <param name="o">Объект, для которого запрашивается интерфейс <see langword="IDispatch" />.</param>
		/// <returns>Указатель <see langword="IDispatch" /> для параметра <paramref name="o" />.</returns>
		/// <exception cref="T:System.InvalidCastException">Параметр <paramref name="o" /> не поддерживает запрошенный интерфейс.</exception>
		// Token: 0x06004194 RID: 16788 RVA: 0x000E27A7 File Offset: 0x000E09A7
		public static IntPtr GetIDispatchForObject(object o)
		{
			IntPtr idispatchForObjectInternal = Marshal.GetIDispatchForObjectInternal(o);
			Marshal.AddRef(idispatchForObjectInternal);
			return idispatchForObjectInternal;
		}

		/// <summary>Возвращает указатель интерфейса IDispatch из управляемого объекта, если вызывающий объект находится в том же контексте, что и данный объект.</summary>
		/// <param name="o">Объект, для которого запрашивается интерфейс <see langword="IDispatch" />.</param>
		/// <returns>Указатель интерфейса <see langword="IDispatch" /> для указанного объекта или значение <see langword="null" />, если контекст вызывающего объекта отличается от контекста заданного объекта.</returns>
		/// <exception cref="T:System.InvalidCastException">Параметр <paramref name="o" /> не поддерживает запрошенный интерфейс.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="o" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004195 RID: 16789 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static IntPtr GetIDispatchForObjectInContext(object o)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeInfo" /> из управляемого типа.</summary>
		/// <param name="t">Тип, интерфейс <see langword="ITypeInfo" /> которого запрашивается.</param>
		/// <returns>Указатель на интерфейс <see langword="ITypeInfo" /> для параметра <paramref name="t" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="t" /> не является типом, видимым для модели COM.  
		/// -или- 
		///  <paramref name="t" /> относится к типу Среда выполнения Windows.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Библиотека типов зарегистрирована для сборки, содержащей тип, но определение типа не найдено.</exception>
		// Token: 0x06004196 RID: 16790 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static IntPtr GetITypeInfoForType(Type t)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает интерфейс IUnknown из управляемого объекта, если контекст этого объекта совпадает с контекстом вызывающего объекта.</summary>
		/// <param name="o">Объект, для которого запрашивается интерфейс <see langword="IUnknown" />.</param>
		/// <returns>Указатель интерфейса <see langword="IUnknown" /> для указанного объекта или значение <see langword="null" />, если контекст вызывающего объекта отличается от контекста заданного объекта.</returns>
		// Token: 0x06004197 RID: 16791 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static IntPtr GetIUnknownForObjectInContext(object o)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает указатель на функцию, генерируемую в среде выполнения, которая маршалирует вызов из управляемого кода в неуправляемый.</summary>
		/// <param name="pfnMethodToWrap">Указатель на метод, маршалирование которого требуется выполнить.</param>
		/// <param name="pbSignature">Указатель на сигнатуру метода.</param>
		/// <param name="cbSignature">Число байтов в <paramref name="pbSignature" />.</param>
		/// <returns>Указатель на функцию, маршалирующую вызов из параметра <paramref name="pfnMethodToWrap" /> в неуправляемый код.</returns>
		// Token: 0x06004198 RID: 16792 RVA: 0x000479F8 File Offset: 0x00045BF8
		[Obsolete("This method has been deprecated")]
		public static IntPtr GetManagedThunkForUnmanagedMethodPtr(IntPtr pfnMethodToWrap, IntPtr pbSignature, int cbSignature)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает объект <see cref="T:System.Reflection.MemberInfo" /> для указанной ячейки таблицы виртуальных функций (VTBL).</summary>
		/// <param name="t">Тип, для которого извлекается <see cref="T:System.Reflection.MemberInfo" />.</param>
		/// <param name="slot">Ячейка таблицы VTBL.</param>
		/// <param name="memberType">В случае успешного возврата значения содержит одно из значений перечисления, задающее тип элемента.</param>
		/// <returns>Объект, представляющий элемент из указанной ячейки таблицы виртуальных функций (VTBL).</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="t" /> недоступен из COM.</exception>
		// Token: 0x06004199 RID: 16793 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static MemberInfo GetMethodInfoForComSlot(Type t, int slot, ref ComMemberType memberType)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600419A RID: 16794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetIUnknownForObjectInternal(object o);

		/// <summary>Возвращает интерфейс IUnknown из управляемого объекта.</summary>
		/// <param name="o">Объект, для которого запрашивается интерфейс <see langword="IUnknown" />.</param>
		/// <returns>Указатель <see langword="IUnknown" /> для параметра <paramref name="o" />.</returns>
		// Token: 0x0600419B RID: 16795 RVA: 0x000E27B6 File Offset: 0x000E09B6
		public static IntPtr GetIUnknownForObject(object o)
		{
			IntPtr iunknownForObjectInternal = Marshal.GetIUnknownForObjectInternal(o);
			Marshal.AddRef(iunknownForObjectInternal);
			return iunknownForObjectInternal;
		}

		/// <summary>Преобразует объект в COM VARIANT.</summary>
		/// <param name="obj">Объект, для которого нужно получить COM VARIANT.</param>
		/// <param name="pDstNativeVariant">Указатель, получающий тип VARIANT, соответствующий параметру <paramref name="obj" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="obj" /> является экземпляром универсального типа.</exception>
		// Token: 0x0600419C RID: 16796 RVA: 0x000E27C8 File Offset: 0x000E09C8
		public static void GetNativeVariantForObject(object obj, IntPtr pDstNativeVariant)
		{
			Variant structure = default(Variant);
			structure.SetValue(obj);
			Marshal.StructureToPtr<Variant>(structure, pDstNativeVariant, false);
		}

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Преобразует объект заданного типа в COM VARIANT.</summary>
		/// <param name="obj">Объект, для которого нужно получить COM VARIANT.</param>
		/// <param name="pDstNativeVariant">Указатель, получающий тип VARIANT, соответствующий параметру <paramref name="obj" />.</param>
		/// <typeparam name="T">Тип объекта для преобразования.</typeparam>
		// Token: 0x0600419D RID: 16797 RVA: 0x000E27ED File Offset: 0x000E09ED
		public static void GetNativeVariantForObject<T>(T obj, IntPtr pDstNativeVariant)
		{
			Marshal.GetNativeVariantForObject(obj, pDstNativeVariant);
		}

		// Token: 0x0600419E RID: 16798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object GetObjectForCCW(IntPtr pUnk);

		/// <summary>Возвращает экземпляр типа, представляющего COM-объект, с помощью указателя на его интерфейс IUnknown.</summary>
		/// <param name="pUnk">Указатель на интерфейс <see langword="IUnknown" />.</param>
		/// <returns>Объект, представляющий указанный неуправляемый COM-объект.</returns>
		// Token: 0x0600419F RID: 16799 RVA: 0x000E27FC File Offset: 0x000E09FC
		public static object GetObjectForIUnknown(IntPtr pUnk)
		{
			object obj = Marshal.GetObjectForCCW(pUnk);
			if (obj == null)
			{
				obj = ComInteropProxy.GetProxy(pUnk, typeof(__ComObject)).GetTransparentProxy();
			}
			return obj;
		}

		/// <summary>Преобразует COM VARIANT в объект.</summary>
		/// <param name="pSrcNativeVariant">Указатель на COM VARIANT.</param>
		/// <returns>Объект, соответствующий параметру <paramref name="pSrcNativeVariant" />.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidOleVariantTypeException">
		///   <paramref name="pSrcNativeVariant" /> не является допустимым типом VARIANT.</exception>
		/// <exception cref="T:System.NotSupportedException">Тип параметра <paramref name="pSrcNativeVariant" /> не поддерживается.</exception>
		// Token: 0x060041A0 RID: 16800 RVA: 0x000E282C File Offset: 0x000E0A2C
		public static object GetObjectForNativeVariant(IntPtr pSrcNativeVariant)
		{
			return ((Variant)Marshal.PtrToStructure(pSrcNativeVariant, typeof(Variant))).GetValue();
		}

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Преобразует COM VARIANT в объект заданного типа.</summary>
		/// <param name="pSrcNativeVariant">Указатель на COM VARIANT.</param>
		/// <typeparam name="T">Тип, в который требуется преобразовать COM VARIANT.</typeparam>
		/// <returns>Объект указанного типа, соответствующий параметру <paramref name="pSrcNativeVariant" />.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidOleVariantTypeException">
		///   <paramref name="pSrcNativeVariant" /> не является допустимым типом VARIANT.</exception>
		/// <exception cref="T:System.NotSupportedException">Тип параметра <paramref name="pSrcNativeVariant" /> не поддерживается.</exception>
		// Token: 0x060041A1 RID: 16801 RVA: 0x000E2858 File Offset: 0x000E0A58
		public static T GetObjectForNativeVariant<T>(IntPtr pSrcNativeVariant)
		{
			return (T)((object)((Variant)Marshal.PtrToStructure(pSrcNativeVariant, typeof(Variant))).GetValue());
		}

		/// <summary>Преобразует массив типа COM VARIANT в массив объектов.</summary>
		/// <param name="aSrcNativeVariant">Указатель на первый элемент массива типа COM VARIANT.</param>
		/// <param name="cVars">Число объектов типа COM VARIANT в <paramref name="aSrcNativeVariant" />.</param>
		/// <returns>Массив объектов, соответствующий элементу <paramref name="aSrcNativeVariant" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="cVars" /> является отрицательным числом.</exception>
		// Token: 0x060041A2 RID: 16802 RVA: 0x000E2888 File Offset: 0x000E0A88
		public static object[] GetObjectsForNativeVariants(IntPtr aSrcNativeVariant, int cVars)
		{
			if (cVars < 0)
			{
				throw new ArgumentOutOfRangeException("cVars", "cVars cannot be a negative number.");
			}
			object[] array = new object[cVars];
			for (int i = 0; i < cVars; i++)
			{
				array[i] = Marshal.GetObjectForNativeVariant((IntPtr)(aSrcNativeVariant.ToInt64() + (long)(i * Marshal.SizeOf(typeof(Variant)))));
			}
			return array;
		}

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Преобразует массив типа COM VARIANT в массив указанного типа.</summary>
		/// <param name="aSrcNativeVariant">Указатель на первый элемент массива типа COM VARIANT.</param>
		/// <param name="cVars">Число объектов типа COM VARIANT в <paramref name="aSrcNativeVariant" />.</param>
		/// <typeparam name="T">Тип возвращаемого массива.</typeparam>
		/// <returns>Массив объектов <typeparamref name="T" />, соответствующий элементу <paramref name="aSrcNativeVariant" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="cVars" /> является отрицательным числом.</exception>
		// Token: 0x060041A3 RID: 16803 RVA: 0x000E28E4 File Offset: 0x000E0AE4
		public static T[] GetObjectsForNativeVariants<T>(IntPtr aSrcNativeVariant, int cVars)
		{
			if (cVars < 0)
			{
				throw new ArgumentOutOfRangeException("cVars", "cVars cannot be a negative number.");
			}
			T[] array = new T[cVars];
			for (int i = 0; i < cVars; i++)
			{
				array[i] = Marshal.GetObjectForNativeVariant<T>((IntPtr)(aSrcNativeVariant.ToInt64() + (long)(i * Marshal.SizeOf(typeof(Variant)))));
			}
			return array;
		}

		/// <summary>Возвращает первую ячейку в таблице виртуальных функций (VTBL), которая содержит методы, определенные пользователем.</summary>
		/// <param name="t">Тип, представляющий интерфейс.</param>
		/// <returns>Первая ячейка таблицы виртуальных функций (VTBL), содержащая методы, определенные пользователем. Первая ячейка содержит значение 3, если интерфейс основан на интерфейсе IUnknown, или значение 7, если он основан на интерфейсе IDispatch.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="t" /> недоступен из COM.</exception>
		// Token: 0x060041A4 RID: 16804 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static int GetStartComSlot(Type t)
		{
			throw new NotImplementedException();
		}

		/// <summary>Преобразует многослойный файл cookie в соответствующий экземпляр <see cref="T:System.Threading.Thread" />.</summary>
		/// <param name="cookie">Целое число, представляющее многослойный файл cookie.</param>
		/// <returns>Поток, соответствующий параметру <paramref name="cookie" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="cookie" /> равен 0.</exception>
		// Token: 0x060041A5 RID: 16805 RVA: 0x000479F8 File Offset: 0x00045BF8
		[Obsolete("This method has been deprecated")]
		public static Thread GetThreadFromFiberCookie(int cookie)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает управляемый объект указанного типа, представляющий COM-объект.</summary>
		/// <param name="pUnk">Указатель на интерфейс <see langword="IUnknown" /> неуправляемого объекта.</param>
		/// <param name="t">Тип запрашиваемого управляемого класса.</param>
		/// <returns>Экземпляр класса, который соответствует объекту <see cref="T:System.Type" />, представляющему запрошенный неуправляемый COM-объект.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="t" /> не отмечается атрибутом <see cref="T:System.Runtime.InteropServices.ComImportAttribute" />.  
		/// -или- 
		///  <paramref name="t" /> относится к типу Среда выполнения Windows.</exception>
		// Token: 0x060041A6 RID: 16806 RVA: 0x000E2944 File Offset: 0x000E0B44
		public static object GetTypedObjectForIUnknown(IntPtr pUnk, Type t)
		{
			__ComObject _ComObject = (__ComObject)new ComInteropProxy(pUnk, t).GetTransparentProxy();
			foreach (Type type in t.GetInterfaces())
			{
				if ((type.Attributes & TypeAttributes.Import) == TypeAttributes.Import && _ComObject.GetInterface(type) == IntPtr.Zero)
				{
					return null;
				}
			}
			return _ComObject;
		}

		/// <summary>Преобразует неуправляемый объект ITypeInfo в управляемый объект <see cref="T:System.Type" />.</summary>
		/// <param name="piTypeInfo">Интерфейс <see langword="ITypeInfo" /> для маршалирования.</param>
		/// <returns>Управляемый тип, представляющий неуправляемый объект <see langword="ITypeInfo" />.</returns>
		// Token: 0x060041A7 RID: 16807 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static Type GetTypeForITypeInfo(IntPtr piTypeInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает имя типа, представленного объектом ITypeInfo.</summary>
		/// <param name="pTI">Объект, представляющий указатель <see langword="ITypeInfo" />.</param>
		/// <returns>Имя типа, на который указывает параметр <paramref name="pTI" />.</returns>
		// Token: 0x060041A8 RID: 16808 RVA: 0x000479F8 File Offset: 0x00045BF8
		[Obsolete]
		public static string GetTypeInfoName(UCOMITypeInfo pTI)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает идентификатор LIBID библиотеки типов.</summary>
		/// <param name="pTLB">Библиотека типов, идентификатор LIBID которой требуется извлечь.</param>
		/// <returns>Идентификатор LIBID библиотеки типов, на которую указывает параметр <paramref name="pTLB" />.</returns>
		// Token: 0x060041A9 RID: 16809 RVA: 0x000479F8 File Offset: 0x00045BF8
		[Obsolete]
		public static Guid GetTypeLibGuid(UCOMITypeLib pTLB)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает идентификатор LIBID библиотеки типов.</summary>
		/// <param name="typelib">Библиотека типов, идентификатор LIBID которой требуется извлечь.</param>
		/// <returns>Идентификатор LIBID указанной библиотеки типов.</returns>
		// Token: 0x060041AA RID: 16810 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static Guid GetTypeLibGuid(ITypeLib typelib)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает идентификатор библиотеки LIBID, присвоенный библиотеке типов при экспортировании из указанной сборки.</summary>
		/// <param name="asm">Сборка, из которой экспортирована библиотека типов.</param>
		/// <returns>Идентификатор LIBID, присвоенный библиотеке типов при ее экспорте из указанной сборки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asm" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060041AB RID: 16811 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static Guid GetTypeLibGuidForAssembly(Assembly asm)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает идентификатор LCID библиотеки типов.</summary>
		/// <param name="pTLB">Библиотека типов, идентификатор LCID которой требуется извлечь.</param>
		/// <returns>Идентификатор LCID библиотеки типов, на которую указывает параметр <paramref name="pTLB" />.</returns>
		// Token: 0x060041AC RID: 16812 RVA: 0x000479F8 File Offset: 0x00045BF8
		[Obsolete]
		public static int GetTypeLibLcid(UCOMITypeLib pTLB)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает идентификатор LCID библиотеки типов.</summary>
		/// <param name="typelib">Библиотека типов, идентификатор LCID которой требуется извлечь.</param>
		/// <returns>Идентификатор LCID библиотеки типов, на которую указывает параметр <paramref name="typelib" />.</returns>
		// Token: 0x060041AD RID: 16813 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static int GetTypeLibLcid(ITypeLib typelib)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает имя библиотеки типов.</summary>
		/// <param name="pTLB">Библиотека типов, имя которой требуется извлечь.</param>
		/// <returns>Имя библиотеки типов, на которую указывает параметр <paramref name="pTLB" />.</returns>
		// Token: 0x060041AE RID: 16814 RVA: 0x000479F8 File Offset: 0x00045BF8
		[Obsolete]
		public static string GetTypeLibName(UCOMITypeLib pTLB)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает имя библиотеки типов.</summary>
		/// <param name="typelib">Библиотека типов, имя которой требуется извлечь.</param>
		/// <returns>Имя библиотеки типов, на которую указывает параметр <paramref name="typelib" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="typelib" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060041AF RID: 16815 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static string GetTypeLibName(ITypeLib typelib)
		{
			throw new NotImplementedException();
		}

		/// <summary>Извлекает номер версии типа библиотеки, экспортируемой из указанной сборки.</summary>
		/// <param name="inputAssembly">Управляемая сборка.</param>
		/// <param name="majorVersion">Основной номер версии.</param>
		/// <param name="minorVersion">Дополнительный номер версии.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="inputAssembly" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060041B0 RID: 16816 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static void GetTypeLibVersionForAssembly(Assembly inputAssembly, out int majorVersion, out int minorVersion)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает указатель на функцию, генерируемую в среде выполнения, которая маршалирует вызов из неуправляемого кода в управляемый.</summary>
		/// <param name="pfnMethodToWrap">Указатель на метод, маршалирование которого требуется выполнить.</param>
		/// <param name="pbSignature">Указатель на сигнатуру метода.</param>
		/// <param name="cbSignature">Число байтов в <paramref name="pbSignature" />.</param>
		/// <returns>Указатель на функцию, маршалирующую вызов из параметра <paramref name="pfnMethodToWrap" /> в управляемый код.</returns>
		// Token: 0x060041B1 RID: 16817 RVA: 0x000479F8 File Offset: 0x00045BF8
		[Obsolete("This method has been deprecated")]
		public static IntPtr GetUnmanagedThunkForManagedMethodPtr(IntPtr pfnMethodToWrap, IntPtr pbSignature, int cbSignature)
		{
			throw new NotImplementedException();
		}

		/// <summary>Показывает, является ли тип видимым для клиентов COM.</summary>
		/// <param name="t">Тип, для которого требуется проверить видимость для COM.</param>
		/// <returns>Значение <see langword="true" />, если тип видим для COM; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060041B2 RID: 16818 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static bool IsTypeVisibleFromCom(Type t)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вычисляет число байтов в неуправляемой памяти, необходимых для хранения параметров указанного метода.</summary>
		/// <param name="m">Проверяемый метод.</param>
		/// <returns>Число байтов, необходимых для представления параметров метода в неуправляемой памяти.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="m" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="m" /> не является объектом <see cref="T:System.Reflection.MethodInfo" />.</exception>
		// Token: 0x060041B3 RID: 16819 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static int NumParamBytes(MethodInfo m)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает тип, связанный с заданным идентификатором класса (CLSID).</summary>
		/// <param name="clsid">CLSID возвращаемого типа.</param>
		/// <returns>
		///   <see langword="System.__ComObject" /> вне зависимости от того, допустим ли код CLSID.</returns>
		// Token: 0x060041B4 RID: 16820 RVA: 0x0001B98B File Offset: 0x00019B8B
		public static Type GetTypeFromCLSID(Guid clsid)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Извлекает имя типа, представленного объектом ITypeInfo.</summary>
		/// <param name="typeInfo">Объект, представляющий указатель <see langword="ITypeInfo" />.</param>
		/// <returns>Имя типа, на который указывает параметр <paramref name="typeInfo" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="typeInfo" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060041B5 RID: 16821 RVA: 0x0001B98B File Offset: 0x00019B8B
		public static string GetTypeInfoName(ITypeInfo typeInfo)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Создает уникальный объект вызываемой оболочки времени выполнения (RCW) для заданного интерфейса IUnknown.</summary>
		/// <param name="unknown">Управляемый указатель на интерфейс <see langword="IUnknown" />.</param>
		/// <returns>Уникальная оболочка RCW для указанного интерфейса <see langword="IUnknown" />.</returns>
		// Token: 0x060041B6 RID: 16822 RVA: 0x0001B98B File Offset: 0x00019B8B
		public static object GetUniqueObjectForIUnknown(IntPtr unknown)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Показывает, представляет ли указанный объект COM-объект.</summary>
		/// <param name="o">Объект для проверки.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="o" /> является COM-типом. В противном случае значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="o" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060041B7 RID: 16823
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsComObject(object o);

		/// <summary>Возвращает код ошибки, возвращенной последней неуправляемой функцией, вызванной при помощи вызова неуправляемого кода с установленным флагом <see cref="F:System.Runtime.InteropServices.DllImportAttribute.SetLastError" />.</summary>
		/// <returns>Последний код ошибки, заданный вызовом функции SetLastError платформы Win32.</returns>
		// Token: 0x060041B8 RID: 16824
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetLastWin32Error();

		/// <summary>Возвращает смещение поля для неуправляемой формы управляемого класса.</summary>
		/// <param name="t">Тип значения или форматированный ссылочный тип, указывающий управляемый класс. К классу должен применяться <see cref="T:System.Runtime.InteropServices.StructLayoutAttribute" />.</param>
		/// <param name="fieldName">Поле внутри параметра <paramref name="t" />.</param>
		/// <returns>Смещение (в байтах) для параметра <paramref name="fieldName" /> в указанном классе, объявленном вызовом платформы.</returns>
		/// <exception cref="T:System.ArgumentException">Класс не может быть экспортирован как структура, или поле не является публичным. Начиная с версии 2.0 платформы .NET Framework поле может быть закрытым.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="t" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060041B9 RID: 16825
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr OffsetOf(Type t, string fieldName);

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Возвращает смещение поля для неуправляемой формы указанного управляемого класса.</summary>
		/// <param name="fieldName">Имя поля в типе <paramref name="T" />.</param>
		/// <typeparam name="T">Управляемый тип значения или форматированный ссылочный тип. Примените атрибут <see cref="T:System.Runtime.InteropServices.StructLayoutAttribute" /> к классу.</typeparam>
		/// <returns>Смещение (в байтах) для параметра <paramref name="fieldName" /> в указанном классе, объявленном вызовом платформы.</returns>
		// Token: 0x060041BA RID: 16826 RVA: 0x000E29A5 File Offset: 0x000E0BA5
		public static IntPtr OffsetOf<T>(string fieldName)
		{
			return Marshal.OffsetOf(typeof(T), fieldName);
		}

		/// <summary>Выполняет задачи настройки метода за один раз, не вызывая метод.</summary>
		/// <param name="m">Проверяемый метод.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="m" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="m" /> не является объектом <see cref="T:System.Reflection.MethodInfo" />.</exception>
		// Token: 0x060041BB RID: 16827
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Prelink(MethodInfo m);

		/// <summary>Выполняет проверку перед связыванием для всех методов класса.</summary>
		/// <param name="c">Класс, методы которого требуется проверить.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="c" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060041BC RID: 16828
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PrelinkAll(Type c);

		/// <summary>Копирует все символы вплоть до первого пустого из неуправляемой строки ANSI в управляемый объект <see cref="T:System.String" /> и преобразует каждый символ ANSI в Юникод.</summary>
		/// <param name="ptr">Адрес первого символа в неуправляемой строке.</param>
		/// <returns>Управляемая строка, содержащая копию неуправляемой строки ANSI. Если параметр <paramref name="ptr" /> равен <see langword="null" />, метод возвращает пустую строку.</returns>
		// Token: 0x060041BD RID: 16829
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string PtrToStringAnsi(IntPtr ptr);

		/// <summary>Выделяет управляемый объект типа <see cref="T:System.String" />, копирует в него заданное число знаков из неуправляемой строки ANSI и преобразует каждый знак ANSI в Юникод.</summary>
		/// <param name="ptr">Адрес первого символа в неуправляемой строке.</param>
		/// <param name="len">Копируемое количество байтов исходной строки.</param>
		/// <returns>Управляемая строка, содержащая копию собственной строки ANSI, если значение параметра <paramref name="ptr" /> не равно <see langword="null" />. В противном случае, этот метод возвращает значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="len" /> меньше нуля.</exception>
		// Token: 0x060041BE RID: 16830
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string PtrToStringAnsi(IntPtr ptr, int len);

		// Token: 0x060041BF RID: 16831 RVA: 0x000E29B7 File Offset: 0x000E0BB7
		public static string PtrToStringUTF8(IntPtr ptr)
		{
			return Marshal.PtrToStringAnsi(ptr);
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x000E29BF File Offset: 0x000E0BBF
		public static string PtrToStringUTF8(IntPtr ptr, int byteLen)
		{
			return Marshal.PtrToStringAnsi(ptr, byteLen);
		}

		/// <summary>Выделяет управляемый объект <see cref="T:System.String" /> и копирует в него все знаки до первого пустого знака из строки, хранящейся в неуправляемой памяти.</summary>
		/// <param name="ptr">Для платформ Юникода это адрес первого символа Юникода.  
		/// -или- 
		/// Для платформ ANSI это адрес первого символа ANSI.</param>
		/// <returns>Управляемая строка, содержащая копию неуправляемой строки, если значение параметра <paramref name="ptr" /> не равно <see langword="null" />. В противном случае этот метод возвращает значение <see langword="null" />.</returns>
		// Token: 0x060041C1 RID: 16833 RVA: 0x000E29C8 File Offset: 0x000E0BC8
		public static string PtrToStringAuto(IntPtr ptr)
		{
			if (Marshal.SystemDefaultCharSize != 2)
			{
				return Marshal.PtrToStringAnsi(ptr);
			}
			return Marshal.PtrToStringUni(ptr);
		}

		/// <summary>Выделяет управляемый объект <see cref="T:System.String" /> и копирует в него заданное число знаков из строки, сохраненной в неуправляемой памяти.</summary>
		/// <param name="ptr">Для платформ Юникода это адрес первого символа Юникода.  
		/// -или- 
		/// Для платформ ANSI это адрес первого символа ANSI.</param>
		/// <param name="len">Число символов для копирования.</param>
		/// <returns>Управляемая строка, хранящая копию исходной строки, если значение параметра <paramref name="ptr" /> не равно нулю <see langword="null" />; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="len" /> меньше нуля.</exception>
		// Token: 0x060041C2 RID: 16834 RVA: 0x000E29DF File Offset: 0x000E0BDF
		public static string PtrToStringAuto(IntPtr ptr, int len)
		{
			if (Marshal.SystemDefaultCharSize != 2)
			{
				return Marshal.PtrToStringAnsi(ptr, len);
			}
			return Marshal.PtrToStringUni(ptr, len);
		}

		/// <summary>Выделяет управляемый объект <see cref="T:System.String" /> и копирует в него все знаки до первого пустого знака из неуправляемой строки Юникода.</summary>
		/// <param name="ptr">Адрес первого символа в неуправляемой строке.</param>
		/// <returns>Управляемая строка, содержащая копию неуправляемой строки, если значение параметра <paramref name="ptr" /> не равно <see langword="null" />. В противном случае этот метод возвращает значение <see langword="null" />.</returns>
		// Token: 0x060041C3 RID: 16835
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string PtrToStringUni(IntPtr ptr);

		/// <summary>Выделяет управляемый объект <see cref="T:System.String" /> и копирует в него заданное число знаков неуправляемой строки Юникода.</summary>
		/// <param name="ptr">Адрес первого символа в неуправляемой строке.</param>
		/// <param name="len">Число копируемых символов Юникода.</param>
		/// <returns>Управляемая строка, содержащая копию неуправляемой строки, если значение параметра <paramref name="ptr" /> не равно <see langword="null" />. В противном случае этот метод возвращает значение <see langword="null" />.</returns>
		// Token: 0x060041C4 RID: 16836
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string PtrToStringUni(IntPtr ptr, int len);

		/// <summary>Выделяет управляемый объект <see cref="T:System.String" /> и копирует в него двоичную строку (BSTR), хранящуюся в неуправляемой памяти.</summary>
		/// <param name="ptr">Адрес первого символа в неуправляемой строке.</param>
		/// <returns>Управляемая строка, содержащая копию неуправляемой строки.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="ptr" /> равняется <see cref="F:System.IntPtr.Zero" />.</exception>
		// Token: 0x060041C5 RID: 16837
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string PtrToStringBSTR(IntPtr ptr);

		/// <summary>Маршалирует данные из неуправляемого блока памяти в управляемый объект.</summary>
		/// <param name="ptr">Указатель на неуправляемый блок памяти.</param>
		/// <param name="structure">Объект, в который копируются данные. Он должен представлять собой экземпляр форматированного класса.</param>
		/// <exception cref="T:System.ArgumentException">Распределение структуры не является ни последовательным, ни явным.  
		/// -или- 
		/// Структура принадлежит к упакованному типу значений.</exception>
		// Token: 0x060041C6 RID: 16838
		[ComVisible(true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PtrToStructure(IntPtr ptr, object structure);

		/// <summary>Маршалирует данные из неуправляемого блока памяти во вновь выделенный управляемый объект указанного типа.</summary>
		/// <param name="ptr">Указатель на неуправляемый блок памяти.</param>
		/// <param name="structureType">Тип создаваемого объекта. Этот объект должен представлять форматированный класс или структуру.</param>
		/// <returns>Управляемый объект, содержащий данные, на которые указывает параметр <paramref name="ptr" />.</returns>
		/// <exception cref="T:System.ArgumentException">Распределения параметра <paramref name="structureType" />не является ни последовательным, ни явным.  
		/// -или- 
		/// Параметр <paramref name="structureType" /> является определением универсального типа.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="structureType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">Класс, Указанный <paramref name="structureType" /> не имеет доступного конструктора по умолчанию.</exception>
		// Token: 0x060041C7 RID: 16839
		[ComVisible(true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object PtrToStructure(IntPtr ptr, Type structureType);

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Выполняет маршалирование данных из неуправляемого блока памяти в управляемый объекта указанного типа.</summary>
		/// <param name="ptr">Указатель на неуправляемый блок памяти.</param>
		/// <param name="structure">Объект, в который копируются данные.</param>
		/// <typeparam name="T">Тип параметра <paramref name="structure" />. Этот должен быть форматированный класс.</typeparam>
		/// <exception cref="T:System.ArgumentException">Распределение структуры не является ни последовательным, ни явным.</exception>
		// Token: 0x060041C8 RID: 16840 RVA: 0x000E29F8 File Offset: 0x000E0BF8
		public static void PtrToStructure<T>(IntPtr ptr, T structure)
		{
			Marshal.PtrToStructure(ptr, structure);
		}

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Маршалирует данные из неуправляемого блока памяти во вновь выделенный управляемый объект типа, указанного параметром универсального типа.</summary>
		/// <param name="ptr">Указатель на неуправляемый блок памяти.</param>
		/// <typeparam name="T">Тип объекта, в который копируются данные. Это должен быть форматированный класс или структура.</typeparam>
		/// <returns>Управляемый объект, содержащий данные, на которые указывает параметр <paramref name="ptr" />.</returns>
		/// <exception cref="T:System.ArgumentException">Макет <typeparamref name="T" /> не является ни последовательным, ни явным.</exception>
		/// <exception cref="T:System.MissingMethodException">Класс, Указанный <typeparamref name="T" /> не имеет доступного конструктора по умолчанию.</exception>
		// Token: 0x060041C9 RID: 16841 RVA: 0x000E2A06 File Offset: 0x000E0C06
		public static T PtrToStructure<T>(IntPtr ptr)
		{
			return (T)((object)Marshal.PtrToStructure(ptr, typeof(T)));
		}

		// Token: 0x060041CA RID: 16842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int QueryInterfaceInternal(IntPtr pUnk, ref Guid iid, out IntPtr ppv);

		/// <summary>Запрашивает указатель на заданный интерфейс из COM-объекта.</summary>
		/// <param name="pUnk">Запрашиваемый интерфейс.</param>
		/// <param name="iid">Идентификатор IID запрошенного интерфейса.</param>
		/// <param name="ppv">Когда этот метод возвращает результаты, в них содержится ссылка на возвращенный интерфейс.</param>
		/// <returns>Значение HRESULT, показывающее, успешно ли выполнен вызов.</returns>
		// Token: 0x060041CB RID: 16843 RVA: 0x000E2A1D File Offset: 0x000E0C1D
		public static int QueryInterface(IntPtr pUnk, ref Guid iid, out IntPtr ppv)
		{
			if (pUnk == IntPtr.Zero)
			{
				throw new ArgumentNullException("pUnk");
			}
			return Marshal.QueryInterfaceInternal(pUnk, ref iid, out ppv);
		}

		/// <summary>Считывает один байт из неуправляемой памяти.</summary>
		/// <param name="ptr">Адрес неуправляемой памяти, откуда производится чтение.</param>
		/// <returns>Байт, считанный из неуправляемой памяти.</returns>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> не является распознаваемым форматом.  
		/// -или- 
		///  Свойство <paramref name="ptr" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="ptr" /> недопустим.</exception>
		// Token: 0x060041CC RID: 16844 RVA: 0x000E2A3F File Offset: 0x000E0C3F
		public unsafe static byte ReadByte(IntPtr ptr)
		{
			return *(byte*)((void*)ptr);
		}

		/// <summary>Считывает один байт с указанным смещением (или индексом) из неуправляемой памяти.</summary>
		/// <param name="ptr">Базовый адрес в неуправляемой памяти, относительно которого выполняется чтение.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед чтением.</param>
		/// <returns>Байт, считываемый из неуправляемой памяти с указанным смещением.</returns>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		// Token: 0x060041CD RID: 16845 RVA: 0x000E2A48 File Offset: 0x000E0C48
		public unsafe static byte ReadByte(IntPtr ptr, int ofs)
		{
			return ((byte*)((void*)ptr))[ofs];
		}

		/// <summary>Считывает один байт с указанным смещением (или индексом) из неуправляемой памяти.</summary>
		/// <param name="ptr">Базовый адрес в неуправляемой памяти исходного объекта.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед чтением.</param>
		/// <returns>Байт, считываемый из неуправляемой памяти с указанным смещением.</returns>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ptr" /> является объектом <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />. Этот метод не принимает параметры <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</exception>
		// Token: 0x060041CE RID: 16846 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SuppressUnmanagedCodeSecurity]
		public static byte ReadByte([MarshalAs(UnmanagedType.AsAny)] [In] object ptr, int ofs)
		{
			throw new NotImplementedException();
		}

		/// <summary>Считывает из неуправляемой памяти 16-битное целое число со знаком.</summary>
		/// <param name="ptr">Адрес неуправляемой памяти, откуда производится чтение.</param>
		/// <returns>16-битное целое число со знаком, считанное из неуправляемой памяти.</returns>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> не является распознаваемым форматом.  
		/// -или- 
		///  Свойство <paramref name="ptr" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="ptr" /> недопустим.</exception>
		// Token: 0x060041CF RID: 16847 RVA: 0x000E2A54 File Offset: 0x000E0C54
		public unsafe static short ReadInt16(IntPtr ptr)
		{
			byte* ptr2 = (byte*)((void*)ptr);
			if ((ptr2 & 1U) == 0U)
			{
				return *(short*)ptr2;
			}
			short result;
			Buffer.Memcpy((byte*)(&result), (byte*)((void*)ptr), 2, true);
			return result;
		}

		/// <summary>Считывает из неуправляемой памяти с указанным смещением 16-битное целое число со знаком.</summary>
		/// <param name="ptr">Базовый адрес в неуправляемой памяти, относительно которого выполняется чтение.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед чтением.</param>
		/// <returns>16-битное целое число со знаком, считанное из неуправляемой памяти с указанным смещением.</returns>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		// Token: 0x060041D0 RID: 16848 RVA: 0x000E2A84 File Offset: 0x000E0C84
		public unsafe static short ReadInt16(IntPtr ptr, int ofs)
		{
			byte* ptr2 = (byte*)((void*)ptr) + ofs;
			if ((ptr2 & 1U) == 0U)
			{
				return *(short*)ptr2;
			}
			short result;
			Buffer.Memcpy((byte*)(&result), ptr2, 2, true);
			return result;
		}

		/// <summary>Считывает из неуправляемой памяти с указанным смещением 16-битное целое число со знаком.</summary>
		/// <param name="ptr">Базовый адрес в неуправляемой памяти исходного объекта.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед чтением.</param>
		/// <returns>16-битное целое число со знаком, считанное из неуправляемой памяти с указанным смещением.</returns>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ptr" /> является объектом <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />. Этот метод не принимает параметры <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</exception>
		// Token: 0x060041D1 RID: 16849 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SuppressUnmanagedCodeSecurity]
		public static short ReadInt16([MarshalAs(UnmanagedType.AsAny)] [In] object ptr, int ofs)
		{
			throw new NotImplementedException();
		}

		/// <summary>Считывает из неуправляемой памяти 32-битное целое число со знаком.</summary>
		/// <param name="ptr">Адрес неуправляемой памяти, откуда производится чтение.</param>
		/// <returns>32-битное целое число со знаком, считанное из неуправляемой памяти.</returns>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> не является распознаваемым форматом.  
		/// -или- 
		///  Свойство <paramref name="ptr" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="ptr" /> недопустим.</exception>
		// Token: 0x060041D2 RID: 16850 RVA: 0x000E2AB0 File Offset: 0x000E0CB0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public unsafe static int ReadInt32(IntPtr ptr)
		{
			byte* ptr2 = (byte*)((void*)ptr);
			if ((ptr2 & 3U) == 0U)
			{
				return *(int*)ptr2;
			}
			int result;
			Buffer.Memcpy((byte*)(&result), ptr2, 4, true);
			return result;
		}

		/// <summary>Считывает из неуправляемой памяти с указанным смещением 32-битное целое число со знаком.</summary>
		/// <param name="ptr">Базовый адрес в неуправляемой памяти, относительно которого выполняется чтение.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед чтением.</param>
		/// <returns>32-битное целое число со знаком, считанное из неуправляемой памяти.</returns>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		// Token: 0x060041D3 RID: 16851 RVA: 0x000E2ADC File Offset: 0x000E0CDC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public unsafe static int ReadInt32(IntPtr ptr, int ofs)
		{
			byte* ptr2 = (byte*)((void*)ptr) + ofs;
			if ((ptr2 & 3) == 0)
			{
				return *(int*)ptr2;
			}
			int result;
			Buffer.Memcpy((byte*)(&result), ptr2, 4, true);
			return result;
		}

		/// <summary>Считывает из неуправляемой памяти с указанным смещением 32-битное целое число со знаком.</summary>
		/// <param name="ptr">Базовый адрес в неуправляемой памяти исходного объекта.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед чтением.</param>
		/// <returns>32-битное целое число со знаком, считанное из неуправляемой памяти с указанным смещением.</returns>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ptr" /> является объектом <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />. Этот метод не принимает параметры <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</exception>
		// Token: 0x060041D4 RID: 16852 RVA: 0x000479F8 File Offset: 0x00045BF8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SuppressUnmanagedCodeSecurity]
		public static int ReadInt32([MarshalAs(UnmanagedType.AsAny)] [In] object ptr, int ofs)
		{
			throw new NotImplementedException();
		}

		/// <summary>Считывает из неуправляемой памяти 64-битное целое число со знаком.</summary>
		/// <param name="ptr">Адрес неуправляемой памяти, откуда производится чтение.</param>
		/// <returns>64-битное целое число со знаком, считанное из неуправляемой памяти.</returns>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> не является распознаваемым форматом.  
		/// -или- 
		///  Свойство <paramref name="ptr" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="ptr" /> недопустим.</exception>
		// Token: 0x060041D5 RID: 16853 RVA: 0x000E2B08 File Offset: 0x000E0D08
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public unsafe static long ReadInt64(IntPtr ptr)
		{
			byte* ptr2 = (byte*)((void*)ptr);
			if ((ptr2 & 7U) == 0U)
			{
				return *(long*)((void*)ptr);
			}
			long result;
			Buffer.Memcpy((byte*)(&result), ptr2, 8, true);
			return result;
		}

		/// <summary>Считывает из неуправляемой памяти с указанным смещением 64-битное целое число со знаком.</summary>
		/// <param name="ptr">Базовый адрес в неуправляемой памяти, относительно которого выполняется чтение.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед чтением.</param>
		/// <returns>64-битное целое число со знаком, считанное из неуправляемой памяти с указанным смещением.</returns>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		// Token: 0x060041D6 RID: 16854 RVA: 0x000E2B38 File Offset: 0x000E0D38
		public unsafe static long ReadInt64(IntPtr ptr, int ofs)
		{
			byte* ptr2 = (byte*)((void*)ptr) + ofs;
			if ((ptr2 & 7U) == 0U)
			{
				return *(long*)ptr2;
			}
			long result;
			Buffer.Memcpy((byte*)(&result), ptr2, 8, true);
			return result;
		}

		/// <summary>Считывает из неуправляемой памяти с указанным смещением 64-битное целое число со знаком.</summary>
		/// <param name="ptr">Базовый адрес в неуправляемой памяти исходного объекта.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед чтением.</param>
		/// <returns>64-битное целое число со знаком, считанное из неуправляемой памяти с указанным смещением.</returns>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ptr" /> является объектом <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />. Этот метод не принимает параметры <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</exception>
		// Token: 0x060041D7 RID: 16855 RVA: 0x000479F8 File Offset: 0x00045BF8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SuppressUnmanagedCodeSecurity]
		public static long ReadInt64([MarshalAs(UnmanagedType.AsAny)] [In] object ptr, int ofs)
		{
			throw new NotImplementedException();
		}

		/// <summary>Считывает из неуправляемой памяти целое число, разрядность которого соответствует собственной разрядности процессора.</summary>
		/// <param name="ptr">Адрес неуправляемой памяти, откуда производится чтение.</param>
		/// <returns>Целое число, считанное из неуправляемой памяти. На 32-разрядных компьютерах возвращается 32-битное целое число, а на 64-разрядных компьютерах — 64-битное.</returns>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> не является распознаваемым форматом.  
		/// -или- 
		///  Свойство <paramref name="ptr" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="ptr" /> недопустим.</exception>
		// Token: 0x060041D8 RID: 16856 RVA: 0x000E2B63 File Offset: 0x000E0D63
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static IntPtr ReadIntPtr(IntPtr ptr)
		{
			if (IntPtr.Size == 4)
			{
				return (IntPtr)Marshal.ReadInt32(ptr);
			}
			return (IntPtr)Marshal.ReadInt64(ptr);
		}

		/// <summary>Считывает из неуправляемой памяти с указанным смещением знаковое целое число, разрядность которого соответствует собственной разрядности процессора.</summary>
		/// <param name="ptr">Базовый адрес в неуправляемой памяти, относительно которого выполняется чтение.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед чтением.</param>
		/// <returns>Целое число, считываемое из неуправляемой памяти с указанным смещением.</returns>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		// Token: 0x060041D9 RID: 16857 RVA: 0x000E2B84 File Offset: 0x000E0D84
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static IntPtr ReadIntPtr(IntPtr ptr, int ofs)
		{
			if (IntPtr.Size == 4)
			{
				return (IntPtr)Marshal.ReadInt32(ptr, ofs);
			}
			return (IntPtr)Marshal.ReadInt64(ptr, ofs);
		}

		/// <summary>Считывает из неуправляемой памяти целое число, разрядность которого соответствует собственной разрядности процессора.</summary>
		/// <param name="ptr">Базовый адрес в неуправляемой памяти исходного объекта.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед чтением.</param>
		/// <returns>Целое число, считываемое из неуправляемой памяти с указанным смещением.</returns>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ptr" /> является объектом <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />. Этот метод не принимает параметры <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</exception>
		// Token: 0x060041DA RID: 16858 RVA: 0x000479F8 File Offset: 0x00045BF8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static IntPtr ReadIntPtr([MarshalAs(UnmanagedType.AsAny)] [In] object ptr, int ofs)
		{
			throw new NotImplementedException();
		}

		/// <summary>Изменяет размер блока памяти, предварительно выделенной с использованием <see cref="M:System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Int32)" />.</summary>
		/// <param name="pv">Указатель на память, выделенную с использованием <see cref="M:System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Int32)" />.</param>
		/// <param name="cb">Новый размер выделенного блока.</param>
		/// <returns>Целое число, представляющее адрес повторно выделенного блока памяти. Освобождать эту память необходимо с помощью метода <see cref="M:System.Runtime.InteropServices.Marshal.FreeCoTaskMem(System.IntPtr)" />.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно памяти для выполнения запроса.</exception>
		// Token: 0x060041DB RID: 16859
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr ReAllocCoTaskMem(IntPtr pv, int cb);

		/// <summary>Изменяет размер блока памяти, предварительно выделенной с использованием <see cref="M:System.Runtime.InteropServices.Marshal.AllocHGlobal(System.IntPtr)" />.</summary>
		/// <param name="pv">Указатель на память, выделенную с использованием <see cref="M:System.Runtime.InteropServices.Marshal.AllocHGlobal(System.IntPtr)" />.</param>
		/// <param name="cb">Новый размер выделенного блока. Это не указатель; это запрашиваемое число байтов, приведенное к типу <see cref="T:System.IntPtr" />. Если передается указатель, он рассматривается как размер.</param>
		/// <returns>Указатель на повторно выделенную память. Эта память должна освобождаться с помощью <see cref="M:System.Runtime.InteropServices.Marshal.FreeHGlobal(System.IntPtr)" />.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно памяти для выполнения запроса.</exception>
		// Token: 0x060041DC RID: 16860
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr ReAllocHGlobal(IntPtr pv, IntPtr cb);

		// Token: 0x060041DD RID: 16861
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int ReleaseInternal(IntPtr pUnk);

		/// <summary>Уменьшает счетчик ссылок для указанного интерфейса.</summary>
		/// <param name="pUnk">Освобождаемый интерфейс.</param>
		/// <returns>Новое значение счетчика ссылок для интерфейса, заданного параметром <paramref name="pUnk" />.</returns>
		// Token: 0x060041DE RID: 16862 RVA: 0x000E2BA7 File Offset: 0x000E0DA7
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int Release(IntPtr pUnk)
		{
			if (pUnk == IntPtr.Zero)
			{
				throw new ArgumentNullException("pUnk");
			}
			return Marshal.ReleaseInternal(pUnk);
		}

		// Token: 0x060041DF RID: 16863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int ReleaseComObjectInternal(object co);

		/// <summary>Уменьшает счетчик ссылок вызываемой оболочки времени выполнения (RCW), связанной с указанным COM-объектом.</summary>
		/// <param name="o">Освобождаемый COM-объект.</param>
		/// <returns>Новое значение счетчика ссылок оболочки RCW, связанной с <paramref name="o" />. Это значение обычно равно нулю, поскольку оболочка RCW хранит только одну ссылку на COM-объект в оболочке вне зависимости от количества управляемых клиентов, которые ее вызывают.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="o" /> не является допустимым COM-объектом.</exception>
		/// <exception cref="T:System.NullReferenceException">Свойство <paramref name="o" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060041E0 RID: 16864 RVA: 0x000E2BC7 File Offset: 0x000E0DC7
		public static int ReleaseComObject(object o)
		{
			if (o == null)
			{
				throw new ArgumentException("Value cannot be null.", "o");
			}
			if (!Marshal.IsComObject(o))
			{
				throw new ArgumentException("Value must be a Com object.", "o");
			}
			return Marshal.ReleaseComObjectInternal(o);
		}

		/// <summary>Освобождает кэш потока.</summary>
		// Token: 0x060041E1 RID: 16865 RVA: 0x000479F8 File Offset: 0x00045BF8
		[Obsolete]
		public static void ReleaseThreadCache()
		{
			throw new NotImplementedException();
		}

		/// <summary>Определяет данные, на которые ссылается заданный ключ в указанном COM-объекте.</summary>
		/// <param name="obj">COM-объект для хранения данных.</param>
		/// <param name="key">Ключ во внутренней хэш-таблице COM-объекта, в котором хранятся данные.</param>
		/// <param name="data">Задаваемые данные.</param>
		/// <returns>Значение <see langword="true" />, если данные заданы успешно; в противном случае значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="obj" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="obj" /> не является COM-объектом.  
		/// -или- 
		///  <paramref name="obj" /> является объектом Среда выполнения Windows.</exception>
		// Token: 0x060041E2 RID: 16866 RVA: 0x000E26D5 File Offset: 0x000E08D5
		public static bool SetComObjectData(object obj, object key, object data)
		{
			throw new NotSupportedException("MSDN states user code should never need to call this method.");
		}

		/// <summary>Возвращает неуправляемый размер объекта в байтах.</summary>
		/// <param name="structure">Объект, размер которого возвращается.</param>
		/// <returns>Размер указанного объекта в неуправляемом коде.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="structure" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060041E3 RID: 16867 RVA: 0x000E2BFA File Offset: 0x000E0DFA
		[ComVisible(true)]
		public static int SizeOf(object structure)
		{
			return Marshal.SizeOf(structure.GetType());
		}

		/// <summary>Возвращает размер неуправляемого типа в байтах.</summary>
		/// <param name="t">Тип, размер которого возвращается.</param>
		/// <returns>Размер указанного типа в неуправляемом коде.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="t" /> является определением универсального типа.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="t" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060041E4 RID: 16868
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int SizeOf(Type t);

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Возвращает размер неуправляемого типа в байтах.</summary>
		/// <typeparam name="T">Тип, размер которого возвращается.</typeparam>
		/// <returns>Размер, в байтах, типа, определяемого параметром универсального типа <typeparamref name="T" />.</returns>
		// Token: 0x060041E5 RID: 16869 RVA: 0x000E2C07 File Offset: 0x000E0E07
		public static int SizeOf<T>()
		{
			return Marshal.SizeOf(typeof(T));
		}

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Возвращает неуправляемый размер объекта указанного типа в байтах.</summary>
		/// <param name="structure">Объект, размер которого возвращается.</param>
		/// <typeparam name="T">Тип параметра <paramref name="structure" />.</typeparam>
		/// <returns>Размер в байтах указанного объекта в неуправляемом коде.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="structure" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060041E6 RID: 16870 RVA: 0x000E2C18 File Offset: 0x000E0E18
		public static int SizeOf<T>(T structure)
		{
			return Marshal.SizeOf(structure.GetType());
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x000E2C2C File Offset: 0x000E0E2C
		internal static uint SizeOfType(Type type)
		{
			return (uint)Marshal.SizeOf(type);
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x000E2C34 File Offset: 0x000E0E34
		internal static uint AlignedSizeOf<T>() where T : struct
		{
			uint num = Marshal.SizeOfType(typeof(T));
			if (num == 1U || num == 2U)
			{
				return num;
			}
			if (IntPtr.Size == 8 && num == 4U)
			{
				return num;
			}
			return num + 3U & 4294967292U;
		}

		/// <summary>Выделяет строку BSTR и копирует в нее содержимое управляемого объекта <see cref="T:System.String" />.</summary>
		/// <param name="s">Копируемая управляемая строка.</param>
		/// <returns>Неуправляемый указатель на строку <see langword="BSTR" /> или значение 0, если параметр <paramref name="s" /> имеет значение null.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина параметра <paramref name="s" /> выходит за пределы диапазона.</exception>
		// Token: 0x060041E9 RID: 16873 RVA: 0x000E2C70 File Offset: 0x000E0E70
		public unsafe static IntPtr StringToBSTR(string s)
		{
			if (s == null)
			{
				return IntPtr.Zero;
			}
			char* ptr = s;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return Marshal.BufferToBSTR(ptr, s.Length);
		}

		/// <summary>Копирует содержимое управляемого объекта типа <see cref="T:System.String" /> в блок памяти, выделенный из неуправляемого распределителя памяти для COM-задач.</summary>
		/// <param name="s">Копируемая управляемая строка.</param>
		/// <returns>Целое число, представляющее указатель на блок памяти, выделенный для строки, или значение 0, если строка <paramref name="s" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="s" /> превышает максимальную длину, разрешенную операционной системой.</exception>
		// Token: 0x060041EA RID: 16874 RVA: 0x000E2CA2 File Offset: 0x000E0EA2
		public static IntPtr StringToCoTaskMemAnsi(string s)
		{
			return Marshal.StringToAllocatedMemoryUTF8(s);
		}

		/// <summary>Копирует содержимое управляемого объекта типа <see cref="T:System.String" /> в блок памяти, выделенный из неуправляемого распределителя памяти для COM-задач.</summary>
		/// <param name="s">Копируемая управляемая строка.</param>
		/// <returns>Выделенный блок памяти или значение 0, если строка <paramref name="s" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина параметра <paramref name="s" /> выходит за пределы диапазона.</exception>
		// Token: 0x060041EB RID: 16875 RVA: 0x000E2CAA File Offset: 0x000E0EAA
		public static IntPtr StringToCoTaskMemAuto(string s)
		{
			if (Marshal.SystemDefaultCharSize != 2)
			{
				return Marshal.StringToCoTaskMemAnsi(s);
			}
			return Marshal.StringToCoTaskMemUni(s);
		}

		/// <summary>Копирует содержимое управляемого объекта типа <see cref="T:System.String" /> в блок памяти, выделенный из неуправляемого распределителя памяти для COM-задач.</summary>
		/// <param name="s">Копируемая управляемая строка.</param>
		/// <returns>Целое число, представляющее указатель на блок памяти, выделенный для строки, или значение 0, если строка s имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="s" /> превышает максимальную длину, разрешенную операционной системой.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		// Token: 0x060041EC RID: 16876 RVA: 0x000E2CC4 File Offset: 0x000E0EC4
		public static IntPtr StringToCoTaskMemUni(string s)
		{
			int num = s.Length + 1;
			IntPtr intPtr = Marshal.AllocCoTaskMem(num * 2);
			char[] array = new char[num];
			s.CopyTo(0, array, 0, s.Length);
			array[s.Length] = '\0';
			Marshal.copy_to_unmanaged(array, 0, intPtr, num);
			return intPtr;
		}

		// Token: 0x060041ED RID: 16877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr StringToHGlobalAnsi(char* s, int length);

		/// <summary>Копирует содержимое управляемого объекта <see cref="T:System.String" /> в неуправляемую память, преобразуя его по мере копирования в формат ANSI.</summary>
		/// <param name="s">Копируемая управляемая строка.</param>
		/// <returns>Адрес в неуправляемой памяти, куда скопирована строка <paramref name="s" />, или значение 0, если строка <paramref name="s" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="s" /> превышает максимальную длину, разрешенную операционной системой.</exception>
		// Token: 0x060041EE RID: 16878 RVA: 0x000E2D0C File Offset: 0x000E0F0C
		public unsafe static IntPtr StringToHGlobalAnsi(string s)
		{
			char* ptr = s;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return Marshal.StringToHGlobalAnsi(ptr, (s != null) ? s.Length : 0);
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x000E2D3C File Offset: 0x000E0F3C
		public unsafe static IntPtr StringToAllocatedMemoryUTF8(string s)
		{
			if (s == null)
			{
				return IntPtr.Zero;
			}
			int num = (s.Length + 1) * 3;
			if (num < s.Length)
			{
				throw new ArgumentOutOfRangeException("s");
			}
			IntPtr intPtr = Marshal.AllocCoTaskMemSize(new UIntPtr((uint)(num + 1)));
			if (intPtr == IntPtr.Zero)
			{
				throw new OutOfMemoryException();
			}
			byte* ptr = (byte*)((void*)intPtr);
			fixed (string text = s)
			{
				char* ptr2 = text;
				if (ptr2 != null)
				{
					ptr2 += RuntimeHelpers.OffsetToStringData / 2;
				}
				int bytes = Encoding.UTF8.GetBytes(ptr2, s.Length, ptr, num);
				ptr[bytes] = 0;
			}
			return intPtr;
		}

		/// <summary>Копирует содержимое управляемого объекта типа <see cref="T:System.String" /> в неуправляемую память, преобразуя его по мере копирования в формат ANSI, если это требуется.</summary>
		/// <param name="s">Копируемая управляемая строка.</param>
		/// <returns>Адрес в неуправляемой памяти, куда скопирована строка, или значение 0, если строка <paramref name="s" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		// Token: 0x060041F0 RID: 16880 RVA: 0x000E2DC5 File Offset: 0x000E0FC5
		public static IntPtr StringToHGlobalAuto(string s)
		{
			if (Marshal.SystemDefaultCharSize != 2)
			{
				return Marshal.StringToHGlobalAnsi(s);
			}
			return Marshal.StringToHGlobalUni(s);
		}

		// Token: 0x060041F1 RID: 16881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr StringToHGlobalUni(char* s, int length);

		/// <summary>Копирует содержимое управляемого объекта <see cref="T:System.String" /> в неуправляемую память.</summary>
		/// <param name="s">Копируемая управляемая строка.</param>
		/// <returns>Адрес в неуправляемой памяти, куда скопирована строка <paramref name="s" />, или значение 0, если строка <paramref name="s" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Метод не может выделить в куче достаточное количество динамической памяти, присущей данному объекту.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="s" /> превышает максимальную длину, разрешенную операционной системой.</exception>
		// Token: 0x060041F2 RID: 16882 RVA: 0x000E2DDC File Offset: 0x000E0FDC
		public unsafe static IntPtr StringToHGlobalUni(string s)
		{
			char* ptr = s;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return Marshal.StringToHGlobalUni(ptr, (s != null) ? s.Length : 0);
		}

		/// <summary>Выделяет неуправляемую двоичную строку (BSTR) и копирует в нее содержимое управляемого объекта <see cref="T:System.Security.SecureString" />.</summary>
		/// <param name="s">Управляемый объект, подлежащий копированию.</param>
		/// <returns>Адрес в неуправляемой памяти, куда скопирован параметр <paramref name="s" />, или 0, если передан пустой объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий компьютер не работает под управлением Windows 2000 с пакетом обновления 3 (SP3) или более поздней версии.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		// Token: 0x060041F3 RID: 16883 RVA: 0x000E2E0C File Offset: 0x000E100C
		public unsafe static IntPtr SecureStringToBSTR(SecureString s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			byte[] buffer = s.GetBuffer();
			int length = s.Length;
			if (BitConverter.IsLittleEndian)
			{
				for (int i = 0; i < buffer.Length; i += 2)
				{
					byte b = buffer[i];
					buffer[i] = buffer[i + 1];
					buffer[i + 1] = b;
				}
			}
			byte[] array;
			byte* ptr;
			if ((array = buffer) == null || array.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &array[0];
			}
			return Marshal.BufferToBSTR((char*)ptr, length);
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x000E2E81 File Offset: 0x000E1081
		internal static IntPtr SecureStringCoTaskMemAllocator(int len)
		{
			return Marshal.AllocCoTaskMem(len);
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x000E2E89 File Offset: 0x000E1089
		internal static IntPtr SecureStringGlobalAllocator(int len)
		{
			return Marshal.AllocHGlobal(len);
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x000E2E94 File Offset: 0x000E1094
		internal static IntPtr SecureStringToAnsi(SecureString s, Marshal.SecureStringAllocator allocator)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			int length = s.Length;
			IntPtr intPtr = allocator(length + 1);
			byte[] array = new byte[length + 1];
			try
			{
				byte[] buffer = s.GetBuffer();
				int i = 0;
				int num = 0;
				while (i < length)
				{
					array[i] = buffer[num + 1];
					buffer[num] = 0;
					buffer[num + 1] = 0;
					i++;
					num += 2;
				}
				array[i] = 0;
				Marshal.copy_to_unmanaged(array, 0, intPtr, length + 1);
			}
			finally
			{
				int j = length;
				while (j > 0)
				{
					j--;
					array[j] = 0;
				}
			}
			return intPtr;
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x000E2F38 File Offset: 0x000E1138
		internal static IntPtr SecureStringToUnicode(SecureString s, Marshal.SecureStringAllocator allocator)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			int length = s.Length;
			IntPtr intPtr = allocator(length * 2 + 2);
			byte[] array = null;
			try
			{
				array = s.GetBuffer();
				for (int i = 0; i < length; i++)
				{
					Marshal.WriteInt16(intPtr, i * 2, (short)((int)array[i * 2] << 8 | (int)array[i * 2 + 1]));
				}
				Marshal.WriteInt16(intPtr, array.Length, 0);
			}
			finally
			{
				if (array != null)
				{
					int j = array.Length;
					while (j > 0)
					{
						j--;
						array[j] = 0;
					}
				}
			}
			return intPtr;
		}

		/// <summary>Копирует содержимое управляемого объекта <see cref="T:System.Security.SecureString" /> в блок памяти, выделенный из неуправляемого распределителя COM-задач.</summary>
		/// <param name="s">Управляемый объект, подлежащий копированию.</param>
		/// <returns>Адрес в неуправляемой памяти, куда скопирован параметр <paramref name="s" />, или 0, если передан пустой объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий компьютер не работает под управлением Windows 2000 с пакетом обновления 3 (SP3) или более поздней версии.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		// Token: 0x060041F8 RID: 16888 RVA: 0x000E2FCC File Offset: 0x000E11CC
		public static IntPtr SecureStringToCoTaskMemAnsi(SecureString s)
		{
			return Marshal.SecureStringToAnsi(s, new Marshal.SecureStringAllocator(Marshal.SecureStringCoTaskMemAllocator));
		}

		/// <summary>Копирует содержимое управляемого объекта <see cref="T:System.Security.SecureString" /> в блок памяти, выделенный из неуправляемого распределителя COM-задач.</summary>
		/// <param name="s">Управляемый объект, подлежащий копированию.</param>
		/// <returns>Адрес в неуправляемой памяти, куда скопирован параметр <paramref name="s" />, или 0, если передан пустой объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий компьютер не работает под управлением Windows 2000 с пакетом обновления 3 (SP3) или более поздней версии.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		// Token: 0x060041F9 RID: 16889 RVA: 0x000E2FE0 File Offset: 0x000E11E0
		public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s)
		{
			return Marshal.SecureStringToUnicode(s, new Marshal.SecureStringAllocator(Marshal.SecureStringCoTaskMemAllocator));
		}

		/// <summary>Копирует содержимое управляемого объекта <see cref="T:System.Security.SecureString" /> в неуправляемую память, преобразуя его по мере копирования в формат ANSI.</summary>
		/// <param name="s">Управляемый объект, подлежащий копированию.</param>
		/// <returns>Адрес в неуправляемой памяти, куда скопирован параметр <paramref name="s" />, или 0, если передан пустой объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий компьютер не работает под управлением Windows 2000 с пакетом обновления 3 (SP3) или более поздней версии.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		// Token: 0x060041FA RID: 16890 RVA: 0x000E2FF4 File Offset: 0x000E11F4
		public static IntPtr SecureStringToGlobalAllocAnsi(SecureString s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			return Marshal.SecureStringToAnsi(s, new Marshal.SecureStringAllocator(Marshal.SecureStringGlobalAllocator));
		}

		/// <summary>Копирует содержимое управляемого объекта <see cref="T:System.Security.SecureString" /> в неуправляемую память.</summary>
		/// <param name="s">Управляемый объект, подлежащий копированию.</param>
		/// <returns>Адрес в неуправляемой памяти, куда был скопирован параметр <paramref name="s" />, или значение 0, если параметр <paramref name="s" /> представляет собой объект <see cref="T:System.Security.SecureString" />, длина которого равна 0.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий компьютер не работает под управлением Windows 2000 с пакетом обновления 3 (SP3) или более поздней версии.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		// Token: 0x060041FB RID: 16891 RVA: 0x000E3016 File Offset: 0x000E1216
		public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			return Marshal.SecureStringToUnicode(s, new Marshal.SecureStringAllocator(Marshal.SecureStringGlobalAllocator));
		}

		/// <summary>Маршалирует данные из управляемого объекта в неуправляемый блок памяти.</summary>
		/// <param name="structure">Управляемый объект, содержащий данные для маршалинга. Этот объект должен представлять собой структуру или экземпляр форматированного класса.</param>
		/// <param name="ptr">Указатель на неуправляемый блок памяти, который должен быть выделен перед вызовом метода.</param>
		/// <param name="fDeleteOld">Значение <see langword="true" /> для вызова метода <see cref="M:System.Runtime.InteropServices.Marshal.DestroyStructure(System.IntPtr,System.Type)" /> в параметре <paramref name="ptr" /> перед тем, как этот метод скопирует данные. Блок должен содержать допустимые данные. Обратите внимание, что передача значения <see langword="false" />, когда блок памяти уже содержит данные, может привести к утечке памяти.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="structure" /> — это ссылочный тип, который не является форматированным классом.  
		/// -или- 
		///  <paramref name="structure" /> — это экземпляр универсального типа (только в .NET Framework 4.5 и более ранних версиях).</exception>
		// Token: 0x060041FC RID: 16892
		[ComVisible(true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld);

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Выполняет маршалирование данных в неуправляемый блока памяти из управляемого объекта указанного типа.</summary>
		/// <param name="structure">Управляемый объект, содержащий данные для маршалинга. Объект должен представлять собой структуру или экземпляр форматированного класса.</param>
		/// <param name="ptr">Указатель на неуправляемый блок памяти, который должен быть выделен перед вызовом метода.</param>
		/// <param name="fDeleteOld">Значение <see langword="true" /> для вызова метода <see cref="M:System.Runtime.InteropServices.Marshal.DestroyStructure``1(System.IntPtr)" /> в параметре <paramref name="ptr" /> перед тем, как этот метод скопирует данные. Блок должен содержать допустимые данные. Обратите внимание, что передача значения <see langword="false" />, когда блок памяти уже содержит данные, может привести к утечке памяти.</param>
		/// <typeparam name="T">Тип управляемого объекта.</typeparam>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="structure" /> — это ссылочный тип, который не является форматированным классом.</exception>
		// Token: 0x060041FD RID: 16893 RVA: 0x000E3038 File Offset: 0x000E1238
		public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld)
		{
			Marshal.StructureToPtr(structure, ptr, fDeleteOld);
		}

		/// <summary>Создает исключение с определенным значением ошибки HRESULT.</summary>
		/// <param name="errorCode">Значение HRESULT, соответствующее нужному исключению.</param>
		// Token: 0x060041FE RID: 16894 RVA: 0x000E3048 File Offset: 0x000E1248
		public static void ThrowExceptionForHR(int errorCode)
		{
			Exception exceptionForHR = Marshal.GetExceptionForHR(errorCode);
			if (exceptionForHR != null)
			{
				throw exceptionForHR;
			}
		}

		/// <summary>Создает исключение с определенным значением ошибки HRESULT в соответствии с указанным интерфейсом IErrorInfo.aspx).</summary>
		/// <param name="errorCode">Значение HRESULT, соответствующее нужному исключению.</param>
		/// <param name="errorInfo">Указатель на интерфейс IErrorInfo, предоставляющий дополнительные сведения об ошибке. Можно задать значение IntPtr(0), чтобы использовать текущий интерфейс IErrorInfo, или значение IntPtr(-1), чтобы игнорировать текущий интерфейс IErrorInfo и создать исключение только на основе кода ошибки.</param>
		// Token: 0x060041FF RID: 16895 RVA: 0x000E3064 File Offset: 0x000E1264
		public static void ThrowExceptionForHR(int errorCode, IntPtr errorInfo)
		{
			Exception exceptionForHR = Marshal.GetExceptionForHR(errorCode, errorInfo);
			if (exceptionForHR != null)
			{
				throw exceptionForHR;
			}
		}

		// Token: 0x06004200 RID: 16896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr BufferToBSTR(char* ptr, int slen);

		/// <summary>Возвращает адрес элемента по указанному индексу внутри заданного массива.</summary>
		/// <param name="arr">Массив, содержащий требуемый элемент.</param>
		/// <param name="index">Индекс необходимого элемента в параметре <paramref name="arr" />.</param>
		/// <returns>Адрес параметра <paramref name="index" /> в параметре <paramref name="arr" />.</returns>
		// Token: 0x06004201 RID: 16897
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index);

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Возвращает адрес элемента по указанному индексу внутри массива заданного типа.</summary>
		/// <param name="arr">Массив, содержащий требуемый элемент.</param>
		/// <param name="index">Индекс необходимого элемента в массиве <paramref name="arr" />.</param>
		/// <typeparam name="T">Тип массива.</typeparam>
		/// <returns>Адрес параметра <paramref name="index" /> в параметре <paramref name="arr" />.</returns>
		// Token: 0x06004202 RID: 16898 RVA: 0x000E307E File Offset: 0x000E127E
		public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index)
		{
			return Marshal.UnsafeAddrOfPinnedArrayElement(arr, index);
		}

		/// <summary>Записывает однобайтовое значение в неуправляемую память.</summary>
		/// <param name="ptr">Адрес в неуправляемой памяти, по которому производится запись.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> не является распознаваемым форматом.  
		/// -или- 
		///  Свойство <paramref name="ptr" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="ptr" /> недопустим.</exception>
		// Token: 0x06004203 RID: 16899 RVA: 0x000E3087 File Offset: 0x000E1287
		public unsafe static void WriteByte(IntPtr ptr, byte val)
		{
			*(byte*)((void*)ptr) = val;
		}

		/// <summary>Записывает однобайтовое значение в неуправляемую память с указанным смещением.</summary>
		/// <param name="ptr">Базовый адрес для записи в неуправляемой памяти.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед записью.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		// Token: 0x06004204 RID: 16900 RVA: 0x000E3091 File Offset: 0x000E1291
		public unsafe static void WriteByte(IntPtr ptr, int ofs, byte val)
		{
			*(byte*)((void*)IntPtr.Add(ptr, ofs)) = val;
		}

		/// <summary>Записывает однобайтовое значение в неуправляемую память с указанным смещением.</summary>
		/// <param name="ptr">Базовый адрес конечного объекта в неуправляемой памяти.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед записью.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ptr" /> является объектом <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />. Этот метод не принимает параметры <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</exception>
		// Token: 0x06004205 RID: 16901 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SuppressUnmanagedCodeSecurity]
		public static void WriteByte([MarshalAs(UnmanagedType.AsAny)] [In] [Out] object ptr, int ofs, byte val)
		{
			throw new NotImplementedException();
		}

		/// <summary>Записывает в неуправляемую память 16-битное целое число.</summary>
		/// <param name="ptr">Адрес в неуправляемой памяти, по которому производится запись.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> не является распознаваемым форматом.  
		/// -или- 
		///  Свойство <paramref name="ptr" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="ptr" /> недопустим.</exception>
		// Token: 0x06004206 RID: 16902 RVA: 0x000E30A4 File Offset: 0x000E12A4
		public unsafe static void WriteInt16(IntPtr ptr, short val)
		{
			byte* ptr2 = (byte*)((void*)ptr);
			if ((ptr2 & 1U) == 0U)
			{
				*(short*)ptr2 = val;
				return;
			}
			Buffer.Memcpy(ptr2, (byte*)(&val), 2, true);
		}

		/// <summary>Записывает 16-битное целое число со знаком в неуправляемую память с указанным смещением.</summary>
		/// <param name="ptr">Базовый адрес для записи в неуправляемой памяти.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед записью.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		// Token: 0x06004207 RID: 16903 RVA: 0x000E30D0 File Offset: 0x000E12D0
		public unsafe static void WriteInt16(IntPtr ptr, int ofs, short val)
		{
			byte* ptr2 = (byte*)((void*)ptr) + ofs;
			if ((ptr2 & 1U) == 0U)
			{
				*(short*)ptr2 = val;
				return;
			}
			Buffer.Memcpy(ptr2, (byte*)(&val), 2, true);
		}

		/// <summary>Записывает 16-битное целое число со знаком в неуправляемую память с указанным смещением.</summary>
		/// <param name="ptr">Базовый адрес конечного объекта в неуправляемой памяти.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед записью.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ptr" /> является объектом <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />. Этот метод не принимает параметры <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</exception>
		// Token: 0x06004208 RID: 16904 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SuppressUnmanagedCodeSecurity]
		public static void WriteInt16([MarshalAs(UnmanagedType.AsAny)] [In] [Out] object ptr, int ofs, short val)
		{
			throw new NotImplementedException();
		}

		/// <summary>Записывает в неуправляемую память символ в виде 16-битного целого числа.</summary>
		/// <param name="ptr">Адрес в неуправляемой памяти, по которому производится запись.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> не является распознаваемым форматом.  
		/// -или- 
		///  Свойство <paramref name="ptr" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="ptr" /> недопустим.</exception>
		// Token: 0x06004209 RID: 16905 RVA: 0x000E30FB File Offset: 0x000E12FB
		public static void WriteInt16(IntPtr ptr, char val)
		{
			Marshal.WriteInt16(ptr, 0, (short)val);
		}

		/// <summary>Записывает 16-битное целое число со знаком в неуправляемую память с указанным смещением.</summary>
		/// <param name="ptr">Базовый адрес для записи в собственной куче.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед записью.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		// Token: 0x0600420A RID: 16906 RVA: 0x000E3106 File Offset: 0x000E1306
		public static void WriteInt16(IntPtr ptr, int ofs, char val)
		{
			Marshal.WriteInt16(ptr, ofs, (short)val);
		}

		/// <summary>Записывает 16-битное целое число со знаком в неуправляемую память с указанным смещением.</summary>
		/// <param name="ptr">Базовый адрес конечного объекта в неуправляемой памяти.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед записью.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ptr" /> является объектом <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />. Этот метод не принимает параметры <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</exception>
		// Token: 0x0600420B RID: 16907 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static void WriteInt16([In] [Out] object ptr, int ofs, char val)
		{
			throw new NotImplementedException();
		}

		/// <summary>Записывает в неуправляемую память 32-битное целое число со знаком.</summary>
		/// <param name="ptr">Адрес в неуправляемой памяти, по которому производится запись.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> не является распознаваемым форматом.  
		/// -или- 
		///  Свойство <paramref name="ptr" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="ptr" /> недопустим.</exception>
		// Token: 0x0600420C RID: 16908 RVA: 0x000E3114 File Offset: 0x000E1314
		public unsafe static void WriteInt32(IntPtr ptr, int val)
		{
			byte* ptr2 = (byte*)((void*)ptr);
			if ((ptr2 & 3U) == 0U)
			{
				*(int*)ptr2 = val;
				return;
			}
			Buffer.Memcpy(ptr2, (byte*)(&val), 4, true);
		}

		/// <summary>Записывает 32-битное целое число со знаком в неуправляемую память с указанным смещением.</summary>
		/// <param name="ptr">Базовый адрес для записи в неуправляемой памяти.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед записью.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		// Token: 0x0600420D RID: 16909 RVA: 0x000E3140 File Offset: 0x000E1340
		public unsafe static void WriteInt32(IntPtr ptr, int ofs, int val)
		{
			byte* ptr2 = (byte*)((void*)ptr) + ofs;
			if ((ptr2 & 3U) == 0U)
			{
				*(int*)ptr2 = val;
				return;
			}
			Buffer.Memcpy(ptr2, (byte*)(&val), 4, true);
		}

		/// <summary>Записывает 32-битное целое число со знаком в неуправляемую память с указанным смещением.</summary>
		/// <param name="ptr">Базовый адрес конечного объекта в неуправляемой памяти.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед записью.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ptr" /> является объектом <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />. Этот метод не принимает параметры <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</exception>
		// Token: 0x0600420E RID: 16910 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SuppressUnmanagedCodeSecurity]
		public static void WriteInt32([MarshalAs(UnmanagedType.AsAny)] [In] [Out] object ptr, int ofs, int val)
		{
			throw new NotImplementedException();
		}

		/// <summary>Записывает в неуправляемую память 64-битное целое число со знаком.</summary>
		/// <param name="ptr">Адрес в неуправляемой памяти, по которому производится запись.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> не является распознаваемым форматом.  
		/// -или- 
		///  Свойство <paramref name="ptr" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="ptr" /> недопустим.</exception>
		// Token: 0x0600420F RID: 16911 RVA: 0x000E316C File Offset: 0x000E136C
		public unsafe static void WriteInt64(IntPtr ptr, long val)
		{
			byte* ptr2 = (byte*)((void*)ptr);
			if ((ptr2 & 7U) == 0U)
			{
				*(long*)ptr2 = val;
				return;
			}
			Buffer.Memcpy(ptr2, (byte*)(&val), 8, true);
		}

		/// <summary>Записывает 64-битное целое число со знаком в неуправляемую память с указанным смещением.</summary>
		/// <param name="ptr">Базовый адрес для записи в неуправляемой памяти.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед записью.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		// Token: 0x06004210 RID: 16912 RVA: 0x000E3198 File Offset: 0x000E1398
		public unsafe static void WriteInt64(IntPtr ptr, int ofs, long val)
		{
			byte* ptr2 = (byte*)((void*)ptr) + ofs;
			if ((ptr2 & 7U) == 0U)
			{
				*(long*)ptr2 = val;
				return;
			}
			Buffer.Memcpy(ptr2, (byte*)(&val), 8, true);
		}

		/// <summary>Записывает 64-битное целое число со знаком в неуправляемую память с указанным смещением.</summary>
		/// <param name="ptr">Базовый адрес конечного объекта в неуправляемой памяти.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед записью.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ptr" /> является объектом <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />. Этот метод не принимает параметры <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</exception>
		// Token: 0x06004211 RID: 16913 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SuppressUnmanagedCodeSecurity]
		public static void WriteInt64([MarshalAs(UnmanagedType.AsAny)] [In] [Out] object ptr, int ofs, long val)
		{
			throw new NotImplementedException();
		}

		/// <summary>Записывает в неуправляемую память целое число, разрядность которого соответствует собственной разрядности процессора.</summary>
		/// <param name="ptr">Адрес в неуправляемой памяти, по которому производится запись.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> не является распознаваемым форматом.  
		/// -или- 
		///  Свойство <paramref name="ptr" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="ptr" /> недопустим.</exception>
		// Token: 0x06004212 RID: 16914 RVA: 0x000E31C3 File Offset: 0x000E13C3
		public static void WriteIntPtr(IntPtr ptr, IntPtr val)
		{
			if (IntPtr.Size == 4)
			{
				Marshal.WriteInt32(ptr, (int)val);
				return;
			}
			Marshal.WriteInt64(ptr, (long)val);
		}

		/// <summary>Записывает в неуправляемую память с указанным смещением целое число, разрядность которого соответствует собственной разрядности процессора.</summary>
		/// <param name="ptr">Базовый адрес для записи в неуправляемой памяти.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед записью.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		// Token: 0x06004213 RID: 16915 RVA: 0x000E31E6 File Offset: 0x000E13E6
		public static void WriteIntPtr(IntPtr ptr, int ofs, IntPtr val)
		{
			if (IntPtr.Size == 4)
			{
				Marshal.WriteInt32(ptr, ofs, (int)val);
				return;
			}
			Marshal.WriteInt64(ptr, ofs, (long)val);
		}

		/// <summary>Записывает в неуправляемую память целое число, разрядность которого соответствует собственной разрядности процессора.</summary>
		/// <param name="ptr">Базовый адрес конечного объекта в неуправляемой памяти.</param>
		/// <param name="ofs">Дополнительное смещение байтов, добавляемое к параметру <paramref name="ptr" /> перед записью.</param>
		/// <param name="val">Значение для записи.</param>
		/// <exception cref="T:System.AccessViolationException">Сумма базового адреса (<paramref name="ptr" />) и байта смещения (<paramref name="ofs" />) дает значение null или недопустимый адрес.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ptr" /> является объектом <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />. Этот метод не принимает параметры <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" />.</exception>
		// Token: 0x06004214 RID: 16916 RVA: 0x000479F8 File Offset: 0x00045BF8
		public static void WriteIntPtr([MarshalAs(UnmanagedType.AsAny)] [In] [Out] object ptr, int ofs, IntPtr val)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x000E320C File Offset: 0x000E140C
		private static Exception ConvertHrToException(int errorCode)
		{
			if (errorCode > -2147024362)
			{
				if (errorCode <= -2146232828)
				{
					if (errorCode <= -2146893792)
					{
						if (errorCode != -2147023895)
						{
							if (errorCode != -2146893792)
							{
								goto IL_3A9;
							}
							return new CryptographicException();
						}
					}
					else
					{
						if (errorCode == -2146234348)
						{
							return new AppDomainUnloadedException();
						}
						switch (errorCode)
						{
						case -2146233088:
							return new Exception();
						case -2146233087:
							return new SystemException();
						case -2146233086:
							return new ArgumentOutOfRangeException();
						case -2146233085:
							return new ArrayTypeMismatchException();
						case -2146233084:
							return new ContextMarshalException();
						case -2146233083:
						case -2146233074:
						case -2146233073:
						case -2146233061:
						case -2146233060:
						case -2146233059:
						case -2146233058:
						case -2146233057:
						case -2146233055:
						case -2146233053:
						case -2146233052:
						case -2146233051:
						case -2146233050:
						case -2146233046:
						case -2146233045:
						case -2146233044:
						case -2146233043:
						case -2146233042:
						case -2146233041:
						case -2146233040:
						case -2146233035:
						case -2146233034:
							goto IL_3A9;
						case -2146233082:
							return new ExecutionEngineException();
						case -2146233081:
							return new FieldAccessException();
						case -2146233080:
							return new IndexOutOfRangeException();
						case -2146233079:
							return new InvalidOperationException();
						case -2146233078:
							return new SecurityException();
						case -2146233077:
							return new RemotingException();
						case -2146233076:
							return new SerializationException();
						case -2146233075:
							return new VerificationException();
						case -2146233072:
							return new MethodAccessException();
						case -2146233071:
							return new MissingFieldException();
						case -2146233070:
							return new MissingMemberException();
						case -2146233069:
							return new MissingMethodException();
						case -2146233068:
							return new MulticastNotSupportedException();
						case -2146233067:
							return new NotSupportedException();
						case -2146233066:
							return new OverflowException();
						case -2146233065:
							return new RankException();
						case -2146233064:
							return new SynchronizationLockException();
						case -2146233063:
							return new ThreadInterruptedException();
						case -2146233062:
							return new MemberAccessException();
						case -2146233056:
							return new ThreadStateException();
						case -2146233054:
							return new TypeLoadException();
						case -2146233049:
							return new InvalidComObjectException();
						case -2146233048:
							return new NotFiniteNumberException();
						case -2146233047:
							return new DuplicateWaitObjectException();
						case -2146233039:
							return new InvalidOleVariantTypeException();
						case -2146233038:
							return new MissingManifestResourceException();
						case -2146233037:
							return new SafeArrayTypeMismatchException();
						case -2146233036:
							return new TypeInitializationException("", null);
						case -2146233033:
							return new FormatException();
						default:
							switch (errorCode)
							{
							case -2146232832:
								return new ApplicationException();
							case -2146232831:
								return new InvalidFilterCriteriaException();
							case -2146232830:
								return new ReflectionTypeLoadException(new Type[0], new Exception[0]);
							case -2146232829:
								return new TargetException();
							case -2146232828:
								return new TargetInvocationException(null);
							default:
								goto IL_3A9;
							}
							break;
						}
					}
				}
				else if (errorCode <= 3)
				{
					if (errorCode == -2146232800)
					{
						return new IOException();
					}
					if (errorCode == 2)
					{
						goto IL_2A6;
					}
					if (errorCode != 3)
					{
						goto IL_3A9;
					}
					goto IL_27C;
				}
				else
				{
					if (errorCode == 11)
					{
						goto IL_26A;
					}
					if (errorCode == 206)
					{
						goto IL_32A;
					}
					if (errorCode != 1001)
					{
						goto IL_3A9;
					}
				}
				return new StackOverflowException();
			}
			if (errorCode <= -2147024893)
			{
				if (errorCode <= -2147352562)
				{
					switch (errorCode)
					{
					case -2147467263:
						return new NotImplementedException();
					case -2147467262:
						return new InvalidCastException();
					case -2147467261:
						return new NullReferenceException();
					default:
						if (errorCode != -2147352562)
						{
							goto IL_3A9;
						}
						return new TargetParameterCountException();
					}
				}
				else
				{
					if (errorCode == -2147352558)
					{
						return new DivideByZeroException();
					}
					if (errorCode == -2147024894)
					{
						goto IL_2A6;
					}
					if (errorCode != -2147024893)
					{
						goto IL_3A9;
					}
					goto IL_27C;
				}
			}
			else if (errorCode <= -2147024858)
			{
				if (errorCode != -2147024885)
				{
					if (errorCode == -2147024882)
					{
						return new OutOfMemoryException();
					}
					if (errorCode != -2147024858)
					{
						goto IL_3A9;
					}
					return new EndOfStreamException();
				}
			}
			else
			{
				if (errorCode == -2147024809)
				{
					return new ArgumentException();
				}
				if (errorCode == -2147024690)
				{
					goto IL_32A;
				}
				if (errorCode != -2147024362)
				{
					goto IL_3A9;
				}
				return new ArithmeticException();
			}
			IL_26A:
			return new BadImageFormatException();
			IL_27C:
			return new DirectoryNotFoundException();
			IL_2A6:
			return new FileNotFoundException();
			IL_32A:
			return new PathTooLongException();
			IL_3A9:
			if (errorCode < 0)
			{
				return new COMException("", errorCode);
			}
			return null;
		}

		// Token: 0x06004216 RID: 16918
		[DllImport("oleaut32.dll", CharSet = CharSet.Unicode, EntryPoint = "SetErrorInfo")]
		private static extern int _SetErrorInfo(int dwReserved, [MarshalAs(UnmanagedType.Interface)] IErrorInfo pIErrorInfo);

		// Token: 0x06004217 RID: 16919
		[DllImport("oleaut32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetErrorInfo")]
		private static extern int _GetErrorInfo(int dwReserved, [MarshalAs(UnmanagedType.Interface)] out IErrorInfo ppIErrorInfo);

		// Token: 0x06004218 RID: 16920 RVA: 0x000E35D4 File Offset: 0x000E17D4
		internal static int SetErrorInfo(int dwReserved, IErrorInfo errorInfo)
		{
			int result = 0;
			errorInfo = null;
			if (Marshal.SetErrorInfoNotAvailable)
			{
				return -1;
			}
			try
			{
				result = Marshal._SetErrorInfo(dwReserved, errorInfo);
			}
			catch (Exception)
			{
				Marshal.SetErrorInfoNotAvailable = true;
			}
			return result;
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x000E3614 File Offset: 0x000E1814
		internal static int GetErrorInfo(int dwReserved, out IErrorInfo errorInfo)
		{
			int result = 0;
			errorInfo = null;
			if (Marshal.GetErrorInfoNotAvailable)
			{
				return -1;
			}
			try
			{
				result = Marshal._GetErrorInfo(dwReserved, out errorInfo);
			}
			catch (Exception)
			{
				Marshal.GetErrorInfoNotAvailable = true;
			}
			return result;
		}

		/// <summary>Преобразует заданный код ошибки HRESULT в соответствующий объект <see cref="T:System.Exception" />.</summary>
		/// <param name="errorCode">Преобразуемое значение HRESULT.</param>
		/// <returns>Объект, представляющий преобразованное значение HRESULT.</returns>
		// Token: 0x0600421A RID: 16922 RVA: 0x000E3654 File Offset: 0x000E1854
		public static Exception GetExceptionForHR(int errorCode)
		{
			return Marshal.GetExceptionForHR(errorCode, IntPtr.Zero);
		}

		/// <summary>Преобразует указанный код ошибки HRESULT в соответствующий объект <see cref="T:System.Exception" /> с дополнительными сведениями об ошибке, передаваемыми в интерфейсе IErrorInfo для объекта исключения.</summary>
		/// <param name="errorCode">Преобразуемое значение HRESULT.</param>
		/// <param name="errorInfo">Указатель на интерфейс <see langword="IErrorInfo" />, предоставляющий дополнительные сведения об ошибке. Можно задать IntPtr(0), чтобы использовать текущий интерфейс <see langword="IErrorInfo" />, или IntPtr(-1), чтобы игнорировать текущий интерфейс <see langword="IErrorInfo" /> и сформировать исключение только на основе кода ошибки.</param>
		/// <returns>Объект, представляющий преобразованное значение HRESULT и сведения, полученные из параметра <paramref name="errorInfo" />.</returns>
		// Token: 0x0600421B RID: 16923 RVA: 0x000E3664 File Offset: 0x000E1864
		public static Exception GetExceptionForHR(int errorCode, IntPtr errorInfo)
		{
			IErrorInfo errorInfo2 = null;
			if (errorInfo != (IntPtr)(-1))
			{
				if (errorInfo == IntPtr.Zero)
				{
					if (Marshal.GetErrorInfo(0, out errorInfo2) != 0)
					{
						errorInfo2 = null;
					}
				}
				else
				{
					errorInfo2 = (Marshal.GetObjectForIUnknown(errorInfo) as IErrorInfo);
				}
			}
			if (errorInfo2 is ManagedErrorInfo && ((ManagedErrorInfo)errorInfo2).Exception._HResult == errorCode)
			{
				return ((ManagedErrorInfo)errorInfo2).Exception;
			}
			Exception ex = Marshal.ConvertHrToException(errorCode);
			if (errorInfo2 != null && ex != null)
			{
				uint num;
				errorInfo2.GetHelpContext(out num);
				string text;
				errorInfo2.GetSource(out text);
				ex.Source = text;
				errorInfo2.GetDescription(out text);
				ex.SetMessage(text);
				errorInfo2.GetHelpFile(out text);
				if (num == 0U)
				{
					ex.HelpLink = text;
				}
				else
				{
					ex.HelpLink = string.Format("{0}#{1}", text, num);
				}
			}
			return ex;
		}

		/// <summary>Высвобождает все ссылки на вызываемую оболочку времени выполнения (RCW), присваивая ее счетчику ссылок значение 0.</summary>
		/// <param name="o">Освобождаемая оболочка CLR.</param>
		/// <returns>Новое значение счетчика ссылок для вызываемой оболочки времени выполнения, связанной с параметром <paramref name="o" />, равное нулю (0), если высвобождение прошло успешно.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="o" /> не является допустимым COM-объектом.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="o" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600421C RID: 16924 RVA: 0x000E3732 File Offset: 0x000E1932
		public static int FinalReleaseComObject(object o)
		{
			while (Marshal.ReleaseComObject(o) != 0)
			{
			}
			return 0;
		}

		// Token: 0x0600421D RID: 16925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Delegate GetDelegateForFunctionPointerInternal(IntPtr ptr, Type t);

		/// <summary>Преобразует указатель на неуправляемую функцию в делегат.</summary>
		/// <param name="ptr">Указатель на неуправляемую функцию, который требуется преобразовать.</param>
		/// <param name="t">Тип возвращаемого делегата.</param>
		/// <returns>Экземпляр делегата, который может быть приведен к соответствующему типу делегата.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="t" /> не является делегатом или является универсальным.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="ptr" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Параметр <paramref name="t" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600421E RID: 16926 RVA: 0x000E3740 File Offset: 0x000E1940
		public static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t)
		{
			if (t == null)
			{
				throw new ArgumentNullException("t");
			}
			if (!t.IsSubclassOf(typeof(MulticastDelegate)) || t == typeof(MulticastDelegate))
			{
				throw new ArgumentException("Type is not a delegate", "t");
			}
			if (t.IsGenericType)
			{
				throw new ArgumentException("The specified Type must not be a generic type definition.");
			}
			if (ptr == IntPtr.Zero)
			{
				throw new ArgumentNullException("ptr");
			}
			return Marshal.GetDelegateForFunctionPointerInternal(ptr, t);
		}

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Преобразует указатель на неуправляемую функцию в делегат указанного типа.</summary>
		/// <param name="ptr">Указатель на неуправляемую функцию, который требуется преобразовать.</param>
		/// <typeparam name="TDelegate">Тип возвращаемого делегата.</typeparam>
		/// <returns>Экземпляр делегата указанного типа.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="TDelegate" /> не является делегатом или является открытым универсальным типом.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="ptr" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600421F RID: 16927 RVA: 0x000E37C7 File Offset: 0x000E19C7
		public static TDelegate GetDelegateForFunctionPointer<TDelegate>(IntPtr ptr)
		{
			return (TDelegate)((object)Marshal.GetDelegateForFunctionPointer(ptr, typeof(TDelegate)));
		}

		// Token: 0x06004220 RID: 16928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetFunctionPointerForDelegateInternal(Delegate d);

		/// <summary>Преобразует делегат в указатель на функцию, вызываемый из неуправляемого кода.</summary>
		/// <param name="d">Делегат, передаваемый в неуправляемый код.</param>
		/// <returns>Значение, которое можно передать в неуправляемый код, который, в свою очередь, может использовать его для вызова базового управляемого делегата.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="d" /> является определением универсального типа.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="d" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004221 RID: 16929 RVA: 0x000E37DE File Offset: 0x000E19DE
		public static IntPtr GetFunctionPointerForDelegate(Delegate d)
		{
			if (d == null)
			{
				throw new ArgumentNullException("d");
			}
			return Marshal.GetFunctionPointerForDelegateInternal(d);
		}

		/// <summary>[Поддерживается в .NET Framework 4.5.1 и более поздних версиях.] 
		/// Преобразует делегат указанного типа в указатель на функцию, вызываемый из неуправляемого кода.</summary>
		/// <param name="d">Делегат, передаваемый в неуправляемый код.</param>
		/// <typeparam name="TDelegate">Тип преобразуемого делегата.</typeparam>
		/// <returns>Значение, которое можно передать в неуправляемый код, который, в свою очередь, может использовать его для вызова базового управляемого делегата.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="d" /> является определением универсального типа.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="d" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004222 RID: 16930 RVA: 0x000E37F4 File Offset: 0x000E19F4
		public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
		{
			if (d == null)
			{
				throw new ArgumentNullException("d");
			}
			return Marshal.GetFunctionPointerForDelegateInternal((Delegate)((object)d));
		}

		// Token: 0x06004223 RID: 16931
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetLastWin32Error(int error);

		// Token: 0x06004224 RID: 16932
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr GetRawIUnknownForComObjectNoAddRef(object o);

		// Token: 0x06004225 RID: 16933
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetHRForException_WinRT(Exception e);

		// Token: 0x06004226 RID: 16934
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern object GetNativeActivationFactory(Type type);

		// Token: 0x06004227 RID: 16935 RVA: 0x000E381C File Offset: 0x000E1A1C
		internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie)
		{
			ValueTuple<Type, string> key = new ValueTuple<Type, string>(type, cookie);
			LazyInitializer.EnsureInitialized<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>>(ref Marshal.MarshalerInstanceCache, () => new Dictionary<ValueTuple<Type, string>, ICustomMarshaler>(new Marshal.MarshalerInstanceKeyComparer()));
			object marshalerInstanceCacheLock = Marshal.MarshalerInstanceCacheLock;
			ICustomMarshaler customMarshaler;
			bool flag2;
			lock (marshalerInstanceCacheLock)
			{
				flag2 = Marshal.MarshalerInstanceCache.TryGetValue(key, out customMarshaler);
			}
			if (!flag2)
			{
				RuntimeMethodInfo runtimeMethodInfo;
				try
				{
					runtimeMethodInfo = (RuntimeMethodInfo)type.GetMethod("GetInstance", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, new Type[]
					{
						typeof(string)
					}, null);
				}
				catch (AmbiguousMatchException)
				{
					throw new ApplicationException("Custom marshaler '" + type.FullName + "' implements multiple static GetInstance methods that take a single string parameter.");
				}
				if (runtimeMethodInfo == null || runtimeMethodInfo.ReturnType != typeof(ICustomMarshaler))
				{
					throw new ApplicationException("Custom marshaler '" + type.FullName + "' does not implement a static GetInstance method that takes a single string parameter and returns an ICustomMarshaler.");
				}
				Exception ex;
				try
				{
					customMarshaler = (ICustomMarshaler)runtimeMethodInfo.InternalInvoke(null, new object[]
					{
						cookie
					}, out ex);
				}
				catch (Exception ex)
				{
					customMarshaler = null;
				}
				if (ex != null)
				{
					ExceptionDispatchInfo.Capture(ex).Throw();
				}
				if (customMarshaler == null)
				{
					throw new ApplicationException("A call to GetInstance() for custom marshaler '" + type.FullName + "' returned null, which is not allowed.");
				}
				marshalerInstanceCacheLock = Marshal.MarshalerInstanceCacheLock;
				lock (marshalerInstanceCacheLock)
				{
					Marshal.MarshalerInstanceCache[key] = customMarshaler;
				}
			}
			return customMarshaler;
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x000E39C8 File Offset: 0x000E1BC8
		public unsafe static IntPtr StringToCoTaskMemUTF8(string s)
		{
			if (s == null)
			{
				return IntPtr.Zero;
			}
			int maxByteCount = Encoding.UTF8.GetMaxByteCount(s.Length);
			IntPtr intPtr = Marshal.AllocCoTaskMem(maxByteCount + 1);
			byte* ptr = (byte*)((void*)intPtr);
			int bytes;
			fixed (string text = s)
			{
				char* ptr2 = text;
				if (ptr2 != null)
				{
					ptr2 += RuntimeHelpers.OffsetToStringData / 2;
				}
				bytes = Encoding.UTF8.GetBytes(ptr2, s.Length, ptr, maxByteCount);
			}
			ptr[bytes] = 0;
			return intPtr;
		}

		/// <summary>Представляет наибольший размер набора двухбайтовых символов (DBCS) в байтах для текущей операционной системы. Это поле доступно только для чтения.</summary>
		// Token: 0x04002BCC RID: 11212
		public static readonly int SystemMaxDBCSCharSize = 2;

		/// <summary>Представляет используемый по умолчанию размер символа в системе. По умолчанию для систем Юникода задается значение 2, а для систем ANSI значение 1. Это поле доступно только для чтения.</summary>
		// Token: 0x04002BCD RID: 11213
		public static readonly int SystemDefaultCharSize = Environment.IsRunningOnWindows ? 2 : 1;

		// Token: 0x04002BCE RID: 11214
		private static bool SetErrorInfoNotAvailable;

		// Token: 0x04002BCF RID: 11215
		private static bool GetErrorInfoNotAvailable;

		// Token: 0x04002BD0 RID: 11216
		internal static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache;

		// Token: 0x04002BD1 RID: 11217
		internal static readonly object MarshalerInstanceCacheLock = new object();

		// Token: 0x02000749 RID: 1865
		// (Invoke) Token: 0x0600422B RID: 16939
		internal delegate IntPtr SecureStringAllocator(int len);

		// Token: 0x0200074A RID: 1866
		internal class MarshalerInstanceKeyComparer : IEqualityComparer<ValueTuple<Type, string>>
		{
			// Token: 0x0600422E RID: 16942 RVA: 0x000E3A4E File Offset: 0x000E1C4E
			public bool Equals(ValueTuple<Type, string> lhs, ValueTuple<Type, string> rhs)
			{
				return lhs.CompareTo(rhs) == 0;
			}

			// Token: 0x0600422F RID: 16943 RVA: 0x000E3A5B File Offset: 0x000E1C5B
			public int GetHashCode(ValueTuple<Type, string> key)
			{
				return key.GetHashCode();
			}
		}
	}
}
