using System;
using System.Globalization;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Предоставляет набор методов и свойств, помогающих при отладке кода.</summary>
	// Token: 0x02000215 RID: 533
	public static class Debug
	{
		/// <summary>Получает коллекцию слушателей, отслеживающих данные отладки.</summary>
		/// <returns>Класс <see cref="T:System.Diagnostics.TraceListenerCollection" />, представляющий коллекцию типа <see cref="T:System.Diagnostics.TraceListener" />, которая позволяет отслеживать данные отладки.</returns>
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x00044C16 File Offset: 0x00042E16
		public static TraceListenerCollection Listeners
		{
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
			get
			{
				return TraceInternal.Listeners;
			}
		}

		/// <summary>Получает или задает значение, определяющее необходимость вызова метода <see cref="M:System.Diagnostics.Debug.Flush" /> для свойства <see cref="P:System.Diagnostics.Debug.Listeners" /> после каждой записи.</summary>
		/// <returns>
		///   <see langword="true" />, если <see cref="M:System.Diagnostics.Debug.Flush" /> вызывается в <see cref="P:System.Diagnostics.Debug.Listeners" /> после каждой операции записи; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x00044C1D File Offset: 0x00042E1D
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x00044C24 File Offset: 0x00042E24
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

		/// <summary>Возвращает или задает уровень отступа.</summary>
		/// <returns>Уровень отступа. Значение по умолчанию — 0.</returns>
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00044C2C File Offset: 0x00042E2C
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x00044C33 File Offset: 0x00042E33
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
		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00044C3B File Offset: 0x00042E3B
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x00044C42 File Offset: 0x00042E42
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

		/// <summary>Очищает выходной буфер и вызывает запись буферизованных данных в коллекцию <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		// Token: 0x06000F5E RID: 3934 RVA: 0x00044C4A File Offset: 0x00042E4A
		[Conditional("DEBUG")]
		public static void Flush()
		{
			TraceInternal.Flush();
		}

		/// <summary>Очищает выходной буфер, а затем вызывает метод <see langword="Close" /> на каждый <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		// Token: 0x06000F5F RID: 3935 RVA: 0x00044C51 File Offset: 0x00042E51
		[Conditional("DEBUG")]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static void Close()
		{
			TraceInternal.Close();
		}

		/// <summary>Проверяет условие. Если условие имеет значение <see langword="false" />, отображается окно сообщения со стеком вызовов.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, сообщение о сбое не отправляется и не отображается окно сообщения.</param>
		// Token: 0x06000F60 RID: 3936 RVA: 0x00044C58 File Offset: 0x00042E58
		[Conditional("DEBUG")]
		public static void Assert(bool condition)
		{
			TraceInternal.Assert(condition);
		}

		/// <summary>Проверяет условие. Если условие имеет значение <see langword="false" />, выдается указанное сообщение и отображается окно сообщения со стеком вызовов.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, указанное сообщение не отправляется и окно сообщения не отображается.</param>
		/// <param name="message">Сообщение для отправки в коллекцию <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		// Token: 0x06000F61 RID: 3937 RVA: 0x00044C60 File Offset: 0x00042E60
		[Conditional("DEBUG")]
		public static void Assert(bool condition, string message)
		{
			TraceInternal.Assert(condition, message);
		}

		/// <summary>Проверяет условие. Если условие имеет значение <see langword="false" />, выдается два указанных сообщения и отображается окно сообщения со стеком вызовов.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, указанное сообщение не отправляется и окно сообщения не отображается.</param>
		/// <param name="message">Сообщение для отправки в коллекцию <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		/// <param name="detailMessage">Подробное сообщение для отправки в коллекцию <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		// Token: 0x06000F62 RID: 3938 RVA: 0x00044C69 File Offset: 0x00042E69
		[Conditional("DEBUG")]
		public static void Assert(bool condition, string message, string detailMessage)
		{
			TraceInternal.Assert(condition, message, detailMessage);
		}

		/// <summary>Проверяет условие; если условие имеет значение <see langword="false" />, выводит два сообщения (простое и отформатированное) и отображает окно сообщения со стеком вызовов.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, указанное сообщение не отправляется и окно сообщения не отображается.</param>
		/// <param name="message">Сообщение для отправки в коллекцию <see cref="P:System.Diagnostics.Trace.Listeners" />.</param>
		/// <param name="detailMessageFormat">Строка составного формата для отправки в коллекцию <see cref="P:System.Diagnostics.Trace.Listeners" />. Это сообщение содержит текст, перемежаемый нулем или несколькими элементами форматирования, которые соответствуют объектам массива <paramref name="args" />.</param>
		/// <param name="args">Массив объектов, содержащий нуль или более форматируемых объектов.</param>
		// Token: 0x06000F63 RID: 3939 RVA: 0x00044C73 File Offset: 0x00042E73
		[Conditional("DEBUG")]
		public static void Assert(bool condition, string message, string detailMessageFormat, params object[] args)
		{
			TraceInternal.Assert(condition, message, string.Format(CultureInfo.InvariantCulture, detailMessageFormat, args));
		}

		/// <summary>Выдает указанное сообщение об ошибке.</summary>
		/// <param name="message">Выдаваемое сообщение.</param>
		// Token: 0x06000F64 RID: 3940 RVA: 0x00044C88 File Offset: 0x00042E88
		[Conditional("DEBUG")]
		public static void Fail(string message)
		{
			TraceInternal.Fail(message);
		}

		/// <summary>Выдает простое и подробное сообщение об ошибке.</summary>
		/// <param name="message">Выдаваемое сообщение.</param>
		/// <param name="detailMessage">Выдаваемое подробное сообщение.</param>
		// Token: 0x06000F65 RID: 3941 RVA: 0x00044C90 File Offset: 0x00042E90
		[Conditional("DEBUG")]
		public static void Fail(string message, string detailMessage)
		{
			TraceInternal.Fail(message, detailMessage);
		}

		/// <summary>Записывает сообщение, заканчивающееся ограничителем строки, в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		/// <param name="message">Сообщение для записи.</param>
		// Token: 0x06000F66 RID: 3942 RVA: 0x00044C99 File Offset: 0x00042E99
		[Conditional("DEBUG")]
		public static void Print(string message)
		{
			TraceInternal.WriteLine(message);
		}

		/// <summary>Записывает форматированную строку, заканчивающееся ограничителем строки, в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		/// <param name="format">Строка составного формата, содержащая текст, который перемежается несколькими элементами форматирования (или ни одним из них), соответствующими объектам в массиве <paramref name="args" />.</param>
		/// <param name="args">Массив объектов, содержащий один или несколько (либо ни одного) объектов, которые необходимо отформатировать.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="format" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.  
		///
		/// или - 
		/// Число, указывающее аргумент для форматирования, меньше нуля или больше или равно числу указанных объектов для форматирования.</exception>
		// Token: 0x06000F67 RID: 3943 RVA: 0x00044CA1 File Offset: 0x00042EA1
		[Conditional("DEBUG")]
		public static void Print(string format, params object[] args)
		{
			TraceInternal.WriteLine(string.Format(CultureInfo.InvariantCulture, format, args));
		}

		/// <summary>Записывает сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x06000F68 RID: 3944 RVA: 0x00044CB4 File Offset: 0x00042EB4
		[Conditional("DEBUG")]
		public static void Write(string message)
		{
			TraceInternal.Write(message);
		}

		/// <summary>Записывает значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		/// <param name="value">Объект, имя которого отправляется в <see cref="P:System.Diagnostics.Debug.Listeners" />.</param>
		// Token: 0x06000F69 RID: 3945 RVA: 0x00044CBC File Offset: 0x00042EBC
		[Conditional("DEBUG")]
		public static void Write(object value)
		{
			TraceInternal.Write(value);
		}

		/// <summary>Записывает имя категории и сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06000F6A RID: 3946 RVA: 0x00044CC4 File Offset: 0x00042EC4
		[Conditional("DEBUG")]
		public static void Write(string message, string category)
		{
			TraceInternal.Write(message, category);
		}

		/// <summary>Записывает имя категории и значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		/// <param name="value">Объект, имя которого отправляется в <see cref="P:System.Diagnostics.Debug.Listeners" />.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06000F6B RID: 3947 RVA: 0x00044CCD File Offset: 0x00042ECD
		[Conditional("DEBUG")]
		public static void Write(object value, string category)
		{
			TraceInternal.Write(value, category);
		}

		/// <summary>Записывает сообщение, заканчивающееся ограничителем строки, в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x06000F6C RID: 3948 RVA: 0x00044C99 File Offset: 0x00042E99
		[Conditional("DEBUG")]
		public static void WriteLine(string message)
		{
			TraceInternal.WriteLine(message);
		}

		/// <summary>Записывает значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		/// <param name="value">Объект, имя которого отправляется в <see cref="P:System.Diagnostics.Debug.Listeners" />.</param>
		// Token: 0x06000F6D RID: 3949 RVA: 0x00044CD6 File Offset: 0x00042ED6
		[Conditional("DEBUG")]
		public static void WriteLine(object value)
		{
			TraceInternal.WriteLine(value);
		}

		/// <summary>Записывает имя категории и сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06000F6E RID: 3950 RVA: 0x00044CDE File Offset: 0x00042EDE
		[Conditional("DEBUG")]
		public static void WriteLine(string message, string category)
		{
			TraceInternal.WriteLine(message, category);
		}

		/// <summary>Записывает имя категории и значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		/// <param name="value">Объект, имя которого отправляется в <see cref="P:System.Diagnostics.Debug.Listeners" />.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06000F6F RID: 3951 RVA: 0x00044CE7 File Offset: 0x00042EE7
		[Conditional("DEBUG")]
		public static void WriteLine(object value, string category)
		{
			TraceInternal.WriteLine(value, category);
		}

		/// <summary>Записывает форматированное сообщение, заканчивающееся ограничителем строки, в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />.</summary>
		/// <param name="format">Строка составного формата, содержащая текст, который перемежается несколькими элементами форматирования (или ни одним из них), соответствующими объектам в массиве <paramref name="args" />.</param>
		/// <param name="args">Массив объектов, содержащий нуль или более форматируемых объектов.</param>
		// Token: 0x06000F70 RID: 3952 RVA: 0x00044CA1 File Offset: 0x00042EA1
		[Conditional("DEBUG")]
		public static void WriteLine(string format, params object[] args)
		{
			TraceInternal.WriteLine(string.Format(CultureInfo.InvariantCulture, format, args));
		}

		/// <summary>Записывает сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />, если задано условие <see langword="true" />.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, сообщение записывается в прослушиватели трассировки в коллекции.</param>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x06000F71 RID: 3953 RVA: 0x00044CF0 File Offset: 0x00042EF0
		[Conditional("DEBUG")]
		public static void WriteIf(bool condition, string message)
		{
			TraceInternal.WriteIf(condition, message);
		}

		/// <summary>Записывает значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />, если условие — <see langword="true" />.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, значение записывается в прослушиватели трассировки в коллекции.</param>
		/// <param name="value">Объект, имя которого отправляется в <see cref="P:System.Diagnostics.Debug.Listeners" />.</param>
		// Token: 0x06000F72 RID: 3954 RVA: 0x00044CF9 File Offset: 0x00042EF9
		[Conditional("DEBUG")]
		public static void WriteIf(bool condition, object value)
		{
			TraceInternal.WriteIf(condition, value);
		}

		/// <summary>Записывает имя категории и сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />, если условие равно <see langword="true" />.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, имя категории и сообщение записываются в прослушиватели трассировки в коллекции.</param>
		/// <param name="message">Записываемое сообщение.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06000F73 RID: 3955 RVA: 0x00044D02 File Offset: 0x00042F02
		[Conditional("DEBUG")]
		public static void WriteIf(bool condition, string message, string category)
		{
			TraceInternal.WriteIf(condition, message, category);
		}

		/// <summary>Записывает имя категории и значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />, если задано условие <see langword="true" />.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, имя категории и значение записываются в прослушиватели трассировки в коллекции.</param>
		/// <param name="value">Объект, имя которого отправляется в <see cref="P:System.Diagnostics.Debug.Listeners" />.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06000F74 RID: 3956 RVA: 0x00044D0C File Offset: 0x00042F0C
		[Conditional("DEBUG")]
		public static void WriteIf(bool condition, object value, string category)
		{
			TraceInternal.WriteIf(condition, value, category);
		}

		/// <summary>Записывает сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />, если задано условие <see langword="true" />.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, сообщение записывается в прослушиватели трассировки в коллекции.</param>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x06000F75 RID: 3957 RVA: 0x00044D16 File Offset: 0x00042F16
		[Conditional("DEBUG")]
		public static void WriteLineIf(bool condition, string message)
		{
			TraceInternal.WriteLineIf(condition, message);
		}

		/// <summary>Записывает значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />, если условие — <see langword="true" />.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, значение записывается в прослушиватели трассировки в коллекции.</param>
		/// <param name="value">Объект, имя которого отправляется в <see cref="P:System.Diagnostics.Debug.Listeners" />.</param>
		// Token: 0x06000F76 RID: 3958 RVA: 0x00044D1F File Offset: 0x00042F1F
		[Conditional("DEBUG")]
		public static void WriteLineIf(bool condition, object value)
		{
			TraceInternal.WriteLineIf(condition, value);
		}

		/// <summary>Записывает имя категории и сообщение в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />, если условие равно <see langword="true" />.</summary>
		/// <param name="condition">Значение <see langword="true" />, если требуется запись сообщения. В противном случае — значение <see langword="false" />.</param>
		/// <param name="message">Записываемое сообщение.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06000F77 RID: 3959 RVA: 0x00044D28 File Offset: 0x00042F28
		[Conditional("DEBUG")]
		public static void WriteLineIf(bool condition, string message, string category)
		{
			TraceInternal.WriteLineIf(condition, message, category);
		}

		/// <summary>Записывает имя категории и значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватели трассировки в коллекции <see cref="P:System.Diagnostics.Debug.Listeners" />, если задано условие <see langword="true" />.</summary>
		/// <param name="condition">Условное выражение для вычисления. Если условие имеет значение <see langword="true" />, имя категории и значение записываются в прослушиватели трассировки в коллекции.</param>
		/// <param name="value">Объект, имя которого отправляется в <see cref="P:System.Diagnostics.Debug.Listeners" />.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x06000F78 RID: 3960 RVA: 0x00044D32 File Offset: 0x00042F32
		[Conditional("DEBUG")]
		public static void WriteLineIf(bool condition, object value, string category)
		{
			TraceInternal.WriteLineIf(condition, value, category);
		}

		/// <summary>Уменьшает текущее значение <see cref="P:System.Diagnostics.Debug.IndentLevel" /> на единицу.</summary>
		// Token: 0x06000F79 RID: 3961 RVA: 0x00044D3C File Offset: 0x00042F3C
		[Conditional("DEBUG")]
		public static void Indent()
		{
			TraceInternal.Indent();
		}

		/// <summary>Уменьшает текущее значение <see cref="P:System.Diagnostics.Debug.IndentLevel" /> на единицу.</summary>
		// Token: 0x06000F7A RID: 3962 RVA: 0x00044D43 File Offset: 0x00042F43
		[Conditional("DEBUG")]
		public static void Unindent()
		{
			TraceInternal.Unindent();
		}
	}
}
