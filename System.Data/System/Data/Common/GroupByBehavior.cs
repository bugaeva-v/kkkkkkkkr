using System;

namespace System.Data.Common
{
	/// <summary>Задает связь между столбцами в предложении GROUP BY и неагрегированными столбцами в списке выбора оператора SELECT.</summary>
	// Token: 0x020003A2 RID: 930
	public enum GroupByBehavior
	{
		/// <summary>Неизвестно, поддерживается ли предложение GROUP BY.</summary>
		// Token: 0x04001B91 RID: 7057
		Unknown,
		/// <summary>Предложение GROUP BY не поддерживается.</summary>
		// Token: 0x04001B92 RID: 7058
		NotSupported,
		/// <summary>Отсутствует связь между столбцами в предложении GROUP BY и неагрегированными столбцами в списке SELECT. Может выполняться группировка по любому столбцу.</summary>
		// Token: 0x04001B93 RID: 7059
		Unrelated,
		/// <summary>Предложение GROUP BY должно содержать все неагрегированные столбцы в списке выбора и может содержать другие столбцы не в списке выбора.</summary>
		// Token: 0x04001B94 RID: 7060
		MustContainAll,
		/// <summary>Предложение GROUP BY должно содержать все неагрегированные столбцы в списке выбора и не должно содержать другие столбцы не в списке выбора.</summary>
		// Token: 0x04001B95 RID: 7061
		ExactMatch
	}
}
