using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Разрешает сегменту кода, определяемому объектами <see cref="M:System.EnterpriseServices.ServiceDomain.Enter(System.EnterpriseServices.ServiceConfig)" /> и <see cref="M:System.EnterpriseServices.ServiceDomain.Leave" />, выполняться в собственном контексте и вести себя так, как если бы это были методы, которые вызываются на объекте, созданном в рамках контекста. Этот класс не наследуется.</summary>
	// Token: 0x02000047 RID: 71
	[ComVisible(false)]
	public sealed class ServiceDomain
	{
		// Token: 0x0600012C RID: 300 RVA: 0x000021E0 File Offset: 0x000003E0
		private ServiceDomain()
		{
		}

		/// <summary>Создает контекст, указанный с помощью объекта <see cref="T:System.EnterpriseServices.ServiceConfig" />, а затем помещает его в стек контекстов, чтобы сделать текущим контекстом.</summary>
		/// <param name="cfg">Объект <see cref="T:System.EnterpriseServices.ServiceConfig" />, содержащий сведения о конфигурации служб, которые должны использоваться во вложенном коде.</param>
		/// <exception cref="T:System.PlatformNotSupportedException">Объект <see cref="T:System.EnterpriseServices.ServiceConfig" /> не поддерживается текущей платформой.</exception>
		// Token: 0x0600012D RID: 301 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static void Enter(ServiceConfig cfg)
		{
			throw new NotImplementedException();
		}

		/// <summary>Вызывает сервер и политики на стороне клиента так, как если бы возвращался вызов метода. Текущий контекст затем извлекается из стека контекстов и контекст, который был запущен при вызове метода <see cref="M:System.EnterpriseServices.ServiceDomain.Enter(System.EnterpriseServices.ServiceConfig)" />, становится текущим контекстом.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.TransactionStatus" />.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Объект <see cref="T:System.EnterpriseServices.ServiceConfig" /> не поддерживается текущей платформой.</exception>
		// Token: 0x0600012E RID: 302 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static TransactionStatus Leave()
		{
			throw new NotImplementedException();
		}
	}
}
