using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Позволяет передать свойства контекста из интегратора COM-транзакций (COMTI — COM Transaction Integrator ) в контекст COM+.</summary>
	// Token: 0x02000016 RID: 22
	[ComVisible(false)]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class COMTIIntrinsicsAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.COMTIIntrinsicsAttribute" />, задавая для свойства <see cref="P:System.EnterpriseServices.COMTIIntrinsicsAttribute.Value" /> значение <see langword="true" />.</summary>
		// Token: 0x0600003B RID: 59 RVA: 0x000021E8 File Offset: 0x000003E8
		public COMTIIntrinsicsAttribute()
		{
			this.val = false;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.COMTIIntrinsicsAttribute" />, позволяя задавать значение свойства <see cref="P:System.EnterpriseServices.COMTIIntrinsicsAttribute.Value" />.</summary>
		/// <param name="val">Значение <see langword="true" />, если свойства контекста COMTI передаются в контекст COM+, в противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600003C RID: 60 RVA: 0x000021F7 File Offset: 0x000003F7
		public COMTIIntrinsicsAttribute(bool val)
		{
			this.val = val;
		}

		/// <summary>Возвращает значение, показывающее, передаются ли свойства контекста COMTI в контекст COM+.</summary>
		/// <returns>Значение <see langword="true" />, если свойства контекста COMTI передаются в контекст COM+, в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002206 File Offset: 0x00000406
		public bool Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x0400004A RID: 74
		private bool val;
	}
}
