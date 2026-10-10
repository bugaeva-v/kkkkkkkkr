using System;

namespace System.Net
{
	/// <summary>Содержит глобальный экземпляр прокси-сервера по умолчанию для всех HTTP-запросов.</summary>
	// Token: 0x020005CD RID: 1485
	[Obsolete("This class has been deprecated. Please use WebRequest.DefaultWebProxy instead to access and set the global default proxy. Use 'null' instead of GetEmptyWebProxy. https://go.microsoft.com/fwlink/?linkid=14202")]
	public class GlobalProxySelection
	{
		/// <summary>Возвращает или устанавливает глобальный прокси-сервер HTTP.</summary>
		/// <returns>Объект <see cref="T:System.Net.IWebProxy" />, используемый всеми вызовами <see cref="M:System.Net.HttpWebRequest.GetResponse" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для операции задания было указано значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект не имеет разрешения на запрошенную операцию.</exception>
		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x000A5C54 File Offset: 0x000A3E54
		// (set) Token: 0x0600300B RID: 12299 RVA: 0x000A5C82 File Offset: 0x000A3E82
		public static IWebProxy Select
		{
			get
			{
				IWebProxy defaultWebProxy = WebRequest.DefaultWebProxy;
				if (defaultWebProxy == null)
				{
					return GlobalProxySelection.GetEmptyWebProxy();
				}
				WebRequest.WebProxyWrapper webProxyWrapper = defaultWebProxy as WebRequest.WebProxyWrapper;
				if (webProxyWrapper != null)
				{
					return webProxyWrapper.WebProxy;
				}
				return defaultWebProxy;
			}
			set
			{
				WebRequest.DefaultWebProxy = value;
			}
		}

		/// <summary>Возвращает пустой экземпляр прокси-сервера.</summary>
		/// <returns>Объект <see cref="T:System.Net.IWebProxy" />, не содержащий данных.</returns>
		// Token: 0x0600300C RID: 12300 RVA: 0x000A5C8A File Offset: 0x000A3E8A
		public static IWebProxy GetEmptyWebProxy()
		{
			return new EmptyWebProxy();
		}
	}
}
