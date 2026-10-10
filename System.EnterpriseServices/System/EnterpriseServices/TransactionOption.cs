using System;

namespace System.EnterpriseServices
{
	/// <summary>Указывает тип автоматической транзакции, запрошенной компонентом.</summary>
	// Token: 0x02000053 RID: 83
	[Serializable]
	public enum TransactionOption
	{
		/// <summary>Игнорирует любые транзакции в текущем контексте.</summary>
		// Token: 0x040000A2 RID: 162
		Disabled,
		/// <summary>Создает компонент в контексте без управляющей транзакции.</summary>
		// Token: 0x040000A3 RID: 163
		NotSupported,
		/// <summary>Совместно использует транзакцию, если она существует.</summary>
		// Token: 0x040000A4 RID: 164
		Supported,
		/// <summary>Совместно использует транзакцию (если она существует) и при необходимости создает новую транзакцию.</summary>
		// Token: 0x040000A5 RID: 165
		Required,
		/// <summary>Создает компонент с новой транзакцией, независимо от состояния текущего контекста.</summary>
		// Token: 0x040000A6 RID: 166
		RequiresNew
	}
}
