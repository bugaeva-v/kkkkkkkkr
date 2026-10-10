using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Threading
{
	/// <summary>Получает код ошибки, количество байтов и тип перекрывающегося значения при завершении операции ввода-вывода в пуле потоков.</summary>
	/// <param name="errorCode">Код ошибки.</param>
	/// <param name="numBytes">Количество переданных байтов.</param>
	/// <param name="pOVERLAP">Структура <see cref="T:System.Threading.NativeOverlapped" />, представляющая неуправляемый указатель на собственный тип перекрывающегося значения.</param>
	// Token: 0x020002DC RID: 732
	// (Invoke) Token: 0x06002007 RID: 8199
	[ComVisible(true)]
	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe delegate void IOCompletionCallback(uint errorCode, uint numBytes, NativeOverlapped* pOVERLAP);
}
