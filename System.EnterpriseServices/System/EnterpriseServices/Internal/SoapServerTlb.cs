using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Обрабатывает на серверах зашифрованные SOAP-компоненты, прошедшие проверку подлинности. Этот класс не наследуется.</summary>
	// Token: 0x0200006C RID: 108
	[Guid("F6B6768F-F99E-4152-8ED2-0412F78517FB")]
	public sealed class SoapServerTlb : ISoapServerTlb
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.Internal.SoapServerTlb" />.</summary>
		// Token: 0x060001A1 RID: 417 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public SoapServerTlb()
		{
			throw new NotImplementedException();
		}

		/// <summary>Добавляет записи для библиотеки типов сервера в файлы Web.config и Default.disco в зависимости от параметров безопасности и при необходимости создает прокси.</summary>
		/// <param name="progId">Программный идентификатор класса.</param>
		/// <param name="classId">Идентификатор класса (CLSID) библиотеки типов.</param>
		/// <param name="interfaceId">IID библиотеки типов.</param>
		/// <param name="srcTlbPath">Путь к файлу, содержащему библиотеку типов.</param>
		/// <param name="rootWebServer">Корневой веб-сервер.</param>
		/// <param name="inBaseUrl">Базовый URL-адрес, содержащий виртуальный корень.</param>
		/// <param name="inVirtualRoot">Имя виртуального корня.</param>
		/// <param name="clientActivated">
		///   <see langword="true" />, если клиент активирован, в противном случае — <see langword="false" />.</param>
		/// <param name="wellKnown">
		///   <see langword="true" />, если это известный объект, в противном случае — <see langword="false" />.</param>
		/// <param name="discoFile">
		///   <see langword="true" />, если это файл обнаружения, в противном случае — <see langword="false" />.</param>
		/// <param name="operation">Выполняемая операция. Укажите "delete" или пустую строку.</param>
		/// <param name="strAssemblyName">Когда этот метод возвращает управление, данный параметр содержит имя сборки.</param>
		/// <param name="typeName">Когда этот метод возвращает управление, данный параметр содержит тип сборки.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Служебная программа SOAP недоступна.</exception>
		/// <exception cref="T:System.EnterpriseServices.ServicedComponentException">Вызов для получения системного каталога не выполнен.</exception>
		// Token: 0x060001A2 RID: 418 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void AddServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string inBaseUrl, string inVirtualRoot, string clientActivated, string wellKnown, string discoFile, string operation, out string strAssemblyName, out string typeName)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет записи для библиотеки типов сервера из файлов Web.config и Default.disco в зависимости от параметров безопасности.</summary>
		/// <param name="progId">Программный идентификатор класса.</param>
		/// <param name="classId">Идентификатор класса (CLSID) библиотеки типов.</param>
		/// <param name="interfaceId">IID библиотеки типов.</param>
		/// <param name="srcTlbPath">Путь к файлу, содержащему библиотеку типов.</param>
		/// <param name="rootWebServer">Корневой веб-сервер.</param>
		/// <param name="baseUrl">Базовый URL-адрес, содержащий виртуальный корень.</param>
		/// <param name="virtualRoot">Имя виртуального корня.</param>
		/// <param name="operation">Не используется. Укажите <see langword="null" /> в качестве этого параметра.</param>
		/// <param name="assemblyName">Имя сборки.</param>
		/// <param name="typeName">Тип сборки.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Служебная программа SOAP недоступна.</exception>
		// Token: 0x060001A3 RID: 419 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void DeleteServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string baseUrl, string virtualRoot, string operation, string assemblyName, string typeName)
		{
			throw new NotImplementedException();
		}
	}
}
