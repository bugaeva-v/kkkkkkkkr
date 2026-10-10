using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает, может ли интерфейс <see cref="T:System.Runtime.InteropServices.ICustomQueryInterface" /> использоваться в вызовахIUnknown::QueryInterface метода <see cref="M:System.Runtime.InteropServices.Marshal.GetComInterfaceForObject(System.Object,System.Type,System.Runtime.InteropServices.CustomQueryInterfaceMode)" />.</summary>
	// Token: 0x020006D5 RID: 1749
	public enum CustomQueryInterfaceMode
	{
		/// <summary>Вызовы метода IUnknown::QueryInterface должны игнорировать интерфейс <see cref="T:System.Runtime.InteropServices.ICustomQueryInterface" />.</summary>
		// Token: 0x04002A1E RID: 10782
		Ignore,
		/// <summary>Вызовы метода IUnknown::QueryInterface могут использовать интерфейс <see cref="T:System.Runtime.InteropServices.ICustomQueryInterface" />. Если используется это значение, перегруженный метод <see cref="M:System.Runtime.InteropServices.Marshal.GetComInterfaceForObject(System.Object,System.Type,System.Runtime.InteropServices.CustomQueryInterfaceMode)" /> действует аналогично перегруженному методу <see cref="M:System.Runtime.InteropServices.Marshal.GetComInterfaceForObject(System.Object,System.Type)" />.</summary>
		// Token: 0x04002A1F RID: 10783
		Allow
	}
}
