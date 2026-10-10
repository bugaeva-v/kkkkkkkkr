using System;

namespace System
{
	/// <summary>Определяет поставщика push-уведомлений.</summary>
	/// <typeparam name="T">Объект, предоставляющий сведения об уведомлениях.</typeparam>
	// Token: 0x02000141 RID: 321
	public interface IObservable<out T>
	{
		/// <summary>Уведомляет поставщика о том, что наблюдатель должен получать уведомления.</summary>
		/// <param name="observer">Объект, который должен получать уведомления.</param>
		/// <returns>Ссылка на интерфейс, позволяющий наблюдателям прекратить получение уведомлений до того, как поставщик завершит их отправку.</returns>
		// Token: 0x06000C01 RID: 3073
		IDisposable Subscribe(IObserver<T> observer);
	}
}
