using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Задает значение синхронизации для компонента. Этот класс не наследуется.</summary>
	// Token: 0x0200004E RID: 78
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(false)]
	public sealed class SynchronizationAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.SynchronizationAttribute" /> с объектом <see cref="T:System.EnterpriseServices.SynchronizationOption" />, используемым по умолчанию.</summary>
		// Token: 0x0600014B RID: 331 RVA: 0x00002644 File Offset: 0x00000844
		public SynchronizationAttribute() : this(SynchronizationOption.Required)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.SynchronizationAttribute" /> указанным значением <see cref="T:System.EnterpriseServices.SynchronizationOption" />.</summary>
		/// <param name="val">Одно из значений <see cref="T:System.EnterpriseServices.SynchronizationOption" />.</param>
		// Token: 0x0600014C RID: 332 RVA: 0x0000264D File Offset: 0x0000084D
		public SynchronizationAttribute(SynchronizationOption val)
		{
			this.val = val;
		}

		/// <summary>Возвращает текущий параметр свойства <see cref="P:System.EnterpriseServices.SynchronizationAttribute.Value" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.SynchronizationOption" />. Значение по умолчанию — <see langword="Required" />.</returns>
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000265C File Offset: 0x0000085C
		public SynchronizationOption Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x0400008C RID: 140
		private SynchronizationOption val;
	}
}
