using System;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет управляемый буфер памяти, который может использоваться для чтения и записи. Попытки обращения к памяти за пределами управляемого буфера (опустошение или переполнение) вызывают исключения.</summary>
	// Token: 0x020006D0 RID: 1744
	public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Runtime.InteropServices.SafeBuffer" /> и указывает, должен ли быть дескриптор буфера надежно освобожден.</summary>
		/// <param name="ownsHandle">Значение <see langword="true" />, чтобы надежно освободить маркер на стадии завершения; значение <see langword="false" />, чтобы предотвратить надежное освобождение (не рекомендуется).</param>
		// Token: 0x06004010 RID: 16400 RVA: 0x000E05D0 File Offset: 0x000DE7D0
		protected SafeBuffer(bool ownsHandle) : base(ownsHandle)
		{
			this._numBytes = SafeBuffer.Uninitialized;
		}

		/// <summary>Определяет размер выделяемой области памяти (в байтах). Данный метод необходимо вызвать перед использованием экземпляра <see cref="T:System.Runtime.InteropServices.SafeBuffer" />.</summary>
		/// <param name="numBytes">Количество байтов в буфере.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="numBytes" /> меньше нуля.  
		/// -или- 
		///  <paramref name="numBytes" /> больше доступного адресного пространства.</exception>
		// Token: 0x06004011 RID: 16401 RVA: 0x000E05E4 File Offset: 0x000DE7E4
		[CLSCompliant(false)]
		public void Initialize(ulong numBytes)
		{
			if (IntPtr.Size == 4 && numBytes > (ulong)-1)
			{
				throw new ArgumentOutOfRangeException("numBytes", "The number of bytes cannot exceed the virtual address space on a 32 bit machine.");
			}
			if (numBytes >= (ulong)SafeBuffer.Uninitialized)
			{
				throw new ArgumentOutOfRangeException("numBytes", "The length of the buffer must be less than the maximum UIntPtr value for your platform.");
			}
			this._numBytes = (UIntPtr)numBytes;
		}

		/// <summary>Задает размер выделяемого буфера памяти, используя указанное количество элементов и размер элемента. Данный метод необходимо вызвать перед использованием экземпляра <see cref="T:System.Runtime.InteropServices.SafeBuffer" />.</summary>
		/// <param name="numElements">Количество элементов в буфере.</param>
		/// <param name="sizeOfEachElement">Размер каждого элемента в буфере.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="numElements" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="sizeOfEachElement" /> меньше нуля.  
		/// -или- 
		///  Произведение <paramref name="numElements" /> и <paramref name="sizeOfEachElement" /> превышает объем доступного адресного пространства.</exception>
		// Token: 0x06004012 RID: 16402 RVA: 0x000E0638 File Offset: 0x000DE838
		[CLSCompliant(false)]
		public void Initialize(uint numElements, uint sizeOfEachElement)
		{
			if (IntPtr.Size == 4 && numElements * sizeOfEachElement > 4294967295U)
			{
				throw new ArgumentOutOfRangeException("numBytes", "The number of bytes cannot exceed the virtual address space on a 32 bit machine.");
			}
			if ((ulong)(numElements * sizeOfEachElement) >= (ulong)SafeBuffer.Uninitialized)
			{
				throw new ArgumentOutOfRangeException("numElements", "The length of the buffer must be less than the maximum UIntPtr value for your platform.");
			}
			this._numBytes = (UIntPtr)(checked(numElements * sizeOfEachElement));
		}

		/// <summary>Определяет размер выделяемой области памяти путем указания количества значений и их типа. Данный метод необходимо вызвать перед использованием экземпляра <see cref="T:System.Runtime.InteropServices.SafeBuffer" />.</summary>
		/// <param name="numElements">Количество элементов этого типа значения, под которое выделяется память.</param>
		/// <typeparam name="T">Тип значения, под который выделяется память.</typeparam>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="numElements" /> меньше нуля.  
		/// -или- 
		///  Произведение <paramref name="numElements" /> и размера каждого элемента превышает объем доступного адресного пространства.</exception>
		// Token: 0x06004013 RID: 16403 RVA: 0x000E0691 File Offset: 0x000DE891
		[CLSCompliant(false)]
		public void Initialize<T>(uint numElements) where T : struct
		{
			this.Initialize(numElements, SafeBuffer.AlignedSizeOf<T>());
		}

		/// <summary>Получает из объекта <see cref="T:System.Runtime.InteropServices.SafeBuffer" /> указатель для блока памяти.</summary>
		/// <param name="pointer">Указатель байта, передаваемый по ссылке, для получения указателя из объекта <see cref="T:System.Runtime.InteropServices.SafeBuffer" />. Необходимо присвоить этому указателю значение <see langword="null" />, прежде чем вызывать этот метод.</param>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="Overload:System.Runtime.InteropServices.SafeBuffer.Initialize" /> не был вызван.</exception>
		// Token: 0x06004014 RID: 16404 RVA: 0x000E06A0 File Offset: 0x000DE8A0
		[CLSCompliant(false)]
		public unsafe void AcquirePointer(ref byte* pointer)
		{
			if (this._numBytes == SafeBuffer.Uninitialized)
			{
				throw SafeBuffer.NotInitialized();
			}
			pointer = (IntPtr)((UIntPtr)0);
			bool flag = false;
			base.DangerousAddRef(ref flag);
			pointer = (void*)this.handle;
		}

		/// <summary>Высвобождает указатель, полученный методом <see cref="M:System.Runtime.InteropServices.SafeBuffer.AcquirePointer(System.Byte*@)" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="Overload:System.Runtime.InteropServices.SafeBuffer.Initialize" /> не был вызван.</exception>
		// Token: 0x06004015 RID: 16405 RVA: 0x000E06E0 File Offset: 0x000DE8E0
		public void ReleasePointer()
		{
			if (this._numBytes == SafeBuffer.Uninitialized)
			{
				throw SafeBuffer.NotInitialized();
			}
			base.DangerousRelease();
		}

		/// <summary>Считывает из памяти тип значения с указанным смещением.</summary>
		/// <param name="byteOffset">Расположение, из которого считывается тип значения. Может потребоваться продумать проблемы выравнивания.</param>
		/// <typeparam name="T">Считываемый тип значения.</typeparam>
		/// <returns>Тип значения, считанный из памяти.</returns>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="Overload:System.Runtime.InteropServices.SafeBuffer.Initialize" /> не был вызван.</exception>
		// Token: 0x06004016 RID: 16406 RVA: 0x000E0700 File Offset: 0x000DE900
		[CLSCompliant(false)]
		public unsafe T Read<T>(ulong byteOffset) where T : struct
		{
			if (this._numBytes == SafeBuffer.Uninitialized)
			{
				throw SafeBuffer.NotInitialized();
			}
			uint num = SafeBuffer.SizeOf<T>();
			byte* ptr = (byte*)((void*)this.handle) + byteOffset;
			this.SpaceCheck(ptr, (ulong)num);
			T result = default(T);
			bool flag = false;
			try
			{
				base.DangerousAddRef(ref flag);
				try
				{
					fixed (byte* ptr2 = Unsafe.As<T, byte>(ref result))
					{
						Buffer.Memmove(ptr2, ptr, num);
					}
				}
				finally
				{
					byte* ptr2 = null;
				}
			}
			finally
			{
				if (flag)
				{
					base.DangerousRelease();
				}
			}
			return result;
		}

		/// <summary>Считывает из памяти указанное количество типов значений, начиная указанного смещения, и записывает их в массив, начиная с указанного индекса.</summary>
		/// <param name="byteOffset">Расположение, с которого начинается считывание.</param>
		/// <param name="array">Выходной массив для записи.</param>
		/// <param name="index">Расположение в выходном массиве, с которого начинается запись.</param>
		/// <param name="count">Количество типов значений, считываемых из входного массива и записываемых в выходной массив.</param>
		/// <typeparam name="T">Считываемый тип значения.</typeparam>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина массива за вычетом индекса меньше значения <paramref name="count" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="Overload:System.Runtime.InteropServices.SafeBuffer.Initialize" /> не был вызван.</exception>
		// Token: 0x06004017 RID: 16407 RVA: 0x000E0798 File Offset: 0x000DE998
		[CLSCompliant(false)]
		public unsafe void ReadArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct
		{
			if (array == null)
			{
				throw new ArgumentNullException("array", "Buffer cannot be null.");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (array.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (this._numBytes == SafeBuffer.Uninitialized)
			{
				throw SafeBuffer.NotInitialized();
			}
			uint num = SafeBuffer.SizeOf<T>();
			uint num2 = SafeBuffer.AlignedSizeOf<T>();
			byte* ptr = (byte*)((void*)this.handle) + byteOffset;
			this.SpaceCheck(ptr, checked(unchecked((ulong)num2) * (ulong)(unchecked((long)count))));
			bool flag = false;
			try
			{
				base.DangerousAddRef(ref flag);
				if (count > 0)
				{
					try
					{
						fixed (byte* ptr2 = Unsafe.As<T, byte>(ref array[index]))
						{
							byte* ptr3 = ptr2;
							for (int i = 0; i < count; i++)
							{
								Buffer.Memmove(ptr3 + (ulong)num * (ulong)((long)i), ptr + (ulong)num2 * (ulong)((long)i), num);
							}
						}
					}
					finally
					{
						byte* ptr2 = null;
					}
				}
			}
			finally
			{
				if (flag)
				{
					base.DangerousRelease();
				}
			}
		}

		/// <summary>Записывает тип значения в память в указанном расположении.</summary>
		/// <param name="byteOffset">Расположение, с которого начинается запись. Может потребоваться продумать проблемы выравнивания.</param>
		/// <param name="value">Значение для записи.</param>
		/// <typeparam name="T">Записываемый тип значения.</typeparam>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="Overload:System.Runtime.InteropServices.SafeBuffer.Initialize" /> не был вызван.</exception>
		// Token: 0x06004018 RID: 16408 RVA: 0x000E08B4 File Offset: 0x000DEAB4
		[CLSCompliant(false)]
		public unsafe void Write<T>(ulong byteOffset, T value) where T : struct
		{
			if (this._numBytes == SafeBuffer.Uninitialized)
			{
				throw SafeBuffer.NotInitialized();
			}
			uint num = SafeBuffer.SizeOf<T>();
			byte* ptr = (byte*)((void*)this.handle) + byteOffset;
			this.SpaceCheck(ptr, (ulong)num);
			bool flag = false;
			try
			{
				base.DangerousAddRef(ref flag);
				try
				{
					fixed (byte* ptr2 = Unsafe.As<T, byte>(ref value))
					{
						byte* src = ptr2;
						Buffer.Memmove(ptr, src, num);
					}
				}
				finally
				{
					byte* ptr2 = null;
				}
			}
			finally
			{
				if (flag)
				{
					base.DangerousRelease();
				}
			}
		}

		/// <summary>Записывает указанное количество типов значений в указанное расположение в памяти, считывая байты входного массива, начиная с указанного расположения.</summary>
		/// <param name="byteOffset">Расположение в памяти, в которое выполняется запись.</param>
		/// <param name="array">Входной массив.</param>
		/// <param name="index">Смещение в этом массиве, с которого начинается считывание.</param>
		/// <param name="count">Число записываемых типов значений.</param>
		/// <typeparam name="T">Записываемый тип значения.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> или <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Длина входного массива за вычетом <paramref name="index" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="Overload:System.Runtime.InteropServices.SafeBuffer.Initialize" /> не был вызван.</exception>
		// Token: 0x06004019 RID: 16409 RVA: 0x000E0944 File Offset: 0x000DEB44
		[CLSCompliant(false)]
		public unsafe void WriteArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct
		{
			if (array == null)
			{
				throw new ArgumentNullException("array", "Buffer cannot be null.");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (array.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (this._numBytes == SafeBuffer.Uninitialized)
			{
				throw SafeBuffer.NotInitialized();
			}
			uint num = SafeBuffer.SizeOf<T>();
			uint num2 = SafeBuffer.AlignedSizeOf<T>();
			byte* ptr = (byte*)((void*)this.handle) + byteOffset;
			this.SpaceCheck(ptr, checked(unchecked((ulong)num2) * (ulong)(unchecked((long)count))));
			bool flag = false;
			try
			{
				base.DangerousAddRef(ref flag);
				if (count > 0)
				{
					try
					{
						fixed (byte* ptr2 = Unsafe.As<T, byte>(ref array[index]))
						{
							byte* ptr3 = ptr2;
							for (int i = 0; i < count; i++)
							{
								Buffer.Memmove(ptr + (ulong)num2 * (ulong)((long)i), ptr3 + (ulong)num * (ulong)((long)i), num);
							}
						}
					}
					finally
					{
						byte* ptr2 = null;
					}
				}
			}
			finally
			{
				if (flag)
				{
					base.DangerousRelease();
				}
			}
		}

		/// <summary>Получает размер буфера (в байтах).</summary>
		/// <returns>Число байтов в буфере памяти.</returns>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="Overload:System.Runtime.InteropServices.SafeBuffer.Initialize" /> не был вызван.</exception>
		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x0600401A RID: 16410 RVA: 0x000E0A60 File Offset: 0x000DEC60
		[CLSCompliant(false)]
		public ulong ByteLength
		{
			get
			{
				if (this._numBytes == SafeBuffer.Uninitialized)
				{
					throw SafeBuffer.NotInitialized();
				}
				return (ulong)this._numBytes;
			}
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x000E0A85 File Offset: 0x000DEC85
		private unsafe void SpaceCheck(byte* ptr, ulong sizeInBytes)
		{
			if ((ulong)this._numBytes < sizeInBytes)
			{
				SafeBuffer.NotEnoughRoom();
			}
			if ((long)((byte*)ptr - (byte*)((void*)this.handle)) > (long)((ulong)this._numBytes - sizeInBytes))
			{
				SafeBuffer.NotEnoughRoom();
			}
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x000E0ABE File Offset: 0x000DECBE
		private static void NotEnoughRoom()
		{
			throw new ArgumentException("Not enough space available in the buffer.");
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x000E0ACA File Offset: 0x000DECCA
		private static InvalidOperationException NotInitialized()
		{
			return new InvalidOperationException("You must call Initialize on this object instance before using it.");
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x000E0AD8 File Offset: 0x000DECD8
		internal static uint AlignedSizeOf<T>() where T : struct
		{
			uint num = SafeBuffer.SizeOf<T>();
			if (num == 1U || num == 2U)
			{
				return num;
			}
			return (uint)((ulong)(num + 3U) & 18446744073709551612UL);
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x000E0AFE File Offset: 0x000DECFE
		internal static uint SizeOf<T>() where T : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				throw new ArgumentException("The specified Type must be a struct containing no references.");
			}
			return (uint)Unsafe.SizeOf<T>();
		}

		// Token: 0x04002A15 RID: 10773
		private static readonly UIntPtr Uninitialized = (UIntPtr.Size == 4) ? ((UIntPtr)uint.MaxValue) : ((UIntPtr)ulong.MaxValue);

		// Token: 0x04002A16 RID: 10774
		private UIntPtr _numBytes;
	}
}
