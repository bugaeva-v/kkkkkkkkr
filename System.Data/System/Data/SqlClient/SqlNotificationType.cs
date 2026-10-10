using System;

namespace System.Data.SqlClient
{
	/// <summary>Определяет разные типы уведомлений, которые могут быть получены обработчиком события <see cref="T:System.Data.SqlClient.OnChangeEventHandler" /> в параметре <see cref="T:System.Data.SqlClient.SqlNotificationEventArgs" />.</summary>
	// Token: 0x02000215 RID: 533
	public enum SqlNotificationType
	{
		/// <summary>Изменились данные на отслеживаемом сервере. Используйте элемент <see cref="T:System.Data.SqlClient.SqlNotificationInfo" /> для получения подробных сведений об изменении.</summary>
		// Token: 0x040010CB RID: 4299
		Change,
		/// <summary>Не удалось создать подписку на уведомление. Для определения причины неудачи используйте входящий в состав объекта <see cref="T:System.Data.SqlClient.SqlNotificationEventArgs" /> элемент <see cref="T:System.Data.SqlClient.SqlNotificationInfo" />.</summary>
		// Token: 0x040010CC RID: 4300
		Subscribe,
		/// <summary>Используется, когда отправленный сервером параметр типа не распознан клиентом.</summary>
		// Token: 0x040010CD RID: 4301
		Unknown = -1
	}
}
