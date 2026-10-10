using System;

namespace System.Net
{
	/// <summary>Представляет метод, который извещает вызывающие операторы о получении клиентом продолжения ответа.</summary>
	/// <param name="StatusCode">Числовое значение состояния HTTP, полученное с сервера.</param>
	/// <param name="httpHeaders">Заголовки, возвращенные с сервера с ответом 100-continue.</param>
	// Token: 0x020005F2 RID: 1522
	// (Invoke) Token: 0x0600306D RID: 12397
	public delegate void HttpContinueDelegate(int StatusCode, WebHeaderCollection httpHeaders);
}
