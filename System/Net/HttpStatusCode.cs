using System;

namespace System.Net
{
	/// <summary>Содержит значения кодов состояний, определенных для протокола HTTP.</summary>
	// Token: 0x0200057A RID: 1402
	public enum HttpStatusCode
	{
		/// <summary>Эквивалент HTTP-состояния 100. <see cref="F:System.Net.HttpStatusCode.Continue" /> указывает, что клиент может продолжать выполнять свой запрос.</summary>
		// Token: 0x0400189E RID: 6302
		Continue = 100,
		/// <summary>Эквивалент HTTP-состояния 101. <see cref="F:System.Net.HttpStatusCode.SwitchingProtocols" /> указывает, что изменяется протокол или версия протокола.</summary>
		// Token: 0x0400189F RID: 6303
		SwitchingProtocols,
		// Token: 0x040018A0 RID: 6304
		Processing,
		// Token: 0x040018A1 RID: 6305
		EarlyHints,
		/// <summary>Эквивалент HTTP-состояния 200. <see cref="F:System.Net.HttpStatusCode.OK" /> указывает, что запрос завершился успешно и запрашиваемые данные находятся в ответе. Это наиболее часто получаемый код состояния.</summary>
		// Token: 0x040018A2 RID: 6306
		OK = 200,
		/// <summary>Эквивалент HTTP-состояния 201. <see cref="F:System.Net.HttpStatusCode.Created" /> указывает, что запрос привел к созданию нового ресурса до того, как был послан ответ.</summary>
		// Token: 0x040018A3 RID: 6307
		Created,
		/// <summary>Эквивалент HTTP-состояния 202. Значение <see cref="F:System.Net.HttpStatusCode.Accepted" /> указывает, что запрос принят для дальнейшей обработки.</summary>
		// Token: 0x040018A4 RID: 6308
		Accepted,
		/// <summary>Эквивалент HTTP-состояния 203. <see cref="F:System.Net.HttpStatusCode.NonAuthoritativeInformation" /> указывает, что возвращенные метаданные взяты из кэшированной копии вместо исходного сервера и поэтому могут быть неверными.</summary>
		// Token: 0x040018A5 RID: 6309
		NonAuthoritativeInformation,
		/// <summary>Эквивалент HTTP-состояния 204. <see cref="F:System.Net.HttpStatusCode.NoContent" /> указывает, что запрос успешно обработан и ответ является преднамеренно пустым.</summary>
		// Token: 0x040018A6 RID: 6310
		NoContent,
		/// <summary>Эквивалент HTTP-состояния 205. <see cref="F:System.Net.HttpStatusCode.ResetContent" /> указывает, что клиент должен сбросить (не перезагрузить) текущий ресурс.</summary>
		// Token: 0x040018A7 RID: 6311
		ResetContent,
		/// <summary>Эквивалент HTTP-состояния 206. Значение <see cref="F:System.Net.HttpStatusCode.PartialContent" /> указывает, что ответ является частичным ответом на запрос GET, содержащий диапазон байтов.</summary>
		// Token: 0x040018A8 RID: 6312
		PartialContent,
		// Token: 0x040018A9 RID: 6313
		MultiStatus,
		// Token: 0x040018AA RID: 6314
		AlreadyReported,
		// Token: 0x040018AB RID: 6315
		IMUsed = 226,
		/// <summary>Эквивалент HTTP-состояния 300. <see cref="F:System.Net.HttpStatusCode.MultipleChoices" /> указывает, что запрашиваемые данные имеют несколько представлений. Действие, выполняемое по умолчанию, состоит в перенаправлении и отслеживании данных заголовка Location, связанного с этим ответом.</summary>
		// Token: 0x040018AC RID: 6316
		MultipleChoices = 300,
		/// <summary>Эквивалент HTTP-состояния 300. <see cref="F:System.Net.HttpStatusCode.Ambiguous" /> указывает, что запрашиваемые данные имеют несколько представлений. Действие, выполняемое по умолчанию, состоит в перенаправлении и отслеживании данных заголовка Location, связанного с этим ответом.</summary>
		// Token: 0x040018AD RID: 6317
		Ambiguous = 300,
		/// <summary>Эквивалент HTTP-состояния 301. <see cref="F:System.Net.HttpStatusCode.MovedPermanently" /> указывает, что запрашиваемые данные перемещены по универсальному коду ресурса (URI), заданному в заголовке Location. Действие, выполняемое по умолчанию при получении этого состояния, состоит в отслеживании заголовка Location, связанного с ответом.</summary>
		// Token: 0x040018AE RID: 6318
		MovedPermanently,
		/// <summary>Эквивалент HTTP-состояния 301. <see cref="F:System.Net.HttpStatusCode.Moved" /> указывает, что запрашиваемые данные перемещены по универсальному коду ресурса (URI), заданному в заголовке Location. Действие, выполняемое по умолчанию при получении этого состояния, состоит в отслеживании заголовка Location, связанного с ответом. Если для исходного запроса использовался метод POST, перенаправляемый запрос будет использовать метод GET.</summary>
		// Token: 0x040018AF RID: 6319
		Moved = 301,
		/// <summary>Эквивалент HTTP-состояния 302. <see cref="F:System.Net.HttpStatusCode.Found" /> указывает, что запрашиваемые данные расположены по универсальному коду ресурса (URI), заданному в заголовке Location. Действие, выполняемое по умолчанию при получении этого состояния, состоит в отслеживании заголовка Location, связанного с ответом. Если для исходного запроса использовался метод POST, перенаправляемый запрос будет использовать метод GET.</summary>
		// Token: 0x040018B0 RID: 6320
		Found,
		/// <summary>Эквивалент HTTP-состояния 302. <see cref="F:System.Net.HttpStatusCode.Redirect" /> указывает, что запрашиваемые данные расположены по универсальному коду ресурса (URI), заданному в заголовке Location. Действие, выполняемое по умолчанию при получении этого состояния, состоит в отслеживании заголовка Location, связанного с ответом. Если для исходного запроса использовался метод POST, перенаправляемый запрос будет использовать метод GET.</summary>
		// Token: 0x040018B1 RID: 6321
		Redirect = 302,
		/// <summary>Эквивалент HTTP-состояния 303. Значение <see cref="F:System.Net.HttpStatusCode.SeeOther" /> приводит к автоматическому перенаправлению клиента на универсальный код ресурса (URI), заданный в заголовке Location, в результате выполнения запроса POST. Запрос ресурса, задаваемого заголовком Location, выполняется с помощью метода GET.</summary>
		// Token: 0x040018B2 RID: 6322
		SeeOther,
		/// <summary>Эквивалент HTTP-состояния 303. Значение <see cref="F:System.Net.HttpStatusCode.RedirectMethod" /> приводит к автоматическому перенаправлению клиента на универсальный код ресурса (URI), заданный в заголовке Location, в результате выполнения запроса POST. Запрос ресурса, задаваемого заголовком Location, выполняется с помощью метода GET.</summary>
		// Token: 0x040018B3 RID: 6323
		RedirectMethod = 303,
		/// <summary>Эквивалент HTTP-состояния 304. <see cref="F:System.Net.HttpStatusCode.NotModified" /> указывает, что клиентская кэшированная копия является самой новой. Данные ресурса не пересылаются.</summary>
		// Token: 0x040018B4 RID: 6324
		NotModified,
		/// <summary>Эквивалент HTTP-состояния 305. <see cref="F:System.Net.HttpStatusCode.UseProxy" /> указывает, что запрос должен использовать прокси-сервер по универсальному коду ресурса (URI), заданному в заголовке Location.</summary>
		// Token: 0x040018B5 RID: 6325
		UseProxy,
		/// <summary>Эквивалент HTTP-состояния 306. <see cref="F:System.Net.HttpStatusCode.Unused" /> является предлагаемым расширением спецификации HTTP/1.1, которая полностью не определена.</summary>
		// Token: 0x040018B6 RID: 6326
		Unused,
		/// <summary>Эквивалент HTTP-состояния 307. Значение <see cref="F:System.Net.HttpStatusCode.TemporaryRedirect" /> указывает, что данные запроса расположены по универсальному коду ресурса (URI), заданному в заголовке Location. Действие, выполняемое по умолчанию при получении этого состояния, состоит в отслеживании заголовка Location, связанного с ответом. Если для исходного запроса использовался метод POST, перенаправляемый запрос будет также использовать метод POST.</summary>
		// Token: 0x040018B7 RID: 6327
		TemporaryRedirect,
		/// <summary>Эквивалент HTTP-состояния 307. Значение <see cref="F:System.Net.HttpStatusCode.RedirectKeepVerb" /> указывает, что данные запроса расположены по универсальному коду ресурса (URI), заданному в заголовке Location. Действие, выполняемое по умолчанию при получении этого состояния, состоит в отслеживании заголовка Location, связанного с ответом. Если для исходного запроса использовался метод POST, перенаправляемый запрос будет также использовать метод POST.</summary>
		// Token: 0x040018B8 RID: 6328
		RedirectKeepVerb = 307,
		// Token: 0x040018B9 RID: 6329
		PermanentRedirect,
		/// <summary>Эквивалент HTTP-состояния 400. <see cref="F:System.Net.HttpStatusCode.BadRequest" /> указывает, что запрос не может быть воспринят сервером. <see cref="F:System.Net.HttpStatusCode.BadRequest" /> посылается, когда не применима любая другая ошибка или ошибка является неизвестной либо не имеет собственного кода ошибки.</summary>
		// Token: 0x040018BA RID: 6330
		BadRequest = 400,
		/// <summary>Эквивалент HTTP-состояния 401. Значение <see cref="F:System.Net.HttpStatusCode.Unauthorized" /> указывает, что для запрашиваемого ресурса требуется аутентификация. В заголовке WWW-Authenticate подробно излагается порядок выполнения проверки подлинности.</summary>
		// Token: 0x040018BB RID: 6331
		Unauthorized,
		/// <summary>Эквивалент HTTP-состояния 402. <see cref="F:System.Net.HttpStatusCode.PaymentRequired" /> зарезервирован для дальнейшего использования.</summary>
		// Token: 0x040018BC RID: 6332
		PaymentRequired,
		/// <summary>Эквивалент HTTP-состояния 403. <see cref="F:System.Net.HttpStatusCode.Forbidden" /> указывает, что сервер отказывается выполнять запрос.</summary>
		// Token: 0x040018BD RID: 6333
		Forbidden,
		/// <summary>Эквивалент HTTP-состояния 404. <see cref="F:System.Net.HttpStatusCode.NotFound" /> указывает, что запрашиваемый ресурс отсутствует на сервере.</summary>
		// Token: 0x040018BE RID: 6334
		NotFound,
		/// <summary>Эквивалент HTTP-состояния 405. <see cref="F:System.Net.HttpStatusCode.MethodNotAllowed" /> указывает, что метод запроса (POST или GET) не разрешен для запрашиваемого ресурса.</summary>
		// Token: 0x040018BF RID: 6335
		MethodNotAllowed,
		/// <summary>Эквивалент HTTP-состояния 406. <see cref="F:System.Net.HttpStatusCode.NotAcceptable" /> указывает, что клиент показывает с помощью заголовков Accept, что он не принимает любые из доступных представлений ресурса.</summary>
		// Token: 0x040018C0 RID: 6336
		NotAcceptable,
		/// <summary>Эквивалент HTTP-состояния 407. <see cref="F:System.Net.HttpStatusCode.ProxyAuthenticationRequired" /> указывает, что запрашиваемый прокси требует прохождения проверки подлинности. В заголовке Proxy-authenticate подробно излагается порядок выполнения проверки подлинности.</summary>
		// Token: 0x040018C1 RID: 6337
		ProxyAuthenticationRequired,
		/// <summary>Эквивалент HTTP-состояния 408. <see cref="F:System.Net.HttpStatusCode.RequestTimeout" /> указывает, что клиент не послал запрос в пределах времени, когда запрос ожидался сервером.</summary>
		// Token: 0x040018C2 RID: 6338
		RequestTimeout,
		/// <summary>Эквивалент HTTP-состояния 409. <see cref="F:System.Net.HttpStatusCode.Conflict" /> указывает, что запрос не может быть выполнен из-за конфликта на сервере.</summary>
		// Token: 0x040018C3 RID: 6339
		Conflict,
		/// <summary>Эквивалент HTTP-состояния 410. <see cref="F:System.Net.HttpStatusCode.Gone" /> указывает, что запрашиваемый ресурс больше недоступен.</summary>
		// Token: 0x040018C4 RID: 6340
		Gone,
		/// <summary>Эквивалент HTTP-состояния 411. <see cref="F:System.Net.HttpStatusCode.LengthRequired" /> указывает, что требуемый заголовок Content-Length отсутствует.</summary>
		// Token: 0x040018C5 RID: 6341
		LengthRequired,
		/// <summary>Эквивалент HTTP-состояния 412. <see cref="F:System.Net.HttpStatusCode.PreconditionFailed" /> указывает, что условие, установленное для этого запроса, не соблюдено и запрос не может быть выполнен. Условия задаются с помощью заголовков условного запроса, таких как If-Match, If-None-Match или If-Unmodified-Since.</summary>
		// Token: 0x040018C6 RID: 6342
		PreconditionFailed,
		/// <summary>Эквивалент HTTP-состояния 413. <see cref="F:System.Net.HttpStatusCode.RequestEntityTooLarge" /> указывает, что запрос слишком велик для сервера, чтобы быть обработанным.</summary>
		// Token: 0x040018C7 RID: 6343
		RequestEntityTooLarge,
		/// <summary>Эквивалент HTTP-состояния 414. <see cref="F:System.Net.HttpStatusCode.RequestUriTooLong" /> указывает, что универсальный код ресурса (URI) слишком длинный.</summary>
		// Token: 0x040018C8 RID: 6344
		RequestUriTooLong,
		/// <summary>Эквивалент HTTP-состояния 415. <see cref="F:System.Net.HttpStatusCode.UnsupportedMediaType" /> указывает, что запрос этого типа не поддерживается.</summary>
		// Token: 0x040018C9 RID: 6345
		UnsupportedMediaType,
		/// <summary>Эквивалент HTTP-состояния 416. Значение <see cref="F:System.Net.HttpStatusCode.RequestedRangeNotSatisfiable" /> указывает, что диапазон данных, запрашиваемых из ресурса, не может быть возвращен из-за расположения начала диапазона до начала ресурса или конца диапазона после конца ресурса.</summary>
		// Token: 0x040018CA RID: 6346
		RequestedRangeNotSatisfiable,
		/// <summary>Эквивалент HTTP-состояния 417. <see cref="F:System.Net.HttpStatusCode.ExpectationFailed" /> указывает, что ожидание, заданное в заголовке Expect, не может быть выполнено сервером.</summary>
		// Token: 0x040018CB RID: 6347
		ExpectationFailed,
		// Token: 0x040018CC RID: 6348
		MisdirectedRequest = 421,
		// Token: 0x040018CD RID: 6349
		UnprocessableEntity,
		// Token: 0x040018CE RID: 6350
		Locked,
		// Token: 0x040018CF RID: 6351
		FailedDependency,
		/// <summary>Эквивалент HTTP-состояния 426. <see cref="F:System.Net.HttpStatusCode.UpgradeRequired" /> указывает, что клиент должен переключиться на другой протокол, например на TLS/1.0.</summary>
		// Token: 0x040018D0 RID: 6352
		UpgradeRequired = 426,
		// Token: 0x040018D1 RID: 6353
		PreconditionRequired = 428,
		// Token: 0x040018D2 RID: 6354
		TooManyRequests,
		// Token: 0x040018D3 RID: 6355
		RequestHeaderFieldsTooLarge = 431,
		// Token: 0x040018D4 RID: 6356
		UnavailableForLegalReasons = 451,
		/// <summary>Эквивалент HTTP-состояния 500. <see cref="F:System.Net.HttpStatusCode.InternalServerError" /> указывает, что на сервере произошла общая ошибка.</summary>
		// Token: 0x040018D5 RID: 6357
		InternalServerError = 500,
		/// <summary>Эквивалент HTTP-состояния 501. <see cref="F:System.Net.HttpStatusCode.NotImplemented" /> указывает, что сервер не поддерживает запрашиваемую функцию.</summary>
		// Token: 0x040018D6 RID: 6358
		NotImplemented,
		/// <summary>Эквивалент HTTP-состояния 502. Значение <see cref="F:System.Net.HttpStatusCode.BadGateway" /> указывает, что промежуточный прокси-сервер получил неправильный ответ от другого прокси или исходного сервера.</summary>
		// Token: 0x040018D7 RID: 6359
		BadGateway,
		/// <summary>Эквивалент HTTP-состояния 503. Значение <see cref="F:System.Net.HttpStatusCode.ServiceUnavailable" /> указывает, что сервер временно недоступен, обычно из-за высокой нагрузки или выполняемого обслуживания.</summary>
		// Token: 0x040018D8 RID: 6360
		ServiceUnavailable,
		/// <summary>Эквивалент HTTP-состояния 504. Значение <see cref="F:System.Net.HttpStatusCode.GatewayTimeout" /> указывает, что промежуточный прокси-сервер простаивает, ожидая ответа от другого прокси или исходного сервера.</summary>
		// Token: 0x040018D9 RID: 6361
		GatewayTimeout,
		/// <summary>Эквивалент HTTP-состояния 505. <see cref="F:System.Net.HttpStatusCode.HttpVersionNotSupported" /> указывает, что запрашиваемая версия HTTP не поддерживается сервером.</summary>
		// Token: 0x040018DA RID: 6362
		HttpVersionNotSupported,
		// Token: 0x040018DB RID: 6363
		VariantAlsoNegotiates,
		// Token: 0x040018DC RID: 6364
		InsufficientStorage,
		// Token: 0x040018DD RID: 6365
		LoopDetected,
		// Token: 0x040018DE RID: 6366
		NotExtended = 510,
		// Token: 0x040018DF RID: 6367
		NetworkAuthenticationRequired
	}
}
