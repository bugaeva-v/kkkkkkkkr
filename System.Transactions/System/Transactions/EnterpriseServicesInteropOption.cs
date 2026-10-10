using System;

namespace System.Transactions
{
	/// <summary>Указывает способ взаимодействия распределенных транзакций с транзакциями COM+.</summary>
	// Token: 0x02000012 RID: 18
	public enum EnterpriseServicesInteropOption
	{
		/// <summary>Между объектами <see cref="P:System.EnterpriseServices.ContextUtil.Transaction" /> и <see cref="P:System.Transactions.Transaction.Current" /> синхронизация отсутствует.</summary>
		// Token: 0x04000038 RID: 56
		None,
		/// <summary>Поиск существующего контекста COM+ и синхронизация с этим контекстом, если он существует.</summary>
		// Token: 0x04000039 RID: 57
		Automatic,
		/// <summary>Контекст <see cref="N:System.EnterpriseServices" /> (который можно найти, вызвав статический метод <see cref="P:System.EnterpriseServices.ContextUtil.Transaction" /> класса <see cref="T:System.EnterpriseServices.ContextUtil" />) и внешняя транзакция <see cref="N:System.Transactions" /> (которую можно найти, вызвав статический метод <see cref="P:System.Transactions.Transaction.Current" /> класса <see cref="T:System.Transactions.Transaction" />) всегда синхронизируются. Это приводит к снижению производительности, поскольку может потребоваться создание новых контекстов <see cref="N:System.EnterpriseServices" />.</summary>
		// Token: 0x0400003A RID: 58
		Full
	}
}
