using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Поддерживает методы, которые могут быть вызваны при запуске или завершении работы компонента COM.</summary>
	// Token: 0x02000023 RID: 35
	[Guid("1113f52d-dc7f-4943-aed6-88d04027e32a")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IProcessInitializer
	{
		/// <summary>Выполняет действия для завершения работы. Вызывается при закрытии программы Dllhost.exe.</summary>
		// Token: 0x06000075 RID: 117
		void Shutdown();

		/// <summary>Выполняет инициализацию при запуске. Вызывается при запуске Dllhost.exe.</summary>
		/// <param name="punkProcessControl">В Microsoft Windows XP запускается указатель на интерфейс <see langword="IUnknown" /> компонента COM. В Microsoft Windows 2000 этот аргумент всегда имеет значение <see langword="null" />.</param>
		// Token: 0x06000076 RID: 118
		void Startup([MarshalAs(UnmanagedType.IUnknown)] [In] object punkProcessControl);
	}
}
