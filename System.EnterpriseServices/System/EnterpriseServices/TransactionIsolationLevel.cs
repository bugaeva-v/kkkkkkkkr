using System;

namespace System.EnterpriseServices
{
	/// <summary>Указывает значение объекта <see cref="T:System.EnterpriseServices.TransactionAttribute" />.</summary>
	// Token: 0x02000052 RID: 82
	[Serializable]
	public enum TransactionIsolationLevel
	{
		/// <summary>Уровень изоляции для компонента получается из уровня изоляции вызываемого компонента. Если это корневой компонент, используется уровень изоляции <see cref="F:System.EnterpriseServices.TransactionIsolationLevel.Serializable" />.</summary>
		// Token: 0x0400009C RID: 156
		Any,
		/// <summary>В процессе чтения данных совмещаемые блокировки сохраняются, чтобы избежать чтения измененных данных, однако данные могут быть изменены до окончания транзакции, что может стать причиной неповторяемых считываний или появления фиктивных данных.</summary>
		// Token: 0x0400009D RID: 157
		ReadCommitted = 2,
		/// <summary>Возникают совмещаемые блокировки и монопольные блокировки не выполняются.</summary>
		// Token: 0x0400009E RID: 158
		ReadUncommitted = 1,
		/// <summary>Блокировки помещаются на все данные, используемые в запросе, что предотвращает обновление данных другими пользователями. Предотвращает неповторяемое чтение, однако появление фиктивных строк остается возможным.</summary>
		// Token: 0x0400009F RID: 159
		RepeatableRead = 3,
		/// <summary>Запрещает обновление или вставку до завершения транзакции.</summary>
		// Token: 0x040000A0 RID: 160
		Serializable
	}
}
