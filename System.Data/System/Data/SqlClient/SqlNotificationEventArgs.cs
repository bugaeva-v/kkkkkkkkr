using System;

namespace System.Data.SqlClient
{
	/// <summary>Представляет набор аргументов, передаваемых обработчику событий уведомления.</summary>
	// Token: 0x02000212 RID: 530
	public class SqlNotificationEventArgs : EventArgs
	{
		/// <summary>Создает новый экземпляр объекта <see cref="T:System.Data.SqlClient.SqlNotificationEventArgs" />.</summary>
		/// <param name="type">Значение <see cref="T:System.Data.SqlClient.SqlNotificationType" />, указывающее причину, по которой сгенерировано данное уведомление: реальное изменение или подписка.</param>
		/// <param name="info">Значение <see cref="T:System.Data.SqlClient.SqlNotificationInfo" />, указывающее причину, по которой сгенерировано данное уведомление. Это может быть реальное изменение данных в хранилище или тот факт, что уведомление стало недействительным (например, из-за таймаута).</param>
		/// <param name="source">Значение <see cref="T:System.Data.SqlClient.SqlNotificationSource" />, указывающее источник, сгенерировавший данное уведомление.</param>
		// Token: 0x060019BB RID: 6587 RVA: 0x000772B9 File Offset: 0x000754B9
		public SqlNotificationEventArgs(SqlNotificationType type, SqlNotificationInfo info, SqlNotificationSource source)
		{
			this._info = info;
			this._source = source;
			this._type = type;
		}

		/// <summary>Возвращает или задает, указывающее причину, по которой сгенерировано данное уведомление: реальное изменение или подписка.</summary>
		/// <returns>Значение, показывающее, создано ли уведомление изменением или подпиской.</returns>
		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x000772D6 File Offset: 0x000754D6
		public SqlNotificationType Type
		{
			get
			{
				return this._type;
			}
		}

		/// <summary>Получает значение, показывающее причину события уведомления, например изменение строки в базе данных или усечение таблицы.</summary>
		/// <returns>Причина события уведомления.</returns>
		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x000772DE File Offset: 0x000754DE
		public SqlNotificationInfo Info
		{
			get
			{
				return this._info;
			}
		}

		/// <summary>Получает значение, которое указывает источник, создавший уведомление, например изменение данных запроса или состояние базы данных.</summary>
		/// <returns>Источник уведомления.</returns>
		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x000772E6 File Offset: 0x000754E6
		public SqlNotificationSource Source
		{
			get
			{
				return this._source;
			}
		}

		// Token: 0x040010A6 RID: 4262
		private SqlNotificationType _type;

		// Token: 0x040010A7 RID: 4263
		private SqlNotificationInfo _info;

		// Token: 0x040010A8 RID: 4264
		private SqlNotificationSource _source;

		// Token: 0x040010A9 RID: 4265
		internal static SqlNotificationEventArgs s_notifyError = new SqlNotificationEventArgs(SqlNotificationType.Subscribe, SqlNotificationInfo.Error, SqlNotificationSource.Object);
	}
}
