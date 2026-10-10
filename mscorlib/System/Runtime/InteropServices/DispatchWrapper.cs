using System;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.InteropServices
{
	/// <summary>Инкапсулирует объекты, которые необходимо маршалировать, как <see langword="VT_DISPATCH" />.</summary>
	// Token: 0x02000716 RID: 1814
	[ComVisible(true)]
	[Serializable]
	public sealed class DispatchWrapper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.DispatchWrapper" /> с объектом, заключаемым в оболочку.</summary>
		/// <param name="obj">Объект, который необходимо заключить в оболочку и преобразовать в <see cref="F:System.Runtime.InteropServices.VarEnum.VT_DISPATCH" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="obj" /> не является классом или массивом.  
		/// -или- 
		///  <paramref name="obj" /> не поддерживает <see langword="IDispatch" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="obj" /> был помечен атрибутом <see cref="T:System.Runtime.InteropServices.ComVisibleAttribute" />, переданным как значение <see langword="false" />.  
		/// -или- 
		/// Параметр <paramref name="obj" /> наследуется от типа, помеченного атрибутом <see cref="T:System.Runtime.InteropServices.ComVisibleAttribute" />, переданным как значение <see langword="false" />.</exception>
		// Token: 0x060040D5 RID: 16597 RVA: 0x000E1725 File Offset: 0x000DF925
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public DispatchWrapper(object obj)
		{
			if (obj != null)
			{
				Marshal.Release(Marshal.GetIDispatchForObject(obj));
			}
			this.m_WrappedObject = obj;
		}

		/// <summary>Возвращает объект, заключенный в оболочку с помощью <see cref="T:System.Runtime.InteropServices.DispatchWrapper" />.</summary>
		/// <returns>Объект, заключенный в оболочку с помощью <see cref="T:System.Runtime.InteropServices.DispatchWrapper" />.</returns>
		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060040D6 RID: 16598 RVA: 0x000E1743 File Offset: 0x000DF943
		public object WrappedObject
		{
			get
			{
				return this.m_WrappedObject;
			}
		}

		// Token: 0x04002AFA RID: 11002
		private object m_WrappedObject;
	}
}
