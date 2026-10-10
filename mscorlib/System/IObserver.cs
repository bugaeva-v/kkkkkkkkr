using System;

namespace System
{
	/// <summary>Предоставляет механизм для получения push-уведомлений.</summary>
	/// <typeparam name="T">Объект, предоставляющий сведения об уведомлениях.</typeparam>
	// Token: 0x02000142 RID: 322
	public interface IObserver<in T>
	{
		/// <summary>Предоставляет наблюдателю новые данные.</summary>
		/// <param name="value">Текущие сведения об уведомлениях.</param>
		// Token: 0x06000C02 RID: 3074
		void OnNext(T value);

		/// <summary>Уведомляет наблюдателя о том, что у поставщика возникла ошибка.</summary>
		/// <param name="error">Объект, который предоставляет дополнительную информацию об ошибке.</param>
		// Token: 0x06000C03 RID: 3075
		void OnError(Exception error);

		/// <summary>Уведомляет наблюдателя о том, что поставщик завершил отправку push-уведомлений.</summary>
		// Token: 0x06000C04 RID: 3076
		void OnCompleted();
	}
}
