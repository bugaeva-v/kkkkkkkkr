using System;
using System.Configuration;
using System.Transactions.Configuration;

namespace System.Transactions
{
	/// <summary>Содержит методы, используемые для управления транзакциями. Этот класс не наследуется.</summary>
	// Token: 0x02000025 RID: 37
	public static class TransactionManager
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00002CEC File Offset: 0x00000EEC
		static TransactionManager()
		{
			TransactionManager.defaultSettings = (ConfigurationManager.GetSection("system.transactions/defaultSettings") as DefaultSettingsSection);
			TransactionManager.machineSettings = (ConfigurationManager.GetSection("system.transactions/machineSettings") as MachineSettingsSection);
		}

		/// <summary>Получает тайм-аут по умолчанию для новых транзакций.</summary>
		/// <returns>Значение <see cref="T:System.TimeSpan" />, указывающее тайм-аут для новых транзакций.</returns>
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00002D3C File Offset: 0x00000F3C
		public static TimeSpan DefaultTimeout
		{
			get
			{
				if (TransactionManager.defaultSettings != null)
				{
					return TransactionManager.defaultSettings.Timeout;
				}
				return TransactionManager.defaultTimeout;
			}
		}

		/// <summary>Получает или задает пользовательскую фабрику транзакций.</summary>
		/// <returns>Объект <see cref="T:System.Transactions.HostCurrentTransactionCallback" />, содержащий пользовательское производство транзакций.</returns>
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000216A File Offset: 0x0000036A
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO("Not implemented")]
		public static HostCurrentTransactionCallback HostCurrentCallback
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает максимальный тайм-аут по умолчанию для новых транзакций.</summary>
		/// <returns>Значение <see cref="T:System.TimeSpan" />, указывающее максимальный тайм-аут, допустимый при создании новых транзакций.</returns>
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00002D55 File Offset: 0x00000F55
		public static TimeSpan MaximumTimeout
		{
			get
			{
				if (TransactionManager.machineSettings != null)
				{
					return TransactionManager.machineSettings.MaxTimeout;
				}
				return TransactionManager.maxTimeout;
			}
		}

		/// <summary>Уведомляет диспетчер транзакций о том, что диспетчер ресурсов, восстанавливающийся после сбоя, завершил повторное зачисление всех неразрешенных транзакций.</summary>
		/// <param name="resourceManagerIdentifier">Объект <see cref="T:System.Guid" />, однозначно определяющий ресурс, подлежащий восстановлению.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="resourceManagerIdentifier" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060000AF RID: 175 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO("Not implemented")]
		public static void RecoveryComplete(Guid resourceManagerIdentifier)
		{
			throw new NotImplementedException();
		}

		/// <summary>Повторно включает долговременного участника в список транзакции.</summary>
		/// <param name="resourceManagerIdentifier">Объект <see cref="T:System.Guid" />, однозначно определяющий диспетчер ресурсов.</param>
		/// <param name="recoveryInformation">Содержит дополнительные сведения о восстановлении.</param>
		/// <param name="enlistmentNotification">Объект ресурса, реализующий интерфейс <see cref="T:System.Transactions.IEnlistmentNotification" /> для приема уведомлений.</param>
		/// <returns>Объект <see cref="T:System.Transactions.Enlistment" />, описывающий зачисление.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="recoveryInformation" /> недопустим.  
		///
		/// или - 
		/// Сведения о диспетчере транзакций в параметре <paramref name="recoveryInformation" /> не соответствуют настроенному диспетчеру транзакций.  
		///
		/// или - 
		/// Параметр <paramref name="RecoveryInformation" /> не распознается инфраструктурой <see cref="N:System.Transactions" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Transactions.TransactionManager.RecoveryComplete(System.Guid)" /> уже вызван для указанного идентификатора <paramref name="resourceManagerIdentifier" />. Повторное зачисление отклонено.</exception>
		/// <exception cref="T:System.Transactions.TransactionException">Идентификатор <paramref name="resourceManagerIdentifier" /> не соответствует сведениям о восстановлении, указанным в параметре <paramref name="recoveryInformation" />.</exception>
		// Token: 0x060000B0 RID: 176 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO("Not implemented")]
		public static Enlistment Reenlist(Guid resourceManagerIdentifier, byte[] recoveryInformation, IEnlistmentNotification enlistmentNotification)
		{
			throw new NotImplementedException();
		}

		/// <summary>Указывает, что запущена распределенная транзакция.</summary>
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000B1 RID: 177 RVA: 0x00002D70 File Offset: 0x00000F70
		// (remove) Token: 0x060000B2 RID: 178 RVA: 0x00002DA4 File Offset: 0x00000FA4
		public static event TransactionStartedEventHandler DistributedTransactionStarted;

		// Token: 0x04000060 RID: 96
		private static DefaultSettingsSection defaultSettings;

		// Token: 0x04000061 RID: 97
		private static MachineSettingsSection machineSettings;

		// Token: 0x04000062 RID: 98
		private static TimeSpan defaultTimeout = new TimeSpan(0, 1, 0);

		// Token: 0x04000063 RID: 99
		private static TimeSpan maxTimeout = new TimeSpan(0, 10, 0);
	}
}
