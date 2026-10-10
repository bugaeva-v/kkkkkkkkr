using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Публикует на серверах зашифрованные виртуальные корни SOAP, прошедшие проверку подлинности.</summary>
	// Token: 0x02000067 RID: 103
	[Guid("A31B6577-71D2-4344-AEDF-ADC1B0DC5347")]
	public interface ISoapServerVRoot
	{
		/// <summary>Создает виртуальный корень SOAP с параметрами безопасности.</summary>
		/// <param name="rootWebServer">Корневой веб-сервер.</param>
		/// <param name="inBaseUrl">Базовый URL-адрес, содержащий виртуальный корень.</param>
		/// <param name="inVirtualRoot">Имя виртуального корня.</param>
		/// <param name="homePage">
		///   <see langword="true" />, если свойство <see langword="EnableDefaultDoc" /> должно быть установлено, в противном случае — <see langword="false" />.</param>
		/// <param name="discoFile">
		///   <see langword="true" />, если должен быть создан используемый по умолчанию файл обнаружения; <see langword="false" />, если файл обнаружения не нужен. Если задано <see langword="false" /> и существует файл Default.disco, этот файл удаляется.</param>
		/// <param name="secureSockets">
		///   <see langword="true" />, если требуется SSL-шифрование; в противном случае — <see langword="false" />.</param>
		/// <param name="authentication">Укажите "anonymous", если не используется проверка подлинности (анонимный пользователь). В противном случае укажите пустую строку.</param>
		/// <param name="operation">Не используется. Укажите <see langword="null" /> в качестве этого параметра.</param>
		/// <param name="baseUrl">Когда этот метод возвращает управление, данный параметр содержит базовый URL-адрес.</param>
		/// <param name="virtualRoot">Когда этот метод возвращает управление, данный параметр содержит имя виртуального корня.</param>
		/// <param name="physicalPath">Когда этот метод возвращает управление, данный параметр содержит дисковый адрес каталога виртуального корня.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Служебная программа SOAP недоступна.</exception>
		// Token: 0x06000187 RID: 391
		[DispId(1)]
		void CreateVirtualRootEx([MarshalAs(UnmanagedType.BStr)] string rootWebServer, [MarshalAs(UnmanagedType.BStr)] string inBaseUrl, [MarshalAs(UnmanagedType.BStr)] string inVirtualRoot, [MarshalAs(UnmanagedType.BStr)] string homePage, [MarshalAs(UnmanagedType.BStr)] string discoFile, [MarshalAs(UnmanagedType.BStr)] string secureSockets, [MarshalAs(UnmanagedType.BStr)] string authentication, [MarshalAs(UnmanagedType.BStr)] string operation, [MarshalAs(UnmanagedType.BStr)] out string baseUrl, [MarshalAs(UnmanagedType.BStr)] out string virtualRoot, [MarshalAs(UnmanagedType.BStr)] out string physicalPath);

		/// <summary>Удаляет виртуальный корень. Реализован не полностью.</summary>
		/// <param name="rootWebServer">Корневой веб-сервер.</param>
		/// <param name="baseUrl">Базовый URL-адрес, содержащий виртуальный корень.</param>
		/// <param name="virtualRoot">Имя виртуального корня.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Служебная программа SOAP недоступна.</exception>
		/// <exception cref="T:System.EnterpriseServices.ServicedComponentException">Вызов для определения системного каталога не выполнен.</exception>
		// Token: 0x06000188 RID: 392
		[DispId(2)]
		void DeleteVirtualRootEx([MarshalAs(UnmanagedType.BStr)] string rootWebServer, [MarshalAs(UnmanagedType.BStr)] string baseUrl, [MarshalAs(UnmanagedType.BStr)] string virtualRoot);

		/// <summary>Возвращает состояние безопасности существующего виртуального корня SOAP.</summary>
		/// <param name="rootWebServer">Корневой веб-сервер.</param>
		/// <param name="inBaseUrl">Базовый URL-адрес, содержащий виртуальный корень.</param>
		/// <param name="inVirtualRoot">Имя виртуального корня.</param>
		/// <param name="exists">Когда этот метод возвращает управление, данный параметр содержит <see langword="true" />, если виртуальный каталог существует, в противном случае — <see langword="false" />.</param>
		/// <param name="secureSockets">Когда этот метод возвращает управление, данный параметр содержит <see langword="true" />, если требуется SSL-шифрование, в противном случае — <see langword="false" />.</param>
		/// <param name="windowsAuth">Когда этот метод возвращает управление, данный параметр содержит <see langword="true" />, если установлена проверка подлинности Windows, в противном случае — <see langword="false" />.</param>
		/// <param name="anonymous">Когда этот метод возвращает управление, данный параметр содержит <see langword="true" />, если не установлена проверка подлинности (анонимный пользователь), в противном случае — <see langword="false" />.</param>
		/// <param name="homePage">Когда этот метод возвращает управление, данный параметр содержит <see langword="true" />, если свойство <see langword="EnableDefaultDoc" /> каталога виртуального корня установлено, в противном случае — <see langword="false" />.</param>
		/// <param name="discoFile">Когда этот метод возвращает управление, данный параметр содержит <see langword="true" />, если файл Default.disco существует, в противном случае — <see langword="false" />.</param>
		/// <param name="physicalPath">Когда этот метод возвращает управление, данный параметр содержит дисковый адрес каталога виртуального корня.</param>
		/// <param name="baseUrl">Когда этот метод возвращает управление, данный параметр содержит базовый URL-адрес.</param>
		/// <param name="virtualRoot">Когда этот метод возвращает управление, данный параметр содержит имя виртуального корня.</param>
		// Token: 0x06000189 RID: 393
		[DispId(3)]
		void GetVirtualRootStatus([MarshalAs(UnmanagedType.BStr)] string rootWebServer, [MarshalAs(UnmanagedType.BStr)] string inBaseUrl, [MarshalAs(UnmanagedType.BStr)] string inVirtualRoot, [MarshalAs(UnmanagedType.BStr)] out string exists, [MarshalAs(UnmanagedType.BStr)] out string secureSockets, [MarshalAs(UnmanagedType.BStr)] out string windowsAuth, [MarshalAs(UnmanagedType.BStr)] out string anonymous, [MarshalAs(UnmanagedType.BStr)] out string homePage, [MarshalAs(UnmanagedType.BStr)] out string discoFile, [MarshalAs(UnmanagedType.BStr)] out string physicalPath, [MarshalAs(UnmanagedType.BStr)] out string baseUrl, [MarshalAs(UnmanagedType.BStr)] out string virtualRoot);
	}
}
