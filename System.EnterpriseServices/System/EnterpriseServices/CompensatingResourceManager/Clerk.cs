using System;

namespace System.EnterpriseServices.CompensatingResourceManager
{
	/// <summary>Записывает транзактные действия в журнал.</summary>
	// Token: 0x02000070 RID: 112
	public sealed class Clerk
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.CompensatingResourceManager.Clerk" />.</summary>
		/// <param name="compensator">Имя компенсатора.</param>
		/// <param name="description">Описание компенсатора.</param>
		/// <param name="flags">Поразрядное сочетание значений <see cref="T:System.EnterpriseServices.CompensatingResourceManager.CompensatorOptions" />.</param>
		// Token: 0x060001AF RID: 431 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public Clerk(string compensator, string description, CompensatorOptions flags)
		{
			throw new NotImplementedException();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.CompensatingResourceManager.Clerk" />.</summary>
		/// <param name="compensator">Тип, представляющий компенсатор.</param>
		/// <param name="description">Описание компенсатора.</param>
		/// <param name="flags">Поразрядное сочетание значений <see cref="T:System.EnterpriseServices.CompensatingResourceManager.CompensatorOptions" />.</param>
		// Token: 0x060001B0 RID: 432 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public Clerk(Type compensator, string description, CompensatorOptions flags)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает число записей журнала.</summary>
		/// <returns>Число записей журнала.</returns>
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00002085 File Offset: 0x00000285
		public int LogRecordCount
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает значение, представляющее единицу работы транзакции (UOW).</summary>
		/// <returns>Идентификатор GUID, представляющий единицу работы.</returns>
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00002085 File Offset: 0x00000285
		public string TransactionUOW
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Высвобождает ресурсы текущего клерка до их освобождения сборщиком мусора.</summary>
		// Token: 0x060001B3 RID: 435 RVA: 0x00002714 File Offset: 0x00000914
		[MonoTODO]
		~Clerk()
		{
			throw new NotImplementedException();
		}

		/// <summary>Принудительно копирует все записи журнала на диск.</summary>
		// Token: 0x060001B4 RID: 436 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void ForceLog()
		{
			throw new NotImplementedException();
		}

		/// <summary>Выполняет немедленный вызов прерывания транзакции.</summary>
		// Token: 0x060001B5 RID: 437 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void ForceTransactionToAbort()
		{
			throw new NotImplementedException();
		}

		/// <summary>Не доставляет последнюю запись журнала, записанную данным экземпляром интерфейса.</summary>
		// Token: 0x060001B6 RID: 438 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void ForgetLogRecord()
		{
			throw new NotImplementedException();
		}

		/// <summary>Заносит неструктурированные записи в журнал.</summary>
		/// <param name="record">Записи, которые заносятся в журнал.</param>
		// Token: 0x060001B7 RID: 439 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void WriteLogRecord(object record)
		{
			throw new NotImplementedException();
		}
	}
}
