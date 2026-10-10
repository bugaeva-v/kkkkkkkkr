using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;

namespace System
{
	/// <summary>Предоставляет стандартные потоки для консольных приложений: входной, выходной и поток сообщений об ошибках. Этот класс не наследуется.</summary>
	// Token: 0x0200022A RID: 554
	public static class Console
	{
		// Token: 0x060018D9 RID: 6361 RVA: 0x0005E1DC File Offset: 0x0005C3DC
		static Console()
		{
			if (Environment.IsRunningOnWindows)
			{
				try
				{
					Console.inputEncoding = Encoding.GetEncoding(Console.WindowsConsole.GetInputCodePage());
					Console.outputEncoding = Encoding.GetEncoding(Console.WindowsConsole.GetOutputCodePage());
					goto IL_9B;
				}
				catch
				{
					Console.inputEncoding = (Console.outputEncoding = Encoding.Default);
					goto IL_9B;
				}
			}
			int num = 0;
			EncodingHelper.InternalCodePage(ref num);
			if (num != -1 && ((num & 268435455) == 3 || (num & 268435456) != 0))
			{
				Console.inputEncoding = (Console.outputEncoding = EncodingHelper.UTF8Unmarked);
			}
			else
			{
				Console.inputEncoding = (Console.outputEncoding = Encoding.Default);
			}
			IL_9B:
			Console.SetupStreams(Console.inputEncoding, Console.outputEncoding);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0005E2A4 File Offset: 0x0005C4A4
		private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding)
		{
			if (!Environment.IsRunningOnWindows && ConsoleDriver.IsConsole)
			{
				Console.stdin = new CStreamReader(Console.OpenStandardInput(0), inputEncoding);
				Console.stdout = TextWriter.Synchronized(new CStreamWriter(Console.OpenStandardOutput(0), outputEncoding, true)
				{
					AutoFlush = true
				});
				Console.stderr = TextWriter.Synchronized(new CStreamWriter(Console.OpenStandardError(0), outputEncoding, true)
				{
					AutoFlush = true
				});
			}
			else
			{
				Console.stdin = TextReader.Synchronized(new UnexceptionalStreamReader(Console.OpenStandardInput(0), inputEncoding));
				Console.stdout = TextWriter.Synchronized(new UnexceptionalStreamWriter(Console.OpenStandardOutput(0), outputEncoding)
				{
					AutoFlush = true
				});
				Console.stderr = TextWriter.Synchronized(new UnexceptionalStreamWriter(Console.OpenStandardError(0), outputEncoding)
				{
					AutoFlush = true
				});
			}
			GC.SuppressFinalize(Console.stdout);
			GC.SuppressFinalize(Console.stderr);
			GC.SuppressFinalize(Console.stdin);
		}

		/// <summary>Возвращает стандартный выходной поток сообщений об ошибках.</summary>
		/// <returns>Объект <see cref="T:System.IO.TextWriter" />, предоставляющий стандартный поток вывода ошибок.</returns>
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x0005E37C File Offset: 0x0005C57C
		public static TextWriter Error
		{
			get
			{
				return Console.stderr;
			}
		}

		/// <summary>Возвращает стандартный выходной поток.</summary>
		/// <returns>Объект <see cref="T:System.IO.TextWriter" />, представляющий стандартный выходной поток.</returns>
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x0005E383 File Offset: 0x0005C583
		public static TextWriter Out
		{
			get
			{
				return Console.stdout;
			}
		}

		/// <summary>Возвращает стандартный входной поток.</summary>
		/// <returns>Объект <see cref="T:System.IO.TextReader" />, представляющий стандартный входной поток.</returns>
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x0005E38A File Offset: 0x0005C58A
		public static TextReader In
		{
			get
			{
				return Console.stdin;
			}
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0005E394 File Offset: 0x0005C594
		private static Stream Open(IntPtr handle, FileAccess access, int bufferSize)
		{
			Stream result;
			try
			{
				FileStream fileStream = new FileStream(handle, access, false, bufferSize, false, true);
				GC.SuppressFinalize(fileStream);
				result = fileStream;
			}
			catch (IOException)
			{
				result = Stream.Null;
			}
			return result;
		}

		/// <summary>Получает стандартный поток сообщений об ошибках.</summary>
		/// <returns>Стандартный поток сообщений об ошибках.</returns>
		// Token: 0x060018DF RID: 6367 RVA: 0x0005E3D0 File Offset: 0x0005C5D0
		public static Stream OpenStandardError()
		{
			return Console.OpenStandardError(0);
		}

		/// <summary>Получает стандартный поток сообщений об ошибках, для которого установлен заданный размер буфера.</summary>
		/// <param name="bufferSize">Размер буфера внутреннего потока.</param>
		/// <returns>Стандартный поток сообщений об ошибках.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="bufferSize" /> не больше нуля.</exception>
		// Token: 0x060018E0 RID: 6368 RVA: 0x0005E3D8 File Offset: 0x0005C5D8
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public static Stream OpenStandardError(int bufferSize)
		{
			return Console.Open(MonoIO.ConsoleError, FileAccess.Write, bufferSize);
		}

		/// <summary>Получает стандартный входной поток.</summary>
		/// <returns>Стандартный входной поток.</returns>
		// Token: 0x060018E1 RID: 6369 RVA: 0x0005E3E6 File Offset: 0x0005C5E6
		public static Stream OpenStandardInput()
		{
			return Console.OpenStandardInput(0);
		}

		/// <summary>Получает стандартный входной поток, для которого установлен заданный размер буфера.</summary>
		/// <param name="bufferSize">Размер буфера внутреннего потока.</param>
		/// <returns>Стандартный входной поток.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="bufferSize" /> не больше нуля.</exception>
		// Token: 0x060018E2 RID: 6370 RVA: 0x0005E3EE File Offset: 0x0005C5EE
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public static Stream OpenStandardInput(int bufferSize)
		{
			return Console.Open(MonoIO.ConsoleInput, FileAccess.Read, bufferSize);
		}

		/// <summary>Получает стандартный выходной поток.</summary>
		/// <returns>Стандартный выходной поток.</returns>
		// Token: 0x060018E3 RID: 6371 RVA: 0x0005E3FC File Offset: 0x0005C5FC
		public static Stream OpenStandardOutput()
		{
			return Console.OpenStandardOutput(0);
		}

		/// <summary>Получает стандартный выходной поток, для которого установлен заданный размер буфера.</summary>
		/// <param name="bufferSize">Размер буфера внутреннего потока.</param>
		/// <returns>Стандартный выходной поток.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="bufferSize" /> не больше нуля.</exception>
		// Token: 0x060018E4 RID: 6372 RVA: 0x0005E404 File Offset: 0x0005C604
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		public static Stream OpenStandardOutput(int bufferSize)
		{
			return Console.Open(MonoIO.ConsoleOutput, FileAccess.Write, bufferSize);
		}

		/// <summary>Присваивает свойству <see cref="P:System.Console.Error" /> указанный объект <see cref="T:System.IO.TextWriter" />.</summary>
		/// <param name="newError">Поток, являющийся новым стандартным потоком сообщений об ошибках.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="newError" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060018E5 RID: 6373 RVA: 0x0005E412 File Offset: 0x0005C612
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		public static void SetError(TextWriter newError)
		{
			if (newError == null)
			{
				throw new ArgumentNullException("newError");
			}
			Console.stderr = TextWriter.Synchronized(newError);
		}

		/// <summary>Присваивает свойству <see cref="P:System.Console.In" /> указанный объект <see cref="T:System.IO.TextReader" />.</summary>
		/// <param name="newIn">Поток, являющийся новым стандартным входным потоком.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="newIn" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060018E6 RID: 6374 RVA: 0x0005E42D File Offset: 0x0005C62D
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		public static void SetIn(TextReader newIn)
		{
			if (newIn == null)
			{
				throw new ArgumentNullException("newIn");
			}
			Console.stdin = TextReader.Synchronized(newIn);
		}

		/// <summary>Присваивает свойству <see cref="P:System.Console.Out" /> указанный объект <see cref="T:System.IO.TextWriter" />.</summary>
		/// <param name="newOut">Поток, являющийся новым стандартным выходным потоком.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="newOut" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060018E7 RID: 6375 RVA: 0x0005E448 File Offset: 0x0005C648
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		public static void SetOut(TextWriter newOut)
		{
			if (newOut == null)
			{
				throw new ArgumentNullException("newOut");
			}
			Console.stdout = TextWriter.Synchronized(newOut);
		}

		/// <summary>Записывает текстовое представление заданного логического значения в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018E8 RID: 6376 RVA: 0x0005E463 File Offset: 0x0005C663
		public static void Write(bool value)
		{
			Console.stdout.Write(value);
		}

		/// <summary>Записывает значение заданного знака Юникода в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018E9 RID: 6377 RVA: 0x0005E470 File Offset: 0x0005C670
		public static void Write(char value)
		{
			Console.stdout.Write(value);
		}

		/// <summary>Записывает заданный массив знаков Юникода в стандартный выходной поток.</summary>
		/// <param name="buffer">Массив знаков Юникода.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018EA RID: 6378 RVA: 0x0005E47D File Offset: 0x0005C67D
		public static void Write(char[] buffer)
		{
			Console.stdout.Write(buffer);
		}

		/// <summary>Записывает текстовое представление заданного значения <see cref="T:System.Decimal" /> в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018EB RID: 6379 RVA: 0x0005E48A File Offset: 0x0005C68A
		public static void Write(decimal value)
		{
			Console.stdout.Write(value);
		}

		/// <summary>Записывает текстовое представление заданного значения двойной точности с плавающей запятой в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018EC RID: 6380 RVA: 0x0005E497 File Offset: 0x0005C697
		public static void Write(double value)
		{
			Console.stdout.Write(value);
		}

		/// <summary>Записывает текстовое представление заданного 32-битового целого числа со знаком в стандартный поток вывода.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018ED RID: 6381 RVA: 0x0005E4A4 File Offset: 0x0005C6A4
		public static void Write(int value)
		{
			Console.stdout.Write(value);
		}

		/// <summary>Записывает текстовое представление заданного 64-битового целого числа со знаком в стандартный поток вывода.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018EE RID: 6382 RVA: 0x0005E4B1 File Offset: 0x0005C6B1
		public static void Write(long value)
		{
			Console.stdout.Write(value);
		}

		/// <summary>Записывает текстовое представление заданного объекта в стандартный выходной поток.</summary>
		/// <param name="value">Записываемое значение или <see langword="null" />.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018EF RID: 6383 RVA: 0x0005E4BE File Offset: 0x0005C6BE
		public static void Write(object value)
		{
			Console.stdout.Write(value);
		}

		/// <summary>Записывает текстовое представление заданного значения одинарной точности с плавающей запятой в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018F0 RID: 6384 RVA: 0x0005E4CB File Offset: 0x0005C6CB
		public static void Write(float value)
		{
			Console.stdout.Write(value);
		}

		/// <summary>Записывает заданное строковое значение в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018F1 RID: 6385 RVA: 0x0005E4D8 File Offset: 0x0005C6D8
		public static void Write(string value)
		{
			Console.stdout.Write(value);
		}

		/// <summary>Записывает текстовое представление заданного 32-битового целого числа без знака в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018F2 RID: 6386 RVA: 0x0005E4E5 File Offset: 0x0005C6E5
		[CLSCompliant(false)]
		public static void Write(uint value)
		{
			Console.stdout.Write(value);
		}

		/// <summary>Записывает текстовое представление заданного 64-битового целого числа без знака в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018F3 RID: 6387 RVA: 0x0005E4F2 File Offset: 0x0005C6F2
		[CLSCompliant(false)]
		public static void Write(ulong value)
		{
			Console.stdout.Write(value);
		}

		/// <summary>Записывает текстовое представление заданного объекта в стандартный выходной поток, используя заданные сведения о форматировании.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Объект для записи с использованием <paramref name="format" />.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Недопустимая спецификация формата в <paramref name="format" />.</exception>
		// Token: 0x060018F4 RID: 6388 RVA: 0x0005E4FF File Offset: 0x0005C6FF
		public static void Write(string format, object arg0)
		{
			Console.stdout.Write(format, arg0);
		}

		/// <summary>Записывает текстовое представление заданного массива объектов в стандартный выходной поток, используя заданные сведения о форматировании.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg">Массив объектов для записи с использованием <paramref name="format" />.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="format" /> или <paramref name="arg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Недопустимая спецификация формата в <paramref name="format" />.</exception>
		// Token: 0x060018F5 RID: 6389 RVA: 0x0005E50D File Offset: 0x0005C70D
		public static void Write(string format, params object[] arg)
		{
			if (arg == null)
			{
				Console.stdout.Write(format);
				return;
			}
			Console.stdout.Write(format, arg);
		}

		/// <summary>Записывает заданный дочерний массив знаков Юникода в стандартный выходной поток.</summary>
		/// <param name="buffer">Массив знаков Юникода.</param>
		/// <param name="index">Начальная позиция в массиве <paramref name="buffer" />.</param>
		/// <param name="count">Количество символов для записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> или <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="index" /> и <paramref name="count" /> указывает позицию, которая не находится в <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018F6 RID: 6390 RVA: 0x0005E52A File Offset: 0x0005C72A
		public static void Write(char[] buffer, int index, int count)
		{
			Console.stdout.Write(buffer, index, count);
		}

		/// <summary>Записывает текстовые представления заданных объектов в стандартный выходной поток, используя заданные сведения о форматировании.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Первый объект для записи с использованием <paramref name="format" />.</param>
		/// <param name="arg1">Второй объект для записи с использованием <paramref name="format" />.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Недопустимая спецификация формата в <paramref name="format" />.</exception>
		// Token: 0x060018F7 RID: 6391 RVA: 0x0005E539 File Offset: 0x0005C739
		public static void Write(string format, object arg0, object arg1)
		{
			Console.stdout.Write(format, arg0, arg1);
		}

		/// <summary>Записывает текстовые представления заданных объектов в стандартный выходной поток, используя заданные сведения о форматировании.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Первый объект для записи с использованием <paramref name="format" />.</param>
		/// <param name="arg1">Второй объект для записи с использованием <paramref name="format" />.</param>
		/// <param name="arg2">Третий объект для записи с использованием <paramref name="format" />.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Недопустимая спецификация формата в <paramref name="format" />.</exception>
		// Token: 0x060018F8 RID: 6392 RVA: 0x0005E548 File Offset: 0x0005C748
		public static void Write(string format, object arg0, object arg1, object arg2)
		{
			Console.stdout.Write(format, arg0, arg1, arg2);
		}

		/// <summary>Записывает текстовое представление заданных объектов и список параметров переменной длины в стандартный выходной поток, используя заданные сведения о форматировании.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Первый объект для записи с использованием <paramref name="format" />.</param>
		/// <param name="arg1">Второй объект для записи с использованием <paramref name="format" />.</param>
		/// <param name="arg2">Третий объект для записи с использованием <paramref name="format" />.</param>
		/// <param name="arg3">Четвертый объект для записи с использованием <paramref name="format" />.</param>
		/// 	  <param name="…">A comma-delimited list of one or more additional objects to write using <paramref name="format" />. </param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Недопустимая спецификация формата в <paramref name="format" />.</exception>
		// Token: 0x060018F9 RID: 6393 RVA: 0x0005E558 File Offset: 0x0005C758
		[CLSCompliant(false)]
		public static void Write(string format, object arg0, object arg1, object arg2, object arg3, __arglist)
		{
			ArgIterator argIterator = new ArgIterator(__arglist);
			int remainingCount = argIterator.GetRemainingCount();
			object[] array = new object[remainingCount + 4];
			array[0] = arg0;
			array[1] = arg1;
			array[2] = arg2;
			array[3] = arg3;
			for (int i = 0; i < remainingCount; i++)
			{
				TypedReference nextArg = argIterator.GetNextArg();
				array[i + 4] = TypedReference.ToObject(nextArg);
			}
			Console.stdout.Write(string.Format(format, array));
		}

		/// <summary>Записывает текущий признак конца строки в стандартный выходной поток.</summary>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018FA RID: 6394 RVA: 0x0005E5C2 File Offset: 0x0005C7C2
		public static void WriteLine()
		{
			Console.stdout.WriteLine();
		}

		/// <summary>Записывает текстовое представление заданного логического значения с текущим признаком конца строки в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018FB RID: 6395 RVA: 0x0005E5CE File Offset: 0x0005C7CE
		public static void WriteLine(bool value)
		{
			Console.stdout.WriteLine(value);
		}

		/// <summary>Записывает заданный знак Юникода, за которым следует текущий признак конца строки, в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018FC RID: 6396 RVA: 0x0005E5DB File Offset: 0x0005C7DB
		public static void WriteLine(char value)
		{
			Console.stdout.WriteLine(value);
		}

		/// <summary>Записывает заданный массив знаков Юникода, за которым следует текущий признак конца строки, в стандартный выходной поток.</summary>
		/// <param name="buffer">Массив знаков Юникода.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018FD RID: 6397 RVA: 0x0005E5E8 File Offset: 0x0005C7E8
		public static void WriteLine(char[] buffer)
		{
			Console.stdout.WriteLine(buffer);
		}

		/// <summary>Записывает текстовое представление указанного значения <see cref="T:System.Decimal" />, за которым следует текущий знак завершения строки, в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018FE RID: 6398 RVA: 0x0005E5F5 File Offset: 0x0005C7F5
		public static void WriteLine(decimal value)
		{
			Console.stdout.WriteLine(value);
		}

		/// <summary>Записывает текстовое представление заданного значения двойной точности с плавающей запятой, за которым следует признак конца строки, в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x060018FF RID: 6399 RVA: 0x0005E602 File Offset: 0x0005C802
		public static void WriteLine(double value)
		{
			Console.stdout.WriteLine(value);
		}

		/// <summary>Записывает текстовое представление заданного 32-битового целого числа со знаком, за которым следует текущий знак завершения строки, в стандартный поток вывода.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06001900 RID: 6400 RVA: 0x0005E60F File Offset: 0x0005C80F
		public static void WriteLine(int value)
		{
			Console.stdout.WriteLine(value);
		}

		/// <summary>Записывает текстовое представление заданного 64-битового целого числа со знаком, за которым следует текущий знак завершения строки, в стандартный поток вывода.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06001901 RID: 6401 RVA: 0x0005E61C File Offset: 0x0005C81C
		public static void WriteLine(long value)
		{
			Console.stdout.WriteLine(value);
		}

		/// <summary>Записывает текстовое представление заданного объекта, за которым следует текущий признак конца строки, в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06001902 RID: 6402 RVA: 0x0005E629 File Offset: 0x0005C829
		public static void WriteLine(object value)
		{
			Console.stdout.WriteLine(value);
		}

		/// <summary>Записывает текстовое представление заданного значения одинарной точности с плавающей запятой, за которым следует признак конца строки, в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06001903 RID: 6403 RVA: 0x0005E636 File Offset: 0x0005C836
		public static void WriteLine(float value)
		{
			Console.stdout.WriteLine(value);
		}

		/// <summary>Записывает заданное строковое значение, за которым следует текущий признак конца строки, в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06001904 RID: 6404 RVA: 0x0005E643 File Offset: 0x0005C843
		public static void WriteLine(string value)
		{
			Console.stdout.WriteLine(value);
		}

		/// <summary>Записывает текстовое представление заданного 32-битового целого числа без знака, за которым следует текущий признак конца строки, в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06001905 RID: 6405 RVA: 0x0005E650 File Offset: 0x0005C850
		[CLSCompliant(false)]
		public static void WriteLine(uint value)
		{
			Console.stdout.WriteLine(value);
		}

		/// <summary>Записывает текстовое представление заданного 64-битового целого числа без знака, за которым следует текущий признак конца строки, в стандартный выходной поток.</summary>
		/// <param name="value">Значение для записи.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06001906 RID: 6406 RVA: 0x0005E65D File Offset: 0x0005C85D
		[CLSCompliant(false)]
		public static void WriteLine(ulong value)
		{
			Console.stdout.WriteLine(value);
		}

		/// <summary>Записывает текстовое представление заданного объекта, за которым следует текущий признак конца строки, в стандартный выходной поток с использованием заданных сведений о форматировании.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Объект для записи с использованием <paramref name="format" />.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Недопустимая спецификация формата в <paramref name="format" />.</exception>
		// Token: 0x06001907 RID: 6407 RVA: 0x0005E66A File Offset: 0x0005C86A
		public static void WriteLine(string format, object arg0)
		{
			Console.stdout.WriteLine(format, arg0);
		}

		/// <summary>Записывает текстовые представления заданного массива объектов, за которым следует текущий признак конца строки, в стандартный выходной поток с использованием заданных сведений о форматировании.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg">Массив объектов для записи с использованием <paramref name="format" />.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="format" /> или <paramref name="arg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Недопустимая спецификация формата в <paramref name="format" />.</exception>
		// Token: 0x06001908 RID: 6408 RVA: 0x0005E678 File Offset: 0x0005C878
		public static void WriteLine(string format, params object[] arg)
		{
			if (arg == null)
			{
				Console.stdout.WriteLine(format);
				return;
			}
			Console.stdout.WriteLine(format, arg);
		}

		/// <summary>Записывает заданный подмассив знаков Юникода, за которым следует текущий признак конца строки, в стандартный выходной поток.</summary>
		/// <param name="buffer">Массив знаков Юникода.</param>
		/// <param name="index">Начальная позиция в массиве <paramref name="buffer" />.</param>
		/// <param name="count">Количество символов для записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> или <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма <paramref name="index" /> и <paramref name="count" /> указывает позицию, которая не находится в <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06001909 RID: 6409 RVA: 0x0005E695 File Offset: 0x0005C895
		public static void WriteLine(char[] buffer, int index, int count)
		{
			Console.stdout.WriteLine(buffer, index, count);
		}

		/// <summary>Записывает текстовые представления заданных объектов, за которыми следует текущий признак конца строки, в стандартный выходной поток с использованием заданных сведений о форматировании.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Первый объект для записи с использованием <paramref name="format" />.</param>
		/// <param name="arg1">Второй объект для записи с использованием <paramref name="format" />.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Недопустимая спецификация формата в <paramref name="format" />.</exception>
		// Token: 0x0600190A RID: 6410 RVA: 0x0005E6A4 File Offset: 0x0005C8A4
		public static void WriteLine(string format, object arg0, object arg1)
		{
			Console.stdout.WriteLine(format, arg0, arg1);
		}

		/// <summary>Записывает текстовые представления заданных объектов, за которыми следует текущий признак конца строки, в стандартный выходной поток с использованием заданных сведений о форматировании.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Первый объект для записи с использованием <paramref name="format" />.</param>
		/// <param name="arg1">Второй объект для записи с использованием <paramref name="format" />.</param>
		/// <param name="arg2">Третий объект для записи с использованием <paramref name="format" />.</param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Недопустимая спецификация формата в <paramref name="format" />.</exception>
		// Token: 0x0600190B RID: 6411 RVA: 0x0005E6B3 File Offset: 0x0005C8B3
		public static void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			Console.stdout.WriteLine(format, arg0, arg1, arg2);
		}

		/// <summary>Записывает текстовые представления заданных объектов и список параметров переменной длины, за которыми следует текущий признак конца строки, в стандартный выходной поток с использованием заданных сведений о форматировании.</summary>
		/// <param name="format">Строка составного формата.</param>
		/// <param name="arg0">Первый объект для записи с использованием <paramref name="format" />.</param>
		/// <param name="arg1">Второй объект для записи с использованием <paramref name="format" />.</param>
		/// <param name="arg2">Третий объект для записи с использованием <paramref name="format" />.</param>
		/// <param name="arg3">Четвертый объект для записи с использованием <paramref name="format" />.</param>
		/// 	  <param name="…">A comma-delimited list of one or more additional objects to write using <paramref name="format" />. </param>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Недопустимая спецификация формата в <paramref name="format" />.</exception>
		// Token: 0x0600190C RID: 6412 RVA: 0x0005E6C4 File Offset: 0x0005C8C4
		[CLSCompliant(false)]
		public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3, __arglist)
		{
			ArgIterator argIterator = new ArgIterator(__arglist);
			int remainingCount = argIterator.GetRemainingCount();
			object[] array = new object[remainingCount + 4];
			array[0] = arg0;
			array[1] = arg1;
			array[2] = arg2;
			array[3] = arg3;
			for (int i = 0; i < remainingCount; i++)
			{
				TypedReference nextArg = argIterator.GetNextArg();
				array[i + 4] = TypedReference.ToObject(nextArg);
			}
			Console.stdout.WriteLine(string.Format(format, array));
		}

		/// <summary>Читает следующий символ из стандартного входного потока.</summary>
		/// <returns>Следующий символ из входного потока или значение минус единица (-1), если доступных для чтения символов не осталось.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x0600190D RID: 6413 RVA: 0x0005E72E File Offset: 0x0005C92E
		public static int Read()
		{
			if (Console.stdin is CStreamReader && ConsoleDriver.IsConsole)
			{
				return ConsoleDriver.Read();
			}
			return Console.stdin.Read();
		}

		/// <summary>Считывает следующую строку символов из стандартного входного потока.</summary>
		/// <returns>Следующая строка символов из входного потока или значение <see langword="null" />, если больше нет доступных строк.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти для выделения буфера под возвращаемую строку.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Количество символов в следующей строке символов больше, чем <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x0600190E RID: 6414 RVA: 0x0005E753 File Offset: 0x0005C953
		public static string ReadLine()
		{
			if (Console.stdin is CStreamReader && ConsoleDriver.IsConsole)
			{
				return ConsoleDriver.ReadLine();
			}
			return Console.stdin.ReadLine();
		}

		/// <summary>Возвращает или задает кодировку консоли, используемую при чтении входных данных.</summary>
		/// <returns>Кодировка консоли, используемая при чтении ввода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства в операции задания — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Во время выполнения этой операции произошла ошибка.</exception>
		/// <exception cref="T:System.Security.SecurityException">У приложения нет разрешения на выполнение этой операции.</exception>
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x0005E778 File Offset: 0x0005C978
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x0005E77F File Offset: 0x0005C97F
		public static Encoding InputEncoding
		{
			get
			{
				return Console.inputEncoding;
			}
			set
			{
				Console.inputEncoding = value;
				Console.SetupStreams(Console.inputEncoding, Console.outputEncoding);
			}
		}

		/// <summary>Получает или задает кодировку консоли, используемую при записи выходных данных.</summary>
		/// <returns>Кодировка консоли, используемая при записи вывода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства в операции задания — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Во время выполнения этой операции произошла ошибка.</exception>
		/// <exception cref="T:System.Security.SecurityException">У приложения нет разрешения на выполнение этой операции.</exception>
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x0005E796 File Offset: 0x0005C996
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x0005E79D File Offset: 0x0005C99D
		public static Encoding OutputEncoding
		{
			get
			{
				return Console.outputEncoding;
			}
			set
			{
				Console.outputEncoding = value;
				Console.SetupStreams(Console.inputEncoding, Console.outputEncoding);
			}
		}

		/// <summary>Возвращает или задает цвет фона консоли.</summary>
		/// <returns>Значение из перечисления , задающее фоновый цвет консоли, то есть цвет, на фоне которого выводятся символы. Значением по умолчанию является Black.</returns>
		/// <exception cref="T:System.ArgumentException">Цвет, указанный в операции SET, не является допустимым членом <see cref="T:System.ConsoleColor" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x0005E7B4 File Offset: 0x0005C9B4
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x0005E7BB File Offset: 0x0005C9BB
		public static ConsoleColor BackgroundColor
		{
			get
			{
				return ConsoleDriver.BackgroundColor;
			}
			set
			{
				ConsoleDriver.BackgroundColor = value;
			}
		}

		/// <summary>Возвращает или задает высоту буферной области.</summary>
		/// <returns>Текущая высота буферной области в строках.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение в операции задания меньше или равно нулю.  
		/// -или- 
		/// Значение в операции задания больше или равно <see cref="F:System.Int16.MaxValue" />.  
		///
		/// или - 
		/// Значение в операции задания меньше суммы <see cref="P:System.Console.WindowTop" /> + <see cref="P:System.Console.WindowHeight" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0005E7C3 File Offset: 0x0005C9C3
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x0005E7CA File Offset: 0x0005C9CA
		public static int BufferHeight
		{
			get
			{
				return ConsoleDriver.BufferHeight;
			}
			[MonoLimitation("Implemented only on Windows")]
			set
			{
				ConsoleDriver.BufferHeight = value;
			}
		}

		/// <summary>Возвращает или задает ширину буферной области.</summary>
		/// <returns>Текущая ширина буферной области в столбцах.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение в операции задания меньше или равно нулю.  
		///
		/// или - 
		/// Значение в операции задания больше или равно <see cref="F:System.Int16.MaxValue" />.  
		///
		/// -или- 
		/// Значение в операции задания меньше суммы <see cref="P:System.Console.WindowLeft" /> + <see cref="P:System.Console.WindowWidth" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x0005E7D2 File Offset: 0x0005C9D2
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x0005E7D9 File Offset: 0x0005C9D9
		public static int BufferWidth
		{
			get
			{
				return ConsoleDriver.BufferWidth;
			}
			[MonoLimitation("Implemented only on Windows")]
			set
			{
				ConsoleDriver.BufferWidth = value;
			}
		}

		/// <summary>Возвращает значение, указывающее, включен или отключен режим CAPS LOCK клавиатуры.</summary>
		/// <returns>Значение <see langword="true" />, если режим CAPS LOCK включен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x0005E7E1 File Offset: 0x0005C9E1
		[MonoLimitation("Implemented only on Windows")]
		public static bool CapsLock
		{
			get
			{
				return ConsoleDriver.CapsLock;
			}
		}

		/// <summary>Возвращает или задает позицию столбца курсора в буферной области.</summary>
		/// <returns>Текущая позиция курсора в столбцах.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение в операции задания меньше нуля.  
		/// -или- 
		/// Значение в операции задания больше или равно <see cref="P:System.Console.BufferWidth" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0005E7E8 File Offset: 0x0005C9E8
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x0005E7EF File Offset: 0x0005C9EF
		public static int CursorLeft
		{
			get
			{
				return ConsoleDriver.CursorLeft;
			}
			set
			{
				ConsoleDriver.CursorLeft = value;
			}
		}

		/// <summary>Возвращает или задает позицию строки курсора в буферной области.</summary>
		/// <returns>Текущая позиция курсора в строках.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение в операции задания меньше нуля.  
		/// -или- 
		/// Значение в операции задания больше или равно <see cref="P:System.Console.BufferHeight" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x0005E7F7 File Offset: 0x0005C9F7
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x0005E7FE File Offset: 0x0005C9FE
		public static int CursorTop
		{
			get
			{
				return ConsoleDriver.CursorTop;
			}
			set
			{
				ConsoleDriver.CursorTop = value;
			}
		}

		/// <summary>Возвращает или задает высоту курсора в символьной ячейке.</summary>
		/// <returns>Размер курсора, выраженный как процент от высоты символьной ячейки. Данное свойство принимает значения в диапазоне от 1 до 100.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное в операции задания, меньше 1 или больше 100.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x0005E806 File Offset: 0x0005CA06
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x0005E80D File Offset: 0x0005CA0D
		public static int CursorSize
		{
			get
			{
				return ConsoleDriver.CursorSize;
			}
			set
			{
				ConsoleDriver.CursorSize = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, видим ли курсор.</summary>
		/// <returns>Значение <see langword="true" />, если курсор видим; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x0005E815 File Offset: 0x0005CA15
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x0005E81C File Offset: 0x0005CA1C
		public static bool CursorVisible
		{
			get
			{
				return ConsoleDriver.CursorVisible;
			}
			set
			{
				ConsoleDriver.CursorVisible = value;
			}
		}

		/// <summary>Возвращает или задает цвет фона консоли.</summary>
		/// <returns>Значение из перечисления <see cref="T:System.ConsoleColor" />, задающее цвет переднего плана консоли, то есть цвет, которым выводятся символы. По умолчанию задано значение Gray.</returns>
		/// <exception cref="T:System.ArgumentException">Цвет, указанный в операции SET, не является допустимым членом <see cref="T:System.ConsoleColor" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x0005E824 File Offset: 0x0005CA24
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x0005E82B File Offset: 0x0005CA2B
		public static ConsoleColor ForegroundColor
		{
			get
			{
				return ConsoleDriver.ForegroundColor;
			}
			set
			{
				ConsoleDriver.ForegroundColor = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, доступно ли нажатие клавиши во входном потоке.</summary>
		/// <returns>Значение <see langword="true" />, если нажатие клавиши доступно; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		/// <exception cref="T:System.InvalidOperationException">Стандартный ввод перенаправляется в файл вместо клавиатуры.</exception>
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x0005E833 File Offset: 0x0005CA33
		public static bool KeyAvailable
		{
			get
			{
				return ConsoleDriver.KeyAvailable;
			}
		}

		/// <summary>Возвращает максимальное число строк окна консоли с учетом текущего шрифта и разрешения экрана.</summary>
		/// <returns>Максимально возможная высота окна консоли измеряется в строках.</returns>
		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x0005E83A File Offset: 0x0005CA3A
		public static int LargestWindowHeight
		{
			get
			{
				return ConsoleDriver.LargestWindowHeight;
			}
		}

		/// <summary>Возвращает максимальное число столбцов окна консоли с учетом текущего шрифта и разрешения экрана.</summary>
		/// <returns>Максимально возможная ширина окна консоли измеряется в столбцах.</returns>
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0005E841 File Offset: 0x0005CA41
		public static int LargestWindowWidth
		{
			get
			{
				return ConsoleDriver.LargestWindowWidth;
			}
		}

		/// <summary>Возвращает значение, указывающее, включен или отключен режим NUM LOCK клавиатуры.</summary>
		/// <returns>Значение <see langword="true" />, если клавиша NUM LOCK включена; значение <see langword="false" />, если клавиша NUM LOCK выключена.</returns>
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x0005E848 File Offset: 0x0005CA48
		public static bool NumberLock
		{
			get
			{
				return ConsoleDriver.NumberLock;
			}
		}

		/// <summary>Возвращает или задает заголовок для отображения в строке заголовка консоли.</summary>
		/// <returns>Строка для отображения в строке заголовка консоли. Максимальная длина строки заголовка — 24500 символов.</returns>
		/// <exception cref="T:System.InvalidOperationException">В операции get длина полученного заголовка превышает 24 500 символов.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">В операции set длина указанного заголовка превышает 24 500 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">В операции set указанный заголовок имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x0005E84F File Offset: 0x0005CA4F
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x0005E856 File Offset: 0x0005CA56
		public static string Title
		{
			get
			{
				return ConsoleDriver.Title;
			}
			set
			{
				ConsoleDriver.Title = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, интерпретируется ли комбинация клавиши-модификатора <see cref="F:System.ConsoleModifiers.Control" /> и клавиши консоли <see cref="F:System.ConsoleKey.C" /> (Ctrl+C) как обычный ввод или как прерывание, которое обрабатывается операционной системой.</summary>
		/// <returns>Значение <see langword="true" />, если сочетание клавиш CTRL+C интерпретируется как обычный ввод; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.IO.IOException">Не удалось получить или задать режим ввода входного буфера консоли.</exception>
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0005E85E File Offset: 0x0005CA5E
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x0005E865 File Offset: 0x0005CA65
		public static bool TreatControlCAsInput
		{
			get
			{
				return ConsoleDriver.TreatControlCAsInput;
			}
			set
			{
				ConsoleDriver.TreatControlCAsInput = value;
			}
		}

		/// <summary>Возвращает или задает высоту области окна консоли.</summary>
		/// <returns>Высота окна консоли измеряется строками.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение свойства <see cref="P:System.Console.WindowWidth" /> или <see cref="P:System.Console.WindowHeight" /> больше или равно 0.  
		/// -или- 
		/// Сумма значений свойств <see cref="P:System.Console.WindowHeight" /> и <see cref="P:System.Console.WindowTop" /> больше или равна <see cref="F:System.Int16.MaxValue" />.  
		///
		/// или - 
		/// Значение свойства <see cref="P:System.Console.WindowWidth" /> или <see cref="P:System.Console.WindowHeight" /> больше наибольшей возможной ширины или высоты окна для текущего шрифта консоли и разрешения экрана.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка при чтении или записи данных.</exception>
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0005E86D File Offset: 0x0005CA6D
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x0005E874 File Offset: 0x0005CA74
		public static int WindowHeight
		{
			get
			{
				return ConsoleDriver.WindowHeight;
			}
			set
			{
				ConsoleDriver.WindowHeight = value;
			}
		}

		/// <summary>Возвращает или задает позицию левого края области окна консоли относительно буфера экрана.</summary>
		/// <returns>Позиция левого края области окна консоли измеряется столбцами.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">В операции задания назначаемое значение меньше нуля.  
		///
		/// или - 
		/// В результате назначения сумма <see cref="P:System.Console.WindowLeft" /> и <see cref="P:System.Console.WindowWidth" /> превысит <see cref="P:System.Console.BufferWidth" />.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка при чтении или записи данных.</exception>
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0005E87C File Offset: 0x0005CA7C
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x0005E883 File Offset: 0x0005CA83
		public static int WindowLeft
		{
			get
			{
				return ConsoleDriver.WindowLeft;
			}
			set
			{
				ConsoleDriver.WindowLeft = value;
			}
		}

		/// <summary>Возвращает или задает позицию верхнего края области окна консоли относительно буфера экрана.</summary>
		/// <returns>Позиция верхнего края области окна консоли измеряется строками.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">В операции задания назначаемое значение меньше нуля.  
		///
		/// или - 
		/// В результате назначения сумма <see cref="P:System.Console.WindowTop" /> и <see cref="P:System.Console.WindowHeight" /> превысит <see cref="P:System.Console.BufferHeight" />.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка при чтении или записи данных.</exception>
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0005E88B File Offset: 0x0005CA8B
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x0005E892 File Offset: 0x0005CA92
		public static int WindowTop
		{
			get
			{
				return ConsoleDriver.WindowTop;
			}
			set
			{
				ConsoleDriver.WindowTop = value;
			}
		}

		/// <summary>Возвращает или задает ширину окна консоли.</summary>
		/// <returns>Ширина окна консоли измеряется столбцами.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение свойства <see cref="P:System.Console.WindowWidth" /> или <see cref="P:System.Console.WindowHeight" /> больше или равно 0.  
		///
		/// или - 
		/// Сумма значений свойств <see cref="P:System.Console.WindowHeight" /> и <see cref="P:System.Console.WindowTop" /> больше или равна <see cref="F:System.Int16.MaxValue" />.  
		///
		/// или - 
		/// Значение свойства <see cref="P:System.Console.WindowWidth" /> или <see cref="P:System.Console.WindowHeight" /> больше наибольшей возможной ширины или высоты окна для текущего шрифта консоли и разрешения экрана.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка при чтении или записи данных.</exception>
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0005E89A File Offset: 0x0005CA9A
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x0005E8A1 File Offset: 0x0005CAA1
		public static int WindowWidth
		{
			get
			{
				return ConsoleDriver.WindowWidth;
			}
			set
			{
				ConsoleDriver.WindowWidth = value;
			}
		}

		/// <summary>Получает значение, показывающее, был ли перенаправлен выходной поток ошибок от стандартного потока ошибок.</summary>
		/// <returns>Значение <see langword="true" />, если выходные сообщения об ошибках перенаправляются; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x0005E8A9 File Offset: 0x0005CAA9
		public static bool IsErrorRedirected
		{
			get
			{
				return ConsoleDriver.IsErrorRedirected;
			}
		}

		/// <summary>Получает значение, показывающее, был ли перенаправлены выходные данные от стандартного выходного потока.</summary>
		/// <returns>Значение <see langword="true" />, если выходные данные перенаправляются; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x0005E8B0 File Offset: 0x0005CAB0
		public static bool IsOutputRedirected
		{
			get
			{
				return ConsoleDriver.IsOutputRedirected;
			}
		}

		/// <summary>Получает значение, показывающее, был ли перенаправлены ли входные данные от стандартного входного потока.</summary>
		/// <returns>Значение <see langword="true" />, если входные данные перенаправляются; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x0005E8B7 File Offset: 0x0005CAB7
		public static bool IsInputRedirected
		{
			get
			{
				return ConsoleDriver.IsInputRedirected;
			}
		}

		/// <summary>Воспроизводит звуковой сигнал через динамик консоли.</summary>
		/// <exception cref="T:System.Security.HostProtectionException">Этот метод выполнен на сервере, например SQL Server, который не разрешает доступ к интерфейсу пользователя.</exception>
		// Token: 0x06001937 RID: 6455 RVA: 0x0005E8BE File Offset: 0x0005CABE
		public static void Beep()
		{
			Console.Beep(1000, 500);
		}

		/// <summary>Воспроизводит звуковой сигнал заданной частоты и длительности через динамик консоли.</summary>
		/// <param name="frequency">Частота сигнала в диапазоне от 37 до 32767 Гц.</param>
		/// <param name="duration">Длительность сигнала в миллисекундах.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="frequency" /> меньше 37 или больше 32767 Гц.  
		///
		/// или - 
		/// <paramref name="duration" /> меньше или равно нулю.</exception>
		/// <exception cref="T:System.Security.HostProtectionException">Этот метод выполнен на сервере, например SQL Server, который не разрешает доступ к консоли.</exception>
		// Token: 0x06001938 RID: 6456 RVA: 0x0005E8CF File Offset: 0x0005CACF
		public static void Beep(int frequency, int duration)
		{
			if (frequency < 37 || frequency > 32767)
			{
				throw new ArgumentOutOfRangeException("frequency");
			}
			if (duration <= 0)
			{
				throw new ArgumentOutOfRangeException("duration");
			}
			ConsoleDriver.Beep(frequency, duration);
		}

		/// <summary>Удаляет из буфера консоли и ее окна отображаемую информацию.</summary>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06001939 RID: 6457 RVA: 0x0005E8FF File Offset: 0x0005CAFF
		public static void Clear()
		{
			ConsoleDriver.Clear();
		}

		/// <summary>Копирует заданную исходную область буфера экрана в заданную область назначения.</summary>
		/// <param name="sourceLeft">Крайний слева столбец исходной области.</param>
		/// <param name="sourceTop">Самая верхняя строка исходной области.</param>
		/// <param name="sourceWidth">Общее число столбцов в исходной области.</param>
		/// <param name="sourceHeight">Общее число строк в исходной области.</param>
		/// <param name="targetLeft">Крайний слева столбец области назначения.</param>
		/// <param name="targetTop">Самая верхняя строка области назначения.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Один или несколько параметров имеют значение меньше нуля.  
		/// -или- 
		///  Параметр <paramref name="sourceLeft" /> или <paramref name="targetLeft" /> больше или равен <see cref="P:System.Console.BufferWidth" />.  
		/// -или- 
		///  Параметр <paramref name="sourceTop" /> или <paramref name="targetTop" /> больше или равен <see cref="P:System.Console.BufferHeight" />.  
		/// -или- 
		///  <paramref name="sourceTop" /> + <paramref name="sourceHeight" /> больше или равно <see cref="P:System.Console.BufferHeight" />.  
		/// -или- 
		///  <paramref name="sourceLeft" /> + <paramref name="sourceWidth" /> больше или равно <see cref="P:System.Console.BufferWidth" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x0600193A RID: 6458 RVA: 0x0005E906 File Offset: 0x0005CB06
		[MonoLimitation("Implemented only on Windows")]
		public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
		{
			ConsoleDriver.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
		}

		/// <summary>Копирует заданную исходную область буфера экрана в заданную область назначения.</summary>
		/// <param name="sourceLeft">Крайний слева столбец исходной области.</param>
		/// <param name="sourceTop">Самая верхняя строка исходной области.</param>
		/// <param name="sourceWidth">Общее число столбцов в исходной области.</param>
		/// <param name="sourceHeight">Общее число строк в исходной области.</param>
		/// <param name="targetLeft">Крайний слева столбец области назначения.</param>
		/// <param name="targetTop">Самая верхняя строка области назначения.</param>
		/// <param name="sourceChar">Символ, используемый для заполнения исходной области.</param>
		/// <param name="sourceForeColor">Цвет переднего плана, используемый для заполнения исходной области.</param>
		/// <param name="sourceBackColor">Цвет фона, используемый для заполнения исходной области.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Один или несколько параметров имеют значение меньше нуля.  
		///
		/// или - 
		/// Параметр <paramref name="sourceLeft" /> или <paramref name="targetLeft" /> больше или равен <see cref="P:System.Console.BufferWidth" />.  
		///
		/// -или- 
		///  Параметр <paramref name="sourceTop" /> или <paramref name="targetTop" /> больше или равен <see cref="P:System.Console.BufferHeight" />.  
		/// -или- 
		///  <paramref name="sourceTop" /> + <paramref name="sourceHeight" /> больше или равно <see cref="P:System.Console.BufferHeight" />.  
		/// -или- 
		///  <paramref name="sourceLeft" /> + <paramref name="sourceWidth" /> больше или равно <see cref="P:System.Console.BufferWidth" />.</exception>
		/// <exception cref="T:System.ArgumentException">Один или более параметров цвета не являются членами перечисления <see cref="T:System.ConsoleColor" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x0600193B RID: 6459 RVA: 0x0005E918 File Offset: 0x0005CB18
		[MonoLimitation("Implemented only on Windows")]
		public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
		{
			ConsoleDriver.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);
		}

		/// <summary>Получает следующий нажатый пользователем символ или функциональную клавишу. Нажатая клавиша отображается в окне консоли.</summary>
		/// <returns>Объект, описывающий константу <see cref="T:System.ConsoleKey" /> и символ Юникода (при наличии), соответствующий нажатой клавише консоли. Этот объект <see cref="T:System.ConsoleKeyInfo" /> также описывает в битовой комбинации значений <see cref="T:System.ConsoleModifiers" />, нажимались ли клавиши-модификаторы (одна или несколько) Shift, Alt или Ctrl одновременно с клавишей консоли.</returns>
		/// <exception cref="T:System.InvalidOperationException">Свойство <see cref="P:System.Console.In" /> перенаправлено из потока, отличного от консоли.</exception>
		// Token: 0x0600193C RID: 6460 RVA: 0x0005E938 File Offset: 0x0005CB38
		public static ConsoleKeyInfo ReadKey()
		{
			return Console.ReadKey(false);
		}

		/// <summary>Получает следующий нажатый пользователем символ или функциональную клавишу. Нажатая клавиша может быть отображена в окне консоли.</summary>
		/// <param name="intercept">Определяет, следует ли отображать нажатую клавишу в окне консоли. Значение <see langword="true" />, чтобы не отображать нажатую клавишу; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Объект, описывающий константу <see cref="T:System.ConsoleKey" /> и символ Юникода (при наличии), соответствующий нажатой клавише консоли. Этот объект <see cref="T:System.ConsoleKeyInfo" /> также описывает в битовой комбинации значений <see cref="T:System.ConsoleModifiers" />, нажимались ли клавиши-модификаторы (одна или несколько) Shift, Alt или Ctrl одновременно с клавишей консоли.</returns>
		/// <exception cref="T:System.InvalidOperationException">Свойство <see cref="P:System.Console.In" /> перенаправлено из потока, отличного от консоли.</exception>
		// Token: 0x0600193D RID: 6461 RVA: 0x0005E940 File Offset: 0x0005CB40
		public static ConsoleKeyInfo ReadKey(bool intercept)
		{
			return ConsoleDriver.ReadKey(intercept);
		}

		/// <summary>Устанавливает для цветов фона и текста консоли их значения по умолчанию.</summary>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x0600193E RID: 6462 RVA: 0x0005E948 File Offset: 0x0005CB48
		public static void ResetColor()
		{
			ConsoleDriver.ResetColor();
		}

		/// <summary>Устанавливает заданные значения высоты и ширины буферной области экрана.</summary>
		/// <param name="width">Ширина области буфера в столбцах.</param>
		/// <param name="height">Высота области буфера в строках.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="height" /> или <paramref name="width" /> меньше или равно нулю.  
		/// -или- 
		///  Параметр <paramref name="height" /> или <paramref name="width" /> больше или равен <see cref="F:System.Int16.MaxValue" />.  
		/// -или- 
		///  <paramref name="width" /> меньше <see cref="P:System.Console.WindowLeft" /> + <see cref="P:System.Console.WindowWidth" />.  
		/// -или- 
		///  <paramref name="height" /> меньше <see cref="P:System.Console.WindowTop" /> + <see cref="P:System.Console.WindowHeight" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x0600193F RID: 6463 RVA: 0x0005E94F File Offset: 0x0005CB4F
		[MonoLimitation("Only works on windows")]
		public static void SetBufferSize(int width, int height)
		{
			ConsoleDriver.SetBufferSize(width, height);
		}

		/// <summary>Устанавливает положение курсора.</summary>
		/// <param name="left">Позиция столбца курсора. Столбцы нумеруются как слева направо, начинается с 0.</param>
		/// <param name="top">Позиция строки курсора. Строки пронумерованы сверху вниз, начиная с 0.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="left" /> или <paramref name="top" /> меньше нуля.  
		///
		/// или - 
		/// Значение <paramref name="left" /> больше или равно <see cref="P:System.Console.BufferWidth" />.  
		///
		/// -или- 
		///  Значение <paramref name="top" /> больше или равно <see cref="P:System.Console.BufferHeight" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06001940 RID: 6464 RVA: 0x0005E958 File Offset: 0x0005CB58
		public static void SetCursorPosition(int left, int top)
		{
			ConsoleDriver.SetCursorPosition(left, top);
		}

		/// <summary>Задает позицию окна консоли относительно буфера экрана.</summary>
		/// <param name="left">Позиция столбца верхнего левого угла окна консоли.</param>
		/// <param name="top">Позиция строки верхнего левого угла окна консоли.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="left" /> или <paramref name="top" /> меньше нуля.  
		///
		/// или - 
		/// <paramref name="left" /> + <see cref="P:System.Console.WindowWidth" /> больше <see cref="P:System.Console.BufferWidth" />.  
		///
		/// -или- 
		///  <paramref name="top" /> + <see cref="P:System.Console.WindowHeight" /> больше <see cref="P:System.Console.BufferHeight" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06001941 RID: 6465 RVA: 0x0005E961 File Offset: 0x0005CB61
		public static void SetWindowPosition(int left, int top)
		{
			ConsoleDriver.SetWindowPosition(left, top);
		}

		/// <summary>Устанавливает заданные значения высоты и ширины окна консоли.</summary>
		/// <param name="width">Ширина окна консоли измеряется столбцами.</param>
		/// <param name="height">Высота окна консоли измеряется строками.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="width" /> или <paramref name="height" /> меньше или равно нулю.  
		/// -или- 
		///  <paramref name="width" /> плюс <see cref="P:System.Console.WindowLeft" /> или <paramref name="height" /> плюс <see cref="P:System.Console.WindowTop" /> больше или равно <see cref="F:System.Int16.MaxValue" />.  
		/// -или- 
		///  Значение <paramref name="width" /> или <paramref name="height" /> больше наибольшей возможной ширины или высоты окна для текущего разрешения экрана и шрифта консоли.</exception>
		/// <exception cref="T:System.Security.SecurityException">Пользователь не имеет разрешений на выполнение этого действия.</exception>
		/// <exception cref="T:System.IO.IOException">Ошибка ввода/вывода.</exception>
		// Token: 0x06001942 RID: 6466 RVA: 0x0005E96A File Offset: 0x0005CB6A
		public static void SetWindowSize(int width, int height)
		{
			ConsoleDriver.SetWindowSize(width, height);
		}

		/// <summary>Возникает при одновременном нажатии клавиши-модификатора <see cref="F:System.ConsoleModifiers.Control" /> (Ctrl) и либо клавиши консоли <see cref="F:System.ConsoleKey.C" /> (C), либо клавиши Break (Ctrl+C или Ctrl+Break).</summary>
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06001943 RID: 6467 RVA: 0x0005E973 File Offset: 0x0005CB73
		// (remove) Token: 0x06001944 RID: 6468 RVA: 0x0005E9A9 File Offset: 0x0005CBA9
		public static event ConsoleCancelEventHandler CancelKeyPress
		{
			add
			{
				if (!ConsoleDriver.Initialized)
				{
					ConsoleDriver.Init();
				}
				Console.cancel_event = (ConsoleCancelEventHandler)Delegate.Combine(Console.cancel_event, value);
				if (Environment.IsRunningOnWindows && !Console.WindowsConsole.ctrlHandlerAdded)
				{
					Console.WindowsConsole.AddCtrlHandler();
				}
			}
			remove
			{
				if (!ConsoleDriver.Initialized)
				{
					ConsoleDriver.Init();
				}
				Console.cancel_event = (ConsoleCancelEventHandler)Delegate.Remove(Console.cancel_event, value);
				if (Console.cancel_event == null && Environment.IsRunningOnWindows && Console.WindowsConsole.ctrlHandlerAdded)
				{
					Console.WindowsConsole.RemoveCtrlHandler();
				}
			}
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0005E9E6 File Offset: 0x0005CBE6
		private static void DoConsoleCancelEventInBackground()
		{
			ThreadPool.UnsafeQueueUserWorkItem(delegate(object _)
			{
				Console.DoConsoleCancelEvent();
			}, null);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0005EA10 File Offset: 0x0005CC10
		private static void DoConsoleCancelEvent()
		{
			bool flag = true;
			if (Console.cancel_event != null)
			{
				ConsoleCancelEventArgs consoleCancelEventArgs = new ConsoleCancelEventArgs(ConsoleSpecialKey.ControlC);
				foreach (ConsoleCancelEventHandler consoleCancelEventHandler in Console.cancel_event.GetInvocationList())
				{
					try
					{
						consoleCancelEventHandler(null, consoleCancelEventArgs);
					}
					catch
					{
					}
				}
				flag = !consoleCancelEventArgs.Cancel;
			}
			if (flag)
			{
				Environment.Exit(58);
			}
		}

		// Token: 0x040016DB RID: 5851
		internal static TextWriter stdout;

		// Token: 0x040016DC RID: 5852
		private static TextWriter stderr;

		// Token: 0x040016DD RID: 5853
		private static TextReader stdin;

		// Token: 0x040016DE RID: 5854
		private const string LibLog = "/system/lib/liblog.so";

		// Token: 0x040016DF RID: 5855
		private const string LibLog64 = "/system/lib64/liblog.so";

		// Token: 0x040016E0 RID: 5856
		internal static bool IsRunningOnAndroid = File.Exists("/system/lib/liblog.so") || File.Exists("/system/lib64/liblog.so");

		// Token: 0x040016E1 RID: 5857
		private static Encoding inputEncoding;

		// Token: 0x040016E2 RID: 5858
		private static Encoding outputEncoding;

		// Token: 0x040016E3 RID: 5859
		private static ConsoleCancelEventHandler cancel_event;

		// Token: 0x0200022B RID: 555
		private class WindowsConsole
		{
			// Token: 0x06001947 RID: 6471
			[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
			private static extern int GetConsoleCP();

			// Token: 0x06001948 RID: 6472
			[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
			private static extern int GetConsoleOutputCP();

			// Token: 0x06001949 RID: 6473
			[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
			private static extern bool SetConsoleCtrlHandler(Console.WindowsConsole.WindowsCancelHandler handler, bool addHandler);

			// Token: 0x0600194A RID: 6474 RVA: 0x0005EA84 File Offset: 0x0005CC84
			private static bool DoWindowsConsoleCancelEvent(int keyCode)
			{
				if (keyCode == 0)
				{
					Console.DoConsoleCancelEvent();
				}
				return keyCode == 0;
			}

			// Token: 0x0600194B RID: 6475 RVA: 0x0005EA92 File Offset: 0x0005CC92
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static int GetInputCodePage()
			{
				return Console.WindowsConsole.GetConsoleCP();
			}

			// Token: 0x0600194C RID: 6476 RVA: 0x0005EA99 File Offset: 0x0005CC99
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static int GetOutputCodePage()
			{
				return Console.WindowsConsole.GetConsoleOutputCP();
			}

			// Token: 0x0600194D RID: 6477 RVA: 0x0005EAA0 File Offset: 0x0005CCA0
			public static void AddCtrlHandler()
			{
				Console.WindowsConsole.SetConsoleCtrlHandler(Console.WindowsConsole.cancelHandler, true);
				Console.WindowsConsole.ctrlHandlerAdded = true;
			}

			// Token: 0x0600194E RID: 6478 RVA: 0x0005EAB4 File Offset: 0x0005CCB4
			public static void RemoveCtrlHandler()
			{
				Console.WindowsConsole.SetConsoleCtrlHandler(Console.WindowsConsole.cancelHandler, false);
				Console.WindowsConsole.ctrlHandlerAdded = false;
			}

			// Token: 0x040016E4 RID: 5860
			public static bool ctrlHandlerAdded = false;

			// Token: 0x040016E5 RID: 5861
			private static Console.WindowsConsole.WindowsCancelHandler cancelHandler = new Console.WindowsConsole.WindowsCancelHandler(Console.WindowsConsole.DoWindowsConsoleCancelEvent);

			// Token: 0x0200022C RID: 556
			// (Invoke) Token: 0x06001952 RID: 6482
			private delegate bool WindowsCancelHandler(int keyCode);
		}
	}
}
