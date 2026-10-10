using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Задает описание для свойства или события.</summary>
	// Token: 0x0200026D RID: 621
	[AttributeUsage(AttributeTargets.All)]
	public class MonitoringDescriptionAttribute : DescriptionAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.MonitoringDescriptionAttribute" />, используя заданное описание.</summary>
		/// <param name="description">Текст описания, определяемый приложением.</param>
		// Token: 0x060013A1 RID: 5025 RVA: 0x0002BAD4 File Offset: 0x00029CD4
		public MonitoringDescriptionAttribute(string description) : base(description)
		{
		}

		/// <summary>Получает описание текста, связанного с наблюдаемым элементом.</summary>
		/// <returns>Описание, определяемое приложением.</returns>
		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00052300 File Offset: 0x00050500
		public override string Description
		{
			get
			{
				return base.Description;
			}
		}
	}
}
