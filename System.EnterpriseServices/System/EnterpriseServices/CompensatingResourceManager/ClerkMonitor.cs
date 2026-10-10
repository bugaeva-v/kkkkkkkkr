using System;
using System.Collections;

namespace System.EnterpriseServices.CompensatingResourceManager
{
	/// <summary>Содержит снимки всех активных клерков в данном процессе.</summary>
	// Token: 0x02000072 RID: 114
	public sealed class ClerkMonitor : IEnumerable
	{
		/// <summary>Высвобождает ресурсы текущего <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkMonitor" /> до их освобождения сборщиком мусора.</summary>
		// Token: 0x060001C0 RID: 448 RVA: 0x0000276C File Offset: 0x0000096C
		[MonoTODO]
		~ClerkMonitor()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkMonitor" />.</summary>
		// Token: 0x060001C1 RID: 449 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public ClerkMonitor()
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает число мониторов клерков в коллекции мониторов CRM.</summary>
		/// <returns>Число мониторов клерков в коллекции мониторов CRM.</returns>
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public int Count
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает объект <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkInfo" /> для этого <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkMonitor" />.</summary>
		/// <param name="index">Числовой индекс, идентифицирующий <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkMonitor" />.</param>
		/// <returns>Объект <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkInfo" /> для <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkMonitor" />.</returns>
		// Token: 0x17000072 RID: 114
		[MonoTODO]
		public ClerkInfo this[string index]
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает объект <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkInfo" /> для этого <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkMonitor" />.</summary>
		/// <param name="index">Целочисленный индекс, идентифицирующий <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkMonitor" />.</param>
		/// <returns>Объект <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkInfo" /> для <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ClerkMonitor" />.</returns>
		// Token: 0x17000073 RID: 115
		[MonoTODO]
		public ClerkInfo this[int index]
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает перечисление клерков в коллекции мониторов CRM.</summary>
		/// <returns>Перечислитель, описывающий клерков в коллекции.</returns>
		// Token: 0x060001C5 RID: 453 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает объект коллекции клерков, который является снимком текущего состояния клерков.</summary>
		// Token: 0x060001C6 RID: 454 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void Populate()
		{
			throw new NotImplementedException();
		}
	}
}
