using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Mono.Security;

namespace System.IO
{
	/// <summary>Записывает примитивные типы в двоичный поток и поддерживает запись строк в заданной кодировке.</summary>
	// Token: 0x02000B58 RID: 2904
	[ComVisible(true)]
	[Serializable]
	public class BinaryWriter : IDisposable, IAsyncDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.BinaryWriter" />, который осуществляет запись в поток.</summary>
		// Token: 0x0600691B RID: 26907 RVA: 0x001673DF File Offset: 0x001655DF
		protected BinaryWriter()
		{
			this.OutStream = Stream.Null;
			this._buffer = new byte[16];
			this._encoding = new UTF8Encoding(false, true);
			this._encoder = this._encoding.GetEncoder();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.BinaryWriter" /> на основании указанного потока с использованием кодировки UTF-8.</summary>
		/// <param name="output">Выходной поток.</param>
		/// <exception cref="T:System.ArgumentException">Поток не поддерживает запись или уже закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="output" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600691C RID: 26908 RVA: 0x0016741D File Offset: 0x0016561D
		public BinaryWriter(Stream output) : this(output, new UTF8Encoding(false, true), false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.BinaryWriter" /> на основе указанного потока и кодировки символов.</summary>
		/// <param name="output">Выходной поток.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <exception cref="T:System.ArgumentException">Поток не поддерживает запись или уже закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="output" /> или <paramref name="encoding" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600691D RID: 26909 RVA: 0x0016742E File Offset: 0x0016562E
		public BinaryWriter(Stream output, Encoding encoding) : this(output, encoding, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.BinaryWriter" /> на основе указанного потока и кодировки символов, а также при необходимости оставляет поток открытым.</summary>
		/// <param name="output">Выходной поток.</param>
		/// <param name="encoding">Кодировка символов, которую нужно использовать.</param>
		/// <param name="leaveOpen">Значение <see langword="true" />, чтобы оставить поток открытым после удаления объекта <see cref="T:System.IO.BinaryWriter" />; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">Поток не поддерживает запись или уже закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="output" /> или <paramref name="encoding" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600691E RID: 26910 RVA: 0x0016743C File Offset: 0x0016563C
		public BinaryWriter(Stream output, Encoding encoding, bool leaveOpen)
		{
			if (output == null)
			{
				throw new ArgumentNullException("output");
			}
			if (encoding == null)
			{
				throw new ArgumentNullException("encoding");
			}
			if (!output.CanWrite)
			{
				throw new ArgumentException(Environment.GetResourceString("Stream was not writable."));
			}
			this.OutStream = output;
			this._buffer = new byte[16];
			this._encoding = encoding;
			this._encoder = this._encoding.GetEncoder();
			this._leaveOpen = leaveOpen;
		}

		/// <summary>Закрывает текущий <see cref="T:System.IO.BinaryWriter" /> и базовый поток.</summary>
		// Token: 0x0600691F RID: 26911 RVA: 0x001674B6 File Offset: 0x001656B6
		public virtual void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.BinaryWriter" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06006920 RID: 26912 RVA: 0x001674BF File Offset: 0x001656BF
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this._leaveOpen)
				{
					this.OutStream.Flush();
					return;
				}
				this.OutStream.Close();
			}
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.IO.BinaryWriter" />.</summary>
		// Token: 0x06006921 RID: 26913 RVA: 0x001674B6 File Offset: 0x001656B6
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Возвращает базовый поток <see cref="T:System.IO.BinaryWriter" />.</summary>
		/// <returns>Базовый поток, связанный с объектом <see langword="BinaryWriter" />.</returns>
		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06006922 RID: 26914 RVA: 0x001674E3 File Offset: 0x001656E3
		public virtual Stream BaseStream
		{
			get
			{
				this.Flush();
				return this.OutStream;
			}
		}

		/// <summary>Очищает все буферы текущего модуля записи и вызывает немедленную запись всех буферизованных данных на базовое устройство.</summary>
		// Token: 0x06006923 RID: 26915 RVA: 0x001674F1 File Offset: 0x001656F1
		public virtual void Flush()
		{
			this.OutStream.Flush();
		}

		/// <summary>Задает позицию в текущем потоке.</summary>
		/// <param name="offset">Смещение в байтах относительно <paramref name="origin" />.</param>
		/// <param name="origin">Поле <see cref="T:System.IO.SeekOrigin" /> указывает точку отсчета, относительно которой указывается новая позиция.</param>
		/// <returns>Позиция в текущем потоке.</returns>
		/// <exception cref="T:System.IO.IOException">Указатель на файл перемещен в недопустимую позицию.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимое значение <see cref="T:System.IO.SeekOrigin" />.</exception>
		// Token: 0x06006924 RID: 26916 RVA: 0x001674FE File Offset: 0x001656FE
		public virtual long Seek(int offset, SeekOrigin origin)
		{
			return this.OutStream.Seek((long)offset, origin);
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x0016750E File Offset: 0x0016570E
		public virtual void Write(ReadOnlySpan<byte> buffer)
		{
			this.Write(buffer.ToArray());
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x0016751D File Offset: 0x0016571D
		public virtual void Write(ReadOnlySpan<char> buffer)
		{
			this.Write(buffer.ToArray());
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x0016752C File Offset: 0x0016572C
		public virtual ValueTask DisposeAsync()
		{
			ValueTask result;
			try
			{
				if (base.GetType() == typeof(BinaryWriter))
				{
					if (this._leaveOpen)
					{
						return new ValueTask(this.OutStream.FlushAsync());
					}
					this.OutStream.Close();
				}
				else
				{
					this.Dispose();
				}
				result = default(ValueTask);
			}
			catch (Exception exception)
			{
				result = new ValueTask(Task.FromException(exception));
			}
			return result;
		}

		/// <summary>Записывает значение типа <see langword="Boolean" /> длиной один байт в текущий поток, при этом 0 соответствует значению <see langword="false" />, а 1 — значению <see langword="true" />.</summary>
		/// <param name="value">Записываемое значение <see langword="Boolean" /> (0 или 1).</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006928 RID: 26920 RVA: 0x001675A8 File Offset: 0x001657A8
		public virtual void Write(bool value)
		{
			this._buffer[0] = (value ? 1 : 0);
			this.OutStream.Write(this._buffer, 0, 1);
		}

		/// <summary>Выполняет запись байта без знака в текущий поток и перемещает позицию в потоке на один байт вперед.</summary>
		/// <param name="value">Записываемый в поток байт без знака.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006929 RID: 26921 RVA: 0x001675CD File Offset: 0x001657CD
		public virtual void Write(byte value)
		{
			this.OutStream.WriteByte(value);
		}

		/// <summary>Записывает байт со знаком в текущий поток и перемещает позицию в потоке вперед на один байт.</summary>
		/// <param name="value">Байт со знаком, который необходимо записать в поток.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x0600692A RID: 26922 RVA: 0x001675DB File Offset: 0x001657DB
		[CLSCompliant(false)]
		public virtual void Write(sbyte value)
		{
			this.OutStream.WriteByte((byte)value);
		}

		/// <summary>Записывает массив байтов в базовый поток.</summary>
		/// <param name="buffer">Массив байтов, содержащий записываемые в поток данные.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600692B RID: 26923 RVA: 0x001675EA File Offset: 0x001657EA
		public virtual void Write(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			this.OutStream.Write(buffer, 0, buffer.Length);
		}

		/// <summary>Выполняет запись части массива байтов в текущий поток.</summary>
		/// <param name="buffer">Массив байтов, содержащий записываемые в поток данные.</param>
		/// <param name="index">Индекс первого байта для чтения из <paramref name="buffer" /> и для записи в поток.</param>
		/// <param name="count">Количество байтов для чтения из <paramref name="buffer" /> и для записи в поток.</param>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x0600692C RID: 26924 RVA: 0x0016760A File Offset: 0x0016580A
		public virtual void Write(byte[] buffer, int index, int count)
		{
			this.OutStream.Write(buffer, index, count);
		}

		/// <summary>Выполняет запись символа Юникод в текущий поток и перемещает текущую позицию в потоке вперед в соответствии с используемой <see langword="Encoding" /> и количеством записанных в поток символов.</summary>
		/// <param name="ch">Незаменяющий символ Юникода, который необходимо записать.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="ch" /> представляет собой единичный символ-заместитель.</exception>
		// Token: 0x0600692D RID: 26925 RVA: 0x0016761C File Offset: 0x0016581C
		[SecuritySafeCritical]
		public unsafe virtual void Write(char ch)
		{
			if (char.IsSurrogate(ch))
			{
				throw new ArgumentException(Environment.GetResourceString("Unicode surrogate characters must be written out as pairs together in the same call, not individually. Consider passing in a character array instead."));
			}
			byte[] array;
			byte* bytes;
			if ((array = this._buffer) == null || array.Length == 0)
			{
				bytes = null;
			}
			else
			{
				bytes = &array[0];
			}
			int bytes2 = this._encoder.GetBytes(&ch, 1, bytes, this._buffer.Length, true);
			array = null;
			this.OutStream.Write(this._buffer, 0, bytes2);
		}

		/// <summary>Выполняет запись массива символов в текущий поток и перемещает текущую позицию в потоке в соответствии с используемой <see langword="Encoding" /> и количеством записанных в поток символов.</summary>
		/// <param name="chars">Массив символов, содержащий записываемые в поток данные.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600692E RID: 26926 RVA: 0x00167690 File Offset: 0x00165890
		public virtual void Write(char[] chars)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars");
			}
			byte[] bytes = this._encoding.GetBytes(chars, 0, chars.Length);
			this.OutStream.Write(bytes, 0, bytes.Length);
		}

		/// <summary>Выполняет запись части массива символов в текущий поток и изменяет текущую позицию в потоке в соответствии с используемой <see langword="Encoding" /> и, возможно, количеством символов, записанных в поток.</summary>
		/// <param name="chars">Массив символов, содержащий записываемые в поток данные.</param>
		/// <param name="index">Индекс первого символа для чтения из <paramref name="chars" /> и для записи в поток.</param>
		/// <param name="count">Количество символов для чтения из <paramref name="chars" /> и для записи в поток.</param>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="chars" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x0600692F RID: 26927 RVA: 0x001676CC File Offset: 0x001658CC
		public virtual void Write(char[] chars, int index, int count)
		{
			byte[] bytes = this._encoding.GetBytes(chars, index, count);
			this.OutStream.Write(bytes, 0, bytes.Length);
		}

		/// <summary>Записывает число с плавающей запятой размером 8 байт в текущий поток и перемещает позицию в потоке вперед на восемь байт.</summary>
		/// <param name="value">Число с плавающей запятой размером 8 байт, которое необходимо записать в поток.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006930 RID: 26928 RVA: 0x001676F8 File Offset: 0x001658F8
		[SecuritySafeCritical]
		public virtual void Write(double value)
		{
			this.OutStream.Write(BitConverterLE.GetBytes(value), 0, 8);
		}

		/// <summary>Записывает десятичное число в текущий поток и перемещает позицию в потоке на шестнадцать байтов.</summary>
		/// <param name="value">Десятичное значение, которое необходимо записать.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006931 RID: 26929 RVA: 0x0016770D File Offset: 0x0016590D
		public virtual void Write(decimal value)
		{
			decimal.GetBytes(value, this._buffer);
			this.OutStream.Write(this._buffer, 0, 16);
		}

		/// <summary>Записывает целое число со знаком размером 2 байта в текущий поток и перемещает позицию в потоке вперед на два байта.</summary>
		/// <param name="value">Целое число со знаком размером 2 байта, которое необходимо записать в поток.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006932 RID: 26930 RVA: 0x00167730 File Offset: 0x00165930
		public virtual void Write(short value)
		{
			this._buffer[0] = (byte)value;
			this._buffer[1] = (byte)(value >> 8);
			this.OutStream.Write(this._buffer, 0, 2);
		}

		/// <summary>Записывает целое число без знака размером 2 байта в текущий поток и перемещает позицию в потоке вперед на два байта.</summary>
		/// <param name="value">Целое число без знака размером 2 байта, которое необходимо записать в поток.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006933 RID: 26931 RVA: 0x00167730 File Offset: 0x00165930
		[CLSCompliant(false)]
		public virtual void Write(ushort value)
		{
			this._buffer[0] = (byte)value;
			this._buffer[1] = (byte)(value >> 8);
			this.OutStream.Write(this._buffer, 0, 2);
		}

		/// <summary>Записывает четырехбайтовое целое число со знаком в текущий поток и перемещает позицию в потоке на четыре байта вперед.</summary>
		/// <param name="value">Целое число со знаком размером 4 байта, которое необходимо записать в поток.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006934 RID: 26932 RVA: 0x0016775C File Offset: 0x0016595C
		public virtual void Write(int value)
		{
			this._buffer[0] = (byte)value;
			this._buffer[1] = (byte)(value >> 8);
			this._buffer[2] = (byte)(value >> 16);
			this._buffer[3] = (byte)(value >> 24);
			this.OutStream.Write(this._buffer, 0, 4);
		}

		/// <summary>Записывает целое число без знака размером 4 байта в текущий поток и перемещает позицию в потоке вперед на четыре байта.</summary>
		/// <param name="value">Целое число без знака размером 4 байта, которое необходимо записать в поток.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006935 RID: 26933 RVA: 0x001677AC File Offset: 0x001659AC
		[CLSCompliant(false)]
		public virtual void Write(uint value)
		{
			this._buffer[0] = (byte)value;
			this._buffer[1] = (byte)(value >> 8);
			this._buffer[2] = (byte)(value >> 16);
			this._buffer[3] = (byte)(value >> 24);
			this.OutStream.Write(this._buffer, 0, 4);
		}

		/// <summary>Записывает целое число со знаком размером 8 байт в текущий поток и перемещает позицию в потоке вперед на восемь байт.</summary>
		/// <param name="value">Целое число со знаком размером 8 байт, которое необходимо записать в поток.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006936 RID: 26934 RVA: 0x001677FC File Offset: 0x001659FC
		public virtual void Write(long value)
		{
			this._buffer[0] = (byte)value;
			this._buffer[1] = (byte)(value >> 8);
			this._buffer[2] = (byte)(value >> 16);
			this._buffer[3] = (byte)(value >> 24);
			this._buffer[4] = (byte)(value >> 32);
			this._buffer[5] = (byte)(value >> 40);
			this._buffer[6] = (byte)(value >> 48);
			this._buffer[7] = (byte)(value >> 56);
			this.OutStream.Write(this._buffer, 0, 8);
		}

		/// <summary>Записывает целое число без знака размером 8 байт в текущий поток и перемещает позицию в потоке вперед на восемь байт.</summary>
		/// <param name="value">Целое число без знака размером 8 байт, которое необходимо записать в поток.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006937 RID: 26935 RVA: 0x00167880 File Offset: 0x00165A80
		[CLSCompliant(false)]
		public virtual void Write(ulong value)
		{
			this._buffer[0] = (byte)value;
			this._buffer[1] = (byte)(value >> 8);
			this._buffer[2] = (byte)(value >> 16);
			this._buffer[3] = (byte)(value >> 24);
			this._buffer[4] = (byte)(value >> 32);
			this._buffer[5] = (byte)(value >> 40);
			this._buffer[6] = (byte)(value >> 48);
			this._buffer[7] = (byte)(value >> 56);
			this.OutStream.Write(this._buffer, 0, 8);
		}

		/// <summary>Записывает число с плавающей запятой длиной 4 байта в текущий поток и перемещает позицию в потоке вперед на четыре байта.</summary>
		/// <param name="value">Число с плавающей запятой длиной 4 байта, которое необходимо записать в поток.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006938 RID: 26936 RVA: 0x00167904 File Offset: 0x00165B04
		[SecuritySafeCritical]
		public virtual void Write(float value)
		{
			this.OutStream.Write(BitConverterLE.GetBytes(value), 0, 4);
		}

		/// <summary>Записывает в текущий поток строку, предваряемую ее длиной, используя текущую кодировку <see cref="T:System.IO.BinaryWriter" />, и перемещает позицию в потоке вперед в соответствии с используемой кодировкой и количеством записанных в поток символов.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		// Token: 0x06006939 RID: 26937 RVA: 0x0016791C File Offset: 0x00165B1C
		[SecuritySafeCritical]
		public unsafe virtual void Write(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			int byteCount = this._encoding.GetByteCount(value);
			this.Write7BitEncodedInt(byteCount);
			if (this._largeByteBuffer == null)
			{
				this._largeByteBuffer = new byte[256];
				this._maxChars = this._largeByteBuffer.Length / this._encoding.GetMaxByteCount(1);
			}
			if (byteCount <= this._largeByteBuffer.Length)
			{
				this._encoding.GetBytes(value, 0, value.Length, this._largeByteBuffer, 0);
				this.OutStream.Write(this._largeByteBuffer, 0, byteCount);
				return;
			}
			int num = 0;
			int num2;
			for (int i = value.Length; i > 0; i -= num2)
			{
				num2 = ((i > this._maxChars) ? this._maxChars : i);
				if (num < 0 || num2 < 0 || checked(num + num2) > value.Length)
				{
					throw new ArgumentOutOfRangeException("charCount");
				}
				int bytes2;
				fixed (string text = value)
				{
					char* ptr = text;
					if (ptr != null)
					{
						ptr += RuntimeHelpers.OffsetToStringData / 2;
					}
					byte[] array;
					byte* bytes;
					if ((array = this._largeByteBuffer) == null || array.Length == 0)
					{
						bytes = null;
					}
					else
					{
						bytes = &array[0];
					}
					bytes2 = this._encoder.GetBytes(checked(ptr + num), num2, bytes, this._largeByteBuffer.Length, num2 == i);
					array = null;
				}
				this.OutStream.Write(this._largeByteBuffer, 0, bytes2);
				num += num2;
			}
		}

		/// <summary>Записывает 32-разрядное целое число в сжатом формате.</summary>
		/// <param name="value">32-разрядное целое число, которое необходимо записать.</param>
		/// <exception cref="T:System.IO.EndOfStreamException">Достигнут конец потока.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Поток закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Поток закрыт.</exception>
		// Token: 0x0600693A RID: 26938 RVA: 0x00167A7C File Offset: 0x00165C7C
		protected void Write7BitEncodedInt(int value)
		{
			uint num;
			for (num = (uint)value; num >= 128U; num >>= 7)
			{
				this.Write((byte)(num | 128U));
			}
			this.Write((byte)num);
		}

		/// <summary>Указывает <see cref="T:System.IO.BinaryWriter" /> без резервного хранилища.</summary>
		// Token: 0x04003D1A RID: 15642
		public static readonly BinaryWriter Null = new BinaryWriter();

		/// <summary>Содержит базовый поток.</summary>
		// Token: 0x04003D1B RID: 15643
		protected Stream OutStream;

		// Token: 0x04003D1C RID: 15644
		private byte[] _buffer;

		// Token: 0x04003D1D RID: 15645
		private Encoding _encoding;

		// Token: 0x04003D1E RID: 15646
		private Encoder _encoder;

		// Token: 0x04003D1F RID: 15647
		[OptionalField]
		private bool _leaveOpen;

		// Token: 0x04003D20 RID: 15648
		[OptionalField]
		private char[] _tmpOneCharBuffer;

		// Token: 0x04003D21 RID: 15649
		private byte[] _largeByteBuffer;

		// Token: 0x04003D22 RID: 15650
		private int _maxChars;

		// Token: 0x04003D23 RID: 15651
		private const int LargeByteBufferSize = 256;
	}
}
