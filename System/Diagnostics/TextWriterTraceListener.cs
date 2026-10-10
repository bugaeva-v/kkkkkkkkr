using System;
using System.IO;
using System.Security.Permissions;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Направляет вывод отладки или трассировки в <see cref="T:System.IO.TextWriter" /> или в <see cref="T:System.IO.Stream" />, например, <see cref="T:System.IO.FileStream" />.</summary>
	// Token: 0x0200022A RID: 554
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	public class TextWriterTraceListener : TraceListener
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TextWriterTraceListener" /> с помощью <see cref="T:System.IO.TextWriter" /> в качестве выходного получателя.</summary>
		// Token: 0x06001021 RID: 4129 RVA: 0x00046FA4 File Offset: 0x000451A4
		public TextWriterTraceListener()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TextWriterTraceListener" />, используя этот поток в качестве получателя выходных данных отладки и трассировки.</summary>
		/// <param name="stream">Объект <see cref="T:System.IO.Stream" />, представляющий поток, в который записывает объект <see cref="T:System.Diagnostics.TextWriterTraceListener" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Поток имеет значение <see langword="null" />.</exception>
		// Token: 0x06001022 RID: 4130 RVA: 0x00046FAC File Offset: 0x000451AC
		public TextWriterTraceListener(Stream stream) : this(stream, string.Empty)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TextWriterTraceListener" /> с заданным именем, используя этот поток в качестве получателя выходных данных отладки и трассировки.</summary>
		/// <param name="stream">Объект <see cref="T:System.IO.Stream" />, представляющий поток, в который записывает объект <see cref="T:System.Diagnostics.TextWriterTraceListener" />.</param>
		/// <param name="name">Имя нового экземпляра.</param>
		/// <exception cref="T:System.ArgumentNullException">Поток имеет значение <see langword="null" />.</exception>
		// Token: 0x06001023 RID: 4131 RVA: 0x00046FBA File Offset: 0x000451BA
		public TextWriterTraceListener(Stream stream, string name) : base(name)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			this.writer = new StreamWriter(stream);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TextWriterTraceListener" />, используя заданное средство записи в качестве получателя выходных данных отладки или трассировки.</summary>
		/// <param name="writer">Поток <see cref="T:System.IO.TextWriter" />, принимающий выходные данные из объекта <see cref="T:System.Diagnostics.TextWriterTraceListener" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Модуль записи равен <see langword="null" />.</exception>
		// Token: 0x06001024 RID: 4132 RVA: 0x00046FDD File Offset: 0x000451DD
		public TextWriterTraceListener(TextWriter writer) : this(writer, string.Empty)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TextWriterTraceListener" /> с заданным именем, используя заданное средство записи в качестве получателя выходных данных отладки или трассировки.</summary>
		/// <param name="writer">Поток <see cref="T:System.IO.TextWriter" />, принимающий выходные данные из объекта <see cref="T:System.Diagnostics.TextWriterTraceListener" />.</param>
		/// <param name="name">Имя нового экземпляра.</param>
		/// <exception cref="T:System.ArgumentNullException">Модуль записи равен <see langword="null" />.</exception>
		// Token: 0x06001025 RID: 4133 RVA: 0x00046FEB File Offset: 0x000451EB
		public TextWriterTraceListener(TextWriter writer, string name) : base(name)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			this.writer = writer;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TextWriterTraceListener" />, используя этот файл в качестве получателя выходных данных отладки и трассировки.</summary>
		/// <param name="fileName">Имя файла, в который осуществляет запись объект <see cref="T:System.Diagnostics.TextWriterTraceListener" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Файл имеет значение <see langword="null" />.</exception>
		// Token: 0x06001026 RID: 4134 RVA: 0x00047009 File Offset: 0x00045209
		public TextWriterTraceListener(string fileName)
		{
			this.fileName = fileName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TextWriterTraceListener" /> с заданным именем, используя этот файл в качестве получателя выходных данных отладки и трассировки.</summary>
		/// <param name="fileName">Имя файла, в который осуществляет запись объект <see cref="T:System.Diagnostics.TextWriterTraceListener" />.</param>
		/// <param name="name">Имя нового экземпляра.</param>
		/// <exception cref="T:System.ArgumentNullException">Поток имеет значение <see langword="null" />.</exception>
		// Token: 0x06001027 RID: 4135 RVA: 0x00047018 File Offset: 0x00045218
		public TextWriterTraceListener(string fileName, string name) : base(name)
		{
			this.fileName = fileName;
		}

		/// <summary>Возвращает или задает средство записи текста, принимающее выходные данные трассировки или отладки.</summary>
		/// <returns>Поток <see cref="T:System.IO.TextWriter" />, представляющий средство записи, которое принимает выходные данные трассировки или отладки.</returns>
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00047028 File Offset: 0x00045228
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x00047037 File Offset: 0x00045237
		public TextWriter Writer
		{
			get
			{
				this.EnsureWriter();
				return this.writer;
			}
			set
			{
				this.writer = value;
			}
		}

		/// <summary>Закрывает свойство <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" />, которое, таким образом, больше не получает выходные данные отладки или трассировки.</summary>
		// Token: 0x0600102A RID: 4138 RVA: 0x00047040 File Offset: 0x00045240
		public override void Close()
		{
			if (this.writer != null)
			{
				try
				{
					this.writer.Close();
				}
				catch (ObjectDisposedException)
				{
				}
			}
			this.writer = null;
		}

		/// <summary>Удаляет этот объект <see cref="T:System.Diagnostics.TextWriterTraceListener" />.</summary>
		/// <param name="disposing">
		///   <see langword="true" /> для высвобождения управляемых ресурсов, если <see langword="false" />, <see cref="M:System.Diagnostics.TextWriterTraceListener.Dispose(System.Boolean)" /> не действует.</param>
		// Token: 0x0600102B RID: 4139 RVA: 0x0004707C File Offset: 0x0004527C
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					this.Close();
				}
				else
				{
					if (this.writer != null)
					{
						try
						{
							this.writer.Close();
						}
						catch (ObjectDisposedException)
						{
						}
					}
					this.writer = null;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		/// <summary>Очищает выходной буфер для свойства <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" />.</summary>
		// Token: 0x0600102C RID: 4140 RVA: 0x000470DC File Offset: 0x000452DC
		public override void Flush()
		{
			if (!this.EnsureWriter())
			{
				return;
			}
			try
			{
				this.writer.Flush();
			}
			catch (ObjectDisposedException)
			{
			}
		}

		/// <summary>Записывает сообщение в свойство <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" /> данного экземпляра.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x0600102D RID: 4141 RVA: 0x00047114 File Offset: 0x00045314
		public override void Write(string message)
		{
			if (!this.EnsureWriter())
			{
				return;
			}
			if (base.NeedIndent)
			{
				this.WriteIndent();
			}
			try
			{
				this.writer.Write(message);
			}
			catch (ObjectDisposedException)
			{
			}
		}

		/// <summary>Записывает сообщение в свойство <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" /> данного экземпляра, за которым следует ограничитель строки. Ограничитель строки по умолчанию — возврат каретки, за которым следует перевод строки (\r\n).</summary>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x0600102E RID: 4142 RVA: 0x0004715C File Offset: 0x0004535C
		public override void WriteLine(string message)
		{
			if (!this.EnsureWriter())
			{
				return;
			}
			if (base.NeedIndent)
			{
				this.WriteIndent();
			}
			try
			{
				this.writer.WriteLine(message);
				base.NeedIndent = true;
			}
			catch (ObjectDisposedException)
			{
			}
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000471AC File Offset: 0x000453AC
		private static Encoding GetEncodingWithFallback(Encoding encoding)
		{
			Encoding encoding2 = (Encoding)encoding.Clone();
			encoding2.EncoderFallback = EncoderFallback.ReplacementFallback;
			encoding2.DecoderFallback = DecoderFallback.ReplacementFallback;
			return encoding2;
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x000471D0 File Offset: 0x000453D0
		internal bool EnsureWriter()
		{
			bool flag = true;
			if (this.writer == null)
			{
				flag = false;
				if (this.fileName == null)
				{
					return flag;
				}
				Encoding encodingWithFallback = TextWriterTraceListener.GetEncodingWithFallback(new UTF8Encoding(false));
				string path = Path.GetFullPath(this.fileName);
				string directoryName = Path.GetDirectoryName(path);
				string text = Path.GetFileName(path);
				for (int i = 0; i < 2; i++)
				{
					try
					{
						this.writer = new StreamWriter(path, true, encodingWithFallback, 4096);
						flag = true;
						break;
					}
					catch (IOException)
					{
						text = Guid.NewGuid().ToString() + text;
						path = Path.Combine(directoryName, text);
					}
					catch (UnauthorizedAccessException)
					{
						break;
					}
					catch (Exception)
					{
						break;
					}
				}
				if (!flag)
				{
					this.fileName = null;
				}
			}
			return flag;
		}

		// Token: 0x040009D0 RID: 2512
		internal TextWriter writer;

		// Token: 0x040009D1 RID: 2513
		private string fileName;
	}
}
