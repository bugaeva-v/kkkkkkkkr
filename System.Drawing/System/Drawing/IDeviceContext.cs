using System;

namespace System.Drawing
{
	/// <summary>Определяет методы получения и освобождения существующего дескриптора контекста устройства Windows.</summary>
	// Token: 0x02000031 RID: 49
	public interface IDeviceContext : IDisposable
	{
		/// <summary>Возвращает дескриптор контекста устройства Windows.</summary>
		/// <returns>Указатель <see cref="T:System.IntPtr" />, представляющий дескриптор контекста устройства.</returns>
		// Token: 0x060000E7 RID: 231
		IntPtr GetHdc();

		/// <summary>Освобождает дескриптор контекста устройства Windows.</summary>
		// Token: 0x060000E8 RID: 232
		void ReleaseHdc();
	}
}
