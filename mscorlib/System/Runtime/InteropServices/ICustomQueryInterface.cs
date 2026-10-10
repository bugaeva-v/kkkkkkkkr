using System;
using System.Security;

namespace System.Runtime.InteropServices
{
	/// <summary>Позволяет разработчикам предоставлять собственную управляемую реализацию метода IUnknown::QueryInterface(REFIID riid, void **ppvObject).</summary>
	// Token: 0x02000718 RID: 1816
	[ComVisible(false)]
	public interface ICustomQueryInterface
	{
		/// <summary>Возвращает интерфейс, соответствующий указанному идентификатору интерфейса.</summary>
		/// <param name="iid">Идентификатор GUID запрашиваемого интерфейса.</param>
		/// <param name="ppv">Ссылка на запрашиваемый интерфейс (когда данный метод возвращает значение).</param>
		/// <returns>Одно из значений перечисления, указывающих, используется ли пользовательская реализация интерфейса IUnknown::QueryInterface.</returns>
		// Token: 0x060040D7 RID: 16599
		[SecurityCritical]
		CustomQueryInterfaceResult GetInterface([In] ref Guid iid, out IntPtr ppv);
	}
}
