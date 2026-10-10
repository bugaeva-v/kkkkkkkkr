using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.IO
{
	/// <summary>Предоставляет произвольный доступ к неуправляемым блокам памяти из управляемого кода.</summary>
	// Token: 0x02000B28 RID: 2856
	public class UnmanagedMemoryAccessor : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.UnmanagedMemoryAccessor" />.</summary>
		// Token: 0x0600666B RID: 26219 RVA: 0x0015D89A File Offset: 0x0015BA9A
		protected UnmanagedMemoryAccessor()
		{
			this._isOpen = false;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.UnmanagedMemoryAccessor" /> указанными буфером, смещением и емкостью.</summary>
		/// <param name="buffer">Буфер, который должен содержать метод доступа.</param>
		/// <param name="offset">Байт, с которого должен начинаться метод доступа.</param>
		/// <param name="capacity">Размер выделяемой памяти (в байтах).</param>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="capacity" /> больше значения <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> или <paramref name="capacity" /> меньше нуля.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сумма <paramref name="offset" /> и <paramref name="capacity" /> выйдет за верхний предел адресного пространства.</exception>
		// Token: 0x0600666C RID: 26220 RVA: 0x0015D8A9 File Offset: 0x0015BAA9
		public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity)
		{
			this.Initialize(buffer, offset, capacity, FileAccess.Read);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.UnmanagedMemoryAccessor" /> указанными буфером, смещением, емкостью и правами доступа.</summary>
		/// <param name="buffer">Буфер, который должен содержать метод доступа.</param>
		/// <param name="offset">Байт, с которого должен начинаться метод доступа.</param>
		/// <param name="capacity">Размер выделяемой памяти (в байтах).</param>
		/// <param name="access">Тип разрешенного доступа к памяти. Значение по умолчанию — <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />.</param>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="capacity" /> больше значения <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> или <paramref name="capacity" /> меньше нуля.  
		///
		/// или - 
		/// <paramref name="access" /> не является допустимым значением перечисления <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сумма <paramref name="offset" /> и <paramref name="capacity" /> выйдет за верхний предел адресного пространства.</exception>
		// Token: 0x0600666D RID: 26221 RVA: 0x0015D8BB File Offset: 0x0015BABB
		public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity, FileAccess access)
		{
			this.Initialize(buffer, offset, capacity, access);
		}

		/// <summary>Задает начальные значения для метода доступа.</summary>
		/// <param name="buffer">Буфер, который должен содержать метод доступа.</param>
		/// <param name="offset">Байт, с которого должен начинаться метод доступа.</param>
		/// <param name="capacity">Размер выделяемой памяти (в байтах).</param>
		/// <param name="access">Тип разрешенного доступа к памяти. Значение по умолчанию — <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite" />.</param>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="offset" /> и <paramref name="capacity" /> больше значения <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> или <paramref name="capacity" /> меньше нуля.  
		///
		/// или - 
		/// <paramref name="access" /> не является допустимым значением перечисления <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFileAccess" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сумма <paramref name="offset" /> и <paramref name="capacity" /> выйдет за верхний предел адресного пространства.</exception>
		// Token: 0x0600666E RID: 26222 RVA: 0x0015D8D0 File Offset: 0x0015BAD0
		protected unsafe void Initialize(SafeBuffer buffer, long offset, long capacity, FileAccess access)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0L)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (capacity < 0L)
			{
				throw new ArgumentOutOfRangeException("capacity", "Non-negative number required.");
			}
			if (buffer.ByteLength < (ulong)(offset + capacity))
			{
				throw new ArgumentException("Offset and capacity were greater than the size of the view.");
			}
			if (access < FileAccess.Read || access > FileAccess.ReadWrite)
			{
				throw new ArgumentOutOfRangeException("access");
			}
			if (this._isOpen)
			{
				throw new InvalidOperationException("The method cannot be called twice on the same instance.");
			}
			byte* ptr = null;
			try
			{
				buffer.AcquirePointer(ref ptr);
				if (ptr + offset + capacity < ptr)
				{
					throw new ArgumentException("The UnmanagedMemoryAccessor capacity and offset would wrap around the high end of the address space.");
				}
			}
			finally
			{
				if (ptr != null)
				{
					buffer.ReleasePointer();
				}
			}
			this._offset = offset;
			this._buffer = buffer;
			this._capacity = capacity;
			this._access = access;
			this._isOpen = true;
			this._canRead = ((this._access & FileAccess.Read) > (FileAccess)0);
			this._canWrite = ((this._access & FileAccess.Write) > (FileAccess)0);
		}

		/// <summary>Возвращает емкость метода доступа.</summary>
		/// <returns>Емкость метода доступа.</returns>
		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x0600666F RID: 26223 RVA: 0x0015D9D8 File Offset: 0x0015BBD8
		public long Capacity
		{
			get
			{
				return this._capacity;
			}
		}

		/// <summary>Определяет, доступен ли метод доступа для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если метод доступа доступен для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06006670 RID: 26224 RVA: 0x0015D9E0 File Offset: 0x0015BBE0
		public bool CanRead
		{
			get
			{
				return this._isOpen && this._canRead;
			}
		}

		/// <summary>Определяет, доступен ли метод доступа для записи.</summary>
		/// <returns>Значение <see langword="true" />, если метод доступа доступен для записи; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06006671 RID: 26225 RVA: 0x0015D9F2 File Offset: 0x0015BBF2
		public bool CanWrite
		{
			get
			{
				return this._isOpen && this._canWrite;
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.UnmanagedMemoryAccessor" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06006672 RID: 26226 RVA: 0x0015DA04 File Offset: 0x0015BC04
		protected virtual void Dispose(bool disposing)
		{
			this._isOpen = false;
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.IO.UnmanagedMemoryAccessor" />.</summary>
		// Token: 0x06006673 RID: 26227 RVA: 0x0015DA0D File Offset: 0x0015BC0D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Определяет, открыт ли метод доступа процессом в текущий момент.</summary>
		/// <returns>Значение <see langword="true" />, если метод доступа открыт; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06006674 RID: 26228 RVA: 0x0015DA1C File Offset: 0x0015BC1C
		protected bool IsOpen
		{
			get
			{
				return this._isOpen;
			}
		}

		/// <summary>Считывает из метода доступа логическое значение.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>
		///   <see langword="true" /> или <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006675 RID: 26229 RVA: 0x0015DA24 File Offset: 0x0015BC24
		public bool ReadBoolean(long position)
		{
			return this.ReadByte(position) > 0;
		}

		/// <summary>Считывает из метода доступа значение байта.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>Прочитанное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006676 RID: 26230 RVA: 0x0015DA30 File Offset: 0x0015BC30
		public unsafe byte ReadByte(long position)
		{
			this.EnsureSafeToRead(position, 1);
			byte* ptr = null;
			byte result;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				result = (ptr + this._offset)[position];
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
			return result;
		}

		/// <summary>Считывает из метода доступа символ.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>Прочитанное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006677 RID: 26231 RVA: 0x0015DA88 File Offset: 0x0015BC88
		public char ReadChar(long position)
		{
			return (char)this.ReadInt16(position);
		}

		/// <summary>Считывает из метода доступа 16-разрядное целое число.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>Прочитанное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006678 RID: 26232 RVA: 0x0015DA94 File Offset: 0x0015BC94
		public unsafe short ReadInt16(long position)
		{
			this.EnsureSafeToRead(position, 2);
			byte* ptr = null;
			short result;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				result = Unsafe.ReadUnaligned<short>((void*)(ptr + this._offset + position));
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
			return result;
		}

		/// <summary>Считывает из метода доступа 32-разрядное целое число.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>Прочитанное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006679 RID: 26233 RVA: 0x0015DAF0 File Offset: 0x0015BCF0
		public unsafe int ReadInt32(long position)
		{
			this.EnsureSafeToRead(position, 4);
			byte* ptr = null;
			int result;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				result = Unsafe.ReadUnaligned<int>((void*)(ptr + this._offset + position));
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
			return result;
		}

		/// <summary>Считывает из метода доступа 64-разрядное целое число.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>Прочитанное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x0600667A RID: 26234 RVA: 0x0015DB4C File Offset: 0x0015BD4C
		public unsafe long ReadInt64(long position)
		{
			this.EnsureSafeToRead(position, 8);
			byte* ptr = null;
			long result;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				result = Unsafe.ReadUnaligned<long>((void*)(ptr + this._offset + position));
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
			return result;
		}

		/// <summary>Считывает из метода доступа десятичное число.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>Прочитанное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.  
		///
		/// или - 
		/// Считываемое десятичное число недопустимо.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x0600667B RID: 26235 RVA: 0x0015DBA8 File Offset: 0x0015BDA8
		public unsafe decimal ReadDecimal(long position)
		{
			this.EnsureSafeToRead(position, 16);
			byte* ptr = null;
			int lo;
			int mid;
			int hi;
			int num;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				ptr += this._offset + position;
				lo = Unsafe.ReadUnaligned<int>((void*)ptr);
				mid = Unsafe.ReadUnaligned<int>((void*)(ptr + 4));
				hi = Unsafe.ReadUnaligned<int>((void*)(ptr + 8));
				num = Unsafe.ReadUnaligned<int>((void*)(ptr + 12));
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
			if ((num & 2130771967) != 0 || (num & 16711680) > 1835008)
			{
				throw new ArgumentException("Read an invalid decimal value from the buffer.");
			}
			bool isNegative = (num & int.MinValue) != 0;
			byte scale = (byte)(num >> 16);
			return new decimal(lo, mid, hi, isNegative, scale);
		}

		/// <summary>Считывает из метода доступа значение с плавающей запятой одиночной точности.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>Прочитанное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x0600667C RID: 26236 RVA: 0x0015DC6C File Offset: 0x0015BE6C
		public float ReadSingle(long position)
		{
			return BitConverter.Int32BitsToSingle(this.ReadInt32(position));
		}

		/// <summary>Считывает из метода доступа значение с плавающей запятой двойной точности.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>Прочитанное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x0600667D RID: 26237 RVA: 0x0015DC7A File Offset: 0x0015BE7A
		public double ReadDouble(long position)
		{
			return BitConverter.Int64BitsToDouble(this.ReadInt64(position));
		}

		/// <summary>Считывает из метода доступа 8-разрядное целое число со знаком.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>Прочитанное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x0600667E RID: 26238 RVA: 0x0015DC88 File Offset: 0x0015BE88
		[CLSCompliant(false)]
		public sbyte ReadSByte(long position)
		{
			return (sbyte)this.ReadByte(position);
		}

		/// <summary>Считывает из метода доступа 16-разрядное целое число без знака.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>Прочитанное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x0600667F RID: 26239 RVA: 0x0015DA88 File Offset: 0x0015BC88
		[CLSCompliant(false)]
		public ushort ReadUInt16(long position)
		{
			return (ushort)this.ReadInt16(position);
		}

		/// <summary>Считывает из метода доступа 32-разрядное целое число без знака.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>Прочитанное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006680 RID: 26240 RVA: 0x0015DC92 File Offset: 0x0015BE92
		[CLSCompliant(false)]
		public uint ReadUInt32(long position)
		{
			return (uint)this.ReadInt32(position);
		}

		/// <summary>Считывает из метода доступа 64-разрядное целое число без знака.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <returns>Прочитанное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006681 RID: 26241 RVA: 0x0015DC9B File Offset: 0x0015BE9B
		[CLSCompliant(false)]
		public ulong ReadUInt64(long position)
		{
			return (ulong)this.ReadInt64(position);
		}

		/// <summary>Считывает из метода доступа структуру типа <paramref name="T" /> и передает ее по указанной ссылке.</summary>
		/// <param name="position">Позиция в методе доступа, с которой начинается чтение.</param>
		/// <param name="structure">Структура, которая будет содержать считываемые данные.</param>
		/// <typeparam name="T">Тип структуры.</typeparam>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для чтения в структуре типа <paramref name="T" />.  
		///
		/// или - 
		/// <see langword="T" /> является типом значений, содержащим один или несколько ссылочных типов.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006682 RID: 26242 RVA: 0x0015DCA4 File Offset: 0x0015BEA4
		public void Read<T>(long position, out T structure) where T : struct
		{
			if (position < 0L)
			{
				throw new ArgumentOutOfRangeException("position", "Non-negative number required.");
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", "Cannot access a closed accessor.");
			}
			if (!this._canRead)
			{
				throw new NotSupportedException("Accessor does not support reading.");
			}
			uint num = SafeBuffer.SizeOf<T>();
			if (position <= this._capacity - (long)((ulong)num))
			{
				structure = this._buffer.Read<T>((ulong)(this._offset + position));
				return;
			}
			if (position >= this._capacity)
			{
				throw new ArgumentOutOfRangeException("position", "The position may not be greater or equal to the capacity of the accessor.");
			}
			throw new ArgumentException(SR.Format("There are not enough bytes remaining in the accessor to read at this position.", typeof(T)), "position");
		}

		/// <summary>Считывает из метода доступа структуры типа <paramref name="T" /> и передает их в массив типа <paramref name="T" />.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должно начаться чтение.</param>
		/// <param name="array">Массив, который будет содержать считываемые из метода доступа структуры.</param>
		/// <param name="offset">Индекс в массиве <paramref name="array" />, по которому будет помещена первая скопированная структура.</param>
		/// <param name="count">Число структур типа T, которое необходимо считать из метода доступа.</param>
		/// <typeparam name="T">Тип структуры.</typeparam>
		/// <returns>Число структур, считанных в массив <paramref name="array" />. Это число может быть меньше значения <paramref name="count" />, если доступно меньшее число структур, или равняться нулю, если достигнут конец метода доступа.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> недостаточно велик для размещения <paramref name="count" /> структур (начиная с <paramref name="position" />).</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает чтение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006683 RID: 26243 RVA: 0x0015DD54 File Offset: 0x0015BF54
		public int ReadArray<T>(long position, T[] array, int offset, int count) where T : struct
		{
			if (array == null)
			{
				throw new ArgumentNullException("array", "Buffer cannot be null.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (array.Length - offset < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", "Cannot access a closed accessor.");
			}
			if (!this._canRead)
			{
				throw new NotSupportedException("Accessor does not support reading.");
			}
			if (position < 0L)
			{
				throw new ArgumentOutOfRangeException("position", "Non-negative number required.");
			}
			uint num = SafeBuffer.AlignedSizeOf<T>();
			if (position >= this._capacity)
			{
				throw new ArgumentOutOfRangeException("position", "The position may not be greater or equal to the capacity of the accessor.");
			}
			int num2 = count;
			long num3 = this._capacity - position;
			if (num3 < 0L)
			{
				num2 = 0;
			}
			else
			{
				ulong num4 = (ulong)num * (ulong)((long)count);
				if (num3 < (long)num4)
				{
					num2 = (int)(num3 / (long)((ulong)num));
				}
			}
			this._buffer.ReadArray<T>((ulong)(this._offset + position), array, offset, num2);
			return num2;
		}

		/// <summary>Записывает в метод доступа логическое значение.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для записи значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006684 RID: 26244 RVA: 0x0015DE4D File Offset: 0x0015C04D
		public void Write(long position, bool value)
		{
			this.Write(position, value ? 1 : 0);
		}

		/// <summary>Записывает в метод доступа значение байта.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для записи значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006685 RID: 26245 RVA: 0x0015DE60 File Offset: 0x0015C060
		public unsafe void Write(long position, byte value)
		{
			this.EnsureSafeToWrite(position, 1);
			byte* ptr = null;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				(ptr + this._offset)[position] = value;
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
		}

		/// <summary>Записывает в метод доступа символ.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для записи значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006686 RID: 26246 RVA: 0x0015DEB8 File Offset: 0x0015C0B8
		public void Write(long position, char value)
		{
			this.Write(position, (short)value);
		}

		/// <summary>Записывает в метод доступа 16-разрядное целое число.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для записи значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006687 RID: 26247 RVA: 0x0015DEC4 File Offset: 0x0015C0C4
		public unsafe void Write(long position, short value)
		{
			this.EnsureSafeToWrite(position, 2);
			byte* ptr = null;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				Unsafe.WriteUnaligned<short>((void*)(ptr + this._offset + position), value);
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
		}

		/// <summary>Записывает в метод доступа 32-разрядное целое число.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для записи значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006688 RID: 26248 RVA: 0x0015DF20 File Offset: 0x0015C120
		public unsafe void Write(long position, int value)
		{
			this.EnsureSafeToWrite(position, 4);
			byte* ptr = null;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				Unsafe.WriteUnaligned<int>((void*)(ptr + this._offset + position), value);
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
		}

		/// <summary>Записывает в метод доступа 64-разрядное целое число.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после позиции для записи значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006689 RID: 26249 RVA: 0x0015DF7C File Offset: 0x0015C17C
		public unsafe void Write(long position, long value)
		{
			this.EnsureSafeToWrite(position, 8);
			byte* ptr = null;
			try
			{
				this._buffer.AcquirePointer(ref ptr);
				Unsafe.WriteUnaligned<long>((void*)(ptr + this._offset + position), value);
			}
			finally
			{
				if (ptr != null)
				{
					this._buffer.ReleasePointer();
				}
			}
		}

		/// <summary>Записывает в метод доступа десятичное число.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для записи значения.  
		///
		/// или - 
		/// Десятичное число недопустимо.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x0600668A RID: 26250 RVA: 0x0015DFD8 File Offset: 0x0015C1D8
		public unsafe void Write(long position, decimal value)
		{
			this.EnsureSafeToWrite(position, 16);
			int* ptr = (int*)(&value);
			int value2 = *ptr;
			int value3 = ptr[1];
			int value4 = ptr[2];
			int value5 = ptr[3];
			byte* ptr2 = null;
			try
			{
				this._buffer.AcquirePointer(ref ptr2);
				ptr2 += this._offset + position;
				Unsafe.WriteUnaligned<int>((void*)ptr2, value4);
				Unsafe.WriteUnaligned<int>((void*)(ptr2 + 4), value5);
				Unsafe.WriteUnaligned<int>((void*)(ptr2 + 8), value3);
				Unsafe.WriteUnaligned<int>((void*)(ptr2 + 12), value2);
			}
			finally
			{
				if (ptr2 != null)
				{
					this._buffer.ReleasePointer();
				}
			}
		}

		/// <summary>Записывает в метод доступа значение типа <see langword="Single" />.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для записи значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x0600668B RID: 26251 RVA: 0x0015E078 File Offset: 0x0015C278
		public void Write(long position, float value)
		{
			this.Write(position, BitConverter.SingleToInt32Bits(value));
		}

		/// <summary>Записывает в метод доступа значение типа <see langword="Double" />.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для записи значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x0600668C RID: 26252 RVA: 0x0015E087 File Offset: 0x0015C287
		public void Write(long position, double value)
		{
			this.Write(position, BitConverter.DoubleToInt64Bits(value));
		}

		/// <summary>Записывает в метод доступа 8-разрядное целое число.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для записи значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x0600668D RID: 26253 RVA: 0x0015E096 File Offset: 0x0015C296
		[CLSCompliant(false)]
		public void Write(long position, sbyte value)
		{
			this.Write(position, (byte)value);
		}

		/// <summary>Записывает в метод доступа 16-разрядное целое число без знака.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для записи значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x0600668E RID: 26254 RVA: 0x0015DEB8 File Offset: 0x0015C0B8
		[CLSCompliant(false)]
		public void Write(long position, ushort value)
		{
			this.Write(position, (short)value);
		}

		/// <summary>Записывает в метод доступа 32-разрядное целое число без знака.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для записи значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x0600668F RID: 26255 RVA: 0x0015E0A1 File Offset: 0x0015C2A1
		[CLSCompliant(false)]
		public void Write(long position, uint value)
		{
			this.Write(position, (int)value);
		}

		/// <summary>Записывает в метод доступа 64-разрядное целое число без знака.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов после <paramref name="position" /> для записи значения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006690 RID: 26256 RVA: 0x0015E0AB File Offset: 0x0015C2AB
		[CLSCompliant(false)]
		public void Write(long position, ulong value)
		{
			this.Write(position, (long)value);
		}

		/// <summary>Записывает в метод доступа структуру.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="structure">Структура, которую требуется записать.</param>
		/// <typeparam name="T">Тип структуры.</typeparam>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов в методе доступа после <paramref name="position" /> для записи структуры типа <paramref name="T" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006691 RID: 26257 RVA: 0x0015E0B8 File Offset: 0x0015C2B8
		public void Write<T>(long position, ref T structure) where T : struct
		{
			if (position < 0L)
			{
				throw new ArgumentOutOfRangeException("position", "Non-negative number required.");
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", "Cannot access a closed accessor.");
			}
			if (!this._canWrite)
			{
				throw new NotSupportedException("Accessor does not support writing.");
			}
			uint num = SafeBuffer.SizeOf<T>();
			if (position <= this._capacity - (long)((ulong)num))
			{
				this._buffer.Write<T>((ulong)(this._offset + position), structure);
				return;
			}
			if (position >= this._capacity)
			{
				throw new ArgumentOutOfRangeException("position", "The position may not be greater or equal to the capacity of the accessor.");
			}
			throw new ArgumentException(SR.Format("There are not enough bytes remaining in the accessor to write at this position.", typeof(T)), "position");
		}

		/// <summary>Записывает в метод доступа структуры из массива типа <paramref name="T" />.</summary>
		/// <param name="position">Число байтов в методе доступа, с которого должна начаться запись.</param>
		/// <param name="array">Массив, из которого ведется запись в метод доступа.</param>
		/// <param name="offset">Индекс в массиве <paramref name="array" />, с которого требуется начать запись.</param>
		/// <param name="count">Число структур в массиве <paramref name="array" />, которые требуется записать.</param>
		/// <typeparam name="T">Тип структуры.</typeparam>
		/// <exception cref="T:System.ArgumentException">Не хватает байтов в методе доступа после <paramref name="position" /> для записи числа структур, указанных <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="position" /> меньше нуля или больше емкости метода доступа.  
		///
		/// или - 
		/// Значение параметра <paramref name="offset" /> или <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Метод доступа не поддерживает запись.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект доступа был освобожден.</exception>
		// Token: 0x06006692 RID: 26258 RVA: 0x0015E168 File Offset: 0x0015C368
		public void WriteArray<T>(long position, T[] array, int offset, int count) where T : struct
		{
			if (array == null)
			{
				throw new ArgumentNullException("array", "Buffer cannot be null.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (array.Length - offset < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (position < 0L)
			{
				throw new ArgumentOutOfRangeException("position", "Non-negative number required.");
			}
			if (position >= this.Capacity)
			{
				throw new ArgumentOutOfRangeException("position", "The position may not be greater or equal to the capacity of the accessor.");
			}
			if (!this._isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", "Cannot access a closed accessor.");
			}
			if (!this._canWrite)
			{
				throw new NotSupportedException("Accessor does not support writing.");
			}
			this._buffer.WriteArray<T>((ulong)(this._offset + position), array, offset, count);
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x0015E238 File Offset: 0x0015C438
		private void EnsureSafeToRead(long position, int sizeOfType)
		{
			if (!this._isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", "Cannot access a closed accessor.");
			}
			if (!this._canRead)
			{
				throw new NotSupportedException("Accessor does not support reading.");
			}
			if (position < 0L)
			{
				throw new ArgumentOutOfRangeException("position", "Non-negative number required.");
			}
			if (position <= this._capacity - (long)sizeOfType)
			{
				return;
			}
			if (position >= this._capacity)
			{
				throw new ArgumentOutOfRangeException("position", "The position may not be greater or equal to the capacity of the accessor.");
			}
			throw new ArgumentException("There are not enough bytes remaining in the accessor to read at this position.", "position");
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x0015E2BC File Offset: 0x0015C4BC
		private void EnsureSafeToWrite(long position, int sizeOfType)
		{
			if (!this._isOpen)
			{
				throw new ObjectDisposedException("UnmanagedMemoryAccessor", "Cannot access a closed accessor.");
			}
			if (!this._canWrite)
			{
				throw new NotSupportedException("Accessor does not support writing.");
			}
			if (position < 0L)
			{
				throw new ArgumentOutOfRangeException("position", "Non-negative number required.");
			}
			if (position <= this._capacity - (long)sizeOfType)
			{
				return;
			}
			if (position >= this._capacity)
			{
				throw new ArgumentOutOfRangeException("position", "The position may not be greater or equal to the capacity of the accessor.");
			}
			throw new ArgumentException("There are not enough bytes remaining in the accessor to write at this position.", "position");
		}

		// Token: 0x04003C0D RID: 15373
		private SafeBuffer _buffer;

		// Token: 0x04003C0E RID: 15374
		private long _offset;

		// Token: 0x04003C0F RID: 15375
		private long _capacity;

		// Token: 0x04003C10 RID: 15376
		private FileAccess _access;

		// Token: 0x04003C11 RID: 15377
		private bool _isOpen;

		// Token: 0x04003C12 RID: 15378
		private bool _canRead;

		// Token: 0x04003C13 RID: 15379
		private bool _canWrite;
	}
}
