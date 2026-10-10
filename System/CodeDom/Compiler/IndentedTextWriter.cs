using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace System.CodeDom.Compiler
{
	/// <summary>Предоставляет модуль записи текста, позволяющий делать отступ новой строки с помощью строкового маркера табуляции.</summary>
	// Token: 0x02000355 RID: 853
	public class IndentedTextWriter : TextWriter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.IndentedTextWriter" />, используя указанный модуль записи текста и строку табуляции по умолчанию.</summary>
		/// <param name="writer">Объект <see cref="T:System.IO.TextWriter" />, предназначенный для вывода данных.</param>
		// Token: 0x06001C1F RID: 7199 RVA: 0x0006695C File Offset: 0x00064B5C
		public IndentedTextWriter(TextWriter writer) : this(writer, "    ")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.IndentedTextWriter" />, используя указанный модуль записи текста и строку табуляции.</summary>
		/// <param name="writer">Объект <see cref="T:System.IO.TextWriter" />, предназначенный для вывода данных.</param>
		/// <param name="tabString">Используемая для отступа строка табуляции.</param>
		// Token: 0x06001C20 RID: 7200 RVA: 0x0006696A File Offset: 0x00064B6A
		public IndentedTextWriter(TextWriter writer, string tabString) : base(CultureInfo.InvariantCulture)
		{
			this._writer = writer;
			this._tabString = tabString;
			this._indentLevel = 0;
			this._tabsPending = false;
		}

		/// <summary>Получает кодировку для использования модулем записи текста.</summary>
		/// <returns>Объект <see cref="T:System.Text.Encoding" /> задает кодировку для использования модулем записи текста.</returns>
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x00066993 File Offset: 0x00064B93
		public override Encoding Encoding
		{
			get
			{
				return this._writer.Encoding;
			}
		}

		/// <summary>Получает или задает знак новой строки для использования.</summary>
		/// <returns>Знак новой строки для использования.</returns>
		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x000669A0 File Offset: 0x00064BA0
		// (set) Token: 0x06001C23 RID: 7203 RVA: 0x000669AD File Offset: 0x00064BAD
		public override string NewLine
		{
			get
			{
				return this._writer.NewLine;
			}
			set
			{
				this._writer.NewLine = value;
			}
		}

		/// <summary>Получает или задает количество пробелов для отступа.</summary>
		/// <returns>Количество пробелов для отступа.</returns>
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x000669BB File Offset: 0x00064BBB
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x000669C3 File Offset: 0x00064BC3
		public int Indent
		{
			get
			{
				return this._indentLevel;
			}
			set
			{
				this._indentLevel = Math.Max(value, 0);
			}
		}

		/// <summary>Получает <see cref="T:System.IO.TextWriter" /> для использования.</summary>
		/// <returns>Используемый <see cref="T:System.IO.TextWriter" />.</returns>
		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x000669D2 File Offset: 0x00064BD2
		public TextWriter InnerWriter
		{
			get
			{
				return this._writer;
			}
		}

		/// <summary>Закрывает документ, в который производилась запись.</summary>
		// Token: 0x06001C27 RID: 7207 RVA: 0x000669DA File Offset: 0x00064BDA
		public override void Close()
		{
			this._writer.Close();
		}

		/// <summary>Сбрасывает поток.</summary>
		// Token: 0x06001C28 RID: 7208 RVA: 0x000669E7 File Offset: 0x00064BE7
		public override void Flush()
		{
			this._writer.Flush();
		}

		/// <summary>Выводит строку табуляции один раз для каждого уровня отступа в соответствии со свойством <see cref="P:System.CodeDom.Compiler.IndentedTextWriter.Indent" />.</summary>
		// Token: 0x06001C29 RID: 7209 RVA: 0x000669F4 File Offset: 0x00064BF4
		protected virtual void OutputTabs()
		{
			if (this._tabsPending)
			{
				for (int i = 0; i < this._indentLevel; i++)
				{
					this._writer.Write(this._tabString);
				}
				this._tabsPending = false;
			}
		}

		/// <summary>Записывает указанную строку в текстовый поток.</summary>
		/// <param name="s">Строка для записи.</param>
		// Token: 0x06001C2A RID: 7210 RVA: 0x00066A32 File Offset: 0x00064C32
		public override void Write(string s)
		{
			this.OutputTabs();
			this._writer.Write(s);
		}

		/// <summary>Записывает текстовое представление логического значения в текстовый поток.</summary>
		/// <param name="value">Логическое значение для записи.</param>
		// Token: 0x06001C2B RID: 7211 RVA: 0x00066A46 File Offset: 0x00064C46
		public override void Write(bool value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		/// <summary>Записывает символ в текстовый поток.</summary>
		/// <param name="value">Записываемый символ.</param>
		// Token: 0x06001C2C RID: 7212 RVA: 0x00066A5A File Offset: 0x00064C5A
		public override void Write(char value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		/// <summary>Записывает массив символов в текстовый поток.</summary>
		/// <param name="buffer">Записываемый массив символов.</param>
		// Token: 0x06001C2D RID: 7213 RVA: 0x00066A6E File Offset: 0x00064C6E
		public override void Write(char[] buffer)
		{
			this.OutputTabs();
			this._writer.Write(buffer);
		}

		/// <summary>Записывает подмассив символов в текстовый поток.</summary>
		/// <param name="buffer">Массив символов, из которого записываются данные.</param>
		/// <param name="index">Начальный индекс в буфере.</param>
		/// <param name="count">Количество символов для записи.</param>
		// Token: 0x06001C2E RID: 7214 RVA: 0x00066A82 File Offset: 0x00064C82
		public override void Write(char[] buffer, int index, int count)
		{
			this.OutputTabs();
			this._writer.Write(buffer, index, count);
		}

		/// <summary>Записывает текстовое представление значения типа Double в текстовый поток.</summary>
		/// <param name="value">Документ <see langword="double" /> для записи.</param>
		// Token: 0x06001C2F RID: 7215 RVA: 0x00066A98 File Offset: 0x00064C98
		public override void Write(double value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		/// <summary>Записывает текстовое представление значения типа Single в текстовый поток.</summary>
		/// <param name="value">Документ <see langword="single" /> для записи.</param>
		// Token: 0x06001C30 RID: 7216 RVA: 0x00066AAC File Offset: 0x00064CAC
		public override void Write(float value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		/// <summary>Записывает текстовое представление целого числа в текстовый поток.</summary>
		/// <param name="value">Целое число для записи.</param>
		// Token: 0x06001C31 RID: 7217 RVA: 0x00066AC0 File Offset: 0x00064CC0
		public override void Write(int value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		/// <summary>Записывает текстовое представление целого числа размером 8 байт в текстовый поток.</summary>
		/// <param name="value">Целое число размером 8 байт для записи.</param>
		// Token: 0x06001C32 RID: 7218 RVA: 0x00066AD4 File Offset: 0x00064CD4
		public override void Write(long value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		/// <summary>Записывает текстовое представление объекта в текстовый поток.</summary>
		/// <param name="value">Записываемый объект.</param>
		// Token: 0x06001C33 RID: 7219 RVA: 0x00066AE8 File Offset: 0x00064CE8
		public override void Write(object value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		/// <summary>Выводит отформатированную строку, используя заданную семантику.</summary>
		/// <param name="format">Строка форматирования.</param>
		/// <param name="arg0">Объект для записи в отформатированную строку.</param>
		// Token: 0x06001C34 RID: 7220 RVA: 0x00066AFC File Offset: 0x00064CFC
		public override void Write(string format, object arg0)
		{
			this.OutputTabs();
			this._writer.Write(format, arg0);
		}

		/// <summary>Выводит отформатированную строку, используя заданную семантику.</summary>
		/// <param name="format">Строка форматирования для использования.</param>
		/// <param name="arg0">Первый объект для записи в форматируемую строку.</param>
		/// <param name="arg1">Второй объект для записи в форматируемую строку.</param>
		// Token: 0x06001C35 RID: 7221 RVA: 0x00066B11 File Offset: 0x00064D11
		public override void Write(string format, object arg0, object arg1)
		{
			this.OutputTabs();
			this._writer.Write(format, arg0, arg1);
		}

		/// <summary>Выводит отформатированную строку, используя заданную семантику.</summary>
		/// <param name="format">Строка форматирования для использования.</param>
		/// <param name="arg">Массив аргументов для вывода.</param>
		// Token: 0x06001C36 RID: 7222 RVA: 0x00066B27 File Offset: 0x00064D27
		public override void Write(string format, params object[] arg)
		{
			this.OutputTabs();
			this._writer.Write(format, arg);
		}

		/// <summary>Записывает указанное строковое значение в строку без табуляций.</summary>
		/// <param name="s">Строка для записи.</param>
		// Token: 0x06001C37 RID: 7223 RVA: 0x00066B3C File Offset: 0x00064D3C
		public void WriteLineNoTabs(string s)
		{
			this._writer.WriteLine(s);
		}

		/// <summary>Записывает в текстовый поток указанную строку, за которой следует признак конца строки.</summary>
		/// <param name="s">Строка для записи.</param>
		// Token: 0x06001C38 RID: 7224 RVA: 0x00066B4A File Offset: 0x00064D4A
		public override void WriteLine(string s)
		{
			this.OutputTabs();
			this._writer.WriteLine(s);
			this._tabsPending = true;
		}

		/// <summary>Записывает признак конца строки.</summary>
		// Token: 0x06001C39 RID: 7225 RVA: 0x00066B65 File Offset: 0x00064D65
		public override void WriteLine()
		{
			this.OutputTabs();
			this._writer.WriteLine();
			this._tabsPending = true;
		}

		/// <summary>Записывает текстовое представление логического значения, за которым следует признак конца строки, в текстовый поток.</summary>
		/// <param name="value">Логическое значение для записи.</param>
		// Token: 0x06001C3A RID: 7226 RVA: 0x00066B7F File Offset: 0x00064D7F
		public override void WriteLine(bool value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		/// <summary>Записывает в текстовый поток символ, за которым следует признак конца строки.</summary>
		/// <param name="value">Записываемый символ.</param>
		// Token: 0x06001C3B RID: 7227 RVA: 0x00066B9A File Offset: 0x00064D9A
		public override void WriteLine(char value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		/// <summary>Записывает в текстовый поток массив символов, за которым следует признак конца строки.</summary>
		/// <param name="buffer">Записываемый массив символов.</param>
		// Token: 0x06001C3C RID: 7228 RVA: 0x00066BB5 File Offset: 0x00064DB5
		public override void WriteLine(char[] buffer)
		{
			this.OutputTabs();
			this._writer.WriteLine(buffer);
			this._tabsPending = true;
		}

		/// <summary>Записывает в текстовый поток подмассив символов, за которым следует признак конца строки.</summary>
		/// <param name="buffer">Массив символов, из которого записываются данные.</param>
		/// <param name="index">Начальный индекс в буфере.</param>
		/// <param name="count">Количество символов для записи.</param>
		// Token: 0x06001C3D RID: 7229 RVA: 0x00066BD0 File Offset: 0x00064DD0
		public override void WriteLine(char[] buffer, int index, int count)
		{
			this.OutputTabs();
			this._writer.WriteLine(buffer, index, count);
			this._tabsPending = true;
		}

		/// <summary>Записывает в текстовый поток текстовое представление значения типа Double, за которым следует признак конца строки.</summary>
		/// <param name="value">Документ <see langword="double" /> для записи.</param>
		// Token: 0x06001C3E RID: 7230 RVA: 0x00066BED File Offset: 0x00064DED
		public override void WriteLine(double value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		/// <summary>Записывает в текстовый поток текстовое представление значения типа Single, за которым следует признак конца строки.</summary>
		/// <param name="value">Документ <see langword="single" /> для записи.</param>
		// Token: 0x06001C3F RID: 7231 RVA: 0x00066C08 File Offset: 0x00064E08
		public override void WriteLine(float value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		/// <summary>Записывает в текстовый поток текстовое представление целого числа, за которым следует признак конца строки.</summary>
		/// <param name="value">Целое число для записи.</param>
		// Token: 0x06001C40 RID: 7232 RVA: 0x00066C23 File Offset: 0x00064E23
		public override void WriteLine(int value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		/// <summary>Записывает в текстовый поток текстовое представление целого числа размером 8 байт, за которым следует признак конца строки.</summary>
		/// <param name="value">Целое число размером 8 байт для записи.</param>
		// Token: 0x06001C41 RID: 7233 RVA: 0x00066C3E File Offset: 0x00064E3E
		public override void WriteLine(long value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		/// <summary>Записывает в текстовый поток текстовое представление объекта, за которым следует признак конца строки.</summary>
		/// <param name="value">Записываемый объект.</param>
		// Token: 0x06001C42 RID: 7234 RVA: 0x00066C59 File Offset: 0x00064E59
		public override void WriteLine(object value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		/// <summary>Выводит отформатированную строку, за которой следует знак конца строки, используя заданную семантику.</summary>
		/// <param name="format">Строка форматирования.</param>
		/// <param name="arg0">Объект для записи в отформатированную строку.</param>
		// Token: 0x06001C43 RID: 7235 RVA: 0x00066C74 File Offset: 0x00064E74
		public override void WriteLine(string format, object arg0)
		{
			this.OutputTabs();
			this._writer.WriteLine(format, arg0);
			this._tabsPending = true;
		}

		/// <summary>Выводит отформатированную строку, за которой следует знак конца строки, используя заданную семантику.</summary>
		/// <param name="format">Строка форматирования для использования.</param>
		/// <param name="arg0">Первый объект для записи в форматируемую строку.</param>
		/// <param name="arg1">Второй объект для записи в форматируемую строку.</param>
		// Token: 0x06001C44 RID: 7236 RVA: 0x00066C90 File Offset: 0x00064E90
		public override void WriteLine(string format, object arg0, object arg1)
		{
			this.OutputTabs();
			this._writer.WriteLine(format, arg0, arg1);
			this._tabsPending = true;
		}

		/// <summary>Выводит отформатированную строку, за которой следует знак конца строки, используя заданную семантику.</summary>
		/// <param name="format">Строка форматирования для использования.</param>
		/// <param name="arg">Массив аргументов для вывода.</param>
		// Token: 0x06001C45 RID: 7237 RVA: 0x00066CAD File Offset: 0x00064EAD
		public override void WriteLine(string format, params object[] arg)
		{
			this.OutputTabs();
			this._writer.WriteLine(format, arg);
			this._tabsPending = true;
		}

		/// <summary>Записывает в текстовый поток текстовое представление значения типа UInt32, за которым следует знак конца строки.</summary>
		/// <param name="value">Значение типа UInt32 для вывода.</param>
		// Token: 0x06001C46 RID: 7238 RVA: 0x00066CC9 File Offset: 0x00064EC9
		[CLSCompliant(false)]
		public override void WriteLine(uint value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x04000E6E RID: 3694
		private readonly TextWriter _writer;

		// Token: 0x04000E6F RID: 3695
		private readonly string _tabString;

		// Token: 0x04000E70 RID: 3696
		private int _indentLevel;

		// Token: 0x04000E71 RID: 3697
		private bool _tabsPending;

		/// <summary>Указывает строку табуляции по умолчанию. Это поле является константой.</summary>
		// Token: 0x04000E72 RID: 3698
		public const string DefaultTabString = "    ";
	}
}
