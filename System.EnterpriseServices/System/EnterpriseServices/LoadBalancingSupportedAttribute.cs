using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Определяет, участвует ли компонент в процессе балансировки нагрузки, если служба балансировки нагрузки компонента установлена и включена на сервере.</summary>
	// Token: 0x02000033 RID: 51
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(false)]
	public sealed class LoadBalancingSupportedAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.LoadBalancingSupportedAttribute" /> с указанием поддержки балансировки нагрузки.</summary>
		// Token: 0x0600009B RID: 155 RVA: 0x000023BC File Offset: 0x000005BC
		public LoadBalancingSupportedAttribute() : this(true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.LoadBalancingSupportedAttribute" /> и дополнительно отключает поддержку балансировки нагрузки.</summary>
		/// <param name="val">Значение <see langword="true" />, чтобы включить поддержку балансировки нагрузки; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600009C RID: 156 RVA: 0x000023C5 File Offset: 0x000005C5
		public LoadBalancingSupportedAttribute(bool val)
		{
			this.val = val;
		}

		/// <summary>Возвращает значение, указывающее, включена ли поддержка балансировки нагрузки.</summary>
		/// <returns>Значение <see langword="true" />, если поддержка балансировки нагрузки включена; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000023D4 File Offset: 0x000005D4
		public bool Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x0400006D RID: 109
		private bool val;
	}
}
