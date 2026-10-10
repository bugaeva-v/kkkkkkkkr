using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml
{
	/// <summary>
	///         Разрешает внешние ресурсы XML, имена которых заданы с помощью универсального кода ресурса (URI).
	///       </summary>
	// Token: 0x02000248 RID: 584
	public class XmlUrlResolver : XmlResolver
	{
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x00084C14 File Offset: 0x00082E14
		private static XmlDownloadManager DownloadManager
		{
			get
			{
				if (XmlUrlResolver.s_DownloadManager == null)
				{
					object value = new XmlDownloadManager();
					Interlocked.CompareExchange<object>(ref XmlUrlResolver.s_DownloadManager, value, null);
				}
				return (XmlDownloadManager)XmlUrlResolver.s_DownloadManager;
			}
		}

		/// <summary>
		///         Задает учетные данные, используемые для проверки подлинности веб-запросов.
		///       </summary>
		/// <returns>
		///         Учетные данные, используемые для аутентификации веб-запросов.
		///          Если свойство не задано, значением по умолчанию становится <see langword="null" /> — <see langword="XmlUrlResolver" /> не имеет учетных данных пользователя.
		///       </returns>
		// Token: 0x170003D9 RID: 985
		// (set) Token: 0x060015B7 RID: 5559 RVA: 0x00084C45 File Offset: 0x00082E45
		public override ICredentials Credentials
		{
			set
			{
				this._credentials = value;
			}
		}

		/// <summary>
		///         Получает или задает сетевой прокси-сервер для базового объекта <see cref="T:System.Net.WebRequest" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Net.IWebProxy" /> для доступа к данному интернет-ресурсу.
		///       </returns>
		// Token: 0x170003DA RID: 986
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x00084C4E File Offset: 0x00082E4E
		public IWebProxy Proxy
		{
			set
			{
				this._proxy = value;
			}
		}

		/// <summary>
		///         Получает или задает политику кэширования для базового объекта <see cref="T:System.Net.WebRequest" />.
		///       </summary>
		/// <returns>
		///         Политика кэширования для базового веб-запроса.
		///       </returns>
		// Token: 0x170003DB RID: 987
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x00084C57 File Offset: 0x00082E57
		public RequestCachePolicy CachePolicy
		{
			set
			{
				this._cachePolicy = value;
			}
		}

		/// <summary>
		///         Сопоставляет код URI с объектом, содержащим фактический ресурс.
		///       </summary>
		/// <param name="absoluteUri">
		///           URI, возвращаемый методом <see cref="M:System.Xml.XmlResolver.ResolveUri(System.Uri,System.String)" />.
		///         </param>
		/// <param name="role">
		///           В настоящий момент не используется.
		///         </param>
		/// <param name="ofObjectToReturn">
		///           Тип возвращаемого объекта.
		///            В текущей реализации возвращаются только объекты <see cref="T:System.IO.Stream" />.
		///         </param>
		/// <returns>
		///         Объект потока или значение <see langword="null" />, если в качестве типа не указан поток.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             <paramref name="ofObjectToReturn" /> не является ни <see langword="null" /> ни <see langword="Stream" /> типа.
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
		// Token: 0x060015BA RID: 5562 RVA: 0x00084C60 File Offset: 0x00082E60
		public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			if (ofObjectToReturn == null || ofObjectToReturn == typeof(Stream) || ofObjectToReturn == typeof(object))
			{
				return XmlUrlResolver.DownloadManager.GetStream(absoluteUri, this._credentials, this._proxy, this._cachePolicy);
			}
			throw new XmlException("Object type is not supported.", string.Empty);
		}

		/// <summary>
		///         Разрешает абсолютный URI на основе базового и относительного URI.
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
		///         Абсолютный URI или значение <see langword="null" />, если невозможно разрешить относительный URI.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение параметра <paramref name="baseUri" /> — <see langword="null" />, или значение параметра <paramref name="relativeUri" /> — <see langword="null" />.
		///           </exception>
		// Token: 0x060015BB RID: 5563 RVA: 0x00084CC7 File Offset: 0x00082EC7
		[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
		public override Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			return base.ResolveUri(baseUri, relativeUri);
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
		///            В текущей реализации возвращаются только объекты <see cref="T:System.IO.Stream" />.
		///         </param>
		/// <returns>
		///         Объект потока или значение <see langword="null" />, если в качестве типа не указан поток.
		///       </returns>
		// Token: 0x060015BC RID: 5564 RVA: 0x00084CD4 File Offset: 0x00082ED4
		public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			XmlUrlResolver.<GetEntityAsync>d__15 <GetEntityAsync>d__;
			<GetEntityAsync>d__.<>4__this = this;
			<GetEntityAsync>d__.absoluteUri = absoluteUri;
			<GetEntityAsync>d__.ofObjectToReturn = ofObjectToReturn;
			<GetEntityAsync>d__.<>t__builder = AsyncTaskMethodBuilder<object>.Create();
			<GetEntityAsync>d__.<>1__state = -1;
			<GetEntityAsync>d__.<>t__builder.Start<XmlUrlResolver.<GetEntityAsync>d__15>(ref <GetEntityAsync>d__);
			return <GetEntityAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04001325 RID: 4901
		private static object s_DownloadManager;

		// Token: 0x04001326 RID: 4902
		private ICredentials _credentials;

		// Token: 0x04001327 RID: 4903
		private IWebProxy _proxy;

		// Token: 0x04001328 RID: 4904
		private RequestCachePolicy _cachePolicy;
	}
}
