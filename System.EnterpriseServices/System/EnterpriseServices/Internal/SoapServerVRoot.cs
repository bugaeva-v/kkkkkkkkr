using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Публикует на серверах зашифрованные виртуальные корни SOAP, прошедшие проверку подлинности. Этот класс не наследуется.</summary>
	// Token: 0x0200006D RID: 109
	[Guid("CAA817CC-0C04-4d22-A05C-2B7E162F4E8F")]
	public sealed class SoapServerVRoot : ISoapServerVRoot
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.Internal.SoapServerVRoot" />.</summary>
		// Token: 0x060001A4 RID: 420 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public SoapServerVRoot()
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает виртуальный корень SOAP с параметрами безопасности.</summary>
		/// <param name="rootWebServer">Корневой веб-сервер. По умолчанию используется "IIS://localhost/W3SVC/1/ROOT".</param>
		/// <param name="inBaseUrl">Базовый URL-адрес, содержащий виртуальный корень.</param>
		/// <param name="inVirtualRoot">Имя виртуального корня.</param>
		/// <param name="homePage">URL-адрес домашней страницы.</param>
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
		// Token: 0x060001A5 RID: 421 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void CreateVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot, string homePage, string discoFile, string secureSockets, string authentication, string operation, out string baseUrl, out string virtualRoot, out string physicalPath)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет виртуальный корень. Реализован не полностью.</summary>
		/// <param name="rootWebServer">Корневой веб-сервер. По умолчанию используется "IIS://localhost/W3SVC/1/ROOT".</param>
		/// <param name="inBaseUrl">Базовый URL-адрес, содержащий виртуальный корень.</param>
		/// <param name="inVirtualRoot">Имя виртуального корня.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Служебная программа SOAP недоступна.</exception>
		/// <exception cref="T:System.EnterpriseServices.ServicedComponentException">Вызов для получения системного каталога не выполнен.</exception>
		// Token: 0x060001A6 RID: 422 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void DeleteVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает состояние безопасности существующего виртуального корня SOAP.</summary>
		/// <param name="RootWebServer">Корневой веб-сервер. По умолчанию используется "IIS://localhost/W3SVC/1/ROOT".</param>
		/// <param name="inBaseUrl">Базовый URL-адрес, содержащий виртуальный корень.</param>
		/// <param name="inVirtualRoot">Имя виртуального корня.</param>
		/// <param name="Exists">Когда этот метод возвращает управление, данный параметр содержит <see langword="true" />, если виртуальный каталог существует, в противном случае — <see langword="false" />.</param>
		/// <param name="SSL">Когда этот метод возвращает управление, данный параметр содержит <see langword="true" />, если требуется SSL-шифрование, в противном случае — <see langword="false" />.</param>
		/// <param name="WindowsAuth">Когда этот метод возвращает управление, данный параметр содержит <see langword="true" />, если установлена проверка подлинности Windows, в противном случае — <see langword="false" />.</param>
		/// <param name="Anonymous">Когда этот метод возвращает управление, данный параметр содержит <see langword="true" />, если не установлена проверка подлинности (анонимный пользователь), в противном случае — <see langword="false" />.</param>
		/// <param name="HomePage">Когда этот метод возвращает управление, данный параметр содержит <see langword="true" />, если свойство <see langword="EnableDefaultDoc" /> виртуального корня установлено, в противном случае — <see langword="false" />.</param>
		/// <param name="DiscoFile">Когда этот метод возвращает управление, данный параметр содержит <see langword="true" />, если файл Default.disco существует, в противном случае — <see langword="false" />.</param>
		/// <param name="PhysicalPath">Когда этот метод возвращает управление, данный параметр содержит дисковый адрес каталога виртуального корня.</param>
		/// <param name="BaseUrl">Когда этот метод возвращает управление, данный параметр содержит базовый URL-адрес.</param>
		/// <param name="VirtualRoot">Когда этот метод возвращает управление, данный параметр содержит имя виртуального корня.</param>
		// Token: 0x060001A7 RID: 423 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void GetVirtualRootStatus(string RootWebServer, string inBaseUrl, string inVirtualRoot, out string Exists, out string SSL, out string WindowsAuth, out string Anonymous, out string HomePage, out string DiscoFile, out string PhysicalPath, out string BaseUrl, out string VirtualRoot)
		{
			throw new NotImplementedException();
		}
	}
}
