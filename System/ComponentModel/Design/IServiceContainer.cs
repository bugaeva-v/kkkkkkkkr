using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет контейнер для служб.</summary>
	// Token: 0x0200046A RID: 1130
	public interface IServiceContainer : IServiceProvider
	{
		/// <summary>Добавляет заданную службу в контейнер служб.</summary>
		/// <param name="serviceType">Тип добавляемой службы.</param>
		/// <param name="serviceInstance">Экземпляр добавляемого типа службы. Данный объект должен реализовывать или наследовать тип, определяемый параметром <paramref name="serviceType" />.</param>
		// Token: 0x06002474 RID: 9332
		void AddService(Type serviceType, object serviceInstance);

		/// <summary>Добавляет заданную службу в контейнер служб и дополнительно распространяет ее во все родительские контейнеры служб.</summary>
		/// <param name="serviceType">Тип добавляемой службы.</param>
		/// <param name="serviceInstance">Экземпляр добавляемого типа службы. Данный объект должен реализовывать или наследовать тип, определяемый параметром <paramref name="serviceType" />.</param>
		/// <param name="promote">Значение <see langword="true" />, если этот запрос следует распространить во все родительские контейнеры служб; в противном случае — <see langword="false" />.</param>
		// Token: 0x06002475 RID: 9333
		void AddService(Type serviceType, object serviceInstance, bool promote);

		/// <summary>Добавляет заданную службу в контейнер служб.</summary>
		/// <param name="serviceType">Тип добавляемой службы.</param>
		/// <param name="callback">Объект обратного вызова, используемый для создания службы. Это позволяет объявить службу доступной, однако создание объекта откладывается до запроса службы.</param>
		// Token: 0x06002476 RID: 9334
		void AddService(Type serviceType, ServiceCreatorCallback callback);

		/// <summary>Добавляет заданную службу в контейнер служб и дополнительно распространяет ее в родительские контейнеры служб.</summary>
		/// <param name="serviceType">Тип добавляемой службы.</param>
		/// <param name="callback">Объект обратного вызова, используемый для создания службы. Это позволяет объявить службу доступной, однако создание объекта откладывается до запроса службы.</param>
		/// <param name="promote">Значение <see langword="true" />, если этот запрос следует распространить во все родительские контейнеры служб; в противном случае — <see langword="false" />.</param>
		// Token: 0x06002477 RID: 9335
		void AddService(Type serviceType, ServiceCreatorCallback callback, bool promote);

		/// <summary>Удаляет службы указанного типа из контейнера служб.</summary>
		/// <param name="serviceType">Тип удаляемой службы.</param>
		// Token: 0x06002478 RID: 9336
		void RemoveService(Type serviceType);

		/// <summary>Удаляет заданный тип службы из контейнера служб и дополнительно распространяет службу в родительские контейнеры служб.</summary>
		/// <param name="serviceType">Тип удаляемой службы.</param>
		/// <param name="promote">Значение <see langword="true" />, если этот запрос следует распространить во все родительские контейнеры служб; в противном случае — <see langword="false" />.</param>
		// Token: 0x06002479 RID: 9337
		void RemoveService(Type serviceType, bool promote);
	}
}
