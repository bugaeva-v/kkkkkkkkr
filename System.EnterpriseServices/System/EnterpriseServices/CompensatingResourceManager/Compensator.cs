using System;

namespace System.EnterpriseServices.CompensatingResourceManager
{
	/// <summary>Представляет базовый класс для всех компенсаторов CRM.</summary>
	// Token: 0x02000073 RID: 115
	public class Compensator : ServicedComponent
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.CompensatingResourceManager.Compensator" />.</summary>
		// Token: 0x060001C7 RID: 455 RVA: 0x00002794 File Offset: 0x00000994
		[MonoTODO]
		public Compensator()
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает значение, предоставляющее объект <see cref="T:System.EnterpriseServices.CompensatingResourceManager.Clerk" /> диспетчера CRM.</summary>
		/// <returns>Объект <see cref="T:System.EnterpriseServices.CompensatingResourceManager.Clerk" />.</returns>
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002085 File Offset: 0x00000285
		public Clerk Clerk
		{
			[MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Доставляет запись журнала в компенсатор CRM на этапе прерывания.</summary>
		/// <param name="rec">Доставляемая запись журнала.</param>
		/// <returns>Значение <see langword="true" />, если доставленную запись следует забыть; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001C9 RID: 457 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public virtual bool AbortRecord(LogRecord rec)
		{
			throw new NotImplementedException();
		}

		/// <summary>Уведомляет компенсатор CRM об этапе прерывания выполнения транзакции и о планируемой доставке записей.</summary>
		/// <param name="fRecovery">Принимает значение <see langword="true" /> для начала этапа прерывания, в противном случае — <see langword="false" />.</param>
		// Token: 0x060001CA RID: 458 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public virtual void BeginAbort(bool fRecovery)
		{
			throw new NotImplementedException();
		}

		/// <summary>Уведомляет компенсатор CRM об этапе фиксирования выполнения транзакции и о планируемой доставке записей.</summary>
		/// <param name="fRecovery">Принимает значение <see langword="true" /> для начала этапа фиксирования, в противном случае — <see langword="false" />.</param>
		// Token: 0x060001CB RID: 459 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public virtual void BeginCommit(bool fRecovery)
		{
			throw new NotImplementedException();
		}

		/// <summary>Уведомляет компенсатор CRM об этапе подготовки выполнения транзакции и о планируемой доставке записей.</summary>
		// Token: 0x060001CC RID: 460 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public virtual void BeginPrepare()
		{
			throw new NotImplementedException();
		}

		/// <summary>Срочно доставляет запись журнала на этапе фиксирования.</summary>
		/// <param name="rec">Пересылаемая запись журнала.</param>
		/// <returns>Значение <see langword="true" />, если доставленную запись следует забыть; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001CD RID: 461 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public virtual bool CommitRecord(LogRecord rec)
		{
			throw new NotImplementedException();
		}

		/// <summary>Уведомляет компенсатор CRM о получении всех записей журнала, доступных на этапе прерывания.</summary>
		// Token: 0x060001CE RID: 462 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public virtual void EndAbort()
		{
			throw new NotImplementedException();
		}

		/// <summary>Уведомляет компенсатор CRM о доставке всех записей журнала, доступных на этапе фиксирования.</summary>
		// Token: 0x060001CF RID: 463 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public virtual void EndCommit()
		{
			throw new NotImplementedException();
		}

		/// <summary>Уведомляет компенсатор CRM о получении им всех записей журнала, доступных на этапе подготовки.</summary>
		/// <returns>Значение <see langword="true" /> в случае успешного выполнения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001D0 RID: 464 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public virtual bool EndPrepare()
		{
			throw new NotImplementedException();
		}

		/// <summary>Срочно доставляет запись журнала на этапе подготовки.</summary>
		/// <param name="rec">Пересылаемая запись журнала.</param>
		/// <returns>Значение <see langword="true" />, если доставленную запись следует забыть; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060001D1 RID: 465 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public virtual bool PrepareRecord(LogRecord rec)
		{
			throw new NotImplementedException();
		}
	}
}
