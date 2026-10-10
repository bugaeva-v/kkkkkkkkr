using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Mono.Security;

namespace System.IO
{
	/// <summary>Считывает примитивные типы данных как двоичные значения в заданной кодировке.</summary>
	// Token: 0x02000B57 RID: 2903
	[ComVisible(true)]
	public class BinaryReader : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.BinaryReader" /> на основании указанного потока с использованием кодировки UTF-8.</summary>
		/// <param name="input">Входной поток.</param>
		/// <exception cref="T:System.ArgumentException">Поток не поддерживает чтение, имеет значение <see langword="null" /> или уже закрыт.</exception>
		// Token: 0x060068FA RID: 26874 RVA: 0x00166873 File Offset: 0x00164A73
		public BinaryReader(Stream input) : this(input, new UTF8Encoding(), false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.BinaryReader" /> на основе указанного потока и кодировки символов.</summary>
		/// <param name="input">Входной поток.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <exception cref="T:System.ArgumentException">Поток не поддерживает чтение, имеет значение <see langword="null" /> или уже закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="encoding" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060068FB RID: 26875 RVA: 0x00166882 File Offset: 0x00164A82
		public BinaryReader(Stream input, Encoding encoding) : this(input, encoding, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.BinaryReader" /> на основе указанного потока и кодировки символов, а также при необходимости оставляет поток открытым.</summary>
		/// <param name="input">Входной поток.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <param name="leaveOpen">Значение <see langword="true" />, чтобы оставить поток открытым после удаления объекта <see cref="T:System.IO.BinaryReader" />; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">Поток не поддерживает чтение, имеет значение <see langword="null" /> или уже закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="encoding" /> или <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060068FC RID: 26876 RVA: 0x00166890 File Offset: 0x00164A90
		public BinaryReader(Stream input, Encoding encoding, bool leaveOpen)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (!input.CanRead)
			{
				throw new ArgumentException(Environment.GetResourceString("Stream was not readable."));
			}
			this.m_stream = input;
			this.m_decoder = encoding.GetDecoder();
			this.m_maxCharsSize = encoding.GetMaxCharCount(128);
			int num = encoding.GetMaxByteCount(1);
			if (num < 16)
			{
				num = 16;
			}
			this.m_buffer = new byte[num];
			this.m_2BytesPerChar = (encoding is UnicodeEncoding);
			this.m_isMemoryStream = (this.m_stream.GetType() == typeof(MemoryStream));
			this.m_leaveOpen = leaveOpen;
		}

		/// <summary>Предоставляет доступ к базовому потоку объекта <see cref="T:System.IO.BinaryReader" />.</summary>
		/// <returns>Базовый поток, связанный с объектом <see langword="BinaryReader" />.</returns>
		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x060068FD RID: 26877 RVA: 0x0016694D File Offset: 0x00164B4D
		public virtual Stream BaseStream
		{
			get
			{
				return this.m_stream;
			}
		}

		/// <summary>Закрывает текущий поток чтения и связанный с ним базовый поток.</summary>
		// Token: 0x060068FE RID: 26878 RVA: 0x00166955 File Offset: 0x00164B55
		public virtual void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые классом <see cref="T:System.IO.BinaryReader" /> (при необходимости освобождает и управляемые ресурсы).</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x060068FF RID: 26879 RVA: 0x00166960 File Offset: 0x00164B60
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				Stream stream = this.m_stream;
				this.m_stream = null;
				if (stream != null && !this.m_leaveOpen)
				{
					stream.Close();
				}
			}
			this.m_stream = null;
			this.m_buffer = null;
			this.m_decoder = null;
			this.m_charBytes = null;
			this.m_singleChar = null;
			this.m_charBuffer = null;
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.IO.BinaryReader" />.</summary>
		// Token: 0x06006900 RID: 26880 RVA: 0x00166955 File Offset: 0x00164B55
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Возвращает следующий доступный для чтения символ, не перемещая позицию байта или символа вперед.</summary>
		/// <returns>Следующий доступный символ или значение -1, если в потоке больше нет символов, или поток не поддерживает поиск.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ArgumentException">Текущий символ не может быт декодирован в буфер внутренних символов с помощью <see cref="T:System.Text.Encoding" />, выбранного для потока.</exception>
		// Token: 0x06006901 RID: 26881 RVA: 0x001669BC File Offset: 0x00164BBC
		public virtual int PeekChar()
		{
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			if (!this.m_stream.CanSeek)
			{
				return -1;
			}
			long position = this.m_stream.Position;
			int result = this.Read();
			this.m_stream.Position = position;
			return result;
		}

		/// <summary>Выполняет чтение знаков из базового потока и перемещает текущую позицию в потоке вперед в соответствии с используемым значением <see langword="Encoding" /> и конкретным знаком в потоке, чтение которого выполняется в настоящий момент.</summary>
		/// <returns>Следующий символ из входного потока или значение -1, если в настоящее время доступных символов нет.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006902 RID: 26882 RVA: 0x00166A03 File Offset: 0x00164C03
		public virtual int Read()
		{
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			return this.InternalReadOneChar();
		}

		/// <summary>Считывает значение <see langword="Boolean" /> из текущего потока и перемещает текущую позицию в потоке на один байт вперед.</summary>
		/// <returns>Значение <see langword="true" />, если байт не равен нулю; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006903 RID: 26883 RVA: 0x00166A18 File Offset: 0x00164C18
		public virtual bool ReadBoolean()
		{
			this.FillBuffer(1);
			return this.m_buffer[0] > 0;
		}

		/// <summary>Считывает из текущего потока следующий байт и перемещает текущую позицию в потоке на один байт вперед.</summary>
		/// <returns>Следующий байт, считанный из текущего потока.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006904 RID: 26884 RVA: 0x00166A2C File Offset: 0x00164C2C
		public virtual byte ReadByte()
		{
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			int num = this.m_stream.ReadByte();
			if (num == -1)
			{
				__Error.EndOfFile();
			}
			return (byte)num;
		}

		/// <summary>Считывает из текущего потока байт со знаком и перемещает текущую позицию в потоке на один байт вперед.</summary>
		/// <returns>Байт со знаком, считанный из текущего потока.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006905 RID: 26885 RVA: 0x00166A50 File Offset: 0x00164C50
		[CLSCompliant(false)]
		public virtual sbyte ReadSByte()
		{
			this.FillBuffer(1);
			return (sbyte)this.m_buffer[0];
		}

		/// <summary>Считывает следующий знак из текущего потока и изменяет текущую позицию в потоке в соответствии с используемым значением <see langword="Encoding" /> и конкретным знаком в потоке, чтение которого выполняется в настоящий момент.</summary>
		/// <returns>Символ, считанный из текущего потока.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ArgumentException">Выполнено чтение символа-заместителя.</exception>
		// Token: 0x06006906 RID: 26886 RVA: 0x00166A62 File Offset: 0x00164C62
		public virtual char ReadChar()
		{
			int num = this.Read();
			if (num == -1)
			{
				__Error.EndOfFile();
			}
			return (char)num;
		}

		/// <summary>Считывает целое число со знаком длиной 2 байта из текущего потока и перемещает текущую позицию в потоке на два байта вперед.</summary>
		/// <returns>Целое число со знаком длиной 2 байта, считанное из текущего потока.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006907 RID: 26887 RVA: 0x00166A74 File Offset: 0x00164C74
		public virtual short ReadInt16()
		{
			this.FillBuffer(2);
			return (short)((int)this.m_buffer[0] | (int)this.m_buffer[1] << 8);
		}

		/// <summary>Считывает целое число без знака длиной 2 байта в формате с прямым порядком байтов из текущего потока и перемещает текущую позицию в потоке на два байта вперед.</summary>
		/// <returns>Целое число без знака длиной 2 байта, считанное из текущего потока.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006908 RID: 26888 RVA: 0x00166A91 File Offset: 0x00164C91
		[CLSCompliant(false)]
		public virtual ushort ReadUInt16()
		{
			this.FillBuffer(2);
			return (ushort)((int)this.m_buffer[0] | (int)this.m_buffer[1] << 8);
		}

		/// <summary>Считывает целое число со знаком длиной 4 байта из текущего потока и перемещает текущую позицию в потоке на четыре байта вперед.</summary>
		/// <returns>Целое число со знаком длиной 2 байта, считанное из текущего потока.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006909 RID: 26889 RVA: 0x00166AB0 File Offset: 0x00164CB0
		public virtual int ReadInt32()
		{
			if (this.m_isMemoryStream)
			{
				if (this.m_stream == null)
				{
					__Error.FileNotOpen();
				}
				return (this.m_stream as MemoryStream).InternalReadInt32();
			}
			this.FillBuffer(4);
			return (int)this.m_buffer[0] | (int)this.m_buffer[1] << 8 | (int)this.m_buffer[2] << 16 | (int)this.m_buffer[3] << 24;
		}

		/// <summary>Считывает целое число без знака длиной 4 байта из текущего потока и перемещает текущую позицию в потоке на четыре байта вперед.</summary>
		/// <returns>Целое число без знака длиной 4 байта, считанное из текущего потока.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600690A RID: 26890 RVA: 0x00166B15 File Offset: 0x00164D15
		[CLSCompliant(false)]
		public virtual uint ReadUInt32()
		{
			this.FillBuffer(4);
			return (uint)((int)this.m_buffer[0] | (int)this.m_buffer[1] << 8 | (int)this.m_buffer[2] << 16 | (int)this.m_buffer[3] << 24);
		}

		/// <summary>Считывает целое число со знаком длиной 8 байта из текущего потока и перемещает текущую позицию в потоке на восемь байт вперед.</summary>
		/// <returns>Целое число со знаком длиной 8 байт, считанное из текущего потока.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600690B RID: 26891 RVA: 0x00166B4C File Offset: 0x00164D4C
		public virtual long ReadInt64()
		{
			this.FillBuffer(8);
			uint num = (uint)((int)this.m_buffer[0] | (int)this.m_buffer[1] << 8 | (int)this.m_buffer[2] << 16 | (int)this.m_buffer[3] << 24);
			return (long)((ulong)((int)this.m_buffer[4] | (int)this.m_buffer[5] << 8 | (int)this.m_buffer[6] << 16 | (int)this.m_buffer[7] << 24) << 32 | (ulong)num);
		}

		/// <summary>Считывает целое число без знака длиной 8 байт из текущего потока и перемещает текущую позицию в потоке на восемь байтов вперед.</summary>
		/// <returns>Целое число без знака длиной 8 байт, считанное из текущего потока.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x0600690C RID: 26892 RVA: 0x00166BC0 File Offset: 0x00164DC0
		[CLSCompliant(false)]
		public virtual ulong ReadUInt64()
		{
			this.FillBuffer(8);
			uint num = (uint)((int)this.m_buffer[0] | (int)this.m_buffer[1] << 8 | (int)this.m_buffer[2] << 16 | (int)this.m_buffer[3] << 24);
			return (ulong)((int)this.m_buffer[4] | (int)this.m_buffer[5] << 8 | (int)this.m_buffer[6] << 16 | (int)this.m_buffer[7] << 24) << 32 | (ulong)num;
		}

		/// <summary>Считывает число с плавающей запятой длиной 4 байта из текущего потока и перемещает текущую позицию в потоке на четыре байта вперед.</summary>
		/// <returns>Число с плавающей запятой длиной 4 байта, считанное из текущего потока.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600690D RID: 26893 RVA: 0x00166C32 File Offset: 0x00164E32
		[SecuritySafeCritical]
		public virtual float ReadSingle()
		{
			this.FillBuffer(4);
			return BitConverterLE.ToSingle(this.m_buffer, 0);
		}

		/// <summary>Считывает число с плавающей запятой длиной 8 байт из текущего потока и перемещает текущую позицию в потоке на восемь байт вперед.</summary>
		/// <returns>Число с плавающей запятой длиной 8 байт, считанное из текущего потока.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600690E RID: 26894 RVA: 0x00166C47 File Offset: 0x00164E47
		[SecuritySafeCritical]
		public virtual double ReadDouble()
		{
			this.FillBuffer(8);
			return BitConverterLE.ToDouble(this.m_buffer, 0);
		}

		/// <summary>Считывает десятичное значение из текущего потока и перемещает текущую позицию в потоке на шестнадцать байтов вперед.</summary>
		/// <returns>Десятичное значение, считанное из текущего потока.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600690F RID: 26895 RVA: 0x00166C5C File Offset: 0x00164E5C
		public virtual decimal ReadDecimal()
		{
			this.FillBuffer(16);
			decimal result;
			try
			{
				int[] array = new int[4];
				Buffer.BlockCopy(this.m_buffer, 0, array, 0, 16);
				if (!BitConverter.IsLittleEndian)
				{
					for (int i = 0; i < 4; i++)
					{
						array[i] = BinaryPrimitives.ReverseEndianness(array[i]);
					}
				}
				result = new decimal(array);
			}
			catch (ArgumentException innerException)
			{
				throw new IOException(Environment.GetResourceString("Decimal byte array constructor requires an array of length four containing valid decimal bytes."), innerException);
			}
			return result;
		}

		/// <summary>Считывает строку из текущего потока. Строка предваряется значением длины строки, которое закодировано как целое число блоками по семь битов.</summary>
		/// <returns>Считываемая строка.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006910 RID: 26896 RVA: 0x00166CD4 File Offset: 0x00164ED4
		public virtual string ReadString()
		{
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			int num = 0;
			int num2 = this.Read7BitEncodedInt();
			if (num2 < 0)
			{
				throw new IOException(Environment.GetResourceString("BinaryReader encountered an invalid string length of {0} characters.", new object[]
				{
					num2
				}));
			}
			if (num2 == 0)
			{
				return string.Empty;
			}
			if (this.m_charBytes == null)
			{
				this.m_charBytes = new byte[128];
			}
			if (this.m_charBuffer == null)
			{
				this.m_charBuffer = new char[this.m_maxCharsSize];
			}
			StringBuilder stringBuilder = null;
			int chars;
			for (;;)
			{
				int count = (num2 - num > 128) ? 128 : (num2 - num);
				int num3 = this.m_stream.Read(this.m_charBytes, 0, count);
				if (num3 == 0)
				{
					__Error.EndOfFile();
				}
				chars = this.m_decoder.GetChars(this.m_charBytes, 0, num3, this.m_charBuffer, 0);
				if (num == 0 && num3 == num2)
				{
					break;
				}
				if (stringBuilder == null)
				{
					stringBuilder = StringBuilderCache.Acquire(num2);
				}
				stringBuilder.Append(this.m_charBuffer, 0, chars);
				num += num3;
				if (num >= num2)
				{
					goto Block_11;
				}
			}
			return new string(this.m_charBuffer, 0, chars);
			Block_11:
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		/// <summary>Считывает указанное количество символов из потока, начиная с заданной точки в массиве символов.</summary>
		/// <param name="buffer">Буфер, в который должны считываться данные.</param>
		/// <param name="index">Стартовая точка в буфере, начиная с которой считываемые данные записываются в буфер.</param>
		/// <param name="count">Число символов для чтения.</param>
		/// <returns>Общее количество символов, считанных в буфер. Количество символов может быть меньше указанного числа, если в потоке осталось меньше символов, чем следует прочитать. Количество символов также может равняться нулю, если достигнут конец потока.</returns>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.  
		///
		/// или - 
		/// Число декодированных знаков для чтения больше, чем <paramref name="count" />. Это может произойти, если декодер Юникода возвращает резервные символы или суррогатную пару.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006911 RID: 26897 RVA: 0x00166DEC File Offset: 0x00164FEC
		[SecuritySafeCritical]
		public virtual int Read(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", Environment.GetResourceString("Buffer cannot be null."));
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("Non-negative number required."));
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(Environment.GetResourceString("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
			}
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			return this.InternalReadChars(buffer, index, count);
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x00166E74 File Offset: 0x00165074
		[SecurityCritical]
		private unsafe int InternalReadChars(char[] buffer, int index, int count)
		{
			int i = count;
			if (this.m_charBytes == null)
			{
				this.m_charBytes = new byte[128];
			}
			while (i > 0)
			{
				int num = i;
				DecoderNLS decoderNLS = this.m_decoder as DecoderNLS;
				if (decoderNLS != null && decoderNLS.HasState && num > 1)
				{
					num--;
				}
				if (this.m_2BytesPerChar)
				{
					num <<= 1;
				}
				if (num > 128)
				{
					num = 128;
				}
				int num2 = 0;
				byte[] array;
				if (this.m_isMemoryStream)
				{
					MemoryStream memoryStream = this.m_stream as MemoryStream;
					num2 = memoryStream.InternalGetPosition();
					num = memoryStream.InternalEmulateRead(num);
					array = memoryStream.InternalGetBuffer();
				}
				else
				{
					num = this.m_stream.Read(this.m_charBytes, 0, num);
					array = this.m_charBytes;
				}
				if (num == 0)
				{
					return count - i;
				}
				int chars;
				checked
				{
					if (num2 < 0 || num < 0 || num2 + num > array.Length)
					{
						throw new ArgumentOutOfRangeException("byteCount");
					}
					if (index < 0 || i < 0 || index + i > buffer.Length)
					{
						throw new ArgumentOutOfRangeException("charsRemaining");
					}
					byte[] array2;
					byte* ptr;
					if ((array2 = array) == null || array2.Length == 0)
					{
						ptr = null;
					}
					else
					{
						ptr = &array2[0];
					}
					fixed (char[] array3 = buffer)
					{
						char* ptr2;
						if (buffer == null || array3.Length == 0)
						{
							ptr2 = null;
						}
						else
						{
							ptr2 = &array3[0];
						}
						chars = this.m_decoder.GetChars(ptr + num2, num, ptr2 + index, i, false);
					}
					array2 = null;
				}
				i -= chars;
				index += chars;
			}
			return count - i;
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x00166FE0 File Offset: 0x001651E0
		private int InternalReadOneChar()
		{
			int num = 0;
			long num2 = 0L;
			if (this.m_stream.CanSeek)
			{
				num2 = this.m_stream.Position;
			}
			if (this.m_charBytes == null)
			{
				this.m_charBytes = new byte[128];
			}
			if (this.m_singleChar == null)
			{
				this.m_singleChar = new char[1];
			}
			while (num == 0)
			{
				int num3 = this.m_2BytesPerChar ? 2 : 1;
				int num4 = this.m_stream.ReadByte();
				this.m_charBytes[0] = (byte)num4;
				if (num4 == -1)
				{
					num3 = 0;
				}
				if (num3 == 2)
				{
					num4 = this.m_stream.ReadByte();
					this.m_charBytes[1] = (byte)num4;
					if (num4 == -1)
					{
						num3 = 1;
					}
				}
				if (num3 == 0)
				{
					return -1;
				}
				try
				{
					num = this.m_decoder.GetChars(this.m_charBytes, 0, num3, this.m_singleChar, 0);
				}
				catch
				{
					if (this.m_stream.CanSeek)
					{
						this.m_stream.Seek(num2 - this.m_stream.Position, SeekOrigin.Current);
					}
					throw;
				}
			}
			if (num == 0)
			{
				return -1;
			}
			return (int)this.m_singleChar[0];
		}

		/// <summary>Считывает указанное количество символов из текущего потока, возвращает данные в массив символов и перемещает текущую позицию в соответствии с используемой <see langword="Encoding" /> и определенным символом, считываемым из потока.</summary>
		/// <param name="count">Число символов для чтения.</param>
		/// <returns>Массив символов, в котором содержатся данные, считанные из базового потока. Если при чтении был достигнут конец потока, это число может быть меньше, чем количество запрошенных символов.</returns>
		/// <exception cref="T:System.ArgumentException">Число декодированных знаков для чтения больше, чем <paramref name="count" />. Это может произойти, если декодер Юникода возвращает резервные символы или суррогатную пару.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> является отрицательным значением.</exception>
		// Token: 0x06006914 RID: 26900 RVA: 0x001670FC File Offset: 0x001652FC
		[SecuritySafeCritical]
		public virtual char[] ReadChars(int count)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			if (count == 0)
			{
				return EmptyArray<char>.Value;
			}
			char[] array = new char[count];
			int num = this.InternalReadChars(array, 0, count);
			if (num != count)
			{
				char[] array2 = new char[num];
				Buffer.InternalBlockCopy(array, 0, array2, 0, 2 * num);
				array = array2;
			}
			return array;
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x00167164 File Offset: 0x00165364
		public virtual int Read(Span<char> buffer)
		{
			char[] array = ArrayPool<char>.Shared.Rent(buffer.Length);
			int result;
			try
			{
				int num = this.InternalReadChars(array, 0, buffer.Length);
				if (num > buffer.Length)
				{
					throw new IOException("Stream was too long.");
				}
				new ReadOnlySpan<char>(array, 0, num).CopyTo(buffer);
				result = num;
			}
			finally
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06006916 RID: 26902 RVA: 0x001671DC File Offset: 0x001653DC
		public virtual int Read(Span<byte> buffer)
		{
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			return this.m_stream.Read(buffer);
		}

		/// <summary>Считывает указанное количество байтов из потока, начиная с заданной точки в массиве байтов.</summary>
		/// <param name="buffer">Буфер, в который должны считываться данные.</param>
		/// <param name="index">Стартовая точка в буфере, начиная с которой считываемые данные записываются в буфер.</param>
		/// <param name="count">Количество байтов, чтение которых необходимо выполнить.</param>
		/// <returns>Количество байтов, считанных в <paramref name="buffer" />. Количество символов может быть меньше указанного числа, если в потоке осталось меньше байтов, чем следует считать. Количество символов также может равняться нулю, если достигнут конец потока.</returns>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.  
		///
		/// или - 
		/// Число декодированных знаков для чтения больше, чем <paramref name="count" />. Это может произойти, если декодер Юникода возвращает резервные символы или суррогатную пару.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006917 RID: 26903 RVA: 0x001671F8 File Offset: 0x001653F8
		public virtual int Read(byte[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", Environment.GetResourceString("Buffer cannot be null."));
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("Non-negative number required."));
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(Environment.GetResourceString("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
			}
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			return this.m_stream.Read(buffer, index, count);
		}

		/// <summary>Считывает указанное количество байтов из текущего потока в массив байтов и перемещает текущую позицию на это количество байтов.</summary>
		/// <param name="count">Количество байтов, чтение которых необходимо выполнить. Это значение должно быть равно 0 или быть больше 0, иначе возникнет исключение.</param>
		/// <returns>Массив байтов, в котором содержатся данные, считанные из базового потока. Если при чтении был достигнут конец потока, это число может быть меньше, чем количество запрошенных байтов.</returns>
		/// <exception cref="T:System.ArgumentException">Число декодированных знаков для чтения больше, чем <paramref name="count" />. Это может произойти, если декодер Юникода возвращает резервные символы или суррогатную пару.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> является отрицательным значением.</exception>
		// Token: 0x06006918 RID: 26904 RVA: 0x00167284 File Offset: 0x00165484
		public virtual byte[] ReadBytes(int count)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			if (count == 0)
			{
				return EmptyArray<byte>.Value;
			}
			byte[] array = new byte[count];
			int num = 0;
			do
			{
				int num2 = this.m_stream.Read(array, num, count);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				count -= num2;
			}
			while (count > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.InternalBlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}

		/// <summary>Заполняет внутренний буфер указанным количеством байтов, которые были cчитаны из потока.</summary>
		/// <param name="numBytes">Количество байтов, чтение которых необходимо выполнить.</param>
		/// <exception cref="T:System.IO.EndOfStreamException">Конец потока достигнут раньше, чем было выполнено чтение <paramref name="numBytes" /> байтов.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Запрошенное значение <paramref name="numBytes" /> превышает размер внутреннего буфера.</exception>
		// Token: 0x06006919 RID: 26905 RVA: 0x00167304 File Offset: 0x00165504
		protected virtual void FillBuffer(int numBytes)
		{
			if (this.m_buffer != null && (numBytes < 0 || numBytes > this.m_buffer.Length))
			{
				throw new ArgumentOutOfRangeException("numBytes", Environment.GetResourceString("The number of bytes requested does not fit into BinaryReader's internal buffer."));
			}
			int num = 0;
			if (this.m_stream == null)
			{
				__Error.FileNotOpen();
			}
			if (numBytes == 1)
			{
				int num2 = this.m_stream.ReadByte();
				if (num2 == -1)
				{
					__Error.EndOfFile();
				}
				this.m_buffer[0] = (byte)num2;
				return;
			}
			do
			{
				int num2 = this.m_stream.Read(this.m_buffer, num, numBytes - num);
				if (num2 == 0)
				{
					__Error.EndOfFile();
				}
				num += num2;
			}
			while (num < numBytes);
		}

		/// <summary>Считывает 32-разрядное целое число в сжатом формате.</summary>
		/// <returns>32-разрядное целое число в сжатом формате.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.FormatException">Поток поврежден.</exception>
		// Token: 0x0600691A RID: 26906 RVA: 0x00167398 File Offset: 0x00165598
		protected internal int Read7BitEncodedInt()
		{
			int num = 0;
			int num2 = 0;
			while (num2 != 35)
			{
				byte b = this.ReadByte();
				num |= (int)(b & 127) << num2;
				num2 += 7;
				if ((b & 128) == 0)
				{
					return num;
				}
			}
			throw new FormatException(Environment.GetResourceString("Too many bytes in what should have been a 7 bit encoded Int32."));
		}

		// Token: 0x04003D0F RID: 15631
		private const int MaxCharBytesSize = 128;

		// Token: 0x04003D10 RID: 15632
		private Stream m_stream;

		// Token: 0x04003D11 RID: 15633
		private byte[] m_buffer;

		// Token: 0x04003D12 RID: 15634
		private Decoder m_decoder;

		// Token: 0x04003D13 RID: 15635
		private byte[] m_charBytes;

		// Token: 0x04003D14 RID: 15636
		private char[] m_singleChar;

		// Token: 0x04003D15 RID: 15637
		private char[] m_charBuffer;

		// Token: 0x04003D16 RID: 15638
		private int m_maxCharsSize;

		// Token: 0x04003D17 RID: 15639
		private bool m_2BytesPerChar;

		// Token: 0x04003D18 RID: 15640
		private bool m_isMemoryStream;

		// Token: 0x04003D19 RID: 15641
		private bool m_leaveOpen;
	}
}
