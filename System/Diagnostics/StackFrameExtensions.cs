using System;

namespace System.Diagnostics
{
	/// <summary>Предоставляет методы расширения для класса <see cref="T:System.Diagnostics.StackFrame" />, который представляет вызов функции в стеке вызовов для текущего потока.</summary>
	// Token: 0x02000210 RID: 528
	public static class StackFrameExtensions
	{
		/// <summary>Указывает, доступен ли собственный образ для указанного кадра стека.</summary>
		/// <param name="stackFrame">Кадр стека.</param>
		/// <returns>
		///   <see langword="true" />, если собственный образ доступен для этого кадра стека; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000F3C RID: 3900 RVA: 0x00044A07 File Offset: 0x00042C07
		public static bool HasNativeImage(this StackFrame stackFrame)
		{
			return stackFrame.GetNativeImageBase() != IntPtr.Zero;
		}

		/// <summary>Указывает, доступны ли сведения о методе, в котором выполняется заданный кадр.</summary>
		/// <param name="stackFrame">Кадр стека.</param>
		/// <returns>Значение <see langword="true" />, если доступны сведения о методе, в котором выполняется текущий; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F3D RID: 3901 RVA: 0x00044A19 File Offset: 0x00042C19
		public static bool HasMethod(this StackFrame stackFrame)
		{
			return stackFrame.GetMethod() != null;
		}

		/// <summary>Указывает, доступно ли смещение от начала кода на языке IL для выполняемого метода.</summary>
		/// <param name="stackFrame">Кадр стека.</param>
		/// <returns>
		///   <see langword="true" />, если смещение доступно; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000F3E RID: 3902 RVA: 0x00044A27 File Offset: 0x00042C27
		public static bool HasILOffset(this StackFrame stackFrame)
		{
			return stackFrame.GetILOffset() != -1;
		}

		/// <summary>Указывает, доступен ли файл, содержащий код, который выполняется в указанном кадре стека.</summary>
		/// <param name="stackFrame">Кадр стека.</param>
		/// <returns>
		///   <see langword="true" />, если доступен код, который выполняется в указанном кадре стека; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000F3F RID: 3903 RVA: 0x00044A35 File Offset: 0x00042C35
		public static bool HasSource(this StackFrame stackFrame)
		{
			return stackFrame.GetFileName() != null;
		}

		/// <summary>Получает указатель интерфейса на начало машинного код для выполняющегося метода.</summary>
		/// <param name="stackFrame">Кадр стека.</param>
		/// <returns>Указатель интерфейса на начало машинного кода для выполняющегося метода или <see cref="F:System.IntPtr.Zero" />, если целевой платформой является .NET Framework.</returns>
		// Token: 0x06000F40 RID: 3904 RVA: 0x00011E31 File Offset: 0x00010031
		public static IntPtr GetNativeIP(this StackFrame stackFrame)
		{
			return IntPtr.Zero;
		}

		/// <summary>Возвращает указатель на базовый адрес собственного образа, который выполняется в этом кадре стека.</summary>
		/// <param name="stackFrame">Кадр стека.</param>
		/// <returns>Указатель на базовый адрес собственного образа или <see cref="F:System.IntPtr.Zero" />, если целевой платформой является .NET Framework.</returns>
		// Token: 0x06000F41 RID: 3905 RVA: 0x00011E31 File Offset: 0x00010031
		public static IntPtr GetNativeImageBase(this StackFrame stackFrame)
		{
			return IntPtr.Zero;
		}
	}
}
