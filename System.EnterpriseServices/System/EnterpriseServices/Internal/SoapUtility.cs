using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Предоставляет служебные программы поддержки экспорта прокси приложений COM+ с включенным SOAP с помощью сервера, а также импорта прокси клиентом. Этот класс не наследуется.</summary>
	// Token: 0x0200006E RID: 110
	[Guid("5F9A955F-AA55-4127-A32B-33496AA8A44E")]
	public sealed class SoapUtility : ISoapUtility
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.Internal.SoapUtility" />.</summary>
		// Token: 0x060001A8 RID: 424 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public SoapUtility()
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает путь к каталогу bin виртуального корня SOAP.</summary>
		/// <param name="rootWebServer">Корневой веб-сервер.</param>
		/// <param name="inBaseUrl">Базовый URL-адрес.</param>
		/// <param name="inVirtualRoot">Имя виртуального корня.</param>
		/// <param name="binPath">Когда этот метод возвращает управление, данный параметр содержит путь к файлу для каталога bin в виртуальном корне SOAP.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Служебная программа SOAP недоступна.</exception>
		/// <exception cref="T:System.EnterpriseServices.ServicedComponentException">Вызов для получения системного каталога не выполнен.</exception>
		// Token: 0x060001A9 RID: 425 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void GetServerBinPath(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string binPath)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает путь к виртуальному корню SOAP.</summary>
		/// <param name="rootWebServer">Корневой веб-сервер.</param>
		/// <param name="inBaseUrl">Базовый URL-адрес.</param>
		/// <param name="inVirtualRoot">Имя виртуального корня.</param>
		/// <param name="physicalPath">Когда этот метод возвращает управление, данный параметр содержит путь к файлу для виртуального корня SOAP.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Служебная программа SOAP недоступна.</exception>
		/// <exception cref="T:System.EnterpriseServices.ServicedComponentException">Вызов для получения системного каталога не выполнен.</exception>
		// Token: 0x060001AA RID: 426 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void GetServerPhysicalPath(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string physicalPath)
		{
			throw new NotImplementedException();
		}

		/// <summary>Проверяет наличие зашифрованных интерфейсов SOAP, прошедших проверку подлинности.</summary>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Служебная программа SOAP недоступна.</exception>
		// Token: 0x060001AB RID: 427 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void Present()
		{
			throw new NotImplementedException();
		}
	}
}
