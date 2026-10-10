using System;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	/// <summary>Предоставляет удобные методы для работы с безопасным дескриптором для дескриптора ожидания.</summary>
	// Token: 0x020002EC RID: 748
	public static class WaitHandleExtensions
	{
		/// <summary>Возвращает безопасный дескриптор для собственного дескриптора ожидания операционной системы.</summary>
		/// <param name="waitHandle">Собственный дескриптор операционной системы.</param>
		/// <returns>Безопасный дескриптор ожидания, инкапсулирующий собственный дескриптор ожидания операционной системы.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="waitHandle" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600209B RID: 8347 RVA: 0x000768AF File Offset: 0x00074AAF
		[SecurityCritical]
		public static SafeWaitHandle GetSafeWaitHandle(this WaitHandle waitHandle)
		{
			if (waitHandle == null)
			{
				throw new ArgumentNullException("waitHandle");
			}
			return waitHandle.SafeWaitHandle;
		}

		/// <summary>Задает безопасный дескриптор для собственного дескриптора ожидания операционной системы.</summary>
		/// <param name="waitHandle">Дескриптор ожидания, который инкапсулирует связанный с операционной системой объект, ожидающий монопольного доступа к общему ресурсу.</param>
		/// <param name="value">Безопасный дескриптор, инкапсулирующий дескриптор операционной системы.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="waitHandle" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600209C RID: 8348 RVA: 0x000768C5 File Offset: 0x00074AC5
		[SecurityCritical]
		public static void SetSafeWaitHandle(this WaitHandle waitHandle, SafeWaitHandle value)
		{
			if (waitHandle == null)
			{
				throw new ArgumentNullException("waitHandle");
			}
			waitHandle.SafeWaitHandle = value;
		}
	}
}
