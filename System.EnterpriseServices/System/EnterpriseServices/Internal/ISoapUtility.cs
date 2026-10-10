using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Предоставляет служебные программы поддержки экспорта прокси приложений COM+ с включенным SOAP с помощью сервера, а также импорта прокси клиентом.</summary>
	// Token: 0x02000068 RID: 104
	[Guid("5AC4CB7E-F89F-429b-926B-C7F940936BF4")]
	public interface ISoapUtility
	{
		/// <summary>Возвращает путь к каталогу bin в виртуальном корне SOAP.</summary>
		/// <param name="rootWebServer">Корневой веб-сервер.</param>
		/// <param name="inBaseUrl">Базовый URL-адрес.</param>
		/// <param name="inVirtualRoot">Имя виртуального корня.</param>
		/// <param name="binPath">Когда этот метод возвращает управление, данный параметр содержит путь к файлу для каталога bin в виртуальном корне SOAP.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Служебная программа SOAP недоступна.</exception>
		/// <exception cref="T:System.EnterpriseServices.ServicedComponentException">Вызов для получения системного каталога не выполнен.</exception>
		// Token: 0x0600018A RID: 394
		[DispId(2)]
		void GetServerBinPath([MarshalAs(UnmanagedType.BStr)] string rootWebServer, [MarshalAs(UnmanagedType.BStr)] string inBaseUrl, [MarshalAs(UnmanagedType.BStr)] string inVirtualRoot, [MarshalAs(UnmanagedType.BStr)] out string binPath);

		/// <summary>Возвращает путь к виртуальному корню SOAP.</summary>
		/// <param name="rootWebServer">Корневой веб-сервер.</param>
		/// <param name="inBaseUrl">Базовый URL-адрес.</param>
		/// <param name="inVirtualRoot">Имя виртуального корня.</param>
		/// <param name="physicalPath">Когда этот метод возвращает управление, данный параметр содержит путь к файлу для виртуального корня SOAP.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Служебная программа SOAP недоступна.</exception>
		/// <exception cref="T:System.EnterpriseServices.ServicedComponentException">Вызов для получения системного каталога не выполнен.</exception>
		// Token: 0x0600018B RID: 395
		[DispId(1)]
		void GetServerPhysicalPath([MarshalAs(UnmanagedType.BStr)] string rootWebServer, [MarshalAs(UnmanagedType.BStr)] string inBaseUrl, [MarshalAs(UnmanagedType.BStr)] string inVirtualRoot, [MarshalAs(UnmanagedType.BStr)] out string physicalPath);

		/// <summary>Проверяет наличие зашифрованных интерфейсов SOAP, прошедших проверку подлинности.</summary>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Служебная программа SOAP недоступна.</exception>
		// Token: 0x0600018C RID: 396
		[DispId(3)]
		void Present();
	}
}
