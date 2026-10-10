using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Включает или отключает активацию по требованию (JIT). Этот класс не наследуется.</summary>
	// Token: 0x02000032 RID: 50
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(false)]
	public sealed class JustInTimeActivationAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.JustInTimeActivationAttribute" />. Конструктор, используемый по умолчанию, включает JIT-активацию.</summary>
		// Token: 0x06000098 RID: 152 RVA: 0x0000239C File Offset: 0x0000059C
		public JustInTimeActivationAttribute() : this(true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.JustInTimeActivationAttribute" /> и при необходимости разрешает отключение JIT-активации путем передачи значения <see langword="false" /> в качестве параметра.</summary>
		/// <param name="val">Значение <see langword="true" /> для включения JIT-активации; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06000099 RID: 153 RVA: 0x000023A5 File Offset: 0x000005A5
		public JustInTimeActivationAttribute(bool val)
		{
			this.val = val;
		}

		/// <summary>Возвращает значение параметра <see cref="T:System.EnterpriseServices.JustInTimeActivationAttribute" />.</summary>
		/// <returns>Значение <see langword="true" />, если JIT-активация включена; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000023B4 File Offset: 0x000005B4
		public bool Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x0400006C RID: 108
		private bool val;
	}
}
