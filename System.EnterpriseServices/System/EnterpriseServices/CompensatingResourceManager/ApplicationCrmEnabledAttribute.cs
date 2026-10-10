using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.CompensatingResourceManager
{
	/// <summary>Включает компенсирующий диспетчер ресурсов (CRM) в приложениях с тегами.</summary>
	// Token: 0x0200006F RID: 111
	[AttributeUsage(AttributeTargets.Assembly)]
	[ComVisible(false)]
	[ProgId("System.EnterpriseServices.Crm.ApplicationCrmEnabledAttribute")]
	public sealed class ApplicationCrmEnabledAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ApplicationCrmEnabledAttribute" />, задавая для свойства <see cref="P:System.EnterpriseServices.CompensatingResourceManager.ApplicationCrmEnabledAttribute.Value" /> значение <see langword="true" />.</summary>
		// Token: 0x060001AC RID: 428 RVA: 0x000026ED File Offset: 0x000008ED
		public ApplicationCrmEnabledAttribute()
		{
			this.val = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.CompensatingResourceManager.ApplicationCrmEnabledAttribute" />, при необходимости устанавливая для свойства <see cref="P:System.EnterpriseServices.CompensatingResourceManager.ApplicationCrmEnabledAttribute.Value" /> значение <see langword="false" />.</summary>
		/// <param name="val">Значение <see langword="true" /> позволяет включить диспетчер CRM, а значение <see langword="false" /> — отключить.</param>
		// Token: 0x060001AD RID: 429 RVA: 0x000026FC File Offset: 0x000008FC
		public ApplicationCrmEnabledAttribute(bool val)
		{
			this.val = val;
		}

		/// <summary>Включает или отключает диспетчер CRM в приложениях с тегами.</summary>
		/// <returns>Принимает значение <see langword="true" />, если диспетчер CRM включен, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000270B File Offset: 0x0000090B
		public bool Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x040000B7 RID: 183
		private bool val;
	}
}
