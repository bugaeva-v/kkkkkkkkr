using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Включает проверку безопасности вызовов в компонент. Этот класс не наследуется.</summary>
	// Token: 0x02000017 RID: 23
	[ComVisible(false)]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ComponentAccessControlAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ComponentAccessControlAttribute" />.</summary>
		// Token: 0x0600003E RID: 62 RVA: 0x0000220E File Offset: 0x0000040E
		public ComponentAccessControlAttribute()
		{
			this.val = false;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ComponentAccessControlAttribute" /> и задает свойство <see cref="P:System.EnterpriseServices.ComponentAccessControlAttribute.Value" />, показывающее, включена ли конфигурация безопасности COM+.</summary>
		/// <param name="val">Значение <see langword="true" />, чтобы активировать проверку безопасности вызовов компонента, в противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600003F RID: 63 RVA: 0x0000221D File Offset: 0x0000041D
		public ComponentAccessControlAttribute(bool val)
		{
			this.val = val;
		}

		/// <summary>Принимает значение, показывающее, требуется ли включать проверку безопасности вызовов компонента.</summary>
		/// <returns>Значение <see langword="true" />, если требуется активировать проверку безопасности, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000222C File Offset: 0x0000042C
		public bool Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x0400004B RID: 75
		private bool val;
	}
}
