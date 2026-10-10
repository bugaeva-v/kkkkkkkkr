using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Импортирует зашифрованные прокси клиентов SOAP, прошедшие проверку подлинности.</summary>
	// Token: 0x02000065 RID: 101
	[Guid("E7F0F021-9201-47e4-94DA-1D1416DEC27A")]
	public interface ISoapClientImport
	{
		/// <summary>Создает клиентский файл конфигурации службы удаленного взаимодействия .NET, содержащий параметры безопасности и проверки подлинности.</summary>
		/// <param name="progId">Программный идентификатор класса. Если задана пустая строка (""), данный метод возвращает управление, не выполняя никаких действий.</param>
		/// <param name="virtualRoot">Имя виртуального корня.</param>
		/// <param name="baseUrl">Базовый URL-адрес, содержащий виртуальный корень.</param>
		/// <param name="authentication">Тип используемой проверки подлинности ASP.NET.</param>
		/// <param name="assemblyName">Имя сборки.</param>
		/// <param name="typeName">Имя типа.</param>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06000184 RID: 388
		[DispId(1)]
		void ProcessClientTlbEx([MarshalAs(UnmanagedType.BStr)] string progId, [MarshalAs(UnmanagedType.BStr)] string virtualRoot, [MarshalAs(UnmanagedType.BStr)] string baseUrl, [MarshalAs(UnmanagedType.BStr)] string authentication, [MarshalAs(UnmanagedType.BStr)] string assemblyName, [MarshalAs(UnmanagedType.BStr)] string typeName);
	}
}
