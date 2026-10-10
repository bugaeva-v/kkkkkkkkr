using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Создает и удаляет виртуальные корни IIS 6.0.</summary>
	// Token: 0x02000063 RID: 99
	[Guid("d8013ef1-730b-45e2-ba24-874b7242c425")]
	public class IISVirtualRoot : IComSoapIISVRoot
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.Internal.IISVirtualRoot" />.</summary>
		// Token: 0x0600017F RID: 383 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public IISVirtualRoot()
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает виртуальный корень IIS.</summary>
		/// <param name="RootWeb">Строка со значением <c>"IIS://localhost/W3SVC/1/ROOT"</c>, представляющая корневой веб-сервер.</param>
		/// <param name="inPhysicalDirectory">Физический путь к виртуальному корню, соответствующий параметру <paramref name="PhysicalPath" /> метода <see cref="M:System.EnterpriseServices.Internal.Publish.CreateVirtualRoot(System.String,System.String,System.String@,System.String@,System.String@,System.String@)" />.</param>
		/// <param name="VirtualDirectory">Имя виртуального корня, соответствующее параметру <paramref name="VirtualRoot" /> метода <see cref="M:System.EnterpriseServices.Internal.Publish.CreateVirtualRoot(System.String,System.String,System.String@,System.String@,System.String@,System.String@)" />.</param>
		/// <param name="Error">Строка, в которую можно записать сообщение об ошибке.</param>
		// Token: 0x06000180 RID: 384 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void Create(string RootWeb, string inPhysicalDirectory, string VirtualDirectory, out string Error)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет виртуальный корень IIS.</summary>
		/// <param name="RootWeb">Корневой веб-сервер, заданный параметром <paramref name="RootWebServer" /> метода <see cref="M:System.EnterpriseServices.Internal.IComSoapPublisher.DeleteVirtualRoot(System.String,System.String,System.String@)" />.</param>
		/// <param name="PhysicalDirectory">Физический путь к виртуальному корню.</param>
		/// <param name="VirtualDirectory">Имя виртуального корня.</param>
		/// <param name="Error">Строка, в которую можно записать сообщение об ошибке.</param>
		// Token: 0x06000181 RID: 385 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void Delete(string RootWeb, string PhysicalDirectory, string VirtualDirectory, out string Error)
		{
			throw new NotImplementedException();
		}
	}
}
