using System;

namespace System.Diagnostics.Contracts
{
	/// <summary>Позволяет задавать параметры контракта и средств на уровне сборки, типа или метода.</summary>
	// Token: 0x020009CE RID: 2510
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	[Conditional("CONTRACTS_FULL")]
	public sealed class ContractOptionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Contracts.ContractOptionAttribute" />, используя предоставленную категорию, настройку и значение включения/отключения.</summary>
		/// <param name="category">Категория для задаваемого параметра.</param>
		/// <param name="setting">Настройка параметра.</param>
		/// <param name="enabled">Значение <see langword="true" />, чтобы включить параметр; значение <see langword="false" />, чтобы отключить параметр.</param>
		// Token: 0x06005A09 RID: 23049 RVA: 0x00133D7B File Offset: 0x00131F7B
		public ContractOptionAttribute(string category, string setting, bool enabled)
		{
			this._category = category;
			this._setting = setting;
			this._enabled = enabled;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Contracts.ContractOptionAttribute" />, используя предоставленную категорию, настройку и значение.</summary>
		/// <param name="category">Категория задаваемого параметра.</param>
		/// <param name="setting">Настройка параметра.</param>
		/// <param name="value">Значение параметра.</param>
		// Token: 0x06005A0A RID: 23050 RVA: 0x00133D98 File Offset: 0x00131F98
		public ContractOptionAttribute(string category, string setting, string value)
		{
			this._category = category;
			this._setting = setting;
			this._value = value;
		}

		/// <summary>Получает категорию параметра.</summary>
		/// <returns>Категория параметра.</returns>
		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06005A0B RID: 23051 RVA: 0x00133DB5 File Offset: 0x00131FB5
		public string Category
		{
			get
			{
				return this._category;
			}
		}

		/// <summary>Получает настройку для параметра.</summary>
		/// <returns>Настройка для параметра.</returns>
		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06005A0C RID: 23052 RVA: 0x00133DBD File Offset: 0x00131FBD
		public string Setting
		{
			get
			{
				return this._setting;
			}
		}

		/// <summary>Определяет, включен ли параметр.</summary>
		/// <returns>Значение <see langword="true" />, если параметр включен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06005A0D RID: 23053 RVA: 0x00133DC5 File Offset: 0x00131FC5
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
		}

		/// <summary>Получает значение для параметра.</summary>
		/// <returns>Значение для параметра.</returns>
		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06005A0E RID: 23054 RVA: 0x00133DCD File Offset: 0x00131FCD
		public string Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x040037A7 RID: 14247
		private string _category;

		// Token: 0x040037A8 RID: 14248
		private string _setting;

		// Token: 0x040037A9 RID: 14249
		private bool _enabled;

		// Token: 0x040037AA RID: 14250
		private string _value;
	}
}
