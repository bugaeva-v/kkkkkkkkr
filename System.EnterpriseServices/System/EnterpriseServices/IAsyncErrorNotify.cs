using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Реализует перехват ошибок в асинхронной пакетной работе, отправленной объектом <see cref="T:System.EnterpriseServices.Activity" />.</summary>
	// Token: 0x0200001E RID: 30
	[Guid("FE6777FB-A674-4177-8F32-6D707E113484")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IAsyncErrorNotify
	{
		/// <summary>Обрабатывает ошибки для асинхронной пакетной работы.</summary>
		/// <param name="hresult">Результат HRESULT для ошибки, возникшей при выполнении пакетной работы в асинхронном режиме.</param>
		// Token: 0x0600006B RID: 107
		void OnError(int hresult);
	}
}
