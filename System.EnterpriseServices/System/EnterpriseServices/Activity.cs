using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Создает действие синхронной или асинхронной пакетной работы, которое может использовать службы COM+ без необходимости создания компонента COM+. Этот класс не наследуется.</summary>
	// Token: 0x0200000B RID: 11
	[ComVisible(false)]
	public sealed class Activity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.Activity" />.</summary>
		/// <param name="cfg">Объект <see cref="T:System.EnterpriseServices.ServiceConfig" />, содержащий сведения о конфигурации для используемых служб.</param>
		/// <exception cref="T:System.PlatformNotSupportedException">Объект <see cref="T:System.EnterpriseServices.Activity" /> не поддерживается текущей платформой.</exception>
		// Token: 0x06000009 RID: 9 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public Activity(ServiceConfig cfg)
		{
			throw new NotImplementedException();
		}

		/// <summary>Запускает в асинхронном режиме указанную пакетную работу, определенную пользователем.</summary>
		/// <param name="serviceCall">Объект <see cref="T:System.EnterpriseServices.IServiceCall" />, который используется для выполнения пакетной работы.</param>
		// Token: 0x0600000A RID: 10 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void AsynchronousCall(IServiceCall serviceCall)
		{
			throw new NotImplementedException();
		}

		/// <summary>Связывает работу, определенную пользователем, с текущим потоком.</summary>
		// Token: 0x0600000B RID: 11 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void BindToCurrentThread()
		{
			throw new NotImplementedException();
		}

		/// <summary>Запускает в синхронном режиме указанную пакетную работу, определенную пользователем.</summary>
		/// <param name="serviceCall">Объект <see cref="T:System.EnterpriseServices.IServiceCall" />, который используется для выполнения пакетной работы.</param>
		// Token: 0x0600000C RID: 12 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void SynchronousCall(IServiceCall serviceCall)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отвязывает пакетную работу, отправляемую с помощью методов <see cref="M:System.EnterpriseServices.Activity.SynchronousCall(System.EnterpriseServices.IServiceCall)" /> или <see cref="M:System.EnterpriseServices.Activity.AsynchronousCall(System.EnterpriseServices.IServiceCall)" />, от потока, на котором выполняется пакетная работа.</summary>
		// Token: 0x0600000D RID: 13 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void UnbindFromThread()
		{
			throw new NotImplementedException();
		}
	}
}
