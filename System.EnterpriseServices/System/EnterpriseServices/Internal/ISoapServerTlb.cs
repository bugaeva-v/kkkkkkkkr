using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Обрабатывает на серверах зашифрованные SOAP-компоненты, прошедшие проверку подлинности.</summary>
	// Token: 0x02000066 RID: 102
	[Guid("1E7BA9F7-21DB-4482-929E-21BDE2DFE51C")]
	public interface ISoapServerTlb
	{
		/// <summary>Добавляет записи для библиотеки типов сервера в файлы Web.config и Default.disco в зависимости от параметров безопасности и при необходимости создает прокси.</summary>
		/// <param name="progId">Программный идентификатор класса.</param>
		/// <param name="classId">Идентификатор класса (CLSID) библиотеки типов.</param>
		/// <param name="interfaceId">IID библиотеки типов.</param>
		/// <param name="srcTlbPath">Путь к файлу, содержащему библиотеку типов.</param>
		/// <param name="rootWebServer">Корневой веб-сервер.</param>
		/// <param name="baseUrl">Базовый URL-адрес, содержащий виртуальный корень.</param>
		/// <param name="virtualRoot">Имя виртуального корня.</param>
		/// <param name="clientActivated">
		///   <see langword="true" />, если клиент активирован, в противном случае — <see langword="false" />.</param>
		/// <param name="wellKnown">
		///   <see langword="true" />, если это известный объект, в противном случае — <see langword="false" />.</param>
		/// <param name="discoFile">
		///   <see langword="true" />, если это файл обнаружения, в противном случае — <see langword="false" />.</param>
		/// <param name="operation">Выполняемая операция. Укажите "delete" или пустую строку.</param>
		/// <param name="assemblyName">Когда этот метод возвращает управление, данный параметр содержит имя сборки.</param>
		/// <param name="typeName">Когда этот метод возвращает управление, данный параметр содержит тип сборки.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Служебная программа SOAP недоступна.</exception>
		/// <exception cref="T:System.EnterpriseServices.ServicedComponentException">Вызов для получения системного каталога не выполнен.</exception>
		// Token: 0x06000185 RID: 389
		[DispId(1)]
		void AddServerTlb([MarshalAs(UnmanagedType.BStr)] string progId, [MarshalAs(UnmanagedType.BStr)] string classId, [MarshalAs(UnmanagedType.BStr)] string interfaceId, [MarshalAs(UnmanagedType.BStr)] string srcTlbPath, [MarshalAs(UnmanagedType.BStr)] string rootWebServer, [MarshalAs(UnmanagedType.BStr)] string baseUrl, [MarshalAs(UnmanagedType.BStr)] string virtualRoot, [MarshalAs(UnmanagedType.BStr)] string clientActivated, [MarshalAs(UnmanagedType.BStr)] string wellKnown, [MarshalAs(UnmanagedType.BStr)] string discoFile, [MarshalAs(UnmanagedType.BStr)] string operation, [MarshalAs(UnmanagedType.BStr)] out string assemblyName, [MarshalAs(UnmanagedType.BStr)] out string typeName);

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
		// Token: 0x06000186 RID: 390
		[DispId(2)]
		void DeleteServerTlb([MarshalAs(UnmanagedType.BStr)] string progId, [MarshalAs(UnmanagedType.BStr)] string classId, [MarshalAs(UnmanagedType.BStr)] string interfaceId, [MarshalAs(UnmanagedType.BStr)] string srcTlbPath, [MarshalAs(UnmanagedType.BStr)] string rootWebServer, [MarshalAs(UnmanagedType.BStr)] string baseUrl, [MarshalAs(UnmanagedType.BStr)] string virtualRoot, [MarshalAs(UnmanagedType.BStr)] string operation, [MarshalAs(UnmanagedType.BStr)] string assemblyName, [MarshalAs(UnmanagedType.BStr)] string typeName);
	}
}
