using System;

namespace System.Configuration
{
	/// <summary>Указывает специальные службы свойств параметров приложения. Этот класс не наследуется.</summary>
	// Token: 0x020001CB RID: 459
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SettingsManageabilityAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsManageabilityAttribute" />.</summary>
		/// <param name="manageability">Значение <see cref="T:System.Configuration.SettingsManageability" />, перечисляющее запрашиваемые службы.</param>
		// Token: 0x06000BF7 RID: 3063 RVA: 0x00031E58 File Offset: 0x00030058
		public SettingsManageabilityAttribute(SettingsManageability manageability)
		{
			this.manageability = manageability;
		}

		/// <summary>Возвращает набор запрошенных специальных служб.</summary>
		/// <returns>Значение, получаемое использованием логического оператора <see langword="OR" /> для объединения всех перечисленных значений <see cref="T:System.Configuration.SettingsManageability" />, соответствующих затребованным службам.</returns>
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x00031E67 File Offset: 0x00030067
		public SettingsManageability Manageability
		{
			get
			{
				return this.manageability;
			}
		}

		// Token: 0x0400079C RID: 1948
		private SettingsManageability manageability;
	}
}
