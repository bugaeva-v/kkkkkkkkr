using System;
using System.Runtime.InteropServices;

namespace System.Security
{
	/// <summary>Предоставляет коллекцию методов для выделения неуправляемой памяти и копирования блоков неуправляемой памяти.</summary>
	// Token: 0x0200028D RID: 653
	public static class SecureStringMarshal
	{
		/// <summary>Копирует содержимое управляемого объекта <see cref="T:System.Security.SecureString" /> в блок памяти, выделенный из неуправляемого распределителя COM-задач.</summary>
		/// <param name="s">Управляемый объект, подлежащий копированию.</param>
		/// <returns>Адрес в неуправляемой памяти, куда скопирован параметр <paramref name="s" />, или 0, если передан пустой объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий компьютер не работает под управлением Windows 2000 с пакетом обновления 3 (SP3) или более поздней версии.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		// Token: 0x060014AA RID: 5290 RVA: 0x000543AE File Offset: 0x000525AE
		public static IntPtr SecureStringToCoTaskMemAnsi(SecureString s)
		{
			return Marshal.SecureStringToCoTaskMemAnsi(s);
		}

		/// <summary>Копирует содержимое управляемого объекта <see cref="T:System.Security.SecureString" /> в неуправляемую память, преобразуя его по мере копирования в формат ANSI.</summary>
		/// <param name="s">Управляемый объект, подлежащий копированию.</param>
		/// <returns>Адрес в неуправляемой памяти, куда скопирован параметр <paramref name="s" />, или 0, если передан пустой объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий компьютер не работает под управлением Windows 2000 с пакетом обновления 3 (SP3) или более поздней версии.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		// Token: 0x060014AB RID: 5291 RVA: 0x000543B6 File Offset: 0x000525B6
		public static IntPtr SecureStringToGlobalAllocAnsi(SecureString s)
		{
			return Marshal.SecureStringToGlobalAllocAnsi(s);
		}

		/// <summary>Копирует содержимое управляемого объекта <see cref="T:System.Security.SecureString" /> в блок памяти, выделенный из неуправляемого распределителя COM-задач.</summary>
		/// <param name="s">Управляемый объект, подлежащий копированию.</param>
		/// <returns>Адрес в неуправляемой памяти, куда скопирован параметр <paramref name="s" />, или 0, если передан пустой объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий компьютер не работает под управлением Windows 2000 с пакетом обновления 3 (SP3) или более поздней версии.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		// Token: 0x060014AC RID: 5292 RVA: 0x000543BE File Offset: 0x000525BE
		public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s)
		{
			return Marshal.SecureStringToCoTaskMemUnicode(s);
		}

		/// <summary>Копирует содержимое управляемого объекта <see cref="T:System.Security.SecureString" /> в неуправляемую память.</summary>
		/// <param name="s">Управляемый объект, подлежащий копированию.</param>
		/// <returns>Адрес в неуправляемой памяти, куда был скопирован параметр <paramref name="s" />, или значение 0, если параметр <paramref name="s" /> представляет собой объект <see cref="T:System.Security.SecureString" />, длина которого равна 0.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Текущий компьютер не работает под управлением Windows 2000 с пакетом обновления 3 (SP3) или более поздней версии.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти.</exception>
		// Token: 0x060014AD RID: 5293 RVA: 0x000543C6 File Offset: 0x000525C6
		public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
		{
			return Marshal.SecureStringToGlobalAllocUnicode(s);
		}
	}
}
