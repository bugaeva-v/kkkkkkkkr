using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Предоставляет сведения об объекте <see cref="T:System.Diagnostics.StackFrame" />, который представляет вызов функции в стеке вызовов для текущего потока.</summary>
	// Token: 0x020009C1 RID: 2497
	[ComVisible(true)]
	[MonoTODO("Serialized objects are not compatible with MS.NET")]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class StackFrame
	{
		// Token: 0x060059D3 RID: 22995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column);

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.StackFrame" />.</summary>
		// Token: 0x060059D4 RID: 22996 RVA: 0x001332D8 File Offset: 0x001314D8
		public StackFrame()
		{
			bool flag = StackFrame.get_frame_info(2, false, out this.methodBase, out this.ilOffset, out this.nativeOffset, out this.fileName, out this.lineNumber, out this.columnNumber);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.StackFrame" /> и дополнительно может собирать сведения об источнике.</summary>
		/// <param name="fNeedFileInfo">Значение <see langword="true" />, чтобы зафиксировать имя файла, номер строки и номер столбца кадра стека; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060059D5 RID: 22997 RVA: 0x00133328 File Offset: 0x00131528
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFrame(bool fNeedFileInfo)
		{
			bool flag = StackFrame.get_frame_info(2, fNeedFileInfo, out this.methodBase, out this.ilOffset, out this.nativeOffset, out this.fileName, out this.lineNumber, out this.columnNumber);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.StackFrame" />, соответствующий кадру, который расположен над текущим кадром стека.</summary>
		/// <param name="skipFrames">Количество пропускаемых кадров вверх по стеку.</param>
		// Token: 0x060059D6 RID: 22998 RVA: 0x00133378 File Offset: 0x00131578
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFrame(int skipFrames)
		{
			bool flag = StackFrame.get_frame_info(skipFrames + 2, false, out this.methodBase, out this.ilOffset, out this.nativeOffset, out this.fileName, out this.lineNumber, out this.columnNumber);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.StackFrame" />, соответствующий кадру, который расположен над текущим кадром стека и дополнительно может собирать сведения об источнике.</summary>
		/// <param name="skipFrames">Количество пропускаемых кадров вверх по стеку.</param>
		/// <param name="fNeedFileInfo">Значение <see langword="true" />, чтобы зафиксировать имя файла, номер строки и номер столбца кадра стека; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060059D7 RID: 22999 RVA: 0x001333C8 File Offset: 0x001315C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFrame(int skipFrames, bool fNeedFileInfo)
		{
			bool flag = StackFrame.get_frame_info(skipFrames + 2, fNeedFileInfo, out this.methodBase, out this.ilOffset, out this.nativeOffset, out this.fileName, out this.lineNumber, out this.columnNumber);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.StackFrame" />, содержащий только заданное имя файла и номер строки.</summary>
		/// <param name="fileName">Имя файла.</param>
		/// <param name="lineNumber">Номер строки в указанном файле.</param>
		// Token: 0x060059D8 RID: 23000 RVA: 0x00133418 File Offset: 0x00131618
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFrame(string fileName, int lineNumber)
		{
			bool flag = StackFrame.get_frame_info(2, false, out this.methodBase, out this.ilOffset, out this.nativeOffset, out fileName, out lineNumber, out this.columnNumber);
			this.fileName = fileName;
			this.lineNumber = lineNumber;
			this.columnNumber = 0;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.StackFrame" />, содержащий только заданное имя файла, номер строки и номер столбца.</summary>
		/// <param name="fileName">Имя файла.</param>
		/// <param name="lineNumber">Номер строки в указанном файле.</param>
		/// <param name="colNumber">Номер столбца в указанном файле.</param>
		// Token: 0x060059D9 RID: 23001 RVA: 0x00133474 File Offset: 0x00131674
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackFrame(string fileName, int lineNumber, int colNumber)
		{
			bool flag = StackFrame.get_frame_info(2, false, out this.methodBase, out this.ilOffset, out this.nativeOffset, out fileName, out lineNumber, out this.columnNumber);
			this.fileName = fileName;
			this.lineNumber = lineNumber;
			this.columnNumber = colNumber;
		}

		/// <summary>Получает номер строки в файле, содержащем выполняемый код. Эти сведения обычно извлекаются из символов отладки для исполняемого файла.</summary>
		/// <returns>Номер строки в файле или 0 (нуль), если номер строки в файле определить не удалось.</returns>
		// Token: 0x060059DA RID: 23002 RVA: 0x001334CE File Offset: 0x001316CE
		public virtual int GetFileLineNumber()
		{
			return this.lineNumber;
		}

		/// <summary>Получает номер столбца в файле, содержащем выполняемый код. Эти сведения обычно извлекаются из символов отладки для исполняемого файла.</summary>
		/// <returns>Номер столбца в файле или 0 (нуль), если номер столбца в файле определить не удалось.</returns>
		// Token: 0x060059DB RID: 23003 RVA: 0x001334D6 File Offset: 0x001316D6
		public virtual int GetFileColumnNumber()
		{
			return this.columnNumber;
		}

		/// <summary>Получает имя файла, содержащего выполняемый код. Эти сведения обычно извлекаются из символов отладки для исполняемого файла.</summary>
		/// <returns>Имя файла или <see langword="null" />, если имя файла определить не удалось.</returns>
		// Token: 0x060059DC RID: 23004 RVA: 0x001334DE File Offset: 0x001316DE
		public virtual string GetFileName()
		{
			return this.fileName;
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x001334E8 File Offset: 0x001316E8
		internal string GetSecureFileName()
		{
			string result = "<filename unknown>";
			if (this.fileName == null)
			{
				return result;
			}
			try
			{
				result = this.GetFileName();
			}
			catch (SecurityException)
			{
			}
			return result;
		}

		/// <summary>Получает смещение от начала кода на языке MSIL для выполняемого метода. Это смещение может быть приблизительным, в зависимости от того, создает ли JIT-компилятор код отладки. Управление созданием этих сведений отладки осуществляется классом <see cref="T:System.Diagnostics.DebuggableAttribute" />.</summary>
		/// <returns>Смещение от начала кода на языке MSIL для выполняемого метода.</returns>
		// Token: 0x060059DE RID: 23006 RVA: 0x00133524 File Offset: 0x00131724
		public virtual int GetILOffset()
		{
			return this.ilOffset;
		}

		/// <summary>Получает метод, в котором выполняется кадр.</summary>
		/// <returns>Метод, в котором выполняется кадр.</returns>
		// Token: 0x060059DF RID: 23007 RVA: 0x0013352C File Offset: 0x0013172C
		public virtual MethodBase GetMethod()
		{
			return this.methodBase;
		}

		/// <summary>Получает смещение от начала исходного, скомпилированного JIT-компилятором кода для исполняемого метода. Управление созданием этих сведений отладки осуществляется классом <see cref="T:System.Diagnostics.DebuggableAttribute" />.</summary>
		/// <returns>Смещение от начала кода, скомпилированного JIT-компилятором для выполняемого метода.</returns>
		// Token: 0x060059E0 RID: 23008 RVA: 0x00133534 File Offset: 0x00131734
		public virtual int GetNativeOffset()
		{
			return this.nativeOffset;
		}

		// Token: 0x060059E1 RID: 23009 RVA: 0x0013353C File Offset: 0x0013173C
		internal long GetMethodAddress()
		{
			return this.methodAddress;
		}

		// Token: 0x060059E2 RID: 23010 RVA: 0x00133544 File Offset: 0x00131744
		internal uint GetMethodIndex()
		{
			return this.methodIndex;
		}

		// Token: 0x060059E3 RID: 23011 RVA: 0x0013354C File Offset: 0x0013174C
		internal string GetInternalMethodName()
		{
			return this.internalMethodName;
		}

		/// <summary>Создает доступное для чтения представление трассировки стека.</summary>
		/// <returns>Доступное для чтения представление трассировки стека.</returns>
		// Token: 0x060059E4 RID: 23012 RVA: 0x00133554 File Offset: 0x00131754
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.methodBase == null)
			{
				stringBuilder.Append(Locale.GetText("<unknown method>"));
			}
			else
			{
				stringBuilder.Append(this.methodBase.Name);
			}
			stringBuilder.Append(Locale.GetText(" at "));
			if (this.ilOffset == -1)
			{
				stringBuilder.Append(Locale.GetText("<unknown offset>"));
			}
			else
			{
				stringBuilder.Append(Locale.GetText("offset "));
				stringBuilder.Append(this.ilOffset);
			}
			stringBuilder.Append(Locale.GetText(" in file:line:column "));
			stringBuilder.Append(this.GetSecureFileName());
			stringBuilder.AppendFormat(":{0}:{1}", this.lineNumber, this.columnNumber);
			return stringBuilder.ToString();
		}

		/// <summary>Определяет значение, возвращаемое методом <see cref="M:System.Diagnostics.StackFrame.GetNativeOffset" />, или <see cref="M:System.Diagnostics.StackFrame.GetILOffset" />, если смещение в исходном коде или коде на языке MSIL неизвестно. Это поле является константой.</summary>
		// Token: 0x0400378E RID: 14222
		public const int OFFSET_UNKNOWN = -1;

		// Token: 0x0400378F RID: 14223
		private int ilOffset = -1;

		// Token: 0x04003790 RID: 14224
		private int nativeOffset = -1;

		// Token: 0x04003791 RID: 14225
		private long methodAddress;

		// Token: 0x04003792 RID: 14226
		private uint methodIndex;

		// Token: 0x04003793 RID: 14227
		private MethodBase methodBase;

		// Token: 0x04003794 RID: 14228
		private string fileName;

		// Token: 0x04003795 RID: 14229
		private int lineNumber;

		// Token: 0x04003796 RID: 14230
		private int columnNumber;

		// Token: 0x04003797 RID: 14231
		private string internalMethodName;
	}
}
