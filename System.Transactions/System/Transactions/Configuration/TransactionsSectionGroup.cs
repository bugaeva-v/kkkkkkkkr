using System;
using System.Configuration;

namespace System.Transactions.Configuration
{
	/// <summary>Представляет раздел конфигурации, инкапсулирующий и обеспечивающий обход всех XML-элементов конфигурации транзакции и атрибутов, содержащихся в этом разделе конфигурации. Этот класс не наследуется.</summary>
	// Token: 0x0200002F RID: 47
	public class TransactionsSectionGroup : ConfigurationSectionGroup
	{
		/// <summary>Обеспечивает статический доступ к объекту <see cref="T:System.Transactions.Configuration.TransactionsSectionGroup" />.</summary>
		/// <param name="config">Объект <see cref="T:System.Configuration.Configuration" />,представляющий параметры конфигурации, применимые для определенного компьютера, приложения или ресурса.</param>
		/// <returns>Объект <see cref="T:System.Transactions.Configuration.TransactionsSectionGroup" />.</returns>
		// Token: 0x060000E5 RID: 229 RVA: 0x00003420 File Offset: 0x00001620
		public static TransactionsSectionGroup GetSectionGroup(Configuration config)
		{
			if (config == null)
			{
				throw new ArgumentNullException("config");
			}
			return config.GetSectionGroup("system.transactions") as TransactionsSectionGroup;
		}

		/// <summary>Получает параметры по умолчанию, используемые для инициализации элементов и атрибутов в разделе транзакций.</summary>
		/// <returns>Объект <see cref="T:System.Transactions.Configuration.DefaultSettingsSection" />, который представляет параметры по умолчанию. По умолчанию используется объект <see cref="T:System.Transactions.Configuration.DefaultSettingsSection" />, который заполняется значениями по умолчанию.</returns>
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00003440 File Offset: 0x00001640
		[ConfigurationProperty("defaultSettings")]
		public DefaultSettingsSection DefaultSettings
		{
			get
			{
				return (DefaultSettingsSection)base.Sections["defaultSettings"];
			}
		}

		/// <summary>Получает параметры конфигурации, заданные на уровне компьютера.</summary>
		/// <returns>Объект <see cref="T:System.Transactions.Configuration.MachineSettingsSection" />, представляющий параметры конфигурации на уровне компьютера. По умолчанию используется объект <see cref="T:System.Transactions.Configuration.MachineSettingsSection" />, который заполняется значениями по умолчанию.</returns>
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00003457 File Offset: 0x00001657
		[ConfigurationProperty("machineSettings")]
		public MachineSettingsSection MachineSettings
		{
			get
			{
				return (MachineSettingsSection)base.Sections["machineSettings"];
			}
		}
	}
}
