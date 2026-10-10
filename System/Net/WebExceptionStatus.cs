using System;

namespace System.Net
{
	/// <summary>Определяет коды состояния для класса <see cref="T:System.Net.WebException" />.</summary>
	// Token: 0x02000607 RID: 1543
	public enum WebExceptionStatus
	{
		/// <summary>Ошибок не было.</summary>
		// Token: 0x04001C49 RID: 7241
		Success,
		/// <summary>Служба разрешения имен не может разрешить имя узла.</summary>
		// Token: 0x04001C4A RID: 7242
		NameResolutionFailure,
		/// <summary>С точкой удаленной службы нельзя связаться на транспортном уровне.</summary>
		// Token: 0x04001C4B RID: 7243
		ConnectFailure,
		/// <summary>От удаленного сервера не был получен полный ответ.</summary>
		// Token: 0x04001C4C RID: 7244
		ReceiveFailure,
		/// <summary>Полный запрос не был передан на удаленный сервер.</summary>
		// Token: 0x04001C4D RID: 7245
		SendFailure,
		/// <summary>Запрос являлся конвейерным запросом, и подключение было закрыто до получения запроса.</summary>
		// Token: 0x04001C4E RID: 7246
		PipelineFailure,
		/// <summary>Запрос был отменен, был вызван метод <see cref="M:System.Net.WebRequest.Abort" /> или возникла ошибка, не поддающаяся классификации. Это значение по умолчанию для свойства <see cref="P:System.Net.WebException.Status" />.</summary>
		// Token: 0x04001C4F RID: 7247
		RequestCanceled,
		/// <summary>Ответ, принятый от сервера, был завершен, но указал на ошибку на уровне протокола. Это состояние могла бы использовать, например, ошибка протокола HTTP, такая как ошибка 401 Нет доступа.</summary>
		// Token: 0x04001C50 RID: 7248
		ProtocolError,
		/// <summary>Подключение было преждевременно закрыто.</summary>
		// Token: 0x04001C51 RID: 7249
		ConnectionClosed,
		/// <summary>Сертификат сервера не может быть проверен.</summary>
		// Token: 0x04001C52 RID: 7250
		TrustFailure,
		/// <summary>При установлении подключения с использованием SSL произошла ошибка.</summary>
		// Token: 0x04001C53 RID: 7251
		SecureChannelFailure,
		/// <summary>Ответ сервера не являлся допустимым ответом HTTP.</summary>
		// Token: 0x04001C54 RID: 7252
		ServerProtocolViolation,
		/// <summary>Неожиданно закрыто подключение для запроса, задающего заголовок Keep-alive.</summary>
		// Token: 0x04001C55 RID: 7253
		KeepAliveFailure,
		/// <summary>Внутренний асинхронный запрос находится в очереди.</summary>
		// Token: 0x04001C56 RID: 7254
		Pending,
		/// <summary>В течение времени ожидания запроса ответ получен не был.</summary>
		// Token: 0x04001C57 RID: 7255
		Timeout,
		/// <summary>Служба разрешения имен не может распознать имя узла прокси-сервера.</summary>
		// Token: 0x04001C58 RID: 7256
		ProxyNameResolutionFailure,
		/// <summary>Возникло исключение неизвестного типа.</summary>
		// Token: 0x04001C59 RID: 7257
		UnknownError,
		/// <summary>Принято сообщение о превышении заданного ограничения при передаче запроса или приеме ответа сервера.</summary>
		// Token: 0x04001C5A RID: 7258
		MessageLengthLimitExceeded,
		/// <summary>Указанная запись не была найдена в кэше.</summary>
		// Token: 0x04001C5B RID: 7259
		CacheEntryNotFound,
		/// <summary>Этот запрос не разрешен политикой кэширования. В целом, это происходит в том случае, если запрос не подлежит кэшированию и действующая политика запрещает отправку запроса на сервер. Можно получить это состояние, если метод запроса подразумевает наличие основного текста, для метода запроса требуется взаимодействия с сервером или запрос содержит условный заголовок.</summary>
		// Token: 0x04001C5C RID: 7260
		RequestProhibitedByCachePolicy,
		/// <summary>Этот запрос не разрешен прокси-сервером.</summary>
		// Token: 0x04001C5D RID: 7261
		RequestProhibitedByProxy
	}
}
