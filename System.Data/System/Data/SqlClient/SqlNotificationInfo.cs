using System;

namespace System.Data.SqlClient
{
	/// <summary>Это перечисление предоставляет дополнительную информацию о различных уведомлениях, которые могут быть получены обработчиком события зависимости.</summary>
	// Token: 0x02000213 RID: 531
	public enum SqlNotificationInfo
	{
		/// <summary>Усечены одна или несколько таблиц.</summary>
		// Token: 0x040010AB RID: 4267
		Truncate,
		/// <summary>Данные изменены инструкцией INSERT.</summary>
		// Token: 0x040010AC RID: 4268
		Insert,
		/// <summary>Данные изменены инструкцией UPDATE.</summary>
		// Token: 0x040010AD RID: 4269
		Update,
		/// <summary>Данные изменены инструкцией DELETE.</summary>
		// Token: 0x040010AE RID: 4270
		Delete,
		/// <summary>Удален базовый серверный объект, связанный с запросом.</summary>
		// Token: 0x040010AF RID: 4271
		Drop,
		/// <summary>Изменился базовый серверный объект, связанный с запросом.</summary>
		// Token: 0x040010B0 RID: 4272
		Alter,
		/// <summary>Сервер перезапущен (при перезапуске рассылаются уведомления).</summary>
		// Token: 0x040010B1 RID: 4273
		Restart,
		/// <summary>Произошла внутренняя ошибка сервера.</summary>
		// Token: 0x040010B2 RID: 4274
		Error,
		/// <summary>Задана инструкция SELECT, для которой не могут генерироваться уведомления.</summary>
		// Token: 0x040010B3 RID: 4275
		Query,
		/// <summary>Задана инструкция, для которой не могут генерироваться уведомления (например, UPDATE).</summary>
		// Token: 0x040010B4 RID: 4276
		Invalid,
		/// <summary>Параметр SET не задан необходимым образом во время подписки.</summary>
		// Token: 0x040010B5 RID: 4277
		Options,
		/// <summary>Инструкция выполнена с недопустимым уровнем изоляции (например, изоляцией снимка).</summary>
		// Token: 0x040010B6 RID: 4278
		Isolation,
		/// <summary>Объект <see langword="SqlDependency" /> устарел.</summary>
		// Token: 0x040010B7 RID: 4279
		Expired,
		/// <summary>Генерируется в результате загрузки серверных ресурсов.</summary>
		// Token: 0x040010B8 RID: 4280
		Resource,
		/// <summary>Предыдущая инструкция вызвала генерацию уведомлений о запросе для текущей транзакции.</summary>
		// Token: 0x040010B9 RID: 4281
		PreviousFire,
		/// <summary>Запрос подписки вызывает превышение максимального допустимого лимита количества шаблонов для одной из целевых таблиц.</summary>
		// Token: 0x040010BA RID: 4282
		TemplateLimit,
		/// <summary>Используется, чтобы различить причину отправки уведомления о запросе на стороне сервера.</summary>
		// Token: 0x040010BB RID: 4283
		Merge,
		/// <summary>Используется, когда отправленный сервером информационный параметр не распознан клиентом.</summary>
		// Token: 0x040010BC RID: 4284
		Unknown = -1,
		/// <summary>Объект <see langword="SqlDependency" /> уже получал уведомления, и новые команды не могут быть в него добавлены.</summary>
		// Token: 0x040010BD RID: 4285
		AlreadyChanged = -2
	}
}
