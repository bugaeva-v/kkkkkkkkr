using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace System.Xml
{
	/// <summary>
	///         Разрешает внешние ресурсы XML, имена которых заданы с помощью универсального кода ресурса (URI).
	///       </summary>
	// Token: 0x02000246 RID: 582
	public abstract class XmlResolver
	{
		/// <summary>
		///         При переопределении в производном классе отображает URI в объект, содержащий текущий ресурс.
		///       </summary>
		/// <param name="absoluteUri">
		///           URI, возвращаемый методом <see cref="M:System.Xml.XmlResolver.ResolveUri(System.Uri,System.String)" />.
		///         </param>
		/// <param name="role">
		///           В настоящий момент не используется.
		///         </param>
		/// <param name="ofObjectToReturn">
		///           Тип возвращаемого объекта.
		///            В текущей версии возвращаются только объекты System.IO.Stream.
		///         </param>
		/// <returns>
		///         Объект потока или значение <see langword="null" />, если в качестве типа не указан поток.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             <paramref name="ofObjectToReturn" /> не <see langword="Stream" /> типа.
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///             Указанный URI не является абсолютным URI.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="absoluteUri" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Exception">
		///             Есть ошибка среды выполнения (например, прервано подключение к серверу).
		///           </exception>
		// Token: 0x060015A7 RID: 5543
		public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

		/// <summary>
		///         Когда переопределено в производном классе, разрешает абсолютный URI из базового и относительного URI.
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
		///         Абсолютный URI или <see langword="null" /> Если невозможно разрешить относительный URI.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Свойство <paramref name="relativeUri" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060015A8 RID: 5544 RVA: 0x00084B04 File Offset: 0x00082D04
		public virtual Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			if (baseUri == null || (!baseUri.IsAbsoluteUri && baseUri.OriginalString.Length == 0))
			{
				Uri uri = new Uri(relativeUri, UriKind.RelativeOrAbsolute);
				if (!uri.IsAbsoluteUri && uri.OriginalString.Length > 0)
				{
					uri = new Uri(Path.GetFullPath(relativeUri));
				}
				return uri;
			}
			if (relativeUri == null || relativeUri.Length == 0)
			{
				return baseUri;
			}
			if (!baseUri.IsAbsoluteUri)
			{
				throw new NotSupportedException(Res.GetString("Relative URIs are not supported."));
			}
			return new Uri(baseUri, relativeUri);
		}

		/// <summary>
		///         При переопределении в производном классе задает учетные данные для проверки подлинности веб-запросов.
		///       </summary>
		/// <returns>
		///         Учетные данные, используемые для аутентификации веб-запросов.
		///          Если свойство не задано, значением по умолчанию становится <see langword="null" /> — <see langword="XmlResolver" /> не имеет учетных данных пользователя.
		///       </returns>
		// Token: 0x170003D6 RID: 982
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x0000B528 File Offset: 0x00009728
		public virtual ICredentials Credentials
		{
			set
			{
			}
		}

		/// <summary>
		///         Позволяет сопоставителю возвращает типы, отличные от <see cref="T:System.IO.Stream" />.
		///       </summary>
		/// <param name="absoluteUri">
		///           Универсальный код ресурса.
		///         </param>
		/// <param name="type">
		///           Возвращаемый тип.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <paramref name="type" /> поддерживается; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x060015AA RID: 5546 RVA: 0x00084B87 File Offset: 0x00082D87
		public virtual bool SupportsType(Uri absoluteUri, Type type)
		{
			if (absoluteUri == null)
			{
				throw new ArgumentNullException("absoluteUri");
			}
			return type == null || type == typeof(Stream);
		}

		/// <summary>
		///         Асинхронно сопоставляет URI с объектом, содержащим фактический ресурс.
		///       </summary>
		/// <param name="absoluteUri">
		///           URI, возвращаемый методом <see cref="M:System.Xml.XmlResolver.ResolveUri(System.Uri,System.String)" />.
		///         </param>
		/// <param name="role">
		///           В настоящий момент не используется.
		///         </param>
		/// <param name="ofObjectToReturn">
		///           Тип возвращаемого объекта.
		///            В текущей версии возвращаются только объекты <see cref="T:System.IO.Stream" />.
		///         </param>
		/// <returns>
		///         Объект потока или значение <see langword="null" />, если в качестве типа не указан поток.
		///       </returns>
		// Token: 0x060015AB RID: 5547 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			throw new NotImplementedException();
		}
	}
}
