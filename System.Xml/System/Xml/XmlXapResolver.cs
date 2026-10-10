using System;
using System.ComponentModel;

namespace System.Xml
{
	/// <summary>
	///         Тип XmlXapResolver используется для разрешения ресурсов в пакет XAP приложения Silverlight.
	///       </summary>
	// Token: 0x0200024A RID: 586
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class XmlXapResolver : XmlResolver
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlXapResolver" />.
		///       </summary>
		// Token: 0x060015BF RID: 5567 RVA: 0x000021F2 File Offset: 0x000003F2
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public XmlXapResolver()
		{
		}

		/// <summary>
		///         Сопоставляет URI с объектом, содержащим фактический ресурс.
		///       </summary>
		/// <param name="absoluteUri">
		///           URI, возвращаемый методом <see cref="M:System.Xml.XmlResolver.ResolveUri(System.Uri,System.String)" />.
		///         </param>
		/// <param name="role">
		///           При разрешении URI текущей версии этот параметр не используется.
		///            Это используется с целью расширения среды.
		///            Например, это может быть сопоставлен xlink: роли и используется в качестве аргумента реализацию в других сценариях.
		///         </param>
		/// <param name="ofObjectToReturn">
		///           Тип возвращаемого объекта.
		///            В текущей версии возвращаются только объекты <see cref="T:System.IO.Stream" />.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.IO.Stream" />.
		///          Если поток не найден, выдается исключение.
		///       </returns>
		// Token: 0x060015C0 RID: 5568 RVA: 0x00084E66 File Offset: 0x00083066
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			throw new XmlException("Cannot open '{0}'. The Uri parameter must be a relative path pointing to content inside the Silverlight application's XAP package. If you need to load content from an arbitrary Uri, please see the documentation on Loading XML content using WebClient/HttpWebRequest.", absoluteUri.ToString(), null, null);
		}

		/// <summary>
		///         Регистрирует Сопоставитель поток ресурса для приложения.
		///       </summary>
		/// <param name="appStreamResolver">
		///           Системных ресурсов приложения для регистрации.
		///         </param>
		// Token: 0x060015C1 RID: 5569 RVA: 0x0000B528 File Offset: 0x00009728
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void RegisterApplicationResourceStreamResolver(IApplicationResourceStreamResolver appStreamResolver)
		{
		}
	}
}
