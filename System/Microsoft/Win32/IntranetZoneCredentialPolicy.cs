using System;
using System.Net;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;

namespace Microsoft.Win32
{
	/// <summary>Определяет политику учетных данных, используемую для запросов, создаваемых с помощью <see cref="T:System.Net.WebRequest" /> и соответствующих производных классов.</summary>
	// Token: 0x0200011E RID: 286
	public class IntranetZoneCredentialPolicy : ICredentialPolicy
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:Microsoft.Win32.IntranetZoneCredentialPolicy" />.</summary>
		// Token: 0x060006C3 RID: 1731 RVA: 0x0000219B File Offset: 0x0000039B
		[SecurityPermission(SecurityAction.Demand, ControlPolicy = true)]
		public IntranetZoneCredentialPolicy()
		{
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, показывающее, отправляются ли учетные данные клиента с запросом ресурса, выполненным с помощью <see cref="T:System.Net.WebRequest" />.</summary>
		/// <param name="challengeUri">Адрес <see cref="T:System.Uri" />, который получит этот запрос.</param>
		/// <param name="request">Запрос <see cref="T:System.Net.WebRequest" />, представляющий запрашиваемый ресурс.</param>
		/// <param name="credential">Учетные данные <see cref="T:System.Net.NetworkCredential" />, которые будут отправлены с запросом, если этот метод возвращает значение <see langword="true" />.</param>
		/// <param name="authModule">Модуль <see cref="T:System.Net.IAuthenticationModule" />, который будет выполнять проверку подлинности, если проверка подлинности является необходимой.</param>
		/// <returns>Значение <see langword="true" />, если запрошенный ресурс и клиент, выполнивший запрос, находятся в одном домене, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060006C4 RID: 1732 RVA: 0x0001367F File Offset: 0x0001187F
		public virtual bool ShouldSendCredential(Uri challengeUri, WebRequest request, NetworkCredential credential, IAuthenticationModule authModule)
		{
			return Zone.CreateFromUrl(challengeUri.AbsoluteUri).SecurityZone == SecurityZone.Intranet;
		}
	}
}
