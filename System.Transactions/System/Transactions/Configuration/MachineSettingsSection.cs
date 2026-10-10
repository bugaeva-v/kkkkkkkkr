using System;
using System.Configuration;

namespace System.Transactions.Configuration
{
	/// <summary>Представляет раздел XML в файле конфигурации, инкапсулирующий все параметры, которые могут быть изменены только на уровне компьютера. Этот класс не наследуется.</summary>
	// Token: 0x0200002E RID: 46
	public class MachineSettingsSection : ConfigurationSection
	{
		/// <summary>Получает максимальное разрешенное время до тайм-аута транзакции.</summary>
		/// <returns>Объект <see cref="T:System.TimeSpan" />, содержащий максимальное разрешенное время. Значение по умолчанию — 00:10:00.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Выполняется попытка присвоить этому свойству отрицательное значение.</exception>
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000033FB File Offset: 0x000015FB
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000340D File Offset: 0x0000160D
		[TimeSpanValidator(MinValueString = "00:00:00", MaxValueString = "10675199.02:48:05.4775807")]
		[ConfigurationProperty("maxTimeout", DefaultValue = "00:10:00")]
		public TimeSpan MaxTimeout
		{
			get
			{
				return (TimeSpan)base["maxTimeout"];
			}
			set
			{
				base["maxTimeout"] = value;
			}
		}
	}
}
