using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Публикует COM-интерфейсы для приложений COM+ с включенным SOAP.</summary>
	// Token: 0x02000062 RID: 98
	[Guid("d8013eee-730b-45e2-ba24-874b7242c425")]
	public interface IComSoapPublisher
	{
		/// <summary>Создает почтовый ящик приложения COM+ с включенным SOAP по заданному URL-адресу. Реализован не полностью.</summary>
		/// <param name="RootMailServer">URL-адрес корневого почтового сервера.</param>
		/// <param name="MailBox">Создаваемый почтовый ящик.</param>
		/// <param name="SmtpName">Когда этот метод возвращает управление, данный параметр содержит имя сервера SMTP, содержащего почтовый ящик.</param>
		/// <param name="Domain">Когда этот метод возвращает управление, данный параметр содержит домен SMTP-сервера.</param>
		/// <param name="PhysicalPath">Когда этот метод возвращает управление, данный параметр содержит путь к почтовому ящику в файловой системе.</param>
		/// <param name="Error">Когда этот метод возвращает управление, данный параметр содержит сообщение об ошибке в случае ее возникновения.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x06000173 RID: 371
		[DispId(6)]
		void CreateMailBox([MarshalAs(UnmanagedType.BStr)] string RootMailServer, [MarshalAs(UnmanagedType.BStr)] string MailBox, [MarshalAs(UnmanagedType.BStr)] out string SmtpName, [MarshalAs(UnmanagedType.BStr)] out string Domain, [MarshalAs(UnmanagedType.BStr)] out string PhysicalPath, [MarshalAs(UnmanagedType.BStr)] out string Error);

		/// <summary>Создает виртуальный корень приложения COM+ с включенным SOAP.</summary>
		/// <param name="Operation">Выполняемая операция.</param>
		/// <param name="FullUrl">Полный URL-адрес виртуального корня.</param>
		/// <param name="BaseUrl">Когда этот метод возвращает управление, данный параметр содержит базовый URL-адрес.</param>
		/// <param name="VirtualRoot">Когда этот метод возвращает управление, данный параметр содержит имя виртуального корня.</param>
		/// <param name="PhysicalPath">Когда этот метод возвращает управление, данный параметр содержит путь к файлу для виртуального корня.</param>
		/// <param name="Error">Когда этот метод возвращает управление, данный параметр содержит сообщение об ошибке в случае ее возникновения.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.  
		/// -или- 
		/// Вызывающий код не имеет разрешения на доступ к сведениям DNS.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="FullUrl" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При преобразовании имени локального узла возникает ошибка.</exception>
		/// <exception cref="T:System.UriFormatException">Параметр <paramref name="FullUrl" /> пуст.  
		/// -или- 
		/// Схема, указанная в параметре <paramref name="FullUrl" />, является недопустимой.  
		/// -или- 
		///  Адрес <paramref name="FullUrl" /> содержит более двух знаков косой черты подряд.  
		/// -или- 
		/// Пароль, указанный в параметре <paramref name="FullUrl" />, является недопустимым.  
		/// -или- 
		/// Имя узла, указанное в параметре <paramref name="FullUrl" />, является недопустимым.  
		/// -или- 
		/// Имя файла, указанное в параметре <paramref name="FullUrl" />, является недопустимым.</exception>
		// Token: 0x06000174 RID: 372
		[DispId(4)]
		void CreateVirtualRoot([MarshalAs(UnmanagedType.BStr)] string Operation, [MarshalAs(UnmanagedType.BStr)] string FullUrl, [MarshalAs(UnmanagedType.BStr)] out string BaseUrl, [MarshalAs(UnmanagedType.BStr)] out string VirtualRoot, [MarshalAs(UnmanagedType.BStr)] out string PhysicalPath, [MarshalAs(UnmanagedType.BStr)] out string Error);

		/// <summary>Удаляет почтовый ящик приложения COM+ с включенным SOAP по заданному URL-адресу. Реализован не полностью.</summary>
		/// <param name="RootMailServer">URL-адрес корневого почтового сервера.</param>
		/// <param name="MailBox">Удаляемый почтовый ящик.</param>
		/// <param name="Error">Когда этот метод возвращает управление, данный параметр содержит сообщение об ошибке в случае ее возникновения.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x06000175 RID: 373
		[DispId(7)]
		void DeleteMailBox([MarshalAs(UnmanagedType.BStr)] string RootMailServer, [MarshalAs(UnmanagedType.BStr)] string MailBox, [MarshalAs(UnmanagedType.BStr)] out string Error);

		/// <summary>Удаляет виртуальный корень приложения COM+ с включенным SOAP. Реализован не полностью.</summary>
		/// <param name="RootWebServer">Корневой веб-сервер.</param>
		/// <param name="FullUrl">Полный URL-адрес виртуального корня.</param>
		/// <param name="Error">Когда этот метод возвращает управление, данный параметр содержит сообщение об ошибке в случае ее возникновения.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x06000176 RID: 374
		[DispId(5)]
		void DeleteVirtualRoot([MarshalAs(UnmanagedType.BStr)] string RootWebServer, [MarshalAs(UnmanagedType.BStr)] string FullUrl, [MarshalAs(UnmanagedType.BStr)] out string Error);

		/// <summary>Помещает сборку в глобальный кэш сборок.</summary>
		/// <param name="AssemblyPath">Путь файловой системы для сборки.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x06000177 RID: 375
		[DispId(13)]
		void GacInstall([MarshalAs(UnmanagedType.BStr)] string AssemblyPath);

		/// <summary>Удаляет сборку из глобального кэша сборок.</summary>
		/// <param name="AssemblyPath">Путь файловой системы для сборки.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="AssemblyPath" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="AssemblyPath" /> пуст.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="AssemblyPath" /> не найден.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="AssemblyPath" /> не является допустимой сборкой.</exception>
		// Token: 0x06000178 RID: 376
		[DispId(14)]
		void GacRemove([MarshalAs(UnmanagedType.BStr)] string AssemblyPath);

		/// <summary>Возвращает полный путь для созданной подписанной сборки со строгим именем в каталоге SoapCache.</summary>
		/// <param name="TypeLibPath">Путь к файлу, содержащему библиотеку типов.</param>
		/// <param name="CachePath">Когда этот метод возвращает управление, данный параметр содержит полный путь к прокси-сборке в каталоге SoapCache.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="TypeLibPath" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">Имя файла является пустой строкой, содержит только пробелы или недопустимые символы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Отказано в доступе к <paramref name="TypeLibPath" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="TypeLibPath" /> содержит двоеточие (:) в середине строки.</exception>
		// Token: 0x06000179 RID: 377
		[DispId(15)]
		void GetAssemblyNameForCache([MarshalAs(UnmanagedType.BStr)] string TypeLibPath, [MarshalAs(UnmanagedType.BStr)] out string CachePath);

		/// <summary>Просматривает сборку и возвращает имя типа, которое соответствует идентификатору ProgID.</summary>
		/// <param name="AssemblyPath">Путь файловой системы для сборки.</param>
		/// <param name="ProgId">Программный идентификатор класса.</param>
		/// <returns>Имя типа, соответствующее идентификатору ProgID.</returns>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x0600017A RID: 378
		[DispId(10)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string GetTypeNameFromProgId([MarshalAs(UnmanagedType.BStr)] string AssemblyPath, [MarshalAs(UnmanagedType.BStr)] string ProgId);

		/// <summary>Обрабатывает клиентскую библиотеку типов, создавая файл конфигурации на стороне клиента.</summary>
		/// <param name="ProgId">Программный идентификатор класса.</param>
		/// <param name="SrcTlbPath">Путь к файлу, содержащему библиотеку типов.</param>
		/// <param name="PhysicalPath">Каталог веб-приложения.</param>
		/// <param name="VRoot">Имя виртуального корня.</param>
		/// <param name="BaseUrl">Базовый URL-адрес, содержащий виртуальный корень.</param>
		/// <param name="Mode">Режим активации.</param>
		/// <param name="Transport">Не используется. Укажите <see langword="null" /> в качестве этого параметра.</param>
		/// <param name="AssemblyName">Когда этот метод возвращает управление, данный параметр содержит отображаемое имя сборки.</param>
		/// <param name="TypeName">Когда этот метод возвращает управление, данный параметр содержит полное имя типа сборки.</param>
		/// <param name="Error">Когда этот метод возвращает управление, данный параметр содержит сообщение об ошибке в случае ее возникновения.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x0600017B RID: 379
		[DispId(9)]
		void ProcessClientTlb([MarshalAs(UnmanagedType.BStr)] string ProgId, [MarshalAs(UnmanagedType.BStr)] string SrcTlbPath, [MarshalAs(UnmanagedType.BStr)] string PhysicalPath, [MarshalAs(UnmanagedType.BStr)] string VRoot, [MarshalAs(UnmanagedType.BStr)] string BaseUrl, [MarshalAs(UnmanagedType.BStr)] string Mode, [MarshalAs(UnmanagedType.BStr)] string Transport, [MarshalAs(UnmanagedType.BStr)] out string AssemblyName, [MarshalAs(UnmanagedType.BStr)] out string TypeName, [MarshalAs(UnmanagedType.BStr)] out string Error);

		/// <summary>Обрабатывает библиотеку типов сервера, добавляя или удаляя записи компонентов в файлах Web.config и Default.disco. При необходимости создает прокси.</summary>
		/// <param name="ProgId">Программный идентификатор класса.</param>
		/// <param name="SrcTlbPath">Путь к файлу, содержащему библиотеку типов.</param>
		/// <param name="PhysicalPath">Каталог веб-приложения.</param>
		/// <param name="Operation">Выполняемая операция.</param>
		/// <param name="AssemblyName">Когда этот метод возвращает управление, данный параметр содержит отображаемое имя сборки.</param>
		/// <param name="TypeName">Когда этот метод возвращает управление, данный параметр содержит полное имя типа сборки.</param>
		/// <param name="Error">Когда этот метод возвращает управление, данный параметр содержит сообщение об ошибке в случае ее возникновения.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.EnterpriseServices.ServicedComponentException">Параметр <paramref name="SrcTlbPath" /> ссылается на библиотеку scrobj.dll, поэтому SOAP-публикация компонентов скриптов не поддерживается.</exception>
		// Token: 0x0600017C RID: 380
		[DispId(8)]
		void ProcessServerTlb([MarshalAs(UnmanagedType.BStr)] string ProgId, [MarshalAs(UnmanagedType.BStr)] string SrcTlbPath, [MarshalAs(UnmanagedType.BStr)] string PhysicalPath, [MarshalAs(UnmanagedType.BStr)] string Operation, [MarshalAs(UnmanagedType.BStr)] out string AssemblyName, [MarshalAs(UnmanagedType.BStr)] out string TypeName, [MarshalAs(UnmanagedType.BStr)] out string Error);

		/// <summary>Регистрирует сборку для COM-взаимодействия.</summary>
		/// <param name="AssemblyPath">Путь файловой системы для сборки.</param>
		/// <exception cref="T:System.EnterpriseServices.RegistrationException">Входная сборка не имеет строгого имени.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.  
		/// -или- 
		/// База кода, которая не начинается с "file://", была указана без требуемого разрешения <see cref="T:System.Net.WebPermission" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="AssemblyPath" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Параметр <paramref name="AssemblyPath" /> не найден, или не указано расширение имени файла.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="AssemblyPath" /> не является допустимой сборкой.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль были загружены дважды с двумя разными свидетельствами, или длина имени сборки превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод, помеченный с помощью атрибута <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" />, не является статическим (<see langword="static" />).  
		/// -или- 
		/// На заданном уровне иерархии атрибутом <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" /> помечено несколько методов.  
		/// -или- 
		/// Подпись метода, помеченного атрибутом <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" />, недействительна.</exception>
		// Token: 0x0600017D RID: 381
		[DispId(11)]
		void RegisterAssembly([MarshalAs(UnmanagedType.BStr)] string AssemblyPath);

		/// <summary>Отменяет регистрацию сборки для COM-взаимодействия.</summary>
		/// <param name="AssemblyPath">Путь файловой системы для сборки.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.  
		/// -или- 
		/// База кода, которая не начинается с "file://", была указана без требуемого разрешения <see cref="T:System.Net.WebPermission" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="AssemblyPath" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Параметр <paramref name="AssemblyPath" /> не найден, или не указано расширение имени файла.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="AssemblyPath" /> не является допустимой сборкой.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль были загружены дважды с двумя разными свидетельствами, или длина имени сборки превышает максимальную длину, определенную в системе.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод, помеченный с помощью атрибута <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" />, не является статическим (<see langword="static" />).  
		/// -или- 
		/// На заданном уровне иерархии атрибутом <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" /> помечено несколько методов.  
		/// -или- 
		/// Подпись метода, помеченного атрибутом <see cref="T:System.Runtime.InteropServices.ComUnregisterFunctionAttribute" />, недействительна.</exception>
		// Token: 0x0600017E RID: 382
		[DispId(12)]
		void UnRegisterAssembly([MarshalAs(UnmanagedType.BStr)] string AssemblyPath);
	}
}
