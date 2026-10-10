using System;
using System.Configuration;

namespace System.Transactions.Configuration
{
	/// <summary>Представляет раздел XML в файле конфигурации, содержащий значения транзакции по умолчанию. Этот класс не наследуется.</summary>
	// Token: 0x0200002D RID: 45
	public class DefaultSettingsSection : ConfigurationSection
	{
		/// <summary>Возвращает или задает время по умолчанию, по истечении которого происходит тайм-аут транзакции.</summary>
		/// <returns>Объект <see cref="T:System.TimeSpan" />. Значение по умолчанию — 00:01:00.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Выполняется попытка присвоить этому свойству отрицательное значение.</exception>
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000033AE File Offset: 0x000015AE
		// (set) Token: 0x060000DE RID: 222 RVA: 0x000033C0 File Offset: 0x000015C0
		[TimeSpanValidator(MinValueString = "00:00:00", MaxValueString = "10675199.02:48:05.4775807")]
		[ConfigurationProperty("timeout", DefaultValue = "00:01:00")]
		public TimeSpan Timeout
		{
			get
			{
				return (TimeSpan)base["timeout"];
			}
			set
			{
				base["timeout"] = value;
			}
		}

		/// <summary>Получает имя диспетчера транзакций.</summary>
		/// <returns>Имя диспетчера транзакций. Значение по умолчанию - пустая строка.</returns>
		/// <exception cref="T:System.NotSupportedException">Предпринята попытка присвоить этому свойству полные доменные имена или IP-адреса.</exception>
		/// <exception cref="T:System.Transactions.TransactionAbortedException">Предпринята попытка присвоить этому свойству значение localhost.</exception>
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000033D3 File Offset: 0x000015D3
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000033E5 File Offset: 0x000015E5
		[ConfigurationProperty("distributedTransactionManagerName", DefaultValue = "")]
		public string DistributedTransactionManagerName
		{
			get
			{
				return base["distributedTransactionManagerName"] as string;
			}
			set
			{
				base["distributedTransactionManagerName"] = value;
			}
		}
	}
}
