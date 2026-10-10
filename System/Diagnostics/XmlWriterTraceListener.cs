using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Security.Permissions;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace System.Diagnostics
{
	/// <summary>Направляет выходные данные отладки или трассировки в виде закодированных XML-данных в <see cref="T:System.IO.TextWriter" /> или в <see cref="T:System.IO.Stream" />, например, <see cref="T:System.IO.FileStream" />.</summary>
	// Token: 0x02000238 RID: 568
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	public class XmlWriterTraceListener : TextWriterTraceListener
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.XmlWriterTraceListener" />, используя указанный поток в качестве получателя выходных данных отладки и трассировки.</summary>
		/// <param name="stream">Объект <see cref="T:System.IO.Stream" />, представляющий поток, в который записывает прослушиватель трассировки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600110F RID: 4367 RVA: 0x0004A8FC File Offset: 0x00048AFC
		public XmlWriterTraceListener(Stream stream) : base(stream)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> с заданным именем, используя указанный поток в качестве получателя выходных данных отладки и трассировки.</summary>
		/// <param name="stream">Объект <see cref="T:System.IO.Stream" />, представляющий поток, в который записывает прослушиватель трассировки.</param>
		/// <param name="name">Имя нового экземпляра.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001110 RID: 4368 RVA: 0x0004A910 File Offset: 0x00048B10
		public XmlWriterTraceListener(Stream stream, string name) : base(stream, name)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.XmlWriterTraceListener" />, используя указанный объект записи в качестве получателя выходных данных отладки и трассировки.</summary>
		/// <param name="writer">Поток <see cref="T:System.IO.TextWriter" />, принимающий выходные данные из прослушивателя трассировки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="writer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001111 RID: 4369 RVA: 0x0004A925 File Offset: 0x00048B25
		public XmlWriterTraceListener(TextWriter writer) : base(writer)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> с заданным именем, используя указанный объект записи в качестве получателя выходных данных отладки и трассировки.</summary>
		/// <param name="writer">Поток <see cref="T:System.IO.TextWriter" />, принимающий выходные данные из прослушивателя трассировки.</param>
		/// <param name="name">Имя нового экземпляра.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="writer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001112 RID: 4370 RVA: 0x0004A939 File Offset: 0x00048B39
		public XmlWriterTraceListener(TextWriter writer, string name) : base(writer, name)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.XmlWriterTraceListener" />, используя указанный файл в качестве получателя выходных данных отладки и трассировки.</summary>
		/// <param name="filename">Имя файла для записи.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="filename" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001113 RID: 4371 RVA: 0x0004A94E File Offset: 0x00048B4E
		public XmlWriterTraceListener(string filename) : base(filename)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.XmlWriterTraceListener" /> с заданным именем, используя указанный файл в качестве получателя выходных данных отладки и трассировки.</summary>
		/// <param name="filename">Имя файла для записи.</param>
		/// <param name="name">Имя нового экземпляра.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001114 RID: 4372 RVA: 0x0004A962 File Offset: 0x00048B62
		public XmlWriterTraceListener(string filename, string name) : base(filename, name)
		{
		}

		/// <summary>Дословно записывает сообщение без какой-либо дополнительной контекстной информации в файл или поток.</summary>
		/// <param name="message">Сообщение для записи.</param>
		// Token: 0x06001115 RID: 4373 RVA: 0x0004A977 File Offset: 0x00048B77
		public override void Write(string message)
		{
			this.WriteLine(message);
		}

		/// <summary>Дословно записывает сообщение без какой-либо дополнительной контекстной информации, за которым следует знак окончания текущей строки в файл или поток.</summary>
		/// <param name="message">Сообщение для записи.</param>
		// Token: 0x06001116 RID: 4374 RVA: 0x0004A980 File Offset: 0x00048B80
		public override void WriteLine(string message)
		{
			this.TraceEvent(null, SR.GetString("Trace"), TraceEventType.Information, 0, message);
		}

		/// <summary>Записывает сведения трассировки, включая сообщение об ошибке и подробное сообщение об ошибке в файл или поток.</summary>
		/// <param name="message">Сообщение об ошибке для записи.</param>
		/// <param name="detailMessage">Подробное сообщение об ошибке для добавления к сообщению об ошибке.</param>
		// Token: 0x06001117 RID: 4375 RVA: 0x0004A998 File Offset: 0x00048B98
		public override void Fail(string message, string detailMessage)
		{
			StringBuilder stringBuilder = new StringBuilder(message);
			if (detailMessage != null)
			{
				stringBuilder.Append(" ");
				stringBuilder.Append(detailMessage);
			}
			this.TraceEvent(null, SR.GetString("Trace"), TraceEventType.Error, 0, stringBuilder.ToString());
		}

		/// <summary>Записывает сведения трассировки, форматированное сообщение и сведения о событии в файл или поток.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий идентификаторы текущего процесса и потока, а также информацию трассировки стека.</param>
		/// <param name="source">Имя источника.</param>
		/// <param name="eventType">Одно из значений перечисления <see cref="T:System.Diagnostics.TraceEventType" />.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="format">Строка форматирования, содержащая 0 или больше элементов форматирования, соответствующих объектам в массиве <paramref name="args" />.</param>
		/// <param name="args">Массив объектов, содержащий один или несколько (либо ни одного) объектов, которые необходимо отформатировать.</param>
		// Token: 0x06001118 RID: 4376 RVA: 0x0004A9DC File Offset: 0x00048BDC
		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, format, args))
			{
				return;
			}
			this.WriteHeader(source, eventType, id, eventCache);
			string str;
			if (args != null)
			{
				str = string.Format(CultureInfo.InvariantCulture, format, args);
			}
			else
			{
				str = format;
			}
			this.WriteEscaped(str);
			this.WriteFooter(eventCache);
		}

		/// <summary>Записывает сведения трассировки, сообщение и сведения о событии в файл или поток.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий идентификаторы текущего процесса и потока, а также информацию трассировки стека.</param>
		/// <param name="source">Имя источника.</param>
		/// <param name="eventType">Одно из значений перечисления <see cref="T:System.Diagnostics.TraceEventType" />.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="message">Сообщение для записи.</param>
		// Token: 0x06001119 RID: 4377 RVA: 0x0004AA39 File Offset: 0x00048C39
		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, message))
			{
				return;
			}
			this.WriteHeader(source, eventType, id, eventCache);
			this.WriteEscaped(message);
			this.WriteFooter(eventCache);
		}

		/// <summary>Записывает сведения трассировки, объект данных и сведения о событии в файл или поток.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий идентификаторы текущего процесса и потока, а также информацию трассировки стека.</param>
		/// <param name="source">Имя источника.</param>
		/// <param name="eventType">Одно из значений перечисления <see cref="T:System.Diagnostics.TraceEventType" />.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="data">Порождаемый объект данных.</param>
		// Token: 0x0600111A RID: 4378 RVA: 0x0004AA74 File Offset: 0x00048C74
		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, data))
			{
				return;
			}
			this.WriteHeader(source, eventType, id, eventCache);
			this.InternalWrite("<TraceData>");
			if (data != null)
			{
				this.InternalWrite("<DataItem>");
				this.WriteData(data);
				this.InternalWrite("</DataItem>");
			}
			this.InternalWrite("</TraceData>");
			this.WriteFooter(eventCache);
		}

		/// <summary>Записывает сведения трассировки, объекты данных и сведения о событии в файл или поток.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий идентификаторы текущего процесса и потока, а также информацию трассировки стека.</param>
		/// <param name="source">Имя источника.</param>
		/// <param name="eventType">Одно из значений перечисления <see cref="T:System.Diagnostics.TraceEventType" />.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="data">Порождаемый массив объектов данных.</param>
		// Token: 0x0600111B RID: 4379 RVA: 0x0004AAEC File Offset: 0x00048CEC
		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, null, data))
			{
				return;
			}
			this.WriteHeader(source, eventType, id, eventCache);
			this.InternalWrite("<TraceData>");
			if (data != null)
			{
				for (int i = 0; i < data.Length; i++)
				{
					this.InternalWrite("<DataItem>");
					if (data[i] != null)
					{
						this.WriteData(data[i]);
					}
					this.InternalWrite("</DataItem>");
				}
			}
			this.InternalWrite("</TraceData>");
			this.WriteFooter(eventCache);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0004AB7C File Offset: 0x00048D7C
		private void WriteData(object data)
		{
			XPathNavigator xpathNavigator = data as XPathNavigator;
			if (xpathNavigator == null)
			{
				this.WriteEscaped(data.ToString());
				return;
			}
			if (this.strBldr == null)
			{
				this.strBldr = new StringBuilder();
				this.xmlBlobWriter = new XmlTextWriter(new StringWriter(this.strBldr, CultureInfo.CurrentCulture));
			}
			else
			{
				this.strBldr.Length = 0;
			}
			try
			{
				xpathNavigator.MoveToRoot();
				this.xmlBlobWriter.WriteNode(xpathNavigator, false);
				this.InternalWrite(this.strBldr.ToString());
			}
			catch (Exception)
			{
				this.InternalWrite(data.ToString());
			}
		}

		/// <summary>Закрывает свойство <see cref="P:System.Diagnostics.TextWriterTraceListener.Writer" /> этого прослушивателя, которое, таким образом, больше не получает выходные данные отладки или трассировки.</summary>
		// Token: 0x0600111D RID: 4381 RVA: 0x0004AC24 File Offset: 0x00048E24
		public override void Close()
		{
			base.Close();
			if (this.xmlBlobWriter != null)
			{
				this.xmlBlobWriter.Close();
			}
			this.xmlBlobWriter = null;
			this.strBldr = null;
		}

		/// <summary>Записывает сведения трассировки, включая идентификацию сопутствующей активности, сообщение и сведения о событии в файл или поток.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий идентификаторы текущего процесса и потока, а также информацию трассировки стека.</param>
		/// <param name="source">Имя источника.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="message">Сообщение трассировки для записи.</param>
		/// <param name="relatedActivityId">Структура <see cref="T:System.Guid" />, идентифицирующая связанное действие.</param>
		// Token: 0x0600111E RID: 4382 RVA: 0x0004AC50 File Offset: 0x00048E50
		public override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
		{
			if (this.shouldRespectFilterOnTraceTransfer && base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, TraceEventType.Transfer, id, message))
			{
				return;
			}
			this.WriteHeader(source, TraceEventType.Transfer, id, eventCache, relatedActivityId);
			this.WriteEscaped(message);
			this.WriteFooter(eventCache);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0004ACA4 File Offset: 0x00048EA4
		private void WriteHeader(string source, TraceEventType eventType, int id, TraceEventCache eventCache, Guid relatedActivityId)
		{
			this.WriteStartHeader(source, eventType, id, eventCache);
			this.InternalWrite("\" RelatedActivityID=\"");
			this.InternalWrite(relatedActivityId.ToString("B"));
			this.WriteEndHeader(eventCache);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0004ACD6 File Offset: 0x00048ED6
		private void WriteHeader(string source, TraceEventType eventType, int id, TraceEventCache eventCache)
		{
			this.WriteStartHeader(source, eventType, id, eventCache);
			this.WriteEndHeader(eventCache);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0004ACEC File Offset: 0x00048EEC
		private void WriteStartHeader(string source, TraceEventType eventType, int id, TraceEventCache eventCache)
		{
			this.InternalWrite("<E2ETraceEvent xmlns=\"http://schemas.microsoft.com/2004/06/E2ETraceEvent\"><System xmlns=\"http://schemas.microsoft.com/2004/06/windows/eventlog/system\">");
			this.InternalWrite("<EventID>");
			uint num = (uint)id;
			this.InternalWrite(num.ToString(CultureInfo.InvariantCulture));
			this.InternalWrite("</EventID>");
			this.InternalWrite("<Type>3</Type>");
			this.InternalWrite("<SubType Name=\"");
			this.InternalWrite(eventType.ToString());
			this.InternalWrite("\">0</SubType>");
			this.InternalWrite("<Level>");
			int num2 = (int)eventType;
			if (num2 > 255)
			{
				num2 = 255;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			this.InternalWrite(num2.ToString(CultureInfo.InvariantCulture));
			this.InternalWrite("</Level>");
			this.InternalWrite("<TimeCreated SystemTime=\"");
			if (eventCache != null)
			{
				this.InternalWrite(eventCache.DateTime.ToString("o", CultureInfo.InvariantCulture));
			}
			else
			{
				this.InternalWrite(DateTime.Now.ToString("o", CultureInfo.InvariantCulture));
			}
			this.InternalWrite("\" />");
			this.InternalWrite("<Source Name=\"");
			this.WriteEscaped(source);
			this.InternalWrite("\" />");
			this.InternalWrite("<Correlation ActivityID=\"");
			if (eventCache != null)
			{
				this.InternalWrite(eventCache.ActivityId.ToString("B"));
				return;
			}
			this.InternalWrite(Guid.Empty.ToString("B"));
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0004AE58 File Offset: 0x00049058
		private void WriteEndHeader(TraceEventCache eventCache)
		{
			this.InternalWrite("\" />");
			this.InternalWrite("<Execution ProcessName=\"");
			this.InternalWrite(TraceEventCache.GetProcessName());
			this.InternalWrite("\" ProcessID=\"");
			this.InternalWrite(((uint)TraceEventCache.GetProcessId()).ToString(CultureInfo.InvariantCulture));
			this.InternalWrite("\" ThreadID=\"");
			if (eventCache != null)
			{
				this.WriteEscaped(eventCache.ThreadId.ToString(CultureInfo.InvariantCulture));
			}
			else
			{
				this.WriteEscaped(TraceEventCache.GetThreadId().ToString(CultureInfo.InvariantCulture));
			}
			this.InternalWrite("\" />");
			this.InternalWrite("<Channel/>");
			this.InternalWrite("<Computer>");
			this.InternalWrite(this.machineName);
			this.InternalWrite("</Computer>");
			this.InternalWrite("</System>");
			this.InternalWrite("<ApplicationData>");
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0004AF38 File Offset: 0x00049138
		private void WriteFooter(TraceEventCache eventCache)
		{
			bool flag = base.IsEnabled(TraceOptions.LogicalOperationStack);
			bool flag2 = base.IsEnabled(TraceOptions.Callstack);
			if (eventCache != null && (flag || flag2))
			{
				this.InternalWrite("<System.Diagnostics xmlns=\"http://schemas.microsoft.com/2004/08/System.Diagnostics\">");
				if (flag)
				{
					this.InternalWrite("<LogicalOperationStack>");
					Stack logicalOperationStack = eventCache.LogicalOperationStack;
					if (logicalOperationStack != null)
					{
						foreach (object obj in logicalOperationStack)
						{
							this.InternalWrite("<LogicalOperation>");
							this.WriteEscaped(obj.ToString());
							this.InternalWrite("</LogicalOperation>");
						}
					}
					this.InternalWrite("</LogicalOperationStack>");
				}
				this.InternalWrite("<Timestamp>");
				this.InternalWrite(eventCache.Timestamp.ToString(CultureInfo.InvariantCulture));
				this.InternalWrite("</Timestamp>");
				if (flag2)
				{
					this.InternalWrite("<Callstack>");
					this.WriteEscaped(eventCache.Callstack);
					this.InternalWrite("</Callstack>");
				}
				this.InternalWrite("</System.Diagnostics>");
			}
			this.InternalWrite("</ApplicationData></E2ETraceEvent>");
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0004B060 File Offset: 0x00049260
		private void WriteEscaped(string str)
		{
			if (str == null)
			{
				return;
			}
			int num = 0;
			for (int i = 0; i < str.Length; i++)
			{
				char c = str[i];
				if (c <= '"')
				{
					if (c != '\n')
					{
						if (c != '\r')
						{
							if (c == '"')
							{
								this.InternalWrite(str.Substring(num, i - num));
								this.InternalWrite("&quot;");
								num = i + 1;
							}
						}
						else
						{
							this.InternalWrite(str.Substring(num, i - num));
							this.InternalWrite("&#xD;");
							num = i + 1;
						}
					}
					else
					{
						this.InternalWrite(str.Substring(num, i - num));
						this.InternalWrite("&#xA;");
						num = i + 1;
					}
				}
				else if (c <= '\'')
				{
					if (c != '&')
					{
						if (c == '\'')
						{
							this.InternalWrite(str.Substring(num, i - num));
							this.InternalWrite("&apos;");
							num = i + 1;
						}
					}
					else
					{
						this.InternalWrite(str.Substring(num, i - num));
						this.InternalWrite("&amp;");
						num = i + 1;
					}
				}
				else if (c != '<')
				{
					if (c == '>')
					{
						this.InternalWrite(str.Substring(num, i - num));
						this.InternalWrite("&gt;");
						num = i + 1;
					}
				}
				else
				{
					this.InternalWrite(str.Substring(num, i - num));
					this.InternalWrite("&lt;");
					num = i + 1;
				}
			}
			this.InternalWrite(str.Substring(num, str.Length - num));
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0004B1DD File Offset: 0x000493DD
		private void InternalWrite(string message)
		{
			if (!base.EnsureWriter())
			{
				return;
			}
			this.writer.Write(message);
		}

		// Token: 0x04000A16 RID: 2582
		private const string fixedHeader = "<E2ETraceEvent xmlns=\"http://schemas.microsoft.com/2004/06/E2ETraceEvent\"><System xmlns=\"http://schemas.microsoft.com/2004/06/windows/eventlog/system\">";

		// Token: 0x04000A17 RID: 2583
		private readonly string machineName = Environment.MachineName;

		// Token: 0x04000A18 RID: 2584
		private StringBuilder strBldr;

		// Token: 0x04000A19 RID: 2585
		private XmlTextWriter xmlBlobWriter;

		// Token: 0x04000A1A RID: 2586
		internal bool shouldRespectFilterOnTraceTransfer;
	}
}
