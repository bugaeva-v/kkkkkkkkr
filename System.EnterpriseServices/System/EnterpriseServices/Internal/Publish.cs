using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Публикует COM-интерфейсы для приложений COM+ с включенным SOAP.</summary>
	// Token: 0x02000069 RID: 105
	[Guid("d8013eef-730b-45e2-ba24-874b7242c425")]
	public class Publish : IComSoapPublisher
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.Internal.Publish" />.</summary>
		// Token: 0x0600018D RID: 397 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public Publish()
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает почтовый ящик приложения COM+ с включенным SOAP по заданному URL-адресу. Реализован не полностью.</summary>
		/// <param name="RootMailServer">URL-адрес корневого почтового сервера.</param>
		/// <param name="MailBox">Создаваемый почтовый ящик.</param>
		/// <param name="SmtpName">Когда этот метод возвращает управление, данный параметр содержит имя сервера SMTP, содержащего почтовый ящик.</param>
		/// <param name="Domain">Когда этот метод возвращает управление, данный параметр содержит домен SMTP-сервера.</param>
		/// <param name="PhysicalPath">Когда этот метод возвращает управление, данный параметр содержит путь к почтовому ящику в файловой системе.</param>
		/// <param name="Error">Когда этот метод возвращает управление, данный параметр содержит сообщение об ошибке в случае ее возникновения.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x0600018E RID: 398 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void CreateMailBox(string RootMailServer, string MailBox, out string SmtpName, out string Domain, out string PhysicalPath, out string Error)
		{
			throw new NotImplementedException();
		}

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
		// Token: 0x0600018F RID: 399 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void CreateVirtualRoot(string Operation, string FullUrl, out string BaseUrl, out string VirtualRoot, out string PhysicalPath, out string Error)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет почтовый ящик приложения COM+ с включенным SOAP по заданному URL-адресу. Реализован не полностью.</summary>
		/// <param name="RootMailServer">URL-адрес корневого почтового сервера.</param>
		/// <param name="MailBox">Удаляемый почтовый ящик.</param>
		/// <param name="Error">Когда этот метод возвращает управление, данный параметр содержит сообщение об ошибке в случае ее возникновения.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x06000190 RID: 400 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void DeleteMailBox(string RootMailServer, string MailBox, out string Error)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет виртуальный корень приложения COM+ с включенным SOAP. Реализован не полностью.</summary>
		/// <param name="RootWebServer">Корневой веб-сервер.</param>
		/// <param name="FullUrl">Полный URL-адрес виртуального корня.</param>
		/// <param name="Error">Когда этот метод возвращает управление, данный параметр содержит сообщение об ошибке в случае ее возникновения.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x06000191 RID: 401 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void DeleteVirtualRoot(string RootWebServer, string FullUrl, out string Error)
		{
			throw new NotImplementedException();
		}

		/// <summary>Помещает сборку в глобальный кэш сборок.</summary>
		/// <param name="AssemblyPath">Путь файловой системы для сборки.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x06000192 RID: 402 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void GacInstall(string AssemblyPath)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет сборку из глобального кэша сборок.</summary>
		/// <param name="AssemblyPath">Путь файловой системы для сборки.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.  
		/// -или- 
		/// У вызывающего объекта отсутствует необходимое разрешение на обнаружение пути.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="AssemblyPath" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="AssemblyPath" /> пуст.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="AssemblyPath" /> не найден.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Сборка или модуль был загружен дважды с двумя разными свидетельствами.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="AssemblyPath" /> не является допустимой сборкой.</exception>
		// Token: 0x06000193 RID: 403 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void GacRemove(string AssemblyPath)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает полный путь для созданной подписанной сборки со строгим именем в каталоге SoapCache.</summary>
		/// <param name="TypeLibPath">Путь к файлу, содержащему библиотеку типов.</param>
		/// <param name="CachePath">Когда этот метод возвращает управление, данный параметр содержит имя каталога SoapCache.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="TypeLibPath" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.ArgumentException">Имя файла является пустой строкой, содержит только пробелы или недопустимые символы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Отказано в доступе к <paramref name="TypeLibPath" />.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">Указанный путь, имя файла или оба значения превышают максимальную длину, заданную в системе.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="TypeLibPath" /> содержит двоеточие (:) в середине строки.</exception>
		// Token: 0x06000194 RID: 404 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void GetAssemblyNameForCache(string TypeLibPath, out string CachePath)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает путь к каталогу для хранения файлов конфигурации клиента.</summary>
		/// <param name="CreateDir">Укажите <see langword="true" />, чтобы создать каталог, или <see langword="false" />, чтобы возвратить путь, не создавая каталог.</param>
		/// <returns>Путь к каталогу, содержащему файлы конфигурации.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06000195 RID: 405 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static string GetClientPhysicalPath(bool CreateDir)
		{
			throw new NotImplementedException();
		}

		/// <summary>Просматривает сборку и возвращает имя типа, которое соответствует идентификатору ProgID.</summary>
		/// <param name="AssemblyPath">Путь файловой системы для сборки.</param>
		/// <param name="ProgId">Программный идентификатор класса.</param>
		/// <returns>Имя типа, соответствующее идентификатору ProgID.</returns>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		// Token: 0x06000196 RID: 406 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string GetTypeNameFromProgId(string AssemblyPath, string ProgId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Анализирует URL-адрес и возвращает базовый URL-адрес и виртуальный корень.</summary>
		/// <param name="FullUrl">Полный URL-адрес виртуального корня.</param>
		/// <param name="BaseUrl">Когда этот метод возвращает управление, данный параметр содержит базовый URL-адрес.</param>
		/// <param name="VirtualRoot">Когда этот метод возвращает управление, данный параметр содержит имя виртуального корня.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="FullUrl" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">При преобразовании имени локального узла возникает ошибка.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код не имеет разрешения на доступ к сведениям DNS.</exception>
		/// <exception cref="T:System.UriFormatException">Параметр <paramref name="FullUrl" /> пуст.  
		/// -или- 
		/// Схема, указанная в параметре <paramref name="FullUrl" />, является недопустимой.  
		/// -или- 
		///  <paramref name="FullUrl" /> содержит слишком много знаков косой черты.  
		/// -или- 
		/// Пароль, указанный в параметре <paramref name="FullUrl" />, является недопустимым.  
		/// -или- 
		/// Имя узла, указанное в параметре <paramref name="FullUrl" />, является недопустимым.  
		/// -или- 
		/// Имя файла, указанное в параметре <paramref name="FullUrl" />, является недопустимым.</exception>
		// Token: 0x06000197 RID: 407 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static void ParseUrl(string FullUrl, out string BaseUrl, out string VirtualRoot)
		{
			throw new NotImplementedException();
		}

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
		// Token: 0x06000198 RID: 408 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void ProcessClientTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string VRoot, string BaseUrl, string Mode, string Transport, out string AssemblyName, out string TypeName, out string Error)
		{
			throw new NotImplementedException();
		}

		/// <summary>Обрабатывает библиотеку типов сервера, добавляя или удаляя записи компонентов в файлах Web.config и Default.disco. При необходимости создает прокси.</summary>
		/// <param name="ProgId">Программный идентификатор класса.</param>
		/// <param name="SrcTlbPath">Путь к файлу, содержащему библиотеку типов.</param>
		/// <param name="PhysicalPath">Каталог веб-приложения.</param>
		/// <param name="Operation">Выполняемая операция.</param>
		/// <param name="strAssemblyName">Когда этот метод возвращает управление, данный параметр содержит отображаемое имя сборки.</param>
		/// <param name="TypeName">Когда этот метод возвращает управление, данный параметр содержит полное имя типа сборки.</param>
		/// <param name="Error">Когда этот метод возвращает управление, данный параметр содержит сообщение об ошибке в случае ее возникновения.</param>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.EnterpriseServices.ServicedComponentException">Параметр <paramref name="SrcTlbPath" /> ссылается на библиотеку scrobj.dll, поэтому SOAP-публикация компонентов скриптов не поддерживается.</exception>
		// Token: 0x06000199 RID: 409 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void ProcessServerTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string Operation, out string strAssemblyName, out string TypeName, out string Error)
		{
			throw new NotImplementedException();
		}

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
		// Token: 0x0600019A RID: 410 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void RegisterAssembly(string AssemblyPath)
		{
			throw new NotImplementedException();
		}

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
		// Token: 0x0600019B RID: 411 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void UnRegisterAssembly(string AssemblyPath)
		{
			throw new NotImplementedException();
		}
	}
}
