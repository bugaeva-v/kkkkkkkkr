using System;
using System.Net;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Threading.Tasks;

namespace System.Xml
{
	/// <summary>
	///         Позволяет защитить другую реализацию <see cref="T:System.Xml.XmlResolver" /> путем применения программы-оболочки к объекту <see cref="T:System.Xml.XmlResolver" /> и ограничения ресурсов, доступ к которым имеет базовый объект <see cref="T:System.Xml.XmlResolver" />.
	///       </summary>
	// Token: 0x02000247 RID: 583
	[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
	[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
	public class XmlSecureResolver : XmlResolver
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlSecureResolver" /> с указанными объектом <see cref="T:System.Xml.XmlResolver" /> и URL-адресом.
		///       </summary>
		/// <param name="resolver">
		///           Сопоставитель XML, для которого создана программа-оболочка с помощью <see cref="T:System.Xml.XmlSecureResolver" />.
		///         </param>
		/// <param name="securityUrl">
		///           URL-адрес, используемый для создания объекта <see cref="T:System.Security.PermissionSet" />, который будет применен к базовому объекту <see cref="T:System.Xml.XmlResolver" />.
		///           <see cref="T:System.Xml.XmlSecureResolver" /> вызывает <see cref="M:System.Security.PermissionSet.PermitOnly" /> для созданного объекта <see cref="T:System.Security.PermissionSet" /> перед вызовом метода <see cref="M:System.Xml.XmlSecureResolver.GetEntity(System.Uri,System.String,System.Type)" /> для базового объекта <see cref="T:System.Xml.XmlResolver" />.
		///         </param>
		// Token: 0x060015AD RID: 5549 RVA: 0x00084BBB File Offset: 0x00082DBB
		public XmlSecureResolver(XmlResolver resolver, string securityUrl) : this(resolver, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlSecureResolver" /> с заданными объектами <see cref="T:System.Xml.XmlResolver" /> и <see cref="T:System.Security.Policy.Evidence" />.
		///       </summary>
		/// <param name="resolver">
		///           Сопоставитель XML, для которого создана программа-оболочка с помощью <see cref="T:System.Xml.XmlSecureResolver" />.
		///         </param>
		/// <param name="evidence">
		///           Свидетельство, используемое для создания объекта <see cref="T:System.Security.PermissionSet" />, который будет применен к базовому объекту <see cref="T:System.Xml.XmlResolver" />.
		///           <see cref="T:System.Xml.XmlSecureResolver" /> вызывает метод <see cref="M:System.Security.PermissionSet.PermitOnly" /> для созданного объекта <see cref="T:System.Security.PermissionSet" /> перед вызовом метода <see cref="M:System.Xml.XmlSecureResolver.GetEntity(System.Uri,System.String,System.Type)" /> для базового объекта <see cref="T:System.Xml.XmlResolver" />.
		///         </param>
		// Token: 0x060015AE RID: 5550 RVA: 0x00084BBB File Offset: 0x00082DBB
		public XmlSecureResolver(XmlResolver resolver, Evidence evidence) : this(resolver, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlSecureResolver" /> с заданными объектами <see cref="T:System.Xml.XmlResolver" /> и <see cref="T:System.Security.PermissionSet" />.
		///       </summary>
		/// <param name="resolver">
		///           Сопоставитель XML, для которого создана программа-оболочка с помощью <see cref="T:System.Xml.XmlSecureResolver" />.
		///         </param>
		/// <param name="permissionSet">
		///           Набор разрешений, который необходимо применить к базовому объекту <see cref="T:System.Xml.XmlResolver" />.
		///           <see cref="T:System.Xml.XmlSecureResolver" /> вызывает метод <see cref="M:System.Security.PermissionSet.PermitOnly" /> для набора разрешений перед вызовом метода <see cref="M:System.Xml.XmlSecureResolver.GetEntity(System.Uri,System.String,System.Type)" /> для базового сопоставителя XML.
		///         </param>
		// Token: 0x060015AF RID: 5551 RVA: 0x00084BC5 File Offset: 0x00082DC5
		public XmlSecureResolver(XmlResolver resolver, PermissionSet permissionSet)
		{
			this.resolver = resolver;
		}

		/// <summary>
		///         Задает учетные данные, используемые для проверки подлинности веб-запросов.
		///       </summary>
		/// <returns>
		///         Учетные данные, используемые для аутентификации веб-запросов.
		///          Объект <see cref="T:System.Xml.XmlSecureResolver" /> задает указанные учетные данные для базового объекта <see cref="T:System.Xml.XmlResolver" />.
		///          Если свойство не задано, значением по умолчанию становится <see langword="null" /> — <see cref="T:System.Xml.XmlSecureResolver" /> не имеет учетных данных пользователя.
		///       </returns>
		// Token: 0x170003D7 RID: 983
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x00084BD4 File Offset: 0x00082DD4
		public override ICredentials Credentials
		{
			set
			{
				this.resolver.Credentials = value;
			}
		}

		/// <summary>
		///         Сопоставляет код URI с объектом, содержащим фактический ресурс.
		///          Этот метод временно задает объект <see cref="T:System.Security.PermissionSet" />, созданный в конструкторе путем вызова объекта <see cref="M:System.Security.PermissionSet.PermitOnly" /> до вызова <see langword="GetEntity" /> для базового объекта <see cref="T:System.Xml.XmlResolver" />, чтобы открыть ресурс.
		///       </summary>
		/// <param name="absoluteUri">
		///           URI, возвращаемый методом <see cref="M:System.Xml.XmlSecureResolver.ResolveUri(System.Uri,System.String)" />.
		///         </param>
		/// <param name="role">
		///           В настоящий момент не используется.
		///         </param>
		/// <param name="ofObjectToReturn">
		///           Тип возвращаемого объекта.
		///            В текущей версии возвращаются только объекты <see cref="T:System.IO.Stream" />.
		///         </param>
		/// <returns>
		///         Объект, возвращенный путем вызова <see langword="GetEntity" /> для базового объекта <see cref="T:System.Xml.XmlResolver" />.
		///          Если задан тип, отличный от <see cref="T:System.IO.Stream" />, метод возвращает <see langword="null" />.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             <paramref name="ofObjectToReturn" /> не является ни <see langword="null" /> ни <see cref="T:System.IO.Stream" /> типа.
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///             Указанный URI не является абсолютным URI.
		///           </exception>
		/// <exception cref="T:System.NullReferenceException">
		///             Свойство <paramref name="absoluteUri" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Exception">
		///             Есть ошибка среды выполнения (например, прервано подключение к серверу).
		///           </exception>
		// Token: 0x060015B1 RID: 5553 RVA: 0x00084BE2 File Offset: 0x00082DE2
		public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			return this.resolver.GetEntity(absoluteUri, role, ofObjectToReturn);
		}

		/// <summary>
		///         Разрешает абсолютный URI на основе базового и относительного URI путем вызова <see langword="ResolveUri" /> для базового объекта <see cref="T:System.Xml.XmlResolver" />.
		///       </summary>
		/// <param name="baseUri">
		///           Базовый URI, используемый для разрешения относительного URI.
		///         </param>
		/// <param name="relativeUri">
		///           URI, которые нужно разрешить.
		///            URI может быть как абсолютным, так и относительным.
		///            Если URI является абсолютным, данное значение замещает значение <paramref name="baseUri" />.
		///            Если относительным, то абсолютный URI является сочетанием относительного и <paramref name="baseUri" />.
		///         </param>
		/// <returns>
		///         Абсолютный URI или значение <see langword="null" />, если относительный URI невозможно разрешить (возвращенный путем вызова <see langword="ResolveUri" /> для базового объекта <see cref="T:System.Xml.XmlResolver" />).
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Свойство <paramref name="relativeUri" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060015B2 RID: 5554 RVA: 0x00084BF2 File Offset: 0x00082DF2
		public override Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			return this.resolver.ResolveUri(baseUri, relativeUri);
		}

		/// <summary>
		///         Создает свидетельство, используя предоставленный URL-адрес.
		///       </summary>
		/// <param name="securityUrl">
		///           URL, используемый для создания свидетельства.
		///         </param>
		/// <returns>
		///         Свидетельство, созданное из предоставленного URL-адреса в соответствии с политикой по умолчанию.
		///       </returns>
		// Token: 0x060015B3 RID: 5555 RVA: 0x0001DA42 File Offset: 0x0001BC42
		public static Evidence CreateEvidenceForUrl(string securityUrl)
		{
			return null;
		}

		/// <summary>
		///         Асинхронно сопоставляет URI с объектом, содержащим фактический ресурс.
		///       </summary>
		/// <param name="absoluteUri">
		///           URI, возвращаемый методом <see cref="M:System.Xml.XmlSecureResolver.ResolveUri(System.Uri,System.String)" />.
		///         </param>
		/// <param name="role">
		///           В настоящий момент не используется.
		///         </param>
		/// <param name="ofObjectToReturn">
		///           Тип возвращаемого объекта.
		///            В текущей версии возвращаются только объекты <see cref="T:System.IO.Stream" />.
		///         </param>
		/// <returns>
		///         Объект, возвращенный путем вызова <see langword="GetEntity" /> для базового объекта <see cref="T:System.Xml.XmlResolver" />.
		///          Если задан тип, отличный от <see cref="T:System.IO.Stream" />, метод возвращает <see langword="null" />.
		///       </returns>
		// Token: 0x060015B4 RID: 5556 RVA: 0x00084C01 File Offset: 0x00082E01
		public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			return this.resolver.GetEntityAsync(absoluteUri, role, ofObjectToReturn);
		}

		// Token: 0x04001324 RID: 4900
		private XmlResolver resolver;
	}
}
