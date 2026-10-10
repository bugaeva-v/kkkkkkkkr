using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Инкапсулирует управляемый объект, который содержит дескриптор для ресурса (передается в неуправляемый код с помощью вызова платформы).</summary>
	// Token: 0x020006C5 RID: 1733
	public readonly struct HandleRef
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.HandleRef" />, используя инкапсулируемый объект и дескриптор ресурса, используемого неуправляемым кодом.</summary>
		/// <param name="wrapper">Управляемый объект, который не следует завершать до возвращения из вызова неуправляемого кода.</param>
		/// <param name="handle">Указатель<see cref="T:System.IntPtr" />, показывающий дескриптор для ресурса.</param>
		// Token: 0x06003FD7 RID: 16343 RVA: 0x000DFE4B File Offset: 0x000DE04B
		public HandleRef(object wrapper, IntPtr handle)
		{
			this._wrapper = wrapper;
			this._handle = handle;
		}

		/// <summary>Возвращает объект, содержащий дескриптор для ресурса.</summary>
		/// <returns>Объект, содержащий дескриптор для ресурса.</returns>
		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06003FD8 RID: 16344 RVA: 0x000DFE5B File Offset: 0x000DE05B
		public object Wrapper
		{
			get
			{
				return this._wrapper;
			}
		}

		/// <summary>Возвращает дескриптор для ресурса.</summary>
		/// <returns>Дескриптор для ресурса.</returns>
		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x000DFE63 File Offset: 0x000DE063
		public IntPtr Handle
		{
			get
			{
				return this._handle;
			}
		}

		/// <summary>Возвращает дескриптор для ресурса указанного объекта <see cref="T:System.Runtime.InteropServices.HandleRef" />.</summary>
		/// <param name="value">Объект, для которого требуется дескриптор.</param>
		/// <returns>Дескриптор для ресурса указанного объекта <see cref="T:System.Runtime.InteropServices.HandleRef" />.</returns>
		// Token: 0x06003FDA RID: 16346 RVA: 0x000DFE63 File Offset: 0x000DE063
		public static explicit operator IntPtr(HandleRef value)
		{
			return value._handle;
		}

		/// <summary>Возвращает внутреннее целочисленное представление объекта <see cref="T:System.Runtime.InteropServices.HandleRef" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Runtime.InteropServices.HandleRef" /> для извлечения внутреннего целочисленного представления.</param>
		/// <returns>Объект <see cref="T:System.IntPtr" />, представляющий объект <see cref="T:System.Runtime.InteropServices.HandleRef" />.</returns>
		// Token: 0x06003FDB RID: 16347 RVA: 0x000DFE63 File Offset: 0x000DE063
		public static IntPtr ToIntPtr(HandleRef value)
		{
			return value._handle;
		}

		// Token: 0x040029F3 RID: 10739
		private readonly object _wrapper;

		// Token: 0x040029F4 RID: 10740
		private readonly IntPtr _handle;
	}
}
