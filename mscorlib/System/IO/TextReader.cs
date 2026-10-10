using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Представляет средство чтения, позволяющее считывать последовательные наборы символов.</summary>
	// Token: 0x02000B1E RID: 2846
	[Serializable]
	public abstract class TextReader : MarshalByRefObject, IDisposable
	{
		/// <summary>Закрывает <see cref="T:System.IO.TextReader" /> и освобождает все системные ресурсы, связанные с <see langword="TextReader" />.</summary>
		// Token: 0x060065B9 RID: 26041 RVA: 0x0015C1F2 File Offset: 0x0015A3F2
		public virtual void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает все ресурсы, используемые объектом <see cref="T:System.IO.TextReader" />.</summary>
		// Token: 0x060065BA RID: 26042 RVA: 0x0015C1F2 File Offset: 0x0015A3F2
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.TextReader" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x060065BB RID: 26043 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Выполняет чтение следующего символа, не изменяя состояние средства чтения или источника символа. Возвращает следующий доступный символ, фактически не считывая его из средства чтения.</summary>
		/// <returns>Целое число, представляющее следующий символ, чтение которого необходимо выполнить, или значение -1, если доступных символов больше нет или средство чтения не поддерживает поиск.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextReader" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065BC RID: 26044 RVA: 0x00122772 File Offset: 0x00120972
		public virtual int Peek()
		{
			return -1;
		}

		/// <summary>Выполняет чтение следующего символа из средства чтения текста и перемещает положение символа на одну позицию вперед.</summary>
		/// <returns>Следующий символ из средства чтения текста или значение -1, если доступных символов больше нет. Реализация по умолчанию возвращает значение -1.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextReader" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065BD RID: 26045 RVA: 0x00122772 File Offset: 0x00120972
		public virtual int Read()
		{
			return -1;
		}

		/// <summary>Считывает указанное максимальное количество символов из текущего средства чтения и записывает данные в буфер, начиная с заданного индекса.</summary>
		/// <param name="buffer">При возвращении из этого метода содержит указанный массив символов, в котором значения в интервале от <paramref name="index" /> и (<paramref name="index" /> + <paramref name="count" /> - 1) заменены символами, считанными из текущего источника.</param>
		/// <param name="index">Позиция в буфере <paramref name="buffer" />, с которого начинается запись.</param>
		/// <param name="count">Максимальное число считываемых символов. Если конец средства чтения достигнут, прежде чем в буфер считано указанное количество символов, метод возвращает управление.</param>
		/// <returns>Количество считанных символов. Количество будет меньше или равно <paramref name="count" /> в зависимости от доступности данных в средстве чтения. Этот метод возвращает 0 (нуль), если его вызвать при отсутствии символов, доступных для чтения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextReader" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065BE RID: 26046 RVA: 0x0015C204 File Offset: 0x0015A404
		public virtual int Read(char[] buffer, int index, int count)
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
			int i;
			for (i = 0; i < count; i++)
			{
				int num = this.Read();
				if (num == -1)
				{
					break;
				}
				buffer[index + i] = (char)num;
			}
			return i;
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x0015C280 File Offset: 0x0015A480
		public virtual int Read(Span<char> buffer)
		{
			char[] array = ArrayPool<char>.Shared.Rent(buffer.Length);
			int result;
			try
			{
				int num = this.Read(array, 0, buffer.Length);
				if ((ulong)num > (ulong)((long)buffer.Length))
				{
					throw new IOException("The read operation returned an invalid length.");
				}
				new Span<char>(array, 0, num).CopyTo(buffer);
				result = num;
			}
			finally
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result;
		}

		/// <summary>Считывает все символы, начиная с текущей позиции до конца средства чтения текста, и возвращает их в виде одной строки.</summary>
		/// <returns>Строка, содержащая все символы, начиная с текущей позиции до конца средства чтения текста.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextReader" /> закрыт.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти для выделения буфера под возвращаемую строку.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество символов в следующей строке больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060065C0 RID: 26048 RVA: 0x0015C2FC File Offset: 0x0015A4FC
		public virtual string ReadToEnd()
		{
			char[] array = new char[4096];
			StringBuilder stringBuilder = new StringBuilder(4096);
			int charCount;
			while ((charCount = this.Read(array, 0, array.Length)) != 0)
			{
				stringBuilder.Append(array, 0, charCount);
			}
			return stringBuilder.ToString();
		}

		/// <summary>Считывает указанное максимальное количество символов из текущего средства чтения текста и записывает данные в буфер, начиная с заданного индекса.</summary>
		/// <param name="buffer">При возвращении из этого метода параметр содержит указанный массив символов, в котором значения в интервале от <paramref name="index" /> до (<paramref name="index" /> + <paramref name="count" /> - 1) заменены символами, считанными из текущего источника.</param>
		/// <param name="index">Позиция в буфере <paramref name="buffer" />, с которого начинается запись.</param>
		/// <param name="count">Максимальное число считываемых символов.</param>
		/// <returns>Количество считанных символов. Число будет меньше или равно значению <paramref name="count" />, в зависимости от того, считаны ли все входящие символы.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Длина буфера минус <paramref name="index" /> меньше <paramref name="count" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextReader" /> закрыт.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		// Token: 0x060065C1 RID: 26049 RVA: 0x0015C340 File Offset: 0x0015A540
		public virtual int ReadBlock(char[] buffer, int index, int count)
		{
			int num = 0;
			int num2;
			do
			{
				num += (num2 = this.Read(buffer, index + num, count - num));
			}
			while (num2 > 0 && num < count);
			return num;
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x0015C36C File Offset: 0x0015A56C
		public virtual int ReadBlock(Span<char> buffer)
		{
			char[] array = ArrayPool<char>.Shared.Rent(buffer.Length);
			int result;
			try
			{
				int num = this.ReadBlock(array, 0, buffer.Length);
				if ((ulong)num > (ulong)((long)buffer.Length))
				{
					throw new IOException("The read operation returned an invalid length.");
				}
				new Span<char>(array, 0, num).CopyTo(buffer);
				result = num;
			}
			finally
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result;
		}

		/// <summary>Выполняет чтение строки символов из средства чтения текста и возвращает данные в виде строки.</summary>
		/// <returns>Следующая строка из средства чтения или значение <see langword="null" />, если все символы считаны.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода-вывода.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти для выделения буфера под возвращаемую строку.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.IO.TextReader" /> закрыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество символов в следующей строке больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060065C3 RID: 26051 RVA: 0x0015C3E8 File Offset: 0x0015A5E8
		public virtual string ReadLine()
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num;
			for (;;)
			{
				num = this.Read();
				if (num == -1)
				{
					goto IL_43;
				}
				if (num == 13 || num == 10)
				{
					break;
				}
				stringBuilder.Append((char)num);
			}
			if (num == 13 && this.Peek() == 10)
			{
				this.Read();
			}
			return stringBuilder.ToString();
			IL_43:
			if (stringBuilder.Length > 0)
			{
				return stringBuilder.ToString();
			}
			return null;
		}

		/// <summary>Асинхронно считывает строку символов и возвращает данные в виде строки.</summary>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит следующую строку из средства чтения текста или значение <see langword="null" />, если все символы считаны.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество символов в следующей строке больше <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство чтения текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль чтения в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x060065C4 RID: 26052 RVA: 0x0015C449 File Offset: 0x0015A649
		public virtual Task<string> ReadLineAsync()
		{
			return Task<string>.Factory.StartNew((object state) => ((TextReader)state).ReadLine(), this, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		/// <summary>Асинхронно считывает все символы с текущей позиции до конца средства чтения текста и возвращает их в виде одной строки.</summary>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит строку с символами от текущего положения до конца средства чтения текста.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество символов больше <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство чтения текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль чтения в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x060065C5 RID: 26053 RVA: 0x0015C480 File Offset: 0x0015A680
		public virtual Task<string> ReadToEndAsync()
		{
			TextReader.<ReadToEndAsync>d__14 <ReadToEndAsync>d__;
			<ReadToEndAsync>d__.<>4__this = this;
			<ReadToEndAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ReadToEndAsync>d__.<>1__state = -1;
			<ReadToEndAsync>d__.<>t__builder.Start<TextReader.<ReadToEndAsync>d__14>(ref <ReadToEndAsync>d__);
			return <ReadToEndAsync>d__.<>t__builder.Task;
		}

		/// <summary>Асинхронно считывает указанное максимальное количество символов из текущего средства чтения текста и записывает данные в буфер, начиная с указанного индекса.</summary>
		/// <param name="buffer">При возвращении из этого метода содержит указанный массив символов, в котором значения в интервале от <paramref name="index" /> и (<paramref name="index" /> + <paramref name="count" /> - 1) заменены символами, считанными из текущего источника.</param>
		/// <param name="index">Позиция в буфере <paramref name="buffer" />, с которого начинается запись.</param>
		/// <param name="count">Максимальное число считываемых символов. Если конец текста достигнут, прежде чем указанное количество символов считывается в буфер, текущий метод возвращает управление.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит общее число байтов, считанных в буфер. Значение результата может быть меньше запрошенного числа байтов, если число текущих доступных байтов меньше запрошенного числа, или результат может быть равен 0 (нулю), если был достигнут конец текста.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="index" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство чтения текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль чтения в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x060065C6 RID: 26054 RVA: 0x0015C4C4 File Offset: 0x0015A6C4
		public virtual Task<int> ReadAsync(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			return this.ReadAsyncInternal(new Memory<char>(buffer, index, count), default(CancellationToken)).AsTask();
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x0015C53C File Offset: 0x0015A73C
		public virtual ValueTask<int> ReadAsync(Memory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArraySegment<char> arraySegment;
			Task<int> task;
			if (!MemoryMarshal.TryGetArray<char>(buffer, out arraySegment))
			{
				task = Task<int>.Factory.StartNew(delegate(object state)
				{
					Tuple<TextReader, Memory<char>> tuple = (Tuple<TextReader, Memory<char>>)state;
					return tuple.Item1.Read(tuple.Item2.Span);
				}, Tuple.Create<TextReader, Memory<char>>(this, buffer), cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			}
			else
			{
				task = this.ReadAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
			return new ValueTask<int>(task);
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x0015C5B4 File Offset: 0x0015A7B4
		internal virtual ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
		{
			Tuple<TextReader, Memory<char>> state2 = new Tuple<TextReader, Memory<char>>(this, buffer);
			return new ValueTask<int>(Task<int>.Factory.StartNew(delegate(object state)
			{
				Tuple<TextReader, Memory<char>> tuple = (Tuple<TextReader, Memory<char>>)state;
				return tuple.Item1.Read(tuple.Item2.Span);
			}, state2, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default));
		}

		/// <summary>Асинхронно считывает указанное максимальное количество символов из текущего средства чтения текста и записывает данные в буфер, начиная с указанного индекса.</summary>
		/// <param name="buffer">При возвращении из этого метода содержит указанный массив символов, в котором значения в интервале от <paramref name="index" /> и (<paramref name="index" /> + <paramref name="count" /> - 1) заменены символами, считанными из текущего источника.</param>
		/// <param name="index">Позиция в буфере <paramref name="buffer" />, с которого начинается запись.</param>
		/// <param name="count">Максимальное число считываемых символов. Если конец текста достигнут, прежде чем указанное количество символов считывается в буфер, текущий метод возвращает управление.</param>
		/// <returns>Задача, представляющая асинхронную операцию чтения. Значение параметра <paramref name="TResult" /> содержит общее число байтов, считанных в буфер. Значение результата может быть меньше запрошенного числа байтов, если число текущих доступных байтов меньше запрошенного числа, или результат может быть равен 0 (нулю), если был достигнут конец текста.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="index" /> и <paramref name="count" /> больше, чем длина буфера.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Удалено средство чтения текста.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль чтения в настоящее время используется предыдущей операцией чтения.</exception>
		// Token: 0x060065C9 RID: 26057 RVA: 0x0015C600 File Offset: 0x0015A800
		public virtual Task<int> ReadBlockAsync(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			return this.ReadBlockAsyncInternal(new Memory<char>(buffer, index, count), default(CancellationToken)).AsTask();
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x0015C678 File Offset: 0x0015A878
		public virtual ValueTask<int> ReadBlockAsync(Memory<char> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArraySegment<char> arraySegment;
			Task<int> task;
			if (!MemoryMarshal.TryGetArray<char>(buffer, out arraySegment))
			{
				task = Task<int>.Factory.StartNew(delegate(object state)
				{
					Tuple<TextReader, Memory<char>> tuple = (Tuple<TextReader, Memory<char>>)state;
					return tuple.Item1.ReadBlock(tuple.Item2.Span);
				}, Tuple.Create<TextReader, Memory<char>>(this, buffer), cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			}
			else
			{
				task = this.ReadBlockAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			}
			return new ValueTask<int>(task);
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x0015C6F0 File Offset: 0x0015A8F0
		internal ValueTask<int> ReadBlockAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
		{
			TextReader.<ReadBlockAsyncInternal>d__20 <ReadBlockAsyncInternal>d__;
			<ReadBlockAsyncInternal>d__.<>4__this = this;
			<ReadBlockAsyncInternal>d__.buffer = buffer;
			<ReadBlockAsyncInternal>d__.cancellationToken = cancellationToken;
			<ReadBlockAsyncInternal>d__.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<ReadBlockAsyncInternal>d__.<>1__state = -1;
			<ReadBlockAsyncInternal>d__.<>t__builder.Start<TextReader.<ReadBlockAsyncInternal>d__20>(ref <ReadBlockAsyncInternal>d__);
			return <ReadBlockAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Создает потокобезопасную оболочку для указанного объекта <see langword="TextReader" />.</summary>
		/// <param name="reader">Коллекция <see langword="TextReader" />, которую требуется синхронизировать.</param>
		/// <returns>Потокобезопасный объект <see cref="T:System.IO.TextReader" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="reader" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060065CC RID: 26060 RVA: 0x0015C743 File Offset: 0x0015A943
		public static TextReader Synchronized(TextReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (!(reader is TextReader.SyncTextReader))
			{
				return new TextReader.SyncTextReader(reader);
			}
			return reader;
		}

		/// <summary>Предоставляет <see langword="TextReader" /> без данных, доступных для чтения.</summary>
		// Token: 0x04003BE9 RID: 15337
		public static readonly TextReader Null = new TextReader.NullTextReader();

		// Token: 0x02000B1F RID: 2847
		[Serializable]
		private sealed class NullTextReader : TextReader
		{
			// Token: 0x060065CF RID: 26063 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
			public override int Read(char[] buffer, int index, int count)
			{
				return 0;
			}

			// Token: 0x060065D0 RID: 26064 RVA: 0x0000AF5E File Offset: 0x0000915E
			public override string ReadLine()
			{
				return null;
			}
		}

		// Token: 0x02000B20 RID: 2848
		[Serializable]
		internal sealed class SyncTextReader : TextReader
		{
			// Token: 0x060065D1 RID: 26065 RVA: 0x0015C777 File Offset: 0x0015A977
			internal SyncTextReader(TextReader t)
			{
				this._in = t;
			}

			// Token: 0x060065D2 RID: 26066 RVA: 0x0015C786 File Offset: 0x0015A986
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Close()
			{
				this._in.Close();
			}

			// Token: 0x060065D3 RID: 26067 RVA: 0x0015C793 File Offset: 0x0015A993
			[MethodImpl(MethodImplOptions.Synchronized)]
			protected override void Dispose(bool disposing)
			{
				if (disposing)
				{
					((IDisposable)this._in).Dispose();
				}
			}

			// Token: 0x060065D4 RID: 26068 RVA: 0x0015C7A3 File Offset: 0x0015A9A3
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override int Peek()
			{
				return this._in.Peek();
			}

			// Token: 0x060065D5 RID: 26069 RVA: 0x0015C7B0 File Offset: 0x0015A9B0
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override int Read()
			{
				return this._in.Read();
			}

			// Token: 0x060065D6 RID: 26070 RVA: 0x0015C7BD File Offset: 0x0015A9BD
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override int Read(char[] buffer, int index, int count)
			{
				return this._in.Read(buffer, index, count);
			}

			// Token: 0x060065D7 RID: 26071 RVA: 0x0015C7CD File Offset: 0x0015A9CD
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override int ReadBlock(char[] buffer, int index, int count)
			{
				return this._in.ReadBlock(buffer, index, count);
			}

			// Token: 0x060065D8 RID: 26072 RVA: 0x0015C7DD File Offset: 0x0015A9DD
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override string ReadLine()
			{
				return this._in.ReadLine();
			}

			// Token: 0x060065D9 RID: 26073 RVA: 0x0015C7EA File Offset: 0x0015A9EA
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override string ReadToEnd()
			{
				return this._in.ReadToEnd();
			}

			// Token: 0x060065DA RID: 26074 RVA: 0x0015C7F7 File Offset: 0x0015A9F7
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task<string> ReadLineAsync()
			{
				return Task.FromResult<string>(this.ReadLine());
			}

			// Token: 0x060065DB RID: 26075 RVA: 0x0015C804 File Offset: 0x0015AA04
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task<string> ReadToEndAsync()
			{
				return Task.FromResult<string>(this.ReadToEnd());
			}

			// Token: 0x060065DC RID: 26076 RVA: 0x0015C814 File Offset: 0x0015AA14
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task<int> ReadBlockAsync(char[] buffer, int index, int count)
			{
				if (buffer == null)
				{
					throw new ArgumentNullException("buffer", "Buffer cannot be null.");
				}
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (buffer.Length - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				return Task.FromResult<int>(this.ReadBlock(buffer, index, count));
			}

			// Token: 0x060065DD RID: 26077 RVA: 0x0015C878 File Offset: 0x0015AA78
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task<int> ReadAsync(char[] buffer, int index, int count)
			{
				if (buffer == null)
				{
					throw new ArgumentNullException("buffer", "Buffer cannot be null.");
				}
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (buffer.Length - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				return Task.FromResult<int>(this.Read(buffer, index, count));
			}

			// Token: 0x04003BEA RID: 15338
			internal readonly TextReader _in;
		}
	}
}
