using System;

namespace System.Net
{
	/// <summary>Предоставляет базовый интерфейс для загрузки и выполнения скриптов автоматического обнаружения прокси-сервера.</summary>
	// Token: 0x0200069F RID: 1695
	public interface IWebProxyScript
	{
		/// <summary>Закрывает скрипт.</summary>
		// Token: 0x06003648 RID: 13896
		void Close();

		/// <summary>Загружает скрипт.</summary>
		/// <param name="scriptLocation">Только для внутреннего использования.</param>
		/// <param name="script">Только для внутреннего использования.</param>
		/// <param name="helperType">Только для внутреннего использования.</param>
		/// <returns>Объект <see cref="T:System.Boolean" />, указывающий, был ли скрипт загружен успешно.</returns>
		// Token: 0x06003649 RID: 13897
		bool Load(Uri scriptLocation, string script, Type helperType);

		/// <summary>Выполняет скрипт.</summary>
		/// <param name="url">Только для внутреннего использования.</param>
		/// <param name="host">Только для внутреннего использования.</param>
		/// <returns>Объект <see cref="T:System.String" />.  
		/// Возвращаемое только внутреннее значение.</returns>
		// Token: 0x0600364A RID: 13898
		string Run(string url, string host);
	}
}
