using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Определение интерфейса для создания и удаления виртуальных корней IIS 6.0.</summary>
	// Token: 0x02000060 RID: 96
	[Guid("d8013ef0-730b-45e2-ba24-874b7242c425")]
	public interface IComSoapIISVRoot
	{
		/// <summary>Создает виртуальный корень IIS.</summary>
		/// <param name="RootWeb">Корневой веб-сервер.</param>
		/// <param name="PhysicalDirectory">Физический путь к виртуальному корню, соответствующий параметру <paramref name="PhysicalPath" /> метода <see cref="M:System.EnterpriseServices.Internal.IComSoapPublisher.CreateVirtualRoot(System.String,System.String,System.String@,System.String@,System.String@,System.String@)" />.</param>
		/// <param name="VirtualDirectory">Имя виртуального корня, соответствующее параметру <paramref name="VirtualRoot" /> метода <see cref="M:System.EnterpriseServices.Internal.IComSoapPublisher.CreateVirtualRoot(System.String,System.String,System.String@,System.String@,System.String@,System.String@)" />.</param>
		/// <param name="Error">Строка, в которую можно записать сообщение об ошибке.</param>
		// Token: 0x0600016F RID: 367
		[DispId(1)]
		void Create([MarshalAs(UnmanagedType.BStr)] string RootWeb, [MarshalAs(UnmanagedType.BStr)] string PhysicalDirectory, [MarshalAs(UnmanagedType.BStr)] string VirtualDirectory, [MarshalAs(UnmanagedType.BStr)] out string Error);

		/// <summary>Удаляет виртуальный корень IIS.</summary>
		/// <param name="RootWeb">Корневой веб-сервер.</param>
		/// <param name="PhysicalDirectory">Физический путь к виртуальному корню.</param>
		/// <param name="VirtualDirectory">Имя виртуального корня.</param>
		/// <param name="Error">Строка, в которую можно записать сообщение об ошибке.</param>
		// Token: 0x06000170 RID: 368
		[DispId(2)]
		void Delete([MarshalAs(UnmanagedType.BStr)] string RootWeb, [MarshalAs(UnmanagedType.BStr)] string PhysicalDirectory, [MarshalAs(UnmanagedType.BStr)] string VirtualDirectory, [MarshalAs(UnmanagedType.BStr)] out string Error);
	}
}
