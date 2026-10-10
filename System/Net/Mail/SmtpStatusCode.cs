using System;

namespace System.Net.Mail
{
	/// <summary>Указывает результат отправки электронной почты с помощью класса <see cref="T:System.Net.Mail.SmtpClient" />.</summary>
	// Token: 0x0200083E RID: 2110
	public enum SmtpStatusCode
	{
		/// <summary>Команды были отправлены в неправильной последовательности.</summary>
		// Token: 0x040028AC RID: 10412
		BadCommandSequence = 503,
		/// <summary>Указанный пользователь не является локальным, но служба-получатель SMTP приняла сообщение и попыталась доставить его. Этот код состояния определен в документе RFC 1123, который доступен по адресу https://www.ietf.org.</summary>
		// Token: 0x040028AD RID: 10413
		CannotVerifyUserWillAttemptDelivery = 252,
		/// <summary>Клиент не прошел проверку подлинности или не имеет право отправлять почту через указанный узел SMTP.</summary>
		// Token: 0x040028AE RID: 10414
		ClientNotPermitted = 454,
		/// <summary>Служба SMTP не может применить указанную команду.</summary>
		// Token: 0x040028AF RID: 10415
		CommandNotImplemented = 502,
		/// <summary>Служба SMTP не может применить указанный параметр команды.</summary>
		// Token: 0x040028B0 RID: 10416
		CommandParameterNotImplemented = 504,
		/// <summary>Служба SMTP не может распознать указанную команду.</summary>
		// Token: 0x040028B1 RID: 10417
		CommandUnrecognized = 500,
		/// <summary>Сообщение слишком велико для сохранения в почтовом ящике назначения.</summary>
		// Token: 0x040028B2 RID: 10418
		ExceededStorageAllocation = 552,
		/// <summary>Невозможно выполнить транзакцию. Такая ошибка возникает, если не удается найти указанный узел SMTP.</summary>
		// Token: 0x040028B3 RID: 10419
		GeneralFailure = -1,
		/// <summary>Служба вернула сообщение справки.</summary>
		// Token: 0x040028B4 RID: 10420
		HelpMessage = 214,
		/// <summary>Службе SMTP не хватает памяти для выполнения запроса.</summary>
		// Token: 0x040028B5 RID: 10421
		InsufficientStorage = 452,
		/// <summary>Служба SMTP не может выполнить запрос. Эта ошибка может возникать, если не удается разрешить IP-адрес клиента (то есть при сбое обратного просмотра). Эта ошибка также может возникнуть, если домен клиента настроен на открытую ретрансляцию и служит источником нежелательных сообщений электронной почты (спама). Дополнительные сведения см. в RFC 2505 по адресу https://www.ietf.org.</summary>
		// Token: 0x040028B6 RID: 10422
		LocalErrorInProcessing = 451,
		/// <summary>Почтовый ящик назначения уже используется.</summary>
		// Token: 0x040028B7 RID: 10423
		MailboxBusy = 450,
		/// <summary>Для указания почтового ящика назначения используется неправильный синтаксис.</summary>
		// Token: 0x040028B8 RID: 10424
		MailboxNameNotAllowed = 553,
		/// <summary>Почтовый ящик назначения не найден или недоступен.</summary>
		// Token: 0x040028B9 RID: 10425
		MailboxUnavailable = 550,
		/// <summary>Сообщение электронной почты было успешно отправлено службе SMTP.</summary>
		// Token: 0x040028BA RID: 10426
		Ok = 250,
		/// <summary>Служба SMTP закрывает канал передачи.</summary>
		// Token: 0x040028BB RID: 10427
		ServiceClosingTransmissionChannel = 221,
		/// <summary>Служба SMTP недоступна; сервер закрывает канал передачи.</summary>
		// Token: 0x040028BC RID: 10428
		ServiceNotAvailable = 421,
		/// <summary>Служба SMTP готова.</summary>
		// Token: 0x040028BD RID: 10429
		ServiceReady = 220,
		/// <summary>Служба SMTP готова получать содержимое сообщения электронной почты.</summary>
		// Token: 0x040028BE RID: 10430
		StartMailInput = 354,
		/// <summary>Используется неверный синтаксис команды или ее параметров.</summary>
		// Token: 0x040028BF RID: 10431
		SyntaxError = 501,
		/// <summary>Состояние системы или ответ системы по справке.</summary>
		// Token: 0x040028C0 RID: 10432
		SystemStatus = 211,
		/// <summary>Сбой при выполнении транзакции.</summary>
		// Token: 0x040028C1 RID: 10433
		TransactionFailed = 554,
		/// <summary>Почтовый ящик пользователя не расположен на принимающем сервере. Следует повторно отправить сообщение, используя предоставленные сведения об адресе.</summary>
		// Token: 0x040028C2 RID: 10434
		UserNotLocalTryAlternatePath = 551,
		/// <summary>Почтовый ящик пользователя не расположен на принимающем сервере; сервер пересылает сообщение электронной почты.</summary>
		// Token: 0x040028C3 RID: 10435
		UserNotLocalWillForward = 251,
		/// <summary>SMTP-сервер настроен на прием только TLS-подключений, а клиент SMTP пытается подключиться без использования TLS-подключения. Чтобы устранить эту проблему, установите для этого пользователя параметр EnableSsl=true в клиенте SMTP.</summary>
		// Token: 0x040028C4 RID: 10436
		MustIssueStartTlsFirst = 530
	}
}
