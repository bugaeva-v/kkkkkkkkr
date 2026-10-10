using System;

namespace System.Configuration
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Configuration.ApplicationSettingsBase.SettingsLoaded" />.</summary>
	// Token: 0x020001C8 RID: 456
	public class SettingsLoadedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsLoadedEventArgs" />.</summary>
		/// <param name="provider">
		///   <see cref="T:System.Configuration.SettingsProvider" /> объект, параметры которого загружены.</param>
		// Token: 0x06000BF1 RID: 3057 RVA: 0x00031E41 File Offset: 0x00030041
		public SettingsLoadedEventArgs(SettingsProvider provider)
		{
			this.provider = provider;
		}

		/// <summary>Возвращает параметры поставщика, используемые для хранения параметров конфигурации.</summary>
		/// <returns>Поставщик параметров.</returns>
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00031E50 File Offset: 0x00030050
		public SettingsProvider Provider
		{
			get
			{
				return this.provider;
			}
		}

		// Token: 0x04000799 RID: 1945
		private SettingsProvider provider;
	}
}
