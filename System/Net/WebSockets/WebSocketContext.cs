using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Principal;

namespace System.Net.WebSockets
{
	/// <summary>Используется для доступа к сведениям в подтверждении WebSocket.</summary>
	// Token: 0x020007EF RID: 2031
	public abstract class WebSocketContext
	{
		/// <summary>URI, запрашиваемый клиентом WebSocket.</summary>
		/// <returns>Возвращает <see cref="T:System.Uri" />.</returns>
		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x060040B8 RID: 16568
		public abstract Uri RequestUri { get; }

		/// <summary>Заголовки HTTP, отправленные на сервер во время начала установления связи.</summary>
		/// <returns>Возвращает <see cref="T:System.Collections.Specialized.NameValueCollection" />.</returns>
		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x060040B9 RID: 16569
		public abstract NameValueCollection Headers { get; }

		/// <summary>Значение HTTP-заголовка Origin, включенного в начало установления связи.</summary>
		/// <returns>Возвращает <see cref="T:System.String" />.</returns>
		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x060040BA RID: 16570
		public abstract string Origin { get; }

		/// <summary>Значение HTTP-заголовка SecWebSocketKey, включенного в начало установления связи.</summary>
		/// <returns>Возвращает <see cref="T:System.Collections.Generic.IEnumerable`1" />.</returns>
		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x060040BB RID: 16571
		public abstract IEnumerable<string> SecWebSocketProtocols { get; }

		/// <summary>Список подпротоколов, запрошенных клиентом WebSocket.</summary>
		/// <returns>Возвращает <see cref="T:System.String" />.</returns>
		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x060040BC RID: 16572
		public abstract string SecWebSocketVersion { get; }

		/// <summary>Значение HTTP-заголовка SecWebSocketKey, включенного в начало установления связи.</summary>
		/// <returns>Возвращает <see cref="T:System.String" />.</returns>
		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x060040BD RID: 16573
		public abstract string SecWebSocketKey { get; }

		/// <summary>Файлы cookie, переданные на сервер во время начала установления связи.</summary>
		/// <returns>Возвращает <see cref="T:System.Net.CookieCollection" />.</returns>
		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x060040BE RID: 16574
		public abstract CookieCollection CookieCollection { get; }

		/// <summary>Объект, используемый для получения удостоверения, сведений проверки подлинности и ролей безопасности для клиента WebSocket.</summary>
		/// <returns>Возвращает <see cref="T:System.Security.Principal.IPrincipal" />.</returns>
		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x060040BF RID: 16575
		public abstract IPrincipal User { get; }

		/// <summary>Прошел ли клиент WebSocket проверку подлинности.</summary>
		/// <returns>Возвращает <see cref="T:System.Boolean" />.</returns>
		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x060040C0 RID: 16576
		public abstract bool IsAuthenticated { get; }

		/// <summary>Подключен ли клиент WebSocket с локального компьютера.</summary>
		/// <returns>Возвращает <see cref="T:System.Boolean" />.</returns>
		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x060040C1 RID: 16577
		public abstract bool IsLocal { get; }

		/// <summary>Защищается ли соединение WebSocket с помощью протокола SSL.</summary>
		/// <returns>Возвращает <see cref="T:System.Boolean" />.</returns>
		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x060040C2 RID: 16578
		public abstract bool IsSecureConnection { get; }

		/// <summary>Экземпляр WebSocket, используемый для взаимодействия (отправка, получение, закрытие и т. д.) с соединением WebSocket.</summary>
		/// <returns>Возвращает <see cref="T:System.Net.WebSockets.WebSocket" />.</returns>
		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x060040C3 RID: 16579
		public abstract WebSocket WebSocket { get; }
	}
}
