using System;

namespace System.Net
{
	/// <summary>Предоставляет базовый интерфейс для создания экземпляров класса <see cref="T:System.Net.WebRequest" />.</summary>
	// Token: 0x020005DA RID: 1498
	public interface IWebRequestCreate
	{
		/// <summary>Создает экземпляр <see cref="T:System.Net.WebRequest" />.</summary>
		/// <param name="uri">Универсальный код ресурса (URI) веб-ресурса.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.WebRequest" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Схема запроса, заданная в <paramref name="uri" />, не поддерживается этим экземпляром <see cref="T:System.Net.IWebRequestCreate" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="uri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.UriFormatException">Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.FormatException" />.  
		///
		///
		///
		///
		/// Код URI, заданный в <paramref name="uri" />, является недопустимым.</exception>
		// Token: 0x06003036 RID: 12342
		WebRequest Create(Uri uri);
	}
}
