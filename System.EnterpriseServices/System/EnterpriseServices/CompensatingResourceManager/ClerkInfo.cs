using System;

namespace System.EnterpriseServices.CompensatingResourceManager
{
	/// <summary>Содержит описание активного объекта клерка компенсирующего диспетчера ресурсов (CRM).</summary>
	// Token: 0x02000071 RID: 113
	public sealed class ClerkInfo
	{
		/// <summary>Высвобождает ресурсы текущего <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkInfo" /> до их освобождения сборщиком мусора.</summary>
		// Token: 0x060001B8 RID: 440 RVA: 0x00002740 File Offset: 0x00000940
		[MonoTODO]
		~ClerkInfo()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000021E0 File Offset: 0x000003E0
		internal ClerkInfo()
		{
		}

		/// <summary>Получает идентификатор операции текущего рабочего CRM.</summary>
		/// <returns>Получает идентификатор операции текущего рабочего CRM.</returns>
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string ActivityId
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает <see cref="F:System.Runtime.InteropServices.UnmanagedType.IUnknown" /> для текущего клерка.</summary>
		/// <returns>
		///   <see cref="F:System.Runtime.InteropServices.UnmanagedType.IUnknown" /> для текущего клерка.</returns>
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public Clerk Clerk
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает программный идентификатор компенсатора CRM для текущего клерка CRM.</summary>
		/// <returns>Программный идентификатор компенсатора CRM для текущего клерка CRM.</returns>
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string Compensator
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает описание компенсатора CRM для текущего клерка CRM. Строка описания — строка, заданная с помощью метода <see langword="ICrmLogControl::RegisterCompensator" />.</summary>
		/// <returns>Описание компенсатора CRM для текущего клерка CRM.</returns>
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string Description
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает идентификатор класса экземпляра (CLSID) для текущего клерка CRM.</summary>
		/// <returns>Идентификатор CLSID экземпляра для текущего клерка CRM.</returns>
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string InstanceId
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает единицу работы транзакции для текущего клерка CRM.</summary>
		/// <returns>Единица работы транзакции для текущего клерка CRM.</returns>
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string TransactionUOW
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}
}
