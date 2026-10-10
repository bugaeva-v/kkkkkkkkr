using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет механизм обратного вызова, с помощью которого выполняется создание экземпляра службы по запросу.</summary>
	/// <param name="container">Контейнер служб, выдающий запрос на создание службы.</param>
	/// <param name="serviceType">Тип создаваемой службы.</param>
	/// <returns>Служба, заданная параметром <paramref name="serviceType" />, либо значение <see langword="null" />, если не удалось выполнить создание службы.</returns>
	// Token: 0x02000471 RID: 1137
	// (Invoke) Token: 0x0600249B RID: 9371
	public delegate object ServiceCreatorCallback(IServiceContainer container, Type serviceType);
}
