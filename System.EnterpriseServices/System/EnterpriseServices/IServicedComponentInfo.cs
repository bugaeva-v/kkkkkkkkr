using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Реализуется классом <see cref="T:System.EnterpriseServices.ServicedComponent" /> для получения сведений о компоненте посредством метода <see cref="M:System.EnterpriseServices.IServicedComponentInfo.GetComponentInfo(System.Int32@,System.String[]@)" />.</summary>
	// Token: 0x0200002A RID: 42
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8165B19E-8D3A-4d0b-80C8-97DE310DB583")]
	public interface IServicedComponentInfo
	{
		/// <summary>Получает определенную информацию об экземпляре класса <see cref="T:System.EnterpriseServices.ServicedComponent" />.</summary>
		/// <param name="infoMask">Битовая маска, где 0x00000001 — ключ для идентификатора обслуживаемого компонента, 0x00000002 — ключ для идентификатора домена приложения, а 0x00000004 — ключ для удаленного URI обслуживаемого компонента.</param>
		/// <param name="infoArray">Строковый массив, который может содержать любые или все из следующих элементов: идентификатор процесса обслуживаемого компонента, идентификатор домена приложения и удаленный URI обслуживаемого компонента.</param>
		// Token: 0x06000088 RID: 136
		void GetComponentInfo(ref int infoMask, out string[] infoArray);
	}
}
