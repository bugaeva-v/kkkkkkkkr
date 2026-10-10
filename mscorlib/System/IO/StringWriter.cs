using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Реализует объект <see cref="T:System.IO.TextWriter" /> для записи сведений в строку. Сведения хранятся в базовом <see cref="T:System.Text.StringBuilder" />.</summary>
	// Token: 0x02000B5A RID: 2906
	[ComVisible(true)]
	[Serializable]
	public class StringWriter : TextWriter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StringWriter" />.</summary>
		// Token: 0x06006948 RID: 26952 RVA: 0x00167E43 File Offset: 0x00166043
		public StringWriter() : this(new StringBuilder(), CultureInfo.CurrentCulture)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StringWriter" /> указанным элементом управления формата.</summary>
		/// <param name="formatProvider">Объект <see cref="T:System.IFormatProvider" />, управляющий форматированием.</param>
		// Token: 0x06006949 RID: 26953 RVA: 0x00167E55 File Offset: 0x00166055
		public StringWriter(IFormatProvider formatProvider) : this(new StringBuilder(), formatProvider)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StringWriter" />, который производит запись в указанный объект <see cref="T:System.Text.StringBuilder" />.</summary>
		/// <param name="sb">Объект <see cref="T:System.Text.StringBuilder" />, куда выполняется запись.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="sb" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600694A RID: 26954 RVA: 0x00167E63 File Offset: 0x00166063
		public StringWriter(StringBuilder sb) : this(sb, CultureInfo.CurrentCulture)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.StringWriter" />, который выполняет запись в указанный объект <see cref="T:System.Text.StringBuilder" /> и имеет указанный поставщик формата.</summary>
		/// <param name="sb">Объект <see cref="T:System.Text.StringBuilder" />, куда выполняется запись.</param>
		/// <param name="formatProvider">Объект <see cref="T:System.IFormatProvider" />, управляющий форматированием.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="sb" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600694B RID: 26955 RVA: 0x00167E71 File Offset: 0x00166071
		public StringWriter(StringBuilder sb, IFormatProvider formatProvider) : base(formatProvider)
		{
			if (sb == null)
			{
				throw new ArgumentNullException("sb", Environment.GetResourceString("Buffer cannot be null."));
			}
			this._sb = sb;
			this._isOpen = true;
		}

		/// <summary>Закрывает текущий <see cref="T:System.IO.StringWriter" /> и базовый поток.</summary>
		// Token: 0x0600694C RID: 26956 RVA: 0x00167EA0 File Offset: 0x001660A0
		public override void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.IO.StringWriter" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x0600694D RID: 26957 RVA: 0x00167EA9 File Offset: 0x001660A9
		protected override void Dispose(bool disposing)
		{
			this._isOpen = false;
			base.Dispose(disposing);
		}

		/// <summary>Получает кодировку <see cref="T:System.Text.Encoding" />, в которой осуществляется запись выходных данных.</summary>
		/// <returns>Кодировка <see langword="Encoding" />, в которой осуществляется запись выходных данных.</returns>
		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x0600694E RID: 26958 RVA: 0x00167EB9 File Offset: 0x001660B9
		public override Encoding Encoding
		{
			get
			{
				if (StringWriter.m_encoding == null)
				{
					StringWriter.m_encoding = new UnicodeEncoding(false, false);
				}
				return StringWriter.m_encoding;
			}
		}

		/// <summary>Возвращает базовый объект <see cref="T:System.Text.StringBuilder" />.</summary>
		/// <returns>Базовый объект <see langword="StringBuilder" />.</returns>
		// Token: 0x0600694F RID: 26959 RVA: 0x00167ED9 File Offset: 0x001660D9
		public virtual StringBuilder GetStringBuilder()
		{
			return this._sb;
		}

		/// <summary>Записывает символ в строку.</summary>
		/// <param name="value">Записываемый символ.</param>
		/// <exception cref="T:System.ObjectDisposedException">Модуль записи закрыт.</exception>
		// Token: 0x06006950 RID: 26960 RVA: 0x00167EE1 File Offset: 0x001660E1
		public override void Write(char value)
		{
			if (!this._isOpen)
			{
				__Error.WriterClosed();
			}
			this._sb.Append(value);
		}

		/// <summary>Записывает в поток дочерний массив символов.</summary>
		/// <param name="buffer">Массив символов, из которого записываются данные.</param>
		/// <param name="index">Позиция в буфере, с которой начинается чтение данных.</param>
		/// <param name="count">Наибольшее количество символов для записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ArgumentException">(<paramref name="index" /> + <paramref name="count" />)&gt; <paramref name="buffer" />. <see langword="Length" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Модуль записи закрыт.</exception>
		// Token: 0x06006951 RID: 26961 RVA: 0x00167F00 File Offset: 0x00166100
		public override void Write(char[] buffer, int index, int count)
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
			if (!this._isOpen)
			{
				__Error.WriterClosed();
			}
			this._sb.Append(buffer, index, count);
		}

		/// <summary>Записывает строку в текущую строку.</summary>
		/// <param name="value">Строка для записи.</param>
		/// <exception cref="T:System.ObjectDisposedException">Модуль записи закрыт.</exception>
		// Token: 0x06006952 RID: 26962 RVA: 0x00167F8B File Offset: 0x0016618B
		public override void Write(string value)
		{
			if (!this._isOpen)
			{
				__Error.WriterClosed();
			}
			if (value != null)
			{
				this._sb.Append(value);
			}
		}

		/// <summary>Асинхронно записывает символ в строку.</summary>
		/// <param name="value">Символ, записываемый в строку.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Модуль записи строк удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль записи строк сейчас используется предыдущей операцией записи.</exception>
		// Token: 0x06006953 RID: 26963 RVA: 0x0015D6B4 File Offset: 0x0015B8B4
		[ComVisible(false)]
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override Task WriteAsync(char value)
		{
			this.Write(value);
			return Task.CompletedTask;
		}

		/// <summary>Асинхронно записывает строку в текущую строку.</summary>
		/// <param name="value">Строка для записи. Если параметр <paramref name="value" /> имеет значение <see langword="null" />, в текстовый поток ничего не записывается.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Модуль записи строк удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль записи строк сейчас используется предыдущей операцией записи.</exception>
		// Token: 0x06006954 RID: 26964 RVA: 0x0015D6C2 File Offset: 0x0015B8C2
		[ComVisible(false)]
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override Task WriteAsync(string value)
		{
			this.Write(value);
			return Task.CompletedTask;
		}

		/// <summary>Асинхронно записывает подмассив символов в строку.</summary>
		/// <param name="buffer">Массив символов, из которого записываются данные.</param>
		/// <param name="index">Позиция в буфере, с которой начинается чтение данных.</param>
		/// <param name="count">Наибольшее количество символов для записи.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма значений параметров <paramref name="index" /> и <paramref name="count" /> превышает длину буфера.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Модуль записи строк удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль записи строк сейчас используется предыдущей операцией записи.</exception>
		// Token: 0x06006955 RID: 26965 RVA: 0x0015D6D0 File Offset: 0x0015B8D0
		[ComVisible(false)]
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override Task WriteAsync(char[] buffer, int index, int count)
		{
			this.Write(buffer, index, count);
			return Task.CompletedTask;
		}

		/// <summary>Асинхронно записывает в строку символ, за которым следует знак завершения строки.</summary>
		/// <param name="value">Символ, записываемый в строку.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Модуль записи строк удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль записи строк сейчас используется предыдущей операцией записи.</exception>
		// Token: 0x06006956 RID: 26966 RVA: 0x0015D6E0 File Offset: 0x0015B8E0
		[ComVisible(false)]
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override Task WriteLineAsync(char value)
		{
			this.WriteLine(value);
			return Task.CompletedTask;
		}

		/// <summary>Асинхронно записывает в текущую строку строку, за которой следует символ завершения строки.</summary>
		/// <param name="value">Строка для записи. Если значение равно <see langword="null" />, записывается только знак конца строки.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Модуль записи строк удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль записи строк сейчас используется предыдущей операцией записи.</exception>
		// Token: 0x06006957 RID: 26967 RVA: 0x0015D6EE File Offset: 0x0015B8EE
		[ComVisible(false)]
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override Task WriteLineAsync(string value)
		{
			this.WriteLine(value);
			return Task.CompletedTask;
		}

		/// <summary>Асинхронно записывает в строку подмассив символов, за которым следует символ конца строки.</summary>
		/// <param name="buffer">Массив символов, из которого записываются данные.</param>
		/// <param name="index">Позиция в буфере, с которой начинается чтение данных.</param>
		/// <param name="count">Наибольшее количество символов для записи.</param>
		/// <returns>Задача, представляющая асинхронную операцию записи.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Сумма значений параметров <paramref name="index" /> и <paramref name="count" /> превышает длину буфера.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> или <paramref name="count" /> является отрицательным значением.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Модуль записи строк удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Модуль записи строк сейчас используется предыдущей операцией записи.</exception>
		// Token: 0x06006958 RID: 26968 RVA: 0x0015D6FC File Offset: 0x0015B8FC
		[ComVisible(false)]
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override Task WriteLineAsync(char[] buffer, int index, int count)
		{
			this.WriteLine(buffer, index, count);
			return Task.CompletedTask;
		}

		/// <summary>Асинхронно очищает все буферы текущего средства записи и вызывает запись всех буферизованных данных в базовое устройство.</summary>
		/// <returns>Задача, представляющая асинхронную операцию очистки.</returns>
		// Token: 0x06006959 RID: 26969 RVA: 0x0007885A File Offset: 0x00076A5A
		[ComVisible(false)]
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override Task FlushAsync()
		{
			return Task.CompletedTask;
		}

		/// <summary>Возвращает строку, содержащую символы, записанные в текущий <see langword="StringWriter" /> к текущему моменту.</summary>
		/// <returns>Строка, содержащая символы, записанные в текущий <see langword="StringWriter" />.</returns>
		// Token: 0x0600695A RID: 26970 RVA: 0x00167FAA File Offset: 0x001661AA
		public override string ToString()
		{
			return this._sb.ToString();
		}

		// Token: 0x04003D27 RID: 15655
		private static volatile UnicodeEncoding m_encoding;

		// Token: 0x04003D28 RID: 15656
		private StringBuilder _sb;

		// Token: 0x04003D29 RID: 15657
		private bool _isOpen;
	}
}
