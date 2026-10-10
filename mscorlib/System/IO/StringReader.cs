using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Реализует класс <see cref="T:System.IO.TextReader" />, осуществляющий чтение из строки.</summary>
	// Token: 0x02000B59 RID: 2905
	[ComVisible(true)]
	[Serializable]
	public class StringReader : TextReader
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StringReader" />, осуществляющий чтение из указанной строки.</summary>
		/// <param name="s">Строка, для которой должен быть инициализирован класс <see cref="T:System.IO.StringReader" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600693C RID: 26940 RVA: 0x00167ABB File Offset: 0x00165CBB
		public StringReader(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			this._s = s;
			this._length = ((s == null) ? 0 : s.Length);
		}

		/// <summary>Закрывает объект <see cref="T:System.IO.StringReader" />.</summary>
		// Token: 0x0600693D RID: 26941 RVA: 0x001588C5 File Offset: 0x00156AC5
		public override void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.StringReader" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x0600693E RID: 26942 RVA: 0x00167AEA File Offset: 0x00165CEA
		protected override void Dispose(bool disposing)
		{
			this._s = null;
			this._pos = 0;
			this._length = 0;
			base.Dispose(disposing);
		}

		/// <summary>Возвращает следующий доступный символ, но не использует его.</summary>
		/// <returns>Целое число, представляющее следующий символ, чтение которого необходимо выполнить, или значение -1, если доступных символов больше нет или поток не поддерживает поиск.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущее средство чтения закрыто.</exception>
		// Token: 0x0600693F RID: 26943 RVA: 0x00167B08 File Offset: 0x00165D08
		public override int Peek()
		{
			if (this._s == null)
			{
				__Error.ReaderClosed();
			}
			if (this._pos == this._length)
			{
				return -1;
			}
			return (int)this._s[this._pos];
		}

		/// <summary>Считывает следующий символ из строки ввода и увеличивает позицию символа на один символ.</summary>
		/// <returns>Следующий символ из основной строки или значение -1, если больше нет доступных символов.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущее средство чтения закрыто.</exception>
		// Token: 0x06006940 RID: 26944 RVA: 0x00167B38 File Offset: 0x00165D38
		public override int Read()
		{
			if (this._s == null)
			{
				__Error.ReaderClosed();
			}
			if (this._pos == this._length)
			{
				return -1;
			}
			string s = this._s;
			int pos = this._pos;
			this._pos = pos + 1;
			return (int)s[pos];
		}

		/// <summary>Считывает блок символов из строки ввода и увеличивает позицию символов на <paramref name="count" />.</summary>
		/// <param name="buffer">При возвращении из этого метода содержит указанный массив символов, в котором значения в интервале от <paramref name="index" /> и (<paramref name="index" /> + <paramref name="count" /> - 1) заменены символами, считанными из текущего источника.</param>
		/// <param name="index">Начальный индекс в буфере.</param>
		/// <param name="count">Число символов для чтения.</param>
		/// <returns>Общее количество символов, считанных в буфер. Оно может быть меньше, чем число запрошенных символов, если большинство символов не доступно в текущий момент, или равно нулю, если достигнут конец основной строки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущее средство чтения закрыто.</exception>
		// Token: 0x06006941 RID: 26945 RVA: 0x00167B80 File Offset: 0x00165D80
		public override int Read([In] [Out] char[] buffer, int index, int count)
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
			if (this._s == null)
			{
				__Error.ReaderClosed();
			}
			int num = this._length - this._pos;
			if (num > 0)
			{
				if (num > count)
				{
					num = count;
				}
				this._s.CopyTo(this._pos, buffer, index, num);
				this._pos += num;
			}
			return num;
		}

		/// <summary>Выполняет чтение всех символов, начиная с текущей позиции до конца строки, и возвращает их в виде одной строки.</summary>
		/// <returns>Содержимое, начиная от текущей позиции до конца основной строки.</returns>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти для выделения буфера под возвращаемую строку.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущее средство чтения закрыто.</exception>
		// Token: 0x06006942 RID: 26946 RVA: 0x00167C38 File Offset: 0x00165E38
		public override string ReadToEnd()
		{
			if (this._s == null)
			{
				__Error.ReaderClosed();
			}
			string result;
			if (this._pos == 0)
			{
				result = this._s;
			}
			else
			{
				result = this._s.Substring(this._pos, this._length - this._pos);
			}
			this._pos = this._length;
			return result;
		}

		/// <summary>Выполняет чтение строки символов из текущей строки и возвращает данные в виде строки.</summary>
		/// <returns>Следующая строка из текущей строки, или значение <see langword="null" />, если достигнут конец строки.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Текущее средство чтения закрыто.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти для выделения буфера под возвращаемую строку.</exception>
		// Token: 0x06006943 RID: 26947 RVA: 0x00167C90 File Offset: 0x00165E90
		public override string ReadLine()
		{
			if (this._s == null)
			{
				__Error.ReaderClosed();
			}
			int i;
			for (i = this._pos; i < this._length; i++)
			{
				char c = this._s[i];
				if (c == '\r' || c == '\n')
				{
					string result = this._s.Substring(this._pos, i - this._pos);
					this._pos = i + 1;
					if (c == '\r' && this._pos < this._length && this._s[this._pos] == '\n')
					{
						this._pos++;
					}
					return result;
				}
			}
			if (i > this._pos)
			{
				string result2 = this._s.Substring(this._pos, i - this._pos);
				this._pos = i;
				return result2;
			}
			return null;
		}

		/// <summary>Асинхронно выполняет чтение строки символов из текущей строки и возвращает данные в виде строки.</summary>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит следующую строку из средства чтения строк или значение <see langword="null" />, если все знаки считаны.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество символов в следующей строке больше <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство чтения строки.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль чтения в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x06006944 RID: 26948 RVA: 0x0015C7F7 File Offset: 0x0015A9F7
		[ComVisible(false)]
		public override Task<string> ReadLineAsync()
		{
			return Task.FromResult<string>(this.ReadLine());
		}

		/// <summary>Асинхронно считывает все символы, начиная с текущей позиции до конца строки, и возвращает их в виде одной строки.</summary>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит строку с символами от текущего положения до конца строки.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество символов больше <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство чтения строки.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль чтения в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x06006945 RID: 26949 RVA: 0x0015C804 File Offset: 0x0015AA04
		[ComVisible(false)]
		public override Task<string> ReadToEndAsync()
		{
			return Task.FromResult<string>(this.ReadToEnd());
		}

		/// <summary>Асинхронно считывает указанное максимальное количество символов из текущей строки и записывает данные в буфер, начиная с заданного индекса.</summary>
		/// <param name="buffer">При возвращении из этого метода содержит указанный массив символов, в котором значения в интервале от <paramref name="index" /> и (<paramref name="index" /> + <paramref name="count" /> - 1) заменены символами, считанными из текущего источника.</param>
		/// <param name="index">Позиция в буфере <paramref name="buffer" />, с которого начинается запись.</param>
		/// <param name="count">Максимальное число считываемых символов. Если конец строки достигнут, прежде чем в буфер записано указанное количество символов, метод возвращает управление.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит общее число байтов, считанных в буфер. Значение результата может быть меньше запрошенного числа байтов, если число текущих доступных байтов меньше запрошенного числа, или результат может быть равен 0 (нулю), если был достигнут конец строки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="index" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство чтения строки.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль чтения в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x06006946 RID: 26950 RVA: 0x00167D5C File Offset: 0x00165F5C
		[ComVisible(false)]
		public override Task<int> ReadBlockAsync(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", Environment.GetResourceString("Buffer cannot be null."));
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", Environment.GetResourceString("Non-negative number required."));
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(Environment.GetResourceString("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
			}
			return Task.FromResult<int>(this.ReadBlock(buffer, index, count));
		}

		/// <summary>Асинхронно считывает указанное максимальное количество символов из текущей строки и записывает данные в буфер, начиная с заданного индекса.</summary>
		/// <param name="buffer">При возвращении из этого метода содержит указанный массив символов, в котором значения в интервале от <paramref name="index" /> и (<paramref name="index" /> + <paramref name="count" /> - 1) заменены символами, считанными из текущего источника.</param>
		/// <param name="index">Позиция в буфере <paramref name="buffer" />, с которого начинается запись.</param>
		/// <param name="count">Максимальное число считываемых символов. Если конец строки достигнут, прежде чем в буфер записано указанное количество символов, метод возвращает управление.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит общее число байтов, считанных в буфер. Значение результата может быть меньше запрошенного числа байтов, если число текущих доступных байтов меньше запрошенного числа, или результат может быть равен 0 (нулю), если был достигнут конец строки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="index" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство чтения строки.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль чтения в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x06006947 RID: 26951 RVA: 0x00167DD0 File Offset: 0x00165FD0
		[ComVisible(false)]
		public override Task<int> ReadAsync(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", Environment.GetResourceString("Buffer cannot be null."));
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", Environment.GetResourceString("Non-negative number required."));
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(Environment.GetResourceString("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
			}
			return Task.FromResult<int>(this.Read(buffer, index, count));
		}

		// Token: 0x04003D24 RID: 15652
		private string _s;

		// Token: 0x04003D25 RID: 15653
		private int _pos;

		// Token: 0x04003D26 RID: 15654
		private int _length;
	}
}
