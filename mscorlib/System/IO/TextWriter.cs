using System;
using System.Buffers;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Представляет модуль записи, который может записывать последовательные наборы символов. Это абстрактный класс.</summary>
	// Token: 0x02000B24 RID: 2852
	[Serializable]
	public abstract class TextWriter : MarshalByRefObject, IDisposable, IAsyncDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.TextWriter" />.</summary>
		// Token: 0x060065E8 RID: 26088 RVA: 0x0015CC2E File Offset: 0x0015AE2E
		protected TextWriter()
		{
			this._internalFormatProvider = null;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.TextWriter" /> указанным поставщиком формата.</summary>
		/// <param name="formatProvider">Объект <see cref="T:System.IFormatProvider" />, управляющий форматированием.</param>
		// Token: 0x060065E9 RID: 26089 RVA: 0x0015CC53 File Offset: 0x0015AE53
		protected TextWriter(IFormatProvider formatProvider)
		{
			this._internalFormatProvider = formatProvider;
		}

		/// <summary>Возвращает объект, управляющий форматированием.</summary>
		/// <returns>Объект <see cref="T:System.IFormatProvider" /> для указанного языка и региональных параметров или форматирование текущего языка и региональных параметров, если не заданы другие.</returns>
		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x060065EA RID: 26090 RVA: 0x0015CC78 File Offset: 0x0015AE78
		public virtual IFormatProvider FormatProvider
		{
			get
			{
				if (this._internalFormatProvider == null)
				{
					return CultureInfo.CurrentCulture;
				}
				return this._internalFormatProvider;
			}
		}

		/// <summary>Закрывает текущий модуль записи и освобождает все системные ресурсы, связанные с ним.</summary>
		// Token: 0x060065EB RID: 26091 RVA: 0x0015A79F File Offset: 0x0015899F
		public virtual void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.TextWriter" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x060065EC RID: 26092 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Освобождает все ресурсы, используемые объектом <see cref="T:System.IO.TextWriter" />.</summary>
		// Token: 0x060065ED RID: 26093 RVA: 0x0015A79F File Offset: 0x0015899F
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x0015CC90 File Offset: 0x0015AE90
		public virtual ValueTask DisposeAsync()
		{
			ValueTask valueTask;
			try
			{
				this.Dispose();
				valueTask = default(ValueTask);
				valueTask = valueTask;
			}
			catch (Exception exception)
			{
				valueTask = new ValueTask(Task.FromException(exception));
			}
			return valueTask;
		}

		/// <summary>Очищает все буферы текущего модуля записи и вызывает немедленную запись всех буферизованных данных на базовое устройство.</summary>
		// Token: 0x060065EF RID: 26095 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public virtual void Flush()
		{
		}

		/// <summary>При переопределении в производном классе возвращает кодировку символов, в которой записаны выходные данные.</summary>
		/// <returns>Кодировка символов, в которой осуществляется запись выходных данных.</returns>
		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x060065F0 RID: 26096
		public abstract Encoding Encoding { get; }

		/// <summary>Возвращает или задает признак конца строки, используемой текущим <see langword="TextWriter" />.</summary>
		/// <returns>Признак конца строки для текущего <see langword="TextWriter" />.</returns>
		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x060065F1 RID: 26097 RVA: 0x0015CCD0 File Offset: 0x0015AED0
		// (set) Token: 0x060065F2 RID: 26098 RVA: 0x0015CCD8 File Offset: 0x0015AED8
		public virtual string NewLine
		{
			get
			{
				return this.CoreNewLineStr;
			}
			set
			{
				if (value == null)
				{
					value = Environment.NewLine;
				}
				this.CoreNewLineStr = value;
				this.CoreNewLine = value.ToCharArray();
			}
		}

		/// <summary>Выполняет запись символа в текстовую строку или поток.</summary>
		/// <param name="value">Символ, записываемый в текстовый поток.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065F3 RID: 26099 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public virtual void Write(char value)
		{
		}

		/// <summary>Выполняет запись массива символов в текстовую строку или поток.</summary>
		/// <param name="buffer">Массив символов, записываемый в текстовый поток.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065F4 RID: 26100 RVA: 0x0015CCF7 File Offset: 0x0015AEF7
		public virtual void Write(char[] buffer)
		{
			if (buffer != null)
			{
				this.Write(buffer, 0, buffer.Length);
			}
		}

		/// <summary>Записывает дочерний массив символов в текстовую строку или поток.</summary>
		/// <param name="buffer">Массив символов, из которого записываются данные.</param>
		/// <param name="index">Положение символа в буфере, с которого начинается извлечение данных.</param>
		/// <param name="count">Количество символов для записи.</param>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065F5 RID: 26101 RVA: 0x0015CD08 File Offset: 0x0015AF08
		public virtual void Write(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			for (int i = 0; i < count; i++)
			{
				this.Write(buffer[index + i]);
			}
		}

		// Token: 0x060065F6 RID: 26102 RVA: 0x0015CD7C File Offset: 0x0015AF7C
		public virtual void Write(ReadOnlySpan<char> buffer)
		{
			char[] array = ArrayPool<char>.Shared.Rent(buffer.Length);
			try
			{
				buffer.CopyTo(new Span<char>(array));
				this.Write(array, 0, buffer.Length);
			}
			finally
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление значения <see langword="Boolean" />.</summary>
		/// <param name="value">Значение <see langword="Boolean" /> для записи.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065F7 RID: 26103 RVA: 0x0015CDD8 File Offset: 0x0015AFD8
		public virtual void Write(bool value)
		{
			this.Write(value ? "True" : "False");
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление целого числа со знаком размером 4 байта.</summary>
		/// <param name="value">Записываемое целое число со знаком размером 4 байта.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065F8 RID: 26104 RVA: 0x0015CDEF File Offset: 0x0015AFEF
		public virtual void Write(int value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление целого числа без знака размером 4 байта.</summary>
		/// <param name="value">Записываемое целое число без знака размером 4 байта.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065F9 RID: 26105 RVA: 0x0015CE04 File Offset: 0x0015B004
		[CLSCompliant(false)]
		public virtual void Write(uint value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление целого числа со знаком размером 8 байт.</summary>
		/// <param name="value">Записываемое целое число со знаком размером 8 байт.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065FA RID: 26106 RVA: 0x0015CE19 File Offset: 0x0015B019
		public virtual void Write(long value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление целого числа без знака размером 8 байт.</summary>
		/// <param name="value">Записываемое целое число без знака размером 8 байт.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065FB RID: 26107 RVA: 0x0015CE2E File Offset: 0x0015B02E
		[CLSCompliant(false)]
		public virtual void Write(ulong value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление значения с плавающей запятой размером 4 байта.</summary>
		/// <param name="value">Записываемое значение с плавающей запятой размером 4 байта.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065FC RID: 26108 RVA: 0x0015CE43 File Offset: 0x0015B043
		public virtual void Write(float value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление значения с плавающей запятой размером 8 байт.</summary>
		/// <param name="value">Записываемое значение с плавающей запятой размером 8 байт.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065FD RID: 26109 RVA: 0x0015CE58 File Offset: 0x0015B058
		public virtual void Write(double value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		/// <summary>Записывает текстовое представление десятичного значения в текстовую строку или поток.</summary>
		/// <param name="value">Десятичное значение, которое необходимо записать.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065FE RID: 26110 RVA: 0x0015CE6D File Offset: 0x0015B06D
		public virtual void Write(decimal value)
		{
			this.Write(value.ToString(this.FormatProvider));
		}

		/// <summary>Асинхронно записывает строку в текстовую строку или поток.</summary>
		/// <param name="value">Строка для записи.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065FF RID: 26111 RVA: 0x0015CE82 File Offset: 0x0015B082
		public virtual void Write(string value)
		{
			if (value != null)
			{
				this.Write(value.ToCharArray());
			}
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление объекта с помощью вызова метода <see langword="ToString" /> для этого объекта.</summary>
		/// <param name="value">Записываемый объект.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006600 RID: 26112 RVA: 0x0015CE94 File Offset: 0x0015B094
		public virtual void Write(object value)
		{
			if (value != null)
			{
				IFormattable formattable = value as IFormattable;
				if (formattable != null)
				{
					this.Write(formattable.ToString(null, this.FormatProvider));
					return;
				}
				this.Write(value.ToString());
			}
		}

		/// <summary>Записывает форматированную строку в текстовую строку или поток, используя ту же семантику, что и метод <see cref="M:System.String.Format(System.String,System.Object)" />.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Объект для форматирования и записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> не является допустимой строкой составного формата.  
		///
		/// или - 
		/// Индекс элемента формата меньше 0 (нуля) или больше или равен числу объектов, которые необходимо отформатировать (которое для этой перегрузки метода равно 1).</exception>
		// Token: 0x06006601 RID: 26113 RVA: 0x0015CECE File Offset: 0x0015B0CE
		public virtual void Write(string format, object arg0)
		{
			this.Write(string.Format(this.FormatProvider, format, arg0));
		}

		/// <summary>Записывает форматированную строку в текстовую строку или поток, используя ту же семантику, что и метод <see cref="M:System.String.Format(System.String,System.Object,System.Object)" />.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Первый объект для форматирования и записи.</param>
		/// <param name="arg1">Второй объект для форматирования и записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> не является допустимой строкой составного формата.  
		///
		/// или - 
		/// Индекс элемента формата меньше 0 (нуля) или больше или равен числу объектов, которые необходимо отформатировать (которое для этой перегрузки метода равно 2).</exception>
		// Token: 0x06006602 RID: 26114 RVA: 0x0015CEE3 File Offset: 0x0015B0E3
		public virtual void Write(string format, object arg0, object arg1)
		{
			this.Write(string.Format(this.FormatProvider, format, arg0, arg1));
		}

		/// <summary>Записывает форматированную строку в текстовую строку или поток, используя ту же семантику, что и метод <see cref="M:System.String.Format(System.String,System.Object,System.Object,System.Object)" />.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Первый объект для форматирования и записи.</param>
		/// <param name="arg1">Второй объект для форматирования и записи.</param>
		/// <param name="arg2">Третий объект для форматирования и записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> не является допустимой строкой составного формата.  
		///
		/// или - 
		/// Индекс элемента формата меньше 0 (нуля) или больше или равен числу объектов, которые необходимо отформатировать (которое для этой перегрузки метода равно 3).</exception>
		// Token: 0x06006603 RID: 26115 RVA: 0x0015CEF9 File Offset: 0x0015B0F9
		public virtual void Write(string format, object arg0, object arg1, object arg2)
		{
			this.Write(string.Format(this.FormatProvider, format, arg0, arg1, arg2));
		}

		/// <summary>Записывает форматированную строку в текстовую строку или поток, используя ту же семантику, что и метод <see cref="M:System.String.Format(System.String,System.Object[])" />.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg">Массив объектов, содержащий от нуля и более объектов, которые необходимо форматировать и записать.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="format" /> или <paramref name="arg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> не является допустимой строкой составного формата.  
		///
		/// или - 
		/// Индекс элемента формата меньше нуля или больше либо равен длине массива <paramref name="arg" />.</exception>
		// Token: 0x06006604 RID: 26116 RVA: 0x0015CF11 File Offset: 0x0015B111
		public virtual void Write(string format, params object[] arg)
		{
			this.Write(string.Format(this.FormatProvider, format, arg));
		}

		/// <summary>Записывает признак конца строки в текстовую строку или поток.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006605 RID: 26117 RVA: 0x0015CF26 File Offset: 0x0015B126
		public virtual void WriteLine()
		{
			this.Write(this.CoreNewLine);
		}

		/// <summary>Записывает в текстовую строку или поток символ, за которым следует признак конца строки.</summary>
		/// <param name="value">Символ, записываемый в текстовый поток.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006606 RID: 26118 RVA: 0x0015CF34 File Offset: 0x0015B134
		public virtual void WriteLine(char value)
		{
			this.Write(value);
			this.WriteLine();
		}

		/// <summary>Записывает в текстовую строку или поток массив символов, за которыми следует признак конца строки.</summary>
		/// <param name="buffer">Массив символов, из которого считываются данные.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006607 RID: 26119 RVA: 0x0015CF43 File Offset: 0x0015B143
		public virtual void WriteLine(char[] buffer)
		{
			this.Write(buffer);
			this.WriteLine();
		}

		/// <summary>Записывает в текстовую строку или поток дочерний массив символов, за которыми следует признак конца строки.</summary>
		/// <param name="buffer">Массив символов, из которого считываются данные.</param>
		/// <param name="index">Положение символа в <paramref name="buffer" />, с которого начинается чтение данных.</param>
		/// <param name="count">Наибольшее количество символов для записи.</param>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006608 RID: 26120 RVA: 0x0015CF52 File Offset: 0x0015B152
		public virtual void WriteLine(char[] buffer, int index, int count)
		{
			this.Write(buffer, index, count);
			this.WriteLine();
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x0015CF64 File Offset: 0x0015B164
		public virtual void WriteLine(ReadOnlySpan<char> buffer)
		{
			char[] array = ArrayPool<char>.Shared.Rent(buffer.Length);
			try
			{
				buffer.CopyTo(new Span<char>(array));
				this.WriteLine(array, 0, buffer.Length);
			}
			finally
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление значения <see langword="Boolean" />, за которым следует признак конца строки.</summary>
		/// <param name="value">Значение <see langword="Boolean" /> для записи.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600660A RID: 26122 RVA: 0x0015CFC0 File Offset: 0x0015B1C0
		public virtual void WriteLine(bool value)
		{
			this.Write(value);
			this.WriteLine();
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление целого числа со знаком размером 4 байта, за которым следует признак конца строки.</summary>
		/// <param name="value">Записываемое целое число со знаком размером 4 байта.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600660B RID: 26123 RVA: 0x0015CFCF File Offset: 0x0015B1CF
		public virtual void WriteLine(int value)
		{
			this.Write(value);
			this.WriteLine();
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление целого числа без знака размером 4 байта, за которым следует признак конца строки.</summary>
		/// <param name="value">Записываемое целое число без знака размером 4 байта.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600660C RID: 26124 RVA: 0x0015CFDE File Offset: 0x0015B1DE
		[CLSCompliant(false)]
		public virtual void WriteLine(uint value)
		{
			this.Write(value);
			this.WriteLine();
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление целого числа со знаком размером 8 байт, за которым следует признак конца строки.</summary>
		/// <param name="value">Записываемое целое число со знаком размером 8 байт.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600660D RID: 26125 RVA: 0x0015CFED File Offset: 0x0015B1ED
		public virtual void WriteLine(long value)
		{
			this.Write(value);
			this.WriteLine();
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление целого числа без знака размером 8 байт, за которым следует признак конца строки.</summary>
		/// <param name="value">Записываемое целое число без знака размером 8 байт.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600660E RID: 26126 RVA: 0x0015CFFC File Offset: 0x0015B1FC
		[CLSCompliant(false)]
		public virtual void WriteLine(ulong value)
		{
			this.Write(value);
			this.WriteLine();
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление значения с плавающей запятой размером 4 байта, за которым следует признак конца строки.</summary>
		/// <param name="value">Записываемое значение с плавающей запятой размером 4 байта.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x0600660F RID: 26127 RVA: 0x0015D00B File Offset: 0x0015B20B
		public virtual void WriteLine(float value)
		{
			this.Write(value);
			this.WriteLine();
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление значения с плавающей запятой размером 8 байта, за которым следует признак конца строки.</summary>
		/// <param name="value">Записываемое значение с плавающей запятой размером 8 байт.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006610 RID: 26128 RVA: 0x0015D01A File Offset: 0x0015B21A
		public virtual void WriteLine(double value)
		{
			this.Write(value);
			this.WriteLine();
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление десятичного значения, за которым следует признак конца строки.</summary>
		/// <param name="value">Десятичное значение, которое необходимо записать.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006611 RID: 26129 RVA: 0x0015D029 File Offset: 0x0015B229
		public virtual void WriteLine(decimal value)
		{
			this.Write(value);
			this.WriteLine();
		}

		/// <summary>Записывает в текстовую строку или поток строку, за которой следует признак конца строки.</summary>
		/// <param name="value">Строка для записи. Если <paramref name="value" /> имеет значение <see langword="null" />, записывается только признак конца строки.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006612 RID: 26130 RVA: 0x0015D038 File Offset: 0x0015B238
		public virtual void WriteLine(string value)
		{
			if (value != null)
			{
				this.Write(value);
			}
			this.Write(this.CoreNewLineStr);
		}

		/// <summary>Записывает в текстовую строку или поток текстовое представление объекта путем вызова метода <see langword="ToString" /> для этого объекта, за которым следует признак конца строки.</summary>
		/// <param name="value">Записываемый объект. Если <paramref name="value" /> имеет значение <see langword="null" />, записывается только признак конца строки.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x06006613 RID: 26131 RVA: 0x0015D050 File Offset: 0x0015B250
		public virtual void WriteLine(object value)
		{
			if (value == null)
			{
				this.WriteLine();
				return;
			}
			IFormattable formattable = value as IFormattable;
			if (formattable != null)
			{
				this.WriteLine(formattable.ToString(null, this.FormatProvider));
				return;
			}
			this.WriteLine(value.ToString());
		}

		/// <summary>Записывает форматированную строку и новую строку в текстовую строку или поток, используя ту же семантику, что и метод <see cref="M:System.String.Format(System.String,System.Object)" />.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Объект для форматирования и записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> не является допустимой строкой составного формата.  
		///
		/// или - 
		/// Индекс элемента формата меньше 0 (нуля) или больше или равен числу объектов, которые необходимо отформатировать (которое для этой перегрузки метода равно 1).</exception>
		// Token: 0x06006614 RID: 26132 RVA: 0x0015D091 File Offset: 0x0015B291
		public virtual void WriteLine(string format, object arg0)
		{
			this.WriteLine(string.Format(this.FormatProvider, format, arg0));
		}

		/// <summary>Записывает форматированную строку и новую строку в текстовую строку или поток, используя ту же семантику, что и метод <see cref="M:System.String.Format(System.String,System.Object,System.Object)" />.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Первый объект для форматирования и записи.</param>
		/// <param name="arg1">Второй объект для форматирования и записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> не является допустимой строкой составного формата.  
		///
		/// или - 
		/// Индекс элемента формата меньше 0 (нуля) или больше или равен числу объектов, которые необходимо отформатировать (которое для этой перегрузки метода равно 2).</exception>
		// Token: 0x06006615 RID: 26133 RVA: 0x0015D0A6 File Offset: 0x0015B2A6
		public virtual void WriteLine(string format, object arg0, object arg1)
		{
			this.WriteLine(string.Format(this.FormatProvider, format, arg0, arg1));
		}

		/// <summary>Записывает отформатированную строку и новую строку, используя ту же семантику, что и <see cref="M:System.String.Format(System.String,System.Object)" />.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Первый объект для форматирования и записи.</param>
		/// <param name="arg1">Второй объект для форматирования и записи.</param>
		/// <param name="arg2">Третий объект для форматирования и записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> не является допустимой строкой составного формата.  
		///
		/// или - 
		/// Индекс элемента формата меньше 0 (нуля) или больше или равен числу объектов, которые необходимо отформатировать (которое для этой перегрузки метода равно 3).</exception>
		// Token: 0x06006616 RID: 26134 RVA: 0x0015D0BC File Offset: 0x0015B2BC
		public virtual void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			this.WriteLine(string.Format(this.FormatProvider, format, arg0, arg1, arg2));
		}

		/// <summary>Записывает отформатированную строку и новую строку, используя ту же семантику, что и <see cref="M:System.String.Format(System.String,System.Object)" />.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg">Массив объектов, содержащий от нуля и более объектов, которые необходимо форматировать и записать.</param>
		/// <exception cref="T:System.ArgumentNullException">Строка или объект передаются в виде <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextWriter" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> не является допустимой строкой составного формата.  
		///
		/// или - 
		/// Индекс элемента формата меньше нуля или больше либо равен длине массива <paramref name="arg" />.</exception>
		// Token: 0x06006617 RID: 26135 RVA: 0x0015D0D4 File Offset: 0x0015B2D4
		public virtual void WriteLine(string format, params object[] arg)
		{
			this.WriteLine(string.Format(this.FormatProvider, format, arg));
		}

		/// <summary>Выполняет асинхронную запись символа в текстовую строку или поток.</summary>
		/// <param name="value">Символ, записываемый в текстовый поток.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство записи текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство записи текста в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x06006618 RID: 26136 RVA: 0x0015D0EC File Offset: 0x0015B2EC
		public virtual Task WriteAsync(char value)
		{
			Tuple<TextWriter, char> state2 = new Tuple<TextWriter, char>(this, value);
			return Task.Factory.StartNew(delegate(object state)
			{
				Tuple<TextWriter, char> tuple = (Tuple<TextWriter, char>)state;
				tuple.Item1.Write(tuple.Item2);
			}, state2, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		/// <summary>Выполняет асинхронную запись строки в текстовую строку или поток.</summary>
		/// <param name="value">Строка для записи. Если параметр <paramref name="value" /> имеет значение <see langword="null" />, в текстовый поток ничего не записывается.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство записи текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство записи текста в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x06006619 RID: 26137 RVA: 0x0015D138 File Offset: 0x0015B338
		public virtual Task WriteAsync(string value)
		{
			Tuple<TextWriter, string> state2 = new Tuple<TextWriter, string>(this, value);
			return Task.Factory.StartNew(delegate(object state)
			{
				Tuple<TextWriter, string> tuple = (Tuple<TextWriter, string>)state;
				tuple.Item1.Write(tuple.Item2);
			}, state2, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		/// <summary>Выполняет асинхронную запись массива символов в текстовую строку или поток.</summary>
		/// <param name="buffer">Массив символов, записываемый в текстовый поток. Если <paramref name="buffer" /> имеет значение <see langword="null" />, запись не выполняется.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство записи текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство записи текста в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x0600661A RID: 26138 RVA: 0x0015D182 File Offset: 0x0015B382
		public Task WriteAsync(char[] buffer)
		{
			if (buffer == null)
			{
				return Task.CompletedTask;
			}
			return this.WriteAsync(buffer, 0, buffer.Length);
		}

		/// <summary>Асинхронно записывает дочерний массив символов в текстовую строку или поток.</summary>
		/// <param name="buffer">Массив символов, из которого записываются данные.</param>
		/// <param name="index">Положение символа в буфере, с которого начинается извлечение данных.</param>
		/// <param name="count">Количество символов для записи.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма значений параметров <paramref name="index" /> и <paramref name="count" /> превышает длину буфера.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство записи текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство записи текста в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x0600661B RID: 26139 RVA: 0x0015D198 File Offset: 0x0015B398
		public virtual Task WriteAsync(char[] buffer, int index, int count)
		{
			Tuple<TextWriter, char[], int, int> state2 = new Tuple<TextWriter, char[], int, int>(this, buffer, index, count);
			return Task.Factory.StartNew(delegate(object state)
			{
				Tuple<TextWriter, char[], int, int> tuple = (Tuple<TextWriter, char[], int, int>)state;
				tuple.Item1.Write(tuple.Item2, tuple.Item3, tuple.Item4);
			}, state2, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x0015D1E4 File Offset: 0x0015B3E4
		public virtual Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArraySegment<char> arraySegment;
			if (!MemoryMarshal.TryGetArray<char>(buffer, out arraySegment))
			{
				return Task.Factory.StartNew(delegate(object state)
				{
					Tuple<TextWriter, ReadOnlyMemory<char>> tuple = (Tuple<TextWriter, ReadOnlyMemory<char>>)state;
					tuple.Item1.Write(tuple.Item2.Span);
				}, Tuple.Create<TextWriter, ReadOnlyMemory<char>>(this, buffer), cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			}
			return this.WriteAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
		}

		/// <summary>Асинхронно записывает в текстовую строку или поток символ, за которым следует признак конца строки.</summary>
		/// <param name="value">Символ, записываемый в текстовый поток.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство записи текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство записи текста в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x0600661D RID: 26141 RVA: 0x0015D250 File Offset: 0x0015B450
		public virtual Task WriteLineAsync(char value)
		{
			Tuple<TextWriter, char> state2 = new Tuple<TextWriter, char>(this, value);
			return Task.Factory.StartNew(delegate(object state)
			{
				Tuple<TextWriter, char> tuple = (Tuple<TextWriter, char>)state;
				tuple.Item1.WriteLine(tuple.Item2);
			}, state2, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		/// <summary>Асинхронно записывает в текстовую строку или поток строку, за которой следует знак конца строки.</summary>
		/// <param name="value">Строка для записи. Если значение равно <see langword="null" />, записывается только знак конца строки.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство записи текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство записи текста в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x0600661E RID: 26142 RVA: 0x0015D29C File Offset: 0x0015B49C
		public virtual Task WriteLineAsync(string value)
		{
			Tuple<TextWriter, string> state2 = new Tuple<TextWriter, string>(this, value);
			return Task.Factory.StartNew(delegate(object state)
			{
				Tuple<TextWriter, string> tuple = (Tuple<TextWriter, string>)state;
				tuple.Item1.WriteLine(tuple.Item2);
			}, state2, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		/// <summary>Асинхронно записывает в текстовую строку или поток массив символов, за которыми следует признак конца строки.</summary>
		/// <param name="buffer">Массив символов, записываемый в текстовый поток. Если массив символов имеет значение <see langword="null" />, записывается только признак конца строки.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство записи текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство записи текста в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x0600661F RID: 26143 RVA: 0x0015D2E6 File Offset: 0x0015B4E6
		public Task WriteLineAsync(char[] buffer)
		{
			if (buffer == null)
			{
				return this.WriteLineAsync();
			}
			return this.WriteLineAsync(buffer, 0, buffer.Length);
		}

		/// <summary>Асинхронно записывает в текстовую строку или поток дочерний массив символов, за которыми следует признак конца строки.</summary>
		/// <param name="buffer">Массив символов, из которого записываются данные.</param>
		/// <param name="index">Положение символа в буфере, с которого начинается извлечение данных.</param>
		/// <param name="count">Количество символов для записи.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма значений параметров <paramref name="index" /> и <paramref name="count" /> превышает длину буфера.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство записи текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство записи текста в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x06006620 RID: 26144 RVA: 0x0015D300 File Offset: 0x0015B500
		public virtual Task WriteLineAsync(char[] buffer, int index, int count)
		{
			Tuple<TextWriter, char[], int, int> state2 = new Tuple<TextWriter, char[], int, int>(this, buffer, index, count);
			return Task.Factory.StartNew(delegate(object state)
			{
				Tuple<TextWriter, char[], int, int> tuple = (Tuple<TextWriter, char[], int, int>)state;
				tuple.Item1.WriteLine(tuple.Item2, tuple.Item3, tuple.Item4);
			}, state2, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x0015D34C File Offset: 0x0015B54C
		public virtual Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArraySegment<char> arraySegment;
			if (!MemoryMarshal.TryGetArray<char>(buffer, out arraySegment))
			{
				return Task.Factory.StartNew(delegate(object state)
				{
					Tuple<TextWriter, ReadOnlyMemory<char>> tuple = (Tuple<TextWriter, ReadOnlyMemory<char>>)state;
					tuple.Item1.WriteLine(tuple.Item2.Span);
				}, Tuple.Create<TextWriter, ReadOnlyMemory<char>>(this, buffer), cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			}
			return this.WriteLineAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
		}

		/// <summary>Асинхронно записывает признак конца строки в текстовую строку или поток.</summary>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство записи текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство записи текста в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x06006622 RID: 26146 RVA: 0x0015D3B6 File Offset: 0x0015B5B6
		public virtual Task WriteLineAsync()
		{
			return this.WriteAsync(this.CoreNewLine);
		}

		/// <summary>Асинхронно очищает все буферы текущего средства записи и вызывает запись всех буферизованных данных в базовое устройство.</summary>
		/// <returns>Задача, представляющая асинхронную операцию очистки.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство записи текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство записи в настоящее время используется предыдущей операцией записи.</exception>
		// Token: 0x06006623 RID: 26147 RVA: 0x0015D3C4 File Offset: 0x0015B5C4
		public virtual Task FlushAsync()
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				((TextWriter)state).Flush();
			}, this, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		/// <summary>Создает потокобезопасную оболочку для указанного объекта <see langword="TextWriter" />.</summary>
		/// <param name="writer">Коллекция <see langword="TextWriter" />, которую требуется синхронизировать.</param>
		/// <returns>Потокобезопасная программа-оболочка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="writer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06006624 RID: 26148 RVA: 0x0015D3FB File Offset: 0x0015B5FB
		public static TextWriter Synchronized(TextWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (!(writer is TextWriter.SyncTextWriter))
			{
				return new TextWriter.SyncTextWriter(writer);
			}
			return writer;
		}

		/// <summary>Предоставляет <see langword="TextWriter" /> без резервного хранилища, в который можно осуществлять запись, но из которого нельзя считывать данные.</summary>
		// Token: 0x04003BFD RID: 15357
		public static readonly TextWriter Null = new TextWriter.NullTextWriter();

		// Token: 0x04003BFE RID: 15358
		private static readonly char[] s_coreNewLine = Environment.NewLine.ToCharArray();

		/// <summary>Сохраняет символы новой строки, используемые для данного <see langword="TextWriter" />.</summary>
		// Token: 0x04003BFF RID: 15359
		protected char[] CoreNewLine = TextWriter.s_coreNewLine;

		// Token: 0x04003C00 RID: 15360
		private string CoreNewLineStr = Environment.NewLine;

		// Token: 0x04003C01 RID: 15361
		private IFormatProvider _internalFormatProvider;

		// Token: 0x02000B25 RID: 2853
		[Serializable]
		private sealed class NullTextWriter : TextWriter
		{
			// Token: 0x06006626 RID: 26150 RVA: 0x0015D436 File Offset: 0x0015B636
			internal NullTextWriter() : base(CultureInfo.InvariantCulture)
			{
			}

			// Token: 0x170011CA RID: 4554
			// (get) Token: 0x06006627 RID: 26151 RVA: 0x001598B5 File Offset: 0x00157AB5
			public override Encoding Encoding
			{
				get
				{
					return Encoding.Unicode;
				}
			}

			// Token: 0x06006628 RID: 26152 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void Write(char[] buffer, int index, int count)
			{
			}

			// Token: 0x06006629 RID: 26153 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void Write(string value)
			{
			}

			// Token: 0x0600662A RID: 26154 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void WriteLine()
			{
			}

			// Token: 0x0600662B RID: 26155 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void WriteLine(string value)
			{
			}

			// Token: 0x0600662C RID: 26156 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void WriteLine(object value)
			{
			}

			// Token: 0x0600662D RID: 26157 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void Write(char value)
			{
			}
		}

		// Token: 0x02000B26 RID: 2854
		[Serializable]
		internal sealed class SyncTextWriter : TextWriter, IDisposable
		{
			// Token: 0x0600662E RID: 26158 RVA: 0x0015D443 File Offset: 0x0015B643
			internal SyncTextWriter(TextWriter t) : base(t.FormatProvider)
			{
				this._out = t;
			}

			// Token: 0x170011CB RID: 4555
			// (get) Token: 0x0600662F RID: 26159 RVA: 0x0015D458 File Offset: 0x0015B658
			public override Encoding Encoding
			{
				get
				{
					return this._out.Encoding;
				}
			}

			// Token: 0x170011CC RID: 4556
			// (get) Token: 0x06006630 RID: 26160 RVA: 0x0015D465 File Offset: 0x0015B665
			public override IFormatProvider FormatProvider
			{
				get
				{
					return this._out.FormatProvider;
				}
			}

			// Token: 0x170011CD RID: 4557
			// (get) Token: 0x06006631 RID: 26161 RVA: 0x0015D472 File Offset: 0x0015B672
			// (set) Token: 0x06006632 RID: 26162 RVA: 0x0015D47F File Offset: 0x0015B67F
			public override string NewLine
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				get
				{
					return this._out.NewLine;
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				set
				{
					this._out.NewLine = value;
				}
			}

			// Token: 0x06006633 RID: 26163 RVA: 0x0015D48D File Offset: 0x0015B68D
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Close()
			{
				this._out.Close();
			}

			// Token: 0x06006634 RID: 26164 RVA: 0x0015D49A File Offset: 0x0015B69A
			[MethodImpl(MethodImplOptions.Synchronized)]
			protected override void Dispose(bool disposing)
			{
				if (disposing)
				{
					((IDisposable)this._out).Dispose();
				}
			}

			// Token: 0x06006635 RID: 26165 RVA: 0x0015D4AA File Offset: 0x0015B6AA
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Flush()
			{
				this._out.Flush();
			}

			// Token: 0x06006636 RID: 26166 RVA: 0x0015D4B7 File Offset: 0x0015B6B7
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(char value)
			{
				this._out.Write(value);
			}

			// Token: 0x06006637 RID: 26167 RVA: 0x0015D4C5 File Offset: 0x0015B6C5
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(char[] buffer)
			{
				this._out.Write(buffer);
			}

			// Token: 0x06006638 RID: 26168 RVA: 0x0015D4D3 File Offset: 0x0015B6D3
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(char[] buffer, int index, int count)
			{
				this._out.Write(buffer, index, count);
			}

			// Token: 0x06006639 RID: 26169 RVA: 0x0015D4E3 File Offset: 0x0015B6E3
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(bool value)
			{
				this._out.Write(value);
			}

			// Token: 0x0600663A RID: 26170 RVA: 0x0015D4F1 File Offset: 0x0015B6F1
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(int value)
			{
				this._out.Write(value);
			}

			// Token: 0x0600663B RID: 26171 RVA: 0x0015D4FF File Offset: 0x0015B6FF
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(uint value)
			{
				this._out.Write(value);
			}

			// Token: 0x0600663C RID: 26172 RVA: 0x0015D50D File Offset: 0x0015B70D
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(long value)
			{
				this._out.Write(value);
			}

			// Token: 0x0600663D RID: 26173 RVA: 0x0015D51B File Offset: 0x0015B71B
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(ulong value)
			{
				this._out.Write(value);
			}

			// Token: 0x0600663E RID: 26174 RVA: 0x0015D529 File Offset: 0x0015B729
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(float value)
			{
				this._out.Write(value);
			}

			// Token: 0x0600663F RID: 26175 RVA: 0x0015D537 File Offset: 0x0015B737
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(double value)
			{
				this._out.Write(value);
			}

			// Token: 0x06006640 RID: 26176 RVA: 0x0015D545 File Offset: 0x0015B745
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(decimal value)
			{
				this._out.Write(value);
			}

			// Token: 0x06006641 RID: 26177 RVA: 0x0015D553 File Offset: 0x0015B753
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(string value)
			{
				this._out.Write(value);
			}

			// Token: 0x06006642 RID: 26178 RVA: 0x0015D561 File Offset: 0x0015B761
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(object value)
			{
				this._out.Write(value);
			}

			// Token: 0x06006643 RID: 26179 RVA: 0x0015D56F File Offset: 0x0015B76F
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(string format, object arg0)
			{
				this._out.Write(format, arg0);
			}

			// Token: 0x06006644 RID: 26180 RVA: 0x0015D57E File Offset: 0x0015B77E
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(string format, object arg0, object arg1)
			{
				this._out.Write(format, arg0, arg1);
			}

			// Token: 0x06006645 RID: 26181 RVA: 0x0015D58E File Offset: 0x0015B78E
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(string format, object arg0, object arg1, object arg2)
			{
				this._out.Write(format, arg0, arg1, arg2);
			}

			// Token: 0x06006646 RID: 26182 RVA: 0x0015D5A0 File Offset: 0x0015B7A0
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(string format, params object[] arg)
			{
				this._out.Write(format, arg);
			}

			// Token: 0x06006647 RID: 26183 RVA: 0x0015D5AF File Offset: 0x0015B7AF
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine()
			{
				this._out.WriteLine();
			}

			// Token: 0x06006648 RID: 26184 RVA: 0x0015D5BC File Offset: 0x0015B7BC
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(char value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06006649 RID: 26185 RVA: 0x0015D5CA File Offset: 0x0015B7CA
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(decimal value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x0600664A RID: 26186 RVA: 0x0015D5D8 File Offset: 0x0015B7D8
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(char[] buffer)
			{
				this._out.WriteLine(buffer);
			}

			// Token: 0x0600664B RID: 26187 RVA: 0x0015D5E6 File Offset: 0x0015B7E6
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(char[] buffer, int index, int count)
			{
				this._out.WriteLine(buffer, index, count);
			}

			// Token: 0x0600664C RID: 26188 RVA: 0x0015D5F6 File Offset: 0x0015B7F6
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(bool value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x0600664D RID: 26189 RVA: 0x0015D604 File Offset: 0x0015B804
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(int value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x0600664E RID: 26190 RVA: 0x0015D612 File Offset: 0x0015B812
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(uint value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x0600664F RID: 26191 RVA: 0x0015D620 File Offset: 0x0015B820
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(long value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06006650 RID: 26192 RVA: 0x0015D62E File Offset: 0x0015B82E
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(ulong value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06006651 RID: 26193 RVA: 0x0015D63C File Offset: 0x0015B83C
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(float value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06006652 RID: 26194 RVA: 0x0015D64A File Offset: 0x0015B84A
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(double value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06006653 RID: 26195 RVA: 0x0015D658 File Offset: 0x0015B858
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(string value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06006654 RID: 26196 RVA: 0x0015D666 File Offset: 0x0015B866
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(object value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x06006655 RID: 26197 RVA: 0x0015D674 File Offset: 0x0015B874
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(string format, object arg0)
			{
				this._out.WriteLine(format, arg0);
			}

			// Token: 0x06006656 RID: 26198 RVA: 0x0015D683 File Offset: 0x0015B883
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(string format, object arg0, object arg1)
			{
				this._out.WriteLine(format, arg0, arg1);
			}

			// Token: 0x06006657 RID: 26199 RVA: 0x0015D693 File Offset: 0x0015B893
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(string format, object arg0, object arg1, object arg2)
			{
				this._out.WriteLine(format, arg0, arg1, arg2);
			}

			// Token: 0x06006658 RID: 26200 RVA: 0x0015D6A5 File Offset: 0x0015B8A5
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(string format, params object[] arg)
			{
				this._out.WriteLine(format, arg);
			}

			// Token: 0x06006659 RID: 26201 RVA: 0x0015D6B4 File Offset: 0x0015B8B4
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteAsync(char value)
			{
				this.Write(value);
				return Task.CompletedTask;
			}

			// Token: 0x0600665A RID: 26202 RVA: 0x0015D6C2 File Offset: 0x0015B8C2
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteAsync(string value)
			{
				this.Write(value);
				return Task.CompletedTask;
			}

			// Token: 0x0600665B RID: 26203 RVA: 0x0015D6D0 File Offset: 0x0015B8D0
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteAsync(char[] buffer, int index, int count)
			{
				this.Write(buffer, index, count);
				return Task.CompletedTask;
			}

			// Token: 0x0600665C RID: 26204 RVA: 0x0015D6E0 File Offset: 0x0015B8E0
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteLineAsync(char value)
			{
				this.WriteLine(value);
				return Task.CompletedTask;
			}

			// Token: 0x0600665D RID: 26205 RVA: 0x0015D6EE File Offset: 0x0015B8EE
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteLineAsync(string value)
			{
				this.WriteLine(value);
				return Task.CompletedTask;
			}

			// Token: 0x0600665E RID: 26206 RVA: 0x0015D6FC File Offset: 0x0015B8FC
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteLineAsync(char[] buffer, int index, int count)
			{
				this.WriteLine(buffer, index, count);
				return Task.CompletedTask;
			}

			// Token: 0x0600665F RID: 26207 RVA: 0x0015D70C File Offset: 0x0015B90C
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task FlushAsync()
			{
				this.Flush();
				return Task.CompletedTask;
			}

			// Token: 0x04003C02 RID: 15362
			private readonly TextWriter _out;
		}
	}
}
