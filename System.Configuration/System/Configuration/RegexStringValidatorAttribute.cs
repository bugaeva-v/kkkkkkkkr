using System;

namespace System.Configuration
{
	/// <summary>Описательно инструктирует платформу .NET Framework для проверки строки на наличие свойства конфигурации, используя регулярное выражение. Этот класс не наследуется.</summary>
	// Token: 0x02000064 RID: 100
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class RegexStringValidatorAttribute : ConfigurationValidatorAttribute
	{
		/// <summary>Инициализирует новый экземпляр объекта <see cref="T:System.Configuration.RegexStringValidatorAttribute" />.</summary>
		/// <param name="regex">Строка для использования при проверке регулярного выражения.</param>
		// Token: 0x0600033B RID: 827 RVA: 0x00008F68 File Offset: 0x00007168
		public RegexStringValidatorAttribute(string regex)
		{
			this.regex = regex;
		}

		/// <summary>Возвращает строку, используемую для выполнения проверки регулярного выражения.</summary>
		/// <returns>Описательно инструктирует регулярное выражение, используемое для фильтрации строки, присвоенной декорированному свойству элемента конфигурации.</returns>
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00008F77 File Offset: 0x00007177
		public string Regex
		{
			get
			{
				return this.regex;
			}
		}

		/// <summary>Возвращает экземпляр класса <see cref="T:System.Configuration.RegexStringValidator" />.</summary>
		/// <returns>Проверяющий экземпляр <see cref="T:System.Configuration.ConfigurationValidatorBase" />.</returns>
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00008F7F File Offset: 0x0000717F
		public override ConfigurationValidatorBase ValidatorInstance
		{
			get
			{
				if (this.instance == null)
				{
					this.instance = new RegexStringValidator(this.regex);
				}
				return this.instance;
			}
		}

		// Token: 0x0400012D RID: 301
		private string regex;

		// Token: 0x0400012E RID: 302
		private ConfigurationValidatorBase instance;
	}
}
