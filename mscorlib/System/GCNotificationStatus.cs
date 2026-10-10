using System;

namespace System
{
	/// <summary>Предоставляет сведения о текущей регистрации для уведомления о следующей полной сборке мусора.</summary>
	// Token: 0x020001FE RID: 510
	[Serializable]
	public enum GCNotificationStatus
	{
		/// <summary>Уведомление успешно отправлено, и регистрация не отменена.</summary>
		// Token: 0x04001540 RID: 5440
		Succeeded,
		/// <summary>Не удалось отправить уведомление по какой-либо причине.</summary>
		// Token: 0x04001541 RID: 5441
		Failed,
		/// <summary>Текущая регистрация отменена пользователем.</summary>
		// Token: 0x04001542 RID: 5442
		Canceled,
		/// <summary>Время, заданное в параметре <paramref name="millisecondsTimeout" /> для <see cref="M:System.GC.WaitForFullGCApproach(System.Int32)" /> или <see cref="M:System.GC.WaitForFullGCComplete(System.Int32)" />, истекло.</summary>
		// Token: 0x04001543 RID: 5443
		Timeout,
		/// <summary>Этот результат может быть вызван следующими причинами: отсутствует регистрация на получение уведомлений о сборке мусора, включена параллельная операция сборки мусора или время, заданное для параметра <paramref name="millisecondsTimeout" />, истекло, поэтому уведомление о сборке мусора не было получено. (Сведения об отключении параллельной сборки мусора см. в статье, посвященной параметру среды выполнения &lt;gcConcurrent&gt;.)</summary>
		// Token: 0x04001544 RID: 5444
		NotApplicable
	}
}
