using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Импортирует зашифрованные прокси клиентов SOAP, прошедшие проверку подлинности. Этот класс не наследуется.</summary>
	// Token: 0x0200006B RID: 107
	[Guid("346D5B9F-45E1-45c0-AADF-1B7D221E9063")]
	public sealed class SoapClientImport : ISoapClientImport
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.Internal.SoapClientImport" />.</summary>
		// Token: 0x0600019F RID: 415 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public SoapClientImport()
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает клиентский файл конфигурации службы удаленного взаимодействия .NET, содержащий параметры безопасности и проверки подлинности.</summary>
		/// <param name="progId">Программный идентификатор класса. Если задана пустая строка (""), данный метод возвращает управление, не выполняя никаких действий.</param>
		/// <param name="virtualRoot">Имя виртуального корня.</param>
		/// <param name="baseUrl">Базовый URL-адрес, содержащий виртуальный корень.</param>
		/// <param name="authentication">Тип используемой проверки подлинности ASP.NET.</param>
		/// <param name="assemblyName">Имя сборки.</param>
		/// <param name="typeName">Имя типа.</param>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060001A0 RID: 416 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void ProcessClientTlbEx(string progId, string virtualRoot, string baseUrl, string authentication, string assemblyName, string typeName)
		{
			throw new NotImplementedException();
		}
	}
}
