using System;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Предоставляет набор методов и свойств, используемых при трассировке выполнения кода. Этот класс не наследуется.</summary>
	// Token: 0x0200022B RID: 555
	public sealed class Trace
	{
		// Token: 0x06001031 RID: 4145 RVA: 0x0000219B File Offset: 0x0000039B
		private Trace()
		{
		}

		/// <summary>Получает коллекцию прослушивателей, отслеживающую выходные данные трассировки.</summary>
		/// <returns>Объект <see cref="T:System.Diagnostics.TraceListenerCollection" />, представляющий коллекцию типа <see cref="T:System.Diagnostics.TraceListener" />, отслеживающую выходные данные трассировки.</returns>
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x00044C16 File Offset: 0x00042E16
		public static TraceListenerCollection Listeners
		{
			[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
			get
			{
				return TraceInternal.Listeners;
			}
		}

		/// <summary>Возвращает или задает вызов <see cref="M:System.Diagnostics.Trace.Flush" /> в <see cref="P:System.Diagnostics.Trace.Listeners" /> после каждой операции записи.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="M:System.Diagnostics.Trace.Flush" /> вызывается в <see cref="P:System.Diagnostics.Trace.Listeners" /> после каждой операции записи; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00044C1D File Offset: 0x00042E1D
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x00044C24 File Offset: 0x00042E24
		public static bool AutoFlush
		{
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				return TraceInternal.AutoFlush;
			}
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			set
			{
				TraceInternal.AutoFlush = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, следует ли использовать глобальную блокировку.</summary>
		/// <returns>Значение <see langword="true" />, если нужно использовать глобальную блокировку; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x000472A8 File Offset: 0x000454A8
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x000472AF File Offset: 0x000454AF
		public static bool UseGlobalLock
		{
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				return TraceInternal.UseGlobalLock;
			}
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			set
			{
				TraceInternal.UseGlobalLock = value;
			}
		}

		/// <summary>Получает диспетчер корреляции для потока для данной трассировки.</summary>
		/// <returns>Объект <see cref="T:System.Diagnostics.CorrelationManager" />, связанный с потоком для данной трассировки.</returns>
		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x000472B7 File Offset: 0x000454B7
		public static CorrelationManager CorrelationManager
		{
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				if (Trace.correlationManager == null)
				{
					Trace.correlationManager = new CorrelationManager();
				}
				return Trace.correlationManager;
			}
		}

		/// <summary>Возвращает или задает уровень отступа.</summary>
		/// <returns>Уровень отступа. По умолчанию используется значение ноль.</returns>
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00044C2C File Offset: 0x00042E2C
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x00044C33 File Offset: 0x00042E33
		public static int IndentLevel
		{
			get
			{
				return TraceInternal.IndentLevel;
			}
			set
			{
				TraceInternal.IndentLevel = value;
			}
		}

		/// <summary>Возвращает или задает число пробелов в отступе.</summary>
		/// <returns>Число пробелов в отступе. Значение по умолчанию — четыре.</returns>
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x00044C3B File Offset: 0x00042E3B
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x00044C42 File Offset: 0x00042E42
		public static int IndentSize
		{
			get
			{
				return TraceInternal.IndentSize;
			}
			set
			{
				TraceInternal.IndentSize = value;
			}
		}

		/// <summary>Очищает выходной буфер и вызывает запись буферизованных данных в <see cref="P:System.Diagnostics.Trace.Listeners" />.</summary>
		// Token: 0x0600103C RID: 4156 RVA: 0x00044C4A File Offset: 0x00042E4A
		[Conditional("TRACE")]
		public static void Flush()
		{
			TraceInternal.Flush();
		}

		/// <summary>Очищает выходной буфер, а затем закрывает <see cref="P:System.Diagnostics.Trace.Listeners" />.</summary>
		// Token: 0x0600103D RID: 4157 RVA: 0x00044C51 File Offset: 0x00042E51
		[Conditional("TRACE")]
		public static void Close()
		{
			TraceInternal.Close();
		}

		/// <summary>Проверяет условие. Если условие имеет значение <see langword="false" />, отображается окно сообщения со стеком вызовов.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, сообщение о сбое не отправляется и не отображается окно сообщения.</param>
		// Token: 0x0600103E RID: 4158 RVA: 0x00044C58 File Offset: 0x00042E58
		[Conditional("TRACE")]
		public static void Assert(bool condition)
		{
			TraceInternal.Assert(condition);
		}

		/// <summary>Проверяет условие. Если условие имеет значение <see langword="false" />, выдается указанное сообщение и отображается окно сообщения со стеком вызовов.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, указанное сообщение не отправляется и окно сообщения не отображается.</param>
		/// <param name="message">Сообщение для отправки в коллекцию <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		// Token: 0x0600103F RID: 4159 RVA: 0x00044C60 File Offset: 0x00042E60
		[Conditional("TRACE")]
		public static void Assert(bool condition, string message)
		{
			TraceInternal.Assert(condition, message);
		}

		/// <summary>Проверяет условие. Если условие имеет значение <see langword="false" />, выдается два указанных сообщения и отображается окно сообщения со стеком вызовов.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, указанное сообщение не отправляется и окно сообщения не отображается.</param>
		/// <param name="message">Сообщение для отправки в коллекцию <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		/// <param name="detailMessage">Подробное сообщение для отправки в коллекцию <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		// Token: 0x06001040 RID: 4160 RVA: 0x00044C69 File Offset: 0x00042E69
		[Conditional("TRACE")]
		public static void Assert(bool condition, string message, string detailMessage)
		{
			TraceInternal.Assert(condition, message, detailMessage);
		}

		/// <summary>Выдает указанное сообщение об ошибке.</summary>
		/// <param name="message">Выдаваемое сообщение.</param>
		// Token: 0x06001041 RID: 4161 RVA: 0x00044C88 File Offset: 0x00042E88
		[Conditional("TRACE")]
		public static void Fail(string message)
		{
			TraceInternal.Fail(message);
		}

		/// <summary>Выдает сообщение об ошибке и подробное сообщение об ошибке.</summary>
		/// <param name="message">Выдаваемое сообщение.</param>
		/// <param name="detailMessage">Выдаваемое подробное сообщение.</param>
		// Token: 0x06001042 RID: 4162 RVA: 0x00044C90 File Offset: 0x00042E90
		[Conditional("TRACE")]
		public static void Fail(string message, string detailMessage)
		{
			TraceInternal.Fail(message, detailMessage);
		}

		/// <summary>Обновляет данные конфигурации трассировки.</summary>
		// Token: 0x06001043 RID: 4163 RVA: 0x000472D5 File Offset: 0x000454D5
		public static void Refresh()
		{
			DiagnosticsConfiguration.Refresh();
			Switch.RefreshAll();
			TraceSource.RefreshAll();
			TraceInternal.Refresh();
		}

		/// <summary>Записывает информационное сообщение в прослушиватели трассировки коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, используя для этого указанное сообщение.</summary>
		/// <param name="message">Информационное сообщение для записи.</param>
		// Token: 0x06001044 RID: 4164 RVA: 0x000472EB File Offset: 0x000454EB
		[Conditional("TRACE")]
		public static void TraceInformation(string message)
		{
			TraceInternal.TraceEvent(TraceEventType.Information, 0, message, null);
		}

		/// <summary>Записывает информационное сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, используя для этого указанный массив объектов и сведения о форматировании.</summary>
		/// <param name="format">Строка формата, не содержащая элементов формата или содержащая один либо несколько элементов формата, связанных с объектами в массиве <paramref name="args" />.</param>
		/// <param name="args">Массив <see langword="object" />, содержащий несколько объектов (или ни одного), которые необходимо отформатировать.</param>
		// Token: 0x06001045 RID: 4165 RVA: 0x000472F6 File Offset: 0x000454F6
		[Conditional("TRACE")]
		public static void TraceInformation(string format, params object[] args)
		{
			TraceInternal.TraceEvent(TraceEventType.Information, 0, format, args);
		}

		/// <summary>Записывает предупреждение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, используя указанное сообщение.</summary>
		/// <param name="message">Информационное сообщение для записи.</param>
		// Token: 0x06001046 RID: 4166 RVA: 0x00047301 File Offset: 0x00045501
		[Conditional("TRACE")]
		public static void TraceWarning(string message)
		{
			TraceInternal.TraceEvent(TraceEventType.Warning, 0, message, null);
		}

		/// <summary>Записывает предупреждение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, используя для этого указанный массив объектов и сведения о форматировании.</summary>
		/// <param name="format">Строка формата, не содержащая элементов формата или содержащая один либо несколько элементов формата, связанных с объектами в массиве <paramref name="args" />.</param>
		/// <param name="args">Массив <see langword="object" />, содержащий несколько объектов (или ни одного), которые необходимо отформатировать.</param>
		// Token: 0x06001047 RID: 4167 RVA: 0x0004730C File Offset: 0x0004550C
		[Conditional("TRACE")]
		public static void TraceWarning(string format, params object[] args)
		{
			TraceInternal.TraceEvent(TraceEventType.Warning, 0, format, args);
		}

		/// <summary>Записывает сообщение об ошибке в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, используя указанное сообщение.</summary>
		/// <param name="message">Информационное сообщение для записи.</param>
		// Token: 0x06001048 RID: 4168 RVA: 0x00047317 File Offset: 0x00045517
		[Conditional("TRACE")]
		public static void TraceError(string message)
		{
			TraceInternal.TraceEvent(TraceEventType.Error, 0, message, null);
		}

		/// <summary>Записывает сообщение об ошибке в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, используя для этого указанный массив объектов и сведения о форматировании.</summary>
		/// <param name="format">Строка формата, не содержащая элементов формата или содержащая один либо несколько элементов формата, связанных с объектами в массиве <paramref name="args" />.</param>
		/// <param name="args">Массив <see langword="object" />, содержащий несколько объектов (или ни одного), которые необходимо отформатировать.</param>
		// Token: 0x06001049 RID: 4169 RVA: 0x00047322 File Offset: 0x00045522
		[Conditional("TRACE")]
		public static void TraceError(string format, params object[] args)
		{
			TraceInternal.TraceEvent(TraceEventType.Error, 0, format, args);
		}

		/// <summary>Записывает сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x0600104A RID: 4170 RVA: 0x00044CB4 File Offset: 0x00042EB4
		[Conditional("TRACE")]
		public static void Write(string message)
		{
			TraceInternal.Write(message);
		}

		/// <summary>Записывает значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, имя которого отправляется к <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		// Token: 0x0600104B RID: 4171 RVA: 0x00044CBC File Offset: 0x00042EBC
		[Conditional("TRACE")]
		public static void Write(object value)
		{
			TraceInternal.Write(value);
		}

		/// <summary>Записывает имя категории и сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x0600104C RID: 4172 RVA: 0x00044CC4 File Offset: 0x00042EC4
		[Conditional("TRACE")]
		public static void Write(string message, string category)
		{
			TraceInternal.Write(message, category);
		}

		/// <summary>Записывает имя категории и значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />.</summary>
		/// <param name="value">Имя <see cref="T:System.Object" /> отправляется в <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x0600104D RID: 4173 RVA: 0x00044CCD File Offset: 0x00042ECD
		[Conditional("TRACE")]
		public static void Write(object value, string category)
		{
			TraceInternal.Write(value, category);
		}

		/// <summary>Записывает сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x0600104E RID: 4174 RVA: 0x00044C99 File Offset: 0x00042E99
		[Conditional("TRACE")]
		public static void WriteLine(string message)
		{
			TraceInternal.WriteLine(message);
		}

		/// <summary>Записывает значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, имя которого отправляется к <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		// Token: 0x0600104F RID: 4175 RVA: 0x00044CD6 File Offset: 0x00042ED6
		[Conditional("TRACE")]
		public static void WriteLine(object value)
		{
			TraceInternal.WriteLine(value);
		}

		/// <summary>Записывает имя категории и сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06001050 RID: 4176 RVA: 0x00044CDE File Offset: 0x00042EDE
		[Conditional("TRACE")]
		public static void WriteLine(string message, string category)
		{
			TraceInternal.WriteLine(message, category);
		}

		/// <summary>Записывает имя категории и значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, имя которого отправляется к <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06001051 RID: 4177 RVA: 0x00044CE7 File Offset: 0x00042EE7
		[Conditional("TRACE")]
		public static void WriteLine(object value, string category)
		{
			TraceInternal.WriteLine(value, category);
		}

		/// <summary>Записывает сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, если задано условие <see langword="true" />.</summary>
		/// <param name="condition">Значение <see langword="true" />, если требуется запись сообщения. В противном случае — значение <see langword="false" />.</param>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x06001052 RID: 4178 RVA: 0x00044CF0 File Offset: 0x00042EF0
		[Conditional("TRACE")]
		public static void WriteIf(bool condition, string message)
		{
			TraceInternal.WriteIf(condition, message);
		}

		/// <summary>Записывает значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, если условие — <see langword="true" />.</summary>
		/// <param name="condition">Значение <see langword="true" />, если требуется запись сообщения. В противном случае — значение <see langword="false" />.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, имя которого отправляется к <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		// Token: 0x06001053 RID: 4179 RVA: 0x00044CF9 File Offset: 0x00042EF9
		[Conditional("TRACE")]
		public static void WriteIf(bool condition, object value)
		{
			TraceInternal.WriteIf(condition, value);
		}

		/// <summary>Записывает имя категории и сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, если условие равно <see langword="true" />.</summary>
		/// <param name="condition">Значение <see langword="true" />, если требуется запись сообщения. В противном случае — значение <see langword="false" />.</param>
		/// <param name="message">Записываемое сообщение.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06001054 RID: 4180 RVA: 0x00044D02 File Offset: 0x00042F02
		[Conditional("TRACE")]
		public static void WriteIf(bool condition, string message, string category)
		{
			TraceInternal.WriteIf(condition, message, category);
		}

		/// <summary>Записывает имя категории и значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, если задано условие <see langword="true" />.</summary>
		/// <param name="condition">Значение <see langword="true" />, если требуется запись сообщения. В противном случае — значение <see langword="false" />.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, имя которого отправляется к <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06001055 RID: 4181 RVA: 0x00044D0C File Offset: 0x00042F0C
		[Conditional("TRACE")]
		public static void WriteIf(bool condition, object value, string category)
		{
			TraceInternal.WriteIf(condition, value, category);
		}

		/// <summary>Записывает сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, если задано условие <see langword="true" />.</summary>
		/// <param name="condition">Значение <see langword="true" />, если требуется запись сообщения. В противном случае — значение <see langword="false" />.</param>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x06001056 RID: 4182 RVA: 0x00044D16 File Offset: 0x00042F16
		[Conditional("TRACE")]
		public static void WriteLineIf(bool condition, string message)
		{
			TraceInternal.WriteLineIf(condition, message);
		}

		/// <summary>Записывает значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, если условие — <see langword="true" />.</summary>
		/// <param name="condition">Значение <see langword="true" />, если требуется запись сообщения. В противном случае — значение <see langword="false" />.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, имя которого отправляется к <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		// Token: 0x06001057 RID: 4183 RVA: 0x00044D1F File Offset: 0x00042F1F
		[Conditional("TRACE")]
		public static void WriteLineIf(bool condition, object value)
		{
			TraceInternal.WriteLineIf(condition, value);
		}

		/// <summary>Записывает имя категории и сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, если условие равно <see langword="true" />.</summary>
		/// <param name="condition">Значение <see langword="true" />, если требуется запись сообщения. В противном случае — значение <see langword="false" />.</param>
		/// <param name="message">Записываемое сообщение.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06001058 RID: 4184 RVA: 0x00044D28 File Offset: 0x00042F28
		[Conditional("TRACE")]
		public static void WriteLineIf(bool condition, string message, string category)
		{
			TraceInternal.WriteLineIf(condition, message, category);
		}

		/// <summary>Записывает имя категории и значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Trace.Listeners" />, если задано условие <see langword="true" />.</summary>
		/// <param name="condition">Значение <see langword="true" />, если требуется запись сообщения. В противном случае — значение <see langword="false" />.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, имя которого отправляется к <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06001059 RID: 4185 RVA: 0x00044D32 File Offset: 0x00042F32
		[Conditional("TRACE")]
		public static void WriteLineIf(bool condition, object value, string category)
		{
			TraceInternal.WriteLineIf(condition, value, category);
		}

		/// <summary>Уменьшает текущее значение <see cref="P:System.Diagnostics.Trace.IndentLevel" /> на единицу.</summary>
		// Token: 0x0600105A RID: 4186 RVA: 0x00044D3C File Offset: 0x00042F3C
		[Conditional("TRACE")]
		public static void Indent()
		{
			TraceInternal.Indent();
		}

		/// <summary>Уменьшает текущее значение <see cref="P:System.Diagnostics.Trace.IndentLevel" /> на единицу.</summary>
		// Token: 0x0600105B RID: 4187 RVA: 0x00044D43 File Offset: 0x00042F43
		[Conditional("TRACE")]
		public static void Unindent()
		{
			TraceInternal.Unindent();
		}

		// Token: 0x040009D2 RID: 2514
		private static volatile CorrelationManager correlationManager;
	}
}
